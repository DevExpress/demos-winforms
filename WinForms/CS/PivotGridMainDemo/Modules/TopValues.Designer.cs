namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class TopValues {
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition3 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.ceTopValuesShowOthers = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.icbField = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.seTop = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTopValuesShowOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ceTopValuesShowOthers
            // 
            this.ceTopValuesShowOthers.Location = new System.Drawing.Point(11, 112);
            this.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers";
            this.ceTopValuesShowOthers.Properties.Caption = "Show \"Others\" value";
            this.ceTopValuesShowOthers.Size = new System.Drawing.Size(177, 19);
            this.ceTopValuesShowOthers.StyleController = this.layoutControl1;
            this.ceTopValuesShowOthers.TabIndex = 2;
            this.ceTopValuesShowOthers.CheckedChanged += new System.EventHandler(this.ceTopValuesShowOthers_CheckedChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceTopValuesShowOthers);
            this.layoutControl1.Controls.Add(this.icbField);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.seTop);
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(450, 357, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(199, 509);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // icbField
            // 
            this.icbField.EditValue = "imageComboBoxEdit1";
            this.icbField.Location = new System.Drawing.Point(11, 88);
            this.icbField.Name = "icbField";
            this.icbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbField.Size = new System.Drawing.Size(177, 20);
            this.icbField.StyleController = this.layoutControl1;
            this.icbField.TabIndex = 1;
            this.icbField.SelectedIndexChanged += new System.EventHandler(this.icbField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.StyleController = this.layoutControl1;
            this.label1.TabIndex = 8;
            this.label1.Text = "Values for the Field: ";
            // 
            // seTop
            // 
            this.seTop.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seTop.Location = new System.Drawing.Point(11, 47);
            this.seTop.Name = "seTop";
            this.seTop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seTop.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seTop.Properties.IsFloatValue = false;
            this.seTop.Properties.Mask.EditMask = "N00";
            this.seTop.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.seTop.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTop.Size = new System.Drawing.Size(177, 20);
            this.seTop.StyleController = this.layoutControl1;
            this.seTop.TabIndex = 0;
            this.seTop.EditValueChanged += new System.EventHandler(this.seTop_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Appearance.Options.UseBackColor = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.StyleController = this.layoutControl1;
            this.label2.TabIndex = 6;
            this.label2.Text = "Show Top:";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 509);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(181, 17);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 142);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 367);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seTop;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.label1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(181, 17);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.icbField;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(181, 24);
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceTopValuesShowOthers;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(181, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(677, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 536);
            this.sidePanel1.TabIndex = 13;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 536);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 536);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 509);
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Width = 120;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 2;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldSalesPerson.Width = 140;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 3;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldProductName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldProductName.Width = 180;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 1;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldCategoryName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldCategoryName.Width = 160;
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order ID";
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.SortBySummaryInfo.Field = this.fieldExtendedPrice;
            this.fieldOrderID.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ActiveFilterString = "";
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderID,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldSalesPerson,
            this.fieldExtendedPrice});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition1.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition1.FieldName = "";
            pivotGridStyleFormatCondition1.Value1 = 10000;
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition2.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition2.FieldName = "";
            pivotGridStyleFormatCondition2.Value1 = 350;
            pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = false;
            pivotGridStyleFormatCondition3.ApplyToTotalCell = false;
            pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition3.FieldName = "";
            pivotGridStyleFormatCondition3.Value1 = 0.1F;
            this.pivotGridControl1.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2,
            pivotGridStyleFormatCondition3});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(677, 536);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CustomDrawFieldValue += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(this.pivotGridControl1_CustomDrawFieldValue);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 142);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Top N";
            // 
            // TopValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TopValues";
            this.Size = new System.Drawing.Size(877, 536);
            this.Load += new System.EventHandler(this.TopValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTopValuesShowOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.ImageComboBoxEdit icbField;
        private DevExpress.XtraEditors.SpinEdit seTop;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.CheckEdit ceTopValuesShowOthers;
        private System.ComponentModel.IContainer components = null;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldSalesPerson;
        private PivotGridField fieldProductName;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldOrderID;
        private PivotGridControl pivotGridControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
