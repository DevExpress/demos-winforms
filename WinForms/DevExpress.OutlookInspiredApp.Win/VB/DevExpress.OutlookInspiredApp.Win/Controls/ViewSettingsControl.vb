Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.Modules

    Public Partial Class ViewSettingsControl
        Inherits BaseModuleControl

        Public Sub New(ByVal collectionViewModel As CollectionUIViewModel)
            MyBase.New(GetType(ViewSettingsViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            BindCommands()
        End Sub

        Public ReadOnly Property ViewModel As ViewSettingsViewModel
            Get
                Return GetViewModel(Of ViewSettingsViewModel)()
            End Get
        End Property

        Private Sub BindCommands()
            resetFiltersBtn.BindCommand(Sub() ViewModel.ResetCustomFilters(), ViewModel)
            resetViewBtn.BindCommand(Sub() ViewModel.ResetView(), ViewModel)
            okBtn.BindCommand(Sub() ViewModel.OK(), ViewModel)
            cancelBtn.BindCommand(Sub() ViewModel.Cancel(), ViewModel)
        End Sub
    End Class
End Namespace

Namespace DevExpress.DevAV.ViewModels

    Public Class ViewSettingsViewModel

        Private collectionUIViewModelCore As CollectionUIViewModel

        Public Shared Function Create(ByVal collectionUIViewModel As CollectionUIViewModel) As ViewSettingsViewModel
            Return ViewModelSource.Create(Function() New ViewSettingsViewModel(collectionUIViewModel))
        End Function

        Protected Sub New(ByVal collectionUIViewModel As CollectionUIViewModel)
            collectionUIViewModelCore = collectionUIViewModel
        End Sub

        <Command>
        Public Sub ResetCustomFilters()
            Dim vm = ViewModelHelper.GetParentViewModel(Of ISupportCustomFilters)(Me)
            If vm IsNot Nothing Then vm.ResetCustomFilters()
        End Sub

        Public ReadOnly Property CollectionUIViewModel As CollectionUIViewModel
            Get
                Return collectionUIViewModelCore
            End Get
        End Property

        <Command>
        Public Sub ResetView()
            CollectionUIViewModel.ResetView()
        End Sub

        Public Property Document As IDocument

        <Command>
        Public Sub OK()
            Document.Close()
        End Sub

        <Command>
        Public Sub Cancel()
            Document.Close()
        End Sub
    End Class
End Namespace
