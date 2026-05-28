Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos.Modules.Overview

#Region "Data"
    Public Module EmployeeDataHelper

        'TODO add EMployee task and Evaluations
        Public Function CreateDefaultEmployee() As Employee
            Dim rnd = TutorialConstants.Random
            Dim employee As Employee = New Employee()
            employee.FirstName = "Leah"
            employee.LastName = "Simpson"
            employee.BirthDate = New DateTime(1983, 4, 19)
            employee.Title = "Test Coordinator"
            employee.Prefix = PersonPrefix.Mrs
            employee.Address = New Address()
            employee.Address.Line = "6755 Newlin Ave"
            employee.Address.City = "Whittier"
            employee.Address.State = StateEnum.AK
            employee.Address.ZipCode = "90601"
            employee.HomePhone = "(562) 555-7372"
            employee.MobilePhone = "(562) 559-5830"
            employee.Email = "leahs@dx-email.com"
            employee.Skype = "leahs_DX_skype"
            employee.Department = EmployeeDepartment.Engineering
            employee.Status = EmployeeStatus.Salaried
            employee.HireDate = New DateTime(2009, 2, 14)
            employee.AssignedTasks = New List(Of EmployeeTask)()
            Dim employeeTask1 As EmployeeTask = New EmployeeTask()
            employeeTask1.Priority = EmployeeTaskPriority.Normal
            employeeTask1.DueDate = TutorialConstants.Now + New TimeSpan(10, 10, 0, 0, 0)
            employeeTask1.Subject = String.Format("{0} QA Strategy Report", TutorialConstants.Now.Year)
            employeeTask1.Description = String.Format("In final stages of the {0} R & D Report to Management.Need QA strategy report asap.Remember, {1} was a difficult year product quality-wise and we must step it up in {0}. Leah Simpson: Bart, my apologies about {1}.My report includes remedies to issues we encountered.", TutorialConstants.Now.Year, TutorialConstants.Now.Year - 1)
            employeeTask1.Completion = 100
            employee.AssignedTasks.Add(employeeTask1)
            Dim employeeTask2 As EmployeeTask = New EmployeeTask()
            employeeTask2.Priority = EmployeeTaskPriority.Urgent
            employeeTask2.DueDate = TutorialConstants.Now + New TimeSpan(40, 10, 0, 0, 0)
            employeeTask2.Subject = "Review Training Course for any Commissions"
            employeeTask2.Description = "Leah, consider this most important item on your agenda. I need this new training material reviewed so it can be submitted to management. Leah Simpson: I only found a few spelling mistakes."
            employeeTask2.Completion = 70
            employee.AssignedTasks.Add(employeeTask2)
            Dim employeeTask3 As EmployeeTask = New EmployeeTask()
            employeeTask3.Priority = EmployeeTaskPriority.Low
            employeeTask3.DueDate = TutorialConstants.Now + New TimeSpan(80, 10, 0, 0, 0)
            employeeTask3.Subject = "Review New Training Material"
            employeeTask3.Description = "Just getting ready to push out some new training material for our customers so they can better understand how our product line fits together.Can I get a review of the content so I can send it out to the printer ? Leah Simpson: Nat, I've reviewed everything and it looks really nice."
            employeeTask3.Completion = 55
            employee.AssignedTasks.Add(employeeTask3)
            Dim employeeTask4 As EmployeeTask = New EmployeeTask()
            employeeTask4.Priority = EmployeeTaskPriority.High
            employeeTask4.DueDate = TutorialConstants.Now + New TimeSpan(95, 10, 0, 0, 0)
            employeeTask4.Subject = "Test New Automation App"
            employeeTask4.Description = "We are in a rush to ship this and you need to put all your energy behind finding bugs.If you do find bugs, use standard reporting mechanisms. We'll fix what we can as soon as we can."
            employeeTask4.Completion = 40
            employee.AssignedTasks.Add(employeeTask4)
            Dim employeeTask5 As EmployeeTask = New EmployeeTask()
            employeeTask5.Priority = EmployeeTaskPriority.Urgent
            employeeTask5.DueDate = TutorialConstants.Now + New TimeSpan(30, 10, 0, 0, 0)
            employeeTask5.Subject = "Email Test Report on New Products"
            employeeTask5.Description = "Leah, we cannot fix our products until we get the test report from you.Please send everything you have by email to me so I can distribute it in the engineering dept. Leah Simpson: Still collecting these"
            employeeTask5.Completion = 15
            employee.AssignedTasks.Add(employeeTask5)
            employee.Evaluations = New List(Of Evaluation)()
            For i As Integer = employee.HireDate.Value.Year To TutorialConstants.Now.Year - 1
                employee.Evaluations.Add(New Evaluation() With {.CreatedOn = New DateTime(i, rnd.Next(1, 12), rnd.Next(1, 25)), .Manager = "Bart Simpson", .Subject = String.Format("{0} Employee Review", i)})
            Next

            Return employee
        End Function
    End Module

    Public Class Employee

        Public Property Address As Address

        Public Overridable Property AssignedTasks As List(Of EmployeeTask)

        <Display(Name:="Birth Date")>
        Public Property BirthDate As Date?

        Public Property Department As EmployeeDepartment

        <Required>
        Public Property Email As String

        Public Overridable Property Evaluations As List(Of Evaluation)

        <Display(Name:="First Name")>
        <Required>
        Public Property FirstName As String

        <Display(Name:="Full Name")>
        Public ReadOnly Property FullNameBindable As String
            Get
                Return FirstName & " " & LastName
            End Get
        End Property

        <Display(Name:="Hire Date")>
        Public Property HireDate As Date?

        <Display(Name:="Home Phone")>
        Public Property HomePhone As String

        <Display(Name:="Last Name")>
        <Required>
        Public Property LastName As String

        <Display(Name:="Mobile Phone")>
        <Required>
        Public Property MobilePhone As String

        Public Property PersonalProfile As String

        Public Property Photo As Image

        Public Property Prefix As PersonPrefix

        Public Overridable Property ProbationReason As String

        Public Property Skype As String

        Public Property Status As EmployeeStatus

        <Required>
        Public Property Title As String
    End Class

    Public Enum PersonPrefix
        Dr = 0
        Mr = 1
        Ms = 2
        Miss = 3
        Mrs = 4
    End Enum

    Public Enum EmployeeStatus
        Salaried = 0
        Commission = 1
        Terminated = 2
        OnLeave = 3
    End Enum

    Public Enum EmployeeDepartment
        Sales = 1
        Support = 2
        Shipping = 3
        Engineering = 4
        HumanResources = 5
        Management = 6
        IT = 7
    End Enum

    Public Class Address

        Public Property City As String

        Public Property Latitude As Double

        <Display(Name:="Address")>
        Public Property Line As String

        Public Property Longitude As Double

        Public Property State As StateEnum

        <Display(Name:="Zip code")>
        Public Property ZipCode As String
    End Class

    Public Enum StateEnum
        CA = 0
        AR = 1
        AL = 2
        AK = 3
        AZ = 4
        CO = 5
        CT = 6
        DE = 7
        DC = 8
        FL = 9
        GA = 10
        HI = 11
        ID = 12
        IL = 13
        [IN] = 14
        IA = 15
        KS = 16
        KY = 17
        LA = 18
        [ME] = 19
        MD = 20
        MA = 21
        MI = 22
        MN = 23
        MS = 24
        MO = 25
        MT = 26
        NE = 27
        NV = 28
        NH = 29
        NJ = 30
        NM = 31
        NY = 32
        NC = 33
        OH = 34
        OK = 35
        [OR] = 36
        PA = 37
        RI = 38
        SC = 39
        SD = 40
        TN = 41
        TX = 42
        UT = 43
        VT = 44
        VA = 45
        WA = 46
        WV = 47
        WI = 48
        WY = 49
        ND = 50
    End Enum

    Public Class EmployeeTask

        Public Property Completion As Integer

        Public Property Description As String

        Public Property DueDate As Date?

        Public Property Priority As EmployeeTaskPriority

        Public Property StartDate As Date?

        Public Property Subject As String
    End Class

    Public Enum EmployeeTaskPriority
        Low = 0
        Normal = 1
        High = 2
        Urgent = 3
    End Enum

    Public Class Evaluation

        Public Property CreatedOn As Date

        Public Overridable Property Manager As String

        Public Property Subject As String
    End Class

    '
    Public Class ReviewedEmployee
        Inherits Employee

        Public ReadOnly Property FullName As String
            Get
                Return FullNameBindable
            End Get
        End Property

        Public Property Reviews As IList(Of EmployeeReview)
    End Class

    Public Class Assistant
        Inherits Employee

        Public ReadOnly Property FullName As String
            Get
                Return FullNameBindable
            End Get
        End Property

        Public Property ID As Integer
    End Class

    Public Class EmployeeReview

        Public Property CreatedOn As Date

        Public Property AssistantIDs As HashSet(Of Integer)
    End Class

    '
    Public Module EmployeeReviews

        Public Function GetReviewedEmployee() As ReviewedEmployee
            Dim employee As ReviewedEmployee = New ReviewedEmployee()
            employee.FirstName = "Leah"
            employee.LastName = "Simpson"
            employee.BirthDate = New DateTime(1983, 4, 19)
            employee.HireDate = New DateTime(2017, 2, 14)
            employee.Title = "Technical Writer"
            employee.Prefix = PersonPrefix.Mrs
            employee.Email = "leahs@dx-email.com"
            Dim reviews = New BindingList(Of EmployeeReview)()
            Dim assistants = GetAssistants()
            Dim r = NonCryptographicRandom.Default
            For i As Integer = employee.HireDate.Value.Year To TutorialConstants.Now.Year - 1
                Dim review = New EmployeeReview() With {.CreatedOn = New DateTime(i, r.Next(1, 12), r.Next(1, 25))}
                review.AssistantIDs = New HashSet(Of Integer)()
                Dim res = r.NextDouble()
                If res > 0.35 Then review.AssistantIDs.Add(r.Next(1, assistants.Count + 1))
                If res > 0.75 Then review.AssistantIDs.Add(r.Next(1, assistants.Count + 1))
                reviews.Add(review)
            Next

            Dim lastReview = reviews.LastOrDefault()
            If lastReview IsNot Nothing AndAlso lastReview.AssistantIDs.Count < 2 Then lastReview.AssistantIDs.Add(r.Next(1, assistants.Count + 1))
            employee.Reviews = reviews
            Return employee
        End Function

        <ThreadStatic>
        Private assistants As List(Of Assistant)

        Public Function GetAssistants() As List(Of Assistant)
            If assistants Is Nothing Then
                assistants = New List(Of Assistant)()
                Call assistants.Add(New Assistant() With {.ID = 0, .LastName = "Camino", .FirstName = "Alexandra", .Email = "Camino@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 1, .LastName = "Fuller", .FirstName = "Andrew", .Email = "Fuller@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 2, .LastName = "Dodsworth", .FirstName = "Anne", .Email = "Dodsworth@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 3, .LastName = "Callahan", .FirstName = "Laura", .Email = "Callahan@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 4, .LastName = "Leverling", .FirstName = "Jannet", .Email = "Leverling@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 5, .LastName = "Peacock", .FirstName = "Margaret", .Email = "Peacock@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 6, .LastName = "Suyama", .FirstName = "Michael", .Email = "Suyama@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 7, .LastName = "Davolio", .FirstName = "Nancy", .Email = "Davolio@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 8, .LastName = "King", .FirstName = "Robert", .Email = "King@dx-email.com"})
                Call assistants.Add(New Assistant() With {.ID = 9, .LastName = "Buchanan", .FirstName = "Steven", .Email = "Buchanan@dx-email.com"})
            End If

            Return assistants
        End Function
    End Module

