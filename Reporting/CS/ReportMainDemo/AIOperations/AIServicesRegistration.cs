using System;
using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using Microsoft.Extensions.AI;

namespace XtraReportsDemos.AIOperations {
    public static class AIServicesRegistration {
        static bool isRegistered;
        public static void RegisterIfNeeded() {
            if (isRegistered)
                return;
            isRegistered = true;
            var azureOpenAIEndpoint = new Uri("https://api.devexpress.com/demo-openai"); //DevExpress proxy-server
            var azureOpenAIKey = new System.ClientModel.ApiKeyCredential("DEMO"); //Demo key
            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureOpenAIEndpoint, azureOpenAIKey, new AzureOpenAIClientOptions() {
                Transport = new PromoteHttpStatusErrorsPipelineTransport()
            });
            IChatClient chatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient();
            var container = AIExtensionsContainerDesktop.Default;
            container.RegisterChatClient(chatClient);
            container.RegisterAIExceptionHandler(new AIExceptionHandler());
        }
    }
}
