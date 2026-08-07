Namespace DevExpress.XtraCharts.Demos

    Partial Class SegmentColorizerDemo

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
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim keyColorColorizer1 As DevExpress.XtraCharts.KeyColorColorizer = New DevExpress.XtraCharts.KeyColorColorizer()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
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
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
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
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupTemperatureUnit)
            Me.layoutControl.Controls.Add(Me.radioGroupChartType)
            Me.layoutControl.Controls.Add(Me.radioGroupColorizerType)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupTemperatureUnit
            ' 
            Me.radioGroupTemperatureUnit.AutoSizeInLayoutControl = True
            Me.radioGroupTemperatureUnit.EditValue = "Fahrenheit"
            Me.radioGroupTemperatureUnit.Location = New System.Drawing.Point(14, 144)
            Me.radioGroupTemperatureUnit.Name = "radioGroupTemperatureUnit"
            Me.radioGroupTemperatureUnit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupTemperatureUnit.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupTemperatureUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupTemperatureUnit.Properties.Columns = 1
            Me.radioGroupTemperatureUnit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Fahrenheit", "Fahrenheit"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Celsius", "Celsius")})
            Me.radioGroupTemperatureUnit.Size = New System.Drawing.Size(213, 56)
            Me.radioGroupTemperatureUnit.StyleController = Me.layoutControl
            Me.radioGroupTemperatureUnit.TabIndex = 5
            AddHandler Me.radioGroupTemperatureUnit.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' radioGroupChartType
            ' 
            Me.radioGroupChartType.AutoSizeInLayoutControl = True
            Me.radioGroupChartType.Location = New System.Drawing.Point(12, 88)
            Me.radioGroupChartType.Name = "radioGroupChartType"
            Me.radioGroupChartType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupChartType.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupChartType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupChartType.Properties.Columns = 1
            Me.radioGroupChartType.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupChartType.StyleController = Me.layoutControl
            Me.radioGroupChartType.TabIndex = 4
            AddHandler Me.radioGroupChartType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupChartType_SelectedIndexChanged)
            ' 
            ' radioGroupColorizerType
            ' 
            Me.radioGroupColorizerType.AutoSizeInLayoutControl = True
            Me.radioGroupColorizerType.Location = New System.Drawing.Point(12, 34)
            Me.radioGroupColorizerType.Name = "radioGroupColorizerType"
            Me.radioGroupColorizerType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupColorizerType.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupColorizerType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupColorizerType.Properties.Columns = 1
            Me.radioGroupColorizerType.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupColorizerType.StyleController = Me.layoutControl
            Me.radioGroupColorizerType.TabIndex = 4
            AddHandler Me.radioGroupColorizerType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupColorizerType_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItemBottom, Me.layoutControlGroupChartType, Me.layoutControlGroupColorizerType, Me.layoutControlGroup1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItemBottom
            ' 
            Me.emptySpaceItemBottom.Location = New System.Drawing.Point(0, 214)
            Me.emptySpaceItemBottom.Name = "emptySpaceItem1"
            Me.emptySpaceItemBottom.Size = New System.Drawing.Size(241, 324)
            ' 
            ' layoutControlGroupChartType
            ' 
            Me.layoutControlGroupChartType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupChartType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemChartType})
            Me.layoutControlGroupChartType.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlGroupChartType.Name = "layoutControlGroupChartType"
            Me.layoutControlGroupChartType.Size = New System.Drawing.Size(241, 54)
            Me.layoutControlGroupChartType.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupChartType.Text = "Chart Type"
            ' 
            ' layoutControlItemChartType
            ' 
            Me.layoutControlItemChartType.Control = Me.radioGroupChartType
            Me.layoutControlItemChartType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemChartType.Name = "layoutControlItemChartType"
            Me.layoutControlItemChartType.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemChartType.TextVisible = False
            ' 
            ' layoutControlGroupColorizerType
            ' 
            Me.layoutControlGroupColorizerType.CustomizationFormText = "Chart Type"
            Me.layoutControlGroupColorizerType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupColorizerType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemChartType1})
            Me.layoutControlGroupColorizerType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupColorizerType.Name = "layoutControlGroupColorizerType"
            Me.layoutControlGroupColorizerType.Size = New System.Drawing.Size(241, 54)
            Me.layoutControlGroupColorizerType.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupColorizerType.Text = "Segment Colorizer Type"
            ' 
            ' layoutControlItemChartType1
            ' 
            Me.layoutControlItemChartType1.Control = Me.radioGroupColorizerType
            Me.layoutControlItemChartType1.CustomizationFormText = "layoutControlItemChartType"
            Me.layoutControlItemChartType1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemChartType1.Name = "layoutControlItemChartType1"
            Me.layoutControlItemChartType1.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemChartType1.Text = "layoutControlItemChartType"
            Me.layoutControlItemChartType1.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 108)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 106)
            Me.layoutControlGroup1.Text = "Temperature Unit"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.radioGroupTemperatureUnit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(217, 60)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.AxisX.Color = System.Drawing.Color.White
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:F1}°F"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chart.Legend.MaxVerticalPercentage = 30R
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Title.Text = "Products"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.PaletteRepository.Add("Temperature Palette", New DevExpress.XtraCharts.Palette("Temperature Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))), System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222))))))), System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194))))))), System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53))))))), System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((121)))))), (CInt(((CByte((5))))))), System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((121)))))), (CInt(((CByte((5)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((183)))))), (CInt(((CByte((0)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53))))))), System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((246)))))), (CInt(((CByte((53)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194))))))), System.Drawing.Color.FromArgb((CInt(((CByte((185)))))), (CInt(((CByte((222)))))), (CInt(((CByte((194)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222))))))), System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((202)))))), (CInt(((CByte((222)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((120)))))), (CInt(((CByte((176)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))), System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((40)))))), (CInt(((CByte((151))))))))}))
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            dataMember1.ColumnName = "Date"
            dataMember2.ColumnName = "Fahrenheit"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Date"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Color
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            series1.DataAdapter = dataSourceAdapter1
            series1.Name = "Series"
            series1.SeriesID = 0
            keyColorColorizer1.Keys.Add("January")
            keyColorColorizer1.Keys.Add("February")
            keyColorColorizer1.Keys.Add("March")
            keyColorColorizer1.Keys.Add("April")
            keyColorColorizer1.Keys.Add("May")
            keyColorColorizer1.Keys.Add("June")
            keyColorColorizer1.Keys.Add("July")
            keyColorColorizer1.Keys.Add("August")
            keyColorColorizer1.Keys.Add("September")
            keyColorColorizer1.Keys.Add("October")
            keyColorColorizer1.Keys.Add("November")
            keyColorColorizer1.Keys.Add("December")
            keyColorColorizer1.PaletteName = "Temperature Palette"
            lineSeriesView1.Colorizer = keyColorColorizer1
            lineSeriesView1.LineMarkerOptions.Size = 5
            series1.View = lineSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 3
            Me.chart.TabStop = False
            chartTitle1.Text = "Mean Daily Temperature"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chart)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 4
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' SegmentColorizerDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "SegmentColorizerDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
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
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
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
