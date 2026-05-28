Namespace DevExpress.XtraScheduler.Demos

    Partial Class Tabs

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
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowAddButton = New DevExpress.XtraEditors.CheckEdit()
            Me.cmbResourceDisplayStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cmbAppointmentDisplayMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.cbAppointmentDisplayMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkShowCloseButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowAddButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cmbResourceDisplayStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cmbAppointmentDisplayMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbAppointmentDisplayMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
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
            ' schedulerControl
            ' 
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.DateNavigationBar.ShowViewSelectorButton = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(564, 424)
            Me.schedulerControl.Start = New System.DateTime(2019, 9, 24, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 1
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(284, 391)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.chkShowCloseButton)
            Me.layoutControl1.Controls.Add(Me.chkShowAddButton)
            Me.layoutControl1.Controls.Add(Me.cmbResourceDisplayStyle)
            Me.layoutControl1.Controls.Add(Me.cmbAppointmentDisplayMode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(284, 391)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkShowCloseButton
            ' 
            Me.chkShowCloseButton.Location = New System.Drawing.Point(5, 99)
            Me.chkShowCloseButton.MenuManager = Me
            Me.chkShowCloseButton.Name = "chkShowCloseButton"
            Me.chkShowCloseButton.Properties.Caption = "Show Close Button"
            Me.chkShowCloseButton.Size = New System.Drawing.Size(274, 20)
            Me.chkShowCloseButton.StyleController = Me.layoutControl1
            Me.chkShowCloseButton.TabIndex = 7
            AddHandler Me.chkShowCloseButton.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowCloseButton_CheckedChanged)
            ' 
            ' chkShowAddButton
            ' 
            Me.chkShowAddButton.Location = New System.Drawing.Point(5, 75)
            Me.chkShowAddButton.MenuManager = Me
            Me.chkShowAddButton.Name = "chkShowAddButton"
            Me.chkShowAddButton.Properties.Caption = "Show Add Button"
            Me.chkShowAddButton.Size = New System.Drawing.Size(274, 20)
            Me.chkShowAddButton.StyleController = Me.layoutControl1
            Me.chkShowAddButton.TabIndex = 6
            AddHandler Me.chkShowAddButton.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowAddButton_CheckedChanged)
            ' 
            ' cmbResourceDisplayStyle
            ' 
            Me.cmbResourceDisplayStyle.Location = New System.Drawing.Point(144, 27)
            Me.cmbResourceDisplayStyle.MenuManager = Me
            Me.cmbResourceDisplayStyle.Name = "cmbResourceDisplayStyle"
            Me.cmbResourceDisplayStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbResourceDisplayStyle.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.ResourceDisplayStyle.Headers, DevExpress.XtraScheduler.ResourceDisplayStyle.Tabs})
            Me.cmbResourceDisplayStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbResourceDisplayStyle.Size = New System.Drawing.Size(135, 20)
            Me.cmbResourceDisplayStyle.StyleController = Me.layoutControl1
            Me.cmbResourceDisplayStyle.TabIndex = 5
            AddHandler Me.cmbResourceDisplayStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbResourceDisplayStyle_SelectedIndexChanged)
            ' 
            ' cmbAppointmentDisplayMode
            ' 
            Me.cmbAppointmentDisplayMode.Location = New System.Drawing.Point(144, 51)
            Me.cmbAppointmentDisplayMode.MenuManager = Me
            Me.cmbAppointmentDisplayMode.Name = "cmbAppointmentDisplayMode"
            Me.cmbAppointmentDisplayMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbAppointmentDisplayMode.Properties.Items.AddRange(New Object() {DevExpress.XtraScheduler.AppointmentDisplayMode.AllResources, DevExpress.XtraScheduler.AppointmentDisplayMode.SelectedResource})
            Me.cmbAppointmentDisplayMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbAppointmentDisplayMode.Size = New System.Drawing.Size(135, 20)
            Me.cmbAppointmentDisplayMode.StyleController = Me.layoutControl1
            Me.cmbAppointmentDisplayMode.TabIndex = 4
            AddHandler Me.cmbAppointmentDisplayMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbAppointmentDisplayMode_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(284, 391)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 124)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(284, 267)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.cbAppointmentDisplayMode, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(284, 124)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Resource Category Options"
            ' 
            ' cbAppointmentDisplayMode
            ' 
            Me.cbAppointmentDisplayMode.Control = Me.cmbAppointmentDisplayMode
            Me.cbAppointmentDisplayMode.Location = New System.Drawing.Point(0, 24)
            Me.cbAppointmentDisplayMode.Name = "cbAppointmentDisplayMode"
            Me.cbAppointmentDisplayMode.Size = New System.Drawing.Size(278, 24)
            Me.cbAppointmentDisplayMode.Text = "Appointment Display Mode"
            Me.cbAppointmentDisplayMode.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cmbResourceDisplayStyle
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(278, 24)
            Me.layoutControlItem1.Text = "Resource Display Style"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(127, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkShowAddButton
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(278, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkShowCloseButton
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(278, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(284, 424)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(284, 424)
            Me.tabPane1.TabIndex = 3
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.schedulerControl)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(564, 424)
            Me.sidePanel1.TabIndex = 4
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.tabPane1)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel2.Location = New System.Drawing.Point(564, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(285, 424)
            Me.sidePanel2.TabIndex = 5
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(564, 0)
            Me.commonRibbon1.TabIndex = 1
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' Tabs
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.commonRibbon1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.sidePanel2)
            Me.Name = "Tabs"
            Me.Size = New System.Drawing.Size(849, 424)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Tabs_Load)
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkShowCloseButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowAddButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cmbResourceDisplayStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cmbAppointmentDisplayMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbAppointmentDisplayMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private cmbAppointmentDisplayMode As DevExpress.XtraEditors.ComboBoxEdit

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbAppointmentDisplayMode As DevExpress.XtraLayout.LayoutControlItem

        Private cmbResourceDisplayStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private chkShowCloseButton As DevExpress.XtraEditors.CheckEdit

        Private chkShowAddButton As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
