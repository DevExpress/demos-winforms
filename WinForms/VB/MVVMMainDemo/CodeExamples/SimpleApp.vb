Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.Utils
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.DXperience.Demos

Namespace DevExpress.MVVM.Demos.CodeExamples
    <CodeExampleClass("Prerequisites, Implement a Data Model", "SimpleApp.vb")>
    Public Class SimpleApp_Prerequisites
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim schema = New DevExpress.XtraEditors.PictureEdit()
            schema.Dock = System.Windows.Forms.DockStyle.Fill
            schema.BackColor = System.Drawing.Color.Transparent
            schema.Properties.AllowFocused = False
            schema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            schema.Properties.[ReadOnly] = True
            schema.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            schema.SvgImage = DevExpress.Tutorials.TodoApp.Assets.DataModel
            schema.Name = "schema"
            schema.Parent = sampleHost
            Dim repository As IRepository = Nothing
            Return New Object() {repository}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            ' do nothing 
        End Sub

        <CodeExampleCase("Example 1, How to retrieve the data source records count", New Type() {GetType(TodoItem), GetType(IRepository)}), TodoAppDescription("DataModel")>
        Public Sub QueryItemsCount(ByVal repository As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)
            ' The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            If repository IsNot Nothing Then
                ' Query all items count
                Dim allItemsCount As Integer = repository.Count()
                ' Query completed items count only
                Dim completedItemsCount As Integer = repository.Count(Function(x) x.IsCompleted)
            End If
        End Sub
        <CodeExampleCase("Example 2, How to load items from a source", New System.Type() {GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem), GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)}), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("DataModel")>
        Public Sub LoadItems(ByVal repository As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)
            ' External option
            Dim showAll As Boolean = True

            ' The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            If repository IsNot Nothing Then

                If showAll Then
                    ' Load all items 
                    Dim allItems = repository.LoadItems()
                Else
                    ' Load incompleted items only
                    Dim incompletedItems = repository.LoadItems(Function(x) Not x.IsCompleted)
                End If
            End If
        End Sub
        <CodeExampleCase("Example 3, How to load or save a specific source item", New System.Type() {GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem), GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)}), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("DataModel")>
        Public Sub LoadingAndSavingItem(ByVal repository As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)
            ' External parameter
            Dim itemId As Integer = 42

            ' The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            If repository IsNot Nothing Then
                ' Load the specific item 
                Dim item As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem = repository.LoadItem(itemId)
                ' Working with item
                item.Description = "Some Description"

                ' Tracking changes
                If repository.HasChanges(itemId, item) Then
                    ' Updating our item
                    repository.Save(item)
                End If
            End If
        End Sub
        <CodeExampleCase("Example 4, How to create a new data source record", New System.Type() {GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem), GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository), GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.AppModel)}, HiddenTypes:="AppModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("DataModel")>
        Public Sub CreatingAndSavingNewItem(ByVal repository As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)
            ' The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            If repository IsNot Nothing Then
                ' Get a new item instance
                Dim newItem As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem = repository.LoadItem(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.AppModel.NewItemID)
                ' Initializing item fields
                newItem.Title = "Do something"
                newItem.Description = "Some Description"
                ' Saving new item to data storage
                Dim savedId As Integer = repository.Save(newItem)
                ' Further use the resulting id
                Dim savedItem As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem = repository.LoadItem(savedId)
            End If
        End Sub
        <CodeExampleCase("Example 5, How to delete a data source entity", New System.Type() {GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.TodoItem), GetType(DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)}), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("DataModel")>
        Public Sub DeletingItem(ByVal repository As DevExpress.MVVM.Demos.CodeExamples.SimpleApp_Prerequisites.IRepository)
            ' External parameter
            Dim itemId As Integer = 5

            ' The code-snippet below demonstrates the API-usage scenario which we will use in our code later
            If repository IsNot Nothing Then

                ' Delete the specific item
                If repository.Delete(itemId) Then
                    ' Do something if item completely deleted
                End If
            End If
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class TodoItem
            Private _Id As Integer
            ' Deny direct item creation (available for data storage only)
            Protected Sub New(ByVal id As Integer)
                Me._Id = id
            End Sub
            ' Key field (for data storage).  Hidden from UI
            <Display(AutoGenerateField:=False)>
            Public ReadOnly Property Id As Integer
                Get
                    Return _Id
                End Get
            End Property
            ' Data fields
            Public Property Title As String
            Public Property Description As String
            Public Property IsCompleted As Boolean
        End Class
        <CodeExampleNestedClass>
        Public Interface IRepository
            ' Query count
            Function Count(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As Integer
            ' Items Loading
            Function LoadItems(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem)
            ' Item loading/reloading
            Function LoadItem(ByVal id As Integer) As TodoItem
            Function ReloadItem(ByVal items As IList(Of TodoItem), ByVal id As Integer) As TodoItem
            ' Change tracking
            Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean
            ' Update/Delete operations
            Function Save(ByVal item As TodoItem) As Integer
            Function Delete(ByVal id As Integer) As Boolean
        End Interface
        ' Hidden code
        <CodeExampleNestedClass>
        Public Class AppModel
            Public Const NewItemID As Integer = Integer.MinValue
        End Class
    End Class

    <CodeExampleClass("Step 1, Create the Main Application Form", "SimpleApp.vb")>
    <CodeExampleUnderlineTokens("SetBinding")>
    Public Class SimpleApp_Step1
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            ' Create mainView
            Dim mainView As MainView = New MainView()
            ' Show mainView as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView)
            '
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(mainView)
            Return New Object() {mvvmContext, mainView}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mainView = sampleHost.Controls.Find("MainView", True)

            For i As Integer = 0 To mainView.Length - 1
                mainView(CInt((i))).Dispose()
            Next
        End Sub

        <CodeExampleCase("Create the MainView", New System.Type() {GetType(MainView)}, Nothing, GetType(MainView)), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAppMainView")>
        Public Sub CreateAppMainView(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal mainView As MainView)
            ' Here we will write all our bindings
        End Sub
        <CodeExampleCase("Create the AppViewModel", New System.Type() {GetType(MainView), GetType(AppViewModel), GetType(InMemoryRepository)}, GetType(AppViewModel), GetType(MainView), HiddenTypes:="MainView;InMemoryRepository"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAppViewModelAndBindTheTitle")>
        Public Sub CreateAppViewModelAndBindTheTitle(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal mainView As MainView)
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of AppViewModel)()
            ' Bind the Title property to the Text
            fluent.SetBinding(mainView, Function(view) view.Text, Function(x) x.Title)
        End Sub

        <CodeExampleNestedClass>
        Public Class AppViewModel
            Shared Sub New()
                ' Registering  the global instance of IRepository service
                DevExpress.MVVM.ServiceContainer.[Default].RegisterService(New InMemoryRepository())
            End Sub
            ' This is ViewModel for our Application
            Public Sub New()
                Me.Title = "Getting started witn MVVM - Todo App"
            End Sub
            Public Property Title As String
        End Class
        <CodeExampleNestedClass>
        Partial Public Class MainView
            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Windows Form Designer generated code"
            ''' <summary>
            ''' Required method for Designer support - do not modify
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(AppViewModel)  ' #2
                ' 
                ' MainView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.ClientSize = New System.Drawing.Size(398, 255)
                Me.IconOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MinimizeBox = False
                Me.MaximizeBox = False
                Me.CloseBox = False
                Me.Text = "{Application Title}"
                Me.Name = "MainView"
                Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

            Protected Overrides ReadOnly Property ShowMode As DevExpress.XtraEditors.FormShowMode
                Get
                    Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
                End Get
            End Property
        End Class
        Partial Class MainView
            Inherits DevExpress.XtraEditors.XtraForm
            Public Sub New()
                Me.InitializeComponent()
                ' Initializing bindings only at runtime   // #2
                If Not Me.mvvmContext.IsDesignMode Then Me.InitializeBindings()              ' #2
                ' #2  
            End Sub
            Sub InitializeBindings()                    ' #2
                ' $CodeBehindInsertionLine$               // #2
            End Sub                                              ' #2
        End Class
        ' Hidden Code
        <CodeExampleNestedClass>
        Public Class InMemoryRepository
        End Class
    End Class

    <CodeExampleClass("Step 2, Create the Start Screen Form", "SimpleApp.vb")>
    <CodeExampleUnderlineTokens("SetBinding")>
    Public Class SimpleApp_Step2
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim mainView As AppLogoContainer = New AppLogoContainer()
            ' Create appLogo
            ' mainView emulates repository service (for demo purposes)
            DevExpress.MVVM.ServiceContainer.[Default].RegisterService(mainView)
            Dim appLogo As AppLogo = New AppLogo()
            appLogo.Dock = System.Windows.Forms.DockStyle.Fill
            appLogo.Parent = mainView
            ' Show AppLogoContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView)
            '
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(appLogo)
            Dim greetLabel As DevExpress.XtraEditors.LabelControl = TryCast(appLogo.Controls.Find("greetLabel", True)(0), DevExpress.XtraEditors.LabelControl)
            Return New Object() {mvvmContext, greetLabel}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mainView = sampleHost.Controls.Find("MainView", True)

            For i As Integer = 0 To mainView.Length - 1
                mainView(CInt((i))).Dispose()
            Next
        End Sub

        <CodeExampleCase("Create the AppLogo View", New System.Type() {GetType(AppLogo), GetType(AppLogoContainer), GetType(TodoItem), GetType(IRepository)}, Nothing, GetType(AppLogo), HiddenTypes:="AppLogoContainer;TodoItem;IRepository"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAppLogo")>
        Public Sub CreateAppLogo(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal greetLabel As DevExpress.XtraEditors.LabelControl)
            ' Here we will write all our bindings
        End Sub
        <CodeExampleCase("Create the AppLogoViewModel", New System.Type() {GetType(AppLogo), GetType(AppLogoViewModel), GetType(AppLogoContainer), GetType(TodoItem), GetType(IRepository)}, GetType(AppLogoViewModel), GetType(AppLogo), HiddenTypes:="AppLogo;AppLogoContainer;TodoItem;IRepository"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAndBindAppLogoViewModel")>
        Public Sub CreateAndBindAppLogoViewModel(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal greetLabel As DevExpress.XtraEditors.LabelControl)
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of AppLogoViewModel)()
            ' Bind the Greeting property to the label Text
            fluent.SetBinding(greetLabel, Function(lbl) lbl.Text, Function(x) x.Greeting)
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class AppLogoViewModel
            ' This is ViewModel for our Start Screen
            Protected ReadOnly Property Repository As IRepository
                Get
                    Return Me.GetRequiredService(Of IRepository)()
                End Get
            End Property
            Public ReadOnly Property Greeting As String
                Get
                    ' Read this count from DB
                    Dim uncompletedCount As Integer = Me.Repository.Count(Function(x) Not x.IsCompleted)
                    Return Size("Hello " & Environment.UserName & "!", 4) & DoubleLineBreak & Size("You have " & uncompletedCount.ToString() & " incompleted tasks for now.", 2) & DoubleLineBreak & Size("Have a good day!", 4)
                End Get
            End Property
            ' Helper method and constant for creating the html-string
            Const DoubleLineBreak As String = "<br><br>"
            Shared Function Size(ByVal text As String, ByVal delta As Integer) As String
                Return "<size=+" & delta.ToString() & ">" & text & "</size>"
            End Function
        End Class
        <CodeExampleNestedClass>
        Partial Class AppLogo
            ''' <summary> 
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary> 
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Component Designer generated code"
            ''' <summary> 
            ''' Required method for Designer support - do not modify 
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppLogo))
                Me.greetLabel = New DevExpress.XtraEditors.LabelControl()
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' greetLabel
                ' 
                Me.greetLabel.AllowHtmlString = True
                Me.greetLabel.Appearance.Options.UseTextOptions = True
                Me.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Me.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                Me.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
                Me.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill
                Me.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
                Me.greetLabel.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo
                Me.greetLabel.ImageOptions.SvgImageSize = New System.Drawing.Size(128, 128)
                Me.greetLabel.IndentBetweenImageAndText = 64
                Me.greetLabel.Location = New System.Drawing.Point(0, 0)
                Me.greetLabel.Name = "greetLabel"
                Me.greetLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 200)
                Me.greetLabel.Size = New System.Drawing.Size(398, 468)
                Me.greetLabel.TabIndex = 0
                Me.greetLabel.Text = "{Greeting}"
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(AppLogoViewModel) ' #2
                ' 
                ' AppLogo
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.greetLabel)
                Me.Name = "AppLogo"
                Me.Size = New System.Drawing.Size(398, 468)
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private greetLabel As DevExpress.XtraEditors.LabelControl
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        End Class
        Partial Public Class AppLogo
            Inherits DevExpress.XtraEditors.XtraUserControl
            Public Sub New()
                Me.InitializeComponent()
                ' Initializing bindings only at runtime   // #2
                If Not Me.mvvmContext.IsDesignMode Then Me.InitializeBindings()              ' #2
                ' #2  
            End Sub
            Sub InitializeBindings()                    ' #2
                ' $CodeBehindInsertionLine$               // #2
            End Sub                                              ' #2
        End Class
        ' Hidden code
        <CodeExampleNestedClass>
        Public Class AppLogoContainer
            Inherits DevExpress.XtraEditors.XtraForm
            Implements IRepository
            Public Sub New()
                Me.SuspendLayout()
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.ClientSize = New System.Drawing.Size(398, 255)
                Me.CloseBox = False
                Me.IconOptions.ShowIcon = False
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "MainView"
                Me.ResumeLayout(False)
            End Sub
            Protected Overrides ReadOnly Property ShowMode As DevExpress.XtraEditors.FormShowMode
                Get
                    Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
                End Get
            End Property
            Function Count(ByVal filter As System.Func(Of TodoItem, Boolean)) As Integer Implements IRepository.Count
                Return 3
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Interface IRepository
            Function Count(ByVal filter As System.Func(Of TodoItem, Boolean)) As Integer
        End Interface
        <CodeExampleNestedClass>
        Public Class TodoItem
            Public Property IsCompleted As Boolean
        End Class
    End Class

    <CodeExampleClass("Step 3, Implement Navigation Between Views", "SimpleApp.vb")>
    <CodeExampleUnderlineTokens("RegisterService", "EventToCommand")>
    <CodeExampleHighlightTokens("INavigationService", "NavigationService")>
    Public Class SimpleApp_Step3
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            ' Create mainView
            Dim mainView As MainView = New MainView()
            ' Show mainView as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView)
            '
            Dim mvvmContext As MVVMContext = MVVMContext.FromControl(mainView)
            Dim navigationFrame As NavigationFrame = TryCast(mainView.Controls.Find("navigationFrame", False)(0), NavigationFrame)
            ' explicit type resolution (for runtime code-examples only)
            AddHandler navigationFrame.QueryControl, Sub(s, e)
                                                         If Equals(e.ControlName, "AppLogo") Then e.Control = New AppLogo()
                                                     End Sub
            Return New Object() {mvvmContext, mainView, navigationFrame}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mainView = sampleHost.Controls.Find("MainView", True)
            For i As Integer = 0 To mainView.Length - 1
                mainView(CInt((i))).Dispose()
            Next
        End Sub

        <CodeExampleCase("Add a NavigationFrame and use the NavigationService", New Type() {GetType(MainView), GetType(AppViewModel), GetType(AppLogo), GetType(AppLogoViewModel)}, GetType(AppViewModel), GetType(MainView), HiddenTypes:="AppLogo;AppLogoViewModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("RegisteringNavigationService")>
        Public Sub RegisteringNavigationService(ByVal mvvmContext As MVVMContext, ByVal mainView As MainView, ByVal navigationFrame As NavigationFrame)
            ' creating the NavigationFrame as INavigationService
            Dim navigationServiceInstance = NavigationService.Create(navigationFrame)
            ' registering the service instance
            mvvmContext.RegisterService(navigationServiceInstance)
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of AppViewModel)()
            ' Bind the OnShown command to the Shown event
            fluent.WithEvent(mainView, "Shown").EventToCommand(Function(x) x.OnShown)
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class AppViewModel
            ' This is ViewModel for our Application
            Public Sub New()
                Me.Title = "Getting started witn MVVM - Todo App"
            End Sub
            Public Overridable Property Title As String
            Protected ReadOnly Property NavigationService As INavigationService
                Get
                    Return Me.GetService(Of DevExpress.MVVM.INavigationService)()
                End Get
            End Property
            Public Async Function OnShown() As Task
                ' Wait some time (for demo purposes)
                Await System.Threading.Tasks.Task.Delay(1000)
                ' Show AppLogo screen
                Me.NavigationService.Navigate("AppLogo", Nothing, Me, False)
                ' Wait some time before showing ItemsView
                Await Task.Delay(1000)
                ' TODO: we will uncomment these item in complete application
                ' NavigationService.Navigate("ItemsView", null, this, true)
            End Function
        End Class
        <CodeExampleNestedClass>
        Partial Public Class MainView
            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Windows Form Designer generated code"
            ''' <summary>
            ''' Required method for Designer support - do not modify
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
                Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.navigationFrame), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' navigationFrame
                ' 
                Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
                Me.navigationFrame.Location = New System.Drawing.Point(0, 0)
                Me.navigationFrame.Margin = New System.Windows.Forms.Padding(0)
                Me.navigationFrame.Name = "navigationFrame"
                Me.navigationFrame.SelectedPage = Nothing
                Me.navigationFrame.Size = New System.Drawing.Size(398, 468)
                Me.navigationFrame.TabIndex = 0
                Me.navigationFrame.Text = "navigationFrame1"
                Me.navigationFrame.TransitionAnimationProperties.FrameInterval = 2500
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(AppViewModel)
                ' 
                ' MainView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.ClientSize = New System.Drawing.Size(398, 255)
                Me.Controls.Add(Me.navigationFrame)
                Me.IconOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MinimizeBox = False
                Me.MaximizeBox = False
                Me.CloseBox = False
                Me.Name = "MainView"
                Me.Text = "{Application Title}"
                CType((Me.navigationFrame), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
            Private navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame

            Protected Overrides ReadOnly Property ShowMode As DevExpress.XtraEditors.FormShowMode
                Get
                    Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
                End Get
            End Property
        End Class
        Partial Class MainView
            Inherits DevExpress.XtraEditors.XtraForm

            Public Sub New()
                Me.InitializeComponent()

                ' Initializing bindings only at runtime   
                If Not Me.mvvmContext.IsDesignMode Then
                    Me.InitializeNavigation()
                    Me.InitializeBindings()
                End If
            End Sub

            Sub InitializeNavigation()
                ' $CodeBehindInsertionLine$
            End Sub

            Sub InitializeBindings()
                ' Initialize the Fluent API
                Dim fluent = Me.mvvmContext.OfType(Of AppViewModel)()
                ' Bind the Title property to the Text
                fluent.SetBinding(Me, Function(view) view.Text, Function(x) x.Title)
            End Sub
        End Class
        ' Hidden code
        <CodeExampleNestedClass>
        Public Class AppLogoViewModel
            ' This is ViewModel for our Start Screen
            Public ReadOnly Property Greeting As String
                Get
                    Dim uncompletedCount As Integer = 3 ' TODO: We will read this count from DB
                    Return Me.Size("Hello " & System.Environment.UserName & "!", 4) & AppLogoViewModel.DoubleLineBreak & Me.Size("You have " & uncompletedCount.ToString() & " incompleted tasks for now.", 2) & AppLogoViewModel.DoubleLineBreak & Me.Size("Have a good day!", 4)
                End Get
            End Property

            Const DoubleLineBreak As String = "<br><br>"

            Private Function Size(ByVal text As String, ByVal delta As Integer) As String
                Return "<size=+" & delta.ToString() & ">" & text & "</size>"
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class AppLogo
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
                ' Initializing bindings only at runtime   
                If Not Me.mvvmContext.IsDesignMode Then Me.InitializeBindings()
            End Sub

            Sub InitializeBindings()
                ' Initialize the Fluent API
                Dim fluent = mvvmContext.OfType(Of AppLogoViewModel)()
                ' Bind the Greeting property to the label Text
                fluent.SetBinding(greetLabel, Function(lbl) lbl.Text, Function(x) x.Greeting)
            End Sub

            ''' <summary> 
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary> 
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Component Designer generated code"
            ''' <summary> 
            ''' Required method for Designer support - do not modify 
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppLogo))
                Me.greetLabel = New DevExpress.XtraEditors.LabelControl()
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' greetLabel
                ' 
                Me.greetLabel.AllowHtmlString = True
                Me.greetLabel.Appearance.Options.UseTextOptions = True
                Me.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Me.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                Me.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
                Me.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill
                Me.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
                Me.greetLabel.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Logo
                Me.greetLabel.ImageOptions.SvgImageSize = New System.Drawing.Size(128, 128)
                Me.greetLabel.IndentBetweenImageAndText = 64
                Me.greetLabel.Location = New System.Drawing.Point(0, 0)
                Me.greetLabel.Name = "greetLabel"
                Me.greetLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 200)
                Me.greetLabel.Size = New System.Drawing.Size(398, 468)
                Me.greetLabel.TabIndex = 0
                Me.greetLabel.Text = "{Greeting}"
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(AppLogoViewModel)
                ' 
                ' AppLogo
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.greetLabel)
                Me.Name = "AppLogo"
                Me.Size = New System.Drawing.Size(398, 468)
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private greetLabel As DevExpress.XtraEditors.LabelControl
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        End Class
    End Class

    <CodeExampleClass("Step 4, Create the Items Screen", "SimpleApp.vb")>
    <CodeExampleUnderlineTokens("SetBinding", "EventToCommand")>
    Public Class SimpleApp_Step4
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim mainView As ItemsViewContainer = New ItemsViewContainer()
            ' mainView emulates repository service (for demo purposes)
            DevExpress.MVVM.ServiceContainer.[Default].RegisterService(mainView)
            ' Create itemsView
            Dim itemsView As ItemsView = New ItemsView()
            itemsView.Dock = System.Windows.Forms.DockStyle.Fill
            itemsView.Parent = mainView
            ' Show ItemsViewContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView)
            ' Resolving view controls
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(itemsView)
            Dim titleLabel As DevExpress.XtraEditors.LabelControl = TryCast(itemsView.Controls.Find("titleLabel", True)(0), DevExpress.XtraEditors.LabelControl)
            Dim toggleShowAll As DevExpress.XtraEditors.ToggleSwitch = TryCast(itemsView.Controls.Find("toggleShowAll", True)(0), DevExpress.XtraEditors.ToggleSwitch)
            Dim listBoxControl As DevExpress.XtraEditors.ListBoxControl = TryCast(itemsView.Controls.Find("listBoxControl", True)(0), DevExpress.XtraEditors.ListBoxControl)
            Dim todoItemBindingSource As System.Windows.Forms.BindingSource = itemsView.todoItemBindingSource
            Return New Object() {mvvmContext, titleLabel, toggleShowAll, listBoxControl, todoItemBindingSource}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mainView = sampleHost.Controls.Find("MainView", True)

            For i As Integer = 0 To mainView.Length - 1
                mainView(CInt((i))).Dispose()
            Next
        End Sub

        <CodeExampleCase("Create the ItemsView", New System.Type() {GetType(ItemsView), GetType(ItemsViewContainer), GetType(TodoItem), GetType(IRepository)}, Nothing, GetType(ItemsView), HiddenTypes:="ItemsViewContainer;TodoItem;IRepository"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateItemsView")>
        Public Sub CreateItemsView(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal titleLabel As DevExpress.XtraEditors.LabelControl, ByVal toggleShowAll As DevExpress.XtraEditors.ToggleSwitch, ByVal listBoxControl As DevExpress.XtraEditors.ListBoxControl, ByVal todoItemBindingSource As System.Windows.Forms.BindingSource)
            ' Here we will write all our bindings
        End Sub
        <CodeExampleCase("Create the ItemsViewModel", New System.Type() {GetType(ItemsView), GetType(ItemsViewModel), GetType(ItemsViewContainer), GetType(TodoItem), GetType(IRepository), GetType(AppModel)}, GetType(ItemsViewModel), GetType(ItemsView), HiddenTypes:="ItemsView;ItemsViewContainer;TodoItem;IRepository;AppModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAndBindItemsViewModel")>
        Public Sub CreateAndBindItemsViewModel(ByVal mvvmContext As MVVMContext, ByVal titleLabel As LabelControl, ByVal toggleShowAll As ToggleSwitch, ByVal listBoxControl As ListBoxControl, ByVal todoItemBindingSource As BindingSource)
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of ItemsViewModel)()
            ' Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, Function(lbl) lbl.Text, Function(x) x.Title)
            ' Bind the ShowAllItems option to the toggle switch
            fluent.SetBinding(toggleShowAll, Function(tgl) tgl.EditValue, Function(x) x.ShowAllItems)
            ' Bind data-items to listbox
            fluent.SetBinding(todoItemBindingSource, Function(bs) bs.DataSource, Function(x) x.Items)
            fluent.SetBinding(listBoxControl, Function(lb) lb.SelectedValue, Function(x) x.SelectedItem)
            ' Bind the Complete command to the context button click (with args propagation)
            'fluent.WithEvent(Of ContextItemClickEventArgs)(listBoxControl, "ContextButtonClick").EventToCommand(Of TodoItem)(Function(x) x.Complete, Function(args) TryCast(args.DataItem, TodoItem))
        End Sub
        '
        <CodeExampleNestedClass>
        Public Class ItemsViewModel
            Public Sub New()
                Me.Title = "What needs to be done?"
                Me.ShowAllItems = True
            End Sub
            Protected ReadOnly Property Repository As IRepository
                Get
                    Return Me.GetRequiredService(Of IRepository)()
                End Get
            End Property
            Sub ReloadItems(ByVal showAll As Boolean)
                Dim savedId As Integer = If((Me.SelectedItem IsNot Nothing), Me.SelectedItem.Id, AppModel.NewItemID)
                If showAll Then
                    Me.Items = Me.Repository.LoadItems()
                Else
                    Me.Items = Me.Repository.LoadItems(Function(x) Not x.IsCompleted)
                End If
                Me.SelectedItem = If(Me.Items.FirstOrDefault(Function(x) x.Id = savedId), Me.SelectedItem)
            End Sub
            Public Property Title As String
            Private _Items As IList(Of TodoItem)
            Public Overridable Property Items As IList(Of TodoItem)
                Get
                    Return _Items
                End Get
                Protected Set(ByVal value As IList(Of TodoItem))
                    _Items = value
                End Set
            End Property
            Public Overridable Property SelectedItem As TodoItem
            Public Overridable Property ShowAllItems As Boolean
            Protected Sub OnItemsChanged()
                Me.SelectedItem = Me.Items.FirstOrDefault()
            End Sub
            Protected Sub OnSelectedItemChanged()
                Me.RaiseCanExecuteChanged(Sub(x) x.Edit())
            End Sub
            Protected Sub OnShowAllItemsChanged()
                Me.ReloadItems(Me.ShowAllItems)
            End Sub
            Protected ReadOnly Property NavigationService As INavigationService
                Get
                    Return Me.GetService(Of DevExpress.MVVM.INavigationService)()
                End Get
            End Property
            Public Sub Complete(ByVal item As TodoItem)
                item.IsCompleted = True
                If Me.Repository.HasChanges(item.Id, item) Then
                    Me.Repository.Save(item)
                End If
            End Sub
            Public Sub [New]()
                ' TODO: we will uncomment this item in complete application
                ' NavigationService.Navigate("ItemView", AppModel.NewItemID, this);
            End Sub
            Public Function CanEdit() As Boolean
                Return Me.SelectedItem IsNot Nothing
            End Function
            Public Sub Edit()
                ' TODO: we will uncomment this item in complete application
                ' NavigationService.Navigate("ItemView", SelectedItem.Id, this);
            End Sub
        End Class
        <CodeExampleNestedClass>
        Partial Public Class ItemsView
            ''' <summary> 
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary> 
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Component Designer generated code"
            ''' <summary> 
            ''' Required method for Designer support - do not modify 
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim simpleContextButton1 As DevExpress.Utils.SimpleContextButton = New DevExpress.Utils.SimpleContextButton()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsView))
                Dim itemTemplateBase1 As DevExpress.XtraEditors.TableLayout.ItemTemplateBase = New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
                Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
                Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
                Dim templatedItemElement1 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
                Dim templatedItemElement2 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
                Dim templatedItemElement3 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
                Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
                Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
                Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
                Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
                Me.searchControl = New DevExpress.XtraEditors.SearchControl()
                Me.titleLabel = New DevExpress.XtraEditors.LabelControl()
                Me.toggleShowAll = New DevExpress.XtraEditors.ToggleSwitch()
                Me.footerPane = New DevExpress.Utils.Layout.TablePanel()
                Me.headerPane = New DevExpress.Utils.Layout.TablePanel()
                Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
                Me.todoItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.toggleShowAll.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.footerPane), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.footerPane.SuspendLayout()
                CType((Me.headerPane), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.headerPane.SuspendLayout()
                CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' listBoxControl
                ' 
                simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center
                simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Near
                simpleContextButton1.Id = New System.Guid("07615a42-60b8-4284-bc4c-d14067d2e65e")
                simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Unchecked
                simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(32, 32)
                simpleContextButton1.Name = "btnCheck"
                simpleContextButton1.Padding = New System.Windows.Forms.Padding(16)
                Me.listBoxControl.ContextButtons.Add(simpleContextButton1)
                Me.listBoxControl.DataSource = Me.todoItemBindingSource
                Me.listBoxControl.DisplayMember = "Title"
                Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
                Me.listBoxControl.ItemHeight = 48
                Me.listBoxControl.Location = New System.Drawing.Point(24, 74)
                Me.listBoxControl.Name = "listBoxControl"
                Me.listBoxControl.ShowFocusRect = False
                Me.listBoxControl.Size = New System.Drawing.Size(350, 344)
                Me.listBoxControl.TabIndex = 0
                tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
                tableColumnDefinition1.Length.Value = 48.0R
                tableColumnDefinition1.PaddingLeft = 16
                itemTemplateBase1.Columns.Add(tableColumnDefinition1)
                itemTemplateBase1.Columns.Add(tableColumnDefinition2)
                templatedItemElement1.ColumnIndex = 1
                templatedItemElement1.FieldName = "Title"
                templatedItemElement1.Text = "Title"
                templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
                templatedItemElement2.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText
                templatedItemElement2.Appearance.Normal.Options.UseForeColor = True
                templatedItemElement2.ColumnIndex = 1
                templatedItemElement2.FieldName = "Description"
                templatedItemElement2.RowIndex = 1
                templatedItemElement2.Text = "Description"
                templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
                templatedItemElement3.FieldName = "IsCompleted"
                templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
                templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale
                templatedItemElement3.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Checked
                templatedItemElement3.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
                templatedItemElement3.Text = "IsCompleted"
                templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
                templatedItemElement3.TextVisible = False
                itemTemplateBase1.Elements.Add(templatedItemElement1)
                itemTemplateBase1.Elements.Add(templatedItemElement2)
                itemTemplateBase1.Elements.Add(templatedItemElement3)
                itemTemplateBase1.Name = "ToDoItem"
                itemTemplateBase1.Rows.Add(tableRowDefinition1)
                itemTemplateBase1.Rows.Add(tableRowDefinition2)
                tableSpan1.RowSpan = 2
                itemTemplateBase1.Spans.Add(tableSpan1)
                Me.listBoxControl.Templates.Add(itemTemplateBase1)
                AddHandler Me.listBoxControl.CustomizeContextItem, New DevExpress.XtraEditors.ViewInfo.ListBoxControlContextButtonCustomizeEventHandler(AddressOf Me.OnListBoxControl_CustomizeContextItem)
                AddHandler Me.listBoxControl.CustomizeItem, New DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(AddressOf Me.OnListBoxControl_CustomizeItem)
                ' 
                ' searchControl
                ' 
                Me.searchControl.Client = Me.listBoxControl
                Me.searchControl.Dock = System.Windows.Forms.DockStyle.Top
                Me.searchControl.Location = New System.Drawing.Point(24, 50)
                Me.searchControl.Name = "searchControl"
                Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
                Me.searchControl.Properties.Client = Me.listBoxControl
                Me.searchControl.Properties.NullValuePrompt = "Start typing here to search..."
                Me.searchControl.Size = New System.Drawing.Size(350, 24)
                Me.searchControl.TabIndex = 1
                ' 
                ' titleLabel
                ' 
                Me.titleLabel.Appearance.FontSizeDelta = 4
                Me.titleLabel.Appearance.Options.UseFont = True
                Me.titleLabel.Appearance.Options.UseTextOptions = True
                Me.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Me.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
                Me.headerPane.SetColumn(Me.titleLabel, 0)
                Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
                Me.titleLabel.Location = New System.Drawing.Point(0, 0)
                Me.titleLabel.Margin = New System.Windows.Forms.Padding(0)
                Me.titleLabel.Name = "titleLabel"
                Me.headerPane.SetRow(Me.titleLabel, 0)
                Me.titleLabel.Size = New System.Drawing.Size(312, 38)
                Me.titleLabel.TabIndex = 2
                Me.titleLabel.Text = "{Title}"
                ' 
                ' toggleShowAll
                ' 
                Me.footerPane.SetColumn(Me.toggleShowAll, 1)
                Me.toggleShowAll.Dock = System.Windows.Forms.DockStyle.Fill
                Me.toggleShowAll.EditValue = True
                Me.toggleShowAll.Location = New System.Drawing.Point(194, 8)
                Me.toggleShowAll.Margin = New System.Windows.Forms.Padding(0)
                Me.toggleShowAll.Name = "toggleShowAll"
                Me.toggleShowAll.Properties.AllowFocused = False
                Me.toggleShowAll.Properties.AutoWidth = True
                Me.toggleShowAll.Properties.OffText = " Show All Tasks"
                Me.toggleShowAll.Properties.OnText = " Show All Tasks"
                Me.footerPane.SetRow(Me.toggleShowAll, 0)
                Me.toggleShowAll.Size = New System.Drawing.Size(156, 30)
                Me.toggleShowAll.TabIndex = 3
                ' 
                ' footerPane
                ' 
                Me.footerPane.AutoSize = True
                Me.footerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.footerPane.Controls.Add(Me.toggleShowAll)
                Me.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom
                Me.footerPane.Location = New System.Drawing.Point(24, 418)
                Me.footerPane.Margin = New System.Windows.Forms.Padding(0)
                Me.footerPane.Name = "footerPane"
                Me.footerPane.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
                Me.footerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.footerPane.Size = New System.Drawing.Size(350, 38)
                Me.footerPane.TabIndex = 4
                ' 
                ' headerPane
                ' 
                Me.headerPane.AutoSize = True
                Me.headerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.headerPane.Controls.Add(Me.btnNew)
                Me.headerPane.Controls.Add(Me.titleLabel)
                Me.headerPane.Dock = System.Windows.Forms.DockStyle.Top
                Me.headerPane.Location = New System.Drawing.Point(24, 12)
                Me.headerPane.Margin = New System.Windows.Forms.Padding(0)
                Me.headerPane.Name = "headerPane"
                Me.headerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.headerPane.Size = New System.Drawing.Size(350, 38)
                Me.headerPane.TabIndex = 5
                ' 
                ' btnNew
                ' 
                Me.btnNew.AllowFocus = False
                Me.btnNew.AutoSize = True
                Me.headerPane.SetColumn(Me.btnNew, 1)
                Me.btnNew.Dock = System.Windows.Forms.DockStyle.Fill
                Me.btnNew.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.[New]
                Me.btnNew.Location = New System.Drawing.Point(312, 0)
                Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
                Me.btnNew.Name = "btnNew"
                Me.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
                Me.headerPane.SetRow(Me.btnNew, 0)
                Me.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
                Me.btnNew.Size = New System.Drawing.Size(38, 38)
                Me.btnNew.TabIndex = 3
                ' 
                ' todoItemBindingSource
                ' 
                Me.todoItemBindingSource.DataSource = GetType(TodoItem)
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(ItemsViewModel) ' #2
                ' 
                ' ItemsView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.listBoxControl)
                Me.Controls.Add(Me.searchControl)
                Me.Controls.Add(Me.headerPane)
                Me.Controls.Add(Me.footerPane)
                Me.Name = "ItemsView"
                Me.Padding = New System.Windows.Forms.Padding(24, 12, 24, 12)
                Me.Size = New System.Drawing.Size(398, 468)
                CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.toggleShowAll.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.footerPane), System.ComponentModel.ISupportInitialize).EndInit()
                Me.footerPane.ResumeLayout(False)
                Me.footerPane.PerformLayout()
                CType((Me.headerPane), System.ComponentModel.ISupportInitialize).EndInit()
                Me.headerPane.ResumeLayout(False)
                Me.headerPane.PerformLayout()
                CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
                Me.PerformLayout()
            End Sub

#End Region
            Private listBoxControl As DevExpress.XtraEditors.ListBoxControl
            Private searchControl As DevExpress.XtraEditors.SearchControl
            Friend todoItemBindingSource As System.Windows.Forms.BindingSource
            Private titleLabel As DevExpress.XtraEditors.LabelControl
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
            Private toggleShowAll As DevExpress.XtraEditors.ToggleSwitch
            Private footerPane As DevExpress.Utils.Layout.TablePanel
            Private headerPane As DevExpress.Utils.Layout.TablePanel
            Private btnNew As DevExpress.XtraEditors.SimpleButton
        End Class
        Partial Class ItemsView
            Inherits DevExpress.XtraEditors.XtraUserControl
            Public Sub New()
                Me.InitializeComponent()
                ' Initializing bindings only at runtime    // #2
                If Not Me.mvvmContext.IsDesignMode Then Me.InitializeBindings()               ' #2
                ' #2
            End Sub
            Sub InitializeBindings()         ' #2
                ' $CodeBehindInsertionLine$    // #2
            End Sub                                   ' #2
            Sub OnListBoxControl_CustomizeItem(ByVal sender As Object, ByVal e As CustomizeTemplatedItemEventArgs)
                Dim item = TryCast(e.DataItem, TodoItem)
                If Not item.IsCompleted Then e.TemplatedItem.Elements("IsCompleted").ImageOptions.SvgImage = Nothing
            End Sub
            Sub OnListBoxControl_CustomizeContextItem(ByVal sender As Object, ByVal e As ListBoxControlContextButtonCustomizeEventArgs)
                Dim item = TryCast(e.Item, TodoItem)
                e.ContextItem.Visibility = If(item.IsCompleted, ContextItemVisibility.Hidden, ContextItemVisibility.Auto)
            End Sub
        End Class
        ' Hidden code
        <CodeExampleNestedClass>
        Public Class ItemsViewContainer
            Inherits DevExpress.XtraEditors.XtraForm
            Implements IRepository
            Public Sub New()
                Me.SuspendLayout()
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.ClientSize = New System.Drawing.Size(398, 255)
                Me.CloseBox = False
                Me.IconOptions.ShowIcon = False
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "MainView"
                Me.ResumeLayout(False)
            End Sub
            Protected Overrides ReadOnly Property ShowMode As DevExpress.XtraEditors.FormShowMode
                Get
                    Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
                End Get
            End Property
            ReadOnly items As BindingList(Of TodoItem) = New BindingList(Of TodoItem) From {
                New TodoItem() With {
                    .Id = 1,
                    .Title = "Task 1",
                    .Description = "some text 1"
                },
                New TodoItem() With {
                    .Id = 2,
                    .Title = "Task 2",
                    .Description = "some text 2"
                }
            }
            Function LoadItems(Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem) Implements IRepository.LoadItems
                Return Me.items
            End Function
            Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean Implements IRepository.HasChanges
                Return item.IsCompleted
            End Function
            Sub Save(ByVal item As TodoItem) Implements IRepository.Save
                Me.items.ResetBindings()
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Interface IRepository
            Function LoadItems(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem)
            Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean
            Sub Save(ByVal item As TodoItem)
        End Interface
        <CodeExampleNestedClass>
        Public Class TodoItem
            Public Property Id As Integer
            Public Property Title As String
            Public Property Description As String
            Public Property IsCompleted As Boolean
        End Class
        <CodeExampleNestedClass>
        Public Class AppModel
            Public Const NewItemID As Integer = Integer.MinValue
        End Class
    End Class

    <CodeExampleClass("Step 5, Create the Edit Item Screen", "SimpleApp.vb")>
    <CodeExampleUnderlineTokens("SetBinding", "BindCommand", "SetObjectDataSourceBinding")>
    Public Class SimpleApp_Step5
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim mainView As ItemViewContainer = New ItemViewContainer()
            ' mainView emulates repository service (for demo purposes)
            DevExpress.MVVM.ServiceContainer.[Default].RegisterService(mainView)
            ' Create itemView
            Dim itemView As ItemView = New ItemView()
            itemView.Dock = System.Windows.Forms.DockStyle.Fill
            itemView.Parent = mainView
            ' Show ItemsViewContainer as TopLevel=false
            DevExpress.Tutorials.TodoApp.PresentationHelper.CenterParent(sampleHost, mainView)
            ' Initializing the data-model
            DevExpress.Utils.MVVM.MVVMContext.SetParameter(itemView, 42)
            ' Resolving view controls
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(itemView)
            Dim titleLabel As DevExpress.XtraEditors.LabelControl = TryCast(itemView.Controls.Find("titleLabel", True)(0), DevExpress.XtraEditors.LabelControl)
            Dim btnBack As DevExpress.XtraEditors.SimpleButton = TryCast(itemView.Controls.Find("btnBack", True)(0), DevExpress.XtraEditors.SimpleButton)
            Dim btnSave As DevExpress.XtraEditors.SimpleButton = TryCast(itemView.Controls.Find("btnSave", True)(0), DevExpress.XtraEditors.SimpleButton)
            Dim btnDelete As DevExpress.XtraEditors.SimpleButton = TryCast(itemView.Controls.Find("btnDelete", True)(0), DevExpress.XtraEditors.SimpleButton)
            Dim todoItemBindingSource As System.Windows.Forms.BindingSource = itemView.todoItemBindingSource
            Return New Object() {mvvmContext, titleLabel, btnBack, btnSave, btnDelete, todoItemBindingSource}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mainView = sampleHost.Controls.Find("MainView", True)

            For i As Integer = 0 To mainView.Length - 1
                mainView(CInt((i))).Dispose()
            Next
        End Sub

        <CodeExampleCase("Create the ItemView", New System.Type() {GetType(ItemView), GetType(ItemViewContainer), GetType(TodoItem), GetType(IRepository)}, Nothing, GetType(ItemView), HiddenTypes:="ItemViewContainer;TodoItem;IRepository"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateItemView")>
        Public Sub CreateItemView(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal titleLabel As DevExpress.XtraEditors.LabelControl, ByVal btnBack As DevExpress.XtraEditors.SimpleButton, ByVal btnSave As DevExpress.XtraEditors.SimpleButton, ByVal btnDelete As DevExpress.XtraEditors.SimpleButton, ByVal todoItemBindingSource As System.Windows.Forms.BindingSource)
            ' Here we will write all our bindings
        End Sub
        <CodeExampleCase("Create the ItemViewModel", New System.Type() {GetType(ItemView), GetType(ItemViewModel), GetType(ItemViewContainer), GetType(TodoItem), GetType(IRepository), GetType(AppModel)}, GetType(ItemViewModel), GetType(ItemView), HiddenTypes:="ItemView;ItemViewContainer;TodoItem;IRepository;AppModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("CreateAndBindItemViewModel")>
        Public Sub CreateAndBindItemViewModel(ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal titleLabel As DevExpress.XtraEditors.LabelControl, ByVal btnBack As DevExpress.XtraEditors.SimpleButton, ByVal btnSave As DevExpress.XtraEditors.SimpleButton, ByVal btnDelete As DevExpress.XtraEditors.SimpleButton, ByVal todoItemBindingSource As System.Windows.Forms.BindingSource)
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of ItemViewModel)()
            ' Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, Function(lbl) lbl.Text, Function(x) x.Title)
            ' Bind commands to buttons
            fluent.BindCommand(btnBack, Sub(x) x.Close())
            fluent.BindCommand(btnSave, Sub(x) x.Save())
            fluent.BindCommand(btnDelete, Sub(x) x.Delete())
            ' Bind datasource to editors
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, Function(x) x.Item, Sub(x) x.Update())
        End Sub

        <CodeExampleNestedClass>
        Public Class ItemViewModel
            Implements DevExpress.MVVM.ISupportParameter
            Private _Item As TodoItem, _HasChanges As Boolean
            Property Parameter As Object Implements ISupportParameter.Parameter
                Get
                    Return Me.Item
                End Get
                Set(ByVal value As Object)
                    Me.ReloadItem(CInt(value))
                End Set
            End Property
            Protected ReadOnly Property Repository As IRepository
                Get
                    Return Me.GetRequiredService(Of IRepository)()
                End Get
            End Property
            Sub ReloadItem(ByVal id As Integer)
                Me.Item = Me.Repository.LoadItem(id)
            End Sub
            Public Overridable Property Item As TodoItem
                Get
                    Return _Item
                End Get
                Protected Set(ByVal value As TodoItem)
                    _Item = value
                End Set
            End Property
            Public Overridable Property HasChanges As Boolean
                Get
                    Return _HasChanges
                End Get
                Protected Set(ByVal value As Boolean)
                    _HasChanges = value
                End Set
            End Property
            Public ReadOnly Property Title As String
                Get
                    If Me.Item Is Nothing Then Return String.Empty
                    Dim suffix = (If(Me.HasChanges, "*", String.Empty))

                    If Me.IsNew Then
                        Return "New task" & suffix
                    Else
                        Return "Task #" & Me.Item.Id.ToString() & suffix
                    End If
                End Get
            End Property
            ReadOnly Property IsNew As Boolean
                Get
                    Return Me.Item.Id = AppModel.NewItemID
                End Get
            End Property
            Protected Sub OnItemChanged()
                Me.HasChanges = False
                Me.RaiseCanExecuteChanged(Sub(x) x.Save())
                Me.RaiseCanExecuteChanged(Sub(x) x.Delete())
                Me.RaisePropertyChanged(Function(x) x.Title)
            End Sub
            Protected Sub OnHasChangesChanged()
                Me.RaisePropertyChanged(Function(x) x.Title)
                Me.RaiseCanExecuteChanged(Sub(x) x.Save())
            End Sub
            Public Sub Update()
                Me.HasChanges = Me.Repository.HasChanges(Me.Item.Id, Me.Item)
            End Sub
            Public Function CanSave() As Boolean
                Return (Me.Item IsNot Nothing) AndAlso Me.HasChanges
            End Function
            Public Sub Save()
                Me.Repository.Save(Me.Item)
                Me.HasChanges = False
            End Sub
            Public Function CanDelete() As Boolean
                Return (Me.Item IsNot Nothing) AndAlso Not Me.IsNew
            End Function
            Public Sub Delete()
                If Me.Repository.Delete(Me.Item.Id) Then Me.Close()
            End Sub
            Protected ReadOnly Property NavigationService As INavigationService
                Get
                    Return Me.GetService(Of DevExpress.MVVM.INavigationService)()
                End Get
            End Property

            Public Sub Close()
                ' TODO: we will uncomment these item in complete application
                ' var document = NavigationService.Current as IDocument;
                ' NavigationService.GoBack();
                ' if(document != null)
                '    document.Close(true);
            End Sub
        End Class
        <CodeExampleNestedClass>
        Partial Public Class ItemView
            ''' <summary> 
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary> 
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
                End If

                MyBase.Dispose(disposing)
            End Sub

