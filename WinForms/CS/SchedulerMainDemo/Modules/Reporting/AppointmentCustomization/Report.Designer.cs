using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization {

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
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dayViewTimeRuler1,
            this.horizontalDateHeaders1,
            this.dayViewTimeCells1});
            this.Detail.Height = 59;
            this.Detail.Name = "Detail";
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.Corners.Top = 25;
            this.dayViewTimeRuler1.Location = new System.Drawing.Point(0, 0);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.Size = new System.Drawing.Size(50, 58);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.HorizontalHeaders = this.horizontalDateHeaders1;
            this.dayViewTimeCells1.Location = new System.Drawing.Point(50, 25);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.Size = new System.Drawing.Size(592, 33);
            this.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
            this.dayViewTimeCells1.View = this.reportDayView1;
            timeOfDayInterval1.End = System.TimeSpan.Parse("18:00:00");
            timeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00");
            this.dayViewTimeCells1.VisibleTime = timeOfDayInterval1;
            this.dayViewTimeCells1.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.dayViewTimeCells1_InitAppointmentDisplayText);
            this.dayViewTimeCells1.AppointmentViewInfoCustomizing += new DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventHandler(this.dayViewTimeCells1_AppointmentViewInfoCustomizing);
            this.dayViewTimeCells1.InitAppointmentImages += new DevExpress.XtraScheduler.AppointmentImagesEventHandler(this.dayViewTimeCells1_InitAppointmentImages);
            // 
            // horizontalDateHeaders1
            // 
            this.horizontalDateHeaders1.Location = new System.Drawing.Point(50, 0);
            this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
            this.horizontalDateHeaders1.Size = new System.Drawing.Size(592, 25);
            this.horizontalDateHeaders1.View = this.reportDayView1;
            // 
            // reportDayView1
            // 
            this.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None;
            this.reportDayView1.VisibleDayCount = 5;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "9.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
        private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;

	}
}
