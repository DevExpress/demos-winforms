Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class TabControlModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation()
            End If
            AddHandler xtraTabControl.SelectedPageChanged, AddressOf xtraTabControl_SelectedPageChanged
            AddHandler ribbonControl.Merge, AddressOf ribbonControl_Merge
            LoadSourceCode(sourceCode, "InitializeNavigation")
        End Sub
        Private Sub xtraTabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs)
            If e.Page Is Nothing Then
                ribbonControl.UnMergeRibbon()
            Else
                Dim view = TryCast(CType(e.Page, XtraTabPage).Controls(0), UserControl)
                Dim childRibbon = TryCast(view.Controls.OfType(Of Control)().FirstOrDefault(Function(c) TypeOf c Is RibbonControl), RibbonControl)
                ribbonControl.MergeRibbon(childRibbon)
            End If
        End Sub
        Private Sub ribbonControl_Merge(ByVal sender As Object, ByVal e As XtraBars.Ribbon.RibbonMergeEventArgs)
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage
        End Sub
        Private Sub InitializeNavigation()
            ' We want the XtraTabControl to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(xtraTabControl))
            ' We want to use buttons in Ribbon to show the specific modules
            Dim fluentAPI = mvvmContext.OfType(Of ExpensesDbContextViewModel)()
            fluentAPI.BindCommand(biAccounts, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
            fluentAPI.BindCommand(biCategories, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
            fluentAPI.BindCommand(biTransactions, Sub(x, m) x.Show(m), Function(x) x.Modules(2))
            ' We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent(Of EventArgs)(Me, "Load").
                EventToCommand(Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)
        End Sub
        Private Sub xtraTabControl1_CloseButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim ea As PageEventArgs = TryCast(e, PageEventArgs)
            If ea IsNot Nothing Then
                Dim page As XtraTabPage = TryCast(ea.Page, XtraTabPage)
                If page IsNot Nothing Then
                    page.Dispose()
                End If
            End If
        End Sub
    End Class
End Namespace
