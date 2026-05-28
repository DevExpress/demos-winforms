namespace DevExpress.XtraMap.Demos {
    public partial class MapArrows : MapTutorialControl {
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopRight; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public MapArrows() {
            InitializeComponent();
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("Countries.shp");
            InitWindDataAdapter();
        }
        void InitWindDataAdapter() {
            listSourceDataAdapter1.DataSource = MapArrowsDemoHelper.LoadItems();
            listSourceDataAdapter1.PropertyMappings.Add(new MapLinePoint1XMapping() { Member = "Longitude1" });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLinePoint1YMapping() { Member = "Latitude1" });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLinePoint2XMapping() { Member = "Longitude2" });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLinePoint2YMapping() { Member = "Latitude2" });
            listSourceDataAdapter1.PropertyMappings.Add(new MapItemStrokeWidthMapping() { DefaultValue = 2 });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLineEndCapVisibleMapping() { DefaultValue = true });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLineEndCapLengthMapping() { DefaultValue = 12 });
            listSourceDataAdapter1.PropertyMappings.Add(new MapLineEndCapWidthMapping() { DefaultValue = 6 });
            listSourceDataAdapter1.AttributeMappings.Add(new MapItemAttributeMapping("Speed", "Speed"));
        }
    }
}
