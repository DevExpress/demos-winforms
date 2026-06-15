namespace DevExpress.DevAV {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos;
    using DevExpress.Internal;
    using DevExpress.Utils.Taskbar;
#if NET
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
#endif

    static class Program {
        const string AppName = "DevExpressWinOutlookInspiredApp";
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            
            TaskbarAssistant.Default.Initialize();
            DevAVDataDirectoryHelper.LocalPrefix = "WinOutlookInspiredApp";
            
            bool exit;
            using(DevAVDataDirectoryHelper.SingleInstanceApplicationGuard(AppName, out exit)) {
                if(exit)
                    return;
                
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
                DevExpress.XtraEditors.WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.True;
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.WXI);
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultRibbonStyle = XtraEditors.DefaultRibbonControlStyle.Office365;
                DevExpress.XtraEditors.WindowsFormsSettings.FindPanelBehavior = XtraEditors.FindPanelBehavior.Search;
                DevExpress.XtraEditors.WindowsFormsSettings.FilterCriteriaDisplayStyle = XtraEditors.FilterCriteriaDisplayStyle.Visual;
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", AppHelper.GetDefaultSize());
                
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                DevExpress.XtraEditors.WindowsFormsSettings.CustomizationFormSnapMode = Utils.Controls.SnapMode.OwnerControl;
                DevExpress.XtraEditors.WindowsFormsSettings.ColumnFilterPopupMode = XtraEditors.ColumnFilterPopupMode.Excel;
                DevExpress.XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = Utils.DefaultBoolean.True;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
#if NET
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
#endif
                MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
                if(!MainFormHelper.TakeScreens) {
                    using(new StartUpProcess()) {
                        using(StartUpProcess.Status.Subscribe(new DemoStartUp())) {
                            Application.Run(new MainForm());
                        }
                    }
                }
                else Application.Run(new MainForm());
            }
        }
        
#if NET
        
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
#endif
    }
}
