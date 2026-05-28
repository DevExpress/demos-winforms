Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DevExpress.XtraScheduler.Demos

    Public Class CarScheduling

        <Key>
        Public Property Id As Long

        Public Property AllDay As Boolean

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property Description As String

        Public Property Status As Integer

        Public Property Label As Integer

        Public Property EventType As Integer

        Public Property Location As String

        Public Property Subject As String

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property CarId As Integer?

        Public Property Price As Double
    End Class
End Namespace
