namespace EditorsTutorials.Modules {
    partial class ToolTipControllerContentProperties {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolTipControllerContentProperties));
            this.icbIconSize = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.icbCustomImage = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.icbIconType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.teTitleText = new DevExpress.XtraEditors.TextEdit();
            this.meToolTipText = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.icbIconSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbIconType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitleText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meToolTipText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // icbIconSize
            // 
            this.icbIconSize.Location = new System.Drawing.Point(176, 101);
            this.icbIconSize.Name = "icbIconSize";
            this.icbIconSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbIconSize.Size = new System.Drawing.Size(97, 20);
            this.icbIconSize.StyleController = this.layoutControl1;
            this.icbIconSize.TabIndex = 22;
            this.icbIconSize.SelectedIndexChanged += new System.EventHandler(this.icbIconSize_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.icbCustomImage);
            this.layoutControl1.Controls.Add(this.icbIconSize);
            this.layoutControl1.Controls.Add(this.icbIconType);
            this.layoutControl1.Controls.Add(this.teTitleText);
            this.layoutControl1.Controls.Add(this.meToolTipText);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(285, 161);
            this.layoutControl1.TabIndex = 24;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // icbCustomImage
            // 
            this.icbCustomImage.EditValue = 0;
            this.icbCustomImage.Location = new System.Drawing.Point(96, 129);
            this.icbCustomImage.Name = "icbCustomImage";
            this.icbCustomImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbCustomImage.Properties.DropDownRows = 12;
            this.icbCustomImage.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 1, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 2, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 3, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 4, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 5, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 6, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 7, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 8, 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 9, 8),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 10, 9)});
            this.icbCustomImage.Properties.SmallImages = this.svgImageCollection1;
            this.icbCustomImage.Size = new System.Drawing.Size(177, 20);
            this.icbCustomImage.StyleController = this.layoutControl1;
            this.icbCustomImage.TabIndex = 23;
            this.icbCustomImage.SelectedIndexChanged += new System.EventHandler(this.icbCustomImage_SelectedIndexChanged);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Time", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Time"))));
            this.svgImageCollection1.Add("Design", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Design"))));
            this.svgImageCollection1.Add("Mail", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Mail"))));
            this.svgImageCollection1.Add("Pie", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Pie"))));
            this.svgImageCollection1.Add("Actions_32x32_Home", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Actions_32x32_Home"))));
            this.svgImageCollection1.Add("Tag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Tag"))));
            this.svgImageCollection1.Add("PersonalID", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.PersonalID"))));
            this.svgImageCollection1.Add("Database", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Database"))));
            this.svgImageCollection1.Add("task", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.task"))));
            this.svgImageCollection1.Add("Video", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Video"))));
            // 
            // icbIconType
            // 
            this.icbIconType.Location = new System.Drawing.Point(96, 101);
            this.icbIconType.Name = "icbIconType";
            this.icbIconType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbIconType.Properties.DropDownRows = 12;
            this.icbIconType.Size = new System.Drawing.Size(76, 20);
            this.icbIconType.StyleController = this.layoutControl1;
            this.icbIconType.TabIndex = 21;
            this.icbIconType.SelectedIndexChanged += new System.EventHandler(this.icbIconType_SelectedIndexChanged);
            // 
            // teTitleText
            // 
            this.teTitleText.EditValue = "";
            this.teTitleText.Location = new System.Drawing.Point(96, 73);
            this.teTitleText.Name = "teTitleText";
            this.teTitleText.Size = new System.Drawing.Size(177, 20);
            this.teTitleText.StyleController = this.layoutControl1;
            this.teTitleText.TabIndex = 20;
            this.teTitleText.TextChanged += new System.EventHandler(this.teTitleText_TextChanged);
            // 
            // meToolTipText
            // 
            this.meToolTipText.EditValue = "";
            this.meToolTipText.Location = new System.Drawing.Point(96, 12);
            this.meToolTipText.Name = "meToolTipText";
            this.meToolTipText.Size = new System.Drawing.Size(177, 53);
            this.meToolTipText.StyleController = this.layoutControl1;
            this.meToolTipText.TabIndex = 19;
            this.meToolTipText.TextChanged += new System.EventHandler(this.meToolTipText_TextChanged);
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 161);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.meToolTipText;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(265, 59);
            this.layoutControlItem1.Text = "ToolTip text:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teTitleText;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 6);
            this.layoutControlItem2.Size = new System.Drawing.Size(265, 30);
            this.layoutControlItem2.Text = "Title text:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.icbIconType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem3.Text = "Icon type/size:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.icbIconSize;
            this.layoutControlItem4.Location = new System.Drawing.Point(164, 89);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(101, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.icbCustomImage;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 113);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(265, 28);
            this.layoutControlItem5.Text = "Custom image:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ToolTipControllerContentProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ToolTipControllerContentProperties";
            this.Size = new System.Drawing.Size(285, 161);
            ((System.ComponentModel.ISupportInitialize)(this.icbIconSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbIconType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitleText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meToolTipText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ImageComboBoxEdit icbIconSize;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCustomImage;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbIconType;
        private DevExpress.XtraEditors.TextEdit teTitleText;
        private DevExpress.XtraEditors.MemoEdit meToolTipText;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}
