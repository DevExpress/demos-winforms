Imports System
Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace RibbonDemos

    Public Class SkinGalleryHelper
        Implements IDisposable

#Region "static "
        Private Shared Function GetSkinImage(ByVal button As SimpleButton, ByVal width As Integer, ByVal height As Integer, ByVal indent As Integer) As Bitmap
            Dim image As Bitmap = New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(image)
                Dim info As StyleObjectInfoArgs = New StyleObjectInfoArgs(New GraphicsCache(g))
                info.Bounds = New Rectangle(0, 0, width, height)
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info)
                button.LookAndFeel.Painter.Border.DrawObject(info)
                info.Bounds = New Rectangle(indent, indent, width - indent * 2, height - indent * 2)
                button.LookAndFeel.Painter.Button.DrawObject(info)
            End Using

            Return image
        End Function

#End Region
        Private ReadOnly ribbonGallerySkins As DevExpress.XtraBars.RibbonGalleryBarItem

        Public Sub New(ByVal ribbonGallerySkins As DevExpress.XtraBars.RibbonGalleryBarItem)
            Me.ribbonGallerySkins = ribbonGallerySkins
            InitBarItem()
            FillImages()
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            If ribbonGallerySkins IsNot Nothing Then
                RemoveHandler ribbonGallerySkins.Gallery.ItemClick, New GalleryItemClickEventHandler(AddressOf ItemClick)
                RemoveHandler ribbonGallerySkins.Gallery.InitDropDownGallery, New InplaceGalleryEventHandler(AddressOf InitDropDownGallery)
            End If
        End Sub

        Private Sub InitBarItem()
            Dim galleryItemGroup4 As GalleryItemGroup = New GalleryItemGroup()
            Dim galleryItemGroup5 As GalleryItemGroup = New GalleryItemGroup()
            Dim galleryItemGroup6 As GalleryItemGroup = New GalleryItemGroup()
            ribbonGallerySkins.Gallery.AllowHoverImages = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            ribbonGallerySkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            ribbonGallerySkins.Gallery.ColumnCount = 4
            ribbonGallerySkins.Gallery.FixedHoverImageSize = False
            galleryItemGroup4.Caption = "Main Skins"
            galleryItemGroup5.Caption = "Office Skins"
            galleryItemGroup6.Caption = "Bonus Skins"
            ribbonGallerySkins.Gallery.Groups.AddRange(New GalleryItemGroup() {galleryItemGroup4, galleryItemGroup5, galleryItemGroup6})
            ribbonGallerySkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
            ribbonGallerySkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
            ribbonGallerySkins.Gallery.RowCount = 4
            AddHandler ribbonGallerySkins.Gallery.ItemClick, New GalleryItemClickEventHandler(AddressOf ItemClick)
            AddHandler ribbonGallerySkins.Gallery.InitDropDownGallery, New InplaceGalleryEventHandler(AddressOf InitDropDownGallery)
        End Sub

        Private Sub FillImages()
            Dim imageButton As SimpleButton = New SimpleButton()
            For Each cnt As SkinContainer In SkinManager.Default.Skins
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
                Dim gItem As GalleryItem = New GalleryItem()
                Dim groupIndex As Integer = 0
                If cnt.SkinName.IndexOf("Office") > -1 Then
                    groupIndex = 1
                ElseIf Not cnt.IsEmbedded Then
                    groupIndex = 2
                End If

                ribbonGallerySkins.Gallery.Groups(groupIndex).Items.Add(gItem)
                gItem.Caption = cnt.SkinName
                gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)
                gItem.Caption = cnt.SkinName
            Next
        End Sub

        Private Sub ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        End Sub

        Private Sub InitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.CreateFrom(ribbonGallerySkins.Gallery)
            e.PopupGallery.AllowFilter = False
            e.PopupGallery.ShowItemText = True
            e.PopupGallery.ShowGroupCaption = True
            e.PopupGallery.AllowHoverImages = False
            For Each galleryGroup As GalleryItemGroup In e.PopupGallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    item.Image = item.HoverImage
                Next
            Next

            e.PopupGallery.ColumnCount = 2
            e.PopupGallery.ImageSize = New Size(70, 36)
        End Sub
    End Class
End Namespace
