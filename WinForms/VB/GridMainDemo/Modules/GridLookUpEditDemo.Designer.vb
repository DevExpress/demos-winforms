Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class GridLookUpEditDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.GridLookUpEditDemo))
            Dim contextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colPhoto1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colNotes1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.gridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.dsNWindCustomers1 = New DevExpress.XtraGrid.Demos.dsNWindCustomers()
            Me.gridLookUpEdit2View = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colAddress = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colEmployeeID1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colExtension = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFirstName1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colLastName1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colReportsTo = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tabPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.dsNWindProducts1 = New DevExpress.XtraGrid.Demos.dsNWindProducts()
            Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.tabPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.repositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.repositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.gridLookUpEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsNWindCustomers1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit2View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage1.SuspendLayout()
            Me.xtraScrollableControl1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.dsNWindProducts1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage2.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit2View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colPhoto1
            ' 
            Me.colPhoto1.FieldName = "Photo"
            Me.colPhoto1.Name = "colPhoto1"
            resources.ApplyResources(Me.colPhoto1, "colPhoto1")
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            resources.ApplyResources(Me.colName, "colName")
            ' 
            ' colNotes1
            ' 
            Me.colNotes1.FieldName = "Notes"
            Me.colNotes1.Name = "colNotes1"
            resources.ApplyResources(Me.colNotes1, "colNotes1")
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.ImageOptions.Alignment = CType((resources.GetObject("colCategoryID.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colCategoryID.ImageOptions.SvgImage = CType((resources.GetObject("colCategoryID.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colCategoryID.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
            Me.colCategoryID.OptionsColumn.AllowMove = False
            Me.colCategoryID.OptionsColumn.AllowSize = False
            Me.colCategoryID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCategoryID.OptionsColumn.FixedWidth = True
            Me.colCategoryID.OptionsFilter.AllowFilter = False
            resources.ApplyResources(Me.colCategoryID, "colCategoryID")
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items10")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items13")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items14"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items16")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items17"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items19")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items20"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items22")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items23")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' colDiscontinued
            ' 
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabPage1)
            Me.tabPane1.Controls.Add(Me.tabPage3)
            Me.tabPane1.Controls.Add(Me.tabPage2)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabPage1, Me.tabPage3, Me.tabPage2})
            Me.tabPane1.SelectedPage = Me.tabPage3
            ' 
            ' tabPage3
            ' 
            resources.ApplyResources(Me.tabPage3, "tabPage3")
            Me.tabPage3.Controls.Add(Me.groupControl1)
            Me.tabPage3.Name = "tabPage3"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.gridLookUpEdit2)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' gridLookUpEdit2
            ' 
            resources.ApplyResources(Me.gridLookUpEdit2, "gridLookUpEdit2")
            Me.gridLookUpEdit2.Name = "gridLookUpEdit2"
            Me.gridLookUpEdit2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("gridLookUpEdit2.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.gridLookUpEdit2.Properties.DataSource = Me.dsNWindCustomers1.Employees
            Me.gridLookUpEdit2.Properties.DisplayMember = "Name"
            Me.gridLookUpEdit2.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
            Me.gridLookUpEdit2.Properties.PopupView = Me.gridLookUpEdit2View
            Me.gridLookUpEdit2.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.gridLookUpEdit2.Properties.ValueMember = "EmployeeID"
            Me.gridLookUpEdit2.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            ' 
            ' dsNWindCustomers1
            ' 
            Me.dsNWindCustomers1.DataSetName = "dsNWindCustomers"
            Me.dsNWindCustomers1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindCustomers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridLookUpEdit2View
            ' 
            Me.gridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAddress, Me.colBirthDate, Me.colCity, Me.colCountry, Me.colEmployeeID1, Me.colExtension, Me.colFirstName1, Me.colHireDate, Me.colHomePhone, Me.colLastName1, Me.colNotes1, Me.colPhoto1, Me.colPostalCode, Me.colRegion, Me.colReportsTo, Me.colTitle, Me.colTitleOfCourtesy, Me.colName})
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton1.Id = New System.Guid("3c2a68ae-c0c8-45ae-9d32-ed4596b39df3")
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
            contextButton1.Name = "contextButton1"
            resources.ApplyResources(contextButton1, "contextButton1")
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
            Me.gridLookUpEdit2View.ContextButtons.Add(contextButton1)
            Me.gridLookUpEdit2View.Name = "gridLookUpEdit2View"
            Me.gridLookUpEdit2View.OptionsBehavior.AllowSmoothScrolling = True
            Me.gridLookUpEdit2View.OptionsTiles.AllowPressAnimation = False
            Me.gridLookUpEdit2View.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gridLookUpEdit2View.OptionsTiles.ItemSize = New System.Drawing.Size(300, 90)
            Me.gridLookUpEdit2View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.gridLookUpEdit2View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.gridLookUpEdit2View.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 71R
            tableColumnDefinition1.PaddingRight = 4
            tableColumnDefinition2.Length.Value = 153R
            Me.gridLookUpEdit2View.TileColumns.Add(tableColumnDefinition1)
            Me.gridLookUpEdit2View.TileColumns.Add(tableColumnDefinition2)
            tableRowDefinition1.Length.Value = 26R
            tableRowDefinition2.Length.Value = 48R
            Me.gridLookUpEdit2View.TileRows.Add(tableRowDefinition1)
            Me.gridLookUpEdit2View.TileRows.Add(tableRowDefinition2)
            tableSpan1.RowSpan = 2
            Me.gridLookUpEdit2View.TileSpans.Add(tableSpan1)
            tileViewItemElement1.Column = Me.colPhoto1
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            resources.ApplyResources(tileViewItemElement1, "tileViewItemElement1")
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.Appearance.Normal.Font = CType((resources.GetObject("resource.Font1")), System.Drawing.Font)
            tileViewItemElement2.Appearance.Normal.Options.UseFont = True
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement2.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement2.Column = Me.colName
            tileViewItemElement2.ColumnIndex = 1
            resources.ApplyResources(tileViewItemElement2, "tileViewItemElement2")
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileViewItemElement3.Appearance.Normal.Font = CType((resources.GetObject("resource.Font2")), System.Drawing.Font)
            tileViewItemElement3.Appearance.Normal.Options.UseFont = True
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement3.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            tileViewItemElement3.Column = Me.colNotes1
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.RowIndex = 1
            resources.ApplyResources(tileViewItemElement3, "tileViewItemElement3")
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            Me.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement1)
            Me.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement2)
            Me.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement3)
            ' 
            ' colAddress
            ' 
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            resources.ApplyResources(Me.colAddress, "colAddress")
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            resources.ApplyResources(Me.colBirthDate, "colBirthDate")
            ' 
            ' colCity
            ' 
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            resources.ApplyResources(Me.colCity, "colCity")
            ' 
            ' colCountry
            ' 
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            resources.ApplyResources(Me.colCountry, "colCountry")
            ' 
            ' colEmployeeID1
            ' 
            Me.colEmployeeID1.FieldName = "EmployeeID"
            Me.colEmployeeID1.Name = "colEmployeeID1"
            resources.ApplyResources(Me.colEmployeeID1, "colEmployeeID1")
            ' 
            ' colExtension
            ' 
            Me.colExtension.FieldName = "Extension"
            Me.colExtension.Name = "colExtension"
            resources.ApplyResources(Me.colExtension, "colExtension")
            ' 
            ' colFirstName1
            ' 
            Me.colFirstName1.FieldName = "FirstName"
            Me.colFirstName1.Name = "colFirstName1"
            resources.ApplyResources(Me.colFirstName1, "colFirstName1")
            ' 
            ' colHireDate
            ' 
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            resources.ApplyResources(Me.colHireDate, "colHireDate")
            ' 
            ' colHomePhone
            ' 
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            resources.ApplyResources(Me.colHomePhone, "colHomePhone")
            ' 
            ' colLastName1
            ' 
            Me.colLastName1.FieldName = "LastName"
            Me.colLastName1.Name = "colLastName1"
            resources.ApplyResources(Me.colLastName1, "colLastName1")
            ' 
            ' colPostalCode
            ' 
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            ' 
            ' colRegion
            ' 
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            resources.ApplyResources(Me.colRegion, "colRegion")
            ' 
            ' colReportsTo
            ' 
            Me.colReportsTo.FieldName = "ReportsTo"
            Me.colReportsTo.Name = "colReportsTo"
            resources.ApplyResources(Me.colReportsTo, "colReportsTo")
            ' 
            ' colTitle
            ' 
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            resources.ApplyResources(Me.colTitle, "colTitle")
            ' 
            ' colTitleOfCourtesy
            ' 
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            resources.ApplyResources(Me.colTitleOfCourtesy, "colTitleOfCourtesy")
            ' 
            ' tabPage1
            ' 
            resources.ApplyResources(Me.tabPage1, "tabPage1")
            Me.tabPage1.Controls.Add(Me.xtraScrollableControl1)
            Me.tabPage1.Name = "tabPage1"
            ' 
            ' xtraScrollableControl1
            ' 
            Me.xtraScrollableControl1.Controls.Add(Me.panelControl1)
            resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.dataNavigator1)
            Me.panelControl1.Controls.Add(Me.gridLookUpEdit1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.DataSource = Me.dsNWindProducts1.Order_Details
            resources.ApplyResources(Me.dataNavigator1, "dataNavigator1")
            Me.dataNavigator1.Name = "dataNavigator1"
            ' 
            ' dsNWindProducts1
            ' 
            Me.dsNWindProducts1.DataSetName = "dsNWindProducts"
            Me.dsNWindProducts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridLookUpEdit1
            ' 
            resources.ApplyResources(Me.gridLookUpEdit1, "gridLookUpEdit1")
            Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
            Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("gridLookUpEdit1.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.gridLookUpEdit1.Properties.DataSource = Me.dsNWindProducts1.Products
            Me.gridLookUpEdit1.Properties.DisplayMember = "ProductName"
            Me.gridLookUpEdit1.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
            Me.gridLookUpEdit1.Properties.PopupView = Me.gridLookUpEdit1View
            Me.gridLookUpEdit1.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.gridLookUpEdit1.Properties.ValueMember = "ProductID"
            AddHandler Me.gridLookUpEdit1.ProcessNewValue, New DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(AddressOf Me.gridLookUpEdit1_ProcessNewValue)
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colDiscontinued})
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colCategoryID
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 1
            styleFormatCondition2.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Gray
            styleFormatCondition2.Appearance.Options.UseFont = True
            styleFormatCondition2.Appearance.Options.UseForeColor = True
            styleFormatCondition2.ApplyToRow = True
            styleFormatCondition2.Column = Me.colDiscontinued
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition2.Value1 = True
            Me.gridLookUpEdit1View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1, styleFormatCondition2})
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.gridLookUpEdit1View.OptionsView.ShowIndicator = False
            ' 
            ' colProductName
            ' 
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            ' 
            ' colQuantityPerUnit
            ' 
            resources.ApplyResources(Me.colQuantityPerUnit, "colQuantityPerUnit")
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            ' 
            ' tabPage2
            ' 
            resources.ApplyResources(Me.tabPage2, "tabPage2")
            Me.tabPage2.Controls.Add(Me.gridControl1)
            Me.tabPage2.Name = "tabPage2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsNWindCustomers1.Orders
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemGridLookUpEdit1, Me.repositoryItemGridLookUpEdit2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShipName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.AppearanceHeader.Font = CType((resources.GetObject("colCustomerID.AppearanceHeader.Font")), System.Drawing.Font)
            Me.colCustomerID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.ColumnEdit = Me.repositoryItemGridLookUpEdit1
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            ' 
            ' repositoryItemGridLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemGridLookUpEdit1, "repositoryItemGridLookUpEdit1")
            Me.repositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemGridLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemGridLookUpEdit1.DataSource = Me.dsNWindCustomers1.Customers
            Me.repositoryItemGridLookUpEdit1.DisplayMember = "CompanyName"
            Me.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1"
            Me.repositoryItemGridLookUpEdit1.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemGridLookUpEdit1.PopupView = Me.repositoryItemGridLookUpEdit1View
            Me.repositoryItemGridLookUpEdit1.ValueMember = "CustomerID"
            ' 
            ' repositoryItemGridLookUpEdit1View
            ' 
            Me.repositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyName, Me.colContactName, Me.colContactTitle})
            Me.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View"
            Me.repositoryItemGridLookUpEdit1View.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.repositoryItemGridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.AutoCalcPreviewLineCount = True
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowPreview = True
            AddHandler Me.repositoryItemGridLookUpEdit1View.CalcPreviewText, New DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(AddressOf Me.repositoryItemGridLookUpEdit1View_CalcPreviewText)
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.AppearanceHeader.Font = CType((resources.GetObject("colEmployeeID.AppearanceHeader.Font")), System.Drawing.Font)
            Me.colEmployeeID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colEmployeeID, "colEmployeeID")
            Me.colEmployeeID.ColumnEdit = Me.repositoryItemGridLookUpEdit2
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            ' 
            ' repositoryItemGridLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemGridLookUpEdit2, "repositoryItemGridLookUpEdit2")
            Me.repositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemGridLookUpEdit2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemGridLookUpEdit2.DataSource = Me.dsNWindCustomers1.Employees
            Me.repositoryItemGridLookUpEdit2.DisplayMember = "Name"
            Me.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2"
            Me.repositoryItemGridLookUpEdit2.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemGridLookUpEdit2.PopupView = Me.repositoryItemGridLookUpEdit2View
            Me.repositoryItemGridLookUpEdit2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1})
            Me.repositoryItemGridLookUpEdit2.ValueMember = "EmployeeID"
            Me.repositoryItemGridLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView
            ' 
            ' repositoryItemGridLookUpEdit2View
            ' 
            Me.repositoryItemGridLookUpEdit2View.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2})
            Me.repositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPhoto, Me.colFirstName, Me.colLastName, Me.colNotes})
            Me.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View"
            Me.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit2View.OptionsView.ColumnAutoWidth = True
            Me.repositoryItemGridLookUpEdit2View.OptionsView.ShowColumnHeaders = False
            Me.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemGridLookUpEdit2View.OptionsView.ShowIndicator = False
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Columns.Add(Me.colPhoto)
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            ' 
            ' colPhoto
            ' 
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.RowCount = 4
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colFirstName)
            Me.gridBand2.Columns.Add(Me.colLastName)
            Me.gridBand2.Columns.Add(Me.colNotes)
            Me.gridBand2.VisibleIndex = 1
            ' 
            ' colFirstName
            ' 
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            ' 
            ' colLastName
            ' 
            resources.ApplyResources(Me.colLastName, "colLastName")
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            ' 
            ' colNotes
            ' 
            Me.colNotes.AutoFillDown = True
            resources.ApplyResources(Me.colNotes, "colNotes")
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.RowIndex = 1
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colOrderDate
            ' 
            resources.ApplyResources(Me.colOrderDate, "colOrderDate")
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' colRequiredDate
            ' 
            resources.ApplyResources(Me.colRequiredDate, "colRequiredDate")
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            ' 
            ' colShipName
            ' 
            resources.ApplyResources(Me.colShipName, "colShipName")
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Beverages", CType((resources.GetObject("svgImageCollection1.Beverages")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("condiments", CType((resources.GetObject("svgImageCollection1.condiments")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("confections", CType((resources.GetObject("svgImageCollection1.confections")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("DairyProduct", CType((resources.GetObject("svgImageCollection1.DairyProduct")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("grains_cereals", CType((resources.GetObject("svgImageCollection1.grains_cereals")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("MeatPoultry", CType((resources.GetObject("svgImageCollection1.MeatPoultry")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("produce", CType((resources.GetObject("svgImageCollection1.produce")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Seafood", CType((resources.GetObject("svgImageCollection1.Seafood")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' GridLookUpEditDemo
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane1)
            Me.Name = "GridLookUpEditDemo"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.GridLookUpEdit_Load)
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabPage3.ResumeLayout(False)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.gridLookUpEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsNWindCustomers1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit2View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage1.ResumeLayout(False)
            Me.xtraScrollableControl1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.dsNWindProducts1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage2.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit2View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl1 As DevExpress.XtraEditors.GroupControl

        Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private dsNWindProducts1 As DevExpress.XtraGrid.Demos.dsNWindProducts

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit

        Private repositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit

        Private repositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private dsNWindCustomers1 As DevExpress.XtraGrid.Demos.dsNWindCustomers

        Private components As System.ComponentModel.IContainer = Nothing

        Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl

        Private tabPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private gridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit

        Private gridLookUpEdit2View As DevExpress.XtraGrid.Views.Tile.TileView

        Private colAddress As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colBirthDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colCity As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colCountry As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colEmployeeID1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colExtension As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colFirstName1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colHireDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colHomePhone As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colLastName1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colNotes1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPhoto1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPostalCode As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colRegion As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colReportsTo As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colTitle As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colName As DevExpress.XtraGrid.Columns.TileViewColumn

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
