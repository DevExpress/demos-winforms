using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.Xpo.Demos {
    public partial class UnitsOfWork : TutorialControl {
        public UnitsOfWork() {
            InitializeComponent();
        }

        public override bool SetNewWhatsThisPadding { get { return true; } }

        private void UnitsOfWork_Load(object sender, System.EventArgs e) {
            InitEditors();
            // If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            if(xpProjects.Count == 0) {
                CreateProjects(unitOfWork1);
                xpProjects.Reload();
            }
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
            this.imageComboBoxEdit1.Properties.Items.AddRange(new object[] {
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)});
            this.imageComboBoxEdit1.SelectedIndex = 0;
        }
        #endregion

        //<simpleButton1>
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            if(gridView1.SelectedRowsCount == 0) return;
            
            ProjectStatus status = (ProjectStatus)((ImageComboBoxItem)imageComboBoxEdit1.SelectedItem).Value;
            
            for(int i = 0; i < gridView1.SelectedRowsCount; i++)
                ((Project)xpProjects[gridView1.GetDataSourceRowIndex(gridView1.GetSelectedRows()[i])]).Status = status;
            
            unitOfWork1.CommitChanges();
        }
        //</simpleButton1>

        public override void ReloadData() {
            xpProjects.Reload();
        }
    }
}
