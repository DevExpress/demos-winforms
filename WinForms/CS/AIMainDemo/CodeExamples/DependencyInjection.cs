#pragma warning disable CRR0033, CRR0029
namespace DevExpress.AI.Demos {
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using Azure.AI.OpenAI;
    using DevExpress.AI.Demos.Helpers;
    using DevExpress.AIIntegration;
    using DevExpress.AIIntegration.Extensions;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.XtraEditors;
    using DevExpress.XtraLayout;
    using DevExpress.XtraLayout.Utils;
    using Microsoft.Extensions.AI;
    using Microsoft.Extensions.DependencyInjection;

    [CodeExampleClass("Dependency Injection", "DependencyInjection.cs")]
    public static class DependencyInjection {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            var tableGroup = layoutControl.Root.AddGroup("");
            tableGroup.OptionsTableLayoutItem.ColumnSpan = 3;
            tableGroup.OptionsTableLayoutItem.RowSpan = 3;

            var button = new SimpleButton() { Text = "Click me" };
            LayoutControlItem item1 = tableGroup.AddItem("Button", button);
            item1.OptionsTableLayoutItem.RowIndex = 2;
            item1.OptionsTableLayoutItem.ColumnIndex = 2;

            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl, button };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("DI extensions (Settings)", new Type[] { typeof(MarkTwainStyleExtension) })]
        [CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle", "ProofreadRequest")]
        [CodeExampleUnderlineTokens("AddDevExpressAIConsole", "RegisterChatClient", "Register", "RegisterAIExceptionHandler", "BuildServiceProvider", "GetService")]
        public static void InvokeWithSettings(LayoutControl layoutControl, SimpleButton button) {
            string AzureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";
            string AzureOpenAIKey = "DEMO";
            string DeploymentName = "demo-mini";
            IChatClient azureOpenAIClient = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                                new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)).GetChatClient(DeploymentName).AsIChatClient();
            // Configure the service provider (this should usually be done at application startup)
            var serviceProvider = new ServiceCollection()
                .AddDevExpressAIConsole(settings => {
                    // 1) You can register IChatClient here
                    settings.RegisterChatClient(azureOpenAIClient);
                    // 2) You can register your own extensions here
                    settings.Register<ProofreadRequest, MarkTwainStyleExtension>();
                    // 3) You can register your own handlers and customization interceptors here
                    settings.RegisterAIExceptionHandler(new AIExceptionHandler());
                    // settings.RegisterAIChatClientCustomizeMessageRequest(...)
                })
                .BuildServiceProvider();
            // Usage (we use desktop controls here for demonstration purposes)
            button.Click += async (s, e) => {
                var aiContainer = serviceProvider.GetService<IAIExtensionsContainer>();
                // have fun
                var request = new ChangeStyleRequest("Have fun experimenting with this code", WritingStyle.Academic);
                var response = await aiContainer.ChangeStyleAsync(request, CancellationToken.None);
                await XtraMessageBox.ShowAsync(response.Response);
            };
        }

        [CodeExampleCase("DI extensions (Services)", new Type[] { typeof(MarkTwainStyleExtension) })]
        [CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle", "ProofreadRequest", "IAIExtension <ProofreadRequest, TextResponse>")]
        [CodeExampleUnderlineTokens("AddDevExpressAIConsole", "AddSingleton", "AddTransient", "BuildServiceProvider", "GetService")]
        public static void InvokeWithServices(LayoutControl layoutControl, SimpleButton button) {
            string AzureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";
            string AzureOpenAIKey = "DEMO";
            string DeploymentName = "demo-mini";
            IChatClient azureOpenAIClient = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                                new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)).GetChatClient(DeploymentName).AsIChatClient();
            // Configure the service provider (this should usually be done at application startup)
            var serviceProvider = new ServiceCollection()
                // 1) You can register IChatClient here
                .AddSingleton<IChatClient>(azureOpenAIClient)
                // 2) You can register your own extensions here
                .AddTransient<IAIExtension<ProofreadRequest, TextResponse>, MarkTwainStyleExtension>()
                // 3) You can register your own handlers and customization interceptors here
                .AddScoped<IAIExceptionHandler, AIExceptionHandler>()
                .AddDevExpressAIConsole()
                .BuildServiceProvider();
            // Usage (we use desktop controls here for demonstration purposes)
            button.Click += async (s, e) => {
                var aiContainer = serviceProvider.GetService<IAIExtensionsContainer>();
                // have fun
                var request = new ChangeStyleRequest("Have fun experimenting with this code", WritingStyle.Academic);
                var response = await aiContainer.ChangeStyleAsync(request, CancellationToken.None);
                await XtraMessageBox.ShowAsync(response.Response);
            };
        }

        [CodeExampleNestedClass]
        public class MarkTwainStyleExtension : ProofreadExtension {
            public MarkTwainStyleExtension(IServiceProvider serviceProvider)
                : base(serviceProvider) { }
            protected override string GetSystemPrompt(ProofreadRequest request) {
                return "Rewrite this text in the Mark Twain style.";
            }
        }
    }
}
#pragma warning restore CRR0033, CRR0029
