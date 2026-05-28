Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class GanttViewsDemo
        Inherits ChartDemoModule

        Private Shared ReadOnly rightAxisLimit As Date = New DateTime(2006, 11, 13)

        Private chart As ChartControl

        Private ReadOnly Property Diagram As GanttDiagram
            Get
                Return If(chart IsNot Nothing, TryCast(chart.Diagram, GanttDiagram), Nothing)
            End Get
        End Property

        Private ReadOnly Property PlannedSeries As Series
            Get
                Return chart.GetSeriesByName("Planned")
            End Get
        End Property

        Private ReadOnly Property CompletedSeries As Series
            Get
                Return chart.GetSeriesByName("Completed")
            End Get
        End Property

        Private ReadOnly Property ProgressLine As ConstantLine
            Get
                Return Diagram.AxisY.ConstantLines(0)
            End Get
        End Property

        Private ReadOnly Property HasConstantLine As Boolean
            Get
                Return Diagram IsNot Nothing AndAlso Diagram.AxisY.ConstantLines.Count > 0
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartGantt, chartGanttSideBySide}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler currentTabbedView.PopupMenuShowing, Sub(s, e) e.Cancel = True
        End Sub

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs)
            chart = TryCast(CType(e.Document.Control, DockPanel).ControlContainer.Controls(0), ChartControl)
            chart.Animate()
        End Sub

        Private Sub chartGantt_ConstantLineMoved(ByVal sender As Object, ByVal e As ConstantLineMovedEventArgs)
            SetProgressState(CDate(e.ConstantLine.AxisValue))
        End Sub

        Private Sub chartGantt_AnimationEnded(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagram As XYDiagram = CType(ChartControl.Diagram, XYDiagram)
            If diagram.AxisY.ConstantLines.Count > 0 Then diagram.AxisY.ConstantLines(0).Visible = True
        End Sub

        Private Sub SetProgressState(ByVal dateTimeValue As Date)
            If dateTimeValue > rightAxisLimit Then dateTimeValue = rightAxisLimit
            If CompletedSeries IsNot Nothing AndAlso PlannedSeries IsNot Nothing Then
                CompletedSeries.Points.BeginUpdate()
                CompletedSeries.Points.Clear()
                For Each point As SeriesPoint In PlannedSeries.Points
                    Dim plannedStartDate As Date = point.DateTimeValues(0)
                    If Date.Compare(plannedStartDate, dateTimeValue) >= 0 Then Continue For
                    Dim plannedFinishDate As Date = point.DateTimeValues(1)
                    Dim completedFinishDate As Date
                    If Date.Compare(dateTimeValue, plannedFinishDate) > 0 Then
                        completedFinishDate = plannedFinishDate
                    Else
                        completedFinishDate = dateTimeValue
                    End If

                    CompletedSeries.Points.Add(New SeriesPoint(point.Argument, New Date() {plannedStartDate, completedFinishDate}))
                Next

                CompletedSeries.Points.EndUpdate()
            End If

            If HasConstantLine Then ProgressLine.AxisValue = dateTimeValue
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentManager.View.Controller.Activate(documentGantt)
        End Sub
    End Class
End Namespace
