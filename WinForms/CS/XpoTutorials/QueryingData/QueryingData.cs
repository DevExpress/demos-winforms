using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.Xpo.Demos {
    public partial class QueryingData : TutorialControl	{
        public QueryingData() {
            InitializeComponent();
        }

        private void QueryingData_Load(object sender, System.EventArgs e) {
            // If the 'Customer' table is empty, adds new records and reloads the xpCustomers collection.
            if(xpCustomers.Count == 0) {
                CreateCustomers();
                xpCustomers.Reload();
            }
        }

        private void repositoryItemImageComboBox1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            ImageComboBoxEdit editor = sender as ImageComboBoxEdit;
            if(e.Button.Kind != ButtonPredefines.Close) return;
            ClearFilter(IsClient(barManager1.ActiveEditItemLink.Item));
            editor.EditValue = null;
            barManager1.ActiveEditItemLink.PostEditor();
        }

        private void barEditItem1_EditValueChanged(object sender, System.EventArgs e) {
            BarEditItem barItem = sender as BarEditItem;
            bool isClient = IsClient(barItem);

			//gridView1.CollapseAllDetails();
			
			if(barItem.EditValue == null) {
                ClearFilter(isClient);
                return;
            }
            string filterString = barItem.EditValue.ToString();
			if(isClient)
                xpCustomers.Filter = CriteriaOperator.Parse(filterString);
            else
                xpCustomers.Criteria = CriteriaOperator.Parse(filterString);
            UpdateStatusBar(isClient, filterString);
        }

        private bool IsClient(BarItem barItem) {
            bool isClient = false;
            if(barItem.Tag.ToString() == "Client")
                isClient = true;
            return isClient;
        }

        private void ClearFilter(bool isClient) {
            if(isClient)
                xpCustomers.Filter = null;
            else
                xpCustomers.Criteria = null;
            UpdateStatusBar(isClient, "(no filter)");
        }

        private void UpdateStatusBar(bool isClient, string filterString) {
            if(isClient)
                barStaticItemClient.Caption = "Filter String (client): " + filterString;
            else
                barStaticItemDataStore.Caption = "Filter String (data store): " + filterString;
        }

        public override void ReloadData() {
            xpCustomers.Reload();
        }
    }
}
