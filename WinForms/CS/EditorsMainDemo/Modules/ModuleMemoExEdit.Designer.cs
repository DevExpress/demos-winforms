namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMemoExEdit {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleMemoExEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceCustomIcons = new DevExpress.XtraEditors.CheckEdit();
            this.ceWordWrap = new DevExpress.XtraEditors.CheckEdit();
            this.ceIcon = new DevExpress.XtraEditors.CheckEdit();
            this.cePopupSizeable = new DevExpress.XtraEditors.CheckEdit();
            this.memoExEditSample = new DevExpress.XtraEditors.MemoExEdit();
            this.icbScrollBars = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceAutoHideScrollBars = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMemoExEditSample = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciIcbScrollBars = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCeWordWrap = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCeIcon = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCePopupSizeable = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCeCustomIcons = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCeAutoHideScrollBars = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoHideScrollBars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMemoExEditSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIcbScrollBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeWordWrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCePopupSizeable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeCustomIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeAutoHideScrollBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceCustomIcons);
            this.layoutControl1.Controls.Add(this.ceWordWrap);
            this.layoutControl1.Controls.Add(this.ceIcon);
            this.layoutControl1.Controls.Add(this.cePopupSizeable);
            this.layoutControl1.Controls.Add(this.memoExEditSample);
            this.layoutControl1.Controls.Add(this.icbScrollBars);
            this.layoutControl1.Controls.Add(this.ceAutoHideScrollBars);
            this.layoutControl1.Location = new System.Drawing.Point(41, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(986, 45, 737, 684);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(589, 275);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceCustomIcons
            // 
            this.ceCustomIcons.Location = new System.Drawing.Point(333, 165);
            this.ceCustomIcons.Name = "ceCustomIcons";
            this.ceCustomIcons.Properties.Caption = "Use custom icons";
            this.ceCustomIcons.Size = new System.Drawing.Size(224, 20);
            this.ceCustomIcons.StyleController = this.layoutControl1;
            this.ceCustomIcons.TabIndex = 6;
            this.ceCustomIcons.CheckedChanged += new System.EventHandler(this.ceCustomIcons_CheckedChanged);
            // 
            // ceWordWrap
            // 
            this.ceWordWrap.Location = new System.Drawing.Point(333, 81);
            this.ceWordWrap.Name = "ceWordWrap";
            this.ceWordWrap.Properties.Caption = "Word wrap";
            this.ceWordWrap.Size = new System.Drawing.Size(224, 20);
            this.ceWordWrap.StyleController = this.layoutControl1;
            this.ceWordWrap.TabIndex = 1;
            this.ceWordWrap.CheckedChanged += new System.EventHandler(this.ceWordWrap_CheckedChanged);
            // 
            // ceIcon
            // 
            this.ceIcon.Location = new System.Drawing.Point(333, 109);
            this.ceIcon.Name = "ceIcon";
            this.ceIcon.Properties.Caption = "Show icon";
            this.ceIcon.Size = new System.Drawing.Size(224, 20);
            this.ceIcon.StyleController = this.layoutControl1;
            this.ceIcon.TabIndex = 4;
            this.ceIcon.CheckedChanged += new System.EventHandler(this.ceIcon_CheckedChanged);
            // 
            // cePopupSizeable
            // 
            this.cePopupSizeable.Location = new System.Drawing.Point(333, 137);
            this.cePopupSizeable.Name = "cePopupSizeable";
            this.cePopupSizeable.Properties.Caption = "Popup sizeable";
            this.cePopupSizeable.Size = new System.Drawing.Size(224, 20);
            this.cePopupSizeable.StyleController = this.layoutControl1;
            this.cePopupSizeable.TabIndex = 5;
            this.cePopupSizeable.CheckedChanged += new System.EventHandler(this.cePopupSizeable_CheckedChanged);
            // 
            // memoExEditSample
            // 
            this.memoExEditSample.Location = new System.Drawing.Point(32, 138);
            this.memoExEditSample.Name = "memoExEditSample";
            this.memoExEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoExEditSample.Size = new System.Drawing.Size(229, 20);
            this.memoExEditSample.StyleController = this.layoutControl1;
            this.memoExEditSample.TabIndex = 0;
            // 
            // icbScrollBars
            // 
            this.icbScrollBars.EditValue = "imageComboBoxEdit1";
            this.icbScrollBars.Location = new System.Drawing.Point(398, 53);
            this.icbScrollBars.Name = "icbScrollBars";
            this.icbScrollBars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbScrollBars.Size = new System.Drawing.Size(159, 20);
            this.icbScrollBars.StyleController = this.layoutControl1;
            this.icbScrollBars.TabIndex = 0;
            this.icbScrollBars.SelectedIndexChanged += new System.EventHandler(this.icbScrollBars_SelectedIndexChanged);
            // 
            // ceAutoHideScrollBars
            // 
            this.ceAutoHideScrollBars.Location = new System.Drawing.Point(333, 193);
            this.ceAutoHideScrollBars.Name = "ceAutoHideScrollBars";
            this.ceAutoHideScrollBars.Properties.Caption = "Auto Hide ScrollBars";
            this.ceAutoHideScrollBars.Size = new System.Drawing.Size(224, 20);
            this.ceAutoHideScrollBars.StyleController = this.layoutControl1;
            this.ceAutoHideScrollBars.TabIndex = 7;
            this.ceAutoHideScrollBars.CheckedChanged += new System.EventHandler(this.ceAutoHideScrollBars_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(589, 275);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMemoExEditSample});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(301, 255);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // lciMemoExEditSample
            // 
            this.lciMemoExEditSample.Control = this.memoExEditSample;
            this.lciMemoExEditSample.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lciMemoExEditSample.FillControlToClientArea = false;
            this.lciMemoExEditSample.Location = new System.Drawing.Point(0, 0);
            this.lciMemoExEditSample.MinSize = new System.Drawing.Size(190, 24);
            this.lciMemoExEditSample.Name = "lciMemoExEditSample";
            this.lciMemoExEditSample.Size = new System.Drawing.Size(233, 194);
            this.lciMemoExEditSample.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMemoExEditSample.TextVisible = false;
            this.lciMemoExEditSample.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciIcbScrollBars,
            this.lciCeWordWrap,
            this.lciCeIcon,
            this.lciCePopupSizeable,
            this.lciCeCustomIcons,
            this.emptySpaceItem1,
            this.lciCeAutoHideScrollBars});
            this.layoutControlGroup3.Location = new System.Drawing.Point(301, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(268, 255);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // lciIcbScrollBars
            // 
            this.lciIcbScrollBars.Control = this.icbScrollBars;
            this.lciIcbScrollBars.Location = new System.Drawing.Point(0, 0);
            this.lciIcbScrollBars.Name = "lciIcbScrollBars";
            this.lciIcbScrollBars.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.lciIcbScrollBars.Size = new System.Drawing.Size(228, 26);
            this.lciIcbScrollBars.Text = "Scroll bars:";
            this.lciIcbScrollBars.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lciCeWordWrap
            // 
            this.lciCeWordWrap.Control = this.ceWordWrap;
            this.lciCeWordWrap.Location = new System.Drawing.Point(0, 26);
            this.lciCeWordWrap.Name = "lciCeWordWrap";
            this.lciCeWordWrap.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciCeWordWrap.Size = new System.Drawing.Size(228, 28);
            this.lciCeWordWrap.TextVisible = false;
            // 
            // lciCeIcon
            // 
            this.lciCeIcon.Control = this.ceIcon;
            this.lciCeIcon.Location = new System.Drawing.Point(0, 54);
            this.lciCeIcon.Name = "lciCeIcon";
            this.lciCeIcon.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciCeIcon.Size = new System.Drawing.Size(228, 28);
            this.lciCeIcon.TextVisible = false;
            // 
            // lciCePopupSizeable
            // 
            this.lciCePopupSizeable.Control = this.cePopupSizeable;
            this.lciCePopupSizeable.Location = new System.Drawing.Point(0, 82);
            this.lciCePopupSizeable.Name = "lciCePopupSizeable";
            this.lciCePopupSizeable.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciCePopupSizeable.Size = new System.Drawing.Size(228, 28);
            this.lciCePopupSizeable.TextVisible = false;
            // 
            // lciCeCustomIcons
            // 
            this.lciCeCustomIcons.Control = this.ceCustomIcons;
            this.lciCeCustomIcons.Location = new System.Drawing.Point(0, 110);
            this.lciCeCustomIcons.Name = "lciCeCustomIcons";
            this.lciCeCustomIcons.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciCeCustomIcons.Size = new System.Drawing.Size(228, 28);
            this.lciCeCustomIcons.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 166);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(228, 28);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // lciCeAutoHideScrollBars
            // 
            this.lciCeAutoHideScrollBars.Control = this.ceAutoHideScrollBars;
            this.lciCeAutoHideScrollBars.Location = new System.Drawing.Point(0, 138);
            this.lciCeAutoHideScrollBars.Name = "lciCeAutoHideScrollBars";
            this.lciCeAutoHideScrollBars.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciCeAutoHideScrollBars.Size = new System.Drawing.Size(228, 28);
            this.lciCeAutoHideScrollBars.TextVisible = false;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "listbox_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "new_16x16.png");
            // 
            // ModuleMemoExEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleMemoExEdit";
            this.Size = new System.Drawing.Size(755, 480);
            this.Load += new System.EventHandler(this.ModuleMemoExEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoHideScrollBars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMemoExEditSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIcbScrollBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeWordWrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCePopupSizeable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeCustomIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCeAutoHideScrollBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.MemoExEdit memoExEditSample;
        private DevExpress.XtraEditors.CheckEdit ceCustomIcons;
        private DevExpress.XtraEditors.CheckEdit ceIcon;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbScrollBars;
        private DevExpress.XtraEditors.CheckEdit cePopupSizeable;
        private DevExpress.XtraEditors.CheckEdit ceWordWrap;
        private System.ComponentModel.IContainer components = null;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem lciMemoExEditSample;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem lciIcbScrollBars;
        private XtraLayout.LayoutControlItem lciCeWordWrap;
        private XtraLayout.LayoutControlItem lciCeIcon;
        private XtraLayout.LayoutControlItem lciCePopupSizeable;
        private XtraLayout.LayoutControlItem lciCeCustomIcons;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.ImageCollection imageCollection1;
        private CheckEdit ceAutoHideScrollBars;
        private XtraLayout.LayoutControlItem lciCeAutoHideScrollBars;
    }
}
