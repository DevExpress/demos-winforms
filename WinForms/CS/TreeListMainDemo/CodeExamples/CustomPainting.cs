namespace Examples {
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;
    using DevExpress.XtraTreeList.ViewInfo;


    [CodeExampleClass("Custom painting", "CustomPainting.cs")]
    public class CustomPainting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.GetData();
            treeList.Load += (s, e) => treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Highlight the specific cells")]
        [CodeExampleUnderlineTokens("CustomDrawNodeCell")]
        public static void HighlightCells(TreeList treeList) {
            // Handle this event to modify the specific cell's paint appearance
            treeList.CustomDrawNodeCell += (sender, e) =>
            {
                if(object.Equals(e.CellValue, "Planet"))
                    e.Appearance.BackColor = Color.LightGreen;
                if(object.Equals(e.Node["Name"], "Earth"))
                    e.Appearance.BackColor = Color.LightSeaGreen;
            };
        }
        [CodeExampleCase("Adding the custom painting into cell content")]
        [CodeExampleUnderlineTokens("CustomDrawNodeCell")]
        public static void DrawNodeCellIcons(TreeList treeList) {
            TreeListColumn colTypeOfObject = treeList.Columns["TypeOfObject"];
            colTypeOfObject.Width = 120;
            // Handle this event to paint node cells manually
            treeList.CustomDrawNodeCell += (sender, e) =>
            {
                if(e.Column != colTypeOfObject)
                    return;
                // draw the default content
                e.DefaultDraw();
                // select the brush for painting based on cell value 
                Color objectColor = Color.LightGray;
                if(object.Equals(e.CellValue, "Star"))
                    objectColor = Color.Yellow;
                if(object.Equals(e.CellValue, "Planet"))
                    objectColor = Color.LightGreen;
                if(object.Equals(e.CellValue, "Satellite"))
                    objectColor = Color.LightSkyBlue;
                if(object.Equals(e.CellValue, "Asteroid"))
                    objectColor = Color.LightPink;
                // draw the object icons
                Size iconSize = new Size(10, 10);
                Rectangle content = Rectangle.Inflate(e.Bounds, -4, -4);
                e.Cache.FillEllipse(objectColor, PlacementHelper.Arrange(iconSize, content, ContentAlignment.MiddleRight));
            };
        }
        [CodeExampleCase("Highlight the specific column header")]
        [CodeExampleUnderlineTokens("CustomDrawColumnHeader")]
        public static void HighlightColumnHeaders(TreeList treeList) {
            TreeListColumn colName = treeList.Columns["Name"];
            treeList.CustomDrawColumnHeader += (sender, e) =>
            {
                if(e.Column != colName) return;
                // update the painting arguments
                ColumnInfo columnInfo = e.ObjectArgs as ColumnInfo;
                columnInfo.AllowColoring = true;
                columnInfo.Appearance.BackColor = Color.Orange;
            };
        }

        [CodeExampleCase("Drawing row numbers")]
        [CodeExampleUnderlineTokens("CustomDrawNodeIndicator")]
        public static void DrawRowNumbers(TreeList treeList) {
            treeList.CustomDrawNodeIndicator += (sender, e) =>
            {
                // fill the background
                using(SolidBrush brush = new SolidBrush(Color.LightGreen))
                    e.Cache.FillRectangle(brush, Rectangle.Inflate(e.Bounds, -1, -1));
                // draw row number
                using(var sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Cache.DrawString(e.Node.Id.ToString(), e.Appearance.GetFont(), e.Cache.GetSolidBrush(e.Appearance.GetForeColor(e.Cache)), Rectangle.Inflate(e.Bounds, -2, -2), sf);
                }
                // supress the default painting
                e.Handled = true;
            };
        }

        [CodeExampleCase("CustomDrawRowPreview")]
        [CodeExampleUnderlineTokens("CustomDrawRowPreview")]
        public static void CustomDrawRowPreview(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            treeList.PreviewFieldName = "Notes";
            treeList.PreviewLineCount = 3;
            treeList.OptionsView.ShowPreview = true;

            int padding = 5;

            // Handle this event to paint Preview row manually
            treeList.CustomDrawNodePreview += (s, e) => {                
                e.Appearance.TextOptions.VAlignment = VertAlignment.Center;
                
                double radius = (double)e.Node["MeanRadiusByEarth"];
                if(radius > 5) {
                    Rectangle rect = e.Bounds;
                    rect.Inflate(-padding, -padding);
                    e.Cache.FillEllipse(rect.X, rect.Y, rect.Height, rect.Height, Color.Coral);
                    rect.X += rect.Height + padding * 2;
                    rect.Width -= (rect.Height + padding * 3);
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.DrawString(e.Cache, e.PreviewText, rect);
                    e.Handled = true;
                }
                else
                    e.DefaultDraw();
            };
        }
    }
}
