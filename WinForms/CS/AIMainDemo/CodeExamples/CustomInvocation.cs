#pragma warning disable CRR0033, CRR0029
namespace DevExpress.AI.Demos {
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using Azure.AI.OpenAI;
    using DevExpress.AIIntegration;
    using DevExpress.AIIntegration.Extensions;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.XtraEditors;
    using DevExpress.XtraLayout;
    using DevExpress.XtraLayout.Utils;
    using Microsoft.Extensions.AI;

    [CodeExampleClass("Custom Invocations", "CustomInvocation.cs")]
    public static class CustomInvocation {
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
        [CodeExampleCase("Invoke extension")]
        [CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle")]
        [CodeExampleUnderlineTokens("ChangeStyleAsync")]
        public static void Invoke(LayoutControl layoutControl, SimpleButton button) {
            // setup container
            AIExtensionsContainerDefault defaultAIContainer = new AIExtensionsContainerDefault();
            string AzureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai";
            string AzureOpenAIKey = "DEMO";
            string DeploymentName = "gpt-4o-mini";
            IChatClient azureOpenAIClient = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                                new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)).GetChatClient(DeploymentName).AsIChatClient();
            defaultAIContainer.RegisterChatClient(azureOpenAIClient);
            // register extensions
            defaultAIContainer.Register<ChangeStyleExtension>(typeof(ChangeStyleRequest));
            button.Click += async (s, e) => {
                // have fun
                var request = new ChangeStyleRequest("Have fun experimenting with this code", WritingStyle.Academic);
                var response = await defaultAIContainer.ChangeStyleAsync(request, CancellationToken.None);
                await XtraMessageBox.ShowAsync(response.Response);
            };
        }

        [CodeExampleCase("Custom processing")]
        [CodeExampleHighlightTokens("TranslateExtension", "TranslateRequest", "ResponseStatus")]
        [CodeExampleUnderlineTokens("TranslateAsync", "ContinueAsync")]
        public static void InvokeWithProcessing(LayoutControl layoutControl, SimpleButton button) {
            // setup container
            AIExtensionsContainerDefault defaultAIContainer = new AIExtensionsContainerDefault();
            string AzureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai";
            string AzureOpenAIKey = "DEMO";
            string DeploymentName = "gpt-4o-mini";
            IChatClient azureOpenAIClient = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                                new System.ClientModel.ApiKeyCredential(AzureOpenAIKey))
                .GetChatClient(DeploymentName)
                .AsIChatClient();
            defaultAIContainer.RegisterChatClient(azureOpenAIClient);
            // register extensions
            defaultAIContainer.Register<TranslateExtension>(typeof(TranslateRequest));
            button.Click += async (s, e) => {
                // have fun
                var request = new TranslateRequest("Have fun experimenting with this code", "Elvish");
                var response = await defaultAIContainer.TranslateAsync(request, CancellationToken.None);
                string translatedText = response.Response;
                if(response.IsCompleted) {
                    // OK
                }
                else if(!response.IsRestrictedOrFailed) {
                    while(response.IsContinuationRequired) {
                        await response.ContinueAsync();
                        translatedText += response.Response;
                    }
                }
                else { // Something unexpected happens
                    switch(response.Status) {
                        case ResponseStatus.MaxTokenLimitExceeded:
                        case ResponseStatus.InputSizeLimitExceeded:
                            translatedText = "The text you're trying to send within a request is too long and exceeds the limit.";
                            break;
                        case ResponseStatus.ContentFiltered:
                            translatedText = "Potentially harmful content was detected in your request.";
                            break;
                        case ResponseStatus.Error:
                            translatedText = "An error occurred while processing the request.";
                            break;
                    }
                }
                await XtraMessageBox.ShowAsync(translatedText);
            };
        }
    }
}
#pragma warning restore CRR0033, CRR0029
