
namespace DevExpress.XtraDialogs.Demos  {
    partial class CustomDialogLayout {
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
            this.components = new System.ComponentModel.Container();
            this.fileExplorerAssistant = new DevExpress.XtraDialogs.FileExplorerAssistant(this.components);
            this.leftPanel = new DevExpress.XtraEditors.SidePanel();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolbarPanel = new DevExpress.Utils.Layout.TablePanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.currentPathEdit = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.searchBox = new DevExpress.XtraEditors.SearchControl();
            this.bottomPanel = new DevExpress.XtraEditors.SidePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.fNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.fileNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.topPanel = new DevExpress.XtraEditors.SidePanel();
            this.rightPanel = new DevExpress.XtraEditors.SidePanel();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileExplorerAssistant)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarPanel)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPathEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).BeginInit();
            this.topPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.treeList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 48);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(199, 276);
            this.leftPanel.TabIndex = 0;
            // 
            // treeList
            // 
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Margin = new System.Windows.Forms.Padding(0);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(198, 276);
            this.treeList.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(199, 48);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(388, 276);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.AutoSize = true;
            this.toolbarPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F)});
            this.toolbarPanel.Controls.Add(this.btnBack);
            this.toolbarPanel.Controls.Add(this.currentPathEdit);
            this.toolbarPanel.Controls.Add(this.btnForward);
            this.toolbarPanel.Controls.Add(this.btnUp);
            this.toolbarPanel.Controls.Add(this.searchBox);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarPanel.Location = new System.Drawing.Point(12, 8);
            this.toolbarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.toolbarPanel.Size = new System.Drawing.Size(992, 31);
            this.toolbarPanel.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnBack, 0);
            this.btnBack.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateBack;
            this.btnBack.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnBack, 0);
            this.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBack.Size = new System.Drawing.Size(30, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // currentPathEdit
            // 
            this.toolbarPanel.SetColumn(this.currentPathEdit, 3);
            this.currentPathEdit.Location = new System.Drawing.Point(92, 5);
            this.currentPathEdit.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.currentPathEdit.Name = "currentPathEdit";
            this.currentPathEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toolbarPanel.SetRow(this.currentPathEdit, 0);
            this.currentPathEdit.Size = new System.Drawing.Size(750, 20);
            this.currentPathEdit.TabIndex = 4;
            // 
            // btnForward
            // 
            this.btnForward.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnForward, 1);
            this.btnForward.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateForward;
            this.btnForward.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnForward.Location = new System.Drawing.Point(30, 1);
            this.btnForward.Margin = new System.Windows.Forms.Padding(0);
            this.btnForward.Name = "btnForward";
            this.btnForward.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnForward, 0);
            this.btnForward.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnForward.Size = new System.Drawing.Size(30, 28);
            this.btnForward.TabIndex = 2;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnUp, 2);
            this.btnUp.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateUp;
            this.btnUp.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnUp.Location = new System.Drawing.Point(60, 1);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnUp.Name = "btnUp";
            this.btnUp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnUp, 0);
            this.btnUp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnUp.Size = new System.Drawing.Size(30, 28);
            this.btnUp.TabIndex = 2;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // searchBox
            // 
            this.searchBox.Client = this.gridControl;
            this.toolbarPanel.SetColumn(this.searchBox, 4);
            this.searchBox.Location = new System.Drawing.Point(850, 5);
            this.searchBox.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchBox.Properties.Client = this.gridControl;
            this.toolbarPanel.SetRow(this.searchBox, 0);
            this.searchBox.Size = new System.Drawing.Size(142, 20);
            this.searchBox.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AllowResize = false;
            this.bottomPanel.Controls.Add(this.tablePanel1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 324);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.bottomPanel.Size = new System.Drawing.Size(1016, 73);
            this.bottomPanel.TabIndex = 3;
            this.bottomPanel.Visible = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel1.Controls.Add(this.fNameLabel);
            this.tablePanel1.Controls.Add(this.fileNameEdit);
            this.tablePanel1.Controls.Add(this.btnOpenFile);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(12, 9);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.tablePanel1.Size = new System.Drawing.Size(992, 56);
            this.tablePanel1.TabIndex = 0;
            // 
            // fNameLabel
            // 
            this.tablePanel1.SetColumn(this.fNameLabel, 0);
            this.fNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fNameLabel.Location = new System.Drawing.Point(3, 3);
            this.fNameLabel.Name = "fNameLabel";
            this.tablePanel1.SetRow(this.fNameLabel, 0);
            this.fNameLabel.Size = new System.Drawing.Size(77, 24);
            this.fNameLabel.TabIndex = 2;
            this.fNameLabel.Text = "Text Document:";
            // 
            // fileNameEdit
            // 
            this.tablePanel1.SetColumn(this.fileNameEdit, 1);
            this.fileNameEdit.Location = new System.Drawing.Point(91, 5);
            this.fileNameEdit.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.fileNameEdit.Name = "fileNameEdit";
            this.fileNameEdit.Properties.NullValuePrompt = "Select a Text Document...";
            this.tablePanel1.SetRow(this.fileNameEdit, 0);
            this.fileNameEdit.Size = new System.Drawing.Size(767, 20);
            this.fileNameEdit.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.tablePanel1.SetColumn(this.btnOpenFile, 2);
            this.btnOpenFile.Location = new System.Drawing.Point(869, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.tablePanel1.SetRow(this.btnOpenFile, 0);
            this.btnOpenFile.Size = new System.Drawing.Size(120, 24);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open Text Document";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // topPanel
            // 
            this.topPanel.AllowResize = false;
            this.topPanel.Controls.Add(this.toolbarPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.topPanel.Size = new System.Drawing.Size(1016, 48);
            this.topPanel.TabIndex = 5;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panelControl);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(587, 48);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(429, 276);
            this.rightPanel.TabIndex = 6;
            this.rightPanel.Text = "sidePanel1";
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(1, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(428, 276);
            this.panelControl.TabIndex = 0;
            // 
            // CustomDialogLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustomDialogLayout";
            this.Size = new System.Drawing.Size(1016, 397);
            ((System.ComponentModel.ISupportInitialize)(this.fileExplorerAssistant)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarPanel)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPathEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDialogs.FileExplorerAssistant fileExplorerAssistant;
        private DevExpress.XtraEditors.SidePanel leftPanel;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel toolbarPanel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.BreadCrumbEdit currentPathEdit;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.SearchControl searchBox;
        private DevExpress.XtraEditors.SidePanel bottomPanel;
        private DevExpress.XtraEditors.SidePanel topPanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit fileNameEdit;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.LabelControl fNameLabel;
        private XtraEditors.SidePanel rightPanel;
        private XtraEditors.PanelControl panelControl;
    }
}
