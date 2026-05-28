namespace DevExpress.HTML.Demos {
    partial class PreviewCoreControllerProperties {
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
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ttInitialDelay = new DevExpress.XtraEditors.SpinEdit();
            this.ttIconSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ttAutoPopDelay = new DevExpress.XtraEditors.SpinEdit();
            this.ttLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ttType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liType = new DevExpress.XtraLayout.LayoutControlItem();
            this.liLocation = new DevExpress.XtraLayout.LayoutControlItem();
            this.liAutoPopDelay = new DevExpress.XtraLayout.LayoutControlItem();
            this.liIconSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.liInitialDelay = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttInitialDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttIconSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttAutoPopDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAutoPopDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liIconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liInitialDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("actions_check", "image://svgimages/icon builder/actions_check.svg");
            this.svgImageCollection1.Add("actions_checkcircled", "image://svgimages/icon builder/actions_checkcircled.svg");
            this.svgImageCollection1.Add("warning", "image://svgimages/status/warning.svg");
            this.svgImageCollection1.Add("security_warningcircled1", "image://svgimages/icon builder/security_warningcircled1.svg");
            this.svgImageCollection1.Add("actions_deletecircled", "image://svgimages/icon builder/actions_deletecircled.svg");
            this.svgImageCollection1.Add("actions_info", "image://svgimages/icon builder/actions_info.svg");
            // 
            // layoutControl1
            // 
            this.layoutControl1.AutoSize = true;
            this.layoutControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.layoutControl1.Controls.Add(this.ttInitialDelay);
            this.layoutControl1.Controls.Add(this.ttIconSize);
            this.layoutControl1.Controls.Add(this.ttAutoPopDelay);
            this.layoutControl1.Controls.Add(this.ttLocation);
            this.layoutControl1.Controls.Add(this.ttType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(180, 154);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ttInitialDelay
            // 
            this.ttInitialDelay.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ttInitialDelay.Location = new System.Drawing.Point(110, 43);
            this.ttInitialDelay.Margin = new System.Windows.Forms.Padding(2);
            this.ttInitialDelay.Name = "ttInitialDelay";
            this.ttInitialDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ttInitialDelay.Properties.IsFloatValue = false;
            this.ttInitialDelay.Properties.MaskSettings.Set("mask", "N00");
            this.ttInitialDelay.Properties.MaxValue = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.ttInitialDelay.Size = new System.Drawing.Size(50, 20);
            this.ttInitialDelay.StyleController = this.layoutControl1;
            this.ttInitialDelay.TabIndex = 3;
            // 
            // ttIconSize
            // 
            this.ttIconSize.Location = new System.Drawing.Point(110, 67);
            this.ttIconSize.Margin = new System.Windows.Forms.Padding(2);
            this.ttIconSize.Name = "ttIconSize";
            this.ttIconSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ttIconSize.Size = new System.Drawing.Size(50, 20);
            this.ttIconSize.StyleController = this.layoutControl1;
            this.ttIconSize.TabIndex = 4;
            // 
            // ttAutoPopDelay
            // 
            this.ttAutoPopDelay.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ttAutoPopDelay.Location = new System.Drawing.Point(110, 19);
            this.ttAutoPopDelay.Margin = new System.Windows.Forms.Padding(2);
            this.ttAutoPopDelay.Name = "ttAutoPopDelay";
            this.ttAutoPopDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ttAutoPopDelay.Properties.IsFloatValue = false;
            this.ttAutoPopDelay.Properties.MaskSettings.Set("mask", "N00");
            this.ttAutoPopDelay.Properties.MaxValue = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.ttAutoPopDelay.Size = new System.Drawing.Size(50, 20);
            this.ttAutoPopDelay.StyleController = this.layoutControl1;
            this.ttAutoPopDelay.TabIndex = 2;
            // 
            // ttLocation
            // 
            this.ttLocation.Location = new System.Drawing.Point(110, 91);
            this.ttLocation.Margin = new System.Windows.Forms.Padding(2);
            this.ttLocation.Name = "ttLocation";
            this.ttLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ttLocation.Size = new System.Drawing.Size(50, 20);
            this.ttLocation.StyleController = this.layoutControl1;
            this.ttLocation.TabIndex = 5;
            // 
            // ttType
            // 
            this.ttType.Location = new System.Drawing.Point(110, 115);
            this.ttType.Margin = new System.Windows.Forms.Padding(2);
            this.ttType.Name = "ttType";
            this.ttType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ttType.Size = new System.Drawing.Size(50, 20);
            this.ttType.StyleController = this.layoutControl1;
            this.ttType.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liType,
            this.liLocation,
            this.liAutoPopDelay,
            this.liIconSize,
            this.liInitialDelay});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17);
            this.Root.Size = new System.Drawing.Size(180, 154);
            this.Root.TextVisible = false;
            // 
            // liType
            // 
            this.liType.Control = this.ttType;
            this.liType.Location = new System.Drawing.Point(0, 96);
            this.liType.Name = "liType";
            this.liType.Size = new System.Drawing.Size(144, 24);
            this.liType.Text = "Type:";
            this.liType.TextSize = new System.Drawing.Size(78, 13);
            // 
            // liLocation
            // 
            this.liLocation.Control = this.ttLocation;
            this.liLocation.Location = new System.Drawing.Point(0, 72);
            this.liLocation.Name = "liLocation";
            this.liLocation.Size = new System.Drawing.Size(144, 24);
            this.liLocation.Text = "Location:";
            this.liLocation.TextSize = new System.Drawing.Size(78, 13);
            // 
            // liAutoPopDelay
            // 
            this.liAutoPopDelay.Control = this.ttAutoPopDelay;
            this.liAutoPopDelay.Location = new System.Drawing.Point(0, 0);
            this.liAutoPopDelay.Name = "liAutoPopDelay";
            this.liAutoPopDelay.Size = new System.Drawing.Size(144, 24);
            this.liAutoPopDelay.Text = "Auto Pop Delay:";
            this.liAutoPopDelay.TextSize = new System.Drawing.Size(78, 13);
            // 
            // liIconSize
            // 
            this.liIconSize.Control = this.ttIconSize;
            this.liIconSize.Location = new System.Drawing.Point(0, 48);
            this.liIconSize.Name = "liIconSize";
            this.liIconSize.Size = new System.Drawing.Size(144, 24);
            this.liIconSize.Text = "Icon Size:";
            this.liIconSize.TextSize = new System.Drawing.Size(78, 13);
            // 
            // liInitialDelay
            // 
            this.liInitialDelay.Control = this.ttInitialDelay;
            this.liInitialDelay.Location = new System.Drawing.Point(0, 24);
            this.liInitialDelay.Name = "liInitialDelay";
            this.liInitialDelay.Size = new System.Drawing.Size(144, 24);
            this.liInitialDelay.Text = "Initial Delay:";
            this.liInitialDelay.TextSize = new System.Drawing.Size(78, 13);
            // 
            // PreviewCoreControllerProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PreviewCoreControllerProperties";
            this.Size = new System.Drawing.Size(180, 154);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ttInitialDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttIconSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttAutoPopDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAutoPopDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liIconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liInitialDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.SpinEdit ttInitialDelay;
        private XtraEditors.ComboBoxEdit ttIconSize;
        private XtraEditors.SpinEdit ttAutoPopDelay;
        private XtraEditors.ComboBoxEdit ttLocation;
        private XtraEditors.ComboBoxEdit ttType;
        private XtraLayout.LayoutControlItem liType;
        private XtraLayout.LayoutControlItem liLocation;
        private XtraLayout.LayoutControlItem liAutoPopDelay;
        private XtraLayout.LayoutControlItem liIconSize;
        private XtraLayout.LayoutControlItem liInitialDelay;
    }
}
