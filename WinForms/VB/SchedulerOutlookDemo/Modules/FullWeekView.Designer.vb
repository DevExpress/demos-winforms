Namespace DevExpress.XtraScheduler.Demos

    Partial Class FullWeekViewModule

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
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.schedulerPanel = New System.Windows.Forms.Panel()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.spOptionPanel = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkStretchAppointments = New DevExpress.XtraEditors.CheckEdit()
            Me.spinAppointmentWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.spinColumnWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.cbColumnWidthMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbTimeMarkerStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkCustomGroup = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStatusOrientation = New DevExpress.XtraEditors.CheckEdit()
            Me.cbTimeMarkerVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkShowOverAppointment = New DevExpress.XtraEditors.CheckEdit()
            Me.cbAllDayStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbTimeIndicatorVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chkAppointmentShadows = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowDayHeaders = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowAllDayArea = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupAppointment = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupCurrentTimeVisualization = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.spOptionPanel.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinAppointmentWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinColumnWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbColumnWidthMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbAllDayStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAppointmentShadows.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowDayHeaders.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowAllDayArea.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupCurrentTimeVisualization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek
            Me.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl1.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.MenuManager = Me
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl1.Size = New System.Drawing.Size(791, 631)
            Me.schedulerControl1.Start = New System.DateTime(2014, 8, 17, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 2
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl1.PopupMenuShowing, New DevExpress.XtraScheduler.PopupMenuShowingEventHandler(AddressOf Me.schedulerControl_PopupMenuShowing)
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
            Me.schedulerBarController1.Control = Me.schedulerControl1
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.Controls.Add(Me.schedulerControl1)
            Me.schedulerPanel.Controls.Add(Me.commonRibbon1)
            Me.schedulerPanel.Controls.Add(Me.spOptionPanel)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(1077, 631)
            Me.schedulerPanel.TabIndex = 6
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(791, 0)
            Me.commonRibbon1.SwitchViewPageGroupVisible = False
            Me.commonRibbon1.TabIndex = 3
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' spOptionPanel
            ' 
            Me.spOptionPanel.Controls.Add(Me.tabPane1)
            Me.spOptionPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPanel.Location = New System.Drawing.Point(791, 0)
            Me.spOptionPanel.Name = "spOptionPanel"
            Me.spOptionPanel.Size = New System.Drawing.Size(286, 631)
            Me.spOptionPanel.TabIndex = 4
            Me.spOptionPanel.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 631)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage2
            Me.tabPane1.Size = New System.Drawing.Size(285, 631)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "FullWeek View Options"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(285, 598)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.chkStretchAppointments)
            Me.layoutControl1.Controls.Add(Me.spinAppointmentWidth)
            Me.layoutControl1.Controls.Add(Me.spinColumnWidth)
            Me.layoutControl1.Controls.Add(Me.cbColumnWidthMode)
            Me.layoutControl1.Controls.Add(Me.cbTimeMarkerStyle)
            Me.layoutControl1.Controls.Add(Me.chkCustomGroup)
            Me.layoutControl1.Controls.Add(Me.chkStatusOrientation)
            Me.layoutControl1.Controls.Add(Me.cbTimeMarkerVisibility)
            Me.layoutControl1.Controls.Add(Me.chkShowOverAppointment)
            Me.layoutControl1.Controls.Add(Me.cbAllDayStatus)
            Me.layoutControl1.Controls.Add(Me.cbStatus)
            Me.layoutControl1.Controls.Add(Me.cbTimeIndicatorVisibility)
            Me.layoutControl1.Controls.Add(Me.cbSnapToCellsMode)
            Me.layoutControl1.Controls.Add(Me.chkAppointmentShadows)
            Me.layoutControl1.Controls.Add(Me.chkShowDayHeaders)
            Me.layoutControl1.Controls.Add(Me.chkShowAllDayArea)
            Me.layoutControl1.Controls.Add(Me.chkShowWorkTimeOnly)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 598)
            Me.layoutControl1.TabIndex = 0
            ' 
            ' chkStretchAppointments
            ' 
            Me.chkStretchAppointments.Location = New System.Drawing.Point(12, 254)
            Me.chkStretchAppointments.MenuManager = Me
            Me.chkStretchAppointments.Name = "chkStretchAppointments"
            Me.chkStretchAppointments.Properties.Caption = "Stretch Appointments"
            Me.chkStretchAppointments.Size = New System.Drawing.Size(261, 20)
            Me.chkStretchAppointments.StyleController = Me.layoutControl1
            Me.chkStretchAppointments.TabIndex = 96
            AddHandler Me.chkStretchAppointments.CheckedChanged, New System.EventHandler(AddressOf Me.chkStretchAppointmentsCheckedChanged)
            ' 
            ' spinAppointmentWidth
            ' 
            Me.spinAppointmentWidth.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinAppointmentWidth.Location = New System.Drawing.Point(160, 154)
            Me.spinAppointmentWidth.MenuManager = Me
            Me.spinAppointmentWidth.Name = "spinAppointmentWidth"
            Me.spinAppointmentWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinAppointmentWidth.Size = New System.Drawing.Size(113, 20)
            Me.spinAppointmentWidth.StyleController = Me.layoutControl1
            Me.spinAppointmentWidth.TabIndex = 95
            AddHandler Me.spinAppointmentWidth.EditValueChanged, New System.EventHandler(AddressOf Me.spinAppointmentWidthEditValueChanged)
            ' 
            ' spinColumnWidth
            ' 
            Me.spinColumnWidth.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinColumnWidth.Location = New System.Drawing.Point(160, 130)
            Me.spinColumnWidth.MenuManager = Me
            Me.spinColumnWidth.Name = "spinColumnWidth"
            Me.spinColumnWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinColumnWidth.Size = New System.Drawing.Size(113, 20)
            Me.spinColumnWidth.StyleController = Me.layoutControl1
            Me.spinColumnWidth.TabIndex = 94
            AddHandler Me.spinColumnWidth.EditValueChanged, New System.EventHandler(AddressOf Me.spinColumnWidthEditValueChanged)
            ' 
            ' cbColumnWidthMode
            ' 
            Me.cbColumnWidthMode.Location = New System.Drawing.Point(160, 106)
            Me.cbColumnWidthMode.MenuManager = Me
            Me.cbColumnWidthMode.Name = "cbColumnWidthMode"
            Me.cbColumnWidthMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbColumnWidthMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.ColumnWidthMode.Fixed, DevExpress.XtraScheduler.ColumnWidthMode.Auto})
            Me.cbColumnWidthMode.Size = New System.Drawing.Size(113, 20)
            Me.cbColumnWidthMode.StyleController = Me.layoutControl1
            Me.cbColumnWidthMode.TabIndex = 93
            AddHandler Me.cbColumnWidthMode.EditValueChanged, New System.EventHandler(AddressOf Me.cbColumnWidthModeEditValueChanged)
            ' 
            ' cbTimeMarkerStyle
            ' 
            Me.cbTimeMarkerStyle.Location = New System.Drawing.Point(160, 460)
            Me.cbTimeMarkerStyle.MenuManager = Me
            Me.cbTimeMarkerStyle.Name = "cbTimeMarkerStyle"
            Me.cbTimeMarkerStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerStyle.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerStyle.[Default], DevExpress.XtraScheduler.TimeMarkerStyle.Line, DevExpress.XtraScheduler.TimeMarkerStyle.Appearance, CType(((DevExpress.XtraScheduler.TimeMarkerStyle.Line Or DevExpress.XtraScheduler.TimeMarkerStyle.Appearance)), DevExpress.XtraScheduler.TimeMarkerStyle)})
            Me.cbTimeMarkerStyle.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeMarkerStyle.StyleController = Me.layoutControl1
            Me.cbTimeMarkerStyle.TabIndex = 92
            AddHandler Me.cbTimeMarkerStyle.EditValueChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerStyle_EditValueChanged)
            ' 
            ' chkCustomGroup
            ' 
            Me.chkCustomGroup.Location = New System.Drawing.Point(12, 178)
            Me.chkCustomGroup.MenuManager = Me
            Me.chkCustomGroup.Name = "chkCustomGroup"
            Me.chkCustomGroup.Properties.Caption = "Appointment Group By Category"
            Me.chkCustomGroup.Size = New System.Drawing.Size(261, 20)
            Me.chkCustomGroup.StyleController = Me.layoutControl1
            Me.chkCustomGroup.TabIndex = 6
            AddHandler Me.chkCustomGroup.CheckedChanged, New System.EventHandler(AddressOf Me.chkCustomGroup_CheckedChanged)
            ' 
            ' chkStatusOrientation
            ' 
            Me.chkStatusOrientation.EditValue = True
            Me.chkStatusOrientation.Location = New System.Drawing.Point(12, 350)
            Me.chkStatusOrientation.MenuManager = Me
            Me.chkStatusOrientation.Name = "chkStatusOrientation"
            Me.chkStatusOrientation.Properties.Caption = "Show All-Day Appointment Status Vertically"
            Me.chkStatusOrientation.Size = New System.Drawing.Size(261, 20)
            Me.chkStatusOrientation.StyleController = Me.layoutControl1
            Me.chkStatusOrientation.TabIndex = 91
            AddHandler Me.chkStatusOrientation.CheckedChanged, New System.EventHandler(AddressOf Me.chkStatusOrientation_CheckedChanged)
            ' 
            ' cbTimeMarkerVisibility
            ' 
            Me.cbTimeMarkerVisibility.Location = New System.Drawing.Point(160, 484)
            Me.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility"
            Me.cbTimeMarkerVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerVisibility.Always, DevExpress.XtraScheduler.TimeMarkerVisibility.Never, DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView})
            Me.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeMarkerVisibility.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeMarkerVisibility.StyleController = Me.layoutControl1
            Me.cbTimeMarkerVisibility.TabIndex = 4
            AddHandler Me.cbTimeMarkerVisibility.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerVisibility_SelectedIndexChanged)
            ' 
            ' chkShowOverAppointment
            ' 
            Me.chkShowOverAppointment.Location = New System.Drawing.Point(12, 532)
            Me.chkShowOverAppointment.Name = "chkShowOverAppointment"
            Me.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment"
            Me.chkShowOverAppointment.Size = New System.Drawing.Size(261, 20)
            Me.chkShowOverAppointment.StyleController = Me.layoutControl1
            Me.chkShowOverAppointment.TabIndex = 2
            AddHandler Me.chkShowOverAppointment.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowOverAppointment_CheckedChanged)
            ' 
            ' cbAllDayStatus
            ' 
            Me.cbAllDayStatus.EditValue = ""
            Me.cbAllDayStatus.Location = New System.Drawing.Point(160, 302)
            Me.cbAllDayStatus.Name = "cbAllDayStatus"
            Me.cbAllDayStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAllDayStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbAllDayStatus.Size = New System.Drawing.Size(113, 20)
            Me.cbAllDayStatus.StyleController = Me.layoutControl1
            Me.cbAllDayStatus.TabIndex = 87
            AddHandler Me.cbAllDayStatus.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbAllDayStatus_SelectedIndexChanged)
            ' 
            ' cbStatus
            ' 
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(160, 326)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(113, 20)
            Me.cbStatus.StyleController = Me.layoutControl1
            Me.cbStatus.TabIndex = 89
            AddHandler Me.cbStatus.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbStatus_SelectedIndexChanged)
            ' 
            ' cbTimeIndicatorVisibility
            ' 
            Me.cbTimeIndicatorVisibility.Location = New System.Drawing.Point(160, 508)
            Me.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility"
            Me.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeIndicatorVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeIndicatorVisibility.Always, DevExpress.XtraScheduler.TimeIndicatorVisibility.Never, DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView, DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate})
            Me.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeIndicatorVisibility.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeIndicatorVisibility.StyleController = Me.layoutControl1
            Me.cbTimeIndicatorVisibility.TabIndex = 1
            AddHandler Me.cbTimeIndicatorVisibility.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTimeIndicatorVisibility_SelectedIndexChanged)
            ' 
            ' cbSnapToCellsMode
            ' 
            Me.cbSnapToCellsMode.Location = New System.Drawing.Point(160, 278)
            Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
            Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSnapToCellsMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)})
            Me.cbSnapToCellsMode.Size = New System.Drawing.Size(113, 20)
            Me.cbSnapToCellsMode.StyleController = Me.layoutControl1
            Me.cbSnapToCellsMode.TabIndex = 90
            AddHandler Me.cbSnapToCellsMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbSnapToCellsMode_SelectedIndexChanged)
            ' 
            ' chkAppointmentShadows
            ' 
            Me.chkAppointmentShadows.Location = New System.Drawing.Point(12, 374)
            Me.chkAppointmentShadows.Name = "chkAppointmentShadows"
            Me.chkAppointmentShadows.Properties.Caption = "Appointment Shadows"
            Me.chkAppointmentShadows.Size = New System.Drawing.Size(261, 20)
            Me.chkAppointmentShadows.StyleController = Me.layoutControl1
            Me.chkAppointmentShadows.TabIndex = 2
            AddHandler Me.chkAppointmentShadows.CheckedChanged, New System.EventHandler(AddressOf Me.chkAppointmentShadows_CheckedChanged)
            ' 
            ' chkShowDayHeaders
            ' 
            Me.chkShowDayHeaders.Location = New System.Drawing.Point(12, 34)
            Me.chkShowDayHeaders.Name = "chkShowDayHeaders"
            Me.chkShowDayHeaders.Properties.Caption = "Show Day Headers"
            Me.chkShowDayHeaders.Size = New System.Drawing.Size(261, 20)
            Me.chkShowDayHeaders.StyleController = Me.layoutControl1
            Me.chkShowDayHeaders.TabIndex = 3
            AddHandler Me.chkShowDayHeaders.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowDayHeaders_CheckedChanged)
            ' 
            ' chkShowAllDayArea
            ' 
            Me.chkShowAllDayArea.Location = New System.Drawing.Point(12, 58)
            Me.chkShowAllDayArea.Name = "chkShowAllDayArea"
            Me.chkShowAllDayArea.Properties.Caption = "Show All Day Area"
            Me.chkShowAllDayArea.Size = New System.Drawing.Size(261, 20)
            Me.chkShowAllDayArea.StyleController = Me.layoutControl1
            Me.chkShowAllDayArea.TabIndex = 1
            AddHandler Me.chkShowAllDayArea.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowAllDayArea_CheckedChanged)
            ' 
            ' chkShowWorkTimeOnly
            ' 
            Me.chkShowWorkTimeOnly.Location = New System.Drawing.Point(12, 82)
            Me.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly"
            Me.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only"
            Me.chkShowWorkTimeOnly.Size = New System.Drawing.Size(261, 20)
            Me.chkShowWorkTimeOnly.StyleController = Me.layoutControl1
            Me.chkShowWorkTimeOnly.TabIndex = 0
            AddHandler Me.chkShowWorkTimeOnly.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowWorkTimeOnly_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.groupView, Me.groupAppointment, Me.groupCurrentTimeVisualization, Me.emptySpaceItem4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 598)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 210)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(285, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 416)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(285, 10)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 564)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(285, 34)
            ' 
            ' groupView
            ' 
            Me.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem13, Me.layoutControlItem14, Me.layoutControlItem16, Me.layoutControlItem15})
            Me.groupView.Location = New System.Drawing.Point(0, 0)
            Me.groupView.Name = "groupView"
            Me.groupView.Size = New System.Drawing.Size(285, 210)
            Me.groupView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupView.Text = "View"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkShowWorkTimeOnly
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkShowDayHeaders
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkShowAllDayArea
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.cbColumnWidthMode
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem13.Text = "Column Width Mode"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.spinColumnWidth
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem14.Text = "Column Width"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.spinAppointmentWidth
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem16.Text = "Appointment Width"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.chkCustomGroup
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' groupAppointment
            ' 
            Me.groupAppointment.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupAppointment.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem5, Me.layoutControlItem12, Me.layoutControlItem17})
            Me.groupAppointment.Location = New System.Drawing.Point(0, 220)
            Me.groupAppointment.Name = "groupAppointment"
            Me.groupAppointment.Size = New System.Drawing.Size(285, 186)
            Me.groupAppointment.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupAppointment.Text = "Appointment"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbStatus
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem4.Text = "Appointment Status:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.cbSnapToCellsMode
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem6.Text = "Snap To Cells Mode:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbAllDayStatus
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem7.Text = "All-Day Appointment Status:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.chkAppointmentShadows
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.chkStatusOrientation
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.chkStretchAppointments
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' groupCurrentTimeVisualization
            ' 
            Me.groupCurrentTimeVisualization.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupCurrentTimeVisualization.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem8, Me.layoutControlItem11})
            Me.groupCurrentTimeVisualization.Location = New System.Drawing.Point(0, 426)
            Me.groupCurrentTimeVisualization.Name = "groupCurrentTimeVisualization"
            Me.groupCurrentTimeVisualization.Size = New System.Drawing.Size(285, 138)
            Me.groupCurrentTimeVisualization.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupCurrentTimeVisualization.Text = "Current Time Visualization"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.cbTimeIndicatorVisibility
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem9.Text = "TimeIndicator Visibility:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.chkShowOverAppointment
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.cbTimeMarkerVisibility
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem8.Text = "TimeMarker Visibility:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.cbTimeMarkerStyle
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem11.Text = "TimeMarker Style:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 406)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(285, 10)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 309)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(244, 89)
            ' 
            ' FullWeekViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Name = "FullWeekViewModule"
            Me.Size = New System.Drawing.Size(1077, 631)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FullWeekViewModule_Load)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.FullWeekViewModule_VisibleChanged)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.spOptionPanel.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinAppointmentWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinColumnWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbColumnWidthMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbAllDayStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAppointmentShadows.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowDayHeaders.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowAllDayArea.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupCurrentTimeVisualization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerPanel As System.Windows.Forms.Panel

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPanel As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private chkStatusOrientation As DevExpress.XtraEditors.CheckEdit

        Private cbTimeMarkerVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private chkShowOverAppointment As DevExpress.XtraEditors.CheckEdit

        Private cbAllDayStatus As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbTimeIndicatorVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private cbSnapToCellsMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private chkAppointmentShadows As DevExpress.XtraEditors.CheckEdit

        Private chkShowDayHeaders As DevExpress.XtraEditors.CheckEdit

        Private chkShowAllDayArea As DevExpress.XtraEditors.CheckEdit

        Private chkShowWorkTimeOnly As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private groupView As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private groupAppointment As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private groupCurrentTimeVisualization As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private chkCustomGroup As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private cbTimeMarkerStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private spinAppointmentWidth As DevExpress.XtraEditors.SpinEdit

        Private spinColumnWidth As DevExpress.XtraEditors.SpinEdit

        Private cbColumnWidthMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private chkStretchAppointments As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
