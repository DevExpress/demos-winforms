using System;
using DevExpress.XtraReports;

namespace DevExpress.DevAV.Services {
    public interface IReportInfo {
        object ParametersViewModel { get; }
        IReport CreateReport();
    }
    
    public class ReportInfo<TParametersViewModel> : IReportInfo {
        TParametersViewModel parametersViewModel;
        Func<TParametersViewModel, IReport> reportFactory;
        public ReportInfo(TParametersViewModel parametersViewModel, Func<TParametersViewModel, IReport> reportFactory) {
            this.parametersViewModel = parametersViewModel;
            this.reportFactory = reportFactory;
        }
        object IReportInfo.ParametersViewModel {
            get { return parametersViewModel; }
        }
        IReport IReportInfo.CreateReport() {
            return reportFactory(parametersViewModel);
        }
    }
}
