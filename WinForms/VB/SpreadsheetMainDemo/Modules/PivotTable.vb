Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class PivotTableModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Private ReadOnly Property Workbook As IWorkbook
            Get
                Return spreadsheetControl1.Document
            End Get
        End Property

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                pivotTableToolsRibbonPageCategory1.Visible = True
                pivotTableAnalyzeRibbonPage1.Visible = True
                Return pivotTableAnalyzeRibbonPage1
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            ApplyOptions()
            Workbook.LoadDocument(DemoUtils.GetRelativePath("PivotTableDemoTemplate.xlsx"))
            spreadsheetControl1.Document.PivotCaches.RefreshAll()
        End Sub

        Private Sub ApplyOptions()
            Dim graphics As Graphics = CreateGraphics()
            Dim pivotTableFieldListOptions As SpreadsheetPivotTableFieldListOptions = spreadsheetControl1.Options.PivotTableFieldList
            pivotTableFieldListOptions.StartPosition = SpreadsheetPivotTableFieldListStartPosition.ManualSpreadsheetControl
            pivotTableFieldListOptions.StartSize = New Size(CInt(350 * graphics.DpiX / 96F), CInt(601 * graphics.DpiY / 96F))
            Dim width As Double = spreadsheetControl1.Width - pivotTableFieldListOptions.StartSize.Width
            pivotTableFieldListOptions.StartLocation = New Point(CInt(width), 0)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet("C3")
        End Sub

        Protected Overrides Sub DoHide()
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet("A1")
            MyBase.DoHide()
        End Sub
    End Class
End Namespace
