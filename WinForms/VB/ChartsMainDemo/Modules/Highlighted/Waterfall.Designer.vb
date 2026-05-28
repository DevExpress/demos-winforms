Namespace DevExpress.XtraCharts.Demos

    Partial Class WaterfallDemo

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
            Dim customAxisLabel4 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel5 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim seriesTemplateAdapter1 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim waterfallSeriesLabel1 As DevExpress.XtraCharts.WaterfallSeriesLabel = New DevExpress.XtraCharts.WaterfallSeriesLabel()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Dim waterfallSeriesView1 As DevExpress.XtraCharts.WaterfallSeriesView = New DevExpress.XtraCharts.WaterfallSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim waterfallRelativeValueOptions1 As DevExpress.XtraCharts.WaterfallRelativeValueOptions = New DevExpress.XtraCharts.WaterfallRelativeValueOptions()
            Dim subtotal1 As DevExpress.XtraCharts.Subtotal = New DevExpress.XtraCharts.Subtotal()
            Dim subtotal2 As DevExpress.XtraCharts.Subtotal = New DevExpress.XtraCharts.Subtotal()
            Dim subtotal3 As DevExpress.XtraCharts.Subtotal = New DevExpress.XtraCharts.Subtotal()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupDataView = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((waterfallSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((waterfallSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupDataView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            customAxisLabel1.AxisValueSerializable = "1989"
            customAxisLabel1.Name = "1989"
            customAxisLabel2.AxisValueSerializable = "Kyoto Protocol Adopted"
            customAxisLabel2.Name = "1997" & Global.Microsoft.VisualBasic.Constants.vbLf & "Kyoto Protocol"
            customAxisLabel3.AxisValueSerializable = "Clean Development Mechanism Opens"
            customAxisLabel3.Name = "2006" & Global.Microsoft.VisualBasic.Constants.vbLf & "Clean Development Mechanism Opens"
            customAxisLabel4.AxisValueSerializable = "Paris Agreement Adopted"
            customAxisLabel4.Name = "2016" & Global.Microsoft.VisualBasic.Constants.vbLf & "Paris Agreement"
            customAxisLabel5.AxisValueSerializable = "2020"
            customAxisLabel5.Name = "2020"
            xyDiagram1.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel1, customAxisLabel2, customAxisLabel3, customAxisLabel4, customAxisLabel5})
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "Emissions and Sinks, BtC"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((68)))))), (CInt(((CByte((108))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((68)))))), (CInt(((CByte((108)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((88)))))), (CInt(((CByte((89))))))), System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((88)))))), (CInt(((CByte((89)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((220)))))), (CInt(((CByte((255))))))), System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((220)))))), (CInt(((CByte((255)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((131)))))), (CInt(((CByte((213))))))), System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((131)))))), (CInt(((CByte((213)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((146)))))), (CInt(((CByte((206)))))), (CInt(((CByte((181))))))), System.Drawing.Color.FromArgb((CInt(((CByte((146)))))), (CInt(((CByte((206)))))), (CInt(((CByte((181)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((155)))))), (CInt(((CByte((136))))))), System.Drawing.Color.FromArgb((CInt(((CByte((109)))))), (CInt(((CByte((155)))))), (CInt(((CByte((136))))))))}))
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            dataMember1.ColumnName = "Year"
            dataMember1.ScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            dataMember2.ColumnName = "CalculatedContribution"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Factor"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            waterfallSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.SeriesTemplate.Label = waterfallSeriesLabel1
            seriesKeyColorColorizer1.Keys.Add("Fuel/Industry")
            seriesKeyColorColorizer1.Keys.Add("Land-Use Emissions")
            seriesKeyColorColorizer1.Keys.Add("Atmospheric Growth")
            seriesKeyColorColorizer1.Keys.Add("Ocean Sink")
            seriesKeyColorColorizer1.Keys.Add("Land Sink")
            seriesKeyColorColorizer1.Keys.Add("Cement Carbonation Sink")
            seriesKeyColorColorizer1.PaletteName = "Palette 1"
            Me.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            waterfallSeriesView1.FallingBarColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((64)))))), (CInt(((CByte((0)))))))
            waterfallSeriesView1.RisingBarColor = System.Drawing.Color.Red
            Me.chart.SeriesTemplate.View = waterfallSeriesView1
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "Global Carbon Balance"
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            chartTitle2.Text = "From globalcarbonproject.org"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            waterfallRelativeValueOptions1.StartBarLabel = "1989"
            waterfallRelativeValueOptions1.StartBarValue = 2766R
            subtotal1.Label = "Kyoto Protocol Adopted"
            subtotal1.PointIndex = 7
            subtotal2.Label = "Clean Development Mechanism Opens"
            subtotal2.PointIndex = 16
            subtotal3.Label = "Paris Agreement Adopted"
            subtotal3.PointIndex = 26
            waterfallRelativeValueOptions1.Subtotals.AddRange(New DevExpress.XtraCharts.Subtotal() {subtotal1, subtotal2, subtotal3})
            waterfallRelativeValueOptions1.TotalLabel = "2020"
            Me.chart.WaterfallValueOptions = waterfallRelativeValueOptions1
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupDataView)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 135, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupDataView
            ' 
            Me.radioGroupDataView.AutoSizeInLayoutControl = True
            Me.radioGroupDataView.EditValue = "Fahrenheit"
            Me.radioGroupDataView.Location = New System.Drawing.Point(12, 34)
            Me.radioGroupDataView.Name = "radioGroupDataView"
            Me.radioGroupDataView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupDataView.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupDataView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupDataView.Properties.Columns = 1
            Me.radioGroupDataView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("AggregatedData", "Aggregated Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem("DetailedData", "Detailed Data")})
            Me.radioGroupDataView.Size = New System.Drawing.Size(217, 56)
            Me.radioGroupDataView.StyleController = Me.layoutControl
            Me.radioGroupDataView.TabIndex = 6
            AddHandler Me.radioGroupDataView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupTemperatureUnit_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.emptySpaceItem})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 102)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.radioGroupDataView
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 60)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 102)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 436)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' WaterfallDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "WaterfallDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((waterfallSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((waterfallSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupDataView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private radioGroupDataView As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
