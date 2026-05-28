using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbAllowNullInput>
// <icbWeekNumberRule>
// <icbEditMask>
using DevExpress.XtraEditors.Controls;
// </icbEditMask>
// </icbWeekNumberRule>
using DevExpress.Utils;
// </icbAllowNullInput>
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleDateEdit : TutorialControl  {
        public ModuleDateEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleDateEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "dateedit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleDateEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(dateEditSample);
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            // <icbAllowNullInput>
            icbAllowNullInput.Properties.Items.AddEnum(typeof(DefaultBoolean));
            icbVistaDisplayMode.Properties.Items.AddEnum(typeof(CalendarView));
            icbShowVistaClock.Properties.Items.AddEnum(typeof(DefaultBoolean));
            // </icbAllowNullInput>
            // <icbWeekNumberRule>
            icbWeekNumberRule.Properties.Items.AddEnum(typeof(WeekNumberRule));
            // </icbWeekNumberRule>
            // <icbEditMask>
            string[,] dateFormats = new string[,] {
				{"d", "Short Date"}, 
				{"D", "Long Date"}, 
				{"m", "Month & Day"}, 
				{"y", "Year & Month"}};
            for(int i = 0; i < dateFormats.Length / 2; i++)
                icbEditMask.Properties.Items.Add(new ImageComboBoxItem(dateFormats[i, 1], dateFormats[i, 0], -1));
            // </icbEditMask>
            
        }


        void InitValues() {
            updateValues = true;
            dateEditSample.DateTime = TutorialConstants.Now.AddDays(-2);
            icbVistaDisplayMode.EditValue = dateEditSample.Properties.CalendarView;
            icbShowVistaClock.EditValue = dateEditSample.Properties.VistaEditTime;
            icbAllowNullInput.EditValue = dateEditSample.Properties.AllowNullInput;
            icbWeekNumberRule.EditValue = dateEditSample.Properties.WeekNumberRule;
            ceShowClear.Checked = dateEditSample.Properties.ShowClear;
            ceShowToday.Checked = dateEditSample.Properties.ShowToday;
            ceShowWeekNumbers.Checked = dateEditSample.Properties.ShowWeekNumbers;
            ceShowClear.Enabled = dateEditSample.Properties.AllowNullInput != DefaultBoolean.False;
            icbEditMask.EditValue = dateEditSample.Properties.EditMask;
            UpdateVistaStyle();
            updateValues = false;
            EnableClock();
        }
        // <icbAllowNullInput>
        private void icbAllowNullInput_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dateEditSample.Properties.AllowNullInput = (DefaultBoolean)icbAllowNullInput.EditValue;
            // <ceShowClear>
            ceShowClear.Enabled = dateEditSample.Properties.AllowNullInput != DefaultBoolean.False;
            // </ceShowClear>
        }
        // </icbAllowNullInput>

        // <icbWeekNumberRule>
        private void icbWeekNumberRule_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dateEditSample.Properties.WeekNumberRule = (WeekNumberRule)icbWeekNumberRule.EditValue;
        }
        // </icbWeekNumberRule>

        // <ceShowClear>
        private void ceShowClear_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dateEditSample.Properties.ShowClear = ceShowClear.Checked;
        }
        // </ceShowClear>

        // <ceShowToday>
        private void ceShowToday_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dateEditSample.Properties.ShowToday = ceShowToday.Checked;
        }
        // </ceShowToday>

        // <ceShowWeekNumbers>
        private void ceShowWeekNumbers_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dateEditSample.Properties.ShowWeekNumbers = ceShowWeekNumbers.Checked;
        }
        // </ceShowWeekNumbers>

        // <icbEditMask>
        private void icbEditMask_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetMask();
        }
        // </icbEditMask>

        // <ceSynchronizing>
        private void ceSynchronizing_CheckedChanged(object sender, System.EventArgs e) {
            SetMask();
        }

        // <icbEditMask>
        void SetMask() {
            dateEditSample.Properties.EditMask = icbEditMask.EditValue.ToString();
            dateEditSample.Properties.DisplayFormat.FormatString = (ceSynchronizing.Checked ? dateEditSample.Properties.EditMask : "d");
        }
        // </icbEditMask>
        // </ceSynchronizing>

        //<icbVistaDisplayMode>
        private void icbVistaDisplayMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            dateEditSample.Properties.CalendarView = (CalendarView)icbVistaDisplayMode.EditValue;
            EnableClock();
            UpdateVistaStyle();
        }
        //</icbVistaDisplayMode>

        void EnableClock() {
            bool enableTime = dateEditSample.Properties.VistaDisplayMode == DefaultBoolean.True ||
                (NativeVista.IsVista && dateEditSample.Properties.VistaDisplayMode == DefaultBoolean.Default) ||
                dateEditSample.Properties.CalendarView == CalendarView.TouchUI;
            icbShowVistaClock.Enabled = enableTime;
        }

        //<icbShowVistaClock>
        private void icbShowVistaClock_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            dateEditSample.Properties.VistaEditTime = (DefaultBoolean)icbShowVistaClock.EditValue;
        }
        //</icbShowVistaClock>

        bool IsVistaDisplayMode(DateEdit edit) {
            if(edit.Properties.VistaDisplayMode == DefaultBoolean.False) return false;
            if(edit.Properties.VistaDisplayMode == DefaultBoolean.True) return true;
            return NativeVista.IsVista;
        }

        void UpdateVistaStyle() {
            if(dateEditSample.Properties.CalendarView == CalendarView.TouchUI) {
                ceShowClear.Enabled = ceShowToday.Enabled = ceShowWeekNumbers.Enabled = false;
            }
            else {
                ceShowToday.Enabled = !IsVistaDisplayMode(dateEditSample);
                ceShowClear.Enabled = ceShowWeekNumbers.Enabled = true;
            }
        }
    }
}

