using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Simple Behaviors", "Behaviors.cs")]
    [CodeExampleHighlightTokens("ConfirmationBehavior", "ChangingEventArgs", "ConfirmationButtons")]
    [CodeExampleUnderlineTokens("AttachBehavior", "Confirmation")]
    public static class SimpleBehaviors {
        static SimpleBehaviors() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            CheckEdit editor = new CheckEdit();
            editor.Dock = DockStyle.Top;
            editor.Text = "Please, try to change checked state of this editor";
            editor.Parent = sampleHost;

            return new object[] { mvvmContext, editor };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Confirmation Behavior (separate class)", new Type[] { typeof(EditValueChangingConfirmation) })]
        public static void EditValueChangingConfirmationBehavior(MVVMContext mvvmContext, CheckEdit editor) {
            // UI binding for the EditValueChangingConfirmation behavior
            mvvmContext.AttachBehavior<EditValueChangingConfirmation>(editor);
        }
        [CodeExampleCase("Confirmation Behavior (generic ConfirmationBehavior class)")]
        public static void GenericConfirmationBehavior(MVVMContext mvvmContext, CheckEdit editor) {
            // UI binding for the generic ConfirmationBehavior behavior with some specific parameters
            mvvmContext.AttachBehavior<ConfirmationBehavior<ChangingEventArgs>>(editor,
                behavior => {
                    behavior.Caption = "CheckEdit State changing";
                    behavior.Text = "This checkEdit's checked-state is about to be changed. Are you sure?";
                    behavior.Buttons = ConfirmationButtons.YesNo;
                    behavior.ShowQuestionIcon = true;
                }, "EditValueChanging");
        }
        [CodeExampleCase("Confirmation Behavior (Fluent API)")]
        public static void GenericConfirmationBehaviorFluentAPI(MVVMContext mvvmContext, CheckEdit editor) {
            // UI binding for the generic ConfirmationBehavior behavior with some specific parameters
            mvvmContext.WithEvent<ChangingEventArgs>(editor, "EditValueChanging")
                .Confirmation(behavior => {
                    behavior.Caption = "CheckEdit State changing";
                    behavior.Text = "This checkEdit's checked-state is about to be changed. Are you sure?";
                });
        }
        [CodeExampleNestedClass]
        public class EditValueChangingConfirmation : ConfirmationBehavior<ChangingEventArgs> {
            public EditValueChangingConfirmation()
                : base("EditValueChanging") {
            }
            protected override string GetConfirmationCaption() {
                return "EditValue changing confirmation";
            }
            protected override string GetConfirmationText() {
                return "This editor's EditValue is about to be changed. Are you sure?";
            }
        }
    }

    [CodeExampleClass("Event-To-Command Behavior", "Behaviors.cs")]
    [CodeExampleHighlightTokens("EventToCommandBehavior", "EventArgs", "IMessageBoxService")]
    [CodeExampleUnderlineTokens("EventToCommand", "AttachBehavior")]
    public static class EventToCommandBehavior {
        static EventToCommandBehavior() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            Button thirdPartyButton = new Button();
            thirdPartyButton.Dock = DockStyle.Top;
            thirdPartyButton.Text = "Say Hello";
            thirdPartyButton.AutoSize = true;
            thirdPartyButton.Parent = sampleHost;

            return new object[] { mvvmContext, thirdPartyButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Using Commands with third-party controls", new Type[] { typeof(ViewModel), typeof(ClickToSayHello) })]
        public static void CommandForThirdPartyControls(MVVMContext mvvmContext, Button thirdPartyButton) {
            mvvmContext.ViewModelType = typeof(ViewModel);
            // UI binding for the ClickToSayHello behavior
            mvvmContext.AttachBehavior<ClickToSayHello>(thirdPartyButton);
        }
        [CodeExampleCase("Using Commands with third-party controls (Fluent API)", new Type[] { typeof(ViewModel) })]
        public static void CommandForThirdPartyControlsFluentAPI(MVVMContext mvvmContext, Button thirdPartyButton) {
            mvvmContext.ViewModelType = typeof(ViewModel);
            // UI binding for the EventToCommand behavior (using FluentAPI)
            mvvmContext.WithEvent<ViewModel, EventArgs>(thirdPartyButton, "Click")
                .EventToCommand(x => x.SayHello);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            protected IMessageBoxService MessageBoxService {
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void SayHello() {
                MessageBoxService.ShowMessage("Hello!");
            }
        }
        [CodeExampleNestedClass]
        public class ClickToSayHello : DevExpress.Utils.MVVM.EventToCommandBehavior<ViewModel, EventArgs> {
            public ClickToSayHello()
                : base("Click", x => x.SayHello) {
            }
        }
    }

    [CodeExampleClass("Event-To-Command Behavior (Parameters&Converters)", "Behaviors.cs")]
    [CodeExampleHighlightTokens("MouseEventArgs", "MouseButtons", "IMessageBoxService", "Point")]
    [CodeExampleUnderlineTokens("EventToCommand", "WithEvent")]
    public static class EventToCommandBehaviorParametersAndConverters {
        static EventToCommandBehaviorParametersAndConverters() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Top;
            panel.Parent = sampleHost;

            LabelControl label = new LabelControl();
            label.Text = "Click to Execute Command";
            label.Dock = DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Parent = panel;

            return new object[] { mvvmContext, label };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Passing parameters to Commands", new Type[] { typeof(MouseDownAwareViewModel) })]
        public static void ReportMouseDown(MVVMContext mvvmContext, LabelControl label) {
            mvvmContext.ViewModelType = typeof(MouseDownAwareViewModel);
            // UI binding for the EventToCommand behavior
            mvvmContext.OfType<MouseDownAwareViewModel>()
                .WithEvent<MouseEventArgs>(label, "MouseDown")
                .EventToCommand(x => x.Report, x => x.Message);
        }
        [CodeExampleCase("Passing event Arguments to Commands AS IS", new Type[] { typeof(MouseDownAwareViewModel) })]
        public static void ReportMouseDownArgs(MVVMContext mvvmContext, LabelControl label) {
            mvvmContext.ViewModelType = typeof(MouseDownAwareViewModel);
            // UI binding for the EventToCommand behavior
            mvvmContext.OfType<MouseDownAwareViewModel>()
                .WithEvent<MouseEventArgs>(label, "MouseDown")
                .EventToCommand(x => x.ReportArgs);
        }
        [CodeExampleCase("Passing event Arguments to Commands via Converter", new Type[] { typeof(MouseDownAwareViewModel) })]
        public static void ReportMouseDownLocation(MVVMContext mvvmContext, LabelControl label) {
            mvvmContext.ViewModelType = typeof(MouseDownAwareViewModel);
            // UI binding for the EventToCommand behavior
            mvvmContext.OfType<MouseDownAwareViewModel>()
                .WithEvent<MouseEventArgs>(label, "MouseDown")
                .EventToCommand(x => x.ReportLocation, args => args.Location);
        }
        [CodeExampleNestedClass]
        public class MouseDownAwareViewModel {
            public MouseDownAwareViewModel() {
                Message = "MouseDown performed!";
            }
            public string Message { get; set; }
            protected IMessageBoxService MessageBoxService {
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void Report(string message) {
                MessageBoxService.ShowMessage(message);
            }
            public void ReportArgs(MouseEventArgs args) {
                string message = string.Join(", ",
                        "Button: " + args.Button.ToString(),
                        "Location: " + args.Location.ToString(),
                        "Clicks: " + args.Clicks.ToString(),
                        "Delta: " + args.Delta.ToString());
                MessageBoxService.ShowMessage("Args = {" + message + "}");
            }
            public void ReportLocation(Point pt) {
                MessageBoxService.ShowMessage("Location = " + pt.ToString());
            }
        }
    }

    [CodeExampleClass("Event-To-Command Behavior (Reusable Behaviors)", "Behaviors.cs")]
    [CodeExampleHighlightTokens("EventToCommandBehavior", "EventArgs", "IMessageBoxService")]
    [CodeExampleUnderlineTokens("AttachBehavior")]
    public static class EventToCommandBehaviorReusableBehaviors {
        static EventToCommandBehaviorReusableBehaviors() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit sayMessage = new TextEdit();
            sayMessage.Properties.NullValuePrompt = "Enter the message to say";
            sayMessage.Dock = DockStyle.Top;
            sayMessage.Parent = sampleHost;
            sayMessage.Visible = false;

            SimpleButton btn1 = new SimpleButton();
            btn1.Dock = DockStyle.Top;
            btn1.Parent = sampleHost;

            SimpleButton btn2 = new SimpleButton();
            btn2.Dock = DockStyle.Top;
            btn2.Parent = sampleHost;

            return new object[] { mvvmContext, btn1, btn2, sayMessage };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Reusable parameterless behavior", new Type[] { typeof(ViewModel), typeof(ClickToSayHello) })]
        public static void UseClickToSayHello(MVVMContext mvvmContext, SimpleButton btn1, SimpleButton btn2, TextEdit sayMessage) {
            // UI setup
            btn1.Text = btn2.Text = "Click to say \"Hello!\"";
            //
            mvvmContext.ViewModelType = typeof(ViewModel);
            // UI binding for the reusable ClickToSayHello behavior
            mvvmContext.AttachBehavior<ClickToSayHello>(btn1);
            mvvmContext.AttachBehavior<ClickToSayHello>(btn2);
        }
        [CodeExampleCase("Reusable parameterized behavior", new Type[] { typeof(ViewModel), typeof(ClickToSay) })]
        public static void UseClickToSay(MVVMContext mvvmContext, SimpleButton btn1, SimpleButton btn2, TextEdit sayMessage) {
            // UI setup
            btn1.Text = btn2.Text = "Click to say something";
            sayMessage.Visible = true;
            sayMessage.SendToBack();
            //
            mvvmContext.ViewModelType = typeof(ViewModel);
            // UI binding for the Message property
            mvvmContext.OfType<ViewModel>()
                .SetBinding(sayMessage, te => te.EditValue, x => x.Message);
            // UI binding for the reusable ClickToSay behavior
            mvvmContext.AttachBehavior<ClickToSay>(btn1);
            mvvmContext.AttachBehavior<ClickToSay>(btn2);
        }

        [CodeExampleNestedClass]
        public class ViewModel {
            protected IMessageBoxService MessageBoxService {
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void SayHello() {
                MessageBoxService.ShowMessage("Hello!");
            }
            public virtual string Message { get; set; }
            protected virtual void OnMessageChanged() {
                this.RaiseCanExecuteChanged(x => x.Say(null));
            }
            public void Say(string message) {
                MessageBoxService.ShowMessage(message);
            }
            public bool CanSay(string message) {
                return !string.IsNullOrEmpty(message);
            }
        }
        [CodeExampleNestedClass]
        public class ClickToSayHello : DevExpress.Utils.MVVM.EventToCommandBehavior<ViewModel, EventArgs> {
            public ClickToSayHello()
                // specifying command selector
                : base("Click", x => x.SayHello) {
            }
        }
        [CodeExampleNestedClass]
        public class ClickToSay : DevExpress.Utils.MVVM.EventToCommandBehavior<ViewModel, string, EventArgs> {
            public ClickToSay()
                // specifying command selector and command parameters
                : base("Click", x => x.Say, x => x.Message) {
            }
        }
    }

    [CodeExampleClass("Key-To-Command and Keys-To-Command Behaviors", "Behaviors.cs"), CodeExampleVersionID(162)]
    [CodeExampleHighlightTokens("Keys", "KeyEventArgs")]
    [CodeExampleUnderlineTokens("KeyToCommand", "WithKey", "KeysToCommand", "WithKeys")]
    public static class KeyToCommandBehavior {
        static KeyToCommandBehavior() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            UserControl panel = new UserControl();
            panel.Dock = DockStyle.Top;
            panel.Parent = sampleHost;

            MemoEdit memo = new MemoEdit();
            memo.Dock = DockStyle.Fill;
            memo.ReadOnly = true;
            memo.MinimumSize = new Size(0, 100);
            memo.Parent = panel;

            return new object[] { mvvmContext, memo };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Key to Command(Parameterless)", new Type[] { typeof(KeyAwareViewModel) })]
        public static void KeyToCommand(MVVMContext mvvmContext, MemoEdit memo) {
            memo.Text = "Click here and press the A or Alt+A keys to execute a command";
            //
            mvvmContext.ViewModelType = typeof(KeyAwareViewModel);
            // UI binding for the KeyToCommand behavior
            mvvmContext.OfType<KeyAwareViewModel>()
                .WithKey(memo, Keys.A)
                .KeyToCommand(x => x.OnAKey);
            mvvmContext.OfType<KeyAwareViewModel>()
                .WithKey(memo, Keys.A | Keys.Alt)
                .KeyToCommand(x => x.OnAltAKey);
        }
        [CodeExampleCase("Keys to Command(Passing Keys as Command parameter)", new Type[] { typeof(KeyAwareViewModel) })]
        public static void KeysToCommand(MVVMContext mvvmContext, MemoEdit memo) {
            memo.Text = "Click here and press A, B or C to display short key information. Press the same keys with the Shift modifier to view detailed information.";
            //
            mvvmContext.ViewModelType = typeof(KeyAwareViewModel);
            // UI binding for the KeysToCommand behavior
            mvvmContext.OfType<KeyAwareViewModel>()
                .WithKeys(memo, new Keys[] { Keys.A, Keys.B, Keys.C })
                .KeysToCommand(x => x.OnKey, args => args.KeyCode);
            // UI binding for the KeysToCommand behavior
            mvvmContext.OfType<KeyAwareViewModel>()
                .WithKeys(memo, new Keys[] { Keys.Shift | Keys.A, Keys.Shift | Keys.B, Keys.Shift | Keys.C })
                .KeysToCommand(x => x.OnKeyArgs, args => args);
        }
        [CodeExampleNestedClass]
        public class KeyAwareViewModel {
            protected IMessageBoxService MessageBoxService {
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void OnAKey() {
                MessageBoxService.ShowMessage("Key Command: A");
            }
            public void OnAltAKey() {
                MessageBoxService.ShowMessage("Key Command: Alt+A");
            }
            public void OnKey(Keys keys) {
                MessageBoxService.ShowMessage("Key Command: " + keys.ToString());
            }
            public void OnKeyArgs(KeyEventArgs args) {
                string message = string.Join(", ",
                    "KeyValue: " + args.KeyValue.ToString(),
                    "KeyData: " + args.KeyData.ToString(),
                    "KeyCode: " + args.KeyCode.ToString(),
                    "Modifiers: " + args.Modifiers.ToString());
                MessageBoxService.ShowMessage("Args = {" + message + "}");
            }
        }
    }
}
