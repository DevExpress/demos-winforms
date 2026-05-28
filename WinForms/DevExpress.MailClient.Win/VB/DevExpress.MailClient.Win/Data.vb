Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraExport
Imports System.Xml
Imports System.ServiceModel.Syndication
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.DevAV
Imports System.Data.Entity

Namespace DevExpress.MailClient.Win
    Public Class Message
        Implements INotifyPropertyChanged

        Private row As DataRow
        Private date_Field As Date
        Private read_Field, deleted_Field, hasAttachment As Boolean
        Private priority_Field As Integer = 1
        Private mailType_Field As MailType
        Private mailFolder_Field As Integer
        Private from_Field As String = String.Empty, subject_Field As String = String.Empty, text_Field As String = String.Empty, plainText_Field As String = String.Empty, email_Field As String = String.Empty

        Public Sub New()
            date_Field = Date.Now
        End Sub
        Public Sub New(ByVal row As DataRow)
            Me.row = row
            date_Field = Date.Now.AddDays(DirectCast(row("Day"), Integer)).AddSeconds(-(New Random()).Next(10000))
            email_Field = String.Format("{0}", row("From"))
            from_Field = DataHelper.GetNameByEmail(email_Field)
            subject_Field = String.Format("{0}", row("Subject"))
            read_Field = Delay > TimeSpan.FromHours(48)
            text_Field = String.Format("{0}", row("Text"))
            deleted_Field = False
            mailType_Field = DevExpress.MailClient.Win.MailType.Inbox
            mailFolder_Field = CInt(GetFolder(row))
            DataTweaking()
        End Sub
        Public ReadOnly Property FullName() As String
            Get
                If String.IsNullOrEmpty(email_Field) Then
                    Return from_Field
                End If
                Return String.Format("{0} ({1})", from_Field, email_Field)
            End Get
        End Property
        Public Property [Date]() As Date
            Get
                Return date_Field
            End Get
            Set(ByVal value As Date)
                date_Field = value
            End Set
        End Property
        Public Property [From]() As String
            Get
                Return from_Field
            End Get
            Set(ByVal value As String)
                from_Field = value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return email_Field
            End Get
            Set(ByVal value As String)
                email_Field = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return subject_Field
            End Get
            Set(ByVal value As String)
                subject_Field = value
            End Set
        End Property
        Public ReadOnly Property SubjectDisplayText() As String
            Get
                Return Subject
            End Get
        End Property
        Public ReadOnly Property Attachment() As Integer
            Get
                Return If(hasAttachment, 1, 0)
            End Get
        End Property
        Public ReadOnly Property Read() As Integer
            Get
                Return If(read_Field, 1, 0)
            End Get
        End Property
        Public Property Priority() As Integer
            Get
                Return priority_Field
            End Get
            Set(ByVal value As Integer)
                priority_Field = value
            End Set
        End Property
        Public ReadOnly Property IsUnread() As Boolean
            Get
                Return Not read_Field
            End Get
        End Property
        Friend ReadOnly Property Folder() As String
            Get
                Return String.Format("{0}", mailFolder_Field)
            End Get
        End Property
        Public Property Text() As String
            Get
                Return text_Field
            End Get
            Set(ByVal value As String)
                text_Field = value
            End Set
        End Property
        Public ReadOnly Property PlainText() As String
            Get
                Return GetPlainText()
            End Get
        End Property

        Private Function GetPlainText() As String
            If String.IsNullOrEmpty(plainText_Field) Then
                plainText_Field = ObjectHelper.GetPlainTextFromMHT(text_Field).Replace(ControlChars.CrLf, " ")
            End If
            Return plainText_Field
        End Function
        Public Property MailType() As MailType
            Get
                Return mailType_Field
            End Get
            Set(ByVal value As MailType)
                mailType_Field = value
            End Set
        End Property
        Public Property MailFolder() As Integer
            Get
                Return mailFolder_Field
            End Get
            Set(ByVal value As Integer)
                If MailFolder = value Then
                    Return
                End If
                mailFolder_Field = value
                OnPropertyChanged("MailFolder")
            End Set
        End Property
        Public Property Deleted() As Boolean
            Get
                Return deleted_Field
            End Get
            Set(ByVal value As Boolean)
                deleted_Field = value
            End Set
        End Property
        Friend ReadOnly Property Delay() As TimeSpan
            Get
                Return Date.Now.Subtract(date_Field)
            End Get
        End Property

        Public Sub ToggleRead()
            read_Field = Not read_Field
        End Sub
        Private Sub DataTweaking()
            If Delay > TimeSpan.FromHours(50) AndAlso Delay < TimeSpan.FromHours(100) Then
                read_Field = False
            End If
            If subject_Field.IndexOf("RE:") >= 0 OrElse subject_Field.IndexOf("FW:") >= 0 Then
                read_Field = False
            End If
            Me.hasAttachment = text_Field.Length > 20000
            If subject_Field.IndexOf("Review") >= 0 OrElse subject_Field.IndexOf("Important") >= 0 Then
                priority_Field = 2
            End If
            If subject_Field.IndexOf("FW:") >= 0 AndAlso Delay > TimeSpan.FromHours(48) Then
                priority_Field = 0
            End If
            If subject_Field.IndexOf("New") >= 0 OrElse subject_Field.IndexOf("Meeting") >= 0 Then
                mailFolder_Field += 1
            End If
        End Sub
        Private Function GetFolder(ByVal row As DataRow) As MailFolder
            Dim category As Object = row("CategoryID")
            Dim ret As String = String.Format("{0}", CType(If(category Is DBNull.Value, 1, DirectCast(category, Integer)), Categories))
            If String.IsNullOrEmpty(ret) Then
                Return DevExpress.MailClient.Win.MailFolder.All
            End If
            Return DirectCast(System.Enum.Parse(GetType(MailFolder), ret.Replace(" ", "")), MailFolder)
        End Function
        Public Sub SetPlainText(ByVal text As String)
            plainText_Field = text
        End Sub

