using System;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class DocumentStatisticsForm : XtraForm {
        readonly SubDocument document;

        public DocumentStatisticsForm(SubDocument document, bool includeTextboxes) {
            InitializeComponent();
            this.document = document;
            chkIncludeTextboxes.Checked = includeTextboxes;
            CalculateStatistics();
        }

        public bool IncludeTextboxes { get { return chkIncludeTextboxes.Checked; } }

        void OnIncludeTextboxesCheckedChanged(object sender, EventArgs e) {
            CalculateStatistics();
        }
        void CalculateStatistics() {
            DocumentIterator iterator = new DocumentIterator(document, true);
            StaticsticsVisitor visitor = new StaticsticsVisitor(IncludeTextboxes);
            while(iterator.MoveNext())
                iterator.Current.Accept(visitor);
            lblNoSpacesCharactersCount.Text = String.Format("{0,5}", visitor.NoSpacesCharacterCount);
            lblWithSpacesCharactersCount.Text = String.Format("{0,5}", visitor.WithSpacesCharacterCount);
            lblWordsCount.Text = String.Format("{0,5}", visitor.WordCount);
            lblParagraphsCount.Text = String.Format("{0,5}", visitor.ParagraphCount);
        }

        void OnCloseClick(object sender, EventArgs e) {
            Close();
        }
    }
    public class StaticsticsVisitor : DocumentVisitorBase {
        readonly StringBuilder _buffer;
        readonly bool includeTextboxes;
        int _noSpacesCharacterCount;
        int _withSpacesCharacterCount;
        int _wordCount;
        int _paragraphCount;

        public StaticsticsVisitor(bool includeTextboxes) {
            _buffer = new StringBuilder();
            this.includeTextboxes = includeTextboxes;
        }

        StringBuilder Buffer { get { return _buffer; } }
        public int NoSpacesCharacterCount { get { return _noSpacesCharacterCount; } }
        public int WithSpacesCharacterCount { get { return _withSpacesCharacterCount; } }
        public int WordCount { get { return _wordCount; } }
        public int ParagraphCount { get { return _paragraphCount; } }

        public override void Visit(DocumentText text) {
            Buffer.Append(text.Text);
        }

        public override void Visit(DocumentTextBox textBox) {
            if(!includeTextboxes) return;
            DocumentIterator iterator = textBox.GetIterator(true);
            StaticsticsVisitor visitor = new StaticsticsVisitor(false);
            while(iterator.MoveNext())
                iterator.Current.Accept(visitor);
            _noSpacesCharacterCount += visitor.NoSpacesCharacterCount;
            _withSpacesCharacterCount += visitor.WithSpacesCharacterCount;
            _wordCount += visitor.WordCount;
            _paragraphCount += visitor.ParagraphCount;
        }
        public override void Visit(DocumentSectionEnd sectionEnd) {
            FinishParagraph();
        }
        public override void Visit(DocumentParagraphEnd paragraphEnd) {
            FinishParagraph();
        }
        void FinishParagraph() {
            string text = Buffer.ToString();
            _noSpacesCharacterCount += text.Count(c => !Char.IsWhiteSpace(c));
            _withSpacesCharacterCount += text.Length;
            _wordCount += text.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if(!string.IsNullOrWhiteSpace(text))
                _paragraphCount++;
            Buffer.Length = 0;
        }
    }
}
