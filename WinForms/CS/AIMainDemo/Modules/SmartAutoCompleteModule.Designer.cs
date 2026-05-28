namespace DevExpress.AI.Demos {
    partial class SmartAutoCompleteModule {
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

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.roundedSkinPanel = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.ucDisclaimerPanel1 = new DevExpress.AI.Demos.ucDisclaimerPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRoundedSkinPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditUserRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.aiEvents1 = new DevExpress.AIIntegration.WinForms.AIEvents();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel)).BeginInit();
            this.roundedSkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoundedSkinPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditUserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedSkinPanel
            // 
            this.roundedSkinPanel.Controls.Add(this.panelControl1);
            this.roundedSkinPanel.Location = new System.Drawing.Point(0, 103);
            this.roundedSkinPanel.Name = "roundedSkinPanel";
            this.roundedSkinPanel.Size = new System.Drawing.Size(784, 329);
            this.roundedSkinPanel.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.memoEdit1);
            this.panelControl1.Controls.Add(this.sidePanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(17, 17);
            this.panelControl1.MinimumSize = new System.Drawing.Size(32, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(750, 295);
            this.panelControl1.TabIndex = 1;
            // 
            // memoEdit1
            // 
            this.behaviorManager1.SetBehaviors(this.memoEdit1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(((DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehavior)(DevExpress.Utils.Behaviors.Behavior.Create(typeof(DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehavior), typeof(DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehaviorSource), new object[] {
                        ((object)(800)),
                        ((object)("")),
                        ((object)(this.aiEvents1))})))))});
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.MinimumSize = new System.Drawing.Size(32, 32);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Properties.NullValuePrompt = "Begin typing to display AI-powered suggestions.";
            this.memoEdit1.Size = new System.Drawing.Size(440, 295);
            this.memoEdit1.StyleController = this.layoutControl2;
            this.memoEdit1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.ucDisclaimerPanel1);
            this.layoutControl2.Controls.Add(this.roundedSkinPanel);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(831, 141, 650, 400);
            this.layoutControl2.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(784, 432);
            this.layoutControl2.TabIndex = 6;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // ucDisclaimerPanel1
            // 
            this.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            this.ucDisclaimerPanel1.Size = new System.Drawing.Size(784, 103);
            this.ucDisclaimerPanel1.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRoundedSkinPanel,
            this.lciUcDisclaimerPanel1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 432);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciRoundedSkinPanel
            // 
            this.lciRoundedSkinPanel.Control = this.roundedSkinPanel;
            this.lciRoundedSkinPanel.Location = new System.Drawing.Point(0, 103);
            this.lciRoundedSkinPanel.Name = "lciRoundedSkinPanel";
            this.lciRoundedSkinPanel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciRoundedSkinPanel.Size = new System.Drawing.Size(784, 329);
            this.lciRoundedSkinPanel.TextVisible = false;
            // 
            // lciUcDisclaimerPanel1
            // 
            this.lciUcDisclaimerPanel1.Control = this.ucDisclaimerPanel1;
            this.lciUcDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1";
            this.lciUcDisclaimerPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciUcDisclaimerPanel1.Size = new System.Drawing.Size(784, 103);
            this.lciUcDisclaimerPanel1.TextVisible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(440, 0);
            this.sidePanel1.MaximumSize = new System.Drawing.Size(500, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(300, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(310, 295);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(309, 295);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(309, 295);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(309, 254);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.comboBoxEditUserRole);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(900, 305, 738, 524);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(309, 254);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(16, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(277, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "labelControl1";
            // 
            // comboBoxEditUserRole
            // 
            this.comboBoxEditUserRole.Location = new System.Drawing.Point(16, 35);
            this.comboBoxEditUserRole.Name = "comboBoxEditUserRole";
            this.comboBoxEditUserRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditUserRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditUserRole.Size = new System.Drawing.Size(277, 28);
            this.comboBoxEditUserRole.StyleController = this.layoutControl1;
            this.comboBoxEditUserRole.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(309, 254);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxEditUserRole;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(283, 53);
            this.layoutControlItem2.Text = "User role:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(283, 175);
            this.layoutControlItem1.TextVisible = false;
            // 
            // SmartAutoCompleteModule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl2);
            this.Name = "SmartAutoCompleteModule";
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel)).EndInit();
            this.roundedSkinPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoundedSkinPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditUserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.MemoEdit memoEdit1;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.ComboBoxEdit comboBoxEditUserRole;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem lciRoundedSkinPanel;
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel;
        private AIIntegration.WinForms.AIEvents aiEvents1;
        private XtraEditors.PanelControl panelControl1;
    }
}
