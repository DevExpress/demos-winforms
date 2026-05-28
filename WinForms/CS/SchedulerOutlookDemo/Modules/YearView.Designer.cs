namespace DevExpress.XtraScheduler.Demos {
    public partial class YearViewModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerPanel = new System.Windows.Forms.Panel();
            this.spOptionPanel = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkStretchAppointments = new DevExpress.XtraEditors.CheckEdit();
            this.cbStretchAppointmentsMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbShowOutOfScopeDays = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbHighlightWeekends = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinAppointmentHeight = new DevExpress.XtraEditors.SpinEdit();
            this.cbFirstDayOfWeek = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinMonthCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.commonRibbon = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            this.schedulerPanel.SuspendLayout();
            this.spOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStretchAppointments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStretchAppointmentsMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowOutOfScopeDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightWeekends.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAppointmentHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFirstDayOfWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMonthCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Year;
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(742, 572);
            this.schedulerControl.Start = new System.DateTime(2019, 12, 29, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl";
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.GanttView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.WeekCount = 3;
            this.schedulerControl.Views.TimelineView.Enabled = false;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Controls.Add(this.spOptionPanel);
            this.schedulerPanel.Controls.Add(this.commonRibbon);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 0);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Size = new System.Drawing.Size(1028, 572);
            this.schedulerPanel.TabIndex = 14;
            // 
            // spOptionPanel
            // 
            this.spOptionPanel.Controls.Add(this.tabPane1);
            this.spOptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPanel.Location = new System.Drawing.Point(742, 0);
            this.spOptionPanel.Name = "spOptionPanel";
            this.spOptionPanel.Size = new System.Drawing.Size(286, 572);
            this.spOptionPanel.TabIndex = 2;
            this.spOptionPanel.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 572);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(285, 572);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Year View Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(285, 539);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkStretchAppointments);
            this.layoutControl1.Controls.Add(this.cbStretchAppointmentsMode);
            this.layoutControl1.Controls.Add(this.cbShowOutOfScopeDays);
            this.layoutControl1.Controls.Add(this.cbHighlightWeekends);
            this.layoutControl1.Controls.Add(this.spinAppointmentHeight);
            this.layoutControl1.Controls.Add(this.cbFirstDayOfWeek);
            this.layoutControl1.Controls.Add(this.spinMonthCount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1050, 0, 650, 1040);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 539);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkStretchAppointments
            // 
            this.chkStretchAppointments.Location = new System.Drawing.Point(5, 151);
            this.chkStretchAppointments.MenuManager = this;
            this.chkStretchAppointments.Name = "chkStretchAppointments";
            this.chkStretchAppointments.Properties.Caption = "Stretch Appointments";
            this.chkStretchAppointments.Size = new System.Drawing.Size(275, 20);
            this.chkStretchAppointments.StyleController = this.layoutControl1;
            this.chkStretchAppointments.TabIndex = 83;
            this.chkStretchAppointments.CheckedChanged += new System.EventHandler(this.chkStretchAppointments_CheckedChanged);
            // 
            // cbStretchAppointmentsMode
            // 
            this.cbStretchAppointmentsMode.Location = new System.Drawing.Point(150, 175);
            this.cbStretchAppointmentsMode.MenuManager = this;
            this.cbStretchAppointmentsMode.Name = "cbStretchAppointmentsMode";
            this.cbStretchAppointmentsMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStretchAppointmentsMode.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.StretchAppointmentsMode.GrowAndShrink,
            DevExpress.XtraScheduler.StretchAppointmentsMode.GrowOnly});
            this.cbStretchAppointmentsMode.Size = new System.Drawing.Size(130, 20);
            this.cbStretchAppointmentsMode.StyleController = this.layoutControl1;
            this.cbStretchAppointmentsMode.TabIndex = 82;
            this.cbStretchAppointmentsMode.SelectedIndexChanged += new System.EventHandler(this.cbStretchAppointmentsMode_SelectedIndexChanged);
            // 
            // cbShowOutOfScopeDays
            // 
            this.cbShowOutOfScopeDays.Location = new System.Drawing.Point(150, 99);
            this.cbShowOutOfScopeDays.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbShowOutOfScopeDays.MenuManager = this;
            this.cbShowOutOfScopeDays.Name = "cbShowOutOfScopeDays";
            this.cbShowOutOfScopeDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShowOutOfScopeDays.Size = new System.Drawing.Size(130, 20);
            this.cbShowOutOfScopeDays.StyleController = this.layoutControl1;
            this.cbShowOutOfScopeDays.TabIndex = 81;
            this.cbShowOutOfScopeDays.SelectedIndexChanged += new System.EventHandler(this.cbShowOutOfScopeDays_SelectedIndexChanged);
            // 
            // cbHighlightWeekends
            // 
            this.cbHighlightWeekends.Location = new System.Drawing.Point(150, 75);
            this.cbHighlightWeekends.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbHighlightWeekends.MenuManager = this;
            this.cbHighlightWeekends.Name = "cbHighlightWeekends";
            this.cbHighlightWeekends.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHighlightWeekends.Size = new System.Drawing.Size(130, 20);
            this.cbHighlightWeekends.StyleController = this.layoutControl1;
            this.cbHighlightWeekends.TabIndex = 80;
            this.cbHighlightWeekends.SelectedIndexChanged += new System.EventHandler(this.cbHighlightWeekends_SelectedIndexChanged);
            // 
            // spinAppointmentHeight
            // 
            this.spinAppointmentHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAppointmentHeight.Location = new System.Drawing.Point(150, 199);
            this.spinAppointmentHeight.MenuManager = this;
            this.spinAppointmentHeight.Name = "spinAppointmentHeight";
            this.spinAppointmentHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAppointmentHeight.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinAppointmentHeight.Size = new System.Drawing.Size(130, 20);
            this.spinAppointmentHeight.StyleController = this.layoutControl1;
            this.spinAppointmentHeight.TabIndex = 79;
            this.spinAppointmentHeight.EditValueChanged += new System.EventHandler(this.OnAppointmentHeightEditValueChanged);
            // 
            // cbFirstDayOfWeek
            // 
            this.cbFirstDayOfWeek.EditValue = "";
            this.cbFirstDayOfWeek.Location = new System.Drawing.Point(150, 51);
            this.cbFirstDayOfWeek.Name = "cbFirstDayOfWeek";
            this.cbFirstDayOfWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFirstDayOfWeek.Size = new System.Drawing.Size(130, 20);
            this.cbFirstDayOfWeek.StyleController = this.layoutControl1;
            this.cbFirstDayOfWeek.TabIndex = 77;
            this.cbFirstDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.OnFirstDayOfWeekSelectedIndexChanged);
            // 
            // spinMonthCount
            // 
            this.spinMonthCount.EditValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinMonthCount.Location = new System.Drawing.Point(150, 27);
            this.spinMonthCount.Name = "spinMonthCount";
            this.spinMonthCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMonthCount.Properties.IsFloatValue = false;
            this.spinMonthCount.Properties.Mask.EditMask = "N00";
            this.spinMonthCount.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinMonthCount.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinMonthCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinMonthCount.Size = new System.Drawing.Size(130, 20);
            this.spinMonthCount.StyleController = this.layoutControl1;
            this.spinMonthCount.TabIndex = 1;
            this.spinMonthCount.EditValueChanged += new System.EventHandler(this.OnMonthCountEditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupView,
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 539);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupView
            // 
            this.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.groupView.Location = new System.Drawing.Point(0, 0);
            this.groupView.Name = "groupView";
            this.groupView.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupView.Size = new System.Drawing.Size(285, 124);
            this.groupView.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupView.Text = "View";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.spinMonthCount;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "Month Count:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem1.Text = "Month Count:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbFirstDayOfWeek;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem5.Text = "First Day of Week:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbHighlightWeekends;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem2.Text = "Highlight Weekends";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbShowOutOfScopeDays;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem4.Text = "Show Out of Scope Days";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(133, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 224);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 315);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 124);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(285, 100);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Appointment Options";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinAppointmentHeight;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem3.Text = "Height:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cbStretchAppointmentsMode;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "cbStretchAppointmentsMode";
            this.layoutControlItem8.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem8.Text = "Stretch Appointments Mode";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(133, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkStretchAppointments;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem7.TextVisible = false;
            // 
            // commonRibbon
            // 
            this.commonRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon.Name = "commonRibbon";
            this.commonRibbon.Size = new System.Drawing.Size(1028, 0);
            this.commonRibbon.SwitchViewPageGroupVisible = false;
            this.commonRibbon.TabIndex = 1;
            this.commonRibbon.TabStop = false;
            this.commonRibbon.Tutorial = this;
            // 
            // YearViewModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "YearViewModule";
            this.Size = new System.Drawing.Size(1028, 572);
            this.Load += new System.EventHandler(this.YearView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            this.schedulerPanel.ResumeLayout(false);
            this.spOptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkStretchAppointments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStretchAppointmentsMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowOutOfScopeDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlightWeekends.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAppointmentHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFirstDayOfWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMonthCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SchedulerDataStorage schedulerDataStorage1;
        private UI.SchedulerBarController schedulerBarController1;
        private SchedulerControl schedulerControl;
        private System.Windows.Forms.Panel schedulerPanel;
        private XtraEditors.SidePanel spOptionPanel;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.ImageComboBoxEdit cbFirstDayOfWeek;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup groupView;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CommonRibbon commonRibbon;
        private XtraEditors.SpinEdit spinMonthCount;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraEditors.SpinEdit spinAppointmentHeight;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.ImageComboBoxEdit cbShowOutOfScopeDays;
        private XtraEditors.ImageComboBoxEdit cbHighlightWeekends;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraEditors.CheckEdit chkStretchAppointments;
        private XtraEditors.ComboBoxEdit cbStretchAppointmentsMode;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem7;
    }
}
