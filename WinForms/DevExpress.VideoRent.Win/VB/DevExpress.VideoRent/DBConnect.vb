Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.Xpo
Imports System.Data.SqlClient
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports System.Data
Imports System.Reflection
Imports DevExpress.VideoRent.Helpers
Imports System.ComponentModel
Imports DevExpress.Xpo.DB.Exceptions

Namespace DevExpress.VideoRent
	Public Structure SqlDbHandle
		Public Server As String
		Public DbName As String
		Public UseWinAuth As Boolean
		Public Login As String
		Public Password As String
		Public ReadOnly Property ConnectionString() As String
			Get
				Dim initalCatalog As String
				If String.IsNullOrEmpty(DbName) Then
					initalCatalog = "User Instance=False"
				Else
					initalCatalog = String.Format("initial catalog={0}", DbName)
				End If
				If UseWinAuth Then
					Return String.Format("data source={0};integrated security=SSPI;{1}", Server, initalCatalog)
				End If
				Return String.Format("data source={0};user id={1};password={2};{3}", Server, Login, Password, initalCatalog)
			End Get
		End Property
	End Structure
	Public Class SqlHelper
		Public Shared Function SqlDbExists(ByVal sqlDb As SqlDbHandle) As Boolean
			Dim commandText As String = "select * from master.dbo.sysdatabases where name='" & sqlDb.DbName & "'"
			sqlDb.DbName = "master"
			Dim ret As Boolean = False
			Using sqlConnection As New SqlConnection(sqlDb.ConnectionString)
				Try
					sqlConnection.Open()
					Using sqlCommand As New SqlCommand(commandText, sqlConnection)
						Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
						ret = reader.HasRows
						reader.Close()
					End Using
					sqlConnection.Close()
				Catch e1 As SqlException
					ret = False
				End Try
			End Using
			Return ret
		End Function
		Public Shared Sub DeleteSqlDb(ByVal sqlDb As SqlDbHandle)
			Dim dbName As String = sqlDb.DbName
			sqlDb.DbName = Nothing
			Dim sqlConnection As New SqlConnection(sqlDb.ConnectionString)
			sqlConnection.Open()
			CType(New SqlCommand("DROP DATABASE " & dbName, sqlConnection), SqlCommand).ExecuteNonQuery()
		End Sub
		Public Shared Function CanConnect(ByVal sqlDb As SqlDbHandle) As Boolean
            Dim fcanConnect As Boolean = False
            Dim dbName As String = sqlDb.DbName
            sqlDb.DbName = "master"
            Dim sqlConnection As New SqlConnection(sqlDb.ConnectionString)
            Try
                sqlConnection.Open()
                fcanConnect = True
                sqlConnection.Close()
            Catch
            End Try
            If (Not fcanConnect) Then
                Return False
            End If
            sqlDb.DbName = dbName
            If (Not SqlDbExists(sqlDb)) Then
                Return True
            End If
            fcanConnect = False
            sqlConnection = New SqlConnection(sqlDb.ConnectionString)
            Try
                sqlConnection.Open()
                fcanConnect = True
                sqlConnection.Close()
            Catch
            End Try
            Return fcanConnect
        End Function
    End Class
    Public Class IniFile
        Private data As New SortedDictionary(Of String, String)()
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub Load(ByVal path As String)
            Using sr As New StreamReader(path)
                Dim folder As String = "[]"
                Do While Not sr.EndOfStream
                    Dim s As String = sr.ReadLine().Trim()
                    If s.Length = 0 OrElse s.Chars(0) = ";"c Then
                        Continue Do
                    End If
                    If s.Chars(0) = "["c Then
                        folder = s
                        Continue Do
                    End If
                    Dim key, value As String
                    Dim delim As Integer = s.IndexOf("="c)
                    If delim < 0 Then
                        key = folder & s.Replace("[", String.Empty).Replace("]", String.Empty)
                        value = String.Empty
                    Else
                        key = folder & s.Remove(delim).TrimEnd().Replace("[", String.Empty).Replace("]", String.Empty)
                        value = s.Substring(delim + 1).TrimStart()
                    End If
                    If (Not data.ContainsKey(key)) Then
                        data.Add(key, value)
                    Else
                        data(key) = value
                    End If
                Loop
            End Using
        End Sub
        Public Sub Save(ByVal path As String)
            Using sw As New StreamWriter(path)
                Dim folder As String = "[]"
                For Each key As String In data.Keys
                    Dim delim As Integer = key.IndexOf("]"c)
                    Dim keyFolder As String = key.Remove(delim + 1)
                    Dim keyName As String = key.Substring(delim + 1)
                    If keyFolder <> folder Then
                        folder = keyFolder
                        sw.WriteLine(folder)
                    End If
                    sw.WriteLine(keyName & " = " & data(key))
                Next key
            End Using
        End Sub
        Public ReadOnly Property Keys() As ICollection(Of String)
            Get
                Return data.Keys
            End Get
        End Property
        Public Function ContainKey(ByVal key As String) As Boolean
            Return data.ContainsKey(key)
        End Function
        Public Sub Remove(ByVal key As String)
            data.Remove(key)
        End Sub
        Public Sub Add(Of T)(ByVal key As String, ByVal value As T)
            AddRawValue(key, AddQuotes(value.ToString()))
        End Sub
        Public Function [Get](Of T)(ByVal key As String) As T
            If GetType(T) Is GetType(String) Then
                Return CType(CObj(RemoveQuotes(GetRawValue(key))), T)
            End If
            If GetType(T).BaseType Is GetType([Enum]) Then
                Return CType(System.Enum.Parse(GetType(T), RemoveQuotes(GetRawValue(key))), T)
            End If
            Dim parseMethod As MethodInfo = GetType(T).GetMethod("Parse", BindingFlags.Public Or BindingFlags.Static, Nothing, New Type() {GetType(String)}, Nothing)
            If Object.Equals(parseMethod, Nothing) Then
                Throw New ArgumentException()
            End If
            Return CType(parseMethod.Invoke(Nothing, New Object() {RemoveQuotes(GetRawValue(key))}), T)
        End Function
        Public Sub [Set](Of T)(ByVal key As String, ByVal value As T)
            SetRawValue(key, AddQuotes(value.ToString()))
        End Sub
        Private Function GetRawValue(ByVal key As String) As String
            Return data(key)
        End Function
        Private Sub SetRawValue(ByVal key As String, ByVal value As String)
            data(key) = value
        End Sub
        Private Sub AddRawValue(ByVal key As String, ByVal value As String)
            key = key.Trim()
            value = value.Trim()
            Dim folderBegin As Integer = key.IndexOf("["c)
            Dim folderEnd As Integer = key.IndexOf("]"c)
            If folderBegin <> 0 OrElse folderEnd < 0 Then
                Throw New ArgumentException("key")
            End If
            data.Add(key, value)
        End Sub
        Private Shared Function AddQuotes(ByVal s As String) As String
            Return """" & s & """"
        End Function
        Private Shared Function RemoveQuotes(ByVal s As String) As String
            If String.IsNullOrEmpty(s) OrElse s.Chars(0) <> """"c Then
                Return s
            End If
            s = s.Substring(1)
            If s.Length <> 0 AndAlso s.Chars(s.Length - 1) = """"c Then
                s = s.Remove(s.Length - 1)
            End If
            Return s
        End Function
    End Class
    Public Enum DbFormat
        Mdb
        Sql
    End Enum
    Public Class DbConnectData
        Private Const DbFormatKey As String = "[]DbFormat"
        Private Const MdbPathKey As String = "[]MdbPath"
        Private Const SqlDbNameKey As String = "[]SqlDbName"
        Private Const ServerKey As String = "[]Server"
        Private Const UseWinAuthKey As String = "[]UseWinAuth"
        Private Const LoginKey As String = "[]Login"
        Private Const PasswordKey As String = "[]Password"
        Private Const GenerateRentsHistoryKey As String = "[]GenerateRentsHistory"
        Private fdbFormat As DbFormat
        Private fmdbPath As String
        Private fsqlDbHandle As SqlDbHandle
        Private fgenerateRentsHistory As Boolean

        Public Property DbFormat() As DbFormat
            Get
                Return fdbFormat
            End Get
            Set(ByVal value As DbFormat)
                fdbFormat = value
            End Set
        End Property
        Public Property MdbPath() As String
            Get
                Return fmdbPath
            End Get
            Set(ByVal value As String)
                fmdbPath = value
            End Set
        End Property
        Public Property SqlDbHandle() As SqlDbHandle
            Get
                Return fsqlDbHandle
            End Get
            Set(ByVal value As SqlDbHandle)
                fsqlDbHandle = value
            End Set
        End Property
        Public Property SqlDbName() As String
            Get
                Return fsqlDbHandle.DbName
            End Get
            Set(ByVal value As String)
                fsqlDbHandle.DbName = value
            End Set
        End Property
        Public Property Server() As String
            Get
                Return fsqlDbHandle.Server
            End Get
            Set(ByVal value As String)
                fsqlDbHandle.Server = value
            End Set
        End Property
        Public Property UseWinAuth() As Boolean
            Get
                Return fsqlDbHandle.UseWinAuth
            End Get
            Set(ByVal value As Boolean)
                fsqlDbHandle.UseWinAuth = value
            End Set
        End Property
        Public Property Login() As String
            Get
                Return fsqlDbHandle.Login
            End Get
            Set(ByVal value As String)
                fsqlDbHandle.Login = value
            End Set
        End Property
        Public Property Password() As String
            Get
                Return fsqlDbHandle.Password
            End Get
            Set(ByVal value As String)
                fsqlDbHandle.Password = value
            End Set
        End Property
        Public Property GenerateRentsHistory() As Boolean
            Get
                Return fgenerateRentsHistory
            End Get
            Set(ByVal value As Boolean)
                fgenerateRentsHistory = value
            End Set
        End Property
        Public Sub LoadIniFile(ByVal iniFile As IniFile)
            DbFormat = iniFile.Get(Of DbFormat)(DbFormatKey)
            MdbPath = iniFile.Get(Of String)(MdbPathKey)
            GenerateRentsHistory = iniFile.Get(Of Boolean)(GenerateRentsHistoryKey)
            SqlDbName = iniFile.Get(Of String)(SqlDbNameKey)
            Server = iniFile.Get(Of String)(ServerKey)
            UseWinAuth = iniFile.Get(Of Boolean)(UseWinAuthKey)
            Login = iniFile.Get(Of String)(LoginKey)
            Password = iniFile.Get(Of String)(PasswordKey)
        End Sub
        Public Sub SaveIniFile(ByVal iniFile As IniFile)
            iniFile.Set(Of String)(MdbPathKey, MdbPath)
            iniFile.Set(Of String)(SqlDbNameKey, SqlDbName)
            iniFile.Set(Of DbFormat)(DbFormatKey, DbFormat)
            iniFile.Set(Of String)(ServerKey, Server)
            iniFile.Set(Of Boolean)(GenerateRentsHistoryKey, GenerateRentsHistory)
            iniFile.Set(Of Boolean)(UseWinAuthKey, UseWinAuth)
            iniFile.Set(Of String)(LoginKey, Login)
            iniFile.Set(Of String)(PasswordKey, Password)
        End Sub
        Public Shared Function CheckDefaults(ByVal iniFile As IniFile) As Boolean
            Dim ret As Boolean = True
            If (Not iniFile.ContainKey(MdbPathKey)) Then
                iniFile.Add(Of String)(MdbPathKey, "VideoRent.mdb")
                ret = False
            End If
            If (Not iniFile.ContainKey(SqlDbNameKey)) Then
                iniFile.Add(Of String)(SqlDbNameKey, "VideoRent")
                ret = False
            End If
            If (Not iniFile.ContainKey(DbFormatKey)) Then
                iniFile.Add(Of DbFormat)(DbFormatKey, DbFormat.Mdb)
                ret = False
            End If
            If (Not iniFile.ContainKey(ServerKey)) Then
                iniFile.Add(Of String)(ServerKey, ".\SQLExpress")
                ret = False
            End If
            If (Not iniFile.ContainKey(GenerateRentsHistoryKey)) Then
                iniFile.Add(Of Boolean)(GenerateRentsHistoryKey, True)
                ret = False
            End If
            If (Not iniFile.ContainKey(UseWinAuthKey)) Then
                iniFile.Add(Of Boolean)(UseWinAuthKey, True)
                ret = False
            End If
            If (Not iniFile.ContainKey(LoginKey)) Then
                iniFile.Add(Of String)(LoginKey, "sa")
                ret = False
            End If
            If (Not iniFile.ContainKey(PasswordKey)) Then
                iniFile.Add(Of String)(PasswordKey, String.Empty)
                ret = False
            End If
            Return ret
        End Function
        Public Function GetSqlConnectionString() As String
            Return fsqlDbHandle.ConnectionString
        End Function
        Public Function GetMdbConnectionString() As String
            Return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID={0};Data Source={1};Mode=Share Deny None;", "Admin", MdbPath)
        End Function
    End Class
	Public Interface ICreateInitialDbDialog
		Sub Show(ByVal dbConnectData As DbConnectData)
		Sub ShowDialog()
		Sub Close()
		ReadOnly Property CreateDbWorker() As IBackgroundWorker
		ReadOnly Property GenerateRentsHistoryWorker() As IBackgroundWorker
		Event Start As EventHandler
		Sub BeginWork()
		Sub EndWork(ByVal complete As Boolean)
		Sub ShowUnableToOpenMessage(createNew As Boolean)
	End Interface
	Public Class InitialDbCreator
		Public Const HistoryDays As Integer = 550

		Private createInitialDbDialog As ICreateInitialDbDialog
		Private operationsInProgress As Boolean = False
		Private operationsComplete As Boolean = False
		Private session As UnitOfWork
		Private iniFile As IniFile
		Private dbConnectData As DbConnectData
		Private unableToCreateDb As Boolean = False
		Private exceptionProcesser As IExceptionProcesser

		Public Sub New(ByVal createInitialDbDialog As ICreateInitialDbDialog, ByVal exceptionProcesser As IExceptionProcesser)
			Me.createInitialDbDialog = createInitialDbDialog
			Me.exceptionProcesser = exceptionProcesser
		End Sub
		Public Function OpenDb(ByVal iniFile As IniFile) As Boolean
			Me.iniFile = iniFile
			dbConnectData = New DbConnectData()
            Dim createNew As Boolean = Not dbConnectData.CheckDefaults(iniFile)
            dbConnectData.LoadIniFile(iniFile)
			If (Not createNew) Then
				Dim session As UnitOfWork = OpenDb(False, False)
				If (Not Object.Equals(session, Nothing)) Then
					XpoDefault.Session = session
					Return True
				End If
			End If
			Return CreateInitialDb()
		End Function
		Private Function CreateInitialDb() As Boolean
			createInitialDbDialog.Show(dbConnectData)
			AddHandler createInitialDbDialog.Start, AddressOf CreateInitialDbDialog_Start
			AddHandler createInitialDbDialog.CreateDbWorker.DoWork, AddressOf CreateDbWorker_DoWork
			AddHandler createInitialDbDialog.CreateDbWorker.RunWorkerCompleted, AddressOf CreateDbWorker_RunWorkerCompleted
			AddHandler createInitialDbDialog.GenerateRentsHistoryWorker.RunWorkerCompleted, AddressOf GenerateRentsHistoryWorker_RunWorkerCompleted
			createInitialDbDialog.ShowDialog()
			If operationsComplete Then
				dbConnectData.SaveIniFile(iniFile)
			End If
			Return operationsComplete
		End Function
		Private Sub CreateInitialDbDialog_Start(ByVal sender As Object, ByVal e As EventArgs)
			If operationsInProgress Then
				Return
			End If
			BeginOperations()
			createInitialDbDialog.CreateDbWorker.RunWorkerAsync()
		End Sub
		Private Sub BeginOperations()
			createInitialDbDialog.BeginWork()
			unableToCreateDb = False
			operationsComplete = False
			operationsInProgress = True
		End Sub
		Private Sub EndOperations(ByVal complete As Boolean)
			operationsInProgress = False
			operationsComplete = complete
			createInitialDbDialog.EndWork(complete)
		End Sub
        Private Function TryOpenMdb(ByVal deleteExist As Boolean, ByVal tryCreateNew As Boolean, ByRef createNew As Boolean) As String
            Dim connectionString As String = Nothing
            createNew = False
            If File.Exists(dbConnectData.MdbPath) Then
                If deleteExist Then
                    File.Delete(dbConnectData.MdbPath)
                End If
                connectionString = dbConnectData.GetMdbConnectionString()
            Else
                If tryCreateNew Then
                    connectionString = dbConnectData.GetMdbConnectionString()
                    createNew = True
                End If
            End If
            Return connectionString
        End Function
        Private Function TryOpenSql(deleteExist As Boolean, tryCreateNew As Boolean, ByRef createNew As Boolean) As String
            Dim connectionString As String = Nothing
            createNew = False
            If SqlHelper.SqlDbExists(dbConnectData.SqlDbHandle) Then
                If deleteExist Then
                    SqlHelper.DeleteSqlDb(dbConnectData.SqlDbHandle)
                End If
                connectionString = dbConnectData.GetSqlConnectionString()
            Else
                If tryCreateNew Then
                    connectionString = dbConnectData.GetSqlConnectionString()
                    createNew = True
                End If
            End If
            Return connectionString
        End Function
        Private Function OpenDb(ByVal deleteExist As Boolean, ByVal tryCreateNew As Boolean) As UnitOfWork
            Dim session As UnitOfWork = Nothing
            Dim createNew As Boolean = False
            Try
                Dim connectionString As String = Nothing
                If dbConnectData.DbFormat = DbFormat.Mdb Then
                    connectionString = TryOpenMdb(deleteExist, tryCreateNew, createNew)
                Else
                    connectionString = TryOpenSql(deleteExist, tryCreateNew, createNew)
                End If
                If Object.Equals(connectionString, Nothing) Then
                    session = Nothing
                Else
                    XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema)
                    session = New UnitOfWork(XpoDefault.DataLayer)
                End If
            Catch e1 As UnableToOpenDatabaseException
            End Try
            If Object.Equals(session, Nothing) Then
                createInitialDbDialog.ShowUnableToOpenMessage(createNew)
            End If
            Return session
        End Function
        Private Sub CreateDbWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Dim xmlPath As String = ResourcesHelper.GetXmlDbFileFromResource()
            Dim xmlConnectionString As String = String.Format("XpoProvider=XmlDataSet;data source={0};read only = true", xmlPath)
            Using xmlSession As New UnitOfWork()
                xmlSession.ConnectionString = xmlConnectionString
                xmlSession.Connect()
                Dim dbSession As UnitOfWork = OpenDb(True, True)
                If Object.Equals(dbSession, Nothing) Then
                    unableToCreateDb = True
                Else
                    IDGenerator.DisableGeneration(dbSession)
                    SessionHelper.CopySession(xmlSession, dbSession, xmlSession.Dictionary.CollectClassInfos(System.Reflection.Assembly.GetAssembly(GetType(VideoRentBaseObject))), createInitialDbDialog.CreateDbWorker, 90)
                    SessionHelper.CommitInBackground(dbSession, exceptionProcesser, createInitialDbDialog.CreateDbWorker, 100)
                    IDGenerator.EnableGeneration()
                    CorrectCustomersBirthDate(dbSession)
                    XpoDefault.Session = dbSession
                End If
            End Using
            File.Delete(xmlPath)
        End Sub
        Private Sub CreateDbWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
            If unableToCreateDb Then
                EndOperations(False)
                Return
            End If
            If dbConnectData.GenerateRentsHistory Then
                session = New UnitOfWork(DevExpress.Xpo.Session.DefaultSession.DataLayer)
                Dim TempRentsHistory As RentsHistory = New RentsHistory(HistoryDays, session, createInitialDbDialog.GenerateRentsHistoryWorker, exceptionProcesser)
            Else
                EndOperations(True)
                createInitialDbDialog.Close()
            End If
        End Sub
        Private Sub GenerateRentsHistoryWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
            session.Dispose()
            EndOperations(True)
            createInitialDbDialog.Close()
        End Sub
        Private Sub CorrectCustomersBirthDate(ByVal session As UnitOfWork)
            For Each customer As Customer In New XPCollection(Of Customer)(session)
                If Object.Equals(customer.BirthDate, Nothing) Then
                    Continue For
                End If
                Dim age As Integer = 2000 - customer.BirthDate.Value.Year
                Dim month As Integer = customer.BirthDate.Value.Month
                Dim day As Integer = customer.BirthDate.Value.Day
                customer.BirthDate = New DateTime(DevExpress.VideoRent.Helpers.VideoRentDateTime.Now.Year - age, month, day)
            Next customer
            SessionHelper.CommitSession(session, exceptionProcesser)
        End Sub
    End Class
End Namespace
