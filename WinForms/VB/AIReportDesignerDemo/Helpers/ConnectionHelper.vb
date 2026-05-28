Imports System
Imports System.IO

Namespace DevExpress.AI.ReportDesigner.Demo

    Public Module ConnectionHelper

        Const dataDirectoryName As String = "DataDirectory"

        Friend Const DataDirectoryTag As String = "|" & dataDirectoryName & "|"

        Public Function PatchConnection(ByVal connectionString As String, ByVal dataDirectory As String) As String
            Return PatchConnectionCore(connectionString, Function() dataDirectory)
        End Function

        Public Function PatchConnectionCore(ByVal connectionString As String, ByVal getDataDirectory As Func(Of String)) As String
            If Not String.IsNullOrEmpty(connectionString) AndAlso connectionString.Contains(DataDirectoryTag) Then Return connectionString.Replace(DataDirectoryTag, getDataDirectory())
            Return connectionString
        End Function

        Private Function ValidateDirectory(ByVal dataDirectory As String) As String
            Dim result As String = Path.GetFullPath(dataDirectory)
            Return result.TrimEnd("\"c)
        End Function

        Public Function PatchDataDirectory(ByVal connectionString As String) As String
            Return PatchConnectionCore(connectionString, New Func(Of String)(AddressOf GetDataDirectory))
        End Function

        Private Function GetDataDirectory() As String
            Dim dataDirectory As String = TryCast(AppDomain.CurrentDomain.GetData(dataDirectoryName), String)
            If String.IsNullOrEmpty(dataDirectory) Then dataDirectory = AppDomain.CurrentDomain.BaseDirectory
            Return ValidateDirectory(dataDirectory)
        End Function

        Public Sub SetDataDirectory(ByVal directory As String)
            AppDomain.CurrentDomain.SetData("DataDirectory", directory)
        End Sub
    End Module
End Namespace
