using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
// <hyperLinkEdit2>
using DevExpress.XtraEditors;
// </hyperLinkEdit2>
// <icbWindowStyle>
// <icbAlignment>
using DevExpress.XtraEditors.Controls;
// </icbAlignment>
// </icbWindowStyle>
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleHyperLinkEdit : TutorialControl  {
        public ModuleHyperLinkEdit() {
            InitializeComponent();
            hyperLinkImage = hyperLinkEditSample.Properties.ContextImageOptions.SvgImage;
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleHyperLinkEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "hyperlinkedit"; } }

        Utils.Svg.SvgImage hyperLinkImage = null;
        bool updateValues = false;

        private void ModuleHyperLinkEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(hyperLinkEditSample);
            InitComboBoxes();
            InitValues();
        }

        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
        }
        void InitComboBoxes() {
            // <icbWindowStyle>
            icbWindowStyle.Properties.Items.AddEnum(typeof(ProcessWindowStyle));
            // </icbWindowStyle>
            // <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(typeof(ContextImageAlignment));
            // </icbAlignment>
        }

        void InitValues() {
            lbStartKey.Text = hyperLinkEditSample.Properties.StartKey.ToString();
            lbAddress.Text = hyperLinkEditSample.Text;
            updateValues = true;
            icbWindowStyle.EditValue = hyperLinkEditSample.Properties.BrowserWindowStyle;
            ceSingleClick.Checked = hyperLinkEditSample.Properties.SingleClick;
            teCaption.Text = hyperLinkEditSample.Properties.Caption;
            icbAlignment.EditValue = hyperLinkEditSample.Properties.ContextImageOptions.Alignment;
            colorEditLinkColor.Color = hyperLinkEditSample.Properties.LinkColor;
            updateValues = false;
        }

        // <icbWindowStyle>
        private void icbWindowStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            hyperLinkEditSample.Properties.BrowserWindowStyle = (ProcessWindowStyle)icbWindowStyle.EditValue;
        }
        // </icbWindowStyle>

        // <ceSingleClick>
        private void ceSingleClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            hyperLinkEditSample.Properties.SingleClick = ceSingleClick.Checked;
        }
        // </ceSingleClick>

        // <teCaption>
        private void teCaption_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            hyperLinkEditSample.Properties.Caption = teCaption.Text;
        }
        // </teCaption>

        // <sbImageSet>
        private void sbImageSet_Click(object sender, System.EventArgs e) {
            hyperLinkEditSample.Properties.ContextImageOptions.SvgImage = hyperLinkImage;
        }
        // </sbImageSet>

        // <sbImageClear>
        private void sbImageClear_Click(object sender, System.EventArgs e) {
            hyperLinkEditSample.Properties.ContextImageOptions.SvgImage = null;
        }
        // </sbImageClear>

        // <icbAlignment>
        private void icbAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            hyperLinkEditSample.Properties.ContextImageOptions.Alignment = (ContextImageAlignment)icbAlignment.EditValue;
        }
        // </icbAlignment>

        // <colorEditLinkColor>
        private void colorEditLinkColor_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            hyperLinkEditSample.Properties.LinkColor = colorEditLinkColor.Color;
        }
        // </colorEditLinkColor>

        // <hyperLinkEdit2>
        private void hyperLinkEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            HyperLinkEdit editor = sender as HyperLinkEdit;
            editor.ShowBrowser("https://www.devexpress.com/ClientCenter/Order/?group=.NET");
        }
        // </hyperLinkEdit2>

        // <hyperLinkEdit1>
        void ShowEvent(string eventString, string data) {
            meFiringEvents.Text = string.Format("{0}: {1}\r\n", eventString, data) + meFiringEvents.Text;
        }

        private void hyperLinkEdit_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e) {
            ShowEvent("OpenLink", e.EditValue.ToString());
        }
        // </hyperLinkEdit1>
    }
}

