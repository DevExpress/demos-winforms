namespace DevExpress.XtraSpreadsheet.Demos {
    partial class TopTradingPartnersModule {
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.chkAsiaRegion = new DevExpress.XtraEditors.CheckEdit();
            this.chkBalance = new DevExpress.XtraEditors.CheckEdit();
            this.chkExports = new DevExpress.XtraEditors.CheckEdit();
            this.chkImports = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsiaRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExports.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkImports.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets;
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(569, 192);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 41);
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(697, 150);
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Controls.Add(this.layoutControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(569, 191);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(128, 192);
            this.sidePanel1.TabIndex = 56;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // chkAsiaRegion
            // 
            this.chkAsiaRegion.EditValue = true;
            this.chkAsiaRegion.Location = new System.Drawing.Point(12, 84);
            this.chkAsiaRegion.Name = "chkAsiaRegion";
            this.chkAsiaRegion.Properties.AutoWidth = true;
            this.chkAsiaRegion.Properties.Caption = "Asia Region";
            this.chkAsiaRegion.Size = new System.Drawing.Size(79, 20);
            this.chkAsiaRegion.StyleController = this.layoutControl1;
            this.chkAsiaRegion.TabIndex = 4;
            this.chkAsiaRegion.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkBalance
            // 
            this.chkBalance.EditValue = true;
            this.chkBalance.Location = new System.Drawing.Point(12, 60);
            this.chkBalance.Name = "chkBalance";
            this.chkBalance.Properties.AutoWidth = true;
            this.chkBalance.Properties.Caption = "Balance";
            this.chkBalance.Size = new System.Drawing.Size(60, 20);
            this.chkBalance.StyleController = this.layoutControl1;
            this.chkBalance.TabIndex = 3;
            this.chkBalance.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkExports
            // 
            this.chkExports.EditValue = true;
            this.chkExports.Location = new System.Drawing.Point(12, 36);
            this.chkExports.Name = "chkExports";
            this.chkExports.Properties.AutoWidth = true;
            this.chkExports.Properties.Caption = "Exports";
            this.chkExports.Size = new System.Drawing.Size(60, 20);
            this.chkExports.StyleController = this.layoutControl1;
            this.chkExports.TabIndex = 2;
            this.chkExports.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkImports
            // 
            this.chkImports.EditValue = true;
            this.chkImports.Location = new System.Drawing.Point(12, 12);
            this.chkImports.Name = "chkImports";
            this.chkImports.Properties.AutoWidth = true;
            this.chkImports.Properties.Caption = "Imports";
            this.chkImports.Size = new System.Drawing.Size(60, 20);
            this.chkImports.StyleController = this.layoutControl1;
            this.chkImports.TabIndex = 1;
            this.chkImports.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.chkAsiaRegion);
            this.layoutControl1.Controls.Add(this.chkBalance);
            this.layoutControl1.Controls.Add(this.chkExports);
            this.layoutControl1.Controls.Add(this.chkImports);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(127, 192);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition2.Width = 107D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition10.Height = 76D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition6,
            rowDefinition7,
            rowDefinition8,
            rowDefinition9,
            rowDefinition10});
            this.Root.Size = new System.Drawing.Size(127, 192);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkImports;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(107, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkExports;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(107, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkBalance;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(107, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkAsiaRegion;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(107, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // TopTradingPartnersModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Name = "TopTradingPartnersModule";
            this.Size = new System.Drawing.Size(697, 410);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.sidePanel1, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAsiaRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExports.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkImports.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.SidePanel sidePanel1;
        protected XtraEditors.CheckEdit chkAsiaRegion;
        protected XtraEditors.CheckEdit chkBalance;
        protected XtraEditors.CheckEdit chkExports;
        protected XtraEditors.CheckEdit chkImports;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
