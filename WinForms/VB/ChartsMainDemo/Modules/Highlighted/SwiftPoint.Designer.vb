Namespace DevExpress.XtraCharts.Demos

    Partial Class SwiftPointDemo

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
            Dim swiftPlotDiagram1 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim swiftPointSeriesView1 As DevExpress.XtraCharts.SwiftPointSeriesView = New DevExpress.XtraCharts.SwiftPointSeriesView()
            Dim regressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupTemperatureUnit = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupChartType = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupColorizerType = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItemBottom = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupChartType = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemChartType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupColorizerType = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemChartType1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupTemperatureUnit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupChartType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupColorizerType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupChartType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemChartType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupColorizerType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemChartType1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((regressionLine1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupTemperatureUnit)
            Me.layoutControl.Controls.Add(Me.radioGroupChartType)
            Me.layoutControl.Controls.Add(Me.radioGroupColorizerType)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(362, 873)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupTemperatureUnit
            ' 
            Me.radioGroupTemperatureUnit.EditValue = "Fahrenheit"
            Me.radioGroupTemperatureUnit.Location = New System.Drawing.Point(14, 180)
            Me.radioGroupTemperatureUnit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.radioGroupTemperatureUnit.Name = "radioGroupTemperatureUnit"
            Me.radioGroupTemperatureUnit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupTemperatureUnit.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupTemperatureUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupTemperatureUnit.Properties.Columns = 1
            Me.radioGroupTemperatureUnit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Fahrenheit", "Fahrenheit"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Celsius", "Celsius")})
            Me.radioGroupTemperatureUnit.Size = New System.Drawing.Size(334, 130)
            Me.radioGroupTemperatureUnit.StyleController = Me.layoutControl
            Me.radioGroupTemperatureUnit.TabIndex = 5
            ' 
            ' radioGroupChartType
            ' 
            Me.radioGroupChartType.Location = New System.Drawing.Point(12, 106)
            Me.radioGroupChartType.Name = "radioGroupChartType"
            Me.radioGroupChartType.Size = New System.Drawing.Size(338, 26)
            Me.radioGroupChartType.StyleController = Me.layoutControl
            Me.radioGroupChartType.TabIndex = 6
            ' 
            ' radioGroupColorizerType
            ' 
            Me.radioGroupColorizerType.Location = New System.Drawing.Point(12, 34)
            Me.radioGroupColorizerType.Name = "radioGroupColorizerType"
            Me.radioGroupColorizerType.Size = New System.Drawing.Size(338, 26)
            Me.radioGroupColorizerType.StyleController = Me.layoutControl
            Me.radioGroupColorizerType.TabIndex = 7
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItemBottom, Me.layoutControlGroupChartType, Me.layoutControlGroupColorizerType, Me.layoutControlGroup1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(362, 873)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItemBottom
            ' 
            Me.emptySpaceItemBottom.Location = New System.Drawing.Point(0, 324)
            Me.emptySpaceItemBottom.Name = "emptySpaceItem1"
            Me.emptySpaceItemBottom.Size = New System.Drawing.Size(362, 549)
            ' 
            ' layoutControlGroupChartType
            ' 
            Me.layoutControlGroupChartType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupChartType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemChartType})
            Me.layoutControlGroupChartType.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlGroupChartType.Name = "layoutControlGroupChartType"
            Me.layoutControlGroupChartType.Size = New System.Drawing.Size(362, 72)
            Me.layoutControlGroupChartType.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupChartType.Text = "Chart Type"
            ' 
            ' layoutControlItemChartType
            ' 
            Me.layoutControlItemChartType.Control = Me.radioGroupChartType
            Me.layoutControlItemChartType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemChartType.Name = "layoutControlItemChartType"
            Me.layoutControlItemChartType.Size = New System.Drawing.Size(342, 30)
            Me.layoutControlItemChartType.TextVisible = False
            ' 
            ' layoutControlGroupColorizerType
            ' 
            Me.layoutControlGroupColorizerType.CustomizationFormText = "Chart Type"
            Me.layoutControlGroupColorizerType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupColorizerType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemChartType1})
            Me.layoutControlGroupColorizerType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupColorizerType.Name = "layoutControlGroupColorizerType"
            Me.layoutControlGroupColorizerType.Size = New System.Drawing.Size(362, 72)
            Me.layoutControlGroupColorizerType.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupColorizerType.Text = "Segment Colorizer Type"
            ' 
            ' layoutControlItemChartType1
            ' 
            Me.layoutControlItemChartType1.Control = Me.radioGroupColorizerType
            Me.layoutControlItemChartType1.CustomizationFormText = "layoutControlItemChartType"
            Me.layoutControlItemChartType1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemChartType1.Name = "layoutControlItemChartType1"
            Me.layoutControlItemChartType1.Size = New System.Drawing.Size(342, 30)
            Me.layoutControlItemChartType1.Text = "layoutControlItemChartType"
            Me.layoutControlItemChartType1.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(362, 180)
            Me.layoutControlGroup1.Text = "Temperature Unit"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.radioGroupTemperatureUnit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(338, 134)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[Default]
            Me.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            Me.chart.CrosshairOptions.ShowValueLabels = True
            Me.chart.CrosshairOptions.ShowValueLine = True
            swiftPlotDiagram1.AxisX.CrosshairAxisLabelOptions.Pattern = "{A:N0}"
            swiftPlotDiagram1.AxisX.GridLines.Visible = True
            swiftPlotDiagram1.AxisX.Title.Tag = ""
            swiftPlotDiagram1.AxisX.Title.Text = "House Area in ft<sup>2</sup>"
            swiftPlotDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.AxisY.Label.TextPattern = "{V:0,.}"
            swiftPlotDiagram1.AxisY.Title.Text = "Price in Thousands of Dollars "
            swiftPlotDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.EnableAxisXScrolling = True
            swiftPlotDiagram1.EnableAxisXZooming = True
            swiftPlotDiagram1.EnableAxisYScrolling = True
            swiftPlotDiagram1.EnableAxisYZooming = True
            Me.chart.Diagram = swiftPlotDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.PaletteRepository.Add("Temperature Palette", New DevExpress.XtraCharts.Palette("Temperature Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))), System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222))))))), System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194))))))), System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53))))))), System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((121)))))), (CInt(((CByte((5))))))), System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((121)))))), (CInt(((CByte((5)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53))))))), System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194))))))), System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222))))))), System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))), System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))))}))
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument
            series1.CrosshairLabelPattern = "{A:N0}ft<sup>2</sup> : {V:$0}"
            series1.Name = "Houses"
            series1.SeriesID = 0
            regressionLine1.CrosshairLabelPattern = "{A:N0}ft<sup>2</sup> : {V:$0}"
            regressionLine1.IndicatorID = 0
            regressionLine1.Name = "Regression"
            regressionLine1.ShowInLegend = True
            swiftPointSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {regressionLine1})
            series1.View = swiftPointSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 3
            Me.chart.TabStop = False
            chartTitle1.Text = "House Sale Prices"
            chartTitle1.TitleID = 0
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle2.Text = "Point Count: 100000"
            chartTitle2.TitleID = 1
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chart)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(784, 432)
            Me.sidePanel1.TabIndex = 4
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' SwiftPointDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "SwiftPointDemo"
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupTemperatureUnit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupChartType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupColorizerType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupChartType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemChartType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupColorizerType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemChartType1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((regressionLine1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((swiftPointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private radioGroupChartType As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItemBottom As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupChartType As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemChartType As DevExpress.XtraLayout.LayoutControlItem

        Private radioGroupColorizerType As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupColorizerType As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemChartType1 As DevExpress.XtraLayout.LayoutControlItem

        Private chart As DevExpress.XtraCharts.ChartControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private radioGroupTemperatureUnit As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
