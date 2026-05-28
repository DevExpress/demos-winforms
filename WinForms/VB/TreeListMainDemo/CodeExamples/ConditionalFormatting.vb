Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.StyleFormatConditions

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")>
    Public Module ConditionalFormatting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            AddHandler treeList.Load, Sub(s, e) treeList.ExpandAll()
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Apply conditional formatting")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FormatRules")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("FormatConditionRuleValue", "FormatConditionRule2ColorScale")>
        Public Sub CustomizingConditionalFormatting(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim ruleForMark As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            ruleForMark.Condition = DevExpress.XtraEditors.FormatCondition.Expression
            ruleForMark.Expression = "[Mark] == false"
            ruleForMark.Appearance.BackColor = System.Drawing.Color.LightGreen
            treeList.FormatRules.Add(treeList.Columns("Mark"), ruleForMark)
            Dim ruleForTypeOfObject As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            ruleForTypeOfObject.Column = treeList.Columns("RecordDate")
            ruleForTypeOfObject.ColumnApplyTo = treeList.Columns("TypeOfObject")
            Dim colorScale = New DevExpress.XtraEditors.FormatConditionRule2ColorScale With {.PredefinedName = "White, Red"}
            ruleForTypeOfObject.Rule = colorScale
            treeList.FormatRules.Add(ruleForTypeOfObject)
        End Sub
    End Module
End Namespace
