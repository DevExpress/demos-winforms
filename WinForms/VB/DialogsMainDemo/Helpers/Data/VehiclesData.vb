Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraDialogs.Demos.Helpers.Data

    Public Class VehiclesData

        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")>
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum

        Public Enum TransmissionType
            Automatic = 1
            Manual = 2
            Variomatic = 3
        End Enum

        Public Class BodyStyle

            Public Property ID As Integer

            Public Property Name As String
        End Class

        Public Class Trademark

            Public Property ID As Integer

            Public Property Logo As Image

            Public Property Name As String

            Private ReadOnly logoImages As Dictionary(Of Integer, Image) = New Dictionary(Of Integer, Image)()

            Public Function GetLogo(ByVal size As Size) As Image
                Dim image As Image = Nothing
                Dim imageSizeKey As Integer =(size.Width << 16) + size.Width
                If Not logoImages.TryGetValue(imageSizeKey, image) Then
                    image = ResizeImage(Logo, size.Height, size.Width)
                    logoImages.Add(imageSizeKey, image)
                End If

                Return image
            End Function
        End Class

        Public Class Model

            Public Property ID As Integer

            Public Property Trademark As Integer

            Public Property Name As String

            Public Property Modification As String

            <EnumDataType(GetType(Category))>
            Public Property Category As Integer

            Public Property Price As Decimal

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            Public Property BodyStyle As Integer

            Public Property Cylinders As Integer

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            <EnumDataType(GetType(TransmissionType))>
            Public Property TransmissionType As Integer

            Public Property Description As String

            Public Property Image As Image

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

            Public Trademarks As List(Of Trademark) = Nothing

            Public BodyStyles As List(Of BodyStyle) = Nothing

            Private ReadOnly images As Dictionary(Of Integer, Image) = New Dictionary(Of Integer, Image)()

            Public Function GetImage(ByVal size As Size) As Image
                Dim image As Image = Nothing
                Dim imageSizeKey As Integer =(size.Width << 16) + size.Width
                If Not images.TryGetValue(imageSizeKey, image) Then
                    image = ResizeImage(Me.Image, size.Height, size.Width)
                    images.Add(imageSizeKey, image)
                End If

                Return image
            End Function

            Friend Property LicenseInfo As String
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

        Public Shared Function InitXMLDataCore(ByVal dataFileName As String) As List(Of Model)
            Dim ds = GetDataSet(dataFileName)
            Dim listStyles = New List(Of BodyStyle)()
            For Each row As DataRow In ds.Tables("BodyStyle").Rows
                listStyles.Add(New VehiclesData.BodyStyle() With {.ID = CInt(row("ID")), .Name = CStr(row("Name"))})
            Next

            Dim listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables("Trademark").Rows
                listTrademarks.Add(New VehiclesData.Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            For Each row As DataRow In ds.Tables("Model").Rows
                listModels.Add(New VehiclesData.Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = If((CStr(row("Modification"))).Contains("VA"), 3, CInt(row("Transmission Type"))), .Description = String.Format("{0}", row("Description")), .Image = ResizeImage(ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), 128, 128), .Photo = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), .DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(30)), .InStock = TutorialConstants.Random.Next(100) < 95, .Trademarks = listTrademarks, .BodyStyles = listStyles, .LicenseInfo = GetLicenseInfo(row)})
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
                Call dataSets.Add(dataFileName, ds)
            End If

            Return ds
        End Function
    End Class
End Namespace
