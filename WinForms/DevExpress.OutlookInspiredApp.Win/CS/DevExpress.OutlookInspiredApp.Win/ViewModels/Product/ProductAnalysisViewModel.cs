namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class ProductAnalysisViewModel : DocumentContentViewModelBase {
        IDevAVDbUnitOfWork unitOfWork;

        public static ProductAnalysisViewModel Create() {
            return ViewModelSource.Create(() => new ProductAnalysisViewModel());
        }
        protected ProductAnalysisViewModel() {           
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IEnumerable<ProductsAnalysis.Item> GetFinancialReport(DateTime startDate, DateTime endDate) {
            return ProductsAnalysis.GetFinancialReport(unitOfWork, startDate, endDate);
        }
        public IEnumerable<ProductsAnalysis.Item> GetFinancialData(DateTime startDate, DateTime endDate) {
            return ProductsAnalysis.GetFinancialData(unitOfWork, startDate, endDate);
        }
        public DateTime GetMaxOrdersDate() {
            return AnalysisPeriodHelper.GetMaxOrdersDate(unitOfWork);
        }
    }
}
