Imports System
Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports Microsoft.Extensions.AI

Namespace XtraReportsDemos.AIOperations

    Public Module AIServicesRegistration

        Private isRegistered As Boolean

        Public Sub RegisterIfNeeded()
            If isRegistered Then Return
            isRegistered = True
            Dim azureOpenAIEndpoint = New Uri("https://api.devexpress.com/demo-openai") 'DevExpress proxy-server
            Dim azureOpenAIKey = New ClientModel.ApiKeyCredential("DEMO") 'Demo key
            Dim azureOpenAIClient As AzureOpenAIClient = New AzureOpenAIClient(azureOpenAIEndpoint, azureOpenAIKey, New AzureOpenAIClientOptions() With {.Transport = New PromoteHttpStatusErrorsPipelineTransport()})
            Dim chatClient As IChatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient()
            Dim container = AIExtensionsContainerDesktop.Default
            container.RegisterChatClient(chatClient)
            container.RegisterAIExceptionHandler(New AIExceptionHandler())
        End Sub
    End Module
End Namespace
