namespace DevExpress.XtraEditors.Demos {
    partial class ModuleFlyoutPanel {
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
            this.horzFlyoutPanel = new DevExpress.Utils.FlyoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.vertFlyoutPanel = new DevExpress.Utils.FlyoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupCommands = new DevExpress.XtraEditors.GroupControl();
            this.btnHideToolWindow = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowToolWindow = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblYCoord = new DevExpress.XtraEditors.LabelControl();
            this.lblXCoord = new DevExpress.XtraEditors.LabelControl();
            this.spinEditYCoord = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditXCoord = new DevExpress.XtraEditors.SpinEdit();
            this.cbAnchorTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceCloseOnOuterClick = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbAnimationTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.horzFlyoutPanel)).BeginInit();
            this.horzFlyoutPanel.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertFlyoutPanel)).BeginInit();
            this.vertFlyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCommands)).BeginInit();
            this.groupCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYCoord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditXCoord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnchorTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCloseOnOuterClick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnimationTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // horzFlyoutPanel
            // 
            this.horzFlyoutPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.horzFlyoutPanel.Appearance.Options.UseBackColor = true;
            this.horzFlyoutPanel.Controls.Add(this.labelControl3);
            this.horzFlyoutPanel.Location = new System.Drawing.Point(77, 11);
            this.horzFlyoutPanel.Name = "horzFlyoutPanel";
            this.horzFlyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent;
            this.horzFlyoutPanel.OwnerControl = this.xtraTabPage1;
            this.horzFlyoutPanel.Size = new System.Drawing.Size(400, 60);
            this.horzFlyoutPanel.TabIndex = 0;
            this.horzFlyoutPanel.Hidden += new DevExpress.Utils.FlyoutPanelEventHandler(this.OnFlyoutPanelHidden);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(3, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Content";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.horzFlyoutPanel);
            this.xtraTabPage1.Controls.Add(this.vertFlyoutPanel);
            this.xtraTabPage1.Controls.Add(this.groupCommands);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(782, 430);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // vertFlyoutPanel
            // 
            this.vertFlyoutPanel.Controls.Add(this.labelControl4);
            this.vertFlyoutPanel.Location = new System.Drawing.Point(594, 11);
            this.vertFlyoutPanel.Name = "vertFlyoutPanel";
            this.vertFlyoutPanel.OwnerControl = this.xtraTabPage1;
            this.vertFlyoutPanel.Size = new System.Drawing.Size(69, 400);
            this.vertFlyoutPanel.TabIndex = 1;
            this.vertFlyoutPanel.Hidden += new DevExpress.Utils.FlyoutPanelEventHandler(this.OnFlyoutPanelHidden);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(14, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Content";
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.btnHideToolWindow);
            this.groupCommands.Controls.Add(this.btnShowToolWindow);
            this.groupCommands.Location = new System.Drawing.Point(77, 285);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(294, 69);
            this.groupCommands.TabIndex = 6;
            this.groupCommands.Text = "Commands";
            // 
            // btnHideToolWindow
            // 
            this.btnHideToolWindow.Location = new System.Drawing.Point(156, 30);
            this.btnHideToolWindow.Name = "btnHideToolWindow";
            this.btnHideToolWindow.Size = new System.Drawing.Size(125, 23);
            this.btnHideToolWindow.TabIndex = 6;
            this.btnHideToolWindow.Text = "Hide Tool Window";
            this.btnHideToolWindow.Click += new System.EventHandler(this.OnHideToolWindowClick);
            // 
            // btnShowToolWindow
            // 
            this.btnShowToolWindow.Location = new System.Drawing.Point(15, 30);
            this.btnShowToolWindow.Name = "btnShowToolWindow";
            this.btnShowToolWindow.Size = new System.Drawing.Size(125, 23);
            this.btnShowToolWindow.TabIndex = 5;
            this.btnShowToolWindow.Text = "Show Tool Window";
            this.btnShowToolWindow.Click += new System.EventHandler(this.OnShowToolWindowClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblYCoord);
            this.groupControl1.Controls.Add(this.lblXCoord);
            this.groupControl1.Controls.Add(this.spinEditYCoord);
            this.groupControl1.Controls.Add(this.spinEditXCoord);
            this.groupControl1.Controls.Add(this.cbAnchorTypes);
            this.groupControl1.Controls.Add(this.ceCloseOnOuterClick);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbAnimationTypes);
            this.groupControl1.Location = new System.Drawing.Point(77, 86);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 187);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Properties";
            // 
            // lblYCoord
            // 
            this.lblYCoord.Location = new System.Drawing.Point(208, 157);
            this.lblYCoord.Name = "lblYCoord";
            this.lblYCoord.Size = new System.Drawing.Size(38, 13);
            this.lblYCoord.TabIndex = 8;
            this.lblYCoord.Text = "Y Coord";
            // 
            // lblXCoord
            // 
            this.lblXCoord.Location = new System.Drawing.Point(208, 125);
            this.lblXCoord.Name = "lblXCoord";
            this.lblXCoord.Size = new System.Drawing.Size(38, 13);
            this.lblXCoord.TabIndex = 7;
            this.lblXCoord.Text = "X Coord";
            // 
            // spinEditYCoord
            // 
            this.spinEditYCoord.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditYCoord.Location = new System.Drawing.Point(102, 154);
            this.spinEditYCoord.Name = "spinEditYCoord";
            this.spinEditYCoord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditYCoord.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditYCoord.Properties.IsFloatValue = false;
            this.spinEditYCoord.Properties.Mask.EditMask = "N00";
            this.spinEditYCoord.Size = new System.Drawing.Size(100, 20);
            this.spinEditYCoord.TabIndex = 6;
            this.spinEditYCoord.EditValueChanged += new System.EventHandler(this.OnYCoordEditValueChanged);
            // 
            // spinEditXCoord
            // 
            this.spinEditXCoord.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditXCoord.Location = new System.Drawing.Point(102, 122);
            this.spinEditXCoord.Name = "spinEditXCoord";
            this.spinEditXCoord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditXCoord.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditXCoord.Properties.IsFloatValue = false;
            this.spinEditXCoord.Properties.Mask.EditMask = "N00";
            this.spinEditXCoord.Size = new System.Drawing.Size(100, 20);
            this.spinEditXCoord.TabIndex = 5;
            this.spinEditXCoord.EditValueChanged += new System.EventHandler(this.OnCoordEditValueChanged);
            // 
            // cbAnchorTypes
            // 
            this.cbAnchorTypes.Location = new System.Drawing.Point(102, 33);
            this.cbAnchorTypes.Name = "cbAnchorTypes";
            this.cbAnchorTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAnchorTypes.Properties.DropDownRows = 8;
            this.cbAnchorTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbAnchorTypes.Size = new System.Drawing.Size(179, 20);
            this.cbAnchorTypes.TabIndex = 0;
            this.cbAnchorTypes.SelectedValueChanged += new System.EventHandler(this.OnAnchorTypeSelectedValueChanged);
            // 
            // ceCloseOnOuterClick
            // 
            this.ceCloseOnOuterClick.Location = new System.Drawing.Point(100, 94);
            this.ceCloseOnOuterClick.Name = "ceCloseOnOuterClick";
            this.ceCloseOnOuterClick.Properties.Caption = "Close On Outer Click";
            this.ceCloseOnOuterClick.Size = new System.Drawing.Size(133, 20);
            this.ceCloseOnOuterClick.TabIndex = 4;
            this.ceCloseOnOuterClick.CheckedChanged += new System.EventHandler(this.OnCloseOnOuterClickCheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Animation Type";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Anchor";
            // 
            // cbAnimationTypes
            // 
            this.cbAnimationTypes.Location = new System.Drawing.Point(102, 65);
            this.cbAnimationTypes.Name = "cbAnimationTypes";
            this.cbAnimationTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAnimationTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbAnimationTypes.Size = new System.Drawing.Size(179, 20);
            this.cbAnimationTypes.TabIndex = 1;
            this.cbAnimationTypes.SelectedValueChanged += new System.EventHandler(this.OnAnimationTypesSelectedValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(784, 432);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // ModuleFlyoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleFlyoutPanel";
            ((System.ComponentModel.ISupportInitialize)(this.horzFlyoutPanel)).EndInit();
            this.horzFlyoutPanel.ResumeLayout(false);
            this.horzFlyoutPanel.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vertFlyoutPanel)).EndInit();
            this.vertFlyoutPanel.ResumeLayout(false);
            this.vertFlyoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCommands)).EndInit();
            this.groupCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYCoord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditXCoord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnchorTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCloseOnOuterClick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnimationTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.FlyoutPanel horzFlyoutPanel;
        private Utils.FlyoutPanel vertFlyoutPanel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbAnimationTypes;
        private DevExpress.XtraEditors.ComboBoxEdit cbAnchorTypes;
        private DevExpress.XtraEditors.SimpleButton btnShowToolWindow;
        private DevExpress.XtraEditors.CheckEdit ceCloseOnOuterClick;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupCommands;
        private DevExpress.XtraEditors.SimpleButton btnHideToolWindow;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblYCoord;
        private DevExpress.XtraEditors.LabelControl lblXCoord;
        private DevExpress.XtraEditors.SpinEdit spinEditYCoord;
        private DevExpress.XtraEditors.SpinEdit spinEditXCoord;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
