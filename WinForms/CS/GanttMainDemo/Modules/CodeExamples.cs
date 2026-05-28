namespace DevExpress.XtraGantt.Demos {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos;
    using DevExpress.DXperience.Demos.CodeDemo;

    public partial class CodeExamples : CodeTutorialControlBase {
        #region static
        readonly static string[] externalAssemblies = new string[] { 
                //typeof(IFormatRuleBase).Assembly.FullName 
            };
        static CodeExamples() {
            foreach(var asmName in externalAssemblies) {
                DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssembly(asmName);
            }
        }
        #endregion static
        public CodeExamples() {
            InitializeComponent();
        }
        #region HighlightTokens
        protected override List<string> InitializeHighlightTokens() {
            var tokens = base.InitializeHighlightTokens();
            tokens.AddRange(DefaultTokens);
            return tokens;
        }
        readonly static string[] DefaultTokens = new string[] { 
                "Task",
                "HashSet",
                "TimeSpan",
                "RectangleF",
                "TreeList",
                "GanttControl",
                "TreeListColumn",
                "GanttTimescaleColumn",
                "TreeListNode",
                "GanttControlNode",
                "TreeListBand",
                "TreeListHitInfo",
                "TreeListLocalizer",
                "TreeListStringId",
                "TreeListMenuType",
                "TreeListMultiSelectMode",
                "Action",
                "StringFormat", 
                "StringAlignment",
                "RepositoryItem",
                "RepositoryItemSpinEdit",
                "RepositoryItemProgressBar",
                "RepositoryItemCalcEdit",
            };
        #endregion HighlightTokens
        protected override List<string> InitializeReferences() {
            List<string> _references = base.InitializeReferences();
            _references.AddRange(new string[] {
                "DevExpress.BonusSkins" + AssemblyInfo.VSuffix,
                "DevExpress.XtraBars" + AssemblyInfo.VSuffix,
                "DevExpress.XtraGantt" + AssemblyInfo.VSuffix,
                "DevExpress.XtraEditors" + AssemblyInfo.VSuffix,
                "DevExpress.XtraTreeList" + AssemblyInfo.VSuffix,
                "DevExpress.XtraGrid" + AssemblyInfo.VSuffix,
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

    public class TaskCS : CodeExampleResourceFile {
        const string resourcePath = "DevExpress.XtraGantt.Demos.CodeExamples.Resources.";
        public TaskCS() 
            : base(typeof(TaskCS).Assembly.FullName, DevExpress.DXperience.Demos.DemoHelper.IsCSharp ? resourcePath + "Task.cs" : "Task.vb") {
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {{"{TutorialsAssembly}", typeof(Task).Assembly.FullName}};
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }

    public class SplitInfoCS : CodeExampleResourceFile {
        const string resourcePath = "DevExpress.XtraGantt.Demos.CodeExamples.Resources.";
        public SplitInfoCS() 
            : base(typeof(SplitInfoCS).Assembly.FullName, DevExpress.DXperience.Demos.DemoHelper.IsCSharp ? resourcePath + "SplitInfo.cs" : "SplitInfo.vb") {
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {{"{TutorialsAssembly}", typeof(SplitInfo).Assembly.FullName}};
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }
}
