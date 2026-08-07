Imports System
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.DirectXPaint
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.Taskbar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.WindowsMailClient.Win.Modules
Imports DevExpress.WindowsMailClient.Win.Services
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.WindowsMailClient.Win.ViewModels
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.WindowsMailClient.Win

    Public Partial Class MainForm
        Inherits XtraBars.FluentDesignSystem.FluentDesignForm
        Implements IMainModule

        Public Sub New()
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, Me)
            AppProvider.MainForm = Me
            StartUpProcess.OnStart("When Only the Best Will Do")
            InitializeComponent()
            ConfigureDateNavigatorControl()
            StartUpProcess.OnRunning("Initializing...")
            mvvmContext.ViewModelConstructorParameter = Me
            Me.OptionsAdaptiveLayout.AdaptiveLayout = True
            Icon = AppIcon
            AddHandler ViewModel.ModuleAdded, AddressOf ViewModelOnModuleAdded
            AddHandler ViewModel.ModuleRemoved, AddressOf ViewModelOnModuleRemoved
            AddHandler ViewModel.CurrentTagChanged, AddressOf ViewModel_CurrentTagChanged
            BindCommands()
            InitBindings()
        End Sub

        Private Sub ViewModel_CurrentTagChanged(ByVal sender As Object, ByVal e As EventArgs)
            SelectNavigationControlElementByTag(accordionControl, ViewModel.CurrentTag)
            SelectNavigationControlElementByTag(accordionFolders, ViewModel.CurrentTag)
        End Sub

        Private Sub SelectNavigationControlElementByTag(ByVal control As AccordionControl, ByVal tag As Object)
            Dim element = control.GetElements().FirstOrDefault(Function(x) Equals(x.Tag, tag))
            control.SelectElement(element)
        End Sub

        Protected Overrides Sub OnLookAndFeelChangedCore()
            MyBase.OnLookAndFeelChangedCore()
            UpdateCalendarColors()
        End Sub

        Private Sub ConfigureDateNavigatorControl()
            calendarControl1.CalendarView = CalendarView.Fluent
            calendarControl1.AllowAnimatedContentChange = True
            calendarControl1.UseDirectXPaint = DefaultBoolean.True
            calendarControl1.ShowTodayButton = False
            calendarControl1.PerformTodayClick()
            UpdateCalendarColors()
        End Sub

        Private Sub UpdateCalendarColors()
            If DCompositionSettings.IsWindowsSupportsAcrylic Then
                calendarControl1.HighlightHolidays = False
                Dim elem As SkinElement = HamburgerMenuSkins.GetSkin(UserLookAndFeel.Default)(HamburgerMenuSkins.SkinItem)
                If elem Is Nothing Then Return
                calendarControl1.CalendarAppearance.DayCellSpecial.ForeColor = elem.Color.GetForeColor()
                calendarControl1.CalendarAppearance.DayCell.ForeColor = calendarControl1.CalendarAppearance.DayCellSpecial.ForeColor
                calendarControl1.CalendarAppearance.DayCell.Font = New Font("Segoe UI", 9F)
                calendarControl1.CalendarAppearance.DayCellSpecialInactive.Font = calendarControl1.CalendarAppearance.DayCell.Font
                calendarControl1.CalendarAppearance.DayCellInactive.Font = calendarControl1.CalendarAppearance.DayCellSpecialInactive.Font
                calendarControl1.CalendarAppearance.DayCellToday.Font = calendarControl1.CalendarAppearance.DayCellInactive.Font
                calendarControl1.CalendarAppearance.DayCellSelected.Font = calendarControl1.CalendarAppearance.DayCell.Font
                calendarControl1.CalendarAppearance.DayCellSpecialSelected.Font = calendarControl1.CalendarAppearance.DayCellSelected.Font
                calendarControl1.CalendarAppearance.DayCellHighlighted.Font = calendarControl1.CalendarAppearance.DayCellSpecialSelected.Font
                calendarControl1.CalendarAppearance.DayCellSpecialHighlighted.Font = calendarControl1.CalendarAppearance.DayCellHighlighted.Font
                calendarControl1.CalendarAppearance.DayCellSpecialPressed.Font = calendarControl1.CalendarAppearance.DayCell.Font
                calendarControl1.CalendarAppearance.DayCellPressed.Font = calendarControl1.CalendarAppearance.DayCellSpecialPressed.Font
                calendarControl1.CalendarAppearance.HeaderPressed.ForeColor = calendarControl1.CalendarAppearance.DayCell.ForeColor
                calendarControl1.CalendarAppearance.HeaderHighlighted.ForeColor = calendarControl1.CalendarAppearance.HeaderPressed.ForeColor
                calendarControl1.CalendarAppearance.Header.ForeColor = calendarControl1.CalendarAppearance.HeaderHighlighted.ForeColor
                calendarControl1.CalendarAppearance.HeaderPressed.Font = calendarControl1.CalendarAppearance.DayCell.Font
                calendarControl1.CalendarAppearance.HeaderHighlighted.Font = calendarControl1.CalendarAppearance.HeaderPressed.Font
                calendarControl1.CalendarAppearance.Header.Font = calendarControl1.CalendarAppearance.HeaderHighlighted.Font
                calendarControl1.CalendarAppearance.WeekDay.Font = calendarControl1.CalendarAppearance.DayCell.Font
            End If
        End Sub

        Private Sub ViewModelOnModuleRemoved(ByVal sender As Object, ByVal e As EventArgs)
            Dim [module] As Control = TryCast(sender, Control)
            If [module] IsNot Nothing Then
                [module].Parent = Nothing
            End If

            accordionControl.Refresh()
        End Sub

        Private Sub ViewModelOnModuleAdded(ByVal sender As Object, ByVal e As EventArgs)
            Dim [module] As Control = TryCast(sender, Control)
            If [module] IsNot Nothing Then
                ConfigureAddedModule([module])
                [module].Dock = DockStyle.Fill
                [module].Parent = fluentDesignFormContainer
            End If
        End Sub

        Private Sub ConfigureAddedModule(ByVal [module] As Control)
            If TypeOf [module] Is MailModule Then
                CType([module], MailModule).Init()
                accordionControl.OptionsMinimizing.State = AccordionControlState.Minimized
            End If
        End Sub

