Imports System.Globalization
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.Utils.Behaviors
Imports DevExpress.XtraReports.UI
Imports XtraReportsDemos.NorthwindTraders

Namespace XtraReportsDemos.AIOperations

    Public Class PreviewControl
        Inherits ReportModule

        Private ReadOnly behaviorManager1 As BehaviorManager = New BehaviorManager()

        Protected Friend Overrides ReadOnly Property HeaderContent As Control = New ucDisclaimerPanel()

        Protected Overrides Function CreateReport() As XtraReport
            Call RegisterIfNeeded()
            Return New InvoiceReport()
        End Function

        Protected Overrides Sub OnSetViewer()
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Dim languageInfo1 As LanguageInfo = New LanguageInfo With {.Culture = New CultureInfo("en"), .LanguageName = "English"}
            Dim languageInfo2 As LanguageInfo = New LanguageInfo With {.Culture = New CultureInfo("es"), .LanguageName = "Spanish"}
            Dim languageInfo3 As LanguageInfo = New LanguageInfo With {.Culture = New CultureInfo("de"), .LanguageName = "German"}
            Dim languageInfo4 As LanguageInfo = New LanguageInfo With {.Culture = New CultureInfo("zh"), .LanguageName = "Chinese"}
            behaviorManager1.Detach(Viewer)
            behaviorManager1.SetBehaviors(Viewer, New Behavior() {DocumentTranslateBehavior.Create(GetType(DocumentTranslateBehaviorSource), New LanguageInfo() {languageInfo1, languageInfo2, languageInfo3, languageInfo4}), DocumentSummarizeBehavior.Create(GetType(DocumentSummarizeBehaviorSource), SummarizationMode.Abstractive), New DocumentTranslateInlineBehavior(GetType(DocumentTranslateInlineBehaviorSource), New LanguageInfo() {languageInfo1, languageInfo2, languageInfo3, languageInfo4})})
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth)
        End Sub

        Protected Overrides Function StopWorkingAsync() As Task
            behaviorManager1.Detach(Viewer)
            Return MyBase.StopWorkingAsync()
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
