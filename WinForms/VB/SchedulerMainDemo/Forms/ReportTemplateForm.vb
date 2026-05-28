Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler.Design
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Reporting.UI

Namespace DevExpress.XtraScheduler.Demos.Reporting

    Public Class ReportTemplateForm
        Inherits XtraForm

#Region "inner classes"
        Public Class DirectionModeItem

            Private _text As String

            Private _directionMode As DirectionMode

            Public ReadOnly Property DirectionMode As DirectionMode
                Get
                    Return _directionMode
                End Get
            End Property

            Public ReadOnly Property Text As String
                Get
                    Return _text
                End Get
            End Property

            Public Sub New(ByVal directionMode As DirectionMode, ByVal text As String)
                _directionMode = directionMode
                _text = text
            End Sub
        End Class

        Public Class ViewModeItem

            Private _viewMode As ImageViewMode

            Private _text As String

            Public ReadOnly Property ViewMode As ImageViewMode
                Get
                    Return _viewMode
                End Get
            End Property

            Public ReadOnly Property Text As String
                Get
                    Return _text
                End Get
            End Property

            Public Sub New(ByVal viewMode As ImageViewMode, ByVal text As String)
                _viewMode = viewMode
                _text = text
            End Sub
        End Class

        Public Class ImageAlignItem

            Private _text As String

            Private _alignment As String

            Public ReadOnly Property Alignment As String
                Get
                    Return _alignment
                End Get
            End Property

            Public ReadOnly Property Text As String
                Get
                    Return _text
                End Get
            End Property

            Public Sub New(ByVal alignment As String, ByVal text As String)
                _alignment = alignment
                _text = text
            End Sub
        End Class

        Private Class MyPrintControl
            Inherits PrintControl

            Private ps As PrintingSystem

            Public Sub New()
                SetControlVisibility(New Control() {hScrollBar, sidePanel}, False)
                ps = New PrintingSystem()
                PrintingSystem = ps
                fMinZoom = 0.00001F
            End Sub

            Private Sub SetControlVisibility(ByVal controls As Control(), ByVal visible As Boolean)
                For Each control As Control In controls
                    control.Visible = visible
                Next
            End Sub

            Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
                MyBase.OnHandleCreated(e)
                CreateDocument()
                ViewWholePage()
            End Sub

            Private Sub CreateDocument()
                ps.Begin()
                ps.Graph.Modifier = BrickModifier.Detail
                Dim brick As EmptyBrick = New EmptyBrick()
                brick.Rect = New RectangleF(0, 0, 100, 100)
                ps.Graph.DrawBrick(brick)
                ps.End()
            End Sub

            Public Sub UpdateWatermark(ByVal watermark As Watermark)
                ps.Watermark.CopyFrom(watermark)
                ps.Watermark.PageRange = ""
                Invalidate(True)
            End Sub

            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing Then
                    ps.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub
        End Class

#End Region
#Region "Fields"
        Private xtraTabControl As XtraTab.XtraTabControl

        Private tpFormat As XtraTab.XtraTabPage

        Private tpResources As XtraTab.XtraTabPage

        Private labelControl1 As LabelControl

        Protected cbResourcesKind As ImageComboBoxEdit

        Protected lblResourcesKind As LabelControl

        Protected chkPrintCustomCollection As CheckEdit

        Protected grpCustomCollection As GroupControl

        Protected lblAvailableResource As LabelControl

        Protected lblCustomResources As LabelControl

        Protected lbResources As ListBoxControl

        Protected btnToCustomCollection As SimpleButton

        Protected btnAllToCustomCollection As SimpleButton

        Protected btnAllFromCustomCollection As SimpleButton

        Protected btnFromCustomCollection As SimpleButton

        Protected btnMoveUp As SimpleButton

        Protected btnMoveDown As SimpleButton

        Protected lbCustomResources As ListBoxControl

        Private panelControl1 As PanelControl

        Private pc As MyPrintControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private btnClose As SimpleButton

        Private lbPageRangeComment As LabelControl

        Private labelControl2 As LabelControl

        Private cbReportFile As ComboBoxEdit

        Protected edtEnd As DateEdit

        Protected edtStart As DateEdit

        Protected lblEnd As LabelControl

        Protected lblStart As LabelControl

        Private btnPreview As SimpleButton

        Private report As XtraSchedulerReport

        Private previewReport As XtraSchedulerReport

        Private _printAdapter As SchedulerControlPrintAdapter

        Private reportFileName As String = String.Empty

        Private btnEdit As SimpleButton

        Private _printResources As ResourceBaseCollection = New ResourceBaseCollection()

