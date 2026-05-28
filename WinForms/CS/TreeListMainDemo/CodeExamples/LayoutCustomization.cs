namespace Examples {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraDataLayout;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;

    [CodeExampleClass("Layout customization", "LayoutCustomization.cs")]
    public static class LayoutCustomization {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.Load += (s, e) => treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        #region Helpers
        [CodeExampleNestedClass]
        public static class DemoHelper {
            static DevExpress.Utils.ImageCollection imagesCore;
            public static DevExpress.Utils.ImageCollection Images {
                get {
                    if(imagesCore == null) {
                        imagesCore = new DevExpress.Utils.ImageCollection();
                        AddImage(Brushes.LightCoral, imagesCore);
                        AddImage(Brushes.LightGreen, imagesCore);
                        AddImage(Brushes.LightSkyBlue, imagesCore);
                        AddImage(Brushes.LightPink, imagesCore);
                        AddImage(Brushes.LightGray, imagesCore);
                    }
                    return imagesCore;
                }
            }
            static void AddImage(Brush brush, DevExpress.Utils.ImageCollection images) {
                Image img = new Bitmap(16, 16);
                using(Graphics g = Graphics.FromImage(img)) {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(brush, new Rectangle(0, 0, img.Width - 1, img.Height - 1));
                }
                images.AddImage(img);
            }
        }
        #endregion
        [CodeExampleCase("Change Node height dynamically")]
        [CodeExampleUnderlineTokens("CalcNodeHeight")]
        public static void CalcNodeHeight(TreeList treeList) {
            // The CalcNodeHeight event fires only if the TreeList.OptionsBehavior.AutoNodeHeight option is disabled.
            treeList.OptionsBehavior.AutoNodeHeight = false;
            treeList.RowHeight = 30;
            // Handle the CalcNodeHeight event to assign different node heights to the TreeList control.
            treeList.CalcNodeHeight += (sender, e) =>
            {
                e.NodeHeight = (e.Node.Level + 1) * e.NodeHeight;
            };
        }
        [CodeExampleCase("Display tree lines")]
        [CodeExampleUnderlineTokens("ShowTreeLines", "TreeLineStyle")]
        [CodeExampleVersionID(181)]
        public static void ShowTreeLines(TreeList treeList) {
            // Show hierarchy lines
            treeList.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True;
            // Hierarchy line style 
            treeList.OptionsView.TreeLineStyle = LineStyle.Percent50; // Solid, Light, Dark, Wide, Large
        }
        [CodeExampleCase("Assign node images dynamically", new Type[] { typeof(DemoHelper) })]
        [CodeExampleUnderlineTokens("GetSelectImage")]
        public static void GetSelectImage(TreeList treeList) {
            // Assign the source of select images for nodes to this property.
            treeList.SelectImageList = DemoHelper.Images;
            // Handle this event to dynamically assign select images to nodes.
            treeList.GetSelectImage += (s, e) =>
            {
                // default case
                e.NodeImageIndex = 4;
                // then specific cases
                if(object.Equals(e.Node["TypeOfObject"], "Asteroid"))
                    e.NodeImageIndex = e.FocusedNode ? 0 : 1;
                if(object.Equals(e.Node["TypeOfObject"], "Planet"))
                    e.NodeImageIndex = e.FocusedNode ? 0 : 2;
                if(object.Equals(e.Node["TypeOfObject"], "Satellite"))
                    e.NodeImageIndex = e.FocusedNode ? 0 : 3;
            };
        }
        [CodeExampleCase("Display row images in cells", new Type[] { typeof(DemoHelper) })]
        [CodeExampleUnderlineTokens("RowImagesShowMode")]
        [CodeExampleVersionID(181)]
        public static void RowImagesShowMode(TreeList treeList) {
            // Specify the source of select images for nodes.
            treeList.SelectImageList = DemoHelper.Images;
            // Handle this event to dynamically assign select images to nodes.
            treeList.GetSelectImage += (s, e) => {
                e.NodeImageIndex = -1;
                if(object.Equals(e.Node["Mark"], true))
                    e.NodeImageIndex = e.FocusedNode ? 0 : 1;
            };
            // Specify this property to display row images in cells. Available modes: InCell, InIndent.
            treeList.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell;
        }
        [CodeExampleCase("Display node checkboxes")]
        [CodeExampleUnderlineTokens("CheckBoxFieldName")]
        public static void ShowCheckBoxes(TreeList treeList) {
            // Sets the name of the field whose values define the states of built-in check boxes and hide the corresponding column
            treeList.CheckBoxFieldName = "Mark";
            treeList.Columns["Mark"].Visible = false;
            // Enable this property to make nodes show checkboxes
            treeList.OptionsView.ShowCheckBoxes = true;
        }
        [CodeExampleCase("Preview text horizontal offset")]
        [CodeExampleUnderlineTokens("PreviewIndent")]
        public static void IncreasePreviewIndent(TreeList treeList) {
            treeList.Columns["Notes"].Visible = false;
            treeList.PreviewFieldName = "Notes";
            treeList.OptionsView.ShowPreview = true;
            // This property gets or sets the horizontal offset of preview text.
            treeList.PreviewIndent = 55;

            SimpleButton b = new SimpleButton { Parent = treeList.Parent, Text = "Increase preview indent", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                treeList.PreviewIndent += 5;
            };
        }
    }
    [CodeExampleClass("View customization", "LayoutCustomization.cs")]
    public static class TreeViewCustomization {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            BindingSource source = new BindingSource();
            source.DataSource = SpaceObject.LoadData();
            DataLayoutControl dataLayout = new DataLayoutControl();
            dataLayout.Dock = DockStyle.Fill;
            dataLayout.Parent = sampleHost;
            dataLayout.DataSource = source;
            dataLayout.RetrieveFields();

            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Left;
            treeList.Parent = sampleHost;
            treeList.Width = sampleHost.Bounds.Width / 3;
            treeList.DataSource = source;
            treeList.Load += (s, e) => treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("TreeView style")]
        [CodeExampleUnderlineTokens("TreeViewFieldName")]
        [CodeExampleVersionID(181)]
        public static void TreeViewStyle(TreeList treeList) {
            //To display single - column data in the TreeView style, 
            //  specify the display column with the TreeList.TreeViewColumn or TreeList.TreeViewFieldName property.
            treeList.TreeViewFieldName = "Name";
        }
    }
}
