using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraCharts.Demos {
    class SaleItem {
        readonly static string[] companies = new string[] { "DevAV North", "DevAV South", "DevAV West", "DevAV East", "DevAV Central" };
        static Dictionary<string, List<string>> categorizedProducts;

        internal static Dictionary<string, List<string>> CategorizedProducts {
            get {
                if(categorizedProducts == null) {
                    categorizedProducts = new Dictionary<string, List<string>>();
                    categorizedProducts["Cameras"] = new List<string>() { "Camera", "Camcorder", "Binoculars", "Flash", "Tripod" };
                    categorizedProducts["Cell Phones"] = new List<string>() { "Smartphone", "Mobile Phone", "Smart Watch", "Sim Card" };
                    categorizedProducts["Computers"] = new List<string>() { "Desktop", "Laptop", "Tablet", "Printer" };
                    categorizedProducts["TV, Audio"] = new List<string>() { "Television", "Home Audio", "Headphone", "DVD Player" };
                    categorizedProducts["Vehicle Electronics"] = new List<string>() { "GPS Unit", "Radar", "Car Alarm", "Car Accessories" };
                    categorizedProducts["Multipurpose Batteries"] = new List<string>() { "Battery", "Charger", "Converter", "Tester", "AC/DC Adapter" };
                }
                return categorizedProducts;
            }
        }

        internal static List<SaleItem> GetProductsByMonths() {
            List<SaleItem> items = new List<SaleItem>();
            foreach(string company in companies)
                foreach(string product in CategorizedProducts["Cameras"]) {
                    DateTime dateTime = new DateTime(2017, 12, 01);
                    for(int i = 0; i < 12; i++) {
                        int income = TutorialConstants.Random.Next(20, 100);
                        int revenue = income + TutorialConstants.Random.Next(20, 50);
                        items.Add(new SaleItem() {
                            Company = company,
                            Product = product,
                            Month = dateTime.AddMonths(1).ToString("MMMM", CultureInfo.InvariantCulture),
                            Income = income,
                            Revenue = revenue
                        });
                        dateTime = dateTime.AddMonths(1);
                    }
                }
            return items;
        }
        internal static List<SaleItem> GetProductsByCompany(int companyIndex) {
            NonCryptographicRandom rnd = new NonCryptographicRandom(companyIndex);
            List<SaleItem> items = new List<SaleItem>();
            foreach(string category in CategorizedProducts.Keys) {
                foreach(string product in CategorizedProducts[category]) {
                    int income = rnd.Next(20, 100);
                    int revenue = income + rnd.Next(20, 50);
                    items.Add(new SaleItem() {
                        Company = companies[companyIndex],
                        Product = product,
                        Income = income,
                        Revenue = revenue,
                        Category = category
                    });
                }
            }
            return items;
        }
        internal static List<CategorySaleItem> GetProductsCategoriesByMonth() {
            NonCryptographicRandom rnd = new NonCryptographicRandom(TutorialConstants.Now.Millisecond);
            List<CategorySaleItem> categoryItems = new List<CategorySaleItem>();
            int productIndex = 0;
            foreach(string category in CategorizedProducts.Keys) {
                CategorySaleItem categoryItem = new CategorySaleItem() { Category = category };
                foreach(string product in CategorizedProducts[category]) {
                    DateTime dateTime = new DateTime(2017, 12, 01);
                    DataGenerator generator = new DataGenerator(productIndex++, rnd.Next(20, 30));
                    List<DataPoint> incomes = generator.GenerateData(SeriesDataType.ArgumentValue, 12);
                    for(int i = 0; i < 12; i++) {
                        categoryItem.SaleItems.Add(new SaleItem() {
                            Category = category,
                            Product = product,
                            OrderDate = dateTime.AddMonths(1),
                            Income = incomes[i].Value
                        });
                        dateTime = dateTime.AddMonths(1);
                    }
                }
                categoryItems.Add(categoryItem);
            }
            List<CategorySaleItem> sortedCategory = categoryItems.OrderBy(c => c.TotalIncome).ToList();
            for(int i = 0; i < sortedCategory.Count; i++)
                sortedCategory[i].OrderIndex = i;
            return sortedCategory;
        }
        internal static List<SaleItem> GetProductsIncome() {
            NonCryptographicRandom rnd = new NonCryptographicRandom(TutorialConstants.Now.Millisecond);
            List<SaleItem> items = new List<SaleItem>();
            for(int i = 0; i < 50; i++)
                foreach(string product in CategorizedProducts["Cameras"]) {
                    items.Add(new SaleItem() {
                        Product = product,
                        Income = rnd.Next(20, 100)
                    });
                }
            return items;
        }
        internal static List<SaleItem> GetTotalIncome() {
            NonCryptographicRandom rnd = new NonCryptographicRandom(TutorialConstants.Now.Millisecond);
            DateTime now = TutorialConstants.Now;
            DateTime endDate = new DateTime(now.Year, now.Month, 1);
            List<SaleItem> items = new List<SaleItem>();
            foreach(string company in companies) {
                double companyFactor = rnd.NextDouble() * 0.6 + 1;
                foreach(string category in CategorizedProducts.Keys) {
                    double categoryFactor = rnd.NextDouble() * 0.6 + 1;
                    foreach(string product in CategorizedProducts[category]) {
                        int maxIncome = rnd.Next(60, 140);
                        for(int i = 0; i < 1000; i++) {
                            if(i % 100 == 0)
                                maxIncome = Math.Max(40, rnd.Next(maxIncome - 20, maxIncome + 20));
                            DateTime date = endDate.AddDays(-i - 1);
                            double income = rnd.Next(20, maxIncome) * companyFactor * categoryFactor;
                            items.Add(new SaleItem() { Category = category, Company = company, Product = product, OrderDate = date, Income = income });
                        }
                    }
                }
            }
            return items;
        }

        public string Product { get; set; }
        public string Company { get; set; }
        public DateTime OrderDate { get; set; }
        public string Month { get; set; }
        public double Income { get; set; }
        public double Revenue { get; set; }
        public string Category { get; set; }
    }


    class CategorySaleItem {
        readonly List<SaleItem> saleItems = new List<SaleItem>();
        Dictionary<string, double> productIncome;

        public int OrderIndex { get; set; }
        public string Category { get; set; }
        public List<SaleItem> SaleItems { get { return saleItems; } }
        public double TotalIncome { get { return saleItems.Sum((x) => x.Income); } }
        public Dictionary<string, double> ProductIncome {
            get {
                if(productIncome == null) {
                    productIncome = new Dictionary<string, double>();
                    foreach(SaleItem item in SaleItems)
                        if(productIncome.Keys.Contains(item.Product))
                            productIncome[item.Product] += item.Income;
                        else
                            productIncome[item.Product] = item.Income;
                }
                return productIncome;
            }
        }
    }
}
