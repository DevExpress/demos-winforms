using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraTab;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SpreadsheetPreview : UserControl {
        readonly Dictionary<PrintControl, PrintableComponentLinkBase> pcCache;
        SpreadhsheetPreviewZoom _previewZoom = SpreadhsheetPreviewZoom.Default;
        public SpreadsheetPreview() {
            InitializeComponent();
            pcCache = new Dictionary<PrintControl, PrintableComponentLinkBase>();
            xtraTabControl1.TabPages.Clear();
            UpdatePreview();
        }

        [DefaultValue(false)]
        public bool CanShowBorders { get; set; }

        public IWorkbook Workbook { get; set; }
        public bool ShouldSerializeWorkbook() {
            return Workbook != null;
        }
        public void ResetWorkbook() {
            Workbook = null;
        }

        [DefaultValue(SpreadhsheetPreviewZoom.Default)]
        public SpreadhsheetPreviewZoom PreviewZoom {
            get { return _previewZoom; }
            set {
                if(_previewZoom == value)
                    return;
                _previewZoom = value;
                UpdatePreview();
            }
        }
        public void UpdatePreview() {
            if(Workbook == null)
                return;
            int count = Workbook.Worksheets.Count;
            documentViewerSinglePreview.Visible = false;
            xtraTabControl1.Visible = false;
            if(count < 2)
                UpdateWorkbookSinglePreview();
            else
                UpdateMultipleSheetPreview();
        }
        void UpdateWorkbookSinglePreview() {
            documentViewerSinglePreview.Visible = true;
            UpdateDocumentViewerProperties(documentViewerSinglePreview);
            if(documentViewerSinglePreview.PrintingSystem == null)
                documentViewerSinglePreview.PrintingSystem = new PrintingSystemBase();
            PrintableComponentLinkBase link = new PrintableComponentLinkBase(documentViewerSinglePreview.PrintingSystem);
            link.Component = Workbook;
            link.CreateDocument();
            UpdateDocumentViewerZoom(documentViewerSinglePreview);
        }
        void UpdateMultipleSheetPreview() {
            xtraTabControl1.Visible = true;
            int count = Workbook.Worksheets.Count;
            List<PrintControl> usedPrintControls = new List<PrintControl>();
            for(int i = 0; i < count; i++) {
                Worksheet sheet = Workbook.Worksheets[i];
                PrintControl pc = EnsurePrintControl(i, sheet.Name);
                PrintableComponentLinkBase link = ObtainLinkFrom(pc);
                UpdateSheetPreview(sheet, link);
                usedPrintControls.Add(pc);
            }
            ClearPrintControlCache(usedPrintControls);
        }
        void ClearPrintControlCache(List<PrintControl> usedPrintControls) {
            List<PrintControl> toClear = new List<PrintControl>();
            foreach(KeyValuePair<PrintControl, PrintableComponentLinkBase> pc in pcCache) {
                if(!usedPrintControls.Contains(pc.Key))
                    toClear.Add(pc.Key);
            }
            foreach(PrintControl item in toClear)
                pcCache.Remove(item);
        }
        void UpdateSheetPreview(Worksheet sheet, PrintableComponentLinkBase link) {
            IBasePrintable printable = sheet as IBasePrintable;
            link.Component = printable;
            link.CreateDocument();
        }
        PrintableComponentLinkBase ObtainLinkFrom(PrintControl pc) {
            PrintableComponentLinkBase link = null;
            if(pcCache.TryGetValue(pc, out link))
                return link;
            link = new PrintableComponentLinkBase(pc.PrintingSystem);
            pcCache.Add(pc, link);
            return link;
        }
        PrintControl EnsurePrintControl(int i, string caption) {
            XtraTabPageCollection tabPages = xtraTabControl1.TabPages;
            XtraTabPage page = (i < tabPages.Count) ? tabPages[i] : CreateNewTabPage();
            page.Text = caption;
            if(page.Controls.Count == 1 && page.Controls[0] is PrintControl)
                return page.Controls[0] as PrintControl;
            PrintControl pc = new PrintControl();
            pc.PrintingSystem = new PrintingSystemBase();
            pc.Dock = DockStyle.Fill;
            page.Controls.Clear();
            page.Controls.Add(pc);
            UpdatePrintControlProperties(pc);
            return pc;
        }
        void UpdateDocumentViewerProperties(XtraPrinting.Preview.DocumentViewer documentViewer) {
            if(documentViewer == null || CanShowBorders)
                return;
            documentViewer.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None;
            documentViewer.ShowPageMargins = false;
            if(documentViewer.PrintingSystem != null)
                documentViewer.PrintingSystem.Graph.PageBackColor = Color.Gray;
            documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);
        }
        void UpdateDocumentViewerZoom(XtraPrinting.Preview.DocumentViewer documentViewer) {
            if(documentViewer == null || PreviewZoom == SpreadhsheetPreviewZoom.Default)
                return;
            documentViewer.ShowPageMargins = false;
            if(PreviewZoom == SpreadhsheetPreviewZoom.WholePage) {
                documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);
                documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage);
                documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ScrollPageUp);
            }
            else documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToTwoPages);
        }
        void UpdatePrintControlProperties(PrintControl pc) {
            if(pc == null || CanShowBorders)
                return;
            pc.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None;
            pc.ShowPageMargins = false;
            pc.PrintingSystem.Graph.PageBackColor = Color.Gray;
            pc.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);
        }
        XtraTabPage CreateNewTabPage() {
            XtraTabPage tabPage = new XtraTabPage();
            xtraTabControl1.TabPages.Add(tabPage);
            return tabPage;
        }
    }
    public enum SpreadhsheetPreviewZoom {
        Default,
        WholePage,
        TwoPages
    }
}
