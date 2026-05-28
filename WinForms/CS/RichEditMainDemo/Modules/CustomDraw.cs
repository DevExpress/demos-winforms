using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Demos.Modules.CustomDraw;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class CustomDrawModule : TutorialControl {
        readonly List<FixedRange> _searchResult = new List<FixedRange>();
        int _currentItemIndex = -1;

        public CustomDrawModule() {
            InitializeComponent();
            ribbonControl1 = richEditControl.CreateRibbon();
            Controls.Add(ribbonControl1);
            LoadDocument("CustomDraw.docx");
            IRichEditCommandFactoryService commandFactoryService = richEditControl.GetService<IRichEditCommandFactoryService>();
            richEditControl.ReplaceService<IRichEditCommandFactoryService>(new CustomsRichEditCommandFactoryService(richEditControl, commandFactoryService, searchControl));
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }
        List<FixedRange> SearchResult { get { return _searchResult; } }
        int CurrentItemIndex {
            get { return _currentItemIndex; }
            set {
                if(value < 0 || value >= SearchResult.Count)
                    return;
                _currentItemIndex = value;
                FixedRange fixedRange = SearchResult[_currentItemIndex];
                DocumentRange range = richEditControl.Document.CreateRange(fixedRange.Start, fixedRange.Length);
                richEditControl.Document.ChangeActiveDocument(richEditControl.Document);
                richEditControl.Document.Selection = range;
                richEditControl.ScrollToCaret();
                UpdateSearchOptionsUI();
            }
        }
        bool IsSelectionInMainDocument { get { return !richEditControl.IsSelectionInTextBox && !richEditControl.IsSelectionInHeaderOrFooter && !richEditControl.IsSelectionInComment; } }

        void richEditControl_BeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            if(e.CanvasOwnerType == CanvasOwnerType.Printer || SearchResult.Count == 0)
                return;
            FixedRange currentItem = SearchResult[CurrentItemIndex];
            List<FixedRange> visibleSearchResult = e.Page.GetVisibleRanges(SearchResult).ToList();
            e.Painter = new CustomDrawPagePainter(richEditControl, visibleSearchResult, currentItem);
        }
        void richEditControl_ContentChanged(object sender, EventArgs e) {
            SearchResult.Clear();
        }
        void navigationButtonEdit_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {
            CurrentItemIndex += e.Button.Kind == ButtonPredefines.Down ? 1 : -1;
        }
        void searchTextBox_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {
            if(e.Button.Kind == ButtonPredefines.Close)
                searchControl.Text = string.Empty;
        }
        void searchTextBox_EditValueChanged(object sender, EventArgs e) {
            FindText();
        }
        void searchTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter)
                FindText();
            if(e.KeyData == Keys.Escape) {
                searchControl.Text = string.Empty;
                richEditControl.Focus();
            }
        }
        void OnSearchOptionsChanged(object sender, EventArgs e) {
            FindText();
        }
        void FindText() {
            SearchResult.Clear();
            string textToSearch = searchControl.Text;
            if(IsSelectionInMainDocument && !String.IsNullOrEmpty(textToSearch)) {
                SearchOptions options = GetSearchOptions();
                IEnumerable<DocumentRange> ranges = RichEdit.Document.FindAll(textToSearch, options).GetAsFrozen();
                foreach(DocumentRange range in ranges)
                    SearchResult.Add(new FixedRange(range.Start.ToInt(), range.Length));
            }

            CurrentItemIndex = 0;
            UpdateSearchOptionsUI();
            richEditControl.Refresh();
        }
        void UpdateSearchOptionsUI() {
            //this.searchResultAndButtonsGroup.Visibility = !String.IsNullOrEmpty(this.searchControl.Text) && SearchResult.Count > 0 ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            navigationButtonsEdit.ContentVisible = !String.IsNullOrEmpty(searchControl.Text) && SearchResult.Count > 0;
            foreach(EditorButton button in searchControl.Properties.Buttons) {
                button.Visible = !String.IsNullOrEmpty(searchControl.Text);
            }
            if(string.IsNullOrEmpty(searchControl.Text))
                searchText.Text = String.Empty;
            else if(SearchResult.Count == 0)
                searchText.Text = "No matches";
            else
                searchText.Text = String.Format("{0} of {1} matches", CurrentItemIndex + 1, SearchResult.Count);
        }
        SearchOptions GetSearchOptions() {
            SearchOptions result = SearchOptions.None;
            if(matchCase.Checked)
                result |= SearchOptions.CaseSensitive;
            if(findWholeWordsOnly.Checked)
                result |= SearchOptions.WholeWord;
            return result;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            BeginInvoke(new Action(FindText));
        }
    }
}
