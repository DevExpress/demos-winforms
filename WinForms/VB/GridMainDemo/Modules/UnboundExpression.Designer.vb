Namespace DevExpress.XtraGrid.Demos

    Partial Class UnboundExpression

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.UnboundExpression))
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.imageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.imageListBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridColumn7
            ' 
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            Me.gridColumn7.DisplayFormat.FormatString = "c"
            Me.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn7.FieldName = "DiscountAmount"
            Me.gridColumn7.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn7.ImageOptions.ImageIndex"))))
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.OptionsColumn.AllowEdit = False
            Me.gridColumn7.ShowUnboundExpressionMenu = True
            Me.gridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn7.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("gridColumn7.Summary1"), resources.GetString("gridColumn7.Summary2"))})
            Me.gridColumn7.UnboundDataType = GetType(Decimal)
            Me.gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]"
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.DisplayFormat.FormatString = "c"
            Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn6.FieldName = "Total"
            Me.gridColumn6.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn6.ImageOptions.ImageIndex"))))
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowEdit = False
            Me.gridColumn6.ShowUnboundExpressionMenu = True
            Me.gridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn6.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("gridColumn6.Summary1"), resources.GetString("gridColumn6.Summary2"))})
            Me.gridColumn6.UnboundDataType = GetType(Decimal)
            Me.gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gridColumn5.DisplayFormat.FormatString = "p"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn5.FieldName = "Discount"
            Me.gridColumn5.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn5.ImageOptions.ImageIndex"))))
            Me.gridColumn5.Name = "gridColumn5"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            gridFormatRule1.Column = Me.gridColumn7
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue1.PredefinedName = "Green Fill"
            formatConditionRuleValue1.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
            gridFormatRule1.Rule = formatConditionRuleValue1
            gridFormatRule2.Column = Me.gridColumn6
            gridFormatRule2.Name = "Format1"
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            formatConditionRuleValue2.PredefinedName = "Red Bold Text"
            formatConditionRuleValue2.Value1 = 1000
            gridFormatRule2.Rule = formatConditionRuleValue2
            gridFormatRule3.Column = Me.gridColumn5
            gridFormatRule3.Name = "Format2"
            formatConditionIconSet1.CategoryName = "Directional"
            formatConditionIconSetIcon1.PredefinedName = "Arrows5_1.png"
            formatConditionIconSetIcon1.Value = New Decimal(New Integer() {80, 0, 0, 0})
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon2.PredefinedName = "Arrows5_2.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() {60, 0, 0, 0})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon3.PredefinedName = "Arrows5_3.png"
            formatConditionIconSetIcon3.Value = New Decimal(New Integer() {40, 0, 0, 0})
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon4.PredefinedName = "Arrows5_4.png"
            formatConditionIconSetIcon4.Value = New Decimal(New Integer() {20, 0, 0, 0})
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon5.PredefinedName = "Arrows5_5.png"
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon5)
            formatConditionIconSet1.Name = "Arrows5Colored"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            gridFormatRule3.Rule = formatConditionRuleIconSet1
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.FormatRules.Add(gridFormatRule2)
            Me.gridView1.FormatRules.Add(gridFormatRule3)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary4")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary5"), CType((resources.GetObject("gridView1.GroupSummary6")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary7"))})
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "OrderID"
            Me.gridColumn1.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn1.ImageOptions.ImageIndex"))))
            Me.gridColumn1.Name = "gridColumn1"
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumn2.FieldName = "ProductID"
            Me.gridColumn2.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn2.ImageOptions.ImageIndex"))))
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn2.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' gridColumn3
            ' 
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "UnitPrice"
            Me.gridColumn3.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn3.ImageOptions.ImageIndex"))))
            Me.gridColumn3.Name = "gridColumn3"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemCalcEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemCalcEdit1.Mask.EditMask = resources.GetString("repositoryItemCalcEdit1.Mask.EditMask")
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' gridColumn4
            ' 
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn4.FieldName = "Quantity"
            Me.gridColumn4.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn4.ImageOptions.ImageIndex"))))
            Me.gridColumn4.Name = "gridColumn4"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Discount", CType((resources.GetObject("svgImageCollection1.Discount")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Sales", CType((resources.GetObject("svgImageCollection1.Sales")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("UnitPrice", CType((resources.GetObject("svgImageCollection1.UnitPrice")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Quantity", CType((resources.GetObject("svgImageCollection1.Quantity")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("bo_order_item", "image://svgimages/business objects/bo_order_item.svg")
            Me.svgImageCollection1.Add("amount", CType((resources.GetObject("svgImageCollection1.amount")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.simpleButton1.Appearance.Options.UseTextOptions = True
            Me.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.imageListBoxControl1)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' imageListBoxControl1
            ' 
            Me.imageListBoxControl1.ImageList = Me.svgImageCollection1
            resources.ApplyResources(Me.imageListBoxControl1, "imageListBoxControl1")
            Me.imageListBoxControl1.Name = "imageListBoxControl1"
            Me.imageListBoxControl1.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 446)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 171)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 275)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 171)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.imageListBoxControl1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 95)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(39, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.simpleButton1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 95)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 34)
            Me.layoutControlItem2.TextVisible = False
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 479)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' UnboundExpression
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "UnboundExpression"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.UnboundExpression_Load)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.imageListBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private imageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
