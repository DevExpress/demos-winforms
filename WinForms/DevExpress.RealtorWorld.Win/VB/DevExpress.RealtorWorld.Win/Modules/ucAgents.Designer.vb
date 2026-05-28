Namespace DevExpress.RealtorWorld.Win

    Partial Class ucAgents

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
            Dim imageAnnotation2 As DevExpress.XtraCharts.ImageAnnotation = New DevExpress.XtraCharts.ImageAnnotation()
            Dim chartAnchorPoint2 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
            Dim freePosition2 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel6 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel7 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel8 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel9 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesLabel10 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.pnlList = New DevExpress.XtraEditors.TileControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ccAgent = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBeds = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBaths = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHouseSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colYearBuilt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ccAgent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((imageAnnotation2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pnlList
            ' 
            Me.pnlList.AllowSelectedItem = True
            Me.pnlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.pnlList.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlList.IndentBetweenItems = 11
            Me.pnlList.ItemPadding = New System.Windows.Forms.Padding(3)
            Me.pnlList.Location = New System.Drawing.Point(0, 0)
            Me.pnlList.Name = "pnlList"
            Me.pnlList.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.pnlList.Padding = New System.Windows.Forms.Padding(6)
            Me.pnlList.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar
            Me.pnlList.Size = New System.Drawing.Size(226, 597)
            Me.pnlList.TabIndex = 3
            Me.pnlList.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            AddHandler Me.pnlList.ItemClick, New DevExpress.XtraEditors.TileItemClickEventHandler(AddressOf Me.pnlList_ItemClick)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ccAgent)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(226, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(745, 388, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(949, 597)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ccAgent
            ' 
            chartAnchorPoint2.X = 0
            chartAnchorPoint2.Y = 0
            imageAnnotation2.AnchorPoint = chartAnchorPoint2
            imageAnnotation2.BackColor = System.Drawing.Color.Transparent
            imageAnnotation2.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            imageAnnotation2.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
            imageAnnotation2.Height = 96
            imageAnnotation2.Name = "Image Annotation 1"
            imageAnnotation2.ShapeKind = DevExpress.XtraCharts.ShapeKind.Rectangle
            freePosition2.DockCorner = DevExpress.XtraCharts.DockCorner.RightTop
            freePosition2.InnerIndents.Top = 48
            imageAnnotation2.ShapePosition = freePosition2
            imageAnnotation2.SizeMode = DevExpress.XtraCharts.ChartImageSizeMode.Zoom
            imageAnnotation2.Visible = False
            imageAnnotation2.Width = 83
            Me.ccAgent.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {imageAnnotation2})
            Me.ccAgent.CacheToMemory = True
            xyDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram2.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram2.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.EnableAxisXScrolling = True
            xyDiagram2.EnableAxisXZooming = True
            Me.ccAgent.Diagram = xyDiagram2
            Me.ccAgent.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.ccAgent.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            Me.ccAgent.Legend.Padding.Bottom = 10
            Me.ccAgent.Legend.Padding.Left = 10
            Me.ccAgent.Legend.Padding.Right = 10
            Me.ccAgent.Legend.Padding.Top = 10
            Me.ccAgent.Location = New System.Drawing.Point(12, 214)
            Me.ccAgent.Name = "ccAgent"
            Me.ccAgent.Padding.Bottom = 20
            Me.ccAgent.Padding.Left = 20
            Me.ccAgent.Padding.Right = 20
            Me.ccAgent.Padding.Top = 20
            Me.ccAgent.PaletteName = "Flow"
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            sideBySideBarSeriesLabel6.BackColor = System.Drawing.Color.Transparent
            sideBySideBarSeriesLabel6.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel6.ShowForZeroValues = True
            series5.Label = sideBySideBarSeriesLabel6
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series5.Name = "North-East"
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            sideBySideBarSeriesLabel7.BackColor = System.Drawing.Color.Transparent
            sideBySideBarSeriesLabel7.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesLabel7.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel7.ShowForZeroValues = True
            series6.Label = sideBySideBarSeriesLabel7
            series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series6.Name = "Mid-West"
            series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            sideBySideBarSeriesLabel8.BackColor = System.Drawing.Color.Transparent
            sideBySideBarSeriesLabel8.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesLabel8.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel8.ShowForZeroValues = True
            series7.Label = sideBySideBarSeriesLabel8
            series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series7.Name = "South"
            series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            sideBySideBarSeriesLabel9.BackColor = System.Drawing.Color.Transparent
            sideBySideBarSeriesLabel9.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesLabel9.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel9.ShowForZeroValues = True
            series8.Label = sideBySideBarSeriesLabel9
            series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series8.Name = "West"
            Me.ccAgent.SeriesSerializable = New DevExpress.XtraCharts.Series() {series5, series6, series7, series8}
            sideBySideBarSeriesLabel10.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.ccAgent.SeriesTemplate.Label = sideBySideBarSeriesLabel10
            Me.ccAgent.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.ccAgent.Size = New System.Drawing.Size(935, 381)
            Me.ccAgent.TabIndex = 6
            chartTitle2.Font = New System.Drawing.Font("Tahoma", 12F)
            chartTitle2.Text = "Houses Sold by "
            Me.ccAgent.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(12, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemCalcEdit1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(935, 203)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            AddHandler Me.gridControl1.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gridControl1_MouseDoubleClick)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.GroupPanel.Options.UseTextOptions = True
            Me.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBeds, Me.colBaths, Me.colHouseSize, Me.colPrice, Me.colYearBuilt, Me.colPhoto, Me.colAddress})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupPanelText = "   "
            Me.gridView1.GroupRowHeight = 80
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsCustomization.AllowQuickHideColumns = False
            Me.gridView1.OptionsSelection.EnableAppearanceHideSelection = False
            Me.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
            Me.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.RowHeight = 60
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPrice, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsColumn.AllowEdit = False
            Me.colID.OptionsColumn.AllowFocus = False
            Me.colID.OptionsFilter.AllowFilter = False
            Me.colID.Width = 45
            ' 
            ' colBeds
            ' 
            Me.colBeds.Caption = "Bedrooms"
            Me.colBeds.FieldName = "Beds"
            Me.colBeds.Name = "colBeds"
            Me.colBeds.OptionsColumn.AllowEdit = False
            Me.colBeds.OptionsColumn.AllowFocus = False
            Me.colBeds.Visible = True
            Me.colBeds.VisibleIndex = 2
            Me.colBeds.Width = 132
            ' 
            ' colBaths
            ' 
            Me.colBaths.Caption = "Bathrooms"
            Me.colBaths.FieldName = "Baths"
            Me.colBaths.Name = "colBaths"
            Me.colBaths.OptionsColumn.AllowEdit = False
            Me.colBaths.OptionsColumn.AllowFocus = False
            Me.colBaths.Visible = True
            Me.colBaths.VisibleIndex = 3
            Me.colBaths.Width = 126
            ' 
            ' colHouseSize
            ' 
            Me.colHouseSize.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colHouseSize.FieldName = "HouseSize"
            Me.colHouseSize.Name = "colHouseSize"
            Me.colHouseSize.OptionsColumn.AllowEdit = False
            Me.colHouseSize.OptionsColumn.AllowFocus = False
            Me.colHouseSize.Visible = True
            Me.colHouseSize.VisibleIndex = 4
            Me.colHouseSize.Width = 117
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.DisplayFormat.FormatString = "{0:n0} Sq Ft"
            Me.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemTextEdit1.Mask.EditMask = "n0"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' colPrice
            ' 
            Me.colPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.OptionsColumn.AllowEdit = False
            Me.colPrice.OptionsColumn.AllowFocus = False
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 5
            Me.colPrice.Width = 125
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Mask.EditMask = "c0"
            Me.repositoryItemCalcEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' colYearBuilt
            ' 
            Me.colYearBuilt.FieldName = "YearBuilt"
            Me.colYearBuilt.Name = "colYearBuilt"
            Me.colYearBuilt.OptionsColumn.AllowEdit = False
            Me.colYearBuilt.OptionsColumn.AllowFocus = False
            Me.colYearBuilt.Width = 201
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowEdit = False
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.FixedWidth = True
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 0
            Me.colPhoto.Width = 96
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' colAddress
            ' 
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.OptionsColumn.AllowEdit = False
            Me.colAddress.OptionsColumn.AllowFocus = False
            Me.colAddress.OptionsFilter.AllowFilter = False
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 1
            Me.colAddress.Width = 337
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem3, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(949, 597)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.CustomizationFormText = "Homes:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(939, 207)
            Me.layoutControlItem1.Text = "Homes:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ccAgent
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 212)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(939, 385)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(0, 207)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(939, 5)
            ' 
            ' ucAgents
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.pnlList)
            Me.Name = "ucAgents"
            Me.Size = New System.Drawing.Size(1175, 597)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((imageAnnotation2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ccAgent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pnlList As DevExpress.XtraEditors.TileControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private colID As DevExpress.XtraGrid.Columns.GridColumn

        Private colBeds As DevExpress.XtraGrid.Columns.GridColumn

        Private colBaths As DevExpress.XtraGrid.Columns.GridColumn

        Private colHouseSize As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colYearBuilt As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private ccAgent As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
