namespace DevExpress.XtraLayout.Demos {
    partial class XtraLayoutPanelTutorialControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraLayoutPanelTutorialControl));
            this.contentPanel = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnResetLayout = new DevExpress.XtraEditors.SimpleButton();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.toolboxControl = new DevExpress.XtraToolbox.ToolboxControl();
            this.toolboxGroupRoot = new DevExpress.XtraToolbox.ToolboxGroup();
            this.tiSimpleButton = new DevExpress.XtraToolbox.ToolboxItem();
            this.tiTextEdit = new DevExpress.XtraToolbox.ToolboxItem();
            this.tiLabel = new DevExpress.XtraToolbox.ToolboxItem();
            this.tiCheckEdit = new DevExpress.XtraToolbox.ToolboxItem();
            this.imageList = new DevExpress.Utils.ImageCollection(this.components);
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgToolbox = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liToolbox = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liPropertyGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.liResetLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.rootPanel = new DevExpress.XtraEditors.PanelControl();
            this.topStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.labelHint = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgToolbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liToolbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liPropertyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liResetLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).BeginInit();
            this.rootPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topStackPanel)).BeginInit();
            this.topStackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 50);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(693, 536);
            this.contentPanel.TabIndex = 4;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.layoutControl);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(693, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 586);
            this.sidePanel.TabIndex = 11;
            this.sidePanel.Text = "sidePanel1";
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.btnResetLayout);
            this.layoutControl.Controls.Add(this.propertyGridControl);
            this.layoutControl.Controls.Add(this.toolboxControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(1, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 335, 650, 400);
            this.layoutControl.Root = this.lcgRoot;
            this.layoutControl.Size = new System.Drawing.Size(249, 586);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btnResetLayout
            // 
            this.btnResetLayout.Location = new System.Drawing.Point(12, 528);
            this.btnResetLayout.Name = "btnResetLayout";
            this.btnResetLayout.Size = new System.Drawing.Size(225, 22);
            this.btnResetLayout.StyleController = this.layoutControl;
            this.btnResetLayout.TabIndex = 6;
            this.btnResetLayout.Text = "Reset Layout";
            this.btnResetLayout.Click += new System.EventHandler(this.OnResetLayoutClick);
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office;
            this.propertyGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.propertyGridControl.Location = new System.Drawing.Point(0, 169);
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.OptionsBehavior.AutoPostEditorDelay = 600;
            this.propertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl.OptionsView.LevelIndent = 9;
            this.propertyGridControl.OptionsView.ShowRootCategories = false;
            this.propertyGridControl.RecordWidth = 178;
            this.propertyGridControl.RowHeaderWidth = 22;
            this.propertyGridControl.Size = new System.Drawing.Size(249, 357);
            this.propertyGridControl.TabIndex = 5;
            // 
            // toolboxControl
            // 
            this.toolboxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.toolboxControl.Groups.Add(this.toolboxGroupRoot);
            this.toolboxControl.Images = this.imageList;
            this.toolboxControl.Location = new System.Drawing.Point(0, 22);
            this.toolboxControl.Name = "toolboxControl";
            this.toolboxControl.OptionsMinimizing.AllowMinimizing = false;
            this.toolboxControl.OptionsView.ColumnCount = 1;
            this.toolboxControl.OptionsView.ShowMenuButton = false;
            this.toolboxControl.OptionsView.ShowSearchPanel = false;
            this.toolboxControl.OptionsView.ShowToolboxCaption = true;
            this.toolboxControl.SelectedGroup = this.toolboxGroupRoot;
            this.toolboxControl.SelectedGroupIndex = 0;
            this.toolboxControl.ShouldDrawOnlyItems = true;
            this.toolboxControl.Size = new System.Drawing.Size(249, 125);
            this.toolboxControl.StyleController = this.layoutControl;
            this.toolboxControl.TabIndex = 4;
            this.toolboxControl.DragItemDrop += new DevExpress.XtraToolbox.ToolboxDragItemDropEventHandler(this.OnToolboxDragItemDrop);
            this.toolboxControl.DragItemStart += new DevExpress.XtraToolbox.ToolboxDragItemStartEventHandler(this.OnToolboxDragItemStart);
            this.toolboxControl.DragItemMove += new DevExpress.XtraToolbox.ToolboxDragItemMoveEventHandler(this.OnToolboxDragItemMove);
            this.toolboxControl.DragItemCancel += new DevExpress.XtraToolbox.ToolboxDragItemCancelEventHandler(this.OnToolboxDragItemCancel);
            // 
            // toolboxGroupRoot
            // 
            this.toolboxGroupRoot.Caption = "ToolboxGroup";
            this.toolboxGroupRoot.Items.Add(this.tiSimpleButton);
            this.toolboxGroupRoot.Items.Add(this.tiTextEdit);
            this.toolboxGroupRoot.Items.Add(this.tiLabel);
            this.toolboxGroupRoot.Items.Add(this.tiCheckEdit);
            this.toolboxGroupRoot.Name = "toolboxGroupRoot";
            this.toolboxGroupRoot.Visible = false;
            // 
            // tiSimpleButton
            // 
            this.tiSimpleButton.Caption = "Button";
            this.tiSimpleButton.ImageOptions.ImageIndex = 0;
            this.tiSimpleButton.Name = "tiSimpleButton";
            // 
            // tiTextEdit
            // 
            this.tiTextEdit.Caption = "TextEdit";
            this.tiTextEdit.ImageOptions.ImageIndex = 1;
            this.tiTextEdit.Name = "tiTextEdit";
            // 
            // tiLabel
            // 
            this.tiLabel.Caption = "Label";
            this.tiLabel.ImageOptions.ImageIndex = 2;
            this.tiLabel.Name = "tiLabel";
            // 
            // tiCheckEdit
            // 
            this.tiCheckEdit.Caption = "CheckEdit";
            this.tiCheckEdit.ImageOptions.ImageIndex = 3;
            this.tiCheckEdit.Name = "tiCheckEdit";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList.Images.SetKeyName(0, "SimpleButton.bmp");
            this.imageList.Images.SetKeyName(1, "TextEdit.bmp");
            this.imageList.Images.SetKeyName(2, "LabelControl.bmp");
            this.imageList.Images.SetKeyName(3, "CheckEdit.bmp");
            // 
            // lcgRoot
            // 
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgToolbox,
            this.lcgOptions});
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgRoot.Size = new System.Drawing.Size(249, 586);
            this.lcgRoot.TextVisible = false;
            // 
            // lcgToolbox
            // 
            this.lcgToolbox.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgToolbox.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liToolbox});
            this.lcgToolbox.Location = new System.Drawing.Point(0, 0);
            this.lcgToolbox.Name = "lcgToolbox";
            this.lcgToolbox.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgToolbox.Size = new System.Drawing.Size(249, 147);
            this.lcgToolbox.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgToolbox.Text = "Toolbox";
            // 
            // liToolbox
            // 
            this.liToolbox.Control = this.toolboxControl;
            this.liToolbox.Location = new System.Drawing.Point(0, 0);
            this.liToolbox.Name = "liToolbox";
            this.liToolbox.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.liToolbox.Size = new System.Drawing.Size(249, 125);
            this.liToolbox.TextVisible = false;
            // 
            // lcgOptions
            // 
            this.lcgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liPropertyGrid,
            this.liResetLayout,
            this.emptySpaceItem});
            this.lcgOptions.Location = new System.Drawing.Point(0, 147);
            this.lcgOptions.Name = "lcgOptions";
            this.lcgOptions.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgOptions.Size = new System.Drawing.Size(249, 439);
            this.lcgOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgOptions.Text = "Options";
            // 
            // liPropertyGrid
            // 
            this.liPropertyGrid.Control = this.propertyGridControl;
            this.liPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.liPropertyGrid.Name = "liPropertyGrid";
            this.liPropertyGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.liPropertyGrid.Size = new System.Drawing.Size(249, 357);
            this.liPropertyGrid.TextVisible = false;
            // 
            // liResetLayout
            // 
            this.liResetLayout.Control = this.btnResetLayout;
            this.liResetLayout.Location = new System.Drawing.Point(0, 357);
            this.liResetLayout.Name = "liResetLayout";
            this.liResetLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2);
            this.liResetLayout.Size = new System.Drawing.Size(249, 26);
            this.liResetLayout.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 383);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(249, 34);
            // 
            // rootPanel
            // 
            this.rootPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rootPanel.Controls.Add(this.contentPanel);
            this.rootPanel.Controls.Add(this.topStackPanel);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Size = new System.Drawing.Size(693, 586);
            this.rootPanel.TabIndex = 12;
            // 
            // topStackPanel
            // 
            this.topStackPanel.Controls.Add(this.labelHint);
            this.topStackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topStackPanel.Location = new System.Drawing.Point(0, 0);
            this.topStackPanel.Name = "topStackPanel";
            this.topStackPanel.Size = new System.Drawing.Size(693, 50);
            this.topStackPanel.TabIndex = 5;
            // 
            // labelHint
            // 
            this.labelHint.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelHint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelHint.ImageOptions.SvgImage")));
            this.labelHint.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.labelHint.Location = new System.Drawing.Point(17, 15);
            this.labelHint.Margin = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(170, 20);
            this.labelHint.TabIndex = 0;
            this.labelHint.Text = "Drag controls from the Toolbox";
            // 
            // XtraLayoutPanelTutorialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "XtraLayoutPanelTutorialControl";
            this.Size = new System.Drawing.Size(943, 586);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgToolbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liToolbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liPropertyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liResetLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).EndInit();
            this.rootPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topStackPanel)).EndInit();
            this.topStackPanel.ResumeLayout(false);
            this.topStackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.PanelControl contentPanel;
        private XtraEditors.SidePanel sidePanel;
        protected LayoutControl layoutControl;
        protected LayoutControlGroup lcgRoot;
        private XtraEditors.PanelControl rootPanel;
        private DevExpress.Utils.Layout.StackPanel topStackPanel;
        private XtraEditors.LabelControl labelHint;
        private XtraToolbox.ToolboxControl toolboxControl;
        private LayoutControlItem liToolbox;
        private XtraToolbox.ToolboxGroup toolboxGroupRoot;
        private XtraToolbox.ToolboxItem tiSimpleButton;
        private XtraToolbox.ToolboxItem tiTextEdit;
        private XtraToolbox.ToolboxItem tiLabel;
        private XtraToolbox.ToolboxItem tiCheckEdit;
        private DevExpress.Utils.ImageCollection imageList;
        protected XtraVerticalGrid.PropertyGridControl propertyGridControl;
        protected LayoutControlItem liPropertyGrid;
        protected LayoutControlGroup lcgOptions;
        protected LayoutControlGroup lcgToolbox;
        private XtraEditors.SimpleButton btnResetLayout;
        protected LayoutControlItem liResetLayout;
        protected EmptySpaceItem emptySpaceItem;
    }
}
