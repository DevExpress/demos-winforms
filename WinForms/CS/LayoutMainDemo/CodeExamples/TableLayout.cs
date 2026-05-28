using System;
using DevExpress.XtraLayout;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos.CodeDemo;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;
using System.Linq;
using DevExpress.Utils.Design;

namespace Examples {
    [CodeExampleClass("Table layout", "TableLayout.cs")]
    [CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup",
        "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "ColumnDefinition", "RowDefinition", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")]
    public static class TableLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Parent = sampleHost;
            return new object[] { layoutControl };
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as LayoutControl).Dispose();
        }
        [CodeExampleCase("Two table items")]
        public static void TableLayoutSimple(LayoutControl layoutControl) {
            // A layout consisting of two items.
            // When Table Layout mode is enabled, two rows and two columns are automatically created.
            // The first item is implicitly positioned in the cell (col=0, row=0).
            // The second item is explicitly positioned in the cell (col=1, row=1).
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            LayoutControlItem item2 = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            item2.OptionsTableLayoutItem.RowIndex = 1;
            item2.OptionsTableLayoutItem.ColumnIndex = 1;
        }
        [CodeExampleCase("Rows and columns")]
        public static void TableLayoutRowsAndColumns(LayoutControl layoutControl) {
            // A layout consisting of five items explicitly positioned within table cells.
            // Two items occupy more than one cell.

            layoutControl.Root.LayoutMode = LayoutMode.Table;

            //After enabling Table mode, two columns already exist. Add one more column.
            ColumnDefinition columnDefinition3 = new ColumnDefinition();
            columnDefinition3.SizeType = SizeType.Percent;
            columnDefinition3.Width = 50;
            layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions.Add(columnDefinition3);

            //Two rows already exist. Add one more row.
            RowDefinition rowDefinition3 = new RowDefinition();
            rowDefinition3.SizeType = SizeType.Percent;
            rowDefinition3.Height = 50;
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions.Add(rowDefinition3);

            // Create controls and position them within table cells.
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            LayoutControlItem item2 = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            LayoutControlItem item3 = layoutControl.AddItem("Memo 3", new MemoEdit() { Name = "Memo3" });
            LayoutControlItem item4 = layoutControl.AddItem("Memo 4", new MemoEdit() { Name = "Memo4" });
            LayoutControlItem item5 = layoutControl.AddItem("Memo 5", new MemoEdit() { Name = "Memo5" });

            item1.OptionsTableLayoutItem.RowIndex = 0;
            item1.OptionsTableLayoutItem.ColumnIndex = 0;

            item2.OptionsTableLayoutItem.RowIndex = 0;
            item2.OptionsTableLayoutItem.ColumnIndex = 2;

            item3.OptionsTableLayoutItem.RowIndex = 1;
            item3.OptionsTableLayoutItem.ColumnIndex = 0;
            item3.OptionsTableLayoutItem.RowSpan = 2;

            item4.OptionsTableLayoutItem.RowIndex = 1;
            item4.OptionsTableLayoutItem.ColumnIndex = 1;

            item5.OptionsTableLayoutItem.RowIndex = 2;
            item5.OptionsTableLayoutItem.ColumnIndex = 1;
            item5.OptionsTableLayoutItem.ColumnSpan = 2;

        }

        [CodeExampleCase("Row and column visibility")]
        [CodeExampleUnderlineTokens("Visible")]
        [CodeExampleVersionID(202)]
        public static void RowAndColumnVisibility(LayoutControl layoutControl) {
            // This example shows how to hide rows and columns using the Visible property.
            LayoutControlGroup tableGroup = layoutControl.Root.AddGroup();
            tableGroup.LayoutMode = LayoutMode.Table;
            //Create a table layout.
            tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear();
            tableGroup.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for(int i = 0; i < 4; i++) {
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition(tableGroup, 25, SizeType.Percent));
                tableGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition(tableGroup, 25, SizeType.Percent));
                LayoutControlItem newMemoItem = tableGroup.AddItem(string.Format("Memo {0}x{0}", i), new MemoEdit() { Name = string.Format("Memo {0}x{0}", i) });
                newMemoItem.OptionsTableLayoutItem.RowIndex = newMemoItem.OptionsTableLayoutItem.ColumnIndex = i;
            }
            //Toggle row and column visibility
            SimpleButton btnHide = new SimpleButton() { Name = "ButtonHide", Text = "Hide/show row and column" };
            LayoutControlItem btnHideItem = layoutControl.AddItem("ButtonHide", btnHide);
            btnHideItem.TextVisible = false;
            btnHide.Click += (s, e) => {
                tableGroup.OptionsTableLayoutGroup.RowDefinitions[2].Visible = !tableGroup.OptionsTableLayoutGroup.RowDefinitions[2].Visible;
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions[2].Visible = !tableGroup.OptionsTableLayoutGroup.ColumnDefinitions[2].Visible;
            };
        }

        [CodeExampleCase("Absolute row height")]
        public static void TableLayoutAbsoluteRowHeight(LayoutControl layoutControl) {
            // This example sets a row's height to an absolute value.
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            // When Table Layout mode is enabled, two rows and two columns are automatically created.
            // Access the first row.
            RowDefinition row1 = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions[0];
            row1.SizeType = SizeType.Absolute;
            row1.Height = 100;
            layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            LayoutControlItem item = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            item.OptionsTableLayoutItem.RowIndex = 1;
            item.OptionsTableLayoutItem.ColumnIndex = 1;
        }
        [CodeExampleCase("Auto-sized row")]
        [CodeExampleHighlightTokens("DxImageAssemblyUtil", "ImageSize", "ImageType", "Size")]
        public static void TableLayoutAutoSizedRow(LayoutControl layoutControl) {
            // This example demonstrates the auto-sizing feature of rows.

            // When Table Layout mode is enabled, two rows and two columns are automatically created. 
            // Three items (Picture editor and two Memo controls) are displayed in their individual table cells.
            // The Picture editor's maximum height is limited.
            // It is positioned in the first row, whose RowDefinition.SizeType property is set to AutoSize.  
            // The row is auto-sized to fit the Picture editor in its entirety.
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions[0].SizeType = SizeType.AutoSize;
            LayoutControlItem item1 = layoutControl.AddItem("Picture",
                new PictureEdit() {
                    Name = "Picture",
                    Image = DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", ImageSize.Size32x32, ImageType.Colored)
                });
            // Limit the PictureEdit control height.
            item1.SizeConstraintsType = SizeConstraintsType.Custom;
            item1.ControlMaxSize = new System.Drawing.Size(0, 40);

            LayoutControlItem item2 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            item2.OptionsTableLayoutItem.RowIndex = 1;
            item2.OptionsTableLayoutItem.ColumnIndex = 0;
            LayoutControlItem item3 = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            item3.OptionsTableLayoutItem.RowIndex = 1;
            item3.OptionsTableLayoutItem.ColumnIndex = 1;
        }
        [CodeExampleCase("Relative row height")]
        [CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")]
        public static void TableLayoutRelativeRowHeight(LayoutControl layoutControl) {
            // This example sets the height of table rows to proportional values.

            layoutControl.Root.LayoutMode = LayoutMode.Table;
            // When Table Layout mode is enabled, two rows and two columns are automatically created.
            // Access these rows.
            RowDefinition row1 = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions[0];
            RowDefinition row2 = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions[1];
            layoutControl.Root.BeginUpdate();
            row1.SizeType = row2.SizeType = SizeType.Percent;
            row1.Height = 40;
            row2.Height = 60;
            layoutControl.Root.EndUpdate();
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            LayoutControlItem item2 = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            item2.OptionsTableLayoutItem.RowIndex = 1;
            item2.OptionsTableLayoutItem.ColumnIndex = 1;
        }
        [CodeExampleCase("Relative column size and column span")]
        [CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")]
        public static void TableLayoutColumnSizeAndSpan(LayoutControl layoutControl) {
            // This example sets the width of table columns to proportinal values.
            // In addtion, the column span setting is demonstrated.

            layoutControl.Root.LayoutMode = LayoutMode.Table;
            // When Table Layout mode is enabled, two rows and two columns are automatically created.
            // Access these columns.
            ColumnDefinition column1 = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions[0];
            ColumnDefinition column2 = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions[1];
            layoutControl.Root.BeginUpdate();
            column1.SizeType = column2.SizeType = SizeType.Percent;
            column1.Width = 40;
            column2.Width = 60;
            layoutControl.Root.EndUpdate();
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            item1.OptionsTableLayoutItem.RowIndex = 0;
            item1.OptionsTableLayoutItem.ColumnIndex = 0;
            item1.OptionsTableLayoutItem.ColumnSpan = 2;
            LayoutControlItem item2 = layoutControl.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            item2.OptionsTableLayoutItem.RowIndex = 1;
            item2.OptionsTableLayoutItem.ColumnIndex = 1;
        }
        [CodeExampleCase("Table layout with nested group")]
        public static void TableLayoutNestedGroup(LayoutControl layoutControl) {
            // In this example, a table cell displays a nested layout group with two Memo controls.
            layoutControl.Root.LayoutMode = LayoutMode.Table;
            // When Table Layout mode is enabled, two rows and two columns are automatically created.
            LayoutControlItem item1 = layoutControl.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            LayoutControlGroup innerGroup = layoutControl.AddGroup();
            innerGroup.AddItem("Memo 2", new MemoEdit() { Name = "Memo2" });
            innerGroup.AddItem("Memo 3", new MemoEdit() { Name = "Memo3" });
            // Position the created group in a target cell.
            innerGroup.OptionsTableLayoutItem.RowIndex = 1;
            innerGroup.OptionsTableLayoutItem.ColumnIndex = 1;
            innerGroup.BestFit();
        }
        [CodeExampleCase("M rows x N columns layout")]
        [CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")]
        public static void TableLayoutMxN(LayoutControl layoutControl) {
            // This example creates a table consisting of a certain number of columns and rows.
            LayoutControlGroup tableGroup = layoutControl.Root.AddGroup();
            tableGroup.LayoutMode = LayoutMode.Table;
            tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear();
            tableGroup.OptionsTableLayoutGroup.RowDefinitions.Clear();
            int rowCount = 10;
            int columnCount = 10;
            tableGroup.BeginUpdate();
            for(int n = 0; n < columnCount; n++)
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition(tableGroup, 10, SizeType.Percent));
            for(int m = 0; m < rowCount; m++)
                tableGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition(tableGroup, 10, SizeType.Percent));
            tableGroup.EndUpdate();
            LayoutControlItem memo1LCI = tableGroup.AddItem("Memo 1", new MemoEdit() { Name = "Memo1" });
            memo1LCI.OptionsTableLayoutItem.ColumnIndex = 5;
            memo1LCI.OptionsTableLayoutItem.RowIndex = 4;
        }
    }
}
