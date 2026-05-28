Imports System
Imports System.Windows.Forms
Imports DevExpress.DevAV.Services
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class MainViewModel
        Implements IZoomViewModel

        Private _ReportParameter As Object

#Region "static"
        Shared Sub New()
            ServiceContainer.Default.RegisterService(New ModuleResourceProvider())
            ServiceContainer.Default.RegisterService(New ModuleTypesResolver())
        End Sub

#End Region  ' static
        Protected Sub New(ByVal mainModule As IMainModule)
            RegisterServices(mainModule)
        End Sub

        Private Sub RegisterServices(ByVal mainModule As IMainModule)
            Dim mainModuleType = mainModule.GetType()
            Dim localServices As ISupportServices = CType(Me, ISupportServices)
            localServices.ServiceContainer.RegisterService(New WaitingService())
            localServices.ServiceContainer.RegisterService(New ModuleActivator(mainModuleType.Assembly, mainModuleType.Namespace & ".Modules"))
            localServices.ServiceContainer.RegisterService(New ReportActivator())
            localServices.ServiceContainer.RegisterService(New ModuleLocator(localServices.ServiceContainer))
            localServices.ServiceContainer.RegisterService(New ReportLocator(localServices.ServiceContainer))
            localServices.ServiceContainer.RegisterService(New TransitionService(mainModule))
            localServices.ServiceContainer.RegisterService(New PeekModulesHostingService(mainModule))
            localServices.ServiceContainer.RegisterService(New WorkspaceService(mainModule))
        End Sub

#Region "Properties"
        Public Overridable Property SelectedModuleType As ModuleType

        Public Overridable Property SelectedModule As Object

        Public Function GetNavigationModule(ByVal moduleType As ModuleType) As Control
            Dim filterPane As Control = TryCast(GetModule(moduleType, SelectedModuleViewModel), Control)
            EnsureModuleViewModel(filterPane, Me)
            Return filterPane
        End Function

        Public ReadOnly Property SelectedNavPaneModuleType As ModuleType
            Get
                Return GetNavPaneModuleType(SelectedModuleType)
            End Get
        End Property

        Public ReadOnly Property SelectedPeekModuleType As ModuleType
            Get
                Return GetPeekModuleType(SelectedModuleType)
            End Get
        End Property

        Public ReadOnly Property SelectedNavPaneHeaderModuleType As ModuleType
            Get
                Return GetNavPaneModuleType(SelectedModuleType, True)
            End Get
        End Property

        Public ReadOnly Property SelectedExportModuleType As ModuleType
            Get
                Return GetExportModuleType(SelectedModuleType)
            End Get
        End Property

        Public ReadOnly Property SelectedPrintModuleType As ModuleType
            Get
                Return GetPrintModuleType(SelectedModuleType)
            End Get
        End Property

        Public ReadOnly Property SelectedModuleViewModel As Object
            Get
                Return CType(SelectedModule, Modules.ISupportViewModel).ViewModel
            End Get
        End Property

#End Region  ' Properties
#Region "Commands"
        Public Function CanSelectModule(ByVal moduleType As ModuleType) As Boolean
            Return SelectedModuleType <> moduleType
        End Function

        <Command>
        Public Sub SelectModule(ByVal moduleType As ModuleType)
            SelectedModuleType = moduleType
        End Sub

        Public Function CanDockPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return Not GetService(Of IPeekModulesHostingService).IsDocked(peekModuleType)
        End Function

        <Command>
        Public Sub DockPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            GetService(Of IPeekModulesHostingService).DockModule(peekModuleType)
        End Sub

        Public Function CanUndockPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return GetService(Of IPeekModulesHostingService).IsDocked(peekModuleType)
        End Function

        <Command>
        Public Sub UndockPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            GetService(Of IPeekModulesHostingService).UndockModule(peekModuleType)
        End Sub

        Public Function CanShowPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return Not GetService(Of IPeekModulesHostingService).IsDocked(peekModuleType)
        End Function

        <Command>
        Public Sub ShowPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            GetService(Of IPeekModulesHostingService).ShowModule(peekModuleType)
        End Sub

        <Command>
        Public Sub GetStarted()
            Data.Utils.SafeProcess.TryOpenHyperlink(AssemblyInfo.DXLinkGetStarted)
        End Sub

        <Command>
        Public Sub GetSupport()
            Data.Utils.SafeProcess.TryOpenHyperlink(AssemblyInfo.DXLinkGetSupport)
        End Sub

        <Command>
        Public Sub BuyNow()
            Data.Utils.SafeProcess.TryOpenHyperlink(AssemblyInfo.DXLinkBuyNow)
        End Sub

        <Command>
        Public Sub About()
            Utils.About.AboutHelper.Show(Utils.About.ProductKind.DXperienceWin)
        End Sub

