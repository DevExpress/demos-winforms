Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private cmbLayout As XtraEditors.ComboBoxEdit

        Private spinResourceCount As XtraEditors.SpinEdit

        Protected edtEnd As XtraEditors.DateEdit

        Protected edtStart As XtraEditors.DateEdit

        Private printInterval As TimeInterval = TimeInterval.Empty

        Private pagesPerWeek As Integer

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

        Private resourceCount As Integer

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

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(14))
        End Sub

        Private Sub InitializeControlValues()
            printInterval = New TimeInterval(BaseDate, BaseDate.AddDays(6))
            StartDate = printInterval.Start
            EndDate = printInterval.End
            pagesPerWeek = Report.ColumnCount
            Me.cmbLayout.SelectedIndex = pagesPerWeek - 1
            InitializeResourceCount()
        End Sub

        Private Sub InitializeResourceCount()
            spinResourceCount.Properties.MinValue = 1
            spinResourceCount.Properties.MaxValue = SchedulerStorage.Resources.Count
            resourceCount = Report.ResourceCount
            spinResourceCount.Value = resourceCount
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            StoragePrintAdapter.TimeInterval = printInterval
            MyBase.UpdateReportProperties(otherReport)
            Report.ColumnCount = pagesPerWeek
            Report.ResourceCount = resourceCount
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            Me.cmbLayout = New XtraEditors.ComboBoxEdit()
            spinResourceCount = New XtraEditors.SpinEdit()
            edtEnd = New XtraEditors.DateEdit()
            edtStart = New XtraEditors.DateEdit()
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
            CType((Me.cmbLayout.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(461, 396)
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            btnEdit.Size = New System.Drawing.Size(195, 22)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.Location = New System.Drawing.Point(461, 0)
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.RegularSize = New System.Drawing.Size(239, 396)
            navigationPaneSettings.Size = New System.Drawing.Size(239, 396)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(209, 352)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Controls.Add(edtEnd)
            layoutControlSettings.Controls.Add(edtStart)
            layoutControlSettings.Controls.Add(Me.cmbLayout)
            layoutControlSettings.Controls.Add(spinResourceCount)
            layoutControlSettings.Size = New System.Drawing.Size(209, 352)
            layoutControlSettings.Controls.SetChildIndex(spinResourceCount, 0)
            layoutControlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(edtStart, 0)
            layoutControlSettings.Controls.SetChildIndex(edtEnd, 0)
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
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5})
            layoutControlGroupSettings.Size = New System.Drawing.Size(209, 352)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(199, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(199, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 132)
            emptySpaceItem2.Size = New System.Drawing.Size(199, 210)
            ' 
            ' cmbLayout
            ' 
            Me.cmbLayout.EditValue = "1 page/week"
            Me.cmbLayout.Location = New System.Drawing.Point(92, 67)
            Me.cmbLayout.Name = "cmbLayout"
            Me.cmbLayout.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbLayout.Properties.Items.AddRange(New Object() {"1 page/week", "2 pages/week"})
            Me.cmbLayout.Size = New System.Drawing.Size(110, 20)
            Me.cmbLayout.StyleController = layoutControlSettings
            Me.cmbLayout.TabIndex = 5
            AddHandler Me.cmbLayout.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbLayout_SelectedIndexChanged)
            ' 
            ' spinResourceCount
            ' 
            spinResourceCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinResourceCount.Location = New System.Drawing.Point(92, 43)
            spinResourceCount.Name = "spinResourceCount"
            spinResourceCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinResourceCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            spinResourceCount.Properties.IsFloatValue = False
            spinResourceCount.Properties.Mask.EditMask = "N00"
            spinResourceCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            spinResourceCount.Size = New System.Drawing.Size(110, 20)
            spinResourceCount.StyleController = layoutControlSettings
            spinResourceCount.TabIndex = 42
            ' 
            ' edtEnd
            ' 
            edtEnd.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtEnd.Location = New System.Drawing.Point(92, 115)
            edtEnd.Name = "edtEnd"
            edtEnd.Properties.AccessibleName = "End date:"
            edtEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtEnd.Size = New System.Drawing.Size(110, 20)
            edtEnd.StyleController = layoutControlSettings
            edtEnd.TabIndex = 47
            ' 
            ' edtStart
            ' 
            edtStart.EditValue = New DateTime(2005, 9, 5, 0, 0, 0, 0)
            edtStart.Location = New System.Drawing.Point(92, 91)
            edtStart.Name = "edtStart"
            edtStart.Properties.AccessibleName = "Start date:"
            edtStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            edtStart.Size = New System.Drawing.Size(110, 20)
            edtStart.StyleController = layoutControlSettings
            edtStart.TabIndex = 46
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = spinResourceCount
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(199, 24)
            layoutControlItem2.Text = "Resource Count:"
            layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = Me.cmbLayout
            layoutControlItem3.Location = New System.Drawing.Point(0, 60)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(199, 24)
            layoutControlItem3.Text = "Layout:"
            layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = edtStart
            layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(199, 24)
            layoutControlItem4.Text = "Start Date:"
            layoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = edtEnd
            layoutControlItem5.Location = New System.Drawing.Point(0, 108)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(199, 24)
            layoutControlItem5.Text = "End Date:"
            layoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
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
            CType((Me.cmbLayout.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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
            RemoveHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            RemoveHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            RemoveHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
        End Sub

        Protected Friend Overridable Sub SubscribeEvents()
            AddHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            AddHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
            AddHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
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

        Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            resourceCount = CInt(spinResourceCount.Value)
            UpdateActiveReport()
        End Sub

        Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtStart.EditValue = EndDate.AddDays(-1)
            printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub

        Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            pagesPerWeek = cmbLayout.SelectedIndex + 1
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
