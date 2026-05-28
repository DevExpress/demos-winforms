using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraTreeList;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ResourcesTreeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        int _lastSplitContainerControlSplitterPosition;
        public ResourcesTreeModule() { 
            InitializeComponent();
            LastSplitContainerControlSplitterPosition = 180;
            resourcesTree1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.ShowAlways;
        }
        void ResourcesTreeModule_Load(object sender, System.EventArgs e) {
            FillData();
            UpdateControls();
            
        }
        #region Properties
        int LastSplitContainerControlSplitterPosition { get { return _lastSplitContainerControlSplitterPosition; } set { _lastSplitContainerControlSplitterPosition = value; } }
        public TimelineView ActiveTimeLineBasedView {
            get {
                if (schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Gantt))
                    return schedulerControl1.GanttView;
                return schedulerControl1.TimelineView;
            }
        }
        #endregion
        #region FillData
        void FillData() {
            string connectionString = DemoUtils.GetFileRelativePath("Tasks.mdb");
            if (connectionString.Length <= 0)
                return;

            DemoUtils.SetConnectionString(tasksTableAdapter.Connection, connectionString);
            //DemoUtils.SetConnectionString(taskDependenciesTableAdapter.Connection, connectionString);
            DemoUtils.SetConnectionString(resourcesTableAdapter.Connection, connectionString);

            tasksTableAdapter.Fill(this.tasksDataSet.Tasks);
            //taskDependenciesTableAdapter.Fill(this.tasksDataSet.TaskDependencies);
            resourcesTableAdapter.Fill(this.tasksDataSet.Resources);

            this.tasksTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(tasksTableAdapter_RowUpdated);
            //this.taskDependenciesTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(taskDependenciesTableAdapter_RowUpdated);
            this.resourcesTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(resourcesTableAdapter_RowUpdated);
            this.schedulerControl1.Start = new DateTime(2016, 11, 10);
        }        
        #endregion
        #region UpdateControls
        void UnsubscribeEvents() {
            this.chkAutoHeightCells.CheckedChanged -= new System.EventHandler(this.chkAutoHeightCells_CheckedChanged);
            this.chkShowResourceHeaders.CheckedChanged -= new System.EventHandler(this.chkShowResourceHeaders_CheckedChanged);            
            this.splitContainerControl1.SplitterPositionChanged -= new System.EventHandler(this.splitContainerControl1_SplitterPositionChanged);
            this.chkAutoFilterRow.CheckedChanged -= new EventHandler(chkAutoFilterRow_CheckedChanged);
            this.chkFilterPanel.CheckedChanged -= new EventHandler(chkFilterPanel_CheckedChanged);
            UnsubscribeSpinEditEvents();
        }
        void SubscribeEvents() {
            this.chkAutoHeightCells.CheckedChanged += new System.EventHandler(this.chkAutoHeightCells_CheckedChanged);
            this.chkShowResourceHeaders.CheckedChanged += new System.EventHandler(this.chkShowResourceHeaders_CheckedChanged);            
            this.splitContainerControl1.SplitterPositionChanged += new System.EventHandler(this.splitContainerControl1_SplitterPositionChanged);
            this.chkAutoFilterRow.CheckedChanged += new EventHandler(chkAutoFilterRow_CheckedChanged);
            this.chkFilterPanel.CheckedChanged += new EventHandler(chkFilterPanel_CheckedChanged);
            SubscribeSpinEditEvents();
        }

        private void SubscribeSpinEditEvents() {
            this.spinResourcesPerPage.EditValueChanged += new System.EventHandler(this.spinResourcesPerPage_EditValueChanged);
        }
        private void UnsubscribeSpinEditEvents() {
            this.spinResourcesPerPage.EditValueChanged += new System.EventHandler(this.spinResourcesPerPage_EditValueChanged);
        }

        void chkFilterPanel_CheckedChanged(object sender, EventArgs e)
        {
            resourcesTree1.OptionsView.ShowFilterPanelMode = chkFilterPanel.Checked ? ShowFilterPanelMode.ShowAlways : ShowFilterPanelMode.Never;
        }

        void chkAutoFilterRow_CheckedChanged(object sender, EventArgs e)
        {
            resourcesTree1.OptionsView.ShowAutoFilterRow = chkAutoFilterRow.Checked;
        }
        void UpdateControls() {
            UnsubscribeEvents();
            try {
                this.chkShowResourceHeaders.Checked = ActiveTimeLineBasedView.ShowResourceHeaders;
                this.chkAutoHeightCells.Checked = ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled;                
                this.chkAutoFilterRow.Checked = resourcesTree1.OptionsView.ShowAutoFilterRow;
                this.chkFilterPanel.Checked = resourcesTree1.OptionsView.ShowFilterPanelMode != ShowFilterPanelMode.Never;
                UpdateSpinEdit();
                LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition;

            }
            finally {
                SubscribeEvents();
            }
        }
        void UpdateSpinEdit() {
            this.spinResourcesPerPage.EditValue = schedulerControl1.ActiveView.ResourcesPerPage;
        }
        #endregion
        #region RowUpdated handlers
        int id = 0;
        private void tasksTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", tasksTableAdapter.Connection)) {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["Id"] = id;
            }
        }
        //int id2 = 0;
        //private void taskDependenciesTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
        //    if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
        //        id2 = 0;
        //        using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", taskDependenciesTableAdapter.Connection)) {
        //            id2 = (int)cmd.ExecuteScalar();
        //        }
        //        e.Row["Id"] = id2;
        //    }
        //}
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
            schedulerDataStorage1.SetAppointmentId(((Appointment)e.Objects[0]), id);
        }
        void CommitTask() {
            tasksTableAdapter.Update(this.tasksDataSet);
            this.tasksDataSet.AcceptChanges();
        }
        #endregion
        //#region Task Dependencies
        //private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e) {
        //    CommitTaskDependency();
        //}

        //private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e) {
        //    CommitTaskDependency();
        //}

        //private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e) {
        //    CommitTaskDependency();
        //}
        //void CommitTaskDependency() {
        //    taskDependenciesTableAdapter.Update(this.tasksDataSet);
        //    this.tasksDataSet.AcceptChanges();
        //}
        //#endregion
        #region UI elelents event handles
        void chkShowResourceHeaders_CheckedChanged(object sender, EventArgs args) {
            ActiveTimeLineBasedView.ShowResourceHeaders = chkShowResourceHeaders.Checked;
        }
        void chkAutoHeightCells_CheckedChanged(object sender, EventArgs args) {
            ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled = chkAutoHeightCells.Checked;
        }
        void spinResourcesPerPage_EditValueChanged(object sender, System.EventArgs e) {
            ActiveTimeLineBasedView.ResourcesPerPage = Convert.ToInt32(spinResourcesPerPage.EditValue);
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
            bool isTimeLine = schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Gantt) || schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Timeline);
            try {
                splitContainerControl1.SplitterPosition = (isTimeLine) ? LastSplitContainerControlSplitterPosition : 0;
            }
            finally {
                SubscribeEvents();
            }
        }
        #endregion        
        void resourcesTree1_LayoutUpdated(object sender, EventArgs e) {
            UnsubscribeSpinEditEvents();
            UpdateSpinEdit();
            SubscribeSpinEditEvents();
                
        }
    }
}
