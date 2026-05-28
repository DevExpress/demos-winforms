Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class ProductsCustomFilter
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

        Public ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property

        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Product)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.Name).AddColumn(Function(e) e.Available).AddColumn(Function(e) e.Cost).AddColumn(Function(e) e.CurrentInventory).AddColumn(Function(e) e.RetailPrice).AddColumn(Function(e) e.SalePrice).AddDateTimeColumn(Function(e) e.ProductionStart).AddLookupColumn(Function(e) e.Category)
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
