Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

    Public Class PreviewControl
        Inherits ReportPreviewControlBase

        Private components As System.ComponentModel.IContainer = Nothing

        Private rgrpView As XtraEditors.RadioGroup

        Private _monthReport As MonthReport

        Private spinHeight As XtraEditors.SpinEdit

        Protected chkCanGrow As XtraEditors.CheckEdit

        Protected chkCanShrink As XtraEditors.CheckEdit

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private layoutControlItem5 As XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private _timelineReport As TimelineReport

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            printControl.Zoom = 0.6F
            InitializeControlValues()
        End Sub

        Private ReadOnly Property MonthReport As MonthReport
            Get
                Return _monthReport
            End Get
        End Property

        Private ReadOnly Property TimelineReport As TimelineReport
            Get
                Return _timelineReport
            End Get
        End Property

        Private ReadOnly Property ViewType As SchedulerViewType
            Get
                Return CType(rgrpView.EditValue, SchedulerViewType)
            End Get
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
            If _timelineReport IsNot Nothing Then _timelineReport.Dispose()
            _timelineReport = New TimelineReport()
        End Sub

        Protected Overrides Function GetActiveReport() As XtraSchedulerReport
            If ViewType.Equals(SchedulerViewType.Month) Then
                Return MonthReport
            Else
                Return TimelineReport
            End If
        End Function

        Protected Overrides Sub FillReportSourceData()
            DemoUtils.FillReportsStorageData(SchedulerStorage)
        End Sub

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date.AddDays(17), TimeSpan.FromDays(14))
        End Sub

        Private Sub InitializeControlValues()
            Dim report As IAutoHeightReport = CType(GetActiveReport(), IAutoHeightReport)
            chkCanShrink.Checked = report.CellsCanShrink
            chkCanGrow.Checked = report.CellsCanGrow
            spinHeight.Value = CDec(report.CellsHeight)
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Dim autoHeightReport As IAutoHeightReport = CType(otherReport, IAutoHeightReport)
            autoHeightReport.CellsHeight = CSng(spinHeight.Value)
            autoHeightReport.CellsCanGrow = chkCanGrow.Checked
            autoHeightReport.CellsCanShrink = chkCanShrink.Checked
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            rgrpView = New XtraEditors.RadioGroup()
            spinHeight = New XtraEditors.SpinEdit()
            chkCanShrink = New XtraEditors.CheckEdit()
            chkCanGrow = New XtraEditors.CheckEdit()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
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
            CType(rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(485, 396)
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(AnchorStyles.Bottom Or AnchorStyles.Right, AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(171, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = DockStyle.Right
            navigationPaneSettings.ItemOrientation = Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(485, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.RegularSize = New System.Drawing.Size(215, 396)
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.Size = New System.Drawing.Size(215, 396)
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(185, 352)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(spinHeight)
            layoutControlSettings.Controls.Add(chkCanGrow)
            layoutControlSettings.Controls.Add(rgrpView)
            layoutControlSettings.Controls.Add(chkCanShrink)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Size = New System.Drawing.Size(185, 352)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(chkCanShrink, 0)
            layoutControlSettings.Controls.SetChildIndex(rgrpView, 0)
            layoutControlSettings.Controls.SetChildIndex(chkCanGrow, 0)
            layoutControlSettings.Controls.SetChildIndex(spinHeight, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup1, layoutControlGroup2, emptySpaceItem3})
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Size = New System.Drawing.Size(185, 352)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(175, 26)
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.AllowHotTrack = False
            emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
            emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem1.Size = New System.Drawing.Size(175, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 225)
            emptySpaceItem2.Size = New System.Drawing.Size(175, 117)
            ' 
            ' rgrpView
            ' 
            rgrpView.EditValue = SchedulerViewType.Month
            rgrpView.Location = New System.Drawing.Point(13, 67)
            rgrpView.MaximumSize = New System.Drawing.Size(0, 45)
            rgrpView.MinimumSize = New System.Drawing.Size(0, 45)
            rgrpView.Name = "rgrpView"
            rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            rgrpView.Properties.Appearance.Options.UseBackColor = True
            rgrpView.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            rgrpView.Properties.Columns = 1
            rgrpView.Properties.Items.AddRange(New XtraEditors.Controls.RadioGroupItem() {New XtraEditors.Controls.RadioGroupItem(SchedulerViewType.Month, "Month"), New XtraEditors.Controls.RadioGroupItem(SchedulerViewType.Timeline, "Timeline")})
            rgrpView.Size = New System.Drawing.Size(159, 45)
            rgrpView.StyleController = layoutControlSettings
            rgrpView.TabIndex = 5
            AddHandler rgrpView.SelectedIndexChanged, New EventHandler(AddressOf rgrpView_SelectedIndexChanged)
            ' 
            ' spinHeight
            ' 
            spinHeight.EditValue = New Decimal(New Integer() {50, 0, 0, 0})
            spinHeight.Location = New System.Drawing.Point(52, 156)
            spinHeight.Name = "spinHeight"
            spinHeight.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinHeight.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            spinHeight.Properties.IsFloatValue = False
            spinHeight.Properties.Mask.EditMask = "N00"
            spinHeight.Properties.MaxValue = New Decimal(New Integer() {800, 0, 0, 0})
            spinHeight.Properties.MinValue = New Decimal(New Integer() {50, 0, 0, 0})
            spinHeight.Size = New System.Drawing.Size(120, 20)
            spinHeight.StyleController = layoutControlSettings
            spinHeight.TabIndex = 39
            AddHandler spinHeight.EditValueChanged, New EventHandler(AddressOf spinHeight_EditValueChanged)
            ' 
            ' chkCanShrink
            ' 
            chkCanShrink.Location = New System.Drawing.Point(13, 180)
            chkCanShrink.Name = "chkCanShrink"
            chkCanShrink.Properties.AutoWidth = True
            chkCanShrink.Properties.Caption = "Can Shrink"
            chkCanShrink.Size = New System.Drawing.Size(73, 19)
            chkCanShrink.StyleController = layoutControlSettings
            chkCanShrink.TabIndex = 50
            AddHandler chkCanShrink.CheckedChanged, New EventHandler(AddressOf chkCanShrink_CheckedChanged)
            ' 
            ' chkCanGrow
            ' 
            chkCanGrow.Location = New System.Drawing.Point(13, 203)
            chkCanGrow.Name = "chkCanGrow"
            chkCanGrow.Properties.AutoWidth = True
            chkCanGrow.Properties.Caption = "Can Grow"
            chkCanGrow.Size = New System.Drawing.Size(69, 19)
            chkCanGrow.StyleController = layoutControlSettings
            chkCanGrow.TabIndex = 51
            AddHandler chkCanGrow.CheckedChanged, New EventHandler(AddressOf chkCanGrow_CheckedChanged)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = rgrpView
            layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(163, 49)
            layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(175, 79)
            layoutControlGroup1.Text = "Report Type"
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = spinHeight
            layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(163, 24)
            layoutControlItem3.Text = "Height:"
            layoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = chkCanShrink
            layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(163, 23)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = chkCanGrow
            layoutControlItem5.Location = New System.Drawing.Point(0, 47)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(163, 23)
            layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem3, layoutControlItem4, layoutControlItem5})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 125)
            layoutControlGroup2.Name = "layoutControlGroup2"
            layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup2.Size = New System.Drawing.Size(175, 100)
            layoutControlGroup2.Text = "Cells Options"
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 115)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(175, 10)
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
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
            CType(rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub rgrpView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub spinHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub chkCanShrink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub chkCanGrow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub
    End Class

    Public Interface IAutoHeightReport

        Property CellsCanShrink As Boolean

        Property CellsCanGrow As Boolean

        Property CellsHeight As Single

    End Interface
End Namespace
