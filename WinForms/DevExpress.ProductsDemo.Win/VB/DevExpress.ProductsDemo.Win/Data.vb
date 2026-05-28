Imports System.IO
Imports DevExpress.MailDemo.Win
Imports DevExpress.ProductsDemo.Win
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.MailClient.Win
    Public Class Task
        Implements IDXDataErrorInfo

        'INSTANT VB NOTE: The field priority was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private priority_Renamed As Integer = 1
        'INSTANT VB NOTE: The field percentComplete was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private percentComplete_Renamed As Integer = 0
        'INSTANT VB NOTE: The field createdDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private createdDate_Renamed As Date
        'INSTANT VB NOTE: The field startDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field dueDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field completedDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private startDate_Renamed? As Date = Nothing, dueDate_Renamed? As Date = Nothing, completedDate_Renamed? As Date = Nothing
        'INSTANT VB NOTE: The field subject was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field description was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private subject_Renamed, description_Renamed As String
        'INSTANT VB NOTE: The field status was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private status_Renamed As TaskStatus = TaskStatus.NotStarted
        'INSTANT VB NOTE: The field category was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private category_Renamed As TaskCategory
        'INSTANT VB NOTE: The field assignTo was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private assignTo_Renamed As Contact = Nothing
        Public Sub New(ByVal subject As String, ByVal category As TaskCategory)
            Me.New(subject, category, Date.Now)
        End Sub
        Friend Sub New(ByVal subject As String, ByVal category As TaskCategory, ByVal [date] As Date)
            Me.subject_Renamed = subject
            Me.category_Renamed = category
            Me.createdDate_Renamed = [date]
        End Sub
        Public Property Priority() As Integer
            Get
                Return priority_Renamed
            End Get
            Set(ByVal value As Integer)
                priority_Renamed = value
            End Set
        End Property
        Public Property PercentComplete() As Integer
            Get
                Return percentComplete_Renamed
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    value = 0
                End If
                If value > 100 Then
                    value = 100
                End If
                If percentComplete_Renamed = value Then
                    Return
                End If
                percentComplete_Renamed = value
                If percentComplete_Renamed = 100 Then
                    Status = TaskStatus.Completed
                End If
                If percentComplete_Renamed > 0 AndAlso percentComplete_Renamed < 100 Then
                    Status = TaskStatus.InProgress
                End If
            End Set
        End Property
        Public ReadOnly Property CreatedDate() As Date
            Get
                Return createdDate_Renamed
            End Get
        End Property
        Public Property StartDate() As Date?
            Get
                Return startDate_Renamed
            End Get
            Set(ByVal value? As Date)
                startDate_Renamed = value
            End Set
        End Property
        Public Property DueDate() As Date?
            Get
                Return dueDate_Renamed
            End Get
            Set(ByVal value? As Date)
                dueDate_Renamed = value
            End Set
        End Property
        Public Property CompletedDate() As Date?
            Get
                Return completedDate_Renamed
            End Get
            Set(ByVal value? As Date)
                completedDate_Renamed = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return subject_Renamed
            End Get
            Set(ByVal value As String)
                subject_Renamed = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return description_Renamed
            End Get
            Set(ByVal value As String)
                description_Renamed = value
            End Set
        End Property
        Public Property Category() As TaskCategory
            Get
                Return category_Renamed
            End Get
            Set(ByVal value As TaskCategory)
                category_Renamed = value
            End Set
        End Property
        Public Property Status() As TaskStatus
            Get
                Return status_Renamed
            End Get
            Set(ByVal value As TaskStatus)
                status_Renamed = value
                If status_Renamed = TaskStatus.Completed Then
                    PercentComplete = 100
                    CompletedDate = Date.Now
                Else
                    CompletedDate = Nothing
                End If
                If status_Renamed = TaskStatus.NotStarted Then
                    PercentComplete = 0
                End If
                If status_Renamed = TaskStatus.InProgress AndAlso PercentComplete = 100 Then
                    PercentComplete = 75
                End If
                If status_Renamed = TaskStatus.Deferred OrElse status_Renamed = TaskStatus.WaitingOnSomeoneElse Then
                    DueDate = Nothing
                End If
            End Set
        End Property
        Public Property AssignTo() As Contact
            Get
                Return assignTo_Renamed
            End Get
            Set(ByVal value As Contact)
                assignTo_Renamed = value
            End Set
        End Property
        Friend ReadOnly Property TimeDiff() As TimeSpan
            Get
                Return (Date.Now.Subtract(CreatedDate))
            End Get
        End Property
        Public ReadOnly Property Overdue() As Boolean
            Get
                If Status = TaskStatus.Completed OrElse Not DueDate.HasValue Then
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
            Me.subject_Renamed = task.Subject
            Me.priority_Renamed = task.Priority
            Me.percentComplete_Renamed = task.PercentComplete
            Me.createdDate_Renamed = task.CreatedDate
            Me.startDate_Renamed = task.StartDate
            Me.dueDate_Renamed = task.DueDate
            Me.completedDate_Renamed = task.CompletedDate
            Me.description_Renamed = task.Description
            Me.category_Renamed = task.Category
            Me.status_Renamed = task.Status
            Me.assignTo_Renamed = task.AssignTo
        End Sub
        Public Function Clone() As Task
            Dim task As New Task(Me.Subject, Me.Category)
            task.Assign(Me)
            Return task
        End Function
        Public ReadOnly Property DueIn() As String
            Get
                If DueDate.HasValue Then
                    Dim oDays As Integer = (Date.Today.Subtract(DueDate.Value)).Days
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
                'INSTANT VB WARNING: Comparisons involving nullable type instances require Option Strict Off:
                If (DueDate.HasValue AndAlso StartDate.HasValue) AndAlso DueDate < StartDate Then
                    SetErrorInfo(info, My.Resources.DueDateError, ErrorType.Critical)
                End If
                If Not DueDate.HasValue AndAlso Status = TaskStatus.InProgress Then
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

        Private customer, person As DataRow
        'INSTANT VB NOTE: The field photo was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private photo_Renamed As Image
        'INSTANT VB NOTE: The field name was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private name_Renamed As FullName
        'INSTANT VB NOTE: The field email was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field phone was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field note was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private email_Renamed, phone_Renamed, note_Renamed As String
        'INSTANT VB NOTE: The field gender was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private gender_Renamed As ContactGender
        'INSTANT VB NOTE: The field birthDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private birthDate_Renamed? As Date
        'INSTANT VB NOTE: The field address was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private address_Renamed As Address
        'INSTANT VB NOTE: The field hasPhoto was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private hasPhoto_Renamed As Boolean = False
        Public Sub New()
            name_Renamed = New FullName(My.Resources.NewFirstName, String.Empty, My.Resources.NewLastName)
            address_Renamed = New Address()
        End Sub
        Public Sub New(ByVal contact As Contact)
            name_Renamed = New FullName()
            address_Renamed = New Address()
            Me.Assign(contact)
        End Sub
        Public Sub New(ByVal customer As DataRow, ByVal person As DataRow)
            Me.customer = customer
            Me.person = person
            If Not (TypeOf customer("Photo") Is DBNull) Then
                photo_Renamed = XtraEditors.Controls.ByteImageConverter.FromByteArray(DirectCast(customer("Photo"), Byte()))
                hasPhoto_Renamed = True
            Else
                photo_Renamed = My.Resources.Unknown_user
            End If
            name_Renamed = New FullName(String.Format("{0}", person("FirstName")), String.Format("{0}", customer("MiddleName")), String.Format("{0}", person("LastName")))
            email_Renamed = String.Format("{0}", customer("Email")).Replace("dxvideorent.com", "dxmail.net")
            gender_Renamed = DirectCast(person("Gender"), ContactGender)
            birthDate_Renamed = DirectCast(person("BirthDate"), Date?)
            phone_Renamed = String.Format("{0}", customer("Phone"))
            address_Renamed = New Address(String.Format("{0}", customer("Address")))
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return name_Renamed.ToString()
            End Get
        End Property
        Public ReadOnly Property FirstName() As String
            Get
                Return name_Renamed.FirstName
            End Get
        End Property
        Public ReadOnly Property MiddleName() As String
            Get
                Return name_Renamed.MiddleName
            End Get
        End Property
        Public ReadOnly Property LastName() As String
            Get
                Return name_Renamed.LastName
            End Get
        End Property
        Public Property Email() As String
            Get
                Return email_Renamed
            End Get
            Set(ByVal value As String)
                email_Renamed = value
            End Set
        End Property
        Public Property Gender() As ContactGender
            Get
                Return gender_Renamed
            End Get
            Set(ByVal value As ContactGender)
                gender_Renamed = value
            End Set
        End Property
        Public ReadOnly Property BirthDate() As Date?
            Get
                Return birthDate_Renamed
            End Get
        End Property
        Public Property BindingBirthDate() As Date
            Get
                If BirthDate.HasValue Then
                    Return BirthDate.Value
                End If
                Return Date.MinValue
            End Get
            Set(ByVal value As Date)
                birthDate_Renamed = value
            End Set
        End Property
        Public Property Phone() As String
            Get
                Return phone_Renamed
            End Get
            Set(ByVal value As String)
                phone_Renamed = value
            End Set
        End Property
        Public ReadOnly Property State() As String
            Get
                Return address_Renamed.State
            End Get
        End Property
        Public ReadOnly Property City() As String
            Get
                Return address_Renamed.City
            End Get
        End Property
        Public ReadOnly Property Zip() As String
            Get
                Return address_Renamed.Zip
            End Get
        End Property
        Public ReadOnly Property AddressLine() As String
            Get
                Return address_Renamed.AddressLine
            End Get
        End Property
        Public ReadOnly Property Address() As Address
            Get
                Return address_Renamed
            End Get
        End Property
        Public ReadOnly Property FullName() As FullName
            Get
                Return name_Renamed
            End Get
        End Property
        Public Property Photo() As Image
            Get
                Return photo_Renamed
            End Get
            Set(ByVal value As Image)
                photo_Renamed = value
            End Set
        End Property
        Public Property Note() As String
            Get
                Return note_Renamed
            End Get
            Set(ByVal value As String)
                note_Renamed = value
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
                Dim title As ContactTitle = name_Renamed.Title
                If title = ContactTitle.None AndAlso gender_Renamed = ContactGender.Female Then
                    title = ContactTitle.Mrs
                End If
                Select Case title
                    Case ContactTitle.Dr
                        Return My.Resources.Doctor
                    Case ContactTitle.Miss
                        Return My.Resources.Miss
                    Case ContactTitle.Mrs
                        Return My.Resources.Mrs
                    Case ContactTitle.Ms
                        Return My.Resources.Ms
                    Case ContactTitle.Prof
                        Return My.Resources.Professor
                End Select
                Return My.Resources.Mr
            End Get
        End Property
        Public ReadOnly Property SvgIcon() As SvgImage
            Get
                Dim title As ContactTitle = name_Renamed.Title
                If title = ContactTitle.None AndAlso gender_Renamed = ContactGender.Female Then
                    title = ContactTitle.Mrs
                End If
                Select Case title
                    Case ContactTitle.Dr
                        Return My.Resources.Doctor1
                    Case ContactTitle.Miss
                        Return My.Resources.Miss1
                    Case ContactTitle.Mrs
                        Return My.Resources.Mrs1
                    Case ContactTitle.Ms
                        Return My.Resources.Ms1
                    Case ContactTitle.Prof
                        Return My.Resources.Professor1
                End Select
                Return My.Resources.Mr1
            End Get
        End Property
        Friend ReadOnly Property HasPhoto() As Boolean
            Get
                Return hasPhoto_Renamed
            End Get
        End Property
        Public Sub Assign(ByVal contact As Contact)
            Me.photo_Renamed = contact.Photo
            Me.name_Renamed.Assign(contact.FullName)
            Me.address_Renamed.Assign(contact.Address)
            Me.email_Renamed = contact.Email
            Me.gender_Renamed = contact.Gender
            Me.birthDate_Renamed = contact.BirthDate
            Me.phone_Renamed = contact.Phone
            Me.note_Renamed = contact.Note
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
    Public Class FullName
        'INSTANT VB NOTE: The field title was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private title_Renamed As ContactTitle
        Private first, middle, last As String
        Public Sub New()
            Me.New(String.Empty, String.Empty, String.Empty)
        End Sub
        Public Sub New(ByVal first As String, ByVal middle As String, ByVal last As String)
            Me.New(ContactTitle.None, first, middle, last)
        End Sub
        Public Sub New(ByVal title As ContactTitle, ByVal first As String, ByVal middle As String, ByVal last As String)
            Me.title_Renamed = title
            Me.first = first
            Me.middle = middle
            Me.last = last
        End Sub
        Public Property Title() As ContactTitle
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As ContactTitle)
                title_Renamed = value
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
            Return String.Format("{0}{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)), GetFormatString(FirstName), GetFormatString(MiddleName), LastName)
        End Function
        Private Function GetFormatString(ByVal name As String) As String
            If String.IsNullOrEmpty(name) Then
                Return String.Empty
            End If
            Return String.Format("{0} ", name)
        End Function
        Public Sub Assign(ByVal name As FullName)
            Me.title_Renamed = name.Title
            Me.first = name.FirstName
            Me.middle = name.MiddleName
            Me.last = name.LastName
        End Sub
    End Class
    Public Class Address
        'INSTANT VB NOTE: The field address was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field city was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
        'INSTANT VB NOTE: The field zip was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private address_Renamed As String, city_Renamed As String = String.Empty, state_Renamed As String = String.Empty, zip_Renamed As String
        Public Sub New()
            Me.New(String.Empty)
        End Sub
        Public Sub New(ByVal address As String, ByVal city As String, ByVal state As String, ByVal zip As String)
            Me.address_Renamed = address
            Me.city_Renamed = city
            Me.state_Renamed = state
            Me.zip_Renamed = zip
        End Sub
        Friend Sub New(ByVal addressString As String)
            If String.IsNullOrEmpty(addressString) Then
                Return
            End If
            Try
                Dim lines() As String = addressString.Split(","c)
                Me.address_Renamed = lines(0).Trim()
                Me.city_Renamed = lines(1).Trim()
                Me.state_Renamed = lines(2).Trim().Substring(0, 2)
                Dim temp As String = lines(2).Trim()
                Me.zip_Renamed = temp.Substring(3, temp.Length - 3)
            Catch
            End Try
        End Sub
        Public Property AddressLine() As String
            Get
                Return address_Renamed
            End Get
            Set(ByVal value As String)
                address_Renamed = value
            End Set
        End Property
        Public Property State() As String
            Get
                Return state_Renamed
            End Get
            Set(ByVal value As String)
                state_Renamed = value
            End Set
        End Property
        Public Property City() As String
            Get
                Return city_Renamed
            End Get
            Set(ByVal value As String)
                city_Renamed = value
            End Set
        End Property
        Public Property Zip() As String
            Get
                Return zip_Renamed
            End Get
            Set(ByVal value As String)
                zip_Renamed = value
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
            Me.address_Renamed = address.AddressLine
            Me.state_Renamed = address.State
            Me.city_Renamed = address.City
            Me.zip_Renamed = address.Zip
        End Sub
    End Class
    Public Class DataHelper
        'INSTANT VB NOTE: The field contacts was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private Shared contacts_Renamed As List(Of Contact) = Nothing
        'INSTANT VB NOTE: The field tasks was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private Shared tasks_Renamed As List(Of Task) = Nothing
        Friend Shared ApplicationArguments() As String
        Private Shared calendarResourcesTable As DataTable
        Private Shared calendarAppointmentsTable As DataTable

        Public Shared ReadOnly Property Contacts() As List(Of Contact)
            Get
                If contacts_Renamed Is Nothing Then
                    contacts_Renamed = GetContacts()
                End If
                Return contacts_Renamed
            End Get
        End Property
        Public Shared ReadOnly Property Tasks() As List(Of Task)
            Get
                If tasks_Renamed Is Nothing Then
                    tasks_Renamed = GenerateTasks()
                End If
                Return tasks_Renamed
            End Get
        End Property
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
            Dim temp As New DataSet()
            Dim dbName As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\VideoRent.xml", False)
            If String.IsNullOrEmpty(dbName) Then
                Return ret
            End If
            temp.ReadXml(dbName)
            Dim tbl As DataTable = temp.Relations("FK_CustomerOidOidPerson").ChildTable
            For i As Integer = 0 To tbl.Rows.Count - 1
                ret.Add(New Contact(tbl.Rows(i), tbl.Rows(i).GetParentRow("FK_CustomerOidOidPerson")))
            Next i
            Return ret
        End Function
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
        'INSTANT VB NOTE: The field customers was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private Shared customers_Renamed As List(Of Contact)
        Friend Shared ReadOnly Property Customers() As List(Of Contact)
            Get
                If customers_Renamed Is Nothing Then
                    customers_Renamed = New List(Of Contact)()
                    Dim temp As List(Of Contact) = DataHelper.GetContacts()
                    If temp.Count > CustomerCount Then
                        Do While customers_Renamed.Count < CustomerCount
                            Dim contact As Contact = GetCustomer(rndGenerator.Next(temp.Count - 1), customers_Renamed, temp)
                            If contact IsNot Nothing Then
                                customers_Renamed.Add(contact)
                            End If
                        Loop
                    End If
                End If
                Return customers_Renamed
            End Get
        End Property
        Private Shared Function GetCustomer(ByVal index As Integer, ByVal customers As List(Of Contact), ByVal contacts As List(Of Contact)) As Contact
            Dim contact As Contact = contacts(index)
            If Not contact.HasPhoto Then
                Return Nothing
            End If
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
    End Class
End Namespace
