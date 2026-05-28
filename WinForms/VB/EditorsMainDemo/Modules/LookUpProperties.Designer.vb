Namespace DevExpress.XtraEditors.Demos

    Partial Class LookUpProperties

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
            Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
            Me.LookUpPropertieslayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.teNullText = New DevExpress.XtraEditors.TextEdit()
            Me.seItemHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowLines = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowHeader = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowFooter = New DevExpress.XtraEditors.CheckEdit()
            Me.ceHotTrack = New DevExpress.XtraEditors.CheckEdit()
            Me.icbSearchMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbHeaderClickMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seColumnIndex = New DevExpress.XtraEditors.SpinEdit()
            Me.ceCaseSensitiveSearch = New DevExpress.XtraEditors.CheckEdit()
            Me.lbValue = New DevExpress.XtraEditors.LabelControl()
            Me.lbDisplay = New DevExpress.XtraEditors.LabelControl()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupControl2item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.teNullTextitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.seItemHeightitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowLinesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowHeaderitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowFooteritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceHotTrackitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupControl1item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.icbSearchModeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.icbHeaderClickModeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.seColumnIndexitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceCaseSensitiveSearchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lbDisplayitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lblSelectitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.label1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lbValueitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.LookUpPropertieslayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LookUpPropertieslayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.teNullText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seItemHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowLines.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowFooter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceHotTrack.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSearchMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbHeaderClickMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seColumnIndex.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCaseSensitiveSearch.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl2item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teNullTextitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seItemHeightitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowLinesitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowHeaderitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowFooteritem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceHotTrackitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSearchModeitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbHeaderClickModeitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seColumnIndexitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCaseSensitiveSearchitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbDisplayitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lblSelectitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.label1item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbValueitem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lblSelect
            ' 
            Me.lblSelect.Location = New System.Drawing.Point(22, 12)
            Me.lblSelect.Name = "lblSelect"
            Me.lblSelect.Size = New System.Drawing.Size(79, 13)
            Me.lblSelect.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.lblSelect.TabIndex = 13
            Me.lblSelect.Text = "Display Member:"
            ' 
            ' LookUpPropertieslayoutControl1ConvertedLayout
            ' 
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.teNullText)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.seItemHeight)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceShowLines)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceShowHeader)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceShowFooter)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceHotTrack)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.icbSearchMode)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.icbHeaderClickMode)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.seColumnIndex)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceCaseSensitiveSearch)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.lbValue)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.lbDisplay)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.label1)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.lblSelect)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Name = "LookUpPropertieslayoutControl1ConvertedLayout"
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.LookUpPropertieslayoutControl1ConvertedLayout.Size = New System.Drawing.Size(311, 526)
            Me.LookUpPropertieslayoutControl1ConvertedLayout.TabIndex = 19
            ' 
            ' teNullText
            ' 
            Me.teNullText.EditValue = ""
            Me.teNullText.Location = New System.Drawing.Point(174, 312)
            Me.teNullText.Name = "teNullText"
            Me.teNullText.Size = New System.Drawing.Size(103, 20)
            Me.teNullText.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.teNullText.TabIndex = 20
            AddHandler Me.teNullText.EditValueChanged, New System.EventHandler(AddressOf Me.teNullText_EditValueChanged)
            ' 
            ' seItemHeight
            ' 
            Me.seItemHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seItemHeight.Location = New System.Drawing.Point(174, 282)
            Me.seItemHeight.Name = "seItemHeight"
            Me.seItemHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seItemHeight.Properties.IsFloatValue = False
            Me.seItemHeight.Properties.Mask.EditMask = "N00"
            Me.seItemHeight.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.seItemHeight.Size = New System.Drawing.Size(103, 20)
            Me.seItemHeight.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.seItemHeight.TabIndex = 18
            AddHandler Me.seItemHeight.EditValueChanged, New System.EventHandler(AddressOf Me.seItemHeight_EditValueChanged)
            ' 
            ' ceShowLines
            ' 
            Me.ceShowLines.Location = New System.Drawing.Point(34, 432)
            Me.ceShowLines.Name = "ceShowLines"
            Me.ceShowLines.Properties.Caption = "Show lines"
            Me.ceShowLines.Size = New System.Drawing.Size(243, 20)
            Me.ceShowLines.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.ceShowLines.TabIndex = 24
            AddHandler Me.ceShowLines.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowLines_CheckedChanged)
            ' 
            ' ceShowHeader
            ' 
            Me.ceShowHeader.Location = New System.Drawing.Point(34, 402)
            Me.ceShowHeader.Name = "ceShowHeader"
            Me.ceShowHeader.Properties.Caption = "Show header"
            Me.ceShowHeader.Size = New System.Drawing.Size(243, 20)
            Me.ceShowHeader.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.ceShowHeader.TabIndex = 23
            AddHandler Me.ceShowHeader.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowHeader_CheckedChanged)
            ' 
            ' ceShowFooter
            ' 
            Me.ceShowFooter.Location = New System.Drawing.Point(34, 372)
            Me.ceShowFooter.Name = "ceShowFooter"
            Me.ceShowFooter.Properties.Caption = "Show footer"
            Me.ceShowFooter.Size = New System.Drawing.Size(243, 20)
            Me.ceShowFooter.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.ceShowFooter.TabIndex = 22
            AddHandler Me.ceShowFooter.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowFooter_CheckedChanged)
            ' 
            ' ceHotTrack
            ' 
            Me.ceHotTrack.Location = New System.Drawing.Point(34, 342)
            Me.ceHotTrack.Name = "ceHotTrack"
            Me.ceHotTrack.Properties.Caption = "Hot-track items"
            Me.ceHotTrack.Size = New System.Drawing.Size(243, 20)
            Me.ceHotTrack.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.ceHotTrack.TabIndex = 21
            AddHandler Me.ceHotTrack.CheckedChanged, New System.EventHandler(AddressOf Me.ceHotTrack_CheckedChanged)
            ' 
            ' icbSearchMode
            ' 
            Me.icbSearchMode.EditValue = "imageComboBoxEdit2"
            Me.icbSearchMode.Location = New System.Drawing.Point(174, 163)
            Me.icbSearchMode.Name = "icbSearchMode"
            Me.icbSearchMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSearchMode.Size = New System.Drawing.Size(103, 20)
            Me.icbSearchMode.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.icbSearchMode.TabIndex = 19
            AddHandler Me.icbSearchMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbSearchMode_SelectedIndexChanged)
            ' 
            ' icbHeaderClickMode
            ' 
            Me.icbHeaderClickMode.EditValue = "imageComboBoxEdit1"
            Me.icbHeaderClickMode.Location = New System.Drawing.Point(174, 133)
            Me.icbHeaderClickMode.Name = "icbHeaderClickMode"
            Me.icbHeaderClickMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbHeaderClickMode.Size = New System.Drawing.Size(103, 20)
            Me.icbHeaderClickMode.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.icbHeaderClickMode.TabIndex = 18
            AddHandler Me.icbHeaderClickMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbHeaderClickMode_SelectedIndexChanged)
            ' 
            ' seColumnIndex
            ' 
            Me.seColumnIndex.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seColumnIndex.Location = New System.Drawing.Point(174, 103)
            Me.seColumnIndex.Name = "seColumnIndex"
            Me.seColumnIndex.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seColumnIndex.Properties.IsFloatValue = False
            Me.seColumnIndex.Properties.Mask.EditMask = "N00"
            Me.seColumnIndex.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
            Me.seColumnIndex.Size = New System.Drawing.Size(103, 20)
            Me.seColumnIndex.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.seColumnIndex.TabIndex = 17
            AddHandler Me.seColumnIndex.EditValueChanged, New System.EventHandler(AddressOf Me.seColumnIndex_EditValueChanged)
            ' 
            ' ceCaseSensitiveSearch
            ' 
            Me.ceCaseSensitiveSearch.Location = New System.Drawing.Point(34, 195)
            Me.ceCaseSensitiveSearch.Name = "ceCaseSensitiveSearch"
            Me.ceCaseSensitiveSearch.Properties.Caption = "Case sensitive search"
            Me.ceCaseSensitiveSearch.Size = New System.Drawing.Size(243, 20)
            Me.ceCaseSensitiveSearch.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.ceCaseSensitiveSearch.TabIndex = 20
            AddHandler Me.ceCaseSensitiveSearch.CheckedChanged, New System.EventHandler(AddressOf Me.ceCaseSensitiveSearch_CheckedChanged)
            ' 
            ' lbValue
            ' 
            Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbValue.Appearance.Options.UseFont = True
            Me.lbValue.Location = New System.Drawing.Point(115, 35)
            Me.lbValue.Name = "lbValue"
            Me.lbValue.Size = New System.Drawing.Size(47, 13)
            Me.lbValue.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.lbValue.TabIndex = 16
            Me.lbValue.Text = "Member"
            ' 
            ' lbDisplay
            ' 
            Me.lbDisplay.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbDisplay.Appearance.Options.UseFont = True
            Me.lbDisplay.Location = New System.Drawing.Point(115, 12)
            Me.lbDisplay.Name = "lbDisplay"
            Me.lbDisplay.Size = New System.Drawing.Size(47, 13)
            Me.lbDisplay.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.lbDisplay.TabIndex = 15
            Me.lbDisplay.Text = "Member"
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(22, 35)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(71, 13)
            Me.label1.StyleController = Me.LookUpPropertieslayoutControl1ConvertedLayout
            Me.label1.TabIndex = 14
            Me.label1.Text = "Value Member:"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupControl2item, Me.groupControl1item, Me.lbDisplayitem, Me.lblSelectitem, Me.emptySpaceItem1, Me.label1item, Me.lbValueitem})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 10, 20)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(311, 526)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupControl2item
            ' 
            Me.groupControl2item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.teNullTextitem, Me.seItemHeightitem, Me.ceShowLinesitem, Me.ceShowHeaderitem, Me.ceShowFooteritem, Me.ceHotTrackitem})
            Me.groupControl2item.Location = New System.Drawing.Point(0, 237)
            Me.groupControl2item.Name = "groupControl2item"
            Me.groupControl2item.Size = New System.Drawing.Size(271, 219)
            Me.groupControl2item.Text = "Appearance"
            ' 
            ' teNullTextitem
            ' 
            Me.teNullTextitem.Control = Me.teNullText
            Me.teNullTextitem.Location = New System.Drawing.Point(0, 27)
            Me.teNullTextitem.Name = "teNullTextitem"
            Me.teNullTextitem.Size = New System.Drawing.Size(247, 30)
            Me.teNullTextitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.teNullTextitem.Text = "Null Text:"
            Me.teNullTextitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.teNullTextitem.TextSize = New System.Drawing.Size(128, 13)
            ' 
            ' seItemHeightitem
            ' 
            Me.seItemHeightitem.Control = Me.seItemHeight
            Me.seItemHeightitem.Location = New System.Drawing.Point(0, 0)
            Me.seItemHeightitem.Name = "seItemHeightitem"
            Me.seItemHeightitem.Size = New System.Drawing.Size(247, 27)
            Me.seItemHeightitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 3)
            Me.seItemHeightitem.Text = "Dropdown item height:"
            Me.seItemHeightitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.seItemHeightitem.TextSize = New System.Drawing.Size(128, 13)
            ' 
            ' ceShowLinesitem
            ' 
            Me.ceShowLinesitem.Control = Me.ceShowLines
            Me.ceShowLinesitem.Location = New System.Drawing.Point(0, 147)
            Me.ceShowLinesitem.Name = "ceShowLinesitem"
            Me.ceShowLinesitem.Size = New System.Drawing.Size(247, 27)
            Me.ceShowLinesitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0)
            Me.ceShowLinesitem.TextVisible = False
            ' 
            ' ceShowHeaderitem
            ' 
            Me.ceShowHeaderitem.Control = Me.ceShowHeader
            Me.ceShowHeaderitem.Location = New System.Drawing.Point(0, 117)
            Me.ceShowHeaderitem.Name = "ceShowHeaderitem"
            Me.ceShowHeaderitem.Size = New System.Drawing.Size(247, 30)
            Me.ceShowHeaderitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.ceShowHeaderitem.TextVisible = False
            ' 
            ' ceShowFooteritem
            ' 
            Me.ceShowFooteritem.Control = Me.ceShowFooter
            Me.ceShowFooteritem.Location = New System.Drawing.Point(0, 87)
            Me.ceShowFooteritem.Name = "ceShowFooteritem"
            Me.ceShowFooteritem.Size = New System.Drawing.Size(247, 30)
            Me.ceShowFooteritem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.ceShowFooteritem.TextVisible = False
            ' 
            ' ceHotTrackitem
            ' 
            Me.ceHotTrackitem.Control = Me.ceHotTrack
            Me.ceHotTrackitem.Location = New System.Drawing.Point(0, 57)
            Me.ceHotTrackitem.Name = "ceHotTrackitem"
            Me.ceHotTrackitem.Size = New System.Drawing.Size(247, 30)
            Me.ceHotTrackitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.ceHotTrackitem.TextVisible = False
            ' 
            ' groupControl1item
            ' 
            Me.groupControl1item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.icbSearchModeitem, Me.icbHeaderClickModeitem, Me.seColumnIndexitem, Me.ceCaseSensitiveSearchitem})
            Me.groupControl1item.Location = New System.Drawing.Point(0, 40)
            Me.groupControl1item.Name = "groupControl1item"
            Me.groupControl1item.Size = New System.Drawing.Size(271, 197)
            Me.groupControl1item.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 20, 20)
            Me.groupControl1item.Text = "Search"
            ' 
            ' icbSearchModeitem
            ' 
            Me.icbSearchModeitem.Control = Me.icbSearchMode
            Me.icbSearchModeitem.Location = New System.Drawing.Point(0, 57)
            Me.icbSearchModeitem.Name = "icbSearchModeitem"
            Me.icbSearchModeitem.Size = New System.Drawing.Size(247, 30)
            Me.icbSearchModeitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.icbSearchModeitem.Text = "Search mode:"
            Me.icbSearchModeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.icbSearchModeitem.TextSize = New System.Drawing.Size(128, 13)
            ' 
            ' icbHeaderClickModeitem
            ' 
            Me.icbHeaderClickModeitem.Control = Me.icbHeaderClickMode
            Me.icbHeaderClickModeitem.Location = New System.Drawing.Point(0, 27)
            Me.icbHeaderClickModeitem.Name = "icbHeaderClickModeitem"
            Me.icbHeaderClickModeitem.Size = New System.Drawing.Size(247, 30)
            Me.icbHeaderClickModeitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 3)
            Me.icbHeaderClickModeitem.Text = "Header click mode:"
            Me.icbHeaderClickModeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.icbHeaderClickModeitem.TextSize = New System.Drawing.Size(128, 13)
            ' 
            ' seColumnIndexitem
            ' 
            Me.seColumnIndexitem.Control = Me.seColumnIndex
            Me.seColumnIndexitem.Location = New System.Drawing.Point(0, 0)
            Me.seColumnIndexitem.Name = "seColumnIndexitem"
            Me.seColumnIndexitem.Size = New System.Drawing.Size(247, 27)
            Me.seColumnIndexitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 3)
            Me.seColumnIndexitem.Text = "Auto-search column index:"
            Me.seColumnIndexitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.seColumnIndexitem.TextSize = New System.Drawing.Size(128, 13)
            ' 
            ' ceCaseSensitiveSearchitem
            ' 
            Me.ceCaseSensitiveSearchitem.Control = Me.ceCaseSensitiveSearch
            Me.ceCaseSensitiveSearchitem.Location = New System.Drawing.Point(0, 87)
            Me.ceCaseSensitiveSearchitem.Name = "ceCaseSensitiveSearchitem"
            Me.ceCaseSensitiveSearchitem.Size = New System.Drawing.Size(247, 29)
            Me.ceCaseSensitiveSearchitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0)
            Me.ceCaseSensitiveSearchitem.TextVisible = False
            ' 
            ' lbDisplayitem
            ' 
            Me.lbDisplayitem.Control = Me.lbDisplay
            Me.lbDisplayitem.Location = New System.Drawing.Point(93, 0)
            Me.lbDisplayitem.Name = "lbDisplayitem"
            Me.lbDisplayitem.Size = New System.Drawing.Size(178, 23)
            Me.lbDisplayitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.lbDisplayitem.TextVisible = False
            ' 
            ' lblSelectitem
            ' 
            Me.lblSelectitem.Control = Me.lblSelect
            Me.lblSelectitem.Location = New System.Drawing.Point(0, 0)
            Me.lblSelectitem.Name = "lblSelectitem"
            Me.lblSelectitem.Size = New System.Drawing.Size(93, 23)
            Me.lblSelectitem.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 3)
            Me.lblSelectitem.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 456)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(271, 40)
            ' 
            ' label1item
            ' 
            Me.label1item.Control = Me.label1
            Me.label1item.Location = New System.Drawing.Point(0, 23)
            Me.label1item.Name = "label1item"
            Me.label1item.Size = New System.Drawing.Size(93, 17)
            Me.label1item.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 7, 0, 0)
            Me.label1item.TextVisible = False
            ' 
            ' lbValueitem
            ' 
            Me.lbValueitem.Control = Me.lbValue
            Me.lbValueitem.Location = New System.Drawing.Point(93, 23)
            Me.lbValueitem.Name = "lbValueitem"
            Me.lbValueitem.Size = New System.Drawing.Size(178, 17)
            Me.lbValueitem.TextVisible = False
            ' 
            ' LookUpProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LookUpPropertieslayoutControl1ConvertedLayout)
            Me.Name = "LookUpProperties"
            Me.Size = New System.Drawing.Size(311, 526)
            CType((Me.LookUpPropertieslayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.LookUpPropertieslayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.teNullText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seItemHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowLines.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowFooter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceHotTrack.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSearchMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbHeaderClickMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seColumnIndex.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCaseSensitiveSearch.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl2item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teNullTextitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seItemHeightitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowLinesitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowHeaderitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowFooteritem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceHotTrackitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSearchModeitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbHeaderClickModeitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seColumnIndexitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCaseSensitiveSearchitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbDisplayitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lblSelectitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.label1item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbValueitem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private lblSelect As DevExpress.XtraEditors.LabelControl

        Private label1 As DevExpress.XtraEditors.LabelControl

        Private lbDisplay As DevExpress.XtraEditors.LabelControl

        Private lbValue As DevExpress.XtraEditors.LabelControl

        Private seColumnIndex As DevExpress.XtraEditors.SpinEdit

        Private icbHeaderClickMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbSearchMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceCaseSensitiveSearch As DevExpress.XtraEditors.CheckEdit

        Private seItemHeight As DevExpress.XtraEditors.SpinEdit

        Private teNullText As DevExpress.XtraEditors.TextEdit

        Private ceHotTrack As DevExpress.XtraEditors.CheckEdit

        Private ceShowFooter As DevExpress.XtraEditors.CheckEdit

        Private ceShowHeader As DevExpress.XtraEditors.CheckEdit

        Private ceShowLines As DevExpress.XtraEditors.CheckEdit

        Private LookUpPropertieslayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private groupControl2item As DevExpress.XtraLayout.LayoutControlGroup

        Private teNullTextitem As DevExpress.XtraLayout.LayoutControlItem

        Private seItemHeightitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowLinesitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowHeaderitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowFooteritem As DevExpress.XtraLayout.LayoutControlItem

        Private ceHotTrackitem As DevExpress.XtraLayout.LayoutControlItem

        Private groupControl1item As DevExpress.XtraLayout.LayoutControlGroup

        Private icbSearchModeitem As DevExpress.XtraLayout.LayoutControlItem

        Private icbHeaderClickModeitem As DevExpress.XtraLayout.LayoutControlItem

        Private seColumnIndexitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceCaseSensitiveSearchitem As DevExpress.XtraLayout.LayoutControlItem

        Private lbValueitem As DevExpress.XtraLayout.LayoutControlItem

        Private lbDisplayitem As DevExpress.XtraLayout.LayoutControlItem

        Private label1item As DevExpress.XtraLayout.LayoutControlItem

        Private lblSelectitem As DevExpress.XtraLayout.LayoutControlItem

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private components As System.ComponentModel.IContainer

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
