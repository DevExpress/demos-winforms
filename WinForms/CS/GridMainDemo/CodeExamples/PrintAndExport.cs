using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Print and export", "PrintAndExport.cs")]
    public static class PrintAndExport {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(6);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }


        #region Helpers

        [CodeExampleNestedClass("")]
        public static class DemoHelper {
            public static Image GetRandomImage(int w, int h) {
                Image img = new Bitmap(w, h);
                using(Graphics g = Graphics.FromImage(img)) {
                    using(var brush = GetRandomBrush())
                        g.FillRectangle(brush, new Rectangle(0, 0, img.Width, img.Height));
                }
                return img;
            }
            public static Color GetRandomColor() {
                var r = DevExpress.Data.Utils.NonCryptographicRandom.Default;
                System.Threading.Thread.Sleep(15);
                return Color.FromArgb(r.Next(50, 200), r.Next(50, 200), r.Next(50, 200));
            }
            public static Brush GetRandomBrush() {
                return new SolidBrush(GetRandomColor());
            }
        }

        #endregion

        #region Printing / Exporting

        [CodeExampleCase("Add custom information to the print/export output after a row is printed", new Type[] { typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AfterPrintRow")]
        public static void AfterPrintRow(GridControl gridControl, GridView gridView) {
            // Handle this event to add custom information to the printout/export output after a row is printed
            float offset = 1;
            gridView.AfterPrintRow += (s, e) => {
                DevExpress.XtraPrinting.ImageBrick ib = new DevExpress.XtraPrinting.ImageBrick();
                ib.Image = DemoHelper.GetRandomImage(100, 20);
                using(Graphics g = Graphics.FromImage(ib.Image))
                    g.DrawString("AfterPrintRow", AppearanceObject.DefaultFont, DemoHelper.GetRandomBrush(), new PointF(3, 3));
                RectangleF r = new RectangleF(2, offset, 100, 20);
                e.BrickGraphics.DrawBrick(ib, r);
                offset += (r.Height + 1);
            };
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Show PrintPreview", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                offset = 1;
                gridView.ShowPrintPreview();
            };
        }

        [CodeExampleCase("Add custom information to the print/export output before a row is printed", new Type[] { typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("BeforePrintRow")]
        public static void BeforePrintRow(GridControl gridControl, GridView gridView) {
            // Handle this event to add custom information to the printout/export output before a row is printed
            gridView.BeforePrintRow += (s, e) => {
                if(e.RowHandle % 2 != 0) {
                    // Create a text brick and customize its appearance settings.
                    DevExpress.XtraPrinting.TextBrick tb = new DevExpress.XtraPrinting.TextBrick();
                    tb.Text = "BeforePrintRow";
                    tb.Font = new DXFont(tb.Font, DXFontStyle.Bold);
                    tb.HorzAlignment = HorzAlignment.Near;
                    tb.Padding = new PaddingInfo(5, 0, 0, 0);
                    tb.BackColor = DemoHelper.GetRandomColor();
                    tb.ForeColor = DemoHelper.GetRandomColor();
                    // Get the client page width.
                    BrickGraphics brickGraphics = (BrickGraphics)e.BrickGraphics;
                    SizeF clientPageSize = brickGraphics.ClientPageSize;
                    float textBrickHeight = brickGraphics.MeasureString(tb.Text, tb.Font).Height + 4;
                    // Calculate a rectangle for the brick and draw the brick.
                    RectangleF textBrickRect =
                        new RectangleF(0, e.Y, (int)clientPageSize.Width, textBrickHeight);
                    e.BrickGraphics.DrawBrick(tb, textBrickRect);
                    // Adjust the current Y position to print the following row below the brick.
                    e.Y += (int)textBrickHeight;
                }
            };
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Show PrintPreview", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ShowPrintPreview();
            };
        }

        [CodeExampleCase("Customize general print/export settings when the View is being printed/exported"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AfterBuildPages", "PrintInitialize")]
        public static void PrintInitialize(GridControl gridControl, GridView gridView) {
            EventHandler afterBuildPages = null;
            afterBuildPages = (s, e) => {
                PrintingSystemBase pb = s as PrintingSystemBase;
                pb.AfterBuildPages -= afterBuildPages;
                //Set the document's scale factor
                pb.Document.ScaleFactor = 1.5f;
            };
            // Handle this event to customize general print/export settings when the View is being printed/exported
            gridView.PrintInitialize += (s, e) => {
                PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
                //Set the paper orientation to Landscape
                pb.PageSettings.Landscape = true;
                //Specify the document's scale factor
                pb.AfterBuildPages += afterBuildPages;
            };
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Show PrintPreview", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ShowPrintPreview();
            };
        }

        #endregion
    }
}
