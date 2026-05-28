Namespace DevExpress.XtraGrid.Demos

    Partial Class GridServerMode

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.GridServerMode))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpServerCollectionSource1 = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.xtraConsole1 = New DevExpress.XtraGrid.Demos.XtraConsole()
            Me.sbClear = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.sbShowSQLConnection = New DevExpress.XtraEditors.SimpleButton()
            Me.ceTracing = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.unitOfWork1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceTracing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpServerCollectionSource1
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemCheckEdit1, Me.repositoryItemImageComboBox1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' xpServerCollectionSource1
            ' 
            Me.xpServerCollectionSource1.AllowEdit = True
            Me.xpServerCollectionSource1.AllowNew = True
            Me.xpServerCollectionSource1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideGridTest)
            Me.xpServerCollectionSource1.Session = Me.unitOfWork1
            Me.xpServerCollectionSource1.TrackChanges = True
            ' 
            ' unitOfWork1
            ' 
            Me.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
            Me.unitOfWork1.TrackPropertiesModifications = False
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment, Me.colPriority})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary4")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary5"), CType((resources.GetObject("gridView1.GroupSummary6")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary7")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary8")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary9"), Me.colSize, resources.GetString("gridView1.GroupSummary10"))})
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsMenu.ShowGroupSortSummaryItems = False
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gridView1.OptionsView.ShowFooter = True
            ' 
            ' colOid
            ' 
            resources.ApplyResources(Me.colOid, "colOid")
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.[ReadOnly] = True
            Me.colOid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colOid.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colSubject
            ' 
            resources.ApplyResources(Me.colSubject, "colSubject")
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            ' 
            ' colFrom
            ' 
            resources.ApplyResources(Me.colFrom, "colFrom")
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            ' 
            ' colSent
            ' 
            resources.ApplyResources(Me.colSent, "colSent")
            Me.colSent.FieldName = "Sent"
            Me.colSent.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
            Me.colSent.Name = "colSent"
            ' 
            ' colSize
            ' 
            resources.ApplyResources(Me.colSize, "colSize")
            Me.colSize.DisplayFormat.FormatString = "{0:n0} KB"
            Me.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSize.FieldName = "Size"
            Me.colSize.Name = "colSize"
            Me.colSize.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colSize.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colSize.Summary1"), resources.GetString("colSize.Summary2"))})
            ' 
            ' colHasAttachment
            ' 
            resources.ApplyResources(Me.colHasAttachment, "colHasAttachment")
            Me.colHasAttachment.ColumnEdit = Me.repositoryItemCheckEdit1
            Me.colHasAttachment.FieldName = "HasAttachment"
            Me.colHasAttachment.ImageOptions.Alignment = CType((resources.GetObject("colHasAttachment.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colHasAttachment.ImageOptions.ImageIndex =(CInt((resources.GetObject("colHasAttachment.ImageOptions.ImageIndex"))))
            Me.colHasAttachment.Name = "colHasAttachment"
            Me.colHasAttachment.OptionsColumn.AllowSize = False
            Me.colHasAttachment.OptionsColumn.FixedWidth = True
            Me.colHasAttachment.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemCheckEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCheckEdit1, "repositoryItemCheckEdit1")
            Me.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
            Me.repositoryItemCheckEdit1.ImageOptions.ImageIndexChecked = 4
            Me.repositoryItemCheckEdit1.ImageOptions.Images = Me.svgImageCollection1
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            Me.repositoryItemCheckEdit1.[ReadOnly] = True
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("system.Drawing.Bitmap", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_1", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_2", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_2")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_3", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_3")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_4", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_4")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Icon", CType((resources.GetObject("svgImageCollection1.Icon")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' colPriority
            ' 
            resources.ApplyResources(Me.colPriority, "colPriority")
            Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.ImageOptions.Alignment = CType((resources.GetObject("colPriority.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colPriority.ImageOptions.ImageIndex =(CInt((resources.GetObject("colPriority.ImageOptions.ImageIndex"))))
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsColumn.AllowSize = False
            Me.colPriority.OptionsColumn.FixedWidth = True
            Me.colPriority.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' xtraConsole1
            ' 
            Me.xtraConsole1.Appearance.ForeColor = CType((resources.GetObject("xtraConsole1.Appearance.ForeColor")), System.Drawing.Color)
            Me.xtraConsole1.Appearance.Options.UseForeColor = True
            resources.ApplyResources(Me.xtraConsole1, "xtraConsole1")
            Me.xtraConsole1.Name = "xtraConsole1"
            ' 
            ' sbClear
            ' 
            resources.ApplyResources(Me.sbClear, "sbClear")
            Me.sbClear.Name = "sbClear"
            Me.sbClear.StyleController = Me.layoutControl1
            AddHandler Me.sbClear.Click, New System.EventHandler(AddressOf Me.sbClear_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.sbShowSQLConnection)
            Me.layoutControl1.Controls.Add(Me.sbClear)
            Me.layoutControl1.Controls.Add(Me.ceTracing)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.groupControl1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' sbShowSQLConnection
            ' 
            resources.ApplyResources(Me.sbShowSQLConnection, "sbShowSQLConnection")
            Me.sbShowSQLConnection.Name = "sbShowSQLConnection"
            Me.sbShowSQLConnection.StyleController = Me.layoutControl1
            AddHandler Me.sbShowSQLConnection.Click, New System.EventHandler(AddressOf Me.sbShowSQLConnection_Click)
            ' 
            ' ceTracing
            ' 
            resources.ApplyResources(Me.ceTracing, "ceTracing")
            Me.ceTracing.Name = "ceTracing"
            Me.ceTracing.Properties.Caption = resources.GetString("ceTracing.Properties.Caption")
            Me.ceTracing.StyleController = Me.layoutControl1
            AddHandler Me.ceTracing.CheckedChanged, New System.EventHandler(AddressOf Me.ceTracing_CheckedChanged)
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.xtraConsole1)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.sbShowSQLConnection
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 436)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(119, 33)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.splitterItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem4, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(927, 569)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(927, 383)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(0, 383)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(927, 5)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceTracing
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 388)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(119, 29)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.groupControl1
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(119, 388)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(808, 155)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 417)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(119, 93)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.sbClear
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 510)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.simpleButton1
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 543)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(927, 26)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' GridServerMode
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "GridServerMode"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.unitOfWork1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceTracing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private xpServerCollectionSource1 As DevExpress.Xpo.XPServerCollectionSource

        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork

        Private colOid As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private colFrom As DevExpress.XtraGrid.Columns.GridColumn

        Private colSent As DevExpress.XtraGrid.Columns.GridColumn

        Private colSize As DevExpress.XtraGrid.Columns.GridColumn

        Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn

        Private xtraConsole1 As DevExpress.XtraGrid.Demos.XtraConsole

        Private ceTracing As DevExpress.XtraEditors.CheckEdit

        Private sbClear As DevExpress.XtraEditors.SimpleButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private sbShowSQLConnection As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private colPriority As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
