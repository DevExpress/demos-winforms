Imports System
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports System.Linq.Expressions

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("Delegate Commands", "Commanding.vb"), CodeExampleHighlightTokens("DelegateCommand", "Func"), CodeExampleUnderlineTokens("BindCommand")>
    Public NotInheritable Class DelegateCommands
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {commandButton}
        End Function
        <CodeExampleCase("Simple Command")>
        Public Shared Sub SimpleCommand(ByVal commandButton As SimpleButton)
            ' This is simple command that shows a message
            Dim command As New DelegateCommand(Sub() XtraMessageBox.Show("Hello! I'm running!"))
            ' UI binding for button
            commandButton.BindCommand(command)
        End Sub
        <CodeExampleCase("Command with CanExecute condition")>
        Public Shared Sub CommandWithCanExecuteCondition(ByVal commandButton As SimpleButton)
            Dim canExecute As Func(Of Boolean) = Function() (2 + 2 = 4)
            ' This command is created with the `canExecute` parameter.
            Dim command As New DelegateCommand(Sub() XtraMessageBox.Show("Hello! I'm running, because the `canExecute` condition is `True`. Try to change this condition!"), canExecute)
            ' UI binding for button
            commandButton.BindCommand(command)
        End Sub
        <CodeExampleCase("Parameterized Command")>
        Public Shared Sub ParameterizedCommand(ByVal commandButton As SimpleButton)
            ' This command is created as parameterized.
            Dim command As New DelegateCommand(Of Object)(Sub(v) XtraMessageBox.Show(String.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", v)))
            '
            Dim parameter As Object = 5
            ' UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, Function() parameter)
        End Sub
        <CodeExampleCase("Parameterized Command with CanExecute condition")>
        Public Shared Sub ParameterizedCommandWithCanExecuteCondition(ByVal commandButton As SimpleButton)
            Dim canExecute As Func(Of Integer, Boolean) = Function(p) (2 + 2 = p)
            ' This command is created as parameterized and with `canExecute` parameter.
            Dim command As New DelegateCommand(Of Integer)(
                Sub(v) XtraMessageBox.Show(
                    String.Format(
                                "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                                "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                                "Try to change this parameter!", v)), canExecute)
            '
            Dim parameter As Integer = 4
            ' UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, Function() parameter)
        End Sub
    End Class

    <CodeExampleClass(".NET 7+ Command Binding", "Commanding.cs")>
    <CodeExampleHighlightTokens("DelegateCommand", "Func")>
    <CodeExampleUnderlineTokens("Command", "CommandParameter")>
    Public NotInheritable Class ModernWinFormsCommands
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim commandButton As SimpleButton = New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {commandButton}
        End Function
        <CodeExampleCase("Simple Command Object", New Type() {GetType(CommandObject)})>
        Public Shared Sub SimpleCommandObject(ByVal commandButton As SimpleButton)
            Dim command As CommandObject = New CommandObject()
            ' UI binding for a button.
            commandButton.Command = command
        End Sub
        <CodeExampleCase("Parameterized Command Object", New Type() {GetType(CommandObjectWithParameter)}, GetType(CommandObjectWithParameter))>
        Public Shared Sub ParameterizedCommandWithCanExecuteCondition(ByVal commandButton As SimpleButton)
            Dim command As CommandObjectWithParameter = New CommandObjectWithParameter()
            ' UI binding for a button.
            commandButton.Command = command
            commandButton.CommandParameter = 4
        End Sub
        <CodeExampleCase("Simple DelegateCommand")>
        Public Shared Sub SimpleDelegateCommand(ByVal commandButton As SimpleButton)
            ' This is a simple command that displays a message.
            Dim command As DelegateCommand = New DelegateCommand(Sub()
                                                                     XtraMessageBox.Show("Hello! I'm running!")
                                                                 End Sub)
            ' UI binding for a button.
            commandButton.Command = command
        End Sub
        <CodeExampleCase("Parameterized DelegateCommand")>
        Public Shared Sub ParameterizedDelegateCommand(ByVal commandButton As SimpleButton)
            Dim canExecute As Func(Of Integer, Boolean) = Function(p) (2 + 2 = p)
            ' Creates a parameterized command with the `canExecute` parameter.
            Dim command As DelegateCommand(Of Integer) = New DelegateCommand(Of Integer)(Sub(v)
                                                                                             XtraMessageBox.Show(String.Format("Hello! The parameter passed to command is {0}." & Environment.NewLine & "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine & "Try to change this parameter!", v))
                                                                                         End Sub, canExecute)
            ' UI binding for a button.
            commandButton.Command = command
            commandButton.CommandParameter = 4
        End Sub
        <CodeExampleNestedClass>
        Public Class CommandObject
            Public Sub Execute(ByVal parameter As Object)
                XtraMessageBox.Show("Hello! I'm  Legacy command and I'm running!")
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class CommandObjectWithParameter
            Public Sub Execute(ByVal parameter As Object)
                XtraMessageBox.Show(String.Format("Hello! I'm  Legacy command and the parameter passed to me is {0}." & Environment.NewLine & "I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine & "Try to change this parameter!", parameter))
            End Sub
            Public Function CanExecute(ByVal parameter As Object) As Boolean
                Return Object.Equals(2 + 2, parameter)
            End Function
        End Class
    End Class

    <CodeExampleClass("POCO Commands", "Commanding.vb"), CodeExampleUnderlineTokens("BindCommand")>
    Public NotInheritable Class POCOCommands
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {mvvmContext, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Simple Command", New Type() {GetType(ViewModelWithSimpleCommand)})>
        Public Shared Sub SimpleCommand(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommand)
            ' UI binding for the button
            mvvmContext.BindCommand(Of ViewModelWithSimpleCommand)(commandButton, Sub(x) x.DoSomething())
        End Sub
        <CodeExampleCase("Command with CanExecute condition", New Type() {GetType(ViewModelWithConditionalCommand)})>
        Public Shared Sub CommandWithCanExecuteCondition(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithConditionalCommand)
            ' UI binding for the button
            mvvmContext.BindCommand(Of ViewModelWithConditionalCommand)(commandButton, Sub(x) x.DoSomething())
        End Sub
        <CodeExampleCase("Parameterized Command", New Type() {GetType(ViewModelWithParametrizedCommand)})>
        Public Shared Sub ParameterizedCommand(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithParametrizedCommand)
            '
            Dim parameter As Object = 5
            ' Binding the button to the parameterized command
            mvvmContext.BindCommand(Of ViewModelWithParametrizedCommand, Object)(commandButton, Sub(x, p) x.DoSomething(p), Function(x) parameter)
        End Sub
        <CodeExampleCase("Parameterized Command with CanExecute condition", New Type() {GetType(ViewModelWithParametrizedConditionalCommand)})>
        Public Shared Sub ParameterizedCommandWithCanExecuteCondition(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithParametrizedConditionalCommand)
            '
            Dim parameter As Integer = 4
            ' Binding the button to the parameterized command
            mvvmContext.BindCommand(Of ViewModelWithParametrizedConditionalCommand, Integer)(commandButton, Sub(x, p) x.DoSomething(p), Function(x) parameter)
        End Sub
        <CodeExampleCase("Fluent API for commands", New Type() {GetType(ViewModelWithParametrizedConditionalCommand)})>
        Public Shared Sub ParameterizedCommandWithCanExecuteConditionFluentAPI(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithParametrizedConditionalCommand)
            '
            Dim parameter As Integer = 4
            ' UI binding for button with the `queryParameter` function
            Dim fluent = mvvmContext.OfType(Of ViewModelWithParametrizedConditionalCommand)()
            fluent.BindCommand(commandButton, CType(Sub(x, p) x.DoSomething(p), Expression(Of Action(Of ViewModelWithParametrizedConditionalCommand, Integer))), CType(Function(x) parameter, Expression(Of Func(Of ViewModelWithParametrizedConditionalCommand, Integer))))
        End Sub

        <CodeExampleNestedClass("POCO View Model with simple command")>
        Public Class ViewModelWithSimpleCommand
            ' A POCO-command will be created from this method.
            Public Sub DoSomething()
                XtraMessageBox.Show("Hello! I'm running!")
            End Sub
        End Class
        <CodeExampleNestedClass("POCO View Model with command that depends on specific condition")>
        Public Class ViewModelWithConditionalCommand
            ' A POCO-command will be created from this method.
            Public Sub DoSomething()
                XtraMessageBox.Show("Hello! I'm running, because the `canExecute` condition is `True`.")
            End Sub
            ' The `CanExecute` method for the `SayHello` command.
            Public Function CanDoSomething() As Boolean
                Return (2 + 2) = 4
            End Function
        End Class
        <CodeExampleNestedClass("POCO View Model with command that has a parameter")>
        Public Class ViewModelWithParametrizedCommand
            ' A Parameterized POCO-command will be created from this method.
            Public Sub DoSomething(ByVal p As Object)
                XtraMessageBox.Show(String.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", p))
            End Sub
        End Class
        <CodeExampleNestedClass("POCO View Model with command that has a parameter and depends on specific condition")>
        Public Class ViewModelWithParametrizedConditionalCommand
            ' A parameterized POCO-command will be created from this method.
            Public Sub DoSomething(ByVal p As Integer)
                XtraMessageBox.Show(String.Format("Hello! The parameter passed to command is {0}." & Environment.NewLine & "And I'm running, because the `canExecute` condition is `True` for this parameter." & Environment.NewLine & "Try to change this parameter!", p))
            End Sub
            ' A parameterized `CanExecute` method for the `Say` command.
            Public Function CanDoSomething(ByVal p As Integer) As Boolean
                Return (2 + 2) = p
            End Function
        End Class
    End Class

    <CodeExampleClass("POCO Asynchronous Commands", "Commanding.vb"), CodeExampleHighlightTokens("Task", "IDispatcherService"), CodeExampleUnderlineTokens("BindCommand", "BindCancelCommand", "GetAsyncCommand", "BeginInvoke")>
    Public NotInheritable Class POCOAsyncCommands
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim progressBar As New ProgressBarControl()
            progressBar.Dock = DockStyle.Top

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Start Command Execution"
            commandButton.Dock = DockStyle.Top

            Dim cancelButton As New SimpleButton()
            cancelButton.Text = "Cancel Command Execution"
            cancelButton.Dock = DockStyle.Top

            cancelButton.Parent = sampleHost
            commandButton.Parent = sampleHost
            progressBar.Parent = sampleHost
            Return New Object() {mvvmContext, commandButton, cancelButton, progressBar}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Simple Command", New Type() {GetType(ViewModelWithAsyncCommand)})>
        Public Shared Sub SimpleCommand(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal cancelButton As SimpleButton, ByVal progressBar As ProgressBarControl)
            cancelButton.Visible = False
            progressBar.Visible = False
            '
            mvvmContext.ViewModelType = GetType(ViewModelWithAsyncCommand)
            ' UI binding for the button
            mvvmContext.BindCommand(Of ViewModelWithAsyncCommand)(commandButton, Function(x) x.DoSomethingAsynchronously())
        End Sub
        <CodeExampleCase("Simple Command with Cancellation", New Type() {GetType(ViewModelWithAsyncCommandAndCancellation)})>
        Public Shared Sub SimpleCommandWithCancellation(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal cancelButton As SimpleButton, ByVal progressBar As ProgressBarControl)
            mvvmContext.ViewModelType = GetType(ViewModelWithAsyncCommandAndCancellation)
            ' UI binding for the button
            mvvmContext.BindCommand(Of ViewModelWithAsyncCommandAndCancellation)(commandButton, Sub(x) x.DoSomethingAsynchronously())
            ' UI binding for cancelation
            mvvmContext.BindCancelCommand(Of ViewModelWithAsyncCommandAndCancellation)(cancelButton, Function(x) x.DoSomethingAsynchronously())
            ' UI binding for progress
            mvvmContext.SetBinding(progressBar, Function(p) p.EditValue, "Progress")
        End Sub
        <CodeExampleCase("Fluent API for commands", New Type() {GetType(ViewModelWithAsyncCommandAndCancellation)})>
        Public Shared Sub SimpleCommandWithCancellationFluentAPI(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal cancelButton As SimpleButton, ByVal progressBar As ProgressBarControl)
            mvvmContext.ViewModelType = GetType(ViewModelWithAsyncCommandAndCancellation)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithAsyncCommandAndCancellation)()
            ' UI binding for the button
            fluent.BindCommand(commandButton, Sub(x) x.DoSomethingAsynchronously())
            ' UI binding for cancelation
            ' Fluent API: fluent.BindCancelCommand(cancelButton, Sub(x) x.DoSomethingAsynchronously())
            ' Stub for Demo
            fluent.BindCancelCommand(cancelButton, CType(Sub(x) x.DoSomethingAsynchronously(), Expression(Of Action(Of ViewModelWithAsyncCommandAndCancellation))))
            ' UI binding for progress
            fluent.SetBinding(progressBar, Function(p) p.EditValue, Function(x) x.Progress)
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModelWithAsyncCommand
            ' An asynchronous POCO-command will be created from this method.
            Public Function DoSomethingAsynchronously() As Task
                Return Task.Factory.StartNew(Sub() System.Threading.Thread.Sleep(1000)) ' do some work here
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class ViewModelWithAsyncCommandAndCancellation
            ' An asynchronous POCO-command will be created from this method.
            Public Function DoSomethingAsynchronously() As Task
                Return Task.Factory.StartNew(Sub()
                                                 Dim asyncCommand = Me.GetAsyncCommand(Function(x) x.DoSomethingAsynchronously())
                                                 For i As Integer = 0 To 100
                                                     'cancellation check
                                                     If asyncCommand.IsCancellationRequested Then
                                                         Exit For
                                                     End If
                                                     ' do some work here
                                                     System.Threading.Thread.Sleep(25)
                                                     UpdateProgressOnUIThread(i)
                                                 Next i
                                                 UpdateProgressOnUIThread(0)
                                             End Sub)
            End Function
            ' Property for progress
            Private privateProgress As Integer
            Public Property Progress() As Integer
                Get
                    Return privateProgress
                End Get
                Private Set(ByVal value As Integer)
                    privateProgress = value
                End Set
            End Property
            Protected ReadOnly Property DispatcherService() As IDispatcherService
                Get
                    Return Me.GetService(Of IDispatcherService)()
                End Get
            End Property
            Private Sub UpdateProgressOnUIThread(ByVal progress As Integer)
                DispatcherService.BeginInvoke(Sub()
                                                  Me.Progress = progress
                                                  Me.RaisePropertyChanged(Function(x) x.Progress)
                                              End Sub)
            End Sub
        End Class
    End Class

    <CodeExampleClass("Legacy Commands", "Commanding.vb"), CodeExampleUnderlineTokens("BindCommand")>
    Public NotInheritable Class LegacyCommands

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {commandButton}
        End Function
        <CodeExampleCase("Simple Command", New Type() {GetType(LegacyCommand)})>
        Public Shared Sub SimpleLegacyCommand(ByVal commandButton As SimpleButton)
            ' This is simple legacy-command. It provides the Execute method for doing something.
            Dim command As New LegacyCommand()
            ' UI binding for the button
            commandButton.BindCommand(command)
        End Sub
        <CodeExampleCase("Parameterized Command", New Type() {GetType(LegacyCommandWithParameter)})>
        Public Shared Sub ParameterizedCommandWithCanExecuteCondition(ByVal commandButton As SimpleButton)
            ' This is legacy-command with both Execute(object) and CanExecute(object) methods.
            Dim command As New LegacyCommandWithParameter()
            Dim parameter As Integer = 4
            ' UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, Function() parameter)
        End Sub
        <CodeExampleNestedClass>
        Public Class LegacyCommand
            Public Sub Execute(ByVal parameter As Object)
                XtraMessageBox.Show("Hello! I'm  Legacy command and I'm running!")
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class LegacyCommandWithParameter
            Public Sub Execute(ByVal parameter As Object)
                XtraMessageBox.Show(String.Format("Hello! I'm  Legacy command and the parameter passed to me is {0}." & Environment.NewLine & "I'm running, because the `canExecute` condition is `True` for this parameter." & Environment.NewLine & "Try to change this parameter!", parameter))
            End Sub
            Public Function CanExecute(ByVal parameter As Object) As Boolean
                Return Object.Equals(2 + 2, parameter)
            End Function
        End Class
    End Class

    <CodeExampleClass("The WithCommand extension", "Commanding.vb"), CodeExampleVersionID(162), CodeExampleUnderlineTokens("WithCommand", "Bind")>
    Public NotInheritable Class WithCommandExtention

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim commandButton2 As New SimpleButton()
            commandButton2.Text = "Execute Command 2"
            commandButton2.Dock = DockStyle.Top
            commandButton2.Parent = sampleHost
            commandButton2.Visible = False

            Dim commandButton1 As New SimpleButton()
            commandButton1.Text = "Execute Command 1"
            commandButton1.Dock = DockStyle.Top
            commandButton1.Parent = sampleHost

            Return New Object() {mvvmContext, commandButton1, commandButton2}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Binding to one UI element", New Type() {GetType(ViewModelWithSimpleCommand)})>
        Public Shared Sub BindingToOneElement(ByVal mvvmContext As MVVMContext, ByVal commandButton1 As SimpleButton, ByVal commandButton2 As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommand)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithSimpleCommand)()
            ' UI binding for a single button
            fluent.WithCommand(CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand)))).Bind(commandButton1)
        End Sub
        <CodeExampleCase("Binding to multiple UI elements", New Type() {GetType(ViewModelWithSimpleCommand)})>
        Public Shared Sub BindingToMultipleElement(ByVal mvvmContext As MVVMContext, ByVal commandButton1 As SimpleButton, ByVal commandButton2 As SimpleButton)
            commandButton2.Visible = True
            '
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommand)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithSimpleCommand)()
            ' Binding two different buttons to the same command
            fluent.WithCommand(CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand)))).Bind(commandButton1).Bind(commandButton2)
        End Sub
        <CodeExampleNestedClass("POCO View Model with simple command")>
        Public Class ViewModelWithSimpleCommand
            ' A POCO-command will be created from this method.
            Public Sub DoSomething()
                XtraMessageBox.Show("Hello! I'm running!")
            End Sub
        End Class
    End Class

    <CodeExampleClass("The WithCommand extension for asynchronous commands", "Commanding.vb"), CodeExampleVersionID(162), CodeExampleHighlightTokens("Task", "IDispatcherService"), CodeExampleUnderlineTokens("WithCommand", "Bind", "BindCancel")>
    Public NotInheritable Class WithCommandExtentionAsync

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim progressBar As New ProgressBarControl()
            progressBar.Dock = DockStyle.Top

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Start Command Execution"
            commandButton.Dock = DockStyle.Top

            Dim cancelButton As New SimpleButton()
            cancelButton.Text = "Cancel Command Execution"
            cancelButton.Dock = DockStyle.Top

            cancelButton.Parent = sampleHost
            commandButton.Parent = sampleHost
            progressBar.Parent = sampleHost
            Return New Object() {mvvmContext, commandButton, cancelButton, progressBar}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Binding to asynchronous command", New Type() {GetType(ViewModelWithAsyncCommandAndCancellation)})>
        Public Shared Sub BindingToAsynchronousCommand(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal cancelButton As SimpleButton, ByVal progressBar As ProgressBarControl)
            mvvmContext.ViewModelType = GetType(ViewModelWithAsyncCommandAndCancellation)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithAsyncCommandAndCancellation)()
            ' UI binding for buttons
            fluent.WithCommand(CType(Sub(x) x.DoSomethingAsynchronously(), Expression(Of Action(Of ViewModelWithAsyncCommandAndCancellation)))).Bind(commandButton).BindCancel(cancelButton)
            ' UI binding for progress
            fluent.SetBinding(progressBar, CType(Function(p) p.EditValue, Expression(Of Func(Of ProgressBarControl, Object))), CType(Function(x) x.Progress, Expression(Of Func(Of ViewModelWithAsyncCommandAndCancellation, Object))))
        End Sub
        <CodeExampleNestedClass>
        Public Class ViewModelWithAsyncCommandAndCancellation
            ' An asynchronous POCO-command will be created from this method.
            Public Function DoSomethingAsynchronously() As Task
                Return Task.Factory.StartNew(Sub()
                                                 Dim asyncCommand = Me.GetAsyncCommand(Function(x) x.DoSomethingAsynchronously())
                                                 For i As Integer = 0 To 100
                                                     'cancellation check
                                                     If asyncCommand.IsCancellationRequested Then
                                                         Exit For
                                                     End If
                                                     'do some work here
                                                     System.Threading.Thread.Sleep(25)
                                                     UpdateProgressOnUIThread(i)
                                                 Next i
                                                 UpdateProgressOnUIThread(0)
                                             End Sub)
            End Function
            ' Property for progress
            Private privateProgress As Integer
            Public Property Progress() As Integer
                Get
                    Return privateProgress
                End Get
                Private Set(ByVal value As Integer)
                    privateProgress = value
                End Set
            End Property
            Protected ReadOnly Property DispatcherService() As IDispatcherService
                Get
                    Return Me.GetService(Of IDispatcherService)()
                End Get
            End Property
            Private Sub UpdateProgressOnUIThread(ByVal progress As Integer)
                DispatcherService.BeginInvoke(Sub()
                                                  Me.Progress = progress
                                                  Me.RaisePropertyChanged(Function(x) x.Progress)
                                              End Sub)
            End Sub
        End Class
    End Class

    <CodeExampleClass("Command triggers", "Commanding.vb"), CodeExampleVersionID(162), CodeExampleUnderlineTokens("WithCommand", "After", "Before", "OnCanExecuteChanged")>
    Public NotInheritable Class CommandTriggers

        Private Sub New()
        End Sub

        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim triggerCheckEdit As New CheckEdit()
            triggerCheckEdit.Dock = DockStyle.Top
            triggerCheckEdit.Text = "Allow execute"
            triggerCheckEdit.Parent = sampleHost

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost

            Return New Object() {mvvmContext, triggerCheckEdit, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("A follow-up command", New Type() {GetType(ViewModelWithSimpleCommand)})>
        Public Shared Sub AfterCommandTrigger(ByVal mvvmContext As MVVMContext, ByVal triggerCheckEdit As CheckEdit, ByVal commandButton As SimpleButton)
            triggerCheckEdit.Visible = False
            '
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommand)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithSimpleCommand)()
            fluent.BindCommand(commandButton, CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand))))
            ' After the target comand executes, the message shows up
            fluent.WithCommand(CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand)))).After(CType(Sub() XtraMessageBox.Show("The target command has been executed"), Action))
        End Sub
        <CodeExampleCase("A prelude command", New Type() {GetType(ViewModelWithSimpleCommand)})>
        Public Shared Sub BeforeCommandTrigger(ByVal mvvmContext As MVVMContext, ByVal triggerCheckEdit As CheckEdit, ByVal commandButton As SimpleButton)
            triggerCheckEdit.Visible = False
            '
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommand)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithSimpleCommand)()
            fluent.BindCommand(commandButton, CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand))))
            ' Before the target comand executes, the message shows up
            fluent.WithCommand(CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommand)))).Before(CType(Sub() XtraMessageBox.Show("The target command is about to be executed"), Action))
        End Sub
        <CodeExampleCase("A trigger for the CanExecute condition", New Type() {GetType(ViewModelWithSimpleCommandAndCanExecute)})>
        Public Shared Sub OnCanExecuteCommandTrigger(ByVal mvvmContext As MVVMContext, ByVal triggerCheckEdit As CheckEdit, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithSimpleCommandAndCanExecute)
            Dim fluent = mvvmContext.OfType(Of ViewModelWithSimpleCommandAndCanExecute)()
            fluent.BindCommand(commandButton, CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommandAndCanExecute))))
            'fluent.SetBinding(triggerCheckEdit, Function(e) e.Checked, Function(x) x.AllowExecute)
            fluent.SetBinding(triggerCheckEdit, CType(Function(p) p.EditValue, Expression(Of Func(Of CheckEdit, Object))), CType(Function(x) x.AllowExecute, Expression(Of Func(Of ViewModelWithSimpleCommandAndCanExecute, Object))))
            'When the CanExecute condition changes, the message shows up
            fluent.WithCommand(CType(Sub(x) x.DoSomething(), Expression(Of Action(Of ViewModelWithSimpleCommandAndCanExecute)))).OnCanExecuteChanged(CType(Sub() XtraMessageBox.Show("The CanExecute condition has changed"), Action))
        End Sub
        <CodeExampleNestedClass("POCO View Model with simple command")>
        Public Class ViewModelWithSimpleCommand
            Public Sub DoSomething()
                XtraMessageBox.Show("Hello! I'm running!")
            End Sub
        End Class
        <CodeExampleNestedClass("POCO View Model with a simple command and the CanExecute condition")>
        Public Class ViewModelWithSimpleCommandAndCanExecute
            Public Overridable Property AllowExecute() As Boolean
            Public Sub New()
                AllowExecute = True
            End Sub
            Protected Sub OnAllowExecuteChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.DoSomething())
            End Sub
            Public Function CanDoSomething() As Boolean
                Return AllowExecute
            End Function
            Public Sub DoSomething()
                XtraMessageBox.Show("Hello! I'm running!")
            End Sub
        End Class
    End Class
End Namespace
