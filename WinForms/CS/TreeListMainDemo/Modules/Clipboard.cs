using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraTreeList.Demos {
    public partial class ClipboardFormats : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TreeListMainDemo\\Modules\\Clipboard" }; } }
        protected override string WhatsThisXMLFileName { get { return "Clipboard"; } }
        public ClipboardFormats() {
            InitializeComponent();
            Init();
        }
        void Init() {
            propertyGridControl.SelectedObject = treeList1.OptionsClipboard;
            propertyGridControl.ExpandAllRows();
            gridViewPropertiesLayoutGroup.Expanded = false;
        }

        internal void PasteClipboardData() {
            PasteHTMLFormat();
            PasteXLSFormat();
            PasteRTFFormat();
        }
        //<richEditControl>
        void PasteRTFFormat() {
            richEditControl.Document.RtfText = string.Empty;
            richEditControl.Document.Text = string.Empty;
            try {
                if(treeList1.OptionsClipboard.ClipboardMode == Export.ClipboardMode.Formatted) {
                    string rtfText = DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.Rtf) as string;
                    richEditControl.Document.AppendRtfText(rtfText);
                }
                else {
                    string text = DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText) as string;
                    richEditControl.Document.AppendText(text);
                }
            }
            catch { }
        }
        //</richEditControl>
        protected override void OnUseEmptyRootPadding() { }
        //<spreadsheetControl1>
        void PasteXLSFormat() {
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange());
            try {
                if(treeList1.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                    var stream = DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData("Biff8") as Stream;
                    if(stream != null)
                        spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls);
                }
                else {
                    int nextRow = 0;
                    string text = DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText) as string;
                    foreach(var line in text.Split('\n')) {
                        spreadsheetControl1.ActiveWorksheet.Import(line.Split('\t'), nextRow, 0, false);
                        nextRow++;
                    }
                }
            }
            catch { }
            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width / treeList1.Columns.Count;
        }
        //</spreadsheetControl1>
        //<webBrowser1>
        void PasteHTMLFormat() {
            if(treeList1.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                try {
                    string html = DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.Html) as string;
                    if(string.IsNullOrEmpty(html)) {
                        webBrowser1.DocumentText = string.Empty;
                        return;
                    }
                    html = html.Remove(0, html.Substring(0, html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)).Length);
                    webBrowser1.DocumentText = html;
                }
                catch { }
            }
            else {
                webBrowser1.DocumentText = "<html><body><p align=\"center\">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>";
            }
        }
        //</webBrowser1>
        //<treeList1>
        void simpleButtonCopyPaste_Click(object sender, EventArgs e) {
            treeList1.CopyAndPaste();
        }
        //</treeList1>
        void layoutControl1_GroupExpandChanged(object sender, XtraLayout.Utils.LayoutGroupEventArgs e) {
            if(gridViewPropertiesLayoutGroup.Expanded) {
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            }
            else splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }

        void ClipboardFormats_Load(object sender, EventArgs e) {
            treeList1.DataSource = SalesDataGenerator.CreateData();
            treeList1.ExpandAll();
            treeList1.ForceInitialize();
            treeList1.BestFitColumns();
            treeList1.SelectCells(treeList1.Nodes[0], colRegion, treeList1.Nodes[0].LastNode, colMarketShare);
        }

        private void treeList_ShowingEditor(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }
    }
    public class ClipboardTreeListControl : TreeList {
        ClipboardFormats userControlCore;
        internal ClipboardFormats ClipboardFormats {
            get {
                if(userControlCore == null)
                    userControlCore = Parent.Parent as ClipboardFormats;
                return userControlCore;
            }
        }
        public void CopyAndPaste() {
            OnKeyDown(new KeyEventArgs(Keys.Control | Keys.C));
        }
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if(e.Control && e.KeyCode == Keys.C) {
                ClipboardFormats.PasteClipboardData();
            }
        }
    }
}
