using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for GridLookUpEdit.
    /// </summary>
    public partial class SearchLookUpEditDemo : TutorialControl {
        public SearchLookUpEditDemo() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            InitNWindData();
            // TODO: Add any initialization after the InitForm call
            searchLookUpEdit1.Properties.ShowClearButton = false;
            repositoryItemSearchLookUpEdit2.GetImageByValue += repositoryItemSearchLookUpEdit2_GetImageByValue;

            //<searchLookUpEdit1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            
            ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            searchLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products;
            
            ~Specify the field whose values are displayed in the edit box:
            searchLookUpEdit1.Properties.DisplayMember = "ProductName";
            
            ~Specify the key field whose values identify dropdown rows:
            searchLookUpEdit1.Properties.ValueMember = "ProductID";
            
            ~Specify a GridView that will render data in the dropdown window:
            searchLookUpEdit1.Properties.View = gridLookUpEdit1View;
            */
            //</searchLookUpEdit1>

            //<dataNavigator1>
            /*
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
            
            ~The DataNavigator will navigate through the Order_Details data source:
            dataNavigator1.DataSource = dsNWindProducts1.Order_Details;
            */
            //</dataNavigator1>

            //<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            
            ~Settings of the Customer column's SearchLookUpEdit in-place editor:
            
            ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            repositoryItemSearchLookUpEdit1.DataSource = dsNWindCustomers1.Customers;
            
            ~Specify the field whose values are displayed in the edit box:
            repositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName";
            
            ~Specify the key field whose values identify dropdown rows:
            repositoryItemSearchLookUpEdit1.ValueMember = "CustomerID";
            
            ~Specify a GridView that will render data in the dropdown window:
            repositoryItemSearchLookUpEdit1.View = repositoryItemSearchLookUpEdit1View;

            
            ~Settings of the Employee column's SearchLookUpEdit in-place editor:
            
            ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            repositoryItemSearchLookUpEdit2.DataSource = dsNWindCustomers1.Employees;
            
            ~Specify the field whose values are displayed in the edit box:
            repositoryItemSearchLookUpEdit2.DisplayMember = "Name";
            
            ~Specify the key field whose values identify dropdown rows:
            repositoryItemSearchLookUpEdit2.ValueMember = "EmployeeID";
            
            ~Specify an AdvBandedGridView that will render data in the dropdown window:
            repositoryItemSearchLookUpEdit2.View = repositoryItemSearchLookUpEdit2View;
            */
            //</gridControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "SearchLookUpEditDemo", "SearchLookUpProperties" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "SearchLookUpEditDemo"; }
        }
        void repositoryItemSearchLookUpEdit2_GetImageByValue(object sender, ImageByValueEventArgs e) {
            RepositoryItemSearchLookUpEditWithGlyph repository = sender as RepositoryItemSearchLookUpEditWithGlyph;
            DataTable dt = repository.DataSource as DataTable;
            DataRow row = null;
            try {
                row = dt.Rows.Find(e.Value);
            }
            catch { }
            if (row != null) {
                e.Image = row["Photo"];
            }
        }
        void GridLookUpEdit_Load(object sender, System.EventArgs e) {
            SearchLookUpProperties lp = new SearchLookUpProperties(searchLookUpEdit1);
            lp.Dock = DockStyle.Right;
            lp.Parent = xtraScrollableControl1;
            //<dataNavigator1>
            /*
             ~Bind the SearchLookUpEdit's EditValue to the ProductID field in the Order_Details table:
             */
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsNWindProducts1.Order_Details, "ProductID"));
            //</dataNavigator1>
        }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            filterConditionEdit.Properties.AddEnum<Data.Filtering.FilterCondition>();
            filterConditionEdit.EditValue = Data.Filtering.FilterCondition.Default;
            parserKindEdit.Properties.AddEnum<Data.Filtering.FindPanelParserKind>();
            parserKindEdit.Properties.Items.Remove(Data.Filtering.FindPanelParserKind.Custom);
            parserKindEdit.EditValue = Data.Filtering.FindPanelParserKind.Default;
            //<autoSearchLookUpEdit>
            autoSearchLookUpEdit.Properties.DataSource = WorldCities.All;
            autoSearchLookUpEdit.Properties.DisplayMember = "Text";
            autoSearchLookUpEdit.Properties.SearchMode = XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            //</autoSearchLookUpEdit>
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dsNWindProducts1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            dsNWindCustomers1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1);
            return dsNWindCustomers1;
        }

        void repositoryItemGridLookUpEdit1View_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            GridView view = sender as GridView;
            if (view == null) return;
            DataRow row = view.GetDataRow(e.RowHandle);
            if (row == null) return;
            string _region = row["Region"] != DBNull.Value ? string.Format("{0}, ", row["Region"]) : "";
            e.PreviewText = String.Format("{0}{1}, {2}, {3}\r\n{4}, {5}", _region, row["Country"], row["City"], row["PostalCode"], row["Address"], row["Phone"]);
        }
        void gridLookUpEdit1_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e) {
            dsNWindProducts1.Products.Rows.Add(new object[] { 0, false, System.Environment.TickCount, e.DisplayValue });
            e.Handled = true;
        }
        void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e) {
            SearchLookUpEditWithGlyph edit = sender as SearchLookUpEditWithGlyph;
            if(edit == null) return;
            if(edit.EditValue == null)
                edit.Image = null;
            else {
                DataTable dt = edit.Properties.DataSource as DataTable;
                if(dt == null)
                    return;
                DataRow row = dt.Rows.Find(edit.EditValue);
                edit.Image = DemoHelper.CategorySvgImages.GetImage(Convert.ToInt32(row["CategoryID"]) - 1, DemoHelper.CategorySvgImages.ScaledImageSize);
            }
        }
        void searchLookUpEdit1_AddNewValue(object sender, AddNewValueEventArgs e) {
            SearchLookUpEditWithGlyph edit = sender as SearchLookUpEditWithGlyph;
            DataTable dt = edit.Properties.DataSource as DataTable;

            using (frmProduct frm = new frmProduct()) {
                if (frm.ShowDialog(this.FindForm()) == DialogResult.OK) {
                    DataRow dr = dt.Rows.Add(frm.CategoryID, frm.Discontinued, null, frm.NewProductName, frm.QuantityPerUnit, 0, 0, frm.UnitPrice, 1, 1);
                    dr.AcceptChanges();
                    e.NewValue = dr["ProductID"];
                }
                else e.Cancel = true;
            }
        }
        //<autoSearchLookUpEdit>
        void LookUpEdit_AutoSearch(object sender, LookUpEditAutoSearchEventArgs e) {
            var parseKind = (Data.Filtering.FindPanelParserKind)parserKindEdit.EditValue;
            var filterCondition = (Data.Filtering.FilterCondition)filterConditionEdit.EditValue;
            e.SetParameters(parseKind, filterCondition);
        }
        //</autoSearchLookUpEdit>
    }
}
