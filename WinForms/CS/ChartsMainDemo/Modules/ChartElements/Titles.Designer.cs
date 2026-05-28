namespace DevExpress.XtraCharts.Demos {
    partial class TitlesDemo {
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxEditSeriesView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditTitleText = new DevExpress.XtraEditors.TextEdit();
            this.checkEditWordWrap = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditDock = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupText = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemWordWrap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTitleText = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeriesView = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupLayout = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemDock = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAlignment = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitleText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWordWrap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWordWrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitleText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAlignment)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.Location = new System.Drawing.Point(772, 0);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 544);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.AutoLayout = false;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Title.Text = "Products";
            this.chart.Legend.Title.Visible = true;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.RuntimeHitTesting = true;
            this.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            this.chart.SeriesDataMember = "Region";
            this.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "ProductCategory";
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            pieSeriesLabel1.TextPattern = "{VP:0%}";
            this.chart.SeriesTemplate.Label = pieSeriesLabel1;
            this.chart.SeriesTemplate.LegendTextPattern = "{A}";
            this.chart.SeriesTemplate.SeriesDataMember = "Region";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chart.SeriesTemplate.View = pieSeriesView1;
            this.chart.Size = new System.Drawing.Size(772, 571);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            chartTitle1.Text = "With XtraCharts, <b>you</b> can display an <u>unlimited</u> number of <color=blue" +
    ">chart titles</color>";
            chartTitle1.WordWrap = true;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Text = "<size=14>Title</size> <size=+2>with <size=+6>a</size></size> <size=24>variable</s" +
    "ize> <size=14>font <size=+6>size</size></size>";
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle3.Text = "<i>Italicized</i> title";
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Right;
            chartTitle4.Text = "<color=red>Multi</color>-<color=green>color</color> <color=blue>title</color>";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2,
            chartTitle3,
            chartTitle4});
            this.chart.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectSelected);
            this.chart.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectHotTracked);
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.comboBoxEditSeriesView);
            this.layoutControl.Controls.Add(this.textEditTitleText);
            this.layoutControl.Controls.Add(this.checkEditWordWrap);
            this.layoutControl.Controls.Add(this.comboBoxEditDock);
            this.layoutControl.Controls.Add(this.comboBoxEditAlignment);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 544);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // comboBoxEditSeriesView
            // 
            this.comboBoxEditSeriesView.Location = new System.Drawing.Point(73, 31);
            this.comboBoxEditSeriesView.Name = "comboBoxEditSeriesView";
            this.comboBoxEditSeriesView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSeriesView.Properties.Items.AddRange(new object[] {
            "Pie",
            "Bar"});
            this.comboBoxEditSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSeriesView.Size = new System.Drawing.Size(156, 20);
            this.comboBoxEditSeriesView.StyleController = this.layoutControl;
            this.comboBoxEditSeriesView.TabIndex = 4;
            this.comboBoxEditSeriesView.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSeriesView_SelectedIndexChanged);
            // 
            // textEditTitleText
            // 
            this.textEditTitleText.Location = new System.Drawing.Point(12, 94);
            this.textEditTitleText.Name = "textEditTitleText";
            this.textEditTitleText.Size = new System.Drawing.Size(217, 20);
            this.textEditTitleText.StyleController = this.layoutControl;
            this.textEditTitleText.TabIndex = 5;
            this.textEditTitleText.TextChanged += new System.EventHandler(this.textEditTitleText_TextChanged);
            // 
            // checkEditWordWrap
            // 
            this.checkEditWordWrap.Location = new System.Drawing.Point(12, 118);
            this.checkEditWordWrap.Name = "checkEditWordWrap";
            this.checkEditWordWrap.Properties.Caption = "Word Wrap";
            this.checkEditWordWrap.Size = new System.Drawing.Size(217, 19);
            this.checkEditWordWrap.StyleController = this.layoutControl;
            this.checkEditWordWrap.TabIndex = 6;
            this.checkEditWordWrap.CheckedChanged += new System.EventHandler(this.checkEditWordWrap_CheckedChanged);
            // 
            // comboBoxEditDock
            // 
            this.comboBoxEditDock.Location = new System.Drawing.Point(73, 180);
            this.comboBoxEditDock.Name = "comboBoxEditDock";
            this.comboBoxEditDock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDock.Properties.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right"});
            this.comboBoxEditDock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditDock.Size = new System.Drawing.Size(156, 20);
            this.comboBoxEditDock.StyleController = this.layoutControl;
            this.comboBoxEditDock.TabIndex = 7;
            this.comboBoxEditDock.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditDock_SelectedIndexChanged);
            // 
            // comboBoxEditAlignment
            // 
            this.comboBoxEditAlignment.Location = new System.Drawing.Point(73, 204);
            this.comboBoxEditAlignment.Name = "comboBoxEditAlignment";
            this.comboBoxEditAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditAlignment.Properties.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBoxEditAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditAlignment.Size = new System.Drawing.Size(156, 20);
            this.comboBoxEditAlignment.StyleController = this.layoutControl;
            this.comboBoxEditAlignment.TabIndex = 8;
            this.comboBoxEditAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditAlignment_SelectedIndexChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupText,
            this.layoutControlGroupGeneral,
            this.emptySpaceItem,
            this.layoutControlGroupLayout});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 544);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupText
            // 
            this.layoutControlGroupText.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupText.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemWordWrap,
            this.layoutControlItemTitleText});
            this.layoutControlGroupText.Location = new System.Drawing.Point(0, 63);
            this.layoutControlGroupText.Name = "layoutControlGroupText";
            this.layoutControlGroupText.Size = new System.Drawing.Size(241, 86);
            this.layoutControlGroupText.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupText.Text = "Selected Title Text";
            // 
            // layoutControlItemWordWrap
            // 
            this.layoutControlItemWordWrap.Control = this.checkEditWordWrap;
            this.layoutControlItemWordWrap.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemWordWrap.Name = "layoutControlItemWordWrap";
            this.layoutControlItemWordWrap.Size = new System.Drawing.Size(221, 23);
            this.layoutControlItemWordWrap.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemWordWrap.TextVisible = false;
            // 
            // layoutControlItemTitleText
            // 
            this.layoutControlItemTitleText.Control = this.textEditTitleText;
            this.layoutControlItemTitleText.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemTitleText.Name = "layoutControlItemTitleText";
            this.layoutControlItemTitleText.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemTitleText.Text = "Text: ";
            this.layoutControlItemTitleText.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemTitleText.TextVisible = false;
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeriesView});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(241, 63);
            this.layoutControlGroupGeneral.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupGeneral.Text = "General";
            // 
            // layoutControlItemSeriesView
            // 
            this.layoutControlItemSeriesView.Control = this.comboBoxEditSeriesView;
            this.layoutControlItemSeriesView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView";
            this.layoutControlItemSeriesView.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemSeriesView.Text = "Series View:";
            this.layoutControlItemSeriesView.TextSize = new System.Drawing.Size(58, 13);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 236);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 308);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupLayout
            // 
            this.layoutControlGroupLayout.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupLayout.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemDock,
            this.layoutControlItemAlignment});
            this.layoutControlGroupLayout.Location = new System.Drawing.Point(0, 149);
            this.layoutControlGroupLayout.Name = "layoutControlGroupLayout";
            this.layoutControlGroupLayout.Size = new System.Drawing.Size(241, 87);
            this.layoutControlGroupLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupLayout.Text = "Selected Title Layout";
            // 
            // layoutControlItemDock
            // 
            this.layoutControlItemDock.Control = this.comboBoxEditDock;
            this.layoutControlItemDock.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemDock.Name = "layoutControlItemDock";
            this.layoutControlItemDock.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemDock.Text = "Dock:";
            this.layoutControlItemDock.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItemAlignment
            // 
            this.layoutControlItemAlignment.Control = this.comboBoxEditAlignment;
            this.layoutControlItemAlignment.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemAlignment.Name = "layoutControlItemAlignment";
            this.layoutControlItemAlignment.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemAlignment.Text = "Alignment:";
            this.layoutControlItemAlignment.TextSize = new System.Drawing.Size(58, 13);
            // 
            // TitlesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TitlesDemo";
            this.Size = new System.Drawing.Size(1014, 571);
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitleText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWordWrap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWordWrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitleText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAlignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        XtraLayout.LayoutControl layoutControl;
        XtraEditors.ComboBoxEdit comboBoxEditSeriesView;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraLayout.LayoutControlItem layoutControlItemSeriesView;
        XtraEditors.TextEdit textEditTitleText;
        XtraLayout.LayoutControlItem layoutControlItemTitleText;
        XtraEditors.CheckEdit checkEditWordWrap;
        XtraLayout.LayoutControlItem layoutControlItemWordWrap;
        XtraEditors.ComboBoxEdit comboBoxEditDock;
        XtraEditors.ComboBoxEdit comboBoxEditAlignment;
        XtraLayout.LayoutControlGroup layoutControlGroupText;
        XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        XtraLayout.EmptySpaceItem emptySpaceItem;
        XtraLayout.LayoutControlGroup layoutControlGroupLayout;
        XtraLayout.LayoutControlItem layoutControlItemDock;
        XtraLayout.LayoutControlItem layoutControlItemAlignment;
    }
}