#Region "MVVM"
        Public ReadOnly Property ViewModel As MainViewModel
            Get
                Return mvvmContext.GetViewModel(Of MainViewModel)()
            End Get
        End Property

        Private Sub BindCommands()
            mvvmContext.BindCommand(Of MainViewModel)(elementPeople, Sub(x) x.StartPeople())
            mvvmContext.BindCommand(Of MainViewModel)(elementFolders, Sub(x) x.ShowPanel(PanelType.Folders), Function(p) If(accordionControl.OptionsMinimizing.State = AccordionControlState.Normal, PanelType.Folders, PanelType.Unknown))
            mvvmContext.BindCommand(Of MainViewModel)(elementSettings, Sub(x) x.ShowPanel(PanelType.Settings), Function(p) PanelType.Settings)
            mvvmContext.BindCommand(Of MainViewModel)(elementAccounts, Sub(x) x.ShowPanel(PanelType.Accounts), Function(p) PanelType.Accounts)
            mvvmContext.BindCommand(Of MainViewModel)(manageAccountsElement, Sub(x) x.ShowPanel(PanelType.Accounts), Function(p) PanelType.Accounts)
            mvvmContext.BindCommand(Of MainViewModel)(outboxElement, Sub(x) x.SelectMailViewerModuleAndApplyOutboxFilter())
            mvvmContext.BindCommand(Of MainViewModel)(inboxElement, Sub(x) x.SelectMailViewerModuleAndApplyInboxFilter())
            mvvmContext.BindCommand(Of MainViewModel)(archiveElement, Sub(x) x.SelectMailViewerModuleAndApplyArchiveFilter())
            mvvmContext.BindCommand(Of MainViewModel)(archive1Element, Sub(x) x.SelectMailViewerModuleAndApplyArchive1Filter())
            mvvmContext.BindCommand(Of MainViewModel)(clutterElement, Sub(x) x.SelectMailViewerModuleAndApplyClutterFilter())
            mvvmContext.BindCommand(Of MainViewModel)(draftsElement, Sub(x) x.SelectMailViewerModuleAndApplyDraftsFilter())
            mvvmContext.BindCommand(Of MainViewModel)(sentItemsElement, Sub(x) x.SelectMailViewerModuleAndApplySentItemsFilter())
            mvvmContext.BindCommand(Of MainViewModel)(foldersDrafts, Sub(x) x.SelectMailViewerModuleAndApplyDraftsFilter())
            mvvmContext.BindCommand(Of MainViewModel)(foldersSentItems, Sub(x) x.SelectMailViewerModuleAndApplySentItemsFilter())
            mvvmContext.BindCommand(Of MainViewModel)(foldersMore, Sub(x) x.ShowPanel(PanelType.Folders), Function(p) PanelType.Folders)
            mvvmContext.BindCommand(Of MainViewModel)(deletedItemsElement, Sub(x) x.SelectMailViewerModuleAndApplyDeletedItemsFilter())
            mvvmContext.BindCommand(Of MainViewModel)(signatureElement, Sub(x) x.ShowSignatureForm(Bounds), Function(p) Bounds)
            mvvmContext.BindCommand(Of MainViewModel)(notificationsElement, Sub(x) x.ShowPanel(PanelType.Notifications), Function(p) PanelType.Notifications)
            mvvmContext.BindCommand(Of MainViewModel)(elementNewEvent, Sub(x) x.ShowAppointmentForm())
            mvvmContext.BindCommand(Of MainViewModel)(focusedInboxElement, Sub(x) x.ShowPanel(PanelType.FocusedOther), Function(p) PanelType.FocusedOther)
            mvvmContext.BindCommand(Of MainViewModel)(personalizationElement, Sub(x) x.ShowPersonalization(Me), Function(p) Me)
            mvvmContext.BindCommand(Of MainViewModel)(helpElement, Sub(x) x.ShowHelp())
            mvvmContext.BindCommand(Of MainViewModel)(wnElement, Sub(x) x.ShowWN())
            mvvmContext.BindCommand(Of MainViewModel)(aceManageAccountsTitle, Sub(x) x.HidePanel(PanelType.Accounts), Function(p) PanelType.Accounts)
            mvvmContext.BindCommand(Of MainViewModel)(focusedInboxAccordionTitle, Sub(x) x.HidePanel(PanelType.FocusedOther), Function(p) PanelType.FocusedOther)
            mvvmContext.BindCommand(Of MainViewModel)(notificationsHeader, Sub(x) x.HidePanel(PanelType.Notifications), Function(p) PanelType.Notifications)
            mvvmContext.BindCommand(Of MainViewModel)(elementNewMail, Sub(x) x.SelectModule(ModuleType.MailModule), Function(p) ModuleType.MailModule)
            mvvmContext.BindCommand(Of MainViewModel)(elementMail, Sub(x) x.SelectModule(ModuleType.MailViewer), Function(p) ModuleType.MailViewer)
            mvvmContext.BindCommand(Of MainViewModel)(elementCalendar, Sub(x) x.SelectModule(ModuleType.SchedulerModule), Function(p) ModuleType.SchedulerModule)
        End Sub

        Private Sub InitBindings()
            Dim fluentAPI As MVVMContextFluentAPI(Of MainViewModel) = mvvmContext.OfType(Of MainViewModel)()
            fluentAPI.SetBinding(accordionControl, Function(x) x.SelectedElement, Function(x) x.CurrentTag, New Func(Of Object, AccordionControlElement)(AddressOf GetAccordionControlElementFromTag), Function(x) If(x IsNot Nothing, x.Tag, -1))
            fluentAPI.SetBinding(accordionFolders, Function(x) x.SelectedElement, Function(x) x.CurrentTag, Function(tag) accordionFolders.GetElements().FirstOrDefault(Function(x) Equals(x.Tag, tag)), Function(x) If(x IsNot Nothing, x.Tag, -1))
            fluentAPI.SetBinding(showFocusedOtherFilterToggle, Function(x) x.EditValue, Function(x) x.ShowFocusedOtherFilter)
        End Sub

        Private Function GetAccordionControlElementFromTag(ByVal tag As Object) As AccordionControlElement
            Dim element = accordionControl.GetElements().FirstOrDefault(Function(x) Equals(x.Tag, tag))
            If Not Equals(element, Nothing) Then Return element
            Return accordionControl.GetElements().FirstOrDefault(Function(x) Equals(x.Tag, foldersMore.Tag))
        End Function

