namespace DevExpress.HTML.Demos {
    partial class RepositoryItems {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepositoryItems));
            this.htmlContentControl = new DevExpress.XtraEditors.HtmlContentControl();
            this.emailEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.passEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cPassEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.checkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.templateCodeViewer = new DevExpress.HTML.Demos.HtmlContentControlCodeViewer();
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl
            // 
            this.htmlContentControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles");
            this.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template");
            this.htmlContentControl.Location = new System.Drawing.Point(5, 0);
            this.htmlContentControl.Name = "htmlContentControl";
            this.htmlContentControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.emailEdit,
            this.passEdit,
            this.cPassEdit,
            this.checkEdit,
            this.pictureEdit});
            this.htmlContentControl.Size = new System.Drawing.Size(395, 445);
            this.htmlContentControl.TabIndex = 0;
            this.htmlContentControl.ElementMouseDown += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.OnHtmlElementMouseDown);
            // 
            // emailEdit
            // 
            this.emailEdit.AutoHeight = false;
            this.emailEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.emailEdit.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.emailEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.emailEdit.Name = "emailEdit";
            this.emailEdit.NullValuePrompt = "Email Address";
            // 
            // passEdit
            // 
            this.passEdit.AutoHeight = false;
            this.passEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.passEdit.Name = "passEdit";
            this.passEdit.NullValuePrompt = "Password";
            this.passEdit.PasswordChar = '*';
            // 
            // cPassEdit
            // 
            this.cPassEdit.AutoHeight = false;
            this.cPassEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cPassEdit.Name = "cPassEdit";
            this.cPassEdit.NullValuePrompt = "Confirm Password";
            this.cPassEdit.PasswordChar = '*';
            // 
            // checkEdit
            // 
            this.checkEdit.AllowFocused = false;
            this.checkEdit.AutoHeight = false;
            this.checkEdit.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.checkEdit.ImageOptions.SvgImageChecked = global::DevExpress.HTML.Demos.Properties.Resources._checked;
            this.checkEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.checkEdit.ImageOptions.SvgImageUnchecked = global::DevExpress.HTML.Demos.Properties.Resources._unchecked;
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // pictureEdit
            // 
            this.pictureEdit.AllowFocused = false;
            this.pictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pictureEdit.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.ImageChanged += new System.EventHandler(this.OnPictureEditImageChanged);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("default_photo", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.default_photo"))));
            // 
            // templateCodeViewer
            // 
            this.templateCodeViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateCodeViewer.Location = new System.Drawing.Point(1, 0);
            this.templateCodeViewer.Name = "templateCodeViewer";
            this.templateCodeViewer.Size = new System.Drawing.Size(399, 445);
            this.templateCodeViewer.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.templateCodeViewer);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(400, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(400, 445);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.Text = "sidePanel";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "UserInfo";
            // 
            // RepositoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlContentControl);
            this.Controls.Add(this.sidePanel);
            this.Name = "RepositoryItems";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl;
        private XtraEditors.Repository.RepositoryItemTextEdit emailEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit passEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit cPassEdit;
        private XtraEditors.Repository.RepositoryItemCheckEdit checkEdit;
        private XtraEditors.Repository.RepositoryItemPictureEdit pictureEdit;
        private Utils.SvgImageCollection svgImageCollection1;
        private HtmlContentControlCodeViewer templateCodeViewer;
        private XtraEditors.SidePanel sidePanel;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}
