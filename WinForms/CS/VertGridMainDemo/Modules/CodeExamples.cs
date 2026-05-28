namespace DevExpress.XtraVerticalGrid.Demos {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos;
    using DevExpress.DXperience.Demos.CodeDemo;

    public partial class CodeExample : CodeTutorialControlBase {
        public CodeExample() {
            InitializeComponent();
            #region Load External Assemblies
            string[] externalAssemblies = new string[] {
                typeof(DevExpress.XtraPrinting.PrintTool).Assembly.FullName, // XtraPrinting
                typeof(DevExpress.XtraPrinting.TextBrick).Assembly.FullName, // Printing.Core
                typeof(DevExpress.Drawing.DXFont).Assembly.FullName, // Drawing
            };
            foreach(string asmName in externalAssemblies)
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName);
            #endregion Load External Assemblies
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        #region HighlightTokens
        protected override List<string> InitializeHighlightTokens() {
            var tokens = base.InitializeHighlightTokens();
            tokens.AddRange(DefaultTokens);
            return tokens;
        }
        readonly static string[] DefaultTokens = new string[] {

        };
        #endregion HighlightTokens
        protected override List<string> InitializeReferences() {
            List<string> _references = base.InitializeReferences();
            _references.AddRange(new string[] {
                "DevExpress.Drawing" + AssemblyInfo.VSuffix,
                "DevExpress.BonusSkins" + AssemblyInfo.VSuffix,
                "DevExpress.XtraBars" + AssemblyInfo.VSuffix,
                "DevExpress.XtraEditors" + AssemblyInfo.VSuffix,
                "DevExpress.XtraVerticalGrid" + AssemblyInfo.VSuffix,
                "DevExpress.XtraLayout" + AssemblyInfo.VSuffix,
                "DevExpress.XtraPrinting" + AssemblyInfo.VSuffix,
                "DevExpress.Printing" + AssemblyInfo.VSuffix + ".Core",
                "DevExpress.Sparkline" + AssemblyInfo.VSuffix + ".Core",
             });
            return _references;
        }
    }
}

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;

    public class SampleDataCS : CodeExampleResourceFile {
        const string resourcePath = "DevExpress.XtraVerticalGrid.Demos.CodeExamples.Resources.";
        public SampleDataCS()
            : base(typeof(SampleDataCS).Assembly.FullName, resourcePath + "SampleData.cs") {
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(SampleData).Assembly.FullName } };
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }

    public class ImageHelperCS : CodeExampleResourceFile {
        const string resourcePath = "DevExpress.XtraVerticalGrid.Demos.CodeExamples.Resources.";
        public ImageHelperCS()
            : base(typeof(ImageHelperCS).Assembly.FullName, resourcePath + "ImageHelper.cs") {
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(SampleData).Assembly.FullName } };
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }
}
