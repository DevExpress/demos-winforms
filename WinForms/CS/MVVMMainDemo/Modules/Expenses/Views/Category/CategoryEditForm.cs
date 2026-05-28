using System.Windows.Forms;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MVVM.Demos.Views {
    [DevExpress.Utils.MVVM.UI.ViewType("CategoryView")]
    public partial class CategoryEditForm : UserControl {
        public CategoryEditForm() {
            InitializeComponent();
            this.TypeImageComboBoxEdit.Properties.Items.AddEnum<Model.TransactionType>();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            var fluent = mvvmContext.OfType<CategoryViewModel>();
            fluent.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded);
            fluent.SetObjectDataSourceBinding(
                bindingSource, x => x.Entity, x => x.Update);
            //Populating the grid running in master-detail mode
            fluent.SetBinding(
                TransactionsGrid, gc => gc.DataSource, x => x.CategoryTransactionDetails.Entities);
            //
            transactionsGridView.Columns["Category"].Visible = false;

            #region Transaction_Details Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(transactionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CategoryTransactionDetails.SelectedEntity,
                    args => args.Row as DevExpress.MVVM.Demos.Model.Transaction,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to proceed the Edit command when row double-clicked
            fluent.WithEvent<RowClickEventArgs>(transactionsGridView, "RowClick")
                         .EventToCommand(
                             x => x.CategoryTransactionDetails.Edit, x => x.CategoryTransactionDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            transactionsGridView.RowClick += (s, e) =>
            {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Transaction_DetailsPopUpMenu.ShowPopup(TransactionsGrid.PointToScreen(e.Location), s);
                }
            };
            // We want to show the OrdersOrder_DetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(TransactionsGrid, g => g.DataSource, x => x.CategoryTransactionDetails.Entities);

            fluent.BindCommand(bbiTransaction_DetailsNew, x => x.CategoryTransactionDetails.New);
            fluent.BindCommand(bbiTransaction_DetailsEdit, x => x.CategoryTransactionDetails.Edit, x => x.CategoryTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsDelete, x => x.CategoryTransactionDetails.Delete, x => x.CategoryTransactionDetails.SelectedEntity);
            fluent.BindCommand(bbiTransaction_DetailsRefresh, x => x.CategoryTransactionDetails.Refresh);
            #endregion

            bbiCustomize.ItemClick += (s, e) => dataLayout.ShowCustomizationForm();
        }
    }
}
