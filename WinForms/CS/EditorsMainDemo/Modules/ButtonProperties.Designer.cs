namespace DevExpress.XtraEditors.Demos {
    partial class ButtonProperties {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.teCaption = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.icbAlignment = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.sbImageClear = new DevExpress.XtraEditors.SimpleButton();
            this.sbImageLoad = new DevExpress.XtraEditors.SimpleButton();
            this.teToolTip = new DevExpress.XtraEditors.TextEdit();
            this.icbKind = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.seWidth = new DevExpress.XtraEditors.SpinEdit();
            this.ceEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.ceVisible = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToolTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teCaption
            // 
            this.teCaption.EditValue = "";
            this.teCaption.Location = new System.Drawing.Point(107, 18);
            this.teCaption.Name = "teCaption";
            this.teCaption.Size = new System.Drawing.Size(134, 20);
            this.teCaption.StyleController = this.layoutControl1;
            this.teCaption.TabIndex = 16;
            this.teCaption.EditValueChanged += new System.EventHandler(this.teCaption_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.icbAlignment);
            this.layoutControl1.Controls.Add(this.sbImageClear);
            this.layoutControl1.Controls.Add(this.sbImageLoad);
            this.layoutControl1.Controls.Add(this.teCaption);
            this.layoutControl1.Controls.Add(this.teToolTip);
            this.layoutControl1.Controls.Add(this.icbKind);
            this.layoutControl1.Controls.Add(this.seWidth);
            this.layoutControl1.Controls.Add(this.ceEnabled);
            this.layoutControl1.Controls.Add(this.ceVisible);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.MinimumSize = new System.Drawing.Size(250, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(663, 370, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(259, 258);
            this.layoutControl1.TabIndex = 27;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // icbAlignment
            // 
            this.icbAlignment.EditValue = "imageComboBoxEdit1";
            this.icbAlignment.Location = new System.Drawing.Point(107, 216);
            this.icbAlignment.Name = "icbAlignment";
            this.icbAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbAlignment.Properties.DropDownRows = 15;
            this.icbAlignment.Size = new System.Drawing.Size(134, 20);
            this.icbAlignment.StyleController = this.layoutControl1;
            this.icbAlignment.TabIndex = 26;
            this.icbAlignment.SelectedIndexChanged += new System.EventHandler(this.icbAlignment_SelectedIndexChanged);
            // 
            // sbImageClear
            // 
            this.sbImageClear.Location = new System.Drawing.Point(170, 186);
            this.sbImageClear.Name = "sbImageClear";
            this.sbImageClear.Size = new System.Drawing.Size(71, 22);
            this.sbImageClear.StyleController = this.layoutControl1;
            this.sbImageClear.TabIndex = 25;
            this.sbImageClear.Text = "Clear";
            this.sbImageClear.Click += new System.EventHandler(this.sbImageClear_Click);
            // 
            // sbImageLoad
            // 
            this.sbImageLoad.Location = new System.Drawing.Point(107, 186);
            this.sbImageLoad.Name = "sbImageLoad";
            this.sbImageLoad.Size = new System.Drawing.Size(59, 22);
            this.sbImageLoad.StyleController = this.layoutControl1;
            this.sbImageLoad.TabIndex = 24;
            this.sbImageLoad.Text = "Load";
            this.sbImageLoad.Click += new System.EventHandler(this.sbImageLoad_Click);
            // 
            // teToolTip
            // 
            this.teToolTip.EditValue = "";
            this.teToolTip.Location = new System.Drawing.Point(107, 46);
            this.teToolTip.Name = "teToolTip";
            this.teToolTip.Size = new System.Drawing.Size(134, 20);
            this.teToolTip.StyleController = this.layoutControl1;
            this.teToolTip.TabIndex = 17;
            this.teToolTip.EditValueChanged += new System.EventHandler(this.teToolTip_EditValueChanged);
            // 
            // icbKind
            // 
            this.icbKind.EditValue = "imageComboBoxEdit1";
            this.icbKind.Location = new System.Drawing.Point(107, 74);
            this.icbKind.Name = "icbKind";
            this.icbKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbKind.Properties.DropDownRows = 15;
            this.icbKind.Size = new System.Drawing.Size(134, 20);
            this.icbKind.StyleController = this.layoutControl1;
            this.icbKind.TabIndex = 18;
            this.icbKind.SelectedIndexChanged += new System.EventHandler(this.icbKind_SelectedIndexChanged);
            // 
            // seWidth
            // 
            this.seWidth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seWidth.Location = new System.Drawing.Point(107, 102);
            this.seWidth.Name = "seWidth";
            this.seWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seWidth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seWidth.Properties.IsFloatValue = false;
            this.seWidth.Properties.Mask.EditMask = "N00";
            this.seWidth.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seWidth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.seWidth.Size = new System.Drawing.Size(134, 20);
            this.seWidth.StyleController = this.layoutControl1;
            this.seWidth.TabIndex = 19;
            this.seWidth.EditValueChanged += new System.EventHandler(this.seWidth_EditValueChanged);
            // 
            // ceEnabled
            // 
            this.ceEnabled.Location = new System.Drawing.Point(18, 130);
            this.ceEnabled.Name = "ceEnabled";
            this.ceEnabled.Properties.Caption = "Enabled";
            this.ceEnabled.Size = new System.Drawing.Size(223, 20);
            this.ceEnabled.StyleController = this.layoutControl1;
            this.ceEnabled.TabIndex = 20;
            this.ceEnabled.CheckedChanged += new System.EventHandler(this.ceEnabled_CheckedChanged);
            // 
            // ceVisible
            // 
            this.ceVisible.Location = new System.Drawing.Point(18, 158);
            this.ceVisible.Name = "ceVisible";
            this.ceVisible.Properties.Caption = "Visible";
            this.ceVisible.Size = new System.Drawing.Size(223, 20);
            this.ceVisible.StyleController = this.layoutControl1;
            this.ceVisible.TabIndex = 21;
            this.ceVisible.CheckedChanged += new System.EventHandler(this.ceVisible_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 16, 16);
            this.layoutControlGroup1.Size = new System.Drawing.Size(259, 258);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teCaption;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 26);
            this.layoutControlItem1.Text = "Caption:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teToolTip;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 28);
            this.layoutControlItem2.Text = "Tooltip:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.icbKind;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 28);
            this.layoutControlItem3.Text = "Kind:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seWidth;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(227, 28);
            this.layoutControlItem4.Text = "Width:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceEnabled;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(227, 28);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ceVisible;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(227, 28);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sbImageClear;
            this.layoutControlItem7.Location = new System.Drawing.Point(152, 166);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(75, 30);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sbImageLoad;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem8.Size = new System.Drawing.Size(152, 30);
            this.layoutControlItem8.Text = "Image:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.icbAlignment;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 196);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem9.Size = new System.Drawing.Size(227, 30);
            this.layoutControlItem9.Text = "Image Location:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(77, 13);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(259, 258);
            this.panelControl1.TabIndex = 22;
            // 
            // ButtonProperties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panelControl1);
            this.Name = "ButtonProperties";
            this.Size = new System.Drawing.Size(259, 258);
            ((System.ComponentModel.ISupportInitialize)(this.teCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToolTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teCaption;
        private DevExpress.XtraEditors.TextEdit teToolTip;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbKind;
        private DevExpress.XtraEditors.SpinEdit seWidth;
        private DevExpress.XtraEditors.CheckEdit ceEnabled;
        private DevExpress.XtraEditors.CheckEdit ceVisible;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbImageLoad;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbAlignment;
        private DevExpress.XtraEditors.SimpleButton sbImageClear;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
    }
}
