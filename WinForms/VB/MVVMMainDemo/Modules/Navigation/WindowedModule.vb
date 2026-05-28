Imports System
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class WindowedModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation()
            End If
            LoadSourceCode(sourceCode, "InitializeNavigation")
        End Sub
        Private Sub InitializeNavigation()
            ' We want the default WindowedDocumentManagerService based on RibbonForm to be a navigation provider
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(Me))
            ' We want to use buttons in Ribbon to show the specific modules
            Dim fluentAPI = mvvmContext.OfType(Of ExpensesDbContextViewModel)()
            fluentAPI.BindCommand(biAccounts, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
            fluentAPI.BindCommand(biCategories, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
            fluentAPI.BindCommand(biTransactions, Sub(x, m) x.Show(m), Function(x) x.Modules(2))
            ' We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent(Of EventArgs)(Me, "Load").
                EventToCommand(Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)
        End Sub
    End Class
End Namespace
