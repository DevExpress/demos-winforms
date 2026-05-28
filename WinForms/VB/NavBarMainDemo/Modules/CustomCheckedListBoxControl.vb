Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing

Namespace NavBarMainDemo.Modules

    Public Class CustomCheckedListBoxControl
        Inherits CheckedListBoxControl

        Public Sub New()
            MyBase.New()
            AddHandler LookAndFeel.StyleChanged, AddressOf OnLookAndFeelStyleChanged
        End Sub

        Protected Sub OnLookAndFeelStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateAppearance()
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateAppearance()
        End Sub

        Protected Sub UpdateAppearance()
            If Parent IsNot Nothing Then
                ForeColor = If(Parent.ForeColor = Color.Transparent, SystemColors.ControlText, Parent.ForeColor)
                BackColor = If(Parent.BackColor = Color.Transparent, SystemColors.Control, Parent.BackColor)
            End If
        End Sub
    End Class
End Namespace
