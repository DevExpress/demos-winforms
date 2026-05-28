using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars;
using DevExpress.XtraLayout;

namespace DevExpress.HTML.Demos {
    public partial class AlertControlProperties : XtraUserControl {
        AlertControl aControl;
        bool _initValues = false;
        public AlertControlProperties() {
            InitializeComponent();
            InitProperties();
        }

        void InitProperties() {
            icbFormDisplaySpeed.Properties.Items.AddEnum(typeof(AlertFormDisplaySpeed));
            icbFormLocation.Properties.Items.AddEnum(typeof(AlertFormLocation));
            icbShowingEffect.Properties.Items.AddEnum(typeof(AlertFormShowingEffect));
        }
        public void Init(AlertControl control) {
            _initValues = true;
            this.aControl = control;
            seAutoFormDelay.EditValue = aControl.AutoFormDelay;
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed;
            icbFormLocation.EditValue = aControl.FormLocation;
            icbShowingEffect.EditValue = aControl.FormShowingEffect;
            seFormMaxCount.Value = aControl.FormMaxCount;
            _initValues = false;
        }

        //<seAutoFormDelay>
        private void seAutoFormDelay_EditValueChanged(object sender, EventArgs e) {
            if(_initValues || aControl == null) return;
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value);
        }
        //</seAutoFormDelay>

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

        private void icbShowingEffect_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.FormShowingEffect = (AlertFormShowingEffect)icbShowingEffect.EditValue;
        }

        private void seFormMaxCount_EditValueChanged(object sender, EventArgs e) {
            if(_initValues) return;
            aControl.FormMaxCount = (int)seFormMaxCount.Value;
        }

        public int GetBestHeight() {
            int bottom = 0;
            foreach(BaseLayoutItem item in Root.Items)
                if(item is LayoutControlItem)
                    bottom = Math.Max(((LayoutControlItem)item).Control.Bounds.Bottom, bottom);
            return bottom + Root.Padding.Height + layoutControl1.Padding.Vertical + layoutControl1.Margin.Vertical + this.Padding.Vertical + this.Margin.Vertical;
        }

        //public void ApplyProperties(AlertControl ac) {
        //    ac.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value);
        //    ac.FormMaxCount = (int)seFormMaxCount.Value;
        //    ac.FormShowingEffect = (AlertFormShowingEffect)icbShowingEffect.EditValue;
        //    ac.FormLocation = (AlertFormLocation)icbFormLocation.EditValue;
        //    ac.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
        //    ac.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
        //}
    }
}
