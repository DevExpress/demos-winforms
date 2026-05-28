Namespace DevExpress.XtraCharts.Demos

    Partial Class CustomDrawDemo

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.CustomDrawDemo))
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.dS51 = New DevExpress.XtraCharts.Demos.DS5()
            Me.oleDbAdapter = New System.Data.OleDb.OleDbDataAdapter()
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
            Me.oleDbConnection = New System.Data.OleDb.OleDbConnection()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.dS51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dS51
            ' 
            Me.dS51.DataSetName = "DS5"
            Me.dS51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' oleDbAdapter
            ' 
            Me.oleDbAdapter.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Photo", "Photo"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("Freight", "Freight")})})
            ' 
            ' oleDbSelectCommand1
            ' 
            Me.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText")
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram1.AxisX.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram1.AxisX.Title.Text = "Date"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.chart.Legend.HorizontalIndent = 16
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Padding.Bottom = 0
            Me.chart.Legend.Padding.Left = 10
            Me.chart.Legend.Padding.Right = 30
            Me.chart.Legend.Padding.Top = 0
            Me.chart.Legend.TextOffset = 8
            Me.chart.Legend.VerticalIndent = 8
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesDataMember = "LastName"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.ArgumentDataMember = "OrderDate"
            Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chart.SeriesTemplate.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            sideBySideBarSeriesLabel1.MaxLineCount = 2
            sideBySideBarSeriesLabel1.MaxWidth = 300
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.SeriesTemplate.SeriesDataMember = "LastName"
            Me.chart.SeriesTemplate.DateTimeSummaryOptions.SummaryFunction = "SUM([Freight])"
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 2
            chartTitle1.Text = "Sales Volume by Year"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.ObjectHotTracked, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chart_ObjectHotTracked)
            AddHandler Me.chart.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.chart_CustomDrawSeries)
            AddHandler Me.chart.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.chart_CustomDrawSeriesPoint)
            AddHandler Me.chart.CustomDrawAxisLabel, New DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(AddressOf Me.chart_CustomDrawAxisLabel)
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            AddHandler Me.chart.MouseLeave, New System.EventHandler(AddressOf Me.chart_MouseLeave)
            ' 
            ' CustomDrawDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "CustomDrawDemo"
            CType((Me.dS51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private dS51 As DevExpress.XtraCharts.Demos.DS5

        Private oleDbAdapter As System.Data.OleDb.OleDbDataAdapter

        Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand

        Private oleDbConnection As System.Data.OleDb.OleDbConnection

        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
