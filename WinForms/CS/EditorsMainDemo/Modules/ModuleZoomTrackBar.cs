using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraEditors.Repository;
using DevExpress.Tutorials;
using DevExpress.XtraLayout;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleZoomTrackBar : TutorialControl {
        public ModuleZoomTrackBar() {
            InitializeComponent();
            this.Load += ModuleZoomTrackBar_Load1;
        }

        private void ModuleZoomTrackBar_Load1(object sender, EventArgs e) {
            CalcContentCore();
        }

        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleZoomTrackBar" }; } }
        protected override string WhatsThisXMLFileName { get { return "zoomTrackBar"; } }

        bool updateValues = false;

        private void ModuleZoomTrackBar_Load(object sender, System.EventArgs e) {
            SetDefaultProgressBarPosition();
            InitComboBoxes();
            InitValues();
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
        }

        private void SetDefaultProgressBarPosition() {
            UpdateTrackBarBounds(zoomTrackBarControl1);
        }

        private void UpdateTrackBarBounds(ZoomTrackBarControl trackBar) {
            if(trackBar.Properties.Orientation == Orientation.Horizontal) {
                ControlUtils.HorzAlignControlInParent(trackBar, 16);
            }
            else {
                ControlUtils.VertAlignControlInParent(trackBar, 32);
            }
            ControlUtils.CenterControlInParent(trackBar);
        }

        void InitComboBoxes() {
            icbScrollThumbStyle.Properties.Items.AddEnum(typeof(ScrollThumbStyle));
        }


        void InitValues() {
            updateValues = true;
            checkEditVertical.Checked = zoomTrackBarControl1.Properties.Orientation == Orientation.Vertical;
            icbScrollThumbStyle.EditValue = zoomTrackBarControl1.Properties.ScrollThumbStyle;
            seMinimum.Value = zoomTrackBarControl1.Properties.Minimum;
            seMaximum.Value = zoomTrackBarControl1.Properties.Maximum;
            seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange;
            seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange;
            seMiddle.Value = zoomTrackBarControl1.Properties.Middle;
            checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue;
            updateValues = false;
            ShowValue();
        }

        //<checkEditVertical>
        private void checkEditVertical_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.Orientation = checkEditVertical.Checked ? Orientation.Vertical : Orientation.Horizontal;
            UpdateTrackBarBounds(zoomTrackBarControl1);
        }
        //</checkEditVertical>

        //<icbScrollThumbStyle>
        private void icbScrollThumbStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.ScrollThumbStyle = (ScrollThumbStyle)icbScrollThumbStyle.EditValue;
        }
        //</icbScrollThumbStyle>

        private void UpdateMiddleParameters() {
            if (!checkEditUseMiddleValue.Checked) return;
            seMiddle.Value = zoomTrackBarControl1.Properties.Middle;
            checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue;
        }

        //<seMinimum>
        private void seMinimum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value);
            seMinimum.Value = zoomTrackBarControl1.Properties.Minimum;
            UpdateMiddleParameters();
        }
        //</seMinimum>

        //<seMaximum>
        private void seMaximum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value);
            seMaximum.Value = zoomTrackBarControl1.Properties.Maximum;
            UpdateMiddleParameters();
        }
        //</seMaximum>

        //<seSmallChange>
        private void seSmallChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value);
            seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange;
        }
        //</seSmallChange>

        //<seLargeChange>
        private void seLargeChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            zoomTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value);
            seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange;
        }
        //</seLargeChange>
        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            ShowValue();
        }
        void ShowValue() {
            lbValue.Text = zoomTrackBarControl1.Value.ToString();
        }
        //<checkEditUseMiddleValue>
        private void checkEditUseMiddleValue_CheckedChanged(object sender, EventArgs e) {
            //<skip>
            if (updateValues) return;
            //</skip>
            if (checkEditUseMiddleValue.Checked) {
                seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue = true;
            }
            else seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue = false;
            UpdateMiddleParameters();
            
            try {
                zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value);
            }
            catch(ArgumentException) {
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle;
            }
        }
        //</checkEditUseMiddleValue>
        //<seMiddle>
        private void seMiddle_EditValueChanged(object sender, EventArgs e) {
            //<skip>
            if (updateValues) return;
            //</skip>
            try {
                zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value);
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle;
            }
            catch(ArgumentException) {
                seMiddle.Value = zoomTrackBarControl1.Properties.Middle;
            }
        }
        //</seMiddle>
    }
}

