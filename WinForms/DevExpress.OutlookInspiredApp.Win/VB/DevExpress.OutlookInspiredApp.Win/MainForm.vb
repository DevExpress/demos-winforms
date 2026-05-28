Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Customization
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.DPI
Imports DevExpress.Utils.Taskbar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon

#If NET
using System.ComponentModel;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Tools;
#End If
Namespace DevExpress.DevAV

    Public Partial Class MainForm
        Inherits RibbonForm
        Implements IMainModule, ISupportViewModel

#If NET
        public const string ToolsChatResponseProviderServiceKey = "ToolsChatResponseProviderServiceKey";
        const string SystemMessage =
@"You are an assistant integrated into an application. Your role is to perform all user-requested UI operations exclusively through the provided tools.
The application consists of modules such as Employees, Customers, Products, and Orders, each containing a grid with relevant data. Tools used to interact with the application are module-scoped, meaning they appear only after navigating to the corresponding module.

Rules:
1. Always use tools to interact with the UI. Do not simulate actions or produce imagined results.
2. If the user’s request refers to any module’s data or operations, you must always identify the target module and call NavigateToModule for that module first, even if the required tool is not currently visible.
3. If a tool requires a tool-target identifier, obtain it only by calling the GetToolTargets tool. Never invent, guess, or construct identifiers; always use one returned by GetToolTargets.
4. Before performing operations on grid data (filtering, adding, editing records, etc.), always switch to the corresponding module first using NavigateToModule.";
#End If
        Public Sub New()
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, Me)
            AppHelper.MainForm = Me
            StartUpProcess.OnStart("When Only the Best Will Do")
            InitializeComponent()
            StartUpProcess.OnRunning("Initializing...")
            IconOptions.SvgImage = AppIcon
            mvvmContext.ViewModelConstructorParameter = Me
            AddHandler ViewModelProp.ModuleAdded, AddressOf viewModel_ModuleAdded
            AddHandler ViewModelProp.ModuleRemoved, AddressOf viewModel_ModuleRemoved
            AddHandler ViewModelProp.SelectedModuleTypeChanged, AddressOf viewModel_SelectedModuleTypeChanged
            AddHandler ViewModelProp.Print, AddressOf viewModel_Print
            AddHandler ViewModelProp.IsReadingModeChanged, AddressOf viewModel_IsReadingModeChanged
            ribbonControl.ApplicationButtonDropDownControl = Nothing
            ribbonControl.SelectedPage = ribbonControl.Pages(1)
            AddHandler ribbonControl.SelectedPageChanging, AddressOf RibbonControl_SelectedPageChanging
            AddHandler ribbonControl.ApplicationButtonClick, AddressOf RibbonControl_ApplicationButtonClick
            AddHandler backstageViewControl.Hidden, AddressOf BackstageViewControl_Hidden
            AddHandler ribbonControl.MinimizedChanged, AddressOf Ribbon_MinimizedChanged
            ribbonControl.Manager.HideBarsWhenMerging = False
            ribbonStatusBar1.HideWhenMerging = DefaultBoolean.False
            ribbonControl.ForceInitialize()
            Dim tmp_ZoomLevelManager = New ZoomLevelManager(beZoomLevel, bbiZoomDialog, ViewModelProp)
            AddHandler backstageViewControl.SelectedTabChanged, AddressOf backstageViewControl_SelectedTabChanged
            AddHandler backstageViewControl.Shown, AddressOf backstageViewControl_Shown
            AddHandler backstageViewControl.Hidden, AddressOf backstageViewControl_HiddenMethod
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = GetControlColor(LookAndFeel)
            backstageViewControl.BackstageViewShowRibbonItems = BackstageViewShowRibbonItems.None
            Ribbon.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden
            IconOptions.ShowIcon = False
            BindCommands()
            BindFiltersVisibility()
            InitNotifications()
            InitTaskBarCommands()
            InitRibbonWindowModeAndAccentColor()
            InitChatPanelControl()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            bciShowChatControl.Checked = True
            SwapFluentIcons(Me)
        End Sub

        Private Sub InitChatPanelControl()
#If NET
            var control = CreateChatControl();
#Else
            Dim control = CreateLabelControl()
#End If
            Controls.Add(control)
            chatControlPanel.Controls.Add(control)
        End Sub

