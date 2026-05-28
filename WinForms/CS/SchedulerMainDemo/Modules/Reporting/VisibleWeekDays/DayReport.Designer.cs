using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays {

    partial class DayReport {
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
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dayViewTimeRuler1,
            this.horizontalDateHeaders1,
            this.dayViewTimeCells1,
            this.calendarControl1,
            this.timeIntervalInfo1});
            this.Detail.HeightF = 827F;
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
            this.calendarControl1.TimeCells = this.dayViewTimeCells1;
            this.calendarControl1.View = this.reportDayView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Weekly;
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(267F, 125F);
            this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.HorizontalHeaders = this.horizontalDateHeaders1;
            this.dayViewTimeCells1.LocationFloat = new DevExpress.Utils.PointFloat(59.99997F, 190.6251F);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.ShowWorkTimeOnly = true;
            this.dayViewTimeCells1.SizeF = new System.Drawing.SizeF(580F, 626.3749F);
            this.dayViewTimeCells1.View = this.reportDayView1;
            // 
            // reportDayView1
            // 
            this.reportDayView1.VisibleDayCount = 5;
            // 
            // horizontalDateHeaders1
            // 
            this.horizontalDateHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(59.99997F, 164.6251F);
            this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
            this.horizontalDateHeaders1.SizeF = new System.Drawing.SizeF(579.9999F, 26F);
            this.horizontalDateHeaders1.View = this.reportDayView1;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.Corners.Top = 25;
            this.dayViewTimeRuler1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 164.625F);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.SizeF = new System.Drawing.SizeF(50F, 652.3749F);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // DayReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "10.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
        private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;


    }
}
