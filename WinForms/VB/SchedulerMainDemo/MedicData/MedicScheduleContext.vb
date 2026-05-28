Imports System.Linq
#If Not NET
Imports System.Data.Entity
Imports System.Data.SQLite

#Else
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
#End If
Namespace DevExpress.XtraScheduler.Demos

    Public Class MedicScheduleContext
        Inherits DbContext

#Region "tableCreationScript"
        Private _tableCreationScript As String = "
-- Table: Medics
CREATE TABLE Medics ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT,
    Phone TEXT,
    PhotoBytes BLOB,
    DepartmentId        INT64 
);

-- Table: HospitalDepartments
CREATE TABLE HospitalDepartments ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT
);

-- Table: Patients
CREATE TABLE Patients ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT,    
    Birthday DATE,
    Phone TEXT
);

-- Table: MedicalAppointments
CREATE TABLE MedicalAppointments ( 
    Id             INTEGER  PRIMARY KEY AUTOINCREMENT
                            UNIQUE,
    AllDay          BOOLEAN,
    StartTime           DATETIME,
    [EndTime]           DATETIME,
    PatientId       INT64,
    Note            TEXT,
    IssueId         INTEGER,
    PaymentStatusId INTEGER,
    EventType       INTEGER,
    Location        TEXT,
    RecurrenceInfo  TEXT,
    ReminderInfo    TEXT,
    MedicId        INT64 
);
"

#End Region
#If Not NET
        Public Sub New()
            MyBase.New("name=DevExpress.XtraScheduler.Demos.Properties.Settings.MedicConnectionString")
            CreateDBStructureIfRequired()
        End Sub

#Else
        public MedicScheduleContext() : base(GetOptions()) {
            CreateDBStructureIfRequired();
        }

        private static DbContextOptions GetOptions() {
            var context = new DbContextOptionsBuilder<MedicScheduleContext>();
            context.UseSqlite("Data Source = Medics.sqlite");
            return context.Options;
        }
#End If
        Public Property Medics As DbSet(Of Medic)

        Public Property MedicalAppointments As DbSet(Of MedicalAppointment)

        Public Property HospitalDepartments As DbSet(Of HospitalDepartment)

        Public Property Patients As DbSet(Of Patient)

        Private ReadOnly Property TableCreationScript As String
            Get
                Return String.Format(_tableCreationScript)
            End Get
        End Property

        Public Sub LoadData()
            LoadPatients()
            LoadHospitalDepartments()
            LoadMedics()
            LoadMedicalAppointments()
        End Sub

        Private Sub CreateDBStructureIfRequired()
#If Not NET
            Dim connection = TryCast(Database.Connection, SQLiteConnection)
            If connection Is Nothing Then Return
            connection.Open()
            Dim table = connection.GetSchema("Tables")
            If table.Rows.Count > 0 Then Return
            Dim command = New SQLiteCommand(TableCreationScript, connection)
#Else
            var connection = Database.GetDbConnection()  as SqliteConnection;
            if (connection == null)
                return;
            connection.Open();
            var cmd = new SqliteCommand($"SELECT * FROM sqlite_master WHERE name='Medics'", connection);
            var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
            if(reader.HasRows) 
                return;
            var command = new SqliteCommand(TableCreationScript, connection);
#End If
            command.ExecuteNonQuery()
        End Sub

        Private Sub LoadMedics()
            Medics.Load()
            If Medics.Count() > 0 Then Return
            Medics.AddRange(CreateMedics(HospitalDepartments.ToList()))
            SaveChanges()
        End Sub

        Private Sub LoadHospitalDepartments()
            HospitalDepartments.Load()
            If HospitalDepartments.Count() > 0 Then Return
            HospitalDepartments.AddRange(CreateHospitalDepartments())
            SaveChanges()
        End Sub

        Private Sub LoadPatients()
            Patients.Load()
            If Patients.Count() > 0 Then Return
            Patients.AddRange(CreatePatients())
            SaveChanges()
        End Sub

        Private Sub LoadMedicalAppointments()
            MedicalAppointments.Load()
            Dim medicalAppointmentsCount As Integer = MedicalAppointments.Count()
            If medicalAppointmentsCount > 0 Then
                Dim appointment As MedicalAppointment = MedicalAppointments.FirstOrDefault(Function(apt) apt.EndTime >= BaseDate)
                If appointment IsNot Nothing Then Return
                MedicalAppointments.Local.Clear()
                SaveChanges()
            End If

            MedicalAppointments.AddRange(CreateMedicalAppointments(Medics.ToList()))
            SaveChanges()
        End Sub
    End Class
End Namespace
