namespace DevExpress.XtraTreeMap.Demos {
    partial class HierarchicalData {
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
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter treeMapHierarchicalDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter();
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping treeMapHierarchicalDataMapping1 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping();
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping treeMapHierarchicalDataMapping2 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping();
            DevExpress.XtraTreeMap.Title title1 = new DevExpress.XtraTreeMap.Title();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.treeMapControl1.BorderOptions.Thickness = 2;
            this.treeMapControl1.BorderOptions.Visible = false;
            treeMapHierarchicalDataMapping1.ChildrenDataMember = "EnergyStatistic";
            treeMapHierarchicalDataMapping1.LabelDataMember = "Country";
            treeMapHierarchicalDataMapping2.LabelDataMember = "TypeName";
            treeMapHierarchicalDataMapping2.ValueDataMember = "Value";
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping1);
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping2);
            this.treeMapControl1.DataAdapter = treeMapHierarchicalDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(0, 0);
            this.treeMapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.treeMapControl1.Size = new System.Drawing.Size(731, 512);
            this.treeMapControl1.TabIndex = 1;
            title1.Indent = 0;
            title1.Text = "Energy Consumption in 2004 (millions of tons, oil equivalent)";
            this.treeMapControl1.Titles.Add(title1);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.treeMapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 10);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(731, 512);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(731, 512);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(731, 512);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // HierarchicalData
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Name = "HierarchicalData";
            this.Size = new System.Drawing.Size(731, 522);
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private TreeMapControl treeMapControl1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        
    }
}
