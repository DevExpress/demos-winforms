using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.Drawing;

namespace DevExpress.ProductsDemo.Win.Controls {
    public partial class ExportControl : RibbonApplicationUserControl {
        public ExportControl() {
            InitializeComponent();
        }
        List<DXImageFormat> formats = new List<DXImageFormat> { DXImageFormat.Bmp, DXImageFormat.Gif, DXImageFormat.Jpeg, DXImageFormat.Png, DXImageFormat.Tiff, DXImageFormat.Emf, DXImageFormat.Wmf, DXImageFormat.Png };
        private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            string index = string.Format("{0}", e.Item.Tag);
            frmMain frm = BackstageView.Ribbon.FindForm() as frmMain;
            if(frm == null) return;
            if(index.Contains("PDF"))
                saveFileDialog1.Filter = Properties.Resources.PDFFilter;
            else if(index.Contains("HTML"))
                saveFileDialog1.Filter = Properties.Resources.HTMLFilter;
            else if(index.Contains("MHT"))
                saveFileDialog1.Filter = Properties.Resources.MHTFilter;
            else if(index.Contains("RTF"))
                saveFileDialog1.Filter = Properties.Resources.RTFFilter;
            else if(index.Contains("XLS"))
                saveFileDialog1.Filter = Properties.Resources.XLSFilter;
            else if(index.Contains("XLSX"))
                saveFileDialog1.Filter = Properties.Resources.XLSXFilter;
            else if(index.Contains("CSV"))
                saveFileDialog1.Filter = Properties.Resources.CSVFilter;
            else if(index.Contains("Text"))
                saveFileDialog1.Filter = Properties.Resources.TextFilter;
            else if(index.Contains("Image"))
                saveFileDialog1.Filter = Properties.Resources.ImageFilter;
            saveFileDialog1.Filter += "|" + Properties.Resources.AllFilesFilter;
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.FileName = frm.CurrentModuleName;
            if(saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            Cursor.Current = Cursors.WaitCursor;
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = frm.CurrentExportComponent;
            link.CreateDocument();
            ExportTo(index, saveFileDialog1.FileName, ps);
        }
        static void ShowExportErrorMessage() {
            XtraMessageBox.Show(Properties.Resources.ExportErrorText, Properties.Resources.Export, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void ExportTo(string index, string fileName, PrintingSystem ps) {
            if(!String.IsNullOrEmpty(fileName))
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    if(index.Contains("PDF")) ps.ExportToPdf(fileName);
                    else if(index.Contains("HTML")) ps.ExportToHtml(fileName);
                    else if(index.Contains("MHT")) ps.ExportToMht(fileName);
                    else if(index.Contains("RTF")) ps.ExportToRtf(fileName);
                    else if(index.Contains("XLS")) ps.ExportToXls(fileName);
                    else if(index.Contains("XLSX")) ps.ExportToXlsx(fileName);
                    else if(index.Contains("CSV")) ps.ExportToCsv(fileName);
                    else if(index.Contains("Text")) ps.ExportToText(fileName);
                    else if(index.Contains("Image"))
                        ps.ExportToImage(fileName, formats[saveFileDialog1.FilterIndex]);
                    Cursor.Current = Cursors.Default;
                    if(XtraMessageBox.Show(Properties.Resources.OpentFileQuestion, Properties.Resources.Export, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        Data.Utils.SafeProcess.Start(saveFileDialog1.FileName);
                    }
                } catch {
                    ShowExportErrorMessage();
                } finally {
                    Cursor.Current = Cursors.Default;
                }
        }
    }
}
