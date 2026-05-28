Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class FixedColumns
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private Sub FixedColumns_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            pivotGridControl1.FixedColumnFieldValues.Add(New FixedFieldValue(fieldMin))
            pivotGridControl1.FixedColumnFieldValues.Add(New FixedFieldValue(fieldMax))
            pivotGridControl1.FixedColumnFieldValues.Add(New FixedFieldValue(fieldMedian))
            pivotGridControl1.OptionsMenu.EnablePinColumnMenu = DevExpress.Utils.DefaultBoolean.True
            pivotGridControl1.EndUpdate()
            SetFormatRules()
        End Sub

        Private Sub SetFormatRules()
            Dim minColor As Color = Color.FromArgb(255, 223, 109, 148)
            Dim maxColor As Color = Color.FromArgb(255, 78, 182, 166)
            Dim minHighlightRule As PivotGridFormatRule = CreateHighlightFormatRule(minColor, String.Format("([{0}] > 0) And ([{1}] = [{2}])", fieldExtendedPrice.Name, fieldExtendedPrice.Name, fcFieldMin.Name))
            Dim maxHighlightRule As PivotGridFormatRule = CreateHighlightFormatRule(maxColor, String.Format("([{0}] > 0) And ([{1}] = [{2}])", fieldExtendedPrice.Name, fieldExtendedPrice.Name, fcFieldMax.Name))
            pivotGridControl1.FormatRules.Add(minHighlightRule)
            pivotGridControl1.FormatRules.Add(maxHighlightRule)
        End Sub

        Private Function CreateHighlightFormatRule(ByVal color As Color, ByVal expression As String) As PivotGridFormatRule
            Dim rule As PivotGridFormatRule = New PivotGridFormatRule()
            rule.Measure = fieldExtendedPrice
            Dim ruleExpression As FormatConditionRuleExpression = New FormatConditionRuleExpression()
            ruleExpression.Appearance.BackColor = color
            ruleExpression.Appearance.Options.UseBackColor = True
            ruleExpression.Expression = expression
            rule.Rule = ruleExpression
            Dim settings As FormatRuleFieldIntersectionSettings = New FormatRuleFieldIntersectionSettings()
            settings.Column = fieldMonth
            settings.Row = fieldProduct
            rule.Settings = settings
            Return rule
        End Function

        '<rgPinColLocation>
        Private Sub RgPinColLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsView.FixedColumnLocation = If(rgPinColLocation.SelectedIndex = 0, FixedColumnStyle.FixedLeft, FixedColumnStyle.FixedRight)
        End Sub

        '</rgPinColLocation>
        '<ceShowColumns>
        Private Sub CeShowColumns_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsView.HideFixedColumnsFromFieldValues = Not ceShowColumns.Checked
        End Sub
    '</ceShowColumns>
    End Class
End Namespace
