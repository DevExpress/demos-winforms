Imports DevExpress.XtraEditors
Imports System

Namespace DevExpress.WindowsMailClient.Win.Forms

    Public Partial Class EmailSignatureEditForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            toggleSwitch1.EditValue = CBool(Utils.UseAsEmailSignature)
            signatureEditFormControl1.LoadText(Utils.StartMhtText)
        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.StartMhtText = signatureEditFormControl1.GetText()
            Close()
        End Sub

        Private Sub toggleSwitch1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Utils.UseAsEmailSignature = CBool(CType(sender, ToggleSwitch).EditValue)
        End Sub
    End Class
End Namespace
