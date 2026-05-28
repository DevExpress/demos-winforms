Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class WorksheetProtectionModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("SimpleMonthlyBudget.xlsx"))
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return reviewRibbonPage1
            End Get
        End Property
    End Class
End Namespace
