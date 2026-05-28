Imports System
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services

Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class DocumentManagerModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation()
            End If
            AddHandler ribbonControl.Merge, AddressOf ribbonControl_Merge
            LoadSourceCode(sourceCode, "InitializeNavigation")
        End Sub
        Private Sub ribbonControl_Merge(ByVal sender As Object, ByVal e As XtraBars.Ribbon.RibbonMergeEventArgs)
            e.MergedChild.Visible = False
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage
        End Sub
        Private Sub InitializeNavigation()
            ' We want the DocmentManager's TabbedView to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView))
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
