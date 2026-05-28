using System.Data;

namespace DevExpress.XtraGrid.Demos {
    public partial class StyleConditions : TutorialControl {
		public StyleConditions() {
			InitializeComponent();
		}
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "StyleConditions", "ExpressionConditionsEditor", "ConditionsItem" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "StyleConditions"; }
        }
        public override Views.Base.BaseView ExportView {
            get { return gvProducts; }
        }
		void StyleConditions_Load(object sender, System.EventArgs e) {
			InitNWindData();
			CreateTimer();
            expressionConditionsEditor1.Init(gvProducts);
		}
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gcProducts.DataSource = ds.Tables["Order Details"];
            repositoryItemLookUpEdit1.DataSource = ds.Tables["Products"];
            return ds;
        }
        //<gcProducts>
        /*
        ~Note: the following code is set at design-time and listed here for educational purposes only.

        DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
        DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
        DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
        DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
        DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
        DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
        DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
        DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
        //
        gridFormatRule1.ApplyToRow = true;
        gridFormatRule1.Column = this.gcQuantity;
        gridFormatRule1.Name = "Format0";
        formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
        formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black;
        formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
        formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
        formatConditionRuleExpression1.Expression = "[Quantity] >= 20 And [Discount] != 0";
        gridFormatRule1.Rule = formatConditionRuleExpression1;
        //
        gridFormatRule2.ApplyToRow = true;
        gridFormatRule2.Column = this.gcQuantity;
        gridFormatRule2.Name = "Format1";
        formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LightPink;
        formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Maroon;
        formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
        formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
        formatConditionRuleExpression2.Expression = "[Quantity] <= 20 AND [Total] < 100";
        gridFormatRule2.Rule = formatConditionRuleExpression2;
        //
        gridFormatRule3.Column = this.gcTotal;
        gridFormatRule3.Name = "Format2";
        formatConditionRuleExpression3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
        formatConditionRuleExpression3.Appearance.Options.UseFont = true;
        formatConditionRuleExpression3.Expression = "[Total] >= 500";
        gridFormatRule3.Rule = formatConditionRuleExpression3;
        //
        gridFormatRule4.ApplyToRow = true;
        gridFormatRule4.Column = this.gcTotal;
        gridFormatRule4.Name = "Format3";
        formatConditionRuleExpression4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
        formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Gray;
        formatConditionRuleExpression4.Appearance.Options.UseFont = true;
        formatConditionRuleExpression4.Appearance.Options.UseForeColor = true;
        formatConditionRuleExpression4.Expression = "[Total] < 50 And [Discount] != 0";
        gridFormatRule4.Rule = formatConditionRuleExpression4;
        //
        this.gvProducts.FormatRules.Add(gridFormatRule1);
        this.gvProducts.FormatRules.Add(gridFormatRule2);
        this.gvProducts.FormatRules.Add(gridFormatRule3);
        this.gvProducts.FormatRules.Add(gridFormatRule4);
        */
        //</gcProducts>
    }
}
