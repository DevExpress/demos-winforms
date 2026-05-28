Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.XtraScheduler.Demos

    Public Class Car

        Public Sub New(ByVal carId As Integer, ByVal caption As String)
            Id = carId
            Me.Caption = caption
        End Sub

        <Key>
        Public Property Id As Integer

        Public Property Caption As String
    End Class
End Namespace
