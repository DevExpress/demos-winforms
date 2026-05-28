namespace PhotoViewer {
    partial class ProgressForm {
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
            this.progressControl1 = new PhotoViewer.ProgressControl();
            this.SuspendLayout();
            // 
            // progressControl1
            // 
            this.progressControl1.Location = new System.Drawing.Point(0, 0);
            this.progressControl1.Maximum = 100;
            this.progressControl1.Name = "progressControl1";
            this.progressControl1.Size = new System.Drawing.Size(355, 57);
            this.progressControl1.TabIndex = 0;
            this.progressControl1.Value = 0;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 57);
            this.Controls.Add(this.progressControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProgressForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressControl progressControl1;
    }
}
