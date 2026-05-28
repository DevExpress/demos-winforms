namespace PhotoViewer {
    partial class FolderGroupCaptionControl {
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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Appearance.Options.UseFont = true;
            this.nameLabel.Size = new System.Drawing.Size(89, 21);
            this.nameLabel.Text = "FolderName";
            // 
            // dataLabel
            // 
            this.dataLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Appearance.Options.UseFont = true;
            // 
            // groupIcon
            // 
            this.groupIcon.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupIcon.Appearance.Image = global::PhotoViewer.Properties.Resources.Folder_32x32;
            this.groupIcon.Appearance.Options.UseFont = true;
            this.groupIcon.Appearance.Options.UseImage = true;
            this.groupIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // editLabel
            // 
            this.editLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Edit_16x16;
            this.editLabel.Appearance.Options.UseImage = true;
            this.editLabel.Location = new System.Drawing.Point(162, 18);
            this.editLabel.Visible = false;
            // 
            // removeLabel
            // 
            this.removeLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.RemoveAlbum_16x16;
            this.removeLabel.Appearance.Options.UseImage = true;
            this.removeLabel.Location = new System.Drawing.Point(189, 18);
            this.removeLabel.ToolTip = "Remove folder from list";
            // 
            // collageLabel
            // 
            this.collageLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Collage_16x16;
            this.collageLabel.Appearance.Options.UseImage = true;
            this.collageLabel.Location = new System.Drawing.Point(226, 18);
            this.collageLabel.ToolTip = "Make collage";
            // 
            // slideshowLabel
            // 
            this.slideshowLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Slideshow_16x16;
            this.slideshowLabel.Appearance.Options.UseImage = true;
            this.slideshowLabel.Location = new System.Drawing.Point(253, 18);
            this.slideshowLabel.ToolTip = "Make slideshow";
            // 
            // filmLabel
            // 
            this.filmLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Film_16x16;
            this.filmLabel.Appearance.Options.UseImage = true;
            this.filmLabel.Location = new System.Drawing.Point(280, 18);
            this.filmLabel.ToolTip = "Make film";
            // 
            // separatorLabel
            // 
            this.separatorLabel.Location = new System.Drawing.Point(216, 22);
            // 
            // FolderGroupCaptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FolderGroupCaptionControl";
            this.Size = new System.Drawing.Size(310, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