#End Region
#Region "Properties"
        Public ReadOnly Property PrintAdapter As SchedulerControlPrintAdapter
            Get
                Return _printAdapter
            End Get
        End Property

        Public ReadOnly Property PrintResources As ResourceBaseCollection
            Get
                Return _printResources
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

        Private ReadOnly Property ReportTemplateDirectoryInfo As DirectoryInfo
            Get
                Return New DirectoryInfo(DemoUtils.GetFolderRelativePath("SchedulerReportTemplates"))
            End Get
        End Property

#End Region
        Public Sub New(ByVal printAdapter As SchedulerControlPrintAdapter)
            _printAdapter = printAdapter
            InitializeComponent()
            edtStart.DateTime = TutorialConstants.Today.AddDays(-2)
            edtEnd.DateTime = TutorialConstants.Today.AddDays(7)
            btnPreview.Enabled = False
            btnEdit.Enabled = False
            SubscribeIntervalControlsEvents()
            PopulateResourceKindItems()
            PopulateReportTemplates()
            PopulateAvailableResources()
            UpdateControlsVisibility()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
                If _printAdapter IsNot Nothing Then UnsubscribePrintAdapterEvents(_printAdapter)
                If report IsNot Nothing Then
                    DisposeReport(report)
                    report = Nothing
                End If

                If pc IsNot Nothing Then
                    pc.Dispose()
                    pc = Nothing
                End If

                If previewReport IsNot Nothing Then
                    DisposeReport(previewReport)
                    previewReport = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub DisposeReport(ByVal report As XtraSchedulerReport)
            UnsubscribePrintAdapterEvents(report.SchedulerAdapter)
            report.Dispose()
        End Sub

