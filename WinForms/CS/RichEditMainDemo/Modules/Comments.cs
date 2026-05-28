using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class CommentsModule : TutorialControl {
        public CommentsModule() {
            InitializeComponent();
            RibbonControl ribbonControl = richEditControl.CreateRibbon(RichEditToolbarType.File | RichEditToolbarType.Home | RichEditToolbarType.Review);
            Controls.Add(ribbonControl);
            ribbonControl.SelectedPage = ribbonControl.Pages["Review"];
            LoadDocument("Comments.docx");
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }
    }
}
