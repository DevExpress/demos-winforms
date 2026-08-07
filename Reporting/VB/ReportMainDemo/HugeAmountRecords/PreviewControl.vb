Imports System
Imports Microsoft.Data.Sqlite
Imports System.IO
Imports System.Threading.Tasks
Imports DevExpress.XtraPrinting.Caching
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.HugeAmountRecords

    Public Class PreviewControl
        Inherits ReportModule

#Region "inner classes"
        Private Class StorageHelper
            Implements IDisposable

            Const dbFileName As String = "ReportCache"

            Const dbFileExtension As String = ".db"

            Private ReadOnly path As String

            Public Sub New(ByVal path As String)
                Me.path = path
            End Sub

            Public Function CreateStorage() As DocumentStorage
                Clear()
                CreateDirectory()
                Dim dbFileName As String = GetDbFileName()
                Using conn = New SqliteConnection("Data Source=" & dbFileName)
                    conn.Open()
                End Using

                Return New DbDocumentStorage("XpoProvider=SQLite;Data Source=" & dbFileName & ";Version=3;")
            End Function

            Public Sub Clear()
                Call SqliteConnection.ClearAllPools()
                If Directory.Exists(path) Then ClearFiles(path)
            End Sub

            Private Shared Sub ClearFiles(ByVal path As String)
                For Each file As String In Directory.GetFiles(path, dbFileName & "*")
                    Try
                        IO.File.Delete(file)
                    Catch
                    End Try
                Next
            End Sub

            Private Function GetDbFileName() As String
                Dim dbFile As String
                Dim i As Integer = 0
                Do
                    dbFile = IO.Path.Combine(path, dbFileName & Math.Min(Threading.Interlocked.Increment(i), i - 1) & dbFileExtension)
                Loop While File.Exists(dbFile)

                Return dbFile
            End Function

            Private Sub CreateDirectory()
                If Not Directory.Exists(path) Then Directory.CreateDirectory(path)
            End Sub

            Private Sub Dispose() Implements IDisposable.Dispose
                Clear()
            End Sub
        End Class

#End Region
        Private source As CachedReportSource

        Private ReadOnly Property FolderPath As String
            Get
                Return Path.Combine(DevExpress.Data.Utils.SafeEnvironment.LocalApplicationData, "DevExpress\ReportCache")
            End Get
        End Property

        Protected Overrides Function CreateReport() As XtraReport
            Dim storage As DocumentStorage = New StorageHelper(FolderPath).CreateStorage()
            Dim _report As XtraReport = New CachedDocumentSourceReport.Report()
            source = New CachedReportSource(_report, storage)
            Return _report
        End Function

        Protected Overrides ReadOnly Property DocumentSource As Object
            Get
                Return source
            End Get
        End Property

        Protected Overrides Function StopWorkingAsync() As Task
            If source IsNot Nothing Then Return source.CompleteWorkingAsync(True)
            Return Task.FromResult(Of Object)(Nothing)
        End Function

        Protected Overrides Sub DisposeReport()
            If source IsNot Nothing Then
                source.Dispose()
                source = Nothing
            End If

            Call New StorageHelper(FolderPath).Clear()
            MyBase.DisposeReport()
        End Sub
    End Class
End Namespace
