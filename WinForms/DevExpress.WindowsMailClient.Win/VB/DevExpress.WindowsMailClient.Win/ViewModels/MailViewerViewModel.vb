Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.WindowsMailClient.Win.Data
Imports DevExpress.WindowsMailClient.Win.Model
Imports DevExpress.WindowsMailClient.Win.Modules
Imports DevExpress.WindowsMailClient.Win.Properties
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.WindowsMailClient.Win.ViewModels

    Public Class MailViewerViewModel

        Public Event MessageDeleted As EventHandler

        Public Event MessageChanged As EventHandler

        Public Event FilterChanged As EventHandler

        Public Event SortInfoChanged As EventHandler

        Public Event MessageFlagged As EventHandler

        Public Overridable Property LayoutHeaderVisibility As LayoutVisibility

        Public Overridable Property FocusedItemVisibility As LayoutVisibility

        Public Overridable Property OtherItemVisibility As LayoutVisibility

        Public Overridable Property SortInfo As GridColumnSortInfo

        Protected Sub OnSortInfoChanged()
            AnimateArrival = True
            RaiseEvent SortInfoChanged(Me, EventArgs.Empty)
        End Sub

        Public Overridable Property LabelText As String

        Public Overridable Property CurrentMailType As MailType

        Protected Sub OnCurrentMailTypeChanging(ByVal currentMailType As MailType)
            Select Case currentMailType
                Case MailType.Outbox
                    ChangeSettings("Outbox", currentMailType)
                Case MailType.Archive
                    ChangeSettings("Archive", currentMailType)
                Case MailType.Archive1
                    ChangeSettings("Archive1", currentMailType)
                Case MailType.Clutter
                    ChangeSettings("Clutter", currentMailType)
                Case MailType.Sent
                    ChangeSettings("Sent Items", currentMailType)
                Case MailType.Draft
                    ChangeSettings("Drafts", currentMailType)
                Case MailType.Deleted
                    ChangeSettings("Deleted", currentMailType)
                Case Else
                    RefreshFilter(CurrentFilterType)
                    LabelText = "Inbox"
                    UpdateLabelsVisibility()
            End Select
        End Sub

        Private Sub UpdateLabelsVisibility()
            LayoutHeaderVisibility = If(ShowFocusedOtherFilter, LayoutVisibility.Never, LayoutVisibility.Always)
            FocusedItemVisibility = If(ShowFocusedOtherFilter, LayoutVisibility.Always, LayoutVisibility.Never)
            OtherItemVisibility = If(ShowFocusedOtherFilter, LayoutVisibility.Always, LayoutVisibility.Never)
        End Sub

        Private Sub ChangeSettings(ByVal text As String, ByVal currentMailType As MailType)
            LabelText = text
            LayoutHeaderVisibility = LayoutVisibility.Always
            FocusedItemVisibility = LayoutVisibility.Never
            OtherItemVisibility = LayoutVisibility.Never
            ActiveFilter = New BinaryOperator("MailType", currentMailType, BinaryOperatorType.Equal)
            RaiseEvent FilterChanged(Me, EventArgs.Empty)
        End Sub

        Public Overridable Property ActiveFilter As CriteriaOperator

        Public Overridable Property CurrentFilterType As FilterType

        Protected Sub OnCurrentFilterTypeChanging(ByVal currentFilterType As FilterType)
            RefreshFilter(currentFilterType)
        End Sub

        Private Sub RefreshFilter(ByVal currentFilterType As FilterType)
            Dim inboxOperator = New BinaryOperator("MailType", MailType.Inbox, BinaryOperatorType.Equal)
            If currentFilterType = FilterType.Other Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("Priority", 1, BinaryOperatorType.Equal), inboxOperator, BinaryOperatorType.BitwiseAnd)
            ElseIf currentFilterType = FilterType.Focused Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("Priority", 2, BinaryOperatorType.Equal), inboxOperator, BinaryOperatorType.BitwiseAnd)
            Else
                ActiveFilter = New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal)
            End If

            RaiseEvent FilterChanged(Me, EventArgs.Empty)
        End Sub

        Public Overridable Property AnimateArrival As Boolean

        Public Overridable Property CurrentMessage As Message

        Protected Sub OnCurrentMessageChanged()
            RaiseEvent MessageChanged(Me, EventArgs.Empty)
        End Sub

