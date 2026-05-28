using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class InlineGrouping : TutorialControl {
        public InlineGrouping() {
            InitializeComponent();
            InitVehiclesData();
            InitEditors();
        }

        void InitEditors() {
            icbGroupDrawMode.Properties.Items.AddEnum(typeof(Views.Grid.GroupDrawMode));
            ceAllowPartialGroups.Checked = gridView1.OptionsBehavior.AllowPartialGroups == Utils.DefaultBoolean.True;
            icbGroupDrawMode.EditValue = gridView1.OptionsView.GroupDrawMode;
            ceShowExpandCollapseButtons.Checked = gridView1.OptionsView.ShowGroupExpandCollapseButtons;
            ceAutoExpandAllGroups.Checked = gridView1.OptionsBehavior.AutoExpandAllGroups;
            ceGroupExpandedOnSorting.Checked = gridView1.OptionsBehavior.KeepGroupExpandedOnSorting;
        }
        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1, 50);
            VehiclesData.InitColumnViewEditors(gridView1);
            gridView1.Columns["DeliveryDate"].GroupInterval = ColumnGroupInterval.Date;
            gridView1.GroupSummary.Clear();
            gridView1.GroupSummary.Add(Data.SummaryItemType.Count, "Name", gridView1.Columns["Name"]);
            gridView1.GroupSummary.Add(Data.SummaryItemType.Sum, "Price", gridView1.Columns["Price"], "{0:c}");
        }

        private void ceAllowPartialGroups_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsBehavior.AllowPartialGroups = ce.Checked ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
        }

        private void icbGroupDrawMode_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsView.GroupDrawMode = (Views.Grid.GroupDrawMode)icbGroupDrawMode.EditValue;
        }

        private void ceShowExpandCollapsButtons_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsView.ShowGroupExpandCollapseButtons = ce.Checked;
        }

        private void ceAutoExpandAllGroups_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsBehavior.AutoExpandAllGroups = ce.Checked;
            ceGroupExpandedOnSorting.Enabled = !ce.Checked;
        }

        private void ceGroupExpandedOnSorting_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsBehavior.KeepGroupExpandedOnSorting = ce.Checked;
        }
    }
}
