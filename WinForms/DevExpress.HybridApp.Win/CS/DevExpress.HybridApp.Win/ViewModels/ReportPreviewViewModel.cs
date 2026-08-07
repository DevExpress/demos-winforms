using System;
using System.ComponentModel;
using DevExpress.DevAV.Services;
using DevExpress.Mvvm;
using DevExpress.XtraReports.UI;

namespace DevExpress.DevAV.ViewModels {
    public class ReportPreviewViewModel : IDocumentContent, ISupportParameter {
        object ISupportParameter.Parameter {
            get { throw new NotImplementedException(); }
            set {
                object[] parameters = (object[])value;
                ReportInfo = (IReportInfo)parameters[0];
                ReportType = (EmployeeReportType)parameters[1];
            }
        }
        public bool CanLoad() {
            return ReportInfo != null;
        }
        public void Load() {
            Report = (XtraReport)ReportInfo.CreateReport();
            Report.CreateDocument(true);
        }
        public virtual IReportInfo ReportInfo {
            get;
            set;
        }
        public virtual XtraReport Report {
            get;
            protected set;
        }
        public virtual EmployeeReportType ReportType {
            get;
            protected set;
        }
        public bool CanShowEvaluations(bool include) {
            return Report != null;
        }
        public void ShowEvaluations(bool include) {
            var evaluationParameter = Report.Parameters["paramEvaluations"];
            if(evaluationParameter != null)
                evaluationParameter.Value = include;
            Report.CreateDocument(true);
        }
        protected IDocumentOwner DocumentOwner {
            get;
            private set;
        }
        public void Close() {
            if(DocumentOwner != null)
                DocumentOwner.Close(this);
        }
        #region IDocumentContent
        void IDocumentContent.OnClose(CancelEventArgs e) { }
        void IDocumentContent.OnDestroy() { }
        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }
        object IDocumentContent.Title {
            get { return null; }
        }
        #endregion
    }
}
