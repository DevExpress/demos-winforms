using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraDialogs.Demos {
    public class CodeTutorialControl : CodeTutorialControlBase {
        public CodeTutorialControl() {
            //load assemblies
            string gridAssembly = typeof(XtraGrid.GridControl).Assembly.FullName;
            string coreAssembly = typeof(Dialogs.Core.CustomLinkFilterEventArgs).Assembly.FullName;
            DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(gridAssembly);
            DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(coreAssembly);
        }
        //
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("XtraForm");
            list.Add("XtraUserControl");
            return list;
        }
    }
}
