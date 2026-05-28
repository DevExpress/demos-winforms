Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Partial Class MonthViewModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.MonthViewModule))
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbStretchAppointmentsMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkCustomGroup = New DevExpress.XtraEditors.CheckEdit()
            Me.chkCustomSort = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStretchAppointments = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStatusOrientation = New DevExpress.XtraEditors.CheckEdit()
            Me.chkEndTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
            Me.chkStartTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbTimeDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chkShowWeekend = New DevExpress.XtraEditors.CheckEdit()
            Me.chkCompressWeekEnd = New DevExpress.XtraEditors.CheckEdit()
            Me.spinWeekCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupAppointment = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerPanel = New System.Windows.Forms.Panel()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.spOptionPanel = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbStretchAppointmentsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomSort.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkEndTimeVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStartTimeVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeDisplayType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowWeekend.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCompressWeekEnd.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinWeekCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.spOptionPanel.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.HtmlImages = Me.svgImageCollection1
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.HtmlTemplate.Styles = resources.GetString("schedulerControl.OptionsFlyout.HtmlTemplate.Styles")
            Me.schedulerControl.OptionsFlyout.HtmlTemplate.Template = resources.GetString("schedulerControl.OptionsFlyout.HtmlTemplate.Template")
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(418, 453)
            Me.schedulerControl.Start = New System.DateTime(2010, 6, 6, 0, 0, 0, 0)
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
            AddHandler Me.schedulerControl.AppointmentFlyoutShowing, New DevExpress.XtraScheduler.AppointmentFlyoutShowingEventHandler(AddressOf Me.schedulerControl_AppointmentFlyoutShowing)
            AddHandler Me.schedulerControl.CustomAppointmentFlyoutTemplateValue, New System.EventHandler(Of DevExpress.XtraScheduler.CustomAppointmentFlyoutTemplateValueEventArgs)(AddressOf Me.schedulerControl_CustomAppointmentFlyoutTemplateValue)
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
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Busy", CType((resources.GetObject("svgImageCollection1.Busy")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Free", CType((resources.GetObject("svgImageCollection1.Free")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("OutOfOffice", CType((resources.GetObject("svgImageCollection1.OutOfOffice")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Tentative", CType((resources.GetObject("svgImageCollection1.Tentative")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("WorkingElsewhere", CType((resources.GetObject("svgImageCollection1.WorkingElsewhere")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbStretchAppointmentsMode)
            Me.layoutControl1.Controls.Add(Me.chkCustomGroup)
            Me.layoutControl1.Controls.Add(Me.chkCustomSort)
            Me.layoutControl1.Controls.Add(Me.chkStretchAppointments)
            Me.layoutControl1.Controls.Add(Me.chkStatusOrientation)
            Me.layoutControl1.Controls.Add(Me.chkEndTimeVisibility)
            Me.layoutControl1.Controls.Add(Me.chkStartTimeVisibility)
            Me.layoutControl1.Controls.Add(Me.cbStatus)
            Me.layoutControl1.Controls.Add(Me.cbTimeDisplayType)
            Me.layoutControl1.Controls.Add(Me.chkShowWeekend)
            Me.layoutControl1.Controls.Add(Me.chkCompressWeekEnd)
            Me.layoutControl1.Controls.Add(Me.spinWeekCount)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 420)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbStretchAppointmentsMode
            ' 
            Me.cbStretchAppointmentsMode.Location = New System.Drawing.Point(150, 295)
            Me.cbStretchAppointmentsMode.MenuManager = Me
            Me.cbStretchAppointmentsMode.Name = "cbStretchAppointmentsMode"
            Me.cbStretchAppointmentsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStretchAppointmentsMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.StretchAppointmentsMode.GrowAndShrink, DevExpress.XtraScheduler.StretchAppointmentsMode.GrowOnly})
            Me.cbStretchAppointmentsMode.Size = New System.Drawing.Size(130, 20)
            Me.cbStretchAppointmentsMode.StyleController = Me.layoutControl1
            Me.cbStretchAppointmentsMode.TabIndex = 82
            AddHandler Me.cbStretchAppointmentsMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbStretchAppointmentsMode_SelectedIndexChanged)
            ' 
            ' chkCustomGroup
            ' 
            Me.chkCustomGroup.Location = New System.Drawing.Point(5, 367)
            Me.chkCustomGroup.MenuManager = Me
            Me.chkCustomGroup.Name = "chkCustomGroup"
            Me.chkCustomGroup.Properties.Caption = "Group By Category"
            Me.chkCustomGroup.Size = New System.Drawing.Size(275, 20)
            Me.chkCustomGroup.StyleController = Me.layoutControl1
            Me.chkCustomGroup.TabIndex = 81
            AddHandler Me.chkCustomGroup.CheckedChanged, New System.EventHandler(AddressOf Me.chkCustomGroup_CheckedChanged)
            ' 
            ' chkCustomSort
            ' 
            Me.chkCustomSort.Location = New System.Drawing.Point(5, 343)
            Me.chkCustomSort.MenuManager = Me
            Me.chkCustomSort.Name = "chkCustomSort"
            Me.chkCustomSort.Properties.Caption = "Sort By Category"
            Me.chkCustomSort.Size = New System.Drawing.Size(275, 20)
            Me.chkCustomSort.StyleController = Me.layoutControl1
            Me.chkCustomSort.TabIndex = 80
            AddHandler Me.chkCustomSort.CheckedChanged, New System.EventHandler(AddressOf Me.chkCustomSort_CheckedChanged)
            ' 
            ' chkStretchAppointments
            ' 
            Me.chkStretchAppointments.Location = New System.Drawing.Point(5, 319)
            Me.chkStretchAppointments.MenuManager = Me
            Me.chkStretchAppointments.Name = "chkStretchAppointments"
            Me.chkStretchAppointments.Properties.Caption = "Stretch Appointments"
            Me.chkStretchAppointments.Size = New System.Drawing.Size(275, 20)
            Me.chkStretchAppointments.StyleController = Me.layoutControl1
            Me.chkStretchAppointments.TabIndex = 79
            AddHandler Me.chkStretchAppointments.CheckedChanged, New System.EventHandler(AddressOf Me.chkStretchAppointments_CheckedChanged)
            ' 
            ' chkStatusOrientation
            ' 
            Me.chkStatusOrientation.EditValue = True
            Me.chkStatusOrientation.Location = New System.Drawing.Point(5, 185)
            Me.chkStatusOrientation.MenuManager = Me
            Me.chkStatusOrientation.Name = "chkStatusOrientation"
            Me.chkStatusOrientation.Properties.Caption = "Show Appointment Status Vertically"
            Me.chkStatusOrientation.Size = New System.Drawing.Size(275, 20)
            Me.chkStatusOrientation.StyleController = Me.layoutControl1
            Me.chkStatusOrientation.TabIndex = 78
            AddHandler Me.chkStatusOrientation.CheckedChanged, New System.EventHandler(AddressOf Me.chkStatusOrientation_CheckedChanged)
            ' 
            ' chkEndTimeVisibility
            ' 
            Me.chkEndTimeVisibility.Location = New System.Drawing.Point(5, 233)
            Me.chkEndTimeVisibility.Name = "chkEndTimeVisibility"
            Me.chkEndTimeVisibility.Properties.AllowGrayed = True
            Me.chkEndTimeVisibility.Properties.Caption = "End Time"
            Me.chkEndTimeVisibility.Size = New System.Drawing.Size(275, 20)
            Me.chkEndTimeVisibility.StyleController = Me.layoutControl1
            Me.chkEndTimeVisibility.TabIndex = 0
            AddHandler Me.chkEndTimeVisibility.CheckStateChanged, New System.EventHandler(AddressOf Me.chkEndTimeVisibility_CheckStateChanged)
            ' 
            ' chkStartTimeVisibility
            ' 
            Me.chkStartTimeVisibility.Location = New System.Drawing.Point(5, 209)
            Me.chkStartTimeVisibility.Name = "chkStartTimeVisibility"
            Me.chkStartTimeVisibility.Properties.AllowGrayed = True
            Me.chkStartTimeVisibility.Properties.Caption = "Start Time"
            Me.chkStartTimeVisibility.Size = New System.Drawing.Size(275, 20)
            Me.chkStartTimeVisibility.StyleController = Me.layoutControl1
            Me.chkStartTimeVisibility.TabIndex = 3
            AddHandler Me.chkStartTimeVisibility.CheckStateChanged, New System.EventHandler(AddressOf Me.chkStartTimeVisibility_CheckStateChanged)
            ' 
            ' cbStatus
            ' 
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(150, 161)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(130, 20)
            Me.cbStatus.StyleController = Me.layoutControl1
            Me.cbStatus.TabIndex = 77
            AddHandler Me.cbStatus.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbStatus_SelectedIndexChanged)
            ' 
            ' cbTimeDisplayType
            ' 
            Me.cbTimeDisplayType.EditValue = ""
            Me.cbTimeDisplayType.Location = New System.Drawing.Point(150, 137)
            Me.cbTimeDisplayType.Name = "cbTimeDisplayType"
            Me.cbTimeDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeDisplayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)})
            Me.cbTimeDisplayType.Size = New System.Drawing.Size(130, 20)
            Me.cbTimeDisplayType.StyleController = Me.layoutControl1
            Me.cbTimeDisplayType.TabIndex = 24
            AddHandler Me.cbTimeDisplayType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTimeDisplayType_SelectedIndexChanged)
            ' 
            ' chkShowWeekend
            ' 
            Me.chkShowWeekend.Location = New System.Drawing.Point(5, 51)
            Me.chkShowWeekend.Name = "chkShowWeekend"
            Me.chkShowWeekend.Properties.Caption = "Show Weekend"
            Me.chkShowWeekend.Size = New System.Drawing.Size(275, 20)
            Me.chkShowWeekend.StyleController = Me.layoutControl1
            Me.chkShowWeekend.TabIndex = 0
            AddHandler Me.chkShowWeekend.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowWeekend_CheckedChanged)
            ' 
            ' chkCompressWeekEnd
            ' 
            Me.chkCompressWeekEnd.Location = New System.Drawing.Point(5, 75)
            Me.chkCompressWeekEnd.Name = "chkCompressWeekEnd"
            Me.chkCompressWeekEnd.Properties.Caption = "Compress Weekend"
            Me.chkCompressWeekEnd.Size = New System.Drawing.Size(275, 20)
            Me.chkCompressWeekEnd.StyleController = Me.layoutControl1
            Me.chkCompressWeekEnd.TabIndex = 0
            AddHandler Me.chkCompressWeekEnd.CheckedChanged, New System.EventHandler(AddressOf Me.chkCompressWeekEnd_CheckedChanged)
            ' 
            ' spinWeekCount
            ' 
            Me.spinWeekCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinWeekCount.Location = New System.Drawing.Point(150, 27)
            Me.spinWeekCount.Name = "spinWeekCount"
            Me.spinWeekCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinWeekCount.Properties.IsFloatValue = False
            Me.spinWeekCount.Properties.Mask.EditMask = "N00"
            Me.spinWeekCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinWeekCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinWeekCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinWeekCount.Size = New System.Drawing.Size(130, 20)
            Me.spinWeekCount.StyleController = Me.layoutControl1
            Me.spinWeekCount.TabIndex = 1
            AddHandler Me.spinWeekCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinWeekCount_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupView, Me.groupAppointment, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlGroup2, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 420)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupView
            ' 
            Me.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem1, Me.layoutControlItem2})
            Me.groupView.Location = New System.Drawing.Point(0, 0)
            Me.groupView.Name = "groupView"
            Me.groupView.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupView.Size = New System.Drawing.Size(285, 100)
            Me.groupView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupView.Text = "View"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkCompressWeekEnd
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkShowWeekend
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.spinWeekCount
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem2.Text = "Week Count:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' groupAppointment
            ' 
            Me.groupAppointment.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupAppointment.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.groupAppointment.Location = New System.Drawing.Point(0, 110)
            Me.groupAppointment.Name = "groupAppointment"
            Me.groupAppointment.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupAppointment.Size = New System.Drawing.Size(285, 148)
            Me.groupAppointment.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupAppointment.Text = "Appointment"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbTimeDisplayType
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem4.Text = "Display Time As:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cbStatus
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem5.Text = "Status:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chkStartTimeVisibility
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.chkEndTimeVisibility
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.chkStatusOrientation
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem8.TextVisible = False
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
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 392)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(285, 28)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem12})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 268)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(285, 124)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Appointment Layout"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.chkStretchAppointments
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.chkCustomSort
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.chkCustomGroup
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.cbStretchAppointmentsMode
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem12.Text = "Stretch Appointments Mode"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(133, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 258)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(285, 10)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.Text = "emptySpaceItem1"
            ' 
            ' schedulerPanel
            ' 
            Me.schedulerPanel.Controls.Add(Me.schedulerControl)
            Me.schedulerPanel.Controls.Add(Me.commonRibbon1)
            Me.schedulerPanel.Controls.Add(Me.spOptionPanel)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(704, 453)
            Me.schedulerPanel.TabIndex = 13
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(418, 0)
            Me.commonRibbon1.SwitchViewPageGroupVisible = False
            Me.commonRibbon1.TabIndex = 1
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' spOptionPanel
            ' 
            Me.spOptionPanel.Controls.Add(Me.tabPane1)
            Me.spOptionPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPanel.Location = New System.Drawing.Point(418, 0)
            Me.spOptionPanel.Name = "spOptionPanel"
            Me.spOptionPanel.Size = New System.Drawing.Size(286, 453)
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 453)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(285, 453)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Month View Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(285, 420)
            ' 
            ' MonthViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Name = "MonthViewModule"
            Me.Size = New System.Drawing.Size(704, 453)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MonthViewModule_Load)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.MonthViewModule_VisibleChanged)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbStretchAppointmentsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomSort.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStretchAppointments.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkEndTimeVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStartTimeVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeDisplayType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowWeekend.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCompressWeekEnd.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinWeekCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupAppointment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.spOptionPanel.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private chkCompressWeekEnd As DevExpress.XtraEditors.CheckEdit

        Private spinWeekCount As DevExpress.XtraEditors.SpinEdit

        Private chkShowWeekend As DevExpress.XtraEditors.CheckEdit

        Private cbTimeDisplayType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private chkStartTimeVisibility As DevExpress.XtraEditors.CheckEdit

        Private chkEndTimeVisibility As DevExpress.XtraEditors.CheckEdit

        Private cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private groupView As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private groupAppointment As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private schedulerPanel As System.Windows.Forms.Panel

        Private chkStatusOrientation As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPanel As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private chkStretchAppointments As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private chkCustomGroup As DevExpress.XtraEditors.CheckEdit

        Private chkCustomSort As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private cbStretchAppointmentsMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
