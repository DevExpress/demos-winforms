Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq.Expressions
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars.ToastNotifications
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen


Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("MessageBox Services", "Services.vb"), CodeExampleHighlightTokens("MVVMContext", "IMessageBoxService"), CodeExampleUnderlineTokens("RegisterMessageBoxService", "RegisterXtraMessageBoxService", "RegisterFlyoutMessageBoxService", "ShowMessage")>
    Public NotInheritable Class MessageBoxServices
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {mvvmContext, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            MVVMContext.RegisterXtraMessageBoxService()
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("MessageBox Service", New Type() {GetType(SayHelloViewModel)})>
        Public Shared Sub MessageBoxService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            ' Force use the MessageBoxService
            MVVMContext.RegisterMessageBoxService()
            '
            mvvmContext.ViewModelType = GetType(SayHelloViewModel)
            ' UI binding for button
            mvvmContext.BindCommand(Of SayHelloViewModel)(commandButton, Sub(x) x.SayHello())
        End Sub
        <CodeExampleCase("XtraMessageBox Service", New Type() {GetType(SayHelloViewModel)})>
        Public Shared Sub XtraMessageBoxService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            ' Force use the XtraMessageBoxService
            MVVMContext.RegisterXtraMessageBoxService()
            '
            mvvmContext.ViewModelType = GetType(SayHelloViewModel)
            ' UI binding for button
            mvvmContext.BindCommand(Of SayHelloViewModel)(commandButton, Sub(x) x.SayHello())
        End Sub
        <CodeExampleCase("FlyoutMessageBox Service", New Type() {GetType(SayHelloViewModel)})>
        Public Shared Sub FlyoutMessageBoxService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            ' Force use the FlyoutMessageBoxService
            MVVMContext.RegisterFlyoutMessageBoxService()
            '
            mvvmContext.ViewModelType = GetType(SayHelloViewModel)
            ' UI binding for button
            mvvmContext.BindCommand(Of SayHelloViewModel)(commandButton, Sub(x) x.SayHello())
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class SayHelloViewModel
            Protected ReadOnly Property MessageBoxService() As IMessageBoxService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Public Sub SayHello()
                ' using the MessageBoxService.ShowMessage method
                If MessageBoxService.ShowMessage("Hello, buddy! Have a nice day!", "Greeting", MessageButton.OK, MessageIcon.Information) = MessageResult.OK Then
                    ' do something
                End If
            End Sub
        End Class
    End Class
    <CodeExampleClass("Dialog Services", "Services.vb"), CodeExampleHighlightTokens("MVVMContext", "IDialogService", "ISupportParameter"), CodeExampleUnderlineTokens("RegisterXtraDialogService", "RegisterRibbonDialogService", "RegisterFlyoutDialogService", "ShowDialog")>
    Public NotInheritable Class DialogServices
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top

            Dim memo As New MemoEdit()
            memo.Dock = DockStyle.Top
            memo.Properties.ReadOnly = True
            memo.MinimumSize = New System.Drawing.Size(0, 100)

            commandButton.Parent = sampleHost
            memo.Parent = sampleHost

            Return New Object() {mvvmContext, commandButton, memo}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("XtraDialog Service", New Type() {GetType(NotesViewModel), GetType(EditNotesViewModel), GetType(NotesEditor)})>
        Public Shared Sub XtraDialogService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal memo As MemoEdit)
            ' Force use the XtraDialogService
            MVVMContext.RegisterXtraDialogService()
            '
            mvvmContext.ViewModelType = GetType(NotesViewModel)
            ' UI binding for Notes
            mvvmContext.SetBinding(memo, Function(m) m.EditValue, "Notes")
            ' UI binding for button
            mvvmContext.BindCommand(Of NotesViewModel)(commandButton, Sub(x) x.EditNotes())
        End Sub
        <CodeExampleCase("FlyoutDialog Service", New Type() {GetType(NotesViewModel), GetType(EditNotesViewModel), GetType(NotesEditor)})>
        Public Shared Sub FlyoutDialogService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal memo As MemoEdit)
            ' Force use the FlyoutDialogService
            MVVMContext.RegisterFlyoutDialogService()
            '
            mvvmContext.ViewModelType = GetType(NotesViewModel)
            ' UI binding for Notes
            mvvmContext.SetBinding(memo, Function(m) m.EditValue, "Notes")
            ' UI binding for button
            mvvmContext.BindCommand(Of NotesViewModel)(commandButton, Sub(x) x.EditNotes())
        End Sub
        <CodeExampleCase("RibbonDialog Service", New Type() {GetType(NotesViewModel), GetType(EditNotesViewModel), GetType(NotesEditor)})>
        Public Shared Sub RibbonDialogService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton, ByVal memo As MemoEdit)
            ' Force use the RibbonDialogService
            MVVMContext.RegisterRibbonDialogService()
            '
            mvvmContext.ViewModelType = GetType(NotesViewModel)
            ' UI binding for Notes
            mvvmContext.SetBinding(memo, Function(m) m.EditValue, "Notes")
            ' UI binding for button
            mvvmContext.BindCommand(Of NotesViewModel)(commandButton, Sub(x) x.EditNotes())
        End Sub
        <CodeExampleNestedClass>
        Public Class NotesViewModel
            Public Sub New()
                Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            End Sub
            Public Overridable Property Notes() As String
            ' using the GetService<> extension method for obtaining service instance
            Protected ReadOnly Property DialogService() As IDialogService
                Get
                    Return Me.GetService(Of IDialogService)()
                End Get
            End Property
            Public Sub EditNotes()
                Dim dialogParams = New Object() {Notes}
                If DialogService.ShowDialog(MessageButton.OKCancel, "Edit Notes", "EditNotes", dialogParams, Me) = MessageResult.OK Then
                    Notes = TryCast(dialogParams(0), String)
                End If
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class EditNotesViewModel
            Implements ISupportParameter

            Public Overridable Property Notes() As String
            Protected Sub OnNotesChanged()
                parameters(0) = Notes
            End Sub
            Private parameters() As Object
            Private Property ISupportParameter_Parameter() As Object Implements ISupportParameter.Parameter
                Get
                    Return parameters(0)
                End Get
                Set(ByVal value As Object)
                    If Object.ReferenceEquals(parameters, value) Then
                        Return
                    End If
                    parameters = DirectCast(value, Object())
                    Notes = TryCast(parameters(0), String)
                End Set
            End Property
        End Class
        <CodeExampleNestedClass, DevExpress.Utils.MVVM.UI.ViewType("EditNotes")>
        Public Class NotesEditor
            Inherits XtraUserControl

            Public Sub New()
                Me.Padding = New Padding(12)
                Me.MinimumSize = New System.Drawing.Size(320, 160)
                '
                Dim mvvmContext As New MVVMContext()
                mvvmContext.ContainerControl = Me
                mvvmContext.ViewModelType = GetType(EditNotesViewModel)
                '
                Dim memo As New MemoEdit()
                memo.Dock = DockStyle.Fill
                memo.Parent = Me
                ' Data-binding for Notes
                mvvmContext.SetBinding(memo, Function(m) m.EditValue, "Notes")
            End Sub
        End Class
    End Class

    <CodeExampleClass("Layout Serialization Service", "Services.vb"), CodeExampleHighlightTokens("LayoutSerializationService", "ILayoutSerializationService"), CodeExampleUnderlineTokens("Create", "Serialize", "Deserialize")>
    Public NotInheritable Class LayoutService
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim saveLayoutButton As New SimpleButton()
            saveLayoutButton.Text = "Save Layout"
            saveLayoutButton.Dock = DockStyle.Top

            Dim loadLayoutButton As New SimpleButton()
            loadLayoutButton.Text = "Load Layout"
            loadLayoutButton.Dock = DockStyle.Top

            Dim container As New SplitContainerControl()
            container.Dock = DockStyle.Top
            container.Panel1.BackColor = System.Drawing.Color.LightGray
            container.Panel2.BackColor = System.Drawing.Color.Beige

            container.Parent = sampleHost
            loadLayoutButton.Parent = sampleHost
            saveLayoutButton.Parent = sampleHost

            Return New Object() {mvvmContext, saveLayoutButton, loadLayoutButton, container}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Save and Load Layout", New Type() {GetType(LayoutViewModel)})>
        Public Shared Sub LayoutSerialization(ByVal mvvmContext As MVVMContext, ByVal saveLayoutButton As SimpleButton, ByVal loadLayoutButton As SimpleButton, ByVal container As SplitContainerControl)
            mvvmContext.ViewModelType = GetType(LayoutViewModel)
            ' Use the LayoutSerializationService for SplitContainerControl
            mvvmContext.RegisterService(LayoutSerializationService.Create(container, True))
            ' Binding commands to buttons
            mvvmContext.BindCommand(Of LayoutViewModel)(saveLayoutButton, Sub(x) x.SaveLayout())
            mvvmContext.BindCommand(Of LayoutViewModel)(loadLayoutButton, Sub(x) x.LoadLayout())
        End Sub
        <CodeExampleNestedClass>
        Public Class LayoutViewModel
            Protected ReadOnly Property Service() As ILayoutSerializationService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ILayoutSerializationService)()
                End Get
            End Property
            Protected Property Layout() As String
            Public Sub SaveLayout()
                ' Using the ILayoutSerializationService.Serialize method
                Layout = Service.Serialize()
            End Sub
            Public Sub LoadLayout()
                ' Using the ILayoutSerializationService.Deserialize method
                Service.Deserialize(Layout)
            End Sub
        End Class
    End Class

    <CodeExampleClass("Notification Service", "Services.vb"), CodeExampleHighlightTokens("NotificationService", "INotificationService", "INotification", "INotificationInfo"), CodeExampleUnderlineTokens("Create", "ShowAsync", "Hide", "CreatePredefinedNotification", "CreateCustomNotification"), CodeExampleVersionID(161)>
    Public NotInheritable Class NotificationServices
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim hideNotificationButton As New SimpleButton()
            hideNotificationButton.Text = "Hide Notification"
            hideNotificationButton.Dock = DockStyle.Top
            hideNotificationButton.Parent = sampleHost

            Dim showNotificationButton As New SimpleButton()
            showNotificationButton.Text = "Show Notification"
            showNotificationButton.Dock = DockStyle.Top
            showNotificationButton.Parent = sampleHost

            Dim alertControl As New AlertControl()
            Dim toastNotificationsManager1 As New ToastNotificationsManager()
            toastNotificationsManager1.ApplicationId = String.Format("Components_{0}_Demo_Center_{0}", AssemblyInfo.VersionShort.Replace(".", "_"))
            toastNotificationsManager1.ApplicationName = "DevAV"

            Return New Object() {mvvmContext, showNotificationButton, hideNotificationButton, toastNotificationsManager1, alertControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Predefined Notification(Toast Style)", New Type() {GetType(HelloViewModel)})>
        Public Shared Sub ToastNotificationStylePredefinedNotification(ByVal mvvmContext As MVVMContext, ByVal showNotificationButton As SimpleButton, ByVal hideNotificationButton As SimpleButton, ByVal toastNotificationManager As INotificationProvider, ByVal alertControl As INotificationProvider)
            mvvmContext.ViewModelType = GetType(HelloViewModel)
            ' Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager))
            ' Binding commands to buttons
            mvvmContext.BindCommand(Of HelloViewModel)(showNotificationButton, Sub(x) x.ShowNotification())
            mvvmContext.BindCommand(Of HelloViewModel)(hideNotificationButton, Sub(x) x.HideNotification())
        End Sub
        <CodeExampleCase("Predefined Notification(Alert Style)", New Type() {GetType(HelloViewModel)})>
        Public Shared Sub AlertControlStylePredefinedNotification(ByVal mvvmContext As MVVMContext, ByVal showNotificationButton As SimpleButton, ByVal hideNotificationButton As SimpleButton, ByVal toastNotificationManager As INotificationProvider, ByVal alertControl As INotificationProvider)
            mvvmContext.ViewModelType = GetType(HelloViewModel)
            ' Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl))
            ' Binding commands to buttons
            mvvmContext.BindCommand(Of HelloViewModel)(showNotificationButton, Sub(x) x.ShowNotification())
            mvvmContext.BindCommand(Of HelloViewModel)(hideNotificationButton, Sub(x) x.HideNotification())
        End Sub
        <CodeExampleCase("Custom Notification(Toast Style)", New Type() {GetType(HelloViewModelWithINotificationInfo)})>
        Public Shared Sub ToastNotificationStyleCustomNotification(ByVal mvvmContext As MVVMContext, ByVal showNotificationButton As SimpleButton, ByVal hideNotificationButton As SimpleButton, ByVal toastNotificationManager As INotificationProvider, ByVal alertControl As INotificationProvider)
            mvvmContext.ViewModelType = GetType(HelloViewModelWithINotificationInfo)
            ' Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager))
            ' Binding commands to buttons
            mvvmContext.BindCommand(Of HelloViewModelWithINotificationInfo)(showNotificationButton, Sub(x) x.ShowNotification())
            mvvmContext.BindCommand(Of HelloViewModelWithINotificationInfo)(hideNotificationButton, Sub(x) x.HideNotification())
        End Sub
        <CodeExampleCase("Custom Notification(Alert Style)", New Type() {GetType(HelloViewModelWithINotificationInfo)})>
        Public Shared Sub AlertControlStyleCustomNotification(ByVal mvvmContext As MVVMContext, ByVal showNotificationButton As SimpleButton, ByVal hideNotificationButton As SimpleButton, ByVal toastNotificationManager As INotificationProvider, ByVal alertControl As INotificationProvider)
            mvvmContext.ViewModelType = GetType(HelloViewModelWithINotificationInfo)
            ' Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl))
            ' Binding commands to buttons
            mvvmContext.BindCommand(Of HelloViewModelWithINotificationInfo)(showNotificationButton, Sub(x) x.ShowNotification())
            mvvmContext.BindCommand(Of HelloViewModelWithINotificationInfo)(hideNotificationButton, Sub(x) x.HideNotification())
        End Sub
        <CodeExampleNestedClass>
        Public Class HelloViewModel
            Protected ReadOnly Property INotificationService() As INotificationService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of INotificationService)()
                End Get
            End Property
            Public Overridable Property Notification() As INotification
            Protected Overridable Sub OnNotificationChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.HideNotification())
            End Sub
            Private notifications As New List(Of INotification)()
            Public Sub ShowNotification()
                ' using the INotificationService.CreatePredefinedNotification method
                Notification = INotificationService.CreatePredefinedNotification("Hello, buddy!", "Have a nice day!", "Greeting")
                notifications.Add(Notification)
                ' using the INotification.ShowAsync method
                Notification.ShowAsync()
            End Sub
            Public Sub HideNotification()
                ' using the INotification.Hide method
                Notification.Hide()
                If notifications.Remove(Notification) Then
                    Notification = If(notifications.Count = 0, Nothing, notifications(notifications.Count - 1))
                End If
            End Sub
            Public Function CanHideNotification() As Boolean
                Return Notification IsNot Nothing
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class HelloViewModelWithINotificationInfo
            Implements INotificationInfo

            Protected ReadOnly Property INotificationService() As INotificationService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of INotificationService)()
                End Get
            End Property
            Public Overridable Property Notification() As INotification
            Protected Overridable Sub OnNotificationChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.HideNotification())
            End Sub
            Private notifications As New List(Of INotification)()
            Public Sub ShowNotification()
                ' using the INotificationService.CreateCustomNotification method
                Notification = INotificationService.CreateCustomNotification(Me)
                notifications.Add(Notification)
                ' Showing the notification
                Notification.ShowAsync()
            End Sub
            Public Sub HideNotification()
                ' Hiding the notification
                Notification.Hide()
                If notifications.Remove(Notification) Then
                    Notification = If(notifications.Count = 0, Nothing, notifications(notifications.Count - 1))
                End If
            End Sub
            Public Function CanHideNotification() As Boolean
                Return Notification IsNot Nothing
            End Function
            ReadOnly Property INotificationInfo_Header() As String Implements INotificationInfo.Header
                Get
                    Return "Hello, buddy!"
                End Get
            End Property
            ReadOnly Property INotificationInfo_Body() As String Implements INotificationInfo.Body
                Get
                    Return "Have a nice day!"
                End Get
            End Property
            ReadOnly Property INotificationInfo_Body2() As String Implements INotificationInfo.Body2
                Get
                    Return "Greeting"
                End Get
            End Property
            ReadOnly Property INotificationInfo_Image() As System.Drawing.Image Implements INotificationInfo.Image
                Get
                    Return Nothing
                End Get
            End Property
        End Class
    End Class
    <CodeExampleClass("SplashScreen Service", "Services.vb"), CodeExampleHighlightTokens("ISplashScreenService", "SplashScreen", "DemoProgressSplashScreen", "CommandId"), CodeExampleUnderlineTokens("Create", "ShowSplashScreen", "SetSplashScreenState", "HideSplashScreen"), CodeExampleVersionID(161)>
    Public NotInheritable Class SplashScreenServices
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim hideButton As New SimpleButton()
            hideButton.Text = "Hide"
            hideButton.Dock = DockStyle.Top
            hideButton.Parent = sampleHost

            Dim showButton As New SimpleButton()
            showButton.Text = "Show"
            showButton.Dock = DockStyle.Top
            showButton.Parent = sampleHost

            Dim splashScreenManager As New SplashScreenManager()

            Return New Object() {mvvmContext, showButton, hideButton, splashScreenManager}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Default SplashScreen", New Type() {GetType(DefaultSplashScreenViewModel)})>
        Public Shared Sub ShowDefaultSplashScreen(ByVal mvvmContext As MVVMContext, ByVal showButton As SimpleButton, ByVal hideButton As SimpleButton, ByVal splashScreenManager As SplashScreenManager)
            hideButton.Visible = False
            '
            mvvmContext.ViewModelType = GetType(DefaultSplashScreenViewModel)
            ' UI binding for button
            mvvmContext.BindCommand(Of DefaultSplashScreenViewModel)(showButton, Sub(x) x.Show())
        End Sub
        <CodeExampleCase("Custom SplashScreen", New Type() {GetType(CustomSplashScreenViewModel), GetType(CustomSplashScreen)})>
        Public Shared Sub ShowCustomSplashScreen(ByVal mvvmContext As MVVMContext, ByVal showButton As SimpleButton, ByVal hideButton As SimpleButton, ByVal splashScreenManager As SplashScreenManager)
            mvvmContext.ViewModelType = GetType(CustomSplashScreenViewModel)
            ' SplashScreenManager setup
            splashScreenManager.Properties.UseFadeInEffect = False
            splashScreenManager.Properties.UseFadeOutEffect = False
            ' Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager))
            ' UI binding for buttons
            mvvmContext.BindCommand(Of CustomSplashScreenViewModel)(showButton, Sub(x) x.Show())
            mvvmContext.BindCommand(Of CustomSplashScreenViewModel)(hideButton, Sub(x) x.Hide())
        End Sub
        <CodeExampleCase("Fluent SplashScreen", New Type() {GetType(FluentSplashScreenViewModel)}), CodeExampleVersionID(202)>
        Public Shared Sub ShowFluentSplashScreen(ByVal mvvmContext As MVVMContext, ByVal showButton As SimpleButton, ByVal hideButton As SimpleButton, ByVal splashScreenManager As SplashScreenManager)
            mvvmContext.ViewModelType = GetType(FluentSplashScreenViewModel)
            ' Setup splashScreen options
            FluentSplashScreenOptions.Default.LoadingIndicatorType = FluentLoadingIndicatorType.Dots
            ' Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager))
            ' UI binding for buttons
            ' UI binding for buttons
            mvvmContext.BindCommand(Of FluentSplashScreenViewModel)(showButton, Sub(x) x.Show())
            mvvmContext.BindCommand(Of FluentSplashScreenViewModel)(hideButton, Sub(x) x.Hide())
        End Sub
        <CodeExampleCase("Wait Form", New Type() {GetType(WaitFormViewModel), GetType(MyWaitForm)}), CodeExampleVersionID(201)>
        Public Shared Sub ShowWaitForm(ByVal mvvmContext As MVVMContext, ByVal showButton As SimpleButton, ByVal hideButton As SimpleButton, ByVal splashScreenManager As SplashScreenManager)
            hideButton.Visible = False
            showButton.Text = "Press to wait"
            '
            mvvmContext.ViewModelType = GetType(WaitFormViewModel)
            ' Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager))
            ' UI binding for buttons
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            mvvmContext.BindCommand(Of WaitFormViewModel)(showButton, Sub(x) x.Wait())
#Enable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        End Sub
        <CodeExampleCase("Overlay", New Type() {GetType(OverlayViewModel)}), CodeExampleVersionID(202)>
        Public Shared Sub ShowOverlay(ByVal mvvmContext As MVVMContext, ByVal showButton As SimpleButton, ByVal hideButton As SimpleButton, ByVal splashScreenManager As SplashScreenManager)
            hideButton.Visible = False
            showButton.Text = "Press to wait"
            ' Setup overlay options
            OverlayWindowOptions.Default.UseDirectX = True
            '
            mvvmContext.ViewModelType = GetType(OverlayViewModel)
            ' Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager))
            ' UI binding for buttons
