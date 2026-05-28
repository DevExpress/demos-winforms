using System.ComponentModel.DataAnnotations;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraLayout.Demos {
    public class CodeFirstModule : CodeTutorialControlBase {
        public CodeFirstModule() : base() {
            string cmAssemblyName = typeof(DisplayAttribute).Assembly.FullName;
            DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(cmAssemblyName);
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
    }
}
