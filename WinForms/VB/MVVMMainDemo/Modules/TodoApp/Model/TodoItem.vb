Imports System.ComponentModel.DataAnnotations

Namespace TodoApp.Model
    Public Class TodoItem
        Private _Id As Integer
        Protected Sub New(ByVal id As Integer)
            Me.Id = id
        End Sub
        <Display(AutoGenerateField:=False)>
        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Private Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property
        Public Property Title As String
        Public Property Description As String
        Public Property IsCompleted As Boolean
    End Class
End Namespace
