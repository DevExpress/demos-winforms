Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Partial Class DayViewModule

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
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.spOptionPane = New DevExpress.XtraEditors.SidePanel()
            Me.tbOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbTimeMarkerStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbColumnWidthMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkCustomGroup = New DevExpress.XtraEditors.CheckEdit()
            Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbAllDayStatus = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbStatus = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkStatusOrientation = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAllowHtmlText = New DevExpress.XtraEditors.CheckEdit()
            Me.spinDaysCount = New DevExpress.XtraEditors.SpinEdit()
            Me.chkShowDayHeaders = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowAllDayArea = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowRightTimeRuler = New DevExpress.XtraEditors.CheckEdit()
            Me.cbTimeMarkerVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbTimeIndicatorVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.chkShowOverAppointment = New DevExpress.XtraEditors.CheckEdit()
            Me.chkColorizeResources = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.groupAppointmentLayout = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.mvvmContext2 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.spOptionPane.SuspendLayout()
            CType((Me.tbOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbOptions.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbColumnWidthMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbAllDayStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAllowHtmlText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinDaysCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowDayHeaders.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowAllDayArea.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowRightTimeRuler.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkColorizeResources.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupAppointmentLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(798, 653)
            Me.schedulerControl.Start = New System.DateTime(2018, 2, 28, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            timeRuler2.HorizontalAlignment = DevExpress.XtraScheduler.TimeRulerHorizontalAlignment.Far
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.Enabled = False
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl.VisibleIntervalChanged, New System.EventHandler(AddressOf Me.OnSchedulerControlVisibleIntervalChanged)
            AddHandler Me.schedulerControl.PopupMenuShowing, New DevExpress.XtraScheduler.PopupMenuShowingEventHandler(AddressOf Me.OnSchedulerControlPopupMenuShowing)
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
            ' spOptionPane
            ' 
            Me.spOptionPane.Controls.Add(Me.tbOptions)
            Me.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPane.Location = New System.Drawing.Point(798, 0)
            Me.spOptionPane.Name = "spOptionPane"
            Me.spOptionPane.Size = New System.Drawing.Size(286, 653)
            Me.spOptionPane.TabIndex = 3
            Me.spOptionPane.Text = "sidePanel1"
            ' 
            ' tbOptions
            ' 
            Me.tbOptions.Controls.Add(Me.tabNavigationPage1)
            Me.tbOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbOptions.Location = New System.Drawing.Point(1, 0)
            Me.tbOptions.Name = "tbOptions"
            Me.tbOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tbOptions.RegularSize = New System.Drawing.Size(285, 653)
            Me.tbOptions.SelectedPage = Me.tabNavigationPage1
            Me.tbOptions.Size = New System.Drawing.Size(285, 653)
            Me.tbOptions.TabIndex = 11
            Me.tbOptions.Text = "Day View Options"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Day View Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl4)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(285, 620)
            ' 
            ' layoutControl4
            ' 
            Me.layoutControl4.Controls.Add(Me.cbTimeMarkerStyle)
            Me.layoutControl4.Controls.Add(Me.cbColumnWidthMode)
            Me.layoutControl4.Controls.Add(Me.chkCustomGroup)
            Me.layoutControl4.Controls.Add(Me.cbSnapToCellsMode)
            Me.layoutControl4.Controls.Add(Me.cbAllDayStatus)
            Me.layoutControl4.Controls.Add(Me.cbStatus)
            Me.layoutControl4.Controls.Add(Me.chkStatusOrientation)
            Me.layoutControl4.Controls.Add(Me.chkAllowHtmlText)
            Me.layoutControl4.Controls.Add(Me.spinDaysCount)
            Me.layoutControl4.Controls.Add(Me.chkShowDayHeaders)
            Me.layoutControl4.Controls.Add(Me.chkShowAllDayArea)
            Me.layoutControl4.Controls.Add(Me.chkShowWorkTimeOnly)
            Me.layoutControl4.Controls.Add(Me.chkShowRightTimeRuler)
            Me.layoutControl4.Controls.Add(Me.cbTimeMarkerVisibility)
            Me.layoutControl4.Controls.Add(Me.cbTimeIndicatorVisibility)
            Me.layoutControl4.Controls.Add(Me.chkShowOverAppointment)
            Me.layoutControl4.Controls.Add(Me.chkColorizeResources)
            Me.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(698, 302, 650, 400)
            Me.layoutControl4.Root = Me.layoutControlGroup4
            Me.layoutControl4.Size = New System.Drawing.Size(285, 620)
            Me.layoutControl4.TabIndex = 10
            Me.layoutControl4.Text = "layoutControl4"
            ' 
            ' cbTimeMarkerStyle
            ' 
            Me.cbTimeMarkerStyle.Location = New System.Drawing.Point(160, 284)
            Me.cbTimeMarkerStyle.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.cbTimeMarkerStyle.MenuManager = Me
            Me.cbTimeMarkerStyle.Name = "cbTimeMarkerStyle"
            Me.cbTimeMarkerStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerStyle.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerStyle.[Default], DevExpress.XtraScheduler.TimeMarkerStyle.Line, DevExpress.XtraScheduler.TimeMarkerStyle.Appearance, CType(((DevExpress.XtraScheduler.TimeMarkerStyle.Line Or DevExpress.XtraScheduler.TimeMarkerStyle.Appearance)), DevExpress.XtraScheduler.TimeMarkerStyle)})
            Me.cbTimeMarkerStyle.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeMarkerStyle.StyleController = Me.layoutControl4
            Me.cbTimeMarkerStyle.TabIndex = 13
            AddHandler Me.cbTimeMarkerStyle.EditValueChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerStyle_EditValueChanged)
            ' 
            ' cbColumnWidthMode
            ' 
            Me.cbColumnWidthMode.Location = New System.Drawing.Point(160, 456)
            Me.cbColumnWidthMode.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.cbColumnWidthMode.MenuManager = Me
            Me.cbColumnWidthMode.Name = "cbColumnWidthMode"
            Me.cbColumnWidthMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbColumnWidthMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.ColumnWidthMode.Fixed, DevExpress.XtraScheduler.ColumnWidthMode.Auto})
            Me.cbColumnWidthMode.Size = New System.Drawing.Size(113, 20)
            Me.cbColumnWidthMode.StyleController = Me.layoutControl4
            Me.cbColumnWidthMode.TabIndex = 12
            AddHandler Me.cbColumnWidthMode.EditValueChanged, New System.EventHandler(AddressOf Me.cbColumnWidthMode_EditValueChanged)
            ' 
            ' chkCustomGroup
            ' 
            Me.chkCustomGroup.Location = New System.Drawing.Point(12, 207)
            Me.chkCustomGroup.MenuManager = Me
            Me.chkCustomGroup.Name = "chkCustomGroup"
            Me.chkCustomGroup.Properties.Caption = "Group By Category"
            Me.chkCustomGroup.Size = New System.Drawing.Size(261, 20)
            Me.chkCustomGroup.StyleController = Me.layoutControl4
            Me.chkCustomGroup.TabIndex = 10
            AddHandler Me.chkCustomGroup.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkCustomGroupCheckedChanged)
            ' 
            ' cbSnapToCellsMode
            ' 
            Me.cbSnapToCellsMode.Location = New System.Drawing.Point(160, 34)
            Me.cbSnapToCellsMode.MenuManager = Me
            Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
            Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSnapToCellsMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never})
            Me.cbSnapToCellsMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbSnapToCellsMode.Size = New System.Drawing.Size(113, 20)
            Me.cbSnapToCellsMode.StyleController = Me.layoutControl4
            Me.cbSnapToCellsMode.TabIndex = 4
            AddHandler Me.cbSnapToCellsMode.EditValueChanged, New System.EventHandler(AddressOf Me.cbSnapToCellsMode_EditValueChanged)
            ' 
            ' cbAllDayStatus
            ' 
            Me.cbAllDayStatus.Location = New System.Drawing.Point(160, 58)
            Me.cbAllDayStatus.MenuManager = Me
            Me.cbAllDayStatus.Name = "cbAllDayStatus"
            Me.cbAllDayStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAllDayStatus.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds})
            Me.cbAllDayStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbAllDayStatus.Size = New System.Drawing.Size(113, 20)
            Me.cbAllDayStatus.StyleController = Me.layoutControl4
            Me.cbAllDayStatus.TabIndex = 5
            AddHandler Me.cbAllDayStatus.EditValueChanged, New System.EventHandler(AddressOf Me.cbAllDayStatus_EditValueChanged)
            ' 
            ' cbStatus
            ' 
            Me.cbStatus.Location = New System.Drawing.Point(160, 82)
            Me.cbStatus.MenuManager = Me
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds})
            Me.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbStatus.Size = New System.Drawing.Size(113, 20)
            Me.cbStatus.StyleController = Me.layoutControl4
            Me.cbStatus.TabIndex = 7
            AddHandler Me.cbStatus.EditValueChanged, New System.EventHandler(AddressOf Me.cbStatus_EditValueChanged)
            ' 
            ' chkStatusOrientation
            ' 
            Me.chkStatusOrientation.EditValue = True
            Me.chkStatusOrientation.Location = New System.Drawing.Point(12, 106)
            Me.chkStatusOrientation.MenuManager = Me
            Me.chkStatusOrientation.Name = "chkStatusOrientation"
            Me.chkStatusOrientation.Properties.Caption = "Show All-Day Appointment Status Vertically"
            Me.chkStatusOrientation.Size = New System.Drawing.Size(261, 20)
            Me.chkStatusOrientation.StyleController = Me.layoutControl4
            Me.chkStatusOrientation.TabIndex = 6
            AddHandler Me.chkStatusOrientation.CheckedChanged, New System.EventHandler(AddressOf Me.chkStatusOrientation_CheckedChanged)
            ' 
            ' chkAllowHtmlText
            ' 
            Me.chkAllowHtmlText.Location = New System.Drawing.Point(12, 130)
            Me.chkAllowHtmlText.Name = "chkAllowHtmlText"
            Me.chkAllowHtmlText.Properties.Caption = "Allow Html Text"
            Me.chkAllowHtmlText.Size = New System.Drawing.Size(261, 20)
            Me.chkAllowHtmlText.StyleController = Me.layoutControl4
            Me.chkAllowHtmlText.TabIndex = 8
            AddHandler Me.chkAllowHtmlText.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkAllowHtmlTextCheckedChanged)
            ' 
            ' spinDaysCount
            ' 
            Me.spinDaysCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinDaysCount.Location = New System.Drawing.Point(160, 432)
            Me.spinDaysCount.Name = "spinDaysCount"
            Me.spinDaysCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinDaysCount.Properties.IsFloatValue = False
            Me.spinDaysCount.Properties.Mask.EditMask = "N00"
            Me.spinDaysCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinDaysCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinDaysCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinDaysCount.Size = New System.Drawing.Size(113, 20)
            Me.spinDaysCount.StyleController = Me.layoutControl4
            Me.spinDaysCount.TabIndex = 1
            AddHandler Me.spinDaysCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinDaysCount_EditValueChanged)
            ' 
            ' chkShowDayHeaders
            ' 
            Me.chkShowDayHeaders.Location = New System.Drawing.Point(12, 480)
            Me.chkShowDayHeaders.Name = "chkShowDayHeaders"
            Me.chkShowDayHeaders.Properties.Caption = "Show Day Headers"
            Me.chkShowDayHeaders.Size = New System.Drawing.Size(261, 20)
            Me.chkShowDayHeaders.StyleController = Me.layoutControl4
            Me.chkShowDayHeaders.TabIndex = 4
            AddHandler Me.chkShowDayHeaders.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowDayHeaders_CheckedChanged)
            ' 
            ' chkShowAllDayArea
            ' 
            Me.chkShowAllDayArea.Location = New System.Drawing.Point(12, 504)
            Me.chkShowAllDayArea.Name = "chkShowAllDayArea"
            Me.chkShowAllDayArea.Properties.Caption = "Show All Day Area"
            Me.chkShowAllDayArea.Size = New System.Drawing.Size(261, 20)
            Me.chkShowAllDayArea.StyleController = Me.layoutControl4
            Me.chkShowAllDayArea.TabIndex = 5
            AddHandler Me.chkShowAllDayArea.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowAllDayArea_CheckedChanged)
            ' 
            ' chkShowWorkTimeOnly
            ' 
            Me.chkShowWorkTimeOnly.Location = New System.Drawing.Point(12, 528)
            Me.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly"
            Me.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only"
            Me.chkShowWorkTimeOnly.Size = New System.Drawing.Size(261, 20)
            Me.chkShowWorkTimeOnly.StyleController = Me.layoutControl4
            Me.chkShowWorkTimeOnly.TabIndex = 6
            AddHandler Me.chkShowWorkTimeOnly.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowWorkTimeOnly_CheckedChanged)
            ' 
            ' chkShowRightTimeRuler
            ' 
            Me.chkShowRightTimeRuler.Location = New System.Drawing.Point(12, 552)
            Me.chkShowRightTimeRuler.MenuManager = Me
            Me.chkShowRightTimeRuler.Name = "chkShowRightTimeRuler"
            Me.chkShowRightTimeRuler.Properties.Caption = "TimeRuler On The Right"
            Me.chkShowRightTimeRuler.Size = New System.Drawing.Size(261, 20)
            Me.chkShowRightTimeRuler.StyleController = Me.layoutControl4
            Me.chkShowRightTimeRuler.TabIndex = 7
            AddHandler Me.chkShowRightTimeRuler.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowRightTimeRuler_CheckedChanged)
            ' 
            ' cbTimeMarkerVisibility
            ' 
            Me.cbTimeMarkerVisibility.Location = New System.Drawing.Point(160, 308)
            Me.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility"
            Me.cbTimeMarkerVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeMarkerVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeMarkerVisibility.Always, DevExpress.XtraScheduler.TimeMarkerVisibility.Never, DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView})
            Me.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeMarkerVisibility.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeMarkerVisibility.StyleController = Me.layoutControl4
            Me.cbTimeMarkerVisibility.TabIndex = 7
            AddHandler Me.cbTimeMarkerVisibility.EditValueChanged, New System.EventHandler(AddressOf Me.cbTimeMarkerVisibility_EditValueChanged)
            ' 
            ' cbTimeIndicatorVisibility
            ' 
            Me.cbTimeIndicatorVisibility.Location = New System.Drawing.Point(160, 332)
            Me.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility"
            Me.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeIndicatorVisibility.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.TimeIndicatorVisibility.Always, DevExpress.XtraScheduler.TimeIndicatorVisibility.Never, DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView, DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate, DevExpress.XtraScheduler.TimeIndicatorVisibility.DaysBeforeToday})
            Me.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTimeIndicatorVisibility.Size = New System.Drawing.Size(113, 20)
            Me.cbTimeIndicatorVisibility.StyleController = Me.layoutControl4
            Me.cbTimeIndicatorVisibility.TabIndex = 5
            AddHandler Me.cbTimeIndicatorVisibility.EditValueChanged, New System.EventHandler(AddressOf Me.cbTimeIndicatorVisibility_EditValueChanged)
            ' 
            ' chkShowOverAppointment
            ' 
            Me.chkShowOverAppointment.Location = New System.Drawing.Point(12, 356)
            Me.chkShowOverAppointment.Name = "chkShowOverAppointment"
            Me.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment"
            Me.chkShowOverAppointment.Size = New System.Drawing.Size(261, 20)
            Me.chkShowOverAppointment.StyleController = Me.layoutControl4
            Me.chkShowOverAppointment.TabIndex = 6
            AddHandler Me.chkShowOverAppointment.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowOverAppointment_CheckedChanged)
            ' 
            ' chkColorizeResources
            ' 
            Me.chkColorizeResources.EditValue = True
            Me.chkColorizeResources.Location = New System.Drawing.Point(12, 576)
            Me.chkColorizeResources.MenuManager = Me
            Me.chkColorizeResources.Name = "chkColorizeResources"
            Me.chkColorizeResources.Properties.Caption = "Colorize Resources "
            Me.chkColorizeResources.Size = New System.Drawing.Size(261, 20)
            Me.chkColorizeResources.StyleController = Me.layoutControl4
            Me.chkColorizeResources.TabIndex = 11
            AddHandler Me.chkColorizeResources.CheckedChanged, New System.EventHandler(AddressOf Me.OnChkColorizeResourcesCheckedChanged)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup6, Me.emptySpaceItem3, Me.layoutControlGroup2, Me.layoutControlGroup1, Me.emptySpaceItem2, Me.emptySpaceItem4, Me.groupAppointmentLayout, Me.emptySpaceItem1})
            Me.layoutControlGroup4.Name = "Root"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(285, 620)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem7, Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem14})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(285, 162)
            Me.layoutControlGroup6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup6.Text = "Appointment"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.cbAllDayStatus
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem3.Text = "All-Day Appointment Status:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbStatus
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem7.Text = "Appointment Status:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbSnapToCellsMode
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem1.Text = "Snap To Cells Mode:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chkStatusOrientation
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem4.Text = "Show All-Day Appointment Status Vertically"
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.chkAllowHtmlText
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 608)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(285, 12)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem2, Me.layoutControlItem5, Me.layoutControlItem17})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 250)
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
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbTimeMarkerVisibility
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem2.Text = "TimeMarker Visibility:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cbTimeIndicatorVisibility
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem5.Text = "TimeIndicator Visibility:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.cbTimeMarkerStyle
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem17.Text = "TimeMarker Style:"
            Me.layoutControlItem17.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem12, Me.layoutControlItem13, Me.layoutControlItem8, Me.layoutControlItem16})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 398)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 210)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "View"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.spinDaysCount
            Me.layoutControlItem9.CustomizationFormText = "Day Count:"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem9.Text = "Day Count:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.chkShowDayHeaders
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.chkShowAllDayArea
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.chkShowWorkTimeOnly
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.chkShowRightTimeRuler
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.chkColorizeResources
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.cbColumnWidthMode
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem16.Text = "Column Width Mode"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(136, 13)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 388)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(285, 10)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 162)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(285, 11)
            ' 
            ' groupAppointmentLayout
            ' 
            Me.groupAppointmentLayout.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupAppointmentLayout.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem15})
            Me.groupAppointmentLayout.Location = New System.Drawing.Point(0, 173)
            Me.groupAppointmentLayout.Name = "groupAppointmentLayout"
            Me.groupAppointmentLayout.Size = New System.Drawing.Size(285, 66)
            Me.groupAppointmentLayout.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupAppointmentLayout.Text = "Appointment Layout"
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.chkCustomGroup
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(265, 24)
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 239)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(285, 11)
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Margin = New System.Windows.Forms.Padding(6)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(1084, 0)
            Me.commonRibbon1.SwitchViewPageGroupVisible = False
            Me.commonRibbon1.TabIndex = 1
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' mvvmContext1
            ' 
            Me.mvvmContext1.ContainerControl = Me
            ' 
            ' mvvmContext2
            ' 
            Me.mvvmContext2.ContainerControl = Me
            ' 
            ' DayViewModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.spOptionPane)
            Me.Controls.Add(Me.commonRibbon1)
            Me.Name = "DayViewModule"
            Me.Size = New System.Drawing.Size(1084, 653)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnDayViewModuleLoad)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.OnDayViewModuleVisibleChanged)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.spOptionPane.ResumeLayout(False)
            CType((Me.tbOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tbOptions.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            CType((Me.cbTimeMarkerStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbColumnWidthMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkCustomGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbSnapToCellsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbAllDayStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkStatusOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAllowHtmlText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinDaysCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowDayHeaders.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowAllDayArea.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowRightTimeRuler.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeMarkerVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbTimeIndicatorVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowOverAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkColorizeResources.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupAppointmentLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPane As DevExpress.XtraEditors.SidePanel

        Private chkShowOverAppointment As DevExpress.XtraEditors.CheckEdit

        Private cbTimeMarkerVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private cbTimeIndicatorVisibility As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private cbSnapToCellsMode As DevExpress.XtraEditors.ComboBoxEdit

        Private cbAllDayStatus As DevExpress.XtraEditors.ComboBoxEdit

        Private chkStatusOrientation As DevExpress.XtraEditors.CheckEdit

        Private cbStatus As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private chkShowRightTimeRuler As DevExpress.XtraEditors.CheckEdit

        Private chkShowWorkTimeOnly As DevExpress.XtraEditors.CheckEdit

        Private chkShowAllDayArea As DevExpress.XtraEditors.CheckEdit

        Private chkShowDayHeaders As DevExpress.XtraEditors.CheckEdit

        Private spinDaysCount As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext

        Private layoutControl4 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private mvvmContext2 As DevExpress.Utils.MVVM.MVVMContext

        Private tbOptions As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private chkCustomGroup As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private groupAppointmentLayout As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private chkAllowHtmlText As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private chkColorizeResources As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private cbColumnWidthMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private cbTimeMarkerStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
