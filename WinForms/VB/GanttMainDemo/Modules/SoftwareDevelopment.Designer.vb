Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGantt.Demos

    Partial Class SoftwareDevelopment

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGantt.Demos.SoftwareDevelopment))
            Me.ganttControl1 = New DevExpress.XtraGantt.GanttControl()
            Me.taskNameColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.startDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.finishDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.resourcesColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.constraintTypeColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.constraintDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cpeCriticalPathDependencies = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpeCriticalPathTasks = New DevExpress.XtraEditors.ColorPickEdit()
            Me.icbSchedulingMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbTooltipLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAllowModifyTasks = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowModifyDependencies = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowModifyProgress = New DevExpress.XtraEditors.CheckEdit()
            Me.constraintTypeComboBox = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.constraintDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.optionsPage.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cpeCriticalPathDependencies.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cpeCriticalPathTasks.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSchedulingMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbTooltipLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowModifyTasks.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowModifyDependencies.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowModifyProgress.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.constraintTypeComboBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.constraintDateEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.constraintDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ganttControl1
            ' 
            Me.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ganttControl1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.taskNameColumn, Me.startDateColumn, Me.finishDateColumn, Me.resourcesColumn, Me.constraintTypeColumn, Me.constraintDateColumn})
            Me.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl1.FixedLineWidth = 1
            Me.ganttControl1.HorzScrollStep = 2
            Me.ganttControl1.Location = New System.Drawing.Point(0, 0)
            Me.ganttControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.ganttControl1.MinWidth = 16
            Me.ganttControl1.Name = "ganttControl1"
            Me.ganttControl1.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Auto
            Me.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsPrint.ShowPrintExportProgress = True
            Me.ganttControl1.OptionsSplitter.OverlayResizeZoneThickness = 3
            Me.ganttControl1.OptionsSplitter.SplitterThickness = 0
            Me.ganttControl1.OptionsView.ShowIndentAsRowStyle = True
            Me.ganttControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.ganttControl1.Size = New System.Drawing.Size(647, 520)
            Me.ganttControl1.SplitterPosition = 400
            Me.ganttControl1.TabIndex = 0
            Me.ganttControl1.TimescaleRulerHeight = 0
            Me.ganttControl1.ToolTipController = Me.toolTipController1
            Me.ganttControl1.TreeLevelWidth = 12
            Me.ganttControl1.TreeListMappings.HierarchyColumn = Me.taskNameColumn
            AddHandler Me.ganttControl1.FocusedNodeChanged, New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(AddressOf Me.ganttControl1_FocusedNodeChanged)
            AddHandler Me.ganttControl1.CellValueChanged, New DevExpress.XtraTreeList.CellValueChangedEventHandler(AddressOf Me.ganttControl1_CellValueChanged)
            AddHandler Me.ganttControl1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.ganttControl1_MouseMove)
            ' 
            ' taskNameColumn
            ' 
            Me.taskNameColumn.Caption = "Task Name"
            Me.taskNameColumn.FieldName = "Name"
            Me.taskNameColumn.MinWidth = 16
            Me.taskNameColumn.Name = "taskNameColumn"
            Me.taskNameColumn.Visible = True
            Me.taskNameColumn.VisibleIndex = 0
            Me.taskNameColumn.Width = 141
            ' 
            ' startDateColumn
            ' 
            Me.startDateColumn.Caption = "Start Date"
            Me.startDateColumn.FieldName = "StartDate"
            Me.startDateColumn.MinWidth = 16
            Me.startDateColumn.Name = "startDateColumn"
            Me.startDateColumn.Visible = True
            Me.startDateColumn.VisibleIndex = 1
            Me.startDateColumn.Width = 63
            ' 
            ' finishDateColumn
            ' 
            Me.finishDateColumn.Caption = "Finish Date"
            Me.finishDateColumn.FieldName = "FinishDate"
            Me.finishDateColumn.MinWidth = 16
            Me.finishDateColumn.Name = "finishDateColumn"
            Me.finishDateColumn.Visible = True
            Me.finishDateColumn.VisibleIndex = 2
            Me.finishDateColumn.Width = 63
            ' 
            ' resourcesColumn
            ' 
            Me.resourcesColumn.Caption = "Resources"
            Me.resourcesColumn.FieldName = "Resources"
            Me.resourcesColumn.MinWidth = 16
            Me.resourcesColumn.Name = "resourcesColumn"
            Me.resourcesColumn.Visible = True
            Me.resourcesColumn.VisibleIndex = 3
            Me.resourcesColumn.Width = 99
            ' 
            ' constraintTypeColumn
            ' 
            Me.constraintTypeColumn.AccessibleName = "ConstraintType"
            Me.constraintTypeColumn.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.constraintTypeColumn.FieldName = "ConstraintType"
            Me.constraintTypeColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.constraintTypeColumn.ImageOptions.SvgImage = Global.DevExpress.XtraGantt.Demos.Properties.Resources.Constraints
            Me.constraintTypeColumn.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.constraintTypeColumn.MaxWidth = 35
            Me.constraintTypeColumn.Name = "constraintTypeColumn"
            Me.constraintTypeColumn.OptionsColumn.AllowEdit = False
            Me.constraintTypeColumn.OptionsColumn.AllowFocus = False
            Me.constraintTypeColumn.OptionsColumn.AllowMove = False
            Me.constraintTypeColumn.OptionsColumn.AllowSize = False
            Me.constraintTypeColumn.OptionsColumn.AllowSort = False
            Me.constraintTypeColumn.OptionsFilter.AllowAutoFilter = False
            Me.constraintTypeColumn.OptionsFilter.AllowFilter = False
            Me.constraintTypeColumn.ToolTip = "ConstraintType"
            Me.constraintTypeColumn.Visible = True
            Me.constraintTypeColumn.VisibleIndex = 4
            Me.constraintTypeColumn.Width = 34
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 5, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 6, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 7, 7)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("As Soon As Possible", CType((resources.GetObject("svgImageCollection1.As Soon As Possible")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("As Late As Possible", CType((resources.GetObject("svgImageCollection1.As Late As Possible")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Start No Earlier", CType((resources.GetObject("svgImageCollection1.Start No Earlier")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Start No Later", CType((resources.GetObject("svgImageCollection1.Start No Later")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Finish No Earlier", CType((resources.GetObject("svgImageCollection1.Finish No Earlier")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Finish No Later", CType((resources.GetObject("svgImageCollection1.Finish No Later")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Must Start On", CType((resources.GetObject("svgImageCollection1.Must Start On")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Must Finish On", CType((resources.GetObject("svgImageCollection1.Must Finish On")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' constraintDateColumn
            ' 
            Me.constraintDateColumn.Caption = "constraintDateColumn"
            Me.constraintDateColumn.FieldName = "ConstraintDate"
            Me.constraintDateColumn.Name = "constraintDateColumn"
            Me.constraintDateColumn.OptionsColumn.ShowInCustomizationForm = False
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.tabPane1)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel2.Location = New System.Drawing.Point(647, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(227, 520)
            Me.sidePanel2.TabIndex = 3
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.optionsPage)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.optionsPage})
            Me.tabPane1.RegularSize = New System.Drawing.Size(226, 520)
            Me.tabPane1.SelectedPage = Me.optionsPage
            Me.tabPane1.Size = New System.Drawing.Size(226, 520)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' optionsPage
            ' 
            Me.optionsPage.Caption = "Options"
            Me.optionsPage.Controls.Add(Me.layoutControl1)
            Me.optionsPage.Name = "optionsPage"
            Me.optionsPage.Size = New System.Drawing.Size(226, 487)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cpeCriticalPathDependencies)
            Me.layoutControl1.Controls.Add(Me.cpeCriticalPathTasks)
            Me.layoutControl1.Controls.Add(Me.icbSchedulingMode)
            Me.layoutControl1.Controls.Add(Me.icbTooltipLocation)
            Me.layoutControl1.Controls.Add(Me.ceAllowModifyTasks)
            Me.layoutControl1.Controls.Add(Me.ceAllowModifyDependencies)
            Me.layoutControl1.Controls.Add(Me.ceAllowModifyProgress)
            Me.layoutControl1.Controls.Add(Me.constraintTypeComboBox)
            Me.layoutControl1.Controls.Add(Me.constraintDateEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(596, 693, 914, 620)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(226, 487)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cpeCriticalPathDependencies
            ' 
            Me.cpeCriticalPathDependencies.EditValue = System.Drawing.Color.Empty
            Me.cpeCriticalPathDependencies.Location = New System.Drawing.Point(12, 409)
            Me.cpeCriticalPathDependencies.Name = "cpeCriticalPathDependencies"
            Me.cpeCriticalPathDependencies.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.cpeCriticalPathDependencies.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpeCriticalPathDependencies.Size = New System.Drawing.Size(202, 20)
            Me.cpeCriticalPathDependencies.StyleController = Me.layoutControl1
            Me.cpeCriticalPathDependencies.TabIndex = 14
            AddHandler Me.cpeCriticalPathDependencies.EditValueChanged, New System.EventHandler(AddressOf Me.cpeCriticalPathDependencies_EditValueChanged)
            ' 
            ' cpeCriticalPathTasks
            ' 
            Me.cpeCriticalPathTasks.EditValue = System.Drawing.Color.Empty
            Me.cpeCriticalPathTasks.Location = New System.Drawing.Point(12, 369)
            Me.cpeCriticalPathTasks.Name = "cpeCriticalPathTasks"
            Me.cpeCriticalPathTasks.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.cpeCriticalPathTasks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpeCriticalPathTasks.Size = New System.Drawing.Size(202, 20)
            Me.cpeCriticalPathTasks.StyleController = Me.layoutControl1
            Me.cpeCriticalPathTasks.TabIndex = 13
            AddHandler Me.cpeCriticalPathTasks.EditValueChanged, New System.EventHandler(AddressOf Me.cpeCriticalPathTasks_EditValueChanged)
            ' 
            ' icbSchedulingMode
            ' 
            Me.icbSchedulingMode.Location = New System.Drawing.Point(12, 50)
            Me.icbSchedulingMode.Name = "icbSchedulingMode"
            Me.icbSchedulingMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSchedulingMode.Size = New System.Drawing.Size(202, 20)
            Me.icbSchedulingMode.StyleController = Me.layoutControl1
            Me.icbSchedulingMode.TabIndex = 4
            AddHandler Me.icbSchedulingMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbSchedulingMode_SelectedIndexChanged)
            ' 
            ' icbTooltipLocation
            ' 
            Me.icbTooltipLocation.Location = New System.Drawing.Point(12, 287)
            Me.icbTooltipLocation.Name = "icbTooltipLocation"
            Me.icbTooltipLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbTooltipLocation.Size = New System.Drawing.Size(202, 20)
            Me.icbTooltipLocation.StyleController = Me.layoutControl1
            Me.icbTooltipLocation.TabIndex = 8
            AddHandler Me.icbTooltipLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbTooltipLocation_SelectedIndexChanged)
            ' 
            ' ceAllowModifyTasks
            ' 
            Me.ceAllowModifyTasks.Location = New System.Drawing.Point(12, 196)
            Me.ceAllowModifyTasks.Name = "ceAllowModifyTasks"
            Me.ceAllowModifyTasks.Properties.Caption = "Allow Modify Tasks"
            Me.ceAllowModifyTasks.Size = New System.Drawing.Size(202, 20)
            Me.ceAllowModifyTasks.StyleController = Me.layoutControl1
            Me.ceAllowModifyTasks.TabIndex = 9
            AddHandler Me.ceAllowModifyTasks.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowModifyTasks_CheckedChanged)
            ' 
            ' ceAllowModifyDependencies
            ' 
            Me.ceAllowModifyDependencies.Location = New System.Drawing.Point(12, 220)
            Me.ceAllowModifyDependencies.Name = "ceAllowModifyDependencies"
            Me.ceAllowModifyDependencies.Properties.Caption = "Allow Modify Task Dependencies"
            Me.ceAllowModifyDependencies.Size = New System.Drawing.Size(202, 20)
            Me.ceAllowModifyDependencies.StyleController = Me.layoutControl1
            Me.ceAllowModifyDependencies.TabIndex = 10
            AddHandler Me.ceAllowModifyDependencies.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowModifyDependencies_CheckedChanged)
            ' 
            ' ceAllowModifyProgress
            ' 
            Me.ceAllowModifyProgress.Location = New System.Drawing.Point(12, 244)
            Me.ceAllowModifyProgress.Name = "ceAllowModifyProgress"
            Me.ceAllowModifyProgress.Properties.Caption = "Allow Modify Task Porgress"
            Me.ceAllowModifyProgress.Size = New System.Drawing.Size(202, 20)
            Me.ceAllowModifyProgress.StyleController = Me.layoutControl1
            Me.ceAllowModifyProgress.TabIndex = 11
            AddHandler Me.ceAllowModifyProgress.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowModifyProgress_CheckedChanged)
            ' 
            ' constraintTypeComboBox
            ' 
            Me.constraintTypeComboBox.Location = New System.Drawing.Point(12, 90)
            Me.constraintTypeComboBox.Name = "constraintTypeComboBox"
            Me.constraintTypeComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.constraintTypeComboBox.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("As Soon As Possible", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("As Late As Possible", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Start No Earlier Than", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Start No Later Than", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Finish No Earlier Than", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Finish No Later Than", 5, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Must Start On", 6, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Must Finish On", 7, 7)})
            Me.constraintTypeComboBox.Properties.SmallImages = Me.svgImageCollection1
            Me.constraintTypeComboBox.Size = New System.Drawing.Size(202, 20)
            Me.constraintTypeComboBox.StyleController = Me.layoutControl1
            Me.constraintTypeComboBox.TabIndex = 15
            AddHandler Me.constraintTypeComboBox.EditValueChanged, New System.EventHandler(AddressOf Me.constraintTypeComboBox_EditValueChanged)
            ' 
            ' constraintDateEdit
            ' 
            Me.constraintDateEdit.EditValue = Nothing
            Me.constraintDateEdit.Location = New System.Drawing.Point(12, 130)
            Me.constraintDateEdit.Name = "constraintDateEdit"
            Me.constraintDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.constraintDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.constraintDateEdit.Size = New System.Drawing.Size(202, 20)
            Me.constraintDateEdit.StyleController = Me.layoutControl1
            Me.constraintDateEdit.TabIndex = 16
            AddHandler Me.constraintDateEdit.EditValueChanged, New System.EventHandler(AddressOf Me.constraintDateEdit_EditValueChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(226, 487)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem9})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(226, 162)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Auto Scheduling"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.constraintTypeComboBox
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(206, 40)
            Me.layoutControlItem6.Text = "Constraint Type"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.icbSchedulingMode
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(206, 40)
            Me.layoutControlItem1.Text = "Scheduling Mode"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.constraintDateEdit
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(206, 40)
            Me.layoutControlItem9.Text = "Constraint Date"
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 162)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(226, 157)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Interactive Editing"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceAllowModifyTasks
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(206, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceAllowModifyDependencies
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(206, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceAllowModifyProgress
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(206, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.icbTooltipLocation
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(206, 43)
            Me.layoutControlItem5.Text = "Tooltip Location"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 319)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(226, 168)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Critical Path"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cpeCriticalPathTasks
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(206, 40)
            Me.layoutControlItem7.Text = "Critical Path Tasks"
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.cpeCriticalPathDependencies
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(206, 86)
            Me.layoutControlItem8.Text = "Critical Path Dependencies"
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' SoftwareDevelopment
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ganttControl1)
            Me.Controls.Add(Me.sidePanel2)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "SoftwareDevelopment"
            Me.Size = New System.Drawing.Size(874, 520)
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.optionsPage.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cpeCriticalPathDependencies.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cpeCriticalPathTasks.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSchedulingMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbTooltipLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowModifyTasks.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowModifyDependencies.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowModifyProgress.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.constraintTypeComboBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.constraintDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.constraintDateEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ganttControl1 As DevExpress.XtraGantt.GanttControl

        Private taskNameColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private startDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private finishDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private resourcesColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private icbSchedulingMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbTooltipLocation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private ceAllowModifyTasks As DevExpress.XtraEditors.CheckEdit

        Private ceAllowModifyDependencies As DevExpress.XtraEditors.CheckEdit

        Private ceAllowModifyProgress As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private cpeCriticalPathTasks As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private cpeCriticalPathDependencies As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private constraintTypeColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private constraintTypeComboBox As DevExpress.XtraEditors.ImageComboBoxEdit

        Private constraintDateEdit As DevExpress.XtraEditors.DateEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private constraintDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
