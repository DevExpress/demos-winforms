Imports System.Configuration
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MailMergeSimpleReportModule
        Inherits MailMergeModuleBase

        Protected Overrides ReadOnly Property ShowFilterPanel As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ShowParametersPanel As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
            Call ConfigureConnectionString()
            Dim book As IWorkbook = spreadsheetControl.Document
            book.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\TableReportTemplate.xlsx"))
        End Sub

        Private Shared Sub ConfigureConnectionString()
            Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim csSection As ConnectionStringsSection = config.ConnectionStrings
            Dim newSettings As ConnectionStringSettings = New ConnectionStringSettings("nwindConnection", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path, "System.Data.OleDb")
            csSection.ConnectionStrings.Add(newSettings)
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("connectionStrings")
        End Sub

        Protected Overrides Sub LoadData(ByVal book As IWorkbook)
        End Sub

        Protected Overrides Sub HideComments(ByVal book As IWorkbook, ByVal visible As Boolean)
            book.BeginUpdate()
            book.Worksheets(0).Rows(1).Visible = visible
            book.Worksheets(0).Rows(2).Visible = visible
            book.Worksheets(0).Rows(3).Visible = visible
            book.Worksheets(0).Rows(4).Visible = visible
            book.Worksheets(0).Rows(8).Visible = visible
            book.Worksheets(0).Rows(9).Visible = visible
            book.Worksheets(0).Rows(11).Visible = visible
            book.Worksheets(0).Rows(12).Visible = visible
            book.Worksheets(0).Rows(18).Visible = visible
            book.EndUpdate()
        End Sub
    End Class
End Namespace
