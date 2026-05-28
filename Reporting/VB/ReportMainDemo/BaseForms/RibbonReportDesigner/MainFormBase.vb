Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraReports.UserDesigner

Namespace RibbonReportDesigner

    Public Class MainFormBase
        Inherits RibbonForm

        Public Sub New()
            Text = "Report Designer"
#If DEBUG
            Text += $" v{AssemblyInfo.VersionShort}"
#End If
        End Sub

        Public Overridable Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
        End Sub

        Public Overridable ReadOnly Property ActiveXRDesignPanel As XRDesignPanel
            Get
                Return Nothing
            End Get
        End Property
    End Class
End Namespace
