using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.Xpo.Demos {
    public partial class EditForm : DevExpress.XtraEditors.XtraForm {
        public EditForm(Project dataSource, string formCaption, ImageList iProjectType, ImageList iStatus) {
            InitializeComponent();
            this.dataSource = dataSource;
            this.Text = formCaption;
            this.imageComboBoxEdit1.Properties.SmallImages = iProjectType;
            this.imageComboBoxEdit2.Properties.SmallImages = iStatus;
        }

        private Project dataSource;
        #region Editors Initialization
        private void InitEditors() {
            this.imageComboBoxEdit1.Properties.Items.AddRange(new object[] {
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)});
            this.imageComboBoxEdit2.Properties.Items.AddRange(new object[] {
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2),
                                                                               new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)});
        }
        #endregion

        private void EditForm_Load(object sender, System.EventArgs e) {
            InitEditors();
            if(dataSource.Name != null)
                lbName.Text = dataSource.Name;
            teOwner.DataBindings.Add("EditValue", dataSource, "Owner");
            deCreatedDate.DataBindings.Add("EditValue", dataSource, "CreatedDate");
            imageComboBoxEdit1.DataBindings.Add("EditValue", dataSource, "ProjectType");
            imageComboBoxEdit2.DataBindings.Add("EditValue", dataSource, "Status");
        }
    }
}
