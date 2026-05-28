using System.Collections.Generic;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraGrid.Demos.Modules {
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
            get { return DXperience.Demos.DemoHelper.GetExampleLanguage(); }
        }
        protected override List<string> InitializeHighlightTokens() {
            List<string> _initializeHighlightTokens = base.InitializeHighlightTokens();
            _initializeHighlightTokens.AddRange(new string[] {
                "Binding",
                "GridControl",
                "GridColumn",
                "TileViewColumn",
                "HorzAlignment",
                "NewItemRowPosition",
                "DockStyle",
                "ComboBoxEdit",
                "RepositoryItemSpinEdit",
                "RepositoryItemCalcEdit",
                "ShowButtonModeEnum",
                "RepositoryItemGridLookUpEdit",
                "RepositoryItemToggleSwitch",
                "RepositoryItemButtonEdit",
                "ButtonPredefines",
                "GridHitInfo",
                "DXMenuItem",
                "List",
                "EventHandler",
                "Dictionary",
                "ControlPaint",
                "DrawElementInfo",
                "ObjectPainter",
                "Brushes",
                "Brush",
                "SmoothingMode",
                "Convert",
                "Pen",
                "BinaryOperator",
                "Font",
                "Size",
                "Point",
                "XtraInputBox",
                "GridFilterPanelInfoArgs",
                "SkinGridFilterPanelPainter",
                "CheckState",
                "GridGroupSummaryItem",
                "ImageCollection",
                "GroupOperator",
                "CriteriaOperator",
                "OperandProperty",
                "OperandValue",
                "GridEditingMode",
                "MethodInvoker",
                "Environment",
                "ButtonPredefines",
                "ColumnFilterInfo",
                "RepositoryItemSpinEdit",
                "TextEdit",
                "GridGroupRowInfo",
                "SeekOrigin",
                "MemoryStream",
                "PaddingInfo",
                "FontStyle",
                "GridMultiSelectMode",
                "SummaryItemType",
                "GridGroupSummaryItem",
                "CustomSummaryProcess",
                "UnboundColumnType",
                "EditFormValidateEditorEventArgs",
                "ExceptionMode",
                "Keys",
                "FormatConditionRuleValue",
                "GridFormatRule",
                "FormatConditionRule2ColorScale",
                "FormatCondition",
                "Rectangle",
                "EditorsSkins",
                "UserLookAndFeel",
                "Cursor",
                "DefaultBoolean",
                "CustomEditForm",
                "DateEdit",
                "ImageLocation",
                "DemoHelper",
                "EditorButton",
                "DataSourceUpdateMode",
                "ShowValueEditorEventHandler",
                "BinaryOperatorType",
                "Comparer",
                "ColumnSortOrder",
                "ColumnSortMode",
                "SpinEdit",
                "RectangleF",
                "PrintingSystemBase",
                "TextBrick",
                "SizeF",
                "FormStartPosition",
                "XtraForm",
                "RepositoryItemCheckEdit"
            });
            return _initializeHighlightTokens;
        }
        protected override List<string> InitializeReferences() {
            List<string> _references = base.InitializeReferences();
            _references.AddRange(new string[] {
                "DevExpress.Drawing" + AssemblyInfo.VSuffix,
                "DevExpress.BonusSkins" + AssemblyInfo.VSuffix,
                "DevExpress.XtraBars" + AssemblyInfo.VSuffix,
                "DevExpress.XtraEditors" + AssemblyInfo.VSuffix,
                "DevExpress.XtraGrid" + AssemblyInfo.VSuffix,
                "DevExpress.XtraLayout" + AssemblyInfo.VSuffix,
                "DevExpress.XtraPrinting" + AssemblyInfo.VSuffix,
                "DevExpress.Printing" + AssemblyInfo.VSuffix + ".Core",
                "DevExpress.Sparkline" + AssemblyInfo.VSuffix + ".Core",
             });
            return _references;
        }
    }
}

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    using System.Collections.Generic;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;

    public class SampleDataCS : CodeExampleResourceFile {
        public SampleDataCS()
            : base(typeof(SampleDataCS).Assembly.FullName, GetResourceName()) {
        }
        static string GetResourceName() {
            return DXperience.Demos.DemoHelper.IsCSharp ? "DevExpress.XtraGrid.Demos.CodeExamples.Resources.SampleData.cs" : "SampleData.vb";
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(SampleData).Assembly.FullName }
        };
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }

    public class LipsumDataCS : CodeExampleResourceFile {
        public LipsumDataCS()
            : base(typeof(LipsumDataCS).Assembly.FullName, GetResourceName()) {
        }
        static string GetResourceName() {
            return DXperience.Demos.DemoHelper.IsCSharp ? "DevExpress.XtraGrid.Demos.CodeExamples.Resources.LipsumObject.cs" : "LipsumObject.vb";
        }
        static readonly IDictionary<string, string> replacementsCore = new Dictionary<string, string> {
            { "{TutorialsAssembly}", typeof(LipsumObject).Assembly.FullName }
        };
        public override IDictionary<string, string> Replacements {
            get { return replacementsCore; }
        }
    }
}
