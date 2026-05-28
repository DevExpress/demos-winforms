Imports System.Threading.Tasks
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data

Namespace TodoApp.ViewModels
    Public Class AppViewModel
        Private _Title As String
        Shared Sub New()
            ' registering global service
            ServiceContainer.Default.RegisterService(New InMemoryRepository())
        End Sub
        Public Sub New()
            Title = "Getting started witn MVVM - Todo App"
        End Sub
        Public Property Title As String
            Get
                Return _Title
            End Get
            Private Set(ByVal value As String)
                _Title = value
            End Set
        End Property
        Protected ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property
        Public Async Function OnShown() As Task
            ' Show Logo screen
            NavigationService.Navigate("AppLogo", Nothing, Me, False)
            Await Task.Delay(2000)
            ' Show Items screen
            NavigationService.Navigate("ItemsView", Nothing, Me, True)
        End Function
    End Class
End Namespace
