using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays {

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
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.dayOfWeekHeaders1,
            this.horizontalWeek1});
            this.Detail.HeightF = 340.67F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // calendarControl1
            // 
            this.calendarControl1.LocationFloat = new DevExpress.Utils.PointFloat(283F, 0F);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.SizeF = new System.Drawing.SizeF(358F, 133F);
            this.calendarControl1.TimeCells = this.horizontalWeek1;
            this.calendarControl1.View = this.reportWeekView1;
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 166F);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.SizeF = new System.Drawing.SizeF(645F, 174.67F);
            this.horizontalWeek1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
            this.horizontalWeek1.View = this.reportWeekView1;
            // 
            // reportWeekView1
            // 
            this.reportWeekView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None;
            this.reportWeekView1.VisibleWeekCount = 4;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(267F, 125F);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            // 
            // dayOfWeekHeaders1
            // 
            this.dayOfWeekHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 141F);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.SizeF = new System.Drawing.SizeF(645F, 25F);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
            // 
            // MonthReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "10.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportWeekView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek1;
        private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;


    }
}
