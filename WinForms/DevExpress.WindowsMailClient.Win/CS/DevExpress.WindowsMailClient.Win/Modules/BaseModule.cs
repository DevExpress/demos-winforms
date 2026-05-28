using System;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.WindowsMailClient.Win.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.WindowsMailClient.Win.Modules {
    public class BaseModule : XtraUserControl, ISupportViewModel {
        protected BaseModule(Type viewModelType, object viewModel)
            : this() {
            this.mvvmContext.SetViewModel(viewModelType, viewModel);
            this.BindingContext = new BindingContext();
            OnInitServices();
        }
        protected BaseModule(Type viewModelType)
            : this() {
            this.mvvmContext.ViewModelType = viewModelType;
            this.BindingContext = new BindingContext();
            OnInitServices();
        }
        protected TViewModel GetViewModel<TViewModel>() {
            return mvvmContext.GetViewModel<TViewModel>();
        }
        protected TViewModel GetParentViewModel<TViewModel>() {
            return mvvmContext.GetParentViewModel<TViewModel>();
        }
        protected TService GetService<TService>() where TService : class {
            return mvvmContext.GetService<TService>();
        }
        protected virtual void OnInitServices() { }
        object ISupportViewModel.ViewModel {
            get { return mvvmContext.GetViewModel<object>(); }
        }
        void ISupportViewModel.ParentViewModelAttached() {
            OnParentViewModelAttached();
        }
        #region for DesignTime

        void ReleaseModule() {
        }
        BaseModule() {
            InitializeComponent();
        }
        protected virtual void OnParentViewModelAttached() { }
        protected virtual void OnDisposing() { }
        System.ComponentModel.IContainer components;
        void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.SuspendLayout();
            
            
            
            this.mvvmContext.ContainerControl = this;
            
            
            
            this.Name = "BaseModule";
            this.ResumeLayout(false);
        }
        protected override void OnHandleDestroyed(EventArgs e) {
            ReleaseMVVMContext();
            base.OnHandleDestroyed(e);
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                ReleaseMVVMContext();
                OnDisposing();
                if(components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        protected virtual void OnMVVMContextReleasing() { }
        void ReleaseMVVMContext() {
            DestroyUIUpdateTimer();
            if(mvvmContext.IsViewModelCreated) {
                ReleaseModule();
                OnMVVMContextReleasing();
                mvvmContext.Dispose();
            }
        }
        Timer updateTimer;
        protected void QueueUIUpdate() {
            EnsureUIUpdateTimer();
            updateTimer.Stop();
            updateTimer.Start();
        }
        void EnsureUIUpdateTimer() {
            if(updateTimer == null) {
                updateTimer = new Timer(components);
                updateTimer.Interval = GetUIUpdateDelay();
                updateTimer.Tick += OnUIUpdate;
            }
        }
        void DestroyUIUpdateTimer() {
            if(updateTimer != null) {
                updateTimer.Tick -= OnUIUpdate;
                updateTimer.Stop();
                updateTimer.Dispose();
            }
            updateTimer = null;
        }
        void OnUIUpdate(object sender, EventArgs e) {
            updateTimer.Stop();
            OnDelayedUIUpdate();
        }
        protected virtual void OnDelayedUIUpdate() { }
        protected virtual int GetUIUpdateDelay() {
            return 250;
        }
        #endregion
    }
}
