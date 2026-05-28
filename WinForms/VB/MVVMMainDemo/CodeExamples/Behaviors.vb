Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("Simple Behaviors", "Behaviors.vb"), CodeExampleHighlightTokens("ConfirmationBehavior", "ChangingEventArgs", "ConfirmationButtons"), CodeExampleUnderlineTokens("AttachBehavior", "Confirmation")>
    Public NotInheritable Class SimpleBehaviors
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim editor As New CheckEdit()
            editor.Dock = DockStyle.Top
            editor.Text = "Please, try to change checked state of this editor"
            editor.Parent = sampleHost

            Return New Object() {mvvmContext, editor}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Confirmation Behavior (separate class)", New Type() {GetType(EditValueChangingConfirmation)})>
        Public Shared Sub EditValueChangingConfirmationBehavior(ByVal mvvmContext As MVVMContext, ByVal editor As CheckEdit)
            ' UI binding for the EditValueChangingConfirmation behavior
            mvvmContext.AttachBehavior(Of EditValueChangingConfirmation)(editor)
        End Sub
        <CodeExampleCase("Confirmation Behavior (generic ConfirmationBehavior class)")>
        Public Shared Sub GenericConfirmationBehavior(ByVal mvvmContext As MVVMContext, ByVal editor As CheckEdit)
            ' UI binding for the generic ConfirmationBehavior behavior with some specific parameters
            mvvmContext.AttachBehavior(Of ConfirmationBehavior(Of ChangingEventArgs))(editor,
                              Sub(behavior)
                                  behavior.Caption = "CheckEdit State changing"
                                  behavior.Text = "This checkEdit's checked-state is about to be changed. Are you sure?"
                                  behavior.Buttons = ConfirmationButtons.YesNo
                                  behavior.ShowQuestionIcon = True
                              End Sub, "EditValueChanging")
        End Sub
        <CodeExampleCase("Confirmation Behavior (Fluent API)")>
        Public Shared Sub GenericConfirmationBehaviorFluentAPI(ByVal mvvmContext As MVVMContext, ByVal editor As CheckEdit)
            ' UI binding for the generic ConfirmationBehavior behavior with some specific parameters
            mvvmContext.WithEvent(Of ChangingEventArgs)(editor, "EditValueChanging").
                Confirmation(Sub(behavior)
                                 behavior.Caption = "CheckEdit State changing"
                                 behavior.Text = "This checkEdit's checked-state is about to be changed. Are you sure?"
                             End Sub)
        End Sub
        <CodeExampleNestedClass>
        Public Class EditValueChangingConfirmation
            Inherits ConfirmationBehavior(Of ChangingEventArgs)
            Public Sub New()
                MyBase.New("EditValueChanging")
            End Sub
            Protected Overrides Function GetConfirmationCaption() As String
                Return "EditValue changing confirmation"
            End Function
            Protected Overrides Function GetConfirmationText() As String
                Return "This editor's EditValue is about to be changed. Are you sure?"
            End Function
        End Class
    End Class

    <CodeExampleClass("Event-To-Command Behavior", "Behaviors.vb"), CodeExampleHighlightTokens("EventToCommandBehavior", "EventArgs", "IMessageBoxService"), CodeExampleUnderlineTokens("EventToCommand", "AttachBehavior")>
    Public NotInheritable Class EventToCommandBehavior
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim thirdPartyButton As New Button()
            thirdPartyButton.Dock = DockStyle.Top
            thirdPartyButton.Text = "Execute Command"
            thirdPartyButton.AutoSize = True
            thirdPartyButton.Parent = sampleHost

            Return New Object() {mvvmContext, thirdPartyButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Using Commands with third-party controls", New Type() {GetType(ViewModel), GetType(ClickToSayHello)})>
        Public Shared Sub CommandForThirdPartyControls(ByVal mvvmContext As MVVMContext, ByVal thirdPartyButton As Button)
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' UI binding for the ClickToSayHello behavior
            mvvmContext.AttachBehavior(Of ClickToSayHello)(thirdPartyButton)
        End Sub
        <CodeExampleCase("Using Commands with third-party controls (Fluent API)", New Type() {GetType(ViewModel)})>
        Public Shared Sub CommandForThirdPartyControlsFluentAPI(ByVal mvvmContext As MVVMContext, ByVal thirdPartyButton As Button)
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' UI binding for the EventToCommand behavior (using FluentAPI)
            mvvmContext.WithEvent(Of ViewModel, EventArgs)(thirdPartyButton, "Click").
                EventToCommand(Sub(x) x.SayHello())
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Protected ReadOnly Property MessageBoxService() As IMessageBoxService
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Public Sub SayHello()
                MessageBoxService.ShowMessage("Hello!")
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ClickToSayHello
            Inherits DevExpress.Utils.MVVM.EventToCommandBehavior(Of ViewModel, EventArgs)
            Public Sub New()
                MyBase.New("Click", Sub(x) x.SayHello())
            End Sub
        End Class
    End Class

    <CodeExampleClass("Event-To-Command Behavior (Parameters&Converters)", "Behaviors.vb"), CodeExampleHighlightTokens("MouseEventArgs", "MouseButtons", "IMessageBoxService", "Point"), CodeExampleUnderlineTokens("EventToCommand", "WithEvent")>
    Public NotInheritable Class EventToCommandBehaviorParametersAndConverters
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim panel As New PanelControl()
            panel.Dock = DockStyle.Top
            panel.Parent = sampleHost

            Dim label As New LabelControl()
            label.Text = "Click to Execute Command"
            label.Dock = DockStyle.Fill
            label.AutoSizeMode = LabelAutoSizeMode.None
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            label.Parent = panel

            Return New Object() {mvvmContext, label}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Passing parameters to Commands", New Type() {GetType(MouseDownAwareViewModel)})>
        Public Shared Sub ReportMouseDown(ByVal mvvmContext As MVVMContext, ByVal label As LabelControl)
            mvvmContext.ViewModelType = GetType(MouseDownAwareViewModel)
            ' UI binding for the EventToCommand behavior
            mvvmContext.OfType(Of MouseDownAwareViewModel)().WithEvent(Of MouseEventArgs)(label, "MouseDown").
                EventToCommand(Sub(x) x.Report(Nothing), Function(x) x.Message)
        End Sub
        <CodeExampleCase("Passing event Arguments to Commands AS IS", New Type() {GetType(MouseDownAwareViewModel)})>
        Public Shared Sub ReportMouseDownArgs(ByVal mvvmContext As MVVMContext, ByVal label As LabelControl)
            mvvmContext.ViewModelType = GetType(MouseDownAwareViewModel)
            ' UI binding for the EventToCommand behavior
            mvvmContext.OfType(Of MouseDownAwareViewModel)().WithEvent(Of MouseEventArgs)(label, "MouseDown").
                EventToCommand(Sub(x) x.ReportArgs(New MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0)))
        End Sub
        <CodeExampleCase("Passing event Arguments to Commands via Converter", New Type() {GetType(MouseDownAwareViewModel)})>
        Public Shared Sub ReportMouseDownLocation(ByVal mvvmContext As MVVMContext, ByVal label As LabelControl)
            mvvmContext.ViewModelType = GetType(MouseDownAwareViewModel)
            ' UI binding for the EventToCommand behavior
            mvvmContext.OfType(Of MouseDownAwareViewModel)().WithEvent(Of MouseEventArgs)(label, "MouseDown").
                EventToCommand(Sub(x) x.ReportLocation(Point.Empty), Function(args) args.Location)
        End Sub
        <CodeExampleNestedClass>
        Public Class MouseDownAwareViewModel
            Public Sub New()
                Message = "MouseDown performed!"
            End Sub
            Public Property Message() As String
            Protected ReadOnly Property MessageBoxService() As IMessageBoxService
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Public Sub Report(ByVal message As String)
                MessageBoxService.ShowMessage(message)
            End Sub
            Public Sub ReportArgs(ByVal args As MouseEventArgs)

                Dim msg As String = String.Join(", ",
                                          "Button: " & args.Button.ToString(),
                                          "Location: " & args.Location.ToString(),
                                          "Clicks: " & args.Clicks.ToString(),
                                          "Delta: " & args.Delta.ToString())
                MessageBoxService.ShowMessage("Args = {" & msg & "}")
            End Sub
            Public Sub ReportLocation(ByVal pt As Point)
                MessageBoxService.ShowMessage("Location = " & pt.ToString())
            End Sub
        End Class
    End Class
    <CodeExampleClass("Event-To-Command Behavior (Reusable Behaviors)", "Behaviors.vb"), CodeExampleHighlightTokens("EventToCommandBehavior", "EventArgs", "IMessageBoxService"), CodeExampleUnderlineTokens("AttachBehavior")>
    Public NotInheritable Class EventToCommandBehaviorReusableBehaviors
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim sayMessage As New TextEdit()
            sayMessage.Properties.NullValuePrompt = "Enter the message to say"
            sayMessage.Dock = DockStyle.Top
            sayMessage.Parent = sampleHost
            sayMessage.Visible = False

            Dim btn1 As New SimpleButton()
            btn1.Dock = DockStyle.Top
            btn1.Parent = sampleHost

            Dim btn2 As New SimpleButton()
            btn2.Dock = DockStyle.Top
            btn2.Parent = sampleHost

            Return New Object() {mvvmContext, btn1, btn2, sayMessage}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Reusable parameterless behavior", New Type() {GetType(ViewModel), GetType(ClickToSayHello)})>
        Public Shared Sub UseClickToSayHello(ByVal mvvmContext As MVVMContext, ByVal btn1 As SimpleButton, ByVal btn2 As SimpleButton, ByVal sayMessage As TextEdit)
            ' UI setup
            btn2.Text = "Click to say ""Hello!"""
            btn1.Text = btn2.Text
            '
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' UI binding for the reusable ClickToSayHello behavior
            mvvmContext.AttachBehavior(Of ClickToSayHello)(btn1)
            mvvmContext.AttachBehavior(Of ClickToSayHello)(btn2)
        End Sub
        <CodeExampleCase("Reusable parameterized behavior", New Type() {GetType(ViewModel), GetType(ClickToSay)})>
        Public Shared Sub UseClickToSay(ByVal mvvmContext As MVVMContext, ByVal btn1 As SimpleButton, ByVal btn2 As SimpleButton, ByVal sayMessage As TextEdit)
            ' UI setup
            btn2.Text = "Click to say something"
            btn1.Text = btn2.Text
            sayMessage.Visible = True
            sayMessage.SendToBack()
            '
            mvvmContext.ViewModelType = GetType(ViewModel)
            ' UI binding for the Message property
            mvvmContext.OfType(Of ViewModel)().SetBinding(sayMessage, Function(te) te.EditValue, Function(x) x.Message)
            ' UI binding for the reusable ClickToSay behavior
            mvvmContext.AttachBehavior(Of ClickToSay)(btn1)
            mvvmContext.AttachBehavior(Of ClickToSay)(btn2)
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModel
            Protected ReadOnly Property MessageBoxService() As IMessageBoxService
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Public Sub SayHello()
                MessageBoxService.ShowMessage("Hello!")
            End Sub
            Public Overridable Property Message() As String
            Protected Overridable Sub OnMessageChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.Say(Nothing))
            End Sub
            Public Sub Say(ByVal message As String)
                MessageBoxService.ShowMessage(message)
            End Sub
            Public Function CanSay(ByVal message As String) As Boolean
                Return Not String.IsNullOrEmpty(message)
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class ClickToSayHello
            Inherits DevExpress.Utils.MVVM.EventToCommandBehavior(Of ViewModel, EventArgs)
            Public Sub New()
                ' specifying command selector
                MyBase.New("Click", Sub(x) x.SayHello())
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ClickToSay
            Inherits DevExpress.Utils.MVVM.EventToCommandBehavior(Of ViewModel, String, EventArgs)
            Public Sub New()
                ' specifying command selector and command parameters
                MyBase.New("Click", Sub(x) x.Say(Nothing), Function(x) x.Message)
            End Sub
        End Class
    End Class
    <CodeExampleClass("Key-To-Command and Keys-To-Command Behaviors", "Behaviors.vb"), CodeExampleVersionID(162), CodeExampleHighlightTokens("Keys", "KeyEventArgs"), CodeExampleUnderlineTokens("KeyToCommand", "WithKey", "KeysToCommand", "WithKeys")>
    Public NotInheritable Class KeyToCommandBehavior

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim panel As New UserControl()
            panel.Dock = DockStyle.Top
            panel.Parent = sampleHost

            Dim memo As New MemoEdit()
            memo.Dock = DockStyle.Fill
            memo.ReadOnly = True
            memo.MinimumSize = New Size(0, 100)
            memo.Parent = panel

            Return New Object() {mvvmContext, memo}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Key to Command(Parameterless)", New Type() {GetType(KeyAwareViewModel)})>
        Public Shared Sub KeyToCommand(ByVal mvvmContext As MVVMContext, ByVal memo As MemoEdit)
            memo.Text = "Click here and press the A or Alt+A keys to execute a command"
            '
            mvvmContext.ViewModelType = GetType(KeyAwareViewModel)
            ' UI binding for the KeyToCommand behavior
            mvvmContext.OfType(Of KeyAwareViewModel)().WithKey(memo, Keys.A).KeyToCommand(Sub(x) x.OnAKey())
            mvvmContext.OfType(Of KeyAwareViewModel)().WithKey(memo, Keys.A Or Keys.Alt).KeyToCommand(Sub(x) x.OnAltAKey())
        End Sub
        <CodeExampleCase("Keys to Command(Passing Keys as Command parameter)", New Type() {GetType(KeyAwareViewModel)})>
        Public Shared Sub KeysToCommand(ByVal mvvmContext As MVVMContext, ByVal memo As MemoEdit)
            memo.Text = "Click here and press A, B or C to display short key information. Press the same keys with the Shift modifier to view detailed information."
            '
            mvvmContext.ViewModelType = GetType(KeyAwareViewModel)
            ' UI binding for the KeysToCommand behavior
            mvvmContext.OfType(Of KeyAwareViewModel)().WithKeys(memo, New Keys() {Keys.A, Keys.B, Keys.C}).KeysToCommand(Sub(x) x.OnKey(Keys.None), Function(args As KeyEventArgs) CType(args, KeyEventArgs).KeyCode)
            ' UI binding for the KeysToCommand behavior
            mvvmContext.OfType(Of KeyAwareViewModel)().WithKeys(memo, New Keys() {Keys.Shift Or Keys.A, Keys.Shift Or Keys.B, Keys.Shift Or Keys.C}).KeysToCommand(Sub(x) x.OnKeyArgs(DirectCast(Nothing, KeyEventArgs)), Function(args As KeyEventArgs) CType(args, KeyEventArgs))
        End Sub
        <CodeExampleNestedClass>
        Public Class KeyAwareViewModel
            Protected ReadOnly Property MessageBoxService() As IMessageBoxService
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Public Sub OnAKey()
                MessageBoxService.ShowMessage("Key Command: A")
            End Sub
            Public Sub OnAltAKey()
                MessageBoxService.ShowMessage("Key Command: Alt+A")
            End Sub
            Public Sub OnKey(ByVal keys As Keys)
                MessageBoxService.ShowMessage("Key Command: " & keys.ToString())
            End Sub
            Public Sub OnKeyArgs(ByVal args As KeyEventArgs)
                Dim message As String = String.Join(", ", "KeyValue: " & args.KeyValue.ToString(), "KeyData: " & args.KeyData.ToString(), "KeyCode: " & args.KeyCode.ToString(), "Modifiers: " & args.Modifiers.ToString())
                MessageBoxService.ShowMessage("Args = {" & message & "}")
            End Sub
        End Class
    End Class
End Namespace
