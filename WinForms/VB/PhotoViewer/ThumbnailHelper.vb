Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors

Namespace PhotoViewer

    Public Class ThumbnailHelper

        Private Shared defaultHelper As ThumbnailHelper

        Public Shared ReadOnly Property [Default] As ThumbnailHelper
            Get
                If defaultHelper Is Nothing Then defaultHelper = New ThumbnailHelper()
                Return defaultHelper
            End Get
        End Property

        Private thumbnailsCore As Dictionary(Of String, Image)

        Protected ReadOnly Property Thumbnails As Dictionary(Of String, Image)
            Get
                If thumbnailsCore Is Nothing Then thumbnailsCore = New Dictionary(Of String, Image)()
                Return thumbnailsCore
            End Get
        End Property

        Public Function CreateThumbnail(ByVal image As Image, ByVal length As Integer) As Image
            Dim rect As Rectangle = ImageLayoutHelper.GetImageBounds(New Rectangle(0, 0, length, length), image.Size, ImageLayoutMode.ZoomInside)
            Dim bmp As Bitmap = New Bitmap(rect.Width, rect.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                rect.X = 0
                rect.Y = 0
                g.DrawImage(image, rect)
            End Using

            Return bmp
        End Function

        Public Function CreateThumbnail(ByVal image As Image, ByVal fileName As String, ByVal length As Integer, ByVal thumbPath As String) As Image
            Dim bmp As Image = CreateThumbnail(image, length)
            Dim thumbFileName As String = length.ToString() & "_" & fileName
            Dim digest As String = CalculateDigest(thumbFileName)
            Try
                If Not Directory.Exists(thumbPath) Then Directory.CreateDirectory(thumbPath)
            Catch e As Exception
                XtraMessageBox.Show("Error creating thumnail for image '" & fileName & "'. " & e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return bmp
        End Function

        Public Function GetThumbnail(ByVal fileName As String, ByVal length As Integer, ByVal thumbPath As String) As Image
            Dim thumbFileName As String = length.ToString() & "_" & fileName
            thumbFileName = CalculateDigest(thumbFileName)
            thumbFileName = thumbPath & thumbFileName
            Dim imgThumbnail As Image = Nothing
            If Thumbnails.TryGetValue(thumbFileName, imgThumbnail) Then Return imgThumbnail
            Try
                If File.Exists(thumbFileName) Then Return Image.FromFile(thumbFileName)
            Catch e As Exception
                XtraMessageBox.Show("Error creating thumnail for image '" & fileName & "'. " & e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                Using img As Image = Image.FromFile(fileName)
                    Return CreateThumbnail(img, fileName, length, thumbPath)
                End Using
            Catch
                Return Nothing
            End Try
        End Function

        Private Shared Function CalculateDigest(ByVal input As String) As String
            Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(input)
            Dim digestBytes As Byte() = HashCodeHelper.Persistent.CreateRH5Digest(inputBytes)
            Dim sb As StringBuilder = New StringBuilder(32)
            For i As Integer = 0 To digestBytes.Length - 1
                sb.Append(digestBytes(i).ToString("X2"))
            Next

            Return sb.ToString()
        End Function
    End Class
End Namespace
