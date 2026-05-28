Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class LargeSeriesNumberDemo
        Inherits ChartDemoModule

        Const UngrouppedSeriesCount As Integer = 11

        Private othersSeriesIndex As Integer

        Private ReadOnly Property Series As SeriesCollection
            Get
                Return chart.Series
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.DataSource = ReadDataFromFile()
        End Sub

        Private Sub ChartControl_LegendItemChecked(ByVal sender As Object, ByVal e As LegendItemCheckedEventArgs)
            Dim checkedSeries As Series = TryCast(e.CheckedElement, Series)
            If checkedSeries Is Nothing OrElse Series.IndexOf(checkedSeries) <> othersSeriesIndex Then Return
            For i As Integer = 0 To Series.Count - 1
                If i < othersSeriesIndex Then Series(i).Visible = e.NewCheckState
            Next
        End Sub

        Private Sub ChartControl_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Series.Count = 0 Then Return
            Dim seriesCount As Integer = Series.Count
            othersSeriesIndex = seriesCount - UngrouppedSeriesCount
            Dim color As Color = chart.GetPaletteEntries(Series.Count)(0).Color
            For i As Integer = 0 To seriesCount - 1
                Dim series As Series = Me.Series(i)
                series.View.Color = ColorizerSeaIceSeries(color, seriesCount - i, LookAndFeel.ActiveSkinName)
                If i < othersSeriesIndex Then
                    Me.Series(i).ShowInLegend = False
                ElseIf i = othersSeriesIndex Then
                    series.LegendTextPattern = "Others"
                ElseIf i = Me.Series.Count - 1 Then
                    Dim view As LineSeriesView = CType(series.View, LineSeriesView)
                    view.LineStyle.Thickness = 5
                    view.FirstPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint
                    view.FirstPoint.Label.TextPattern = "{FullDate:MM/dd/yyyy}" & Microsoft.VisualBasic.Constants.vbLf & "{V:0.000M km²}"
                    view.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint
                    view.LastPoint.Label.TextPattern = "{FullDate:MM/dd/yyyy}" & Microsoft.VisualBasic.Constants.vbLf & "{V:0.000M km²}"
                End If
            Next
        End Sub

        Private Sub UpdateSeriesColors()
            Dim color As Color = chart.GetPaletteEntries(Series.Count)(0).Color
            Dim seriesCount As Integer = Series.Count
            For i As Integer = 0 To seriesCount - 1
                Series(i).View.Color = ColorizerSeaIceSeries(color, seriesCount - i, LookAndFeel.ActiveSkinName)
            Next
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateSeriesColors()
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            UpdateSeriesColors()
        End Sub
    End Class
End Namespace
