Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports Azure.AI.OpenAI
Imports DevExpress.AI.Demos.Helpers
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.Extensions
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils
Imports Microsoft.Extensions.AI
Imports Microsoft.Extensions.DependencyInjection

Namespace DevExpress.AI.Demos

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Dependency Injection", "DependencyInjection.cs")>
    Public Module DependencyInjection

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Dim tableGroup = layoutControl.Root.AddGroup("")
            tableGroup.OptionsTableLayoutItem.ColumnSpan = 3
            tableGroup.OptionsTableLayoutItem.RowSpan = 3
            Dim button = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Click me"}
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = tableGroup.AddItem("Button", button)
            item1.OptionsTableLayoutItem.RowIndex = 2
            item1.OptionsTableLayoutItem.ColumnIndex = 2
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl, button}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("DI extensions (Settings)", New System.Type() {GetType(DevExpress.AI.Demos.DependencyInjection.MarkTwainStyleExtension)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle", "ProofreadRequest")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddDevExpressAIConsole", "RegisterChatClient", "Register", "RegisterAIExceptionHandler", "BuildServiceProvider", "GetService")>
        Public Sub InvokeWithSettings(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl, ByVal button As DevExpress.XtraEditors.SimpleButton)
            Dim AzureOpenAIEndpoint As String = "https://public-api.devexpress.com/demo-openai"
            Dim AzureOpenAIKey As String = "DEMO"
            Dim DeploymentName As String = "demo-mini"
            Dim azureOpenAIClient As Microsoft.Extensions.AI.IChatClient = New Azure.AI.OpenAI.AzureOpenAIClient(CType((New System.Uri(CStr((AzureOpenAIEndpoint)))), System.Uri), CType((New System.ClientModel.ApiKeyCredential(CStr((AzureOpenAIKey)))), System.ClientModel.ApiKeyCredential)).GetChatClient(CStr((DeploymentName))).AsIChatClient()
            ' Configure the service provider (this should usually be done at application startup)
            Dim serviceProvider = DevExpress.AIIntegration.AIExtensionsContainerConsole.AddDevExpressAIConsole(New Microsoft.Extensions.DependencyInjection.ServiceCollection(), CType((Sub(settings)
                ' 1) You can register IChatClient here
                settings.RegisterChatClient(CType((azureOpenAIClient), Microsoft.Extensions.AI.IChatClient))
                ' 2) You can register your own extensions here
                settings.Register(Of DevExpress.AIIntegration.Extensions.ProofreadRequest, DevExpress.AI.Demos.DependencyInjection.MarkTwainStyleExtension)()
                ' 3) You can register your own handlers and customization interceptors here
                settings.RegisterAIExceptionHandler(CType((New DevExpress.AI.Demos.Helpers.AIExceptionHandler()), DevExpress.AIIntegration.IAIExceptionHandler))
            ' settings.RegisterAIChatClientCustomizeMessageRequest(...)
            End Sub), System.Action(Of DevExpress.AIIntegration.AIExtensionsContainerConsole.Settings))).BuildServiceProvider()
            ' Usage (we use desktop controls here for demonstration purposes)
            AddHandler button.Click, Async Sub(s, e)
                Dim aiContainer = serviceProvider.GetService(Of DevExpress.AIIntegration.IAIExtensionsContainer)()
                ' have fun
                Dim request = New DevExpress.AIIntegration.Extensions.ChangeStyleRequest("Have fun experimenting with this code", DevExpress.AIIntegration.Extensions.WritingStyle.Academic)
                Dim response = Await aiContainer.ChangeStyleAsync(request, System.Threading.CancellationToken.None)
                Await DevExpress.XtraEditors.XtraMessageBox.ShowAsync(response.Response)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("DI extensions (Services)", New System.Type() {GetType(DevExpress.AI.Demos.DependencyInjection.MarkTwainStyleExtension)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ChangeStyleExtension", "ChangeStyleRequest", "WritingStyle", "ProofreadRequest", "IAIExtension <ProofreadRequest, TextResponse>")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddDevExpressAIConsole", "AddSingleton", "AddTransient", "BuildServiceProvider", "GetService")>
        Public Sub InvokeWithServices(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl, ByVal button As DevExpress.XtraEditors.SimpleButton)
            Dim AzureOpenAIEndpoint As String = "https://public-api.devexpress.com/demo-openai"
            Dim AzureOpenAIKey As String = "DEMO"
            Dim DeploymentName As String = "demo-mini"
            Dim azureOpenAIClient As Microsoft.Extensions.AI.IChatClient = New Azure.AI.OpenAI.AzureOpenAIClient(CType((New System.Uri(CStr((AzureOpenAIEndpoint)))), System.Uri), CType((New System.ClientModel.ApiKeyCredential(CStr((AzureOpenAIKey)))), System.ClientModel.ApiKeyCredential)).GetChatClient(CStr((DeploymentName))).AsIChatClient()
            ' Configure the service provider (this should usually be done at application startup)
            ' 3) You can register your own handlers and customization interceptors here
            ' 2) You can register your own extensions here
            ' 1) You can register IChatClient here
            Dim serviceProvider = DevExpress.AIIntegration.AIExtensionsContainerConsole.AddDevExpressAIConsole(Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddScoped(Of DevExpress.AIIntegration.IAIExceptionHandler, DevExpress.AI.Demos.Helpers.AIExceptionHandler)(Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddTransient(Of DevExpress.AIIntegration.IAIExtension(Of DevExpress.AIIntegration.Extensions.ProofreadRequest, DevExpress.AIIntegration.Extensions.TextResponse), DevExpress.AI.Demos.DependencyInjection.MarkTwainStyleExtension)(Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(Of Microsoft.Extensions.AI.IChatClient)(New Microsoft.Extensions.DependencyInjection.ServiceCollection(), CType((azureOpenAIClient), Microsoft.Extensions.AI.IChatClient))))).BuildServiceProvider()
            ' Usage (we use desktop controls here for demonstration purposes)
            AddHandler button.Click, Async Sub(s, e)
                Dim aiContainer = serviceProvider.GetService(Of DevExpress.AIIntegration.IAIExtensionsContainer)()
                ' have fun
                Dim request = New DevExpress.AIIntegration.Extensions.ChangeStyleRequest("Have fun experimenting with this code", DevExpress.AIIntegration.Extensions.WritingStyle.Academic)
                Dim response = Await aiContainer.ChangeStyleAsync(request, System.Threading.CancellationToken.None)
                Await DevExpress.XtraEditors.XtraMessageBox.ShowAsync(response.Response)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class MarkTwainStyleExtension
            Inherits DevExpress.AIIntegration.Extensions.ProofreadExtension

            Public Sub New(ByVal serviceProvider As System.IServiceProvider)
                MyBase.New(serviceProvider)
            End Sub

            Protected Overrides Function GetSystemPrompt(ByVal request As DevExpress.AIIntegration.Extensions.ProofreadRequest) As String
                Return "Rewrite this text in the Mark Twain style."
            End Function
        End Class
    End Module
End Namespace
