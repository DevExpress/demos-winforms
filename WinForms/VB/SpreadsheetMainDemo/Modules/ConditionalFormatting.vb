Imports System
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class TopTradingPartnersModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("TopTradingPartners.xlsx"))
            UpdateConditionalFormatting()
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateConditionalFormatting()
        End Sub

        Private Sub UpdateConditionalFormatting()
            spreadsheetControl1.BeginUpdate()
            Try
                Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
                sheet.ConditionalFormattings.Clear()
                If chkImports.Checked Then
                    ApplyTopImportsConditionalFormatting(sheet)
                    ApplyImportsYearlyChangeConditionalFormatting(sheet)
                End If

                If chkExports.Checked Then
                    ApplyTopExportsConditionalFormatting(sheet)
                    ApplyExportsYearlyChangeConditionalFormatting(sheet)
                End If

                If chkBalance.Checked Then
                    ApplyBalanceTrendConditionalFormatting(sheet)
                    ApplyBalanceChangeConditionalFormatting(sheet)
                End If

                If chkAsiaRegion.Checked Then ApplyAsiaCountriesConditionalFormatting(sheet)
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
