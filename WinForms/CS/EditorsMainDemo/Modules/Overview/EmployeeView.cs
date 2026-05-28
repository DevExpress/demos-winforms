namespace DevExpress.XtraEditors.Demos.Modules.Overview {
    public partial class EmployeeView : TutorialControl {
        public EmployeeView() {
            InitializeComponent();
            StatusImageComboBoxEdit.Properties.Items.AddEnum<EmployeeStatus>();
            EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, null);
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(null, gridControlTasks.RepositoryItems);
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum<EmployeeDepartment>();
            StateImageComboBoxEdit.Properties.Items.AddEnum<StateEnum>();
            this.bindingSource.Add(EmployeeDataHelper.CreateDefaultEmployee());
        }
        protected override bool? UseRoundedPanel {
            get { return false; }
        }
    }
}
