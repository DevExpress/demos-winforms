Imports DevExpress.DevAV.Chat
Imports DevExpress.DevAV.Chat.Events
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.ChatClient.ViewModels

    Public MustInherit Class ChannelViewModel

        Private _Channel As IChannel, _DispatcherService As IDispatcherService

        Protected Sub New()
            Call Mvvm.Messenger.Default.Register(Me, New System.Action(Of IChannel)(AddressOf OnConnected))
        End Sub

        Protected Overridable Sub OnConnected(ByVal channel As IChannel)
            channel.Subscribe(New System.Action(Of ChannelEvent)(AddressOf OnChannelEvent))
        End Sub

        Public Overridable Sub OnCreate()
            EnsureDispatcherService()
        End Sub

        Public Overridable Sub OnDestroy()
            Call Mvvm.Messenger.Default.Unregister(Me, New System.Action(Of IChannel)(AddressOf OnConnected))
        End Sub

        Protected Property Channel As IChannel
            Get
                Return _Channel
            End Get

            Private Set(ByVal value As IChannel)
                _Channel = value
            End Set
        End Property

        Private Sub OnChannelEvent(ByVal [event] As ChannelEvent)
            Dim channelReady = TryCast([event], ChannelReadyEvent)
            If channelReady IsNot Nothing Then
                EnsureDispatcherService()
                Channel = channelReady.Channel
                OnChannelReady()
            End If
        End Sub

        Protected Overridable Sub OnChannelReady()
        End Sub

        Protected Property DispatcherService As IDispatcherService
            Get
                Return _DispatcherService
            End Get

            Private Set(ByVal value As IDispatcherService)
                _DispatcherService = value
            End Set
        End Property

        Protected Function EnsureDispatcherService() As IDispatcherService
            Return If(DispatcherService, Function()
                DispatcherService = GetRequiredService(Of IDispatcherService)()
                Return DispatcherService
            End Function())
        End Function
    End Class
End Namespace
