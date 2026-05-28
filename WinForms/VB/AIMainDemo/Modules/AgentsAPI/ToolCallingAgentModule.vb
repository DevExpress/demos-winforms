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
            new PromptSuggestion("Current Time", "Utility", "What is the current UTC time?", false),
            new PromptSuggestion("Sum Numbers", "Math", "What is the sum of 42 and 58?", false),
            new PromptSuggestion("Reverse Text", "Text Processing", "Reverse the text 'Hello, World!'", false)
        ];
        protected override string Icon => "&#x1F527;";
        protected override string Title => "AI Agent with Tool Calling";
        protected override string Description =>
            """
            A simple <strong>AI Agent</strong> equipped with tools that can retrieve the current time,
            sum numbers and reverse text.
            Choose a suggestion below or ask the agent to use any of its tools.
            """;
#End If
    End Class
End Namespace
