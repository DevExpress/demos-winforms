using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Tutorials;
using DevExpress.LookAndFeel;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleMarqueeProgressBar : TutorialControl {
        public ModuleMarqueeProgressBar() {
            InitializeComponent();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
            UpdateSkinInfo();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleMarqueeProgressBar" }; } }
        protected override string WhatsThisXMLFileName { get { return "marqueeProgressBar"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        void UpdateSkinInfo() {
            icbProgressViewStyle.Enabled = UserLookAndFeel.Default.ActiveStyle != ActiveLookAndFeelStyle.Skin;
        }

        void Default_StyleChanged(object sender, EventArgs e) {
            UpdateSkinInfo();
        }

        bool updateValues = false;

        void ModuleMarqueeProgressBar_Load(object sender, System.EventArgs e) {
            SetDefaultProgressBarPosition();
            InitComboBoxes();
            InitValues();
        }

        void SetDefaultProgressBarPosition() {
            UpdateProgressBarBounds(marqueeProgressBarControl1);
        }

        void UpdateProgressBarBounds(MarqueeProgressBarControl progressBar) {
            if(progressBar.Properties.ProgressKind == ProgressKind.Horizontal) {
                progressBar.Height = 20;
                ControlUtils.HorzAlignControlInParent(progressBar, 16);
            }
            else {
                progressBar.Width = 20;
                ControlUtils.VertAlignControlInParent(progressBar, 32);
            }
            ControlUtils.CenterControlInParent(progressBar);
        }

        void InitComboBoxes() {
            icbProgressViewStyle.Properties.Items.AddEnum(typeof(ProgressViewStyle));
        }

        void InitValues() {
            updateValues = true;
            icbProgressViewStyle.EditValue = marqueeProgressBarControl1.Properties.ProgressViewStyle;
            spinEditAnimationSpeed.EditValue = marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed;
            checkEditVertical.Checked = marqueeProgressBarControl1.Properties.ProgressKind == ProgressKind.Vertical;
            checkEditShowTitle.Checked = marqueeProgressBarControl1.Properties.ShowTitle;
            checkEditPause.Checked = marqueeProgressBarControl1.Properties.Paused;
            teTitle.Text = marqueeProgressBarControl1.Text;
            teTitle.Enabled = checkEditShowTitle.Checked;
            updateValues = false;
        }

        //<checkEditVertical>
        void checkEditVertical_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Properties.ProgressKind = checkEditVertical.Checked ? ProgressKind.Vertical : ProgressKind.Horizontal;
            UpdateProgressBarBounds(marqueeProgressBarControl1);
        }
        //</checkEditVertical>

        //<checkEditShowTitle>
        void checkEditShowTitle_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Properties.ShowTitle = checkEditShowTitle.Checked;
            teTitle.Enabled = checkEditShowTitle.Checked;
        }
        //</checkEditShowTitle>

        //<checkEditPause>
        void checkEditPause_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Properties.Paused = checkEditPause.Checked;
        }
        //</checkEditPause>

        //<spinEditAnimationSpeed>
        void spinEditAnimationSpeed_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = (int)spinEditAnimationSpeed.Value;
        }
        //</spinEditAnimationSpeed>

        //<icbProgressViewStyle>
        void icbProgressViewStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Properties.ProgressViewStyle = (ProgressViewStyle)icbProgressViewStyle.EditValue;
        }
        //</icbProgressViewStyle>

        //<teTitle>
        void teTitle_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            marqueeProgressBarControl1.Text = teTitle.Text;
        }
        //</teTitle>
    }
}
