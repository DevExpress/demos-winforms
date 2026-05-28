using System.Collections.Generic;

namespace DevExpress.XtraDialogs.Demos {
    public partial class FileExplorerExtensionsAPIExamples : CodeTutorialControl {
        static FileExplorerExtensionsAPIExamples() {
            if(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0 && DevExpress.XtraTreeList.TreeList.AutoFilterNodeId < 0)
                DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize();
        }
        public FileExplorerExtensionsAPIExamples() {
            InitializeComponent();
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("GridControlExtension");
            list.Add("TreeListExtension");
            list.Add("BreadCrumbExtension");
            list.Add("Environment");
            list.Add("EnvironmentSpecialFolderNode");
            list.Add("VirtualFolderNode");
            list.Add("VirtualItemNode");
            list.Add("PathNode");
            list.Add(nameof(NavigationBinding));
            list.Add(nameof(DXperience.Demos.CodeDemo.Data.SvgPreviewHandler));
            list.Add(nameof(XtraEditors.Base.Controls.Preview.WinPreviewHandlerBase));
            return list;
        }
    }
}


namespace DevExpress.XtraDialogs.Demos.CodeExamples {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;

    public class SvgPreviewHandlerCS : CodeExampleResourceFile {
        public SvgPreviewHandlerCS()
            : base(typeof(SvgPreviewHandlerCS).Assembly.FullName, GetResourceName()) {
        }
        static string GetResourceName() {
            return DXperience.Demos.DemoHelper.IsCSharp ? "DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandler.cs" : "SvgPreviewHandler.vb";
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(SampleData).Assembly.FullName }
        };
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }
}
