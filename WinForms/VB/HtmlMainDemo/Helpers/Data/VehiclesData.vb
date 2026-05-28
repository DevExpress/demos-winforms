Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Namespace DevExpress.HTML.Demos.Helpers.Data

    Public Class VehiclesData

        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")>
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum

        Public Class BodyStyle

            Public Property ID As Integer

            Public Property Name As String
        End Class

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

        Public Class OrderItem

            Friend Model As Model

            Public Sub New(ByVal totalCount As Integer, ByVal models As List(Of Model), ByVal id As Integer)
                Me.New(totalCount, models(id Mod models.Count), id)
            End Sub

            Public Sub New(ByVal totalCount As Integer, ByVal model As Model, ByVal id As Integer)
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
                Discount = Math.Round(0.05 * (id * Trademark Mod 4), 2)
                OrderID = id
                If totalCount > 0 Then CreateSalesInfo(id, totalCount)
            End Sub

            Private Sub CreateSalesInfo(ByVal id As Integer, ByVal totalCount As Integer)
                Dim salesPerDay = totalCount / (365.25 * 7)
                Dim lastSaleDateTime = TutorialConstants.Today.AddHours(-15)
                SalesDate = lastSaleDateTime.AddDays(-id / salesPerDay)
                Dim orderWithinYearId = CInt(Math.Floor((SalesDate - New DateTime(SalesDate.Year, 1, 1)).TotalDays * salesPerDay)) + 1
                SalesID = String.Format("{0:d4}-<size=-1><b>{1:d6}</b>", SalesDate.Year, orderWithinYearId)
            End Sub

            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal rnd As DevExpress.Data.Utils.NonCryptographicRandom, ByVal id As Integer)
                Me.New(-1, model, id)
                Discount = Math.Round(0.05 * rnd.Next(4), 2)
                SalesDate = TutorialConstants.Now.AddDays(-rnd.Next(days))
            End Sub

            Public Property OrderID As Integer

            Public Property SalesID As String

            Public Property SalesDate As Date

            Public Property Discount As Double

            <DataType(DataType.Currency)>
            Public Property ModelPrice As Decimal

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

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

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

            Public ReadOnly Property BodyStyleName As String
                Get
                    Return If(BodyStyles IsNot Nothing, BodyStyles(BodyStyle - 1).Name, String.Empty)
                End Get
            End Property

            Public ReadOnly Property TrademarkName As String
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Name, String.Empty)
                End Get
            End Property

            Public ReadOnly Property CategoryName As String
                Get
                    Return EnumDisplayTextHelper.GetDisplayText(CType(Category, Category))
                End Get
            End Property

            Public ReadOnly Property CategoryNameCaps As String
                Get
                    Return CategoryName?.ToUpperInvariant()
                End Get
            End Property

            Public Function GetSmallTrademarkImage() As Bitmap
                Return Trademarks(Trademark - 1).CaptionLogo
            End Function

            Public Trademarks As List(Of Trademark) = Nothing

            Public BodyStyles As List(Of BodyStyle) = Nothing

            Public Property LicenseName As String

            Public Property Author As String

            Public Property Source As String

            Public ReadOnly Property SourceLink As String
                Get
                    Return $"http:\{Source}"
                End Get
            End Property

            Public Property Edits As String
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

        Public Shared Sub InitXMLData(ByVal dataFileName As String, ByVal grid As GridControl)
            Call InitXMLData(dataFileName, grid, 30)
        End Sub

        Public Shared Sub InitXMLData(ByVal dataFileName As String, ByVal grid As GridControl, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listStyles As List(Of BodyStyle) = Nothing
            Dim listModels As List(Of Model) = InitXMLDataCore(dataFileName, ds, listTrademarks, listStyles, dataInterval)
            grid.DataSource = listModels
        End Sub

        Public Shared Sub InitVehiclesData(ByVal gc As GridControl)
            Dim DBFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml")
            If Not Equals(DBFileName, String.Empty) Then Call VehiclesData.InitXMLData(DBFileName, gc)
        End Sub

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark), <Out> ByRef listStyles As List(Of BodyStyle), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            ds = GetDataSet(dataFileName)
            listStyles = New List(Of BodyStyle)()
            For Each row As DataRow In ds.Tables("BodyStyle").Rows
                listStyles.Add(New VehiclesData.BodyStyle() With {.ID = CInt(row("ID")), .Name = CStr(row("Name"))})
            Next

            listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New VehiclesData.Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            For Each row As DataRow In ds.Tables(Model).Rows
                listModels.Add(New VehiclesData.Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = CInt(row("Transmission Type")), .Description = String.Format("{0}", row("Description")), .Photo = CropImageHelper.Crop(ByteImageConverter.FromByteArray(CType(row("Photo"), Byte()))), .DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)), .InStock = TutorialConstants.Random.Next(100) < 95, .Trademarks = listTrademarks, .BodyStyles = listStyles, .LicenseName = $"{row("License Name")}", .Author = $"{row("Author")}", .Source = $"{row("Source")}", .Edits = $"{row("Edits")}"})
            Next

            Return listModels
        End Function

        Private ReadOnly Shared dataSets As Dictionary(Of String, DataSet) = New Dictionary(Of String, DataSet)()

        Private Shared Function GetDataSet(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = Nothing
            If Not dataSets.TryGetValue(dataFileName, ds) Then
                ds = New DataSet()
                ds.ReadXml(dataFileName)
                Call dataSets.Add(dataFileName, ds)
            End If

            Return ds
        End Function
    End Class

    Friend Module CropImageHelper

        Public Function Crop(ByVal img As Image) As Image
            Dim bmp As Bitmap = TryCast(img, Bitmap)
            If bmp Is Nothing Then Return img
            Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat)
            Dim size As Integer = data.Stride * data.Height
            Dim bt As Byte() = New Byte(size - 1) {}
            Marshal.Copy(data.Scan0, bt, 0, size)
            Dim left As Integer = GetLeft(data, bt)
            Dim right As Integer = GetRight(data, bt)
            Dim top As Integer = GetTop(data, bt)
            Dim bottom As Integer = GetBottom(data, bt)
            bmp.UnlockBits(data)
            Dim lCrop As Rectangle = New Rectangle(left, top, right - left, bottom - top)
            Dim res As Bitmap = New Bitmap(bmp, lCrop.Width, lCrop.Height)
            Using g As Graphics = Graphics.FromImage(res)
                g.DrawImage(bmp, New Rectangle(0, 0, res.Width, res.Height), lCrop, GraphicsUnit.Pixel)
            End Using

            Return res
        End Function

        Private Function GetLeft(ByVal data As BitmapData, ByVal bt As Byte()) As Integer
            Dim pixelSize As Integer = GetPixelSize(data.PixelFormat)
            For x As Integer = 0 To data.Width - 1
                For y As Integer = 0 To data.Height - 1
                    Dim pos As Integer = y * data.Stride + x * pixelSize
                    For l As Integer = 0 To pixelSize - 1
                        If bt(pos + l) < 250 Then Return x ' white and alpha
                    Next
                Next
            Next

            Return 0
        End Function

        Private Function GetRight(ByVal data As BitmapData, ByVal bt As Byte()) As Integer
            Dim pixelSize As Integer = GetPixelSize(data.PixelFormat)
            For x As Integer = data.Width - 1 To 0 Step -1
                For y As Integer = 0 To data.Height - 1
                    Dim pos As Integer = y * data.Stride + x * pixelSize
                    For l As Integer = 0 To pixelSize - 1
                        If bt(pos + l) < 250 Then Return x ' white and alpha
                    Next
                Next
            Next

            Return data.Width - 1
        End Function

        Private Function GetTop(ByVal data As BitmapData, ByVal bt As Byte()) As Integer
            Dim pixelSize As Integer = GetPixelSize(data.PixelFormat)
            For y As Integer = 0 To data.Height - 1
                For x As Integer = 0 To data.Width - 1
                    Dim pos As Integer = y * data.Stride + x * pixelSize
                    For l As Integer = 0 To pixelSize - 1
                        If bt(pos + l) < 250 Then Return y ' white and alpha
                    Next
                Next
            Next

            Return 0
        End Function

        Private Function GetBottom(ByVal data As BitmapData, ByVal bt As Byte()) As Integer
            Dim pixelSize As Integer = GetPixelSize(data.PixelFormat)
            For y As Integer = data.Height - 1 To 0 Step -1
                For x As Integer = 0 To data.Width - 1
                    Dim pos As Integer = y * data.Stride + x * pixelSize
                    For l As Integer = 0 To pixelSize - 1
                        If bt(pos + l) < 250 Then Return y ' white and alpha
                    Next
                Next
            Next

            Return data.Height - 1
        End Function

        Private Function GetPixelSize(ByVal pixelFormat As PixelFormat) As Integer
            If pixelFormat = PixelFormat.Format32bppArgb OrElse pixelFormat = PixelFormat.Format32bppPArgb OrElse pixelFormat = PixelFormat.Format32bppRgb Then Return 4
            Return 3
        End Function
    End Module
End Namespace
