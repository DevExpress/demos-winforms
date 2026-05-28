using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Commands", "Commanding.cs")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class POCOCommands {
        static POCOCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Simple Command", new Type[] { typeof(ViewModelWithSimpleCommand) }, typeof(ViewModelWithSimpleCommand))]
        public static void SimpleCommand(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // Binding for the DoSomething command
            fluent.BindCommand(commandButton, x => x.DoSomething);
        }
        [CodeExampleCase("Command with CanExecute condition", new Type[] { typeof(ViewModelWithConditionalCommand) }, typeof(ViewModelWithConditionalCommand))]
        public static void CommandWithCanExecuteCondition(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithConditionalCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithConditionalCommand>();
            // Binding for the DoSomething command
            fluent.BindCommand(commandButton, x => x.DoSomething);
        }
        [CodeExampleCase("Parameterized Command", new Type[] { typeof(ViewModelWithParametrizedCommand) }, typeof(ViewModelWithParametrizedCommand))]
        public static void ParameterizedCommand(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithParametrizedCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithParametrizedCommand>();
            // Binding for the DoSomething command with passing the specific parameter
            object parameter = 5;
            fluent.BindCommand(commandButton, x => x.DoSomething, x => parameter);
        }
        [CodeExampleCase("Parameterized Command with CanExecute condition", new Type[] { typeof(ViewModelWithParametrizedConditionalCommand) }, typeof(ViewModelWithParametrizedConditionalCommand))]
        public static void ParameterizedCommandWithCanExecuteCondition(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithParametrizedConditionalCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithParametrizedConditionalCommand>();
            // Binding for the DoSomething command with passing the specific parameter
            int parameter = 4;
            fluent.BindCommand(commandButton, x => x.DoSomething, x => parameter);
        }
        [CodeExampleNestedClass("POCO View Model with simple command")]
        public class ViewModelWithSimpleCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hello! I'm running!");
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that depends on specific condition")]
        public class ViewModelWithConditionalCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hello! I'm running, because the `canExecute` condition is `True`.");
            }
            // The `CanExecute` method for the `DoSomething` command.
            public bool CanDoSomething() {
                return (2 + 2) == 4;
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that has a parameter")]
        public class ViewModelWithParametrizedCommand {
            // A parameterized POCO-command will be created from this method.
            public void DoSomething(object p) {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage(string.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", p));
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that has a parameter and depends on specific condition")]
        public class ViewModelWithParametrizedConditionalCommand {
            // A parameterized POCO-command will be created from this method.
            public void DoSomething(int p) {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage(string.Format(
                    "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                    "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", p));
            }
            // A parameterized `CanExecute` method for the `DoSomething` command.
            public bool CanDoSomething(int p) {
                return (2 + 2) == p;
            }
        }
    }

    [CodeExampleClass(".NET 7+ Command Binding", "Commanding.cs")]
    [CodeExampleUnderlineTokens("Command", "CommandParameter")]
    [CodeExampleHighlightTokens("DelegateCommand", "Func")]
    public static class ModernWinFormsCommands {
        static ModernWinFormsCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { commandButton };
        }
        [CodeExampleCase("Simple Command Object", new Type[] { typeof(CommandObject) })]
        public static void SimpleCommandObject(SimpleButton commandButton) {
            // This is simple legacy-command. It provides the Execute method for doing something.
            CommandObject command = new CommandObject();
            // UI binding for a button.
            commandButton.Command = command;
        }
        [CodeExampleCase("Parameterized Command Object", new Type[] { typeof(CommandObjectWithParameter) }, typeof(CommandObjectWithParameter))]
        public static void ParameterizedCommandWithCanExecuteCondition(SimpleButton commandButton) {
            // This is legacy-command with both Execute(object) and CanExecute(object) methods.
            CommandObjectWithParameter command = new CommandObjectWithParameter();
            // UI binding for a button.
            commandButton.Command = command;
            commandButton.CommandParameter = 4;
        }
        [CodeExampleCase("Simple DelegateCommand")]
        public static void SimpleDelegateCommand(SimpleButton commandButton) {
            // This is a simple command that displays a message.
            DelegateCommand command = new DelegateCommand(() => {
                XtraMessageBox.Show("Hello! I'm running!");
            });
            // UI binding for a button.
            commandButton.Command = command;
        }
        [CodeExampleCase("Parameterized DelegateCommand")]
        public static void ParameterizedDelegateCommand(SimpleButton commandButton) {
            Func<int, bool> canExecute = (p) => (2 + 2 == p);
            // Creates a parameterized command with the `canExecute` parameter.
            DelegateCommand<int> command = new DelegateCommand<int>((v) => {
                XtraMessageBox.Show(string.Format(
                    "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                    "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", v));
            }, canExecute);
            //
            // UI binding for a button.
            commandButton.Command = command;
            commandButton.CommandParameter = 4;
        }
        [CodeExampleNestedClass]
        public class CommandObject {
            public void Execute(object parameter) {
                XtraMessageBox.Show("Hello! I'm  Legacy command and I'm running!");
            }
        }
        [CodeExampleNestedClass]
        public class CommandObjectWithParameter {
            public void Execute(object parameter) {
                XtraMessageBox.Show(string.Format(
                    "Hello! I'm  Legacy command and the parameter passed to me is {0}." + Environment.NewLine +
                    "I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", parameter));
            }
            public bool CanExecute(object parameter) {
                return object.Equals(2 + 2, parameter);
            }
        }
    }

    [CodeExampleClass("Asynchronous Commands", "Commanding.cs")]
    [CodeExampleHighlightTokens("Task", "IDispatcherService")]
    [CodeExampleUnderlineTokens("BindCommand", "BindCancelCommand", "GetAsyncCommand", "BeginInvoke")]
    public static class POCOAsyncCommands {
        static POCOAsyncCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            ProgressBarControl progressBar = new ProgressBarControl();
            progressBar.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Start Command Execution";
            commandButton.Dock = DockStyle.Top;

            SimpleButton cancelButton = new SimpleButton();
            cancelButton.Text = "Cancel Command Execution";
            cancelButton.Dock = DockStyle.Top;

            cancelButton.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            progressBar.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton, cancelButton, progressBar };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Async Command", new Type[] { typeof(ViewModelWithAsyncCommand) }, typeof(ViewModelWithAsyncCommand))]
        public static void SimpleCommand(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            cancelButton.Visible = false;
            progressBar.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithAsyncCommand>();
            // Binding the DoSomethingAsynchronously async command
            fluent.BindCommand(commandButton, x => x.DoSomethingAsynchronously);
        }
        [CodeExampleCase("Async Command with Cancellation", new Type[] { typeof(ViewModelWithAsyncCommandAndCancellation) }, typeof(ViewModelWithAsyncCommandAndCancellation))]
        public static void SimpleCommandWithCancellation(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommandAndCancellation);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithAsyncCommandAndCancellation>();
            // Binding the DoSomethingAsynchronously async command
            fluent.BindCommand(commandButton, x => x.DoSomethingAsynchronously);
            // Binding the DoSomethingAsynchronously async command canlellation
            fluent.BindCancelCommand(cancelButton, x => x.DoSomethingAsynchronously);
            // One-way binding for displaying progress
            fluent.SetBinding(progressBar, p => p.EditValue, x => x.Progress);
        }
        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommand {
            // An asynchronous POCO-command will be created from this method.
            public async Task DoSomethingAsynchronously() {
                // do some work here
                await Task.Delay(1000);
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommandAndCancellation {
            // An asynchronous POCO-command will be created from this method.
            public async Task DoSomethingAsynchronously() {
                var dispatcher = this.GetService<IDispatcherService>();
                var asyncCommand = this.GetAsyncCommand(x => x.DoSomethingAsynchronously());
                for(int i = 0; i <= 100; i++) {
                    // cancellation check
                    if(asyncCommand.IsCancellationRequested)
                        break;
                    // do some work here
                    await Task.Delay(25);
                    await UpdateProgressOnUIThread(dispatcher, i);
                }
                await UpdateProgressOnUIThread(dispatcher, 0);
            }
            // Property for progress
            public int Progress { 
                get; 
                private set; 
            }
            async Task UpdateProgressOnUIThread(IDispatcherService dispatcher, int progress) {
                await dispatcher.BeginInvoke(() => {
                    Progress = progress;
                    this.RaisePropertyChanged(x => x.Progress);
                });
            }
        }
    }

    [CodeExampleClass("The WithCommand extension", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("WithCommand", "Bind")]
    public static class WithCommandExtention {
        static WithCommandExtention() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);

            SimpleButton commandButton2 = new SimpleButton();
            commandButton2.Text = "Execute Command 2";
            commandButton2.Dock = DockStyle.Top;
            commandButton2.Parent = sampleHost;
            commandButton2.Visible = false;

            SimpleButton commandButton1 = new SimpleButton();
            commandButton1.Text = "Execute Command 1";
            commandButton1.Dock = DockStyle.Top;
            commandButton1.Parent = sampleHost;

            return new object[] { mvvmContext, commandButton1, commandButton2 };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding to one UI element", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BindingToOneElement(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // UI binding for a single button
            fluent.WithCommand(x => x.DoSomething)
                .Bind(commandButton1);
        }
        [CodeExampleCase("Binding to multiple UI elements", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BindingToMultipleElement(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            commandButton2.Visible = true;
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // Binding two different buttons to the same command
            fluent.WithCommand(x => x.DoSomething)
                .Bind(commandButton1)
                .Bind(commandButton2);
        }
        [CodeExampleNestedClass("POCO View Model with simple command")]
        public class ViewModelWithSimpleCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hello! I'm running!");
            }
        }
    }

    [CodeExampleClass("The WithCommand extension for asynchronous commands", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleHighlightTokens("Task", "IDispatcherService")]
    [CodeExampleUnderlineTokens("WithCommand", "Bind", "BindCancel")]
    public static class WithCommandExtentionAsync {
        static WithCommandExtentionAsync() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            ProgressBarControl progressBar = new ProgressBarControl();
            progressBar.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Start Command Execution";
            commandButton.Dock = DockStyle.Top;

            SimpleButton cancelButton = new SimpleButton();
            cancelButton.Text = "Cancel Command Execution";
            cancelButton.Dock = DockStyle.Top;

            cancelButton.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            progressBar.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton, cancelButton, progressBar };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Binding to an asynchronous command", new Type[] { typeof(ViewModelWithAsyncCommandAndCancellation) })]
        public static void BindingToAsynchronousCommand(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommandAndCancellation);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithAsyncCommandAndCancellation>();
            // Binding for buttons
            fluent.WithCommand(x => x.DoSomethingAsynchronously)
                .Bind(commandButton)
                .BindCancel(cancelButton);
            // UI binding for progress
            fluent.SetBinding(progressBar, p => p.EditValue, x => x.Progress);
        }
        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommandAndCancellation {
            // An asynchronous POCO-command will be created from this method.
            public async Task DoSomethingAsynchronously() {
                var dispatcher = this.GetService<IDispatcherService>();
                var asyncCommand = this.GetAsyncCommand(x => x.DoSomethingAsynchronously());
                for(int i = 0; i <= 100; i++) {
                    // cancellation check
                    if(asyncCommand.IsCancellationRequested)
                        break;
                    // do some work here
                    await Task.Delay(25);
                    await UpdateProgressOnUIThread(dispatcher, i);
                }
                await UpdateProgressOnUIThread(dispatcher, 0);
            }
            // Property for progress
            public int Progress {
                get;
                private set;
            }
            async Task UpdateProgressOnUIThread(IDispatcherService dispatcher, int progress) {
                await dispatcher.BeginInvoke(() => {
                    Progress = progress;
                    this.RaisePropertyChanged(x => x.Progress);
                });
            }
        }
    }

    [CodeExampleClass("Command triggers", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("WithCommand", "After", "Before", "OnCanExecuteChanged")]
    public static class CommandTriggers {
        static CommandTriggers() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            CheckEdit triggerCheckEdit = new CheckEdit();
            triggerCheckEdit.Dock = DockStyle.Top;
            triggerCheckEdit.Text = "Allow execute";
            triggerCheckEdit.Parent = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;

            return new object[] { mvvmContext, triggerCheckEdit, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("\"Before\" trigger", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void AfterCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            triggerCheckEdit.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // Bind the DoSomething command
            fluent.BindCommand(commandButton, x => x.DoSomething);
            // After the target comand executes, the message shows up
            fluent.WithCommand(x => x.DoSomething)
                .After(() => XtraMessageBox.Show("The target command has been executed"));
        }
        [CodeExampleCase("\"After\" trigger", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BeforeCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            triggerCheckEdit.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // Bind the DoSomething command
            fluent.BindCommand(commandButton, x => x.DoSomething);
            // Before the target comand executes, the message shows up
            fluent.WithCommand(x => x.DoSomething)
                .Before(() => XtraMessageBox.Show("The target command is about to be executed"));
        }
        [CodeExampleCase("\"CanExecute\" condition trigger", new Type[] { typeof(ViewModelWithSimpleCommandAndCanExecute) })]
        public static void OnCanExecuteCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommandAndCanExecute);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModelWithSimpleCommandAndCanExecute>();
            // Bind the DoSomething command
            fluent.BindCommand(commandButton, x => x.DoSomething);
            fluent.SetBinding(triggerCheckEdit, e => e.Checked, x => x.AllowExecute);
            // When the CanExecute condition changes, the message shows up
            fluent.WithCommand(x => x.DoSomething)
                .OnCanExecuteChanged(() => XtraMessageBox.Show("The CanExecute condition has changed"));
        }
        [CodeExampleNestedClass("POCO View Model with a simple command")]
        public class ViewModelWithSimpleCommand {
            public void DoSomething() {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hello! I'm running!");
            }
        }
        [CodeExampleNestedClass("POCO View Model with a simple command and the CanExecute condition")]
        public class ViewModelWithSimpleCommandAndCanExecute {
            public virtual bool AllowExecute {
                get;
                set;
            }
            public ViewModelWithSimpleCommandAndCanExecute() {
                AllowExecute = true;
            }
            protected void OnAllowExecuteChanged() {
                this.RaiseCanExecuteChanged(x => x.DoSomething());
            }
            public bool CanDoSomething() {
                return AllowExecute;
            }
            public void DoSomething() {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hello! I'm running!");
            }
        }
    }

    [CodeExampleClass("Delegate Commands (Legacy Scenarios)", "Commanding.cs")]
    [CodeExampleHighlightTokens("DelegateCommand", "Func")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class DelegateCommands {
        static DelegateCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { commandButton };
        }
        [CodeExampleCase("Simple Command")]
        public static void SimpleCommand(SimpleButton commandButton) {
            // This is simple command that shows a message
            DelegateCommand command = new DelegateCommand(() => {
                XtraMessageBox.Show("Hello! I'm running!");
            });
            // UI binding for button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Command with CanExecute condition")]
        public static void CommandWithCanExecuteCondition(SimpleButton commandButton) {
            Func<bool> canExecute = () => (2 + 2 == 4);
            // This command is created with the `canExecute` parameter.
            DelegateCommand command = new DelegateCommand(() => {
                XtraMessageBox.Show("Hello! I'm running, because the `canExecute` condition is `True`. Try to change this condition!");
            }, canExecute);
            // UI binding for the button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Parameterized Command")]
        public static void ParameterizedCommand(SimpleButton commandButton) {
            // This command is created as parameterized.
            DelegateCommand<object> command = new DelegateCommand<object>((v) => {
                XtraMessageBox.Show(string.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", v));
            });
            //
            object parameter = 5;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
        [CodeExampleCase("Parameterized Command with CanExecute condition")]
        public static void ParameterizedCommandWithCanExecuteCondition(SimpleButton commandButton) {
            Func<int, bool> canExecute = (p) => (2 + 2 == p);
            // This command is created as parameterized and with `canExecute` parameter.
            DelegateCommand<int> command = new DelegateCommand<int>((v) => {
                XtraMessageBox.Show(string.Format(
                    "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                    "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", v));
            }, canExecute);
            //
            int parameter = 4;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
    }

    [CodeExampleClass("Command Objects (Legacy Scenarios)", "Commanding.cs")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class LegacyCommands {
        static LegacyCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { commandButton };
        }
        [CodeExampleCase("Simple Command", new Type[] { typeof(CommandObject) })]
        public static void SimpleLegacyCommand(SimpleButton commandButton) {
            // This is simple legacy-command. It provides the Execute method for doing something.
            CommandObject command = new CommandObject();
            // UI binding for the button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Parameterized Command", new Type[] { typeof(CommandObjectWithParameter) }, typeof(CommandObjectWithParameter))]
        public static void ParameterizedCommandWithCanExecuteCondition(SimpleButton commandButton) {
            // This is legacy-command with both Execute(object) and CanExecute(object) methods.
            CommandObjectWithParameter command = new CommandObjectWithParameter();
            int parameter = 4;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
        [CodeExampleNestedClass]
        public class CommandObject {
            public void Execute(object parameter) {
                XtraMessageBox.Show("Hello! I'm  Legacy command and I'm running!");
            }
        }
        [CodeExampleNestedClass]
        public class CommandObjectWithParameter {
            public void Execute(object parameter) {
                XtraMessageBox.Show(string.Format(
                    "Hello! I'm  Legacy command and the parameter passed to me is {0}." + Environment.NewLine +
                    "I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", parameter));
            }
            public bool CanExecute(object parameter) {
                return object.Equals(2 + 2, parameter);
            }
        }
    }
}
