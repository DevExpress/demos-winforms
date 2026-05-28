using System;
using System.Drawing;
using System.Drawing.Text;
using DevExpress.Skins;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomDrawModule : SpreadsheetRibbonTutorialControlBase {
        readonly string[] headers = new string[] { "Product Name", "Quantity per Unit", "Unit Price", "Units in Stock" };

        public CustomDrawModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Products_template.xlsx"));
            spreadsheetControl1.CustomDrawColumnHeader += SpreadsheetControl1_CustomDrawColumnHeader;
            spreadsheetControl1.CustomDrawColumnHeaderBackground += SpreadsheetControl1_CustomDrawColumnHeaderBackground;
            spreadsheetControl1.CustomDrawCell += SpreadsheetControl1_CustomDrawCell;
            spreadsheetControl1.CustomDrawCellBackground += SpreadsheetControl1_CustomDrawCellBackground;
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        private void SpreadsheetControl1_CustomDrawColumnHeader(object sender, CustomDrawColumnHeaderEventArgs e) {
            e.Handled = true;
            if(e.ColumnIndex > 3)
                return;
            float dpiScale = e.Cache.DeviceDpi / spreadsheetControl1.DpiY;
            SpreadsheetFont defaultFont = spreadsheetControl1.Document.Styles.DefaultStyle.Font;
            using(Font font = new Font(defaultFont.Name, (float)defaultFont.Size * dpiScale, FontStyle.Bold)) {
                using(StringFormat stringFormat = new StringFormat()) {
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = e.ColumnIndex < 2 ? StringAlignment.Near : StringAlignment.Far;
                    stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    e.Graphics.DrawString(headers[e.ColumnIndex], font, e.Cache.GetSolidBrush(Color.White), e.Bounds, stringFormat);
                }
            }
        }

        private void SpreadsheetControl1_CustomDrawColumnHeaderBackground(object sender, CustomDrawColumnHeaderBackgroundEventArgs e) {
            e.Handled = true;
            if(e.ColumnIndex <= 3)
                e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.FromArgb(91, 155, 213)), e.Bounds);
        }

        private void SpreadsheetControl1_CustomDrawCell(object sender, CustomDrawCellEventArgs e) {
            if(e.Cell.ColumnIndex != 3)
                return;
            CellValue unitsInStock = e.Cell.Value;
            string text = "OUT OF STOCK";
            if(unitsInStock.IsNumeric && unitsInStock.NumericValue == 0) {
                float dpiScale = e.Cache.DeviceDpi / spreadsheetControl1.DpiY;
                using(Font font = new Font(e.Font.Name, 9f * dpiScale, FontStyle.Bold)) {
                    using(StringFormat stringFormat = new StringFormat()) {
                        stringFormat.LineAlignment = StringAlignment.Center;
                        stringFormat.Alignment = StringAlignment.Center;
                        SizeF size = e.Graphics.MeasureString(text, font, Int32.MaxValue, stringFormat);
                        Rectangle textBounds = new Rectangle(
                            e.Bounds.Right + 15,
                            (int)Math.Round(e.Bounds.Top + (e.Bounds.Height - size.Height) / 2),
                            (int)(size.Width + 8),
                            (int)Math.Round(size.Height));
                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                        int middle = (int)Math.Round(textBounds.Height / 2.0);
                        Point[] points = new Point[] {
                            new Point(textBounds.Left, textBounds.Top),
                            new Point(textBounds.Left - middle, textBounds.Top + middle),
                            new Point(textBounds.Left, textBounds.Bottom)
                        };
                        Brush brush = e.Cache.GetSolidBrush(Color.Red);
                        e.Graphics.FillPolygon(brush, points);
                        e.Cache.FillRectangle(brush, textBounds);
                        e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(Color.White), textBounds, stringFormat);
                    }
                }
            }
        }

        private void SpreadsheetControl1_CustomDrawCellBackground(object sender, CustomDrawCellBackgroundEventArgs e) {
            if(e.Cell.ColumnIndex > 3 || e.Cell.RowIndex % 2 == 0)
                return;
            CellRange dataRange = e.Cell.Worksheet.GetDataRange();
            if(e.Cell.RowIndex <= dataRange.BottomRowIndex) {
                Color color = CommonSkins.GetSkin(spreadsheetControl1.LookAndFeel).GetSystemColor(SystemColors.Window);
                e.BackColor = DemoColors.ApplyTint(color, color.GetBrightness() > 0.5 ? -0.05f : 0.05f);
            }
        }
    }
}
