Imports System
Imports System.ComponentModel
Imports System.Drawing

#If NET
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.Skins;
using DevExpress.XtraDataLayout;
using Microsoft.Extensions.AI;
#End If
Namespace DevExpress.AI.Demos

    Public MustInherit Partial Class AIChatModuleBase
        Inherits AITutorialControl

#If NET
        BindingSource optionsBindingSource;
        public AIChatModuleBase() {
            InitializeComponent();
            UpdatePanelControlBackColor();

            aiChatControl.ChatResponseProviderServiceKey = ToolsChatClientServiceKey;
            if(!string.IsNullOrEmpty(SystemMessage))
                aiChatControl.LoadMessages([new BlazorChatMessage(ChatRole.System, SystemMessage)]);

            optionsBindingSource = new BindingSource();
            optionsBindingSource.DataSource = GetOptionsType();
            Options = optionsBindingSource.AddNew() as AIChatModuleOptionsBase;
            Options.PropertyChanged += OptionsPropertyChanged;

            dataLayoutControl.DataSource = optionsBindingSource;
            dataLayoutControl.FieldRetrieved += DataLayoutControl_FieldRetrieved;
            dataLayoutControl.RetrieveFields(new RetrieveFieldsParameters() { DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged });
        }

        protected virtual void DataLayoutControl_FieldRetrieved(object sender, FieldRetrievedEventArgs e) {
        }

        protected AIChatModuleOptionsBase Options { get; }
        protected AIChatControl ChatControl => aiChatControl;

        protected virtual string ToolsChatClientServiceKey { get; } = null;
        protected virtual string SystemMessage { get; } = null;

        protected abstract Type GetOptionsType();
        protected virtual void OptionsPropertyChanged(object sender, PropertyChangedEventArgs e) {
            if(e.PropertyName == nameof(Options.UseStreaming)) {
                aiChatControl.UseStreaming = Options.UseStreaming ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
            }
        }

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
#End If
    End Class

    Public Class AIChatModuleOptionsBase
        Implements INotifyPropertyChanged

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub NotifyPropertyChanged(<Runtime.CompilerServices.CallerMemberName> ByVal Optional propertyName As String = "")
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Private useStreamingField As Boolean = True

        Public Overridable Property UseStreaming As Boolean
            Get
                Return useStreamingField
            End Get

            Set(ByVal value As Boolean)
                useStreamingField = value
                NotifyPropertyChanged(NameOf(AIChatModuleOptionsBase.UseStreaming))
            End Set
        End Property
    End Class
End Namespace
