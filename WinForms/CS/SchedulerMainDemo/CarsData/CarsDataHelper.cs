using DevExpress.DXperience.Demos;
using System;
using System.ComponentModel;
using System.Globalization;

namespace DevExpress.XtraScheduler.Demos {
    public static class CarsDataHelper {
        static class CarLabel {
            public const int None = 0;
            public const int Important = 1;
            public const int Business = 2;
            public const int Personal = 3;
            public const int Vacation = 4;
            public const int MustAttend = 5;
        }

        static class CarStatus {
            public const int Free = 0;
            public const int Tentative = 1;
            public const int Busy = 2;
            public const int OutOfOffice = 3;
            public const int WorkingElsewhere = 4;
        }

        public static class CarBrand {
            public const int MercedesBenz = 1;
            public const int Audi = 2;
            public const int Chevrolet = 3;
            public const int Lexus = 4;
            public const int Toyota = 5;
            public const int Nissan = 6;
            public const int Ford = 7;
        }

        static class CarLocation {
            public const string Garage = "Garage";
            public const string ServiceCenter = "Service Center";
            public const string City = "City";
            public const string OutOfTown = "Out-Of-Town";
        }

        static class CarDescription {
            public const string Rent = "Rent this car";
            public const string RentAllDay = "Rent this car for the all day";
            public const string Repair = "Scheduled repair of this car";
            public const string CheckUp = "Check up after maintenance";
            public const string Wash = "Wash this car in the garage";
        }


        public static void FillData(SchedulerControl control, ISchedulerStorage storage) {
            storage.EnableReminders = false;
            DateTime date = GetStartDate();
            FillStorageData(storage, date);
            control.Start = date;
            DayView dayView = control.ActiveView as DayView;
            if (dayView != null)
                dayView.TopRowTime = TimeSpan.FromHours(9);
        }

        public static void FillStorageData(ISchedulerStorage storage, DateTime startDate) {
            storage.BeginUpdate();
            try {
                FillResources(storage);
                FillAppointments(storage, startDate);
            }
            finally {
                storage.EndUpdate();
            }
        }

        public static void FillResources(ISchedulerStorage storage) {
            storage.Resources.Mappings.Id = "Id";
            storage.Resources.Mappings.Caption = "Caption";
            storage.Resources.DataSource = CreateCars();
        }

        public static void FillAppointments(ISchedulerStorage storage, DateTime startDate) {
            storage.Appointments.Mappings.AllDay = "AllDay";
            storage.Appointments.Mappings.Description = "Description";
            storage.Appointments.Mappings.End = "EndTime";
            storage.Appointments.Mappings.Label = "Label";
            storage.Appointments.Mappings.Location = "Location";
            storage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            storage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            storage.Appointments.Mappings.ResourceId = "CarId";
            storage.Appointments.Mappings.Start = "StartTime";
            storage.Appointments.Mappings.Status = "Status";
            storage.Appointments.Mappings.Subject = "Subject";
            storage.Appointments.Mappings.Type = "EventType";
            storage.Appointments.DataSource = CreateAppointment(startDate);
        }

        public static BindingList<Car> CreateCars() {
            BindingList<Car> cars = new BindingList<Car>();
            cars.Add(new Car(CarBrand.MercedesBenz, "Mercedes-Benz Slk350"));
            cars.Add(new Car(CarBrand.Chevrolet, "Chevrolet Camaro"));
            cars.Add(new Car(CarBrand.Audi, "Audi S8"));
            cars.Add(new Car(CarBrand.Lexus, "Lexus IS 350"));
            cars.Add(new Car(CarBrand.Toyota, "Toyota Tundra 4x4 Reg Cab"));
            cars.Add(new Car(CarBrand.Nissan, "Nissan Murano"));
            cars.Add(new Car(CarBrand.Ford, "Ford Mustang GT Coupe"));
            return cars;
        }

