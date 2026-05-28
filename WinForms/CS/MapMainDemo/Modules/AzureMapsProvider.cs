using System;
using System.Drawing;

namespace DevExpress.XtraMap.Demos {
    public partial class AzureMapsProvider : FooteredMapTutorialControl {
        static AzureMapDataProvider InitMapDataProvider(AzureTileset tileset) {
            AzureMapDataProvider tilesetProvider = new AzureMapDataProvider() {
                Tileset = tileset,
            };
            DemoUtils.SetAzureMapDataProviderKey(tilesetProvider);
            return tilesetProvider;
        }

        ImageLayer baseTilesetLayer;
        ImageLayer additionalTilesetLayer;
        ImageLayer weatherTilesetLayer;

        protected override Image CopyrightImage => DemoUtils.AzureLogo;
        protected override string CopyrightText => DemoUtils.AzureCopyright;
        public override MapControl MapControl => mapControl;

        public AzureMapsProvider() {
            InitializeComponent();
            baseTilesetLayer = (ImageLayer)MapControl.Layers[0];
            baseTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.Imagery);
            UpdateAdditionalTilesetAppearance();
        }
        void RemoveImageLayer(ImageLayer layer) {
            if(layer == null)
                return;
            mapControl.Layers.Remove(layer);
        }
        void UpdateAdditionalTilesetAppearance() {
            if(additionalLayersRadio.EditValue.Equals("None")) {
                RemoveImageLayer(additionalTilesetLayer);
                additionalTilesetLayer = null;
            }
            else {
                if(additionalTilesetLayer == null) {
                    int idx = !chkShowTerrain.Checked ? 1 : 2;
                    additionalTilesetLayer = new ImageLayer();
                    mapControl.Layers.Insert(idx, additionalTilesetLayer);
                }
                if(additionalLayersRadio.EditValue.Equals("Hybrid Road")) {
                    if(appearanceRadio.EditValue.Equals("Light"))
                        additionalTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseHybridRoad);
                    else
                        additionalTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseHybridDarkgrey);
                }
                else if(additionalLayersRadio.EditValue.Equals("Labels")) {
                    if(appearanceRadio.EditValue.Equals("Light"))
                        additionalTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseLabelsRoad);
                    else
                        additionalTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseLabelsDarkgrey);
                }
            }
        }
        void UpdateRoadTilesetAppearance() {
            RemoveImageLayer(additionalTilesetLayer);
            additionalTilesetLayer = null;
            if(appearanceRadio.EditValue.Equals("Light"))
                baseTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseRoad);
            else
                baseTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.BaseDarkGrey);
        }

        void mapStyleRadio_SelectedIndexChanged(object sender, EventArgs e) {
            if(mapStyleRadio.EditValue.Equals("Satellite")) {
                additionalLayersGroup.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
                baseTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.Imagery);
                UpdateAdditionalTilesetAppearance();
            }
            else {
                additionalLayersGroup.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                UpdateRoadTilesetAppearance();
            }
        }
        void chkShowTerrain_CheckedChanged(object sender, EventArgs e) {
            if(chkShowTerrain.Checked) {
                ImageLayer imageLayer = new ImageLayer() {
                    DataProvider = InitMapDataProvider(AzureTileset.TerraMain),
                };
                mapControl.Layers.Insert(1, imageLayer);
            }
            else
                mapControl.Layers.RemoveAt(1);

        }
        void appearanceRadio_SelectedIndexChanged(object sender, EventArgs e) {
            if(mapStyleRadio.EditValue.Equals("Satellite"))
                UpdateAdditionalTilesetAppearance();
            else
                UpdateRoadTilesetAppearance();
        }
        void additionalLayersRadio_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateAdditionalTilesetAppearance();
        }
        void weatherLayersRadio_SelectedIndexChanged(object sender, EventArgs e) {
            if(weatherLayersRadio.EditValue.Equals("None")) {
                RemoveImageLayer(weatherTilesetLayer);
                weatherTilesetLayer = null;
            }
            else {
                if(weatherTilesetLayer == null) {
                    int idx = !chkShowTerrain.Checked ? 1 : 2;
                    if(additionalTilesetLayer != null)
                        idx += 1;
                    weatherTilesetLayer = new ImageLayer();
                    mapControl.Layers.Insert(idx, weatherTilesetLayer);
                }
                if(weatherLayersRadio.EditValue.Equals("Radar"))
                    weatherTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.WeatherRadarMain);
                else
                    weatherTilesetLayer.DataProvider = InitMapDataProvider(AzureTileset.WeatherInfraredMain);
            }

        }
    }
}
