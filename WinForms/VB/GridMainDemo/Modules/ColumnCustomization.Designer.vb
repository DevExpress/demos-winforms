Namespace DevExpress.XtraGrid.Demos

    Partial Class ColumnCustomization

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ColumnCustomization))
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon6 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Me.bgcInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.ccbSnapMode = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gbMain = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcLogo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.gbPerfomance = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbImage = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbInfo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.pgcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.checkEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.checkEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ccbSnapMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' bgcInStock
            ' 
            Me.bgcInStock.FieldName = "InStock"
            Me.bgcInStock.Name = "bgcInStock"
            ' 
            ' bgcMPGCity
            ' 
            resources.ApplyResources(Me.bgcMPGCity, "bgcMPGCity")
            Me.bgcMPGCity.FieldName = "MPGCity"
            Me.bgcMPGCity.Name = "bgcMPGCity"
            Me.bgcMPGCity.RowIndex = 1
            ' 
            ' bgcMPGHighway
            ' 
            resources.ApplyResources(Me.bgcMPGHighway, "bgcMPGHighway")
            Me.bgcMPGHighway.FieldName = "MPGHighway"
            Me.bgcMPGHighway.Name = "bgcMPGHighway"
            Me.bgcMPGHighway.RowIndex = 1
            ' 
            ' checkEdit3
            ' 
            resources.ApplyResources(Me.checkEdit3, "checkEdit3")
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = resources.GetString("checkEdit3.Properties.Caption")
            Me.checkEdit3.StyleController = Me.layoutControl1
            AddHandler Me.checkEdit3.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit3_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.checkEdit4)
            Me.layoutControl1.Controls.Add(Me.checkEdit3)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.Controls.Add(Me.ccbSnapMode)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 695, 586)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' checkEdit4
            ' 
            resources.ApplyResources(Me.checkEdit4, "checkEdit4")
            Me.checkEdit4.Name = "checkEdit4"
            Me.checkEdit4.Properties.Caption = resources.GetString("checkEdit4.Properties.Caption")
            Me.checkEdit4.StyleController = Me.layoutControl1
            AddHandler Me.checkEdit4.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit4_CheckedChanged)
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' checkEdit1
            ' 
            resources.ApplyResources(Me.checkEdit1, "checkEdit1")
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption")
            Me.checkEdit1.StyleController = Me.layoutControl1
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' checkEdit2
            ' 
            resources.ApplyResources(Me.checkEdit2, "checkEdit2")
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = resources.GetString("checkEdit2.Properties.Caption")
            Me.checkEdit2.StyleController = Me.layoutControl1
            AddHandler Me.checkEdit2.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit2_CheckedChanged)
            ' 
            ' ccbSnapMode
            ' 
            resources.ApplyResources(Me.ccbSnapMode, "ccbSnapMode")
            Me.ccbSnapMode.Name = "ccbSnapMode"
            Me.ccbSnapMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ccbSnapMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ccbSnapMode.StyleController = Me.layoutControl1
            AddHandler Me.ccbSnapMode.EditValueChanged, New System.EventHandler(AddressOf Me.ccbSnapMode_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem4, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 532)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEdit2
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEdit3
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(229, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 180)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(229, 332)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkEdit4
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 106)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ccbSnapMode
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 140)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(154, 13)
            AddHandler Me.layoutControlItem6.CustomDraw, New System.EventHandler(Of DevExpress.XtraLayout.ItemCustomDrawEventArgs)(AddressOf Me.layoutControlItem6_CustomDraw)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 130)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(229, 10)
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbMain, Me.gbPerfomance, Me.gbImage, Me.gbInfo})
            Me.advBandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bgcID, Me.bgcTrademark, Me.bgcName, Me.bgcModification, Me.pgcCategory, Me.bgcPrice, Me.bgcMPGCity, Me.bgcMPGHighway, Me.bgcDoors, Me.bgcBodyStyle, Me.bgcCylinders, Me.bgcHorsepower, Me.bgcTorque, Me.bgcDescription, Me.bgcPhoto, Me.bgcTransmissionSpeeds, Me.bgcTransmissionType, Me.bgcDeliveryDate, Me.bgcInStock, Me.bgcLogo})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.bgcInStock
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DarkGray
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue1.PredefinedName = "Strikeout Text"
            formatConditionRuleValue1.Value1 = True
            gridFormatRule1.Rule = formatConditionRuleValue1
            gridFormatRule2.Column = Me.bgcMPGCity
            gridFormatRule2.Name = "Format1"
            formatConditionIconSet1.CategoryName = "Directional"
            formatConditionIconSetIcon1.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon1.Value = New Decimal(New Integer() {67, 0, 0, 0})
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon2.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon3.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet1.Name = "Arrows3Colored"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            gridFormatRule2.Rule = formatConditionRuleIconSet1
            gridFormatRule3.Column = Me.bgcMPGHighway
            gridFormatRule3.Name = "Format2"
            formatConditionIconSet2.CategoryName = "Directional"
            formatConditionIconSetIcon4.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon4.Value = New Decimal(New Integer() {67, 0, 0, 0})
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon5.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon5.Value = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon6.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6)
            formatConditionIconSet2.Name = "Arrows3Colored"
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2
            gridFormatRule3.Rule = formatConditionRuleIconSet2
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule1)
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule2)
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule3)
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.GroupCount = 1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.advBandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.advBandedGridView1.OptionsCustomization.UseAdvancedCustomizationForm = DevExpress.Utils.DefaultBoolean.[True]
            Me.advBandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.bgcBodyStyle, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.advBandedGridView1.ShowCustomizationForm, New System.EventHandler(AddressOf Me.advBandedGridView1_ShowCustomizationForm)
            AddHandler Me.advBandedGridView1.HideCustomizationForm, New System.EventHandler(AddressOf Me.advBandedGridView1_HideCustomizationForm)
            ' 
            ' gbMain
            ' 
            resources.ApplyResources(Me.gbMain, "gbMain")
            Me.gbMain.Columns.Add(Me.bgcID)
            Me.gbMain.Columns.Add(Me.bgcTrademark)
            Me.gbMain.Columns.Add(Me.bgcName)
            Me.gbMain.Columns.Add(Me.bgcModification)
            Me.gbMain.Columns.Add(Me.bgcLogo)
            Me.gbMain.Columns.Add(Me.bgcDescription)
            Me.gbMain.VisibleIndex = 0
            ' 
            ' bgcID
            ' 
            Me.bgcID.FieldName = "ID"
            Me.bgcID.Name = "bgcID"
            ' 
            ' bgcTrademark
            ' 
            resources.ApplyResources(Me.bgcTrademark, "bgcTrademark")
            Me.bgcTrademark.FieldName = "Trademark"
            Me.bgcTrademark.MinWidth = 80
            Me.bgcTrademark.Name = "bgcTrademark"
            ' 
            ' bgcName
            ' 
            Me.bgcName.FieldName = "Name"
            Me.bgcName.Name = "bgcName"
            resources.ApplyResources(Me.bgcName, "bgcName")
            ' 
            ' bgcModification
            ' 
            Me.bgcModification.FieldName = "Modification"
            Me.bgcModification.Name = "bgcModification"
            resources.ApplyResources(Me.bgcModification, "bgcModification")
            ' 
            ' bgcLogo
            ' 
            Me.bgcLogo.FieldName = "TrademarkImage"
            Me.bgcLogo.Name = "bgcLogo"
            Me.bgcLogo.RowCount = 2
            Me.bgcLogo.RowIndex = 1
            resources.ApplyResources(Me.bgcLogo, "bgcLogo")
            ' 
            ' bgcDescription
            ' 
            Me.bgcDescription.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.bgcDescription.FieldName = "Description"
            Me.bgcDescription.Name = "bgcDescription"
            Me.bgcDescription.OptionsFilter.AllowFilter = False
            Me.bgcDescription.RowCount = 3
            Me.bgcDescription.RowIndex = 1
            resources.ApplyResources(Me.bgcDescription, "bgcDescription")
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' gbPerfomance
            ' 
            resources.ApplyResources(Me.gbPerfomance, "gbPerfomance")
            Me.gbPerfomance.Columns.Add(Me.bgcHorsepower)
            Me.gbPerfomance.Columns.Add(Me.bgcTorque)
            Me.gbPerfomance.Columns.Add(Me.bgcMPGCity)
            Me.gbPerfomance.Columns.Add(Me.bgcMPGHighway)
            Me.gbPerfomance.Columns.Add(Me.bgcDoors)
            Me.gbPerfomance.Columns.Add(Me.bgcCylinders)
            Me.gbPerfomance.Columns.Add(Me.bgcTransmissionType)
            Me.gbPerfomance.Columns.Add(Me.bgcTransmissionSpeeds)
            Me.gbPerfomance.VisibleIndex = 1
            ' 
            ' bgcHorsepower
            ' 
            Me.bgcHorsepower.FieldName = "Horsepower"
            Me.bgcHorsepower.Name = "bgcHorsepower"
            resources.ApplyResources(Me.bgcHorsepower, "bgcHorsepower")
            ' 
            ' bgcTorque
            ' 
            Me.bgcTorque.FieldName = "Torque"
            Me.bgcTorque.Name = "bgcTorque"
            resources.ApplyResources(Me.bgcTorque, "bgcTorque")
            ' 
            ' bgcDoors
            ' 
            Me.bgcDoors.FieldName = "Doors"
            Me.bgcDoors.Name = "bgcDoors"
            Me.bgcDoors.RowIndex = 2
            resources.ApplyResources(Me.bgcDoors, "bgcDoors")
            ' 
            ' bgcCylinders
            ' 
            Me.bgcCylinders.FieldName = "Cylinders"
            Me.bgcCylinders.Name = "bgcCylinders"
            Me.bgcCylinders.RowIndex = 2
            resources.ApplyResources(Me.bgcCylinders, "bgcCylinders")
            ' 
            ' bgcTransmissionType
            ' 
            Me.bgcTransmissionType.FieldName = "TransmissionType"
            Me.bgcTransmissionType.Name = "bgcTransmissionType"
            Me.bgcTransmissionType.OptionsColumn.ShowInCustomizationForm = False
            Me.bgcTransmissionType.RowIndex = 3
            resources.ApplyResources(Me.bgcTransmissionType, "bgcTransmissionType")
            ' 
            ' bgcTransmissionSpeeds
            ' 
            Me.bgcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bgcTransmissionSpeeds.Name = "bgcTransmissionSpeeds"
            Me.bgcTransmissionSpeeds.OptionsColumn.ShowInCustomizationForm = False
            Me.bgcTransmissionSpeeds.RowIndex = 3
            resources.ApplyResources(Me.bgcTransmissionSpeeds, "bgcTransmissionSpeeds")
            ' 
            ' gbImage
            ' 
            resources.ApplyResources(Me.gbImage, "gbImage")
            Me.gbImage.Columns.Add(Me.bgcPhoto)
            Me.gbImage.VisibleIndex = 2
            ' 
            ' bgcPhoto
            ' 
            Me.bgcPhoto.FieldName = "Photo"
            Me.bgcPhoto.Name = "bgcPhoto"
            Me.bgcPhoto.RowCount = 4
            resources.ApplyResources(Me.bgcPhoto, "bgcPhoto")
            ' 
            ' gbInfo
            ' 
            resources.ApplyResources(Me.gbInfo, "gbInfo")
            Me.gbInfo.Columns.Add(Me.pgcCategory)
            Me.gbInfo.Columns.Add(Me.bgcBodyStyle)
            Me.gbInfo.Columns.Add(Me.bgcPrice)
            ' 
            ' pgcCategory
            ' 
            resources.ApplyResources(Me.pgcCategory, "pgcCategory")
            Me.pgcCategory.FieldName = "Category"
            Me.pgcCategory.Name = "pgcCategory"
            ' 
            ' bgcBodyStyle
            ' 
            resources.ApplyResources(Me.bgcBodyStyle, "bgcBodyStyle")
            Me.bgcBodyStyle.FieldName = "BodyStyle"
            Me.bgcBodyStyle.Name = "bgcBodyStyle"
            ' 
            ' bgcPrice
            ' 
            Me.bgcPrice.FieldName = "Price"
            Me.bgcPrice.Name = "bgcPrice"
            resources.ApplyResources(Me.bgcPrice, "bgcPrice")
            ' 
            ' bgcDeliveryDate
            ' 
            Me.bgcDeliveryDate.FieldName = "DeliveryDate"
            Me.bgcDeliveryDate.Name = "bgcDeliveryDate"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemSpinEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat"))))
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit2, "repositoryItemTextEdit2")
            Me.repositoryItemTextEdit2.Mask.EditMask = resources.GetString("repositoryItemTextEdit2.Mask.EditMask")
            Me.repositoryItemTextEdit2.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit2.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat"))))
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 565)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' ColumnCustomization
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ColumnCustomization"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ColumnCustomization_Load)
            CType((Me.checkEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.checkEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ccbSnapMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit3 As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private checkEdit4 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panel1 As System.Windows.Forms.Panel

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private ccbSnapMode As DevExpress.XtraEditors.CheckedComboBoxEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private gbMain As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private bgcID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcTrademark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcModification As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcLogo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gbPerfomance As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private bgcHorsepower As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcTorque As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcMPGCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcMPGHighway As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcDoors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcCylinders As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcTransmissionType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcTransmissionSpeeds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gbImage As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private bgcPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gbInfo As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private pgcCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcBodyStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcDeliveryDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bgcInStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    End Class
End Namespace
