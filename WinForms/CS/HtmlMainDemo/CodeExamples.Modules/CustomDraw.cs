using System.Collections.Generic;
using System.Reflection;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace DevExpress.HTML.Demos {
    public partial class CustomDraw : CodeTutorialControl {
        public CustomDraw() {
            InitializeComponent();
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("Assets");
            return list;
        }
    }
}

namespace DevExpress.HTML.Demos.CodeExamples {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;

    public class SampleDataCS : HtmlExampleResourceFile {
        public SampleDataCS() : base(typeof(SampleData)) { }     
    }

    public class SpaceObjectCS : HtmlExampleResourceFile {
        public SpaceObjectCS() : base(typeof(SpaceObject)) { }
    }

    public abstract class HtmlExampleResourceFile : CodeExampleResourceFile {
        static string assemblyName = typeof(HtmlExampleResourceFile).Assembly.FullName;
        const string resourcePath = "DevExpress.HTML.Demos.CodeExamples.Resources.";

        readonly IDictionary<string, string> replacementsCore;
        public override IDictionary<string, string> Replacements => replacementsCore;

        public HtmlExampleResourceFile(System.Type resourceType)
            : base(assemblyName, DevExpress.DXperience.Demos.DemoHelper.IsCSharp ? resourcePath + resourceType.Name + ".cs" : resourceType.Name + ".vb") {

            replacementsCore = new Dictionary<string, string> { { "{TutorialsAssembly}", resourceType.Assembly.FullName } };
        }        
    }
}
