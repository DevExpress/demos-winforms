namespace DevExpress.XtraEditors.Demos.Modules {
    partial class TimerControl {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerControl));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.timeLabel = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanelStart = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.windowsUIButtonPanelCancel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 48.25F);
            this.timeLabel.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.timeLabel.Appearance.Options.UseFont = true;
            this.timeLabel.Appearance.Options.UseForeColor = true;
            this.timeLabel.Appearance.Options.UseTextOptions = true;
            this.timeLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timeLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(35, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(274, 62);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "05:00:00";
            // 
            // windowsUIButtonPanelStart
            // 
            this.windowsUIButtonPanelStart.AllowGlyphSkinning = false;
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            this.windowsUIButtonPanelStart.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Start", false, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelStart.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanelStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowsUIButtonPanelStart.Location = new System.Drawing.Point(309, 0);
            this.windowsUIButtonPanelStart.Name = "windowsUIButtonPanelStart";
            this.windowsUIButtonPanelStart.Size = new System.Drawing.Size(35, 62);
            this.windowsUIButtonPanelStart.TabIndex = 2;
            this.windowsUIButtonPanelStart.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanelStart.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelStart.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.OnButtonClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTick);
            // 
            // windowsUIButtonPanelCancel
            // 
            this.windowsUIButtonPanelCancel.AllowGlyphSkinning = false;
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            this.windowsUIButtonPanelCancel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", false, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelCancel.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanelCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCancel.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCancel.Name = "windowsUIButtonPanelCancel";
            this.windowsUIButtonPanelCancel.Size = new System.Drawing.Size(35, 62);
            this.windowsUIButtonPanelCancel.TabIndex = 3;
            this.windowsUIButtonPanelCancel.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanelCancel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelCancel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.OnButtonClick);
            // 
            // TimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.windowsUIButtonPanelCancel);
            this.Controls.Add(this.windowsUIButtonPanelStart);
            this.Name = "TimerControl";
            this.Size = new System.Drawing.Size(344, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl timeLabel;
        private XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelStart;
        private System.Windows.Forms.Timer timer;
        private XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCancel;
    }
}
