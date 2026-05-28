Imports System
Imports System.Data
Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Public Partial Class HeatMap
        Inherits FooteredMapTutorialControl

        Private ReadOnly Property Adapter As HeatmapDataSourceAdapter
            Get
                Return CType(heatmapProvider1.PointSource, HeatmapDataSourceAdapter)
            End Get
        End Property

        Private Property ActualColorizer As ChoroplethColorizer
            Get
                Return heatmapProvider1.Colorizer
            End Get

            Set(ByVal value As ChoroplethColorizer)
                heatmapProvider1.Colorizer = value
            End Set
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            tabPaneOptions.AllowCollapse = Utils.DefaultBoolean.True
            paletteRadioGroup.SelectedIndex = 1
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim xmlDataSet As DataSet = New DataSet("XML DataSet")
            xmlDataSet.ReadXml(DemoUtils.GetRelativePath("Earthquakes.xml"))
            Adapter.DataSource = xmlDataSet.Tables("Row")
        End Sub

        Private Sub OnLegendItemCreating(ByVal sender As Object, ByVal e As LegendItemCreatingEventArgs)
            Dim endIndex As Integer = If(ActualColorizer IsNot Nothing, ActualColorizer.ColorItems.Count - 1, 3)
            If e.Index = 0 Then
                e.Item.Text = "low"
            ElseIf e.Index = endIndex Then
                e.Item.Text = "high"
            Else
                e.Item.Text = " "
            End If
        End Sub

        Private Sub OnTrackBarControlEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(heatmapProvider1.Algorithm, HeatmapDensityBasedAlgorithm).PointRadius = CInt(mfTrackBarControl1.EditValue)
        End Sub

        Private Sub OnPaletteTypeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ActualColorizer = ObtainColorizer(paletteRadioGroup.SelectedIndex)
        End Sub

        Private Function ObtainColorizer(ByVal index As Integer) As ChoroplethColorizer
            Select Case index
                Case 1
                    Return CreateHotColorizer()
                Case 2
                    Return CreateColdColorizer()
                Case Else
                    Return Nothing
            End Select
        End Function

        Private Function CreateHotColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New Double() {0.1, 0.2, 0.7, 1})
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(50, 128, 255, 0)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 255, 255, 0)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 234, 72, 58)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 162, 36, 25)))
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private Function CreateColdColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New Double() {0, 0.2, 0.4, 0.6, 0.8, 1})
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(0, 33, 102, 172)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 103, 169, 207)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 209, 229, 240)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 253, 219, 199)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 239, 138, 98)))
            colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(255, 178, 24, 43)))
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub
    End Class
End Namespace
