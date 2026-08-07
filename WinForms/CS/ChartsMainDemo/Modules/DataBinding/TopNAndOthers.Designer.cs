namespace DevExpress.XtraCharts.Demos {
	partial class TopNAndOthersDemo {
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DataSourceAdapter dataSourceAdapter1 = new DevExpress.XtraCharts.DataSourceAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.Doughnut3DSeriesLabel doughnut3DSeriesLabel1 = new DevExpress.XtraCharts.Doughnut3DSeriesLabel();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.dS21 = new DevExpress.XtraCharts.Demos.DS2();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.checkEditLabelVisible = new DevExpress.XtraEditors.CheckEdit();
            this.spinEditCount = new DevExpress.XtraEditors.SpinEdit();
            this.checkEditShowOthers = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditOthersArgument = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemShowOther = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemOthersArgument = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupLabel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemLabelVisible = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLabelVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOthersArgument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOthersArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLabelVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataSource = this.dS21.Countries;
            simpleDiagram3D1.RotationMatrixSerializable = "0.990157351881877;-0.0243454369756547;0.13782495497091;0;0.10562840212504;0.77604" +
    "3051453063;-0.621771519897728;0;-0.0918207992710787;0.630209871384037;0.77097630" +
    "237987;0;0;0;0;1";
            simpleDiagram3D1.RuntimeRotation = true;
            simpleDiagram3D1.RuntimeScrolling = true;
            simpleDiagram3D1.RuntimeZooming = true;
            this.chart.Diagram = simpleDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.RefreshDataOnRepaint = true;
            dataMember1.ColumnName = "Country";
            dataMember2.ColumnName = "Area";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataSourceAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2});
            series1.DataAdapter = dataSourceAdapter1;
            doughnut3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Tangent;
            doughnut3DSeriesLabel1.TextPattern = "{VP:P2}";
            series1.Label = doughnut3DSeriesLabel1;
            series1.LegendTextPattern = "{A:P2}";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.TopNOptions.Enabled = true;
            series1.TopNOptions.ThresholdPercent = 2.3D;
            series1.TopNOptions.ThresholdValue = 7000D;
            series1.View = doughnut3DSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.TextPattern = "{V:F2}";
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Land Area by Country";
            chartTitle1.TitleID = 0;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            chartTitle2.Text = "From www.nationmaster.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            chartTitle2.TitleID = 1;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // dS21
            // 
            this.dS21.DataSetName = "DS2";
            this.dS21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter
            // 
            this.oleDbDataAdapter.SelectCommand = this.oleDbSelectCommand;
            this.oleDbDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Countries", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("OfficialName", "OfficialName"),
                        new System.Data.Common.DataColumnMapping("Area", "Area")})});
            // 
            // oleDbSelectCommand
            // 
            this.oleDbSelectCommand.CommandText = "SELECT Country, OfficialName, Area FROM Countries";
            this.oleDbSelectCommand.Connection = this.oleDbConnection;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.checkEditLabelVisible);
            this.layoutControl.Controls.Add(this.spinEditCount);
            this.layoutControl.Controls.Add(this.checkEditShowOthers);
            this.layoutControl.Controls.Add(this.comboBoxEditMode);
            this.layoutControl.Controls.Add(this.textEditOthersArgument);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(817, 168, 817, 753);
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // checkEditLabelVisible
            // 
            this.checkEditLabelVisible.EditValue = true;
            this.checkEditLabelVisible.Location = new System.Drawing.Point(12, 172);
            this.checkEditLabelVisible.Name = "checkEditLabelVisible";
            this.checkEditLabelVisible.Properties.Caption = "Visible";
            this.checkEditLabelVisible.Size = new System.Drawing.Size(217, 20);
            this.checkEditLabelVisible.StyleController = this.layoutControl;
            this.checkEditLabelVisible.TabIndex = 4;
            this.checkEditLabelVisible.CheckedChanged += new System.EventHandler(this.checkEditLabelVisible_CheckedChanged);
            // 
            // spinEditCount
            // 
            this.spinEditCount.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEditCount.Location = new System.Drawing.Point(107, 106);
            this.spinEditCount.Name = "spinEditCount";
            this.spinEditCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCount.Properties.IsFloatValue = false;
            this.spinEditCount.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditCount.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEditCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditCount.Size = new System.Drawing.Size(122, 20);
            this.spinEditCount.StyleController = this.layoutControl;
            this.spinEditCount.TabIndex = 9;
            this.spinEditCount.EditValueChanged += new System.EventHandler(this.checkEditCount_EditValueChanged);
            // 
            // checkEditShowOthers
            // 
            this.checkEditShowOthers.EditValue = true;
            this.checkEditShowOthers.Location = new System.Drawing.Point(12, 34);
            this.checkEditShowOthers.Name = "checkEditShowOthers";
            this.checkEditShowOthers.Properties.Caption = "Show Others";
            this.checkEditShowOthers.Size = new System.Drawing.Size(217, 20);
            this.checkEditShowOthers.StyleController = this.layoutControl;
            this.checkEditShowOthers.TabIndex = 10;
            this.checkEditShowOthers.EditValueChanged += new System.EventHandler(this.checkEditShowOthers_CheckedChanged);
            // 
            // comboBoxEditMode
            // 
            this.comboBoxEditMode.EditValue = "Count";
            this.comboBoxEditMode.Location = new System.Drawing.Point(107, 82);
            this.comboBoxEditMode.Name = "comboBoxEditMode";
            this.comboBoxEditMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMode.Properties.Items.AddRange(new object[] {
            "Count",
            "Threshold Value",
            "Threshold Percent"});
            this.comboBoxEditMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMode.Size = new System.Drawing.Size(122, 20);
            this.comboBoxEditMode.StyleController = this.layoutControl;
            this.comboBoxEditMode.TabIndex = 13;
            this.comboBoxEditMode.SelectedIndexChanged += new System.EventHandler(this.comboBOxEditMode_SelectedIndexChanged);
            // 
            // textEditOthersArgument
            // 
            this.textEditOthersArgument.EditValue = "Other";
            this.textEditOthersArgument.Location = new System.Drawing.Point(107, 58);
            this.textEditOthersArgument.Name = "textEditOthersArgument";
            this.textEditOthersArgument.Size = new System.Drawing.Size(122, 20);
            this.textEditOthersArgument.StyleController = this.layoutControl;
            this.textEditOthersArgument.TabIndex = 14;
            this.textEditOthersArgument.EditValueChanged += new System.EventHandler(this.textEditOthersArgument_EditValueChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupGeneral,
            this.emptySpaceItem,
            this.layoutControlGroupLabel});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent;
            this.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemCount,
            this.layoutControlItemShowOther,
            this.layoutControlItemMode,
            this.layoutControlItemOthersArgument});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(241, 138);
            this.layoutControlGroupGeneral.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupGeneral.Text = "General";
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.spinEditCount;
            this.layoutControlItemCount.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemCount.Text = "Count:";
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItemShowOther
            // 
            this.layoutControlItemShowOther.Control = this.checkEditShowOthers;
            this.layoutControlItemShowOther.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemShowOther.Name = "layoutControlItemShowOther";
            this.layoutControlItemShowOther.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemShowOther.TextVisible = false;
            // 
            // layoutControlItemMode
            // 
            this.layoutControlItemMode.Control = this.comboBoxEditMode;
            this.layoutControlItemMode.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemMode.Name = "layoutControlItemMode";
            this.layoutControlItemMode.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemMode.Text = "Mode";
            this.layoutControlItemMode.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItemOthersArgument
            // 
            this.layoutControlItemOthersArgument.Control = this.textEditOthersArgument;
            this.layoutControlItemOthersArgument.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemOthersArgument.Name = "layoutControlItemOthersArgument";
            this.layoutControlItemOthersArgument.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemOthersArgument.Text = "Others Argument";
            this.layoutControlItemOthersArgument.TextSize = new System.Drawing.Size(83, 13);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 204);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 334);
            // 
            // layoutControlGroupLabel
            // 
            this.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent;
            this.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupLabel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemLabelVisible});
            this.layoutControlGroupLabel.Location = new System.Drawing.Point(0, 138);
            this.layoutControlGroupLabel.Name = "layoutControlGroupLabel";
            this.layoutControlGroupLabel.Size = new System.Drawing.Size(241, 66);
            this.layoutControlGroupLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupLabel.Text = "Label";
            // 
            // layoutControlItemLabelVisible
            // 
            this.layoutControlItemLabelVisible.Control = this.checkEditLabelVisible;
            this.layoutControlItemLabelVisible.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible";
            this.layoutControlItemLabelVisible.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemLabelVisible.TextVisible = false;
            // 
            // TopNAndOthersDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TopNAndOthersDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLabelVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOthersArgument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOthersArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLabelVisible)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        System.ComponentModel.IContainer components = null;
        System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
        System.Data.OleDb.OleDbCommand oleDbSelectCommand;
        System.Data.OleDb.OleDbConnection oleDbConnection;
        DS2 dS21;
        XtraLayout.LayoutControl layoutControl;
        XtraEditors.CheckEdit checkEditLabelVisible;
        XtraEditors.CheckEdit checkEditShowOthers;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        XtraLayout.LayoutControlItem layoutControlItemShowOther;
        XtraLayout.LayoutControlGroup layoutControlGroupLabel;
        XtraLayout.LayoutControlItem layoutControlItemLabelVisible;
        XtraEditors.SpinEdit spinEditCount;
        XtraEditors.ComboBoxEdit comboBoxEditMode;
        XtraLayout.LayoutControlItem layoutControlItemCount;
        XtraLayout.LayoutControlItem layoutControlItemMode;
        XtraEditors.TextEdit textEditOthersArgument;
        XtraLayout.LayoutControlItem layoutControlItemOthersArgument;
        ChartControl chart;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
    }
}