#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportTemplateForm))
            btnPreview = New SimpleButton()
            lbPageRangeComment = New LabelControl()
            btnClose = New SimpleButton()
            xtraTabControl = New XtraTab.XtraTabControl()
            tpFormat = New XtraTab.XtraTabPage()
            edtEnd = New DateEdit()
            edtStart = New DateEdit()
            lblEnd = New LabelControl()
            lblStart = New LabelControl()
            panelControl1 = New PanelControl()
            pc = New MyPrintControl()
            tpResources = New XtraTab.XtraTabPage()
            cbResourcesKind = New ImageComboBoxEdit()
            lblResourcesKind = New LabelControl()
            chkPrintCustomCollection = New CheckEdit()
            grpCustomCollection = New GroupControl()
            lblAvailableResource = New LabelControl()
            lblCustomResources = New LabelControl()
            lbResources = New ListBoxControl()
            btnToCustomCollection = New SimpleButton()
            btnAllToCustomCollection = New SimpleButton()
            btnAllFromCustomCollection = New SimpleButton()
            btnFromCustomCollection = New SimpleButton()
            btnMoveUp = New SimpleButton()
            btnMoveDown = New SimpleButton()
            lbCustomResources = New ListBoxControl()
            labelControl1 = New LabelControl()
            labelControl2 = New LabelControl()
            cbReportFile = New ComboBoxEdit()
            btnEdit = New SimpleButton()
            CType(xtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            xtraTabControl.SuspendLayout()
            tpFormat.SuspendLayout()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            panelControl1.SuspendLayout()
            tpResources.SuspendLayout()
            CType(cbResourcesKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(chkPrintCustomCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(grpCustomCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            grpCustomCollection.SuspendLayout()
            CType(lbResources, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lbCustomResources, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cbReportFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnPreview
            ' 
            resources.ApplyResources(btnPreview, "btnPreview")
            btnPreview.Name = "btnPreview"
            AddHandler btnPreview.Click, New EventHandler(AddressOf btnPreview_Click)
            ' 
            ' lbPageRangeComment
            ' 
            resources.ApplyResources(lbPageRangeComment, "lbPageRangeComment")
            lbPageRangeComment.Name = "lbPageRangeComment"
            ' 
            ' btnClose
            ' 
            btnClose.DialogResult = DialogResult.OK
            resources.ApplyResources(btnClose, "btnClose")
            btnClose.Name = "btnClose"
            ' 
            ' xtraTabControl
            ' 
            resources.ApplyResources(xtraTabControl, "xtraTabControl")
            xtraTabControl.Name = "xtraTabControl"
            xtraTabControl.SelectedTabPage = tpFormat
            xtraTabControl.TabPages.AddRange(New XtraTab.XtraTabPage() {tpFormat, tpResources})
            ' 
            ' tpFormat
            ' 
            tpFormat.Controls.Add(edtEnd)
            tpFormat.Controls.Add(edtStart)
            tpFormat.Controls.Add(lblEnd)
            tpFormat.Controls.Add(lblStart)
            tpFormat.Controls.Add(panelControl1)
            tpFormat.Name = "tpFormat"
            resources.ApplyResources(tpFormat, "tpFormat")
            ' 
            ' edtEnd
            ' 
            resources.ApplyResources(edtEnd, "edtEnd")
            edtEnd.Name = "edtEnd"
            edtEnd.Properties.AccessibleName = resources.GetString("edtEnd.Properties.AccessibleName")
            edtEnd.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtEnd.Properties.Buttons"), XtraEditors.Controls.ButtonPredefines))})
            edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            ' 
            ' edtStart
            ' 
            resources.ApplyResources(edtStart, "edtStart")
            edtStart.Name = "edtStart"
            edtStart.Properties.AccessibleName = resources.GetString("edtStart.Properties.AccessibleName")
            edtStart.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtStart.Properties.Buttons"), XtraEditors.Controls.ButtonPredefines))})
            edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            ' 
            ' lblEnd
            ' 
            resources.ApplyResources(lblEnd, "lblEnd")
            lblEnd.Name = "lblEnd"
            ' 
            ' lblStart
            ' 
            resources.ApplyResources(lblStart, "lblStart")
            lblStart.Name = "lblStart"
            ' 
            ' panelControl1
            ' 
            panelControl1.BorderStyle = XtraEditors.Controls.BorderStyles.Simple
            panelControl1.Controls.Add(pc)
            resources.ApplyResources(panelControl1, "panelControl1")
            panelControl1.Name = "panelControl1"
            ' 
            ' pc
            ' 
            resources.ApplyResources(pc, "pc")
            pc.HorizontalScrollBarVisibility = ViewInfo.ScrollBarVisibility.Hidden
            pc.Name = "pc"
            pc.ShowPageMargins = False
            pc.TabStop = False
            pc.VerticalScrollBarVisibility = ViewInfo.ScrollBarVisibility.Hidden
            pc.Zoom = 0.2310606F
            ' 
            ' tpResources
            ' 
            tpResources.Controls.Add(cbResourcesKind)
            tpResources.Controls.Add(lblResourcesKind)
            tpResources.Controls.Add(chkPrintCustomCollection)
            tpResources.Controls.Add(grpCustomCollection)
            tpResources.Name = "tpResources"
            resources.ApplyResources(tpResources, "tpResources")
            ' 
            ' cbResourcesKind
            ' 
            resources.ApplyResources(cbResourcesKind, "cbResourcesKind")
            cbResourcesKind.Name = "cbResourcesKind"
            cbResourcesKind.Properties.AccessibleName = resources.GetString("cbResourcesKind.Properties.AccessibleName")
            cbResourcesKind.Properties.AccessibleRole = AccessibleRole.ComboBox
            cbResourcesKind.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(CType(resources.GetObject("cbResourcesKind.Properties.Buttons"), XtraEditors.Controls.ButtonPredefines))})
            ' 
            ' lblResourcesKind
            ' 
            resources.ApplyResources(lblResourcesKind, "lblResourcesKind")
            lblResourcesKind.Name = "lblResourcesKind"
            ' 
            ' chkPrintCustomCollection
            ' 
            resources.ApplyResources(chkPrintCustomCollection, "chkPrintCustomCollection")
            chkPrintCustomCollection.Name = "chkPrintCustomCollection"
            chkPrintCustomCollection.Properties.AutoWidth = True
            chkPrintCustomCollection.Properties.Caption = resources.GetString("chkPrintCustomCollection.Properties.Caption")
            AddHandler chkPrintCustomCollection.CheckedChanged, New EventHandler(AddressOf chkPrintCustomCollection_CheckedChanged)
            ' 
            ' grpCustomCollection
            ' 
            grpCustomCollection.AccessibleRole = AccessibleRole.Grouping
            grpCustomCollection.Controls.Add(lblAvailableResource)
            grpCustomCollection.Controls.Add(lblCustomResources)
            grpCustomCollection.Controls.Add(lbResources)
            grpCustomCollection.Controls.Add(btnToCustomCollection)
            grpCustomCollection.Controls.Add(btnAllToCustomCollection)
            grpCustomCollection.Controls.Add(btnAllFromCustomCollection)
            grpCustomCollection.Controls.Add(btnFromCustomCollection)
            grpCustomCollection.Controls.Add(btnMoveUp)
            grpCustomCollection.Controls.Add(btnMoveDown)
            grpCustomCollection.Controls.Add(lbCustomResources)
            resources.ApplyResources(grpCustomCollection, "grpCustomCollection")
            grpCustomCollection.Name = "grpCustomCollection"
            ' 
            ' lblAvailableResource
            ' 
            resources.ApplyResources(lblAvailableResource, "lblAvailableResource")
            lblAvailableResource.Name = "lblAvailableResource"
            ' 
            ' lblCustomResources
            ' 
            resources.ApplyResources(lblCustomResources, "lblCustomResources")
            lblCustomResources.Name = "lblCustomResources"
            ' 
            ' lbResources
            ' 
            resources.ApplyResources(lbResources, "lbResources")
            lbResources.AccessibleRole = AccessibleRole.List
            lbResources.Name = "lbResources"
            lbResources.SelectionMode = SelectionMode.MultiExtended
            ' 
            ' btnToCustomCollection
            ' 
            resources.ApplyResources(btnToCustomCollection, "btnToCustomCollection")
            btnToCustomCollection.Name = "btnToCustomCollection"
            AddHandler btnToCustomCollection.Click, New EventHandler(AddressOf btnToCustomCollection_Click)
            ' 
            ' btnAllToCustomCollection
            ' 
            resources.ApplyResources(btnAllToCustomCollection, "btnAllToCustomCollection")
            btnAllToCustomCollection.Name = "btnAllToCustomCollection"
            AddHandler btnAllToCustomCollection.Click, New EventHandler(AddressOf btnAllToCustomCollection_Click)
            ' 
            ' btnAllFromCustomCollection
            ' 
            resources.ApplyResources(btnAllFromCustomCollection, "btnAllFromCustomCollection")
            btnAllFromCustomCollection.Name = "btnAllFromCustomCollection"
            AddHandler btnAllFromCustomCollection.Click, New EventHandler(AddressOf btnAllFromCustomCollection_Click)
            ' 
            ' btnFromCustomCollection
            ' 
            resources.ApplyResources(btnFromCustomCollection, "btnFromCustomCollection")
            btnFromCustomCollection.Name = "btnFromCustomCollection"
            AddHandler btnFromCustomCollection.Click, New EventHandler(AddressOf btnFromCustomCollection_Click)
            ' 
            ' btnMoveUp
            ' 
            resources.ApplyResources(btnMoveUp, "btnMoveUp")
            btnMoveUp.Name = "btnMoveUp"
            AddHandler btnMoveUp.Click, New EventHandler(AddressOf btnMoveUp_Click)
            ' 
            ' btnMoveDown
            ' 
            resources.ApplyResources(btnMoveDown, "btnMoveDown")
            btnMoveDown.Name = "btnMoveDown"
            AddHandler btnMoveDown.Click, New EventHandler(AddressOf btnMoveDown_Click)
            ' 
            ' lbCustomResources
            ' 
            resources.ApplyResources(lbCustomResources, "lbCustomResources")
            lbCustomResources.AccessibleRole = AccessibleRole.List
            lbCustomResources.Name = "lbCustomResources"
            lbCustomResources.SelectionMode = SelectionMode.MultiExtended
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(labelControl1, "labelControl1")
            labelControl1.LineVisible = True
            labelControl1.Name = "labelControl1"
            ' 
            ' labelControl2
            ' 
            resources.ApplyResources(labelControl2, "labelControl2")
            labelControl2.Name = "labelControl2"
            ' 
            ' cbReportFile
            ' 
            resources.ApplyResources(cbReportFile, "cbReportFile")
            cbReportFile.Name = "cbReportFile"
            cbReportFile.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(CType(resources.GetObject("cbReportFile.Properties.Buttons"), XtraEditors.Controls.ButtonPredefines)), New XtraEditors.Controls.EditorButton()})
            cbReportFile.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            AddHandler cbReportFile.Properties.ButtonClick, New XtraEditors.Controls.ButtonPressedEventHandler(AddressOf buttonEdit1_Properties_ButtonClick)
            AddHandler cbReportFile.SelectedIndexChanged, New EventHandler(AddressOf cbReportFile_SelectedIndexChanged)
            ' 
            ' btnEdit
            ' 
            resources.ApplyResources(btnEdit, "btnEdit")
            btnEdit.Name = "btnEdit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' ReportTemplateForm
            ' 
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(btnEdit)
            Me.Controls.Add(labelControl2)
            Me.Controls.Add(cbReportFile)
            Me.Controls.Add(labelControl1)
            Me.Controls.Add(btnPreview)
            Me.Controls.Add(xtraTabControl)
            Me.Controls.Add(btnClose)
            FormBorderStyle = FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "ReportTemplateForm"
            ShowInTaskbar = False
            CType(xtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            xtraTabControl.ResumeLayout(False)
            tpFormat.ResumeLayout(False)
            tpFormat.PerformLayout()
            CType(edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            panelControl1.ResumeLayout(False)
            tpResources.ResumeLayout(False)
            tpResources.PerformLayout()
            CType(cbResourcesKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(chkPrintCustomCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(grpCustomCollection, System.ComponentModel.ISupportInitialize).EndInit()
            grpCustomCollection.ResumeLayout(False)
            grpCustomCollection.PerformLayout()
            CType(lbResources, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lbCustomResources, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cbReportFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private Sub SubscribePrintAdapterEvents(ByVal adapter As SchedulerPrintAdapter)
            If adapter IsNot Nothing Then AddHandler adapter.ValidateResources, New ResourcesValidationEventHandler(AddressOf PrintAdapter_ValidateResources)
        End Sub

        Private Sub UnsubscribePrintAdapterEvents(ByVal adapter As SchedulerPrintAdapter)
            If adapter IsNot Nothing Then RemoveHandler adapter.ValidateResources, New ResourcesValidationEventHandler(AddressOf PrintAdapter_ValidateResources)
        End Sub

        Private Sub SubscribeIntervalControlsEvents()
            AddHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            AddHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
        End Sub

        Private Sub UnsubscribeIntervalControlsEvents()
            RemoveHandler edtStart.EditValueChanged, New EventHandler(AddressOf StartEditValueChanged)
            RemoveHandler edtEnd.EditValueChanged, New EventHandler(AddressOf EndEditValueChanged)
        End Sub

        Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeIntervalControlsEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtEnd.EditValue = StartDate
            SubscribeIntervalControlsEvents()
        End Sub

        Protected Friend Overridable Function IsValidInterval(ByVal start As Date, ByVal [end] As Date) As Boolean
            Return start <= [end]
        End Function

        Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeIntervalControlsEvents()
            If Not IsValidInterval(StartDate, EndDate) Then edtStart.EditValue = EndDate.AddDays(-1)
            SubscribeIntervalControlsEvents()
        End Sub

        Private Sub PrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs)
            e.Resources.Clear()
            e.Resources.AddRange(PrintResources)
        End Sub

        Private Sub PopulateResourceKindItems()
            cbResourcesKind.Properties.Items.Add(New ImageComboBoxItem() With {.Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_AllResources), .Value = ResourcesKind.All})
            cbResourcesKind.Properties.Items.Add(New ImageComboBoxItem() With {.Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_OnScreenResources), .Value = ResourcesKind.OnScreen})
            cbResourcesKind.SelectedIndex = 0
        End Sub

        Private Sub PopulateReportTemplates()
            Dim reportTemplates As FileInfo() = ReportTemplateDirectoryInfo.GetFiles("*.schrepx")
            cbReportFile.Properties.Buttons(0).Visible = reportTemplates.Length <> 0
            For Each reportFile As FileInfo In reportTemplates
                cbReportFile.Properties.Items.Add(New ReportTemplateInfo(reportFile.FullName))
            Next

            cbReportFile.SelectedIndex = 0
        End Sub

        Private Sub buttonEdit1_Properties_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Kind = ButtonPredefines.Ellipsis Then
                Dim dlg As OpenFileDialog = New OpenFileDialog()
                Try
                    dlg.CheckPathExists = True
                    dlg.Filter = "Report template files (*.schrepx)|*.schrepx|All files (*.*)|*.*"
                    dlg.InitialDirectory = ReportTemplateDirectoryInfo.FullName
                    Dim result As DialogResult = dlg.ShowDialog()
                    If result <> DialogResult.OK Then Return
                    UpdateReport(New ReportTemplateInfo(dlg.FileName))
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message, Application.ProductName)
                Finally
                    dlg.Dispose()
                End Try
            End If
        End Sub

        Private Sub UpdatePreview()
            If previewReport Is Nothing Then Return
            pc.PrintingSystem = previewReport.PrintingSystem
            previewReport.ReportPrintOptions.DetailCount = 1
            UpdateReport(previewReport)
        End Sub

        Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            UpdateReport(report)
            If report IsNot Nothing Then report.ShowPreview()
        End Sub

        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            UpdateReport(report)
            If report IsNot Nothing Then
                Call New SchedulerReportDesignTool(report).ShowRibbonDesignerDialog()
            End If
        End Sub

        Private Sub UpdateReport(ByVal report As XtraSchedulerReport)
            If report Is Nothing Then Return
            report.SchedulerAdapter.TimeInterval = New TimeInterval(StartDate, EndDate)
            UpdatePrintResources()
            report.PrintingSystem.ClearContent()
            report.CreateDocument(True)
        End Sub

        Private Sub UpdatePrintResources()
            PrintResources.Clear()
            Dim resources As ResourceBaseCollection = GetPrintResources()
            PrintResources.AddRange(resources)
        End Sub

        Private Function GetPrintResources() As ResourceBaseCollection
            If chkPrintCustomCollection.Checked Then Return GetCustomResources()
            Dim resourcesKind As ResourcesKind = CType(cbResourcesKind.EditValue, ResourcesKind)
            Select Case resourcesKind
                Case ResourcesKind.All
                    Return GetAvailableResources()
                Case ResourcesKind.OnScreen
                    Return GetOnScreenResources()
                Case Else
                    Return New ResourceBaseCollection()
            End Select
        End Function

        Private Function GetAvailableResources() As ResourceBaseCollection
            Return PrintAdapter.SchedulerControl.DataStorage.Resources.Items
        End Function

        Private Function GetOnScreenResources() As ResourceBaseCollection
            Return PrintAdapter.SchedulerControl.ActiveView.GetResources()
        End Function

        Private Function GetCustomResources() As ResourceBaseCollection
            Dim result As ResourceBaseCollection = New ResourceBaseCollection()
            Dim count As Integer = lbCustomResources.ItemCount
            For i As Integer = 0 To count - 1
                Dim objectWrapper As ObjectWrapper = CType(lbCustomResources.Items(i), ObjectWrapper)
                result.Add(CType(objectWrapper.Object, Resource))
            Next

            Return result
        End Function

        Private Sub CreateReports()
            CreateReport()
            CreatePreviewReport()
        End Sub

        Private Sub CreateReport()
            If report IsNot Nothing Then
                DisposeReport(report)
            End If

            report = CreateReportCore()
        End Sub

        Private Sub CreatePreviewReport()
            If previewReport IsNot Nothing Then
                DisposeReport(previewReport)
            End If

            previewReport = CreateReportCore()
        End Sub

        Private Function CreateReportCore() As XtraSchedulerReport
            Dim report As XtraSchedulerReport = New XtraSchedulerReport()
            report.LoadLayout(reportFileName)
            If report.SchedulerAdapter IsNot Nothing Then
                report.SchedulerAdapter.SetSourceObject(PrintAdapter.SchedulerControl)
            Else
                report.SchedulerAdapter = PrintAdapter
            End If

            report.SchedulerAdapter.EnableSmartSync = reportFileName.ToLower().Contains("trifold")
            SubscribePrintAdapterEvents(report.SchedulerAdapter)
            report.PrintColorSchema = DemoUtils.ReportPrintColorSchema
            Return report
        End Function

        Private Sub chkPrintCustomCollection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControlsVisibility()
        End Sub

        Private Sub UpdateControlsVisibility()
            Dim isCustomResources As Boolean = chkPrintCustomCollection.Checked
            lbCustomResources.Enabled = isCustomResources
            lbResources.Enabled = isCustomResources
            cbResourcesKind.Enabled = Not isCustomResources
            UpdateResourceButtonsVisibility(isCustomResources)
        End Sub

        Private Sub UpdateResourceButtonsVisibility(ByVal isCustomResources As Boolean)
            btnAllToCustomCollection.Enabled = isCustomResources AndAlso lbResources.ItemCount > 0
            btnToCustomCollection.Enabled = isCustomResources AndAlso lbResources.ItemCount > 0
            btnAllFromCustomCollection.Enabled = isCustomResources AndAlso lbCustomResources.ItemCount > 0
            btnFromCustomCollection.Enabled = isCustomResources AndAlso lbCustomResources.ItemCount > 0
            btnMoveDown.Enabled = isCustomResources
            btnMoveUp.Enabled = isCustomResources
        End Sub

        Private Sub PopulateAvailableResources()
            lbResources.Items.Clear()
            Dim resources As ResourceBaseCollection = GetAvailableResources()
            Dim count As Integer = resources.Count
            For i As Integer = 0 To count - 1
                lbResources.Items.Add(New ObjectWrapper(resources(i), resources(i).Caption))
            Next
        End Sub

        Private Sub btnAllToCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveAllItems(lbResources, lbCustomResources)
        End Sub

        Private Sub btnAllFromCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveAllItems(lbCustomResources, lbResources)
        End Sub

        Private Sub btnToCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveSelectedItems(lbResources, lbCustomResources)
        End Sub

        Private Sub btnFromCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveSelectedItems(lbCustomResources, lbResources)
        End Sub

        Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveSelectedItems(lbCustomResources, True)
        End Sub

        Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            MoveSelectedItems(lbCustomResources, False)
        End Sub

        Private Sub MoveAllItems(ByVal source As ListBoxControl, ByVal target As ListBoxControl)
            Dim count As Integer = source.ItemCount
            For i As Integer = 0 To count - 1
                target.Items.Add(source.Items(i))
            Next

            source.Items.Clear()
            UpdateResourceButtonsVisibility(True)
        End Sub

        Private Sub MoveSelectedItems(ByVal source As ListBoxControl, ByVal target As ListBoxControl)
            Dim selectedItems As List(Of Object) = New List(Of Object)()
            Dim count As Integer = source.SelectedItems.Count
            For i As Integer = 0 To count - 1
                Dim item As Object = source.SelectedItems(i)
                target.Items.Add(item)
                selectedItems.Add(item)
            Next

            For i As Integer = 0 To count - 1
                source.Items.Remove(selectedItems(i))
            Next

            UpdateResourceButtonsVisibility(True)
        End Sub

        Private Sub MoveSelectedItems(ByVal listBox As ListBoxControl, ByVal moveUp As Boolean)
            If Not CanMoveItems(listBox, moveUp) Then Return
            Dim selectedIndices As List(Of Integer) = GetSelectedIndixes(listBox)
            Dim selectedItems As List(Of Object) = GetSelectedItems(listBox)
            If moveUp Then
                MoveSelectedItemsUp(listBox, selectedIndices)
            Else
                MoveSelectedItemsDown(listBox, selectedIndices)
            End If

            UpdateSelection(listBox, selectedItems)
            UpdateResourceButtonsVisibility(True)
        End Sub

        Private Sub MoveSelectedItemsUp(ByVal listBox As ListBoxControl, ByVal selectedIndices As List(Of Integer))
            Dim count As Integer = selectedIndices.Count
            For i As Integer = 0 To count - 1
                Dim index As Integer = selectedIndices(i)
                Dim item As Object = listBox.Items(index)
                listBox.Items.RemoveAt(index)
                listBox.Items.Insert(index - 1, item)
            Next
        End Sub

        Private Sub MoveSelectedItemsDown(ByVal listBox As ListBoxControl, ByVal selectedIndices As List(Of Integer))
            Dim count As Integer = selectedIndices.Count
            For i As Integer = count - 1 To 0 Step -1
                Dim index As Integer = selectedIndices(i)
                Dim item As Object = listBox.Items(index)
                listBox.Items.RemoveAt(index)
                listBox.Items.Insert(index + 1, item)
            Next
        End Sub

        Private Sub UpdateSelection(ByVal listBox As ListBoxControl, ByVal selectedItems As List(Of Object))
            Dim count As Integer = listBox.Items.Count
            For i As Integer = 0 To count - 1
                Dim selected As Boolean = selectedItems.Contains(listBox.Items(i))
                listBox.SetSelected(i, selected)
            Next
        End Sub

        Private Function GetSelectedIndixes(ByVal listBox As ListBoxControl) As List(Of Integer)
            Dim result As List(Of Integer) = New List(Of Integer)()
            Dim count As Integer = listBox.SelectedIndices.Count
            For i As Integer = 0 To count - 1
                result.Add(listBox.SelectedIndices(i))
            Next

            Return result
        End Function

        Private Function GetSelectedItems(ByVal listBox As ListBoxControl) As List(Of Object)
            Dim result As List(Of Object) = New List(Of Object)()
            Dim count As Integer = listBox.SelectedItems.Count
            For i As Integer = 0 To count - 1
                result.Add(listBox.SelectedItems(i))
            Next

            Return result
        End Function

        Private Function CanMoveItems(ByVal listBox As ListBoxControl, ByVal moveUp As Boolean) As Boolean
            Dim indices As BaseListBoxControl.SelectedIndexCollection = listBox.SelectedIndices
            Dim selectedIndexesCount As Integer = indices.Count
            If selectedIndexesCount = 0 Then Return False
            Return If(moveUp, indices(0) > 0, indices(selectedIndexesCount - 1) < listBox.ItemCount - 1)
        End Function

        Private Sub cbReportFile_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim templateInfo As ReportTemplateInfo = TryCast(cbReportFile.SelectedItem, ReportTemplateInfo)
                If templateInfo Is Nothing Then Return
                UpdateReport(templateInfo)
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, Application.ProductName)
            End Try
        End Sub

        Private Sub UpdateReport(ByVal templateInfo As ReportTemplateInfo)
            reportFileName = templateInfo.FullName
            cbReportFile.Text = templateInfo.Name
            cbReportFile.ToolTip = reportFileName
            CreateReports()
            UpdatePreview()
            btnPreview.Enabled = Not Equals(reportFileName, String.Empty)
            btnEdit.Enabled = Not Equals(reportFileName, String.Empty)
        End Sub
    End Class

    Public Enum ResourcesKind
        All
        OnScreen
    End Enum

    Public Class ReportTemplateInfo

        Private ReadOnly _name As String

        Private ReadOnly _fullName As String

        Public ReadOnly Property Name As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property FullName As String
            Get
                Return _fullName
            End Get
        End Property

        Public Sub New(ByVal fullName As String)
            _fullName = fullName
            _name = Path.GetFileNameWithoutExtension(fullName)
        End Sub

        Public Overrides Function ToString() As String
            Return _name
        End Function
    End Class
End Namespace
