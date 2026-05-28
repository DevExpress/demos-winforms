Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class AccordionControlMultimediaModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            WorkingFolder = DataPath
            If Not String.IsNullOrEmpty(WorkingFolder) Then
                InitializeContent()
                SetImage(Images(0))
            End If
        End Sub

        Protected Overridable Sub InitializeContent()
            InitializeTileControl()
            UpdateEditors()
            AddHandler galleryFilters.SizeChanged, AddressOf OnGalleryFiltersSizeChanged
        End Sub

        Protected Overridable Sub InitializeTileControl()
            TryCast(tileControl1, ITileControl).ViewInfo.UseAdvancedTextRendering = False
            If TileGroupImages Is Nothing Then Return
            TileControl.Groups.Clear()
            TileControl.Groups.Add(TileGroupImages)
        End Sub

        Protected Overridable Sub InitializeImages()
            If String.IsNullOrEmpty(WorkingFolder) Then Return
            Images = New List(Of Image)()
            Dim files As String() = Directory.GetFiles(WorkingFolder, "*.jpg")
            For Each file As String In files
                Dim img As Image = Bitmap.FromFile(file)
                img.Tag = file
                Images.Add(img)
            Next

            InitializeTileControl()
        End Sub

        Protected Overridable Property Images As List(Of Image)

        Protected Overridable ReadOnly Property TileControl As TileControl
            Get
                Return tileControl1
            End Get
        End Property

        Protected Overridable ReadOnly Property PictureEdit As PictureEdit
            Get
                Return peCurrentImage
            End Get
        End Property

        Protected Overridable ReadOnly Property FilterGroup As GalleryItemGroup
            Get
                Return galleryFilters.Gallery.Groups(0)
            End Get
        End Property

        Protected Overridable ReadOnly Property PreviewSize As Size
            Get
                Return galleryFilters.Gallery.ImageSize
            End Get
        End Property

        Private originalImageCore As Image

        Protected Overridable Property OriginalImage As Image
            Get
                Return originalImageCore
            End Get

            Set(ByVal value As Image)
                originalImageCore = value
                peOriginalImage.Image = originalImageCore
                UpdateImageProperties()
            End Set
        End Property

        Private currentImageCore As Image

        Protected Overridable Property CurrentImage As Image
            Get
                Return currentImageCore
            End Get

            Set(ByVal value As Image)
                currentImageCore = value
                If CurrentImage Is Nothing Then Return
                PictureEdit.Image = CurrentImage
                CalcCurrentImageZoomPercent(currentImageCore)
                UpdateEditors()
            End Set
        End Property

        Protected Overridable Sub CalcCurrentImageZoomPercent(ByVal img As Image)
            PictureEdit.Properties.ZoomPercent = Math.Min((CDbl(PictureEdit.Height) / CDbl(img.Height)) * 100, 100)
        End Sub

        Private workingFolderCore As String

        Protected Overridable Property WorkingFolder As String
            Get
                Return workingFolderCore
            End Get

            Set(ByVal value As String)
                If Equals(workingFolderCore, value) Then Return
                workingFolderCore = value
                InitializeImages()
            End Set
        End Property

        Private group As TileGroup

        Protected Overridable ReadOnly Property TileGroupImages As TileGroup
            Get
                If group Is Nothing Then group = CreateTileGroupImages()
                Return group
            End Get
        End Property

        Protected Overridable Sub SetImage(ByVal img As Image)
            OriginalImage = img
            CurrentImage = OriginalImage
            RefreshFilters(OriginalImage)
        End Sub

        Protected ReadOnly Property DataPath As String
            Get
                Dim dataDir As String = Tutorials.FilePathUtils.FindDirPath("Data")
                Dim dataPathCore As String = Path.Combine(dataDir, "AccordionControlData")
                If Directory.Exists(dataPathCore) Then Return dataPathCore
                Return String.Empty
            End Get
        End Property

        Protected Overridable Sub UpdateEditors()
            Dim value As Boolean = CurrentImage IsNot Nothing
            tbRed.Enabled = value
            tbGreen.Enabled = value
            tbBlue.Enabled = value
            tbBrightness.Enabled = value
            tbContrast.Enabled = value
            tbRed.Value = tbRed.Properties.Minimum
            tbGreen.Value = tbGreen.Properties.Minimum
            tbBlue.Value = tbBlue.Properties.Minimum
            tbBrightness.Value = tbBrightness.Properties.Minimum
            tbContrast.Value = tbContrast.Properties.Minimum
        End Sub

        Protected Overridable Function CreateTileGroupImages() As TileGroup
            If Images Is Nothing OrElse Images.Count = 0 Then Return Nothing
            Dim g As TileGroup = New TileGroup()
            For Each img As Image In Images
                Dim item As TileItem = New TileItem() With {.BackgroundImage = img, .BackgroundImageScaleMode = TileItemImageScaleMode.Squeeze, .BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter}
                g.Items.Add(item)
            Next

            Return g
        End Function

        Protected Overridable Sub RefreshFilters(ByVal img As Image)
            FilterGroup.Items.Clear()
            For Each filter As FilterBase In FilterList
                FilterGroup.Items.Add(CreateGalleryItemFilter(img, filter))
            Next
        End Sub

        Private updatingAccordionWidth As Boolean

        Protected Overridable Sub OnGalleryFiltersSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateAccordionPanelWidth()
        End Sub

        Protected Overridable Sub UpdateAccordionPanelWidth()
            If updatingAccordionWidth Then Return
            If FilterGroup.Items.Count = 0 Then Return
            updatingAccordionWidth = True
            Try
                Dim bestSize As Size = galleryFilters.GetPreferredSize(Size.Empty)
                Dim delta As Integer = bestSize.Width - galleryFilters.Width
                If delta = 0 Then Return
                panelControl7.Width += delta
            Finally
                updatingAccordionWidth = False
            End Try
        End Sub

        Protected Overridable Sub UpdateImageProperties()
            ratingImage.Rating = GetRating(OriginalImage)
            lblSize.Text = GetSize(OriginalImage)
            lblName.Text = GetName(OriginalImage)
            lblDimension.Text = GetDimension(OriginalImage)
        End Sub

        Protected Overridable Function CreateGalleryItemFilter(ByVal img As Image, ByVal filter As FilterBase) As GalleryItem
            Dim item As GalleryItem = New GalleryItem() With {.Image = filter.ApplyFilter(img, PreviewSize), .Caption = filter.Name}
            AddHandler item.ItemClick, Sub() PictureEdit.Image = filter.ApplyFilter(img, img.Size)
            Return item
        End Function

        Protected Overridable Sub OnPictureEditCurrentImageSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentImage Is Nothing Then Return
            CalcCurrentImageZoomPercent(CurrentImage)
        End Sub

        Protected Overridable Sub OnTbRedEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnChangeColor()
        End Sub

        Protected Overridable Sub OnTbGreenEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnChangeColor()
        End Sub

        Protected Overridable Sub OnTbBlueEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnChangeColor()
        End Sub

        Protected Overridable Sub OnChangeColor()
            If CurrentImage Is Nothing Then Return
            PictureEdit.Image = UniversalFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, tbRed.Value, tbGreen.Value, tbBlue.Value)
        End Sub

        Protected Sub OnBrightnessChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs)
            Dim val As Integer = tbBrightness.Value
            PictureEdit.Image = UniversalFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, val, val, val)
        End Sub

        Protected Overridable Sub OnContrastChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentImage Is Nothing Then Return
            Dim val As Integer = tbContrast.Value
            PictureEdit.Image = ContrastFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, val)
        End Sub

        Protected Overridable Sub OnTileControlItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            SetImage(e.Item.BackgroundImage)
        End Sub

