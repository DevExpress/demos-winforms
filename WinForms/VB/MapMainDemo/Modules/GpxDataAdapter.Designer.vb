Imports DevExpress.Utils.Layout
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraMap.Demos

    Partial Class GpxDataAdapterDemo

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim areaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.GpxDataAdapterDemo))
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.GpxDataLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.gpxFileDataAdapter1 = New DevExpress.XtraMap.GpxFileDataAdapter()
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mapControl1.SuspendLayout()
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.tablePanel1)
            Me.panelControl1.Size = New System.Drawing.Size(733, 332)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(40, 39, 40, 39)
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(5)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.OptionsMenuMinWidth = 440
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(733, 150)
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AutoLayout = False
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.tablePanel1.SetColumn(Me.chartControl1, 0)
            Me.tablePanel1.SetColumnSpan(Me.chartControl1, 4)
            Me.chartControl1.CrosshairOptions.GroupHeaderPattern = "Distance : {A:F2} m"
            Me.chartControl1.CrosshairOptions.ShowOnlyInFocusedPane = False
            xyDiagram1.AxisX.Title.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            xyDiagram1.AxisX.Title.Text = "Distance, m"
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.GridLines.Visible = False
            xyDiagram1.AxisY.Title.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            xyDiagram1.AxisY.Title.Text = "Elevation, m"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DefaultPane.BorderVisible = False
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.PaneDistance = 0
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Label.TextPattern = "{V:mm\:ss}"
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.Reverse = True
            secondaryAxisY1.Title.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            secondaryAxisY1.Title.Text = "Pace, min/km"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.Name = "Secondary AxisY 2"
            secondaryAxisY2.Title.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            secondaryAxisY2.Title.Text = "Heart Rate, BMP"
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY2.VisibleInPanesSerializable = "-1"
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2})
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.Margins.Bottom = 2
            Me.chartControl1.Legend.Margins.Left = 2
            Me.chartControl1.Legend.Margins.Right = 2
            Me.chartControl1.Legend.Margins.Top = 2
            Me.chartControl1.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Padding.Bottom = 2
            Me.chartControl1.Legend.Padding.Left = 2
            Me.chartControl1.Legend.Padding.Right = 2
            Me.chartControl1.Legend.Padding.Top = 2
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.Location = New System.Drawing.Point(3, 213)
            Me.chartControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.chartControl1.Name = "chartControl1"
            Me.tablePanel1.SetRow(Me.chartControl1, 1)
            Me.chartControl1.RuntimeHitTesting = True
            series1.ArgumentDataMember = "gpxdata:distance"
            series1.CrosshairLabelPattern = "{S} : {V:mm\:ss}/km"
            series1.Name = "Pace"
            series1.ValueDataMembersSerializable = "Pace"
            series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan
            lineSeriesView1.AxisYName = "Secondary AxisY 1"
            lineSeriesView1.LineMarkerOptions.Size = 6
            series1.View = lineSeriesView1
            series2.ArgumentDataMember = "gpxdata:distance"
            series2.CrosshairLabelPattern = "{S} : {V} BMP"
            series2.Name = "Heart Rate"
            series2.ValueDataMembersSerializable = "gpxtpx:hr"
            lineSeriesView2.AxisYName = "Secondary AxisY 2"
            lineSeriesView2.LineMarkerOptions.Size = 6
            series2.View = lineSeriesView2
            series3.ArgumentDataMember = "gpxdata:distance"
            series3.CrosshairLabelPattern = "{S} : {V:F2} m"
            series3.Name = "Elevation"
            series3.ValueDataMembersSerializable = "ele"
            areaSeriesView1.Border.Color = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((176)))))), (CInt(((CByte((80)))))))
            areaSeriesView1.Border.Thickness = 2
            areaSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            areaSeriesView1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            areaSeriesView1.MarkerOptions.Size = 6
            series3.View = areaSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3}
            Me.chartControl1.SeriesTemplate.LegendName = "Default Legend"
            Me.chartControl1.Size = New System.Drawing.Size(727, 116)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.ValidateDataMembers = False
            AddHandler Me.chartControl1.CustomDrawCrosshair, New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(AddressOf Me.ChartControl1_CustomDrawCrosshair)
            AddHandler Me.chartControl1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.ChartControl1_MouseMove)
            ' 
            ' mapControl1
            ' 
            Me.tablePanel1.SetColumn(Me.mapControl1, 0)
            Me.tablePanel1.SetColumnSpan(Me.mapControl1, 4)
            Me.mapControl1.Controls.Add(Me.gridLookUpEdit1)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.GpxDataLayer)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl1.Location = New System.Drawing.Point(3, 3)
            Me.mapControl1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
            Me.mapControl1.Measurements.ShowToolbar = True
            Me.mapControl1.Measurements.ToolbarOptions.ShowAreaButton = False
            Me.mapControl1.MinZoomLevel = 10R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.tablePanel1.SetRow(Me.mapControl1, 0)
            Me.mapControl1.Size = New System.Drawing.Size(727, 200)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 10R
            AddHandler Me.mapControl1.OverlaysArranged, New DevExpress.XtraMap.OverlaysArrangedEventHandler(AddressOf Me.mapControl1_OverlaysArranged)
            ' 
            ' gridLookUpEdit1
            ' 
            Me.gridLookUpEdit1.Location = New System.Drawing.Point(10, 10)
            Me.gridLookUpEdit1.Margin = New System.Windows.Forms.Padding(10)
            Me.gridLookUpEdit1.MenuManager = Me
            Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
            Me.gridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
            Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gridLookUpEdit1.Properties.DisplayMember = "Title"
            Me.gridLookUpEdit1.Properties.PopupSizeable = False
            Me.gridLookUpEdit1.Properties.PopupView = Me.gridLookUpEdit1View
            Me.gridLookUpEdit1.Properties.ShowFooter = False
            AddHandler Me.gridLookUpEdit1.Properties.EditValueChanged, New System.EventHandler(AddressOf Me.OnGridLookUpEditValueChanged)
            Me.gridLookUpEdit1.Size = New System.Drawing.Size(472, 20)
            Me.gridLookUpEdit1.TabIndex = 1
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.gridLookUpEdit1View.OptionsView.ShowIndicator = False
            Me.imageLayer1.DataProvider = Me.AzureMapDataProvider
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.GpxDataLayer.Data = Me.gpxFileDataAdapter1
            Me.GpxDataLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((140)))))), (CInt(((CByte((210)))))))
            Me.GpxDataLayer.ItemStyle.StrokeWidth = 5
            Me.GpxDataLayer.Name = "GpxDataLayer"
            AddHandler Me.GpxDataLayer.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.VectorItemsLayer1_DataLoaded)
            Me.vectorItemsLayer2.Data = Me.mapItemStorage1
            Me.vectorItemsLayer2.EnableHighlighting = False
            Me.vectorItemsLayer2.EnableSelection = False
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.tablePanel1.Controls.Add(Me.htmlContentControl1)
            Me.tablePanel1.Controls.Add(Me.chartControl1)
            Me.tablePanel1.Controls.Add(Me.mapControl1)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)})
            Me.tablePanel1.Size = New System.Drawing.Size(733, 332)
            Me.tablePanel1.TabIndex = 0
            ' 
            ' htmlContentControl1
            ' 
            Me.tablePanel1.SetColumn(Me.htmlContentControl1, 0)
            Me.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.htmlContentControl1.HtmlImages = Me.svgImageCollection1
            ' 
            ' 
            ' 
            Me.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles")
            Me.htmlContentControl1.Location = New System.Drawing.Point(518, 15)
            Me.htmlContentControl1.Margin = New System.Windows.Forms.Padding(15)
            Me.htmlContentControl1.Name = "htmlContentControl1"
            Me.tablePanel1.SetRow(Me.htmlContentControl1, 0)
            Me.htmlContentControl1.Size = New System.Drawing.Size(200, 178)
            Me.htmlContentControl1.TabIndex = 2
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Pace", "image://svgimages/dashboards/gaugestylehalfcircular.svg")
            Me.svgImageCollection1.Add("HeartRate", "image://svgimages/icon builder/shopping_favorites.svg")
            Me.svgImageCollection1.Add("Duration", "image://svgimages/outlook inspired/employeequickprobationnotice.svg")
            Me.svgImageCollection1.Add("Distance", "image://svgimages/richedit/rulerhorizontal.svg")
            ' 
            ' GpxDataAdapterDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(5)
            Me.Name = "GpxDataAdapterDemo"
            Me.Size = New System.Drawing.Size(733, 500)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mapControl1.ResumeLayout(False)
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private GpxDataLayer As DevExpress.XtraMap.VectorItemsLayer

        Private gpxFileDataAdapter1 As DevExpress.XtraMap.GpxFileDataAdapter

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl
    End Class
End Namespace
