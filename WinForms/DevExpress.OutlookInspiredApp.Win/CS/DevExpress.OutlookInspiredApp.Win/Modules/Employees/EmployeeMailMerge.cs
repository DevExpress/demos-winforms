namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils;
    using DevExpress.Utils.Svg;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraLayout.Utils;

    public partial class EmployeeMailMerge : BaseModuleControl, IRibbonModule {
        public EmployeeMailMerge()
            : base(typeof(EmployeeMailMergeViewModel)) {
            InitializeComponent();
            BindCommands();
            BindEditors();
            UpdateSelectTemplateUI();
            new ZoomLevelManager(beZoomLevel, bbiZoomDialog, new RichEditZoomingModel(richEditControl));
            
            ViewModel.MailTemplateChanged += ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged += ViewModel_MailTemplateSelectedChanged;
            ViewModel.Save += ViewModel_Save;
            richEditControl.ModifiedChanged += richEditControl_ModifiedChanged;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Save -= ViewModel_Save;
            ViewModel.MailTemplateChanged -= ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged -= ViewModel_MailTemplateSelectedChanged;
        }
        protected override void OnDisposing() {
            richEditControl.ModifiedChanged -= richEditControl_ModifiedChanged;
            base.OnDisposing();
        }
        void ViewModel_Save(object sender, EventArgs e) {
            richEditControl.SaveDocumentAs();
        }
        void ViewModel_MailTemplateSelectedChanged(object sender, EventArgs e) {
            UpdateSelectTemplateUI();
        }
        void ViewModel_MailTemplateChanged(object sender, EventArgs e) {
            UpdateEditor(ViewModel.MailTemplate.GetValueOrDefault());
        }
        void UpdateEditor(EmployeeMailTemplate mailTemplate) {
            ViewModel.Modified = richEditControl.Modified;
            cbMailTemplate.EditValue = mailTemplate;
            LoadTemplate(mailTemplate);
            SynchronizeCurrentRecordWithRichEdit();
        }
        void LoadTemplate(EmployeeMailTemplate mailTemplate) {
            string template = (mailTemplate.ToFileName() + ".docx");
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream(template))
                richEditControl.LoadDocumentTemplate(stream, XtraRichEdit.DocumentFormat.Rtf);
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate);
        }
        void UpdateSelectTemplateUI() {
            roundedSkinPanel2.Visible = !ViewModel.IsMailTemplateSelected;
            mailMergeRibbonPage1.Visible = !ViewModel.IsMailTemplateSelected;
        }
        public EmployeeMailMergeViewModel ViewModel {
            get { return GetViewModel<EmployeeMailMergeViewModel>(); }
        }
        public EmployeeCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        protected override void OnLoad(EventArgs ea) {
            base.OnLoad(ea);
            CollectionViewModel.GetEntities();
            bindingSource.DataSource = CollectionViewModel.GetEntities();
            employeesList.DataSource = bindingSource.DataSource;

            gridView.FocusedRowHandle = gridView.LocateByValue("Id", CollectionViewModel.SelectedEntity.Id);
            if(richEditControl.Document.IsEmpty)
                LoadTemplate(ViewModel.MailTemplate.GetValueOrDefault());
            richEditControl.Options.MailMerge.DataSource = bindingSource;
            richEditControl.Options.MailMerge.ViewMergedData = true;
            SynchronizeCurrentRecordWithRichEdit();
            ViewModel.Modified = richEditControl.Modified;
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
        }
        void BindEditors() {
            employeesList.Load += (s, e) => GridHelper.SetFindControlImages(employeesList);
            gridView.FocusedRowObjectChanged += gridView_FocusedRowObjectChanged;

            cbMailTemplate.Properties.Items.AddEnum<EmployeeMailTemplate>();
            
            cbMailTemplate.Properties.SmallImages = CreateSvgImageCollection();
            foreach(DevExpress.XtraEditors.Controls.ImageComboBoxItem item in cbMailTemplate.Properties.Items)
                item.ImageIndex = (int)(EmployeeMailTemplate)item.Value;
            cbMailTemplate.EditValue = ViewModel.MailTemplate.GetValueOrDefault();
            cbMailTemplate.EditValueChanged += cbMailTemplate_EditValueChanged;
        }
        static SvgImageCollection CreateSvgImageCollection() {
            SvgImageCollection ret = new SvgImageCollection();
            ret.ImageSize = new Size(16, 16);
            ret.Add(SvgImage.FromResources(FluentIconHelper.GetFluentIconName("icon_employee_quick_award_16"), typeof(MainForm).Assembly));
            ret.Add(SvgImage.FromResources(FluentIconHelper.GetFluentIconName("icon_employee_quick_probation_notice_16"), typeof(MainForm).Assembly));
            ret.Add(SvgImage.FromResources(FluentIconHelper.GetFluentIconName("icon_employee_quick_excellence_16"), typeof(MainForm).Assembly));
            ret.Add(SvgImage.FromResources(FluentIconHelper.GetFluentIconName("icon_employee_quick_thank_16"), typeof(MainForm).Assembly));
            ret.Add(SvgImage.FromResources(FluentIconHelper.GetFluentIconName("icon_employee_quick_welcome_16"), typeof(MainForm).Assembly));
            return ret;
        }
        static ImageCollection CreateImageCollection() {
            ImageCollection ret = new ImageCollection();
            ret.ImageSize = new Size(16, 16);
            ret.AddImage(Properties.Resources.icon_employee_quick_thank_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_probation_notice_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_excellence_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_award_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_welcome_16);
            return ret;
        }
        void gridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            SynchronizeCurrentRecordWithRichEdit();
        }
        void SynchronizeCurrentRecordWithRichEdit() {
            bindingSource.Position = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
        }
        void cbMailTemplate_EditValueChanged(object sender, EventArgs e) {
            ViewModel.MailTemplate = (EmployeeMailTemplate)cbMailTemplate.EditValue;
        }
        void richEditControl_ModifiedChanged(object sender, EventArgs e) {
            ViewModel.Modified = richEditControl.Modified;
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
        #region IZoomViewModel Members
        class RichEditZoomingModel : IZoomViewModel, ISupportZoom {
            object IZoomViewModel.ZoomModule {
                get { return this; }
            }
            event EventHandler IZoomViewModel.ZoomModuleChanged {
                add { }
                remove { }
            }
            XtraRichEdit.RichEditControl richEditControl;
            public RichEditZoomingModel(XtraRichEdit.RichEditControl richEditControl) {
                this.richEditControl = richEditControl;
                if(richEditControl != null)
                    richEditControl.ZoomChanged += richEditControl_ZoomChanged;
            }
            void richEditControl_ZoomChanged(object sender, EventArgs e) {
                RaiseZoomChanged();
            }
            int ISupportZoom.ZoomLevel {
                get { return (int)System.Math.Ceiling(richEditControl.ActiveView.ZoomFactor * 100.0f); }
                set { richEditControl.ActiveView.ZoomFactor = ((float)value) / 100.0f; }
            }
            public event EventHandler ZoomChanged;
            void RaiseZoomChanged() {
                EventHandler handler = ZoomChanged;
                if(handler != null)
                    handler(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}
