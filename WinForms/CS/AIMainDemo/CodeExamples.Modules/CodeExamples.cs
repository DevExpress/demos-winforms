namespace DevExpress.AI.Demos {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos;
    using DevExpress.DXperience.Demos.CodeDemo;

    public partial class CodeExamples : CodeTutorialControlBase {
        static void CodeExample() {
            DevExpress.AIIntegration.WinForms.BehaviorInitializer.Initialize();//Force initialize Behavior in a case of starting code-example without running the demo
        }
        public CodeExamples() {
            InitializeComponent();
            #region Load External Assemblies
            string[] externalAssemblies = new string[] {
                typeof(DevExpress.Mvvm.ViewModelBase).Assembly.FullName,
                typeof(Microsoft.Extensions.DependencyInjection.ServiceCollection).Assembly.FullName,
                typeof(Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions).Assembly.FullName,
                typeof(DevExpress.AIIntegration.WinForms.BehaviorInitializer).Assembly.FullName
            };
            foreach(string asmName in externalAssemblies)
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName);
            #endregion Load External Assemblies
        }
        protected override string XtraItemGroupData {
            get {
                return $@"<PackageReference Include=""DevExpress.AIIntegration.WinForms"" Version=""//Version"" />";
            }
        }
        #region HighlightTokens
        protected override List<string> InitializeHighlightTokens() {
            var tokens = base.InitializeHighlightTokens();
            tokens.AddRange(DefaultTokens);
            return tokens;
        }
        readonly static string[] DefaultTokens = new string[] {
                "IChatClient",
                "AzureOpenAIClient",
                "ApiKeyCredential",
                "IAIExtensionsContainer",
                "AIExtensionsContainerDefault",
                "AIExtensionsContainerLocal",
                "AIExtensionsContainerDesktop",
                "AIExceptionHandler",
                "IAIExceptionHandler",
            };
        #endregion HighlightTokens
        protected override List<string> InitializeReferences() {
            List<string> _references = base.InitializeReferences();
            _references.AddRange(new string[] { });
            return _references;
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override void DoHide() {
            base.DoHide();
            DestroyCurrentExample();
        }
    }
}
