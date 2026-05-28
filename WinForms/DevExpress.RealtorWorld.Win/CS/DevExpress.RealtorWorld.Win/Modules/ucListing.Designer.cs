namespace DevExpress.RealtorWorld.Win {
    partial class ucListing {
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
            this.pnlList = new DevExpress.XtraEditors.TileControl();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.ucHomeDetail1 = new DevExpress.RealtorWorld.Win.ucHomeDetail();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.AllowHtmlText = DevExpress.Utils.DefaultBoolean.Default;
            this.pnlList.AllowItemHover = true;
            this.pnlList.AllowSelectedItem = true;
            this.pnlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlList.IndentBetweenItems = 6;
            this.pnlList.ItemPadding = new System.Windows.Forms.Padding(3);
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pnlList.Padding = new System.Windows.Forms.Padding(6);
            this.pnlList.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar;
            this.pnlList.Size = new System.Drawing.Size(226, 678);
            this.pnlList.TabIndex = 2;
            this.pnlList.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.pnlList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.pnlList_ItemClick);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDetail.Controls.Add(this.ucHomeDetail1);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(226, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1051, 678);
            this.pnlDetail.TabIndex = 1;
            // 
            // ucHomeDetail1
            // 
            this.ucHomeDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomeDetail1.FullLayout = true;
            this.ucHomeDetail1.Location = new System.Drawing.Point(0, 0);
            this.ucHomeDetail1.Name = "ucHomeDetail1";
            this.ucHomeDetail1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ucHomeDetail1.Size = new System.Drawing.Size(1051, 678);
            this.ucHomeDetail1.TabIndex = 0;
            // 
            // ucListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlList);
            this.Name = "ucListing";
            this.Size = new System.Drawing.Size(1277, 678);
            this.Tag = "";
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl pnlList;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private ucHomeDetail ucHomeDetail1;
    }
}
