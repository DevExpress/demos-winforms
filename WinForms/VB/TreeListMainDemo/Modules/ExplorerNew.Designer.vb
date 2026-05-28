Namespace DevExpress.XtraTreeList.Demos

    Partial Class ExplorerNew

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.ExplorerNew))
            Me.navigationTreeList = New DevExpress.XtraTreeList.TreeList()
            Me.navNameCol = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.breadCrumbEdit = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.backButton = New DevExpress.XtraEditors.SimpleButton()
            Me.forwardButton = New DevExpress.XtraEditors.SimpleButton()
            Me.recentButton = New DevExpress.XtraEditors.CheckButton()
            Me.upButton = New DevExpress.XtraEditors.SimpleButton()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.displayNameCol = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.displayModifiedCol = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.displaySizeCol = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.displayCreateCol = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.displayTypeColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.displayPathColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.breadCrumbItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.searchControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.upButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.recentButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.forwardButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.backButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.breadCrumbEvents1 = New DevExpress.XtraEditors.Behaviors.BreadCrumbEvents(Me.components)
            CType((Me.navigationTreeList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.breadCrumbEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.breadCrumbItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.upButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.recentButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.forwardButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationTreeList
            ' 
            Me.behaviorManager1.SetBehaviors(Me.navigationTreeList, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.XtraEditors.Behaviors.BreadCrumbBehavior.Create(GetType(DevExpress.XtraTreeList.TreeListBreadCrumbSource), Me.breadCrumbEdit, "DisplayName", "Name", Me.breadCrumbEvents1)), DevExpress.Utils.Behaviors.Behavior)})
            Me.navigationTreeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navigationTreeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.navNameCol})
            Me.navigationTreeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationTreeList.Location = New System.Drawing.Point(0, 0)
            Me.navigationTreeList.Name = "navigationTreeList"
            Me.navigationTreeList.OptionsBehavior.Editable = False
            Me.navigationTreeList.OptionsFind.AllowFindPanel = False
            Me.navigationTreeList.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.navigationTreeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.navigationTreeList.OptionsView.ShowColumns = False
            Me.navigationTreeList.OptionsView.ShowHorzLines = False
            Me.navigationTreeList.OptionsView.ShowIndentAsRowStyle = True
            Me.navigationTreeList.OptionsView.ShowIndicator = False
            Me.navigationTreeList.OptionsView.ShowVertLines = False
            Me.navigationTreeList.RowHeight = 22
            Me.navigationTreeList.SelectImageList = Me.svgImageCollection1
            Me.navigationTreeList.Size = New System.Drawing.Size(239, 572)
            Me.navigationTreeList.TabIndex = 1
            ' 
            ' navNameCol
            ' 
            Me.navNameCol.Caption = "DisplayName"
            Me.navNameCol.FieldName = "DisplayName"
            Me.navNameCol.Name = "navNameCol"
            Me.navNameCol.Visible = True
            Me.navNameCol.VisibleIndex = 0
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("electronics_desktopmac", "image://svgimages/icon builder/electronics_desktopmac.svg")
            ' 
            ' breadCrumbEdit
            ' 
            Me.breadCrumbEdit.Location = New System.Drawing.Point(141, 5)
            Me.breadCrumbEdit.Name = "breadCrumbEdit"
            Me.breadCrumbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.breadCrumbEdit.Properties.Images = Me.svgImageCollection1
            Me.breadCrumbEdit.Size = New System.Drawing.Size(710, 20)
            Me.breadCrumbEdit.TabIndex = 0
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.backButton)
            Me.layoutControl1.Controls.Add(Me.forwardButton)
            Me.layoutControl1.Controls.Add(Me.recentButton)
            Me.layoutControl1.Controls.Add(Me.upButton)
            Me.layoutControl1.Controls.Add(Me.searchControl)
            Me.layoutControl1.Controls.Add(Me.breadCrumbEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(814, 217, 650, 400)
            Me.layoutControl1.OptionsView.ShareLookAndFeelWithChildren = False
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(1020, 32)
            Me.layoutControl1.TabIndex = 6
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' backButton
            ' 
            Me.backButton.AllowFocus = False
            Me.backButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.backButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.backButton.ImageOptions.SvgImage = CType((resources.GetObject("backButton.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.backButton.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.backButton.Location = New System.Drawing.Point(7, 3)
            Me.backButton.MinimumSize = New System.Drawing.Size(26, 26)
            Me.backButton.Name = "backButton"
            Me.backButton.Size = New System.Drawing.Size(26, 26)
            Me.backButton.TabIndex = 10
            AddHandler Me.backButton.Click, New System.EventHandler(AddressOf Me.OnBackButtonClick)
            AddHandler Me.backButton.MouseEnter, New System.EventHandler(AddressOf Me.OnMouseEnterButton)
            AddHandler Me.backButton.MouseLeave, New System.EventHandler(AddressOf Me.OnMouseLeaveButton)
            ' 
            ' forwardButton
            ' 
            Me.forwardButton.AllowFocus = False
            Me.forwardButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.forwardButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.forwardButton.ImageOptions.SvgImage = CType((resources.GetObject("forwardButton.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.forwardButton.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.forwardButton.Location = New System.Drawing.Point(41, 3)
            Me.forwardButton.MinimumSize = New System.Drawing.Size(26, 26)
            Me.forwardButton.Name = "forwardButton"
            Me.forwardButton.Size = New System.Drawing.Size(26, 26)
            Me.forwardButton.TabIndex = 11
            AddHandler Me.forwardButton.Click, New System.EventHandler(AddressOf Me.OnForwardButtonClick)
            AddHandler Me.forwardButton.MouseEnter, New System.EventHandler(AddressOf Me.OnMouseEnterButton)
            AddHandler Me.forwardButton.MouseLeave, New System.EventHandler(AddressOf Me.OnMouseLeaveButton)
            ' 
            ' recentButton
            ' 
            Me.recentButton.AllowFocus = False
            Me.recentButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentButton.Enabled = False
            Me.recentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.recentButton.ImageOptions.SvgImage = CType((resources.GetObject("recentButton.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.recentButton.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.recentButton.Location = New System.Drawing.Point(75, 3)
            Me.recentButton.MinimumSize = New System.Drawing.Size(26, 26)
            Me.recentButton.Name = "recentButton"
            Me.recentButton.Size = New System.Drawing.Size(26, 26)
            Me.recentButton.TabIndex = 15
            Me.recentButton.Text = "checkButton1"
            AddHandler Me.recentButton.CheckedChanged, New System.EventHandler(AddressOf Me.OnRecentButtonCheckedChanged)
            AddHandler Me.recentButton.MouseEnter, New System.EventHandler(AddressOf Me.OnMouseEnterButton)
            AddHandler Me.recentButton.MouseLeave, New System.EventHandler(AddressOf Me.OnMouseLeaveButton)
            ' 
            ' upButton
            ' 
            Me.upButton.AllowFocus = False
            Me.upButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.upButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.upButton.ImageOptions.SvgImage = CType((resources.GetObject("upButton.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.upButton.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.upButton.Location = New System.Drawing.Point(109, 3)
            Me.upButton.MinimumSize = New System.Drawing.Size(26, 26)
            Me.upButton.Name = "upButton"
            Me.upButton.Size = New System.Drawing.Size(26, 26)
            Me.upButton.TabIndex = 13
            AddHandler Me.upButton.Click, New System.EventHandler(AddressOf Me.OnUpButtonClick)
            AddHandler Me.upButton.MouseEnter, New System.EventHandler(AddressOf Me.OnMouseEnterButton)
            AddHandler Me.upButton.MouseLeave, New System.EventHandler(AddressOf Me.OnMouseLeaveButton)
            ' 
            ' searchControl
            ' 
            Me.searchControl.Client = Me.treeList1
            Me.searchControl.Location = New System.Drawing.Point(861, 5)
            Me.searchControl.MinimumSize = New System.Drawing.Size(0, 22)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControl.Properties.Client = Me.treeList1
            Me.searchControl.Size = New System.Drawing.Size(154, 22)
            Me.searchControl.TabIndex = 14
            ' 
            ' treeList1
            ' 
            Me.treeList1.AutoFillColumn = Me.displayNameCol
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.displayNameCol, Me.displayModifiedCol, Me.displaySizeCol, Me.displayCreateCol, Me.displayTypeColumn, Me.displayPathColumn})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(240, 33)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsFind.AllowFindPanel = False
            Me.treeList1.OptionsMenu.EnableFooterMenu = False
            Me.treeList1.OptionsMenu.ShowAutoFilterRowItem = False
            Me.treeList1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList1.OptionsView.AutoWidth = False
            Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList1.OptionsView.ShowHorzLines = False
            Me.treeList1.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList1.OptionsView.ShowIndicator = False
            Me.treeList1.OptionsView.ShowVertLines = False
            Me.treeList1.RowHeight = 20
            Me.treeList1.SelectImageList = Me.svgImageCollection1
            Me.treeList1.Size = New System.Drawing.Size(780, 572)
            Me.treeList1.TabIndex = 2
            ' 
            ' displayNameCol
            ' 
            Me.displayNameCol.Caption = "Name"
            Me.displayNameCol.FieldName = "Name"
            Me.displayNameCol.Name = "displayNameCol"
            Me.displayNameCol.Visible = True
            Me.displayNameCol.VisibleIndex = 0
            Me.displayNameCol.Width = 399
            ' 
            ' displayModifiedCol
            ' 
            Me.displayModifiedCol.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.displayModifiedCol.AppearanceCell.Options.UseForeColor = True
            Me.displayModifiedCol.Caption = "Date Modified"
            Me.displayModifiedCol.FieldName = "DateModified"
            Me.displayModifiedCol.Name = "displayModifiedCol"
            Me.displayModifiedCol.Visible = True
            Me.displayModifiedCol.VisibleIndex = 1
            Me.displayModifiedCol.Width = 174
            ' 
            ' displaySizeCol
            ' 
            Me.displaySizeCol.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.displaySizeCol.AppearanceCell.Options.UseForeColor = True
            Me.displaySizeCol.AppearanceCell.Options.UseTextOptions = True
            Me.displaySizeCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.displaySizeCol.Caption = "Size"
            Me.displaySizeCol.FieldName = "Size"
            Me.displaySizeCol.Name = "displaySizeCol"
            Me.displaySizeCol.Visible = True
            Me.displaySizeCol.VisibleIndex = 3
            Me.displaySizeCol.Width = 99
            ' 
            ' displayCreateCol
            ' 
            Me.displayCreateCol.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.displayCreateCol.AppearanceCell.Options.UseForeColor = True
            Me.displayCreateCol.Caption = "Date Created"
            Me.displayCreateCol.FieldName = "DateCreated"
            Me.displayCreateCol.Name = "displayCreateCol"
            Me.displayCreateCol.Width = 135
            ' 
            ' displayTypeColumn
            ' 
            Me.displayTypeColumn.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.displayTypeColumn.AppearanceCell.Options.UseForeColor = True
            Me.displayTypeColumn.Caption = "Type"
            Me.displayTypeColumn.FieldName = "TypeName"
            Me.displayTypeColumn.Name = "displayTypeColumn"
            Me.displayTypeColumn.Visible = True
            Me.displayTypeColumn.VisibleIndex = 2
            Me.displayTypeColumn.Width = 106
            ' 
            ' displayPathColumn
            ' 
            Me.displayPathColumn.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.displayPathColumn.AppearanceCell.Options.UseForeColor = True
            Me.displayPathColumn.Caption = "Path"
            Me.displayPathColumn.FieldName = "FullName"
            Me.displayPathColumn.Name = "displayPathColumn"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.breadCrumbItem, Me.searchControlItem, Me.upButtonItem, Me.recentButtonItem, Me.forwardButtonItem, Me.backButtonItem})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.Root.Size = New System.Drawing.Size(1020, 32)
            Me.Root.TextVisible = False
            ' 
            ' breadCrumbItem
            ' 
            Me.breadCrumbItem.Control = Me.breadCrumbEdit
            Me.breadCrumbItem.Location = New System.Drawing.Point(136, 0)
            Me.breadCrumbItem.MaxSize = New System.Drawing.Size(0, 26)
            Me.breadCrumbItem.MinSize = New System.Drawing.Size(54, 26)
            Me.breadCrumbItem.Name = "breadCrumbItem"
            Me.breadCrumbItem.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 5, 2, 2)
            Me.breadCrumbItem.Size = New System.Drawing.Size(717, 26)
            Me.breadCrumbItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.breadCrumbItem.TextVisible = False
            ' 
            ' searchControlItem
            ' 
            Me.searchControlItem.Control = Me.searchControl
            Me.searchControlItem.Location = New System.Drawing.Point(853, 0)
            Me.searchControlItem.MaxSize = New System.Drawing.Size(161, 26)
            Me.searchControlItem.MinSize = New System.Drawing.Size(161, 26)
            Me.searchControlItem.Name = "searchControlItem"
            Me.searchControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2)
            Me.searchControlItem.Size = New System.Drawing.Size(161, 26)
            Me.searchControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.searchControlItem.TextVisible = False
            ' 
            ' upButtonItem
            ' 
            Me.upButtonItem.Control = Me.upButton
            Me.upButtonItem.Location = New System.Drawing.Point(102, 0)
            Me.upButtonItem.MaxSize = New System.Drawing.Size(34, 26)
            Me.upButtonItem.MinSize = New System.Drawing.Size(34, 26)
            Me.upButtonItem.Name = "upButtonItem"
            Me.upButtonItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 0, 0)
            Me.upButtonItem.Size = New System.Drawing.Size(34, 26)
            Me.upButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.upButtonItem.TextVisible = False
            ' 
            ' recentButtonItem
            ' 
            Me.recentButtonItem.Control = Me.recentButton
            Me.recentButtonItem.Location = New System.Drawing.Point(68, 0)
            Me.recentButtonItem.MaxSize = New System.Drawing.Size(34, 26)
            Me.recentButtonItem.MinSize = New System.Drawing.Size(34, 26)
            Me.recentButtonItem.Name = "recentButtonItem"
            Me.recentButtonItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 0, 0)
            Me.recentButtonItem.Size = New System.Drawing.Size(34, 26)
            Me.recentButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.recentButtonItem.TextVisible = False
            ' 
            ' forwardButtonItem
            ' 
            Me.forwardButtonItem.Control = Me.forwardButton
            Me.forwardButtonItem.Location = New System.Drawing.Point(34, 0)
            Me.forwardButtonItem.MaxSize = New System.Drawing.Size(34, 26)
            Me.forwardButtonItem.MinSize = New System.Drawing.Size(34, 26)
            Me.forwardButtonItem.Name = "forwardButtonItem"
            Me.forwardButtonItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 0, 0)
            Me.forwardButtonItem.Size = New System.Drawing.Size(34, 26)
            Me.forwardButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.forwardButtonItem.TextVisible = False
            ' 
            ' backButtonItem
            ' 
            Me.backButtonItem.Control = Me.backButton
            Me.backButtonItem.Location = New System.Drawing.Point(0, 0)
            Me.backButtonItem.MaxSize = New System.Drawing.Size(34, 26)
            Me.backButtonItem.MinSize = New System.Drawing.Size(34, 26)
            Me.backButtonItem.Name = "backButtonItem"
            Me.backButtonItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 0, 0)
            Me.backButtonItem.Size = New System.Drawing.Size(34, 26)
            Me.backButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.backButtonItem.TextVisible = False
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.navigationTreeList)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel2.Location = New System.Drawing.Point(0, 33)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(240, 572)
            Me.sidePanel2.TabIndex = 4
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.layoutControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(1020, 33)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' ExplorerNew
            ' 
            Me.Appearance.Options.UseBackColor = True
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.sidePanel2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ExplorerNew"
            Me.Size = New System.Drawing.Size(1020, 605)
            CType((Me.navigationTreeList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.breadCrumbEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.breadCrumbItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.upButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.recentButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.forwardButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private breadCrumbEdit As DevExpress.XtraEditors.BreadCrumbEdit

        Private navigationTreeList As DevExpress.XtraTreeList.TreeList

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private navNameCol As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private displayNameCol As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private displayModifiedCol As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private displaySizeCol As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private displayCreateCol As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private breadCrumbEvents1 As DevExpress.XtraEditors.Behaviors.BreadCrumbEvents

        Private upButton As DevExpress.XtraEditors.SimpleButton

        Private forwardButton As DevExpress.XtraEditors.SimpleButton

        Private backButton As DevExpress.XtraEditors.SimpleButton

        Private searchControl As DevExpress.XtraEditors.SearchControl

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private displayTypeColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private displayPathColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private recentButton As DevExpress.XtraEditors.CheckButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private breadCrumbItem As DevExpress.XtraLayout.LayoutControlItem

        Private searchControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private upButtonItem As DevExpress.XtraLayout.LayoutControlItem

        Private recentButtonItem As DevExpress.XtraLayout.LayoutControlItem

        Private forwardButtonItem As DevExpress.XtraLayout.LayoutControlItem

        Private backButtonItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
