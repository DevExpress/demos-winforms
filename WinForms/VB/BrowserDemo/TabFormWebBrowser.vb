Imports System
Imports System.Drawing
Imports System.IO
Imports System.Runtime.ExceptionServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Public Class TabFormWebBrowser
        Inherits WebBrowser

        Private pageCore As TabFormPage

        Public Sub New(ByVal page As TabFormPage)
            MyBase.New()
            pageCore = page
        End Sub

        Public ReadOnly Property Page As TabFormPage
            Get
                Return pageCore
            End Get
        End Property

        Protected Overrides Sub OnDocumentCompleted(ByVal e As WebBrowserDocumentCompletedEventArgs)
            MyBase.OnDocumentCompleted(e)
            OnDocumentCompletedCore(e)
        End Sub

        Protected Async Sub OnDocumentCompletedCore(ByVal e As WebBrowserDocumentCompletedEventArgs)
            If Page Is Nothing OrElse e.Url Is Nothing OrElse String.IsNullOrEmpty(e.Url.Host) OrElse Url Is Nothing OrElse Not Equals(Url.Host, e.Url.Host) Then Return
            Try
                Dim favicon = Await TabFormWebBrowser.Favicon.QueryAsync(e.Url)
                If favicon IsNot Nothing AndAlso Not favicon.Failed Then Page.Image = favicon.Image
            Catch
            End Try
        End Sub

        Protected Overrides Sub OnDocumentTitleChanged(ByVal e As EventArgs)
            MyBase.OnDocumentTitleChanged(e)
            OnDocumentTitleChangedCore()
        End Sub

        Protected Sub OnDocumentTitleChangedCore()
            If Page Is Nothing OrElse String.IsNullOrEmpty(DocumentTitle) Then Return
            Page.Text = DocumentTitle
        End Sub

        '
        Private NotInheritable Class Favicon

            Private _Image As Image

            Public Shared Async Function QueryAsync(ByVal uri As Uri) As Task(Of Favicon)
                Dim iconURL As String = "http://" & uri.Host & "/favicon.ico"
                Return Await Data.Utils.AsyncDownloader(Of Favicon).LoadAsync(iconURL, Function(exception, stream) New Favicon(exception, stream), CancellationToken.None).ConfigureAwait(False)
            End Function

            '
            Private ReadOnly exception As Exception

            Private Sub New(ByVal exceptionInfo As ExceptionDispatchInfo, ByVal stream As Stream)
                exception = exceptionInfo?.SourceException
                If exception Is Nothing AndAlso stream IsNot Nothing Then
                    Try
                        Image = Image.FromStream(stream)
                    Catch e As Exception
                        exception = e
                    End Try
                End If
            End Sub

            Public ReadOnly Property Failed As Boolean
                Get
                    Return exception IsNot Nothing OrElse Image Is Nothing
                End Get
            End Property

            Public Property Image As Image
                Get
                    Return _Image
                End Get

                Private Set(ByVal value As Image)
                    _Image = value
                End Set
            End Property
        End Class
    End Class
End Namespace
