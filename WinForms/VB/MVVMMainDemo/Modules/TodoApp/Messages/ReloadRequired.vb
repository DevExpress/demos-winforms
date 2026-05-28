Imports TodoApp.Model

Namespace TodoApp
    Public Class ReloadRequired
        Public ReadOnly Shared All As ReloadRequired = New ReloadRequired(AppModel.NewItemID, False)
        '
        Private ReadOnly f_Id As Integer
        Private ReadOnly f_IsNew As Boolean
        Sub New(ByVal id As Integer, ByVal isNew As Boolean)
            f_Id = id
            f_IsNew = isNew
        End Sub
        Public ReadOnly Property Id As Integer
            Get
                Return f_Id
            End Get
        End Property
        Public ReadOnly Property IsNew As Boolean
            Get
                Return f_IsNew
            End Get
        End Property
        Public Shared Function FromID(ByVal id As Integer) As ReloadRequired
            Return New ReloadRequired(id, False)
        End Function
        Public Shared Function FromNew(ByVal id As Integer) As ReloadRequired
            Return New ReloadRequired(id, True)
        End Function
    End Class
End Namespace
