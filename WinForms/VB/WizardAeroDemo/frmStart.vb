Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraWizard.Demos

    Public Partial Class frmStart
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            For Each cnt As SkinContainer In SkinManager.Default.Skins
                listBoxControl1.Items.Add(cnt.SkinName)
            Next

            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI)
            listBoxControl1.SelectedItem = UserLookAndFeel.Default.ActiveSkinName
        End Sub

        Public ReadOnly Property SelectedSkinName As String
            Get
                Return listBoxControl1.SelectedItem.ToString()
            End Get
        End Property

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
        End Sub
    End Class
End Namespace
