namespace DevExpress.DevAV.Modules {
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Spreadsheet;

    public partial class ProductAnalysis : BaseModuleControl, IRibbonModule {
        AnalysisPeriod.DatePeriod dataPeriod;
        AnalysisPeriod.DatePeriod reportPeriod;
        public ProductAnalysis()
            : base(typeof(ProductAnalysisViewModel)) {
            InitializeComponent();
            BindCommands();
            LoadTemplate();
            InitializeCurrentDateTimePeriod();
        }
        public ProductAnalysisViewModel ViewModel {
            get { return GetViewModel<ProductAnalysisViewModel>(); }
        }
        public ProductCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<ProductCollectionViewModel>(); }
        }
        protected override void OnParentViewModelAttached() {
            base.OnParentViewModelAttached();
            LoadAnalysisData();
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
        }
        void LoadTemplate() {
            using(var stream = AnalysisTemplatesHelper.GetAnalysisTemplate(AnalysisTemplate.ProductSales))
                spreadsheetControl.LoadDocument(stream, DocumentFormat.Xlsm);
        }
        void InitializeCurrentDateTimePeriod() {
            var maxDate = ViewModel.GetMaxOrdersDate();
            dataPeriod = AnalysisPeriod.CalculateAnalysisPeriod(maxDate);
            reportPeriod = AnalysisPeriod.CalculateReportPeriod(maxDate);
        }
        void LoadAnalysisData() {
            spreadsheetControl.Document.BeginUpdate();
            var defName = spreadsheetControl.Document.DefinedNames.GetDefinedName("ReportYear");
            if(defName != null)
                defName.RefersTo = "=" + reportPeriod.End.Year.ToString(System.Globalization.CultureInfo.InvariantCulture);

            var financialReportWorksheet = spreadsheetControl.Document.Worksheets["Financial Report"];
            var financialReportItems = ViewModel.GetFinancialReport(dataPeriod.Start, dataPeriod.End).ToList(); 
            var frProducts = financialReportItems
                .Select(i => i.ProductName)
                .Distinct()
                .OrderBy(i => i).ToList();
            financialReportWorksheet.Import(frProducts, 17, 1, true);
            foreach(var reportItem in financialReportItems) {
                int rowOffset = frProducts.IndexOf(reportItem.ProductName);
                int columnOffset = AnalysisPeriod.MonthOffset(dataPeriod.Start, reportItem.Date) / 12;
                if(rowOffset < 0 || columnOffset < 0) continue;
                financialReportWorksheet.Cells[17 + rowOffset, 3 + columnOffset * 2].SetValue(reportItem.Total);
            }

            var financialDataWorksheet = spreadsheetControl.Document.Worksheets["Financial Data"];
            var financialDataItems = ViewModel.GetFinancialData(dataPeriod.Start, dataPeriod.End).ToList(); 
            foreach(var dataItem in financialDataItems) {
                int rowOffset = AnalysisPeriod.MonthOffset(dataPeriod.Start, dataItem.Date);
                int columnOffset = GetColumnIndex(dataItem.ProductCategory);
                if(rowOffset < 0 || columnOffset < 0) continue;
                financialDataWorksheet.Cells[6 + rowOffset, 3 + columnOffset].SetValue(dataItem.Total);
            }
            spreadsheetControl.Document.Worksheets.ActiveWorksheet = financialReportWorksheet;
            spreadsheetControl.Document.EndUpdate();
        }
        int GetColumnIndex(ProductCategory category) {
            switch(category) {
                case ProductCategory.Televisions:
                    return 0;
                case ProductCategory.Monitors:
                    return 1;
                case ProductCategory.VideoPlayers:
                    return 2;
                case ProductCategory.Automation:
                    return 3;
                default:
                    return -1;
            }
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon { get { return ribbonControl; } }
        #endregion
    }
}