#If NET
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
#Else
        Private Function CreateLabelControl() As Control
            Dim label = New XtraEditors.LabelControl()
            label.Text = "This feature is only supported in .NET Core. Please refer to the .NET Core version of the demo."
            label.AutoSizeMode = XtraEditors.LabelAutoSizeMode.Vertical
            label.Appearance.TextOptions.HAlignment = HorzAlignment.Center
            Const padding As Integer = 10
            AddHandler chatControlPanel.Resize, Sub(s, e)
                label.Width = chatControlPanel.Width - padding * 2
                label.Location = New Point(padding, (chatControlPanel.Height - label.Height) \ 2)
            End Sub
            Return label
        End Function

#End If
        Private Sub BackstageViewControl_Hidden(ByVal sender As Object, ByVal e As EventArgs)
            ribbonControl.ApplicationButtonDropDownControl = Nothing
        End Sub

        Private Sub RibbonControl_SelectedPageChanging(ByVal sender As Object, ByVal e As RibbonPageChangingEventArgs)
            If Equals(e.Page.Text, "File") Then
                ribbonControl.ApplicationButtonDropDownControl = backstageViewControl
                e.Cancel = True
                ribbonControl.ShowApplicationButtonContentControl()
            End If
        End Sub

        Private Sub RibbonControl_ApplicationButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim filtersHidden As Boolean = ViewModelProp.FiltersVisibility = CollectionViewFiltersVisibility.Hidden
            ViewModelProp.FiltersVisibility = If(filtersHidden, CollectionViewFiltersVisibility.Visible, CollectionViewFiltersVisibility.Hidden)
        End Sub

        Public ReadOnly Property ViewModelProp As MainViewModel
            Get
                Return mvvmContext.GetViewModel(Of MainViewModel)()
            End Get
        End Property

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = GetControlColor(LookAndFeel)
        End Sub

        Protected Overrides ReadOnly Property ShowMode As XtraEditors.FormShowMode
            Get
                Return XtraEditors.FormShowMode.AfterInitialization
            End Get
        End Property

#If NET
        AIToolsContext globalContext;
#End If
        Private loading As Integer = 0

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            loading += 1
            Try
                ViewModelProp.SelectedModuleType = ModuleType.Employees
                Dim types = New ModuleType() {ModuleType.Employees, ModuleType.Customers, ModuleType.Products, ModuleType.Orders, ModuleType.Quotes}
                RegisterNavigationMenuItems(barNavigationItem, types)
                RegisterAccordionControlElements(accordionControl1, types, ViewModelProp.SelectedModuleType)
#If Not NET
#End If
                bciShowChatControl.Checked = False
            Finally
                StartUpProcess.OnRunning("Successfully loaded.")
                loading -= 1
            End Try

            If MainFormHelper.TakeScreens Then
                WindowState = FormWindowState.Normal
                Call MainFormHelper.TakeAllScreens(New Func(Of Integer, String)(AddressOf TakeModule), takeModuleTypes.Length, Me, modulesContainer, New Func(Of Integer, Integer)(AddressOf TakeModuleInterval))
            End If
#If NET
            globalContext = new AIToolsContextBuilder()
                .WithToolMethods(NavigateToModule, ChangeTheme)
                .Build();
            AIExtensionsContainerDesktop.Default.AddAIToolsContext(globalContext);
