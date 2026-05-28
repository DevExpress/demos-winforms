using System;
namespace DevExpress.XtraScheduler.Demos {
    partial class ResourcesTreeModule {
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
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.colDescription = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colId = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spinResourcesPerPage = new DevExpress.XtraEditors.SpinEdit();
            this.chkAutoFilterRow = new DevExpress.XtraEditors.CheckEdit();
            this.chkAutoHeightCells = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowResourceHeaders = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupResources = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupResourceTree = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.schedulerPanel = new DevExpress.XtraEditors.PanelControl();
            this.commonRibbon1 = new DevExpress.XtraScheduler.Demos.CommonRibbon();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.spOptionPane = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinResourcesPerPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoFilterRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHeightCells.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowResourceHeaders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResourceTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerPanel)).BeginInit();
            this.schedulerPanel.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.spOptionPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescription,
            this.colId});
            this.resourcesTree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 0);
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsView.ShowAutoFilterRow = true;
            this.resourcesTree1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.resourcesTree1.SchedulerControl = this.schedulerControl1;
            this.resourcesTree1.Size = new System.Drawing.Size(231, 395);
            this.resourcesTree1.TabIndex = 6;
            this.resourcesTree1.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.resourcesTree1.LayoutUpdated += new System.EventHandler(this.resourcesTree1_LayoutUpdated);
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Caption";
            this.colDescription.Name = "colDescription";
            this.colDescription.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 161;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 32;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl1.DateNavigationBar.ShowViewSelectorButton = true;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(232, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsFlyout.SubjectAutoHeight = true;
            this.schedulerControl1.Size = new System.Drawing.Size(270, 395);
            this.schedulerControl1.Start = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.AutoHeightMode = DevExpress.XtraScheduler.SchedulerCellAutoHeightMode.Limited;
            this.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.GanttView.ResourcesPerPage = 9;
            this.schedulerControl1.Views.GanttView.ShowResourceHeaders = false;
            this.schedulerControl1.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.AutoHeightMode = DevExpress.XtraScheduler.SchedulerCellAutoHeightMode.Limited;
            this.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControl1.Views.TimelineView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.TimelineView.ShowResourceHeaders = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.Enabled = false;
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl1.ActiveViewChanged += new System.EventHandler(this.schedulerControl1_ActiveViewChanged);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.DependentId = "Dependent";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.ParentId = "Parent";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.Type = "Type";
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
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "Id";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndTime";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceId";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartTime";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "EventType";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.Mappings.Caption = "Description";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Id";
            this.schedulerDataStorage1.Resources.Mappings.ParentId = "ParentId";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinResourcesPerPage);
            this.layoutControl1.Controls.Add(this.chkAutoFilterRow);
            this.layoutControl1.Controls.Add(this.chkAutoHeightCells);
            this.layoutControl1.Controls.Add(this.chkShowResourceHeaders);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 362);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinResourcesPerPage
            // 
            this.spinResourcesPerPage.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinResourcesPerPage.Location = new System.Drawing.Point(117, 27);
            this.spinResourcesPerPage.Name = "spinResourcesPerPage";
            this.spinResourcesPerPage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinResourcesPerPage.Properties.IsFloatValue = false;
            this.spinResourcesPerPage.Properties.Mask.EditMask = "N00";
            this.spinResourcesPerPage.Properties.MaxValue = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.spinResourcesPerPage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinResourcesPerPage.Size = new System.Drawing.Size(163, 20);
            this.spinResourcesPerPage.StyleController = this.layoutControl1;
            this.spinResourcesPerPage.TabIndex = 5;
            this.spinResourcesPerPage.EditValueChanged += new System.EventHandler(this.spinResourcesPerPage_EditValueChanged);
            // 
            // chkAutoFilterRow
            // 
            this.chkAutoFilterRow.EditValue = true;
            this.chkAutoFilterRow.Location = new System.Drawing.Point(5, 137);
            this.chkAutoFilterRow.Name = "chkAutoFilterRow";
            this.chkAutoFilterRow.Properties.Caption = "Show AutoFilter Row";
            this.chkAutoFilterRow.Size = new System.Drawing.Size(275, 20);
            this.chkAutoFilterRow.StyleController = this.layoutControl1;
            this.chkAutoFilterRow.TabIndex = 6;
            this.chkAutoFilterRow.CheckedChanged += new System.EventHandler(this.chkAutoFilterRow_CheckedChanged);
            // 
            // chkAutoHeightCells
            // 
            this.chkAutoHeightCells.EditValue = true;
            this.chkAutoHeightCells.Location = new System.Drawing.Point(5, 75);
            this.chkAutoHeightCells.Name = "chkAutoHeightCells";
            this.chkAutoHeightCells.Properties.Caption = "Autoheight";
            this.chkAutoHeightCells.Size = new System.Drawing.Size(275, 20);
            this.chkAutoHeightCells.StyleController = this.layoutControl1;
            this.chkAutoHeightCells.TabIndex = 2;
            this.chkAutoHeightCells.CheckedChanged += new System.EventHandler(this.chkAutoHeightCells_CheckedChanged);
            // 
            // chkShowResourceHeaders
            // 
            this.chkShowResourceHeaders.Location = new System.Drawing.Point(5, 51);
            this.chkShowResourceHeaders.Name = "chkShowResourceHeaders";
            this.chkShowResourceHeaders.Properties.Caption = "Show Headers";
            this.chkShowResourceHeaders.Size = new System.Drawing.Size(275, 20);
            this.chkShowResourceHeaders.StyleController = this.layoutControl1;
            this.chkShowResourceHeaders.TabIndex = 3;
            this.chkShowResourceHeaders.CheckedChanged += new System.EventHandler(this.chkShowResourceHeaders_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupResources,
            this.groupResourceTree,
            this.emptySpaceItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 362);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupResources
            // 
            this.groupResources.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupResources.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.groupResources.Location = new System.Drawing.Point(0, 0);
            this.groupResources.Name = "groupResources";
            this.groupResources.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupResources.Size = new System.Drawing.Size(285, 100);
            this.groupResources.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupResources.Text = "Resources";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkAutoHeightCells;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkShowResourceHeaders;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinResourcesPerPage;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem5.Text = "Resources Per Page:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(100, 13);
            // 
            // groupResourceTree
            // 
            this.groupResourceTree.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupResourceTree.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.groupResourceTree.Location = new System.Drawing.Point(0, 110);
            this.groupResourceTree.Name = "groupResourceTree";
            this.groupResourceTree.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.groupResourceTree.Size = new System.Drawing.Size(285, 52);
            this.groupResourceTree.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupResourceTree.Text = "Resource Tree";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkAutoFilterRow;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 162);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(285, 200);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 100);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.Control = this.schedulerControl1;
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerPanel.Controls.Add(this.commonRibbon1);
            this.schedulerPanel.Controls.Add(this.schedulerControl1);
            this.schedulerPanel.Controls.Add(this.sidePanel1);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 0);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Size = new System.Drawing.Size(502, 395);
            this.schedulerPanel.TabIndex = 12;
            // 
            // commonRibbon1
            // 
            this.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonRibbon1.Location = new System.Drawing.Point(232, 0);
            this.commonRibbon1.Name = "commonRibbon1";
            this.commonRibbon1.Size = new System.Drawing.Size(270, 0);
            this.commonRibbon1.TabIndex = 1;
            this.commonRibbon1.TabStop = false;
            this.commonRibbon1.Tutorial = this;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.resourcesTree1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(232, 395);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // spOptionPane
            // 
            this.spOptionPane.Controls.Add(this.tabPane1);
            this.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.spOptionPane.Location = new System.Drawing.Point(502, 0);
            this.spOptionPane.Name = "spOptionPane";
            this.spOptionPane.Size = new System.Drawing.Size(286, 395);
            this.spOptionPane.TabIndex = 2;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(285, 395);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(285, 395);
            this.tabPane1.TabIndex = 8;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Options";
            this.tabNavigationPage2.Controls.Add(this.layoutControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(285, 362);
            // 
            // ResourcesTreeModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerPanel);
            this.Controls.Add(this.spOptionPane);
            this.Name = "ResourcesTreeModule";
            this.Size = new System.Drawing.Size(788, 395);
            this.Load += new System.EventHandler(this.ResourcesTreeModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinResourcesPerPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoFilterRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoHeightCells.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowResourceHeaders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupResourceTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerPanel)).EndInit();
            this.schedulerPanel.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.spOptionPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private SchedulerControl schedulerControl1;
        private SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraEditors.CheckEdit chkShowResourceHeaders;
        private DevExpress.XtraEditors.CheckEdit chkAutoHeightCells;
        private DevExpress.XtraEditors.SpinEdit spinResourcesPerPage;
        private DevExpress.XtraEditors.CheckEdit chkAutoFilterRow;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colDescription;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colId;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraEditors.PanelControl schedulerPanel;
        private XtraLayout.LayoutControlGroup groupResources;
        private XtraLayout.LayoutControlGroup groupResourceTree;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraScheduler.Demos.CommonRibbon commonRibbon1;
        private XtraEditors.SidePanel spOptionPane;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraEditors.SidePanel sidePanel1;
    }

}
