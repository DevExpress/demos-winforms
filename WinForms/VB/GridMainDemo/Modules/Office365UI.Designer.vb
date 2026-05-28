Namespace DevExpress.XtraGrid.Demos

    Partial Class Office365UI

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.Office365UI))
            Dim contextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton3 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton4 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim itemTemplate1 As DevExpress.XtraGrid.Views.Tile.ItemTemplate = New DevExpress.XtraGrid.Views.Tile.ItemTemplate()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition5 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition6 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition7 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan4 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan5 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan6 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSubjectDisplayText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colRead = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPlainText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.office365MailViewer = New DevExpress.XtraGrid.Demos.Office365MailViewer()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.toggleAutoHeight = New DevExpress.XtraEditors.ToggleSwitch()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.bcFilterAll = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterUnread = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterImportance = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterToday = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterYesterday = New DevExpress.XtraBars.BarCheckItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.biSortDate = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortFrom = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortRead = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortSubject = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortImportance = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
            Me.labelControl1 = New DevExpress.XtraEditors.DropDownButton()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.panel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.toggleAutoHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colDate
            ' 
            Me.colDate.Caption = "colDate"
            Me.colDate.FieldName = "Date"
            Me.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 0
            ' 
            ' colSubjectDisplayText
            ' 
            Me.colSubjectDisplayText.Caption = "colSubjectDisplayText"
            Me.colSubjectDisplayText.FieldName = "SubjectDisplayText"
            Me.colSubjectDisplayText.Name = "colSubjectDisplayText"
            Me.colSubjectDisplayText.Visible = True
            Me.colSubjectDisplayText.VisibleIndex = 4
            ' 
            ' colFrom
            ' 
            Me.colFrom.Caption = "colFrom"
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            Me.colFrom.Visible = True
            Me.colFrom.VisibleIndex = 1
            ' 
            ' colRead
            ' 
            Me.colRead.Caption = "colRead"
            Me.colRead.FieldName = "Read"
            Me.colRead.Name = "colRead"
            Me.colRead.Visible = True
            Me.colRead.VisibleIndex = 5
            ' 
            ' colPlainText
            ' 
            Me.colPlainText.Caption = "colPlainText"
            Me.colPlainText.FieldName = "PlainText"
            Me.colPlainText.Name = "colPlainText"
            Me.colPlainText.Visible = True
            Me.colPlainText.VisibleIndex = 3
            ' 
            ' colPriority
            ' 
            Me.colPriority.Caption = "colPriority"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 6
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            ' 
            ' office365MailViewer
            ' 
            Me.office365MailViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.office365MailViewer.Location = New System.Drawing.Point(1, 0)
            Me.office365MailViewer.Name = "office365MailViewer"
            Me.office365MailViewer.Size = New System.Drawing.Size(445, 432)
            Me.office365MailViewer.TabIndex = 4
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 45)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(338, 387)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView1})
            ' 
            ' tileView1
            ' 
            Me.tileView1.Appearance.Group.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView1.Appearance.Group.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((124)))))), (CInt(((CByte((50)))))))
            Me.tileView1.Appearance.Group.Options.UseFont = True
            Me.tileView1.Appearance.Group.Options.UseForeColor = True
            Me.tileView1.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView1.Appearance.ItemNormal.Options.UseFont = True
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colFrom, Me.colSubject, Me.colPlainText, Me.colSubjectDisplayText, Me.colRead, Me.colPriority})
            Me.tileView1.ColumnSet.GroupColumn = Me.colDate
            Me.tileView1.ContextButtonOptions.Indent = 6
            Me.tileView1.ContextButtonOptions.TopPanelPadding = New System.Windows.Forms.Padding(5, 10, 12, 5)
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton1.Id = New System.Guid("46c5197d-a771-45bb-9de8-afed5491a3c5")
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            contextButton1.Name = "cbExclamation"
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton2.Id = New System.Guid("b5ddbc13-0cf7-4468-afe5-8d6d6df06d77")
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            contextButton2.Name = "cbEdit"
            contextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton3.Id = New System.Guid("07c1aaac-55bd-4ebc-b850-93a79dede0db")
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage2")), DevExpress.Utils.Svg.SvgImage)
            contextButton3.Name = "cbRemove"
            contextButton4.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton4.Id = New System.Guid("83ef3e55-2c44-470e-acca-c4d796b1ecbd")
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage3")), DevExpress.Utils.Svg.SvgImage)
            contextButton4.Name = "cbShow"
            Me.tileView1.ContextButtons.Add(contextButton1)
            Me.tileView1.ContextButtons.Add(contextButton2)
            Me.tileView1.ContextButtons.Add(contextButton3)
            Me.tileView1.ContextButtons.Add(contextButton4)
            Me.tileView1.FocusBorderColor = System.Drawing.Color.Transparent
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsBehavior.AllowSmoothScrolling = True
            Me.tileView1.OptionsTiles.AllowItemHover = True
            Me.tileView1.OptionsTiles.AllowPressAnimation = False
            Me.tileView1.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(30, 10, 0, 10)
            Me.tileView1.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tileView1.OptionsTiles.IndentBetweenGroups = 0
            Me.tileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0, 8, 12, 8)
            Me.tileView1.OptionsTiles.ItemSize = New System.Drawing.Size(560, 80)
            Me.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar
            Me.tileView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 28R
            tableColumnDefinition2.Length.Value = 214R
            itemTemplate1.Columns.Add(tableColumnDefinition1)
            itemTemplate1.Columns.Add(tableColumnDefinition2)
            tileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement1.Appearance.Normal.Options.UseFont = True
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement1.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement1.Column = Me.colDate
            tileViewItemElement1.ColumnIndex = 1
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.RowIndex = 2
            tileViewItemElement1.Text = "colDate"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement2.Appearance.Normal.Options.UseFont = True
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement2.Column = Me.colSubjectDisplayText
            tileViewItemElement2.ColumnIndex = 1
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.RowIndex = 1
            tileViewItemElement2.Text = "colSubjectDisplayText"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement3.Appearance.Normal.Options.UseFont = True
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement3.Column = Me.colFrom
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.Text = "colFrom"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.Column = Me.colRead
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement4.Name = "readElement"
            tileViewItemElement4.RowIndex = 1
            tileViewItemElement4.StretchVertical = True
            tileViewItemElement4.Text = "colRead"
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.TextVisible = False
            tileViewItemElement4.Width = 3
            itemTemplate1.Elements.Add(tileViewItemElement1)
            itemTemplate1.Elements.Add(tileViewItemElement2)
            itemTemplate1.Elements.Add(tileViewItemElement3)
            itemTemplate1.Elements.Add(tileViewItemElement4)
            itemTemplate1.Name = "smallsize"
            itemTemplate1.Rows.Add(tableRowDefinition1)
            itemTemplate1.Rows.Add(tableRowDefinition2)
            itemTemplate1.Rows.Add(tableRowDefinition3)
            tableSpan1.RowSpan = 3
            itemTemplate1.Spans.Add(tableSpan1)
            Me.tileView1.Templates.Add(itemTemplate1)
            tableColumnDefinition3.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition3.Length.Value = 28R
            tableColumnDefinition4.Length.Value = 214R
            tableColumnDefinition5.Length.Value = 171R
            tableColumnDefinition6.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition6.Length.Value = 45R
            tableColumnDefinition7.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition7.Length.Value = 45R
            Me.tileView1.TileColumns.Add(tableColumnDefinition3)
            Me.tileView1.TileColumns.Add(tableColumnDefinition4)
            Me.tileView1.TileColumns.Add(tableColumnDefinition5)
            Me.tileView1.TileColumns.Add(tableColumnDefinition6)
            Me.tileView1.TileColumns.Add(tableColumnDefinition7)
            tableRowDefinition4.AutoHeight = True
            tableRowDefinition5.AutoHeight = True
            tableRowDefinition6.AutoHeight = True
            Me.tileView1.TileRows.Add(tableRowDefinition4)
            Me.tileView1.TileRows.Add(tableRowDefinition5)
            Me.tileView1.TileRows.Add(tableRowDefinition6)
            tableSpan2.ColumnIndex = 1
            tableSpan2.ColumnSpan = 2
            tableSpan2.RowIndex = 1
            tableSpan3.ColumnIndex = 1
            tableSpan3.ColumnSpan = 3
            tableSpan4.RowSpan = 3
            tableSpan5.ColumnIndex = 1
            tableSpan5.ColumnSpan = 3
            tableSpan5.RowIndex = 2
            tableSpan6.ColumnIndex = 3
            tableSpan6.ColumnSpan = 2
            tableSpan6.RowIndex = 1
            Me.tileView1.TileSpans.Add(tableSpan2)
            Me.tileView1.TileSpans.Add(tableSpan3)
            Me.tileView1.TileSpans.Add(tableSpan4)
            Me.tileView1.TileSpans.Add(tableSpan5)
            Me.tileView1.TileSpans.Add(tableSpan6)
            tileViewItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement5.Appearance.Normal.Options.UseFont = True
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement5.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement5.Column = Me.colDate
            tileViewItemElement5.ColumnIndex = 4
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement5.RowIndex = 1
            tileViewItemElement5.Text = "colDate"
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement6.Appearance.Normal.Options.UseFont = True
            tileViewItemElement6.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement6.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement6.Column = Me.colSubjectDisplayText
            tileViewItemElement6.ColumnIndex = 1
            tileViewItemElement6.RowIndex = 1
            tileViewItemElement6.Text = "colSubjectDisplayText"
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement7.Appearance.Normal.Options.UseFont = True
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement7.Column = Me.colPlainText
            tileViewItemElement7.ColumnIndex = 1
            tileViewItemElement7.MaxLineCount = 6
            tileViewItemElement7.Name = "PlainText"
            tileViewItemElement7.RowIndex = 2
            tileViewItemElement7.Text = "colPlainText"
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement8.Appearance.Normal.Options.UseFont = True
            tileViewItemElement8.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement8.Column = Me.colFrom
            tileViewItemElement8.ColumnIndex = 2
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement8.Text = "colFrom"
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement9.Column = Me.colRead
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement9.Name = "readElement"
            tileViewItemElement9.RowIndex = 1
            tileViewItemElement9.StretchVertical = True
            tileViewItemElement9.Text = "colRead"
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement9.TextVisible = False
            tileViewItemElement9.Width = 3
            Me.tileView1.TileTemplate.Add(tileViewItemElement5)
            Me.tileView1.TileTemplate.Add(tileViewItemElement6)
            Me.tileView1.TileTemplate.Add(tileViewItemElement7)
            Me.tileView1.TileTemplate.Add(tileViewItemElement8)
            Me.tileView1.TileTemplate.Add(tileViewItemElement9)
            AddHandler Me.tileView1.ContextButtonCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewContextButtonCustomizeEventHandler(AddressOf Me.tileView1_ContextButtonCustomize)
            AddHandler Me.tileView1.ItemCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(AddressOf Me.tileView1_ItemCustomize)
            AddHandler Me.tileView1.CustomItemTemplate, New DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(AddressOf Me.tileView1_CustomItemTemplate)
            AddHandler Me.tileView1.FocusedRowChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(AddressOf Me.tileView1_FocusedRowChanged)
            ' 
            ' colSubject
            ' 
            Me.colSubject.Caption = "colSubject"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 2
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.office365MailViewer)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(338, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(280, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(446, 432)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' panel1
            ' 
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.toggleAutoHeight)
            Me.panel1.Controls.Add(Me.labelControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(28, 0, 26, 0)
            Me.panel1.Size = New System.Drawing.Size(338, 45)
            Me.panel1.TabIndex = 6
            ' 
            ' toggleAutoHeight
            ' 
            Me.toggleAutoHeight.Dock = System.Windows.Forms.DockStyle.Right
            Me.toggleAutoHeight.EditValue = True
            Me.toggleAutoHeight.Location = New System.Drawing.Point(176, 0)
            Me.toggleAutoHeight.MenuManager = Me.barManager1
            Me.toggleAutoHeight.Name = "toggleAutoHeight"
            Me.toggleAutoHeight.Properties.AllowFocused = False
            Me.toggleAutoHeight.Properties.AutoWidth = True
            Me.toggleAutoHeight.Properties.OffText = "Item Auto-Height"
            Me.toggleAutoHeight.Properties.OnText = "Item Auto-Height"
            Me.toggleAutoHeight.Size = New System.Drawing.Size(136, 45)
            Me.toggleAutoHeight.TabIndex = 2
            AddHandler Me.toggleAutoHeight.Toggled, New System.EventHandler(AddressOf Me.toggleAutoHeight_Toggled)
            ' 
            ' barManager1
            ' 
            Me.barManager1.AllowGlyphSkinning = True
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection2
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.bcFilterAll, Me.bcFilterUnread, Me.bcFilterImportance, Me.bcFilterToday, Me.bcFilterYesterday, Me.barSubItem1, Me.biSortDate, Me.biSortFrom, Me.biSortRead, Me.barSubItem2, Me.biSortSubject, Me.biSortImportance})
            Me.barManager1.MaxItemId = 13
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(784, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 432)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(784, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 432)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(784, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 432)
            ' 
            ' imageCollection2
            ' 
            Me.imageCollection2.ImageStream = CType((resources.GetObject("imageCollection2.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection2.InsertGalleryImage("sortdesc_16x16.png", "grayscaleimages/data/sortdesc_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("grayscaleimages/data/sortdesc_16x16.png"), 0)
            Me.imageCollection2.Images.SetKeyName(0, "sortdesc_16x16.png")
            Me.imageCollection2.InsertGalleryImage("sortasc_16x16.png", "grayscaleimages/data/sortasc_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("grayscaleimages/data/sortasc_16x16.png"), 1)
            Me.imageCollection2.Images.SetKeyName(1, "sortasc_16x16.png")
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' bcFilterAll
            ' 
            Me.bcFilterAll.BindableChecked = True
            Me.bcFilterAll.Caption = "All"
            Me.bcFilterAll.Checked = True
            Me.bcFilterAll.GroupIndex = 22
            Me.bcFilterAll.Id = 1
            Me.bcFilterAll.Name = "bcFilterAll"
            AddHandler Me.bcFilterAll.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterItemCheckedChanged)
            ' 
            ' bcFilterUnread
            ' 
            Me.bcFilterUnread.Caption = "Unread"
            Me.bcFilterUnread.GroupIndex = 22
            Me.bcFilterUnread.Id = 2
            Me.bcFilterUnread.Name = "bcFilterUnread"
            AddHandler Me.bcFilterUnread.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterItemCheckedChanged)
            ' 
            ' bcFilterImportance
            ' 
            Me.bcFilterImportance.Caption = "Important"
            Me.bcFilterImportance.GroupIndex = 22
            Me.bcFilterImportance.Id = 3
            Me.bcFilterImportance.Name = "bcFilterImportance"
            AddHandler Me.bcFilterImportance.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterItemCheckedChanged)
            ' 
            ' bcFilterToday
            ' 
            Me.bcFilterToday.Caption = "Today"
            Me.bcFilterToday.GroupIndex = 22
            Me.bcFilterToday.Id = 4
            Me.bcFilterToday.Name = "bcFilterToday"
            AddHandler Me.bcFilterToday.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterItemCheckedChanged)
            ' 
            ' bcFilterYesterday
            ' 
            Me.bcFilterYesterday.Caption = "Yesterday"
            Me.bcFilterYesterday.GroupIndex = 22
            Me.bcFilterYesterday.Id = 5
            Me.bcFilterYesterday.Name = "bcFilterYesterday"
            AddHandler Me.bcFilterYesterday.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterItemCheckedChanged)
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Sort By"
            Me.barSubItem1.Id = 6
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biSortDate), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortFrom), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortRead), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortSubject), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortImportance)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' biSortDate
            ' 
            Me.biSortDate.Caption = "Date"
            Me.biSortDate.Id = 7
            Me.biSortDate.Name = "biSortDate"
            AddHandler Me.biSortDate.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSortItemClick)
            ' 
            ' biSortFrom
            ' 
            Me.biSortFrom.Caption = "From"
            Me.biSortFrom.Id = 8
            Me.biSortFrom.Name = "biSortFrom"
            AddHandler Me.biSortFrom.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSortItemClick)
            ' 
            ' biSortRead
            ' 
            Me.biSortRead.Caption = "To"
            Me.biSortRead.Id = 9
            Me.biSortRead.Name = "biSortRead"
            AddHandler Me.biSortRead.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSortItemClick)
            ' 
            ' biSortSubject
            ' 
            Me.biSortSubject.Caption = "Subject"
            Me.biSortSubject.Id = 11
            Me.biSortSubject.Name = "biSortSubject"
            AddHandler Me.biSortSubject.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSortItemClick)
            ' 
            ' biSortImportance
            ' 
            Me.biSortImportance.Caption = "Importance"
            Me.biSortImportance.Id = 12
            Me.biSortImportance.Name = "biSortImportance"
            AddHandler Me.biSortImportance.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSortItemClick)
            ' 
            ' barSubItem2
            ' 
            Me.barSubItem2.Caption = "Show As"
            Me.barSubItem2.Id = 10
            Me.barSubItem2.Name = "barSubItem2"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowFocus = False
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.AppearanceHovered.Options.UseFont = True
            Me.labelControl1.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.AppearancePressed.Options.UseFont = True
            Me.labelControl1.AutoSize = True
            Me.labelControl1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.labelControl1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            Me.labelControl1.DropDownControl = Me.popupMenu1
            Me.labelControl1.Location = New System.Drawing.Point(28, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(58, 45)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Filter"
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterAll), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterUnread), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterImportance), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterToday), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.MenuCaption = "Filter"
            Me.popupMenu1.Name = "popupMenu1"
            Me.popupMenu1.ShowCaption = True
            ' 
            ' Office365UI
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Office365UI"
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.panel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType((Me.toggleAutoHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private office365MailViewer As DevExpress.XtraGrid.Demos.Office365MailViewer

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView

        Private colDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colFrom As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubject As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPlainText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubjectDisplayText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colRead As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPriority As DevExpress.XtraGrid.Columns.TileViewColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private panel1 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.DropDownButton

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private bcFilterAll As DevExpress.XtraBars.BarCheckItem

        Private bcFilterUnread As DevExpress.XtraBars.BarCheckItem

        Private bcFilterImportance As DevExpress.XtraBars.BarCheckItem

        Private bcFilterToday As DevExpress.XtraBars.BarCheckItem

        Private bcFilterYesterday As DevExpress.XtraBars.BarCheckItem

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private biSortDate As DevExpress.XtraBars.BarButtonItem

        Private biSortFrom As DevExpress.XtraBars.BarButtonItem

        Private biSortRead As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barSubItem2 As DevExpress.XtraBars.BarSubItem

        Private biSortSubject As DevExpress.XtraBars.BarButtonItem

        Private biSortImportance As DevExpress.XtraBars.BarButtonItem

        Private imageCollection2 As DevExpress.Utils.ImageCollection

        Private toggleAutoHeight As DevExpress.XtraEditors.ToggleSwitch
    End Class
End Namespace
