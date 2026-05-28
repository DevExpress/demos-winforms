namespace DevExpress.ProductsDemo.Win.Modules {
    partial class PivotModuleNew {
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
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.rangeControl = new DevExpress.XtraEditors.RangeControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tiles = new DevExpress.ProductsDemo.Win.PivotTileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tiRevenue = new DevExpress.XtraEditors.TileItem();
            this.tiUnitSales = new DevExpress.XtraEditors.TileItem();
            this.tiDirectSales = new DevExpress.XtraEditors.TileItem();
            this.tiBestSector = new DevExpress.XtraEditors.TileItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.chartsPanel = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucUnits = new DevExpress.SalesDemo.Win.Modules.ucSalesPerformance();
            this.ucSales = new DevExpress.SalesDemo.Win.Modules.ucSalesPerformance();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartsPanel)).BeginInit();
            this.chartsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rangeControl, 2);
            this.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeControl.Location = new System.Drawing.Point(3, 175);
            this.rangeControl.Name = "rangeControl";
            rangeControlRange1.Maximum = 4.5D;
            rangeControlRange1.Minimum = -0.5D;
            rangeControlRange1.Owner = this.rangeControl;
            this.rangeControl.SelectedRange = rangeControlRange1;
            this.rangeControl.ShowToolTips = false;
            this.rangeControl.ShowZoomScrollBar = false;
            this.rangeControl.Size = new System.Drawing.Size(1036, 54);
            this.rangeControl.TabIndex = 5;
            this.rangeControl.Text = "rangeControl1";
            this.rangeControl.VisibleRangeMaximumScaleFactor = 1D;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.tiles);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.panelControl1.Size = new System.Drawing.Size(1042, 111);
            this.panelControl1.TabIndex = 0;
            // 
            // tiles
            // 
            this.tiles.AllowDrag = false;
            this.tiles.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(116)))), ((int)(((byte)(189)))));
            this.tiles.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tiles.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tiles.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tiles.AppearanceText.Font = new System.Drawing.Font("Segoe Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiles.AppearanceText.Options.UseFont = true;
            this.tiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiles.Groups.Add(this.tileGroup1);
            this.tiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tiles.IndentBetweenGroups = 0;
            this.tiles.ItemSize = 101;
            this.tiles.LargeItemWidth = 250;
            this.tiles.Location = new System.Drawing.Point(4, 4);
            this.tiles.Margin = new System.Windows.Forms.Padding(0);
            this.tiles.MaxId = 9;
            this.tiles.Name = "tiles";
            this.tiles.Padding = new System.Windows.Forms.Padding(0);
            this.tiles.RowCount = 1;
            this.tiles.Size = new System.Drawing.Size(1034, 107);
            this.tiles.TabIndex = 0;
            this.tiles.Text = "Dashboard: Sales by Product";
            this.tiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tiRevenue);
            this.tileGroup1.Items.Add(this.tiUnitSales);
            this.tileGroup1.Items.Add(this.tiDirectSales);
            this.tileGroup1.Items.Add(this.tiBestSector);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // tiRevenue
            // 
            this.tiRevenue.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiRevenue.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Revenues<br><size=10>YTD GROWTH";
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe Condensed", 30F);
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "+1%";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tiRevenue.Elements.Add(tileItemElement1);
            this.tiRevenue.Elements.Add(tileItemElement2);
            this.tiRevenue.Id = 5;
            this.tiRevenue.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiRevenue.Name = "tiRevenue";
            // 
            // tiUnitSales
            // 
            this.tiUnitSales.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiUnitSales.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Text = "Unit Sales<br><size=10>YTD";
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "2820";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tiUnitSales.Elements.Add(tileItemElement3);
            this.tiUnitSales.Elements.Add(tileItemElement4);
            this.tiUnitSales.Id = 6;
            this.tiUnitSales.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiUnitSales.Name = "tiUnitSales";
            // 
            // tiDirectSales
            // 
            this.tiDirectSales.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiDirectSales.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Direct Sales<br><size=10>YTD";
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe Condensed", 30F);
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Text = "$200M";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tiDirectSales.Elements.Add(tileItemElement5);
            this.tiDirectSales.Elements.Add(tileItemElement6);
            this.tiDirectSales.Id = 7;
            this.tiDirectSales.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiDirectSales.Name = "tiDirectSales";
            // 
            // tiBestSector
            // 
            this.tiBestSector.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tiBestSector.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Text = "Best Sector YTD<br><size=10>{0}";
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Segoe Condensed", 30F);
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.Text = "$14M";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tiBestSector.Elements.Add(tileItemElement7);
            this.tiBestSector.Elements.Add(tileItemElement8);
            this.tiBestSector.Id = 8;
            this.tiBestSector.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiBestSector.Name = "tiBestSector";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.pivot);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 111);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl2.Size = new System.Drawing.Size(1042, 328);
            this.panelControl2.TabIndex = 1;
            // 
            // pivot
            // 
            this.pivot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivot.Location = new System.Drawing.Point(3, 3);
            this.pivot.Name = "pivot";
            this.pivot.OptionsView.ShowFilterHeaders = false;
            this.pivot.Size = new System.Drawing.Size(1036, 322);
            this.pivot.TabIndex = 0;
            // 
            // chartsPanel
            // 
            this.chartsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chartsPanel.Controls.Add(this.tableLayoutPanel1);
            this.chartsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartsPanel.Location = new System.Drawing.Point(0, 439);
            this.chartsPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartsPanel.Name = "chartsPanel";
            this.chartsPanel.Size = new System.Drawing.Size(1042, 232);
            this.chartsPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.95702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.04298F));
            this.tableLayoutPanel1.Controls.Add(this.ucUnits, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucSales, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rangeControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 232);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ucUnits
            // 
            this.ucUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUnits.Location = new System.Drawing.Point(2, 3);
            this.ucUnits.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucUnits.Name = "ucUnits";
            this.ucUnits.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ucUnits.ShowButtonsPanel = false;
            this.ucUnits.ShowCaptionPanel = false;
            this.ucUnits.Size = new System.Drawing.Size(631, 166);
            this.ucUnits.TabIndex = 1;
            // 
            // ucSales
            // 
            this.ucSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSales.Location = new System.Drawing.Point(637, 3);
            this.ucSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucSales.Name = "ucSales";
            this.ucSales.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ucSales.ShowButtonsPanel = false;
            this.ucSales.ShowCaptionPanel = false;
            this.ucSales.Size = new System.Drawing.Size(403, 166);
            this.ucSales.TabIndex = 0;
            // 
            // PivotModuleNew
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.chartsPanel);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PivotModuleNew";
            this.Size = new System.Drawing.Size(1042, 671);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartsPanel)).EndInit();
            this.chartsPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panelControl1;
        private PivotTileControl tiles;
        private XtraEditors.TileGroup tileGroup1;
        private XtraEditors.TileItem tiRevenue;
        private XtraEditors.TileItem tiUnitSales;
        private XtraEditors.TileItem tiDirectSales;
        private XtraEditors.TileItem tiBestSector;
        private XtraEditors.PanelControl panelControl2;
        private XtraEditors.PanelControl chartsPanel;
        private SalesDemo.Win.Modules.ucSalesPerformance ucSales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XtraPivotGrid.PivotGridControl pivot;
        private SalesDemo.Win.Modules.ucSalesPerformance ucUnits;
        private XtraEditors.RangeControl rangeControl;

    }
}
