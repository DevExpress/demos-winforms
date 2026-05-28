using System.Windows.Forms;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class EmployeeView : XtraUserControl {
        public EmployeeView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext.OfType<EmployeeViewModel>();
            fluentAPI.SetBinding(xpBindingSource, x => x.DataSource, x => x.Employee);
            fluentAPI.BindCommand(sbSave, x => x.Save);
            fluentAPI.BindCommand(linkChangePassword, x => x.ChangePassword);
        }
    }
}
