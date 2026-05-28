Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraWizard.Demos

    Public Partial Class frmMain
        Inherits XtraForm

        Private finish As Boolean = False

        Public Sub New()
            InitializeComponent()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraWizard.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Private Sub wizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As WizardPageChangingEventArgs)
            If e.PrevPage Is wpCardTemplate AndAlso e.Direction = Direction.Forward Then e.Page = If(ceSignature.Checked, wpSignature, wpPreview)
            If e.PrevPage Is wpPreview AndAlso e.Direction = Direction.Backward Then e.Page = If(ceSignature.Checked, wpSignature, wpCardTemplate)
            If e.Page Is wpPreview AndAlso e.Direction = Direction.Forward Then CreateCardPreview()
        End Sub

        Private Sub wizardControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As WizardPageChangedEventArgs)
            If e.Page Is wpRecipientData Then teRecipientName.Focus()
            If e.Page Is wpSignature Then teYourName.Focus()
        End Sub

        Private Sub teRecipient_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            wpRecipientData.AllowNext = Not Equals(teRecipientName.Text, String.Empty) AndAlso Not Equals(teEmail.Text, String.Empty)
        End Sub

        Private Sub teYourName_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            wpSignature.AllowNext = Not Equals(teYourName.Text, String.Empty)
        End Sub

        Private Sub sbSkipSignature_Click(ByVal sender As Object, ByVal e As EventArgs)
            teYourName.Text = String.Empty
            ceSignature.Checked = False
            wizardControl1.SelectedPage = wpPreview
        End Sub

        Private Sub CreateCardPreview()
            meCard.Text = String.Format("Happy birthday, {0}!!!" & Microsoft.VisualBasic.Constants.vbCrLf & "{1}", teRecipientName.Text, rgWishes.Properties.Items(CInt(rgWishes.SelectedIndex)).Description)
            If ceSignature.Checked Then meCard.Text += String.Format(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "{0}, {1}", cbeSignatureTemplate.Text, teYourName.Text)
        End Sub

        Private Sub sbSend_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim emailTag As String = String.Format("mailto:{0}?subject={1}&body={2}", Uri.EscapeDataString(teEmail.Text), Uri.EscapeDataString("Happy Birthday!"), Uri.EscapeDataString(meCard.Text))
            Data.Utils.SafeProcess.Start(emailTag)
        End Sub

        Private Sub wizardControl1_CancelClick(ByVal sender As Object, ByVal e As CancelEventArgs)
            Close()
        End Sub

        Private Sub wizardControl1_FinishClick(ByVal sender As Object, ByVal e As CancelEventArgs)
            finish = True
            Close()
        End Sub

        Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If finish Then Return
            If XtraMessageBox.Show(Me, "Do you want to exit the XtraWizard control demo?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then e.Cancel = True
        End Sub

        Private Sub teEmail_InvalidValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            e.ErrorText = "Invalid email address"
        End Sub
    End Class
End Namespace
