Imports System
Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Public Partial Class AzureMapsProvider
        Inherits DevExpress.XtraMap.Demos.FooteredMapTutorialControl

        Private Shared Function InitMapDataProvider(ByVal tileset As DevExpress.XtraMap.AzureTileset) As AzureMapDataProvider
            Dim tilesetProvider As DevExpress.XtraMap.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider() With {.Tileset = tileset}
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(tilesetProvider)
            Return tilesetProvider
        End Function

        Private baseTilesetLayer As DevExpress.XtraMap.ImageLayer

        Private additionalTilesetLayer As DevExpress.XtraMap.ImageLayer

        Private weatherTilesetLayer As DevExpress.XtraMap.ImageLayer

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DevExpress.XtraMap.Demos.DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DevExpress.XtraMap.Demos.DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControlField
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.baseTilesetLayer = CType(Me.MapControl.Layers(0), DevExpress.XtraMap.ImageLayer)
            Me.baseTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.Imagery)
            Me.UpdateAdditionalTilesetAppearance()
        End Sub

        Private Sub RemoveImageLayer(ByVal layer As DevExpress.XtraMap.ImageLayer)
            If layer Is Nothing Then Return
            Me.mapControlField.Layers.Remove(layer)
        End Sub

        Private Sub UpdateAdditionalTilesetAppearance()
            If Me.additionalLayersRadio.EditValue.Equals("None") Then
                Me.RemoveImageLayer(Me.additionalTilesetLayer)
                Me.additionalTilesetLayer = Nothing
            Else
                If Me.additionalTilesetLayer Is Nothing Then
                    Dim idx As Integer = If(Not Me.chkShowTerrain.Checked, 1, 2)
                    Me.additionalTilesetLayer = New DevExpress.XtraMap.ImageLayer()
                    Me.mapControlField.Layers.Insert(idx, Me.additionalTilesetLayer)
                End If

                If Me.additionalLayersRadio.EditValue.Equals("Hybrid Road") Then
                    If Me.appearanceRadio.EditValue.Equals("Light") Then
                        Me.additionalTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseHybridRoad)
                    Else
                        Me.additionalTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseHybridDarkgrey)
                    End If
                ElseIf Me.additionalLayersRadio.EditValue.Equals("Labels") Then
                    If Me.appearanceRadio.EditValue.Equals("Light") Then
                        Me.additionalTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseLabelsRoad)
                    Else
                        Me.additionalTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseLabelsDarkgrey)
                    End If
                End If
            End If
        End Sub

        Private Sub UpdateRoadTilesetAppearance()
            Me.RemoveImageLayer(Me.additionalTilesetLayer)
            Me.additionalTilesetLayer = Nothing
            If Me.appearanceRadio.EditValue.Equals("Light") Then
                Me.baseTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseRoad)
            Else
                Me.baseTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.BaseDarkGrey)
            End If
        End Sub

        Private Sub mapStyleRadio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.mapStyleRadio.EditValue.Equals("Satellite") Then
                Me.additionalLayersGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.baseTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.Imagery)
                Me.UpdateAdditionalTilesetAppearance()
            Else
                Me.additionalLayersGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.UpdateRoadTilesetAppearance()
            End If
        End Sub

        Private Sub chkShowTerrain_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.chkShowTerrain.Checked Then
                Dim imageLayer As DevExpress.XtraMap.ImageLayer = New DevExpress.XtraMap.ImageLayer() With {.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.TerraMain)}
                Me.mapControlField.Layers.Insert(1, imageLayer)
            Else
                Me.mapControlField.Layers.RemoveAt(1)
            End If
        End Sub

        Private Sub appearanceRadio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.mapStyleRadio.EditValue.Equals("Satellite") Then
                Me.UpdateAdditionalTilesetAppearance()
            Else
                Me.UpdateRoadTilesetAppearance()
            End If
        End Sub

        Private Sub additionalLayersRadio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateAdditionalTilesetAppearance()
        End Sub

        Private Sub weatherLayersRadio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.weatherLayersRadio.EditValue.Equals("None") Then
                Me.RemoveImageLayer(Me.weatherTilesetLayer)
                Me.weatherTilesetLayer = Nothing
            Else
                If Me.weatherTilesetLayer Is Nothing Then
                    Dim idx As Integer = If(Not Me.chkShowTerrain.Checked, 1, 2)
                    If Me.additionalTilesetLayer IsNot Nothing Then idx += 1
                    Me.weatherTilesetLayer = New DevExpress.XtraMap.ImageLayer()
                    Me.mapControlField.Layers.Insert(idx, Me.weatherTilesetLayer)
                End If

                If Me.weatherLayersRadio.EditValue.Equals("Radar") Then
                    Me.weatherTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.WeatherRadarMain)
                Else
                    Me.weatherTilesetLayer.DataProvider = DevExpress.XtraMap.Demos.AzureMapsProvider.InitMapDataProvider(DevExpress.XtraMap.AzureTileset.WeatherInfraredMain)
                End If
            End If
        End Sub
    End Class
End Namespace
