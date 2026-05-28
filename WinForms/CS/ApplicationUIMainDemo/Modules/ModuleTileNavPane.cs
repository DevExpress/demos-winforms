using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ModuleTileNavPane : TutorialControlBase {
        public ModuleTileNavPane() {
            InitializeComponent();
            SelectHomePath();
        }
        void SelectHomePath() {
            tileNavPane.SelectedElement = catMarketing;
        }
        void tileNavPane_TileClick(object sender, NavElementEventArgs e) {
            var item = e.Element as TileNavItem;
            if(item != null && item.Category == catCreateNew) {
                AddToLog("Tile clicked: " + e.Element.Caption);
                tileNavPane.HideDropDownWindow();
            }
        }
        void navButtonHome_ElementClick(object sender, NavElementEventArgs e) {
            AddToLog("Button clicked: Home");
            SelectHomePath();
        }
        void tileNavPane_SelectedElementChanged(object sender, TileNavElementEventArgs e) {
            string _name = e.Element == null ? "null" : e.Element.Caption;
            AddToLog("Selected element changed: " + _name);
        }
        void navButtonSettings_ElementClick(object sender, NavElementEventArgs e) {
            AddToLog("Button clicked: Settings");
        }
        void navButtonHelp_ElementClick(object sender, NavElementEventArgs e) {
            AddToLog("Button clicked: Help");
        }
        void AddToLog(string value) {
            eventsLog.Text = value + Environment.NewLine + eventsLog.Text;
        }
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            tileNavPane.HideDropDownWindow();
            if(cbDock.SelectedIndex == 0)
                tileNavPane.Dock = DockStyle.Top;
            else
                tileNavPane.Dock = DockStyle.Bottom;
        }
        void ceItemShadow_CheckedChanged(object sender, EventArgs e) {
            var value = ceItemShadow.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            tileNavPane.OptionsPrimaryDropDown.ShowItemShadow = value;
            tileNavPane.OptionsSecondaryDropDown.ShowItemShadow = value;
            tileNavPane.HideDropDownWindow();
        }
        void ceOuterClick_CheckedChanged(object sender, EventArgs e) {
            var value = ceOuterClick.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            tileNavPane.OptionsPrimaryDropDown.CloseOnOuterClick = value;
        }
        void ceContinueNavigation_CheckedChanged(object sender, EventArgs e) {
            tileNavPane.ContinuousNavigation = ceContinueNavigation.Checked;
        }
        void seDropDownHeight_EditValueChanged(object sender, EventArgs e) {
            tileNavPane.OptionsPrimaryDropDown.Height = (int)seDropDownHeight.Value;
            tileNavPane.HideDropDownWindow();
        }
        void btnClearEventLog_Click(object sender, EventArgs e) {
            eventsLog.Text = string.Empty;
        }
        protected override void DoHide() {
            base.DoHide();
            if(tileNavPane != null) tileNavPane.HideDropDownWindow();
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            if(panelContainer == null) return;
            int x = (this.Width / 2) - (panelContainer.Width / 2);
            int y = (this.Height / 2) - (panelContainer.Height / 2);
            panelContainer.Location = new Point(x, y);
        }
        protected override bool? AllowBorderRounding {
            get { return true; }
        }
    }
}
