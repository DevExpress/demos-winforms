using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevExpress.XtraGrid.Demos {
    public class ChangeThread {
        readonly BindingList<MarketData> collection = new BindingList<MarketData>();
        public IList List { get { return this.collection; } }
        public int InterEventDelay = 1024000;
        bool needStop;
        readonly SynchronizationContext context;
        readonly Stopwatch changesWatch = Stopwatch.StartNew();
        int changes;
        public double? GetRate() {
            var interval = changesWatch.Elapsed;
            if(interval == TimeSpan.Zero)
                return null;
            changesWatch.Restart();
            var currentChanges = (double)Interlocked.Exchange(ref changes, 0);
            try {
                var resultRate = currentChanges / interval.TotalSeconds;
                if(resultRate >= 0.0 && resultRate < float.MaxValue)
                    return resultRate;
            }
            catch { }
            return null;
        }
        public ChangeThread(SynchronizationContext context) {
            string[] data = new string[] {"ANR", "FE", "GT", "PRGO", "APD", "PPL", "AES", "AVB", "IBM", "GAS", "EFX", "GPC", "ICE", "IVZ", "KO", "CCE", "SO", "STI",
                "BWA", "HRL", "WFM", "LM", "TROW", "K", "EXPE", "PCAR", "TRIP", "WHR", "WMT", "NU", "HST", "CVH", "LMT", "MAR", "CVC", "RF", "VMC", "PHM", "MU", "IRM",
                "AMT", "BXP", "STT", "PBCT", "FISV", "BLL", "MTB", "DIS", "LH", "AKAM", "CPB", "MYL", "LIFE", "LEG", "SCG", "CNX", "COL", "MCHP", "GR", "DUK", "BAC",
                "NUE", "UNM", "DLTR", "ABC", "TEG", "RRD", "EQR", "EXC", "BA", "CME", "NTRS", "VTR", "FITB", "PG", "KR", "M", "SNI", "ETN", "CLF", "PH", "KEY", "SHW",
                "HD", "AFL", "TSS", "CMI", "HBAN", "AEP", "BIG", "LTD", "ESRX", "GLW", "WPI", "MON", "AAPL", "DF", "T", "CMA", "THC", "LUV", "TXN", "TIE", "PX"};

            this.context = context;
            foreach(string name in data)
                collection.Add(new MarketData(name));
        }
        public void Do() {
            var rndRow = Data.Utils.NonCryptographicRandom.Default;
            do {
                var delayPerRow = Volatile.Read(ref InterEventDelay);
                if(delayPerRow == 0) {
                    for(int i = 0; i < 1024; ++i)
                        UpdateRandomRow();
                }
                else {
                    int rows = (int)Math.Min(Math.Max(TimeSpan.TicksPerSecond / delayPerRow / 25, 1), 4096);
                    for(int i = 0; i < rows; ++i) {
                        UpdateRandomRow();
                    }
                    var totalDelay = TimeSpan.FromTicks(rows * (long)delayPerRow);
                    Stopwatch watch = Stopwatch.StartNew();
                    for(; ; ) {
                        var elapsed = watch.Elapsed;
                        if(elapsed >= totalDelay)
                            break;
                        var diffTicks = (totalDelay - elapsed).Ticks;
                        if(diffTicks > TimeSpan.TicksPerMillisecond / 100)
                            Thread.Sleep((int)(diffTicks / TimeSpan.TicksPerMillisecond));
                    }
                    watch.Stop();
                }
            } while(!Volatile.Read(ref needStop));
        }
        void UpdateRandomRow() {
            var rnd = Data.Utils.NonCryptographicRandom.Default;
            var row = rnd.Next(0, collection.Count);
            collection[row].Update();
            collection.ResetItem(row);
            Interlocked.Increment(ref changes);
        }
        public void Stop() {
            Volatile.Write(ref needStop, true);
        }
    }

    public class MarketData {
        const double MAX = 950;
        const double MIN = 350;
        public string Ticker { get; private set; }
        public double Last {
            get;
            private set;
        }
        public double ChgPercent {
            get;
            private set;
        }
        public double Chg {
            get;
            private set;
        }
        public double Open {
            get;
            private set;
        }
        public double High {
            get;
            private set;
        }
        public double Low {
            get;
            private set;
        }
        double dayValCore;
        public double DayVal {
            get { return Math.Round(dayValCore, 1); }
            private set { dayValCore = value; }
        }

        public MarketData(string name) {
            Ticker = name;
            DayVal = Open = Math.Round((NextRnd() * (MAX - MIN)) + MIN, 1);
            UpdateInternal(Open);
        }
        public void Update() {
            double value = Math.Round(DayVal - (MAX - MIN) * 0.05 + NextRnd() * (MAX - MIN) * 0.1, 1);
            if(value <= MIN)
                value = MIN;
            if(value >= MAX)
                value = MAX;
            UpdateInternal(value);
        }
        void UpdateInternal(double dayVal) {
            Last = DayVal;
            DayVal = dayVal;
            Chg = DayVal - Last;
            ChgPercent = Math.Round(Chg / DayVal * 100, 2);
            High = Math.Max(Open, Math.Max(DayVal, Last));
            Low = Math.Min(Open, Math.Min(DayVal, Last));
        }
        double NextRnd() {
            var rnd = Data.Utils.NonCryptographicRandom.Default;
            return (rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble()) / 5;
        }
    }
}
