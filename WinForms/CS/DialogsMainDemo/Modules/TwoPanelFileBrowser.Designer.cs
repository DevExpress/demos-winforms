namespace DevExpress.XtraDialogs.Demos {
    partial class TwoPanelFileBrowser {
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
            this.components = new System.ComponentModel.Container();
            this.fileExplorerAssistant = new DevExpress.XtraDialogs.FileExplorerAssistant(this.components);
            this.rightGrid = new DevExpress.XtraGrid.GridControl();
            this.rightView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.leftGrid = new DevExpress.XtraGrid.GridControl();
            this.leftView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.currentPathEdit = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.contentPanel = new DevExpress.Utils.Layout.TablePanel();
            this.verticalSeparator = new DevExpress.XtraEditors.SeparatorControl();
            this.toolbarPanel = new DevExpress.Utils.Layout.TablePanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.searchBox = new DevExpress.XtraEditors.SearchControl();
            this.footerPanel = new DevExpress.Utils.Layout.TablePanel();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnRename = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnMove = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanelBottom = new DevExpress.XtraEditors.SidePanel();
            this.sidePanelTop = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.fileExplorerAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPathEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarPanel)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPanel)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.sidePanelBottom.SuspendLayout();
            this.sidePanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileExplorerAssistant
            // 
            this.fileExplorerAssistant.Form = this;
            // 
            // rightGrid
            // 
            this.contentPanel.SetColumn(this.rightGrid, 2);
            this.rightGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.rightGrid.Location = new System.Drawing.Point(401, 0);
            this.rightGrid.MainView = this.rightView;
            this.rightGrid.Margin = new System.Windows.Forms.Padding(0);
            this.rightGrid.Name = "rightGrid";
            this.contentPanel.SetRow(this.rightGrid, 0);
            this.rightGrid.Size = new System.Drawing.Size(400, 505);
            this.rightGrid.TabIndex = 5;
            this.rightGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rightView});
            // 
            // rightView
            // 
            this.rightView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rightView.GridControl = this.rightGrid;
            this.rightView.Name = "rightView";
            this.rightView.OptionsView.ShowGroupPanel = false;
            // 
            // leftGrid
            // 
            this.contentPanel.SetColumn(this.leftGrid, 0);
            this.leftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.leftGrid.Location = new System.Drawing.Point(0, 0);
            this.leftGrid.MainView = this.leftView;
            this.leftGrid.Margin = new System.Windows.Forms.Padding(0);
            this.leftGrid.Name = "leftGrid";
            this.contentPanel.SetRow(this.leftGrid, 0);
            this.leftGrid.Size = new System.Drawing.Size(400, 505);
            this.leftGrid.TabIndex = 4;
            this.leftGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.leftView});
            // 
            // leftView
            // 
            this.leftView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.leftView.GridControl = this.leftGrid;
            this.leftView.Name = "leftView";
            this.leftView.OptionsView.ShowGroupPanel = false;
            // 
            // currentPathEdit
            // 
            this.toolbarPanel.SetColumn(this.currentPathEdit, 3);
            this.currentPathEdit.Location = new System.Drawing.Point(114, 13);
            this.currentPathEdit.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.currentPathEdit.Name = "currentPathEdit";
            this.currentPathEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toolbarPanel.SetRow(this.currentPathEdit, 0);
            this.currentPathEdit.Size = new System.Drawing.Size(483, 20);
            this.currentPathEdit.TabIndex = 4;
            // 
            // contentPanel
            // 
            this.contentPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.contentPanel.Controls.Add(this.verticalSeparator);
            this.contentPanel.Controls.Add(this.rightGrid);
            this.contentPanel.Controls.Add(this.leftGrid);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 47);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.contentPanel.Size = new System.Drawing.Size(800, 505);
            this.contentPanel.TabIndex = 0;
            // 
            // verticalSeparator
            // 
            this.verticalSeparator.AutoSizeMode = true;
            this.contentPanel.SetColumn(this.verticalSeparator, 1);
            this.verticalSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSeparator.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.verticalSeparator.Location = new System.Drawing.Point(400, 0);
            this.verticalSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.verticalSeparator.Name = "verticalSeparator";
            this.verticalSeparator.Padding = new System.Windows.Forms.Padding(0);
            this.contentPanel.SetRow(this.verticalSeparator, 0);
            this.verticalSeparator.Size = new System.Drawing.Size(1, 505);
            this.verticalSeparator.TabIndex = 6;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.AutoSize = true;
            this.toolbarPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F)});
            this.toolbarPanel.Controls.Add(this.btnBack);
            this.toolbarPanel.Controls.Add(this.currentPathEdit);
            this.toolbarPanel.Controls.Add(this.btnForward);
            this.toolbarPanel.Controls.Add(this.btnUp);
            this.toolbarPanel.Controls.Add(this.searchBox);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.toolbarPanel.Size = new System.Drawing.Size(800, 46);
            this.toolbarPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnBack, 0);
            this.btnBack.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateBack;
            this.btnBack.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnBack, 0);
            this.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBack.Size = new System.Drawing.Size(30, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.OnBack);
            // 
            // btnForward
            // 
            this.btnForward.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnForward, 1);
            this.btnForward.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateForward;
            this.btnForward.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnForward.Location = new System.Drawing.Point(42, 9);
            this.btnForward.Margin = new System.Windows.Forms.Padding(0);
            this.btnForward.Name = "btnForward";
            this.btnForward.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnForward, 0);
            this.btnForward.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnForward.Size = new System.Drawing.Size(30, 28);
            this.btnForward.TabIndex = 2;
            this.btnForward.Click += new System.EventHandler(this.OnForward);
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.toolbarPanel.SetColumn(this.btnUp, 2);
            this.btnUp.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.navigateUp;
            this.btnUp.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnUp.Location = new System.Drawing.Point(72, 9);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnUp.Name = "btnUp";
            this.btnUp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.toolbarPanel.SetRow(this.btnUp, 0);
            this.btnUp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnUp.Size = new System.Drawing.Size(30, 28);
            this.btnUp.TabIndex = 2;
            this.btnUp.Click += new System.EventHandler(this.OnUp);
            // 
            // searchBox
            // 
            this.toolbarPanel.SetColumn(this.searchBox, 4);
            this.searchBox.Location = new System.Drawing.Point(612, 13);
            this.searchBox.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.toolbarPanel.SetRow(this.searchBox, 0);
            this.searchBox.Size = new System.Drawing.Size(176, 20);
            this.searchBox.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.AutoSize = true;
            this.footerPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPanel.Controls.Add(this.btnOpen);
            this.footerPanel.Controls.Add(this.btnRename);
            this.footerPanel.Controls.Add(this.btnCopy);
            this.footerPanel.Controls.Add(this.btnMove);
            this.footerPanel.Controls.Add(this.btnNewFolder);
            this.footerPanel.Controls.Add(this.btnDelete);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.footerPanel.Location = new System.Drawing.Point(12, 9);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPanel.Size = new System.Drawing.Size(501, 31);
            this.footerPanel.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.footerPanel.SetColumn(this.btnOpen, 0);
            this.btnOpen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOpen.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f3;
            this.btnOpen.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnOpen.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnOpen, 0);
            this.btnOpen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnOpen.Size = new System.Drawing.Size(76, 31);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.OnOpen);
            // 
            // btnRename
            // 
            this.btnRename.AutoSize = true;
            this.footerPanel.SetColumn(this.btnRename, 1);
            this.btnRename.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRename.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f4;
            this.btnRename.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnRename.Location = new System.Drawing.Point(76, 0);
            this.btnRename.Margin = new System.Windows.Forms.Padding(0);
            this.btnRename.Name = "btnRename";
            this.btnRename.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnRename.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnRename, 0);
            this.btnRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRename.Size = new System.Drawing.Size(89, 31);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename";
            this.btnRename.Click += new System.EventHandler(this.OnRename);
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.footerPanel.SetColumn(this.btnCopy, 2);
            this.btnCopy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCopy.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f5;
            this.btnCopy.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnCopy.Location = new System.Drawing.Point(165, 0);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnCopy.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnCopy, 0);
            this.btnCopy.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCopy.Size = new System.Drawing.Size(75, 31);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.OnCopy);
            // 
            // btnMove
            // 
            this.btnMove.AutoSize = true;
            this.footerPanel.SetColumn(this.btnMove, 3);
            this.btnMove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMove.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f6;
            this.btnMove.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnMove.Location = new System.Drawing.Point(240, 0);
            this.btnMove.Margin = new System.Windows.Forms.Padding(0);
            this.btnMove.Name = "btnMove";
            this.btnMove.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnMove.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnMove, 0);
            this.btnMove.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnMove.Size = new System.Drawing.Size(76, 31);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move";
            this.btnMove.Click += new System.EventHandler(this.OnMove);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.AutoSize = true;
            this.footerPanel.SetColumn(this.btnNewFolder, 4);
            this.btnNewFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewFolder.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f7;
            this.btnNewFolder.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnNewFolder.Location = new System.Drawing.Point(316, 0);
            this.btnNewFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnNewFolder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnNewFolder, 0);
            this.btnNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNewFolder.Size = new System.Drawing.Size(104, 31);
            this.btnNewFolder.TabIndex = 0;
            this.btnNewFolder.Text = "New Folder";
            this.btnNewFolder.Click += new System.EventHandler(this.OnNewFolder);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.footerPanel.SetColumn(this.btnDelete, 5);
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.ImageOptions.SvgImage = global::DevExpress.XtraDialogs.Demos.Properties.Resources.f8;
            this.btnDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.btnDelete.Location = new System.Drawing.Point(420, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.footerPanel.SetRow(this.btnDelete, 0);
            this.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelete.Size = new System.Drawing.Size(81, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.OnDelete);
            // 
            // sidePanelBottom
            // 
            this.sidePanelBottom.AllowResize = false;
            this.sidePanelBottom.Controls.Add(this.footerPanel);
            this.sidePanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanelBottom.Location = new System.Drawing.Point(0, 552);
            this.sidePanelBottom.Name = "sidePanelBottom";
            this.sidePanelBottom.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.sidePanelBottom.Size = new System.Drawing.Size(800, 48);
            this.sidePanelBottom.TabIndex = 6;
            // 
            // sidePanelTop
            // 
            this.sidePanelTop.AllowResize = false;
            this.sidePanelTop.Controls.Add(this.toolbarPanel);
            this.sidePanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanelTop.Location = new System.Drawing.Point(0, 0);
            this.sidePanelTop.Name = "sidePanelTop";
            this.sidePanelTop.Size = new System.Drawing.Size(800, 47);
            this.sidePanelTop.TabIndex = 6;
            // 
            // TwoPanelFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanelTop);
            this.Controls.Add(this.sidePanelBottom);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TwoPanelFileBrowser";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.fileExplorerAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPathEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarPanel)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPanel)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.sidePanelBottom.ResumeLayout(false);
            this.sidePanelBottom.PerformLayout();
            this.sidePanelTop.ResumeLayout(false);
            this.sidePanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraDialogs.FileExplorerAssistant fileExplorerAssistant;
        private DevExpress.XtraGrid.GridControl rightGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rightView;
        private DevExpress.XtraGrid.GridControl leftGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView leftView;
        private DevExpress.XtraEditors.BreadCrumbEdit currentPathEdit;
        private DevExpress.Utils.Layout.TablePanel toolbarPanel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.Utils.Layout.TablePanel contentPanel;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.SearchControl searchBox;
        private DevExpress.Utils.Layout.TablePanel footerPanel;
        private DevExpress.XtraEditors.SimpleButton btnOpen;
        private DevExpress.XtraEditors.SimpleButton btnRename;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnMove;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNewFolder;
        private XtraEditors.SidePanel sidePanelTop;
        private XtraEditors.SidePanel sidePanelBottom;
        private XtraEditors.SeparatorControl verticalSeparator;
    }
}

