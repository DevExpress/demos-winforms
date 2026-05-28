namespace DevExpress.XtraEditors.Demos {
    partial class ModuleFontEdit {
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
            this.cbFontSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceShowSymbolPreview = new DevExpress.XtraEditors.CheckEdit();
            this.fontEditSample = new DevExpress.XtraEditors.FontEdit();
            this.seRUItemCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowSymbolPreview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seRUItemCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cbFontSize);
            this.layoutControl1.Controls.Add(this.ceShowSymbolPreview);
            this.layoutControl1.Controls.Add(this.fontEditSample);
            this.layoutControl1.Controls.Add(this.seRUItemCount);
            this.layoutControl1.Location = new System.Drawing.Point(36, 36);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1017, 247, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(504, 266);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbFontSize
            // 
            this.cbFontSize.AllowDrop = true;
            this.cbFontSize.Location = new System.Drawing.Point(446, 81);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFontSize.Properties.DropDownRows = 12;
            this.cbFontSize.Properties.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "20",
            "25",
            "30"});
            this.cbFontSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFontSize.Size = new System.Drawing.Size(70, 20);
            this.cbFontSize.StyleController = this.layoutControl1;
            this.cbFontSize.TabIndex = 1;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // ceShowSymbolPreview
            // 
            this.ceShowSymbolPreview.Location = new System.Drawing.Point(300, 109);
            this.ceShowSymbolPreview.Name = "ceShowSymbolPreview";
            this.ceShowSymbolPreview.Properties.Caption = "Show Symbol Font Preview";
            this.ceShowSymbolPreview.Size = new System.Drawing.Size(216, 20);
            this.ceShowSymbolPreview.StyleController = this.layoutControl1;
            this.ceShowSymbolPreview.TabIndex = 2;
            this.ceShowSymbolPreview.CheckedChanged += new System.EventHandler(this.ceShowSymbolPreview_CheckedChanged);
            // 
            // fontEditSample
            // 
            this.fontEditSample.Location = new System.Drawing.Point(32, 125);
            this.fontEditSample.Name = "fontEditSample";
            this.fontEditSample.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontEditSample.Properties.AppearanceDropDown.Options.UseFont = true;
            this.fontEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fontEditSample.Size = new System.Drawing.Size(196, 20);
            this.fontEditSample.StyleController = this.layoutControl1;
            this.fontEditSample.TabIndex = 0;
            // 
            // seRUItemCount
            // 
            this.seRUItemCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seRUItemCount.Location = new System.Drawing.Point(446, 53);
            this.seRUItemCount.Name = "seRUItemCount";
            this.seRUItemCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seRUItemCount.Properties.IsFloatValue = false;
            this.seRUItemCount.Properties.Mask.EditMask = "N00";
            this.seRUItemCount.Properties.MaxValue = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.seRUItemCount.Size = new System.Drawing.Size(70, 20);
            this.seRUItemCount.StyleController = this.layoutControl1;
            this.seRUItemCount.TabIndex = 0;
            this.seRUItemCount.EditValueChanged += new System.EventHandler(this.seRUItemCount_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(548, 249);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(268, 229);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.fontEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 168);
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
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(268, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(260, 229);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AllowHtmlStringInCaption = true;
            this.layoutControlItem2.Control = this.seRUItemCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(220, 26);
            this.layoutControlItem2.Text = "Recently Used Item <b>Count</b>:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHtmlStringInCaption = true;
            this.layoutControlItem3.Control = this.cbFontSize;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(220, 28);
            this.layoutControlItem3.Text = "DropDown Font <b>Size</b>:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceShowSymbolPreview;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(220, 26);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 80);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(220, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(220, 88);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ModuleFontEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleFontEdit";
            this.Size = new System.Drawing.Size(792, 555);
            this.Load += new System.EventHandler(this.ModuleCalcEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowSymbolPreview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seRUItemCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SpinEdit seRUItemCount;
        private DevExpress.XtraEditors.CheckEdit ceShowSymbolPreview;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.FontEdit fontEditSample;
        private DevExpress.XtraEditors.ComboBoxEdit cbFontSize;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
