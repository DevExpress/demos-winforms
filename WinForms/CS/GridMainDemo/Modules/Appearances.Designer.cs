namespace DevExpress.XtraGrid.Demos {
    partial class Appearances {
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
            this.lbcAppearances = new DevExpress.XtraEditors.ListBoxControl();
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraPropertyGrid1 = new DevExpress.DXperience.Demos.XtraPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcAppearances
            // 
            this.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbcAppearances.ItemHeight = 16;
            this.lbcAppearances.Location = new System.Drawing.Point(5, 5);
            this.lbcAppearances.Name = "lbcAppearances";
            this.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcAppearances.Size = new System.Drawing.Size(190, 306);
            this.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lbcAppearances.TabIndex = 22;
            this.lbcAppearances.SelectedIndexChanged += new System.EventHandler(this.lbcAppearances_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(195, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 306);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // gcProperties
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(207)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.xtraPropertyGrid1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(201, 5);
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 306);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Properties:";
            // 
            // xtraPropertyGrid1
            // 
            this.xtraPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraPropertyGrid1.Location = new System.Drawing.Point(2, 19);
            this.xtraPropertyGrid1.Name = "xtraPropertyGrid1";
            this.xtraPropertyGrid1.Size = new System.Drawing.Size(294, 285);
            this.xtraPropertyGrid1.TabIndex = 0;
            // 
            // Appearances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbcAppearances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appearances";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Appearances";
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl lbcAppearances;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private DevExpress.DXperience.Demos.XtraPropertyGrid xtraPropertyGrid1;
    }
}
