Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports DevExpress.DevAV.Chat
Imports DevExpress.DevAV.Chat.Commands
Imports DevExpress.DevAV.Chat.Events
Imports DevExpress.DevAV.Chat.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.ChatClient.ViewModels

    Public Class MessagesViewModel
        Inherits ChannelViewModel

        Public Sub New()
            MyBase.New()
            Messages = New Message(-1) {}
            Call Mvvm.Messenger.Default.Register(Me, New System.Action(Of Contact)(AddressOf OnContact))
        End Sub

        Public Overrides Sub OnDestroy()
            MyBase.OnDestroy()
            Call Mvvm.Messenger.Default.Unregister(Me, New System.Action(Of Contact)(AddressOf OnContact))
        End Sub

        Protected Overrides Sub OnConnected(ByVal channel As IChannel)
            MyBase.OnConnected(channel)
            channel.Subscribe(New System.Action(Of Dictionary(Of Long, MessageEvent))(AddressOf OnMessageEvents))
            channel.Subscribe(New System.Action(Of Dictionary(Of Long, ContactEvent))(AddressOf OnContactEvents))
        End Sub

        Protected Overrides Async Sub OnChannelReady()
            Await LoadMessages(Channel, Contact)
            Await DispatcherService?.BeginInvoke(New System.Action(AddressOf UpdateUIOnChannelReady))
        End Sub

        Private Async Sub OnContactEvents(ByVal events As Dictionary(Of Long, ContactEvent))
            If Contact IsNot Nothing Then
                Dim [event] As ContactEvent = Nothing
                If events.TryGetValue(Contact.ID, [event]) Then
                    If TypeOf [event] Is UnreadChanged OrElse TypeOf [event] Is NewMessages Then Await LoadMessages(Channel, Contact)
                End If

                If events.Count > 0 Then Await DispatcherService?.BeginInvoke(New System.Action(AddressOf RaiseMessagesChanged))
                If TypeOf [event] Is NewMessages Then Await DispatcherService?.BeginInvoke(New System.Action(AddressOf RaiseContactChanged))
            End If
        End Sub

        Private updatedMessagesIdices As HashSet(Of Integer) = New HashSet(Of Integer)()

        Private Async Sub OnMessageEvents(ByVal events As Dictionary(Of Long, MessageEvent))
            updatedMessagesIdices.Clear()
            Dim [event] As MessageEvent = Nothing
            Dim index As Integer = 0
            For Each message As Message In Messages
                If events.TryGetValue(message.ID, [event]) AndAlso updatedMessagesIdices.Add(index) Then [event].Apply(message)
                index += 1
            Next

            If events.Count > 0 Then Await DispatcherService?.BeginInvoke(New System.Action(AddressOf RaiseMessagesUpdated))
        End Sub

        Private Sub UpdateUIOnChannelReady()
            RaisePropertyChanged(Function(x) x.Messages)
            UpdateActions()
        End Sub

        Private Sub RaiseMessagesChanged()
            RaisePropertyChanged(Function(x) x.Messages)
        End Sub

        Private Sub RaiseMessagesUpdated()
            RaisePropertyChanged(Function(x) x.UpdatedMessageIndices)
            updatedMessagesIdices.Clear()
        End Sub

        Private Async Sub OnContact(ByVal contact As Contact)
            Await LoadMessages(Channel, contact)
            Await DispatcherService?.BeginInvoke(Sub() Me.Contact = contact)
        End Sub

        Private Async Function LoadMessages(ByVal channel As IChannel, ByVal contact As Contact) As Task
            If channel IsNot Nothing AndAlso contact IsNot Nothing Then
                Dim history = Await channel.GetHistory(contact)
                Await DispatcherService?.BeginInvoke(Sub() Messages = history)
            End If
        End Function

        Public Overridable Property Contact As Contact

        Private Sub RaiseContactChanged()
            RaisePropertyChanged(Function(x) x.Contact)
        End Sub

        Protected Sub OnContactChanged()
            UpdateActions()
        End Sub

        Public Function CanExecuteActions() As Boolean
            Return Channel IsNot Nothing AndAlso Contact IsNot Nothing
        End Function

        Protected Sub UpdateActions()
            RaiseCanExecuteChanged(Sub(x) x.SendMessage())
            RaiseCanExecuteChanged(Sub(x) x.PhoneCall())
            RaiseCanExecuteChanged(Sub(x) x.VideoCall())
            RaiseCanExecuteChanged(Sub(x) x.ShowContact())
            RaiseCanExecuteChanged(Sub(x) x.ShowUser())
        End Sub

        Public Overridable Property Messages As IReadOnlyCollection(Of Message)

        Public ReadOnly Property UpdatedMessageIndices As IReadOnlyCollection(Of Integer)
            Get
                Return updatedMessagesIdices.ToArray()
            End Get
        End Property

        Private lastMessage As Message

        Protected Sub OnMessagesChanged()
            lastMessage = Messages.LastOrDefault()
        End Sub

        Public Overridable Property MessageText As String

        Protected Sub OnMessageTextChanged()
            RaiseCanExecuteChanged(Sub(x) x.SendMessage())
        End Sub

        Public Function CanSendMessage() As Boolean
            Return CanExecuteActions() AndAlso Not String.IsNullOrEmpty(MessageText)
        End Function

        Public Sub SendMessage()
            If Channel IsNot Nothing Then Channel.Send(New AddMessage(Contact, MessageText))
            MessageText = Nothing
        End Sub

        Public Sub Update()
            RaiseCanExecuteChanged(Sub(x) x.SendMessage())
        End Sub

        <Command(CanExecuteMethodName:=NameOf(CanExecuteActions))>
        Public Async Sub PhoneCall()
            Dim contactInfo = Await Channel.GetUserInfo(Contact.ID)
            DoCall("Phone Call: " & contactInfo.MobilePhone)
        End Sub

        <Command(CanExecuteMethodName:=NameOf(CanExecuteActions))>
        Public Async Sub VideoCall()
            Dim contactInfo = Await Channel.GetUserInfo(Contact.ID)
            DoCall("Video Call: " & contactInfo.MobilePhone)
        End Sub

        Private Sub DoCall(ByVal [call] As String)
            Dim msgService = GetRequiredService(Of IMessageBoxService)()
            msgService.ShowMessage([call])
        End Sub

        <Command(CanExecuteMethodName:=NameOf(CanExecuteActions))>
        Public Async Sub ShowContact()
            Dim contactInfo = Await Channel.GetUserInfo(Contact.ID)
            MessengerViewModel.ShowContactInfo(Me, contactInfo)
        End Sub

        <Command(CanExecuteMethodName:=NameOf(CanExecuteActions))>
        Public Async Sub ShowUser()
            Dim userInfo = Await Channel.GetUserInfo(Channel.UserName)
            MessengerViewModel.ShowUserInfo(Me, userInfo)
        End Sub

        Public Overridable Property SelectedMessage As Message

        Public Overridable Property SelectedText As String

        Protected Sub OnSelectedTextChanged()
            RaiseCanExecuteChanged(Sub(x) x.CopySelectedText())
        End Sub

        Protected Sub OnSelectedMessageChanged()
            RaiseCanExecuteChanged(Sub(x) x.DeleteMessage())
            RaiseCanExecuteChanged(Sub(x) x.CopyMessage())
            RaiseCanExecuteChanged(Sub(x) x.CopyMessageText())
            RaiseCanExecuteChanged(Sub(x) x.LikeMessage())
        End Sub

        Public Function CanDeleteMessage() As Boolean
            Return SelectedMessage IsNot Nothing AndAlso Not SelectedMessage.IsDeleted
        End Function

        Public Sub DeleteMessage()
            If Channel IsNot Nothing Then Channel.Send(New DeleteMessage(SelectedMessage.ID))
        End Sub

        Public Function CanCopyMessage() As Boolean
            Return SelectedMessage IsNot Nothing AndAlso Not SelectedMessage.IsDeleted
        End Function

        Public Sub CopyMessage()
            Dim message As String = "[" & SelectedMessage.StatusText & "] " & SelectedMessage.Owner.UserName & System.Environment.NewLine & SelectedMessage.Text
            Data.Utils.SafeClipboardWin.Instance.SetText(message)
        End Sub

        Public Function CanCopyMessageText() As Boolean
            Return SelectedMessage IsNot Nothing AndAlso Not SelectedMessage.IsDeleted
        End Function

        Public Sub CopyMessageText()
            Data.Utils.SafeClipboardWin.Instance.SetText(SelectedMessage.Text)
        End Sub

        Public Function CanCopySelectedText() As Boolean
            Return Not String.IsNullOrEmpty(SelectedText)
        End Function

        Public Sub CopySelectedText()
            Data.Utils.SafeClipboardWin.Instance.SetText(SelectedText)
        End Sub

        Public Function CanLikeMessage() As Boolean
            Return SelectedMessage IsNot Nothing AndAlso Not SelectedMessage.IsLiked
        End Function

        Public Sub LikeMessage()
            If Channel IsNot Nothing Then Channel.Send(New LikeMessage(SelectedMessage.ID))
        End Sub

        <Command(False)>
        Public Sub OnMessageRead(ByVal message As Message)
            If lastMessage IsNot Nothing AndAlso message Is lastMessage Then
                lastMessage = Nothing
                If Channel IsNot Nothing Then Channel.Send(New ReadMessages(Contact))
            End If
        End Sub
    End Class
End Namespace
