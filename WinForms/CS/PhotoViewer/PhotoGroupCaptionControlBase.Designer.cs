namespace PhotoViewer {
    partial class PhotoGroupCaptionControlBase {
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
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.groupIcon = new DevExpress.XtraEditors.LabelControl();
            this.dataLabel = new DevExpress.XtraEditors.LabelControl();
            this.editLabel = new DevExpress.XtraEditors.LabelControl();
            this.removeLabel = new DevExpress.XtraEditors.LabelControl();
            this.collageLabel = new DevExpress.XtraEditors.LabelControl();
            this.slideshowLabel = new DevExpress.XtraEditors.LabelControl();
            this.filmLabel = new DevExpress.XtraEditors.LabelControl();
            this.separatorLabel = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Appearance.Options.UseFont = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "AlbumName";
            // 
            // groupIcon
            // 
            this.groupIcon.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupIcon.Appearance.Options.UseFont = true;
            this.groupIcon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.groupIcon.Location = new System.Drawing.Point(9, 11);
            this.groupIcon.Name = "groupIcon";
            this.groupIcon.Size = new System.Drawing.Size(32, 32);
            this.groupIcon.TabIndex = 1;
            this.groupIcon.Click += new System.EventHandler(this.OnGroupIconClick);
            // 
            // dataLabel
            // 
            this.dataLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Appearance.Options.UseFont = true;
            this.dataLabel.Location = new System.Drawing.Point(51, 30);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(56, 13);
            this.dataLabel.TabIndex = 2;
            this.dataLabel.Text = "2025/03/25";
            // 
            // editLabel
            // 
            this.editLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Edit_16x16;
            this.editLabel.Appearance.Options.UseImage = true;
            this.editLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.editLabel.Location = new System.Drawing.Point(159, 18);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(21, 20);
            this.editLabel.TabIndex = 9;
            this.editLabel.Click += new System.EventHandler(this.OnEditButtonClick);
            // 
            // removeLabel
            // 
            this.removeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.RemoveAlbum_16x16;
            this.removeLabel.Appearance.Options.UseImage = true;
            this.removeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.removeLabel.Location = new System.Drawing.Point(186, 18);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(21, 20);
            this.removeLabel.TabIndex = 10;
            this.removeLabel.Click += new System.EventHandler(this.OnRemoveButtonClick);
            // 
            // collageLabel
            // 
            this.collageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collageLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Collage_16x16;
            this.collageLabel.Appearance.Options.UseImage = true;
            this.collageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collageLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.collageLabel.Location = new System.Drawing.Point(223, 18);
            this.collageLabel.Name = "collageLabel";
            this.collageLabel.Size = new System.Drawing.Size(21, 20);
            this.collageLabel.TabIndex = 11;
            this.collageLabel.Click += new System.EventHandler(this.OnCollageButtonClick);
            // 
            // slideshowLabel
            // 
            this.slideshowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slideshowLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Slideshow_16x16;
            this.slideshowLabel.Appearance.Options.UseImage = true;
            this.slideshowLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideshowLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.slideshowLabel.Location = new System.Drawing.Point(250, 18);
            this.slideshowLabel.Name = "slideshowLabel";
            this.slideshowLabel.Size = new System.Drawing.Size(21, 20);
            this.slideshowLabel.TabIndex = 12;
            this.slideshowLabel.Click += new System.EventHandler(this.OnSlideShowButtonClick);
            // 
            // filmLabel
            // 
            this.filmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filmLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Film_16x16;
            this.filmLabel.Appearance.Options.UseImage = true;
            this.filmLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.filmLabel.Location = new System.Drawing.Point(277, 18);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(21, 20);
            this.filmLabel.TabIndex = 13;
            this.filmLabel.Click += new System.EventHandler(this.OnFilmButtonClick);
            // 
            // separatorLabel
            // 
            this.separatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.separatorLabel.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.separatorLabel.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.separatorLabel.LineVisible = true;
            this.separatorLabel.Location = new System.Drawing.Point(213, 22);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(4, 13);
            this.separatorLabel.TabIndex = 14;
            // 
            // PhotoGroupCaptionControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.filmLabel);
            this.Controls.Add(this.slideshowLabel);
            this.Controls.Add(this.collageLabel);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.groupIcon);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "PhotoGroupCaptionControlBase";
            this.Size = new System.Drawing.Size(307, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.XtraEditors.LabelControl nameLabel;
        protected DevExpress.XtraEditors.LabelControl dataLabel;
        protected DevExpress.XtraEditors.LabelControl groupIcon;
        protected DevExpress.XtraEditors.LabelControl editLabel;
        protected DevExpress.XtraEditors.LabelControl removeLabel;
        protected DevExpress.XtraEditors.LabelControl collageLabel;
        protected DevExpress.XtraEditors.LabelControl slideshowLabel;
        protected DevExpress.XtraEditors.LabelControl filmLabel;
        protected DevExpress.XtraEditors.LabelControl separatorLabel;
    }
}
