Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid.StyleFormatConditions
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")>
    Public Module ConditionalFormatting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Conditional formatting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Apply conditional formatting"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        Public Sub AddColumnsManually(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            Dim markRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            markRule.Condition = DevExpress.XtraEditors.FormatCondition.Expression
            markRule.Expression = "[Mark] = false"
            markRule.Appearance.BackColor = System.Drawing.Color.LightGreen
            vGridControl.FormatRules.Add(vGridControl.Rows(CStr(("Mark"))).Properties, markRule)
            Dim typeOfObjectRule As DevExpress.XtraVerticalGrid.StyleFormatConditions.VGridFormatRule = New DevExpress.XtraVerticalGrid.StyleFormatConditions.VGridFormatRule()
            Dim colorScaleRule As DevExpress.XtraEditors.FormatConditionRule2ColorScale = New DevExpress.XtraEditors.FormatConditionRule2ColorScale()
            typeOfObjectRule.RowProperties = vGridControl.Rows(CStr(("Length"))).Properties
            typeOfObjectRule.RowPropertiesApplyTo = vGridControl.Rows(CStr(("Name"))).Properties
            colorScaleRule.PredefinedName = "White, Red"
            typeOfObjectRule.Rule = colorScaleRule
            vGridControl.FormatRules.Add(typeOfObjectRule)
        End Sub
#End Region
    End Module
End Namespace
