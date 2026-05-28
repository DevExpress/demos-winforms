namespace DevExpress.XtraEditors.Demos {
    partial class ModuleBeakForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleBeakForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.cbeBeakLocation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.previewPanel = new DevExpress.XtraEditors.PanelControl();
            this.prevewPanelHintLabel = new DevExpress.XtraEditors.LabelControl();
            this.btnRemoveButton = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.cbeButtonPanelAlignment = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceCloseOnOuterClick = new DevExpress.XtraEditors.CheckEdit();
            this.borderColorEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.cbeButtonPanelLocation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceShowButtonPanel = new DevExpress.XtraEditors.CheckEdit();
            this.backColorEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flyoutPanel = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelHintLabel = new DevExpress.XtraEditors.LabelControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbeBeakLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).BeginInit();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeButtonPanelAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCloseOnOuterClick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeButtonPanelLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowButtonPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).BeginInit();
            this.flyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbeBeakLocation
            // 
            this.cbeBeakLocation.Location = new System.Drawing.Point(395, 53);
            this.cbeBeakLocation.Name = "cbeBeakLocation";
            this.cbeBeakLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeBeakLocation.Size = new System.Drawing.Size(154, 20);
            this.cbeBeakLocation.StyleController = this.layoutControl1;
            this.cbeBeakLocation.TabIndex = 5;
            this.cbeBeakLocation.SelectedIndexChanged += new System.EventHandler(this.OnBeakLocationChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.previewPanel);
            this.layoutControl1.Controls.Add(this.btnRemoveButton);
            this.layoutControl1.Controls.Add(this.btnAddButton);
            this.layoutControl1.Controls.Add(this.cbeBeakLocation);
            this.layoutControl1.Controls.Add(this.cbeButtonPanelAlignment);
            this.layoutControl1.Controls.Add(this.ceCloseOnOuterClick);
            this.layoutControl1.Controls.Add(this.borderColorEdit);
            this.layoutControl1.Controls.Add(this.cbeButtonPanelLocation);
            this.layoutControl1.Controls.Add(this.ceShowButtonPanel);
            this.layoutControl1.Controls.Add(this.backColorEdit);
            this.layoutControl1.Location = new System.Drawing.Point(49, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1043, 85, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(589, 344);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // previewPanel
            // 
            this.previewPanel.Controls.Add(this.prevewPanelHintLabel);
            this.previewPanel.Location = new System.Drawing.Point(40, 172);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(193, 56);
            this.previewPanel.TabIndex = 1;
            this.previewPanel.MouseEnter += new System.EventHandler(this.OnPreviewPanelMouseEnter);
            // 
            // prevewPanelHintLabel
            // 
            this.prevewPanelHintLabel.Appearance.Options.UseTextOptions = true;
            this.prevewPanelHintLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.prevewPanelHintLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.prevewPanelHintLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.prevewPanelHintLabel.Location = new System.Drawing.Point(28, 11);
            this.prevewPanelHintLabel.Name = "prevewPanelHintLabel";
            this.prevewPanelHintLabel.Size = new System.Drawing.Size(133, 36);
            this.prevewPanelHintLabel.TabIndex = 0;
            this.prevewPanelHintLabel.Text = "Move mouse here to show the Beak Form";
            // 
            // btnRemoveButton
            // 
            this.btnRemoveButton.Location = new System.Drawing.Point(431, 325);
            this.btnRemoveButton.Name = "btnRemoveButton";
            this.btnRemoveButton.Size = new System.Drawing.Size(118, 22);
            this.btnRemoveButton.StyleController = this.layoutControl1;
            this.btnRemoveButton.TabIndex = 13;
            this.btnRemoveButton.Text = "Remove Button";
            this.btnRemoveButton.Click += new System.EventHandler(this.OnRemoveButtonClick);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(313, 325);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(114, 22);
            this.btnAddButton.StyleController = this.layoutControl1;
            this.btnAddButton.TabIndex = 12;
            this.btnAddButton.Text = "Add Button";
            this.btnAddButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // cbeButtonPanelAlignment
            // 
            this.cbeButtonPanelAlignment.Location = new System.Drawing.Point(395, 297);
            this.cbeButtonPanelAlignment.Name = "cbeButtonPanelAlignment";
            this.cbeButtonPanelAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeButtonPanelAlignment.Properties.DropDownRows = 14;
            this.cbeButtonPanelAlignment.Size = new System.Drawing.Size(154, 20);
            this.cbeButtonPanelAlignment.StyleController = this.layoutControl1;
            this.cbeButtonPanelAlignment.TabIndex = 5;
            this.cbeButtonPanelAlignment.SelectedIndexChanged += new System.EventHandler(this.OnButtonPanelAlignmentChanged);
            // 
            // ceCloseOnOuterClick
            // 
            this.ceCloseOnOuterClick.Location = new System.Drawing.Point(313, 137);
            this.ceCloseOnOuterClick.Name = "ceCloseOnOuterClick";
            this.ceCloseOnOuterClick.Properties.Caption = "Close On Outer Click";
            this.ceCloseOnOuterClick.Size = new System.Drawing.Size(236, 20);
            this.ceCloseOnOuterClick.StyleController = this.layoutControl1;
            this.ceCloseOnOuterClick.TabIndex = 2;
            this.ceCloseOnOuterClick.CheckedChanged += new System.EventHandler(this.OnCloseOnOuterClickFlagChanged);
            // 
            // borderColorEdit
            // 
            this.borderColorEdit.EditValue = System.Drawing.Color.Empty;
            this.borderColorEdit.Location = new System.Drawing.Point(395, 109);
            this.borderColorEdit.Name = "borderColorEdit";
            this.borderColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black;
            this.borderColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.borderColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color";
            this.borderColorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.borderColorEdit.Size = new System.Drawing.Size(154, 20);
            this.borderColorEdit.StyleController = this.layoutControl1;
            this.borderColorEdit.TabIndex = 1;
            this.borderColorEdit.ColorChanged += new System.EventHandler(this.OnBorderColorChanged);
            // 
            // cbeButtonPanelLocation
            // 
            this.cbeButtonPanelLocation.Location = new System.Drawing.Point(395, 269);
            this.cbeButtonPanelLocation.Name = "cbeButtonPanelLocation";
            this.cbeButtonPanelLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeButtonPanelLocation.Size = new System.Drawing.Size(154, 20);
            this.cbeButtonPanelLocation.StyleController = this.layoutControl1;
            this.cbeButtonPanelLocation.TabIndex = 9;
            this.cbeButtonPanelLocation.SelectedIndexChanged += new System.EventHandler(this.OnButtonPanelLocationChanged);
            // 
            // ceShowButtonPanel
            // 
            this.ceShowButtonPanel.Location = new System.Drawing.Point(313, 241);
            this.ceShowButtonPanel.Name = "ceShowButtonPanel";
            this.ceShowButtonPanel.Properties.Caption = "Show ButtonPanel";
            this.ceShowButtonPanel.Size = new System.Drawing.Size(236, 20);
            this.ceShowButtonPanel.StyleController = this.layoutControl1;
            this.ceShowButtonPanel.TabIndex = 11;
            this.ceShowButtonPanel.CheckedChanged += new System.EventHandler(this.OnShowButtonPanelFlagChanged);
            // 
            // backColorEdit
            // 
            this.backColorEdit.EditValue = System.Drawing.Color.Empty;
            this.backColorEdit.Location = new System.Drawing.Point(395, 81);
            this.backColorEdit.Name = "backColorEdit";
            this.backColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black;
            this.backColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.backColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color";
            this.backColorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.backColorEdit.Size = new System.Drawing.Size(154, 20);
            this.backColorEdit.StyleController = this.layoutControl1;
            this.backColorEdit.TabIndex = 0;
            this.backColorEdit.ColorChanged += new System.EventHandler(this.OnBackColorChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(581, 379);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(281, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(280, 188);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup2.Text = "Appearance && Behavior Options";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbeBeakLocation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem1.Text = "Beak Location:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.backColorEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem2.Text = "Back Color:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.borderColorEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem3.Text = "Border Color:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceCloseOnOuterClick;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup3.Location = new System.Drawing.Point(281, 188);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(280, 171);
            this.layoutControlGroup3.Text = "ButtonPanel Appearance";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceShowButtonPanel;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbeButtonPanelLocation;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem6.Text = "Location:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbeButtonPanelAlignment;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 6);
            this.layoutControlItem7.Size = new System.Drawing.Size(240, 30);
            this.layoutControlItem7.Text = "Alignment:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnAddButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(118, 26);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnRemoveButton;
            this.layoutControlItem9.Location = new System.Drawing.Point(118, 84);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(25, 25, 17, 17);
            this.layoutControlGroup4.Size = new System.Drawing.Size(281, 359);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup4.Text = "Sample";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.previewPanel;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(197, 60);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(197, 60);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(197, 298);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextVisible = false;
            this.layoutControlItem10.TrimClientAreaToControl = false;
            // 
            // flyoutPanel
            // 
            this.flyoutPanel.Controls.Add(this.flyoutPanelHintLabel);
            this.flyoutPanel.Location = new System.Drawing.Point(27, 382);
            this.flyoutPanel.Name = "flyoutPanel";
            this.flyoutPanel.OptionsButtonPanel.AllowGlyphSkinning = true;
            this.flyoutPanel.OptionsButtonPanel.ButtonPanelHeight = 36;
            buttonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonImageOptions1.SvgImage")));
            buttonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            toolTipItem1.Text = "Exit";
            superToolTip1.Items.Add(toolTipItem1);
            this.flyoutPanel.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Button", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exit", -1, true, superToolTip1, true, false, true, "Exit", -1, false)});
            this.flyoutPanel.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanel.OwnerControl = this;
            this.flyoutPanel.Padding = new System.Windows.Forms.Padding(0, 36, 0, 0);
            this.flyoutPanel.Size = new System.Drawing.Size(338, 120);
            this.flyoutPanel.TabIndex = 2;
            this.flyoutPanel.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.OnFlyoutPanelButtonClick);
            // 
            // flyoutPanelHintLabel
            // 
            this.flyoutPanelHintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flyoutPanelHintLabel.Location = new System.Drawing.Point(90, 58);
            this.flyoutPanelHintLabel.Name = "flyoutPanelHintLabel";
            this.flyoutPanelHintLabel.Size = new System.Drawing.Size(152, 13);
            this.flyoutPanelHintLabel.TabIndex = 0;
            this.flyoutPanelHintLabel.Text = "You can place any content here";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("properties", "image://svgimages/setup/properties.svg");
            // 
            // ModuleBeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleBeakForm";
            this.Size = new System.Drawing.Size(784, 527);
            ((System.ComponentModel.ISupportInitialize)(this.cbeBeakLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).EndInit();
            this.previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeButtonPanelAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCloseOnOuterClick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeButtonPanelLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowButtonPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).EndInit();
            this.flyoutPanel.ResumeLayout(false);
            this.flyoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl prevewPanelHintLabel;
        private Utils.FlyoutPanel flyoutPanel;
        private LabelControl flyoutPanelHintLabel;
        private PanelControl previewPanel;
        private CheckEdit ceCloseOnOuterClick;
        private ColorPickEdit borderColorEdit;
        private ColorPickEdit backColorEdit;
        private ImageComboBoxEdit cbeButtonPanelLocation;
        private ImageComboBoxEdit cbeButtonPanelAlignment;
        private CheckEdit ceShowButtonPanel;
        private SimpleButton btnRemoveButton;
        private SimpleButton btnAddButton;
        private ImageComboBoxEdit cbeBeakLocation;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
