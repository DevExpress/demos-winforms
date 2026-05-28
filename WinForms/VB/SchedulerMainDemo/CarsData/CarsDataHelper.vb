Imports DevExpress.DXperience.Demos
Imports System
Imports System.ComponentModel
Imports System.Globalization

Namespace DevExpress.XtraScheduler.Demos

    Public Module CarsDataHelper

        Private NotInheritable Class CarLabel

            Public Const None As Integer = 0

            Public Const Important As Integer = 1

            Public Const Business As Integer = 2

            Public Const Personal As Integer = 3

            Public Const Vacation As Integer = 4

            Public Const MustAttend As Integer = 5
        End Class

        Private NotInheritable Class CarStatus

            Public Const Free As Integer = 0

            Public Const Tentative As Integer = 1

            Public Const Busy As Integer = 2

            Public Const OutOfOffice As Integer = 3

            Public Const WorkingElsewhere As Integer = 4
        End Class

        Public NotInheritable Class CarBrand

            Public Const MercedesBenz As Integer = 1

            Public Const Audi As Integer = 2

            Public Const Chevrolet As Integer = 3

            Public Const Lexus As Integer = 4

            Public Const Toyota As Integer = 5

            Public Const Nissan As Integer = 6

            Public Const Ford As Integer = 7
        End Class

        Private NotInheritable Class CarLocation

            Public Const Garage As String = "Garage"

            Public Const ServiceCenter As String = "Service Center"

            Public Const City As String = "City"

            Public Const OutOfTown As String = "Out-Of-Town"
        End Class

        Private NotInheritable Class CarDescription

            Public Const Rent As String = "Rent this car"

            Public Const RentAllDay As String = "Rent this car for the all day"

            Public Const Repair As String = "Scheduled repair of this car"

            Public Const CheckUp As String = "Check up after maintenance"

            Public Const Wash As String = "Wash this car in the garage"
        End Class

        Public Sub FillData(ByVal control As SchedulerControl, ByVal storage As ISchedulerStorage)
            storage.EnableReminders = False
            Dim [date] As Date = GetStartDate()
            FillStorageData(storage, [date])
            control.Start = [date]
            Dim dayView As DayView = TryCast(control.ActiveView, DayView)
            If dayView IsNot Nothing Then dayView.TopRowTime = TimeSpan.FromHours(9)
        End Sub

        Public Sub FillStorageData(ByVal storage As ISchedulerStorage, ByVal startDate As Date)
            storage.BeginUpdate()
            Try
                FillResources(storage)
                FillAppointments(storage, startDate)
            Finally
                storage.EndUpdate()
            End Try
        End Sub

        Public Sub FillResources(ByVal storage As ISchedulerStorage)
            storage.Resources.Mappings.Id = "Id"
            storage.Resources.Mappings.Caption = "Caption"
            storage.Resources.DataSource = CreateCars()
        End Sub

        Public Sub FillAppointments(ByVal storage As ISchedulerStorage, ByVal startDate As Date)
            storage.Appointments.Mappings.AllDay = "AllDay"
            storage.Appointments.Mappings.Description = "Description"
            storage.Appointments.Mappings.End = "EndTime"
            storage.Appointments.Mappings.Label = "Label"
            storage.Appointments.Mappings.Location = "Location"
            storage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            storage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            storage.Appointments.Mappings.ResourceId = "CarId"
            storage.Appointments.Mappings.Start = "StartTime"
            storage.Appointments.Mappings.Status = "Status"
            storage.Appointments.Mappings.Subject = "Subject"
            storage.Appointments.Mappings.Type = "EventType"
            storage.Appointments.DataSource = CreateAppointment(startDate)
        End Sub

        Public Function CreateCars() As BindingList(Of Car)
            Dim cars As BindingList(Of Car) = New BindingList(Of Car)()
            cars.Add(New Car(CarBrand.MercedesBenz, "Mercedes-Benz Slk350"))
            cars.Add(New Car(CarBrand.Chevrolet, "Chevrolet Camaro"))
            cars.Add(New Car(CarBrand.Audi, "Audi S8"))
            cars.Add(New Car(CarBrand.Lexus, "Lexus IS 350"))
            cars.Add(New Car(CarBrand.Toyota, "Toyota Tundra 4x4 Reg Cab"))
            cars.Add(New Car(CarBrand.Nissan, "Nissan Murano"))
            cars.Add(New Car(CarBrand.Ford, "Ford Mustang GT Coupe"))
            Return cars
        End Function

        Public Function CreateAppointment(ByVal startDate As Date) As BindingList(Of CarScheduling)
            Dim reccurenceFormat As String = "<RecurrenceInfo Start=""{0}"" End=""{1}"" WeekOfMonth=""{2}"" WeekDays=""{3}"" Month=""{4}"" OccurrenceCount=""{5}"" Range=""{6}"" Type=""{7}"" Id=""{8}""/>"
            Dim changedOccurrenceFormat As String = "<RecurrenceInfo Id=""{0}"" Index=""{1}""/>"
            Dim apts As BindingList(Of CarScheduling) = New BindingList(Of CarScheduling)()
