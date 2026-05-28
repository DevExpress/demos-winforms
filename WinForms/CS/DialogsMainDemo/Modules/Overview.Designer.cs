
namespace DevExpress.XtraDialogs.Demos {
    partial class Overview {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.operationsPanel = new DevExpress.XtraEditors.SidePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.workingFolderButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainModule = new DevExpress.XtraDialogs.Demos.MainModule();
            this.operationsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.AllowResize = false;
            this.operationsPanel.Controls.Add(this.tableLayoutPanel1);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.operationsPanel.Location = new System.Drawing.Point(748, 0);
            this.operationsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Padding = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.operationsPanel.Size = new System.Drawing.Size(300, 688);
            this.operationsPanel.TabIndex = 9;
            this.operationsPanel.Text = "sidePanel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.loadButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.workingFolderButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 640);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // loadButton
            // 
            this.loadButton.AllowFocus = false;
            this.loadButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.loadButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.loadButton.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.open;
            this.loadButton.ImageOptions.SvgImageSize = new System.Drawing.Size(90, 90);
            this.loadButton.Location = new System.Drawing.Point(89, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 120);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Document";
            this.loadButton.Click += new System.EventHandler(this.OpenItemClick);
            // 
            // saveButton
            // 
            this.saveButton.AllowFocus = false;
            this.saveButton.Enabled = false;
            this.saveButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.saveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.saveButton.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.save;
            this.saveButton.ImageOptions.SvgImageSize = new System.Drawing.Size(90, 90);
            this.saveButton.Location = new System.Drawing.Point(89, 129);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 120);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Document";
            this.saveButton.Click += new System.EventHandler(this.SaveItemClick);
            // 
            // workingFolderButton
            // 
            this.workingFolderButton.AllowFocus = false;
            this.workingFolderButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.workingFolderButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.workingFolderButton.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.folder;
            this.workingFolderButton.ImageOptions.SvgImageSize = new System.Drawing.Size(90, 90);
            this.workingFolderButton.Location = new System.Drawing.Point(89, 255);
            this.workingFolderButton.Name = "workingFolderButton";
            this.workingFolderButton.Size = new System.Drawing.Size(120, 120);
            this.workingFolderButton.TabIndex = 0;
            this.workingFolderButton.Text = "Set Working Folder";
            this.workingFolderButton.Click += new System.EventHandler(this.SetWorkingFolderItemClick);
            // 
            // mainModule
            // 
            this.mainModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainModule.Location = new System.Drawing.Point(0, 0);
            this.mainModule.Margin = new System.Windows.Forms.Padding(0);
            this.mainModule.Name = "mainModule";
            this.mainModule.Size = new System.Drawing.Size(748, 688);
            this.mainModule.TabIndex = 3;
            this.mainModule.DocumentLoaded += new System.EventHandler(this.MainModule_DocumentLoaded);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.mainModule);
            this.Controls.Add(this.operationsPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1048, 688);
            this.operationsPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected XtraEditors.SidePanel operationsPanel;
        private DevExpress.XtraDialogs.Demos.MainModule mainModule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton loadButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton workingFolderButton;
    }
}
