Imports System
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class HitTestingDemo
        Inherits ChartDemoModule

        Private ReadOnly toolTipController As ToolTipController = New ToolTipController()

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
            Dim builder As StringBuilder = New StringBuilder()
            If hitInfo.InDiagram Then builder.AppendLine("In diagram")
            If hitInfo.InNonDefaultPane Then builder.AppendLine("In non-default pane: " & hitInfo.NonDefaultPane.Name)
            If hitInfo.InAxis Then
                builder.AppendLine("In axis: " & hitInfo.Axis.Name)
                If hitInfo.AxisLabelItem IsNot Nothing Then builder.AppendLine("  Label item: " & hitInfo.AxisLabelItem.Text)
                If hitInfo.AxisTitle IsNot Nothing Then builder.AppendLine("  Axis title: " & hitInfo.AxisTitle.Text)
            End If

            If hitInfo.InChartTitle Then builder.AppendLine("In chart title: " & hitInfo.ChartTitle.Text)
            If hitInfo.InLegend Then
                builder.AppendLine("In legend")
                If hitInfo.Series IsNot Nothing AndAlso Not hitInfo.InSeries Then builder.AppendLine("  Series: " & CType(hitInfo.Series, Series).Name)
            End If

            If hitInfo.InSeries Then builder.AppendLine("In series: " & CType(hitInfo.Series, Series).Name)
            If hitInfo.InSeriesLabel Then
                builder.AppendLine("In series label")
                builder.AppendLine("  Series: " & CType(hitInfo.Series, Series).Name)
            End If

            If hitInfo.InSeriesPoint Then
                builder.AppendLine("  Argument: " & hitInfo.SeriesPoint.Argument)
                If Not hitInfo.SeriesPoint.IsEmpty Then builder.AppendLine("  Value: " & hitInfo.SeriesPoint.Values(0))
            End If

            If hitInfo.InAnnotation Then
                If TypeOf hitInfo.Annotation Is TextAnnotation Then
                    builder.AppendLine("In annotation: " & CType(hitInfo.Annotation, TextAnnotation).Name)
                ElseIf TypeOf hitInfo.Annotation Is ImageAnnotation Then
                    builder.AppendLine("In annotation: " & CType(hitInfo.Annotation, ImageAnnotation).Name)
                End If
            End If

            If hitInfo.InHyperlink Then
                builder.AppendLine("In hyperlink: " & hitInfo.Hyperlink)
                chart.Cursor = Cursors.Hand
            Else
                chart.Cursor = Cursors.Default
            End If

            If builder.Length > 0 Then
                toolTipController.ShowHint("Hit-testing results:" & Microsoft.VisualBasic.Constants.vbLf & builder.ToString(), chart.PointToScreen(e.Location))
            Else
                toolTipController.HideHint()
            End If
        End Sub

        Private Sub chart_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            toolTipController.HideHint()
        End Sub

        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
            If hitInfo.InHyperlink Then DevExpress.Data.Utils.SafeProcess.Start(hitInfo.Hyperlink)
        End Sub
    End Class
End Namespace
