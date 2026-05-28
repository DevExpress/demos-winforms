Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class HyperlinksModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Options.View.ShowPrintArea = False
            spreadsheetControl1.Options.Print.PrintContent = SpreadsheetPrintContent.EntireWorkbook
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Hyperlinks_template.xlsx"))
        End Sub
    End Class
End Namespace
