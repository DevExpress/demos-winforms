Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services.Implementation
Imports System.Globalization

Namespace DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private cmbVertAptEnd As ComboBoxEdit

        Private cmbVertAptStart As ComboBoxEdit

        Private cmbHorzAptEnd As ComboBoxEdit

        Private cmbHorzAptStart As ComboBoxEdit

        Private cmbHeaderCaptions As ComboBoxEdit

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As SimpleButton

        Private layoutControlItem6 As XtraLayout.LayoutControlItem

        Private layoutControlItem5 As XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem7 As XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

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

        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(21))
        End Sub

        Private Sub InitializeControlValues()
            PopulateFormatCombo(cmbHorzAptStart)
            PopulateFormatCombo(cmbHorzAptEnd)
            PopulateFormatCombo(cmbVertAptStart)
            PopulateFormatCombo(cmbVertAptEnd)
            PopulateFormatCombo(cmbHeaderCaptions)
        End Sub

        Private Sub PopulateFormatCombo(ByVal comboBox As ComboBoxEdit)
            comboBox.Properties.Items.Clear()
            comboBox.Properties.Items.Add("Default")
            comboBox.Properties.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns())
            comboBox.SelectedIndex = 0
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            UpdateFormatServices()
        End Sub

        Public Sub UpdateFormatServices()
            StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
            Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService(cmbHeaderCaptions.Text)
            StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)
            StoragePrintAdapter.RemoveService(GetType(IAppointmentFormatStringService))
            Dim customAptFormatService As CustomAppointmentFormatStringService = New CustomAppointmentFormatStringService()
            customAptFormatService.HorizontalAppointmentStart = cmbHorzAptStart.Text
            customAptFormatService.HorizontalAppointmentEnd = cmbHorzAptEnd.Text
            customAptFormatService.VerticalAppointmentStart = cmbVertAptStart.Text
            customAptFormatService.VerticalAppointmentEnd = cmbVertAptEnd.Text
            StoragePrintAdapter.AddService(GetType(IAppointmentFormatStringService), customAptFormatService)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            cmbHorzAptEnd = New ComboBoxEdit()
            cmbHorzAptStart = New ComboBoxEdit()
            cmbVertAptEnd = New ComboBoxEdit()
            cmbVertAptStart = New ComboBoxEdit()
            cmbHeaderCaptions = New ComboBoxEdit()
            btnEdit = New SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
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
            CType(cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(416, 396)
            ' 
            ' btnEdit
            ' 
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left, Windows.Forms.AnchorStyles)
            btnEdit.Size = New System.Drawing.Size(240, 22)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(416, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.RegularSize = New System.Drawing.Size(284, 396)
            navigationPaneSettings.Size = New System.Drawing.Size(284, 396)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(254, 352)
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
            layoutControlSettings.Controls.Add(cmbHeaderCaptions)
            layoutControlSettings.Controls.Add(cmbHorzAptEnd)
            layoutControlSettings.Controls.Add(cmbVertAptEnd)
            layoutControlSettings.Controls.Add(cmbVertAptStart)
            layoutControlSettings.Controls.Add(cmbHorzAptStart)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Size = New System.Drawing.Size(254, 352)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbHorzAptStart, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbVertAptStart, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbVertAptEnd, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbHorzAptEnd, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbHeaderCaptions, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup1, layoutControlGroup2, layoutControlGroup3, emptySpaceItem3, emptySpaceItem4})
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Size = New System.Drawing.Size(254, 352)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(244, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(244, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 266)
            emptySpaceItem2.Size = New System.Drawing.Size(244, 76)
            ' 
            ' cmbHorzAptEnd
            ' 
            cmbHorzAptEnd.Location = New System.Drawing.Point(108, 91)
            cmbHorzAptEnd.Name = "cmbHorzAptEnd"
            cmbHorzAptEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
            cmbHorzAptEnd.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbHorzAptEnd.Size = New System.Drawing.Size(133, 20)
            cmbHorzAptEnd.StyleController = layoutControlSettings
            cmbHorzAptEnd.TabIndex = 53
            AddHandler cmbHorzAptEnd.SelectedIndexChanged, New EventHandler(AddressOf cmbHorzAptStart_SelectedIndexChanged)
            ' 
            ' cmbHorzAptStart
            ' 
            cmbHorzAptStart.Location = New System.Drawing.Point(108, 67)
            cmbHorzAptStart.Name = "cmbHorzAptStart"
            cmbHorzAptStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(Windows.Forms.Keys.None), serializableAppearanceObject5, "", Nothing, Nothing, True)})
            cmbHorzAptStart.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbHorzAptStart.Size = New System.Drawing.Size(133, 20)
            cmbHorzAptStart.StyleController = layoutControlSettings
            cmbHorzAptStart.TabIndex = 51
            AddHandler cmbHorzAptStart.SelectedIndexChanged, New EventHandler(AddressOf cmbHorzAptStart_SelectedIndexChanged)
            ' 
            ' cmbVertAptEnd
            ' 
            cmbVertAptEnd.Location = New System.Drawing.Point(108, 179)
            cmbVertAptEnd.Name = "cmbVertAptEnd"
            cmbVertAptEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
            cmbVertAptEnd.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbVertAptEnd.Size = New System.Drawing.Size(133, 20)
            cmbVertAptEnd.StyleController = layoutControlSettings
            cmbVertAptEnd.TabIndex = 53
            AddHandler cmbVertAptEnd.SelectedIndexChanged, New EventHandler(AddressOf cmbHorzAptStart_SelectedIndexChanged)
            ' 
            ' cmbVertAptStart
            ' 
            cmbVertAptStart.Location = New System.Drawing.Point(108, 155)
            cmbVertAptStart.Name = "cmbVertAptStart"
            cmbVertAptStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
            cmbVertAptStart.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbVertAptStart.Size = New System.Drawing.Size(133, 20)
            cmbVertAptStart.StyleController = layoutControlSettings
            cmbVertAptStart.TabIndex = 51
            AddHandler cmbVertAptStart.SelectedIndexChanged, New EventHandler(AddressOf cmbHorzAptStart_SelectedIndexChanged)
            ' 
            ' cmbHeaderCaptions
            ' 
            cmbHeaderCaptions.Location = New System.Drawing.Point(108, 243)
            cmbHeaderCaptions.Name = "cmbHeaderCaptions"
            cmbHeaderCaptions.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
            cmbHeaderCaptions.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbHeaderCaptions.Size = New System.Drawing.Size(133, 20)
            cmbHeaderCaptions.StyleController = layoutControlSettings
            cmbHeaderCaptions.TabIndex = 53
            AddHandler cmbHeaderCaptions.SelectedIndexChanged, New EventHandler(AddressOf cmbHorzAptStart_SelectedIndexChanged)
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = cmbHorzAptStart
            layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(232, 24)
            layoutControlItem6.Text = "Start Date Format:"
            layoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = cmbHorzAptEnd
            layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(232, 24)
            layoutControlItem5.Text = "End Date Format:"
            layoutControlItem5.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem6, layoutControlItem5})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(244, 78)
            layoutControlGroup1.Text = "Horizontal Appointment"
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = cmbVertAptStart
            layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(232, 24)
            layoutControlItem2.Text = "Start Date Format:"
            layoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = cmbVertAptEnd
            layoutControlItem7.Location = New System.Drawing.Point(0, 24)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Size = New System.Drawing.Size(232, 24)
            layoutControlItem7.Text = "End Date Format:"
            layoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem7})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 124)
            layoutControlGroup2.Name = "layoutControlGroup2"
            layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup2.Size = New System.Drawing.Size(244, 78)
            layoutControlGroup2.Text = "Vertical Appointment"
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = cmbHeaderCaptions
            layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(232, 24)
            layoutControlItem3.Text = "Format:"
            layoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlGroup3
            ' 
            layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem3})
            layoutControlGroup3.Location = New System.Drawing.Point(0, 212)
            layoutControlGroup3.Name = "layoutControlGroup3"
            layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup3.Size = New System.Drawing.Size(244, 54)
            layoutControlGroup3.Text = "Day Headers"
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 114)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(244, 10)
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem4
            ' 
            emptySpaceItem4.AllowHotTrack = False
            emptySpaceItem4.Location = New System.Drawing.Point(0, 202)
            emptySpaceItem4.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem4.Name = "emptySpaceItem4"
            emptySpaceItem4.Size = New System.Drawing.Size(244, 10)
            emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' PreviewControl
            ' 
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
            CType(cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private Sub cmbHorzAptStart_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

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
    End Class

    Public Class CustomHeaderCaptionService
        Inherits HeaderCaptionServiceWrapper

        Private format As String

        Public Sub New(ByVal format As String)
            MyBase.New(New HeaderCaptionService())
            Me.format = format
        End Sub

        Protected Overridable Function CreateFormat(ByVal format As String) As String
            If Equals(format, "Default") Then Return String.Empty
            Return String.Format("{{0:{0}}}", format)
        End Function

        Public Overrides Function GetDayColumnHeaderCaption(ByVal header As DayHeader) As String
            Return CreateFormat(format)
        End Function
    End Class

    Public Class CustomAppointmentFormatStringService
        Inherits AppointmentFormatStringServiceWrapper

        Private _horizontalAppointmentStart As String

        Private _horizontalAppointmentEnd As String

        Private _verticalAppointmentStart As String

        Private _verticalAppointmentEnd As String

        Public Sub New()
            MyBase.New(New AppointmentFormatStringService())
        End Sub

        Public Property HorizontalAppointmentStart As String
            Get
                Return _horizontalAppointmentStart
            End Get

            Set(ByVal value As String)
                _horizontalAppointmentStart = value
            End Set
        End Property

        Public Property HorizontalAppointmentEnd As String
            Get
                Return _horizontalAppointmentEnd
            End Get

            Set(ByVal value As String)
                _horizontalAppointmentEnd = value
            End Set
        End Property

        Public Property VerticalAppointmentStart As String
            Get
                Return _verticalAppointmentStart
            End Get

            Set(ByVal value As String)
                _verticalAppointmentStart = value
            End Set
        End Property

        Public Property VerticalAppointmentEnd As String
            Get
                Return _verticalAppointmentEnd
            End Get

            Set(ByVal value As String)
                _verticalAppointmentEnd = value
            End Set
        End Property

        Protected Overridable Function CreateFormat(ByVal format As String) As String
            If Equals(format, "Default") Then Return String.Empty
            Return String.Format("{{0:{0}}} ", format)
        End Function

        Public Overrides Function GetHorizontalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return CreateFormat(_horizontalAppointmentStart)
        End Function

        Public Overrides Function GetHorizontalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return CreateFormat(_horizontalAppointmentEnd)
        End Function

        Public Overrides Function GetVerticalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return CreateFormat(_verticalAppointmentStart)
        End Function

        Public Overrides Function GetVerticalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return CreateFormat(_verticalAppointmentEnd)
        End Function

        Public Overrides Function GetContinueItemStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return MyBase.GetContinueItemStartFormat(aptViewInfo)
        End Function

        Public Overrides Function GetContinueItemEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
            Return MyBase.GetContinueItemEndFormat(aptViewInfo)
        End Function
    End Class
End Namespace
