using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Threading;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleRangeTrackBar : TutorialControl {
        public ModuleRangeTrackBar() {
            InitializeComponent();
            this.Load += ModuleRangeTrackBar_Load1;
        }

        private void ModuleRangeTrackBar_Load1(object sender, EventArgs e) {
            CalcContentCore();
        }

        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleRangeTrackBar" }; } }
        protected override string WhatsThisXMLFileName { get { return "rangetrackbar"; } }

        bool updateValues = false;

        private void ModuleRangeTrackBar_Load(object sender, System.EventArgs e) {
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
            UpdateTrackBarBounds(rangeTrackBarControl1);
        }

        private void UpdateTrackBarBounds(TrackBarControl trackBar) {
            if(trackBar.Properties.Orientation == Orientation.Horizontal) {
                ControlUtils.HorzAlignControlInParent(trackBar, 16);
            }
            else {
                ControlUtils.VertAlignControlInParent(trackBar, 32);
            }
            ControlUtils.CenterControlInParent(trackBar);
        }

        void InitComboBoxes() {
            icbTickStyle.Properties.Items.AddEnum(typeof(TickStyle));
        }


        void InitValues() {
            updateValues = true;
            checkEditVertical.Checked = rangeTrackBarControl1.Properties.Orientation == Orientation.Vertical;
            icbTickStyle.EditValue = rangeTrackBarControl1.Properties.TickStyle;
            seMinimum.Value = rangeTrackBarControl1.Properties.Minimum;
            seMaximum.Value = rangeTrackBarControl1.Properties.Maximum;
            seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange;
            seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange;
            seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency;
            ceShowValue.Checked = rangeTrackBarControl1.Properties.ShowValueToolTip;
            ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip;
            updateValues = false;
            ShowValue();
        }

        //<checkEditVertical>
        private void checkEditVertical_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.Orientation = checkEditVertical.Checked ? Orientation.Vertical : Orientation.Horizontal;
            UpdateTrackBarBounds(rangeTrackBarControl1);
        }
        //</checkEditVertical>

        //<icbTickStyle>
        private void icbTickStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.TickStyle = (TickStyle)icbTickStyle.EditValue;
        }
        //</icbTickStyle>

        //<seMinimum>
        private void seMinimum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value);
            seMinimum.Value = rangeTrackBarControl1.Properties.Minimum;
        }
        //</seMinimum>

        //<seMaximum>
        private void seMaximum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value);
            seMaximum.Value = rangeTrackBarControl1.Properties.Maximum;
        }
        //</seMaximum>

        //<seSmallChange>
        private void seSmallChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value);
            seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange;
        }
        //</seSmallChange>

        //<seLargeChange>
        private void seLargeChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value);
            seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange;
        }
        //</seLargeChange>

        //<seTickFrequency>
        private void seTickFrequency_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value);
            seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency;
        }
        //</seTickFrequency>
        private void rangeTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            ShowValue();
        }
        void ShowValue() {
            lbValue.Text = rangeTrackBarControl1.Value.ToString();
        }
        //<ceShowValue>
        private void ceShowValue_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            rangeTrackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked;
            ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip;
        }
        //</ceShowValue>

        //<ceShowCustomValue>
        private void rangeTrackBarControl1_BeforeShowValueToolTip(object sender, TrackBarValueToolTipEventArgs e) {
            if(!ceShowCustomValue.Checked) return;
            e.ShowArgs.ToolTip = string.Format("Interval = [{0}; {1}]", rangeTrackBarControl1.Value.Minimum, rangeTrackBarControl1.Value.Maximum);
        }
        //</ceShowCustomValue>
    }
}

