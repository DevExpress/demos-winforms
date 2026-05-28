using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class TimeScalesEditForm : DevExpress.XtraEditors.XtraForm {
        TimeScaleCollection fScales;

        public TimeScalesEditForm(TimeScaleCollection lScales, Form parent) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            Left = (int)(parent.Left + (parent.Width - Width) / 2);
            Top = (int)(parent.Top + (parent.Height - Height) / 2);

            this.fScales = lScales;

            UpdateTimeScalesList();
        }
        public TimeScaleCollection Scales { get { return fScales; } }


        void UpdateTimeScalesList() {
            lbTimeScales.Items.Clear();
            for (int i = 0; i < Scales.Count; i++) {
                lbTimeScales.Items.Add(Scales[i].DisplayName);
            }
            lbTimeScales.SelectedIndex = 0;
        }
        private void lbcAppearances_SelectedIndexChanged(object sender, EventArgs e) {
            propertyGrid1.SelectedObjects = GetSelectedObjects();
        }
        object[] GetSelectedObjects() {
            if (lbTimeScales.SelectedItem == null)
                return null;
            return new object[] { Scales[lbTimeScales.SelectedIndex] };
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            Scales.Add(new TimeScaleFixedInterval());
            UpdateTimeScalesList();
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            if (lbTimeScales.SelectedIndex == -1)
                return;
            Scales.RemoveAt(lbTimeScales.SelectedIndex);
            UpdateTimeScalesList();
        }

        private void btnDefaults_Click(object sender, EventArgs e) {
            Scales.LoadDefaults();
            UpdateTimeScalesList();
        }
    }
}

