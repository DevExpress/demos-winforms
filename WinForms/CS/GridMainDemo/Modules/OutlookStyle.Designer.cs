using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class OutlookStyle {
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlookStyle));
            DevExpress.XtraBars.Alerter.AlertButton alertButton1 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton2 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton3 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.svgImageCollection2 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.biOpen = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biRead = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bcLow = new DevExpress.XtraBars.BarCheckItem();
            this.bcMedium = new DevExpress.XtraBars.BarCheckItem();
            this.bcHigh = new DevExpress.XtraBars.BarCheckItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ucMailViewer1 = new DevExpress.XtraGrid.Demos.ucMailViewer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Demos.PreviewGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.svgImageColumns = new DevExpress.Utils.SvgImageCollection(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageColumns)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gridColumn2.FieldName = "Read";
            this.gridColumn2.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("gridColumn2.ImageOptions.Alignment")));
            this.gridColumn2.ImageOptions.ImageIndex = ((int)(resources.GetObject("gridColumn2.ImageOptions.ImageIndex")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox2
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox2, "repositoryItemImageComboBox2");
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items5"))))});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.svgImageCollection1;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("system.Drawing.Bitmap", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_1"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_2", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_2"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_3", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_3"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_4", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_4"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_5", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_5"))));
            this.svgImageCollection1.Add("system.Drawing.Bitmap_7", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_7"))));
            // 
            // alertControl1
            // 
            alertButton1.Hint = "Mark as Read";
            alertButton1.ImageOptions.ImageDownIndex = 1;
            alertButton1.ImageOptions.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            alertButton1.Name = "Read";
            alertButton1.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton;
            alertButton2.Hint = "Open Attachment";
            alertButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            alertButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            alertButton2.Name = "Attachment";
            alertButton3.Hint = "Delete Item";
            alertButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            alertButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            alertButton3.Name = "Delete";
            this.alertControl1.Buttons.Add(alertButton1);
            this.alertControl1.Buttons.Add(alertButton2);
            this.alertControl1.Buttons.Add(alertButton3);
            this.alertControl1.Images = this.svgImageCollection2;
            this.alertControl1.PopupMenu = this.popupMenu1;
            this.alertControl1.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alertControl1_AlertClick);
            this.alertControl1.ButtonClick += new DevExpress.XtraBars.Alerter.AlertButtonClickEventHandler(this.alertControl1_ButtonClick);
            this.alertControl1.ButtonDownChanged += new DevExpress.XtraBars.Alerter.AlertButtonDownChangedEventHandler(this.alertControl1_ButtonDownChanged);
            // 
            // svgImageCollection2
            // 
            this.svgImageCollection2.Add("Icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection2.Icon"))));
            this.svgImageCollection2.Add("system.Drawing.Bitmap_2", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_2"))));
            this.svgImageCollection2.Add("system.Drawing.Bitmap_3", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_3"))));
            this.svgImageCollection2.Add("system.Drawing.Bitmap_4", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_4"))));
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.biDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.biRead),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupMenu1_BeforePopup);
            // 
            // biOpen
            // 
            resources.ApplyResources(this.biOpen, "biOpen");
            this.biOpen.Id = 4;
            this.biOpen.Name = "biOpen";
            this.biOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biOpen_ItemClick);
            // 
            // biDelete
            // 
            resources.ApplyResources(this.biDelete, "biDelete");
            this.biDelete.Id = 1;
            this.biDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biDelete.ImageOptions.SvgImage")));
            this.biDelete.Name = "biDelete";
            this.biDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDelete_ItemClick);
            // 
            // biRead
            // 
            resources.ApplyResources(this.biRead, "biRead");
            this.biRead.Id = 2;
            this.biRead.ImageOptions.ImageIndex = ((int)(resources.GetObject("biRead.ImageOptions.ImageIndex")));
            this.biRead.Name = "biRead";
            this.biRead.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biRead_ItemClick);
            // 
            // barSubItem1
            // 
            resources.ApplyResources(this.barSubItem1, "barSubItem1");
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcLow),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcMedium),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcHigh)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bcLow
            // 
            resources.ApplyResources(this.bcLow, "bcLow");
            this.bcLow.GroupIndex = 1;
            this.bcLow.Id = 5;
            this.bcLow.Name = "bcLow";
            this.bcLow.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bc_DownChanged);
            // 
            // bcMedium
            // 
            resources.ApplyResources(this.bcMedium, "bcMedium");
            this.bcMedium.GroupIndex = 1;
            this.bcMedium.Id = 8;
            this.bcMedium.Name = "bcMedium";
            this.bcMedium.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bc_DownChanged);
            // 
            // bcHigh
            // 
            resources.ApplyResources(this.bcHigh, "bcHigh");
            this.bcHigh.GroupIndex = 1;
            this.bcHigh.Id = 9;
            this.bcHigh.Name = "bcHigh";
            this.bcHigh.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bc_DownChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.svgImageCollection2;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biDelete,
            this.biRead,
            this.barSubItem1,
            this.biOpen,
            this.bcLow,
            this.bcMedium,
            this.bcHigh});
            this.barManager1.MaxItemId = 10;
            this.barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // repositoryItemImageComboBox4
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox4, "repositoryItemImageComboBox4");
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox4.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox4.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox4.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox4.Items5"))))});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.svgImageCollection1;
            // 
            // ucMailViewer1
            // 
            resources.ApplyResources(this.ucMailViewer1, "ucMailViewer1");
            this.ucMailViewer1.Name = "ucMailViewer1";
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            styleFormatCondition1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridColumn2;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Images = this.svgImageColumns;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.PrintHorzLines = false;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsPrint.PrintVertLines = false;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PreviewFieldName = "PlainText";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn6, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.ColumnPositionChanged += new System.EventHandler(this.gridView1_ColumnPositionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn1.FieldName = "Priority";
            this.gridColumn1.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("gridColumn1.ImageOptions.Alignment")));
            this.gridColumn1.ImageOptions.ImageIndex = ((int)(resources.GetObject("gridColumn1.ImageOptions.ImageIndex")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ShowCaption = false;
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
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.ColumnEdit = this.repositoryItemImageComboBox3;
            this.gridColumn3.FieldName = "Attachment";
            this.gridColumn3.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("gridColumn3.ImageOptions.Alignment")));
            this.gridColumn3.ImageOptions.ImageIndex = ((int)(resources.GetObject("gridColumn3.ImageOptions.ImageIndex")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.AllowSize = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox3
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox3, "repositoryItemImageComboBox3");
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items5"))))});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.svgImageCollection1;
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.FieldName = "Subject";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn5
            // 
            resources.ApplyResources(this.gridColumn5, "gridColumn5");
            this.gridColumn5.FieldName = "From";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn6
            // 
            resources.ApplyResources(this.gridColumn6, "gridColumn6");
            this.gridColumn6.FieldName = "Date";
            this.gridColumn6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.ColumnEdit = this.repositoryItemImageComboBox4;
            this.gridColumn7.FieldName = "Read";
            this.gridColumn7.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("gridColumn7.ImageOptions.Alignment")));
            this.gridColumn7.ImageOptions.ImageIndex = ((int)(resources.GetObject("gridColumn7.ImageOptions.ImageIndex")));
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsColumn.AllowShowHide = false;
            this.gridColumn7.OptionsColumn.AllowSize = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.OptionsColumn.ShowCaption = false;
            this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.gridColumn7, "gridColumn7");
            // 
            // svgImageColumns
            // 
            this.svgImageColumns.Add("system.Drawing.Bitmap_1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageColumns.system.Drawing.Bitmap_1"))));
            this.svgImageColumns.Add("new1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageColumns.new1"))));
            this.svgImageColumns.Add("system.Drawing.Bitmap_4", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageColumns.system.Drawing.Bitmap_4"))));
            this.svgImageColumns.Add("show", "image://devav/actions/show.svg");
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.ucMailViewer1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // OutlookStyle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OutlookStyle";
            this.Load += new System.EventHandler(this.OutlookStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageColumns)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem biDelete;
        private DevExpress.XtraBars.BarButtonItem biRead;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem biOpen;
        private DevExpress.XtraBars.BarCheckItem bcLow;
        private DevExpress.XtraBars.BarCheckItem bcMedium;
        private DevExpress.XtraBars.BarCheckItem bcHigh;
        private ucMailViewer ucMailViewer1;
        private GridControl gridControl1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private Columns.GridColumn gridColumn1;
        private Columns.GridColumn gridColumn2;
        private Columns.GridColumn gridColumn3;
        private Columns.GridColumn gridColumn4;
        private Columns.GridColumn gridColumn5;
        private Columns.GridColumn gridColumn6;
        private Columns.GridColumn gridColumn7;
        private PreviewGridView gridView1;
        private XtraEditors.SidePanel sidePanel1;
        private Utils.SvgImageCollection svgImageCollection1;
        private Utils.SvgImageCollection svgImageColumns;
        private Utils.SvgImageCollection svgImageCollection2;
    }
}
