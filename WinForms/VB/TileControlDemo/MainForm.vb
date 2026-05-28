Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.TileControlDemo

    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            AddHandler userControl11.OnDesktopClick, AddressOf userControl11_OnDesktopClick
        End Sub

        Private Sub userControl11_OnDesktopClick(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
