using System;
using System.ComponentModel;
using DevExpress.XtraDataLayout;
using System.ComponentModel.DataAnnotations;

#if NET
using Markdig;
using Microsoft.AspNetCore.Components;
using DevExpress.AIIntegration.Blazor.Chat;
#endif

namespace DevExpress.AI.Demos {
    public partial class AIChatCustomizeAppearanceModule : AIChatModuleBase {
#if NET
        public AIChatCustomizeAppearanceModule() {
            InitializeComponent();
            ChatControl.ContentFormat = ResponseContentFormat.Markdown;
            ChatControl.MarkdownConvert += MarkdownConvert;
            ChatControl.EmptyStateText = Options.EmptyStateText;
            ChatControl.InputBoxNullText = Options.InputBoxNullText;
        }

        void MarkdownConvert(object sender, AIIntegration.Blazor.Chat.WebView.AIChatControlMarkdownConvertEventArgs e) {
            string html = Markdown.ToHtml(e.MarkdownText);
            e.HtmlText = (MarkupString)html;
        }

        protected override Type GetOptionsType() {
            return typeof(AIChatOverviewModuleOptions);
        }
        protected new AIChatOverviewModuleOptions Options => base.Options as AIChatOverviewModuleOptions;

        protected override void DataLayoutControl_FieldRetrieved(object sender, FieldRetrievedEventArgs e) {
            base.DataLayoutControl_FieldRetrieved(sender, e);
            if(e.FieldName == nameof(Options.EmptyStateText) || e.FieldName == nameof(Options.InputBoxNullText)) {
                e.Item.TextLocation = Utils.Locations.Top;
            }
        }

        protected override void OptionsPropertyChanged(object sender, PropertyChangedEventArgs e) {
            base.OptionsPropertyChanged(sender, e);
            if(e.PropertyName == nameof(Options.ShowHeader)) {
                ChatControl.ShowHeader = Options.ShowHeader ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
            }
            if(e.PropertyName == nameof(Options.AllowResizeInput)) {
                ChatControl.AllowResizeInput = Options.AllowResizeInput ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
            }
            if(e.PropertyName == nameof(Options.EmptyStateText)) {
                ChatControl.EmptyStateText = Options.EmptyStateText;
            }
            if(e.PropertyName == nameof(Options.InputBoxNullText)) {
                ChatControl.InputBoxNullText = Options.InputBoxNullText;
            }
            if(e.PropertyName == nameof(Options.CustomMessageAppearance)) {
                if(Options.CustomMessageAppearance) {
                    ChatControl.SetMessageTemplate((message) => (builder) => {
                        builder.OpenComponent<MessageTemplate>(0);
                        builder.AddAttribute(1, "Context", message);
                        builder.CloseComponent();
                    });
                }
                else {
                    ChatControl.SetMessageTemplate(null);
                }
            }
            if(e.PropertyName == nameof(Options.RichFormattedResponses)) {
                ChatControl.ContentFormat = Options.RichFormattedResponses ? ResponseContentFormat.Markdown : ResponseContentFormat.PlainText;
            }
        }
#endif
    }

    public class AIChatOverviewModuleOptions : AIChatModuleOptionsBase {
        bool showHeader = true;
        public bool ShowHeader {
            get { return showHeader; }
            set {
                showHeader = value;
                NotifyPropertyChanged(nameof(ShowHeader));
            }
        }

        bool allowResizeInput = false;
        public bool AllowResizeInput {
            get { return allowResizeInput; }
            set {
                allowResizeInput = value;
                NotifyPropertyChanged(nameof(AllowResizeInput));
            }
        }

        bool customMessageAppearance = false;
        public bool CustomMessageAppearance {
            get { return customMessageAppearance; }
            set {
                customMessageAppearance = value;
                NotifyPropertyChanged(nameof(CustomMessageAppearance));
            }
        }

        public override bool UseStreaming {
            get { return base.UseStreaming; }
            set { base.UseStreaming = value; }
        }

        bool richFormattedResponses = true;
        public bool RichFormattedResponses {
            get { return richFormattedResponses; }
            set {
                richFormattedResponses = value;
                NotifyPropertyChanged(nameof(RichFormattedResponses));
            }
        }

        string emptyStateText = "AI assistant is ready";
        [Display(Name = "Empty State Placeholder Text")]
        public string EmptyStateText {
            get { return emptyStateText; }
            set {
                emptyStateText = value;
                NotifyPropertyChanged(nameof(EmptyStateText));
            }
        }

        string inputBoxNullText = "Enter your question...";
        [Display(Name = "Input Placeholder Text")]
        public string InputBoxNullText {
            get { return inputBoxNullText; }
            set {
                inputBoxNullText = value;
                NotifyPropertyChanged(nameof(InputBoxNullText));
            }
        }
    }
}
