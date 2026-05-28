Imports System

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class RangeControlIntegrationDemo
        Inherits ChartDemoModule

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisBase
            Get
                Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
            End Get
        End Property

        Private ReadOnly Property SeriesGbpUsd As Series
            Get
                Return chart.Series("GBPUSD")
            End Get
        End Property

        Private ReadOnly Property SeriesEurUsd As Series
            Get
                Return chart.Series("EURUSD")
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            SeriesGbpUsd.DataSource = ReadFinancialData("GBPUSDDaily.csv")
            SeriesEurUsd.DataSource = ReadFinancialData("EURUSDDaily.csv")
            ChartControl.EndInit()
            Dim offset As TimeSpan = New TimeSpan(366 * 2, 0, 0, 0)
            AxisX.VisualRange.SetMinMaxValues(CDate(AxisX.VisualRange.MaxValue) - offset, CDate(AxisX.VisualRange.MaxValue))
        End Sub

        Private Sub chart_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            Dim elementIndex As Integer = 0
            For Each crosshairGroup As CrosshairElementGroup In e.CrosshairElementGroups
                For Each crosshairElement As CrosshairElement In crosshairGroup.CrosshairElements
                    Dim labelElement As CrosshairLabelElement = crosshairElement.LabelElement
                    labelElement.MarkerSize = New System.Drawing.Size(0, 0)
                    labelElement.MarkerVisible = False
                    labelElement.TextColor = chart.PaletteRepository(chart.PaletteName)(elementIndex).Color
                    elementIndex += 1
                Next
            Next
        End Sub
    End Class
End Namespace
