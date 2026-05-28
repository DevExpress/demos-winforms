Namespace DevExpress.XtraEditors.Demos

    Public Class RecordOrder

        Private fcategory As String

        Private fproduct1 As Object

        Private fproduct2 As Object

        Private fproduct3 As Object

        Public Sub New(ByVal fcategory As String, ByVal fproduct1 As Object, ByVal fproduct2 As Object, ByVal fproduct3 As Object)
            Me.fcategory = fcategory
            Me.fproduct1 = fproduct1
            Me.fproduct2 = fproduct2
            Me.fproduct3 = fproduct3
        End Sub

        Public ReadOnly Property Category As String
            Get
                Return fcategory
            End Get
        End Property

        Public Property Product1 As Object
            Get
                Return fproduct1
            End Get

            Set(ByVal value As Object)
                fproduct1 = value
            End Set
        End Property

        Public Property Product2 As Object
            Get
                Return fproduct2
            End Get

            Set(ByVal value As Object)
                fproduct2 = value
            End Set
        End Property

        Public Property Product3 As Object
            Get
                Return fproduct3
            End Get

            Set(ByVal value As Object)
                fproduct3 = value
            End Set
        End Property
    End Class
End Namespace
