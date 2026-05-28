using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos {
    public partial class EmployeeEdit : XtraUserControl {
        public EmployeeEdit() {
            InitializeComponent();
        }
        public EmployeeEdit(dsOrder order, int employeeID) : this() {
            employeesBindingSource.DataSource = order;
            employeesBindingSource.DataMember = "Employees";
            employeesBindingSource.Position = order.Employees.Rows.IndexOf(order.Employees.FindByEmployeeID(employeeID));

            lookUpEdit1.Properties.DataSource = order.Employees;
            lookUpEdit1.Properties.DisplayMember = "FullName";
            lookUpEdit1.Properties.ValueMember = "EmployeeID";
            lookUpEdit1.Properties.NullText = "";
        }
    }
}
