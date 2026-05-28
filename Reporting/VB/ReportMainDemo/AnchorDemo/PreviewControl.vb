Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.AnchorVertical

    Friend Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth)
        End Sub

        Public Overrides Sub AddElements(ByVal adorner As AdornerUIManager, ByVal targets As IDictionary(Of String, Object))
            Dim element As Object = Nothing
            If targets.TryGetValue("PageSetup", element) Then
                AddHandler adorner.QueryGuideFlyoutControl, AddressOf Adorner_QueryGuideFlyoutControl
                Dim guide As Guide = New Guide() With {.TargetElement = element}
                adorner.Elements.Add(guide)
            End If
        End Sub

        Private Sub Adorner_QueryGuideFlyoutControl(ByVal sender As Object, ByVal e As QueryGuideFlyoutControlEventArgs)
            e.Control = New LabelControl() With {.AllowHtmlString = True, .Width = 250, .AutoSizeMode = LabelAutoSizeMode.Vertical, .Padding = New Padding(20), .Text = "Change Margins, Orientation or Size to see how horizontal anchoring works."}
        End Sub
    End Class
End Namespace
