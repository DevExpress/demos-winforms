namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMRUEdit {
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceAllowAdding = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowCustomButtons = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowRemoveItems = new DevExpress.XtraEditors.CheckEdit();
            this.mruEditSample = new DevExpress.XtraEditors.MRUEdit();
            this.seMaxItemCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowAdding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCustomButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRemoveItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seMaxItemCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceAllowAdding);
            this.layoutControl1.Controls.Add(this.ceShowCustomButtons);
            this.layoutControl1.Controls.Add(this.ceAllowRemoveItems);
            this.layoutControl1.Controls.Add(this.mruEditSample);
            this.layoutControl1.Controls.Add(this.seMaxItemCount);
            this.layoutControl1.Location = new System.Drawing.Point(28, 27);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(964, 27, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(517, 270);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceAllowAdding
            // 
            this.ceAllowAdding.EditValue = true;
            this.ceAllowAdding.Location = new System.Drawing.Point(310, 212);
            this.ceAllowAdding.Name = "ceAllowAdding";
            this.ceAllowAdding.Properties.Caption = "Allow adding item to a mru list";
            this.ceAllowAdding.Size = new System.Drawing.Size(186, 20);
            this.ceAllowAdding.StyleController = this.layoutControl1;
            this.ceAllowAdding.TabIndex = 0;
            // 
            // ceShowCustomButtons
            // 
            this.ceShowCustomButtons.Location = new System.Drawing.Point(310, 109);
            this.ceShowCustomButtons.Name = "ceShowCustomButtons";
            this.ceShowCustomButtons.Properties.Caption = "Show custom buttons";
            this.ceShowCustomButtons.Size = new System.Drawing.Size(186, 20);
            this.ceShowCustomButtons.StyleController = this.layoutControl1;
            this.ceShowCustomButtons.TabIndex = 2;
            this.ceShowCustomButtons.CheckedChanged += new System.EventHandler(this.ceShowCustomButtons_CheckedChanged);
            // 
            // ceAllowRemoveItems
            // 
            this.ceAllowRemoveItems.Location = new System.Drawing.Point(310, 81);
            this.ceAllowRemoveItems.Name = "ceAllowRemoveItems";
            this.ceAllowRemoveItems.Properties.Caption = "Allow Remove MRU Items";
            this.ceAllowRemoveItems.Size = new System.Drawing.Size(186, 20);
            this.ceAllowRemoveItems.StyleController = this.layoutControl1;
            this.ceAllowRemoveItems.TabIndex = 1;
            this.ceAllowRemoveItems.CheckedChanged += new System.EventHandler(this.ceAllowRemoveItems_CheckedChanged);
            // 
            // mruEditSample
            // 
            this.mruEditSample.EditValue = "www.devexpress.com";
            this.mruEditSample.Location = new System.Drawing.Point(32, 132);
            this.mruEditSample.Name = "mruEditSample";
            editorButtonImageOptions1.EnableTransparency = false;
            this.mruEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open file", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "Open file", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.mruEditSample.Properties.Items.AddRange(new object[] {
            "www.devexpress.com",
            "www.devexpress.com/ClientCenter/Downloads/#Trials",
            "www.devexpress.com/ClientCenter/Purchase/"});
            this.mruEditSample.Size = new System.Drawing.Size(206, 22);
            this.mruEditSample.StyleController = this.layoutControl1;
            this.mruEditSample.TabIndex = 0;
            this.mruEditSample.AddingMRUItem += new DevExpress.XtraEditors.Controls.AddingMRUItemEventHandler(this.mruEditSample_AddingMRUItem);
            this.mruEditSample.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.mruEditSample_ButtonClick);
            // 
            // seMaxItemCount
            // 
            this.seMaxItemCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seMaxItemCount.Location = new System.Drawing.Point(397, 53);
            this.seMaxItemCount.Name = "seMaxItemCount";
            this.seMaxItemCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seMaxItemCount.Properties.IsFloatValue = false;
            this.seMaxItemCount.Properties.Mask.EditMask = "N00";
            this.seMaxItemCount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seMaxItemCount.Size = new System.Drawing.Size(99, 20);
            this.seMaxItemCount.StyleController = this.layoutControl1;
            this.seMaxItemCount.TabIndex = 0;
            this.seMaxItemCount.EditValueChanged += new System.EventHandler(this.seMaxItemCount_EditValueChanged);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(528, 265);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(278, 245);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mruEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(210, 184);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(278, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(230, 159);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seMaxItemCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(190, 26);
            this.layoutControlItem2.Text = "MaxItemCount:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceAllowRemoveItems;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 28);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceShowCustomButtons;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(190, 26);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(278, 159);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup4.Size = new System.Drawing.Size(230, 86);
            this.layoutControlGroup4.Text = "AddingMRUItem event";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceAllowAdding;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ModuleMRUEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleMRUEdit";
            this.Size = new System.Drawing.Size(799, 524);
            this.Load += new System.EventHandler(this.ModuleMRUEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowAdding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCustomButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRemoveItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seMaxItemCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.MRUEdit mruEditSample;
        private DevExpress.XtraEditors.SpinEdit seMaxItemCount;
        private DevExpress.XtraEditors.CheckEdit ceShowCustomButtons;
        private DevExpress.XtraEditors.CheckEdit ceAllowAdding;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.CheckEdit ceAllowRemoveItems;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
