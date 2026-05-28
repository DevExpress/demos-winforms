namespace DevExpress.XtraTreeList.Demos {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos;
    using DevExpress.DXperience.Demos.CodeDemo;

    public partial class CodeExamples : CodeTutorialControlBase {
        public CodeExamples() {
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
        #region HighlightTokens
        protected override List<string> InitializeHighlightTokens() {
            var tokens = base.InitializeHighlightTokens();
            tokens.AddRange(DefaultTokens);
            return tokens;
        }
        readonly static string[] DefaultTokens = new string[] {
                "SpaceObject",
                "SortOrder",
                "IndicatorObjectPainter",
                "TreeList",
                "TreeListColumn",
                "TreeListNode",
                "TreeListBand",
                "TreeListFormatRule",
                "TreeListHitInfo",
                "TreeListLocalizer",
                "TreeListStringId",
                "TreeListMenuType",
                "TreeListMultiSelectMode",
                "IVirtualTreeListData",
                "VirtualTreeGetCellValueInfo",
                "Action",
                "StringFormat",
                "StringAlignment",
                "PlacementHelper",
                "ColumnInfo",
                "FixedStyle",
                "FormatCondition",
                "AutoFilterCondition",
                "TreeListColumnFilterInfo",
                "RepositoryItem",
                "RepositoryItemSpinEdit",
                "RepositoryItemProgressBar",
                "RepositoryItemCalcEdit",
            };
        #endregion HighlightTokens
        protected override List<string> InitializeReferences() {
            List<string> _references = base.InitializeReferences();
            _references.AddRange(new string[] {
                "DevExpress.Drawing" + AssemblyInfo.VSuffix,
                "DevExpress.BonusSkins" + AssemblyInfo.VSuffix,
                "DevExpress.XtraBars" + AssemblyInfo.VSuffix,
                "DevExpress.XtraEditors" + AssemblyInfo.VSuffix,
                "DevExpress.XtraTreeList" + AssemblyInfo.VSuffix,
                "DevExpress.XtraLayout" + AssemblyInfo.VSuffix,
                "DevExpress.XtraPrinting" + AssemblyInfo.VSuffix,
                "DevExpress.Printing" + AssemblyInfo.VSuffix + ".Core",
                "DevExpress.Sparkline" + AssemblyInfo.VSuffix + ".Core",
             });
            return _references;
        }
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
    }
}

namespace Examples {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;

    public class SpaceObjectCS : CodeExampleResourceFile {
        const string resourcePath = "DevExpress.XtraTreeList.Demos.CodeExamples.Resources.";
        //
        public SpaceObjectCS()
            : base(typeof(SpaceObjectCS).Assembly.FullName, DevExpress.DXperience.Demos.DemoHelper.IsCSharp ? resourcePath + "SpaceObject.cs" : "SpaceObject.vb") {
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(SpaceObject).Assembly.FullName }
        };
        public override System.Collections.Generic.IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }
}
