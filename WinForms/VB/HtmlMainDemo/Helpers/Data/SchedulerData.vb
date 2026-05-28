Imports DevExpress.DevAV
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
#If Not NET
Imports System.Data.Entity
#Else
using Microsoft.EntityFrameworkCore;
#End If
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Linq
Imports DevExpress.DXperience.Demos

Namespace DevExpress.HTML.Demos.Helpers

    Public Class SchedulerData

        Private locations As IList(Of String) = New List(Of String)()

        Private ReadOnly Property Start As Date
            Get
                Return TutorialConstants.Today
            End Get
        End Property

        Public Sub New()
#If NET
            DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#Else
            Dim devAvDb As DevAVDb = New DevAVDb()
#End If
            devAvDb.Employees.Load()
            Employees = New Dictionary(Of String, Employee)()
            Employees = devAvDb.Employees.Local.ToDictionary(Function(employee) employee.FullName)
        End Sub

        Public ReadOnly Property Employees As Dictionary(Of String, Employee)

        Public Sub AttachToScheduler(ByVal scheduler As SchedulerControl)
            scheduler.Tag = Me
            Dim storage As SchedulerDataStorage = CType(scheduler.DataStorage, SchedulerDataStorage)
            scheduler.BeginUpdate()
            Try
                storage.DateTimeSavingMode = DateTimeSavingMode.Storage
                CreateLabels(scheduler)
                GenerateResources()
                GenerateLocations()
                CreateMappings(storage)
                storage.Resources.DataSource = GenerateResources()
                storage.Appointments.DataSource = GenerateEvents()
                AddHandler scheduler.InitNewAppointment, Sub(o, e)
                    If CType(o, SchedulerControl).GroupType = SchedulerGroupType.None Then e.Appointment.ResourceId = 1
                End Sub
            Finally
                scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub CreateLabels(ByVal scheduler As SchedulerControl)
            Dim storage As SchedulerDataStorage = CType(scheduler.DataStorage, SchedulerDataStorage)
            storage.Appointments.Labels.Clear()
            storage.Appointments.Labels.Add(SchedulerColorId.BirthdayLabel, "1 Category", "1 Category")
            storage.Appointments.Labels.Add(SchedulerColorId.NeedsPreparationLabel, "2 Category", "2 Category")
            storage.Appointments.Labels.Add(SchedulerColorId.VacationLabel, "3 Category", "3 Category")
            storage.Appointments.Labels.Add(SchedulerColorId.PhoneCallLabel, "4 Category", "4 Category")
        End Sub

        Private Sub CreateMappings(ByVal storage As ISchedulerStorage)
            Dim appointmentMappings As AppointmentMappingInfo = storage.Appointments.Mappings
            appointmentMappings.AppointmentId = "Id"
            appointmentMappings.Start = "StartDate"
            appointmentMappings.End = "EndDate"
            appointmentMappings.AllDay = "AllDay"
            appointmentMappings.Subject = "Subject"
            appointmentMappings.Description = "Description"
            appointmentMappings.Location = "Location"
            appointmentMappings.ReminderInfo = "ReminderInfo"
            appointmentMappings.RecurrenceInfo = "RecurrenceInfo"
            appointmentMappings.Type = "EventType"
            appointmentMappings.ResourceId = "ResourceId"
            appointmentMappings.Label = "LabelId"
            appointmentMappings.Status = "StatusId"
            storage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Position", "Position", FieldValueType.String))
            storage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Employee", "Employee", FieldValueType.String))
            Dim resourceMappings As ResourceMappingInfo = storage.Resources.Mappings
            resourceMappings.Id = "Id"
            resourceMappings.Caption = "Caption"
            resourceMappings.ParentId = "ParentId"
            resourceMappings.Image = "Image"
        End Sub

        Private Function GenerateResources() As CalendarBindingList
            Dim calendars As CalendarBindingList = New CalendarBindingList()
            calendars.Add(New Calendar() With {.Id = 0, .Caption = "DevAV", .ParentId = 0})
            Return calendars
        End Function

        Private Sub GenerateLocations()
            locations.Add("Conference Room A")
            locations.Add("Conference Room B")
            locations.Add("Training Room A")
            locations.Add("Training Room B")
        End Sub

        Private Function GenerateEvents() As EventBindingList
            Dim events As EventBindingList = New EventBindingList()
            Dim [date] As Date = Start
            Dim id As Integer = 0
            id += 1
            events.Add(Me.CreateEvent(id, [date].AddHours(8), [date].AddHours(10), "Review product literature and marketing brochures", "Detailed review of all product literature and discuss layout of new marketing brochures. " & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "Must address customer complaints that our specifications are not 100% accurate.", 0, 0, GetNextEmployee(id), "Marketing"))
            id += 1
            events.Add(Me.CreateEvent(id, [date].AddHours(CDbl(10)).AddMinutes(30), [date].AddHours(CDbl(12)).AddMinutes(30), "Team training session on new automation engine", "Discuss new home automation API and see if we are close to integrating our products with Amazon Alexa. " & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "Need to figure out if we'll ever release our own controller as well.", 2, 2, GetNextEmployee(id), "Product Manager"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(13), [date].AddHours(15), "Board of Directors meeting", "Demonstrate need for outside capital to help fuel sales growth and describe risks to business from weakness in supply chain.", 1, 1, GetNextEmployee(id), "Director"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(15).AddMinutes(30), [date].AddHours(17).AddMinutes(30), "Customer service training part 1", "Jack Howell from Worldwide Consulting will pay us a visit to give us pointers on how to improve our customer service processes.", 3, 3, GetNextEmployee(id), "Support Engineer"))
            [date] = [date].AddDays(1)
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(8), [date].AddHours(10), "Product development meeting with R&D team", "Review schematics for new projectors and discuss options for 8K and Dolby Atmos. Determine if we should create our own A/V receiver.", 0, 0, GetNextEmployee(id), "Product Manager"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(10).AddMinutes(30), [date].AddHours(12).AddMinutes(30), "Customer service training part 2", "Part 2 - Jack promises that he will share some cutting edge techniques and case studies on how his system revolutionizes customer service processes.", 2, 2, GetNextEmployee(id), "Support Engineer"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(13), [date].AddHours(15), "Company-wide meeting", "Everyone must be ready to ask questions and inform leadership team why they are not performing as expected and what we need to do as a team to improve morale.", 1, 1, GetNextEmployee(id), "Director"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(15).AddMinutes(30), [date].AddHours(17).AddMinutes(30), "Train staff on new remote controls", "Our newest remote controls are ready for production. Everyone needs to understand how our new universal remote works and our long term plans for better automation.", 3, 3, GetNextEmployee(id), "Product Manager"))
            [date] = [date].AddDays(1)
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(8), [date].AddHours(10), "Review financials with outside accounting firm", "Determine if all accounting rules are followed and make certain that last year's errors are addressed and will no longer be an issue going forward.", 0, 0, GetNextEmployee(id), "Accountant"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(10).AddMinutes(30), [date].AddHours(12).AddMinutes(30), "Sales Force Training", "All sales reps will be in attendance. Review sales techniques to determine how to best improve closing rates. Make certain to answer all product related questions during meeting.", 2, 2, GetNextEmployee(id), "Marketing Team"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(13), [date].AddHours(15), "Meeting with risk analysts", "Economists are suggesting that we are about to enter a global recession. Some analysts dispute this reality and we need to figure out who is right.", 1, 1, GetNextEmployee(id), "Director"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(15).AddMinutes(30), [date].AddHours(17).AddMinutes(30), "Company meeting", "Review rules that govern workplace behavior. Discuss impact of changes to the law and how it will impact DevAV in the upcoming 12 months.", 3, 3, GetNextEmployee(id), "Product Manager"))
            [date] = [date].AddDays(1)
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(8), [date].AddHours(10), "Meeting with outside HR team", "Johnson & Co is promising to reduce our HR costs and improve the quality of hires. Need to verify that their proposal is factual and not smoke and mirrors.", 0, 0, GetNextEmployee(id), "Accountant"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(10).AddMinutes(30), [date].AddHours(12).AddMinutes(30), "Database overhaul meeting", "Meet to discuss changes required to our database to deal with new products and to address on-going complaints from staff members about performance.", 2, 2, GetNextEmployee(id), "Product Manager"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(13), [date].AddHours(15), "Review the basic principles of Game Theory", "Discuss game theory with entire team and see if we have the tools necessary to improve internal decision making.", 1, 1, GetNextEmployee(id), "Evangelist"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(15).AddMinutes(30), [date].AddHours(17).AddMinutes(30), "Determine operational deficiencies", "Weaknesses remain throughout operations and we need to determine the weakest link and eliminate any bottlenecks in production.", 3, 3, GetNextEmployee(id), "Product Manager"))
            [date] = [date].AddDays(1)
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(8), [date].AddHours(10), "Meeting to discuss progress on new website", "The website is taking far too long to develop and we need to get everyone on board with management's plan to release the site this month.", 0, 0, GetNextEmployee(id), "Evangelist"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(10).AddMinutes(30), [date].AddHours(12).AddMinutes(30), "East-coast distributors meeting", "Host major distributors in the conference room and show them why they need to start carrying our products today.", 2, 2, GetNextEmployee(id), "Director"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(13), [date].AddHours(15), "Meet with analysts and media", "Share our upcoming product releases, discuss stengths of existing product line and provide demos of our new 8K panels.", 1, 1, GetNextEmployee(id), "Product Manager"))
            id += 1
            events.Add(CreateEvent(id, [date].AddHours(15).AddMinutes(30), [date].AddHours(17).AddMinutes(30), "Meeting with EU regulators", "Meet with EU regulators to determine battery disposal regulations and how we can avoid fines going forward. Need to verify if our current procedures are sufficient.", 3, 3, GetNextEmployee(id), "Director"))
            Return events
        End Function

        Private Function GetNextEmployee(ByVal id As Integer) As Employee
            If Employees.Values.Count < id Then Return Employees.Values.ElementAt(id Mod Employees.Values.Count)
            Return Employees.Values.ElementAt(id)
        End Function

        Private Function CreateEvent(ByVal id As Integer, ByVal startDate As Date, ByVal endDate As Date, ByVal subject As String, ByVal description As String, ByVal locationId As Integer, ByVal labelId As Integer, ByVal employee As Employee, ByVal position As String) As EventData
            Dim result As EventData = New EventData()
            result.Id = id
            result.StartDate = startDate
            result.EndDate = endDate
            result.Subject = subject
            result.Description = description
            result.AllDay = False
            result.ResourceId = 0
            result.EventType = 0
            result.Location = locations(locationId)
            result.LabelId = labelId
            result.StatusId = 0
            result.Employee = employee.FullName
            result.Photo = employee.Photo
            result.Position = position
            Return result
        End Function
    End Class

    Public Class Calendar

        Public Property Id As Integer

        Public Property Caption As String

        Public Property ParentId As Integer

        Public Property Image As Svg.SvgImage
    End Class

    Public Class CalendarBindingList
        Inherits BindingList(Of Calendar)

    End Class

    Public Class EventBindingList
        Inherits BindingList(Of EventData)

        Public Sub New()
        End Sub
    End Class

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

        Public Property Employee As String

        Public Property Position As String

        Public Property Photo As Image

        Public Property Location As String

        Public Property ReminderInfo As String

        Public Property RecurrenceInfo As String

        Public Property EventType As Integer

        Public Property ResourceId As Integer
    End Class
End Namespace
