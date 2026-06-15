using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel.Connectors.InMemory;


#if NET
using OpenAI.Responses;
using DevExpress.AI.Demos.Agents;
using DevExpress.AI.Demos.Agents.WorkflowInfra;
using DevExpress.AI.Demos.Agents.Weather;
using DevExpress.AI.Demos.Services;
using DevExpress.AIIntegration.Agents;
using DevExpress.AIIntegration.Chat;
using DevExpress.AI.Demos.AITools;
#endif

namespace DevExpress.AI.Demos {
    static class Program {
        static Program() {
            // Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            // This code loads these DLLs into the current AppDomain
            AppDomain.CurrentDomain.AssemblyResolve += (s, e) => OnAssemblyResolve(e);
        }

        static System.Reflection.Assembly OnAssemblyResolve(ResolveEventArgs e) {
            return DXperience.Demos.DemoHelper.DemoAssemblyResolve(e, typeof(Program).Assembly);
        }

        //WA for https://github.com/Azure/azure-sdk-for-net/issues/45618
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

        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.True;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(AzureOpenAIEndpoint, AzureOpenAIKey, new AzureOpenAIClientOptions() {
                Transport = new PromoteHttpStatusErrorsPipelineTransport()
            });
            var chatClient = azureOpenAIClient.GetChatClient("demo").AsIChatClient();
            var embeddingGenerator = azureOpenAIClient.GetEmbeddingClient("text-embedding-3-small")
                .AsIEmbeddingGenerator();

            /*
            For demonstration purposes, we're using a simple InMemoryCollection to store vectors in memory,
            with a CachingEmbeddingGenerator to load pre-calculated vectors into the vector collection
            during the SemanticSearch module initialization.
            In real-world applications, it's recommended to use a production-grade vector store.
            You can find the list of supported vector store connectors here:
            https://learn.microsoft.com/en-us/semantic-kernel/concepts/vector-store-connectors/out-of-the-box-connectors/?pivots=programming-language-csharp
            */
            var cachingEmbeddingGenerator = new Modules.SemanticSearch.CachingEmbeddingGenerator(embeddingGenerator);
            var collection = new InMemoryCollection<string, SemanticSearchModule.VectorStoreRecord>(SemanticSearchModule.VectorCollectionName,
                new InMemoryCollectionOptions { EmbeddingGenerator = cachingEmbeddingGenerator });
            
            var serviceCollection = new ServiceCollection();
#if NET
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
                var reasoningClient = responsesClient.AsIChatClient("demo-mini").AsBuilder().ConfigureOptions(x => {
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

            // Tool Calling Approval
            serviceCollection.AddKeyedTransient<IChatResponseProvider>(AIAgentWithToolApprovalModule.ServiceKey, (sp, _) => {
                var agent = agentFactory.CreateToolApprovalAgent();
                var session = agent.CreateSessionAsync().GetAwaiter().GetResult();
                return agent.AsIChatResponseProvider(session);
            });
#endif
            serviceCollection.AddChatClient(chatClient);
            serviceCollection.AddDevExpressAIDesktop(x => {
                x.RegisterAIExceptionHandler(new Helpers.AIExceptionHandler());
                x.RegisterVectorCollection(collection);
            });

            Application.Run(new frmMain());
        }

        static Uri AzureOpenAIEndpoint {
            get {
                string azureOpenAIEndpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIEndpoint))
                    azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";//DevExpress proxy-server
                return new Uri(azureOpenAIEndpoint);
            }
        }
        static System.ClientModel.ApiKeyCredential AzureOpenAIKey {
            get {
                string azureOpenAIKey = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIKey))
                    azureOpenAIKey = "DEMO";//Demo key
                return new System.ClientModel.ApiKeyCredential(azureOpenAIKey);
            }
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

        static string GetLastUserText(IEnumerable<ChatMessage> messages) {
            var userMessage = messages.LastOrDefault(m => m.Role == ChatRole.User);
            if(userMessage is null || string.IsNullOrWhiteSpace(userMessage.Text))
                throw new InvalidOperationException("The workflow requires a user text message.");
            return userMessage.Text;
        }
    }

}

