Imports System.Linq
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class FilterPanePresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))
            MyBase.New(viewModel)
            navigationBarCore = navigationBar
            If CollectionViewModel IsNot Nothing Then SubscribeCollectionViewModelEvents()
            If OfficeNavigationBar IsNot Nothing Then
                BindItems()
            End If
        End Sub

        Protected Overrides Sub OnDisposing()
            If CollectionViewModel IsNot Nothing Then UnsubscribeCollectionViewModelEvents()
            navigationBarCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Private navigationBarCore As OfficeNavigationBar

        Protected ReadOnly Property OfficeNavigationBar As OfficeNavigationBar
            Get
                Return navigationBarCore
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork)
            Get
                Return ViewModel.CollectionViewModel
            End Get
        End Property

        Protected Overridable Sub SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub

        Protected Overridable Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub

        Private Sub CollectionViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            For Each navItem As NavigationBarItem In OfficeNavigationBar.Items
                navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, CType(navItem.Tag, FilterItemBase))
            Next
        End Sub

        Private Sub BindItems()
            For Each item As FilterItemBase In ViewModel.StaticFilters
                RegisterFilterItem(OfficeNavigationBar, item)
            Next
        End Sub

        Private Sub UpdateSelectedItemByFilter(ByVal item As FilterItemBase)
            Dim result = OfficeNavigationBar.Items.FirstOrDefault(Function(navItem) Equals(navItem.Tag, item))
            If result IsNot Nothing Then OfficeNavigationBar.SelectedItem = result
        End Sub

        Private Sub RegisterFilterItem(ByVal navigationBar As OfficeNavigationBar, ByVal item As FilterItemBase)
            Dim navItem As NavigationBarItem = New NavigationBarItem()
            navItem.Tag = item
            navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, item)
            navItem.Name = "filterItem" & item.Name.Replace(" ", String.Empty)
            navigationBar.Items.Add(navItem)
            navItem.BindCommand(Sub(f) ViewModel.Select(f), ViewModel, Function() TryCast(item, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem))
        End Sub
    End Class
End Namespace
