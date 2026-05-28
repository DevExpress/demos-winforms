using System;
using DevExpress.XtraSplashScreen;

namespace DevExpress.WindowsMailClient.Win.Utils {
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
    sealed class DemoStartUp : IObserver<string> {
        FluentSplashScreenOptions options = null;
        public DemoStartUp() {
            options = new FluentSplashScreenOptions() {
                Title = "When Only The Best Will Do",
                Subtitle = "DevExpress WinForms Controls",
                RightFooter = "Starting...",
                LeftFooter = AssemblyInfo.AssemblyCopyright + Environment.NewLine + "All Rights reserved.",
                LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
                OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190),
                Opacity = 130,
            };
            options.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            options.LogoImageOptions.SvgImage = Properties.Resources.DevExpress_Logo_Mono;
        }
        void IObserver<string>.OnCompleted() {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 300, AppProvider.MainForm);
        }
        void IObserver<string>.OnNext(string status) {
            if(DevExpress.XtraSplashScreen.SplashScreenManager.Default == null) {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(options, null, AppProvider.MainForm);
            }
            else {
                options.RightFooter = status;
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, options);
            }
        }
        void IObserver<string>.OnError(Exception error) { throw error; }
    }
}
