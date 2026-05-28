Imports System
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class OperationRestrictionsModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OperationRestrictions_template.xlsx"))
            propertyGridControl1.SelectedObject = New BehaviorOptionsProvider(spreadsheetControl1.Options.Behavior)
            propertyGridControl1.RowHeaderWidth = 110
            propertyGridControl1.OptionsView.ShowRootCategories = False
            propertyGridControl1.ExpandAllRows()
            InitializeZoomFactors()
        End Sub

        Private Sub InitializeZoomFactors()
            spreadsheetControl1.Options.Behavior.MaxZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MaxZoomFactorDefault
            spreadsheetControl1.Options.Behavior.MinZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MinZoomFactorDefault
        End Sub

        Private Sub ReadOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetControl1.ReadOnly = CType(sender, CheckEdit).Checked
        End Sub
    End Class
End Namespace
