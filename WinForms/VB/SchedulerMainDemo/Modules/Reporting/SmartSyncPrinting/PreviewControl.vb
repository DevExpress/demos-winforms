Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private rgrpGroupType As XtraEditors.RadioGroup

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private groupType As SchedulerGroupType

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
        End Sub

        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
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

        Protected Overrides Sub FillReportSourceData()
            DemoUtils.FillReportsStorageData(SchedulerStorage)
        End Sub

        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date.AddDays(17), TimeSpan.FromDays(4))
        End Sub

        Private Sub InitializeControlValues()
            groupType = StoragePrintAdapter.SmartSyncOptions.GroupType
            rgrpGroupType.EditValue = groupType
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            StoragePrintAdapter.SmartSyncOptions.GroupType = groupType
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            rgrpGroupType = New XtraEditors.RadioGroup()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
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
            CType(rgrpGroupType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(441, 396)
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
            btnEdit.Size = New System.Drawing.Size(215, 22)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(441, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.RegularSize = New System.Drawing.Size(259, 396)
            navigationPaneSettings.Size = New System.Drawing.Size(259, 396)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(229, 352)
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
            layoutControlSettings.Controls.Add(rgrpGroupType)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Size = New System.Drawing.Size(229, 352)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(rgrpGroupType, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup1})
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Size = New System.Drawing.Size(229, 352)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(219, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(219, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 123)
            emptySpaceItem2.Size = New System.Drawing.Size(219, 219)
            ' 
            ' fStoragePrintAdapter
            ' 
            fStoragePrintAdapter.EnableSmartSync = True
            ' 
            ' rgrpGroupType
            ' 
            rgrpGroupType.Location = New System.Drawing.Point(13, 67)
            rgrpGroupType.MaximumSize = New System.Drawing.Size(0, 70)
            rgrpGroupType.MinimumSize = New System.Drawing.Size(0, 70)
            rgrpGroupType.Name = "rgrpGroupType"
            rgrpGroupType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            rgrpGroupType.Properties.Appearance.Options.UseBackColor = True
            rgrpGroupType.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            rgrpGroupType.Properties.Columns = 1
            rgrpGroupType.Properties.Items.AddRange(New XtraEditors.Controls.RadioGroupItem() {New XtraEditors.Controls.RadioGroupItem(SchedulerGroupType.None, "None"), New XtraEditors.Controls.RadioGroupItem(SchedulerGroupType.Date, "Date"), New XtraEditors.Controls.RadioGroupItem(SchedulerGroupType.Resource, "Resource")})
            rgrpGroupType.Size = New System.Drawing.Size(203, 70)
            rgrpGroupType.StyleController = layoutControlSettings
            rgrpGroupType.TabIndex = 5
            AddHandler rgrpGroupType.SelectedIndexChanged, New EventHandler(AddressOf rgrpGroupType_SelectedIndexChanged)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = rgrpGroupType
            layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(207, 57)
            layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem3})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(219, 87)
            layoutControlGroup1.Text = "Group Type"
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
            CType(rgrpGroupType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub rgrpGroupType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            groupType = CType(rgrpGroupType.EditValue, SchedulerGroupType)
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
