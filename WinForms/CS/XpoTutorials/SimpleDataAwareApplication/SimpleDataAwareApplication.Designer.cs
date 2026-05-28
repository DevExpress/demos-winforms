namespace DevExpress.Xpo.Demos {
    partial class SimpleDataAwareApplication {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        private void InitializeComponent() {
            this.xpCustomers = new DevExpress.Xpo.XPCollection();
            this.gControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCustomers
            // 
            this.xpCustomers.DisplayableProperties = "This;Oid;Name;Age";
            this.xpCustomers.ObjectType = typeof(DevExpress.Xpo.Demos.Customer);
            // 
            // gControl1
            // 
            this.gControl1.DataSource = this.xpCustomers;
            this.gControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl1.Location = new System.Drawing.Point(0, 0);
            this.gControl1.MainView = this.gridView1;
            this.gControl1.Name = "gControl1";
            this.gControl1.Size = new System.Drawing.Size(414, 342);
            this.gControl1.TabIndex = 0;
            this.gControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colName,
            this.colAge});
            this.gridView1.GridControl = this.gControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colOid
            // 
            this.colOid.Caption = "Oid";
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.OptionsColumn.AllowEdit = false;
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            this.colOid.Width = 55;
            // 
            // colName
            // 
            this.colName.Caption = "Customer Name";
            this.colName.FieldName = "Name";
            this.colName.ImageIndex = 0;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 229;
            // 
            // colAge
            // 
            this.colAge.Caption = "Age";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 2;
            this.colAge.Width = 111;
            // 
            // SimpleDataAwareApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gControl1);
            this.Name = "SimpleDataAwareApplication";
            this.Size = new System.Drawing.Size(414, 342);
            //this.TutorialInfo.AboutFile = null;
            //this.TutorialInfo.Description = null;
            //this.TutorialInfo.TutorialName = null;
            //this.TutorialInfo.WhatsThisCodeFile = null;
            //this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.SimpleDataAwareApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection xpCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.GridControl gControl1;
        private System.ComponentModel.IContainer components = null;

    }
}
