Namespace DevExpress.XtraTreeList.Demos

    Public Class Record

        Private fCategory As String

        Private fProduct1 As Object

        Private fProduct2 As Object

        Private fProduct3 As Object

        Private fId As Integer

        Private fParentID As Integer

        Public Sub New(ByVal category As String, ByVal product1 As Object, ByVal product2 As Object, ByVal product3 As Object, ByVal id As Integer)
            Me.New(category, product1, product2, product3, id, -1)
        End Sub

        Public Sub New(ByVal category As String, ByVal product1 As Object, ByVal product2 As Object, ByVal product3 As Object, ByVal id As Integer, ByVal parentID As Integer)
            fCategory = category
            fProduct1 = product1
            fProduct2 = product2
            fProduct3 = product3
            fId = id
            fParentID = parentID
        End Sub

        Public ReadOnly Property ID As Integer
            Get
                Return fId
            End Get
        End Property

        Public ReadOnly Property ParentID As Integer
            Get
                Return fParentID
            End Get
        End Property

        Public ReadOnly Property Category As String
            Get
                Return fCategory
            End Get
        End Property

        Public Property Product1 As Object
            Get
                Return fProduct1
            End Get

            Set(ByVal value As Object)
                fProduct1 = value
            End Set
        End Property

        Public Property Product2 As Object
            Get
                Return fProduct2
            End Get

            Set(ByVal value As Object)
                fProduct2 = value
            End Set
        End Property

        Public Property Product3 As Object
            Get
                Return fProduct3
            End Get

            Set(ByVal value As Object)
                fProduct3 = value
            End Set
        End Property
    End Class
End Namespace
