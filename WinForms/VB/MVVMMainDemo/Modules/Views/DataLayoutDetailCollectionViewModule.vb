Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class DataLayoutDetailCollectionViewModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()

            If Not mvvmContext.IsDesignMode Then
                InitBindings()
                'Here we will force first entity loading by its primary key
                MVVMContext.SetParameter(Me, CLng(2))
            End If
            LoadSourceCode(sourceCode, "InitBindings")
        End Sub
        Private Sub InitBindings()
            Dim fluent = mvvmContext.OfType(Of AccountViewModel)()
            ' We want all changes in editors to be synchronized with ViewModel state
            fluent.SetObjectDataSourceBinding(bindingSource, Function(x) x.Entity, Sub(x) x.Update())

            '			#Region "AccountTransactionDetails collection ViewModel bindings"
            'We want to show the Account's transactions collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(TransactionsGrid, Function(g) g.DataSource, Function(x) x.AccountTransactionDetails.Entities)

            transactionsGridView.Columns("Account").Visible = False
            'We want to synchronize the AccountTransactionDetails.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(transactionsGridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.AccountTransactionDetails.SelectedEntity, Function(args) TryCast(args.Row, Model.Transaction), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))

            'We want to proceed the Edit command when row double-clicked
            fluent.WithEvent(Of RowClickEventArgs)(transactionsGridView, "RowClick").EventToCommand(Sub(x) x.AccountTransactionDetails.Edit(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
            'We want to proceed all the commands related to the Account's transactions collection 
            fluent.BindCommand(bbiTransaction_DetailsNew, Sub(x) x.AccountTransactionDetails.[New]())
            fluent.BindCommand(bbiTransaction_DetailsEdit, Sub(x) x.AccountTransactionDetails.Edit(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity)
            fluent.BindCommand(bbiTransaction_DetailsDelete, Sub(x) x.AccountTransactionDetails.Delete(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity)
            fluent.BindCommand(bbiTransaction_DetailsRefresh, Sub(x) x.AccountTransactionDetails.Refresh())
            'We want to show PopupMenu when row clicked by right button
            AddHandler transactionsGridView.RowClick, Sub(s, e)
                                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                              Transactions_DetailsPopUpMenu.ShowPopup(TransactionsGrid.PointToScreen(e.Location), s)
                                                          End If
                                                      End Sub
            '			#End Region
        End Sub
    End Class
End Namespace
