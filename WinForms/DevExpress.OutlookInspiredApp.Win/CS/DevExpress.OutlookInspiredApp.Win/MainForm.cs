using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Customization;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.Modules;
using DevExpress.DevAV.ViewModels;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
#if NET
using System.ComponentModel;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Tools;
#endif

namespace DevExpress.DevAV {
    public partial class MainForm : RibbonForm, IMainModule, ISupportViewModel {
#if NET
        public const string ToolsChatResponseProviderServiceKey = "ToolsChatResponseProviderServiceKey";
        const string SystemMessage =
@"You are an assistant integrated into an application. Your role is to perform all user-requested UI operations exclusively through the provided tools.
The application consists of modules such as Employees, Customers, Products, and Orders, each containing a grid with relevant data. Tools used to interact with the application are module-scoped, meaning they appear only after navigating to the corresponding module.

Rules:
1. Always use tools to interact with the UI. Do not simulate actions or produce imagined results.
2. If the user’s request refers to any module’s data or operations, you must always identify the target module and call NavigateToModule for that module first, even if the required tool is not currently visible.
3. If a tool requires a tool-target identifier, obtain it only by calling the GetToolTargets tool. Never invent, guess, or construct identifiers; always use one returned by GetToolTargets.
4. Before performing operations on grid data (filtering, adding, editing records, etc.), always switch to the corresponding module first using NavigateToModule.";
#endif
        public MainForm() {
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, this);
            AppHelper.MainForm = this;
            DevExpress.DevAV.StartUpProcess.OnStart("When Only the Best Will Do");
            InitializeComponent();
            DevExpress.DevAV.StartUpProcess.OnRunning("Initializing...");
            IconOptions.SvgImage = AppHelper.AppIcon;
            mvvmContext.ViewModelConstructorParameter = this;
            ViewModel.ModuleAdded += viewModel_ModuleAdded;
            ViewModel.ModuleRemoved += viewModel_ModuleRemoved;
            ViewModel.SelectedModuleTypeChanged += viewModel_SelectedModuleTypeChanged;
            ViewModel.Print += viewModel_Print;
            ViewModel.IsReadingModeChanged += viewModel_IsReadingModeChanged;
            ribbonControl.ApplicationButtonDropDownControl = null;
            ribbonControl.SelectedPage = ribbonControl.Pages[1];
            ribbonControl.SelectedPageChanging += RibbonControl_SelectedPageChanging;
            ribbonControl.ApplicationButtonClick += RibbonControl_ApplicationButtonClick;
            backstageViewControl.Hidden += BackstageViewControl_Hidden;
            ribbonControl.MinimizedChanged += Ribbon_MinimizedChanged;
            ribbonControl.Manager.HideBarsWhenMerging = false;
            ribbonStatusBar1.HideWhenMerging = DefaultBoolean.False;
            ribbonControl.ForceInitialize();
            new ZoomLevelManager(beZoomLevel, bbiZoomDialog, ViewModel);
            backstageViewControl.SelectedTabChanged += backstageViewControl_SelectedTabChanged;
            backstageViewControl.Shown += backstageViewControl_Shown;
            backstageViewControl.Hidden += backstageViewControl_Hidden;
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = ColorHelper.GetControlColor(LookAndFeel);
            backstageViewControl.BackstageViewShowRibbonItems = BackstageViewShowRibbonItems.None;
            Ribbon.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
            IconOptions.ShowIcon = false;
            
