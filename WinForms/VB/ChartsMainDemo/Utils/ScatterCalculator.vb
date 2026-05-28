Imports System
Imports System.Collections.Generic

Namespace DevExpress.XtraCharts.Demos

    Friend MustInherit Class ScatterFunctionCalculatorBase

        Const archimedeanSpiralIndex As Integer = 0

        Const polarRoseIndex As Integer = 1

        Const polarFoliumIndex As Integer = 2

        Const spiralIntervalsCount As Integer = 72

        Const roseIntervalsCount As Integer = 288

        Const foliumSegmentIntervalsCount As Integer = 30

        Const roseParameter As Double = 7.0 / 4.0

        Const foliumDistanceLimit As Double = 3.0

        Protected MustOverride Function NormalizeAngle(ByVal angle As Double) As Double

        Protected MustOverride Function ToRadian(ByVal angle As Double) As Double

        Protected MustOverride Function FromDegrees(ByVal angle As Double) As Double

        Private Function FilterPointsByRange(ByVal points As List(Of SeriesPoint), ByVal min As Double, ByVal max As Double) As List(Of SeriesPoint)
            Dim resultPoints As List(Of SeriesPoint) = New List(Of SeriesPoint)()
            For Each point As SeriesPoint In points
                Dim pointValue As Double = point.Values(0)
                If pointValue <= max AndAlso pointValue >= min Then resultPoints.Add(point)
            Next

            Return resultPoints
        End Function

        Private Sub CreatePolarFunctionPoints(ByVal minAngleDegree As Double, ByVal maxAngleDegree As Double, ByVal intervalsCount As Integer, ByVal [function] As Func(Of Double, Double), ByVal points As List(Of SeriesPoint))
            Dim minAngle As Double = FromDegrees(minAngleDegree)
            Dim maxAngle As Double = FromDegrees(maxAngleDegree)
            Dim angleStep As Double =(maxAngle - minAngle) / intervalsCount
            For pointIndex As Integer = 0 To intervalsCount
                Dim angle As Double = minAngle + pointIndex * angleStep
                Dim angleRadians As Double = ToRadian(angle)
                Dim distance As Double = [function](angleRadians)
                Dim normalAngle As Double = NormalizeAngle(angle)
                points.Add(New SeriesPoint(normalAngle, distance))
            Next
        End Sub

        Private Function ArchimedeanSpiralFunction(ByVal angleRadians As Double) As Double
            Return angleRadians
        End Function

        Private Function PolarRoseFunction(ByVal angleRadians As Double) As Double
            Return Math.Max(0.0, Math.Sin(roseParameter * angleRadians))
        End Function

        Private Function PolarFoliumFunction(ByVal angleRadians As Double) As Double
            Dim sin As Double = Math.Sin(angleRadians)
            Dim cos As Double = Math.Cos(angleRadians)
            Return 3.0 * sin * cos / (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0))
        End Function

        Friend Function GenerateScatterFunctionPoints(ByVal index As Integer) As SeriesPoint()
            Dim points As List(Of SeriesPoint) = New List(Of SeriesPoint)()
            Select Case index
                Case archimedeanSpiralIndex
                    CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, New Func(Of Double, Double)(AddressOf ArchimedeanSpiralFunction), points)
                Case polarRoseIndex
                    CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, New Func(Of Double, Double)(AddressOf PolarRoseFunction), points)
                Case polarFoliumIndex
                    CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, New Func(Of Double, Double)(AddressOf PolarFoliumFunction), points)
                    CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, New Func(Of Double, Double)(AddressOf PolarFoliumFunction), points)
                    CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, New Func(Of Double, Double)(AddressOf PolarFoliumFunction), points)
                    points = FilterPointsByRange(points, 0.0, foliumDistanceLimit)
            End Select

            Return points.ToArray()
        End Function
    End Class

    Friend Class RadianScatterFunctionCalculator
        Inherits ScatterFunctionCalculatorBase

        Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
            Return angle Mod Math.PI * 2.0
        End Function

        Protected Overrides Function ToRadian(ByVal angle As Double) As Double
            Return angle
        End Function

        Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
            Return angle * Math.PI / 180.0
        End Function
    End Class

    Friend Class DegreeScatterFunctionCalculator
        Inherits ScatterFunctionCalculatorBase

        Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
            Return angle Mod 360
        End Function

        Protected Overrides Function ToRadian(ByVal angle As Double) As Double
            Return angle * Math.PI / 180.0
        End Function

        Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
            Return angle
        End Function
    End Class
End Namespace
