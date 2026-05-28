Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeesCustomFilter
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

        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Employee)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.FirstName).AddColumn(Function(e) e.LastName).AddColumn(Function(e) e.FullName).AddColumn(Function(e) e.MobilePhone).AddColumn(Function(e) e.HomePhone).AddColumn(Function(e) e.Address.City).AddColumn(Function(e) e.Address.Line).AddColumn(Function(e) e.Address.ZipCode).AddColumn(Function(e) e.Email).AddColumn(Function(e) e.Skype).AddDateTimeColumn(Function(e) e.BirthDate).AddDateTimeColumn(Function(e) e.HireDate).AddLookupColumn(Function(e) e.Department).AddLookupColumn(Function(e) e.Status).AddLookupColumn(Function(e) e.Address.State).AddLookupColumn(Function(e) e.Prefix)
        End Sub

        Private Sub BindEditors()
            Dim errorProvider = New XtraEditors.DXErrorProvider.DXErrorProvider(components)
            errorProvider.ContainerControl = Me
            errorProvider.DataSource = bindingSource
        End Sub

        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of CustomFilterViewModel)()
            fluent.BindCommand(okBtn, Sub(x) x.OK())
            fluent.BindCommand(cancelBtn, Sub(x) x.Cancel())
        End Sub
    End Class
End Namespace
