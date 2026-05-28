Namespace DevExpress.XtraGrid.Demos

    Partial Class VirtualServerMode

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
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.VirtualServerMode))
            Me.bcDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbRefresh = New DevExpress.XtraEditors.SimpleButton()
            Me.seBatchCount = New DevExpress.XtraEditors.SpinEdit()
            Me.seRowCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.virtualServerModeSource1 = New DevExpress.Data.VirtualServerModeSource(Me.components)
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.bcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colOrderID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcSalesID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemHypertextLabel1 = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
            Me.bcSalesDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.seBatchCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seRowCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.virtualServerModeSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemHypertextLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bcDiscount
            ' 
            Me.bcDiscount.ColumnEdit = Me.repositoryItemTextEdit4
            Me.bcDiscount.FieldName = "Discount"
            Me.bcDiscount.Name = "bcDiscount"
            Me.bcDiscount.Visible = True
            Me.bcDiscount.Width = 69
            ' 
            ' repositoryItemTextEdit4
            ' 
            Me.repositoryItemTextEdit4.AutoHeight = False
            Me.repositoryItemTextEdit4.Mask.EditMask = "p"
            Me.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            ' 
            ' bcPrice
            ' 
            Me.bcPrice.FieldName = "ModelPrice"
            Me.bcPrice.Name = "bcPrice"
            Me.bcPrice.Visible = True
            Me.bcPrice.Width = 137
            ' 
            ' bcMPGCity
            ' 
            Me.bcMPGCity.Caption = "MPG <b>City"
            Me.bcMPGCity.FieldName = "MPGCity"
            Me.bcMPGCity.Name = "bcMPGCity"
            Me.bcMPGCity.Visible = True
            ' 
            ' bcMPGHighway
            ' 
            Me.bcMPGHighway.Caption = "MPG <b>Highway"
            Me.bcMPGHighway.FieldName = "MPGHighway"
            Me.bcMPGHighway.Name = "bcMPGHighway"
            Me.bcMPGHighway.Visible = True
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(794, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 642)
            Me.sidePanel1.TabIndex = 6
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 642)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 642)
            Me.navigationPane1.TabIndex = 10
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 613)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbRefresh)
            Me.layoutControl1.Controls.Add(Me.seBatchCount)
            Me.layoutControl1.Controls.Add(Me.seRowCount)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(754, 346, 1017, 646)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 613)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' sbRefresh
            ' 
            Me.sbRefresh.Location = New System.Drawing.Point(12, 70)
            Me.sbRefresh.Name = "sbRefresh"
            Me.sbRefresh.Size = New System.Drawing.Size(225, 22)
            Me.sbRefresh.StyleController = Me.layoutControl1
            Me.sbRefresh.TabIndex = 6
            Me.sbRefresh.Text = "Refresh Data Source"
            AddHandler Me.sbRefresh.Click, New System.EventHandler(AddressOf Me.sbRefresh_Click)
            ' 
            ' seBatchCount
            ' 
            Me.seBatchCount.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seBatchCount.Location = New System.Drawing.Point(74, 36)
            Me.seBatchCount.Name = "seBatchCount"
            Me.seBatchCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seBatchCount.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.seBatchCount.Properties.IsFloatValue = False
            Me.seBatchCount.Properties.Mask.EditMask = "N00"
            Me.seBatchCount.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seBatchCount.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seBatchCount.Size = New System.Drawing.Size(163, 20)
            Me.seBatchCount.StyleController = Me.layoutControl1
            Me.seBatchCount.TabIndex = 5
            ' 
            ' seRowCount
            ' 
            Me.seRowCount.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seRowCount.Location = New System.Drawing.Point(74, 12)
            Me.seRowCount.Name = "seRowCount"
            Me.seRowCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seRowCount.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seRowCount.Properties.IsFloatValue = False
            Me.seRowCount.Properties.Mask.EditMask = "N00"
            Me.seRowCount.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seRowCount.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seRowCount.Size = New System.Drawing.Size(163, 20)
            Me.seRowCount.StyleController = Me.layoutControl1
            Me.seRowCount.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 613)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 84)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(229, 509)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.seRowCount
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.Text = "Row Count"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(59, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.seBatchCount
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.Text = "Batch Count"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(59, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sbRefresh
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(229, 10)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.DataSource = Me.virtualServerModeSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.bandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemTextEdit3, Me.repositoryItemTextEdit4, Me.repositoryItemTextEdit5, Me.repositoryItemHypertextLabel1})
            Me.gridControl1.Size = New System.Drawing.Size(794, 642)
            Me.gridControl1.TabIndex = 7
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView1})
            ' 
            ' virtualServerModeSource1
            ' 
            Me.virtualServerModeSource1.RowType = GetType(DevExpress.XtraGrid.Demos.VehiclesData.OrderItem)
            AddHandler Me.virtualServerModeSource1.ConfigurationChanged, New System.EventHandler(Of DevExpress.Data.VirtualServerModeRowsEventArgs)(AddressOf Me.virtualServerModeSource1_ConfigurationChanged)
            AddHandler Me.virtualServerModeSource1.MoreRows, New System.EventHandler(Of DevExpress.Data.VirtualServerModeRowsEventArgs)(AddressOf Me.virtualServerModeSource1_MoreRows)
            AddHandler Me.virtualServerModeSource1.GetUniqueValues, New System.EventHandler(Of DevExpress.Data.VirtualServerModeGetUniqueValuesEventArgs)(AddressOf Me.virtualServerModeSource1_GetUniqueValues)
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.gridBand1, Me.gridBand3, Me.gridBand4})
            Me.bandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bcTrademark, Me.bcName, Me.bcModification, Me.bcCategory, Me.bcPrice, Me.bcMPGCity, Me.bcMPGHighway, Me.bcDoors, Me.bcBodyStyle, Me.bcCylinders, Me.bcHorsepower, Me.bcTorque, Me.bcTransmissionSpeeds, Me.bcTransmissionType, Me.bcPhoto, Me.bcSalesDate, Me.bcSalesID, Me.bcDiscount, Me.colOrderID})
            gridFormatRule1.Column = Me.bcDiscount
            gridFormatRule1.Name = "Format0"
            formatConditionIconSet1.CategoryName = "Ratings"
            formatConditionIconSetIcon1.PredefinedName = "Rating4_1.png"
            formatConditionIconSetIcon1.Value = New Decimal(New Integer() {75, 0, 0, 0})
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon2.PredefinedName = "Rating4_2.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() {50, 0, 0, 0})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon3.PredefinedName = "Rating4_3.png"
            formatConditionIconSetIcon3.Value = New Decimal(New Integer() {25, 0, 0, 0})
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon4.PredefinedName = "Rating4_4.png"
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet1.Name = "Ratings4"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            gridFormatRule1.Rule = formatConditionRuleIconSet1
            gridFormatRule2.Column = Me.bcPrice
            gridFormatRule2.Name = "Format3"
            formatConditionRuleDataBar1.AutomaticType = DevExpress.XtraEditors.FormatConditionAutomaticType.ZeroBased
            formatConditionRuleDataBar1.PredefinedName = "Blue"
            gridFormatRule2.Rule = formatConditionRuleDataBar1
            Me.bandedGridView1.FormatRules.Add(gridFormatRule1)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule2)
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.bandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.bandedGridView1.OptionsCustomization.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl
            Me.bandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = False
            Me.bandedGridView1.OptionsDetail.EnableMasterViewMode = False
            Me.bandedGridView1.OptionsFind.AllowFindPanel = False
            Me.bandedGridView1.OptionsMenu.ShowAutoFilterRowItem = False
            Me.bandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.bandedGridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' bcPhoto
            ' 
            Me.bcPhoto.FieldName = "Photo"
            Me.bcPhoto.Name = "bcPhoto"
            Me.bcPhoto.OptionsFilter.AllowFilter = False
            Me.bcPhoto.Visible = True
            Me.bcPhoto.Width = 64
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.Caption = "<b>Row No</b>"
            Me.colOrderID.ColumnEdit = Me.repositoryItemTextEdit5
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            Me.colOrderID.Visible = True
            Me.colOrderID.Width = 53
            ' 
            ' repositoryItemTextEdit5
            ' 
            Me.repositoryItemTextEdit5.AutoHeight = False
            Me.repositoryItemTextEdit5.Mask.EditMask = "d7"
            Me.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5"
            ' 
            ' bcTrademark
            ' 
            Me.bcTrademark.FieldName = "Trademark"
            Me.bcTrademark.Name = "bcTrademark"
            Me.bcTrademark.Visible = True
            Me.bcTrademark.Width = 87
            ' 
            ' bcName
            ' 
            Me.bcName.FieldName = "Name"
            Me.bcName.Name = "bcName"
            Me.bcName.Visible = True
            Me.bcName.Width = 104
            ' 
            ' bcModification
            ' 
            Me.bcModification.FieldName = "Modification"
            Me.bcModification.Name = "bcModification"
            Me.bcModification.Visible = True
            Me.bcModification.Width = 147
            ' 
            ' bcSalesID
            ' 
            Me.bcSalesID.Caption = "<b>Sales ID</b>"
            Me.bcSalesID.ColumnEdit = Me.repositoryItemHypertextLabel1
            Me.bcSalesID.FieldName = "SalesID"
            Me.bcSalesID.ImageOptions.SvgImage = CType((resources.GetObject("bcSalesID.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bcSalesID.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.bcSalesID.Name = "bcSalesID"
            Me.bcSalesID.OptionsColumn.AllowEdit = False
            Me.bcSalesID.OptionsFilter.AllowFilter = False
            Me.bcSalesID.Visible = True
            Me.bcSalesID.Width = 93
            ' 
            ' repositoryItemHypertextLabel1
            ' 
            Me.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1"
            ' 
            ' bcSalesDate
            ' 
            Me.bcSalesDate.FieldName = "SalesDate"
            Me.bcSalesDate.Name = "bcSalesDate"
            Me.bcSalesDate.Visible = True
            Me.bcSalesDate.Width = 88
            ' 
            ' bcCylinders
            ' 
            Me.bcCylinders.FieldName = "Cylinders"
            Me.bcCylinders.Name = "bcCylinders"
            Me.bcCylinders.Visible = True
            Me.bcCylinders.Width = 60
            ' 
            ' bcTransmissionSpeeds
            ' 
            Me.bcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bcTransmissionSpeeds.Name = "bcTransmissionSpeeds"
            Me.bcTransmissionSpeeds.Visible = True
            ' 
            ' bcCategory
            ' 
            Me.bcCategory.FieldName = "Category"
            Me.bcCategory.Name = "bcCategory"
            Me.bcCategory.Visible = True
            Me.bcCategory.Width = 84
            ' 
            ' bcDoors
            ' 
            Me.bcDoors.FieldName = "Doors"
            Me.bcDoors.Name = "bcDoors"
            Me.bcDoors.Visible = True
            ' 
            ' bcBodyStyle
            ' 
            Me.bcBodyStyle.FieldName = "BodyStyle"
            Me.bcBodyStyle.Name = "bcBodyStyle"
            Me.bcBodyStyle.Visible = True
            Me.bcBodyStyle.Width = 92
            ' 
            ' bcHorsepower
            ' 
            Me.bcHorsepower.FieldName = "Horsepower"
            Me.bcHorsepower.Name = "bcHorsepower"
            Me.bcHorsepower.Visible = True
            Me.bcHorsepower.Width = 71
            ' 
            ' bcTorque
            ' 
            Me.bcTorque.FieldName = "Torque"
            Me.bcTorque.Name = "bcTorque"
            Me.bcTorque.Visible = True
            Me.bcTorque.Width = 83
            ' 
            ' bcTransmissionType
            ' 
            Me.bcTransmissionType.FieldName = "TransmissionType"
            Me.bcTransmissionType.Name = "bcTransmissionType"
            Me.bcTransmissionType.Visible = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' repositoryItemTextEdit3
            ' 
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Mask.EditMask = "n"
            Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Model"
            Me.gridBand2.Columns.Add(Me.colOrderID)
            Me.gridBand2.Columns.Add(Me.bcTrademark)
            Me.gridBand2.Columns.Add(Me.bcName)
            Me.gridBand2.Columns.Add(Me.bcModification)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 0
            Me.gridBand2.Width = 391
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Order Info"
            Me.gridBand1.Columns.Add(Me.bcSalesID)
            Me.gridBand1.Columns.Add(Me.bcPrice)
            Me.gridBand1.Columns.Add(Me.bcDiscount)
            Me.gridBand1.Columns.Add(Me.bcSalesDate)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 1
            Me.gridBand1.Width = 387
            ' 
            ' gridBand3
            ' 
            Me.gridBand3.Caption = "Performance"
            Me.gridBand3.Columns.Add(Me.bcMPGCity)
            Me.gridBand3.Columns.Add(Me.bcMPGHighway)
            Me.gridBand3.Columns.Add(Me.bcCylinders)
            Me.gridBand3.ImageOptions.Image = CType((resources.GetObject("gridBand3.ImageOptions.Image")), System.Drawing.Image)
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.Visible = False
            Me.gridBand3.VisibleIndex = -1
            Me.gridBand3.Width = 210
            ' 
            ' gridBand4
            ' 
            Me.gridBand4.Caption = "Others"
            Me.gridBand4.Columns.Add(Me.bcHorsepower)
            Me.gridBand4.Columns.Add(Me.bcTransmissionType)
            Me.gridBand4.Columns.Add(Me.bcTransmissionSpeeds)
            Me.gridBand4.Columns.Add(Me.bcTorque)
            Me.gridBand4.Columns.Add(Me.bcPhoto)
            Me.gridBand4.Columns.Add(Me.bcBodyStyle)
            Me.gridBand4.Columns.Add(Me.bcDoors)
            Me.gridBand4.Columns.Add(Me.bcCategory)
            Me.gridBand4.Name = "gridBand4"
            Me.gridBand4.Visible = False
            Me.gridBand4.VisibleIndex = -1
            Me.gridBand4.Width = 619
            ' 
            ' VirtualServerMode
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "VirtualServerMode"
            Me.Size = New System.Drawing.Size(1044, 642)
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.seBatchCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seRowCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.virtualServerModeSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemHypertextLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private bcSalesID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private bcPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private bcSalesDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTrademark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcModification As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcMPGCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcMPGHighway As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcCylinders As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTransmissionSpeeds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcDoors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcBodyStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcHorsepower As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTorque As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTransmissionType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private virtualServerModeSource1 As DevExpress.Data.VirtualServerModeSource

        Private seBatchCount As DevExpress.XtraEditors.SpinEdit

        Private seRowCount As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private sbRefresh As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private colOrderID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemHypertextLabel1 As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    End Class
End Namespace