#End If
        End Sub

        Private ReadOnly Shared takeModuleTypes As ModuleType() = New ModuleType() {ModuleType.Employees, ModuleType.Customers, ModuleType.Products, ModuleType.Orders, ModuleType.Quotes, ModuleType.ProductAnalysis}

        Private Function TakeModule(ByVal num As Integer) As String
            Dim info As ModuleType = takeModuleTypes(num)
            ViewModelProp.SelectedModuleType = info
            modulesContainer.Focus()
            Return $"{info}"
        End Function

        Private Function TakeModuleInterval(ByVal num As Integer) As Integer
            Dim x As Integer = 1
            If num = 2 Then x = 2
            Return 1000 * x
        End Function

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            StartUpProcess.OnComplete()
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            If loading > 0 Then e.Cancel = True
            MyBase.OnFormClosing(e)
        End Sub

        Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
            RemoveHandler ViewModelProp.SelectedModuleTypeChanged, AddressOf viewModel_SelectedModuleTypeChanged
            RemoveHandler ViewModelProp.ModuleRemoved, AddressOf viewModel_ModuleRemoved
            RemoveHandler ViewModelProp.ModuleAdded, AddressOf viewModel_ModuleAdded
            ViewModelProp.SelectedModuleType = ModuleType.Unknown
            MyBase.OnFormClosed(e)
        End Sub

        Private Sub BindCommands()
            mvvmContext.BindCommand(Of MainViewModel)(biGetStarted, Sub(x) x.GetStarted())
            mvvmContext.BindCommand(Of MainViewModel)(biGetSupport, Sub(x) x.GetSupport())
            mvvmContext.BindCommand(Of MainViewModel)(biBuyNow, Sub(x) x.BuyNow())
            mvvmContext.BindCommand(Of MainViewModel)(biAbout, Sub(x) x.About())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewGetStarted, Sub(x) x.GetStarted())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewGetSupport, Sub(x) x.GetSupport())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewBuyNow, Sub(x) x.BuyNow())
            mvvmContext.BindCommand(Of MainViewModel)(bbiNormal, Sub(x) x.TurnOffReadingMode())
            mvvmContext.BindCommand(Of MainViewModel)(bbiReading, Sub(x) x.TurnOnReadingMode())
        End Sub

        Private Sub viewModel_ModuleAdded(ByVal sender As Object, ByVal e As EventArgs)
            Dim moduleControl = TryCast(sender, Control)
            If Not DpiAwarenessHelper.Default.IsPerMonitor() Then modulesContainer.SuspendLayout()
            moduleControl.Dock = DockStyle.Fill
            moduleControl.Parent = modulesContainer
            If Not DpiAwarenessHelper.Default.IsPerMonitor() Then modulesContainer.ResumeLayout()
            Text = String.Format("{1} - {0}", ViewModelProp.GetModuleCaption(ViewModelProp.SelectedModuleType), "DevAV")
            Dim ribbonModuleControl As IRibbonModule = TryCast(moduleControl, IRibbonModule)
            If ribbonModuleControl IsNot Nothing Then
                Ribbon.MergeRibbon(ribbonModuleControl.Ribbon)
                Ribbon.StatusBar.MergeStatusBar(ribbonModuleControl.Ribbon.StatusBar)
            Else
                Ribbon.UnMergeRibbon()
                Ribbon.StatusBar.UnMergeStatusBar()
            End If
        End Sub

        Private Sub viewModel_ModuleRemoved(ByVal sender As Object, ByVal e As EventArgs)
            Dim moduleControl = TryCast(sender, Control)
            HideCustomization(moduleControl)
            moduleControl.Parent = Nothing
        End Sub

        Private Sub viewModel_SelectedModuleTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ViewModelProp.SelectedNavPaneModuleType <> ModuleType.Unknown Then
                accordionControl1.SelectedElement = accordionControl1.Elements.FirstOrDefault(Function(g) Equals(g.Tag, ViewModelProp.SelectedModuleType))
                TryCast(GetModule(ViewModelProp.SelectedModuleType), ISupportFiltersVisibilityChangedEvent)?.RaiseFiltersVisibilityChanged(sender, e)
            End If

            UpdateCompactLayout(Not ribbonControl.Minimized)
        End Sub

        Private prevVisibility As CollectionViewFiltersVisibility = CollectionViewFiltersVisibility.Visible

        Private Sub viewModel_IsReadingModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ViewModelProp.FiltersVisibility <> CollectionViewFiltersVisibility.Hidden Then prevVisibility = ViewModelProp.FiltersVisibility
            If ViewModelProp.IsReadingMode Then
                ViewModelProp.FiltersVisibility = CollectionViewFiltersVisibility.Hidden
            Else
                ViewModelProp.FiltersVisibility = prevVisibility
            End If
        End Sub

        Private Sub Ribbon_MinimizedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCompactLayout(Not ribbonControl.Minimized)
        End Sub

        Private Sub UpdateCompactLayout(ByVal compact As Boolean)
            If ViewModelProp.SelectedNavPaneModuleType <> ModuleType.Unknown Then UpdateCompactLayout(TryCast(GetNavPaneModule(ViewModelProp.SelectedNavPaneModuleType), ISupportCompactLayout), compact)
            If ViewModelProp.SelectedNavPaneHeaderModuleType <> ModuleType.Unknown Then UpdateCompactLayout(TryCast(GetNavPaneModule(ViewModelProp.SelectedNavPaneHeaderModuleType), ISupportCompactLayout), compact)
        End Sub

        Private Sub UpdateCompactLayout(ByVal [module] As ISupportCompactLayout, ByVal compact As Boolean)
            If [module] IsNot Nothing Then [module].Compact = compact
        End Sub

        Private Sub backstageViewControl_SelectedTabChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            If e.Item Is tabBackstageViewExport Then AddBackStageViewModule(ViewModelProp.SelectedExportModuleType, tabBackstageViewExport)
            If e.Item Is tabBackstageViewPrint Then AddBackStageViewModule(ViewModelProp.SelectedPrintModuleType, tabBackstageViewPrint)
        End Sub

        Private Sub viewModel_Print(ByVal sender As Object, ByVal e As PrintEventArgs)
            ribbonControl.ApplicationButtonDropDownControl = backstageViewControl
            backstageViewControl.SelectedTab = tabBackstageViewPrint
            ribbonControl.ShowApplicationButtonContentControl()
        End Sub

        Private Sub backstageViewControl_Shown(ByVal sender As Object, ByVal e As EventArgs)
            tabBackstageViewExport.Enabled = ViewModelProp.SelectedExportModuleType <> ModuleType.QuotesExport
            tabBackstageViewPrint.Enabled = ViewModelProp.SelectedPrintModuleType <> ModuleType.QuotesPrint
        End Sub

        Private Sub backstageViewControl_HiddenMethod(ByVal sender As Object, ByVal e As EventArgs)
            If backstageViewControl.SelectedTab IsNot tabBackstageViewAbout Then ViewModelProp.AfterReportHidden()
            backstageViewControl.SelectedTab = tabBackstageViewAbout
            ReleaseBackStageViewModule(tabBackstageViewExport)
            ReleaseBackStageViewModule(tabBackstageViewPrint)
        End Sub

        Private Sub AddBackStageViewModule(ByVal moduleType As ModuleType, ByVal tabItem As BackstageViewTabItem)
            ViewModelProp.BeforeReportShown(moduleType)
            tabItem.ContentControl.SuspendLayout()
            tabItem.ContentControl.Controls.Clear()
            Dim moduleControl = GetReportModule(moduleType)
            ViewModelProp.AfterReportShown(moduleType)
            moduleControl.Dock = DockStyle.Fill
            moduleControl.Parent = tabItem.ContentControl
            tabItem.ContentControl.ResumeLayout()
        End Sub

        Private Sub ReleaseBackStageViewModule(ByVal tabItem As BackstageViewTabItem)
            tabItem.ContentControl.SuspendLayout()
            Dim controls As Control() = New Control(tabItem.ContentControl.Controls.Count - 1) {}
            tabItem.ContentControl.Controls.CopyTo(controls, 0)
            tabItem.ContentControl.Controls.Clear()
            For i As Integer = 0 To controls.Length - 1
                controls(i).Dispose()
            Next

            tabItem.ContentControl.ResumeLayout(False)
        End Sub

        Private Sub InitRibbonWindowModeAndAccentColor()
            Call SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode)
            bciTrackWindowsAppMode.SuperTip = New SuperToolTip()
            bciTrackWindowsAppMode.SuperTip.Items.Add("This setting is available for WXI, Basic, and Bezier skins.")
            bciTrackWindowsAppMode.SuperTip.Items(0).Appearance.FontStyleDelta = FontStyle.Bold
            Call SkinHelper.InitResetToOriginalPalette(bciOriginalPalette)
            Call SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor)
            Call SkinHelper.InitCustomAccentColor(Ribbon.Manager, bbiCustomColors)
            bbiCustomColors.SuperTip = New SuperToolTip()
            bbiCustomColors.SuperTip.Items.Add("Custom Accent Color.")
            bbiCustomColors.SuperTip.Items(0).Appearance.FontStyleDelta = FontStyle.Bold
            Call SkinHelper.InitCustomAccentColor2(Ribbon.Manager, bbiCustomColors2)
            bbiCustomColors2.SuperTip = New SuperToolTip()
            bbiCustomColors2.SuperTip.Items.Add("Custom Accent Color 2.")
            bbiCustomColors2.SuperTip.Items(0).Appearance.FontStyleDelta = FontStyle.Bold
        End Sub

        Private Sub bciShowChatControl_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            chatControlPanel.Visible = bciShowChatControl.Checked
        End Sub

