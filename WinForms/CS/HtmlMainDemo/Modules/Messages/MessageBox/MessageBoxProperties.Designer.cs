namespace DevExpress.HTML.Demos {
    partial class MessageBoxProperties {
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
            this.txtText = new DevExpress.XtraEditors.MemoEdit();
            this.icbImage = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.captionItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.textItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.txtText);
            this.layoutControl1.Controls.Add(this.icbImage);
            this.layoutControl1.Controls.Add(this.txtCaption);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(264, 207);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(67, 40);
            this.txtText.Name = "txtText";
            this.txtText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.Size = new System.Drawing.Size(178, 127);
            this.txtText.StyleController = this.layoutControl1;
            this.txtText.TabIndex = 3;
            this.txtText.EditValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // icbImage
            // 
            this.icbImage.EditValue = 0;
            this.icbImage.Location = new System.Drawing.Point(67, 169);
            this.icbImage.Name = "icbImage";
            this.icbImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbImage.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("check", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("check2", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("warning", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("error", 3, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("cancel", 4, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("info", 5, 5)});
            this.icbImage.Properties.SmallImages = this.svgImageCollection1;
            this.icbImage.ShowToolTips = false;
            this.icbImage.Size = new System.Drawing.Size(178, 20);
            this.icbImage.StyleController = this.layoutControl1;
            this.icbImage.TabIndex = 0;
            this.icbImage.EditValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(67, 18);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(178, 20);
            this.txtCaption.StyleController = this.layoutControl1;
            this.txtCaption.TabIndex = 2;
            this.txtCaption.EditValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.captionItem,
            this.textItem,
            this.imageItem});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17);
            this.Root.Size = new System.Drawing.Size(264, 207);
            this.Root.TextVisible = false;
            // 
            // captionItem
            // 
            this.captionItem.Control = this.txtCaption;
            this.captionItem.Location = new System.Drawing.Point(0, 0);
            this.captionItem.Name = "captionItem";
            this.captionItem.Size = new System.Drawing.Size(228, 22);
            this.captionItem.Text = "Caption:";
            this.captionItem.TextSize = new System.Drawing.Size(41, 13);
            // 
            // textItem
            // 
            this.textItem.Control = this.txtText;
            this.textItem.Location = new System.Drawing.Point(0, 22);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(228, 129);
            this.textItem.Text = "Text:";
            this.textItem.TextSize = new System.Drawing.Size(41, 13);
            // 
            // imageItem
            // 
            this.imageItem.Control = this.icbImage;
            this.imageItem.Location = new System.Drawing.Point(0, 151);
            this.imageItem.Name = "imageItem";
            this.imageItem.Size = new System.Drawing.Size(228, 22);
            this.imageItem.Text = "Image:";
            this.imageItem.TextSize = new System.Drawing.Size(41, 13);
            // 
            // MessageBoxProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MessageBoxProperties";
            this.Size = new System.Drawing.Size(264, 207);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit icbImage;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.MemoEdit txtText;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem captionItem;
        private XtraLayout.LayoutControlItem textItem;
        private XtraLayout.LayoutControlItem imageItem;
    }
}
