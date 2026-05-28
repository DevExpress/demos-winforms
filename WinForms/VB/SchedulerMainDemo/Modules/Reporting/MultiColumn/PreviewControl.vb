Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private spinColumnCount As XtraEditors.SpinEdit

        Private rgrpColumnArrangement As XtraEditors.RadioGroup

        Private visibleWeekDayColumnCount As Integer = 0

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private columnArrangement As ColumnArrangementMode = ColumnArrangementMode.Ascending

        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
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
            visibleWeekDayColumnCount = Report.VisibleWeekDayColumnCount
            columnArrangement = Report.ColumnArrangement
            spinColumnCount.Value = visibleWeekDayColumnCount
            rgrpColumnArrangement.EditValue = columnArrangement
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Report.VisibleWeekDayColumnCount = visibleWeekDayColumnCount
            Report.ColumnArrangement = columnArrangement
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            spinColumnCount = New XtraEditors.SpinEdit()
            rgrpColumnArrangement = New XtraEditors.RadioGroup()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
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
            CType(spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            layoutControlSettings.Controls.Add(rgrpColumnArrangement)
            layoutControlSettings.Controls.Add(spinColumnCount)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(spinColumnCount, 0)
            layoutControlSettings.Controls.SetChildIndex(rgrpColumnArrangement, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlGroup1, emptySpaceItem3})
            layoutControlGroupSettings.Name = "Root"
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
            emptySpaceItem2.Location = New System.Drawing.Point(0, 154)
            emptySpaceItem2.Size = New System.Drawing.Size(205, 188)
            ' 
            ' spinColumnCount
            ' 
            spinColumnCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinColumnCount.Location = New System.Drawing.Point(136, 43)
            spinColumnCount.Name = "spinColumnCount"
            spinColumnCount.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            spinColumnCount.Properties.IsFloatValue = False
            spinColumnCount.Properties.Mask.EditMask = "N00"
            spinColumnCount.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
            spinColumnCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            spinColumnCount.Size = New System.Drawing.Size(72, 20)
            spinColumnCount.StyleController = layoutControlSettings
            spinColumnCount.TabIndex = 3
            AddHandler spinColumnCount.EditValueChanged, New EventHandler(AddressOf spinColumnPerPage_EditValueChanged)
            ' 
            ' rgrpColumnArrangement
            ' 
            rgrpColumnArrangement.Location = New System.Drawing.Point(13, 101)
            rgrpColumnArrangement.MaximumSize = New System.Drawing.Size(0, 50)
            rgrpColumnArrangement.MinimumSize = New System.Drawing.Size(0, 50)
            rgrpColumnArrangement.Name = "rgrpColumnArrangement"
            rgrpColumnArrangement.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            rgrpColumnArrangement.Properties.Appearance.Options.UseBackColor = True
            rgrpColumnArrangement.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            rgrpColumnArrangement.Properties.Columns = 1
            rgrpColumnArrangement.Properties.Items.AddRange(New XtraEditors.Controls.RadioGroupItem() {New XtraEditors.Controls.RadioGroupItem(ColumnArrangementMode.Ascending, "Ascending"), New XtraEditors.Controls.RadioGroupItem(ColumnArrangementMode.Descending, "Descending")})
            rgrpColumnArrangement.Size = New System.Drawing.Size(189, 50)
            rgrpColumnArrangement.StyleController = layoutControlSettings
            rgrpColumnArrangement.TabIndex = 7
            AddHandler rgrpColumnArrangement.SelectedIndexChanged, New EventHandler(AddressOf rgrpColumnMode_SelectedIndexChanged)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = spinColumnCount
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(205, 24)
            layoutControlItem2.Text = "WeekDays Column Count:"
            layoutControlItem2.TextSize = New System.Drawing.Size(125, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = rgrpColumnArrangement
            layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(193, 54)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem4})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 70)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(205, 84)
            layoutControlGroup1.Text = "Column Arrangement"
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 60)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(205, 10)
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
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
            CType(spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub spinColumnPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            visibleWeekDayColumnCount = Convert.ToInt32(spinColumnCount.Value)
            UpdateActiveReport()
        End Sub

        Private Sub rgrpColumnMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            columnArrangement = CType(rgrpColumnArrangement.EditValue, ColumnArrangementMode)
            UpdateActiveReport()
        End Sub

        Private Sub lbResourceCount_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub labelControl1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
