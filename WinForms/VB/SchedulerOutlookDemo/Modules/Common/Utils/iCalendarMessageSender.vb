Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.iCalendar

Namespace DevExpress.XtraScheduler.Demos

    Public Module iCalendarMessageSender

        Public Sub ExportAppointments(ByVal owner As Form, ByVal storage As ISchedulerStorage, ByVal appointments As AppointmentBaseCollection)
            Dim tempDirInfos As List(Of DirectoryInfo) = New List(Of DirectoryInfo)(appointments.Count)
            Try
                Dim files As String() = New String(appointments.Count - 1) {}
                For i As Integer = 0 To appointments.Count - 1
                    Dim tempDirectoryName As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())
                    Dim tempDirInfo As DirectoryInfo = New DirectoryInfo(tempDirectoryName)
                    If tempDirInfo.Exists Then Return
                    tempDirInfo.Create()
                    tempDirInfos.Add(tempDirInfo)
                    Dim appointment As Appointment = appointments(i)
                    Dim appointmentsToExport As AppointmentBaseCollection = New AppointmentBaseCollection()
                    appointmentsToExport.Add(appointment)
                    Dim exporter As iCalendarExporter = New iCalendarExporter(storage, appointmentsToExport)
                    Dim filePath As String = Path.Combine(tempDirectoryName, GetFileName(appointment))
                    Using output As FileStream = File.OpenWrite(filePath)
                        exporter.Export(output)
                        files(i) = filePath
                        output.Flush()
                    End Using
                Next

                Dim appointmentCount As Integer = appointments.Count
                Dim fileName As String = If(appointmentCount = 1, String.Format("FW:{0}", GetFileName(appointments(0))), "")
                Dim actionForm As SendAppointmentByMailForm = New SendAppointmentByMailForm(fileName, files)
                actionForm.StartPosition = FormStartPosition.CenterParent
                actionForm.ShowDialog(owner)
            Finally
                For Each tempDirInfo As DirectoryInfo In tempDirInfos
                    tempDirInfo.Delete(True)
                Next
            End Try
        End Sub

        Private Function GetFileName(ByVal appointment As Appointment) As String
            Return String.Format("{0}.ics", If(String.IsNullOrEmpty(appointment.Subject), "Untitled", appointment.Subject))
        End Function
    End Module
End Namespace
