Imports System.Windows.Forms
Imports DevExpress.Utils.MVVM
Imports DevExpress.MVVM.Demos.ViewModels

Namespace DevExpress.MVVM.Demos.Views
    <DevExpress.Utils.MVVM.UI.ViewType("TransactionView")>
    Partial Public Class TransactionEditForm
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            If Not DesignMode Then
                InitBindings()
            End If
        End Sub
        Private Sub InitBindings()
            Dim fluent = mvvmContext.OfType(Of TransactionViewModel)()
            fluent.SetObjectDataSourceBinding(bindingSource, Function(x) x.Entity, Sub(x) x.Update())
            fluent.SetBinding(accountBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpAccounts.Entities)
            fluent.SetBinding(categoryBindingSource, Function(cbs) cbs.DataSource, Function(x) x.LookUpCategories.Entities)
        End Sub
    End Class
End Namespace
