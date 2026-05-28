using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("MessageBox Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IMessageBoxService")]
    [CodeExampleUnderlineTokens("RegisterMessageBoxService", "RegisterXtraMessageBoxService", "RegisterFlyoutMessageBoxService", "ShowMessage")]
    public static class MessageBoxServices {
        static MessageBoxServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(SayHelloViewModel);

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Say Hello";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext.RegisterXtraMessageBoxService();
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("MessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void MessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the MessageBoxService
            MVVMContext.RegisterMessageBoxService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<SayHelloViewModel>();
            // Bind the SayHello command
            fluent.BindCommand(commandButton, x => x.SayHello);
        }
        [CodeExampleCase("XtraMessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void XtraMessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the XtraMessageBoxService
            MVVMContext.RegisterXtraMessageBoxService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<SayHelloViewModel>();
            // Bind the SayHello command
            fluent.BindCommand(commandButton, x => x.SayHello);
        }
        [CodeExampleCase("FlyoutMessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void FlyoutMessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the FlyoutMessageBoxService
            MVVMContext.RegisterFlyoutMessageBoxService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<SayHelloViewModel>();
            // Bind the SayHello command
            fluent.BindCommand(commandButton, x => x.SayHello);
        }
        //
        [CodeExampleNestedClass]
        public class SayHelloViewModel {
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void SayHello() {
                // using the MessageBoxService.ShowMessage method
                if(MessageBoxService.ShowMessage("Hello, buddy! Have a nice day!", "Greeting", MessageButton.OK, MessageIcon.Information) == MessageResult.OK) {
                    // do something
                }
            }
        }
    }

    [CodeExampleClass("Current Window Service", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "ICurrentWindowService", "DXWindowState")]
    [CodeExampleUnderlineTokens("WindowState")]
    [CodeExampleVersionID(201)]
    public static class CurrentWindowServices {
        static CurrentWindowServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(CurrentWindowViewModel);

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Maximize or Restore Current Window";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext.RegisterXtraMessageBoxService();
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Maximize or restore current form", new Type[] { typeof(CurrentWindowViewModel) })]
        public static void MaximizeOrRestoreCurrentWindow(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<CurrentWindowViewModel>();
            // Bind the MaximizeOrRestoreCurrentWindow command
            fluent.BindCommand(commandButton, x => x.MaximizeOrRestoreCurrentWindow);
        }
        //
        [CodeExampleNestedClass]
        public class CurrentWindowViewModel {
            protected ICurrentWindowService CurrentWindowService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ICurrentWindowService>(); }
            }
            public void MaximizeOrRestoreCurrentWindow() {
                // using the CurrentWindowService.WindowState property
                if(CurrentWindowService.WindowState == DXWindowState.Normal) {
                    CurrentWindowService.WindowState = DXWindowState.Maximized;
                }
                else {
                    CurrentWindowService.WindowState = DXWindowState.Normal;
                }
            }
        }
    }

    [CodeExampleClass("Current Dialog Service", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "ICurrentDialogService", "MessageResult")]
    [CodeExampleUnderlineTokens("Close")]
    [CodeExampleVersionID(201)]
    public static class CurrentDialogServices {
        static CurrentDialogServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(ViewModel);

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Show Dialog";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext.RegisterXtraMessageBoxService();
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Close dialog with specific result", new Type[] { typeof(ViewModel), typeof(QuestionViewModel), typeof(QuestionView) })]
        public static void MaximizeOrRestoreCurrentWindow(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ViewModel>();
            // Bind the ShowDialog command
            fluent.BindCommand(commandButton, x => x.ShowDialog);
        }
        //
        [CodeExampleNestedClass]
        public class ViewModel {
            protected IDialogService DialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IDialogService>(); }
            }
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void ShowDialog() {
                var toBeorNot = DialogService.ShowDialog(MessageButton.YesNoCancel, "To be or not to be?", "QuestionView", null, this);
                if(toBeorNot != MessageResult.Cancel)
                    MessageBoxService.ShowMessage(toBeorNot.ToString() + "!!!");
            }
        }
        [CodeExampleNestedClass]
        public class QuestionViewModel {
            protected ICurrentDialogService CurrentDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ICurrentDialogService>(); }
            }
            public void CloseAsYes() {
                CurrentDialogService.Close(MessageResult.Yes);
            }
            public void CloseAsNo() {
                CurrentDialogService.Close(MessageResult.No);
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("QuestionView")]
        public class QuestionView : XtraUserControl {
            public QuestionView() {
                this.Padding = new Padding(12);
                this.MinimumSize = new System.Drawing.Size(320, 160);
                //
                MVVMContext mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(QuestionViewModel);
                //
                SimpleButton commandButtonYes = new SimpleButton();
                commandButtonYes.Text = "To be!";
                commandButtonYes.Dock = DockStyle.Top;
                //
                SimpleButton commandButtonNo = new SimpleButton();
                commandButtonNo.Text = "Or not!";
                commandButtonNo.Dock = DockStyle.Top;
                //
                this.Controls.Add(commandButtonNo);
                this.Controls.Add(commandButtonYes);
                // Data-binding for Answers
                var fluent = mvvmContext.OfType<QuestionViewModel>();
                fluent.BindCommand(commandButtonYes, x => x.CloseAsYes);
                fluent.BindCommand(commandButtonNo, x => x.CloseAsNo);
            }
        }
    }

    [CodeExampleClass("Dialog Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IDialogService", "ISupportParameter")]
    [CodeExampleUnderlineTokens("RegisterXtraDialogService", "RegisterRibbonDialogService", "RegisterFlyoutDialogService", "ShowDialog")]
    public static class DialogServices {
        static DialogServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(NotesViewModel);

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Edit Notes";
            commandButton.Dock = DockStyle.Top;

            MemoEdit memo = new MemoEdit();
            memo.Dock = DockStyle.Top;
            memo.Properties.ReadOnly = true;
            memo.MinimumSize = new System.Drawing.Size(0, 100);

            commandButton.Parent = sampleHost;
            memo.Parent = sampleHost;

            return new object[] { mvvmContext, commandButton, memo };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("XtraDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void XtraDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the XtraDialogService
            MVVMContext.RegisterXtraDialogService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<NotesViewModel>();
            // One-way binding for the Notes
            fluent.SetBinding(memo, m => m.EditValue, x=> x.Notes);
            // Bind the EditNotes command
            fluent.BindCommand(commandButton, x => x.EditNotes);
        }
        [CodeExampleCase("FlyoutDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void FlyoutDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the FlyoutDialogService
            MVVMContext.RegisterFlyoutDialogService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<NotesViewModel>();
            // One-way binding for the Notes
            fluent.SetBinding(memo, m => m.EditValue, x => x.Notes);
            // Bind the EditNotes command
            fluent.BindCommand(commandButton, x => x.EditNotes);
        }
        [CodeExampleCase("RibbonDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void RibbonDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the RibbonDialogService
            MVVMContext.RegisterRibbonDialogService();
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<NotesViewModel>();
            // One-way binding for the Notes
            fluent.SetBinding(memo, m => m.EditValue, x => x.Notes);
            // Bind the EditNotes command
            fluent.BindCommand(commandButton, x => x.EditNotes);
        }
        [CodeExampleNestedClass]
        public class NotesViewModel {
            public NotesViewModel() {
                Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            }
            public virtual string Notes { 
                get; 
                protected set; 
            }
            // using the GetService<> extension method for obtaining service instance
            protected IDialogService DialogService {
                get { return this.GetService<IDialogService>(); }
            }
            public void EditNotes() {
                var dialogParams = new object[] { Notes };
                if(DialogService.ShowDialog(MessageButton.OKCancel, "Edit Notes", "EditNotes", dialogParams, this) == MessageResult.OK)
                    Notes = dialogParams[0] as string;
            }
        }
        [CodeExampleNestedClass]
        public class EditNotesViewModel : ISupportParameter {
            public virtual string Notes { get; set; }
            protected void OnNotesChanged() {
                parameters[0] = Notes;
            }
            object[] parameters;
            object ISupportParameter.Parameter {
                get { return parameters[0]; }
                set {
                    if(object.ReferenceEquals(parameters, value)) return;
                    parameters = (object[])value;
                    Notes = parameters[0] as string;
                }
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("EditNotes")]
        public class NotesEditor : XtraUserControl {
            public NotesEditor() {
                this.Padding = new Padding(12);
                this.MinimumSize = new System.Drawing.Size(400, 160);
                //
                MVVMContext mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(EditNotesViewModel);
                //
                MemoEdit memo = new MemoEdit();
                memo.Dock = DockStyle.Fill;
                memo.Parent = this;
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<EditNotesViewModel>();
                // Two-way binding for the Notes
                fluent.SetBinding(memo, m => m.EditValue, x => x.Notes);
            }
        }
    }

    [CodeExampleClass("Window Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "WindowService", "IWindowService", "ISupportParameter")]
    [CodeExampleUnderlineTokens("CreateXtraFormService", "CreateRibbonWindowService", "CreateFlyoutWindowService", "Show", "RegisterService")]
    [CodeExampleVersionID(201)]
    public static class WindowServices {
        static WindowServices() {
            // force PresentationFramework loading
            var result = System.Windows.MessageBoxResult.OK;
            DelegateCommand.DefaultUseCommandManager = (result == System.Windows.MessageBoxResult.Cancel);
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ViewModelType = typeof(ViewModel);
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton showButton = new SimpleButton();
            showButton.Text = "Show Window";
            showButton.Dock = DockStyle.Top;

            SimpleButton closeButton = new SimpleButton();
            closeButton.Text = "Close Window";
            closeButton.Dock = DockStyle.Top;

            closeButton.Parent = sampleHost;
            showButton.Parent = sampleHost;

            return new object[] { mvvmContext, showButton, closeButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("XtraForm Service", new Type[] { typeof(ViewModel), typeof(GreetingViewModel), typeof(GreetingView) })]
        public static void XtraFormService(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton closeButton) {
            // Force use the XtraFormService
            var service = WindowService.CreateXtraFormService(mvvmContext.ContainerControl);
            // window customization
            service.StartPosition = FormStartPosition.CenterParent;
            service.WindowStyle = (window) => {
                ((XtraForm)window).ShowInTaskbar = false;
                ((XtraForm)window).CloseBox = false;
            };
            mvvmContext.RegisterService(service);
            // UI binding for buttons
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.BindCommand(showButton, x => x.ShowWindow);
            fluent.BindCommand(closeButton, x => x.CloseWindow);
        }
        [CodeExampleCase("Flyout Window Service", new Type[] { typeof(ViewModel), typeof(GreetingViewModel), typeof(GreetingView) })]
        public static void FlyoutWindowService(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton closeButton) {
            // Force use the FlyoutWindowService
            var service = WindowService.CreateFlyoutWindowService(mvvmContext.ContainerControl);
            mvvmContext.RegisterService(service);
            // UI binding for buttons
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.BindCommand(showButton, x => x.ShowWindow);
            fluent.BindCommand(closeButton, x => x.CloseWindow);
        }
        [CodeExampleCase("Ribbon Window Service", new Type[] { typeof(ViewModel), typeof(GreetingViewModel), typeof(GreetingView) })]
        public static void RibbonWindowService(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton closeButton) {
            // Force use the RibbonWindowService
            var service = WindowService.CreateRibbonWindowService(mvvmContext.ContainerControl);
            // window customization
            service.StartPosition = FormStartPosition.CenterParent;
            service.WindowStyle = (window) => {
                ((XtraForm)window).ShowInTaskbar = false;
                ((XtraForm)window).CloseBox = false;
            };
            mvvmContext.RegisterService(service);
            // UI binding for buttons
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.BindCommand(showButton, x => x.ShowWindow);
            fluent.BindCommand(closeButton, x => x.CloseWindow);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                // we need to update commands state whenever the window is closed by system
                Messenger.Default.Register<GreetingViewModel>(this, OnGreetingDisposed);
            }
            void OnGreetingDisposed(GreetingViewModel source) {
                UpdateCommands();
            }
            // using the GetService<> extension method for obtaining service instance
            protected IWindowService WindowService {
                get { return this.GetService<IWindowService>(); }
            }
            public bool CanShowWindow() {
                return !WindowService.IsWindowAlive;
            }
            public void ShowWindow() {
                WindowService.Title = "Greeting";
                WindowService.Show("GreetingView", "Have a good day!", this);
                UpdateCommands();
            }
            public bool CanCloseWindow() {
                return WindowService.IsWindowAlive;
            }
            public void CloseWindow() {
                WindowService.Close();
                UpdateCommands();
            }
            void UpdateCommands() {
                this.RaiseCanExecuteChanged(x => x.ShowWindow());
                this.RaiseCanExecuteChanged(x => x.CloseWindow());
            }
        }
        [CodeExampleNestedClass]
        public class GreetingViewModel : ISupportParameter, IDisposable {
            void IDisposable.Dispose() {
                Messenger.Default.Send(this);
            }
            object ISupportParameter.Parameter {
                get { return Greeting; }
                set { Greeting = value as string; }
            }
            public virtual string Greeting {
                get;
                protected set;
            }
        }
        [CodeExampleNestedClass]
        public class GreetingView : XtraUserControl {
            MVVMContext mvvmContext;
            public GreetingView() {
                this.Padding = new Padding(12);
                this.MinimumSize = new System.Drawing.Size(500, 160);
                //
                mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(GreetingViewModel);
                //
                LabelControl label = new LabelControl();
                label.Dock = DockStyle.Fill;
                label.AutoSizeMode = LabelAutoSizeMode.None;
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                label.Parent = this;
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<GreetingViewModel>();
                // One-way binding for the Greeting
                fluent.SetBinding(label, l => l.Text, x => x.Greeting);
            }
            protected override void Dispose(bool disposing) {
                base.Dispose(disposing);
                mvvmContext.Dispose();
            }
        }
    }

    [CodeExampleClass("DocumentManager Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IDocumentManagerService", "IDocumentContent", "IDocumentOwner", "DocumentManagerService", "NavigationFrame", "XtraTabControl", "TabPane")]
    [CodeExampleUnderlineTokens("DocumentManagerService", "Create", "FindDocumentById", "CreateDocument", "Close", "UseDeferredLoading")]
    public static class DocumentManagerServices {
        static DocumentManagerServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;
            mvvmContext.ViewModelType = typeof(RootViewModel);

            SimpleButton commandButton1 = new SimpleButton();
            commandButton1.Text = "Show Document A";
            commandButton1.Dock = DockStyle.Top;

            SimpleButton commandButton2 = new SimpleButton();
            commandButton2.Text = "Show Document B";
            commandButton2.Dock = DockStyle.Top;

            commandButton1.Parent = sampleHost;
            commandButton2.Parent = sampleHost;

            return new object[] { mvvmContext, commandButton1, commandButton2 };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("NavigationFrame as DocumentManager Service", new Type[] {
            typeof(RootViewModel),
            typeof(FirstViewModel), typeof(FirstView),
            typeof(SecondViewModel), typeof(SecondView)
        })]
        public static void NavigationFrameAsDocumentManagerService(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            NavigationFrame navigationFrame = new NavigationFrame();
            navigationFrame.Dock = DockStyle.Fill;
            navigationFrame.Parent = mvvmContext.ContainerControl;
            navigationFrame.BringToFront();
            // Register the DocumentManagerService instance
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<RootViewModel>();
            fluent.BindCommand(commandButton1, x => x.ShowViewA);
            fluent.BindCommand(commandButton2, x => x.ShowViewB);
        }
        [CodeExampleCase("Deferred Load in DocumentManager Service (TabPane)", new Type[] {
            typeof(RootViewModel),
            typeof(FirstViewModel), typeof(FirstView),
            typeof(SecondViewModel), typeof(SecondView)
        })]
        [CodeExampleVersionID(201)]
        public static void TabPaneAsDocumentManagerServiceDeferredLoad(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            TabPane tabPane = new TabPane();
            tabPane.Dock = DockStyle.Fill;
            tabPane.Parent = mvvmContext.ContainerControl;
            tabPane.BringToFront();
            // Register the DocumentManagerService instance
            var service = DocumentManagerService.Create(tabPane);
            service.UseDeferredLoading = DevExpress.Utils.DefaultBoolean.True;
            mvvmContext.RegisterService(service);
            // UI binding for buttons
            var fluent = mvvmContext.OfType<RootViewModel>();
            fluent.BindCommand(commandButton1, x => x.ShowViewA);
            fluent.BindCommand(commandButton2, x => x.ShowViewB);
        }
        [CodeExampleCase("TabControl as DocumentManager Service", new Type[] {
            typeof(RootViewModel),
            typeof(FirstViewModel), typeof(FirstView),
            typeof(SecondViewModel), typeof(SecondView)
        })]
        public static void TabControlAsDocumentManagerService(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            XtraTabControl xtraTabControl = new XtraTabControl();
            xtraTabControl.Dock = DockStyle.Fill;
            xtraTabControl.Parent = mvvmContext.ContainerControl;
            xtraTabControl.BringToFront();
            // Register the DocumentManagerService instance
            mvvmContext.RegisterService(DocumentManagerService.Create(xtraTabControl));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<RootViewModel>();
            fluent.BindCommand(commandButton1, x => x.ShowViewA);
            fluent.BindCommand(commandButton2, x => x.ShowViewB);
        }
        [CodeExampleNestedClass]
        public class RootViewModel {
            // using the GetService<> extension method for obtaining service instance
            protected IDocumentManagerService DocumentManagerService {
                get { return this.GetService<IDocumentManagerService>(); }
            }
            public void ShowViewA() {
                ShowDocumentCore("A");
            }
            public void ShowViewB() {
                ShowDocumentCore("B");
            }
            void ShowDocumentCore(string id) {
                IDocument document = DocumentManagerService.FindDocumentById(id);
                if(document == null) {
                    document = DocumentManagerService.CreateDocument("View" + id, null, this);
                    document.Id = id;
                    document.Title = "Document " + id;
                }
                document.Show();
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("ViewA")]
        public class FirstView : UserControl {
            MVVMContext mvvmContext;
            SimpleButton btnClose;
            public FirstView() {
                mvvmContext = new MVVMContext() { ContainerControl = this };
                mvvmContext.ViewModelType = typeof(FirstViewModel);
                SuspendLayout();
                this.BackColor = System.Drawing.Color.FromArgb(200, 255, 200, 255);
                LabelControl label = new LabelControl() { AutoSizeMode = LabelAutoSizeMode.None, Dock = DockStyle.Fill, Parent = this, Text = "First View" };
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                btnClose = new SimpleButton { Parent = this, Text = "Close Me", Dock = DockStyle.Bottom };
                ResumeLayout();
            }
            protected override void OnLoad(System.EventArgs e) {
                base.OnLoad(e);
                var fluent = mvvmContext.OfType<FirstViewModel>();
                fluent.BindCommand(btnClose, x => x.Close);
            }
        }
        [CodeExampleNestedClass]
        public class FirstViewModel : IDocumentContent {
            public void Close() {
                // close document manually
                DocumentOwner.Close(this);
            }
            public IDocumentOwner DocumentOwner { get; set; }
            public object Title { get; set; }
            void IDocumentContent.OnClose(CancelEventArgs e) {
                /* do something */
            }
            void IDocumentContent.OnDestroy() {
                /* do something */
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("ViewB")]
        public class SecondView : UserControl {
            MVVMContext mvvmContext;
            SimpleButton btnClose;
            public SecondView() {
                mvvmContext = new MVVMContext() { ContainerControl = this };
                mvvmContext.ViewModelType = typeof(SecondViewModel);
                SuspendLayout();
                this.BackColor = System.Drawing.Color.FromArgb(200, 200, 255, 255);
                LabelControl label = new LabelControl() { AutoSizeMode = LabelAutoSizeMode.None, Dock = DockStyle.Fill, Parent = this, Text = "Second View" };
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                btnClose = new SimpleButton { Parent = this, Text = "Close Me", Dock = DockStyle.Bottom };
                ResumeLayout();
            }
            protected override void OnLoad(System.EventArgs e) {
                base.OnLoad(e);
                var fluent = mvvmContext.OfType<SecondViewModel>();
                fluent.BindCommand(btnClose, x => x.Close);
            }
        }
        [CodeExampleNestedClass]
        public class SecondViewModel : IDocumentContent {
            public void Close() {
                // close document manually
                DocumentOwner.Close(this);
            }
            public IDocumentOwner DocumentOwner { get; set; }
            public object Title { get; set; }
            void IDocumentContent.OnClose(CancelEventArgs e) {
                /* do something */
            }
            void IDocumentContent.OnDestroy() {
                /* do something */
            }
        }
    }

    [CodeExampleClass("Layout Serialization Service", "Services.cs")]
    [CodeExampleHighlightTokens("LayoutSerializationService", "ILayoutSerializationService")]
    [CodeExampleUnderlineTokens("Create", "Serialize", "Deserialize")]
    public static class LayoutService {
        static LayoutService() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton saveLayoutButton = new SimpleButton();
            saveLayoutButton.Text = "Save Layout";
            saveLayoutButton.Dock = DockStyle.Top;

            SimpleButton loadLayoutButton = new SimpleButton();
            loadLayoutButton.Text = "Load Layout";
            loadLayoutButton.Dock = DockStyle.Top;

            SplitContainerControl container = new SplitContainerControl();
            container.Dock = DockStyle.Top;
            container.Panel1.BackColor = System.Drawing.Color.LightGray;
            container.Panel2.BackColor = System.Drawing.Color.Beige;

            container.Parent = sampleHost;
            loadLayoutButton.Parent = sampleHost;
            saveLayoutButton.Parent = sampleHost;

            return new object[] { mvvmContext, saveLayoutButton, loadLayoutButton, container };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Save and Load Layout", new Type[] { typeof(LayoutViewModel) })]
        public static void LayoutSerialization(MVVMContext mvvmContext, SimpleButton saveLayoutButton, SimpleButton loadLayoutButton, SplitContainerControl container) {
            mvvmContext.ViewModelType = typeof(LayoutViewModel);
            // Use the LayoutSerializationService for SplitContainerControl
            mvvmContext.RegisterService(LayoutSerializationService.Create(container, true));
            // Binding commands to buttons
            var fluent = mvvmContext.OfType<LayoutViewModel>();
            fluent.BindCommand(saveLayoutButton, x => x.SaveLayout);
            fluent.BindCommand(loadLayoutButton, x => x.LoadLayout);
        }
        [CodeExampleNestedClass]
        public class LayoutViewModel {
            protected ILayoutSerializationService Service {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ILayoutSerializationService>(); }
            }
            protected string Layout { get; private set; }
            public void SaveLayout() {
                // Using the ILayoutSerializationService.Serialize method
                Layout = Service.Serialize();
            }
            public void LoadLayout() {
                // Using the ILayoutSerializationService.Deserialize method
                Service.Deserialize(Layout);
            }
        }
    }

    [CodeExampleClass("Notification Service", "Services.cs")]
    [CodeExampleHighlightTokens("NotificationService", "INotificationService", "INotification", "INotificationInfo")]
    [CodeExampleUnderlineTokens("Create", "ShowAsync", "Hide", "CreatePredefinedNotification", "CreateCustomNotification")]
    [CodeExampleVersionID(161)]
    public static class NotificationServices {
        static NotificationServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton hideNotificationButton = new SimpleButton();
            hideNotificationButton.Text = "Hide Notification";
            hideNotificationButton.Dock = DockStyle.Top;
            hideNotificationButton.Parent = sampleHost;

            SimpleButton showNotificationButton = new SimpleButton();
            showNotificationButton.Text = "Show Notification";
            showNotificationButton.Dock = DockStyle.Top;
            showNotificationButton.Parent = sampleHost;

            AlertControl alertControl = new AlertControl();
            ToastNotificationsManager toastNotificationsManager1 = new ToastNotificationsManager();
            toastNotificationsManager1.ApplicationId = string.Format("Components_{0}_Demo_Center_{0}", AssemblyInfo.VersionShort.Replace(".", "_"));
            toastNotificationsManager1.ApplicationName = "DevAV";

            return new object[] { mvvmContext, showNotificationButton, hideNotificationButton, toastNotificationsManager1, alertControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Predefined Notification(Toast Style)", new Type[] { typeof(HelloViewModel) })]
        public static void ToastNotificationStylePredefinedNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModel);
            // Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager));
            // Binding commands to buttons
            var fluent = mvvmContext.OfType<HelloViewModel>();
            fluent.BindCommand(showNotificationButton, x => x.ShowNotification);
            fluent.BindCommand(hideNotificationButton, x => x.HideNotification);
        }
        [CodeExampleCase("Predefined Notification(Alert Style)", new Type[] { typeof(HelloViewModel) })]
        public static void AlertControlStylePredefinedNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModel);
            // Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl));
            // Binding commands to buttons
            var fluent = mvvmContext.OfType<HelloViewModel>();
            fluent.BindCommand(showNotificationButton, x => x.ShowNotification);
            fluent.BindCommand(hideNotificationButton, x => x.HideNotification);
        }
        [CodeExampleCase("Custom Notification(Toast Style)", new Type[] { typeof(HelloViewModelWithINotificationInfo) })]
        public static void ToastNotificationStyleCustomNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModelWithINotificationInfo);
            // Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager));
            // Binding commands to buttons
            var fluent = mvvmContext.OfType<HelloViewModelWithINotificationInfo>();
            fluent.BindCommand(showNotificationButton, x => x.ShowNotification);
            fluent.BindCommand(hideNotificationButton, x => x.HideNotification);
        }
        [CodeExampleCase("Custom Notification(Alert Style)", new Type[] { typeof(HelloViewModelWithINotificationInfo) })]
        public static void AlertControlStyleCustomNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModelWithINotificationInfo);
            // Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl));
            // Binding commands to buttons
            var fluent = mvvmContext.OfType<HelloViewModelWithINotificationInfo>();
            fluent.BindCommand(showNotificationButton, x => x.ShowNotification);
            fluent.BindCommand(hideNotificationButton, x => x.HideNotification);
        }
        [CodeExampleNestedClass]
        public class HelloViewModel {
            protected INotificationService INotificationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INotificationService>(); }
            }
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            public virtual INotification Notification {
                get;
                set;
            }
            protected virtual void OnNotificationChanged() {
                this.RaiseCanExecuteChanged(x => x.HideNotification());
            }
            List<INotification> notifications = new List<INotification>();
            public async void ShowNotification() {
                // using the INotificationService.CreatePredefinedNotification method
                Notification = INotificationService.CreatePredefinedNotification("Hello, buddy!", "Have a nice day!", "Greeting");
                notifications.Add(Notification);
                // using the INotification.ShowAsync method
                try {
                    await Notification.ShowAsync();
                }
                catch(AggregateException) {
                    // handling errors (you can use the exception information for detailed diagnostic)
                    // Take a look at the https://docs.devexpress.com/WindowsForms/17020/controls-and-libraries/messages-notifications-and-dialogs/toast-notification-manager for details
                    MessageBoxService.ShowMessage("Ensure that showing notifications is enabled at the Windows OS level (Notification & Actions settings)", "Unable to show notification");
                }
            }
            public void HideNotification() {
                // using the INotification.Hide method
                Notification.Hide();
                if(notifications.Remove(Notification))
                    Notification = (notifications.Count == 0) ? null : notifications[notifications.Count - 1];
            }
            public bool CanHideNotification() {
                return Notification != null;
            }
        }
        [CodeExampleNestedClass]
        public class HelloViewModelWithINotificationInfo : INotificationInfo {
            protected INotificationService INotificationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INotificationService>(); }
            }
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            public virtual INotification Notification {
                get;
                set;
            }
            protected virtual void OnNotificationChanged() {
                this.RaiseCanExecuteChanged(x => x.HideNotification());
            }
            List<INotification> notifications = new List<INotification>();
            public async void ShowNotification() {
                // using the INotificationService.CreateCustomNotification method
                Notification = INotificationService.CreateCustomNotification(this);
                notifications.Add(Notification);
                // using the INotification.ShowAsync method
                try {
                    await Notification.ShowAsync();
                }
                catch(AggregateException) {
                    // handling errors (you can use the exception information for detailed diagnostic)
                    // Take a look at the https://docs.devexpress.com/WindowsForms/17020/controls-and-libraries/messages-notifications-and-dialogs/toast-notification-manager for details
                    MessageBoxService.ShowMessage("Ensure that showing notifications is enabled at the Windows OS level (Notification & Actions settings)", "Unable to show notification");
                }
            }
            public void HideNotification() {
                // using the INotification.Hide method
                Notification.Hide();
                if(notifications.Remove(Notification))
                    Notification = (notifications.Count == 0) ? null : notifications[notifications.Count - 1];
            }
            public bool CanHideNotification() {
                return Notification != null;
            }
            #region INotificationInfo
            string INotificationInfo.Header {
                get { return "Hello, buddy!"; }
            }
            string INotificationInfo.Body {
                get { return "Have a nice day!"; }
            }
            string INotificationInfo.Body2 {
                get { return "Greeting"; }
            }
            System.Drawing.Image INotificationInfo.Image {
                get { return null; }
            }
            #endregion
        }
    }

    [CodeExampleClass("SplashScreen Service", "Services.cs")]
    [CodeExampleHighlightTokens("ISplashScreenService", "SplashScreen", "DemoProgressSplashScreen", "CommandId")]
    [CodeExampleUnderlineTokens("Create", "ShowSplashScreen", "SetSplashScreenState", "HideSplashScreen")]
    [CodeExampleVersionID(161)]
    public static class SplashScreenServices {
        static SplashScreenServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton hideButton = new SimpleButton();
            hideButton.Text = "Hide";
            hideButton.Dock = DockStyle.Top;
            hideButton.Parent = sampleHost;

            SimpleButton showButton = new SimpleButton();
            showButton.Text = "Show";
            showButton.Dock = DockStyle.Top;
            showButton.Parent = sampleHost;

            SplashScreenManager splashScreenManager = new SplashScreenManager();

            return new object[] { mvvmContext, showButton, hideButton, splashScreenManager };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Default SplashScreen", new Type[] { typeof(DefaultSplashScreenViewModel) })]
        public static void ShowDefaultSplashScreen(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton hideButton, SplashScreenManager splashScreenManager) {
            hideButton.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(DefaultSplashScreenViewModel);
            // UI binding for button
            var fluent = mvvmContext.OfType<DefaultSplashScreenViewModel>();
            fluent.BindCommand(showButton, x => x.Show);
        }
        [CodeExampleCase("Custom SplashScreen", new Type[] { typeof(CustomSplashScreenViewModel), typeof(CustomSplashScreen) })]
        public static void ShowCustomSplashScreen(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton hideButton, SplashScreenManager splashScreenManager) {
            mvvmContext.ViewModelType = typeof(CustomSplashScreenViewModel);
            // SplashScreenManager setup
            splashScreenManager.Properties.UseFadeInEffect = false;
            splashScreenManager.Properties.UseFadeOutEffect = false;
            // Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<CustomSplashScreenViewModel>();
            fluent.BindCommand(showButton, x => x.Show);
            fluent.BindCommand(hideButton, x => x.Hide);
        }
        [CodeExampleCase("Fluent SplashScreen", new Type[] { typeof(FluentSplashScreenViewModel) }), CodeExampleVersionID(202)]
        public static void ShowFluentSplashScreen(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton hideButton, SplashScreenManager splashScreenManager) {
            mvvmContext.ViewModelType = typeof(FluentSplashScreenViewModel);
            // Setup splashScreen options
            FluentSplashScreenOptions.Default.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            // Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<FluentSplashScreenViewModel>();
            fluent.BindCommand(showButton, x => x.Show);
            fluent.BindCommand(hideButton, x => x.Hide);
        }
        [CodeExampleCase("Wait Form", new Type[] { typeof(WaitFormViewModel), typeof(MyWaitForm) }), CodeExampleVersionID(201)]
        public static void ShowWaitForm(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton hideButton, SplashScreenManager splashScreenManager) {
            hideButton.Visible = false; showButton.Text = "Press to wait";
            //
            mvvmContext.ViewModelType = typeof(WaitFormViewModel);
            // Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<WaitFormViewModel>();
            fluent.BindCommand(showButton, x => x.Wait);
        }
        [CodeExampleCase("Overlay", new Type[] { typeof(OverlayViewModel) }), CodeExampleVersionID(202)]
        public static void ShowOverlay(MVVMContext mvvmContext, SimpleButton showButton, SimpleButton hideButton, SplashScreenManager splashScreenManager) {
            hideButton.Visible = false; showButton.Text = "Press to wait";
            // Setup overlay options
            OverlayWindowOptions.Default.UseDirectX = true;
            //
            mvvmContext.ViewModelType = typeof(OverlayViewModel);
            // Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager));
            // UI binding for buttons
            var fluent = mvvmContext.OfType<OverlayViewModel>();
            fluent.BindCommand(showButton, x => x.Wait);
        }

        [CodeExampleNestedClass]
        public class DefaultSplashScreenViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public void Show() {
                // Using the ISplashScreenService.ShowSplashScreen method with null parameters that show default SplashScreen
                SplashScreenService.ShowSplashScreen(null);
                // Using the ISplashScreenService.SetSplashScreenState
                SplashScreenService.SetSplashScreenState("Loading...");
                int maxProgress = 10000;
                for(int i = 1; i <= maxProgress; i++) {
                    // using the ISplashScreenService.SetSplashScreenProgress
                    SplashScreenService.SetSplashScreenProgress(i, maxProgress);
                }
                Hide();
            }
            public void Hide() {
                // Using the ISplashScreenService.HideSplashScreen method
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class CustomSplashScreenViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method to obtain the service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public void Show() {
                // Showing the splash screen
                SplashScreenService.ShowSplashScreen("CustomSplashScreen");
                // Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Hello, buddy! Have a nice day!");
            }
            public void Hide() {
                // Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Bye!");
                System.Threading.Thread.Sleep(1000);
                // Hiding the splash screen
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class WaitFormViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method to obtain the service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public async System.Threading.Tasks.Task Wait() {
                //Find the Wait Form by its type name and show it
                SplashScreenService.ShowSplashScreen("MyWaitForm");
                //Set Wait Form captions
                SplashScreenService.SetSplashScreenState(new string[] {
                    "Please, wait", "In progress..."
                });
                // Doing something
                await System.Threading.Tasks.Task.Delay(2500);
                // Hiding the wait form
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class OverlayViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method to obtain the service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public async System.Threading.Tasks.Task Wait() {
                //show the Overlay via the special type name
                SplashScreenService.ShowSplashScreen("#Overlay#");
                // Doing something
                await System.Threading.Tasks.Task.Delay(2500);
                // Hiding the wait form
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class FluentSplashScreenViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method to obtain the service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public void Show() {
                // Showing the Fluent splash screen (via special type name)
                SplashScreenService.ShowSplashScreen("#FluentSplashScreen#");
            }
            public void Hide() {
                System.Threading.Thread.Sleep(1000);
                // Hiding the splash screen
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class CustomSplashScreen : SplashScreen {
            public CustomSplashScreen()
                : base() {
                stateLabel = new Label();
                stateLabel.Text = "State";
                stateLabel.AutoSize = false;
                stateLabel.Dock = DockStyle.Fill;
                stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.Controls.Add(stateLabel);
            }
            Label stateLabel;
            public override void ProcessCommand(Enum cmd, object arg) {
                base.ProcessCommand(cmd, arg);
                DemoProgressSplashScreen.CommandId command = (DemoProgressSplashScreen.CommandId)cmd;
                if(command == DemoProgressSplashScreen.CommandId.MVVMSetState)
                    stateLabel.Text = (string)arg;
            }
        }
        [CodeExampleNestedClass]
        public class MyWaitForm : DevExpress.XtraWaitForm.DemoWaitForm {
            public override void ProcessCommand(Enum cmd, object arg) {
                string[] args = arg as string[];
                SetCaption(args[0]);
                SetDescription(args[1]);
            }
        }
    }

    [CodeExampleClass("Open/Save File Dialog Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IOpenFileDialogService", "ISaveFileDialogService")]
    [CodeExampleUnderlineTokens("ShowDialog", "RegisterSkinnableOpenFileDialogService", "RegisterOpenFileDialogService", "RegisterSkinnableSaveFileDialogService", "RegisterSaveFileDialogService")]
    [CodeExampleVersionID(161)]
    public static class FileDialogServices {
        static FileDialogServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            MemoEdit logMemoEdit = new MemoEdit();
            logMemoEdit.ReadOnly = true;
            logMemoEdit.Dock = DockStyle.Fill;
            logMemoEdit.Parent = sampleHost;

            SimpleButton showDialogButton = new SimpleButton();
            showDialogButton.Text = "Show Dialog";
            showDialogButton.Dock = DockStyle.Top;
            showDialogButton.Parent = sampleHost;

            return new object[] { mvvmContext, showDialogButton, logMemoEdit };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Open File Dialog Service", new Type[] { typeof(OpenFileDialogViewModel) })]
        public static void ShowOpenFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the standard OpenFileDialog
            MVVMContext.RegisterOpenFileDialogService();

            mvvmContext.ViewModelType = typeof(OpenFileDialogViewModel);
            var fluent = mvvmContext.OfType<OpenFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleCase("Skinnable Open File Dialog Service", new Type[] { typeof(OpenFileDialogViewModel) })]
        [CodeExampleVersionID(181)]
        public static void ShowSkinnableOpenFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the skinnable OpenFileDialog
            MVVMContext.RegisterSkinnableOpenFileDialogService();

            mvvmContext.ViewModelType = typeof(OpenFileDialogViewModel);
            var fluent = mvvmContext.OfType<OpenFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleCase("Custom OpenFileDialog", new Type[] { typeof(OpenFileDialogViewModel) })]
        [CodeExampleVersionID(191)]
        public static void CreateCustomOpenFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(OpenFileDialogViewModel);

            // Create a custom dialog
            var openFileDialog = new OpenFileDialog();
            //Custom dialog ignores service settings
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Custom Dialog Title";
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.OpenFileDialogService.Create(openFileDialog));

            var fluent = mvvmContext.OfType<OpenFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleCase("Save File Dialog Service", new Type[] { typeof(SaveFileDialogViewModel) })]
        public static void ShowSaveFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the standard SaveFileDialog
            MVVMContext.RegisterSaveFileDialogService();

            mvvmContext.ViewModelType = typeof(SaveFileDialogViewModel);
            var fluent = mvvmContext.OfType<SaveFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleCase("Skinnable Save File Dialog Service", new Type[] { typeof(SaveFileDialogViewModel) })]
        [CodeExampleVersionID(181)]
        public static void ShowSkinnableSaveFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the skinnable SaveFileDialog
            MVVMContext.RegisterSkinnableSaveFileDialogService();

            mvvmContext.ViewModelType = typeof(SaveFileDialogViewModel);
            var fluent = mvvmContext.OfType<SaveFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleCase("Custom SaveFileDialog", new Type[] { typeof(SaveFileDialogViewModel) })]
        [CodeExampleVersionID(191)]
        public static void CreateCustomSaveFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(SaveFileDialogViewModel);

            // Create a custom dialog
            var saveFileDialog = new SaveFileDialog();
            //Custom dialog ignores service settings
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Custom Dialog Title";
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.SaveFileDialogService.Create(saveFileDialog));

            var fluent = mvvmContext.OfType<SaveFileDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFileDialog);
        }
        [CodeExampleNestedClass]
        public class OpenFileDialogViewModel {
            public OpenFileDialogViewModel() {
                // Set IOpenFileDialogService settings
                this.Title = "Open File Dialog";
                this.Filter = "All Files|*.*|Text|*.txt";
                this.FilterIndex = 2;
            }
            protected IOpenFileDialogService OpenFileDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IOpenFileDialogService>(); }
            }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFileDialog() {
                // Using the IOpenFileDialogService.ShowDialog method
                if(this.OpenFileDialogService.ShowDialog(DialogFileOKCallback, string.Empty))
                    AppendLogString("Open file: " + this.OpenFileDialogService.File.Name);
                else
                    AppendLogString("Cancel");
            }
            public virtual string Log { get; protected set; }
            public virtual string Filter { get; protected set; }
            protected virtual void OnFilterChanged() {
                this.OpenFileDialogService.Filter = this.Filter;
                AppendLogString("Set Filter: " + this.Filter);
            }
            public virtual int FilterIndex { get; protected set; }
            protected virtual void OnFilterIndexChanged() {
                this.OpenFileDialogService.FilterIndex = this.FilterIndex;
                AppendLogString("Set FilterIndex: " + this.FilterIndex.ToString());
            }
            public virtual string Title { get; protected set; }
            protected virtual void OnTitleChanged() {
                this.OpenFileDialogService.Title = this.Title;
                AppendLogString("Set Title: " + this.Title);
            }
            protected virtual void DialogFileOKCallback(System.ComponentModel.CancelEventArgs e) {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("File is opened");
            }
        }
        [CodeExampleNestedClass]
        public class SaveFileDialogViewModel {
            public SaveFileDialogViewModel() {
                // Set ISaveFileDialogService settings
                this.Title = "Save File Dialog";
                this.Filter = "Text|*.txt";
            }
            protected ISaveFileDialogService SaveFileDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ISaveFileDialogService>(); }
            }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFileDialog() {
                // Using the ISaveFileDialogService.ShowDialog method
                if(this.SaveFileDialogService.ShowDialog(DialogFileOKCallback, string.Empty, string.Empty))
                    AppendLogString("Save file: " + this.SaveFileDialogService.File.Name);
                else
                    AppendLogString("Cancel");
            }
            public virtual string Log {
                get; 
                protected set;
            }
            public virtual string Filter {
                get; 
                protected set;
            }
            protected virtual void OnFilterChanged() {
                this.SaveFileDialogService.Filter = this.Filter;
                AppendLogString("Set Filter: " + this.Filter);
            }
            public virtual int FilterIndex { get; protected set; }
            protected virtual void OnFilterIndexChanged() {
                this.SaveFileDialogService.FilterIndex = this.FilterIndex;
                AppendLogString("Set FilterIndex: " + this.FilterIndex.ToString());
            }
            public virtual string Title { get; protected set; }
            protected virtual void OnTitleChanged() {
                this.SaveFileDialogService.Title = this.Title;
                AppendLogString("Set Title: " + this.Title);
            }
            protected virtual void DialogFileOKCallback(System.ComponentModel.CancelEventArgs e) {
                var msgBoxService = this.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("File is saved");
            }
        }
    }

    [CodeExampleClass("FolderBrowser Dialog Service", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IFolderBrowserDialogService", "Environment")]
    [CodeExampleUnderlineTokens("ShowDialog", "RegisterCompactSkinnableFolderBrowserDialogService", "RegisterWideSkinnableFolderBrowserDialogService", "RegisterFolderBrowserDialogService")]
    [CodeExampleVersionID(161)]
    public static class FolderBrowserDialogService {
        static FolderBrowserDialogService() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            MemoEdit logMemoEdit = new MemoEdit();
            logMemoEdit.ReadOnly = true;
            logMemoEdit.Dock = DockStyle.Fill;
            logMemoEdit.Parent = sampleHost;

            SimpleButton showDialogButton = new SimpleButton();
            showDialogButton.Text = "Show Dialog";
            showDialogButton.Dock = DockStyle.Top;
            showDialogButton.Parent = sampleHost;

            return new object[] { mvvmContext, showDialogButton, logMemoEdit };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Folder Browser Dialog Service", new Type[] { typeof(FolderBrowserDialogViewModel) })]
        public static void ShowFolderBrowserDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the standard FolderBrowserDialog
            MVVMContext.RegisterFolderBrowserDialogService();
            mvvmContext.ViewModelType = typeof(FolderBrowserDialogViewModel);
            var fluent = mvvmContext.OfType<FolderBrowserDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFolderDialog);
        }
        [CodeExampleCase("Compact Skinnable Folder Browser Dialog Service", new Type[] { typeof(FolderBrowserDialogViewModel) })]
        [CodeExampleVersionID(181)]
        public static void ShowCompactSkinnableFolderBrowserDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the compact skinnable FolderBrowserDialog
            MVVMContext.RegisterCompactSkinnableFolderBrowserDialogService();

            mvvmContext.ViewModelType = typeof(FolderBrowserDialogViewModel);
            var fluent = mvvmContext.OfType<FolderBrowserDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFolderDialog);
        }
        [CodeExampleCase("Wide Skinnable Folder Browser Dialog Service", new Type[] { typeof(FolderBrowserDialogViewModel) })]
        [CodeExampleVersionID(181)]
        public static void ShowWideSkinnableFolderBrowserDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            // Force use the wide skinnable FolderBrowserDialog
            MVVMContext.RegisterWideSkinnableFolderBrowserDialogService();
            mvvmContext.ViewModelType = typeof(FolderBrowserDialogViewModel);
            var fluent = mvvmContext.OfType<FolderBrowserDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFolderDialog);
        }
        [CodeExampleCase("Custom FolderBrowserDialog", new Type[] { typeof(FolderBrowserDialogViewModel) })]
        [CodeExampleVersionID(191)]
        public static void CreateCustomFolderBrowserDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(FolderBrowserDialogViewModel);
            // Create a custom dialog
            var folderBrowserDialog = new FolderBrowserDialog();
            //Custom dialog ignores service settings
            folderBrowserDialog.ShowNewFolderButton = false;
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.FolderBrowserDialogService.Create(folderBrowserDialog));

            var fluent = mvvmContext.OfType<FolderBrowserDialogViewModel>();
            // UI binding for memoEdit
            fluent.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluent.BindCommand(showDialogButton, x => x.ShowFolderDialog);
        }
        [CodeExampleNestedClass]
        public class FolderBrowserDialogViewModel {
            protected IFolderBrowserDialogService FolderBrowserDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IFolderBrowserDialogService>(); }
            }
            public virtual string Log { get; protected set; }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFolderDialog() {
                if(this.FolderBrowserDialogService.ShowDialog())
                    AppendLogString("Folder path: " + this.FolderBrowserDialogService.ResultPath);
                else
                    AppendLogString("Cancel");
            }
        }
    }

    [CodeExampleClass("Navigation Service", "Services.cs")]
    [CodeExampleVersionID(172)]
    [CodeExampleHighlightTokens("INavigationService,ISupportNavigation")]
    [CodeExampleUnderlineTokens("RegisterDefaultService", "Create")]
    public static class NavigationServiceExample {
        static NavigationServiceExample() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            UserControl mainView = new UserControl();
            mainView.Dock = DockStyle.Fill;

            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = mainView;
            mvvmContext.ViewModelType = typeof(NavigationViewModel);
            NavigationFrame navigationFrame = new NavigationFrame();
            navigationFrame.Dock = DockStyle.Fill;
            navigationFrame.Parent = mainView;

            return new object[] { sampleHost, mainView, mvvmContext, navigationFrame };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Navigation Service", new Type[] {
            typeof(NavigationViewModel), typeof(NavigationViewModelBase),
            typeof(HomeView), typeof(HomeViewModel),
            typeof(DetailView), typeof(DetailViewModel),
            typeof(NextDetailView), typeof(NextDetailViewModel)
        }), CodeExampleVersionID(192)]
        public static void NavigationServiceSample(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, NavigationFrame navigationFrame) {
            // Service registration at the Application level
            mvvmContext.RegisterDefaultService(NavigationService.Create(navigationFrame));
            // Navigate to the specific View when load
            var fluent = mvvmContext.OfType<NavigationViewModel>();
            fluent.WithEvent(mainView, "Load")
                .EventToCommand(x => x.OnLoad);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }
        [CodeExampleNestedClass]
        public class HomeView : UserControl {
            MVVMContext mvvmContext;
            SimpleButton bDetails;
            SimpleButton bGoForward;
            SimpleButton bGoBack;
            public HomeView() {
                mvvmContext = new MVVMContext() { ContainerControl = this };
                mvvmContext.ViewModelType = typeof(HomeViewModel);
                SuspendLayout();
                LabelControl label = new LabelControl() { AutoSizeMode = LabelAutoSizeMode.None, Dock = DockStyle.Fill, Parent = this, Text = "Home View" };
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                bDetails = new SimpleButton { Parent = this, Text = "Details", Dock = DockStyle.Top };
                bGoForward = new SimpleButton { Parent = this, Text = "Go Forward", Dock = DockStyle.Top };
                bGoBack = new SimpleButton { Parent = this, Text = "Go Back", Dock = DockStyle.Top };
                ResumeLayout();
            }
            protected override void OnLoad(System.EventArgs e) {
                base.OnLoad(e);
                var fluent = mvvmContext.OfType<HomeViewModel>();
                fluent.BindCommand(bDetails, x => x.NavigateDetails);
                fluent.BindCommand(bGoForward, x => x.NavigateForward);
                fluent.BindCommand(bGoBack, x => x.NavigateBack);
            }
        }
        [CodeExampleNestedClass]
        public class DetailView : UserControl {
            MVVMContext mvvmContext;
            SimpleButton bNextDetail;
            SimpleButton bBack;
            SimpleButton bGoForward;
            public DetailView() {
                mvvmContext = new MVVMContext() { ContainerControl = this };
                mvvmContext.ViewModelType = typeof(DetailViewModel);
                SuspendLayout();
                LabelControl label = new LabelControl() { AutoSizeMode = LabelAutoSizeMode.None, Dock = DockStyle.Fill, Parent = this, Text = "Detail View" };
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                bNextDetail = new SimpleButton { Parent = this, Text = "Next Detail", Dock = DockStyle.Top };
                bBack = new SimpleButton { Parent = this, Text = "Go Back", Dock = DockStyle.Top };
                bGoForward = new SimpleButton { Parent = this, Text = "Go Forward", Dock = DockStyle.Top };
                ResumeLayout();
            }
            protected override void OnLoad(System.EventArgs e) {
                base.OnLoad(e);
                var fluent = mvvmContext.OfType<DetailViewModel>();
                fluent.BindCommand(bNextDetail, x => x.NavigateNextDetail);
                fluent.BindCommand(bBack, x => x.NavigateBack);
                fluent.BindCommand(bGoForward, x => x.NavigateForward);
            }
        }
        [CodeExampleNestedClass]
        public class NextDetailView : UserControl {
            MVVMContext mvvmContext;
            SimpleButton bGoHome;
            SimpleButton bBack;
            public NextDetailView() {
                mvvmContext = new MVVMContext() { ContainerControl = this };
                mvvmContext.ViewModelType = typeof(NextDetailViewModel);
                SuspendLayout();
                LabelControl label = new LabelControl() { AutoSizeMode = LabelAutoSizeMode.None, Dock = DockStyle.Fill, Parent = this, Text = "Next Detail View" };
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                bGoHome = new SimpleButton { Parent = this, Text = "Go Home", Dock = DockStyle.Top };
                bBack = new SimpleButton { Parent = this, Text = "Go Back", Dock = DockStyle.Top };
                ResumeLayout();
            }
            protected override void OnLoad(System.EventArgs e) {
                base.OnLoad(e);
                var fluent = mvvmContext.OfType<NextDetailViewModel>();
                fluent.BindCommand(bGoHome, x => x.NavigateHome);
                fluent.BindCommand(bBack, x => x.NavigateBack);
            }
        }
        [CodeExampleNestedClass]
        public class NavigationViewModel {
            protected INavigationService NavigationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INavigationService>(); }
            }
            public void OnLoad() {
                // Navigate to the specific View
                NavigationService.Navigate("HomeView");
            }
        }
        [CodeExampleNestedClass]
        public class NavigationViewModelBase : ISupportNavigation {
            protected NavigationViewModelBase() {
                NavigationService.CanGoBackChanged += (s, e) =>
                    this.RaiseCanExecuteChanged(x => x.NavigateBack());
                NavigationService.CanGoForwardChanged += (s, e) =>
                    this.RaiseCanExecuteChanged(x => x.NavigateForward());
            }
            object ISupportParameter.Parameter {
                get;
                set;
            }
            protected INavigationService NavigationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INavigationService>(); }
            }
            public void NavigateBack() {
                // Navigate back
                NavigationService.GoBack();
            }
            public bool CanNavigateBack() {
                return NavigationService.CanGoBack;
            }
            public void NavigateForward() {
                // Navigate forward
                NavigationService.GoForward();
            }
            public bool CanNavigateForward() {
                return NavigationService.CanGoForward;
            }
            void ISupportNavigation.OnNavigatedTo() {
                // the ISupportNavigation functionality is supported
                OnNavigatedTo();
            }
            void ISupportNavigation.OnNavigatedFrom() {
                // the ISupportNavigation functionality is supported
                OnNavigatedFrom();
            }
            protected virtual void OnNavigatedTo() { }
            protected virtual void OnNavigatedFrom() { }
        }
        [CodeExampleNestedClass]
        public class HomeViewModel : NavigationViewModelBase {
            public void NavigateDetails() {
                // Navigate to the specific View
                NavigationService.Navigate("DetailView");
            }
            protected override void OnNavigatedTo() {
                // do something if needed
            }
            protected override void OnNavigatedFrom() {
                // do something if needed
            }
        }
        [CodeExampleNestedClass]
        public class DetailViewModel : NavigationViewModelBase {
            public void NavigateNextDetail() {
                // Navigate to the specific View
                NavigationService.Navigate("NextDetailView");
            }
            protected override void OnNavigatedTo() {
                // do something if needed
            }
            protected override void OnNavigatedFrom() {
                // do something if needed
            }
        }
        [CodeExampleNestedClass]
        public class NextDetailViewModel : NavigationViewModelBase {
            public void NavigateHome() {
                // Navigate to the specific View
                NavigationService.Navigate("HomeView");
            }
            protected override void OnNavigatedTo() {
                // do something if needed
            }
            protected override void OnNavigatedFrom() {
                // do something if needed
            }
        }
    }

    [CodeExampleClass("Custom Services", "Services.cs")]
    [CodeExampleHighlightTokens("CustomService", "ICustomService", "ServiceProperty")]
    [CodeExampleUnderlineTokens("RegisterService")]
    public static class CustomServices {
        static CustomServices() {
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
        [CodeExampleCase("Custom Service", new Type[] { typeof(ViewModelWithCustomService), typeof(ICustomService), typeof(CustomService) })]
        public static void UseCustomService(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithCustomService);
            // Custom service registration
            mvvmContext.RegisterService(new CustomService());
            // UI binding for button
            var fluent = mvvmContext.OfType<ViewModelWithCustomService>();
            fluent.BindCommand(commandButton, x => x.DoSomethingViaCustomService);
        }
        [CodeExampleCase("Custom Service with Key", new Type[] { typeof(ViewModelWithKeyedCustomService), typeof(ICustomService), typeof(CustomService) })]
        public static void UseCustomServiceWithKey(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithKeyedCustomService);
            // Custom service registration
            mvvmContext.RegisterService("SomeKey1", new CustomService("Custom Service 1"));
            mvvmContext.RegisterService("SomeKey2", new CustomService("Custom Service 2"));
            // UI binding for button
            var fluent = mvvmContext.OfType<ViewModelWithKeyedCustomService>();
            fluent.BindCommand(commandButton, x => x.DoSomethingViaCustomServices);
        }

        [CodeExampleNestedClass]
        public interface ICustomService {
            void DoSomething();
        }
        [CodeExampleNestedClass]
        public class CustomService : ICustomService {
            string text;
            public CustomService(string text = null) {
                this.text = text;
            }
            public void DoSomething() {
                var msgBoxService = ServiceContainer.Default.GetService<IMessageBoxService>();
                msgBoxService.ShowMessage("Hi!", text ?? "CustomService");
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithCustomService {
            public void DoSomethingViaCustomService() {
                this.GetService<ICustomService>().DoSomething();
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithKeyedCustomService {
            [DevExpress.Mvvm.DataAnnotations.ServiceProperty(Key = "SomeKey1")]
            protected virtual ICustomService CustomService1 {
                get { throw new NotImplementedException(); }
            }
            [DevExpress.Mvvm.DataAnnotations.ServiceProperty(Key = "SomeKey2")]
            protected virtual ICustomService CustomService2 {
                get { throw new NotImplementedException(); }
            }
            public void DoSomethingViaCustomServices() {
                CustomService1.DoSomething();
                CustomService2.DoSomething();
            }
        }
    }
}
