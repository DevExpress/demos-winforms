namespace DevExpress.ProductsDemo.Win.Controls {
    partial class ucCalendar {
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
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.treeResources = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateNavigator1.DateTime = new System.DateTime(2011, 12, 29, 0, 0, 0, 0);
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 12);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(239, 443);
            this.dateNavigator1.TabIndex = 1;
            // 
            // treeResources
            // 
            this.treeResources.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeResources.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeResources.Location = new System.Drawing.Point(0, 1);
            this.treeResources.Name = "treeResources";
            this.treeResources.OptionsBehavior.Editable = false;
            this.treeResources.OptionsView.ShowCheckBoxes = true;
            this.treeResources.OptionsView.ShowColumns = false;
            this.treeResources.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeResources.OptionsView.ShowHorzLines = false;
            this.treeResources.OptionsView.ShowIndicator = false;
            this.treeResources.OptionsView.ShowVertLines = false;
            this.treeResources.Size = new System.Drawing.Size(239, 10);
            this.treeResources.TabIndex = 0;
            this.treeResources.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeResources_BeforeExpand);
            this.treeResources.BeforeCollapse += new DevExpress.XtraTreeList.BeforeCollapseEventHandler(this.treeResources_BeforeCollapse);
            this.treeResources.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterExpand);
            this.treeResources.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCollapse);
            this.treeResources.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 68;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(239, 1);
            this.panelControl1.TabIndex = 9;
            // 
            // ucCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.treeResources);
            this.Name = "ucCalendar";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.Size = new System.Drawing.Size(240, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraTreeList.TreeList treeResources;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
