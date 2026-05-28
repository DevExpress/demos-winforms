using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn {

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
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.timeIntervalInfo1,
            this.calendarControl1,
            this.dayOfWeekHeaders1,
            this.verticalResourceHeaders1,
            this.horizontalWeek1});
            this.Detail.Height = 851;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.Location = new System.Drawing.Point(33, 0);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
            this.timeIntervalInfo1.PrintInColumn = DevExpress.XtraScheduler.Reporting.PrintInColumnMode.Odd;
            this.timeIntervalInfo1.Size = new System.Drawing.Size(242, 133);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.CompressWeekend = false;
            this.horizontalWeek1.Location = new System.Drawing.Point(27, 181);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.Size = new System.Drawing.Size(620, 668);
            this.horizontalWeek1.View = this.reportWeekView1;
            // 
            // reportWeekView1
            // 
            this.reportWeekView1.VisibleResourceCount = 2;
            this.reportWeekView1.VisibleWeekCount = 2;
            this.reportWeekView1.VisibleWeekDayColumnCount = 2;
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(292, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.PrintInColumn = DevExpress.XtraScheduler.Reporting.PrintInColumnMode.Even;
            this.calendarControl1.Size = new System.Drawing.Size(350, 150);
            this.calendarControl1.TimeCells = this.horizontalWeek1;
            this.calendarControl1.View = this.reportWeekView1;
            // 
            // dayOfWeekHeaders1
            //             
            this.dayOfWeekHeaders1.Location = new System.Drawing.Point(27, 156);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.Size = new System.Drawing.Size(620, 25);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
            // 
            // verticalResourceHeaders1
            //             
            this.verticalResourceHeaders1.Corners.Top = 25;
            this.verticalResourceHeaders1.Location = new System.Drawing.Point(2, 156);
            this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
            this.verticalResourceHeaders1.Size = new System.Drawing.Size(25, 692);
            this.verticalResourceHeaders1.TimeCells = this.horizontalWeek1;
            this.verticalResourceHeaders1.View = this.reportWeekView1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "9.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportWeekView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek1;
        private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;


    }
}
