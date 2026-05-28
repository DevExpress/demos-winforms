namespace DevExpress.XtraLayout.Demos.Modules {
    partial class DragDropLayoutControl {
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
            this.dragDropLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dragDropLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // dragDropLayout
            // 
            this.dragDropLayout.AllowDrop = true;
            this.dragDropLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragDropLayout.Location = new System.Drawing.Point(0, 0);
            this.dragDropLayout.Name = "dragDropLayout";
            this.dragDropLayout.Root = this.layoutControlGroup2;
            this.dragDropLayout.Size = new System.Drawing.Size(362, 346);
            this.dragDropLayout.TabIndex = 5;
            this.dragDropLayout.Text = "layoutControl2";
            this.dragDropLayout.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutControl2_DragDrop);
            this.dragDropLayout.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutControl2_DragEnter);
            this.dragDropLayout.DragOver += new System.Windows.Forms.DragEventHandler(this.layoutControl2_DragOver);
            this.dragDropLayout.DragLeave += new System.EventHandler(this.layoutControl2_DragLeave);
            this.dragDropLayout.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.layoutControl2_GiveFeedback);
            this.dragDropLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layoutControl2_MouseDown);
            this.dragDropLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.layoutControl2_MouseMove);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(362, 346);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // DragDropLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dragDropLayout);
            this.Name = "DragDropLayoutControl";
            this.Size = new System.Drawing.Size(362, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dragDropLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal LayoutControl dragDropLayout;
        private LayoutControlGroup layoutControlGroup2;
    }
}
