using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos {

    static class SalesProductDataGenerator {
        internal class ProductItemBase {
            public string Product { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }
        internal class SaleItemBase {
            [FilterLookup(UseBlanks = false, UseSelectAll = false)]
            public string Category { get; set; }
            public int UnitsSold { get; set; }
            public decimal Revenue { get; set; }
            public int UnitsSoldTarget { get; set; }
            [DataType(DataType.Currency)]
            public decimal RevenueTarget { get; set; }
            [DisplayFormat(DataFormatString = "p")]
            public float SalesDynamic { get { return (float)((Revenue - RevenueTarget) / Revenue); } }
            public DateTime ReportDate { get; set; }
        }
        internal class SaleItem : SaleItemBase {
            public string State { get; set; }
            public string Product { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
        }
        internal class BikeReportItem : SaleItemBase {
        }

        internal static List<string> BikeCategories = new List<string>() {
            "Mountain",
            "Hybrid/Cross",
            "Road",
            "Comfort",
            "Youth",
            "Cruiser",
            "Electric"
        };

        static int GetUnitsSold(string category) {
            int max = category.Equals("Bikes") ? 50 : 250;
            return TutorialConstants.Random.Next(1, max);
        }
        static object CreateProductBase(DataRow dataRow, string categoryName) {
            return new ProductItemBase() {
                Price = dataRow.Field<decimal>("ListPrice"),
                Product = dataRow.Field<string>("Name"),
                Category = categoryName
            };
        }
        static DataSet LoadData(string fileName) {
            string path = Utils.GetRelativePath(string.Format("{0}.xml", fileName));
            if(string.IsNullOrEmpty(path)) {
                XtraMessageBox.Show("The \"" + fileName + ".xml\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            DataSet ds = new DataSet();
            ds.ReadXml(path, XmlReadMode.ReadSchema);
            return ds;
        }
        static List<SaleItem> GenerateData(DataRowCollection regions, IEnumerable<ProductItemBase> products) {
            List<SaleItem> totalSales = new List<SaleItem>();
            foreach(DataRow region in regions) {
                string state = (string)region["Region"];
                int year = TutorialConstants.Today.Year - 1;
                for(int month = 1; month <= 12; month++) {
                    foreach(ProductItemBase product in products) {
                        SaleItem tsItem = new SaleItem { State = state, Category = product.Category, Product = product.Product, Price = product.Price };
                        DateTime dt = new DateTime(year, month, 1);
                        int uSold = GetUnitsSold(product.Category);
                        int uSoldTarget = uSold + TutorialConstants.Random.Next(-(int)(uSold * 0.2), (int)(uSold * 0.2));
                        decimal rev = uSold * product.Price;
                        decimal revTarget = uSoldTarget * product.Price;

                        tsItem.Revenue = rev;
                        tsItem.RevenueTarget = revTarget;
                        tsItem.UnitsSold = uSold;
                        tsItem.UnitsSoldTarget = uSoldTarget;
                        tsItem.ReportDate = dt;

                        totalSales.Add(tsItem);
                    }
                }
            }
            return totalSales;
        }

        internal static List<SaleItem> ExtractData() {
            DataSet dataSet = LoadData("DashboardSales");
            if(dataSet == null)
                return null;

            DataTable products = dataSet.Tables["Products"];
            DataTable categories = dataSet.Tables["Categories"];
            DataTable regions = dataSet.Tables["Regions"];

            IEnumerable<object> items = from t1 in products.AsEnumerable()
                                        join t2 in categories.AsEnumerable()
                                        on t1["CategoryID"] equals t2["CategoryID"]
                                        select CreateProductBase(t1, (string)t2["CategoryName"]);

            return GenerateData(regions.Rows, items.Cast<ProductItemBase>());
        }
        internal static List<BikeReportItem> GenerateBicyclesReport() {
            List<BikeReportItem> result = new List<BikeReportItem>();
            int year = TutorialConstants.Today.Year - 1;
            DateTime startDate = new DateTime(year, 1, 1);
            int averageMonthSold = 1700;
            decimal averagePrice = 900;
            DateTime date = startDate;
            for(int day = 1; day <= 365; day += 7) {
                int minDay = TutorialConstants.Random.Next(100, 200);
                int maxDay = TutorialConstants.Random.Next(250, 300);
                date = startDate.AddDays(day);
                for(int i = 0; i < BikeCategories.Count; i++) {
                    string category = BikeCategories[i];

                    double deltaCorrection = 2 * TutorialConstants.Random.NextDouble() + 0.2;

                    BikeReportItem tsItem = new BikeReportItem { Category = category };
                    double correction = 22 - i * 3 - TutorialConstants.Random.NextDouble();
                    if(day > minDay && day < maxDay)
                        correction += deltaCorrection;
                    if(day > maxDay)
                        correction -= deltaCorrection;

                    int uSold = (int)(averageMonthSold * correction / 100.0);
                    int uSoldTarget = uSold + TutorialConstants.Random.Next(-(int)(uSold * 0.2), (int)(uSold * 0.2));
                    decimal rev = uSold * averagePrice;
                    decimal revTarget = uSoldTarget * averagePrice;

                    tsItem.Revenue = rev;
                    tsItem.RevenueTarget = revTarget;
                    tsItem.UnitsSold = uSold;
                    tsItem.UnitsSoldTarget = uSoldTarget;
                    tsItem.ReportDate = date;

                    result.Add(tsItem);
                }
            }
            return result;
        }
    }
}
