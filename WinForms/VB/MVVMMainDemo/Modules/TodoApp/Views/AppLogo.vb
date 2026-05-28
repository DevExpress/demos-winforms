Imports DevExpress.XtraEditors
Imports TodoApp.ViewModels

Namespace TodoApp.Views
    Public Partial Class AppLogo
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then InitializeBindings()
        End Sub
        Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of AppLogoViewModel)()
            fluent.SetBinding(greetLabel, Function(lbl) lbl.Text, Function(x) x.Greeting)
        End Sub
    End Class
End Namespace