#Region "Filters Visibility"
        Private Sub BindFiltersVisibility()
            AddHandler ViewModelProp.ViewFiltersVisibilityChanged, AddressOf ViewModel_ViewFiltersVisibilityChanged
            bmiFolderNormal.BindCommand(Sub() ViewModelProp.ShowFilters(), ViewModelProp)
            bmiFolderMinimized.BindCommand(Sub() ViewModelProp.MinimizeFilters(), ViewModelProp)
            bmiFolderOff.BindCommand(Sub() ViewModelProp.HideFilters(), ViewModelProp)
        End Sub

        Private Sub ViewModel_ViewFiltersVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim applicationTip As SuperToolTip = ribbonControl.ApplicationButtonSuperTip
            Select Case ViewModelProp.FiltersVisibility
                Case CollectionViewFiltersVisibility.Visible
                    CType(applicationTip.Items(0), ToolTipTitleItem).Text = "Hide navigation pane"
                    ViewModelProp.IsReadingMode = False
                Case CollectionViewFiltersVisibility.Minimized
                    ViewModelProp.IsReadingMode = False
                Case CollectionViewFiltersVisibility.Hidden
                    CType(applicationTip.Items(0), ToolTipTitleItem).Text = "Show navigation pane"
                    ViewModelProp.IsReadingMode = True
            End Select

            TryCast(GetModule(ViewModelProp.SelectedModuleType), ISupportFiltersVisibilityChangedEvent)?.RaiseFiltersVisibilityChanged(sender, e)
        End Sub

