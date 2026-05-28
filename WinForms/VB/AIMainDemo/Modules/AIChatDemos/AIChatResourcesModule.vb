#If NET
using DevExpress.AIIntegration.Blazor.Chat;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class AIChatResourcesModule
        Inherits AIChatModuleBase

#If NET
        public AIChatResourcesModule() {
            InitializeComponent();
            ChatControl.FileUploadEnabled = Utils.DefaultBoolean.True;
            ChatControl.SetResources(AIChatResourcesDataProvider.GetData());
        }
        protected override Type GetOptionsType() {
            return typeof(AIChatResourcesOptions);
        }
        protected new AIChatResourcesOptions Options => base.Options as AIChatResourcesOptions;
#End If
    End Class

    Public Class AIChatResourcesOptions
        Inherits AIChatModuleOptionsBase

    End Class
End Namespace
