Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System.Runtime.CompilerServices

Namespace DevExpress.XtraScheduler.Demos

    Public Module AppointmentExtensions

        <Extension()>
        Public Function GetIsPrivate(ByVal appointment As Appointment) As Boolean
            Dim value As Object = appointment.CustomFields("IsPrivate")
            If value Is Nothing Then Return False
            Return CBool(value)
        End Function

        <Extension()>
        Public Sub SetIsPrivate(ByVal appointment As Appointment, ByVal value As Boolean)
            appointment.CustomFields("IsPrivate") = value
        End Sub

        <Extension()>
        Public Sub ToggleIsPrivate(ByVal appointment As Appointment)
            appointment.CustomFields("IsPrivate") = Not appointment.GetIsPrivate()
        End Sub

        <Extension()>
        Public Function GetPriority(ByVal appointment As Appointment) As EventPriority
            Dim value As Object = appointment.CustomFields("Priority")
            Return If(value Is Nothing, EventPriority.None, CType(value, EventPriority))
        End Function

        <Extension()>
        Public Sub SetPriority(ByVal appointment As Appointment, ByVal value As EventPriority)
            appointment.CustomFields("Priority") = value
        End Sub
    End Module
End Namespace
