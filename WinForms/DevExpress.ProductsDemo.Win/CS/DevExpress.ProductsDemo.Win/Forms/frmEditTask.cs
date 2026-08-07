using System;
using System.Windows.Forms;
using DevExpress.MailClient.Win;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevExpress.ProductsDemo.Win.Forms {
    public partial class frmEditTask : RibbonForm {
        Task task, bindingTask;
        public frmEditTask() {
            InitializeComponent();
        }
        public frmEditTask(Task task, IDXMenuManager menuManager) {
            InitializeComponent();
            this.task = task;
            this.bindingTask = task.Clone();
            InitEditors();
            InitMenuManager(menuManager);
            if(bindingTask.StartDate.HasValue)
                deStartDate.DateTime = bindingTask.StartDate.Value;
            if(bindingTask.DueDate.HasValue)
                deDueDate.DateTime = bindingTask.DueDate.Value;
            teSubject.DataBindings.Add("Text", bindingTask, "Subject");
            icbStatus.DataBindings.Add("EditValue", bindingTask, "Status");
            icbCategory.DataBindings.Add("EditValue", bindingTask, "Category");
            icbPriority.DataBindings.Add("EditValue", bindingTask, "Priority");
            sePercentComplete.DataBindings.Add("Value", bindingTask, "PercentComplete");
            richEditControl1.DataBindings.Add("HtmlText", bindingTask, "Description");
            UpdateCaption();
            InitValidationProvider();
            if(task.AssignTo != null) {
                ucContactInfo1.Init(task.AssignTo, string.Empty);
                splitContainerControl1.Collapsed = LayoutOption.TaskCollapsed;
            }
            else
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
        }

        void InitValidationProvider() {
            dxValidationProvider1.SetValidationRule(teSubject, ValidationRulesHelper.RuleIsNotBlank);
        }
        void UpdateCaption() {
            Text = bindingTask.Subject;
        }
        void InitMenuManager(IDXMenuManager menuManager) {
            foreach(Control ctrl in lcMain.Controls) {
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) {
                    edit.MenuManager = menuManager;
                }
            }
        }
        void InitEditors() {
            EditorHelper.CreateTaskCategoryImageComboBox(icbCategory.Properties);
            EditorHelper.CreateTaskStatusImageComboBox(icbStatus.Properties);
            EditorHelper.InitPriorityComboBox(icbPriority.Properties);
        }
        private void sbOK_Click(object sender, EventArgs e) {
            if(deDueDate.DateTime != DateTime.MinValue)
                bindingTask.DueDate = deDueDate.DateTime;
            if(deStartDate.DateTime != DateTime.MinValue)
                bindingTask.StartDate = deStartDate.DateTime;
            task.Assign(bindingTask);
        }

        private void richEditControl1_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl1.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl1.IsFloatingObjectSelected;
        }

        private void sePercentComplete_EditValueChanged(object sender, EventArgs e) {
            sePercentComplete.DoValidate();
        }

        private void icbStatus_SelectedIndexChanged(object sender, EventArgs e) {
            icbStatus.DoValidate();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if(task.AssignTo != null)
                LayoutOption.TaskCollapsed = splitContainerControl1.Collapsed;
        }
    }
}
