Imports DevExpress.Xpo

Namespace DevExpress.XtraScheduler.Demos

    ' XP object
    Public Class OlAppointment
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Start As Date ' Appointment.Start

        Public [End] As Date ' Appointment.End

        Public Subject As String ' Appointment.Subject

        <Size(SizeAttribute.Unlimited)>
        Public Body As String ' Appointment.Description

        Public AllDayEvent As Boolean ' Appointment.AllDay

        Public BusyStatus As Integer ' Appointment.Status

        Public Location As String ' Appointment.Location

        <Size(SizeAttribute.Unlimited)>
        Public RecurrencePattern As String ' Appointment.RecurrenceInfo

        <Size(SizeAttribute.Unlimited)>
        Public ReminderSet As String ' Appointment.ReminderInfo

        Public AppointmentType As Integer ' Appointment.Type

        Public Label As Integer ' Appointment.Label

        <Size(SizeAttribute.Unlimited)> 
        Public EntryID As String ' ForeignIdFieldName
    End Class
End Namespace
