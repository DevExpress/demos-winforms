namespace Examples {
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.StyleFormatConditions;

    [CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")]
    public static class ConditionalFormatting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.GetData();
            treeList.Load += (s, e) => treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Apply conditional formatting")]
        [CodeExampleUnderlineTokens("FormatRules")]
        [CodeExampleHighlightTokens("FormatConditionRuleValue", "FormatConditionRule2ColorScale")]
        public static void CustomizingConditionalFormatting(TreeList treeList) {
            FormatConditionRuleValue ruleForMark = new FormatConditionRuleValue();
            ruleForMark.Condition = FormatCondition.Expression;
            ruleForMark.Expression = "[Mark] == false";
            ruleForMark.Appearance.BackColor = Color.LightGreen;
            treeList.FormatRules.Add(treeList.Columns["Mark"], ruleForMark);

            TreeListFormatRule ruleForTypeOfObject = new TreeListFormatRule();
            ruleForTypeOfObject.Column = treeList.Columns["RecordDate"];
            ruleForTypeOfObject.ColumnApplyTo = treeList.Columns["TypeOfObject"];
            var colorScale = new FormatConditionRule2ColorScale
            {
                PredefinedName = "White, Red"
            };
            ruleForTypeOfObject.Rule = colorScale;
            treeList.FormatRules.Add(ruleForTypeOfObject);
        }
    }
}
