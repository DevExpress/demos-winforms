//<ceShowIndicatorIcons>
//<ceShowStepIcons>
using DevExpress.Utils.Svg;
//</ceShowStepIcons>
//</ceShowIndicatorIcons>
using System;
using System.Collections.Generic;
//<icbOrientation>
using System.Windows.Forms;
//</icbOrientation>
//<ceFillIndicators>
using DevExpress.XtraEditors;
//</ceFillIndicators>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleStepProgressBar : TutorialControl {
        bool inInitialization = false;
        bool incrementAnimation = true;
        const int timerSleepInterval = 1000;
        const int itemInterval = 4;
        Timer timer;
        //<ceShowStepIcons>
        //<ceShowIndicatorIcons>
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleStepProgressBar));
        //</ceShowStepIcons>
        //</ceShowIndicatorIcons>

        public ModuleStepProgressBar() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleStepProgressBar" }; } }
        protected override string WhatsThisXMLFileName { get { return "stepProgressBar"; } }
        void ModuleStepProgressBar_Load(object sender, System.EventArgs e) {
            InitComboBoxes();
            InitValues();
            InitTimer();
        }

        void InitComboBoxes() {
            icbOrientation.Properties.Items.AddEnum(typeof(Orientation));
        }

        void InitValues() {
            inInitialization = true;
            tbcSelectStep.Value = stepProgressBarSample.SelectedItemIndex;
            icbOrientation.EditValue = stepProgressBarSample.Orientation;
            ceInversedProgressDirection.Checked = stepProgressBarSample.InversedProgressDirection;
            ceDrawConnectors.Checked = stepProgressBarSample.DrawConnectors;
            ceFillIndicators.Checked = stepProgressBarSample.ItemOptions.Indicator.InactiveStateDrawMode == IndicatorDrawMode.Full;
            ceDrawShadows.Checked = true;
            ceAllowUserInteraction.Checked = stepProgressBarSample.AllowUserInteraction == Utils.DefaultBoolean.True;
            inInitialization = false;
        }
        void InitTimer() {
            timer = new Timer() { Interval = itemInterval };
            StepProgressBarItem item = stepProgressBarSample.SelectedItem;
      
            timer.Tick += (ss, ee) => {
                timer.Interval = itemInterval;
                item.Progress += incrementAnimation ? 1 : -1;
                if(item.IsActive) {
                    if(item.IsLastItem) {
                        timer.Interval = timerSleepInterval;
                        incrementAnimation = false;
                        return;
                    }
                    item = item.GetNextItem();
                }
                if(item.Progress == 0 && !incrementAnimation) {
                    if(item == itemShippingOptions) {
                        timer.Interval = timerSleepInterval;
                        incrementAnimation = true;
                        return;
                    }
                    item = item.GetPreviousItem();
                }
            };
            timer.Enabled = ceAllowAnimation.Checked;
        }
        //<tbcSelectStep>
        private void tbcSelectStep_EditValueChanged(object sender, System.EventArgs e) {
            stepProgressBarSample.SelectedItemIndex = tbcSelectStep.Value;
        }
        //</tbcSelectStep>
        //<icbOrientation>
        private void icbOrientation_SelectedIndexChanged(object sender, System.EventArgs e) {
            //<skip>
            if (inInitialization) return;
            //</skip>
            stepProgressBarSample.Orientation = (Orientation)icbOrientation.EditValue;
        }
        //</icbOrientation>
        //<ceInversedProgressDirection>
        private void ceInversedProgressDirection_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if (inInitialization) return;
            //</skip>
            stepProgressBarSample.InversedProgressDirection = ceInversedProgressDirection.Checked;
        }
        //</ceInversedProgressDirection>
        //<ceDrawConnectors>
        private void ceDrawConnectors_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if (inInitialization) return;
            //</skip>
            stepProgressBarSample.DrawConnectors = ceDrawConnectors.Checked;
        }
        //</ceDrawConnectors>
        //<ceFillIndicators>
        private void ceFillIndicators_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if (inInitialization) return;
            //</skip>
            stepProgressBarSample.ItemOptions.Indicator.InactiveStateDrawMode = ceFillIndicators.Checked ? IndicatorDrawMode.Full : IndicatorDrawMode.Outline;
        }
        //</ceFillIndicators>
        //<ceShowStepIcons>
        private void ceShowStepIcons_CheckedChanged(object sender, System.EventArgs e) {
            itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage") : null;
            itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage") : null;
            itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage") : null;
            itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage") : null;
            itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage") : null;
            itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage") : null;
            itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage") : null;
            itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage = ceShowStepIcons.Checked ? (SvgImage)resources.GetObject("itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage") : null;
        }
        //</ceShowStepIcons>
        //<ceShowIndicatorIcons>
        void ceShowIndicatorIcons_CheckedChanged(object sender, System.EventArgs e) {
            stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = ceShowIndicatorIcons.Checked ? (SvgImage)resources.GetObject("stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage") : null;
        }
        //</ceShowIndicatorIcons>
        //<ceAllowAnimation>
        void ceAllowAnimation_CheckedChanged(object sender, System.EventArgs e) {
            timer.Enabled = ceAllowAnimation.Checked;
            tbcSelectStep.Enabled = !ceAllowAnimation.Checked;
            tbcSelectStep.Value = stepProgressBarSample.SelectedItemIndex;
        }
        //</ceAllowAnimation>
        //<ceDrawShadows>
        void ceDrawShadows_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if(inInitialization) return;
            //</skip>
            stepProgressBarSample.ShadowDrawMode = ceDrawShadows.Checked ? StepProgressBarShadowDrawMode.ActiveElements : StepProgressBarShadowDrawMode.None;
        }
        //</ceDrawShadows>
        //<ceAllowUserInteraction>
        void ceAllowUserInteraction_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if(inInitialization) return;
            //</skip>
            stepProgressBarSample.AllowUserInteraction = ceAllowUserInteraction.Checked ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
        }
        //</ceAllowUserInteraction>
        void stepProgressBarSample_ItemClick(object sender, StepProgressBarItemClickEventArgs e) {
            tbcSelectStep.Value = stepProgressBarSample.Items.IndexOf(e.Item);
        }
    }
}
