using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <comboBoxProgressStyle> <checkEditVertical>
using DevExpress.XtraEditors.Controls;
// </comboBoxProgressStyle> </checkEditVertical>
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Threading;
using DevExpress.Utils.Drawing;
using DevExpress.Tutorials;
using DevExpress.LookAndFeel;
using DevExpress.XtraLayout;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleProgressBar : TutorialControl {
        public ModuleProgressBar() {
            InitializeComponent();
            if(tabPane1 != null) {
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
                tabPane1.VisibleChanged += OnTabControlVisibleChanged;
            }
            UpdateVisualSettings();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleProgressBar" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "progressBar"; }
        }
        void UpdateVisualSettings() {
            comboBoxProgressStyle.Enabled = UserLookAndFeel.Default.ActiveStyle != ActiveLookAndFeelStyle.Skin;
            bool colorPanelVisibility = UserLookAndFeel.Default.ActiveStyle != ActiveLookAndFeelStyle.Skin;
            layoutControlGroup7.Visibility = colorPanelVisibility ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        protected override void OnLookAndFeelChanged(object sender, EventArgs e) {
            base.OnLookAndFeelChanged(sender, e);
            UpdateVisualSettings();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null) {
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
                tabPane1.VisibleChanged -= OnTabControlVisibleChanged;
            }
        }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        void OnTabControlVisibleChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        protected override void CalcContentCore() {
            if(!Visible || !IsHandleCreated) return;
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) {
            tabControl.LayoutChanged();
        }

        bool increment = true;
        bool updateValues = false;
        bool incrementInternal = true;

        // <btnApplyColors>
        private void btnApplyColors_Click(object sender, System.EventArgs e) {
            progressBarSample.Properties.StartColor = colorEditStartColor.Color;
            progressBarSample.Properties.EndColor = colorEditEndColor.Color;
        }
        // </btnApplyColors>

        // <comboBoxProgressStyle>
        private void comboBoxProgressStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            ProgressViewStyle[] styles = new ProgressViewStyle[] { 
				ProgressViewStyle.Solid,
				ProgressViewStyle.Broken };
            progressBarSample.Properties.ProgressViewStyle = styles[comboBoxProgressStyle.SelectedIndex];
        }
        // </comboBoxProgressStyle>

        // <checkEditVertical>
        private void checkEditVertical_CheckedChanged(object sender, System.EventArgs e) {
            ProgressKind kind = ProgressKind.Horizontal;
            if(checkEditVertical.Checked)
                kind = ProgressKind.Vertical;
            progressBarSample.Properties.ProgressKind = kind;
            UpdateProgressBarBounds(progressBarSample);
        }
        // </checkEditVertical>

        // <checkEditVertical>
        private void UpdateProgressBarBounds(ProgressBarControl progressBar) {
            if(progressBar.Properties.ProgressKind == ProgressKind.Horizontal) {
                progressBar.Height = GetProgressBarSize(progressBar);
                ControlUtils.HorzAlignControlInParent(progressBar, 16);
            }
            else {
                progressBar.Width = GetProgressBarSize(progressBar);
                ControlUtils.VertAlignControlInParent(progressBar, 32);
            }
            ControlUtils.CenterControlInParent(progressBar);
        }
        // </checkEditVertical>
        int GetProgressBarSize(ProgressBarControl progressBar) {
            return progressBar.Properties.ProgressKind == ProgressKind.Vertical && progressBar.Properties.TextOrientation == TextOrientation.Horizontal ? 30 : 20;
        }
        // <checkEditShowText>
        private void checkEditShowText_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            progressBarSample.Properties.ShowTitle = checkEditShowText.Checked;
            checkEditShowPercent.Enabled = checkEditShowText.Checked;
        }
        // </checkEditShowText>

        // <checkEditShowPercent>
        private void checkEditShowPercent_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            progressBarSample.Properties.PercentView = checkEditShowPercent.Checked;
        }
        // </checkEditShowPercent>

        // <colorEditTextColor>
        private void colorEditTextColor_EditValueChanged(object sender, System.EventArgs e) {
            progressBarSample.Properties.Appearance.ForeColor = colorEditTextColor.Color;
        }
        // </colorEditTextColor>

        // <spinEditStep>
        private void spinEditStep_EditValueChanged(object sender, System.EventArgs e) {
            progressBarSample2.Properties.Step = (int)spinEditStep.Value;
        }
        // </spinEditStep>

        // <btnSetMinimum>
        private void btnSetMinimum_Click(object sender, System.EventArgs e) {
            progressBarSample2.Position = progressBarSample2.Properties.Minimum;
        }
        // </btnSetMinimum>

        // <btnSetMaximum>
        private void btnSetMaximum_Click(object sender, System.EventArgs e) {
            progressBarSample2.Position = progressBarSample2.Properties.Maximum;
        }
        // </btnSetMaximum>

        // <textEditCurrentValue>
        private void progressBarSample2_EditValueChanged(object sender, System.EventArgs e) {
            textEditCurrentValue.Text = progressBarSample2.Position.ToString();
        }
        // </textEditCurrentValue>

        // <buttonsUpDown>
        private void buttonsUpDown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            checkEditAnimation.Checked = false;
            checkEditAnimation.Update();
            if(e.Button.Caption == "Up")
                RunVariableIncrement();
            if(e.Button.Caption == "Down")
                RunVariableDecrement();
        }
        // </buttonsUpDown>

        // <buttonsUpDown>
        private void RunVariableIncrement() {
            progressBarSample2.Position = progressBarSample2.Properties.Minimum;
            double currentStep = (progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) / 4;
            while(progressBarSample2.Position + currentStep < progressBarSample2.Properties.Maximum) {
                progressBarSample2.Increment((int)Math.Ceiling(currentStep));
                progressBarSample2.Update();
                textEditCurrentValue.Update();
                System.Threading.Thread.Sleep(100);
                currentStep /= 1.5;
            }
        }
        private void RunVariableDecrement() {
            progressBarSample2.Position = progressBarSample2.Properties.Maximum;
            double currentStep = (progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) / 4;
            while(progressBarSample2.Position - currentStep > progressBarSample2.Properties.Minimum) {
                progressBarSample2.Decrement((int)Math.Ceiling(currentStep));
                progressBarSample2.Update();
                textEditCurrentValue.Update();
                System.Threading.Thread.Sleep(100);
                currentStep /= 1.5;
            }
        }
        // </buttonsUpDown>

        // <comboBoxMaxMin>
        private void comboBoxMaxMin_SelectedIndexChanged(object sender, System.EventArgs e) {
            int[] minValues = new int[] { 0, 100, -100 };
            int[] maxValues = new int[] { 100, 200, 100 };
            progressBarSample2.Properties.Minimum = minValues[comboBoxMaxMin.SelectedIndex];
            progressBarSample2.Properties.Maximum = maxValues[comboBoxMaxMin.SelectedIndex];
            progressBarSample2.Position = progressBarSample2.Properties.Minimum;
        }
        // </comboBoxMaxMin>

        // <checkEditAnimation>
        private void checkEditAnimation_CheckedChanged(object sender, System.EventArgs e) {
            timer.Enabled = checkEditAnimation.Checked;
        }



        private void timer_Tick(object sender, System.EventArgs e) {
            progressBarSample2.Position += (increment) ? 1 : -1;
            if(progressBarSample2.Position == progressBarSample2.Properties.Maximum)
                increment = false;
            if(progressBarSample2.Position == progressBarSample2.Properties.Minimum)
                increment = true;
        }
        // </checkEditAnimation>

        private void TutorialModuleProgressBar_Load(object sender, System.EventArgs e) {
            SetDefaultProgressBarPosition();
            InitValues();
        }
        private void SetDefaultProgressBarPosition() {
            UpdateProgressBarBounds(progressBarSample);
            UpdateProgressBarBounds(progressBarSample2);
        }

        void InitValues() {
            updateValues = true;
            comboBoxProgressStyle.EditValue = progressBarSample.Properties.ProgressViewStyle.ToString();
            checkEditShowText.Checked = progressBarSample.Properties.ShowTitle;
            checkEditShowPercent.Checked = progressBarSample.Properties.PercentView;
            updateValues = false;
            checkEditShowPercent.Enabled = checkEditShowText.Checked;
        }


        private void timerInternal_Tick(object sender, System.EventArgs e) {
            if(MainFormHelper.TakeScreens) return;
            progressBarSample.Position += (incrementInternal) ? 1 : -1;
            if(progressBarSample.Position == progressBarSample.Properties.Maximum)
                incrementInternal = false;
            if(progressBarSample.Position == progressBarSample.Properties.Minimum)
                incrementInternal = true;
        }

        // <buttonsMaxMin>
        private void buttonsMaxMin_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Caption == "Max")
                progressBarSample2.Position = progressBarSample2.Properties.Maximum;
            if(e.Button.Caption == "Min")
                progressBarSample2.Position = progressBarSample2.Properties.Minimum;
        }
        // </buttonsMaxMin>

        // <spinEditStep>
        private void spinEditStep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            progressBarSample2.PerformStep();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            progressBarSample.Properties.FlowAnimationEnabled = checkEdit1.Checked;
            spinDelay.Enabled = checkEdit1.Checked;
            spinSpeed.Enabled = checkEdit1.Checked;
        }

        private void spinSpeed_EditValueChanged(object sender, EventArgs e) {
            var value = spinSpeed.Value;
            if(value > 0 && value < int.MaxValue)
                progressBarSample.Properties.FlowAnimationDuration = (int)value;
        }

        private void spinDelay_EditValueChanged(object sender, EventArgs e) {
            var value = spinDelay.Value;
            if(value > 0 && value < int.MaxValue)
                progressBarSample.Properties.FlowAnimationDelay = (int)value;
        }

        // </spinEditStep>
    }
}

