using System.Collections.Generic;
#if NET
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using Microsoft.Extensions.AI;
#endif

namespace DevExpress.AI.Demos {
    public partial class ReasoningModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(ReasoningModule);

        const string SystemPrompt =
            "Always reason through every question before giving your final answer, regardless of how simple it seems. " +
            "Do not use LaTeX, KaTeX, MathJax, or any other mathematical markup. " +
            "Express mathematical content in plain text or Markdown (e.g., use C(3,2) instead of \\binom{3}{2}).";

        public ReasoningModule() {
            InitializeComponent();
            ChatControl.Initialized += ChatControl_Initialized;
            ChatControl.ContentFormat = ResponseContentFormat.PlainText;
            ChatControl.SetMessageContentTemplate((message) => (builder) => {
                builder.OpenComponent<ReasoningMessage>(0);
                builder.AddAttribute(1, "Message", message);
                builder.CloseComponent();
            });
        }

        void ChatControl_Initialized(object sender, AIChatControlInitializedEventArgs e) {
            ChatControl.LoadMessages([new BlazorChatMessage(ChatRole.System, SystemPrompt)]);
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Water Jug Problem", "Classic Logic Puzzle", "You have a 3-gallon jug and a 5-gallon jug. How can you measure exactly 4 gallons of water? Explain each step.", false),
            new PromptSuggestion("Probability Puzzle", "Math Reasoning", "A bag contains 3 red balls and 5 blue balls. You draw 2 balls without replacement. What is the probability that both balls are the same color? Show your work step by step.", false),
            new PromptSuggestion("Knights and Knaves", "Logical Deduction", "On an island, every person is either a knight (always tells the truth) or a knave (always lies). You meet two people, A and B. A says 'At least one of us is a knave.' What are A and B?", false)
        ];
        protected override string Icon => "&#x1F9E0;";
        protected override string Title => "Responses API & Reasoning Models";
        protected override string Description =>
            """
            Test the model's reasoning capabilities with logic puzzles, math problems,
            coding challenges, and other multi-step tasks.
            Choose a suggestion below or enter your own prompt.
            """;
#endif
    }
}
