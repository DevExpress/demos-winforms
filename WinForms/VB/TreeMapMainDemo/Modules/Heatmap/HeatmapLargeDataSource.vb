Imports System
Imports DevExpress.XtraCharts.Heatmap

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapLargeDataSource
        Inherits TreeMapTutorialControl

        Private ReadOnly dataGenerator As HeatmapDataSourceGenerator

        Private ReadOnly Property DataAdapter As HeatmapMatrixAdapter
            Get
                Return CType(heatmapControl1.DataAdapter, HeatmapMatrixAdapter)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            dataGenerator = New HeatmapDataSourceGenerator()
            heatmapControl1.DataAdapter = New HeatmapMatrixAdapter() With {.XArguments = HeatmapDataSourceGenerator.GetArray(HeatmapDataSourceGenerator.SizeX), .YArguments = HeatmapDataSourceGenerator.GetArray(HeatmapDataSourceGenerator.SizeY)}
            timer1.Interval = 100
            timer1.Start()
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If Visible Then
                DataAdapter.Values = dataGenerator.GetMatrix()
            End If
        End Sub
    End Class
End Namespace
