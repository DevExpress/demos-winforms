using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.WindowsMailClient.Win.Data;
using DevExpress.WindowsMailClient.Win.Modules;
using DevExpress.WindowsMailClient.Win.Services;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.XtraSplashScreen;
using Message = DevExpress.WindowsMailClient.Win.Data.Message;

namespace DevExpress.WindowsMailClient.Win.ViewModels {
    public interface ISupportModuleLayout {
        void SaveLayoutToStream(System.IO.MemoryStream ms);
        void RestoreLayoutFromStream(System.IO.MemoryStream ms);
    }
    public interface IMainModule : ISupportModuleLayout {
    }
    public class MainViewModel {
        static MainViewModel() {
            ServiceContainer.Default.RegisterService(new ModuleResourceProvider());
            ServiceContainer.Default.RegisterService(new ModuleTypesResolver());
            ServiceContainer.Default.RegisterService(new ProcessExecutionService());
            ServiceContainer.Default.RegisterService(new PanelProviderService());
        }
        public MainViewModel(IMainModule module) {
            var mainModuleType = module.GetType();
            ISupportServices localServices = (ISupportServices) this;
            localServices.ServiceContainer.RegisterService(new ModuleActivator(mainModuleType.Assembly, mainModuleType.Namespace + ".Modules"));
            localServices.ServiceContainer.RegisterService(new ModuleLocator(localServices.ServiceContainer));
            localServices.ServiceContainer.RegisterService(new ProcessExecutionService());
            localServices.ServiceContainer.RegisterService(new PanelProviderService());
            RegisterAsRecipient();
        }
        public void RegisterAsRecipient() {
            Messenger.Default.Register<Message>(this, OnGetMessage);
        }

        public ModuleType SelectedAccordionModuleType {
            get { return GetAccordionModuleType(SelectedModuleType); }
        }
        public ModuleType GetAccordionModuleType(ModuleType type) {
            var resolver = this.GetService<IModuleTypesResolver>();
            return resolver.GetAccordionModuleType(type);
        }
        #region Events

        public event EventHandler ModuleAdded;
        public event EventHandler ModuleRemoved;
        public event EventHandler SelectedModuleTypeChanged;
        public event EventHandler SelectedModuleChanged;
        public event EventHandler CurrentTagChanged;

        #endregion
        #region Commands

