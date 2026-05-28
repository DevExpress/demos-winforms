namespace DevExpress.DevAV {
    using System;

    public interface IProcess {
        event ProcessStatusEventHandler Start;
        event ProcessStatusEventHandler Running;
        event EventHandler Complete;
    }
    public delegate void ProcessStatusEventHandler(
            object sender, ProcessStatusEventArgs e
        );
    public class ProcessStatusEventArgs : EventArgs {
        public ProcessStatusEventArgs(string status) {
            Status = status;
        }
        public string Status { get; private set; }
    }
    
    sealed class StartUpProcess : IProcess, IDisposable {
        static StartUpProcess process;
        readonly IDisposable tracker;
        readonly System.ComponentModel.EventHandlerList Events;
        public StartUpProcess() {
            this.Events = new System.ComponentModel.EventHandlerList();
            process = this;
            this.tracker = StartUpProcessTracker.Instance.StartTracking(this);
        }
        void IDisposable.Dispose() {
            Events.Dispose();
            tracker.Dispose();
            process = null;
            GC.SuppressFinalize(this);
        }
        public static IObservable<string> Status {
            get { return StartUpProcessTracker.Instance; }
        }
        public static void OnStart(string status) {
            if(process != null)
                process.RaiseStart(status);
        }
        public static void OnRunning(string status) {
            if(process != null)
                process.RaiseRunning(status);
        }
        public static void OnComplete() {
            if(process != null)
                process.RaiseComplete();
        }
        #region ProcessTracker
        sealed class StartUpProcessTracker : ProcessTracker {
            internal static StartUpProcessTracker Instance = new StartUpProcessTracker();
        }
        #endregion ProcessTracker
        #region IProcess Members
        readonly static object startCore = new object();
        readonly static object runningCore = new object();
        readonly static object completeCore = new object();
        
        event ProcessStatusEventHandler IProcess.Start {
            add { Events.AddHandler(startCore, value); }
            remove { Events.RemoveHandler(startCore, value); }
        }
        event ProcessStatusEventHandler IProcess.Running {
            add { Events.AddHandler(runningCore, value); }
            remove { Events.RemoveHandler(runningCore, value); }
        }
        event EventHandler IProcess.Complete {
            add { Events.AddHandler(completeCore, value); }
            remove { Events.RemoveHandler(completeCore, value); }
        }
        void RaiseStart(string status) {
            var handler = Events[startCore] as ProcessStatusEventHandler;
            if(handler != null) handler(this, new ProcessStatusEventArgs(status));
        }
        void RaiseRunning(string status) {
            var handler = Events[runningCore] as ProcessStatusEventHandler;
            if(handler != null) handler(this, new ProcessStatusEventArgs(status));
        }
        void RaiseComplete() {
            var handler = Events[completeCore] as EventHandler;
            if(handler != null) handler(this, EventArgs.Empty);
        }
        #endregion
    }
}
