Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class AddNewBonus
        Inherits XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private pivot As PivotGridControl

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property PivotGrid As PivotGridControl
            Get
                Return pivot
            End Get

            Set(ByVal value As PivotGridControl)
                pivot = value
            End Set
        End Property

        Private Sub teBonusName_EditValueChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs)
            If String.IsNullOrEmpty(teBonusName.Text) Then
                buttonOK.Enabled = False
                beExpression.Enabled = False
            Else
                buttonOK.Enabled = True
                beExpression.Enabled = True
            End If
        End Sub

        Private Function GetNewInvisibleBonusField() As PivotGridField
            Dim newBonusField As PivotGridField = New PivotGridField("", PivotArea.DataArea)
            newBonusField.Name = "field_" & teBonusName.Text
            newBonusField.Caption = teBonusName.Text
            newBonusField.Visible = False
            newBonusField.DataBinding = New ExpressionDataBinding(beExpression.Text)
            newBonusField.Options.ShowExpressionEditorMenu = True
            Return newBonusField
        End Function

        Private Sub beExpression_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
            PivotGrid.Fields.Add(newBonus)
            PivotGrid.ShowExpressionEditor(newBonus)
            beExpression.Text = CType(newBonus.DataBinding, ExpressionDataBinding).Expression
            PivotGrid.Fields.Remove(newBonus)
        End Sub

        Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
            newBonus.Visible = True
            newBonus.AreaIndex = PivotGrid.GetFieldsByArea(PivotArea.DataArea).Count
            newBonus.Tag = "removable"
            PivotGrid.Fields.Add(newBonus)
            teBonusName.Text = String.Empty
            buttonOK.Enabled = False
            beExpression.Text = String.Empty
            beExpression.Enabled = False
            DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace
