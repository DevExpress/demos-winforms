using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.XtraGantt.Demos {
    partial class SoftwareDevelopment {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareDevelopment));
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.taskNameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.startDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.finishDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resourcesColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.constraintTypeColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.constraintDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cpeCriticalPathDependencies = new DevExpress.XtraEditors.ColorPickEdit();
            this.cpeCriticalPathTasks = new DevExpress.XtraEditors.ColorPickEdit();
            this.icbSchedulingMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbTooltipLocation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceAllowModifyTasks = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowModifyDependencies = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowModifyProgress = new DevExpress.XtraEditors.CheckEdit();
            this.constraintTypeComboBox = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.constraintDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.optionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpeCriticalPathDependencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeCriticalPathTasks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSchedulingMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTooltipLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyTasks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyDependencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintTypeComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.taskNameColumn,
            this.startDateColumn,
            this.finishDateColumn,
            this.resourcesColumn,
            this.constraintTypeColumn,
            this.constraintDateColumn});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.FixedLineWidth = 1;
            this.ganttControl1.HorzScrollStep = 2;
            this.ganttControl1.Location = new System.Drawing.Point(0, 0);
            this.ganttControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ganttControl1.MinWidth = 16;
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Auto;
            this.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsPrint.ShowPrintExportProgress = true;
            this.ganttControl1.OptionsSplitter.OverlayResizeZoneThickness = 3;
            this.ganttControl1.OptionsSplitter.SplitterThickness = 0;
            this.ganttControl1.OptionsView.ShowIndentAsRowStyle = true;
            this.ganttControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.ganttControl1.Size = new System.Drawing.Size(647, 520);
            this.ganttControl1.SplitterPosition = 400;
            this.ganttControl1.TabIndex = 0;
            this.ganttControl1.TimescaleRulerHeight = 0;
            this.ganttControl1.ToolTipController = this.toolTipController1;
            this.ganttControl1.TreeLevelWidth = 12;
            this.ganttControl1.TreeListMappings.HierarchyColumn = this.taskNameColumn;
            this.ganttControl1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.ganttControl1_FocusedNodeChanged);
            this.ganttControl1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.ganttControl1_CellValueChanged);
            this.ganttControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ganttControl1_MouseMove);
            // 
            // taskNameColumn
            // 
            this.taskNameColumn.Caption = "Task Name";
            this.taskNameColumn.FieldName = "Name";
            this.taskNameColumn.MinWidth = 16;
            this.taskNameColumn.Name = "taskNameColumn";
            this.taskNameColumn.Visible = true;
            this.taskNameColumn.VisibleIndex = 0;
            this.taskNameColumn.Width = 141;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Caption = "Start Date";
            this.startDateColumn.FieldName = "StartDate";
            this.startDateColumn.MinWidth = 16;
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.Visible = true;
            this.startDateColumn.VisibleIndex = 1;
            this.startDateColumn.Width = 63;
            // 
            // finishDateColumn
            // 
            this.finishDateColumn.Caption = "Finish Date";
            this.finishDateColumn.FieldName = "FinishDate";
            this.finishDateColumn.MinWidth = 16;
            this.finishDateColumn.Name = "finishDateColumn";
            this.finishDateColumn.Visible = true;
            this.finishDateColumn.VisibleIndex = 2;
            this.finishDateColumn.Width = 63;
            // 
            // resourcesColumn
            // 
            this.resourcesColumn.Caption = "Resources";
            this.resourcesColumn.FieldName = "Resources";
            this.resourcesColumn.MinWidth = 16;
            this.resourcesColumn.Name = "resourcesColumn";
            this.resourcesColumn.Visible = true;
            this.resourcesColumn.VisibleIndex = 3;
            this.resourcesColumn.Width = 99;
            // 
            // constraintTypeColumn
            // 
            this.constraintTypeColumn.AccessibleName = "ConstraintType";
            this.constraintTypeColumn.ColumnEdit = this.repositoryItemImageComboBox1;
            this.constraintTypeColumn.FieldName = "ConstraintType";
            this.constraintTypeColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.constraintTypeColumn.ImageOptions.SvgImage = global::DevExpress.XtraGantt.Demos.Properties.Resources.Constraints;
            this.constraintTypeColumn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.constraintTypeColumn.MaxWidth = 35;
            this.constraintTypeColumn.Name = "constraintTypeColumn";
            this.constraintTypeColumn.OptionsColumn.AllowEdit = false;
            this.constraintTypeColumn.OptionsColumn.AllowFocus = false;
            this.constraintTypeColumn.OptionsColumn.AllowMove = false;
            this.constraintTypeColumn.OptionsColumn.AllowSize = false;
            this.constraintTypeColumn.OptionsColumn.AllowSort = false;
            this.constraintTypeColumn.OptionsFilter.AllowAutoFilter = false;
            this.constraintTypeColumn.OptionsFilter.AllowFilter = false;
            this.constraintTypeColumn.ToolTip = "ConstraintType";
            this.constraintTypeColumn.Visible = true;
            this.constraintTypeColumn.VisibleIndex = 4;
            this.constraintTypeColumn.Width = 34;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 5, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 6, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 7, 7)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.svgImageCollection1;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("As Soon As Possible", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.As Soon As Possible"))));
            this.svgImageCollection1.Add("As Late As Possible", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.As Late As Possible"))));
            this.svgImageCollection1.Add("Start No Earlier", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Start No Earlier"))));
            this.svgImageCollection1.Add("Start No Later", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Start No Later"))));
            this.svgImageCollection1.Add("Finish No Earlier", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Finish No Earlier"))));
            this.svgImageCollection1.Add("Finish No Later", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Finish No Later"))));
            this.svgImageCollection1.Add("Must Start On", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Must Start On"))));
            this.svgImageCollection1.Add("Must Finish On", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Must Finish On"))));
            // 
            // constraintDateColumn
            // 
            this.constraintDateColumn.Caption = "constraintDateColumn";
            this.constraintDateColumn.FieldName = "ConstraintDate";
            this.constraintDateColumn.Name = "constraintDateColumn";
            this.constraintDateColumn.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.tabPane1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(647, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(227, 520);
            this.sidePanel2.TabIndex = 3;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.optionsPage);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.optionsPage});
            this.tabPane1.RegularSize = new System.Drawing.Size(226, 520);
            this.tabPane1.SelectedPage = this.optionsPage;
            this.tabPane1.Size = new System.Drawing.Size(226, 520);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // optionsPage
            // 
            this.optionsPage.Caption = "Options";
            this.optionsPage.Controls.Add(this.layoutControl1);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Size = new System.Drawing.Size(226, 487);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cpeCriticalPathDependencies);
            this.layoutControl1.Controls.Add(this.cpeCriticalPathTasks);
            this.layoutControl1.Controls.Add(this.icbSchedulingMode);
            this.layoutControl1.Controls.Add(this.icbTooltipLocation);
            this.layoutControl1.Controls.Add(this.ceAllowModifyTasks);
            this.layoutControl1.Controls.Add(this.ceAllowModifyDependencies);
            this.layoutControl1.Controls.Add(this.ceAllowModifyProgress);
            this.layoutControl1.Controls.Add(this.constraintTypeComboBox);
            this.layoutControl1.Controls.Add(this.constraintDateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(596, 693, 914, 620);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(226, 487);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cpeCriticalPathDependencies
            // 
            this.cpeCriticalPathDependencies.EditValue = System.Drawing.Color.Empty;
            this.cpeCriticalPathDependencies.Location = new System.Drawing.Point(12, 409);
            this.cpeCriticalPathDependencies.Name = "cpeCriticalPathDependencies";
            this.cpeCriticalPathDependencies.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeCriticalPathDependencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeCriticalPathDependencies.Size = new System.Drawing.Size(202, 20);
            this.cpeCriticalPathDependencies.StyleController = this.layoutControl1;
            this.cpeCriticalPathDependencies.TabIndex = 14;
            this.cpeCriticalPathDependencies.EditValueChanged += new System.EventHandler(this.cpeCriticalPathDependencies_EditValueChanged);
            // 
            // cpeCriticalPathTasks
            // 
            this.cpeCriticalPathTasks.EditValue = System.Drawing.Color.Empty;
            this.cpeCriticalPathTasks.Location = new System.Drawing.Point(12, 369);
            this.cpeCriticalPathTasks.Name = "cpeCriticalPathTasks";
            this.cpeCriticalPathTasks.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeCriticalPathTasks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeCriticalPathTasks.Size = new System.Drawing.Size(202, 20);
            this.cpeCriticalPathTasks.StyleController = this.layoutControl1;
            this.cpeCriticalPathTasks.TabIndex = 13;
            this.cpeCriticalPathTasks.EditValueChanged += new System.EventHandler(this.cpeCriticalPathTasks_EditValueChanged);
            // 
            // icbSchedulingMode
            // 
            this.icbSchedulingMode.Location = new System.Drawing.Point(12, 50);
            this.icbSchedulingMode.Name = "icbSchedulingMode";
            this.icbSchedulingMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSchedulingMode.Size = new System.Drawing.Size(202, 20);
            this.icbSchedulingMode.StyleController = this.layoutControl1;
            this.icbSchedulingMode.TabIndex = 4;
            this.icbSchedulingMode.SelectedIndexChanged += new System.EventHandler(this.icbSchedulingMode_SelectedIndexChanged);
            // 
            // icbTooltipLocation
            // 
            this.icbTooltipLocation.Location = new System.Drawing.Point(12, 287);
            this.icbTooltipLocation.Name = "icbTooltipLocation";
            this.icbTooltipLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbTooltipLocation.Size = new System.Drawing.Size(202, 20);
            this.icbTooltipLocation.StyleController = this.layoutControl1;
            this.icbTooltipLocation.TabIndex = 8;
            this.icbTooltipLocation.SelectedIndexChanged += new System.EventHandler(this.icbTooltipLocation_SelectedIndexChanged);
            // 
            // ceAllowModifyTasks
            // 
            this.ceAllowModifyTasks.Location = new System.Drawing.Point(12, 196);
            this.ceAllowModifyTasks.Name = "ceAllowModifyTasks";
            this.ceAllowModifyTasks.Properties.Caption = "Allow Modify Tasks";
            this.ceAllowModifyTasks.Size = new System.Drawing.Size(202, 20);
            this.ceAllowModifyTasks.StyleController = this.layoutControl1;
            this.ceAllowModifyTasks.TabIndex = 9;
            this.ceAllowModifyTasks.CheckedChanged += new System.EventHandler(this.ceAllowModifyTasks_CheckedChanged);
            // 
            // ceAllowModifyDependencies
            // 
            this.ceAllowModifyDependencies.Location = new System.Drawing.Point(12, 220);
            this.ceAllowModifyDependencies.Name = "ceAllowModifyDependencies";
            this.ceAllowModifyDependencies.Properties.Caption = "Allow Modify Task Dependencies";
            this.ceAllowModifyDependencies.Size = new System.Drawing.Size(202, 20);
            this.ceAllowModifyDependencies.StyleController = this.layoutControl1;
            this.ceAllowModifyDependencies.TabIndex = 10;
            this.ceAllowModifyDependencies.CheckedChanged += new System.EventHandler(this.ceAllowModifyDependencies_CheckedChanged);
            // 
            // ceAllowModifyProgress
            // 
            this.ceAllowModifyProgress.Location = new System.Drawing.Point(12, 244);
            this.ceAllowModifyProgress.Name = "ceAllowModifyProgress";
            this.ceAllowModifyProgress.Properties.Caption = "Allow Modify Task Porgress";
            this.ceAllowModifyProgress.Size = new System.Drawing.Size(202, 20);
            this.ceAllowModifyProgress.StyleController = this.layoutControl1;
            this.ceAllowModifyProgress.TabIndex = 11;
            this.ceAllowModifyProgress.CheckedChanged += new System.EventHandler(this.ceAllowModifyProgress_CheckedChanged);
            // 
            // constraintTypeComboBox
            // 
            this.constraintTypeComboBox.Location = new System.Drawing.Point(12, 90);
            this.constraintTypeComboBox.Name = "constraintTypeComboBox";
            this.constraintTypeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.constraintTypeComboBox.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("As Soon As Possible", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("As Late As Possible", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Start No Earlier Than", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Start No Later Than", 3, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Finish No Earlier Than", 4, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Finish No Later Than", 5, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Must Start On", 6, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Must Finish On", 7, 7)});
            this.constraintTypeComboBox.Properties.SmallImages = this.svgImageCollection1;
            this.constraintTypeComboBox.Size = new System.Drawing.Size(202, 20);
            this.constraintTypeComboBox.StyleController = this.layoutControl1;
            this.constraintTypeComboBox.TabIndex = 15;
            this.constraintTypeComboBox.EditValueChanged += new System.EventHandler(this.constraintTypeComboBox_EditValueChanged);
            // 
            // constraintDateEdit
            // 
            this.constraintDateEdit.EditValue = null;
            this.constraintDateEdit.Location = new System.Drawing.Point(12, 130);
            this.constraintDateEdit.Name = "constraintDateEdit";
            this.constraintDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.constraintDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.constraintDateEdit.Size = new System.Drawing.Size(202, 20);
            this.constraintDateEdit.StyleController = this.layoutControl1;
            this.constraintDateEdit.TabIndex = 16;
            this.constraintDateEdit.EditValueChanged += new System.EventHandler(this.constraintDateEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(226, 487);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(226, 162);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Auto Scheduling";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.constraintTypeComboBox;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem6.Text = "Constraint Type";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.icbSchedulingMode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem1.Text = "Scheduling Mode";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.constraintDateEdit;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem9.Text = "Constraint Date";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 162);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(226, 157);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Interactive Editing";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceAllowModifyTasks;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceAllowModifyDependencies;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceAllowModifyProgress;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.icbTooltipLocation;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(206, 43);
            this.layoutControlItem5.Text = "Tooltip Location";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 319);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(226, 168);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Critical Path";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cpeCriticalPathTasks;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem7.Text = "Critical Path Tasks";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cpeCriticalPathDependencies;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(206, 86);
            this.layoutControlItem8.Text = "Critical Path Dependencies";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(127, 13);
            // 
            // SoftwareDevelopment
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.sidePanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SoftwareDevelopment";
            this.Size = new System.Drawing.Size(874, 520);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpeCriticalPathDependencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeCriticalPathTasks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSchedulingMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTooltipLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyTasks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyDependencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowModifyProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintTypeComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GanttControl ganttControl1;
        private XtraTreeList.Columns.TreeListColumn taskNameColumn;
        private XtraTreeList.Columns.TreeListColumn startDateColumn;
        private XtraTreeList.Columns.TreeListColumn finishDateColumn;
        private XtraTreeList.Columns.TreeListColumn resourcesColumn;
        private SidePanel sidePanel2;
        private TabPane tabPane1;
        private TabNavigationPage optionsPage;
        private LayoutControl layoutControl1;
        private LayoutControlGroup Root;
        private XtraEditors.ImageComboBoxEdit icbSchedulingMode;
        private XtraEditors.ImageComboBoxEdit icbTooltipLocation;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraEditors.CheckEdit ceAllowModifyTasks;
        private XtraEditors.CheckEdit ceAllowModifyDependencies;
        private XtraEditors.CheckEdit ceAllowModifyProgress;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private ColorPickEdit cpeCriticalPathTasks;
        private LayoutControlItem layoutControlItem7;
        private ColorPickEdit cpeCriticalPathDependencies;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlGroup layoutControlGroup3;
        private XtraTreeList.Columns.TreeListColumn constraintTypeColumn;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private SvgImageCollection svgImageCollection1;
        private ImageComboBoxEdit constraintTypeComboBox;
        private DateEdit constraintDateEdit;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem9;
        private ToolTipController toolTipController1;
        private XtraTreeList.Columns.TreeListColumn constraintDateColumn;
    }
}
