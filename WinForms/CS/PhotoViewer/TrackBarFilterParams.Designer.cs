namespace PhotoViewer {
    partial class TrackBarFilterParams {
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
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).BeginInit();
            this.SimpleFilterParamsConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            this.SimpleFilterParamsConvertedLayout.Controls.SetChildIndex(this.applyFilterButton, 0);
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarControl1.EditValue = 500;
            this.trackBarControl1.Location = new System.Drawing.Point(104, 51);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.trackBarControl1.Properties.AllowFocused = false;
            this.trackBarControl1.Properties.AutoSize = false;
            this.trackBarControl1.Properties.Maximum = 1000;
            this.trackBarControl1.Properties.ShowValueToolTip = true;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl1.Properties.BeforeShowValueToolTip += new DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(this.OnBeforeShowTrackBarValueToolTip);
            this.trackBarControl1.Size = new System.Drawing.Size(216, 70);
            this.trackBarControl1.TabIndex = 1;
            this.trackBarControl1.Value = 500;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // TrackBarFilterParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TrackBarFilterParams";
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).EndInit();
            this.SimpleFilterParamsConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.TrackBarControl trackBarControl1;

    }
}
