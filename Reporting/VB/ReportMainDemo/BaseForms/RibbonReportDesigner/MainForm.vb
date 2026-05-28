Imports DevExpress.XtraReports.UserDesigner

Namespace RibbonReportDesigner

    Public Partial Class MainForm
        Inherits MainFormBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ActiveXRDesignPanel As XRDesignPanel
            Get
                Return reportDesigner1.ActiveDesignPanel
            End Get
        End Property

        Public Overrides Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
            reportDesigner1.OpenReport(newReport)
        End Sub

        Public Sub CreateNewReport()
            reportDesigner1.CreateNewReport()
        End Sub
    End Class
End Namespace
