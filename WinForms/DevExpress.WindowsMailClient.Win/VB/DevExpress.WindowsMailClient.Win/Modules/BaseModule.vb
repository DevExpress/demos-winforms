Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.WindowsMailClient.Win.Modules

    Public Class BaseModule
        Inherits XtraUserControl
        Implements ISupportViewModel

        Protected Sub New(ByVal viewModelType As Type, ByVal viewModel As Object)
            Me.New()
            mvvmContext.SetViewModel(viewModelType, viewModel)
            BindingContext = New BindingContext()
            OnInitServices()
        End Sub

        Protected Sub New(ByVal viewModelType As Type)
            Me.New()
            mvvmContext.ViewModelType = viewModelType
            BindingContext = New BindingContext()
            OnInitServices()
        End Sub

        Protected Function GetViewModel(Of TViewModel)() As TViewModel
            Return mvvmContext.GetViewModel(Of TViewModel)()
        End Function

        Protected Function GetParentViewModel(Of TViewModel)() As TViewModel
            Return mvvmContext.GetParentViewModel(Of TViewModel)()
        End Function

        Protected Overloads Function GetService(Of TService As Class)() As TService
            Return mvvmContext.GetService(Of TService)()
        End Function

        Protected Overridable Sub OnInitServices()
        End Sub

        Private ReadOnly Property ViewModel As Object Implements ISupportViewModel.ViewModel
            Get
                Return mvvmContext.GetViewModel(Of Object)()
            End Get
        End Property

        Private Sub ParentViewModelAttached() Implements ISupportViewModel.ParentViewModelAttached
            OnParentViewModelAttached()
        End Sub

#Region "for DesignTime"
        Private Sub ReleaseModule()
        End Sub

        Private Sub New()
            InitializeComponent()
        End Sub

        Protected Overridable Sub OnParentViewModelAttached()
        End Sub

        Protected Overridable Sub OnDisposing()
        End Sub

        Private components As System.ComponentModel.IContainer

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(components)
            Me.SuspendLayout()
            mvvmContext.ContainerControl = Me
            Name = "BaseModule"
            Me.ResumeLayout(False)
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            ReleaseMVVMContext()
            MyBase.OnHandleDestroyed(e)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                ReleaseMVVMContext()
                OnDisposing()
                If components IsNot Nothing Then components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Protected Overridable Sub OnMVVMContextReleasing()
        End Sub

        Private Sub ReleaseMVVMContext()
            DestroyUIUpdateTimer()
            If mvvmContext.IsViewModelCreated Then
                ReleaseModule()
                OnMVVMContextReleasing()
                mvvmContext.Dispose()
            End If
        End Sub

        Private updateTimer As Timer

        Protected Sub QueueUIUpdate()
            EnsureUIUpdateTimer()
            updateTimer.Stop()
            updateTimer.Start()
        End Sub

        Private Sub EnsureUIUpdateTimer()
            If updateTimer Is Nothing Then
                updateTimer = New Timer(components)
                updateTimer.Interval = GetUIUpdateDelay()
                AddHandler updateTimer.Tick, AddressOf OnUIUpdate
            End If
        End Sub

        Private Sub DestroyUIUpdateTimer()
            If updateTimer IsNot Nothing Then
                RemoveHandler updateTimer.Tick, AddressOf OnUIUpdate
                updateTimer.Stop()
                updateTimer.Dispose()
            End If

            updateTimer = Nothing
        End Sub

        Private Sub OnUIUpdate(ByVal sender As Object, ByVal e As EventArgs)
            updateTimer.Stop()
            OnDelayedUIUpdate()
        End Sub

        Protected Overridable Sub OnDelayedUIUpdate()
        End Sub

        Protected Overridable Function GetUIUpdateDelay() As Integer
            Return 250
        End Function
#End Region
    End Class
End Namespace
