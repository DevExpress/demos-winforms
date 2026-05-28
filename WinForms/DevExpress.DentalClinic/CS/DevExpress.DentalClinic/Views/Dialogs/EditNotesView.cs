using DevExpress.DentalClinic.ViewModel;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class EditNotesView : XtraUserControl {
        public EditNotesView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext.OfType<EditNotesViewModel>();
            fluentAPI.SetBinding(notesMemo, m => m.EditValue, x => x.Notes);
            fluentAPI.SetBinding(labelControl1, m => m.Text, x => x.Action);
            fluentAPI.BindCommand(sbSave, x => x.Save);
        }
    }
}
