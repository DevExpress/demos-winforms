Imports DevExpress.XtraEditors
Imports TodoApp.ViewModels

Namespace TodoApp.Views
    Public Partial Class ItemView
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then InitializeBindings()
        End Sub
        Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of ItemViewModel)()
            fluent.BindCommand(btnBack, Sub(x) x.Close())
            fluent.BindCommand(btnSave, Sub(x) x.Save())
            fluent.BindCommand(btnDelete, Sub(x) x.Delete())
            fluent.SetBinding(titleLabel, Function(lbl) lbl.Text, Function(x) x.Title)
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, Function(x) x.Item, Sub(x) x.Update())
        End Sub
    End Class
End Namespace
