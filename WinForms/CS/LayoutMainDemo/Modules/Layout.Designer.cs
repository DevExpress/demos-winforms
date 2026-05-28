namespace DevExpress.XtraLayout.Demos {
    partial class Layout {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.sbOpen = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sbOpen
            // 
            this.sbOpen.Location = new System.Drawing.Point(8, 8);
            this.sbOpen.Name = "sbOpen";
            this.sbOpen.Size = new System.Drawing.Size(96, 24);
            this.sbOpen.TabIndex = 0;
            this.sbOpen.Text = "Open Form";
            this.sbOpen.Click += new System.EventHandler(this.sbOpen_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(108, 8);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(132, 24);
            this.sbDelete.TabIndex = 1;
            this.sbDelete.Text = "Delete xml file";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable quick customization mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sbDelete);
            this.Controls.Add(this.sbOpen);
            this.Name = "Layout";
            this.Size = new System.Drawing.Size(459, 272);
            this.Load += new System.EventHandler(this.Layout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbOpen;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}
