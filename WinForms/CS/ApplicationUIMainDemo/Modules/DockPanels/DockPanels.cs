using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DockPanels : TutorialControlBase {
        int activeIndex = 0;
        BaseControl[] modules = new BaseControl[5];
        Type[] modulesTypes = new Type[] { typeof(SimpleDockPanel), typeof(CentralContainer), typeof(TabContainer), typeof(HorizontalContainer), typeof(VerticalContainer) };
        public DockPanels() {
            InitializeComponent();
        }
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            SetLayoutLabelBackColor();
        }
        void OnDockPanelsLoad(object sender, EventArgs e) {
            InitDefaultContainer();
            SetLayoutLabelBackColor();
        }
        void InitDefaultContainer() {
            var layoutCheckButtons = toolbarPanel.Controls.OfType<CheckButton>().Where(cb => cb.Name.StartsWith(cbLayoutType.Name));
            var checkedLayoutButton = layoutCheckButtons.FirstOrDefault(b => b.Checked);
            int containerIndex = (int)checkedLayoutButton.Tag;
            string superTipText = checkedLayoutButton.SuperTip.ToString();
            SelectContainer(containerIndex, superTipText);
        }
        void SetLayoutLabelBackColor() {
            layoutLabel.Appearance.BackColor = Color.FromArgb(10, DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary);
        }
        void OnLayoutSelectionChanged(object sender, EventArgs e) {
            var checkButton = sender as CheckButton;
            if(checkButton.Tag == null) return;
            int index = (int)checkButton.Tag;
            string _text = checkButton.SuperTip.ToString();
            SelectContainer(index, _text);
        }
        void SelectContainer(int index, string displayText) {
            if(index < 0) return;
            layoutLabel.Text = displayText;
            if(modules[index] == null) {
                ConstructorInfo constructorInfoObj = modulesTypes[index].GetConstructor(Type.EmptyTypes);
                if(constructorInfoObj != null) {
                    modules[index] = constructorInfoObj.Invoke(null) as BaseControl;
                    contentPanel.Controls.Add(modules[index]);
                    modules[index].Dock = DockStyle.Fill;
                }
                else return;
            }
            modules[index].BringToFront();
            if(modules[activeIndex] != null && index != activeIndex) {
                modules[activeIndex].Dispose();
                modules[activeIndex] = null;
            }
            activeIndex = index;
            SetEnableAddPanelButtons(true);
        }
        int maxPanelCount = 10;
        void OnAddPanelButtonClick(object sender, EventArgs e) {
            var button = sender as SimpleButton;
            var dockStyle = (DockingStyle)button.Tag;
            if(modules[activeIndex] != null) {
                if(modules[activeIndex].Manager.Count < maxPanelCount)
                    modules[activeIndex].Manager.AddPanel(dockStyle);
                else
                    SetEnableAddPanelButtons(false);
            }
        }
        void SetEnableAddPanelButtons(bool value) {
            buttonsLabel.Enabled = value;
            var addPanelButtons = toolbarPanel.Controls.OfType<SimpleButton>().Where(cb => cb.Name.StartsWith(sbAddPanel.Name));
            foreach(var addPanelButton in addPanelButtons) {
                addPanelButton.Enabled = value;
            }
        }
        protected override bool? AllowBorderRounding { get { return true; } }
    }
}
