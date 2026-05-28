Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports DevExpress.Data
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Text
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Svg
Imports DevExpress.DXperience.Demos
Imports DevExpress.DevAV
Imports DevExpress.Internal
#If Not NET
Imports System.Data.Entity
Imports System.Runtime.InteropServices

#Else
using Microsoft.EntityFrameworkCore;
#End If
Namespace DevExpress.XtraGrid.Demos

    <Flags>
    Public Enum MailFolder
        All = 0
        Announcements = 1
        General = 2
        Management = 4
        IT = 8
        Sales = 16
        Support = 32
        Engineering = 64
        Deleted = 128
        Custom = 1024
    End Enum

    Public Enum MailCategories
        General = 1
        Management = 2
        IT = 3
        Sales = 4
        Support = 5
        Engineering = 6
        HR = 7
        Design = 8
    End Enum

    Public Enum MailType
        Inbox
        Deleted
        Sent
        Draft
    End Enum

    Public Class OutlookData

        Friend Shared users As String() = New String() {"Peter Dolan", "Ryan Fischer", "Richard Fisher", "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain", "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman", "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"}

        Private Shared subject As String() = New String() {"Integrating DevExpress MasterView control into an Accounting System.", "Web Edition: Data Entry Page. There is an issue with date validation.", "Payables Due Calculator is ready for testing.", "Web Edition: Search Page is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I find the complete specs?", "Ledger: Inconsistency. Please fix it.", "Receivables Printing module is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library are we going to use?", "Cannot add new vendor. This module doesn't work!", "History. Will we track sales history in our system?", "Main Menu: Add a File menu. File menu item is missing.", "Currency Mask. The current currency mask in completely unusable.", "Drag & Drop operations are not available in the scheduler module.", "Data Import. What database types will we support?", "Reports. The list of incomplete reports.", "Data Archiving. We still don't have this features in our application.", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked us for export to Microsoft Excel"}

        Private Shared Function GetImportance(ByVal num As Integer) As Integer
            Dim ret As Integer = TutorialConstants.Random.Next(num)
            If ret > 2 Then ret = 1
            Return ret
        End Function

        Private Shared Function GetIcon() As Integer
            Dim ret As Integer = TutorialConstants.Random.Next(10)
            ret = If(ret > 2, 1, 0)
            Return ret
        End Function

        Private Shared Function GetAttach() As Integer
            Dim ret As Integer = TutorialConstants.Random.Next(10)
            ret = If(ret > 5, 1, 0)
            Return ret
        End Function

        Private Shared Function GetSent() As Date
            Dim ret As Date = TutorialConstants.Now
            Dim r As Integer = TutorialConstants.Random.Next(12)
            If r > 1 Then ret = ret.AddDays(-TutorialConstants.Random.Next(50))
            ret = ret.AddMinutes(-TutorialConstants.Random.Next(ret.Minute + ret.Hour * 60 + 360))
            Return ret
        End Function

        Private Shared Function GetReceived(ByVal sent As Date) As Date
            Dim dt As Date = sent.AddMinutes(10 + TutorialConstants.Random.Next(120))
            If dt > TutorialConstants.Now Then dt = TutorialConstants.Now.AddMinutes(-1)
            Return dt
        End Function

        Private Shared Function GetSubject() As String
            Return subject(TutorialConstants.Random.Next(subject.Length - 1))
        End Function

        Public Shared Function GetFrom() As String
            Return users(TutorialConstants.Random.Next(users.Length - 2))
        End Function

        Private Shared Function GetTo() As String
            Return users(users.Length - 1)
        End Function

        Private Shared Function GetSentDate() As Date
            Dim ret As Date = TutorialConstants.Today
            Dim r As Integer = TutorialConstants.Random.Next(12)
            If r > 1 Then ret = ret.AddDays(-TutorialConstants.Random.Next(50))
            Return ret
        End Function

        Private Shared Function GetSentDateWithTime() As Date
            Dim ret As Date = TutorialConstants.Now.AddMinutes(-TutorialConstants.Random.Next(60, 250000))
            Return ret
        End Function

        Public Shared Function GetDueDate() As Date
            Dim ret As Date = TutorialConstants.Today
            ret = ret.AddDays(60 + TutorialConstants.Random.Next(50))
            Return ret
        End Function

        Private Shared Function GetSize(ByVal largeData As Boolean) As Integer
            Return 1000 + If(largeData, 20 * TutorialConstants.Random.Next(10000), 30 * TutorialConstants.Random.Next(100))
        End Function

        Private Shared Function GetHasAttachment() As Boolean
            Return TutorialConstants.Random.Next(10) > 5
        End Function

        Public Shared Function CreateDataTable() As DataTable
            Return CreateDataTable(7)
        End Function

        Public Shared Function CreateMailRow(ByVal num As Integer, ByVal realTime As Boolean) As Object()
            Dim sent As Date = GetSent()
            Return New Object() {GetImportance(num), GetAttach(), If(realTime, 0, GetIcon()), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent, If(realTime, TutorialConstants.Now, GetReceived(sent))}
        End Function

        Public Shared Function CreateDataTable(ByVal num As Integer) As DataTable
            Dim tbl As DataTable = New DataTable("Outlook")
            tbl.Columns.Add("Priority", GetType(Integer))
            tbl.Columns.Add("Attachment", GetType(Integer))
            tbl.Columns.Add("Read", GetType(Integer))
            tbl.Columns.Add("Flag", GetType(Integer))
            tbl.Columns.Add("Subject", GetType(String))
            tbl.Columns.Add("From", GetType(String))
            tbl.Columns.Add("To", GetType(String))
            tbl.Columns.Add("Sent", GetType(Date))
            tbl.Columns.Add("Received", GetType(Date))
            For i As Integer = 0 To 80 - 1
                tbl.Rows.Add(CreateMailRow(num, False))
            Next

            Return tbl
        End Function

        Public Shared Function CreateIssueList() As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl = New DataTable("IssueList")
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Subject", GetType(String))
            tbl.Columns.Add("Implemented", GetType(Integer))
            tbl.Columns.Add("Suspended", GetType(Boolean))
            For i As Integer = 1 To subject.Length
                tbl.Rows.Add(New Object() {i, subject.GetValue(i - 1), TutorialConstants.Random.Next(100), TutorialConstants.Random.Next(10) > 8})
            Next

            Return tbl
        End Function

        Public Shared Function CreateNewObject(ByVal uow As UnitOfWork) As ServerSideGridTest
            Dim obj As ServerSideGridTest = New ServerSideGridTest(uow)
            obj.Subject = GetSubject()
            obj.From = GetFrom()
            obj.Sent = GetSentDateWithTime()
            obj.HasAttachment = GetHasAttachment()
            obj.Size = GetSize(obj.HasAttachment)
            obj.Priority = GetImportance(4)
            Return obj
        End Function
    End Class

    Public Class GroupIntervalData

        Private Shared Function GetCount() As Decimal
            Return TutorialConstants.Random.Next(50) + 10
        End Function

        Private Shared Function GetDate(ByVal range As Boolean) As Date
            Dim ret As Date = TutorialConstants.Now
            Dim r As Integer = TutorialConstants.Random.Next(20)
            If range Then
                If r > 1 Then ret = ret.AddDays(TutorialConstants.Random.Next(80) - 40)
                If r > 18 Then ret = ret.AddMonths(TutorialConstants.Random.Next(18))
            Else
                ret = ret.AddDays(TutorialConstants.Random.Next(r * 30) - r * 15)
            End If

            Return ret
        End Function

        Public Shared Function CreateDataTable(ByVal maxRows As Integer) As DataTable
            Return CreateDataTable(maxRows, True)
        End Function

        Public Shared Function CreateDataTable(ByVal maxRows As Integer, ByVal range As Boolean) As DataTable
            Dim tbl As DataTable = Nothing
            Dim DBFileName As String = String.Empty
            DBFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml")
            If Not Equals(DBFileName, String.Empty) Then
                Dim ds As DataSet = New DataSet()
                ds.ReadXml(DBFileName)
                Dim product As DataTable = ds.Tables("Products")
                tbl = New DataTable("GroupInterval")
                tbl.Columns.Add("Product Name", GetType(String))
                tbl.Columns.Add("Category", GetType(Integer))
                tbl.Columns.Add("Unit Price", GetType(Decimal))
                tbl.Columns.Add("Count", GetType(Integer))
                tbl.Columns.Add("Order Date", GetType(Date))
                tbl.Columns.Add("Order Sum", GetType(Decimal), "[Unit Price] * [Count]")
                For i As Integer = 0 To maxRows - 1
                    Dim row As DataRow = product.Rows(TutorialConstants.Random.Next(product.Rows.Count - 1))
                    tbl.Rows.Add(New Object() {row("ProductName"), row("CategoryID"), row("UnitPrice"), GetCount(), GetDate(range)})
                Next
            End If

            Return tbl
        End Function
    End Class

    Public Class MailData

        Private ReadOnly rowCore As DataRow

        Public Sub New(ByVal row As DataRow)
            rowCore = row
        End Sub

        Public ReadOnly Property Row As DataRow
            Get
                Return rowCore
            End Get
        End Property

        Public Property Priority As Integer
            Get
                Return CInt(rowCore("Priority"))
            End Get

            Set(ByVal value As Integer)
                rowCore("Priority") = value
            End Set
        End Property

        Public ReadOnly Property Attachment As Integer
            Get
                Return CInt(rowCore("Attachment"))
            End Get
        End Property

        Public Property Read As Integer
            Get
                Return CInt(rowCore("Read"))
            End Get

            Set(ByVal value As Integer)
                rowCore("Read") = value
            End Set
        End Property

        Public Property Flag As Integer
            Get
                Return CInt(rowCore("Flag"))
            End Get

            Set(ByVal value As Integer)
                rowCore("Flag") = value
            End Set
        End Property

        Public ReadOnly Property Subject As String
            Get
                Return String.Format("{0}", rowCore("Subject"))
            End Get
        End Property

        Public ReadOnly Property From As String
            Get
                Return String.Format("{0}", rowCore("From"))
            End Get
        End Property
    End Class

    Public Class OrderItem

        Public Property OrderID As Integer

        Public Property ProductID As Integer

        Public Property UnitPrice As Decimal

        Public Property Quantity As Integer

        Public Property Discount As Single

        Public Property Selector As Boolean

        Public Shared Function GetOrderItems(ByVal tbl As DataTable) As List(Of OrderItem)
            Dim ret As List(Of OrderItem) = New List(Of OrderItem)(tbl.Rows.Count)
            For Each row As DataRow In tbl.Rows
                ret.Add(New OrderItem() With {.OrderID = CInt(row("OrderID")), .ProductID = CInt(row("ProductID")), .Discount = CSng(row("Discount")), .Quantity = CShort(row("Quantity")), .UnitPrice = CDec(row("UnitPrice"))})
            Next

            Return ret
        End Function
    End Class

    Public Class ColorsObject

        Private fforeColor, fbackColor As Color

        Public Sub New(ByVal fforeColor As Color, ByVal fbackColor As Color)
            Me.fforeColor = fforeColor
            Me.fbackColor = fbackColor
        End Sub

        Public Property ForeColor As Color
            Get
                Return fforeColor
            End Get

            Set(ByVal value As Color)
                fforeColor = value
            End Set
        End Property

        Public Property BackColor As Color
            Get
                Return fbackColor
            End Get

            Set(ByVal value As Color)
                fbackColor = value
            End Set
        End Property
    End Class

    Public Class ColorHelper

        Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
            Dim ret As Color = SystemColors.ControlText
            If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then Return ret
            Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
        End Function

        Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
            For i As Integer = 0 To bmp.Width - 1
                For j As Integer = 0 To bmp.Height - 1
                    If Not Equals(bmp.GetPixel(i, j).Name, "0") Then bmp.SetPixel(i, j, color)
                Next
            Next

            Return bmp
        End Function
    End Class

    Public Class LoanPayment

        Private monthNumberCore As Integer

        Private balanceCore, interestCore, principalCore As Double

        Private monthCore As Date

        Public Sub New(ByVal balance As Double, ByVal monthlyPayment As Double, ByVal month As Integer, ByVal interestRate As Double, ByVal startMonth As Date)
            monthNumberCore = month
            monthCore = startMonth.AddMonths(month - 1)
            interestCore = Trunc2(balance * interestRate)
            principalCore = Trunc2(monthlyPayment - interestCore)
            balanceCore = Trunc2(balance - principalCore)
        End Sub

        Public Sub UpdateBalance()
            If balanceCore < 0 Then principalCore += balanceCore
            balanceCore = 0
        End Sub

        Public ReadOnly Property Month As Date
            Get
                Return monthCore
            End Get
        End Property

        Public ReadOnly Property MonthNumber As Integer
            Get
                Return monthNumberCore
            End Get
        End Property

        Public ReadOnly Property MonthlyPayment As Double
            Get
                Return Interest + Principal
            End Get
        End Property

        Public ReadOnly Property Balance As Double
            Get
                Return balanceCore
            End Get
        End Property

        Public ReadOnly Property Interest As Double
            Get
                Return interestCore
            End Get
        End Property

        Public ReadOnly Property Principal As Double
            Get
                Return principalCore
            End Get
        End Property

        Public ReadOnly Property MonthString As String
            Get
                Return String.Format("{0}<size=-2> ({1:MMMM, yyyy})", MonthNumber, Month)
            End Get
        End Property

        Public Shared Function Trunc2(ByVal val As Double) As Double
            Return Convert.ToDouble(Convert.ToInt64(val * 100)) / 100
        End Function

        Public Shared Function Calculate(ByVal loanAmount As Double, ByVal interestRate As Double, ByVal months As Double, ByVal startMonth As Date, <Out> ByRef payment As Double) As List(Of LoanPayment)
            payment = loanAmount * interestRate / (1 - Math.Exp(-months * Math.Log(1 + interestRate)))
            payment = Trunc2(payment)
            Dim payments As List(Of LoanPayment) = New List(Of LoanPayment)()
            Dim _balance As Double = loanAmount
            Dim count As Integer = Convert.ToInt32(months + 0.5)
            For i As Integer = 1 To count
                Dim lp As LoanPayment = New LoanPayment(_balance, payment, i, interestRate, startMonth)
                _balance = lp.Balance
                payments.Add(lp)
                If lp.Balance <= 0 Then Exit For
            Next

            payments(payments.Count - 1).UpdateBalance()
            Return payments
        End Function

        Public Shared Sub InitStartMonth(ByVal edit As ImageComboBoxEdit)
            Dim start As Date = New DateTime(TutorialConstants.Today.Year, TutorialConstants.Today.Month, 1)
            For i As Integer = 1 To 7 - 1
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0:MMMM, yyyy}", start.AddMonths(i)), start.AddMonths(i), -1))
            Next

            edit.SelectedIndex = 0
        End Sub

        Public Shared Sub InitTermOfLoan(ByVal edit As ImageComboBoxEdit)
            Dim terms As Integer() = New Integer() {5, 10, 15, 20, 25, 30}
            For Each term As Integer In terms
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0} {1}", term, Properties.Resources.Years), term, -1))
            Next

            edit.SelectedIndex = 5
        End Sub

        Public Shared Sub InitInterestRateData(ByVal edit As ImageComboBoxEdit)
            For i As Double = 2.5 To 15 - 1 Step 0.125R
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0:n3} %", i), i, -1))
            Next

            edit.SelectedIndex = 25
        End Sub

        Public Shared Function GetMonthString(ByVal month As Integer, ByVal data As List(Of LoanPayment)) As String
            For Each payment As LoanPayment In data
                If payment.MonthNumber.Equals(month) Then Return StringPainter.Default.RemoveFormat(payment.MonthString)
            Next

            Return String.Empty
        End Function
    End Class

    Public Class PaymentTypeSum

        Private interestSumCore As Double = 0

        Private principalSumCore As Double = 0

        Public Sub New()
            interestSumCore = 0
            principalSumCore = 0
        End Sub

        Public ReadOnly Property InterestSum As Double
            Get
                Return interestSumCore
            End Get
        End Property

        Public ReadOnly Property PrincipalSum As Double
            Get
                Return principalSumCore
            End Get
        End Property

        Public Sub AddToSum(ByVal value1 As Double, ByVal value2 As Double)
            interestSumCore += value1
            principalSumCore += value2
        End Sub
    End Class

    Public Enum PropertyType
        <Description("Single Family Home")>
        SingleFamilyHome
        <Description("Condo/Townhouse")>
        Townhome
        <Description("Multi-Family Home")>
        MultiFamilyHome
    End Enum

    Public Enum PropertyStatus
        <Description("New Construction")>
        NewConstruction
        <Description("Foreclosures")>
        Foreclosures
        <Description("Recently Sold")>
        RecentlySold
    End Enum

    Public Class Home

        Private Shared homesCore As List(Of Home)

        Private row As DataRow

        Private photoCore As Image

        Public Sub New(ByVal row As DataRow)
            Me.row = row
            If Not(TypeOf row("Photo") Is DBNull) Then photoCore = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte()))
        End Sub

        Public ReadOnly Property ID As Integer
            Get
                Return CInt(row("ID"))
            End Get
        End Property

        Public ReadOnly Property Address As String
            Get
                Return String.Format("{0}", row("Address"))
            End Get
        End Property

        Public ReadOnly Property Baths As Short
            Get
                Return CShort(row("Baths"))
            End Get
        End Property

        Public ReadOnly Property Beds As Short
            Get
                Return CShort(row("Beds"))
            End Get
        End Property

        Public ReadOnly Property HouseSize As Double
            Get
                Return CDbl(row("HouseSize"))
            End Get
        End Property

        Public ReadOnly Property LotSize As Double
            Get
                Return CDbl(row("LotSize"))
            End Get
        End Property

        Public ReadOnly Property Price As Decimal
            Get
                Return Convert.ToDecimal(row("Price"))
            End Get
        End Property

        Public ReadOnly Property YearBuilt As String
            Get
                Return String.Format("{0}", row("YearBuilt"))
            End Get
        End Property

        Public ReadOnly Property Photo As Image
            Get
                Return photoCore
            End Get
        End Property

        Public ReadOnly Property Features As String
            Get
                Return String.Format("{0}", row("Features"))
            End Get
        End Property

        Public ReadOnly Property Type As String
            Get
                Return EnumExtensions.GetEnumItemDisplayText(CType(row("Type"), PropertyType))
            End Get
        End Property

        Public ReadOnly Property Status As String
            Get
                Return EnumExtensions.GetEnumItemDisplayText(CType(row("Status"), PropertyStatus))
            End Get
        End Property

        Private Shared Function GetHomes() As List(Of Home)
            Dim temp As DataSet = New DataSet()
            Dim db As String = DataDirectoryHelper.GetDataFile("Homes.xml")
            If String.IsNullOrEmpty(db) Then Return Nothing
            temp.ReadXml(db)
            Dim ret As List(Of Home) = New List(Of Home)()
            For Each row As DataRow In temp.Tables("Homes").Rows
                ret.Add(New Home(row))
            Next

            Return ret
        End Function

        Public Shared ReadOnly Property Homes As List(Of Home)
            Get
                If homesCore Is Nothing Then homesCore = GetHomes()
                Return homesCore
            End Get
        End Property
    End Class

    Public Class HomeBedRoomChartData

        Public Property RoomName As String

        Public Property RoomSize As Double
    End Class

    Public Class Message
        Implements INotifyPropertyChanged

        Private row As DataRow

        Private dateCore As Date

        Private readCore, deletedCore, hasAttachment As Boolean

        Private priorityCore As Integer = 1

        Private mailTypeCore As MailType

        Private mailFolderCore As Integer

        Private fromCore As String = String.Empty, subjectCore As String = String.Empty, textCore As String = String.Empty, plainTextCore As String = String.Empty, emailCore As String = String.Empty

        Public Sub New()
            dateCore = TutorialConstants.Now
        End Sub

        Private Shared counter As Integer = 0

        Public Sub New(ByVal row As DataRow)
            Me.row = row
            Dim rnd = GetRandomInstance()
            dateCore = TutorialConstants.Now.AddDays(CInt(row("Day"))).AddSeconds(-rnd.Next(10000))
            emailCore = String.Format("{0}", row("From"))
            fromCore = DataHelper.GetNameByEmail(emailCore)
            subjectCore = String.Format("{0}", row("Subject"))
            readCore = Delay > TimeSpan.FromHours(48)
            textCore = String.Format("{0}", row("Text"))
            deletedCore = False
            mailTypeCore = MailType.Inbox
            mailFolderCore = CInt(GetFolder(row))
            plainTextCore = GetPlainText()
            DataTweaking()
        End Sub

        Private Shared Function GetRandomInstance() As Data.Utils.NonCryptographicRandom
            If MainFormHelper.TakeScreens Then
                counter += 1
                Return New Data.Utils.NonCryptographicRandom(counter)
            End If

            Return TutorialConstants.Random
        End Function

        Public ReadOnly Property FullName As String
            Get
                If String.IsNullOrEmpty(emailCore) Then Return fromCore
                Return String.Format("{0} ({1})", fromCore, emailCore)
            End Get
        End Property

        Public Property [Date] As Date
            Get
                Return dateCore
            End Get

            Set(ByVal value As Date)
                dateCore = value
            End Set
        End Property

        Public Property From As String
            Get
                Return fromCore
            End Get

            Set(ByVal value As String)
                fromCore = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return emailCore
            End Get

            Set(ByVal value As String)
                emailCore = value
            End Set
        End Property

        Public Property Subject As String
            Get
                Return subjectCore
            End Get

            Set(ByVal value As String)
                subjectCore = value
            End Set
        End Property

        Public ReadOnly Property SubjectDisplayText As String
            Get
                Return Subject
            End Get
        End Property

        Public ReadOnly Property Attachment As Integer
            Get
                Return If(hasAttachment, 1, 0)
            End Get
        End Property

        Public ReadOnly Property Read As Integer
            Get
                Return If(readCore, 1, 0)
            End Get
        End Property

        Public Property Priority As Integer
            Get
                Return priorityCore
            End Get

            Set(ByVal value As Integer)
                priorityCore = value
            End Set
        End Property

        Public ReadOnly Property IsUnread As Boolean
            Get
                Return Not readCore
            End Get
        End Property

        Friend ReadOnly Property Folder As String
            Get
                Return String.Format("{0}", mailFolderCore)
            End Get
        End Property

        Public Property Text As String
            Get
                Return textCore
            End Get

            Set(ByVal value As String)
                textCore = value
            End Set
        End Property

        Public ReadOnly Property PlainText As String
            Get
                Return GetPlainText()
            End Get
        End Property

        Private Function GetPlainText() As String
            If String.IsNullOrEmpty(plainTextCore) Then
                plainTextCore = ObjectHelper.GetPlainTextFromMHT(CStr(textCore)).Replace(Microsoft.VisualBasic.Constants.vbCrLf, " ")
            End If

            Return plainTextCore
        End Function

        Public Property MailType As MailType
            Get
                Return mailTypeCore
            End Get

            Set(ByVal value As MailType)
                mailTypeCore = value
            End Set
        End Property

        Public Property MailFolder As Integer
            Get
                Return mailFolderCore
            End Get

            Set(ByVal value As Integer)
                If MailFolder = value Then Return
                mailFolderCore = value
                OnPropertyChanged("MailFolder")
            End Set
        End Property

        Public Property Deleted As Boolean
            Get
                Return deletedCore
            End Get

            Set(ByVal value As Boolean)
                deletedCore = value
            End Set
        End Property

        Friend ReadOnly Property Delay As TimeSpan
            Get
                Return TutorialConstants.Now - dateCore
            End Get
        End Property

        Public Sub ToggleRead()
            readCore = Not readCore
        End Sub

        Private Sub DataTweaking()
            If Delay > TimeSpan.FromHours(50) AndAlso Delay < TimeSpan.FromHours(100) Then readCore = False
            If subjectCore.IndexOf("RE:") >= 0 OrElse subjectCore.IndexOf("FW:") >= 0 Then readCore = False
            hasAttachment = textCore.Length > 20000
            If subjectCore.IndexOf("Review") >= 0 OrElse subjectCore.IndexOf("Important") >= 0 Then priorityCore = 2
            If subjectCore.IndexOf("FW:") >= 0 AndAlso Delay > TimeSpan.FromHours(48) Then priorityCore = 0
            If subjectCore.IndexOf("New") >= 0 OrElse subjectCore.IndexOf("Meeting") >= 0 Then mailFolderCore += 1
        End Sub

        Private Function GetFolder(ByVal row As DataRow) As MailFolder
            Dim category As Object = row("CategoryID")
            Dim ret As String = String.Format("{0}", CType((If(category Is DBNull.Value, 1, CInt(category))), MailCategories))
            If String.IsNullOrEmpty(ret) Then Return Demos.MailFolder.All
            Return CType([Enum].Parse(GetType(MailFolder), ret.Replace(" ", "")), MailFolder)
        End Function

        Public Sub SetPlainText(ByVal text As String)
            plainTextCore = text
        End Sub

