Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils.MVVM

Namespace DevExpress.DevAV.Modules

    Public Partial Class ProductsPeek
        Inherits BaseModuleControl

        Private presenterCore As ProductPeekListPresenter

        Private entitiesBinding As IPropertyBinding

        Public Sub New()
            MyBase.New(GetType(ProductCollectionViewModel))
            InitializeComponent()
            entitiesBinding = mvvmContext.SetBinding(gridControl, Function(g) g.DataSource, "Entities")
            presenterCore = CreatePresenter()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            entitiesBinding.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As ProductCollectionViewModel
            Get
                Return GetViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As ProductPeekListPresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As ProductPeekListPresenter
            Return New ProductPeekListPresenter(gridView, ViewModel)
        End Function
    End Class
End Namespace
