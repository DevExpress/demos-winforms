namespace DevExpress.XtraGrid.Demos {
    partial class GridInstantFeedbackUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridInstantFeedbackUI));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpAsyncServerModeSource1 = new DevExpress.Xpo.XPInstantFeedbackSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbShowSQLConnection = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.icbAnimation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl1layoutControl2ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.icbAnimationitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl2ConvertedLayout)).BeginInit();
            this.panelControl1layoutControl2ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimationitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpAsyncServerModeSource1;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemCheckEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpAsyncServerModeSource1
            // 
            this.xpAsyncServerModeSource1.ObjectType = typeof(DevExpress.XtraGrid.Demos.ServerSideGridTest);
            this.xpAsyncServerModeSource1.ResolveSession += new System.EventHandler<DevExpress.Xpo.ResolveSessionEventArgs>(this.xpAsyncServerModeSource1_ResolveSession);
            this.xpAsyncServerModeSource1.DismissSession += new System.EventHandler<DevExpress.Xpo.ResolveSessionEventArgs>(this.xpAsyncServerModeSource1_DismissSession);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colSubject,
            this.colFrom,
            this.colSent,
            this.colSize,
            this.colHasAttachment,
            this.colPriority,
            this.colExpression});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3")),
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary4"))), resources.GetString("gridView1.GroupSummary5"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary6"))), resources.GetString("gridView1.GroupSummary7"))});
            this.gridView1.Images = this.svgImageCollection1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colOid
            // 
            resources.ApplyResources(this.colOid, "colOid");
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.OptionsColumn.ReadOnly = true;
            this.colOid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colOid.Summary"))))});
            // 
            // colSubject
            // 
            resources.ApplyResources(this.colSubject, "colSubject");
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            // 
            // colFrom
            // 
            resources.ApplyResources(this.colFrom, "colFrom");
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            // 
            // colSent
            // 
            resources.ApplyResources(this.colSent, "colSent");
            this.colSent.FieldName = "Sent";
            this.colSent.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
            this.colSent.Name = "colSent";
            // 
            // colSize
            // 
            resources.ApplyResources(this.colSize, "colSize");
            this.colSize.DisplayFormat.FormatString = "{0:n0} KB";
            this.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colSize.Summary"))), resources.GetString("colSize.Summary1"), resources.GetString("colSize.Summary2"))});
            // 
            // colHasAttachment
            // 
            resources.ApplyResources(this.colHasAttachment, "colHasAttachment");
            this.colHasAttachment.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colHasAttachment.FieldName = "HasAttachment";
            this.colHasAttachment.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colHasAttachment.ImageOptions.Alignment")));
            this.colHasAttachment.ImageOptions.ImageIndex = ((int)(resources.GetObject("colHasAttachment.ImageOptions.ImageIndex")));
            this.colHasAttachment.Name = "colHasAttachment";
            this.colHasAttachment.OptionsColumn.AllowSize = false;
            this.colHasAttachment.OptionsColumn.FixedWidth = true;
            this.colHasAttachment.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemCheckEdit1
            // 
            resources.ApplyResources(this.repositoryItemCheckEdit1, "repositoryItemCheckEdit1");
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.ImageOptions.ImageIndexChecked = 4;
            this.repositoryItemCheckEdit1.ImageOptions.Images = this.svgImageCollection1;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ReadOnly = true;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("system.Drawing.Bitmap", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_1"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_2", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_2"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_3", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_3"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_4", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_4"))));
            this.svgImageCollection1.Add("Icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Icon"))));
            // 
            // colPriority
            // 
            resources.ApplyResources(this.colPriority, "colPriority");
            this.colPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colPriority.FieldName = "Priority";
            this.colPriority.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colPriority.ImageOptions.Alignment")));
            this.colPriority.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPriority.ImageOptions.ImageIndex")));
            this.colPriority.Name = "colPriority";
            this.colPriority.OptionsColumn.AllowSize = false;
            this.colPriority.OptionsColumn.FixedWidth = true;
            this.colPriority.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.svgImageCollection1;
            // 
            // colExpression
            // 
            resources.ApplyResources(this.colExpression, "colExpression");
            this.colExpression.FieldName = "Expression";
            this.colExpression.Name = "colExpression";
            this.colExpression.ShowUnboundExpressionMenu = true;
            this.colExpression.UnboundExpression = "DateDiffMinute([Sent], Now())";
            this.colExpression.UnboundDataType = typeof(int);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbShowSQLConnection);
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // sbShowSQLConnection
            // 
            resources.ApplyResources(this.sbShowSQLConnection, "sbShowSQLConnection");
            this.sbShowSQLConnection.Name = "sbShowSQLConnection";
            this.sbShowSQLConnection.StyleController = this.layoutControl1;
            this.sbShowSQLConnection.Click += new System.EventHandler(this.sbShowSQLConnection_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbShowSQLConnection;
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 436);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(119, 33);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(542, 577);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(542, 577);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // icbAnimation
            // 
            resources.ApplyResources(this.icbAnimation, "icbAnimation");
            this.icbAnimation.Name = "icbAnimation";
            this.icbAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbAnimation.Properties.Buttons"))))});
            this.icbAnimation.StyleController = this.panelControl1layoutControl2ConvertedLayout;
            this.icbAnimation.SelectedIndexChanged += new System.EventHandler(this.icbAnimation_SelectedIndexChanged);
            // 
            // panelControl1layoutControl2ConvertedLayout
            // 
            this.panelControl1layoutControl2ConvertedLayout.AllowCustomization = false;
            this.panelControl1layoutControl2ConvertedLayout.Controls.Add(this.icbAnimation);
            resources.ApplyResources(this.panelControl1layoutControl2ConvertedLayout, "panelControl1layoutControl2ConvertedLayout");
            this.panelControl1layoutControl2ConvertedLayout.Name = "panelControl1layoutControl2ConvertedLayout";
            this.panelControl1layoutControl2ConvertedLayout.Root = this.layoutControlGroup2;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 550);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.icbAnimationitem});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(249, 63);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // icbAnimationitem
            // 
            this.icbAnimationitem.Control = this.icbAnimation;
            this.icbAnimationitem.Location = new System.Drawing.Point(0, 0);
            this.icbAnimationitem.Name = "icbAnimationitem";
            this.icbAnimationitem.Size = new System.Drawing.Size(229, 24);
            resources.ApplyResources(this.icbAnimationitem, "icbAnimationitem");
            this.icbAnimationitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.icbAnimationitem.TextSize = new System.Drawing.Size(0, 0);
            this.icbAnimationitem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 63);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 487);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            resources.ApplyResources(this.tabPane1, "tabPane1");
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(249, 577);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            // 
            // tabNavigationPage1
            // 
            resources.ApplyResources(this.tabNavigationPage1, "tabNavigationPage1");
            this.tabNavigationPage1.Controls.Add(this.panelControl1layoutControl2ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            // 
            // GridInstantFeedbackUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "GridInstantFeedbackUI";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl2ConvertedLayout)).EndInit();
            this.panelControl1layoutControl2ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimationitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSent;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colHasAttachment;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sbShowSQLConnection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Xpo.XPInstantFeedbackSource xpAsyncServerModeSource1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbAnimation;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colExpression;
        private XtraLayout.LayoutControl panelControl1layoutControl2ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem icbAnimationitem;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}

