using System.Collections.Generic;
#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#endif

namespace DevExpress.AI.Demos {
    public partial class WorkflowResponseStreamingModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(WorkflowResponseStreamingModule);

        public WorkflowResponseStreamingModule() {
            InitializeComponent();
            ChatControl.IncludeFunctionCallInfo = Utils.DefaultBoolean.True;
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Moon, whisper, ocean", "Tranquil & Mystical", "moon, whisper, ocean", false),
            new PromptSuggestion("Fire, dream, shadow", "Heroic & Hopeful", "fire, dream, shadow", false),
            new PromptSuggestion("Rose, thunder, silence", "Romantic & Contemplative", "rose, thunder, silence", false)
        ];
        protected override string Icon => "&#x1F3AD;";
        protected override string Title => "Workflow Response Streaming";
        protected override string Description =>
            """
            This demo implements the same Shakespearean Poet pipeline 
            and uses a custom workflow provider implementation (WorkflowResponseProvider). 
            This provider streams events in real time. Enter <strong>2 or 3 keywords</strong> to get started.
            """;
#endif
    }
}
