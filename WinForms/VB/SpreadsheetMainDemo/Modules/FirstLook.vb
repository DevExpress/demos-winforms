Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class FirstLookModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("InvestmentPortfolio.xltx"))
            AddHandler spreadsheetControl1.InvalidFormatException, AddressOf SpreadsheetControl1_InvalidFormatException
            AddHandler spreadsheetControl1.DocumentClosing, AddressOf SpreadsheetControl1_DocumentClosing
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return homeRibbonPage1
            End Get
        End Property

        Private Sub SpreadsheetControl1_InvalidFormatException(ByVal sender As Object, ByVal e As SpreadsheetInvalidFormatExceptionEventArgs)
            XtraMessageBox.Show(String.Format("Cannot open the file '{0}' because the file format or file extension is not valid." & Microsoft.VisualBasic.Constants.vbLf & "Verify that file has not been corrupted and that the file extension matches the format of the file.", e.SourceUri), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Private Sub SpreadsheetControl1_DocumentClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If spreadsheetControl1.Modified Then
                Dim currentFileName As String = spreadsheetControl1.Options.Save.CurrentFileName
                Dim message As String = If(Not String.IsNullOrEmpty(currentFileName), String.Format("Do you want to save the changes you made for '{0}'?", currentFileName), "Do you want to save the changes?")
                Dim result As DialogResult = XtraMessageBox.Show(message, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    e.Cancel = Not spreadsheetControl1.SaveDocument()
                Else
                    e.Cancel = result = DialogResult.Cancel
                End If
            End If
        End Sub
    End Class
End Namespace