#End Region
#Region "Services"
        Private Function IsDockedCore(ByVal peekModuleType As ModuleType) As Boolean
            Dim panel As DockPanel = GetPanel(peekModuleType)
            Return panel IsNot Nothing AndAlso panel.Visibility = DockVisibility.Visible
        End Function

        Private Function IsDocked(ByVal moduleType As ModuleType) As Boolean Implements IPeekModulesHost.IsDocked
            Return IsDockedCore(moduleType)
        End Function

        Private Sub DockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHost.DockModule
            Dim panel As DockPanel = GetPanel(moduleType)
            If panel IsNot Nothing Then panel.Restore()
        End Sub

        Private Sub UndockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHost.UndockModule
            Dim panel As DockPanel = GetPanel(moduleType)
            If panel IsNot Nothing Then panel.Close()
        End Sub

        Private Sub ShowPeek(ByVal moduleType As ModuleType) Implements IPeekModulesHost.ShowPeek
        End Sub

        Private Sub StartTransition(ByVal forward As Boolean, ByVal waitParameter As Object) Implements ISupportTransitions.StartTransition
            Dim transition = transitionManager.Transitions(modulesContainer)
            Dim animator = TryCast(transition.TransitionType, Animation.SlideFadeTransition)
            animator.Parameters.EffectOptions = If(forward, Animation.PushEffectOptions.FromRight, Animation.PushEffectOptions.FromLeft)
            If waitParameter Is Nothing Then
                transition.ShowWaitingIndicator = DefaultBoolean.False
            Else
                transition.ShowWaitingIndicator = DefaultBoolean.True
                transition.WaitingIndicatorProperties.Caption = XtraEditors.EnumDisplayTextHelper.GetDisplayText(waitParameter)
                transition.WaitingIndicatorProperties.Description = "Loading..."
                transition.WaitingIndicatorProperties.ContentMinSize = New System.Drawing.Size(160, 0)
            End If

            transitionManager.StartTransition(modulesContainer)
        End Sub

        Private Sub EndTransition() Implements ISupportTransitions.EndTransition
            transitionManager.EndTransition()
        End Sub

        Private Sub SaveLayoutToStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.SaveLayoutToStream
            dockManager.SaveLayoutToStream(ms)
        End Sub

        Private Sub RestoreLayoutFromStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.RestoreLayoutFromStream
            dockManager.RestoreLayoutFromStream(ms)
        End Sub

#End Region  ' Services
#Region "Navigation Menu"
        Private Sub RegisterNavigationMenuItems(ByVal menuItem As BarLinkContainerItem, ByVal types As ModuleType())
            For i As Integer = 0 To types.Length - 1
                RegisterNavigationMenuItem(menuItem, types(i))
            Next
        End Sub

        Private Sub RegisterNavigationMenuItem(ByVal menuItem As BarLinkContainerItem, ByVal type As ModuleType)
            Dim biModule As BarCheckItem = New BarCheckItem()
            biModule.Caption = ViewModelProp.GetModuleCaption(type)
            biModule.Name = "biModule" & ViewModelProp.GetModuleName(type)
            biModule.ImageUri.Uri = ViewModelProp.GetModuleImageUri(type)
            biModule.ImageOptions.SvgImageSize = New Size(32, 32)
            biModule.AllowGlyphSkinning = DefaultBoolean.True
            biModule.ImageUri.ResourceType = GetType(MainForm)
            biModule.GroupIndex = 1
            biModule.BindCommand(Sub(t) ViewModelProp.SelectModule(t), ViewModelProp, Function() type)
            menuItem.AddItem(biModule)
        End Sub

