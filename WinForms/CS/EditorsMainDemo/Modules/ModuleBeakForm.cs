using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraEditors.Demos.Properties;
using System.Windows.Forms;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleBeakForm : TutorialControl {
        BeakPanelOptions options;
        FlyoutPanelButtonOptions buttonPanelOptions;
        public ModuleBeakForm() {
            InitializeComponent();
            this.options = this.flyoutPanel.OptionsBeakPanel;
            this.buttonPanelOptions = this.flyoutPanel.OptionsButtonPanel;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleBeakForm" }; } }
        protected override string WhatsThisXMLFileName { get { return "beakForm"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitValues();
        }
        void InitValues() {
            this.backColorEdit.EditValue = this.options.BackColor;
            this.borderColorEdit.EditValue = this.options.BorderColor;
            this.ceCloseOnOuterClick.EditValue = this.options.CloseOnOuterClick;
            this.backColorEdit.Properties.AutomaticColor = this.borderColorEdit.Properties.AutomaticColor = Color.Empty;
            this.ceShowButtonPanel.EditValue = this.flyoutPanel.OptionsButtonPanel.ShowButtonPanel;
            this.cbeButtonPanelLocation.Properties.Items.AddEnum(typeof(FlyoutPanelButtonPanelLocation));
            this.cbeButtonPanelLocation.EditValue = this.buttonPanelOptions.ButtonPanelLocation;
            this.cbeButtonPanelAlignment.Properties.Items.AddEnum(typeof(ContentAlignment));
            this.cbeButtonPanelAlignment.EditValue = this.buttonPanelOptions.ButtonPanelContentAlignment = ContentAlignment.TopRight;
            this.cbeBeakLocation.Properties.Items.AddEnum(typeof(BeakPanelBeakLocation));
            this.cbeBeakLocation.EditValue = this.options.BeakLocation;
            UpdateControls();
        }
        // <previewPanel>
        void OnPreviewPanelMouseEnter(object sender, EventArgs e) {
            EnsureShowBeakForm();
        }
        void EnsureShowBeakForm() {
            if(flyoutPanel.FlyoutPanelState.IsActive) return;
            flyoutPanel.ShowBeakForm(GetHotPoint());
        }
        Point GetHotPoint() {
            Point pt = new Point(0, this.previewPanel.Height / 2);
            BeakPanelBeakLocation edtiValue = (BeakPanelBeakLocation)this.cbeBeakLocation.EditValue;
            if(edtiValue == BeakPanelBeakLocation.Right) {
                return this.previewPanel.PointToScreen(pt);
            }
            if(edtiValue == BeakPanelBeakLocation.Left) {
                pt.X += this.previewPanel.Width;
                return this.previewPanel.PointToScreen(pt);
            }
            pt = new Point(this.previewPanel.Width / 2, 0);
            if(edtiValue == BeakPanelBeakLocation.Top) {
                pt.Y += this.previewPanel.Height;
            }
            return this.previewPanel.PointToScreen(pt);
        }
        // </previewPanel>
        // <backColorEdit>
        void OnBackColorChanged(object sender, EventArgs e) {
            ColorPickEdit colorEdit = (ColorPickEdit)sender;
            this.options.BackColor = colorEdit.Color;
        }
        // </backColorEdit>
        // <borderColorEdit>
        void OnBorderColorChanged(object sender, EventArgs e) {
            ColorPickEdit colorEdit = (ColorPickEdit)sender;
            this.options.BorderColor = colorEdit.Color;
        }
        // </borderColorEdit>
        // <ceCloseOnOuterClick>
        void OnCloseOnOuterClickFlagChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.options.CloseOnOuterClick = checkEdit.Checked;
        }
        // </ceCloseOnOuterClick>
        // <ceShowButtonPanel>
        void OnShowButtonPanelFlagChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.flyoutPanel.OptionsButtonPanel.ShowButtonPanel = checkEdit.Checked;
            UpdateControls();
        }
        // </ceShowButtonPanel>
        // <flyoutPanel>
        void OnFlyoutPanelButtonClick(object sender, FlyoutPanelButtonClickEventArgs e) {
            string _tag = e.Button.Tag as string;
            if(string.Equals(_tag, "Exit", StringComparison.OrdinalIgnoreCase)) {
                this.flyoutPanel.HideBeakForm();
            }
        }
        // </flyoutPanel>
        // <cbeButtonPanelLocation>
        void OnButtonPanelLocationChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.flyoutPanel.OptionsButtonPanel.ButtonPanelLocation = (FlyoutPanelButtonPanelLocation)comboBox.EditValue;
            UpdateControls();
        }
        // </cbeButtonPanelLocation>
        // <cbeButtonPanelAlignment>
        void OnButtonPanelAlignmentChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.buttonPanelOptions.ButtonPanelContentAlignment = (ContentAlignment)comboBox.EditValue;
        }
        // </cbeButtonPanelAlignment>
        // <btnAddButton>
        void OnAddButtonClick(object sender, EventArgs e) {
            this.buttonPanelOptions.Buttons.Insert(0, CreateButton());
            UpdateControls();
        }
        ButtonControl CreateButton() {
            var button = new PeekFormButton();
            button.ToolTip = "Custom Button";
            button.UseCaption = false;
            button.ImageOptions.SvgImage = svgImageCollection1[0];
            button.ImageOptions.SvgImageSize = svgImageCollection1.ImageSize;
            return button;
        }
        // </btnAddButton>
        // <btnRemoveButton>
        void OnRemoveButtonClick(object sender, EventArgs e) {
            var buttons = this.buttonPanelOptions.Buttons;
            if(buttons.Count <= 1) return;
            buttons.RemoveAt(0);
            UpdateControls();
        }
        // </btnRemoveButton>
        void UpdateFlyoutHintLabelLocation() {
            Point loc = this.flyoutPanelHintLabel.Location;
            loc.Y = (this.flyoutPanel.Height - this.flyoutPanelHintLabel.Height) / 2;
            this.flyoutPanelHintLabel.Location = loc;
        }
        // <cbeBeakLocation>
        void OnBeakLocationChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.options.BeakLocation = (BeakPanelBeakLocation)comboBox.EditValue;
        }
        // </cbeBeakLocation>
        void UpdateControls() {
            this.btnAddButton.Enabled = this.buttonPanelOptions.Buttons.Count < 6;
            this.btnRemoveButton.Enabled = this.buttonPanelOptions.Buttons.Count > 1;
            UpdateFlyoutHintLabelLocation();
        }
    }
}
