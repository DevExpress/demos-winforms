namespace DevExpress.XtraEditors.Demos {
    partial class ModuleOverlayForm {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.cbViewType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.backColorEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.allowFadeInCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.allowFadeOutCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.foreColorEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.spinOpacity = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liBackColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.liForeColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.liOpacity = new DevExpress.XtraLayout.LayoutControlItem();
            this.liViewType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFadeInCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFadeOutCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOpacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.cbViewType);
            this.layoutControl.Controls.Add(this.backColorEdit);
            this.layoutControl.Controls.Add(this.btnShow);
            this.layoutControl.Controls.Add(this.allowFadeInCheckEdit);
            this.layoutControl.Controls.Add(this.allowFadeOutCheckEdit);
            this.layoutControl.Controls.Add(this.foreColorEdit);
            this.layoutControl.Controls.Add(this.spinOpacity);
            this.layoutControl.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControl.Location = new System.Drawing.Point(237, 135);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 140, 650, 400);
            this.layoutControl.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl.Root = this.layoutControlGroup4;
            this.layoutControl.Size = new System.Drawing.Size(320, 257);
            this.layoutControl.TabIndex = 6;
            this.layoutControl.Text = "layoutControl2";
            // 
            // cbViewType
            // 
            this.cbViewType.Location = new System.Drawing.Point(139, 45);
            this.cbViewType.Name = "cbViewType";
            this.cbViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbViewType.Size = new System.Drawing.Size(132, 20);
            this.cbViewType.StyleController = this.layoutControl;
            this.cbViewType.TabIndex = 17;
            this.cbViewType.EditValueChanged += new System.EventHandler(this.OnViewTypeChanged);
            // 
            // backColorEdit
            // 
            this.backColorEdit.EditValue = System.Drawing.Color.Empty;
            this.backColorEdit.Location = new System.Drawing.Point(139, 69);
            this.backColorEdit.Name = "backColorEdit";
            this.backColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.backColorEdit.Properties.ColorDialogOptions.AllowTransparency = false;
            this.backColorEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Simple;
            this.backColorEdit.Size = new System.Drawing.Size(132, 20);
            this.backColorEdit.StyleController = this.layoutControl;
            this.backColorEdit.TabIndex = 4;
            this.backColorEdit.EditValueChanged += new System.EventHandler(this.OnBackColorEditValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(24, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(255, 22);
            this.btnShow.StyleController = this.layoutControl;
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show Preview";
            this.btnShow.Click += new System.EventHandler(this.OnShowClick);
            // 
            // allowFadeInCheckEdit
            // 
            this.allowFadeInCheckEdit.EditValue = true;
            this.allowFadeInCheckEdit.Location = new System.Drawing.Point(139, 141);
            this.allowFadeInCheckEdit.Name = "allowFadeInCheckEdit";
            this.allowFadeInCheckEdit.Properties.Caption = "Allow Fade In Effect";
            this.allowFadeInCheckEdit.Size = new System.Drawing.Size(132, 20);
            this.allowFadeInCheckEdit.StyleController = this.layoutControl;
            this.allowFadeInCheckEdit.TabIndex = 13;
            this.allowFadeInCheckEdit.EditValueChanged += new System.EventHandler(this.OnAllowFadeInEditValueChanged);
            // 
            // allowFadeOutCheckEdit
            // 
            this.allowFadeOutCheckEdit.EditValue = true;
            this.allowFadeOutCheckEdit.Location = new System.Drawing.Point(139, 165);
            this.allowFadeOutCheckEdit.Name = "allowFadeOutCheckEdit";
            this.allowFadeOutCheckEdit.Properties.Caption = "Allow Fade Out Effect";
            this.allowFadeOutCheckEdit.Size = new System.Drawing.Size(132, 20);
            this.allowFadeOutCheckEdit.StyleController = this.layoutControl;
            this.allowFadeOutCheckEdit.TabIndex = 14;
            this.allowFadeOutCheckEdit.EditValueChanged += new System.EventHandler(this.OnAllowFadeOutEditValueChanged);
            // 
            // foreColorEdit
            // 
            this.foreColorEdit.EditValue = System.Drawing.Color.Empty;
            this.foreColorEdit.Location = new System.Drawing.Point(139, 93);
            this.foreColorEdit.Name = "foreColorEdit";
            this.foreColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.foreColorEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Simple;
            this.foreColorEdit.Size = new System.Drawing.Size(132, 20);
            this.foreColorEdit.StyleController = this.layoutControl;
            this.foreColorEdit.TabIndex = 4;
            this.foreColorEdit.EditValueChanged += new System.EventHandler(this.OnForeColorEditValueChanged);
            // 
            // spinOpacity
            // 
            this.spinOpacity.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinOpacity.Location = new System.Drawing.Point(139, 117);
            this.spinOpacity.Name = "spinOpacity";
            this.spinOpacity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinOpacity.Properties.Mask.EditMask = "n0";
            this.spinOpacity.Properties.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinOpacity.Size = new System.Drawing.Size(132, 20);
            this.spinOpacity.StyleController = this.layoutControl;
            this.spinOpacity.TabIndex = 16;
            this.spinOpacity.EditValueChanged += new System.EventHandler(this.OnOpacityEditValueChanged);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem9.Name = "layoutControlItem6";
            this.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem9.Size = new System.Drawing.Size(158, 92);
            this.layoutControlItem9.Text = "Opacity";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 183);
            this.layoutControlItem10.Name = "layoutControlItem4";
            this.layoutControlItem10.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem10.Size = new System.Drawing.Size(158, 24);
            this.layoutControlItem10.Text = "Background Color";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5,
            this.layoutControlGroup6});
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(303, 288);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liBackColor,
            this.liForeColor,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.liOpacity,
            this.liViewType});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup3";
            this.layoutControlGroup5.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17);
            this.layoutControlGroup5.Size = new System.Drawing.Size(283, 197);
            this.layoutControlGroup5.Text = "Properties";
            // 
            // liBackColor
            // 
            this.liBackColor.Control = this.backColorEdit;
            this.liBackColor.Location = new System.Drawing.Point(0, 24);
            this.liBackColor.Name = "liBackColor";
            this.liBackColor.Size = new System.Drawing.Size(243, 24);
            this.liBackColor.Text = "Background Color";
            this.liBackColor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.liBackColor.TextSize = new System.Drawing.Size(107, 13);
            this.liBackColor.TextToControlDistance = 0;
            // 
            // liForeColor
            // 
            this.liForeColor.Control = this.foreColorEdit;
            this.liForeColor.CustomizationFormText = "Foreground Color";
            this.liForeColor.FillControlToClientArea = false;
            this.liForeColor.Location = new System.Drawing.Point(0, 48);
            this.liForeColor.Name = "liForeColor";
            this.liForeColor.OptionsTableLayoutItem.RowIndex = 1;
            this.liForeColor.Size = new System.Drawing.Size(243, 24);
            this.liForeColor.Text = "Foreground Color";
            this.liForeColor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.liForeColor.TextLocation = DevExpress.Utils.Locations.Left;
            this.liForeColor.TextSize = new System.Drawing.Size(107, 13);
            this.liForeColor.TextToControlDistance = 0;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AccessibleName = "Allow Fade Out Effect";
            this.layoutControlItem13.Control = this.allowFadeOutCheckEdit;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem13.Name = "layoutControlItem2";
            this.layoutControlItem13.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem13.Size = new System.Drawing.Size(243, 24);
            this.layoutControlItem13.Text = " ";
            this.layoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(107, 0);
            this.layoutControlItem13.TextToControlDistance = 0;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.AccessibleName = "Allow Fade In Effect";
            this.layoutControlItem14.Control = this.allowFadeInCheckEdit;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem14.Name = "layoutControlItem3";
            this.layoutControlItem14.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem14.Size = new System.Drawing.Size(243, 24);
            this.layoutControlItem14.Text = " ";
            this.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(107, 0);
            this.layoutControlItem14.TextToControlDistance = 0;
            // 
            // liOpacity
            // 
            this.liOpacity.Control = this.spinOpacity;
            this.liOpacity.FillControlToClientArea = false;
            this.liOpacity.Location = new System.Drawing.Point(0, 72);
            this.liOpacity.Name = "liOpacity";
            this.liOpacity.OptionsTableLayoutItem.RowIndex = 2;
            this.liOpacity.Size = new System.Drawing.Size(243, 24);
            this.liOpacity.Text = "Opacity";
            this.liOpacity.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.liOpacity.TextSize = new System.Drawing.Size(107, 13);
            this.liOpacity.TextToControlDistance = 0;
            // 
            // liViewType
            // 
            this.liViewType.Control = this.cbViewType;
            this.liViewType.Location = new System.Drawing.Point(0, 0);
            this.liViewType.Name = "liViewType";
            this.liViewType.Size = new System.Drawing.Size(243, 24);
            this.liViewType.Text = "View Type";
            this.liViewType.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.liViewType.TextSize = new System.Drawing.Size(107, 13);
            this.liViewType.TextToControlDistance = 0;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 197);
            this.layoutControlGroup6.Name = "layoutControlGroup2";
            this.layoutControlGroup6.Size = new System.Drawing.Size(283, 71);
            this.layoutControlGroup6.Text = "Commands";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnShow;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.Name = "layoutControlItem1";
            this.layoutControlItem16.Size = new System.Drawing.Size(259, 26);
            this.layoutControlItem16.TextVisible = false;
            // 
            // ModuleOverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ModuleOverlayForm";
            this.Size = new System.Drawing.Size(827, 636);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFadeInCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFadeOutCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOpacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private XtraLayout.LayoutControl layoutControl;
        private ColorPickEdit backColorEdit;
        private SimpleButton btnShow;
        private CheckEdit allowFadeInCheckEdit;
        private CheckEdit allowFadeOutCheckEdit;
        private ColorPickEdit foreColorEdit;
        private SpinEdit spinOpacity;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlGroup layoutControlGroup5;
        private XtraLayout.LayoutControlItem liBackColor;
        private XtraLayout.LayoutControlItem liForeColor;
        private XtraLayout.LayoutControlItem layoutControlItem13;
        private XtraLayout.LayoutControlItem layoutControlItem14;
        private XtraLayout.LayoutControlItem liOpacity;
        private XtraLayout.LayoutControlGroup layoutControlGroup6;
        private XtraLayout.LayoutControlItem layoutControlItem16;
        private ImageComboBoxEdit cbViewType;
        private XtraLayout.LayoutControlItem liViewType;
    }
}
