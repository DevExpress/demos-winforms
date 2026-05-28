using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DevExpress.XtraScheduler.Demos {
    public partial class GanttViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        int _lastSplitContainerControlSplitterPosition;
       
        public GanttViewModule() { 
            InitializeComponent();
        }
        void GanttViewModule_Load(object sender, System.EventArgs e) {
            InitControlValues();
            FillData();
            UpdateControls();
        }

        #region Properties
        int LastSplitContainerControlSplitterPosition { get { return _lastSplitContainerControlSplitterPosition; } set { _lastSplitContainerControlSplitterPosition = value; } }
        GanttViewAppointmentDisplayOptions GanttAppointmentDisplayOptions { get { return schedulerControl1.Views.GanttView.AppointmentDisplayOptions; } }
        TimeIndicatorDisplayOptions TimeIndicatorDisplayOptions { get { return (TimeIndicatorDisplayOptions)schedulerControl1.GanttView.TimeIndicatorDisplayOptions; } }
        #endregion

        #region FillData
        void FillData() {
            string connectionString = DemoUtils.GetFileRelativePath("Tasks.mdb");
            if (connectionString.Length <= 0)
                return;

            DemoUtils.SetConnectionString(tasksTableAdapter.Connection, connectionString);
            DemoUtils.SetConnectionString(taskDependenciesTableAdapter.Connection, connectionString);
            DemoUtils.SetConnectionString(resourcesTableAdapter.Connection, connectionString);

            tasksTableAdapter.Fill(this.tasksDataSet.Tasks);
            taskDependenciesTableAdapter.Fill(this.tasksDataSet.TaskDependencies);
            resourcesTableAdapter.Fill(this.tasksDataSet.Resources);

            this.tasksTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(tasksTableAdapter_RowUpdated);
            this.taskDependenciesTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(taskDependenciesTableAdapter_RowUpdated);
            this.resourcesTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(resourcesTableAdapter_RowUpdated);
            this.schedulerControl1.Start = new DateTime(2016, 11, 10);
        }        
        #endregion
        #region InitControlValues
        void InitControlValues() {
            PercentCompleteDisplayType type = GanttAppointmentDisplayOptions.PercentCompleteDisplayType;
            this.chkShowBar.Checked = type.Equals(PercentCompleteDisplayType.Both) || type.Equals(PercentCompleteDisplayType.BarProgress);
            this.chkShowNumber.Checked = type.Equals(PercentCompleteDisplayType.Both) || type.Equals(PercentCompleteDisplayType.Number);
        }
        #endregion
        #region UpdateControls
        void UnsubscribeEvents() {
            this.chkAutoHeightCells.CheckedChanged -= new System.EventHandler(this.chkAutoHeightCells_CheckedChanged);
            this.chkShowResourceHeaders.CheckedChanged -= new System.EventHandler(this.chkShowResourceHeaders_CheckedChanged);
            this.spinResourcesPerPage.EditValueChanged -= new System.EventHandler(this.spinResourcesPerPage_EditValueChanged);
            this.chkShowBar.CheckedChanged -= new System.EventHandler(this.ShowProgressAsChanged);
            this.chkShowNumber.CheckedChanged -= new System.EventHandler(this.ShowProgressAsChanged);
            this.splitContainerControl1.SplitterPositionChanged -= new System.EventHandler(this.splitContainerControl1_SplitterPositionChanged);
        }
        void SubscribeEvents() {
            this.chkAutoHeightCells.CheckedChanged += new System.EventHandler(this.chkAutoHeightCells_CheckedChanged);
            this.chkShowResourceHeaders.CheckedChanged += new System.EventHandler(this.chkShowResourceHeaders_CheckedChanged);
            this.spinResourcesPerPage.EditValueChanged += new System.EventHandler(this.spinResourcesPerPage_EditValueChanged);
            this.chkShowBar.CheckedChanged += new System.EventHandler(this.ShowProgressAsChanged);
            this.chkShowNumber.CheckedChanged += new System.EventHandler(this.ShowProgressAsChanged);
            this.splitContainerControl1.SplitterPositionChanged += new System.EventHandler(this.splitContainerControl1_SplitterPositionChanged);
        }
        void UpdateControls() {
            UnsubscribeEvents();
            try {
                this.chkShowResourceHeaders.Checked = schedulerControl1.GanttView.ShowResourceHeaders;
                this.chkAutoHeightCells.Checked = schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled;
                this.spinResourcesPerPage.EditValue = schedulerControl1.Views.GanttView.ResourcesPerPage;
                LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition;
                chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment;
                cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility;
            }
            finally {
                SubscribeEvents();
            }
        }
        #endregion
        #region RowUpdated handlers
        private void tasksTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", tasksTableAdapter.Connection)) {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["Id"] = id;
            }
        }
        int id2 = 0;
        private void taskDependenciesTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                id2 = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", taskDependenciesTableAdapter.Connection)) {
                    id2 = (int)cmd.ExecuteScalar();
                }
                e.Row["Id"] = id2;
            }
        }
        int id3 = 0;
        private void resourcesTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                id3 = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", resourcesTableAdapter.Connection)) {
                    id3 = (int)cmd.ExecuteScalar();
                }
                e.Row["Id"] = id3;
            }
        }
        #endregion
        #region Appointment
        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            CommitTask();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e) {
            CommitTask();
        }
        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e) {
            CommitTask();
            int count = e.Objects.Count;
            for (int i = 0; i < count; i++) {
                Appointment apt = (Appointment)e.Objects[i];
                DataRowView rowView = apt.GetRow(this.schedulerDataStorage1) as DataRowView;
                DataRow row = rowView.Row;
                if (row == null)
                    continue;
                schedulerDataStorage1.SetAppointmentId(apt, row["Id"]);    
            }            
        }
        void CommitTask() {
            //try {
            //    DataSet ch = this.tasksDataSet.GetChanges();
            //    TasksDataSet.TasksRow row = tasksDataSet.Tasks[0];
            //    DataTable cht = tasksDataSet.Tasks.GetChanges();
            //} catch {
            //}
            tasksTableAdapter.Update(this.tasksDataSet);
            this.tasksDataSet.AcceptChanges();
        }
        #endregion
        #region Task Dependencies
        private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e) {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e) {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e) {
            CommitTaskDependency();
        }
        void CommitTaskDependency() {
            taskDependenciesTableAdapter.Update(this.tasksDataSet);
            this.tasksDataSet.AcceptChanges();
        }
        #endregion
        #region UI elelents event handles
        void chkShowResourceHeaders_CheckedChanged(object sender, EventArgs args) {
            schedulerControl1.GanttView.ShowResourceHeaders = chkShowResourceHeaders.Checked;
        }
        void chkAutoHeightCells_CheckedChanged(object sender, EventArgs args) {
            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = chkAutoHeightCells.Checked;
        }
        void spinResourcesPerPage_EditValueChanged(object sender, System.EventArgs e) {
            schedulerControl1.GanttView.ResourcesPerPage = Convert.ToInt32(spinResourcesPerPage.EditValue);
        }
        #region ResourcesTree hide/show
        void chkShowResourcesTree_CheckedChanged(object sender, EventArgs args) {
            
        }

        private void splitContainerControl1_SplitterPositionChanged(object sender, EventArgs e) {
            LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition;
        }
        #endregion

        private void schedulerControl1_ActiveViewChanged(object sender, EventArgs e) {
            UnsubscribeEvents();
            bool isGanttView = schedulerControl1.ActiveViewType == SchedulerViewType.Gantt;
            try {
                splitContainerControl1.SplitterPosition = (isGanttView) ? LastSplitContainerControlSplitterPosition : 0;
            }
            finally {
                SubscribeEvents();
            }
        }
        private void ShowProgressAsChanged(object sender, EventArgs e) {
            SetPercentCompleteDisplateType();
        }
        #endregion
        #region SetPercentCompleteDisplateType
        void SetPercentCompleteDisplateType() {
            GanttAppointmentDisplayOptions.PercentCompleteDisplayType = CalculatePercentCompleteDisplateType();
        }
        #endregion
        #region CalculatePercentCompleteDisplateType
        PercentCompleteDisplayType CalculatePercentCompleteDisplateType() {
            bool isShowBar = chkShowBar.Checked;
            bool isShowNumber = chkShowNumber.Checked;

            if (isShowBar && isShowNumber)
                return PercentCompleteDisplayType.Both;
            if (isShowBar && !isShowNumber)
                return PercentCompleteDisplayType.BarProgress;
            if (!isShowBar && isShowNumber)
                return PercentCompleteDisplayType.Number;

            return PercentCompleteDisplayType.None;
        }
        #endregion
        private void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked;
        }

        private void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)cbTimeIndicatorVisibility.EditValue;
        }
    }
}
