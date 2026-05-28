Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM

Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class DataLayoutViewModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitBindings()
                'Here we will force first entity loading by its primary key
                mvvmContext.SetParameter(Me, CLng(1))
            End If
            LoadSourceCode(sourceCode, "InitBindings")
        End Sub
        Private Sub InitBindings()
            Dim fluent = mvvmContext.OfType(Of TransactionViewModel)()
            ' We want all changes in editors to be synchronized with ViewModel state
            fluent.SetObjectDataSourceBinding(transactionBindingSource, Function(x) x.Entity, Sub(x) x.Update())
            ' We want user can select specific Account from LookUp
            fluent.SetBinding(accountBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpAccounts.Entities)
            ' We want user can select specific Category from LookUp
            fluent.SetBinding(categoryBindingSource, Function(cbs) cbs.DataSource, Function(x) x.LookUpCategories.Entities)
        End Sub
    End Class
End Namespace
