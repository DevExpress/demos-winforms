Imports System
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.DXperience.Demos
Imports DevExpress.WindowsMailClient.Win.Model
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit

Namespace DevExpress.WindowsMailClient.Win.Data

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
        Unknown
        Inbox
        Deleted
        Sent
        Draft
        Clutter
        Outbox
        Archive
        Archive1
    End Enum

    Public Class MailData

        Private _row As DataRow

        Public Sub New(ByVal row As DataRow)
            _row = row
        End Sub

        Public ReadOnly Property Row As DataRow
            Get
                Return _row
            End Get
        End Property

        Public Property Priority As Integer
            Get
                Return CInt(_row("Priority"))
            End Get

            Set(ByVal value As Integer)
                _row("Priority") = value
            End Set
        End Property

        Public ReadOnly Property Attachment As Integer
            Get
                Return CInt(_row("Attachment"))
            End Get
        End Property

        Public Property Read As Integer
            Get
                Return CInt(_row("Read"))
            End Get

            Set(ByVal value As Integer)
                _row("Read") = value
            End Set
        End Property

        Public Property Flag As Integer
            Get
                Return CInt(_row("Flag"))
            End Get

            Set(ByVal value As Integer)
                _row("Flag") = value
            End Set
        End Property

        Public ReadOnly Property Subject As String
            Get
                Return String.Format("{0}", _row("Subject"))
            End Get
        End Property

        Public ReadOnly Property From As String
            Get
                Return String.Format("{0}", _row("From"))
            End Get
        End Property
    End Class

    Public Class Message

        Private _row As DataRow

        Private _date As Date

        Private _read, _deleted, _hasAttachment As Boolean

        Private _priority As Integer = 1

        Private _mailType As MailType

        Private _mailFolder As Integer

        Private _from As String = String.Empty, _subject As String = String.Empty, _text As String = String.Empty, _plainText As String = String.Empty, _email As String = String.Empty

        Public Sub New()
            _date = TutorialConstants.Now
        End Sub

        Public Sub New(ByVal row As DataRow)
            _row = row
            _date = TutorialConstants.Now.AddDays(CInt(row("Day"))).AddSeconds(-TutorialConstants.Random.Next(10000))
            _email = String.Format("{0}", row("From"))
            _from = MailClientDataModel.GetNameByEmail(_email)
            _subject = String.Format("{0}", row("Subject"))
            _read = Delay > TimeSpan.FromHours(48)
            _text = String.Format("{0}", row("Text"))
            _deleted = False
            _mailType = MailType.Inbox
            _mailFolder = CInt(GetFolder(row))
            _plainText = GetPlainText()
            DataTweaking()
        End Sub

        Public ReadOnly Property FullName As String
            Get
                If String.IsNullOrEmpty(_email) Then Return _from
                Return String.Format("{0} ({1})", _from, _email)
            End Get
        End Property

        Public Property [Date] As Date
            Get
                Return _date
            End Get

            Set(ByVal value As Date)
                _date = value
            End Set
        End Property

        Public Property From As String
            Get
                Return _from
            End Get

            Set(ByVal value As String)
                _from = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get

            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        Public Property Subject As String
            Get
                Return _subject
            End Get

            Set(ByVal value As String)
                _subject = value
            End Set
        End Property

        Public ReadOnly Property SubjectDisplayText As String
            Get
                Return Subject
            End Get
        End Property

        Public ReadOnly Property Attachment As Integer
            Get
                Return If(_hasAttachment, 1, 0)
            End Get
        End Property

        Public ReadOnly Property Read As Integer
            Get
                Return If(_read, 1, 0)
            End Get
        End Property

        Public Property Priority As Integer
            Get
                Return _priority
            End Get

            Set(ByVal value As Integer)
                _priority = value
            End Set
        End Property

        Public ReadOnly Property IsUnread As Boolean
            Get
                Return Not _read
            End Get
        End Property

        Public Property Flagged As Integer

        Friend ReadOnly Property Folder As String
            Get
                Return String.Format("{0}", _mailFolder)
            End Get
        End Property

        Public Property Text As String
            Get
                Return _text
            End Get

            Set(ByVal value As String)
                _text = value
            End Set
        End Property

        Public ReadOnly Property PlainText As String
            Get
                Return GetPlainText()
            End Get
        End Property

        Private Function GetPlainText() As String
            If String.IsNullOrEmpty(_plainText) Then
                _plainText = ObjectHelper.GetPlainTextFromMHT(CStr(_text)).Replace(Microsoft.VisualBasic.Constants.vbCrLf, " ")
            End If

            Return _plainText
        End Function

        Public Property MailType As MailType
            Get
                Return _mailType
            End Get

            Set(ByVal value As MailType)
                _mailType = value
            End Set
        End Property

        Public Property MailFolder As Integer
            Get
                Return _mailFolder
            End Get

            Set(ByVal value As Integer)
                If MailFolder = value Then Return
                _mailFolder = value
            End Set
        End Property

        Public Property Deleted As Boolean
            Get
                Return _deleted
            End Get

            Set(ByVal value As Boolean)
                _deleted = value
            End Set
        End Property

        Friend ReadOnly Property Delay As TimeSpan
            Get
                Return TutorialConstants.Now - _date
            End Get
        End Property

        Public Sub ToggleRead()
            _read = Not _read
        End Sub

        Private Sub DataTweaking()
            If Delay > TimeSpan.FromHours(50) AndAlso Delay < TimeSpan.FromHours(100) Then _read = False
            If _subject.IndexOf("RE:") >= 0 OrElse _subject.IndexOf("FW:") >= 0 Then _read = False
            _hasAttachment = _text.Length > 20000
            If _subject.IndexOf("Review") >= 0 OrElse _subject.IndexOf("Important") >= 0 Then _priority = 2
            If _subject.IndexOf("FW:") >= 0 AndAlso Delay > TimeSpan.FromHours(48) Then _priority = 0
            If _subject.IndexOf("New") >= 0 OrElse _subject.IndexOf("Meeting") >= 0 Then _mailFolder += 1
        End Sub

        Private Function GetFolder(ByVal row As DataRow) As MailFolder
            Dim category As Object = row("CategoryID")
            Dim ret As String = String.Format("{0}", CType((If(category Is DBNull.Value, 1, CInt(category))), MailCategories))
            If String.IsNullOrEmpty(ret) Then Return Data.MailFolder.All
            Return CType([Enum].Parse(GetType(MailFolder), ret.Replace(" ", "")), MailFolder)
        End Function

        Public Sub SetPlainText(ByVal text As String)
            _plainText = text
        End Sub
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
End Namespace