#End Region
    Friend Module EditorHelpers

        Private Function CreatePersonPrefixImageCollection() As SvgImageCollection
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.Add(Properties.Resources.Doctor)
            ret.Add(Properties.Resources.Mr)
            ret.Add(Properties.Resources.Ms)
            ret.Add(Properties.Resources.Miss)
            ret.Add(Properties.Resources.Mrs)
            Return ret
        End Function

        Private Function CreateTaskPriorityImageCollection() As SvgImageCollection
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.Add("LowPriority", "image://svgimages/outlook inspired/lowpriority.svg")
            ret.Add("NormalPriority", "image://svgimages/outlook inspired/normalpriority.svg")
            ret.Add("MediumPriority", "image://svgimages/outlook inspired/mediumpriority.svg")
            ret.Add("HighPriority", "image://svgimages/outlook inspired/highpriority.svg")
            Return ret
        End Function

        Public Function CreateEdit(Of TEdit As {RepositoryItem, New})(ByVal Optional edit As TEdit = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing, ByVal Optional initialize As Func(Of TEdit, Boolean) = Nothing) As TEdit
            edit = If(edit, New TEdit())
            If collection IsNot Nothing Then collection.Add(edit)
            If initialize IsNot Nothing Then initialize(edit)
            Return edit
        End Function

        Public Function CreateEnumImageComboBox(Of TEnum)(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing, ByVal Optional displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
            Return CreateEdit(edit, collection, Function(e) AddEnum(displayTextConverter, e))
        End Function

        Private Function AddEnum(Of TEnum)(ByVal displayTextConverter As Converter(Of TEnum, String), ByVal e As RepositoryItemImageComboBox) As Boolean
            e.Items.AddEnum(displayTextConverter)
            Return True
        End Function

        Public Function CreatePersonPrefixImageComboBox(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of PersonPrefix)(edit, collection)
            ret.SmallImages = CreatePersonPrefixImageCollection()
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Public Function CreateTaskPriorityImageComboBox(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of EmployeeTaskPriority)(edit, collection)
            ret.SmallImages = CreateTaskPriorityImageCollection()
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function
    End Module
End Namespace