#End Region
#Region "FiltersVisibility"
        Public Overridable Property IsReadingMode As Boolean

        <Command>
        Public Sub TurnOnReadingMode()
            IsReadingMode = True
        End Sub

        Public Function CanTurnOnReadingMode() As Boolean
            Return Not IsReadingMode
        End Function

        <Command>
        Public Sub TurnOffReadingMode()
            IsReadingMode = False
        End Sub

        Public Function CanTurnOffReadingMode() As Boolean
            Return IsReadingMode
        End Function

        Public Overridable Property FiltersVisibility As CollectionViewFiltersVisibility

        <Command>
        Public Sub ShowFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Visible
        End Sub

        Public Function CanShowFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Visible
        End Function

        <Command>
        Public Sub MinimizeFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Minimized
        End Sub

        Public Function CanMinimizeFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Minimized
        End Function

        <Command>
        Public Sub HideFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Hidden
        End Sub

        Public Function CanHideFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Hidden
        End Function

        Public Event IsReadingModeChanged As EventHandler

        Protected Overridable Sub OnIsReadingModeChanged()
            RaiseCanExecuteChanged(Sub(x) x.TurnOnReadingMode())
            RaiseCanExecuteChanged(Sub(x) x.TurnOffReadingMode())
            RaiseIsReadingModeChanged()
        End Sub

        Private Sub RaiseIsReadingModeChanged()
            Dim handler As EventHandler = IsReadingModeChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Event ViewFiltersVisibilityChanged As EventHandler

        Protected Overridable Sub OnFiltersVisibilityChanged()
            RaiseCanExecuteChanged(Sub(x) x.ShowFilters())
            RaiseCanExecuteChanged(Sub(x) x.MinimizeFilters())
            RaiseCanExecuteChanged(Sub(x) x.HideFilters())
            RaiseFiltersVisibilityChanged()
        End Sub

        Private Sub RaiseFiltersVisibilityChanged()
            Dim handler As EventHandler = ViewFiltersVisibilityChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#End Region
        Private Function IsModuleLoaded(ByVal type As ModuleType) As Boolean
            Return GetService(Of IModuleLocator).IsModuleLoaded(type)
        End Function

        Public Function GetModule(ByVal type As ModuleType) As Object
            Return GetService(Of IModuleLocator).GetModule(type)
        End Function

        Public Function GetModule(ByVal type As ModuleType, ByVal viewModel As Object) As Object
            Return GetService(Of IModuleLocator).GetModule(type, viewModel)
        End Function

        Public Function GetModuleName(ByVal type As ModuleType) As String
            Return GetService(Of IModuleTypesResolver).GetName(type)
        End Function

        Public Function GetModuleID(ByVal type As ModuleType) As Guid
            Return GetService(Of IModuleTypesResolver).GetId(type)
        End Function

        Public Function GetModuleCaption(ByVal type As ModuleType) As String
            Return GetService(Of IModuleResourceProvider).GetCaption(type)
        End Function

        Public Function GetModuleSmallImageUri(ByVal type As ModuleType) As String
            Return GetService(Of IModuleResourceProvider).GetModuleImageUri(type, True)
        End Function

        Public Function GetModuleImageUri(ByVal type As ModuleType) As String
            Return GetService(Of IModuleResourceProvider).GetModuleImageUri(type)
        End Function

        Public Function GetMainModuleType(ByVal type As ModuleType) As ModuleType
            Return Me.GetService(Of IModuleTypesResolver)().GetMainModuleType(type)
        End Function

        Public Function GetNavPaneModuleType(ByVal type As ModuleType, ByVal Optional collapsed As Boolean = False) As ModuleType
            Dim resolver = GetService(Of IModuleTypesResolver)()
            Return If(collapsed, resolver.GetNavPaneHeaderModuleType(type), resolver.GetNavPaneModuleType(type))
        End Function

        Public Function GetPeekModuleType(ByVal type As ModuleType) As ModuleType
            Return GetService(Of IModuleTypesResolver).GetPeekModuleType(type)
        End Function

        Public Function GetExportModuleType(ByVal type As ModuleType) As ModuleType
            Return GetService(Of IModuleTypesResolver).GetExportModuleType(type)
        End Function

        Public Function GetPrintModuleType(ByVal type As ModuleType) As ModuleType
            Return GetService(Of IModuleTypesResolver).GetPrintModuleType(type)
        End Function

