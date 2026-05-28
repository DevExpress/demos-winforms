Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports DevExpress.Data.Utils
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Map
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraMap.Demos

    Public Class DemoUtils

        Const azureKeyField As String = "CDOhtwNBSsbmBiN3rUEjmBJGHW2tRMbp5XVwu4J55VBZg8PdRe9MJQQJ99BEACYeBjFllM6LAAAgAZMP1cA4"

        Const testKey As String = "TestKey"

        '
        Public Shared ReadOnly Property AzureKey As String
            Get
                Return If(DevExpress.DXperience.Demos.DemoHelper.IsTesting, DevExpress.XtraMap.Demos.DemoUtils.testKey, DevExpress.XtraMap.Demos.DemoUtils.azureKeyField)
            End Get
        End Property

        Public Shared ReadOnly Property AzureLogo As Image
            Get
                Return New System.Drawing.Bitmap(DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath("Images\AzureMapLogo.png"))
            End Get
        End Property

        Public Shared ReadOnly Property AzureCopyright As String
            Get
                Return "Copyright © " & System.DateTime.Now.Year & " Microsoft and its suppliers. All rights reserved."
            End Get
        End Property

        Public Shared ReadOnly Property OsmCopyright As String
            Get
                Return "© OpenStreetMap contributors"
            End Get
        End Property

        '
        Public Shared Function LoadXml(ByVal name As String) As XDocument
            Try
                Return DevExpress.Utils.SafeXml.CreateXDocument(System.IO.File.ReadAllText(DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath(name)))
            Catch
                Return Nothing
            End Try
        End Function

        Friend Shared Sub SetAzureMapDataProviderKey(ByVal provider As DevExpress.XtraMap.AzureMapDataProvider)
            If provider IsNot Nothing Then provider.AzureKey = DevExpress.XtraMap.Demos.DemoUtils.AzureKey
        End Sub

        Friend Shared Sub SetAzureMapDataProviderKey(ByVal provider As DevExpress.XtraMap.AzureMapDataProviderBase)
            If provider IsNot Nothing Then provider.AzureKey = DevExpress.XtraMap.Demos.DemoUtils.AzureKey
        End Sub

        Public Shared Function GetFileUri(ByVal fileName As String) As Uri
            Return New System.Uri("file:\\" & DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath(fileName), System.UriKind.RelativeOrAbsolute)
        End Function

        Public Shared Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath)
            While dir IsNot Nothing
                Dim filePath As String = System.IO.Path.Combine(dir.FullName, name)
                If System.IO.File.Exists(filePath) Then Return filePath
                dir = System.IO.Directory.GetParent(dir.FullName)
            End While

            Return String.Empty
        End Function

        Public Shared Function GetRelativeDirectoryPath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath)
            While dir IsNot Nothing
                Dim directoryPath As String = System.IO.Path.Combine(dir.FullName, name)
                If System.IO.Directory.Exists(directoryPath) Then Return directoryPath
                dir = System.IO.Directory.GetParent(dir.FullName)
            End While

            Return String.Empty
        End Function

        Public Shared Function GetBackGroundImage(ByVal map As DevExpress.XtraMap.MapControl, ByVal galleryRect As System.Drawing.Rectangle, ByVal opacity As Single) As Image
            Using stream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Try
                    map.ExportToImage(stream, DevExpress.Drawing.DXImageFormat.Png)
                    Using image As System.Drawing.Image = System.Drawing.Image.FromStream(stream)
                        Dim result As System.Drawing.Bitmap = New System.Drawing.Bitmap(galleryRect.Width, galleryRect.Height)
                        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(result)
                            Dim matrix As System.Drawing.Imaging.ColorMatrix = New System.Drawing.Imaging.ColorMatrix() With {.Matrix33 = opacity}
                            Dim attributes As System.Drawing.Imaging.ImageAttributes = New System.Drawing.Imaging.ImageAttributes()
                            attributes.SetColorMatrix(matrix, System.Drawing.Imaging.ColorMatrixFlag.[Default], System.Drawing.Imaging.ColorAdjustType.Bitmap)
                            g.DrawImage(image, New System.Drawing.Rectangle(0, 0, result.Width, result.Height), galleryRect.X, galleryRect.Y, galleryRect.Width, galleryRect.Height, System.Drawing.GraphicsUnit.Pixel, attributes)
                        End Using

                        Return result
                    End Using
                Catch
                    Return Nothing
                End Try
            End Using
        End Function

        Public Shared Function GetInflatedImage(ByVal imageUri As String, ByVal inflateX As Integer, ByVal inflateY As Integer) As Image
            Using image As System.Drawing.Image = System.Drawing.Image.FromFile(imageUri)
                Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(New System.Drawing.Point(0, 0), image.Size)
                rect.Inflate(inflateX, inflateY)
                Dim result As System.Drawing.Bitmap = New System.Drawing.Bitmap(rect.Width, rect.Height)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(result)
                    g.FillRectangle(System.Drawing.Brushes.White, New System.Drawing.Rectangle(0, 0, result.Width, result.Height))
                    g.DrawImage(image, New System.Drawing.Rectangle(inflateX, inflateY, image.Width, image.Height), 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel)
                    Return result
                End Using
            End Using
        End Function

        Public Shared Function GetOSMBaseLayers() As Object()
            Dim result As System.Collections.Generic.List(Of Object) = New System.Collections.Generic.List(Of Object) From {DevExpress.XtraMap.OpenStreetMapKind.Basic, DevExpress.XtraMap.OpenStreetMapKind.CycleMap, DevExpress.XtraMap.OpenStreetMapKind.Hot, DevExpress.XtraMap.OpenStreetMapKind.Transport}
            Return result.ToArray()
        End Function

        Public Shared Function GetOSMOverlays() As Object()
            Dim result As System.Collections.Generic.List(Of Object) = New System.Collections.Generic.List(Of Object) From {"None", DevExpress.XtraMap.OpenStreetMapKind.SeaMarks, DevExpress.XtraMap.OpenStreetMapKind.HikingRoutes, DevExpress.XtraMap.OpenStreetMapKind.CyclingRoutes, DevExpress.XtraMap.OpenStreetMapKind.PublicTransport}
            Return result.ToArray()
        End Function

        Public Shared Function CreateFlagsDictionary() As Dictionary(Of System.[String], System.Drawing.Image)
            Dim flags As System.Collections.Generic.Dictionary(Of System.[String], System.Drawing.Image) = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)()
            Dim path As String = DevExpress.XtraMap.Demos.DemoUtils.GetRelativeDirectoryPath("\Images\Flags")
            Dim fileEntries As String() = If(String.IsNullOrEmpty(path), New String(-1) {}, System.IO.Directory.GetFiles(path).Where(Function(entry) entry.EndsWith(".png")).ToArray())
            For Each fileName As String In fileEntries
                Dim key As String = fileName.Substring(CInt((fileName.LastIndexOf(CStr(("\"))) + 1))).Remove(2, 4)
                flags.Add(key, System.Drawing.Image.FromFile(fileName))
            Next

            Return flags
        End Function

        Public Shared Function GetCountryFlag(ByVal flagsCache As System.Collections.Generic.Dictionary(Of String, System.Drawing.Image), ByVal countryName As String) As Image
            Dim countryFileName As String = countryName.Replace(" "c, "_"c) & ".png"
            Dim flagPath As String = System.IO.Path.Combine(DevExpress.XtraMap.Demos.DemoUtils.GetRelativeDirectoryPath("Images\Flags\Big"), countryFileName)
            Dim flagImage As System.Drawing.Image = Nothing
            If Not flagsCache.TryGetValue(countryName, flagImage) Then
                flagImage = System.Drawing.Image.FromFile(flagPath)
                flagsCache.Add(countryName, flagImage)
            End If

            Return flagImage
        End Function

        Private Shared ReadOnly images As System.Collections.Generic.Dictionary(Of String, System.Drawing.Image) = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)()

        Public Shared Function GetAreaImage(ByVal fontSize As Integer) As Image
            Dim key As String = String.Format("Area {0}", fontSize)
            Dim image As System.Drawing.Image = Nothing
            If Not DevExpress.XtraMap.Demos.DemoUtils.images.TryGetValue(key, image) Then
                image = DevExpress.XtraMap.Demos.DemoUtils.CreateAreaImage(fontSize)
                DevExpress.XtraMap.Demos.DemoUtils.images(key) = image
            End If

            Return image
        End Function

        Public Shared Function GetPerimeterImage(ByVal fontSize As Integer) As Image
            Dim key As String = String.Format("Perimeter {0}", fontSize)
            Dim image As System.Drawing.Image = Nothing
            If Not DevExpress.XtraMap.Demos.DemoUtils.images.TryGetValue(key, image) Then
                image = DevExpress.XtraMap.Demos.DemoUtils.CreatePerimeterImage(fontSize)
                DevExpress.XtraMap.Demos.DemoUtils.images(key) = image
            End If

            Return image
        End Function

        Public Shared Function GetDiameterImage(ByVal fontSize As Integer) As Image
            Dim key As String = String.Format("Diameter {0}", fontSize)
            Dim image As System.Drawing.Image = Nothing
            If Not DevExpress.XtraMap.Demos.DemoUtils.images.TryGetValue(key, image) Then
                image = DevExpress.XtraMap.Demos.DemoUtils.CreateDiameterImage(fontSize)
                DevExpress.XtraMap.Demos.DemoUtils.images(key) = image
            End If

            Return image
        End Function

        Private Shared Function CreateDiameterImage(ByVal fontSize As Integer) As Image
            Dim perimeterImage As System.Drawing.Bitmap = New System.Drawing.Bitmap(fontSize, fontSize)
            Dim halfSize As Integer = CInt((fontSize / 2.0))
            Using gr As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(perimeterImage)
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                gr.DrawEllipse(System.Drawing.Pens.Black, New System.Drawing.Rectangle(0, fontSize \ 4, halfSize, halfSize))
                gr.DrawLine(System.Drawing.Pens.DarkGray, 0, halfSize, halfSize, halfSize)
            End Using

            Return perimeterImage
        End Function

        Private Shared Function CreatePerimeterImage(ByVal fontSize As Integer) As Image
            Dim perimeterImage As System.Drawing.Bitmap = New System.Drawing.Bitmap(fontSize, fontSize)
            Using gr As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(perimeterImage)
                gr.Clear(System.Drawing.Color.Transparent)
                gr.DrawRectangle(System.Drawing.Pens.Black, New System.Drawing.Rectangle(0, fontSize \ 4, fontSize \ 2, fontSize \ 2))
            End Using

            Return perimeterImage
        End Function

        Private Shared Function CreateAreaImage(ByVal fontSize As Integer) As Image
            Dim areaImage As System.Drawing.Bitmap = New System.Drawing.Bitmap(fontSize, fontSize)
            Using gr As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(areaImage)
                gr.Clear(System.Drawing.Color.Transparent)
                gr.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(80, 0, 0, 0)), New System.Drawing.RectangleF(0, fontSize \ 4, fontSize \ 2, fontSize \ 2))
            End Using

            Return areaImage
        End Function

        Public Shared Function DipToPixels(ByVal value As Integer) As Integer
            Return CInt((value * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
        End Function

        Public Shared Function ScaleImage(ByVal source As System.Drawing.Image, ByVal scaleHelper As DevExpress.Utils.DPI.ScaleHelper) As Image
            Dim sourceSize As System.Drawing.Size = source.Size
            Dim deviceImageSize As System.Drawing.Size = scaleHelper.ScaleSize(sourceSize)
            If sourceSize = deviceImageSize Then Return source
            Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(deviceImageSize.Width, deviceImageSize.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
            Using graphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bitmap)
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                Dim srcRect As System.Drawing.RectangleF = New System.Drawing.RectangleF(0F, 0F, source.Size.Width, source.Size.Height)
                Dim destRect As System.Drawing.RectangleF = New System.Drawing.RectangleF(0F, 0F, deviceImageSize.Width, deviceImageSize.Height)
                srcRect.Offset(-0.5F, -0.5F)
                graphics.DrawImage(source, destRect, srcRect, System.Drawing.GraphicsUnit.Pixel)
            End Using

            Return bitmap
        End Function
    End Class

    Public Class InvariantImageRepositoryItem
        Inherits DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

        Protected Overrides Function TransformPicture(ByVal image As System.Drawing.Image) As Image
            Return image
        End Function
    End Class

    Public Class HotelRoomTooltipHelper

        Private ReadOnly superToolTip As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()

        Private ReadOnly imageGenerator As DevExpress.XtraMap.Demos.HotelImagesGenerator = New DevExpress.XtraMap.Demos.HotelImagesGenerator()

        Private ReadOnly titleItem As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()

        Private ReadOnly contentItem As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem() With {.ImageToTextDistance = 0}

        Public Sub New()
            Me.superToolTip.Items.Add(Me.titleItem)
            Me.superToolTip.Items.Add(Me.contentItem)
        End Sub

        Private Function CalculateTitle(ByVal category As Integer, ByVal tooltip As String) As String
            Return If(category = 4, String.Format("Room: {0}", tooltip), tooltip)
        End Function

        Public Function CalculateSuperTooltip(ByVal item As DevExpress.XtraMap.MapItem, ByVal tooltip As String) As SuperToolTip
            If item Is Nothing Then Return Nothing
            Dim attr As DevExpress.XtraMap.MapItemAttribute = item.Attributes("CATEGORY")
            If attr Is Nothing Then Return Nothing
            Me.titleItem.Text = Me.CalculateTitle(CInt(attr.Value), tooltip)
            attr = item.Attributes("IMAGE")
            If Me.superToolTip.Items.Count = 1 Then Me.superToolTip.Items.Add(Me.contentItem)
            Dim result As System.Drawing.Image = If(attr IsNot Nothing, CType(attr.Value, System.Drawing.Image), Me.imageGenerator.GetItemImage(item))
            If result IsNot Nothing Then
                Me.contentItem.Image = result
            Else
                Me.superToolTip.Items.RemoveAt(1)
            End If

            Return Me.superToolTip
        End Function

        Public Sub UpdateHotelIndex(ByVal index As Integer)
            Me.imageGenerator.HotelIndex = index
        End Sub
    End Class

    Public Class HotelImagesGenerator

        Private Class PathsIndexPair

            Public Property Paths As String()

            Public Property Index As Integer
        End Class

        Const ImageWidth As Integer = 200

        Private Shared ReadOnly Categories As String() = New String() {"Restaurant", "MeetingRoom", "Bathroom", "Bedroom", "OutOfDoors", "ServiceRoom", "Pool", "Lobby"}

        Private hotelIndexField As Integer = 0

        Private ReadOnly filesWithIndices As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.HotelImagesGenerator.PathsIndexPair) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.HotelImagesGenerator.PathsIndexPair)()

        Public Property HotelIndex As Integer
            Get
                Return Me.hotelIndexField
            End Get

            Set(ByVal value As Integer)
                Me.hotelIndexField = value
                Me.UpdateIndices()
            End Set
        End Property

        Public Sub New()
            For Each category As String In DevExpress.XtraMap.Demos.HotelImagesGenerator.Categories
                Me.filesWithIndices.Add(New DevExpress.XtraMap.Demos.HotelImagesGenerator.PathsIndexPair() With {.Index = 0, .Paths = Me.GetAvailableFiles(category)})
            Next
        End Sub

        Private Sub UpdateIndices()
            Me.filesWithIndices(CInt((0))).Index = Me.hotelIndexField * 2
            Me.filesWithIndices(CInt((1))).Index = 0
            Me.filesWithIndices(CInt((2))).Index = Me.hotelIndexField * 4
            Me.filesWithIndices(CInt((6))).Index = Me.hotelIndexField
        End Sub

        Private Function GetAvailableFiles(ByVal category As String) As String()
            Dim path As String = DevExpress.XtraMap.Demos.DemoUtils.GetRelativeDirectoryPath("\Images\Hotels\")
            Return System.IO.Directory.GetFiles(path).Where(Function(p) p.StartsWith(path & category)).ToArray()
        End Function

        Private Function GetImage(ByVal category As Integer, ByVal roomCat As Integer) As Image
            If category = 4 Then Me.filesWithIndices(CInt((3))).Index = roomCat
            Return Me.GetCategoryImage(Me.filesWithIndices(category - 1))
        End Function

        Private Function GetCategoryImage(ByVal pathsWithIndex As DevExpress.XtraMap.Demos.HotelImagesGenerator.PathsIndexPair) As Image
            If pathsWithIndex.Paths.Length = 0 Then Return Nothing
            Dim index As Integer = pathsWithIndex.Index Mod pathsWithIndex.Paths.Length
            pathsWithIndex.Index += 1
            Return New System.Drawing.Bitmap(pathsWithIndex.Paths(index))
        End Function

        Private Function ScaleImage(ByVal srcImg As System.Drawing.Image) As Image
            Dim ratio As Double = CDbl(srcImg.Width) / srcImg.Height
            Dim newHeight As Integer = CInt((DevExpress.XtraMap.Demos.HotelImagesGenerator.ImageWidth / ratio))
            Dim resImg As System.Drawing.Image = New System.Drawing.Bitmap(DevExpress.XtraMap.Demos.HotelImagesGenerator.ImageWidth, newHeight)
            Call System.Drawing.Graphics.FromImage(CType((resImg), System.Drawing.Image)).DrawImage(srcImg, 0, 0, DevExpress.XtraMap.Demos.HotelImagesGenerator.ImageWidth, newHeight)
            Return resImg
        End Function

        Public Function GetItemImage(ByVal item As DevExpress.XtraMap.MapItem) As Image
            Dim image As System.Drawing.Image = Me.GetImage(CInt(item.Attributes(CStr(("CATEGORY"))).Value), CInt(item.Attributes(CStr(("ROOMCAT"))).Value))
            If image Is Nothing Then Return Nothing
            image = Me.ScaleImage(image)
            item.Attributes.Add(New DevExpress.XtraMap.MapItemAttribute() With {.Name = "IMAGE", .Value = image})
            Return image
        End Function
    End Class

    Public Module ColorHelper

        Public Sub UpdateColor(ByVal image As System.Drawing.Image, ByVal lookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel)
            Dim foreColor As System.Drawing.Color = DevExpress.XtraMap.Demos.ColorHelper.GetForeColor(lookAndFeel)
            Call DevExpress.XtraMap.Demos.ColorHelper.SetColor(CType(image, System.Drawing.Bitmap), foreColor)
        End Sub

        Public Function GetForeColor(ByVal lookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel) As Color
            Dim ret As System.Drawing.Color = System.Drawing.SystemColors.ControlText
            If lookAndFeel.ActiveStyle <> DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin Then Return ret
            Return DevExpress.Skins.MapSkins.GetSkin(CType((lookAndFeel), DevExpress.Skins.ISkinProvider)).Properties.GetColor(DevExpress.Skins.MapSkins.PropPanelTextColor)
        End Function

        Private Sub SetColor(ByVal bmp As System.Drawing.Bitmap, ByVal color As System.Drawing.Color)
            For i As Integer = 0 To bmp.Width - 1
                For j As Integer = 0 To bmp.Height - 1
                    If bmp.GetPixel(CInt((i)), CInt((j))).A > 0 Then bmp.SetPixel(i, j, color)
                Next
            Next
        End Sub
    End Module

    Public Class FlagsRepository

        Private ReadOnly gridImages As System.Collections.Generic.Dictionary(Of String, System.Drawing.Image) = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)()

        Private ReadOnly calloutImages As System.Collections.Generic.Dictionary(Of String, System.Drawing.Image) = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)()

        Public Sub New()
            Me.calloutImages = DevExpress.XtraMap.Demos.DemoUtils.CreateFlagsDictionary()
            Me.gridImages = DevExpress.XtraMap.Demos.DemoUtils.CreateFlagsDictionary()
        End Sub

        Public Function GetFlag(ByVal country As String, ByVal forCallout As Boolean) As Image
            Return If(forCallout, Me.calloutImages(country), Me.gridImages(country))
        End Function

        Public Function Contains(ByVal country As String) As Boolean
            Return Me.calloutImages.ContainsKey(country)
        End Function
    End Class

    Public Class PixelMapGenerator

        Const SvgFileName As String = "Countries.svg"

        Public Shared ReadOnly Projection As DevExpress.XtraMap.ProjectionBase = New DevExpress.XtraMap.EPSG4326Projection()

        Private template As DevExpress.XtraMap.MapUnit()

        Private resolution As System.Drawing.Size

        Private Function SvgMapExists() As Boolean
            Dim path As String = DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath(DevExpress.XtraMap.Demos.PixelMapGenerator.SvgFileName)
            Return System.IO.File.Exists(path)
        End Function

        Private Function CheckWritingAllowed(ByVal path As String) As Boolean
            Try
                Using New System.IO.FileStream(path, System.IO.FileMode.Create)
                    Return True
                End Using
            Catch
                Return False
            End Try
        End Function

        Private Function GenerateSvgMap() As Stream
            Using layer As DevExpress.XtraMap.VectorItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
                Using data As DevExpress.XtraMap.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
                    data.FileUri = New System.Uri("file:\\" & DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath("Countries.shp"))
                    layer.Data = data
                    layer.ItemStyle.Stroke = System.Drawing.Color.Black
                    layer.ItemStyle.Fill = layer.ItemStyle.Stroke
                    data.Load()
                    Dim filePath As String = System.IO.Path.Combine(DevExpress.XtraMap.Demos.DemoUtils.GetRelativeDirectoryPath(String.Empty), DevExpress.XtraMap.Demos.PixelMapGenerator.SvgFileName)
                    Dim isWritingAllowed As Boolean = Me.CheckWritingAllowed(filePath)
                    If isWritingAllowed Then
                        layer.ExportToSvg(filePath, New DevExpress.XtraMap.SvgExportOptions() With {.CoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem() With {.Projection = DevExpress.XtraMap.Demos.PixelMapGenerator.Projection}})
                        Return New System.IO.FileStream(filePath, System.IO.FileMode.Open)
                    End If

                    Dim stream As System.IO.Stream = New System.IO.MemoryStream()
                    layer.ExportToSvg(stream, New DevExpress.XtraMap.SvgExportOptions() With {.CoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem() With {.Projection = DevExpress.XtraMap.Demos.PixelMapGenerator.Projection}})
                    stream.Seek(0, System.IO.SeekOrigin.Begin)
                    Return stream
                End Using
            End Using
        End Function

        Private Function GenerateRasterMap(ByVal stream As System.IO.Stream) As Bitmap
            Return CType(DevExpress.Utils.Svg.SvgBitmap.FromStream(CType((stream), System.IO.Stream)).Render(Me.resolution, Nothing), System.Drawing.Bitmap)
        End Function

        Private Function CalculateOffset(ByVal row As Integer, ByVal col As Integer) As MapUnit
            Return New DevExpress.XtraMap.MapUnit(CDbl(col) / Me.resolution.Height, CDbl(row) / Me.resolution.Width)
        End Function

        Private Function CreatePath(ByVal row As Integer, ByVal col As Integer) As MapItem
            Dim offset As DevExpress.XtraMap.MapUnit = Me.CalculateOffset(row, col)
            Dim geoPoints As DevExpress.XtraMap.GeoPoint() = Me.CalculateGeoPoints(offset)
            Dim segment As DevExpress.XtraMap.MapPathSegment = New DevExpress.XtraMap.MapPathSegment()
            segment.Points.AddRange(geoPoints)
            Dim path As DevExpress.XtraMap.MapPath = New DevExpress.XtraMap.MapPath()
            path.Segments.Add(segment)
            Return path
        End Function

        Private Function CalculateGeoPoints(ByVal offset As DevExpress.XtraMap.MapUnit) As DevExpress.XtraMap.GeoPoint()
            Dim points As DevExpress.XtraMap.GeoPoint() = New DevExpress.XtraMap.GeoPoint(Me.template.Length - 1) {}
            For i As Integer = 0 To points.Length - 1
                Dim actualUnit As DevExpress.XtraMap.MapUnit = New DevExpress.XtraMap.MapUnit(offset.X + Me.template(CInt((i))).X, offset.Y + Me.template(CInt((i))).Y)
                points(i) = DevExpress.XtraMap.Demos.PixelMapGenerator.Projection.MapUnitToGeoPoint(actualUnit)
            Next

            Return points
        End Function

        Private Function GeneratePaths(ByVal image As System.Drawing.Bitmap) As List(Of DevExpress.XtraMap.MapItem)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraMap.MapItem) = New System.Collections.Generic.List(Of DevExpress.XtraMap.MapItem)()
            Dim bitmapData As System.Drawing.Imaging.BitmapData = image.LockBits(New System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size), System.Drawing.Imaging.ImageLockMode.[ReadOnly], System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Dim byteArrayLength As Integer = bitmapData.Stride * image.Height
            Dim byteArray As Byte() = New Byte(byteArrayLength - 1) {}
            Call System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, byteArray, 0, byteArrayLength)
            Dim stride As Integer = bitmapData.Stride
            For i As Integer = 3 To byteArrayLength - 1 Step 4
                If byteArray(i) <> 0 Then items.Add(Me.CreatePath(i \ stride, i \ 4 Mod image.Width))
            Next

            image.UnlockBits(bitmapData)
            Return items
        End Function

        Private Function GenerateDotTemplate(ByVal pointsPerDotCount As Integer) As DevExpress.XtraMap.MapUnit()
            Dim scaleX As Integer = Me.resolution.Width
            Dim scaleY As Integer = Me.resolution.Height
            Dim result As DevExpress.XtraMap.MapUnit() = New DevExpress.XtraMap.MapUnit(pointsPerDotCount - 1) {}
            Dim phi As Double = If(pointsPerDotCount = 3, -System.Math.PI / 2, 0)
            Dim [step] As Double = System.Math.PI * 2R / pointsPerDotCount
            For i As Integer = 0 To pointsPerDotCount - 1
                Dim x As Double = System.Math.Cos(phi) / 2 + 0.5
                Dim y As Double = System.Math.Sin(phi) / 2 + 0.5
                result(i) = New DevExpress.XtraMap.MapUnit(x / scaleX, y / scaleY)
                phi += [step]
            Next

            Return result
        End Function

        Private Function GetSvgMapStream() As Stream
            If Me.SvgMapExists() Then Return New System.IO.FileStream(DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath(DevExpress.XtraMap.Demos.PixelMapGenerator.SvgFileName), System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Return Me.GenerateSvgMap()
        End Function

        Public Function GenerateMap(ByVal resolution As System.Drawing.Size, ByVal pointsPerDotCount As Integer) As List(Of DevExpress.XtraMap.MapItem)
            Using svgMapStream As System.IO.Stream = Me.GetSvgMapStream()
                Me.resolution = resolution
                Me.template = Me.GenerateDotTemplate(pointsPerDotCount)
                Using rasterImage As System.Drawing.Bitmap = Me.GenerateRasterMap(svgMapStream)
                    Return Me.GeneratePaths(rasterImage)
                End Using
            End Using
        End Function
    End Class

    Public Class PuzzleLayoutGenerator

        Const HeightPadding As Double = 0.01

        Const WidthPadding As Double = 0.01

        Private ReadOnly items As System.Collections.Generic.IList(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect))

        Private ReadOnly availableBounds As DevExpress.XtraMap.MapRect

        Private ReadOnly projection As DevExpress.XtraMap.ProjectionBase = New DevExpress.XtraMap.SphericalMercatorProjection()

        Public Shared Function GetItemLocation(ByVal item As DevExpress.Map.ISupportCoordPoints) As GeoPoint
            Return CType(item.Points(0), DevExpress.XtraMap.GeoPoint)
        End Function

        Public Sub New(ByVal items As System.Collections.Generic.IEnumerable(Of DevExpress.XtraMap.MapItem))
            Me.items = New System.Collections.Generic.List(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect))()
            For Each item As DevExpress.XtraMap.MapPath In items
                Dim itemBoundingBox As DevExpress.XtraMap.MapRect = Me.CalculateBoundingBox(item)
                Me.items.Add(New System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect)(item, itemBoundingBox))
            Next

            Dim leftTop As DevExpress.XtraMap.MapUnit = Me.projection.GeoPointToMapUnit(New DevExpress.XtraMap.GeoPoint(15, -180))
            Dim rightBottom As DevExpress.XtraMap.MapUnit = Me.projection.GeoPointToMapUnit(New DevExpress.XtraMap.GeoPoint(-62, -90))
            Me.availableBounds = DevExpress.XtraMap.MapRect.FromLTRB(leftTop.X, leftTop.Y, rightBottom.X, rightBottom.Y)
        End Sub

        Private Function CalculateBoundingBox(ByVal item As DevExpress.Map.ISupportCoordPoints) As MapRect
            Dim maxLat As Double = Double.NegativeInfinity
            Dim minLat As Double = Double.PositiveInfinity
            Dim maxLon As Double = Double.NegativeInfinity
            Dim minLon As Double = Double.PositiveInfinity
            For Each point As DevExpress.XtraMap.GeoPoint In item.Points
                If maxLat < point.Latitude Then maxLat = point.Latitude
                If minLat > point.Latitude Then minLat = point.Latitude
                If maxLon < point.Longitude Then maxLon = point.Longitude
                If minLon > point.Longitude Then minLon = point.Longitude
            Next

            Dim corner1 As DevExpress.XtraMap.MapUnit = Me.projection.GeoPointToMapUnit(New DevExpress.XtraMap.GeoPoint(maxLat, minLon))
            Dim corner2 As DevExpress.XtraMap.MapUnit = Me.projection.GeoPointToMapUnit(New DevExpress.XtraMap.GeoPoint(minLat, maxLon))
            Return DevExpress.XtraMap.MapRect.FromLTRB(corner1.X, corner1.Y, corner2.X, corner2.Y)
        End Function

        Public Function GeneratePathInfos() As IEnumerable(Of DevExpress.XtraMap.Demos.MapPathInfo)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(System.DateTime.Now.Millisecond)
            Dim unusedItems As System.Collections.Generic.List(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect)) = New System.Collections.Generic.List(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect))(Me.items)
            Dim result As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.MapPathInfo) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.MapPathInfo)()
            Dim availableHeight As Double = Me.availableBounds.Height
            Dim y As Double = Me.availableBounds.Top
            Dim x As Double = Me.availableBounds.Left
            Dim maxWidth As Double = 0
            While unusedItems.Count > 0
                Dim availableItems As System.Collections.Generic.List(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect)) = New System.Collections.Generic.List(Of System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect))()
                For Each item As System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect) In unusedItems
                    If item.Item2.Height < availableHeight Then availableItems.Add(item)
                Next

                If availableItems.Count > 0 Then
                    Dim index As Integer = rnd.[Next](availableItems.Count)
                    Dim pair As System.Tuple(Of DevExpress.XtraMap.MapPath, DevExpress.XtraMap.MapRect) = availableItems(index)
                    Dim gameCenter As DevExpress.XtraMap.MapUnit = New DevExpress.XtraMap.MapUnit(x + pair.Item2.Width / 2, y + pair.Item2.Height / 2)
                    result.Add(New DevExpress.XtraMap.Demos.MapPathInfo(pair.Item1, DevExpress.XtraMap.Demos.PuzzleLayoutGenerator.GetItemLocation(pair.Item1), Me.projection.MapUnitToGeoPoint(gameCenter)))
                    unusedItems.Remove(pair)
                    availableHeight -=(pair.Item2.Height + DevExpress.XtraMap.Demos.PuzzleLayoutGenerator.HeightPadding)
                    y += pair.Item2.Height + DevExpress.XtraMap.Demos.PuzzleLayoutGenerator.HeightPadding
                    If pair.Item2.Width > maxWidth Then maxWidth = pair.Item2.Width
                Else
                    availableHeight = Me.availableBounds.Height
                    x += maxWidth + DevExpress.XtraMap.Demos.PuzzleLayoutGenerator.WidthPadding
                    y = Me.availableBounds.Top
                    maxWidth = 0
                End If
            End While

            Return result
        End Function
    End Class

    Public MustInherit Class FractalGeneratorBase

        Protected MustOverride Function GenerateCore(ByVal start As DevExpress.XtraMap.CartesianPoint, ByVal finish As DevExpress.XtraMap.CartesianPoint) As List(Of DevExpress.XtraMap.CartesianPoint)

        Public Function Generate(ByVal start As DevExpress.XtraMap.CartesianPoint, ByVal finish As DevExpress.XtraMap.CartesianPoint, ByVal depth As Integer) As List(Of DevExpress.XtraMap.CartesianPoint)
            Dim previousResult As System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint)() From {start, finish}
            Dim i As Integer = 0
            While i < depth
                Dim result As System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint)()
                result.Add(start)
                Dim j As Integer = 0
                While j < previousResult.Count - 1
                    Dim points As System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint) = Me.GenerateCore(previousResult(j), previousResult(j + 1))
                    points.RemoveAt(0)
                    result.AddRange(points)
                    Call System.Threading.Interlocked.Increment(j)
                End While

                previousResult = result
                Call System.Threading.Interlocked.Increment(i)
            End While

            Return previousResult
        End Function
    End Class

    Public Class MinkowskiLine
        Inherits DevExpress.XtraMap.Demos.FractalGeneratorBase

        Protected Overrides Function GenerateCore(ByVal start As DevExpress.XtraMap.CartesianPoint, ByVal finish As DevExpress.XtraMap.CartesianPoint) As List(Of DevExpress.XtraMap.CartesianPoint)
            Dim result As System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint)()
            Dim dx As Double =(finish.X - start.X) / 4
            Dim dy As Double =(finish.Y - start.Y) / 4
            result.Add(start)
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dx, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dy))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X - dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dx))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dx, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dy))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y - dx))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y - dx))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dx, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dy))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X - dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dx))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dx, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dy))
            Return result
        End Function
    End Class

    Public Class KochLine
        Inherits DevExpress.XtraMap.Demos.FractalGeneratorBase

        Protected Overrides Function GenerateCore(ByVal start As DevExpress.XtraMap.CartesianPoint, ByVal finish As DevExpress.XtraMap.CartesianPoint) As List(Of DevExpress.XtraMap.CartesianPoint)
            Dim result As System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.CartesianPoint)()
            Dim dx As Double =(finish.X - start.X) / 3
            Dim dy As Double =(finish.Y - start.Y) / 3
            result.Add(start)
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + dx, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + dy))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + System.Math.Cos(System.Math.PI / 3) * dx - System.Math.Sin(System.Math.PI / 3) * dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + System.Math.Sin(System.Math.PI / 3) * dx + System.Math.Cos(System.Math.PI / 3) * dy))
            result.Add(New DevExpress.XtraMap.CartesianPoint(System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).X + System.Math.Cos(-System.Math.PI / 3) * dx - System.Math.Sin(-System.Math.PI / 3) * dy, System.Linq.Enumerable.Last(Of DevExpress.XtraMap.CartesianPoint)(result).Y + System.Math.Sin(-System.Math.PI / 3) * dx + System.Math.Cos(-System.Math.PI / 3) * dy))
            result.Add(finish)
            Return result
        End Function
    End Class

    Public Module TrackInfoHelper

        Private ReadOnly templateBegin As String = "
        <table class=""table"">
	        <tr>
		        <th><img src=""Duration"" class=""image""></th>
		        <th class=""text"">Duration<br>${Duration}</th>
	        </tr>
	        <tr>
		        <th><img src=""Distance"" class=""image""></th>
		        <th class=""text"">Distance<br>${Distance}</th>
            </tr>"

        Private ReadOnly templateHeartRate As String = "
            <tr>
                <th><img src=""HeartRate"" class= ""image""></th>
                <th class= ""text"">Average Heart Rate<br>${AverageHeartRate}<br>$(Max {MaxHeartRate} | Min {MinHeartRate})</th>
            </tr>"

        Private ReadOnly templateEnd As String = "
            <tr>
                <th><img src=""Pace"" class= ""image""></th>
                <th class=""text"">$Average Pace {AveragePace}/km<br>$(Max {MaxPace})</th >
            </tr>
        </table>"

        Private Sub CalculateHeartRate(ByVal data As System.Data.DataView, ByVal info As DevExpress.XtraMap.Demos.GpxTrackInfo)
            Dim heartRate As String = "gpxtpx:hr"
            If Not data.Table.Columns.Contains(heartRate) Then Return
            Dim minHeartRate As Integer = System.Convert.ToInt32(data(0)(heartRate)), maxHeartRate As Integer = minHeartRate, heartRateSum As Integer = 0
            For Each row As System.Data.DataRowView In data
                minHeartRate = System.Math.Min(minHeartRate, System.Convert.ToInt32(row(heartRate)))
                maxHeartRate = System.Math.Max(maxHeartRate, System.Convert.ToInt32(row(heartRate)))
                heartRateSum += System.Convert.ToInt32(row(heartRate))
            Next

            info.MinHeartRate = minHeartRate
            info.MaxHeartRate = maxHeartRate
            info.AverageHeartRate = heartRateSum \ data.Count
        End Sub

        Private Sub CalculatePace(ByVal data As System.Data.DataView, ByVal info As DevExpress.XtraMap.Demos.GpxTrackInfo)
            If Not data.Table.Columns.Contains("Pace") Then data.Table.Columns.Add("Pace")
            Dim distance As String = "gpxdata:distance", time As String = "time"
            Dim window As Integer = 10
            Dim minTicks As Long = Long.MaxValue
            For i As Integer = 1 To window - 1
                Dim d As Double = CDbl(data(i)(distance)) - CDbl(data(i - 1)(distance))
                Dim pace As System.TimeSpan = System.TimeSpan.FromMilliseconds(0)
                If d > Double.Epsilon Then
                    Dim dTime As System.TimeSpan = CDate(data(i)(time)) - CDate(data(i - 1)(time))
                    pace = System.TimeSpan.FromMinutes(dTime.TotalMinutes / (d * 0.001))
                    minTicks = System.Math.Min(minTicks, pace.Ticks)
                End If

                data(i)("Pace") = pace
            Next

            For j As Integer = window To data.Count - 1
                Dim d As Double = CDbl(data(j)(distance)) - CDbl(data(j - window)(distance))
                If d < Double.Epsilon Then Continue For
                Dim dTime As System.TimeSpan = CDate(data(j)(time)) - CDate(data(j - window)(time))
                Dim pace As System.TimeSpan = System.TimeSpan.FromMinutes(dTime.TotalMinutes / (d * 0.001))
                minTicks = System.Math.Min(minTicks, pace.Ticks)
                data(j)("Pace") = pace
            Next

            info.AveragePace = System.TimeSpan.FromMinutes(CDbl((info.Duration.TotalMinutes / info.Distance))).ToString("mm\:ss")
            info.MaxPace = System.TimeSpan.FromTicks(CLng((minTicks))).ToString("mm\:ss")
        End Sub

        Public Function CalculateTrackInfo(ByVal source As System.ComponentModel.IListSource) As GpxTrackInfo
            Dim info As DevExpress.XtraMap.Demos.GpxTrackInfo = New DevExpress.XtraMap.Demos.GpxTrackInfo()
            Dim data As System.Data.DataView = TryCast(source.GetList(), System.Data.DataView)
            If data Is Nothing Then Return info
            Dim durationSeconds As Double =(CDate(data(CInt((data.Count - 1)))(CStr(("time")))) - CDate(data(CInt((0)))(CStr(("time"))))).TotalSeconds
            info.Duration = System.TimeSpan.FromSeconds(CLng(durationSeconds))
            info.Distance = System.Math.Round((CDbl(data(data.Count - 1)("gpxdata:distance")) - CDbl(data(0)("gpxdata:distance"))) * 0.001, 3)
            Call DevExpress.XtraMap.Demos.TrackInfoHelper.CalculatePace(data, info)
            Call DevExpress.XtraMap.Demos.TrackInfoHelper.CalculateHeartRate(data, info)
            Return info
        End Function

        Public Function GenerateTrackTemplate(ByVal isTrackHasHeartRate As Boolean) As String
            Return DevExpress.XtraMap.Demos.TrackInfoHelper.templateBegin & (If(isTrackHasHeartRate, DevExpress.XtraMap.Demos.TrackInfoHelper.templateHeartRate, String.Empty)) & DevExpress.XtraMap.Demos.TrackInfoHelper.templateEnd
        End Function
    End Module

    Public Module MapArrowsDemoHelper

        Public Function LoadItems() As List(Of DevExpress.XtraMap.Demos.WindDataItem)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WindDataItem) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WindDataItem)()
            Try
                Using reader As System.IO.StreamReader = New System.IO.StreamReader(DevExpress.XtraMap.Demos.DemoUtils.GetRelativePath("windData.csv"))
                    While Not reader.EndOfStream
                        Dim values As String() = reader.ReadLine().Split(" "c)
                        items.Add(New DevExpress.XtraMap.Demos.WindDataItem(Double.Parse(values(1), System.Globalization.CultureInfo.InvariantCulture), Double.Parse(values(2), System.Globalization.CultureInfo.InvariantCulture), Double.Parse(values(3), System.Globalization.CultureInfo.InvariantCulture), Double.Parse(values(4), System.Globalization.CultureInfo.InvariantCulture)))
                    End While
                End Using
            Catch
                Throw New System.Exception("It's impossible to load wind data")
            End Try

            Return items
        End Function
    End Module

    '
    Public Class WindDataItem

        '
        Private _Latitude1 As Double, _Longitude1 As Double, _Latitude2 As Double, _Longitude2 As Double, _Speed As Double

        Const ArrowLength As Double = 70000

        Public Property Latitude1 As Double
            Get
                Return _Latitude1
            End Get

            Private Set(ByVal value As Double)
                _Latitude1 = value
            End Set
        End Property

        Public Property Longitude1 As Double
            Get
                Return _Longitude1
            End Get

            Private Set(ByVal value As Double)
                _Longitude1 = value
            End Set
        End Property

        Public Property Latitude2 As Double
            Get
                Return _Latitude2
            End Get

            Private Set(ByVal value As Double)
                _Latitude2 = value
            End Set
        End Property

        Public Property Longitude2 As Double
            Get
                Return _Longitude2
            End Get

            Private Set(ByVal value As Double)
                _Longitude2 = value
            End Set
        End Property

        Public Property Speed As Double
            Get
                Return _Speed
            End Get

            Private Set(ByVal value As Double)
                _Speed = value
            End Set
        End Property

        '
        Public Sub New(ByVal latitude As Double, ByVal longitude As Double, ByVal direction As Double, ByVal speed As Double)
            Dim destination As DevExpress.XtraMap.GeoPoint = DevExpress.XtraMap.GeoUtils.CalculateDestinationPoint(New DevExpress.XtraMap.GeoPoint(latitude, longitude), DevExpress.XtraMap.Demos.WindDataItem.ArrowLength, direction)
            Me.Latitude1 = latitude
            Me.Longitude1 = longitude
            Me.Latitude2 = destination.Latitude
            Me.Longitude2 = destination.Longitude
            Me.Speed = speed
        End Sub
    End Class
End Namespace
