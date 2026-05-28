Imports System.ComponentModel
Imports DevExpress.XtraDataLayout
Imports System.ComponentModel.DataAnnotations

#If NET
using Markdig;
using Microsoft.AspNetCore.Components;
using DevExpress.AIIntegration.Blazor.Chat;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class AIChatCustomizeAppearanceModule
        Inherits AIChatModuleBase

#If NET
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
#End If
    End Class

    Public Class AIChatOverviewModuleOptions
        Inherits AIChatModuleOptionsBase

        Private showHeaderField As Boolean = True

        Public Property ShowHeader As Boolean
            Get
                Return showHeaderField
            End Get

            Set(ByVal value As Boolean)
                showHeaderField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.ShowHeader))
            End Set
        End Property

        Private allowResizeInputField As Boolean = False

        Public Property AllowResizeInput As Boolean
            Get
                Return allowResizeInputField
            End Get

            Set(ByVal value As Boolean)
                allowResizeInputField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.AllowResizeInput))
            End Set
        End Property

        Private customMessageAppearanceField As Boolean = False

        Public Property CustomMessageAppearance As Boolean
            Get
                Return customMessageAppearanceField
            End Get

            Set(ByVal value As Boolean)
                customMessageAppearanceField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.CustomMessageAppearance))
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

        Private richFormattedResponsesField As Boolean = True

        Public Property RichFormattedResponses As Boolean
            Get
                Return richFormattedResponsesField
            End Get

            Set(ByVal value As Boolean)
                richFormattedResponsesField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.RichFormattedResponses))
            End Set
        End Property

        Private emptyStateTextField As String = "AI assistant is ready"

        <Display(Name:="Empty State Placeholder Text")>
        Public Property EmptyStateText As String
            Get
                Return emptyStateTextField
            End Get

            Set(ByVal value As String)
                emptyStateTextField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.EmptyStateText))
            End Set
        End Property

        Private inputBoxNullTextField As String = "Enter your question..."

        <Display(Name:="Input Placeholder Text")>
        Public Property InputBoxNullText As String
            Get
                Return inputBoxNullTextField
            End Get

            Set(ByVal value As String)
                inputBoxNullTextField = value
                NotifyPropertyChanged(NameOf(AIChatOverviewModuleOptions.InputBoxNullText))
            End Set
        End Property
    End Class
End Namespace
