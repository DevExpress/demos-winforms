Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner

Namespace XtraReportsDemos

    Friend Interface IDesignForm

        ReadOnly Property Form As Form

        ReadOnly Property ActiveXRDesignPanel As XRDesignPanel

        Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)

    End Interface
End Namespace
