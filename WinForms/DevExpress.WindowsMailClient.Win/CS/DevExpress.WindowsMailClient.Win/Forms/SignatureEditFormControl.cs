using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.WindowsMailClient.Win.Forms {
    public partial class SignatureEditFormControl : UserControl {
        public SignatureEditFormControl() {
            InitializeComponent();
        }
        public void LoadText(string text) {
            richEditControl1.MhtText = text;
            richEditControl1.Document.BeginUpdate();
            foreach(Paragraph p in richEditControl1.Document.Paragraphs) {
                p.LeftIndent = Units.InchesToDocumentsF(-0.09f);
            }
            richEditControl1.Document.EndUpdate();
        }
        public string GetText() {
            return richEditControl1.MhtText;
        }
    }
}
