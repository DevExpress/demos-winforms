using System;
using System.ClientModel.Primitives;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;

namespace XtraReportsDemos.AIOperations {
    class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
        protected override PipelineMessage CreateMessageCore() {
            var message = base.CreateMessageCore();
            return new DemoPipelineMessage(message.Request);
        }
        protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
            if(!httpResponse.IsSuccessStatusCode) {
                if((int)httpResponse.StatusCode == 429) {
                    string seconds = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault();
                    string text = $"You have reached the demo request limit. Your request will be retried automatically in {seconds} seconds. Thank you for your patience and understanding.";

                    Form.ActiveForm?.Invoke(new Action(() => {
                        var result = XtraMessageBox.Show(Form.ActiveForm, text, "AI Service Request Limit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if(result == DialogResult.Cancel)
                            (message as DemoPipelineMessage)?.Cancel();
                    }));
                }
                else {
                    throw new HttpRequestException("HTTP request failed with status code: " + httpResponse.StatusCode);
                }
            }
            base.OnReceivedResponse(message, httpResponse);
        }

        class DemoPipelineMessage : PipelineMessage {
            readonly CancellationTokenSource cts = new CancellationTokenSource();
            public DemoPipelineMessage(PipelineRequest request) : base(request) {
                CancellationToken = cts.Token;
            }
            public void Cancel() => cts.Cancel();
        }
    }
}
