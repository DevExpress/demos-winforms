using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleFlyoutPanel : TutorialControl  {
        FlyoutModuleOptions _options;
        public ModuleFlyoutPanel() {
            this._options = new FlyoutModuleOptions();
            InitializeComponent();
            TutorialInfo.TutorialName = "FlyoutPanel Tutorial";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitControls();
            UpdateControls();
        }
        protected override void DoHide() {
            base.DoHide();
            HideToolWindowCore();
        }
        void InitControls() {
            foreach(PopupToolWindowAnchor anchorType in Enum.GetValues(typeof(PopupToolWindowAnchor))) {
                cbAnchorTypes.Properties.Items.Add(anchorType);
            }
            cbAnchorTypes.EditValue = Options.Anchor;
            foreach(PopupToolWindowAnimation animationType in Enum.GetValues(typeof(PopupToolWindowAnimation))) {
                cbAnimationTypes.Properties.Items.Add(animationType);
            }
            cbAnimationTypes.EditValue = Options.AnimationType;
            ceCloseOnOuterClick.Checked = Options.CloseOnOuterClick;
            spinEditXCoord.Value = Options.XCoord;
            spinEditYCoord.Value = Options.YCoord;
        }
        //<cbAnchorTypes>
        void OnAnchorTypeSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit edit = (ComboBoxEdit)sender;
            Options.Anchor = (PopupToolWindowAnchor)edit.EditValue;
            if(Options.Anchor == PopupToolWindowAnchor.Center || Options.Anchor == PopupToolWindowAnchor.Manual)
                cbAnimationTypes.EditValue = PopupToolWindowAnimation.Fade;
            UpdateControls();
        }
        //</cbAnchorTypes>
        //<cbAnimationTypes>
        void OnAnimationTypesSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit edit = (ComboBoxEdit)sender;
            Options.AnimationType = (PopupToolWindowAnimation)edit.EditValue;
        }
        //</cbAnimationTypes>
        //<ceCloseOnOuterClick>
        void OnCloseOnOuterClickCheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = (CheckEdit)sender;
            Options.CloseOnOuterClick = edit.Checked;
            if(panelCore != null)
                panelCore.Options.CloseOnOuterClick = Options.CloseOnOuterClick;
        }
        //</ceCloseOnOuterClick>
        //<spinEditXCoord>
        void OnCoordEditValueChanged(object sender, EventArgs e) {
            SpinEdit edit = (SpinEdit)sender;
            Options.XCoord = (int)edit.Value;
        }
        //</spinEditXCoord>
        //<spinEditYCoord>
        void OnYCoordEditValueChanged(object sender, EventArgs e) {
            SpinEdit edit = (SpinEdit)sender;
            Options.YCoord = (int)edit.Value;
        }
        //</spinEditYCoord>
        //<horzFlyoutPanel>
        void OnFlyoutPanelHidden(object sender, FlyoutPanelEventArgs e) {
            FlyoutPanel panel = (FlyoutPanel)sender;
            if(panelCore == null || !object.ReferenceEquals(panel, panelCore))
                return;
            panelCore = null;
            UpdateControls();
        }
        //</horzFlyoutPanel>
        //<btnShowToolWindow>
        void OnShowToolWindowClick(object sender, EventArgs e) {
            ShowToolWindowCore();
        }
        //</btnShowToolWindow>
        //<btnHideToolWindow>
        void OnHideToolWindowClick(object sender, EventArgs e) {
            HideToolWindowCore();
        }
        //</btnHideToolWindow>
        FlyoutPanel panelCore = null;
        void ShowToolWindowCore() {
            FlyoutPanel panel = SelectPanel();
            panel.Options.AnchorType = _options.Anchor;
            panel.Options.AnimationType = _options.AnimationType;
            panel.Options.CloseOnOuterClick = _options.CloseOnOuterClick;
            panel.Options.Location = Options.ManualPoint;
            panel.ShowPopup();
            panelCore = panel;
            UpdateControls();
        }
        void HideToolWindowCore() {
            if(panelCore == null) return;
            panelCore.HidePopup();
            panelCore = null;
            UpdateControls();
        }
        FlyoutPanel SelectPanel() {
            if(Options.Anchor == PopupToolWindowAnchor.Left || Options.Anchor == PopupToolWindowAnchor.Right)
                return vertFlyoutPanel;
            return horzFlyoutPanel;
        }
        void UpdateControls() {
            btnShowToolWindow.Enabled = (panelCore == null);
            btnHideToolWindow.Enabled = !btnShowToolWindow.Enabled;
            spinEditXCoord.Enabled = spinEditYCoord.Enabled = lblXCoord.Enabled = lblYCoord.Enabled = (Options.Anchor == PopupToolWindowAnchor.Manual);
        }
        public FlyoutModuleOptions Options { get { return _options; } }
    }

    public class FlyoutModuleOptions {
        public FlyoutModuleOptions() {
            this.Anchor = PopupToolWindowAnchor.Top;
            this.AnimationType = PopupToolWindowAnimation.Slide;
            this.CloseOnOuterClick = false;
            this.XCoord = this.YCoord = 0;
        }
        public PopupToolWindowAnchor Anchor { get; set; }
        public PopupToolWindowAnimation AnimationType { get; set; }
        public bool CloseOnOuterClick { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public Point ManualPoint { get { return new Point(XCoord, YCoord); } }
    }
}
