namespace DevExpress.XtraLayout.Demos {
    partial class BaseTutorialControl {
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lcTitle = new DevExpress.XtraLayout.LayoutControl();
            this.highlightTabHeadersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.highlightGroupBordersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.snapModeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.showPropertyGridCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.showAdornerLayerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.quickCustomizationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.highlightFocusedItemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.sbCustomize = new DevExpress.XtraEditors.SimpleButton();
            this.allowExpandAnimationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tabTransitionAnimationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cbFiles = new DevExpress.XtraEditors.RadioGroup();
            this.lcMainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.quickCustomizationLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.showPropertyGridLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.snapModeLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCustomizeButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.showAdornerLayerLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.highlightFocusedItemCheckEditLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.allowExpandAnimationLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.allowExpandAnimationLCI1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcItemCombo = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).BeginInit();
            this.lcTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highlightTabHeadersCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightGroupBordersCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTransitionAnimationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEditLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcItemCombo)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.AllowResize = false;
            this.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(1, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 482);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(249, 482);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.lcTitle);
            this.navigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPage1.Size = new System.Drawing.Size(249, 449);
            // 
            // lcTitle
            // 
            this.lcTitle.AllowCustomization = false;
            this.lcTitle.Controls.Add(this.highlightTabHeadersCheckEdit);
            this.lcTitle.Controls.Add(this.highlightGroupBordersCheckEdit);
            this.lcTitle.Controls.Add(this.snapModeCheckEdit);
            this.lcTitle.Controls.Add(this.showPropertyGridCheckEdit);
            this.lcTitle.Controls.Add(this.showAdornerLayerCheckEdit);
            this.lcTitle.Controls.Add(this.quickCustomizationCheckEdit);
            this.lcTitle.Controls.Add(this.highlightFocusedItemCheckEdit);
            this.lcTitle.Controls.Add(this.sbCustomize);
            this.lcTitle.Controls.Add(this.allowExpandAnimationCheckEdit);
            this.lcTitle.Controls.Add(this.tabTransitionAnimationCheckEdit);
            this.lcTitle.Controls.Add(this.cbFiles);
            this.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTitle.Location = new System.Drawing.Point(0, 0);
            this.lcTitle.Name = "lcTitle";
            this.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(623, 480, 785, 589);
            this.lcTitle.OptionsView.UseParentAutoScaleFactor = true;
            this.lcTitle.Root = this.lcMainGroup;
            this.lcTitle.Size = new System.Drawing.Size(249, 449);
            this.lcTitle.TabIndex = 1;
            // 
            // highlightTabHeadersCheckEdit
            // 
            this.highlightTabHeadersCheckEdit.Location = new System.Drawing.Point(12, 138);
            this.highlightTabHeadersCheckEdit.Name = "highlightTabHeadersCheckEdit";
            this.highlightTabHeadersCheckEdit.Properties.Caption = "Highlight Tabs";
            this.highlightTabHeadersCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.highlightTabHeadersCheckEdit.StyleController = this.lcTitle;
            this.highlightTabHeadersCheckEdit.TabIndex = 16;
            this.highlightTabHeadersCheckEdit.CheckedChanged += new System.EventHandler(this.highlightTabHeadersCheckEdit_CheckedChanged);
            // 
            // highlightGroupBordersCheckEdit
            // 
            this.highlightGroupBordersCheckEdit.Location = new System.Drawing.Point(12, 114);
            this.highlightGroupBordersCheckEdit.Name = "highlightGroupBordersCheckEdit";
            this.highlightGroupBordersCheckEdit.Properties.Caption = "Highlight Group Borders";
            this.highlightGroupBordersCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.highlightGroupBordersCheckEdit.StyleController = this.lcTitle;
            this.highlightGroupBordersCheckEdit.TabIndex = 15;
            this.highlightGroupBordersCheckEdit.CheckedChanged += new System.EventHandler(this.highlightGroupBordersCheckEdit_CheckedChanged);
            // 
            // snapModeCheckEdit
            // 
            this.snapModeCheckEdit.EditValue = true;
            this.snapModeCheckEdit.Location = new System.Drawing.Point(12, 366);
            this.snapModeCheckEdit.Name = "snapModeCheckEdit";
            this.snapModeCheckEdit.Properties.Caption = "Snap Customization Form";
            this.snapModeCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.snapModeCheckEdit.StyleController = this.lcTitle;
            this.snapModeCheckEdit.TabIndex = 14;
            this.snapModeCheckEdit.CheckedChanged += new System.EventHandler(this.snapModeCheckEdit_CheckedChanged);
            // 
            // showPropertyGridCheckEdit
            // 
            this.showPropertyGridCheckEdit.EditValue = true;
            this.showPropertyGridCheckEdit.Location = new System.Drawing.Point(12, 342);
            this.showPropertyGridCheckEdit.Name = "showPropertyGridCheckEdit";
            this.showPropertyGridCheckEdit.Properties.Caption = "Show PropertyGrid";
            this.showPropertyGridCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.showPropertyGridCheckEdit.StyleController = this.lcTitle;
            this.showPropertyGridCheckEdit.TabIndex = 13;
            this.showPropertyGridCheckEdit.CheckedChanged += new System.EventHandler(this.showPropertyGridCheckEdit_CheckedChanged);
            // 
            // showAdornerLayerCheckEdit
            // 
            this.showAdornerLayerCheckEdit.Location = new System.Drawing.Point(12, 318);
            this.showAdornerLayerCheckEdit.Name = "showAdornerLayerCheckEdit";
            this.showAdornerLayerCheckEdit.Properties.Caption = "Enable Customization Guides";
            this.showAdornerLayerCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.showAdornerLayerCheckEdit.StyleController = this.lcTitle;
            this.showAdornerLayerCheckEdit.TabIndex = 12;
            this.showAdornerLayerCheckEdit.CheckedChanged += new System.EventHandler(this.showAdornerLayerCheckEdit_CheckedChanged);
            // 
            // quickCustomizationCheckEdit
            // 
            this.quickCustomizationCheckEdit.Location = new System.Drawing.Point(12, 294);
            this.quickCustomizationCheckEdit.Name = "quickCustomizationCheckEdit";
            this.quickCustomizationCheckEdit.Properties.Caption = "Quick Customization Mode";
            this.quickCustomizationCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.quickCustomizationCheckEdit.StyleController = this.lcTitle;
            this.quickCustomizationCheckEdit.TabIndex = 11;
            this.quickCustomizationCheckEdit.CheckedChanged += new System.EventHandler(this.quickCustomizationCheckEdit_CheckedChanged);
            // 
            // highlightFocusedItemCheckEdit
            // 
            this.highlightFocusedItemCheckEdit.Location = new System.Drawing.Point(12, 90);
            this.highlightFocusedItemCheckEdit.Name = "highlightFocusedItemCheckEdit";
            this.highlightFocusedItemCheckEdit.Properties.Caption = "Highlight Focused Item";
            this.highlightFocusedItemCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.highlightFocusedItemCheckEdit.StyleController = this.lcTitle;
            this.highlightFocusedItemCheckEdit.TabIndex = 8;
            this.highlightFocusedItemCheckEdit.CheckedChanged += new System.EventHandler(this.highlightFocusedItemCheckEdit_CheckedChanged);
            // 
            // sbCustomize
            // 
            this.sbCustomize.Location = new System.Drawing.Point(12, 390);
            this.sbCustomize.Name = "sbCustomize";
            this.sbCustomize.Size = new System.Drawing.Size(225, 22);
            this.sbCustomize.StyleController = this.lcTitle;
            this.sbCustomize.TabIndex = 6;
            this.sbCustomize.Text = "Customize Layout";
            this.sbCustomize.Click += new System.EventHandler(this.sbCustomize_Click);
            // 
            // allowExpandAnimationCheckEdit
            // 
            this.allowExpandAnimationCheckEdit.EditValue = true;
            this.allowExpandAnimationCheckEdit.Location = new System.Drawing.Point(12, 204);
            this.allowExpandAnimationCheckEdit.Name = "allowExpandAnimationCheckEdit";
            this.allowExpandAnimationCheckEdit.Properties.Caption = "Allow Group Expand Animation";
            this.allowExpandAnimationCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.allowExpandAnimationCheckEdit.StyleController = this.lcTitle;
            this.allowExpandAnimationCheckEdit.TabIndex = 12;
            this.allowExpandAnimationCheckEdit.CheckedChanged += new System.EventHandler(this.allowExpandAnimationCheckEdit_CheckedChanged);
            // 
            // tabTransitionAnimationCheckEdit
            // 
            this.tabTransitionAnimationCheckEdit.EditValue = true;
            this.tabTransitionAnimationCheckEdit.Location = new System.Drawing.Point(12, 228);
            this.tabTransitionAnimationCheckEdit.Name = "tabTransitionAnimationCheckEdit";
            this.tabTransitionAnimationCheckEdit.Properties.Caption = "Allow Tab Transition Animation";
            this.tabTransitionAnimationCheckEdit.Size = new System.Drawing.Size(225, 20);
            this.tabTransitionAnimationCheckEdit.StyleController = this.lcTitle;
            this.tabTransitionAnimationCheckEdit.TabIndex = 12;
            this.tabTransitionAnimationCheckEdit.CheckedChanged += new System.EventHandler(this.tabTransitionAnimation_CheckedChanged);
            // 
            // cbFiles
            // 
            this.cbFiles.AutoSizeInLayoutControl = true;
            this.cbFiles.EditValue = "";
            this.cbFiles.Location = new System.Drawing.Point(12, 34);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Properties.Columns = 1;
            this.cbFiles.Size = new System.Drawing.Size(225, 10);
            this.cbFiles.StyleController = this.lcTitle;
            this.cbFiles.TabIndex = 3;
            this.cbFiles.EditValueChanged += new System.EventHandler(this.cbFiles_EditValueChanged);
            // 
            // lcMainGroup
            // 
            this.lcMainGroup.CustomizationFormText = "Select json file and restore layout";
            this.lcMainGroup.GroupBordersVisible = false;
            this.lcMainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.lcMainGroup.Name = "Root";
            this.lcMainGroup.OptionsItemText.TextToControlDistance = 5;
            this.lcMainGroup.Size = new System.Drawing.Size(249, 449);
            this.lcMainGroup.Text = "Select json file and restore layout";
            this.lcMainGroup.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 424);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 25);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.quickCustomizationLCI,
            this.showPropertyGridLCI,
            this.snapModeLCI,
            this.lcCustomizeButton,
            this.showAdornerLayerLCI});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 260);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 164);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Customization Mode";
            // 
            // quickCustomizationLCI
            // 
            this.quickCustomizationLCI.Control = this.quickCustomizationCheckEdit;
            this.quickCustomizationLCI.CustomizationFormText = "quickCustomizationLCI";
            this.quickCustomizationLCI.Location = new System.Drawing.Point(0, 0);
            this.quickCustomizationLCI.Name = "quickCustomizationLCI";
            this.quickCustomizationLCI.Size = new System.Drawing.Size(229, 24);
            this.quickCustomizationLCI.TextVisible = false;
            // 
            // showPropertyGridLCI
            // 
            this.showPropertyGridLCI.Control = this.showPropertyGridCheckEdit;
            this.showPropertyGridLCI.Location = new System.Drawing.Point(0, 48);
            this.showPropertyGridLCI.Name = "showPropertyGridLCI";
            this.showPropertyGridLCI.Size = new System.Drawing.Size(229, 24);
            this.showPropertyGridLCI.TextVisible = false;
            // 
            // snapModeLCI
            // 
            this.snapModeLCI.Control = this.snapModeCheckEdit;
            this.snapModeLCI.Location = new System.Drawing.Point(0, 72);
            this.snapModeLCI.Name = "snapModeLCI";
            this.snapModeLCI.Size = new System.Drawing.Size(229, 24);
            this.snapModeLCI.TextVisible = false;
            // 
            // lcCustomizeButton
            // 
            this.lcCustomizeButton.Control = this.sbCustomize;
            this.lcCustomizeButton.CustomizationFormText = "lcCustomizeButton";
            this.lcCustomizeButton.Location = new System.Drawing.Point(0, 96);
            this.lcCustomizeButton.Name = "lcCustomizeButton";
            this.lcCustomizeButton.Size = new System.Drawing.Size(229, 26);
            this.lcCustomizeButton.TextVisible = false;
            // 
            // showAdornerLayerLCI
            // 
            this.showAdornerLayerLCI.Control = this.showAdornerLayerCheckEdit;
            this.showAdornerLayerLCI.Location = new System.Drawing.Point(0, 24);
            this.showAdornerLayerLCI.Name = "showAdornerLayerLCI";
            this.showAdornerLayerLCI.Size = new System.Drawing.Size(229, 24);
            this.showAdornerLayerLCI.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.highlightFocusedItemCheckEditLCI,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 114);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Appearance";
            // 
            // highlightFocusedItemCheckEditLCI
            // 
            this.highlightFocusedItemCheckEditLCI.Control = this.highlightFocusedItemCheckEdit;
            this.highlightFocusedItemCheckEditLCI.CustomizationFormText = "highlightFocusedItemCheckEditLCI";
            this.highlightFocusedItemCheckEditLCI.Location = new System.Drawing.Point(0, 0);
            this.highlightFocusedItemCheckEditLCI.Name = "highlightFocusedItemCheckEditLCI";
            this.highlightFocusedItemCheckEditLCI.Size = new System.Drawing.Size(229, 24);
            this.highlightFocusedItemCheckEditLCI.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.highlightGroupBordersCheckEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.highlightTabHeadersCheckEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.allowExpandAnimationLCI,
            this.allowExpandAnimationLCI1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 170);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup3.Size = new System.Drawing.Size(249, 90);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Animation";
            // 
            // allowExpandAnimationLCI
            // 
            this.allowExpandAnimationLCI.Control = this.allowExpandAnimationCheckEdit;
            this.allowExpandAnimationLCI.Location = new System.Drawing.Point(0, 0);
            this.allowExpandAnimationLCI.Name = "allowExpandAnimationLCI";
            this.allowExpandAnimationLCI.Size = new System.Drawing.Size(229, 24);
            this.allowExpandAnimationLCI.TextVisible = false;
            // 
            // allowExpandAnimationLCI1
            // 
            this.allowExpandAnimationLCI1.Control = this.tabTransitionAnimationCheckEdit;
            this.allowExpandAnimationLCI1.Location = new System.Drawing.Point(0, 24);
            this.allowExpandAnimationLCI1.Name = "allowExpandAnimationLCI1";
            this.allowExpandAnimationLCI1.Size = new System.Drawing.Size(229, 24);
            this.allowExpandAnimationLCI1.Text = "allowTabTransitionAnimationLCI";
            this.allowExpandAnimationLCI1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcItemCombo});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup4.Size = new System.Drawing.Size(249, 56);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Text = "JSON Files";
            // 
            // lcItemCombo
            // 
            this.lcItemCombo.Control = this.cbFiles;
            this.lcItemCombo.CustomizationFormText = "Json files:";
            this.lcItemCombo.Location = new System.Drawing.Point(0, 0);
            this.lcItemCombo.Name = "lcItemCombo";
            this.lcItemCombo.Size = new System.Drawing.Size(229, 14);
            this.lcItemCombo.Text = "Json files:";
            this.lcItemCombo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcItemCombo.TextVisible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(464, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(250, 482);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // BaseTutorialControl
            // 
            this.Controls.Add(this.sidePanel1);
            this.Name = "BaseTutorialControl";
            this.Size = new System.Drawing.Size(714, 482);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).EndInit();
            this.lcTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highlightTabHeadersCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightGroupBordersCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTransitionAnimationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEditLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcItemCombo)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup lcMainGroup;
        private DevExpress.XtraLayout.LayoutControl lcTitle;
        private DevExpress.XtraEditors.SimpleButton sbCustomize;
        private DevExpress.XtraEditors.CheckEdit highlightFocusedItemCheckEdit;
        private System.ComponentModel.IContainer components = null;
        private XtraEditors.CheckEdit quickCustomizationCheckEdit;
        private XtraEditors.CheckEdit showAdornerLayerCheckEdit;
        private LayoutControlItem lcItemCombo;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private XtraEditors.CheckEdit allowExpandAnimationCheckEdit;
        private XtraEditors.CheckEdit showPropertyGridCheckEdit;
        private XtraEditors.CheckEdit snapModeCheckEdit;
        private XtraEditors.CheckEdit tabTransitionAnimationCheckEdit;
        private XtraEditors.SidePanel sidePanel1;
        private EmptySpaceItem emptySpaceItem1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem quickCustomizationLCI;
        private LayoutControlItem showPropertyGridLCI;
        private LayoutControlItem snapModeLCI;
        private LayoutControlItem lcCustomizeButton;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem highlightFocusedItemCheckEditLCI;
        private LayoutControlItem showAdornerLayerLCI;
        private LayoutControlGroup layoutControlGroup3;
        private LayoutControlItem allowExpandAnimationLCI;
        private LayoutControlItem allowExpandAnimationLCI1;
        private LayoutControlGroup layoutControlGroup4;
        private XtraEditors.RadioGroup cbFiles;
        private XtraEditors.CheckEdit highlightGroupBordersCheckEdit;
        private LayoutControlItem layoutControlItem1;
        private XtraEditors.CheckEdit highlightTabHeadersCheckEdit;
        private LayoutControlItem layoutControlItem2;
    }
}
