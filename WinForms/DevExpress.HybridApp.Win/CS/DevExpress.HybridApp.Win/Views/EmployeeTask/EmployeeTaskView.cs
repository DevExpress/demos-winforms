using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Views {
    [DevExpress.Utils.MVVM.UI.ViewType(DevExpress.DevAV.ViewModels.DevAVDbViewModel.EmployeeTaskViewDocumentType)]
    public partial class EmployeeTaskView : XtraUserControl {
        public EmployeeTaskView() {
            InitializeComponent();
            InitImages();
            dataLayoutControl.SetupLayoutControl();
            if (!mvvmContext.IsDesignMode) {
                InitBindings();
            }
        }
        void InitImages() {
            statusImageList.Clear();
            statusImageList.ImageSize = StatusIconsExtension.GetImage("Completed").Size;
            statusImageList.AddImage(StatusIconsExtension.GetImage("Completed"));
            statusImageList.AddImage(StatusIconsExtension.GetImage("Deferred"));
            statusImageList.AddImage(StatusIconsExtension.GetImage("InProgress"));
            statusImageList.AddImage(StatusIconsExtension.GetImage("NeedAssistance"));
            statusImageList.AddImage(StatusIconsExtension.GetImage("NotStarted"));
            priorityImageList.Clear();
            priorityImageList.ImageSize = PriorityIconsExtension.GetImage("LowPriority").Size;
            priorityImageList.AddImage(PriorityIconsExtension.GetImage("LowPriority"));
            priorityImageList.AddImage(PriorityIconsExtension.GetImage("MediumPriority"));
            priorityImageList.AddImage(PriorityIconsExtension.GetImage("NormalPriority"));
            priorityImageList.AddImage(PriorityIconsExtension.GetImage("HighPriority"));
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<EmployeeTaskViewModel>();
            fluentAPI.SetObjectDataSourceBinding(taskBindingSource,
                x => x.Entity, x => x.Update());
            
            fluentAPI.BindCommand(saveSimpleButton, x => x.SaveAndClose());
            fluentAPI.BindCommand(cancelSimpleButton, x => x.Close());
            
            fluentAPI.SetBinding(ownerLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(assignedToLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(linkedToLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(ReminderCheckEdit, r => r.EditValue, x => x.ShouldRemind);
            fluentAPI.SetBinding(ReminderDateTimeDateEdit, r => r.Enabled, x => x.ShouldRemind);
            fluentAPI.SetBinding(ReminderDateTimeEdit, r => r.Enabled, x => x.ShouldRemind);
        }
    }
}
