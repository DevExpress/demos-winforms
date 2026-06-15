Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils.Taskbar

Namespace DevExpress.DevAV

#If NET
    using Microsoft.Extensions.AI;
    using Azure.AI.OpenAI;
    using DevExpress.AIIntegration;
    using System.ClientModel.Primitives;
    using System.Net.Http;
    using DevExpress.Data.Utils;
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.XtraEditors;
    using Microsoft.Extensions.DependencyInjection;
    using DevExpress.AIIntegration.Chat;
#End If
    Friend Module Program

        Const AppName As String = "DevExpressWinOutlookInspiredApp"

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            Call ExternalAssemblies.ResolveFromSpecificFolderIfRequired()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            Call TaskbarAssistant.Default.Initialize()
            DevAVDataDirectoryHelper.LocalPrefix = "WinOutlookInspiredApp"
            Dim [exit] As Boolean
            Using DevAVDataDirectoryHelper.SingleInstanceApplicationGuard(AppName, [exit])
                If [exit] Then Return
                XtraEditors.WindowsFormsSettings.EnableFormSkins()
                XtraEditors.WindowsFormsSettings.ForceDirectXPaint()
                XtraEditors.WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.True
                XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.WXI)
                XtraEditors.WindowsFormsSettings.DefaultRibbonStyle = XtraEditors.DefaultRibbonControlStyle.Office365
                XtraEditors.WindowsFormsSettings.FindPanelBehavior = XtraEditors.FindPanelBehavior.Search
                XtraEditors.WindowsFormsSettings.FilterCriteriaDisplayStyle = XtraEditors.FilterCriteriaDisplayStyle.Visual
                XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True
                Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", GetDefaultSize())
                XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch
                XtraEditors.WindowsFormsSettings.CustomizationFormSnapMode = Utils.Controls.SnapMode.OwnerControl
                XtraEditors.WindowsFormsSettings.ColumnFilterPopupMode = XtraEditors.ColumnFilterPopupMode.Excel
                XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = Utils.DefaultBoolean.True
                Call Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
#If NET
                AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(AzureOpenAIEndpoint, AzureOpenAIKey, new AzureOpenAIClientOptions() {
                    Transport = new PromoteHttpStatusErrorsPipelineTransport()
                });
                var chatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient();
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddSingleton(chatClient);
                
                
                var toolsChatClientBuilder = chatClient
                        .AsBuilder()
                        .UseDXTools()
                        .UseFunctionInvocation(configure: (f) => { f.IncludeDetailedErrors = true; });

                serviceCollection.AddKeyedScoped<IChatResponseProvider>(MainForm.ToolsChatResponseProviderServiceKey, (sp, _) => {
                    return toolsChatClientBuilder
                        .Build(sp)
                        .AsIChatResponseProvider();
                });

                serviceCollection.AddDevExpressAIDesktop(x => {
                    x.RegisterAIExceptionHandler(new AIExceptionHandler());
                });
#End If
                Call MainFormHelper.InitTakeScreen(Data.Utils.SafeEnvironment.GetCommandLineArgs())
                If Not MainFormHelper.TakeScreens Then
                    Using New StartUpProcess()
                        Using StartUpProcess.Status.Subscribe(New DemoStartUp())
                            Call Application.Run(New MainForm())
                        End Using
                    End Using
                Else
                    Call Application.Run(New MainForm())
                End If
            End Using
        End Sub
#If NET
        
        class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
            protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
                if(!httpResponse.IsSuccessStatusCode) {
                    if((int)httpResponse.StatusCode == 429)
                        throw new AIDemoException("You have reached demo request limit. Further requests are temporarily suspended. Please try again in a few minutes. Thank you for your patience and understanding.");
                    throw new HttpRequestException("HTTP request failed with status code: " + httpResponse.StatusCode);
                }
                base.OnReceivedResponse(message, httpResponse);
            }
        }
        
        static Uri AzureOpenAIEndpoint {
            get {
                string azureOpenAIEndpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIEndpoint))
                    azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";
                return new Uri(azureOpenAIEndpoint);
            }
        }
        static System.ClientModel.ApiKeyCredential AzureOpenAIKey {
            get {
                string azureOpenAIKey = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIKey))
                    azureOpenAIKey = "DEMO";
                return new System.ClientModel.ApiKeyCredential(azureOpenAIKey);
            }
        }
        static bool IsDeveloperMode {
            get { return string.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase); }
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
#End If
    End Module
End Namespace
