namespace DevExpress.XtraScheduler.Demos.Forms {
    partial class MyInplaceEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyInplaceEditor));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.appointmentLabelEdit = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtSubject = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edtDescription);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.appointmentLabelEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.edtSubject);
            this.groupControl1.Controls.Add(this.labelControl2);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // edtDescription
            // 
            resources.ApplyResources(this.edtDescription, "edtDescription");
            this.edtDescription.MinimumSize = new System.Drawing.Size(0, 32);
            this.edtDescription.Name = "edtDescription";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // appointmentLabelEdit
            // 
            resources.ApplyResources(this.appointmentLabelEdit, "appointmentLabelEdit");
            this.appointmentLabelEdit.Name = "appointmentLabelEdit";
            this.appointmentLabelEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // edtSubject
            // 
            resources.ApplyResources(this.edtSubject, "edtSubject");
            this.edtSubject.Name = "edtSubject";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // MyInplaceEditor
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyInplaceEditor";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit edtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit appointmentLabelEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit edtSubject;
        private DevExpress.XtraEditors.LabelControl labelControl2;





    }
}