#Region "Selected Module"
        Protected Overridable Sub OnSelectedModuleTypeChanged(ByVal oldType As ModuleType)
            Dim transitionService = GetService(Of ITransitionService)()
            Dim effective As Boolean = SelectedModuleType <> ModuleType.Unknown AndAlso oldType <> ModuleType.Unknown
            Dim waitParameter As Object = If(Not IsModuleLoaded(SelectedModuleType), CObj(SelectedModuleType), Nothing)
            Using transitionService.EnterTransition(effective, (CInt(SelectedModuleType) > CInt(oldType)), waitParameter)
                Dim workspaceService = GetService(Of IWorkspaceService)()
                Dim resolver = GetService(Of IModuleTypesResolver)()
                If oldType <> ModuleType.Unknown Then
                    workspaceService.SaveWorkspace(resolver.GetName(oldType))
                Else
                    workspaceService.SetupDefaultWorkspace()
                End If

                Try
                    SelectedModule = GetModule(SelectedModuleType)
                    RaiseSelectedModuleTypeChanged()
                Catch e As Exception
                    Dim entryAsm = Reflection.Assembly.GetEntryAssembly()
                    Dim msg As String = "Navigation Error: [" & oldType.ToString() & "=>" & SelectedModuleType.ToString() & Environment.NewLine & If(entryAsm IsNot Nothing, "StartUp:" & entryAsm.Location, String.Empty)
                    Throw New ApplicationException(msg, e)
                End Try

                If SelectedModuleType <> ModuleType.Unknown Then workspaceService.RestoreWorkspace(resolver.GetName(SelectedModuleType))
            End Using
        End Sub

        Protected Overridable Sub OnSelectedModuleChanged(ByVal oldModule As Object)
            If oldModule IsNot Nothing Then
                RaiseEvent ModuleRemoved(oldModule, EventArgs.Empty)
            End If

            RaiseEvent SelectedModuleChanged(Me, EventArgs.Empty)
            If SelectedModule IsNot Nothing Then
                EnsureModuleViewModel(SelectedModule, Me)
                RaiseEvent ModuleAdded(SelectedModule, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub RaiseSelectedModuleTypeChanged()
            RaiseCanExecuteChanged(Sub(x) x.SelectModule(ModuleType.Unknown))
            RaisePropertyChanged(Function(x) SelectedNavPaneModuleType)
            RaisePropertyChanged(Function(x) SelectedNavPaneHeaderModuleType)
            RaiseEvent SelectedModuleTypeChanged(Me, EventArgs.Empty)
        End Sub

        Public Event ModuleAdded As EventHandler

        Public Event ModuleRemoved As EventHandler

        Public Event SelectedModuleChanged As EventHandler

        Public Event SelectedModuleTypeChanged As EventHandler

#End Region  ' Selected Module
#Region "Print & Reports"
        Public Event Print As EventHandler(Of PrintEventArgs)

        Public Property ReportParameter As Object
            Get
                Return _ReportParameter
            End Get

            Private Set(ByVal value As Object)
                _ReportParameter = value
            End Set
        End Property

        Private currentReportModule As ModuleType

        Friend Sub BeforeReportShown(ByVal moduleType As ModuleType)
            If ReportParameter IsNot Nothing Then Return
            Select Case moduleType
                Case ModuleType.EmployeesExport, ModuleType.EmployeesPrint
                    ReportParameter = EmployeeReportType.Profile
                Case ModuleType.CustomersExport, ModuleType.CustomersPrint
                    ReportParameter = CustomerReportType.Profile
                Case ModuleType.ProductsExport, ModuleType.ProductsPrint
                    ReportParameter = ProductReportType.OrderDetail
                Case ModuleType.OrdersExport, ModuleType.OrdersPrint
                    ReportParameter = SalesReportType.Invoice
            End Select
        End Sub

        Friend Sub AfterReportShown(ByVal moduleType As ModuleType)
            If currentReportModule <> moduleType Then
                Dim reportChanged As Boolean = currentReportModule <> ModuleType.Unknown
                currentReportModule = moduleType
                If reportChanged AndAlso moduleType <> ModuleType.Unknown Then
                    Dim reportViewModel = TryCast(CType(GetModule(moduleType), Modules.ISupportViewModel).ViewModel, ReportViewModelBase)
                    If reportViewModel IsNot Nothing Then reportViewModel.OnReload()
                End If
            End If
        End Sub

        Friend Sub AfterReportHidden()
            currentReportModule = ModuleType.Unknown
            ReportParameter = Nothing
        End Sub

        Friend Sub RaisePrint(ByVal parameter As Object)
            ReportParameter = parameter
            Dim handler As EventHandler(Of PrintEventArgs) = PrintEvent
            If handler IsNot Nothing Then handler(Me, New PrintEventArgs(parameter))
        End Sub

#End Region  ' Print & Reports
        Public Event ShowAllFolders As EventHandler

        Friend Sub RaiseShowAllFolders()
            Dim handler As EventHandler = ShowAllFoldersEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#Region "ISupportZoomModule Members"
        Private ReadOnly Property ZoomModule As Object Implements IZoomViewModel.ZoomModule
            Get
                Return SelectedModule
            End Get
        End Property

        Private Custom Event ZoomModuleChanged As EventHandler Implements IZoomViewModel.ZoomModuleChanged
            AddHandler(ByVal value As EventHandler)
                AddHandler SelectedModuleChanged, value
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler SelectedModuleChanged, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                RaiseEvent SelectedModuleChanged(sender, e)
            End RaiseEvent
        End Event
#End Region
    End Class

    Public Class PrintEventArgs
        Inherits EventArgs

        Private _Parameter As Object

        Public Sub New(ByVal parameter As Object)
            Me.Parameter = parameter
        End Sub

        Public Property Parameter As Object
            Get
                Return _Parameter
            End Get

            Private Set(ByVal value As Object)
                _Parameter = value
            End Set
        End Property
    End Class
End Namespace
