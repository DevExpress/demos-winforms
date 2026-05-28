namespace DevExpress.DevAV.Modules {
    using System;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraRichEdit.API.Native;
    using DevExpress.XtraRichEdit;

    public partial class OrderMailMerge : BaseModuleControl, IRibbonModule {
        public OrderMailMerge()
            : base(typeof(OrderMailMergeViewModel)) {
            InitializeComponent();
            BindCommands();
            UpdateUI();
            
            ViewModel.MailTemplateChanged += ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged += ViewModel_MailTemplateSelectedChanged;
            ViewModel.PeriodChanged += ViewModel_PeriodChanged;
            ViewModel.Save += ViewModel_Save;
            ViewModel.Modified = richEditControl.Modified;
            richEditControl.ModifiedChanged += richEditControl_ModifiedChanged;
            richEditControl.CalculateDocumentVariable += documentServer_CalculateDocumentVariable;
        }

        void documentServer_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            if (e.VariableName == "OrderDetail") {
                var targetDocumentServer = richEditControl.CreateDocumentServer();
                using (var sourceDocumentServer = richEditControl.CreateDocumentServer()) {
                    sourceDocumentServer.Options.MailMerge.DataSource = CollectionViewModel.SelectedEntity.OrderItems;
                    NumberingList bulletedList = CreateNumberingList(sourceDocumentServer);

                    Field filed = sourceDocumentServer.Document.Fields.Create(sourceDocumentServer.Document.CreatePosition(0), "MERGEFIELD Product.Name");
                    sourceDocumentServer.Document.Paragraphs.AddParagraphsToList(filed.Range, bulletedList, 0);

                    sourceDocumentServer.MailMerge(targetDocumentServer.Document);
                }

                e.KeepLastParagraph = true;
                e.Value = targetDocumentServer;
                e.Handled = true;
            }
        }

        NumberingList CreateNumberingList(IRichEditDocumentServer sourceDocumentServer) {
            AbstractNumberingList list = sourceDocumentServer.Document.AbstractNumberingLists.Add();
            list.NumberingType = NumberingType.Bullet;

            ListLevel level = list.Levels[0];
            level.ParagraphProperties.LeftIndent = 150;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.CharacterProperties.FontName = "Symbol";
            level.DisplayFormatString = new string('\u00B7', 1);

            return sourceDocumentServer.Document.NumberingLists.Add(0);
        }

        protected override void OnMVVMContextReleasing() {
            ViewModel.Save -= ViewModel_Save;
            ViewModel.PeriodChanged -= ViewModel_PeriodChanged;
            ViewModel.MailTemplateChanged -= ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged -= ViewModel_MailTemplateSelectedChanged;
        }
        protected override void OnDisposing() {
            richEditControl.ModifiedChanged -= richEditControl_ModifiedChanged;
            base.OnDisposing();
        }
        void ViewModel_MailTemplateSelectedChanged(object sender, EventArgs e) {
            UpdateUI();
        }
        void ViewModel_MailTemplateChanged(object sender, EventArgs e) {
            UpdateUI();
            ShowReport();
        }
        void ViewModel_PeriodChanged(object sender, EventArgs e) {
            if(ViewModel.MailTemplate.GetValueOrDefault() == SalesReportType.SalesReport)
                GenerateReport();
        }
        void LoadTemplate(Document document, SalesReportType mailTemplate) {
            string template = (mailTemplate.ToFileName() + ".docx");
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream(template))
                document.LoadDocument(stream, DocumentFormat.OpenXml);
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate);
            ViewModel.Modified = richEditControl.Modified;
            richEditControl.Options.MailMerge.DataSource = bindingSource;
            richEditControl.Options.MailMerge.ViewMergedData = true;
        }
        void UpdateUI() {
            mailMergeRibbonPage1.Visible = !ViewModel.IsMailTemplateSelected;
            rpbReportRange.Visible = ViewModel.IsMailTemplateSelected && ViewModel.MailTemplate.GetValueOrDefault() == SalesReportType.SalesReport;
        }
        public OrderMailMergeViewModel ViewModel {
            get { return GetViewModel<OrderMailMergeViewModel>(); }
        }
        public OrderCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<OrderCollectionViewModel>(); }
        }
        protected override void OnLoad(EventArgs ea) {
            base.OnLoad(ea);
            bindingSource.DataSource = CollectionViewModel.SelectedEntity;
            if(richEditControl.Document.IsEmpty)
                ShowReport();
        }
        void ShowReport() {
            bindingSource.DataSource = CollectionViewModel.SelectedEntity;
            switch(ViewModel.MailTemplate.GetValueOrDefault()) {
                case SalesReportType.SalesReport:
                    richEditControl.Options.MailMerge.DataSource = CollectionViewModel.GetOrderItems();
                    GenerateReport();
                    break;
                case SalesReportType.SalesByStore:
                    richEditControl.Options.MailMerge.DataSource = CollectionViewModel.GetOrderItems(CollectionViewModel.SelectedEntity.StoreId);
                    GenerateReport();
                    break;
                case SalesReportType.Invoice:
                case SalesReportType.OrderFollowUp:
                    LoadTemplate(richEditControl.Document, ViewModel.MailTemplate.GetValueOrDefault());
                    richEditControl.Options.MailMerge.DataSource = bindingSource;
                    break;
            }
        }
        void GenerateReport() {
            richEditControl.BeginUpdate();
            LoadTemplate(richEditControl.Document, ViewModel.MailTemplate.GetValueOrDefault());
            richEditControl.EndUpdate();
            ViewModel.Modified = richEditControl.Modified;
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            bbiThisMonth.BindCommand(() => ViewModel.SetThisMonthPeriod(), ViewModel);
            bbiPrevMonth.BindCommand(() => ViewModel.SetLastMonthPeriod(), ViewModel);
        }
        void richEditControl_ModifiedChanged(object sender, EventArgs e) {
            ViewModel.Modified = richEditControl.Modified;
        }
        void ViewModel_Save(object sender, EventArgs e) {
            richEditControl.SaveDocumentAs();
        }
#region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
#endregion
    }
}
