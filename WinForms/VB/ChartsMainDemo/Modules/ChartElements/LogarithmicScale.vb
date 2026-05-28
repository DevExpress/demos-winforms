Namespace DevExpress.XtraCharts.Demos

    Public Partial Class LogarithmicScaleDemo
        Inherits ChartDemoModule

        Private ReadOnly headphone1Spl90 As Series

        Private ReadOnly headphone1Spl100 As Series

        Private ReadOnly headphone2Spl90 As Series

        Private ReadOnly headphone2Spl100 As Series

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            headphone1Spl90 = ChartControl.Series("Headphones 1 90 dB SPL")
            headphone1Spl100 = ChartControl.Series("Headphones 1 100 dB SPL")
            headphone2Spl90 = ChartControl.Series("Headphones 2 90 dB SPL")
            headphone2Spl100 = ChartControl.Series("Headphones 2 100 dB SPL")
            headphone1Spl90.SetDataMembers("Frequency", "Spl90Db")
            headphone1Spl100.SetDataMembers("Frequency", "Spl100Db")
            headphone2Spl90.SetDataMembers("Frequency", "Spl90Db")
            headphone2Spl100.SetDataMembers("Frequency", "Spl100Db")
            headphone1Spl90.FilterString = "[HeadphonesName] = 'Headphones 1'"
            headphone1Spl100.FilterString = "[HeadphonesName] = 'Headphones 1'"
            headphone2Spl90.FilterString = "[HeadphonesName] = 'Headphones 2'"
            headphone2Spl100.FilterString = "[HeadphonesName] = 'Headphones 2'"
            ChartControl.DataSource = HeadphoneComparisonDataReader.ReadDataFromFile()
            ColorizeSeries()
            ChartControl.EndInit()
        End Sub

        Private Sub ColorizeSeries()
            Dim palette As Palette = ChartControl.PaletteRepository(ChartControl.PaletteName)
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(palette.Count + 2)
            headphone1Spl90.View.Color = paletteEntries(0).Color
            headphone1Spl100.View.Color = paletteEntries(palette.Count).Color
            headphone2Spl90.View.Color = paletteEntries(1).Color
            headphone2Spl100.View.Color = paletteEntries(palette.Count + 1).Color
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            ColorizeSeries()
        End Sub
    End Class
End Namespace
