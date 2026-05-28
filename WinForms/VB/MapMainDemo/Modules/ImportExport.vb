Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraMap.Demos

    Public Partial Class ImportExport
        Inherits MapTutorialControl

        Const PoliticalToolTipPattern As String = "{NAME}"

        Const GdpToolTipPattern As String = "{NAME}: ${GDP_MD_EST:#,0}M"

        Const PopulationToolTipPattern As String = "{NAME}: {POP_EST:#,##0,,}M"

        Private politicalColorizerField As ChoroplethColorizer

        Private gdpColorizerField As ChoroplethColorizer

        Private populationColorizerField As ChoroplethColorizer

        Private gdpLegendField As ColorScaleLegend

        Private populationLegendField As ColorListLegend

        Private legendAlignment As LegendAlignment

        Private ReadOnly Property PoliticalColorizer As ChoroplethColorizer
            Get
                If politicalColorizerField Is Nothing Then politicalColorizerField = CreatePoliticalColorizer()
                Return politicalColorizerField
            End Get
        End Property

        Private ReadOnly Property GdpColorizer As ChoroplethColorizer
            Get
                If gdpColorizerField Is Nothing Then gdpColorizerField = CreateGDPColorizer()
                Return gdpColorizerField
            End Get
        End Property

        Private ReadOnly Property PopulationColorizer As ChoroplethColorizer
            Get
                If populationColorizerField Is Nothing Then populationColorizerField = CreatePopulationColorizer()
                Return populationColorizerField
            End Get
        End Property

        Private ReadOnly Property GdpLegend As ColorScaleLegend
            Get
                If gdpLegendField Is Nothing Then gdpLegendField = CreateGDPLegend()
                Return gdpLegendField
            End Get
        End Property

        Private ReadOnly Property PopulationLegend As ColorListLegend
            Get
                If populationLegendField Is Nothing Then populationLegendField = CreatePopulationLegend()
                Return populationLegendField
            End Get
        End Property

        Private Property Legend As ItemsLayerLegend
            Get
                Return If(MapControl.Legends.Count > 0, CType(MapControl.Legends(0), ItemsLayerLegend), Nothing)
            End Get

            Set(ByVal value As ItemsLayerLegend)
                If MapControl.Legends.Count > 0 Then MapControl.Legends.RemoveAt(0)
                If value IsNot Nothing Then MapControl.Legends.Add(value)
            End Set
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ShapefileDataAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp")
            chkGDP.Checked = True
        End Sub

        Private Function CreatePoliticalColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New List(Of Double) From {0, 9})
            colorizer.PredefinedColorSchema = PredefinedColorSchema.Palette
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "MAP_COLOR"}
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private Function CreateGDPColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New List(Of Double) From {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000})
            Dim colors As List(Of Color) = New List(Of Color) From {Color.FromArgb(&H5F, &H8B, &H95), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75), Color.FromArgb(&HCE, &HBB, &H5F), Color.FromArgb(&HF2, &HCB, &H4E), Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HBA, &H4D, &H51)}
            colorizer.ColorItems.AddRange(GetColorItems(colors))
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private Function GetColorItems(ByVal colors As List(Of Color)) As GenericColorizerItemCollection(Of ColorizerColorItem)
            Dim result As GenericColorizerItemCollection(Of ColorizerColorItem) = New GenericColorizerItemCollection(Of ColorizerColorItem)()
            result.BeginUpdate()
            Try
                For Each color As Color In colors
                    result.Add(New ColorizerColorItem(color))
                Next
            Finally
                result.EndUpdate()
            End Try

            Return result
        End Function

        Private Function CreateGDPLegend() As ColorScaleLegend
            Dim legend As ColorScaleLegend = New ColorScaleLegend()
            legend.Header = "GDP by Countries"
            legend.Description = "In US dollars"
            legend.RangeStopsFormat = "0,B"
            legend.Layer = FileLayer
            Return legend
        End Function

        Private Function CreatePopulationColorizer() As ChoroplethColorizer
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New List(Of Double) From {0, 1000000, 2000000, 5000000, 10000000, 25000000, 50000000, 100000000, 1000000000, 1500000000})
            colorizer.PredefinedColorSchema = PredefinedColorSchema.Gradient
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "POP_EST"}
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private Function CreatePopulationLegend() As ColorListLegend
            Dim legend As ColorListLegend = New ColorListLegend()
            legend.RangeStopsFormat = "0,,M"
            legend.Header = ""
            legend.Description = ""
            legend.Layer = FileLayer
            Return legend
        End Function

        Private Sub UpdateMapColorizer(ByVal colorizer As MapColorizer, ByVal toolTipPattern As String)
            FileLayer.Colorizer = colorizer
            FileLayer.ToolTipPattern = toolTipPattern
            UpdateLegendAligment()
        End Sub

        Private Sub UpdateMapLegend(ByVal legend As ItemsLayerLegend)
            Me.Legend = legend
        End Sub

        Private Sub MapMode_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If chkPolitical.Checked Then
                UpdateMapLegend(Nothing)
                UpdateMapColorizer(PoliticalColorizer, PoliticalToolTipPattern)
            ElseIf chkGDP.Checked Then
                UpdateMapLegend(GdpLegend)
                UpdateMapColorizer(GdpColorizer, GdpToolTipPattern)
            Else
                UpdateMapLegend(PopulationLegend)
                UpdateMapColorizer(PopulationColorizer, PopulationToolTipPattern)
            End If

            bbLegendAlignment.Enabled = FileLayer.Colorizer IsNot PoliticalColorizer
        End Sub

        Private Function GetLegendAlignment(ByVal value As String) As LegendAlignment
            Dim alignment As LegendAlignment
            [Enum].TryParse(value, alignment)
            Return alignment
        End Function

        Private Sub UpdateLegendAligment()
            Dim choroplethColorizer As ChoroplethColorizer = TryCast(FileLayer.Colorizer, ChoroplethColorizer)
            If choroplethColorizer IsNot Nothing AndAlso Legend IsNot Nothing Then
                Legend.Alignment = legendAlignment
            End If
        End Sub

        Private Sub Export_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            btnExportShape.Caption = "Export Shapes To " & e.Item.Caption
            btnExportShape.Tag = e.Item.Tag
        End Sub

        Private Sub btnExportShape_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim format As String = CStr(btnExportShape.Tag)
            saveFileDialog1.Filter = String.Format("{0} files (*.{1})|*.{1}", format.ToUpper(), format)
            saveFileDialog1.FileName = String.Empty
            If saveFileDialog1.ShowDialog() <> DialogResult.OK Then Return
            Select Case format
                Case "shp"
                    FileLayer.ExportToShp(saveFileDialog1.FileName, New ShpExportOptions() With {.ExportToDbf = True, .ShapeType = ShapeType.Polygon})
                Case "kml"
                    FileLayer.ExportToKml(saveFileDialog1.FileName)
                Case "svg"
                    FileLayer.ExportToSvg(saveFileDialog1.FileName)
            End Select

            XtraMessageBox.Show(ParentForm, String.Format("Shapes successfully exported to {0} file", saveFileDialog1.FileName), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub ddLegendAligment_GalleryItemClick(ByVal sender As Object, ByVal e As Ribbon.GalleryItemClickEventArgs)
            legendAlignment = GetLegendAlignment(e.Item.Caption)
            UpdateLegendAligment()
        End Sub

        Protected Overrides Function CreateMiniMapLayer() As MiniMapLayerBase
            Dim adapter As ShapefileDataAdapter = New ShapefileDataAdapter() With {.FileUri = DemoUtils.GetFileUri("Countries.shp")}
            Return New MiniMapVectorItemsLayer() With {.Data = adapter}
        End Function
    End Class
End Namespace
