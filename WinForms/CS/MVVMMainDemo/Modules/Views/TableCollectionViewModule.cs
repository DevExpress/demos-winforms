using System.Windows.Forms;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MVVM.Demos.Views {
    public partial class TableCollectionViewModule : TutorialControl {
        public TableCollectionViewModule() {
            InitializeComponent();
            if(!DesignMode)
                InitBindings();
            LoadSourceCode(sourceCode, "InitBindings");
        }
        void InitBindings() {
            // We want all child views, opened from this view, to be a RibbonUI-based (Double click rows to try this feature)
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(this));

            var fluent = mvvmContext.OfType<AccountCollectionViewModel>();
            // We want to show loading-indicator when data is loading asynchronously
            fluent.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluent.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);

            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as Model.Account,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick")
                .EventToCommand(
                    x => x.Edit, x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
        }
    }
}
