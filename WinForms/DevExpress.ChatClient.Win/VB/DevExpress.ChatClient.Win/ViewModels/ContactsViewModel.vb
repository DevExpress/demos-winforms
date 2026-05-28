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

    Public Class ContactsViewModel
        Inherits ChannelViewModel

        Public Sub New()
            MyBase.New()
            Contacts = New Contact(-1) {}
            Call Mvvm.Messenger.Default.Register(Me, New System.Action(Of Contact)(AddressOf OnContact))
        End Sub

        Protected Overrides Sub OnConnected(ByVal channel As IChannel)
            MyBase.OnConnected(channel)
            channel.Subscribe(New System.Action(Of Dictionary(Of Long, ContactEvent))(AddressOf OnContactEvents))
        End Sub

        Protected Overrides Async Sub OnChannelReady()
            Dim channelContacts = Await Channel.GetContacts()
            Await DispatcherService?.BeginInvoke(Sub() Contacts = channelContacts)
        End Sub

        Private Sub OnContact(ByVal contact As Contact)
            UpdateSelectedContact(contact)
        End Sub

        Private Async Sub OnContactEvents(ByVal events As Dictionary(Of Long, ContactEvent))
            Dim [event] As ContactEvent = Nothing
            For Each contact As Contact In Contacts
                If events.TryGetValue(contact.ID, [event]) Then [event].Apply(contact)
            Next

            If events.Count > 0 Then Await DispatcherService?.BeginInvoke(New System.Action(AddressOf RaiseContactsChanged))
        End Sub

        Private Sub RaiseContactsChanged()
            RaisePropertyChanged(Function(x) x.Contacts)
        End Sub

        Public Overridable Property Contacts As IReadOnlyCollection(Of Contact)

        Protected Sub OnContactsChanged()
            If SelectedContact Is Nothing Then
                SelectedContact = Contacts.FirstOrDefault()
            Else
                UpdateSelectedContact(SelectedContact)
            End If
        End Sub

        Public Overridable Property SelectedContact As Contact

        Protected Sub OnSelectedContactChanged()
            NotifyContactSelected(SelectedContact)
            RaiseCanExecuteChanged(Sub(x) x.ClearConversation())
            RaiseCanExecuteChanged(Sub(x) x.CopyContact())
        End Sub

        Private lockContact As Integer = 0

        Private Sub UpdateSelectedContact(ByVal contact As Contact)
            If lockContact > 0 OrElse contact Is Nothing Then Return
            lockContact += 1
            Try
                Dim id As Long = contact.ID
                SelectedContact = If(Contacts.Where(Function(x) x.ID = id).FirstOrDefault(), Contacts.FirstOrDefault())
            Finally
                lockContact -= 1
            End Try
        End Sub

        Private Sub NotifyContactSelected(ByVal contact As Contact)
            If lockContact > 0 OrElse contact Is Nothing Then Return
            lockContact += 1
            Try
                Mvvm.Messenger.Default.Send(contact)
            Finally
                lockContact -= 1
            End Try
        End Sub

        Public Async Sub ShowContact(ByVal contact As Contact)
            Dim contactInfo = Await Channel.GetUserInfo(contact.ID)
            MessengerViewModel.ShowContactInfo(Me, contactInfo)
        End Sub

        <Command(False)>
        Public Function HasContact() As Boolean
            Return SelectedContact IsNot Nothing
        End Function

        <Command(CanExecuteMethodName:=NameOf(HasContact))>
        Public Sub ClearConversation()
            If Channel IsNot Nothing Then Channel.Send(New ClearConversation(SelectedContact))
        End Sub

        <Command(CanExecuteMethodName:=NameOf(HasContact))>
        Public Async Sub CopyContact()
            Dim info = Await Channel.GetUserInfo(SelectedContact.ID)
            Dim contact As String = info.Name & System.Environment.NewLine & $"Email: {info.Email}" & System.Environment.NewLine & $"Phone: {info.MobilePhone}"
            Data.Utils.SafeClipboardWin.Instance.SetText(contact)
        End Sub

        Private contactTooltipViewModel As ContactViewModel

        Public Async Function EnsureTooltipViewModel(ByVal contact As Contact) As Task(Of ContactViewModel)
            Dim contactInfo = Await Channel.GetUserInfo(contact.ID)
            If contactTooltipViewModel Is Nothing Then
                contactTooltipViewModel = ContactViewModel.Create(contactInfo)
            Else
                CType(contactTooltipViewModel, ISupportParameter).Parameter = contactInfo
            End If

            Return contactTooltipViewModel
        End Function
    End Class
End Namespace
