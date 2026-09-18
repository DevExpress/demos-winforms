using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
#if NET
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.Skins;
using DevExpress.XtraDataLayout;
using Microsoft.Extensions.AI;
#endif
namespace DevExpress.AI.Demos {
    public abstract partial class AIChatModuleBase : AITutorialControl {
#if NET
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
#endif
    }
    public class AIChatModuleOptionsBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] String propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool useStreaming = true;
        public virtual bool UseStreaming {
            get { return useStreaming; }
            set {
                useStreaming = value;
                NotifyPropertyChanged(nameof(UseStreaming));
            }
        }
    }
}
