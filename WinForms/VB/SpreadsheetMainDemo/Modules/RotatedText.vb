Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class RotatedTextModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("RotatedText_template.xlsx"))
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return homeRibbonPage1
            End Get
        End Property
    End Class
End Namespace
