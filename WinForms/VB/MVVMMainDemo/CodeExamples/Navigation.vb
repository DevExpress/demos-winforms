Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports System.Linq.Expressions

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("Navigation on Application Start", "Navigation.vb")>
    <CodeExampleVersionID(211)>
    <CodeExampleHighlightTokens("IDocumentManagerService,DocumentManagerService")>
    <CodeExampleUnderlineTokens("RegisterDefaultService", "Create", "UseDeferredLoading")>
    Public NotInheritable Class NavigationOnApplicationStart
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mainView As UserControl = New UserControl()
            mainView.Dock = DockStyle.Fill
            Dim mvvmContext As MVVMContext = New MVVMContext()
            mvvmContext.ContainerControl = mainView
            mvvmContext.ViewModelType = GetType(NavigationViewModel)
            Dim manager = New DocumentManager()
            Dim tabbedView = New TabbedView()
            manager.View = tabbedView
            manager.ContainerControl = mainView
            Return New Object() {sampleHost, mainView, mvvmContext, tabbedView}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then context.Dispose()
            Dim manager = DocumentManager.FromControl(sampleHost)
            If manager IsNot Nothing Then manager.Dispose()
        End Sub
        <CodeExampleCase("Open the specific module", New Type() {GetType(NavigationViewModel), GetType(ModuleBase), GetType(ModuleA), GetType(ModuleAViewModel)})>
        Public Shared Sub OpenDocument(ByVal sampleHost As XtraUserControl, ByVal mainView As UserControl, ByVal mvvmContext As MVVMContext, ByVal tabbedView As TabbedView)
            ' Service registration at the Application level
            mvvmContext.RegisterDefaultService(DocumentManagerService.Create(tabbedView))
            ' Binding the Load event to the specific command
            Dim fluent = mvvmContext.OfType(Of NavigationViewModel)()
            fluent.WithEvent(Of EventArgs)(mainView, "Load").EventToCommand(Sub(x) x.ShowModuleA())
            ' Adding View onto the samples host
            mainView.Parent = sampleHost
        End Sub
        <CodeExampleCase("Open the specific modules in deferred manner", New Type() {GetType(NavigationViewModel), GetType(ModuleBase), GetType(ModuleA), GetType(ModuleAViewModel), GetType(ModuleB), GetType(ModuleBViewModel), GetType(ModuleC), GetType(ModuleCViewModel)})>
        Public Shared Sub OpenDeferredDocuments(ByVal sampleHost As XtraUserControl, ByVal mainView As UserControl, ByVal mvvmContext As MVVMContext, ByVal tabbedView As TabbedView)
            ' Activating the Deferred Loading feature
            Dim service = DocumentManagerService.Create(tabbedView)
            service.UseDeferredLoading = DevExpress.Utils.DefaultBoolean.[True]
            ' Service registration at the Application level
            mvvmContext.RegisterDefaultService(service)
            ' Binding the Load event to the specific command
            Dim fluent = mvvmContext.OfType(Of NavigationViewModel)()
            fluent.WithEvent(Of EventArgs)(mainView, "Load").EventToCommand(Sub(x) x.ShowSomeModulesInDeferredManner())
            ' Adding View onto the samples host
            mainView.Parent = sampleHost
        End Sub
        <CodeExampleNestedClass>
        Public Class NavigationViewModel
            Protected ReadOnly Property DocumentManagerService As IDocumentManagerService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IDocumentManagerService)()
                End Get
            End Property
            ' Ids for modules
            Shared ReadOnly ID_ModuleA As Object = New Object()
            Shared ReadOnly ID_ModuleB As Object = New Object()
            Shared ReadOnly ID_ModuleC As Object = New Object()
            '
            Public Sub ShowModuleA()
                FindAndActivateModule(ID_ModuleA, "ModuleA", "Module A")
            End Sub
            Public Sub ShowSomeModulesInDeferredManner()
                FindAndActivateModule(ID_ModuleA, "ModuleA", "Module A")
                FindAndActivateModule(ID_ModuleB, "ModuleB", "Module B")
                FindAndActivateModule(ID_ModuleC, "ModuleC", "Module C")
            End Sub
            Sub FindAndActivateModule(ByVal id As Object, ByVal documentType As String, ByVal title As String)
                ' Find the specific module by its ID
                Dim document = DocumentManagerService.FindDocumentById(id)
                If document Is Nothing Then
                    ' create when there is no such module opened
                    document = DocumentManagerService.CreateDocument(documentType, parameter:=Nothing, parentViewModel:=Me)
                    document.Id = id
                    document.Title = title
                End If
                ' Show the specific module
                document.Show()
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        Public Class ModuleBase
            Inherits UserControl
            ReadOnly mvvmContext As MVVMContext
            Protected Sub New(ByVal text As String, ByVal viewModelType As Type)
                mvvmContext = New MVVMContext()
                mvvmContext.ContainerControl = Me
                mvvmContext.ViewModelType = viewModelType
                SuspendLayout()
                Dim label As LabelControl = New LabelControl()
                label.AutoSizeMode = LabelAutoSizeMode.None
                label.Dock = DockStyle.Fill
                label.Parent = Me
                label.Text = text
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                ResumeLayout()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleA
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("Module A", GetType(ModuleAViewModel))
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleB
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("Module B", GetType(ModuleBViewModel))
                ' Do something important/time-consuming
                Threading.Thread.Sleep(1000)
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleC
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("Module C", GetType(ModuleCViewModel))
                ' Do something important/time-consuming
                Threading.Thread.Sleep(1000)
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        Public Class ModuleAViewModel
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleBViewModel
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleCViewModel
        End Class
    End Class

    <CodeExampleClass("Navigation to the same type of view", "Navigation.cs")>
    <CodeExampleVersionID(211)>
    <CodeExampleHighlightTokens("WindowedDocumentManagerService", "IDocumentContent")>
    <CodeExampleUnderlineTokens("RegisterService", "Create")>
    Public NotInheritable Class NavigationToTheSameTypeOfView
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mainView As UserControl = New UserControl()
            mainView.Dock = DockStyle.Fill
            '
            Dim mvvmContext As MVVMContext = New MVVMContext()
            mvvmContext.ContainerControl = mainView
            mvvmContext.ViewModelType = GetType(ContactsViewModel)
            '
            Dim manager = New DocumentManager()
            Dim tabbedView = New TabbedView()
            manager.View = tabbedView
            manager.ContainerControl = mainView
            '
            Dim showBtn As SimpleButton = New SimpleButton()
            showBtn.Dock = System.Windows.Forms.DockStyle.Bottom
            showBtn.Parent = mainView
            '
            Return New Object() {sampleHost, mainView, mvvmContext, tabbedView, showBtn}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then context.Dispose()
            Dim manager = DocumentManager.FromControl(sampleHost)
            If manager IsNot Nothing Then manager.Dispose()
        End Sub

        <CodeExampleCase("Open or activate the specific contact", New Type() {GetType(ContactsViewModel), GetType(ContactModule), GetType(ContactModuleViewModel)})>
        Public Shared Sub ShowContact(ByVal sampleHost As XtraUserControl, ByVal mainView As UserControl, ByVal mvvmContext As MVVMContext, ByVal tabbedView As TabbedView, ByVal showBtn As SimpleButton)
            ' Local service registration
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView))
            ' Binding the Load event to the specific command
            Dim fluent = mvvmContext.OfType(Of ContactsViewModel)()
            fluent.BindCommand(showBtn, Sub(x) x.ShowContact())
            fluent.SetBinding(showBtn, Function(btn) btn.Text, Function(x) x.ShowContactTitle)
            ' Adding View onto the samples host
            mainView.Parent = sampleHost
        End Sub
        <CodeExampleNestedClass>
        Public Class ContactsViewModel
            Private Contacts As List(Of String)
            Public Sub New()
                Contacts = New List(Of String)
                Contacts.AddRange(New String() {
                    "John Smith",
                    "Marie Louis",
                    "Ann Baker",
                    "Mark Voo"
                })
            End Sub
            Protected ReadOnly Property DocumentManagerService As IDocumentManagerService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IDocumentManagerService)()
                End Get
            End Property
            '
            Private currentContactId As Integer
            Public ReadOnly Property ShowContactTitle As String
                Get
                    Return String.Format("Show contact #{0} of {1}", currentContactId + 1, Contacts.Count)
                End Get
            End Property
            Public Sub ShowContact()
                ' Find the specific opened contact by its ID
                Dim document = DocumentManagerService.FindDocumentById(currentContactId)
                If document Is Nothing Then
                    ' create when there is no such module opened
                    document = DocumentManagerService.CreateDocument("ContactView", parameter:=Contacts(currentContactId), parentViewModel:=Me)
                    document.Id = currentContactId
                    document.Title = "Contact #" & (currentContactId + 1).ToString()
                End If
                ' Show the specific module
                document.Show()
                currentContactId = (currentContactId + 1) Mod Contacts.Count
                Me.RaisePropertyChanged(Function(x) x.ShowContactTitle)
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        <DevExpress.Utils.MVVM.UI.ViewType("ContactView")>
        Public Class ContactModule
            Inherits UserControl
            Private mvvmContext As MVVMContext
            Private contactLabel As LabelControl
            Public Sub New()
                mvvmContext = New MVVMContext()
                mvvmContext.ContainerControl = Me
                mvvmContext.ViewModelType = GetType(ContactModuleViewModel)
                SuspendLayout()
                contactLabel = New LabelControl()
                contactLabel.AutoSizeMode = LabelAutoSizeMode.None
                contactLabel.Dock = DockStyle.Fill
                contactLabel.Parent = Me
                contactLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                contactLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                ResumeLayout()
                If Not mvvmContext.IsDesignMode Then InitializeBinding()
            End Sub
            Sub InitializeBinding()
                Dim fluent = mvvmContext.OfType(Of ContactModuleViewModel)()
                contactLabel.Text = fluent.ViewModel.Contact
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ContactModuleViewModel
            Implements ISupportParameter
            Property Parameter As Object Implements ISupportParameter.Parameter
                Get
                    Return Contact
                End Get
                Set(ByVal value As Object)
                    Contact = TryCast(value, String)
                End Set
            End Property
            Public Property Contact As String
        End Class
    End Class

    <CodeExampleClass("Navigation from one view to another", "Navigation.vb")>
    <CodeExampleVersionID(211)>
    <CodeExampleHighlightTokens("INavigationService,NavigationService")>
    <CodeExampleUnderlineTokens("RegisterDefaultService", "Create")>
    Public NotInheritable Class NavigationFromOneViewToAnother
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mainView As UserControl = New UserControl()
            mainView.Dock = DockStyle.Fill
            Dim mvvmContext As MVVMContext = New MVVMContext()
            mvvmContext.ContainerControl = mainView
            mvvmContext.ViewModelType = GetType(RootViewModel)
            Dim frame = New NavigationFrame()
            frame.Dock = DockStyle.Fill
            frame.Parent = mainView
            Return New Object() {sampleHost, mainView, mvvmContext, frame}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then context.Dispose()
            Dim manager = DocumentManager.FromControl(sampleHost)
            If manager IsNot Nothing Then manager.Dispose()
        End Sub
        <CodeExampleCase("Open the specific module and close previous", New Type() {GetType(RootViewModel), GetType(ModuleBase), GetType(ModuleViewModelBase), GetType(FirstModule), GetType(FirstModuleViewModel), GetType(SecondModule), GetType(SecondModuleViewModel), GetType(ThirdModule), GetType(ThirdModuleViewModel)}, GetType(ModuleViewModelBase))>
        Public Shared Sub OpenDocumentAndClosePrevious(ByVal sampleHost As XtraUserControl, ByVal mainView As UserControl, ByVal mvvmContext As MVVMContext, ByVal frame As NavigationFrame)
            ' Service registration at the Application level
            Dim service = NavigationService.Create(frame)
            mvvmContext.RegisterDefaultService(service)
            ' Binding the Load event to the specific command
            Dim fluent = mvvmContext.OfType(Of RootViewModel)()
            fluent.WithEvent(mainView, "Load").EventToCommand(Sub(x) x.OnLoad())
            ' Adding View onto the samples host
            mainView.Parent = sampleHost
        End Sub
        <CodeExampleNestedClass>
        Public Class RootViewModel
            Protected ReadOnly Property NavigationService As INavigationService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of INavigationService)()
                End Get
            End Property
            Public Sub OnLoad()
                NavigationService.Navigate("FirstModule", Nothing, Me)
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        Public MustInherit Class ModuleViewModelBase
            Implements ISupportNavigation
            Protected ReadOnly Property NavigationService As INavigationService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of INavigationService)()
                End Get
            End Property
            Protected MustOverride ReadOnly Property ModuleName As String
            Protected MustOverride ReadOnly Property NextModule As String
            Public Overridable Property Title As String
            Public Sub ShowNextModuleAndClose()
                ' get current document
                Dim document = TryCast(NavigationService.Current, IDocument)
                ' navigate to the next module and pass current name as parameter
                Dim rootViewModel = Me.GetParentViewModel(Of Object)()
                NavigationService.Navigate(NextModule, ModuleName, rootViewModel)
                If document IsNot Nothing Then
                    ' close document
                    NavigationService.ClearNavigationHistory()
                    document.Close(True)
                End If
            End Sub
            Public Property Parameter As Object Implements ISupportParameter.Parameter
            Sub OnNavigatedTo() Implements ISupportNavigation.OnNavigatedTo
                ' obtain previous module name from navigation parameter 
                Dim prevModule = TryCast(Parameter, String)
                If Not Equals(prevModule, Nothing) Then
                    Title = "Navigated from " & prevModule & ". Click to navigate to " & NextModule
                Else
                    Title = "Click to navigate to " & NextModule
                End If
            End Sub
            Sub OnNavigatedFrom() Implements ISupportNavigation.OnNavigatedFrom
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ModuleBase
            Inherits UserControl
            Private mvvmContext As MVVMContext
            Protected Sub New(ByVal text As String, ByVal viewModelType As Type)
                mvvmContext = New MVVMContext()
                mvvmContext.ContainerControl = Me
                mvvmContext.ViewModelType = viewModelType
                SuspendLayout()
                Dim nextButton As SimpleButton = New SimpleButton()
                nextButton.Dock = DockStyle.Bottom
                nextButton.Parent = Me
                Dim label As LabelControl = New LabelControl()
                label.AutoSizeMode = LabelAutoSizeMode.None
                label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                label.Dock = DockStyle.Fill
                label.Text = text
                label.Parent = Me
                If text.StartsWith("First") Then Me.BackColor = Color.FromArgb(&H30, Color.Red)
                If text.StartsWith("Second") Then Me.BackColor = Color.FromArgb(&H30, Color.Green)
                If text.StartsWith("Third") Then Me.BackColor = Color.FromArgb(&H30, Color.Blue)
                Me.Padding = New Padding(24)
                ResumeLayout()
                Dim fluent = mvvmContext.OfType(Of ModuleViewModelBase)()
                fluent.SetBinding(nextButton, Function(btn) btn.Text, Function(x) x.Title)
                fluent.BindCommand(nextButton, Sub(x) x.ShowNextModuleAndClose())
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class FirstModule
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("First Module", GetType(FirstModuleViewModel))
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class SecondModule
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("Second Module", GetType(SecondModuleViewModel))
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class ThirdModule
            Inherits ModuleBase
            Public Sub New()
                MyBase.New("Third Module", GetType(ThirdModuleViewModel))
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        Public Class FirstModuleViewModel
            Inherits ModuleViewModelBase
            Protected Overrides ReadOnly Property ModuleName As String
                Get
                    Return "FirstModule"
                End Get
            End Property
            Protected Overrides ReadOnly Property NextModule As String
                Get
                    Return "SecondModule"
                End Get
            End Property
        End Class
        <CodeExampleNestedClass>
        Public Class SecondModuleViewModel
            Inherits ModuleViewModelBase
            Protected Overrides ReadOnly Property ModuleName As String
                Get
                    Return "SecondModule"
                End Get
            End Property
            Protected Overrides ReadOnly Property NextModule As String
                Get
                    Return "ThirdModule"
                End Get
            End Property
        End Class
        <CodeExampleNestedClass>
        Public Class ThirdModuleViewModel
            Inherits ModuleViewModelBase
            Protected Overrides ReadOnly Property ModuleName As String
                Get
                    Return "ThirdModule"
                End Get
            End Property
            Protected Overrides ReadOnly Property NextModule As String
                Get
                    Return "FirstModule"
                End Get
            End Property
        End Class
    End Class

    <CodeExampleClass("Navigation to custom Form", "Navigation.cs")>
    <CodeExampleVersionID(211)>
    <CodeExampleHighlightTokens("WindowedDocumentManagerService", "IDocumentContent")>
    <CodeExampleUnderlineTokens("RegisterService", "Create")>
    Public NotInheritable Class NavigationToCustomView
        Shared Sub New()
            DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim mainView As UserControl = New UserControl()
            mainView.Padding = New System.Windows.Forms.Padding(24)
            mainView.Dock = System.Windows.Forms.DockStyle.Fill
            Dim mvvmContext As MVVMContext = New MVVMContext()
            mvvmContext.ContainerControl = mainView
            mvvmContext.ViewModelType = GetType(MainViewModel)
            Dim showBtn As SimpleButton = New SimpleButton()
            showBtn.Dock = System.Windows.Forms.DockStyle.Bottom
            showBtn.Parent = mainView
            showBtn.Text = "Show custom dialog form"
            Return New Object() {sampleHost, mainView, mvvmContext, showBtn}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim context = MVVMContext.FromControl(sampleHost)
            If context IsNot Nothing Then context.Dispose()
            Dim manager = DocumentManager.FromControl(sampleHost)
            If manager IsNot Nothing Then manager.Dispose()
        End Sub
        <CodeExampleCase("Open the specific modal form", New Type() {GetType(MainViewModel), GetType(AcceptForm), GetType(AcceptFormViewModel)}, GetType(MainViewModel))>
        Public Shared Sub OpenSpecificForm(ByVal sampleHost As XtraUserControl, ByVal mainView As UserControl, ByVal mvvmContext As MVVMContext, ByVal showBtn As SimpleButton)
            ' Service registration at the Application level
            Dim service = WindowedDocumentManagerService.Create(mainView)
            ' set up service for modal showing
            service.DocumentShowMode = WindowedDocumentManagerService.FormShowMode.Dialog
            mvvmContext.RegisterService(service)
            ' Binding button to the specific command
            Dim fluent = mvvmContext.OfType(Of MainViewModel)()
            fluent.BindCommand(showBtn, Sub(x) x.ShowAcceptDialog())
            ' Adding View onto the samples host
            mainView.Parent = sampleHost
        End Sub
        <CodeExampleNestedClass>
        Public Class MainViewModel
            Protected ReadOnly Property WindowedDocumentManagerService As IDocumentManagerService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IDocumentManagerService)()
                End Get
            End Property
            Protected ReadOnly Property MessageBoxService As IMessageBoxService
                ' using the GetService<> extension method for obtaining service instance
                Get
                    Return Me.GetService(Of IMessageBoxService)()
                End Get
            End Property
            Private id As Integer = 0
            Dim greeting As String = "Click the ""Accept"" button to accept this dialog, or ""Close"" to discard it."
            Public Sub ShowAcceptDialog()
                Dim viewModel = ViewModelSource.Create(Function() New AcceptFormViewModel(greeting))
                ' Find the specific module by its ID
                Dim document = WindowedDocumentManagerService.FindDocumentById(id = id + 1)
                If document Is Nothing Then
                    ' create the specific document and inject a viewmodel into this document
                    document = WindowedDocumentManagerService.CreateDocument(String.Empty, viewModel:=viewModel)
                    document.Id = id
                    document.Title = "Accept Dialog #" + id.ToString()
                End If
                ' Show the specific module (execution will be blocked here because of modeless)
                document.Show()
                If viewModel.Accepted Then
                    MessageBoxService.ShowMessage("Dialog accepted.")
                Else
                    MessageBoxService.ShowMessage("Dialog not accepted.")
                End If
            End Sub
        End Class
        '
        <CodeExampleNestedClass>
        <DevExpress.Utils.MVVM.UI.ViewType(GetType(AcceptFormViewModel))>
        Public Class AcceptForm
            Inherits XtraForm
            Private mvvmContext As MVVMContext
            Private acceptBtn As SimpleButton
            Private greetingLbl As LabelControl
            Public Sub New()
                mvvmContext = New MVVMContext()
                mvvmContext.ContainerControl = Me
                mvvmContext.ViewModelType = GetType(AcceptFormViewModel)
                AddHandler Me.mvvmContext.ViewModelSet, AddressOf OnViewModelSet
                SuspendLayout()
                acceptBtn = New SimpleButton()
                acceptBtn.Dock = System.Windows.Forms.DockStyle.Bottom
                acceptBtn.Parent = Me
                acceptBtn.Text = "Accept"
                greetingLbl = New LabelControl()
                greetingLbl.AutoSizeMode = LabelAutoSizeMode.None
                greetingLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                greetingLbl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                greetingLbl.Dock = System.Windows.Forms.DockStyle.Fill
                greetingLbl.Parent = Me
                AcceptButton = acceptBtn
                Me.Padding = New System.Windows.Forms.Padding(24)
                Me.ClientSize = New Size(750, 250)
                ResumeLayout()
            End Sub
            Sub OnViewModelSet(ByVal sender As Object, ByVal e As ViewModelSetEventArgs)
                Dim fluent = mvvmContext.OfType(Of AcceptFormViewModel)()
                greetingLbl.Text = fluent.ViewModel.Greeting
                fluent.BindCommand(acceptBtn, Sub(x) x.Accept())
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class AcceptFormViewModel
            Implements IDocumentContent
            Public Sub New(ByVal greeting As String)
                Me.Greeting = greeting
            End Sub
            Public Property Greeting As String
            Public Property Accepted As Boolean
            Public Sub Accept()
                Accepted = True
                DocumentOwner.Close(Me)
            End Sub
            <EditorBrowsable(EditorBrowsableState.Never)>
            Public Property DocumentOwner As IDocumentOwner Implements IDocumentContent.DocumentOwner
            Private ReadOnly Property Title As Object Implements IDocumentContent.Title
                Get
                    Return "Custom View"
                End Get
            End Property
            Private Sub OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
            End Sub
            Private Sub OnClose() Implements IDocumentContent.OnDestroy
            End Sub
        End Class
    End Class
End Namespace
