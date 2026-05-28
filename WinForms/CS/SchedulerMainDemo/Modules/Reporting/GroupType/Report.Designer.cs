using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraScheduler.Demos.Reporting.GroupType {

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
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.resourceInfo1 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.timeIntervalInfo1,
            this.resourceInfo1,
            this.dayOfWeekHeaders1,
            this.horizontalWeek1});
            this.Detail.Height = 350;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.Location = new System.Drawing.Point(0, 42);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(608, 8);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.Location = new System.Drawing.Point(0, 67);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.Size = new System.Drawing.Size(308, 58);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.Location = new System.Drawing.Point(3, 182);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.ShowMoreItems = false;
            this.horizontalWeek1.Size = new System.Drawing.Size(645, 167);
            this.horizontalWeek1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
            this.horizontalWeek1.View = this.reportWeekView1;
            // 
            // reportWeekView1
            // 
            this.reportWeekView1.VisibleWeekCount = 4;
            // 
            // resourceInfo1
            // 
            this.resourceInfo1.AutoScaleFont = false;
            this.resourceInfo1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 24F);
            this.resourceInfo1.Location = new System.Drawing.Point(0, 0);
            this.resourceInfo1.Name = "resourceInfo1";
            this.resourceInfo1.Size = new System.Drawing.Size(600, 33);
            this.resourceInfo1.TimeCells = this.horizontalWeek1;
            this.resourceInfo1.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // dayOfWeekHeaders1
            //             
            this.dayOfWeekHeaders1.Location = new System.Drawing.Point(3, 157);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.Size = new System.Drawing.Size(645, 25);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
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
		private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;


	}
}
