namespace DevExpress.DevAV.Modules {
    using System.Linq;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Spreadsheet;

    public partial class CustomerAnalysis : BaseModuleControl, IRibbonModule {
        AnalysisPeriod.DatePeriod dataPeriod;
        AnalysisPeriod.DatePeriod reportPeriod;
        public CustomerAnalysis()
            : base(typeof(CustomerAnalysisViewModel)) {
            InitializeComponent();
            BindCommands();
            LoadTemplate();
            InitializeCurrentDateTimePeriod();
        }
        public CustomerAnalysisViewModel ViewModel {
            get { return GetViewModel<CustomerAnalysisViewModel>(); }
        }
        public CustomerCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<CustomerCollectionViewModel>(); }
        }
        protected override void OnParentViewModelAttached() {
            base.OnParentViewModelAttached();
            LoadAnalysisData();
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
        }
        void LoadTemplate() {
            using(var stream = AnalysisTemplatesHelper.GetAnalysisTemplate(AnalysisTemplate.CustomerSales))
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

            var salesReportWorksheet = spreadsheetControl.Document.Worksheets["Sales Report"];
            var salesReportItems = ViewModel.GetSalesReport(dataPeriod.Start, dataPeriod.End).ToList(); 
            var frCustomers = salesReportItems
                .Select(i => i.CustomerName)
                .Distinct()
                .OrderBy(i => i).ToList();
            salesReportWorksheet.Import(frCustomers, 14, 1, true);
            foreach(var reportItem in salesReportItems) {
                int rowOffset = frCustomers.IndexOf(reportItem.CustomerName);
                int columnOffset = AnalysisPeriod.MonthOffset(dataPeriod.Start, reportItem.Date) / 12;
                if(rowOffset < 0 || columnOffset < 0) continue;
                salesReportWorksheet.Cells[14 + rowOffset, 3 + columnOffset * 2].SetValue(reportItem.Total);
            }

            var salesDataWorksheet = spreadsheetControl.Document.Worksheets["Sales Data"];
            var salesDataItems = ViewModel.GetSalesData(dataPeriod.Start, dataPeriod.End).ToList(); 
            var states = salesDataItems.Select(i => i.State).Distinct().OrderBy(i => i).ToList();
            salesDataWorksheet.Import(ViewModel.GetStates(states), 5, 3, false);
            foreach(var dataItem in salesDataItems) {
                int rowOffset = AnalysisPeriod.MonthOffset(dataPeriod.Start, dataItem.Date);
                int columnOffset = states.IndexOf(dataItem.State);
                if(rowOffset < 0 || columnOffset < 0) continue;
                salesDataWorksheet.Cells[6 + rowOffset, 3 + columnOffset].SetValue(dataItem.Total);
            }
            spreadsheetControl.Document.Worksheets.ActiveWorksheet = salesReportWorksheet;
            spreadsheetControl.Document.EndUpdate();
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}
