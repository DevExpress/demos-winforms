Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
#If Not NET
Imports System.Data.Entity
Imports System.Data.SQLite

#Else
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
#End If
Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class EntityBoundModeModule
        Inherits TutorialControl

        Private dataContext As DoctorScheduleContext

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = DoctorScheduleDataHelper.BaseDate
#If Not NET
            Database.SetInitializer(Of DoctorScheduleContext)(Nothing)
#End If
            dataContext = New DoctorScheduleContext()
            DoctorScheduleDataHelper.InitIfRequired(dataContext)
            InitializeMappings(schedulerStorage1)
            DoctorScheduleDataHelper.CustomizeLabelsAndStatuses(schedulerStorage1)
            dataContext.Doctors.Load()
            dataContext.DoctorAppointments.Load()
            schedulerStorage1.Resources.DataSource = dataContext.Doctors.Local.ToBindingList()
            schedulerStorage1.Appointments.DataSource = dataContext.DoctorAppointments.Local.ToBindingList()
            AddHandler schedulerStorage1.AppointmentsChanged, AddressOf schedulerStorage1_AppointmentsChanged
            AddHandler schedulerStorage1.AppointmentsInserted, AddressOf schedulerStorage1_AppointmentsChanged
            AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsChanged
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            dataContext.SaveChanges()
        End Sub

        Private Sub InitializeMappings(ByVal schedulerStorage As SchedulerStorage)
            Dim appointmentMapping As AppointmentMappingInfo = schedulerStorage.Appointments.Mappings
            appointmentMapping.AllDay = "AllDay"
            appointmentMapping.Description = "Note"
            appointmentMapping.Subject = "PatientName"
            appointmentMapping.Start = "StartDate"
            appointmentMapping.End = "EndDate"
            appointmentMapping.Label = "IssueId"
            appointmentMapping.Location = "Location"
            appointmentMapping.RecurrenceInfo = "RecurrenceInfo"
            appointmentMapping.ReminderInfo = "ReminderInfo"
            appointmentMapping.ResourceId = "DoctorId"
            appointmentMapping.Status = "PaymentStatusId"
            appointmentMapping.Type = "EventType"
            Dim resourceMapping As ResourceMappingInfo = schedulerStorage.Resources.Mappings
            resourceMapping.Id = "Id"
            resourceMapping.Caption = "Name"
        End Sub
    End Class

#Region "Data model"
    Public Class DoctorAppointment

        <Key>
        Public Property Id As Long

        Public Property AllDay As Boolean

        Public Property StartDate As Date

        Public Property EndDate As Date

        Public Property PatientName As String

        Public Property Note As String

        Public Property PaymentStatusId As Integer

        Public Property IssueId As Integer

        Public Property EventType As Integer

        Public Property Location As String

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property DoctorId As Long?
    End Class

    Public Class Doctor

        <Key>
        Public Property Id As Long

        Public Property Name As String
    End Class

    Public Class DoctorScheduleContext
        Inherits DbContext

#If Not NET
        Public Sub New()
            MyBase.New("name=DevExpress.XtraScheduler.Demos.Properties.Settings.DoctorConnectionString")
        End Sub

#Else
        public DoctorScheduleContext() : base(GetOptions()) {
        }

        private static DbContextOptions GetOptions() {
            var context = new DbContextOptionsBuilder<DoctorScheduleContext>();
            context.UseSqlite("Data Source = Doctors.sqlite");
            return context.Options;
        }
#End If
        Public Property DoctorAppointments As DbSet(Of DoctorAppointment)

        Public Property Doctors As DbSet(Of Doctor)
    End Class

#End Region
#Region "DoctorScheduleDataHelper"
    Public Class DoctorScheduleDataHelper

#Region "Table Creation Script"
        Public Const TableCreationScript As String = "
-- Table: Doctors
CREATE TABLE Doctors ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT
);

-- Table: DoctorAppointments
CREATE TABLE DoctorAppointments ( 
    Id             INTEGER  PRIMARY KEY AUTOINCREMENT
                            UNIQUE,
    AllDay          BOOLEAN,
    StartDate           DATETIME,
    EndDate           DATETIME,
    PatientName     TEXT,
    Note            TEXT,
    IssueId         INTEGER,
    PaymentStatusId INTEGER,
    EventType       INTEGER,
    Location        TEXT,
    RecurrenceInfo  TEXT,
    ReminderInfo    TEXT,
    DoctorId        INT64 
);
"

