#If NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class ToolCallingAgentModule
        Inherits AgentModuleBase

#If NET
        public const string ServiceKey = nameof(ToolCallingAgentModule);

        public ToolCallingAgentModule() {
            InitializeComponent();
            ChatControl.IncludeFunctionCallInfo = Utils.DefaultBoolean.True;
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Current UTC Time", "System Information", "What is the current UTC time?", false),
            new PromptSuggestion("Add Numbers", "Math Operation", "What is the sum of 42 and 58?", false),
            new PromptSuggestion("Reverse Text", "String Function", "Reverse the text 'Hello, World!'.", false)
        ];
        protected override string Icon => "&#x1F527;";
        protected override string Title => "AI Agent with Tool Calling";
        protected override string Description =>
            """
            This simple <strong>AI Agent</strong> is equipped with tools to retrieve the current time,
            add numbers, and reverse text.
            Choose a suggestion below or ask the agent to use one of its tools.
            """;
#End If
    End Class
End Namespace
