#If NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class WorkflowAsAgentModule
        Inherits AgentModuleBase

#If NET
        public const string ServiceKey = nameof(WorkflowAsAgentModule);

        public WorkflowAsAgentModule() {
            InitializeComponent();
            ChatControl.UseStreaming = Utils.DefaultBoolean.False;
            ChatControl.IncludeFunctionCallInfo = Utils.DefaultBoolean.True;
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Moon, whisper, ocean", "Tranquil & Mystical", "moon, whisper, ocean", false),
            new PromptSuggestion("Fire, dream, shadow", "Heroic & Hopeful", "fire, dream, shadow", false),
            new PromptSuggestion("Rose, thunder, silence", "Romantic & Contemplative", "rose, thunder, silence", false)
        ];
        protected override string Icon => "&#x1F3AD;";
        protected override string Title => "Shakespearean Poet";
        protected override string Description =>
            """
            The AI Assistant uses a few keywords to craft a poem,
            then rewrites it in the grand style of <em>William Shakespeare</em>.
            Choose a keyword combination below or enter <strong>2 or 3 custom keywords</strong>.
            """;
#End If
    End Class
End Namespace
