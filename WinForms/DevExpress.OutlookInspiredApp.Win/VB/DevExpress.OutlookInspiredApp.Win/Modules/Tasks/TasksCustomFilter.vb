Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class TasksCustomFilter
        Inherits BaseModuleControl

        Public Sub New(ByVal customFilterViewModel As CustomFilterViewModel)
            MyBase.New(GetType(CustomFilterViewModel), customFilterViewModel)
            InitializeComponent()
            AddHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            bindingSource.DataSource = customFilterViewModel
            BuildFilterColumns()
            BindEditors()
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
            Dim builder = New FilterColumnCollectionBuilder(Of EmployeeTask)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.Completion).AddColumn(Function(e) e.Priority).AddColumn(Function(e) e.Private).AddColumn(Function(e) e.AssignedEmployee.FullName)
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
