Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Class UserService
        Implements IUserListService

        Private ReadOnly _users As List(Of String) = New List(Of String)()

        Public ReadOnly Property Users As List(Of String)
            Get
                Return _users
            End Get
        End Property

        Private Function GetUsers() As IList(Of String) Implements IUserListService.GetUsers
            Return Users
        End Function

        Public Sub Update(ByVal userList As List(Of String))
            _users.Clear()
            _users.AddRange(userList)
        End Sub
    End Class
End Namespace
