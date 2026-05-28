Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Mvvm
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports System.Linq.Expressions

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("Messenger", "Messenger.vb"), CodeExampleHighlightTokens("Messenger", "CustomMessage", "TokenizedMessage", "DockStyle", "Environment"), CodeExampleUnderlineTokens("Send", "Register")>
    Public NotInheritable Class MessengerSamples
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim sendMessageButton As New SimpleButton()
            sendMessageButton.Text = "Send Message"
            sendMessageButton.Dock = DockStyle.Top
            sendMessageButton.Parent = sampleHost
            Return New Object() {mvvmContext, sendMessageButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Sending and receiving Messages", New Type() {GetType(ViewModel), GetType(MessageAwareView)})>
        Public Shared Sub SendingAndReceivingMessages(ByVal mvvmContext As MVVMContext, ByVal sendMessageButton As SimpleButton)
            ' add another view
            Dim msgView As New MessageAwareView()
            msgView.Parent = sendMessageButton.Parent
            msgView.BringToFront()
            ' start listening the ViewModel's string messages in View1
            msgView.RegisterAsStringMessageRecepient()

            mvvmContext.ViewModelType = GetType(ViewModel)
            Dim fluent = mvvmContext.OfType(Of ViewModel)()
            ' UI bindings for SendStringMessage commands
            fluent.BindCommand(sendMessageButton, Sub(x) x.SendStringMessage())
        End Sub
        <CodeExampleCase("Sending and receiving custom Messages", New Type() {GetType(ViewModelWithCustomMessage), GetType(CustomMessageAwareView)})>
        Public Shared Sub SendingAndReceivingCustomMessages(ByVal mvvmContext As MVVMContext, ByVal sendMessageButton As SimpleButton)
            ' add another view
            Dim msgView As New CustomMessageAwareView()
            msgView.Parent = sendMessageButton.Parent
            msgView.BringToFront()
            ' start listening the ViewModel's custom messages  in View
            msgView.RegisterAsCustomMessageRecepient()

            mvvmContext.ViewModelType = GetType(ViewModelWithCustomMessage)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithCustomMessage)()
            ' UI bindings for SendCustomMessage commands
            fluent.BindCommand(sendMessageButton, Sub(x) x.SendCustomMessage())
        End Sub
        <CodeExampleCase("Sending and receiving tokenized Messages", New Type() {GetType(ViewModelWithTokenizedMessages), GetType(TokenizedMessagesAwareView)})>
        Public Shared Sub SendingAndReceivingTokenizedMessages(ByVal mvvmContext As MVVMContext, ByVal sendMessageButton As SimpleButton)
            ' add another view
            Dim msgView As New TokenizedMessagesAwareView()
            msgView.Parent = sendMessageButton.Parent
            msgView.BringToFront()
            ' start listening the ViewModel's custom messages  in View
            msgView.RegisterAsCustomMessageRecepient()

            mvvmContext.ViewModelType = GetType(ViewModelWithTokenizedMessages)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithTokenizedMessages)()
            ' UI bindings for SendCustomMessage commands
            fluent.BindCommand(sendMessageButton, Sub(x) x.SendTokenizedMessage())
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class ViewModel
            Public Sub SendStringMessage()
                Messenger.Default.Send("Something happens!")
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class MessageAwareView
            Inherits XtraUserControl
            Private memo As MemoEdit
            Public Sub New()
                Me.Padding = New Padding(0, 0, 0, 4)
                Me.Dock = DockStyle.Fill
                memo = New MemoEdit()
                memo.Dock = DockStyle.Fill
                memo.Parent = Me
            End Sub
            Public Sub RegisterAsStringMessageRecepient()
                Messenger.Default.Register(Of String)(Me, AddressOf OnStringMessage)
            End Sub
            Private Sub OnStringMessage(ByVal message As String)
                memo.Text += ("String message: " & message & Environment.NewLine)
                memo.SelectionStart = memo.Text.Length
                memo.ScrollToCaret()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ViewModelWithCustomMessage
            Private rnd As New Random()
            Public Sub SendCustomMessage()
                Messenger.Default.Send(New CustomMessage() With {.Parameter = rnd.Next(0, 100)})
            End Sub
            ' Custom Message related to this ViewModel
            Public Class CustomMessage
                Public Property Parameter() As Object
                Public Overrides Function ToString() As String
                    Return String.Format("CustomMessage: {0}!", Parameter)
                End Function
            End Class
        End Class
        <CodeExampleNestedClass>
        Public Class CustomMessageAwareView
            Inherits XtraUserControl
            Private memo As MemoEdit
            Public Sub New()
                Me.Padding = New Padding(0, 0, 0, 4)
                Me.Dock = DockStyle.Fill
                memo = New MemoEdit()
                memo.Dock = DockStyle.Fill
                memo.Parent = Me
            End Sub
            Public Sub RegisterAsCustomMessageRecepient()
                Messenger.Default.Register(Of ViewModelWithCustomMessage.CustomMessage)(Me, AddressOf OnCustomMessage)
            End Sub
            Private Sub OnCustomMessage(ByVal message As ViewModelWithCustomMessage.CustomMessage)
                memo.Text += (message.ToString() & Environment.NewLine)
                memo.SelectionStart = memo.Text.Length
                memo.ScrollToCaret()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ViewModelWithTokenizedMessages
            Private rnd As New Random()
            Public Sub SendTokenizedMessage()
                Dim parameter As Integer = rnd.Next(0, 100)
                Dim msg As TokenizedMessage = New TokenizedMessage() With {.Parameter = parameter}
                If parameter Mod 10 = 0 Then
                    Messenger.Default.Send(msg, "Ten")
                Else
                    Messenger.Default.Send(msg, If(parameter Mod 2 = 1, "Odd", "Even"))
                End If
            End Sub
            ' Message related to this ViewModel (will be dispatched via string token)
            Public Class TokenizedMessage
                Public Property Parameter() As Object
            End Class
        End Class
        <CodeExampleNestedClass>
        Public Class TokenizedMessagesAwareView
            Inherits XtraUserControl
            Private memo As MemoEdit
            Public Sub New()
                Me.Padding = New Padding(0, 0, 0, 4)
                Me.Dock = DockStyle.Fill
                memo = New MemoEdit()
                memo.Dock = DockStyle.Fill
                memo.Parent = Me
            End Sub
            Public Sub RegisterAsCustomMessageRecepient()
                Messenger.Default.Register(Of ViewModelWithTokenizedMessages.TokenizedMessage)(Me, "Odd", AddressOf OnOddMessage)
                Messenger.Default.Register(Of ViewModelWithTokenizedMessages.TokenizedMessage)(Me, "Even", AddressOf OnEvenMessage)
                Messenger.Default.Register(Of ViewModelWithTokenizedMessages.TokenizedMessage)(Me, "Ten", AddressOf OnTenMessage)
            End Sub
            Private Sub OnOddMessage(ByVal message As ViewModelWithTokenizedMessages.TokenizedMessage)
                LogMessage("Odd: " & message.Parameter.ToString())
            End Sub
            Private Sub OnEvenMessage(ByVal message As ViewModelWithTokenizedMessages.TokenizedMessage)
                LogMessage("Even: " & message.Parameter.ToString())
            End Sub
            Private Sub OnTenMessage(ByVal message As ViewModelWithTokenizedMessages.TokenizedMessage)
                LogMessage("Ten: " & message.Parameter.ToString())
            End Sub
            Private Sub LogMessage(ByVal message As String)
                memo.Text += (message & Environment.NewLine)
                memo.SelectionStart = memo.Text.Length
                memo.ScrollToCaret()
            End Sub
        End Class
    End Class
End Namespace
