namespace DevExpress.XtraBars.Demos.BrowserDemo {
    partial class ctrlFavorites {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFavorites));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.iAdd = new DevExpress.XtraBars.BarButtonItem();
            this.iEdit = new DevExpress.XtraBars.BarButtonItem();
            this.iDelete = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.listBox1 = new DevExpress.XtraEditors.ListBoxControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.iAdd,
            this.iEdit,
            this.iDelete,
            this.iOpen});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Edit";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(43, 86);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.iEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen, true)});
            this.bar1.Text = "Edit";
            // 
            // iAdd
            // 
            this.iAdd.Caption = "&Add";
            this.iAdd.Hint = "Add Favorite";
            this.iAdd.Id = 0;
            this.iAdd.ImageOptions.ImageIndex = 0;
            this.iAdd.Name = "iAdd";
            this.iAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAdd_ItemClick);
            // 
            // iEdit
            // 
            this.iEdit.Caption = "&Edit";
            this.iEdit.Hint = "Edit Favorite";
            this.iEdit.Id = 1;
            this.iEdit.ImageOptions.ImageIndex = 1;
            this.iEdit.Name = "iEdit";
            this.iEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iEdit_ItemClick);
            // 
            // iDelete
            // 
            this.iDelete.Caption = "&Delete";
            this.iDelete.Hint = "Delete Favorite";
            this.iDelete.Id = 2;
            this.iDelete.ImageOptions.ImageIndex = 2;
            this.iDelete.Name = "iDelete";
            this.iDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDelete_ItemClick);
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.Hint = "Open Favorite";
            this.iOpen.Id = 3;
            this.iOpen.ImageOptions.ImageIndex = 3;
            this.iOpen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.iOpen.Name = "iOpen";
            this.iOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpen_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(196, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 248);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(196, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 224);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(196, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 224);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 224);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "insert_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "edit_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "deletelist2_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "article_16x16.png");
            // 
            // ctrlFavorites
            // 
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "ctrlFavorites";
            this.Size = new System.Drawing.Size(196, 248);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem iAdd;
        private DevExpress.XtraBars.BarButtonItem iEdit;
        private DevExpress.XtraBars.BarButtonItem iDelete;
        private DevExpress.XtraEditors.ListBoxControl listBox1;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.Bar bar1;
        private System.ComponentModel.IContainer components;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
