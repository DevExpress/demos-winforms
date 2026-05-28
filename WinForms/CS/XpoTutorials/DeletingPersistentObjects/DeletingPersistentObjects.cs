using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos {
    public partial class DeletingPersistentObjects : TutorialControl {
        public DeletingPersistentObjects() {
            InitializeComponent();
        }

        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void DeletingPersistentObjects_Load(object sender, System.EventArgs e) {
            InitEditors();
            // If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            if(xpProjects.Count == 0) {
                CreateProjects(unitOfWork1);
                xpProjects.Reload();
            }
            // If the 'ImmediateDeletionProject' table is empty, adds new records and reloads the xpImmediateDeletionProjects collection.
            if(xpImmediateDeletionProjects.Count == 0) {
                CreateImmediateDeletionProjects(unitOfWork2);
                xpImmediateDeletionProjects.Reload();
            }
            UpdateImmediateDeleteButtonState();
        }

        #region Editors Initialization
        private void InitEditors() {
            this.repositoryItemImageComboBox1.Items.AddRange(new object[] {
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0),
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1),
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2),
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)});
            this.repositoryItemImageComboBox2.Items.AddRange(new object[] {
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0),
                                                                              new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)});
            gridControl1.ForceInitialize();
            gridControl2.ForceInitialize();
        }
        #endregion

        //<sbDeleteSelected>
        private void sbDeleteSelected_Click(object sender, System.EventArgs e) {
            int itemIndex = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
            if(itemIndex < 0)
                return;
            unitOfWork1.Delete(xpProjects[itemIndex]);
            unitOfWork1.CommitChanges();
            UpdateButtonState(gridView1.FocusedRowHandle);
        }
        //</sbDeleteSelected>

        //<gridControl1>
        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e) {
            int itemIndex;
            if(e.RowHandle < 0 || (itemIndex = gridView1.GetDataSourceRowIndex(e.RowHandle)) < 0) 
                return;
            Project obj = xpProjects[itemIndex] as Project; 
            if(obj != null && obj.IsDeleted) {
                e.Appearance.BackColor = Color.LightGray;
                e.Appearance.ForeColor = Color.Gray;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            UpdateButtonState(e.FocusedRowHandle);
        }

        private void UpdateButtonState(int rowHandle) {
            int itemIndex = gridView1.GetDataSourceRowIndex(rowHandle);
            if(itemIndex < 0)
                return;
            Project obj = xpProjects[itemIndex] as Project;
            sbRestore.Enabled = obj.IsDeleted;
            sbDeleteSelected.Enabled = !obj.IsDeleted;
        }
        //</gridControl1>

        //<sbRestore>
        private void sbRestore_Click(object sender, System.EventArgs e) {
            RestorePersistentObject(gridView1.FocusedRowHandle, unitOfWork1);
            UpdateButtonState(gridView1.FocusedRowHandle);
        }

        private void RestorePersistentObject(int rowHandle, UnitOfWork uow) {
            int itemIndex = gridView1.GetDataSourceRowIndex(rowHandle);
            if(itemIndex < 0)
                return;
            Project obj = xpProjects[itemIndex] as Project;
            obj.SetMemberValue("GCRecord", null);
            uow.CommitChanges();
        }
        //</sbRestore>

        //<sbImmediateDelete>
        private void sbImmediateDelete_Click(object sender, System.EventArgs e) {
            DeleteFocusedRecord(gridView2.FocusedRowHandle);
            UpdateImmediateDeleteButtonState();
        }
        
        private void DeleteFocusedRecord(int rowHandle) {
            if(gridView2.RowCount == 0)
                return;
            int itemIndex = gridView2.GetDataSourceRowIndex(rowHandle);
            if(itemIndex < 0)
                return;
            ImmediateDeletionProject obj = xpImmediateDeletionProjects[itemIndex] as ImmediateDeletionProject;
            obj.Delete();
            unitOfWork2.CommitChanges();
        }
        //</sbImmediateDelete>

        private void UpdateImmediateDeleteButtonState() {
            if(gridView2.RowCount > 0)
                sbImmediateDelete.Enabled = true;
            else
                sbImmediateDelete.Enabled = false;
        }

        //<sbAddNew>
        private void sbAddNew_Click(object sender, System.EventArgs e) {
            CreateNewImmediateDeletionProject();
            UpdateImmediateDeleteButtonState();
        }

        private void CreateNewImmediateDeletionProject() {
            ImmediateDeletionProject prj = new ImmediateDeletionProject(unitOfWork2, "Test", "John Doe", DateTime.Today);
            prj.Save();
            xpImmediateDeletionProjects.Add(prj);
        }
        //</sbAddNew>

        public override void ReloadData() {
            xpProjects.Reload();
        }
    }
}
