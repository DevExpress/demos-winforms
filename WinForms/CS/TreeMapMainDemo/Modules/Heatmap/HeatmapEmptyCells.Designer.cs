using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeMap.Demos {
    partial class HeatmapEmptyCells {
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
            DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider heatmapRangeColorProvider1 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop1 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop2 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop3 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop4 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop5 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop6 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter heatmapDataSourceAdapter1 = new DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter();
            DevExpress.XtraCharts.Heatmap.HeatmapTitle heatmapTitle1 = new DevExpress.XtraCharts.Heatmap.HeatmapTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.heatmapControl1 = new DevExpress.XtraCharts.Heatmap.HeatmapControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.highlightModeComboBoxEdit = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupInteraction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupInteraction1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightModeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(322, 747);
            this.tabPaneOptions.Size = new System.Drawing.Size(322, 747);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Margin = new System.Windows.Forms.Padding(7);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(322, 706);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.heatmapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 279, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 747);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // heatmapControl1
            // 
            this.heatmapControl1.AxisX.Title.Text = "";
            this.heatmapControl1.AxisY.Title.Text = "";
            this.heatmapControl1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            heatmapRangeColorProvider1.ApproximateColors = true;
            heatmapRangeColorProvider1.LegendItemPattern = "${V1:N0} - ${V2:N0}";
            heatmapRangeColorProvider1.PaletteName = "Product Sales";
            heatmapRangeStop1.Value = 0D;
            heatmapRangeStop2.Value = 250D;
            heatmapRangeStop3.Value = 500D;
            heatmapRangeStop4.Value = 1000D;
            heatmapRangeStop5.Value = 5000D;
            heatmapRangeStop6.Value = 15000D;
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop1);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop2);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop3);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop4);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop5);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop6);
            this.heatmapControl1.ColorProvider = heatmapRangeColorProvider1;
            heatmapDataSourceAdapter1.ColorDataMember = "SalesVolume";
            heatmapDataSourceAdapter1.XArgumentDataMember = "SalesPerson";
            heatmapDataSourceAdapter1.YArgumentDataMember = "ProductName";
            this.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1;
            this.heatmapControl1.Label.Pattern = "{V:N0}";
            this.heatmapControl1.Label.Visible = true;
            this.heatmapControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.heatmapControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.heatmapControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.heatmapControl1.Legend.HorizontalIndent = 20;
            this.heatmapControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.heatmapControl1.Location = new System.Drawing.Point(0, 0);
            this.heatmapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.heatmapControl1.Name = "heatmapControl1";
            this.heatmapControl1.PaletteRepository.Add("Product Sales", new DevExpress.XtraCharts.Palette("Product Sales", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(218))))), System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(206))))), System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(182))))), System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(182)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(163)))), ((int)(((byte)(175))))), System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(131)))), ((int)(((byte)(163))))), System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(131)))), ((int)(((byte)(163))))))}));
            this.heatmapControl1.Size = new System.Drawing.Size(728, 747);
            this.heatmapControl1.TabIndex = 4;
            this.heatmapControl1.Text = "heatmapControl1";
            heatmapTitle1.Text = "Product Sales";
            this.heatmapControl1.Titles.Add(heatmapTitle1);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(728, 747);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.heatmapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(728, 747);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.colorPickEdit1);
            this.layoutControl.Controls.Add(this.highlightModeComboBoxEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(322, 706);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(12, 119);
            this.colorPickEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.colorPickEdit1.MenuManager = this;
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.colorPickEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Size = new System.Drawing.Size(298, 22);
            this.colorPickEdit1.StyleController = this.layoutControl;
            this.colorPickEdit1.TabIndex = 5;
            this.colorPickEdit1.ColorChanged += new System.EventHandler(this.DiagramColorChanged);
            // 
            // highlightModeComboBoxEdit
            // 
            this.highlightModeComboBoxEdit.Location = new System.Drawing.Point(12, 39);
            this.highlightModeComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.highlightModeComboBoxEdit.MenuManager = this;
            this.highlightModeComboBoxEdit.Name = "highlightModeComboBoxEdit";
            this.highlightModeComboBoxEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.highlightModeComboBoxEdit.Properties.Appearance.Options.UseBackColor = true;
            this.highlightModeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.highlightModeComboBoxEdit.Size = new System.Drawing.Size(298, 29);
            this.highlightModeComboBoxEdit.StyleController = this.layoutControl;
            this.highlightModeComboBoxEdit.TabIndex = 4;
            this.highlightModeComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.HighlightModeChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupInteraction,
            this.emptySpaceItem,
            this.layoutControlGroupInteraction1});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(322, 706);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupInteraction
            // 
            this.layoutControlGroupInteraction.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupInteraction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroupInteraction.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupInteraction.Name = "layoutControlGroupInteraction";
            this.layoutControlGroupInteraction.Size = new System.Drawing.Size(322, 80);
            this.layoutControlGroupInteraction.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction.Text = "Highlight Mode";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.highlightModeComboBoxEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(302, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 153);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(322, 553);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupInteraction1
            // 
            this.layoutControlGroupInteraction1.CustomizationFormText = "Diagram Color";
            this.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupInteraction1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroupInteraction1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1";
            this.layoutControlGroupInteraction1.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroupInteraction1.Size = new System.Drawing.Size(322, 73);
            this.layoutControlGroupInteraction1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction1.Text = "Diagram Background";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.colorPickEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(302, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(0, 0);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // HeatmapEmptyCells
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "HeatmapEmptyCells";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightModeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraLayout.LayoutControlGroup layoutControlGroupInteraction;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraCharts.Heatmap.HeatmapControl heatmapControl1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraLayout.LayoutControlGroup layoutControlGroupInteraction1;
        private ColorPickEdit colorPickEdit1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private RadioGroup highlightModeComboBoxEdit;
    }
}
