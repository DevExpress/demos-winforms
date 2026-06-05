Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.PivotGridAndChart

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim stackedSplineAreaSeriesView1 As DevExpress.XtraCharts.StackedSplineAreaSeriesView = New DevExpress.XtraCharts.StackedSplineAreaSeriesView()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.PivotGridAndChart.Report))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrChart = New DevExpress.XtraReports.UI.XRChart()
            Me.xrPivotGrid = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.pgfSalesPerson = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfSalesTotal = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfYear = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfQuarter = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.xpiPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xpbDevExpress = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrlTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.CategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.parameterViewType = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterShowLabels = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterGenerateSeriesFromColumns = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterShowRowGrandTotals = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterShowColumnGrandTotals = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrChart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedSplineAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.Transparent
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart, Me.xrPivotGrid})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
            Me.Detail.HeightF = 592F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xpiPageCount})
            Me.BottomMargin.HeightF = 87F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xpbDevExpress})
            Me.topMarginBand1.HeightF = 119F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlTitle})
            Me.ReportHeader.HeightF = 48.95833F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrChart
            ' 
            Me.xrChart.BorderColor = System.Drawing.Color.Black
            Me.xrChart.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart.DataSource = Me.xrPivotGrid
            xyDiagram1.AxisLabelsResolveOverlappingMinIndent = 0
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.ScaleBreakOptions.SizeInPixels = -1
            xyDiagram1.AxisX.ScaleBreakOptions.Style = DevExpress.XtraCharts.ScaleBreakStyle.Straight
            xyDiagram1.AxisX.Title.Text = "Year Quarter"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.Title.Text = "Sales Total"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.xrChart.Diagram = xyDiagram1
            Me.xrChart.ImageType = DevExpress.XtraReports.UI.ChartImageType.Svg
            Me.xrChart.Legend.MaxHorizontalPercentage = 30R
            Me.xrChart.Legend.Name = "Default Legend"
            Me.xrChart.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 217F)
            Me.xrChart.Name = "xrChart"
            Me.xrChart.SeriesDataMember = "Series"
            Me.xrChart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.xrChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.xrChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.xrChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart.SeriesTemplate.SeriesDataMember = "Series"
            Me.xrChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            stackedSplineAreaSeriesView1.EmptyPointOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            stackedSplineAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
            stackedSplineAreaSeriesView1.Transparency =(CByte((100)))
            Me.xrChart.SeriesTemplate.View = stackedSplineAreaSeriesView1
            Me.xrChart.SizeF = New System.Drawing.SizeF(919.9999F, 295F)
            ' 
            ' xrPivotGrid
            ' 
            Me.xrPivotGrid.Appearance.Cell.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.CustomTotalCell.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.FieldHeader.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.FieldValue.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.FieldValueGrandTotal.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.FieldValueTotal.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.GrandTotalCell.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.Lines.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.Appearance.TotalCell.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.875F)
            Me.xrPivotGrid.DataMember = "SalesPerson"
            Me.xrPivotGrid.DataSource = Me.sqlDataSource1
            Me.xrPivotGrid.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.pgfSalesPerson, Me.pgfSalesTotal, Me.pgfYear, Me.pgfQuarter})
            Me.xrPivotGrid.HeaderGroupLineStyleName = "GroupHeader"
            Me.xrPivotGrid.LocationFloat = New DevExpress.Utils.PointFloat(1F, 0F)
            Me.xrPivotGrid.Name = "xrPivotGrid"
            Me.xrPivotGrid.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.xrPivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = False
            Me.xrPivotGrid.OptionsPrint.FilterSeparatorBarPadding = 3
            Me.xrPivotGrid.OptionsView.ShowColumnTotals = False
            Me.xrPivotGrid.OptionsView.ShowRowTotals = False
            Me.xrPivotGrid.SizeF = New System.Drawing.SizeF(920F, 215.625F)
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "SalesPerson"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Country"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "FirstName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "LastName"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ProductName"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "OrderDate"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitPrice"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Quantity"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discount"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "ExtendedPrice"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "FullName"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.MetaSerializable = "<Meta X=""380"" Y=""20"" Width=""100"" Height=""280"" />"
            selectQuery1.Name = "SalesPerson"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' pgfSalesPerson
            ' 
            Me.pgfSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pgfSalesPerson.AreaIndex = 0
            Me.pgfSalesPerson.Caption = "Sales Person"
            Me.pgfSalesPerson.FieldName = "FullName"
            Me.pgfSalesPerson.Name = "pgfSalesPerson"
            ' 
            ' pgfSalesTotal
            ' 
            Me.pgfSalesTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pgfSalesTotal.AreaIndex = 0
            Me.pgfSalesTotal.Caption = "Sales Total"
            Me.pgfSalesTotal.FieldName = "ExtendedPrice"
            Me.pgfSalesTotal.Name = "pgfSalesTotal"
            ' 
            ' pgfYear
            ' 
            Me.pgfYear.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.pgfYear.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
            Me.pgfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pgfYear.AreaIndex = 0
            Me.pgfYear.Caption = "Year"
            Me.pgfYear.FieldName = "OrderDate"
            Me.pgfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.pgfYear.Name = "pgfYear"
            Me.pgfYear.UnboundFieldName = "pgfYear"
            ' 
            ' pgfQuarter
            ' 
            Me.pgfQuarter.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.pgfQuarter.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
            Me.pgfQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pgfQuarter.AreaIndex = 1
            Me.pgfQuarter.Caption = "Quarter"
            Me.pgfQuarter.FieldName = "OrderDate"
            Me.pgfQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.pgfQuarter.Name = "pgfQuarter"
            Me.pgfQuarter.UnboundFieldName = "pgfQuarter"
            Me.pgfQuarter.Width = 87
            ' 
            ' xpiPageCount
            ' 
            Me.xpiPageCount.Font = New DevExpress.Drawing.DXFont("Arial", 10.25F)
            Me.xpiPageCount.LocationFloat = New DevExpress.Utils.PointFloat(412F, 35F)
            Me.xpiPageCount.Name = "xpiPageCount"
            Me.xpiPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xpiPageCount.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xpiPageCount.StylePriority.UseFont = False
            Me.xpiPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xpiPageCount.TextFormatString = "Page : {0 } / {1}"
            ' 
            ' xpbDevExpress
            ' 
            Me.xpbDevExpress.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xpbDevExpress.ImageSource"))
            Me.xpbDevExpress.LocationFloat = New DevExpress.Utils.PointFloat(382.875F, 43.875F)
            Me.xpbDevExpress.Name = "xpbDevExpress"
            Me.xpbDevExpress.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xpbDevExpress.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xpbDevExpress.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xpbDevExpress.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xpbDevExpress.UseImageResolution = False
            ' 
            ' xrlTitle
            ' 
            Me.xrlTitle.Font = New DevExpress.Drawing.DXFont("Arial", 21.75F)
            Me.xrlTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrlTitle.Name = "xrlTitle"
            Me.xrlTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlTitle.SizeF = New System.Drawing.SizeF(920F, 48.95833F)
            Me.xrlTitle.StylePriority.UseFont = False
            Me.xrlTitle.StylePriority.UseTextAlignment = False
            Me.xrlTitle.Text = "Sales by Person"
            Me.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.Transparent
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((205)))))), (CInt(((CByte((162)))))))
            Me.OddStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)), DevExpress.XtraPrinting.BorderSide)
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' GroupHeader
            ' 
            Me.GroupHeader.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((243)))))), (CInt(((CByte((243)))))))
            Me.GroupHeader.BorderColor = System.Drawing.Color.White
            Me.GroupHeader.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.GroupHeader.BorderWidth = 1F
            Me.GroupHeader.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((139)))))), (CInt(((CByte((139)))))), (CInt(((CByte((139)))))))
            Me.GroupHeader.Name = "GroupHeader"
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((237)))))), (CInt(((CByte((196)))))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((205)))))), (CInt(((CByte((162)))))))
            Me.EvenStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)), DevExpress.XtraPrinting.BorderSide)
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' CategoryStyle
            ' 
            Me.CategoryStyle.BackColor = System.Drawing.Color.Transparent
            Me.CategoryStyle.BorderColor = System.Drawing.Color.Black
            Me.CategoryStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.CategoryStyle.BorderWidth = 1F
            Me.CategoryStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F)
            Me.CategoryStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((120)))))), (CInt(((CByte((0)))))))
            Me.CategoryStyle.Name = "CategoryStyle"
            ' 
            ' parameterViewType
            ' 
            Me.parameterViewType.Description = "View Type"
            Me.parameterViewType.Name = "parameterViewType"
            Me.parameterViewType.Type = GetType(XtraReportsDemos.PivotGridAndChart.ViewTypeFiltered)
            Me.parameterViewType.ValueInfo = "StackedSplineArea"
            ' 
            ' parameterShowLabels
            ' 
            Me.parameterShowLabels.Description = "Show Labels"
            Me.parameterShowLabels.Name = "parameterShowLabels"
            Me.parameterShowLabels.Type = GetType(Boolean)
            Me.parameterShowLabels.ValueInfo = "False"
            ' 
            ' parameterGenerateSeriesFromColumns
            ' 
            Me.parameterGenerateSeriesFromColumns.Description = "Generate Series from Columns"
            Me.parameterGenerateSeriesFromColumns.Name = "parameterGenerateSeriesFromColumns"
            Me.parameterGenerateSeriesFromColumns.Type = GetType(Boolean)
            Me.parameterGenerateSeriesFromColumns.ValueInfo = "False"
            ' 
            ' parameterShowRowGrandTotals
            ' 
            Me.parameterShowRowGrandTotals.Description = "Show Row Grand Totals"
            Me.parameterShowRowGrandTotals.Name = "parameterShowRowGrandTotals"
            Me.parameterShowRowGrandTotals.Type = GetType(Boolean)
            Me.parameterShowRowGrandTotals.ValueInfo = "False"
            ' 
            ' parameterShowColumnGrandTotals
            ' 
            Me.parameterShowColumnGrandTotals.Description = "Show Column Grand Totals"
            Me.parameterShowColumnGrandTotals.Name = "parameterShowColumnGrandTotals"
            Me.parameterShowColumnGrandTotals.Type = GetType(Boolean)
            Me.parameterShowColumnGrandTotals.ValueInfo = "False"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.topMarginBand1, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DisplayName = "PivotGrid and Chart"
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 78F, 119F, 87F)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameterViewType, Me.parameterShowLabels, Me.parameterGenerateSeriesFromColumns, Me.parameterShowRowGrandTotals, Me.parameterShowColumnGrandTotals})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.OddStyle, Me.GroupHeader, Me.EvenStyle, Me.CategoryStyle})
            Me.Version = "25.1"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedSplineAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrChart As DevExpress.XtraReports.UI.XRChart

        Private xrPivotGrid As DevExpress.XtraReports.UI.XRPivotGrid

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private pgfSalesPerson As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private pgfSalesTotal As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private pgfYear As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private pgfQuarter As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xpiPageCount As DevExpress.XtraReports.UI.XRPageInfo

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xpbDevExpress As DevExpress.XtraReports.UI.XRPictureBox

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrlTitle As DevExpress.XtraReports.UI.XRLabel

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupHeader As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private CategoryStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private parameterViewType As DevExpress.XtraReports.Parameters.Parameter

        Private parameterShowLabels As DevExpress.XtraReports.Parameters.Parameter

        Private parameterGenerateSeriesFromColumns As DevExpress.XtraReports.Parameters.Parameter

        Private parameterShowRowGrandTotals As DevExpress.XtraReports.Parameters.Parameter

        Private parameterShowColumnGrandTotals As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
