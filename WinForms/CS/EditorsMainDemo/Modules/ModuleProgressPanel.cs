using System;
using DevExpress.Utils.Animation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleProgressPanel : TutorialControl {
        public ModuleProgressPanel() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleProgressPanel" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "progressPanel"; }
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        // <comboBoxAnimationType>
        void comboBoxAnimationType_SelectedIndexChanged(object sender, EventArgs e) {
            switch((string)comboBoxAnimationType.SelectedItem) {
                case ("Default"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Default;
                    break;
                case ("Line"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line;
                    break;
                case ("Ring"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring;
                    break;
                case ("Bar"):
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Bar;
                    break;
            }
            // <skip>
            spinFrameCount.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinFrameInterval.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinElementCount.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinAcceleration.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinSpeed.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            colorEditElementColor.Enabled = (progressPanelSample.WaitAnimationType != WaitingAnimatorType.Default);
            spinLineHeight.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Line);
            comboBoxLineElementType.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Line);
            spinRingDiameter.Enabled = (progressPanelSample.WaitAnimationType == WaitingAnimatorType.Ring);
            // </skip>
        }
        // </comboBoxAnimationType>

        // <spinElementCount>
        void spinElementCount_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationElementCount = (int)spinElementCount.Value;
        }
        // </spinElementCount>

        // <spinAcceleration>
        void spinAcceleration_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationAcceleration = (float)spinAcceleration.Value;
        }
        // </spinAcceleration>

        // <spinSpeed>
        void spinSpeed_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.AnimationSpeed = (float)spinSpeed.Value;
        }
        // </spinSpeed>

        // <spinLineHeight>
        void spinLineHeight_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.LineAnimationElementHeight = (int)spinLineHeight.Value;
        }
        // </spinLineHeight>

        // <comboBoxLineElementType>
        void comboBoxLineElementType_SelectedIndexChanged(object sender, EventArgs e) {
            switch((string)comboBoxLineElementType.SelectedItem) {
                case ("Circle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Circle;
                    break;
                case ("Rectangle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Rectangle;
                    break;
                case ("Triangle"):
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Triangle;
                    break;
            }
        }
        // </comboBoxLineElementType>

        // <spinRingDiameter>
        void spinRingDiameter_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.RingAnimationDiameter = (int)spinRingDiameter.Value;
        }
        // </spinRingDiameter>

        // <colorEditElementColor>
        void colorEditElementColor_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.Appearance.ForeColor = colorEditElementColor.Color;
        }
        // </colorEditElementColor>

        // <spinFrameCount>
        void spinFrameCount_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.FrameCount = (int)spinFrameCount.Value;
        }
        // </spinFrameCount>

        // <spinFrameInterval>
        void spinFrameInterval_EditValueChanged(object sender, EventArgs e) {
            progressPanelSample.FrameInterval = (int)spinFrameInterval.Value;
        }
        // </spinFrameInterval>
    }
}
