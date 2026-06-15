Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Linq
Imports DevExpress.AIIntegration.WinForms.Reporting
Imports DevExpress.AIIntegration.WinForms.Reporting.Internal
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraReports.Design
Imports RibbonReportDesigner

Namespace XtraReportsDemos

    Public Class AIReportDesignerForm
        Inherits OfficeInspiredMainForm

#Region "fields"
        Private behaviorManager1 As Behaviors.BehaviorManager

        Private components As System.ComponentModel.IContainer

        Private ReadOnly guideController As GuideController

#End Region
#Region "WinForms designer auto-generated code"
        Private Overloads Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIReportDesignerForm))
            behaviorManager1 = New Behaviors.BehaviorManager(components)
            CType(reportDesigner1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            ' reportDesigner1
            '
            behaviorManager1.SetBehaviors(reportDesigner1, New Behaviors.Behavior() {CType(ReportPromptToReportBehavior.Create(GetType(XRDesignMdiControllerGenerationBehaviorSource), 3, True, 0F), Behaviors.Behavior), CType(CType((Behaviors.Behavior.Create(GetType(ReportLocalizationBehavior), GetType(XRDesignMdiControllerLocalizationBehaviorSource), New Object() {(CObj(3)), (CObj(False)), (CObj(0F))})), ReportLocalizationBehavior), Behaviors.Behavior), CType(ReportTestDataSourceBehavior.Create(GetType(XRDesignMdiControllerTestDataSourceBehaviorSource), 10, Nothing), Behaviors.Behavior), CType(ReportPromptToExpressionBehavior.Create(GetType(XRDesignMdiControllerPromptToReportExpressionBehaviorSource)), Behaviors.Behavior)})
            ' 
            ' AIReportDesignerForm
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(9F, 21F)
            ClientSize = New System.Drawing.Size(1830, 972)
            IconOptions.Icon = CType(resources.GetObject("AIReportDesignerForm.IconOptions.Icon"), System.Drawing.Icon)
            Margin = New Windows.Forms.Padding(6, 8, 6, 8)
            Name = "AIReportDesignerForm"
            CType(reportDesigner1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Public Sub New()
            InitializeComponent()
            guideController = New GuideController(Me, GetGuides())
#If NET
            behaviorManager1.Attach<ReportModifyBehavior>(reportDesigner1);
#End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ShowGuides()
        End Sub

        Private Sub ShowGuides()
            guideController.ShowGuides()
        End Sub

        Private Function FindTestDataItem() As Object
            Return Ribbon.PageHeaderItemLinks.FirstOrDefault(Function(a) TypeOf a.Item Is TestDataSourceBarButtonItem)
        End Function

        Private Function GetGuides() As GuideInfo()
            Dim guides As List(Of GuideInfo) = New List(Of GuideInfo) From {New GuideInfo() With {.Image = GetImage("LocalizationGuide"), .Location = VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindSmartTagControl}, New GuideInfo() With {.Image = GetImage("WizardGuide"), .Location = VisualEffects.GuideFlyoutLocation.Right, .GetTarget = Function() commandBarItem6}, New GuideInfo() With {.Image = GetImage("AIExpressionGuide"), .Location = VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindSmartTagControl}, New GuideInfo() With {.Image = GetImage("TestDataGuide"), .Location = VisualEffects.GuideFlyoutLocation.Right, .GetTarget = AddressOf FindTestDataItem}}
#If NET
            guides.Add(new GuideInfo() {
                Image = GetImage("ChatGuide"),
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
        Private Shared Function GetImage(ByVal name As String) As Image
            Return ResourceImageHelperCore.CreateImageFromResources(String.Format("XtraReportsDemos.Resources.AI.{0}.png", name), GetType(AIReportDesignerForm).Assembly)
        End Function
    End Class
End Namespace
