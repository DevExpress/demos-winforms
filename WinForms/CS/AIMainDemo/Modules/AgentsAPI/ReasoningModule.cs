using System.Collections.Generic;
#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#endif

namespace DevExpress.AI.Demos {
    public partial class ReasoningModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(ReasoningModule);

        public ReasoningModule() {
            InitializeComponent();
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Matrix Transposition", "Bash Scripting Challenge", "Write a bash script that accepts a string representation of a matrix (such as '[1,2],[3,4],[5,6]') and outputs the transpose in the same format.", false),
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
