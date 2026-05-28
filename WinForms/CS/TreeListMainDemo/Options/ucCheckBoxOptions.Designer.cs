namespace DevExpress.XtraTreeList.Demos.Options {
    partial class ucCheckBoxOptions {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.ceAllowRecursiveNodeChecking = new DevExpress.XtraEditors.CheckEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.imbShowCheckBoxes = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lgPreview = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liShowCheckBoxes = new DevExpress.XtraLayout.LayoutControlItem();
            this.liAllowRecursiveNodeChecking = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRecursiveNodeChecking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbShowCheckBoxes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowCheckBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowRecursiveNodeChecking)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.ceAllowRecursiveNodeChecking);
            this.layoutControl.Controls.Add(this.treeList1);
            this.layoutControl.Controls.Add(this.imbShowCheckBoxes);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 596, 696);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(418, 342);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // ceAllowRecursiveNodeChecking
            // 
            this.ceAllowRecursiveNodeChecking.Location = new System.Drawing.Point(12, 34);
            this.ceAllowRecursiveNodeChecking.Name = "ceAllowRecursiveNodeChecking";
            this.ceAllowRecursiveNodeChecking.Properties.Caption = "Allow Recursive Node Checking";
            this.ceAllowRecursiveNodeChecking.Size = new System.Drawing.Size(394, 20);
            this.ceAllowRecursiveNodeChecking.StyleController = this.layoutControl;
            this.ceAllowRecursiveNodeChecking.TabIndex = 14;
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList1.Appearance.Empty.Options.UseBackColor = true;
            this.treeList1.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.treeList1.Appearance.Row.Options.UseBackColor = true;
            this.treeList1.Location = new System.Drawing.Point(19, 124);
            this.treeList1.MaximumSize = new System.Drawing.Size(380, 0);
            this.treeList1.MinimumSize = new System.Drawing.Size(380, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsBehavior.ReadOnly = true;
            this.treeList1.OptionsCustomization.AllowFilter = false;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeList1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.treeList1.Size = new System.Drawing.Size(380, 206);
            this.treeList1.TabIndex = 4;
            this.treeList1.TreeViewFieldName = "Name";
            // 
            // imbShowCheckBoxes
            // 
            this.imbShowCheckBoxes.Location = new System.Drawing.Point(115, 58);
            this.imbShowCheckBoxes.Name = "imbShowCheckBoxes";
            this.imbShowCheckBoxes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imbShowCheckBoxes.Properties.DropDownRows = 25;
            this.imbShowCheckBoxes.Size = new System.Drawing.Size(291, 20);
            this.imbShowCheckBoxes.StyleController = this.layoutControl;
            this.imbShowCheckBoxes.TabIndex = 2;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lgPreview,
            this.lgOptions});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(418, 342);
            this.layoutControlGroup.TextVisible = false;
            // 
            // lgPreview
            // 
            this.lgPreview.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lgPreview.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgPreview.Location = new System.Drawing.Point(0, 90);
            this.lgPreview.Name = "lgPreview";
            this.lgPreview.Size = new System.Drawing.Size(418, 252);
            this.lgPreview.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgPreview.Text = "Preview";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeList1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(398, 210);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // lgOptions
            // 
            this.lgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lgOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liShowCheckBoxes,
            this.liAllowRecursiveNodeChecking});
            this.lgOptions.Location = new System.Drawing.Point(0, 0);
            this.lgOptions.Name = "lgOptions";
            this.lgOptions.Size = new System.Drawing.Size(418, 90);
            this.lgOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgOptions.Text = "Options";
            // 
            // liShowCheckBoxes
            // 
            this.liShowCheckBoxes.Control = this.imbShowCheckBoxes;
            this.liShowCheckBoxes.CustomizationFormText = "liShowCheckBoxes";
            this.liShowCheckBoxes.Location = new System.Drawing.Point(0, 24);
            this.liShowCheckBoxes.Name = "liShowCheckBoxes";
            this.liShowCheckBoxes.Size = new System.Drawing.Size(398, 24);
            this.liShowCheckBoxes.Text = "Show CheckBoxes:";
            this.liShowCheckBoxes.TextSize = new System.Drawing.Size(91, 13);
            // 
            // liAllowRecursiveNodeChecking
            // 
            this.liAllowRecursiveNodeChecking.Control = this.ceAllowRecursiveNodeChecking;
            this.liAllowRecursiveNodeChecking.Location = new System.Drawing.Point(0, 0);
            this.liAllowRecursiveNodeChecking.Name = "liAllowRecursiveNodeChecking";
            this.liAllowRecursiveNodeChecking.Size = new System.Drawing.Size(398, 24);
            this.liAllowRecursiveNodeChecking.Text = "lAllowRecursiveNodeChecking";
            this.liAllowRecursiveNodeChecking.TextVisible = false;
            // 
            // ucCheckBoxOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ucCheckBoxOptions";
            this.Size = new System.Drawing.Size(418, 342);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRecursiveNodeChecking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbShowCheckBoxes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowCheckBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowRecursiveNodeChecking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private TreeList treeList1;
        private XtraEditors.ImageComboBoxEdit imbShowCheckBoxes;
        private XtraLayout.LayoutControlItem liShowCheckBoxes;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup lgPreview;
        private XtraLayout.LayoutControlGroup lgOptions;
        private XtraEditors.CheckEdit ceAllowRecursiveNodeChecking;
        private XtraLayout.LayoutControlItem liAllowRecursiveNodeChecking;
    }
}