#Region "INotifyPropertyChanged Members"
        Private Event _propertyChangedEventHandler As PropertyChangedEventHandler

        Private Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                AddHandler _propertyChangedEventHandler, value
            End AddHandler

            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                RemoveHandler _propertyChangedEventHandler, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
                RaiseEvent _propertyChangedEventHandler(sender, e)
            End RaiseEvent
        End Event

        Protected Sub OnPropertyChanged(ByVal name As String)
            RaiseEvent _propertyChangedEventHandler(Me, New PropertyChangedEventArgs(name))
        End Sub
#End Region
    End Class

    Public Class ObjectHelper

        Private Shared rich As RichEditDocumentServer = New RichEditDocumentServer()

        Public Shared Function GetPlainTextFromMHT(ByVal mhtText As String) As String
            rich.MhtText = mhtText
            Return rich.Text.TrimStart()
        End Function

        Public Shared Sub GetChildDataRowHandles(ByVal view As GridView, ByVal rowHandle As Integer, ByVal list As List(Of Message))
            For i As Integer = 0 To view.GetChildRowCount(rowHandle) - 1
                Dim row As Integer = view.GetChildRowHandle(rowHandle, i)
                If row >= 0 Then
                    list.Add(TryCast(view.GetRow(row), Message))
                Else
                    GetChildDataRowHandles(view, row, list)
                End If
            Next
        End Sub
    End Class

    Public Class DataHelper

        Private Shared employeesCore As BindingList(Of Employee) = Nothing

        Private Shared messagesCore As BindingList(Of Message) = Nothing

        Friend Shared ReadOnly Property MailTable As DataTable
            Get
                Dim table As String = "Messages"
                Return CreateDataTable(table)
            End Get
        End Property

        Public Shared Function LoadMessagesAsync() As Threading.Tasks.Task
            If MainFormHelper.TakeScreens Then
                Call LoadMessages()
                PostUpdateMessaged(Nothing)
                Return Nothing
            End If

            Dim context = Data.Helpers.SyncHelper.TryCaptureSynchronizationContext()
            Return Threading.Tasks.Task.Run(Sub()
                If LoadMessages() AndAlso context IsNot Nothing Then context.Post(New Threading.SendOrPostCallback(AddressOf PostUpdateMessaged), Nothing)
            End Sub)
        End Function

        Private Shared Sub PostUpdateMessaged(ByVal state As Object)
            Call messagesCore.ResetBindings()
        End Sub

        Public Shared Function LoadMessages() As Boolean
            Try
                If messagesCore Is Nothing Then
                    messagesCore = New BindingList(Of Message)()
                    Dim tbl As DataTable = MailTable
                    If tbl IsNot Nothing Then
                        messagesCore.RaiseListChangedEvents = False
                        For Each row As DataRow In tbl.Rows
                            Call messagesCore.Add(New Message(row))
                        Next

                        messagesCore.RaiseListChangedEvents = True
                        Return True
                    End If
                End If
            Catch e As Exception
                XtraMessageBox.Show(e.Message, e.Source)
                messagesCore = New BindingList(Of Message)()
            End Try

            Return messagesCore.Count > 0
        End Function

        Public Shared ReadOnly Property Messages As BindingList(Of Message)
            Get
                Call LoadMessages()
                Return messagesCore
            End Get
        End Property

        Friend Shared ReadOnly Property Employees As BindingList(Of Employee)
            Get
                If employeesCore Is Nothing Then
