Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos

    '<gControl1>
    '<gridControl1>
    Public Class Customer
        Inherits XPObject
        '</gridControl1>
        Public Sub New()
        End Sub
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private _name As String
        Private _age As Integer

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                ' The old value of the Name property.
                Dim oldValue As String = Name
                If oldValue = Value Then
                    Return
                End If
                _name = value
                ' Keep track of every change made to the Name property.
                OnChanged(NameOf(Name), oldValue, value)
            End Set
        End Property

        Public Property Age() As Integer
            Get
                Return _age
            End Get
            Set(ByVal value As Integer)
                Dim oldValue As Integer = Age
                If oldValue = Value Then
                    Return
                End If
                _age = value
                OnChanged(NameOf(Age), oldValue, value)
            End Set
        End Property
        '</gControl1>

        '<gridControl1>
        <Association("Customer-Orders", GetType(OrderObject)), Aggregated()> _
  Public ReadOnly Property Orders() As XPCollection
            Get
                Return GetCollection(NameOf(Orders))
            End Get
        End Property
        '<gControl1>
    End Class
    '</gControl1>

    Public Class OrderObject
        Inherits XPObject

        <Association("Customer-Orders")> _
        Public Customer As Customer
        '</gridControl1>

        Private _productName As String
        Private _orderDate As DateTime

        Public Property ProductName() As String
            Get
                Return _productName
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = ProductName
                If oldValue = value Then
                    Return
                End If
                _productName = value
                OnChanged(NameOf(ProductName), oldValue, value)
            End Set
        End Property

        Public Property OrderDate() As DateTime
            Get
                Return _orderDate
            End Get
            Set(ByVal value As DateTime)
                Dim oldValue As DateTime = OrderDate
                If oldValue = value Then
                    Return
                End If
                _orderDate = value
                OnChanged(NameOf(OrderDate), oldValue, value)
            End Set
        End Property
        '<gridControl1>
    End Class
    '</gridControl1>
End Namespace
