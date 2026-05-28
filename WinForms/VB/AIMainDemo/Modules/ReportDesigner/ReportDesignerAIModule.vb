Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.AI.Demos.Properties
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Namespace DevExpress.AI.Demos

    Public Partial Class ReportDesignerAIModule
        Inherits AITutorialControl

        Public Sub New()
            InitializeComponent()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            gallery.InitializeGallery(GetFeatureInfos())
        End Sub

        Private Function GetFeatureInfos() As IEnumerable(Of FeatureTileInfo)
            Return {New FeatureTileInfo() With {.Caption = "Localization", .Description = "Use AI-powered localization to translate report content to a different language with a single click.
<href=https://docs.devexpress.com/XtraReports/405435>Learn More</href>", .Image = Resources.ai_reports_localizationThumb}, New FeatureTileInfo() With {.Caption = "Report Creation", .Description = "Run the Report Wizard to generate a new report layout based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405460>Learn More</href>", .Image = Resources.ai_reports_wizardThumb}, New FeatureTileInfo() With {.Caption = "Report Modification", .Description = "Chat with an AI Assistant to make adjustments to your report layout (available for .NET 8+).
<href=https://docs.devexpress.com/XtraReports/405498>Learn More</href>", .Image = Resources.ai_reports_chatThumb}, New FeatureTileInfo() With {.Caption = "Test Data Preview", .Description = "Preview your report with AI-generated test data before connecting to a live source.
<href=http://docs.devexpress.devx/XtraReports/405566>Learn More</href>", .Image = Resources.ai_reports_test_dataThumb}, New FeatureTileInfo() With {.Caption = "Prompt-to-Expression", .Description = "Generate a data binding expression or a filter condition based on a natural language prompt.
<href=http://docs.devexpress.devx/XtraReports/405646>Learn More</href>", .Image = Resources.ai_expression_Thumb}}
        End Function

        Private Sub runDesignerBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim size = New Size()
            Using form = New DemoWaitForm()
                size = form.Size
            End Using

            Dim waitFormLocation As Point = tableLayoutPanel.PointToScreen(New Point((Width - size.Width) \ 2, (Height - size.Height) \ 2))
            SplashScreenManager.ShowForm(Me, GetType(DemoWaitForm), True, False, SplashFormStartPosition.Manual, waitFormLocation)
            Using report As XtraReport = CreateReport()
                Using form As ReportDesignerForm = New ReportDesignerForm()
                    form.WindowState = Windows.Forms.FormWindowState.Maximized
                    form.OpenReport(report)
                    AddHandler form.Load, Sub(s, args) SplashScreenManager.CloseForm(False)
                    form.ShowDialog()
                End Using
            End Using
        End Sub

        Protected Overridable Function CreateReport() As XtraReport
            Return New XtraReportsDemos.NorthwindTraders.InvoiceReport()
        End Function

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Private Overloads Sub OnResize(ByVal sender As Object, ByVal e As EventArgs)
            Dim availableHeight As Integer = tableLayoutPanel.ClientSize.Height
            Dim reservedHeight As Integer = lblTitle.Height + btnRunDesigner.Height + lblTitle.Margin.Vertical + btnRunDesigner.Margin.Vertical
            Dim maxGalleryHeight As Integer = availableHeight - reservedHeight
            galleryContainerPanel.MaximumSize = New Size(0, maxGalleryHeight)
            galleryContainerPanel.MinimumSize = New Size(0, 0)
        End Sub
    End Class
End Namespace
