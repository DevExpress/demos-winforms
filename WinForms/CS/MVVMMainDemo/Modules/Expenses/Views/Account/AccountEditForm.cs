using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MVVM.Demos.Views {
    [DevExpress.Utils.MVVM.UI.ViewType("AccountView")]
    public partial class AccountEditForm : XtraUserControl {
        public AccountEditForm() {
            InitializeComponent();

            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<AccountViewModel>();
            fluent.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded);
            fluent.SetObjectDataSourceBinding(bindingSource, x => x.Entity, x => x.Update);
            //Populating the grid running in master-detail mode
            fluent.SetBinding(TransactionsGrid, gc => gc.DataSource, x => x.AccountTransactionDetails.Entities);
            //
            transactionsGridView.Columns["Account"].Visible = false;

            #region Transaction_Details Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(transactionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.AccountTransactionDetails.SelectedEntity,
                    args => args.Row as DevExpress.MVVM.Demos.Model.Transaction,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to proceed the Edit command when row double-clicked
            fluent.WithEvent<RowClickEventArgs>(transactionsGridView, "RowClick")
                         .EventToCommand(
                             x => x.AccountTransactionDetails.Edit, x => x.AccountTransactionDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            transactionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Transactions_DetailsPopUpMenu.ShowPopup(TransactionsGrid.PointToScreen(e.Location), s);
                }
            };
            // We want to show the OrdersOrder_DetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(TransactionsGrid, g => g.DataSource, x => x.AccountTransactionDetails.Entities);

            fluent.BindCommand(bbiTransaction_DetailsNew, x => x.AccountTransactionDetails.New);
            fluent.BindCommand(bbiTransaction_DetailsEdit, x => x.AccountTransactionDetails.Edit, x => x.AccountTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsDelete, x => x.AccountTransactionDetails.Delete, x => x.AccountTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsRefresh, x => x.AccountTransactionDetails.Refresh);
            #endregion

            bbiCustomize.ItemClick += (s, e) => dataLayout.ShowCustomizationForm();
        }
    }
}