#Region "Audi"
            Dim apt1 As CarScheduling = New CarScheduling()
            apt1.EventType = CInt(AppointmentType.Normal)
            apt1.StartTime = startDate.Add(New TimeSpan(3, 08, 15, 00))
            apt1.EndTime = startDate.Add(New TimeSpan(5, 16, 40, 00))
            apt1.Description = CarDescription.Repair
            apt1.Label = CarLabel.Vacation
            apt1.Location = CarLocation.ServiceCenter
            apt1.CarId = CarBrand.Audi
            apt1.Status = CarStatus.Tentative
            apt1.Subject = "Repair"
            apt1.Price = 90
            apts.Add(apt1)
#End Region
#Region "Chevrolet"
            Dim apt2 As CarScheduling = New CarScheduling()
            apt2.EventType = CInt(AppointmentType.Normal)
            apt2.StartTime = startDate.Add(New TimeSpan(10, 00, 00))
            apt2.EndTime = startDate.Add(New TimeSpan(2, 11, 45, 00))
            apt2.Description = CarDescription.Rent
            apt2.Label = CarLabel.MustAttend
            apt2.Location = CarLocation.OutOfTown
            apt2.CarId = CarBrand.Chevrolet
            apt2.Status = CarStatus.Tentative
            apt2.Subject = "Mrs.Black"
            apt2.Price = 5
            apts.Add(apt2)
            Dim apt3 As CarScheduling = New CarScheduling()
            apt3.EventType = CInt(AppointmentType.Normal)
            apt3.StartTime = startDate.Add(New TimeSpan(1, 13, 00, 00))
            apt3.EndTime = startDate.Add(New TimeSpan(1, 14, 30, 00))
            apt3.Description = CarDescription.Rent
            apt3.Label = CarLabel.Personal
            apt3.Location = CarLocation.OutOfTown
            apt3.CarId = CarBrand.Chevrolet
            apt3.Status = CarStatus.OutOfOffice
            apt3.Subject = "Mrs.Black"
            apt3.Price = 6
            apts.Add(apt3)
            Dim apt4 As CarScheduling = New CarScheduling()
            apt4.EventType = CInt(AppointmentType.Normal)
            apt4.StartTime = startDate.Add(New TimeSpan(2, 15, 30, 00))
            apt4.EndTime = startDate.Add(New TimeSpan(3, 14, 00, 00))
            apt4.Description = CarDescription.Rent
            apt4.Label = CarLabel.Personal
            apt4.Location = CarLocation.OutOfTown
            apt4.CarId = CarBrand.Chevrolet
            apt4.Status = CarStatus.OutOfOffice
            apt4.Subject = "Mrs.Black"
            apt4.Price = 4
            apts.Add(apt4)
            Dim apt5 As CarScheduling = New CarScheduling()
            apt5.EventType = CInt(AppointmentType.Pattern)
            apt5.StartTime = startDate.Add(New TimeSpan(07, 30, 00))
            apt5.EndTime = startDate.Add(New TimeSpan(08, 45, 00))
            apt5.Description = CarDescription.Wash
            apt5.Label = CarLabel.Business
            apt5.Location = CarLocation.Garage
            apt5.CarId = CarBrand.Chevrolet
            apt5.Status = CarStatus.Tentative
            apt5.Price = 4
            apt5.Subject = "Wash"
            Dim recInfo As RecurrenceInfo = New RecurrenceInfo()
            recInfo.Start = startDate.Add(New TimeSpan(07, 00, 00))
            recInfo.End = startDate.Add(New TimeSpan(44, 01, 00, 00))
            recInfo.WeekOfMonth = WeekOfMonth.None
            recInfo.Type = RecurrenceType.Weekly
            recInfo.WeekDays = WeekDays.Monday Or WeekDays.Wednesday Or WeekDays.Friday
            recInfo.Month = 12
            recInfo.OccurrenceCount = 1
            recInfo.Range = RecurrenceRange.EndByDate
            apt5.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, reccurenceFormat, recInfo.Start, recInfo.End, CInt(recInfo.WeekOfMonth), CInt(recInfo.WeekDays), recInfo.Month, recInfo.OccurrenceCount, CInt(recInfo.Range), CInt(recInfo.Type), recInfo.Id.ToString())
            apts.Add(apt5)
            Dim apt6 As CarScheduling = New CarScheduling()
            apt6.EventType = CInt(AppointmentType.ChangedOccurrence)
            apt6.StartTime = startDate.Add(New TimeSpan(8, 01, 30, 00))
            apt6.EndTime = startDate.Add(New TimeSpan(8, 09, 00, 00))
            apt6.Description = CarDescription.Wash
            apt6.Label = CarLabel.Business
            apt6.Location = CarLocation.Garage
            apt6.CarId = CarBrand.Chevrolet
            apt6.Status = CarStatus.Tentative
            apt6.Subject = "Wash"
            apt6.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo.Id.ToString(), 4)
            apt6.Price = 6
            apts.Add(apt6)
