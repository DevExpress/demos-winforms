using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.ApplicationUI.Demos {
    public class UtilityControlsModule : CodeTutorialControlBase {
        public UtilityControlsModule()
            : base() {
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override bool? AllowBorderRounding {
            get { return true; }
        }
    }
}