#Disable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
            mvvmContext.BindCommand(Of OverlayViewModel)(showButton, Sub(x) x.Wait())
#Enable Warning BC42358 ' Because this call is not awaited, execution of the current method continues before the call is completed
        End Sub
        <CodeExampleNestedClass>
        Public Class DefaultSplashScreenViewModel
            Protected ReadOnly Property SplashScreenService() As ISplashScreenService
                ' Using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISplashScreenService)()
                End Get
            End Property
            Public Sub Show()
                ' Using the ISplashScreenService.ShowSplashScreen method with null parameters that show default SplashScreen
                SplashScreenService.ShowSplashScreen(Nothing)
                ' Using the ISplashScreenService.SetSplashScreenState
                SplashScreenService.SetSplashScreenState("Loading...")
                Dim maxProgress As Integer = 10000
                For i As Integer = 1 To maxProgress
                    ' Using the ISplashScreenService.SetSplashScreenProgress
                    SplashScreenService.SetSplashScreenProgress(i, maxProgress)
                Next i
                Hide()
            End Sub
            Public Sub Hide()
                ' Using the ISplashScreenService.HideSplashScreen method
                SplashScreenService.HideSplashScreen()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class CustomSplashScreenViewModel
            Protected ReadOnly Property SplashScreenService() As ISplashScreenService
                ' Using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISplashScreenService)()
                End Get
            End Property
            Public Sub Show()
                ' Showing the splash screen
                SplashScreenService.ShowSplashScreen("CustomSplashScreen")
                ' Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Hello, buddy! Have a nice day!")
            End Sub
            Public Sub Hide()
                ' Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Bye!")
                System.Threading.Thread.Sleep(1000)
                ' Hiding the splash screen 
                SplashScreenService.HideSplashScreen()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class FluentSplashScreenViewModel
            Protected ReadOnly Property SplashScreenService() As ISplashScreenService
                ' Using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISplashScreenService)()
                End Get
            End Property
            Public Sub Show()
                ' Showing the Fluent splash screen (via special typename)
                SplashScreenService.ShowSplashScreen("#FluentSplashScreen#")
            End Sub
            Public Sub Hide()
                System.Threading.Thread.Sleep(1000)
                ' Hiding the splash screen
                SplashScreenService.HideSplashScreen()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class WaitFormViewModel
            Protected ReadOnly Property SplashScreenService() As ISplashScreenService
                ' Using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISplashScreenService)()
                End Get
            End Property
            Public Async Function Wait() As System.Threading.Tasks.Task
                ' Find the Wait Form by its type name And show it
                SplashScreenService.ShowSplashScreen("MyWaitForm")
                ' Set Wait Form captions
                SplashScreenService.SetSplashScreenState(New String() {
                    "Please, wait", "In progress..."
                })
                ' Doing something
                Await System.Threading.Tasks.Task.Delay(2500)
                ' Hiding the wait form
                SplashScreenService.HideSplashScreen()
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class OverlayViewModel
            Protected ReadOnly Property SplashScreenService() As ISplashScreenService
                ' Using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISplashScreenService)()
                End Get
            End Property
            Public Async Function Wait() As System.Threading.Tasks.Task
                ' show the Overlay via the special type name
                SplashScreenService.ShowSplashScreen("#Overlay#")
                ' Doing something
                Await System.Threading.Tasks.Task.Delay(2500)
                ' Hiding the wait form
                SplashScreenService.HideSplashScreen()
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class CustomSplashScreen
            Inherits SplashScreen
            Public Sub New()
                MyBase.New()
                stateLabel = New Label()
                stateLabel.Text = "State"
                stateLabel.AutoSize = False
                stateLabel.Dock = DockStyle.Fill
                stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                Me.Controls.Add(stateLabel)
            End Sub
            Private stateLabel As Label
            Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
                MyBase.ProcessCommand(cmd, arg)
                Dim command As DemoProgressSplashScreen.CommandId = CType(cmd, DemoProgressSplashScreen.CommandId)
                If command = DemoProgressSplashScreen.CommandId.MVVMSetState Then
                    stateLabel.Text = DirectCast(arg, String)
                End If
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class MyWaitForm
            Inherits DevExpress.XtraWaitForm.DemoWaitForm
            Public Overrides Sub ProcessCommand(cmd As [Enum], arg As Object)
                Dim args As String() = CType(arg, String())
                SetCaption(args(0))
                SetDescription(args(1))
            End Sub
        End Class
    End Class

    <CodeExampleClass("Open/Save File Dialog Services", "Services.vb"), CodeExampleHighlightTokens("IOpenFileDialogService", "ISaveFileDialogService"), CodeExampleUnderlineTokens("ShowDialog"), CodeExampleVersionID(161)>
    Public NotInheritable Class FileDialogServices
        Private Sub New()
        End Sub
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim logMemoEdit As New MemoEdit()
            logMemoEdit.ReadOnly = True
            logMemoEdit.Dock = DockStyle.Fill
            logMemoEdit.Parent = sampleHost

            Dim showDialogButton As New SimpleButton()
            showDialogButton.Text = "Show Dialog"
            showDialogButton.Dock = DockStyle.Top
            showDialogButton.Parent = sampleHost

            Return New Object() {mvvmContext, showDialogButton, logMemoEdit}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Open File Dialog Service", New Type() {GetType(OpenFileDialogViewModel)})>
        Public Shared Sub ShowOpenFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterOpenFileDialogService()

            mvvmContext.ViewModelType = GetType(OpenFileDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of OpenFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, OpenFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of OpenFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleCase("Skinnable Open File Dialog Service", New Type() {GetType(OpenFileDialogViewModel)}), CodeExampleVersionID(181)>
        Public Shared Sub ShowSkinnableOpenFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterSkinnableOpenFileDialogService()

            mvvmContext.ViewModelType = GetType(OpenFileDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of OpenFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, OpenFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of OpenFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleCase("Custom OpenFileDialog", New Type() {GetType(OpenFileDialogViewModel)}), CodeExampleVersionID(191)>
        Public Shared Sub CreateCustomOpenFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            mvvmContext.ViewModelType = GetType(OpenFileDialogViewModel)

            ' Create a custom dialog
            Dim openFileDialog = New OpenFileDialog()
            'Custom dialog ignores service settings
            openFileDialog.Multiselect = True
            openFileDialog.Title = "Custom Dialog Title"
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.OpenFileDialogService.Create(openFileDialog))

            Dim fluentApi = mvvmContext.OfType(Of OpenFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, OpenFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of OpenFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleCase("Save File Dialog Service", New Type() {GetType(SaveFileDialogViewModel)})>
        Public Shared Sub ShowSaveFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            mvvmContext.ViewModelType = GetType(SaveFileDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of SaveFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, SaveFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of SaveFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleCase("Skinnable Save File Dialog Service", New Type() {GetType(SaveFileDialogViewModel)}), CodeExampleVersionID(181)>
        Public Shared Sub ShowSkinnableSaveFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterSkinnableSaveFileDialogService()

            mvvmContext.ViewModelType = GetType(SaveFileDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of SaveFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, SaveFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of SaveFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleCase("Custom SaveFileDialog", New Type() {GetType(SaveFileDialogViewModel)}), CodeExampleVersionID(191)>
        Public Shared Sub CreateCustomSaveFileDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            mvvmContext.ViewModelType = GetType(SaveFileDialogViewModel)

            ' Create a custom dialog
            Dim saveFileDialog = New SaveFileDialog()
            'Custom dialog ignores service settings
            saveFileDialog.OverwritePrompt = True
            saveFileDialog.CreatePrompt = True
            saveFileDialog.Title = "Custom Dialog Title"
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.SaveFileDialogService.Create(saveFileDialog))

            Dim fluentApi = mvvmContext.OfType(Of SaveFileDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, SaveFileDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of SaveFileDialogViewModel)(showDialogButton, Sub(x) x.ShowFileDialog())
        End Sub
        <CodeExampleNestedClass>
        Public Class OpenFileDialogViewModel
            Public Sub New()
                ' Set IOpenFileDialogService settings
                Me.Title = "Open File Dialog"
                Me.Filter = "All Files|*.*|Text|*.txt"
                Me.FilterIndex = 2
            End Sub
            Protected ReadOnly Property OpenFileDialogService() As IOpenFileDialogService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IOpenFileDialogService)()
                End Get
            End Property
            Protected Overridable Sub AppendLogString(ByVal str As String)
                ' Update log
                Log &= str & Environment.NewLine
            End Sub
            Public Sub ShowFileDialog()
                ' Using the IOpenFileDialogService.ShowDialog method
                If Me.OpenFileDialogService.ShowDialog(AddressOf DialogFileOKCallback, String.Empty) Then
                    AppendLogString("Open file: " & Me.OpenFileDialogService.File.Name)
                Else
                    AppendLogString("Cancel")
                End If
            End Sub

            Public Overridable Property Log() As String
            Public Overridable Property Filter() As String
            Protected Overridable Sub OnFilterChanged()
                Me.OpenFileDialogService.Filter = Me.Filter
                AppendLogString("Set Filter: " & Me.Filter)
            End Sub
            Public Overridable Property FilterIndex() As Integer
            Protected Overridable Sub OnFilterIndexChanged()
                Me.OpenFileDialogService.FilterIndex = Me.FilterIndex
                AppendLogString("Set FilterIndex: " & Me.FilterIndex.ToString())
            End Sub
            Public Overridable Property Title() As String
            Protected Overridable Sub OnTitleChanged()
                Me.OpenFileDialogService.Title = Me.Title
                AppendLogString("Set Title: " & Me.Title)
            End Sub
            Protected Overridable Sub DialogFileOKCallback(ByVal e As System.ComponentModel.CancelEventArgs)
                MessageBox.Show("File is opened")
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class SaveFileDialogViewModel
            Public Sub New()
                ' Set ISaveFileDialogService settings
                Me.Title = "Save File Dialog"
                Me.Filter = "Text|*.txt"
            End Sub
            Protected ReadOnly Property SaveFileDialogService() As ISaveFileDialogService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of ISaveFileDialogService)()
                End Get
            End Property
            Protected Overridable Sub AppendLogString(ByVal str As String)
                ' Update log
                Log &= str & Environment.NewLine
            End Sub
            Public Sub ShowFileDialog()
                ' Using the ISaveFileDialogService.ShowDialog method
                If Me.SaveFileDialogService.ShowDialog(AddressOf DialogFileOKCallback, String.Empty, String.Empty) Then
                    AppendLogString("Save file: " & Me.SaveFileDialogService.File.Name)
                Else
                    AppendLogString("Cancel")
                End If
            End Sub
            Public Overridable Property Log() As String
            Public Overridable Property Filter() As String
            Protected Overridable Sub OnFilterChanged()
                Me.SaveFileDialogService.Filter = Me.Filter
                AppendLogString("Set Filter: " & Me.Filter)
            End Sub
            Public Overridable Property FilterIndex() As Integer
            Protected Overridable Sub OnFilterIndexChanged()
                Me.SaveFileDialogService.FilterIndex = Me.FilterIndex
                AppendLogString("Set FilterIndex: " & Me.FilterIndex.ToString())
            End Sub
            Public Overridable Property Title() As String
            Protected Overridable Sub OnTitleChanged()
                Me.SaveFileDialogService.Title = Me.Title
                AppendLogString("Set Title: " & Me.Title)
            End Sub
            Protected Overridable Sub DialogFileOKCallback(ByVal e As System.ComponentModel.CancelEventArgs)
                MessageBox.Show("File is saved")
            End Sub
        End Class
    End Class
    <CodeExampleClass("FolderBrowser Dialog Service", "Services.vb"), CodeExampleHighlightTokens("IFolderBrowserDialogService", "Environment"), CodeExampleUnderlineTokens("ShowDialog"), CodeExampleVersionID(161)>
    Public NotInheritable Class FolderBrowserDialogService
        Private Sub New()
        End Sub
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim logMemoEdit As New MemoEdit()
            logMemoEdit.ReadOnly = True
            logMemoEdit.Dock = DockStyle.Fill
            logMemoEdit.Parent = sampleHost

            Dim showDialogButton As New SimpleButton()
            showDialogButton.Text = "Show Dialog"
            showDialogButton.Dock = DockStyle.Top
            showDialogButton.Parent = sampleHost

            Return New Object() {mvvmContext, showDialogButton, logMemoEdit}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Folder Browser Dialog Service", New Type() {GetType(FolderBrowserDialogViewModel)})>
        Public Shared Sub ShowFolderBrowserDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterFolderBrowserDialogService()

            mvvmContext.ViewModelType = GetType(FolderBrowserDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of FolderBrowserDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, FolderBrowserDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of FolderBrowserDialogViewModel)(showDialogButton, Sub(x) x.ShowFolderDialog())
        End Sub
        <CodeExampleCase("Compact Skinnable Folder Browser Dialog Service", New Type() {GetType(FolderBrowserDialogViewModel)}), CodeExampleVersionID(181)>
        Public Shared Sub ShowCompactSkinnableFolderBrowserDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterCompactSkinnableFolderBrowserDialogService()

            mvvmContext.ViewModelType = GetType(FolderBrowserDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of FolderBrowserDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, FolderBrowserDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of FolderBrowserDialogViewModel)(showDialogButton, Sub(x) x.ShowFolderDialog())
        End Sub
        <CodeExampleCase("Wide Skinnable Folder Browser Dialog Service", New Type() {GetType(FolderBrowserDialogViewModel)}), CodeExampleVersionID(181)>
        Public Shared Sub ShowWideSkinnableFolderBrowserDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            MVVMContext.RegisterWideSkinnableFolderBrowserDialogService()

            mvvmContext.ViewModelType = GetType(FolderBrowserDialogViewModel)
            Dim fluentApi = mvvmContext.OfType(Of FolderBrowserDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, FolderBrowserDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of FolderBrowserDialogViewModel)(showDialogButton, Sub(x) x.ShowFolderDialog())
        End Sub
        <CodeExampleCase("Custom FolderBrowserDialog", New Type() {GetType(FolderBrowserDialogViewModel)}), CodeExampleVersionID(191)>
        Public Shared Sub CreateCustomFolderBrowserDialog(ByVal mvvmContext As MVVMContext, ByVal showDialogButton As SimpleButton, ByVal logMemoEdit As MemoEdit)
            mvvmContext.ViewModelType = GetType(FolderBrowserDialogViewModel)

            ' Create a custom dialog
            Dim folderBrowserDialog = New FolderBrowserDialog()
            'Custom dialog ignores service settings
            folderBrowserDialog.ShowNewFolderButton = False
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.FolderBrowserDialogService.Create(folderBrowserDialog))

            Dim fluentApi = mvvmContext.OfType(Of FolderBrowserDialogViewModel)()
            ' UI binding for memoEdit
            mvvmContext.SetBinding(Of MemoEdit, FolderBrowserDialogViewModel, String)(logMemoEdit, Function(le) le.Text, Function(x) x.Log)
            ' UI binding for button
            mvvmContext.BindCommand(Of FolderBrowserDialogViewModel)(showDialogButton, Sub(x) x.ShowFolderDialog())
        End Sub
        <CodeExampleNestedClass>
        Public Class FolderBrowserDialogViewModel
            Protected ReadOnly Property FolderBrowserDialogService() As IFolderBrowserDialogService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IFolderBrowserDialogService)()
                End Get
            End Property
            Public Overridable Property Log() As String
            Protected Overridable Sub AppendLogString(ByVal str As String)
                ' Update log
                Log &= str & Environment.NewLine
            End Sub
            Public Sub ShowFolderDialog()
                If Me.FolderBrowserDialogService.ShowDialog() Then
                    AppendLogString("Folder path: " & Me.FolderBrowserDialogService.ResultPath)
                Else
                    AppendLogString("Cancel")
                End If
            End Sub
        End Class
    End Class

    <CodeExampleClass("Custom Services", "Services.vb"), CodeExampleHighlightTokens("CustomService", "ICustomService", "ServiceProperty"), CodeExampleUnderlineTokens("RegisterService")>
    Public NotInheritable Class CustomServices
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mvvmContext As New MVVMContext()
            mvvmContext.ContainerControl = sampleHost

            Dim commandButton As New SimpleButton()
            commandButton.Text = "Execute Command"
            commandButton.Dock = DockStyle.Top
            commandButton.Parent = sampleHost
            Return New Object() {mvvmContext, commandButton}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then
                context.Dispose()
            End If
        End Sub
        <CodeExampleCase("Custom Service", New Type() {GetType(ViewModelWithCustomService), GetType(ICustomService), GetType(CustomService)})>
        Public Shared Sub UseCustomService(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithCustomService)
            ' Custom service registration
            mvvmContext.RegisterService(New CustomService())
            ' UI binding for button
            mvvmContext.BindCommand(Of ViewModelWithCustomService)(commandButton, Sub(x) x.DoSomethingViaCustomService())
        End Sub
        <CodeExampleCase("Custom Service with Key", New Type() {GetType(ViewModelWithKeyedCustomService), GetType(ICustomService), GetType(CustomService)})>
        Public Shared Sub UseCustomServiceWithKey(ByVal mvvmContext As MVVMContext, ByVal commandButton As SimpleButton)
            mvvmContext.ViewModelType = GetType(ViewModelWithKeyedCustomService)
            ' Custom service registration
            mvvmContext.RegisterService("SomeKey1", New CustomService("Custom Service 1"))
            mvvmContext.RegisterService("SomeKey2", New CustomService("Custom Service 2"))
            ' UI binding for button
            mvvmContext.BindCommand(Of ViewModelWithKeyedCustomService)(commandButton, Sub(x) x.DoSomethingViaCustomServices())
        End Sub
        <CodeExampleNestedClass>
        Public Interface ICustomService
            Sub DoSomething()
        End Interface
        <CodeExampleNestedClass>
        Public Class CustomService
            Implements ICustomService

            Private text As String
            Public Sub New(Optional ByVal text As String = Nothing)
                Me.text = text
            End Sub
            Public Sub DoSomething() Implements ICustomService.DoSomething
                XtraMessageBox.Show("Hi!", If(text, "CustomService"))
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ViewModelWithCustomService
            Public Sub DoSomethingViaCustomService()
                Me.GetService(Of ICustomService)().DoSomething()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ViewModelWithKeyedCustomService
            <DevExpress.MVVM.DataAnnotations.ServiceProperty(Key:="SomeKey1")>
            Protected Overridable ReadOnly Property CustomService1() As ICustomService
                Get
                    Throw New NotImplementedException()
                End Get
            End Property
            <DevExpress.MVVM.DataAnnotations.ServiceProperty(Key:="SomeKey2")>
            Protected Overridable ReadOnly Property CustomService2() As ICustomService
                Get
                    Throw New NotImplementedException()
                End Get
            End Property
            Public Sub DoSomethingViaCustomServices()
                CustomService1.DoSomething()
                CustomService2.DoSomething()
            End Sub
        End Class
    End Class
End Namespace
