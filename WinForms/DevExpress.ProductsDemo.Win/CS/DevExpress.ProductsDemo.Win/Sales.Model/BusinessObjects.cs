using System;
using System.Collections.Generic;

namespace DevExpress.SalesDemo.Model {
    public static class DataSource {
        static IDataProvider instance;
        public static IDataProvider GetDataProvider() {
            if(instance == null)
                EnsureDataProvider();
            return instance;
        }
        public static void EnsureDataProvider() {
            if(instance != null)
                return;
            string dbPath = Internal.DataDirectoryHelper.GetDataFile("sales.mdb");
            System.IO.File.SetAttributes(dbPath, System.IO.FileAttributes.Normal);
            var generator = new DevExpress.Demos.SalesDBGenerator.SalesGenerator();
            using(ProgressTracker.Instance.StartTracking(generator)) {
                generator.Run(OleDataProvider.GetConnectionString(dbPath));
                instance = new OleDataProvider(dbPath);
            }
        }
        public static IObservable<int> Progress {
            get { return ProgressTracker.Instance; }
        }
        #region IObservable
        sealed class ProgressTracker : IObservable<int> {
            internal static readonly ProgressTracker Instance = new ProgressTracker();
            readonly IList<IObserver<int>> observers;
            ProgressTracker() {
                observers = new List<IObserver<int>>();
            }
            public IDisposable StartTracking(IDataGenerator generator) {
                return new TrackingContext(generator, this);
            }
            IDisposable IObservable<int>.Subscribe(IObserver<int> observer) {
                return new Subscription(this, observer);
            }
            void generator_Start(object sender, ProgressEventArgs e) {
                foreach(IObserver<int> observer in observers)
                    observer.OnNext(e.Progress);
            }
            void generator_Complete(object sender, ProgressEventArgs e) {
                foreach(IObserver<int> observer in observers)
                    observer.OnCompleted();
            }
            void generator_Progress(object sender, ProgressEventArgs e) {
                foreach(IObserver<int> observer in observers)
                    observer.OnNext(e.Progress);
            }
            sealed class TrackingContext : IDisposable {
                readonly IDataGenerator generator;
                readonly ProgressTracker tracker;
                public TrackingContext(IDataGenerator generator, ProgressTracker tracker) {
                    this.generator = generator;
                    this.tracker = tracker;
                    generator.GenerationStart += OnGenerationStart;
                    generator.GenerationComplete += OnGenerationComplete;
                    generator.GenerationProgress += OnGenerationProgress;
                }
                void IDisposable.Dispose() {
                    generator.GenerationStart -= OnGenerationStart;
                    generator.GenerationComplete -= OnGenerationComplete;
                    generator.GenerationProgress -= OnGenerationProgress;
                }
                void OnGenerationStart(object sender, ProgressEventArgs e) {
                    tracker.generator_Start(sender, e);
                }
                void OnGenerationComplete(object sender, ProgressEventArgs e) {
                    tracker.generator_Complete(sender, e);
                }
                void OnGenerationProgress(object sender, ProgressEventArgs e) {
                    tracker.generator_Progress(sender, e);
                }
            }
            sealed class Subscription : IDisposable {
                readonly IObserver<int> observer;
                readonly ProgressTracker tracker;
                public Subscription(ProgressTracker tracker, IObserver<int> observer) {
                    if(!tracker.observers.Contains(observer))
                        tracker.observers.Add(observer);
                    this.tracker = tracker;
                    this.observer = observer;
                }
                void IDisposable.Dispose() {
                    tracker.observers.Remove(observer);
                }
            }
        }
        #endregion IObservable
    }
    //
    public class SalesGroup {
        public SalesGroup(string groupName, decimal totalCost, int unitsSold, DateTime startOfPeriod, DateTime endOfPeriod) {
            GroupName = groupName;
            TotalCost = totalCost;
            Units = unitsSold;
            StartOfPeriod = startOfPeriod;
            EndOfPeriod = endOfPeriod;
        }
        public string GroupName { get; }
        public decimal TotalCost { get; }
        public int Units { get; }
        public DateTime StartOfPeriod { get; }
        public DateTime EndOfPeriod { get; }
    }
    public enum GroupingPeriod {
        Hour, Day, All, None
    }
}
