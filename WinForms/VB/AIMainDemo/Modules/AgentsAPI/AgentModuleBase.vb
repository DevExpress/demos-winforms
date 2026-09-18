Imports System.Drawing

#If NET
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.Skins;
using Markdig;
using Microsoft.AspNetCore.Components;
#End If
Namespace DevExpress.AI.Demos

    Public MustInherit Partial Class AgentModuleBase
        Inherits AITutorialControl

#If NET
        public AgentModuleBase() {
            InitializeComponent();
            UpdatePanelControlBackColor();

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
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePanelControlBackColor();
        }
        void UpdatePanelControlBackColor() {
            panelControl1.BackColor = CommonSkins.GetSkin(LookAndFeel).TranslateColor(SystemColors.Window);
        }
        void MarkdownConvert(object sender, AIIntegration.Blazor.Chat.WebView.AIChatControlMarkdownConvertEventArgs e) {
            string html = Markdown.ToHtml(e.MarkdownText);
            e.HtmlText = (MarkupString)html;
        }
#End If
    End Class
End Namespace
