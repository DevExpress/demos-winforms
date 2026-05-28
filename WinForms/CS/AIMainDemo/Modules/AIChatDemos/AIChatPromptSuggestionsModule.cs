using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#if NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#endif

namespace DevExpress.AI.Demos {
    public partial class AIChatPromptSuggestionsModule : AIChatModuleBase {
#if NET
        public AIChatPromptSuggestionsModule() {
            InitializeComponent();

            ChatControl.ShowHeader = Utils.DefaultBoolean.True;
            SetPromptSuggestions();
        }
        protected override Type GetOptionsType() {
            return typeof(AIChatPromptSuggestionsModuleOptions);
        }
        protected new AIChatPromptSuggestionsModuleOptions Options => base.Options as AIChatPromptSuggestionsModuleOptions;
        protected override void OptionsPropertyChanged(object sender, PropertyChangedEventArgs e) {
            base.OptionsPropertyChanged(sender, e);
            if(e.PropertyName == nameof(Options.SendOnClick)) {
                SetPromptSuggestions(Options.SendOnClick);
            }
        }
        void SetPromptSuggestions(bool sendOnClick = false) {
            ChatControl.SetPromptSuggestions(new List<PromptSuggestion>() {
                new PromptSuggestion("Tell me a joke", "Take a break and enjoy a quick laugh", "Tell me a joke", sendOnClick),
                new PromptSuggestion("Summarize text", "Extract a quick summary(main ideas)", "Summarize text", sendOnClick),
                new PromptSuggestion("Write an email", "Make your text look and sound professional", "Write an email", sendOnClick),
                new PromptSuggestion("Brainstorm ideas", "Get creative input for your tasks", "Brainstorm ideas", sendOnClick),
                new PromptSuggestion("Fix my writing", "Avoid spelling, grammar, and style errors", "Fix my writing", sendOnClick)
            });
        }
#endif
    }
    public class AIChatPromptSuggestionsModuleOptions : AIChatModuleOptionsBase {
        bool sendOnClick = false;
        public virtual bool SendOnClick {
            get { return sendOnClick; }
            set {
                sendOnClick = value;
                NotifyPropertyChanged(nameof(SendOnClick));
            }
        }

        public override bool UseStreaming {
            get { return base.UseStreaming; }
            set { base.UseStreaming = value; }
        }
    }
}
