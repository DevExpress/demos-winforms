Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Xml.Serialization

Namespace DevExpress.Diagram.Demos

    <XmlRoot("Employees")>
    Public Class EmployeesWithPhotoData
        Inherits List(Of Employee)

    End Class

    Public Class Employee

        Public Property Id As Integer

        Public Property ParentId As Integer

        Public Property FirstName As String

        Public Property MiddleName As String

        Public Property LastName As String

        Public ReadOnly Property FullName As String
            Get
                Return FirstName & " " & LastName
            End Get
        End Property

        Public Property JobTitle As String

        Public Property GroupName As String

        Public Property Phone As String

        Public Property EmailAddress As String

        Public Property AddressLine1 As String

        Public Property City As String

        Public Property StateProvinceName As String

        Public Property PostalCode As String

        Public Property CountryRegionName As String

        Public Property BirthDate As Date

        Public Property HireDate As Date

        Public Property Gender As String

        Public Property MaritalStatus As String

        Public Property Title As String

        <XmlIgnore>
        Public Property CroppedImageData As Byte()

        Public Property ImageData As Byte()

        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class

    Public Module EmployeesData

        Public ReadOnly FilteredEmployees As EmployeesWithPhotoData

        Sub New()
            Using stream = GetDataStream("FilteredEmployeesWithPhoto.xml")
                FilteredEmployees = Utils.SafeXml.Deserialize(Of EmployeesWithPhotoData)(stream)
            End Using

            For Each employee In FilteredEmployees
                employee.CroppedImageData = CropImage(employee.ImageData)
            Next
        End Sub

        Public Function GetOrgChartEmployees() As IEnumerable(Of Object)
            Dim allEmployees As EmployeesWithPhotoData
            Using stream = GetDataStream("EmployeesWithPhoto.xml")
                allEmployees = Utils.SafeXml.Deserialize(Of EmployeesWithPhotoData)(stream)
            End Using

            For Each pair In idMap
                For Each childID In pair.Value
                    Dim copyID = childID
                    allEmployees.Find(Function(x) Equals(copyID, x.Id)).ParentId = pair.Key
                Next
            Next

            Return allEmployees
        End Function

        Private Function CropImage(ByVal imageBytes As Byte()) As Byte()
            Using ms = New MemoryStream(imageBytes)
                Using original = Image.FromStream(ms)
                    Dim skipYOffset As Integer = 50
                    Dim cropHeight As Integer = 220
                    If skipYOffset + cropHeight > original.Height Then cropHeight = original.Height - skipYOffset
                    Dim cropArea = New Rectangle(0, skipYOffset, original.Width, cropHeight)
                    Using bmp = New Bitmap(cropArea.Width, cropArea.Height)
                        Using g = Graphics.FromImage(bmp)
                            g.DrawImage(original, New Rectangle(0, 0, bmp.Width, bmp.Height), cropArea, GraphicsUnit.Pixel)
                        End Using

                        Using output = New MemoryStream()
                            bmp.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Return output.ToArray()
                        End Using
                    End Using
                End Using
            End Using
        End Function

#Region "id map"
        '0
        '1
        '2
        '3
        '4
        '5
        Private idMap As Dictionary(Of Integer, Integer()) = New Dictionary(Of Integer, Integer())() From {{109, {42, 117, 102}}, {42, {149, 150, 28}}, {117, {188, 6}}, {102, {46}}, {149, {119}}, {150, {140, 30, 191}}, {28, {82, 70}}, {188, {71, 274}}, {6, {261}}, {46, {266, 103, 139, 216}}, {119, {130, 12}}, {30, {3}}, {191, {263, 5}}, {82, {265, 11, 4}}, {71, {270, 217}}, {274, {79, 114, 273}}, {266, {268}}, {103, {278, 283, 276}}, {139, {290, 284}}, {216, {287}}, {130, {281, 288}}, {12, {280, 277}}, {263, {275, 148, 218}}, {114, {225, 49}}, {283, {260, 21}}, {287, {200}}, {288, {44}}, {148, {206, 41, 145}}}
#End Region
    End Module
End Namespace
