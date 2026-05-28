namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMarqueeProgressBar {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.checkEditPause = new DevExpress.XtraEditors.CheckEdit();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.spinEditAnimationSpeed = new DevExpress.XtraEditors.SpinEdit();
            this.checkEditVertical = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditShowTitle = new DevExpress.XtraEditors.CheckEdit();
            this.icbProgressViewStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPause.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnimationSpeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditVertical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbProgressViewStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.teTitle);
            this.layoutControl1.Controls.Add(this.checkEditPause);
            this.layoutControl1.Controls.Add(this.marqueeProgressBarControl1);
            this.layoutControl1.Controls.Add(this.spinEditAnimationSpeed);
            this.layoutControl1.Controls.Add(this.checkEditVertical);
            this.layoutControl1.Controls.Add(this.checkEditShowTitle);
            this.layoutControl1.Controls.Add(this.icbProgressViewStyle);
            this.layoutControl1.Location = new System.Drawing.Point(29, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 140, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(692, 385);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(477, 181);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(182, 20);
            this.teTitle.StyleController = this.layoutControl1;
            this.teTitle.TabIndex = 10;
            this.teTitle.EditValueChanged += new System.EventHandler(this.teTitle_EditValueChanged);
            // 
            // checkEditPause
            // 
            this.checkEditPause.Location = new System.Drawing.Point(384, 155);
            this.checkEditPause.Name = "checkEditPause";
            this.checkEditPause.Properties.Caption = "Pause";
            this.checkEditPause.Size = new System.Drawing.Size(275, 20);
            this.checkEditPause.StyleController = this.layoutControl1;
            this.checkEditPause.TabIndex = 11;
            this.checkEditPause.CheckedChanged += new System.EventHandler(this.checkEditPause_CheckedChanged);
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = "Rebuild...";
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(24, 194);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(296, 18);
            this.marqueeProgressBarControl1.StyleController = this.layoutControl1;
            this.marqueeProgressBarControl1.TabIndex = 0;
            // 
            // spinEditAnimationSpeed
            // 
            this.spinEditAnimationSpeed.EditValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEditAnimationSpeed.Location = new System.Drawing.Point(477, 73);
            this.spinEditAnimationSpeed.Name = "spinEditAnimationSpeed";
            this.spinEditAnimationSpeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditAnimationSpeed.Properties.IsFloatValue = false;
            this.spinEditAnimationSpeed.Properties.Mask.EditMask = "N00";
            this.spinEditAnimationSpeed.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEditAnimationSpeed.Properties.MinValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEditAnimationSpeed.Size = new System.Drawing.Size(182, 20);
            this.spinEditAnimationSpeed.StyleController = this.layoutControl1;
            this.spinEditAnimationSpeed.TabIndex = 1;
            this.spinEditAnimationSpeed.EditValueChanged += new System.EventHandler(this.spinEditAnimationSpeed_EditValueChanged);
            // 
            // checkEditVertical
            // 
            this.checkEditVertical.Location = new System.Drawing.Point(384, 101);
            this.checkEditVertical.Name = "checkEditVertical";
            this.checkEditVertical.Properties.Caption = "Vertical";
            this.checkEditVertical.Size = new System.Drawing.Size(275, 20);
            this.checkEditVertical.StyleController = this.layoutControl1;
            this.checkEditVertical.TabIndex = 2;
            this.checkEditVertical.CheckedChanged += new System.EventHandler(this.checkEditVertical_CheckedChanged);
            // 
            // checkEditShowTitle
            // 
            this.checkEditShowTitle.Location = new System.Drawing.Point(384, 129);
            this.checkEditShowTitle.Name = "checkEditShowTitle";
            this.checkEditShowTitle.Properties.Caption = "Show title";
            this.checkEditShowTitle.Size = new System.Drawing.Size(275, 20);
            this.checkEditShowTitle.StyleController = this.layoutControl1;
            this.checkEditShowTitle.TabIndex = 3;
            this.checkEditShowTitle.CheckedChanged += new System.EventHandler(this.checkEditShowTitle_CheckedChanged);
            // 
            // icbProgressViewStyle
            // 
            this.icbProgressViewStyle.Location = new System.Drawing.Point(477, 45);
            this.icbProgressViewStyle.Name = "icbProgressViewStyle";
            this.icbProgressViewStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbProgressViewStyle.Size = new System.Drawing.Size(182, 20);
            this.icbProgressViewStyle.StyleController = this.layoutControl1;
            this.icbProgressViewStyle.TabIndex = 0;
            this.icbProgressViewStyle.SelectedIndexChanged += new System.EventHandler(this.icbProgressViewStyle_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(692, 385);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(352, 365);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.marqueeProgressBarControl1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(300, 22);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(300, 320);
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
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(352, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(320, 365);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbProgressViewStyle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 26);
            this.layoutControlItem2.Text = "Bar style:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinEditAnimationSpeed;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem3.Text = "Animation Delay:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEditVertical;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEditShowTitle;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.checkEditPause;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.teTitle;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(279, 26);
            this.layoutControlItem7.Text = "Title:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 160);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(220, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(279, 152);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(279, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(1, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(1, 300);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1, 312);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ModuleMarqueeProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleMarqueeProgressBar";
            this.Size = new System.Drawing.Size(827, 636);
            this.Load += new System.EventHandler(this.ModuleMarqueeProgressBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPause.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnimationSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditVertical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbProgressViewStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.CheckEdit checkEditVertical;
        private DevExpress.XtraEditors.CheckEdit checkEditShowTitle;
        private DevExpress.XtraEditors.SpinEdit spinEditAnimationSpeed;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbProgressViewStyle;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.CheckEdit checkEditPause;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;

    }
}
