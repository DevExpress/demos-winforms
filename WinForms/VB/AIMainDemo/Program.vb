Imports System
Imports System.ClientModel.Primitives
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net.Http
Imports System.Threading
Imports System.Windows.Forms
Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Data.Utils
Imports DevExpress.XtraEditors
Imports Microsoft.Extensions.AI
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.SemanticKernel.Connectors.InMemory

#If NET
using OpenAI.Responses;
using DevExpress.AI.Demos.Agents;
using DevExpress.AI.Demos.Agents.WorkflowInfra;
using DevExpress.AI.Demos.Agents.Weather;
using DevExpress.AI.Demos.Services;
using DevExpress.AIIntegration.Agents;
using DevExpress.AIIntegration.Chat;
using DevExpress.AI.Demos.AITools;
#End If
Namespace DevExpress.AI.Demos

    Friend Module Program

        Sub New()
            ' Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            ' This code loads these DLLs into the current AppDomain
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, Function(s, e) OnAssemblyResolve(e)
        End Sub

        Private Function OnAssemblyResolve(ByVal e As ResolveEventArgs) As System.Reflection.Assembly
            Return DXperience.Demos.DemoHelper.DemoAssemblyResolve(e, GetType(Program).Assembly)
        End Function

        'WA for https://github.com/Azure/azure-sdk-for-net/issues/45618
        Private Class PromoteHttpStatusErrorsPipelineTransport
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

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                Call WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim azureOpenAIClient As AzureOpenAIClient = New AzureOpenAIClient(AzureOpenAIEndpoint, AzureOpenAIKey, New AzureOpenAIClientOptions() With {.Transport = New PromoteHttpStatusErrorsPipelineTransport()})
            Dim chatClient = azureOpenAIClient.GetChatClient("gpt-4.1").AsIChatClient()
            Dim embeddingGenerator = azureOpenAIClient.GetEmbeddingClient("text-embedding-3-small").AsIEmbeddingGenerator()
            ' 
            ' For demonstration purposes, we're using a simple InMemoryCollection to store vectors in memory,
            ' with a CachingEmbeddingGenerator to load pre-calculated vectors into the vector collection
            ' during the SemanticSearch module initialization.
            ' In real-world applications, it's recommended to use a production-grade vector store.
            ' You can find the list of supported vector store connectors here:
            ' https://learn.microsoft.com/en-us/semantic-kernel/concepts/vector-store-connectors/out-of-the-box-connectors/?pivots=programming-language-csharp
            ' 
            Dim cachingEmbeddingGenerator = New Modules.SemanticSearch.CachingEmbeddingGenerator(embeddingGenerator)
            Dim collection = New InMemoryCollection(Of String, SemanticSearchModule.VectorStoreRecord)(SemanticSearchModule.VectorCollectionName, New InMemoryCollectionOptions With {.EmbeddingGenerator = cachingEmbeddingGenerator})
            Dim serviceCollection = New ServiceCollection()