#Region "INotifyPropertyChanged Members"
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Me.PropertyChangedEvent IsNot Nothing) Then
                RaiseEvent propertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
#End Region
    End Class
    Public Class Task
        Implements IDXDataErrorInfo

        Private priority_Field As Integer = 1
        Private percentComplete_Field As Integer = 0
        Private createdDate_Field As Date
        Private startDate_Field? As Date = Nothing, dueDate_Field? As Date = Nothing, completedDate_Field? As Date = Nothing
        Private subject_Field, description_Field As String
        Private status_Field As TaskStatus = TaskStatus.NotStarted
        Private category_Field As TaskCategory
        Private assignTo_Field As Contact = Nothing
        Public Sub New(ByVal subject As String, ByVal category As TaskCategory)
            Me.New(subject, category, Date.Now)
        End Sub
        Friend Sub New(ByVal subject As String, ByVal category As TaskCategory, ByVal [date] As Date)
            Me.subject_Field = subject
            Me.category_Field = category
            Me.createdDate_Field = [date]
        End Sub
        Public Property Priority() As Integer
            Get
                Return priority_Field
            End Get
            Set(ByVal value As Integer)
                priority_Field = value
            End Set
        End Property
        Public Property PercentComplete() As Integer
            Get
                Return percentComplete_Field
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    value = 0
                End If
                If value > 100 Then
                    value = 100
                End If
                If percentComplete_Field = value Then
                    Return
                End If
                percentComplete_Field = value
                If percentComplete_Field = 100 Then
                    Status = TaskStatus.Completed
                End If
                If percentComplete_Field > 0 AndAlso percentComplete_Field < 100 Then
                    Status = TaskStatus.InProgress
                End If
            End Set
        End Property
        Public ReadOnly Property CreatedDate() As Date
            Get
                Return createdDate_Field
            End Get
        End Property
        Public Property StartDate() As Date?
            Get
                Return startDate_Field
            End Get
            Set(ByVal value As Date?)
                startDate_Field = value
            End Set
        End Property
        Public Property DueDate() As Date?
            Get
                Return dueDate_Field
            End Get
            Set(ByVal value As Date?)
                dueDate_Field = value
            End Set
        End Property
        Public Property CompletedDate() As Date?
            Get
                Return completedDate_Field
            End Get
            Set(ByVal value As Date?)
                completedDate_Field = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return subject_Field
            End Get
            Set(ByVal value As String)
                subject_Field = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return description_Field
            End Get
            Set(ByVal value As String)
                description_Field = value
            End Set
        End Property
        Public Property Category() As TaskCategory
            Get
                Return category_Field
            End Get
            Set(ByVal value As TaskCategory)
                category_Field = value
            End Set
        End Property
        Public Property Status() As TaskStatus
            Get
                Return status_Field
            End Get
            Set(ByVal value As TaskStatus)
                status_Field = value
                If status_Field = TaskStatus.Completed Then
                    PercentComplete = 100
                    CompletedDate = Date.Now
                Else
                    CompletedDate = Nothing
                End If
                If status_Field = TaskStatus.NotStarted Then
                    PercentComplete = 0
                End If
                If status_Field = TaskStatus.InProgress AndAlso PercentComplete = 100 Then
                    PercentComplete = 75
                End If
                If status_Field = TaskStatus.Deferred OrElse status_Field = TaskStatus.WaitingOnSomeoneElse Then
                    DueDate = Nothing
                End If
            End Set
        End Property
        Public Property AssignTo() As Contact
            Get
                Return assignTo_Field
            End Get
            Set(ByVal value As Contact)
                assignTo_Field = value
            End Set
        End Property
        Friend ReadOnly Property TimeDiff() As TimeSpan
            Get
                Return (Date.Now.Subtract(CreatedDate))
            End Get
        End Property
        Public ReadOnly Property Overdue() As Boolean
            Get
                If Status = TaskStatus.Completed OrElse (Not DueDate.HasValue) Then
                    Return False
                End If
                Dim dDate As Date = DueDate.Value.Date.AddDays(1)
                If Date.Now >= dDate Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public Property Complete() As Boolean
            Get
                Return Status = TaskStatus.Completed
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    Status = TaskStatus.Completed
                Else
                    Status = TaskStatus.NotStarted
                End If
            End Set
        End Property
        Public ReadOnly Property Icon() As Integer
            Get
                Return If(Complete, 0, 1)
            End Get
        End Property
        Public ReadOnly Property FlagStatus() As FlagStatus
            Get
                Dim today As Date = Date.Today
                If Complete Then
                    Return FlagStatus.Completed
                End If
                If Not DueDate.HasValue Then
                    Return FlagStatus.NoDate
                End If
                If DueDate.Value.Date.Equals(today) Then
                    Return FlagStatus.Today
                End If
                If DueDate.Value.Date.Equals(today.AddDays(1)) Then
                    Return FlagStatus.Tomorrow
                End If
                Dim thisWeekStart As Date = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today)
                If DueDate.Value.Date >= thisWeekStart AndAlso DueDate.Value.Date < thisWeekStart.AddDays(7) Then
                    Return FlagStatus.ThisWeek
                End If
                If DueDate.Value.Date >= thisWeekStart.AddDays(7) AndAlso DueDate.Value.Date < thisWeekStart.AddDays(14) Then
                    Return FlagStatus.NextWeek
                End If
                Return FlagStatus.Custom
            End Get
        End Property
        Public Sub Assign(ByVal task As Task)
            Me.subject_Field = task.Subject
            Me.priority_Field = task.Priority
            Me.percentComplete_Field = task.PercentComplete
            Me.createdDate_Field = task.CreatedDate
            Me.startDate_Field = task.StartDate
            Me.dueDate_Field = task.DueDate
            Me.completedDate_Field = task.CompletedDate
            Me.description_Field = task.Description
            Me.category_Field = task.Category
            Me.status_Field = task.Status
            Me.assignTo_Field = task.AssignTo
        End Sub
        Public Function Clone() As Task
            Dim task As New Task(Me.Subject, Me.Category)
            task.Assign(Me)
            Return task
        End Function
        Public ReadOnly Property DueIn() As String
            Get
                If DueDate.HasValue Then
                    Dim oDays As Integer = (Date.Today - DueDate.Value).Days
                    Return If(oDays > 0, String.Format("{0} day{1} overdue", oDays, If(oDays > 1, "s", String.Empty)), String.Empty)
                End If
                Return String.Empty
            End Get
        End Property
