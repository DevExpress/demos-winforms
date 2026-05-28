using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraCharts.Heatmap;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapSelection : TreeMapTutorialControl {
        HeatmapDataSourceAdapter HeatmapDataAdapter { get { return (HeatmapDataSourceAdapter)heatmapControl1.DataAdapter; } }
        public override Control ActiveDemoModule { get { return heatmapControl1; } }

        public HeatmapSelection() {
            InitializeComponent();
            List<ProductSale> data = LoadData();
            HeatmapDataAdapter.DataSource = data;
            HeatmapDataAdapter.XArgumentComparer = new OriginalOrderComparer();
            heatmapControl1.SelectedItems.Add(data[0]);
        }

        List<ProductSale> LoadData() {
            List<ProductSale> data = new List<ProductSale>();
            try {
                XDocument sales_xml = XDocument.Load(Utils.GetRelativePath("ProductSales.xml"));
                foreach(XElement monthSale in sales_xml.Root.Elements()) {
                    string product = monthSale.Element("Product").Value;
                    string month = monthSale.Element("Month").Value;
                    List<DailySale> dailySales = new List<DailySale>();
                    foreach(XElement daySale in monthSale.Elements("SalesByDay").Elements("DailySale")) {
                        dailySales.Add(new DailySale() {
                            Product = product,
                            Date = Convert.ToDateTime(daySale.Element("Date").Value),
                            Revenue = Convert.ToDouble(daySale.Element("Revenue").Value)
                        });
                    }
                    data.Add(new ProductSale() { SalesByDay = dailySales });
                }
            }
            catch {
            }
            return data;
        }

        void heatmapControl1_SelectedItemsChanged(object sender, XtraCharts.SelectedItemsChangedEventArgs e) {
            List<DailySale> list = new List<DailySale>();
            foreach(ProductSale item in heatmapControl1.SelectedItems)
                list.AddRange(item.SalesByDay);
            chartControl1.DataSource = list;
        }
    }

    public class ProductSale {
        public string Product { get { return SalesByDay[0].Product; } }
        public string Month { get { return SalesByDay[0].Date.ToString("MMMM"); } }
        public double RevenueByMonth { get { return SalesByDay.Sum(s => s.Revenue); } }

        public List<DailySale> SalesByDay { get; set; }
    }
    public class DailySale {
        public string Product { get; set; }
        public double Revenue { get; set; }
        public DateTime Date { get; set; }
    }
    public class OriginalOrderComparer : IComparer {
        int IComparer.Compare(object x, object y) {
            return 0;
        }
    }
}
