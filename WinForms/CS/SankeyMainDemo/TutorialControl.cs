using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraCharts.Sankey;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DevExpress.XtraSankey.Demos {
    public partial class SankeyTutorialControl : TutorialControlBase, IDXMenuManager {
        readonly Dictionary<string, DXImageFormat> imageFormats = new Dictionary<string, DXImageFormat>() {
            { "bmp", DXImageFormat.Bmp },
            { "jpeg", DXImageFormat.Jpeg },
            { "gif", DXImageFormat.Gif },
            { "tiff", DXImageFormat.Tiff },
            { "png", DXImageFormat.Png }
        };
        public SankeyTutorialControl() {
            this.AutoMergeRibbon = true;
            this.SuspendLayout();
            this.Name = "SankeyTutorialControl";
            this.Size = new Size(500, 500);
            this.ResumeLayout(false);
        }
        [DefaultValue(true)]
        public override bool AutoMergeRibbon { get { return true; } set { } }
        public virtual SankeyDiagramControl SankeyDiagramControl { get { return null; } }
        public IDXMenuManager MenuManager { get; set; }
        public bool ShouldSerializeMenuManager() {
            return MenuManager != null;
        }
        public void ResetMenuManager() {
            MenuManager = null;
        }

        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }
        void IDXMenuManager.DisposeManager() { }
        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, MenuManager, control, pos);
        }
        string GetImageFormatsFilter() {
            string result = string.Empty;
            foreach(string format in imageFormats.Keys)
                result += string.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower());
            return result.TrimEnd('|');
        }

        protected override void AllowExport() {
            EnabledPrintExportActions(true, true,
                ExportFormats.PDF | ExportFormats.MHT | ExportFormats.RTF | ExportFormats.XLS | ExportFormats.XLSX | ExportFormats.Image,
                false);
        }
        protected override void ExportToCore(string filename, string ext) {
            SankeyDiagramControl sankey = SankeyDiagramControl;
            if (sankey != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                sankey.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
                if (ext == "rtf")
                    sankey.ExportToRtf(filename);
                else if (ext == "pdf")
                    sankey.ExportToPdf(filename);
                else if (ext == "mht")
                    sankey.ExportToMht(filename);
                else if (ext == "xls")
                    sankey.ExportToXls(filename);
                else if (ext == "xlsx")
                    sankey.ExportToXlsx(filename);
                Cursor.Current = currentCursor;
            }
        }
        protected override void ExportToImage() {
            if (SankeyDiagramControl == null)
                return;
            string fileName = MainFormHelper.GetFileName("", GetImageFormatsFilter());
            if (!string.IsNullOrEmpty(fileName))
                SankeyDiagramControl.ExportToImage(fileName, imageFormats[Path.GetExtension(fileName).TrimStart('.').ToLower()]);
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            if (SankeyDiagramControl != null)
                SankeyDiagramControl.ShowPrintPreview();
        }
        protected override void Print() {
            if (SankeyDiagramControl != null)
                SankeyDiagramControl.Print();
        }
    }
}
