Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data
Imports TodoApp.Model

Namespace TodoApp.ViewModels
    Public Class ItemsViewModel
        Private _Title As String
        Public Sub New()
            Title = "What needs to be done?"
            ShowAllItems = True
            Messenger.Default.Register(Me, New System.Action(Of ReloadRequired)(AddressOf OnReloadRequired))
        End Sub
        Protected ReadOnly Property Repository As IRepository
            Get
                Return GetRequiredService(Of IRepository)()
            End Get
        End Property
        Sub OnReloadRequired(ByVal message As ReloadRequired)
            If message Is ReloadRequired.All OrElse message.IsNew Then
                ReloadItems(ShowAllItems)
            Else
                Dim item = Repository.ReloadItem(Items, message.Id)
                If item Is SelectedItem Then SelectedItem = item
            End If
        End Sub
        Sub ReloadItems(ByVal showAll As Boolean)
            Dim savedId As Integer = If(SelectedItem IsNot Nothing, SelectedItem.Id, AppModel.NewItemID)
            If showAll Then
                Items = Repository.LoadItems()
            Else
                Items = Repository.LoadItems(Function(x) Not x.IsCompleted)
            End If
            SelectedItem = If(Items.FirstOrDefault(Function(x) x.Id = savedId), SelectedItem)
        End Sub
        Public Property Title As String
            Get
                Return _Title
            End Get
            Private Set(ByVal value As String)
                _Title = value
            End Set
        End Property
        Public Overridable Property Items As IList(Of TodoItem)
        Public Overridable Property SelectedItem As TodoItem
        Public Overridable Property ShowAllItems As Boolean
        Protected Sub OnItemsChanged()
            SelectedItem = Items.FirstOrDefault()
        End Sub
        Protected Sub OnSelectedItemChanged()
            RaiseCanExecuteChanged(Sub(x) x.Edit())
        End Sub
        Protected Sub OnShowAllItemsChanged()
            ReloadItems(ShowAllItems)
        End Sub
        Public Sub Complete(ByVal item As TodoItem)
            item.IsCompleted = True
            If Repository.HasChanges(item.Id, item) Then
                Dim itemId As Integer = Repository.Save(item)
                Messenger.Default.Send(ReloadRequired.FromID(itemId))
            End If
        End Sub
        Protected ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property
        Public Sub [New]()
            NavigationService.Navigate("ItemView", AppModel.NewItemID, Me)
        End Sub
        Public Function CanEdit() As Boolean
            Return SelectedItem IsNot Nothing
        End Function
        Public Sub Edit()
            NavigationService.Navigate("ItemView", SelectedItem.Id, Me)
        End Sub
    End Class
End Namespace
