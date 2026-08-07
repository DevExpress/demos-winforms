Namespace DevExpress.XtraCharts.Demos

    Partial Class HistogramDemo

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisX1 As DevExpress.XtraCharts.SecondaryAxisX = New DevExpress.XtraCharts.SecondaryAxisX()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter2 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter3 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesView2 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter4 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember6 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter5 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember7 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember8 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesView3 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter6 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember9 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel5 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel6 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel7 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel8 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel9 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel12 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel13 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel14 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel15 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel16 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel17 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel18 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel19 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel20 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel21 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel22 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.trackBar1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.trackBar2 = New DevExpress.XtraEditors.TrackBarControl()
            Me.trackBar3 = New DevExpress.XtraEditors.TrackBarControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBar3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chart.CrosshairOptions.ShowGroupHeaders = False
            Me.chart.CrosshairOptions.ShowValueLine = True
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.Title.Text = "Arguments"
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.GridLines.Visible = False
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.Title.Text = "Values"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1})
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisX1.AxisID = 0
            secondaryAxisX1.Label.ResolveOverlappingOptions.AllowRotate = False
            secondaryAxisX1.Label.ResolveOverlappingOptions.AllowStagger = False
            secondaryAxisX1.Label.TextPattern = "{A:#}"
            secondaryAxisX1.Name = "Secondary AxisX 1"
            secondaryAxisX1.NumericScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Histogram
            secondaryAxisX1.NumericScaleOptions.IntervalOptions.GridLayoutMode = DevExpress.XtraCharts.GridLayoutMode.GridAndLabelShifted
            secondaryAxisX1.NumericScaleOptions.IntervalOptions.Pattern = "{A1:#}-{A2:#}"
            secondaryAxisX1.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Interval
            secondaryAxisX1.Tickmarks.MinorVisible = False
            secondaryAxisX1.Title.Text = "Intervals"
            secondaryAxisX1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisX1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisX1.VisibleInPanesSerializable = "0"
            xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() {secondaryAxisX1})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Name = "Secondary Axis Y 1"
            secondaryAxisY1.Tickmarks.MinorVisible = False
            secondaryAxisY1.Title.Text = "Number of Points"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Margin = New System.Windows.Forms.Padding(0)
            Me.chart.Name = "chart"
            series1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
            series1.CrosshairLabelPattern = "{A}: {V}"
            dataMember1.ColumnName = "Argument"
            dataMember2.ColumnName = "Value"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2})
            series1.DataAdapter = dataSourceAdapter1
            series1.LegendName = "Default Legend"
            series1.Name = "Series 1"
            series1.SeriesID = 0
            series1.View = pointSeriesView1
            dataMember3.ColumnName = "Argument"
            dataSourceAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember3})
            series2.DataAdapter = dataSourceAdapter2
            series2.LegendName = "Default Legend"
            series2.Name = "Histogram 1"
            series2.SeriesID = 1
            sideBySideBarSeriesView1.AxisXName = "Secondary AxisX 1"
            sideBySideBarSeriesView1.AxisYName = "Secondary Axis Y 1"
            sideBySideBarSeriesView1.BarWidth = 1R
            sideBySideBarSeriesView1.PaneName = "Pane 1"
            series2.View = sideBySideBarSeriesView1
            series3.CrosshairLabelPattern = "{A}: {V}"
            dataMember4.ColumnName = "Argument"
            dataMember5.ColumnName = "Value"
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter3.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember4, dataMember5})
            series3.DataAdapter = dataSourceAdapter3
            series3.Name = "Series 2"
            series3.SeriesID = 2
            series3.View = pointSeriesView2
            dataMember6.ColumnName = "Argument"
            dataSourceAdapter4.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember6})
            series4.DataAdapter = dataSourceAdapter4
            series4.Name = "Histogram 2"
            series4.SeriesID = 3
            sideBySideBarSeriesView2.AxisXName = "Secondary AxisX 1"
            sideBySideBarSeriesView2.AxisYName = "Secondary Axis Y 1"
            sideBySideBarSeriesView2.BarWidth = 1R
            sideBySideBarSeriesView2.PaneName = "Pane 1"
            series4.View = sideBySideBarSeriesView2
            series5.CrosshairLabelPattern = "{A}: {V}"
            dataMember7.ColumnName = "Argument"
            dataMember8.ColumnName = "Value"
            dataMember8.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter5.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember7, dataMember8})
            series5.DataAdapter = dataSourceAdapter5
            series5.Name = "Series 3"
            series5.SeriesID = 4
            series5.View = pointSeriesView3
            dataMember9.ColumnName = "Argument"
            dataSourceAdapter6.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember9})
            series6.DataAdapter = dataSourceAdapter6
            series6.Name = "Histogram 3"
            series6.SeriesID = 5
            sideBySideBarSeriesView3.AxisXName = "Secondary AxisX 1"
            sideBySideBarSeriesView3.AxisYName = "Secondary Axis Y 1"
            sideBySideBarSeriesView3.BarWidth = 1R
            sideBySideBarSeriesView3.PaneName = "Pane 1"
            series6.View = sideBySideBarSeriesView3
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4, series5, series6}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 2
            chartTitle1.Text = "Point Distribution by Arguments"
            chartTitle1.TitleID = 0
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chart)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl.Controls.Add(Me.radioGroup1)
            Me.layoutControl.Controls.Add(Me.trackBar1)
            Me.layoutControl.Controls.Add(Me.trackBar2)
            Me.layoutControl.Controls.Add(Me.trackBar3)
            Me.layoutControl.Controls.Add(Me.simpleButton1)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(605, 330, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Location = New System.Drawing.Point(134, 34)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(95, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl
            Me.comboBoxEdit1.TabIndex = 4
            AddHandler Me.comboBoxEdit1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEdit1_SelectedIndexChanged)
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.AutoSizeInLayoutControl = True
            Me.radioGroup1.Location = New System.Drawing.Point(14, 494)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Size = New System.Drawing.Size(213, 8)
            Me.radioGroup1.StyleController = Me.layoutControl
            Me.radioGroup1.TabIndex = 10
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' trackBar1
            ' 
            Me.trackBar1.EditValue = 1
            Me.trackBar1.Location = New System.Drawing.Point(14, 102)
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.Properties.EditValueChangedDelay = 1
            Me.trackBar1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
            Me.trackBar1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBar1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "1"
            trackBarLabel1.Value = 1
            trackBarLabel2.Label = "2"
            trackBarLabel2.Value = 2
            trackBarLabel3.Label = "3"
            trackBarLabel3.Value = 3
            trackBarLabel4.Label = "4"
            trackBarLabel4.Value = 4
            trackBarLabel5.Label = "5"
            trackBarLabel5.Value = 5
            trackBarLabel6.Label = "6"
            trackBarLabel6.Value = 6
            trackBarLabel7.Label = "7"
            trackBarLabel7.Value = 7
            trackBarLabel8.Label = "8"
            trackBarLabel8.Value = 8
            trackBarLabel9.Label = "9"
            trackBarLabel9.Value = 9
            trackBarLabel10.Label = "10"
            trackBarLabel10.Value = 10
            Me.trackBar1.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10})
            Me.trackBar1.Properties.LargeChange = 1
            Me.trackBar1.Properties.Minimum = 1
            Me.trackBar1.Properties.ShowLabels = True
            Me.trackBar1.Properties.ShowValueToolTip = True
            Me.trackBar1.Size = New System.Drawing.Size(213, 72)
            Me.trackBar1.StyleController = Me.layoutControl
            Me.trackBar1.TabIndex = 11
            Me.trackBar1.Value = 1
            AddHandler Me.trackBar1.ValueChanged, New System.EventHandler(AddressOf Me.trackBar1_ValueChanged)
            ' 
            ' trackBar2
            ' 
            Me.trackBar2.EditValue = 10
            Me.trackBar2.Location = New System.Drawing.Point(14, 224)
            Me.trackBar2.Name = "trackBar2"
            Me.trackBar2.Properties.EditValueChangedDelay = 1
            Me.trackBar2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
            Me.trackBar2.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBar2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel11.Label = "10"
            trackBarLabel11.Value = 10
            trackBarLabel12.Label = "20"
            trackBarLabel12.Value = 20
            trackBarLabel13.Label = "30"
            trackBarLabel13.Value = 30
            trackBarLabel14.Label = "40"
            trackBarLabel14.Value = 40
            trackBarLabel15.Label = "50"
            trackBarLabel15.Value = 50
            trackBarLabel16.Label = "60"
            trackBarLabel16.Value = 60
            trackBarLabel17.Label = "70"
            trackBarLabel17.Value = 70
            trackBarLabel18.Label = "80"
            trackBarLabel18.Value = 80
            trackBarLabel19.Label = "90"
            trackBarLabel19.Value = 90
            Me.trackBar2.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel11, trackBarLabel12, trackBarLabel13, trackBarLabel14, trackBarLabel15, trackBarLabel16, trackBarLabel17, trackBarLabel18, trackBarLabel19})
            Me.trackBar2.Properties.LargeChange = 10
            Me.trackBar2.Properties.Maximum = 90
            Me.trackBar2.Properties.Minimum = 10
            Me.trackBar2.Properties.ShowLabels = True
            Me.trackBar2.Properties.ShowValueToolTip = True
            Me.trackBar2.Size = New System.Drawing.Size(213, 72)
            Me.trackBar2.StyleController = Me.layoutControl
            Me.trackBar2.TabIndex = 12
            Me.trackBar2.Value = 10
            AddHandler Me.trackBar2.ValueChanged, New System.EventHandler(AddressOf Me.trackBar2_ValueChanged)
            ' 
            ' trackBar3
            ' 
            Me.trackBar3.EditValue = 1
            Me.trackBar3.Location = New System.Drawing.Point(14, 346)
            Me.trackBar3.Name = "trackBar3"
            Me.trackBar3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.trackBar3.Properties.EditValueChangedDelay = 1
            Me.trackBar3.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBar3.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel20.Label = "1"
            trackBarLabel20.Value = 1
            trackBarLabel21.Label = "2"
            trackBarLabel21.Value = 2
            trackBarLabel22.Label = "3"
            trackBarLabel22.Value = 3
            Me.trackBar3.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel20, trackBarLabel21, trackBarLabel22})
            Me.trackBar3.Properties.LargeChange = 1
            Me.trackBar3.Properties.Maximum = 3
            Me.trackBar3.Properties.Minimum = 1
            Me.trackBar3.Properties.ShowLabels = True
            Me.trackBar3.Size = New System.Drawing.Size(213, 72)
            Me.trackBar3.StyleController = Me.layoutControl
            Me.trackBar3.TabIndex = 14
            Me.trackBar3.Value = 1
            AddHandler Me.trackBar3.ValueChanged, New System.EventHandler(AddressOf Me.trackBar3_ValueChanged)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(14, 422)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(213, 22)
            Me.simpleButton1.StyleController = Me.layoutControl
            Me.simpleButton1.TabIndex = 15
            Me.simpleButton1.Text = "Generate Points"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup2, Me.layoutControlGroup5, Me.emptySpaceItem1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroupScale"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 66)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "General"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.comboBoxEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.Text = "Interval Division Mode:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 66)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(241, 122)
            Me.layoutControlGroup3.Text = "Width"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.trackBar1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(217, 76)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 188)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(241, 122)
            Me.layoutControlGroup4.Text = "Count"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.trackBar2
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(217, 76)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 458)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(241, 58)
            Me.layoutControlGroup2.Text = "Histogram Chart Type"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.radioGroup1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(217, 12)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem7})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 310)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(241, 148)
            Me.layoutControlGroup5.Text = "Series Count"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.trackBar3
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(217, 76)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.simpleButton1
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 76)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(217, 26)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 516)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(241, 22)
            ' 
            ' HistogramDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "HistogramDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBar3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private trackBar1 As DevExpress.XtraEditors.TrackBarControl

        Private trackBar2 As DevExpress.XtraEditors.TrackBarControl

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private trackBar3 As DevExpress.XtraEditors.TrackBarControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
