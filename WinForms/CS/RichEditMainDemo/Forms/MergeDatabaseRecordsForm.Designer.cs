namespace DevExpress.XtraRichEdit.Demos.Forms {
    partial class MergeDatabaseRecordsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.rgMergeRecords = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.rgMergeTo = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeRecords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rgMergeRecords
            // 
            this.rgMergeRecords.Location = new System.Drawing.Point(13, 31);
            this.rgMergeRecords.Name = "rgMergeRecords";
            this.rgMergeRecords.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMergeRecords.Properties.Appearance.Options.UseBackColor = true;
            this.rgMergeRecords.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMergeRecords.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Selected"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All")});
            this.rgMergeRecords.Size = new System.Drawing.Size(211, 52);
            this.rgMergeRecords.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Merge records";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(62, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rgMergeTo
            // 
            this.rgMergeTo.Location = new System.Drawing.Point(13, 108);
            this.rgMergeTo.Name = "rgMergeTo";
            this.rgMergeTo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMergeTo.Properties.Appearance.Options.UseBackColor = true;
            this.rgMergeTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMergeTo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Window"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "File")});
            this.rgMergeTo.Size = new System.Drawing.Size(205, 22);
            this.rgMergeTo.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(205, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Merge to";
            // 
            // MergeDatabaseRecordsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(228, 168);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.rgMergeTo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rgMergeRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeDatabaseRecordsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Options";
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeRecords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgMergeRecords;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.RadioGroup rgMergeTo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
