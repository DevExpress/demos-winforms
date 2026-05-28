using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.Utils;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Focus and navigation", "FocusAndNavigation.cs")]
    public static class FocusAndNavigation {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(50);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        
        #region Focus and Navigation
        [CodeExampleCase("Scroll horizontally"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("LeftCoord")]
        public static void ScrollHorizontally(GridControl gridControl, GridView gridView) {            
            gridView.OptionsView.ColumnAutoWidth = false;
            foreach (GridColumn col in gridView.Columns) {
                col.Width = 400;
            }
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll forward", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // The property controls the offset by which the View is scrolled horizontally
                gridView.LeftCoord += 10;
            };

            SimpleButton b1 = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll backward", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                gridView.LeftCoord -= 10;
            };
        }
        [CodeExampleCase("Scroll vertically by rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("TopRowIndex")]
        public static void ScrollViewVerticallyByRows(GridControl gridControl, GridView gridView) {
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll down", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // The property gets or sets the rowHandle of the top visible row
                gridView.TopRowIndex++;
            };

            SimpleButton b1 = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll up", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                gridView.TopRowIndex--;
            };
        }
        [CodeExampleCase("Scroll vertically by pixels"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("TopRowPixel")]
        public static void ScrollViewVerticallyByPixels(GridControl gridControl, GridView gridView) {          
            // This option controls whether pixel-based vertical scrolling is enabled
            gridView.OptionsBehavior.AllowPixelScrolling = DefaultBoolean.True;

            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll down", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // This property specifies the vertical scroll position, in pixels.
                gridView.TopRowPixel += 6;
            };

            SimpleButton b1 = new SimpleButton { Parent = gridControl.Parent, Text = "Scroll up", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                gridView.TopRowPixel -= 6;
            };
        }
        [CodeExampleCase("Prevent row focus changes"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("BeforeLeaveRow")]
        public static void BeforeLeaveRow(GridControl gridControl, GridView gridView) {
            gridView.SetRowCellValue(2, "Length", 0);
            gridView.FocusedRowHandle = 2;
            // Handle this event to prevent row focus changes
            gridView.BeforeLeaveRow += (s, e) => {
                double _length = Convert.ToDouble((s as GridView).GetRowCellValue(e.RowHandle, "Length"));
                if (_length <= 0) {
                    e.Allow = XtraMessageBox.Show("Length should be greater than zero. Would you like to leave the row anyway?", "Confirmation dialog", MessageBoxButtons.YesNo) == DialogResult.Yes;
                }
            };
        }
        [CodeExampleCase("Focus a cell and show its in-place editor"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("FocusedRowHandle", "FocusedColumn", "ShowEditor")]
        public static void FocusingCellAndShowingEditor(GridControl gridControl, GridView gridView) {
            // Focusing a cell and showing its in-place editor
            gridControl.Load += (sender, e) => {
                gridView.FocusedRowHandle = 2;
                gridView.FocusedColumn = gridView.Columns["Length"];
                gridView.ShowEditor();
                TextEdit edit = gridView.ActiveEditor as TextEdit;
                if (edit != null) {
                    edit.BackColor = Color.DodgerBlue;
                }
            };
        }
        [CodeExampleCase("Prohibit focusing a column"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("FocusedColumnChanged", "FocusedColumn", "PrevFocusedColumn")]
        public static void ProhibitFocusingColumn(GridControl gridControl, GridView gridView) {
            // The event is raised each time focus is moved to another column
            gridView.FocusedColumnChanged += (s, e) => {
                if (e.FocusedColumn.VisibleIndex % 2 == 1) {
                    GridView view = s as GridView;
                    view.FocusedColumn = e.PrevFocusedColumn;
                }
            };
        }
        [CodeExampleCase("Prohibit focusing a row"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("FocusedRowChanged", "FocusedRowHandle", "PrevFocusedRowHandle")]
        public static void ProhibitFocusingRow(GridControl gridControl, GridView gridView) {
            gridView.FocusedColumn = gridView.Columns[1];
            // The event is raised each time focus is moved to another row
            gridView.FocusedRowChanged += (s, e) => {
                if (e.FocusedRowHandle % 2 == 1) {
                    GridView view = s as GridView;
                    view.FocusedRowHandle = e.PrevFocusedRowHandle;
                }
            };
        }
        #endregion
    }
}
