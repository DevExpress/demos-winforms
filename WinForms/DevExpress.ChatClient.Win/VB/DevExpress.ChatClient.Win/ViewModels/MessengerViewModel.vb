Imports System.Threading.Tasks
Imports DevExpress.ChatClient.Services
Imports DevExpress.DevAV.Chat
Imports DevExpress.DevAV.Chat.Commands
Imports DevExpress.DevAV.Chat.Events
Imports DevExpress.DevAV.Chat.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.ChatClient.ViewModels

    Public Class MessengerViewModel

        Public Overridable Property Title As String

        Private dispatcher As IDispatcherService

        Private channel As IChannel

        Public Async Function OnLoad() As Task
            dispatcher = GetRequiredService(Of IDispatcherService)()
            Dim settingsService = GetRequiredService(Of ISettingsService)()
            Dim theme = If(settingsService.Theme, "Light")
            Dim currentUser = If(settingsService.CurrentUser, "John Heart")
            Dim messageServer = GetRequiredService(Of IMessageServer)()
            channel = Await messageServer.Create(currentUser)
            channel.Subscribe(New System.Action(Of ChannelEvent)(AddressOf OnChannelEvent))
            Mvvm.Messenger.Default.Send(channel)
            Await dispatcher.BeginInvoke(Sub() Title = $"DevExpress Chat Client (CS) - [{currentUser.ToUpper()}]")
        End Function

        Private authCounter As Integer = 0

        Private Sub OnChannelEvent(ByVal [event] As ChannelEvent)
            Dim credentialsRequired = TryCast([event], CredentialsRequiredEvent)
            If credentialsRequired IsNot Nothing Then
                If 0 = System.Math.Min(System.Threading.Interlocked.Increment(authCounter), authCounter - 1) Then
                    Dim cacheQuery = QueryAccessTokenFromLocalAuthCache([event].UserName, credentialsRequired.Salt)
                    credentialsRequired.SetAccessTokenQuery(cacheQuery)
                Else
                    Dim userQuery = QueryAccessTokenFromUser([event].UserName, credentialsRequired.Salt)
                    credentialsRequired.SetAccessTokenQuery(userQuery)
                End If
            End If
        End Sub

        Private Function QueryAccessTokenFromLocalAuthCache(ByVal userName As String, ByVal salt As String) As Task(Of String)
            Return Task.FromResult(DevAVEmpployeesInMemoryServer.GetPasswordHash(String.Empty, salt))
        End Function

        Private Function QueryAccessTokenFromUser(ByVal userName As String, ByVal salt As String) As Task(Of String)
            Dim accessTokenQueryCompletionSource = New TaskCompletionSource(Of String)()
            dispatcher.BeginInvoke(Sub()
                Dim signInViewModel = ViewModels.SignInViewModel.Create(userName, salt)
                signInViewModel.ShowDialog()
                If Not String.IsNullOrEmpty(signInViewModel.AccessToken) Then
                    accessTokenQueryCompletionSource.SetResult(signInViewModel.AccessToken)
                Else
                    accessTokenQueryCompletionSource.SetCanceled()
                End If
            End Sub)
            Return accessTokenQueryCompletionSource.Task
        End Function

        Public Sub OnClosed()
            If channel IsNot Nothing Then channel.Dispose()
            channel = Nothing
        End Sub

        Public Sub LogOff()
            If channel IsNot Nothing Then channel.Send(New LogOff(channel))
        End Sub

        Private userViewModel As UserViewModel

        <Command(False)>
        Public Sub ShowUserInfo(ByVal userInfo As UserInfo)
            ShowPopup(If(userViewModel, Function()
                userViewModel = UserViewModel.Create(userInfo)
                Return userViewModel
            End Function()), userInfo)
        End Sub

        Private contactViewModel As ContactViewModel

        <Command(False)>
        Public Sub ShowContactInfo(ByVal contactInfo As UserInfo)
            ShowPopup(If(contactViewModel, Function()
                contactViewModel = ContactViewModel.Create(contactInfo)
                Return contactViewModel
            End Function()), contactInfo)
        End Sub

        Private Sub ShowPopup(ByVal viewModel As UserInfoViewModel, ByVal info As UserInfo)
            viewModel.SetParentViewModel(Me)
            Dim popup = GetService(Of IWindowService)(viewModel.ServiceKey)
            popup.Show(Nothing, viewModel, info, Me)
        End Sub

        Public Shared Sub ShowUserInfo(ByVal viewModel As Object, ByVal userInfo As UserInfo)
            Dim messenger = POCOViewModelExtensions.GetParentViewModel(Of MessengerViewModel)(viewModel)
            If messenger IsNot Nothing Then messenger.ShowUserInfo(userInfo)
        End Sub

        Public Shared Sub ShowContactInfo(ByVal viewModel As Object, ByVal contactInfo As UserInfo)
            Dim messenger = POCOViewModelExtensions.GetParentViewModel(Of MessengerViewModel)(viewModel)
            If messenger IsNot Nothing Then messenger.ShowContactInfo(contactInfo)
        End Sub
    End Class
End Namespace
