using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbScrollBars>
using DevExpress.XtraEditors.Controls;
// </icbScrollBars>
using System.Windows.Forms;
using DevExpress.Tutorials;
using DevExpress.XtraEditors.TextEditController;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
	public partial class ModuleMemoEdit : TutorialControl  {
		public ModuleMemoEdit() {
			InitializeComponent();
            InitializeDefaultColors();
            tabPane1.SizeChanged += OnGeneralUserControlSizeChanged;
            this.tabPane1.SelectedPageChanged += SelectedPageChanged;
        }
        private void OnGeneralUserControlSizeChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        private void SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            this.sidePanel1.Visible = e.Page.Caption.Contains("Highlight");
            CalcContentCore();
        }


        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleMemoEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "memoedit"; } }
        bool updateValues = false;

		private void ModuleMemoEdit_Load(object sender, System.EventArgs e) {
			ControlUtils.CenterControlInParent(memoEditSample);
            this.commentColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.numberColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.stringColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.keywordColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            memoEditSample.Text = @"MemoEdit is a multi-line text editor. In addition to the advanced text input features derived from the TextEdit control, it offers numerous options for multi-line text management.

- Optional ENTER and TAB key processing.
- Customizable visibility for vertical and horizontal scrollbars.
- Optional text word-wrapping.
- Specifying height in text lines (if used within a container control such as the XtraGrid, XtraTreeList, and XtraVerticalGrid).";
            memoEdit1.Text = @"-- Create a database
DROP DATABASE IF EXISTS myDataBase;
CREATE DATABASE myDataBase;
USE myDataBase;

-- Create a table
DROP TABLE IF EXISTS fruits;
CREATE TABLE fruits (id INTEGER NOT NULL PRIMARY KEY, name VARCHAR(20), cnt INTEGER);
INSERT INTO fruits (name, cnt) VALUES ('orange', 1500);
INSERT INTO fruits (name, cnt) VALUES ('apple', 2000);
INSERT INTO fruits (name, cnt) VALUES ('pineapple', 500);

-- Select
SELECT * FROM fruits;

-- Update
UPDATE fruits SET cnt = 400 WHERE id = 2;
SELECT * FROM fruits;

-- Delete
DELETE FROM fruits WHERE id = 1;
SELECT * FROM fruits;
";
			InitComboBoxes();
			InitValues();
		}
        protected override void CalcContentCore() {
            if(!Visible || !IsHandleCreated)
                return;
            CalcLayoutControlBounds(layoutControl1);
        }
		void InitComboBoxes() {
			// <icbScrollBars>
            icbScrollBars.Properties.Items.AddEnum(typeof(ScrollBars)); 
			// </icbScrollBars>
		}
		
		void InitValues() {
			updateValues = true;
			icbScrollBars.EditValue = memoEditSample.Properties.ScrollBars;
			ceWordWrap.Checked = memoEditSample.Properties.WordWrap;
			ceReturn.Checked = memoEditSample.Properties.AcceptsReturn;
			ceTab.Checked = memoEditSample.Properties.AcceptsTab;
			seMaxLength.Value = memoEditSample.Properties.MaxLength;
			updateValues = false;
		}

		// <icbScrollBars>
		private void icbScrollBars_SelectedIndexChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.ScrollBars = (ScrollBars)icbScrollBars.EditValue;
		}
		// </icbScrollBars>

		// <ceWordWrap>
		private void ceWordWrap_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.WordWrap = ceWordWrap.Checked;
		}
		// </ceWordWrap>

		// <ceReturn>
		private void ceReturn_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.AcceptsReturn = ceReturn.Checked;
		}
		// </ceReturn>

		// <ceTab>
		private void ceTab_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.AcceptsTab = ceTab.Checked;
		}
		// </ceTab>

		// <seMaxLength>
		private void seMaxLength_EditValueChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.MaxLength = Convert.ToInt32(seMaxLength.Value);
		}
        // </seMaxLength>
        Color KeywordColor { get; set; }
        Color StringColor { get; set; }
        Color CommentColor { get; set; }
        Color NumberColor { get; set; }
        void InitializeDefaultColors() {
            KeywordColor = this.keywordColorPickEdit.Color;
            StringColor = this.stringColorPickEdit.Color;
            CommentColor = this.commentColorPickEdit.Color;
            NumberColor = this.numberColorPickEdit.Color;
            this.memoEdit1.UpdateTextHighlight();
        }

        //<memoEdit1>
        void OnCustomHighlightText(object sender, TextEditCustomHighlightTextEventArgs e) {
            HighlightKeyword(e);
            HighlightNumbers(e);
            HighlightStrings(e);
            HighlightComment(e);
        }

        void HighlightComment(TextEditCustomHighlightTextEventArgs e) {
            string text = e.Text;
            int index = text.IndexOf("--");
            if(index != -1)
                e.HighlightRange(index, text.Length - index, CommentColor);
        }
        string Keywords = "select;delete;from;insert;into;table;primary;key;varchar;integer;drop;if;exists;create;use;set;values;update;where;database;not;null";
        string[] keywordList;
        string[] KeywordList {
            get {
                if(keywordList == null)
                    keywordList = Keywords.Split(';');
                return keywordList;
            }
        }
        void HighlightKeyword(TextEditCustomHighlightTextEventArgs e) {
            for(int i = 0; i < KeywordList.Length; i++) {
                e.HighlightWords(KeywordList[i], KeywordColor);
            }
        }

        static readonly char StringStartChar = '\'';
        void HighlightStrings(TextEditCustomHighlightTextEventArgs e) {
            string text = e.Text;
            int length = text.Length;
            int startTextIndex = -1;
            while(startTextIndex < length) {
                startTextIndex = text.IndexOf(StringStartChar, startTextIndex + 1);
                if(startTextIndex == -1) break;
                int endTextIndex = text.IndexOf(StringStartChar, startTextIndex + 1);
                if(endTextIndex == -1)
                    endTextIndex = length;
                e.HighlightRange(startTextIndex, endTextIndex - startTextIndex + 1, StringColor);
                startTextIndex = endTextIndex;
            }
        }
        void HighlightNumbers(TextEditCustomHighlightTextEventArgs e) {
            string text = e.Text;
            int length = text.Length;
            int startWordIndex = 0;
            for(int i = 0; i < length; i++) {
                var ch = text[i];
                if(char.IsWhiteSpace(ch) || char.IsSeparator(ch) || char.IsPunctuation(ch)) {
                    if(startWordIndex != -1 && i - startWordIndex > 0)
                        e.HighlightRange(startWordIndex, i - startWordIndex, NumberColor);
                    startWordIndex = i + 1;
                    continue;
                }
                if(!char.IsNumber(ch)) startWordIndex = -1;
            }
            if(startWordIndex != -1)
                e.HighlightRange(startWordIndex, length - startWordIndex, NumberColor);
        }
        //</memoEdit1>

        private void OnTextColorChanged(object sender, EventArgs e) {
            this.memoEdit1.Properties.Appearance.ForeColor = this.textColorPickEdit.Color;
        }
        private void OnKeywordColorChanged(object sender, EventArgs e) {
            InitializeDefaultColors();
        }
        private void OnStringColorChanged(object sender, EventArgs e) {
            InitializeDefaultColors();
        }
        private void OnNumberColorChanged(object sender, EventArgs e) {
            InitializeDefaultColors();
        }
        private void OnCommentColorChanged(object sender, EventArgs e) {
            InitializeDefaultColors();
        }
    }
}

