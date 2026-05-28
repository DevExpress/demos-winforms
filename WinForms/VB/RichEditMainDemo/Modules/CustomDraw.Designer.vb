Namespace DevExpress.XtraRichEdit.Demos

    Partial Class CustomDrawModule

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
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.displayForReviewModeComboBox1 = New DevExpress.XtraRichEdit.UI.DisplayForReviewModeComboBox()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.hitTestPanelControl = New DevExpress.XtraEditors.PanelControl()
            Me.hitTestPanelLayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.searchText = New DevExpress.XtraEditors.LabelControl()
            Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
            Me.findWholeWordsOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.matchCase = New DevExpress.XtraEditors.CheckEdit()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.searchPanelLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.searchOptionsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.matchCaseControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.searchTextBox = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.searchResultAndButtonsGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationButtonsEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.displayForReviewModeComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemBorderLineStyle1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemBorderLineWeight1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFloatingObjectOutlineWeight1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hitTestPanelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hitTestPanelControl.SuspendLayout()
            CType((Me.hitTestPanelLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hitTestPanelLayoutControl.SuspendLayout()
            CType((Me.buttonEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.findWholeWordsOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.matchCase.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchPanelLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchOptionsLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.matchCaseControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchTextBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchResultAndButtonsGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationButtonsEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.Margin = New System.Windows.Forms.Padding(0)
            Me.richEditControl.MenuManager = Me.ribbonControl1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(1013, 608)
            Me.richEditControl.TabIndex = 13
            AddHandler Me.richEditControl.ContentChanged, New System.EventHandler(AddressOf Me.richEditControl_ContentChanged)
            AddHandler Me.richEditControl.BeforePagePaint, New DevExpress.XtraRichEdit.BeforePagePaintEventHandler(AddressOf Me.richEditControl_BeforePagePaint)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 270
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.displayForReviewModeComboBox1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1296, 50)
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' displayForReviewModeComboBox1
            ' 
            Me.displayForReviewModeComboBox1.AutoHeight = False
            Me.displayForReviewModeComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.displayForReviewModeComboBox1.Name = "displayForReviewModeComboBox1"
            Me.displayForReviewModeComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            Me.repositoryItemBorderLineWeight1.AutoHeight = False
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineWeight1.Control = Me.richEditControl
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            Me.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.richEditControl
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' hitTestPanelControl
            ' 
            Me.hitTestPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hitTestPanelControl.Controls.Add(Me.hitTestPanelLayoutControl)
            Me.hitTestPanelControl.Dock = System.Windows.Forms.DockStyle.Right
            Me.hitTestPanelControl.Location = New System.Drawing.Point(1016, 50)
            Me.hitTestPanelControl.Name = "hitTestPanelControl"
            Me.hitTestPanelControl.Size = New System.Drawing.Size(280, 558)
            Me.hitTestPanelControl.TabIndex = 44
            ' 
            ' hitTestPanelLayoutControl
            ' 
            Me.hitTestPanelLayoutControl.Controls.Add(Me.searchText)
            Me.hitTestPanelLayoutControl.Controls.Add(Me.buttonEdit1)
            Me.hitTestPanelLayoutControl.Controls.Add(Me.findWholeWordsOnly)
            Me.hitTestPanelLayoutControl.Controls.Add(Me.matchCase)
            Me.hitTestPanelLayoutControl.Controls.Add(Me.searchControl)
            Me.hitTestPanelLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hitTestPanelLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.hitTestPanelLayoutControl.Name = "hitTestPanelLayoutControl"
            Me.hitTestPanelLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(260, 196, 650, 400)
            Me.hitTestPanelLayoutControl.Root = Me.Root
            Me.hitTestPanelLayoutControl.Size = New System.Drawing.Size(280, 558)
            Me.hitTestPanelLayoutControl.TabIndex = 0
            Me.hitTestPanelLayoutControl.Text = "layoutControl1"
            ' 
            ' searchText
            ' 
            Me.searchText.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.searchText.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
            Me.searchText.Location = New System.Drawing.Point(9, 53)
            Me.searchText.Name = "searchText"
            Me.searchText.Size = New System.Drawing.Size(114, 13)
            Me.searchText.StyleController = Me.hitTestPanelLayoutControl
            Me.searchText.TabIndex = 36
            ' 
            ' buttonEdit1
            ' 
            Me.buttonEdit1.Location = New System.Drawing.Point(127, 51)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.Properties.AllowFocused = False
            Me.buttonEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.buttonEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.buttonEdit1.Properties.AppearanceFocused.Options.UseTextOptions = True
            Me.buttonEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
            Me.buttonEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.None
            Me.buttonEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            Me.buttonEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
            Me.buttonEdit1.Properties.[ReadOnly] = True
            Me.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            AddHandler Me.buttonEdit1.Properties.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.navigationButtonEdit_Properties_ButtonClick)
            Me.buttonEdit1.Size = New System.Drawing.Size(145, 18)
            Me.buttonEdit1.StyleController = Me.hitTestPanelLayoutControl
            Me.buttonEdit1.TabIndex = 35
            Me.buttonEdit1.TabStop = False
            ' 
            ' findWholeWordsOnly
            ' 
            Me.findWholeWordsOnly.Location = New System.Drawing.Point(15, 122)
            Me.findWholeWordsOnly.Name = "findWholeWordsOnly"
            Me.findWholeWordsOnly.Properties.Caption = "Find Whole Words Only"
            Me.findWholeWordsOnly.Size = New System.Drawing.Size(251, 20)
            Me.findWholeWordsOnly.StyleController = Me.hitTestPanelLayoutControl
            Me.findWholeWordsOnly.TabIndex = 28
            AddHandler Me.findWholeWordsOnly.CheckedChanged, New System.EventHandler(AddressOf Me.OnSearchOptionsChanged)
            ' 
            ' matchCase
            ' 
            Me.matchCase.Location = New System.Drawing.Point(15, 98)
            Me.matchCase.Name = "matchCase"
            Me.matchCase.Properties.Caption = "Match Case"
            Me.matchCase.Size = New System.Drawing.Size(251, 20)
            Me.matchCase.StyleController = Me.hitTestPanelLayoutControl
            Me.matchCase.TabIndex = 27
            AddHandler Me.matchCase.CheckedChanged, New System.EventHandler(AddressOf Me.OnSearchOptionsChanged)
            ' 
            ' searchControl
            ' 
            Me.searchControl.EditValue = "g"
            Me.searchControl.Location = New System.Drawing.Point(9, 27)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton()})
            Me.searchControl.Properties.NullValuePrompt = " "
            Me.searchControl.Properties.ShowSearchButton = False
            AddHandler Me.searchControl.Properties.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.searchTextBox_Properties_ButtonClick)
            Me.searchControl.Size = New System.Drawing.Size(263, 20)
            Me.searchControl.StyleController = Me.hitTestPanelLayoutControl
            Me.searchControl.TabIndex = 25
            AddHandler Me.searchControl.EditValueChanged, New System.EventHandler(AddressOf Me.searchTextBox_EditValueChanged)
            AddHandler Me.searchControl.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.searchTextBox_KeyDown)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.searchPanelLayoutControlGroup, Me.simpleSeparator1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(280, 558)
            Me.Root.TextVisible = False
            ' 
            ' searchPanelLayoutControlGroup
            ' 
            Me.searchPanelLayoutControlGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
            Me.searchPanelLayoutControlGroup.CustomizationFormText = "Search Panel"
            Me.searchPanelLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.searchPanelLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.searchOptionsLayoutControlGroup, Me.searchTextBox, Me.emptySpaceItem1, Me.searchResultAndButtonsGroup})
            Me.searchPanelLayoutControlGroup.Location = New System.Drawing.Point(1, 0)
            Me.searchPanelLayoutControlGroup.Name = "searchPanelLayoutControlGroup"
            Me.searchPanelLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 3, 5)
            Me.searchPanelLayoutControlGroup.Size = New System.Drawing.Size(279, 558)
            Me.searchPanelLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.searchPanelLayoutControlGroup.Text = "Search Panel"
            ' 
            ' searchOptionsLayoutControlGroup
            ' 
            Me.searchOptionsLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.searchOptionsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.matchCaseControlItem, Me.layoutControlItem1})
            Me.searchOptionsLayoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.searchOptionsLayoutControlGroup.Location = New System.Drawing.Point(0, 46)
            Me.searchOptionsLayoutControlGroup.Name = "searchOptionsLayoutControlGroup"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 100R
            Me.searchOptionsLayoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1})
            rowDefinition1.Height = 24R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition2.Height = 24R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.searchOptionsLayoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2})
            Me.searchOptionsLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
            Me.searchOptionsLayoutControlGroup.Size = New System.Drawing.Size(267, 77)
            Me.searchOptionsLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.searchOptionsLayoutControlGroup.Text = "Search Options"
            ' 
            ' matchCaseControlItem
            ' 
            Me.matchCaseControlItem.Control = Me.matchCase
            Me.matchCaseControlItem.Location = New System.Drawing.Point(0, 0)
            Me.matchCaseControlItem.Name = "matchCaseControlItem"
            Me.matchCaseControlItem.Size = New System.Drawing.Size(255, 24)
            Me.matchCaseControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.matchCaseControlItem.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.findWholeWordsOnly
            Me.layoutControlItem1.CustomizationFormText = "findWholeWordsOnly"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem1.Size = New System.Drawing.Size(255, 24)
            Me.layoutControlItem1.Text = "findWholeWordsOnly"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' searchTextBox
            ' 
            Me.searchTextBox.Control = Me.searchControl
            Me.searchTextBox.CustomizationFormText = "searchTextBox"
            Me.searchTextBox.Location = New System.Drawing.Point(0, 0)
            Me.searchTextBox.Name = "searchTextBox"
            Me.searchTextBox.Size = New System.Drawing.Size(267, 24)
            Me.searchTextBox.TextSize = New System.Drawing.Size(0, 0)
            Me.searchTextBox.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 123)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(267, 405)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' searchResultAndButtonsGroup
            ' 
            Me.searchResultAndButtonsGroup.CustomizationFormText = "searchResultAndButtonsGroup"
            Me.searchResultAndButtonsGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.searchResultAndButtonsGroup.GroupBordersVisible = False
            Me.searchResultAndButtonsGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.navigationButtonsEdit})
            Me.searchResultAndButtonsGroup.Location = New System.Drawing.Point(0, 24)
            Me.searchResultAndButtonsGroup.Name = "searchResultAndButtonsGroup"
            Me.searchResultAndButtonsGroup.Size = New System.Drawing.Size(267, 22)
            Me.searchResultAndButtonsGroup.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem2.Control = Me.searchText
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(118, 22)
            Me.layoutControlItem2.Text = "searchText"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' navigationButtonsEdit
            ' 
            Me.navigationButtonsEdit.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.navigationButtonsEdit.Control = Me.buttonEdit1
            Me.navigationButtonsEdit.CustomizationFormText = "navigationButtonsEdit"
            Me.navigationButtonsEdit.Location = New System.Drawing.Point(118, 0)
            Me.navigationButtonsEdit.Name = "navigationButtonsEdit"
            Me.navigationButtonsEdit.Size = New System.Drawing.Size(149, 22)
            Me.navigationButtonsEdit.TextSize = New System.Drawing.Size(0, 0)
            Me.navigationButtonsEdit.TextVisible = False
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 0)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.simpleSeparator1.Size = New System.Drawing.Size(1, 558)
            ' 
            ' CustomDrawModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.hitTestPanelControl)
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "CustomDrawModule"
            Me.Size = New System.Drawing.Size(1296, 608)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichEditFontSizeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.displayForReviewModeComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemBorderLineStyle1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemBorderLineWeight1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFloatingObjectOutlineWeight1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hitTestPanelControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hitTestPanelControl.ResumeLayout(False)
            CType((Me.hitTestPanelLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hitTestPanelLayoutControl.ResumeLayout(False)
            CType((Me.buttonEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.findWholeWordsOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.matchCase.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchPanelLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchOptionsLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.matchCaseControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchTextBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchResultAndButtonsGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationButtonsEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit

        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit

        Private displayForReviewModeComboBox1 As DevExpress.XtraRichEdit.UI.DisplayForReviewModeComboBox

        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle

        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight

        Private repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight

        Private hitTestPanelControl As DevExpress.XtraEditors.PanelControl

        Private hitTestPanelLayoutControl As DevExpress.XtraLayout.LayoutControl

        Private searchText As DevExpress.XtraEditors.LabelControl

        Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit

        Private findWholeWordsOnly As DevExpress.XtraEditors.CheckEdit

        Private matchCase As DevExpress.XtraEditors.CheckEdit

        Private searchControl As DevExpress.XtraEditors.SearchControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private searchPanelLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private searchOptionsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private matchCaseControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private searchTextBox As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private navigationButtonsEdit As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private searchResultAndButtonsGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    End Class
End Namespace
