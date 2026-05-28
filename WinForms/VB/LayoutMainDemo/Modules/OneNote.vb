Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraLayout.Demos

    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Public Partial Class OneNote
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            webBrowser1.Url = New Uri("https://www.devexpress.com/Products/NET/Controls/WinForms/Layout/")
        End Sub
    End Class
End Namespace
