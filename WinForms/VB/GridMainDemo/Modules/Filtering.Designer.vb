Namespace DevExpress.XtraGrid.Demos

    Partial Class Filtering

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.Filtering))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsIssueList1 = New DevExpress.XtraGrid.Demos.dsIssueList()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOwnerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colFixedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatorID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ceAllowFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbInfo = New DevExpress.XtraEditors.SimpleButton()
            Me.ceColumnFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterEditor = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAdvDialog = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsIssueList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceColumnFilterList.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFilterEditor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFilterList.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAdvDialog.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsIssueList1.Items
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3})
            Me.gridControl1.Tag = "Design"
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' dsIssueList1
            ' 
            Me.dsIssueList1.DataSetName = "dsIssueList"
            Me.dsIssueList1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsIssueList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProjectID, Me.colType, Me.colName, Me.colPriority, Me.colStatus, Me.colCreatedDate, Me.colOwnerID, Me.colFixedDate, Me.colCreatorID, Me.colModifiedDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic
            Me.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.PreviewFieldName = "Description"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPriority, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView1_PopupMenuShowing)
            AddHandler Me.gridView1.ColumnFilterChanged, New System.EventHandler(AddressOf Me.gridView1_ColumnFilterChanged)
            ' 
            ' colProjectID
            ' 
            resources.ApplyResources(Me.colProjectID, "colProjectID")
            Me.colProjectID.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colProjectID.FieldName = "ProjectID"
            Me.colProjectID.Name = "colProjectID"
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"), (CInt((resources.GetObject("repositoryItemLookUpEdit1.Columns2")))), CType((resources.GetObject("repositoryItemLookUpEdit1.Columns3")), DevExpress.Utils.FormatType), resources.GetString("repositoryItemLookUpEdit1.Columns4"), (CBool((resources.GetObject("repositoryItemLookUpEdit1.Columns5")))), CType((resources.GetObject("repositoryItemLookUpEdit1.Columns6")), DevExpress.Utils.HorzAlignment), CType((resources.GetObject("repositoryItemLookUpEdit1.Columns7")), DevExpress.Data.ColumnSortOrder), CType((resources.GetObject("repositoryItemLookUpEdit1.Columns8")), DevExpress.Utils.DefaultBoolean))})
            Me.repositoryItemLookUpEdit1.DataSource = Me.dsIssueList1.Projects
            Me.repositoryItemLookUpEdit1.DisplayMember = "Name"
            Me.repositoryItemLookUpEdit1.DropDownRows = 3
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 200
            Me.repositoryItemLookUpEdit1.ShowFooter = False
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "ID"
            ' 
            ' colType
            ' 
            resources.ApplyResources(Me.colType, "colType")
            Me.colType.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.colType.FieldName = "Type"
            Me.colType.Name = "colType"
            ' 
            ' repositoryItemImageComboBox3
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox3.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items5")))))})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.svgImageCollection1
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("bugreport", CType((resources.GetObject("svgImageCollection1.bugreport")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("task", CType((resources.GetObject("svgImageCollection1.task")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("new", CType((resources.GetObject("svgImageCollection1.new")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("postponed", CType((resources.GetObject("svgImageCollection1.postponed")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("fixed", CType((resources.GetObject("svgImageCollection1.fixed")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("rejected", CType((resources.GetObject("svgImageCollection1.rejected")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("low", CType((resources.GetObject("svgImageCollection1.low")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("medium", CType((resources.GetObject("svgImageCollection1.medium")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("high", CType((resources.GetObject("svgImageCollection1.high")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' colName
            ' 
            resources.ApplyResources(Me.colName, "colName")
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colName.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colPriority
            ' 
            resources.ApplyResources(Me.colPriority, "colPriority")
            Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colPriority.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            ' 
            ' repositoryItemImageComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items8")))))})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.svgImageCollection1
            ' 
            ' colStatus
            ' 
            resources.ApplyResources(Me.colStatus, "colStatus")
            Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items10")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items11")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' colCreatedDate
            ' 
            resources.ApplyResources(Me.colCreatedDate, "colCreatedDate")
            Me.colCreatedDate.FieldName = "CreatedDate"
            Me.colCreatedDate.Name = "colCreatedDate"
            Me.colCreatedDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colCreatedDate.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colCreatedDate.Summary1"), resources.GetString("colCreatedDate.Summary2"))})
            ' 
            ' colOwnerID
            ' 
            resources.ApplyResources(Me.colOwnerID, "colOwnerID")
            Me.colOwnerID.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colOwnerID.FieldName = "OwnerID"
            Me.colOwnerID.Name = "colOwnerID"
            ' 
            ' repositoryItemLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2")
            Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"), (CInt((resources.GetObject("repositoryItemLookUpEdit2.Columns2")))), CType((resources.GetObject("repositoryItemLookUpEdit2.Columns3")), DevExpress.Utils.FormatType), resources.GetString("repositoryItemLookUpEdit2.Columns4"), (CBool((resources.GetObject("repositoryItemLookUpEdit2.Columns5")))), CType((resources.GetObject("repositoryItemLookUpEdit2.Columns6")), DevExpress.Utils.HorzAlignment), CType((resources.GetObject("repositoryItemLookUpEdit2.Columns7")), DevExpress.Data.ColumnSortOrder), CType((resources.GetObject("repositoryItemLookUpEdit2.Columns8")), DevExpress.Utils.DefaultBoolean))})
            Me.repositoryItemLookUpEdit2.DataSource = Me.dsIssueList1.Users
            Me.repositoryItemLookUpEdit2.DisplayMember = "FullName"
            Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
            Me.repositoryItemLookUpEdit2.ShowFooter = False
            Me.repositoryItemLookUpEdit2.ShowHeader = False
            Me.repositoryItemLookUpEdit2.ValueMember = "ID"
            ' 
            ' colFixedDate
            ' 
            resources.ApplyResources(Me.colFixedDate, "colFixedDate")
            Me.colFixedDate.FieldName = "FixedDate"
            Me.colFixedDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colFixedDate.Name = "colFixedDate"
            ' 
            ' colCreatorID
            ' 
            resources.ApplyResources(Me.colCreatorID, "colCreatorID")
            Me.colCreatorID.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colCreatorID.FieldName = "CreatorID"
            Me.colCreatorID.Name = "colCreatorID"
            ' 
            ' colModifiedDate
            ' 
            resources.ApplyResources(Me.colModifiedDate, "colModifiedDate")
            Me.colModifiedDate.FieldName = "ModifiedDate"
            Me.colModifiedDate.Name = "colModifiedDate"
            ' 
            ' ceAllowFilter
            ' 
            resources.ApplyResources(Me.ceAllowFilter, "ceAllowFilter")
            Me.ceAllowFilter.Name = "ceAllowFilter"
            Me.ceAllowFilter.Properties.Appearance.Font = CType((resources.GetObject("ceAllowFilter.Properties.Appearance.Font")), System.Drawing.Font)
            Me.ceAllowFilter.Properties.Appearance.Options.UseFont = True
            Me.ceAllowFilter.Properties.Caption = resources.GetString("ceAllowFilter.Properties.Caption")
            Me.ceAllowFilter.StyleController = Me.layoutControl1
            AddHandler Me.ceAllowFilter.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowFilter_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbInfo)
            Me.layoutControl1.Controls.Add(Me.ceAllowFilter)
            Me.layoutControl1.Controls.Add(Me.ceColumnFilterList)
            Me.layoutControl1.Controls.Add(Me.ceFilterEditor)
            Me.layoutControl1.Controls.Add(Me.ceFilterList)
            Me.layoutControl1.Controls.Add(Me.ceAdvDialog)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbInfo
            ' 
            resources.ApplyResources(Me.sbInfo, "sbInfo")
            Me.sbInfo.Name = "sbInfo"
            Me.sbInfo.StyleController = Me.layoutControl1
            AddHandler Me.sbInfo.Click, New System.EventHandler(AddressOf Me.sbInfo_Click)
            AddHandler Me.sbInfo.Leave, New System.EventHandler(AddressOf Me.sbInfo_Leave)
            AddHandler Me.sbInfo.MouseLeave, New System.EventHandler(AddressOf Me.sbInfo_Leave)
            ' 
            ' ceColumnFilterList
            ' 
            resources.ApplyResources(Me.ceColumnFilterList, "ceColumnFilterList")
            Me.ceColumnFilterList.Name = "ceColumnFilterList"
            Me.ceColumnFilterList.Properties.Caption = resources.GetString("ceColumnFilterList.Properties.Caption")
            Me.ceColumnFilterList.StyleController = Me.layoutControl1
            AddHandler Me.ceColumnFilterList.CheckedChanged, New System.EventHandler(AddressOf Me.ceColumnFilterList_CheckedChanged)
            ' 
            ' ceFilterEditor
            ' 
            resources.ApplyResources(Me.ceFilterEditor, "ceFilterEditor")
            Me.ceFilterEditor.Name = "ceFilterEditor"
            Me.ceFilterEditor.Properties.Caption = resources.GetString("ceFilterEditor.Properties.Caption")
            Me.ceFilterEditor.StyleController = Me.layoutControl1
            AddHandler Me.ceFilterEditor.CheckedChanged, New System.EventHandler(AddressOf Me.ceFilterEditor_CheckedChanged)
            ' 
            ' ceFilterList
            ' 
            resources.ApplyResources(Me.ceFilterList, "ceFilterList")
            Me.ceFilterList.Name = "ceFilterList"
            Me.ceFilterList.Properties.Caption = resources.GetString("ceFilterList.Properties.Caption")
            Me.ceFilterList.StyleController = Me.layoutControl1
            AddHandler Me.ceFilterList.CheckedChanged, New System.EventHandler(AddressOf Me.ceFilterList_CheckedChanged)
            ' 
            ' ceAdvDialog
            ' 
            resources.ApplyResources(Me.ceAdvDialog, "ceAdvDialog")
            Me.ceAdvDialog.Name = "ceAdvDialog"
            Me.ceAdvDialog.Properties.Caption = resources.GetString("ceAdvDialog.Properties.Caption")
            Me.ceAdvDialog.StyleController = Me.layoutControl1
            AddHandler Me.ceAdvDialog.CheckedChanged, New System.EventHandler(AddressOf Me.ceAdvDialog_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2, Me.emptySpaceItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 459)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAllowFilter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 130)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(229, 283)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceFilterEditor
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(229, 10)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceAdvDialog
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceFilterList
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceColumnFilterList
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 106)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.sbInfo
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 413)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AllowHtmlText = True
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Standard
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 492)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' Filtering
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "Filtering"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Filtering_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsIssueList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceColumnFilterList.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFilterEditor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFilterList.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAdvDialog.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colProjectID As DevExpress.XtraGrid.Columns.GridColumn

        Private colType As DevExpress.XtraGrid.Columns.GridColumn

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colPriority As DevExpress.XtraGrid.Columns.GridColumn

        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn

        Private colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colOwnerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colFixedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colCreatorID As DevExpress.XtraGrid.Columns.GridColumn

        Private colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private dsIssueList1 As DevExpress.XtraGrid.Demos.dsIssueList

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private sbInfo As DevExpress.XtraEditors.SimpleButton

        Private ceAllowFilter As DevExpress.XtraEditors.CheckEdit

        Private ceColumnFilterList As DevExpress.XtraEditors.CheckEdit

        Private ceFilterList As DevExpress.XtraEditors.CheckEdit

        Private ceAdvDialog As DevExpress.XtraEditors.CheckEdit

        Private ceFilterEditor As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
