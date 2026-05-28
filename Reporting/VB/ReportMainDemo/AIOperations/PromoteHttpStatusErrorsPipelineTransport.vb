Imports System
Imports System.ClientModel.Primitives
Imports System.Linq
Imports System.Net.Http
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace XtraReportsDemos.AIOperations

    Friend Class PromoteHttpStatusErrorsPipelineTransport
        Inherits HttpClientPipelineTransport

        Protected Overrides Function CreateMessageCore() As PipelineMessage
            Dim message = MyBase.CreateMessageCore()
            Return New DemoPipelineMessage(message.Request)
        End Function

        Protected Overrides Sub OnReceivedResponse(ByVal message As PipelineMessage, ByVal httpResponse As HttpResponseMessage)
            If Not httpResponse.IsSuccessStatusCode Then
                If CInt(httpResponse.StatusCode) = 429 Then
                    Dim seconds As String = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault()
                    Dim text As String = $"You have reached the demo request limit. Your request will be retried automatically in {seconds} seconds. Thank you for your patience and understanding."
                    Form.ActiveForm?.Invoke(New Action(Sub()
                        Dim result = XtraMessageBox.Show(Form.ActiveForm, text, "AI Service Request Limit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                        If result = DialogResult.Cancel Then TryCast(message, DemoPipelineMessage)?.Cancel()
                    End Sub))
                Else
                    Throw New HttpRequestException("HTTP request failed with status code: " & httpResponse.StatusCode)
                End If
            End If

            MyBase.OnReceivedResponse(message, httpResponse)
        End Sub

        Private Class DemoPipelineMessage
            Inherits PipelineMessage

            Private ReadOnly cts As CancellationTokenSource = New CancellationTokenSource()

            Public Sub New(ByVal request As PipelineRequest)
                MyBase.New(request)
                CancellationToken = cts.Token
            End Sub

            Public Sub Cancel()
                cts.Cancel()
            End Sub
        End Class
    End Class
End Namespace
