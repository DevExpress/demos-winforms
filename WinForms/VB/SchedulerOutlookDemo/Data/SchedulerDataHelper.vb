Imports System
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos.DemoData

    Public Class SchedulerDataHelper

        Private _Locations As LocationDataBindingList

        Public Shared Sub Attach(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl, ByVal Optional hideParentResource As Boolean = True)
            Call New DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper().AttachToScheduler(scheduler, hideParentResource)
        End Sub

        Friend Shared Sub AttachYearView(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl)
            Call New DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper().AttachToYearView(scheduler)
        End Sub

        Public Shared Function GetLocations(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl) As LocationDataBindingList
            Dim instance As DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper = TryCast(scheduler.Tag, DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper)
            If instance Is Nothing Then Return Nothing
            Return instance.Locations
        End Function

        Public Shared Sub AddLocation(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl, ByVal location As String)
            If String.IsNullOrEmpty(location) Then Return
            Dim instance As DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper = TryCast(scheduler.Tag, DevExpress.XtraScheduler.Demos.DemoData.SchedulerDataHelper)
            If instance Is Nothing Then Return
            If instance.Locations.[Select](Function(x) x.Caption).Contains(location) Then Return
            instance.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = instance.Locations.Count, .Caption = location})
        End Sub

        Public Shared ReadOnly Property Start As DateTime
            Get
                Return System.DateTime.Today
            End Get
        End Property

        Private events As DevExpress.XtraScheduler.Demos.DemoData.EventBindingList = New DevExpress.XtraScheduler.Demos.DemoData.EventBindingList()

        Private calendars As DevExpress.XtraScheduler.Demos.DemoData.CalendarBindingList = New DevExpress.XtraScheduler.Demos.DemoData.CalendarBindingList()

        Public Sub New()
            Me.Locations = New DevExpress.XtraScheduler.Demos.DemoData.LocationDataBindingList()
        End Sub

        Public Property Locations As LocationDataBindingList
            Get
                Return _Locations
            End Get

            Private Set(ByVal value As LocationDataBindingList)
                _Locations = value
            End Set
        End Property

        Private Sub AttachToScheduler(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl, ByVal Optional hideParentResource As Boolean = True)
            scheduler.Tag = Me
            Dim storage As DevExpress.XtraScheduler.SchedulerDataStorage = CType(scheduler.DataStorage, DevExpress.XtraScheduler.SchedulerDataStorage)
            scheduler.BeginUpdate()
            Try
                storage.Appointments.ResourceSharing = True
                storage.DateTimeSavingMode = DevExpress.XtraScheduler.DateTimeSavingMode.Storage
                storage.Appointments.Labels.Clear()
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.NoneLabel, "None", "None")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.PersonalLabel, "Green Category", "Green Category")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.BusinessLabel, "Blue Category", "Blue Category")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.MustAttendLabel, "Orange Category", "Orange Category")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.BirthdayLabel, "Purple Category", "Purple Category")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.ImportantLabel, "Red Category", "Red Category")
                Me.GenerateLocations()
                Me.GenerateResources()
                Me.GenerateEvents()
                Me.PrepareResourceStorage(storage, hideParentResource)
                Me.PrepareAppointmentStorage(storage)
                AddHandler scheduler.InitNewAppointment, Sub(o, e)
                    If CType(o, DevExpress.XtraScheduler.SchedulerControl).GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None Then e.Appointment.ResourceId = 1
                End Sub
            Finally
                scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub PrepareResourceStorage(ByVal storage As DevExpress.XtraScheduler.ISchedulerStorage, ByVal hideParentResource As Boolean)
            Dim mappings As DevExpress.XtraScheduler.ResourceMappingInfo = storage.Resources.Mappings
            mappings.Id = "Id"
            mappings.Caption = "Caption"
            mappings.ParentId = "ParentId"
            storage.Resources.DataSource = Me.calendars
            If hideParentResource Then
                For Each resource As DevExpress.XtraScheduler.Resource In storage.Resources.Items
                    If resource.ParentId.Equals(resource.Id) Then Continue For
                    storage.Resources.GetResourceById(CObj((resource.ParentId))).Visible = False
                Next
            End If
        End Sub

        Private Sub PrepareAppointmentStorage(ByVal storage As DevExpress.XtraScheduler.ISchedulerStorage)
            Dim mappings As DevExpress.XtraScheduler.AppointmentMappingInfo = storage.Appointments.Mappings
            mappings.AppointmentId = "Id"
            mappings.Start = "StartDate"
            mappings.[End] = "EndDate"
            mappings.AllDay = "AllDay"
            mappings.Subject = "Subject"
            mappings.Description = "Description"
            mappings.Location = "Location"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.Type = "EventType"
            mappings.ResourceId = "CalendarIds"
            mappings.Label = "LabelId"
            mappings.Status = "StatusId"
            storage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Priority", "Priority", DevExpress.XtraScheduler.FieldValueType.[Integer]))
            storage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IsPrivate", "IsPrivate", DevExpress.XtraScheduler.FieldValueType.[Boolean]))
            storage.Appointments.DataSource = Me.events
        End Sub

        Private Sub GenerateLocations()
            Dim id As Integer = 0
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "My Office"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Conference Room A"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Lunch at Caroline's Steakhouse"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Conference Room B"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "MacArthur Country Club"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "R&R Health Spa"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Sam's Breakfast Nook"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "The Beer Garden Lunchroom"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Dr Drake Dental Center"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Training Room A"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Harry's Steakhouse"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "The Crossfit Center"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Training Room B"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "4 Corners Family Restaurant"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Community Hospital"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Tiffany's Breakfast Lounge"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Bob's Burgers"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Baseball Sadium"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Headquarters"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Hilton Hotel"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "The Lunch Counter"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Las Vegas"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Sal's Delicatessen"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Hilltop Development"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Suzy's Steakhouse"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Westside Country Club"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "The 19th Hole Pub"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Disneyland"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Brad's Sandwich Shop"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Great American Gym"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Sheraton Hotel"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Zeke's BBQ"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Los Angeles"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Home"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Sara's Breakfast Nook"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Breckenridge Seafood"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Hungry Heff's Burgers"})
            Call System.Threading.Interlocked.Increment(id)
            Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = id, .Caption = "Surgical Outpatient Center"})
            Call System.Threading.Interlocked.Increment(id)
        End Sub

        Private Sub GenerateResources()
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 0, .Caption = "Work", .ParentId = 0})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 1, .Caption = "Indoor meetings", .ParentId = 0})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 2, .Caption = "Outdoor meetings", .ParentId = 0})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 3, .Caption = "Partnership", .ParentId = 3})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 4, .Caption = "Personal", .ParentId = 4})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 5, .Caption = "Golfing", .ParentId = 4})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 6, .Caption = "Other", .ParentId = 0})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 7, .Caption = "Other Activities", .ParentId = 4})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 8, .Caption = "Baseball", .ParentId = 4})
            Me.calendars.Add(New DevExpress.XtraScheduler.Demos.DemoData.Calendar() With {.Id = 9, .Caption = "Family", .ParentId = 4})
        End Sub

        Private Sub GenerateEvents()
            Call DevExpress.XtraScheduler.Demos.DemoData.EventGenerator.Generate(Me.events, System.DateTime.Today)
        End Sub

        Private Sub AttachToYearView(ByVal scheduler As DevExpress.XtraScheduler.SchedulerControl)
            scheduler.Tag = Me
            Dim storage As DevExpress.XtraScheduler.SchedulerDataStorage = CType(scheduler.DataStorage, DevExpress.XtraScheduler.SchedulerDataStorage)
            scheduler.BeginUpdate()
            Try
                storage.DateTimeSavingMode = DevExpress.XtraScheduler.DateTimeSavingMode.Storage
                storage.Appointments.Labels.Clear()
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.PersonalLabel, "Vacation Leave", "Vacation Leave")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.MustAttendLabel, "Sick Leave", "Sick Leave")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.BusinessLabel, "FMLA", "FMLA")
                storage.Appointments.Labels.Add(DevExpress.XtraScheduler.SchedulerColorId.ImportantLabel, "Parental Leave", "Parental Leave")
                Me.Locations.Add(New DevExpress.XtraScheduler.Demos.DemoData.LocationData() With {.Id = 0, .Caption = "Home"})
                Call DevExpress.XtraScheduler.Demos.DemoData.EventGenerator.GenerateForYearView(Me.events)
                Me.PrepareAppointmentStorage(storage)
            Finally
                scheduler.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
