using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.ApplicationUI.Demos {
    public class DocumentManagerModule : CodeTutorialControlBase {
        public DocumentManagerModule()
            : base() {
        }
        protected override string[] FileNamesForModule {
            get { return new string[] { "CommonConcepts.cs", "TabbedView.cs", "WindowsUIView.cs", "WidgetView.cs" }; }
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override bool? AllowBorderRounding {
            get { return true; }
        }
    }
}
