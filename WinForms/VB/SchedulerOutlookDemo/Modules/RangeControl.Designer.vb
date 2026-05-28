Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos

    Partial Class RangeControlModule

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
            Dim rangeControlRange1 As DevExpress.XtraEditors.RangeControlRange = New DevExpress.XtraEditors.RangeControlRange()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.spinThumbnailHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.spinMaxIntervalCount = New DevExpress.XtraEditors.SpinEdit()
            Me.rgrpSchedulerType = New DevExpress.XtraEditors.RadioGroup()
            Me.chkAutoFormatCaptions = New DevExpress.XtraEditors.CheckEdit()
            Me.cbThumbnailDisplay = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chkAllowChangeActiveView = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupRangeControl = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.spOptionPane = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinThumbnailHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinMaxIntervalCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgrpSchedulerType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAutoFormatCaptions.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbThumbnailDisplay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAllowChangeActiveView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupRangeControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.spOptionPane.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' rangeControl
            ' 
            Me.rangeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rangeControl.Client = Me.schedulerControl
            Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rangeControl.Location = New System.Drawing.Point(0, 0)
            Me.rangeControl.MinimumSize = New System.Drawing.Size(0, 140)
            Me.rangeControl.Name = "rangeControl"
            rangeControlRange1.Maximum = New System.DateTime(2025, 6, 2, 0, 0, 0, 0)
            rangeControlRange1.Minimum = New System.DateTime(2025, 6, 1, 0, 0, 0, 0)
            rangeControlRange1.Owner = Me.rangeControl
            Me.rangeControl.SelectedRange = rangeControlRange1
            Me.rangeControl.Size = New System.Drawing.Size(418, 144)
            Me.rangeControl.TabIndex = 5
            Me.rangeControl.Text = "rangeControl"
            Me.rangeControl.VisibleRangeMaximumScaleFactor = Double.PositiveInfinity
            Me.rangeControl.VisibleRangeScaleFactor = 22.06611570247934R
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.DateNavigationBar.ShowViewSelectorButton = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.LimitInterval.Duration = System.TimeSpan.Parse("364.00:00:00")
            Me.schedulerControl.LimitInterval.Start = New System.DateTime(2010, 1, 1, 0, 0, 0, 0)
            Me.schedulerControl.Location = New System.Drawing.Point(0, 145)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.OptionsRangeControl.AutoAdjustMode = False
            Me.schedulerControl.Size = New System.Drawing.Size(418, 367)
            Me.schedulerControl.Start = New System.DateTime(2010, 12, 30, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 6
            Me.schedulerControl.Text = "schedulerControl"
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl.Views.YearView.Enabled = False
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
            ' spinThumbnailHeight
            ' 
            Me.spinThumbnailHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinThumbnailHeight.Location = New System.Drawing.Point(158, 156)
            Me.spinThumbnailHeight.Name = "spinThumbnailHeight"
            Me.spinThumbnailHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinThumbnailHeight.Properties.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinThumbnailHeight.Properties.IsFloatValue = False
            Me.spinThumbnailHeight.Properties.Mask.EditMask = "N00"
            Me.spinThumbnailHeight.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinThumbnailHeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinThumbnailHeight.Size = New System.Drawing.Size(122, 20)
            Me.spinThumbnailHeight.StyleController = Me.layoutControl1
            Me.spinThumbnailHeight.TabIndex = 4
            AddHandler Me.spinThumbnailHeight.EditValueChanged, New System.EventHandler(AddressOf Me.spinThumbnailHeight_EditValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.spinThumbnailHeight)
            Me.layoutControl1.Controls.Add(Me.spinMaxIntervalCount)
            Me.layoutControl1.Controls.Add(Me.rgrpSchedulerType)
            Me.layoutControl1.Controls.Add(Me.chkAutoFormatCaptions)
            Me.layoutControl1.Controls.Add(Me.cbThumbnailDisplay)
            Me.layoutControl1.Controls.Add(Me.chkAllowChangeActiveView)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 479)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(5, 27)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(70, 13)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 102
            Me.labelControl1.Text = "Schedule Type"
            ' 
            ' spinMaxIntervalCount
            ' 
            Me.spinMaxIntervalCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinMaxIntervalCount.Location = New System.Drawing.Point(158, 180)
            Me.spinMaxIntervalCount.Name = "spinMaxIntervalCount"
            Me.spinMaxIntervalCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinMaxIntervalCount.Properties.IsFloatValue = False
            Me.spinMaxIntervalCount.Properties.Mask.EditMask = "N00"
            Me.spinMaxIntervalCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinMaxIntervalCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinMaxIntervalCount.Size = New System.Drawing.Size(122, 20)
            Me.spinMaxIntervalCount.StyleController = Me.layoutControl1
            Me.spinMaxIntervalCount.TabIndex = 5
            AddHandler Me.spinMaxIntervalCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinMaxIntervalCount_EditValueChanged)
            ' 
            ' rgrpSchedulerType
            ' 
            Me.rgrpSchedulerType.EditValue = 0
            Me.rgrpSchedulerType.Location = New System.Drawing.Point(5, 44)
            Me.rgrpSchedulerType.MaximumSize = New System.Drawing.Size(0, 35)
            Me.rgrpSchedulerType.Name = "rgrpSchedulerType"
            Me.rgrpSchedulerType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgrpSchedulerType.Properties.Appearance.Options.UseBackColor = True
            Me.rgrpSchedulerType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgrpSchedulerType.Properties.Columns = 3
            Me.rgrpSchedulerType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Daily"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Monthly"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Yearly")})
            Me.rgrpSchedulerType.Size = New System.Drawing.Size(275, 32)
            Me.rgrpSchedulerType.StyleController = Me.layoutControl1
            Me.rgrpSchedulerType.TabIndex = 101
            AddHandler Me.rgrpSchedulerType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgrpSchedulerType_SelectedIndexChanged)
            ' 
            ' chkAutoFormatCaptions
            ' 
            Me.chkAutoFormatCaptions.Location = New System.Drawing.Point(5, 204)
            Me.chkAutoFormatCaptions.Name = "chkAutoFormatCaptions"
            Me.chkAutoFormatCaptions.Properties.Caption = "Auto Format Captions"
            Me.chkAutoFormatCaptions.Size = New System.Drawing.Size(275, 20)
            Me.chkAutoFormatCaptions.StyleController = Me.layoutControl1
            Me.chkAutoFormatCaptions.TabIndex = 2
            AddHandler Me.chkAutoFormatCaptions.CheckedChanged, New System.EventHandler(AddressOf Me.chkAutoFormatCaptions_CheckedChanged)
            ' 
            ' cbThumbnailDisplay
            ' 
            Me.cbThumbnailDisplay.EditValue = ""
            Me.cbThumbnailDisplay.Location = New System.Drawing.Point(158, 132)
            Me.cbThumbnailDisplay.Name = "cbThumbnailDisplay"
            Me.cbThumbnailDisplay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbThumbnailDisplay.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.RangeControlDataDisplayType.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Thumbnail", DevExpress.XtraScheduler.RangeControlDataDisplayType.Thumbnail, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Number", DevExpress.XtraScheduler.RangeControlDataDisplayType.Number, -1)})
            Me.cbThumbnailDisplay.Size = New System.Drawing.Size(122, 20)
            Me.cbThumbnailDisplay.StyleController = Me.layoutControl1
            Me.cbThumbnailDisplay.TabIndex = 3
            AddHandler Me.cbThumbnailDisplay.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbThumbnailDisplay_SelectedIndexChanged)
            ' 
            ' chkAllowChangeActiveView
            ' 
            Me.chkAllowChangeActiveView.Location = New System.Drawing.Point(5, 80)
            Me.chkAllowChangeActiveView.Name = "chkAllowChangeActiveView"
            Me.chkAllowChangeActiveView.Properties.Caption = "Auto Change Scheduler View"
            Me.chkAllowChangeActiveView.Size = New System.Drawing.Size(275, 20)
            Me.chkAllowChangeActiveView.StyleController = Me.layoutControl1
            Me.chkAllowChangeActiveView.TabIndex = 1
            AddHandler Me.chkAllowChangeActiveView.CheckedChanged, New System.EventHandler(AddressOf Me.chkAllowChangeActiveView_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupView, Me.groupRangeControl, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 479)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupView
            ' 
            Me.groupView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem1, Me.layoutControlItem2})
            Me.groupView.Location = New System.Drawing.Point(0, 0)
            Me.groupView.Name = "groupView"
            Me.groupView.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupView.Size = New System.Drawing.Size(285, 105)
            Me.groupView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupView.Text = "View"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.labelControl1
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(279, 17)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkAllowChangeActiveView
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 53)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.rgrpSchedulerType
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(279, 36)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' groupRangeControl
            ' 
            Me.groupRangeControl.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupRangeControl.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem3})
            Me.groupRangeControl.Location = New System.Drawing.Point(0, 105)
            Me.groupRangeControl.Name = "groupRangeControl"
            Me.groupRangeControl.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.groupRangeControl.Size = New System.Drawing.Size(285, 124)
            Me.groupRangeControl.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupRangeControl.Text = "Range Control"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbThumbnailDisplay
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem4.Text = "Display Appointments As:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(141, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.spinThumbnailHeight
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem5.Text = "Thumbnail Height:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(141, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.spinMaxIntervalCount
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem6.Text = "Max Selected Interval Count:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(141, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkAutoFormatCaptions
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 229)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(285, 250)
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.schedulerControl)
            Me.panelControl1.Controls.Add(Me.sidePanel1)
            Me.panelControl1.Controls.Add(Me.commonRibbon1)
            Me.panelControl1.Controls.Add(Me.spOptionPane)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(704, 512)
            Me.panelControl1.TabIndex = 100
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.rangeControl)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(0, 145)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(418, 145)
            Me.sidePanel1.TabIndex = 10
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(418, 0)
            Me.commonRibbon1.TabIndex = 8
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' spOptionPane
            ' 
            Me.spOptionPane.Controls.Add(Me.tabPane1)
            Me.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPane.Location = New System.Drawing.Point(418, 0)
            Me.spOptionPane.Name = "spOptionPane"
            Me.spOptionPane.Size = New System.Drawing.Size(286, 512)
            Me.spOptionPane.TabIndex = 9
            Me.spOptionPane.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(285, 512)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(285, 512)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(285, 479)
            ' 
            ' RangeControlModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "RangeControlModule"
            Me.Size = New System.Drawing.Size(704, 512)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnModuleLoad)
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinThumbnailHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinMaxIntervalCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgrpSchedulerType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAutoFormatCaptions.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbThumbnailDisplay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAllowChangeActiveView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupRangeControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.spOptionPane.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private rangeControl As DevExpress.XtraEditors.RangeControl

        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private chkAllowChangeActiveView As DevExpress.XtraEditors.CheckEdit

        Private cbThumbnailDisplay As DevExpress.XtraEditors.ImageComboBoxEdit

        Private chkAutoFormatCaptions As DevExpress.XtraEditors.CheckEdit

        Private spinMaxIntervalCount As DevExpress.XtraEditors.SpinEdit

        Private rgrpSchedulerType As DevExpress.XtraEditors.RadioGroup

        Private spinThumbnailHeight As DevExpress.XtraEditors.SpinEdit

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private groupView As DevExpress.XtraLayout.LayoutControlGroup

        Private groupRangeControl As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPane As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
