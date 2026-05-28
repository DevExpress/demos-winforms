Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace XtraReportsDemos

    Friend Class StandardFormWrapper
        Implements IDesignForm

        Private ReadOnly wrappedForm As ReportDesigner.MainForm

        Public ReadOnly Property Form As Form Implements IDesignForm.Form
            Get
                Return wrappedForm
            End Get
        End Property

        Public ReadOnly Property ActiveXRDesignPanel As XRDesignPanel Implements IDesignForm.ActiveXRDesignPanel
            Get
                Return wrappedForm.ActiveXRDesignPanel
            End Get
        End Property

        Public Sub New()
            wrappedForm = New ReportDesigner.MainForm()
        End Sub

        Public Sub OpenReport(ByVal newReport As XtraReport) Implements IDesignForm.OpenReport
            wrappedForm.OpenReport(newReport)
        End Sub
    End Class
End Namespace
