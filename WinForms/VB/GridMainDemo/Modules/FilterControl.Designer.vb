Namespace DevExpress.XtraGrid.Demos

    Partial Class FilterControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.FilterControl))
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Me.gridColumnSuspended = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.icbViewMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbDisplayStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceValue = New DevExpress.XtraEditors.ColorEdit()
            Me.ceOperator = New DevExpress.XtraEditors.ColorEdit()
            Me.ceToolTips = New DevExpress.XtraEditors.CheckEdit()
            Me.ceGroupOperator = New DevExpress.XtraEditors.ColorEdit()
            Me.ceFieldName = New DevExpress.XtraEditors.ColorEdit()
            Me.ceOperandTypeIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.ceEmptyValue = New DevExpress.XtraEditors.ColorEdit()
            Me.ceGroupCommandsIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.seSeparatorHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.seLevelIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lgColors = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbApply = New DevExpress.XtraEditors.SimpleButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridColumnUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gridColumnQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridColumnDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.filterControl1 = New DevExpress.DataAccess.UI.FilterEditorControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.tabPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbReset = New DevExpress.XtraEditors.SimpleButton()
            Me.sbApplyFilter2 = New DevExpress.XtraEditors.SimpleButton()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumnID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnImplemented = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.filterControl2 = New DevExpress.XtraEditors.FilterControl()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbViewMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbDisplayStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceOperator.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceToolTips.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceGroupOperator.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFieldName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceOperandTypeIcon.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceEmptyValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceGroupCommandsIcon.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seSeparatorHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seLevelIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lgColors), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage2.SuspendLayout()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridColumnSuspended
            ' 
            resources.ApplyResources(Me.gridColumnSuspended, "gridColumnSuspended")
            Me.gridColumnSuspended.FieldName = "Suspended"
            Me.gridColumnSuspended.Name = "gridColumnSuspended"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Discount", CType((resources.GetObject("svgImageCollection1.Discount")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Sales", CType((resources.GetObject("svgImageCollection1.Sales")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("UnitPrice", CType((resources.GetObject("svgImageCollection1.UnitPrice")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("next7days", "image://svgimages/scheduling/next7days.svg")
            Me.svgImageCollection1.Add("bo_price", "image://svgimages/business objects/bo_price.svg")
            Me.svgImageCollection1.Add("order_id", CType((resources.GetObject("svgImageCollection1.order_id")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product1", CType((resources.GetObject("svgImageCollection1.Product1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Quantity", CType((resources.GetObject("svgImageCollection1.Quantity")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("shortdate", "image://svgimages/spreadsheet/shortdate.svg")
            ' 
            ' icbViewMode
            ' 
            resources.ApplyResources(Me.icbViewMode, "icbViewMode")
            Me.icbViewMode.Name = "icbViewMode"
            Me.icbViewMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbViewMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbViewMode.StyleController = Me.layoutControl1
            AddHandler Me.icbViewMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbViewMode_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbDisplayStyle)
            Me.layoutControl1.Controls.Add(Me.ceValue)
            Me.layoutControl1.Controls.Add(Me.icbViewMode)
            Me.layoutControl1.Controls.Add(Me.ceOperator)
            Me.layoutControl1.Controls.Add(Me.ceToolTips)
            Me.layoutControl1.Controls.Add(Me.ceGroupOperator)
            Me.layoutControl1.Controls.Add(Me.ceFieldName)
            Me.layoutControl1.Controls.Add(Me.ceOperandTypeIcon)
            Me.layoutControl1.Controls.Add(Me.ceEmptyValue)
            Me.layoutControl1.Controls.Add(Me.ceGroupCommandsIcon)
            Me.layoutControl1.Controls.Add(Me.seSeparatorHeight)
            Me.layoutControl1.Controls.Add(Me.seLevelIndent)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(709, 293, 1017, 646)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' icbDisplayStyle
            ' 
            resources.ApplyResources(Me.icbDisplayStyle, "icbDisplayStyle")
            Me.icbDisplayStyle.Name = "icbDisplayStyle"
            Me.icbDisplayStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbDisplayStyle.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbDisplayStyle.StyleController = Me.layoutControl1
            AddHandler Me.icbDisplayStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbDisplayStyle_SelectedIndexChanged)
            ' 
            ' ceValue
            ' 
            resources.ApplyResources(Me.ceValue, "ceValue")
            Me.ceValue.Name = "ceValue"
            Me.ceValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ceValue.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ceValue.StyleController = Me.layoutControl1
            AddHandler Me.ceValue.EditValueChanged, New System.EventHandler(AddressOf Me.ceValue_EditValueChanged)
            ' 
            ' ceOperator
            ' 
            resources.ApplyResources(Me.ceOperator, "ceOperator")
            Me.ceOperator.Name = "ceOperator"
            Me.ceOperator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ceOperator.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ceOperator.StyleController = Me.layoutControl1
            AddHandler Me.ceOperator.EditValueChanged, New System.EventHandler(AddressOf Me.ceOperator_EditValueChanged)
            ' 
            ' ceToolTips
            ' 
            resources.ApplyResources(Me.ceToolTips, "ceToolTips")
            Me.ceToolTips.Name = "ceToolTips"
            Me.ceToolTips.Properties.Caption = resources.GetString("ceToolTips.Properties.Caption")
            Me.ceToolTips.StyleController = Me.layoutControl1
            AddHandler Me.ceToolTips.CheckedChanged, New System.EventHandler(AddressOf Me.ceToolTips_CheckedChanged)
            ' 
            ' ceGroupOperator
            ' 
            resources.ApplyResources(Me.ceGroupOperator, "ceGroupOperator")
            Me.ceGroupOperator.Name = "ceGroupOperator"
            Me.ceGroupOperator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceGroupOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ceGroupOperator.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ceGroupOperator.StyleController = Me.layoutControl1
            AddHandler Me.ceGroupOperator.EditValueChanged, New System.EventHandler(AddressOf Me.ceGroupOperator_EditValueChanged)
            ' 
            ' ceFieldName
            ' 
            resources.ApplyResources(Me.ceFieldName, "ceFieldName")
            Me.ceFieldName.Name = "ceFieldName"
            Me.ceFieldName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceFieldName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ceFieldName.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ceFieldName.StyleController = Me.layoutControl1
            AddHandler Me.ceFieldName.EditValueChanged, New System.EventHandler(AddressOf Me.ceFieldName_EditValueChanged)
            ' 
            ' ceOperandTypeIcon
            ' 
            resources.ApplyResources(Me.ceOperandTypeIcon, "ceOperandTypeIcon")
            Me.ceOperandTypeIcon.Name = "ceOperandTypeIcon"
            Me.ceOperandTypeIcon.Properties.Caption = resources.GetString("ceOperandTypeIcon.Properties.Caption")
            Me.ceOperandTypeIcon.StyleController = Me.layoutControl1
            AddHandler Me.ceOperandTypeIcon.CheckedChanged, New System.EventHandler(AddressOf Me.ceOperandTypeIcon_CheckedChanged)
            ' 
            ' ceEmptyValue
            ' 
            resources.ApplyResources(Me.ceEmptyValue, "ceEmptyValue")
            Me.ceEmptyValue.Name = "ceEmptyValue"
            Me.ceEmptyValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceEmptyValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("ceEmptyValue.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.ceEmptyValue.StyleController = Me.layoutControl1
            AddHandler Me.ceEmptyValue.EditValueChanged, New System.EventHandler(AddressOf Me.ceEmptyValue_EditValueChanged)
            ' 
            ' ceGroupCommandsIcon
            ' 
            resources.ApplyResources(Me.ceGroupCommandsIcon, "ceGroupCommandsIcon")
            Me.ceGroupCommandsIcon.Name = "ceGroupCommandsIcon"
            Me.ceGroupCommandsIcon.Properties.Caption = resources.GetString("ceGroupCommandsIcon.Properties.Caption")
            Me.ceGroupCommandsIcon.StyleController = Me.layoutControl1
            AddHandler Me.ceGroupCommandsIcon.CheckedChanged, New System.EventHandler(AddressOf Me.ceGroupCommandsIcon_CheckedChanged)
            ' 
            ' seSeparatorHeight
            ' 
            resources.ApplyResources(Me.seSeparatorHeight, "seSeparatorHeight")
            Me.seSeparatorHeight.Name = "seSeparatorHeight"
            Me.seSeparatorHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSeparatorHeight.Properties.IsFloatValue = False
            Me.seSeparatorHeight.Properties.Mask.EditMask = resources.GetString("seSeparatorHeight.Properties.Mask.EditMask")
            Me.seSeparatorHeight.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.seSeparatorHeight.StyleController = Me.layoutControl1
            AddHandler Me.seSeparatorHeight.EditValueChanged, New System.EventHandler(AddressOf Me.seSeparatorHeight_EditValueChanged)
            ' 
            ' seLevelIndent
            ' 
            resources.ApplyResources(Me.seLevelIndent, "seLevelIndent")
            Me.seLevelIndent.Name = "seLevelIndent"
            Me.seLevelIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLevelIndent.Properties.IsFloatValue = False
            Me.seLevelIndent.Properties.Mask.EditMask = resources.GetString("seLevelIndent.Properties.Mask.EditMask")
            Me.seLevelIndent.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seLevelIndent.Properties.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.seLevelIndent.StyleController = Me.layoutControl1
            AddHandler Me.seLevelIndent.EditValueChanged, New System.EventHandler(AddressOf Me.seLevelIndent_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup5, Me.lgColors, Me.emptySpaceItem1, Me.layoutControlItem12, Me.layoutControlItem11})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(255, 467)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(255, 162)
            Me.layoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup5, "layoutControlGroup5")
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seLevelIndent
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seSeparatorHeight
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceGroupCommandsIcon
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(235, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceOperandTypeIcon
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(235, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceToolTips
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(235, 24)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' lgColors
            ' 
            Me.lgColors.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lgColors.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem10})
            Me.lgColors.Location = New System.Drawing.Point(0, 230)
            Me.lgColors.Name = "lgColors"
            Me.lgColors.Size = New System.Drawing.Size(255, 162)
            Me.lgColors.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.lgColors, "lgColors")
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceEmptyValue
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem9, "layoutControlItem9")
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceFieldName
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceGroupOperator
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceOperator
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceValue
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(235, 24)
            resources.ApplyResources(Me.layoutControlItem10, "layoutControlItem10")
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 392)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(255, 75)
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.AllowHtmlStringInCaption = True
            Me.layoutControlItem12.Control = Me.icbViewMode
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(255, 34)
            Me.layoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5)
            resources.ApplyResources(Me.layoutControlItem12, "layoutControlItem12")
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.AllowHtmlStringInCaption = True
            Me.layoutControlItem11.Control = Me.icbDisplayStyle
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(255, 34)
            Me.layoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5)
            resources.ApplyResources(Me.layoutControlItem11, "layoutControlItem11")
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabPage1)
            Me.tabPane1.Controls.Add(Me.tabPage2)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabPage1, Me.tabPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(544, 500)
            Me.tabPane1.SelectedPage = Me.tabPage1
            AddHandler Me.tabPane1.SelectedPageChanged, New DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(AddressOf Me.tabPane1_SelectedPageChanged)
            ' 
            ' tabPage1
            ' 
            resources.ApplyResources(Me.tabPage1, "tabPage1")
            Me.tabPage1.Controls.Add(Me.layoutControl2)
            Me.tabPage1.Name = "tabPage1"
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.sbApply)
            Me.layoutControl2.Controls.Add(Me.gridControl1)
            Me.layoutControl2.Controls.Add(Me.filterControl1)
            resources.ApplyResources(Me.layoutControl2, "layoutControl2")
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(591, 235, 650, 400)
            Me.layoutControl2.Root = Me.Root
            ' 
            ' sbApply
            ' 
            Me.sbApply.AutoWidthInLayoutControl = True
            resources.ApplyResources(Me.sbApply, "sbApply")
            Me.sbApply.Name = "sbApply"
            Me.sbApply.StyleController = Me.layoutControl2
            AddHandler Me.sbApply.Click, New System.EventHandler(AddressOf Me.sbApply_Click)
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumnOrder, Me.gridColumnProduct, Me.gridColumnUnitPrice, Me.gridColumnQuantity, Me.gridColumnDiscount, Me.gridColumnOrderDate})
            Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(819, 303, 260, 252)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            ' 
            ' gridColumnOrder
            ' 
            resources.ApplyResources(Me.gridColumnOrder, "gridColumnOrder")
            Me.gridColumnOrder.FieldName = "OrderID"
            Me.gridColumnOrder.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnOrder.ImageOptions.ImageIndex"))))
            Me.gridColumnOrder.Name = "gridColumnOrder"
            ' 
            ' gridColumnProduct
            ' 
            resources.ApplyResources(Me.gridColumnProduct, "gridColumnProduct")
            Me.gridColumnProduct.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumnProduct.FieldName = "ProductID"
            Me.gridColumnProduct.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.gridColumnProduct.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnProduct.ImageOptions.ImageIndex"))))
            Me.gridColumnProduct.Name = "gridColumnProduct"
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
            ' gridColumnUnitPrice
            ' 
            resources.ApplyResources(Me.gridColumnUnitPrice, "gridColumnUnitPrice")
            Me.gridColumnUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumnUnitPrice.DisplayFormat.FormatString = "c"
            Me.gridColumnUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumnUnitPrice.FieldName = "UnitPrice"
            Me.gridColumnUnitPrice.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnUnitPrice.ImageOptions.ImageIndex"))))
            Me.gridColumnUnitPrice.Name = "gridColumnUnitPrice"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemCalcEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' gridColumnQuantity
            ' 
            resources.ApplyResources(Me.gridColumnQuantity, "gridColumnQuantity")
            Me.gridColumnQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumnQuantity.FieldName = "Quantity"
            Me.gridColumnQuantity.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnQuantity.ImageOptions.ImageIndex"))))
            Me.gridColumnQuantity.Name = "gridColumnQuantity"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' gridColumnDiscount
            ' 
            resources.ApplyResources(Me.gridColumnDiscount, "gridColumnDiscount")
            Me.gridColumnDiscount.DisplayFormat.FormatString = "p"
            Me.gridColumnDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumnDiscount.FieldName = "Discount"
            Me.gridColumnDiscount.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnDiscount.ImageOptions.ImageIndex"))))
            Me.gridColumnDiscount.Name = "gridColumnDiscount"
            ' 
            ' gridColumnOrderDate
            ' 
            resources.ApplyResources(Me.gridColumnOrderDate, "gridColumnOrderDate")
            Me.gridColumnOrderDate.FieldName = "OrderDate"
            Me.gridColumnOrderDate.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumnOrderDate.ImageOptions.ImageIndex"))))
            Me.gridColumnOrderDate.Name = "gridColumnOrderDate"
            ' 
            ' filterControl1
            ' 
            Me.filterControl1.AppearanceEmptyValueColor = System.Drawing.Color.Empty
            Me.filterControl1.AppearanceFieldNameColor = System.Drawing.Color.Empty
            Me.filterControl1.AppearanceGroupOperatorColor = System.Drawing.Color.Empty
            Me.filterControl1.AppearanceOperatorColor = System.Drawing.Color.Empty
            Me.filterControl1.AppearanceValueColor = System.Drawing.Color.Empty
            resources.ApplyResources(Me.filterControl1, "filterControl1")
            Me.filterControl1.Name = "filterControl1"
            Me.filterControl1.NodeSeparatorHeight = 2
            Me.filterControl1.SourceControl = Me.gridControl1
            Me.filterControl1.UseMenuForOperandsAndOperators = False
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem13, Me.layoutControlGroup2, Me.splitterItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(544, 467)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.gridControl1
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 215)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(524, 232)
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem14, Me.layoutControlGroup7})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(524, 205)
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.filterControl1
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(524, 177)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.GroupBordersVisible = False
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem3, Me.layoutControlItem15})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 177)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(524, 28)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(117, 0)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(407, 28)
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.sbApply
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(117, 28)
            Me.layoutControlItem15.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.Location = New System.Drawing.Point(0, 205)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(524, 10)
            ' 
            ' tabPage2
            ' 
            resources.ApplyResources(Me.tabPage2, "tabPage2")
            Me.tabPage2.Controls.Add(Me.layoutControl3)
            Me.tabPage2.Name = "tabPage2"
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AllowCustomization = False
            Me.layoutControl3.Controls.Add(Me.sbReset)
            Me.layoutControl3.Controls.Add(Me.sbApplyFilter2)
            Me.layoutControl3.Controls.Add(Me.gridControl2)
            Me.layoutControl3.Controls.Add(Me.filterControl2)
            resources.ApplyResources(Me.layoutControl3, "layoutControl3")
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(591, 235, 650, 400)
            Me.layoutControl3.Root = Me.layoutControlGroup3
            ' 
            ' sbReset
            ' 
            Me.sbReset.AutoWidthInLayoutControl = True
            resources.ApplyResources(Me.sbReset, "sbReset")
            Me.sbReset.Name = "sbReset"
            Me.sbReset.StyleController = Me.layoutControl3
            AddHandler Me.sbReset.Click, New System.EventHandler(AddressOf Me.sbReset_Click)
            ' 
            ' sbApplyFilter2
            ' 
            Me.sbApplyFilter2.AutoWidthInLayoutControl = True
            resources.ApplyResources(Me.sbApplyFilter2, "sbApplyFilter2")
            Me.sbApplyFilter2.Name = "sbApplyFilter2"
            Me.sbApplyFilter2.StyleController = Me.layoutControl3
            AddHandler Me.sbApplyFilter2.Click, New System.EventHandler(AddressOf Me.sbApplyFilter2_Click)
            ' 
            ' gridControl2
            ' 
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1})
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumnID, Me.gridColumnSubject, Me.gridColumnImplemented, Me.gridColumnSuspended})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.gridColumnSuspended
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Gray
            formatConditionRuleValue1.Appearance.Options.UseFont = True
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue1.Value1 = True
            gridFormatRule1.Rule = formatConditionRuleValue1
            Me.gridView2.FormatRules.Add(gridFormatRule1)
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowIndicator = False
            ' 
            ' gridColumnID
            ' 
            resources.ApplyResources(Me.gridColumnID, "gridColumnID")
            Me.gridColumnID.FieldName = "ID"
            Me.gridColumnID.Name = "gridColumnID"
            ' 
            ' gridColumnSubject
            ' 
            resources.ApplyResources(Me.gridColumnSubject, "gridColumnSubject")
            Me.gridColumnSubject.FieldName = "Subject"
            Me.gridColumnSubject.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.gridColumnSubject.Name = "gridColumnSubject"
            ' 
            ' gridColumnImplemented
            ' 
            resources.ApplyResources(Me.gridColumnImplemented, "gridColumnImplemented")
            Me.gridColumnImplemented.ColumnEdit = Me.repositoryItemProgressBar1
            Me.gridColumnImplemented.FieldName = "Implemented"
            Me.gridColumnImplemented.Name = "gridColumnImplemented"
            Me.gridColumnImplemented.OptionsColumn.AllowFocus = False
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' filterControl2
            ' 
            Me.filterControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.filterControl2.Cursor = System.Windows.Forms.Cursors.Arrow
            resources.ApplyResources(Me.filterControl2, "filterControl2")
            Me.filterControl2.Name = "filterControl2"
            Me.filterControl2.NodeSeparatorHeight = 2
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem16, Me.layoutControlGroup4, Me.splitterItem2})
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(544, 467)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.gridControl2
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 113)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(524, 334)
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem17, Me.layoutControlGroup6})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(524, 103)
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.filterControl2
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(524, 75)
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.GroupBordersVisible = False
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.layoutControlItem18, Me.layoutControlItem19})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 75)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(524, 28)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(241, 0)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(283, 28)
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.Control = Me.sbReset
            Me.layoutControlItem18.Location = New System.Drawing.Point(117, 0)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Size = New System.Drawing.Size(124, 28)
            Me.layoutControlItem18.Spacing = New DevExpress.XtraLayout.Utils.Padding(7, 0, 0, 0)
            Me.layoutControlItem18.TextVisible = False
            ' 
            ' layoutControlItem19
            ' 
            Me.layoutControlItem19.Control = Me.sbApplyFilter2
            Me.layoutControlItem19.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem19.Name = "layoutControlItem19"
            Me.layoutControlItem19.Size = New System.Drawing.Size(117, 28)
            Me.layoutControlItem19.TextVisible = False
            ' 
            ' splitterItem2
            ' 
            Me.splitterItem2.Location = New System.Drawing.Point(0, 103)
            Me.splitterItem2.Name = "splitterItem2"
            Me.splitterItem2.Size = New System.Drawing.Size(524, 10)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(255, 500)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "apply_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "cancel_16x16.png")
            ' 
            ' FilterControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "FilterControl"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FilterControl_Load)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbViewMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbDisplayStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceOperator.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceToolTips.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceGroupOperator.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFieldName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceOperandTypeIcon.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceEmptyValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceGroupCommandsIcon.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seSeparatorHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seLevelIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lgColors), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage2.ResumeLayout(False)
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private ceEmptyValue As DevExpress.XtraEditors.ColorEdit

        Private ceFieldName As DevExpress.XtraEditors.ColorEdit

        Private ceGroupOperator As DevExpress.XtraEditors.ColorEdit

        Private ceOperator As DevExpress.XtraEditors.ColorEdit

        Private ceValue As DevExpress.XtraEditors.ColorEdit

        Private seLevelIndent As DevExpress.XtraEditors.SpinEdit

        Private seSeparatorHeight As DevExpress.XtraEditors.SpinEdit

        Private ceGroupCommandsIcon As DevExpress.XtraEditors.CheckEdit

        Private ceOperandTypeIcon As DevExpress.XtraEditors.CheckEdit

        Private ceToolTips As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer

        Private icbViewMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private lgColors As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private icbDisplayStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumnOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumnProduct As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private gridColumnUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private gridColumnQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private gridColumnDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumnOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private filterControl1 As DevExpress.DataAccess.UI.FilterEditorControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumnID As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumnSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumnImplemented As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private gridColumnSuspended As DevExpress.XtraGrid.Columns.GridColumn

        Private filterControl2 As DevExpress.XtraEditors.FilterControl

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private splitterItem2 As DevExpress.XtraLayout.SplitterItem

        Private sbReset As DevExpress.XtraEditors.SimpleButton

        Private sbApplyFilter2 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem

        Private sbApply As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
