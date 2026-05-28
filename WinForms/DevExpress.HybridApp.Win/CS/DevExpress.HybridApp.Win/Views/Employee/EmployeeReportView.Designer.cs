namespace DevExpress.DevAV.Views {
    partial class EmployeeReportView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnExcludeEvaluations = new DevExpress.XtraEditors.CheckButton();
            this.btnIncudeEvaluations = new DevExpress.XtraEditors.CheckButton();
            this.btnOptions = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cbPrinters = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.Printer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Settings = new DevExpress.XtraLayout.SimpleLabelItem();
            this.documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Zoom In", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Zoom Out", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Settings", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Close", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 521);
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(857, 89);
            
            
            
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.btnExcludeEvaluations);
            this.layoutControl.Controls.Add(this.btnIncudeEvaluations);
            this.layoutControl.Controls.Add(this.btnOptions);
            this.layoutControl.Controls.Add(this.btnPrint);
            this.layoutControl.Controls.Add(this.cbPrinters);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(365, 376, 1033, 641);
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(367, 521);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            
            
            
            this.btnExcludeEvaluations.GroupIndex = 1;
            this.btnExcludeEvaluations.Location = new System.Drawing.Point(42, 395);
            this.btnExcludeEvaluations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcludeEvaluations.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeEvaluations.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeEvaluations.Name = "btnExcludeEvaluations";
            this.btnExcludeEvaluations.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExcludeEvaluations.Size = new System.Drawing.Size(283, 40);
            this.btnExcludeEvaluations.StyleController = this.layoutControl;
            this.btnExcludeEvaluations.TabIndex = 8;
            this.btnExcludeEvaluations.TabStop = false;
            this.btnExcludeEvaluations.Text = "Exclude Evaluations";
            
            
            
            this.btnIncudeEvaluations.Checked = true;
            this.btnIncudeEvaluations.GroupIndex = 1;
            this.btnIncudeEvaluations.Location = new System.Drawing.Point(42, 339);
            this.btnIncudeEvaluations.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnIncudeEvaluations.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnIncudeEvaluations.Name = "btnIncudeEvaluations";
            this.btnIncudeEvaluations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncudeEvaluations.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnIncudeEvaluations.Size = new System.Drawing.Size(283, 40);
            this.btnIncudeEvaluations.StyleController = this.layoutControl;
            this.btnIncudeEvaluations.TabIndex = 7;
            this.btnIncudeEvaluations.Text = "Include Evaluations";
            
            
            
            this.btnOptions.Location = new System.Drawing.Point(42, 248);
            this.btnOptions.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnOptions.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(143, 40);
            this.btnOptions.StyleController = this.layoutControl;
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Text = "Print Options";
            
            
            
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(42, 73);
            this.btnPrint.MaximumSize = new System.Drawing.Size(75, 75);
            this.btnPrint.MinimumSize = new System.Drawing.Size(75, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShowToolTips = false;
            this.btnPrint.Size = new System.Drawing.Size(75, 75);
            this.btnPrint.StyleController = this.layoutControl;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            
            
            
            this.cbPrinters.Location = new System.Drawing.Point(40, 196);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPrinters.Size = new System.Drawing.Size(287, 42);
            this.cbPrinters.StyleController = this.layoutControl;
            this.cbPrinters.TabIndex = 4;
            
            
            
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.Printer,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.simpleLabelItem2,
            this.layoutControlItem2,
            this.layoutControlGroupSettings});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(367, 521);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.FontSizeDelta = 6;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 20, 20);
            this.simpleLabelItem1.Size = new System.Drawing.Size(287, 71);
            this.simpleLabelItem1.Text = "Print";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(157, 31);
            
            
            
            this.Printer.AppearanceItemCaption.FontSizeDelta = 3;
            this.Printer.AppearanceItemCaption.Options.UseFont = true;
            this.Printer.Control = this.cbPrinters;
            this.Printer.Location = new System.Drawing.Point(0, 150);
            this.Printer.Name = "Printer";
            this.Printer.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 8);
            this.Printer.Size = new System.Drawing.Size(287, 96);
            this.Printer.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.Printer.TextLocation = DevExpress.Utils.Locations.Top;
            this.Printer.TextSize = new System.Drawing.Size(57, 25);
            this.Printer.TextToControlDistance = 5;
            
            
            
            this.layoutControlItem1.Control = this.btnOptions;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 246);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(147, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            
            
            
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(147, 246);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(140, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AllowHtmlStringInCaption = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem2.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleLabelItem2.CustomizationFormText = "Specify how you want<br>the report to be printed";
            this.simpleLabelItem2.Location = new System.Drawing.Point(81, 71);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0);
            this.simpleLabelItem2.Size = new System.Drawing.Size(206, 79);
            this.simpleLabelItem2.Text = "Specify how you want<br>the report to be printed";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(157, 40);
            
            
            
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(81, 79);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            
            
            
            this.layoutControlGroupSettings.GroupBordersVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.Settings});
            this.layoutControlGroupSettings.Location = new System.Drawing.Point(0, 292);
            this.layoutControlGroupSettings.Name = "layoutControlGroupSettings";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(287, 229);
            
            
            
            this.layoutControlItem3.Control = this.btnIncudeEvaluations;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(287, 56);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            
            
            
            this.layoutControlItem4.Control = this.btnExcludeEvaluations;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(287, 128);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            
            
            
            this.Settings.AllowHotTrack = false;
            this.Settings.AppearanceItemCaption.FontSizeDelta = 3;
            this.Settings.AppearanceItemCaption.Options.UseFont = true;
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(287, 45);
            this.Settings.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0);
            this.Settings.Text = "Settings";
            this.Settings.TextSize = new System.Drawing.Size(157, 25);
            
            
            
            this.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer.IsMetric = false;
            this.documentViewer.Location = new System.Drawing.Point(367, 0);
            this.documentViewer.Name = "documentViewer";
            this.documentViewer.Size = new System.Drawing.Size(490, 521);
            this.documentViewer.TabIndex = 1;
            this.documentViewer.ZoomChanged += new System.EventHandler(this.documentViewer_ZoomChanged);
            
            
            
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.ReportPreviewViewModel);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentViewer);
            this.Controls.Add(this.layoutControl);
            this.Name = "EmployeeReportView";
            this.Size = new System.Drawing.Size(857, 610);
            this.Controls.SetChildIndex(this.windowsUIButtonPanel, 0);
            this.Controls.SetChildIndex(this.layoutControl, 0);
            this.Controls.SetChildIndex(this.documentViewer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.SimpleButton btnOptions;
        private XtraEditors.SimpleButton btnPrint;
        private XtraEditors.ImageComboBoxEdit cbPrinters;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;
        private XtraLayout.LayoutControlItem Printer;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraPrinting.Preview.DocumentViewer documentViewer;
        private XtraEditors.CheckButton btnExcludeEvaluations;
        private XtraEditors.CheckButton btnIncudeEvaluations;
        private XtraLayout.SimpleLabelItem simpleLabelItem2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.SimpleLabelItem Settings;
        private XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private Utils.MVVM.MVVMContext mvvmContext;
    }
}
