Imports DevExpress.Mvvm
Imports IServiceContainer = DevExpress.Mvvm.IServiceContainer

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class BasePresenter(Of TViewModel As Class)

        Public Sub New(ByVal viewModel As TViewModel)
            viewModelCore = viewModel
        End Sub

        Private isDisposing As Boolean

        Public Sub Dispose()
            If Not isDisposing Then
                isDisposing = True
                OnDisposing()
                viewModelCore = Nothing
            End If
        End Sub

        Private viewModelCore As TViewModel

        Public ReadOnly Property ViewModel As TViewModel
            Get
                Return viewModelCore
            End Get
        End Property

        Protected Function GetParentViewModel(Of TParentViewModel)() As TParentViewModel
            Return CType(CType(viewModelCore, ISupportParentViewModel).ParentViewModel, TParentViewModel)
        End Function

        Protected Function GetService(Of TService As Class)() As TService
            Dim serviceContainer = GetServiceContainer()
            Return If(serviceContainer IsNot Nothing, serviceContainer.GetService(Of TService)(), Nothing)
        End Function

        Private Function GetServiceContainer() As IServiceContainer
            If Not(TypeOf viewModelCore Is ISupportServices) Then Return Nothing
            Return CType(viewModelCore, ISupportServices).ServiceContainer
        End Function

        Protected Overridable Sub OnDisposing()
        End Sub
    End Class
End Namespace
