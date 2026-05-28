using System.Windows.Forms;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.DentalClinic.View {
    public partial class UserCollectionView : XtraUserControl {
        public UserCollectionView() {
            InitializeComponent();
            if(!mvvmContext1.IsDesignMode) {
                InitializeBindings();
            }
        }
        private void InitializeBindings() {
            var fluentApi = mvvmContext1.OfType<UserCollectionViewModel>();
            fluentApi.SetBinding(employeeBindingSource, pbs => pbs.DataSource, x => x.Users);
            fluentApi.SetBinding(employeeBindingSource, pbs => pbs.Current, x => x.SelectedEntity);
            fluentApi.BindCommand(sbEdit, x => x.Edit);
            // Interactions
            fluentApi.WithEvent<RowClickEventArgs>(gvPatients, "RowClick")
                .EventToCommand(x => x.Edit,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
        }
    }
}
