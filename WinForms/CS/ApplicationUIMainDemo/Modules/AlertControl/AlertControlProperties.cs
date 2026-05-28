using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars;

namespace DevExpress.ApplicationUI.Demos {
    public partial class AlertControlProperties : XtraUserControl {
        AlertControl aControl;
        PopupMenu menu;
        public event EventHandler AllowHtmlTextChanged;
        bool _initValues = false;
        public AlertControlProperties() {
            InitializeComponent();
            InitProperties();
        }

        void InitProperties() {
            icbControlBoxPosition.Properties.Items.AddEnum(typeof(AlertFormControlBoxPosition));
            icbFormDisplaySpeed.Properties.Items.AddEnum(typeof(AlertFormDisplaySpeed));
            icbFormLocation.Properties.Items.AddEnum(typeof(AlertFormLocation));
            icbShowAnimationType.Properties.Items.AddEnum(typeof(AlertFormShowingEffect));
            icbHideAnimationType.Properties.Items.AddEnum(typeof(AlertFormShowingEffect));
        }
        public void InitValues(AlertControl control) {
            _initValues = true;
            this.aControl = control;
            this.menu = control.PopupMenu;
            seAutoFormDelay.EditValue = aControl.AutoFormDelay;
            icbControlBoxPosition.EditValue = aControl.ControlBoxPosition;
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed;
            icbFormLocation.EditValue = aControl.FormLocation;
            icbShowAnimationType.EditValue = aControl.ShowAnimationType;
            icbHideAnimationType.EditValue = aControl.HideAnimationType;
            ceAllowHtmlText.Checked = aControl.AllowHtmlText;
            ceShowCloseButton.Checked = aControl.ShowCloseButton;
            ceShowPinButton.Checked = aControl.ShowPinButton;
            ceShowTooltips.Checked = aControl.ShowToolTips;
            ceShowPopupMenu.Checked = menu != null;
            ceAutoHeight.Checked = aControl.AutoHeight;
            seFormMaxCount.Value = aControl.FormMaxCount;
            foreach(AlertButton btn in aControl.Buttons) {
                ccbeButtons.Properties.Items.Add(btn.Name, btn.Name, btn.Visible ? CheckState.Checked : CheckState.Unchecked, true);
            }
            _initValues = false;
            RaiseAllowHtmlTextChanged();
        }

        //<seAutoFormDelay>
        private void seAutoFormDelay_EditValueChanged(object sender, EventArgs e) {
            if(_initValues || aControl == null) return;
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value);
        }
        //</seAutoFormDelay>

        //<icbControlBoxPosition>
        private void icbControlBoxPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.ControlBoxPosition = (AlertFormControlBoxPosition)icbControlBoxPosition.EditValue;
        }
        //</icbControlBoxPosition>

        //<icbFormDisplaySpeed>
        private void icbFormDisplaySpeed_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
        }
        //</icbFormDisplaySpeed>

        //<icbFormLocation>
        private void icbFormLocation_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.FormLocation = (AlertFormLocation)icbFormLocation.EditValue;
        }
        //</icbFormLocation>

        //<ceAllowHtmlText>
        private void ceAllowHtmlText_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.AllowHtmlText = ceAllowHtmlText.Checked;
            RaiseAllowHtmlTextChanged();
        }
        //</ceAllowHtmlText>

        void RaiseAllowHtmlTextChanged() {
            if(AllowHtmlTextChanged != null) AllowHtmlTextChanged(this, EventArgs.Empty);
        }

        //<ceShowCloseButton>
        private void ceShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.ShowCloseButton = ceShowCloseButton.Checked;
        }
        //</ceShowCloseButton>

        //<ceShowPinButton>
        private void ceShowPinButton_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.ShowPinButton = ceShowPinButton.Checked;
        }
        //</ceShowPinButton>

        //<ceShowPopupMenu>
        private void ceShowPopupMenu_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            if(ceShowPopupMenu.Checked)
                aControl.PopupMenu = menu;
            else aControl.PopupMenu = null;
        }
        //</ceShowPopupMenu>

        //<ceShowTooltips>
        private void ceShowTooltips_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.ShowToolTips = ceShowTooltips.Checked;
        }
        //</ceShowTooltips>

        //<ccbeButtons>
        private void ccbeButtons_EditValueChanged(object sender, EventArgs e) {
            if(_initValues || aControl == null) return;
            foreach(AlertButton btn in aControl.Buttons) 
                btn.Visible = ccbeButtons.Text.IndexOf(btn.Name) >= 0;    
        }
        //</ccbeButtons>
        private void ceAutoHeight_CheckedChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.AutoHeight = ceAutoHeight.Checked;
        }
        private void seFormMaxCount_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.FormMaxCount = (int)seFormMaxCount.Value;
        }
        public bool AutoCloseFormOnClick { get { return ceAutoClose.Checked; } }
        private void icbHideAnimationType_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.HideAnimationType = (AlertFormShowingEffect)icbHideAnimationType.EditValue;
        }
        private void icbShowAnimationType_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.ShowAnimationType = (AlertFormShowingEffect)icbShowAnimationType.EditValue;
        }
    }
}
