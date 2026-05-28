Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Native
Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace DevExpress.XtraScheduler.Demos

    Public Module MedicScheduleDataHelper

        Public BaseDate As Date = TutorialConstants.Today

        Public AppointmentTypes As String() = {"Hospital", "Office", "Phone Consultation", "Home", "Hospice"}

        Public AppointmentColorTypes As SchedulerColorId() = {SchedulerColorId.BusinessLabel, SchedulerColorId.ImportantLabel, SchedulerColorId.PhoneCallLabel, SchedulerColorId.PersonalLabel, SchedulerColorId.VacationLabel}

        Public PaymentStates As String() = {"Paid", "Unpaid"}

        Public PaymentColorStates As Color() = {Color.Green, Color.Red}

        Public PatientNames As String() = {"Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith", "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell", "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander", "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer", "Samantha Piper", "Maggie Boxter", "Terry Bradley", "Stu Pizaro", "Greta Sims", "Sandra Johnson", "Cindy Stanwick", "Marcus Orbison", "Sandy Bright", "Ken Samuelson", "Brett Wade", "Wally Hobbs", "Brad Jameson", "Karen Goodson", "Morgan Kennedy", "Violet Bailey", "John Heart", "Arthur Miller", "Robert Reagan", "Ed Holmes", "Sammy Hill", "Olivia Peyton", "Jim Packard", "Hannah Brookly", "Harv Mudd", "Todd Hoffman", "Kevin Carter", "Mary Stern", "Robin Cosworth", "Jenny Hobbs", "Dallas Lou"}

        Public departmentCache As Dictionary(Of String, String()) = New Dictionary(Of String, String())()

        Sub New()
            departmentCache.Add("Therapy", New String() {"Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris"})
            departmentCache.Add("Ophthalmology", New String() {"Lucy Ball"})
            departmentCache.Add("Dentistry", New String() {"Clark Morgan", "Leah Simpson"})
            departmentCache.Add("Surgery", New String() {"Davey Jones"})
            departmentCache.Add("Neurology", New String() {"Samantha Bright"})
        End Sub

        Public Function CreatePatients() As List(Of Patient)
            Dim patients As List(Of Patient) = New List(Of Patient)()
            Dim patientCount As Integer = PatientNames.Length
            Dim patientId As Integer = 1
            Dim birthday As Date = New DateTime(1975, 2, 5)
            For i As Integer = 0 To patientCount - 1
                Dim patient As Patient = New Patient()
                patient.Id = Math.Min(Threading.Interlocked.Increment(patientId), patientId - 1)
                patient.Name = PatientNames(i)
                patient.Birthday = birthday.AddMonths(TutorialConstants.Random.Next(1, 12)).AddYears(TutorialConstants.Random.Next(0, 20))
                patient.Phone = "(" & TutorialConstants.Random.Next(100, 999) & ") " & TutorialConstants.Random.Next(100, 999) & "-" & TutorialConstants.Random.Next(1000, 9999)
                patients.Add(patient)
            Next

            Return patients
        End Function

        Public Function CreateHospitalDepartments() As List(Of HospitalDepartment)
            Dim departments As List(Of HospitalDepartment) = New List(Of HospitalDepartment)()
            Dim departmentId As Integer = 1
            For Each name As String In departmentCache.Keys
                Dim department As HospitalDepartment = New HospitalDepartment()
                department.Id = Math.Min(Threading.Interlocked.Increment(departmentId), departmentId - 1)
                department.Name = name
                departments.Add(department)
            Next

            Return departments
        End Function

        Public Function CreateMedics(ByVal hospitalDepartments As List(Of HospitalDepartment)) As List(Of Medic)
            Dim departmentCache As Dictionary(Of String, String()) = MedicScheduleDataHelper.departmentCache
            Dim medics As List(Of Medic) = New List(Of Medic)()
            Dim departmentId As Integer = 1
            Dim medicId As Integer = 1
            For Each department As KeyValuePair(Of String, String()) In departmentCache
                Dim medicNames As String() = department.Value
                Dim medicCount As Integer = medicNames.Length
                For i As Integer = 0 To medicCount - 1
                    Dim medic As Medic = New Medic()
                    medic.Id = Math.Min(Threading.Interlocked.Increment(medicId), medicId - 1)
                    medic.Name = medicNames(i)
                    medic.Phone = "(" & TutorialConstants.Random.Next(10, 99) & ") " & TutorialConstants.Random.Next(100, 999) & "-" & TutorialConstants.Random.Next(1000, 9999)
                    medic.DepartmentId = departmentId
                    Dim imageName As String = String.Format("MedicData.Images.{0}.png", medic.Name.Replace(" ", ""))
                    If Not Equals(DemoUtils.FindResourceName(imageName), String.Empty) Then
                        Dim image As Image = ResourceImageHelperCore.CreateImageFromResources(DemoUtils.FindResourceName(imageName), Reflection.Assembly.GetExecutingAssembly())
                        medic.SetPhoto(image)
                    End If

                    medics.Add(medic)
                Next

                departmentId += 1
            Next

            Return medics
        End Function

        Public Function CreateMedicalAppointments(ByVal resources As List(Of Medic)) As List(Of MedicalAppointment)
            Dim appointments As List(Of MedicalAppointment) = New List(Of MedicalAppointment)()
            Dim patients As List(Of Patient) = CreatePatients()
            Dim appointmentId As Integer = 1
            Dim patientIndex As Integer = 0
            Dim [date] As Date = DateTimeHelper.GetStartOfWeek(BaseDate)
            For Each medic As Medic In resources
                Dim duration As TimeSpan = CalculateAppointmentDuration(medic)
                Dim firstDate As Date = New DateTime([date].Year, [date].Month, [date].Day, TutorialConstants.Random.Next(9, 11), 0, 0)
                Dim startDate As Date = firstDate
                While startDate < firstDate.AddDays(10)
                    Dim endTime As TimeSpan = New TimeSpan(18, 0, 0)
                    endTime = endTime.Add(-duration)
                    Dim endDate As Date = New DateTime(startDate.Year, startDate.Month, startDate.Day, endTime.Hours, endTime.Minutes, 0)
                    Dim room As Integer = TutorialConstants.Random.Next(1, 100)
                    Dim startTime As Date = startDate
                    While startTime < endDate
                        appointments.Add(CreateMedicAppointment(appointmentId, medic.Id, patients(patientIndex), startTime, duration, room))
                        appointmentId += 1
                        patientIndex += 1
                        If patientIndex >= patients.Count() - 1 Then patientIndex = 1
                        startTime += duration.Add(New TimeSpan(0, TutorialConstants.Random.Next(2, 4) * 10, 0))
                    End While

                    startDate += TimeSpan.FromDays(1)
                End While
            Next

            Return appointments
        End Function

        Public Sub CreateLabels(ByVal storage As SchedulerDataStorage)
            Dim labels As PersistentAppointmentLabelCollection = storage.Appointments.Labels
            labels.Clear()
            Dim count As Integer = AppointmentTypes.Length
            For i As Integer = 0 To count - 1
                labels.Add(AppointmentColorTypes(i), AppointmentTypes(i), AppointmentTypes(i))
            Next
        End Sub

        Public Sub CreateStatuses(ByVal storage As SchedulerDataStorage)
            Dim statuses As PersistentAppointmentStatusCollection = storage.Appointments.Statuses
            statuses.Clear()
            Dim count As Integer = PaymentStates.Length
            For i As Integer = 0 To count - 1
                statuses.Add(PaymentColorStates(i), PaymentStates(i))
            Next
        End Sub

        Private Function CalculateAppointmentDuration(ByVal resource As Medic) As TimeSpan
            Select Case resource.DepartmentId
                Case 1
                    Return New TimeSpan(0, TutorialConstants.Random.Next(2, 4) * 10, 0)
                Case 2
                    Return New TimeSpan(0, TutorialConstants.Random.Next(3, 6) * 10, 0)
                Case 3
                    Return New TimeSpan(TutorialConstants.Random.Next(0, 1), TutorialConstants.Random.Next(3, 4) * 10, 0)
                Case 4
                    Return New TimeSpan(TutorialConstants.Random.Next(0, 1), TutorialConstants.Random.Next(2, 5) * 10, 0)
                Case 5
                    Return New TimeSpan(0, TutorialConstants.Random.Next(2, 3) * 10, 0)
                Case Else
                    Return New TimeSpan(0, TutorialConstants.Random.Next(2, 3) * 10, 0)
            End Select
        End Function

        Private Function CreateMedicAppointment(ByVal appointmentId As Long, ByVal resourceId As Long, ByVal patient As Patient, ByVal start As Date, ByVal duration As TimeSpan, ByVal room As Integer) As MedicalAppointment
            Dim medicalAppointment As MedicalAppointment = New MedicalAppointment()
            medicalAppointment.Id = appointmentId
            medicalAppointment.StartTime = start
            medicalAppointment.EndTime = start.Add(duration)
            medicalAppointment.IssueId = TutorialConstants.Random.Next(0, 5)
            medicalAppointment.PaymentStatusId = TutorialConstants.Random.Next(0, 2)
            medicalAppointment.PatientId = patient.Id
            medicalAppointment.MedicId = resourceId
            If medicalAppointment.IssueId <> 3 Then medicalAppointment.Location = String.Format("{0}", room)
            Return medicalAppointment
        End Function
    End Module
End Namespace
