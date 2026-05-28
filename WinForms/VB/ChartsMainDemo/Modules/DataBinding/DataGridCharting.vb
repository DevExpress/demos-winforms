Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class DataGridChartingDemo
        Inherits ChartDemoModule

        Private focusedChart As ChartControl

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return focusedChart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartTotalUnitsSold, chartMonthlyRevenue}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler gridControl.Load, AddressOf OnGridDataLoad
            gridControl.DataSource = ExtractData()
            focusedChart = chartTotalUnitsSold
        End Sub

        Private Sub OnGridDataLoad(ByVal sender As Object, ByVal e As EventArgs)
            gridView.SelectGroup(gridView.GetVisibleRowHandle(0))
            gridView.SelectGroup(gridView.GetVisibleRowHandle(2))
            gridView.SelectGroup(gridView.GetVisibleRowHandle(5))
            FillColorizerKeys(CType(chartTotalUnitsSold.SeriesTemplate.SeriesColorizer, SeriesKeyColorColorizer).Keys)
        End Sub

        Private Sub FillColorizerKeys(ByVal keys As KeyCollection)
            Dim rHandle As Integer = -1
            While gridView.IsValidRowHandle(rHandle)
                keys.Add(gridView.GetGroupRowValue(rHandle, gridColumn1))
                rHandle -= 1
            End While
        End Sub

        Private Sub OnChartControlClick(ByVal sender As Object, ByVal e As EventArgs)
            focusedChart = CType(sender, ChartControl)
        End Sub
    End Class

    Public Class SalesGridView
        Inherits GridView

        Public Sub SelectGroup(ByVal rowHandle As Integer)
            SelectAllGroupRows(rowHandle)
        End Sub
    End Class
End Namespace
