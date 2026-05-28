Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class NWindLayout
        Inherits DevExpress.XtraGrid.Demos.BaseLayoutModule

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.layoutView = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colAddress = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.layoutViewField_colAddress = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colCity = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.layoutViewField_colCity = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colCountry = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.layoutViewField_colCountry = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colFirstName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colHomePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colLastName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colLastName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colNotes = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutViewField_colNotes = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.layoutViewField_colPostalCode = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colRegion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.layoutViewField_colRegion = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colReportsTo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colReportsTo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colTitle = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colTitle = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colTitleOfCourtesy = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Group2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.Item12 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.item1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.dsNWindCustomers = New DevExpress.XtraGrid.Demos.dsNWindCustomers()
            Me.imagesInFields = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl5 = New DevExpress.XtraLayout.LayoutControl()
            Me.visibilityOnlyForFocused = New DevExpress.XtraEditors.CheckEdit()
            Me.photoVisibility = New DevExpress.XtraEditors.CheckEdit()
            Me.imagesInCaptions = New DevExpress.XtraEditors.CheckEdit()
            Me.imagesOnlyForFocused = New DevExpress.XtraEditors.CheckEdit()
            Me.notesVisibility = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.emptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.multiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.stretchWidthM = New DevExpress.XtraEditors.CheckEdit()
            Me.stretchHeightM = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.cardAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.stretchWidth = New DevExpress.XtraEditors.CheckEdit()
            Me.stretchHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl()
            Me.customizationOptions = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.allowRuntimeCustomization = New DevExpress.XtraEditors.CheckEdit()
            Me.customizeBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.advancedCustomization = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colAddress), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colCity), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colCountry), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colFirstName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colHomePhone), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colLastName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colNotes), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPostalCode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colRegion), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colReportsTo), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colTitle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colTitleOfCourtesy), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Group2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Item12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.item1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsNWindCustomers), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imagesInFields.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl5.SuspendLayout()
            CType((Me.visibilityOnlyForFocused.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.photoVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imagesInCaptions.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imagesOnlyForFocused.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.notesVisibility.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.multiSelect.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.stretchWidthM.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stretchHeightM.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.stretchWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stretchHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            CType((Me.customizationOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowRuntimeCustomization.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.advancedCustomization.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage3.SuspendLayout()
            Me.navigationPage2.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            Me.navigationPage4.SuspendLayout()
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.layoutView
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemComboBox1, Me.repositoryItemLookUpEdit1, Me.repositoryItemComboBox2, Me.repositoryItemComboBox3})
            Me.gridControl1.Size = New System.Drawing.Size(835, 668)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutView})
            ' 
            ' layoutView
            ' 
            Me.layoutView.Appearance.Card.Options.UseTextOptions = True
            Me.layoutView.Appearance.Card.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutView.Appearance.FieldCaption.Options.UseTextOptions = True
            Me.layoutView.Appearance.FieldCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.layoutView.CardMinSize = New System.Drawing.Size(250, 343)
            Me.layoutView.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colAddress, Me.colCity, Me.colCountry, Me.colFirstName, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colPostalCode, Me.colRegion, Me.colReportsTo, Me.colTitle, Me.colTitleOfCourtesy})
            Me.layoutView.GridControl = Me.gridControl1
            Me.layoutView.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colReportsTo, Me.layoutViewField_colTitleOfCourtesy})
            Me.layoutView.Name = "layoutView"
            Me.layoutView.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize
            Me.layoutView.OptionsSingleRecordMode.StretchCardToViewHeight = True
            Me.layoutView.OptionsSingleRecordMode.StretchCardToViewWidth = True
            Me.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
            Me.layoutView.TemplateCard = Me.layoutViewCard1
            ' 
            ' colAddress
            ' 
            Me.colAddress.Caption = "Address"
            Me.colAddress.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colAddress.CustomizationCaption = "Address"
            Me.colAddress.FieldName = "Address"
            Me.colAddress.LayoutViewField = Me.layoutViewField_colAddress
            Me.colAddress.Name = "colAddress"
            Me.colAddress.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colAddress.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.ShowIcon = False
            ' 
            ' layoutViewField_colAddress
            ' 
            Me.layoutViewField_colAddress.EditorPreferredWidth = 152
            Me.layoutViewField_colAddress.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colAddress.Name = "layoutViewField_colAddress"
            Me.layoutViewField_colAddress.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colAddress.Size = New System.Drawing.Size(207, 26)
            Me.layoutViewField_colAddress.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colAddress.TextSize = New System.Drawing.Size(43, 13)
            ' 
            ' colCity
            ' 
            Me.colCity.Caption = "City"
            Me.colCity.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCity.CustomizationCaption = "City"
            Me.colCity.FieldName = "City"
            Me.colCity.LayoutViewField = Me.layoutViewField_colCity
            Me.colCity.Name = "colCity"
            ' 
            ' repositoryItemComboBox2
            ' 
            Me.repositoryItemComboBox2.AutoHeight = False
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() {"Seattle", "Tacoma", "Kirkland", "Redmond", "London"})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' layoutViewField_colCity
            ' 
            Me.layoutViewField_colCity.EditorPreferredWidth = 172
            Me.layoutViewField_colCity.Location = New System.Drawing.Point(0, 26)
            Me.layoutViewField_colCity.Name = "layoutViewField_colCity"
            Me.layoutViewField_colCity.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colCity.Size = New System.Drawing.Size(207, 26)
            Me.layoutViewField_colCity.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colCity.TextSize = New System.Drawing.Size(23, 13)
            ' 
            ' colCountry
            ' 
            Me.colCountry.Caption = "Country"
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox1
            Me.colCountry.CustomizationCaption = "Country"
            Me.colCountry.FieldName = "Country"
            Me.colCountry.LayoutViewField = Me.layoutViewField_colCountry
            Me.colCountry.Name = "colCountry"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"USA", "UK"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' layoutViewField_colCountry
            ' 
            Me.layoutViewField_colCountry.EditorPreferredWidth = 152
            Me.layoutViewField_colCountry.Location = New System.Drawing.Point(0, 78)
            Me.layoutViewField_colCountry.Name = "layoutViewField_colCountry"
            Me.layoutViewField_colCountry.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colCountry.Size = New System.Drawing.Size(207, 26)
            Me.layoutViewField_colCountry.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colCountry.TextSize = New System.Drawing.Size(43, 13)
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.Caption = "First Name"
            Me.colFirstName.CustomizationCaption = " First Name"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.LayoutViewField = Me.layoutViewField_colFirstName
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.OptionsFilter.AllowFilter = False
            ' 
            ' layoutViewField_colFirstName
            ' 
            Me.layoutViewField_colFirstName.EditorPreferredWidth = 99
            Me.layoutViewField_colFirstName.Location = New System.Drawing.Point(66, 26)
            Me.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName"
            Me.layoutViewField_colFirstName.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colFirstName.Size = New System.Drawing.Size(165, 26)
            Me.layoutViewField_colFirstName.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colFirstName.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' colHomePhone
            ' 
            Me.colHomePhone.Caption = "Home Phone"
            Me.colHomePhone.CustomizationCaption = "Home Phone"
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.LayoutViewField = Me.layoutViewField_colHomePhone
            Me.colHomePhone.Name = "colHomePhone"
            ' 
            ' layoutViewField_colHomePhone
            ' 
            Me.layoutViewField_colHomePhone.EditorPreferredWidth = 131
            Me.layoutViewField_colHomePhone.Location = New System.Drawing.Point(0, 104)
            Me.layoutViewField_colHomePhone.Name = "layoutViewField_colHomePhone"
            Me.layoutViewField_colHomePhone.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colHomePhone.Size = New System.Drawing.Size(207, 26)
            Me.layoutViewField_colHomePhone.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colHomePhone.TextSize = New System.Drawing.Size(64, 13)
            ' 
            ' colLastName
            ' 
            Me.colLastName.Caption = "Last Name"
            Me.colLastName.CustomizationCaption = "Last Name"
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.LayoutViewField = Me.layoutViewField_colLastName
            Me.colLastName.Name = "colLastName"
            Me.colLastName.OptionsFilter.AllowFilter = False
            ' 
            ' layoutViewField_colLastName
            ' 
            Me.layoutViewField_colLastName.EditorPreferredWidth = 100
            Me.layoutViewField_colLastName.Location = New System.Drawing.Point(66, 52)
            Me.layoutViewField_colLastName.Name = "layoutViewField_colLastName"
            Me.layoutViewField_colLastName.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colLastName.Size = New System.Drawing.Size(165, 26)
            Me.layoutViewField_colLastName.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colLastName.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' colNotes
            ' 
            Me.colNotes.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colNotes.Caption = "Notes"
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.CustomizationCaption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.LayoutViewField = Me.layoutViewField_colNotes
            Me.colNotes.Name = "colNotes"
            Me.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colNotes.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' layoutViewField_colNotes
            ' 
            Me.layoutViewField_colNotes.EditorPreferredWidth = 187
            Me.layoutViewField_colNotes.Location = New System.Drawing.Point(0, 261)
            Me.layoutViewField_colNotes.MaxSize = New System.Drawing.Size(207, 60)
            Me.layoutViewField_colNotes.MinSize = New System.Drawing.Size(207, 60)
            Me.layoutViewField_colNotes.Name = "layoutViewField_colNotes"
            Me.layoutViewField_colNotes.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colNotes.Size = New System.Drawing.Size(231, 25)
            Me.layoutViewField_colNotes.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colNotes.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colNotes.TextSize = New System.Drawing.Size(32, 13)
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.Caption = "Photo"
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.CustomizationCaption = "Photo"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPhoto.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            ' 
            ' layoutViewField_colPhoto
            ' 
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 58
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.MaxSize = New System.Drawing.Size(64, 80)
            Me.layoutViewField_colPhoto.MinSize = New System.Drawing.Size(64, 80)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(64, 88)
            Me.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colPhoto.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 12)
            Me.layoutViewField_colPhoto.TextVisible = False
            ' 
            ' colPostalCode
            ' 
            Me.colPostalCode.Caption = "Postal Code"
            Me.colPostalCode.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colPostalCode.CustomizationCaption = "Postal Code"
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.LayoutViewField = Me.layoutViewField_colPostalCode
            Me.colPostalCode.Name = "colPostalCode"
            Me.colPostalCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPostalCode.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PostalCode", "PostalCode", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
            Me.repositoryItemLookUpEdit1.DisplayMember = "PostalCode"
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 100
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "PostalCode"
            ' 
            ' layoutViewField_colPostalCode
            ' 
            Me.layoutViewField_colPostalCode.EditorPreferredWidth = 55
            Me.layoutViewField_colPostalCode.Location = New System.Drawing.Point(0, 52)
            Me.layoutViewField_colPostalCode.Name = "layoutViewField_colPostalCode"
            Me.layoutViewField_colPostalCode.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colPostalCode.Size = New System.Drawing.Size(128, 26)
            Me.layoutViewField_colPostalCode.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colPostalCode.TextSize = New System.Drawing.Size(61, 13)
            ' 
            ' colRegion
            ' 
            Me.colRegion.Caption = "Region"
            Me.colRegion.ColumnEdit = Me.repositoryItemComboBox3
            Me.colRegion.CustomizationCaption = "Region"
            Me.colRegion.FieldName = "Region"
            Me.colRegion.LayoutViewField = Me.layoutViewField_colRegion
            Me.colRegion.Name = "colRegion"
            ' 
            ' repositoryItemComboBox3
            ' 
            Me.repositoryItemComboBox3.AutoHeight = False
            Me.repositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox3.Items.AddRange(New Object() {"WA", "SP", "NM", "Lara", "Québec", "WY", "ID", "OR", "Nueva Esparta", "Essex", "Isle of Wight", "Táchira"})
            Me.repositoryItemComboBox3.Name = "repositoryItemComboBox3"
            ' 
            ' layoutViewField_colRegion
            ' 
            Me.layoutViewField_colRegion.EditorPreferredWidth = 31
            Me.layoutViewField_colRegion.Location = New System.Drawing.Point(128, 52)
            Me.layoutViewField_colRegion.Name = "layoutViewField_colRegion"
            Me.layoutViewField_colRegion.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colRegion.Size = New System.Drawing.Size(79, 26)
            Me.layoutViewField_colRegion.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colRegion.TextSize = New System.Drawing.Size(37, 13)
            ' 
            ' colReportsTo
            ' 
            Me.colReportsTo.Caption = "ReportsTo"
            Me.colReportsTo.CustomizationCaption = "ReportsTo"
            Me.colReportsTo.FieldName = "ReportsTo"
            Me.colReportsTo.LayoutViewField = Me.layoutViewField_colReportsTo
            Me.colReportsTo.Name = "colReportsTo"
            ' 
            ' layoutViewField_colReportsTo
            ' 
            Me.layoutViewField_colReportsTo.EditorPreferredWidth = 10
            Me.layoutViewField_colReportsTo.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colReportsTo.Name = "layoutViewField_colReportsTo"
            Me.layoutViewField_colReportsTo.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colReportsTo.Size = New System.Drawing.Size(230, 304)
            Me.layoutViewField_colReportsTo.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colReportsTo.TextSize = New System.Drawing.Size(76, 20)
            ' 
            ' colTitle
            ' 
            Me.colTitle.Caption = "Title"
            Me.colTitle.CustomizationCaption = "Title"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.LayoutViewField = Me.layoutViewField_colTitle
            Me.colTitle.Name = "colTitle"
            ' 
            ' layoutViewField_colTitle
            ' 
            Me.layoutViewField_colTitle.EditorPreferredWidth = 130
            Me.layoutViewField_colTitle.Location = New System.Drawing.Point(66, 0)
            Me.layoutViewField_colTitle.Name = "layoutViewField_colTitle"
            Me.layoutViewField_colTitle.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colTitle.Size = New System.Drawing.Size(165, 26)
            Me.layoutViewField_colTitle.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colTitle.TextSize = New System.Drawing.Size(24, 13)
            ' 
            ' colTitleOfCourtesy
            ' 
            Me.colTitleOfCourtesy.Caption = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.CustomizationCaption = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.LayoutViewField = Me.layoutViewField_colTitleOfCourtesy
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            ' 
            ' layoutViewField_colTitleOfCourtesy
            ' 
            Me.layoutViewField_colTitleOfCourtesy.EditorPreferredWidth = 10
            Me.layoutViewField_colTitleOfCourtesy.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colTitleOfCourtesy.Name = "layoutViewField_colTitleOfCourtesy"
            Me.layoutViewField_colTitleOfCourtesy.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colTitleOfCourtesy.Size = New System.Drawing.Size(230, 304)
            Me.layoutViewField_colTitleOfCourtesy.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewField_colTitleOfCourtesy.TextSize = New System.Drawing.Size(76, 20)
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.CustomizationFormText = "layoutViewCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colPhoto, Me.layoutViewField_colNotes, Me.Group2, Me.layoutViewField_colTitle, Me.layoutViewField_colFirstName, Me.layoutViewField_colLastName, Me.Item12, Me.item1})
            Me.layoutViewCard1.Name = "layoutViewTemplateCard"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.[Default]
            ' 
            ' Group2
            ' 
            Me.Group2.CustomizationFormText = "Contact Info"
            Me.Group2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colHomePhone, Me.layoutViewField_colCountry, Me.layoutViewField_colAddress, Me.layoutViewField_colCity, Me.layoutViewField_colPostalCode, Me.layoutViewField_colRegion})
            Me.Group2.Location = New System.Drawing.Point(0, 88)
            Me.Group2.Name = "Group2"
            Me.Group2.Size = New System.Drawing.Size(231, 173)
            Me.Group2.Text = "Contact Info"
            Me.Group2.TextLocation = DevExpress.Utils.Locations.[Default]
            ' 
            ' Item12
            ' 
            Me.Item12.CustomizationFormText = "LayoutItem13"
            Me.Item12.Location = New System.Drawing.Point(66, 78)
            Me.Item12.Name = "Item12"
            Me.Item12.Size = New System.Drawing.Size(165, 10)
            Me.Item12.Text = "LayoutItem13"
            ' 
            ' item1
            ' 
            Me.item1.CustomizationFormText = "item1"
            Me.item1.Location = New System.Drawing.Point(64, 0)
            Me.item1.Name = "item1"
            Me.item1.Size = New System.Drawing.Size(2, 88)
            ' 
            ' dsNWindCustomers
            ' 
            Me.dsNWindCustomers.DataSetName = "dsNWindCustomers"
            Me.dsNWindCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' imagesInFields
            ' 
            Me.imagesInFields.Location = New System.Drawing.Point(12, 12)
            Me.imagesInFields.Name = "imagesInFields"
            Me.imagesInFields.Properties.Caption = "Show Field Caption Images"
            Me.imagesInFields.Size = New System.Drawing.Size(186, 20)
            Me.imagesInFields.StyleController = Me.layoutControl5
            Me.imagesInFields.TabIndex = 15
            AddHandler Me.imagesInFields.CheckedChanged, New System.EventHandler(AddressOf Me.imagesInFields_CheckedChanged)
            ' 
            ' layoutControl5
            ' 
            Me.layoutControl5.AllowCustomization = False
            Me.layoutControl5.Controls.Add(Me.imagesInFields)
            Me.layoutControl5.Controls.Add(Me.visibilityOnlyForFocused)
            Me.layoutControl5.Controls.Add(Me.photoVisibility)
            Me.layoutControl5.Controls.Add(Me.imagesInCaptions)
            Me.layoutControl5.Controls.Add(Me.imagesOnlyForFocused)
            Me.layoutControl5.Controls.Add(Me.notesVisibility)
            Me.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl5.Name = "layoutControl5"
            Me.layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1096, 194, 450, 350)
            Me.layoutControl5.Root = Me.layoutControlGroup8
            Me.layoutControl5.Size = New System.Drawing.Size(210, 608)
            Me.layoutControl5.TabIndex = 0
            Me.layoutControl5.Text = "layoutControl5"
            ' 
            ' visibilityOnlyForFocused
            ' 
            Me.visibilityOnlyForFocused.Location = New System.Drawing.Point(12, 181)
            Me.visibilityOnlyForFocused.Name = "visibilityOnlyForFocused"
            Me.visibilityOnlyForFocused.Properties.Caption = "Show ""Contact Info"""
            Me.visibilityOnlyForFocused.Size = New System.Drawing.Size(186, 20)
            Me.visibilityOnlyForFocused.StyleController = Me.layoutControl5
            Me.visibilityOnlyForFocused.TabIndex = 20
            AddHandler Me.visibilityOnlyForFocused.CheckedChanged, New System.EventHandler(AddressOf Me.visibilityOnlyForFocused_CheckedChanged)
            ' 
            ' photoVisibility
            ' 
            Me.photoVisibility.EditValue = True
            Me.photoVisibility.Location = New System.Drawing.Point(12, 157)
            Me.photoVisibility.Name = "photoVisibility"
            Me.photoVisibility.Properties.Caption = "Show Photo Field"
            Me.photoVisibility.Size = New System.Drawing.Size(186, 20)
            Me.photoVisibility.StyleController = Me.layoutControl5
            Me.photoVisibility.TabIndex = 18
            AddHandler Me.photoVisibility.CheckedChanged, New System.EventHandler(AddressOf Me.photoVisibility_CheckedChanged)
            ' 
            ' imagesInCaptions
            ' 
            Me.imagesInCaptions.Location = New System.Drawing.Point(12, 36)
            Me.imagesInCaptions.Name = "imagesInCaptions"
            Me.imagesInCaptions.Properties.Caption = "Show Card Caption Images"
            Me.imagesInCaptions.Size = New System.Drawing.Size(186, 20)
            Me.imagesInCaptions.StyleController = Me.layoutControl5
            Me.imagesInCaptions.TabIndex = 14
            AddHandler Me.imagesInCaptions.CheckedChanged, New System.EventHandler(AddressOf Me.imagesInCaptions_CheckedChanged)
            ' 
            ' imagesOnlyForFocused
            ' 
            Me.imagesOnlyForFocused.Location = New System.Drawing.Point(12, 60)
            Me.imagesOnlyForFocused.Name = "imagesOnlyForFocused"
            Me.imagesOnlyForFocused.Properties.Caption = "Only in Focused Card"
            Me.imagesOnlyForFocused.Size = New System.Drawing.Size(186, 20)
            Me.imagesOnlyForFocused.StyleController = Me.layoutControl5
            Me.imagesOnlyForFocused.TabIndex = 16
            AddHandler Me.imagesOnlyForFocused.CheckedChanged, New System.EventHandler(AddressOf Me.imagesOnlyForFocused_CheckedChanged)
            ' 
            ' notesVisibility
            ' 
            Me.notesVisibility.EditValue = True
            Me.notesVisibility.Location = New System.Drawing.Point(12, 133)
            Me.notesVisibility.Name = "notesVisibility"
            Me.notesVisibility.Properties.Caption = "Show Notes Field"
            Me.notesVisibility.Size = New System.Drawing.Size(186, 20)
            Me.notesVisibility.StyleController = Me.layoutControl5
            Me.notesVisibility.TabIndex = 19
            AddHandler Me.notesVisibility.CheckedChanged, New System.EventHandler(AddressOf Me.notesVisibility_CheckedChanged)
            ' 
            ' layoutControlGroup8
            ' 
            Me.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup8.GroupBordersVisible = False
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12, Me.layoutControlItem11, Me.layoutControlItem13, Me.layoutControlItem16, Me.layoutControlItem15, Me.layoutControlItem17, Me.simpleLabelItem3, Me.emptySpaceItem9, Me.emptySpaceItem6})
            Me.layoutControlGroup8.Name = "Root"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(210, 608)
            Me.layoutControlGroup8.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.imagesInFields
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.imagesInCaptions
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.imagesOnlyForFocused
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.notesVisibility
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 121)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.photoVisibility
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 145)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.visibilityOnlyForFocused
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 169)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' simpleLabelItem3
            ' 
            Me.simpleLabelItem3.Location = New System.Drawing.Point(0, 193)
            Me.simpleLabelItem3.Name = "simpleLabelItem3"
            Me.simpleLabelItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.simpleLabelItem3.Size = New System.Drawing.Size(190, 17)
            Me.simpleLabelItem3.Text = " (only in focused card)"
            Me.simpleLabelItem3.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' emptySpaceItem9
            ' 
            Me.emptySpaceItem9.Location = New System.Drawing.Point(0, 210)
            Me.emptySpaceItem9.Name = "emptySpaceItem9"
            Me.emptySpaceItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.emptySpaceItem9.Size = New System.Drawing.Size(190, 378)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(190, 49)
            ' 
            ' multiSelect
            ' 
            Me.multiSelect.Location = New System.Drawing.Point(12, 106)
            Me.multiSelect.Name = "multiSelect"
            Me.multiSelect.Properties.Caption = "Multiple Card Selection"
            Me.multiSelect.Size = New System.Drawing.Size(186, 20)
            Me.multiSelect.StyleController = Me.layoutControl3
            Me.multiSelect.TabIndex = 17
            AddHandler Me.multiSelect.CheckedChanged, New System.EventHandler(AddressOf Me.multiSelect_CheckedChanged)
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AllowCustomization = False
            Me.layoutControl3.Controls.Add(Me.stretchWidthM)
            Me.layoutControl3.Controls.Add(Me.stretchHeightM)
            Me.layoutControl3.Controls.Add(Me.multiSelect)
            Me.layoutControl3.Controls.Add(Me.spinEdit1)
            Me.layoutControl3.Controls.Add(Me.spinEdit2)
            Me.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(892, 161, 450, 350)
            Me.layoutControl3.Root = Me.layoutControlGroup9
            Me.layoutControl3.Size = New System.Drawing.Size(210, 608)
            Me.layoutControl3.TabIndex = 0
            Me.layoutControl3.Text = "layoutControl3"
            ' 
            ' stretchWidthM
            ' 
            Me.stretchWidthM.Location = New System.Drawing.Point(12, 12)
            Me.stretchWidthM.Name = "stretchWidthM"
            Me.stretchWidthM.Properties.Caption = "Stretch Card to View Width"
            Me.stretchWidthM.Size = New System.Drawing.Size(186, 20)
            Me.stretchWidthM.StyleController = Me.layoutControl3
            Me.stretchWidthM.TabIndex = 10
            AddHandler Me.stretchWidthM.CheckedChanged, New System.EventHandler(AddressOf Me.stretchWidthM_CheckedChanged)
            ' 
            ' stretchHeightM
            ' 
            Me.stretchHeightM.Location = New System.Drawing.Point(12, 36)
            Me.stretchHeightM.Name = "stretchHeightM"
            Me.stretchHeightM.Properties.Caption = "Stretch Card to View Height"
            Me.stretchHeightM.Size = New System.Drawing.Size(186, 20)
            Me.stretchHeightM.StyleController = Me.layoutControl3
            Me.stretchHeightM.TabIndex = 11
            AddHandler Me.stretchHeightM.CheckedChanged, New System.EventHandler(AddressOf Me.stretchHeightM_CheckedChanged)
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(91, 214)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(107, 20)
            Me.spinEdit1.StyleController = Me.layoutControl3
            Me.spinEdit1.TabIndex = 12
            AddHandler Me.spinEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit1_EditValueChanged)
            ' 
            ' spinEdit2
            ' 
            Me.spinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(91, 238)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEdit2.Properties.IsFloatValue = False
            Me.spinEdit2.Properties.Mask.EditMask = "N00"
            Me.spinEdit2.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEdit2.Size = New System.Drawing.Size(107, 20)
            Me.spinEdit2.StyleController = Me.layoutControl3
            Me.spinEdit2.TabIndex = 13
            AddHandler Me.spinEdit2.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit2_EditValueChanged)
            ' 
            ' layoutControlGroup9
            ' 
            Me.layoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup9.GroupBordersVisible = False
            Me.layoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem14, Me.simpleLabelItem2, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem3, Me.emptySpaceItem4, Me.emptySpaceItem5})
            Me.layoutControlGroup9.Name = "Root"
            Me.layoutControlGroup9.Size = New System.Drawing.Size(210, 608)
            Me.layoutControlGroup9.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.stretchWidthM
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.stretchHeightM
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.multiSelect
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 94)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' simpleLabelItem2
            ' 
            Me.simpleLabelItem2.Location = New System.Drawing.Point(0, 118)
            Me.simpleLabelItem2.Name = "simpleLabelItem2"
            Me.simpleLabelItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.simpleLabelItem2.Size = New System.Drawing.Size(190, 17)
            Me.simpleLabelItem2.Text = " (enables marquee selection)"
            Me.simpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.simpleLabelItem2.TextSize = New System.Drawing.Size(138, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.spinEdit1
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 202)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem9.Text = "Max Columns:"
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.spinEdit2
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 226)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem10.Text = "Max Rows:"
            Me.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 250)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(190, 338)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(190, 46)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 135)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(190, 67)
            ' 
            ' cardAlignment
            ' 
            Me.cardAlignment.Location = New System.Drawing.Point(101, 183)
            Me.cardAlignment.Name = "cardAlignment"
            Me.cardAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cardAlignment.Size = New System.Drawing.Size(97, 20)
            Me.cardAlignment.StyleController = Me.layoutControl2
            Me.cardAlignment.TabIndex = 10
            AddHandler Me.cardAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cardAlignment_SelectedIndexChanged)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.stretchWidth)
            Me.layoutControl2.Controls.Add(Me.stretchHeight)
            Me.layoutControl2.Controls.Add(Me.cardAlignment)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1096, 194, 450, 350)
            Me.layoutControl2.Root = Me.layoutControlGroup6
            Me.layoutControl2.Size = New System.Drawing.Size(210, 608)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' stretchWidth
            ' 
            Me.stretchWidth.EditValue = True
            Me.stretchWidth.Location = New System.Drawing.Point(12, 12)
            Me.stretchWidth.Name = "stretchWidth"
            Me.stretchWidth.Properties.Caption = "Stretch Card to View Width"
            Me.stretchWidth.Size = New System.Drawing.Size(186, 20)
            Me.stretchWidth.StyleController = Me.layoutControl2
            Me.stretchWidth.TabIndex = 8
            AddHandler Me.stretchWidth.CheckedChanged, New System.EventHandler(AddressOf Me.stretchWidth_CheckedChanged)
            ' 
            ' stretchHeight
            ' 
            Me.stretchHeight.EditValue = True
            Me.stretchHeight.Location = New System.Drawing.Point(12, 36)
            Me.stretchHeight.Name = "stretchHeight"
            Me.stretchHeight.Properties.Caption = "Stretch Card to View Height"
            Me.stretchHeight.Size = New System.Drawing.Size(186, 20)
            Me.stretchHeight.StyleController = Me.layoutControl2
            Me.stretchHeight.TabIndex = 9
            AddHandler Me.stretchHeight.CheckedChanged, New System.EventHandler(AddressOf Me.stretchHeight_CheckedChanged)
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup6.GroupBordersVisible = False
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem6, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup6.Name = "Root"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(210, 608)
            Me.layoutControlGroup6.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.stretchWidth
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.stretchHeight
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.cardAlignment
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 171)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem6.Text = "Card Alignment:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 195)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(190, 393)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(190, 123)
            ' 
            ' layoutControl4
            ' 
            Me.layoutControl4.AllowCustomization = False
            Me.layoutControl4.Controls.Add(Me.customizationOptions)
            Me.layoutControl4.Controls.Add(Me.allowRuntimeCustomization)
            Me.layoutControl4.Controls.Add(Me.customizeBtn)
            Me.layoutControl4.Controls.Add(Me.advancedCustomization)
            Me.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.Root = Me.layoutControlGroup7
            Me.layoutControl4.Size = New System.Drawing.Size(192, 595)
            Me.layoutControl4.TabIndex = 0
            Me.layoutControl4.Text = "layoutControl4"
            ' 
            ' customizationOptions
            ' 
            Me.customizationOptions.CheckOnClick = True
            Me.customizationOptions.Enabled = False
            Me.customizationOptions.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Layout Tree View", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Hidden Items", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Reset Shrink Buttons", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Card Indents", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Card Captions", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Save Load Layout Buttons", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group View", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Layout", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Cards", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Fields", System.Windows.Forms.CheckState.Checked)})
            Me.customizationOptions.Location = New System.Drawing.Point(10, 68)
            Me.customizationOptions.Name = "customizationOptions"
            Me.customizationOptions.Size = New System.Drawing.Size(172, 188)
            Me.customizationOptions.StyleController = Me.layoutControl4
            Me.customizationOptions.TabIndex = 23
            AddHandler Me.customizationOptions.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.customizationOptionsList_ItemCheck)
            ' 
            ' allowRuntimeCustomization
            ' 
            Me.allowRuntimeCustomization.EditValue = True
            Me.allowRuntimeCustomization.Location = New System.Drawing.Point(10, 10)
            Me.allowRuntimeCustomization.Name = "allowRuntimeCustomization"
            Me.allowRuntimeCustomization.Properties.Caption = "Allow Runtime Customization"
            Me.allowRuntimeCustomization.Size = New System.Drawing.Size(172, 20)
            Me.allowRuntimeCustomization.StyleController = Me.layoutControl4
            Me.allowRuntimeCustomization.TabIndex = 4
            AddHandler Me.allowRuntimeCustomization.CheckedChanged, New System.EventHandler(AddressOf Me.allowRuntimeCustomization_CheckedChanged)
            ' 
            ' customizeBtn
            ' 
            Me.customizeBtn.Location = New System.Drawing.Point(10, 268)
            Me.customizeBtn.Name = "customizeBtn"
            Me.customizeBtn.Size = New System.Drawing.Size(172, 22)
            Me.customizeBtn.StyleController = Me.layoutControl4
            Me.customizeBtn.TabIndex = 7
            Me.customizeBtn.Text = "Customize..."
            AddHandler Me.customizeBtn.Click, New System.EventHandler(AddressOf Me.customizeBtn_Click)
            ' 
            ' advancedCustomization
            ' 
            Me.advancedCustomization.Location = New System.Drawing.Point(10, 42)
            Me.advancedCustomization.Name = "advancedCustomization"
            Me.advancedCustomization.Properties.Caption = "Advanced Options:"
            Me.advancedCustomization.Size = New System.Drawing.Size(172, 20)
            Me.advancedCustomization.StyleController = Me.layoutControl4
            Me.advancedCustomization.TabIndex = 21
            AddHandler Me.advancedCustomization.CheckedChanged, New System.EventHandler(AddressOf Me.advancedCustomization_CheckedChanged)
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup7.GroupBordersVisible = False
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem18, Me.layoutControlItem5, Me.layoutControlItem1, Me.emptySpaceItem7})
            Me.layoutControlGroup7.Name = "layoutControlGroup1"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(192, 595)
            Me.layoutControlGroup7.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.allowRuntimeCustomization
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12)
            Me.layoutControlItem2.Size = New System.Drawing.Size(172, 32)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.Control = Me.advancedCustomization
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 32)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem18.Size = New System.Drawing.Size(172, 26)
            Me.layoutControlItem18.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.customizeBtn
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 258)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem5.Size = New System.Drawing.Size(172, 22)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.customizationOptions
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(1, 200)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12)
            Me.layoutControlItem1.Size = New System.Drawing.Size(172, 200)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 280)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(172, 295)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage3)
            Me.navigationPane1.Controls.Add(Me.navigationPage2)
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Controls.Add(Me.navigationPage4)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationPane1.Location = New System.Drawing.Point(835, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1, Me.navigationPage2, Me.navigationPage3, Me.navigationPage4})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(253, 668)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(253, 668)
            Me.navigationPane1.TabIndex = 9
            Me.navigationPane1.Text = "navigationPane1"
            AddHandler Me.navigationPane1.SelectedPageChanged, New DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(AddressOf Me.navigationPane1_SelectedPageChanged)
            ' 
            ' navigationPage3
            ' 
            Me.navigationPage3.Caption = "MultiRecord Layout"
            Me.navigationPage3.Controls.Add(Me.layoutControl3)
            Me.navigationPage3.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage3.Name = "navigationPage3"
            Me.navigationPage3.Size = New System.Drawing.Size(210, 608)
            ' 
            ' navigationPage2
            ' 
            Me.navigationPage2.Caption = "SingleRecord Layout"
            Me.navigationPage2.Controls.Add(Me.layoutControl2)
            Me.navigationPage2.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage2.Name = "navigationPage2"
            Me.navigationPage2.Size = New System.Drawing.Size(210, 608)
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Runtime Customization"
            Me.navigationPage1.Controls.Add(Me.layoutControl4)
            Me.navigationPage1.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(192, 595)
            ' 
            ' navigationPage4
            ' 
            Me.navigationPage4.Caption = "Custom Events"
            Me.navigationPage4.Controls.Add(Me.layoutControl5)
            Me.navigationPage4.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage4.Name = "navigationPage4"
            Me.navigationPage4.Size = New System.Drawing.Size(210, 608)
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrid.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrid.Name = "pnlGrid"
            Me.pnlGrid.Size = New System.Drawing.Size(835, 668)
            Me.pnlGrid.TabIndex = 10
            ' 
            ' NWindLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "NWindLayout"
            Me.Size = New System.Drawing.Size(1088, 668)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colAddress), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colCity), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colCountry), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colFirstName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colHomePhone), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colLastName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colNotes), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPostalCode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colRegion), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colReportsTo), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colTitle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colTitleOfCourtesy), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Group2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Item12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.item1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsNWindCustomers), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imagesInFields.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl5.ResumeLayout(False)
            CType((Me.visibilityOnlyForFocused.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.photoVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imagesInCaptions.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imagesOnlyForFocused.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.notesVisibility.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.multiSelect.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.stretchWidthM.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stretchHeightM.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.stretchWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stretchHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            CType((Me.customizationOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowRuntimeCustomization.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.advancedCustomization.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage3.ResumeLayout(False)
            Me.navigationPage2.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            Me.navigationPage4.ResumeLayout(False)
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected gridControl1 As DevExpress.XtraGrid.GridControl

        Private dsNWindCustomers As DevExpress.XtraGrid.Demos.dsNWindCustomers

        Protected layoutView As DevExpress.XtraGrid.Views.Layout.LayoutView

        Private colAddress As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colCity As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colCountry As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colFirstName As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colHomePhone As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colLastName As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colNotes As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colPostalCode As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colRegion As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colReportsTo As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colTitle As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private allowRuntimeCustomization As DevExpress.XtraEditors.CheckEdit

        Private customizeBtn As DevExpress.XtraEditors.SimpleButton

        Private stretchWidth As DevExpress.XtraEditors.CheckEdit

        Private stretchHeight As DevExpress.XtraEditors.CheckEdit

        Private cardAlignment As DevExpress.XtraEditors.ImageComboBoxEdit

        Private stretchWidthM As DevExpress.XtraEditors.CheckEdit

        Private stretchHeightM As DevExpress.XtraEditors.CheckEdit

        Private spinEdit2 As DevExpress.XtraEditors.SpinEdit

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private imagesOnlyForFocused As DevExpress.XtraEditors.CheckEdit

        Private imagesInFields As DevExpress.XtraEditors.CheckEdit

        Private imagesInCaptions As DevExpress.XtraEditors.CheckEdit

        Private multiSelect As DevExpress.XtraEditors.CheckEdit

        Private photoVisibility As DevExpress.XtraEditors.CheckEdit

        Private notesVisibility As DevExpress.XtraEditors.CheckEdit

        Private visibilityOnlyForFocused As DevExpress.XtraEditors.CheckEdit

        Private advancedCustomization As DevExpress.XtraEditors.CheckEdit

        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private layoutViewField_colAddress As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colCity As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colCountry As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colFirstName As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colHomePhone As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colLastName As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colNotes As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colPostalCode As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colRegion As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colReportsTo As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colTitle As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colTitleOfCourtesy As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

        Private Group2 As DevExpress.XtraLayout.LayoutControlGroup

        Private Item12 As DevExpress.XtraLayout.EmptySpaceItem

        Private item1 As DevExpress.XtraLayout.SimpleSeparator

        Private layoutControl4 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane

        Private navigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage

        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup

        Private navigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage

        Private navigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage

        Private layoutControl5 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem

        Private emptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private pnlGrid As DevExpress.XtraEditors.PanelControl

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private customizationOptions As DevExpress.XtraEditors.CheckedListBoxControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
