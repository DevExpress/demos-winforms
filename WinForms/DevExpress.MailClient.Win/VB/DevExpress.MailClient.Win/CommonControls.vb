Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.MailClient.Win
    Public Class PictureEditSimpleZoom
        Inherits PictureEdit

        Protected Overrides Sub OnMouseWheelCore(ByVal e As MouseEventArgs)
            If Control.ModifierKeys <> Keys.None Then
                Return
            End If
            MyBase.OnMouseWheelCore(e)
        End Sub
    End Class
End Namespace