#End Region
#Region "Properties"
        Protected Overrides ReadOnly Property ExtendNavigationControlToFormTitle As Boolean
            Get
                Return False
            End Get
        End Property

        Friend ReadOnly Property ExtendNavigationControlToFormTitleInternal As Boolean
            Get
                Return ExtendNavigationControlToFormTitle
            End Get
        End Property

        Protected Overrides ReadOnly Property ShowMode As FormShowMode
            Get
                Return FormShowMode.AfterInitialization
            End Get
        End Property

#End Region
#Region "Events"
        Private loading As Integer = 0

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            loading += 1
            Try
                ViewModel.SelectedModuleType = ModuleType.MailViewer
            Finally
                StartUpProcess.OnRunning("Successfully loaded.")
                loading -= 1
            End Try
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            Call StartUpProcess.OnComplete()
            If MainFormHelper.TakeScreens Then Call MainFormHelper.TakeAllScreens(New Func(Of Integer, String)(AddressOf TakeModule), takeModuleTypes.Length, Me, fluentDesignFormContainer, New Func(Of Integer, Integer)(AddressOf TakeModuleInterval), demoName:=GetType(MainForm).Assembly.GetName().Name)
        End Sub

        Private ReadOnly takeModuleTypes As ModuleType() = New ModuleType() {ModuleType.MailViewer, ModuleType.SchedulerModule, ModuleType.MailModule}

        Private Function TakeModule(ByVal num As Integer) As String
            If ViewModel.SelectedModuleType <> takeModuleTypes(num) Then ViewModel.SelectedModuleType = takeModuleTypes(num)
            fluentDesignFormContainer.Update()
            Call Application.DoEvents()
            Return takeModuleTypes(num).ToString()
        End Function

        Private Function TakeModuleInterval(ByVal num As Integer) As Integer
            Return 1000
        End Function

        Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
            ViewModel.SelectedModuleType = ModuleType.Unknown
            RemoveHandler ViewModel.ModuleAdded, AddressOf ViewModelOnModuleAdded
            RemoveHandler ViewModel.ModuleRemoved, AddressOf ViewModelOnModuleRemoved
            RemoveHandler ViewModel.CurrentTagChanged, AddressOf ViewModel_CurrentTagChanged
            MyBase.OnFormClosed(e)
        End Sub

