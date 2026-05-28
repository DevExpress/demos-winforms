using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class FixedColumns : TutorialControl {
        public FixedColumns() {
            CreateWaitDialog();
            InitializeComponent();
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        void FixedColumns_Load(object sender, EventArgs e) {
            pivotGridControl1.BeginUpdate();
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            pivotGridControl1.FixedColumnFieldValues.Add(new FixedFieldValue(fieldMin));
            pivotGridControl1.FixedColumnFieldValues.Add(new FixedFieldValue(fieldMax));
            pivotGridControl1.FixedColumnFieldValues.Add(new FixedFieldValue(fieldMedian));
            pivotGridControl1.OptionsMenu.EnablePinColumnMenu = DevExpress.Utils.DefaultBoolean.True;
            pivotGridControl1.EndUpdate();
            SetFormatRules();
        }
        void SetFormatRules() {
            Color minColor = Color.FromArgb(255, 223, 109, 148);
            Color maxColor = Color.FromArgb(255, 78, 182, 166);
            PivotGridFormatRule minHighlightRule =
                CreateHighlightFormatRule(minColor, string.Format("([{0}] > 0) And ([{1}] = [{2}])", fieldExtendedPrice.Name, fieldExtendedPrice.Name, fcFieldMin.Name));
            PivotGridFormatRule maxHighlightRule =
                CreateHighlightFormatRule(maxColor, string.Format("([{0}] > 0) And ([{1}] = [{2}])", fieldExtendedPrice.Name, fieldExtendedPrice.Name, fcFieldMax.Name));

            pivotGridControl1.FormatRules.Add(minHighlightRule);
            pivotGridControl1.FormatRules.Add(maxHighlightRule);
        }
        PivotGridFormatRule CreateHighlightFormatRule(Color color, string expression) {
            PivotGridFormatRule rule = new PivotGridFormatRule();
            rule.Measure = this.fieldExtendedPrice;
            FormatConditionRuleExpression ruleExpression = new FormatConditionRuleExpression();
            ruleExpression.Appearance.BackColor = color;
            ruleExpression.Appearance.Options.UseBackColor = true;
            ruleExpression.Expression = expression;

            rule.Rule = ruleExpression;
            FormatRuleFieldIntersectionSettings settings = new FormatRuleFieldIntersectionSettings();
            settings.Column = this.fieldMonth;
            settings.Row = this.fieldProduct;
            rule.Settings = settings;
            return rule;
        }
        //<rgPinColLocation>
        private void RgPinColLocation_SelectedIndexChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsView.FixedColumnLocation = rgPinColLocation.SelectedIndex == 0 ? FixedColumnStyle.FixedLeft : FixedColumnStyle.FixedRight;
        }
        //</rgPinColLocation>

        //<ceShowColumns>
        private void CeShowColumns_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsView.HideFixedColumnsFromFieldValues = !ceShowColumns.Checked;
        }
        //</ceShowColumns>

    }
}
