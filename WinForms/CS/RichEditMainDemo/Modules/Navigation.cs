using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class NavigationModule : TutorialControl {
        public NavigationModule() {
            InitializeComponent();
            RibbonControl ribbonControl = richEditControl.CreateRibbon(RichEditToolbarType.File | RichEditToolbarType.Home | RichEditToolbarType.Insert | RichEditToolbarType.References);
            Controls.Add(ribbonControl);
            ribbonControl.SelectedPage = ribbonControl.Pages["References"];
            LoadDocument("Navigation.docx");
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }
    }
}
