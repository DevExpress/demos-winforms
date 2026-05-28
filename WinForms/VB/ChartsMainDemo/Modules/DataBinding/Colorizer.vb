Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ColorizerDemo
        Inherits ChartDemoModule

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim series As Series = ChartControl.Series(0)
            Dim rangeColorizer As RangeColorizer = New RangeColorizer()
            rangeColorizer.RangeStops.AddRange(New Double() {22, 30, 38, 46, 54, 64})
            rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI"
            rangeColorizer.PaletteName = "ColorizerPalette"
            series.View.Colorizer = rangeColorizer
            CType(series.DataAdapter, DataSourceAdapter).DataSource = HpiDataReader.GetData()
        End Sub
    End Class
End Namespace