#End Region
        Public Shared BaseDate As Date = TutorialConstants.Today.AddDays(-1)

        Public Shared IssueList As String() = {"Consultation", "Treatment", "X-Ray"}

        Public Shared IssueColorList As Color() = {DXColor.FromArgb(&H8D, &HE9, &HDF), DXColor.FromArgb(&HE0, &HCF, &HE9), DXColor.FromArgb(&HFF, &HC2, &HBE)}

        Public Shared PatientNames As String() = {"Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith", "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell", "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander", "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer", "Samantha Piper", "Maggie Boxter", "Terry Bradley", "Stu Pizaro", "Greta Sims", "Sandra Johnson", "Cindy Stanwick", "Marcus Orbison", "Sandy Bright", "Ken Samuelson", "Brett Wade", "Wally Hobbs", "Brad Jameson", "Karen Goodson", "Morgan Kennedy", "Violet Bailey", "John Heart", "Arthur Miller", "Robert Reagan", "Ed Holmes", "Sammy Hill", "Olivia Peyton", "Jim Packard", "Hannah Brookly", "Harv Mudd", "Todd Hoffman", "Kevin Carter", "Mary Stern", "Robin Cosworth", "Jenny Hobbs", "Dallas Lou"}

        Public Shared DoctorNames As String() = {"Isabella Carter", "Miguel Simmons", "Madeleine Russell", "Ariana Alexander"}

        Public Shared PaymentStatuses As String() = {"Paid", "Unpaid"}

        Public Shared PaymentColorStatuses As Color() = {Color.Green, Color.Red}

        Public Shared Sub InitIfRequired(ByVal dataContext As DoctorScheduleContext)
            Dim helper As DoctorScheduleDataHelper = New DoctorScheduleDataHelper(dataContext)
            helper.Create()
        End Sub

        Public Shared Sub CustomizeLabelsAndStatuses(ByVal storage As SchedulerStorage)
            Dim labels As AppointmentLabelCollection = storage.Appointments.Labels
            labels.Clear()
            Dim count As Integer = IssueList.Length
            For i As Integer = 0 To count - 1
                Dim label As IAppointmentLabel = labels.CreateNewLabel(IssueList(i))
                label.SetColor(IssueColorList(i))
                labels.Add(label)
            Next

            Dim statuses As AppointmentStatusCollection = storage.Appointments.Statuses
            statuses.Clear()
            count = PaymentStatuses.Length
            For i As Integer = 0 To count - 1
                Dim status As AppointmentStatus = statuses.CreateNewStatus(PaymentStatuses(i))
                status.Type = AppointmentStatusType.Custom
                status.SetBrush(New SolidBrush(PaymentColorStatuses(i)))
                statuses.Add(status)
            Next
        End Sub

        Private dataContext As DoctorScheduleContext

        Private isSaveRequired As Boolean = False

        Protected Sub New(ByVal dataContext As DoctorScheduleContext)
            Me.dataContext = dataContext
        End Sub

        Public Sub Create()
            CreateDBStructureIfRequired()
            dataContext.Doctors.Load()
            dataContext.DoctorAppointments.Load()
            If dataContext.Doctors.Count() <= 0 Then CreateDoctors()
            If dataContext.DoctorAppointments.Count() > 0 Then
                Dim appointment As DoctorAppointment = dataContext.DoctorAppointments.FirstOrDefault(Function(apt) apt.EndDate >= BaseDate)
                If appointment Is Nothing Then
                    dataContext.DoctorAppointments.Local.Clear()
                    dataContext.SaveChanges()
                End If
            End If

            If dataContext.DoctorAppointments.Count() <= 0 Then CreateSchedule()
            If Not isSaveRequired Then Return
            dataContext.SaveChanges()
            isSaveRequired = False
        End Sub

        Private Sub CreateDBStructureIfRequired()
#If Not NET
            Dim connection = TryCast(dataContext.Database.Connection, SQLiteConnection)
            connection.Open()
            Dim table = connection.GetSchema("Tables")
            If table.Rows.Count > 0 Then Return
            Dim command = New SQLiteCommand(TableCreationScript, connection)
#Else
            var connection = this.dataContext.Database.GetDbConnection() as SqliteConnection;
            if (connection == null)
                return;
            connection.Open();
            var cmd = new SqliteCommand($"SELECT * FROM sqlite_master WHERE name='Doctors'", connection);
            var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
            if(reader.HasRows)
                return;
            var command = new SqliteCommand(TableCreationScript, connection);
#End If
            command.ExecuteNonQuery()
        End Sub

        Private Sub CreateDoctors()
            Dim doctorCount As Integer = DoctorNames.Length
            Dim doctors = dataContext.Doctors
            For i As Integer = 0 To doctorCount - 1
#If Not NET
                Dim doctor As Doctor = dataContext.Doctors.Create()
#Else
                Doctor doctor = new Doctor();
#End If
                doctor.Name = DoctorNames(i)
                doctors.Add(doctor)
            Next

            isSaveRequired = True
        End Sub

        Private Sub CreateSchedule()
            Dim doctorAppointmentsCount As Integer = dataContext.DoctorAppointments.Count()
            If doctorAppointmentsCount > 0 Then Return
            Dim doctorsCount As Integer = DoctorNames.Length
            For doctorId As Integer = 1 To doctorsCount
                CreateDoctorSchedule(doctorId, BaseDate.AddHours(TutorialConstants.Random.Next(0, 2)))
            Next

            isSaveRequired = True
        End Sub

        Private Sub CreateDoctorSchedule(ByVal doctorId As Integer, ByVal startDate As Date)
            Dim start As Date = BaseDate
            While start < BaseDate.AddDays(28)
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(9, 11)))
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(12, 14)))
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(15, 18)))
                start += TimeSpan.FromDays(1)
            End While
        End Sub

        Private Sub CreateDoctorAppointment(ByVal doctorId As Integer, ByVal start As Date)
#If Not NET
            Dim doctorAppointment As DoctorAppointment = dataContext.DoctorAppointments.Create()
#Else
                DoctorAppointment doctorAppointment = new DoctorAppointment();
#End If
            doctorAppointment.StartDate = start
            doctorAppointment.EndDate = start.AddMinutes(TutorialConstants.Random.Next(2, 6) * 10)
            doctorAppointment.IssueId = TutorialConstants.Random.Next(0, 3)
            doctorAppointment.PaymentStatusId = TutorialConstants.Random.Next(0, 2)
            Dim patientNameCount As Integer = PatientNames.Length
            doctorAppointment.PatientName = PatientNames(TutorialConstants.Random.Next(0, patientNameCount - 1))
            doctorAppointment.DoctorId = doctorId
            dataContext.DoctorAppointments.Add(doctorAppointment)
        End Sub
    End Class
#End Region
End Namespace
