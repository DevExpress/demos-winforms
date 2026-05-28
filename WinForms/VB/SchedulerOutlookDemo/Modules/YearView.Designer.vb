Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class YearViewModule

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
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerPanel = New System.Windows.Forms.Panel()
            Me.spOptionPanel = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkStretchAppointments = New DevExpress.XtraEditors.CheckEdit()
            Me.cbStretchAppointmentsMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbShowOutOfScopeDays = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbHighlightWeekends = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinAppointmentHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.cbFirstDayOfWeek = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinMonthCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.commonRibbon = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.spOptionPanel.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbStretchAppointmentsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbShowOutOfScopeDays.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbHighlightWeekends.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinAppointmentHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbFirstDayOfWeek.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinMonthCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.AppointmentDependencies.AutoReload = False
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
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Year
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(742, 572)
            Me.schedulerControl.Start = New System.DateTime(2019, 12, 29, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl"
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.WeekCount = 3
            Me.schedulerControl.Views.TimelineView.Enabled = False
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.Controls.Add(Me.schedulerControl)
            Me.schedulerPanel.Controls.Add(Me.spOptionPanel)
            Me.schedulerPanel.Controls.Add(Me.commonRibbon)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(1028, 572)
            Me.schedulerPanel.TabIndex = 14
            ' 
            ' spOptionPanel
            ' 
            Me.spOptionPanel.Controls.Add(Me.tabPane1)
            Me.spOptionPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPanel.Location = New System.Drawing.Point(742, 0)
            Me.spOptionPanel.Name = "spOptionPanel"
            Me.spOptionPanel.Size = New System.Drawing.Size(286, 572)
            Me.spOptionPanel.TabIndex = 2
            Me.spOptionPanel.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 572)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(285, 572)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Year View Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(285, 539)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.chkStretchAppointments)
            Me.layoutControl1.Controls.Add(Me.cbStretchAppointmentsMode)
            Me.layoutControl1.Controls.Add(Me.cbShowOutOfScopeDays)
            Me.layoutControl1.Controls.Add(Me.cbHighlightWeekends)
            Me.layoutControl1.Controls.Add(Me.spinAppointmentHeight)
            Me.layoutControl1.Controls.Add(Me.cbFirstDayOfWeek)
            Me.layoutControl1.Controls.Add(Me.spinMonthCount)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1050, 0, 650, 1040)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 539)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkStretchAppointments
            ' 
            Me.chkStretchAppointments.Location = New System.Drawing.Point(5, 151)
            Me.chkStretchAppointments.MenuManager = Me
            Me.chkStretchAppointments.Name = "chkStretchAppointments"
            Me.chkStretchAppointments.Properties.Caption = "Stretch Appointments"
            Me.chkStretchAppointments.Size = New System.Drawing.Size(275, 20)
            Me.chkStretchAppointments.StyleController = Me.layoutControl1
            Me.chkStretchAppointments.TabIndex = 83
            AddHandler Me.chkStretchAppointments.CheckedChanged, New System.EventHandler(AddressOf Me.chkStretchAppointments_CheckedChanged)
            ' 
            ' cbStretchAppointmentsMode
            ' 
            Me.cbStretchAppointmentsMode.Location = New System.Drawing.Point(150, 175)
            Me.cbStretchAppointmentsMode.MenuManager = Me
            Me.cbStretchAppointmentsMode.Name = "cbStretchAppointmentsMode"
            Me.cbStretchAppointmentsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStretchAppointmentsMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.StretchAppointmentsMode.GrowAndShrink, DevExpress.XtraScheduler.StretchAppointmentsMode.GrowOnly})
            Me.cbStretchAppointmentsMode.Size = New System.Drawing.Size(130, 20)
            Me.cbStretchAppointmentsMode.StyleController = Me.layoutControl1
            Me.cbStretchAppointmentsMode.TabIndex = 82
            AddHandler Me.cbStretchAppointmentsMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbStretchAppointmentsMode_SelectedIndexChanged)
            ' 
            ' cbShowOutOfScopeDays
            ' 
            Me.cbShowOutOfScopeDays.Location = New System.Drawing.Point(150, 99)
            Me.cbShowOutOfScopeDays.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.cbShowOutOfScopeDays.MenuManager = Me
            Me.cbShowOutOfScopeDays.Name = "cbShowOutOfScopeDays"
            Me.cbShowOutOfScopeDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbShowOutOfScopeDays.Size = New System.Drawing.Size(130, 20)
            Me.cbShowOutOfScopeDays.StyleController = Me.layoutControl1
            Me.cbShowOutOfScopeDays.TabIndex = 81
            AddHandler Me.cbShowOutOfScopeDays.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbShowOutOfScopeDays_SelectedIndexChanged)
            ' 
            ' cbHighlightWeekends
            ' 
            Me.cbHighlightWeekends.Location = New System.Drawing.Point(150, 75)
            Me.cbHighlightWeekends.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.cbHighlightWeekends.MenuManager = Me
            Me.cbHighlightWeekends.Name = "cbHighlightWeekends"
            Me.cbHighlightWeekends.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbHighlightWeekends.Size = New System.Drawing.Size(130, 20)
            Me.cbHighlightWeekends.StyleController = Me.layoutControl1
            Me.cbHighlightWeekends.TabIndex = 80
            AddHandler Me.cbHighlightWeekends.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbHighlightWeekends_SelectedIndexChanged)
            ' 
            ' spinAppointmentHeight
            ' 
            Me.spinAppointmentHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinAppointmentHeight.Location = New System.Drawing.Point(150, 199)
            Me.spinAppointmentHeight.MenuManager = Me
            Me.spinAppointmentHeight.Name = "spinAppointmentHeight"
            Me.spinAppointmentHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinAppointmentHeight.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinAppointmentHeight.Size = New System.Drawing.Size(130, 20)
            Me.spinAppointmentHeight.StyleController = Me.layoutControl1
            Me.spinAppointmentHeight.TabIndex = 79
            AddHandler Me.spinAppointmentHeight.EditValueChanged, New System.EventHandler(AddressOf Me.OnAppointmentHeightEditValueChanged)
            ' 
            ' cbFirstDayOfWeek
            ' 
            Me.cbFirstDayOfWeek.EditValue = ""
            Me.cbFirstDayOfWeek.Location = New System.Drawing.Point(150, 51)
            Me.cbFirstDayOfWeek.Name = "cbFirstDayOfWeek"
            Me.cbFirstDayOfWeek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFirstDayOfWeek.Size = New System.Drawing.Size(130, 20)
            Me.cbFirstDayOfWeek.StyleController = Me.layoutControl1
            Me.cbFirstDayOfWeek.TabIndex = 77
            AddHandler Me.cbFirstDayOfWeek.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnFirstDayOfWeekSelectedIndexChanged)
            ' 
            ' spinMonthCount
            ' 
            Me.spinMonthCount.EditValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.spinMonthCount.Location = New System.Drawing.Point(150, 27)
            Me.spinMonthCount.Name = "spinMonthCount"
            Me.spinMonthCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinMonthCount.Properties.IsFloatValue = False
            Me.spinMonthCount.Properties.Mask.EditMask = "N00"
            Me.spinMonthCount.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
            Me.spinMonthCount.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinMonthCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinMonthCount.Size = New System.Drawing.Size(130, 20)
            Me.spinMonthCount.StyleController = Me.layoutControl1
            Me.spinMonthCount.TabIndex = 1
            AddHandler Me.spinMonthCount.EditValueChanged, New System.EventHandler(AddressOf Me.OnMonthCountEditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupView, Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 539)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupView
            ' 
            Me.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem5, Me.layoutControlItem2, Me.layoutControlItem4})
            Me.groupView.Location = New System.Drawing.Point(0, 0)
            Me.groupView.Name = "groupView"
            Me.groupView.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupView.Size = New System.Drawing.Size(285, 124)
            Me.groupView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupView.Text = "View"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.spinMonthCount
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem1.CustomizationFormText = "Month Count:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem1.Text = "Month Count:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cbFirstDayOfWeek
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem5.Text = "First Day of Week:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbHighlightWeekends
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem2.Text = "Highlight Weekends"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbShowOutOfScopeDays
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem4.Text = "Show Out of Scope Days"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 224)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(285, 315)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem8, Me.layoutControlItem7})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 124)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(285, 100)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Appointment Options"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinAppointmentHeight
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem3.Text = "Height:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.cbStretchAppointmentsMode
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem8.Name = "cbStretchAppointmentsMode"
            Me.layoutControlItem8.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem8.Text = "Stretch Appointments Mode"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.chkStretchAppointments
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' commonRibbon
            ' 
            Me.commonRibbon.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon.Name = "commonRibbon"
            Me.commonRibbon.Size = New System.Drawing.Size(1028, 0)
            Me.commonRibbon.SwitchViewPageGroupVisible = False
            Me.commonRibbon.TabIndex = 1
            Me.commonRibbon.TabStop = False
            Me.commonRibbon.Tutorial = Me
            ' 
            ' YearViewModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.Name = "YearViewModule"
            Me.Size = New System.Drawing.Size(1028, 572)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.YearView_Load)
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.spOptionPanel.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbStretchAppointmentsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbShowOutOfScopeDays.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbHighlightWeekends.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinAppointmentHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbFirstDayOfWeek.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinMonthCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerPanel As System.Windows.Forms.Panel

        Private spOptionPanel As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private cbFirstDayOfWeek As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private groupView As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private commonRibbon As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spinMonthCount As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private spinAppointmentHeight As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private cbShowOutOfScopeDays As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbHighlightWeekends As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private chkStretchAppointments As DevExpress.XtraEditors.CheckEdit

        Private cbStretchAppointmentsMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
