Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraTab

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class SpreadsheetPreview
        Inherits UserControl

        Private ReadOnly pcCache As Dictionary(Of PrintControl, PrintableComponentLinkBase)

        Private _previewZoom As SpreadhsheetPreviewZoom = SpreadhsheetPreviewZoom.Default

        Public Sub New()
            InitializeComponent()
            pcCache = New Dictionary(Of PrintControl, PrintableComponentLinkBase)()
            xtraTabControl1.TabPages.Clear()
            UpdatePreview()
        End Sub

        <DefaultValue(False)>
        Public Property CanShowBorders As Boolean

        Public Property Workbook As IWorkbook

        Public Function ShouldSerializeWorkbook() As Boolean
            Return Workbook IsNot Nothing
        End Function

        Public Sub ResetWorkbook()
            Workbook = Nothing
        End Sub

        <DefaultValue(SpreadhsheetPreviewZoom.Default)>
        Public Property PreviewZoom As SpreadhsheetPreviewZoom
            Get
                Return _previewZoom
            End Get

            Set(ByVal value As SpreadhsheetPreviewZoom)
                If _previewZoom = value Then Return
                _previewZoom = value
                UpdatePreview()
            End Set
        End Property

        Public Sub UpdatePreview()
            If Workbook Is Nothing Then Return
            Dim count As Integer = Workbook.Worksheets.Count
            documentViewerSinglePreview.Visible = False
            xtraTabControl1.Visible = False
            If count < 2 Then
                UpdateWorkbookSinglePreview()
            Else
                UpdateMultipleSheetPreview()
            End If
        End Sub

        Private Sub UpdateWorkbookSinglePreview()
            documentViewerSinglePreview.Visible = True
            UpdateDocumentViewerProperties(documentViewerSinglePreview)
            If documentViewerSinglePreview.PrintingSystem Is Nothing Then documentViewerSinglePreview.PrintingSystem = New PrintingSystemBase()
            Dim link As PrintableComponentLinkBase = New PrintableComponentLinkBase(documentViewerSinglePreview.PrintingSystem)
            link.Component = Workbook
            link.CreateDocument()
            UpdateDocumentViewerZoom(documentViewerSinglePreview)
        End Sub

        Private Sub UpdateMultipleSheetPreview()
            xtraTabControl1.Visible = True
            Dim count As Integer = Workbook.Worksheets.Count
            Dim usedPrintControls As List(Of PrintControl) = New List(Of PrintControl)()
            For i As Integer = 0 To count - 1
                Dim sheet As Worksheet = Workbook.Worksheets(i)
                Dim pc As PrintControl = EnsurePrintControl(i, sheet.Name)
                Dim link As PrintableComponentLinkBase = ObtainLinkFrom(pc)
                UpdateSheetPreview(sheet, link)
                usedPrintControls.Add(pc)
            Next

            ClearPrintControlCache(usedPrintControls)
        End Sub

        Private Sub ClearPrintControlCache(ByVal usedPrintControls As List(Of PrintControl))
            Dim toClear As List(Of PrintControl) = New List(Of PrintControl)()
            For Each pc As KeyValuePair(Of PrintControl, PrintableComponentLinkBase) In pcCache
                If Not usedPrintControls.Contains(pc.Key) Then toClear.Add(pc.Key)
            Next

            For Each item As PrintControl In toClear
                pcCache.Remove(item)
            Next
        End Sub

        Private Sub UpdateSheetPreview(ByVal sheet As Worksheet, ByVal link As PrintableComponentLinkBase)
            Dim printable As IBasePrintable = TryCast(sheet, IBasePrintable)
            link.Component = printable
            link.CreateDocument()
        End Sub

        Private Function ObtainLinkFrom(ByVal pc As PrintControl) As PrintableComponentLinkBase
            Dim link As PrintableComponentLinkBase = Nothing
            If pcCache.TryGetValue(pc, link) Then Return link
            link = New PrintableComponentLinkBase(pc.PrintingSystem)
            pcCache.Add(pc, link)
            Return link
        End Function

        Private Function EnsurePrintControl(ByVal i As Integer, ByVal caption As String) As PrintControl
            Dim tabPages As XtraTabPageCollection = xtraTabControl1.TabPages
            Dim page As XtraTabPage = If(i < tabPages.Count, tabPages(i), CreateNewTabPage())
            page.Text = caption
            If page.Controls.Count = 1 AndAlso TypeOf page.Controls(0) Is PrintControl Then Return TryCast(page.Controls(0), PrintControl)
            Dim pc As PrintControl = New PrintControl()
            pc.PrintingSystem = New PrintingSystemBase()
            pc.Dock = DockStyle.Fill
            page.Controls.Clear()
            page.Controls.Add(pc)
            UpdatePrintControlProperties(pc)
            Return pc
        End Function

        Private Sub UpdateDocumentViewerProperties(ByVal documentViewer As Preview.DocumentViewer)
            If documentViewer Is Nothing OrElse CanShowBorders Then Return
            documentViewer.PageBorderVisibility = DocumentView.PageBorderVisibility.None
            documentViewer.ShowPageMargins = False
            If documentViewer.PrintingSystem IsNot Nothing Then documentViewer.PrintingSystem.Graph.PageBackColor = Color.Gray
            documentViewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
        End Sub

        Private Sub UpdateDocumentViewerZoom(ByVal documentViewer As Preview.DocumentViewer)
            If documentViewer Is Nothing OrElse PreviewZoom = SpreadhsheetPreviewZoom.Default Then Return
            documentViewer.ShowPageMargins = False
            If PreviewZoom = SpreadhsheetPreviewZoom.WholePage Then
                documentViewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
                documentViewer.ExecCommand(PrintingSystemCommand.ShowFirstPage)
                documentViewer.ExecCommand(PrintingSystemCommand.ScrollPageUp)
            Else
                documentViewer.ExecCommand(PrintingSystemCommand.ZoomToTwoPages)
            End If
        End Sub

        Private Sub UpdatePrintControlProperties(ByVal pc As PrintControl)
            If pc Is Nothing OrElse CanShowBorders Then Return
            pc.PageBorderVisibility = DocumentView.PageBorderVisibility.None
            pc.ShowPageMargins = False
            pc.PrintingSystem.Graph.PageBackColor = Color.Gray
            pc.ExecCommand(PrintingSystemCommand.ZoomToWholePage)
        End Sub

        Private Function CreateNewTabPage() As XtraTabPage
            Dim tabPage As XtraTabPage = New XtraTabPage()
            xtraTabControl1.TabPages.Add(tabPage)
            Return tabPage
        End Function
    End Class

    Public Enum SpreadhsheetPreviewZoom
        [Default]
        WholePage
        TwoPages
    End Enum
End Namespace
