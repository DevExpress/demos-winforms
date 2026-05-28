Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraSpreadsheet.Services

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class HeaderFooterModule
        Inherits SpreadSheetTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"), DocumentFormat.Xlsx)
            spreadsheetPreview1.Workbook = spreadsheetControl1.Document
            spreadsheetPreview1.UpdatePreview()
        End Sub

        Private Sub spreadsheetControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetPreview1.UpdatePreview()
        End Sub

        Private Sub btnPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim service As ISpreadsheetCommandFactoryService = spreadsheetControl1.GetService(Of ISpreadsheetCommandFactoryService)()
            Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.PageSetupHeaderFooter)
            command.ForceExecute(command.CreateDefaultCommandUIState())
        End Sub
    End Class
End Namespace
