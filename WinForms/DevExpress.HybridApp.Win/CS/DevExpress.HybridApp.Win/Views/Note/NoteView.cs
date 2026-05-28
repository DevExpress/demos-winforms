using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Views {
    [DevExpress.Utils.MVVM.UI.ViewType(DevExpress.DevAV.ViewModels.DevAVDbViewModel.NoteViewDocumentType)]
    public partial class NoteView : XtraUserControl {
        public NoteView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<EvaluationViewModel>();
            fluentAPI.SetObjectDataSourceBinding(noteBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommand(saveSimpleButton, x => x.SaveAndClose());
            fluentAPI.BindCommand(cancelSimpleButton, x => x.Close());
            fluentAPI.SetBinding(assignedToLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
        }
    }
}
