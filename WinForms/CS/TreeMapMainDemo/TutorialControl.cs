using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Native;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class TreeMapTutorialControl : TutorialControlBase, IDXMenuManager {
        readonly Dictionary<string, DXImageFormat> imageFormats = new Dictionary<string, DXImageFormat>() {
            { "bmp", DXImageFormat.Bmp },
            { "jpeg", DXImageFormat.Jpeg },
            { "gif", DXImageFormat.Gif },
            { "tiff", DXImageFormat.Tiff },
            { "png", DXImageFormat.Png }
        };
        public TreeMapTutorialControl() {
            AutoMergeRibbon = true;
            SuspendLayout();
            Name = "TreeTreeMapTutorialControl";
            Size = new Size(500, 500);
            ResumeLayout(false);
        }

        public override bool AutoMergeRibbon { get { return true; } set { } }
        public IDXMenuManager MenuManager { get; set; }
        public bool ShouldSerializeMenuManager() {
            return MenuManager != null;
        }
        public void ResetMenuManager() {
            MenuManager = null;
        }
        public virtual Control ActiveDemoModule { get { return null; } }
        IComponentExportable ComponentExportable { get { return ActiveDemoModule as IComponentExportable; } }
        IComponentPrintable ComponentPrintable { get { return ActiveDemoModule as IComponentPrintable; } }

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

        protected void InitializeControls(SunburstControl sunburstControl, ComboBoxEdit colorizerComboBoxEdit, LayoutControlItem varyColorInGroupLCI, LayoutControlItem modeLCI) {
            DemoHelpersContainer.AddControl(sunburstControl, colorizerComboBoxEdit, varyColorInGroupLCI, modeLCI);
        }
        protected void InitializeControls(SunburstControl sunburstControl) {
            DemoHelpersContainer.AddControl(sunburstControl);
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true,
                ExportFormats.PDF | ExportFormats.MHT | ExportFormats.RTF | ExportFormats.XLS | ExportFormats.XLSX | ExportFormats.Image,
                false);
        }
        protected override void ExportToCore(string filename, string ext) {
            if(ComponentExportable != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                if(ext == "rtf")
                    ComponentExportable.ExportToRtf(filename);
                else if(ext == "pdf")
                    ComponentExportable.ExportToPdf(filename);
                else if(ext == "mht")
                    ComponentExportable.ExportToMht(filename);
                else if(ext == "xls")
                    ComponentExportable.ExportToXls(filename);
                else if(ext == "xlsx")
                    ComponentExportable.ExportToXlsx(filename);
                Cursor.Current = currentCursor;
            }
        }
        protected override void ExportToImage() {
            if(ComponentExportable == null)
                return;
            string fileName = MainFormHelper.GetFileName("", GetImageFormatsFilter());
            if(!string.IsNullOrEmpty(fileName)) {
                if(ComponentExportable != null)
                    ComponentExportable.ExportToImage(fileName, imageFormats[Path.GetExtension(fileName).TrimStart('.').ToLower()]);
            }
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
            if(ComponentPrintable != null)
                ComponentPrintable.ShowPrintPreview();
        }
        protected override void Print() {
            if(ComponentPrintable != null)
                ComponentPrintable.Print();
        }
    }
}
