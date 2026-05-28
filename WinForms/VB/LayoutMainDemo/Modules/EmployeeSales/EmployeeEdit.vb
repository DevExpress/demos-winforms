Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class EmployeeEdit
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal order As dsOrder, ByVal employeeID As Integer)
            Me.New()
            employeesBindingSource.DataSource = order
            employeesBindingSource.DataMember = "Employees"
            employeesBindingSource.Position = order.Employees.Rows.IndexOf(order.Employees.FindByEmployeeID(employeeID))
            lookUpEdit1.Properties.DataSource = order.Employees
            lookUpEdit1.Properties.DisplayMember = "FullName"
            lookUpEdit1.Properties.ValueMember = "EmployeeID"
            lookUpEdit1.Properties.NullText = ""
        End Sub
    End Class
End Namespace
