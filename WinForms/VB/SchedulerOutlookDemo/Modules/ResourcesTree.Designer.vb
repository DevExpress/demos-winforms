Imports System

Namespace DevExpress.XtraScheduler.Demos

    Partial Class ResourcesTreeModule

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
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
            Me.colDescription = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.colId = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.spinResourcesPerPage = New DevExpress.XtraEditors.SpinEdit()
            Me.chkAutoFilterRow = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAutoHeightCells = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowResourceHeaders = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupResources = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupResourceTree = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.schedulerPanel = New DevExpress.XtraEditors.PanelControl()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.spOptionPane = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.resourcesTree1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinResourcesPerPage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAutoFilterRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAutoHeightCells.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowResourceHeaders.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupResources), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupResourceTree), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.spOptionPane.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' resourcesTree1
            ' 
            Me.resourcesTree1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDescription, Me.colId})
            Me.resourcesTree1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.OptionsView.ShowAutoFilterRow = True
            Me.resourcesTree1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
            Me.resourcesTree1.Size = New System.Drawing.Size(231, 395)
            Me.resourcesTree1.TabIndex = 6
            Me.resourcesTree1.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never
            AddHandler Me.resourcesTree1.LayoutUpdated, New System.EventHandler(AddressOf Me.resourcesTree1_LayoutUpdated)
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Caption"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[String]
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            Me.colDescription.Width = 161
            ' 
            ' colId
            ' 
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            Me.colId.Width = 32
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl1.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl1.DateNavigationBar.ShowViewSelectorButton = True
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(232, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl1.Size = New System.Drawing.Size(270, 395)
            Me.schedulerControl1.Start = New System.DateTime(2011, 10, 19, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.AgendaView.Enabled = False
            Me.schedulerControl1.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.AutoHeightMode = DevExpress.XtraScheduler.SchedulerCellAutoHeightMode.Limited
            Me.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = True
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.GanttView.ResourcesPerPage = 9
            Me.schedulerControl1.Views.GanttView.ShowResourceHeaders = False
            Me.schedulerControl1.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.AutoHeightMode = DevExpress.XtraScheduler.SchedulerCellAutoHeightMode.Limited
            Me.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = True
            Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.TimelineView.ShowResourceHeaders = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.YearView.Enabled = False
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl1.ActiveViewChanged, New System.EventHandler(AddressOf Me.schedulerControl1_ActiveViewChanged)
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.AppointmentDependencies.Mappings.DependentId = "Dependent"
            Me.schedulerDataStorage1.AppointmentDependencies.Mappings.ParentId = "Parent"
            Me.schedulerDataStorage1.AppointmentDependencies.Mappings.Type = "Type"
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            Me.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "Id"
            Me.schedulerDataStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerDataStorage1.Appointments.Mappings.[End] = "EndTime"
            Me.schedulerDataStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerDataStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceId"
            Me.schedulerDataStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerDataStorage1.Appointments.Mappings.Type = "EventType"
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.Resources.Mappings.Caption = "Description"
            Me.schedulerDataStorage1.Resources.Mappings.Id = "Id"
            Me.schedulerDataStorage1.Resources.Mappings.ParentId = "ParentId"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.spinResourcesPerPage)
            Me.layoutControl1.Controls.Add(Me.chkAutoFilterRow)
            Me.layoutControl1.Controls.Add(Me.chkAutoHeightCells)
            Me.layoutControl1.Controls.Add(Me.chkShowResourceHeaders)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 362)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' spinResourcesPerPage
            ' 
            Me.spinResourcesPerPage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinResourcesPerPage.Location = New System.Drawing.Point(117, 27)
            Me.spinResourcesPerPage.Name = "spinResourcesPerPage"
            Me.spinResourcesPerPage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinResourcesPerPage.Properties.IsFloatValue = False
            Me.spinResourcesPerPage.Properties.Mask.EditMask = "N00"
            Me.spinResourcesPerPage.Properties.MaxValue = New Decimal(New Integer() {11, 0, 0, 0})
            Me.spinResourcesPerPage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinResourcesPerPage.Size = New System.Drawing.Size(163, 20)
            Me.spinResourcesPerPage.StyleController = Me.layoutControl1
            Me.spinResourcesPerPage.TabIndex = 5
            AddHandler Me.spinResourcesPerPage.EditValueChanged, New System.EventHandler(AddressOf Me.spinResourcesPerPage_EditValueChanged)
            ' 
            ' chkAutoFilterRow
            ' 
            Me.chkAutoFilterRow.EditValue = True
            Me.chkAutoFilterRow.Location = New System.Drawing.Point(5, 137)
            Me.chkAutoFilterRow.Name = "chkAutoFilterRow"
            Me.chkAutoFilterRow.Properties.Caption = "Show AutoFilter Row"
            Me.chkAutoFilterRow.Size = New System.Drawing.Size(275, 20)
            Me.chkAutoFilterRow.StyleController = Me.layoutControl1
            Me.chkAutoFilterRow.TabIndex = 6
            AddHandler Me.chkAutoFilterRow.CheckedChanged, New System.EventHandler(AddressOf Me.chkAutoFilterRow_CheckedChanged)
            ' 
            ' chkAutoHeightCells
            ' 
            Me.chkAutoHeightCells.EditValue = True
            Me.chkAutoHeightCells.Location = New System.Drawing.Point(5, 75)
            Me.chkAutoHeightCells.Name = "chkAutoHeightCells"
            Me.chkAutoHeightCells.Properties.Caption = "Autoheight"
            Me.chkAutoHeightCells.Size = New System.Drawing.Size(275, 20)
            Me.chkAutoHeightCells.StyleController = Me.layoutControl1
            Me.chkAutoHeightCells.TabIndex = 2
            AddHandler Me.chkAutoHeightCells.CheckedChanged, New System.EventHandler(AddressOf Me.chkAutoHeightCells_CheckedChanged)
            ' 
            ' chkShowResourceHeaders
            ' 
            Me.chkShowResourceHeaders.Location = New System.Drawing.Point(5, 51)
            Me.chkShowResourceHeaders.Name = "chkShowResourceHeaders"
            Me.chkShowResourceHeaders.Properties.Caption = "Show Headers"
            Me.chkShowResourceHeaders.Size = New System.Drawing.Size(275, 20)
            Me.chkShowResourceHeaders.StyleController = Me.layoutControl1
            Me.chkShowResourceHeaders.TabIndex = 3
            AddHandler Me.chkShowResourceHeaders.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowResourceHeaders_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupResources, Me.groupResourceTree, Me.emptySpaceItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 362)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupResources
            ' 
            Me.groupResources.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupResources.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1, Me.layoutControlItem5})
            Me.groupResources.Location = New System.Drawing.Point(0, 0)
            Me.groupResources.Name = "groupResources"
            Me.groupResources.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupResources.Size = New System.Drawing.Size(285, 100)
            Me.groupResources.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupResources.Text = "Resources"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkAutoHeightCells
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkShowResourceHeaders
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.spinResourcesPerPage
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem5.Text = "Resources Per Page:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
            ' 
            ' groupResourceTree
            ' 
            Me.groupResourceTree.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupResourceTree.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.groupResourceTree.Location = New System.Drawing.Point(0, 110)
            Me.groupResourceTree.Name = "groupResourceTree"
            Me.groupResourceTree.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupResourceTree.Size = New System.Drawing.Size(285, 52)
            Me.groupResourceTree.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupResourceTree.Text = "Resource Tree"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkAutoFilterRow
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 162)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(285, 200)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 100)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(285, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl1
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerPanel.Controls.Add(Me.commonRibbon1)
            Me.schedulerPanel.Controls.Add(Me.schedulerControl1)
            Me.schedulerPanel.Controls.Add(Me.sidePanel1)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(502, 395)
            Me.schedulerPanel.TabIndex = 12
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(232, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(270, 0)
            Me.commonRibbon1.TabIndex = 1
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.resourcesTree1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(232, 395)
            Me.sidePanel1.TabIndex = 3
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' spOptionPane
            ' 
            Me.spOptionPane.Controls.Add(Me.tabPane1)
            Me.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPane.Location = New System.Drawing.Point(502, 0)
            Me.spOptionPane.Name = "spOptionPane"
            Me.spOptionPane.Size = New System.Drawing.Size(286, 395)
            Me.spOptionPane.TabIndex = 2
            Me.spOptionPane.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 395)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage2
            Me.tabPane1.Size = New System.Drawing.Size(285, 395)
            Me.tabPane1.TabIndex = 8
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "Options"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(285, 362)
            ' 
            ' ResourcesTreeModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Controls.Add(Me.spOptionPane)
            Me.Name = "ResourcesTreeModule"
            Me.Size = New System.Drawing.Size(788, 395)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ResourcesTreeModule_Load)
            CType((Me.resourcesTree1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinResourcesPerPage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAutoFilterRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAutoHeightCells.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowResourceHeaders.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupResources), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupResourceTree), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.spOptionPane.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private chkShowResourceHeaders As DevExpress.XtraEditors.CheckEdit

        Private chkAutoHeightCells As DevExpress.XtraEditors.CheckEdit

        Private spinResourcesPerPage As DevExpress.XtraEditors.SpinEdit

        Private chkAutoFilterRow As DevExpress.XtraEditors.CheckEdit

        Private colDescription As DevExpress.XtraScheduler.Native.ResourceTreeColumn

        Private colId As DevExpress.XtraScheduler.Native.ResourceTreeColumn

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private schedulerPanel As DevExpress.XtraEditors.PanelControl

        Private groupResources As DevExpress.XtraLayout.LayoutControlGroup

        Private groupResourceTree As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPane As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
