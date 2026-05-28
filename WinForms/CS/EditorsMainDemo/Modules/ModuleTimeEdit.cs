using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
// <radioGroupHourFormat>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.Tutorials;
// </radioGroupHourFormat>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTimeEdit : TutorialControl {
        public ModuleTimeEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleTimeEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "timeedit"; } }

        private void ModuleTimeEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(timeEditSample);
            timeEditSample.Time = new DateTime(2005, 01, 07, 22, 54, 32);
            SetTimeFormat();
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        // <comboBoxTimeFormat>
        // <radioGroupHourFormat> <teMask>
        void SetTimeFormat() {
            string[] timeFormats = new string[] {
				"hh:mm:ss tt", "hh:mm tt", "hh tt", "HH:mm:ss", "HH:mm", "HH"};
            int index = comboBoxTimeFormat.SelectedIndex + radioGroupHourFormat.SelectedIndex * 3;
            timeEditSample.Properties.Mask.EditMask = timeFormats[index];
            teMask.Text = timeEditSample.Properties.Mask.EditMask;
        }
        // </comboBoxTimeFormat> </teMask>
        private void radioGroupHourFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetTimeFormat();
        }
        // </radioGroupHourFormat>

        // <comboBoxTimeFormat>
        private void comboBoxTimeFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetTimeFormat();
        }
        // </comboBoxTimeFormat>
        // <comboBoxTimeEditStyle>
        private void comboBoxTimeEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(comboBoxTimeEditStyle.SelectedIndex == 0) timeEditSample.Properties.TimeEditStyle = TimeEditStyle.SpinButtons;
            else timeEditSample.Properties.TimeEditStyle = TimeEditStyle.TouchUI;
        }
        // </comboBoxTimeEditStyle>
    }
}
