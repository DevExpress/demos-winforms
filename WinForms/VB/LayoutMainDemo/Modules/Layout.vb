Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class Layout
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Private Sub Layout_Load(ByVal sender As Object, ByVal e As EventArgs)
            DisableDeleteButton()
            timer1.Start()
        End Sub

        Private Sub DisableButtons(ByVal disable As Boolean)
            sbOpen.Enabled = disable
        End Sub

        Private Sub DisableDeleteButton()
            sbDelete.Enabled = IO.File.Exists(frmPassword.LayoutFileName)
        End Sub

        Private Sub OpenForm(ByVal restoreLayout As Boolean)
            Dim dlg As frmPassword = New frmPassword(sbOpen.Parent.RectangleToScreen(sbOpen.Parent.Bounds), restoreLayout)
            If checkBox1.Checked Then
                dlg.SetCustomizationMode(CustomizationModes.Quick)
            Else
                dlg.SetCustomizationMode(CustomizationModes.Default)
            End If

            DisableButtons(False)
            If dlg.ShowDialog() = DialogResult.OK Then
                dlg.SaveLayout()
            End If

            dlg.Dispose()
            DisableButtons(True)
            DisableDeleteButton()
        End Sub

        Private Sub sbOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            OpenForm(True)
        End Sub

        Private Sub sbDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
            If IO.File.Exists(frmPassword.LayoutFileName) Then IO.File.Delete(frmPassword.LayoutFileName)
            DisableDeleteButton()
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            timer1.Stop()
            OpenForm(True)
        End Sub
    End Class
End Namespace
