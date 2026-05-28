Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Threading.Tasks
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraPivotGrid.Demos.Helpers

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

            Private captionLogoBitmap As Bitmap = Nothing

            Public Property ID As Integer

            Public Property Logo As Image

            Public Property Name As String

            Public ReadOnly Property CaptionLogo As Bitmap
                Get
                    If captionLogoBitmap Is Nothing Then captionLogoBitmap = ResizeImage(Logo, 24, 70)
                    Return captionLogoBitmap
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

            <CustomFunction(IsBlackFridayFunction.FunctionName), CustomFunction(IsWeekendFunction.FunctionName)>
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

        Public Class TrademarkBody
            Inherits TrademarkItem

            Public Sub New(ByVal item As OrderItem, ByVal id As Integer)
                MyBase.New(id)
                Model = item.Model
                ModelPrice = item.Model.Price
                Name = item.Model.Name
                Modification = item.Model.Modification
                Category = item.Model.Category
                MPGCity = item.Model.MPGCity
                MPGHighway = item.Model.MPGHighway
                Doors = item.Model.Doors
                BodyStyle = item.Model.BodyStyle
                Cylinders = item.Model.Cylinders
                Horsepower = item.Model.Horsepower
                Torque = item.Model.Torque
                TransmissionSpeeds = item.Model.TransmissionSpeeds
                TransmissionType = item.Model.TransmissionType
                Trademark = item.Model.Trademark
                TrademarkID = item.Model.Trademark - 1
                SalesDate = item.SalesDate
                Discount = item.Discount
            End Sub
        End Class

        Public Class OrderItem

            Friend Model As Model

            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal rnd As NonCryptographicRandom, ByVal id As Integer)
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
                SalesDate = Date.Now.AddDays(-rnd.Next(days))
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
        End Class

        Private Class OrdersData

            Private _DataSet As DataSet, _Trademarks As List(Of DevExpress.XtraPivotGrid.Demos.Helpers.VehiclesData.Trademark), _TrademarkItems As List(Of DevExpress.XtraPivotGrid.Demos.Helpers.VehiclesData.TrademarkItem)

            Public Sub New(ByVal ds As DataSet, ByVal trademarks As List(Of Trademark), ByVal models As List(Of Model), ByVal itemCount As Integer, ByVal days As Integer)
                Dim rnd As NonCryptographicRandom = NonCryptographicRandom.Default
                DataSet = ds
                Me.Trademarks = trademarks
                TrademarkItems = New List(Of TrademarkItem)()
                Dim orders As List(Of OrderItem) = New List(Of OrderItem)()
                For i As Integer = 0 To itemCount - 1
                    orders.Add(New OrderItem(models(rnd.Next(0, models.Count - 1)), days, rnd, i + 1))
                Next

                Dim id As Integer = 0
                For Each item As OrderItem In orders
                    TrademarkItems.Add(New TrademarkBody(item, id))
                    id += 1
                Next
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

        Public Shared Sub InitOrdersData(ByVal dbFileName As String, ByVal pivot As PivotGridControl, ByVal itemCount As Integer, ByVal dateInterval As Integer, ByVal initialization As Action)
            Dim uiScheduler = TaskScheduler.FromCurrentSynchronizationContext()
            Call Task.Factory.StartNew(Function()
                Dim ds As DataSet = Nothing
                Dim trademarks As List(Of Trademark) = Nothing
                Dim models As List(Of Model) = InitMDBDataCore(dbFileName, ds, trademarks, 1)
                Return New OrdersData(ds, trademarks, models, itemCount, dateInterval)
            End Function).ContinueWith(Sub(load)
                Call CreateEditors(pivot, load.Result.DataSet, load.Result.Trademarks)
                Call InitEditors(pivot)
                pivot.DataSource = load.Result.TrademarkItems
                If initialization IsNot Nothing Then initialization()
            End Sub, uiScheduler)
        End Sub

        '
        Private Shared Function InitMDBDataCore(ByVal dbFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            ds = New DataSet()
            ds.ReadXml(dbFileName)
            listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New VehiclesData.Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            Dim rnd As NonCryptographicRandom = NonCryptographicRandom.Default
            For Each row As DataRow In ds.Tables(Model).Rows
                listModels.Add(New VehiclesData.Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = CInt(row("Transmission Type")), .Description = String.Format("{0}", row("Description")), .Photo = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), .DeliveryDate = Date.Now.AddDays(rnd.Next(dataInterval)), .InStock = rnd.Next(100) < 95, .Trademarks = listTrademarks})
            Next

            Return listModels
        End Function

        Public Shared Sub InitEditors(ByVal pivot As PivotGridControl)
            If pivot.Fields.Count = 0 Then Return
            For Each field As PivotGridField In pivot.Fields
                Dim binding = TryCast(field.DataBinding, DataSourceColumnBinding)
                Dim fieldName As String = If(binding IsNot Nothing, binding.ColumnName, field.FieldName)
                Dim item As RepositoryItem = GetEditByFielsName(fieldName, pivot.RepositoryItems)
                If item IsNot Nothing AndAlso field.FieldEdit Is Nothing Then field.FieldEdit = item
            Next
        End Sub

        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each item As RepositoryItem In repositoryItemCollection
                If item.Name.IndexOf("/" & fieldName) >= 0 Then Return item
            Next

            Return Nothing
        End Function

        Private Shared Sub CreateEditors(ByVal pivot As PivotGridControl, ByVal ds As DataSet, ByVal listTrademarks As List(Of Trademark))
            Call CreateLookUp(pivot, listTrademarks, "/Trademark")
        End Sub

        Private Shared Function CreateLookUp(ByVal pivot As PivotGridControl, ByVal dataSource As Object, ByVal name As String) As RepositoryItemLookUpEdit
            Dim ret As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
            pivot.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Columns.AddRange(New LookUpColumnInfo() {New LookUpColumnInfo("Name", "Name")})
            ret.Name = name
            ret.ShowFooter = False
            ret.ShowHeader = False
            ret.ValueMember = "ID"
            ret.DisplayMember = "Name"
            ret.DataSource = dataSource
            Return ret
        End Function
    End Class
End Namespace
