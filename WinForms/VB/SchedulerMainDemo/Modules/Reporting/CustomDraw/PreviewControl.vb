Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private allowCustomDrawDayHeader As Boolean

        Private allowCustomDrawResourceHeader As Boolean

        Private allowCustomDrawAllDayArea As Boolean

        Private allowCustomDrawTimeCell As Boolean

        Private allowCustomDrawTimeRuler As Boolean

        Private allowCustomDrawAppointment As Boolean

        Private chkTimeRuler As CheckEdit

        Private chkAppointmentBackground As CheckEdit

        Private chkAppointment As CheckEdit

        Private chkDayViewAllDayArea As CheckEdit

        Private chkTimeCell As CheckEdit

        Private chkDayHeader As CheckEdit

        Private chkResourceHeader As CheckEdit

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

        Private layoutControlItem8 As XtraLayout.LayoutControlItem

        Private allowCustomDrawAppointmentBackground As Boolean

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
            allowCustomDrawDayHeader = chkDayHeader.Checked
            allowCustomDrawResourceHeader = chkResourceHeader.Checked
            allowCustomDrawAllDayArea = chkDayViewAllDayArea.Checked
            allowCustomDrawTimeCell = chkTimeCell.Checked
            allowCustomDrawTimeRuler = chkTimeRuler.Checked
            allowCustomDrawAppointment = chkAppointment.Checked
            allowCustomDrawAppointmentBackground = chkAppointmentBackground.Checked
        End Sub

        Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            MyBase.UpdateReportProperties(otherReport)
            Report.AllowCustomDrawAllDayArea = allowCustomDrawAllDayArea
            Report.AllowCustomDrawAppointment = allowCustomDrawAppointment
            Report.AllowCustomDrawAppointmentBackground = allowCustomDrawAppointmentBackground
            Report.AllowCustomDrawDayHeader = allowCustomDrawDayHeader
            Report.AllowCustomDrawResourceHeader = allowCustomDrawResourceHeader
            Report.AllowCustomDrawTimeCell = allowCustomDrawTimeCell
            Report.AllowCustomDrawTimeRuler = allowCustomDrawTimeRuler
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            chkTimeRuler = New CheckEdit()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            btnEdit = New SimpleButton()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            chkDayViewAllDayArea = New CheckEdit()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            chkDayHeader = New CheckEdit()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            chkResourceHeader = New CheckEdit()
            layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            chkTimeCell = New CheckEdit()
            layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            chkAppointment = New CheckEdit()
            layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            chkAppointmentBackground = New CheckEdit()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControlSettings.SuspendLayout()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkAppointment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            navigationPaneSettings.SuspendLayout()
            navigationPageSettings.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Size = New System.Drawing.Size(496, 396)
            ' 
            ' chkTimeRuler
            ' 
            chkTimeRuler.EditValue = True
            chkTimeRuler.Location = New System.Drawing.Point(7, 43)
            chkTimeRuler.Name = "chkTimeRuler"
            chkTimeRuler.Properties.Caption = "Time Ruler"
            chkTimeRuler.Size = New System.Drawing.Size(163, 19)
            chkTimeRuler.StyleController = layoutControlSettings
            chkTimeRuler.TabIndex = 101
            AddHandler chkTimeRuler.CheckedChanged, New EventHandler(AddressOf chkTimeRuler_CheckedChanged)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(chkAppointmentBackground)
            layoutControlSettings.Controls.Add(chkTimeRuler)
            layoutControlSettings.Controls.Add(chkAppointment)
            layoutControlSettings.Controls.Add(chkTimeCell)
            layoutControlSettings.Controls.Add(chkDayViewAllDayArea)
            layoutControlSettings.Controls.Add(chkResourceHeader)
            layoutControlSettings.Controls.Add(chkDayHeader)
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.Size = New System.Drawing.Size(177, 352)
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(163, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem2, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8, emptySpaceItem1})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Name = "layoutControlGroup1"
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(177, 352)
            layoutControlGroupSettings.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(167, 26)
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
            emptySpaceItem1.Size = New System.Drawing.Size(167, 10)
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Location = New System.Drawing.Point(0, 197)
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.Size = New System.Drawing.Size(167, 145)
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = chkTimeRuler
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(167, 23)
            layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = chkDayViewAllDayArea
            layoutControlItem3.Location = New System.Drawing.Point(0, 59)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(167, 23)
            layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem3.TextVisible = False
            ' 
            ' chkDayViewAllDayArea
            ' 
            chkDayViewAllDayArea.EditValue = True
            chkDayViewAllDayArea.Location = New System.Drawing.Point(7, 66)
            chkDayViewAllDayArea.Name = "chkDayViewAllDayArea"
            chkDayViewAllDayArea.Properties.Caption = "All-Day Area"
            chkDayViewAllDayArea.Size = New System.Drawing.Size(163, 19)
            chkDayViewAllDayArea.StyleController = layoutControlSettings
            chkDayViewAllDayArea.TabIndex = 98
            AddHandler chkDayViewAllDayArea.CheckedChanged, New EventHandler(AddressOf chkDayViewAllDayArea_CheckedChanged)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = chkDayHeader
            layoutControlItem4.Location = New System.Drawing.Point(0, 82)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(167, 23)
            layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem4.TextVisible = False
            ' 
            ' chkDayHeader
            ' 
            chkDayHeader.EditValue = True
            chkDayHeader.Location = New System.Drawing.Point(7, 89)
            chkDayHeader.Name = "chkDayHeader"
            chkDayHeader.Properties.Caption = "Day Header"
            chkDayHeader.Size = New System.Drawing.Size(163, 19)
            chkDayHeader.StyleController = layoutControlSettings
            chkDayHeader.TabIndex = 96
            AddHandler chkDayHeader.CheckedChanged, New EventHandler(AddressOf chkDayHeader_CheckedChanged)
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = chkResourceHeader
            layoutControlItem5.Location = New System.Drawing.Point(0, 105)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Size = New System.Drawing.Size(167, 23)
            layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem5.TextVisible = False
            ' 
            ' chkResourceHeader
            ' 
            chkResourceHeader.EditValue = True
            chkResourceHeader.Location = New System.Drawing.Point(7, 112)
            chkResourceHeader.Name = "chkResourceHeader"
            chkResourceHeader.Properties.Caption = "Resource Header"
            chkResourceHeader.Size = New System.Drawing.Size(163, 19)
            chkResourceHeader.StyleController = layoutControlSettings
            chkResourceHeader.TabIndex = 95
            AddHandler chkResourceHeader.CheckedChanged, New EventHandler(AddressOf chkResourceHeader_CheckedChanged)
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = chkTimeCell
            layoutControlItem6.Location = New System.Drawing.Point(0, 128)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Size = New System.Drawing.Size(167, 23)
            layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem6.TextVisible = False
            ' 
            ' chkTimeCell
            ' 
            chkTimeCell.EditValue = True
            chkTimeCell.Location = New System.Drawing.Point(7, 135)
            chkTimeCell.Name = "chkTimeCell"
            chkTimeCell.Properties.Caption = "Time Cell"
            chkTimeCell.Size = New System.Drawing.Size(163, 19)
            chkTimeCell.StyleController = layoutControlSettings
            chkTimeCell.TabIndex = 97
            AddHandler chkTimeCell.CheckedChanged, New EventHandler(AddressOf chkTimeCell_CheckedChanged)
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = chkAppointment
            layoutControlItem7.Location = New System.Drawing.Point(0, 151)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Size = New System.Drawing.Size(167, 23)
            layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem7.TextVisible = False
            ' 
            ' chkAppointment
            ' 
            chkAppointment.EditValue = True
            chkAppointment.Location = New System.Drawing.Point(7, 158)
            chkAppointment.Name = "chkAppointment"
            chkAppointment.Properties.Caption = "Appointment"
            chkAppointment.Size = New System.Drawing.Size(163, 19)
            chkAppointment.StyleController = layoutControlSettings
            chkAppointment.TabIndex = 99
            AddHandler chkAppointment.CheckedChanged, New EventHandler(AddressOf chkAppointment_CheckedChanged)
            ' 
            ' layoutControlItem8
            ' 
            layoutControlItem8.Control = chkAppointmentBackground
            layoutControlItem8.Location = New System.Drawing.Point(0, 174)
            layoutControlItem8.Name = "layoutControlItem8"
            layoutControlItem8.Size = New System.Drawing.Size(167, 23)
            layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem8.TextVisible = False
            ' 
            ' chkAppointmentBackground
            ' 
            chkAppointmentBackground.EditValue = True
            chkAppointmentBackground.Location = New System.Drawing.Point(7, 181)
            chkAppointmentBackground.Name = "chkAppointmentBackground"
            chkAppointmentBackground.Properties.Caption = "Appointment Background"
            chkAppointmentBackground.Size = New System.Drawing.Size(163, 19)
            chkAppointmentBackground.StyleController = layoutControlSettings
            chkAppointmentBackground.TabIndex = 100
            AddHandler chkAppointmentBackground.CheckedChanged, New EventHandler(AddressOf chkAppointmentBackground_CheckedChanged)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(496, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.RegularSize = New System.Drawing.Size(204, 396)
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.Size = New System.Drawing.Size(204, 396)
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(177, 352)
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(navigationPaneSettings)
            Name = "PreviewControl"
            Me.Controls.SetChildIndex(navigationPaneSettings, 0)
            Me.Controls.SetChildIndex(printControl, 0)
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControlSettings.ResumeLayout(False)
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkAppointment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub chkDayHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawDayHeader = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkResourceHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawResourceHeader = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkTimeCell_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawTimeCell = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkDayViewAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawAllDayArea = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawAppointment = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkAppointmentBackground_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawAppointmentBackground = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub

        Private Sub chkTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            allowCustomDrawTimeRuler = CType(sender, CheckEdit).Checked
            UpdateActiveReport()
        End Sub
    End Class
End Namespace
