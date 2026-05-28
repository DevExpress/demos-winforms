#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#endif

namespace DevExpress.AI.Demos {
    public partial class GroupChatWorkflowModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(GroupChatWorkflowModule);

        public GroupChatWorkflowModule() {
            InitializeComponent();
            ChatControl.IncludeFunctionCallInfo = Utils.DefaultBoolean.True;
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Publish 'AI Trends 2026'", "Review and publish an article", "Please review and publish the article titled 'AI Trends 2026' to the website and newsletter.", false),
            new PromptSuggestion("Publish breaking news", "Urgent publication", "We have a breaking news story titled 'Major Tech Breakthrough'. Review and publish it immediately across all channels.", false),
            new PromptSuggestion("Publish 'Top 10 Dev Tools'", "Publish a listicle article", "The article 'Top 10 Dev Tools of 2026' is ready. Run all checks and publish it to the website and social media.", false)
        ];
        protected override string Icon => "&#x1F5DE;&#xFE0F;";
        protected override string Title => "Group Chat Workflow with Tool Calling Approval";
        protected override string Description =>
            """
            This is a multi-agent group chat with a <strong>Content Reviewer</strong> and a <strong>Publisher</strong>.
            The Publisher agent's <em>PublishToLive</em> tool requires your approval before execution.
            Start by requesting an article publication.
            """;
#endif
    }
}
