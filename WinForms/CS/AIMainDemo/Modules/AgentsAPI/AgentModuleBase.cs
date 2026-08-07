using System.Drawing;
using System.Windows.Forms;
#if NET
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.Skins;
using Markdig;
using Microsoft.AspNetCore.Components;
#endif
namespace DevExpress.AI.Demos {
    public abstract partial class AgentModuleBase : AITutorialControl {
#if NET
        public AgentModuleBase() {
            InitializeComponent();

            aiChatControl.ChatResponseProviderServiceKey = ChatClientServiceKey;
            aiChatControl.ContentFormat = ResponseContentFormat.Markdown;
            aiChatControl.MarkdownConvert += MarkdownConvert;
            aiChatControl.SetEmptyMessageAreaTemplate(builder => {
                builder.OpenComponent<EmptyMessageAreaTemplate>(0);
                builder.AddAttribute(1, "Icon", Icon);
                builder.AddAttribute(2, "Title", Title);
                builder.AddAttribute(3, "Description", Description);
                builder.CloseComponent();
            });
            aiChatControl.SetPromptSuggestions(PromptSuggestions);
        }

        protected AIChatControl ChatControl => aiChatControl;

        protected abstract string ChatClientServiceKey { get; }
        protected abstract PromptSuggestion[] PromptSuggestions { get; }
        protected abstract string Icon { get; }
        protected abstract string Title { get; }
        protected abstract string Description { get; }

        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
        void MarkdownConvert(object sender, AIIntegration.Blazor.Chat.WebView.AIChatControlMarkdownConvertEventArgs e) {
            string html = Markdown.ToHtml(e.MarkdownText);
            e.HtmlText = (MarkupString)html;
        }
#endif
    }
}
