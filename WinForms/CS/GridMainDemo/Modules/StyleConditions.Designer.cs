namespace DevExpress.XtraGrid.Demos {
    partial class StyleConditions {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleConditions));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gcQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.expressionConditionsEditor1 = new DevExpress.XtraGrid.Demos.ExpressionConditionsEditor();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcQuantity
            // 
            resources.ApplyResources(this.gcQuantity, "gcQuantity");
            this.gcQuantity.ColumnEdit = this.repositoryItemSpinEdit3;
            this.gcQuantity.FieldName = "Quantity";
            this.gcQuantity.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcQuantity.ImageOptions.ImageIndex")));
            this.gcQuantity.Name = "gcQuantity";
            // 
            // repositoryItemSpinEdit3
            // 
            resources.ApplyResources(this.repositoryItemSpinEdit3, "repositoryItemSpinEdit3");
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit3.IsFloatValue = false;
            this.repositoryItemSpinEdit3.Mask.EditMask = resources.GetString("repositoryItemSpinEdit3.Mask.EditMask");
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // gcTotal
            // 
            resources.ApplyResources(this.gcTotal, "gcTotal");
            this.gcTotal.DisplayFormat.FormatString = "c";
            this.gcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcTotal.FieldName = "Total";
            this.gcTotal.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcTotal.ImageOptions.ImageIndex")));
            this.gcTotal.Name = "gcTotal";
            this.gcTotal.OptionsColumn.ReadOnly = true;
            this.gcTotal.ShowUnboundExpressionMenu = true;
            this.gcTotal.UnboundDataType = typeof(decimal);
            this.gcTotal.UnboundExpression = "([UnitPrice] * [Quantity]) * (1 - [Discount])";
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.expressionConditionsEditor1);
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.Name = "sidePanel";
            // 
            // expressionConditionsEditor1
            // 
            resources.ApplyResources(this.expressionConditionsEditor1, "expressionConditionsEditor1");
            this.expressionConditionsEditor1.Name = "expressionConditionsEditor1";
            // 
            // gcProducts
            // 
            this.gcProducts.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.gcProducts, "gcProducts");
            this.gcProducts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProducts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit3,
            this.repositoryItemTextEdit1});
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcOrderID,
            this.gcProduct,
            this.gcUnitPrice,
            this.gcQuantity,
            this.gcDiscount,
            this.gcTotal});
            this.gvProducts.CustomizationFormBounds = new System.Drawing.Rectangle(763, 281, 260, 252);
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gcQuantity;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[Quantity] >= 20 And [Discount] != 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.gcQuantity;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LightPink;
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[Quantity] <= 20 AND [Total] < 100";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.Column = this.gcTotal;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            formatConditionRuleExpression3.Appearance.Options.UseFont = true;
            formatConditionRuleExpression3.Expression = "[Total] >= 500";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = this.gcTotal;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleExpression4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Gray;
            formatConditionRuleExpression4.Appearance.Options.UseFont = true;
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression4.Expression = "[Total] < 50 And [Discount] != 0";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.gvProducts.FormatRules.Add(gridFormatRule1);
            this.gvProducts.FormatRules.Add(gridFormatRule2);
            this.gvProducts.FormatRules.Add(gridFormatRule3);
            this.gvProducts.FormatRules.Add(gridFormatRule4);
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gvProducts.GroupSummary"))), resources.GetString("gvProducts.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gvProducts.GroupSummary2"))), resources.GetString("gvProducts.GroupSummary3"))});
            this.gvProducts.Images = this.svgImageCollection1;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gvProducts.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            this.gvProducts.OptionsView.ShowIndicator = false;
            // 
            // gcOrderID
            // 
            this.gcOrderID.FieldName = "OrderID";
            this.gcOrderID.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcOrderID.ImageOptions.ImageIndex")));
            this.gcOrderID.Name = "gcOrderID";
            resources.ApplyResources(this.gcOrderID, "gcOrderID");
            // 
            // gcProduct
            // 
            resources.ApplyResources(this.gcProduct, "gcProduct");
            this.gcProduct.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gcProduct.FieldName = "ProductID";
            this.gcProduct.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcProduct.ImageOptions.ImageIndex")));
            this.gcProduct.Name = "gcProduct";
            // 
            // repositoryItemLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1");
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit1.Buttons"))))});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit1.DropDownRows = 10;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 220;
            this.repositoryItemLookUpEdit1.ValueMember = "ProductID";
            // 
            // gcUnitPrice
            // 
            this.gcUnitPrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gcUnitPrice.DisplayFormat.FormatString = "c";
            this.gcUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcUnitPrice.FieldName = "UnitPrice";
            this.gcUnitPrice.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcUnitPrice.ImageOptions.ImageIndex")));
            this.gcUnitPrice.Name = "gcUnitPrice";
            resources.ApplyResources(this.gcUnitPrice, "gcUnitPrice");
            // 
            // repositoryItemCalcEdit1
            // 
            resources.ApplyResources(this.repositoryItemCalcEdit1, "repositoryItemCalcEdit1");
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemCalcEdit1.Buttons"))))});
            this.repositoryItemCalcEdit1.Mask.EditMask = resources.GetString("repositoryItemCalcEdit1.Mask.EditMask");
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gcDiscount
            // 
            resources.ApplyResources(this.gcDiscount, "gcDiscount");
            this.gcDiscount.ColumnEdit = this.repositoryItemTextEdit1;
            this.gcDiscount.DisplayFormat.FormatString = "p";
            this.gcDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcDiscount.FieldName = "Discount";
            this.gcDiscount.ImageOptions.ImageIndex = ((int)(resources.GetObject("gcDiscount.ImageOptions.ImageIndex")));
            this.gcDiscount.Name = "gcDiscount";
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask");
            this.repositoryItemTextEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")));
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Discount", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Discount"))));
            this.svgImageCollection1.Add("Sales", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Sales"))));
            this.svgImageCollection1.Add("UnitPrice", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.UnitPrice"))));
            this.svgImageCollection1.Add("Product", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Product"))));
            this.svgImageCollection1.Add("Quantity", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Quantity"))));
            this.svgImageCollection1.Add("order_id", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.order_id"))));
            // 
            // StyleConditions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcProducts);
            this.Controls.Add(this.sidePanel);
            this.Name = "StyleConditions";
            this.Load += new System.EventHandler(this.StyleConditions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gcOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gcProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotal;
        private ExpressionConditionsEditor expressionConditionsEditor1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.SidePanel sidePanel;
    }
}
