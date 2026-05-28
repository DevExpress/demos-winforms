using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle {

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
            DevExpress.XtraScheduler.TimeOfDayInterval timeOfDayInterval1 = new DevExpress.XtraScheduler.TimeOfDayInterval();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
            this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.horizontalDateHeaders1,
            this.horizontalResourceHeaders1,
            this.dayViewTimeCells1,
            this.dayViewTimeRuler1});
            this.Detail.Height = 942;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(275, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(350, 142);
            this.calendarControl1.TimeCells = this.dayViewTimeCells1;
            this.calendarControl1.View = this.reportDayView1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.HorizontalHeaders = this.horizontalResourceHeaders1;
            this.dayViewTimeCells1.Location = new System.Drawing.Point(54, 198);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.Size = new System.Drawing.Size(595, 688);
            this.dayViewTimeCells1.View = this.reportDayView1;
            timeOfDayInterval1.End = System.TimeSpan.Parse("18:00:00");
            timeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00");
            this.dayViewTimeCells1.VisibleTime = timeOfDayInterval1;
            // 
            // horizontalResourceHeaders1
            // 
            this.horizontalResourceHeaders1.HorizontalHeaders = this.horizontalDateHeaders1;
            this.horizontalResourceHeaders1.Location = new System.Drawing.Point(54, 173);
            this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
            this.horizontalResourceHeaders1.Size = new System.Drawing.Size(595, 25);
            this.horizontalResourceHeaders1.View = this.reportDayView1;
            // 
            // horizontalDateHeaders1
            // 
            this.horizontalDateHeaders1.Location = new System.Drawing.Point(54, 148);
            this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
            this.horizontalDateHeaders1.Size = new System.Drawing.Size(595, 25);
            this.horizontalDateHeaders1.View = this.reportDayView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.Location = new System.Drawing.Point(8, 0);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
            this.timeIntervalInfo1.Size = new System.Drawing.Size(242, 133);
            this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.Corners.Top = 50;
            this.dayViewTimeRuler1.Location = new System.Drawing.Point(4, 148);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.Size = new System.Drawing.Size(50, 738);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Name = "Report";
            this.PageHeight = 1100;
            this.PageWidth = 850;
            this.Version = "9.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
        private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;



    }
}
