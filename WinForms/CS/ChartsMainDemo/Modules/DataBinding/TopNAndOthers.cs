using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos {
    public partial class TopNAndOthersDemo : ChartDemoModuleWithOptions {
        TopNOptions Options {
            get {
                return ChartControl.Series.Count > 0 ? ChartControl.Series[0].TopNOptions : null;
            }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public TopNAndOthersDemo() {
            InitializeComponent();
            BindChartToData();
        }

        void comboBOxEditMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(Options == null)
                return;
            TopNMode mode = (TopNMode)comboBoxEditMode.SelectedIndex;
            Options.Mode = mode;
            layoutControlItemCount.Text = (string)comboBoxEditMode.SelectedItem + ":";
            spinEditCount.Properties.BeginInit();
            switch(mode) {
                case TopNMode.Count:
                    spinEditCount.Properties.IsFloatValue = false;
                    spinEditCount.Properties.MinValue = 1;
                    spinEditCount.Properties.MaxValue = 20;
                    spinEditCount.Properties.Increment = 1;
                    spinEditCount.Properties.Mask.EditMask = "f0";
                    spinEditCount.EditValue = Options.Count;
                    break;
                case TopNMode.ThresholdValue:
                    spinEditCount.Properties.IsFloatValue = true;
                    spinEditCount.Properties.MinValue = 2000;
                    spinEditCount.Properties.MaxValue = 20000;
                    spinEditCount.Properties.Increment = 500;
                    spinEditCount.Properties.Mask.EditMask = "f0";
                    spinEditCount.EditValue = Options.ThresholdValue;
                    break;
                case TopNMode.ThresholdPercent:
                    spinEditCount.Properties.IsFloatValue = true;
                    spinEditCount.Properties.MinValue = new decimal(1.5);
                    spinEditCount.Properties.MaxValue = 100;
                    spinEditCount.Properties.Increment = new decimal(0.1);
                    spinEditCount.Properties.Mask.EditMask = "f1";
                    spinEditCount.EditValue = Options.ThresholdPercent;
                    break;
                default:
                    spinEditCount.Enabled = false;
                    break;
            }
            spinEditCount.Properties.EndInit();
        }
        void checkEditCount_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                switch(Options.Mode) {
                    case TopNMode.Count:
                        Options.Count = Convert.ToInt32(spinEditCount.EditValue);
                        break;
                    case TopNMode.ThresholdValue:
                        Options.ThresholdValue = Convert.ToDouble(spinEditCount.EditValue);
                        break;
                    case TopNMode.ThresholdPercent:
                        Options.ThresholdPercent = Convert.ToDouble(spinEditCount.EditValue);
                        break;
                }
        }
        void checkEditShowOthers_CheckedChanged(object sender, EventArgs e) {
            if(Options == null)
                return;
            Options.ShowOthers = checkEditShowOthers.Checked;
            if(Options.ShowOthers) {
                textEditOthersArgument.Enabled = true;
                if(String.IsNullOrEmpty(Options.OthersArgument))
                    textEditOthersArgument.EditValue = "Others";
                else
                    textEditOthersArgument.EditValue = Options.OthersArgument;
            }
            else
                textEditOthersArgument.Enabled = false;
        }
        void textEditOthersArgument_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.OthersArgument = (string)textEditOthersArgument.EditValue;
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            if(chart.Series.Count > 0)
                chart.Series[0].LabelsVisibility = Utils.CovertBoolToDefaultBoolean(checkEditLabelVisible.Checked);
        }
        void BindChartToData() {
            chart.DataSource = dS21.Countries;
            string path = Utils.GetRelativePath("countriesDB.mdb");
            if(path.Length > 0)
                Utils.SetConnectionString(oleDbConnection, path);
            else {
                XtraMessageBox.Show("The \"countriesDB.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                oleDbDataAdapter.Fill(dS21);
            }
            catch(OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
