namespace DevExpress.HTML.Demos {
    partial class AlertControlProperties {
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
            this.icbShowingEffect = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbFormLocation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.seFormMaxCount = new DevExpress.XtraEditors.SpinEdit();
            this.seAutoFormDelay = new DevExpress.XtraEditors.SpinEdit();
            this.icbFormDisplaySpeed = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.autoFormDelayItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.formDisplaySpeedItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.formLocationItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.formShowingEffectItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.formMaxCountItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowingEffect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormMaxCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAutoFormDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormDisplaySpeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoFormDelayItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDisplaySpeedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLocationItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formShowingEffectItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMaxCountItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.icbShowingEffect);
            this.layoutControl1.Controls.Add(this.icbFormLocation);
            this.layoutControl1.Controls.Add(this.seFormMaxCount);
            this.layoutControl1.Controls.Add(this.seAutoFormDelay);
            this.layoutControl1.Controls.Add(this.icbFormDisplaySpeed);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(564, 347, 1137, 700);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(272, 177);
            this.layoutControl1.TabIndex = 20;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // icbShowingEffect
            // 
            this.icbShowingEffect.Location = new System.Drawing.Point(113, 40);
            this.icbShowingEffect.Name = "icbShowingEffect";
            this.icbShowingEffect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbShowingEffect.Size = new System.Drawing.Size(140, 20);
            this.icbShowingEffect.StyleController = this.layoutControl1;
            this.icbShowingEffect.TabIndex = 4;
            this.icbShowingEffect.SelectedIndexChanged += new System.EventHandler(this.icbShowingEffect_SelectedIndexChanged);
            // 
            // icbFormLocation
            // 
            this.icbFormLocation.Location = new System.Drawing.Point(113, 18);
            this.icbFormLocation.Name = "icbFormLocation";
            this.icbFormLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbFormLocation.Size = new System.Drawing.Size(140, 20);
            this.icbFormLocation.StyleController = this.layoutControl1;
            this.icbFormLocation.TabIndex = 3;
            this.icbFormLocation.SelectedIndexChanged += new System.EventHandler(this.icbFormLocation_SelectedIndexChanged);
            // 
            // seFormMaxCount
            // 
            this.seFormMaxCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFormMaxCount.Location = new System.Drawing.Point(113, 106);
            this.seFormMaxCount.Name = "seFormMaxCount";
            this.seFormMaxCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seFormMaxCount.Properties.IsFloatValue = false;
            this.seFormMaxCount.Properties.MaskSettings.Set("mask", "N00");
            this.seFormMaxCount.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seFormMaxCount.Size = new System.Drawing.Size(140, 20);
            this.seFormMaxCount.StyleController = this.layoutControl1;
            this.seFormMaxCount.TabIndex = 6;
            this.seFormMaxCount.EditValueChanged += new System.EventHandler(this.seFormMaxCount_EditValueChanged);
            // 
            // seAutoFormDelay
            // 
            this.seAutoFormDelay.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seAutoFormDelay.Location = new System.Drawing.Point(113, 84);
            this.seAutoFormDelay.Name = "seAutoFormDelay";
            this.seAutoFormDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seAutoFormDelay.Properties.IsFloatValue = false;
            this.seAutoFormDelay.Properties.MaskSettings.Set("mask", "N00");
            this.seAutoFormDelay.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seAutoFormDelay.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seAutoFormDelay.Size = new System.Drawing.Size(140, 20);
            this.seAutoFormDelay.StyleController = this.layoutControl1;
            this.seAutoFormDelay.TabIndex = 0;
            this.seAutoFormDelay.EditValueChanged += new System.EventHandler(this.seAutoFormDelay_EditValueChanged);
            // 
            // icbFormDisplaySpeed
            // 
            this.icbFormDisplaySpeed.Location = new System.Drawing.Point(113, 62);
            this.icbFormDisplaySpeed.Name = "icbFormDisplaySpeed";
            this.icbFormDisplaySpeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbFormDisplaySpeed.Size = new System.Drawing.Size(140, 20);
            this.icbFormDisplaySpeed.StyleController = this.layoutControl1;
            this.icbFormDisplaySpeed.TabIndex = 2;
            this.icbFormDisplaySpeed.SelectedIndexChanged += new System.EventHandler(this.icbFormDisplaySpeed_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.formDisplaySpeedItem,
            this.formMaxCountItem,
            this.formShowingEffectItem,
            this.formLocationItem,
            this.autoFormDelayItem});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17);
            this.Root.Size = new System.Drawing.Size(272, 177);
            this.Root.TextVisible = false;
            // 
            // autoFormDelayItem
            // 
            this.autoFormDelayItem.Control = this.seAutoFormDelay;
            this.autoFormDelayItem.Location = new System.Drawing.Point(0, 66);
            this.autoFormDelayItem.Name = "autoFormDelayItem";
            this.autoFormDelayItem.Size = new System.Drawing.Size(236, 22);
            this.autoFormDelayItem.Text = "Delay:";
            this.autoFormDelayItem.TextSize = new System.Drawing.Size(87, 13);
            // 
            // formDisplaySpeedItem
            // 
            this.formDisplaySpeedItem.Control = this.icbFormDisplaySpeed;
            this.formDisplaySpeedItem.Location = new System.Drawing.Point(0, 44);
            this.formDisplaySpeedItem.Name = "formDisplaySpeedItem";
            this.formDisplaySpeedItem.Size = new System.Drawing.Size(236, 22);
            this.formDisplaySpeedItem.Text = "Animation Speed:";
            this.formDisplaySpeedItem.TextSize = new System.Drawing.Size(87, 13);
            // 
            // formLocationItem
            // 
            this.formLocationItem.Control = this.icbFormLocation;
            this.formLocationItem.Location = new System.Drawing.Point(0, 0);
            this.formLocationItem.Name = "formLocationItem";
            this.formLocationItem.Size = new System.Drawing.Size(236, 22);
            this.formLocationItem.Text = "Location:";
            this.formLocationItem.TextSize = new System.Drawing.Size(87, 13);
            // 
            // formShowingEffectItem
            // 
            this.formShowingEffectItem.Control = this.icbShowingEffect;
            this.formShowingEffectItem.Location = new System.Drawing.Point(0, 22);
            this.formShowingEffectItem.Name = "formShowingEffectItem";
            this.formShowingEffectItem.Size = new System.Drawing.Size(236, 22);
            this.formShowingEffectItem.Text = "Animation:";
            this.formShowingEffectItem.TextSize = new System.Drawing.Size(87, 13);
            // 
            // formMaxCountItem
            // 
            this.formMaxCountItem.Control = this.seFormMaxCount;
            this.formMaxCountItem.Location = new System.Drawing.Point(0, 88);
            this.formMaxCountItem.Name = "formMaxCountItem";
            this.formMaxCountItem.Size = new System.Drawing.Size(236, 55);
            this.formMaxCountItem.Text = "Alerts Max Count:";
            this.formMaxCountItem.TextSize = new System.Drawing.Size(87, 13);
            // 
            // AlertControlProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "AlertControlProperties";
            this.Size = new System.Drawing.Size(272, 177);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbShowingEffect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormMaxCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAutoFormDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormDisplaySpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoFormDelayItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDisplaySpeedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLocationItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formShowingEffectItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMaxCountItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SpinEdit seAutoFormDelay;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbFormDisplaySpeed;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbFormLocation;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbShowingEffect;
        private DevExpress.XtraEditors.SpinEdit seFormMaxCount;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem autoFormDelayItem;
        private XtraLayout.LayoutControlItem formDisplaySpeedItem;
        private XtraLayout.LayoutControlItem formLocationItem;
        private XtraLayout.LayoutControlItem formShowingEffectItem;
        private XtraLayout.LayoutControlItem formMaxCountItem;
    }
}
