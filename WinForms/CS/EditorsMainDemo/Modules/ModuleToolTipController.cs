using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors.Common;
using DevExpress.Utils.Text;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Demos.Modules;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleToolTipController : TutorialControl {
        LabelControl _clockLabelControl;
        TimerControl _timerControl;
        public ModuleToolTipController() {
            InitializeComponent();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }

        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl3);
            CalcLayoutControlBounds(layoutControl4);
        }

        bool updateValues = false;
        string[] titleStyleToolTip = new string[] { "ToolTip Controller component", "<b>ToolTip <i>Controller  </i>component"};
        string[] textStyleToolTip = new string[] {
            "Enables you to customize the appearance and behavior of hints displayed for controls or their elements.", 
            "Enables<size=8> you to <size=14>customize <size=8>the appearance and behavior of <u>hints</u> displayed for controls or their elements."};
        string[] footerStyleToolTip = new string[] { "To learn more, see the help documentation", 
            "<color=Blue>To learn more, see the <u>help documentation"};

        private void ModuleToolTipController_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSample);
            lbSample.Top += 5;
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSampleManual);
            lbSampleManual.Top += 5;
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbStyleSample);
            lbStyleSample.Top += 5;
            InitValues();
            InitToolTips();
        }

        void InitToolTips() {
        }


        void InitValues() {
            updateValues = true;
            toolTipControllerContentProperties1.Init(toolTipController1, lbSample, "This tooltip is automatically displayed\r\nwhen the mouse hovers over the control.", "Auto-popup tooltip.", false);
            toolTipControllerContentProperties2.Init(toolTipController1, lbSampleManual, "This tooltip is displayed using the ShowHint method.", "Manually-popup tooltip.", true);
            seAutoPopDelay.Value = toolTipController1.AutoPopDelay;
            seInitialDelay.Value = toolTipController1.InitialDelay;
            seRoundRadius.Value = toolTipController1.RoundRadius;
            ceRounded.Checked = toolTipController1.Rounded;
            ceShowBeak.Checked = toolTipController1.ShowBeak;
            ceShowShadow.Checked = toolTipController1.ShowShadow;
            propertyGrid1.SelectedObject = new DevExpress.Utils.Design.FilterObject(toolTipController1.Appearance, new string[] { "BackColor", "BackColor2", "BorderColor", "GradientMode", "Font", "ForeColor", "TextOptions" });
            propertyGrid2.SelectedObject = new DevExpress.Utils.Design.FilterObject(toolTipController1.AppearanceTitle, new string[] { "Font", "ForeColor", "TextOptions" });
            Array arr = Enum.GetValues(typeof(ToolTipType));
            foreach(ToolTipType type in arr) {
                if(type == ToolTipType.Default) continue;
                icbType.Properties.Items.Add(new ImageComboBoxItem(type.ToString(), type, -1));
            }
            icbType.EditValue = toolTipStyleController.ToolTipType;
            chAllowHTML.Checked = toolTipStyleController.AllowHtmlText;
            SetStyleTooltip();
            updateValues = false;
        }

        private void seAutoPopDelay_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.AutoPopDelay = Convert.ToInt32(seAutoPopDelay.Value);
        }

        private void seInitialDelay_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.InitialDelay = Convert.ToInt32(seInitialDelay.Value);
        }

        private void seRoundRadius_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.RoundRadius = Convert.ToInt32(seRoundRadius.Value);
        }

        private void ceRounded_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.Rounded = ceRounded.Checked;
        }

        private void ceShowBeak_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.ShowBeak = ceShowBeak.Checked;
        }

        private void ceShowShadow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.ShowShadow = ceShowShadow.Checked;
        }

        private void pceToolTipLocation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            pceToolTipLocation.Properties.PopupFormMinSize = toolTipLocationControl.Size;
            pceToolTipLocation.Properties.PopupSizeable = false;
        }

        private void pceToolTipLocation_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e) {
            e.DisplayText = toolTipLocationControl.ToolTipLocationName;
        }

        private void toolTipLocationControl_ToolTipLocationChanged(object sender, System.EventArgs e) {
            pceToolTipLocation.Refresh();
            ToolTipControllerShowEventArgs args = toolTipController1.CreateShowArgs();
            args.ToolTip = "Test";
            args.IconType = ToolTipIconType.Information;
            args.ImageIndex = -1;
            args.IconSize = ToolTipIconSize.Small;
            toolTipController1.ShowHint(args, lbSample);
        }

        private void lbSampleManual_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            ToolTipControllerShowEventArgs args = toolTipControllerContentProperties2.CreateShowArgs();
            toolTipController1.ShowHint(args, lbSampleManual.PointToScreen(new Point(e.X, e.Y)));
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            toolTipController1.HideHint();
        }

        protected override void DoHide() {
            toolTipController1.HideHint();
        }

        private void icbType_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            toolTipStyleController.ToolTipType = (ToolTipType)icbType.EditValue;
            SetStyleTooltip();
        }

        private void chAllowHTML_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            toolTipStyleController.AllowHtmlText = chAllowHTML.Checked;
            SetStyleTooltip();
        }

        void SetStyleTooltip() {
            int index = toolTipStyleController.AllowHtmlText ? 1 : 0;
            bool canRemoveFormating = toolTipStyleController.ToolTipType == ToolTipType.Flyout || toolTipStyleController.ToolTipType == ToolTipType.Html;
            if(toolTipStyleController.ToolTipType == ToolTipType.SuperTip || canRemoveFormating) {
                DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
                DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
                toolTipItem.Text = canRemoveFormating ? StringPainter.Default.RemoveFormat(textStyleToolTip[index]) : textStyleToolTip[index];
                toolTipItem.ImageOptions.SvgImage = svgImageCollection1[0];
                superToolTip.Items.AddTitle(canRemoveFormating ? StringPainter.Default.RemoveFormat(titleStyleToolTip[index]) : titleStyleToolTip[index]);
                superToolTip.Items.Add(toolTipItem);
                superToolTip.Items.AddSeparator();
                superToolTip.Items.AddTitle(canRemoveFormating ? StringPainter.Default.RemoveFormat(footerStyleToolTip[index]) : footerStyleToolTip[index]);
                toolTipStyleController.SetSuperTip(lbStyleSample, superToolTip);
            }
            else {
                toolTipStyleController.SetToolTip(lbStyleSample, textStyleToolTip[index]);
                toolTipStyleController.SetTitle(lbStyleSample, titleStyleToolTip[index]);
                toolTipStyleController.SetToolTipIconType(lbStyleSample, ToolTipIconType.Information);
            }
        }
        LabelControl ClockLabelControl {
            get {
                if(_clockLabelControl == null) {
                    _clockLabelControl = new LabelControl();
                    _clockLabelControl.AllowHtmlString = true;
                    _clockLabelControl.Text = "<b><size=+5>12:00:00 AM</b><br>Wednesday, September 30, 2110";
                    _clockLabelControl.Padding = new Padding(10);
                    _clockLabelControl.AutoSizeMode = LabelAutoSizeMode.Vertical;
                    _clockLabelControl.ImageOptions.SvgImage = svgImageCollection1[1];
                    behaviorManager1.Attach<ClockBehavior>(_clockLabelControl, behavior => {
                        behavior.Properties.TimeOptions.Color = Color.CornflowerBlue;
                        behavior.Properties.TimeOptions.FontStyle = FontStyle.Bold;
                        behavior.Properties.TimeOptions.FontSizeDelta = 5;
                    });
                    _clockLabelControl.ImageAlignToText = ImageAlignToText.LeftCenter;
                    _clockLabelControl.IndentBetweenImageAndText = 10;
                    _clockLabelControl.Size = _clockLabelControl.CalcBestSize();
                    _clockLabelControl.SizeChanged += ClockLabelControl_SizeChanged;
                }
                return _clockLabelControl;
            }
        }

        bool clockLabelControlSizeChanging = false;
        private void ClockLabelControl_SizeChanged(object sender, EventArgs e) {
            if(clockLabelControlSizeChanging)
                return;
            clockLabelControlSizeChanging = true;
            Size bestSize = ClockLabelControl.CalcBestSize();
            if(ClockLabelControl.Size != bestSize)
                ClockLabelControl.Size = bestSize;
            clockLabelControlSizeChanging = false;
        }

        TimerControl TimerControl {
            get {
                if(_timerControl == null)
                    _timerControl = new TimerControl();
                return _timerControl;
            }
        }
        private void OnShowBeakChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            flyoutToolTipController.ShowBeak = edit.Checked;
        }

        private void OnGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.Info == null) {
                e.Info = new ToolTipControlInfo() { Object = e.SelectedControl};
                if(radioGroupExamples.SelectedIndex == 0)
                    e.Info.FlyoutControl = ClockLabelControl;
                else
                    e.Info.FlyoutControl = TimerControl;
            }
        }
    }
}

