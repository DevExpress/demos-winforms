Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace DevExpress.XtraScheduler.Demos

    Public Class Medic

        <Key>
        Public Property Id As Long

        Public Property Name As String

        Public Property Phone As String

        Public Property PhotoBytes As Byte()

        Public Property DepartmentId As Long?

        Public Sub SetPhoto(ByVal image As Image)
            If image Is Nothing Then
                PhotoBytes = Nothing
                Return
            End If

            Using stream As MemoryStream = New MemoryStream()
                image.Save(stream, ImageFormat.Jpeg)
                PhotoBytes = stream.ToArray()
            End Using
        End Sub

        Public Function GetPhoto() As Image
            If PhotoBytes Is Nothing Then Return Nothing
            Using stream As MemoryStream = New MemoryStream(PhotoBytes)
                Return Image.FromStream(stream)
            End Using
        End Function
    End Class
End Namespace