#Region "IDXDataErrorInfo Members"
        Public Sub GetError(ByVal info As DevExpress.XtraEditors.DXErrorProvider.ErrorInfo) Implements IDXDataErrorInfo.GetError
        End Sub

        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As DevExpress.XtraEditors.DXErrorProvider.ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "DueDate" Then
                If (DueDate.HasValue AndAlso StartDate.HasValue) AndAlso DueDate < StartDate Then
                    SetErrorInfo(info, My.Resources.DueDateError, ErrorType.Critical)
                End If
                If (Not DueDate.HasValue) AndAlso Status = TaskStatus.InProgress Then
                    SetErrorInfo(info, My.Resources.DueDateWarning, ErrorType.Warning)
                End If
            End If
        End Sub
        Private Sub SetErrorInfo(ByVal info As DevExpress.XtraEditors.DXErrorProvider.ErrorInfo, ByVal errorText As String, ByVal errorType As ErrorType)
            info.ErrorText = errorText
            info.ErrorType = errorType
        End Sub
#End Region
    End Class
    Public Class Contact
        Implements IComparable

        Private photo_Field As Image
        Private name_Field As FullName
        Private email_Field, phone_Field, note_Field, fullname_Field As String
        Private birthDate_Field? As Date
        Private address_Field As Address
        Public Sub New()
            name_Field = New FullName(PersonPrefix.Mr, My.Resources.NewFirstName, String.Empty, My.Resources.NewLastName)
            address_Field = New Address()
        End Sub
        Public Sub New(ByVal contact As Contact)
            name_Field = New FullName()
            address_Field = New Address()
            Me.Assign(contact)
        End Sub
        Public Sub New(ByVal employee As Employee)
            photo_Field = employee.Photo
            name_Field = New FullName(employee.Prefix, employee.FirstName, String.Empty, employee.LastName)
            fullname_Field = employee.FullName
            email_Field = employee.Email
            birthDate_Field = employee.BirthDate
            phone_Field = employee.MobilePhone
            address_Field = New Address(employee.Address.ToString())
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return name_Field.ToString()
            End Get
        End Property
        Public ReadOnly Property EmployeeName() As String
            Get
                Return fullname_Field
            End Get
        End Property
        Public ReadOnly Property FirstName() As String
            Get
                Return name_Field.FirstName
            End Get
        End Property
        Public ReadOnly Property MiddleName() As String
            Get
                Return name_Field.MiddleName
            End Get
        End Property
        Public ReadOnly Property LastName() As String
            Get
                Return name_Field.LastName
            End Get
        End Property
        Public Property Email() As String
            Get
                Return email_Field
            End Get
            Set(ByVal value As String)
                email_Field = value
            End Set
        End Property
        Public ReadOnly Property BirthDate() As Date?
            Get
                Return birthDate_Field
            End Get
        End Property
        Private ReadOnly DefaultBirthDate As New Date(1970, 1, 1)
        Public Property BindingBirthDate() As Date
            Get
                If BirthDate.HasValue Then
                    Return BirthDate.Value
                End If
                Return DefaultBirthDate
            End Get
            Set(ByVal value As Date)
                birthDate_Field = value
            End Set
        End Property
        Public ReadOnly Property Title() As PersonPrefix
            Get
                Return name_Field.Title
            End Get
        End Property
        Public Property Phone() As String
            Get
                Return phone_Field
            End Get
            Set(ByVal value As String)
                phone_Field = value
            End Set
        End Property
        Public ReadOnly Property State() As String
            Get
                Return address_Field.State
            End Get
        End Property
        Public ReadOnly Property City() As String
            Get
                Return address_Field.City
            End Get
        End Property
        Public ReadOnly Property Zip() As String
            Get
                Return address_Field.Zip
            End Get
        End Property
        Public ReadOnly Property AddressLine() As String
            Get
                Return address_Field.AddressLine
            End Get
        End Property
        Public ReadOnly Property Address() As Address
            Get
                Return address_Field
            End Get
        End Property
        Public ReadOnly Property FullName() As FullName
            Get
                Return name_Field
            End Get
        End Property
        Public Property Photo() As Image
            Get
                Return photo_Field
            End Get
            Set(ByVal value As Image)
                photo_Field = value
            End Set
        End Property
        Public Property Note() As String
            Get
                Return note_Field
            End Get
            Set(ByVal value As String)
                note_Field = value
            End Set
        End Property
        Public Function GetContactInfoHtml() As String
            Dim ret As String = String.Format("<size=+2><b>{0}</b><size=-2>", Name)
            ret &= "<br>"
            If BirthDate IsNot Nothing AndAlso Not BirthDate.Equals(Date.MinValue) Then
                ret &= String.Format(My.Resources.BirthDateHtml, BirthDate)
            End If
            If Not String.IsNullOrEmpty(Email) Then
                ret &= String.Format(My.Resources.EmailHtml, Email)
            End If
            If Not String.IsNullOrEmpty(Phone) Then
                ret &= String.Format(My.Resources.PhoneHtml, Phone)
            End If
            ret &= String.Format(My.Resources.AddressHtml, Address)

            Return ret
        End Function
        Public Overrides Function ToString() As String
            Return Name
        End Function
        Public ReadOnly Property Icon() As Image
            Get
                Select Case name_Field.Title
                    Case PersonPrefix.Dr
                        Return My.Resources.Doctor
                    Case PersonPrefix.Miss
                        Return My.Resources.Miss
                    Case PersonPrefix.Mrs
                        Return My.Resources.Mrs
                    Case PersonPrefix.Ms
                        Return My.Resources.Ms
                End Select
                Return My.Resources.Mr
            End Get
        End Property
        Public Sub Assign(ByVal contact As Contact)
            Me.photo_Field = contact.Photo
            Me.name_Field.Assign(contact.FullName)
            Me.address_Field.Assign(contact.Address)
            Me.email_Field = contact.Email
            Me.birthDate_Field = contact.BirthDate
            Me.phone_Field = contact.Phone
            Me.note_Field = contact.Note
        End Sub
        Public Function Clone() As Contact
            Return New Contact(Me)
        End Function
