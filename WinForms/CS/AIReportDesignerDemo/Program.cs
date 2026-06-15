using System;
using System.ClientModel.Primitives;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Internal;
using DevExpress.Data.Utils;
using DevExpress.Internal;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.ReportDesigner.Demo {
    static class Program {
        static Program() {
            // Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            // This code loads these DLLs into the current AppDomain
            AppDomain.CurrentDomain.AssemblyResolve += (s, e) => OnAssemblyResolve(e);
        }

        static System.Reflection.Assembly OnAssemblyResolve(ResolveEventArgs e) {
            return DXperience.Demos.DemoHelper.DemoAssemblyResolve(e, typeof(Program).Assembly);
        }

        [STAThread]
        static void Main() {
            bool enablePMv2 = false;
#if DEBUG
            enablePMv2 = true;
#endif
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1 && enablePMv2)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            string path = DevAVDataDirectoryHelper.GetFile("NWind.db");
            string directory = Path.GetDirectoryName(path);
            ConnectionHelper.SetDataDirectory(directory);
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.ConvertBindingsToExpressions = DevExpress.XtraReports.UI.PromptBoolean.False;

            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(AzureOpenAIEndpointUri, AzureOpenAIKeyCredentials, new AzureOpenAIClientOptions() {
                Transport = new PromoteHttpStatusErrorsPipelineTransport()
            });
            IChatClient chatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient();
            //
            var container = AIExtensionsContainerDesktop.Default;
            container.RegisterChatClient(chatClient);

            container.RegisterAIExceptionHandler(new Helpers.AIExceptionHandler());

            //var builder = Kernel.CreateBuilder();
            //builder.AddAzureOpenAIChatCompletion("demo",
            //    AzureOpenAIEndpoint,
            //    AzureOpenAIKey);
            //((IAIServiceContainer)container).RegisterService<Kernel>(builder.Build());

            Application.Run(new ReportDesignerForm());
        }
        //
        static string AzureOpenAIEndpoint {
            get {
                string azureOpenAIEndpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIEndpoint))
                    azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";//DevExpress proxy-server
                return azureOpenAIEndpoint;
            }
        }
        static Uri AzureOpenAIEndpointUri {
            get {

                return new Uri(AzureOpenAIEndpoint);
            }
        }
        static string AzureOpenAIKey {
            get {
                string azureOpenAIKey = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIKey))
                    azureOpenAIKey = "DEMO";//Demo key
                return azureOpenAIKey;
            }
        }
        static System.ClientModel.ApiKeyCredential AzureOpenAIKeyCredentials {
            get { return new System.ClientModel.ApiKeyCredential(AzureOpenAIKey); }
        }
        static bool IsDeveloperMode {
            get {
                return string.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase);
            }
        }
        static string GetEnvironmentVariable(string variableName, bool allowSetNewEnvironmentVariable = false) {
            string environmentVariable = SafeEnvironment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User);
            if(string.IsNullOrEmpty(environmentVariable) && allowSetNewEnvironmentVariable) {
                environmentVariable = XtraInputBox.Show($"Please enter {variableName} variable.", variableName, string.Empty);
                if(string.IsNullOrEmpty(environmentVariable))
                    Application.Exit();
                SafeEnvironment.SetEnvironmentVariable(variableName, environmentVariable, EnvironmentVariableTarget.User);
            }
            return environmentVariable;
        }

        #region inner classes
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
        #endregion
    }
}
