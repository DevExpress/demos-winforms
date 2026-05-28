namespace DevExpress.Xpo.Demos {
    partial class AsyncLoadingTaskBased {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbLoadingPersons = new DevExpress.XtraEditors.LabelControl();
            this.gclPersons = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbLoadingProducts = new DevExpress.XtraEditors.LabelControl();
            this.gclProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbCommit = new DevExpress.XtraEditors.SimpleButton();
            this.sbLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.lbCommit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lbLoadingPersons);
            this.splitContainerControl1.Panel1.Controls.Add(this.gclPersons);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.lbLoadingProducts);
            this.splitContainerControl1.Panel2.Controls.Add(this.gclProducts);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(782, 475);
            this.splitContainerControl1.SplitterPosition = 261;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.splitContainerControl1.Resize += new System.EventHandler(this.splitContainerControl1_Resize);
            // 
            // lbLoadingPersons
            // 
            this.lbLoadingPersons.Appearance.Options.UseTextOptions = true;
            this.lbLoadingPersons.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbLoadingPersons.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbLoadingPersons.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbLoadingPersons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbLoadingPersons.Location = new System.Drawing.Point(72, 205);
            this.lbLoadingPersons.Name = "lbLoadingPersons";
            this.lbLoadingPersons.Size = new System.Drawing.Size(209, 94);
            this.lbLoadingPersons.TabIndex = 3;
            this.lbLoadingPersons.Text = "Loading...";
            this.lbLoadingPersons.Visible = false;
            // 
            // gclPersons
            // 
            this.gclPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPersons.Location = new System.Drawing.Point(0, 0);
            this.gclPersons.MainView = this.gridView4;
            this.gclPersons.Name = "gclPersons";
            this.gclPersons.Size = new System.Drawing.Size(261, 475);
            this.gclPersons.TabIndex = 1;
            this.gclPersons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gclPersons.Resize += new System.EventHandler(this.gclPersons_Resize);
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 268;
            this.gridView4.GridControl = this.gclPersons;
            this.gridView4.Name = "gridView4";
            // 
            // lbLoadingProducts
            // 
            this.lbLoadingProducts.Appearance.Options.UseTextOptions = true;
            this.lbLoadingProducts.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbLoadingProducts.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbLoadingProducts.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbLoadingProducts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbLoadingProducts.Location = new System.Drawing.Point(106, 205);
            this.lbLoadingProducts.Name = "lbLoadingProducts";
            this.lbLoadingProducts.Size = new System.Drawing.Size(209, 94);
            this.lbLoadingProducts.TabIndex = 4;
            this.lbLoadingProducts.Text = "Loading...";
            this.lbLoadingProducts.Visible = false;
            // 
            // gclProducts
            // 
            this.gclProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclProducts.Location = new System.Drawing.Point(0, 0);
            this.gclProducts.MainView = this.gridView5;
            this.gclProducts.Name = "gclProducts";
            this.gclProducts.Size = new System.Drawing.Size(511, 475);
            this.gclProducts.TabIndex = 2;
            this.gclProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gclProducts.Resize += new System.EventHandler(this.gclProducts_Resize);
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 268;
            this.gridView5.GridControl = this.gclProducts;
            this.gridView5.Name = "gridView5";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.sbCommit);
            this.panelControl3.Controls.Add(this.sbLoadData);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 475);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(782, 35);
            this.panelControl3.TabIndex = 3;
            // 
            // sbCommit
            // 
            this.sbCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCommit.Enabled = false;
            this.sbCommit.Location = new System.Drawing.Point(621, 5);
            this.sbCommit.Name = "sbCommit";
            this.sbCommit.Size = new System.Drawing.Size(75, 23);
            this.sbCommit.TabIndex = 2;
            this.sbCommit.Text = "Commit";
            this.sbCommit.Click += new System.EventHandler(this.sbCommit_Click);
            // 
            // sbLoadData
            // 
            this.sbLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLoadData.Location = new System.Drawing.Point(702, 5);
            this.sbLoadData.Name = "sbLoadData";
            this.sbLoadData.Size = new System.Drawing.Size(75, 23);
            this.sbLoadData.TabIndex = 0;
            this.sbLoadData.Text = "Load Data";
            this.sbLoadData.Click += new System.EventHandler(this.sbLoadData_Click);
            // 
            // lbCommit
            // 
            this.lbCommit.Appearance.Options.UseTextOptions = true;
            this.lbCommit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbCommit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbCommit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCommit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbCommit.Location = new System.Drawing.Point(287, 208);
            this.lbCommit.Name = "lbCommit";
            this.lbCommit.Size = new System.Drawing.Size(209, 94);
            this.lbCommit.TabIndex = 5;
            this.lbCommit.Text = "Committing...";
            this.lbCommit.Visible = false;
            // 
            // AsyncLoadingTaskBased
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCommit);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "AsyncLoadingTaskBased";
            this.Size = new System.Drawing.Size(782, 510);
            this.Resize += new System.EventHandler(this.AsyncLoading_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gclPersons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gclProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.LabelControl lbLoadingPersons;
        private DevExpress.XtraEditors.LabelControl lbLoadingProducts;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton sbLoadData;
        private DevExpress.XtraEditors.SimpleButton sbCommit;
        private DevExpress.XtraEditors.LabelControl lbCommit;
    }
}
