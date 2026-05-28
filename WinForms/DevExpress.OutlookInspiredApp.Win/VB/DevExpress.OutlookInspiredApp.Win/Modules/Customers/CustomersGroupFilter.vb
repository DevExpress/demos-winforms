Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class CustomersGroupFilter
        Inherits BaseModuleControl

        Private presenterCore As CustomersGroupFilterPresenter

        Public Sub New(ByVal groupFilterViewModel As GroupFilterViewModel)
            MyBase.New(GetType(GroupFilterViewModel), groupFilterViewModel)
            InitializeComponent()
            GroupFiltersListViewAppearances.Apply(winExplorerView)
            presenterCore = CreatePresenter()
            BindEditors()
            BindCommands()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Presenter.Load()
        End Sub

        Public ReadOnly Property Presenter As CustomersGroupFilterPresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As CustomersGroupFilterPresenter
            Return New CustomersGroupFilterPresenter(winExplorerView, ViewModel)
        End Function

        Public ReadOnly Property ViewModel As GroupFilterViewModel
            Get
                Return GetViewModel(Of GroupFilterViewModel)()
            End Get
        End Property

        Private Sub BindEditors()
            bindingSource.DataSource = ViewModel
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
