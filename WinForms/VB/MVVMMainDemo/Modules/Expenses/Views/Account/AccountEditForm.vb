Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.MVVM.Demos.Views
    <DevExpress.Utils.MVVM.UI.ViewType("AccountView")>
    Partial Public Class AccountEditForm
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()

            If Not mvvmContext.IsDesignMode Then
                InitBindings()
            End If
        End Sub
        Private Sub InitBindings()
            Dim fluent = mvvmContext.OfType(Of AccountViewModel)()
            fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
            fluent.SetObjectDataSourceBinding(bindingSource, Function(x) x.Entity, Sub(x) x.Update())
            'Populating the grid running in master-detail mode
            fluent.SetBinding(TransactionsGrid, Function(gc) gc.DataSource, Function(x) x.AccountTransactionDetails.Entities)
            '
            transactionsGridView.Columns("Account").Visible = False

            '			#Region "Transaction_Details Detail Collection"
            ' We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(transactionsGridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.AccountTransactionDetails.SelectedEntity, Function(args) TryCast(args.Row, DevExpress.MVVM.Demos.Model.Transaction), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
            'We want to proceed the Edit command when row double-clicked
            fluent.WithEvent(Of RowClickEventArgs)(transactionsGridView, "RowClick").EventToCommand(Sub(x) x.AccountTransactionDetails.Edit(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
            'We want to show PopupMenu when row clicked by right button
            AddHandler transactionsGridView.RowClick, Sub(s, e)
                                                                   If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                                       Transactions_DetailsPopUpMenu.ShowPopup(TransactionsGrid.PointToScreen(e.Location), s)
                                                                   End If
                                                               End Sub
            ' We want to show the OrdersOrder_DetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(TransactionsGrid, Function(g) g.DataSource, Function(x) x.AccountTransactionDetails.Entities)

            fluent.BindCommand(bbiTransaction_DetailsNew, Sub(x) x.AccountTransactionDetails.[New]())
            fluent.BindCommand(bbiTransaction_DetailsEdit, Sub(x) x.AccountTransactionDetails.Edit(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity)
            fluent.BindCommand(bbiTransaction_DetailsDelete, Sub(x) x.AccountTransactionDetails.Delete(Nothing), Function(x) x.AccountTransactionDetails.SelectedEntity)
            fluent.BindCommand(bbiTransaction_DetailsRefresh, Sub(x) x.AccountTransactionDetails.Refresh())
            '			#End Region

            AddHandler bbiCustomize.ItemClick, Sub(s, e)
                                                            dataLayout.ShowCustomizationForm()
                                                        End Sub
        End Sub

    End Class
End Namespace
