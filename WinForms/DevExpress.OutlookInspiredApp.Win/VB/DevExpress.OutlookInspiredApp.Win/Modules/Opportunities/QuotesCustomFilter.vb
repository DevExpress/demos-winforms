Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class QuotesCustomFilter
        Inherits BaseModuleControl

        Public Sub New(ByVal customFilterViewModel As CustomFilterViewModel)
            MyBase.New(GetType(CustomFilterViewModel), customFilterViewModel)
            InitializeComponent()
            AddHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            bindingSource.DataSource = customFilterViewModel
            BuildFilterColumns()
            BindEditors()
            BindCommands()
            FilterControlWithoutLike.Apply(filterControl)
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

        Public ReadOnly Property CollectionViewModel As QuoteCollectionViewModel
            Get
                Return GetParentViewModel(Of QuoteCollectionViewModel)()
            End Get
        End Property

        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Quote)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.Customer.Name, caption:="Customer").AddColumn(Function(e) e.CustomerStore.Crest.CityName, caption:="City").AddDateTimeColumn(Function(e) e.Date).AddColumn(Function(e) e.Employee.FullName, caption:="Employee").AddColumn(Function(e) e.Number).AddColumn(Function(e) e.Opportunity).AddColumn(Function(e) e.ShippingAmount).AddColumn(Function(e) e.SubTotal).AddColumn(Function(e) e.Total)
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
