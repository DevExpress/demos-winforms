Namespace DevExpress.XtraGrid.Demos

    Partial Class KanbanEditControl

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
            Dim tileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.KanbanEditControl))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridChecklist = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colTaskId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCaption = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChecked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.memberTiles = New DevExpress.XtraEditors.TileControl()
            Me.tileGroup = New DevExpress.XtraEditors.TileGroup()
            Me.addMemberItem = New DevExpress.XtraEditors.TileItem()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridChecklist), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.SetBoundPropertyName(Me.layoutControl1, "")
            Me.layoutControl1.Controls.Add(Me.progressBarControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.memberTiles)
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1162, 193, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(500, 464)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' progressBarControl1
            ' 
            Me.SetBoundPropertyName(Me.progressBarControl1, "")
            Me.progressBarControl1.Location = New System.Drawing.Point(12, 351)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Properties.ShowTitle = True
            Me.progressBarControl1.Size = New System.Drawing.Size(476, 16)
            Me.progressBarControl1.StyleController = Me.layoutControl1
            Me.progressBarControl1.TabIndex = 9
            ' 
            ' gridControl1
            ' 
            Me.SetBoundPropertyName(Me.gridControl1, "")
            Me.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.First.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.[Next].Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
            Me.gridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
            Me.gridControl1.Location = New System.Drawing.Point(12, 206)
            Me.gridControl1.MainView = Me.gridChecklist
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemCheckEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(476, 141)
            Me.gridControl1.TabIndex = 8
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridChecklist})
            ' 
            ' gridChecklist
            ' 
            Me.gridChecklist.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTaskId, Me.colCaption, Me.colChecked})
            Me.gridChecklist.GridControl = Me.gridControl1
            Me.gridChecklist.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
            Me.gridChecklist.Name = "gridChecklist"
            Me.gridChecklist.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridChecklist.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.gridChecklist.OptionsView.ShowColumnHeaders = False
            Me.gridChecklist.OptionsView.ShowGroupPanel = False
            Me.gridChecklist.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridChecklist.OptionsView.ShowIndicator = False
            Me.gridChecklist.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridChecklist.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
            AddHandler Me.gridChecklist.InitNewRow, New DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(AddressOf Me.gridView1_InitNewRow)
            AddHandler Me.gridChecklist.CustomRowFilter, New DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(AddressOf Me.gridView1_CustomRowFilter)
            ' 
            ' colTaskId
            ' 
            Me.colTaskId.Caption = "gridColumn1"
            Me.colTaskId.FieldName = "TaskID"
            Me.colTaskId.Name = "colTaskId"
            ' 
            ' colCaption
            ' 
            Me.colCaption.Caption = "gridColumn1"
            Me.colCaption.FieldName = "Caption"
            Me.colCaption.Name = "colCaption"
            Me.colCaption.Visible = True
            Me.colCaption.VisibleIndex = 1
            Me.colCaption.Width = 442
            ' 
            ' colChecked
            ' 
            Me.colChecked.Caption = "gridColumn1"
            Me.colChecked.ColumnEdit = Me.repositoryItemCheckEdit1
            Me.colChecked.FieldName = "Checked"
            Me.colChecked.Name = "colChecked"
            Me.colChecked.OptionsColumn.FixedWidth = True
            Me.colChecked.Visible = True
            Me.colChecked.VisibleIndex = 0
            Me.colChecked.Width = 32
            ' 
            ' repositoryItemCheckEdit1
            ' 
            Me.repositoryItemCheckEdit1.AutoHeight = False
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            AddHandler Me.repositoryItemCheckEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.repositoryItemCheckEdit1_CheckedChanged)
            ' 
            ' memberTiles
            ' 
            Me.memberTiles.AllowDrag = False
            Me.memberTiles.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
            Me.memberTiles.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent
            Me.memberTiles.AppearanceItem.Normal.Options.UseBackColor = True
            Me.memberTiles.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.SetBoundPropertyName(Me.memberTiles, "")
            Me.memberTiles.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.memberTiles.Groups.Add(Me.tileGroup)
            Me.memberTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.memberTiles.IndentBetweenItems = 3
            Me.memberTiles.ItemSize = 30
            Me.memberTiles.Location = New System.Drawing.Point(12, 377)
            Me.memberTiles.MaxId = 1
            Me.memberTiles.Name = "memberTiles"
            Me.memberTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.memberTiles.RowCount = 1
            Me.memberTiles.Size = New System.Drawing.Size(476, 75)
            Me.memberTiles.TabIndex = 7
            Me.memberTiles.Text = "tileControl1"
            Me.memberTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            ' 
            ' tileGroup
            ' 
            Me.tileGroup.Items.Add(Me.addMemberItem)
            Me.tileGroup.Name = "tileGroup"
            ' 
            ' addMemberItem
            ' 
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement1.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            tileItemElement1.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            tileItemElement1.Text = ""
            Me.addMemberItem.Elements.Add(tileItemElement1)
            Me.addMemberItem.Id = 0
            Me.addMemberItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.addMemberItem.Name = "addMemberItem"
            AddHandler Me.addMemberItem.ItemClick, New DevExpress.XtraEditors.TileItemClickEventHandler(AddressOf Me.addMemberItem_ItemClick)
            ' 
            ' comboBoxEdit1
            ' 
            Me.SetBoundFieldName(Me.comboBoxEdit1, "Label")
            Me.SetBoundPropertyName(Me.comboBoxEdit1, "EditValue")
            Me.comboBoxEdit1.Location = New System.Drawing.Point(12, 66)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(476, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl1
            Me.comboBoxEdit1.TabIndex = 6
            ' 
            ' memoEdit1
            ' 
            Me.SetBoundFieldName(Me.memoEdit1, "Description")
            Me.SetBoundPropertyName(Me.memoEdit1, "EditValue")
            Me.memoEdit1.Location = New System.Drawing.Point(12, 112)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(476, 68)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 5
            ' 
            ' textEdit1
            ' 
            Me.SetBoundFieldName(Me.textEdit1, "Caption")
            Me.SetBoundPropertyName(Me.textEdit1, "EditValue")
            Me.textEdit1.Location = New System.Drawing.Point(12, 20)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(476, 20)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gray
            Me.layoutControlGroup1.AppearanceItemCaption.Options.UseForeColor = True
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 10)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(500, 464)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(480, 46)
            Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem1.Text = "Title"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.memoEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(0, 94)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(57, 94)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(480, 94)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem2.Text = "Description"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.comboBoxEdit1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(480, 46)
            Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem3.Text = "Label"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.memberTiles
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 373)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(0, 79)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(104, 79)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(480, 79)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.Text = "Members"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.gridControl1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 186)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(480, 161)
            Me.layoutControlItem5.Text = "Checklist"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.progressBarControl1
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 347)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(480, 26)
            Me.layoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' KanbanEditControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "KanbanEditControl"
            Me.Size = New System.Drawing.Size(500, 464)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridChecklist), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private memberTiles As DevExpress.XtraEditors.TileControl

        Private tileGroup As DevExpress.XtraEditors.TileGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private addMemberItem As DevExpress.XtraEditors.TileItem

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridChecklist As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private colTaskId As DevExpress.XtraGrid.Columns.GridColumn

        Private colCaption As DevExpress.XtraGrid.Columns.GridColumn

        Private colChecked As DevExpress.XtraGrid.Columns.GridColumn

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    End Class
End Namespace
