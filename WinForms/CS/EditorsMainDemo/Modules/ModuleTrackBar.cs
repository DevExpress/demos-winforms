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

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTrackBar : TutorialControl {
        public ModuleTrackBar() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleTrackBar" }; } }
        protected override string WhatsThisXMLFileName { get { return "TrackBar"; } }

        bool updateValues = false;

        private void ModuleTrackBar_Load(object sender, System.EventArgs e) {
            InitComboBoxes();
            InitValues();
            CalcContentCore();
        }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        void InitComboBoxes() {
            icbTickStyle.Properties.Items.AddEnum(typeof(TickStyle));
        }


        void InitValues() {
            updateValues = true;
            checkEditVertical.Checked = trackBarControl1.Properties.Orientation == Orientation.Vertical;
            icbTickStyle.EditValue = trackBarControl1.Properties.TickStyle;
            seMinimum.Value = trackBarControl1.Properties.Minimum;
            seMaximum.Value = trackBarControl1.Properties.Maximum;
            seLabelDistance.Value = trackBarControl1.Properties.DistanceFromTickToLabel;
            seSmallChange.Value = trackBarControl1.Properties.SmallChange;
            seLargeChange.Value = trackBarControl1.Properties.LargeChange;
            seTickFrequency.Value = trackBarControl1.Properties.TickFrequency;
            ceShowValue.Checked = trackBarControl1.Properties.ShowValueToolTip;
            ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip;
            ceShowTickLabels.Checked = trackBarControl1.Properties.ShowLabels;
            updateValues = false;
        }

        //<checkEditVertical>
        private void checkEditVertical_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.Orientation = checkEditVertical.Checked ? Orientation.Vertical : Orientation.Horizontal;
            CalcContentCore();
        }
        //</checkEditVertical>

        //<icbTickStyle>
        private void icbTickStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.TickStyle = (TickStyle)icbTickStyle.EditValue;
            CalcContentCore();
        }
        //</icbTickStyle>

        //<seMinimum>
        private void seMinimum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value);
            seMinimum.Value = trackBarControl1.Properties.Minimum;
            if(trackBarControl1.Properties.ShowLabels) {
                CreateNewLabelCollection();
                CalcContentCore();
            }
        }
        //</seMinimum>

        //<seMaximum>
        private void seMaximum_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value);
            seMaximum.Value = trackBarControl1.Properties.Maximum;
            if(trackBarControl1.Properties.ShowLabels){
                CreateNewLabelCollection();
                CalcContentCore();
            }
        }
        //</seMaximum>

        //<seSmallChange>
        private void seSmallChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value);
            seSmallChange.Value = trackBarControl1.Properties.SmallChange;
        }
        //</seSmallChange>

        //<seLargeChange>
        private void seLargeChange_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value);
            seLargeChange.Value = trackBarControl1.Properties.LargeChange;
        }
        //</seLargeChange>

        //<seTickFrequency>
        private void seTickFrequency_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value);
            seTickFrequency.Value = trackBarControl1.Properties.TickFrequency;
        }
        //</seTickFrequency>
        //<ceShowValue>
        private void ceShowValue_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            trackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked;
            ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip;
        }
        //</ceShowValue>
        //<ceShowCustomValue>
        private void trackBarControl1_BeforeShowValueToolTip(object sender, TrackBarValueToolTipEventArgs e) {
            if(!ceShowCustomValue.Checked) return;
            e.ShowArgs.ToolTip = string.Format("Value = {0}", trackBarControl1.Value);
        }
        //</ceShowCustomValue>
        //<ceShowTickLabels>
        private void ceShowTickLabels_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            trackBarControl1.Properties.ShowLabels = ceShowTickLabels.Checked;
            if(trackBarControl1.Properties.ShowLabels) CreateNewLabelCollection();
            seLabelDistance.Enabled = trackBarControl1.Properties.ShowLabels;
            CalcContentCore();
        }
        //</ceShowTickLabels>
        //<seLabelDistance>
        private void seLabelDistance_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            trackBarControl1.Properties.DistanceFromTickToLabel = TutorialHelper.ConvertToInt(seLabelDistance.Value);
            CalcContentCore();
        }
        //</seLabelDistance>
        //<ceShowTickLabels>
        private void CreateNewLabelCollection() {
            int step = 1;
            int itemsCount = trackBarControl1.Properties.Maximum - trackBarControl1.Properties.Minimum + 1;
            trackBarControl1.Properties.Labels.Clear();
            if(itemsCount > 5) {
                step = itemsCount / 5;
            }
            for(int i = trackBarControl1.Properties.Minimum; i <= trackBarControl1.Properties.Maximum; i += step) {
                TrackBarLabel label = new TrackBarLabel() {
                    Value = i,
                    Label = i.ToString()
                };
                trackBarControl1.Properties.Labels.Add(label);
            }
        }
        //</ceShowTickLabels>
    }
}
