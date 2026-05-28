namespace DevExpress.DentalClinic.Views.Settings {
    partial class ChangePasswordView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordView));
            this.newPasswordTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.passwordDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.currentPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.confirmPasswordTextEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSbSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSbCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCurrentPasswordTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNewPasswordTextEdit1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciConfirmPasswordTextEdit2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.headerPanel = new DevExpress.XtraEditors.SidePanel();
            this.headerTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrentPasswordTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPasswordTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirmPasswordTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // newPasswordTextEdit1
            // 
            this.newPasswordTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passwordDataBindingSource, "NewPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.newPasswordTextEdit1.EditValue = "";
            this.newPasswordTextEdit1.Location = new System.Drawing.Point(28, 102);
            this.newPasswordTextEdit1.MaximumSize = new System.Drawing.Size(0, 30);
            this.newPasswordTextEdit1.MinimumSize = new System.Drawing.Size(0, 30);
            this.newPasswordTextEdit1.Name = "newPasswordTextEdit1";
            this.newPasswordTextEdit1.Properties.UseSystemPasswordChar = true;
            this.newPasswordTextEdit1.Properties.ValidateOnEnterKey = true;
            this.newPasswordTextEdit1.Size = new System.Drawing.Size(340, 30);
            this.newPasswordTextEdit1.StyleController = this.dataLayoutControl1;
            this.newPasswordTextEdit1.TabIndex = 7;
            // 
            // passwordDataBindingSource
            // 
            this.passwordDataBindingSource.DataSource = typeof(DevExpress.DentalClinic.ViewModels.PasswordData);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.sbCancel);
            this.dataLayoutControl1.Controls.Add(this.sbSave);
            this.dataLayoutControl1.Controls.Add(this.currentPasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.newPasswordTextEdit1);
            this.dataLayoutControl1.Controls.Add(this.confirmPasswordTextEdit2);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 33);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(4105, 1160, 1107, 858);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(396, 315);
            this.dataLayoutControl1.TabIndex = 3;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(282, 253);
            this.sbCancel.MaximumSize = new System.Drawing.Size(86, 30);
            this.sbCancel.MinimumSize = new System.Drawing.Size(86, 30);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(86, 30);
            this.sbCancel.StyleController = this.dataLayoutControl1;
            this.sbCancel.TabIndex = 17;
            this.sbCancel.Text = "Cancel";
            // 
            // sbSave
            // 
            this.sbSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbSave.Appearance.Options.UseBackColor = true;
            this.sbSave.Location = new System.Drawing.Point(184, 253);
            this.sbSave.MaximumSize = new System.Drawing.Size(86, 30);
            this.sbSave.MinimumSize = new System.Drawing.Size(86, 30);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(86, 30);
            this.sbSave.StyleController = this.dataLayoutControl1;
            this.sbSave.TabIndex = 16;
            this.sbSave.Text = "Save";
            // 
            // currentPasswordTextEdit
            // 
            this.currentPasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passwordDataBindingSource, "OldPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.currentPasswordTextEdit.EditValue = "";
            this.currentPasswordTextEdit.Location = new System.Drawing.Point(28, 37);
            this.currentPasswordTextEdit.MaximumSize = new System.Drawing.Size(0, 30);
            this.currentPasswordTextEdit.MinimumSize = new System.Drawing.Size(0, 30);
            this.currentPasswordTextEdit.Name = "currentPasswordTextEdit";
            this.currentPasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.currentPasswordTextEdit.Size = new System.Drawing.Size(340, 30);
            this.currentPasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.currentPasswordTextEdit.TabIndex = 7;
            // 
            // confirmPasswordTextEdit2
            // 
            this.confirmPasswordTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passwordDataBindingSource, "RepeatPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.confirmPasswordTextEdit2.EditValue = "";
            this.confirmPasswordTextEdit2.Location = new System.Drawing.Point(28, 167);
            this.confirmPasswordTextEdit2.MaximumSize = new System.Drawing.Size(0, 30);
            this.confirmPasswordTextEdit2.MinimumSize = new System.Drawing.Size(0, 30);
            this.confirmPasswordTextEdit2.Name = "confirmPasswordTextEdit2";
            this.confirmPasswordTextEdit2.Properties.UseSystemPasswordChar = true;
            this.confirmPasswordTextEdit2.Properties.ValidateOnEnterKey = true;
            this.confirmPasswordTextEdit2.Size = new System.Drawing.Size(340, 30);
            this.confirmPasswordTextEdit2.StyleController = this.dataLayoutControl1;
            this.confirmPasswordTextEdit2.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlGroup1.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSbSave,
            this.lciSbCancel,
            this.emptySpaceItem2,
            this.lciCurrentPasswordTextEdit,
            this.emptySpaceItem1,
            this.lciNewPasswordTextEdit1,
            this.lciConfirmPasswordTextEdit2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(26, 26, 10, 30);
            this.layoutControlGroup1.Size = new System.Drawing.Size(396, 315);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciSbSave
            // 
            this.lciSbSave.Control = this.sbSave;
            this.lciSbSave.Location = new System.Drawing.Point(156, 241);
            this.lciSbSave.Name = "lciSbSave";
            this.lciSbSave.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 2);
            this.lciSbSave.Size = new System.Drawing.Size(94, 34);
            this.lciSbSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSbSave.TextVisible = false;
            // 
            // lciSbCancel
            // 
            this.lciSbCancel.Control = this.sbCancel;
            this.lciSbCancel.Location = new System.Drawing.Point(250, 241);
            this.lciSbCancel.Name = "lciSbCancel";
            this.lciSbCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.lciSbCancel.Size = new System.Drawing.Size(94, 34);
            this.lciSbCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciSbCancel.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 241);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(156, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCurrentPasswordTextEdit
            // 
            this.lciCurrentPasswordTextEdit.Control = this.currentPasswordTextEdit;
            this.lciCurrentPasswordTextEdit.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciCurrentPasswordTextEdit.CustomizationFormText = "Email";
            this.lciCurrentPasswordTextEdit.Location = new System.Drawing.Point(0, 0);
            this.lciCurrentPasswordTextEdit.Name = "lciCurrentPasswordTextEdit";
            this.lciCurrentPasswordTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8);
            this.lciCurrentPasswordTextEdit.Size = new System.Drawing.Size(344, 65);
            this.lciCurrentPasswordTextEdit.Text = "Current Password";
            this.lciCurrentPasswordTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCurrentPasswordTextEdit.TextSize = new System.Drawing.Size(112, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 195);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(344, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNewPasswordTextEdit1
            // 
            this.lciNewPasswordTextEdit1.Control = this.newPasswordTextEdit1;
            this.lciNewPasswordTextEdit1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciNewPasswordTextEdit1.CustomizationFormText = "Email";
            this.lciNewPasswordTextEdit1.Location = new System.Drawing.Point(0, 65);
            this.lciNewPasswordTextEdit1.Name = "lciNewPasswordTextEdit1";
            this.lciNewPasswordTextEdit1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8);
            this.lciNewPasswordTextEdit1.Size = new System.Drawing.Size(344, 65);
            this.lciNewPasswordTextEdit1.Text = "New Password";
            this.lciNewPasswordTextEdit1.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNewPasswordTextEdit1.TextSize = new System.Drawing.Size(112, 17);
            // 
            // lciConfirmPasswordTextEdit2
            // 
            this.lciConfirmPasswordTextEdit2.Control = this.confirmPasswordTextEdit2;
            this.lciConfirmPasswordTextEdit2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciConfirmPasswordTextEdit2.CustomizationFormText = "Email";
            this.lciConfirmPasswordTextEdit2.Location = new System.Drawing.Point(0, 130);
            this.lciConfirmPasswordTextEdit2.Name = "lciConfirmPasswordTextEdit2";
            this.lciConfirmPasswordTextEdit2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8);
            this.lciConfirmPasswordTextEdit2.Size = new System.Drawing.Size(344, 65);
            this.lciConfirmPasswordTextEdit2.Text = "Confirm Password";
            this.lciConfirmPasswordTextEdit2.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciConfirmPasswordTextEdit2.TextSize = new System.Drawing.Size(112, 17);
            // 
            // panelControl1
            // 
            this.panelControl1.CausesValidation = false;
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Controls.Add(this.headerPanel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 350);
            this.panelControl1.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.AllowResize = false;
            this.headerPanel.Controls.Add(this.headerTextLabel);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(2, 2);
            this.headerPanel.MaximumSize = new System.Drawing.Size(0, 31);
            this.headerPanel.MinimumSize = new System.Drawing.Size(0, 31);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(396, 31);
            this.headerPanel.TabIndex = 19;
            // 
            // headerTextLabel
            // 
            this.headerTextLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.headerTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTextLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTextLabel.Name = "headerTextLabel";
            this.headerTextLabel.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.headerTextLabel.Size = new System.Drawing.Size(362, 30);
            this.headerTextLabel.TabIndex = 3;
            this.headerTextLabel.Text = "Change Password";
            // 
            // closeButton
            // 
            this.closeButton.AllowFocus = false;
            this.closeButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.closeButton.Appearance.Options.UseBackColor = true;
            this.closeButton.AutoSize = true;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.closeButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("closeButton.ImageOptions.SvgImage")));
            this.closeButton.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.closeButton.Location = new System.Drawing.Point(362, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.closeButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closeButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.closeButton.Size = new System.Drawing.Size(34, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            this.dxErrorProvider.DataSource = this.passwordDataBindingSource;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DentalClinic.ViewModels.ChangePasswordViewModel);
            // 
            // ChangePasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.panelControl1);
            this.Name = "ChangePasswordView";
            this.Size = new System.Drawing.Size(400, 350);
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCurrentPasswordTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPasswordTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirmPasswordTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panelControl1;
        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraEditors.SimpleButton sbCancel;
        private XtraEditors.SimpleButton sbSave;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem lciSbSave;
        private XtraLayout.LayoutControlItem lciSbCancel;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.TextEdit currentPasswordTextEdit;
        private XtraLayout.LayoutControlItem lciCurrentPasswordTextEdit;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.TextEdit newPasswordTextEdit1;
        private XtraEditors.TextEdit confirmPasswordTextEdit2;
        private XtraLayout.LayoutControlItem lciNewPasswordTextEdit1;
        private XtraLayout.LayoutControlItem lciConfirmPasswordTextEdit2;
        private Utils.MVVM.MVVMContext mvvmContext;
        private System.Windows.Forms.BindingSource passwordDataBindingSource;
        private XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private XtraEditors.SidePanel headerPanel;
        private XtraEditors.LabelControl headerTextLabel;
        private XtraEditors.SimpleButton closeButton;
    }
}
