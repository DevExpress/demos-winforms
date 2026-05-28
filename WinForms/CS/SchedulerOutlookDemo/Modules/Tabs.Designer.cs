namespace DevExpress.XtraScheduler.Demos {
    partial class Tabs {
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
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkShowCloseButton = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowAddButton = new DevExpress.XtraEditors.CheckEdit();
            this.cmbResourceDisplayStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAppointmentDisplayMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cbAppointmentDisplayMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowCloseButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowAddButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResourceDisplayStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointmentDisplayMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAppointmentDisplayMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
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
            // schedulerControl
            // 
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl.DateNavigationBar.ShowViewSelectorButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.MenuManager = this;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl.Size = new System.Drawing.Size(564, 424);
            this.schedulerControl.Start = new System.DateTime(2019, 9, 24, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 1;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(284, 391);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkShowCloseButton);
            this.layoutControl1.Controls.Add(this.chkShowAddButton);
            this.layoutControl1.Controls.Add(this.cmbResourceDisplayStyle);
            this.layoutControl1.Controls.Add(this.cmbAppointmentDisplayMode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(284, 391);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkShowCloseButton
            // 
            this.chkShowCloseButton.Location = new System.Drawing.Point(5, 99);
            this.chkShowCloseButton.MenuManager = this;
            this.chkShowCloseButton.Name = "chkShowCloseButton";
            this.chkShowCloseButton.Properties.Caption = "Show Close Button";
            this.chkShowCloseButton.Size = new System.Drawing.Size(274, 20);
            this.chkShowCloseButton.StyleController = this.layoutControl1;
            this.chkShowCloseButton.TabIndex = 7;
            this.chkShowCloseButton.CheckedChanged += new System.EventHandler(this.chkShowCloseButton_CheckedChanged);
            // 
            // chkShowAddButton
            // 
            this.chkShowAddButton.Location = new System.Drawing.Point(5, 75);
            this.chkShowAddButton.MenuManager = this;
            this.chkShowAddButton.Name = "chkShowAddButton";
            this.chkShowAddButton.Properties.Caption = "Show Add Button";
            this.chkShowAddButton.Size = new System.Drawing.Size(274, 20);
            this.chkShowAddButton.StyleController = this.layoutControl1;
            this.chkShowAddButton.TabIndex = 6;
            this.chkShowAddButton.CheckedChanged += new System.EventHandler(this.chkShowAddButton_CheckedChanged);
            // 
            // cmbResourceDisplayStyle
            // 
            this.cmbResourceDisplayStyle.Location = new System.Drawing.Point(144, 27);
            this.cmbResourceDisplayStyle.MenuManager = this;
            this.cmbResourceDisplayStyle.Name = "cmbResourceDisplayStyle";
            this.cmbResourceDisplayStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResourceDisplayStyle.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.ResourceDisplayStyle.Headers,
            DevExpress.XtraScheduler.ResourceDisplayStyle.Tabs});
            this.cmbResourceDisplayStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbResourceDisplayStyle.Size = new System.Drawing.Size(135, 20);
            this.cmbResourceDisplayStyle.StyleController = this.layoutControl1;
            this.cmbResourceDisplayStyle.TabIndex = 5;
            this.cmbResourceDisplayStyle.SelectedIndexChanged += new System.EventHandler(this.cmbResourceDisplayStyle_SelectedIndexChanged);
            // 
            // cmbAppointmentDisplayMode
            // 
            this.cmbAppointmentDisplayMode.Location = new System.Drawing.Point(144, 51);
            this.cmbAppointmentDisplayMode.MenuManager = this;
            this.cmbAppointmentDisplayMode.Name = "cmbAppointmentDisplayMode";
            this.cmbAppointmentDisplayMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAppointmentDisplayMode.Properties.Items.AddRange(new object[] {
            DevExpress.XtraScheduler.AppointmentDisplayMode.AllResources,
            DevExpress.XtraScheduler.AppointmentDisplayMode.SelectedResource});
            this.cmbAppointmentDisplayMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAppointmentDisplayMode.Size = new System.Drawing.Size(135, 20);
            this.cmbAppointmentDisplayMode.StyleController = this.layoutControl1;
            this.cmbAppointmentDisplayMode.TabIndex = 4;
            this.cmbAppointmentDisplayMode.SelectedIndexChanged += new System.EventHandler(this.cmbAppointmentDisplayMode_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(284, 391);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(284, 267);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cbAppointmentDisplayMode,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(284, 124);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Resource Category Options";
            // 
            // cbAppointmentDisplayMode
            // 
            this.cbAppointmentDisplayMode.Control = this.cmbAppointmentDisplayMode;
            this.cbAppointmentDisplayMode.Location = new System.Drawing.Point(0, 24);
            this.cbAppointmentDisplayMode.Name = "cbAppointmentDisplayMode";
            this.cbAppointmentDisplayMode.Size = new System.Drawing.Size(278, 24);
            this.cbAppointmentDisplayMode.Text = "Appointment Display Mode";
            this.cbAppointmentDisplayMode.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbResourceDisplayStyle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem1.Text = "Resource Display Style";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkShowAddButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkShowCloseButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(284, 424);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(284, 424);
            this.tabPane1.TabIndex = 3;
            this.tabPane1.Text = "tabPane1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.schedulerControl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(564, 424);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.tabPane1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(564, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(285, 424);
            this.sidePanel2.TabIndex = 5;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(0, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(564, 0);
            this.commonRibbon1.TabIndex = 1;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commonRibbon1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel2);
            this.Name = "Tabs";
            this.Size = new System.Drawing.Size(849, 424);
            this.Load += new System.EventHandler(this.Tabs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkShowCloseButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowAddButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResourceDisplayStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointmentDisplayMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAppointmentDisplayMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private SchedulerControl schedulerControl;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.ComboBoxEdit cmbAppointmentDisplayMode;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.SidePanel sidePanel2;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem cbAppointmentDisplayMode;
        private XtraEditors.ComboBoxEdit cmbResourceDisplayStyle;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.CheckEdit chkShowCloseButton;
        private XtraEditors.CheckEdit chkShowAddButton;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
