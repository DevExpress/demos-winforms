namespace DevExpress.DentalClinic.View {
    partial class EditNotesView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNotesView));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.notesMemo = new DevExpress.XtraEditors.MemoEdit();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSbSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSbCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNotesMemo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciLabelControl1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.headerPanel = new DevExpress.XtraEditors.SidePanel();
            this.headerTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotesMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.notesMemo);
            this.dataLayoutControl1.Controls.Add(this.sbCancel);
            this.dataLayoutControl1.Controls.Add(this.sbSave);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 33);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(4105, 1160, 1107, 858);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(26, 0);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.FontSizeDelta = 3;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 23);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "labelControl1";
            // 
            // notesMemo
            // 
            this.notesMemo.Location = new System.Drawing.Point(28, 57);
            this.notesMemo.Name = "notesMemo";
            this.notesMemo.Size = new System.Drawing.Size(194, 20);
            this.notesMemo.StyleController = this.dataLayoutControl1;
            this.notesMemo.TabIndex = 26;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(136, 99);
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
            this.sbSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbSave.Location = new System.Drawing.Point(38, 99);
            this.sbSave.MaximumSize = new System.Drawing.Size(86, 30);
            this.sbSave.MinimumSize = new System.Drawing.Size(86, 30);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(86, 30);
            this.sbSave.StyleController = this.dataLayoutControl1;
            this.sbSave.TabIndex = 16;
            this.sbSave.Text = "Save";
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
            this.lciNotesMemo,
            this.emptySpaceItem2,
            this.lciLabelControl1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(26, 26, 10, 30);
            this.layoutControlGroup1.Size = new System.Drawing.Size(250, 161);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciSbSave
            // 
            this.lciSbSave.Control = this.sbSave;
            this.lciSbSave.Location = new System.Drawing.Point(10, 87);
            this.lciSbSave.Name = "lciSbSave";
            this.lciSbSave.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 2);
            this.lciSbSave.Size = new System.Drawing.Size(94, 34);
            this.lciSbSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSbSave.TextVisible = false;
            // 
            // lciSbCancel
            // 
            this.lciSbCancel.Control = this.sbCancel;
            this.lciSbCancel.Location = new System.Drawing.Point(104, 87);
            this.lciSbCancel.Name = "lciSbCancel";
            this.lciSbCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.lciSbCancel.Size = new System.Drawing.Size(94, 34);
            this.lciSbCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciSbCancel.TextVisible = false;
            // 
            // lciNotesMemo
            // 
            this.lciNotesMemo.Control = this.notesMemo;
            this.lciNotesMemo.Location = new System.Drawing.Point(0, 45);
            this.lciNotesMemo.Name = "lciNotesMemo";
            this.lciNotesMemo.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.lciNotesMemo.Size = new System.Drawing.Size(198, 42);
            this.lciNotesMemo.TextSize = new System.Drawing.Size(0, 0);
            this.lciNotesMemo.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 87);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciLabelControl1
            // 
            this.lciLabelControl1.Control = this.labelControl1;
            this.lciLabelControl1.Location = new System.Drawing.Point(0, 0);
            this.lciLabelControl1.Name = "lciLabelControl1";
            this.lciLabelControl1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.lciLabelControl1.Size = new System.Drawing.Size(198, 45);
            this.lciLabelControl1.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelControl1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Controls.Add(this.headerPanel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(30, 22);
            this.panelControl1.TabIndex = 28;
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
            this.headerPanel.Size = new System.Drawing.Size(26, 31);
            this.headerPanel.TabIndex = 28;
            // 
            // headerTextLabel
            // 
            this.headerTextLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.headerTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTextLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTextLabel.Name = "headerTextLabel";
            this.headerTextLabel.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.headerTextLabel.Size = new System.Drawing.Size(0, 30);
            this.headerTextLabel.TabIndex = 3;
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
            this.closeButton.Location = new System.Drawing.Point(-8, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.closeButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closeButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.closeButton.Size = new System.Drawing.Size(34, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.EditNotesViewModel);
            // 
            // EditNotesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelControl1);
            this.Name = "EditNotesView";
            this.Size = new System.Drawing.Size(52, 39);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.dataLayoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotesMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraEditors.MemoEdit notesMemo;
        private XtraEditors.SimpleButton sbCancel;
        private XtraEditors.SimpleButton sbSave;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem lciSbSave;
        private XtraLayout.LayoutControlItem lciSbCancel;
        private XtraLayout.LayoutControlItem lciNotesMemo;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem lciLabelControl1;
        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.SidePanel headerPanel;
        private XtraEditors.LabelControl headerTextLabel;
        private XtraEditors.SimpleButton closeButton;
    }
}
