using System;
namespace DevExpress.XtraScheduler.Demos {
	partial class TimeZonesModule {
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
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler7 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler8 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler9 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler10 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.edtTimeZone = new DevExpress.XtraScheduler.UI.TimeZoneEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.spOptionPane = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeZone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.spOptionPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.DateNavigationBar.ShowViewSelectorButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(418, 404);
            this.schedulerControl.Start = new System.DateTime(2010, 7, 5, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.DayCount = 3;
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            timeRuler1.Caption = "GMT";
            timeRuler1.TimeZoneId = "Greenwich Standard Time";
            timeRuler1.UseClientTimeZone = false;
            timeRuler2.Caption = "Local";
            timeRuler4.HorizontalAlignment = DevExpress.XtraScheduler.TimeRulerHorizontalAlignment.Far;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3;
            timeRuler5.Caption = "GMT";
            timeRuler5.TimeZoneId = "Greenwich Standard Time";
            timeRuler5.UseClientTimeZone = false;
            timeRuler6.Caption = "Local";
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler6);
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler7);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.GanttView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.WeekCount = 2;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            timeRuler8.Caption = "GMT";
            timeRuler8.TimeZoneId = "Greenwich Standard Time";
            timeRuler8.UseClientTimeZone = false;
            timeRuler9.Caption = "Local";
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler8);
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler9);
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler10);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage
            // 
            // 
            // 
            // 
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            // 
            // edtTimeZone
            // 
            this.edtTimeZone.Location = new System.Drawing.Point(77, 12);
            this.edtTimeZone.Name = "edtTimeZone";
            this.edtTimeZone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtTimeZone.Size = new System.Drawing.Size(196, 20);
            this.edtTimeZone.StyleController = this.layoutControl1;
            this.edtTimeZone.TabIndex = 1;
            this.edtTimeZone.EditValueChanged += new System.EventHandler(this.edtTimeZone_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.edtTimeZone);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 371);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 371);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edtTimeZone;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem1.Text = "Time Zone:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(265, 327);
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(704, 0);
            this.commonRibbon1.TabIndex = 10;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // spOptionPane
            // 
            this.spOptionPane.Controls.Add(this.tabPane1);
            this.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPane.Location = new System.Drawing.Point(418, 0);
            this.spOptionPane.Name = "spOptionPane";
            this.spOptionPane.Size = new System.Drawing.Size(286, 404);
            this.spOptionPane.TabIndex = 11;
            this.spOptionPane.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 404);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(285, 404);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(285, 371);
            // 
            // TimeZonesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.spOptionPane);
            this.Controls.Add(this.commonRibbon1);
            this.Name = "TimeZonesModule";
            this.Size = new System.Drawing.Size(704, 404);
            this.Load += new System.EventHandler(this.TimeZonesModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimeZone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.spOptionPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
        private System.ComponentModel.IContainer components = null;
        private UI.TimeZoneEdit edtTimeZone;
        private UI.SchedulerBarController schedulerBarController1;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.SidePanel spOptionPane;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
    }
}
