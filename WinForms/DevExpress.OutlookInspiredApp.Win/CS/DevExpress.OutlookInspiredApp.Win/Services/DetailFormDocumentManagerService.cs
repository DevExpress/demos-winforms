namespace DevExpress.DevAV {
    using System;
    using System.Windows.Forms;
    using DevExpress.DevAV.Modules;
    using DevExpress.DevAV.Services;
    using DevExpress.Mvvm;

    abstract class DetailFormDocumentManagerServiceBase : DocumentManagerServiceBase {
        readonly ModuleType viewModuleType;
        public DetailFormDocumentManagerServiceBase(ModuleType viewModuleType) {
            this.viewModuleType = viewModuleType;
        }
        #region Document
        protected class DetailFormDocument : IDocument, IDocumentInfo {
            readonly object contentCore;
            readonly Form formCore;
            readonly DetailFormDocumentManagerServiceBase owner;
            DocumentState docState = DocumentState.Hidden;
            public DetailFormDocument(DetailFormDocumentManagerServiceBase owner, Form form, object content) {
                this.owner = owner;
                this.formCore = form;
                this.contentCore = content;
                form.AutoValidate = AutoValidate.EnableAllowFocusChange;
                form.FormClosing += form_Closing;
                form.FormClosed += form_Closed;
            }
            void form_Closed(object sender, EventArgs e) {
                var formTitle = formCore.Text;
                var parentViewModel = ViewModelHelper.GetParentViewModel<ISupportNewParent>(contentCore);
                owner.RemoveDocument(this);
                formCore.FormClosing -= form_Closing;
                formCore.FormClosed -= form_Closed;
                IDocumentContent documentContent = GetContent() as IDocumentContent;
                if(documentContent != null)
                    documentContent.OnDestroy();
                TryUpdateNew(GetContent(), formTitle, parentViewModel);
            }
            void form_Closing(object sender, FormClosingEventArgs e) {
                IDocumentContent documentContent = GetContent() as IDocumentContent;
                if(documentContent != null)
                    documentContent.OnClose(e);
                if(!destroyOnCloseCore) {
                    bool cancel = e.Cancel;
                    e.Cancel = true;
                    if(!cancel)
                        formCore.Hide();
                }
            }
            void IDocument.Show() {
                if(!formCore.Visible)
                    formCore.Show(AppHelper.MainForm);
                else
                    formCore.Activate();
                docState = DocumentState.Visible;
                var parentViewModel = ViewModelHelper.GetParentViewModel<ISupportNewParent>(contentCore);
                if(contentCore is ISupportNewChid && parentViewModel != null)
                    UpdateNew(parentViewModel);
            }
            void IDocument.Hide() {
                formCore.Hide();
                docState = DocumentState.Hidden;
            }
            void IDocument.Close(bool force) {
                if(force) {
                    formCore.FormClosing -= form_Closing;
                    DevExpress.XtraEditors.Container.ContainerHelper.ClearUnvalidatedControl(formCore.ActiveControl, formCore);
                }
                formCore.Close();
                docState = DocumentState.Hidden;
            }
            static void TryUpdateNew(object content, string title, ISupportNewParent parentViewModel) {
                if(content is ISupportNewChid && parentViewModel != null) {
                    if(AppHelper.MainForm != null && title.EndsWith("(New)"))
                        AppHelper.MainForm.BeginInvoke(new Action<object>(UpdateNew), parentViewModel);
                }
            }
            static void UpdateNew(object parameter) {
                var parentViewModel = parameter as ISupportNewParent;
                if(parentViewModel != null) 
                    ViewModelHelper.RaiseCanExecuteChanged(parentViewModel, "New");
            }
            bool destroyOnCloseCore = true;
            bool IDocument.DestroyOnClose {
                get { return destroyOnCloseCore; }
                set {  }
            }
            object IDocument.Id { 
                get; 
                set; 
            }
            object IDocument.Title {
                get { return formCore.Text; }
                set { formCore.Text = Convert.ToString(value); }
            }
            object IDocument.Content {
                get { return GetContent(); }
            }
            object GetContent() {
                return contentCore;
            }
            DocumentState IDocumentInfo.State {
                get { return docState; }
            }
            string IDocumentInfo.DocumentType {
                get { return null; }
            }
        }
        #endregion Document
        protected bool IsDefaultViewModuleType(ModuleType actualViewModuleType) {
            return viewModuleType == actualViewModuleType;
        }
        protected virtual ModuleType GetActualViewModuleType(string documentType, object parentViewModel) {
            if(documentType == "MapView") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetMapModuleType(viewModuleType);
            }
            if(documentType == "MailMerge") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetMailMergeModuleType(viewModuleType);
            }
            if(documentType == "Analysis") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetAnalysisModuleType(viewModuleType);
            }
            if(documentType == "OrderPdfQuickReportView")
                return ModuleType.OrderPdfQuickReportView;
            if(documentType == "OrderXlsQuickReportView")
                return ModuleType.OrderXlsQuickReportView;
            if(documentType == "OrderDocQuickReportView")
                return ModuleType.OrderDocQuickReportView;
            if(documentType == "OrderRevenueView")
                return ModuleType.OrderRevenueView;
            return viewModuleType;
        }
        protected static object CreateView(object parameter, ModuleType actualModuleType, IModuleLocator moduleLocator) {
            if(parameter is Delegate)
                return moduleLocator.CreateModule(actualModuleType);
            var initInfo = parameter as Mvvm.ViewModel.ViewModelInitInfo;
            if(initInfo != null && initInfo.PrimaryKey is long)
                return moduleLocator.GetModule(actualModuleType, (long)initInfo.PrimaryKey);
            if(parameter is long)
                return moduleLocator.GetModule(actualModuleType, (long)parameter);
            return moduleLocator.GetModule(actualModuleType);
        }
        protected IDocument RegisterDetailFormDocumentForModule(object viewModel, object parentViewModel, object parameter, ModuleType actualModuleType) {
            var waitingService = GetService<Services.IWaitingService>(parentViewModel);
            using(waitingService.Enter(actualModuleType)) {
                var moduleLocator = GetService<Services.IModuleLocator>(parentViewModel);
                object view = CreateView(parameter, actualModuleType, moduleLocator);
                viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view);
                return RegisterDocument(view, (container) => new DetailFormDocument(this, container, viewModel), () => new DetailForm(), parameter);
            }
        }
    }
    
    class DetailFormDocumentManagerService : DetailFormDocumentManagerServiceBase, IDocumentManagerService {
        public DetailFormDocumentManagerService(ModuleType viewModuleType)
            : base(viewModuleType) {
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            var actualModuleType = GetActualViewModuleType(documentType, parentViewModel);
            return RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType);
        }
    }
    class NotImplementedDetailFormDocumentManagerService : DetailFormDocumentManagerServiceBase, IDocumentManagerService {
        public NotImplementedDetailFormDocumentManagerService(ModuleType viewModuleType)
            : base(viewModuleType) {
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            var actualModuleType = GetActualViewModuleType(documentType, parentViewModel);
            return IsDefaultViewModuleType(actualModuleType) ? new DXOverviewDocument() :
                RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType);
        }
        #region DXAbout
        protected class DXOverviewDocument : IDocument, IDocumentInfo {
            XtraEditors.XtraForm overviewForm = new XtraEditors.XtraForm();
            DocumentState docState = DocumentState.Hidden;
            const string captionText =
                "DevExpress";
            const string descriptionText =
                "You can easily create custom edit forms using the 40+ controls that ship as part of the DevExpress Data Editors Library.<br>" +
                "To see what you can build, <href=Employees>activate the Employees module.</href>";
            #region IDocument Members
            void IDocument.Show() {
                OverviewControl overview = new OverviewControl();
                overviewForm.MinimizeBox = false;
                overviewForm.MaximizeBox = false;
                overviewForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                overviewForm.Text = captionText;
                overviewForm.ClientSize = overview.Size;
                overviewForm.MinimumSize = overviewForm.Size;
                overview.SetDescription(descriptionText);
                overview.Dock = DockStyle.Fill;
                overview.Parent = overviewForm;
                overviewForm.StartPosition = FormStartPosition.CenterParent;
                overviewForm.IconOptions.SvgImage = AppHelper.AppIcon;
                using(overviewForm) {
                    overviewForm.ShowDialog(AppHelper.MainForm);
                }
                docState = DocumentState.Visible;
            }
            object IDocument.Content { get { return null; } }
            bool IDocument.DestroyOnClose { get; set; }
            void IDocument.Hide() {
                overviewForm.Close();
                docState = DocumentState.Hidden;
            }
            void IDocument.Close(bool force) {
                overviewForm.Close();
                docState = DocumentState.Hidden;
            }
            object IDocument.Title { get; set; }
            object IDocument.Id { get; set; }
            #endregion

            DocumentState IDocumentInfo.State {
                get { return docState; }
            }
            string IDocumentInfo.DocumentType {
                get { return null; }
            }
        }
        #endregion
    }
}
