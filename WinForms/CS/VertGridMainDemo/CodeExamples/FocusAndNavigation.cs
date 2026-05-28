using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.Utils;
using System.Drawing;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Focus and navigation", "FocusAndNavigation.cs")]
    public static class FocusAndNavigation {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(50);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Focus and Navigation

        [CodeExampleCase("Scroll horizontally by rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("LeftVisibleRecord")]
        public static void ScrollViewVerticallyByRows(VGridControl vGridControl) {
            SimpleButton b = new SimpleButton { Parent = vGridControl.Parent, Text = "Scroll right", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // The index of the leftmost visible record
                vGridControl.LeftVisibleRecord++;
            };

            SimpleButton b1 = new SimpleButton { Parent = vGridControl.Parent, Text = "Scroll left", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                vGridControl.LeftVisibleRecord--;
            };
        }

        [CodeExampleCase("Scroll horizontally by pixels"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("LeftVisibleRecordPixel")]
        public static void ScrollViewVerticallyByPixels(VGridControl vGridControl) {
            // Toggles pixel-based vertical scrolling on or off
            vGridControl.OptionsBehavior.AllowAnimatedScrolling = true;

            SimpleButton b = new SimpleButton { Parent = vGridControl.Parent, Text = "Scroll right", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // The horizontal scroll position of the leftmost record.
                vGridControl.LeftVisibleRecordPixel += 6;
            };

            SimpleButton b1 = new SimpleButton { Parent = vGridControl.Parent, Text = "Scroll left", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                vGridControl.LeftVisibleRecordPixel -= 6;
            };
        }

        [CodeExampleCase("Prohibit focusing a column"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("FocusedColumnChanged", "FocusedColumn", "PrevFocusedColumn")]
        public static void ProhibitFocusingColumn(VGridControl vGridControl) {
            // This event fires each time a user selects another column
            vGridControl.FocusedRowChanged += (s, e) => {
                if(e.Row.VisibleIndex % 2 == 1) {
                    vGridControl.FocusedRow = e.OldRow;
                }
            };
        }
        #endregion
    }
}
