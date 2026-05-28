using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle {

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
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScaleFixedInterval timeScaleFixedInterval1 = new DevExpress.XtraScheduler.TimeScaleFixedInterval();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
            this.timelineCells1 = new DevExpress.XtraScheduler.Reporting.TimelineCells();
            this.timelineScaleHeaders1 = new DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders();
            this.reportTimelineView1 = new DevExpress.XtraScheduler.Reporting.ReportTimelineView();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.formatTimeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.verticalResourceHeaders1,
            this.timelineCells1,
            this.calendarControl1,
            this.timelineScaleHeaders1,
            this.formatTimeIntervalInfo1});
            this.Detail.Height = 846;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // verticalResourceHeaders1
            // 
            this.verticalResourceHeaders1.Corners.Top = 42;
            this.verticalResourceHeaders1.Location = new System.Drawing.Point(2, 157);
            this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
            this.verticalResourceHeaders1.Size = new System.Drawing.Size(25, 675);
            this.verticalResourceHeaders1.TimeCells = this.timelineCells1;
            this.verticalResourceHeaders1.View = this.reportTimelineView1;
            // 
            // timelineCells1
            // 
            this.timelineCells1.HorizontalHeaders = this.timelineScaleHeaders1;
            this.timelineCells1.Location = new System.Drawing.Point(27, 199);
            this.timelineCells1.Name = "timelineCells1";
            this.timelineCells1.Size = new System.Drawing.Size(620, 633);
            this.timelineCells1.View = this.reportTimelineView1;
            // 
            // timelineScaleHeaders1
            // 
            this.timelineScaleHeaders1.Location = new System.Drawing.Point(27, 157);
            this.timelineScaleHeaders1.Name = "timelineScaleHeaders1";
            this.timelineScaleHeaders1.Size = new System.Drawing.Size(620, 42);
            this.timelineScaleHeaders1.View = this.reportTimelineView1;
            // 
            // reportTimelineView1
            // 
            timeScaleQuarter1.Enabled = false;
            timeScaleWeek1.Enabled = false;
            timeScaleDay1.Enabled = false;
            timeScaleHour1.Enabled = false;
            timeScaleFixedInterval1.Enabled = false;
            this.reportTimelineView1.Scales.Add(timeScaleYear1);
            this.reportTimelineView1.Scales.Add(timeScaleQuarter1);
            this.reportTimelineView1.Scales.Add(timeScaleMonth1);
            this.reportTimelineView1.Scales.Add(timeScaleWeek1);
            this.reportTimelineView1.Scales.Add(timeScaleDay1);
            this.reportTimelineView1.Scales.Add(timeScaleHour1);
            this.reportTimelineView1.Scales.Add(timeScaleFixedInterval1);
            this.reportTimelineView1.VisibleIntervalCount = 5;
            this.reportTimelineView1.VisibleResourceCount = 2;
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(292, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(350, 142);
            this.calendarControl1.TimeCells = this.timelineCells1;
            this.calendarControl1.View = this.reportTimelineView1;
            // 
            // formatTimeIntervalInfo1
            // 
            this.formatTimeIntervalInfo1.Location = new System.Drawing.Point(0, 0);
            this.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1";
            this.formatTimeIntervalInfo1.Size = new System.Drawing.Size(283, 142);
            this.formatTimeIntervalInfo1.TimeCells = this.timelineCells1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "9.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportTimelineView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders timelineScaleHeaders1;
        private DevExpress.XtraScheduler.Reporting.TimelineCells timelineCells1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportTimelineView reportTimelineView1;
        private DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo formatTimeIntervalInfo1;



	}
}
