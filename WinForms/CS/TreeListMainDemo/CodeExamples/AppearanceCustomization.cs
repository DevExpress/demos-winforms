namespace Examples {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;
    using DevExpress.XtraTreeList.StyleFormatConditions;

    [CodeExampleClass("Appearance customization", "AppearanceCustomization.cs")]
    public static class AppearanceCustomization {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.GetData();
            treeList.Load += (s, e) => {
                treeList.ExpandAll();
                treeList.Columns["Name"].BestFit();
                treeList.Columns["MeanRadiusByEarth"].SortOrder = SortOrder.Ascending;
            };
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Changing the row appearances settings")]
        [CodeExampleUnderlineTokens("Appearance", "OptionsView")]
        public static void RowAppearance(TreeList treeList) {
            treeList.Appearance.Row.ForeColor = Color.Blue;
            // Contains the appearance settings used to paint odd rows.
            treeList.Appearance.OddRow.BackColor = Color.LightGreen;
            // Controls whether odd nodes are painted using the appearance settings provided by the TreeList.Appearance.OddRow property.
            treeList.OptionsView.EnableAppearanceOddRow = true;
            // The same for even row
            treeList.Appearance.EvenRow.BackColor = Color.LightPink;
            treeList.OptionsView.EnableAppearanceEvenRow = true;
            // Use this property control whether tree indents are painted using the appearance settings of their corresponding nodes.
            treeList.OptionsView.ShowIndentAsRowStyle = false;
        }
        [CodeExampleCase("Changing the appearance settings of the specific column cells")]
        [CodeExampleUnderlineTokens("AppearanceCell")]
        public static void CellAppearance(TreeList treeList) {
            // Cell appearance settings customization for Name column
            TreeListColumn colName = treeList.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.LightGreen;
            colName.AppearanceCell.BackColor2 = Color.Green;
            // Cell appearance settings customization for Notes column
            TreeListColumn colNotes = treeList.Columns["Notes"];
            colNotes.AppearanceCell.ForeColor = Color.Blue;
            colNotes.AppearanceCell.FontStyleDelta = FontStyle.Underline;
        }
        [CodeExampleCase("Changing the appearance settings of column cells dynamically")]
        [CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")]
        public static void ChangingCellAppearanceDynamically(TreeList treeList) {
            treeList.NodeCellStyle += (sender, e) => {
                int radius = Convert.ToInt32(e.Node.GetValue("MeanRadiusInKM"));
                if(e.Column.FieldName == "Name") {
                    e.Appearance.BackColor = radius < 25000 ? Color.LightPink : Color.LightGreen;
                    e.Appearance.ForeColor = Color.Blue;
                } else {
                    e.Appearance.ForeColor = radius < 25000 ? Color.Red : Color.Green;
                }
            };
        }
        [CodeExampleCase("Changing the background color of an active editor")]
        [CodeExampleUnderlineTokens("ShownEditor")]
        public static void ChangingColorOfAnActiveEditor(TreeList treeList) {
            treeList.OptionsBehavior.Editable = true;
            // The ShownEditor event is designed to perform specific actions after a cell editor has been invoked.
            treeList.ShownEditor += (sender, e) => {
                // The editor can be accessed using the ActiveEditor property.
                var activeEditor = treeList.ActiveEditor;
                if(treeList.FocusedValue is int) {
                    activeEditor.BackColor = ((int)treeList.FocusedValue) < 25000 ? Color.LightPink : Color.LightGreen;
                } else {
                    activeEditor.BackColor = Color.Yellow;
                }
            };
        }
        [CodeExampleCase("Applying custom styles to nodes at different levels")]
        [CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")]
        public static void ChangingColorOfNodeLevels(TreeList treeList) {
            treeList.NodeCellStyle += (sender, e) => {
                e.Appearance.BackColor = (e.Node.Level % 2 == 0) ? Color.LightBlue : Color.LightGreen;
            };
        }
        [CodeExampleCase("Prioritize cell selection appearances"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("NodeCellStyle", "IsCellSelected")]
        public static void CellSelectionPriority(TreeList treeList) {
            treeList.OptionsSelection.MultiSelect = true;
            treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect;

            TreeListColumn colName = treeList.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.Salmon;
            colName.AppearanceCell.Options.UseBackColor = true;

            treeList.NodeCellStyle += (s, e) => {
                TreeList tl = s as TreeList;
                if(tl.IsCellSelected(e.Node, e.Column))
                    e.Appearance.BackColor = tl.ViewInfo.PaintAppearance.SelectedRow.BackColor;
            };
        }
        [CodeExampleCase("Disable focused cell highlight"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("EnableAppearanceFocusedCell")]
        public static void DisableFocusedCellAppearance(TreeList treeList) {
            treeList.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
        }
        [CodeExampleCase("Appearance of nodes (dynamically)"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")]
        public static void AppearanceOfRowsDynamically(TreeList treeList) {
            TreeListColumn colName = treeList.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.Salmon;
            colName.AppearanceCell.Options.UseBackColor = true;
            treeList.OptionsBehavior.Editable = false;
            Color foreColor = Color.MediumOrchid;
            Color backColor = Color.LightGreen;
            //Changing the appearance settings of row cells dynamically
            treeList.NodeCellStyle += (s, e) => {
                TreeList tl = s as TreeList;
                //Change selected rows' fore and back colors
                bool mark = (bool)e.Node.GetValue(tl.Columns["Mark"]);
                if(mark) {
                    if(tl.FocusedNode == e.Node)
                        e.Appearance.BackColor = tl.ViewInfo.PaintAppearance.SelectedRow.BackColor;
                    else {
                        e.Appearance.ForeColor = foreColor;
                        e.Appearance.BackColor = backColor;
                    }
                }
            };
        }
    }
}
