using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight {

    partial class MonthReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        //private dsCustomers dsCustomers1;
        //private DevExpress.XtraScheduler.Reporting.Demos.MultiColumnReport.dsCustomersTableAdapters.CustomersTableAdapter customersTableAdapter1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
            this.reportMonthView1 = new DevExpress.XtraScheduler.Reporting.ReportMonthView();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.horizontalWeek = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.horizontalResourceHeaders1,
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.horizontalWeek});
            this.Detail.HeightF = 313F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // horizontalResourceHeaders1
            // 
            this.horizontalResourceHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 147F);
            this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
            this.horizontalResourceHeaders1.SizeF = new System.Drawing.SizeF(648F, 26F);
            this.horizontalResourceHeaders1.View = this.reportMonthView1;
            // 
            // reportMonthView1
            // 
            this.reportMonthView1.VisibleWeekCount = 2;
            // 
            // calendarControl1
            // 
            this.calendarControl1.LocationFloat = new DevExpress.Utils.PointFloat(292F, 0F);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.SizeF = new System.Drawing.SizeF(350F, 142F);
            this.calendarControl1.TimeCells = this.horizontalWeek;
            this.calendarControl1.View = this.reportMonthView1;
            // 
            // horizontalWeek
            // 
            this.horizontalWeek.HorizontalHeaders = this.horizontalResourceHeaders1;
            this.horizontalWeek.LocationFloat = new DevExpress.Utils.PointFloat(0F, 173F);
            this.horizontalWeek.Name = "horizontalWeek";
            this.horizontalWeek.SizeF = new System.Drawing.SizeF(648F, 140F);
            this.horizontalWeek.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
            this.horizontalWeek.View = this.reportMonthView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Monthly;
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(9.000015F, 0F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(283F, 117F);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek;
            // 
            // MonthReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "17.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportMonthView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

		private DevExpress.XtraScheduler.Reporting.ReportMonthView reportMonthView1;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;


	}
}
