using System;
using System.Data;
using System.Data.OleDb;
using DevExpress.Office.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Demos.Modules.MailMerge;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class MailMergeModule : MailMergeModuleBase {
        public MailMergeModule() {
            InitializeComponent();
            ribbonControl1.SelectedPage = ribbonControl1.Pages["Mail Merge"];
            LoadDocument("MailMerge.rtf");
        }
        public override RichEditControl RichEdit {
            get { return richEditControl; }
        }
        protected override GridView TopLevelRecordSelector {
            get {
                return gridView1;
            }
        }
        protected override void OnLoad(EventArgs e) {
            IUriStreamService uriService = (IUriStreamService)RichEdit.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new DBUriStreamProvider(nwindDataSet.Employees, "Photo"));
            base.OnLoad(e);
        }
        protected override void FillDataSource(OleDbConnection connection) {
            employeesTableAdapter.Connection = connection;
            employeesTableAdapter.Fill(nwindDataSet.Employees);
            DataTable dataTable = FetchEmployeeCustomerData(connection);
            RichEdit.Options.MailMerge.DataSource = dataTable;
            gridControl1.DataSource = dataTable;
        }
        DataTable FetchEmployeeCustomerData(OleDbConnection connection) {
            const string commandText = @"SELECT Employees.*, Customers.* FROM " +
                "(Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) " +
                "INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;";
            DataSet dataSet = new DataSet();
#pragma warning disable DX0024 // // we have constant query here
            using(OleDbCommand selectCommand = new OleDbCommand(commandText, connection)) {
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand);
                adapter.Fill(dataSet);
            }
#pragma warning restore DX0024 // // we have constant query here
            return dataSet.Tables[0];
        }
    }
}
