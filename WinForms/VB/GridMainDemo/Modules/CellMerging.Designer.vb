Namespace DevExpress.XtraGrid.Demos

    Partial Class CellMerging

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.CellMerging))
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.panel1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.icbEditMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceMerging = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ceMergingitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
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
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.panel1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.icbEditMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMerging.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMergingitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsIssueList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.panel1layoutControl1ConvertedLayout
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' panel1layoutControl1ConvertedLayout
            ' 
            Me.panel1layoutControl1ConvertedLayout.AllowCustomization = False
            Me.panel1layoutControl1ConvertedLayout.Controls.Add(Me.icbEditMode)
            Me.panel1layoutControl1ConvertedLayout.Controls.Add(Me.simpleButton1)
            Me.panel1layoutControl1ConvertedLayout.Controls.Add(Me.ceMerging)
            resources.ApplyResources(Me.panel1layoutControl1ConvertedLayout, "panel1layoutControl1ConvertedLayout")
            Me.panel1layoutControl1ConvertedLayout.Name = "panel1layoutControl1ConvertedLayout"
            Me.panel1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(4999, 1601, 650, 400)
            Me.panel1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            ' 
            ' icbEditMode
            ' 
            resources.ApplyResources(Me.icbEditMode, "icbEditMode")
            Me.icbEditMode.Name = "icbEditMode"
            Me.icbEditMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbEditMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbEditMode.StyleController = Me.panel1layoutControl1ConvertedLayout
            AddHandler Me.icbEditMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbEditMode_SelectedIndexChanged)
            ' 
            ' ceMerging
            ' 
            resources.ApplyResources(Me.ceMerging, "ceMerging")
            Me.ceMerging.Name = "ceMerging"
            Me.ceMerging.Properties.Caption = resources.GetString("ceMerging.Properties.Caption")
            Me.ceMerging.StyleController = Me.panel1layoutControl1ConvertedLayout
            AddHandler Me.ceMerging.CheckedChanged, New System.EventHandler(AddressOf Me.ceMerging_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 399)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 158)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 241)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ceMergingitem, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 90)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' ceMergingitem
            ' 
            Me.ceMergingitem.Control = Me.ceMerging
            Me.ceMergingitem.Location = New System.Drawing.Point(0, 0)
            Me.ceMergingitem.Name = "ceMergingitem"
            Me.ceMergingitem.Size = New System.Drawing.Size(229, 24)
            Me.ceMergingitem.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbEditMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 68)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsIssueList1.Items
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3})
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
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.PreviewFieldName = "Description"
            AddHandler Me.gridView1.CustomColumnDisplayText, New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(AddressOf Me.gridView1_CustomColumnDisplayText)
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
            Me.colCreatedDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
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
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 432)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.panel1layoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' CellMerging
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CellMerging"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CellMerging_Load)
            CType((Me.panel1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.icbEditMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMerging.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMergingitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsIssueList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ceMerging As DevExpress.XtraEditors.CheckEdit

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

        Private components As System.ComponentModel.IContainer

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private panel1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ceMergingitem As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private icbEditMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
