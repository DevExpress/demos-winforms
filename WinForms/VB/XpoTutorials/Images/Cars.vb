Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata

Namespace DevExpress.Xpo.Demos
    <Persistent("Model")>
    Public Class Cars
        Inherits XPLiteObject
        Private fID As Integer
        <Key()>
        Public Property ID() As Integer
            Get
                Return fID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)(NameOf(ID), fID, value)
            End Set
        End Property
        Private fTrademark As Trademark
        <Size(SizeAttribute.Unlimited), Persistent("TrademarkID")>
        Public Property Trademark() As Trademark
            Get
                Return fTrademark
            End Get
            Set(ByVal value As Trademark)
                SetPropertyValue(Of Trademark)(NameOf(Trademark), fTrademark, value)
            End Set
        End Property
        <PersistentAlias("Trademark.Name")>
        Public ReadOnly Property TrademarkName() As String
            Get
                Return CStr(EvaluateAlias(NameOf(TrademarkName)))
            End Get
        End Property
        Private fModel As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("Name")>
        Public Property Model() As String
            Get
                Return fModel
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Model), fModel, value)
            End Set
        End Property
        Private fPicture As System.Drawing.Image
        <Size(SizeAttribute.Unlimited), ValueConverter(GetType(DevExpress.Xpo.Metadata.ImageValueConverter)), Persistent("Photo")>
        Public Property Picture() As System.Drawing.Image
            Get
                Return fPicture
            End Get
            Set(ByVal value As System.Drawing.Image)
                SetPropertyValue(Of System.Drawing.Image)(NameOf(Picture), fPicture, value)
            End Set
        End Property
        Private fPrice As Decimal
        Public Property Price() As Decimal
            Get
                Return fPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)(NameOf(Price), fPrice, value)
            End Set
        End Property
        Private fIsInStock As Boolean
        <Persistent("InStock")>
        Public Property IsInStock() As Boolean
            Get
                Return fIsInStock
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)(NameOf(IsInStock), fIsInStock, value)
            End Set
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Trademark
        Inherits XPLiteObject
        Private fID As Integer
        Private fName As String
        <Key>
        Public Property ID() As Integer
            Get
                Return fID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(NameOf(ID), fID, value)
            End Set
        End Property
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(NameOf(Name), fName, value)
            End Set
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class
End Namespace
