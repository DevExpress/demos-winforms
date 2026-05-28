Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class DataValidationModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataValidation_template.xlsx"))
            spreadsheetControl1.Options.Behavior.Drawing.Move = DocumentCapability.Disabled
            spreadsheetControl1.Options.Behavior.Drawing.Resize = DocumentCapability.Disabled
            spreadsheetControl1.Options.Behavior.Drawing.Rotate = DocumentCapability.Disabled
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return dataRibbonPage1
            End Get
        End Property
    End Class
End Namespace