#Region "IComparable Members"

        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return Comparer(Of String).Default.Compare(Name, obj.ToString())
        End Function

#End Region
    End Class

    Public Class UnknownContact
        Inherits Contact

        Public Sub New(ByVal email As String)
            Me.Email = email
        End Sub
        Public Overrides Function ToString() As String
            Return Email
        End Function
    End Class

    Public Class FullName
        Private title_Field As PersonPrefix
        Private first, middle, last As String
        Public Sub New()
            Me.New(PersonPrefix.Mr, String.Empty, String.Empty, String.Empty)
        End Sub
        Public Sub New(ByVal title As PersonPrefix, ByVal first As String, ByVal middle As String, ByVal last As String)
            Me.title_Field = title
            Me.first = first
            Me.middle = middle
            Me.last = last
        End Sub
        Public Property Title() As PersonPrefix
            Get
                Return title_Field
            End Get
            Set(ByVal value As PersonPrefix)
                title_Field = value
            End Set
        End Property
        Public Property FirstName() As String
            Get
                Return first
            End Get
            Set(ByVal value As String)
                first = value
            End Set
        End Property
        Public Property MiddleName() As String
            Get
                Return middle
            End Get
            Set(ByVal value As String)
                middle = value
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return last
            End Get
            Set(ByVal value As String)
                last = value
            End Set
        End Property
        Public Overrides Function ToString() As String
            Return String.Format("{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)), GetFormatString(FirstName), GetFormatString(MiddleName), LastName)
        End Function
        Private Function GetFormatString(ByVal name As String) As String
            If String.IsNullOrEmpty(name) Then
                Return String.Empty
            End If
            Return String.Format("{0} ", name)
        End Function
        Public Sub Assign(ByVal name As FullName)
            Me.title_Field = name.Title
            Me.first = name.FirstName
            Me.middle = name.MiddleName
            Me.last = name.LastName
        End Sub
    End Class
    Public Class Address
        Private address_Field As String, city_Field As String = String.Empty, state_Field As String = String.Empty, zip_Field As String
        Public Sub New()
            Me.New(String.Empty)
        End Sub
        Public Sub New(ByVal address As String, ByVal city As String, ByVal state As String, ByVal zip As String)
            Me.address_Field = address
            Me.city_Field = city
            Me.state_Field = state
            Me.zip_Field = zip
        End Sub
        Friend Sub New(ByVal addressString As String)
            If String.IsNullOrEmpty(addressString) Then
                Return
            End If
            Try
                Dim lines() As String = addressString.Split(","c)
                Me.address_Field = lines(0).Trim()
                Me.city_Field = lines(1).Trim()
                Me.state_Field = lines(2).Trim().Substring(0, 2)
                Dim temp As String = lines(2).Trim()
                Me.zip_Field = temp.Substring(3, temp.Length - 3)
            Catch
            End Try
        End Sub
        Public Property AddressLine() As String
            Get
                Return address_Field
            End Get
            Set(ByVal value As String)
                address_Field = value
            End Set
        End Property
        Public Property State() As String
            Get
                Return state_Field
            End Get
            Set(ByVal value As String)
                state_Field = value
            End Set
        End Property
        Public Property City() As String
            Get
                Return city_Field
            End Get
            Set(ByVal value As String)
                city_Field = value
            End Set
        End Property
        Public Property Zip() As String
            Get
                Return zip_Field
            End Get
            Set(ByVal value As String)
                zip_Field = value
            End Set
        End Property
        Public Overrides Function ToString() As String
            Return String.Format("{0}{1}{2}{3}", GetFormatString(AddressLine), GetFormatString(City), GetFormatString(State), Zip)
        End Function
        Private Function GetFormatString(ByVal name As String) As String
            If String.IsNullOrEmpty(name) Then
                Return String.Empty
            End If
            Return String.Format("{0}, ", name)
        End Function
        Public Sub Assign(ByVal address As Address)
            Me.address_Field = address.AddressLine
            Me.state_Field = address.State
            Me.city_Field = address.City
            Me.zip_Field = address.Zip
        End Sub
    End Class
    Public Class FeedItem
        Public Sub New()
        End Sub
        Public Property ID() As String
        Public Property [Date]() As Date
        Public Property [From]() As String
        Public Property Title() As String
        Public Property Description() As String
        Public Property Url() As String
    End Class
    Public Class DataHelper
        Friend Shared ShowAllMessageCount As Boolean = False
        Friend Shared ShowUnreadMessageCount As Boolean = True
        Private Shared messages_Field As List(Of Message) = Nothing
        Private Shared contacts_Field As List(Of Contact) = Nothing
        Private Shared tasks_Field As List(Of Task) = Nothing
        Private Shared employees_Field As BindingList(Of Employee) = Nothing
        Friend Shared CalendarDate As Date = Date.Today
        Friend Shared ApplicationArguments() As String

        Private Shared calendarResourcesTable As DataTable
        Private Shared calendarAppointmentsTable As DataTable

        Friend Shared ReadOnly Property MailTable() As DataTable
            Get
                Dim table As String = "Messages"
                Dim messages_Field As DataTable = CreateDataTable(table)
                Return messages_Field
            End Get
        End Property
        Friend Shared ReadOnly Property Employees() As BindingList(Of Employee)
            Get
                If employees_Field Is Nothing Then
                    Dim devAvDb As New DevAVDb()
                    devAvDb.Employees.Load()
                    employees_Field = devAvDb.Employees.Local.ToBindingList()
                End If
                Return employees_Field
            End Get
        End Property
        Public Shared Function GetNameByEmail(ByVal email As String) As String
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) p.Email = email)
            If employee Is Nothing Then
                Return String.Empty
            End If
            Return employee.FullName
        End Function
        Public Shared Function GetPhotoByEmail(ByVal email As String) As Image
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) p.Email = email)
            If employee Is Nothing OrElse employee.Picture Is Nothing Then
                Return Nothing
            End If
            Return employee.Photo
        End Function
        Public Shared ReadOnly Property Messages() As List(Of Message)
            Get
                Try
                    If messages_Field Is Nothing Then
                        messages_Field = New List(Of Message)()
                        Dim tbl As DataTable = MailTable
                        If tbl IsNot Nothing Then
                            For Each row As DataRow In tbl.Rows
                                messages_Field.Add(New Message(row))
                            Next row
                        End If
                        messages_Field.Add(CreateMessageAbout())
                    End If
                Catch e As Exception
                    XtraMessageBox.Show(e.Message, e.Source)
                    messages_Field = New List(Of Message)()
                    messages_Field.Add(CreateMessageAbout())
                End Try
                Return messages_Field
            End Get
        End Property
        Public Shared ReadOnly Property Contacts() As List(Of Contact)
            Get
                If contacts_Field Is Nothing Then
                    contacts_Field = GetContacts()
                End If
                Return contacts_Field
            End Get
        End Property
        Public Shared ReadOnly Property Tasks() As List(Of Task)
            Get
                If tasks_Field Is Nothing Then
                    tasks_Field = GenerateTasks()
                End If
                Return tasks_Field
            End Get
        End Property
        Private Shared Function GenerateTasks() As List(Of Task)
            Dim ret As New List(Of Task)()
            For i As Integer = 0 To TaskGenerator.CustomerCount - 1
                For Each s As String In CollectionResources.OfficeTasks
                    ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Office))
                Next s
            Next i
            For Each s As String In CollectionResources.HouseTasks
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.HouseChores))
            Next s
            For Each s As String In CollectionResources.ShoppingTasks
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Shopping))
            Next s
            Return ret
        End Function
        Friend Shared Function GetContacts() As List(Of Contact)
            Dim ret As New List(Of Contact)()
            For Each emp As Employee In Employees
                ret.Add(New Contact(emp))
            Next emp
            Return ret
        End Function
        Friend Shared Function FindByName(ByVal name As String) As Contact
            If String.IsNullOrEmpty(name) Then
                Return Nothing
            End If
            Return Contacts.FirstOrDefault(Function(p) p.Name = name OrElse p.EmployeeName = name)
        End Function
        Private Shared Function CreateMessageAbout() As Message
            Dim ret As New Message()
            ret.Subject = My.Resources.AboutSubj
            ret.From = My.Resources.AboutFrom
            ret.Priority = 2
            ret.Text = ObjectHelper.GetMHTTextFromHTML(StringResources.Get("AboutMessage"))
            ret.SetPlainText(StringResources.Get("AboutMessagePlain"))
            ret.MailFolder = CInt(MailFolder.Announcements)
            Return ret
        End Function

        Friend Shared ReadOnly Property CalendarResources() As DataTable
            Get
                If calendarResourcesTable Is Nothing Then
                    Dim table As String = "Resources"
                    calendarResourcesTable = CreateDataTable(table)
                End If
                Return calendarResourcesTable
            End Get
        End Property
        Friend Shared ReadOnly Property CalendarAppointments() As DataTable
            Get
                If calendarAppointmentsTable Is Nothing Then
                    Dim table As String = "Appointments"
                    calendarAppointmentsTable = CreateDataTable(table)
                End If
                Return calendarAppointmentsTable
            End Get
        End Property

        Private Shared Function CreateDataTable(ByVal table As String) As DataTable
            Dim dataSet As New DataSet()
            Dim dataFile As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\MailDevAv.xml")
            If dataFile <> String.Empty Then
                Dim fi As New FileInfo(dataFile)
                dataSet.ReadXml(fi.FullName)
                Return dataSet.Tables(table)
            End If
            Return Nothing
        End Function
    End Class
    Friend Class TaskGenerator
        Public Shared CustomerCount As Integer = 10
        Private Shared rndGenerator As New Random()
        Private Shared customers_Field As List(Of Contact)
        Friend Shared ReadOnly Property Customers() As List(Of Contact)
            Get
                If customers_Field Is Nothing Then
                    customers_Field = New List(Of Contact)()
                    Dim temp As List(Of Contact) = DataHelper.GetContacts()
                    If temp.Count > CustomerCount Then
                        Do While customers_Field.Count < CustomerCount
                            Dim contact As Contact = GetCustomer(rndGenerator.Next(temp.Count - 1), customers_Field, temp)
                            If contact IsNot Nothing Then
                                customers_Field.Add(contact)
                            End If
                        Loop
                    End If
                End If
                Return customers_Field
            End Get
        End Property
        Private Shared Function GetCustomer(ByVal index As Integer, ByVal customers As List(Of Contact), ByVal contacts As List(Of Contact)) As Contact
            Dim contact As Contact = contacts(index)
            For Each c As Contact In customers
                If ReferenceEquals(c, contact) Then
                    Return Nothing
                End If
            Next c
            Return contact
        End Function
        Public Shared Function CreateTask(ByVal subject As String, ByVal category As TaskCategory) As Task
            Dim task As New Task(subject, category, Date.Now.AddHours(-rndGenerator.Next(96)))
            Dim rndStatus As Integer = rndGenerator.Next(10)
            If task.TimeDiff.TotalHours > 12 Then
                If task.TimeDiff.TotalHours > 80 Then
                    task.Status = TaskStatus.Completed

                Else
                    task.Status = TaskStatus.InProgress
                    task.PercentComplete = rndGenerator.Next(9) * 10
                End If
                task.StartDate = task.CreatedDate.AddMinutes(rndGenerator.Next(720)).Date
            End If
            If rndStatus <> 5 Then
                task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date
            End If
            If rndStatus > 8 Then
                task.Priority = 2
            End If
            If rndStatus < 3 Then
                task.Priority = 0
            End If
            If rndStatus = 6 AndAlso task.Status = TaskStatus.InProgress Then
                task.Status = TaskStatus.Deferred
            End If
            If rndStatus = 4 AndAlso task.Status = TaskStatus.InProgress AndAlso task.PercentComplete < 40 Then
                task.Status = TaskStatus.WaitingOnSomeoneElse
            End If
            If task.Category = TaskCategory.Office AndAlso rndStatus <> 7 AndAlso Customers.Count > 0 Then
                task.AssignTo = Customers(rndGenerator.Next(Customers.Count))
            End If
            If task.Status = TaskStatus.Completed Then
                If Not task.StartDate.HasValue Then
                    task.StartDate = task.CreatedDate.AddHours(12).Date
                End If
                task.CompletedDate = task.StartDate.Value.AddHours(rndGenerator.Next(48) + 24)
            End If
            Return task
        End Function
    End Class
    Public Class LayoutOption
        Public Shared TaskCollapsed As Boolean = False
        Public Shared MailCollapsed As Boolean = False
    End Class
End Namespace
