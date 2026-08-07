Imports System
Imports System.Collections.Generic
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class PanesDemo
        Inherits DevExpress.XtraCharts.Demos.ChartDemoModule

        Private activeChart As DevExpress.XtraCharts.ChartControl = New DevExpress.XtraCharts.ChartControl()

        Friend Overrides ReadOnly Property ChartControls As List(Of DevExpress.XtraCharts.ChartControl)
            Get
                Return New System.Collections.Generic.List(Of DevExpress.XtraCharts.ChartControl)() From {Me.chartLinearLayout, Me.chartGridLayout}
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return Me.activeChart
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Dim data As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.WebSitePerformanceIndicatorItem) = Me.GetData()
            Me.chartLinearLayout.DataSource = data
            Me.chartGridLayout.DataSource = data
        End Sub

        Private Function GetData() As List(Of DevExpress.XtraCharts.Demos.WebSitePerformanceIndicatorItem)
            Dim data As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.WebSitePerformanceIndicatorItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.WebSitePerformanceIndicatorItem)()
            Dim lastDate As System.DateTime = DevExpress.DXperience.Demos.TutorialConstants.Now.AddDays(-1)
            Dim random As DevExpress.Data.Utils.NonCryptographicRandom = DevExpress.DXperience.Demos.TutorialConstants.Random
            For i As Integer = 0 To 30 - 1
                Dim newVisitors As Integer = random.[Next](18, 77)
                data.Add(New DevExpress.XtraCharts.Demos.WebSitePerformanceIndicatorItem() With {.ReportDate = lastDate.AddDays(-i), .TrafficTime = random.[Next](3, 12), .ResponseTime = random.[Next](40, 110), .AveragePageLoadTime = random.NextDouble() * 3 + 0.5, .MemoryUsage = random.[Next](500, 2000), .CPUUsage = random.[Next](10, 77), .ClientErrors = random.[Next](2, 45), .ServerErrors = random.[Next](2, 7), .NewVisitors = newVisitors, .ReturnVisitors = random.[Next](10, newVisitors)})
            Next

            Return data
        End Function

        Private Sub tabbedView_DocumentActivated(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs)
            Me.activeChart = TryCast(CType(e.Document.Control, DevExpress.XtraBars.Docking.DockPanel).ControlContainer.Controls(0), DevExpress.XtraCharts.ChartControl)
            Me.activeChart.Animate()
        End Sub

        Private Sub TabbedView_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.PopupMenuShowingEventArgs)
            e.Cancel = e.GetDocument() IsNot Nothing
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Me.documentManager.View.Controller.Activate(Me.documentLinearPaneLayout)
        End Sub
    End Class

    Public Class WebSitePerformanceIndicatorItem

        Public Property ReportDate As DateTime

        Public Property TrafficTime As Integer 's

        Public Property ResponseTime As Integer 'ms

        Public Property AveragePageLoadTime As Double 's

        Public Property MemoryUsage As Integer 'MB

        Public Property CPUUsage As Integer 'percent

        Public Property ClientErrors As Integer

        Public Property ServerErrors As Integer

        Public Property NewVisitors As Integer

        Public Property ReturnVisitors As Integer
    End Class
End Namespace
