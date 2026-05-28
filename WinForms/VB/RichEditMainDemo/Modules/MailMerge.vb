Imports System
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.Office.Services
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit.Demos.Modules.MailMerge

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class MailMergeModule
        Inherits MailMergeModuleBase

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = ribbonControl1.Pages("Mail Merge")
            LoadDocument("MailMerge.rtf")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Protected Overrides ReadOnly Property TopLevelRecordSelector As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            Dim uriService As IUriStreamService = CType(RichEdit.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProvider(nwindDataSet.Employees, "Photo"))
            MyBase.OnLoad(e)
        End Sub

        Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection)
            employeesTableAdapter.Connection = connection
            employeesTableAdapter.Fill(nwindDataSet.Employees)
            Dim dataTable As DataTable = FetchEmployeeCustomerData(connection)
            RichEdit.Options.MailMerge.DataSource = dataTable
            gridControl1.DataSource = dataTable
        End Sub

        Private Function FetchEmployeeCustomerData(ByVal connection As OleDbConnection) As DataTable
            Const commandText As String = "SELECT Employees.*, Customers.* FROM " & "(Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) " & "INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;"
            Dim dataSet As DataSet = New DataSet()
            Using selectCommand As OleDbCommand = New OleDbCommand(commandText, connection)
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommand)
                adapter.Fill(dataSet)
            End Using

            Return dataSet.Tables(0)
        End Function
    End Class
End Namespace
