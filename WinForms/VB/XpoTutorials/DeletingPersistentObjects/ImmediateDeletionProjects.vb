Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos

    '
    '* If the XPBaseObject is used as the base class for persistent objects,
    '* immediate object deletion is enabled (deferred object deletion is disabled).
    '* In this instance, the record in the underlying data store is immediately deleted
    '* after the object has been deleted.
    '

    Public Class ImmediateDeletionProject
        Inherits XPBaseObject
        Public Sub New()
        End Sub
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal projectName As String, ByVal owner As String, ByVal createdDate As DateTime)
            MyBase.New(session)
            Me.fProjectName = projectName
            Me.fOwner = owner
            Me.fCreatedDate = createdDate
        End Sub

        Private fId As Integer
        Private fProjectName As String
        Private fOwner As String
        Private fCreatedDate As DateTime

        <Key(True)> _
        Public Property ID() As Integer
            Get
                Return fId
            End Get
            Set(ByVal value As Integer)
                If Value = ID Then
                    Return
                End If
                fId = Value
            End Set
        End Property

        Public Property ProjectName() As String
            Get
                Return fProjectName
            End Get
            Set(ByVal value As String)
                ' The old value of the ProjectName property.
                Dim oldValue As String = ProjectName
                If oldValue = Value Then
                    Return
                End If
                fProjectName = value
                ' Keep track of every change made to the ProjectName property.
                OnChanged(NameOf(ProjectName), oldValue, value)
            End Set
        End Property

        Public Property Owner() As String
            Get
                Return fOwner
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = Owner
                If oldValue = Value Then
                    Return
                End If
                fOwner = value
                OnChanged(NameOf(Owner), oldValue, value)
            End Set
        End Property

        Public Property CreatedDate() As DateTime
            Get
                Return fCreatedDate
            End Get
            Set(ByVal value As DateTime)
                Dim oldValue As DateTime = CreatedDate
                If oldValue = Value Then
                    Return
                End If
                fCreatedDate = value
                OnChanged(NameOf(CreatedDate), oldValue, value)
            End Set
        End Property
    End Class
End Namespace
