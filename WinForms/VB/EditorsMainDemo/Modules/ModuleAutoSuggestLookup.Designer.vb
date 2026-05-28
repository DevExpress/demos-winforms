Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleAutoSuggestLookup

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.dataLayoutControl2 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.orderInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.contactInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.CountryCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CityTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.RegionTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.DeliveryAddressLookup = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciLastNameTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciFirstNameTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciEmailTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciAddressLineTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.autoGroupForLine = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciCountryCodeTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCityTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRegionTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTextEdit1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.adornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.validationHint1 = New DevExpress.Utils.VisualEffects.ValidationHint()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl2.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.orderInfoBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contactInformationBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.FirstNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CountryCodeTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.entryBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CityTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RegionTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LastNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.EmailTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DeliveryAddressLookup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLastNameTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciFirstNameTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciEmailTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAddressLineTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.autoGroupForLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCountryCodeTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCityTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRegionTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.adornerUIManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 12F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)})
            Me.tablePanel1.Controls.Add(Me.dataLayoutControl2)
            Me.tablePanel1.Controls.Add(Me.dataLayoutControl1)
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.tablePanel1.Size = New System.Drawing.Size(629, 270)
            Me.tablePanel1.TabIndex = 0
            ' 
            ' dataLayoutControl2
            ' 
            Me.dataLayoutControl2.AllowCustomization = False
            Me.tablePanel1.SetColumn(Me.dataLayoutControl2, 2)
            Me.dataLayoutControl2.Controls.Add(Me.gridControl1)
            Me.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl2.Location = New System.Drawing.Point(385, 3)
            Me.dataLayoutControl2.Name = "dataLayoutControl2"
            Me.dataLayoutControl2.Root = Me.layoutControlGroup3
            Me.tablePanel1.SetRow(Me.dataLayoutControl2, 0)
            Me.dataLayoutControl2.Size = New System.Drawing.Size(241, 174)
            Me.dataLayoutControl2.TabIndex = 3
            Me.dataLayoutControl2.Text = "dataLayoutControl2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.orderInfoBindingSource
            Me.gridControl1.Location = New System.Drawing.Point(3, 24)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(235, 147)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' orderInfoBindingSource
            ' 
            Me.orderInfoBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.OrderInfo)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colQuantity, Me.colPrice})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView1.OptionsView.ShowColumnHeaders = False
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            AddHandler Me.gridView1.CustomSummaryCalculate, New DevExpress.Data.CustomSummaryEventHandler(AddressOf Me.OnCustomSummaryCalculate)
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "Product"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 1
            Me.colQuantity.Width = 20
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Price", "{0:C2}")})
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 2
            Me.colPrice.Width = 32
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup4})
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(241, 174)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(241, 174)
            Me.layoutControlGroup4.Text = "Order Summary"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(235, 147)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowCustomization = False
            Me.tablePanel1.SetColumn(Me.dataLayoutControl1, 0)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.FirstNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CountryCodeTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CityTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.RegionTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.LastNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.EmailTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DeliveryAddressLookup)
            Me.dataLayoutControl1.DataSource = Me.contactInformationBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(3, 3)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.Root
            Me.tablePanel1.SetRow(Me.dataLayoutControl1, 0)
            Me.tablePanel1.SetRowSpan(Me.dataLayoutControl1, 2)
            Me.dataLayoutControl1.Size = New System.Drawing.Size(364, 264)
            Me.dataLayoutControl1.TabIndex = 2
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.contactInformationBindingSource, "Phone", True))
            Me.textEdit1.Location = New System.Drawing.Point(14, 226)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.Mask.EditMask = "(999) 000-0000"
            Me.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.textEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.textEdit1.Size = New System.Drawing.Size(336, 20)
            Me.textEdit1.StyleController = Me.dataLayoutControl1
            Me.textEdit1.TabIndex = 11
            ' 
            ' contactInformationBindingSource
            ' 
            Me.contactInformationBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.ContactInformation)
            ' 
            ' FirstNameTextEdit
            ' 
            Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.contactInformationBindingSource, "FirstName", True))
            Me.FirstNameTextEdit.Location = New System.Drawing.Point(96, 59)
            Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
            Me.FirstNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.FirstNameTextEdit.Size = New System.Drawing.Size(254, 20)
            Me.FirstNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.FirstNameTextEdit.TabIndex = 4
            ' 
            ' CountryCodeTextEdit
            ' 
            Me.CountryCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.entryBindingSource, "Country_UN", True))
            Me.CountryCodeTextEdit.Location = New System.Drawing.Point(14, 176)
            Me.CountryCodeTextEdit.Name = "CountryCodeTextEdit"
            Me.CountryCodeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.CountryCodeTextEdit.Properties.NullValuePrompt = "Country"
            Me.CountryCodeTextEdit.Properties.[ReadOnly] = True
            Me.CountryCodeTextEdit.Size = New System.Drawing.Size(66, 20)
            Me.CountryCodeTextEdit.StyleController = Me.dataLayoutControl1
            Me.CountryCodeTextEdit.TabIndex = 6
            ' 
            ' entryBindingSource
            ' 
            Me.entryBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.WorldCities.Entry)
            ' 
            ' CityTextEdit
            ' 
            Me.CityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.entryBindingSource, "City", True))
            Me.CityTextEdit.Location = New System.Drawing.Point(84, 176)
            Me.CityTextEdit.Name = "CityTextEdit"
            Me.CityTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.CityTextEdit.Properties.NullValuePrompt = "City"
            Me.CityTextEdit.Properties.[ReadOnly] = True
            Me.CityTextEdit.Size = New System.Drawing.Size(142, 20)
            Me.CityTextEdit.StyleController = Me.dataLayoutControl1
            Me.CityTextEdit.TabIndex = 7
            ' 
            ' RegionTextEdit
            ' 
            Me.RegionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.entryBindingSource, "Admin_Name_Unicode", True))
            Me.RegionTextEdit.Location = New System.Drawing.Point(230, 176)
            Me.RegionTextEdit.Name = "RegionTextEdit"
            Me.RegionTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.RegionTextEdit.Properties.NullValuePrompt = "Region/State/Provience"
            Me.RegionTextEdit.Properties.[ReadOnly] = True
            Me.RegionTextEdit.Size = New System.Drawing.Size(120, 20)
            Me.RegionTextEdit.StyleController = Me.dataLayoutControl1
            Me.RegionTextEdit.TabIndex = 8
            ' 
            ' LastNameTextEdit
            ' 
            Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.contactInformationBindingSource, "LastName", True))
            Me.LastNameTextEdit.Location = New System.Drawing.Point(96, 83)
            Me.LastNameTextEdit.Name = "LastNameTextEdit"
            Me.LastNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.LastNameTextEdit.Size = New System.Drawing.Size(254, 20)
            Me.LastNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.LastNameTextEdit.TabIndex = 9
            ' 
            ' EmailTextEdit
            ' 
            Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.contactInformationBindingSource, "Email", True))
            Me.EmailTextEdit.Location = New System.Drawing.Point(96, 35)
            Me.EmailTextEdit.Name = "EmailTextEdit"
            Me.EmailTextEdit.Size = New System.Drawing.Size(254, 20)
            Me.EmailTextEdit.StyleController = Me.dataLayoutControl1
            Me.EmailTextEdit.TabIndex = 10
            ' 
            ' DeliveryAddressLookup
            ' 
            Me.DeliveryAddressLookup.Location = New System.Drawing.Point(14, 152)
            Me.DeliveryAddressLookup.Name = "DeliveryAddressLookup"
            Me.DeliveryAddressLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DeliveryAddressLookup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Text")})
            Me.DeliveryAddressLookup.Properties.DataSource = Me.entryBindingSource
            Me.DeliveryAddressLookup.Properties.DisplayMember = "Text"
            Me.DeliveryAddressLookup.Properties.NullValuePrompt = "Enter the city name..."
            Me.DeliveryAddressLookup.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
            Me.DeliveryAddressLookup.Properties.ShowHeader = False
            Me.DeliveryAddressLookup.Size = New System.Drawing.Size(336, 20)
            Me.DeliveryAddressLookup.StyleController = Me.dataLayoutControl1
            Me.DeliveryAddressLookup.TabIndex = 5
            AddHandler Me.DeliveryAddressLookup.AutoSuggest, New DevExpress.XtraEditors.Controls.LookUpEditAutoSuggestEventHandler(AddressOf Me.OnAutoSuggest)
            AddHandler Me.DeliveryAddressLookup.CustomDrawCell, New DevExpress.XtraEditors.Popup.LookUpCustomDrawCellEventHandler(AddressOf Me.OnCustomDrawCell)
            AddHandler Me.DeliveryAddressLookup.EditValueChanged, New System.EventHandler(AddressOf Me.OnEditValueChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(364, 264)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciLastNameTextEdit, Me.lciFirstNameTextEdit, Me.lciEmailTextEdit})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(364, 117)
            Me.layoutControlGroup1.Text = "Contact Information"
            ' 
            ' lciLastNameTextEdit
            ' 
            Me.lciLastNameTextEdit.Control = Me.LastNameTextEdit
            Me.lciLastNameTextEdit.Location = New System.Drawing.Point(0, 48)
            Me.lciLastNameTextEdit.Name = "lciLastNameTextEdit"
            Me.lciLastNameTextEdit.Size = New System.Drawing.Size(340, 24)
            Me.lciLastNameTextEdit.Text = "Last Name"
            Me.lciLastNameTextEdit.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' lciFirstNameTextEdit
            ' 
            Me.lciFirstNameTextEdit.Control = Me.FirstNameTextEdit
            Me.lciFirstNameTextEdit.Location = New System.Drawing.Point(0, 24)
            Me.lciFirstNameTextEdit.Name = "lciFirstNameTextEdit"
            Me.lciFirstNameTextEdit.Size = New System.Drawing.Size(340, 24)
            Me.lciFirstNameTextEdit.Text = "First Name"
            Me.lciFirstNameTextEdit.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' lciEmailTextEdit
            ' 
            Me.lciEmailTextEdit.Control = Me.EmailTextEdit
            Me.lciEmailTextEdit.Location = New System.Drawing.Point(0, 0)
            Me.lciEmailTextEdit.Name = "lciEmailTextEdit"
            Me.lciEmailTextEdit.Size = New System.Drawing.Size(340, 24)
            Me.lciEmailTextEdit.Text = "E-mail"
            Me.lciEmailTextEdit.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAddressLineTextEdit, Me.autoGroupForLine, Me.lciTextEdit1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 117)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(364, 147)
            Me.layoutControlGroup2.Text = "Delivery"
            ' 
            ' lciAddressLineTextEdit
            ' 
            Me.lciAddressLineTextEdit.Control = Me.DeliveryAddressLookup
            Me.lciAddressLineTextEdit.Location = New System.Drawing.Point(0, 0)
            Me.lciAddressLineTextEdit.Name = "lciAddressLineTextEdit"
            Me.lciAddressLineTextEdit.Size = New System.Drawing.Size(340, 24)
            Me.lciAddressLineTextEdit.Text = "Address "
            Me.lciAddressLineTextEdit.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.lciAddressLineTextEdit.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciAddressLineTextEdit.TextToControlDistance = 0
            Me.lciAddressLineTextEdit.TextVisible = False
            ' 
            ' autoGroupForLine
            ' 
            Me.autoGroupForLine.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal
            Me.autoGroupForLine.GroupBordersVisible = False
            Me.autoGroupForLine.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCountryCodeTextEdit, Me.lciCityTextEdit, Me.lciRegionTextEdit})
            Me.autoGroupForLine.Location = New System.Drawing.Point(0, 24)
            Me.autoGroupForLine.Name = "autoGroupForLine"
            Me.autoGroupForLine.Size = New System.Drawing.Size(340, 24)
            Me.autoGroupForLine.Text = "Line"
            ' 
            ' lciCountryCodeTextEdit
            ' 
            Me.lciCountryCodeTextEdit.Control = Me.CountryCodeTextEdit
            Me.lciCountryCodeTextEdit.Location = New System.Drawing.Point(0, 0)
            Me.lciCountryCodeTextEdit.Name = "lciCountryCodeTextEdit"
            Me.lciCountryCodeTextEdit.Size = New System.Drawing.Size(70, 24)
            Me.lciCountryCodeTextEdit.Text = "Country Code"
            Me.lciCountryCodeTextEdit.TextVisible = False
            ' 
            ' lciCityTextEdit
            ' 
            Me.lciCityTextEdit.Control = Me.CityTextEdit
            Me.lciCityTextEdit.Location = New System.Drawing.Point(70, 0)
            Me.lciCityTextEdit.Name = "lciCityTextEdit"
            Me.lciCityTextEdit.Size = New System.Drawing.Size(146, 24)
            Me.lciCityTextEdit.Text = "City"
            Me.lciCityTextEdit.TextVisible = False
            ' 
            ' lciRegionTextEdit
            ' 
            Me.lciRegionTextEdit.Control = Me.RegionTextEdit
            Me.lciRegionTextEdit.Location = New System.Drawing.Point(216, 0)
            Me.lciRegionTextEdit.Name = "lciRegionTextEdit"
            Me.lciRegionTextEdit.Size = New System.Drawing.Size(124, 24)
            Me.lciRegionTextEdit.Text = "Region"
            Me.lciRegionTextEdit.TextVisible = False
            ' 
            ' lciTextEdit1
            ' 
            Me.lciTextEdit1.Control = Me.textEdit1
            Me.lciTextEdit1.Location = New System.Drawing.Point(0, 48)
            Me.lciTextEdit1.Name = "lciTextEdit1"
            Me.lciTextEdit1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 12, 2)
            Me.lciTextEdit1.Size = New System.Drawing.Size(340, 54)
            Me.lciTextEdit1.Text = "Phone Number"
            Me.lciTextEdit1.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciTextEdit1.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' adornerUIManager1
            ' 
            Me.adornerUIManager1.Elements.Add(Me.validationHint1)
            Me.adornerUIManager1.Owner = Me
            ' 
            ' validationHint1
            ' 
            Me.validationHint1.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Invalid
            Me.validationHint1.TargetElement = Me.DeliveryAddressLookup
            ' 
            ' ModuleAutoSuggestLookup
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.tablePanel1)
            Me.Name = "ModuleAutoSuggestLookup"
            Me.Size = New System.Drawing.Size(800, 400)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl2.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.orderInfoBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contactInformationBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.FirstNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CountryCodeTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.entryBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CityTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RegionTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LastNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.EmailTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DeliveryAddressLookup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLastNameTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciFirstNameTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciEmailTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAddressLineTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.autoGroupForLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCountryCodeTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCityTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRegionTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.adornerUIManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private contactInformationBindingSource As System.Windows.Forms.BindingSource

        Private FirstNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private CountryCodeTextEdit As DevExpress.XtraEditors.TextEdit

        Private CityTextEdit As DevExpress.XtraEditors.TextEdit

        Private RegionTextEdit As DevExpress.XtraEditors.TextEdit

        Private LastNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private EmailTextEdit As DevExpress.XtraEditors.TextEdit

        Private DeliveryAddressLookup As DevExpress.XtraEditors.LookUpEdit

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private entryBindingSource As System.Windows.Forms.BindingSource

        Private dataLayoutControl2 As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciLastNameTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciFirstNameTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciEmailTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciAddressLineTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private autoGroupForLine As DevExpress.XtraLayout.LayoutControlGroup

        Private lciCountryCodeTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciCityTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciRegionTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciTextEdit1 As DevExpress.XtraLayout.LayoutControlItem

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private orderInfoBindingSource As System.Windows.Forms.BindingSource

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private adornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager

        Private validationHint1 As DevExpress.Utils.VisualEffects.ValidationHint
    End Class
End Namespace
