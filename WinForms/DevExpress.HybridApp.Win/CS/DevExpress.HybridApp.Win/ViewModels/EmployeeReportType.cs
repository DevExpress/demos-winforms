using System.ComponentModel;

namespace DevExpress.DevAV.ViewModels {
    public enum EmployeeReportType {
        None,
        [Description("Profile Report")]
        Profile,
        [Description("Summary Report")]
        Summary,
        [Description("Employees Directory Report")]
        Directory,
        [Description("Task List Report")]
        TaskList
    }
}
