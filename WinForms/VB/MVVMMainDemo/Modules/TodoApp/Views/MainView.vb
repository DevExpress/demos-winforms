Imports DevExpress.XtraEditors
Imports TodoApp.ViewModels

Namespace TodoApp
    Public Partial Class MainView
        Inherits XtraForm
        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation()
                InitializeBindings()
            End If
        End Sub
        Sub InitializeNavigation()
            Dim navigationService = DevExpress.Utils.MVVM.Services.NavigationService.Create(navigationFrame)
            mvvmContext.RegisterService(navigationService)
        End Sub
        Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of AppViewModel)()
            fluent.WithEvent(CObj(Me), CStr("Shown")).EventToCommand(Function(x) x.OnShown())
            fluent.SetBinding(Me, Function(f) f.Text, Function(x) x.Title)
        End Sub
    End Class
End Namespace
