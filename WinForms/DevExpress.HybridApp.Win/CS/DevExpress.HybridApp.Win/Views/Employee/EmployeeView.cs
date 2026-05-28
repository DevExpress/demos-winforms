using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace DevExpress.DevAV.Views {
    [DevExpress.Utils.MVVM.UI.ViewType(DevExpress.DevAV.ViewModels.DevAVDbViewModel.EmployeeViewDocumentType)]
    public partial class EmployeeView : BaseViewWithWinUIButtons {
        public EmployeeView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            InitializeGridColumnButtons();
            PopulateEnums();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
            labelNotes.Tag = true;
            labelTasks.Tag = false;
            new LabelTabController(labelTasks.Tag, labelNotes, labelTasks).EditValueChanged += (s, e) => {
                tabbedControlGroup1.SelectedTabPageIndex = (bool)s ? 1 : 0;
            };
        }
        void InitializeGridColumnButtons() {
            notesGridView.ButtonsColumn = noteColSubject;
            notesGridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Edit" });
            notesGridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Delete" });
            notesGridView.ShowButtons = true;
            notesGridView.UserCellPadding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            notesGridView.Appearance.SelectedRow.Assign(notesGridView.Appearance.FocusedCell);

            tasksGridView.ButtonsColumn = colComplete;
            tasksGridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Edit", Width = 67 });
            tasksGridView.ShowButtons = true;
        }
        void PopulateEnums() {
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum(typeof(EmployeeDepartment));
            StatusImageComboBoxEdit.Properties.Items.AddEnum(typeof(EmployeeStatus));
            prefixImageComboBoxEdit.Properties.Items.AddEnum(typeof(PersonPrefix));
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<EmployeeViewModel>();
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateFlyoutFormService(this));
            mvvmContext.RegisterService(MessageBoxService.CreateXtraMessageBoxService());
         
            fluentAPI.SetObjectDataSourceBinding(employeeBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommand(backWindowsUIButtonPanel.Buttons[0] as WindowsUIButton, x => x.Close());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.SaveAndClose());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[1], x => x.Close(), "Cancel");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], x => x.ShowReport(), "Print");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[5], x => x.ShowMailMerge(), "MailMerge");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[6], x => x.EmployeeAssignedTasksDetails.New(), "Task");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[7], x => x.ShowMeetingDialog(), "Meeting");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[8], x => x.EmployeeEvaluationsDetails.New(), "Note");

            InitTasksDetailsBindings(fluentAPI);
            InitNotesDetailsBindings(fluentAPI);
        }
        void InitTasksDetailsBindings(Utils.MVVM.MVVMContextFluentAPI<EmployeeViewModel> fluentAPI) {
            fluentAPI.SetBinding(tasksGridControl, gc => gc.DataSource,
                x => x.EmployeeAssignedTasksDetails.Entities);
            fluentAPI.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(tasksGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeeAssignedTasksDetails.SelectedEntity,
                    args => args.Row as DevAV.EmployeeTask,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            
            fluentAPI.BindCommand(tasksGridView.ButtonsPanel.Buttons[0],
                (x, ev) => x.EmployeeAssignedTasksDetails.Edit(ev), x => x.EmployeeAssignedTasksDetails.SelectedEntity);
            
            fluentAPI.WithEvent<RowClickEventArgs>(tasksGridView, "RowClick")
                .EventToCommand(
                    x => x.EmployeeAssignedTasksDetails.Edit(null), x => x.EmployeeAssignedTasksDetails.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
        }
        void InitNotesDetailsBindings(Utils.MVVM.MVVMContextFluentAPI<EmployeeViewModel> fluentAPI) {
            fluentAPI.SetBinding(notesGridControl, gc => gc.DataSource,
                x => x.EmployeeEvaluationsDetails.Entities);
            fluentAPI.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(notesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.EmployeeEvaluationsDetails.SelectedEntity,
                    args => args.Row as DevAV.Evaluation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            
            fluentAPI.BindCommand(notesGridView.ButtonsPanel.Buttons[0],
                (x, ev) => x.EmployeeEvaluationsDetails.Edit(ev), x => x.EmployeeEvaluationsDetails.SelectedEntity);
            fluentAPI.BindCommand(notesGridView.ButtonsPanel.Buttons[1],
                (x, ev) => x.EmployeeEvaluationsDetails.Delete(ev), x => x.EmployeeEvaluationsDetails.SelectedEntity);
            
            fluentAPI.WithEvent<RowClickEventArgs>(notesGridView, "RowClick")
                .EventToCommand(
                    x => x.EmployeeEvaluationsDetails.Edit(null), x => x.EmployeeEvaluationsDetails.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
        }
    }
}
