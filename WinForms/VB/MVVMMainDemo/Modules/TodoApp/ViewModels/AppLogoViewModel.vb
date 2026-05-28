Imports System
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data

Namespace TodoApp.ViewModels
    Public Class AppLogoViewModel
        Protected ReadOnly Property Repository As IRepository
            Get
                Return GetRequiredService(Of IRepository)()
            End Get
        End Property
        Public ReadOnly Property Greeting As String
            Get
                Dim uncompletedCount As Integer = Repository.Count(Function(x) Not x.IsCompleted)
                Return Size("Hello " & Environment.UserName & "!", 4) & DoubleLineBreak & Size("You have " & uncompletedCount.ToString() & " incompleted tasks for now.", 2) & DoubleLineBreak & Size("Have a good day!", 4)
            End Get
        End Property
        Const DoubleLineBreak As String = "<br><br>"
        Private Function Size(ByVal text As String, ByVal delta As Integer) As String
            Return "<size=+" & delta.ToString() & ">" & text & "</size>"
        End Function
    End Class
End Namespace
