Imports System
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

        Public ReadOnly Property AllowAnimation As Boolean
            Get
                Return checkEdit1.Checked
            End Get
        End Property

        Public ReadOnly Property AllowSkin4Form As Boolean
            Get
                Return checkEdit2.Checked
            End Get
        End Property

        Public ReadOnly Property WizardStyle As WizardStyle
            Get
                Return WizardStyle.Wizard97
            End Get
        End Property

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
        End Sub
    End Class
End Namespace
