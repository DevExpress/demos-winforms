using DevExpress.XtraScheduler.Native;
namespace DevExpress.XtraScheduler.Demos {
	partial class RangeControlModule {
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
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.rangeControl = new DevExpress.XtraEditors.RangeControl();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.spinThumbnailHeight = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinMaxIntervalCount = new DevExpress.XtraEditors.SpinEdit();
            this.rgrpSchedulerType = new DevExpress.XtraEditors.RadioGroup();
            this.chkAutoFormatCaptions = new DevExpress.XtraEditors.CheckEdit();
            this.cbThumbnailDisplay = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.chkAllowChangeActiveView = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupRangeControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.spOptionPane = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThumbnailHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxIntervalCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpSchedulerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoFormatCaptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThumbnailDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowChangeActiveView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.spOptionPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeControl
            // 
            this.rangeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rangeControl.Client = this.schedulerControl;
            this.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeControl.Location = new System.Drawing.Point(0, 0);
            this.rangeControl.MinimumSize = new System.Drawing.Size(0, 140);
            this.rangeControl.Name = "rangeControl";
            rangeControlRange1.Maximum = new System.DateTime(2025, 6, 2, 0, 0, 0, 0);
            rangeControlRange1.Minimum = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            rangeControlRange1.Owner = this.rangeControl;
            this.rangeControl.SelectedRange = rangeControlRange1;
            this.rangeControl.Size = new System.Drawing.Size(418, 144);
            this.rangeControl.TabIndex = 5;
            this.rangeControl.Text = "rangeControl";
            this.rangeControl.VisibleRangeMaximumScaleFactor = double.PositiveInfinity;
            this.rangeControl.VisibleRangeScaleFactor = 22.06611570247934D;
            // 
            // schedulerControl
            // 
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.DateNavigationBar.ShowViewSelectorButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.LimitInterval.Duration = System.TimeSpan.Parse("364.00:00:00");
            this.schedulerControl.LimitInterval.Start = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.schedulerControl.Location = new System.Drawing.Point(0, 145);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.OptionsRangeControl.AutoAdjustMode = false;
            this.schedulerControl.Size = new System.Drawing.Size(418, 367);
            this.schedulerControl.Start = new System.DateTime(2010, 12, 30, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 6;
            this.schedulerControl.Text = "schedulerControl";
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
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
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.Enabled = false;
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
            // spinThumbnailHeight
            // 
            this.spinThumbnailHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinThumbnailHeight.Location = new System.Drawing.Point(158, 156);
            this.spinThumbnailHeight.Name = "spinThumbnailHeight";
            this.spinThumbnailHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinThumbnailHeight.Properties.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinThumbnailHeight.Properties.IsFloatValue = false;
            this.spinThumbnailHeight.Properties.Mask.EditMask = "N00";
            this.spinThumbnailHeight.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinThumbnailHeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinThumbnailHeight.Size = new System.Drawing.Size(122, 20);
            this.spinThumbnailHeight.StyleController = this.layoutControl1;
            this.spinThumbnailHeight.TabIndex = 4;
            this.spinThumbnailHeight.EditValueChanged += new System.EventHandler(this.spinThumbnailHeight_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.spinThumbnailHeight);
            this.layoutControl1.Controls.Add(this.spinMaxIntervalCount);
            this.layoutControl1.Controls.Add(this.rgrpSchedulerType);
            this.layoutControl1.Controls.Add(this.chkAutoFormatCaptions);
            this.layoutControl1.Controls.Add(this.cbThumbnailDisplay);
            this.layoutControl1.Controls.Add(this.chkAllowChangeActiveView);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 479);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 102;
            this.labelControl1.Text = "Schedule Type";
            // 
            // spinMaxIntervalCount
            // 
            this.spinMaxIntervalCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxIntervalCount.Location = new System.Drawing.Point(158, 180);
            this.spinMaxIntervalCount.Name = "spinMaxIntervalCount";
            this.spinMaxIntervalCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMaxIntervalCount.Properties.IsFloatValue = false;
            this.spinMaxIntervalCount.Properties.Mask.EditMask = "N00";
            this.spinMaxIntervalCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinMaxIntervalCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinMaxIntervalCount.Size = new System.Drawing.Size(122, 20);
            this.spinMaxIntervalCount.StyleController = this.layoutControl1;
            this.spinMaxIntervalCount.TabIndex = 5;
            this.spinMaxIntervalCount.EditValueChanged += new System.EventHandler(this.spinMaxIntervalCount_EditValueChanged);
            // 
            // rgrpSchedulerType
            // 
            this.rgrpSchedulerType.EditValue = 0;
            this.rgrpSchedulerType.Location = new System.Drawing.Point(5, 44);
            this.rgrpSchedulerType.MaximumSize = new System.Drawing.Size(0, 35);
            this.rgrpSchedulerType.Name = "rgrpSchedulerType";
            this.rgrpSchedulerType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgrpSchedulerType.Properties.Appearance.Options.UseBackColor = true;
            this.rgrpSchedulerType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgrpSchedulerType.Properties.Columns = 3;
            this.rgrpSchedulerType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Daily"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Monthly"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Yearly")});
            this.rgrpSchedulerType.Size = new System.Drawing.Size(275, 32);
            this.rgrpSchedulerType.StyleController = this.layoutControl1;
            this.rgrpSchedulerType.TabIndex = 101;
            this.rgrpSchedulerType.SelectedIndexChanged += new System.EventHandler(this.rgrpSchedulerType_SelectedIndexChanged);
            // 
            // chkAutoFormatCaptions
            // 
            this.chkAutoFormatCaptions.Location = new System.Drawing.Point(5, 204);
            this.chkAutoFormatCaptions.Name = "chkAutoFormatCaptions";
            this.chkAutoFormatCaptions.Properties.Caption = "Auto Format Captions";
            this.chkAutoFormatCaptions.Size = new System.Drawing.Size(275, 20);
            this.chkAutoFormatCaptions.StyleController = this.layoutControl1;
            this.chkAutoFormatCaptions.TabIndex = 2;
            this.chkAutoFormatCaptions.CheckedChanged += new System.EventHandler(this.chkAutoFormatCaptions_CheckedChanged);
            // 
            // cbThumbnailDisplay
            // 
            this.cbThumbnailDisplay.EditValue = "";
            this.cbThumbnailDisplay.Location = new System.Drawing.Point(158, 132);
            this.cbThumbnailDisplay.Name = "cbThumbnailDisplay";
            this.cbThumbnailDisplay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThumbnailDisplay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.RangeControlDataDisplayType.Auto, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Thumbnail", DevExpress.XtraScheduler.RangeControlDataDisplayType.Thumbnail, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Number", DevExpress.XtraScheduler.RangeControlDataDisplayType.Number, -1)});
            this.cbThumbnailDisplay.Size = new System.Drawing.Size(122, 20);
            this.cbThumbnailDisplay.StyleController = this.layoutControl1;
            this.cbThumbnailDisplay.TabIndex = 3;
            this.cbThumbnailDisplay.SelectedIndexChanged += new System.EventHandler(this.cbThumbnailDisplay_SelectedIndexChanged);
            // 
            // chkAllowChangeActiveView
            // 
            this.chkAllowChangeActiveView.Location = new System.Drawing.Point(5, 80);
            this.chkAllowChangeActiveView.Name = "chkAllowChangeActiveView";
            this.chkAllowChangeActiveView.Properties.Caption = "Auto Change Scheduler View";
            this.chkAllowChangeActiveView.Size = new System.Drawing.Size(275, 20);
            this.chkAllowChangeActiveView.StyleController = this.layoutControl1;
            this.chkAllowChangeActiveView.TabIndex = 1;
            this.chkAllowChangeActiveView.CheckedChanged += new System.EventHandler(this.chkAllowChangeActiveView_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupView,
            this.groupRangeControl,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 479);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupView
            // 
            this.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.groupView.Location = new System.Drawing.Point(0, 0);
            this.groupView.Name = "groupView";
            this.groupView.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupView.Size = new System.Drawing.Size(285, 105);
            this.groupView.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupView.Text = "View";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(279, 17);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkAllowChangeActiveView;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rgrpSchedulerType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 36);
            this.layoutControlItem2.TextVisible = false;
            // 
            // groupRangeControl
            // 
            this.groupRangeControl.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupRangeControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem3});
            this.groupRangeControl.Location = new System.Drawing.Point(0, 105);
            this.groupRangeControl.Name = "groupRangeControl";
            this.groupRangeControl.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupRangeControl.Size = new System.Drawing.Size(285, 124);
            this.groupRangeControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupRangeControl.Text = "Range Control";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbThumbnailDisplay;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem4.Text = "Display Appointments As:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(141, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinThumbnailHeight;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem5.Text = "Thumbnail Height:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(141, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spinMaxIntervalCount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem6.Text = "Max Selected Interval Count:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(141, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkAutoFormatCaptions;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 229);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 250);
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.schedulerControl);
            this.panelControl1.Controls.Add(this.sidePanel1);
            this.panelControl1.Controls.Add(this.commonRibbon1);
            this.panelControl1.Controls.Add(this.spOptionPane);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(704, 512);
            this.panelControl1.TabIndex = 100;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.rangeControl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(0, 145);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(418, 145);
            this.sidePanel1.TabIndex = 10;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(418, 0);
            this.commonRibbon1.TabIndex = 8;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // spOptionPane
            // 
            this.spOptionPane.Controls.Add(this.tabPane1);
            this.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPane.Location = new System.Drawing.Point(418, 0);
            this.spOptionPane.Name = "spOptionPane";
            this.spOptionPane.Size = new System.Drawing.Size(286, 512);
            this.spOptionPane.TabIndex = 9;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 512);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(285, 512);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(285, 479);
            // 
            // RangeControlModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "RangeControlModule";
            this.Size = new System.Drawing.Size(704, 512);
            this.Load += new System.EventHandler(this.OnModuleLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThumbnailHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxIntervalCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpSchedulerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoFormatCaptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThumbnailDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowChangeActiveView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupRangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.spOptionPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.RangeControl rangeControl;
        private SchedulerControl schedulerControl;
        private DevExpress.XtraEditors.CheckEdit chkAllowChangeActiveView;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbThumbnailDisplay;
        private DevExpress.XtraEditors.CheckEdit chkAutoFormatCaptions;
        private DevExpress.XtraEditors.SpinEdit spinMaxIntervalCount;
        private DevExpress.XtraEditors.RadioGroup rgrpSchedulerType;
        private DevExpress.XtraEditors.SpinEdit spinThumbnailHeight;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlGroup groupView;
        private XtraLayout.LayoutControlGroup groupRangeControl;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.SidePanel spOptionPane;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraEditors.SidePanel sidePanel1;
    }
}
