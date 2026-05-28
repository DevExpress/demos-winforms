using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MVVM.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                CodeTutorialControlBase ctcb = item.TModule as CodeTutorialControlBase;
                if(ctcb != null)
                    ctcb.SelectExampleByName(item.CodeExampleName);
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
        public static string GetLoremIpsumText(int seed) {
            return string.Format("{0} {1}", texts[seed % texts.Length], texts[(seed + 2) % texts.Length]);
        }
        static string[] texts = new string[] {
            "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.",
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.",
            "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."
        };
    }
    //
    public class TutorialControl : TutorialControlBase {
        public TutorialControl() {
            this.Padding = new Padding(0);
        }
        protected void LoadSourceCode(RichEditUserControl sourceCode, string methodName, System.Type moduleType = null, bool append = false) {
            sourceCode.richEditControl.InitializeDocument += (s, e) =>
                sourceCode.InitializeSyntaxHighlight(ExampleLanguage.Csharp);
            string code = CodeTutorialControlBase.GetModuleMethodCode(moduleType ?? GetType(), methodName);
            sourceCode.RichText = append ? sourceCode.RichText + System.Environment.NewLine + code : code;
            sourceCode.richEditControl.ReadOnly = true;
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateRibbonPanelStyleAndPadding(GetActiveLookAndFeel());
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateRibbonPanelStyleAndPadding(GetActiveLookAndFeel());
        }
        RibbonControl ribbonControl;
        void UpdateRibbonPanelStyleAndPadding(LookAndFeel.UserLookAndFeel lf) {
            if(ribbonControl == null) {
                var ribbons = this.Controls.Find("ribbonControl", false);
                ribbonControl = (ribbons != null && ribbons.Length > 0) ? ribbons[0] as RibbonControl : null;
            }
            if(ribbonControl != null) {
                bool isWXI = (lf.SkinName == DevExpress.LookAndFeel.SkinStyle.WXI);
                ribbonControl.ItemPanelStyle = isWXI ? RibbonItemPanelStyle.Classic : RibbonItemPanelStyle.Default;
            }
        }
    }
    //
    public class CodeTutorialControl : CodeTutorialControlBase {
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override List<string> InitializeHighlightTokens() {
            return new List<string>() {
                "IDisposable",
                "ISupportInitialize",
                "Environment",
                "XtraForm",
                "XtraUserControl",
                "FormShowMode",
                "Container",
                "IContainer",
                "ComponentResourceManager",
                "Padding",
                "AutoScaleMode",
                "FormBorderStyle",
                "FormStartPosition",
                "Point",
                "Size",
                "SizeF",
                "BindingSource",
                "Binding",
                "DataSourceUpdateMode",
                "IDataErrorInfo",
                "FormatException",
                "IList",
                "Assets",
                "MVVMContext",
                "ViewModelSource",
                "IDispatcherService",
                "IMessageBoxService",
                "IDialogService",
                "IDocumentManagerService",
                "INavigationService",
                "ISupportNavigation",
                "IDocument",
                "TablePanelColumn",
                "TablePanelRow",
                "TableColumnDefinition",
                "TableRowDefinition",
                "TableSpan",
                "ItemTemplateBase",
                "SimpleContextButton",
                "ListBoxControl",
                "SearchControl",
                "ToggleSwitch",
                "TablePanel",
                "ContextItemPanel",
                "ContextItemPosition",
                "DockStyle",
                "TablePanelEntityStyle",
                "TableDefinitionLengthType",
                "TileItemContentAlignment",
                "DXSkinColors",
                "TileItemImageScaleMode",
                "ListBoxControlContextButtonCustomizeEventHandler",
                "ListBoxControlContextButtonCustomizeEventArgs",
                "CustomizeTemplatedItemEventHandler",
                "CustomizeTemplatedItemEventArgs",
                "EditorButton",
                "ClearButton",
                "SearchButton",
                "VertAlignment",
                "HorzAlignment",
                "LabelAutoSizeMode",
                "PaintStyles",
                "TemplatedItemElement",
                "ISupportParameter",
                "ServiceContainer",
                "Messenger",
            };
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
    }
}

namespace DevExpress.MVVM.Demos.CodeExamples {
    using DevExpress.DXperience.Demos.CodeDemo;
    public class TodoAppDescription : CodeExampleResourceFile {
        public TodoAppDescription(string fileName)
            : base(typeof(TodoAppDescription).Assembly.FullName, GetResourceName(fileName)) {
            Name = "[Description]";
        }
        static string GetResourceName(string fileName) {
#pragma warning disable DX0025 // no path traversal (predefined paths)
            const string resourcePath = "DevExpress.MVVM.Demos.Resources.TodoApp.Descriptions.";
            return (DemoHelper.IsCSharp ? resourcePath : string.Empty) + fileName + ".md";
#pragma warning restore DX0025
        }
        Dictionary<string, string> replacements;
        public override IDictionary<string, string> Replacements {
            get {
                if(CodeExample == null)
                    return null;
                if(replacements == null) {
                    replacements = new Dictionary<string, string> {
                        { "$CodeExampleName$", CodeExample.Name },
                        { "$CodeExampleGroupName$", CodeExample.GroupName },
                    };
                }
                return replacements;
            }
        }
    }
}
