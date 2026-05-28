using DevExpress.XtraBars.Ribbon;
using System.Drawing;
namespace DevExpress.XtraMap.Demos {
    partial class BubbleCharts {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
            OnDispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem4 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping3 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping4 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping5 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping6 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MeasureRules measureRules1 = new DevExpress.XtraMap.MeasureRules();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.MapItemAttributeValueProvider mapItemAttributeValueProvider1 = new DevExpress.XtraMap.MapItemAttributeValueProvider();
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend1 = new DevExpress.XtraMap.ColorScaleLegend();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.BubbleChartDataAdapter = new DevExpress.XtraMap.BubbleChartDataAdapter();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.rpgDecadeFilter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            this.rpgMagniduteFilter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRangeTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar();
            this.rpgMarkerKind = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRangeTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(938, 139);
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDecadeFilter,
            this.rpgMagniduteFilter,
            this.rpgMarkerKind});
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(106))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))), ((int)(((byte)(217))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(116))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(103)))), ((int)(((byte)(191)))), ((int)(((byte)(88))))));
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            colorizerKeyItem1.Key = "0";
            colorizerKeyItem1.Name = "1960-1969";
            colorizerKeyItem2.Key = "1";
            colorizerKeyItem2.Name = "1970-1979";
            colorizerKeyItem3.Key = "2";
            colorizerKeyItem3.Name = "1980-1989";
            colorizerKeyItem4.Key = "3";
            colorizerKeyItem4.Name = "1990-1999";
            keyColorColorizer1.Keys.Add(colorizerKeyItem1);
            keyColorColorizer1.Keys.Add(colorizerKeyItem2);
            keyColorColorizer1.Keys.Add(colorizerKeyItem3);
            keyColorColorizer1.Keys.Add(colorizerKeyItem4);
            this.ItemsLayer.Colorizer = keyColorColorizer1;
            this.ItemsLayer.Data = this.BubbleChartDataAdapter;
            this.ItemsLayer.Name = "ItemsLayer";
            this.ItemsLayer.ToolTipPattern = "Date: {Date:d}\nMagnitude: {Magnitude}\nDepth: {Depth}km";
            mapItemAttributeMapping1.Member = "day";
            mapItemAttributeMapping1.Name = "Day";
            mapItemAttributeMapping2.Member = "mon";
            mapItemAttributeMapping2.Name = "Month";
            mapItemAttributeMapping3.Member = "yr";
            mapItemAttributeMapping3.Name = "Year";
            mapItemAttributeMapping4.Member = "mag";
            mapItemAttributeMapping4.Name = "Magnitude";
            mapItemAttributeMapping5.Member = "dep";
            mapItemAttributeMapping5.Name = "Depth";
            mapItemAttributeMapping6.Member = "Date";
            mapItemAttributeMapping6.Name = "Date";
            mapItemAttributeMapping6.ValueType = DevExpress.XtraMap.FieldValueType.DateTime;
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3);
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping4);
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping5);
            this.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping6);
            this.BubbleChartDataAdapter.ItemMaxSize = 60;
            this.BubbleChartDataAdapter.ItemMinSize = 10;
            this.BubbleChartDataAdapter.Mappings.BubbleGroup = "Type";
            this.BubbleChartDataAdapter.Mappings.Latitude = "glat";
            this.BubbleChartDataAdapter.Mappings.Longitude = "glon";
            this.BubbleChartDataAdapter.Mappings.Value = "mag";
            measureRules1.ApproximateValues = true;
            measureRules1.RangeDistribution = linearRangeDistribution1;
            measureRules1.RangeStops.Add(6D);
            measureRules1.RangeStops.Add(7D);
            measureRules1.RangeStops.Add(8D);
            measureRules1.RangeStops.Add(9D);
            measureRules1.RangeStops.Add(10D);
            mapItemAttributeValueProvider1.AttributeName = "Magnitude";
            measureRules1.ValueProvider = mapItemAttributeValueProvider1;
            this.BubbleChartDataAdapter.MeasureRules = measureRules1;
            this.TilesLayer.DataProvider = this.AzureMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            sizeLegend1.Header = "Magnitude";
            sizeLegend1.Layer = this.ItemsLayer;
            sizeLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible;
            colorScaleLegend1.Header = "Years";
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.mapControl1.Legends.Add(sizeLegend1);
            this.mapControl1.Legends.Add(colorScaleLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 139);
            this.mapControl1.MaxZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(938, 426);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 2D;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // rpgDecadeFilter
            // 
            this.rpgDecadeFilter.ItemLinks.Add(this.barCheckItem1);
            this.rpgDecadeFilter.ItemLinks.Add(this.barCheckItem2);
            this.rpgDecadeFilter.ItemLinks.Add(this.barCheckItem3);
            this.rpgDecadeFilter.ItemLinks.Add(this.barCheckItem4);
            this.rpgDecadeFilter.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.rpgDecadeFilter.Name = "rpgDecadeFilter";
            this.rpgDecadeFilter.Text = "Filter by Decade";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.BindableChecked = true;
            this.barCheckItem1.Caption = "1960-1969";
            this.barCheckItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.Id = 19;
            this.barCheckItem1.ItemAppearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.barCheckItem1.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_CheckedChanged);
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.BindableChecked = true;
            this.barCheckItem2.Caption = "1970-1979";
            this.barCheckItem2.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barCheckItem2.Checked = true;
            this.barCheckItem2.Id = 20;
            this.barCheckItem2.Name = "barCheckItem2";
            this.barCheckItem2.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_CheckedChanged);
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.BindableChecked = true;
            this.barCheckItem3.Caption = "1980-1989";
            this.barCheckItem3.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barCheckItem3.Checked = true;
            this.barCheckItem3.Id = 21;
            this.barCheckItem3.Name = "barCheckItem3";
            this.barCheckItem3.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_CheckedChanged);
            // 
            // barCheckItem4
            // 
            this.barCheckItem4.BindableChecked = true;
            this.barCheckItem4.Caption = "1990-1999";
            this.barCheckItem4.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barCheckItem4.Checked = true;
            this.barCheckItem4.Id = 22;
            this.barCheckItem4.Name = "barCheckItem4";
            this.barCheckItem4.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_CheckedChanged);
            // 
            // rpgMagniduteFilter
            // 
            this.rpgMagniduteFilter.ItemLinks.Add(this.barEditItem2);
            this.rpgMagniduteFilter.Name = "rpgMagniduteFilter";
            this.rpgMagniduteFilter.Text = "Filter by Magnitude";
            // 
            // barEditItem2
            // 
            this.barEditItem2.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barEditItem2.Edit = this.repositoryItemRangeTrackBar1;
            this.barEditItem2.EditHeight = 60;
            this.barEditItem2.EditWidth = 120;
            this.barEditItem2.Id = 29;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemRangeTrackBar1
            // 
            this.repositoryItemRangeTrackBar1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.repositoryItemRangeTrackBar1.Appearance.Options.UseBorderColor = true;
            this.repositoryItemRangeTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemRangeTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemRangeTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "7";
            trackBarLabel1.Value = 70;
            trackBarLabel2.Label = "8";
            trackBarLabel2.Value = 80;
            trackBarLabel3.Label = "9";
            trackBarLabel3.Value = 90;
            this.repositoryItemRangeTrackBar1.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3});
            this.repositoryItemRangeTrackBar1.Maximum = 96;
            this.repositoryItemRangeTrackBar1.Minimum = 65;
            this.repositoryItemRangeTrackBar1.Name = "repositoryItemRangeTrackBar1";
            this.repositoryItemRangeTrackBar1.ShowLabels = true;
            this.repositoryItemRangeTrackBar1.TickFrequency = 5;
            this.repositoryItemRangeTrackBar1.EditValueChanged += new System.EventHandler(this.repositoryItemRangeTrackBar1_EditValueChanged);
            // 
            // rpgMarkerKind
            // 
            this.rpgMarkerKind.ItemLinks.Add(this.barEditItem1);
            this.rpgMarkerKind.Name = "rpgMarkerKind";
            this.rpgMarkerKind.Text = "Marker Type";
            // 
            // barEditItem1
            // 
            this.barEditItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.EditValue = "Circle";
            this.barEditItem1.EditWidth = 125;
            this.barEditItem1.Id = 28;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.DropDownRows = 12;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Diamond",
            "Triangle",
            "InvertedTriangle",
            "Plus",
            "Cross",
            "Star5",
            "Star6",
            "Star8",
            "Pentagon",
            "Hexagon"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // BubbleCharts
            // 
            this.Appearance.Options.UseFont = true;
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "BubbleCharts";
            this.Size = new System.Drawing.Size(938, 565);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRangeTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private Utils.ToolTipController toolTipController1;
        private XtraBars.BarCheckItem barCheckItem1;
        private XtraBars.BarCheckItem barCheckItem2;
        private XtraBars.BarCheckItem barCheckItem3;
        private XtraBars.BarCheckItem barCheckItem4;
        private XtraBars.Ribbon.RibbonPageGroup rpgDecadeFilter;
        private XtraBars.Ribbon.RibbonPageGroup rpgMarkerKind;
        private XtraBars.BarEditItem barEditItem1;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private XtraBars.Ribbon.RibbonPageGroup rpgMagniduteFilter;
        private XtraBars.BarEditItem barEditItem2;
        private XtraEditors.Repository.RepositoryItemRangeTrackBar repositoryItemRangeTrackBar1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private BubbleChartDataAdapter BubbleChartDataAdapter;
        private AzureMapDataProvider AzureMapDataProvider;
    }
}
