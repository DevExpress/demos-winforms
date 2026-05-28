using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraMap.Demos {
    public partial class MapEditorDemo : FooteredMapTutorialControl {
        static readonly Font TitleFont = new Font(AppearanceObject.DefaultFont.FontFamily, 10, FontStyle.Regular);
        readonly MapEditorOverlayManager overlayManager = new MapEditorOverlayManager();
        readonly Dictionary<Type, long> itemIndexes = new Dictionary<Type, long>();

        MapEditor Editor { get { return MapControl.MapEditor; } }

        protected override MapOverlay[] Overlays { get { return MapControl.Overlays.ToArray(); } }
        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }

        public override MapControl MapControl { get { return mapControl1; } }

        public MapEditorDemo() {
            InitializeComponent();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
            Editor.SetEditMode();
            Editor.MapItemCreating += OnMapItemCreating;
            InitializePlanData();
        }

        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }

        void InitializePlanData() {
            kmlFileDataAdapter1.FileUri = DemoUtils.GetFileUri("Hotels\\hotelmap.kml");
            Editor.ActiveLayer = vectorItemsLayer1;
        }
        void OnOverlaysArranged(object sender, OverlaysArrangedEventArgs e) {
            overlayManager.ArrangeOverlays(ScaleDPI, e.OverlayArrangements, new Size(fillEdit.Width + fillEdit.Margin.Right, fillEdit.Height));
            mapControl1.BeginInvoke(new Action<Point, Point>((Point fillLocation, Point strokeLocation) => {
                fillEdit.Location = fillLocation;
                strokeEdit.Location = strokeLocation;
            }), overlayManager.FillEditLocation, overlayManager.StrokeEditLocation);
        }
        void OnMapItemCreating(object sender, MapItemCreatingEventArgs e) {
            e.Item.Attributes.Add(new MapItemAttribute() { Name = "name", Value = GenerateName(e.Item) });
            ApplyColors(e.Item);
        }
        string GenerateName(MapItem item) {
            Type itemType = item.GetType();
            if(!itemIndexes.ContainsKey(itemType))
                itemIndexes[itemType] = 0;
            return string.Format("{0} {1}", itemType.Name, (++itemIndexes[itemType]).ToString());
        }
        void ApplyColors(MapItem item) {
            item.Fill = fillEdit.Color;
            item.Stroke = strokeEdit.Color;
        }
        void OnItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            e.Items[0].IsHitTestVisible = false;
            Editor.ActiveItems = new MapItem[] { e.Items[50] };
            Editor.ClearSavedActions();
        }
        void OnExportBarButtonItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            Export();
        }
        void Export() {
            using(XtraSaveFileDialog dialog = new XtraSaveFileDialog()) {
                dialog.Filter = "KML files|*.kml";
                dialog.CreatePrompt = true;
                dialog.OverwritePrompt = true;
                if(dialog.ShowDialog() == DialogResult.OK) {
                    Editor.ActiveLayer.ExportToKml(dialog.FileName);
                    XtraMessageBox.Show(ParentForm, string.Format("Items successfully exported to {0} file", dialog.FileName), "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void OnCustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            e.DisplayText = string.Empty;
        }
        void OnColorEditValueChanged(object sender, EventArgs e) {
            foreach(MapItem item in Editor.ActiveItems)
                ApplyColors(item);
        }
        void BeforeShowToolTip(object sender, ToolTipControllerShowEventArgs e) {
            MapShape mapShape = e.SelectedObject as MapShape;
            if(mapShape != null)
                e.SuperTip = ObtainShapeToolTip(e.ToolTip, mapShape);
        }
        SuperToolTip ObtainShapeToolTip(string title, MapShape shape) {
            return shape is MapDot ? CreateDotToolTip(title, shape as MapDot) :
                    CreateShapeToolTip(title, shape);
        }
        SuperToolTip CreateShapeToolTip(string title, MapShape shape) {
            SuperToolTip toolTip = new SuperToolTip() { MaxWidth = 350 };
            ToolTipTitleItem titleItem = new ToolTipTitleItem() { Text = title, Font = TitleFont };
            titleItem.Appearance.ForeColor = shape.Fill;
            double perimeter = Math.Round(GeoUtils.CalculateStrokeLength(shape), 3);
            double area = Math.Round(GeoUtils.CalculateArea(shape), 3);
            ToolTipItem perimeterItem = new ToolTipItem() { Text = perimeter.ToString() + " m" };
            perimeterItem.ImageOptions.ImageToTextDistance = 0;
            perimeterItem.ImageOptions.Image = DemoUtils.GetPerimeterImage(perimeterItem.Font.Height);
            ToolTipItem areaItem = new ToolTipItem() { Text = area.ToString() + " m\xB2" };
            areaItem.ImageOptions.ImageToTextDistance = 0;
            areaItem.ImageOptions.Image = DemoUtils.GetAreaImage(areaItem.Font.Height);
            toolTip.Items.Add(titleItem);
            toolTip.Items.Add(perimeterItem);
            toolTip.Items.Add(areaItem);
            return toolTip;
        }
        SuperToolTip CreateDotToolTip(string title, MapDot item) {
            SuperToolTip toolTip = new SuperToolTip() { MaxWidth = 350 };
            ToolTipTitleItem titleItem = new ToolTipTitleItem() { Text = title, Font = TitleFont };
            titleItem.Appearance.ForeColor = item.Fill;
            ToolTipItem diameterItem = new ToolTipItem() { Text = string.Format("{0} px", (int)item.Size) };
            diameterItem.ImageOptions.ImageToTextDistance = 0;
            diameterItem.ImageOptions.Image = DemoUtils.GetDiameterImage(diameterItem.Font.Height);
            toolTip.Items.Add(titleItem);
            toolTip.Items.Add(diameterItem);
            return toolTip;
        }
    }
}