#If NET
            // To avoid unintended coupling between DevExpress AI-powered Extensions and the tool-calling pipeline,
            // use separate IChatClient instances (one for AI-powered Extensions and one for the AI Chat Control with AITools).
            var toolsChatClientBuilder = chatClient
                        .AsBuilder()
                        .UseDXTools()
                        .UseFunctionInvocation(configure: (f) => { f.IncludeDetailedErrors = true; });

            serviceCollection.AddKeyedScoped<IChatResponseProvider>(RuntimeToolsAIModule.ToolsChatResponseProviderServiceKey, (sp, _) => {
                return toolsChatClientBuilder
                    .Build(sp)
                    .AsIChatResponseProvider();
            });

            // Agentic AI: build a function-invocation-enabled IChatClient for agent workflows
            var agentChatClient = chatClient
                        .AsBuilder()
                        .UseFunctionInvocation()
                        .Build();
            var agentFactory = new AgentFactory(agentChatClient);

            // Shakespearean Poet workflow (non-streaming, buffered)
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(WorkflowAsAgentModule.ServiceKey, (sp, _) => {
                return agentFactory.CreateShakespeareanPoetAgenticWorkflow();
            });

            // Shakespearean Poet workflow (streaming with workflow events)
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(WorkflowResponseStreamingModule.ServiceKey, (sp, _) => {
                return new WorkflowResponseProvider<string>(agentFactory.CreateShakespeareanPoetWorkflow(), GetLastUserText);
            });

            // Text Processing pipeline: Uppercase → Reverse (streaming)
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(WorkflowWithExecutorsModule.ServiceKey, (sp, _) => {
                return new WorkflowResponseProvider<string>(AgentFactory.CreateTextProcessingWorkflow(), GetLastUserText);
            });

            // Azure OpenAI Responses API with reasoning options
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(ReasoningModule.ServiceKey, (sp, _) => {
                var baseOptions = new CreateResponseOptions {
                    ReasoningOptions = new ResponseReasoningOptions() {
                        ReasoningEffortLevel = ResponseReasoningEffortLevel.Medium,
                        ReasoningSummaryVerbosity = ResponseReasoningSummaryVerbosity.Detailed
                    }
                };
                var responsesClient = azureOpenAIClient.GetResponsesClient();
                var reasoningClient = responsesClient.AsIChatClient("gpt-5-mini").AsBuilder().ConfigureOptions(x => {
                    x.RawRepresentationFactory = _ => baseOptions;
                }).Build();
                return reasoningClient.AsIChatResponseProvider();
            });

            // Simple AIAgent with tool calling
            serviceCollection.AddKeyedTransient<IChatResponseProvider>(ToolCallingAgentModule.ServiceKey, (sp, _) => {
                var agent = agentChatClient.AsAIAgent(
                    name: "ToolCallingAgent",
                    instructions: "You are a helpful assistant with access to utility tools. Use the available tools to answer user questions.",
                    tools: SimpleTools.Tools);
                var session = agent.CreateSessionAsync().GetAwaiter().GetResult();
                return agent.AsIChatResponseProvider(session);
            });

            // AG-UI: self-host a Kestrel server with the Weather Agent endpoint
            var weatherService = new WeatherService();
            var weatherTools = new WeatherAgentTools(weatherService);
            var aguiHost = AGUIHost.StartAsync(agentFactory, weatherTools).GetAwaiter().GetResult();
            Application.ApplicationExit += (s, e) => aguiHost.Dispose();

            serviceCollection.AddHttpClient("AGUIWeatherClient", client => {
                client.Timeout = TimeSpan.FromSeconds(60);
            });
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(AGUIIntegrationModule.ServiceKey, (sp, _) => {
                var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                return AgentFactory.CreateAGUIWeatherResponseProvider(
                    httpClientFactory.CreateClient("AGUIWeatherClient"),
                    aguiHost.GetWeatherAgentEndpoint());
            });

            // Group Chat Workflow with Tool Calling Approval
            serviceCollection.AddKeyedScoped<IChatResponseProvider>(GroupChatWorkflowModule.ServiceKey, (sp, _) => {
                return new WorkflowResponseProvider<List<ChatMessage>>(
                    agentFactory.CreatePublishingGroupChatWorkflow(),
                    messages => [.. messages],
                    WorkflowResponseProviderStartMode.Open);
            });
#End If
            serviceCollection.AddChatClient(chatClient)
            serviceCollection.AddDevExpressAIDesktop(Sub(x)
                x.RegisterAIExceptionHandler(New Helpers.AIExceptionHandler())
                x.RegisterVectorCollection(collection)
            End Sub)
            Call Application.Run(New frmMain())
        End Sub

        Private ReadOnly Property AzureOpenAIEndpoint As Uri
            Get
                Dim lAzureOpenAIEndpoint As String = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode)
                If String.IsNullOrEmpty(lAzureOpenAIEndpoint) Then lAzureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai" 'DevExpress proxy-server
                Return New Uri(lAzureOpenAIEndpoint)
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIKey As ClientModel.ApiKeyCredential
            Get
                Dim lAzureOpenAIKey As String = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode)
                If String.IsNullOrEmpty(lAzureOpenAIKey) Then lAzureOpenAIKey = "DEMO" 'Demo key
                Return New ClientModel.ApiKeyCredential(lAzureOpenAIKey)
            End Get
        End Property

        Private ReadOnly Property IsDeveloperMode As Boolean
            Get
                Return String.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase)
            End Get
        End Property

        Private Function GetEnvironmentVariable(ByVal variableName As String, ByVal Optional allowSetNewEnvironmentVariable As Boolean = False) As String
            Dim environmentVariable As String = SafeEnvironment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User)
            If String.IsNullOrEmpty(environmentVariable) AndAlso allowSetNewEnvironmentVariable Then
                environmentVariable = XtraInputBox.Show($"Please enter {variableName} variable.", variableName, String.Empty)
                If String.IsNullOrEmpty(environmentVariable) Then Call Application.Exit()
                SafeEnvironment.SetEnvironmentVariable(variableName, environmentVariable, EnvironmentVariableTarget.User)
            End If

            Return environmentVariable
        End Function

        Private Function GetLastUserText(ByVal messages As IEnumerable(Of ChatMessage)) As String
            Dim userMessage = messages.LastOrDefault(Function(m) m.Role = ChatRole.User)
            If userMessage Is Nothing OrElse String.IsNullOrWhiteSpace(userMessage.Text) Then Throw New InvalidOperationException("The workflow requires a user text message.")
            Return userMessage.Text
        End Function
    End Module
End Namespace
