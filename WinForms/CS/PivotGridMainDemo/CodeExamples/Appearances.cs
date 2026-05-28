namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    using System;
    using System.Data;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.XtraEditors;
    using DevExpress.XtraPivotGrid;
    using DevExpress.Utils;
    using DevExpress.Utils.Controls;
    using DevExpress.XtraEditors.Controls;
    using System.Drawing;
    using System.Collections.Generic;

    [CodeExampleClass("Appearances", "Appearances.cs")]
    public static class Appearances {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;

            pivotGridControl.BeginInit();
            PivotGridField fieldProductName = new PivotGridField();
            fieldProductName.Area = PivotArea.RowArea;
            fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            fieldProductName.Name = "fieldProductName";

            PivotGridField fieldUnitPrice = new PivotGridField();
            fieldUnitPrice.Area = PivotArea.DataArea;
            fieldUnitPrice.DataBinding = new DataSourceColumnBinding("UnitPrice");
            fieldUnitPrice.Name = "fieldUnitPrice";

            PivotGridField fieldDiscontinued = new PivotGridField();
            fieldDiscontinued.Area = PivotArea.ColumnArea;
            fieldDiscontinued.DataBinding = new DataSourceColumnBinding("Discontinued");
            fieldDiscontinued.Name = "fieldDiscontinued1";

            pivotGridControl.Fields.AddRange(new PivotGridField[] {
                fieldUnitPrice,
                fieldProductName,
                fieldDiscontinued
            });

            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.DataSource = DemoHelper.GetData("Products");
            pivotGridControl.EndInit();

            pivotGridControl.Parent = sampleHost;
            pivotGridControl.BestFit();
            return new object[] { pivotGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            PivotGridControl grid = sampleHost.Controls[0] as PivotGridControl;
            if(grid.HtmlImages != null) {
                grid.HtmlImages = null;
            }
            grid.Dispose();
        }
        [CodeExampleCase("Html drawing for headers", new Type[] { typeof(DemoHelper) })]
        [CodeExampleUnderlineTokens("AllowHtmlDrawHeaders")]
        public static void EnableHeaderHtlmFormatting(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsView.AllowHtmlDrawHeaders = true;
            pivotGridControl.Fields["fieldUnitPrice"].Caption = "<b><color=blue>Unit Price";
            pivotGridControl.Fields["fieldProductName"].Caption = "<b><u> Product Name";
            pivotGridControl.Fields["fieldDiscontinued1"].Caption = "<b><color=blue>Discontinued";
        }
        [CodeExampleCase("Html drawing for field values", new Type[] { typeof(DemoHelper) })]
        [CodeExampleUnderlineTokens("AllowHtmlDrawFieldValues")]
        public static void EnableFieldHtlmFormatting(PivotGridControl pivotGridControl) {
            pivotGridControl.HtmlImages = DemoHelper.GetHtmlImages();
            pivotGridControl.OptionsView.AllowHtmlDrawFieldValues = true;
            pivotGridControl.FieldValueDisplayText += (sender, args) => {
                if(!args.IsPopulatingFilterDropdown && args.ValueType == PivotGridValueType.Value && args.Field.Name == "fieldProductName") {
                    int categoryID = (int)args.CreateDrillDownDataSource().GetValue(0, "CategoryID");
                    string prefix = string.Format("<image={0}>", categoryID);
                    string backColor = DemoHelper.GetCategoryColor(categoryID);
                    if(!string.IsNullOrEmpty(backColor))
                        prefix += string.Format("<backcolor={0}><color=white>", backColor);
                    args.DisplayText = prefix + args.DisplayText;
                }
            };
        }
        [CodeExampleCase("Custom draw for cells", new Type[] { typeof(DemoHelper) })]
        [CodeExampleUnderlineTokens("CustomDrawCell")]
        public static void CustomDrawEvents(PivotGridControl pivotGridControl) {
            var highlightedPoints = new List<Point>(new[] { new Point { X = 0, Y = 2 }, new Point { X = 0, Y = 3 } });
            int time = 0;
            pivotGridControl.CustomDrawCell += (s, e) => {
                bool highlight = highlightedPoints.Contains(new Point(e.ColumnIndex, e.RowIndex));
                e.Appearance.ForeColor = highlight ? Color.FromArgb(255, time % 256, time % 256) : Color.Black;
            };
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 125;
            timer.Tick += (s, e) => {
                time += 32;
                pivotGridControl.Invalidate();
            };
        }
        #region Helpers
        [CodeExampleNestedClass]
        public static class DemoHelper {
            public static DataView GetData(string tableName) {
                return DevExpress.DXperience.Demos.CodeDemo.Data.NWindTables.GetDataView(tableName);
            }
            public static ImageCollection GetHtmlImages() {
                ImageCollection imageCollection = new ImageCollection();
                var dv = GetData("Categories");
                foreach(DataRowView row in dv) {
                    byte[] bytes = row["Icon_25"] as byte[];
                    Image image = ByteImageConverter.FromByteArray(bytes);
                    string imageName = row["CategoryID"].ToString().Trim();
                    imageCollection.AddImage(image, imageName);
                }
                return imageCollection;
            }
            public static string GetCategoryColor(int categoryID) {
                switch(categoryID) {
                    case 1:
                    case 5:
                    return "#F4A460";
                    case 2:
                    case 3:
                    return "#8B4513";
                    case 4:
                    return "#FFA500";
                    case 6:
                    return "#FFB6C1";
                    case 7:
                    return "#90EE90";
                    case 8:
                    return "#6495ED";
                    default:
                    return string.Empty;
                }
            }
        }
        #endregion
    }
}