#Region "Commands"
        <Command>
        Public Sub Sort(ByVal info As SortInfo)
            SortInfo = New GridColumnSortInfo(info.Column, info.Order)
        End Sub

        <Command>
        Public Sub SetFilterImportance()
            AnimateArrival = True
            If Not ReferenceEquals(ActiveFilter, Nothing) Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), New BinaryOperator("Priority", 2, BinaryOperatorType.Equal), BinaryOperatorType.BitwiseAnd)
            Else
                ActiveFilter = New BinaryOperator("Priority", 2, BinaryOperatorType.Equal)
            End If
        End Sub

        <Command>
        Public Sub SetFilterType(ByVal type As FilterType)
            CurrentFilterType = type
        End Sub

        <Command>
        Public Sub SetFilterYesterday()
            AnimateArrival = True
            If Not ReferenceEquals(ActiveFilter, Nothing) Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), New BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), TutorialConstants.Today.Date), BinaryOperatorType.BitwiseAnd)
            Else
                ActiveFilter = New BetweenOperator("Date", TutorialConstants.Today.Date.AddHours(-24), TutorialConstants.Today.Date)
            End If
        End Sub

        <Command>
        Public Sub SetFilterToday()
            AnimateArrival = True
            If Not ReferenceEquals(ActiveFilter, Nothing) Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), New BetweenOperator("Date", TutorialConstants.Today.Date, TutorialConstants.Today.Date.AddHours(24)), BinaryOperatorType.BitwiseAnd)
            Else
                ActiveFilter = New BetweenOperator("Date", TutorialConstants.Today.Date, TutorialConstants.Today.Date.AddHours(24))
            End If
        End Sub

        <Command>
        Public Sub SetFilterUnread()
            AnimateArrival = True
            If Not ReferenceEquals(ActiveFilter, Nothing) Then
                ActiveFilter = New BinaryOperator(New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal), New BinaryOperator("Read", 0, BinaryOperatorType.Equal), BinaryOperatorType.BitwiseAnd)
            Else
                ActiveFilter = New BinaryOperator("Read", 0, BinaryOperatorType.Equal)
            End If
        End Sub

        <Command>
        Public Sub SetFilterAll()
            AnimateArrival = True
            If CurrentMailType = MailType.Inbox Then
                RefreshFilter(CurrentFilterType)
            Else
                ActiveFilter = New BinaryOperator("MailType", CurrentMailType, BinaryOperatorType.Equal)
            End If
        End Sub

        <Command>
        Public Sub SendMessage(ByVal message As Message)
            Messenger.Default.Send(message)
        End Sub

        <Command>
        Public Sub DeleteMessage(ByVal selectedMessage As Message)
            If selectedMessage Is Nothing Then Return
            If selectedMessage.MailType = MailType.Deleted Then
                selectedMessage.Deleted = True
            Else
                If selectedMessage.MailType = MailType.Draft Then
                    selectedMessage.MailType = MailType.Deleted
                    SendMessage(selectedMessage)
                End If

                selectedMessage.MailType = MailType.Deleted
            End If

            RaiseEvent MessageDeleted(Me, EventArgs.Empty)
        End Sub

        <Command>
        Public Sub SetMessageFlaged(ByVal selectedMessage As Message)
            selectedMessage.Flagged += 1
            RaiseEvent MessageFlagged(Me, EventArgs.Empty)
        End Sub

        <Command>
        Public Sub EditMessage(ByVal selectedMessage As Message)
            If selectedMessage Is Nothing Then Return
            If selectedMessage.MailType <> MailType.Deleted AndAlso Not selectedMessage.Deleted Then
                Dim message As Message = New Message()
                message.MailType = MailType.Draft
                message.Subject = selectedMessage.Subject
                message.Email = MessageFrom
                message.From = selectedMessage.Email
                message.Text = selectedMessage.Text
                SendMessage(message)
            End If
        End Sub

        <Command>
        Public Sub ReplyMessage(ByVal selectedMessage As Message)
            If selectedMessage Is Nothing Then Return
            If selectedMessage.MailType <> MailType.Deleted AndAlso Not selectedMessage.Deleted Then
                Dim message As Message = CreateReplyMessage(selectedMessage)
                SendMessage(message)
            End If
        End Sub

#End Region
        Public Sub RegisterAsRecipient()
            Call Messenger.Default.Register(Me, New Action(Of Boolean)(AddressOf OnBoolMessage))
        End Sub

        Public Event ShowFocusedOtherChanged As EventHandler

        Private _showFocusedOtherFilter As Boolean = True

        Public ReadOnly Property ShowFocusedOtherFilter As Boolean
            Get
                Return _showFocusedOtherFilter
            End Get
        End Property

        Private Sub OnBoolMessage(ByVal showFocusedOther As Boolean)
            _showFocusedOtherFilter = showFocusedOther
            If showFocusedOther Then
                CurrentFilterType = FilterType.Other
            Else
                CurrentFilterType = CType(3, FilterType)
            End If

            UpdateLabelsVisibility()
            If ShowFocusedOtherChangedEvent IsNot Nothing AndAlso CurrentMailType = MailType.Inbox Then RaiseEvent ShowFocusedOtherChanged(Me, EventArgs.Empty)
        End Sub

        Public Function CreateReplyMessage(ByVal selectedMessage As Message) As Message
            Dim message As Message = New Message()
            message.MailType = MailType.Draft
            message.From = If(String.IsNullOrEmpty(selectedMessage.From), MessageFrom, selectedMessage.From)
            message.Email = selectedMessage.Email
            message.Subject = selectedMessage.Subject
            message.Text = CreateReplyMessageText(selectedMessage.Text, message.From, selectedMessage.Date)
            Return message
        End Function

        Private Function CreateReplyMessageText(ByVal text As String, ByVal [to] As String, ByVal originalMessageDate As Date) As String
            Using server As RichEditDocumentServer = New RichEditDocumentServer()
                server.MhtText = text
                QuoteReplyMessage(server, [to], originalMessageDate)
                Return server.MhtText
            End Using
        End Function

        Private Sub QuoteReplyMessage(ByVal server As RichEditDocumentServer, ByVal [to] As String, ByVal originalMessageDate As Date)
            QuoteMessage(server)
            Dim document As Document = server.Document
            Dim replyHeader As String = String.Format(Resources.ReplyText, [to], originalMessageDate)
            document.InsertText(document.Range.Start, replyHeader)
        End Sub

        Private Sub QuoteMessage(ByVal server As RichEditDocumentServer)
            Dim document As Document = server.Document
            Dim paragraphs As ParagraphCollection = document.Paragraphs
            For Each paragraph As Paragraph In paragraphs
                Dim range As DocumentRange = paragraph.Range
                If document.Tables.GetTableCell(range.Start) Is Nothing AndAlso Not paragraph.IsInList Then
                    document.InsertText(range.Start, ">> ")
                End If
            Next
        End Sub

        Public Sub SetCurrentMessage(ByVal message As Message)
            CurrentMessage = message
        End Sub

        Private model As MailClientDataModel

        Public Sub New()
            model = New MailClientDataModel()
            RegisterAsRecipient()
        End Sub
    End Class
End Namespace
