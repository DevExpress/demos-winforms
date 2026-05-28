using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraReports.UserDesigner;

namespace DevExpress.XtraScheduler.Demos.Reporting {

    public partial class SingleReportPreviewControl : ReportPreviewControlBase {
        XtraSchedulerReport _report;
        public virtual XtraSchedulerReport Report { get { return _report; } }

        protected virtual XtraSchedulerReport CreateReportInstance() {
            return null;
        }
        protected override void CreateReports() {
            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = true;
            if (this._report != null) {
                this._report.Dispose();
            }
            this._report = CreateReportInstance();
        }
        protected override XtraSchedulerReport GetActiveReport() {
            return Report;
        }
        
	}

}

