using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates {

	partial class ReportTemplatesModule {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTemplatesModule));
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.panelSeparatorControl = new DevExpress.XtraEditors.PanelControl();
            this.ControlPrintAdapter1 = new DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparatorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPrintAdapter1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.OptionsBehavior.UseAsyncMode = Program.OptUseAsyncMode;
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl.Location = new System.Drawing.Point(0, 50);
            this.schedulerControl.MenuManager = this;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(704, 331);
            this.schedulerControl.Start = new System.DateTime(2010, 6, 30, 0, 0, 0, 0);
            this.schedulerControl.DataStorage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.OptionsView.EnableAnimation = false;
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00");
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("01:00:00");
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnPreview);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(704, 42);
            this.panelControl.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.ImageIndex = 2;
            this.btnPreview.Location = new System.Drawing.Point(11, 9);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(254, 24);
            this.btnPreview.TabIndex = 87;
            this.btnPreview.Text = "&Preview a report via the template file...";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // panelSeparatorControl
            // 
            this.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparatorControl.Location = new System.Drawing.Point(0, 42);
            this.panelSeparatorControl.Name = "panelSeparatorControl";
            this.panelSeparatorControl.Size = new System.Drawing.Size(704, 8);
            this.panelSeparatorControl.TabIndex = 9;
            // 
            // ControlPrintAdapter1
            // 
            this.ControlPrintAdapter1.SchedulerControl = this.schedulerControl;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(704, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 381);
            this.barDockControlBottom.Size = new System.Drawing.Size(704, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(704, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // ReportTemplatesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.panelSeparatorControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ReportTemplatesModule";
            this.Size = new System.Drawing.Size(704, 404);
            this.Load += new System.EventHandler(this.ReportTemplates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparatorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPrintAdapter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl panelSeparatorControl;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter ControlPrintAdapter1;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlTop;
	}
}