            BindCommands();
            BindFiltersVisibility();
            InitNotifications();
            InitTaskBarCommands();
            InitRibbonWindowModeAndAccentColor();
            InitChatPanelControl();

            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            bciShowChatControl.Checked = true;
            FluentIconHelper.SwapFluentIcons(this);
        }
        void InitChatPanelControl() {
#if NET
            var control = CreateChatControl();
#else
            var control = CreateLabelControl();
#endif
            Controls.Add(control);
            chatControlPanel.Controls.Add(control);
        }
#if NET
        Control CreateChatControl() {
            var chat = new AIIntegration.WinForms.Chat.AIChatControl();
            chat.Dock = DockStyle.Fill;
            chat.ShowHeader = DefaultBoolean.True;
            chat.HeaderText = "AI Assistant";
            chat.EmptyStateText = "Try a predefined request or type in a custom prompt";
            chat.ChatResponseProviderServiceKey = ToolsChatResponseProviderServiceKey;
            chat.LoadMessages([new AIIntegration.Blazor.Chat.BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.System, SystemMessage)]);
            chat.SetPromptSuggestions([
                new(
                    title: "Filter Orders",
                    text: "Order total exceeds $20,000",
                    prompt: "Display orders with Order Total over 20,000.",
                    true),
                new(
                    title: "Add a Product",
                    text: "Product name: Projector Plus4K",
                    prompt: "Add a new product to the Projectors category. Set the product name to Projector Plus4K and set the price to $500.",
                    true),
                new(
                    title: "Application Theme",
                    text: "Switch to dark mode",
                    prompt: "Switch the application theme to dark mode.",
                    true),
                new(
                    title: "About this chat",
                    text: "List available tasks",
                    prompt: "Analyze the methods available to you and display a bullet list with tasks that you can do for me.",
                    true),
            ]);
            return chat;
        }
#else
        Control CreateLabelControl() {
            var label = new XtraEditors.LabelControl();
            label.Text = "This feature is only supported in .NET Core. Please refer to the .NET Core version of the demo.";
            label.AutoSizeMode = XtraEditors.LabelAutoSizeMode.Vertical;
            label.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            const int padding = 10;
            chatControlPanel.Resize += (s, e) => {
                label.Width = chatControlPanel.Width - padding * 2;
                label.Location = new Point(padding, (chatControlPanel.Height - label.Height) / 2);
            };
            return label;
        }