#End Region  ' Navigation Menu
#Region "Navigation Bar"
        Private Sub RegisterAccordionControlElements(ByVal accordionControl As AccordionControl, ByVal types As ModuleType(), ByVal selectedType As ModuleType)
            accordionControl.Elements.Clear()
            For i As Integer = 0 To types.Length - 1
                Dim element = RegisterAccordionControlElement(accordionControl, types(i))
                If types(i) = selectedType Then accordionControl.SelectedElement = element
            Next
        End Sub

        Private Function RegisterAccordionControlElement(ByVal accordionControl As AccordionControl, ByVal type As ModuleType) As AccordionControlElement
            Dim element As AccordionControlElement = New AccordionControlElement()
            element.Tag = type
            element.Name = "accordionElement" & ViewModelProp.GetModuleName(type)
            element.Text = ViewModelProp.GetModuleCaption(type)
            element.SuperTip = New SuperToolTip()
            element.SuperTip.Items.AddTitle(element.Text)
            element.ImageUri = ViewModelProp.GetModuleImageUri(type)
            element.ImageUri.ResourceType = GetType(MainForm)
            element.ImageOptions.SvgImageSize = New Size(32, 32)
            element.Style = ElementStyle.Item
            AddHandler element.Click, Sub(s, e) ViewModelProp.SelectModule(type)
            accordionControl.Elements.Add(element)
            Return element
        End Function

