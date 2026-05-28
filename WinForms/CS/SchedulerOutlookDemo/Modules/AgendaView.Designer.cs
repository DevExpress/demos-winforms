namespace DevExpress.XtraScheduler.Demos {
    partial class AgendaViewModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.schedulerPanel = new System.Windows.Forms.Panel();
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.spOptionPane = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceShowLabel = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowResource = new DevExpress.XtraEditors.CheckEdit();
            this.cbStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinDaysCount = new DevExpress.XtraEditors.SpinEdit();
            this.chkAllowHtmlText = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupAppointment = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupResource = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.schedulerPanel.SuspendLayout();
            this.spOptionPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowHtmlText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Agenda;
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(623, 432);
            this.schedulerControl.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 13;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.AgendaView.DayCount = 10;
            this.schedulerControl.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.ResourcesPerPage = 3;
            this.schedulerControl.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
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
            // schedulerPanel
            // 
            this.schedulerPanel.Controls.Add(this.schedulerControl);
            this.schedulerPanel.Controls.Add(this.commonRibbon1);
            this.schedulerPanel.Controls.Add(this.spOptionPane);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 0);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Size = new System.Drawing.Size(909, 432);
            this.schedulerPanel.TabIndex = 13;
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(623, 0);
            this.commonRibbon1.SwitchViewPageGroupVisible = false;
            this.commonRibbon1.TabIndex = 14;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // spOptionPane
            // 
            this.spOptionPane.Controls.Add(this.tabPane1);
            this.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPane.Location = new System.Drawing.Point(623, 0);
            this.spOptionPane.Name = "spOptionPane";
            this.spOptionPane.Size = new System.Drawing.Size(286, 432);
            this.spOptionPane.TabIndex = 15;
            this.spOptionPane.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 432);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(285, 432);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Agenda View Options";
            this.tabNavigationPage2.Controls.Add(this.layoutControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(285, 399);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceShowLabel);
            this.layoutControl1.Controls.Add(this.ceShowResource);
            this.layoutControl1.Controls.Add(this.cbStatus);
            this.layoutControl1.Controls.Add(this.spinDaysCount);
            this.layoutControl1.Controls.Add(this.chkAllowHtmlText);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 399);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceShowLabel
            // 
            this.ceShowLabel.Location = new System.Drawing.Point(5, 113);
            this.ceShowLabel.MenuManager = this;
            this.ceShowLabel.Name = "ceShowLabel";
            this.ceShowLabel.Properties.Caption = "Show Label";
            this.ceShowLabel.Size = new System.Drawing.Size(275, 20);
            this.ceShowLabel.StyleController = this.layoutControl1;
            this.ceShowLabel.TabIndex = 91;
            this.ceShowLabel.CheckedChanged += new System.EventHandler(this.ceShowLabel_CheckedChanged);
            // 
            // ceShowResource
            // 
            this.ceShowResource.Location = new System.Drawing.Point(5, 199);
            this.ceShowResource.MenuManager = this;
            this.ceShowResource.Name = "ceShowResource";
            this.ceShowResource.Properties.Caption = "Show Resource";
            this.ceShowResource.Size = new System.Drawing.Size(275, 20);
            this.ceShowResource.StyleController = this.layoutControl1;
            this.ceShowResource.TabIndex = 92;
            this.ceShowResource.CheckedChanged += new System.EventHandler(this.ceShowResource_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(116, 89);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)});
            this.cbStatus.Size = new System.Drawing.Size(164, 20);
            this.cbStatus.StyleController = this.layoutControl1;
            this.cbStatus.TabIndex = 89;
            this.cbStatus.EditValueChanged += new System.EventHandler(this.cbStatus_EditValueChanged);
            // 
            // spinDaysCount
            // 
            this.spinDaysCount.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinDaysCount.Location = new System.Drawing.Point(116, 27);
            this.spinDaysCount.Name = "spinDaysCount";
            this.spinDaysCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDaysCount.Properties.IsFloatValue = false;
            this.spinDaysCount.Properties.Mask.EditMask = "N00";
            this.spinDaysCount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinDaysCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDaysCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinDaysCount.Size = new System.Drawing.Size(164, 20);
            this.spinDaysCount.StyleController = this.layoutControl1;
            this.spinDaysCount.TabIndex = 5;
            this.spinDaysCount.EditValueChanged += new System.EventHandler(this.spinDaysCount_EditValueChanged);
            // 
            // chkAllowHtmlText
            // 
            this.chkAllowHtmlText.Location = new System.Drawing.Point(5, 137);
            this.chkAllowHtmlText.MenuManager = this;
            this.chkAllowHtmlText.Name = "chkAllowHtmlText";
            this.chkAllowHtmlText.Properties.Caption = "Allow Html Text";
            this.chkAllowHtmlText.Size = new System.Drawing.Size(275, 20);
            this.chkAllowHtmlText.StyleController = this.layoutControl1;
            this.chkAllowHtmlText.TabIndex = 93;
            this.chkAllowHtmlText.CheckedChanged += new System.EventHandler(this.chkAllowHtml_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupView,
            this.groupAppointment,
            this.groupResource,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 399);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupView
            // 
            this.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.groupView.Location = new System.Drawing.Point(0, 0);
            this.groupView.Name = "groupView";
            this.groupView.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupView.Size = new System.Drawing.Size(285, 52);
            this.groupView.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupView.Text = "View";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinDaysCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem2.Text = "Day Count:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 13);
            // 
            // groupAppointment
            // 
            this.groupAppointment.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupAppointment.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.groupAppointment.Location = new System.Drawing.Point(0, 62);
            this.groupAppointment.Name = "groupAppointment";
            this.groupAppointment.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupAppointment.Size = new System.Drawing.Size(285, 100);
            this.groupAppointment.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupAppointment.Text = "Appointment";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbStatus;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem3.Text = "Appointment Status:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceShowLabel;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkAllowHtmlText;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem5.TextVisible = false;
            // 
            // groupResource
            // 
            this.groupResource.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupResource.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.groupResource.Location = new System.Drawing.Point(0, 172);
            this.groupResource.Name = "groupResource";
            this.groupResource.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupResource.Size = new System.Drawing.Size(285, 52);
            this.groupResource.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupResource.Text = "Resource";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceShowResource;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 224);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(285, 175);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 162);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(285, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // AgendaViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Name = "AgendaViewModule";
            this.Size = new System.Drawing.Size(909, 432);
            this.Load += new System.EventHandler(this.AgendaViewModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.schedulerPanel.ResumeLayout(false);
            this.spOptionPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceShowLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDaysCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowHtmlText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SchedulerControl schedulerControl;
        private SchedulerDataStorage schedulerDataStorage1;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraEditors.SpinEdit spinDaysCount;
        private XtraEditors.ImageComboBoxEdit cbStatus;
        private XtraEditors.CheckEdit ceShowLabel;
        private XtraEditors.CheckEdit ceShowResource;
        private System.Windows.Forms.Panel schedulerPanel;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup groupView;
        private XtraLayout.LayoutControlGroup groupAppointment;
        private XtraLayout.LayoutControlGroup groupResource;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private CommonRibbon commonRibbon1;
        private XtraEditors.SidePanel spOptionPane;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraEditors.CheckEdit chkAllowHtmlText;
        private XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
