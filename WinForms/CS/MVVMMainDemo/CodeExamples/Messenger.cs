using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Messenger", "Messenger.cs")]
    [CodeExampleHighlightTokens("Messenger", "CustomMessage", "TokenizedMessage", "DockStyle", "Environment")]
    [CodeExampleUnderlineTokens("Send", "Register")]
    public static class MessengerSamples {
        static MessengerSamples() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton sendMessageButton = new SimpleButton();
            sendMessageButton.Text = "Send Message";
            sendMessageButton.Dock = DockStyle.Top;
            sendMessageButton.Parent = sampleHost;
            return new object[] { mvvmContext, sendMessageButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Sending and receiving Messages", new Type[] { typeof(ViewModel), typeof(MessageAwareView) })]
        public static void SendingAndReceivingMessages(MVVMContext mvvmContext, SimpleButton sendMessageButton) {
            // add another view
            MessageAwareView msgView = new MessageAwareView();
            msgView.Parent = sendMessageButton.Parent;
            msgView.BringToFront();
            // start listening the ViewModel's string messages in View1
            msgView.RegisterAsStringMessageRecepient();

            mvvmContext.ViewModelType = typeof(ViewModel);
            // UI bindings for SendStringMessage commands
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.BindCommand(sendMessageButton, x => x.SendStringMessage);
        }
        [CodeExampleCase("Sending and receiving custom Messages", new Type[] { typeof(ViewModelWithCustomMessage), typeof(CustomMessageAwareView) })]
        public static void SendingAndReceivingCustomMessages(MVVMContext mvvmContext, SimpleButton sendMessageButton) {
            // add another view
            CustomMessageAwareView msgView = new CustomMessageAwareView();
            msgView.Parent = sendMessageButton.Parent;
            msgView.BringToFront();
            // start listening the ViewModel's custom messages  in View
            msgView.RegisterAsCustomMessageRecepient();

            mvvmContext.ViewModelType = typeof(ViewModelWithCustomMessage);
            // UI bindings for SendCustomMessage commands
            var fluent = mvvmContext.OfType<ViewModelWithCustomMessage>();
            fluent.BindCommand(sendMessageButton, x => x.SendCustomMessage);
        }
        [CodeExampleCase("Sending and receiving tokenized Messages", new Type[] { typeof(ViewModelWithTokenizedMessages), typeof(TokenizedMessagesAwareView) })]
        public static void SendingAndReceivingTokenizedMessages(MVVMContext mvvmContext, SimpleButton sendMessageButton) {
            // add another view
            TokenizedMessagesAwareView msgView = new TokenizedMessagesAwareView();
            msgView.Parent = sendMessageButton.Parent;
            msgView.BringToFront();
            // start listening the ViewModel's custom messages  in View
            msgView.RegisterAsCustomMessageRecepient();

            mvvmContext.ViewModelType = typeof(ViewModelWithTokenizedMessages);
            // UI bindings for SendCustomMessage commands
            var fluent = mvvmContext.OfType<ViewModelWithTokenizedMessages>();
            fluent.BindCommand(sendMessageButton, x => x.SendTokenizedMessage);
        }
        //
        [CodeExampleNestedClass]
        public class ViewModel {
            public void SendStringMessage() {
                Messenger.Default.Send("Something happens!");
            }
        }
        [CodeExampleNestedClass]
        public class MessageAwareView : XtraUserControl {
            MemoEdit memo;
            public MessageAwareView() {
                this.Padding = new Padding(0, 0, 0, 4);
                this.Dock = DockStyle.Fill;
                memo = new MemoEdit();
                memo.Dock = DockStyle.Fill;
                memo.Parent = this;
            }
            public void RegisterAsStringMessageRecepient() {
                Messenger.Default.Register<string>(this, OnStringMessage);
            }
            void OnStringMessage(string message) {
                memo.Text += ("String message: " + message + Environment.NewLine);
                memo.SelectionStart = memo.Text.Length;
                memo.ScrollToCaret();
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithCustomMessage {
            public void SendCustomMessage() {
                var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
                Messenger.Default.Send(new CustomMessage() { Parameter = rnd.Next(0, 100) });
            }
            // Custom Message related to this ViewModel
            public class CustomMessage {
                public object Parameter { get; set; }
                public override string ToString() {
                    return string.Format("CustomMessage: {0}!", Parameter);
                }
            }
        }
        [CodeExampleNestedClass]
        public class CustomMessageAwareView : XtraUserControl {
            MemoEdit memo;
            public CustomMessageAwareView() {
                this.Padding = new Padding(0, 0, 0, 4);
                this.Dock = DockStyle.Fill;
                memo = new MemoEdit();
                memo.Dock = DockStyle.Fill;
                memo.Parent = this;
            }
            public void RegisterAsCustomMessageRecepient() {
                Messenger.Default.Register<ViewModelWithCustomMessage.CustomMessage>(this, OnCustomMessage);
            }
            void OnCustomMessage(ViewModelWithCustomMessage.CustomMessage message) {
                memo.Text += (message.ToString() + Environment.NewLine);
                memo.SelectionStart = memo.Text.Length;
                memo.ScrollToCaret();
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithTokenizedMessages {
            public void SendTokenizedMessage() {
                var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
                int parameter = rnd.Next(0, 100);
                var msg = new TokenizedMessage() { Parameter = parameter };
                if(parameter % 10 == 0)
                    Messenger.Default.Send(msg, "Ten");
                else
                    Messenger.Default.Send(msg, (parameter % 2 == 1) ? "Odd" : "Even");
            }
            // Message related to this ViewModel (will be dispatched via string token)
            public class TokenizedMessage {
                public object Parameter { get; set; }
            }
        }
        [CodeExampleNestedClass]
        public class TokenizedMessagesAwareView : XtraUserControl {
            MemoEdit memo;
            public TokenizedMessagesAwareView() {
                this.Padding = new Padding(0, 0, 0, 4);
                this.Dock = DockStyle.Fill;
                memo = new MemoEdit();
                memo.Dock = DockStyle.Fill;
                memo.Parent = this;
            }
            public void RegisterAsCustomMessageRecepient() {
                Messenger.Default.Register<ViewModelWithTokenizedMessages.TokenizedMessage>(this, "Odd", OnOddMessage);
                Messenger.Default.Register<ViewModelWithTokenizedMessages.TokenizedMessage>(this, "Even", OnEvenMessage);
                Messenger.Default.Register<ViewModelWithTokenizedMessages.TokenizedMessage>(this, "Ten", OnTenMessage);
            }
            void OnOddMessage(ViewModelWithTokenizedMessages.TokenizedMessage message) {
                LogMessage("Odd: " + message.Parameter.ToString());
            }
            void OnEvenMessage(ViewModelWithTokenizedMessages.TokenizedMessage message) {
                LogMessage("Even: " + message.Parameter.ToString());
            }
            void OnTenMessage(ViewModelWithTokenizedMessages.TokenizedMessage message) {
                LogMessage("Ten: " + message.Parameter.ToString());
            }
            void LogMessage(string message) {
                memo.Text += (message + Environment.NewLine);
                memo.SelectionStart = memo.Text.Length;
                memo.ScrollToCaret();
            }
        }
    }
}
