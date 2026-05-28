namespace Examples {
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;

    [CodeExampleClass("Cell editors", "CellEditors.cs")]
    public static class CellEditors {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.GetData();
            treeList.Load += (s, e) =>
            {
                treeList.ExpandAll();
                treeList.Columns["Name"].BestFit();
                treeList.Columns["MeanRadiusByEarth"].BestFit();
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
        [CodeExampleCase("Assign in-place editors dynamically")]
        [CodeExampleUnderlineTokens("CustomNodeCellEdit")]
        public static void AssignInPalceEditorsDynamically(TreeList treeList) {
            // Predefined cell editors
            RepositoryItem spinEdit = new RepositoryItemSpinEdit();
            RepositoryItem calcEdit = new RepositoryItemCalcEdit();
            treeList.RepositoryItems.AddRange(new RepositoryItem[] { spinEdit, calcEdit });

            TreeListColumn colMeanRadiusInKM = treeList.Columns["MeanRadiusInKM"];
            TreeListColumn colMark = treeList.Columns["Mark"];
            colMeanRadiusInKM.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            // Handle this event to assign editors to individual cells
            treeList.CustomNodeCellEdit += (s, e) =>
            {
                if(e.Column == colMeanRadiusInKM) {
                    bool markValue = (bool)treeList.GetRowCellValue(e.Node, colMark);
                    e.RepositoryItem = markValue ? spinEdit : calcEdit;
                }
            };
        }
        [CodeExampleCase("Override the default in-place editor for certain cells"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("ColumnEdit", "CustomNodeCellEdit")]
        public static void AssigningEditorsForInplaceEditing(TreeList treeList) {
            SpaceObject sun = ((IEnumerable<SpaceObject>)treeList.DataSource).First();
            // Predefined cell editors
            RepositoryItem spinEditForEditing = new RepositoryItemSpinEdit();
            RepositoryItem progressEditForDisplaying = new RepositoryItemProgressBar()
            {
                Maximum = sun.MeanRadiusInKM, // SUN
                ShowTitle = true
            };
            treeList.RepositoryItems.AddRange(new RepositoryItem[] { spinEditForEditing, progressEditForDisplaying });

            //Assigning an editor to a column
            TreeListColumn colMeanRadiusInKM = treeList.Columns["MeanRadiusInKM"];
            colMeanRadiusInKM.ColumnEdit = progressEditForDisplaying;
            //Assigning an editor for in-place editing
            treeList.CustomNodeCellEditForEditing += (sender, e) =>
            {
                if(e.Column == colMeanRadiusInKM)
                    e.RepositoryItem = spinEditForEditing;
            };
        }
        [CodeExampleClass("Edit Form", "CellEditors.cs")]
        public static class EditForm {
            [CodeExampleSetUp]
            public static object[] SetUp(XtraUserControl sampleHost) {
                TreeList treeList = new TreeList();
                treeList.Dock = DockStyle.Fill;
                treeList.Parent = sampleHost;
                treeList.DataSource = SpaceObject.GetData();
                treeList.Load += (s, e) => {
                    treeList.ExpandAll();
                    treeList.Columns["Name"].BestFit();
                    treeList.Columns["MeanRadiusByEarth"].BestFit();
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
            [CodeExampleCase("Edit nodes with the default Edit Form")]
            [CodeExampleUnderlineTokens("EditingMode")]
            public static void NodeEditingByDefaultEditForm(TreeList treeList) {
                // Switch edit mode
                treeList.OptionsBehavior.EditingMode = TreeListEditingMode.EditForm;
                treeList.Columns["Notes"].OptionsEditForm.UseEditorColRowSpan = false;
                treeList.Columns["Notes"].OptionsEditForm.ColumnSpan = 3;
                treeList.Columns["Notes"].OptionsEditForm.RowSpan = 2;
            }
            [CodeExampleCase("Edit nodes with a custom Edit Form")]
            [CodeExampleUnderlineTokens("EditingMode", "CustomEditFormLayout")]
            public static void NodeEditingByCustomEditForm(TreeList treeList) {
                // Switch edit mode
                treeList.OptionsBehavior.EditingMode = TreeListEditingMode.EditForm;
                // Create a custom EditForm
                var control = new EditFormUserControl();
                control.Height = treeList.Height / 2;
                // Add editors
                MemoEdit memoEditNotes = new MemoEdit();
                memoEditNotes.Dock = DockStyle.Fill;
                TextEdit textEditName = new TextEdit();
                textEditName.Dock = DockStyle.Top;
                TextEdit textEditType = new TextEdit();
                textEditType.Dock = DockStyle.Top;
                DateEdit dateEditDate = new DateEdit();
                dateEditDate.Dock = DockStyle.Bottom;
                control.Controls.Add(memoEditNotes);
                control.Controls.Add(dateEditDate);
                control.Controls.Add(textEditType);
                control.Controls.Add(textEditName);
                // Bind the editors to data source fields
                control.SetBoundFieldName(memoEditNotes, "Notes");
                control.SetBoundFieldName(textEditName, "Name");
                control.SetBoundFieldName(textEditType, "TypeOfObject");
                control.SetBoundFieldName(dateEditDate, "RecordDate");
                // Assing the Edit Form to the Tree List
                treeList.OptionsEditForm.CustomEditFormLayout = control;
            }
        }
    }
}
