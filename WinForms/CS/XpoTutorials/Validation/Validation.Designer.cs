namespace DevExpress.Xpo.Demos {
    partial class Validation {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            this.xpContacts = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbRemoveContact = new DevExpress.XtraEditors.SimpleButton();
            this.icButtonImages = new DevExpress.Utils.ImageCollection(this.components);
            this.sbAddContact = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xpContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icButtonImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // xpContacts
            // 
            this.xpContacts.DisplayableProperties = "This;Oid;FirstName;LastName;Address;PhoneNumber;Email";
            this.xpContacts.ObjectType = typeof(DevExpress.Xpo.Demos.Contact);
            this.xpContacts.Session = this.unitOfWork1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(563, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bSave);
            this.panelControl1.Controls.Add(this.sbRemoveContact);
            this.panelControl1.Controls.Add(this.sbAddContact);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(563, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bSave.Location = new System.Drawing.Point(523, 8);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(32, 23);
            this.bSave.TabIndex = 11;
            this.bSave.ToolTip = "Save Changes to Database";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // sbRemoveContact
            // 
            this.sbRemoveContact.ImageIndex = 1;
            this.sbRemoveContact.ImageList = this.icButtonImages;
            this.sbRemoveContact.Location = new System.Drawing.Point(120, 8);
            this.sbRemoveContact.Name = "sbRemoveContact";
            this.sbRemoveContact.Size = new System.Drawing.Size(120, 23);
            this.sbRemoveContact.TabIndex = 1;
            this.sbRemoveContact.Text = "Remove Contact";
            this.sbRemoveContact.Click += new System.EventHandler(this.sbRemoveContact_Click);
            // 
            // icButtonImages
            // 
            this.icButtonImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icButtonImages.ImageStream")));
            // 
            // sbAddContact
            // 
            this.sbAddContact.ImageIndex = 0;
            this.sbAddContact.ImageList = this.icButtonImages;
            this.sbAddContact.Location = new System.Drawing.Point(8, 8);
            this.sbAddContact.Name = "sbAddContact";
            this.sbAddContact.Size = new System.Drawing.Size(104, 23);
            this.sbAddContact.TabIndex = 0;
            this.sbAddContact.Text = "Add Contact";
            this.sbAddContact.Click += new System.EventHandler(this.sbAddContact_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(563, 8);
            this.panelControl2.TabIndex = 5;
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Validation";
            this.Size = new System.Drawing.Size(563, 266);
            //this.TutorialInfo.AboutFile = null;
            //this.TutorialInfo.Description = null;
            //this.TutorialInfo.TutorialName = null;
            //this.TutorialInfo.WhatsThisCodeFile = null;
            //this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.Validation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icButtonImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection xpContacts;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton sbAddContact;
        private DevExpress.XtraEditors.SimpleButton sbRemoveContact;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraEditors.SimpleButton bSave;
        private DevExpress.Utils.ImageCollection icButtonImages;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl2;

    }
}