        public static BindingList<CarScheduling> CreateAppointment(DateTime startDate) {
            string reccurenceFormat = @"<RecurrenceInfo Start=""{0}"" End=""{1}"" WeekOfMonth=""{2}"" WeekDays=""{3}"" Month=""{4}"" OccurrenceCount=""{5}"" Range=""{6}"" Type=""{7}"" Id=""{8}""/>";
            string changedOccurrenceFormat = @"<RecurrenceInfo Id=""{0}"" Index=""{1}""/>";
            BindingList<CarScheduling> apts = new BindingList<CarScheduling>();

            #region Audi
            CarScheduling apt1 = new CarScheduling();
            apt1.EventType = (int)AppointmentType.Normal;
            apt1.StartTime = startDate.Add(new TimeSpan(3, 08, 15, 00));
            apt1.EndTime = startDate.Add(new TimeSpan(5, 16, 40, 00));
            apt1.Description = CarDescription.Repair;
            apt1.Label = CarLabel.Vacation;
            apt1.Location = CarLocation.ServiceCenter;
            apt1.CarId = CarBrand.Audi;
            apt1.Status = CarStatus.Tentative;
            apt1.Subject = "Repair";
            apt1.Price = 90;
            apts.Add(apt1);
            #endregion

            #region Chevrolet
            CarScheduling apt2 = new CarScheduling();
            apt2.EventType = (int)AppointmentType.Normal;
            apt2.StartTime = startDate.Add(new TimeSpan(10, 00, 00));
            apt2.EndTime = startDate.Add(new TimeSpan(2, 11, 45, 00));
            apt2.Description = CarDescription.Rent;
            apt2.Label = CarLabel.MustAttend;
            apt2.Location = CarLocation.OutOfTown;
            apt2.CarId = CarBrand.Chevrolet;
            apt2.Status = CarStatus.Tentative;
            apt2.Subject = "Mrs.Black";
            apt2.Price = 5;
            apts.Add(apt2);

            CarScheduling apt3 = new CarScheduling();
            apt3.EventType = (int)AppointmentType.Normal;
            apt3.StartTime = startDate.Add(new TimeSpan(1, 13, 00, 00));
            apt3.EndTime = startDate.Add(new TimeSpan(1, 14, 30, 00));
            apt3.Description = CarDescription.Rent;
            apt3.Label = CarLabel.Personal;
            apt3.Location = CarLocation.OutOfTown;
            apt3.CarId = CarBrand.Chevrolet;
            apt3.Status = CarStatus.OutOfOffice;
            apt3.Subject = "Mrs.Black";
            apt3.Price = 6;
            apts.Add(apt3);

            CarScheduling apt4 = new CarScheduling();
            apt4.EventType = (int)AppointmentType.Normal;
            apt4.StartTime = startDate.Add(new TimeSpan(2, 15, 30, 00));
            apt4.EndTime = startDate.Add(new TimeSpan(3, 14, 00, 00));
            apt4.Description = CarDescription.Rent;
            apt4.Label = CarLabel.Personal;
            apt4.Location = CarLocation.OutOfTown;
            apt4.CarId = CarBrand.Chevrolet;
            apt4.Status = CarStatus.OutOfOffice;
            apt4.Subject = "Mrs.Black";
            apt4.Price = 4;
            apts.Add(apt4);

            CarScheduling apt5 = new CarScheduling();
            apt5.EventType = (int)AppointmentType.Pattern;
            apt5.StartTime = startDate.Add(new TimeSpan(07, 30, 00));
            apt5.EndTime = startDate.Add(new TimeSpan(08, 45, 00));
            apt5.Description = CarDescription.Wash;
            apt5.Label = CarLabel.Business;
            apt5.Location = CarLocation.Garage;
            apt5.CarId = CarBrand.Chevrolet;
            apt5.Status = CarStatus.Tentative;
            apt5.Price = 4;
            apt5.Subject = "Wash";

            RecurrenceInfo recInfo = new RecurrenceInfo();
            recInfo.Start = startDate.Add(new TimeSpan(07, 00, 00));
            recInfo.End = startDate.Add(new TimeSpan(44, 01, 00, 00));
            recInfo.WeekOfMonth = WeekOfMonth.None;
            recInfo.Type = RecurrenceType.Weekly;
            recInfo.WeekDays = WeekDays.Monday | WeekDays.Wednesday | WeekDays.Friday;
            recInfo.Month = 12;
            recInfo.OccurrenceCount = 1;
            recInfo.Range = RecurrenceRange.EndByDate;
            apt5.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, reccurenceFormat, recInfo.Start, recInfo.End, (int)recInfo.WeekOfMonth, (int)recInfo.WeekDays, recInfo.Month, recInfo.OccurrenceCount, (int)recInfo.Range, (int)recInfo.Type, recInfo.Id.ToString());
            apts.Add(apt5);

