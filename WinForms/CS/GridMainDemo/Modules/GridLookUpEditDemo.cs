using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for GridLookUpEdit.
    /// </summary>
    public partial class GridLookUpEditDemo : TutorialControl {
        public GridLookUpEditDemo() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            InitNWindData();
            // TODO: Add any initialization after the InitForm call

            //<gridLookUpEdit1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            
            ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            gridLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products;
            
            ~Specify the field whose values are displayed in the edit box:
            gridLookUpEdit1.Properties.DisplayMember = "ProductName";
            
            ~Specify the key field whose values identify dropdown rows:
            gridLookUpEdit1.Properties.ValueMember = "ProductID";
            
            ~Specify a GridView that will render data in the dropdown window:
            gridLookUpEdit1.Properties.View = gridLookUpEdit1View;
            */
            //</gridLookUpEdit1>

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
            
            ~Settings of the Customer column's GridLookUpEdit in-place editor:
            
            ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            repositoryItemGridLookUpEdit1.DataSource = dsNWindCustomers1.Customers;
            
            ~Specify the field whose values are displayed in the edit box:
            repositoryItemGridLookUpEdit1.DisplayMember = "CompanyName";
            
            ~Specify the key field whose values identify dropdown rows:
            repositoryItemGridLookUpEdit1.ValueMember = "CustomerID";
            
            ~Specify a GridView that will render data in the dropdown window:
            repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;

            
            ~Settings of the Employee column's GridLookUpEdit in-place editor:
            
            ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            repositoryItemGridLookUpEdit2.DataSource = dsNWindCustomers1.Employees;
            
            ~Specify the field whose values are displayed in the edit box:
            repositoryItemGridLookUpEdit2.DisplayMember = "Name";
            
            ~Specify the key field whose values identify dropdown rows:
            repositoryItemGridLookUpEdit2.ValueMember = "EmployeeID";
            
            ~Specify an AdvBandedGridView that will render data in the dropdown window:
            repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            */
            //</gridControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "GridLookUpEditDemo", "LookUpProperties" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "GridLookUpEditDemo"; }
        }

        private void GridLookUpEdit_Load(object sender, System.EventArgs e) {
            LookUpProperties lp = new LookUpProperties(gridLookUpEdit1);
            lp.Dock = DockStyle.Right;
            lp.Parent = xtraScrollableControl1;

            LookUpProperties lpTiles = new LookUpProperties(gridLookUpEdit2);
            lpTiles.Dock = DockStyle.Right;
            lpTiles.Parent = tabPage3;
            //<dataNavigator1>
            /*
             ~Bind the GridLookUpEdit's EditValue to the ProductID field in the Order_Details table:
             */
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsNWindProducts1.Order_Details, "ProductID"));
            //</dataNavigator1>
            this.gridLookUpEdit2.EditValue = dsNWindCustomers1.Employees[0].EmployeeID;
            CreateTimer();
        }

        protected override void OnTick() {
            if(DemosInfo.CurrentModule == this) {
                if(tabPane1.SelectedPage == tabPage1)
                    gridLookUpEdit1.ShowPopup();
                if(tabPane1.SelectedPage == tabPage3)
                    gridLookUpEdit2.ShowPopup();
            }
        }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dsNWindProducts1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            dsNWindCustomers1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1);
            return dsNWindCustomers1;
        }

        private void repositoryItemGridLookUpEdit1View_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            GridView view = sender as GridView;
            if(view == null) return;
            DataRow row = view.GetDataRow(e.RowHandle);
            if(row == null) return;
            string _region = row["Region"] != DBNull.Value ? string.Format("{0}, ", row["Region"]) : "";
            e.PreviewText = String.Format("{0}{1}, {2}, {3}\r\n{4}, {5}", _region, row["Country"], row["City"], row["PostalCode"], row["Address"], row["Phone"]);
        }

        private void gridLookUpEdit1_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e) {
            dsNWindProducts1.Products.Rows.Add(new object[] { 0, false, System.Environment.TickCount, e.DisplayValue });
            e.Handled = true;
        }
        protected override void DoHide() {
            base.DoHide();
            if(gridLookUpEdit1.IsPopupOpen) gridLookUpEdit1.ClosePopup();
            if(gridLookUpEdit2.IsPopupOpen) gridLookUpEdit2.ClosePopup();
        }
    }
}
