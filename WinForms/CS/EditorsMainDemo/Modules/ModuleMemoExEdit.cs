using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbScrollBars>
using DevExpress.XtraEditors.Controls;
// </icbScrollBars>
using System.Windows.Forms;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleMemoExEdit : TutorialControl {
        public ModuleMemoExEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleMemoExEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "memoeditex"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleMemoExEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(memoExEditSample);
            memoExEditSample.Text = @"This control allows end users to edit memo data within the dropdown window. This control is the best choice when you need to save form space or when you want to provide convenient memo editing in container controls like the XtraGrid. The MemoExEdit control combines the features found in the MemoEdit control and the BLOBEditor.";
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            // <icbScrollBars>
            icbScrollBars.Properties.Items.AddEnum(typeof(ScrollBars));
            icbScrollBars.EditValue = memoExEditSample.Properties.ScrollBars;
            // </icbScrollBars>
        }


        void InitValues() {
            updateValues = true;
            icbScrollBars.EditValue = memoExEditSample.Properties.ScrollBars;
            ceIcon.Checked = memoExEditSample.Properties.ShowIcon;
            cePopupSizeable.Checked = memoExEditSample.Properties.PopupSizeable;
            ceWordWrap.Checked = memoExEditSample.Properties.WordWrap;
            ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon;
            ceAutoHideScrollBars.Checked = memoExEditSample.Properties.AutoHideScrollBars == DevExpress.Utils.DefaultBoolean.True;
            updateValues = false;
        }

        // <icbScrollBars>
        private void icbScrollBars_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            memoExEditSample.Properties.ScrollBars = (ScrollBars)icbScrollBars.EditValue;
        }
        // </icbScrollBars>

        // <ceIcon>
        private void ceIcon_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            memoExEditSample.Properties.ShowIcon = ceIcon.Checked;
            // <ceCustomIcons>
            ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon;
            // </ceCustomIcons>
        }
        // </ceIcon>

        // <cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            memoExEditSample.Properties.PopupSizeable = cePopupSizeable.Checked;
        }
        // </cePopupSizeable>

        // <ceWordWrap>
        private void ceWordWrap_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            memoExEditSample.Properties.WordWrap = ceWordWrap.Checked;
        }
        // </ceWordWrap>

        // <ceAutoHideScrollBars>
        private void ceAutoHideScrollBars_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            memoExEditSample.Properties.AutoHideScrollBars = ceAutoHideScrollBars.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            // <skip>
            if(ceAutoHideScrollBars.Checked && memoExEditSample.Properties.ScrollBars == ScrollBars.None)
                icbScrollBars.EditValue = ScrollBars.Vertical;
            // </skip>
        }
        // </ceAutoHideScrollBars>

        // <ceCustomIcons>
        private void ceCustomIcons_CheckedChanged(object sender, System.EventArgs e) {
            memoExEditSample.Properties.Images = ceCustomIcons.Checked ? imageCollection1 : null;
        }
        // </ceCustomIcons>
    }
}