#End Region
        Private Sub SaveLayoutToStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.SaveLayoutToStream
        End Sub

        Private Sub RestoreLayoutFromStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.RestoreLayoutFromStream
        End Sub

        Private Sub accordionControl_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            Dim selectionWidth As Integer = 3
            Dim elem As SkinElement = HamburgerMenuSkins.GetSkin(UserLookAndFeel.Default)(HamburgerMenuSkins.SkinItem)
            If elem Is Nothing Then Return
            If Equals(e.ObjectInfo.Element.Tag, "Account") Then
                e.Handled = True
                e.DrawHeaderBackground()
                e.DrawText()
                e.Cache.FillRectangle(elem.GetForeColor(ObjectState.Pressed), New Rectangle(e.ObjectInfo.HeaderBounds.Location, New Size(ScaleHelper.ScaleHorizontal(selectionWidth), e.ObjectInfo.HeaderBounds.Height)))
            Else
                Dim _tag As Integer = Convert.ToInt32(e.ObjectInfo.Element.Tag)
                If _tag >= CInt(ModuleType.DraftsModule) AndAlso _tag <= CInt(ModuleType.SentItemsModule) Then
                    e.Handled = True
                    e.DrawHeaderBackground()
                    e.DrawText()
                    If Equals(accordionControl.SelectedElement, e.ObjectInfo.Element) Then e.Cache.FillRectangle(elem.GetForeColor(ObjectState.Pressed), New Rectangle(e.ObjectInfo.HeaderBounds.Location, New Size(ScaleHelper.ScaleHorizontal(selectionWidth), e.ObjectInfo.HeaderBounds.Height)))
                    If _tag = CInt(ModuleType.DraftsModule) AndAlso ViewModel.DraftsMailCounter > 0 Then
                        Dim x As Single = e.ObjectInfo.HeaderBounds.Width - e.ObjectInfo.HeaderBounds.X - e.ObjectInfo.TextBounds.X
                        Dim y As Single = e.ObjectInfo.TextBounds.Y
                        Dim fn As Font = accordionControl.Appearance.Item.Normal.Font
                        If e.ObjectInfo.Element IsNot Nothing Then
                            Dim elementTag As Integer = If(TypeOf e.ObjectInfo.Element.Tag Is Integer, CInt(e.ObjectInfo.Element.Tag), -1)
                            Dim state As ObjectState = If(Equals(elementTag, _tag), ObjectState.Pressed, ObjectState.Hot)
                            e.Cache.DrawString(ViewModel.DraftsMailCounter.ToString(), fn, e.Cache.GetSolidBrush(elem.GetForeColor(state)), x, y)
                        End If
                    End If
                End If
            End If
        End Sub
    End Class
End Namespace
