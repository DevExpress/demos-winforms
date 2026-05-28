Namespace DevExpress.XtraGrid.Demos

    Partial Class KanbanBoard

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim simpleContextButton1 As DevExpress.Utils.SimpleContextButton = New DevExpress.Utils.SimpleContextButton()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.KanbanBoard))
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colLabel = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCaption = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colAttachedImage = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colProgress = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.tileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colStatus = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colMembers = New DevExpress.XtraGrid.Columns.TileViewColumn()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colLabel
            ' 
            Me.colLabel.Caption = "Label"
            Me.colLabel.FieldName = "Label"
            Me.colLabel.Name = "colLabel"
            Me.colLabel.Visible = True
            Me.colLabel.VisibleIndex = 3
            ' 
            ' colCaption
            ' 
            Me.colCaption.Caption = "Caption"
            Me.colCaption.FieldName = "Caption"
            Me.colCaption.Name = "colCaption"
            Me.colCaption.Visible = True
            Me.colCaption.VisibleIndex = 1
            ' 
            ' colAttachedImage
            ' 
            Me.colAttachedImage.Caption = "AttachedImage"
            Me.colAttachedImage.FieldName = "AttachedImage"
            Me.colAttachedImage.Name = "colAttachedImage"
            Me.colAttachedImage.Visible = True
            Me.colAttachedImage.VisibleIndex = 6
            ' 
            ' colDescription
            ' 
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 4
            ' 
            ' colProgress
            ' 
            Me.colProgress.Caption = "Progress"
            Me.colProgress.FieldName = "Progress"
            Me.colProgress.Name = "colProgress"
            Me.colProgress.Visible = True
            Me.colProgress.VisibleIndex = 5
            ' 
            ' gridControl
            ' 
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.tileView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(784, 432)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView})
            ' 
            ' tileView
            ' 
            Me.tileView.Appearance.Group.Font = New System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView.Appearance.Group.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((151)))))), (CInt(((CByte((151)))))), (CInt(((CByte((151)))))))
            Me.tileView.Appearance.Group.Options.UseFont = True
            Me.tileView.Appearance.Group.Options.UseForeColor = True
            Me.tileView.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView.Appearance.ItemNormal.Options.UseFont = True
            Me.tileView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStatus, Me.colCaption, Me.colMembers, Me.colLabel, Me.colDescription, Me.colProgress, Me.colAttachedImage})
            Me.tileView.ColumnSet.GroupColumn = Me.colStatus
            Me.tileView.GridControl = Me.gridControl
            Me.tileView.Name = "tileView"
            Me.tileView.OptionsBehavior.AllowSmoothScrolling = True
            Me.tileView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.EditForm
            Me.tileView.OptionsDragDrop.AllowDrag = True
            Me.tileView.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.[Nothing]
            Me.tileView.OptionsEditForm.PopupEditFormWidth = 500
            Me.tileView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[False]
            Me.tileView.OptionsFind.AllowFindPanel = False
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            simpleContextButton1.Id = New System.Guid("cb2e2e03-435e-4146-921e-8679c0fc7372")
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
            simpleContextButton1.Name = "btnAdd"
            simpleContextButton1.ToolTip = "Add a new card"
            simpleContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            Me.tileView.OptionsKanban.GroupHeaderContextButtons.Add(simpleContextButton1)
            Me.tileView.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(0, 12, 0, 12)
            Me.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.Content
            Me.tileView.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.tileView.OptionsTiles.IndentBetweenGroups = 20
            Me.tileView.OptionsTiles.IndentBetweenItems = 5
            Me.tileView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(10)
            Me.tileView.OptionsTiles.ItemSize = New System.Drawing.Size(290, 182)
            Me.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban
            Me.tileView.OptionsTiles.Padding = New System.Windows.Forms.Padding(20, 30, 20, 15)
            Me.tileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            Me.tileView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)})
            tableRowDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableRowDefinition1.Length.Value = 8R
            tableRowDefinition2.AutoHeight = True
            tableRowDefinition2.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableRowDefinition2.Length.Value = 40R
            tableRowDefinition2.PaddingBottom = 10
            tableRowDefinition3.AutoHeight = True
            tableRowDefinition3.Length.Value = 41R
            tableRowDefinition3.PaddingBottom = 10
            tableRowDefinition4.AutoHeight = True
            tableRowDefinition4.Length.Value = 41R
            Me.tileView.TileRows.Add(tableRowDefinition1)
            Me.tileView.TileRows.Add(tableRowDefinition2)
            Me.tileView.TileRows.Add(tableRowDefinition3)
            Me.tileView.TileRows.Add(tableRowDefinition4)
            tileViewItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((128)))))), (CInt(((CByte((128)))))))
            tileViewItemElement1.Appearance.Normal.Options.UseBackColor = True
            tileViewItemElement1.Column = Me.colLabel
            tileViewItemElement1.Height = 4
            tileViewItemElement1.Text = "colLabel"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileViewItemElement1.TextVisible = False
            tileViewItemElement1.Width = 40
            tileViewItemElement2.Column = Me.colCaption
            tileViewItemElement2.RowIndex = 1
            tileViewItemElement2.Text = "colCaption"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileViewItemElement3.Column = Me.colAttachedImage
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.SingleBorder
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
            tileViewItemElement3.RowIndex = 2
            tileViewItemElement3.Text = "colAttachedImage"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.TextVisible = False
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            tileViewItemElement4.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            tileViewItemElement4.Name = "Attachment"
            tileViewItemElement4.RowIndex = 3
            tileViewItemElement4.Text = "Attachment"
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.TextVisible = False
            tileViewItemElement5.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            tileViewItemElement5.AnchorElementIndex = 3
            tileViewItemElement5.AnchorIndent = 0
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement5.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage2")), DevExpress.Utils.Svg.SvgImage)
            tileViewItemElement5.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            tileViewItemElement5.Name = "Description"
            tileViewItemElement5.RowIndex = 3
            tileViewItemElement5.Text = "Description"
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement5.TextVisible = False
            tileViewItemElement6.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            tileViewItemElement6.AnchorElementIndex = 4
            tileViewItemElement6.Appearance.Normal.FontSizeDelta = 1
            tileViewItemElement6.Appearance.Normal.Options.UseFont = True
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            tileViewItemElement6.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage3")), DevExpress.Utils.Svg.SvgImage)
            tileViewItemElement6.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            tileViewItemElement6.Name = "Progress"
            tileViewItemElement6.RowIndex = 3
            tileViewItemElement6.Text = "10/10"
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            Me.tileView.TileTemplate.Add(tileViewItemElement1)
            Me.tileView.TileTemplate.Add(tileViewItemElement2)
            Me.tileView.TileTemplate.Add(tileViewItemElement3)
            Me.tileView.TileTemplate.Add(tileViewItemElement4)
            Me.tileView.TileTemplate.Add(tileViewItemElement5)
            Me.tileView.TileTemplate.Add(tileViewItemElement6)
            AddHandler Me.tileView.ItemCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(AddressOf Me.tileView_ItemCustomize)
            ' 
            ' colStatus
            ' 
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 0
            ' 
            ' colMembers
            ' 
            Me.colMembers.Caption = "Members"
            Me.colMembers.FieldName = "Members"
            Me.colMembers.Name = "colMembers"
            Me.colMembers.Visible = True
            Me.colMembers.VisibleIndex = 2
            ' 
            ' KanbanBoard
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Name = "KanbanBoard"
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl As DevExpress.XtraGrid.GridControl

        Private tileView As DevExpress.XtraGrid.Views.Tile.TileView

        Private colStatus As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colCaption As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colMembers As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colLabel As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colDescription As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colProgress As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colAttachedImage As DevExpress.XtraGrid.Columns.TileViewColumn
    End Class
End Namespace
