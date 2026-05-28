Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraVerticalGrid.Demos

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

            <EnumDataType(GetType(BodyStyle))>
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

        Public Shared Sub InitOrdersData(ByVal dataFileName As String, ByVal vGridControl As VGridControl, ByVal itemCount As Integer, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim trademarks As List(Of Trademark) = Nothing
            Dim models As List(Of Model) = InitXMLDataCore(dataFileName, ds, trademarks, 1)
            vGridControl.DataSource = CreateOrders(models, itemCount, dataInterval)
            CreateEditors(vGridControl, ds, trademarks)
        End Sub

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark)) As List(Of Model)
            Return InitXMLDataCore(dataFileName, ds, listTrademarks, 30)
        End Function

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            ds = GetDataSet(dataFileName)
            listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            For Each row As DataRow In ds.Tables(Model).Rows
                listModels.Add(New Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = CInt(row("Transmission Type")), .Description = String.Format("{0}", row("Description")), .Photo = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), .DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)), .InStock = TutorialConstants.Random.Next(100) < 95, .Trademarks = listTrademarks, .LicenseInfo = GetLicenseInfo(row)})
            Next

            Return listModels
        End Function

        Friend Shared Function GetLicenseInfo(ByVal row As DataRow) As String
            Return $"{row("License Name")}|{row("Author")}|{row("Source")}|{row("Edits")}"
        End Function

        Private ReadOnly Shared dataSets As Dictionary(Of String, DataSet) = New Dictionary(Of String, DataSet)()

        Private Shared Function GetDataSet(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = Nothing
            If Not dataSets.TryGetValue(dataFileName, ds) Then
                ds = New DataSet()
                ds.ReadXml(dataFileName)
                dataSets.Add(dataFileName, ds)
            End If

            Return ds
        End Function

        Private Shared Function CreateOrders(ByVal models As List(Of Model), ByVal itemCount As Integer, ByVal dataInterval As Integer) As List(Of OrderItem)
            Dim orders = New List(Of OrderItem)()
            For i As Integer = 0 To itemCount - 1
                orders.Add(New OrderItem(models(TutorialConstants.Random.Next(0, models.Count - 1)), dataInterval, TutorialConstants.Random, i + 1))
            Next

            Return orders
        End Function

        Public Shared Sub InitEditors(ByVal vGridControl As VGridControl)
            If vGridControl.Rows.Count = 0 Then Return
            For Each row In vGridControl.Rows
                SetRowEditorProperties(row, vGridControl)
            Next

            Dim colPrice As BaseRow = vGridControl.Rows("Price")
            If colPrice IsNot Nothing Then
                colPrice.Properties.Format.FormatType = FormatType.Numeric
                colPrice.Properties.Format.FormatString = "c"
            End If
        End Sub

        Private Shared Sub SetRowEditorProperties(ByVal row As BaseRow, ByVal vGridControl As VGridControl)
            If TypeOf row Is EditorRow Then SetEditorProperties(row.Properties, vGridControl)
            If TypeOf row Is CategoryRow Then
                Dim category = TryCast(row, CategoryRow)
                If category.HasChildren Then SetChildRowsEditorProperties(category.ChildRows, vGridControl)
            End If

            If TypeOf row Is MultiEditorRow Then
                Dim multiEditorRow = TryCast(row, MultiEditorRow)
                If multiEditorRow.HasChildren Then SetChildRowsEditorProperties(multiEditorRow.ChildRows, vGridControl)
                If multiEditorRow.PropertiesCollection.Count > 0 Then SetEditorPropertiesCollection(multiEditorRow.PropertiesCollection, vGridControl)
            End If
        End Sub

        Private Shared Sub SetEditorProperties(ByVal rowProperties As RowProperties, ByVal vGridControl As VGridControl)
            Dim item As RepositoryItem = GetEditByFielsName(rowProperties.FieldName, vGridControl.RepositoryItems)
            If item IsNot Nothing AndAlso rowProperties.RowEdit Is Nothing Then rowProperties.RowEdit = item
        End Sub

        Private Shared Sub SetChildRowsEditorProperties(ByVal childRows As VGridRows, ByVal vGridControl As VGridControl)
            For Each row In childRows
                SetRowEditorProperties(row, vGridControl)
            Next
        End Sub

        Private Shared Sub SetEditorPropertiesCollection(ByVal propertiesCollection As MultiEditorRowPropertiesCollection, ByVal vGridControl As VGridControl)
            For Each rowProperties As RowProperties In propertiesCollection
                SetEditorProperties(rowProperties, vGridControl)
            Next
        End Sub

        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each item As RepositoryItem In repositoryItemCollection
                If item.Name.IndexOf("/" & fieldName) >= 0 Then Return item
            Next

            Return Nothing
        End Function

        Private Shared Sub CreateEditors(ByVal vGridControl As VGridControl, ByVal ds As DataSet, ByVal trademarks As List(Of Trademark))
            CreateSimpleLookUpEdit(vGridControl, ds.Tables("Category"), "/Category")
            CreateSimpleLookUpEdit(vGridControl, ds.Tables("BodyStyle"), "/BodyStyle")
            CreateSimpleLookUpEdit(vGridControl, ds.Tables("TransmissionType"), "/TransmissionType")
            CreateSimpleLookUpEdit(vGridControl, ds.Tables("Trademark"), "/Trademark") ' TODO images
            CreateSpinEdit(vGridControl, "/MPGCity/MPGHighway", 100, 1)
            CreateSpinEdit(vGridControl, "/Doors", 10, 1)
            CreateSpinEdit(vGridControl, "/Cylinders", 20, 1)
            CreateSpinEdit(vGridControl, "/TransmissionSpeeds", 20, -1)
            CreateCurrencyEdit(vGridControl, "/Price/ModelPrice")
            CreatePictureEdit(vGridControl, "/TrademarkImage/Photo/Image")
        End Sub

        Private Shared Function CreateSimpleLookUpEdit(ByVal vGridControl As VGridControl, ByVal tbl As DataTable, ByVal name As String) As RepositoryItemLookUpEdit
            Dim ret As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
            vGridControl.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Columns.AddRange(New XtraEditors.Controls.LookUpColumnInfo() {New LookUpColumnInfo("Name", "Name")})
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

        Private Shared Function CreateSpinEdit(ByVal vGridControl As VGridControl, ByVal name As String, ByVal maxValue As Integer, ByVal minValue As Integer) As RepositoryItemSpinEdit
            Dim ret As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            vGridControl.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.IsFloatValue = False
            ret.Mask.EditMask = "N00"
            ret.MaxValue = maxValue
            ret.MinValue = minValue
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreateCurrencyEdit(ByVal vGridControl As VGridControl, ByVal name As String) As RepositoryItemTextEdit
            Dim ret As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            vGridControl.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Mask.MaskType = XtraEditors.Mask.MaskType.Numeric
            ret.Mask.EditMask = "c"
            ret.Mask.UseMaskAsDisplayFormat = True
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreatePictureEdit(ByVal vGridControl As VGridControl, ByVal name As String) As RepositoryItemPictureEdit
            Dim ret As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            vGridControl.RepositoryItems.Add(ret)
            ret.PictureInterpolationMode = InterpolationMode.HighQualityBicubic
            ret.SizeMode = PictureSizeMode.Squeeze
            ret.Name = name
            Return ret
        End Function
    End Class
End Namespace
