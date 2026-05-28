Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Partial Class TimelineViewModule

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.spinMaxHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.spinMinHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.chkCustomGroup = New DevExpress.XtraEditors.CheckEdit()
            Me.chkCustomSort = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStretchAppointments = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStatusOrientation = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowOverAppointment = New DevExpress.XtraEditors.CheckEdit()
            Me.cbTimeIndicatorVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btnEditScales = New DevExpress.XtraEditors.SimpleButton()
            Me.chkSelectionBarVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.trckScaleWidth = New DevExpress.XtraEditors.TrackBarControl()
            Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chkAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.spinHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chkSetResourceHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.spinResourceHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.chkCellAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupAppointment = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupSelectionBar = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciResourceHeight = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupTimeScale = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupCurrentTimeVisualization = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerPanel = New DevExpress.XtraEditors.PanelControl()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.spOptionPane = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinMaxHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinMinHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomSort.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkSelectionBarVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trckScaleWidth), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trckScaleWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAutoHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkSetResourceHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinResourceHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCellAutoHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupSelectionBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciResourceHeight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupTimeScale), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupCurrentTimeVisualization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.spOptionPane.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(646, 593)
            Me.schedulerControl.Start = New System.DateTime(2010, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.Enabled = False
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.SelectionBar.Height = 30
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            ' 
            ' schedulerDataStorage
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.spinMaxHeight)
            Me.layoutControl1.Controls.Add(Me.spinMinHeight)
            Me.layoutControl1.Controls.Add(Me.chkCustomGroup)
            Me.layoutControl1.Controls.Add(Me.chkCustomSort)
            Me.layoutControl1.Controls.Add(Me.chkStretchAppointments)
            Me.layoutControl1.Controls.Add(Me.chkStatusOrientation)
            Me.layoutControl1.Controls.Add(Me.chkShowOverAppointment)
            Me.layoutControl1.Controls.Add(Me.cbTimeIndicatorVisibility)
            Me.layoutControl1.Controls.Add(Me.btnEditScales)
            Me.layoutControl1.Controls.Add(Me.chkSelectionBarVisible)
            Me.layoutControl1.Controls.Add(Me.trckScaleWidth)
            Me.layoutControl1.Controls.Add(Me.cbSnapToCellsMode)
            Me.layoutControl1.Controls.Add(Me.chkAutoHeight)
            Me.layoutControl1.Controls.Add(Me.spinHeight)
            Me.layoutControl1.Controls.Add(Me.cbStatus)
            Me.layoutControl1.Controls.Add(Me.chkSetResourceHeight)
            Me.layoutControl1.Controls.Add(Me.spinResourceHeight)
            Me.layoutControl1.Controls.Add(Me.chkCellAutoHeight)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(979, 345, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 560)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' spinMaxHeight
            ' 
            Me.spinMaxHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinMaxHeight.Location = New System.Drawing.Point(126, 171)
            Me.spinMaxHeight.MenuManager = Me
            Me.spinMaxHeight.Name = "spinMaxHeight"
            Me.spinMaxHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinMaxHeight.Properties.IsFloatValue = False
            Me.spinMaxHeight.Properties.Mask.EditMask = "N00"
            Me.spinMaxHeight.Properties.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.spinMaxHeight.Size = New System.Drawing.Size(137, 20)
            Me.spinMaxHeight.StyleController = Me.layoutControl1
            Me.spinMaxHeight.TabIndex = 91
            AddHandler Me.spinMaxHeight.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinMaxHeightEditValueChanged)
            ' 
            ' spinMinHeight
            ' 
            Me.spinMinHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinMinHeight.Location = New System.Drawing.Point(126, 147)
            Me.spinMinHeight.MenuManager = Me
            Me.spinMinHeight.Name = "spinMinHeight"
            Me.spinMinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinMinHeight.Properties.IsFloatValue = False
            Me.spinMinHeight.Properties.Mask.EditMask = "N00"
            Me.spinMinHeight.Properties.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.spinMinHeight.Size = New System.Drawing.Size(137, 20)
            Me.spinMinHeight.StyleController = Me.layoutControl1
            Me.spinMinHeight.TabIndex = 90
            AddHandler Me.spinMinHeight.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinMinHeightEditValueChanged)
            ' 
            ' chkCustomGroup
            ' 
            Me.chkCustomGroup.Location = New System.Drawing.Point(5, 281)
            Me.chkCustomGroup.MenuManager = Me
            Me.chkCustomGroup.Name = "chkCustomGroup"
            Me.chkCustomGroup.Properties.Caption = "Group By Category"
            Me.chkCustomGroup.Size = New System.Drawing.Size(258, 20)
            Me.chkCustomGroup.StyleController = Me.layoutControl1
            Me.chkCustomGroup.TabIndex = 86
            AddHandler Me.chkCustomGroup.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkCustomGroupCheckedChanged)
            ' 
            ' chkCustomSort
            ' 
            Me.chkCustomSort.Location = New System.Drawing.Point(5, 257)
            Me.chkCustomSort.MenuManager = Me
            Me.chkCustomSort.Name = "chkCustomSort"
            Me.chkCustomSort.Properties.Caption = "Sort By Category"
            Me.chkCustomSort.Size = New System.Drawing.Size(258, 20)
            Me.chkCustomSort.StyleController = Me.layoutControl1
            Me.chkCustomSort.TabIndex = 85
            AddHandler Me.chkCustomSort.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkCustomSortCheckedChanged)
            ' 
            ' chkStretchAppointments
            ' 
            Me.chkStretchAppointments.Location = New System.Drawing.Point(5, 233)
            Me.chkStretchAppointments.MenuManager = Me
            Me.chkStretchAppointments.Name = "chkStretchAppointments"
            Me.chkStretchAppointments.Properties.Caption = "Stretch Appointments"
            Me.chkStretchAppointments.Size = New System.Drawing.Size(258, 20)
            Me.chkStretchAppointments.StyleController = Me.layoutControl1
            Me.chkStretchAppointments.TabIndex = 84
            AddHandler Me.chkStretchAppointments.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkStretchAppointmentsCheckedChanged)
            ' 
            ' chkStatusOrientation
            ' 
            Me.chkStatusOrientation.EditValue = True
            Me.chkStatusOrientation.Location = New System.Drawing.Point(5, 99)
            Me.chkStatusOrientation.MenuManager = Me
            Me.chkStatusOrientation.Name = "chkStatusOrientation"
            Me.chkStatusOrientation.Properties.Caption = "Show Appointment Status Vertically"
            Me.chkStatusOrientation.Size = New System.Drawing.Size(258, 20)
            Me.chkStatusOrientation.StyleController = Me.layoutControl1
            Me.chkStatusOrientation.TabIndex = 83
            AddHandler Me.chkStatusOrientation.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkStatusOrientationCheckedChanged)
            ' 
            ' chkShowOverAppointment
            ' 
            Me.chkShowOverAppointment.Location = New System.Drawing.Point(5, 590)
            Me.chkShowOverAppointment.Name = "chkShowOverAppointment"
            Me.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment"
            Me.chkShowOverAppointment.Size = New System.Drawing.Size(258, 20)
            Me.chkShowOverAppointment.StyleController = Me.layoutControl1
            Me.chkShowOverAppointment.TabIndex = 2
            AddHandler Me.chkShowOverAppointment.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkShowOverAppointmentCheckedChanged)
            ' 
            ' cbTimeIndicatorVisibility
            ' 
            Me.cbTimeIndicatorVisibility.Location = New System.Drawing.Point(126, 566)
            Me.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility"
            Me.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeIndicatorVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeIndicatorVisibility.Always, DevExpress.XtraScheduler.TimeIndicatorVisibility.Never, DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView, DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate})
            Me.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeIndicatorVisibility.Size = New System.Drawing.Size(137, 20)
            Me.cbTimeIndicatorVisibility.StyleController = Me.layoutControl1
            Me.cbTimeIndicatorVisibility.TabIndex = 1
            AddHandler Me.cbTimeIndicatorVisibility.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnCbTimeIndicatorVisibilitySelectedIndexChanged)
            ' 
            ' btnEditScales
            ' 
            Me.btnEditScales.ImageOptions.ImageIndex = 2
            Me.btnEditScales.Location = New System.Drawing.Point(5, 502)
            Me.btnEditScales.Name = "btnEditScales"
            Me.btnEditScales.Size = New System.Drawing.Size(258, 22)
            Me.btnEditScales.StyleController = Me.layoutControl1
            Me.btnEditScales.TabIndex = 28
            Me.btnEditScales.Text = "Edit Time&Scales..."
            AddHandler Me.btnEditScales.Click, New System.EventHandler(AddressOf Me.OnBtnEditScalesClick)
            ' 
            ' chkSelectionBarVisible
            ' 
            Me.chkSelectionBarVisible.Location = New System.Drawing.Point(5, 343)
            Me.chkSelectionBarVisible.Name = "chkSelectionBarVisible"
            Me.chkSelectionBarVisible.Properties.Caption = "Show SelectionBar"
            Me.chkSelectionBarVisible.Size = New System.Drawing.Size(258, 20)
            Me.chkSelectionBarVisible.StyleController = Me.layoutControl1
            Me.chkSelectionBarVisible.TabIndex = 68
            AddHandler Me.chkSelectionBarVisible.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkSelectionBarVisibleCheckedChanged)
            ' 
            ' trckScaleWidth
            ' 
            Me.trckScaleWidth.EditValue = 80
            Me.trckScaleWidth.Location = New System.Drawing.Point(126, 453)
            Me.trckScaleWidth.MenuManager = Me
            Me.trckScaleWidth.Name = "trckScaleWidth"
            Me.trckScaleWidth.Properties.LargeChange = 50
            Me.trckScaleWidth.Properties.Maximum = 200
            Me.trckScaleWidth.Properties.Minimum = 20
            Me.trckScaleWidth.Properties.ShowValueToolTip = True
            Me.trckScaleWidth.Properties.SmallChange = 20
            Me.trckScaleWidth.Properties.TickFrequency = 20
            Me.trckScaleWidth.Size = New System.Drawing.Size(137, 45)
            Me.trckScaleWidth.StyleController = Me.layoutControl1
            Me.trckScaleWidth.TabIndex = 29
            Me.trckScaleWidth.Value = 80
            AddHandler Me.trckScaleWidth.EditValueChanged, New System.EventHandler(AddressOf Me.OnTrckScaleWidthEditValueChanged)
            ' 
            ' cbSnapToCellsMode
            ' 
            Me.cbSnapToCellsMode.Location = New System.Drawing.Point(126, 27)
            Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
            Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSnapToCellsMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)})
            Me.cbSnapToCellsMode.Size = New System.Drawing.Size(137, 20)
            Me.cbSnapToCellsMode.StyleController = Me.layoutControl1
            Me.cbSnapToCellsMode.TabIndex = 82
            AddHandler Me.cbSnapToCellsMode.EditValueChanged, New System.EventHandler(AddressOf Me.OnCbSnapToCellsModeEditValueChanged)
            ' 
            ' chkAutoHeight
            ' 
            Me.chkAutoHeight.Location = New System.Drawing.Point(5, 123)
            Me.chkAutoHeight.Name = "chkAutoHeight"
            Me.chkAutoHeight.Properties.Caption = "AutoHeight"
            Me.chkAutoHeight.Size = New System.Drawing.Size(258, 20)
            Me.chkAutoHeight.StyleController = Me.layoutControl1
            Me.chkAutoHeight.TabIndex = 76
            AddHandler Me.chkAutoHeight.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkAutoHeightCheckedChanged)
            ' 
            ' spinHeight
            ' 
            Me.spinHeight.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinHeight.Location = New System.Drawing.Point(126, 75)
            Me.spinHeight.Name = "spinHeight"
            Me.spinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinHeight.Properties.IsFloatValue = False
            Me.spinHeight.Properties.Mask.EditMask = "N00"
            Me.spinHeight.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinHeight.Size = New System.Drawing.Size(137, 20)
            Me.spinHeight.StyleController = Me.layoutControl1
            Me.spinHeight.TabIndex = 77
            AddHandler Me.spinHeight.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinHeightEditValueChanged)
            ' 
            ' cbStatus
            ' 
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(126, 51)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(137, 20)
            Me.cbStatus.StyleController = Me.layoutControl1
            Me.cbStatus.TabIndex = 80
            AddHandler Me.cbStatus.EditValueChanged, New System.EventHandler(AddressOf Me.OnCbStatusEditValueChanged)
            ' 
            ' chkSetResourceHeight
            ' 
            Me.chkSetResourceHeight.Location = New System.Drawing.Point(5, 367)
            Me.chkSetResourceHeight.MenuManager = Me
            Me.chkSetResourceHeight.Name = "chkSetResourceHeight"
            Me.chkSetResourceHeight.Properties.Caption = "Set Resource Height"
            Me.chkSetResourceHeight.Size = New System.Drawing.Size(121, 20)
            Me.chkSetResourceHeight.StyleController = Me.layoutControl1
            Me.chkSetResourceHeight.TabIndex = 87
            AddHandler Me.chkSetResourceHeight.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkFixedResourceHeightCheckedChanged)
            ' 
            ' spinResourceHeight
            ' 
            Me.spinResourceHeight.EditValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinResourceHeight.Location = New System.Drawing.Point(130, 367)
            Me.spinResourceHeight.MenuManager = Me
            Me.spinResourceHeight.Name = "spinResourceHeight"
            Me.spinResourceHeight.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.spinResourceHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinResourceHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinResourceHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinResourceHeight.Properties.IsFloatValue = False
            Me.spinResourceHeight.Properties.Mask.EditMask = "N00"
            Me.spinResourceHeight.Properties.MaxValue = New Decimal(New Integer() {400, 0, 0, 0})
            Me.spinResourceHeight.Properties.MinValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinResourceHeight.Properties.ValidateOnEnterKey = True
            Me.spinResourceHeight.Size = New System.Drawing.Size(133, 20)
            Me.spinResourceHeight.StyleController = Me.layoutControl1
            Me.spinResourceHeight.TabIndex = 88
            AddHandler Me.spinResourceHeight.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinResourceHeightEditValueChanged)
            ' 
            ' chkCellAutoHeight
            ' 
            Me.chkCellAutoHeight.Location = New System.Drawing.Point(5, 391)
            Me.chkCellAutoHeight.MenuManager = Me
            Me.chkCellAutoHeight.Name = "chkCellAutoHeight"
            Me.chkCellAutoHeight.Properties.Caption = "Cell Auto Height"
            Me.chkCellAutoHeight.Size = New System.Drawing.Size(258, 20)
            Me.chkCellAutoHeight.StyleController = Me.layoutControl1
            Me.chkCellAutoHeight.TabIndex = 89
            AddHandler Me.chkCellAutoHeight.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkCellAutoHeightCheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.groupAppointment, Me.emptySpaceItem2, Me.groupSelectionBar, Me.emptySpaceItem3, Me.groupTimeScale, Me.emptySpaceItem4, Me.groupCurrentTimeVisualization, Me.layoutControlGroup2, Me.emptySpaceItem5})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(268, 625)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 306)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(268, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' groupAppointment
            ' 
            Me.groupAppointment.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupAppointment.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem11, Me.layoutControlItem16, Me.layoutControlItem17})
            Me.groupAppointment.Location = New System.Drawing.Point(0, 0)
            Me.groupAppointment.Name = "groupAppointment"
            Me.groupAppointment.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupAppointment.Size = New System.Drawing.Size(268, 196)
            Me.groupAppointment.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupAppointment.Text = "Appointment"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbSnapToCellsMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem2.Text = "Snap To Cells Mode:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbStatus
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem1.Text = "Status:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinHeight
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem3.Text = "Height:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chkAutoHeight
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.chkStatusOrientation
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.spinMinHeight
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem16.Text = "Min Height"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.spinMaxHeight
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem17.Text = "Max Height"
            Me.layoutControlItem17.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 416)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(268, 10)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' groupSelectionBar
            ' 
            Me.groupSelectionBar.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupSelectionBar.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem15, Me.lciResourceHeight, Me.layoutControlItem5})
            Me.groupSelectionBar.Location = New System.Drawing.Point(0, 316)
            Me.groupSelectionBar.Name = "groupSelectionBar"
            Me.groupSelectionBar.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupSelectionBar.Size = New System.Drawing.Size(268, 100)
            Me.groupSelectionBar.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupSelectionBar.Text = "View Layout"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chkSelectionBarVisible
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem15.Control = Me.chkSetResourceHeight
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem15.MaxSize = New System.Drawing.Size(0, 24)
            Me.layoutControlItem15.MinSize = New System.Drawing.Size(125, 24)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(125, 24)
            Me.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' lciResourceHeight
            ' 
            Me.lciResourceHeight.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lciResourceHeight.Control = Me.spinResourceHeight
            Me.lciResourceHeight.Location = New System.Drawing.Point(125, 24)
            Me.lciResourceHeight.Name = "lciResourceHeight"
            Me.lciResourceHeight.Size = New System.Drawing.Size(137, 24)
            Me.lciResourceHeight.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.chkCellAutoHeight
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 529)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(268, 10)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' groupTimeScale
            ' 
            Me.groupTimeScale.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupTimeScale.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem8})
            Me.groupTimeScale.Location = New System.Drawing.Point(0, 426)
            Me.groupTimeScale.Name = "groupTimeScale"
            Me.groupTimeScale.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupTimeScale.Size = New System.Drawing.Size(268, 103)
            Me.groupTimeScale.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupTimeScale.Text = "Time Scale"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.trckScaleWidth
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(262, 49)
            Me.layoutControlItem7.Text = "Scale Width:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.btnEditScales
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 49)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(262, 26)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 615)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(268, 10)
            ' 
            ' groupCurrentTimeVisualization
            ' 
            Me.groupCurrentTimeVisualization.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupCurrentTimeVisualization.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10, Me.layoutControlItem9})
            Me.groupCurrentTimeVisualization.Location = New System.Drawing.Point(0, 539)
            Me.groupCurrentTimeVisualization.Name = "groupCurrentTimeVisualization"
            Me.groupCurrentTimeVisualization.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupCurrentTimeVisualization.Size = New System.Drawing.Size(268, 76)
            Me.groupCurrentTimeVisualization.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupCurrentTimeVisualization.Text = "Current Time Visualization"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.chkShowOverAppointment
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.cbTimeIndicatorVisibility
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem9.Text = "TimeIndicator Visibility:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12, Me.layoutControlItem13, Me.layoutControlItem14})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 206)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(268, 100)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Appointment Layout"
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.chkStretchAppointments
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.chkCustomSort
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.chkCustomGroup
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(262, 24)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 196)
            Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(268, 10)
            Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem5.Text = "emptySpaceItem1"
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerPanel.Controls.Add(Me.schedulerControl)
            Me.schedulerPanel.Controls.Add(Me.commonRibbon1)
            Me.schedulerPanel.Controls.Add(Me.spOptionPane)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(932, 593)
            Me.schedulerPanel.TabIndex = 12
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(646, 0)
            Me.commonRibbon1.TabIndex = 1
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' spOptionPane
            ' 
            Me.spOptionPane.Controls.Add(Me.tabPane1)
            Me.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPane.Location = New System.Drawing.Point(646, 0)
            Me.spOptionPane.Name = "spOptionPane"
            Me.spOptionPane.Size = New System.Drawing.Size(286, 593)
            Me.spOptionPane.TabIndex = 2
            Me.spOptionPane.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 593)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(285, 593)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Timeline View Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(285, 560)
            ' 
            ' TimelineViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Name = "TimelineViewModule"
            Me.Size = New System.Drawing.Size(932, 593)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnTimelineViewModuleLoad)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.OnTimelineViewModuleVisibleChanged)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinMaxHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinMinHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomSort.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkSelectionBarVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trckScaleWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trckScaleWidth), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAutoHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkSetResourceHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinResourceHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCellAutoHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupSelectionBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciResourceHeight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupTimeScale), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupCurrentTimeVisualization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.spOptionPane.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private btnEditScales As DevExpress.XtraEditors.SimpleButton

        Private spinHeight As DevExpress.XtraEditors.SpinEdit

        Private chkAutoHeight As DevExpress.XtraEditors.CheckEdit

        Private chkSelectionBarVisible As DevExpress.XtraEditors.CheckEdit

        Private cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private cbSnapToCellsMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private trckScaleWidth As DevExpress.XtraEditors.TrackBarControl

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private chkShowOverAppointment As DevExpress.XtraEditors.CheckEdit

        Private cbTimeIndicatorVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private schedulerPanel As DevExpress.XtraEditors.PanelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private groupAppointment As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private groupSelectionBar As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private groupTimeScale As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private groupCurrentTimeVisualization As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private chkStatusOrientation As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPane As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private chkStretchAppointments As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private chkCustomGroup As DevExpress.XtraEditors.CheckEdit

        Private chkCustomSort As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private chkSetResourceHeight As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private spinResourceHeight As DevExpress.XtraEditors.SpinEdit

        Private lciResourceHeight As DevExpress.XtraLayout.LayoutControlItem

        Private chkCellAutoHeight As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private spinMaxHeight As DevExpress.XtraEditors.SpinEdit

        Private spinMinHeight As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
