using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraCharts.Demos {

    public partial class ChartDemoModule : TutorialControlBase {
        readonly Dictionary<string, DXImageFormat> imageFormats = new Dictionary<string, DXImageFormat>() {
            { "bmp", DXImageFormat.Bmp },
            { "jpeg", DXImageFormat.Jpeg },
            { "gif", DXImageFormat.Gif },
            { "tiff", DXImageFormat.Tiff },
            { "png", DXImageFormat.Png }
        };
        string paletteName = "Default";

        internal virtual List<ChartControl> ChartControls {
            get { return null; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PaletteName {
            get { return paletteName; }
            set {
                List<ChartControl> chartControlsCache = ChartControls;
                if(chartControlsCache == null && ChartControl != null)
                    chartControlsCache = new List<ChartControl>() { ChartControl };
                if(chartControlsCache != null) {
                    foreach(ChartControl chart in chartControlsCache) {
                        try {
                            chart.PaletteName = value;
                            paletteName = value;
                        }
                        catch(ArgumentException exception) {
                            Debug.WriteLine(string.Format("Warning: impossible to set the '{0}' palette.\n{1}", value, exception.Message));
                        }
                    }
                }
                OnPaletteChanged();
            }
        }
        internal ChartRibbonMenuManager ChartRibbonMenuManager {
            get { return RibbonMenuManager as ChartRibbonMenuManager; }
        }
        internal virtual ChartControl ChartControl {
            get { return null; }
        }
        internal virtual object ExportedObject {
            get { return ChartControl; }
        }
        internal virtual bool ChartDesignerEnabled {
            get { return true; }
        }
        internal virtual bool PaletteButtonEnabled {
            get { return true; }
        }
        public override bool AllowPrintOptions {
            get { return ChartControl != null; }
        }

        internal ChartDemoModule() {
            InitializeComponent();
        }

        protected virtual void OnPaletteChanged() {
        }
        protected internal virtual void BeforeChartDesignerShown() {
        }
        protected internal virtual void OnChartDesignerClosed() {
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            AllowExport();
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            OnPaletteChanged();
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true,
                ExportFormats.Image |
                ExportFormats.SVG |
                ExportFormats.PDF |
                ExportFormats.HTML |
                ExportFormats.MHT |
                ExportFormats.XLS |
                ExportFormats.RTF |
                ExportFormats.XLSX |
                ExportFormats.DOCX,
                false);
        }
        protected override void ExportToCore(string filename, string ext) {
            ChartControl chart = ChartControl;
            if(chart != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
                if(ext == "rtf")
                    chart.ExportToRtf(filename);
                else if(ext == "pdf") {
                    chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile;
                    PdfExportOptions options = new PdfExportOptions();
                    options.ConvertImagesToJpeg = false;
                    chart.ExportToPdf(filename, options);
                }
                else if(ext == "mht")
                    chart.ExportToMht(filename);
                else if(ext == "html")
                    chart.ExportToHtml(filename);
                else if(ext == "xls")
                    chart.ExportToXls(filename);
                else if(ext == "xlsx")
                    chart.ExportToXlsx(filename);
                else if(ext == "svg")
                    chart.ExportToSvg(filename);
                else if(ext == "docx")
                    chart.ExportToDocx(filename);
                Cursor.Current = currentCursor;
            }
        }
        protected override void ExportToImage() {
            ChartControl chart = ChartControl;
            if(chart != null) {
                chart.OptionsPrint.SizeMode = PrintSizeMode.None;

                IEnumerable<string> formats = imageFormats.Keys;
                string fileFormat = string.Empty;
                foreach(string format in formats)
                    fileFormat += string.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower());
                fileFormat = fileFormat.TrimEnd('|');
                string filePath = MainFormHelper.GetFileName("", fileFormat);

                if(!string.IsNullOrEmpty(filePath)) {
                    string extension = Path.GetExtension(filePath).TrimStart('.').ToLower();
                    if(!string.IsNullOrEmpty(extension))
                        chart.ExportToImage(filePath, imageFormats[extension]);
                }
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
        protected override void ExportToSVG() {
            ExportTo("svg", "SVG document (*.svg)|*.svg");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", "DOCX document (*.docx)|*.docx");
        }
        protected override void PrintPreview() {
            ChartControl chart = ChartControl;
            if(chart != null) {
                chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
                chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile;
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    chart.ShowRibbonPrintPreview();
                else
                    chart.ShowPrintPreview();
            }
        }
    }
}
