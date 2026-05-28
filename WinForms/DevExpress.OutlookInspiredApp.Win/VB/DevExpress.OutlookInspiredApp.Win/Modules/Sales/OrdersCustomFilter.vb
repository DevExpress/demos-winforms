Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrdersCustomFilter
        Inherits BaseModuleControl

        Public Sub New(ByVal customFilterViewModel As CustomFilterViewModel)
            MyBase.New(GetType(CustomFilterViewModel), customFilterViewModel)
            InitializeComponent()
            AddHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            bindingSource.DataSource = customFilterViewModel
            BuildFilterColumns()
            BindEditors()
            BindCommands()
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
        End Sub

        Protected Overrides Sub OnLoad(ByVal ea As System.EventArgs)
            MyBase.OnLoad(ea)
            filterControl.FilterCriteria = ViewModel.FilterCriteria
        End Sub

        Private Sub ViewModel_QueryFilterCriteria(ByVal sender As Object, ByVal e As QueryFilterCriteriaEventArgs)
            e.FilterCriteria = filterControl.FilterCriteria
        End Sub

        Public ReadOnly Property ViewModel As CustomFilterViewModel
            Get
                Return GetViewModel(Of CustomFilterViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As OrderCollectionViewModel
            Get
                Return GetParentViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property

        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Order)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.Customer.Name, caption:="Customer").AddColumn(Function(e) e.Employee.FullName, caption:="Employee").AddColumn(Function(e) e.InvoiceNumber).AddDateTimeColumn(Function(e) e.OrderDate).AddColumn(Function(e) e.PONumber).AddColumn(Function(e) e.SaleAmount).AddDateTimeColumn(Function(e) e.ShipDate).AddLookupColumn(Function(e) e.ShipMethod).AddColumn(Function(e) e.ShippingAmount).AddColumn(Function(e) e.Store.Crest.CityName, caption:="Store").AddColumn(Function(e) e.TotalAmount)
        End Sub

        Private Sub BindEditors()
            Dim errorProvider = New XtraEditors.DXErrorProvider.DXErrorProvider()
            errorProvider.ContainerControl = Me
            errorProvider.DataSource = bindingSource
        End Sub

        Private Sub BindCommands()
            okBtn.BindCommand(Sub() ViewModel.OK(), ViewModel)
            cancelBtn.BindCommand(Sub() ViewModel.Cancel(), ViewModel)
        End Sub
    End Class
End Namespace
