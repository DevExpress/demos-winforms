Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.ComponentModel
Imports DevExpress.VideoRent.Helpers
Imports System.Drawing
Imports DevExpress.Xpo.Metadata
Imports System.IO

Namespace DevExpress.VideoRent
	Public Class InitialRecords
		Public Shared Sub CheckForInitialRecords(ByVal session As Session)
			Using saver As New UnitOfWork(session.DataLayer)
				CheckForDefaultAdministrator(saver)
				CheckForDefaultCategories(saver)
				CheckForCompanyTypes(saver)
				CheckForDirectorLine(saver)
				CheckForMovieLanguages(saver)
				saver.CommitChanges()
			End Using
		End Sub
		Private Shared Sub CheckForDefaultAdministrator(ByVal session As Session)
			If ((Not Object.Equals(session.FindObject(Of Employee)(CriteriaOperator.Parse("Role = ?", EmployeeRole.Administrator)), Nothing))) Then
				Return
			End If
			CType(New Employee(session, ReferenceData.AdministratorString, String.Empty), Employee).Role = EmployeeRole.Administrator
		End Sub
        Private Shared Sub CheckForDefaultCategories(ByVal session As Session)
            If (Not (Object.Equals(session.FindObject(Of MovieCategory)(Nothing), Nothing))) Then
                Return
            End If
            Dim category As New MovieCategory(session, "General")
            category.IsDefault = True
        End Sub
		Private Shared Sub CheckForDirectorLine(ByVal session As Session)
			If (Not Object.Equals(MovieArtistLine.GetDirector(session), Nothing)) Then
				Return
			End If
			Dim TempMovieArtistLine As MovieArtistLine = New MovieArtistLine(session, ReferenceData.DirectorString)
		End Sub
		Private Shared Sub CheckForCompanyTypes(ByVal session As Session)
			If ((Not Object.Equals(session.FindObject(Of CompanyType)(Nothing), Nothing))) Then
				Return
			End If
			For Each name As String In ReferenceData.CompanyTypes
				Dim TempCompanyType As CompanyType = New CompanyType(session, name)
			Next name
		End Sub
		Private Shared Sub CheckForMovieLanguages(ByVal session As Session)
			If ((Not Object.Equals(session.FindObject(Of Language)(Nothing), Nothing))) Then
				Return
			End If
			For Each name As String In ReferenceData.MovieLanguages
				Dim TempLanguage As Language = New Language(session, name)
			Next name
		End Sub
	End Class
	Public Class VideoRentCurrentUser
		'[ThreadStatic] TODO uncommment for web
        Private Shared currentUserOid As Guid ' = Guid.Empty
        Public Shared Function Login(ByVal session As Session, ByVal flogin As String) As Boolean
            Return VideoRentCurrentUser.Login(session, flogin, String.Empty)
        End Function
        Public Shared Function Login(ByVal session As Session, ByVal flogin As String, ByVal password As String) As Boolean
            InitialRecords.CheckForInitialRecords(session)
            Dim administrator As Employee = session.FindObject(Of Employee)(CriteriaOperator.Parse("Login = ? And Password = ?", flogin, MD5StringEncoder.CalcHash(password)))
            If Object.Equals(administrator, Nothing) Then
                Return False
            End If
            currentUserOid = administrator.Oid
            Return True
        End Function
        Public Shared Function GetCurrentUser(ByVal session As Session) As Employee
            If Object.Equals(currentUserOid, Guid.Empty) Then
                Return Nothing
            Else
                Return session.GetObjectByKey(Of Employee)(currentUserOid)
            End If
        End Function
    End Class
    Public Class MemoryStreamValueConverter
        Inherits ValueConverter
        Public Overrides Function ConvertFromStorageType(ByVal val As Object) As Object
            Try
                If TypeOf val Is Byte() Then
                    Dim stream As MemoryStream = New System.IO.MemoryStream(TryCast(val, Byte()))
                    Dim formatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                    Return formatter.Deserialize(stream)
                End If
            Catch
            End Try
            Return Nothing
        End Function
        Public Overrides Function ConvertToStorageType(ByVal val As Object) As Object
            Try
                If Object.Equals(val, Nothing) Then
                    Return Nothing
                End If
                Dim stream As New MemoryStream()
                Dim formatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                formatter.Serialize(stream, val)
                Return stream.GetBuffer()
            Catch
            End Try
            Return Nothing
        End Function
        Public Overrides ReadOnly Property StorageType() As Type
            Get
                Return GetType(Byte())
            End Get
        End Property
    End Class
    Public Class RectangleValueConverter
        Inherits ValueConverter
        Public Overrides ReadOnly Property StorageType() As Type
            Get
                Return GetType(String)
            End Get
        End Property
        Public Overrides Function ConvertToStorageType(ByVal val As Object) As Object
            If Not (TypeOf val Is Rectangle) Then
                Return Nothing
            End If
            Dim rect As Rectangle = CType(val, Rectangle)
            Return String.Format("{0}@{1}@{2}@{3}", rect.X, rect.Y, rect.Width, rect.Height)
        End Function
        Public Overrides Function ConvertFromStorageType(ByVal val As Object) As Object
            Dim data() As String = String.Format("{0}", val).Split("@"c)
            If data.Length < 2 Then
                Return Nothing
            End If
            Return New Rectangle(Convert.ToInt32(data(0)), Convert.ToInt32(data(1)), Convert.ToInt32(data(2)), Convert.ToInt32(data(3)))
        End Function
    End Class
    Public Class VideoRentBaseObject
        Inherits XPBaseObject
        <Persistent("Oid"), Key(False)> _
        Private foid As Guid ' = Guid.Empty
        Private fcreatedBy As Employee
        Private fcreatedAt As DateTime
        Private ftag As String
        Public Event Saved As EventHandler

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            Me.foid = Guid.NewGuid()
            CreatedBy = VideoRentCurrentUser.GetCurrentUser(Session)
            CreatedAt = DevExpress.VideoRent.Helpers.VideoRentDateTime.Now
        End Sub
        Protected Overrides Sub OnSaving()
            MyBase.OnSaving()
            If Session.IsNewObject(Me) Then
                If SelfId >= 0 Then
                    SelfId = DevExpress.VideoRent.Helpers.IDGenerator.GenerateId(Session, GeneratedIdType, SelfId)
                End If
                CreatedBy = VideoRentCurrentUser.GetCurrentUser(Session)
                CreatedAt = DevExpress.VideoRent.Helpers.VideoRentDateTime.Now
            End If
            If (Not Object.Equals(SavedEvent, Nothing)) Then
                RaiseEvent Saved(Me, New EventArgs())
            End If
        End Sub
        Protected Overrides Function CreateCollection(Of T)(ByVal pr As XPMemberInfo) As XPCollection(Of T)
            Dim collection As XPCollection(Of T) = MyBase.CreateCollection(Of T)(pr)
            If pr.IsAggregated Then
                collection.DeleteObjectOnRemove = True
            End If
            Return collection
        End Function
        <PersistentAlias("foid"), Browsable(False)> _
        Public ReadOnly Property Oid() As Guid
            Get
                Return foid
            End Get
        End Property
        Public Property CreatedBy() As Employee
            Get
                Return fcreatedBy
            End Get
            Set(ByVal value As Employee)
                SetPropertyValue(Of Employee)("CreatedBy", fcreatedBy, value)
            End Set
        End Property
        Public Property CreatedAt() As DateTime
            Get
                Return fcreatedAt
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("CreatedAt", fcreatedAt, value)
            End Set
        End Property
        <Size(SizeAttribute.Unlimited)> _
        Public Property Tag() As String
            Get
                Return ftag
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Tag", ftag, value)
            End Set
        End Property
        <NonPersistent()> _
        Protected Property SelfId() As Integer
            Get
                If String.IsNullOrEmpty(GeneratedIdType) Then
                    Return -1
                End If
                Return GetPropertyValue(Of Integer)(String.Format("{0}Id", GeneratedIdType))
            End Get
            Set(ByVal value As Integer)
                If String.IsNullOrEmpty(GeneratedIdType) Then
                    Return
                End If
                SetPropertyValue(Of Integer)(String.Format("{0}Id", GeneratedIdType), value)
            End Set
        End Property
        Protected Overridable ReadOnly Property GeneratedIdType() As String
            Get
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property AllowDelete() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
    Public Class Person
        Inherits VideoRentBaseObject
        Private ffirstName, flastName As String
        Private fgender As PersonGender
        Private fbirthDate As Nullable(Of DateTime)

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Property FirstName() As String
            Get
                Return ffirstName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("FirstName", ffirstName, value)
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return flastName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("LastName", flastName, value)
            End Set
        End Property
        Public Property Gender() As PersonGender
            Get
                Return fgender
            End Get
            Set(ByVal value As PersonGender)
                SetPropertyValue(Of PersonGender)("Gender", fgender, value)
            End Set
        End Property
        Public Property BirthDate() As Nullable(Of DateTime)
            Get
                Return fbirthDate
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                SetPropertyValue(Of Nullable(Of DateTime))("BirthDate", fbirthDate, value)
            End Set
        End Property
        Public Overridable ReadOnly Property FullName() As String
            Get
                Dim ret As String
                If Object.Equals(FirstName, Nothing) Then
                    ret = String.Empty
                Else
                    ret = FirstName.Trim()
                End If
                Dim lastNameTrim As String
                If Object.Equals(LastName, Nothing) Then
                    lastNameTrim = String.Empty
                Else
                    lastNameTrim = LastName.Trim()
                End If
                If lastNameTrim.Length <> 0 Then
                    If ret.Length = 0 Then
                        ret &= (String.Empty) & lastNameTrim
                    Else
                        ret &= (" ") & lastNameTrim
                    End If
                End If
                Return ret
            End Get
        End Property
    End Class
    Public Class Employee
        Inherits Person
        Private frole As EmployeeRole
        Private flogin As String
        Private fpasswordHash As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal selfId As Integer)
            Me.New(session)
            Me.SelfId = selfId
        End Sub
        Public Sub New(ByVal session As Session, ByVal login As String, ByVal password As String)
            Me.New(session)
            Me.Login = login
            Me.Password = password
        End Sub
        Public Sub New(ByVal session As Session, ByVal login As String, ByVal password As String, ByVal firstName As String, ByVal lastName As String)
            Me.New(session, login, password)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
        <Persistent(), Indexed(Unique:=True)> _
        Public Property EmployeeId() As Integer
            Get
                Return GetPropertyValue(Of Integer)("EmployeeId")
            End Get
            Protected Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("EmployeeId", value)
            End Set
        End Property
        Protected Overrides ReadOnly Property GeneratedIdType() As String
            Get
                Return "Employee"
            End Get
        End Property
        Public Property Role() As EmployeeRole
            Get
                Return frole
            End Get
            Set(ByVal value As EmployeeRole)
                SetPropertyValue(Of EmployeeRole)("Role", frole, value)
            End Set
        End Property
        Public Property Login() As String
            Get
                Return flogin
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Login", flogin, value)
            End Set
        End Property
        <Persistent()> _
        Protected Property PasswordHash() As String
            Get
                Return fpasswordHash
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PasswordHash", fpasswordHash, value)
            End Set
        End Property
        <NonPersistent()> _
        Public Property Password() As String
            Get
                Return PasswordHash
            End Get
            Set(ByVal value As String)
                PasswordHash = MD5StringEncoder.CalcHash(value)
            End Set
        End Property
    End Class
End Namespace
