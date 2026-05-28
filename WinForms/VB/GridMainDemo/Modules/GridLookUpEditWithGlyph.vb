Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace DevExpress.XtraGrid.Demos

    Public Class RepositoryItemGridLookUpEditWithGlyph
        Inherits RepositoryItemGridLookUpEdit

        Shared Sub New()
            Call RegisterGridLookUpEditWithGlyph()
        End Sub

        Private ReadOnly Shared getImageByValue As Object = New Object()

        Public Custom Event GetImageByValueEvent As ImageByValueEventHandler
            AddHandler(ByVal value As ImageByValueEventHandler)
                Events.AddHandler(getImageByValue, value)
            End AddHandler

            RemoveHandler(ByVal value As ImageByValueEventHandler)
                Events.RemoveHandler(getImageByValue, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            End RaiseEvent
        End Event

        Public Function GetImage(ByVal e As ImageByValueEventArgs) As Object
            RaiseGetImageByValue(e)
            Return e.Image
        End Function

        Protected Sub RaiseGetImageByValue(ByVal e As ImageByValueEventArgs)
            Dim handler = TryCast(Events(getImageByValue), ImageByValueEventHandler)
            If handler IsNot Nothing Then handler(Me, e)
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "GridLookUpEditWithGlyph"
            End Get
        End Property

        Public Shared Sub RegisterGridLookUpEditWithGlyph()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("GridLookUpEditWithGlyph", GetType(GridLookUpEditWithGlyph), GetType(RepositoryItemGridLookUpEditWithGlyph), GetType(GridLookUpEditWithGlyphBaseViewInfo), New GridEditPainterWithGlyph(), False))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            Dim li = TryCast(item, RepositoryItemGridLookUpEditWithGlyph)
            If li IsNot Nothing Then Events.AddHandler(getImageByValue, li.Events(getImageByValue))
            MyBase.Assign(item)
        End Sub
    End Class

    Public Class GridLookUpEditWithGlyph
        Inherits GridLookUpEdit

        Private imageCore As Image

        Shared Sub New()
            Call RepositoryItemGridLookUpEditWithGlyph.RegisterGridLookUpEditWithGlyph()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "GridLookUpEditWithGlyph"
            End Get
        End Property

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso imageCore IsNot Nothing Then imageCore.Dispose()
            imageCore = Nothing
            MyBase.Dispose(disposing)
        End Sub

        <DefaultValue(CObj(Nothing))>
        Public Property Image As Image
            Get
                Return imageCore
            End Get

            Set(ByVal value As Image)
                If imageCore Is value Then Return
                imageCore = value
                LayoutChanged()
            End Set
        End Property
    End Class

    Public Class GridLookUpEditWithGlyphBaseViewInfo
        Inherits GridLookUpEditBaseViewInfo

        Private _glyph As Image

        Public Shared DefaultImageSize As Size = New Size(60, 16)

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub

        Public Overloads ReadOnly Property OwnerEdit As GridLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.OwnerEdit, GridLookUpEditWithGlyph)
            End Get
        End Property

        Public Overloads ReadOnly Property Item As RepositoryItemGridLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.Item, RepositoryItemGridLookUpEditWithGlyph)
            End Get
        End Property

        Public Overrides ReadOnly Property IsExistImage As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property ImageSize As Size
            Get
                Return If(Glyph Is Nothing, Size.Empty, DefaultImageSize)
            End Get
        End Property

        Public Overrides ReadOnly Property GlyphDrawMode As Utils.Drawing.TextGlyphDrawModeEnum
            Get
                If ImageSize.IsEmpty Then Return Utils.Drawing.TextGlyphDrawModeEnum.Text
                Return Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph
            End Get
        End Property

        Private requireUpdateImage As Boolean = False

        Protected Overrides Sub OnEditValueChanged()
            MyBase.OnEditValueChanged()
            If Bounds.IsEmpty Then
                requireUpdateImage = True
                Return
            End If

            UpdateImage()
        End Sub

        Public Overrides Sub CalcViewInfo(ByVal g As Graphics)
            If requireUpdateImage OrElse OwnerEdit IsNot Nothing AndAlso OwnerEdit.Image IsNot Nothing Then UpdateImage()
            MyBase.CalcViewInfo(g)
        End Sub

        Public Overrides Sub Reset()
            MyBase.Reset()
            _glyph = Nothing
        End Sub

        Private Sub UpdateImage()
            requireUpdateImage = False
            _glyph = GetImageCore(EditValue)
        End Sub

        Private Function GetImageCore(ByVal editValue As Object) As Image
            Dim ret As Object = Nothing
            If OwnerEdit IsNot Nothing Then ret = OwnerEdit.Image
            If ret IsNot Nothing Then Return CType(ret, Image)
            If Item IsNot Nothing AndAlso editValue IsNot nullValue AndAlso editValue IsNot Nothing Then ret = Item.GetImage(New ImageByValueEventArgs(editValue))
            If ret Is Nothing Then Return Nothing
            If TypeOf ret Is Image Then Return CType(ret, Image)
            Return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret))
        End Function

        Protected Overrides Function CalcGlyphBounds() As Rectangle
            Dim res As Rectangle = MyBase.CalcGlyphBounds()
            If Glyph IsNot Nothing AndAlso OwnerEdit IsNot Nothing AndAlso OwnerEdit.InplaceType = XtraEditors.Controls.InplaceType.Standalone Then res.Width = Glyph.Size.Width * DefaultImageSize.Height \ Glyph.Size.Height
            Return res
        End Function

        Public ReadOnly Property Glyph As Image
            Get
                Return _glyph
            End Get
        End Property
    End Class

    Public Class GridEditPainterWithGlyph
        Inherits ButtonEditPainter

        Protected Overrides Sub DrawGlyphCore(ByVal info As ControlGraphicsInfoArgs, ByVal be As ButtonEditViewInfo)
            Dim vi As GridLookUpEditWithGlyphBaseViewInfo = TryCast(be, GridLookUpEditWithGlyphBaseViewInfo)
            If vi.Glyph Is Nothing Then Return
            info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            info.Paint.DrawImage(info.Graphics, vi.Glyph, CalcImageRect(vi.Glyph.Size, vi.GlyphBounds), New Rectangle(Point.Empty, vi.Glyph.Size), vi.State <> Utils.Drawing.ObjectState.Disabled)
        End Sub

        Private Function CalcImageRect(ByVal imageSize As Size, ByVal rect As Rectangle) As Rectangle
            Dim dh As Integer = imageSize.Height * rect.Width \ imageSize.Width
            Dim dw As Integer = imageSize.Width * rect.Height \ imageSize.Height
            If dh > rect.Height Then
                rect.X +=(rect.Width - dw) \ 2
                rect.Width = dw
            End If

            If dw > rect.Width Then
                rect.Y +=(rect.Height - dh) \ 2
                rect.Height = dh
            End If

            Return rect
        End Function
    End Class
End Namespace
