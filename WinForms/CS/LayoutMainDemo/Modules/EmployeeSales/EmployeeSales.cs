using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Internal;

namespace DevExpress.XtraLayout.Demos {
    public partial class EmployeeSales : TutorialControl {
        //<layoutGridControl>//<bandGridControl>
        List<Color> FillColors = new List<Color>(new Color[] {
            DXSkinColors.FillColors.Danger,
            DXSkinColors.FillColors.Primary,
            DXSkinColors.FillColors.Question,
            DXSkinColors.FillColors.Success,
            DXSkinColors.FillColors.Warning
        });
        //</layoutGridControl>//</bandGridControl>
        public EmployeeSales() {
            InitializeComponent();
            InitData();
            InitGridControl();
            InitAllColorPickEdits(true);
        }
        protected override string WhatsThisXMLFileName { get { return "EmployeeSales"; } }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "EmployeeSales" }; } }

        void InitAllColorPickEdits(bool subscribe) {
            InitColorPickEdit(DXSkinColors.FillColors.Danger, 0, colorPickEdit1, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Primary, 1, colorPickEdit2, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Question, 2, colorPickEdit3, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Success, 3, colorPickEdit4, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Warning, 4, colorPickEdit5, subscribe);
        }
        void InitColorPickEdit(Color clr, int q, ColorPickEdit colorPickEdit, bool subscribe) {
            colorPickEdit.Properties.AutomaticColor = clr;
            colorPickEdit.EditValue = clr;
            colorPickEdit.Tag = q;
            if(!subscribe) return;
            colorPickEdit.ColorChanged += (s, e) => {
                ColorPickEdit edit = s as ColorPickEdit;
                FillColors[(int)edit.Tag] = edit.Color;
                bandedGridView1.BeginUpdate();
                //<bandGridControl>
                foreach(GridBand band in bandedGridView1.Bands) {
                    if(band.Tag != null)
                        band.AppearanceHeader.BackColor = FillColors[(((int)band.Tag) - 1) % FillColors.Count];
                }
                //</bandGridControl>
                bandedGridView1.EndUpdate();
                Refresh();
            };
        }
        void layoutControlGroup2_CustomButtonClick(object sender, XtraBars.Docking2010.BaseButtonEventArgs e) {
            InitAllColorPickEdits(false);
        }
        //<bandGridControl>
        void bandedGridView1_CustomDrawCell(object sender, XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column != colProductName) return;
            if(bandedGridView1.FocusedRowHandle == e.RowHandle && bandedGridView1.FocusedColumn != e.Column) return;
            dsOrder.CategoryProductsRow row = (bandedGridView1.GetRow(e.RowHandle) as DataRowView).Row as dsOrder.CategoryProductsRow;
            e.Appearance.ForeColor = DXSkinColors.ForeColors.InnerColors[(row.CategoryID - 1) % DXSkinColors.ForeColors.InnerColors.Count];
        }
        //</bandGridControl>
        //<layoutGridControl>
        void layoutView1_CustomCardStyle(object sender, XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e) {
            dsOrder.EmployeesRow row = (layoutView1.GetRow(e.RowHandle) as DataRowView).Row as dsOrder.EmployeesRow;
            e.Appearance.BorderColor = FillColors[(row.EmployeeID - 1) % FillColors.Count];
        }
        //</layoutGridControl>
        #region FilteringUI
        void layoutView1_ColumnFilterChanged(object sender, EventArgs e) {
            if(!layoutView1.IsVisible || (!string.IsNullOrEmpty(layoutView1.ActiveFilterString) && layoutView1.RowCount == dsOrder.Employees.Count)) return;
            bandedGridView1.BeginUpdate();
            foreach(GridBand band in bandedGridView1.Bands) {
                if(band.Tag != null)
                    band.Visible = false;
            }
            for(int i = 0; i < layoutView1.RowCount; i++) {
                dsOrder.EmployeesRow row = (layoutView1.GetRow(i) as DataRowView).Row as dsOrder.EmployeesRow;
                bandedGridView1.Bands[row.EmployeeID.ToString()].Visible = true;
                bandedGridView1.Bands[row.EmployeeID.ToString()].VisibleIndex = 3 + i;
            }
            bandedGridView1.EndUpdate();
        }
        #endregion
        #region Edit
        void repositoryItemHypertextLabel1_Click(object sender, EventArgs e) {
            layoutView1.CloseEditor();
            ShowEditForm();
        }

        void layoutView1_CardClick(object sender, XtraGrid.Views.Layout.Events.CardClickEventArgs e) {
            if(e.Clicks != 2 || e.Button != MouseButtons.Left) return;
            ShowEditForm();
        }
        void ShowEditForm() {
            FlyoutDialog.Show(FindForm(), new EmployeeEdit(dsOrder, ((layoutView1.GetFocusedRow() as DataRowView).Row as dsOrder.EmployeesRow).EmployeeID));
        }
        #endregion
        #region Data
        const string layoutViewFilter = @"[FullName] In ('Andrew Fuller', 'Janet Leverling', 'Margaret Peacock')";
        const string bandedViewFilter = @"[CategoryName] In ('Condiments', 'Beverages')";
        Dictionary<EmployeeProductKey, EmployeeProductAnalytics> dictionary = new Dictionary<EmployeeProductKey, EmployeeProductAnalytics>();
        void InitGridControl() {
            for(int i = 0; i < dsOrder.Employees.Count; i++) {
                dsOrder.EmployeesRow employeeRow = dsOrder.Employees[i];
                GridBand newBand = bandedGridView1.Bands.Add();
                newBand.Tag = employeeRow.EmployeeID;
                newBand.Name = employeeRow.EmployeeID.ToString();
                newBand.Caption = employeeRow.FirstName + " " + employeeRow.LastName;
                newBand.AppearanceHeader.BackColor = FillColors[(employeeRow.EmployeeID - 1) % FillColors.Count];
                newBand.Visible = employeeRow.LastName == "Fuller" || employeeRow.LastName == "Leverling" || employeeRow.LastName == "Peacock";
                newBand.VisibleIndex = gridBand1.VisibleIndex + i + 1;
                newBand.Width = gridBand1.Width;
                BandedGridColumn totalSalesColumn = new BandedGridColumn() {
                    FieldName = "TotalSales" + employeeRow.EmployeeID.ToString(),
                    Caption = "Total",
                    Tag = employeeRow.EmployeeID,
                    Visible = true,
                    MinWidth = 65,
                    UnboundType = DevExpress.Data.UnboundColumnType.Decimal };
                totalSalesColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                totalSalesColumn.DisplayFormat.FormatString = "c2";
                totalSalesColumn.Summary.Add(new GridColumnSummaryItem(Data.SummaryItemType.Sum, totalSalesColumn.FieldName, "{0:c0}"));
                BandedGridColumn salesTrendColumn = new BandedGridColumn() {
                    FieldName = "SalesTrend" + employeeRow.EmployeeID.ToString(),
                    Caption = "Trend", Tag = employeeRow.EmployeeID,
                    Visible = true,
                    MinWidth = 80,
                    UnboundType = Data.UnboundColumnType.Object,
                    ColumnEdit = repositoryItemSparklineEdit1 };
                BandedGridColumn salesCountColumn = new BandedGridColumn() {
                    FieldName = "SalesCount" + employeeRow.EmployeeID.ToString(),
                    Caption = "Sales",
                    Tag = employeeRow.EmployeeID,
                    Visible = true,
                    MinWidth = 40,
                    UnboundType = Data.UnboundColumnType.Decimal };
                salesCountColumn.Summary.Add(new GridColumnSummaryItem(Data.SummaryItemType.Sum, salesCountColumn.FieldName, "{0}"));
                bandedGridView1.Columns.Add(totalSalesColumn);
                bandedGridView1.Columns.Add(salesTrendColumn);
                bandedGridView1.Columns.Add(salesCountColumn);
                newBand.Columns.Add(salesCountColumn);
                newBand.Columns.Add(salesTrendColumn);
                newBand.Columns.Add(totalSalesColumn);
            }
            layoutView1.ActiveFilterString = layoutViewFilter;
            bandedGridView1.ActiveFilterString = bandedViewFilter;
            bandedGridView1.BestFitColumns();
        }
        void gridView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.IsSetData) return;
            if(e.Column.FieldName.StartsWith("TotalSales")) {
                dsOrder.CategoryProductsRow categoryProductsRow = (e.Row as DataRowView).Row as dsOrder.CategoryProductsRow;
                EmployeeProductAnalytics analytics = null;
                dictionary.TryGetValue(new EmployeeProductKey((int)e.Column.Tag, categoryProductsRow.ProductID), out analytics);
                e.Value = analytics == null ? 0 : analytics.TotalSale;
            }
            if(e.Column.FieldName.StartsWith("SalesTrend")) {
                dsOrder.CategoryProductsRow categoryProductsRow = (e.Row as DataRowView).Row as dsOrder.CategoryProductsRow;
                EmployeeProductAnalytics analytics = null;
                dictionary.TryGetValue(new EmployeeProductKey((int)e.Column.Tag, categoryProductsRow.ProductID), out analytics);
                e.Value = analytics == null ? new List<decimal>() : analytics.SalesTrend;
            }
            if(e.Column.FieldName.StartsWith("TotalQuantities")) {
                dsOrder.CategoryProductsRow categoryProductsRow = (e.Row as DataRowView).Row as dsOrder.CategoryProductsRow;
                EmployeeProductAnalytics analytics = null;
                dictionary.TryGetValue(new EmployeeProductKey((int)e.Column.Tag, categoryProductsRow.ProductID), out analytics);
                e.Value = analytics == null ? 0 : analytics.TotalQuantities;
            }
            if(e.Column.FieldName.StartsWith("SalesCount")) {
                dsOrder.CategoryProductsRow categoryProductsRow = (e.Row as DataRowView).Row as dsOrder.CategoryProductsRow;
                EmployeeProductAnalytics analytics = null;
                dictionary.TryGetValue(new EmployeeProductKey((int)e.Column.Tag, categoryProductsRow.ProductID), out analytics);
                e.Value = analytics == null ? 0 : analytics.SalesCount;
            }
        }
        void InitConnection() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.mdb");
            if(DBFileName != string.Empty) {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT [FirstName]+' '+[LastName] AS FullName, * FROM Employees WHERE (Employees.EmployeeID < 6)", con);
                OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT Products.ProductID, Products.ProductName, Categories.CategoryName, Categories.Picture, Categories.Description, Products.UnitPrice, Products.UnitsInStock, Products.CategoryID FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) WHERE (Products.CategoryID < 8)", con);
                OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT Orders.EmployeeID, Orders.OrderID, [Order Details].ProductID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, Orders.OrderDate FROM((Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) INNER JOIN Products ON[Order Details].ProductID = Products.ProductID) WHERE (Products.CategoryID < 8)", con);
                oleDBAdapter1.Fill(dsOrder.Employees);
                oleDBAdapter2.Fill(dsOrder.CategoryProducts);
                oleDBAdapter3.Fill(dsOrder.OrderDetailsEmployees);
            }
        }
        void InitData() {
            InitConnection();
            foreach(dsOrder.OrderDetailsEmployeesRow row in dsOrder.OrderDetailsEmployees.ToList().OrderBy(e => e.OrderDate)) {
                EmployeeProductKey key = new EmployeeProductKey(row.EmployeeID, row.ProductID);
                EmployeeProductAnalytics oldResult = null;
                dictionary.TryGetValue(key, out oldResult);
                decimal totalSale = new decimal(((decimal.ToInt32(row.UnitPrice) * row.Quantity) * (1f - row.Discount)));
                decimal totalQuantities = row.Quantity;
                if(oldResult == null)
                    oldResult = new EmployeeProductAnalytics(totalSale, key, totalQuantities, row.OrderDate, totalSale);
                else {
                    oldResult.SalesTrend.Add(totalSale);
                    oldResult.TotalQuantities += totalQuantities;
                    oldResult.TotalSale += totalSale;
                }
                dictionary[key] = oldResult;
            }
        }
        #endregion
    }

    public class EmployeeProductKey : Tuple<int, int> {
        public EmployeeProductKey(int EmployeeID, int ProductID)
            : base(EmployeeID, ProductID) {
        }

        public int EmployeeID { get { return Item1; } }

        public int ProductID { get { return Item1; } }
    }

    public class EmployeeProductAnalytics {
        public EmployeeProductAnalytics(decimal totalSale, EmployeeProductKey key, decimal totalQuantities, DateTime orderDate, decimal totalPrice) {
            TotalSale = totalSale;
            Key = key;
            TotalQuantities = totalQuantities;
            SalesTrend = new List<decimal>();
            SalesTrend.Add(totalPrice);
        }

        public EmployeeProductKey Key { get; set; }

        public decimal SalesCount {
            get { return SalesTrend.Count; }
        }

        public List<decimal> SalesTrend { get; set; }

        public decimal TotalQuantities { get; set; }

        public decimal TotalSale { get; set; }
    }
}
