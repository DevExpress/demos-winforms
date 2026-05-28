using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraDiagram.Demos {
    public class frmMain : RibbonMainForm {
        protected override void SetFormParam() {
            var assembly = typeof(frmMain).Assembly;
            this.Icon = ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(x => x.Contains("DemoIcon.ico")), assembly);
        }
        protected override void ShowAbout() {
            DiagramControl.About();
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowDiagramModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, true, NavBarImage.Large);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override int CustomWidth { get { return 1350; } }
        protected override int CustomHeight { get { return 950; } }

        protected override string DemoName {
            get { return "WinForms Diagram Control"; }
        }
        protected override string ProductName {
            get { return "XtraDiagramControl"; }
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
    }
}
