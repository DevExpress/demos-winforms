Imports System
Imports System.Collections.Generic
Imports TodoApp.Model

Namespace TodoApp.Data
    Friend NotInheritable Class InMemoryRepository
        Inherits DevExpress.Tutorials.TodoApp.Data.InMemoryRepository(Of TodoItem)
        Implements IRepository

        Friend NotInheritable Class InMemoryTodoItem
            Inherits TodoItem
            Public Sub New(ByVal id As Integer)
                MyBase.New(id)
            End Sub
        End Class
        Public Sub New()
            MyBase.New(AppModel.NewItemID, New KeyValuePair(Of Integer, TodoItem)() {
                New KeyValuePair(Of Integer, TodoItem)(1, New InMemoryTodoItem(1) With {
                .Title = "Create the MainView",
                .Description = "Create a Form with application icon and NavigationFrame control.",
                .IsCompleted = True
            }), New KeyValuePair(Of Integer, TodoItem)(2, New InMemoryTodoItem(2) With {
                .Title = "Create the AppViewModel",
                .Description = "Create a class with the Title property.",
                .IsCompleted = True
            }), New KeyValuePair(Of Integer, TodoItem)(3, New InMemoryTodoItem(3) With {
                .Title = "Bind the AppViewModel to the MainView.",
                .Description = "Bind the Title property to the Text. Register the NavigationFrame as a service.",
                .IsCompleted = True
            }), New KeyValuePair(Of Integer, TodoItem)(4, New InMemoryTodoItem(4) With {
                .Title = "Create the ItemsView",
                .Description = "Create an UserControl with ListBoxControl and SearchBox."
            }), New KeyValuePair(Of Integer, TodoItem)(5, New InMemoryTodoItem(5) With {
                .Title = "Create the ItemsViewModel",
                .Description = "Create a class with the Items property."
            }), New KeyValuePair(Of Integer, TodoItem)(6, New InMemoryTodoItem(6) With {
                .Title = "Bind the ItemsViewModel to the ItemsView.",
                .Description = "Bind the Title property to the label. Bind the Items property to the bindingSource."
            })})
        End Sub
        Protected Overrides Function Create(ByVal id As Integer) As TodoItem
            Return New InMemoryTodoItem(id)
        End Function
        Protected Overrides Function GetId(ByVal item As TodoItem) As Integer
            Return item.Id
        End Function

        Protected Overrides Function IsEmpty(ByVal item As TodoItem) As Boolean
            Return String.IsNullOrEmpty(item.Title) AndAlso String.IsNullOrEmpty(item.Description)
        End Function
        Protected Overrides Function Copy(ByVal source As TodoItem, ByVal Optional id As Integer? = Nothing) As TodoItem
            Dim actualId As Integer = id.GetValueOrDefault(source.Id)
            Return New InMemoryTodoItem(actualId) With {
                .Title = source.Title,
                .Description = source.Description,
                .IsCompleted = source.IsCompleted
            }
        End Function
        Protected Overrides Sub Assign(ByVal source As TodoApp.Model.TodoItem, ByVal target As TodoItem)
            target.Title = source.Title
            target.Description = source.Description
            target.IsCompleted = source.IsCompleted
        End Sub
        Protected Overrides Function Equals(ByVal source As TodoItem, ByVal target As TodoItem) As Boolean
            Return (Equals(source.Title, target.Title)) AndAlso (Equals(source.Description, target.Description)) AndAlso (source.IsCompleted = target.IsCompleted)
        End Function
        Function IRepository_Count(Optional filter As Func(Of TodoItem, Boolean) = Nothing) As Integer Implements IRepository.Count
            Return Count(filter)
        End Function
        Function IRepository_LoadItems(Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem) Implements IRepository.LoadItems
            Return LoadItems(filter)
        End Function
        Function IRepository_LoadItem(id As Integer) As TodoItem Implements IRepository.LoadItem
            Return LoadItem(id)
        End Function
        Function IRepository_ReloadItem(items As IList(Of TodoItem), id As Integer) As TodoItem Implements IRepository.ReloadItem
            Return ReloadItem(items, id)
        End Function
        Function IRepository_HasChanges(id As Integer, item As TodoItem) As Boolean Implements IRepository.HasChanges
            Return HasChanges(id, item)
        End Function
        Function IRepository_Save(item As TodoItem) As Integer Implements IRepository.Save
            Return Save(item)
        End Function
        Function IRepository_Delete(id As Integer) As Boolean Implements IRepository.Delete
            Return Delete(id)
        End Function
    End Class
End Namespace
