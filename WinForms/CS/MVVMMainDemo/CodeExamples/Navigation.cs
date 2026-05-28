using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Navigation on Application Start", "Navigation.cs")]
    [CodeExampleVersionID(211)]
    [CodeExampleHighlightTokens("DocumentManagerService")]
    [CodeExampleUnderlineTokens("RegisterDefaultService", "Create", "UseDeferredLoading")]
    public static class NavigationOnApplicationStart {
        static NavigationOnApplicationStart() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            UserControl mainView = new UserControl();
            mainView.Dock = DockStyle.Fill;

            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = mainView;
            mvvmContext.ViewModelType = typeof(NavigationViewModel);

            var manager = new DocumentManager();
            var tabbedView = new TabbedView();
            manager.View = tabbedView;
            manager.ContainerControl = mainView;

            return new object[] { sampleHost, mainView, mvvmContext, tabbedView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
            var manager = DocumentManager.FromControl(sampleHost);
            if(manager != null) manager.Dispose();
        }

        [CodeExampleCase("Open the specific module", new Type[] {
            typeof(NavigationViewModel), typeof(ModuleBase),
            typeof(ModuleA), typeof(ModuleAViewModel),
        })]
        public static void OpenDocument(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, TabbedView tabbedView) {
            // Service registration at the Application level
            mvvmContext.RegisterDefaultService(DocumentManagerService.Create(tabbedView));
            // Binding the Load event to the specific command
            var fluent = mvvmContext.OfType<NavigationViewModel>();
            fluent.WithEvent(mainView, "Load")
                .EventToCommand(x => x.ShowModuleA);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }
        [CodeExampleCase("Open the specific modules in deferred manner", new Type[] {
            typeof(NavigationViewModel), typeof(ModuleBase),
            typeof(ModuleA), typeof(ModuleAViewModel),
            typeof(ModuleB), typeof(ModuleBViewModel),
            typeof(ModuleC), typeof(ModuleCViewModel),
        })]
        public static void OpenDeferredDocuments(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, TabbedView tabbedView) {
            // Activating the Deferred Loading feature
            var service = DocumentManagerService.Create(tabbedView);
            service.UseDeferredLoading = DevExpress.Utils.DefaultBoolean.True;
            // Service registration at the Application level
            mvvmContext.RegisterDefaultService(service);
            // Binding the Load event to the specific command
            var fluent = mvvmContext.OfType<NavigationViewModel>();
            fluent.WithEvent(mainView, "Load")
                .EventToCommand(x => x.ShowSomeModulesInDeferredManner);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }

        [CodeExampleNestedClass]
        public class NavigationViewModel {
            protected IDocumentManagerService DocumentManagerService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IDocumentManagerService>(); }
            }
            // Ids for modules
            readonly static object ID_ModuleA = new object();
            readonly static object ID_ModuleB = new object();
            readonly static object ID_ModuleC = new object();
            //
            public void ShowModuleA() {
                FindAndActivateModule(ID_ModuleA, "ModuleA", "Module A");
            }
            public void ShowSomeModulesInDeferredManner() {
                FindAndActivateModule(ID_ModuleA, "ModuleA", "Module A");
                FindAndActivateModule(ID_ModuleB, "ModuleB", "Module B");
                FindAndActivateModule(ID_ModuleC, "ModuleC", "Module C");
            }
            void FindAndActivateModule(object id, string documentType, string title) {
                // Find the specific module by its ID
                var document = DocumentManagerService.FindDocumentById(id);
                if(document == null) {
                    // create when there is no such module opened
                    document = DocumentManagerService.CreateDocument(documentType, parameter: null, parentViewModel: this);
                    document.Id = id;
                    document.Title = title;
                }
                // Show the specific module
                document.Show();
            }
        }
        //
        [CodeExampleNestedClass]
        public class ModuleBase : UserControl {
            MVVMContext mvvmContext;
            protected ModuleBase(string text, Type viewModelType) {
                mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = viewModelType;
                SuspendLayout();
                LabelControl label = new LabelControl();
                label.AutoSizeMode = LabelAutoSizeMode.None;
                label.Dock = DockStyle.Fill;
                label.Parent = this;
                label.Text = text;
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                if(text.EndsWith("A"))
                    this.BackColor = Color.FromArgb(0x30, Color.Red);
                if(text.EndsWith("B"))
                    this.BackColor = Color.FromArgb(0x30, Color.Green);
                if(text.EndsWith("C"))
                    this.BackColor = Color.FromArgb(0x30, Color.Blue);
                ResumeLayout();
            }
        }
        [CodeExampleNestedClass]
        public class ModuleA : ModuleBase {
            public ModuleA()
                : base("Module A", typeof(ModuleAViewModel)) {
            }
        }
        [CodeExampleNestedClass]
        public class ModuleB : ModuleBase {
            public ModuleB()
                : base("Module B", typeof(ModuleBViewModel)) {
                // Do something important/time-consuming
                System.Threading.Thread.Sleep(1000);
            }
        }
        [CodeExampleNestedClass]
        public class ModuleC : ModuleBase {
            public ModuleC()
                : base("Module C", typeof(ModuleCViewModel)) {
                // Do something important/time-consuming
                System.Threading.Thread.Sleep(1000);
            }
        }
        //
        [CodeExampleNestedClass]
        public class ModuleAViewModel { }
        [CodeExampleNestedClass]
        public class ModuleBViewModel { }
        [CodeExampleNestedClass]
        public class ModuleCViewModel { }
    }

    [CodeExampleClass("Navigation to the same type of view", "Navigation.cs")]
    [CodeExampleVersionID(211)]
    [CodeExampleHighlightTokens("WindowedDocumentManagerService", "IDocumentContent")]
    [CodeExampleUnderlineTokens("RegisterService", "Create")]
    public static class NavigationToTheSameTypeOfView {
        static NavigationToTheSameTypeOfView() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            UserControl mainView = new UserControl();
            mainView.Dock = DockStyle.Fill;

            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = mainView;
            mvvmContext.ViewModelType = typeof(ContactsViewModel);

            var manager = new DocumentManager();
            var tabbedView = new TabbedView();
            manager.View = tabbedView;
            manager.ContainerControl = mainView;

            SimpleButton showBtn = new SimpleButton();
            showBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            showBtn.Parent = mainView;

            return new object[] { sampleHost, mainView, mvvmContext, tabbedView, showBtn };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
            var manager = DocumentManager.FromControl(sampleHost);
            if(manager != null) manager.Dispose();
        }

        [CodeExampleCase("Open or activate the specific contact", new Type[] {
            typeof(ContactsViewModel),
            typeof(ContactModule), typeof(ContactModuleViewModel),
        })]
        public static void ShowContact(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, TabbedView tabbedView, SimpleButton showBtn) {
            // Local service registration
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView));
            // Binding the Load event to the specific command
            var fluent = mvvmContext.OfType<ContactsViewModel>();
            fluent.BindCommand(showBtn, x => x.ShowContact);
            fluent.SetBinding(showBtn, btn => btn.Text, x => x.ShowContactTitle);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }


        [CodeExampleNestedClass]
        public class ContactsViewModel {
            public ContactsViewModel() {
                Contacts = new List<string> {
                    "John Smith",
                    "Marie Louis",
                    "Ann Baker",
                    "Mark Voo",
                };
            }
            protected IDocumentManagerService DocumentManagerService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IDocumentManagerService>(); }
            }
            //
            int currentContactId;
            public List<string> Contacts {
                get;
                private set;
            }
            public string ShowContactTitle {
                get { return string.Format("Show contact #{0} of {1}", currentContactId + 1, Contacts.Count); }
            }
            public void ShowContact() {
                // Find the specific opened contact by its ID
                var document = DocumentManagerService.FindDocumentById(currentContactId);
                if(document == null) {
                    // create when there is no such module opened
                    document = DocumentManagerService.CreateDocument("ContactView", parameter: Contacts[currentContactId], parentViewModel: this);
                    document.Id = currentContactId;
                    document.Title = "Contact #" + (currentContactId + 1).ToString();
                }
                // Show the specific module
                document.Show();
                currentContactId = (currentContactId + 1) % Contacts.Count;
                this.RaisePropertyChanged(x => x.ShowContactTitle);
            }
        }
        //
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("ContactView")]
        public class ContactModule : UserControl {
            MVVMContext mvvmContext;
            LabelControl contactLabel;
            public ContactModule() {
                mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(ContactModuleViewModel);
                SuspendLayout();
                contactLabel = new LabelControl();
                contactLabel.AutoSizeMode = LabelAutoSizeMode.None;
                contactLabel.Dock = DockStyle.Fill;
                contactLabel.Parent = this;
                contactLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                contactLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                ResumeLayout();
                if(!mvvmContext.IsDesignMode)
                    InitializeBinding();
            }
            void InitializeBinding() {
                var fluent = mvvmContext.OfType<ContactModuleViewModel>();
                fluent.SetBinding(contactLabel, lbl => lbl.Text, x => x.Contact);
            }
        }
        [CodeExampleNestedClass]
        public class ContactModuleViewModel : ISupportParameter {
            object ISupportParameter.Parameter {
                get { return Contact; }
                set { Contact = value as string; }
            }
            public string Contact {
                get;
                protected set;
            }
        }
    }

    [CodeExampleClass("Navigation from one view to another", "Navigation.cs")]
    [CodeExampleVersionID(211)]
    [CodeExampleHighlightTokens("NavigationService")]
    [CodeExampleUnderlineTokens("RegisterDefaultService", "Create")]
    public static class NavigationFromOneViewToAnother {
        static NavigationFromOneViewToAnother() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            UserControl mainView = new UserControl();
            mainView.Dock = DockStyle.Fill;

            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = mainView;
            mvvmContext.ViewModelType = typeof(RootViewModel);

            var frame = new NavigationFrame();
            frame.Dock = DockStyle.Fill;
            frame.Parent = mainView;
            return new object[] { sampleHost, mainView, mvvmContext, frame };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
            var manager = DocumentManager.FromControl(sampleHost);
            if(manager != null) manager.Dispose();
        }

        [CodeExampleCase("Open the specific module and close previous", new Type[] {
            typeof(RootViewModel),
            typeof(ModuleBase), typeof(ModuleViewModelBase),
            typeof(FirstModule), typeof(FirstModuleViewModel),
            typeof(SecondModule), typeof(SecondModuleViewModel),
            typeof(ThirdModule), typeof(ThirdModuleViewModel),
        }, typeof(ModuleViewModelBase))]
        public static void OpenDocumentAndClosePrevious(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, NavigationFrame frame) {
            // Service registration at the Application level
            var service = NavigationService.Create(frame);
            mvvmContext.RegisterDefaultService(service);
            // Binding the Load event to the specific command
            var fluent = mvvmContext.OfType<RootViewModel>();
            fluent.WithEvent(mainView, "Load")
                .EventToCommand(x => x.OnLoad);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }

        [CodeExampleNestedClass]
        public class RootViewModel {
            protected INavigationService NavigationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INavigationService>(); }
            }
            public void OnLoad() {
                NavigationService.Navigate("FirstModule", null, this);
            }
        }
        [CodeExampleNestedClass]
        public abstract class ModuleViewModelBase : ISupportNavigation {
            protected INavigationService NavigationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INavigationService>(); }
            }
            public void ShowNextModuleAndClose() {
                // get current document
                var document = NavigationService.Current as IDocument;
                // navigate to the next module and pass current name as parameter
                var rootViewModel = this.GetParentViewModel<object>();
                NavigationService.Navigate(NextModule, ModuleName, rootViewModel);
                if(document != null) {
                    // close document
                    NavigationService.ClearNavigationHistory();
                    document.Close(true);
                }
            }
            public virtual string NavigationActionTitle {
                get;
                protected set;
            }
            void ISupportNavigation.OnNavigatedTo() {
                // obtain previous module name from navigation parameter 
                var prevModule = Parameter as string;
                if(prevModule != null)
                    NavigationActionTitle = "Navigated from " + prevModule + ". Click to navigate to " + NextModule;
                else
                    NavigationActionTitle = "Click to navigate to " + NextModule;
            }
            void ISupportNavigation.OnNavigatedFrom() { }
            public object Parameter {
                get;
                set;
            }
            // module specific parameters
            protected abstract string ModuleName { get; }
            protected abstract string NextModule { get; }
        }

        [CodeExampleNestedClass]
        public class ModuleBase : UserControl {
            MVVMContext mvvmContext;
            protected ModuleBase(string text, Type viewModelType) {
                mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = viewModelType;
                SuspendLayout();
                SimpleButton nextButton = new SimpleButton();
                nextButton.Dock = DockStyle.Bottom;
                nextButton.Parent = this;
                LabelControl label = new LabelControl();
                label.AutoSizeMode = LabelAutoSizeMode.None;
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                label.Dock = DockStyle.Fill;
                label.Text = text;
                label.Parent = this;
                if(text.StartsWith("First"))
                    this.BackColor = Color.FromArgb(0x30, Color.Red);
                if(text.StartsWith("Second"))
                    this.BackColor = Color.FromArgb(0x30, Color.Green);
                if(text.StartsWith("Third"))
                    this.BackColor = Color.FromArgb(0x30, Color.Blue);
                this.Padding = new Padding(24);
                ResumeLayout();
                if(!mvvmContext.IsDesignMode)
                    InitializeBindings(nextButton);
            }
            protected virtual void InitializeBindings(SimpleButton nextButton) {
                var fluent = mvvmContext.OfType<ModuleViewModelBase>();
                fluent.SetBinding(nextButton, btn => btn.Text, x => x.NavigationActionTitle);
                fluent.BindCommand(nextButton, x => x.ShowNextModuleAndClose);
            }
        }
        [CodeExampleNestedClass]
        public class FirstModule : ModuleBase {
            public FirstModule()
                : base("First Module", typeof(FirstModuleViewModel)) {
            }
        }
        [CodeExampleNestedClass]
        public class SecondModule : ModuleBase {
            public SecondModule()
                : base("Second Module", typeof(SecondModuleViewModel)) {
            }
        }
        [CodeExampleNestedClass]
        public class ThirdModule : ModuleBase {
            public ThirdModule()
                : base("Third Module", typeof(ThirdModuleViewModel)) {
            }
        }
        //
        [CodeExampleNestedClass]
        public class FirstModuleViewModel : ModuleViewModelBase {
            protected override string ModuleName {
                get { return "FirstModule"; }
            }
            protected override string NextModule {
                get { return "SecondModule"; }
            }
        }
        [CodeExampleNestedClass]
        public class SecondModuleViewModel : ModuleViewModelBase {
            protected override string ModuleName {
                get { return "SecondModule"; }
            }
            protected override string NextModule {
                get { return "ThirdModule"; }
            }
        }
        [CodeExampleNestedClass]
        public class ThirdModuleViewModel : ModuleViewModelBase {
            protected override string ModuleName {
                get { return "ThirdModule"; }
            }
            protected override string NextModule {
                get { return "FirstModule"; }
            }
        }
    }

    [CodeExampleClass("Navigation to custom Form", "Navigation.cs")]
    [CodeExampleVersionID(211)]
    [CodeExampleHighlightTokens("WindowedDocumentManagerService", "IDocumentContent")]
    [CodeExampleUnderlineTokens("RegisterService", "Create")]
    public static class NavigationToCustomView {
        static NavigationToCustomView() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            UserControl mainView = new UserControl();
            mainView.Padding = new System.Windows.Forms.Padding(24);
            mainView.Dock = System.Windows.Forms.DockStyle.Fill;

            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = mainView;
            mvvmContext.ViewModelType = typeof(MainViewModel);

            SimpleButton showBtn = new SimpleButton();
            showBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            showBtn.Parent = mainView;
            showBtn.Text = "Show custom dialog form";

            return new object[] { sampleHost, mainView, mvvmContext, showBtn };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
            var manager = DocumentManager.FromControl(sampleHost);
            if(manager != null) manager.Dispose();
        }

        [CodeExampleCase("Open the specific modal form", new Type[] { typeof(MainViewModel), 
            typeof(AcceptForm), typeof(AcceptFormViewModel) 
        }, typeof(MainViewModel))]
        public static void OpenSpecificForm(XtraUserControl sampleHost, UserControl mainView, MVVMContext mvvmContext, SimpleButton showBtn) {
            // Service registration at the Application level
            var service = WindowedDocumentManagerService.Create(mainView);
            // set up service for modal showing
            service.DocumentShowMode = WindowedDocumentManagerService.FormShowMode.Dialog;
            mvvmContext.RegisterService(service);
            // Binding button to the specific command
            var fluent = mvvmContext.OfType<MainViewModel>();
            fluent.BindCommand(showBtn, x => x.ShowAcceptDialog);
            // Adding View onto the samples host
            mainView.Parent = sampleHost;
        }

        [CodeExampleNestedClass]
        public class MainViewModel {
            protected IDocumentManagerService WindowedDocumentManagerService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IDocumentManagerService>(); }
            }
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            int id = 0;
            const string greeting = "Click the \"Accept\" button to accept this dialog, or \"Close\" to discard it.";
            public void ShowAcceptDialog() {
                var viewModel = ViewModelSource.Create(() => new AcceptFormViewModel(greeting));
                // Find the specific module by its ID
                var document = WindowedDocumentManagerService.FindDocumentById(id++);
                if(document == null) {
                    // create the specific document and inject a viewmodel into this document
                    document = WindowedDocumentManagerService.CreateDocument(string.Empty, viewModel: viewModel);
                    document.Id = id;
                    document.Title = "Accept Dialog #" + id.ToString();
                }
                // Show the specific module (execution will be blocked here because of modeless)
                document.Show();
                if(viewModel.Accepted)
                    MessageBoxService.ShowMessage("Dialog accepted.");
                else
                    MessageBoxService.ShowMessage("Dialog not accepted.");
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType(typeof(AcceptFormViewModel))]
        public class AcceptForm : XtraForm {
            MVVMContext mvvmContext;
            SimpleButton acceptButton;
            LabelControl greetingLabel;
            public AcceptForm() {
                mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(AcceptFormViewModel);
                mvvmContext.ViewModelSet += OnViewModelSet;
                SuspendLayout();
                acceptButton = new SimpleButton();
                acceptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
                acceptButton.Parent = this;
                acceptButton.Text = "Accept";
                greetingLabel = new LabelControl();
                greetingLabel.AutoSizeMode = LabelAutoSizeMode.None;
                greetingLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                greetingLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                greetingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                greetingLabel.Parent = this;
                this.AcceptButton = acceptButton;
                this.Padding = new System.Windows.Forms.Padding(24);
                this.ClientSize = new Size(750, 250);
                ResumeLayout();
            }
            void OnViewModelSet(object sender, ViewModelSetEventArgs e) {
                var fluent = mvvmContext.OfType<AcceptFormViewModel>();
                fluent.SetBinding(greetingLabel, lbl => lbl.Text, x => x.Greeting);
                fluent.BindCommand(acceptButton, x => x.Accept);
            }
        }
        [CodeExampleNestedClass]
        public class AcceptFormViewModel : IDocumentContent {
            public AcceptFormViewModel(string greeting) {
                this.Greeting = greeting;
            }
            public string Greeting {
                get;
                private set;
            }
            public bool Accepted {
                get;
                private set;
            }
            public void Accept() {
                Accepted = true;
                DocumentOwner.Close(this);
            }
            [EditorBrowsable(EditorBrowsableState.Never)]
            public IDocumentOwner DocumentOwner { get; set; }
            object IDocumentContent.Title {
                get { return "Custom View"; }
            }
            void IDocumentContent.OnClose(CancelEventArgs e) { }
            void IDocumentContent.OnDestroy() { }
        }
    }
}
