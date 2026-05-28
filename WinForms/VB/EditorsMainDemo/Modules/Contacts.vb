Imports System
Imports System.Collections
Imports System.Drawing

Namespace DevExpress.XtraEditors.Demos

    Public Class ContactList
        Inherits CollectionBase

        Public Shared Function GetContacts() As ContactList
            Dim cl As ContactList = New ContactList()
            cl.Add(Contact.ReadContact1())
            cl.Add(Contact.ReadContact2())
            cl.Add(Contact.ReadContact3())
            cl.Add(Contact.ReadContact4())
            cl.Add(Contact.ReadContact5())
            Return cl
        End Function

        Default Public Property Item(ByVal index As Integer) As Contact
            Get
                Return CType(List(index), Contact)
            End Get

            Set(ByVal value As Contact)
                List(index) = value
            End Set
        End Property

        Public Function Add(ByVal value As Contact) As Integer
            Return List.Add(value)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal value As Contact)
            List.Insert(index, value)
        End Sub

        Public Function IndexOf(ByVal value As Contact) As Integer
            Return List.IndexOf(value)
        End Function

        Public Function Contains(ByVal value As Contact) As Boolean
            Return List.Contains(value)
        End Function

        Public Sub Remove(ByVal value As Contact)
            List.Remove(value)
        End Sub

        Public Sub CopyTo(ByVal array As Contact(), ByVal index As Integer)
            List.CopyTo(array, index)
        End Sub
    End Class

    Public Class Contact

        Private fID As String

        Private fName As String

        Private fPurchaseDate As Date

        Private fPaymentAmount As Double

        Friend Sub New(ByVal ID As String)
            MyBase.New()
            fID = ID
        End Sub

        Public ReadOnly Property ID As String
            Get
                Return fID
            End Get
        End Property

        Public Property Name As String
            Get
                Return fName
            End Get

            Set(ByVal value As String)
                fName = value
            End Set
        End Property

        Public Property PurchaseDate As Date
            Get
                Return fPurchaseDate
            End Get

            Set(ByVal value As Date)
                fPurchaseDate = value
            End Set
        End Property

        Public Property PaymentAmount As Double
            Get
                Return fPaymentAmount
            End Get

            Set(ByVal value As Double)
                fPaymentAmount = value
            End Set
        End Property

        Friend Shared Function ReadContact1() As Contact
            Dim c As Contact = New Contact("1")
            c.Name = "John Doe"
            c.PurchaseDate = Parse("5/3/2013")
            c.PaymentAmount = 330.99
            Return c
        End Function

        Friend Shared Function ReadContact2() As Contact
            Dim c As Contact = New Contact("2")
            c.Name = "Sam Hill"
            c.PurchaseDate = Parse("5/7/2014")
            c.PaymentAmount = 100.0
            Return c
        End Function

        Friend Shared Function ReadContact3() As Contact
            Dim c As Contact = New Contact("3")
            c.Name = "Karen Holmes"
            c.PurchaseDate = Parse("7/11/2014")
            c.PaymentAmount = 230.50
            Return c
        End Function

        Friend Shared Function ReadContact4() As Contact
            Dim c As Contact = New Contact("4")
            c.Name = "Bobbie Valentine"
            c.PurchaseDate = Parse("6/1/2013")
            c.PaymentAmount = 550.1
            Return c
        End Function

        Friend Shared Function ReadContact5() As Contact
            Dim c As Contact = New Contact("5")
            c.Name = "Frank Frankson"
            c.PurchaseDate = Parse("2/2/2012")
            c.PaymentAmount = 50.0
            Return c
        End Function

        Private Shared Function Parse(ByVal dateTime As String) As Date
            Return Date.Parse(dateTime, Globalization.CultureInfo.InvariantCulture)
        End Function
    End Class

    ' <lookUpEdit3>
    Public Class Record

        Private fCountry As String

        Public Sub New(ByVal fCountry As String)
            Me.fCountry = fCountry
        End Sub

        Public Property Country As String
            Get
                Return fCountry
            End Get

            Set(ByVal value As String)
                fCountry = value
            End Set
        End Property
    End Class
' </lookUpEdit3>
End Namespace
