Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private cmbFirstTimeScale As XtraEditors.ComboBoxEdit

        Private spinResourceCount As XtraEditors.SpinEdit

        Protected edtEnd As XtraEditors.DateEdit

        Protected edtStart As XtraEditors.DateEdit

        Private spinIntervalCount As XtraEditors.SpinEdit

        Private cmbSecondTimeScale As XtraEditors.ComboBoxEdit

        Private printInterval As TimeInterval = TimeInterval.Empty

        Private visibleResourceCount As Integer

        Private visibleIntevalCount As Integer

        Private firstLevelTimeScale As String

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

        Private secondLevelTimeScale As String

        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer. 
            InitializeComponent()
            PopulateFirstLevelScaleCombo()
            PopulateSecondLevelScaleCombo()
            InitializeControlValues()
            SubscribeEvents()
        End Sub

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
            visibleIntevalCount = Report.VisibleIntervalCount
            visibleResourceCount = Report.VisibleResourceCount
            firstLevelTimeScale = Report.FirstLevelTimeScale
            secondLevelTimeScale = Report.SecondLevelTimeScale
            cmbFirstTimeScale.EditValue = firstLevelTimeScale
            cmbSecondTimeScale.EditValue = secondLevelTimeScale
            spinIntervalCount.EditValue = visibleIntevalCount
            spinResourceCount.EditValue = visibleResourceCount
            printInterval = New TimeInterval(BaseDate.AddDays(-30), BaseDate.AddDays(30))
            StartDate = printInterval.Start
            EndDate = printInterval.End
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            StoragePrintAdapter.TimeInterval = printInterval
            MyBase.UpdateReportProperties(otherReport)
            Report.VisibleResourceCount = visibleResourceCount
            Report.VisibleIntervalCount = visibleIntevalCount
            Report.FirstLevelTimeScale = firstLevelTimeScale
            Report.SecondLevelTimeScale = secondLevelTimeScale
        End Sub

        Private Sub PopulateFirstLevelScaleCombo()
            cmbFirstTimeScale.Properties.Items.Clear()
            Dim scaleCount As Integer = Report.Scales.Count
            For i As Integer = 0 To scaleCount - 1 - 1
                cmbFirstTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
            Next

            cmbFirstTimeScale.SelectedIndex = 0
            firstLevelTimeScale = CStr(cmbFirstTimeScale.SelectedItem)
        End Sub

        Private Sub PopulateSecondLevelScaleCombo()
            Dim index As Integer = cmbFirstTimeScale.SelectedIndex
            cmbSecondTimeScale.Properties.Items.Clear()
            For i As Integer = index + 1 To Report.Scales.Count - 1
                cmbSecondTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
            Next

            cmbSecondTimeScale.SelectedIndex = 0
            secondLevelTimeScale = CStr(cmbSecondTimeScale.SelectedItem)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            cmbFirstTimeScale = New XtraEditors.ComboBoxEdit()
            spinResourceCount = New XtraEditors.SpinEdit()
            edtEnd = New XtraEditors.DateEdit()
            edtStart = New XtraEditors.DateEdit()
            spinIntervalCount = New XtraEditors.SpinEdit()
            cmbSecondTimeScale = New XtraEditors.ComboBoxEdit()
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
            CType(cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(201, 22)
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
            navigationPaneSettings.Location = New System.Drawing.Point(455, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.RegularSize = New System.Drawing.Size(245, 396)
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.Size = New System.Drawing.Size(245, 396)
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
            navigationPageSettings.Size = New System.Drawing.Size(215, 352)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(cmbSecondTimeScale)
            layoutControlSettings.Controls.Add(spinIntervalCount)
            layoutControlSettings.Controls.Add(edtEnd)
            layoutControlSettings.Controls.Add(edtStart)
            layoutControlSettings.Controls.Add(cmbFirstTimeScale)
            layoutControlSettings.Controls.Add(spinResourceCount)
            layoutControlSettings.Controls.SetChildIndex(spinResourceCount, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbFirstTimeScale, 0)
            layoutControlSettings.Controls.SetChildIndex(edtStart, 0)
            layoutControlSettings.Controls.SetChildIndex(edtEnd, 0)
            layoutControlSettings.Controls.SetChildIndex(spinIntervalCount, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbSecondTimeScale, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Name = "layoutControlGroup1"
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7})
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(205, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(205, 10)
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Location = New System.Drawing.Point(0, 180)
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.Size = New System.Drawing.Size(205, 162)
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' cmbFirstTimeScale
            ' 
            cmbFirstTimeScale.EditValue = ""
            cmbFirstTimeScale.Location = New System.Drawing.Point(106, 139)
            cmbFirstTimeScale.Name = "cmbFirstTimeScale"
            cmbFirstTimeScale.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbFirstTimeScale.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbFirstTimeScale.Size = New System.Drawing.Size(102, 20)
            cmbFirstTimeScale.StyleController = layoutControlSettings
            cmbFirstTimeScale.TabIndex = 5
            ' 
            ' spinResourceCount
            ' 
            spinResourceCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinResourceCount.Location = New System.Drawing.Point(106, 43)
            spinResourceCount.Name = "spinResourceCount"
            spinResourceCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinResourceCount.Properties.IsFloatValue = False
            spinResourceCount.Properties.Mask.EditMask = "N00"
            spinResourceCount.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
            spinResourceCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinResourceCount.Size = New System.Drawing.Size(102, 20)
            spinResourceCount.StyleController = layoutControlSettings
            spinResourceCount.TabIndex = 46
            AddHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
            ' 
            ' edtEnd
            ' 
            edtEnd.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtEnd.Location = New System.Drawing.Point(106, 115)
            edtEnd.Name = "edtEnd"
            edtEnd.Properties.AccessibleName = "End date:"
            edtEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtEnd.Size = New System.Drawing.Size(102, 20)
            edtEnd.StyleController = layoutControlSettings
            edtEnd.TabIndex = 43
            ' 
            ' edtStart
            ' 
            edtStart.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtStart.Location = New System.Drawing.Point(106, 91)
            edtStart.Name = "edtStart"
            edtStart.Properties.AccessibleName = "Start date:"
            edtStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtStart.Size = New System.Drawing.Size(102, 20)
            edtStart.StyleController = layoutControlSettings
            edtStart.TabIndex = 42
            ' 
            ' spinIntervalCount
            ' 
            spinIntervalCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinIntervalCount.Location = New System.Drawing.Point(106, 67)
            spinIntervalCount.Name = "spinIntervalCount"
            spinIntervalCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinIntervalCount.Properties.IsFloatValue = False
            spinIntervalCount.Properties.Mask.EditMask = "N00"
            spinIntervalCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            spinIntervalCount.Size = New System.Drawing.Size(102, 20)
            spinIntervalCount.StyleController = layoutControlSettings
            spinIntervalCount.TabIndex = 48
            AddHandler spinIntervalCount.EditValueChanged, New EventHandler(AddressOf spinIntervalCount_EditValueChanged)
            ' 
            ' cmbSecondTimeScale
            ' 
            cmbSecondTimeScale.EditValue = ""
            cmbSecondTimeScale.Location = New System.Drawing.Point(106, 163)
            cmbSecondTimeScale.Name = "cmbSecondTimeScale"
            cmbSecondTimeScale.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbSecondTimeScale.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbSecondTimeScale.Size = New System.Drawing.Size(102, 20)
            cmbSecondTimeScale.StyleController = layoutControlSettings
            cmbSecondTimeScale.TabIndex = 51
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = spinResourceCount
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(205, 24)
            layoutControlItem2.Text = "Resource Count:"
            layoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = spinIntervalCount
            layoutControlItem3.Location = New System.Drawing.Point(0, 60)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(205, 24)
            layoutControlItem3.Text = "Interval Count:"
            layoutControlItem3.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = edtStart
            layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(205, 24)
            layoutControlItem4.Text = "Start Date:"
            layoutControlItem4.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = edtEnd
            layoutControlItem5.Location = New System.Drawing.Point(0, 108)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(205, 24)
            layoutControlItem5.Text = "End Date:"
            layoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = cmbFirstTimeScale
            layoutControlItem6.Location = New System.Drawing.Point(0, 132)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(205, 24)
            layoutControlItem6.Text = "First Level Scale:"
            layoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = cmbSecondTimeScale
            layoutControlItem7.Location = New System.Drawing.Point(0, 156)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Size = New System.Drawing.Size(205, 24)
            layoutControlItem7.Text = "Second Level Scale:"
            layoutControlItem7.TextSize = New System.Drawing.Size(95, 13)
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
            CType(cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub cmbFirstTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            firstLevelTimeScale = cmbFirstTimeScale.EditValue.ToString()
            PopulateSecondLevelScaleCombo()
            UpdateActiveReport()
        End Sub

        Private Sub cmbSecondTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            secondLevelTimeScale = cmbSecondTimeScale.EditValue.ToString()
            UpdateActiveReport()
        End Sub

        Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
            UpdateActiveReport()
        End Sub

        Private Sub spinIntervalCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            visibleIntevalCount = Convert.ToInt32(spinIntervalCount.EditValue)
            UpdateActiveReport()
        End Sub

        Protected Friend Overridable Sub UnsubscribeEvents()
            RemoveHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            RemoveHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            RemoveHandler cmbFirstTimeScale.SelectedIndexChanged, New EventHandler(AddressOf cmbFirstTimeScale_SelectedIndexChanged)
            RemoveHandler cmbSecondTimeScale.SelectedIndexChanged, New EventHandler(AddressOf cmbSecondTimeScale_SelectedIndexChanged)
        End Sub

        Protected Friend Overridable Sub SubscribeEvents()
            AddHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            AddHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            AddHandler cmbFirstTimeScale.SelectedIndexChanged, New EventHandler(AddressOf cmbFirstTimeScale_SelectedIndexChanged)
            AddHandler cmbSecondTimeScale.SelectedIndexChanged, New EventHandler(AddressOf cmbSecondTimeScale_SelectedIndexChanged)
        End Sub

        Protected Friend Overridable Function IsValidInterval(ByVal start As Date, ByVal [end] As Date) As Boolean
            Return start <= [end]
        End Function

        Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtEnd.EditValue = StartDate
            printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub

        Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtStart.EditValue = EndDate.AddDays(-1)
            printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
