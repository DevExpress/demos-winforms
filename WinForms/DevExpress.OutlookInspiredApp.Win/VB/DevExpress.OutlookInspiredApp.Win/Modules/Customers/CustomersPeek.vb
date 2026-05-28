Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils.MVVM

Namespace DevExpress.DevAV.Modules

    Public Partial Class CustomersPeek
        Inherits BaseModuleControl

        Private presenterCore As CustomerPeekListPresenter

        Private entitiesBinding As IPropertyBinding

        Public Sub New()
            MyBase.New(GetType(CustomerCollectionViewModel))
            InitializeComponent()
            entitiesBinding = mvvmContext.SetBinding(gridControl, Function(g) g.DataSource, "Entities")
            presenterCore = CreatePresenter()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            entitiesBinding.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As CustomerCollectionViewModel
            Get
                Return GetViewModel(Of CustomerCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As CustomerPeekListPresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As CustomerPeekListPresenter
            Return New CustomerPeekListPresenter(gridView, ViewModel)
        End Function
    End Class
End Namespace
