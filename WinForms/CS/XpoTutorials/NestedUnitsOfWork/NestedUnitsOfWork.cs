using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

namespace DevExpress.Xpo.Demos {
    public partial class NestedUnitsOfWork : TutorialControl {
        public NestedUnitsOfWork() {
            InitializeComponent();
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
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
        }
        #endregion
        #region Creating Data
        // Adds records to the 'Project' table.
        private void CreateProjects() {
            Project prj = new Project(session1, "Enterprise Accounting System", "Web Edition: Data Entry Page", "Steve Lee", new DateTime(2003, 12, 4), ProjectStatus.Postponed, ProjectType.Request);
            prj.Save();
            prj = new Project(session1, "Enterprise Accounting System", "Transaction History", "Mike Roller", new DateTime(2004, 7, 27), ProjectStatus.Fixed, ProjectType.Bug);
            prj.Save();
            prj = new Project(session1, "Small-Business Accounting System", "Installer", "Bert Parkins", new DateTime(2004, 5, 12), ProjectStatus.New, ProjectType.Bug);
            prj.Save();
            
        }
        #endregion

        private void NestedUnitsOfWork_Load(object sender, System.EventArgs e) {
            InitEditors();
            // If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            if(xpProjects.Count == 0) {
                this.CreateProjects();
                xpProjects.Reload();
            }
        }

        //<gridControl1>
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            if(e.Button.Tag == null || e.Button.Tag.ToString() != "EditRecord") return;
            // Starts the nested unit of work.
            using (NestedUnitOfWork nuow = xpProjects.Session.BeginNestedUnitOfWork()) {
                // Retrieves the persistent object that corresponds to the currently focused grid row.
                Project currentProject = nuow.GetNestedObject(xpProjects[gridView1.FocusedRowHandle]) as Project;
                // Creates the modal form so that an end-user can edit the current project.
                using (EditForm editForm = new EditForm(currentProject, currentProject.ProjectName, iProjectType, iProjectStatus)) {
                    // Shows the modal form. If the modal form's 'Save' button has been pressed, the changes made to the current project are saved to a database and the form is closed.
                    if (editForm.ShowDialog() == DialogResult.OK)
                        nuow.CommitChanges();
                }
            }
        }
        //</gridControl1>

        public override void ReloadData() {
            xpProjects.Reload();
        }

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
			gridControl1.EmbeddedNavigator.Buttons.CustomButtons[0].Enabled = e.FocusedRowHandle >= 0;
		}
    }
}
