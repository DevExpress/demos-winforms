using System.Windows.Forms;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MVVM.Demos.Views {
    [DevExpress.Utils.MVVM.UI.ViewType("TransactionCollectionView")]
    public partial class Transactions : UserControl {
        public Transactions() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluent = mvvmContext.OfType<DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel>();
            fluent.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded);
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);
            // We want to show loading-indicator when data is loading asynchronously
            fluent.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            // We want to proceed the Edit command when row double-clicked
            fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    x => x.Edit, x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as DevExpress.MVVM.Demos.Model.Transaction,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to show ribbon print preview when bbiPrintPreview clicked
            bbiPrintPreview.ItemClick += (s, e) => { gridControl.ShowRibbonPrintPreview(); };
            //We want to show RECORDS count on BarStaticItem
            fluent.SetBinding(bsiRecordsCount, item => item.Caption, x => x.Entities.Count,
                    count => string.Format("RECORDS : {0}", count));
            //We want to show PopupMenu when row clicked by right button
            gridView.RowClick += (s, e) =>
            {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s);
                }
            };
        }
    }
}