            CarScheduling apt6 = new CarScheduling();
            apt6.EventType = (int)AppointmentType.ChangedOccurrence;
            apt6.StartTime = startDate.Add(new TimeSpan(8, 01, 30, 00));
            apt6.EndTime = startDate.Add(new TimeSpan(8, 09, 00, 00));
            apt6.Description = CarDescription.Wash;
            apt6.Label = CarLabel.Business;
            apt6.Location = CarLocation.Garage;
            apt6.CarId = CarBrand.Chevrolet;
            apt6.Status = CarStatus.Tentative;
            apt6.Subject = "Wash";
            apt6.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo.Id.ToString(), 4);
            apt6.Price = 6;
            apts.Add(apt6);
            #endregion

            #region MercedesBenz
            CarScheduling apt7 = new CarScheduling();
            apt7.EventType = (int)AppointmentType.Normal;
            apt7.StartTime = startDate;
            apt7.EndTime = startDate.AddDays(1);
            apt7.AllDay = true;
            apt7.Description = CarDescription.RentAllDay;
            apt7.Label = CarLabel.Personal;
            apt7.Location = CarLocation.City;
            apt7.CarId = CarBrand.MercedesBenz;
            apt7.Status = CarStatus.Busy;
            apt7.Subject = "Mr.Green";
            apt7.Price = 6;
            apts.Add(apt7);

            CarScheduling apt8 = new CarScheduling();
            apt8.EventType = (int)AppointmentType.Normal;
            apt8.StartTime = startDate.Add(new TimeSpan(1, 11, 05, 00));
            apt8.EndTime = startDate.Add(new TimeSpan(1, 14, 30, 00));
            apt8.Description = CarDescription.Rent;
            apt8.Label = CarLabel.Business;
            apt8.Location = CarLocation.City;
            apt8.CarId = CarBrand.MercedesBenz;
            apt8.Status = CarStatus.OutOfOffice;
            apt8.Subject = "Mr.Brown";
            apt8.Price = 8;
            apts.Add(apt8);

            CarScheduling apt9 = new CarScheduling();
            apt9.EventType = (int)AppointmentType.Normal;
            apt9.StartTime = startDate.Add(new TimeSpan(2, 10, 00, 00));
            apt9.EndTime = startDate.Add(new TimeSpan(4, 17, 00, 00));
            apt9.Description = CarDescription.Rent;
            apt9.Label = CarLabel.Personal;
            apt9.Location = CarLocation.City;
            apt9.CarId = CarBrand.MercedesBenz;
            apt9.Status = CarStatus.OutOfOffice;
            apt9.Subject = "Mr.White";
            apt9.Price = 10;
            apts.Add(apt9);

            CarScheduling apt10 = new CarScheduling();
            apt10.EventType = (int)AppointmentType.Normal;
            apt10.StartTime = startDate.Add(new TimeSpan(4, 19, 45, 00));
            apt10.EndTime = startDate.Add(new TimeSpan(4, 22, 45, 00));
            apt10.Description = CarDescription.CheckUp;
            apt10.Label = CarLabel.MustAttend;
            apt10.Location = CarLocation.ServiceCenter;
            apt10.CarId = CarBrand.MercedesBenz;
            apt10.Status = CarStatus.WorkingElsewhere;
            apt10.Subject = "Check up";
            apt10.Price = 45;
            apts.Add(apt10);

            CarScheduling apt11 = new CarScheduling();
            apt11.EventType = (int)AppointmentType.Pattern;
            apt11.StartTime = startDate.Add(new TimeSpan(-6, 16, 40, 00));
            apt11.EndTime = startDate.Add(new TimeSpan(-6, 17, 50, 00));
            apt11.Description = CarDescription.Wash;
            apt11.Label = CarLabel.Important;
            apt11.Location = CarLocation.Garage;
            apt11.CarId = CarBrand.MercedesBenz;
            apt11.Status = CarStatus.Tentative;
            apt11.Subject = "Wash";
            apt11.Price = 7;

