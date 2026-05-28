Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private btnViewAppearance As XtraEditors.SimpleButton

        Private btnResourceColorSchemas As XtraEditors.SimpleButton

        Private cmbAppointmentSchema As XtraEditors.ImageComboBoxEdit

        Private cmbReportSchema As XtraEditors.ImageComboBoxEdit

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

        Private layoutControlItem5 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

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

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(2))
        End Sub

        Private Sub InitializeControlValues()
            cmbReportSchema.EditValue = Report.ReportColorSchema
            cmbAppointmentSchema.EditValue = Report.AppointmentsColorSchema
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Report.ReportColorSchema = CType(cmbReportSchema.EditValue, PrintColorSchema)
            Report.AppointmentsColorSchema = CType(cmbAppointmentSchema.EditValue, PrintColorSchema)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            btnViewAppearance = New XtraEditors.SimpleButton()
            btnResourceColorSchemas = New XtraEditors.SimpleButton()
            cmbAppointmentSchema = New XtraEditors.ImageComboBoxEdit()
            cmbReportSchema = New XtraEditors.ImageComboBoxEdit()
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
            CType(cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Location = New System.Drawing.Point(0, 34)
            printControl.Size = New System.Drawing.Size(453, 362)
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(203, 22)
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
            navigationPaneSettings.Location = New System.Drawing.Point(453, 34)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.RegularSize = New System.Drawing.Size(247, 362)
            navigationPaneSettings.Size = New System.Drawing.Size(247, 362)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(217, 318)
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
            layoutControlSettings.Controls.Add(cmbAppointmentSchema)
            layoutControlSettings.Controls.Add(btnResourceColorSchemas)
            layoutControlSettings.Controls.Add(cmbReportSchema)
            layoutControlSettings.Controls.Add(btnViewAppearance)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Size = New System.Drawing.Size(217, 318)
            layoutControlSettings.Controls.SetChildIndex(btnViewAppearance, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbReportSchema, 0)
            layoutControlSettings.Controls.SetChildIndex(btnResourceColorSchemas, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbAppointmentSchema, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup1, layoutControlItem3, layoutControlItem2, emptySpaceItem3})
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Size = New System.Drawing.Size(217, 318)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(207, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(207, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 176)
            emptySpaceItem2.Size = New System.Drawing.Size(207, 132)
            ' 
            ' btnViewAppearance
            ' 
            btnViewAppearance.ImageIndex = 2
            btnViewAppearance.Location = New System.Drawing.Point(7, 69)
            btnViewAppearance.Name = "btnViewAppearance"
            btnViewAppearance.Size = New System.Drawing.Size(203, 22)
            btnViewAppearance.StyleController = layoutControlSettings
            btnViewAppearance.TabIndex = 0
            btnViewAppearance.Text = "&Edit View Appearance..."
            AddHandler btnViewAppearance.Click, New EventHandler(AddressOf btnEditAppearance_Click)
            ' 
            ' btnResourceColorSchemas
            ' 
            btnResourceColorSchemas.ImageIndex = 2
            btnResourceColorSchemas.Location = New System.Drawing.Point(7, 43)
            btnResourceColorSchemas.Name = "btnResourceColorSchemas"
            btnResourceColorSchemas.Size = New System.Drawing.Size(203, 22)
            btnResourceColorSchemas.StyleController = layoutControlSettings
            btnResourceColorSchemas.TabIndex = 1
            btnResourceColorSchemas.Text = "&Edit Resource Color Schemas..."
            AddHandler btnResourceColorSchemas.Click, New EventHandler(AddressOf btnResourceColorSchemas_Click)
            ' 
            ' cmbAppointmentSchema
            ' 
            cmbAppointmentSchema.EditValue = PrintColorSchema.Default
            cmbAppointmentSchema.Location = New System.Drawing.Point(83, 153)
            cmbAppointmentSchema.Name = "cmbAppointmentSchema"
            cmbAppointmentSchema.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbAppointmentSchema.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("Default", PrintColorSchema.Default, -1), New XtraEditors.Controls.ImageComboBoxItem("FullColor", PrintColorSchema.FullColor, -1), New XtraEditors.Controls.ImageComboBoxItem("GrayScale", PrintColorSchema.GrayScale, -1), New XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", PrintColorSchema.BlackAndWhite, -1)})
            cmbAppointmentSchema.Size = New System.Drawing.Size(121, 20)
            cmbAppointmentSchema.StyleController = layoutControlSettings
            cmbAppointmentSchema.TabIndex = 1
            AddHandler cmbAppointmentSchema.SelectedIndexChanged, New EventHandler(AddressOf cmbAppointmentSchema_SelectedIndexChanged)
            ' 
            ' cmbReportSchema
            ' 
            cmbReportSchema.EditValue = PrintColorSchema.Default
            cmbReportSchema.Location = New System.Drawing.Point(83, 129)
            cmbReportSchema.Name = "cmbReportSchema"
            cmbReportSchema.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbReportSchema.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("Default", PrintColorSchema.Default, -1), New XtraEditors.Controls.ImageComboBoxItem("FullColor", PrintColorSchema.FullColor, -1), New XtraEditors.Controls.ImageComboBoxItem("GrayScale", PrintColorSchema.GrayScale, -1), New XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", PrintColorSchema.BlackAndWhite, -1)})
            cmbReportSchema.Size = New System.Drawing.Size(121, 20)
            cmbReportSchema.StyleController = layoutControlSettings
            cmbReportSchema.TabIndex = 0
            AddHandler cmbReportSchema.SelectedIndexChanged, New EventHandler(AddressOf cmbReportSchema_SelectedIndexChanged)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = btnViewAppearance
            layoutControlItem2.Location = New System.Drawing.Point(0, 62)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(207, 26)
            layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = btnResourceColorSchemas
            layoutControlItem3.Location = New System.Drawing.Point(0, 36)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(207, 26)
            layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = cmbReportSchema
            layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(195, 24)
            layoutControlItem4.Text = "Report"
            layoutControlItem4.TextSize = New System.Drawing.Size(66, 13)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = cmbAppointmentSchema
            layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(195, 24)
            layoutControlItem5.Text = "Appointments"
            layoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem5, layoutControlItem4})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 98)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(207, 78)
            layoutControlGroup1.Text = "Print Color Schema"
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 88)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(207, 10)
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
            CType(cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub btnEditAppearance_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler Report.Appearances.Changed, New EventHandler(AddressOf Appearances_Changed)
            Try
                Dim frm As AppearancesEditForm = New AppearancesEditForm(Report.Appearances, FindForm())
                frm.ShowDialog()
            Finally
                RemoveHandler Report.Appearances.Changed, New EventHandler(AddressOf Appearances_Changed)
            End Try
        End Sub

        Private Sub Appearances_Changed(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub btnResourceColorSchemas_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler StoragePrintAdapter.ResourceColorsChanged, New EventHandler(AddressOf StoragePrintAdapter_ResourceColorsChanged)
            Try
                Dim frm As ColorSchemasEditForm = New ColorSchemasEditForm(StoragePrintAdapter.ResourceColorSchemas, FindForm())
                frm.ShowDialog()
            Finally
                RemoveHandler StoragePrintAdapter.ResourceColorsChanged, New EventHandler(AddressOf StoragePrintAdapter_ResourceColorsChanged)
            End Try
        End Sub

        Private Sub StoragePrintAdapter_ResourceColorsChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Public Sub ResourceColorSchemasChanged(ByVal sender As Object, ByVal e As CollectionChangedEventArgs(Of SchedulerColorSchema))
            UpdateActiveReport()
        End Sub

        Private Sub cmbAppointmentSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub cmbReportSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