#End Region  ' Navigation Bar
#Region "Peek Panels"
        Private Class PeekPanelsRegistrator

            Private viewModel As MainViewModel

            Public Sub New(ByVal viewModel As MainViewModel)
                Me.viewModel = viewModel
            End Sub

            Public Sub RegisterPeekPanels(ByVal dockManager As DockManager, ByVal types As ModuleType())
                AddHandler dockManager.ClosedPanel, AddressOf dockManager_ClosedPanel
                AddHandler dockManager.VisibilityChanged, AddressOf dockManager_VisibilityChanged
                AddHandler dockManager.StartDocking, AddressOf dockManager_StartDocking
                dockManager.BeginInit()
                RegisterPeekPanelsCore(dockManager, Array.ConvertAll(types, New Converter(Of ModuleType, ModuleType)(AddressOf viewModel.GetPeekModuleType)))
                dockManager.EndInit()
            End Sub

            Private Sub RegisterPeekPanelsCore(ByVal dockManager As DockManager, ByVal types As ModuleType())
                For i As Integer = 0 To types.Length - 1
                    RegisterPeekPanel(dockManager, types(i))
                Next
            End Sub

            Private Sub RegisterPeekPanel(ByVal dockManager As DockManager, ByVal type As ModuleType)
                Dim panel = New DockPanel()
                panel.ID = viewModel.GetModuleID(type)
                Call panels.Add(panel.ID, type)
                panel.Name = "peekPanel" & viewModel.GetModuleName(type)
                panel.Options.AllowDockBottom = False
                panel.Options.AllowDockLeft = False
                panel.Options.AllowDockTop = False
                panel.Options.AllowFloating = False
                panel.Text = viewModel.GetModuleCaption(type)
                panel.Visibility = DockVisibility.Hidden
                panel.SavedDock = DockingStyle.Right
                panel.OriginalSize = New System.Drawing.Size(200, 200)
                If dockManager.HiddenPanels.Count > 0 Then
                    panel.SavedParent = dockManager.HiddenPanels(0)
                    panel.Dock = DockingStyle.Fill
                    panel.SavedDock = DockingStyle.Fill
                    panel.SavedIndex = dockManager.HiddenPanels.Count - 1
                End If

                Dim container = New ControlContainer()
                container.Name = panel.Name & "_ControlContainer"
                panel.Controls.Add(container)
                panel.Register(dockManager)
                dockManager.HiddenPanels.AddRange(New DockPanel() {panel})
            End Sub

            Private Sub dockManager_StartDocking(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
                e.Cancel = True
            End Sub

            Private Sub dockManager_VisibilityChanged(ByVal sender As Object, ByVal e As VisibilityChangedEventArgs)
                If e.Visibility = DockVisibility.Visible AndAlso panels.ContainsKey(e.Panel.ID) Then
                    Dim [module] As Control = GetPeekModuleControl(e.Panel)
                    EnsureModuleViewModel([module], viewModel)
                    [module].Dock = DockStyle.Fill
                    e.Panel.ControlContainer.Controls.Add([module])
                End If
            End Sub

            Private Sub dockManager_ClosedPanel(ByVal sender As Object, ByVal e As DockPanelEventArgs)
                Dim [module] As Control = GetPeekModuleControl(e.Panel)
                e.Panel.ControlContainer.Controls.Remove([module])
            End Sub

            Private Shared panels As IDictionary(Of Guid, ModuleType) = New Dictionary(Of Guid, ModuleType)()

            Private Function GetPeekModuleControl(ByVal panel As DockPanel) As Control
                Return TryCast(viewModel.GetModule(panels(panel.ID)), Control)
            End Function
        End Class

#End Region  ' Peek Panels
#Region "Resolve ModuleType"
        Private Function GetPanel(ByVal peekModuleType As ModuleType) As DockPanel
            Dim id = ViewModelProp.GetModuleID(peekModuleType)
            Return dockManager.Panels.Concat(dockManager.HiddenPanels).FirstOrDefault(Function(p) p.ID = id)
        End Function

        Private Function GetModule(ByVal moduleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModelProp.GetModule(moduleType), Control)
            EnsureModuleViewModel(moduleControl, ViewModelProp)
            Return moduleControl
        End Function

        Private Function GetNavPaneModule(ByVal navPaneModuleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModelProp.GetModule(navPaneModuleType, ViewModelProp.SelectedModuleViewModel), Control)
            EnsureModuleViewModel(moduleControl, ViewModelProp)
            Return moduleControl
        End Function

        Private Function GetReportModule(ByVal moduleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModelProp.GetModule(moduleType), Control)
            EnsureModuleViewModel(moduleControl, ViewModelProp.SelectedModuleViewModel, ViewModelProp.ReportParameter)
            Return moduleControl
        End Function

#End Region
#Region "ISupportViewModel"
        Private ReadOnly Property ViewModel As Object Implements ISupportViewModel.ViewModel
            Get
                Return ViewModelProp
            End Get
        End Property

        Private Sub ParentViewModelAttached() Implements ISupportViewModel.ParentViewModelAttached
        End Sub

#End Region
#Region "Notifications"
        Private notificationsTimer As Timer

        Private alertControl As Alerter.AlertControl

        Private Sub InitNotifications()
            If CanUseToastNotifications() Then
                notificationManager.ApplicationId = ApplicationID
                notificationManager.TryCreateApplicationShortcut()
                AddHandler notificationManager.Activated, AddressOf notificationsManager_Activated
            Else
                alertControl = New Alerter.AlertControl(components)
                alertControl.AllowHtmlText = True
                alertControl.FormLocation = Alerter.AlertFormLocation.TopRight
                alertControl.ShowPinButton = False
                AddHandler alertControl.AlertClick, AddressOf alertControl_AlertClick
            End If

            EnsureNotificationsTimer()
        End Sub

        Private Sub EnsureNotificationsTimer()
            If notificationsTimer Is Nothing Then
                notificationsTimer = New Timer(components)
                notificationsTimer.Interval = 60000
                AddHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
            End If

            notificationsTimer.Start()
        End Sub

        Private Sub DestroyNotificationsTimer()
            If notificationsTimer IsNot Nothing Then
                notificationsTimer.Stop()
                RemoveHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
                notificationsTimer.Dispose()
            End If

            notificationsTimer = Nothing
        End Sub

        Private notificationsCount As Integer

        Private Sub notificationsTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If notificationManager.IsDisposing Then
                DestroyNotificationsTimer()
                Return
            End If

            If notificationsCount < notificationManager.Notifications.Count Then
                notificationsTimer.Interval = 120000
                ShowNotification(Math.Min(Threading.Interlocked.Increment(notificationsCount), notificationsCount - 1))
            Else
                DestroyNotificationsTimer()
            End If
        End Sub

        Private Sub alertControl_AlertClick(ByVal sender As Object, ByVal e As Alerter.AlertClickEventArgs)
            Dim notificationID As Object = e.Info.Tag
            e.AlertForm.Close()
            OnNotificationClick(notificationID)
        End Sub

        Private Sub notificationsManager_Activated(ByVal sender As Object, ByVal e As ToastNotifications.ToastNotificationEventArgs)
            OnNotificationClick(e.NotificationID)
        End Sub

        Private Function CanUseToastNotifications() As Boolean
            Return ToastNotifications.ToastNotificationsManager.AreToastNotificationsSupported
        End Function

        Private Sub ShowNotification(ByVal index As Integer)
            Dim notification = notificationManager.Notifications(index)
            If CanUseToastNotifications() Then
                notificationManager.ShowNotification(notification)
            Else
                Dim alertInfo = New Alerter.AlertInfo(caption:="<b>" & notification.Header & "</b>", text:=notification.Body & " " & notification.Body2, image:=AppImage)
                alertInfo.Tag = notification.ID
                alertControl.Show(Me, alertInfo)
            End If
        End Sub

        Private Sub OnNotificationClick(ByVal notificationID As Object)
            Dim backstageViewForm = backstageViewControl.FindForm()
            If backstageViewForm IsNot Nothing AndAlso backstageViewForm IsNot Me Then
                backstageViewForm.Hide()
                ribbonControl.HideApplicationButtonContentControl()
            End If

            If notificationID Is notificationManager.Notifications(0).ID Then
                ViewModelProp.SelectedModuleType = ModuleType.Orders
            End If

            If notificationID Is notificationManager.Notifications(1).ID Then
                Dim supportMap As ISupportMap = TryCast(ViewModelProp.SelectedModuleViewModel, ISupportMap)
                If supportMap IsNot Nothing AndAlso supportMap.CanShowMap() Then supportMap.ShowMap()
            End If

            If notificationID Is notificationManager.Notifications(2).ID Then
                ViewModelProp.SelectedModuleType = ModuleType.Products
            End If

            If notificationID Is notificationManager.Notifications(3).ID Then
                If Not(TypeOf ViewModelProp.SelectedModuleViewModel Is ISupportAnalysis) Then ViewModelProp.SelectedModuleType = ModuleType.Customers
                Dim supportAnalysis As ISupportAnalysis = TryCast(ViewModelProp.SelectedModuleViewModel, ISupportAnalysis)
                If supportAnalysis IsNot Nothing Then supportAnalysis.ShowAnalysis()
            End If
        End Sub

#End Region  ' Notifications
#Region "TaskBar"
        Private taskNewEmployee, taskSalesMap, taskOpportunities As JumpListItemTask

        Private Sub InitTaskBarCommands()
            Call TaskbarAssistant.Default.BeginUpdate()
            taskNewEmployee = CreateJumpListTask("New Employee", "Employee.ico")
            AddHandler taskNewEmployee.Click, AddressOf taskNewEmployee_Click
            taskSalesMap = CreateJumpListTask("Sales Map", "Map.ico")
            AddHandler taskSalesMap.Click, AddressOf taskSalesMap_Click
            taskOpportunities = CreateJumpListTask("Opportunities", "Opportunities.ico")
            taskOpportunities.BindCommand(Sub(m) ViewModelProp.SelectModule(m), ViewModelProp, Function() ModuleType.Quotes)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskNewEmployee)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskSalesMap)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskOpportunities)
            Call TaskbarAssistant.Default.EndUpdate()
        End Sub

        Private Sub taskNewEmployee_Click(ByVal sender As Object, ByVal e As EventArgs)
            ViewModelProp.SelectedModuleType = ModuleType.Employees
            Dim collection = TryCast(ViewModelProp.SelectedModuleViewModel, EmployeeCollectionViewModel)
            If collection IsNot Nothing Then collection.[New]()
        End Sub

        Private Sub paletteSelectorBBI_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Using form As SvgSkinPaletteSelector = New SvgSkinPaletteSelector(Me)
                form.ShowDialog()
            End Using
        End Sub

        Private Sub taskSalesMap_Click(ByVal sender As Object, ByVal e As EventArgs)
            ViewModelProp.SelectedModuleType = ModuleType.Products
            Dim collection = TryCast(ViewModelProp.SelectedModuleViewModel, ProductCollectionViewModel)
            If collection IsNot Nothing Then collection.ShowMap()
        End Sub

        Private Function CreateJumpListTask(ByVal caption As String, ByVal iconName As String) As JumpListItemTask
            Dim task As JumpListItemTask = New JumpListItemTask(caption)
            task.IconPath = TaskbarHelper.GetIconPath(iconName)
            task.IconIndex = 0
            Return task
        End Function
#End Region  ' TaskBar
#If NET
#Region "AI Tools"
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
#End Region
#End If
    End Class

    Public Class OutlookInspiredAppWin
    End Class
End Namespace