        public void HidePanelsAndShowAccounts() {
            HideAllPanels();
            ShowPanel(PanelType.Accounts);
        }
        [Command]
        public void StartPeople() {
            this.GetService<IProcessExecutionService>().ExecuteProcess("ms-people://");
        }
        IOverlaySplashScreenHandle progressPanelHandle = null;
        [Command]
        public void SelectModule(ModuleType moduleType) {
            try {
                HideAllPanels();
                progressPanelHandle = AppProvider.ShowProgressPanel(AppProvider.MainForm);
                if(SelectedModuleType != moduleType) {
                    SelectedModuleType = moduleType;
                }
            }
            finally {
                AppProvider.CloseProgressPanel(progressPanelHandle);
            }
        }
        [Command]
        public void SelectMailViewerModuleAndApplyDraftsFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Draft);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyOutboxFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Outbox);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyInboxFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Inbox);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyArchiveFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Archive);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyArchive1Filter() {
            SelectMailViewerModuleAndShowMessages(MailType.Archive1);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyDeletedItemsFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Deleted);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplyClutterFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Clutter);
            HideAllPanels();
        }
        [Command]
        public void SelectMailViewerModuleAndApplySentItemsFilter() {
            SelectMailViewerModuleAndShowMessages(MailType.Sent);
            HideAllPanels();
        }
        [Command]
        public void ShowPanel(PanelType panel) {
            if(panel == PanelType.Unknown) return;
            ShowFlyoutPanelCore(panel);
        }
        [Command]
        public void HidePanel(PanelType type) {
            HideFlyoutPanelCore(type);
        }
        [Command]
        public void ShowHelp() {
            this.GetService<IProcessExecutionService>().ShowDocumentation();
        }
        
        [Command]
        public void ShowPersonalization(Form mainForm) {
            HideAllPanels();
            this.GetService<IProcessExecutionService>().ShowPaletteSelector();
        }
        [Command]
        public void ShowWN() {
            this.GetService<IProcessExecutionService>().ShowWN();
        }
        [Command]
        public void ShowSignatureForm(Rectangle ownerRect) {
            HideAllPanels();
            this.GetService<IProcessExecutionService>().ShowSignatureForm();
        }
        [Command]
        public void ShowAppointmentForm() {
            var module = SelectedModule as SchedulerModule;
            if(module != null) this.GetService<IProcessExecutionService>().ShowAppointmentForm(module.Scheduler);
        }
        void SelectMailViewerModuleAndShowMessages(MailType category) {
            if(SelectedModuleType != ModuleType.MailViewer) SelectModule(ModuleType.MailViewer);
            var module = GetModule(ModuleType.MailViewer) as MailViewer;
            if(module != null) module.SetMailType(category);
        }

        #endregion
        #region Properties

        public virtual ModuleType SelectedModuleType {
            get;
            set;
        }
        public virtual object SelectedModule {
            get;
            set;
        }
        public virtual int DraftsMailCounter { get; set; }
        bool showFocusedOtherFiler = true;
        public virtual bool ShowFocusedOtherFilter {
            get {
                return showFocusedOtherFiler;
            }
            set {
                showFocusedOtherFiler = value;
                OnShowFocusedOtherFilterChanged();
            }
        }
        protected void OnShowFocusedOtherFilterChanged() {
            Messenger.Default.Send<bool>(ShowFocusedOtherFilter);
        }
        public virtual object CurrentTag { get; set; }
        protected void OnCurrentTagChanged() {
            if(CurrentTagChanged != null) {
                CurrentTagChanged(this, EventArgs.Empty);
            }
        }

        #endregion

        internal void HideFlyoutPanelCore(PanelType type) {
            this.GetService<IPanelProviderService>().HidePanel(type);
        }
        Stack<PanelType> _panelsStack;
        public virtual Stack<PanelType> PanelsStack {
            get {
                if(_panelsStack == null) _panelsStack = new Stack<PanelType>();
                return _panelsStack;
            }
        }
        internal void ShowFlyoutPanelCore(PanelType type) {
            PanelsStack.Push(type);
            this.GetService<IPanelProviderService>().ShowPanel(type);
        }

        protected virtual void OnSelectedModuleTypeChanged(ModuleType oldType) {
            try {
                SelectedModule = GetModule(SelectedModuleType);
                RaiseSelectedModuleTypeChanged();
            }
            catch(Exception e) {
                ExecuteApplicationExeption(oldType, e);
            }
        }
        void ConfigureRemovedModule(object oldModule) {
            var module = oldModule as MailModule;
            if(module != null) {
                if(module.SaveMessageToDrafts()) DraftsMailCounter++;
            }
        }
        protected virtual void OnSelectedModuleChanged(object oldModule) {
            if(oldModule != null) {
                ConfigureRemovedModule(oldModule);
                if(ModuleRemoved != null)
                    ModuleRemoved(oldModule, EventArgs.Empty);
            }
            if(SelectedModuleChanged != null)
                SelectedModuleChanged(this, EventArgs.Empty);
            if(SelectedModule != null) {
                ViewModelUtils.CheckModuleViewModel(SelectedModule, this);
                if(ModuleAdded != null)
                    ModuleAdded(SelectedModule, EventArgs.Empty);
            }
        }
        void ExecuteApplicationExeption(ModuleType oldType, Exception e) {
            var entryAsm = Assembly.GetEntryAssembly();
            string msg = "Error: [" + oldType + "=>" + SelectedModuleType + Environment.NewLine + (entryAsm != null ? "StartUp:" + entryAsm.Location : string.Empty);
            throw new ApplicationException(msg, e);
        }
        void RaiseSelectedModuleTypeChanged() {
            this.RaiseCanExecuteChanged(x => x.SelectModule(ModuleType.Unknown));
            if(SelectedModuleTypeChanged != null) {
                SelectedModuleTypeChanged(this, EventArgs.Empty);
            }
        }
        public object GetModule(ModuleType selectedModuleType) {
            return this.GetService<IModuleLocator>().GetModule(selectedModuleType);
        }
        public void ReleaseModule(Control module) {
            this.GetService<IModuleLocator>().ReleaseModule(module);
        }
        void OnGetMessage(Message message) {
            switch(message.MailType) {
                case MailType.Deleted:
                    DraftsMailCounter--;
                    break;
                default:
                    SelectModule(ModuleType.MailModule);
                    var module = SelectedModule as MailModule;
                    if(module != null) {
                        module.ShowMessage(message);
                    }
                    break;
            }
        }
        [Command]
        public void HideAllPanels() {
            while(PanelsStack.Count > 0) this.GetService<IPanelProviderService>().HidePanel(PanelsStack.Pop());
        }
    }
}
