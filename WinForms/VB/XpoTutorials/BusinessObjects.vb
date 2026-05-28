Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos
    Public Class BusinessObject
        Inherits XPObject
        Public Sub New()
        End Sub
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal fText As String, ByVal fChecked As Boolean, ByVal fCurrency As Single)
            MyBase.New(session)
            Me.fText = fText
            Me.fChecked = fChecked
            Me.fCurrency = fCurrency
        End Sub

        Private fText As String
        Private fChecked As Boolean
        Private fCurrency As Single

        Public Property Text() As String
            Get
                Return fText
            End Get
            Set(ByVal value As String)
                ' The old value of the Text property.
                Dim oldValue As String = Text
                If oldValue = Value Then
                    Return
                End If
                fText = value
                ' Keep track of every change made to the Text property.
                OnChanged(NameOf(Text), oldValue, value)
            End Set
        End Property
        Public Property Checked() As Boolean
            Get
                Return fChecked
            End Get
            Set(ByVal value As Boolean)
                Dim oldValue As Boolean = Checked
                If oldValue = Value Then
                    Return
                End If
                fChecked = value
                OnChanged(NameOf(Checked), oldValue, value)
            End Set
        End Property
        Public Property Currency() As Single
            Get
                Return fCurrency
            End Get
            Set(ByVal value As Single)
                Dim oldValue As Single = Currency
                If oldValue = Value Then
                    Return
                End If
                fCurrency = value
                OnChanged(NameOf(Currency), oldValue, value)
            End Set
        End Property
    End Class
End Namespace
