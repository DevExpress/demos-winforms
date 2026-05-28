Imports DevExpress.Utils
Imports DevExpress.XtraBars.Helpers
Imports System.Drawing
Imports System.Linq
Imports System
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.AI.ReportDesigner.Demo

    Public Partial Class ReportDesignerForm
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
#If NET
            behaviorManager1.Attach<ReportModifyBehavior>(reportDesigner1);
#End If
            Icon = LoadDefaultIcon()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            reportDesigner1.OpenReport(New XtraReportsDemos.NorthwindTraders.InvoiceReport())
        End Sub

        Private Function LoadDefaultIcon() As Icon
            Dim assembly = GetType(ReportDesignerForm).Assembly
            Return ResourceImageHelperCore.CreateIconFromResources(assembly.GetManifestResourceNames().First(Function(x) x.Contains("AppIcon.ico")), assembly)
        End Function
    End Class
End Namespace
