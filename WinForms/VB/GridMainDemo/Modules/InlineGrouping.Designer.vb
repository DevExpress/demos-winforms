Namespace DevExpress.XtraGrid.Demos

    Partial Class InlineGrouping

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
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.InlineGrouping))
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceGroupExpandedOnSorting = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAutoExpandAllGroups = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowExpandCollapseButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.icbGroupDrawMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAllowPartialGroups = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colTrademarkImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceGroupExpandedOnSorting.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAutoExpandAllGroups.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowExpandCollapseButtons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbGroupDrawMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowPartialGroups.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' colInStock
            ' 
            Me.colInStock.FieldName = "InStock"
            Me.colInStock.Name = "colInStock"
            Me.colInStock.Width = 90
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 591)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 591)
            Me.navigationPane1.TabIndex = 8
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 558)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceGroupExpandedOnSorting)
            Me.layoutControl1.Controls.Add(Me.ceAutoExpandAllGroups)
            Me.layoutControl1.Controls.Add(Me.ceShowExpandCollapseButtons)
            Me.layoutControl1.Controls.Add(Me.icbGroupDrawMode)
            Me.layoutControl1.Controls.Add(Me.ceAllowPartialGroups)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(217, 154, 450, 346)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 558)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceGroupExpandedOnSorting
            ' 
            Me.ceGroupExpandedOnSorting.Location = New System.Drawing.Point(12, 82)
            Me.ceGroupExpandedOnSorting.Name = "ceGroupExpandedOnSorting"
            Me.ceGroupExpandedOnSorting.Properties.Caption = "Keep Group Expanded On Sorting"
            Me.ceGroupExpandedOnSorting.Size = New System.Drawing.Size(225, 20)
            Me.ceGroupExpandedOnSorting.StyleController = Me.layoutControl1
            Me.ceGroupExpandedOnSorting.TabIndex = 8
            AddHandler Me.ceGroupExpandedOnSorting.CheckedChanged, New System.EventHandler(AddressOf Me.ceGroupExpandedOnSorting_CheckedChanged)
            ' 
            ' ceAutoExpandAllGroups
            ' 
            Me.ceAutoExpandAllGroups.Location = New System.Drawing.Point(12, 58)
            Me.ceAutoExpandAllGroups.Name = "ceAutoExpandAllGroups"
            Me.ceAutoExpandAllGroups.Properties.Caption = "Auto Expand All Groups"
            Me.ceAutoExpandAllGroups.Size = New System.Drawing.Size(225, 20)
            Me.ceAutoExpandAllGroups.StyleController = Me.layoutControl1
            Me.ceAutoExpandAllGroups.TabIndex = 7
            AddHandler Me.ceAutoExpandAllGroups.CheckedChanged, New System.EventHandler(AddressOf Me.ceAutoExpandAllGroups_CheckedChanged)
            ' 
            ' ceShowExpandCollapseButtons
            ' 
            Me.ceShowExpandCollapseButtons.Location = New System.Drawing.Point(12, 188)
            Me.ceShowExpandCollapseButtons.Name = "ceShowExpandCollapseButtons"
            Me.ceShowExpandCollapseButtons.Properties.Caption = "Show Group Buttons"
            Me.ceShowExpandCollapseButtons.Size = New System.Drawing.Size(225, 20)
            Me.ceShowExpandCollapseButtons.StyleController = Me.layoutControl1
            Me.ceShowExpandCollapseButtons.TabIndex = 6
            AddHandler Me.ceShowExpandCollapseButtons.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowExpandCollapsButtons_CheckedChanged)
            ' 
            ' icbGroupDrawMode
            ' 
            Me.icbGroupDrawMode.Location = New System.Drawing.Point(12, 164)
            Me.icbGroupDrawMode.Name = "icbGroupDrawMode"
            Me.icbGroupDrawMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbGroupDrawMode.Size = New System.Drawing.Size(225, 20)
            Me.icbGroupDrawMode.StyleController = Me.layoutControl1
            Me.icbGroupDrawMode.TabIndex = 5
            AddHandler Me.icbGroupDrawMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbGroupDrawMode_SelectedIndexChanged)
            ' 
            ' ceAllowPartialGroups
            ' 
            Me.ceAllowPartialGroups.Location = New System.Drawing.Point(12, 34)
            Me.ceAllowPartialGroups.Name = "ceAllowPartialGroups"
            Me.ceAllowPartialGroups.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceAllowPartialGroups.Properties.Caption = "<b>Allow Partial Groups"
            Me.ceAllowPartialGroups.Size = New System.Drawing.Size(225, 20)
            Me.ceAllowPartialGroups.StyleController = Me.layoutControl1
            Me.ceAllowPartialGroups.TabIndex = 4
            AddHandler Me.ceAllowPartialGroups.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowPartialGroups_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 558)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 220)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(249, 338)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 106)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Appearance"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbGroupDrawMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem2.Text = "Group Draw Mode:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceShowExpandCollapseButtons
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem1})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(249, 114)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "Behavior"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceAutoExpandAllGroups
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceGroupExpandedOnSorting
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAllowPartialGroups
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(705, 591)
            Me.panel1.TabIndex = 9
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(705, 591)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTrademarkImage, Me.colTrademark, Me.colName, Me.colModification, Me.colCategory, Me.colPrice, Me.colBodyStyle, Me.colDescription, Me.colDeliveryDate, Me.colInStock, Me.colPhoto})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.colInStock
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DarkGray
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue1.PredefinedName = "Strikeout Text"
            formatConditionRuleValue1.Value1 = False
            gridFormatRule1.Rule = formatConditionRuleValue1
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDeliveryDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colTrademarkImage
            ' 
            Me.colTrademarkImage.FieldName = "TrademarkImage"
            Me.colTrademarkImage.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.colTrademarkImage.ImageOptions.SvgImage = CType((resources.GetObject("colTrademarkImage.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colTrademarkImage.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colTrademarkImage.Name = "colTrademarkImage"
            Me.colTrademarkImage.OptionsColumn.AllowFocus = False
            Me.colTrademarkImage.OptionsColumn.AllowSize = False
            Me.colTrademarkImage.OptionsColumn.FixedWidth = True
            Me.colTrademarkImage.OptionsColumn.ShowCaption = False
            Me.colTrademarkImage.OptionsFilter.AllowFilter = False
            Me.colTrademarkImage.Visible = True
            Me.colTrademarkImage.VisibleIndex = 1
            Me.colTrademarkImage.Width = 66
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 2
            Me.colTrademark.Width = 142
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 3
            Me.colName.Width = 131
            ' 
            ' colModification
            ' 
            Me.colModification.FieldName = "Modification"
            Me.colModification.Name = "colModification"
            Me.colModification.Visible = True
            Me.colModification.VisibleIndex = 4
            Me.colModification.Width = 134
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 5
            Me.colCategory.Width = 130
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 6
            Me.colPrice.Width = 121
            ' 
            ' colBodyStyle
            ' 
            Me.colBodyStyle.FieldName = "BodyStyle"
            Me.colBodyStyle.Name = "colBodyStyle"
            Me.colBodyStyle.Width = 117
            ' 
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 7
            Me.colDescription.Width = 83
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormMinSize = New System.Drawing.Size(300, 150)
            ' 
            ' colDeliveryDate
            ' 
            Me.colDeliveryDate.FieldName = "DeliveryDate"
            Me.colDeliveryDate.Name = "colDeliveryDate"
            Me.colDeliveryDate.Visible = True
            Me.colDeliveryDate.VisibleIndex = 0
            Me.colDeliveryDate.Width = 127
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemImageEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.colPhoto.Width = 91
            ' 
            ' repositoryItemImageEdit1
            ' 
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormMinSize = New System.Drawing.Size(300, 150)
            Me.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(705, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 591)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' InlineGrouping
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "InlineGrouping"
            Me.Size = New System.Drawing.Size(955, 591)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceGroupExpandedOnSorting.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAutoExpandAllGroups.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowExpandCollapseButtons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbGroupDrawMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowPartialGroups.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private panel1 As System.Windows.Forms.Panel

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colTrademarkImage As DevExpress.XtraGrid.Columns.GridColumn

        Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colModification As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colBodyStyle As DevExpress.XtraGrid.Columns.GridColumn

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colInStock As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit

        Private ceAllowPartialGroups As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private icbGroupDrawMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private ceShowExpandCollapseButtons As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private ceGroupExpandedOnSorting As DevExpress.XtraEditors.CheckEdit

        Private ceAutoExpandAllGroups As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
