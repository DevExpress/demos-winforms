Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.Utils.Svg

Namespace DevExpress.Utils

    Public Class MappedSvgInfoCreator
        Inherits SvgImageInfoCreator

        Public Overrides Function Create(ByVal name As String, ByVal imageUri As DxImageUri, ByVal size As Size) As SvgImageInfo
            imageUri.ResourceType = GetType(DevAV.MainForm)
            imageUri.Uri = GetFluentIconName(imageUri.Uri)
            Return MyBase.Create(name, imageUri, size)
        End Function
    End Class

    Public Class MappedSvgImageCollection
        Inherits SvgImageCollection

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub

        Protected Overrides Function CreateImageInfoCreator() As ImageInfoCreator(Of SvgImage, SvgImageInfo)
            Return New MappedSvgInfoCreator()
        End Function
    End Class
End Namespace
