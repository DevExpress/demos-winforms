Imports System.Data
Imports System.IO

Namespace DevExpress.XtraRichEdit.Demos

    Public Class DBUriStreamProvider
        Implements Office.Services.IUriStreamProvider

        Private ReadOnly table As DataTable

        Private ReadOnly columnName As String

        Public Sub New(ByVal table As DataTable, ByVal columnName As String)
            Me.table = table
            Me.columnName = columnName
        End Sub

        Private Function GetStream(ByVal uri As String) As Stream Implements Office.Services.IUriStreamProvider.GetStream
            Const prefix As String = "dbimg://"
            uri = uri.Trim()
            If Not uri.StartsWith(prefix, System.StringComparison.OrdinalIgnoreCase) Then Return Nothing
            Dim strId As String = uri.Substring(prefix.Length).Trim()
            Dim id As Integer
            If Not Integer.TryParse(strId, id) Then Return Nothing
            Dim row As DataRow = table.Rows.Find(id)
            If row Is Nothing Then Return Nothing
            Dim bytes As Byte() = TryCast(row(columnName), Byte())
            If bytes Is Nothing Then Return Nothing
            Return New MemoryStream(bytes)
        End Function
    End Class
End Namespace