#Region "Component Designer generated code"
            ''' <summary> 
            ''' Required method for Designer support - do not modify 
            ''' the contents of this method with the code editor.
            ''' </summary>
            Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemView))
                Me.headerPane = New DevExpress.Utils.Layout.TablePanel()
                Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
                Me.titleLabel = New DevExpress.XtraEditors.LabelControl()
                Me.footerPane = New DevExpress.Utils.Layout.TablePanel()
                Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
                Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
                Me.dataPane = New DevExpress.Utils.Layout.TablePanel()
                Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
                Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
                Me.teTitle = New DevExpress.XtraEditors.TextEdit()
                Me.teDescription = New DevExpress.XtraEditors.MemoEdit()
                Me.tglCompleted = New DevExpress.XtraEditors.ToggleSwitch()
                Me.todoItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                CType((Me.headerPane), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.headerPane.SuspendLayout()
                CType((Me.footerPane), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.footerPane.SuspendLayout()
                CType((Me.dataPane), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.dataPane.SuspendLayout()
                CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.teDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.tglCompleted.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' headerPane
                ' 
                Me.headerPane.AutoSize = True
                Me.headerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50.0F)})
                Me.headerPane.Controls.Add(Me.btnBack)
                Me.headerPane.Controls.Add(Me.titleLabel)
                Me.headerPane.Controls.Add(Me.btnDelete)
                Me.headerPane.Controls.Add(Me.btnSave)
                Me.headerPane.Dock = System.Windows.Forms.DockStyle.Top
                Me.headerPane.Location = New System.Drawing.Point(24, 12)
                Me.headerPane.Margin = New System.Windows.Forms.Padding(0)
                Me.headerPane.Name = "headerPane"
                Me.headerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.headerPane.Size = New System.Drawing.Size(350, 38)
                Me.headerPane.TabIndex = 6
                ' 
                ' btnBack
                ' 
                Me.btnBack.AllowFocus = False
                Me.btnBack.AutoSize = True
                Me.headerPane.SetColumn(Me.btnBack, 0)
                Me.btnBack.Dock = System.Windows.Forms.DockStyle.Fill
                Me.btnBack.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Back
                Me.btnBack.Location = New System.Drawing.Point(0, 0)
                Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
                Me.btnBack.Name = "btnBack"
                Me.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
                Me.headerPane.SetRow(Me.btnBack, 0)
                Me.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
                Me.btnBack.Size = New System.Drawing.Size(38, 38)
                Me.btnBack.TabIndex = 3
                ' 
                ' titleLabel
                ' 
                Me.titleLabel.Appearance.FontSizeDelta = 4
                Me.titleLabel.Appearance.Options.UseFont = True
                Me.titleLabel.Appearance.Options.UseTextOptions = True
                Me.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Me.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
                Me.headerPane.SetColumn(Me.titleLabel, 1)
                Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Top
                Me.titleLabel.Location = New System.Drawing.Point(38, 0)
                Me.titleLabel.Margin = New System.Windows.Forms.Padding(0)
                Me.titleLabel.Name = "titleLabel"
                Me.titleLabel.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
                Me.headerPane.SetRow(Me.titleLabel, 0)
                Me.titleLabel.Size = New System.Drawing.Size(236, 38)
                Me.titleLabel.TabIndex = 2
                Me.titleLabel.Text = "{Title}"
                ' 
                ' footerPane
                ' 
                Me.footerPane.AutoSize = True
                Me.footerPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.footerPane.Controls.Add(Me.tglCompleted)
                Me.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom
                Me.footerPane.Location = New System.Drawing.Point(24, 418)
                Me.footerPane.Margin = New System.Windows.Forms.Padding(0)
                Me.footerPane.Name = "footerPane"
                Me.footerPane.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
                Me.footerPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F)})
                Me.footerPane.Size = New System.Drawing.Size(350, 38)
                Me.footerPane.TabIndex = 7
                ' 
                ' btnDelete
                ' 
                Me.btnDelete.AllowFocus = False
                Me.btnDelete.AutoSize = True
                Me.headerPane.SetColumn(Me.btnDelete, 2)
                Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
                Me.btnDelete.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Delete
                Me.btnDelete.Location = New System.Drawing.Point(274, 0)
                Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
                Me.btnDelete.Name = "btnDelete"
                Me.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
                Me.headerPane.SetRow(Me.btnDelete, 0)
                Me.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
                Me.btnDelete.Size = New System.Drawing.Size(38, 38)
                Me.btnDelete.TabIndex = 4
                ' 
                ' btnSave
                ' 
                Me.btnSave.AllowFocus = False
                Me.btnSave.AutoSize = True
                Me.headerPane.SetColumn(Me.btnSave, 3)
                Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
                Me.btnSave.ImageOptions.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Save
                Me.btnSave.Location = New System.Drawing.Point(312, 0)
                Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
                Me.btnSave.Name = "btnSave"
                Me.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
                Me.headerPane.SetRow(Me.btnSave, 0)
                Me.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
                Me.btnSave.Size = New System.Drawing.Size(38, 38)
                Me.btnSave.TabIndex = 3
                ' 
                ' dataPane
                ' 
                Me.dataPane.AutoSize = True
                Me.dataPane.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F)})
                Me.dataPane.Controls.Add(Me.lblDescription)
                Me.dataPane.Controls.Add(Me.lblTitle)
                Me.dataPane.Controls.Add(Me.teTitle)
                Me.dataPane.Controls.Add(Me.teDescription)
                Me.dataPane.Dock = System.Windows.Forms.DockStyle.Fill
                Me.dataPane.Location = New System.Drawing.Point(24, 50)
                Me.dataPane.Margin = New System.Windows.Forms.Padding(0)
                Me.dataPane.Name = "dataPane"
                Me.dataPane.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1.0F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26.0F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26.0F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.0F)})
                Me.dataPane.Size = New System.Drawing.Size(350, 368)
                Me.dataPane.TabIndex = 8
                ' 
                ' lblDescription
                ' 
                Me.lblDescription.Appearance.FontSizeDelta = 2
                Me.lblDescription.Appearance.Options.UseFont = True
                Me.lblDescription.Appearance.Options.UseTextOptions = True
                Me.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Me.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
                Me.dataPane.SetColumn(Me.lblDescription, 0)
                Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Top
                Me.lblDescription.Location = New System.Drawing.Point(0, 67)
                Me.lblDescription.Margin = New System.Windows.Forms.Padding(0)
                Me.lblDescription.Name = "lblDescription"
                Me.lblDescription.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
                Me.dataPane.SetRow(Me.lblDescription, 2)
                Me.lblDescription.Size = New System.Drawing.Size(350, 25)
                Me.lblDescription.TabIndex = 5
                Me.lblDescription.Text = "Description"
                ' 
                ' lblTitle
                ' 
                Me.lblTitle.Appearance.FontSizeDelta = 2
                Me.lblTitle.Appearance.Options.UseFont = True
                Me.lblTitle.Appearance.Options.UseTextOptions = True
                Me.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
                Me.dataPane.SetColumn(Me.lblTitle, 0)
                Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
                Me.lblTitle.Location = New System.Drawing.Point(0, 0)
                Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
                Me.lblTitle.Name = "lblTitle"
                Me.lblTitle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 4)
                Me.dataPane.SetRow(Me.lblTitle, 0)
                Me.lblTitle.Size = New System.Drawing.Size(350, 37)
                Me.lblTitle.TabIndex = 4
                Me.lblTitle.Text = "Title"
                ' 
                ' teTitle
                ' 
                Me.dataPane.SetColumn(Me.teTitle, 0)
                Me.teTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "Title", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
                Me.teTitle.Dock = System.Windows.Forms.DockStyle.Fill
                Me.teTitle.Location = New System.Drawing.Point(3, 40)
                Me.teTitle.Name = "teTitle"
                Me.teTitle.Properties.NullValuePrompt = "Enter task title here..."
                Me.teTitle.Properties.ValidateOnEnterKey = True
                Me.dataPane.SetRow(Me.teTitle, 1)
                Me.teTitle.Size = New System.Drawing.Size(344, 24)
                Me.teTitle.TabIndex = 2
                ' 
                ' teDescription
                ' 
                Me.dataPane.SetColumn(Me.teDescription, 0)
                Me.teDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "Description", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
                Me.teDescription.Dock = System.Windows.Forms.DockStyle.Fill
                Me.teDescription.Location = New System.Drawing.Point(0, 92)
                Me.teDescription.Margin = New System.Windows.Forms.Padding(0)
                Me.teDescription.Name = "teDescription"
                Me.teDescription.Properties.NullValuePrompt = "Enter task description here..."
                Me.teDescription.Properties.ValidateOnEnterKey = True
                Me.dataPane.SetRow(Me.teDescription, 3)
                Me.teDescription.Size = New System.Drawing.Size(350, 276)
                Me.teDescription.TabIndex = 3
                ' 
                ' tglCompleted
                ' 
                Me.footerPane.SetColumn(Me.tglCompleted, 1)
                Me.tglCompleted.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.todoItemBindingSource, "IsCompleted", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
                Me.tglCompleted.Dock = System.Windows.Forms.DockStyle.Fill
                Me.tglCompleted.EditValue = True
                Me.tglCompleted.Location = New System.Drawing.Point(202, 8)
                Me.tglCompleted.Margin = New System.Windows.Forms.Padding(0)
                Me.tglCompleted.Name = "tglCompleted"
                Me.tglCompleted.Properties.AllowFocused = False
                Me.tglCompleted.Properties.AutoWidth = True
                Me.tglCompleted.Properties.OffText = " Is Completed"
                Me.tglCompleted.Properties.OnText = " Is Completed"
                Me.footerPane.SetRow(Me.tglCompleted, 0)
                Me.tglCompleted.Size = New System.Drawing.Size(148, 30)
                Me.tglCompleted.TabIndex = 5
                ' 
                ' todoItemBindingSource
                ' 
                Me.todoItemBindingSource.DataSource = GetType(TodoItem)
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ContainerControl = Me
                Me.mvvmContext.ViewModelType = GetType(ItemViewModel) ' #2
                ' 
                ' ItemView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 17.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.Controls.Add(Me.dataPane)
                Me.Controls.Add(Me.footerPane)
                Me.Controls.Add(Me.headerPane)
                Me.Margin = New System.Windows.Forms.Padding(0)
                Me.Name = "ItemView"
                Me.Padding = New System.Windows.Forms.Padding(24, 12, 24, 12)
                Me.Size = New System.Drawing.Size(398, 468)
                CType((Me.headerPane), System.ComponentModel.ISupportInitialize).EndInit()
                Me.headerPane.ResumeLayout(False)
                Me.headerPane.PerformLayout()
                CType((Me.footerPane), System.ComponentModel.ISupportInitialize).EndInit()
                Me.footerPane.ResumeLayout(False)
                Me.footerPane.PerformLayout()
                CType((Me.dataPane), System.ComponentModel.ISupportInitialize).EndInit()
                Me.dataPane.ResumeLayout(False)
                CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.teDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.tglCompleted.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.todoItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
                Me.PerformLayout()
            End Sub

