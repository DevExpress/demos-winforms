Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos

    Public Class RepositoryItemSearchLookUpEditWithGlyph
        Inherits RepositoryItemSearchLookUpEdit

        Shared Sub New()
            Call RegisterSearchLookUpEditWithGlyph()
        End Sub

        Private ReadOnly Shared getImageByValueCore As Object = New Object()

        Public Custom Event GetImageByValue As ImageByValueEventHandler
            AddHandler(ByVal value As ImageByValueEventHandler)
                Events.AddHandler(getImageByValueCore, value)
            End AddHandler

            RemoveHandler(ByVal value As ImageByValueEventHandler)
                Events.RemoveHandler(getImageByValueCore, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            End RaiseEvent
        End Event

        Public Function GetImage(ByVal e As ImageByValueEventArgs) As Object
            RaiseGetImageByValue(e)
            Return e.Image
        End Function

        Protected Sub RaiseGetImageByValue(ByVal e As ImageByValueEventArgs)
            Dim handler = TryCast(Events(getImageByValueCore), ImageByValueEventHandler)
            If handler IsNot Nothing Then handler(Me, e)
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "SearchLookUpEditWithGlyph"
            End Get
        End Property

        Public Shared Sub RegisterSearchLookUpEditWithGlyph()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("SearchLookUpEditWithGlyph", GetType(SearchLookUpEditWithGlyph), GetType(RepositoryItemSearchLookUpEditWithGlyph), GetType(SearchLookUpEditWithGlyphBaseViewInfo), New SearchEditPainterWithGlyph(), False))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            Dim li = TryCast(item, RepositoryItemSearchLookUpEditWithGlyph)
            If li IsNot Nothing Then Events.AddHandler(getImageByValueCore, li.Events(getImageByValueCore))
            MyBase.Assign(item)
        End Sub

        Protected Overrides Sub ClearClick()
            MyBase.ClearClick()
            Dim edit As SearchLookUpEditWithGlyph = TryCast(OwnerEdit, SearchLookUpEditWithGlyph)
            If edit IsNot Nothing Then
                edit.Image = Nothing
                edit.DoValidate()
            End If
        End Sub
    End Class

    Public Class SearchEditPainterWithGlyph
        Inherits ButtonEditPainter

        Protected Overrides Sub DrawGlyphCore(ByVal info As ControlGraphicsInfoArgs, ByVal be As ButtonEditViewInfo)
            Dim vi As SearchLookUpEditWithGlyphBaseViewInfo = TryCast(be, SearchLookUpEditWithGlyphBaseViewInfo)
            If vi.Image Is Nothing Then Return
            If vi.Image.Size.Width > vi.GetScaleDefaultSize().Width * 2 Then info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            info.Paint.DrawImage(info.Graphics, vi.Image, vi.GlyphBounds, New Rectangle(Point.Empty, vi.Image.Size), vi.State <> Utils.Drawing.ObjectState.Disabled)
        End Sub
    End Class

    Public Class SearchLookUpEditWithGlyphBaseViewInfo
        Inherits SearchLookUpEditBaseViewInfo

        Private imageCore As Image

        Public Shared DefaultImageSize As Size = New Size(17, 17)

        Friend Function GetScaleDefaultSize() As Size
            Return GetScaleDpi().ScaleSize(DefaultImageSize)
        End Function

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub

        Public Overloads ReadOnly Property OwnerEdit As SearchLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.OwnerEdit, SearchLookUpEditWithGlyph)
            End Get
        End Property

        Public Overloads ReadOnly Property Item As RepositoryItemSearchLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.Item, RepositoryItemSearchLookUpEditWithGlyph)
            End Get
        End Property

        Public Overrides ReadOnly Property IsExistImage As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property ImageSize As Size
            Get
                Return If(Image Is Nothing, Size.Empty, GetScaleDefaultSize())
            End Get
        End Property

        Public Overrides ReadOnly Property GlyphDrawMode As Utils.Drawing.TextGlyphDrawModeEnum
            Get
                If ImageSize.IsEmpty Then Return Utils.Drawing.TextGlyphDrawModeEnum.Text
                Return Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph
            End Get
        End Property

        Protected Overrides Function CalcGlyphBounds() As Rectangle
            Dim ret As Rectangle = MyBase.CalcGlyphBounds()
            ret.X += GetScaleDpi().ScaleHorizontal(3) 'horizontal image indent
            Return ret
        End Function

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
            imageCore = Nothing
        End Sub

        Private Sub UpdateImage()
            requireUpdateImage = False
            imageCore = GetImageCore(EditValue)
        End Sub

        Private Function GetImageCore(ByVal editValue As Object) As Image
            Dim ret As Object = Nothing
            If OwnerEdit IsNot Nothing Then ret = OwnerEdit.Image
            If ret IsNot Nothing Then Return CType(ret, Image)
            If Item IsNot Nothing AndAlso editValue IsNot nullValue Then ret = Item.GetImage(New ImageByValueEventArgs(editValue))
            If ret Is Nothing Then Return Nothing
            If TypeOf ret Is Image Then Return CType(ret, Image)
            Return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret))
        End Function

        Public ReadOnly Property Image As Image
            Get
                Return imageCore
            End Get
        End Property
    End Class

    Public Class SearchLookUpEditWithGlyph
        Inherits SearchLookUpEdit

        Private imageCore As Image

        Shared Sub New()
            Call RepositoryItemSearchLookUpEditWithGlyph.RegisterSearchLookUpEditWithGlyph()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "SearchLookUpEditWithGlyph"
            End Get
        End Property

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso imageCore IsNot Nothing Then imageCore.Dispose()
            imageCore = Nothing
            MyBase.Dispose(disposing)
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property Image As Image
            Get
                Return imageCore
            End Get

            Set(ByVal value As Image)
                imageCore = value
                LayoutChanged()
            End Set
        End Property
    End Class

    Public Delegate Sub ImageByValueEventHandler(ByVal sender As Object, ByVal e As ImageByValueEventArgs)

    Public Class ImageByValueEventArgs
        Inherits EventArgs

        Private valueCore As Object

        Private imageCore As Object

        Public Sub New(ByVal value As Object)
            valueCore = value
        End Sub

        Public ReadOnly Property Value As Object
            Get
                Return valueCore
            End Get
        End Property

        Public Property Image As Object
            Get
                Return imageCore
            End Get

            Set(ByVal value As Object)
                imageCore = value
            End Set
        End Property
    End Class
End Namespace
