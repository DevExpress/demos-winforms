Imports DevExpress.XtraPrinting.Preview

Namespace XtraReportsDemos.VehicleInspectionReport

    Friend Class PreviewControl
        Inherits ReportModule

        Shared Sub New()
            Call EditingFieldExtensionsWin.Instance.RegisterImageEditor("DamageDiagram", "Damage Diagram", New ImageEditorOptions() With {.AllowLoadImage = False, .AllowChangeSizeOptions = False, .AllowDraw = True, .AllowClear = False})
        End Sub

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(2, 1)
        End Sub

        Protected Overrides Sub OnAfterReportPrint()
            If Viewer IsNot Nothing Then Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, New Object() {True})
        End Sub

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
