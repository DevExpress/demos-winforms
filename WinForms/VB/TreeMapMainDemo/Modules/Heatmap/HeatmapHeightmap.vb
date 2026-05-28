Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts.Heatmap
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapHeightmap
        Inherits DevExpress.XtraTreeMap.Demos.TreeMapDemoModuleWithOptions

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return Me.heatmapControl1
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.SetDataAdapter()
            Me.InitializeColorizers()
        End Sub

        Private Sub SetDataAdapter()
            Dim image As System.Drawing.Bitmap = New System.Drawing.Bitmap(DevExpress.XtraTreeMap.Demos.Utils.GetRelativePath("Heightmap.jpg"))
            Dim matrix As Double(,) = New Double(image.Height - 1, image.Width - 1) {}
            For i As Integer = 0 To image.Height - 1
                For j As Integer = 0 To image.Width - 1
                    matrix(i, j) = image.GetPixel(CInt((j)), CInt((i))).ToArgb()
                Next
            Next

            Me.heatmapControl1.DataAdapter = New DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter() With {.XArguments = DevExpress.XtraTreeMap.Demos.HeatmapDataSourceGenerator.GetArray(image.Width), .YArguments = DevExpress.XtraTreeMap.Demos.HeatmapDataSourceGenerator.GetArray(image.Height), .Values = matrix}
        End Sub

        Private Sub InitializeColorizers()
            Dim palette As DevExpress.XtraCharts.Palette = New DevExpress.XtraCharts.Palette("Heightmap") From {System.Drawing.Color.FromArgb(105, 168, 204), System.Drawing.Color.FromArgb(125, 205, 168), System.Drawing.Color.FromArgb(180, 224, 149), System.Drawing.Color.FromArgb(253, 204, 138), System.Drawing.Color.FromArgb(251, 167, 86), System.Drawing.Color.FromArgb(225, 123, 49), System.Drawing.Color.FromArgb(199, 73, 25), System.Drawing.Color.FromArgb(180, 43, 1)}
            Me.colorizerComboBox.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem(2) {New DevExpress.XtraEditors.Controls.RadioGroupItem(Me.CreateRangeStopColorProvider(palette, False), "Range"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Me.CreateRangeStopColorProvider(palette, True), "Approximated Range"), New DevExpress.XtraEditors.Controls.RadioGroupItem(New DevExpress.XtraCharts.Heatmap.HeatmapObjectColorProvider(), "Object")})
            Me.colorizerComboBox.SelectedIndex = 0
        End Sub

        Private Function CreateRangeStopColorProvider(ByVal palette As DevExpress.XtraCharts.Palette, ByVal approximateColors As Boolean) As HeatmapRangeColorProvider
            Dim rangeColorProvider As DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider() With {.Palette = palette, .ApproximateColors = approximateColors}
            For i As Integer = 0 To 6
                rangeColorProvider.RangeStops.Add(New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop(0.14 * i, DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage))
            Next

            rangeColorProvider.RangeStops.Add(New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop(1, DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage))
            Return rangeColorProvider
        End Function

        Private Sub ColorizerComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.heatmapControl1.ColorProvider = CType(Me.colorizerComboBox.EditValue, DevExpress.XtraCharts.Heatmap.HeatmapColorProviderBase)
        End Sub

        Private Sub navigationCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim navigationEnable As Boolean = Me.navigationCheckEdit.Checked
            Me.heatmapControl1.EnableAxisXZooming = navigationEnable
            Me.heatmapControl1.EnableAxisYZooming = navigationEnable
            Me.heatmapControl1.EnableAxisXScrolling = navigationEnable
            Me.heatmapControl1.EnableAxisYScrolling = navigationEnable
        End Sub
    End Class
End Namespace
