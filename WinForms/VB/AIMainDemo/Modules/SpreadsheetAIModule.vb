Imports System.Reflection
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.Spreadsheet

Namespace DevExpress.AI.Demos

    Public Partial Class SpreadsheetAIModule
        Inherits AITutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            Dim documentStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.LoanAmortizationSchedule.xlsx")
            spreadsheetControl1.LoadDocument(documentStream, DocumentFormat.OpenXml)
            UpdatePaddings()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Protected Overrides Sub DoHide()
            behaviorManager1.GetBehavior(Of ProofreadBehavior)(spreadsheetControl1)?.CloseOverlayForm()
            behaviorManager1.GetBehavior(Of TranslateBehavior)(spreadsheetControl1)?.CloseOverlayForm()
            MyBase.DoHide()
        End Sub
    End Class
End Namespace
