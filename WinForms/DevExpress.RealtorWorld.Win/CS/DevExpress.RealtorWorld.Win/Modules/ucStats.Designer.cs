namespace DevExpress.RealtorWorld.Win {
    partial class ucStats {
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
            this.ucStatistics1 = new DevExpress.RealtorWorld.Win.ucStatistics();
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
            this.pnlList.Size = new System.Drawing.Size(226, 640);
            this.pnlList.TabIndex = 3;
            this.pnlList.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.pnlList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.pnlList_ItemClick_1);
            // 
            // ucStatistics1
            // 
            this.ucStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatistics1.Location = new System.Drawing.Point(226, 0);
            this.ucStatistics1.Name = "ucStatistics1";
            this.ucStatistics1.Size = new System.Drawing.Size(1041, 640);
            this.ucStatistics1.TabIndex = 4;
            // 
            // ucStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucStatistics1);
            this.Controls.Add(this.pnlList);
            this.Name = "ucStats";
            this.Size = new System.Drawing.Size(1267, 640);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl pnlList;
        private ucStatistics ucStatistics1;
    }
}
