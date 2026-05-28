using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGauges.Core.Printing;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos {
    public class TutorialControl : TutorialControlBase {
        public virtual bool ShowExportMenu {
            get { return false; }
        }
        public virtual GaugeControl ExportControl {
            get { return null; }
        }
        protected override string ModulesFolder {
            get { return @"GaugesMainDemo\ModulesAnyControl"; }
        }
        protected override string CodeInfoFolder {
            get { return "DevExpress.XtraGauges.Demos.CodeInfo"; }
        }
        #region Print and Export
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.Image | ExportFormats.XLS, true);
        }
        public override bool AllowPrintOptions {
            get { return ExportControl != null; }
        }
        protected override void ExportToImage() {
            if(ExportControl == null) 
                return;
            string fileName = MainFormHelper.GetFileName("", "BMP Image (*.bmp)|*.bmp|GIF Image (*.gif)|*.gif|PNG Image (*.png)|*.png|JPEG Image (*.jpeg)|*.jpeg");
            if(!string.IsNullOrEmpty(fileName)) {
                string extension = Path.GetExtension(fileName);
                switch(extension.ToLowerInvariant()) {
                    case ".bmp":
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Bmp);
                        break;
                    case ".gif":
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Gif);
                        break;
                    case ".png":
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Png);
                        break;
                    case ".jpeg":
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Jpeg);
                        break;
                    default:
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Png);
                        break;
                }
            }
        }
        protected override void ExportToCore(string filename, string ext) {
            if(ExportControl == null) 
                return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename);
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            Cursor.Current = currentCursor;
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
        protected override void PrintPreview() {
            if(ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportControl.ShowRibbonPrintPreview(PrintSizeMode.None);
                else ExportControl.ShowPrintPreview(PrintSizeMode.None);
            }
        }
        #endregion
    }
    public class GaugesRibbonMenuManager : RibbonMenuManager {
        public GaugesRibbonMenuManager(RibbonMainForm parentForm)
            : base(parentForm) {
        }
    }
}
