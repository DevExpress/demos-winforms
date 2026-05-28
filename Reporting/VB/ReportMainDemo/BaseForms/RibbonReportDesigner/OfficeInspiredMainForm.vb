Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace RibbonReportDesigner

    Public Partial Class OfficeInspiredMainForm
        Inherits MainFormBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ActiveXRDesignPanel As XRDesignPanel
            Get
                Return reportDesigner1.ActiveDesignPanel
            End Get
        End Property

        Public Overrides Sub OpenReport(ByVal report As XtraReport)
            reportDesigner1.OpenReport(report)
        End Sub
    End Class
End Namespace
