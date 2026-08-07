Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Xml.Serialization
#If NET
using Microsoft.EntityFrameworkCore;
#Else
Imports System.Data.SQLite

#End If
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

        Private ReadOnly employees As Lazy(Of Dictionary(Of Integer, Employee)) = New Lazy(Of Dictionary(Of Integer, Employee))(AddressOf LoadEmployees)

        Sub New()
            FilteredEmployees = New EmployeesWithPhotoData()
            For Each id In filteredIds
                Dim employee As Employee
                If Not employees.Value.TryGetValue(id, employee) Then Continue For
                employee.ParentId = GetParentId(id)
                employee.CroppedImageData = CropImage(employee.ImageData)
                FilteredEmployees.Add(employee)
            Next
        End Sub

        Public Function GetOrgChartEmployees() As IEnumerable(Of Object)
            Dim allEmployees = New EmployeesWithPhotoData()
            For Each employee In employees.Value.Values.OrderBy(Function(x) x.Id)
                employee.ParentId = GetParentId(employee.Id)
                allEmployees.Add(employee)
            Next

            Return allEmployees
        End Function

        Private Function LoadEmployees() As Dictionary(Of Integer, Employee)
            Dim result = New Dictionary(Of Integer, Employee)()
            Dim path As String = Internal.DataDirectoryHelper.GetFile("devav.sqlite3", Internal.DataDirectoryHelper.DataFolderName)
            ClearReadOnly(path)
#If NET
            using(var devAvDb = new DevExpress.DevAV.DevAVDb($"Data Source={path}")) {
                var sources = devAvDb.Employees
                    .Include(e => e.Picture)
                    .ToList();
                foreach(var source in sources) {
                    if(source.Picture == null || source.Picture.Data == null)
                        continue;
                    result[(int)source.Id] = new Employee {
                        Id = (int)source.Id,
                        FirstName = source.FirstName,
                        LastName = source.LastName,
                        JobTitle = source.Title,
                        GroupName = GetDepartmentName(source.Department),
                        Phone = string.IsNullOrEmpty(source.MobilePhone) ? source.HomePhone : source.MobilePhone,
                        EmailAddress = source.Email,
                        AddressLine1 = source.Address != null ? source.Address.Line : null,
                        BirthDate = source.BirthDate ?? default(DateTime),
                        HireDate = source.HireDate ?? default(DateTime),
                        ImageData = source.Picture.Data
                    };
                }
            }
#Else
            Using connection = New SQLiteConnection(New SQLiteConnectionStringBuilder With {.DataSource = path}.ConnectionString)
                connection.Open()
                Using command = connection.CreateCommand()
                    command.CommandText = "SELECT e.Id, e.FirstName, e.LastName, e.Department, e.Title, " & "e.MobilePhone, e.HomePhone, e.Email, e.Address_Line, e.BirthDate, e.HireDate, p.Data " & "FROM Employees e LEFT JOIN Pictures p ON p.Id = e.PictureId"
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            If reader.IsDBNull(11) Then Continue While
                            Dim employee = New Employee With {.Id = CInt(reader.GetInt64(0)), .FirstName = reader.GetString(1), .LastName = reader.GetString(2), .GroupName = GetDepartmentName(CType(reader.GetInt64(3), DevAV.EmployeeDepartment)), .JobTitle = reader.GetString(4), .Phone = If(Not reader.IsDBNull(5), reader.GetString(5), If(Not reader.IsDBNull(6), reader.GetString(6), Nothing)), .EmailAddress = If(Not reader.IsDBNull(7), reader.GetString(7), Nothing), .AddressLine1 = If(Not reader.IsDBNull(8), reader.GetString(8), Nothing), .BirthDate = If(Not reader.IsDBNull(9), reader.GetDateTime(9), Nothing), .HireDate = If(Not reader.IsDBNull(10), reader.GetDateTime(10), Nothing), .ImageData = CType(reader(11), Byte())}
                            result(employee.Id) = employee
                        End While
                    End Using
                End Using
            End Using

#End If
            Return result
        End Function

        Private Sub ClearReadOnly(ByVal path As String)
            Try
                Dim attributes = File.GetAttributes(path)
                If attributes.HasFlag(FileAttributes.ReadOnly) Then File.SetAttributes(path, attributes And Not FileAttributes.ReadOnly)
            Catch
            End Try
        End Sub

        Private Function GetDepartmentName(ByVal department As DevAV.EmployeeDepartment) As String
            Select Case department
                Case DevAV.EmployeeDepartment.Sales
                    Return "Sales"
                Case DevAV.EmployeeDepartment.Support
                    Return "Support"
                Case DevAV.EmployeeDepartment.Shipping
                    Return "Shipping"
                Case DevAV.EmployeeDepartment.Engineering
                    Return "Engineering"
                Case DevAV.EmployeeDepartment.HumanResources
                    Return "Human Resources"
                Case DevAV.EmployeeDepartment.Management
                    Return "Management"
                Case DevAV.EmployeeDepartment.IT
                    Return "IT"
                Case Else
                    Return String.Empty
            End Select
        End Function

        Private Function GetParentId(ByVal id As Integer) As Integer
            For Each pair In idMap
                If pair.Value.Contains(id) Then Return pair.Key
            Next

            Return 0
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

        Private ReadOnly filteredIds As Integer() = {1, 2, 3, 4, 5, 6, 30, 8, 9, 10, 32}

#Region "id map"
        Private ReadOnly idMap As Dictionary(Of Integer, Integer()) = New Dictionary(Of Integer, Integer())() From {{1, {2, 3, 4}}, {2, {5}}, {3, {32}}, {4, {8}}, {5, {11, 26, 27, 7, 30, 9, 10}}, {6, {21, 22, 23, 24, 25, 28}}, {8, {12, 20, 40, 41, 42, 43, 44, 45, 47}}, {9, {17, 18, 19, 31, 39, 46}}, {10, {13, 14, 15, 16, 49, 50}}, {32, {33, 34, 36, 37, 48, 51, 6}}, {28, {29}}, {33, {38}}}
#End Region
    End Module
End Namespace
