Imports System.IO
Imports DevExpress.Data.Utils

Namespace DevExpress.Internal
    Public Class DataDirectoryHelper
        Const DataFolderName As String = "Data"
        '
        Public Shared Function GetFile(fileName As String) As String
            If DataPath IsNot Nothing Then
                Return Path.Combine(DataPath, fileName)
            End If
            Dim dataDirectory As String = Path.GetDirectoryName(SafeEnvironment.ProcessPath)
            If dataDirectory Is Nothing Then
                Return Nothing
            End If
            Dim dataDirectoryRootPath As String = Path.GetFullPath(dataDirectory)
            Dim relativePath As String = Path.Combine(DataFolderName, fileName)
            For n As Integer = 0 To 9
                Dim candidate As String = Path.Combine(dataDirectoryRootPath, relativePath)
                Try
                    If File.Exists(candidate) OrElse Directory.Exists(candidate) Then
                        Return candidate
                    End If
                Catch
                End Try
                dataDirectoryRootPath &= "\.."
            Next
            Throw New FileNotFoundException(String.Format("{0} not found. ({1})", fileName, dataDirectoryRootPath))
        End Function
        '
        Public Shared Property DataPath As String
    End Class
End Namespace
