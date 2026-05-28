Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DevExpress.XtraScheduler.Demos

    Public Class MedicalAppointment

        <Key>
        Public Property Id As Long

        Public Property AllDay As Boolean

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property PatientId As Long?

        <ForeignKey("PatientId")>
        Public Property Patient As Patient

        Public Property Note As String

        Public Property PaymentStatusId As Integer

        Public Property IssueId As Integer

        Public Property EventType As Integer

        Public Property Location As String

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property MedicId As Long?
    End Class
End Namespace
