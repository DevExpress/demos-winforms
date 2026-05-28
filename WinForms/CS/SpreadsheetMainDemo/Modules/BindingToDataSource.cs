using System;
using System.Data;
using System.Text;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Demos.Modules.DataBinding;
using DevExpress.XtraSpreadsheet.Demos.Modules.DataBinding.nwindOrdersTableAdapters;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class BindingToDataSourceModule : SpreadsheetRibbonTutorialControlBase {
        DataView dataView;
        CellRange previousRange;
        bool locked = false;

        public BindingToDataSourceModule() {
            InitializeComponent();
            InitializeBindToData();

            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"));

            nwindOrders dataSet = new nwindOrders();
            BindEditors(dataSet);
            BindDataSource(dataSet);
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        private void BindDataSource(nwindOrders dataSet) {
            OrderDetailsTableAdapter orderDetailsAdapter = new OrderDetailsTableAdapter();
            orderDetailsAdapter.Fill(dataSet.OrderDetails);
            dataView = new DataView(dataSet.OrderDetails);
            dataView.Sort = "OrderID";
            BindDataSourceToWorksheet();
        }

        private void BindDataSourceToWorksheet() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet sheet = workbook.Worksheets[0];
            sheet.DataBindings.BindToDataSource(dataView, 4, 1);
            UpdateTotalPrice();
        }

        private void BindDataSourceToTable() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet sheet = workbook.Worksheets[0];
            workbook.BeginUpdate();
            try {
                ExternalDataSourceOptions options = new ExternalDataSourceOptions() { ImportHeaders = true };
                Table table = sheet.Tables.Add(dataView, 3, 1, options);
                table.Columns[0].Name = "Order ID";
                table.Columns[1].Name = "Product";
                table.Columns[2].Name = "Supplier";
                table.Columns[3].Name = "Unit Price";
                table.Columns[4].Name = "Quantity";
                table.Columns[5].Name = "Discount";
                TableColumn subtotalColumn = table.Columns.Add();
                subtotalColumn.Name = "Subtotal";
                subtotalColumn.Formula = "=[Unit Price]*[Quantity]*(1-[Discount])";
                subtotalColumn.TotalRowFunction = TotalRowFunction.Sum;
                table.Columns[0].TotalRowLabel = "Total";
                table.ShowTotals = true;
            }
            finally {
                workbook.EndUpdate();
            }
        }

        private void BindEditors(nwindOrders dataSet) {
            // Order ID
            OrdersTableAdapter ordersAdapter = new OrdersTableAdapter();
            ordersAdapter.Fill(dataSet.Orders);
            edOrderId.Properties.DataSource = dataSet.Orders;
            edOrderId.Properties.Columns.Add(new XtraEditors.Controls.LookUpColumnInfo("OrderID"));
            edOrderId.Properties.DisplayMember = "OrderID";
            edOrderId.Properties.ValueMember = "OrderID";
            // Product
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            productsAdapter.Fill(dataSet.Products);
            edProductName.Properties.DataSource = dataSet.Products;
            edProductName.Properties.Columns.Add(new XtraEditors.Controls.LookUpColumnInfo("ProductName"));
            edProductName.Properties.DisplayMember = "ProductName";
            edProductName.Properties.ValueMember = "ProductName";
        }

        private void OrderId_EditValueChanged(object sender, EventArgs e) {
            if(!locked)
                SetupDataView();
        }

        private void ProductName_EditValueChanged(object sender, EventArgs e) {
            if(!locked)
                SetupDataView();
        }

        private void Discount_CheckedChanged(object sender, EventArgs e) {
            if(!locked)
                SetupDataView();
        }

        private void Reset_Click(object sender, EventArgs e) {
            locked = true;
            try {
                edOrderId.EditValue = null;
                edProductName.EditValue = null;
                chbDiscount.Checked = false;
                SetupDataView();
            }
            finally {
                locked = false;
            }
        }

        private void SetupDataView() {
            if(dataView == null)
                return;
            StringBuilder sb = new StringBuilder();
            if(!string.IsNullOrEmpty(edOrderId.Text))
                sb.AppendFormat("OrderID = {0}", edOrderId.Text);
            if(!string.IsNullOrEmpty(edProductName.Text)) {
                if(sb.Length > 0)
                    sb.Append(" AND ");
                sb.AppendFormat("ProductName = '{0}'", edProductName.Text.Replace("'", "''"));
            }
            if(chbDiscount.Checked) {
                if(sb.Length > 0)
                    sb.Append(" AND ");
                sb.Append("Discount > 0");
            }
            spreadsheetControl1.BeginUpdate();
            try {
                dataView.RowFilter = sb.ToString();
                if(cbxBindToData.SelectedIndex == 0)
                    UpdateTotalPrice();
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        private void UpdateTotalPrice() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.BeginUpdate();
            try {
                Worksheet sheet = workbook.Worksheets[0];
                CellRange currentRange = sheet.DataBindings[0].Range;
                CellRange subtotalRange;
                if(previousRange != null) {
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex);
                    subtotalRange.ClearContents();
                    if(currentRange.RowCount < previousRange.RowCount) {
                        subtotalRange = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1);
                        subtotalRange.ClearContents();
                    }
                    previousRange = null;
                }
                if(dataView.Count > 0) {
                    previousRange = currentRange;
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex);
                    subtotalRange.FormulaInvariant = "=E5*F5*(1-G5)";
                    CellRange range = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1);
                    range.Value = "Total";
                    range = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1);
                    range.FormulaInvariant = string.Format("=SUBTOTAL(9,{0})", subtotalRange.GetReferenceA1());
                }
            }
            finally {
                workbook.EndUpdate();
            }
        }

        private void InitializeBindToData() {
            locked = true;
            try {
                cbxBindToData.SelectedIndex = 0;
            }
            finally {
                locked = false;
            }
        }

        private void ClearDataBindings() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet sheet = workbook.Worksheets[0];
            sheet.DataBindings.Clear();
        }

        private void BindToData_SelectedIndexChanged(object sender, EventArgs e) {
            if(locked)
                return;
            ClearDataBindings();
            if(cbxBindToData.SelectedIndex == 0) {
                previousRange = null;
                spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"));
                BindDataSourceToWorksheet();
            }
            else {
                spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToTable_template.xlsx"));
                BindDataSourceToTable();
            }
        }
    }
}
