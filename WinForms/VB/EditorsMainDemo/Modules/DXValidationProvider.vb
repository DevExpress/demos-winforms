Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleDXValidationProvider
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitValidationRules()
            InitFieldValues()
            InitAlignmentValues()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"DXValidationProvider"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "dxvalidationprovider"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub InitAlignmentValues()
            icbIconAlignment.Properties.Items.AddEnum(GetType(ErrorIconAlignment))
            icbIconAlignment.EditValue = ErrorIconAlignment.MiddleLeft
        End Sub

        Private Sub ModuleDXValidationProvider_Load(ByVal sender As Object, ByVal e As EventArgs)
            manualValidate.Checked = True
            dxValidationProvider1.ValidationMode = ValidationMode.Manual
            dxValidationProvider1.Validate()
        End Sub

        ' <autoValidateCheck>
        ' <manualValidate>
        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dxValidationProvider1.ValidationMode = If(manualValidate.Checked, ValidationMode.Manual, ValidationMode.Auto)
            btnValidate.Enabled = manualValidate.Checked
        End Sub

        ' </manualValidate>
        ' </autoValidateCheck>
        Private Sub InitValidationRules()
            ' <notEmptyTextEdit> 
            Dim notEmptyValidationRule As ConditionValidationRule = New ConditionValidationRule()
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
            notEmptyValidationRule.ErrorText = "Please enter a value"
            ' </notEmptyTextEdit>
            ' <rangeTextEdit>
            Dim rangeValidationRule As ConditionValidationRule = New ConditionValidationRule()
            rangeValidationRule.ConditionOperator = ConditionOperator.Between
            rangeValidationRule.Value1 = 1
            rangeValidationRule.Value2 = 100
            rangeValidationRule.ErrorText = "Please enter a value between 1 and 100"
            ' </rangeTextEdit>
            ' <notEqualsComboBoxEdit>
            Dim notEqualsValidationRule As ConditionValidationRule = New ConditionValidationRule()
            notEqualsValidationRule.ConditionOperator = ConditionOperator.NotEquals
            notEqualsValidationRule.Value1 = "(select)"
            notEqualsValidationRule.ErrorText = "Please choose a value"
            notEqualsValidationRule.ErrorType = ErrorType.Information
            ' </notEqualsComboBoxEdit>
            ' <containsTextEdit>
            Dim containsValidationRule As ConditionValidationRule = New ConditionValidationRule()
            containsValidationRule.ConditionOperator = ConditionOperator.Contains
            containsValidationRule.Value1 = "@"c
            containsValidationRule.ErrorText = "Please enter a valid email"
            containsValidationRule.ErrorType = ErrorType.Warning
            ' </containsTextEdit>
            ' <compareTextEdit>
            Dim compareValidationRule As CompareAgainstControlValidationRule = New CompareAgainstControlValidationRule()
            compareValidationRule.Control = notEmptyTextEdit
            compareValidationRule.CompareControlOperator = CompareControlOperator.Equals
            compareValidationRule.ErrorText = "Please enter a value that equals to the first editor's value"
            compareValidationRule.CaseSensitive = True
            ' </compareTextEdit>
            ' <customTextEdit>
            Dim customValidationRule As CustomValidationRule = New CustomValidationRule()
            customValidationRule.ErrorText = "Please enter a valid person name"
            customValidationRule.ErrorType = ErrorType.Warning
            ' </customTextEdit>
            ' <notEmptyTextEdit>
            dxValidationProvider1.SetValidationRule(notEmptyTextEdit, notEmptyValidationRule)
            ' </notEmptyTextEdit>
            ' <rangeTextEdit>
            dxValidationProvider1.SetValidationRule(rangeTextEdit, rangeValidationRule)
            ' </rangeTextEdit>
            ' <containsTextEdit>
            dxValidationProvider1.SetValidationRule(containsTextEdit, containsValidationRule)
            ' </containsTextEdit>
            ' <notEqualsComboBoxEdit>
            dxValidationProvider1.SetValidationRule(notEqualsComboBoxEdit, notEqualsValidationRule)
            ' </notEqualsComboBoxEdit>
            dxValidationProvider1.SetValidationRule(compareTextEdit, compareValidationRule)
            ' <customTextEdit>
            dxValidationProvider1.SetValidationRule(customTextEdit, customValidationRule)
        ' </customTextEdit>
        End Sub

        Private Sub InitFieldValues()
            notEmptyTextEdit.EditValue = "DevExpress"
            rangeTextEdit.EditValue = 570
            containsTextEdit.EditValue = "support@devexpress.com"
            notEqualsComboBoxEdit.EditValue = "(select)"
            compareTextEdit.EditValue = notEmptyTextEdit.EditValue
            customTextEdit.EditValue = "Mr. Smith"
        End Sub

        ' <manualValidate>
        ' <btnValidate>
        Private Sub btnValidate_Click(ByVal sender As Object, ByVal e As EventArgs)
            dxValidationProvider1.Validate()
        End Sub

        ' </btnValidate>
        ' </manualValidate>
#Region "CustomValidationRule"
        ' <customTextEdit>
        Public Class CustomValidationRule
            Inherits ValidationRule

            Public Overrides Function Validate(ByVal control As Control, ByVal value As Object) As Boolean
                Dim str As String = CStr(value)
                Dim values As String() = New String() {"Dr.", "Mr.", "Mrs.", "Miss", "Ms."}
                Dim res As Boolean = False
                For Each val As String In values
                    If ValidationHelper.Validate(str, ConditionOperator.BeginsWith, val, Nothing, Nothing, False) Then
                        Dim _name As String = str.Substring(val.Length)
                        If _name.Trim().Length > 0 Then res = True
                    End If
                Next

                Return res
            End Function
        End Class

        ' </customTextEdit>
        ' <icbIconAlignment>
        Private Sub icbIconAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each ctrl As Control In layoutControl1.Controls
                If TypeOf ctrl Is BaseEdit Then dxValidationProvider1.SetIconAlignment(ctrl, CType(icbIconAlignment.EditValue, ErrorIconAlignment))
            Next
        End Sub

        ' </icbIconAlignment>
#End Region
        Private Function GetControlCollection(ByVal page As XtraTab.XtraTabPage) As ControlCollection
            If page.Controls.Count < 2 Then Return page.Controls(0).Controls
            Return page.Controls
        End Function
    End Class
End Namespace
