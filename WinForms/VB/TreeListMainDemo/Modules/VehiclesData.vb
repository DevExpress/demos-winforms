Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Threading.Tasks
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTreeList.Columns
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraTreeList.Demos

    Public Class VehiclesData

        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")>
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum

        Public Enum BodyStyle
            Convertible = 1
            Coupe = 2
            Hatchback = 3
            <Display(Name:="Passenger Van")>
            PassengerVan = 4
            Pickup = 5
            Sedan = 6
            <Display(Name:="Sport Utility Vehicle")>
            SportUtilityVehicle = 7
            Wagon = 8
        End Enum

        Public Class Trademark

            Private captionLogoCore As Bitmap = Nothing

            Public Property ID As Integer

            Public Property Logo As Image

            Public Property Name As String

            Public ReadOnly Property CaptionLogo As Bitmap
                Get
                    If captionLogoCore Is Nothing Then captionLogoCore = ResizeImage(Logo, 24, 70)
                    Return captionLogoCore
                End Get
            End Property
        End Class

        Public Shared Function ResizeImage(ByVal image As Image, ByVal height As Integer, ByVal maxWidth As Integer) As Bitmap
            Dim width As Integer = Math.Min(image.Width * height \ image.Height, maxWidth)
            Dim heightImage As Integer = image.Height * width \ image.Width
            Dim destRect As Rectangle = New Rectangle(0, (height - heightImage) \ 2, width, heightImage)
            Dim destImage As Bitmap = New Bitmap(width, height)
            Using graphics As Graphics = Graphics.FromImage(destImage)
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel)
            End Using

            Return destImage
        End Function

        Public Class TrademarkItem

            Friend Model As Model

            Public Sub New(ByVal id As Integer)
                Me.ID = id
            End Sub

            Public Property ID As Integer

            Public Property TrademarkID As Integer

            Public Property Name As String

            Public Property SalesDate As Date?

            Public Property Discount As Double?

            <DataType(DataType.Currency)>
            Public Property ModelPrice As Decimal?

            Public Property Trademark As Integer

            Public Property Modification As String

            Public Property Category As Integer

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            <EnumDataType(GetType(BodyStyle))>
            Public Property BodyStyle As Integer?

            Public Property Cylinders As Integer?

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            Public Property TransmissionType As Integer

            Public ReadOnly Property Photo As Image
                Get
                    Return If(Model IsNot Nothing, Model.Photo, Nothing)
                End Get
            End Property
        End Class

        Public Class TrademarkHeader
            Inherits TrademarkItem

            Public Sub New(ByVal name As String, ByVal id As Integer)
                MyBase.New(id)
                Me.Name = name
                TrademarkID = -1
            End Sub
        End Class

        Public Class TrademarkBody
            Inherits TrademarkItem

            Public Sub New(ByVal _item As OrderItem, ByVal id As Integer)
                MyBase.New(id)
                Model = _item.Model
                ModelPrice = _item.Model.Price
                Name = _item.Model.Name
                Modification = _item.Model.Modification
                Category = _item.Model.Category
                MPGCity = _item.Model.MPGCity
                MPGHighway = _item.Model.MPGHighway
                Doors = _item.Model.Doors
                BodyStyle = _item.Model.BodyStyle
                Cylinders = _item.Model.Cylinders
                Horsepower = _item.Model.Horsepower
                Torque = _item.Model.Torque
                TransmissionSpeeds = _item.Model.TransmissionSpeeds
                TransmissionType = _item.Model.TransmissionType
                Trademark = _item.Model.Trademark
                TrademarkID = _item.Model.Trademark - 1
                SalesDate = _item.SalesDate
                Discount = _item.Discount
            End Sub
        End Class

        Public Class OrderItem

            Friend Model As Model

            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal rnd As DevExpress.Data.Utils.NonCryptographicRandom, ByVal id As Integer)
                Me.Model = model
                ModelPrice = model.Price
                Trademark = model.Trademark
                Name = model.Name
                Modification = model.Modification
                Category = model.Category
                MPGCity = model.MPGCity
                MPGHighway = model.MPGHighway
                Doors = model.Doors
                BodyStyle = model.BodyStyle
                Cylinders = model.Cylinders
                Horsepower = model.Horsepower
                Torque = model.Torque
                TransmissionSpeeds = model.TransmissionSpeeds
                TransmissionType = model.TransmissionType
                SalesDate = TutorialConstants.Now.AddDays(-rnd.Next(days))
                Discount = Math.Round(0.05 * rnd.Next(4), 2)
                OrderID = id
            End Sub

            Public Property OrderID As Integer

            Public Property SalesDate As Date

            Public Property Discount As Double

            <DataType(DataType.Currency)>
            Public Property ModelPrice As Decimal?

            Public Property Trademark As Integer

            Public Property Name As String

            Public Property Modification As String

            Public Property Category As Integer

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            Public Property BodyStyle As Integer

            Public Property Cylinders As Integer

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            Public Property TransmissionType As Integer

            Public ReadOnly Property Photo As Image
                Get
                    Return Model.Photo
                End Get
            End Property
        End Class

        Public Class Model

            Public Property ID As Integer

            Public Property Trademark As Integer

            Public Property Name As String

            Public Property Modification As String

            Public Property Category As Integer

            Public Property Price As Decimal?

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            Public Property BodyStyle As Integer

            Public Property Cylinders As Integer

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            Public Property TransmissionType As Integer

            Public Property Description As String

            Public Property Photo As Image

            Public Property DeliveryDate As Date

            Public Property InStock As Boolean

            Public ReadOnly Property TrademarkImage As Image
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Logo, Nothing)
                End Get
            End Property

            Public ReadOnly Property TrademarkName As String
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Name, String.Empty)
                End Get
            End Property

            Public Function GetSmallTrademarkImage() As Bitmap
                Return Trademarks(Trademark - 1).CaptionLogo
            End Function

            Public Trademarks As List(Of Trademark) = Nothing

            Friend Property LicenseInfo As String
        End Class

        Private Class OrdersData

            Private _DataSet As DataSet, _Trademarks As List(Of DevExpress.XtraTreeList.Demos.VehiclesData.Trademark), _TrademarkItems As List(Of DevExpress.XtraTreeList.Demos.VehiclesData.TrademarkItem)

            Public Sub New(ByVal ds As DataSet, ByVal trademarks As List(Of Trademark), ByVal models As List(Of Model), ByVal itemCount As Integer, ByVal dataInterval As Integer)
                Dim rnd = TutorialConstants.Random
                DataSet = ds
                Me.Trademarks = trademarks
                TrademarkItems = New List(Of TrademarkItem)()
                Dim orders As List(Of OrderItem) = New List(Of OrderItem)()
                For i As Integer = 0 To itemCount - 1
                    orders.Add(New OrderItem(models(rnd.Next(0, models.Count - 1)), dataInterval, rnd, i + 1))
                Next

                Dim id As Integer = 0
                For Each _item As Trademark In trademarks
                    TrademarkItems.Add(New TrademarkHeader(_item.Name, id))
                    id += 1
                Next

                For Each _item As OrderItem In orders
                    TrademarkItems.Add(New TrademarkBody(_item, id))
                    id += 1
                Next

                Threading.Thread.Sleep(1000)
            End Sub

            Public Property DataSet As DataSet
                Get
                    Return _DataSet
                End Get

                Private Set(ByVal value As DataSet)
                    _DataSet = value
                End Set
            End Property

            Public Property Trademarks As List(Of Trademark)
                Get
                    Return _Trademarks
                End Get

                Private Set(ByVal value As List(Of Trademark))
                    _Trademarks = value
                End Set
            End Property

            Public Property TrademarkItems As List(Of TrademarkItem)
                Get
                    Return _TrademarkItems
                End Get

                Private Set(ByVal value As List(Of TrademarkItem))
                    _TrademarkItems = value
                End Set
            End Property
        End Class

        Public Shared Sub InitOrdersData(ByVal dbFileName As String, ByVal treeList As TreeList, ByVal itemCount As Integer, ByVal dataInterval As Integer, ByVal initialization As Action)
            If MainFormHelper.TakeScreens Then
                Dim ds As DataSet = Nothing
                Dim trademarks As List(Of Trademark) = Nothing
                Dim models As List(Of Model) = InitMDBDataCore(dbFileName, ds, trademarks, 1)
                Dim data = New OrdersData(ds, trademarks, models, itemCount, dataInterval)
                treeList.DataSource = data.TrademarkItems
                CreateEditors(treeList, data.DataSet, data.Trademarks)
                If initialization IsNot Nothing Then initialization()
                Return
            End If

            Dim uiScheduler = TaskScheduler.FromCurrentSynchronizationContext()
            Call Task.Factory.StartNew(Function()
                Dim ds As DataSet = Nothing
                Dim trademarks As List(Of Trademark) = Nothing
                Dim models As List(Of Model) = InitMDBDataCore(dbFileName, ds, trademarks, 1)
                Return New OrdersData(ds, trademarks, models, itemCount, dataInterval)
            End Function).ContinueWith(Sub(load)
                treeList.DataSource = load.Result.TrademarkItems
                CreateEditors(treeList, load.Result.DataSet, load.Result.Trademarks)
                If initialization IsNot Nothing Then initialization()
                treeList.LayoutChanged()
            End Sub, uiScheduler)
        End Sub

        Private Shared Function InitMDBDataCore(ByVal dbFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            ds = New DataSet()
            ds.ReadXml(dbFileName)
            listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            Dim rnd = TutorialConstants.Random
            For Each row As DataRow In ds.Tables(Model).Rows
                listModels.Add(New Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = CInt(row("Transmission Type")), .Description = String.Format("{0}", row("Description")), .Photo = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), .DeliveryDate = TutorialConstants.Now.AddDays(rnd.Next(dataInterval)), .InStock = rnd.Next(100) < 95, .Trademarks = listTrademarks, .LicenseInfo = GetLicenseInfo(row)})
            Next

            Return listModels
        End Function

        Friend Shared Function GetLicenseInfo(ByVal row As DataRow) As String
            Return $"{row("License Name")}|{row("Author")}|{row("Source")}|{row("Edits")}"
        End Function

        Public Shared Sub InitEditors(ByVal treeList As TreeList)
            If treeList.Columns.Count = 0 Then Return
            For Each col As TreeListColumn In treeList.Columns
                Dim _item As RepositoryItem = GetEditByFielsName(col.FieldName, treeList.RepositoryItems)
                If _item IsNot Nothing AndAlso col.ColumnEdit Is Nothing Then col.ColumnEdit = _item
            Next

            Dim colPrice As TreeListColumn = treeList.Columns("Price")
            If colPrice IsNot Nothing Then
                colPrice.Format.FormatType = FormatType.Numeric
                colPrice.Format.FormatString = "c"
            End If
        End Sub

        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each _item As RepositoryItem In repositoryItemCollection
                If _item.Name.IndexOf("/" & fieldName) >= 0 Then Return _item
            Next

            Return Nothing
        End Function

        Private Shared Sub CreateEditors(ByVal treeList As TreeList, ByVal ds As DataSet, ByVal listTrademarks As List(Of Trademark))
            CreateSimpleLookUpEdit(treeList, ds.Tables("Category"), "/Category")
            CreateSimpleLookUpEdit(treeList, ds.Tables("BodyStyle"), "/BodyStyle")
            CreateSimpleLookUpEdit(treeList, ds.Tables("TransmissionType"), "/TransmissionType")
            CreateTrademarkLookUpEdit(treeList, listTrademarks, "/Trademark")
            CreateSpinEdit(treeList, "/MPGCity/MPGHighway", 100, 1)
            CreateSpinEdit(treeList, "/Doors", 10, 1)
            CreateSpinEdit(treeList, "/Cylinders", 20, 1)
            CreateSpinEdit(treeList, "/TransmissionSpeeds", 20, -1)
            CreateCurrencyEdit(treeList, "/Price/ModelPrice")
            CreatePictureEdit(treeList, "/TrademarkImage/Photo/Image")
        End Sub

        Private Shared Function CreateSimpleLookUpEdit(ByVal treeList As TreeList, ByVal tbl As DataTable, ByVal name As String) As RepositoryItemLookUpEdit
            Dim ret As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
            treeList.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Columns.AddRange(New XtraEditors.Controls.LookUpColumnInfo() {New XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
            ret.PopupFormMinSize = New Size(100, 0)
            ret.DisplayMember = "Name"
            ret.Name = name
            ret.ShowFooter = False
            ret.ShowHeader = False
            ret.ValueMember = "ID"
            ret.DataSource = tbl
            ret.DropDownRows = tbl.Rows.Count
            ret.NullText = String.Empty
            Return ret
        End Function

        Private Shared Function CreateTrademarkLookUpEdit(ByVal treeList As TreeList, ByVal ds As Object, ByVal name As String) As RepositoryItemTreeListLookUpEditWithGlyph
            Dim riLookUpEditWithGlyph As RepositoryItemTreeListLookUpEditWithGlyph = New RepositoryItemTreeListLookUpEditWithGlyph()
            Dim picture As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            treeList.RepositoryItems.Add(riLookUpEditWithGlyph)
            riLookUpEditWithGlyph.AutoHeight = False
            riLookUpEditWithGlyph.NullText = String.Empty
            riLookUpEditWithGlyph.DisplayMember = "Name"
            riLookUpEditWithGlyph.Name = name
            picture.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            picture.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            riLookUpEditWithGlyph.RepositoryItems.AddRange(New RepositoryItem() {picture})
            riLookUpEditWithGlyph.ValueMember = "ID"
            Dim treeListInner As TreeList = New TreeList()
            riLookUpEditWithGlyph.TreeList = treeListInner
            Dim colLogo As TreeListColumn = New TreeListColumn()
            Dim colName As TreeListColumn = New TreeListColumn()
            treeListInner.Columns.AddRange(New TreeListColumn() {colLogo, colName})
            treeListInner.OptionsView.FocusRectStyle = DrawFocusRectStyle.RowFocus
            treeListInner.OptionsSelection.EnableAppearanceFocusedCell = False
            treeListInner.OptionsView.ShowColumns = False
            treeListInner.OptionsView.ShowIndicator = False
            treeListInner.OptionsView.ShowRoot = False
            colLogo.ColumnEdit = picture
            colLogo.FieldName = "Logo"
            colLogo.Visible = True
            colLogo.VisibleIndex = 0
            colName.FieldName = "Name"
            colName.Visible = True
            colName.VisibleIndex = 1
            riLookUpEditWithGlyph.DataSource = ds
            Return riLookUpEditWithGlyph
        End Function

        Private Shared Function CreateSpinEdit(ByVal treeList As TreeList, ByVal name As String, ByVal maxValue As Integer, ByVal minValue As Integer) As RepositoryItemSpinEdit
            Dim ret As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            treeList.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.IsFloatValue = False
            ret.Mask.EditMask = "N00"
            ret.MaxValue = maxValue
            ret.MinValue = minValue
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreateCurrencyEdit(ByVal treeList As TreeList, ByVal name As String) As RepositoryItemTextEdit
            Dim ret As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            treeList.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Mask.MaskType = XtraEditors.Mask.MaskType.Numeric
            ret.Mask.EditMask = "c"
            ret.Mask.UseMaskAsDisplayFormat = True
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreatePictureEdit(ByVal treeList As TreeList, ByVal name As String) As RepositoryItemPictureEdit
            Dim ret As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            treeList.RepositoryItems.Add(ret)
            ret.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            ret.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            ret.Name = name
            Return ret
        End Function

        Public Shared Function GetTransmissionGlyphs() As ImageCollection
            Dim result As ImageCollection = New ImageCollection()
            result.ImageSize = ScaleUtils.ScaleValue(New Size(16, 16))
            Dim options As StubGlyphOptions = New StubGlyphOptions()
            options.ColorMode = GlyphColorMode.Red
            result.AddImage(CreateStubGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A")
            options.ColorMode = GlyphColorMode.Green
            result.AddImage(CreateStubGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M")
            options.ColorMode = GlyphColorMode.Blue
            result.AddImage(CreateStubGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V")
            options.ColorMode = GlyphColorMode.Yellow
            result.AddImage(CreateStubGlyph("Ltd", result.ImageSize, options, UserLookAndFeel.Default), "Ltd")
            Return result
        End Function

        Private Shared Function CreateStubGlyph(ByVal text As String, ByVal glyphSize As Size, ByVal options As StubGlyphOptions, ByVal skinProvider As ISkinProvider) As Image
            Dim img = New Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(img)
                Using cache As GraphicsCache = New GraphicsCache(g)
                    Call GlyphPainter.Default.DrawGlyph(cache, options, text, New Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal)
                End Using
            End Using

            Return img
        End Function
    End Class
End Namespace

Namespace DevExpress.XtraTreeList.Demos

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

    Public Class RepositoryItemTreeListLookUpEditWithGlyph
        Inherits RepositoryItemTreeListLookUpEdit

        Shared Sub New()
            Call RegisterTreeListLookUpEditWithGlyph()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "TreeListLookUpEditWithGlyph"
            End Get
        End Property

        Public Shared Sub RegisterTreeListLookUpEditWithGlyph()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("TreeListLookUpEditWithGlyph", GetType(TreeListLookUpEditWithGlyph), GetType(RepositoryItemTreeListLookUpEditWithGlyph), GetType(TreeListLookUpEditWithGlyphBaseViewInfo), New TreeListEditPainterWithGlyph(), False))
        End Sub

        Private Shared ReadOnly getImageByValueField As Object = New Object()

        Public Custom Event GetImageByValue As ImageByValueEventHandler
            AddHandler(ByVal value As ImageByValueEventHandler)
                Events.AddHandler(getImageByValueField, value)
            End AddHandler

            RemoveHandler(ByVal value As ImageByValueEventHandler)
                Events.RemoveHandler(getImageByValueField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            End RaiseEvent
        End Event

        Public Function GetImage(ByVal e As ImageByValueEventArgs) As Object
            Dim hander = TryCast(Events(getImageByValueField), ImageByValueEventHandler)
            If hander IsNot Nothing Then hander(Me, e)
            Return e.Image
        End Function

        Public Overrides Sub Assign(ByVal _item As RepositoryItem)
            Dim li As RepositoryItemTreeListLookUpEditWithGlyph = TryCast(_item, RepositoryItemTreeListLookUpEditWithGlyph)
            If li IsNot Nothing Then Events.AddHandler(getImageByValueField, li.Events(getImageByValueField))
            MyBase.Assign(_item)
        End Sub

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overridable ReadOnly Property RepositoryItems As RepositoryItemCollection
            Get
                Return TreeList.RepositoryItems
            End Get
        End Property
    End Class

    Public Class TreeListLookUpEditWithGlyph
        Inherits TreeListLookUpEdit

        Shared Sub New()
            Call RepositoryItemTreeListLookUpEdit.RegisterTreeListLookUpEdit()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "TreeListLookUpEditWithGlyph"
            End Get
        End Property

        Private imageCore As Image

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

    Public Class TreeListLookUpEditWithGlyphBaseViewInfo
        Inherits TreeListLookUpEditBaseViewInfo

        Private glyphCore As Image

        Public Shared DefaultImageSize As Size = New Size(60, 16)

        Public Sub New(ByVal _item As RepositoryItem)
            MyBase.New(_item)
        End Sub

        Public Overloads ReadOnly Property OwnerEdit As TreeListLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.OwnerEdit, TreeListLookUpEditWithGlyph)
            End Get
        End Property

        Public Overloads ReadOnly Property Item As RepositoryItemTreeListLookUpEditWithGlyph
            Get
                Return TryCast(MyBase.Item, RepositoryItemTreeListLookUpEditWithGlyph)
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
            glyphCore = Nothing
        End Sub

        Private Sub UpdateImage()
            requireUpdateImage = False
            glyphCore = GetImageCore(EditValue)
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
                Return glyphCore
            End Get
        End Property
    End Class

    Public Class TreeListEditPainterWithGlyph
        Inherits ButtonEditPainter

        Protected Overrides Sub DrawGlyphCore(ByVal info As ControlGraphicsInfoArgs, ByVal be As ButtonEditViewInfo)
            Dim vi As TreeListLookUpEditWithGlyphBaseViewInfo = TryCast(be, TreeListLookUpEditWithGlyphBaseViewInfo)
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
