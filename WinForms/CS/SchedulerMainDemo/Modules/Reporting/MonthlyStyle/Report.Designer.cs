using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle {

	partial class Report {
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
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportMonthView1 = new DevExpress.XtraScheduler.Reporting.ReportMonthView();
            this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dayOfWeekHeaders1,
            this.verticalResourceHeaders1,
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.horizontalWeek1});
            this.Detail.Height = 901;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dayOfWeekHeaders1
            // 
            this.dayOfWeekHeaders1.Location = new System.Drawing.Point(27, 148);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.Size = new System.Drawing.Size(620, 25);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportMonthView1;
            // 
            // horizontalWeek1
            //            
            this.horizontalWeek1.Location = new System.Drawing.Point(27, 173);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.Size = new System.Drawing.Size(620, 720);
            this.horizontalWeek1.View = this.reportMonthView1;
            // 
            // reportMonthView1
            // 
            this.reportMonthView1.VisibleWeekCount = 2;
            // 
            // verticalResourceHeaders1
            //             
            this.verticalResourceHeaders1.Corners.Top = 25;
            this.verticalResourceHeaders1.Location = new System.Drawing.Point(2, 148);
            this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
            this.verticalResourceHeaders1.Size = new System.Drawing.Size(25, 745);
            this.verticalResourceHeaders1.TimeCells = this.horizontalWeek1;
            this.verticalResourceHeaders1.View = this.reportMonthView1;
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(292, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(350, 142);
            this.calendarControl1.TimeCells = this.horizontalWeek1;
            this.calendarControl1.View = this.reportMonthView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Monthly;
            this.timeIntervalInfo1.Location = new System.Drawing.Point(0, 0);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
            this.timeIntervalInfo1.Size = new System.Drawing.Size(283, 117);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "9.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportMonthView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

		private DevExpress.XtraScheduler.Reporting.ReportMonthView reportMonthView1;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;


	}
}
