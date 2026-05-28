
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    public partial class ComboBoxTemplateViewer : TemplateCodeViewer {
        public ComboBoxTemplateViewer() {
            InitializeComponent();
        }

        public void Fill(ComboBoxEdit cbe) {
            this.FillTemplates(cbe.Properties.HtmlTemplates);
        }
    }
}
