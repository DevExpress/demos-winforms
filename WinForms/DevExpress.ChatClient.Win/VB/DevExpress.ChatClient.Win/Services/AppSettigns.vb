Namespace DevExpress.ChatClient.Services

    Friend NotInheritable Class AppSettigns
        Implements ISettingsService

        Public Shared Sub Register()
            Mvvm.ServiceContainer.Default.RegisterService(New AppSettigns())
        End Sub

        Public ReadOnly Property CurrentUser As String Implements ISettingsService.CurrentUser
            Get
                Return Properties.Settings.Default.CurrentUser
            End Get
        End Property

        Public ReadOnly Property Theme As String Implements ISettingsService.Theme
            Get
                Return Properties.Settings.Default.Theme
            End Get
        End Property
    End Class
End Namespace
