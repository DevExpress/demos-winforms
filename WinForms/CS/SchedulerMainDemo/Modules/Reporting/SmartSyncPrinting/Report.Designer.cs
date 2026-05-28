using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting {

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
            this.timeIntervalInfo3 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportMonthView1 = new DevExpress.XtraScheduler.Reporting.ReportMonthView();
            this.timeIntervalInfo2 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.fullWeek1 = new DevExpress.XtraScheduler.Reporting.FullWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.resourceInfo1 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.timeIntervalInfo3,
            this.timeIntervalInfo2,
            this.timeIntervalInfo1,
            this.dayOfWeekHeaders1,
            this.dayViewTimeRuler1,
            this.fullWeek1,
            this.horizontalWeek1,
            this.dayViewTimeCells1,
            this.xrLine1,
            this.resourceInfo1});
            this.Detail.HeightF = 792.25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // timeIntervalInfo3
            // 
            this.timeIntervalInfo3.AutoScaleFont = false;
            this.timeIntervalInfo3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.timeIntervalInfo3.LocationFloat = new DevExpress.Utils.PointFloat(611F, 57.00002F);
            this.timeIntervalInfo3.Name = "timeIntervalInfo3";
            this.timeIntervalInfo3.SizeF = new System.Drawing.SizeF(279F, 50F);
            this.timeIntervalInfo3.TimeCells = this.horizontalWeek1;
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.LocationFloat = new DevExpress.Utils.PointFloat(612.0417F, 133.6F);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.SizeF = new System.Drawing.SizeF(279F, 511.86F);
            this.horizontalWeek1.View = this.reportMonthView1;
            // 
            // timeIntervalInfo2
            // 
            this.timeIntervalInfo2.AutoScaleFont = false;
            this.timeIntervalInfo2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.timeIntervalInfo2.LocationFloat = new DevExpress.Utils.PointFloat(317.7081F, 56.95831F);
            this.timeIntervalInfo2.Name = "timeIntervalInfo2";
            this.timeIntervalInfo2.SizeF = new System.Drawing.SizeF(280.21F, 50F);
            this.timeIntervalInfo2.TimeCells = this.fullWeek1;
            // 
            // fullWeek1
            // 
            this.fullWeek1.LocationFloat = new DevExpress.Utils.PointFloat(317.7084F, 113.4583F);
            this.fullWeek1.Name = "fullWeek1";
            this.fullWeek1.SizeF = new System.Drawing.SizeF(280.2084F, 531.9584F);
            this.fullWeek1.View = this.reportWeekView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1.041476F, 56.95831F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(305.13F, 46F);
            this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.ExtraCells.MinCount = 1;
            this.dayViewTimeCells1.LocationFloat = new DevExpress.Utils.PointFloat(51.04167F, 113.5F);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.ShowWorkTimeOnly = true;
            this.dayViewTimeCells1.SizeF = new System.Drawing.SizeF(255.1251F, 531.9584F);
            this.dayViewTimeCells1.TimeScale = System.TimeSpan.Parse("01:00:00");
            this.dayViewTimeCells1.View = this.reportDayView1;
            timeOfDayInterval1.End = System.TimeSpan.Parse("18:00:00");
            timeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00");
            this.dayViewTimeCells1.VisibleTime = timeOfDayInterval1;
            // 
            // dayOfWeekHeaders1
            // 
            this.dayOfWeekHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(612.0417F, 113.5F);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.SizeF = new System.Drawing.SizeF(279F, 20F);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.LocationFloat = new DevExpress.Utils.PointFloat(1.041667F, 113.5F);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.SizeF = new System.Drawing.SizeF(50F, 531.9166F);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.00001F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(890F, 8F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // resourceInfo1
            // 
            this.resourceInfo1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 24F);
            this.resourceInfo1.ForeColor = System.Drawing.Color.Navy;
            this.resourceInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1F);
            this.resourceInfo1.Name = "resourceInfo1";
            this.resourceInfo1.SizeF = new System.Drawing.SizeF(872.2085F, 33F);
            this.resourceInfo1.TimeCells = this.dayViewTimeCells1;
            this.resourceInfo1.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "10.1";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportMonthView1,
            this.reportWeekView1,
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
        private DevExpress.XtraScheduler.Reporting.FullWeek fullWeek1;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek1;
        private DevExpress.XtraScheduler.Reporting.ReportMonthView reportMonthView1;
        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo3;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo2;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;


	}
}