#End Region
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
            Private headerPane As DevExpress.Utils.Layout.TablePanel
            Private btnBack As DevExpress.XtraEditors.SimpleButton
            Private titleLabel As DevExpress.XtraEditors.LabelControl
            Private footerPane As DevExpress.Utils.Layout.TablePanel
            Private btnSave As DevExpress.XtraEditors.SimpleButton
            Private btnDelete As DevExpress.XtraEditors.SimpleButton
            Private dataPane As DevExpress.Utils.Layout.TablePanel
            Private lblDescription As DevExpress.XtraEditors.LabelControl
            Private lblTitle As DevExpress.XtraEditors.LabelControl
            Private teTitle As DevExpress.XtraEditors.TextEdit
            Private teDescription As DevExpress.XtraEditors.MemoEdit
            Friend todoItemBindingSource As System.Windows.Forms.BindingSource
            Private tglCompleted As DevExpress.XtraEditors.ToggleSwitch
        End Class
        Partial Class ItemView
            Inherits DevExpress.XtraEditors.XtraUserControl
            Public Sub New()
                Me.InitializeComponent()
                ' Initializing bindings only at runtime    // #2
                If Not Me.mvvmContext.IsDesignMode Then Me.InitializeBindings()               ' #2
                ' #2
            End Sub
            Sub InitializeBindings()         ' #2
                ' $CodeBehindInsertionLine$    // #2
            End Sub                                   ' #2
        End Class
        ' Hidden code
        <CodeExampleNestedClass>
        Public Class ItemViewContainer
            Inherits DevExpress.XtraEditors.XtraForm
            Implements IRepository
            Public Sub New()
                Me.SuspendLayout()
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.ClientSize = New System.Drawing.Size(398, 255)
                Me.CloseBox = False
                Me.IconOptions.ShowIcon = False
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "MainView"
                Me.ResumeLayout(False)
            End Sub
            Protected Overrides ReadOnly Property ShowMode As DevExpress.XtraEditors.FormShowMode
                Get
                    Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
                End Get
            End Property
            ReadOnly dataItem As TodoItem = New TodoItem() With {
                .Title = "Task 1",
                .Description = "Some description"
            }
            Function LoadItem(ByVal id As Integer) As TodoItem Implements IRepository.LoadItem
                Return New TodoItem() With {
                    .Id = id,
                    .Title = Me.dataItem.Title,
                    .Description = Me.dataItem.Description
                }
            End Function
            Function Delete(ByVal id As Integer) As Boolean Implements IRepository.Delete
                Return False
            End Function
            Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean Implements IRepository.HasChanges
                Return Not Equals(item.Title, Me.dataItem.Title) OrElse Not Equals(item.Description, Me.dataItem.Description) OrElse item.IsCompleted <> Me.dataItem.IsCompleted
            End Function
            Function Save(ByVal item As TodoItem) As Integer Implements IRepository.Save
                Me.dataItem.Title = item.Title
                Me.dataItem.Description = item.Description
                Me.dataItem.IsCompleted = item.IsCompleted
                Return item.Id
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Interface IRepository
            Function LoadItem(ByVal id As Integer) As TodoItem
            Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean
            Function Save(ByVal item As TodoItem) As Integer
            Function Delete(ByVal id As Integer) As Boolean
        End Interface
        <CodeExampleNestedClass>
        Public Class TodoItem
            Public Property Id As Integer
            Public Property Title As String
            Public Property Description As String
            Public Property IsCompleted As Boolean
        End Class
        <CodeExampleNestedClass>
        Public Class AppModel
            Public Const NewItemID As Integer = Integer.MinValue
        End Class
    End Class

    <CodeExampleClass("Step 6, Set Up Interaction Between ViewModels", "SimpleApp.vb")>
    <CodeExampleHighlightTokens("Messenger")>
    <CodeExampleUnderlineTokens("Send", "Register", "Unregister")>
    Public Class SimpleApp_Step6
        Sub New()
            DevExpress.MVVM.DelegateCommand.DefaultUseCommandManager = False
        End Sub
        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim schema = New DevExpress.XtraEditors.PictureEdit()
            schema.Dock = System.Windows.Forms.DockStyle.Fill
            schema.BackColor = System.Drawing.Color.Transparent
            schema.Properties.[ReadOnly] = True
            schema.Properties.AllowFocused = False
            schema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            schema.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            schema.SvgImage = DevExpress.Tutorials.TodoApp.Assets.Interoperations
            schema.Name = "schema"
            schema.Parent = sampleHost
            Dim recipient As Object = New Object()
            Return New Object() {recipient}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            ' do nothing 
        End Sub

        <CodeExampleCase("Send Messages from the ItemViewModel", New System.Type() {GetType(ItemViewModel), GetType(ItemsViewModel), GetType(ReloadRequired), GetType(TodoItem), GetType(IRepository), GetType(AppModel)}, HiddenTypes:="ItemsViewModel;TodoItem;IRepository;AppModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("SendingMessages")>
        Public Sub SendingMessages(ByVal recipient As Object)
            ' You can send the specific message via Send method
            Messenger.[Default].Send(ReloadRequired.All)
        End Sub
        <CodeExampleCase("Receive Messages in the ItemsViewModel", New System.Type() {GetType(ItemViewModel), GetType(ItemsViewModel), GetType(ReloadRequired), GetType(TodoItem), GetType(IRepository), GetType(AppModel)}, HiddenTypes:="ItemViewModel;TodoItem;IRepository;AppModel"), DevExpress.MVVM.Demos.CodeExamples.TodoAppDescription("RegisteringMessageRecipient")>
        Public Sub RegisteringMessageRecipient(ByVal recipient As Object)
            ' You can registering some viewModel as Messenger recepient
            Messenger.[Default].Register(Of ReloadRequired)(recipient, Sub(m)
                                                                           ' do something here
                                                                       End Sub)
            ' And you can stop listening messages when it required
            Messenger.[Default].Unregister(Of ReloadRequired)(recipient)
        End Sub

        <CodeExampleNestedClass>
        Public Class ItemViewModel
            Private _Item As TodoItem
            Protected ReadOnly Property Repository As IRepository
                Get
                    Return Me.GetRequiredService(Of IRepository)()
                End Get
            End Property
            Public Overridable Property Item As TodoItem
                Get
                    Return _Item
                End Get
                Protected Set(ByVal value As TodoItem)
                    _Item = value
                End Set
            End Property
            Public Sub Save()
                Dim isNew As Boolean = (Me.Item.Id = AppModel.NewItemID)
                Dim savedId As Integer = Me.Repository.Save(Me.Item)

                If isNew Then
                    ' Sending the ReloadRequired message for new item
                    Messenger.[Default].Send(ReloadRequired.FromNew(savedId))
                Else
                    ' Sending the ReloadRequired message for the specific item
                    Messenger.[Default].Send(ReloadRequired.FromId(savedId))
                End If
            End Sub
            Public Sub Delete()
                If Me.Repository.Delete(Me.Item.Id) Then
                    ' Sending the ReloadRequired message for all items
                    Messenger.[Default].Send(ReloadRequired.All)
                End If
            End Sub
            ' ... 
            ' Code from the previous steps
        End Class
        <CodeExampleNestedClass>
        Public Class ItemsViewModel
            Private _Items As IList(Of TodoItem)
            Public Sub New()
                ' Start listen the ReloadRequired message 
                Messenger.[Default].Register(Of ReloadRequired)(Me, New Action(Of ReloadRequired)(AddressOf Me.OnReloadRequired))
            End Sub
            Protected ReadOnly Property Repository As IRepository
                Get
                    Return Me.GetRequiredService(Of IRepository)()
                End Get
            End Property
            Public Overridable Property Items As IList(Of TodoItem)
                Get
                    Return _Items
                End Get
                Protected Set(ByVal value As IList(Of TodoItem))
                    _Items = value
                End Set
            End Property
            Public Overridable Property ShowAllItems As Boolean
            Sub OnReloadRequired(ByVal message As ReloadRequired)
                If message Is ReloadRequired.All OrElse message.IsNew Then
                    ' Reload all Items when new item added or explicit reload requested
                    If Me.ShowAllItems Then
                        Me.Items = Me.Repository.LoadItems()
                    Else
                        Me.Items = Me.Repository.LoadItems(Function(x) Not x.IsCompleted)
                    End If
                Else
                    ' Reload the specific item within the Items collection
                    Me.Repository.ReloadItem(Me.Items, message.Id)
                End If
            End Sub
            ' ... 
            ' Code from the previous steps
        End Class
        <CodeExampleNestedClass>
        Public Class ReloadRequired
            Public Shared ReadOnly All As ReloadRequired = New ReloadRequired(AppModel.NewItemID, False)
            Public Shared Function FromId(ByVal id As Integer) As ReloadRequired
                Return New ReloadRequired(id, False)
            End Function
            Public Shared Function FromNew(ByVal id As Integer) As ReloadRequired
                Return New ReloadRequired(id, True)
            End Function
            ' Deny direct instances creation
            Sub New(ByVal id As Integer, ByVal isNew As Boolean)
                Me._Id = id
                Me._IsNew = isNew
            End Sub
            Private _Id As Integer
            Public ReadOnly Property Id As Integer
                Get
                    Return _Id
                End Get
            End Property
            Private _IsNew As Boolean
            Public ReadOnly Property IsNew As Boolean
                Get
                    Return _IsNew
                End Get
            End Property
        End Class
        ' Hidden Code
        <CodeExampleNestedClass>
        Public Interface IRepository
            Function LoadItems(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem)
            Function ReloadItem(ByVal items As IList(Of TodoItem), ByVal id As Integer) As TodoItem
            Function Save(ByVal item As TodoItem) As Integer
            Function Delete(ByVal id As Integer) As Boolean
        End Interface
        <CodeExampleNestedClass>
        Public Class TodoItem
            Public Property Id As Integer
            Public Property IsCompleted As Boolean
        End Class
        <CodeExampleNestedClass>
        Public Class AppModel
            Public Const NewItemID As Integer = Integer.MinValue
        End Class
    End Class
End Namespace
