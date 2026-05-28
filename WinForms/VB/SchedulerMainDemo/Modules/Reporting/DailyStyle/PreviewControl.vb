Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Protected chkPrintAllAppointments As XtraEditors.CheckEdit

        Protected cbTimeScale As UI.DurationEdit

        Protected steToTime As UI.SchedulerTimeEdit

        Protected steFromTime As UI.SchedulerTimeEdit

        Protected edtEnd As XtraEditors.DateEdit

        Protected edtStart As XtraEditors.DateEdit

        Private spinResourceCount As XtraEditors.SpinEdit

        Private visibleResourceCount As Integer = 0

        Private visibleDayCount As Integer = 1

        Private printAllAppointments As Boolean = False

        Private timeScale As TimeSpan = TimeSpan.Zero

        Private printInterval As TimeInterval = TimeInterval.Empty

        Private spinDayCount As XtraEditors.SpinEdit

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private layoutControlItem5 As XtraLayout.LayoutControlItem

        Private layoutControlItem6 As XtraLayout.LayoutControlItem

        Private layoutControlItem7 As XtraLayout.LayoutControlItem

        Private layoutControlItem8 As XtraLayout.LayoutControlItem

        Private layoutControlItem9 As XtraLayout.LayoutControlItem

        Private visibleTime As TimeOfDayInterval = TimeOfDayInterval.Day

        'SchedulerGroupType groupType = SchedulerGroupType.None;
        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Private Property EndDate As Date
            Get
                Return edtEnd.DateTime.AddDays(1)
            End Get

            Set(ByVal value As Date)
                edtEnd.DateTime = value.AddDays(-1)
            End Set
        End Property

        Private Property StartDate As Date
            Get
                Return edtStart.DateTime
            End Get

            Set(ByVal value As Date)
                edtStart.DateTime = value
            End Set
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
            SubscribeEvents()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function

        Private Sub InitializeControlValues()
            visibleResourceCount = Report.VisibleResourceCount
            spinResourceCount.EditValue = visibleResourceCount
            spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount
            visibleDayCount = Report.VisibleDayCount
            spinDayCount.EditValue = visibleDayCount
            spinDayCount.Properties.MinValue = 1
            spinDayCount.Properties.MaxValue = 7
            visibleTime = Report.VisibleTime
            steFromTime.Time = New DateTime(visibleTime.Start.Ticks)
            steToTime.Time = New DateTime(visibleTime.End.Ticks)
            printInterval = New TimeInterval(BaseDate, BaseDate.AddDays(6))
            StartDate = printInterval.Start
            EndDate = printInterval.End
            timeScale = Report.TimeScale
            cbTimeScale.EditValue = timeScale
            printAllAppointments = Report.PrintAllAppointments
            chkPrintAllAppointments.Checked = printAllAppointments
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            StoragePrintAdapter.TimeInterval = printInterval
            MyBase.UpdateReportProperties(otherReport)
            Report.VisibleResourceCount = visibleResourceCount
            Report.VisibleTime = visibleTime
            Report.TimeScale = timeScale
            Report.VisibleDayCount = visibleDayCount
            Report.PrintAllAppointments = printAllAppointments
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            chkPrintAllAppointments = New XtraEditors.CheckEdit()
            edtEnd = New XtraEditors.DateEdit()
            edtStart = New XtraEditors.DateEdit()
            cbTimeScale = New UI.DurationEdit()
            steToTime = New UI.SchedulerTimeEdit()
            steFromTime = New UI.SchedulerTimeEdit()
            spinResourceCount = New XtraEditors.SpinEdit()
            spinDayCount = New XtraEditors.SpinEdit()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            navigationPaneSettings.SuspendLayout()
            navigationPageSettings.SuspendLayout()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControlSettings.SuspendLayout()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(steToTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(steFromTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinDayCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(484, 396)
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(172, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(484, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.RegularSize = New System.Drawing.Size(216, 396)
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.Size = New System.Drawing.Size(216, 396)
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(186, 352)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(steToTime)
            layoutControlSettings.Controls.Add(chkPrintAllAppointments)
            layoutControlSettings.Controls.Add(steFromTime)
            layoutControlSettings.Controls.Add(cbTimeScale)
            layoutControlSettings.Controls.Add(spinDayCount)
            layoutControlSettings.Controls.Add(edtEnd)
            layoutControlSettings.Controls.Add(spinResourceCount)
            layoutControlSettings.Controls.Add(edtStart)
            layoutControlSettings.Size = New System.Drawing.Size(186, 352)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(edtStart, 0)
            layoutControlSettings.Controls.SetChildIndex(spinResourceCount, 0)
            layoutControlSettings.Controls.SetChildIndex(edtEnd, 0)
            layoutControlSettings.Controls.SetChildIndex(spinDayCount, 0)
            layoutControlSettings.Controls.SetChildIndex(cbTimeScale, 0)
            layoutControlSettings.Controls.SetChildIndex(steFromTime, 0)
            layoutControlSettings.Controls.SetChildIndex(chkPrintAllAppointments, 0)
            layoutControlSettings.Controls.SetChildIndex(steToTime, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Name = "layoutControlGroup1"
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8, layoutControlItem9})
            layoutControlGroupSettings.Size = New System.Drawing.Size(186, 352)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(176, 26)
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.AllowHotTrack = False
            emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
            emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.Size = New System.Drawing.Size(176, 10)
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Location = New System.Drawing.Point(0, 227)
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.Size = New System.Drawing.Size(176, 115)
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' chkPrintAllAppointments
            ' 
            chkPrintAllAppointments.Location = New System.Drawing.Point(7, 211)
            chkPrintAllAppointments.Name = "chkPrintAllAppointments"
            chkPrintAllAppointments.Properties.AccessibleName = "Print all appointments"
            chkPrintAllAppointments.Properties.AutoWidth = True
            chkPrintAllAppointments.Properties.Caption = "Print All Appointments"
            chkPrintAllAppointments.Size = New System.Drawing.Size(127, 19)
            chkPrintAllAppointments.StyleController = layoutControlSettings
            chkPrintAllAppointments.TabIndex = 8
            AddHandler chkPrintAllAppointments.CheckedChanged, New EventHandler(AddressOf chkPrintAllAppointments_CheckedChanged)
            ' 
            ' edtEnd
            ' 
            edtEnd.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtEnd.Location = New System.Drawing.Point(92, 139)
            edtEnd.Name = "edtEnd"
            edtEnd.Properties.AccessibleName = "End date:"
            edtEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtEnd.Size = New System.Drawing.Size(87, 20)
            edtEnd.StyleController = layoutControlSettings
            edtEnd.TabIndex = 16
            ' 
            ' edtStart
            ' 
            edtStart.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtStart.Location = New System.Drawing.Point(92, 115)
            edtStart.Name = "edtStart"
            edtStart.Properties.AccessibleName = "Start date:"
            edtStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtStart.Size = New System.Drawing.Size(87, 20)
            edtStart.StyleController = layoutControlSettings
            edtStart.TabIndex = 15
            ' 
            ' cbTimeScale
            ' 
            cbTimeScale.EditValue = ""
            cbTimeScale.Location = New System.Drawing.Point(92, 91)
            cbTimeScale.Name = "cbTimeScale"
            cbTimeScale.Properties.AccessibleName = "Duration:"
            cbTimeScale.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cbTimeScale.Properties.DisabledStateText = Nothing
            cbTimeScale.Properties.Items.AddRange(New Object() {TimeSpan.Parse("00:05:00"), TimeSpan.Parse("00:10:00"), TimeSpan.Parse("00:15:00"), TimeSpan.Parse("00:30:00"), TimeSpan.Parse("01:00:00"), TimeSpan.Parse("02:00:00"), TimeSpan.Parse("03:00:00"), TimeSpan.Parse("04:00:00"), TimeSpan.Parse("05:00:00"), TimeSpan.Parse("06:00:00"), TimeSpan.Parse("07:00:00"), TimeSpan.Parse("08:00:00"), TimeSpan.Parse("09:00:00"), TimeSpan.Parse("10:00:00"), TimeSpan.Parse("11:00:00"), TimeSpan.Parse("12:00:00")})
            cbTimeScale.Properties.ShowEmptyItem = False
            cbTimeScale.Size = New System.Drawing.Size(87, 20)
            cbTimeScale.StyleController = layoutControlSettings
            cbTimeScale.TabIndex = 22
            AddHandler cbTimeScale.SelectedIndexChanged, New EventHandler(AddressOf cbDuration_SelectedIndexChanged)
            ' 
            ' steToTime
            ' 
            steToTime.EditValue = New DateTime(2005, 8, 24, 0, 0, 0, 0)
            steToTime.Location = New System.Drawing.Point(92, 187)
            steToTime.Name = "steToTime"
            steToTime.Properties.AccessibleName = "Print to:"
            steToTime.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            steToTime.Properties.EditValueChangedFiringMode = XtraEditors.Controls.EditValueChangedFiringMode.Default
            steToTime.Size = New System.Drawing.Size(87, 20)
            steToTime.StyleController = layoutControlSettings
            steToTime.TabIndex = 20
            ' 
            ' steFromTime
            ' 
            steFromTime.EditValue = New DateTime(2005, 8, 24, 0, 0, 0, 0)
            steFromTime.Location = New System.Drawing.Point(92, 163)
            steFromTime.Name = "steFromTime"
            steFromTime.Properties.AccessibleName = "Print from:"
            steFromTime.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            steFromTime.Properties.EditValueChangedFiringMode = XtraEditors.Controls.EditValueChangedFiringMode.Default
            steFromTime.Size = New System.Drawing.Size(87, 20)
            steFromTime.StyleController = layoutControlSettings
            steFromTime.TabIndex = 18
            ' 
            ' spinResourceCount
            ' 
            spinResourceCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinResourceCount.Location = New System.Drawing.Point(92, 43)
            spinResourceCount.Name = "spinResourceCount"
            spinResourceCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinResourceCount.Properties.IsFloatValue = False
            spinResourceCount.Properties.Mask.EditMask = "N00"
            spinResourceCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            spinResourceCount.Size = New System.Drawing.Size(87, 20)
            spinResourceCount.StyleController = layoutControlSettings
            spinResourceCount.TabIndex = 38
            ' 
            ' spinDayCount
            ' 
            spinDayCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinDayCount.Location = New System.Drawing.Point(92, 67)
            spinDayCount.Name = "spinDayCount"
            spinDayCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinDayCount.Properties.IsFloatValue = False
            spinDayCount.Properties.Mask.EditMask = "N00"
            spinDayCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            spinDayCount.Size = New System.Drawing.Size(87, 20)
            spinDayCount.StyleController = layoutControlSettings
            spinDayCount.TabIndex = 38
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = spinResourceCount
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(176, 24)
            layoutControlItem2.Text = "Resource Count:"
            layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = spinDayCount
            layoutControlItem3.Location = New System.Drawing.Point(0, 60)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(176, 24)
            layoutControlItem3.Text = "Day Count:"
            layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = cbTimeScale
            layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(176, 24)
            layoutControlItem4.Text = "Time S&cale:"
            layoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = edtStart
            layoutControlItem5.Location = New System.Drawing.Point(0, 108)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(176, 24)
            layoutControlItem5.Text = "Start Date:"
            layoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = edtEnd
            layoutControlItem6.Location = New System.Drawing.Point(0, 132)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(176, 24)
            layoutControlItem6.Text = "End Date:"
            layoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = steFromTime
            layoutControlItem7.Location = New System.Drawing.Point(0, 156)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Size = New System.Drawing.Size(176, 24)
            layoutControlItem7.Text = "Print From:"
            layoutControlItem7.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem8
            ' 
            layoutControlItem8.Control = steToTime
            layoutControlItem8.Location = New System.Drawing.Point(0, 180)
            layoutControlItem8.Name = "layoutControlItem8"
            layoutControlItem8.Size = New System.Drawing.Size(176, 24)
            layoutControlItem8.Text = "Print &To:"
            layoutControlItem8.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem9
            ' 
            layoutControlItem9.Control = chkPrintAllAppointments
            layoutControlItem9.Location = New System.Drawing.Point(0, 204)
            layoutControlItem9.Name = "layoutControlItem9"
            layoutControlItem9.Size = New System.Drawing.Size(176, 23)
            layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem9.TextVisible = False
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Name = "PreviewControl"
            Me.Controls.Add(navigationPaneSettings)
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
            navigationPaneSettings.ResumeLayout(False)
            navigationPageSettings.ResumeLayout(False)
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControlSettings.ResumeLayout(False)
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(steToTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(steFromTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinDayCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim designForm As CustomDesignForm = New CustomDesignForm()
            Dim activeReport As XtraSchedulerReport = GetActiveReport()
            If activeReport Is Nothing Then Return
            designForm.OpenReport(activeReport)
            PreventUpdate = True
            Try
                ShowDesignerForm(designForm, FindForm())
            Finally
                PreventUpdate = False
            End Try

            designForm.Dispose()
            CreateReports()
            UpdateActiveReport()
        End Sub

        Protected Friend Overridable Sub UnsubscribeEvents()
            RemoveHandler spinDayCount.EditValueChanged, New EventHandler(AddressOf spinDayCount_EditValueChanged)
            RemoveHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
            RemoveHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            RemoveHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            RemoveHandler steFromTime.EditValueChanged, New EventHandler(AddressOf steFromTime_EditValueChanged)
            RemoveHandler steToTime.EditValueChanged, New EventHandler(AddressOf steToTime_EditValueChanged)
        End Sub

        Protected Friend Overridable Sub SubscribeEvents()
            AddHandler spinDayCount.EditValueChanged, New EventHandler(AddressOf spinDayCount_EditValueChanged)
            AddHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
            AddHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            AddHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            AddHandler steFromTime.EditValueChanged, New EventHandler(AddressOf steFromTime_EditValueChanged)
            AddHandler steToTime.EditValueChanged, New EventHandler(AddressOf steToTime_EditValueChanged)
        End Sub

        Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
            UpdateActiveReport()
        End Sub

        Private Sub spinDayCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            visibleDayCount = Convert.ToInt32(spinDayCount.EditValue)
            UpdateActiveReport()
        End Sub

        Private Sub cbDuration_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            timeScale = cbTimeScale.Duration
            UpdateActiveReport()
        End Sub

        Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtEnd.EditValue = StartDate
            printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub

        Protected Friend Overridable Function IsValidInterval(ByVal start As Date, ByVal [end] As Date) As Boolean
            Return start <= [end]
        End Function

        Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtStart.EditValue = EndDate.AddDays(-1)
            printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub

        Private Sub steFromTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibleTime()
        End Sub

        Private Sub steToTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibleTime()
        End Sub

        Protected Friend Overridable Sub UpdateVisibleTime()
            'Debug.Assert(edtStart.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            'Debug.Assert(edtEnd.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            Dim start As TimeSpan = steFromTime.Time.TimeOfDay
            Dim [end] As TimeSpan = steToTime.Time.TimeOfDay
            Dim duration As TimeSpan = [end] - start
            If duration.Ticks <= 0 Then [end] += DateTimeHelper.DaySpan
            visibleTime = New TimeOfDayInterval(start, [end])
            UpdateActiveReport()
        End Sub

        Private Sub chkPrintAllAppointments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            printAllAppointments = chkPrintAllAppointments.Checked
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
