using DevExpress.XtraCharts.Sankey;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace DevExpress.XtraSankey.Demos {
    public partial class CustomNodeOrder : SankeyDemoModuleWithOptions {
        public override SankeyDiagramControl SankeyDiagramControl { get { return sankeyDiagramControl1; } }

        public CustomNodeOrder() {
            InitializeComponent();
            InitComboBoxes();
            ordersTableAdapter1.Fill(nwindDataSet.Orders);
            productsTableAdapter1.Fill(nwindDataSet.Products);
            suppliersTableAdapter1.Fill(nwindDataSet.Suppliers);
            categoriesTableAdapter1.Fill(nwindDataSet.Categories);
            shippersTableAdapter1.Fill(nwindDataSet.Shippers);
            customersTableAdapter1.Fill(nwindDataSet.Customers);
            order_DetailsTableAdapter1.Fill(nwindDataSet.Order_Details);
            SetDataSource();
        }
        void InitComboBoxes() {
            comparerRadioGroup.Properties.Items.Add(new RadioGroupItem(new SankeyNodeComparerItem(new TotalWeightComparer(true), new TotalWeightComparer(false)), "Total Weight"));
            comparerRadioGroup.Properties.Items.Add(new RadioGroupItem(new SankeyNodeComparerItem(new OutputLinkCountComparer(true), new OutputLinkCountComparer(false)), "Output Link Count"));
            comparerRadioGroup.Properties.Items.Add(new RadioGroupItem(new SankeyNodeComparerItem(new NodeNameComparer(true), new NodeNameComparer(false)), "Node Name"));
            comparerRadioGroup.SelectedIndex = 0;

            BoolItem ascendingItem = new BoolItem("Ascending", true);
            orderRadioGroup.Properties.Items.Add(new RadioGroupItem(true, "Ascending"));
            orderRadioGroup.Properties.Items.Add(new RadioGroupItem(false, "Descending"));
            orderRadioGroup.SelectedIndex = 0;
        }
        void SetDataSource() {
            decimal limit = 1900;
            int year = 2016;
            var q0 = nwindDataSet.Order_Details
                .Where(x => (x.UnitPrice * x.Quantity) > limit && x.OrdersRow.OrderDate.Year == year)
                .Select(x => new {
                    Column1 = x.ProductsRow.SuppliersRow.CompanyName,
                    Column2 = x.ProductsRow.CategoriesRow.CategoryName,
                    Column3 = x.UnitPrice * x.Quantity
                });
            var q1 = nwindDataSet.Order_Details
                .Where(x => (x.UnitPrice * x.Quantity) > limit && x.OrdersRow.OrderDate.Year == year)
                .Select(x => new {
                    Column1 = x.ProductsRow.CategoriesRow.CategoryName,
                    Column2 = x.OrdersRow.ShippersRow.CompanyName,
                    Column3 = x.UnitPrice * x.Quantity
                });
            var q2 = nwindDataSet.Order_Details
                .Where(x => (x.UnitPrice * x.Quantity) > limit && x.OrdersRow.OrderDate.Year == year)
                .Select(x => new {
                    Column1 = x.OrdersRow.ShippersRow.CompanyName,
                    Column2 = x.OrdersRow.CustomersRow.Country,
                    Column3 = x.UnitPrice * x.Quantity
                });

            var data = q0.ToList();
            data.AddRange(q1.ToList());
            data.AddRange(q2.ToList());
            sankeyDiagramControl1.DataSource = data;
            sankeyDiagramControl1.SourceDataMember = "Column1";
            sankeyDiagramControl1.TargetDataMember = "Column2";
            sankeyDiagramControl1.WeightDataMember = "Column3";
        }
        void OnCustomizeLinkToolTip(object sender, CustomizeSankeyLinkToolTipEventArgs e) {
            NumberFormatInfo format = CultureInfo.InvariantCulture.NumberFormat;
            e.Content = "$" + e.Link.TotalWeight.ToString("#,0.00", format);
        }
        void OnCustomizeNodeToolTip(object sender, CustomizeSankeyNodeToolTipEventArgs e) {
            string prefix = "";
            switch(e.Node.Level) {
                case 0:
                    prefix = "Company";
                    break;
                case 1:
                    prefix = "Product Category";
                    break;
                case 2:
                    prefix = "Ship mode";
                    break;
                case 3:
                    prefix = "Customer Country";
                    break;
            }
            e.Title = prefix + ": " + e.Title;
            NumberFormatInfo format = CultureInfo.InvariantCulture.NumberFormat;
            e.Content = "$" + e.Node.TotalWeight.ToString("#,0.00", format);
        }

        void RadioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            if(comparerRadioGroup.SelectedIndex >= 0 && orderRadioGroup.SelectedIndex >= 0) {
                SankeyNodeComparerItem nodeComparerItem = (SankeyNodeComparerItem)comparerRadioGroup.Properties.Items[comparerRadioGroup.SelectedIndex].Value;
                bool ascending = (bool)orderRadioGroup.Properties.Items[orderRadioGroup.SelectedIndex].Value;
                sankeyDiagramControl1.NodeComparer = nodeComparerItem.GetComparer(ascending);
            }
        }
    }
}
