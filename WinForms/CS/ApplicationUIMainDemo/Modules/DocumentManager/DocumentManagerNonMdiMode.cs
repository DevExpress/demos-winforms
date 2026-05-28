using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerNoDocumentsMode : TutorialControlBase {
        public DocumentManagerNoDocumentsMode() {
            InitializeComponent();
            richEditControl1.Text = DemosInfo.GetLoremIpsumText(0);
        }
    }
}
