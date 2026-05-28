Namespace DevExpress.XtraGrid.Demos

    Partial Class FixedColumns

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.FixedColumns))
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.numFixedLineWidth1 = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbMiddleColumns = New DevExpress.XtraEditors.SimpleButton()
            Me.icbFixedColumnHighlightMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbFixedStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbColumn = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciFixedLineWidth = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numFixedLineWidth1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbFixedColumnHighlightMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbFixedStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbColumn.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciFixedLineWidth), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl2
            ' 
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.MainView = Me.gridView1
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox1, Me.repositoryItemComboBox2})
            Me.gridControl2.ShowOnlyPredefinedDetails = True
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
            Me.gridView1.GridControl = Me.gridControl2
            Me.gridView1.GroupCount = 1
            Me.gridView1.HorzScrollStep = 30
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsPrint.AutoWidth = False
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.FixedColumnHighlightMode = DevExpress.XtraGrid.Views.Grid.GridFixedColumnHighlightMode.Line
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colContactTitle, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView1_PopupMenuShowing)
            ' 
            ' colCustomerID
            ' 
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.OptionsFilter.AllowFilter = False
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.ImageOptions.ImageIndex =(CInt((resources.GetObject("colCompanyName.ImageOptions.ImageIndex"))))
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colCompanyName.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.ImageOptions.ImageIndex =(CInt((resources.GetObject("colContactName.ImageOptions.ImageIndex"))))
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Address"
            Me.colAddress.ImageOptions.ImageIndex =(CInt((resources.GetObject("colAddress.ImageOptions.ImageIndex"))))
            Me.colAddress.Name = "colAddress"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.ImageOptions.ImageIndex =(CInt((resources.GetObject("colCity.ImageOptions.ImageIndex"))))
            Me.colCity.Name = "colCity"
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.ColumnEdit = Me.repositoryItemComboBox1
            Me.colRegion.FieldName = "Region"
            Me.colRegion.ImageOptions.ImageIndex =(CInt((resources.GetObject("colRegion.ImageOptions.ImageIndex"))))
            Me.colRegion.Name = "colRegion"
            ' 
            ' repositoryItemComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17")})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.ImageOptions.ImageIndex =(CInt((resources.GetObject("colPostalCode.ImageOptions.ImageIndex"))))
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCountry.FieldName = "Country"
            Me.colCountry.ImageOptions.ImageIndex =(CInt((resources.GetObject("colCountry.ImageOptions.ImageIndex"))))
            Me.colCountry.Name = "colCountry"
            ' 
            ' repositoryItemComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemComboBox2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() {resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' colPhone
            ' 
            resources.ApplyResources(Me.colPhone, "colPhone")
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.ImageOptions.ImageIndex =(CInt((resources.GetObject("colPhone.ImageOptions.ImageIndex"))))
            Me.colPhone.Name = "colPhone"
            ' 
            ' colFax
            ' 
            resources.ApplyResources(Me.colFax, "colFax")
            Me.colFax.FieldName = "Fax"
            Me.colFax.ImageOptions.ImageIndex =(CInt((resources.GetObject("colFax.ImageOptions.ImageIndex"))))
            Me.colFax.Name = "colFax"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("ContactName", CType((resources.GetObject("svgImageCollection1.ContactName")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Home", CType((resources.GetObject("svgImageCollection1.Home")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Company", CType((resources.GetObject("svgImageCollection1.Company")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("NotFixed", CType((resources.GetObject("svgImageCollection1.NotFixed")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("FixedLeft", CType((resources.GetObject("svgImageCollection1.FixedLeft")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("FixedRight", CType((resources.GetObject("svgImageCollection1.FixedRight")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("City", CType((resources.GetObject("svgImageCollection1.City")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Country", CType((resources.GetObject("svgImageCollection1.Country")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Fax", CType((resources.GetObject("svgImageCollection1.Fax")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("PostalCode", CType((resources.GetObject("svgImageCollection1.PostalCode")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Region", CType((resources.GetObject("svgImageCollection1.Region")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg")
            ' 
            ' numFixedLineWidth1
            ' 
            resources.ApplyResources(Me.numFixedLineWidth1, "numFixedLineWidth1")
            Me.numFixedLineWidth1.Name = "numFixedLineWidth1"
            Me.numFixedLineWidth1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.numFixedLineWidth1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.numFixedLineWidth1.Properties.IsFloatValue = False
            Me.numFixedLineWidth1.Properties.Mask.EditMask = resources.GetString("numFixedLineWidth1.Properties.Mask.EditMask")
            Me.numFixedLineWidth1.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.numFixedLineWidth1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numFixedLineWidth1.StyleController = Me.layoutControl1
            AddHandler Me.numFixedLineWidth1.EditValueChanged, New System.EventHandler(AddressOf Me.numFixedLineWidth1_ValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbMiddleColumns)
            Me.layoutControl1.Controls.Add(Me.icbFixedColumnHighlightMode)
            Me.layoutControl1.Controls.Add(Me.icbFixedStyle)
            Me.layoutControl1.Controls.Add(Me.numFixedLineWidth1)
            Me.layoutControl1.Controls.Add(Me.icbColumn)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1152, 640, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbMiddleColumns
            ' 
            resources.ApplyResources(Me.sbMiddleColumns, "sbMiddleColumns")
            Me.sbMiddleColumns.Name = "sbMiddleColumns"
            Me.sbMiddleColumns.StyleController = Me.layoutControl1
            AddHandler Me.sbMiddleColumns.Click, New System.EventHandler(AddressOf Me.sbMiddleColumns_Click)
            ' 
            ' icbFixedColumnHighlightMode
            ' 
            resources.ApplyResources(Me.icbFixedColumnHighlightMode, "icbFixedColumnHighlightMode")
            Me.icbFixedColumnHighlightMode.Name = "icbFixedColumnHighlightMode"
            Me.icbFixedColumnHighlightMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbFixedColumnHighlightMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbFixedColumnHighlightMode.StyleController = Me.layoutControl1
            AddHandler Me.icbFixedColumnHighlightMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFixedColumnHighlightMode_SelectedIndexChanged)
            ' 
            ' icbFixedStyle
            ' 
            resources.ApplyResources(Me.icbFixedStyle, "icbFixedStyle")
            Me.icbFixedStyle.Name = "icbFixedStyle"
            Me.icbFixedStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbFixedStyle.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbFixedStyle.StyleController = Me.layoutControl1
            AddHandler Me.icbFixedStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFixedStyle_SelectedIndexChanged)
            ' 
            ' icbColumn
            ' 
            resources.ApplyResources(Me.icbColumn, "icbColumn")
            Me.icbColumn.Name = "icbColumn"
            Me.icbColumn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbColumn.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbColumn.Properties.DropDownRows = 15
            Me.icbColumn.StyleController = Me.layoutControl1
            AddHandler Me.icbColumn.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbColumn_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 397)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 255)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 142)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.lciFixedLineWidth, Me.layoutControlItem4, Me.layoutControlItem3, Me.emptySpaceItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 255)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.icbColumn
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(137, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbFixedStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(137, 13)
            ' 
            ' lciFixedLineWidth
            ' 
            Me.lciFixedLineWidth.Control = Me.numFixedLineWidth1
            Me.lciFixedLineWidth.Location = New System.Drawing.Point(0, 173)
            Me.lciFixedLineWidth.Name = "lciFixedLineWidth"
            Me.lciFixedLineWidth.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.lciFixedLineWidth, "lciFixedLineWidth")
            Me.lciFixedLineWidth.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciFixedLineWidth.TextSize = New System.Drawing.Size(137, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbFixedColumnHighlightMode
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 133)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(137, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sbMiddleColumns
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 107)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 80)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 27)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(229, 27)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 430)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' FixedColumns
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "FixedColumns"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FixedColumns_Load)
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numFixedLineWidth1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbFixedColumnHighlightMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbFixedStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbColumn.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciFixedLineWidth), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhone As DevExpress.XtraGrid.Columns.GridColumn

        Private colFax As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private numFixedLineWidth1 As DevExpress.XtraEditors.SpinEdit

        Private icbFixedStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbColumn As DevExpress.XtraEditors.ImageComboBoxEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private lciFixedLineWidth As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private icbFixedColumnHighlightMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private sbMiddleColumns As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
