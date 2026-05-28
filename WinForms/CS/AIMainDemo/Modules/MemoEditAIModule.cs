using DevExpress.LookAndFeel;

namespace DevExpress.AI.Demos {
    public partial class MemoEditAIModule : AITutorialControl {
        public MemoEditAIModule() {
            InitializeComponent();
            UpdatePicture();
            UpdatePaddings();
            layoutControlGroup3.Padding = new XtraLayout.Utils.Padding(0,
                layoutControlGroup3.Padding.Right,
                0,
                layoutControlGroup3.Padding.Bottom);
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePicture();
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }

        void UpdatePicture() {
            pictureEdit2.BackColor = layoutControl2.BackColor;
            if(Utils.Frames.FrameHelper.IsDarkSkin(UserLookAndFeel.Default))
                pictureEdit2.EditValue = Properties.Resources.ai_assistant_menu_dark;
            else
                pictureEdit2.EditValue = Properties.Resources.ai_assistant_menu;
        }
    }
}
