Namespace DevExpress.XtraTreeMap.Demos

    Partial Class Selection

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
            Dim choroplethColorizer1 As DevExpress.XtraMap.ChoroplethColorizer = New DevExpress.XtraMap.ChoroplethColorizer()
            Dim linearRangeDistribution1 As DevExpress.XtraMap.LinearRangeDistribution = New DevExpress.XtraMap.LinearRangeDistribution()
            Dim shapeAttributeValueProvider1 As DevExpress.XtraMap.ShapeAttributeValueProvider = New DevExpress.XtraMap.ShapeAttributeValueProvider()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim splineAreaSeriesView1 As DevExpress.XtraCharts.SplineAreaSeriesView = New DevExpress.XtraCharts.SplineAreaSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim treeMapPaletteColorizer1 As DevExpress.XtraTreeMap.TreeMapPaletteColorizer = New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapFlatDataAdapter1 As DevExpress.XtraTreeMap.TreeMapFlatDataAdapter = New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.vectorItemsLayer1.Data = Me.shapefileDataAdapter1
            Me.vectorItemsLayer1.EnableHighlighting = False
            Me.vectorItemsLayer1.EnableSelection = False
            Me.vectorItemsLayer1.Name = "BackgroundLayer"
            Me.vectorItemsLayer1.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden
            choroplethColorizer1.ApproximateColors = True
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1
            choroplethColorizer1.RangeStops.Add(0R)
            choroplethColorizer1.RangeStops.Add(13R)
            shapeAttributeValueProvider1.AttributeName = "MAP_COLOR"
            choroplethColorizer1.ValueProvider = shapeAttributeValueProvider1
            Me.vectorItemsLayer2.Colorizer = choroplethColorizer1
            Me.vectorItemsLayer2.Name = "FileLayer"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.BackColor = System.Drawing.Color.Transparent
            Me.layoutControl.Controls.Add(Me.label1)
            Me.layoutControl.Controls.Add(Me.chartControl1)
            Me.layoutControl.Controls.Add(Me.mapControl)
            Me.layoutControl.Controls.Add(Me.treeMapControl1)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(778, 293, 845, 627)
            Me.layoutControl.Root = Me.layoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(731, 522)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            AddHandler Me.layoutControl.ClientSizeChanged, New System.EventHandler(AddressOf Me.layoutControl_ClientSizeChanged)
            ' 
            ' label1
            ' 
            Me.label1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.label1.Appearance.Options.UseFont = True
            Me.label1.Location = New System.Drawing.Point(248, 4)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(234, 29)
            Me.label1.StyleController = Me.layoutControl
            Me.label1.TabIndex = 10
            Me.label1.Text = "Top Countries By GDP"
            Me.label1.UseMnemonic = False
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,,,}B$"
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
            xyDiagram1.DefaultPane.BorderVisible = False
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Location = New System.Drawing.Point(367, 324)
            Me.chartControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "Year"
            series1.CrosshairLabelPattern = "{S}: {V:#,,,}B$"
            series1.Name = "GDP"
            series1.ValueDataMembersSerializable = "GDP"
            splineAreaSeriesView1.Transparency =(CByte((100)))
            series1.View = splineAreaSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Size = New System.Drawing.Size(364, 198)
            Me.chartControl1.TabIndex = 9
            chartTitle1.Text = "GDP Dynamic"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' mapControl
            ' 
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.CenterPoint = New DevExpress.XtraMap.GeoPoint(45R, 0R)
            Me.mapControl.EnableAnimation = False
            Me.mapControl.EnableScrolling = False
            Me.mapControl.EnableZooming = False
            Me.mapControl.InitialMapSize = New System.Drawing.Size(340, 340)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl.Location = New System.Drawing.Point(367, 37)
            Me.mapControl.Margin = New System.Windows.Forms.Padding(0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.NavigationPanelOptions.Visible = False
            Me.mapControl.RenderMode = DevExpress.XtraMap.RenderMode.DirectX
            Me.mapControl.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl.Size = New System.Drawing.Size(364, 287)
            Me.mapControl.TabIndex = 8
            AddHandler Me.mapControl.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.mapControl_SelectionChanged)
            ' 
            ' treeMapControl1
            ' 
            Me.treeMapControl1.Appearance.GroupStyle.SubGroupFill = System.Drawing.Color.Transparent
            Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.treeMapControl1.BorderOptions.Visible = False
            treeMapPaletteColorizer1.LegendItemPattern = Nothing
            treeMapPaletteColorizer1.Palette = New DevExpress.XtraTreeMap.Palette(New System.Drawing.Color() {System.Drawing.Color.FromArgb((CInt(((CByte((97)))))), (CInt(((CByte((150)))))), (CInt(((CByte((211))))))), System.Drawing.Color.FromArgb((CInt(((CByte((234)))))), (CInt(((CByte((127)))))), (CInt(((CByte((56))))))), System.Drawing.Color.FromArgb((CInt(((CByte((252)))))), (CInt(((CByte((195)))))), (CInt(((CByte((25))))))), System.Drawing.Color.FromArgb((CInt(((CByte((76)))))), (CInt(((CByte((107)))))), (CInt(((CByte((194))))))), System.Drawing.Color.FromArgb((CInt(((CByte((111)))))), (CInt(((CByte((174)))))), (CInt(((CByte((73))))))), System.Drawing.Color.FromArgb((CInt(((CByte((48)))))), (CInt(((CByte((91)))))), (CInt(((CByte((143))))))), System.Drawing.Color.FromArgb((CInt(((CByte((155)))))), (CInt(((CByte((76)))))), (CInt(((CByte((26))))))), System.Drawing.Color.FromArgb((CInt(((CByte((150)))))), (CInt(((CByte((117)))))), (CInt(((CByte((10))))))), System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((66)))))), (CInt(((CByte((119))))))), System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((105)))))), (CInt(((CByte((47))))))), System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((171)))))), (CInt(((CByte((220))))))), System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((153)))))), (CInt(((CByte((92))))))), System.Drawing.Color.FromArgb((CInt(((CByte((252)))))), (CInt(((CByte((208)))))), (CInt(((CByte((58))))))), System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((129)))))), (CInt(((CByte((195)))))))})
            Me.treeMapControl1.Colorizer = treeMapPaletteColorizer1
            treeMapFlatDataAdapter1.DataMember = Nothing
            treeMapFlatDataAdapter1.GroupDataMembersSerializable = "Continent"
            treeMapFlatDataAdapter1.LabelDataMember = "Name"
            treeMapFlatDataAdapter1.ValueDataMember = "GDP"
            Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
            Me.treeMapControl1.Location = New System.Drawing.Point(0, 37)
            Me.treeMapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.treeMapControl1.Name = "treeMapControl1"
            Me.treeMapControl1.SelectionMode = DevExpress.XtraTreeMap.ElementSelectionMode.[Single]
            Me.treeMapControl1.Size = New System.Drawing.Size(367, 485)
            Me.treeMapControl1.TabIndex = 7
            AddHandler Me.treeMapControl1.SelectionChanged, New DevExpress.XtraTreeMap.SelectionChangedEventHandler(AddressOf Me.treeMapControl_SelectionChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(731, 522)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 37)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(367, 485)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.treeMapControl1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem4"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(367, 485)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            Me.layoutControlItem3.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(367, 37)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(364, 485)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.mapControl
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(104, 24)
            Me.layoutControlItem2.Name = "layoutControlItem3"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(364, 287)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlItem2.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chartControl1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 287)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(104, 24)
            Me.layoutControlItem4.Name = "layoutControlItem5"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(364, 198)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            Me.layoutControlItem4.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.label1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(731, 37)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' Selection
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "Selection"
            Me.Size = New System.Drawing.Size(731, 522)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private mapControl As DevExpress.XtraMap.MapControl

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private treeMapControl1 As DevExpress.XtraTreeMap.TreeMapControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private label1 As DevExpress.XtraEditors.LabelControl

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer
    End Class
End Namespace
