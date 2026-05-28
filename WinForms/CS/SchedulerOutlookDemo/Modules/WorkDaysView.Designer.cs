namespace DevExpress.XtraScheduler.Demos {
	partial class WorkWeekViewModule {
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
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.schedulerPanel = new System.Windows.Forms.Panel();
            this.spOptionsPane = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbTimeMarkerStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkCustomGroup = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowWorkTimeOnly = new DevExpress.XtraEditors.CheckEdit();
            this.weekDaysCheckEdit1 = new DevExpress.XtraScheduler.UI.WeekDaysCheckEdit();
            this.cbTimeMarkerVisibility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTimeIndicatorVisibility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkShowOverAppointment = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.schedulerPanel.SuspendLayout();
            this.spOptionsPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCustomGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowWorkTimeOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(887, 505);
            this.schedulerControl.Start = new System.DateTime(2017, 10, 2, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.DayCount = 3;
            this.schedulerControl.Views.DayView.Enabled = false;
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.GanttView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.Enabled = false;
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.TimelineView.Enabled = false;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl_PopupMenuShowing);
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
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Controls.Add(this.spOptionsPane);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 0);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Size = new System.Drawing.Size(1173, 505);
            this.schedulerPanel.TabIndex = 11;
            // 
            // spOptionsPane
            // 
            this.spOptionsPane.Controls.Add(this.tabPane1);
            this.spOptionsPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionsPane.Location = new System.Drawing.Point(887, 0);
            this.spOptionsPane.Name = "spOptionsPane";
            this.spOptionsPane.Size = new System.Drawing.Size(286, 505);
            this.spOptionsPane.TabIndex = 9;
            this.spOptionsPane.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 505);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(285, 505);
            this.tabPane1.TabIndex = 10;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "WorkWeek View Options";
            this.tabNavigationPage2.Controls.Add(this.layoutControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(285, 472);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbTimeMarkerStyle);
            this.layoutControl1.Controls.Add(this.chkCustomGroup);
            this.layoutControl1.Controls.Add(this.chkShowWorkTimeOnly);
            this.layoutControl1.Controls.Add(this.weekDaysCheckEdit1);
            this.layoutControl1.Controls.Add(this.cbTimeMarkerVisibility);
            this.layoutControl1.Controls.Add(this.cbTimeIndicatorVisibility);
            this.layoutControl1.Controls.Add(this.chkShowOverAppointment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 252, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 472);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbTimeMarkerStyle
            // 
            this.cbTimeMarkerStyle.Location = new System.Drawing.Point(133, 226);
            this.cbTimeMarkerStyle.MenuManager = this;
            this.cbTimeMarkerStyle.Name = "cbTimeMarkerStyle";
            this.cbTimeMarkerStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeMarkerStyle.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeMarkerStyle.Default,
            DevExpress.XtraScheduler.TimeMarkerStyle.Line,
            DevExpress.XtraScheduler.TimeMarkerStyle.Appearance,
            ((DevExpress.XtraScheduler.TimeMarkerStyle)((DevExpress.XtraScheduler.TimeMarkerStyle.Line | DevExpress.XtraScheduler.TimeMarkerStyle.Appearance)))});
            this.cbTimeMarkerStyle.Size = new System.Drawing.Size(140, 20);
            this.cbTimeMarkerStyle.StyleController = this.layoutControl1;
            this.cbTimeMarkerStyle.TabIndex = 11;
            this.cbTimeMarkerStyle.EditValueChanged += new System.EventHandler(this.cbTimeMarkerStyle_EditValueChanged);
            // 
            // chkCustomGroup
            // 
            this.chkCustomGroup.Location = new System.Drawing.Point(12, 160);
            this.chkCustomGroup.MenuManager = this;
            this.chkCustomGroup.Name = "chkCustomGroup";
            this.chkCustomGroup.Properties.Caption = "Group By Category";
            this.chkCustomGroup.Size = new System.Drawing.Size(261, 20);
            this.chkCustomGroup.StyleController = this.layoutControl1;
            this.chkCustomGroup.TabIndex = 10;
            this.chkCustomGroup.CheckedChanged += new System.EventHandler(this.chkCustomGroup_CheckedChanged);
            // 
            // chkShowWorkTimeOnly
            // 
            this.chkShowWorkTimeOnly.Location = new System.Drawing.Point(12, 364);
            this.chkShowWorkTimeOnly.MenuManager = this;
            this.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly";
            this.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only";
            this.chkShowWorkTimeOnly.Size = new System.Drawing.Size(261, 20);
            this.chkShowWorkTimeOnly.StyleController = this.layoutControl1;
            this.chkShowWorkTimeOnly.TabIndex = 8;
            this.chkShowWorkTimeOnly.CheckedChanged += new System.EventHandler(this.chkShowWorkTimeOnly_CheckedChanged);
            // 
            // weekDaysCheckEdit1
            // 
            this.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weekDaysCheckEdit1.Appearance.Options.UseBackColor = true;
            this.weekDaysCheckEdit1.Location = new System.Drawing.Point(12, 34);
            this.weekDaysCheckEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.weekDaysCheckEdit1.MinimumSize = new System.Drawing.Size(0, 80);
            this.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1";
            this.weekDaysCheckEdit1.Size = new System.Drawing.Size(261, 80);
            this.weekDaysCheckEdit1.TabIndex = 4;
            this.weekDaysCheckEdit1.WeekDaysChanged += new System.EventHandler(this.weekDaysCheckEdit1_WeekDaysChanged);
            // 
            // cbTimeMarkerVisibility
            // 
            this.cbTimeMarkerVisibility.Location = new System.Drawing.Point(133, 250);
            this.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility";
            this.cbTimeMarkerVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeMarkerVisibility.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeMarkerVisibility.Always,
            DevExpress.XtraScheduler.TimeMarkerVisibility.Never,
            DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView});
            this.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimeMarkerVisibility.Size = new System.Drawing.Size(140, 20);
            this.cbTimeMarkerVisibility.StyleController = this.layoutControl1;
            this.cbTimeMarkerVisibility.TabIndex = 7;
            this.cbTimeMarkerVisibility.SelectedIndexChanged += new System.EventHandler(this.cbTimeMarkerVisibility_SelectedIndexChanged);
            // 
            // cbTimeIndicatorVisibility
            // 
            this.cbTimeIndicatorVisibility.Location = new System.Drawing.Point(133, 274);
            this.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility";
            this.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimeIndicatorVisibility.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Always,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.Never,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate,
            DevExpress.XtraScheduler.TimeIndicatorVisibility.DaysBeforeToday});
            this.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTimeIndicatorVisibility.Size = new System.Drawing.Size(140, 20);
            this.cbTimeIndicatorVisibility.StyleController = this.layoutControl1;
            this.cbTimeIndicatorVisibility.TabIndex = 5;
            this.cbTimeIndicatorVisibility.SelectedIndexChanged += new System.EventHandler(this.cbTimeIndicatorVisibility_SelectedIndexChanged);
            // 
            // chkShowOverAppointment
            // 
            this.chkShowOverAppointment.Location = new System.Drawing.Point(12, 298);
            this.chkShowOverAppointment.Name = "chkShowOverAppointment";
            this.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment";
            this.chkShowOverAppointment.Size = new System.Drawing.Size(261, 20);
            this.chkShowOverAppointment.StyleController = this.layoutControl1;
            this.chkShowOverAppointment.TabIndex = 6;
            this.chkShowOverAppointment.CheckedChanged += new System.EventHandler(this.chkShowOverAppointment_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.emptySpaceItem3,
            this.layoutControlGroup5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 472);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(285, 126);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Weekdays";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.weekDaysCheckEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(265, 84);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 192);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(285, 138);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Current Time Visualization";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkShowOverAppointment;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbTimeIndicatorVisibility;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem5.Text = "TimeIndicator Visibility:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbTimeMarkerVisibility;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem2.Text = "TimeMarker Visibility:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbTimeMarkerStyle;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem4.Text = "TimeMarker Style:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 330);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(285, 66);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Text = "View";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkShowWorkTimeOnly;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 396);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(285, 76);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 126);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(285, 66);
            this.layoutControlGroup5.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup5.Text = "Appointment Layout";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkCustomGroup;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem7.TextVisible = false;
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(1173, 0);
            this.commonRibbon1.SwitchViewPageGroupVisible = false;
            this.commonRibbon1.TabIndex = 13;
            this.commonRibbon1.Tutorial = this;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // WorkWeekViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Controls.Add(this.commonRibbon1);
            this.Name = "WorkWeekViewModule";
            this.Size = new System.Drawing.Size(1173, 505);
            this.Load += new System.EventHandler(this.WorkWeekViewModule_Load);
            this.VisibleChanged += new System.EventHandler(this.WorkWeekViewModule_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.schedulerPanel.ResumeLayout(false);
            this.spOptionsPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCustomGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowWorkTimeOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeMarkerVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeIndicatorVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOverAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
		private System.ComponentModel.IContainer components = null;
        private UI.SchedulerBarController schedulerBarController1;
        private System.Windows.Forms.Panel schedulerPanel;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.CheckEdit chkShowOverAppointment;
        private XtraEditors.ComboBoxEdit cbTimeMarkerVisibility;
        private XtraEditors.ComboBoxEdit cbTimeIndicatorVisibility;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraEditors.SidePanel spOptionsPane;
        private XtraLayout.LayoutControl layoutControl1;
        private UI.WeekDaysCheckEdit weekDaysCheckEdit1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraEditors.CheckEdit chkShowWorkTimeOnly;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraEditors.CheckEdit chkCustomGroup;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlGroup layoutControlGroup5;
        private XtraEditors.ComboBoxEdit cbTimeMarkerStyle;
        private XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
