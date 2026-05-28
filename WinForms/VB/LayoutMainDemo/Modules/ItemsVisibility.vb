Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Utils

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class ItemsVisibility
        Inherits TutorialControl

        Private layoutControl1 As LayoutControl

        Private showDesc As XtraEditors.CheckEdit

        Private showP1 As XtraEditors.CheckEdit

        Private pictureEdit2 As XtraEditors.PictureEdit

        Private pictureEdit1 As XtraEditors.PictureEdit

        Private memoEdit1 As XtraEditors.MemoEdit

        Private layoutControlGroup1 As LayoutControlGroup

        Private showP2 As XtraEditors.CheckEdit

        Private splitterItem2 As SplitterItem

        Private descriptionItem As LayoutControlItem

        Private picture2Item As LayoutControlItem

        Private splitterItem1 As SplitterItem

        Private picture1Item As LayoutControlItem

        Private lcTitle As LayoutControl

        Private lcMainGroup As LayoutControlGroup

        Private layoutControlItem1 As LayoutControlItem

        Private layoutControlItem2 As LayoutControlItem

        Private layoutControlItem3 As LayoutControlItem

        Private layoutControlItem4 As LayoutControlItem

        Private navigationPane1 As XtraBars.Navigation.TabPane

        Private navigationPage1 As XtraBars.Navigation.TabNavigationPage

        Private ceVerticalIsCollapsible As XtraEditors.CheckEdit

        Private ceVerticalIsCollapsed As XtraEditors.CheckEdit

        Private ceVerticalInverted As XtraEditors.CheckEdit

        Private layoutControlGroupSplitterItem1 As LayoutControlGroup

        Private layoutControlItem5 As LayoutControlItem

        Private layoutControlItem6 As LayoutControlItem

        Private layoutControlItem7 As LayoutControlItem

        Private ceHorizontalInverted As XtraEditors.CheckEdit

        Private ceHorizontalIsCollapsed As XtraEditors.CheckEdit

        Private ceHorizontalIsCollapsible As XtraEditors.CheckEdit

        Private layoutControlGroupSplitterItem2 As LayoutControlGroup

        Private layoutControlItem8 As LayoutControlItem

        Private layoutControlItem9 As LayoutControlItem

        Private layoutControlItem10 As LayoutControlItem

        Private layoutControlGroup2 As LayoutControlGroup

        Private emptySpaceItem1 As EmptySpaceItem

        Private sidePanel1 As XtraEditors.SidePanel

        Private rotateLayoutButton As XtraEditors.SimpleButton

        Public Sub New()
            InitializeComponent()
            UpdateSplitterOptions()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ItemsVisibility"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ItemsVisibility"}
            End Get
        End Property

        Private Sub UpdateSplitterOptions()
            ceVerticalInverted.Checked = splitterItem1.Inverted
            ceVerticalIsCollapsed.Checked = splitterItem1.IsCollapsed
            ceVerticalIsCollapsible.Checked = splitterItem1.IsCollapsible = DefaultBoolean.True
            ceHorizontalInverted.Checked = splitterItem2.Inverted
            ceHorizontalIsCollapsed.Checked = splitterItem2.IsCollapsed
            ceHorizontalIsCollapsible.Checked = splitterItem2.IsCollapsible = DefaultBoolean.True
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsVisibility))
            layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            pictureEdit2 = New XtraEditors.PictureEdit()
            pictureEdit1 = New XtraEditors.PictureEdit()
            memoEdit1 = New XtraEditors.MemoEdit()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            splitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            descriptionItem = New DevExpress.XtraLayout.LayoutControlItem()
            picture2Item = New DevExpress.XtraLayout.LayoutControlItem()
            splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            picture1Item = New DevExpress.XtraLayout.LayoutControlItem()
            navigationPane1 = New XtraBars.Navigation.TabPane()
            navigationPage1 = New XtraBars.Navigation.TabNavigationPage()
            lcTitle = New DevExpress.XtraLayout.LayoutControl()
            ceVerticalIsCollapsible = New XtraEditors.CheckEdit()
            ceVerticalIsCollapsed = New XtraEditors.CheckEdit()
            ceVerticalInverted = New XtraEditors.CheckEdit()
            showDesc = New XtraEditors.CheckEdit()
            showP2 = New XtraEditors.CheckEdit()
            showP1 = New XtraEditors.CheckEdit()
            Me.rotateLayoutButton = New XtraEditors.SimpleButton()
            ceHorizontalInverted = New XtraEditors.CheckEdit()
            ceHorizontalIsCollapsed = New XtraEditors.CheckEdit()
            ceHorizontalIsCollapsible = New XtraEditors.CheckEdit()
            Me.lcMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlGroupSplitterItem1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroupSplitterItem2 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            sidePanel1 = New XtraEditors.SidePanel()
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControl1.SuspendLayout()
            CType(pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(splitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(descriptionItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(picture2Item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(picture1Item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            navigationPane1.SuspendLayout()
            navigationPage1.SuspendLayout()
            CType(lcTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            lcTitle.SuspendLayout()
            CType(ceVerticalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ceVerticalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ceVerticalInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(showDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(showP2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(showP1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ceHorizontalInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ceHorizontalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ceHorizontalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcMainGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroupSplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroupSplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            layoutControl1.Controls.Add(pictureEdit2)
            layoutControl1.Controls.Add(pictureEdit1)
            layoutControl1.Controls.Add(memoEdit1)
            layoutControl1.Dock = DockStyle.Fill
            layoutControl1.Location = New System.Drawing.Point(0, 0)
            layoutControl1.Name = "layoutControl1"
            layoutControl1.Root = layoutControlGroup1
            layoutControl1.Size = New System.Drawing.Size(518, 505)
            layoutControl1.TabIndex = 0
            layoutControl1.Text = "layoutControl1"
            AddHandler layoutControl1.Changed, New EventHandler(AddressOf layoutControl1_Changed)
            ' 
            ' pictureEdit2
            ' 
            pictureEdit2.Cursor = Cursors.Default
            pictureEdit2.EditValue = Global.DevExpress.XtraLayout.Demos.Properties.Resources.bc11
            pictureEdit2.Location = New System.Drawing.Point(12, 12)
            pictureEdit2.Name = "pictureEdit2"
            pictureEdit2.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom
            pictureEdit2.Size = New System.Drawing.Size(242, 256)
            pictureEdit2.StyleController = layoutControl1
            pictureEdit2.TabIndex = 6
            ' 
            ' pictureEdit1
            ' 
            pictureEdit1.Cursor = Cursors.Default
            pictureEdit1.EditValue = Global.DevExpress.XtraLayout.Demos.Properties.Resources.bc12
            pictureEdit1.Location = New System.Drawing.Point(268, 12)
            pictureEdit1.Name = "pictureEdit1"
            pictureEdit1.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom
            pictureEdit1.Size = New System.Drawing.Size(238, 256)
            pictureEdit1.StyleController = layoutControl1
            pictureEdit1.TabIndex = 5
            ' 
            ' memoEdit1
            ' 
            memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            memoEdit1.Location = New System.Drawing.Point(12, 298)
            memoEdit1.Name = "memoEdit1"
            memoEdit1.Size = New System.Drawing.Size(494, 195)
            memoEdit1.StyleController = layoutControl1
            memoEdit1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True
            layoutControlGroup1.GroupBordersVisible = False
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {splitterItem2, descriptionItem, picture2Item, splitterItem1, picture1Item})
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Size = New System.Drawing.Size(518, 505)
            layoutControlGroup1.TextVisible = False
            ' 
            ' splitterItem2
            ' 
            splitterItem2.CustomizationFormText = "splitterItem2"
            splitterItem2.IsCollapsible = DefaultBoolean.True
            splitterItem2.Location = New System.Drawing.Point(0, 260)
            splitterItem2.Name = "splitterItem2"
            splitterItem2.Size = New System.Drawing.Size(498, 10)
            ' 
            ' descriptionItem
            ' 
            descriptionItem.Control = memoEdit1
            descriptionItem.CustomizationFormText = "layoutControlItem1"
            descriptionItem.Location = New System.Drawing.Point(0, 270)
            descriptionItem.Name = "descriptionItem"
            descriptionItem.Size = New System.Drawing.Size(498, 215)
            descriptionItem.Text = "Description"
            descriptionItem.TextLocation = Locations.Top
            descriptionItem.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' picture2Item
            ' 
            picture2Item.Control = pictureEdit1
            picture2Item.CustomizationFormText = "layoutControlItem2"
            picture2Item.Location = New System.Drawing.Point(256, 0)
            picture2Item.Name = "picture2Item"
            picture2Item.Size = New System.Drawing.Size(242, 260)
            picture2Item.TextLocation = Locations.Left
            picture2Item.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            splitterItem1.CustomizationFormText = "splitterItem1"
            splitterItem1.IsCollapsible = DefaultBoolean.True
            splitterItem1.Location = New System.Drawing.Point(246, 0)
            splitterItem1.Name = "splitterItem1"
            splitterItem1.Size = New System.Drawing.Size(10, 260)
            ' 
            ' picture1Item
            ' 
            picture1Item.Control = pictureEdit2
            picture1Item.CustomizationFormText = "layoutControlItem3"
            picture1Item.Location = New System.Drawing.Point(0, 0)
            picture1Item.Name = "picture1Item"
            picture1Item.Size = New System.Drawing.Size(246, 260)
            picture1Item.TextLocation = Locations.Left
            picture1Item.TextVisible = False
            ' 
            ' navigationPane1
            ' 
            navigationPane1.AllowResize = False
            navigationPane1.AllowTransitionAnimation = DefaultBoolean.False
            navigationPane1.Controls.Add(navigationPage1)
            navigationPane1.Dock = DockStyle.Fill
            navigationPane1.Location = New System.Drawing.Point(1, 0)
            navigationPane1.Name = "navigationPane1"
            navigationPane1.PageProperties.ShowMode = XtraBars.Navigation.ItemShowMode.Text
            navigationPane1.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPage1})
            navigationPane1.RegularSize = New System.Drawing.Size(249, 505)
            navigationPane1.SelectedPage = navigationPage1
            navigationPane1.Size = New System.Drawing.Size(249, 505)
            navigationPane1.TabIndex = 4
            navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            navigationPage1.Caption = "Options"
            navigationPage1.Controls.Add(lcTitle)
            navigationPage1.Name = "navigationPage1"
            navigationPage1.Size = New System.Drawing.Size(249, 472)
            ' 
            ' lcTitle
            ' 
            lcTitle.AllowCustomization = False
            lcTitle.Controls.Add(ceVerticalIsCollapsible)
            lcTitle.Controls.Add(ceVerticalIsCollapsed)
            lcTitle.Controls.Add(ceVerticalInverted)
            lcTitle.Controls.Add(showDesc)
            lcTitle.Controls.Add(showP2)
            lcTitle.Controls.Add(showP1)
            lcTitle.Controls.Add(Me.rotateLayoutButton)
            lcTitle.Controls.Add(ceHorizontalInverted)
            lcTitle.Controls.Add(ceHorizontalIsCollapsed)
            lcTitle.Controls.Add(ceHorizontalIsCollapsible)
            lcTitle.Dock = DockStyle.Fill
            lcTitle.Location = New System.Drawing.Point(0, 0)
            lcTitle.Name = "lcTitle"
            lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(668, 323, 715, 579)
            lcTitle.OptionsView.AllowExpandAnimation = DefaultBoolean.True
            lcTitle.OptionsView.UseParentAutoScaleFactor = True
            lcTitle.Root = Me.lcMainGroup
            lcTitle.Size = New System.Drawing.Size(249, 472)
            lcTitle.TabIndex = 1
            ' 
            ' ceVerticalIsCollapsible
            ' 
            ceVerticalIsCollapsible.Location = New System.Drawing.Point(14, 248)
            ceVerticalIsCollapsible.Name = "ceVerticalIsCollapsible"
            ceVerticalIsCollapsible.Properties.Caption = "IsCollapsible"
            ceVerticalIsCollapsible.Size = New System.Drawing.Size(221, 20)
            ceVerticalIsCollapsible.StyleController = lcTitle
            ceVerticalIsCollapsible.TabIndex = 13
            AddHandler ceVerticalIsCollapsible.CheckedChanged, New EventHandler(AddressOf ceVerticalIsCollapsible_CheckedChanged)
            ' 
            ' ceVerticalIsCollapsed
            ' 
            ceVerticalIsCollapsed.Location = New System.Drawing.Point(14, 220)
            ceVerticalIsCollapsed.Name = "ceVerticalIsCollapsed"
            ceVerticalIsCollapsed.Properties.Caption = "IsCollapsed"
            ceVerticalIsCollapsed.Size = New System.Drawing.Size(221, 20)
            ceVerticalIsCollapsed.StyleController = lcTitle
            ceVerticalIsCollapsed.TabIndex = 12
            AddHandler ceVerticalIsCollapsed.CheckedChanged, New EventHandler(AddressOf ceVerticalIsCollapsed_CheckedChanged)
            ' 
            ' ceVerticalInverted
            ' 
            ceVerticalInverted.Location = New System.Drawing.Point(14, 192)
            ceVerticalInverted.Name = "ceVerticalInverted"
            ceVerticalInverted.Properties.Caption = "Inverted"
            ceVerticalInverted.Size = New System.Drawing.Size(221, 20)
            ceVerticalInverted.StyleController = lcTitle
            ceVerticalInverted.TabIndex = 11
            AddHandler ceVerticalInverted.CheckedChanged, New EventHandler(AddressOf ceVerticalInverted_CheckedChanged)
            ' 
            ' showDesc
            ' 
            showDesc.AutoSizeInLayoutControl = True
            showDesc.EditValue = True
            showDesc.Location = New System.Drawing.Point(12, 36)
            showDesc.Name = "showDesc"
            showDesc.Properties.Caption = "Show Description"
            showDesc.Size = New System.Drawing.Size(105, 20)
            showDesc.StyleController = lcTitle
            showDesc.TabIndex = 8
            AddHandler showDesc.CheckedChanged, New EventHandler(AddressOf showDesc_CheckedChanged)
            ' 
            ' showP2
            ' 
            showP2.AutoSizeInLayoutControl = True
            showP2.EditValue = True
            showP2.Location = New System.Drawing.Point(12, 92)
            showP2.Name = "showP2"
            showP2.Properties.Caption = "Show Picture2"
            showP2.Size = New System.Drawing.Size(91, 20)
            showP2.StyleController = lcTitle
            showP2.TabIndex = 9
            AddHandler showP2.CheckedChanged, New EventHandler(AddressOf checkEdit3_CheckedChanged)
            ' 
            ' showP1
            ' 
            showP1.AutoSizeInLayoutControl = True
            showP1.EditValue = True
            showP1.Location = New System.Drawing.Point(12, 64)
            showP1.Name = "showP1"
            showP1.Properties.Caption = "Show Picture1"
            showP1.Size = New System.Drawing.Size(91, 20)
            showP1.StyleController = lcTitle
            showP1.TabIndex = 7
            AddHandler showP1.CheckedChanged, New EventHandler(AddressOf checkEdit1_CheckedChanged)
            ' 
            ' rotateLayoutButton
            ' 
            Me.rotateLayoutButton.Location = New System.Drawing.Point(12, 120)
            Me.rotateLayoutButton.Name = "rotateLayoutButton"
            Me.rotateLayoutButton.Size = New System.Drawing.Size(225, 22)
            Me.rotateLayoutButton.StyleController = lcTitle
            Me.rotateLayoutButton.TabIndex = 10
            Me.rotateLayoutButton.Text = "Rotate Layout 90 Degrees"
            AddHandler Me.rotateLayoutButton.Click, New EventHandler(AddressOf Me.rotateLayoutButton_Click)
            ' 
            ' ceHorizontalInverted
            ' 
            ceHorizontalInverted.Location = New System.Drawing.Point(14, 318)
            ceHorizontalInverted.Name = "ceHorizontalInverted"
            ceHorizontalInverted.Properties.Caption = "Inverted"
            ceHorizontalInverted.Size = New System.Drawing.Size(221, 20)
            ceHorizontalInverted.StyleController = lcTitle
            ceHorizontalInverted.TabIndex = 11
            AddHandler ceHorizontalInverted.CheckedChanged, New EventHandler(AddressOf ceHorizontalInverted_CheckedChanged)
            ' 
            ' ceHorizontalIsCollapsed
            ' 
            ceHorizontalIsCollapsed.Location = New System.Drawing.Point(14, 346)
            ceHorizontalIsCollapsed.Name = "ceHorizontalIsCollapsed"
            ceHorizontalIsCollapsed.Properties.Caption = "IsCollapsed"
            ceHorizontalIsCollapsed.Size = New System.Drawing.Size(221, 20)
            ceHorizontalIsCollapsed.StyleController = lcTitle
            ceHorizontalIsCollapsed.TabIndex = 12
            AddHandler ceHorizontalIsCollapsed.CheckedChanged, New EventHandler(AddressOf ceHorizontalIsCollapsed_CheckedChanged)
            ' 
            ' ceHorizontalIsCollapsible
            ' 
            ceHorizontalIsCollapsible.Location = New System.Drawing.Point(14, 374)
            ceHorizontalIsCollapsible.Name = "ceHorizontalIsCollapsible"
            ceHorizontalIsCollapsible.Properties.Caption = "IsCollapsible"
            ceHorizontalIsCollapsible.Size = New System.Drawing.Size(221, 20)
            ceHorizontalIsCollapsible.StyleController = lcTitle
            ceHorizontalIsCollapsible.TabIndex = 13
            AddHandler ceHorizontalIsCollapsible.CheckedChanged, New EventHandler(AddressOf ceHorizontalIsCollapsible_CheckedChanged)
            ' 
            ' lcMainGroup
            ' 
            Me.lcMainGroup.CustomizationFormText = "Root"
            Me.lcMainGroup.GroupBordersVisible = False
            Me.lcMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroupSplitterItem1, layoutControlGroupSplitterItem2, layoutControlGroup2, emptySpaceItem1})
            Me.lcMainGroup.Name = "Root"
            Me.lcMainGroup.OptionsItemText.TextToControlDistance = 5
            Me.lcMainGroup.Size = New System.Drawing.Size(249, 472)
            Me.lcMainGroup.Text = "Select xml file and restore layout"
            Me.lcMainGroup.TextVisible = False
            ' 
            ' layoutControlGroupSplitterItem1
            ' 
            layoutControlGroupSplitterItem1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            layoutControlGroupSplitterItem1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem5, layoutControlItem6, layoutControlItem7})
            layoutControlGroupSplitterItem1.Location = New System.Drawing.Point(0, 156)
            layoutControlGroupSplitterItem1.Name = "layoutControlGroup2"
            layoutControlGroupSplitterItem1.OptionsItemText.TextToControlDistance = 5
            layoutControlGroupSplitterItem1.Size = New System.Drawing.Size(249, 126)
            layoutControlGroupSplitterItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            layoutControlGroupSplitterItem1.Text = "Vertical SplitterItem"
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.Control = ceVerticalInverted
            layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem5.Size = New System.Drawing.Size(229, 28)
            layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.Control = ceVerticalIsCollapsed
            layoutControlItem6.Location = New System.Drawing.Point(0, 28)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem6.Size = New System.Drawing.Size(229, 28)
            layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            layoutControlItem7.Control = ceVerticalIsCollapsible
            layoutControlItem7.Location = New System.Drawing.Point(0, 56)
            layoutControlItem7.Name = "layoutControlItem7"
            layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem7.Size = New System.Drawing.Size(229, 28)
            layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroupSplitterItem2
            ' 
            layoutControlGroupSplitterItem2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            layoutControlGroupSplitterItem2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem8, layoutControlItem9, layoutControlItem10})
            layoutControlGroupSplitterItem2.Location = New System.Drawing.Point(0, 282)
            layoutControlGroupSplitterItem2.Name = "layoutControlGroup4"
            layoutControlGroupSplitterItem2.OptionsItemText.TextToControlDistance = 5
            layoutControlGroupSplitterItem2.Size = New System.Drawing.Size(249, 126)
            layoutControlGroupSplitterItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            layoutControlGroupSplitterItem2.Text = "Horizontal SplitterItem"
            ' 
            ' layoutControlItem8
            ' 
            layoutControlItem8.Control = ceHorizontalInverted
            layoutControlItem8.CustomizationFormText = "layoutControlItem5"
            layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            layoutControlItem8.Name = "layoutControlItem8"
            layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem8.Size = New System.Drawing.Size(229, 28)
            layoutControlItem8.Text = "layoutControlItem5"
            layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            layoutControlItem9.Control = ceHorizontalIsCollapsed
            layoutControlItem9.CustomizationFormText = "layoutControlItem6"
            layoutControlItem9.Location = New System.Drawing.Point(0, 28)
            layoutControlItem9.Name = "layoutControlItem9"
            layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem9.Size = New System.Drawing.Size(229, 28)
            layoutControlItem9.Text = "layoutControlItem6"
            layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            layoutControlItem10.Control = ceHorizontalIsCollapsible
            layoutControlItem10.CustomizationFormText = "layoutControlItem7"
            layoutControlItem10.Location = New System.Drawing.Point(0, 56)
            layoutControlItem10.Name = "layoutControlItem10"
            layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            layoutControlItem10.Size = New System.Drawing.Size(229, 28)
            layoutControlItem10.Text = "layoutControlItem7"
            layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem4, layoutControlItem3, layoutControlItem2, layoutControlItem1})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            layoutControlGroup2.Name = "item0"
            layoutControlGroup2.Size = New System.Drawing.Size(249, 156)
            layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            layoutControlGroup2.Text = "Layout "
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = showDesc
            layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            layoutControlItem4.Size = New System.Drawing.Size(229, 28)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = showP1
            layoutControlItem3.Location = New System.Drawing.Point(0, 28)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            layoutControlItem3.Size = New System.Drawing.Size(229, 28)
            layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = showP2
            layoutControlItem2.Location = New System.Drawing.Point(0, 56)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            layoutControlItem2.Size = New System.Drawing.Size(229, 28)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = Me.rotateLayoutButton
            layoutControlItem1.Location = New System.Drawing.Point(0, 84)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            layoutControlItem1.Size = New System.Drawing.Size(229, 30)
            layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.Location = New System.Drawing.Point(0, 408)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.Size = New System.Drawing.Size(249, 64)
            ' 
            ' sidePanel1
            ' 
            sidePanel1.Controls.Add(navigationPane1)
            sidePanel1.Dock = DockStyle.Right
            sidePanel1.Location = New System.Drawing.Point(518, 0)
            sidePanel1.Name = "sidePanel1"
            sidePanel1.Size = New System.Drawing.Size(250, 505)
            sidePanel1.TabIndex = 7
            sidePanel1.Text = "sidePanel1"
            ' 
            ' ItemsVisibility
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(layoutControl1)
            Me.Controls.Add(sidePanel1)
            Name = "ItemsVisibility"
            Size = New System.Drawing.Size(768, 505)
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControl1.ResumeLayout(False)
            CType(pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(splitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(descriptionItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(picture2Item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(picture1Item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            navigationPane1.ResumeLayout(False)
            navigationPage1.ResumeLayout(False)
            CType(lcTitle, System.ComponentModel.ISupportInitialize).EndInit()
            lcTitle.ResumeLayout(False)
            CType(ceVerticalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ceVerticalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ceVerticalInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(showDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(showP2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(showP1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ceHorizontalInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ceHorizontalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ceHorizontalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcMainGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroupSplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroupSplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private Sub showDesc_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibility()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibility()
        End Sub

        Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibility()
        End Sub

        '<showDesc>//<showP1>//<showP2>
        Protected Sub UpdateVisibility()
            UpdateVisibility(showDesc.Checked, showP1.Checked, showP2.Checked)
        End Sub

        Protected Sub SetVisibility(ByVal picture1ItemVisibility As LayoutVisibility, ByVal picture2ItemVisibility As LayoutVisibility, ByVal descriptionItemVisibility As LayoutVisibility)
            picture1Item.Visibility = picture1ItemVisibility
            picture2Item.Visibility = picture2ItemVisibility
            descriptionItem.Visibility = descriptionItemVisibility
            If picture1ItemVisibility = LayoutVisibility.Always AndAlso picture2ItemVisibility = LayoutVisibility.Always Then
                splitterItem1.Visibility = LayoutVisibility.Always
            Else
                splitterItem1.Visibility = LayoutVisibility.Never
            End If

            If(picture1ItemVisibility = LayoutVisibility.Always OrElse picture2ItemVisibility = LayoutVisibility.Always) AndAlso descriptionItemVisibility = LayoutVisibility.Always Then
                splitterItem2.Visibility = LayoutVisibility.Always
            Else
                splitterItem2.Visibility = LayoutVisibility.Never
            End If
        End Sub

        Protected Sub UpdateVisibility(ByVal showDescription As Boolean, ByVal showPicure1 As Boolean, ByVal showPicture2 As Boolean)
            SetVisibility(LayoutVisibilityConvertor.FromBoolean(showPicure1), LayoutVisibilityConvertor.FromBoolean(showPicture2), LayoutVisibilityConvertor.FromBoolean(showDescription))
        End Sub

        '</showDesc>//</showP1>//</showP2>
        '<rotateLayoutButton>
        Private Sub rotateLayoutButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            layoutControl1.Root.RotateLayout()
            layoutControlGroupSplitterItem1.Text = If(splitterItem1.IsHorizontal, "Horizontal SplitterItem", "Vertical SplitterItem")
            layoutControlGroupSplitterItem2.Text = If(splitterItem2.IsHorizontal, "Horizontal SplitterItem", "Vertical SplitterItem")
        End Sub

        '</rotateLayoutButton>
        '<ceVerticalInverted>
        Private Sub ceVerticalInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem1.Inverted = ceVerticalInverted.Checked
        End Sub

        '</ceVerticalInverted>
        '<ceVerticalIsCollapsed>
        Private Sub ceVerticalIsCollapsed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem1.IsCollapsed = ceVerticalIsCollapsed.Checked
        End Sub

        '</ceVerticalIsCollapsed>
        '<ceVerticalIsCollapsible>
        Private Sub ceVerticalIsCollapsible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem1.IsCollapsible = If(ceVerticalIsCollapsible.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceVerticalIsCollapsible>
        '<ceHorizontalInverted>
        Private Sub ceHorizontalInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem2.Inverted = ceHorizontalInverted.Checked
        End Sub

        '</ceHorizontalInverted>
        '<ceHorizontalIsCollapsed>
        Private Sub ceHorizontalIsCollapsed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem2.IsCollapsed = ceHorizontalIsCollapsed.Checked
        End Sub

        '</ceHorizontalIsCollapsed>
        '<ceHorizontalIsCollapsible>
        Private Sub ceHorizontalIsCollapsible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            splitterItem2.IsCollapsible = If(ceHorizontalIsCollapsible.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceHorizontalIsCollapsible>
        Private Sub layoutControl1_Changed(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSplitterOptions()
        End Sub
    End Class
End Namespace