#If Not NET
                    Dim devAvDb As DevAVDb = New DevAVDb()
#Else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={DevExpress.Internal.DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#End If
                    devAvDb.Employees.Load()
                    employeesCore = devAvDb.Employees.Local.ToBindingList()
                End If

                Return employeesCore
            End Get
        End Property

        Public Shared Function GetNameByEmail(ByVal email As String) As String
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) Equals(p.Email, email))
            Return If(employee IsNot Nothing, employee.FullName, String.Empty)
        End Function

        Public Shared Function GetPhotoByEmail(ByVal email As String) As Image
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) Equals(p.Email, email))
            Return If(employee IsNot Nothing AndAlso employee.Picture IsNot Nothing, employee.Photo, Nothing)
        End Function

        Private Shared Function CreateDataTable(ByVal table As String) As DataTable
            Dim dataSet As DataSet = New DataSet()
            Dim dataFile As String = DataDirectoryHelper.GetDataFile("MailDevAv.xml")
            If Not Equals(dataFile, String.Empty) Then
                Dim fi As FileInfo = New FileInfo(dataFile)
                dataSet.ReadXml(fi.FullName)
                Return dataSet.Tables(table)
            End If

            Return Nothing
        End Function

        Public Shared Sub LogoGridLookupGetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemGridLookUpEditWithGlyph = TryCast(sender, RepositoryItemGridLookUpEditWithGlyph)
            If repository Is Nothing OrElse repository.DataSource Is Nothing Then Return
            Dim dt As DataTable = TryCast(repository.DataSource, DataTable)
            Dim row As DataRow = Nothing
            Try
                row = dt.Rows(CInt(e.Value) - 1)
            Catch
            End Try

            If row IsNot Nothing Then
                e.Image = CType(row("Logo"), Byte())
            End If
        End Sub
    End Class

    Public Class PreviewGridView
        Inherits GridView

        Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview As Boolean
            Get
                Return True
            End Get
        End Property
    End Class

    Public Class SaleOverviewData

        Public Sub New()
        End Sub

        Public Sub New(ByVal state As String, ByVal sales As Double, ByVal salesVsTarget As Double, ByVal profit As Double, ByVal customersSatisfaction As Double, ByVal markerShare As Double)
            Me.State = state
            Me.Sales = sales
            Me.Profit = profit
            Me.SalesVsTarget = salesVsTarget
            Me.CustomersSatisfaction = customersSatisfaction
            MarketShare = markerShare
        End Sub

        Public Property State As String

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Sales As Double

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Profit As Double

        <DisplayFormat(DataFormatString:="p", ApplyFormatInEditMode:=True), Display(Name:="Sales vs Target")>
        Public Property SalesVsTarget As Double

        <DisplayFormat(DataFormatString:="p0", ApplyFormatInEditMode:=True)>
        Public Property MarketShare As Double

        <Display(Name:="Satisfaction")>
        Public Property CustomersSatisfaction As Double
    End Class

    Public Module SaleOverviewDataGenerator

        Public Function GenerateSales() As SaleOverviewData()
            Return New SaleOverviewData() {New SaleOverviewData("California", 467949484.42, 0.0276, 44000000, 4.6, .34), New SaleOverviewData("South Dakota", 458113868.36, 0.0482, 27000000, 4.8, .32), New SaleOverviewData("Ohio", 250772304.63, -0.0288, -15000000, 3.4, .29), New SaleOverviewData("Wisconsin", 182660621.53, 0.0598, 14000000, 4.1, .22), New SaleOverviewData("New Hampshire", 158710257.91, 0.0132, 10000000, 4.0, .19), New SaleOverviewData("Maine", 156032947.24, -0.0996, -9000000, 2.9, .14), New SaleOverviewData("Utah", 131496479.72, 0.0445, 18000000, 4.7, .27), New SaleOverviewData("Idaho", 119199535.50, 0.0065, 14000000, 3.9, .30), New SaleOverviewData("Illinois", 102480457.66, -0.0039, 9000000, 4.2, .17), New SaleOverviewData("Washington", 102301309.53, 0.0242, 18000000, 4.6, .26), New SaleOverviewData("Wyoming", 98012761.36, 0.0021, 4000000, 3.7, .31), New SaleOverviewData("Indiana", 95976655.67, 0.0249, -7000000, 2.5, .17), New SaleOverviewData("Nevada", 91535057.56, 0.0284, 23000000, 4.5, .22), New SaleOverviewData("Massachusetts", 90602516.28, 0.0139, 12000000, 4.0, .24), New SaleOverviewData("Rhode Island", 90548513.43, 0.0137, 21000000, 4.4, .29), New SaleOverviewData("Montana", 89977272.49, -0.0049, -5000000, 2.0, .13), New SaleOverviewData("Alabama", 88237187.77, -0.0059, 6000000, 4.6, .15), New SaleOverviewData("Georgia", 88175277.25, 0.0045, 11000000, 4.2, .24), New SaleOverviewData("New York", 87774749.80, 0.0114, 15000000, 3.9, .30), New SaleOverviewData("Texas", 84291394.13, -0.0093, -20000000, 2.9, .13), New SaleOverviewData("Virginia", 83582665.33, -0.0057, 8000000, 3.9, .10), New SaleOverviewData("South Carolina", 83391264.21, 0.0384, 6000000, 4.4, .28), New SaleOverviewData("Missouri", 82106438.59, -0.0144, 2000000, 3.2, .18), New SaleOverviewData("Florida", 81751131.33, 0.0115, 7000000, 4.1, .24), New SaleOverviewData("Mississippi", 81203810.96, 0.0332, 6000000, 4.4, .31), New SaleOverviewData("New Mexico", 80452595.66, 0.0122, 13000000, 4.9, .23), New SaleOverviewData("Kentucky", 79995544.60, 0.0403, 10000000, 4.6, .27), New SaleOverviewData("Connecticut", 73220631.05, 0.0337, 8000000, 2.9, .24), New SaleOverviewData("Arizona", 72989023.31, -0.0094, -4000000, 3.6, .11), New SaleOverviewData("Tennessee", 72877959.11, 0.02915, 14000000, 4.9, .25), New SaleOverviewData("Colorado", 71391979.17, 0.0036, 5000000, 4.1, .28), New SaleOverviewData("Oregon", 70908060.11, 0.0042, 6000000, 4.5, .23), New SaleOverviewData("North Carolina", 70896926.22, -0.0111, -17000000, 3.0, .12), New SaleOverviewData("Michigan", 69466608.80, -0.0083, 3000000, 4.0, .20), New SaleOverviewData("Minnesota", 66473670.35, 0.0099, 8000000, 4.2, .19)}
        End Function
    End Module

    Public Class DemoHelper

        Private Shared categorySvgImagesCore As SvgImageCollection

        Public Shared ReadOnly Property CategorySvgImages As SvgImageCollection
            Get
                If categorySvgImagesCore Is Nothing Then
                    categorySvgImagesCore = New SvgImageCollection()
                    Dim assembly = GetType(DemoHelper).Assembly
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.Beverages.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.condiments.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.confections.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.DairyProduct.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.grains_cereals.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.MeatPoultry.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.produce.svg", assembly)))
                    categorySvgImagesCore.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraGrid.Demos.Resources.Seafood.svg", assembly)))
                End If

                Return categorySvgImagesCore
            End Get
        End Property

        Public Shared Sub AddCategoryImagesToEdit(ByVal edit As RepositoryItemImageComboBox)
            If edit IsNot Nothing Then
                edit.SmallImages = CategorySvgImages
                edit.DropDownRows = CategorySvgImages.Count
            End If
        End Sub

        Public Shared Function GetTransmissionGlyphs() As ImageCollection
            Dim result As ImageCollection = New ImageCollection()
            result.ImageSize = ScaleUtils.ScaleValue(New Size(15, 15))
            Dim options As StubGlyphOptions = New StubGlyphOptions()
            options.ColorMode = GlyphColorMode.Red
            result.AddImage(CreateStubGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A")
            options.ColorMode = GlyphColorMode.Green
            result.AddImage(CreateStubGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M")
            options.ColorMode = GlyphColorMode.Blue
            result.AddImage(CreateStubGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V")
            options.ColorMode = GlyphColorMode.Yellow
            result.AddImage(CreateStubGlyph("Ltd", result.ImageSize, options, UserLookAndFeel.Default), "Ltd")
            Return result
        End Function

        Private Shared Function CreateStubGlyph(ByVal text As String, ByVal glyphSize As Size, ByVal options As StubGlyphOptions, ByVal skinProvider As ISkinProvider) As Image
            Dim img = New Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(img)
                Using cache As GraphicsCache = New GraphicsCache(g)
                    Call GlyphPainter.Default.DrawGlyph(cache, options, text, New Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal)
                End Using
            End Using

            Return img
        End Function
    End Class

    Public Class VehiclesData

        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")>
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum

        Public Class Trademark

            Private captionLogoCore As Bitmap = Nothing

            Public Property ID As Integer

            Public Property Logo As Image

            Public Property Name As String

            Public ReadOnly Property CaptionLogo As Bitmap
                Get
                    If captionLogoCore Is Nothing Then captionLogoCore = ResizeImage(Logo, 24, 70)
                    Return captionLogoCore
                End Get
            End Property
        End Class

        Public Class OrderItem

            Friend Model As Model

            Public Sub New(ByVal totalCount As Integer, ByVal models As List(Of Model), ByVal id As Integer)
                Me.New(totalCount, models(id Mod models.Count), id)
            End Sub

            Public Sub New(ByVal totalCount As Integer, ByVal model As Model, ByVal id As Integer)
                Me.Model = model
                ModelPrice = model.Price
                Trademark = model.Trademark
                Name = model.Name
                Modification = model.Modification
                Category = model.Category
                MPGCity = model.MPGCity
                MPGHighway = model.MPGHighway
                Doors = model.Doors
                BodyStyle = model.BodyStyle
                Cylinders = model.Cylinders
                Horsepower = model.Horsepower
                Torque = model.Torque
                TransmissionSpeeds = model.TransmissionSpeeds
                TransmissionType = model.TransmissionType
                Discount = Math.Round(0.05 * (id * Trademark Mod 4), 2)
                OrderID = id
                If totalCount > 0 Then CreateSalesInfo(id, totalCount)
            End Sub

            Private Sub CreateSalesInfo(ByVal id As Integer, ByVal totalCount As Integer)
                Dim salesPerDay = totalCount / (365.25 * 7)
                Dim lastSaleDateTime = TutorialConstants.Today.AddHours(-15)
                SalesDate = lastSaleDateTime.AddDays(-id / salesPerDay)
                Dim orderWithinYearId = CInt(Math.Floor((SalesDate - New DateTime(SalesDate.Year, 1, 1)).TotalDays * salesPerDay)) + 1
                SalesID = String.Format("{0:d4}-<size=-1><b>{1:d6}</b>", SalesDate.Year, orderWithinYearId)
            End Sub

            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal rnd As Data.Utils.NonCryptographicRandom, ByVal id As Integer)
                Me.New(-1, model, id)
                Discount = Math.Round(0.05 * rnd.Next(4), 2)
                SalesDate = TutorialConstants.Now.AddDays(-rnd.Next(days))
            End Sub

            Public Property OrderID As Integer

            Public Property SalesID As String

            <CustomFunction(IsWeekendFunction.FunctionName)>
            Public Property SalesDate As Date

            <CustomFunction(IsBlackFridayDiscountFunction.FunctionName)>
            Public Property Discount As Double

            <DataType(DataType.Currency)>
            Public Property ModelPrice As Decimal

            Public Property Trademark As Integer

            Public Property Name As String

            Public Property Modification As String

            Public Property Category As Integer

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            Public Property BodyStyle As Integer

            Public Property Cylinders As Integer

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            Public Property TransmissionType As Integer

            Public ReadOnly Property Photo As Image
                Get
                    Return Model.Photo
                End Get
            End Property
        End Class

        Public Class Model

            Public Property ID As Integer

            Public Property Trademark As Integer

            Public Property Name As String

            Public Property Modification As String

            Public Property Category As Integer

            Public Property Price As Decimal

            Public Property MPGCity As Integer?

            Public Property MPGHighway As Integer?

            Public Property Doors As Integer

            Public Property BodyStyle As Integer

            Public Property Cylinders As Integer

            Public Property Horsepower As String

            Public Property Torque As String

            Public Property TransmissionSpeeds As Integer

            Public Property TransmissionType As Integer

            Public Property Description As String

            Public Property Photo As Image

            Public Property DeliveryDate As Date

            Public Property InStock As Boolean

            Public ReadOnly Property TrademarkImage As Image
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Logo, Nothing)
                End Get
            End Property

            Public ReadOnly Property TrademarkName As String
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Name, String.Empty)
                End Get
            End Property

            Public ReadOnly Property CategoryName As String
                Get
                    Return EnumDisplayTextHelper.GetDisplayText(CType(Category, Category))
                End Get
            End Property

            Public Function GetSmallTrademarkImage() As Bitmap
                Return Trademarks(Trademark - 1).CaptionLogo
            End Function

            Public Trademarks As List(Of Trademark) = Nothing

            Friend Property LicenseInfo As String
        End Class

        Public Shared Function ResizeImage(ByVal image As Image, ByVal height As Integer, ByVal maxWidth As Integer) As Bitmap
            Dim width As Integer = Math.Min(image.Width * height \ image.Height, maxWidth)
            Dim heightImage As Integer = image.Height * width \ image.Width
            Dim destRect As Rectangle = New Rectangle(0, (height - heightImage) \ 2, width, heightImage)
            Dim destImage As Bitmap = New Bitmap(width, height)
            Using graphics As Graphics = Graphics.FromImage(destImage)
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel)
            End Using

            Return destImage
        End Function

        Public Shared Sub LogoGridLookupGetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemGridLookUpEditWithGlyph = TryCast(sender, RepositoryItemGridLookUpEditWithGlyph)
            If repository Is Nothing OrElse repository.DataSource Is Nothing Then Return
            Dim list As List(Of Trademark) = TryCast(repository.DataSource, List(Of Trademark))
            Dim val As Integer = CInt(e.Value)
            If val > 0 Then e.Image = list(CInt(e.Value) - 1).Logo
        End Sub

        Public Shared Sub InitXMLDataAndCreateEditors(ByVal connectionString As String, ByVal grid As GridControl, <Out> ByRef models As List(Of Model), <Out> ByRef trademarks As List(Of Trademark))
            Dim ds As DataSet = Nothing
            models = InitXMLDataCore(connectionString, ds, trademarks)
            CreateEditors(grid, ds, trademarks)
            Call InitColumnViewEditors(TryCast(grid.MainView, ColumnView))
        End Sub

        Public Shared Sub InitOrdersData(ByVal dataFileName As String, ByVal grid As GridControl, ByVal itemCount As Integer, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listModels As List(Of Model) = InitXMLDataCore(dataFileName, ds, listTrademarks, 1)
            Dim orders As List(Of OrderItem) = New List(Of OrderItem)()
            For i As Integer = 0 To itemCount - 1
                orders.Add(New OrderItem(listModels(TutorialConstants.Random.Next(0, listModels.Count - 1)), dataInterval, TutorialConstants.Random, i + 1))
            Next

            grid.DataSource = orders
            CreateEditors(grid, ds, listTrademarks)
        End Sub

        Public Shared Function InitOrdersVirtualData(ByVal dataFileName As String, ByVal grid As GridControl) As List(Of Model)
            Dim ds As DataSet = Nothing
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listModels As List(Of Model) = InitXMLDataCore(dataFileName, ds, listTrademarks, 1)
            CreateEditors(grid, ds, listTrademarks)
            Return listModels
        End Function

        Public Shared Sub InitXMLData(ByVal dataFileName As String, ByVal grid As GridControl)
            InitXMLData(dataFileName, grid, 30)
        End Sub

        Public Shared Sub InitXMLData(ByVal dataFileName As String, ByVal grid As GridControl, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listModels As List(Of Model) = InitXMLDataCore(dataFileName, ds, listTrademarks, dataInterval)
            SetGridDataSource(listModels, grid)
            CreateEditors(grid, ds, listTrademarks)
        End Sub

        Private Shared Sub CreateEditors(ByVal grid As GridControl, ByVal ds As DataSet, ByVal listTrademarks As List(Of Trademark))
            CreateSimpleLookUpEdit(grid, ds.Tables("Category"), "/Category")
            CreateSimpleLookUpEdit(grid, ds.Tables("BodyStyle"), "/BodyStyle")
            CreateSimpleLookUpEdit(grid, ds.Tables("TransmissionType"), "/TransmissionType")
            CreateTrademarkLookUpEdit(grid, listTrademarks, "/Trademark")
            CreateSpinEdit(grid, "/MPGCity/MPGHighway", 100, 1)
            CreateSpinEdit(grid, "/Doors", 10, 1)
            CreateSpinEdit(grid, "/Cylinders", 20, 1)
            CreateSpinEdit(grid, "/TransmissionSpeeds", 20, -1)
            CreateCurrencyEdit(grid, "/Price/ModelPrice")
            CreatePictureEdit(grid, "/TrademarkImage/Photo/Image")
        End Sub

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark)) As List(Of Model)
            Return InitXMLDataCore(dataFileName, ds, listTrademarks, 30)
        End Function

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, <Out> ByRef ds As DataSet, <Out> ByRef listTrademarks As List(Of Trademark), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            ds = GetDataSet(dataFileName)
            listTrademarks = New List(Of Trademark)()
            For Each row As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New Trademark() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Logo = ByteImageConverter.FromByteArray(CType(row("Logo"), Byte()))})
            Next

            Dim listModels = New List(Of Model)()
            For Each row As DataRow In ds.Tables(Model).Rows
                listModels.Add(New Model() With {.ID = CInt(row("ID")), .Name = CStr(row("Name")), .Trademark = CInt(row("TrademarkID")), .Modification = CStr(row("Modification")), .Category = CInt(row("CategoryID")), .Price = CDec(row("Price")), .MPGCity = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG City"), Integer?)), .MPGHighway = If(DBNull.Value.Equals(row("MPG City")), Nothing, CType(row("MPG Highway"), Integer?)), .Doors = CInt(row("Doors")), .BodyStyle = CInt(row("BodyStyleID")), .Cylinders = CInt(row("Cylinders")), .Horsepower = CStr(row("Horsepower")), .Torque = CStr(row("Torque")), .TransmissionSpeeds = Convert.ToInt32(row("Transmission Speeds")), .TransmissionType = CInt(row("Transmission Type")), .Description = String.Format("{0}", row("Description")), .Photo = ByteImageConverter.FromByteArray(CType(row("Photo"), Byte())), .DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)), .InStock = TutorialConstants.Random.Next(100) < 95, .Trademarks = listTrademarks, .LicenseInfo = GetLicenseInfo(row)})
            Next

            Return listModels
        End Function

        Friend Shared Function GetLicenseInfo(ByVal row As DataRow) As String
            Return $"{row("License Name")}|{row("Author")}|{row("Source")}|{row("Edits")}"
        End Function

        Private ReadOnly Shared dataSets As Dictionary(Of String, DataSet) = New Dictionary(Of String, DataSet)()

        Private Shared Function GetDataSet(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = Nothing
            If Not dataSets.TryGetValue(dataFileName, ds) Then
                ds = New DataSet()
                ds.ReadXml(dataFileName)
                dataSets.Add(dataFileName, ds)
            End If

            Return ds
        End Function

        Public Shared Sub InitColumnViewEditors(ByVal view As ColumnView)
            If view.Columns.Count = 0 Then Return
            For Each col As GridColumn In view.Columns
                Dim item As RepositoryItem = GetEditByFielsName(col.FieldName, view.GridControl.RepositoryItems)
                If item IsNot Nothing AndAlso col.ColumnEdit Is Nothing Then col.ColumnEdit = item
            Next

            Dim gView As GridView = TryCast(view, GridView)
            If gView IsNot Nothing Then
                gView.GroupSummary.Add(SummaryItemType.Count, "ID")
                SetColumnCurrencyFormat(gView, New String() {"Price", "ModelPrice"})
            End If

            Dim colDeliveryDate As GridColumn = view.Columns("DeliveryDate")
            If colDeliveryDate IsNot Nothing Then colDeliveryDate.GroupInterval = ColumnGroupInterval.DateRange
        End Sub

        Private Shared Sub SetColumnCurrencyFormat(ByVal view As GridView, ByVal names As String())
            For Each name As String In names
                Dim colCurrency As GridColumn = view.Columns(name)
                If colCurrency IsNot Nothing Then
                    colCurrency.DisplayFormat.FormatType = FormatType.Numeric
                    colCurrency.DisplayFormat.FormatString = "c"
                End If
            Next
        End Sub

        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each item As RepositoryItem In repositoryItemCollection
                If item.Name.IndexOf("/" & fieldName) >= 0 Then Return item
            Next

            Return Nothing
        End Function

        Private Shared Function CreatePictureEdit(ByVal grid As GridControl, ByVal name As String) As RepositoryItemPictureEdit
            Dim ret As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            grid.RepositoryItems.Add(ret)
            ret.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            ret.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreateCurrencyEdit(ByVal grid As GridControl, ByVal name As String) As RepositoryItemTextEdit
            Dim ret As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Mask.MaskType = XtraEditors.Mask.MaskType.Numeric
            ret.Mask.EditMask = "c"
            ret.Mask.UseMaskAsDisplayFormat = True
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreateSpinEdit(ByVal grid As GridControl, ByVal name As String, ByVal maxValue As Integer, ByVal minValue As Integer) As RepositoryItemSpinEdit
            Dim ret As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.IsFloatValue = False
            ret.Mask.EditMask = "N00"
            ret.MaxValue = maxValue
            ret.MinValue = minValue
            ret.Name = name
            Return ret
        End Function

        Private Shared Function CreateSimpleLookUpEdit(ByVal grid As GridControl, ByVal tbl As DataTable, ByVal name As String) As RepositoryItemLookUpEdit
            Dim ret As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Columns.AddRange(New XtraEditors.Controls.LookUpColumnInfo() {New XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
            ret.PopupFormMinSize = New Size(100, 0)
            ret.DisplayMember = "Name"
            ret.Name = name
            ret.ShowFooter = False
            ret.ShowHeader = False
            ret.ValueMember = "ID"
            ret.DataSource = tbl
            ret.DropDownRows = tbl.Rows.Count
            Return ret
        End Function

        Private Shared Function CreateTrademarkLookUpEdit(ByVal grid As GridControl, ByVal ds As Object, ByVal name As String) As RepositoryItemGridLookUpEditWithGlyph
            Dim ret As RepositoryItemGridLookUpEditWithGlyph = New RepositoryItemGridLookUpEditWithGlyph()
            Dim picture As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.DisplayMember = "Name"
            ret.Name = name
            picture.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            picture.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            ret.RepositoryItems.AddRange(New RepositoryItem() {picture})
            ret.ValueMember = "ID"
            Dim view As GridView = New GridView()
            ret.View = view
            Dim colLogo As GridColumn = New GridColumn()
            Dim colName As GridColumn = New GridColumn()
            view.Columns.AddRange(New GridColumn() {colLogo, colName})
            view.FocusRectStyle = DrawFocusRectStyle.RowFocus
            view.OptionsSelection.EnableAppearanceFocusedCell = False
            view.OptionsView.RowAutoHeight = True
            view.OptionsView.ShowColumnHeaders = False
            view.OptionsView.ShowGroupPanel = False
            view.OptionsView.ShowIndicator = False
            colLogo.ColumnEdit = picture
            colLogo.FieldName = "Logo"
            colLogo.Visible = True
            colLogo.VisibleIndex = 0
            colName.FieldName = "Name"
            colName.Visible = True
            colName.VisibleIndex = 1
            ret.DataSource = ds
            Return ret
        End Function

        Private Shared Sub SetGridDataSource(ByVal ds As Object, ByVal grid As GridControl)
            grid.DataMember = Nothing
            grid.DataSource = ds
        End Sub

        Private Shared Sub repositoryItemGridLookUpEdit1_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            LogoGridLookupGetImageByValue(sender, e)
        End Sub
    End Class

    Public Class ImageHelper

        Private Shared images As Dictionary(Of String, Bitmap) = New Dictionary(Of String, Bitmap)()

        Public Shared Function CreateSenderImage(ByVal sender As String, ByVal size As Size, ByVal ulf As UserLookAndFeel) As Bitmap
            Dim img As Bitmap = Nothing
            If images.TryGetValue(sender, img) Then Return img
            Dim imageSize As Size = New Size(size.Width, size.Height)
            Dim parsedText As String() = sender.Split(" "c)
            Dim result As String = String.Empty
            Dim count As Integer = 0
            For i As Integer = 0 To parsedText.Length - 1
                If parsedText(i).Length > 0 Then
                    result += parsedText(i)(0)
                    count += 1
                    If count = 2 Then Exit For
                End If
            Next

            img = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result)
            images.Add(sender, img)
            Return img
        End Function
    End Class
End Namespace
