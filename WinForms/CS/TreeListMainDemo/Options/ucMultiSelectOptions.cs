using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Behaviors.Common;
using DevExpress.XtraTreeList.Features.Behaviors;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucMultiSelectOptions : ucDefault {
        public ucMultiSelectOptions() {
            InitializeComponent();
        }
        protected override void InitDataCore() {
            //<optionsPage>
            ceAllowMultiSelect.Checked = TreeList.OptionsSelection.MultiSelect;
            imcMultiSelectMode.Properties.Items.AddEnum(typeof(TreeListMultiSelectMode));
            imcMultiSelectMode.EditValue = TreeList.OptionsSelection.MultiSelectMode;
            //</optionsPage>
            InitEnabled();
            InitBehaviors();
        }
        private void InitEnabled() {
            imcMultiSelectMode.Enabled = btnShowSelectedValues.Enabled = ceAllowMultiSelect.Checked;
        }
        void InitBehaviors() {
            this.behaviorManager.SetBehaviors(TreeList, new Behavior[] {
                MultiCellEditBehavior.Create(typeof(TreeListMultiCellEditSource))
            });
            UpdateMultiCellEditBehavior();
        }
        private void cbMultiSelectMode_SelectedIndexChanged(object sender, EventArgs e) {
            TreeList.OptionsSelection.MultiSelectMode = (TreeListMultiSelectMode)imcMultiSelectMode.EditValue;
        }
        private void ceAllowMultiSelect_CheckedChanged(object sender, EventArgs e) {
            TreeList.OptionsSelection.MultiSelect = ceAllowMultiSelect.Checked;
            InitEnabled();
        }
        private void ceMultiCellEdit_CheckedChanged(object sender, EventArgs e) {
            UpdateMultiCellEditBehavior();
        }
        void UpdateMultiCellEditBehavior() {
            if(ceMultiCellEdit.Checked)
                behaviorManager.Attach<MultiCellEditBehavior>(TreeList);
            else
                behaviorManager.Detach<MultiCellEditBehavior>(TreeList);
        }
        private void btnShowSelectedValues_Click(object sender, EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, new Size(400, 600), GetSelectionString(TreeList), TreeList.OptionsSelection.MultiSelectMode == TreeListMultiSelectMode.CellSelect ? "Selected Cells" : "Selected Rows");
        }
        string GetSelectionString(TreeList treeList) {
            string result = "";
            foreach(TreeListNode node in treeList.Selection) {
                if(result != "")
                    result += Environment.NewLine;
                result += string.Format("#{0}: {1} {2}", treeList.GetVisibleIndexByNode(node), node.GetDisplayText("FirstName"), node.GetDisplayText("LastName"));
                if(treeList.OptionsSelection.MultiSelectMode == TreeListMultiSelectMode.CellSelect) {
                    foreach(TreeListColumn cell in treeList.GetSelectedCells(node)) {
                        result += $"{Environment.NewLine}   {cell.FieldName}: {node.GetDisplayText(cell)}";
                    }
                }
            }
            return result;
        }
    }
}
