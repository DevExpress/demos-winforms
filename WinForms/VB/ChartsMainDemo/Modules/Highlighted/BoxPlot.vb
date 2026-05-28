Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Data.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class BoxPlotDemo
        Inherits ChartDemoModuleWithOptions

        Const InitialResultCount As Integer = 25

        Const MeasurementsCount As Integer = 500

        Const InitialArgumentCount As Integer = 7

        Const SecondPointSeriesArgumentOffset As Double = 2R

        Const StripWidth As Double = 0.5R

        Private ReadOnly random As NonCryptographicRandom = New NonCryptographicRandom(3)

        Private ReadOnly currentExperimentRandomPoints1 As ObservableCollection(Of PointData) = New ObservableCollection(Of PointData)()

        Private ReadOnly currentExperimentRandomPoints2 As ObservableCollection(Of PointData) = New ObservableCollection(Of PointData)()

        Private ReadOnly experimentResults1 As ObservableCollection(Of BoxPlotPoint) = New ObservableCollection(Of BoxPlotPoint)()

        Private ReadOnly experimentResults2 As ObservableCollection(Of BoxPlotPoint) = New ObservableCollection(Of BoxPlotPoint)()

        Private randomValues1 As List(Of Double)

        Private randomValues2 As List(Of Double)

        Private experimentNumber As Integer = 0

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return TryCast(ChartControl.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return boxPlotChart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Diagram.EnableAxisXScrolling = True
            Diagram.EnableAxisXZooming = True
            SetDataSource(ChartControl.Series(0), experimentResults1)
            SetDataSource(ChartControl.Series(1), experimentResults2)
            SetDataSource(ChartControl.Series(2), currentExperimentRandomPoints1)
            SetDataSource(ChartControl.Series(3), currentExperimentRandomPoints2)
            ColorizeSeries()
            GenerateInitialResults()
            AxisX.StickToEdge = True
            AxisX.WholeRange.SideMarginsValue = 0.5
            AxisX.VisualRange.SideMarginsValue = 0.5
            Dim min As Long = experimentNumber - InitialArgumentCount
            AxisX.VisualRange.SetMinMaxValues(min, experimentNumber)
            ChartControl.CrosshairOptions.GroupHeaderPattern = "Experiment {A}"
            boxPlotChart.Animate()
        End Sub

        Private Sub SetDataSource(ByVal series As Series, ByVal dataSource As Object)
            CType(series.DataAdapter, DataSourceAdapter).DataSource = dataSource
        End Sub

        Private Sub GenerateInitialResults()
            For i As Integer = InitialResultCount - 1 To 0 + 1 Step -1
                Dim randomValues1 As List(Of Double) = GenerateRandomSequence(random, MeasurementsCount)
                Dim randomValues2 As List(Of Double) = GenerateRandomSequence(random, MeasurementsCount)
                experimentNumber += 1
                Dim point1 As BoxPlotPoint = New BoxPlotPoint(experimentNumber, randomValues1)
                Dim point2 As BoxPlotPoint = New BoxPlotPoint(experimentNumber, randomValues2)
                experimentResults1.Add(point1)
                experimentResults2.Add(point2)
            Next

            randomValues1 = GenerateRandomSequence(random, MeasurementsCount)
            randomValues2 = GenerateRandomSequence(random, MeasurementsCount)
            For i As Integer = 0 To MeasurementsCount - 1
                currentExperimentRandomPoints1.Add(New PointData(randomValues1(i), random))
                currentExperimentRandomPoints2.Add(New PointData(randomValues2(i), random, SecondPointSeriesArgumentOffset))
            Next

            experimentNumber += 1
            experimentResults1.Add(New BoxPlotPoint(experimentNumber, randomValues1))
            experimentResults2.Add(New BoxPlotPoint(experimentNumber, randomValues2))
            UpdateStripAndCustomLabel()
        End Sub

        Private Sub BtnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            sbGenerate.Enabled = False
            DisableBoxPlotAnimations()
            currentExperimentRandomPoints1.Clear()
            currentExperimentRandomPoints2.Clear()
            randomValues1 = GenerateRandomSequence(random, MeasurementsCount)
            randomValues2 = GenerateRandomSequence(random, MeasurementsCount)
            For i As Integer = 0 To MeasurementsCount - 1
                currentExperimentRandomPoints1.Add(New PointData(randomValues1(i), random))
                currentExperimentRandomPoints2.Add(New PointData(randomValues2(i), random, SecondPointSeriesArgumentOffset))
            Next

            experimentNumber += 1
            UpdateStripAndCustomLabel()
            boxPlotChart.Animate()
        End Sub

        Private Sub BoxPlotChart_AnimationEnded(ByVal sender As Object, ByVal e As EventArgs)
            If randomValues1 Is Nothing OrElse randomValues2 Is Nothing Then Return
            experimentResults1.Add(New BoxPlotPoint(experimentNumber, randomValues1))
            experimentResults2.Add(New BoxPlotPoint(experimentNumber, randomValues2))
            sbGenerate.Enabled = True
        End Sub

        Private Sub cheShowMeanLine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each series As Series In ChartControl.Series
                Dim view As BoxPlotSeriesView = TryCast(series.View, BoxPlotSeriesView)
                If view IsNot Nothing Then view.MeanLineVisible = cheShowMeanLine.Checked
            Next
        End Sub

        Private Sub UpdateStripAndCustomLabel()
            If AxisX Is Nothing Then Return
            AxisX.Strips.Clear()
            Dim strip As Strip = New Strip() With {.ShowInLegend = False}
            strip.MinLimit.AxisValue = experimentNumber - StripWidth
            strip.MaxLimit.AxisValue = experimentNumber + StripWidth
            AxisX.Strips.Add(strip)
            AxisX.CustomLabels.Clear()
            Dim label As CustomAxisLabel = New CustomAxisLabel() With {.Name = "Current Experiment", .AxisValue = experimentNumber}
            AxisX.CustomLabels.Add(label)
        End Sub

        Private Sub ColorizeSeries()
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(2)
            If ChartControl.Series.Count < 4 Then Return
            ChartControl.Series(2).View.Color = Color.FromArgb(100, paletteEntries(0).Color)
            ChartControl.Series(3).View.Color = Color.FromArgb(100, paletteEntries(1).Color)
        End Sub

        Private Sub DisableBoxPlotAnimations()
            If ChartControl.Series.Count > 1 Then
                Dim boxPlot1 As BoxPlotSeriesView = TryCast(ChartControl.Series(0).View, BoxPlotSeriesView)
                Dim boxPlot2 As BoxPlotSeriesView = TryCast(ChartControl.Series(1).View, BoxPlotSeriesView)
                If boxPlot1 IsNot Nothing AndAlso boxPlot2 IsNot Nothing Then
                    boxPlot1.Animation.Enabled = False
                    boxPlot2.Animation.Enabled = False
                End If
            End If
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            ColorizeSeries()
        End Sub
    End Class

    Public Class PointData

        Private _Argument As Double, _Value As Double

        Public Property Argument As Double
            Get
                Return _Argument
            End Get

            Private Set(ByVal value As Double)
                _Argument = value
            End Set
        End Property

        Public Property Value As Double
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Double)
                _Value = value
            End Set
        End Property

        Public Sub New(ByVal val As Double, ByVal rnd As NonCryptographicRandom, ByVal Optional argumentOffset As Double = 0)
            Argument = rnd.NextDouble() + argumentOffset
            Value = val
        End Sub
    End Class

    Public Class BoxPlotPoint

        Private _ExperimentNumber As Integer, _Min As Double, _Quartile1 As Double, _Median As Double, _Quartile3 As Double, _Max As Double, _Mean As Double, _Outliers As List(Of Double)

        Public Property ExperimentNumber As Integer
            Get
                Return _ExperimentNumber
            End Get

            Private Set(ByVal value As Integer)
                _ExperimentNumber = value
            End Set
        End Property

        Public Property Min As Double
            Get
                Return _Min
            End Get

            Private Set(ByVal value As Double)
                _Min = value
            End Set
        End Property

        Public Property Quartile1 As Double
            Get
                Return _Quartile1
            End Get

            Private Set(ByVal value As Double)
                _Quartile1 = value
            End Set
        End Property

        Public Property Median As Double
            Get
                Return _Median
            End Get

            Private Set(ByVal value As Double)
                _Median = value
            End Set
        End Property

        Public Property Quartile3 As Double
            Get
                Return _Quartile3
            End Get

            Private Set(ByVal value As Double)
                _Quartile3 = value
            End Set
        End Property

        Public Property Max As Double
            Get
                Return _Max
            End Get

            Private Set(ByVal value As Double)
                _Max = value
            End Set
        End Property

        Public Property Mean As Double
            Get
                Return _Mean
            End Get

            Private Set(ByVal value As Double)
                _Mean = value
            End Set
        End Property

        Public Property Outliers As List(Of Double)
            Get
                Return _Outliers
            End Get

            Private Set(ByVal value As List(Of Double))
                _Outliers = value
            End Set
        End Property

        Public Sub New(ByVal currentExperimentNumber As Integer, ByVal randomSequence As List(Of Double))
            ExperimentNumber = currentExperimentNumber
            Dim quartiles As Tuple(Of Double, Double, Double) = CalculateQuartiles(randomSequence)
            Quartile1 = quartiles.Item1
            Quartile3 = quartiles.Item3
            Median = quartiles.Item2
            Dim averageAndMinMax As Tuple(Of Double, Double, Double) = CalculateAverageAndMinMax(randomSequence)
            Mean = averageAndMinMax.Item1
            Min = Math.Max(averageAndMinMax.Item2, Quartile1 - 1.5 * (Quartile3 - Quartile1))
            Max = Math.Min(averageAndMinMax.Item3, Quartile3 + 1.5 * (Quartile3 - Quartile1))
            Outliers = randomSequence.Where(Function(d) d > Max OrElse d < Min).ToList()
        End Sub

        Private Function CalculateAverageAndMinMax(ByVal randomSequence As List(Of Double)) As Tuple(Of Double, Double, Double)
            Dim average As Double = 0
            Dim min As Double = Double.MaxValue
            Dim max As Double = Double.MinValue
            For Each d As Double In randomSequence
                average += d
                If d > max Then max = d
                If d < min Then min = d
            Next

            average = average / randomSequence.Count
            Return New Tuple(Of Double, Double, Double)(average, min, max)
        End Function

        Private Function CalculateQuartiles(ByVal randomSequence As List(Of Double)) As Tuple(Of Double, Double, Double)
            randomSequence.Sort()
            Dim middleIndex As Integer = randomSequence.Count \ 2 'for correct vb conversion
            Dim quartile1 As Double = 0
            Dim quartile2 As Double
            Dim quartile3 As Double = 0
            If randomSequence.Count Mod 2 = 0 Then
                quartile2 =(randomSequence(middleIndex - 1) + randomSequence(middleIndex)) / 2
                Dim middleIndexOfHalf As Integer = middleIndex \ 2
                If middleIndex Mod 2 = 0 Then
                    quartile1 =(randomSequence(middleIndexOfHalf - 1) + randomSequence(middleIndexOfHalf)) / 2
                    quartile3 =(randomSequence(middleIndex + middleIndexOfHalf - 1) + randomSequence(middleIndex + middleIndexOfHalf)) / 2
                Else
                    quartile1 = randomSequence(middleIndexOfHalf)
                    quartile3 = randomSequence(middleIndexOfHalf + middleIndex)
                End If
            ElseIf randomSequence.Count = 1 Then
                quartile1 = randomSequence(0)
                quartile2 = randomSequence(0)
                quartile3 = randomSequence(0)
            Else
                quartile2 = randomSequence(middleIndex)
                If(randomSequence.Count - 1) Mod 4 = 0 Then
                    Dim quarterIndex As Integer =(randomSequence.Count - 1) \ 4 'for correct vb conversion
                    quartile1 = randomSequence(quarterIndex - 1) * .25 + randomSequence(quarterIndex) * .75
                    quartile3 = randomSequence(3 * quarterIndex) * .75 + randomSequence(3 * quarterIndex + 1) * .25
                ElseIf(randomSequence.Count - 3) Mod 4 = 0 Then
                    Dim quarterIndex As Integer =(randomSequence.Count - 3) \ 4 'for correct vb conversion;
                    quartile1 = randomSequence(quarterIndex) * .75 + randomSequence(quarterIndex + 1) * .25
                    quartile3 = randomSequence(3 * quarterIndex + 1) * .25 + randomSequence(3 * quarterIndex + 2) * .75
                End If
            End If

            Return New Tuple(Of Double, Double, Double)(quartile1, quartile2, quartile3)
        End Function
    End Class

    Friend Module RandomSequenceGenerator

        Public Function GenerateRandomSequence(ByVal random As NonCryptographicRandom, ByVal length As Integer) As List(Of Double)
            Dim selector As Double = random.NextDouble()
            If selector < 0.33 Then Return GenerateExponentialDistribution(random, length)
            If selector < 0.66 Then
                Return GenerateSpecialDistribution(random, length)
            Else
                Return GenerateNormalDistribution(random, length)
            End If
        End Function

        Private Function GenerateNormalDistribution(ByVal random As NonCryptographicRandom, ByVal length As Integer) As List(Of Double)
            Dim list As List(Of Double) = New List(Of Double)(length)
            'Box-Muller transform
            Dim mean As Double = random.Next(450, 550)
            Dim stdDev As Double = random.Next(50, 70)
            For i As Integer = 0 To length - 1
                Dim u1 As Double = 1.0 - random.NextDouble()
                Dim u2 As Double = 1.0 - random.NextDouble()
                Dim randStdNormal As Double = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2)
                list.Add(mean + stdDev * randStdNormal)
            Next

            Return list
        End Function

        Private Function GenerateExponentialDistribution(ByVal random As NonCryptographicRandom, ByVal length As Integer) As List(Of Double)
            Dim list As List(Of Double) = New List(Of Double)(length)
            Dim minVal As Double = random.Next(250, 300)
            Dim maxVal As Double = minVal + 300
            Dim generatedCount As Integer = 0
            Dim lambda As Double = random.NextDouble() * 2
            While generatedCount < length
                Dim u As Double = random.NextDouble()
                Dim t As Double = -Math.Log(u) / lambda
                Dim increment As Double =(maxVal - minVal) / 6.0
                Dim result As Double = minVal + t * increment
                If result < maxVal Then
                    list.Add(result)
                    generatedCount += 1
                End If
            End While

            Return list
        End Function

        Private Function GenerateSpecialDistribution(ByVal random As NonCryptographicRandom, ByVal length As Integer) As List(Of Double)
            Dim list As List(Of Double) = New List(Of Double)(length)
            Dim min As Integer = random.Next(100, 250)
            Dim [step] As Integer = random.Next(30, 70)
            For i As Integer = 0 To CInt(length * 0.05) - 1
                list.Add(random.Next(min, min + [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.025) - 1
                list.Add(random.Next(min + [step] + 1, min + 2 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.075) - 1
                list.Add(random.Next(min + 2 * [step] + 1, min + 3 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.10) - 1
                list.Add(random.Next(min + 3 * [step] + 1, min + 4 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.20) - 1
                list.Add(random.Next(min + 4 * [step] + 1, min + 5 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.30) - 1
                list.Add(random.Next(min + 5 * [step] + 1, min + 6 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.20) - 1
                list.Add(random.Next(min + 6 * [step] + 1, min + 7 * [step]))
            Next

            For i As Integer = 0 To CInt(length * 0.05) + 1 - 1
                list.Add(random.Next(min + 7 * [step] + 1, min + 8 * [step]))
            Next

            Return list
        End Function
    End Module
End Namespace
