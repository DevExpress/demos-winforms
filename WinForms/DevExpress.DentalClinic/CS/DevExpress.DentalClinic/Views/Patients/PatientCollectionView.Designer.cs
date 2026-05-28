namespace DevExpress.DentalClinic.View {
    partial class PatientCollectionView {
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.Drawing.StubGlyphOptions stubGlyphOptions1 = new DevExpress.Utils.Drawing.StubGlyphOptions();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.gvProcedures = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryHyperLinkNavigateScheduller = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPatients = new DevExpress.XtraGrid.GridControl();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryHyperlinkCall = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colLastVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.sbAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.sbRemovePatient = new DevExpress.XtraEditors.SimpleButton();
            this.sbEditPatient = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHyperLinkNavigateScheduller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHyperlinkCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProcedures
            // 
            this.gvProcedures.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvProcedures.ColumnPanelRowHeight = 30;
            this.gvProcedures.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colDoctorName,
            this.colVisitTime,
            this.colPrice});
            this.gvProcedures.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvProcedures.GridControl = this.gcPatients;
            this.gvProcedures.GroupFormat = "{1} {2}";
            this.gvProcedures.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", this.colPrice, "SUM: {0:c}")});
            this.gvProcedures.Name = "gvProcedures";
            this.gvProcedures.OptionsView.AllowCellMerge = true;
            this.gvProcedures.OptionsView.ShowFooter = true;
            this.gvProcedures.OptionsView.ShowGroupPanel = false;
            this.gvProcedures.OptionsView.ShowIndicator = false;
            this.gvProcedures.RowHeight = 30;
            this.gvProcedures.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVisitTime, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvProcedures.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gvProcedures_CellMerge);
            this.gvProcedures.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvProcedures_CustomColumnSort);
            this.gvProcedures.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvProcedures_CustomColumnDisplayText);
            this.gvProcedures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvProcedures_MouseDown);
            // 
            // colName1
            // 
            this.colName1.Caption = "Procedure";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowEdit = false;
            this.colName1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            this.colName1.Width = 530;
            // 
            // colDoctorName
            // 
            this.colDoctorName.Caption = "Doctor";
            this.colDoctorName.FieldName = "DoctorName";
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.OptionsColumn.AllowEdit = false;
            this.colDoctorName.Visible = true;
            this.colDoctorName.VisibleIndex = 1;
            this.colDoctorName.Width = 153;
            // 
            // colVisitTime
            // 
            this.colVisitTime.ColumnEdit = this.repositoryHyperLinkNavigateScheduller;
            this.colVisitTime.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
            this.colVisitTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVisitTime.FieldName = "VisitTime";
            this.colVisitTime.GroupFormat.FormatString = "dd MMMM yyyy";
            this.colVisitTime.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVisitTime.Name = "colVisitTime";
            this.colVisitTime.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colVisitTime.Visible = true;
            this.colVisitTime.VisibleIndex = 0;
            this.colVisitTime.Width = 233;
            // 
            // repositoryHyperLinkNavigateScheduller
            // 
            this.repositoryHyperLinkNavigateScheduller.AutoHeight = false;
            this.repositoryHyperLinkNavigateScheduller.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
            this.repositoryHyperLinkNavigateScheduller.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryHyperLinkNavigateScheduller.Name = "repositoryHyperLinkNavigateScheduller";
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "c";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "SUM={0:c}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 166;
            // 
            // gcPatients
            // 
            this.gcPatients.DataSource = this.patientsBindingSource;
            gridLevelNode1.LevelTemplate = this.gvProcedures;
            gridLevelNode1.RelationName = "Procedures";
            this.gcPatients.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPatients.Location = new System.Drawing.Point(0, 37);
            this.gcPatients.MainView = this.gvPatients;
            this.gcPatients.Name = "gcPatients";
            this.gcPatients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryHyperlinkCall,
            this.repositoryHyperLinkNavigateScheduller});
            this.gcPatients.Size = new System.Drawing.Size(1333, 798);
            this.gcPatients.TabIndex = 2;
            this.gcPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients,
            this.gvProcedures});
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(DevExpress.DentalClinic.ViewModel.PatientInfo);
            // 
            // gvPatients
            // 
            this.gvPatients.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPatients.ColumnPanelRowHeight = 30;
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPhone,
            this.colLastVisit,
            this.colNextVisit,
            this.colStatus});
            this.gvPatients.DetailHeight = 227;
            this.gvPatients.FixedLineWidth = 1;
            this.gvPatients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvPatients.GridControl = this.gcPatients;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gvPatients.OptionsDetail.ShowDetailTabs = false;
            this.gvPatients.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.False;
            this.gvPatients.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPatients.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvPatients.OptionsView.ShowGroupPanel = false;
            this.gvPatients.OptionsView.ShowIndicator = false;
            this.gvPatients.RowHeight = 30;
            this.gvPatients.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNextVisit, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPatients.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.OnGridViewCustomDrawCell);
            this.gvPatients.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPatients_PopupMenuShowing);
            this.gvPatients.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvPatients_CustomColumnDisplayText);
            // 
            // colName
            // 
            stubGlyphOptions1.CaseMode = DevExpress.Utils.Drawing.GlyphTextCaseMode.UpperCase;
            stubGlyphOptions1.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.White;
            stubGlyphOptions1.LetterCount = DevExpress.Utils.Drawing.GlyphTextSymbolCount.Two;
            stubGlyphOptions1.RandomizeColors = false;
            this.behaviorManager1.SetBehaviors(this.colName, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(typeof(DevExpress.XtraGrid.Views.Grid.BehaviorSource.StubGlyphBehaviorSourceForGridColumn), stubGlyphOptions1, new System.Drawing.Size(24, 24))))});
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 250;
            // 
            // colPhone
            // 
            this.colPhone.ColumnEdit = this.repositoryHyperlinkCall;
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 1;
            this.colPhone.Width = 150;
            // 
            // repositoryHyperlinkCall
            // 
            this.repositoryHyperlinkCall.AutoHeight = false;
            this.repositoryHyperlinkCall.Name = "repositoryHyperlinkCall";
            this.repositoryHyperlinkCall.SingleClick = true;
            // 
            // colLastVisit
            // 
            this.colLastVisit.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
            this.colLastVisit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastVisit.FieldName = "LastVisit";
            this.colLastVisit.Name = "colLastVisit";
            this.colLastVisit.OptionsColumn.AllowEdit = false;
            this.colLastVisit.Visible = true;
            this.colLastVisit.VisibleIndex = 2;
            this.colLastVisit.Width = 260;
            // 
            // colNextVisit
            // 
            this.colNextVisit.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
            this.colNextVisit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNextVisit.FieldName = "NextVisit";
            this.colNextVisit.Name = "colNextVisit";
            this.colNextVisit.OptionsColumn.AllowEdit = false;
            this.colNextVisit.Visible = true;
            this.colNextVisit.VisibleIndex = 3;
            this.colNextVisit.Width = 260;
            // 
            // colStatus
            // 
            this.colStatus.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            this.colStatus.Width = 162;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemImageComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemImageComboBox1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.MouseLeave += new System.EventHandler(this.OnRepositoryItemImageComboBoxMouseLeave);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.sbAddPatient);
            this.layoutControl1.Controls.Add(this.gcPatients);
            this.layoutControl1.Controls.Add(this.sbRemovePatient);
            this.layoutControl1.Controls.Add(this.sbEditPatient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1333, 835);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcPatients;
            this.searchControl1.Location = new System.Drawing.Point(8, 1);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchControl1.MaximumSize = new System.Drawing.Size(0, 30);
            this.searchControl1.MinimumSize = new System.Drawing.Size(0, 30);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcPatients;
            this.searchControl1.Size = new System.Drawing.Size(1078, 30);
            this.searchControl1.StyleController = this.layoutControl1;
            this.searchControl1.TabIndex = 4;
            // 
            // sbAddPatient
            // 
            this.sbAddPatient.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.sbAddPatient.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.sbAddPatient.Appearance.Options.UseBackColor = true;
            this.sbAddPatient.Appearance.Options.UseFont = true;
            this.sbAddPatient.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.sbAddPatient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbAddPatient.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.AddPatient;
            this.sbAddPatient.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbAddPatient.Location = new System.Drawing.Point(1164, 1);
            this.sbAddPatient.MaximumSize = new System.Drawing.Size(150, 30);
            this.sbAddPatient.MinimumSize = new System.Drawing.Size(150, 30);
            this.sbAddPatient.Name = "sbAddPatient";
            this.sbAddPatient.Size = new System.Drawing.Size(150, 30);
            this.sbAddPatient.StyleController = this.layoutControl1;
            this.sbAddPatient.TabIndex = 0;
            this.sbAddPatient.Text = "Add Patient";
            // 
            // sbRemovePatient
            // 
            this.sbRemovePatient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbRemovePatient.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Delete;
            this.sbRemovePatient.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbRemovePatient.Location = new System.Drawing.Point(1128, 1);
            this.sbRemovePatient.MaximumSize = new System.Drawing.Size(30, 30);
            this.sbRemovePatient.MinimumSize = new System.Drawing.Size(30, 30);
            this.sbRemovePatient.Name = "sbRemovePatient";
            this.sbRemovePatient.Size = new System.Drawing.Size(30, 30);
            this.sbRemovePatient.StyleController = this.layoutControl1;
            toolTipItem1.Text = "Remove";
            superToolTip1.Items.Add(toolTipItem1);
            this.sbRemovePatient.SuperTip = superToolTip1;
            this.sbRemovePatient.TabIndex = 5;
            this.sbRemovePatient.Text = "Remove";
            // 
            // sbEditPatient
            // 
            this.sbEditPatient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbEditPatient.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.EditPatient;
            this.sbEditPatient.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbEditPatient.Location = new System.Drawing.Point(1092, 1);
            this.sbEditPatient.MaximumSize = new System.Drawing.Size(30, 30);
            this.sbEditPatient.MinimumSize = new System.Drawing.Size(30, 30);
            this.sbEditPatient.Name = "sbEditPatient";
            this.sbEditPatient.Size = new System.Drawing.Size(30, 30);
            this.sbEditPatient.StyleController = this.layoutControl1;
            toolTipItem2.Text = "Edit...";
            superToolTip2.Items.Add(toolTipItem2);
            this.sbEditPatient.SuperTip = superToolTip2;
            this.sbEditPatient.TabIndex = 6;
            this.sbEditPatient.Text = "Edit...";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1333, 835);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPatients;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(1333, 798);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAddPatient;
            this.layoutControlItem2.Location = new System.Drawing.Point(1161, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 19, 1, 1);
            this.layoutControlItem2.Size = new System.Drawing.Size(172, 37);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 3, 1, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(1089, 37);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbRemovePatient;
            this.layoutControlItem4.Location = new System.Drawing.Point(1125, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 1, 1);
            this.layoutControlItem4.Size = new System.Drawing.Size(36, 37);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbEditPatient;
            this.layoutControlItem5.Location = new System.Drawing.Point(1089, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 1, 1);
            this.layoutControlItem5.Size = new System.Drawing.Size(36, 37);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.PatientCollectionViewModel);
            // 
            // PatientCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientCollectionView";
            this.Size = new System.Drawing.Size(1333, 835);
            ((System.ComponentModel.ISupportInitialize)(this.gvProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHyperLinkNavigateScheduller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHyperlinkCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl gcPatients;
        private XtraGrid.Views.Grid.GridView gvPatients;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.SimpleButton sbAddPatient;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private XtraGrid.Columns.GridColumn colName;
        private XtraGrid.Columns.GridColumn colPhone;
        private XtraGrid.Columns.GridColumn colLastVisit;
        private XtraGrid.Columns.GridColumn colNextVisit;
        private XtraGrid.Columns.GridColumn colStatus;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraEditors.SearchControl searchControl1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.SimpleButton sbRemovePatient;
        private XtraEditors.SimpleButton sbEditPatient;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraGrid.Views.Grid.GridView gvProcedures;
        private XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryHyperlinkCall;
        private XtraGrid.Columns.GridColumn colName1;
        private XtraGrid.Columns.GridColumn colDoctorName;
        private XtraGrid.Columns.GridColumn colVisitTime;
        private XtraGrid.Columns.GridColumn colPrice;
        private XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryHyperLinkNavigateScheduller;
    }
}
