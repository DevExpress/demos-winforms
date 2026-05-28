namespace DevExpress.StockMarketTrader {
    partial class StockChartUC {
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
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel1 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.CandleStickSeriesView candleStickSeriesView1 = new DevExpress.XtraCharts.CandleStickSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.CandleStickSeriesView candleStickSeriesView2 = new DevExpress.XtraCharts.CandleStickSeriesView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.chartFinancialSeriesOptionsBar1 = new DevExpress.XtraCharts.UI.ChartFinancialSeriesBar();
            this.stockChart = new DevExpress.XtraCharts.ChartControl();
            this.changeSeriesViewBarItem1 = new DevExpress.XtraCharts.UI.ChangeSeriesViewBarItem();
            this.changeSeriesViewRepositoryItemComboBox1 = new DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox();
            this.volumesBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.chartCommandBarCheckItem1 = new DevExpress.XtraCharts.UI.DrawTrendLineIndicatorBarItem();
            this.chartCommandBarCheckItem2 = new DevExpress.XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem();
            this.chartCommandBarCheckItem3 = new DevExpress.XtraCharts.UI.DrawFibonacciFansIndicatorBarItem();
            this.chartCommandBarCheckItem4 = new DevExpress.XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem();
            this.chartCommandBarCheckItem5 = new DevExpress.XtraCharts.UI.RemoveIndicatorBarItem();
            this.addChartIndicatorBarItem1 = new DevExpress.XtraCharts.UI.AddIndicatorBarItem();
            this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
            this.barStaticItemPeriod = new DevExpress.XtraBars.BarStaticItem();
            this.comboBoxBarEditItem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBoxPeriod = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.selectSeriesRepositoryItemComboBox1 = new DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox();
            this.chartBarController1 = new DevExpress.XtraCharts.UI.ChartBarController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(candleStickSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(candleStickSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeSeriesViewRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.chartFinancialSeriesOptionsBar1});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.volumesBarCheckItem,
            this.barCheckItem3,
            this.barCheckItem4,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barCheckItem7,
            this.barStaticItemPeriod,
            this.comboBoxBarEditItem,
            this.chartCommandBarCheckItem1,
            this.chartCommandBarCheckItem2,
            this.chartCommandBarCheckItem3,
            this.chartCommandBarCheckItem4,
            this.addChartIndicatorBarItem1,
            this.chartCommandBarCheckItem5,
            this.changeSeriesViewBarItem1});
            this.barManager1.MaxItemId = 66;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxPeriod,
            this.selectSeriesRepositoryItemComboBox1,
            this.changeSeriesViewRepositoryItemComboBox1});
            // 
            // chartFinancialSeriesOptionsBar1
            // 
            this.chartFinancialSeriesOptionsBar1.Control = this.stockChart;
            this.chartFinancialSeriesOptionsBar1.DockCol = 0;
            this.chartFinancialSeriesOptionsBar1.DockRow = 0;
            this.chartFinancialSeriesOptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.chartFinancialSeriesOptionsBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.changeSeriesViewBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.volumesBarCheckItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.chartCommandBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.chartCommandBarCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.chartCommandBarCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.chartCommandBarCheckItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.chartCommandBarCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.addChartIndicatorBarItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem7),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.barStaticItemPeriod, "Period:", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.comboBoxBarEditItem, "", false, true, true, 79)});
            this.chartFinancialSeriesOptionsBar1.OptionsBar.AllowQuickCustomization = false;
            this.chartFinancialSeriesOptionsBar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.chartFinancialSeriesOptionsBar1.OptionsBar.DisableCustomization = true;
            this.chartFinancialSeriesOptionsBar1.OptionsBar.DrawDragBorder = false;
            // 
            // stockChart
            // 
            this.stockChart.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.stockChart.AutoLayout = false;
            this.stockChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.stockChart.CrosshairOptions.ShowOnlyInFocusedPane = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "0";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            customAxisLabel1.AxisValueSerializable = "1";
            customAxisLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            customAxisLabel1.Name = "$1,0";
            xyDiagram1.AxisY.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel1});
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisY.Label.TextPattern = "${V:F1}";
            xyDiagram1.AxisY.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom;
            xyDiagram1.AxisY.Title.Text = "";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.DefaultPane.LayoutOptions.RowSpan = 2;
            xyDiagram1.PaneDistance = 5;
            xyDiagramPane1.Name = "Volume Pane";
            xyDiagramPane1.PaneID = 0;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1});
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.GridLines.MinorVisible = true;
            secondaryAxisY1.GridLines.Visible = true;
            secondaryAxisY1.Label.TextPattern = "{V:F1}M";
            secondaryAxisY1.Name = "Volume Axis";
            secondaryAxisY1.VisibleInPanesSerializable = "0";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.stockChart.Diagram = xyDiagram1;
            this.stockChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.stockChart.Legend.Margins.Bottom = 10;
            this.stockChart.Legend.Margins.Left = 10;
            this.stockChart.Legend.Margins.Right = 10;
            this.stockChart.Legend.Margins.Top = 10;
            this.stockChart.Legend.Name = "Default Legend";
            this.stockChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            legend1.DockTargetName = "Volume Pane";
            legend1.Margins.Bottom = 10;
            legend1.Margins.Left = 10;
            legend1.Margins.Right = 10;
            legend1.Margins.Top = 10;
            legend1.Name = "Volume Legend";
            this.stockChart.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.stockChart.Location = new System.Drawing.Point(0, 24);
            this.stockChart.Name = "stockChart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "Price";
            candleStickSeriesView1.LevelLineLength = 0.3D;
            candleStickSeriesView1.LineThickness = 1;
            series1.View = candleStickSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.CrosshairLabelPattern = "{S} : {V}M";
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Label = sideBySideBarSeriesLabel1;
            series2.LegendName = "Volume Legend";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Volume";
            sideBySideBarSeriesView1.AxisYName = "Volume Axis";
            sideBySideBarSeriesView1.BarWidth = 0.8D;
            sideBySideBarSeriesView1.PaneName = "Volume Pane";
            series2.View = sideBySideBarSeriesView1;
            this.stockChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.stockChart.SeriesTemplate.View = candleStickSeriesView2;
            this.stockChart.SideBySideBarDistanceFixed = 0;
            this.stockChart.Size = new System.Drawing.Size(1157, 512);
            this.stockChart.TabIndex = 5;
            this.stockChart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.stockChart_BoundDataChanged);
            // 
            // changeSeriesViewBarItem1
            // 
            this.changeSeriesViewBarItem1.Edit = this.changeSeriesViewRepositoryItemComboBox1;
            this.changeSeriesViewBarItem1.EditWidth = 100;
            this.changeSeriesViewBarItem1.Id = 61;
            this.changeSeriesViewBarItem1.Name = "changeSeriesViewBarItem1";
            this.changeSeriesViewBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.changeSeriesViewBarItem1.UseCommandCaption = true;
            // 
            // changeSeriesViewRepositoryItemComboBox1
            // 
            this.changeSeriesViewRepositoryItemComboBox1.AutoHeight = false;
            this.changeSeriesViewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.changeSeriesViewRepositoryItemComboBox1.Items.AddRange(new object[] {
            DevExpress.XtraCharts.ViewType.Stock,
            DevExpress.XtraCharts.ViewType.CandleStick});
            this.changeSeriesViewRepositoryItemComboBox1.Name = "changeSeriesViewRepositoryItemComboBox1";
            this.changeSeriesViewRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // volumesBarCheckItem
            // 
            this.volumesBarCheckItem.BindableChecked = true;
            this.volumesBarCheckItem.Caption = "Volume";
            this.volumesBarCheckItem.Checked = true;
            this.volumesBarCheckItem.Id = 2;
            this.volumesBarCheckItem.Name = "volumesBarCheckItem";
            this.volumesBarCheckItem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowVolumeChartChanged);
            // 
            // chartCommandBarCheckItem1
            // 
            this.chartCommandBarCheckItem1.Id = 49;
            this.chartCommandBarCheckItem1.Name = "chartCommandBarCheckItem1";
            // 
            // chartCommandBarCheckItem2
            // 
            this.chartCommandBarCheckItem2.Id = 50;
            this.chartCommandBarCheckItem2.Name = "chartCommandBarCheckItem2";
            this.chartCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // chartCommandBarCheckItem3
            // 
            this.chartCommandBarCheckItem3.Id = 51;
            this.chartCommandBarCheckItem3.Name = "chartCommandBarCheckItem3";
            this.chartCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // chartCommandBarCheckItem4
            // 
            this.chartCommandBarCheckItem4.Id = 52;
            this.chartCommandBarCheckItem4.Name = "chartCommandBarCheckItem4";
            this.chartCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // chartCommandBarCheckItem5
            // 
            this.chartCommandBarCheckItem5.Id = 54;
            this.chartCommandBarCheckItem5.Name = "chartCommandBarCheckItem5";
            this.chartCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // addChartIndicatorBarItem1
            // 
            this.addChartIndicatorBarItem1.DropDownControl = this.commandBarGalleryDropDown2;
            this.addChartIndicatorBarItem1.Id = 53;
            this.addChartIndicatorBarItem1.Name = "addChartIndicatorBarItem1";
            this.addChartIndicatorBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown2.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown2.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown2.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown2.Gallery.ShowItemImage = false;
            this.commandBarGalleryDropDown2.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Manager = this.barManager1;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.Caption = "6m";
            this.barCheckItem3.GroupIndex = 1;
            this.barCheckItem3.Id = 4;
            this.barCheckItem3.Name = "barCheckItem3";
            this.barCheckItem3.Tag = 120;
            this.barCheckItem3.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPeriodChanged);
            // 
            // barCheckItem4
            // 
            this.barCheckItem4.Caption = "1y";
            this.barCheckItem4.GroupIndex = 1;
            this.barCheckItem4.Id = 5;
            this.barCheckItem4.Name = "barCheckItem4";
            this.barCheckItem4.Tag = 240;
            this.barCheckItem4.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPeriodChanged);
            // 
            // barCheckItem5
            // 
            this.barCheckItem5.BindableChecked = true;
            this.barCheckItem5.Caption = "1.5y";
            this.barCheckItem5.Checked = true;
            this.barCheckItem5.GroupIndex = 1;
            this.barCheckItem5.Id = 6;
            this.barCheckItem5.Name = "barCheckItem5";
            this.barCheckItem5.Tag = 360;
            this.barCheckItem5.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPeriodChanged);
            // 
            // barCheckItem6
            // 
            this.barCheckItem6.Caption = "2y";
            this.barCheckItem6.GroupIndex = 1;
            this.barCheckItem6.Id = 7;
            this.barCheckItem6.Name = "barCheckItem6";
            this.barCheckItem6.Tag = 480;
            this.barCheckItem6.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPeriodChanged);
            // 
            // barCheckItem7
            // 
            this.barCheckItem7.BindableChecked = true;
            this.barCheckItem7.Caption = "4y";
            this.barCheckItem7.Checked = true;
            this.barCheckItem7.GroupIndex = 1;
            this.barCheckItem7.Id = 8;
            this.barCheckItem7.Name = "barCheckItem7";
            this.barCheckItem7.Tag = 960;
            this.barCheckItem7.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPeriodChanged);
            // 
            // barStaticItemPeriod
            // 
            this.barStaticItemPeriod.Caption = "Period:";
            this.barStaticItemPeriod.Id = 9;
            this.barStaticItemPeriod.Name = "barStaticItemPeriod";
            // 
            // comboBoxBarEditItem
            // 
            this.comboBoxBarEditItem.Caption = "Period";
            this.comboBoxBarEditItem.Edit = this.repositoryItemComboBoxPeriod;
            this.comboBoxBarEditItem.EditWidth = 65;
            this.comboBoxBarEditItem.Id = 13;
            this.comboBoxBarEditItem.Name = "comboBoxBarEditItem";
            this.comboBoxBarEditItem.EditValueChanged += new System.EventHandler(this.OnTicksChanged);
            // 
            // repositoryItemComboBoxPeriod
            // 
            this.repositoryItemComboBoxPeriod.AutoHeight = false;
            this.repositoryItemComboBoxPeriod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxPeriod.Name = "repositoryItemComboBoxPeriod";
            this.repositoryItemComboBoxPeriod.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1157, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1157, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1157, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // selectSeriesRepositoryItemComboBox1
            // 
            this.selectSeriesRepositoryItemComboBox1.AutoHeight = false;
            this.selectSeriesRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectSeriesRepositoryItemComboBox1.Items.AddRange(new object[] {
            "Price",
            "Volume"});
            this.selectSeriesRepositoryItemComboBox1.Name = "selectSeriesRepositoryItemComboBox1";
            this.selectSeriesRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // chartBarController1
            // 
            this.chartBarController1.BarItems.Add(this.chartCommandBarCheckItem1);
            this.chartBarController1.BarItems.Add(this.chartCommandBarCheckItem2);
            this.chartBarController1.BarItems.Add(this.chartCommandBarCheckItem3);
            this.chartBarController1.BarItems.Add(this.chartCommandBarCheckItem4);
            this.chartBarController1.BarItems.Add(this.addChartIndicatorBarItem1);
            this.chartBarController1.BarItems.Add(this.chartCommandBarCheckItem5);
            this.chartBarController1.BarItems.Add(this.changeSeriesViewBarItem1);
            this.chartBarController1.Control = this.stockChart;
            // 
            // StockChartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stockChart);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StockChartUC";
            this.Size = new System.Drawing.Size(1157, 536);
            this.Load += new System.EventHandler(this.StockChartUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(candleStickSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(candleStickSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeSeriesViewRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.BarManager barManager1;
        private XtraBars.BarCheckItem volumesBarCheckItem;
        private XtraBars.BarCheckItem barCheckItem3;
        private XtraBars.BarCheckItem barCheckItem4;
        private XtraBars.BarCheckItem barCheckItem5;
        private XtraBars.BarCheckItem barCheckItem6;
        private XtraBars.BarCheckItem barCheckItem7;
        private XtraBars.BarStaticItem barStaticItemPeriod;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        public XtraCharts.ChartControl stockChart;
        private XtraBars.BarEditItem comboBoxBarEditItem;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxPeriod;
        private XtraBars.BarAndDockingController barAndDockingController1;
        private XtraCharts.UI.ChartBarController chartBarController1;
        private XtraCharts.UI.DrawTrendLineIndicatorBarItem chartCommandBarCheckItem1;
        private XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem chartCommandBarCheckItem2;
        private XtraCharts.UI.DrawFibonacciFansIndicatorBarItem chartCommandBarCheckItem3;
        private XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem chartCommandBarCheckItem4;
        private XtraCharts.UI.AddIndicatorBarItem addChartIndicatorBarItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
        private XtraCharts.UI.RemoveIndicatorBarItem chartCommandBarCheckItem5;
        private XtraCharts.UI.ChartFinancialSeriesBar chartFinancialSeriesOptionsBar1;
        private XtraCharts.UI.ChangeSeriesViewBarItem changeSeriesViewBarItem1;
        private XtraCharts.UI.SelectSeriesRepositoryItemComboBox selectSeriesRepositoryItemComboBox1;
        private XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox changeSeriesViewRepositoryItemComboBox1;
    }
}