#End Region
#Region "MercedesBenz"
            Dim apt7 As CarScheduling = New CarScheduling()
            apt7.EventType = CInt(AppointmentType.Normal)
            apt7.StartTime = startDate
            apt7.EndTime = startDate.AddDays(1)
            apt7.AllDay = True
            apt7.Description = CarDescription.RentAllDay
            apt7.Label = CarLabel.Personal
            apt7.Location = CarLocation.City
            apt7.CarId = CarBrand.MercedesBenz
            apt7.Status = CarStatus.Busy
            apt7.Subject = "Mr.Green"
            apt7.Price = 6
            apts.Add(apt7)
            Dim apt8 As CarScheduling = New CarScheduling()
            apt8.EventType = CInt(AppointmentType.Normal)
            apt8.StartTime = startDate.Add(New TimeSpan(1, 11, 05, 00))
            apt8.EndTime = startDate.Add(New TimeSpan(1, 14, 30, 00))
            apt8.Description = CarDescription.Rent
            apt8.Label = CarLabel.Business
            apt8.Location = CarLocation.City
            apt8.CarId = CarBrand.MercedesBenz
            apt8.Status = CarStatus.OutOfOffice
            apt8.Subject = "Mr.Brown"
            apt8.Price = 8
            apts.Add(apt8)
            Dim apt9 As CarScheduling = New CarScheduling()
            apt9.EventType = CInt(AppointmentType.Normal)
            apt9.StartTime = startDate.Add(New TimeSpan(2, 10, 00, 00))
            apt9.EndTime = startDate.Add(New TimeSpan(4, 17, 00, 00))
            apt9.Description = CarDescription.Rent
            apt9.Label = CarLabel.Personal
            apt9.Location = CarLocation.City
            apt9.CarId = CarBrand.MercedesBenz
            apt9.Status = CarStatus.OutOfOffice
            apt9.Subject = "Mr.White"
            apt9.Price = 10
            apts.Add(apt9)
            Dim apt10 As CarScheduling = New CarScheduling()
            apt10.EventType = CInt(AppointmentType.Normal)
            apt10.StartTime = startDate.Add(New TimeSpan(4, 19, 45, 00))
            apt10.EndTime = startDate.Add(New TimeSpan(4, 22, 45, 00))
            apt10.Description = CarDescription.CheckUp
            apt10.Label = CarLabel.MustAttend
            apt10.Location = CarLocation.ServiceCenter
            apt10.CarId = CarBrand.MercedesBenz
            apt10.Status = CarStatus.WorkingElsewhere
            apt10.Subject = "Check up"
            apt10.Price = 45
            apts.Add(apt10)
            Dim apt11 As CarScheduling = New CarScheduling()
            apt11.EventType = CInt(AppointmentType.Pattern)
            apt11.StartTime = startDate.Add(New TimeSpan(-6, 16, 40, 00))
            apt11.EndTime = startDate.Add(New TimeSpan(-6, 17, 50, 00))
            apt11.Description = CarDescription.Wash
            apt11.Label = CarLabel.Important
            apt11.Location = CarLocation.Garage
            apt11.CarId = CarBrand.MercedesBenz
            apt11.Status = CarStatus.Tentative
            apt11.Subject = "Wash"
            apt11.Price = 7
            Dim recInfo1 As RecurrenceInfo = New RecurrenceInfo()
            recInfo1.Start = startDate.Add(New TimeSpan(-6, 16, 30, 00))
            recInfo1.End = startDate.Add(New TimeSpan(21, 00, 00, 00))
            recInfo1.WeekOfMonth = WeekOfMonth.None
            recInfo1.Type = RecurrenceType.Weekly
            recInfo1.WeekDays = WeekDays.WorkDays
            recInfo1.Month = 12
            recInfo1.OccurrenceCount = 1
            recInfo1.Range = RecurrenceRange.EndByDate
            apt11.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, reccurenceFormat, recInfo1.Start, recInfo1.End, CInt(recInfo1.WeekOfMonth), CInt(recInfo1.WeekDays), recInfo1.Month, recInfo1.OccurrenceCount, CInt(recInfo1.Range), CInt(recInfo1.Type), recInfo1.Id.ToString())
            apts.Add(apt11)
            Dim apt12 As CarScheduling = New CarScheduling()
            apt12.EventType = CInt(AppointmentType.ChangedOccurrence)
            apt12.StartTime = startDate.Add(New TimeSpan(2, 18, 30, 00))
            apt12.EndTime = startDate.Add(New TimeSpan(2, 20, 00, 00))
            apt12.Description = CarDescription.Wash
            apt12.Label = CarLabel.Important
            apt12.Location = CarLocation.Garage
            apt12.CarId = CarBrand.MercedesBenz
            apt12.Status = CarStatus.Tentative
            apt12.Subject = "Wash"
            apt12.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 6)
            apt12.Price = 5
            apts.Add(apt12)
            Dim apt13 As CarScheduling = New CarScheduling()
            apt13.EventType = CInt(AppointmentType.DeletedOccurrence)
            apt13.StartTime = startDate.Add(New TimeSpan(5, 16, 20, 00))
            apt13.EndTime = startDate.Add(New TimeSpan(5, 17, 40, 00))
            apt13.Description = CarDescription.Wash
            apt13.Label = CarLabel.Important
            apt13.Location = CarLocation.Garage
            apt13.CarId = CarBrand.MercedesBenz
            apt13.Status = CarStatus.Tentative
            apt13.Subject = "Wash"
            apt13.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 7)
            apt13.Price = 5
            apts.Add(apt13)
            Dim apt14 As CarScheduling = New CarScheduling()
            apt14.EventType = CInt(AppointmentType.ChangedOccurrence)
            apt14.StartTime = startDate.Add(New TimeSpan(9, 15, 00, 00))
            apt14.EndTime = startDate.Add(New TimeSpan(9, 16, 30, 00))
            apt14.Description = CarDescription.Wash
            apt14.Label = CarLabel.Important
            apt14.Location = CarLocation.Garage
            apt14.CarId = CarBrand.MercedesBenz
            apt14.Status = CarStatus.Tentative
            apt14.Subject = "Wash"
            apt14.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 11)
            apt14.Price = 5
            apts.Add(apt14)
            Dim apt15 As CarScheduling = New CarScheduling()
            apt15.EventType = CInt(AppointmentType.ChangedOccurrence)
            apt15.StartTime = startDate.Add(New TimeSpan(13, 16, 30, 00))
            apt15.EndTime = startDate.Add(New TimeSpan(13, 17, 00, 00))
            apt15.Description = CarDescription.Wash
            apt15.Label = CarLabel.Important
            apt15.Location = CarLocation.Garage
            apt15.CarId = CarBrand.MercedesBenz
            apt15.Status = CarStatus.Tentative
            apt15.Subject = "Wash"
            apt15.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 13)
            apt15.Price = 5
            apts.Add(apt15)
            Dim apt16 As CarScheduling = New CarScheduling()
            apt16.EventType = CInt(AppointmentType.DeletedOccurrence)
            apt16.StartTime = startDate.Add(New TimeSpan(2, 16, 25, 00))
            apt16.EndTime = startDate.Add(New TimeSpan(2, 17, 45, 00))
            apt16.Description = CarDescription.Wash
            apt16.Label = CarLabel.Important
            apt16.Location = CarLocation.Garage
            apt16.CarId = CarBrand.MercedesBenz
            apt16.Status = CarStatus.Tentative
            apt16.Subject = "Wash"
            apt16.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 4)
            apt16.Price = 6
            apts.Add(apt16)
#End Region
            Return apts
        End Function

        Public Function GetStartDate() As Date
            Dim [date] As Date = TutorialConstants.Today
            While [date].DayOfWeek <> DayOfWeek.Wednesday
                [date] = [date].AddDays(1)
            End While

            Return [date]
        End Function
    End Module
End Namespace
