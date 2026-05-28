using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleOverlayForm : TutorialControl {
        readonly OverlayWindowOptions options;

        public ModuleOverlayForm() {
            this.options = new OverlayWindowOptions(opacity: 100d/255);
            InitializeComponent();
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitValues();
        }
        void InitValues() {
            cbViewType.Properties.AddEnum<WaitAnimationType>();
            cbViewType.EditValue = WaitAnimationType.Line;
            backColorEdit.Color = options.BackColor;
            foreColorEdit.Color = options.ForeColor;
            allowFadeInCheckEdit.Checked = options.FadeIn;
            allowFadeOutCheckEdit.Checked = options.FadeOut;
            spinOpacity.Value = (int)(options.Opacity.Value * 255 + 0.5);
        }
        // <backColorEdit>
        void OnBackColorEditValueChanged(object sender, EventArgs e) {
            Color color = ((ColorEdit)sender).Color;
            options.BackColor = color;
        }
        // </backColorEdit>
        // <foreColorEdit>
        void OnForeColorEditValueChanged(object sender, EventArgs e) {
            Color color = ((ColorEdit)sender).Color;
            options.ForeColor = color;
        }
        // </foreColorEdit>
        // <spinOpacity>
        void OnOpacityEditValueChanged(object sender, EventArgs e) {
            options.Opacity = (byte)spinOpacity.Value / 255D;
        }
        // </spinOpacity>
        // <allowFadeInCheckEdit>
        void OnAllowFadeInEditValueChanged(object sender, EventArgs e) {
            options.FadeIn = ((CheckEdit)sender).Checked;
        }
        // </allowFadeInCheckEdit>
        // <allowFadeOutCheckEdit>
        void OnAllowFadeOutEditValueChanged(object sender, EventArgs e) {
            options.FadeOut = ((CheckEdit)sender).Checked;
        }
        // </allowFadeOutCheckEdit>
        // <cbViewType>
        void OnViewTypeChanged(object sender, EventArgs e) {
            WaitAnimationType animationType = (WaitAnimationType)((BaseEdit)sender).EditValue;
            options.AnimationType = animationType;
        }
        // </cbViewType>
        // <btnShow>
        void OnShowClick(object sender, EventArgs e) {
            IOverlaySplashScreenHandle overlayHandle = SplashScreenManager.ShowOverlayForm(layoutControl, options);
            Timer timer = new Timer() { Interval = 4000 };
            timer.Tick += (ss, ee) => {
                overlayHandle.Close();
                timer.Dispose();
            };
            timer.Start();
        }
        // </btnShow>
    }
}
