Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        'bool showReminder;
        'bool showReccurence;
        Private allowInitAptText As Boolean

        Private allowInitAptImages As Boolean

        Private chkAptImages As CheckEdit

        Private chkAptText As CheckEdit

        Private chkShowRecurrence As CheckEdit

        Private cbStatus As ImageComboBoxEdit

        Private cbTimeDisplayType As ImageComboBoxEdit

        Private chkShowReminder As CheckEdit

        Private chkStartTimeVisibility As CheckEdit

        Private chkEndTimeVisibility As CheckEdit

        Private showStartTime As Boolean

        Private showEndTime As Boolean

        Private statusDisplayType As AppointmentStatusDisplayType

        Private timeDisplayType As AppointmentTimeDisplayType

        Private showBell As Boolean

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As SimpleButton

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private layoutControlItem5 As XtraLayout.LayoutControlItem

        Private layoutControlItem6 As XtraLayout.LayoutControlItem

        Private layoutControlItem7 As XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup

        Private layoutControlItem8 As XtraLayout.LayoutControlItem

        Private layoutControlItem9 As XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem

        Private showRecurrence As Boolean

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
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(7))
        End Sub

        Private Sub InitializeControlValues()
            allowInitAptText = chkAptText.Checked
            allowInitAptImages = chkAptImages.Checked
            cbTimeDisplayType.SelectedIndex = 0
            cbStatus.SelectedIndex = 0
            showStartTime = chkStartTimeVisibility.Checked
            showEndTime = chkEndTimeVisibility.Checked
            showRecurrence = chkShowRecurrence.Checked
            showBell = chkShowReminder.Checked
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Report.AllowInitAppointmentText = allowInitAptText
            Report.AllowInitAppointmentImages = allowInitAptImages
            Report.ShowStartTime = showStartTime
            Report.ShowEndTime = showEndTime
            Report.StatusDisplayType = statusDisplayType
            Report.TimeDisplayType = timeDisplayType
            Report.ShowBell = showBell
            Report.ShowRecurrence = showRecurrence
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            chkAptImages = New CheckEdit()
            chkAptText = New CheckEdit()
            chkShowRecurrence = New CheckEdit()
            cbStatus = New ImageComboBoxEdit()
            cbTimeDisplayType = New ImageComboBoxEdit()
            chkShowReminder = New CheckEdit()
            chkStartTimeVisibility = New CheckEdit()
            chkEndTimeVisibility = New CheckEdit()
            btnEdit = New SimpleButton()
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
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
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
            CType(chkAptImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkAptText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Location = New System.Drawing.Point(0, 27)
            printControl.Size = New System.Drawing.Size(487, 384)
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
            btnEdit.Size = New System.Drawing.Size(169, 22)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(487, 27)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.RegularSize = New System.Drawing.Size(213, 384)
            navigationPaneSettings.Size = New System.Drawing.Size(213, 384)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(183, 340)
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
            layoutControlSettings.Controls.Add(chkAptImages)
            layoutControlSettings.Controls.Add(chkAptText)
            layoutControlSettings.Controls.Add(chkShowRecurrence)
            layoutControlSettings.Controls.Add(chkShowReminder)
            layoutControlSettings.Controls.Add(cbStatus)
            layoutControlSettings.Controls.Add(cbTimeDisplayType)
            layoutControlSettings.Controls.Add(chkEndTimeVisibility)
            layoutControlSettings.Controls.Add(chkStartTimeVisibility)
            layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
            layoutControlSettings.Size = New System.Drawing.Size(183, 340)
            layoutControlSettings.Controls.SetChildIndex(chkStartTimeVisibility, 0)
            layoutControlSettings.Controls.SetChildIndex(chkEndTimeVisibility, 0)
            layoutControlSettings.Controls.SetChildIndex(cbTimeDisplayType, 0)
            layoutControlSettings.Controls.SetChildIndex(cbStatus, 0)
            layoutControlSettings.Controls.SetChildIndex(chkShowReminder, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(chkShowRecurrence, 0)
            layoutControlSettings.Controls.SetChildIndex(chkAptText, 0)
            layoutControlSettings.Controls.SetChildIndex(chkAptImages, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup2, layoutControlGroup1, emptySpaceItem3})
            layoutControlGroupSettings.Name = "Root"
            layoutControlGroupSettings.Size = New System.Drawing.Size(183, 340)
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            layoutControlItem1.Size = New System.Drawing.Size(173, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(173, 10)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 292)
            emptySpaceItem2.Size = New System.Drawing.Size(173, 38)
            ' 
            ' chkAptImages
            ' 
            chkAptImages.EditValue = True
            chkAptImages.Location = New System.Drawing.Point(13, 270)
            chkAptImages.Name = "chkAptImages"
            chkAptImages.Properties.Caption = "Custom Images"
            chkAptImages.Size = New System.Drawing.Size(157, 19)
            chkAptImages.StyleController = layoutControlSettings
            chkAptImages.TabIndex = 49
            AddHandler chkAptImages.CheckedChanged, New EventHandler(AddressOf chkAptImages_CheckedChanged)
            ' 
            ' chkAptText
            ' 
            chkAptText.EditValue = True
            chkAptText.Location = New System.Drawing.Point(13, 247)
            chkAptText.Name = "chkAptText"
            chkAptText.Properties.Caption = "Custom Text"
            chkAptText.Size = New System.Drawing.Size(157, 19)
            chkAptText.StyleController = layoutControlSettings
            chkAptText.TabIndex = 48
            AddHandler chkAptText.CheckedChanged, New EventHandler(AddressOf chkAptText_CheckedChanged)
            ' 
            ' chkShowRecurrence
            ' 
            chkShowRecurrence.EditValue = True
            chkShowRecurrence.Location = New System.Drawing.Point(13, 161)
            chkShowRecurrence.Name = "chkShowRecurrence"
            chkShowRecurrence.Properties.Caption = "Recurrence"
            chkShowRecurrence.Size = New System.Drawing.Size(157, 19)
            chkShowRecurrence.StyleController = layoutControlSettings
            chkShowRecurrence.TabIndex = 74
            AddHandler chkShowRecurrence.CheckedChanged, New EventHandler(AddressOf chkShowRecurrence_CheckedChanged)
            ' 
            ' cbStatus
            ' 
            cbStatus.EditValue = ""
            cbStatus.Location = New System.Drawing.Point(52, 67)
            cbStatus.Name = "cbStatus"
            cbStatus.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cbStatus.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("Never", AppointmentStatusDisplayType.Never, -1), New XtraEditors.Controls.ImageComboBoxItem("Time", AppointmentStatusDisplayType.Time, -1), New XtraEditors.Controls.ImageComboBoxItem("Bounds", AppointmentStatusDisplayType.Bounds, -1)})
            cbStatus.Size = New System.Drawing.Size(118, 20)
            cbStatus.StyleController = layoutControlSettings
            cbStatus.TabIndex = 73
            AddHandler cbStatus.SelectedIndexChanged, New EventHandler(AddressOf cbStatus_SelectedIndexChanged)
            ' 
            ' cbTimeDisplayType
            ' 
            cbTimeDisplayType.EditValue = ""
            cbTimeDisplayType.Location = New System.Drawing.Point(52, 91)
            cbTimeDisplayType.Name = "cbTimeDisplayType"
            cbTimeDisplayType.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cbTimeDisplayType.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("Auto", AppointmentTimeDisplayType.Auto, -1), New XtraEditors.Controls.ImageComboBoxItem("Clock", AppointmentTimeDisplayType.Clock, -1), New XtraEditors.Controls.ImageComboBoxItem("Text", AppointmentTimeDisplayType.Text, -1)})
            cbTimeDisplayType.Size = New System.Drawing.Size(118, 20)
            cbTimeDisplayType.StyleController = layoutControlSettings
            cbTimeDisplayType.TabIndex = 22
            AddHandler cbTimeDisplayType.SelectedIndexChanged, New EventHandler(AddressOf cbTimeDisplayType_SelectedIndexChanged)
            ' 
            ' chkShowReminder
            ' 
            chkShowReminder.EditValue = True
            chkShowReminder.Location = New System.Drawing.Point(13, 184)
            chkShowReminder.Name = "chkShowReminder"
            chkShowReminder.Properties.Caption = "Reminder"
            chkShowReminder.Size = New System.Drawing.Size(157, 19)
            chkShowReminder.StyleController = layoutControlSettings
            chkShowReminder.TabIndex = 13
            AddHandler chkShowReminder.CheckedChanged, New EventHandler(AddressOf chkShowReminder_CheckedChanged)
            ' 
            ' chkStartTimeVisibility
            ' 
            chkStartTimeVisibility.EditValue = True
            chkStartTimeVisibility.Location = New System.Drawing.Point(13, 115)
            chkStartTimeVisibility.Name = "chkStartTimeVisibility"
            chkStartTimeVisibility.Properties.Caption = "Start Time"
            chkStartTimeVisibility.Size = New System.Drawing.Size(157, 19)
            chkStartTimeVisibility.StyleController = layoutControlSettings
            chkStartTimeVisibility.TabIndex = 11
            AddHandler chkStartTimeVisibility.CheckedChanged, New EventHandler(AddressOf chkStartTimeVisibility_CheckedChanged)
            ' 
            ' chkEndTimeVisibility
            ' 
            chkEndTimeVisibility.EditValue = True
            chkEndTimeVisibility.Location = New System.Drawing.Point(13, 138)
            chkEndTimeVisibility.Name = "chkEndTimeVisibility"
            chkEndTimeVisibility.Properties.Caption = "End Time"
            chkEndTimeVisibility.Size = New System.Drawing.Size(157, 19)
            chkEndTimeVisibility.StyleController = layoutControlSettings
            chkEndTimeVisibility.TabIndex = 10
            AddHandler chkEndTimeVisibility.CheckedChanged, New EventHandler(AddressOf chkEndTimeVisibility_CheckedChanged)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = cbStatus
            layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(161, 24)
            layoutControlItem2.Text = "Status:"
            layoutControlItem2.TextSize = New System.Drawing.Size(35, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = cbTimeDisplayType
            layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(161, 24)
            layoutControlItem3.Text = "Time:"
            layoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = chkStartTimeVisibility
            layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(161, 23)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = chkEndTimeVisibility
            layoutControlItem5.Location = New System.Drawing.Point(0, 71)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(161, 23)
            layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = chkShowRecurrence
            layoutControlItem6.Location = New System.Drawing.Point(0, 94)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(161, 23)
            layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = chkShowReminder
            layoutControlItem7.Location = New System.Drawing.Point(0, 117)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Size = New System.Drawing.Size(161, 23)
            layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem2, layoutControlItem3})
            layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup1.Size = New System.Drawing.Size(173, 170)
            layoutControlGroup1.Text = "Appointment Display Options"
            ' 
            ' layoutControlItem8
            ' 
            layoutControlItem8.Control = chkAptText
            layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            layoutControlItem8.Name = "layoutControlItem8"
            layoutControlItem8.Size = New System.Drawing.Size(161, 23)
            layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            layoutControlItem9.Control = chkAptImages
            layoutControlItem9.Location = New System.Drawing.Point(0, 23)
            layoutControlItem9.Name = "layoutControlItem9"
            layoutControlItem9.Size = New System.Drawing.Size(161, 23)
            layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem8, layoutControlItem9})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 216)
            layoutControlGroup2.Name = "layoutControlGroup2"
            layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            layoutControlGroup2.Size = New System.Drawing.Size(173, 76)
            layoutControlGroup2.Text = "Customization"
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.AllowHotTrack = False
            emptySpaceItem3.Location = New System.Drawing.Point(0, 206)
            emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Size = New System.Drawing.Size(173, 10)
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Name = "PreviewControl"
            Size = New System.Drawing.Size(700, 411)
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
            CType(chkAptImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkAptText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub chkAptText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowInitAptText = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkAptImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowInitAptImages = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkStartTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showStartTime = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkEndTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showEndTime = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            statusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
            UpdateActiveReport()
        End Sub

        Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            timeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
            UpdateActiveReport()
        End Sub

        Private Sub chkShowRecurrence_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showRecurrence = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkShowReminder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            showBell = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
