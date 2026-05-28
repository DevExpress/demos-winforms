using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class SunburstInteraction : TreeMapTutorialControl {
        readonly List<SaleItem> dataSource;
        public SunburstInteraction() {
            InitializeComponent();
            dataSource = SaleItem.GetProductsByCompanies();
            ((SunburstFlatDataAdapter)sunburstControl1.DataAdapter).DataSource = dataSource;
            UpdateChartColorizer((int i) => {
                SeriesColorizer.Keys.Add(sunburstControl1.Groups.ElementAt(i).GroupValue);
                SeriesColorizer.Palette.Add(PaletteHelper.InteractionDemoPalette[i]);
            });
            sunburstControl1.SelectedGroups.Add(SaleItem.Companies[0]);
            sunburstControl1.SelectedGroups.Add(SaleItem.Companies[1]);
        }
        SeriesKeyColorColorizer SeriesColorizer {
            get { return (SeriesKeyColorColorizer)chartControl1.SeriesTemplate.SeriesColorizer; }
        }
        public override Control ActiveDemoModule {
            get { return sunburstControl1; }
        }
        void SunburstControl1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            chartControl1.DataSource = null;
            IList selectedItems = e.SelectedItems as IList;
            if(selectedItems != null)
                chartControl1.DataSource = selectedItems.Count > 0 ? selectedItems : dataSource;
        }
        void UpdateChartColorizer(Action<int> updateColorizerAction) {
            PaletteHelper.UpdateInteractionDemoPalette(sunburstControl1.LookAndFeel);
            SeriesColorizer.Palette = new XtraCharts.Palette("");
            for(int i = 0; i < sunburstControl1.Groups.Count(); i++)
                updateColorizerAction(i);
        }
        void SunburstInteraction_Resize(object sender, EventArgs e) {
            if(ClientSize.Width < ClientSize.Height)
                return;
            chartControl1.Width = Math.Max(200, ClientSize.Width - ClientSize.Height);
            sunburstControl1.Width = ClientSize.Width - chartControl1.Width;
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateChartColorizer((int i) => { SeriesColorizer.Palette.Add(PaletteHelper.InteractionDemoPalette[i]); });
        }
    }

    class SaleItem {
        static Dictionary<string, List<string>> _categorizedProducts;
        static Dictionary<string, List<string>> CategorizedProducts {
            get {
                if(_categorizedProducts == null) {
                    _categorizedProducts = new Dictionary<string, List<string>>();
                    _categorizedProducts["Cameras"] = new List<string>() { "Camera", "Camcorder", "Binoculars", "Flash", "Tripod" };
                    _categorizedProducts["Cell Phones"] = new List<string>() { "Smartphone", "Sim Card" };
                    _categorizedProducts["Computers"] = new List<string>() { "Desktop", "Laptop", "Tablet", "Printer" };
                }
                return _categorizedProducts;
            }
        }

        public static readonly string[] Companies = new string[] { "North", "South", "West", "East"/*, "DevAV Central" */};
        public static List<SaleItem> GetProductsByCompanies() {
            Data.Utils.NonCryptographicRandom rnd = Data.Utils.NonCryptographicRandom.System;
            List<SaleItem> items = new List<SaleItem>();
            foreach(string company in Companies) {
                foreach(string category in CategorizedProducts.Keys) {
                    foreach(string product in CategorizedProducts[category]) {
                        int income = rnd.Next(20, 100);
                        int revenue = income + rnd.Next(20, 50);
                        items.Add(new SaleItem() {
                            Company = company,
                            Product = product,
                            Income = income,
                            Revenue = revenue,
                            Category = category
                        });
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
}
