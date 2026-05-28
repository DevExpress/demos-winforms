Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils.MVVM

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeesPeek
        Inherits BaseModuleControl

        Private presenterCore As EmployeePeekListPresenter

        Private entitiesBinding As IPropertyBinding

        Public Sub New()
            MyBase.New(GetType(EmployeeCollectionViewModel))
            InitializeComponent()
            entitiesBinding = mvvmContext.SetBinding(gridControl, Function(g) g.DataSource, "Entities")
            presenterCore = CreatePresenter()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            entitiesBinding.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As EmployeeCollectionViewModel
            Get
                Return GetViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As EmployeePeekListPresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As EmployeePeekListPresenter
            Return New EmployeePeekListPresenter(gridView, ViewModel)
        End Function
    End Class
End Namespace
