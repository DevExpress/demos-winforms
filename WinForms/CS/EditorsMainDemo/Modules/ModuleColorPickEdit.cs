using System;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleColorPickEdit : TutorialControl {
        bool updateValues = false;
        
        public ModuleColorPickEdit() {
            InitializeComponent();
        }

        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleColorPickEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "coloredit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        private void ModuleColorEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(colorEditSample);
            InitComboBoxes();
            InitValues();
            InitMagnifierBehavior();
        }

        void InitMagnifierBehavior() {
            behaviorManager1.Attach<Behaviors.MagnifierBehavior>(colorEditSample, (s) => { s.Properties.ShowPixelGrid = true; });
        }
        void InitComboBoxes() {
            // <icbColorDialogType>
            icbColorDialogType.Properties.Items.AddEnum(typeof(ColorDialogType));
            // </icbColorDialogType>
            // <icbColorText>
            icbColorText.Properties.Items.AddEnum(typeof(ColorText));
            // </icbColorText>
            // <icbColorAlignment>
            icbColorAlignment.Properties.Items.AddEnum(typeof(HorzAlignment));
            // </icbColorAlignment>
            // <icbShowTabs>
            icbShowTabs.Properties.Items.AddEnum(typeof(ShowTabs));
            // </icbShowTabs>
            // <icbShowArrows>
            icbShowArrows.Properties.Items.AddEnum(typeof(ShowArrows));
            // </icbShowArrows>
            // <icbTooltipMode>
            icbTooltipMode.Properties.Items.AddEnum(typeof(ColorTooltipFormat));
            // </icbTooltipMode>
        }
        void InitValues() {
            updateValues = true;
            icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment;
            icbColorText.EditValue = colorEditSample.Properties.ColorText;
            icbColorDialogType.EditValue = colorEditSample.Properties.ColorDialogType;
            ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog;
            ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger;
            
            icbShowTabs.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowTabs;
            icbShowArrows.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowArrows;
            icbTooltipMode.EditValue = colorEditSample.Properties.TooltipFormat;
            ceShowMakeWebSafeBtn.Checked = colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton;
            ceShowPreview.Checked = colorEditSample.Properties.ColorDialogOptions.ShowPreview;
            ceAllowTransparency.Checked = colorEditSample.Properties.ColorDialogOptions.AllowTransparency;

            ceShowCustomTab.Checked = colorEditSample.Properties.ShowCustomColors;
            ceShowWebTab.Checked = colorEditSample.Properties.ShowWebColors;
            ceShowSystemTab.Checked = colorEditSample.Properties.ShowSystemColors;
            ceShowWebSafeTab.Checked = colorEditSample.Properties.ShowWebSafeColors;
            ceShowAutomaticButton.Checked = colorEditSample.Properties.ShowAutomaticButton;
            ceShowMoreColorsButton.Checked = colorEditSample.Properties.ShowMoreColorsButton;
            updateValues = false;
        }

        // <icbColorAlignment>
        private void icbColorAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorAlignment = (HorzAlignment)icbColorAlignment.EditValue;
        }
        // </icbColorAlignment>

        // <icbColorText>
        private void icbColorText_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorText = (ColorText)icbColorText.EditValue;
        }
        // </icbColorText>

        // <icbColorDialogType>
        private void icbColorDialogType_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorDialogType = (ColorDialogType)icbColorDialogType.EditValue;
        }
        // </icbColorDialogType>

        // <ceShowColorDialog>
        private void ceShowColorDialog_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked;
        }
        // </ceShowColorDialog>

        // <ceAsInteger>
        private void ceIsInteger_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked;
        }
        // </ceAsInteger>
        // <icbShowTabs>
        void icbShowTabs_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ColorDialogOptions.ShowTabs = (ShowTabs)icbShowTabs.EditValue;
        }
        // </icbShowTabs>
        // <icbShowArrows>
        void icbShowArrows_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ColorDialogOptions.ShowArrows = (ShowArrows)icbShowArrows.EditValue;
        }
        // </icbShowArrows>
        // <icbTooltipMode>
        void icbTooltipMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.TooltipFormat = (ColorTooltipFormat)icbTooltipMode.EditValue;
        }
        // </icbTooltipMode>
        // <ceShowMakeWebSafeBtn>
        void ceShowMakeWebSafeBtn_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton = ceShowMakeWebSafeBtn.Checked;
        }
        // </ceShowMakeWebSafeBtn>
        // <ceShowPreview>
        void ceShowPreview_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ColorDialogOptions.ShowPreview = ceShowPreview.Checked;
        }
        // </ceShowPreview>
        // <ceAllowTransparency>
        void ceAllowTransparency_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ColorDialogOptions.AllowTransparency = ceAllowTransparency.Checked;
        }
        // </ceAllowTransparency>
        void SetButtonEnabled(bool enabled) {
            seAdd.Enabled = enabled;
            seClear.Enabled = !enabled;
        }
        // <ceShowCustom>
        void ceShowCustom_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowCustomColors = ceShowCustomTab.Checked;
        }
        // </ceShowCustom>
        // <ceShowWeb>
        void ceShowWebSafe_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowWebSafeColors = ceShowWebSafeTab.Checked;
        }
        // </ceShowWeb>
        // <ceShowSystem>
        void ceShowSystem_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowSystemColors = ceShowSystemTab.Checked;
        }
        // </ceShowSystem>
        // <ceShowWebColors>
        void ceShowWebColors_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowWebColors = ceShowWebTab.Checked;
        }
        // </ceShowWebColors>
        // <ceShowMoreColorsButton>
        private void ceShowMoreColorsButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowMoreColorsButton = ceShowMoreColorsButton.Checked;
        }
        // </ceShowMoreColorsButton>
        // <ceShowAutomaticButton>
        private void ceShowAutomaticButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            colorEditSample.Properties.ShowAutomaticButton = ceShowAutomaticButton.Checked;
        }
        // </ceShowAutomaticButton>
        // <seAdd>
        private void seAdd_Click(object sender, System.EventArgs e) {
            foreach(Color color in GetColorArray()) {
                colorEditSample.Properties.RecentColors.InsertColor(color);
            }
            SetButtonEnabled(false);
        }
        // </seAdd>
        // <seClear>
        private void seClear_Click(object sender, System.EventArgs e) {
            colorEditSample.Properties.RecentColors.Clear();
            SetButtonEnabled(true);
        }
        // </seClear>
        const int recentColorCount = 10;
        Color[] GetColorArray() {
            var rnd = TutorialConstants.Random;
            Color[] ret = new Color[recentColorCount];
            for(int i = 0; i < ret.Length; i++)
                ret.SetValue((Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), i);
            return ret;
        }
    }
}
