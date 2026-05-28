using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;

namespace DevExpress.XtraGrid.Demos.CodeExamples
{
    [CodeExampleClass("Layout customization", "LayoutCustomization.cs")]
    public static class LayoutCustomization
    {
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

        #region Data classes


        [CodeExampleNestedClass("")]
        public class Product
        {
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        [CodeExampleNestedClass("")]
        public class Category
        {
            public int ID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public BindingList<Product> Products { get; set; }

            public static BindingList<Category> GetMasterDetailData() {
                BindingList<Category> list = new BindingList<Category>();
                list.Add(new Category() { ID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales", Products = new BindingList<Product> { new Product() { ProductName = "Guaraná Fantástica", CategoryID = 1, UnitPrice = 4.5m } } });
                list.Add(new Category() { ID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings", Products = new BindingList<Product> { new Product() { ProductName = "Sir Corey's Scones", CategoryID = 2, UnitPrice = 110 }, new Product() { ProductName = "Sir Joes's Scones", CategoryID = 2, UnitPrice = 231.23m }, new Product() { ProductName = "Amanda's Scones", CategoryID = 2, UnitPrice = 31.23m } } });
                list.Add(new Category() { ID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads", Products = new BindingList<Product> { new Product() { ProductName = "Sir Rodney's Scones", CategoryID = 3, UnitPrice = 10 }, new Product() { ProductName = "Gumbär Gummibärchen", CategoryID = 3, UnitPrice = 31.23m }, new Product() { ProductName = "NuNuCa Nuß-Nougat-Creme", CategoryID = 3, UnitPrice = 14 }, new Product() { ProductName = "Gumbär", CategoryID = 3, UnitPrice = 331.23m }, new Product() { ProductName = "Gummibärchen", CategoryID = 3, UnitPrice = 321.23m } } });
                list.Add(new Category() { ID = 4, CategoryName = "Dairy Products", Description = "Cheeses", Products = new BindingList<Product> { new Product() { ProductName = "Gorgonzola Telino", CategoryID = 4, UnitPrice = 12.5m }, new Product() { ProductName = "Gorgonzola", CategoryID = 4, UnitPrice = 112.5m }, new Product() { ProductName = "Telino", CategoryID = 4, UnitPrice = 122.5m } } });
                list.Add(new Category() { ID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal", Products = new BindingList<Product> { new Product() { ProductName = "Tunnbröd", CategoryID = 5, UnitPrice = 9 }, new Product() { ProductName = "Gustaf's Knäckebröd", CategoryID = 5, UnitPrice = 21 }, new Product() { ProductName = "Knäckebröd", CategoryID = 5, UnitPrice = 221 } } });
                list.Add(new Category() { ID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats", Products = new BindingList<Product> { new Product() { ProductName = "Thüringer Rostbratwurst", CategoryID = 6, UnitPrice = 123.79m }, new Product() { ProductName = "Thüringer", CategoryID = 6, UnitPrice = 223.79m }, new Product() { ProductName = "Rostbratwurst", CategoryID = 6, UnitPrice = 133.79m } } });
                list.Add(new Category() { ID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd", Products = new BindingList<Product> { new Product() { ProductName = "Rössle Sauerkraut", CategoryID = 7, UnitPrice = 45.6m }, new Product() { ProductName = "Rössle", CategoryID = 7, UnitPrice = 55.6m }, new Product() { ProductName = "Sauerkraut", CategoryID = 7, UnitPrice = 35.6m } } });
                list.Add(new Category() { ID = 8, CategoryName = "Seafood", Description = "Seaweed and fish", Products = new BindingList<Product> { new Product() { ProductName = "Nord-Ost Matjeshering", CategoryID = 8, UnitPrice = 25.89m }, new Product() { ProductName = "Nord-Ost", CategoryID = 8, UnitPrice = 23.89m }, new Product() { ProductName = "Nord Matjeshering", CategoryID = 8, UnitPrice = 29.89m } } });
                return list;
            }

            public static string ProductsLevelName = "Products";
        }
        #endregion

        #region Layout Customization
        [CodeExampleCase("View caption height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ViewCaptionHeight", "ShowViewCaption")]
        public static void IncreaseViewCaptionHeight(GridControl gridControl, GridView gridView) {
            // Enable this option to show the GridView's caption
            gridView.OptionsView.ShowViewCaption = true;
            gridView.ViewCaption = "Fish database";
            // This property controls the GridView's caption height
            gridView.ViewCaptionHeight = 20;
        }

        [CodeExampleCase("Column header panel height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ColumnPanelRowHeight")]
        public static void IncreaseColumnPanelHeight(GridControl gridControl, GridView gridView) {
            // This property controls the column header row height
            gridView.ColumnPanelRowHeight = 50;

            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase Column Panel height", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ColumnPanelRowHeight += 5;
            };
        }
        [CodeExampleCase("Footer panel height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("FooterPanelHeight")]
        public static void IncreaseFooterPanelHeight(GridControl gridControl, GridView gridView) {
            // The property manages visibility of the footer panel
            gridView.OptionsView.ShowFooter = true;

            // This property controls the footer panel height
            gridView.FooterPanelHeight = 50;
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase footer panel height", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.FooterPanelHeight += 5;
            };
        }
        [CodeExampleCase("Group row height"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GroupRowHeight")]
        public static void IncreaseGroupdRowsHeight(GridControl gridControl, GridView gridView) {
            gridView.Columns[0].Group();
            // This property controls the group rows' height
            gridView.GroupRowHeight = 22;
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase group row height", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.GroupRowHeight += 2;
            };
        }
        [CodeExampleCase("Change row height dynamically"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CalcRowHeight")]
        public static void CustomDynamicRowHeight(GridControl gridControl, GridView gridView) {
            gridView.CalcRowHeight += (sender, e) => {
                if(e.RowHandle % 2 == 0) {
                    e.RowHeight = 50;
                }
            };
        }
        [CodeExampleCase("RowIndicator width"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("IndicatorWidth")]
        public static void IncreaseRowIndicatorWidth(GridControl gridControl, GridView gridView) {
            // Specify the Row Indicator width
            gridView.IndicatorWidth = 25;
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase RowIndicator's width", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.IndicatorWidth += 5;
            };
        }

        [CodeExampleCase("Preview text horizontal offset"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PreviewIndent")]
        public static void IncreasePreviewIndent(GridControl gridControl, GridView gridView) {
            gridView.Columns["Notes"].Visible = false;
            gridView.PreviewFieldName = "Notes";
            gridView.OptionsView.ShowPreview = true;
            // This property gets or sets the horizontal offset of preview text.
            gridView.PreviewIndent = 55;

            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase preview indent", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.PreviewIndent += 5;
            };
        }
        [CodeExampleCase("Manage cell padding"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("UserCellPadding")]
        public static void ManageCellsPaddings(GridControl gridControl, GridView gridView) {
            int all = 1;
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Increase padding", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // The property gets or sets a Padding structure by which the default cell padding is adjusted.
                gridView.UserCellPadding = new Padding(all);
                all++;
            };
        }
        [CodeExampleCase("Save layout"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SaveLayoutToRegistry", "RestoreLayoutFromRegistry", "SaveLayoutToStream", "RestoreLayoutFromStream", "SaveLayoutToXml", "RestoreLayoutFromXml")]
        public static void SaveRestoreLayout(GridControl gridControl, GridView gridView) {
            string regKey = "DevExpress\\XtraGrid\\Layouts\\MainLayout";
            string filePath = "XtraGrid_SaveLayoutToXML.xml";

            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = @"Save/restore layout to/from registry", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.SaveLayoutToRegistry(regKey);
                gridView.RestoreLayoutFromRegistry(regKey);
            };

            SimpleButton b1 = new SimpleButton { Parent = gridControl.Parent, Text = @"Save/restore layout to/from stream", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                using(MemoryStream str = new MemoryStream()) {
                    gridView.SaveLayoutToStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                    // Load the view's layout from a previously saved memory stream.
                    gridView.RestoreLayoutFromStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                }
            };

            SimpleButton b2 = new SimpleButton { Parent = gridControl.Parent, Text = @"Save/restore layout to/from xml", Dock = DockStyle.Top };
            b2.Click += (s, e) => {
                gridView.SaveLayoutToXml(filePath);
                gridView.RestoreLayoutFromXml(filePath);
            };
        }
        [CodeExampleCase("Prevent restoring layout"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("BeforeLoadLayout", "SaveLayoutToStream", "RestoreLayoutFromStream", "Allow")]
        public static void PreventRestoreLayout(GridControl gridControl, GridView gridView) {
            // This event allows you to prevent the layout from being restored from storage
            gridView.BeforeLoadLayout += (s, e) => {
                e.Allow = false;
            };
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Restore layout from stream", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                using(MemoryStream str = new MemoryStream()) {
                    gridView.SaveLayoutToStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                    gridView.Columns[0].Visible = false;
                    // Load the view's layout from a previously saved memory stream.
                    gridView.RestoreLayoutFromStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                }
            };
        }
        [CodeExampleCase("Customize layout during restoration"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("LayoutUpgrade", "LayoutVersion", "SaveLayoutToStream", "RestoreLayoutFromStream")]
        public static void CustomizeLayoutDuringRestoration(GridControl gridControl, GridView gridView) {
            // This event allows you to update the layout while it is being restored from storage
            gridView.LayoutUpgrade += (s, e) => {
                GridView view = s as GridView;
                view.Columns[0].Visible = false;
            };
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Restore layout from stream", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                using(MemoryStream str = new MemoryStream()) {
                    gridView.OptionsLayout.LayoutVersion = "Previous";
                    gridView.SaveLayoutToStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                    gridView.OptionsLayout.LayoutVersion = "Current";
                    gridView.RestoreLayoutFromStream(str);
                    str.Seek(0, SeekOrigin.Begin);
                }
            };
        }
        [CodeExampleCase("Display group headers in a specific style"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GroupRowCollapsing", "CustomDrawGroupRow")]
        public static void DisplayGroupHeadersInASpecificStyle(GridControl gridControl, GridView gridView) {
           
            gridView.Columns["Mark"].Group();
            gridView.ExpandAllGroups();
            gridView.GroupRowHeight = 30;

            gridView.CustomDrawGroupRow +=(s,e)=>{
            GridView view = s as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
           
            e.Appearance.BackColor = view.PaintAppearance.Row.BackColor;
            info.GroupText = string.Empty;
            info.RowState = DevExpress.XtraGrid.Views.Base.GridRowCellState.Default;
            info.ButtonBounds = Rectangle.Empty;
            e.DefaultDraw();
            
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
          
            string groupText = info.GroupValueText;
            e.Appearance.ForeColor = view.PaintAppearance.HideSelectionRow.ForeColor;
            e.Appearance.FontSizeDelta = 2;
            e.Appearance.FontStyleDelta = FontStyle.Bold;
            Size textSize = e.Appearance.CalcTextSizeInt(e.Cache, groupText, info.DataBounds.Width);
            Rectangle textBounds = new Rectangle(info.DataBounds.X + viewInfo.LevelIndent, info.DataBounds.Bottom - textSize.Height, textSize.Width, textSize.Height);
            e.Appearance.DrawString(e.Cache, groupText, textBounds);
            e.Cache.DrawLine(e.Cache.GetPen(e.Appearance.ForeColor), new Point(textBounds.X, info.TotalBounds.Bottom - 2), new Point(info.TotalBounds.Right, info.TotalBounds.Bottom - 2));
            e.Handled = true;
            };

            gridView.GroupRowCollapsing += (s,e)=>{
                e.Allow = false;
            };
        }


        #endregion
    }

}
