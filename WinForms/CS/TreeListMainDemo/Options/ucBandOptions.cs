using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucBandOptions : ucDefault {
        public ucBandOptions() {
            InitializeComponent();
        }
        protected override void InitDataCore() {
            //<layoutControl.lgView>
            ceShowBands.Checked = TreeList.OptionsView.ShowBandsMode == Utils.DefaultBoolean.False ? false : true;
            ceAllowBandColumnsMultiRow.Checked = TreeList.OptionsView.AllowBandColumnsMultiRow;
            //</layoutControl.lgView>
            //<layoutControl.lgCustomization>
            ceAllowBandMoving.Checked = TreeList.OptionsCustomization.AllowBandMoving;
            ceAllowBandResizing.Checked = TreeList.OptionsCustomization.AllowBandResizing;
            ceAllowChangeBandParent.Checked = TreeList.OptionsCustomization.AllowChangeBandParent;
            ceAllowChangeColumnParent.Checked = TreeList.OptionsCustomization.AllowChangeColumnParent;
            ceShowBandsInCustomizationForm.Checked = TreeList.OptionsCustomization.ShowBandsInCustomizationForm;
            ceCustomizationFormSearchBoxVisible.Checked = TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible;
            ceAllowColumnMoving.Checked = TreeList.OptionsCustomization.AllowColumnMoving;
            ceAllowColumnResizing.Checked = TreeList.OptionsCustomization.AllowColumnResizing;
            //</layoutControl.lgCustomization>
        }
        private void ceAllowBandMoving_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowBandMoving = ceAllowBandMoving.Checked;
        }
        private void ceAllowBandResizing_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowBandResizing = ceAllowBandResizing.Checked;
        }
        private void ceAllowChangeBandParent_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowChangeBandParent = ceAllowChangeBandParent.Checked;
        }
        private void ceAllowChangeColumnParent_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowChangeColumnParent = ceAllowChangeColumnParent.Checked;
        }
        private void ceAllowColumnMoving_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowColumnMoving = ceAllowColumnMoving.Checked;
        }
        private void ceAllowColumnResizing_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.AllowColumnResizing = ceAllowColumnResizing.Checked;
        }
        private void ceShowBandsInCustomizationForm_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.ShowBandsInCustomizationForm = ceShowBandsInCustomizationForm.Checked;
            if(TreeList.CustomizationForm != null && TreeList.CustomizationForm.Visible) {
                TreeList.DestroyCustomization();
                TreeList.ColumnsCustomization();
            }
        }
        private void ceCustomizationFormSearchBoxVisible_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible = ceCustomizationFormSearchBoxVisible.Checked;
            if(TreeList.CustomizationForm != null && TreeList.CustomizationForm.Visible) {
                TreeList.DestroyCustomization();
                TreeList.ColumnsCustomization();
            }
        }
        private void ceShowBands_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsView.ShowBandsMode = ceShowBands.Checked ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
        }
        private void ceAllowBandColumnsMultiRow_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsView.AllowBandColumnsMultiRow = ceAllowBandColumnsMultiRow.Checked;
        }
    }
}
