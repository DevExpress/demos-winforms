Imports System
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraSpreadsheet.Services

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class PrintTitlesModule
        Inherits SpreadSheetTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"))
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage
            spreadsheetPreview1.Workbook = spreadsheetControl1.Document
            spreadsheetPreview1.UpdatePreview()
        End Sub

        Public Overrides ReadOnly Property ShowWithPaddings As Boolean
            Get
                Return True
            End Get
        End Property

        Private Sub SpreadsheetControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetPreview1.UpdatePreview()
            xtraTabControl1.SelectedTabPageIndex = 1
        End Sub

        Private Sub PageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabControl1.SelectedTabPageIndex = 0
            Dim service As ISpreadsheetCommandFactoryService = spreadsheetControl1.GetService(Of ISpreadsheetCommandFactoryService)()
            Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.PageSetupSheet)
            command.ForceExecute(command.CreateDefaultCommandUIState())
        End Sub

        Private Sub WholePage_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage
        End Sub

        Private Sub ManyPages_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.TwoPages
        End Sub
    End Class
End Namespace
