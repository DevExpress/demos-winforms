Namespace DevExpress.XtraCharts.Demos

    Partial Class AxesAndSeriesLabelsDemo

        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim customAxisLabel1 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel2 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel3 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.466424R, New Object() {(CObj((-28.2R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.486035R, New Object() {(CObj((-25.4R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.505635R, New Object() {(CObj((-23.4R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.525235R, New Object() {(CObj((-22.4R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.544851R, New Object() {(CObj((-21R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.564458R, New Object() {(CObj((-19.7R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.584058R, New Object() {(CObj((-15.9R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.603669R, New Object() {(CObj((-15.3R)))})
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.623269R, New Object() {(CObj((-15.3R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.64288R, New Object() {(CObj((-18.9R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.66249R, New Object() {(CObj((-21.1R)))})
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.682092R, New Object() {(CObj((-23.2R)))})
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.701703R, New Object() {(CObj((-26.9R)))})
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.721314R, New Object() {(CObj((-30.8R)))})
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.760537R, New Object() {(CObj((-43.8R)))})
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.780148R, New Object() {(CObj((-45.7R)))})
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.79976R, New Object() {(CObj((-49.1R)))})
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.819371R, New Object() {(CObj((-51.5R)))})
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.838982R, New Object() {(CObj((-55.5R)))})
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.858594R, New Object() {(CObj((-57.5R)))})
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.878205R, New Object() {(CObj((-61R)))})
            Dim seriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.897816R, New Object() {(CObj((-61.1R)))})
            Dim seriesPoint23 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.917428R, New Object() {(CObj((-64.5R)))})
            Dim seriesPoint24 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.937039R, New Object() {(CObj((-64.9R)))})
            Dim seriesPoint25 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2.976262R, New Object() {(CObj((-67.8R)))})
            Dim seriesPoint26 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.035084R, New Object() {(CObj((-69.3R)))})
            Dim seriesPoint27 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.074307R, New Object() {(CObj((-70.4R)))})
            Dim seriesPoint28 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.093918R, New Object() {(CObj((-71.3R)))})
            Dim seriesPoint29 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.11353R, New Object() {(CObj((-71.9R)))})
            Dim seriesPoint30 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.191964R, New Object() {(CObj((-75R)))})
            Dim seriesPoint31 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3.211575R, New Object() {(CObj((-76R)))})
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.spinEditAxisLabelsMinIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditAllowStaggerAxisLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditAllowRotateAxisLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditAllowHideAxisLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditSeriesLabelsMinIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditAxisXLabelsPattern = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditSeriesLabelsPattern = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEditShowCustomLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditCustomLabelsMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupAxisXResolveOverlappingOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemAxisLabelsMinIndent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAllowRotateAxisLabels = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAllowStaggerAxisLabels = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAllowHideAxisLabels = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesLabelResolveOverlappingMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupDisplayPatterns = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesLabelsPattern = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAxisXLabelsPattern = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupCustomLabelsOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemShowCustomLabels = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemCustomLabelsMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.spinEditAxisLabelsMinIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowStaggerAxisLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowRotateAxisLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowHideAxisLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditSeriesLabelsMinIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditAxisXLabelsPattern.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSeriesLabelsPattern.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowCustomLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditCustomLabelsMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupAxisXResolveOverlappingOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAxisLabelsMinIndent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAllowRotateAxisLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAllowStaggerAxisLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAllowHideAxisLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesLabelResolveOverlappingMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupDisplayPatterns), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesLabelsPattern), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAxisXLabelsPattern), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCustomLabelsOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowCustomLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemCustomLabelsMode), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(719, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(285, 571)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(284, 571)
            Me.tabPaneOptions.Size = New System.Drawing.Size(284, 571)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(284, 538)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom
            xyDiagram1.AxisX.MinorCount = 9
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.NumericScaleOptions.CustomGridAlignment = 0.025R
            xyDiagram1.AxisX.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Custom
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.Title.Text = "Sol"
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0.01R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0.01R
            customAxisLabel1.AxisValueSerializable = "-15.3"
            customAxisLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            customAxisLabel1.Name = "-15.3"
            customAxisLabel1.TextColor = System.Drawing.Color.Red
            customAxisLabel2.AxisValueSerializable = "-76"
            customAxisLabel2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            customAxisLabel2.Name = "-76.0"
            customAxisLabel2.TextColor = System.Drawing.Color.DodgerBlue
            customAxisLabel3.AxisValueSerializable = "-45.65"
            customAxisLabel3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            customAxisLabel3.Name = "-45.7"
            customAxisLabel3.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((128)))))), (CInt(((CByte((0)))))))
            xyDiagram1.AxisY.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel1, customAxisLabel2, customAxisLabel3})
            xyDiagram1.AxisY.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 10R
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.Title.Text = "Temperature, in degrees Celsius"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.LabelsResolveOverlappingMinIndent = 3
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Margins.Bottom = 10
            Me.chart.Legend.Margins.Left = 10
            Me.chart.Legend.Margins.Right = 10
            Me.chart.Legend.Margins.Top = 10
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel1.LineLength = 15
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint
            pointSeriesLabel1.TextPattern = "{V:F1}°C"
            series1.Label = pointSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Name = "Mars Temperature"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31})
            series1.SeriesID = 0
            lineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
            series1.View = lineSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.SeriesTemplate.View = lineSeriesView2
            Me.chart.Size = New System.Drawing.Size(719, 571)
            Me.chart.TabIndex = 3
            Me.chart.TabStop = False
            chartTitle1.Text = "Mars Pathfinder Temperature Data"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www-k12.atmos.washington.edu/k12"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.spinEditAxisLabelsMinIndent)
            Me.layoutControl.Controls.Add(Me.checkEditAllowStaggerAxisLabels)
            Me.layoutControl.Controls.Add(Me.checkEditAllowRotateAxisLabels)
            Me.layoutControl.Controls.Add(Me.checkEditAllowHideAxisLabels)
            Me.layoutControl.Controls.Add(Me.comboBoxEditSeriesLabelsResolveOverlappingMode)
            Me.layoutControl.Controls.Add(Me.spinEditSeriesLabelsMinIndent)
            Me.layoutControl.Controls.Add(Me.comboBoxEditAxisXLabelsPattern)
            Me.layoutControl.Controls.Add(Me.comboBoxEditSeriesLabelsPattern)
            Me.layoutControl.Controls.Add(Me.checkEditShowCustomLabels)
            Me.layoutControl.Controls.Add(Me.comboBoxEditCustomLabelsMode)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(284, 538)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' spinEditAxisLabelsMinIndent
            ' 
            Me.spinEditAxisLabelsMinIndent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditAxisLabelsMinIndent.Location = New System.Drawing.Point(94, 34)
            Me.spinEditAxisLabelsMinIndent.Name = "spinEditAxisLabelsMinIndent"
            Me.spinEditAxisLabelsMinIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditAxisLabelsMinIndent.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditAxisLabelsMinIndent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditAxisLabelsMinIndent.Properties.IsFloatValue = False
            Me.spinEditAxisLabelsMinIndent.Properties.Mask.EditMask = "N00"
            Me.spinEditAxisLabelsMinIndent.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditAxisLabelsMinIndent.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, -2147483648})
            Me.spinEditAxisLabelsMinIndent.Size = New System.Drawing.Size(178, 20)
            Me.spinEditAxisLabelsMinIndent.StyleController = Me.layoutControl
            Me.spinEditAxisLabelsMinIndent.TabIndex = 4
            AddHandler Me.spinEditAxisLabelsMinIndent.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditAxisLabelsMinIndent_EditValueChanged)
            ' 
            ' checkEditAllowStaggerAxisLabels
            ' 
            Me.checkEditAllowStaggerAxisLabels.Location = New System.Drawing.Point(12, 58)
            Me.checkEditAllowStaggerAxisLabels.Name = "checkEditAllowStaggerAxisLabels"
            Me.checkEditAllowStaggerAxisLabels.Properties.Caption = "Allow Stagger"
            Me.checkEditAllowStaggerAxisLabels.Size = New System.Drawing.Size(260, 20)
            Me.checkEditAllowStaggerAxisLabels.StyleController = Me.layoutControl
            Me.checkEditAllowStaggerAxisLabels.TabIndex = 5
            AddHandler Me.checkEditAllowStaggerAxisLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAllowStaggerAxisLabels_CheckedChanged)
            ' 
            ' checkEditAllowRotateAxisLabels
            ' 
            Me.checkEditAllowRotateAxisLabels.Location = New System.Drawing.Point(12, 82)
            Me.checkEditAllowRotateAxisLabels.Name = "checkEditAllowRotateAxisLabels"
            Me.checkEditAllowRotateAxisLabels.Properties.Caption = "Allow Rotate"
            Me.checkEditAllowRotateAxisLabels.Size = New System.Drawing.Size(260, 20)
            Me.checkEditAllowRotateAxisLabels.StyleController = Me.layoutControl
            Me.checkEditAllowRotateAxisLabels.TabIndex = 6
            AddHandler Me.checkEditAllowRotateAxisLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAllowRotateAxisLabels_CheckedChanged)
            ' 
            ' checkEditAllowHideAxisLabels
            ' 
            Me.checkEditAllowHideAxisLabels.Location = New System.Drawing.Point(12, 106)
            Me.checkEditAllowHideAxisLabels.Name = "checkEditAllowHideAxisLabels"
            Me.checkEditAllowHideAxisLabels.Properties.Caption = "Allow Hide"
            Me.checkEditAllowHideAxisLabels.Size = New System.Drawing.Size(260, 20)
            Me.checkEditAllowHideAxisLabels.StyleController = Me.layoutControl
            Me.checkEditAllowHideAxisLabels.TabIndex = 7
            AddHandler Me.checkEditAllowHideAxisLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAllowHideAxisLabels_CheckedChanged)
            ' 
            ' comboBoxEditSeriesLabelsResolveOverlappingMode
            ' 
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Location = New System.Drawing.Point(94, 196)
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Name = "comboBoxEditSeriesLabelsResolveOverlappingMode"
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Properties.Items.AddRange(New Object() {"None", "Default", "Hide Overlapped", "Justify Around Point", "Justify All Around Point"})
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Size = New System.Drawing.Size(178, 20)
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.StyleController = Me.layoutControl
            Me.comboBoxEditSeriesLabelsResolveOverlappingMode.TabIndex = 8
            AddHandler Me.comboBoxEditSeriesLabelsResolveOverlappingMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesLabelsResolveOverlappingMode_SelectedIndexChanged)
            ' 
            ' spinEditSeriesLabelsMinIndent
            ' 
            Me.spinEditSeriesLabelsMinIndent.EditValue = New Decimal(New Integer() {3, 0, 0, -2147483648})
            Me.spinEditSeriesLabelsMinIndent.Location = New System.Drawing.Point(94, 172)
            Me.spinEditSeriesLabelsMinIndent.Name = "spinEditSeriesLabelsMinIndent"
            Me.spinEditSeriesLabelsMinIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditSeriesLabelsMinIndent.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditSeriesLabelsMinIndent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditSeriesLabelsMinIndent.Properties.IsFloatValue = False
            Me.spinEditSeriesLabelsMinIndent.Properties.Mask.EditMask = "N00"
            Me.spinEditSeriesLabelsMinIndent.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditSeriesLabelsMinIndent.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, -2147483648})
            Me.spinEditSeriesLabelsMinIndent.Size = New System.Drawing.Size(178, 20)
            Me.spinEditSeriesLabelsMinIndent.StyleController = Me.layoutControl
            Me.spinEditSeriesLabelsMinIndent.TabIndex = 9
            AddHandler Me.spinEditSeriesLabelsMinIndent.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditSeriesLabelsMinIndent_EditValueChanged)
            ' 
            ' comboBoxEditAxisXLabelsPattern
            ' 
            Me.comboBoxEditAxisXLabelsPattern.Location = New System.Drawing.Point(94, 262)
            Me.comboBoxEditAxisXLabelsPattern.Name = "comboBoxEditAxisXLabelsPattern"
            Me.comboBoxEditAxisXLabelsPattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditAxisXLabelsPattern.Properties.Items.AddRange(New Object() {"{A}", "{A:0.000}", "{A:0.0##}", "{A:0.##}", "{A:0.###} Sol"})
            Me.comboBoxEditAxisXLabelsPattern.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditAxisXLabelsPattern.Size = New System.Drawing.Size(178, 20)
            Me.comboBoxEditAxisXLabelsPattern.StyleController = Me.layoutControl
            Me.comboBoxEditAxisXLabelsPattern.TabIndex = 10
            AddHandler Me.comboBoxEditAxisXLabelsPattern.TextChanged, New System.EventHandler(AddressOf Me.comboBoxEditAxisXLabelsPattern_TextChanged)
            ' 
            ' comboBoxEditSeriesLabelsPattern
            ' 
            Me.comboBoxEditSeriesLabelsPattern.Location = New System.Drawing.Point(94, 286)
            Me.comboBoxEditSeriesLabelsPattern.Name = "comboBoxEditSeriesLabelsPattern"
            Me.comboBoxEditSeriesLabelsPattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesLabelsPattern.Properties.Items.AddRange(New Object() {"{V}°C", "{A:0.#} Sol: {V:0.#}°C", "{A:0.#}: {V:0.#}°C", "{S}: {A:0.#}: {V:0.#}°C", "{A}: {V}°C"})
            Me.comboBoxEditSeriesLabelsPattern.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesLabelsPattern.Size = New System.Drawing.Size(178, 20)
            Me.comboBoxEditSeriesLabelsPattern.StyleController = Me.layoutControl
            Me.comboBoxEditSeriesLabelsPattern.TabIndex = 11
            AddHandler Me.comboBoxEditSeriesLabelsPattern.TextChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesLabelsPattern_TextChanged)
            ' 
            ' checkEditShowCustomLabels
            ' 
            Me.checkEditShowCustomLabels.Location = New System.Drawing.Point(12, 352)
            Me.checkEditShowCustomLabels.Name = "checkEditShowCustomLabels"
            Me.checkEditShowCustomLabels.Properties.Caption = "Show Custom Labels"
            Me.checkEditShowCustomLabels.Size = New System.Drawing.Size(260, 20)
            Me.checkEditShowCustomLabels.StyleController = Me.layoutControl
            Me.checkEditShowCustomLabels.TabIndex = 12
            AddHandler Me.checkEditShowCustomLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowCustomLabels_CheckedChanged)
            ' 
            ' comboBoxEditCustomLabelsMode
            ' 
            Me.comboBoxEditCustomLabelsMode.Location = New System.Drawing.Point(94, 376)
            Me.comboBoxEditCustomLabelsMode.Name = "comboBoxEditCustomLabelsMode"
            Me.comboBoxEditCustomLabelsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditCustomLabelsMode.Properties.Items.AddRange(New Object() {"Custom only", "Auto and Custom"})
            Me.comboBoxEditCustomLabelsMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditCustomLabelsMode.Size = New System.Drawing.Size(178, 20)
            Me.comboBoxEditCustomLabelsMode.StyleController = Me.layoutControl
            Me.comboBoxEditCustomLabelsMode.TabIndex = 13
            AddHandler Me.comboBoxEditCustomLabelsMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditCustomLabelsMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem, Me.layoutControlGroupAxisXResolveOverlappingOptions, Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions, Me.layoutControlGroupDisplayPatterns, Me.layoutControlGroupCustomLabelsOptions})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(284, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 408)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(284, 130)
            ' 
            ' layoutControlGroupAxisXResolveOverlappingOptions
            ' 
            Me.layoutControlGroupAxisXResolveOverlappingOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemAxisLabelsMinIndent, Me.layoutControlItemAllowRotateAxisLabels, Me.layoutControlItemAllowStaggerAxisLabels, Me.layoutControlItemAllowHideAxisLabels})
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Name = "layoutControlGroupAxisXResolveOverlappingOptions"
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Size = New System.Drawing.Size(284, 138)
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupAxisXResolveOverlappingOptions.Text = "Axis X Labels' Resolve Overlapping Options"
            ' 
            ' layoutControlItemAxisLabelsMinIndent
            ' 
            Me.layoutControlItemAxisLabelsMinIndent.Control = Me.spinEditAxisLabelsMinIndent
            Me.layoutControlItemAxisLabelsMinIndent.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemAxisLabelsMinIndent.Name = "layoutControlItemAxisLabelsMinIndent"
            Me.layoutControlItemAxisLabelsMinIndent.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemAxisLabelsMinIndent.Text = "Min Indent: "
            Me.layoutControlItemAxisLabelsMinIndent.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItemAllowRotateAxisLabels
            ' 
            Me.layoutControlItemAllowRotateAxisLabels.Control = Me.checkEditAllowRotateAxisLabels
            Me.layoutControlItemAllowRotateAxisLabels.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAllowRotateAxisLabels.Name = "layoutControlItemAllowRotateAxisLabels"
            Me.layoutControlItemAllowRotateAxisLabels.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemAllowRotateAxisLabels.TextVisible = False
            ' 
            ' layoutControlItemAllowStaggerAxisLabels
            ' 
            Me.layoutControlItemAllowStaggerAxisLabels.Control = Me.checkEditAllowStaggerAxisLabels
            Me.layoutControlItemAllowStaggerAxisLabels.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemAllowStaggerAxisLabels.Name = "layoutControlItemAllowStaggerAxisLabels"
            Me.layoutControlItemAllowStaggerAxisLabels.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemAllowStaggerAxisLabels.TextVisible = False
            ' 
            ' layoutControlItemAllowHideAxisLabels
            ' 
            Me.layoutControlItemAllowHideAxisLabels.Control = Me.checkEditAllowHideAxisLabels
            Me.layoutControlItemAllowHideAxisLabels.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemAllowHideAxisLabels.Name = "layoutControlItemAllowHideAxisLabels"
            Me.layoutControlItemAllowHideAxisLabels.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemAllowHideAxisLabels.TextVisible = False
            ' 
            ' layoutControlGroupSeriesLabelsResolveOverlappingOptions
            ' 
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesLabelResolveOverlappingMode, Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent})
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Location = New System.Drawing.Point(0, 138)
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Name = "layoutControlGroupSeriesLabelsResolveOverlappingOptions"
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Size = New System.Drawing.Size(284, 90)
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions.Text = "Series Labels' Resolve Overlapping Options"
            ' 
            ' layoutControlItemSeriesLabelResolveOverlappingMode
            ' 
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.Control = Me.comboBoxEditSeriesLabelsResolveOverlappingMode
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.Name = "layoutControlItemSeriesLabelResolveOverlappingMode"
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.Text = "Mode:"
            Me.layoutControlItemSeriesLabelResolveOverlappingMode.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItemSeriesLabelsResolveOverlappingMinIndent
            ' 
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.Control = Me.spinEditSeriesLabelsMinIndent
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.Name = "layoutControlItemSeriesLabelsResolveOverlappingMinIndent"
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.Text = "Min Indent:"
            Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlGroupDisplayPatterns
            ' 
            Me.layoutControlGroupDisplayPatterns.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupDisplayPatterns.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesLabelsPattern, Me.layoutControlItemAxisXLabelsPattern})
            Me.layoutControlGroupDisplayPatterns.Location = New System.Drawing.Point(0, 228)
            Me.layoutControlGroupDisplayPatterns.Name = "layoutControlGroupDisplayPatterns"
            Me.layoutControlGroupDisplayPatterns.Size = New System.Drawing.Size(284, 90)
            Me.layoutControlGroupDisplayPatterns.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupDisplayPatterns.Text = "Label Patterns"
            ' 
            ' layoutControlItemSeriesLabelsPattern
            ' 
            Me.layoutControlItemSeriesLabelsPattern.Control = Me.comboBoxEditSeriesLabelsPattern
            Me.layoutControlItemSeriesLabelsPattern.CustomizationFormText = "layoutControlItemSeriesLabelsPattern"
            Me.layoutControlItemSeriesLabelsPattern.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemSeriesLabelsPattern.Name = "layoutControlItemSeriesLabelsPattern"
            Me.layoutControlItemSeriesLabelsPattern.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemSeriesLabelsPattern.Text = "Series:"
            Me.layoutControlItemSeriesLabelsPattern.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItemAxisXLabelsPattern
            ' 
            Me.layoutControlItemAxisXLabelsPattern.Control = Me.comboBoxEditAxisXLabelsPattern
            Me.layoutControlItemAxisXLabelsPattern.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemAxisXLabelsPattern.Name = "layoutControlItemAxisXLabelsPattern"
            Me.layoutControlItemAxisXLabelsPattern.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemAxisXLabelsPattern.Text = "X-Axis:"
            Me.layoutControlItemAxisXLabelsPattern.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlGroupCustomLabelsOptions
            ' 
            Me.layoutControlGroupCustomLabelsOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCustomLabelsOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemShowCustomLabels, Me.layoutControlItemCustomLabelsMode})
            Me.layoutControlGroupCustomLabelsOptions.Location = New System.Drawing.Point(0, 318)
            Me.layoutControlGroupCustomLabelsOptions.Name = "layoutControlGroupCustomLabelsOptions"
            Me.layoutControlGroupCustomLabelsOptions.Size = New System.Drawing.Size(284, 90)
            Me.layoutControlGroupCustomLabelsOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupCustomLabelsOptions.Text = "Axis Y Custom Labels Options"
            ' 
            ' layoutControlItemShowCustomLabels
            ' 
            Me.layoutControlItemShowCustomLabels.Control = Me.checkEditShowCustomLabels
            Me.layoutControlItemShowCustomLabels.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemShowCustomLabels.Name = "layoutControlItemShowCustomLabels"
            Me.layoutControlItemShowCustomLabels.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemShowCustomLabels.TextVisible = False
            ' 
            ' layoutControlItemCustomLabelsMode
            ' 
            Me.layoutControlItemCustomLabelsMode.Control = Me.comboBoxEditCustomLabelsMode
            Me.layoutControlItemCustomLabelsMode.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemCustomLabelsMode.Name = "layoutControlItemCustomLabelsMode"
            Me.layoutControlItemCustomLabelsMode.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItemCustomLabelsMode.Text = "Visibility Mode:"
            Me.layoutControlItemCustomLabelsMode.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' AxesAndSeriesLabelsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "AxesAndSeriesLabelsDemo"
            Me.Size = New System.Drawing.Size(1004, 571)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.spinEditAxisLabelsMinIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowStaggerAxisLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowRotateAxisLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowHideAxisLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSeriesLabelsResolveOverlappingMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditSeriesLabelsMinIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditAxisXLabelsPattern.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSeriesLabelsPattern.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowCustomLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditCustomLabelsMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupAxisXResolveOverlappingOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAxisLabelsMinIndent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAllowRotateAxisLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAllowStaggerAxisLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAllowHideAxisLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupSeriesLabelsResolveOverlappingOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesLabelResolveOverlappingMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesLabelsResolveOverlappingMinIndent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupDisplayPatterns), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesLabelsPattern), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAxisXLabelsPattern), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCustomLabelsOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowCustomLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemCustomLabelsMode), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private spinEditAxisLabelsMinIndent As DevExpress.XtraEditors.SpinEdit

        Private checkEditAllowStaggerAxisLabels As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowRotateAxisLabels As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowHideAxisLabels As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupAxisXResolveOverlappingOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemAxisLabelsMinIndent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAllowRotateAxisLabels As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAllowStaggerAxisLabels As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAllowHideAxisLabels As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditSeriesLabelsResolveOverlappingMode As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditSeriesLabelsMinIndent As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemSeriesLabelResolveOverlappingMode As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemSeriesLabelsResolveOverlappingMinIndent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupSeriesLabelsResolveOverlappingOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private comboBoxEditAxisXLabelsPattern As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditSeriesLabelsPattern As DevExpress.XtraEditors.ComboBoxEdit

        Private checkEditShowCustomLabels As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditCustomLabelsMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupDisplayPatterns As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemSeriesLabelsPattern As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAxisXLabelsPattern As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupCustomLabelsOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemShowCustomLabels As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemCustomLabelsMode As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
