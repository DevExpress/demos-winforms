using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MVVM.Demos.Views {
    public partial class DataLayoutDetailCollectionViewModule : TutorialControl {
        public DataLayoutDetailCollectionViewModule() {
            InitializeComponent();

            if(!mvvmContext.IsDesignMode) {
                InitBindings();
                //Here we will force first entity loading by its primary key
                MVVMContext.SetParameter(this, (long)2);
            }
            LoadSourceCode(sourceCode, "InitBindings");
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<AccountViewModel>();
            // We want all changes in editors to be synchronized with ViewModel state
            fluent.SetObjectDataSourceBinding(
                bindingSource, x => x.Entity, x => x.Update);
            
            #region AccountTransactionDetails collection ViewModel bindings
            //We want to show the Account's transactions collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(TransactionsGrid,
                g => g.DataSource, x => x.AccountTransactionDetails.Entities);
            
            transactionsGridView.Columns["Account"].Visible = false;
            //We want to synchronize the AccountTransactionDetails.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(transactionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.AccountTransactionDetails.SelectedEntity,
                    args => args.Row as Model.Transaction,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            
            //We want to proceed the Edit command when row double-clicked
            fluent.WithEvent<RowClickEventArgs>(transactionsGridView, "RowClick")
                         .EventToCommand(
                             x => x.AccountTransactionDetails.Edit, x => x.AccountTransactionDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to proceed all the commands related to the Account's transactions collection 
            fluent.BindCommand(bbiTransaction_DetailsNew, x => x.AccountTransactionDetails.New);
            fluent.BindCommand(bbiTransaction_DetailsEdit, x => x.AccountTransactionDetails.Edit, x => x.AccountTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsDelete, x => x.AccountTransactionDetails.Delete, x => x.AccountTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsRefresh, x => x.AccountTransactionDetails.Refresh);
            //We want to show PopupMenu when row clicked by right button
            transactionsGridView.RowClick += (s, e) =>
            {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                    Transactions_DetailsPopUpMenu.ShowPopup(TransactionsGrid.PointToScreen(e.Location), s);
            };
            #endregion
        }
    }
}
