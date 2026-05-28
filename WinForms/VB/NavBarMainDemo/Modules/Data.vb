Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraRichEdit
Imports DevExpress.DevAV
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
#If Not NET
Imports System.Data.Entity

#Else
using Microsoft.EntityFrameworkCore;
#End If
Namespace DevExpress.XtraNavBar.Demos

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

    Public Class Message
        Implements INotifyPropertyChanged

        Private dateCore As Date

        Private readCore, deletedCore, hasAttachment As Boolean

        Private priorityCore As Integer = 1

        Private mailTypeCore As MailType

        Private mailFolderCore As Integer

        Private fromCore As String = String.Empty, subjectCore As String = String.Empty, textCore As String = String.Empty, plainTextCore As String = String.Empty, emailCore As String = String.Empty

        Public Sub New()
            dateCore = TutorialConstants.Now
        End Sub

        Public Sub New(ByVal row As DataRow)
            dateCore = TutorialConstants.Now.AddDays(CInt(row("Day"))).AddSeconds(-TutorialConstants.Random.Next(10000))
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
        Private Event propertyChangedEventHandler As PropertyChangedEventHandler

        Private Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                AddHandler propertyChangedEventHandler, value
            End AddHandler

            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                RemoveHandler propertyChangedEventHandler, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
                RaiseEvent propertyChangedEventHandler(sender, e)
            End RaiseEvent
        End Event

        Protected Sub OnPropertyChanged(ByVal name As String)
            RaiseEvent propertyChangedEventHandler(Me, New PropertyChangedEventArgs(name))
        End Sub
#End Region
    End Class

    '
    Public Class ObjectHelper

        Private ReadOnly Shared rich As RichEditDocumentServer = New RichEditDocumentServer()

        Public Shared Function GetPlainTextFromMHT(ByVal mhtText As String) As String
            rich.MhtText = mhtText
            Return rich.Text.TrimStart()
        End Function
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
            Dim context = Data.Helpers.SyncHelper.TryCaptureSynchronizationContext()
            Return Threading.Tasks.Task.Run(Sub()
                If LoadMessages() AndAlso context IsNot Nothing Then context.Post(New Threading.SendOrPostCallback(AddressOf PostMessagesUpdate), Nothing)
            End Sub)
        End Function

        Private Shared Sub PostMessagesUpdate(ByVal state As Object)
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
                    DevAVDb devAvDb = new DevAVDb($"Data Source={Internal.DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
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
    End Class

    Public Class VehiclesData

        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")>
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum

        Public Enum BodyStyle
            Convertible = 1
            Coupe = 2
            Hatchback = 3
            <Display(Name:="Passenger Van")>
            PassengerVan = 4
            Pickup = 5
            Sedan = 6
            <Display(Name:="Sport Utility Vehicle")>
            SportUtilityVehicle = 7
            Wagon = 8
        End Enum

        Public Enum TransmissionType
            Automatic = 1
            Manual = 2
        End Enum

        Public Class Trademark

            Public Property ID As Integer

            Public Property Logo As Image

            Public Property Name As String
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

            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal id As Integer)
                Me.New(-1, model, id)
                Discount = Math.Round(0.05 * TutorialConstants.Random.Next(4), 2)
                SalesDate = TutorialConstants.Now.AddDays(-TutorialConstants.Random.Next(days))
            End Sub

            Public Property OrderID As Integer

            Public Property SalesID As String

            Public Property SalesDate As Date

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

            Public ReadOnly Property BodyStyleName As String
                Get
                    Return EnumDisplayTextHelper.GetDisplayText(CType(BodyStyle, BodyStyle))
                End Get
            End Property

            Public ReadOnly Property TransmissionTypeName As String
                Get
                    Return EnumDisplayTextHelper.GetDisplayText(CType(TransmissionType, TransmissionType))
                End Get
            End Property

            Public Trademarks As List(Of Trademark) = Nothing

            Friend Property LicenseInfo As String
        End Class

        Public Shared Function InitXMLDataCore(ByVal dataFileName As String) As List(Of Model)
            Return InitXMLDataCore(dataFileName, 30)
        End Function

        Private Shared Function InitXMLDataCore(ByVal dataFileName As String, ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            Dim ds As DataSet = GetDataSet(dataFileName)
            Dim listTrademarks As List(Of Trademark) = New List(Of Trademark)()
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
    End Class
End Namespace
