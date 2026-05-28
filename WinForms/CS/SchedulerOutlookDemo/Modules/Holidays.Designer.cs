namespace DevExpress.XtraScheduler.Demos {
    partial class HolidaysModule {
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
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.clbLocations = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnImportFromOutlook = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportFromXml = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.spOptionPane = new DevExpress.XtraEditors.SidePanel();
            this.tpOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.spOptionPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpOptions)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.DateNavigationBar.ShowViewSelectorButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(418, 597);
            this.schedulerControl.Start = new System.DateTime(2010, 6, 20, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 1;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.AgendaView.DayCount = 10;
            this.schedulerControl.Views.DayView.DayCount = 5;
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.GanttView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ShowFullWeek = true;
            this.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl.LayoutViewInfoCustomizing += new System.EventHandler<DevExpress.XtraScheduler.LayoutViewInfoCustomizingEventArgs>(this.schedulerControl_LayoutViewInfoCustomizing);
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
            // clbLocations
            // 
            this.clbLocations.CheckOnClick = true;
            this.clbLocations.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbLocations.Location = new System.Drawing.Point(2, 38);
            this.clbLocations.Name = "clbLocations";
            this.clbLocations.Size = new System.Drawing.Size(281, 524);
            this.clbLocations.StyleController = this.layoutControl1;
            this.clbLocations.TabIndex = 0;
            this.clbLocations.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbLocations_ItemCheck);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.clbLocations);
            this.layoutControl1.Controls.Add(this.btnImportFromOutlook);
            this.layoutControl1.Controls.Add(this.btnImportFromXml);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(911, 343, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 564);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnImportFromOutlook
            // 
            this.btnImportFromOutlook.Location = new System.Drawing.Point(123, 2);
            this.btnImportFromOutlook.Name = "btnImportFromOutlook";
            this.btnImportFromOutlook.Size = new System.Drawing.Size(160, 22);
            this.btnImportFromOutlook.StyleController = this.layoutControl1;
            this.btnImportFromOutlook.TabIndex = 1;
            this.btnImportFromOutlook.Text = "Import Outlook Holidays...";
            this.btnImportFromOutlook.Click += new System.EventHandler(this.btnImportFromOutlook_Click);
            // 
            // btnImportFromXml
            // 
            this.btnImportFromXml.Location = new System.Drawing.Point(2, 2);
            this.btnImportFromXml.Name = "btnImportFromXml";
            this.btnImportFromXml.Size = new System.Drawing.Size(117, 22);
            this.btnImportFromXml.StyleController = this.layoutControl1;
            this.btnImportFromXml.TabIndex = 0;
            this.btnImportFromXml.Text = "Import From Xml...";
            this.btnImportFromXml.Click += new System.EventHandler(this.btnImportFromXml_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 564);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnImportFromXml;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnImportFromOutlook;
            this.layoutControlItem2.Location = new System.Drawing.Point(121, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(164, 26);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.clbLocations;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(285, 528);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(121, 26);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(164, 10);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(121, 10);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
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
            this.commonRibbon1.Size = new System.Drawing.Size(418, 0);
            this.commonRibbon1.TabIndex = 14;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // spOptionPane
            // 
            this.spOptionPane.Controls.Add(this.tpOptions);
            this.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPane.Location = new System.Drawing.Point(418, 0);
            this.spOptionPane.Name = "spOptionPane";
            this.spOptionPane.Size = new System.Drawing.Size(286, 597);
            this.spOptionPane.TabIndex = 15;
            this.spOptionPane.Text = "sidePanel1";
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.tabNavigationPage2);
            this.tpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpOptions.Location = new System.Drawing.Point(1, 0);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2});
            this.tpOptions.RegularSize = new System.Drawing.Size(285, 597);
            this.tpOptions.SelectedPage = this.tabNavigationPage2;
            this.tpOptions.Size = new System.Drawing.Size(285, 597);
            this.tpOptions.TabIndex = 1;
            this.tpOptions.Text = "tabPane1";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Options";
            this.tabNavigationPage2.Controls.Add(this.layoutControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(285, 564);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.schedulerControl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(418, 597);
            this.sidePanel1.TabIndex = 16;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // HolidaysModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.commonRibbon1);
            this.Controls.Add(this.spOptionPane);
            this.Name = "HolidaysModule";
            this.Size = new System.Drawing.Size(704, 597);
            this.Load += new System.EventHandler(this.HolidaysModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.spOptionPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpOptions)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.CheckedListBoxControl clbLocations;
        private DevExpress.XtraEditors.SimpleButton btnImportFromOutlook;
        private DevExpress.XtraEditors.SimpleButton btnImportFromXml;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.SidePanel spOptionPane;
        private XtraBars.Navigation.TabPane tpOptions;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraEditors.SidePanel sidePanel1;
    }
}
