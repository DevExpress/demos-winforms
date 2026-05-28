Namespace DevExpress.XtraLayout.Demos

    Partial Class XtraLayoutPanelTutorialControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.XtraLayoutPanelTutorialControl))
            Me.contentPanel = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel = New DevExpress.XtraEditors.SidePanel()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.btnResetLayout = New DevExpress.XtraEditors.SimpleButton()
            Me.propertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.toolboxControl = New DevExpress.XtraToolbox.ToolboxControl()
            Me.toolboxGroupRoot = New DevExpress.XtraToolbox.ToolboxGroup()
            Me.tiSimpleButton = New DevExpress.XtraToolbox.ToolboxItem()
            Me.tiTextEdit = New DevExpress.XtraToolbox.ToolboxItem()
            Me.tiLabel = New DevExpress.XtraToolbox.ToolboxItem()
            Me.tiCheckEdit = New DevExpress.XtraToolbox.ToolboxItem()
            Me.imageList = New DevExpress.Utils.ImageCollection(Me.components)
            Me.lcgRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcgToolbox = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liToolbox = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liPropertyGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liResetLayout = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.rootPanel = New DevExpress.XtraEditors.PanelControl()
            Me.topStackPanel = New DevExpress.Utils.Layout.StackPanel()
            Me.labelHint = New DevExpress.XtraEditors.LabelControl()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.propertyGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liToolbox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rootPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.rootPanel.SuspendLayout()
            CType((Me.topStackPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.topStackPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' contentPanel
            ' 
            Me.contentPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contentPanel.Location = New System.Drawing.Point(0, 50)
            Me.contentPanel.Name = "contentPanel"
            Me.contentPanel.Size = New System.Drawing.Size(693, 536)
            Me.contentPanel.TabIndex = 4
            ' 
            ' sidePanel
            ' 
            Me.sidePanel.Controls.Add(Me.layoutControl)
            Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel.Location = New System.Drawing.Point(693, 0)
            Me.sidePanel.Name = "sidePanel"
            Me.sidePanel.Size = New System.Drawing.Size(250, 586)
            Me.sidePanel.TabIndex = 11
            Me.sidePanel.Text = "sidePanel1"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.btnResetLayout)
            Me.layoutControl.Controls.Add(Me.propertyGridControl)
            Me.layoutControl.Controls.Add(Me.toolboxControl)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(1, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(880, 335, 650, 400)
            Me.layoutControl.Root = Me.lcgRoot
            Me.layoutControl.Size = New System.Drawing.Size(249, 586)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' btnResetLayout
            ' 
            Me.btnResetLayout.Location = New System.Drawing.Point(12, 528)
            Me.btnResetLayout.Name = "btnResetLayout"
            Me.btnResetLayout.Size = New System.Drawing.Size(225, 22)
            Me.btnResetLayout.StyleController = Me.layoutControl
            Me.btnResetLayout.TabIndex = 6
            Me.btnResetLayout.Text = "Reset Layout"
            AddHandler Me.btnResetLayout.Click, New System.EventHandler(AddressOf Me.OnResetLayoutClick)
            ' 
            ' propertyGridControl
            ' 
            Me.propertyGridControl.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office
            Me.propertyGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.propertyGridControl.Location = New System.Drawing.Point(0, 169)
            Me.propertyGridControl.Name = "propertyGridControl"
            Me.propertyGridControl.OptionsBehavior.AutoPostEditorDelay = 600
            Me.propertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl.OptionsView.LevelIndent = 9
            Me.propertyGridControl.OptionsView.ShowRootCategories = False
            Me.propertyGridControl.RecordWidth = 178
            Me.propertyGridControl.RowHeaderWidth = 22
            Me.propertyGridControl.Size = New System.Drawing.Size(249, 357)
            Me.propertyGridControl.TabIndex = 5
            ' 
            ' toolboxControl
            ' 
            Me.toolboxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.toolboxControl.Groups.Add(Me.toolboxGroupRoot)
            Me.toolboxControl.Images = Me.imageList
            Me.toolboxControl.Location = New System.Drawing.Point(0, 22)
            Me.toolboxControl.Name = "toolboxControl"
            Me.toolboxControl.OptionsMinimizing.AllowMinimizing = False
            Me.toolboxControl.OptionsView.ColumnCount = 1
            Me.toolboxControl.OptionsView.ShowMenuButton = False
            Me.toolboxControl.OptionsView.ShowSearchPanel = False
            Me.toolboxControl.OptionsView.ShowToolboxCaption = True
            Me.toolboxControl.SelectedGroup = Me.toolboxGroupRoot
            Me.toolboxControl.SelectedGroupIndex = 0
            Me.toolboxControl.ShouldDrawOnlyItems = True
            Me.toolboxControl.Size = New System.Drawing.Size(249, 125)
            Me.toolboxControl.StyleController = Me.layoutControl
            Me.toolboxControl.TabIndex = 4
            AddHandler Me.toolboxControl.DragItemDrop, New DevExpress.XtraToolbox.ToolboxDragItemDropEventHandler(AddressOf Me.OnToolboxDragItemDrop)
            AddHandler Me.toolboxControl.DragItemStart, New DevExpress.XtraToolbox.ToolboxDragItemStartEventHandler(AddressOf Me.OnToolboxDragItemStart)
            AddHandler Me.toolboxControl.DragItemMove, New DevExpress.XtraToolbox.ToolboxDragItemMoveEventHandler(AddressOf Me.OnToolboxDragItemMove)
            AddHandler Me.toolboxControl.DragItemCancel, New DevExpress.XtraToolbox.ToolboxDragItemCancelEventHandler(AddressOf Me.OnToolboxDragItemCancel)
            ' 
            ' toolboxGroupRoot
            ' 
            Me.toolboxGroupRoot.Caption = "ToolboxGroup"
            Me.toolboxGroupRoot.Items.Add(Me.tiSimpleButton)
            Me.toolboxGroupRoot.Items.Add(Me.tiTextEdit)
            Me.toolboxGroupRoot.Items.Add(Me.tiLabel)
            Me.toolboxGroupRoot.Items.Add(Me.tiCheckEdit)
            Me.toolboxGroupRoot.Name = "toolboxGroupRoot"
            Me.toolboxGroupRoot.Visible = False
            ' 
            ' tiSimpleButton
            ' 
            Me.tiSimpleButton.Caption = "Button"
            Me.tiSimpleButton.ImageOptions.ImageIndex = 0
            Me.tiSimpleButton.Name = "tiSimpleButton"
            ' 
            ' tiTextEdit
            ' 
            Me.tiTextEdit.Caption = "TextEdit"
            Me.tiTextEdit.ImageOptions.ImageIndex = 1
            Me.tiTextEdit.Name = "tiTextEdit"
            ' 
            ' tiLabel
            ' 
            Me.tiLabel.Caption = "Label"
            Me.tiLabel.ImageOptions.ImageIndex = 2
            Me.tiLabel.Name = "tiLabel"
            ' 
            ' tiCheckEdit
            ' 
            Me.tiCheckEdit.Caption = "CheckEdit"
            Me.tiCheckEdit.ImageOptions.ImageIndex = 3
            Me.tiCheckEdit.Name = "tiCheckEdit"
            ' 
            ' imageList
            ' 
            Me.imageList.ImageStream = CType((resources.GetObject("imageList.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageList.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList.Images.SetKeyName(0, "SimpleButton.bmp")
            Me.imageList.Images.SetKeyName(1, "TextEdit.bmp")
            Me.imageList.Images.SetKeyName(2, "LabelControl.bmp")
            Me.imageList.Images.SetKeyName(3, "CheckEdit.bmp")
            ' 
            ' lcgRoot
            ' 
            Me.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgRoot.GroupBordersVisible = False
            Me.lcgRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgToolbox, Me.lcgOptions})
            Me.lcgRoot.Name = "lcgRoot"
            Me.lcgRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgRoot.Size = New System.Drawing.Size(249, 586)
            Me.lcgRoot.TextVisible = False
            ' 
            ' lcgToolbox
            ' 
            Me.lcgToolbox.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgToolbox.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liToolbox})
            Me.lcgToolbox.Location = New System.Drawing.Point(0, 0)
            Me.lcgToolbox.Name = "lcgToolbox"
            Me.lcgToolbox.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgToolbox.Size = New System.Drawing.Size(249, 147)
            Me.lcgToolbox.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgToolbox.Text = "Toolbox"
            ' 
            ' liToolbox
            ' 
            Me.liToolbox.Control = Me.toolboxControl
            Me.liToolbox.Location = New System.Drawing.Point(0, 0)
            Me.liToolbox.Name = "liToolbox"
            Me.liToolbox.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.liToolbox.Size = New System.Drawing.Size(249, 125)
            Me.liToolbox.TextVisible = False
            ' 
            ' lcgOptions
            ' 
            Me.lcgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liPropertyGrid, Me.liResetLayout, Me.emptySpaceItem})
            Me.lcgOptions.Location = New System.Drawing.Point(0, 147)
            Me.lcgOptions.Name = "lcgOptions"
            Me.lcgOptions.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgOptions.Size = New System.Drawing.Size(249, 439)
            Me.lcgOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgOptions.Text = "Options"
            ' 
            ' liPropertyGrid
            ' 
            Me.liPropertyGrid.Control = Me.propertyGridControl
            Me.liPropertyGrid.Location = New System.Drawing.Point(0, 0)
            Me.liPropertyGrid.Name = "liPropertyGrid"
            Me.liPropertyGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.liPropertyGrid.Size = New System.Drawing.Size(249, 357)
            Me.liPropertyGrid.TextVisible = False
            ' 
            ' liResetLayout
            ' 
            Me.liResetLayout.Control = Me.btnResetLayout
            Me.liResetLayout.Location = New System.Drawing.Point(0, 357)
            Me.liResetLayout.Name = "liResetLayout"
            Me.liResetLayout.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2)
            Me.liResetLayout.Size = New System.Drawing.Size(249, 26)
            Me.liResetLayout.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 383)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(249, 34)
            ' 
            ' rootPanel
            ' 
            Me.rootPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rootPanel.Controls.Add(Me.contentPanel)
            Me.rootPanel.Controls.Add(Me.topStackPanel)
            Me.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rootPanel.Location = New System.Drawing.Point(0, 0)
            Me.rootPanel.Name = "rootPanel"
            Me.rootPanel.Size = New System.Drawing.Size(693, 586)
            Me.rootPanel.TabIndex = 12
            ' 
            ' topStackPanel
            ' 
            Me.topStackPanel.Controls.Add(Me.labelHint)
            Me.topStackPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.topStackPanel.Location = New System.Drawing.Point(0, 0)
            Me.topStackPanel.Name = "topStackPanel"
            Me.topStackPanel.Size = New System.Drawing.Size(693, 50)
            Me.topStackPanel.TabIndex = 5
            ' 
            ' labelHint
            ' 
            Me.labelHint.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.labelHint.ImageOptions.SvgImage = CType((resources.GetObject("labelHint.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.labelHint.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.labelHint.Location = New System.Drawing.Point(17, 15)
            Me.labelHint.Margin = New System.Windows.Forms.Padding(17, 3, 3, 3)
            Me.labelHint.Name = "labelHint"
            Me.labelHint.Size = New System.Drawing.Size(170, 20)
            Me.labelHint.TabIndex = 0
            Me.labelHint.Text = "Drag controls from the Toolbox"
            ' 
            ' XtraLayoutPanelTutorialControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.rootPanel)
            Me.Controls.Add(Me.sidePanel)
            Me.Name = "XtraLayoutPanelTutorialControl"
            Me.Size = New System.Drawing.Size(943, 586)
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.propertyGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liToolbox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rootPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.rootPanel.ResumeLayout(False)
            CType((Me.topStackPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.topStackPanel.ResumeLayout(False)
            Me.topStackPanel.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private contentPanel As DevExpress.XtraEditors.PanelControl

        Private sidePanel As DevExpress.XtraEditors.SidePanel

        Protected layoutControl As DevExpress.XtraLayout.LayoutControl

        Protected lcgRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private rootPanel As DevExpress.XtraEditors.PanelControl

        Private topStackPanel As DevExpress.Utils.Layout.StackPanel

        Private labelHint As DevExpress.XtraEditors.LabelControl

        Private toolboxControl As DevExpress.XtraToolbox.ToolboxControl

        Private liToolbox As DevExpress.XtraLayout.LayoutControlItem

        Private toolboxGroupRoot As DevExpress.XtraToolbox.ToolboxGroup

        Private tiSimpleButton As DevExpress.XtraToolbox.ToolboxItem

        Private tiTextEdit As DevExpress.XtraToolbox.ToolboxItem

        Private tiLabel As DevExpress.XtraToolbox.ToolboxItem

        Private tiCheckEdit As DevExpress.XtraToolbox.ToolboxItem

        Private imageList As DevExpress.Utils.ImageCollection

        Protected propertyGridControl As DevExpress.XtraVerticalGrid.PropertyGridControl

        Protected liPropertyGrid As DevExpress.XtraLayout.LayoutControlItem

        Protected lcgOptions As DevExpress.XtraLayout.LayoutControlGroup

        Protected lcgToolbox As DevExpress.XtraLayout.LayoutControlGroup

        Private btnResetLayout As DevExpress.XtraEditors.SimpleButton

        Protected liResetLayout As DevExpress.XtraLayout.LayoutControlItem

        Protected emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
