Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Data.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SwiftPointDemo
        Inherits ChartDemoModule

        Const PointsCount As Integer = 100000

        Private ReadOnly data As IList(Of Point)

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            data = GenerateData()
            chart.Series(0).BindToData(data, "X", "Y")
            chart.Series(0).View.Color = Color.FromArgb(100, chart.GetPaletteEntries(1)(0).Color)
        End Sub

        Private Function GenerateData() As List(Of Point)
            Dim data As List(Of Point) = New List(Of Point)(PointsCount)
            Dim random As NonCryptographicRandom = New NonCryptographicRandom(0)
            Dim value As Double
            Dim square, price, maxValue, minValue As Integer
            For i As Integer = 0 To PointsCount - 1
                value = random.NextDouble()
                value =(Math.Pow(value, 15) + 1.2) * Math.Pow(value, 0.2) / 2.2
                maxValue = If(random.Next(10) = 1, CInt((random.NextDouble() * 2000 + 4000)), random.Next(1000) + 4500)
                minValue = If(random.Next(11) = 10, 400, 600)
                square = CInt(value * maxValue + minValue)
                If random.Next(800 - square \ 10) = 1 Then
                    maxValue = CInt((3000000 * (random.NextDouble() + 1)))
                Else
                    maxValue = 3 * CInt((Math.Pow(value, 2) + 0.5) * Math.Pow(value, 0.2) * 670000)
                End If

                value = random.NextDouble()
                minValue = If(random.Next(11) = 10, 400000, 200000)
                price = CInt(value * maxValue + minValue)
                If price > 2000000 * (0.2 * random.NextDouble() + 1) AndAlso square < random.Next(1000) + 3500 Then square += random.Next(2000)
                If price > 3000000 * (0.2 * random.NextDouble() + 1) Then square += random.Next(2000)
                data.Add(New Point(square, price))
            Next

            Return data
        End Function
    End Class
End Namespace
