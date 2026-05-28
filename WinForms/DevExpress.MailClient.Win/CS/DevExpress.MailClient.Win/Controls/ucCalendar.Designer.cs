namespace DevExpress.MailClient.Win.Controls {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCalendar));
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.treeResources = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateNavigator1.CalendarIndent = 0;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateNavigator1.CalendarTimeProperties.Buttons"))))});
            this.dateNavigator1.CellPadding = new System.Windows.Forms.Padding(-2, -1, -2, -2);
            this.dateNavigator1.DateTime = new System.DateTime(2011, 12, 29, 0, 0, 0, 0);
            resources.ApplyResources(this.dateNavigator1, "dateNavigator1");
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Name = "dateNavigator1";
            // 
            // treeResources
            // 
            this.treeResources.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeResources.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            resources.ApplyResources(this.treeResources, "treeResources");
            this.treeResources.Name = "treeResources";
            this.treeResources.OptionsBehavior.Editable = false;
            this.treeResources.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeResources.OptionsView.ShowCheckBoxes = true;
            this.treeResources.OptionsView.ShowColumns = false;
            this.treeResources.OptionsView.ShowHorzLines = false;
            this.treeResources.OptionsView.ShowIndicator = false;
            this.treeResources.OptionsView.ShowVertLines = false;
            this.treeResources.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeResources_BeforeExpand);
            this.treeResources.BeforeCollapse += new DevExpress.XtraTreeList.BeforeCollapseEventHandler(this.treeResources_BeforeCollapse);
            this.treeResources.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterExpand);
            this.treeResources.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCollapse);
            this.treeResources.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "Name";
            resources.ApplyResources(this.treeListColumn1, "treeListColumn1");
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // ucCalendar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.treeResources);
            this.Name = "ucCalendar";
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
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
