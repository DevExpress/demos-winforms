Namespace DevExpress.XtraCharts.Demos

    Partial Class DataFilteringDemo

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
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim seriesTemplateAdapter1 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.filteringUIContext = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            CType((Me.filteringUIContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' filteringUIContext
            ' 
            Me.filteringUIContext.Client = Me.chart
            Me.filteringUIContext.Control = Me.accordionControl1
            AddHandler Me.filteringUIContext.QueryLookupData, New DevExpress.Utils.Filtering.QueryDataEventHandler(Of DevExpress.Utils.Filtering.QueryLookupDataEventArgs, DevExpress.Utils.Filtering.LookupData)(AddressOf Me.filteringUIContext_QueryLookupData)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.Title.Text = "Year"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "Sales, millions of USD"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V:$0.00}M"
            dataMember1.ColumnName = "Year"
            dataMember2.ColumnName = "Sales"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Company"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            seriesKeyColorColorizer1.Keys.Add("DevAV North")
            seriesKeyColorColorizer1.Keys.Add("DevAV Central")
            seriesKeyColorColorizer1.Keys.Add("DevAV South")
            seriesKeyColorColorizer1.Keys.Add("DevAV West")
            seriesKeyColorColorizer1.Keys.Add("DevAV East")
            Me.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chart.Size = New System.Drawing.Size(893, 714)
            Me.chart.TabIndex = 6
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            chartTitle1.Text = "Market Share Over Time"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple
            Me.accordionControl1.Location = New System.Drawing.Point(893, 0)
            Me.accordionControl1.MinimumSize = New System.Drawing.Size(300, 300)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ResizeMode = DevExpress.XtraBars.Navigation.AccordionControlResizeMode.OuterResizeZone
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.accordionControl1.Size = New System.Drawing.Size(300, 714)
            Me.accordionControl1.TabIndex = 7
            ' 
            ' DataFilteringDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Controls.Add(Me.accordionControl1)
            Me.Name = "DataFilteringDemo"
            Me.Size = New System.Drawing.Size(1193, 714)
            CType((Me.filteringUIContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private filteringUIContext As DevExpress.Utils.Filtering.FilteringUIContext

        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
