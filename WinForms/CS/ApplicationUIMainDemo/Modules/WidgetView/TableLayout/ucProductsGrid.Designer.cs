namespace DevExpress.ApplicationUI.Demos {
    partial class ucProductsGrid {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.RevenueYTDvsTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.totalSalesItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenueYTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsSoldYTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenueYTDTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsSoldYTDTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RevenueYTDvsTarget
            // 
            this.RevenueYTDvsTarget.Caption = "Revenue YTD vs Target";
            this.RevenueYTDvsTarget.DisplayFormat.FormatString = "P1";
            this.RevenueYTDvsTarget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.RevenueYTDvsTarget.FieldName = "Revenue YTD vs Target";
            this.RevenueYTDvsTarget.Name = "RevenueYTDvsTarget";
            this.RevenueYTDvsTarget.UnboundExpression = "([RevenueYTD] - [RevenueYTDTarget]) / ([RevenueYTDTarget])";
            this.RevenueYTDvsTarget.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.RevenueYTDvsTarget.Visible = true;
            this.RevenueYTDvsTarget.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Units Sold YTD vs Target";
            this.gridColumn2.FieldName = "unitsSoldYTDvsTarget";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundExpression = "([UnitsSoldYTD] - [UnitsSoldYTDTarget])";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.totalSalesItemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 351);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // totalSalesItemBindingSource
            // 
            this.totalSalesItemBindingSource.DataSource = typeof(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategory,
            this.colProduct,
            this.colRevenueYTD,
            this.RevenueYTDvsTarget,
            this.colUnitsSoldYTD,
            this.gridColumn2,
            this.colRevenueYTDTarget,
            this.colUnitsSoldYTDTarget});
            this.gridView1.FixedLineWidth = 1;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(48)))));
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.RevenueYTDvsTarget;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[Revenue YTD vs Target] >= 0";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.RevenueYTDvsTarget;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[Revenue YTD vs Target] < 0";
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.gridColumn2;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[unitsSoldYTDvsTarget] < 0";
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(48)))));
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Column = this.gridColumn2;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition4.Expression = "[unitsSoldYTDvsTarget] >= 0";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 0;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 1;
            // 
            // colRevenueYTD
            // 
            this.colRevenueYTD.DisplayFormat.FormatString = "C2";
            this.colRevenueYTD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRevenueYTD.FieldName = "RevenueYTD";
            this.colRevenueYTD.Name = "colRevenueYTD";
            this.colRevenueYTD.Visible = true;
            this.colRevenueYTD.VisibleIndex = 2;
            // 
            // colUnitsSoldYTD
            // 
            this.colUnitsSoldYTD.FieldName = "UnitsSoldYTD";
            this.colUnitsSoldYTD.Name = "colUnitsSoldYTD";
            this.colUnitsSoldYTD.Visible = true;
            this.colUnitsSoldYTD.VisibleIndex = 4;
            // 
            // colRevenueYTDTarget
            // 
            this.colRevenueYTDTarget.FieldName = "RevenueYTDTarget";
            this.colRevenueYTDTarget.Name = "colRevenueYTDTarget";
            // 
            // colUnitsSoldYTDTarget
            // 
            this.colUnitsSoldYTDTarget.FieldName = "UnitsSoldYTDTarget";
            this.colUnitsSoldYTDTarget.Name = "colUnitsSoldYTDTarget";
            // 
            // ucProductsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucProductsGrid";
            this.Size = new System.Drawing.Size(776, 351);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenueYTD;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsSoldYTD;
        private DevExpress.XtraGrid.Columns.GridColumn RevenueYTDvsTarget;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenueYTDTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsSoldYTDTarget;
        private System.Windows.Forms.BindingSource totalSalesItemBindingSource;
    }
}
