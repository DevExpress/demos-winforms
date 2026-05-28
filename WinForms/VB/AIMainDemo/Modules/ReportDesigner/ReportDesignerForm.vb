Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Design
Imports System.Linq
Imports DevExpress.AI.Demos.Properties
Imports DevExpress.AIIntegration.WinForms.Reporting.Internal
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace DevExpress.AI.Demos

    Public Partial Class ReportDesignerForm
        Inherits RibbonForm

        Private ReadOnly guideController As GuideController

        Public Sub New()
            InitializeComponent()
            guideController = New GuideController(Me, GetGuides())
#If NET
            behaviorManager1.Attach<DevExpress.AIIntegration.WinForms.Reporting.ReportModifyBehavior>(reportDesigner1);
#End If
        End Sub

        Public ReadOnly Property ActiveXRDesignPanel As XRDesignPanel
            Get
                Return reportDesigner1.ActiveDesignPanel
            End Get
        End Property

        Public Sub OpenReport(ByVal report As XtraReport)
            reportDesigner1.OpenReport(report)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            guideController.ShowGuides()
        End Sub

        Private Function FindTestDataItem() As Object
            Return ribbonControl1.PageHeaderItemLinks.FirstOrDefault(Function(a) TypeOf a.Item Is TestDataSourceBarButtonItem)
        End Function

        Private Function GetGuides() As GuideInfo()
            Dim guides As List(Of GuideInfo) = New List(Of GuideInfo) From {New GuideInfo() With {.Image = Resources.ai_reports_localizationGuide, .Location = Utils.VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindSmartTagControl}, New GuideInfo() With {.Image = Resources.ai_reports_wizardGuide, .Location = Utils.VisualEffects.GuideFlyoutLocation.Right, .GetTarget = Function() commandBarItem6}, New GuideInfo() With {.Image = Resources.ai_reports_expressionGuide, .Location = Utils.VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindSmartTagControl}, New GuideInfo() With {.Image = Resources.ai_reports_test_dataGuide, .Location = Utils.VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindTestDataItem}}
#If NET
            guides.Add(new GuideInfo() {
                Image = Resources.ai_reports_chatGuide,
                Location = DevExpress.Utils.VisualEffects.GuideFlyoutLocation.Left,
                GetTarget = FindAIAssistantPanel
            });
#End If
            Return guides.ToArray()
        End Function

        Private Function FindSmartTagControl() As Object
            Dim designer = TryCast(reportDesigner1.ActiveDesignPanel.GetService(Of IDesignerHost)().GetDesigner(reportDesigner1.ActiveDesignPanel.Report), ReportDesignerBase)
            Return designer.ReportFrame.CollectControls(Function(x) x.GetType().Name.Contains("CornerPanel")).FirstOrDefault()
        End Function
#If NET
        object FindAIAssistantPanel() {
            var aiAssistant = xrDesignDockManager1.Panels.Union(xrDesignDockManager1.RootPanels).FirstOrDefault(x => x.Text == "AI Assistant");
            xrDesignDockManager1.ActivePanel = aiAssistant;
            return aiAssistant;
        }
#End If
    End Class
End Namespace
