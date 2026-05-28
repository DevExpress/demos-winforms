Namespace DevExpress.XtraScheduler.Demos

    Partial Class WorkWeekViewModule

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
            Me.schedulerPanel = New System.Windows.Forms.Panel()
            Me.spOptionsPane = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbTimeMarkerStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkCustomGroup = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.weekDaysCheckEdit1 = New DevExpress.XtraScheduler.UI.WeekDaysCheckEdit()
            Me.cbTimeMarkerVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbTimeIndicatorVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkShowOverAppointment = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerPanel.SuspendLayout()
            Me.spOptionsPane.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.weekDaysCheckEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(887, 505)
            Me.schedulerControl.Start = New System.DateTime(2017, 10, 2, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.Enabled = False
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.Enabled = False
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl.PopupMenuShowing, New DevExpress.XtraScheduler.PopupMenuShowingEventHandler(AddressOf Me.schedulerControl_PopupMenuShowing)
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
            ' schedulerPanel
            ' 
            Me.schedulerPanel.Controls.Add(Me.schedulerControl)
            Me.schedulerPanel.Controls.Add(Me.spOptionsPane)
            Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerPanel.Location = New System.Drawing.Point(0, 0)
            Me.schedulerPanel.Name = "schedulerPanel"
            Me.schedulerPanel.Size = New System.Drawing.Size(1173, 505)
            Me.schedulerPanel.TabIndex = 11
            ' 
            ' spOptionsPane
            ' 
            Me.spOptionsPane.Controls.Add(Me.tabPane1)
            Me.spOptionsPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionsPane.Location = New System.Drawing.Point(887, 0)
            Me.spOptionsPane.Name = "spOptionsPane"
            Me.spOptionsPane.Size = New System.Drawing.Size(286, 505)
            Me.spOptionsPane.TabIndex = 9
            Me.spOptionsPane.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 505)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage2
            Me.tabPane1.Size = New System.Drawing.Size(285, 505)
            Me.tabPane1.TabIndex = 10
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "WorkWeek View Options"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(285, 472)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbTimeMarkerStyle)
            Me.layoutControl1.Controls.Add(Me.chkCustomGroup)
            Me.layoutControl1.Controls.Add(Me.chkShowWorkTimeOnly)
            Me.layoutControl1.Controls.Add(Me.weekDaysCheckEdit1)
            Me.layoutControl1.Controls.Add(Me.cbTimeMarkerVisibility)
            Me.layoutControl1.Controls.Add(Me.cbTimeIndicatorVisibility)
            Me.layoutControl1.Controls.Add(Me.chkShowOverAppointment)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 252, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 472)
            Me.layoutControl1.TabIndex = 9
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbTimeMarkerStyle
            ' 
            Me.cbTimeMarkerStyle.Location = New System.Drawing.Point(133, 226)
            Me.cbTimeMarkerStyle.MenuManager = Me
            Me.cbTimeMarkerStyle.Name = "cbTimeMarkerStyle"
            Me.cbTimeMarkerStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerStyle.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerStyle.[Default], DevExpress.XtraScheduler.TimeMarkerStyle.Line, DevExpress.XtraScheduler.TimeMarkerStyle.Appearance, CType(((DevExpress.XtraScheduler.TimeMarkerStyle.Line Or DevExpress.XtraScheduler.TimeMarkerStyle.Appearance)), DevExpress.XtraScheduler.TimeMarkerStyle)})
            Me.cbTimeMarkerStyle.Size = New System.Drawing.Size(140, 20)
            Me.cbTimeMarkerStyle.StyleController = Me.layoutControl1
            Me.cbTimeMarkerStyle.TabIndex = 11
            AddHandler Me.cbTimeMarkerStyle.EditValueChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerStyle_EditValueChanged)
            ' 
            ' chkCustomGroup
            ' 
            Me.chkCustomGroup.Location = New System.Drawing.Point(12, 160)
            Me.chkCustomGroup.MenuManager = Me
            Me.chkCustomGroup.Name = "chkCustomGroup"
            Me.chkCustomGroup.Properties.Caption = "Group By Category"
            Me.chkCustomGroup.Size = New System.Drawing.Size(261, 20)
            Me.chkCustomGroup.StyleController = Me.layoutControl1
            Me.chkCustomGroup.TabIndex = 10
            AddHandler Me.chkCustomGroup.CheckedChanged, New System.EventHandler(AddressOf Me.chkCustomGroup_CheckedChanged)
            ' 
            ' chkShowWorkTimeOnly
            ' 
            Me.chkShowWorkTimeOnly.Location = New System.Drawing.Point(12, 364)
            Me.chkShowWorkTimeOnly.MenuManager = Me
            Me.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly"
            Me.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only"
            Me.chkShowWorkTimeOnly.Size = New System.Drawing.Size(261, 20)
            Me.chkShowWorkTimeOnly.StyleController = Me.layoutControl1
            Me.chkShowWorkTimeOnly.TabIndex = 8
            AddHandler Me.chkShowWorkTimeOnly.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowWorkTimeOnly_CheckedChanged)
            ' 
            ' weekDaysCheckEdit1
            ' 
            Me.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.weekDaysCheckEdit1.Appearance.Options.UseBackColor = True
            Me.weekDaysCheckEdit1.Location = New System.Drawing.Point(12, 34)
            Me.weekDaysCheckEdit1.Margin = New System.Windows.Forms.Padding(0)
            Me.weekDaysCheckEdit1.MinimumSize = New System.Drawing.Size(0, 80)
            Me.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1"
            Me.weekDaysCheckEdit1.Size = New System.Drawing.Size(261, 80)
            Me.weekDaysCheckEdit1.TabIndex = 4
            AddHandler Me.weekDaysCheckEdit1.WeekDaysChanged, New System.EventHandler(AddressOf Me.weekDaysCheckEdit1_WeekDaysChanged)
            ' 
            ' cbTimeMarkerVisibility
            ' 
            Me.cbTimeMarkerVisibility.Location = New System.Drawing.Point(133, 250)
            Me.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility"
            Me.cbTimeMarkerVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerVisibility.Always, DevExpress.XtraScheduler.TimeMarkerVisibility.Never, DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView})
            Me.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeMarkerVisibility.Size = New System.Drawing.Size(140, 20)
            Me.cbTimeMarkerVisibility.StyleController = Me.layoutControl1
            Me.cbTimeMarkerVisibility.TabIndex = 7
            AddHandler Me.cbTimeMarkerVisibility.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerVisibility_SelectedIndexChanged)
            ' 
            ' cbTimeIndicatorVisibility
            ' 
            Me.cbTimeIndicatorVisibility.Location = New System.Drawing.Point(133, 274)
            Me.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility"
            Me.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeIndicatorVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeIndicatorVisibility.Always, DevExpress.XtraScheduler.TimeIndicatorVisibility.Never, DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView, DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate, DevExpress.XtraScheduler.TimeIndicatorVisibility.DaysBeforeToday})
            Me.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeIndicatorVisibility.Size = New System.Drawing.Size(140, 20)
            Me.cbTimeIndicatorVisibility.StyleController = Me.layoutControl1
            Me.cbTimeIndicatorVisibility.TabIndex = 5
            AddHandler Me.cbTimeIndicatorVisibility.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTimeIndicatorVisibility_SelectedIndexChanged)
            ' 
            ' chkShowOverAppointment
            ' 
            Me.chkShowOverAppointment.Location = New System.Drawing.Point(12, 298)
            Me.chkShowOverAppointment.Name = "chkShowOverAppointment"
            Me.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment"
            Me.chkShowOverAppointment.Size = New System.Drawing.Size(261, 20)
            Me.chkShowOverAppointment.StyleController = Me.layoutControl1
            Me.chkShowOverAppointment.TabIndex = 6
            AddHandler Me.chkShowOverAppointment.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowOverAppointment_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup2, Me.layoutControlGroup4, Me.emptySpaceItem3, Me.layoutControlGroup5})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 472)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(285, 126)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Weekdays"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.weekDaysCheckEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(265, 84)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem5, Me.layoutControlItem2, Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 192)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(285, 138)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Current Time Visualization"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chkShowOverAppointment
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cbTimeIndicatorVisibility
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem5.Text = "TimeIndicator Visibility:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbTimeMarkerVisibility
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem2.Text = "TimeMarker Visibility:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbTimeMarkerStyle
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem4.Text = "TimeMarker Style:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 330)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(285, 66)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "View"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkShowWorkTimeOnly
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 396)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(285, 76)
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 126)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(285, 66)
            Me.layoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup5.Text = "Appointment Layout"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.chkCustomGroup
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(1173, 0)
            Me.commonRibbon1.SwitchViewPageGroupVisible = False
            Me.commonRibbon1.TabIndex = 13
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' mvvmContext1
            ' 
            Me.mvvmContext1.ContainerControl = Me
            ' 
            ' WorkWeekViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerPanel)
            Me.Controls.Add(Me.commonRibbon1)
            Me.Name = "WorkWeekViewModule"
            Me.Size = New System.Drawing.Size(1173, 505)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.WorkWeekViewModule_Load)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.WorkWeekViewModule_VisibleChanged)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerPanel.ResumeLayout(False)
            Me.spOptionsPane.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.weekDaysCheckEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private schedulerPanel As System.Windows.Forms.Panel

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private chkShowOverAppointment As DevExpress.XtraEditors.CheckEdit

        Private cbTimeMarkerVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private cbTimeIndicatorVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private spOptionsPane As DevExpress.XtraEditors.SidePanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private weekDaysCheckEdit1 As DevExpress.XtraScheduler.UI.WeekDaysCheckEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private chkShowWorkTimeOnly As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private chkCustomGroup As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbTimeMarkerStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
