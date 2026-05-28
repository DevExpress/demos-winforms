using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Master-detail mode", "MasterDetail.cs")]
    public static class MasterDetail {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region Data classes
        [CodeExampleNestedClass("")]
        public class Product {
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        [CodeExampleNestedClass("")]
        public class Category {
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

        #region MasterDetail
        [CodeExampleCase("Create pattern detail View", new Type[] { typeof(Category), typeof(Product)})]
        [CodeExampleUnderlineTokens("ViewCollection", "LevelTree", "Nodes")]
        public static void CreatePatternDetailView(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            // Create a new detail pattern view
            GridView detailPatternView = new GridView { ViewCaption = Category.ProductsLevelName };
            detailPatternView.Appearance.Row.BackColor = Color.Coral;
            detailPatternView.Appearance.Row.Options.UseBackColor = true;
            gridControl.ViewCollection.Add(detailPatternView);

            // Associate the detailPatternView view with the Products level
            gridControl.LevelTree.Nodes.Add(Category.ProductsLevelName, detailPatternView);
        }

        [CodeExampleCase("Detail View height", new Type[] { typeof(Category), typeof(Product) })]
        [CodeExampleUnderlineTokens("DetailHeight")]
        public static void RestrictDetailViewHeight(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            GridView detailPatternView = new GridView { ViewCaption = Category.ProductsLevelName };
            gridControl.ViewCollection.Add(detailPatternView);
            gridControl.LevelTree.Nodes.Add(Category.ProductsLevelName, detailPatternView);
            // Restrict detail View height
            detailPatternView.DetailHeight = 100;
        }

        [CodeExampleCase("How to prevent loading detail data for certain master rows", new Type[] { typeof(Category), typeof(Product) })]
        [CodeExampleUnderlineTokens("MasterRowEmpty", "IsEmpty")]
        public static void PreventLoadingMasterRowsData(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            //The MasterRowEmpty event allows you to specify whether a particular detail is empty.
            // This event fires only if the GridView.OptionsDetail.AllowExpandEmptyDetails option is set to false. 

           gridView.MasterRowEmpty += (s, e) => {
                if (e.RowHandle % 2 == 0)
                    e.IsEmpty = true;
            };
        }

        [CodeExampleCase("Prohibit expanding certain master rows", new Type[] { typeof(Category), typeof(Product) })]
        [CodeExampleUnderlineTokens("MasterRowExpanding", "Allow")]
        public static void ProhibitExpandCertainMasterRows(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            // You can handle the MasterRowExpanding event to manage whether particular details can be displayed.
            gridView.MasterRowExpanding += (s, e) => {
                e.Allow = e.RowHandle % 2 == 0 && e.RelationIndex == 0;
            };
        }
        [CodeExampleCase("Hide master row expand buttons", new Type[] { typeof(Category), typeof(Product) })]
        [CodeExampleUnderlineTokens("ShowDetailButtons", "ExpandMasterRow", "CollapseMasterRow")]
        public static void HideExpandButtons(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            //Hide detail expand buttons
            gridView.OptionsView.ShowDetailButtons = false;
            SpinEdit masterRowHandleSpinEdit = new SpinEdit { Parent = gridControl.Parent, Dock = DockStyle.Top, EditValue = 0 };
            masterRowHandleSpinEdit.Properties.MinValue = 0;
            masterRowHandleSpinEdit.Properties.MaxValue = gridView.DataRowCount - 1;
            masterRowHandleSpinEdit.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            LabelControl masterRowHandleSpinEditLabel = new LabelControl { Text = "Master row handle", Dock = DockStyle.Top, Parent = gridControl.Parent };

            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Expand master row", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ExpandMasterRow(Convert.ToInt32(masterRowHandleSpinEdit.EditValue));
            };

            SimpleButton b1 = new SimpleButton { Parent = gridControl.Parent, Text = "Collapse master row", Dock = DockStyle.Top };
            b1.Click += (s, e) => {
                gridView.CollapseMasterRow(Convert.ToInt32(masterRowHandleSpinEdit.EditValue));
            };
        }

        [CodeExampleCase("Assign detail view dynamically", new Type[] { typeof(Category), typeof(Product)})]
        [CodeExampleUnderlineTokens("MasterRowGetLevelDefaultView", "DefaultView")]
        public static void MasterRowGetLevelDefaultView(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = Category.GetMasterDetailData();
            // Create a new view to use as a detail pattern View
            GridView newDetailView = gridControl.CreateView("GridView") as GridView;
            newDetailView.Appearance.Row.BackColor = Color.LightBlue;
            newDetailView.Appearance.Row.BackColor2 = Color.RoyalBlue;

            // Handle this event to specify a view to represent a particular detail
            gridView.MasterRowGetLevelDefaultView += (s, e) => {
                if (e.RowHandle % 2 == 0)
                    e.DefaultView = newDetailView;
            };
        }
        [CodeExampleCase("Master-detail mode using events"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("MasterRowGetRelationCount", "MasterRowEmpty", "RelationCount", "IsEmpty", "MasterRowGetChildList", "ChildList", "MasterRowGetRelationName", "RelationName")]
        public static void MasterDetailsUsingEvents(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = SampleData.GetData(4);
            // Handle the MasterRowGetRelationCount event to specify the number of master-detail relationships for each master row
            gridView.MasterRowGetRelationCount += (s, e) => {
                e.RelationCount = 1;
            };

            // Handle the MasterRowEmpty event to specify whether or not the current detail has data
            gridView.MasterRowEmpty += (s, e) => {
                e.IsEmpty = false;
            };

            // Handle the MasterRowGetChildList event to provide data for the current detail. 
            // The detail is identified by the master row handle and relation index. 
            gridView.MasterRowGetChildList += (s, e) => {
                e.ChildList = SampleData.GetData(4).ToList();
            };

            // Handle the MasterRowGetRelationName event to provide a name for the current detail
            gridView.MasterRowGetRelationName += (s, e) => {
                e.RelationName = "TestName";
            };
        }

        [CodeExampleCase("Load details asynchronously"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AllowExpandEmptyDetails", "MasterRowGetRelationCount", "MasterRowEmpty", "MasterRowGetChildList", "MasterRowGetRelationName")]
        public static void MasterRowGetChildListAsync(GridControl gridControl, GridView gridView) {
            gridControl.DataSource = SampleData.GetData(4);

            //Set this property to true to allow expanding empty details
            gridView.OptionsDetail.AllowExpandEmptyDetails = true;

            //Handle the MasterRowGetRelationCount event to specify the number of master-detail relationships for each master row
            gridView.MasterRowGetRelationCount += (s, e) => {
                e.RelationCount = 1;
            };

            //Handle the MasterRowEmpty event to specify whether or not the current detail has data
            gridView.MasterRowEmpty += (s, e) => {
                e.IsEmpty = false;
            };

            //Handle the MasterRowGetChildList event to provide data for the current detail.
            //  The detail is identified by the master row handle and relation index.
            gridView.MasterRowGetChildList += async (s, e) => {
                BindingList<SampleData> childList = new BindingList<SampleData>();
                e.ChildList = childList;

                IList<SampleData> tempList = await System.Threading.Tasks.Task.Run(() => {
                    // Imitation of long data loading
                    System.Threading.Thread.Sleep(1000);
                    // Load data
                    return SampleData.GetData(4);
                });

                // Add the loaded data to the childList list on the UI thread
                foreach(SampleData current in tempList)
                    childList.Add(current);
            };

            // Handle the MasterRowGetRelationName event to provide a name for the current detail
            gridView.MasterRowGetRelationName += (s, e) => {
                e.RelationName = "TestName";
            };
        }
        #endregion
    }
}
