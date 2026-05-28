Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraLayout.Demos

    ''' <summary>
    ''' Summary description for frmPassword.
    ''' </summary>
    Public Partial Class frmPassword
        Inherits XtraEditors.XtraForm

        Public Sub New(ByVal r As Rectangle, ByVal restoreLayout As Boolean)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Left = r.Left + (r.Width - Width) \ 2
            Top = r.Top + (r.Height - Height) \ 2
            If restoreLayout Then Me.RestoreLayout()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private customizationMode As CustomizationModes

        Public Sub SetCustomizationMode(ByVal mode As CustomizationModes)
            customizationMode = mode
            layoutControl1.CustomizationMode = customizationMode
        End Sub

        Public Shared LayoutFileName As String = "frmPasswordLayout.xml"

        Private Sub sbCustomization_Click(ByVal sender As Object, ByVal e As EventArgs)
            layoutControl1.CustomizationMode = customizationMode
            layoutControl1.ShowCustomizationForm()
        '   layoutControl1.CustomizationMode = customizationMode;
        End Sub

        Private Sub RestoreLayout()
            If IO.File.Exists(LayoutFileName) Then layoutControl1.RestoreLayoutFromXml(LayoutFileName)
        End Sub

        Public Sub SaveLayout()
            layoutControl1.SaveLayoutToXml(LayoutFileName)
        End Sub
    End Class
End Namespace
