namespace DevExpress.XtraGauges.Demos {
    partial class ColorPickerControl {
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
            this.xtraTabControl1 = new DevExpress.XtraGauges.Demos.NonFocusableTabControl();
            this.tabCustom = new DevExpress.XtraTab.XtraTabPage();
            this.colorPickControl = new DevExpress.XtraEditors.InnerColorPickControl();
            this.tabWeb = new DevExpress.XtraTab.XtraTabPage();
            this.webColorListControl = new DevExpress.XtraEditors.InnerColorListControl();
            this.tabSystem = new DevExpress.XtraTab.XtraTabPage();
            this.systemColorListControl = new DevExpress.XtraEditors.InnerColorListControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.tabWeb.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabCustom;
            this.xtraTabControl1.Size = new System.Drawing.Size(295, 471);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCustom,
            this.tabWeb,
            this.tabSystem});
            this.xtraTabControl1.TabStop = false;
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.colorPickControl);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Size = new System.Drawing.Size(293, 446);
            this.tabCustom.Text = "Custom";
            // 
            // colorPickControl
            // 
            this.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickControl.Location = new System.Drawing.Point(0, 0);
            this.colorPickControl.Name = "colorPickControl";
            this.colorPickControl.ShowAutomaticButton = false;
            this.colorPickControl.ShowMoreColors = false;
            this.colorPickControl.Size = new System.Drawing.Size(293, 446);
            this.colorPickControl.TabIndex = 2;
            this.colorPickControl.SelectedColorChanged += new DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(this.OnSelectedColorChanged);
            // 
            // tabWeb
            // 
            this.tabWeb.Controls.Add(this.webColorListControl);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Size = new System.Drawing.Size(293, 446);
            this.tabWeb.Text = "Web";
            // 
            // webColorListControl
            // 
            this.webColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.webColorListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webColorListControl.Location = new System.Drawing.Point(0, 0);
            this.webColorListControl.Name = "webColorListControl";
            this.webColorListControl.Size = new System.Drawing.Size(293, 446);
            this.webColorListControl.TabIndex = 1;
            this.webColorListControl.SelectedColorChanged += new DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(this.OnSelectedColorChanged);
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.systemColorListControl);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(293, 446);
            this.tabSystem.Text = "System";
            // 
            // systemColorListControl
            // 
            this.systemColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.systemColorListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemColorListControl.Location = new System.Drawing.Point(0, 0);
            this.systemColorListControl.Name = "systemColorListControl";
            this.systemColorListControl.Size = new System.Drawing.Size(293, 446);
            this.systemColorListControl.TabIndex = 1;
            this.systemColorListControl.SelectedColorChanged += new DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(this.OnSelectedColorChanged);
            // 
            // ColorPickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ColorPickerControl";
            this.Size = new System.Drawing.Size(295, 471);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabCustom.ResumeLayout(false);
            this.tabWeb.ResumeLayout(false);
            this.tabSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Demos.NonFocusableTabControl xtraTabControl1;
        private XtraTab.XtraTabPage tabCustom;
        private XtraTab.XtraTabPage tabWeb;
        private XtraTab.XtraTabPage tabSystem;
        private XtraEditors.InnerColorPickControl colorPickControl;
        private XtraEditors.InnerColorListControl webColorListControl;
        private XtraEditors.InnerColorListControl systemColorListControl;
    }
}
