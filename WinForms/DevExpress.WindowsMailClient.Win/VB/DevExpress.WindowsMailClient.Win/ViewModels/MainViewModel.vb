Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.WindowsMailClient.Win.Data
Imports DevExpress.WindowsMailClient.Win.Modules
Imports DevExpress.WindowsMailClient.Win.Services
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.XtraSplashScreen
Imports Message = DevExpress.WindowsMailClient.Win.Data.Message

Namespace DevExpress.WindowsMailClient.Win.ViewModels

    Public Interface ISupportModuleLayout

        Sub SaveLayoutToStream(ByVal ms As IO.MemoryStream)

        Sub RestoreLayoutFromStream(ByVal ms As IO.MemoryStream)

    End Interface

    Public Interface IMainModule
        Inherits ISupportModuleLayout

    End Interface

    Public Class MainViewModel

        Shared Sub New()
            Call ServiceContainer.Default.RegisterService(New ModuleResourceProvider())
            Call ServiceContainer.Default.RegisterService(New ModuleTypesResolver())
            Call ServiceContainer.Default.RegisterService(New ProcessExecutionService())
            Call ServiceContainer.Default.RegisterService(New PanelProviderService())
        End Sub

        Public Sub New(ByVal [module] As IMainModule)
            Dim mainModuleType = [module].GetType()
            Dim localServices As ISupportServices = CType(Me, ISupportServices)
            localServices.ServiceContainer.RegisterService(New ModuleActivator(mainModuleType.Assembly, mainModuleType.Namespace & ".Modules"))
            localServices.ServiceContainer.RegisterService(New ModuleLocator(localServices.ServiceContainer))
            localServices.ServiceContainer.RegisterService(New ProcessExecutionService())
            localServices.ServiceContainer.RegisterService(New PanelProviderService())
            RegisterAsRecipient()
        End Sub

        Public Sub RegisterAsRecipient()
            Call Messenger.Default.Register(Me, New Action(Of Message)(AddressOf OnGetMessage))
        End Sub

        Public ReadOnly Property SelectedAccordionModuleType As ModuleType
            Get
                Return GetAccordionModuleType(SelectedModuleType)
            End Get
        End Property

        Public Function GetAccordionModuleType(ByVal type As ModuleType) As ModuleType
            Dim resolver = GetService(Of IModuleTypesResolver)()
            Return resolver.GetAccordionModuleType(type)
        End Function

#Region "Events"
        Public Event ModuleAdded As EventHandler

        Public Event ModuleRemoved As EventHandler

        Public Event SelectedModuleTypeChanged As EventHandler

        Public Event SelectedModuleChanged As EventHandler

        Public Event CurrentTagChanged As EventHandler

#End Region
#Region "Commands"
        Public Sub HidePanelsAndShowAccounts()
            HideAllPanels()
            ShowPanel(PanelType.Accounts)
        End Sub

        <Command>
        Public Sub StartPeople()
            GetService(Of IProcessExecutionService).ExecuteProcess("ms-people://")
        End Sub

        Private progressPanelHandle As IOverlaySplashScreenHandle = Nothing

        <Command>
        Public Sub SelectModule(ByVal moduleType As ModuleType)
            Try
                HideAllPanels()
                progressPanelHandle = ShowProgressPanel(AppProvider.MainForm)
                If SelectedModuleType <> moduleType Then
                    SelectedModuleType = moduleType
                End If
            Finally
                CloseProgressPanel(progressPanelHandle)
            End Try
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyDraftsFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Draft)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyOutboxFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Outbox)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyInboxFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Inbox)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyArchiveFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Archive)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyArchive1Filter()
            SelectMailViewerModuleAndShowMessages(MailType.Archive1)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyDeletedItemsFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Deleted)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplyClutterFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Clutter)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub SelectMailViewerModuleAndApplySentItemsFilter()
            SelectMailViewerModuleAndShowMessages(MailType.Sent)
            HideAllPanels()
        End Sub

        <Command>
        Public Sub ShowPanel(ByVal panel As PanelType)
            If panel = PanelType.Unknown Then Return
            ShowFlyoutPanelCore(panel)
        End Sub

        <Command>
        Public Sub HidePanel(ByVal type As PanelType)
            HideFlyoutPanelCore(type)
        End Sub

        <Command>
        Public Sub ShowHelp()
            GetService(Of IProcessExecutionService)().ShowDocumentation()
        End Sub

        <Command>
        Public Sub ShowPersonalization(ByVal mainForm As Form)
            HideAllPanels()
            GetService(Of IProcessExecutionService)().ShowPaletteSelector()
        End Sub

        <Command>
        Public Sub ShowWN()
            GetService(Of IProcessExecutionService)().ShowWN()
        End Sub

        <Command>
        Public Sub ShowSignatureForm(ByVal ownerRect As Rectangle)
            HideAllPanels()
            GetService(Of IProcessExecutionService)().ShowSignatureForm()
        End Sub

        <Command>
        Public Sub ShowAppointmentForm()
            Dim [module] = TryCast(SelectedModule, SchedulerModule)
            If [module] IsNot Nothing Then GetService(Of IProcessExecutionService)().ShowAppointmentForm([module].Scheduler)
        End Sub

        Private Sub SelectMailViewerModuleAndShowMessages(ByVal category As MailType)
            If SelectedModuleType <> ModuleType.MailViewer Then SelectModule(ModuleType.MailViewer)
            Dim [module] = TryCast(GetModule(ModuleType.MailViewer), MailViewer)
            If [module] IsNot Nothing Then [module].SetMailType(category)
        End Sub

