using DevExpress.Office;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public class CustomsRichEditCommandFactoryService : IRichEditCommandFactoryService {
        readonly IRichEditCommandFactoryService _service;
        readonly RichEditControl _control;
        readonly ButtonEdit _searchTextBox;

        public CustomsRichEditCommandFactoryService(RichEditControl richEditControl, IRichEditCommandFactoryService richEditCommandFactoryService, ButtonEdit searchTextBox) {
            _control = richEditControl;
            _service = richEditCommandFactoryService;
            _searchTextBox = searchTextBox;
        }

        RichEditCommand IRichEditCommandFactoryService.CreateCommand(RichEditCommandId id) {
            if(id.Equals(RichEditCommandId.Find))
                return new CustomFindCommand(_control, _searchTextBox);
            return _service.CreateCommand(id);
        }
    }
    public class CustomFindCommand : FindCommand {
        readonly ButtonEdit _searchTextBox;
        readonly char[] _separators = new char[] { Characters.ParagraphMark, Characters.PageBreak, Characters.TabMark };

        public CustomFindCommand(IRichEditControl richEditControl, ButtonEdit searchTextBox)
            : base(richEditControl) {
            _searchTextBox = searchTextBox;
        }

        protected override void ShowForm(string searchString) {
            _searchTextBox.Focus();
            string selectedText = Control.Document.GetText(Control.Document.Selection);
            if(string.IsNullOrEmpty(selectedText) || selectedText.IndexOfAny(_separators) >= 0)
                return;
            _searchTextBox.Text = selectedText.Trim();
        }
    }
}
