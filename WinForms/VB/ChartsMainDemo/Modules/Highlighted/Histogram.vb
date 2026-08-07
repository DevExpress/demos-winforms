Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class HistogramDemo
        Inherits ChartDemoModuleWithOptions

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            FillIntervalDivisionModeComboBox()
            FillChartTypes()
            AddData()
            ColorizeSeries()
            radioGroup1.SelectedIndex = 0
            comboBoxEdit1.SelectedIndex = 1
            trackBar1.Value = 5
            trackBar2.Value = 80
            trackBar3.Value = 3
        End Sub

        Private Sub AddData()
            Dim random As NonCryptographicRandom = TutorialConstants.Random
            Dim points As List(Of SimpleDataPoint()) = New List(Of SimpleDataPoint())() From {PointGenerator.GenerateCluster(random, random.Next(20, 70), random.Next(120, 180), random.Next(0, 10), random.Next(70, 120), 2000), PointGenerator.GenerateCluster(random, random.Next(0, 10), random.Next(70, 120), random.Next(40, 80), random.Next(160, 200), 2000), PointGenerator.GenerateCluster(random, random.Next(60, 100), random.Next(160, 200), random.Next(40, 80), random.Next(160, 200), 2000)}
            For i As Integer = 0 To points.Count - 1
                CType(chart.Series(i * 2).DataAdapter, DataSourceAdapter).DataSource = points(i)
                CType(chart.Series(i * 2 + 1).DataAdapter, DataSourceAdapter).DataSource = points(i)
            Next
        End Sub

        Private Sub ColorizeSeries()
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(3)
            For i As Integer = 0 To chart.Series.Count - 1
                chart.Series(i).View.Color = Color.FromArgb(100, paletteEntries(i \ 2).Color)
            Next
        End Sub

        Private Sub FillIntervalDivisionModeComboBox()
            comboBoxEdit1.Properties.Items.AddRange(New List(Of IntervalDivisionMode)() From {IntervalDivisionMode.Auto, IntervalDivisionMode.Width, IntervalDivisionMode.Count})
        End Sub

        Private Sub FillChartTypes()
            Dim items As RadioGroupItemCollection = radioGroup1.Properties.Items
            items.Add(New RadioGroupItem(ViewType.RangeBar, "Range Bar"))
            items.Add(New RadioGroupItem(ViewType.SplineArea, "Spline Area"))
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            ColorizeSeries()
        End Sub

        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chart Is Nothing Then Return
            Dim mode As IntervalDivisionMode = CType(comboBoxEdit1.EditValue, IntervalDivisionMode)
            CType(chart.Diagram, XYDiagram).SecondaryAxesX(0).NumericScaleOptions.IntervalOptions.DivisionMode = mode
            Select Case mode
                Case IntervalDivisionMode.Auto
                    layoutControlGroup3.Enabled = False
                    layoutControlGroup4.Enabled = False
                Case IntervalDivisionMode.Width
                    layoutControlGroup3.Enabled = True
                    layoutControlGroup4.Enabled = False
                Case IntervalDivisionMode.Count
                    layoutControlGroup3.Enabled = False
                    layoutControlGroup4.Enabled = True
                Case Else
                    Throw New NotSupportedException()
            End Select
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim newViewType As ViewType = CType(radioGroup1.Properties.Items(radioGroup1.SelectedIndex).Value, ViewType)
            For i As Integer = 1 To chart.Series.Count - 1 Step 2
                Dim series As Series = chart.Series(i)
                series.ChangeView(newViewType)
                Dim rangeSeriesView As BarSeriesView = TryCast(series.View, BarSeriesView)
                If rangeSeriesView IsNot Nothing Then
                    rangeSeriesView.BarWidth = 1
                    series.CrosshairLabelPattern = "{A}: {V2}"
                Else
                    series.CrosshairLabelPattern = "{A}: {V}"
                End If
            Next
        End Sub

        Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim width As Double = trackBar1.Value
            CType(chart.Diagram, XYDiagram).SecondaryAxesX(0).NumericScaleOptions.IntervalOptions.Width = width
        End Sub

        Private Sub trackBar2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim count As Integer = trackBar2.Value
            CType(chart.Diagram, XYDiagram).SecondaryAxesX(0).NumericScaleOptions.IntervalOptions.Count = count
        End Sub

        Private Sub trackBar3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim count As Integer = trackBar3.Value
            For i As Integer = 0 To chart.Series.Count - 1
                chart.Series(i).Visible = count * 2 > i
            Next
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddData()
        End Sub
    End Class
End Namespace