#Region "Filters"
        Private filterListCore As List(Of FilterBase)

        Protected Overridable ReadOnly Property FilterList As List(Of FilterBase)
            Get
                If filterListCore Is Nothing Then
                    filterListCore = New List(Of FilterBase)() From {New PolaroidFilter(), New BGRFilter(), New GBRFilter(), New SepiaFilter(), New GrayScaleFilter(), New NegativeFilter()}
                End If

                Return filterListCore
            End Get
        End Property

        Private universalFilter As UniversalFilter

        Protected Overridable ReadOnly Property UniversalFilterInstance As UniversalFilter
            Get
                If universalFilter Is Nothing Then universalFilter = New UniversalFilter()
                Return universalFilter
            End Get
        End Property

        Private contrastFilter As ContrastFilter

        Protected Overridable ReadOnly Property ContrastFilterInstance As ContrastFilter
            Get
                If contrastFilter Is Nothing Then contrastFilter = New ContrastFilter()
                Return contrastFilter
            End Get
        End Property
#End Region
    End Class

    '
    Public Module ImageHelper

        Public Function GetDimension(ByVal img As Image) As String
            If img Is Nothing Then Return "0x0"
            Return String.Format("{0}x{1}", img.Width, img.Height)
        End Function

        Public Function GetName(ByVal img As Image) As String
            If img Is Nothing Then Return String.Empty
            Return Path.GetFileName(img.Tag.ToString())
        End Function

        Public Function GetSize(ByVal img As Image) As String
            If img Is Nothing Then Return "0 KB"
            Return(New FileInfo(img.Tag.ToString()).Length / 1024).ToString() & " KB"
        End Function

        Public Function GetRating(ByVal img As Image) As Integer
            If img Is Nothing Then Return 0
            Return TutorialConstants.Random.Next(5)
        End Function

        Private ReadOnly images As Dictionary(Of String, Bitmap) = New Dictionary(Of String, Bitmap)()

        Public Function CreateSenderImage(ByVal sender As String, ByVal size As Size, ByVal ulf As LookAndFeel.UserLookAndFeel) As Bitmap
            Dim img As Bitmap = Nothing
            If images.TryGetValue(sender, img) Then Return img
            Dim imageSize As Size = New Size(size.Width, size.Height)
            Dim parsedText As String() = sender.Split(" "c)
            Dim result As String = String.Empty
            Dim count As Integer = 0
            For i As Integer = 0 To parsedText.Length - 1
                If parsedText(i).Length > 0 Then
                    result += parsedText(i)(0)
                    count += 1
                    If count = 2 Then Exit For
                End If
            Next

            img = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result)
            images.Add(sender, img)
            Return img
        End Function
    End Module

    Public Delegate Sub GalleryItemApplyFilter(ByVal name As String, ByVal image As Image, ByVal filter As FilterBase)

    Public Class FilterBase

        Public Overridable ReadOnly Property Name As String
            Get
                Return String.Empty
            End Get
        End Property

        Public Function ApplyFilter(ByVal image As Image, ByVal size As Size) As Image
            Return ApplyMatrix(image, size, Matrix)
        End Function

        Protected Overridable ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix()
            End Get
        End Property

        Protected Function ApplyMatrix(ByVal image As Image, ByVal size As Size, ByVal matrix As ColorMatrix) As Bitmap
            Dim src As Bitmap = New Bitmap(image, size)
            Dim dest As Bitmap = New Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb)
            Using graphics As Graphics = Graphics.FromImage(dest)
                Dim bmpAttributes As ImageAttributes = New ImageAttributes()
                bmpAttributes.SetColorMatrix(matrix)
                graphics.DrawImage(src, New Rectangle(0, 0, src.Width, src.Height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, bmpAttributes)
            End Using

            src.Dispose()
            Return dest
        End Function
    End Class

    Public Class PolaroidFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Polaroid"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {1.438F, -0.062F, -0.062F, 0, 0}, New Single() {-0.122F, 1.378F, -0.122F, 0, 0}, New Single() {0.016F, -0.016F, 1.438F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.03F, 0.05F, -0.2F, 0, 1}})
            End Get
        End Property
    End Class

    Public Class GrayScaleFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "GrayScale"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {.3F, .3F, .3F, 0, 0}, New Single() {.59F, .59F, .59F, 0, 0}, New Single() {.11F, .11F, .11F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
            End Get
        End Property
    End Class

    Public Class NegativeFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Negative"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {-1, 0, 0, 0, 0}, New Single() {0, -1, 0, 0, 0}, New Single() {0, 0, -1, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {1, 1, 1, 0, 1}})
            End Get
        End Property
    End Class

    Public Class SepiaFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Sepia"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {.393F, .349F, .272F, 0, 0}, New Single() {.769F, .686F, .534F, 0, 0}, New Single() {.189F, .168F, .131F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
            End Get
        End Property
    End Class

    Public Class BGRFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "BGR"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {0, 0, 1, 0, 0}, New Single() {0, 1, 0, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
            End Get
        End Property
    End Class

    Public Class GBRFilter
        Inherits FilterBase

        Public Overrides ReadOnly Property Name As String
            Get
                Return "GBR"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {0, 1, 0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
            End Get
        End Property
    End Class

    Public Class UniversalFilter
        Inherits FilterBase

        Public Sub New()
            b = 0
            g = b
            r = g
        End Sub

        Private r, g, b As Integer

        Public Overloads Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Image
            Me.r = r
            Me.g = g
            Me.b = b
            Return ApplyMatrix(image, size, Matrix)
        End Function

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Universal"
            End Get
        End Property

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {1 + CSng(r / 255.0F), 0, 0, 0, 0}, New Single() {0, 1 + CSng(g / 255.0F), 0, 0, 0}, New Single() {0, 0, 1 + CSng(b / 255.0F), 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.1F, 0.1F, 0.1F, 0, 1}})
            End Get
        End Property
    End Class

    Public Class ContrastFilter
        Inherits FilterBase

        Public Sub New()
            translate = 0
            scale = translate
        End Sub

        Private scale As Single

        Private translate As Single

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Contrast"
            End Get
        End Property

        Public Overloads Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal val As Integer) As Image
            scale = val
            translate =(-.5F * scale + .5F) * 255.0F
            Return ApplyMatrix(image, size, Matrix)
        End Function

        Protected Overrides ReadOnly Property Matrix As ColorMatrix
            Get
                Return New ColorMatrix(New Single()() {New Single() {1 + scale / 100, 0, 0, 0, translate}, New Single() {0, 1 + scale / 100, 0, 0, translate}, New Single() {0, 0, 1 + scale / 100, 0, translate}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
            End Get
        End Property
    End Class
End Namespace
