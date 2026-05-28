Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class HitInfo

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
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.textEdit9 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit8 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit7 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit6 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit5 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lcgCell = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciDispText = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciColRowIndexes = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCellValue = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDataField = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgValue = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciValue = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciValueType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciField = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgHeadersArea = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciArea = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciHeaderField = New DevExpress.XtraLayout.LayoutControlItem()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.lciHint = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.textEdit9.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit8.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit7.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit6.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit5.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgCell), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDispText), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciColRowIndexes), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCellValue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDataField), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgValue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciValue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciValueType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciField), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgHeadersArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciHeaderField), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciHint), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(506, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 416)
            Me.sidePanel1.TabIndex = 13
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 416)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 416)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 389)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.textEdit9)
            Me.layoutControl1.Controls.Add(Me.textEdit8)
            Me.layoutControl1.Controls.Add(Me.textEdit7)
            Me.layoutControl1.Controls.Add(Me.textEdit6)
            Me.layoutControl1.Controls.Add(Me.textEdit5)
            Me.layoutControl1.Controls.Add(Me.textEdit4)
            Me.layoutControl1.Controls.Add(Me.textEdit3)
            Me.layoutControl1.Controls.Add(Me.textEdit2)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(814, 294, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 389)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' textEdit9
            ' 
            Me.textEdit9.Location = New System.Drawing.Point(11, 344)
            Me.textEdit9.Name = "textEdit9"
            Me.textEdit9.Size = New System.Drawing.Size(160, 20)
            Me.textEdit9.StyleController = Me.layoutControl1
            Me.textEdit9.TabIndex = 12
            ' 
            ' textEdit8
            ' 
            Me.textEdit8.Location = New System.Drawing.Point(11, 304)
            Me.textEdit8.Name = "textEdit8"
            Me.textEdit8.Size = New System.Drawing.Size(160, 20)
            Me.textEdit8.StyleController = Me.layoutControl1
            Me.textEdit8.TabIndex = 11
            ' 
            ' textEdit7
            ' 
            Me.textEdit7.Location = New System.Drawing.Point(11, 501)
            Me.textEdit7.Name = "textEdit7"
            Me.textEdit7.Size = New System.Drawing.Size(160, 20)
            Me.textEdit7.StyleController = Me.layoutControl1
            Me.textEdit7.TabIndex = 10
            ' 
            ' textEdit6
            ' 
            Me.textEdit6.Location = New System.Drawing.Point(11, 461)
            Me.textEdit6.Name = "textEdit6"
            Me.textEdit6.Size = New System.Drawing.Size(160, 20)
            Me.textEdit6.StyleController = Me.layoutControl1
            Me.textEdit6.TabIndex = 9
            ' 
            ' textEdit5
            ' 
            Me.textEdit5.Location = New System.Drawing.Point(11, 421)
            Me.textEdit5.Name = "textEdit5"
            Me.textEdit5.Size = New System.Drawing.Size(160, 20)
            Me.textEdit5.StyleController = Me.layoutControl1
            Me.textEdit5.TabIndex = 8
            ' 
            ' textEdit4
            ' 
            Me.textEdit4.Location = New System.Drawing.Point(11, 227)
            Me.textEdit4.Name = "textEdit4"
            Me.textEdit4.Size = New System.Drawing.Size(160, 20)
            Me.textEdit4.StyleController = Me.layoutControl1
            Me.textEdit4.TabIndex = 7
            ' 
            ' textEdit3
            ' 
            Me.textEdit3.Location = New System.Drawing.Point(11, 187)
            Me.textEdit3.Name = "textEdit3"
            Me.textEdit3.Size = New System.Drawing.Size(160, 20)
            Me.textEdit3.StyleController = Me.layoutControl1
            Me.textEdit3.TabIndex = 6
            ' 
            ' textEdit2
            ' 
            Me.textEdit2.Location = New System.Drawing.Point(11, 147)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New System.Drawing.Size(160, 20)
            Me.textEdit2.StyleController = Me.layoutControl1
            Me.textEdit2.TabIndex = 5
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(11, 107)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(160, 20)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.lcgCell, Me.lcgValue, Me.lcgHeadersArea, Me.lciHint})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(182, 542)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 532)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(182, 10)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lcgCell
            ' 
            Me.lcgCell.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgCell.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciDispText, Me.lciColRowIndexes, Me.lciCellValue, Me.lciDataField})
            Me.lcgCell.Location = New System.Drawing.Point(0, 61)
            Me.lcgCell.Name = "lcgCell"
            Me.lcgCell.Size = New System.Drawing.Size(182, 197)
            Me.lcgCell.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgCell.Text = "Cell"
            ' 
            ' lciDispText
            ' 
            Me.lciDispText.Control = Me.textEdit1
            Me.lciDispText.Location = New System.Drawing.Point(0, 0)
            Me.lciDispText.Name = "lciDispText"
            Me.lciDispText.Size = New System.Drawing.Size(164, 40)
            Me.lciDispText.Text = "Display Text:"
            Me.lciDispText.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciDispText.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciColRowIndexes
            ' 
            Me.lciColRowIndexes.Control = Me.textEdit2
            Me.lciColRowIndexes.Location = New System.Drawing.Point(0, 40)
            Me.lciColRowIndexes.Name = "lciColRowIndexes"
            Me.lciColRowIndexes.Size = New System.Drawing.Size(164, 40)
            Me.lciColRowIndexes.Text = "Column, Row Indexes:"
            Me.lciColRowIndexes.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciColRowIndexes.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciCellValue
            ' 
            Me.lciCellValue.Control = Me.textEdit3
            Me.lciCellValue.Location = New System.Drawing.Point(0, 80)
            Me.lciCellValue.Name = "lciCellValue"
            Me.lciCellValue.Size = New System.Drawing.Size(164, 40)
            Me.lciCellValue.Text = "Value:"
            Me.lciCellValue.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciCellValue.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciDataField
            ' 
            Me.lciDataField.Control = Me.textEdit4
            Me.lciDataField.Location = New System.Drawing.Point(0, 120)
            Me.lciDataField.Name = "lciDataField"
            Me.lciDataField.Size = New System.Drawing.Size(164, 40)
            Me.lciDataField.Text = "Data Field:"
            Me.lciDataField.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciDataField.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lcgValue
            ' 
            Me.lcgValue.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgValue.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciValue, Me.lciValueType, Me.lciField})
            Me.lcgValue.Location = New System.Drawing.Point(0, 375)
            Me.lcgValue.Name = "lcgValue"
            Me.lcgValue.Size = New System.Drawing.Size(182, 157)
            Me.lcgValue.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgValue.Text = "Value"
            ' 
            ' lciValue
            ' 
            Me.lciValue.Control = Me.textEdit5
            Me.lciValue.Location = New System.Drawing.Point(0, 0)
            Me.lciValue.Name = "lciValue"
            Me.lciValue.Size = New System.Drawing.Size(164, 40)
            Me.lciValue.Text = "Value:"
            Me.lciValue.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciValue.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciValueType
            ' 
            Me.lciValueType.Control = Me.textEdit6
            Me.lciValueType.Location = New System.Drawing.Point(0, 40)
            Me.lciValueType.Name = "lciValueType"
            Me.lciValueType.Size = New System.Drawing.Size(164, 40)
            Me.lciValueType.Text = "Value Type:"
            Me.lciValueType.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciValueType.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciField
            ' 
            Me.lciField.Control = Me.textEdit7
            Me.lciField.Location = New System.Drawing.Point(0, 80)
            Me.lciField.Name = "lciField"
            Me.lciField.Size = New System.Drawing.Size(164, 40)
            Me.lciField.Text = "Field:"
            Me.lciField.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciField.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lcgHeadersArea
            ' 
            Me.lcgHeadersArea.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgHeadersArea.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciArea, Me.lciHeaderField})
            Me.lcgHeadersArea.Location = New System.Drawing.Point(0, 258)
            Me.lcgHeadersArea.Name = "lcgHeadersArea"
            Me.lcgHeadersArea.Size = New System.Drawing.Size(182, 117)
            Me.lcgHeadersArea.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgHeadersArea.Text = "Headers Area"
            ' 
            ' lciArea
            ' 
            Me.lciArea.Control = Me.textEdit8
            Me.lciArea.Location = New System.Drawing.Point(0, 0)
            Me.lciArea.Name = "lciArea"
            Me.lciArea.Size = New System.Drawing.Size(164, 40)
            Me.lciArea.Text = "Area:"
            Me.lciArea.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciArea.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' lciHeaderField
            ' 
            Me.lciHeaderField.Control = Me.textEdit9
            Me.lciHeaderField.Location = New System.Drawing.Point(0, 40)
            Me.lciHeaderField.Name = "lciHeaderField"
            Me.lciHeaderField.Size = New System.Drawing.Size(164, 40)
            Me.lciHeaderField.Text = "Field:"
            Me.lciHeaderField.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciHeaderField.TextSize = New System.Drawing.Size(109, 13)
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 1
            Me.fieldExtendedPrice.Caption = "Order Amount"
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.FieldName = "Country"
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 1
            Me.fieldSalesPerson.Caption = "Sales Person"
            Me.fieldSalesPerson.FieldName = "Sales Person"
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.Width = 140
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 180
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 160
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson, Me.fieldCountry, Me.fieldQuantity, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(506, 416)
            Me.pivotGridControl1.TabIndex = 11
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            AddHandler Me.pivotGridControl1.MouseLeave, New System.EventHandler(AddressOf Me.pivotGridControl1_MouseLeave)
            AddHandler Me.pivotGridControl1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pivotGridControl1_MouseMove)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Location = New System.Drawing.Point(2, 2)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Padding = New System.Windows.Forms.Padding(9)
            Me.labelControl1.Size = New System.Drawing.Size(178, 57)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 13
            Me.labelControl1.Text = "Hover the mouse over the PivotGrid to display information about its elements."
            ' 
            ' lciHint
            ' 
            Me.lciHint.Control = Me.labelControl1
            Me.lciHint.Location = New System.Drawing.Point(0, 0)
            Me.lciHint.Name = "lciHint"
            Me.lciHint.Size = New System.Drawing.Size(182, 61)
            Me.lciHint.TextSize = New System.Drawing.Size(0, 0)
            Me.lciHint.TextVisible = False
            ' 
            ' HitInfo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "HitInfo"
            Me.Size = New System.Drawing.Size(706, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.HitInfo_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.textEdit9.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit8.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit7.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit6.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit5.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgCell), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDispText), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciColRowIndexes), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCellValue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDataField), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgValue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciValue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciValueType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciField), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgHeadersArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciHeaderField), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciHint), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private components As System.ComponentModel.IContainer = Nothing

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private textEdit4 As DevExpress.XtraEditors.TextEdit

        Private textEdit3 As DevExpress.XtraEditors.TextEdit

        Private textEdit2 As DevExpress.XtraEditors.TextEdit

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private lcgCell As DevExpress.XtraLayout.LayoutControlGroup

        Private lciDispText As DevExpress.XtraLayout.LayoutControlItem

        Private lciColRowIndexes As DevExpress.XtraLayout.LayoutControlItem

        Private lciCellValue As DevExpress.XtraLayout.LayoutControlItem

        Private lciDataField As DevExpress.XtraLayout.LayoutControlItem

        Private textEdit7 As DevExpress.XtraEditors.TextEdit

        Private textEdit6 As DevExpress.XtraEditors.TextEdit

        Private textEdit5 As DevExpress.XtraEditors.TextEdit

        Private lcgValue As DevExpress.XtraLayout.LayoutControlGroup

        Private lciValue As DevExpress.XtraLayout.LayoutControlItem

        Private lciValueType As DevExpress.XtraLayout.LayoutControlItem

        Private lciField As DevExpress.XtraLayout.LayoutControlItem

        Private textEdit9 As DevExpress.XtraEditors.TextEdit

        Private textEdit8 As DevExpress.XtraEditors.TextEdit

        Private lcgHeadersArea As DevExpress.XtraLayout.LayoutControlGroup

        Private lciArea As DevExpress.XtraLayout.LayoutControlItem

        Private lciHeaderField As DevExpress.XtraLayout.LayoutControlItem

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private lciHint As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
