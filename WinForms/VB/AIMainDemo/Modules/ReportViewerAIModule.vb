Imports System.IO
Imports System.Reflection
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraReports.UI

Namespace DevExpress.AI.Demos

    Public Partial Class ReportViewerAIModule
        Inherits AITutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            UpdatePaddings()
            If DemoHelper.IsTesting Then Return 'Don't load Report
            Using manifestResourceStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.TableReport.prnx")
                If manifestResourceStream Is Nothing Then Throw New FileNotFoundException("Embedded report resource not found.")
                Dim report As XtraReport = New XtraReport()
                report.PrintingSystem.LoadDocument(manifestResourceStream)
                documentViewerControl1.DocumentSource = report
            End Using
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub
    End Class
End Namespace
