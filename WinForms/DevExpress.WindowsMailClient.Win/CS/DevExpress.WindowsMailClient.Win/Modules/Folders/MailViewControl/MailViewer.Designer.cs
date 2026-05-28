using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout;

namespace DevExpress.WindowsMailClient.Win.Modules {
    partial class MailViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailViewer));
            contextButton1 = new DevExpress.Utils.ContextButton();
            checkContextButton1 = new DevExpress.Utils.CheckContextButton();
            contextButton2 = new DevExpress.Utils.ContextButton();
            contextButton3 = new DevExpress.Utils.ContextButton();
            DevExpress.XtraGrid.Views.Tile.ItemTemplate itemTemplate1 = new DevExpress.XtraGrid.Views.Tile.ItemTemplate();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.ItemTemplate itemTemplate2 = new DevExpress.XtraGrid.Views.Tile.ItemTemplate();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition6 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition7 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement9 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement10 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition7 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan5 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan6 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan7 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.ItemTemplate itemTemplate3 = new DevExpress.XtraGrid.Views.Tile.ItemTemplate();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition8 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition9 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition10 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition11 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition12 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement11 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement12 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement13 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement14 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement15 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement16 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition8 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition9 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition10 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition11 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan8 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan9 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan10 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan11 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan12 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan13 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition13 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition14 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition15 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition16 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition17 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition12 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition13 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition14 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan14 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan15 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan16 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan17 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan18 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement17 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement18 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement19 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement20 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement21 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSubjectDisplayText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRead = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPlainText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.mailPresenter = new DevExpress.WindowsMailClient.Win.Modules.MailPresenter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colSubject = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelHeader = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.officeFilterTab = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationItemFocused = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationItemOther = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.pnlCtrlFilter = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bcFilterAll = new DevExpress.XtraBars.BarCheckItem();
            this.bcFilterUnread = new DevExpress.XtraBars.BarCheckItem();
            this.bcFilterToday = new DevExpress.XtraBars.BarCheckItem();
            this.bcFilterYesterday = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.biSortDate = new DevExpress.XtraBars.BarButtonItem();
            this.biSortFrom = new DevExpress.XtraBars.BarButtonItem();
            this.biSortRead = new DevExpress.XtraBars.BarButtonItem();
            this.biSortSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bcFilterImportance = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.biSortImportance = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciFilter = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTabFilter = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.notificationManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFilterTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlFilter)).BeginInit();
            this.pnlCtrlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationManager)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.colDate.Caption = "colDate";
            this.colDate.FieldName = "Date";
            this.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            
            
            
            this.colSubjectDisplayText.Caption = "colSubjectDisplayText";
            this.colSubjectDisplayText.FieldName = "SubjectDisplayText";
            this.colSubjectDisplayText.Name = "colSubjectDisplayText";
            this.colSubjectDisplayText.Visible = true;
            this.colSubjectDisplayText.VisibleIndex = 4;
            
            
            
            this.colFrom.Caption = "colFrom";
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 1;
            
            
            
            this.colRead.Caption = "colRead";
            this.colRead.FieldName = "Read";
            this.colRead.Name = "colRead";
            this.colRead.Visible = true;
            this.colRead.VisibleIndex = 5;
            
            
            
            this.colPlainText.Caption = "colPlainText";
            this.colPlainText.FieldName = "PlainText";
            this.colPlainText.Name = "colPlainText";
            this.colPlainText.Visible = true;
            this.colPlainText.VisibleIndex = 3;
            
            
            
            this.colTo.Caption = "colTo";
            this.colTo.FieldName = "Email";
            this.colTo.Name = "colTo";
            this.colTo.Visible = true;
            this.colTo.VisibleIndex = 7;
            this.colTo.Width = 50;
            
            
            
            this.colPriority.Caption = "colPriority";
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Visible = true;
            this.colPriority.VisibleIndex = 6;
            
            
            
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            
            
            
            this.mailPresenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailPresenter.Location = new System.Drawing.Point(1, 0);
            this.mailPresenter.Margin = new System.Windows.Forms.Padding(4);
            this.mailPresenter.Name = "mailPresenter";
            this.mailPresenter.Size = new System.Drawing.Size(402, 565);
            this.mailPresenter.TabIndex = 4;
            
            
            
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.tileView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(386, 515);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            this.gridControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.gridControl1_ControlAdded);
            
            
            
            this.tileView.Appearance.GroupText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(50)))));
            this.tileView.Appearance.GroupText.Options.UseFont = true;
            this.tileView.Appearance.GroupText.Options.UseForeColor = true;
            this.tileView.Appearance.ItemNormal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tileView.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileView.Appearance.ItemNormal.Options.UseBorderColor = true;
            this.tileView.Appearance.ItemNormal.Options.UseFont = true;
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colFrom,
            this.colSubject,
            this.colPlainText,
            this.colSubjectDisplayText,
            this.colRead,
            this.colPriority,
            this.colTo,
            this.colFlag});
            this.tileView.ColumnSet.GroupColumn = this.colDate;
            this.tileView.ContextButtonOptions.Indent = 6;
            this.tileView.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(5, 10, 20, 5);
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton1.AppearanceHover.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            contextButton1.AppearanceHover.Options.UseFont = true;
            contextButton1.AppearanceNormal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contextButton1.AppearanceNormal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            contextButton1.AppearanceNormal.Options.UseFont = true;
            contextButton1.Id = new System.Guid("46c5197d-a771-45bb-9de8-afed5491a3c5");
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            contextButton1.Name = "cbExclamation";
            contextButton1.Padding = new System.Windows.Forms.Padding(0, -1, 0, 0);
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            checkContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            checkContextButton1.Caption = null;
            checkContextButton1.Id = new System.Guid("138952e2-c8b8-4393-b0e6-c3d082f37df5");
            checkContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            checkContextButton1.ImageOptionsCollection.ItemHovered.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(18, 18);
            checkContextButton1.Name = "cbFlag";
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton2.Id = new System.Guid("07c1aaac-55bd-4ebc-b850-93a79dede0db");
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
            contextButton2.Name = "cbRemove";
            contextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton3.Id = new System.Guid("83ef3e55-2c44-470e-acca-c4d796b1ecbd");
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
            contextButton3.Name = "cbShow";
            this.tileView.ContextButtons.Add(contextButton1);
            this.tileView.ContextButtons.Add(checkContextButton1);
            this.tileView.ContextButtons.Add(contextButton2);
            this.tileView.ContextButtons.Add(contextButton3);
            this.tileView.FocusBorderColor = System.Drawing.Color.Transparent;
            this.tileView.GridControl = this.gridControl1;
            this.tileView.Name = "tileView";
            this.tileView.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView.OptionsFind.AlwaysVisible = true;
            this.tileView.OptionsTiles.AllowItemHover = true;
            this.tileView.OptionsTiles.AllowPressAnimation = false;
            this.tileView.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(21, 10, 0, 10);
            this.tileView.OptionsTiles.HighlightFocusedTileOnGridLoad = true;
            this.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tileView.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView.OptionsTiles.IndentBetweenItems = 20;
            this.tileView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0, 8, 12, 8);
            this.tileView.OptionsTiles.ItemSize = new System.Drawing.Size(452, 71);
            this.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar;
            this.tileView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition1.Length.Value = 28D;
            tableColumnDefinition2.Length.Value = 214D;
            itemTemplate1.Columns.Add(tableColumnDefinition1);
            itemTemplate1.Columns.Add(tableColumnDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement1.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement1.Column = this.colDate;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.RowIndex = 2;
            tileViewItemElement1.Text = "colDate";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement2.Column = this.colSubjectDisplayText;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colSubjectDisplayText";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement3.Column = this.colFrom;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Text = "colFrom";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.Column = this.colRead;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Name = "readElement";
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.StretchVertical = true;
            tileViewItemElement4.Text = "colRead";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.TextVisible = false;
            tileViewItemElement4.Width = 3;
            itemTemplate1.Elements.Add(tileViewItemElement1);
            itemTemplate1.Elements.Add(tileViewItemElement2);
            itemTemplate1.Elements.Add(tileViewItemElement3);
            itemTemplate1.Elements.Add(tileViewItemElement4);
            itemTemplate1.Name = "smallsize";
            itemTemplate1.Rows.Add(tableRowDefinition1);
            itemTemplate1.Rows.Add(tableRowDefinition2);
            itemTemplate1.Rows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            itemTemplate1.Spans.Add(tableSpan1);
            tableColumnDefinition3.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition3.Length.Value = 28D;
            tableColumnDefinition4.Length.Value = 214D;
            tableColumnDefinition5.Length.Value = 171D;
            tableColumnDefinition6.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition6.Length.Value = 45D;
            tableColumnDefinition7.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition7.Length.Value = 45D;
            itemTemplate2.Columns.Add(tableColumnDefinition3);
            itemTemplate2.Columns.Add(tableColumnDefinition4);
            itemTemplate2.Columns.Add(tableColumnDefinition5);
            itemTemplate2.Columns.Add(tableColumnDefinition6);
            itemTemplate2.Columns.Add(tableColumnDefinition7);
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement5.Column = this.colDate;
            tileViewItemElement5.ColumnIndex = 4;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "colDate";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement6.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement6.Column = this.colSubjectDisplayText;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.RowIndex = 2;
            tileViewItemElement6.Text = "colSubjectDisplayText";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement7.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement7.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement7.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement7.Column = this.colPlainText;
            tileViewItemElement7.ColumnIndex = 1;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.RowIndex = 3;
            tileViewItemElement7.Text = "colPlainText";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement8.Column = this.colFrom;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.Text = "colFrom";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement9.Column = this.colRead;
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement9.Name = "readElement";
            tileViewItemElement9.RowIndex = 1;
            tileViewItemElement9.StretchVertical = true;
            tileViewItemElement9.Text = "colRead";
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement9.TextVisible = false;
            tileViewItemElement9.Width = 3;
            tileViewItemElement10.Column = this.colTo;
            tileViewItemElement10.ColumnIndex = 1;
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement10.RowIndex = 1;
            tileViewItemElement10.Text = "colTo";
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            itemTemplate2.Elements.Add(tileViewItemElement5);
            itemTemplate2.Elements.Add(tileViewItemElement6);
            itemTemplate2.Elements.Add(tileViewItemElement7);
            itemTemplate2.Elements.Add(tileViewItemElement8);
            itemTemplate2.Elements.Add(tileViewItemElement9);
            itemTemplate2.Elements.Add(tileViewItemElement10);
            itemTemplate2.Name = "tileTemplate";
            tableRowDefinition4.Length.Value = 38D;
            tableRowDefinition5.Length.Value = 25D;
            tableRowDefinition6.Length.Value = 25D;
            tableRowDefinition7.Length.Value = 25D;
            itemTemplate2.Rows.Add(tableRowDefinition4);
            itemTemplate2.Rows.Add(tableRowDefinition5);
            itemTemplate2.Rows.Add(tableRowDefinition6);
            itemTemplate2.Rows.Add(tableRowDefinition7);
            tableSpan2.ColumnIndex = 1;
            tableSpan2.ColumnSpan = 2;
            tableSpan2.RowIndex = 1;
            tableSpan3.ColumnIndex = 1;
            tableSpan3.ColumnSpan = 3;
            tableSpan4.ColumnIndex = 1;
            tableSpan4.ColumnSpan = 3;
            tableSpan4.RowIndex = 2;
            tableSpan5.ColumnIndex = 3;
            tableSpan5.ColumnSpan = 2;
            tableSpan5.RowIndex = 1;
            tableSpan6.ColumnIndex = 1;
            tableSpan6.ColumnSpan = 3;
            tableSpan6.RowIndex = 3;
            tableSpan7.RowSpan = 4;
            itemTemplate2.Spans.Add(tableSpan2);
            itemTemplate2.Spans.Add(tableSpan3);
            itemTemplate2.Spans.Add(tableSpan4);
            itemTemplate2.Spans.Add(tableSpan5);
            itemTemplate2.Spans.Add(tableSpan6);
            itemTemplate2.Spans.Add(tableSpan7);
            tableColumnDefinition8.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition8.Length.Value = 28D;
            tableColumnDefinition9.Length.Value = 214D;
            tableColumnDefinition10.Length.Value = 171D;
            tableColumnDefinition11.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition11.Length.Value = 45D;
            tableColumnDefinition12.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition12.Length.Value = 45D;
            itemTemplate3.Columns.Add(tableColumnDefinition8);
            itemTemplate3.Columns.Add(tableColumnDefinition9);
            itemTemplate3.Columns.Add(tableColumnDefinition10);
            itemTemplate3.Columns.Add(tableColumnDefinition11);
            itemTemplate3.Columns.Add(tableColumnDefinition12);
            tileViewItemElement11.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement11.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement11.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement11.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement11.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement11.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement11.Column = this.colDate;
            tileViewItemElement11.ColumnIndex = 4;
            tileViewItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement11.RowIndex = 1;
            tileViewItemElement11.Text = "colDate";
            tileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement12.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement12.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement12.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement12.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement12.Column = this.colSubjectDisplayText;
            tileViewItemElement12.ColumnIndex = 1;
            tileViewItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement12.RowIndex = 2;
            tileViewItemElement12.Text = "colSubjectDisplayText";
            tileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement13.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement13.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement13.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement13.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement13.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement13.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement13.Column = this.colPlainText;
            tileViewItemElement13.ColumnIndex = 1;
            tileViewItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement13.RowIndex = 3;
            tileViewItemElement13.Text = "colPlainText";
            tileViewItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement14.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement14.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement14.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement14.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement14.Column = this.colFrom;
            tileViewItemElement14.ColumnIndex = 2;
            tileViewItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement14.Text = "colFrom";
            tileViewItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement15.Column = this.colRead;
            tileViewItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement15.Name = "readElement";
            tileViewItemElement15.RowIndex = 1;
            tileViewItemElement15.StretchVertical = true;
            tileViewItemElement15.Text = "colRead";
            tileViewItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement15.TextVisible = false;
            tileViewItemElement15.Width = 3;
            tileViewItemElement16.Column = this.colTo;
            tileViewItemElement16.ColumnIndex = 1;
            tileViewItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement16.RowIndex = 1;
            tileViewItemElement16.Text = "colTo";
            tileViewItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            itemTemplate3.Elements.Add(tileViewItemElement11);
            itemTemplate3.Elements.Add(tileViewItemElement12);
            itemTemplate3.Elements.Add(tileViewItemElement13);
            itemTemplate3.Elements.Add(tileViewItemElement14);
            itemTemplate3.Elements.Add(tileViewItemElement15);
            itemTemplate3.Elements.Add(tileViewItemElement16);
            itemTemplate3.Name = "template2";
            tableRowDefinition8.Length.Value = 38D;
            tableRowDefinition9.Length.Value = 25D;
            tableRowDefinition10.Length.Value = 25D;
            tableRowDefinition11.Length.Value = 25D;
            itemTemplate3.Rows.Add(tableRowDefinition8);
            itemTemplate3.Rows.Add(tableRowDefinition9);
            itemTemplate3.Rows.Add(tableRowDefinition10);
            itemTemplate3.Rows.Add(tableRowDefinition11);
            tableSpan8.ColumnIndex = 1;
            tableSpan8.ColumnSpan = 2;
            tableSpan8.RowIndex = 1;
            tableSpan9.ColumnIndex = 1;
            tableSpan9.ColumnSpan = 3;
            tableSpan10.ColumnIndex = 1;
            tableSpan10.ColumnSpan = 3;
            tableSpan10.RowIndex = 2;
            tableSpan11.ColumnIndex = 3;
            tableSpan11.ColumnSpan = 2;
            tableSpan11.RowIndex = 1;
            tableSpan12.ColumnIndex = 1;
            tableSpan12.ColumnSpan = 3;
            tableSpan12.RowIndex = 3;
            tableSpan13.RowSpan = 4;
            itemTemplate3.Spans.Add(tableSpan8);
            itemTemplate3.Spans.Add(tableSpan9);
            itemTemplate3.Spans.Add(tableSpan10);
            itemTemplate3.Spans.Add(tableSpan11);
            itemTemplate3.Spans.Add(tableSpan12);
            itemTemplate3.Spans.Add(tableSpan13);
            this.tileView.Templates.Add(itemTemplate1);
            this.tileView.Templates.Add(itemTemplate2);
            this.tileView.Templates.Add(itemTemplate3);
            tableColumnDefinition13.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition13.Length.Value = 21D;
            tableColumnDefinition14.Length.Value = 179D;
            tableColumnDefinition15.Length.Value = 143D;
            tableColumnDefinition16.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition16.Length.Value = 47D;
            tableColumnDefinition17.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition17.Length.Value = 43D;
            this.tileView.TileColumns.Add(tableColumnDefinition13);
            this.tileView.TileColumns.Add(tableColumnDefinition14);
            this.tileView.TileColumns.Add(tableColumnDefinition15);
            this.tileView.TileColumns.Add(tableColumnDefinition16);
            this.tileView.TileColumns.Add(tableColumnDefinition17);
            tableRowDefinition12.Length.Value = 25D;
            tableRowDefinition13.Length.Value = 15D;
            tableRowDefinition14.Length.Value = 15D;
            this.tileView.TileRows.Add(tableRowDefinition12);
            this.tileView.TileRows.Add(tableRowDefinition13);
            this.tileView.TileRows.Add(tableRowDefinition14);
            tableSpan14.ColumnIndex = 1;
            tableSpan14.ColumnSpan = 2;
            tableSpan14.RowIndex = 1;
            tableSpan15.ColumnIndex = 1;
            tableSpan15.ColumnSpan = 3;
            tableSpan16.ColumnIndex = 3;
            tableSpan16.ColumnSpan = 2;
            tableSpan16.RowIndex = 1;
            tableSpan17.ColumnIndex = 1;
            tableSpan17.ColumnSpan = 3;
            tableSpan17.RowIndex = 2;
            tableSpan18.RowSpan = 4;
            this.tileView.TileSpans.Add(tableSpan14);
            this.tileView.TileSpans.Add(tableSpan15);
            this.tileView.TileSpans.Add(tableSpan16);
            this.tileView.TileSpans.Add(tableSpan17);
            this.tileView.TileSpans.Add(tableSpan18);
            tileViewItemElement17.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement17.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement17.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement17.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement17.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement17.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement17.Column = this.colDate;
            tileViewItemElement17.ColumnIndex = 3;
            tileViewItemElement17.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement17.RowIndex = 1;
            tileViewItemElement17.Text = "colDate";
            tileViewItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement17.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement18.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement18.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement18.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement18.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement18.Column = this.colSubjectDisplayText;
            tileViewItemElement18.ColumnIndex = 1;
            tileViewItemElement18.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement18.RowIndex = 1;
            tileViewItemElement18.Text = "colSubjectDisplayText";
            tileViewItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement19.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement19.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement19.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement19.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement19.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement19.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement19.Column = this.colPlainText;
            tileViewItemElement19.ColumnIndex = 1;
            tileViewItemElement19.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement19.RowIndex = 2;
            tileViewItemElement19.Text = "colPlainText";
            tileViewItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement20.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement20.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement20.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement20.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement20.Column = this.colFrom;
            tileViewItemElement20.ColumnIndex = 2;
            tileViewItemElement20.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement20.Text = "colFrom";
            tileViewItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement21.Column = this.colRead;
            tileViewItemElement21.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement21.Name = "readElement";
            tileViewItemElement21.RowIndex = 1;
            tileViewItemElement21.StretchVertical = true;
            tileViewItemElement21.Text = "colRead";
            tileViewItemElement21.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement21.TextLocation = new System.Drawing.Point(1, 0);
            tileViewItemElement21.TextVisible = false;
            tileViewItemElement21.Width = 5;
            this.tileView.TileTemplate.Add(tileViewItemElement17);
            this.tileView.TileTemplate.Add(tileViewItemElement18);
            this.tileView.TileTemplate.Add(tileViewItemElement19);
            this.tileView.TileTemplate.Add(tileViewItemElement20);
            this.tileView.TileTemplate.Add(tileViewItemElement21);
            this.tileView.ContextButtonCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewContextButtonCustomizeEventHandler(this.tileView_ContextButtonCustomize);
            this.tileView.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView_ItemCustomize);
            this.tileView.CustomItemTemplate += new DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(this.tileView1_CustomItemTemplate);
            
            
            
            this.colSubject.Caption = "colSubject";
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 2;
            
            
            
            this.colFlag.Caption = "colFlag";
            this.colFlag.FieldName = "Flagged";
            this.colFlag.Name = "colFlag";
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 8;
            this.colFlag.Width = 112;
            
            
            
            this.sidePanel1.Controls.Add(this.mailPresenter);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(386, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(280, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(403, 565);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            
            
            
            this.labelHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Appearance.Options.UseFont = true;
            this.labelHeader.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.AppearanceHovered.Options.UseFont = true;
            this.labelHeader.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.AppearancePressed.Options.UseFont = true;
            this.labelHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelHeader.Location = new System.Drawing.Point(19, 29);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(68, 21);
            this.labelHeader.StyleController = this.layoutControl1;
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Inbox";
            
            
            
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.Controls.Add(this.officeFilterTab);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.pnlCtrlFilter);
            this.layoutControl1.Controls.Add(this.labelHeader);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2707, 545, 975, 600);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(386, 565);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            
            
            
            this.officeFilterTab.AnimateItemPressing = false;
            this.officeFilterTab.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeFilterTab.AppearanceItem.Normal.Options.UseFont = true;
            this.officeFilterTab.AutoSize = false;
            this.officeFilterTab.BackColor = System.Drawing.Color.Transparent;
            this.officeFilterTab.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.officeFilterTab.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationItemFocused,
            this.navigationItemOther});
            this.officeFilterTab.Location = new System.Drawing.Point(87, 29);
            this.officeFilterTab.Name = "officeFilterTab";
            this.officeFilterTab.SelectedItem = this.navigationItemOther;
            this.officeFilterTab.Size = new System.Drawing.Size(125, 21);
            this.officeFilterTab.TabIndex = 7;
            this.officeFilterTab.Text = "officeNavigationBar1";
            this.officeFilterTab.ViewMode = DevExpress.XtraBars.Navigation.OfficeNavigationBarViewMode.Tab;
            
            
            
            this.navigationItemFocused.Name = "navigationItemFocused";
            this.navigationItemFocused.Text = "Focused";
            
            
            
            this.navigationItemOther.Name = "navigationItemOther";
            this.navigationItemOther.Text = "Other";
            
            
            
            this.pnlCtrlFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlCtrlFilter.Controls.Add(this.labelControl1);
            this.pnlCtrlFilter.Location = new System.Drawing.Point(319, 34);
            this.pnlCtrlFilter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCtrlFilter.Name = "pnlCtrlFilter";
            this.pnlCtrlFilter.Size = new System.Drawing.Size(62, 16);
            this.pnlCtrlFilter.TabIndex = 6;
            
            
            
            this.labelControl1.AllowFocus = false;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearanceHovered.Options.UseFont = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.AutoSize = true;
            this.labelControl1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.labelControl1.DropDownControl = this.popupMenu;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Filter";
            
            
            
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcFilterAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcFilterUnread),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcFilterToday),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcFilterYesterday),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.popupMenu.Manager = this.barManager1;
            this.popupMenu.MenuCaption = "Filter";
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.ShowCaption = true;
            
            
            
            this.bcFilterAll.BindableChecked = true;
            this.bcFilterAll.Caption = "All";
            this.bcFilterAll.Checked = true;
            this.bcFilterAll.GroupIndex = 22;
            this.bcFilterAll.Id = 1;
            this.bcFilterAll.Name = "bcFilterAll";
            
            
            
            this.bcFilterUnread.Caption = "Unread";
            this.bcFilterUnread.GroupIndex = 22;
            this.bcFilterUnread.Id = 2;
            this.bcFilterUnread.Name = "bcFilterUnread";
            
            
            
            this.bcFilterToday.Caption = "Today";
            this.bcFilterToday.GroupIndex = 22;
            this.bcFilterToday.Id = 4;
            this.bcFilterToday.Name = "bcFilterToday";
            
            
            
            this.bcFilterYesterday.Caption = "Yesterday";
            this.bcFilterYesterday.GroupIndex = 22;
            this.bcFilterYesterday.Id = 5;
            this.bcFilterYesterday.Name = "bcFilterYesterday";
            
            
            
            this.barSubItem1.Caption = "Sort By";
            this.barSubItem1.Id = 6;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biSortDate),
            new DevExpress.XtraBars.LinkPersistInfo(this.biSortFrom),
            new DevExpress.XtraBars.LinkPersistInfo(this.biSortRead),
            new DevExpress.XtraBars.LinkPersistInfo(this.biSortSubject)});
            this.barSubItem1.Name = "barSubItem1";
            
            
            
            this.biSortDate.Caption = "Date";
            this.biSortDate.Id = 7;
            this.biSortDate.Name = "biSortDate";
            
            
            
            this.biSortFrom.Caption = "From";
            this.biSortFrom.Id = 8;
            this.biSortFrom.Name = "biSortFrom";
            
            
            
            this.biSortRead.Caption = "To";
            this.biSortRead.Id = 9;
            this.biSortRead.Name = "biSortRead";
            
            
            
            this.biSortSubject.Caption = "Subject";
            this.biSortSubject.Id = 11;
            this.biSortSubject.Name = "biSortSubject";
            
            
            
            this.barManager1.AllowGlyphSkinning = true;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection2;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.bcFilterAll,
            this.bcFilterUnread,
            this.bcFilterImportance,
            this.bcFilterToday,
            this.bcFilterYesterday,
            this.barSubItem1,
            this.biSortDate,
            this.biSortFrom,
            this.biSortRead,
            this.barSubItem2,
            this.biSortSubject,
            this.biSortImportance});
            this.barManager1.MaxItemId = 13;
            
            
            
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(789, 0);
            
            
            
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(789, 0);
            
            
            
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 565);
            
            
            
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(789, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 565);
            
            
            
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.InsertGalleryImage("sortdesc_16x16.png", "grayscaleimages/data/sortdesc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/data/sortdesc_16x16.png"), 0);
            this.imageCollection2.Images.SetKeyName(0, "sortdesc_16x16.png");
            this.imageCollection2.InsertGalleryImage("sortasc_16x16.png", "grayscaleimages/data/sortasc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/data/sortasc_16x16.png"), 1);
            this.imageCollection2.Images.SetKeyName(1, "sortasc_16x16.png");
            
            
            
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            
            
            
            this.bcFilterImportance.Caption = "Important";
            this.bcFilterImportance.GroupIndex = 22;
            this.bcFilterImportance.Id = 3;
            this.bcFilterImportance.Name = "bcFilterImportance";
            
            
            
            this.barSubItem2.Caption = "Show As";
            this.barSubItem2.Id = 10;
            this.barSubItem2.Name = "barSubItem2";
            
            
            
            this.biSortImportance.Caption = "Importance";
            this.biSortImportance.Id = 12;
            this.biSortImportance.Name = "biSortImportance";
            
            
            
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.lciFilter,
            this.layoutControlItem1,
            this.lciHeader,
            this.lciTabFilter,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(386, 565);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(214, 19);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(100, 30);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.emptySpaceItem2.Size = new System.Drawing.Size(100, 31);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.lciFilter.Control = this.pnlCtrlFilter;
            this.lciFilter.Location = new System.Drawing.Point(314, 19);
            this.lciFilter.MaxSize = new System.Drawing.Size(72, 32);
            this.lciFilter.MinSize = new System.Drawing.Size(72, 30);
            this.lciFilter.Name = "lciFilter";
            this.lciFilter.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 15, 0);
            this.lciFilter.Size = new System.Drawing.Size(72, 31);
            this.lciFilter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFilter.TextSize = new System.Drawing.Size(0, 0);
            this.lciFilter.TextVisible = false;
            
            
            
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 39);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(386, 515);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            
            
            
            this.lciHeader.Control = this.labelHeader;
            this.lciHeader.Location = new System.Drawing.Point(0, 19);
            this.lciHeader.MinSize = new System.Drawing.Size(37, 30);
            this.lciHeader.Name = "lciHeader";
            this.lciHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(19, 0, 10, 0);
            this.lciHeader.Size = new System.Drawing.Size(87, 31);
            this.lciHeader.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciHeader.TextSize = new System.Drawing.Size(0, 0);
            this.lciHeader.TextVisible = false;
            this.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            
            
            
            this.lciTabFilter.Control = this.officeFilterTab;
            this.lciTabFilter.Location = new System.Drawing.Point(87, 19);
            this.lciTabFilter.MinSize = new System.Drawing.Size(2, 10);
            this.lciTabFilter.Name = "lciTabFilter";
            this.lciTabFilter.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 2, 10, 0);
            this.lciTabFilter.Size = new System.Drawing.Size(127, 31);
            this.lciTabFilter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTabFilter.TextSize = new System.Drawing.Size(0, 0);
            this.lciTabFilter.TextVisible = false;
            
            
            
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(386, 19);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(386, 19);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0);
            this.emptySpaceItem1.Size = new System.Drawing.Size(386, 19);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.notificationManager.ApplicationId = "devenv";
            this.notificationManager.ApplicationName = "DevExpress.WindowsMailClient.Win";
            this.notificationManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("83c29859-c050-402c-8f28-081d0f3de154", null, null, null, null, null, null, "Test notification", "Test notification body", "Test notification body 2", null, DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Long, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic)});
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MailViewer";
            this.Size = new System.Drawing.Size(789, 565);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFilterTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlFilter)).EndInit();
            this.pnlCtrlFilter.ResumeLayout(false);
            this.pnlCtrlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private MailPresenter mailPresenter;
        private GridControl gridControl1;
        private ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDate;
        private TileViewColumn colFrom;
        private TileViewColumn colSubject;
        private TileViewColumn colPlainText;
        private TileViewColumn colSubjectDisplayText;
        private TileViewColumn colRead;
        private TileViewColumn colPriority;
        private SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelHeader;
        private DropDownButton labelControl1;
        private BarManager barManager1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarCheckItem bcFilterAll;
        private DevExpress.XtraBars.BarCheckItem bcFilterUnread;
        private DevExpress.XtraBars.BarCheckItem bcFilterImportance;
        private DevExpress.XtraBars.BarCheckItem bcFilterToday;
        private DevExpress.XtraBars.BarCheckItem bcFilterYesterday;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private BarButtonItem biSortDate;
        private BarButtonItem biSortFrom;
        private BarButtonItem biSortRead;
        private BarButtonItem barButtonItem1;
        private BarSubItem barSubItem2;
        private BarButtonItem biSortSubject;
        private BarButtonItem biSortImportance;
        private ImageCollection imageCollection2;
        private TileViewColumn colTo;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private EmptySpaceItem emptySpaceItem2;
        private LayoutControlItem lciHeader;
        private PanelControl pnlCtrlFilter;
        private LayoutControlItem lciFilter;
        private XtraBars.ToastNotifications.ToastNotificationsManager notificationManager;
        DevExpress.Utils.ContextButton contextButton1; 
        DevExpress.Utils.CheckContextButton checkContextButton1;
        DevExpress.Utils.ContextButton contextButton2;
        DevExpress.Utils.ContextButton contextButton3;
        private TileViewColumn colFlag;
        private XtraBars.Navigation.OfficeNavigationBar officeFilterTab;
        private LayoutControlItem lciTabFilter;
        private XtraBars.Navigation.NavigationBarItem navigationItemFocused;
        private XtraBars.Navigation.NavigationBarItem navigationItemOther;
        private LayoutControlItem layoutControlItem1;
        private EmptySpaceItem emptySpaceItem1;
    }
}
