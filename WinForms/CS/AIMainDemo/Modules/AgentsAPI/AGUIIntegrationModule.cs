using System.Collections.Generic;

#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using DevExpress.AIIntegration.Blazor.Chat;
#endif

namespace DevExpress.AI.Demos {
    public partial class AGUIIntegrationModule : AgentModuleBase {
#if NET
        public const string ServiceKey = nameof(AGUIIntegrationModule);

        public AGUIIntegrationModule() {
            InitializeComponent();
            ChatControl.ContentFormat = ResponseContentFormat.PlainText;
            ChatControl.UseStreaming = Utils.DefaultBoolean.False;
            ChatControl.SetMessageContentTemplate((message) => (builder) => {
                builder.OpenComponent<WeatherMessageContentTemplate>(0);
                builder.AddAttribute(1, "Message", message);
                builder.CloseComponent();
            });
        }

        protected override string ChatClientServiceKey => ServiceKey;
        protected override PromptSuggestion[] PromptSuggestions => [
            new PromptSuggestion("Weather in London", "Check the weather in the UK capital", "What's the weather in London?", false),
            new PromptSuggestion("Weather in Tokyo", "Check the weather in Japan's capital", "How's the weather looking in Tokyo?", false),
            new PromptSuggestion("Weather in New York", "Check the weather in New York (the Big Apple)", "Tell me about the weather in New York.", false)
        ];
        protected override string Icon => "&#x1F324;&#xFE0F;";
        protected override string Title => "AG-UI Weather Agent";
        protected override string Description =>
            """
            Ask about the weather in any city. Pick a suggestion below or enter your own prompt.
            The chat control queries a self-hosted <strong>Weather Agent</strong>. 
            <strong>AG-UI protocol</strong> is used for communication.
            """;
#endif
    }
}
