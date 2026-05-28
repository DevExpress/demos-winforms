namespace DevExpress.XtraEditors.Demos {
    partial class ModuleToggleSwitch {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tsTextOff = new DevExpress.XtraEditors.TextEdit();
            this.comboAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tsTextOn = new DevExpress.XtraEditors.TextEdit();
            this.btnToggleState = new DevExpress.XtraEditors.SimpleButton();
            this.tsAllowThumbAnimation = new DevExpress.XtraEditors.CheckEdit();
            this.tsAllowHTMLString = new DevExpress.XtraEditors.CheckEdit();
            this.tsAllowMnemonics = new DevExpress.XtraEditors.CheckEdit();
            this.toggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsTextOff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAlign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTextOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowThumbAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowHTMLString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowMnemonics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.tsTextOff);
            this.layoutControl1.Controls.Add(this.comboAlign);
            this.layoutControl1.Controls.Add(this.tsTextOn);
            this.layoutControl1.Controls.Add(this.btnToggleState);
            this.layoutControl1.Controls.Add(this.tsAllowThumbAnimation);
            this.layoutControl1.Controls.Add(this.tsAllowHTMLString);
            this.layoutControl1.Controls.Add(this.tsAllowMnemonics);
            this.layoutControl1.Controls.Add(this.toggleSwitch);
            this.layoutControl1.Location = new System.Drawing.Point(39, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1031, 204, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(734, 418);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tsTextOff
            // 
            this.tsTextOff.EditValue = "Off";
            this.tsTextOff.Location = new System.Drawing.Point(547, 257);
            this.tsTextOff.Name = "tsTextOff";
            this.tsTextOff.Size = new System.Drawing.Size(173, 20);
            this.tsTextOff.StyleController = this.layoutControl1;
            this.tsTextOff.TabIndex = 9;
            this.tsTextOff.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.OffTextChanging);
            // 
            // comboAlign
            // 
            this.comboAlign.EditValue = "Near";
            this.comboAlign.Location = new System.Drawing.Point(547, 285);
            this.comboAlign.Name = "comboAlign";
            this.comboAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboAlign.Properties.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboAlign.Size = new System.Drawing.Size(173, 20);
            this.comboAlign.StyleController = this.layoutControl1;
            this.comboAlign.TabIndex = 2;
            this.comboAlign.SelectedIndexChanged += new System.EventHandler(this.comboAlign_SelectedIndexChanged);
            // 
            // tsTextOn
            // 
            this.tsTextOn.EditValue = "On";
            this.tsTextOn.Location = new System.Drawing.Point(547, 229);
            this.tsTextOn.Name = "tsTextOn";
            this.tsTextOn.Size = new System.Drawing.Size(173, 20);
            this.tsTextOn.StyleController = this.layoutControl1;
            this.tsTextOn.TabIndex = 8;
            this.tsTextOn.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.OnTextChanging);
            // 
            // btnToggleState
            // 
            this.btnToggleState.Location = new System.Drawing.Point(547, 130);
            this.btnToggleState.Name = "btnToggleState";
            this.btnToggleState.Size = new System.Drawing.Size(173, 22);
            this.btnToggleState.StyleController = this.layoutControl1;
            this.btnToggleState.TabIndex = 4;
            this.btnToggleState.Text = "Toggle";
            this.btnToggleState.Click += new System.EventHandler(this.btnToggleState_Click);
            // 
            // tsAllowThumbAnimation
            // 
            this.tsAllowThumbAnimation.EditValue = true;
            this.tsAllowThumbAnimation.Location = new System.Drawing.Point(484, 102);
            this.tsAllowThumbAnimation.Name = "tsAllowThumbAnimation";
            this.tsAllowThumbAnimation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tsAllowThumbAnimation.Properties.Appearance.Options.UseBackColor = true;
            this.tsAllowThumbAnimation.Properties.Caption = "Allow Thumb Animation ";
            this.tsAllowThumbAnimation.Size = new System.Drawing.Size(236, 20);
            this.tsAllowThumbAnimation.StyleController = this.layoutControl1;
            this.tsAllowThumbAnimation.TabIndex = 5;
            this.tsAllowThumbAnimation.CheckedChanged += new System.EventHandler(this.tsAllowThumbAnimation_CheckedChanged);
            // 
            // tsAllowHTMLString
            // 
            this.tsAllowHTMLString.Location = new System.Drawing.Point(484, 74);
            this.tsAllowHTMLString.Name = "tsAllowHTMLString";
            this.tsAllowHTMLString.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tsAllowHTMLString.Properties.Appearance.Options.UseBackColor = true;
            this.tsAllowHTMLString.Properties.Caption = "Allow HTML Draw";
            this.tsAllowHTMLString.Size = new System.Drawing.Size(236, 20);
            this.tsAllowHTMLString.StyleController = this.layoutControl1;
            this.tsAllowHTMLString.TabIndex = 2;
            this.tsAllowHTMLString.CheckedChanged += new System.EventHandler(this.tsAllowHTMLString_CheckedChanged);
            // 
            // tsAllowMnemonics
            // 
            this.tsAllowMnemonics.Location = new System.Drawing.Point(484, 46);
            this.tsAllowMnemonics.Name = "tsAllowMnemonics";
            this.tsAllowMnemonics.Properties.Caption = "Allow mnemonics";
            this.tsAllowMnemonics.Size = new System.Drawing.Size(236, 20);
            this.tsAllowMnemonics.StyleController = this.layoutControl1;
            this.tsAllowMnemonics.TabIndex = 0;
            this.tsAllowMnemonics.CheckedChanged += new System.EventHandler(this.tsAllowMnemonics_CheckedChanged);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Location = new System.Drawing.Point(24, 189);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch.Properties.AutoWidth = true;
            this.toggleSwitch.Properties.OffText = "Off";
            this.toggleSwitch.Properties.OnText = "On";
            this.toggleSwitch.Size = new System.Drawing.Size(182, 43);
            this.toggleSwitch.StyleController = this.layoutControl1;
            this.toggleSwitch.TabIndex = 1;
            this.toggleSwitch.Resize += new System.EventHandler(this.tsResize);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(752, 401);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(452, 381);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.toggleSwitch;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(400, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(400, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(400, 336);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(452, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(280, 184);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup3.Text = "Toggle state";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tsAllowMnemonics;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 1);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tsAllowHTMLString;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tsAllowThumbAnimation;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnToggleState;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 83);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 30);
            this.layoutControlItem5.Text = "On / Off:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup4.Location = new System.Drawing.Point(452, 184);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17);
            this.layoutControlGroup4.Size = new System.Drawing.Size(280, 197);
            this.layoutControlGroup4.Text = "Toggle properties";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tsTextOn;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem6.Text = "Text On:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.tsTextOff;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem7.Text = "Text Off:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.comboAlign;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem8.Size = new System.Drawing.Size(240, 90);
            this.layoutControlItem8.Text = "Alignment:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ModuleToggleSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleToggleSwitch";
            this.Size = new System.Drawing.Size(1024, 623);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsTextOff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAlign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTextOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowThumbAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowHTMLString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAllowMnemonics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit tsAllowHTMLString;
        private DevExpress.XtraEditors.CheckEdit tsAllowMnemonics;
        private DevExpress.XtraEditors.SimpleButton btnToggleState;
        private DevExpress.XtraEditors.ComboBoxEdit comboAlign;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch;
        private DevExpress.XtraEditors.TextEdit tsTextOff;
        private DevExpress.XtraEditors.TextEdit tsTextOn;
        private DevExpress.XtraEditors.CheckEdit tsAllowThumbAnimation;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
