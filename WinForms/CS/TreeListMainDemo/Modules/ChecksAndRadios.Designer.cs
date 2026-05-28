namespace DevExpress.XtraTreeList.Demos {
    partial class ChecksAndRadios {
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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.optionsPanel = new DevExpress.XtraEditors.SidePanel();
            this.ucCheckBoxOptions1 = new DevExpress.XtraTreeList.Demos.Options.ucCheckBoxOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Location = new System.Drawing.Point(39, 2);
            this.treeList.MaximumSize = new System.Drawing.Size(380, 0);
            this.treeList.MinimumSize = new System.Drawing.Size(380, 0);
            this.treeList.Name = "treeList";
            this.treeList.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.treeList.Size = new System.Drawing.Size(380, 428);
            this.treeList.TabIndex = 0;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.ucCheckBoxOptions1);
            this.optionsPanel.Controls.Add(this.labelControl1);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionsPanel.Location = new System.Drawing.Point(459, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(420, 432);
            this.optionsPanel.TabIndex = 1;
            this.optionsPanel.Text = "sidePanel";
            // 
            // ucCheckBoxOptions1
            // 
            this.ucCheckBoxOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCheckBoxOptions1.Location = new System.Drawing.Point(1, 0);
            this.ucCheckBoxOptions1.Name = "ucCheckBoxOptions1";
            this.ucCheckBoxOptions1.Size = new System.Drawing.Size(419, 432);
            this.ucCheckBoxOptions1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(1, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(419, 432);
            this.labelControl1.TabIndex = 0;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.treeList);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(459, 432);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.Root.Size = new System.Drawing.Size(459, 432);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem
            // 
            this.layoutControlItem.Control = this.treeList;
            this.layoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem.Name = "layoutControlItem";
            this.layoutControlItem.Size = new System.Drawing.Size(459, 432);
            this.layoutControlItem.TextVisible = false;
            this.layoutControlItem.TrimClientAreaToControl = false;
            // 
            // ChecksAndRadios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.optionsPanel);
            this.Name = "ChecksAndRadios";
            this.Size = new System.Drawing.Size(879, 432);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeList treeList;
        private XtraEditors.SidePanel optionsPanel;
        private XtraEditors.LabelControl labelControl1;
        private Options.ucCheckBoxOptions ucCheckBoxOptions1;
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem;
    }
}
