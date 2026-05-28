using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors;
using System.Linq;
using System.Collections.Generic;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class Groups : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public Groups() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        Color[] groupColors;

        //<pivotGridControl1>
        private void Groups_Load(object sender, System.EventArgs e) {
            UpdateGroupColors();
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            pivotGridControl1.HeaderImages = HeadersImageList;
            pivotGridControl1.ValueImages = CategoryImageList;
            fieldExtendedPrice.ImageIndex = 3;
        }

        private void UpdateGroupColors() {
            this.groupColors = new Color[] { Green, Blue, Red };
        }

        private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }
        //</pivotGridControl1>



        void pivotGridControl1_CustomDrawFieldHeader(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventArgs e) {
            e.Appearance.ForeColor = groupColors[e.Field.Group.Index];
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateGroupColors();
        }
        
        bool syncLocked = false;
        //<ceColumns>
        void ceColumns_CheckedChanged(object sender, EventArgs e) {
            GroupsExpandCollapse(PivotArea.ColumnArea, !(sender as CheckEdit).Checked);
        }
        //</ceColumns>
        //<ceRows>
        void ceRows_CheckedChanged(object sender, EventArgs e) {
            GroupsExpandCollapse(PivotArea.RowArea, !(sender as CheckEdit).Checked);
        }
        //</ceRows>
        //<ceData>
        void ceData_CheckedChanged(object sender, EventArgs e) {
            GroupsExpandCollapse(PivotArea.DataArea, !(sender as CheckEdit).Checked);
        }
        //</ceData>
        
        void SyncCheckBoxes() {
            if(syncLocked)
                return;
            syncLocked = true;
            var groupsByArea = pivotGridControl1.Groups
                .Cast<PivotGridGroup>()
                .Where(g => g.Area != PivotArea.FilterArea)
                .ToLookup(g => g.Area);

            var colGroups = groupsByArea[PivotArea.ColumnArea];
            SetCheckBoxState(ceColumns, groupsByArea[PivotArea.ColumnArea]);
            SetCheckBoxState(ceRows, groupsByArea[PivotArea.RowArea]);
            SetCheckBoxState(ceData, groupsByArea[PivotArea.DataArea]);
            syncLocked = false;
            BestFit();
        }

        void BestFit() {
            pivotGridControl1.BestFitRowArea();
            pivotGridControl1.BestFitDataHeaders(true);
        }
        //<ceColumns>
        //<ceRows>
        //<ceData>
        void GroupsExpandCollapse(PivotArea area, bool expand) {
            if(syncLocked)
                return;
            syncLocked = true;
            pivotGridControl1.BeginUpdate();
            try {
                foreach(PivotGridGroup group in pivotGridControl1.Groups)
                    if(group.Area == area)
                        foreach(PivotGridField field in group)
                            field.ExpandedInFieldsGroup = expand;
            }
            finally {
                pivotGridControl1.EndUpdate();
                BestFit();
                syncLocked = false;
            }
        }
        //</ceData>
        //</ceRows>
        //</ceColumns>
        void SetCheckBoxState(CheckEdit ce, IEnumerable<PivotGridGroup> groups) {
            ce.Enabled = groups.Any();
            if(!ce.Enabled)
                return;
            int collapsedCount = groups.Count(g => g.VisibleCount == 1);
            int count = groups.Count();
            bool allGroupsCollapsed = collapsedCount == count;
            if(allGroupsCollapsed)
                ce.CheckState = CheckState.Checked;
            else {
                int expandedCount = groups.Count(g => g.VisibleCount == g.Count);
                bool allGroupsExpanded = expandedCount == count;
                if(allGroupsExpanded)
                    ce.CheckState = CheckState.Unchecked;
                else
                    ce.CheckState = CheckState.Indeterminate;
            }
        }

        void pivotGridControl1_FieldExpandedInFieldGroupChanged(object sender, PivotFieldEventArgs e) {
            SyncCheckBoxes();
        }

        private void pivotGridControl1_FieldAreaChanged(object sender, PivotFieldEventArgs e) {
            SyncCheckBoxes();
        }

        void CheckStateChanged(object sender, EventArgs e) {
            var ce = sender as CheckEdit;
            if(ce.CheckState == CheckState.Indeterminate && !syncLocked)
                ce.CheckState = CheckState.Unchecked;
        }
    }
}

