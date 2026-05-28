namespace DevExpress.XtraEditors.Demos {
    partial class ModuleImageEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleImageEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceCustomIcons = new DevExpress.XtraEditors.CheckEdit();
            this.ceMenu = new DevExpress.XtraEditors.CheckEdit();
            this.cePopupSizeable = new DevExpress.XtraEditors.CheckEdit();
            this.imageEditSample = new DevExpress.XtraEditors.ImageEdit();
            this.ceIcon = new DevExpress.XtraEditors.CheckEdit();
            this.icbSizeMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSizeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceCustomIcons);
            this.layoutControl1.Controls.Add(this.ceMenu);
            this.layoutControl1.Controls.Add(this.cePopupSizeable);
            this.layoutControl1.Controls.Add(this.imageEditSample);
            this.layoutControl1.Controls.Add(this.ceIcon);
            this.layoutControl1.Controls.Add(this.icbSizeMode);
            this.layoutControl1.Location = new System.Drawing.Point(20, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1153, 273, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(506, 200);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceCustomIcons
            // 
            this.ceCustomIcons.Location = new System.Drawing.Point(290, 165);
            this.ceCustomIcons.Name = "ceCustomIcons";
            this.ceCustomIcons.Properties.Caption = "Use custom icons";
            this.ceCustomIcons.Size = new System.Drawing.Size(186, 20);
            this.ceCustomIcons.StyleController = this.layoutControl1;
            this.ceCustomIcons.TabIndex = 31;
            this.ceCustomIcons.CheckedChanged += new System.EventHandler(this.ceCustomIcons_CheckedChanged);
            // 
            // ceMenu
            // 
            this.ceMenu.Location = new System.Drawing.Point(290, 109);
            this.ceMenu.Name = "ceMenu";
            this.ceMenu.Properties.Caption = "Show menu";
            this.ceMenu.Size = new System.Drawing.Size(186, 20);
            this.ceMenu.StyleController = this.layoutControl1;
            this.ceMenu.TabIndex = 29;
            this.ceMenu.CheckedChanged += new System.EventHandler(this.ceMenu_CheckedChanged);
            // 
            // cePopupSizeable
            // 
            this.cePopupSizeable.Location = new System.Drawing.Point(290, 137);
            this.cePopupSizeable.Name = "cePopupSizeable";
            this.cePopupSizeable.Properties.Caption = "Popup sizeable";
            this.cePopupSizeable.Size = new System.Drawing.Size(186, 20);
            this.cePopupSizeable.StyleController = this.layoutControl1;
            this.cePopupSizeable.TabIndex = 30;
            this.cePopupSizeable.CheckedChanged += new System.EventHandler(this.cePopupSizeable_CheckedChanged);
            // 
            // imageEditSample
            // 
            this.imageEditSample.EditValue = ((object)(resources.GetObject("imageEditSample.EditValue")));
            this.imageEditSample.Location = new System.Drawing.Point(32, 110);
            this.imageEditSample.Name = "imageEditSample";
            this.imageEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageEditSample.Properties.PopupFormSize = new System.Drawing.Size(470, 240);
            this.imageEditSample.Size = new System.Drawing.Size(186, 20);
            this.imageEditSample.StyleController = this.layoutControl1;
            this.imageEditSample.TabIndex = 0;
            // 
            // ceIcon
            // 
            this.ceIcon.Location = new System.Drawing.Point(290, 81);
            this.ceIcon.Name = "ceIcon";
            this.ceIcon.Properties.Caption = "Show icon";
            this.ceIcon.Size = new System.Drawing.Size(186, 20);
            this.ceIcon.StyleController = this.layoutControl1;
            this.ceIcon.TabIndex = 28;
            this.ceIcon.CheckedChanged += new System.EventHandler(this.ceIcon_CheckedChanged);
            // 
            // icbSizeMode
            // 
            this.icbSizeMode.EditValue = "imageComboBoxEdit1";
            this.icbSizeMode.Location = new System.Drawing.Point(354, 53);
            this.icbSizeMode.Name = "icbSizeMode";
            this.icbSizeMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSizeMode.Size = new System.Drawing.Size(122, 20);
            this.icbSizeMode.StyleController = this.layoutControl1;
            this.icbSizeMode.TabIndex = 27;
            this.icbSizeMode.SelectedIndexChanged += new System.EventHandler(this.icbSizeMode_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(508, 220);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(258, 200);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.imageEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(190, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 139);
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
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(258, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(230, 200);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbSizeMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(190, 26);
            this.layoutControlItem2.Text = "Size mode:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceIcon;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 28);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceMenu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(190, 28);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cePopupSizeable;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(190, 28);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ceCustomIcons;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(190, 28);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 138);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("gaugestylehalfcircular", "image://svgimages/reports/gaugestylehalfcircular.svg");
            this.svgImageCollection1.Add("glyph_message", "image://svgimages/outlook inspired/glyph_message.svg");
            // 
            // ModuleImageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleImageEdit";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ModuleImageEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSizeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ImageEdit imageEditSample;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbSizeMode;
        private DevExpress.XtraEditors.CheckEdit ceIcon;
        private DevExpress.XtraEditors.CheckEdit ceMenu;
        private DevExpress.XtraEditors.CheckEdit ceCustomIcons;
        private DevExpress.XtraEditors.CheckEdit cePopupSizeable;
        private System.ComponentModel.IContainer components = null;
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
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
