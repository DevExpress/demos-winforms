using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Prerequisites, Implement a Data Model", "SimpleApp.cs")]
    public static class SimpleApp_Prerequisites {
        static SimpleApp_Prerequisites() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var schema = new PictureEdit();
            schema.Dock = System.Windows.Forms.DockStyle.Fill;
            schema.BackColor = System.Drawing.Color.Transparent;
            schema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            schema.Properties.AllowFocused = false;
            schema.Properties.ReadOnly = true;
            schema.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            schema.SvgImage = DevExpress.Tutorials.TodoApp.Assets.DataModel;
            schema.Parent = sampleHost;
            IRepository repository = null;
            return new object[] { repository };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("Example 1, How to retrieve data source record count",
            new Type[] { typeof(TodoItem), typeof(IRepository) }
        ), TodoAppDescription("DataModel")]
        public static void QueryItemsCount(IRepository repository) {
            // The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            if(repository != null) {
                // Query all items count
                int allItemsCount = repository.Count();
                // Query completed items count only
                int completedItemsCount = repository.Count(x => x.IsCompleted);
            }
        }
        [CodeExampleCase("Example 2, How to load items from a source",
            new Type[] { typeof(TodoItem), typeof(IRepository) }
        ), TodoAppDescription("DataModel")]
        public static void LoadItems(IRepository repository) {
            // External option
            bool showAll = true;
            // The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            if(repository != null) {
                if(showAll) {
                    // Load all items 
                    var allItems = repository.LoadItems();
                }
                else {
                    // Load incompleted items only
                    var incompletedItems = repository.LoadItems(x => !x.IsCompleted);
                }
            }
        }
        [CodeExampleCase("Example 3, How to load or save a specific source item",
            new Type[] { typeof(TodoItem), typeof(IRepository) }
        ), TodoAppDescription("DataModel")]
        public static void LoadingAndSavingItem(IRepository repository) {
            // External parameter
            int itemId = 42;
            // The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            if(repository != null) {
                // Load the specific item 
                TodoItem item = repository.LoadItem(itemId);
                // Working with item
                item.Description = "Some Description";
                // Tracking changes
                if(repository.HasChanges(itemId, item)) {
                    // Updating our item
                    repository.Save(item);
                }
            }
        }
        [CodeExampleCase("Example 4, How to create a new data source record",
            new Type[] { typeof(TodoItem), typeof(IRepository), typeof(AppModel) },
            HiddenTypes = "AppModel"
        ), TodoAppDescription("DataModel")]
        public static void CreatingAndSavingNewItem(IRepository repository) {
            // The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            if(repository != null) {
                // Get a new item instance
                TodoItem newItem = repository.LoadItem(AppModel.NewItemID);
                // Initializing item fields
                newItem.Title = "Do something";
                newItem.Description = "Some Description";
                // Saving new item to data storage
                int savedId = repository.Save(newItem);
                // Further use the resulting id
                TodoItem savedItem = repository.LoadItem(savedId);
            }
        }
        [CodeExampleCase("Example 5, How to delete a data source entity",
            new Type[] { typeof(TodoItem), typeof(IRepository) }
        ), TodoAppDescription("DataModel")]
        public static void DeletingItem(IRepository repository) {
            // External parameter
            int itemId = 5;
            // The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            if(repository != null) {
                // Delete the specific item
                if(repository.Delete(itemId)) {
                    // Do something if item completely deleted
                }
            }
        }
        //
        [CodeExampleNestedClass]
        public class TodoItem {
            // Deny direct item creation (available for data storage only)
            protected TodoItem(int id) {
                this.Id = id;
            }
            // Key field (for data storage).  Hidden from UI
            [Display(AutoGenerateField = false)]
            public int Id {
                get;
                private set;
            }
            // Data fields
            public string Title {
                get;
                set;
            }
            public string Description {
                get;
                set;
            }
            public bool IsCompleted {
                get;
                set;
            }
        }
        [CodeExampleNestedClass]
        public interface IRepository {
            // Query count
            int Count(Func<TodoItem, bool> filter = null);
            // Items Loading
            IList<TodoItem> LoadItems(Func<TodoItem, bool> filter = null);
            // Item loading/reloading
            TodoItem LoadItem(int id);
            TodoItem ReloadItem(IList<TodoItem> items, int id);
            // Change tracking
            bool HasChanges(int id, TodoItem item);
            // Update/Delete operations
            int Save(TodoItem item);
            bool Delete(int id);
        }
        // Hidden code
        [CodeExampleNestedClass]
        public class AppModel {
            public const int NewItemID = int.MinValue;
        }
    }

    [CodeExampleClass("Step 1, Create the Main Application Form", "SimpleApp.cs")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class SimpleApp_Step1 {
        static SimpleApp_Step1() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            // Create mainView
            MainView mainView = new MainView();
            // Show mainView as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView);
            //
            MVVMContext mvvmContext = MVVMContext.FromControl(mainView);
            return new object[] { mvvmContext, mainView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var mainView = sampleHost.Controls.Find("MainView", true);
            for(int i = 0; i < mainView.Length; i++)
                mainView[i].Dispose();
        }
        [CodeExampleCase("Create the MainView",
            new Type[] { typeof(MainView) },
            null,
            typeof(MainView)
        ), TodoAppDescription("CreateAppMainView")]
        public static void CreateAppMainView(MVVMContext mvvmContext, MainView mainView) {
            // Here we will write all our bindings
        }
        [CodeExampleCase("Create the AppViewModel",
            new Type[] { typeof(MainView), typeof(AppViewModel), typeof(InMemoryRepository) },
            typeof(AppViewModel),
            typeof(MainView),
            HiddenTypes = "MainView;InMemoryRepository"
        ), TodoAppDescription("CreateAppViewModelAndBindTheTitle")]
        public static void CreateAppViewModelAndBindTheTitle(MVVMContext mvvmContext, MainView mainView) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppViewModel>();
            // Bind the Title property to the Text
            fluent.SetBinding(mainView, view => view.Text, x => x.Title);
        }
        [CodeExampleNestedClass]
        public class AppViewModel {
            static AppViewModel() {
                // Registering  the global instance of IRepository service
                ServiceContainer.Default.RegisterService(new InMemoryRepository());
            }
            // This is ViewModel for our Application
            public AppViewModel() {
                Title = "Getting started witn MVVM - Todo App";
            }
            public string Title {
                get;
                private set;
            }
        }
        [CodeExampleNestedClass]
        public partial class MainView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Windows Form Designer generated code
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(AppViewModel);  // #2
                // 
                // MainView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.ClientSize = new System.Drawing.Size(398, 255);
                this.IconOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.CloseBox = false;
                this.Text = "{Application Title}";
                this.Name = "MainView";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;

            protected override DevExpress.XtraEditors.FormShowMode ShowMode {
                get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; }
            }
        }
        partial class MainView : XtraForm {
            public MainView() {
                InitializeComponent();
                // Initializing bindings only at runtime   // #2
                if(!mvvmContext.IsDesignMode)              // #2
                    InitializeBindings();                  // #2  
            }
            void InitializeBindings() {                    // #2
                // $CodeBehindInsertionLine$               // #2
            }                                              // #2
        }
        // Hidden Code
        [CodeExampleNestedClass]
        public class InMemoryRepository { 
        }
    }

    [CodeExampleClass("Step 2, Create the Start Screen Form", "SimpleApp.cs")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class SimpleApp_Step2 {
        static SimpleApp_Step2() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            AppLogoContainer mainView = new AppLogoContainer();
            // Create appLogo
            // mainView emulates repository service (for demo purposes)
            ServiceContainer.Default.RegisterService(mainView);
            AppLogo appLogo = new AppLogo();
            appLogo.Dock = DockStyle.Fill;
            appLogo.Parent = mainView;
            // Show AppLogoContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView);
            //
            MVVMContext mvvmContext = MVVMContext.FromControl(appLogo);
            LabelControl greetLabel = appLogo.Controls.Find("greetLabel", true)[0] as LabelControl;
            return new object[] { mvvmContext, greetLabel };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var mainView = sampleHost.Controls.Find("MainView", true);
            for(int i = 0; i < mainView.Length; i++)
                mainView[i].Dispose();
        }
        [CodeExampleCase("Create the AppLogo View",
            new Type[] { typeof(AppLogo), typeof(AppLogoContainer), typeof(TodoItem), typeof(IRepository) },
            null,
            typeof(AppLogo),
            HiddenTypes = "AppLogoContainer;TodoItem;IRepository"
        ), TodoAppDescription("CreateAppLogo")]
        public static void CreateAppLogo(MVVMContext mvvmContext, LabelControl greetLabel) {
            // Here we will write all our bindings
        }
        [CodeExampleCase("Create the AppLogoViewModel",
            new Type[] { typeof(AppLogo), typeof(AppLogoViewModel), typeof(AppLogoContainer), typeof(TodoItem), typeof(IRepository) },
            typeof(AppLogoViewModel),
            typeof(AppLogo),
            HiddenTypes = "AppLogo;AppLogoContainer;TodoItem;IRepository"
        ), TodoAppDescription("CreateAndBindAppLogoViewModel")]
        public static void CreateAndBindAppLogoViewModel(MVVMContext mvvmContext, LabelControl greetLabel) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppLogoViewModel>();
            // Bind the Greeting property to the label Text
            fluent.SetBinding(greetLabel, lbl => lbl.Text, x => x.Greeting);
        }
        //
        [CodeExampleNestedClass]
        public class AppLogoViewModel {
            // This is ViewModel for our Start Screen
            protected IRepository Repository {
                get { return this.GetRequiredService<IRepository>(); }
            }
            public string Greeting {
                get {
                    // Read this count from DB
                    int uncompletedCount = Repository.Count(x => !x.IsCompleted);
                    return
                        Size("Hello " + Environment.UserName + "!", 4) + DoubleLineBreak +
                        Size("You have " + uncompletedCount.ToString() + " incompleted tasks for now.", 2) + DoubleLineBreak +
                        Size("Have a good day!", 4);
                }
            }
            // Helper method and constant for creating the html-string
            const string DoubleLineBreak = "<br><br>";
            string Size(string text, int delta) {
                return "<size=+" + delta.ToString() + ">" + text + "</size>";
            }
        }
        [CodeExampleNestedClass]
        partial class AppLogo {
            /// <summary> 
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLogo));
                this.greetLabel = new DevExpress.XtraEditors.LabelControl();
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // greetLabel
                // 
                this.greetLabel.AllowHtmlString = true;
                this.greetLabel.Appearance.Options.UseTextOptions = true;
                this.greetLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
                this.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                this.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                this.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
                this.greetLabel.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo;
                this.greetLabel.ImageOptions.SvgImageSize = new System.Drawing.Size(128, 128);
                this.greetLabel.IndentBetweenImageAndText = 24;
                this.greetLabel.Location = new System.Drawing.Point(0, 0);
                this.greetLabel.Name = "greetLabel";
                this.greetLabel.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
                this.greetLabel.Size = new System.Drawing.Size(398, 468);
                this.greetLabel.TabIndex = 0;
                this.greetLabel.Text = "{Greeting}";
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(AppLogoViewModel); // #2
                // 
                // AppLogo
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.greetLabel);
                this.Name = "AppLogo";
                this.Size = new System.Drawing.Size(398, 468);
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.LabelControl greetLabel;
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        }
        public partial class AppLogo : XtraUserControl {
            public AppLogo() {
                InitializeComponent();
                // Initializing bindings only at runtime   // #2
                if(!mvvmContext.IsDesignMode)              // #2
                    InitializeBindings();                  // #2  
            }
            void InitializeBindings() {                    // #2
                // $CodeBehindInsertionLine$               // #2
            }                                              // #2
        }
        // Hidden code
        [CodeExampleNestedClass]
        public class AppLogoContainer : XtraForm, IRepository {
            public AppLogoContainer() {
                this.SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.ClientSize = new System.Drawing.Size(398, 255);
                this.CloseBox = false;
                this.IconOptions.ShowIcon = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "MainView";
                this.ResumeLayout(false);
            }
            protected override DevExpress.XtraEditors.FormShowMode ShowMode {
                get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; }
            }
            int IRepository.Count(Func<TodoItem, bool> filter) {
                return 3;
            }
        }
        [CodeExampleNestedClass]
        public interface IRepository {
            int Count(Func<TodoItem, bool> filter);
        }
        [CodeExampleNestedClass]
        public class TodoItem { 
            public bool IsCompleted { get; set; }
        }
    }

    [CodeExampleClass("Step 3, Implement Navigation Between Views", "SimpleApp.cs")]
    [CodeExampleUnderlineTokens("RegisterService", "EventToCommand")]
    [CodeExampleHighlightTokens("INavigationService", "NavigationService")]
    public static class SimpleApp_Step3 {
        static SimpleApp_Step3() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            // Create mainView
            MainView mainView = new MainView();
            // Show mainView as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView);
            //
            MVVMContext mvvmContext = MVVMContext.FromControl(mainView);
            NavigationFrame navigationFrame = mainView.Controls.Find("navigationFrame", false)[0] as NavigationFrame;
            // explicit type resolution (for runtime code-examples only)
            navigationFrame.QueryControl += (s, e) => {
                if(e.ControlName == "AppLogo")
                    e.Control = new AppLogo();
            };
            return new object[] { mvvmContext, mainView, navigationFrame };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var mainView = sampleHost.Controls.Find("MainView", true);
            for(int i = 0; i < mainView.Length; i++)
                mainView[i].Dispose();
        }
        [CodeExampleCase("Add a NavigationFrame and use the NavigationService",
            new Type[] { typeof(MainView), typeof(AppViewModel), typeof(AppLogo), typeof(AppLogoViewModel) },
            typeof(AppViewModel),
            typeof(MainView),
            HiddenTypes = "AppLogo;AppLogoViewModel"
        ), TodoAppDescription("RegisteringNavigationService")]
        public static void RegisteringNavigationService(MVVMContext mvvmContext, MainView mainView, NavigationFrame navigationFrame) {
            // creating the NavigationFrame as INavigationService
            var navigationService = NavigationService.Create(navigationFrame);
            // registering the service instance
            mvvmContext.RegisterService(navigationService);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppViewModel>();
            // Bind the OnShown command to the Shown event
            fluent.WithEvent(mainView, "Shown")
                .EventToCommand(x => x.OnShown);
        }
        //
        [CodeExampleNestedClass]
        public class AppViewModel {
            // This is ViewModel for our Application
            public AppViewModel() {
                Title = "Getting started witn MVVM - Todo App";
            }
            public string Title {
                get;
                private set;
            }
            protected INavigationService NavigationService {
                get { return this.GetService<INavigationService>(); }
            }
            public async Task OnShown() {
                // Wait some time (for demo purposes)
                await Task.Delay(1000);
                // Show AppLogo screen
                NavigationService.Navigate("AppLogo", null, this, false);
                // Wait some time before showing ItemsView
                await Task.Delay(1000);
                // TODO: we will uncomment these item in complete application
                // NavigationService.Navigate("ItemsView", null, this, true);
            }
        }
        [CodeExampleNestedClass]
        public partial class MainView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Windows Form Designer generated code
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
                this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // navigationFrame
                // 
                this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
                this.navigationFrame.Location = new System.Drawing.Point(0, 0);
                this.navigationFrame.Margin = new System.Windows.Forms.Padding(0);
                this.navigationFrame.Name = "navigationFrame";
                this.navigationFrame.SelectedPage = null;
                this.navigationFrame.Size = new System.Drawing.Size(398, 468);
                this.navigationFrame.TabIndex = 0;
                this.navigationFrame.Text = "navigationFrame1";
                this.navigationFrame.TransitionAnimationProperties.FrameInterval = 2500;
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(AppViewModel);
                // 
                // MainView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.ClientSize = new System.Drawing.Size(398, 255);
                this.Controls.Add(this.navigationFrame);
                this.IconOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.CloseBox = false;
                this.Name = "MainView";
                this.Text = "{Application Title}";
                ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
            private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;

            protected override DevExpress.XtraEditors.FormShowMode ShowMode {
                get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; }
            }
        }
        partial class MainView : XtraForm {
            public MainView() {
                InitializeComponent();
                // Initializing bindings only at runtime   
                if(!mvvmContext.IsDesignMode) {
                    InitializeNavigation();
                    InitializeBindings();
                }
            }
            void InitializeNavigation() {
                // $CodeBehindInsertionLine$
            }
            void InitializeBindings() {
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<AppViewModel>();
                // Bind the Title property to the Text
                fluent.SetBinding(this, view => view.Text, x => x.Title);
            }
        }
        // Hidden code
        [CodeExampleNestedClass]
        public class AppLogoViewModel {
            // This is ViewModel for our Start Screen
            public string Greeting {
                get {
                    int uncompletedCount = 3; // TODO: We will read this count from DB
                    return
                        Size("Hello " + Environment.UserName + "!", 4) + DoubleLineBreak +
                        Size("You have " + uncompletedCount.ToString() + " incompleted tasks for now.", 2) + DoubleLineBreak +
                        Size("Have a good day!", 4);
                }
            }
            const string DoubleLineBreak = "<br><br>";
            string Size(string text, int delta) {
                return "<size=+" + delta.ToString() + ">" + text + "</size>";
            }
        }
        [CodeExampleNestedClass]
        public class AppLogo : XtraUserControl {
            public AppLogo() {
                InitializeComponent();
                // Initializing bindings only at runtime   
                if(!mvvmContext.IsDesignMode)
                    InitializeBindings();
            }
            void InitializeBindings() {
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<AppLogoViewModel>();
                // Bind the Greeting property to the label Text
                fluent.SetBinding(greetLabel, lbl => lbl.Text, x => x.Greeting);
            }
            /// <summary> 
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLogo));
                this.greetLabel = new DevExpress.XtraEditors.LabelControl();
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // greetLabel
                // 
                this.greetLabel.AllowHtmlString = true;
                this.greetLabel.Appearance.Options.UseTextOptions = true;
                this.greetLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
                this.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                this.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                this.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
                this.greetLabel.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo;
                this.greetLabel.ImageOptions.SvgImageSize = new System.Drawing.Size(128, 128);
                this.greetLabel.IndentBetweenImageAndText = 24;
                this.greetLabel.Location = new System.Drawing.Point(0, 0);
                this.greetLabel.Name = "greetLabel";
                this.greetLabel.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
                this.greetLabel.Size = new System.Drawing.Size(398, 468);
                this.greetLabel.TabIndex = 0;
                this.greetLabel.Text = "{Greeting}";
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(AppLogoViewModel);
                // 
                // AppLogo
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.greetLabel);
                this.Name = "AppLogo";
                this.Size = new System.Drawing.Size(398, 468);
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.LabelControl greetLabel;
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        }
    }

    [CodeExampleClass("Step 4, Create the Items Screen", "SimpleApp.cs")]
    [CodeExampleUnderlineTokens("SetBinding", "EventToCommand")]
    public static class SimpleApp_Step4 {
        static SimpleApp_Step4() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            ItemsViewContainer mainView = new ItemsViewContainer();
            // mainView emulates repository service (for demo purposes)
            ServiceContainer.Default.RegisterService(mainView);
            // Create itemsView
            ItemsView itemsView = new ItemsView();
            itemsView.Dock = DockStyle.Fill;
            itemsView.Parent = mainView;
            // Show ItemsViewContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView);
            // Resolving view controls
            MVVMContext mvvmContext = MVVMContext.FromControl(itemsView);
            LabelControl titleLabel = itemsView.Controls.Find("titleLabel", true)[0] as LabelControl;
            ToggleSwitch toggleShowAll = itemsView.Controls.Find("toggleShowAll", true)[0] as ToggleSwitch;
            ListBoxControl listBoxControl = itemsView.Controls.Find("listBoxControl", true)[0] as ListBoxControl;
            BindingSource todoItemBindingSource = itemsView.todoItemBindingSource;
            return new object[] { mvvmContext, titleLabel, toggleShowAll, listBoxControl, todoItemBindingSource };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var mainView = sampleHost.Controls.Find("MainView", true);
            for(int i = 0; i < mainView.Length; i++)
                mainView[i].Dispose();
        }
        [CodeExampleCase("Create the ItemsView",
            new Type[] { typeof(ItemsView), typeof(ItemsViewContainer), typeof(TodoItem), typeof(IRepository) },
            null,
            typeof(ItemsView),
            HiddenTypes = "ItemsViewContainer;TodoItem;IRepository"
        ), TodoAppDescription("CreateItemsView")]
        public static void CreateItemsView(MVVMContext mvvmContext, LabelControl titleLabel, ToggleSwitch toggleShowAll, ListBoxControl listBoxControl, BindingSource todoItemBindingSource) {
            // Here we will write all our bindings
        }
        [CodeExampleCase("Create the ItemsViewModel",
            new Type[] { typeof(ItemsView), typeof(ItemsViewModel), typeof(ItemsViewContainer), typeof(TodoItem), typeof(IRepository), typeof(AppModel) },
            typeof(ItemsViewModel),
            typeof(ItemsView),
            HiddenTypes = "ItemsView;ItemsViewContainer;TodoItem;IRepository;AppModel"
        ), TodoAppDescription("CreateAndBindItemsViewModel")]
        public static void CreateAndBindItemsViewModel(MVVMContext mvvmContext, LabelControl titleLabel, ToggleSwitch toggleShowAll, ListBoxControl listBoxControl, BindingSource todoItemBindingSource) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ItemsViewModel>();
            // Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            // Bind the ShowAllItems option to the toggle switch
            fluent.SetBinding(toggleShowAll, tgl => tgl.EditValue, x => x.ShowAllItems);
            // Bind data-items to listbox
            fluent.SetBinding(todoItemBindingSource, bs => bs.DataSource, x => x.Items);
            fluent.SetBinding(listBoxControl, lb => lb.SelectedValue, x => x.SelectedItem);
            // Bind the Complete command to the context button click (with args propagation)
            fluent.WithEvent<ContextItemClickEventArgs>(listBoxControl, "ContextButtonClick")
                .EventToCommand(x => x.Complete, args => args.DataItem as TodoItem);
        }
        //
        [CodeExampleNestedClass]
        public class ItemsViewModel {
            public ItemsViewModel() {
                Title = "What needs to be done?";
                ShowAllItems = true;
            }
            protected IRepository Repository {
                get { return this.GetRequiredService<IRepository>(); }
            }
            void ReloadItems(bool showAll) {
                int savedId = (SelectedItem != null) ? SelectedItem.Id : AppModel.NewItemID;
                if(showAll)
                    Items = Repository.LoadItems();
                else
                    Items = Repository.LoadItems(x => !x.IsCompleted);
                SelectedItem = Items.FirstOrDefault(x => x.Id == savedId) ?? SelectedItem;
            }
            public string Title {
                get;
                private set;
            }
            public virtual IList<TodoItem> Items {
                get;
                protected set;
            }
            public virtual TodoItem SelectedItem {
                get;
                set;
            }
            public virtual bool ShowAllItems {
                get;
                set;
            }
            protected void OnItemsChanged() {
                SelectedItem = Items.FirstOrDefault();
            }
            protected void OnSelectedItemChanged() {
                this.RaiseCanExecuteChanged(x => x.Edit());
            }
            protected void OnShowAllItemsChanged() {
                ReloadItems(ShowAllItems);
            }
            protected INavigationService NavigationService {
                get { return this.GetService<INavigationService>(); }
            }
            public void Complete(TodoItem item) {
                item.IsCompleted = true;
                if(Repository.HasChanges(item.Id, item)) {
                    Repository.Save(item);
                }
            }
            public void New() {
                // TODO: we will uncomment this item in complete application
                // NavigationService.Navigate("ItemView", AppModel.NewItemID, this);
            }
            public bool CanEdit() {
                return SelectedItem != null;
            }
            public void Edit() {
                // TODO: we will uncomment this item in complete application
                // NavigationService.Navigate("ItemView", SelectedItem.Id, this);
            }
        }
        [CodeExampleNestedClass]
        public partial class ItemsView {
            /// <summary> 
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsView));
                DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
                DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
                DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
                DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
                DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
                DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
                DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
                DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
                DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
                this.listBoxControl = new DevExpress.XtraEditors.ListBoxControl();
                this.searchControl = new DevExpress.XtraEditors.SearchControl();
                this.titleLabel = new DevExpress.XtraEditors.LabelControl();
                this.toggleShowAll = new DevExpress.XtraEditors.ToggleSwitch();
                this.footerPane = new DevExpress.Utils.Layout.TablePanel();
                this.headerPane = new DevExpress.Utils.Layout.TablePanel();
                this.btnNew = new DevExpress.XtraEditors.SimpleButton();
                this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.footerPane)).BeginInit();
                this.footerPane.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
                this.headerPane.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // listBoxControl
                // 
                simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
                simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Near;
                simpleContextButton1.Id = new System.Guid("07615a42-60b8-4284-bc4c-d14067d2e65e");
                simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Unchecked;
                simpleContextButton1.Name = "btnCheck";
                simpleContextButton1.Padding = new System.Windows.Forms.Padding(8);
                this.listBoxControl.ContextButtons.Add(simpleContextButton1);
                this.listBoxControl.DataSource = this.todoItemBindingSource;
                this.listBoxControl.DisplayMember = "Title";
                this.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.listBoxControl.ItemHeight = 48;
                this.listBoxControl.Location = new System.Drawing.Point(20, 60);
                this.listBoxControl.Name = "listBoxControl";
                this.listBoxControl.ShowFocusRect = false;
                this.listBoxControl.Size = new System.Drawing.Size(358, 362);
                this.listBoxControl.TabIndex = 0;
                tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
                tableColumnDefinition1.Length.Value = 48D;
                tableColumnDefinition1.PaddingLeft = 8;
                tableColumnDefinition1.PaddingRight = 8;
                itemTemplateBase1.Columns.Add(tableColumnDefinition1);
                itemTemplateBase1.Columns.Add(tableColumnDefinition2);
                templatedItemElement1.ColumnIndex = 1;
                templatedItemElement1.FieldName = "Title";
                templatedItemElement1.Text = "Title";
                templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
                templatedItemElement2.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
                templatedItemElement2.Appearance.Normal.Options.UseForeColor = true;
                templatedItemElement2.ColumnIndex = 1;
                templatedItemElement2.FieldName = "Description";
                templatedItemElement2.RowIndex = 1;
                templatedItemElement2.Text = "Description";
                templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
                templatedItemElement3.FieldName = "IsCompleted";
                templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
                templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
                templatedItemElement3.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Checked;
                templatedItemElement3.Text = "IsCompleted";
                templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
                templatedItemElement3.TextVisible = false;
                itemTemplateBase1.Elements.Add(templatedItemElement1);
                itemTemplateBase1.Elements.Add(templatedItemElement2);
                itemTemplateBase1.Elements.Add(templatedItemElement3);
                itemTemplateBase1.Name = "ToDoItem";
                itemTemplateBase1.Rows.Add(tableRowDefinition1);
                itemTemplateBase1.Rows.Add(tableRowDefinition2);
                tableSpan1.RowSpan = 2;
                itemTemplateBase1.Spans.Add(tableSpan1);
                this.listBoxControl.Templates.Add(itemTemplateBase1);
                this.listBoxControl.CustomizeContextItem += new DevExpress.XtraEditors.ViewInfo.ListBoxControlContextButtonCustomizeEventHandler(this.OnListBoxControl_CustomizeContextItem);
                this.listBoxControl.CustomizeItem += new DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(this.OnListBoxControl_CustomizeItem);
                // 
                // searchControl
                // 
                this.searchControl.Client = this.listBoxControl;
                this.searchControl.Dock = System.Windows.Forms.DockStyle.Top;
                this.searchControl.Location = new System.Drawing.Point(20, 40);
                this.searchControl.Name = "searchControl";
                this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Repository.ClearButton(),
                new DevExpress.XtraEditors.Repository.SearchButton()});
                this.searchControl.Properties.Client = this.listBoxControl;
                this.searchControl.Properties.NullValuePrompt = "Start typing here to search...";
                this.searchControl.Size = new System.Drawing.Size(358, 20);
                this.searchControl.TabIndex = 1;
                // 
                // titleLabel
                // 
                this.titleLabel.Appearance.FontSizeDelta = 4;
                this.titleLabel.Appearance.Options.UseFont = true;
                this.titleLabel.Appearance.Options.UseTextOptions = true;
                this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                this.headerPane.SetColumn(this.titleLabel, 0);
                this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
                this.titleLabel.Location = new System.Drawing.Point(0, 0);
                this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
                this.titleLabel.Name = "titleLabel";
                this.headerPane.SetRow(this.titleLabel, 0);
                this.titleLabel.Size = new System.Drawing.Size(320, 38);
                this.titleLabel.TabIndex = 2;
                this.titleLabel.Text = "{Title}";
                // 
                // toggleShowAll
                // 
                this.footerPane.SetColumn(this.toggleShowAll, 0);
                this.toggleShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
                this.toggleShowAll.EditValue = true;
                this.toggleShowAll.Location = new System.Drawing.Point(0, 8);
                this.toggleShowAll.Margin = new System.Windows.Forms.Padding(0);
                this.toggleShowAll.Name = "toggleShowAll";
                this.toggleShowAll.Properties.AllowFocused = false;
                this.toggleShowAll.Properties.AutoWidth = true;
                this.toggleShowAll.Properties.OffText = " Show All Tasks";
                this.toggleShowAll.Properties.OnText = " Show All Tasks";
                this.footerPane.SetRow(this.toggleShowAll, 0);
                this.toggleShowAll.Size = new System.Drawing.Size(126, 26);
                this.toggleShowAll.TabIndex = 3;
                // 
                // footerPane
                // 
                this.footerPane.AutoSize = true;
                this.footerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
                this.footerPane.Controls.Add(this.toggleShowAll);
                this.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.footerPane.Location = new System.Drawing.Point(20, 422);
                this.footerPane.Margin = new System.Windows.Forms.Padding(0);
                this.footerPane.Name = "footerPane";
                this.footerPane.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
                this.footerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
                this.footerPane.Size = new System.Drawing.Size(358, 34);
                this.footerPane.TabIndex = 4;
                // 
                // headerPane
                // 
                this.headerPane.AutoSize = true;
                this.headerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
                this.headerPane.Controls.Add(this.btnNew);
                this.headerPane.Controls.Add(this.titleLabel);
                this.headerPane.Dock = System.Windows.Forms.DockStyle.Top;
                this.headerPane.Location = new System.Drawing.Point(20, 2);
                this.headerPane.Margin = new System.Windows.Forms.Padding(0);
                this.headerPane.Name = "headerPane";
                this.headerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
                this.headerPane.Size = new System.Drawing.Size(358, 38);
                this.headerPane.TabIndex = 5;
                // 
                // btnNew
                // 
                this.btnNew.AllowFocus = false;
                this.btnNew.AutoSize = true;
                this.headerPane.SetColumn(this.btnNew, 1);
                this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
                this.btnNew.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.New;
                this.btnNew.Location = new System.Drawing.Point(320, 0);
                this.btnNew.Margin = new System.Windows.Forms.Padding(0);
                this.btnNew.Name = "btnNew";
                this.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                this.headerPane.SetRow(this.btnNew, 0);
                this.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                this.btnNew.Size = new System.Drawing.Size(38, 38);
                this.btnNew.TabIndex = 3;
                // 
                // todoItemBindingSource
                // 
                this.todoItemBindingSource.DataSource = typeof(TodoItem);
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(ItemsViewModel); // #2
                // 
                // ItemsView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.listBoxControl);
                this.Controls.Add(this.searchControl);
                this.Controls.Add(this.headerPane);
                this.Controls.Add(this.footerPane);
                this.Name = "ItemsView";
                this.Padding = new System.Windows.Forms.Padding(20, 2, 20, 12);
                this.Size = new System.Drawing.Size(398, 468);
                ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.footerPane)).EndInit();
                this.footerPane.ResumeLayout(false);
                this.footerPane.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
                this.headerPane.ResumeLayout(false);
                this.headerPane.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
            #endregion
            private DevExpress.XtraEditors.ListBoxControl listBoxControl;
            private DevExpress.XtraEditors.SearchControl searchControl;
            internal System.Windows.Forms.BindingSource todoItemBindingSource;
            private DevExpress.XtraEditors.LabelControl titleLabel;
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
            private DevExpress.XtraEditors.ToggleSwitch toggleShowAll;
            private DevExpress.Utils.Layout.TablePanel footerPane;
            private DevExpress.Utils.Layout.TablePanel headerPane;
            private DevExpress.XtraEditors.SimpleButton btnNew;
        }
        partial class ItemsView : XtraUserControl {
            public ItemsView() {
                InitializeComponent();
                // Initializing bindings only at runtime    // #2
                if(!mvvmContext.IsDesignMode)               // #2
                    InitializeBindings();                   // #2
            }
            void InitializeBindings() {         // #2
                // $CodeBehindInsertionLine$    // #2
            }                                   // #2
            void OnListBoxControl_CustomizeItem(object sender, CustomizeTemplatedItemEventArgs e) {
                var item = e.DataItem as TodoItem;
                if(!item.IsCompleted)
                    e.TemplatedItem.Elements["IsCompleted"].ImageOptions.SvgImage = null;
            }
            void OnListBoxControl_CustomizeContextItem(object sender, ListBoxControlContextButtonCustomizeEventArgs e) {
                var item = e.Item as TodoItem;
                e.ContextItem.Visibility = item.IsCompleted ? ContextItemVisibility.Hidden : ContextItemVisibility.Auto;
            }
        }
        // Hidden code
        [CodeExampleNestedClass]
        public class ItemsViewContainer : XtraForm, IRepository {
            public ItemsViewContainer() {
                this.SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.ClientSize = new System.Drawing.Size(398, 255);
                this.CloseBox = false;
                this.IconOptions.ShowIcon = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "MainView";
                this.ResumeLayout(false);
            }
            protected override DevExpress.XtraEditors.FormShowMode ShowMode {
                get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; }
            }
            readonly BindingList<TodoItem> items = new BindingList<TodoItem> {
                    new TodoItem() { Id = 1, Title = "Task 1", Description = "some text 1" },
                    new TodoItem() { Id = 2, Title = "Task 2", Description = "some text 2" },
                };
            IList<TodoItem> IRepository.LoadItems(Func<TodoItem, bool> filter) {
                return items;
            }
            bool IRepository.HasChanges(int id, TodoItem item) {
                return item.IsCompleted;
            }
            void IRepository.Save(TodoItem item) {
                items.ResetBindings();
            }
        }
        [CodeExampleNestedClass]
        public interface IRepository {
            IList<TodoItem> LoadItems(Func<TodoItem, bool> filter = null);
            bool HasChanges(int id, TodoItem item);
            void Save(TodoItem item);
        }
        [CodeExampleNestedClass]
        public class TodoItem {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
        }
        [CodeExampleNestedClass]
        public class AppModel {
            public const int NewItemID = int.MinValue;
        }
    }

    [CodeExampleClass("Step 5, Create the Edit Item Screen", "SimpleApp.cs")]
    [CodeExampleUnderlineTokens("SetBinding", "BindCommand", "SetObjectDataSourceBinding")]
    public static class SimpleApp_Step5 {
        static SimpleApp_Step5() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            ItemViewContainer mainView = new ItemViewContainer();
            // mainView emulates repository service (for demo purposes)
            ServiceContainer.Default.RegisterService(mainView);
            // Create itemView
            ItemView itemView = new ItemView();
            itemView.Dock = DockStyle.Fill;
            itemView.Parent = mainView;
            // Show ItemsViewContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView);
            // Initializing the data-model
            MVVMContext.SetParameter(itemView, 42);
            // Resolving view controls
            MVVMContext mvvmContext = MVVMContext.FromControl(itemView);
            LabelControl titleLabel = itemView.Controls.Find("titleLabel", true)[0] as LabelControl;
            SimpleButton btnBack = itemView.Controls.Find("btnBack", true)[0] as SimpleButton;
            SimpleButton btnSave = itemView.Controls.Find("btnSave", true)[0] as SimpleButton;
            SimpleButton btnDelete = itemView.Controls.Find("btnDelete", true)[0] as SimpleButton;
            BindingSource todoItemBindingSource = itemView.todoItemBindingSource;
            return new object[] { mvvmContext, titleLabel, btnBack, btnSave, btnDelete, todoItemBindingSource };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var mainView = sampleHost.Controls.Find("MainView", true);
            for(int i = 0; i < mainView.Length; i++)
                mainView[i].Dispose();
        }
        [CodeExampleCase("Create the ItemView",
            new Type[] { typeof(ItemView), typeof(ItemViewContainer), typeof(TodoItem), typeof(IRepository) },
            null,
            typeof(ItemView),
            HiddenTypes = "ItemViewContainer;TodoItem;IRepository"
        ), TodoAppDescription("CreateItemView")]
        public static void CreateItemView(MVVMContext mvvmContext, LabelControl titleLabel, SimpleButton btnBack, SimpleButton btnSave, SimpleButton btnDelete, BindingSource todoItemBindingSource) {
            // Here we will write all our bindings
        }
        [CodeExampleCase("Create the ItemViewModel",
            new Type[] { typeof(ItemView), typeof(ItemViewModel), typeof(ItemViewContainer), typeof(TodoItem), typeof(IRepository), typeof(AppModel) },
            typeof(ItemViewModel),
            typeof(ItemView),
            HiddenTypes = "ItemView;ItemViewContainer;TodoItem;IRepository;AppModel"
        ), TodoAppDescription("CreateAndBindItemViewModel")]
        public static void CreateAndBindItemViewModel(MVVMContext mvvmContext, LabelControl titleLabel, SimpleButton btnBack, SimpleButton btnSave, SimpleButton btnDelete, BindingSource todoItemBindingSource) {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ItemViewModel>();
            // Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            // Bind commands to buttons
            fluent.BindCommand(btnBack, x => x.Close);
            fluent.BindCommand(btnSave, x => x.Save);
            fluent.BindCommand(btnDelete, x => x.Delete);
            // Bind datasource to editors
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, x => x.Item, x => x.Update);
        }

        [CodeExampleNestedClass]
        public class ItemViewModel : ISupportParameter {
            object ISupportParameter.Parameter {
                get { return Item; }
                set { ReloadItem((int)value); }
            }
            protected IRepository Repository {
                get { return this.GetRequiredService<IRepository>(); }
            }
            void ReloadItem(int id) {
                Item = Repository.LoadItem(id);
            }
            public virtual TodoItem Item {
                get;
                protected set;
            }
            public virtual bool HasChanges {
                get;
                protected set;
            }
            public string Title {
                get {
                    if(Item == null)
                        return string.Empty;
                    var suffix = (HasChanges ? "*" : string.Empty);
                    if(IsNew)
                        return "New task" + suffix;
                    else
                        return "Task #" + Item.Id.ToString() + suffix;
                }
            }
            bool IsNew {
                get { return Item.Id == AppModel.NewItemID; }
            }
            protected void OnItemChanged() {
                HasChanges = false;
                this.RaiseCanExecuteChanged(x => x.Save());
                this.RaiseCanExecuteChanged(x => x.Delete());
                this.RaisePropertyChanged(x => x.Title);
            }
            protected void OnHasChangesChanged() {
                this.RaisePropertyChanged(x => x.Title);
                this.RaiseCanExecuteChanged(x => x.Save());
            }
            public void Update() {
                HasChanges = Repository.HasChanges(Item.Id, Item);
            }
            public bool CanSave() {
                return (Item != null) && HasChanges;
            }
            public void Save() {
                Repository.Save(Item);
                HasChanges = false;
            }
            public bool CanDelete() {
                return (Item != null) && !IsNew;
            }
            public void Delete() {
                if(Repository.Delete(Item.Id))
                    Close();
            }
            protected INavigationService NavigationService {
                get { return this.GetService<INavigationService>(); }
            }
            public void Close() {
                // TODO: we will uncomment these item in complete application
                // var document = NavigationService.Current as IDocument;
                // NavigationService.GoBack();
                // if(document != null)
                //    document.Close(true);
            }
        }
        [CodeExampleNestedClass]
        public partial class ItemView {
            /// <summary> 
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
                this.headerPane = new DevExpress.Utils.Layout.TablePanel();
                this.btnBack = new DevExpress.XtraEditors.SimpleButton();
                this.titleLabel = new DevExpress.XtraEditors.LabelControl();
                this.footerPane = new DevExpress.Utils.Layout.TablePanel();
                this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
                this.btnSave = new DevExpress.XtraEditors.SimpleButton();
                this.dataPane = new DevExpress.Utils.Layout.TablePanel();
                this.lblDescription = new DevExpress.XtraEditors.LabelControl();
                this.lblTitle = new DevExpress.XtraEditors.LabelControl();
                this.teTitle = new DevExpress.XtraEditors.TextEdit();
                this.teDescription = new DevExpress.XtraEditors.MemoEdit();
                this.tglCompleted = new DevExpress.XtraEditors.ToggleSwitch();
                this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
                this.headerPane.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.footerPane)).BeginInit();
                this.footerPane.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataPane)).BeginInit();
                this.dataPane.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.tglCompleted.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
                this.SuspendLayout();
                // 
                // headerPane
                // 
                this.headerPane.AutoSize = true;
                this.headerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
                this.headerPane.Controls.Add(this.btnBack);
                this.headerPane.Controls.Add(this.titleLabel);
                this.headerPane.Controls.Add(this.btnDelete);
                this.headerPane.Controls.Add(this.btnSave);
                this.headerPane.Dock = System.Windows.Forms.DockStyle.Top;
                this.headerPane.Location = new System.Drawing.Point(20, 2);
                this.headerPane.Margin = new System.Windows.Forms.Padding(0);
                this.headerPane.Name = "headerPane";
                this.headerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
                this.headerPane.Size = new System.Drawing.Size(358, 38);
                this.headerPane.TabIndex = 6;
                // 
                // btnBack
                // 
                this.btnBack.AllowFocus = false;
                this.btnBack.AutoSize = true;
                this.headerPane.SetColumn(this.btnBack, 0);
                this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
                this.btnBack.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Back;
                this.btnBack.Location = new System.Drawing.Point(0, 0);
                this.btnBack.Margin = new System.Windows.Forms.Padding(0);
                this.btnBack.Name = "btnBack";
                this.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                this.headerPane.SetRow(this.btnBack, 0);
                this.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                this.btnBack.Size = new System.Drawing.Size(38, 38);
                this.btnBack.TabIndex = 3;
                // 
                // titleLabel
                // 
                this.titleLabel.Appearance.FontSizeDelta = 4;
                this.titleLabel.Appearance.Options.UseFont = true;
                this.titleLabel.Appearance.Options.UseTextOptions = true;
                this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                this.headerPane.SetColumn(this.titleLabel, 1);
                this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
                this.titleLabel.Location = new System.Drawing.Point(38, 0);
                this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
                this.titleLabel.Name = "titleLabel";
                this.titleLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
                this.headerPane.SetRow(this.titleLabel, 0);
                this.titleLabel.Size = new System.Drawing.Size(244, 38);
                this.titleLabel.TabIndex = 2;
                this.titleLabel.Text = "{Title}";
                // 
                // footerPane
                // 
                this.footerPane.AutoSize = true;
                this.footerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
                this.footerPane.Controls.Add(this.tglCompleted);
                this.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.footerPane.Location = new System.Drawing.Point(20, 422);
                this.footerPane.Margin = new System.Windows.Forms.Padding(0);
                this.footerPane.Name = "footerPane";
                this.footerPane.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
                this.footerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
                this.footerPane.Size = new System.Drawing.Size(358, 34);
                this.footerPane.TabIndex = 7;
                // 
                // btnDelete
                // 
                this.btnDelete.AllowFocus = false;
                this.btnDelete.AutoSize = true;
                this.headerPane.SetColumn(this.btnDelete, 2);
                this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
                this.btnDelete.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Delete;
                this.btnDelete.Location = new System.Drawing.Point(282, 0);
                this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
                this.btnDelete.Name = "btnDelete";
                this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                this.headerPane.SetRow(this.btnDelete, 0);
                this.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                this.btnDelete.Size = new System.Drawing.Size(38, 38);
                this.btnDelete.TabIndex = 4;
                // 
                // btnSave
                // 
                this.btnSave.AllowFocus = false;
                this.btnSave.AutoSize = true;
                this.headerPane.SetColumn(this.btnSave, 3);
                this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
                this.btnSave.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Save;
                this.btnSave.Location = new System.Drawing.Point(320, 0);
                this.btnSave.Margin = new System.Windows.Forms.Padding(0);
                this.btnSave.Name = "btnSave";
                this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                this.headerPane.SetRow(this.btnSave, 0);
                this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                this.btnSave.Size = new System.Drawing.Size(38, 38);
                this.btnSave.TabIndex = 3;
                // 
                // dataPane
                // 
                this.dataPane.AutoSize = true;
                this.dataPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
                new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
                this.dataPane.Controls.Add(this.lblDescription);
                this.dataPane.Controls.Add(this.lblTitle);
                this.dataPane.Controls.Add(this.teTitle);
                this.dataPane.Controls.Add(this.teDescription);
                this.dataPane.Dock = System.Windows.Forms.DockStyle.Fill;
                this.dataPane.Location = new System.Drawing.Point(20, 40);
                this.dataPane.Margin = new System.Windows.Forms.Padding(0);
                this.dataPane.Name = "dataPane";
                this.dataPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
                new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
                this.dataPane.Size = new System.Drawing.Size(358, 382);
                this.dataPane.TabIndex = 8;
                // 
                // lblDescription
                // 
                this.lblDescription.Appearance.FontSizeDelta = 2;
                this.lblDescription.Appearance.Options.UseFont = true;
                this.lblDescription.Appearance.Options.UseTextOptions = true;
                this.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                this.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
                this.dataPane.SetColumn(this.lblDescription, 0);
                this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
                this.lblDescription.Location = new System.Drawing.Point(0, 53);
                this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
                this.lblDescription.Name = "lblDescription";
                this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 2, 0, 4);
                this.dataPane.SetRow(this.lblDescription, 2);
                this.lblDescription.Size = new System.Drawing.Size(358, 23);
                this.lblDescription.TabIndex = 5;
                this.lblDescription.Text = "Description";
                // 
                // lblTitle
                // 
                this.lblTitle.Appearance.FontSizeDelta = 2;
                this.lblTitle.Appearance.Options.UseFont = true;
                this.lblTitle.Appearance.Options.UseTextOptions = true;
                this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
                this.dataPane.SetColumn(this.lblTitle, 0);
                this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
                this.lblTitle.Location = new System.Drawing.Point(0, 0);
                this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
                this.dataPane.SetRow(this.lblTitle, 0);
                this.lblTitle.Size = new System.Drawing.Size(358, 33);
                this.lblTitle.TabIndex = 4;
                this.lblTitle.Text = "Title";
                // 
                // teTitle
                // 
                this.dataPane.SetColumn(this.teTitle, 0);
                this.teTitle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                this.teTitle.Dock = System.Windows.Forms.DockStyle.Fill;
                this.teTitle.Location = new System.Drawing.Point(0, 33);
                this.teTitle.Margin = new System.Windows.Forms.Padding(0);
                this.teTitle.Name = "teTitle";
                this.teTitle.Properties.NullValuePrompt = "Enter task title here...";
                this.teTitle.Properties.ValidateOnEnterKey = true;
                this.dataPane.SetRow(this.teTitle, 1);
                this.teTitle.Size = new System.Drawing.Size(358, 20);
                this.teTitle.TabIndex = 2;
                // 
                // teDescription
                // 
                this.dataPane.SetColumn(this.teDescription, 0);
                this.teDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                this.teDescription.Dock = System.Windows.Forms.DockStyle.Fill;
                this.teDescription.Location = new System.Drawing.Point(0, 76);
                this.teDescription.Margin = new System.Windows.Forms.Padding(0);
                this.teDescription.Name = "teDescription";
                this.teDescription.Properties.NullValuePrompt = "Enter task description here...";
                this.teDescription.Properties.ValidateOnEnterKey = true;
                this.dataPane.SetRow(this.teDescription, 3);
                this.teDescription.Size = new System.Drawing.Size(358, 306);
                this.teDescription.TabIndex = 3;
                // 
                // tglCompleted
                // 
                this.footerPane.SetColumn(this.tglCompleted, 0);
                this.tglCompleted.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "IsCompleted", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
                this.tglCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tglCompleted.EditValue = true;
                this.tglCompleted.Location = new System.Drawing.Point(0, 8);
                this.tglCompleted.Margin = new System.Windows.Forms.Padding(0);
                this.tglCompleted.Name = "tglCompleted";
                this.tglCompleted.Properties.AllowFocused = false;
                this.tglCompleted.Properties.AutoWidth = true;
                this.tglCompleted.Properties.OffText = " Is Completed";
                this.tglCompleted.Properties.OnText = " Is Completed";
                this.footerPane.SetRow(this.tglCompleted, 0);
                this.tglCompleted.Size = new System.Drawing.Size(119, 26);
                this.tglCompleted.TabIndex = 5;
                // 
                // todoItemBindingSource
                // 
                this.todoItemBindingSource.DataSource = typeof(TodoItem);
                // 
                // mvvmContext
                // 
                this.mvvmContext.ContainerControl = this;
                this.mvvmContext.ViewModelType = typeof(ItemViewModel); // #2
                // 
                // ItemView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.dataPane);
                this.Controls.Add(this.footerPane);
                this.Controls.Add(this.headerPane);
                this.Margin = new System.Windows.Forms.Padding(0);
                this.Name = "ItemView";
                this.Padding = new System.Windows.Forms.Padding(20, 2, 20, 12);
                this.Size = new System.Drawing.Size(398, 468);
                ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
                this.headerPane.ResumeLayout(false);
                this.headerPane.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.footerPane)).EndInit();
                this.footerPane.ResumeLayout(false);
                this.footerPane.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataPane)).EndInit();
                this.dataPane.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.tglCompleted.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
            #endregion
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
            private DevExpress.Utils.Layout.TablePanel headerPane;
            private DevExpress.XtraEditors.SimpleButton btnBack;
            private DevExpress.XtraEditors.LabelControl titleLabel;
            private DevExpress.Utils.Layout.TablePanel footerPane;
            private DevExpress.XtraEditors.SimpleButton btnSave;
            private DevExpress.XtraEditors.SimpleButton btnDelete;
            private DevExpress.Utils.Layout.TablePanel dataPane;
            private DevExpress.XtraEditors.LabelControl lblDescription;
            private DevExpress.XtraEditors.LabelControl lblTitle;
            private DevExpress.XtraEditors.TextEdit teTitle;
            private DevExpress.XtraEditors.MemoEdit teDescription;
            internal System.Windows.Forms.BindingSource todoItemBindingSource;
            private DevExpress.XtraEditors.ToggleSwitch tglCompleted;
        }
        partial class ItemView : XtraUserControl {
            public ItemView() {
                InitializeComponent();
                // Initializing bindings only at runtime    // #2
                if(!mvvmContext.IsDesignMode)               // #2
                    InitializeBindings();                   // #2
            }
            void InitializeBindings() {         // #2
                // $CodeBehindInsertionLine$    // #2
            }                                   // #2
        }
        // Hidden code
        [CodeExampleNestedClass]
        public class ItemViewContainer : XtraForm, IRepository {
            public ItemViewContainer() {
                this.SuspendLayout();
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.ClientSize = new System.Drawing.Size(398, 255);
                this.CloseBox = false;
                this.IconOptions.ShowIcon = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "MainView";
                this.ResumeLayout(false);
            }
            protected override DevExpress.XtraEditors.FormShowMode ShowMode {
                get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; }
            }
            readonly TodoItem dataItem = new TodoItem() {
                Title = "Task 1",
                Description = "Some description",
            };
            TodoItem IRepository.LoadItem(int id) {
                return new TodoItem() { Id = id, Title = dataItem.Title, Description = dataItem.Description };
            }
            bool IRepository.Delete(int id) {
                return false;
            }
            bool IRepository.HasChanges(int id, TodoItem item) {
                return
                    item.Title != dataItem.Title ||
                    item.Description != dataItem.Description ||
                    item.IsCompleted != dataItem.IsCompleted;
            }
            int IRepository.Save(TodoItem item) {
                dataItem.Title = item.Title;
                dataItem.Description = item.Description;
                dataItem.IsCompleted = item.IsCompleted;
                return item.Id;
            }
        }
        [CodeExampleNestedClass]
        public interface IRepository {
            TodoItem LoadItem(int id);
            bool HasChanges(int id, TodoItem item);
            int Save(TodoItem item);
            bool Delete(int id);
        }
        [CodeExampleNestedClass]
        public class TodoItem {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
        }
        [CodeExampleNestedClass]
        public class AppModel {
            public const int NewItemID = int.MinValue;
        }
    }

    [CodeExampleClass("Step 6, Set Up Interaction Between ViewModels", "SimpleApp.cs")]
    [CodeExampleHighlightTokens("Messenger")]
    [CodeExampleUnderlineTokens("Send", "Register", "Unregister")]
    public static class SimpleApp_Step6 {
        static SimpleApp_Step6() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var schema = new PictureEdit();
            schema.Dock = System.Windows.Forms.DockStyle.Fill;
            schema.BackColor = System.Drawing.Color.Transparent;
            schema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            schema.Properties.ReadOnly = true;
            schema.Properties.AllowFocused = false;
            schema.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            schema.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Interoperations;
            schema.Parent = sampleHost;
            object recipient = new object();
            return new object[] { recipient };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("Send Messages from the ItemViewModel",
            new Type[] { typeof(ItemViewModel), typeof(ItemsViewModel), typeof(ReloadRequired), typeof(TodoItem), typeof(IRepository), typeof(AppModel) },
            HiddenTypes = "ItemsViewModel;TodoItem;IRepository;AppModel"
        ), TodoAppDescription("SendingMessages")]
        public static void SendingMessages(object recipient) {
            // You can send the specific message via Send method
            Messenger.Default.Send(ReloadRequired.All);
        }
        [CodeExampleCase("Receive Messages in the ItemsViewModel",
            new Type[] { typeof(ItemViewModel),typeof(ItemsViewModel), typeof(ReloadRequired), typeof(TodoItem), typeof(IRepository), typeof(AppModel) },
            HiddenTypes = "ItemViewModel;TodoItem;IRepository;AppModel"
        ), TodoAppDescription("RegisteringMessageRecipient")]
        public static void RegisteringMessageRecipient(object recipient) {
            // You can registering some viewModel as Messenger recepient
            Messenger.Default.Register<ReloadRequired>(recipient, m => { 
                // do something here
            });
            // And you can stop listening messages when it required
            Messenger.Default.Unregister<ReloadRequired>(recipient);
        }

        [CodeExampleNestedClass]
        public class ItemViewModel {
            protected IRepository Repository {
                get { return this.GetRequiredService<IRepository>(); }
            }
            public virtual TodoItem Item {
                get;
                protected set;
            }
            public void Save() {
                bool isNew = (Item.Id == AppModel.NewItemID);
                int savedId = Repository.Save(Item);
                if(isNew) {
                    // Sending the ReloadRequired message for new item
                    Messenger.Default.Send(ReloadRequired.FromNew(savedId));
                }
                else {
                    // Sending the ReloadRequired message for the specific item
                    Messenger.Default.Send(ReloadRequired.FromId(savedId));
                }
            }
            public void Delete() {
                if(Repository.Delete(Item.Id)) {
                    // Sending the ReloadRequired message for all items
                    Messenger.Default.Send(ReloadRequired.All);
                }
            }
            // ... 
            // Code from the previous steps
        }
        [CodeExampleNestedClass]
        public class ItemsViewModel {
            public ItemsViewModel() {
                // Start listen the ReloadRequired message 
                Messenger.Default.Register<ReloadRequired>(this, OnReloadRequired);
            }
            protected IRepository Repository {
                get { return this.GetRequiredService<IRepository>(); }
            }
            public virtual IList<TodoItem> Items {
                get;
                protected set;
            }
            public virtual bool ShowAllItems {
                get;
                set;
            }
            void OnReloadRequired(ReloadRequired message) {
                if(message == ReloadRequired.All || message.IsNew) {
                    // Reload all Items when new item added or explicit reload requested
                    if(ShowAllItems)
                        Items = Repository.LoadItems();
                    else
                        Items = Repository.LoadItems(x => !x.IsCompleted);
                }
                // Reload the specific item within the Items collection
                else Repository.ReloadItem(Items, message.Id);
            }
            // ... 
            // Code from the previous steps
        }
        [CodeExampleNestedClass]
        public class ReloadRequired {
            #region static
            public readonly static ReloadRequired All = new ReloadRequired(AppModel.NewItemID, false);
            public static ReloadRequired FromId(int id) {
                return new ReloadRequired(id, false);
            }
            public static ReloadRequired FromNew(int id) {
                return new ReloadRequired(id, true);
            }
            #endregion static
            // Deny direct instances creation
            ReloadRequired(int id, bool isNew) {
                this.Id = id; 
                this.IsNew = isNew;
            }
            public int Id {
                get;
                private set;
            }
            public bool IsNew {
                get;
                private set;
            }
        }
        // Hidden Code
        [CodeExampleNestedClass]
        public interface IRepository {
            IList<TodoItem> LoadItems(Func<TodoItem, bool> filter = null);
            TodoItem ReloadItem(IList<TodoItem> items, int id);
            int Save(TodoItem item);
            bool Delete(int id);
        }
        [CodeExampleNestedClass]
        public class TodoItem {
            public int Id { get; set; }
            public bool IsCompleted { get; set; }
        }
        [CodeExampleNestedClass]
        public class AppModel {
            public const int NewItemID = int.MinValue;
        }
    }
}
