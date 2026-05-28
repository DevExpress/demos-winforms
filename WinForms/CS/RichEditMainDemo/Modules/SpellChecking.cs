using DevExpress.XtraBars;
using DevExpress.XtraSpellChecker;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SpellCheckingModule : TutorialControl {
        public SpellCheckingModule() {
            InitializeComponent();
            ribbonControl1.SelectedPage = ribbonControl1.Pages["Review"];
            LoadDocument("SpellChecker.rtf");
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }

        void barCheckItem1_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            spellChecker1.SpellCheckMode = (sender as BarCheckItem).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
        }
    }
}
