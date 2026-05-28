using System;
using System.Collections.Generic;
#if NET
using DevExpress.AIIntegration.Blazor.Chat;
#endif

namespace DevExpress.AI.Demos {
    public partial class AIChatResourcesModule : AIChatModuleBase {
#if NET
        public AIChatResourcesModule() {
            InitializeComponent();
            ChatControl.FileUploadEnabled = Utils.DefaultBoolean.True;
            ChatControl.SetResources(AIChatResourcesDataProvider.GetData());
        }
        protected override Type GetOptionsType() {
            return typeof(AIChatResourcesOptions);
        }
        protected new AIChatResourcesOptions Options => base.Options as AIChatResourcesOptions;
#endif
    }
    public class AIChatResourcesOptions : AIChatModuleOptionsBase {
    }
}
