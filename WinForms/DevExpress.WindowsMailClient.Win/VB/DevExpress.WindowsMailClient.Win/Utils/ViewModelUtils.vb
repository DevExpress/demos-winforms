Imports DevExpress.Mvvm
Imports DevExpress.WindowsMailClient.Win.Modules

Namespace DevExpress.WindowsMailClient.Win.Utils

    Public Module ViewModelUtils

        Public Function GetParentViewModel(Of TViewModel)(ByVal viewModel As Object) As TViewModel
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then Return CType(parentViewModelSupport.ParentViewModel, TViewModel)
            Return Nothing
        End Function

        Public Sub CheckModuleViewModel(ByVal [module] As Object, ByVal parentViewModel As Object, ByVal Optional parameter As Object = Nothing)
            Dim vm As ISupportViewModel = TryCast([module], ISupportViewModel)
            If vm IsNot Nothing Then
                Dim oldParentViewModel As Object = Nothing
                Dim parentViewModelSupport As ISupportParentViewModel = TryCast(vm.ViewModel, ISupportParentViewModel)
                If parentViewModelSupport IsNot Nothing Then oldParentViewModel = parentViewModelSupport.ParentViewModel
                CheckViewModel(vm.ViewModel, parentViewModel, parameter)
                If oldParentViewModel IsNot parentViewModel Then vm.ParentViewModelAttached()
            End If
        End Sub

        Public Sub CheckViewModel(ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal Optional parameter As Object = Nothing)
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then parentViewModelSupport.ParentViewModel = parentViewModel
            Dim parameterSupport As ISupportParameter = TryCast(viewModel, ISupportParameter)
            If parameterSupport IsNot Nothing AndAlso parameter IsNot Nothing Then parameterSupport.Parameter = parameter
        End Sub
    End Module
End Namespace
