Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class TopValues

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
            Dim pivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Dim pivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Dim pivotGridStyleFormatCondition3 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.ceTopValuesShowOthers = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbField = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.seTop = New DevExpress.XtraEditors.SpinEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceTopValuesShowOthers.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbField.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seTop.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' ceTopValuesShowOthers
            ' 
            Me.ceTopValuesShowOthers.Location = New System.Drawing.Point(11, 112)
            Me.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers"
            Me.ceTopValuesShowOthers.Properties.Caption = "Show ""Others"" value"
            Me.ceTopValuesShowOthers.Size = New System.Drawing.Size(177, 19)
            Me.ceTopValuesShowOthers.StyleController = Me.layoutControl1
            Me.ceTopValuesShowOthers.TabIndex = 2
            AddHandler Me.ceTopValuesShowOthers.CheckedChanged, New System.EventHandler(AddressOf Me.ceTopValuesShowOthers_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceTopValuesShowOthers)
            Me.layoutControl1.Controls.Add(Me.icbField)
            Me.layoutControl1.Controls.Add(Me.label1)
            Me.layoutControl1.Controls.Add(Me.seTop)
            Me.layoutControl1.Controls.Add(Me.label2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(450, 357, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 509)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbField
            ' 
            Me.icbField.EditValue = "imageComboBoxEdit1"
            Me.icbField.Location = New System.Drawing.Point(11, 88)
            Me.icbField.Name = "icbField"
            Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbField.Size = New System.Drawing.Size(177, 20)
            Me.icbField.StyleController = Me.layoutControl1
            Me.icbField.TabIndex = 1
            AddHandler Me.icbField.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbField_SelectedIndexChanged)
            ' 
            ' label1
            ' 
            Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.label1.Appearance.Options.UseBackColor = True
            Me.label1.Location = New System.Drawing.Point(11, 71)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(99, 13)
            Me.label1.StyleController = Me.layoutControl1
            Me.label1.TabIndex = 8
            Me.label1.Text = "Values for the Field: "
            ' 
            ' seTop
            ' 
            Me.seTop.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.seTop.Location = New System.Drawing.Point(11, 47)
            Me.seTop.Name = "seTop"
            Me.seTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seTop.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seTop.Properties.IsFloatValue = False
            Me.seTop.Properties.Mask.EditMask = "N00"
            Me.seTop.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.seTop.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seTop.Size = New System.Drawing.Size(177, 20)
            Me.seTop.StyleController = Me.layoutControl1
            Me.seTop.TabIndex = 0
            AddHandler Me.seTop.EditValueChanged, New System.EventHandler(AddressOf Me.seTop_EditValueChanged)
            ' 
            ' label2
            ' 
            Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.label2.Appearance.Options.UseBackColor = True
            Me.label2.Location = New System.Drawing.Point(11, 30)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(51, 13)
            Me.label2.StyleController = Me.layoutControl1
            Me.label2.TabIndex = 6
            Me.label2.Text = "Show Top:"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 509)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.label2
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(181, 17)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 142)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 367)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.seTop
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(181, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.label1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 41)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(181, 17)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbField
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(181, 24)
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceTopValuesShowOthers
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(677, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 536)
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 536)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 536)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 509)
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Order Amount"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Width = 120
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 2
            Me.fieldSalesPerson.Caption = "Sales Person"
            Me.fieldSalesPerson.FieldName = "Sales Person"
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.SortBySummaryInfo.Field = Me.fieldExtendedPrice
            Me.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldSalesPerson.Width = 140
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 3
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.SortBySummaryInfo.Field = Me.fieldExtendedPrice
            Me.fieldProductName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldProductName.Width = 180
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 1
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.SortBySummaryInfo.Field = Me.fieldExtendedPrice
            Me.fieldCategoryName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldCategoryName.Width = 160
            ' 
            ' fieldOrderID
            ' 
            Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderID.AreaIndex = 0
            Me.fieldOrderID.Caption = "Order ID"
            Me.fieldOrderID.FieldName = "OrderID"
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.SortBySummaryInfo.Field = Me.fieldExtendedPrice
            Me.fieldOrderID.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderID, Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson, Me.fieldExtendedPrice})
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition1.ApplyToTotalCell = False
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition1.FieldName = ""
            pivotGridStyleFormatCondition1.Value1 = 10000
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition2.ApplyToTotalCell = False
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition2.FieldName = ""
            pivotGridStyleFormatCondition2.Value1 = 350
            pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green
            pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition3.ApplyToTotalCell = False
            pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition3.FieldName = ""
            pivotGridStyleFormatCondition3.Value1 = 0.1F
            Me.pivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {pivotGridStyleFormatCondition1, pivotGridStyleFormatCondition2, pivotGridStyleFormatCondition3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(677, 536)
            Me.pivotGridControl1.TabIndex = 12
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            AddHandler Me.pivotGridControl1.CustomDrawFieldValue, New DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(AddressOf Me.pivotGridControl1_CustomDrawFieldValue)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 142)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Top N"
            ' 
            ' TopValues
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TopValues"
            Me.Size = New System.Drawing.Size(877, 536)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.TopValues_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceTopValuesShowOthers.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbField.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seTop.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private label2 As DevExpress.XtraEditors.LabelControl

        Private icbField As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seTop As DevExpress.XtraEditors.SpinEdit

        Private label1 As DevExpress.XtraEditors.LabelControl

        Private ceTopValuesShowOthers As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderID As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
