using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.StyleFormatConditions;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")]
    public static class ConditionalFormatting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(10);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Conditional formatting
        [CodeExampleCase("Apply conditional formatting"), SampleDataSourceFile]
        public static void AddColumnsManually(VGridControl vGridControl) {
            FormatConditionRuleValue markRule = new FormatConditionRuleValue();
            markRule.Condition = FormatCondition.Expression;
            markRule.Expression = "[Mark] = false";
            markRule.Appearance.BackColor = Color.LightGreen;
            vGridControl.FormatRules.Add(vGridControl.Rows["Mark"].Properties, markRule);

            VGridFormatRule typeOfObjectRule = new VGridFormatRule();
            FormatConditionRule2ColorScale colorScaleRule = new FormatConditionRule2ColorScale();
            typeOfObjectRule.RowProperties = vGridControl.Rows["Length"].Properties;
            typeOfObjectRule.RowPropertiesApplyTo = vGridControl.Rows["Name"].Properties;
            colorScaleRule.PredefinedName = "White, Red";
            typeOfObjectRule.Rule = colorScaleRule;
            vGridControl.FormatRules.Add(typeOfObjectRule);
        }
        #endregion
    }
}
