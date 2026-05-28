using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
    public partial class OverviewControl : XtraUserControl {
        public OverviewControl() {
            InitializeComponent();
            descriptionLabel.AutoSizeInLayoutControl = false;
            descriptionLabel.Text = "<image=#UISuperHero><br>"
                + string.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb())
                + string.Format("<color=#{0:x6}><size=-18>And deliver compelling user-experiences on the WinForms platform<br>", ColorHelper.DisabledTextColor.ToArgb())
                + "with award-winning DevExpress Controls and Libraries.";
            descriptionLabel.HyperlinkClick += descriptionLabel_HyperlinkClick;
            ((WindowsUIButton)buttonsPanel.Buttons[0]).Click += OnOverviewControlGetStartedClick;
            ((WindowsUIButton)buttonsPanel.Buttons[1]).Click += OnOverviewControlGetSupportClick;
            ((WindowsUIButton)buttonsPanel.Buttons[2]).Click += OnOverviewControlByNowClick;
        }

        void OnOverviewControlGetStartedClick(object sender, System.EventArgs e) {
            OutlookFormHelper.DoGettingStarted(DemosInfo.CurrentModule as TutorialControl);
        }

        void OnOverviewControlGetSupportClick(object sender, System.EventArgs e) {
            OutlookFormHelper.DoGetFreeSupport(DemosInfo.CurrentModule as TutorialControl);
        }

        void OnOverviewControlByNowClick(object sender, System.EventArgs e) {
            OutlookFormHelper.DoByNow(DemosInfo.CurrentModule as TutorialControl);
        }

        void descriptionLabel_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            var form = FindForm();
            if(form != null)
                form.Close();
        }

        internal void SetDescription(string description) {
            descriptionLabel.Appearance.Image = null;
            descriptionLabel.Text = "<image=#UISuperHero><br>"
                + string.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb())
                + string.Format("<color=#{0:x6}><size=-18>{1}", ColorHelper.DisabledTextColor.ToArgb(), description);
        }
    }
}