#endif
        void BackstageViewControl_Hidden(object sender, EventArgs e) {
            ribbonControl.ApplicationButtonDropDownControl = null;
        }
        void RibbonControl_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e) {
            if(e.Page.Text == "File") {
                ribbonControl.ApplicationButtonDropDownControl = backstageViewControl;
                e.Cancel = true;
                ribbonControl.ShowApplicationButtonContentControl();
            }
        }
        void RibbonControl_ApplicationButtonClick(object sender, EventArgs e) {
            bool filtersHidden = (ViewModel.FiltersVisibility == CollectionViewFiltersVisibility.Hidden);
            ViewModel.FiltersVisibility = filtersHidden ? CollectionViewFiltersVisibility.Visible : CollectionViewFiltersVisibility.Hidden; ;
        }
        public MainViewModel ViewModel {
            get { return mvvmContext.GetViewModel<MainViewModel>(); }
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        protected override XtraEditors.FormShowMode ShowMode {
            get { return XtraEditors.FormShowMode.AfterInitialization; }
        }
#if NET
        AIToolsContext globalContext;
#endif
        int loading = 0;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            loading++;
            try {
                ViewModel.SelectedModuleType = ModuleType.Employees;
                var types = new ModuleType[] { ModuleType.Employees, ModuleType.Customers, ModuleType.Products, ModuleType.Orders, ModuleType.Quotes};
                RegisterNavigationMenuItems(barNavigationItem, types);
                RegisterAccordionControlElements(accordionControl1, types, ViewModel.SelectedModuleType);
#if !NET
                bciShowChatControl.Checked = false;
#endif
            }
            finally {
                DevExpress.DevAV.StartUpProcess.OnRunning("Successfully loaded.");
                loading--;
            }
            if(MainFormHelper.TakeScreens) {
                WindowState = FormWindowState.Normal;
                MainFormHelper.TakeAllScreens(TakeModule, takeModuleTypes.Length, this, modulesContainer, TakeModuleInterval);
            }
#if NET
            globalContext = new AIToolsContextBuilder()
                .WithToolMethods(NavigateToModule, ChangeTheme)
                .Build();
            AIExtensionsContainerDesktop.Default.AddAIToolsContext(globalContext);
#endif
        }
        readonly static ModuleType[] takeModuleTypes = new ModuleType[] {
            ModuleType.Employees, ModuleType.Customers, ModuleType.Products, ModuleType.Orders, ModuleType.Quotes, ModuleType.ProductAnalysis
        };
        string TakeModule(int num) {
            ModuleType info = takeModuleTypes[num];
            ViewModel.SelectedModuleType = info;
            modulesContainer.Focus();
            return $"{info}";
        }
        int TakeModuleInterval(int num) {
            int x = 1;
            if(num == 2) x = 2;
            return 1000 * x;
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            DevExpress.DevAV.StartUpProcess.OnComplete();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if(loading > 0)
                e.Cancel = true;
            base.OnFormClosing(e);
        }
        protected override void OnFormClosed(FormClosedEventArgs e) {
            ViewModel.SelectedModuleTypeChanged -= viewModel_SelectedModuleTypeChanged;
            ViewModel.ModuleRemoved -= viewModel_ModuleRemoved;
            ViewModel.ModuleAdded -= viewModel_ModuleAdded;
            ViewModel.SelectedModuleType = ModuleType.Unknown;
            base.OnFormClosed(e);
        }
        void BindCommands() {
            mvvmContext.BindCommand<MainViewModel>(biGetStarted, x => x.GetStarted());
            mvvmContext.BindCommand<MainViewModel>(biGetSupport, x => x.GetSupport());
            mvvmContext.BindCommand<MainViewModel>(biBuyNow, x => x.BuyNow());
            mvvmContext.BindCommand<MainViewModel>(biAbout, x => x.About());
            
            mvvmContext.BindCommand<MainViewModel>(biBackstageViewGetStarted, x => x.GetStarted());
            mvvmContext.BindCommand<MainViewModel>(biBackstageViewGetSupport, x => x.GetSupport());
            mvvmContext.BindCommand<MainViewModel>(biBackstageViewBuyNow, x => x.BuyNow());
            
            mvvmContext.BindCommand<MainViewModel>(bbiNormal, x => x.TurnOffReadingMode());
            mvvmContext.BindCommand<MainViewModel>(bbiReading, x => x.TurnOnReadingMode());
        }
        void viewModel_ModuleAdded(object sender, EventArgs e) {
            var moduleControl = sender as Control;
            if(!DpiAwarenessHelper.Default.IsPerMonitor())
                modulesContainer.SuspendLayout();
            moduleControl.Dock = DockStyle.Fill;
            moduleControl.Parent = modulesContainer;

            if(!DpiAwarenessHelper.Default.IsPerMonitor())
                modulesContainer.ResumeLayout();
            Text = string.Format("{1} - {0}", ViewModel.GetModuleCaption(ViewModel.SelectedModuleType), "DevAV");
            IRibbonModule ribbonModuleControl = moduleControl as IRibbonModule;
            if(ribbonModuleControl != null) {
                Ribbon.MergeRibbon(ribbonModuleControl.Ribbon);
                Ribbon.StatusBar.MergeStatusBar(ribbonModuleControl.Ribbon.StatusBar);
            }
            else {
                Ribbon.UnMergeRibbon();
                Ribbon.StatusBar.UnMergeStatusBar();
            }
        }
        void viewModel_ModuleRemoved(object sender, EventArgs e) {
            var moduleControl = sender as Control;
            GridHelper.HideCustomization(moduleControl);
            moduleControl.Parent = null;
        }
        void viewModel_SelectedModuleTypeChanged(object sender, EventArgs e) {
            if(ViewModel.SelectedNavPaneModuleType != ModuleType.Unknown) {
                accordionControl1.SelectedElement = accordionControl1.Elements.FirstOrDefault(g => object.Equals(g.Tag, ViewModel.SelectedModuleType));
                (GetModule(ViewModel.SelectedModuleType) as ISupportFiltersVisibilityChangedEvent)?.RaiseFiltersVisibilityChanged(sender, e);
            }
            UpdateCompactLayout(!ribbonControl.Minimized);
        }
        CollectionViewFiltersVisibility prevVisibility = CollectionViewFiltersVisibility.Visible;
        void viewModel_IsReadingModeChanged(object sender, EventArgs e) {
            if(ViewModel.FiltersVisibility != CollectionViewFiltersVisibility.Hidden)
                prevVisibility = ViewModel.FiltersVisibility;
            if(ViewModel.IsReadingMode) {
                ViewModel.FiltersVisibility = CollectionViewFiltersVisibility.Hidden;
            }
            else ViewModel.FiltersVisibility = prevVisibility;
        }
        void Ribbon_MinimizedChanged(object sender, EventArgs e) {
            UpdateCompactLayout(!ribbonControl.Minimized);
        }
        void UpdateCompactLayout(bool compact) {
            if(ViewModel.SelectedNavPaneModuleType != ModuleType.Unknown)
                UpdateCompactLayout(GetNavPaneModule(ViewModel.SelectedNavPaneModuleType) as ISupportCompactLayout, compact);
            if(ViewModel.SelectedNavPaneHeaderModuleType != ModuleType.Unknown)
                UpdateCompactLayout(GetNavPaneModule(ViewModel.SelectedNavPaneHeaderModuleType) as ISupportCompactLayout, compact);
        }
        void UpdateCompactLayout(ISupportCompactLayout module, bool compact) {
            if(module != null)
                module.Compact = compact;
        }
        void backstageViewControl_SelectedTabChanged(object sender, BackstageViewItemEventArgs e) {
            if(e.Item == tabBackstageViewExport)
                AddBackStageViewModule(ViewModel.SelectedExportModuleType, tabBackstageViewExport);
            if(e.Item == tabBackstageViewPrint)
                AddBackStageViewModule(ViewModel.SelectedPrintModuleType, tabBackstageViewPrint);
        }
        void viewModel_Print(object sender, PrintEventArgs e) {
            ribbonControl.ApplicationButtonDropDownControl = backstageViewControl;
            backstageViewControl.SelectedTab = tabBackstageViewPrint;
            ribbonControl.ShowApplicationButtonContentControl();
        }
        void backstageViewControl_Shown(object sender, EventArgs e) {
            tabBackstageViewExport.Enabled = ViewModel.SelectedExportModuleType != ModuleType.QuotesExport;
            tabBackstageViewPrint.Enabled = ViewModel.SelectedPrintModuleType != ModuleType.QuotesPrint;
        }
        void backstageViewControl_Hidden(object sender, EventArgs e) {
            if(backstageViewControl.SelectedTab != tabBackstageViewAbout)
                ViewModel.AfterReportHidden();
            backstageViewControl.SelectedTab = tabBackstageViewAbout;
            ReleaseBackStageViewModule(tabBackstageViewExport);
            ReleaseBackStageViewModule(tabBackstageViewPrint);
        }
        void AddBackStageViewModule(ModuleType moduleType, BackstageViewTabItem tabItem) {
            ViewModel.BeforeReportShown(moduleType);
            tabItem.ContentControl.SuspendLayout();
            tabItem.ContentControl.Controls.Clear();
            var moduleControl = GetReportModule(moduleType);
            ViewModel.AfterReportShown(moduleType);
            moduleControl.Dock = DockStyle.Fill;
            moduleControl.Parent = tabItem.ContentControl;
            tabItem.ContentControl.ResumeLayout();
        }
        void ReleaseBackStageViewModule(BackstageViewTabItem tabItem) {
            tabItem.ContentControl.SuspendLayout();
            Control[] controls = new Control[tabItem.ContentControl.Controls.Count];
            tabItem.ContentControl.Controls.CopyTo(controls, 0);
            tabItem.ContentControl.Controls.Clear();
            for(int i = 0; i < controls.Length; i++)
                controls[i].Dispose();
            tabItem.ContentControl.ResumeLayout(false);
        }
        void InitRibbonWindowModeAndAccentColor() {
            SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode);
            bciTrackWindowsAppMode.SuperTip = new SuperToolTip();
            bciTrackWindowsAppMode.SuperTip.Items.Add("This setting is available for WXI, Basic, and Bezier skins.");
            bciTrackWindowsAppMode.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
            SkinHelper.InitResetToOriginalPalette(bciOriginalPalette);
            SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor);
            SkinHelper.InitCustomAccentColor(Ribbon.Manager, bbiCustomColors);
            bbiCustomColors.SuperTip = new SuperToolTip();
            bbiCustomColors.SuperTip.Items.Add("Custom Accent Color.");
            bbiCustomColors.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
            SkinHelper.InitCustomAccentColor2(Ribbon.Manager, bbiCustomColors2);
            bbiCustomColors2.SuperTip = new SuperToolTip();
            bbiCustomColors2.SuperTip.Items.Add("Custom Accent Color 2.");
            bbiCustomColors2.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
        }
        void bciShowChatControl_CheckedChanged(object sender, ItemClickEventArgs e) {
            chatControlPanel.Visible = bciShowChatControl.Checked;
        }
        #region Filters Visibility
        void BindFiltersVisibility() {
            ViewModel.ViewFiltersVisibilityChanged += ViewModel_ViewFiltersVisibilityChanged;
            bmiFolderNormal.BindCommand(() => ViewModel.ShowFilters(), ViewModel);
            bmiFolderMinimized.BindCommand(() => ViewModel.MinimizeFilters(), ViewModel);
            bmiFolderOff.BindCommand(() => ViewModel.HideFilters(), ViewModel);
        }
        void ViewModel_ViewFiltersVisibilityChanged(object sender, System.EventArgs e) {
            SuperToolTip applicationTip = ribbonControl.ApplicationButtonSuperTip;
            switch(ViewModel.FiltersVisibility) {
                case CollectionViewFiltersVisibility.Visible:
                    ((ToolTipTitleItem)applicationTip.Items[0]).Text = "Hide navigation pane";
                    ViewModel.IsReadingMode = false;
                    break;
                case CollectionViewFiltersVisibility.Minimized:
                    ViewModel.IsReadingMode = false;
                    break;
                case CollectionViewFiltersVisibility.Hidden:
                    ((ToolTipTitleItem)applicationTip.Items[0]).Text = "Show navigation pane";
                    ViewModel.IsReadingMode = true;
                    break;
            }
            (GetModule(ViewModel.SelectedModuleType) as ISupportFiltersVisibilityChangedEvent)?.RaiseFiltersVisibilityChanged(sender, e);
        }
        #endregion
        #region Services
        bool IsDockedCore(ModuleType peekModuleType) {
            DockPanel panel = GetPanel(peekModuleType);
            return (panel != null) && (panel.Visibility == DockVisibility.Visible);
        }
        bool IPeekModulesHost.IsDocked(ModuleType moduleType) {
            return IsDockedCore(moduleType);
        }
        void IPeekModulesHost.DockModule(ModuleType moduleType) {
            DockPanel panel = GetPanel(moduleType);
            if(panel != null) panel.Restore();
        }
        void IPeekModulesHost.UndockModule(ModuleType moduleType) {
            DockPanel panel = GetPanel(moduleType);
            if(panel != null) panel.Close();
        }
        void IPeekModulesHost.ShowPeek(ModuleType moduleType) {
            
        }
        void ISupportTransitions.StartTransition(bool forward, object waitParameter) {
            var transition = transitionManager.Transitions[modulesContainer];
            var animator = transition.TransitionType as DevExpress.Utils.Animation.SlideFadeTransition;
            animator.Parameters.EffectOptions = forward ? Utils.Animation.PushEffectOptions.FromRight : Utils.Animation.PushEffectOptions.FromLeft;
            if(waitParameter == null)
                transition.ShowWaitingIndicator = DefaultBoolean.False;
            else {
                transition.ShowWaitingIndicator = DefaultBoolean.True;
                transition.WaitingIndicatorProperties.Caption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(waitParameter);
                transition.WaitingIndicatorProperties.Description = "Loading...";
                transition.WaitingIndicatorProperties.ContentMinSize = new System.Drawing.Size(160, 0);
            }
            transitionManager.StartTransition(modulesContainer);
        }
        void ISupportTransitions.EndTransition() {
            transitionManager.EndTransition();
        }
        void ISupportModuleLayout.SaveLayoutToStream(MemoryStream ms) {
            dockManager.SaveLayoutToStream(ms);
        }
        void ISupportModuleLayout.RestoreLayoutFromStream(MemoryStream ms) {
            dockManager.RestoreLayoutFromStream(ms);
        }
        #endregion Services
        #region Navigation Menu
        void RegisterNavigationMenuItems(BarLinkContainerItem menuItem, ModuleType[] types) {
            for(int i = 0; i < types.Length; i++)
                RegisterNavigationMenuItem(menuItem, types[i]);
        }
        void RegisterNavigationMenuItem(BarLinkContainerItem menuItem, ModuleType type) {
            BarCheckItem biModule = new BarCheckItem();
            biModule.Caption = ViewModel.GetModuleCaption(type);
            biModule.Name = "biModule" + ViewModel.GetModuleName(type);
            biModule.ImageUri.Uri = ViewModel.GetModuleImageUri(type);
            biModule.ImageOptions.SvgImageSize = new Size(32, 32);
            biModule.AllowGlyphSkinning = DefaultBoolean.True;
            biModule.ImageUri.ResourceType = typeof(MainForm);
            biModule.GroupIndex = 1;
            biModule.BindCommand((t) => ViewModel.SelectModule(t), ViewModel, () => type);
            menuItem.AddItem(biModule);
        }
        #endregion Navigation Menu
        #region Navigation Bar
        void RegisterAccordionControlElements(AccordionControl accordionControl, ModuleType[] types, ModuleType selectedType) {
            accordionControl.Elements.Clear();
            for(int i = 0; i < types.Length; i++) {
                var element = RegisterAccordionControlElement(accordionControl, types[i]);
                if(types[i] == selectedType)
                    accordionControl.SelectedElement = element;
            }
        }
        AccordionControlElement RegisterAccordionControlElement(AccordionControl accordionControl, ModuleType type) {
            AccordionControlElement element = new AccordionControlElement();
            element.Tag = type;
            element.Name = "accordionElement" + ViewModel.GetModuleName(type);
            element.Text = ViewModel.GetModuleCaption(type);
            element.SuperTip = new SuperToolTip();
            element.SuperTip.Items.AddTitle(element.Text);
            element.ImageUri = ViewModel.GetModuleImageUri(type);
            element.ImageUri.ResourceType = typeof(MainForm);
            element.ImageOptions.SvgImageSize = new Size(32, 32);
            element.Style = ElementStyle.Item;
            element.Click += (s, e) => ViewModel.SelectModule(type);
            accordionControl.Elements.Add(element);
            return element;
        }
        #endregion Navigation Bar
        #region Peek Panels
        class PeekPanelsRegistrator {
            MainViewModel viewModel;
            public PeekPanelsRegistrator(MainViewModel viewModel) {
                this.viewModel = viewModel;
            }
            public void RegisterPeekPanels(DockManager dockManager, ModuleType[] types) {
                dockManager.ClosedPanel += dockManager_ClosedPanel;
                dockManager.VisibilityChanged += dockManager_VisibilityChanged;
                dockManager.StartDocking += dockManager_StartDocking;
                dockManager.BeginInit();
                RegisterPeekPanelsCore(dockManager, Array.ConvertAll(types, viewModel.GetPeekModuleType));
                dockManager.EndInit();
            }
            void RegisterPeekPanelsCore(DockManager dockManager, ModuleType[] types) {
                for(int i = 0; i < types.Length; i++)
                    RegisterPeekPanel(dockManager, types[i]);
            }
            void RegisterPeekPanel(DockManager dockManager, ModuleType type) {
                var panel = new DockPanel();
                panel.ID = viewModel.GetModuleID(type);
                panels.Add(panel.ID, type);
                panel.Name = "peekPanel" + viewModel.GetModuleName(type);
                panel.Options.AllowDockBottom = false;
                panel.Options.AllowDockLeft = false;
                panel.Options.AllowDockTop = false;
                panel.Options.AllowFloating = false;
                panel.Text = viewModel.GetModuleCaption(type);
                panel.Visibility = DockVisibility.Hidden;
                panel.SavedDock = DockingStyle.Right;
                panel.OriginalSize = new System.Drawing.Size(200, 200);
                if(dockManager.HiddenPanels.Count > 0) {
                    panel.SavedParent = dockManager.HiddenPanels[0];
                    panel.Dock = DockingStyle.Fill;
                    panel.SavedDock = DockingStyle.Fill;
                    panel.SavedIndex = dockManager.HiddenPanels.Count - 1;
                }
                var container = new ControlContainer();
                container.Name = panel.Name + "_ControlContainer";
                panel.Controls.Add(container);
                panel.Register(dockManager);
                dockManager.HiddenPanels.AddRange(new DockPanel[] { panel });
            }
            void dockManager_StartDocking(object sender, DockPanelCancelEventArgs e) {
                e.Cancel = true;
            }
            void dockManager_VisibilityChanged(object sender, VisibilityChangedEventArgs e) {
                if(e.Visibility == DockVisibility.Visible && panels.ContainsKey(e.Panel.ID)) {
                    Control module = GetPeekModuleControl(e.Panel);
                    ViewModelHelper.EnsureModuleViewModel(module, viewModel);
                    module.Dock = DockStyle.Fill;
                    e.Panel.ControlContainer.Controls.Add(module);
                }
            }
            void dockManager_ClosedPanel(object sender, DockPanelEventArgs e) {
                Control module = GetPeekModuleControl(e.Panel);
                e.Panel.ControlContainer.Controls.Remove(module);
            }
            static IDictionary<Guid, ModuleType> panels = new Dictionary<Guid, ModuleType>();
            Control GetPeekModuleControl(DockPanel panel) {
                return viewModel.GetModule(panels[panel.ID]) as Control;
            }
        }
        #endregion Peek Panels
        #region Resolve ModuleType
        DockPanel GetPanel(ModuleType peekModuleType) {
            var id = ViewModel.GetModuleID(peekModuleType);
            return dockManager.Panels.Concat(dockManager.HiddenPanels)
                .FirstOrDefault(p => p.ID == id);
        }
        Control GetModule(ModuleType moduleType) {
            Control moduleControl = ViewModel.GetModule(moduleType) as Control;
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel);
            return moduleControl;
        }
        Control GetNavPaneModule(ModuleType navPaneModuleType) {
            Control moduleControl = ViewModel.GetModule(navPaneModuleType, ViewModel.SelectedModuleViewModel) as Control;
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel);
            return moduleControl;
        }
        Control GetReportModule(ModuleType moduleType) {
            Control moduleControl = ViewModel.GetModule(moduleType) as Control;
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel.SelectedModuleViewModel, ViewModel.ReportParameter);
            return moduleControl;
        }
        #endregion
        #region ISupportViewModel
        object ISupportViewModel.ViewModel { get { return ViewModel; } }
        void ISupportViewModel.ParentViewModelAttached() { }
        #endregion
        #region Notifications
        Timer notificationsTimer;
        DevExpress.XtraBars.Alerter.AlertControl alertControl;
        void InitNotifications() {
            if(CanUseToastNotifications()) {
                notificationManager.ApplicationId = AppHelper.ApplicationID;
                notificationManager.TryCreateApplicationShortcut();
                notificationManager.Activated += notificationsManager_Activated;
            }
            else {
                alertControl = new XtraBars.Alerter.AlertControl(components);
                alertControl.AllowHtmlText = true;
                alertControl.FormLocation = XtraBars.Alerter.AlertFormLocation.TopRight;
                alertControl.ShowPinButton = false;
                alertControl.AlertClick += alertControl_AlertClick;
            }
            EnsureNotificationsTimer();
        }
        void EnsureNotificationsTimer() {
            if(notificationsTimer == null) {
                notificationsTimer = new Timer(components);
                notificationsTimer.Interval = 60000;
                notificationsTimer.Tick += notificationsTimer_Tick;
            }
            notificationsTimer.Start();
        }
        void DestroyNotificationsTimer() {
            if(notificationsTimer != null) {
                notificationsTimer.Stop();
                notificationsTimer.Tick -= notificationsTimer_Tick;
                notificationsTimer.Dispose();
            }
            notificationsTimer = null;
        }
        int notificationsCount;
        void notificationsTimer_Tick(object sender, EventArgs e) {
            if(notificationManager.IsDisposing) {
                DestroyNotificationsTimer();
                return;
            }
            if(notificationsCount < notificationManager.Notifications.Count) {
                notificationsTimer.Interval = 120000;
                ShowNotification(notificationsCount++);
            }
            else DestroyNotificationsTimer();
        }
        void alertControl_AlertClick(object sender, XtraBars.Alerter.AlertClickEventArgs e) {
            object notificationID = e.Info.Tag;
            e.AlertForm.Close();
            OnNotificationClick(notificationID);
        }
        void notificationsManager_Activated(object sender, XtraBars.ToastNotifications.ToastNotificationEventArgs e) {
            OnNotificationClick(e.NotificationID);
        }
        bool CanUseToastNotifications() {
            return DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager.AreToastNotificationsSupported;
        }
        void ShowNotification(int index) {
            var notification = notificationManager.Notifications[index];
            if(CanUseToastNotifications())
                notificationManager.ShowNotification(notification);
            else {
                var alertInfo = new XtraBars.Alerter.AlertInfo(
                    caption: "<b>" + notification.Header + "</b>",
                    text: notification.Body + " " + notification.Body2,
                    image: AppHelper.AppImage);
                alertInfo.Tag = notification.ID;
                alertControl.Show(this, alertInfo);
            }
        }
        void OnNotificationClick(object notificationID) {
            var backstageViewForm = backstageViewControl.FindForm();
            if(backstageViewForm != null && backstageViewForm != this) {
                backstageViewForm.Hide();
                ribbonControl.HideApplicationButtonContentControl();
            }
            if(notificationID == notificationManager.Notifications[0].ID) {
                ViewModel.SelectedModuleType = ModuleType.Orders;
            }
            if(notificationID == notificationManager.Notifications[1].ID) {
                ISupportMap supportMap = ViewModel.SelectedModuleViewModel as ISupportMap;
                if(supportMap != null && supportMap.CanShowMap())
                    supportMap.ShowMap();
            }
            if(notificationID == notificationManager.Notifications[2].ID) {
                ViewModel.SelectedModuleType = ModuleType.Products;
            }
            if(notificationID == notificationManager.Notifications[3].ID) {
                if(!(ViewModel.SelectedModuleViewModel is ISupportAnalysis))
                    ViewModel.SelectedModuleType = ModuleType.Customers;
                ISupportAnalysis supportAnalysis = ViewModel.SelectedModuleViewModel as ISupportAnalysis;
                if(supportAnalysis != null)
                    supportAnalysis.ShowAnalysis();
            }
        }
        #endregion Notifications
        #region TaskBar
        JumpListItemTask taskNewEmployee, taskSalesMap, taskOpportunities;
        void InitTaskBarCommands() {
            TaskbarAssistant.Default.BeginUpdate();
            taskNewEmployee = CreateJumpListTask("New Employee", "Employee.ico");
            taskNewEmployee.Click += taskNewEmployee_Click;
            taskSalesMap = CreateJumpListTask("Sales Map", "Map.ico");
            taskSalesMap.Click += taskSalesMap_Click;
            taskOpportunities = CreateJumpListTask("Opportunities", "Opportunities.ico");
            taskOpportunities.BindCommand((m) => ViewModel.SelectModule(m), ViewModel, () => ModuleType.Quotes);
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskNewEmployee);
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskSalesMap);
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskOpportunities);
            TaskbarAssistant.Default.EndUpdate();
        }
        void taskNewEmployee_Click(object sender, EventArgs e) {
            ViewModel.SelectedModuleType = ModuleType.Employees;
            var collection = ViewModel.SelectedModuleViewModel as EmployeeCollectionViewModel;
            if(collection != null)
                collection.New();
        }
        void paletteSelectorBBI_ItemClick(object sender, ItemClickEventArgs e) {
            using(SvgSkinPaletteSelector form = new SvgSkinPaletteSelector(this))
                form.ShowDialog();
        }
        void taskSalesMap_Click(object sender, EventArgs e) {
            ViewModel.SelectedModuleType = ModuleType.Products;
            var collection = ViewModel.SelectedModuleViewModel as ProductCollectionViewModel;
            if(collection != null)
                collection.ShowMap();
        }
        
        JumpListItemTask CreateJumpListTask(string caption, string iconName) {
            JumpListItemTask task = new JumpListItemTask(caption);
            task.IconPath = TaskbarHelper.GetIconPath(iconName);
            task.IconIndex = 0;
            return task;
        }
        #endregion TaskBar
#if NET
        #region AI Tools
        [Description("Navigates to module. Always use this tool to navigate to the corresponding module before processing any request.")]
        public string NavigateToModule(
            [Description("Module name to be selected. Avaiable module names: Employees, Customers, Products, Orders.")]
            string moduleName) {
            if(!Enum.TryParse(moduleName, out ModuleType myStatus))
                throw new Exception("Invalid module name.");
            ViewModel.SelectModule(myStatus);
            return "Module " + moduleName + " selected.";
        }
        [Description("Changes the application theme.")]
        public string ChangeTheme(
            [Description("The theme name to be applied. Available options are 'light' and 'dark'.")]
            string themeName) {
            switch(themeName.ToLowerInvariant()) {
                case "light":
                    LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI.Default);
                    break;
                case "dark":
                    LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI.Darkness);
                    break;
                default:
                    throw new Exception("Invalid theme name. Available options are 'light' and 'dark'.");
            }
            Invalidate();
            return $"Theme changed to {themeName}.";
        }
        #endregion
#endif
    }
    public class OutlookInspiredAppWin { }
}