#End Region
#Region "Properties"
        Public Overridable Property SelectedModuleType As ModuleType

        Public Overridable Property SelectedModule As Object

        Public Overridable Property DraftsMailCounter As Integer

        Private showFocusedOtherFiler As Boolean = True

        Public Overridable Property ShowFocusedOtherFilter As Boolean
            Get
                Return showFocusedOtherFiler
            End Get

            Set(ByVal value As Boolean)
                showFocusedOtherFiler = value
                OnShowFocusedOtherFilterChanged()
            End Set
        End Property

        Protected Sub OnShowFocusedOtherFilterChanged()
            Messenger.Default.Send(ShowFocusedOtherFilter)
        End Sub

        Public Overridable Property CurrentTag As Object

        Protected Sub OnCurrentTagChanged()
            RaiseEvent CurrentTagChanged(Me, EventArgs.Empty)
        End Sub

#End Region
        Friend Sub HideFlyoutPanelCore(ByVal type As PanelType)
            GetService(Of IPanelProviderService).HidePanel(type)
        End Sub

        Private _panelsStack As Stack(Of PanelType)

        Public Overridable ReadOnly Property PanelsStack As Stack(Of PanelType)
            Get
                If _panelsStack Is Nothing Then _panelsStack = New Stack(Of PanelType)()
                Return _panelsStack
            End Get
        End Property

        Friend Sub ShowFlyoutPanelCore(ByVal type As PanelType)
            PanelsStack.Push(type)
            GetService(Of IPanelProviderService).ShowPanel(type)
        End Sub

        Protected Overridable Sub OnSelectedModuleTypeChanged(ByVal oldType As ModuleType)
            Try
                SelectedModule = GetModule(SelectedModuleType)
                RaiseSelectedModuleTypeChanged()
            Catch e As Exception
                ExecuteApplicationExeption(oldType, e)
            End Try
        End Sub

        Private Sub ConfigureRemovedModule(ByVal oldModule As Object)
            Dim [module] = TryCast(oldModule, MailModule)
            If [module] IsNot Nothing Then
                If [module].SaveMessageToDrafts() Then DraftsMailCounter += 1
            End If
        End Sub

        Protected Overridable Sub OnSelectedModuleChanged(ByVal oldModule As Object)
            If oldModule IsNot Nothing Then
                ConfigureRemovedModule(oldModule)
                RaiseEvent ModuleRemoved(oldModule, EventArgs.Empty)
            End If

            RaiseEvent SelectedModuleChanged(Me, EventArgs.Empty)
            If SelectedModule IsNot Nothing Then
                CheckModuleViewModel(SelectedModule, Me)
                RaiseEvent ModuleAdded(SelectedModule, EventArgs.Empty)
            End If
        End Sub

        Private Sub ExecuteApplicationExeption(ByVal oldType As ModuleType, ByVal e As Exception)
            Dim entryAsm = Assembly.GetEntryAssembly()
            Dim msg As String = "Error: [" & oldType & "=>" & SelectedModuleType & Environment.NewLine & If(entryAsm IsNot Nothing, "StartUp:" & entryAsm.Location, String.Empty)
            Throw New ApplicationException(msg, e)
        End Sub

        Private Sub RaiseSelectedModuleTypeChanged()
            RaiseCanExecuteChanged(Sub(x) x.SelectModule(ModuleType.Unknown))
            RaiseEvent SelectedModuleTypeChanged(Me, EventArgs.Empty)
        End Sub

        Public Function GetModule(ByVal selectedModuleType As ModuleType) As Object
            Return GetService(Of IModuleLocator).GetModule(selectedModuleType)
        End Function

        Public Sub ReleaseModule(ByVal [module] As Control)
            GetService(Of IModuleLocator).ReleaseModule([module])
        End Sub

        Private Sub OnGetMessage(ByVal message As Message)
            Select Case message.MailType
                Case MailType.Deleted
                    DraftsMailCounter -= 1
                Case Else
                    SelectModule(ModuleType.MailModule)
                    Dim [module] = TryCast(SelectedModule, MailModule)
                    If [module] IsNot Nothing Then
                        [module].ShowMessage(message)
                    End If

            End Select
        End Sub

        <Command>
        Public Sub HideAllPanels()
            While PanelsStack.Count > 0
                GetService(Of IPanelProviderService)().HidePanel(PanelsStack.Pop())
            End While
        End Sub
    End Class
End Namespace
