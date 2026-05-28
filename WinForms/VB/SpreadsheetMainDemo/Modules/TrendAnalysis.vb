Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class TrendAnalysisModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("TrendlineAnalysis_template.xlsx"))
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return formulasRibbonPage1
            End Get
        End Property
    End Class
End Namespace
