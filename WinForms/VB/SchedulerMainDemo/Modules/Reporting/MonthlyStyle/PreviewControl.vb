Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private spinResourceCount As XtraEditors.SpinEdit

        Protected chkCompressWeekend As XtraEditors.CheckEdit

        Protected chkPrintExactlyOneMonth As XtraEditors.CheckEdit

        Protected chkDontPrintWeekends As XtraEditors.CheckEdit

        Private cmbLayout As XtraEditors.ComboBoxEdit

        Private initialized As Boolean

        Private dontPrintWeekends As Boolean

        Private compressWeekend As Boolean

        Private printExactlyOneMonth As Boolean

        Private visibleResourceCount As Integer = 0

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

        Private pageLayout As Integer = 1

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
            SubscribeEvents()
        End Sub

        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            spinResourceCount = New XtraEditors.SpinEdit()
            Me.cmbLayout = New XtraEditors.ComboBoxEdit()
            chkCompressWeekend = New XtraEditors.CheckEdit()
            chkPrintExactlyOneMonth = New XtraEditors.CheckEdit()
            chkDontPrintWeekends = New XtraEditors.CheckEdit()
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
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cmbLayout.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(201, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 5
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
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Controls.Add(chkPrintExactlyOneMonth)
            layoutControlSettings.Controls.Add(chkCompressWeekend)
            layoutControlSettings.Controls.Add(chkDontPrintWeekends)
            layoutControlSettings.Controls.Add(Me.cmbLayout)
            layoutControlSettings.Controls.Add(spinResourceCount)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Controls.SetChildIndex(spinResourceCount, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
            layoutControlSettings.Controls.SetChildIndex(chkDontPrintWeekends, 0)
            layoutControlSettings.Controls.SetChildIndex(chkCompressWeekend, 0)
            layoutControlSettings.Controls.SetChildIndex(chkPrintExactlyOneMonth, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem6, layoutControlItem5})
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
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 153)
            emptySpaceItem2.Size = New System.Drawing.Size(205, 189)
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
            spinResourceCount.Size = New System.Drawing.Size(116, 20)
            spinResourceCount.StyleController = layoutControlSettings
            spinResourceCount.TabIndex = 42
            ' 
            ' cmbLayout
            ' 
            Me.cmbLayout.EditValue = "1 page/week"
            Me.cmbLayout.Location = New System.Drawing.Point(92, 67)
            Me.cmbLayout.Name = "cmbLayout"
            Me.cmbLayout.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbLayout.Properties.Items.AddRange(New Object() {"1 page/week", "2 pages/week"})
            Me.cmbLayout.Size = New System.Drawing.Size(116, 20)
            Me.cmbLayout.StyleController = layoutControlSettings
            Me.cmbLayout.TabIndex = 45
            ' 
            ' chkCompressWeekend
            ' 
            chkCompressWeekend.Location = New System.Drawing.Point(7, 91)
            chkCompressWeekend.Name = "chkCompressWeekend"
            chkCompressWeekend.Properties.AutoWidth = True
            chkCompressWeekend.Properties.Caption = "Compress Weekend"
            chkCompressWeekend.Size = New System.Drawing.Size(117, 19)
            chkCompressWeekend.StyleController = layoutControlSettings
            chkCompressWeekend.TabIndex = 48
            ' 
            ' chkPrintExactlyOneMonth
            ' 
            chkPrintExactlyOneMonth.Location = New System.Drawing.Point(7, 137)
            chkPrintExactlyOneMonth.Name = "chkPrintExactlyOneMonth"
            chkPrintExactlyOneMonth.Properties.AutoWidth = True
            chkPrintExactlyOneMonth.Properties.Caption = "Print Exactly One Month Per Page"
            chkPrintExactlyOneMonth.Size = New System.Drawing.Size(184, 19)
            chkPrintExactlyOneMonth.StyleController = layoutControlSettings
            chkPrintExactlyOneMonth.TabIndex = 47
            ' 
            ' chkDontPrintWeekends
            ' 
            chkDontPrintWeekends.Location = New System.Drawing.Point(7, 114)
            chkDontPrintWeekends.Name = "chkDontPrintWeekends"
            chkDontPrintWeekends.Properties.AutoWidth = True
            chkDontPrintWeekends.Properties.Caption = "Don't Print &Weekends"
            chkDontPrintWeekends.Size = New System.Drawing.Size(125, 19)
            chkDontPrintWeekends.StyleController = layoutControlSettings
            chkDontPrintWeekends.TabIndex = 46
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = spinResourceCount
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(205, 24)
            layoutControlItem2.Text = "Resource Count:"
            layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = Me.cmbLayout
            layoutControlItem3.Location = New System.Drawing.Point(0, 60)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(205, 24)
            layoutControlItem3.Text = "Layout:"
            layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = chkDontPrintWeekends
            layoutControlItem4.Location = New System.Drawing.Point(0, 107)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(205, 23)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = chkCompressWeekend
            layoutControlItem5.Location = New System.Drawing.Point(0, 84)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(205, 23)
            layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = chkPrintExactlyOneMonth
            layoutControlItem6.Location = New System.Drawing.Point(0, 130)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(205, 23)
            layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem6.TextVisible = False
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
            layoutControlSettings.PerformLayout()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cmbLayout.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' 
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

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub SubscribeEvents()
            AddHandler spinResourceCount.EditValueChanged, New EventHandler(AddressOf spinResourceCount_EditValueChanged)
            AddHandler chkPrintExactlyOneMonth.CheckedChanged, New EventHandler(AddressOf chkPrintExactlyOneMonth_CheckedChanged)
            AddHandler chkDontPrintWeekends.CheckedChanged, New EventHandler(AddressOf chkDontPrintWeekends_CheckedChanged)
            AddHandler chkCompressWeekend.CheckedChanged, New EventHandler(AddressOf chkCompressWeekend_CheckedChanged)
            AddHandler Me.cmbLayout.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbLayout_SelectedIndexChanged)
        End Sub

        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function

        Private Sub InitializeControlValues()
            dontPrintWeekends = Report.DontPrintWeekends
            compressWeekend = Report.CompressWeekend
            visibleResourceCount = Report.VisibleResourceCount
            printExactlyOneMonth = Report.PrintExactlyOneMonth
            Me.pageLayout = Report.ColumnCount - 1
            Me.cmbLayout.SelectedIndex = Me.pageLayout
            spinResourceCount.Value = visibleResourceCount
            spinResourceCount.Properties.MinValue = 1
            spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount
            chkCompressWeekend.Checked = compressWeekend
            chkDontPrintWeekends.Checked = dontPrintWeekends
            chkPrintExactlyOneMonth.Checked = printExactlyOneMonth
            initialized = True
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Report.DontPrintWeekends = dontPrintWeekends
            Report.VisibleResourceCount = visibleResourceCount
            Report.ColumnCount = Me.cmbLayout.SelectedIndex + 1
            Report.CompressWeekend = compressWeekend
            Report.DontPrintWeekends = dontPrintWeekends
            Report.PrintExactlyOneMonth = printExactlyOneMonth
        End Sub

        Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.pageLayout = Me.cmbLayout.SelectedIndex + 1
            UpdateActiveReport()
        End Sub

        Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not initialized Then Return
            visibleResourceCount = Convert.ToInt32(spinResourceCount.Value)
            UpdateActiveReport()
        End Sub

        Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not initialized Then Return
            compressWeekend = chkCompressWeekend.Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkDontPrintWeekends_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not initialized Then Return
            dontPrintWeekends = chkDontPrintWeekends.Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkPrintExactlyOneMonth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not initialized Then Return
            printExactlyOneMonth = chkPrintExactlyOneMonth.Checked
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
