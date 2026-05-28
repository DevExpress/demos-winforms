Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.XtraScheduler.Demos.DemoData

    Public Class EventData

        <Key>
        Public Property Id As Long

        Public Property StartDate As Date

        Public Property EndDate As Date

        Public Property AllDay As Boolean

        Public Property Subject As String

        Public Property Description As String

        Public Property EventState As Integer

        Public Property LabelId As Integer

        Public Property StatusId As Integer

        Public Property IsPrivate As Boolean
            Get
                Return(EventState And 1) <> 0
            End Get

            Set(ByVal value As Boolean)
                EventState = EventState And -2 Or If(value, 1, 0)
            End Set
        End Property

        Public Property Priority As EventPriority
            Get
                Dim result As Integer = EventState And 6 >> 1
                If result = 6 Then Return EventPriority.None
                Return CType(result, EventPriority)
            End Get

            Set(ByVal value As EventPriority)
                EventState = EventState And -7 Or ((CInt(value)) << 1)
            End Set
        End Property

        Public Property Location As String

        Public Property ReminderInfo As String

        Public Property RecurrenceInfo As String

        Public Property EventType As Integer

        Public Property CalendarIds As String
    End Class

    Public Enum EventPriority
        None = 0
        Important = 1
        NotImportant = 2
    End Enum
End Namespace
