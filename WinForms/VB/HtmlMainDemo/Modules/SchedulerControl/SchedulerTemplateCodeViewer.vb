Imports DevExpress.Utils.Html
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic

Namespace DevExpress.HTML.Demos

    Public Class SchedulerTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private control As SchedulerControl

        Public Sub Fill(ByVal control As SchedulerControl)
            Me.control = control
            Dim templates As List(Of HtmlTemplate) = New List(Of HtmlTemplate)()
            templates.Add(Me.control.DayView.HtmlTemplates.Appointment)
            templates.Add(Me.control.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate)
            FillTemplates(templates)
        End Sub

        Protected Overrides Sub LayoutChanged()
            control.DayView.LayoutChanged()
        End Sub
    End Class
End Namespace
