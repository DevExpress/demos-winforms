using System.Collections.Generic;
using System.Reflection;
using DevExpress.Data.Internal;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CodeExamples : CodeTutorialControlBase {
        public CodeExamples() {
            InitializeComponent();
            string[] assemblyNames = new string[] { typeof(PrintingSystemBase).Assembly.FullName, typeof(XtraCharts.ChartControl).Assembly.FullName };
            foreach(var aName in assemblyNames) {
                SafeTypeResolver.GetOrLoadAssembly(aName, throwOnError: true);
            }
        }

        protected override ExampleLanguage CurrentExampleLanguage {
            get {
                if(TutorialControl.GetIsCSCode(typeof(ExcelStyleFilter).Name))
                    return ExampleLanguage.Csharp;
                else
                    return ExampleLanguage.VB;
            }
        }

        protected override List<string> InitializeHighlightTokens() {
            List<string> tokens = base.InitializeHighlightTokens();
            tokens.AddRange(new string[] {
                "PivotGroupInterval",
                "PivotArea",
                "PivotGridField",
                "DateTime",
                "DockStyle",
                "List",
                "EventHandler",
                "Dictionary",
                "Convert",
                "Size",
                "Point",
                "Rectangle",
                "UserLookAndFeel",
                "Cursor",
                "DefaultBoolean",
                "RectangleF",
                "SizeF",
                "FormStartPosition",
                "XtraForm"
            });
            return tokens;
        }
        protected override List<string> InitializeReferences() {
            List<string> referenceList = base.InitializeReferences();
            referenceList.AddRange(new string[] {
                "DevExpress.DemoData" + AssemblyInfo.VSuffix,
                "DevExpress.BonusSkins" + AssemblyInfo.VSuffix,
                "DevExpress.XtraBars" + AssemblyInfo.VSuffix,
                "DevExpress.XtraEditors" + AssemblyInfo.VSuffix,
                "DevExpress.XtraPivotGrid" + AssemblyInfo.VSuffix,
                "DevExpress.XtraLayout" + AssemblyInfo.VSuffix,
                "DevExpress.XtraPrinting" + AssemblyInfo.VSuffix,
                "DevExpress.Printing" + AssemblyInfo.VSuffix + ".Core",
                "DevExpress.PivotGrid" + AssemblyInfo.VSuffix + ".Core",
             });
            return referenceList;
        }
        protected override void DoHide() {
            base.DoHide();
            TutorialControl.FindPivotGridAndHideCustForm(this);
        }
    }
}
