Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleBreadCrumbEdit

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleBreadCrumbEdit))
            Dim breadCrumbNode1 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode2 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnGoForward = New DevExpress.XtraEditors.SimpleButton()
            Me.btnGoUp = New DevExpress.XtraEditors.SimpleButton()
            Me.btnGoBack = New DevExpress.XtraEditors.SimpleButton()
            Me.selNodeValueLabel = New DevExpress.XtraEditors.LabelControl()
            Me.btnClearEventLog = New DevExpress.XtraEditors.SimpleButton()
            Me.cbeImages = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.ceShowRootGlyph = New DevExpress.XtraEditors.CheckEdit()
            Me.seDropDownRowCount = New DevExpress.XtraEditors.SpinEdit()
            Me.cbeMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.eventsLog = New DevExpress.XtraEditors.MemoEdit()
            Me.pathLabel = New DevExpress.XtraEditors.LabelControl()
            Me.breadCrumbEdit = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbeImages.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowRootGlyph.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seDropDownRowCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.eventsLog.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.breadCrumbEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.btnGoForward)
            Me.layoutControl1.Controls.Add(Me.btnGoUp)
            Me.layoutControl1.Controls.Add(Me.btnGoBack)
            Me.layoutControl1.Controls.Add(Me.selNodeValueLabel)
            Me.layoutControl1.Controls.Add(Me.btnClearEventLog)
            Me.layoutControl1.Controls.Add(Me.cbeImages)
            Me.layoutControl1.Controls.Add(Me.ceShowRootGlyph)
            Me.layoutControl1.Controls.Add(Me.seDropDownRowCount)
            Me.layoutControl1.Controls.Add(Me.cbeMode)
            Me.layoutControl1.Controls.Add(Me.eventsLog)
            Me.layoutControl1.Controls.Add(Me.pathLabel)
            Me.layoutControl1.Controls.Add(Me.breadCrumbEdit)
            Me.layoutControl1.Location = New System.Drawing.Point(38, 16)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(636, 446)
            Me.layoutControl1.TabIndex = 15
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnGoForward
            ' 
            Me.btnGoForward.Location = New System.Drawing.Point(208, 365)
            Me.btnGoForward.Name = "btnGoForward"
            Me.btnGoForward.Size = New System.Drawing.Size(85, 22)
            Me.btnGoForward.StyleController = Me.layoutControl1
            Me.btnGoForward.TabIndex = 2
            Me.btnGoForward.Text = "Go Forward"
            AddHandler Me.btnGoForward.Click, New System.EventHandler(AddressOf Me.OnGoForwardClick)
            ' 
            ' btnGoUp
            ' 
            Me.btnGoUp.Location = New System.Drawing.Point(27, 365)
            Me.btnGoUp.Name = "btnGoUp"
            Me.btnGoUp.Size = New System.Drawing.Size(88, 22)
            Me.btnGoUp.StyleController = Me.layoutControl1
            Me.btnGoUp.TabIndex = 3
            Me.btnGoUp.Text = "Go Up"
            AddHandler Me.btnGoUp.Click, New System.EventHandler(AddressOf Me.OnGoUpClick)
            ' 
            ' btnGoBack
            ' 
            Me.btnGoBack.Location = New System.Drawing.Point(119, 365)
            Me.btnGoBack.Name = "btnGoBack"
            Me.btnGoBack.Size = New System.Drawing.Size(85, 22)
            Me.btnGoBack.StyleController = Me.layoutControl1
            Me.btnGoBack.TabIndex = 1
            Me.btnGoBack.Text = "Go Back"
            AddHandler Me.btnGoBack.Click, New System.EventHandler(AddressOf Me.OnGoBackClick)
            ' 
            ' selNodeValueLabel
            ' 
            Me.selNodeValueLabel.Appearance.Options.UseTextOptions = True
            Me.selNodeValueLabel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.selNodeValueLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.selNodeValueLabel.Location = New System.Drawing.Point(149, 278)
            Me.selNodeValueLabel.Name = "selNodeValueLabel"
            Me.selNodeValueLabel.Size = New System.Drawing.Size(144, 13)
            Me.selNodeValueLabel.StyleController = Me.layoutControl1
            Me.selNodeValueLabel.TabIndex = 15
            Me.selNodeValueLabel.Text = "(node)"
            ' 
            ' btnClearEventLog
            ' 
            Me.btnClearEventLog.Location = New System.Drawing.Point(535, 379)
            Me.btnClearEventLog.Name = "btnClearEventLog"
            Me.btnClearEventLog.Size = New System.Drawing.Size(96, 23)
            Me.btnClearEventLog.StyleController = Me.layoutControl1
            Me.btnClearEventLog.TabIndex = 8
            Me.btnClearEventLog.Text = "Clear log"
            AddHandler Me.btnClearEventLog.Click, New System.EventHandler(AddressOf Me.OnClearEventLogClick)
            ' 
            ' cbeImages
            ' 
            Me.cbeImages.Location = New System.Drawing.Point(149, 222)
            Me.cbeImages.Name = "cbeImages"
            Me.cbeImages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeImages.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Folder", "Folder", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayFolder", "GrayFolder", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Check", "Check", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Delete", "Delete", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customize", "Customize", 4)})
            Me.cbeImages.Properties.LargeImages = Me.svgImageCollection1
            Me.cbeImages.Properties.SmallImages = Me.svgImageCollection1
            Me.cbeImages.Size = New System.Drawing.Size(144, 20)
            Me.cbeImages.StyleController = Me.layoutControl1
            Me.cbeImages.TabIndex = 14
            AddHandler Me.cbeImages.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnBreadCrumbSelectedIndexChanged)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Folder", CType((resources.GetObject("svgImageCollection1.Folder")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("GrayFolder", CType((resources.GetObject("svgImageCollection1.GrayFolder")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("CheckBox", CType((resources.GetObject("svgImageCollection1.CheckBox")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Action_Delete", CType((resources.GetObject("svgImageCollection1.Action_Delete")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Settings", CType((resources.GetObject("svgImageCollection1.Settings")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' ceShowRootGlyph
            ' 
            Me.ceShowRootGlyph.Location = New System.Drawing.Point(27, 250)
            Me.ceShowRootGlyph.Name = "ceShowRootGlyph"
            Me.ceShowRootGlyph.Properties.Caption = "Show Root Glyph"
            Me.ceShowRootGlyph.Size = New System.Drawing.Size(266, 20)
            Me.ceShowRootGlyph.StyleController = Me.layoutControl1
            Me.ceShowRootGlyph.TabIndex = 12
            AddHandler Me.ceShowRootGlyph.CheckedChanged, New System.EventHandler(AddressOf Me.OnShowRootGlyphCheckedChanged)
            ' 
            ' seDropDownRowCount
            ' 
            Me.seDropDownRowCount.EditValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.seDropDownRowCount.Location = New System.Drawing.Point(149, 194)
            Me.seDropDownRowCount.Name = "seDropDownRowCount"
            Me.seDropDownRowCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seDropDownRowCount.Properties.Mask.EditMask = "n0"
            Me.seDropDownRowCount.Properties.MaxValue = New Decimal(New Integer() {48, 0, 0, 0})
            Me.seDropDownRowCount.Properties.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.seDropDownRowCount.Size = New System.Drawing.Size(144, 20)
            Me.seDropDownRowCount.StyleController = Me.layoutControl1
            Me.seDropDownRowCount.TabIndex = 11
            AddHandler Me.seDropDownRowCount.EditValueChanged, New System.EventHandler(AddressOf Me.OnBreadCrumbDropDownRowCountChanged)
            ' 
            ' cbeMode
            ' 
            Me.cbeMode.Location = New System.Drawing.Point(149, 166)
            Me.cbeMode.Name = "cbeMode"
            Me.cbeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeMode.Size = New System.Drawing.Size(144, 20)
            Me.cbeMode.StyleController = Me.layoutControl1
            Me.cbeMode.TabIndex = 10
            AddHandler Me.cbeMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnBreadCrumbModeChanged)
            ' 
            ' eventsLog
            ' 
            Me.eventsLog.EditValue = ""
            Me.eventsLog.Location = New System.Drawing.Point(345, 166)
            Me.eventsLog.Name = "eventsLog"
            Me.eventsLog.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.eventsLog.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.eventsLog.Properties.Appearance.Options.UseBackColor = True
            Me.eventsLog.Properties.Appearance.Options.UseForeColor = True
            Me.eventsLog.Properties.[ReadOnly] = True
            Me.eventsLog.Size = New System.Drawing.Size(286, 201)
            Me.eventsLog.StyleController = Me.layoutControl1
            Me.eventsLog.TabIndex = 0
            Me.eventsLog.TabStop = False
            ' 
            ' pathLabel
            ' 
            Me.pathLabel.Location = New System.Drawing.Point(27, 48)
            Me.pathLabel.Name = "pathLabel"
            Me.pathLabel.Size = New System.Drawing.Size(22, 13)
            Me.pathLabel.StyleController = Me.layoutControl1
            Me.pathLabel.TabIndex = 5
            Me.pathLabel.Text = "Path"
            ' 
            ' breadCrumbEdit
            ' 
            Me.breadCrumbEdit.Location = New System.Drawing.Point(27, 73)
            Me.breadCrumbEdit.Name = "breadCrumbEdit"
            Me.breadCrumbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.breadCrumbEdit.Properties.ImageIndex = 0
            Me.breadCrumbEdit.Properties.Images = Me.svgImageCollection1
            breadCrumbNode1.Caption = "Root"
            breadCrumbNode1.Persistent = True
            breadCrumbNode1.PopulateOnDemand = True
            breadCrumbNode1.ShowCaption = False
            breadCrumbNode1.Value = "Root"
            breadCrumbNode2.Caption = "Computer"
            breadCrumbNode2.Persistent = True
            breadCrumbNode2.PopulateOnDemand = True
            breadCrumbNode2.Value = "Computer"
            Me.breadCrumbEdit.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() {breadCrumbNode1, breadCrumbNode2})
            Me.breadCrumbEdit.Properties.RootImageIndex = 0
            Me.breadCrumbEdit.Properties.SortNodesByCaption = True
            AddHandler Me.breadCrumbEdit.Properties.PathChanged, New DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(AddressOf Me.OnBreadCrumbPathChanged)
            AddHandler Me.breadCrumbEdit.Properties.NodeClick, New DevExpress.XtraEditors.BreadCrumbNodeClickEventHandler(AddressOf Me.OnBreadCrumbNodeClick)
            AddHandler Me.breadCrumbEdit.Properties.SelectedNodeChanged, New DevExpress.XtraEditors.BreadCrumbSelectedNodeChangedEventHandler(AddressOf Me.OnBreadCrumbSelectedNodeChanged)
            AddHandler Me.breadCrumbEdit.Properties.RootGlyphClick, New System.EventHandler(AddressOf Me.OnBreadCrumbRootGlyphClick)
            AddHandler Me.breadCrumbEdit.Properties.SelectorClientEmptySpaceClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnBreadCrumbSelectorClientEmptySpaceClick)
            AddHandler Me.breadCrumbEdit.Properties.QueryChildNodes, New DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(AddressOf Me.OnBreadCrumbQueryChildNodes)
            AddHandler Me.breadCrumbEdit.Properties.ValidatePath, New DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(AddressOf Me.OnBreadCrumbValidatePath)
            AddHandler Me.breadCrumbEdit.Properties.PathRejected, New DevExpress.XtraEditors.BreadCrumbPathRejectedEventHandler(AddressOf Me.OnBreadCrumbPathRejected)
            AddHandler Me.breadCrumbEdit.Properties.NewNodeAdding, New DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(AddressOf Me.OnBreadCrumbNewNodeAdding)
            AddHandler Me.breadCrumbEdit.Properties.ShowUserActionMenu, New DevExpress.XtraEditors.BreadCrumbShowUserActionMenuEventHandler(AddressOf Me.OnBreadCrumbShowUserActionMenu)
            AddHandler Me.breadCrumbEdit.Properties.ShownNodeDropdown, New DevExpress.XtraEditors.BreadCrumbShownNodeDropDownEventHandler(AddressOf Me.OnBreadCrumbShownNodeDropdown)
            AddHandler Me.breadCrumbEdit.Properties.HiddenNodeDropDown, New DevExpress.XtraEditors.BreadCrumbHiddenNodeDropDownEventHandler(AddressOf Me.OnBreadCrumbHiddenNodeDropDown)
            Me.breadCrumbEdit.Size = New System.Drawing.Size(604, 20)
            Me.breadCrumbEdit.StyleController = Me.layoutControl1
            Me.breadCrumbEdit.TabIndex = 0
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(658, 429)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(638, 118)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.breadCrumbEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 25)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(608, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.pathLabel
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 10)
            Me.layoutControlItem2.Size = New System.Drawing.Size(608, 25)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CaptionImageOptions.SvgImage = CType((resources.GetObject("layoutControlGroup3.CaptionImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.layoutControlGroup3.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem5})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(300, 118)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(338, 291)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.layoutControlGroup3.Text = "Event log"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.eventsLog
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(290, 200)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 10)
            Me.layoutControlItem3.Size = New System.Drawing.Size(290, 213)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnClearEventLog
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 213)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(100, 36)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(55, 26)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(290, 27)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextVisible = False
            Me.layoutControlItem5.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.emptySpaceItem1})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 118)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(300, 199)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup4.Text = "Options"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbeMode
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(270, 26)
            Me.layoutControlItem4.Text = "BreadCrumb Mode:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seDropDownRowCount
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(270, 28)
            Me.layoutControlItem6.Text = "DropDown Row Count:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbeImages
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(270, 28)
            Me.layoutControlItem7.Text = "Root Glyph:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceShowRootGlyph
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(270, 28)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.selNodeValueLabel
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem9.Size = New System.Drawing.Size(270, 19)
            Me.layoutControlItem9.Text = "Selected Node:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 129)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(270, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(270, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem12})
            Me.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 317)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 34R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition2.Width = 33R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 33R
            Me.layoutControlGroup5.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3})
            rowDefinition1.Height = 41R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.layoutControlGroup5.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1})
            Me.layoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlGroup5.Size = New System.Drawing.Size(300, 92)
            Me.layoutControlGroup5.Text = "Navigation"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.btnGoUp
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(92, 41)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.btnGoBack
            Me.layoutControlItem11.Location = New System.Drawing.Point(92, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem11.Size = New System.Drawing.Size(89, 41)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.btnGoForward
            Me.layoutControlItem12.Location = New System.Drawing.Point(181, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem12.Size = New System.Drawing.Size(89, 41)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' ModuleBreadCrumbEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleBreadCrumbEdit"
            Me.Size = New System.Drawing.Size(739, 509)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbeImages.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowRootGlyph.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seDropDownRowCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.eventsLog.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.breadCrumbEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private breadCrumbEdit As DevExpress.XtraEditors.BreadCrumbEdit

        Private btnGoUp As DevExpress.XtraEditors.SimpleButton

        Private btnGoForward As DevExpress.XtraEditors.SimpleButton

        Private btnGoBack As DevExpress.XtraEditors.SimpleButton

        Private pathLabel As DevExpress.XtraEditors.LabelControl

        Private seDropDownRowCount As DevExpress.XtraEditors.SpinEdit

        Private cbeMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceShowRootGlyph As DevExpress.XtraEditors.CheckEdit

        Private eventsLog As DevExpress.XtraEditors.MemoEdit

        Private btnClearEventLog As DevExpress.XtraEditors.SimpleButton

        Private cbeImages As DevExpress.XtraEditors.ImageComboBoxEdit

        Private selNodeValueLabel As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
