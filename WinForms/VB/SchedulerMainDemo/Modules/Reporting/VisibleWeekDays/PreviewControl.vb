Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

    Public Class PreviewControl
        Inherits ReportPreviewControlBase

        Private components As System.ComponentModel.IContainer = Nothing

        Private weekDaysCheckEdit1 As UI.WeekDaysCheckEdit

        Private _visibleWeekDays As WeekDays = WeekDays.EveryDay

        Private _monthReport As MonthReport

        Private rgrpView As XtraEditors.RadioGroup

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private _dayReport As DayReport

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
        End Sub

        Private ReadOnly Property ViewType As SchedulerViewType
            Get
                Return CType(rgrpView.EditValue, SchedulerViewType)
            End Get
        End Property

        Private ReadOnly Property MonthReport As MonthReport
            Get
                Return _monthReport
            End Get
        End Property

        Private ReadOnly Property DayReport As DayReport
            Get
                Return _dayReport
            End Get
        End Property

        Private Property VisibleWeekDays As WeekDays
            Get
                Return _visibleWeekDays
            End Get

            Set(ByVal value As WeekDays)
                _visibleWeekDays = value
            End Set
        End Property

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

        Protected Overrides Sub CreateReports()
            If _monthReport IsNot Nothing Then _monthReport.Dispose()
            _monthReport = New MonthReport()
            If _dayReport IsNot Nothing Then _dayReport.Dispose()
            _dayReport = New DayReport()
        End Sub

        Protected Overrides Function GetActiveReport() As XtraSchedulerReport
            If ViewType.Equals(SchedulerViewType.Month) Then
                Return MonthReport
            Else
                Return DayReport
            End If
        End Function

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(7 * 8))
        End Sub

        Private Sub InitializeControlValues()
            Dim report As IVisibleWeekDaysReport = CType(GetActiveReport(), IVisibleWeekDaysReport)
            VisibleWeekDays = report.VisibleWeekDays
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            If ViewType.Equals(SchedulerViewType.Month) Then
                CType(otherReport, MonthReport).VisibleWeekDays = VisibleWeekDays
            Else
                Dim dailyReport As DayReport = CType(otherReport, DayReport)
                dailyReport.VisibleWeekDays = VisibleWeekDays
                dailyReport.DayCount = CalculateDayCount()
            End If

            UpdateFormatServices()
        End Sub

        Private Function CalculateDayCount() As Integer
            Dim dayCount As Integer = Native.DateTimeHelper.ToDayOfWeeks(VisibleWeekDays).Length
            Return If(dayCount = 0, 7, dayCount)
        End Function

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            weekDaysCheckEdit1 = New UI.WeekDaysCheckEdit()
            rgrpView = New XtraEditors.RadioGroup()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControlSettings.SuspendLayout()
            CType(weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            navigationPaneSettings.SuspendLayout()
            navigationPageSettings.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(495, 441)
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(184, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(weekDaysCheckEdit1)
            layoutControlSettings.Controls.Add(rgrpView)
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1051, 187, 650, 400)
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.Size = New System.Drawing.Size(198, 397)
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            ' 
            ' weekDaysCheckEdit1
            ' 
            weekDaysCheckEdit1.Anchor = CType(Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
            weekDaysCheckEdit1.Appearance.Options.UseBackColor = True
            weekDaysCheckEdit1.Location = New System.Drawing.Point(13, 161)
            weekDaysCheckEdit1.Margin = New Windows.Forms.Padding(0)
            weekDaysCheckEdit1.MaximumSize = New System.Drawing.Size(0, 100)
            weekDaysCheckEdit1.MinimumSize = New System.Drawing.Size(0, 100)
            weekDaysCheckEdit1.Name = "weekDaysCheckEdit1"
            weekDaysCheckEdit1.Size = New System.Drawing.Size(172, 100)
            weekDaysCheckEdit1.TabIndex = 6
            AddHandler weekDaysCheckEdit1.WeekDaysChanged, New EventHandler(AddressOf weekDaysCheckEdit1_WeekDaysChanged_1)
            ' 
            ' rgrpView
            ' 
            rgrpView.EditValue = SchedulerViewType.Month
            rgrpView.Location = New System.Drawing.Point(13, 67)
            rgrpView.MaximumSize = New System.Drawing.Size(0, 50)
            rgrpView.MinimumSize = New System.Drawing.Size(0, 50)
            rgrpView.Name = "rgrpView"
            rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            rgrpView.Properties.Appearance.Options.UseBackColor = True
            rgrpView.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            rgrpView.Properties.Columns = 1
            rgrpView.Properties.Items.AddRange(New XtraEditors.Controls.RadioGroupItem() {New XtraEditors.Controls.RadioGroupItem(SchedulerViewType.Day, "Day"), New XtraEditors.Controls.RadioGroupItem(SchedulerViewType.Month, "Month")})
            rgrpView.Size = New System.Drawing.Size(172, 50)
            rgrpView.StyleController = layoutControlSettings
            rgrpView.TabIndex = 81
            AddHandler rgrpView.SelectedIndexChanged, New EventHandler(AddressOf rgrpView_SelectedIndexChanged_1)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem2, layoutControlGroup1, layoutControlGroup2, emptySpaceItem3, emptySpaceItem1})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(198, 397)
            layoutControlGroupSettings.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(188, 26)
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Location = New System.Drawing.Point(0, 264)
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.Size = New System.Drawing.Size(188, 123)
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem4})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(188, 84)
            layoutControlGroup1.Text = "Report Type"
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = rgrpView
            layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(176, 54)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 130)
            layoutControlGroup2.Name = "layoutControlGroup2"
            layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup2.Size = New System.Drawing.Size(188, 134)
            layoutControlGroup2.Text = "Visible Weekdays"
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = weekDaysCheckEdit1
            layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(176, 104)
            layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 120)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(188, 10)
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.AllowHotTrack = False
            emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
            emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.Size = New System.Drawing.Size(188, 10)
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(495, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.RegularSize = New System.Drawing.Size(225, 441)
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.Size = New System.Drawing.Size(225, 441)
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(198, 397)
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(navigationPaneSettings)
            Name = "PreviewControl"
            Size = New System.Drawing.Size(720, 441)
            Me.Controls.SetChildIndex(navigationPaneSettings, 0)
            Me.Controls.SetChildIndex(printControl, 0)
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControlSettings.ResumeLayout(False)
            CType(weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
            navigationPaneSettings.ResumeLayout(False)
            navigationPageSettings.ResumeLayout(False)
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

        Private Sub weekDaysCheckEdit1_WeekDaysChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            VisibleWeekDays = weekDaysCheckEdit1.WeekDays
            UpdateActiveReport()
        End Sub

        Private Sub rgrpView_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            VisibleWeekDays = weekDaysCheckEdit1.WeekDays
            UpdateActiveReport()
        End Sub

        Public Sub UpdateFormatServices()
            StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
            Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService("MM/dd, ddd")
            StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)
        End Sub
    End Class

    Public Interface IVisibleWeekDaysReport

        Property VisibleWeekDays As WeekDays

    End Interface
End Namespace