            RecurrenceInfo recInfo1 = new RecurrenceInfo();
            recInfo1.Start = startDate.Add(new TimeSpan(-6, 16, 30, 00));
            recInfo1.End = startDate.Add(new TimeSpan(21, 00, 00, 00));
            recInfo1.WeekOfMonth = WeekOfMonth.None;
            recInfo1.Type = RecurrenceType.Weekly;
            recInfo1.WeekDays = WeekDays.WorkDays;
            recInfo1.Month = 12;
            recInfo1.OccurrenceCount = 1;
            recInfo1.Range = RecurrenceRange.EndByDate;
            apt11.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, reccurenceFormat, recInfo1.Start, recInfo1.End, (int)recInfo1.WeekOfMonth, (int)recInfo1.WeekDays, recInfo1.Month, recInfo1.OccurrenceCount, (int)recInfo1.Range, (int)recInfo1.Type, recInfo1.Id.ToString());

            apts.Add(apt11);

            CarScheduling apt12 = new CarScheduling();
            apt12.EventType = (int)AppointmentType.ChangedOccurrence;
            apt12.StartTime = startDate.Add(new TimeSpan(2, 18, 30, 00));
            apt12.EndTime = startDate.Add(new TimeSpan(2, 20, 00, 00));
            apt12.Description = CarDescription.Wash;
            apt12.Label = CarLabel.Important;
            apt12.Location = CarLocation.Garage;
            apt12.CarId = CarBrand.MercedesBenz;
            apt12.Status = CarStatus.Tentative;
            apt12.Subject = "Wash";
            apt12.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 6);
            apt12.Price = 5;
            apts.Add(apt12);

            CarScheduling apt13 = new CarScheduling();
            apt13.EventType = (int)AppointmentType.DeletedOccurrence;
            apt13.StartTime = startDate.Add(new TimeSpan(5, 16, 20, 00));
            apt13.EndTime = startDate.Add(new TimeSpan(5, 17, 40, 00));
            apt13.Description = CarDescription.Wash;
            apt13.Label = CarLabel.Important;
            apt13.Location = CarLocation.Garage;
            apt13.CarId = CarBrand.MercedesBenz;
            apt13.Status = CarStatus.Tentative;
            apt13.Subject = "Wash";
            apt13.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 7);
            apt13.Price = 5;
            apts.Add(apt13);

            CarScheduling apt14 = new CarScheduling();
            apt14.EventType = (int)AppointmentType.ChangedOccurrence;
            apt14.StartTime = startDate.Add(new TimeSpan(9, 15, 00, 00));
            apt14.EndTime = startDate.Add(new TimeSpan(9, 16, 30, 00));
            apt14.Description = CarDescription.Wash;
            apt14.Label = CarLabel.Important;
            apt14.Location = CarLocation.Garage;
            apt14.CarId = CarBrand.MercedesBenz;
            apt14.Status = CarStatus.Tentative;
            apt14.Subject = "Wash";
            apt14.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 11);
            apt14.Price = 5;
            apts.Add(apt14);

            CarScheduling apt15 = new CarScheduling();
            apt15.EventType = (int)AppointmentType.ChangedOccurrence;
            apt15.StartTime = startDate.Add(new TimeSpan(13, 16, 30, 00));
            apt15.EndTime = startDate.Add(new TimeSpan(13, 17, 00, 00));
            apt15.Description = CarDescription.Wash;
            apt15.Label = CarLabel.Important;
            apt15.Location = CarLocation.Garage;
            apt15.CarId = CarBrand.MercedesBenz;
            apt15.Status = CarStatus.Tentative;
            apt15.Subject = "Wash";
            apt15.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 13);
            apt15.Price = 5;
            apts.Add(apt15);

            CarScheduling apt16 = new CarScheduling();
            apt16.EventType = (int)AppointmentType.DeletedOccurrence;
            apt16.StartTime = startDate.Add(new TimeSpan(2, 16, 25, 00));
            apt16.EndTime = startDate.Add(new TimeSpan(2, 17, 45, 00));
            apt16.Description = CarDescription.Wash;
            apt16.Label = CarLabel.Important;
            apt16.Location = CarLocation.Garage;
            apt16.CarId = CarBrand.MercedesBenz;
            apt16.Status = CarStatus.Tentative;
            apt16.Subject = "Wash";
            apt16.RecurrenceInfo = String.Format(CultureInfo.InvariantCulture, changedOccurrenceFormat, recInfo1.Id.ToString(), 4);
            apt16.Price = 6;
            apts.Add(apt16);
            #endregion
            return apts;
        }

        public static DateTime GetStartDate() {
            DateTime date = TutorialConstants.Today;
            while (date.DayOfWeek != DayOfWeek.Wednesday) {
                date = date.AddDays(1);
            }
            return date;
        }
    }
}
