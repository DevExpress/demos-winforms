namespace DevExpress.DevAV.Views {
    partial class ProductCollectionView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.Sparkline.BarSparklineView barSparklineView1 = new DevExpress.Sparkline.BarSparklineView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackorder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlySales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSparklineEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit();
            this.productFilterView = new DevExpress.DevAV.Views.ProductFilterView();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.windowsUIButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.splitContainerControl.Panel1.Controls.Add(this.productFilterView);
            this.splitContainerControl.Panel2.Controls.Add(this.gridControl);
            this.splitContainerControl.Panel2.Padding = new System.Windows.Forms.Padding(0, 4, 40, 0);
            this.splitContainerControl.Size = new System.Drawing.Size(1139, 696);
            
            
            
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.ProductCollectionViewModel);
            
            
            
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.Size = new System.Drawing.Size(1139, 49);
            this.labelControl.Text = "PRODUCT  <color=47, 81, 165>Categories</color>";
            
            
            
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("New", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Custom Filter", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel.Controls.Add(this.searchControl);
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 745);
            this.windowsUIButtonPanel.PeekFormOptions.Size = new System.Drawing.Size(120, 135);
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(1139, 89);
            
            
            
            this.gridControl.DataSource = this.productBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 4);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSparklineEdit1});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(739, 692);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            
            
            
            this.productBindingSource.DataSource = typeof(DevExpress.DevAV.ProductInfoWithSales);
            
            
            
            this.gridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCost,
            this.colSalePrice,
            this.colRetailPrice,
            this.colCurrentInventory,
            this.colBackorder,
            this.colMonthlySales});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView.FooterPanelHeight = 60;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 10;
            
            
            
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 177;
            
            
            
            this.colCost.DisplayFormat.FormatString = "c";
            this.colCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 1;
            this.colCost.Width = 81;
            
            
            
            this.colSalePrice.DisplayFormat.FormatString = "c";
            this.colSalePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalePrice.FieldName = "SalePrice";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 2;
            this.colSalePrice.Width = 81;
            
            
            
            this.colRetailPrice.DisplayFormat.FormatString = "c";
            this.colRetailPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRetailPrice.FieldName = "RetailPrice";
            this.colRetailPrice.Name = "colRetailPrice";
            this.colRetailPrice.Visible = true;
            this.colRetailPrice.VisibleIndex = 3;
            this.colRetailPrice.Width = 81;
            
            
            
            this.colCurrentInventory.Caption = "Inventory";
            this.colCurrentInventory.FieldName = "CurrentInventory";
            this.colCurrentInventory.Name = "colCurrentInventory";
            this.colCurrentInventory.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CurrentInventory", "<color=gray>TOTAL INVENTORY</color><br><b>{0}</b>")});
            this.colCurrentInventory.Visible = true;
            this.colCurrentInventory.VisibleIndex = 4;
            this.colCurrentInventory.Width = 106;
            
            
            
            this.colBackorder.FieldName = "Backorder";
            this.colBackorder.Name = "colBackorder";
            this.colBackorder.Visible = true;
            this.colBackorder.VisibleIndex = 5;
            this.colBackorder.Width = 67;
            
            
            
            this.colMonthlySales.Caption = "Monthly Sales (FY2013)";
            this.colMonthlySales.ColumnEdit = this.repositoryItemSparklineEdit1;
            this.colMonthlySales.FieldName = "MonthlySales";
            this.colMonthlySales.Name = "colMonthlySales";
            this.colMonthlySales.OptionsFilter.AllowAutoFilter = false;
            this.colMonthlySales.OptionsFilter.AllowFilter = false;
            this.colMonthlySales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSales", "<color=gray>TOTAL SALES</color><br><b>{0:c}</b>")});
            this.colMonthlySales.Visible = true;
            this.colMonthlySales.VisibleIndex = 6;
            this.colMonthlySales.Width = 144;
            
            
            
            this.repositoryItemSparklineEdit1.Name = "repositoryItemSparklineEdit1";
            barSparklineView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(165)))));
            this.repositoryItemSparklineEdit1.View = barSparklineView1;
            
            
            
            this.productFilterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productFilterView.Location = new System.Drawing.Point(53, 3);
            this.productFilterView.Margin = new System.Windows.Forms.Padding(4);
            this.productFilterView.Name = "productFilterView";
            this.productFilterView.Size = new System.Drawing.Size(275, 690);
            this.productFilterView.TabIndex = 0;
            
            
            
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.gridControl;
            this.searchControl.Location = new System.Drawing.Point(865, 20);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.gridControl;
            this.searchControl.Size = new System.Drawing.Size(260, 42);
            this.searchControl.TabIndex = 0;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProductCollectionView";
            this.Size = new System.Drawing.Size(1139, 834);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.windowsUIButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl gridControl;
        private XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private XtraGrid.Columns.GridColumn colName;
        private XtraGrid.Columns.GridColumn colCost;
        private XtraGrid.Columns.GridColumn colSalePrice;
        private XtraGrid.Columns.GridColumn colRetailPrice;
        private XtraGrid.Columns.GridColumn colCurrentInventory;
        private XtraGrid.Columns.GridColumn colBackorder;
        private XtraGrid.Columns.GridColumn colMonthlySales;
        private XtraEditors.Repository.RepositoryItemSparklineEdit repositoryItemSparklineEdit1;
        private ProductFilterView productFilterView;
        private XtraEditors.SearchControl searchControl;
    }
}
