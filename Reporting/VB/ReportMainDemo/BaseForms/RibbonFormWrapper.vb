Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports RibbonReportDesigner

Namespace XtraReportsDemos

    Friend Class RibbonFormWrapper
        Implements IDesignForm

        Private ReadOnly wrappedForm As MainFormBase

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

        Public Sub New(ByVal useOldRibbonStyle As Boolean)
            If useOldRibbonStyle Then
                wrappedForm = New MainForm()
            Else
                wrappedForm = New OfficeInspiredMainForm()
            End If
        End Sub

        Public Sub OpenReport(ByVal newReport As XtraReport) Implements IDesignForm.OpenReport
            wrappedForm.OpenReport(newReport)
        End Sub
    End Class
End Namespace
