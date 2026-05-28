using System.Collections.Generic;
#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#endif

namespace DevExpress.AI.Demos {
    public partial class WorkflowWithExecutorsModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(WorkflowWithExecutorsModule);

        public WorkflowWithExecutorsModule() {
            InitializeComponent();
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Hello, World!", "Classic Greeting", "Hello, World!", false),
            new PromptSuggestion("DevExpress WinForms", "Product Name", "DevExpress WinForms", false),
            new PromptSuggestion("Workflow streaming rocks!", "Enthusiastic Message", "Workflow streaming rocks!", false)
        ];
        protected override string Icon => "&#x1F504;";
        protected override string Title => "Workflow with Execution Steps";
        protected override string Description =>
            """
            Enter any text and start a two-step transformation workflow: 
            <strong>Uppercase</strong> &rarr; <strong>Reverse</strong>.
            Our custom response provider (<em>WorkflowResponseProvider</em>) streams 
            operation progress to the chat control in real time.
            """;
#endif
    }
}
