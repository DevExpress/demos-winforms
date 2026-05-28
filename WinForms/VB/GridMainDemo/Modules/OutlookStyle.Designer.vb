Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class OutlookStyle

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.OutlookStyle))
            Dim alertButton1 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton2 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton3 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.svgImageCollection2 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.biOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biRead = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.bcLow = New DevExpress.XtraBars.BarCheckItem()
            Me.bcMedium = New DevExpress.XtraBars.BarCheckItem()
            Me.bcHigh = New DevExpress.XtraBars.BarCheckItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.ucMailViewer1 = New DevExpress.XtraGrid.Demos.ucMailViewer()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Demos.PreviewGridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.svgImageColumns = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageColumns), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.gridColumn2.FieldName = "Read"
            Me.gridColumn2.ImageOptions.Alignment = CType((resources.GetObject("gridColumn2.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.gridColumn2.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn2.ImageOptions.ImageIndex"))))
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowEdit = False
            Me.gridColumn2.OptionsColumn.AllowFocus = False
            Me.gridColumn2.OptionsColumn.AllowSize = False
            Me.gridColumn2.OptionsColumn.FixedWidth = True
            Me.gridColumn2.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items5")))))})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.svgImageCollection1
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("system.Drawing.Bitmap", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_1", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_2", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_2")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_3", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_3")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_4", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_4")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_5", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_5")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_7", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_7")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' alertControl1
            ' 
            alertButton1.Hint = "Mark as Read"
            alertButton1.ImageOptions.ImageDownIndex = 1
            alertButton1.ImageOptions.ImageIndex =(CInt((resources.GetObject("resource.ImageIndex"))))
            alertButton1.Name = "Read"
            alertButton1.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton
            alertButton2.Hint = "Open Attachment"
            alertButton2.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            alertButton2.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            alertButton2.Name = "Attachment"
            alertButton3.Hint = "Delete Item"
            alertButton3.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            alertButton3.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            alertButton3.Name = "Delete"
            Me.alertControl1.Buttons.Add(alertButton1)
            Me.alertControl1.Buttons.Add(alertButton2)
            Me.alertControl1.Buttons.Add(alertButton3)
            Me.alertControl1.Images = Me.svgImageCollection2
            Me.alertControl1.PopupMenu = Me.popupMenu1
            AddHandler Me.alertControl1.AlertClick, New DevExpress.XtraBars.Alerter.AlertClickEventHandler(AddressOf Me.alertControl1_AlertClick)
            AddHandler Me.alertControl1.ButtonClick, New DevExpress.XtraBars.Alerter.AlertButtonClickEventHandler(AddressOf Me.alertControl1_ButtonClick)
            AddHandler Me.alertControl1.ButtonDownChanged, New DevExpress.XtraBars.Alerter.AlertButtonDownChangedEventHandler(AddressOf Me.alertControl1_ButtonDownChanged)
            ' 
            ' svgImageCollection2
            ' 
            Me.svgImageCollection2.Add("Icon", CType((resources.GetObject("svgImageCollection2.Icon")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("system.Drawing.Bitmap_2", CType((resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_2")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("system.Drawing.Bitmap_3", CType((resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_3")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("system.Drawing.Bitmap_4", CType((resources.GetObject("svgImageCollection2.system.Drawing.Bitmap_4")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.biDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.biRead), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1, True)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            AddHandler Me.popupMenu1.BeforePopup, New System.ComponentModel.CancelEventHandler(AddressOf Me.popupMenu1_BeforePopup)
            ' 
            ' biOpen
            ' 
            resources.ApplyResources(Me.biOpen, "biOpen")
            Me.biOpen.Id = 4
            Me.biOpen.Name = "biOpen"
            AddHandler Me.biOpen.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biOpen_ItemClick)
            ' 
            ' biDelete
            ' 
            resources.ApplyResources(Me.biDelete, "biDelete")
            Me.biDelete.Id = 1
            Me.biDelete.ImageOptions.SvgImage = CType((resources.GetObject("biDelete.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biDelete.Name = "biDelete"
            AddHandler Me.biDelete.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biDelete_ItemClick)
            ' 
            ' biRead
            ' 
            resources.ApplyResources(Me.biRead, "biRead")
            Me.biRead.Id = 2
            Me.biRead.ImageOptions.ImageIndex =(CInt((resources.GetObject("biRead.ImageOptions.ImageIndex"))))
            Me.biRead.Name = "biRead"
            AddHandler Me.biRead.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biRead_ItemClick)
            ' 
            ' barSubItem1
            ' 
            resources.ApplyResources(Me.barSubItem1, "barSubItem1")
            Me.barSubItem1.Id = 3
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bcLow), New DevExpress.XtraBars.LinkPersistInfo(Me.bcMedium), New DevExpress.XtraBars.LinkPersistInfo(Me.bcHigh)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' bcLow
            ' 
            resources.ApplyResources(Me.bcLow, "bcLow")
            Me.bcLow.GroupIndex = 1
            Me.bcLow.Id = 5
            Me.bcLow.Name = "bcLow"
            AddHandler Me.bcLow.DownChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bc_DownChanged)
            ' 
            ' bcMedium
            ' 
            resources.ApplyResources(Me.bcMedium, "bcMedium")
            Me.bcMedium.GroupIndex = 1
            Me.bcMedium.Id = 8
            Me.bcMedium.Name = "bcMedium"
            AddHandler Me.bcMedium.DownChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bc_DownChanged)
            ' 
            ' bcHigh
            ' 
            resources.ApplyResources(Me.bcHigh, "bcHigh")
            Me.bcHigh.GroupIndex = 1
            Me.bcHigh.Id = 9
            Me.bcHigh.Name = "bcHigh"
            AddHandler Me.bcHigh.DownChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bc_DownChanged)
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.svgImageCollection2
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.biDelete, Me.biRead, Me.barSubItem1, Me.biOpen, Me.bcLow, Me.bcMedium, Me.bcHigh})
            Me.barManager1.MaxItemId = 10
            AddHandler Me.barManager1.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barManager1_ItemClick)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
            Me.barDockControlTop.Manager = Me.barManager1
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
            Me.barDockControlBottom.Manager = Me.barManager1
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
            Me.barDockControlLeft.Manager = Me.barManager1
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
            Me.barDockControlRight.Manager = Me.barManager1
            ' 
            ' repositoryItemImageComboBox4
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox4, "repositoryItemImageComboBox4")
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox4.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox4.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox4.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox4.Items5")))))})
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.SmallImages = Me.svgImageCollection1
            ' 
            ' ucMailViewer1
            ' 
            resources.ApplyResources(Me.ucMailViewer1, "ucMailViewer1")
            Me.ucMailViewer1.Name = "ucMailViewer1"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            AddHandler Me.gridControl1.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gridControl1_MouseDoubleClick)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.gridColumn2
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.svgImageColumns
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsPrint.PrintHorzLines = False
            Me.gridView1.OptionsPrint.PrintPreview = True
            Me.gridView1.OptionsPrint.PrintVertLines = False
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.PreviewFieldName = "PlainText"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn6, DevExpress.Data.ColumnSortOrder.Descending)})
            AddHandler Me.gridView1.RowCellClick, New DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(AddressOf Me.gridView1_RowCellClick)
            AddHandler Me.gridView1.ColumnPositionChanged, New System.EventHandler(AddressOf Me.gridView1_ColumnPositionChanged)
            AddHandler Me.gridView1.FocusedRowChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(AddressOf Me.gridView1_FocusedRowChanged)
            AddHandler Me.gridView1.ColumnFilterChanged, New System.EventHandler(AddressOf Me.gridView1_ColumnFilterChanged)
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn1.FieldName = "Priority"
            Me.gridColumn1.ImageOptions.Alignment = CType((resources.GetObject("gridColumn1.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.gridColumn1.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn1.ImageOptions.ImageIndex"))))
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowFocus = False
            Me.gridColumn1.OptionsColumn.AllowSize = False
            Me.gridColumn1.OptionsColumn.FixedWidth = True
            Me.gridColumn1.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' gridColumn3
            ' 
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.gridColumn3.FieldName = "Attachment"
            Me.gridColumn3.ImageOptions.Alignment = CType((resources.GetObject("gridColumn3.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.gridColumn3.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn3.ImageOptions.ImageIndex"))))
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowEdit = False
            Me.gridColumn3.OptionsColumn.AllowFocus = False
            Me.gridColumn3.OptionsColumn.AllowSize = False
            Me.gridColumn3.OptionsColumn.FixedWidth = True
            Me.gridColumn3.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox3
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items5")))))})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.svgImageCollection1
            ' 
            ' gridColumn4
            ' 
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.FieldName = "Subject"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.FieldName = "From"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.FieldName = "Date"
            Me.gridColumn6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn7
            ' 
            Me.gridColumn7.ColumnEdit = Me.repositoryItemImageComboBox4
            Me.gridColumn7.FieldName = "Read"
            Me.gridColumn7.ImageOptions.Alignment = CType((resources.GetObject("gridColumn7.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.gridColumn7.ImageOptions.ImageIndex =(CInt((resources.GetObject("gridColumn7.ImageOptions.ImageIndex"))))
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.OptionsColumn.AllowEdit = False
            Me.gridColumn7.OptionsColumn.AllowFocus = False
            Me.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn7.OptionsColumn.AllowShowHide = False
            Me.gridColumn7.OptionsColumn.AllowSize = False
            Me.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn7.OptionsColumn.FixedWidth = True
            Me.gridColumn7.OptionsColumn.ShowCaption = False
            Me.gridColumn7.OptionsFilter.AllowAutoFilter = False
            Me.gridColumn7.OptionsFilter.AllowFilter = False
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            ' 
            ' svgImageColumns
            ' 
            Me.svgImageColumns.Add("system.Drawing.Bitmap_1", CType((resources.GetObject("svgImageColumns.system.Drawing.Bitmap_1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageColumns.Add("new1", CType((resources.GetObject("svgImageColumns.new1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageColumns.Add("system.Drawing.Bitmap_4", CType((resources.GetObject("svgImageColumns.system.Drawing.Bitmap_4")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageColumns.Add("show", "image://devav/actions/show.svg")
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.ucMailViewer1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' OutlookStyle
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "OutlookStyle"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OutlookStyle_Load)
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageColumns), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private biRead As DevExpress.XtraBars.BarButtonItem

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private biOpen As DevExpress.XtraBars.BarButtonItem

        Private bcLow As DevExpress.XtraBars.BarCheckItem

        Private bcMedium As DevExpress.XtraBars.BarCheckItem

        Private bcHigh As DevExpress.XtraBars.BarCheckItem

        Private ucMailViewer1 As DevExpress.XtraGrid.Demos.ucMailViewer

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridView1 As DevExpress.XtraGrid.Demos.PreviewGridView

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private svgImageColumns As DevExpress.Utils.SvgImageCollection

        Private svgImageCollection2 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
