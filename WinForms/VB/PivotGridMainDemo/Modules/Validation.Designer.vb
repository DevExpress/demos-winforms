Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class Validation

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.spinEdit4 = New DevExpress.XtraEditors.SpinEdit()
            Me.imageComboBoxEdit4 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection()
            Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
            Me.imageComboBoxEdit3 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
            Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl)
            Me.mainPanel.Controls.Add(Me.sidePanel1)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(700, 400)
            Me.mainPanel.TabIndex = 5
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.ActiveFilterString = ""
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldQuantity, Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemCalcEdit1})
            Me.pivotGridControl.Size = New System.Drawing.Size(500, 400)
            Me.pivotGridControl.TabIndex = 0
            AddHandler Me.pivotGridControl.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl_FieldValueImageIndex)
            AddHandler Me.pivotGridControl.CustomAppearance, New DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(AddressOf Me.pivotGridControl_CustomAppearance)
            AddHandler Me.pivotGridControl.EditValueChanged, New DevExpress.XtraPivotGrid.EditValueChangedEventHandler(AddressOf Me.pivotGridControl_EditorValueChanged)
            AddHandler Me.pivotGridControl.ValidatingEditor, New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(AddressOf Me.pivotGridControl_ValidatingEditor)
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.FieldEdit = Me.repositoryItemCalcEdit1
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.FieldName = "Sales Person"
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(500, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 400)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 400)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 400)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 373)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.spinEdit4)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit4)
            Me.layoutControl1.Controls.Add(Me.spinEdit3)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit3)
            Me.layoutControl1.Controls.Add(Me.spinEdit2)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit2)
            Me.layoutControl1.Controls.Add(Me.spinEdit1)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1106, 123, 770, 911)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 373)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "`"
            ' 
            ' spinEdit4
            ' 
            Me.spinEdit4.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEdit4.Location = New System.Drawing.Point(111, 142)
            Me.spinEdit4.Name = "spinEdit4"
            Me.spinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit4.Properties.ValidateOnEnterKey = True
            Me.spinEdit4.Size = New System.Drawing.Size(76, 20)
            Me.spinEdit4.StyleController = Me.layoutControl1
            Me.spinEdit4.TabIndex = 8
            ' 
            ' imageComboBoxEdit4
            ' 
            Me.imageComboBoxEdit4.EditValue = 2
            Me.imageComboBoxEdit4.Location = New System.Drawing.Point(57, 142)
            Me.imageComboBoxEdit4.Name = "imageComboBoxEdit4"
            Me.imageComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit4.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.imageComboBoxEdit4.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3)})
            Me.imageComboBoxEdit4.Properties.SmallImages = Me.svgImageCollection1
            Me.imageComboBoxEdit4.Size = New System.Drawing.Size(50, 20)
            Me.imageComboBoxEdit4.StyleController = Me.layoutControl1
            Me.imageComboBoxEdit4.TabIndex = 6
            ' 
            ' spinEdit3
            ' 
            Me.spinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit3.Location = New System.Drawing.Point(111, 118)
            Me.spinEdit3.Name = "spinEdit3"
            Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit3.Properties.ValidateOnEnterKey = True
            Me.spinEdit3.Size = New System.Drawing.Size(76, 20)
            Me.spinEdit3.StyleController = Me.layoutControl1
            Me.spinEdit3.TabIndex = 4
            ' 
            ' imageComboBoxEdit3
            ' 
            Me.imageComboBoxEdit3.EditValue = 0
            Me.imageComboBoxEdit3.Location = New System.Drawing.Point(57, 118)
            Me.imageComboBoxEdit3.Name = "imageComboBoxEdit3"
            Me.imageComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit3.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.imageComboBoxEdit3.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 4)})
            Me.imageComboBoxEdit3.Properties.SmallImages = Me.svgImageCollection1
            Me.imageComboBoxEdit3.Size = New System.Drawing.Size(50, 20)
            Me.imageComboBoxEdit3.StyleController = Me.layoutControl1
            Me.imageComboBoxEdit3.TabIndex = 7
            Me.imageComboBoxEdit3.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.[Object]
            ' 
            ' spinEdit2
            ' 
            Me.spinEdit2.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(111, 55)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit2.Properties.ValidateOnEnterKey = True
            Me.spinEdit2.Size = New System.Drawing.Size(76, 20)
            Me.spinEdit2.StyleController = Me.layoutControl1
            Me.spinEdit2.TabIndex = 7
            ' 
            ' imageComboBoxEdit2
            ' 
            Me.imageComboBoxEdit2.EditValue = 2
            Me.imageComboBoxEdit2.Location = New System.Drawing.Point(57, 55)
            Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
            Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.imageComboBoxEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3)})
            Me.imageComboBoxEdit2.Properties.SmallImages = Me.svgImageCollection1
            Me.imageComboBoxEdit2.Size = New System.Drawing.Size(50, 20)
            Me.imageComboBoxEdit2.StyleController = Me.layoutControl1
            Me.imageComboBoxEdit2.TabIndex = 5
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(111, 31)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.ValidateOnEnterKey = True
            Me.spinEdit1.Size = New System.Drawing.Size(76, 20)
            Me.spinEdit1.StyleController = Me.layoutControl1
            Me.spinEdit1.TabIndex = 3
            ' 
            ' imageComboBoxEdit1
            ' 
            Me.imageComboBoxEdit1.EditValue = 0
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(57, 31)
            Me.imageComboBoxEdit1.Margin = New System.Windows.Forms.Padding(0)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 4)})
            Me.imageComboBoxEdit1.Properties.SmallImages = Me.svgImageCollection1
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(50, 20)
            Me.imageComboBoxEdit1.StyleController = Me.layoutControl1
            Me.imageComboBoxEdit1.TabIndex = 6
            Me.imageComboBoxEdit1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.[Object]
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.emptySpaceItem1, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 373)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem5, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 87)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Common Cells Rules"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem6.Control = Me.imageComboBoxEdit2
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(99, 24)
            Me.layoutControlItem6.Text = "and"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.spinEdit2
            Me.layoutControlItem7.Location = New System.Drawing.Point(99, 24)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(80, 24)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.imageComboBoxEdit1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(99, 24)
            Me.layoutControlItem5.Text = "Quantity"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.spinEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(99, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(80, 24)
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 174)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 199)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 87)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 87)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = " Total or Grand Total Rules"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.imageComboBoxEdit3
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(99, 24)
            Me.layoutControlItem2.Text = "Quantity"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.spinEdit3
            Me.layoutControlItem8.Location = New System.Drawing.Point(99, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(80, 24)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem9.Control = Me.imageComboBoxEdit4
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(99, 24)
            Me.layoutControlItem9.Text = "and"
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.spinEdit4
            Me.layoutControlItem10.Location = New System.Drawing.Point(99, 24)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(80, 24)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' Validation
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Name = "Validation"
            Me.Size = New System.Drawing.Size(700, 400)
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private mainPanel As DevExpress.XtraEditors.PanelControl

#End Region
        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Public imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Public spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Public imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Public spinEdit2 As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Public spinEdit4 As DevExpress.XtraEditors.SpinEdit

        Public imageComboBoxEdit4 As DevExpress.XtraEditors.ImageComboBoxEdit

        Public spinEdit3 As DevExpress.XtraEditors.SpinEdit

        Public imageComboBoxEdit3 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
