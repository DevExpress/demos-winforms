namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class FormatRules {
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
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule1 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings1 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule2 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings1 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule3 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings2 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule4 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings3 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule5 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet2 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet2 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings4 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule6 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule2ColorScale formatConditionRule2ColorScale1 = new DevExpress.XtraEditors.FormatConditionRule2ColorScale();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings5 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule7 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleTopBottom formatConditionRuleTopBottom1 = new DevExpress.XtraEditors.FormatConditionRuleTopBottom();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings6 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Order Quarter";
            this.fieldQuarter.DataBinding = new DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter);
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountry.AreaIndex = 1;
            this.fieldCountry.DataBinding = new DataSourceColumnBinding("Country");
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldExtendedPrice2
            // 
            this.fieldExtendedPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice2.AreaIndex = 1;
            this.fieldExtendedPrice2.Caption = "Variation";
            this.fieldExtendedPrice2.DataBinding = new DifferenceBinding(new DataSourceColumnBinding("Extended Price"), CalculationPartitioningCriteria.RowValue, DifferenceTarget.Previous, DifferenceType.Absolute);
            this.fieldExtendedPrice2.Name = "fieldExtendedPrice2";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.DataBinding = new DataSourceColumnBinding("CategoryName");
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.DataBinding = new DataSourceColumnBinding("Extended Price");
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivotGridControl1
            //
            this.pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.ActiveFilterString = "";
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldQuarter,
            this.fieldExtendedPrice,
            this.fieldExtendedPrice2,
            this.fieldYear,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldCountry,
            this.fieldSalesPerson});
            pivotGridFormatRule1.Measure = this.fieldExtendedPrice2;
            pivotGridFormatRule1.Name = "AbsVarDataBar";
            formatConditionRuleDataBar1.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            formatConditionRuleDataBar1.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleDataBar1.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            formatConditionRuleDataBar1.Appearance.Options.UseBackColor = true;
            formatConditionRuleDataBar1.Appearance.Options.UseBorderColor = true;
            formatConditionRuleDataBar1.AppearanceNegative.BackColor = System.Drawing.Color.White;
            formatConditionRuleDataBar1.AppearanceNegative.BackColor2 = System.Drawing.Color.LightCoral;
            formatConditionRuleDataBar1.AppearanceNegative.BorderColor = System.Drawing.Color.RosyBrown;
            formatConditionRuleDataBar1.AppearanceNegative.Options.UseBackColor = true;
            formatConditionRuleDataBar1.AppearanceNegative.Options.UseBorderColor = true;
            formatConditionRuleDataBar1.PredefinedName = null;
            formatConditionRuleDataBar1.ShowBarOnly = true;
            pivotGridFormatRule1.Rule = formatConditionRuleDataBar1;
            formatRuleFieldIntersectionSettings1.Column = this.fieldQuarter;
            formatRuleFieldIntersectionSettings1.Row = this.fieldCountry;
            pivotGridFormatRule1.Settings = formatRuleFieldIntersectionSettings1;
            pivotGridFormatRule2.Measure = this.fieldExtendedPrice2;
            pivotGridFormatRule2.Name = "AbsVarGreater0";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.YellowGreen;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = 0;
            pivotGridFormatRule2.Rule = formatConditionRuleValue1;
            pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings1;
            pivotGridFormatRule3.Measure = this.fieldExtendedPrice2;
            pivotGridFormatRule3.Name = "AbsVarLess0";
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less;
            formatConditionRuleValue2.Value1 = 0;
            pivotGridFormatRule3.Rule = formatConditionRuleValue2;
            formatRuleFieldIntersectionSettings2.Column = this.fieldQuarter;
            formatRuleFieldIntersectionSettings2.Row = this.fieldCategoryName;
            pivotGridFormatRule3.Settings = formatRuleFieldIntersectionSettings2;
            pivotGridFormatRule4.Measure = this.fieldExtendedPrice2;
            pivotGridFormatRule4.Name = "Format4";
            formatConditionIconSet1.CategoryName = "Directional";
            formatConditionIconSetIcon1.PredefinedName = "Triangles3_1.png";
            formatConditionIconSetIcon2.PredefinedName = "Triangles3_3.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Name = "Triangles3";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            pivotGridFormatRule4.Rule = formatConditionRuleIconSet1;
            formatRuleFieldIntersectionSettings3.Column = this.fieldQuarter;
            formatRuleFieldIntersectionSettings3.Row = this.fieldCategoryName;
            pivotGridFormatRule4.Settings = formatRuleFieldIntersectionSettings3;
            pivotGridFormatRule4.StopIfTrue = true;
            pivotGridFormatRule5.Measure = this.fieldExtendedPrice2;
            pivotGridFormatRule5.Name = "Format1";
            formatConditionIconSet2.CategoryName = "Directional";
            formatConditionIconSetIcon3.PredefinedName = "Arrows4_1.png";
            formatConditionIconSetIcon4.PredefinedName = "Arrows4_4.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet2.Name = "Arrows4Colored";
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2;
            pivotGridFormatRule5.Rule = formatConditionRuleIconSet2;
            formatRuleFieldIntersectionSettings4.Column = this.fieldQuarter;
            pivotGridFormatRule5.Settings = formatRuleFieldIntersectionSettings4;
            pivotGridFormatRule6.Measure = this.fieldExtendedPrice;
            pivotGridFormatRule6.Name = "Format5";
            formatConditionRule2ColorScale1.PredefinedName = "Yellow, Green";
            pivotGridFormatRule6.Rule = formatConditionRule2ColorScale1;
            formatRuleFieldIntersectionSettings5.Column = this.fieldQuarter;
            formatRuleFieldIntersectionSettings5.Row = this.fieldCountry;
            pivotGridFormatRule6.Settings = formatRuleFieldIntersectionSettings5;
            pivotGridFormatRule7.Measure = this.fieldExtendedPrice;
            pivotGridFormatRule7.Name = "Top 3 Sale";
            formatConditionRuleTopBottom1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleTopBottom1.Appearance.Options.UseFont = true;
            formatConditionRuleTopBottom1.Rank = new decimal(new int[] {
            3,
            0,
            0,
            0});
            formatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            pivotGridFormatRule7.Rule = formatConditionRuleTopBottom1;
            formatRuleFieldIntersectionSettings6.Column = this.fieldQuarter;
            formatRuleFieldIntersectionSettings6.Row = this.fieldCountry;
            pivotGridFormatRule7.Settings = formatRuleFieldIntersectionSettings6;
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule1);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule3);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule4);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule5);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule6);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule7);
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = true;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(704, 416);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.Click += new System.EventHandler(this.pivotGridControl1_Click);
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Order Year";
            this.fieldYear.DataBinding = new DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear);
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProductName.AreaIndex = 2;
            this.fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Visible = false;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.DataBinding = new DataSourceColumnBinding("Sales Person");
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // FormatRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "FormatRules";
            this.Size = new System.Drawing.Size(704, 416);
            this.Load += new System.EventHandler(this.StyleConditions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private System.ComponentModel.IContainer components = null;
		private PivotGridControl pivotGridControl1;
        private PivotGridField fieldQuarter;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldYear;
        private PivotGridField fieldExtendedPrice2;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldProductName;
        private PivotGridField fieldCountry;
        private PivotGridField fieldSalesPerson;

    }
}
