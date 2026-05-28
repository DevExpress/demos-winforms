namespace Examples {
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;

    [CodeExampleClass("Columns and bands", "ColumnsAndBands.cs")]
    public static class ColumnsAndBands {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.Load += (s, e) =>
            {
                treeList.ExpandAll();
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
        [CodeExampleCase("Add columns manually"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("AddVisible")]
        public static void AddColumnsManually(TreeList treeList) {
            TreeListColumn colName = treeList.Columns.AddVisible(fieldName: "Name");
            // Prohibit edit the column's cells
            colName.OptionsColumn.AllowEdit = false;
            // Use this property to override the TreeList.OptionsCustomization.AllowColumnResizing property's value 
            colName.OptionsColumn.AllowSize = false;

            TreeListColumn colTypeOfObject = treeList.Columns.AddVisible(fieldName: "TypeOfObject");
            // Use this property to override the TreeList.OptionsCustomization.AllowColumnMoving property's value
            colTypeOfObject.OptionsColumn.AllowMove = false;

            // Specifies whether columns can be moved by dragging their headers.
            treeList.OptionsCustomization.AllowColumnMoving = true;
            // Specifies whether columns can be resized by dragging the right edge of their headers.
            treeList.OptionsCustomization.AllowColumnResizing = true;
            // There are no new columns will be added here because the columns set is already predefined
            treeList.DataSource = SpaceObject.GetData();
        }
        [CodeExampleCase("Add bands manually"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("AddBand", "Add")]
        public static void Bands(TreeList treeList) {
            // All the columns will be created automatically
            treeList.DataSource = SpaceObject.GetData();
            // Adding bands
            TreeListBand mainBand = treeList.Bands.AddBand(caption: "Main");
            TreeListBand detailsBand = treeList.Bands.AddBand(caption: "Details");
            // Adding sub-bands
            TreeListBand markBand = detailsBand.Bands.AddBand(caption: "Is Checked");
            TreeListBand addInfoBand = detailsBand.Bands.AddBand(caption: "Additional info");
            // Adding columns into bands
            mainBand.Columns.Add(treeList.Columns["Name"]);
            mainBand.Columns.Add(treeList.Columns["TypeOfObject"]);
            markBand.Columns.Add(treeList.Columns["Mark"]);
            addInfoBand.Columns.Add(treeList.Columns["Notes"]);
            addInfoBand.Columns.Add(treeList.Columns["RecordDate"]);
            addInfoBand.Columns.Add(treeList.Columns["MeanRadiusByEarth"]);
            addInfoBand.Columns.Add(treeList.Columns["MeanRadiusInKM"]);
        }
        [CodeExampleCase("Fixed columns"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("Fixed", "FixedLineWidth")]
        public static void FixedColumns(TreeList treeList) {
            // All the columns will be created automatically
            treeList.DataSource = SpaceObject.GetData();
            treeList.OptionsView.AutoWidth = false;
            treeList.Columns["Notes"].Width = 384;
            // Make the specific columns fixed
            treeList.Columns["Name"].Fixed = FixedStyle.Left;
            treeList.Columns["TypeOfObject"].Fixed = FixedStyle.Right;
            // Setup the fixed line width
            treeList.FixedLineWidth = 2;
        }
        [CodeExampleCase("Fixed bands"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("Fixed", "FixedLineWidth")]
        public static void FixedBands(TreeList treeList) {
            // All the columns will be created automatically
            treeList.DataSource = SpaceObject.GetData();
            treeList.OptionsView.AutoWidth = false;
            treeList.Columns["Notes"].Width = 700;
            // Creating bands
            TreeListBand mainBand = treeList.Bands.AddBand("Main");
            mainBand.Columns.Add(treeList.Columns["Name"]);
            TreeListBand detailsBand = treeList.Bands.AddBand("Details");
            detailsBand.Columns.Add(treeList.Columns["TypeOfObject"]);
            detailsBand.Columns.Add(treeList.Columns["Notes"]);            
            TreeListBand InfoBand = treeList.Bands.AddBand("Information");
            InfoBand.Columns.Add(treeList.Columns["Mark"]);
            InfoBand.Columns.Add(treeList.Columns["RecordDate"]);
            // Make the specific band fixed
            mainBand.Fixed = FixedStyle.Left;
            InfoBand.Fixed = FixedStyle.Right;
            // Setup the fixed line width
            treeList.FixedLineWidth = 2;
        }
        [CodeExampleCase("Column separators"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("SeparatorWidth")]
        [CodeExampleVersionID(181)]
        public static void SeparatorColumns(TreeList treeList) {
            // All the columns will be created automatically
            treeList.DataSource = SpaceObject.GetData();
            treeList.OptionsView.AutoWidth = true;
            // Enable a separator for a column
            treeList.Columns["MeanRadiusInKM"].SeparatorWidth = 2;
            treeList.Appearance.Separator.BackColor = System.Drawing.Color.LightPink;
        }
        [CodeExampleCase("Band separators"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("SeparatorWidth")]
        [CodeExampleVersionID(181)]
        public static void SeparatorBands(TreeList treeList) {
            // All the columns will be created automatically
            treeList.DataSource = SpaceObject.GetData();
            treeList.OptionsView.AutoWidth = true;
            // Creating bands
            TreeListBand mainBand = treeList.Bands.AddBand("Main");
            mainBand.Columns.Add(treeList.Columns["Name"]);
            TreeListBand detailsBand = treeList.Bands.AddBand("Details");
            detailsBand.Columns.Add(treeList.Columns["TypeOfObject"]);
            detailsBand.Columns.Add(treeList.Columns["MeanRadiusInKM"]);
            detailsBand.Columns.Add(treeList.Columns["Notes"]);
            TreeListBand InfoBand = treeList.Bands.AddBand("Information");
            InfoBand.Columns.Add(treeList.Columns["Mark"]);
            detailsBand.Columns.Add(treeList.Columns["MeanRadiusByEarth"]);
            InfoBand.Columns.Add(treeList.Columns["RecordDate"]);
            // Enable separators for a column and band
            detailsBand.SeparatorWidth = 2;
            treeList.Columns["MeanRadiusInKM"].SeparatorWidth = 1;
            treeList.Appearance.Separator.BackColor = System.Drawing.Color.LightPink;
        }
    }
}
