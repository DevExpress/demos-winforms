namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.DevAV.DevAVDbDataModel;

    public class CustomerAnalysisViewModel : DocumentContentViewModelBase {
        IDevAVDbUnitOfWork unitOfWork;

        public static CustomerAnalysisViewModel Create() {
            return ViewModelSource.Create(() => new CustomerAnalysisViewModel());
        }
        protected CustomerAnalysisViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IEnumerable<CustomersAnalysis.Item> GetSalesReport(DateTime startDate, DateTime endDate) {
            return CustomersAnalysis.GetSalesReport(unitOfWork, startDate, endDate);
        }
        public IEnumerable<CustomersAnalysis.Item> GetSalesData(DateTime startDate, DateTime endDate) {
            return CustomersAnalysis.GetSalesData(unitOfWork, startDate, endDate);
        }
        public IEnumerable<string> GetStates(IEnumerable<StateEnum> states) {
            return QueriesHelper.GetStateNames(unitOfWork.States, states);
        }
        public DateTime GetMaxOrdersDate() {
            return AnalysisPeriodHelper.GetMaxOrdersDate(unitOfWork);
        }
    }
}
