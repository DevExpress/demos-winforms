namespace DevExpress.DentalClinic.Views.Patients {
    partial class ToothFlyoutView {
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.openedProceduresHeaderLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.completedProceduresHeaderLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.completedProceduresLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.openedProceduresLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.titleLabel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedProceduresHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedProceduresHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedProceduresLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedProceduresLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AutoScroll = false;
            this.dataLayoutControl1.AutoSize = true;
            this.dataLayoutControl1.Controls.Add(this.labelControl3);
            this.dataLayoutControl1.Controls.Add(this.labelControl2);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.DataMember = null;
            this.dataLayoutControl1.DataSource = this.bindingSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(851, 187, 758, 822);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(160, 108);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(61, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 17);
            this.labelControl3.StyleController = this.dataLayoutControl1;
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tooth";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 17);
            this.labelControl2.StyleController = this.dataLayoutControl1;
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(12, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 17);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "labelControl1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DevExpress.DentalClinic.Views.Patients.ToothInfo";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleSeparator1,
            this.openedProceduresHeaderLabel,
            this.completedProceduresHeaderLabel,
            this.completedProceduresLabel,
            this.openedProceduresLabel,
            this.titleLabel});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(160, 108);
            this.Root.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 21);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(160, 1);
            this.simpleSeparator1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            // 
            // openedProceduresHeaderLabel
            // 
            this.openedProceduresHeaderLabel.AllowHotTrack = false;
            this.openedProceduresHeaderLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.openedProceduresHeaderLabel.AppearanceItemCaption.Options.UseFont = true;
            this.openedProceduresHeaderLabel.CustomizationFormText = "Planned Procedures";
            this.openedProceduresHeaderLabel.Location = new System.Drawing.Point(0, 22);
            this.openedProceduresHeaderLabel.MaxSize = new System.Drawing.Size(0, 21);
            this.openedProceduresHeaderLabel.MinSize = new System.Drawing.Size(160, 21);
            this.openedProceduresHeaderLabel.Name = "openedProceduresHeaderLabel";
            this.openedProceduresHeaderLabel.Size = new System.Drawing.Size(160, 21);
            this.openedProceduresHeaderLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.openedProceduresHeaderLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.openedProceduresHeaderLabel.Text = "Planned Procedures";
            this.openedProceduresHeaderLabel.TextSize = new System.Drawing.Size(139, 17);
            // 
            // completedProceduresHeaderLabel
            // 
            this.completedProceduresHeaderLabel.AllowHotTrack = false;
            this.completedProceduresHeaderLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.completedProceduresHeaderLabel.AppearanceItemCaption.Options.UseFont = true;
            this.completedProceduresHeaderLabel.CustomizationFormText = "Completed Procedures";
            this.completedProceduresHeaderLabel.Location = new System.Drawing.Point(0, 64);
            this.completedProceduresHeaderLabel.MaxSize = new System.Drawing.Size(0, 21);
            this.completedProceduresHeaderLabel.MinSize = new System.Drawing.Size(160, 21);
            this.completedProceduresHeaderLabel.Name = "completedProceduresHeaderLabel";
            this.completedProceduresHeaderLabel.Size = new System.Drawing.Size(160, 21);
            this.completedProceduresHeaderLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.completedProceduresHeaderLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.completedProceduresHeaderLabel.Text = "Completed Procedures";
            this.completedProceduresHeaderLabel.TextSize = new System.Drawing.Size(139, 17);
            // 
            // completedProceduresLabel
            // 
            this.completedProceduresLabel.Control = this.labelControl1;
            this.completedProceduresLabel.Location = new System.Drawing.Point(0, 85);
            this.completedProceduresLabel.Name = "completedProceduresLabel";
            this.completedProceduresLabel.Size = new System.Drawing.Size(160, 23);
            this.completedProceduresLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 2);
            this.completedProceduresLabel.TextSize = new System.Drawing.Size(0, 0);
            this.completedProceduresLabel.TextVisible = false;
            // 
            // openedProceduresLabel
            // 
            this.openedProceduresLabel.Control = this.labelControl2;
            this.openedProceduresLabel.Location = new System.Drawing.Point(0, 43);
            this.openedProceduresLabel.Name = "openedProceduresLabel";
            this.openedProceduresLabel.Size = new System.Drawing.Size(160, 21);
            this.openedProceduresLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.openedProceduresLabel.TextSize = new System.Drawing.Size(0, 0);
            this.openedProceduresLabel.TextVisible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleLabel.Control = this.labelControl3;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 21);
            this.titleLabel.TextSize = new System.Drawing.Size(0, 0);
            this.titleLabel.TextVisible = false;
            // 
            // ToothFlyoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ToothFlyoutView";
            this.Size = new System.Drawing.Size(160, 108);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedProceduresHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedProceduresHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedProceduresLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedProceduresLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bindingSource1;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraLayout.SimpleLabelItem openedProceduresHeaderLabel;
        private XtraLayout.SimpleLabelItem completedProceduresHeaderLabel;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem completedProceduresLabel;
        private XtraLayout.LayoutControlItem openedProceduresLabel;
        private XtraEditors.LabelControl labelControl3;
        private XtraLayout.LayoutControlItem titleLabel;
    }
}
