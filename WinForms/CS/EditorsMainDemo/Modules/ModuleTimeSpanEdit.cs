using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using System;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTimeSpanEdit : TutorialControl {
        TimeSpanEdit TimeSpanEdit {
            get { return timeSpanEdit1; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleTimeSpanEdit" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "timespanedit"; }
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        public ModuleTimeSpanEdit() {
            InitializeComponent();
            TimeSpanEdit.EditValue = new TimeSpan(75, 15, 30, 15, 400);
            TimeSpanEdit.Properties.MaskSettings.ShowAdvancedSettings = true;
            TimeSpanEdit.Properties.MaskSettings.UseMaskAsDisplayFormat = true;
            cbEditStyle.Properties.Items.AddEnum(typeof(TimeEditStyle));
            cbEditStyle.EditValue = TimeSpanEdit.Properties.TimeEditStyle;
            cbEditStyle.SelectedItem = TimeSpanEdit.Properties.TimeEditStyle;
            tseMinValue.EditValue = TimeSpanEdit.Properties.MinValue;
            tseMaxValue.EditValue = TimeSpanEdit.Properties.MaxValue;
            SubscribeEvents();
        }
        void SubscribeEvents() {
            ceAllowNegativeValue.CheckStateChanged += OnMaskSettingCheckStateChanged;
            ceUseAdvancingCaret.CheckStateChanged += OnMaskSettingCheckStateChanged;
            cbDisplayFormat.SelectedIndexChanged += OnDisplayFormatChanged;
            tseMinValue.EditValueChanged += OnTouchUIMinValueChanged;
            tseMaxValue.EditValueChanged += OnTouchUIMaxValueChanged;
            cbEditStyle.EditValueChanged += OnEditStyleEditValueChanged;
        }
        void OnEditStyleEditValueChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.TimeEditStyle = (TimeEditStyle)cbEditStyle.EditValue;
        }
        void OnTouchUIMinValueChanged(object sender, EventArgs e) {
            tseMaxValue.Properties.MinValue = (TimeSpan?)tseMinValue.EditValue;
            TimeSpanEdit.Properties.MinValue = (TimeSpan?)tseMinValue.EditValue;
        }
        void OnTouchUIMaxValueChanged(object sender, EventArgs e) {
            tseMinValue.Properties.MaxValue = (TimeSpan?)tseMaxValue.EditValue;
            TimeSpanEdit.Properties.MaxValue = (TimeSpan?)tseMaxValue.EditValue;
        }
        void OnMaskSettingCheckStateChanged(object sender, EventArgs e) {
            var timeSpanSettings = TimeSpanEdit.Properties.MaskSettings.Configure<MaskSettings.TimeSpan>();
            timeSpanSettings.AllowNegativeValues = ceAllowNegativeValue.Checked;
            timeSpanSettings.UseAdvancingCaret = ceUseAdvancingCaret.Checked;
        }
        void OnModuleLoad(object sender, EventArgs e) {
            SetDisplayFormat();
            ShowValue();
        }
        void SetDisplayFormat() {
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("Duration", "[d.]hh:mm:ss[.fff]"));
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("Constant pattern(c)", "c"));
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("General short pattern", "g"));
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("General long pattern", "G"));
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("Timer", "dd DD hh HH mm MM"));
            cbDisplayFormat.Properties.Items.Add(new ImageComboBoxItem("Countdown Timer", "dd DD 'left'"));
            cbDisplayFormat.SelectedIndex = 0;
        }
        void ShowValue() {
            string result = string.Empty;
            if(TimeSpanEdit.EditValue != null)
                result = TimeSpanEdit.EditValue.ToString();
            lbValue.Text = result;
        }
        void OnTimeSpanEditEditValueChanged(object sender, EventArgs e) {
            ShowValue();
        }
        void OnDisplayFormatChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.MaskSettings.MaskExpression = ((ImageComboBoxItem)cbDisplayFormat.SelectedItem).Value.ToString();
            teDisplayFormatString.Text = TimeSpanEdit.Properties.MaskSettings.MaskExpression;
        }
    }
}
