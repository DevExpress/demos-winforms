Imports System.ComponentModel
Imports System.Drawing

#If NET
using DevExpress.AIIntegration.Blazor.Chat.WebView;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class AIChatPromptSuggestionsModule
        Inherits AIChatModuleBase

#If NET
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
#End If
    End Class

    Public Class AIChatPromptSuggestionsModuleOptions
        Inherits AIChatModuleOptionsBase

        Private sendOnClickField As Boolean = False

        Public Overridable Property SendOnClick As Boolean
            Get
                Return sendOnClickField
            End Get

            Set(ByVal value As Boolean)
                sendOnClickField = value
                NotifyPropertyChanged(NameOf(AIChatPromptSuggestionsModuleOptions.SendOnClick))
            End Set
        End Property

        Public Overrides Property UseStreaming As Boolean
            Get
                Return MyBase.UseStreaming
            End Get

            Set(ByVal value As Boolean)
                MyBase.UseStreaming = value
            End Set
        End Property
    End Class
End Namespace
