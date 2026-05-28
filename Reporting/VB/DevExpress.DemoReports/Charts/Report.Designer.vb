Namespace XtraReportsDemos.Charts

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private lbTitle As DevExpress.XtraReports.UI.XRLabel

        Private components As System.ComponentModel.IContainer = Nothing

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

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
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim group1 As DevExpress.DataAccess.Sql.Group = New DevExpress.DataAccess.Sql.Group()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join4 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim group2 As DevExpress.DataAccess.Sql.Group = New DevExpress.DataAccess.Sql.Group()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim join5 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table9 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join6 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo6 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.Charts.Report))
            Dim customJsonSource1 As DevExpress.DataAccess.Json.CustomJsonSource = New DevExpress.DataAccess.Json.CustomJsonSource()
            Dim jsonSchemaNode1 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("root", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
            Dim jsonSchemaNode2 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("CategoryId", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode3 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("CategoryName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim selectNode1 As DevExpress.DataAccess.DataFederation.SelectNode = New DevExpress.DataAccess.DataFederation.SelectNode()
            Dim sourceNode1 As DevExpress.DataAccess.DataFederation.SourceNode = New DevExpress.DataAccess.DataFederation.SourceNode()
            Dim source1 As DevExpress.DataAccess.DataFederation.Source = New DevExpress.DataAccess.DataFederation.Source()
            Dim sourceNode2 As DevExpress.DataAccess.DataFederation.SourceNode = New DevExpress.DataAccess.DataFederation.SourceNode()
            Dim source2 As DevExpress.DataAccess.DataFederation.Source = New DevExpress.DataAccess.DataFederation.Source()
            Dim joinElement1 As DevExpress.DataAccess.DataFederation.JoinElement = New DevExpress.DataAccess.DataFederation.JoinElement()
            Dim selectNode2 As DevExpress.DataAccess.DataFederation.SelectNode = New DevExpress.DataAccess.DataFederation.SelectNode()
            Dim sourceNode3 As DevExpress.DataAccess.DataFederation.SourceNode = New DevExpress.DataAccess.DataFederation.SourceNode()
            Dim sourceNode4 As DevExpress.DataAccess.DataFederation.SourceNode = New DevExpress.DataAccess.DataFederation.SourceNode()
            Dim source3 As DevExpress.DataAccess.DataFederation.Source = New DevExpress.DataAccess.DataFederation.Source()
            Dim joinElement2 As DevExpress.DataAccess.DataFederation.JoinElement = New DevExpress.DataAccess.DataFederation.JoinElement()
            Dim selectNode3 As DevExpress.DataAccess.DataFederation.SelectNode = New DevExpress.DataAccess.DataFederation.SelectNode()
            Dim sourceNode5 As DevExpress.DataAccess.DataFederation.SourceNode = New DevExpress.DataAccess.DataFederation.SourceNode()
            Dim source4 As DevExpress.DataAccess.DataFederation.Source = New DevExpress.DataAccess.DataFederation.Source()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim customAxisLabel1 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel2 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel3 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel4 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel5 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel6 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel7 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel8 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel9 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel10 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel11 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel12 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim doughnutSeriesLabel1 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim doughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim customAxisLabel13 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel14 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel15 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel16 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim stackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim customAxisLabel17 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel18 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel19 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel20 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim doughnutSeriesView2 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
            Me.federationDataSource1 = New DevExpress.DataAccess.DataFederation.FederationDataSource()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.CurrentYear = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrChart3 = New DevExpress.XtraReports.UI.XRChart()
            Me.xrChart2 = New DevExpress.XtraReports.UI.XRChart()
            Me.xrChart4 = New DevExpress.XtraReports.UI.XRChart()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Year = New DevExpress.XtraReports.UI.CalculatedField()
            Me.Month = New DevExpress.XtraReports.UI.CalculatedField()
            Me.Quarter = New DevExpress.XtraReports.UI.CalculatedField()
            Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.VerticalDetail = New DevExpress.XtraReports.UI.VerticalDetailBand()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrChart6 = New DevExpress.XtraReports.UI.XRChart()
            Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.Totals = New DevExpress.XtraReports.UI.CalculatedField()
            Me.xrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
            Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            CType((Me.federationDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrChart1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrChart3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrChart2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrChart4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrChart6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "DevAvConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            column1.[Alias] = "ProductName"
            columnExpression1.ColumnName = "Name"
            table1.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""443"" />"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            column2.[Alias] = "CategoryId"
            columnExpression2.ColumnName = "Category"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "OrderDate"
            table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""443"" />"
            table2.Name = "Orders"
            columnExpression3.Table = table2
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "ProductUnits"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""203"" />"
            table3.Name = "OrderItems"
            columnExpression4.Table = table3
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Total"
            columnExpression5.Table = table3
            column5.Expression = columnExpression5
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Name = "Orders"
            relationColumnInfo1.NestedKeyColumn = "Id"
            relationColumnInfo1.ParentKeyColumn = "OrderId"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table3
            relationColumnInfo2.NestedKeyColumn = "Id"
            relationColumnInfo2.ParentKeyColumn = "ProductId"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table1
            join2.Parent = table3
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table2)
            selectQuery1.Tables.Add(table1)
            column6.[Alias] = "CategoryId"
            columnExpression6.ColumnName = "Category"
            table4.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""443"" />"
            table4.Name = "Products"
            columnExpression6.Table = table4
            column6.Expression = columnExpression6
            column7.[Alias] = "Sales"
            columnExpression7.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
            columnExpression7.ColumnName = "Total"
            table5.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""203"" />"
            table5.Name = "OrderItems"
            columnExpression7.Table = table5
            column7.Expression = columnExpression7
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.FilterString = "GetDate([Orders.OrderDate]) >= ?Start And GetDate([OrderItems.Id]) < ?End"
            selectQuery2.GroupFilterString = ""
            columnExpression8.ColumnName = "Category"
            columnExpression8.Table = table4
            group1.Expression = columnExpression8
            selectQuery2.Groups.Add(group1)
            selectQuery2.Name = "SalesByCategory"
            queryParameter1.Name = "Start"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("?CurrentYear", GetType(System.DateTime))
            queryParameter2.Name = "End"
            queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter2.Value = New DevExpress.DataAccess.Expression("AddYears(?CurrentYear, 1)", GetType(System.DateTime))
            selectQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter1, queryParameter2})
            relationColumnInfo3.NestedKeyColumn = "Id"
            relationColumnInfo3.ParentKeyColumn = "OrderId"
            join3.KeyColumns.Add(relationColumnInfo3)
            table6.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""443"" />"
            table6.Name = "Orders"
            join3.Nested = table6
            join3.Parent = table5
            relationColumnInfo4.NestedKeyColumn = "Id"
            relationColumnInfo4.ParentKeyColumn = "ProductId"
            join4.KeyColumns.Add(relationColumnInfo4)
            join4.Nested = table4
            join4.Parent = table5
            selectQuery2.Relations.Add(join3)
            selectQuery2.Relations.Add(join4)
            selectQuery2.Tables.Add(table5)
            selectQuery2.Tables.Add(table6)
            selectQuery2.Tables.Add(table4)
            column8.[Alias] = "ProductName"
            columnExpression9.ColumnName = "Name"
            table7.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""443"" />"
            table7.Name = "Products"
            columnExpression9.Table = table7
            column8.Expression = columnExpression9
            column9.[Alias] = "SalesCount"
            columnExpression10.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
            columnExpression10.ColumnName = "ProductUnits"
            table8.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""203"" />"
            table8.Name = "OrderItems"
            columnExpression10.Table = table8
            column9.Expression = columnExpression10
            column10.[Alias] = "SalesTotal"
            columnExpression11.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
            columnExpression11.ColumnName = "Total"
            columnExpression11.Table = table8
            column10.Expression = columnExpression11
            selectQuery3.Columns.Add(column8)
            selectQuery3.Columns.Add(column9)
            selectQuery3.Columns.Add(column10)
            selectQuery3.FilterString = "GetDate([Orders.OrderDate]) >= ?Start And GetDate([Orders.OrderDate]) < ?End"
            selectQuery3.GroupFilterString = ""
            columnExpression12.ColumnName = "Name"
            columnExpression12.Table = table7
            group2.Expression = columnExpression12
            selectQuery3.Groups.Add(group2)
            selectQuery3.Name = "BestSellingProducts"
            queryParameter3.Name = "Start"
            queryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter3.Value = New DevExpress.DataAccess.Expression("?CurrentYear", GetType(System.DateTime))
            queryParameter4.Name = "End"
            queryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter4.Value = New DevExpress.DataAccess.Expression("AddYears(?CurrentYear, 1)", GetType(System.DateTime))
            selectQuery3.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter3, queryParameter4})
            relationColumnInfo5.NestedKeyColumn = "Id"
            relationColumnInfo5.ParentKeyColumn = "OrderId"
            join5.KeyColumns.Add(relationColumnInfo5)
            table9.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""443"" />"
            table9.Name = "Orders"
            join5.Nested = table9
            join5.Parent = table8
            relationColumnInfo6.NestedKeyColumn = "Id"
            relationColumnInfo6.ParentKeyColumn = "ProductId"
            join6.KeyColumns.Add(relationColumnInfo6)
            join6.Nested = table7
            join6.Parent = table8
            selectQuery3.Relations.Add(join5)
            selectQuery3.Relations.Add(join6)
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
            columnExpression13.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
            columnExpression13.ColumnName = "Total"
            columnExpression13.Table = table8
            sorting1.Expression = columnExpression13
            selectQuery3.Sorting.Add(sorting1)
            selectQuery3.Tables.Add(table8)
            selectQuery3.Tables.Add(table9)
            selectQuery3.Tables.Add(table7)
            selectQuery3.Top = 10
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2, selectQuery3})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' jsonDataSource1
            ' 
            Me.jsonDataSource1.ConnectionName = Nothing
            customJsonSource1.Json = resources.GetString("customJsonSource1.Json")
            Me.jsonDataSource1.JsonSource = customJsonSource1
            Me.jsonDataSource1.Name = "jsonDataSource1"
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode2)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode3)
            Me.jsonDataSource1.Schema = jsonSchemaNode1
            ' 
            ' federationDataSource1
            ' 
            Me.federationDataSource1.Name = "federationDataSource1"
            selectNode1.[Alias] = "Orders"
            sourceNode1.[Alias] = "Orders"
            source1.DataMember = "Orders"
            source1.DataSource = Me.sqlDataSource1
            source1.Name = "sqlDataSource1_Orders"
            sourceNode1.Source = source1
            sourceNode2.[Alias] = "jsonDataSource1"
            source2.DataMember = ""
            source2.DataSource = Me.jsonDataSource1
            source2.Name = "jsonDataSource1"
            sourceNode2.Source = source2
            selectNode1.Expressions.AddRange(New DevExpress.DataAccess.DataFederation.ISelectExpression() {New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "ProductName"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "CategoryName"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "OrderDate"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "ProductUnits"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "Total")})
            selectNode1.Root = sourceNode1
            joinElement1.Condition = "[[jsonDataSource1\].[CategoryId\]] = [[Orders\].[CategoryId\]]"
            joinElement1.Node = sourceNode2
            selectNode1.SubNodes.AddRange(New DevExpress.DataAccess.DataFederation.JoinElement() {joinElement1})
            selectNode2.[Alias] = "SalesByCategory"
            sourceNode3.[Alias] = "jsonDataSource1"
            sourceNode3.Source = source2
            sourceNode4.[Alias] = "SalesByCategory"
            source3.DataMember = "SalesByCategory"
            source3.DataSource = Me.sqlDataSource1
            source3.Name = "sqlDataSource1_SalesByCategory"
            sourceNode4.Source = source3
            selectNode2.Expressions.AddRange(New DevExpress.DataAccess.DataFederation.ISelectExpression() {New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "CategoryName"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode4, "Sales")})
            selectNode2.Root = sourceNode4
            joinElement2.Condition = "[[jsonDataSource1\].[CategoryId\]] = [[SalesByCategory\].[CategoryId\]]"
            joinElement2.Node = sourceNode3
            selectNode2.SubNodes.AddRange(New DevExpress.DataAccess.DataFederation.JoinElement() {joinElement2})
            selectNode3.[Alias] = "BestSellingProducts"
            sourceNode5.[Alias] = "BestSellingProducts"
            source4.DataMember = "BestSellingProducts"
            source4.DataSource = Me.sqlDataSource1
            source4.Name = "sqlDataSource1_BestSellingProducts"
            sourceNode5.Source = source4
            selectNode3.Expressions.AddRange(New DevExpress.DataAccess.DataFederation.ISelectExpression() {New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "ProductName"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "SalesCount"), New DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "SalesTotal")})
            selectNode3.Root = sourceNode5
            Me.federationDataSource1.Queries.AddRange(New DevExpress.DataAccess.DataFederation.QueryNode() {selectNode1, selectNode2, selectNode3})
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.Transparent
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart1, Me.xrChart3, Me.xrChart2})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
            Me.Detail.HeightF = 645F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.BackColor = System.Drawing.Color.Transparent
            Me.xrChart1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrChart1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrChart1.DataSource = Me.federationDataSource1
            xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            customAxisLabel1.AxisValueSerializable = "1"
            customAxisLabel1.Name = "JAN"
            customAxisLabel2.AxisValueSerializable = "2"
            customAxisLabel2.Name = "FEB"
            customAxisLabel3.AxisValueSerializable = "3"
            customAxisLabel3.Name = "MAR"
            customAxisLabel4.AxisValueSerializable = "4"
            customAxisLabel4.Name = "APR"
            customAxisLabel5.AxisValueSerializable = "5"
            customAxisLabel5.Name = "MAY"
            customAxisLabel6.AxisValueSerializable = "6"
            customAxisLabel6.Name = "JUN"
            customAxisLabel7.AxisValueSerializable = "7"
            customAxisLabel7.Name = "JUL"
            customAxisLabel8.AxisValueSerializable = "8"
            customAxisLabel8.Name = "AUG"
            customAxisLabel9.AxisValueSerializable = "9"
            customAxisLabel9.Name = "SEP"
            customAxisLabel10.AxisValueSerializable = "10"
            customAxisLabel10.Name = "OCT"
            customAxisLabel11.AxisValueSerializable = "11"
            customAxisLabel11.Name = "NOV"
            customAxisLabel12.AxisValueSerializable = "12"
            customAxisLabel12.Name = "DEC"
            xyDiagram1.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel1, customAxisLabel2, customAxisLabel3, customAxisLabel4, customAxisLabel5, customAxisLabel6, customAxisLabel7, customAxisLabel8, customAxisLabel9, customAxisLabel10, customAxisLabel11, customAxisLabel12})
            xyDiagram1.AxisX.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.Tickmarks.Visible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram1.AxisY.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram1.AxisY.Label.TextPattern = "{V:n0}"
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.Tickmarks.Visible = False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
            xyDiagram1.DefaultPane.BorderVisible = False
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart1.Diagram = xyDiagram1
            Me.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.xrChart1.Legend.BackColor = System.Drawing.Color.Transparent
            Me.xrChart1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.xrChart1.Legend.DockTargetName = "Default Pane"
            Me.xrChart1.Legend.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrChart1.Legend.HorizontalIndent = 20
            Me.xrChart1.Legend.MarkerSize = New System.Drawing.Size(20, 20)
            Me.xrChart1.Legend.Name = "Default Legend"
            Me.xrChart1.Legend.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((85)))))), (CInt(((CByte((104)))))))
            Me.xrChart1.Legend.TextOffset = 5
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 10F)
            Me.xrChart1.Name = "xrChart1"
            Me.xrChart1.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 22, 96F)
            Me.xrChart1.PaletteName = "Palette 1"
            Me.xrChart1.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((220)))))), (CInt(((CByte((225)))))), (CInt(((CByte((230))))))), System.Drawing.Color.FromArgb((CInt(((CByte((220)))))), (CInt(((CByte((225)))))), (CInt(((CByte((230)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((97)))))), (CInt(((CByte((133))))))), System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((97)))))), (CInt(((CByte((133))))))))}))
            Me.xrChart1.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", Me.CurrentYear)})
            Me.xrChart1.SeriesDataMember = "Orders.Year"
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.xrChart1.SeriesTemplate.ArgumentDataMember = "Orders.Month"
            Me.xrChart1.SeriesTemplate.FilterString = "[Orders.OrderDate] >= AddYears(?CurrentYear, -1) And [Orders.OrderDate] < AddYear" & "s(?CurrentYear, 1)"
            Me.xrChart1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart1.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])"
            Me.xrChart1.SeriesTemplate.SeriesDataMember = "Orders.Year"
            Me.xrChart1.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total"
            Me.xrChart1.SideBySideBarDistanceFixed = 2
            Me.xrChart1.SizeF = New System.Drawing.SizeF(980F, 365F)
            Me.xrChart1.StylePriority.UseBackColor = False
            Me.xrChart1.StylePriority.UseBorderColor = False
            Me.xrChart1.StylePriority.UseBorders = False
            Me.xrChart1.StylePriority.UsePadding = False
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            chartTitle1.Indent = 0
            chartTitle1.Text = "Annual Sales Comparison, $"
            chartTitle1.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            chartTitle1.WordWrap = True
            Me.xrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.xrChart1.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.xrChart_CustomDrawLegendMarker)
            ' 
            ' CurrentYear
            ' 
            Me.CurrentYear.Description = "CurrentYear"
            Me.CurrentYear.Name = "CurrentYear"
            Me.CurrentYear.Type = GetType(System.DateTime)
            Me.CurrentYear.Visible = False
            ' 
            ' xrChart3
            ' 
            Me.xrChart3.BackColor = System.Drawing.Color.Transparent
            Me.xrChart3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrChart3.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrChart3.DataSource = Me.federationDataSource1
            Me.xrChart3.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
            Me.xrChart3.Legend.BackColor = System.Drawing.Color.Transparent
            Me.xrChart3.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart3.Legend.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrChart3.Legend.HorizontalIndent = 0
            Me.xrChart3.Legend.MarkerSize = New System.Drawing.Size(20, 20)
            Me.xrChart3.Legend.Name = "Default Legend"
            Me.xrChart3.Legend.Padding.Bottom = 0
            Me.xrChart3.Legend.Padding.Left = 20
            Me.xrChart3.Legend.Padding.Right = 30
            Me.xrChart3.Legend.Padding.Top = 0
            Me.xrChart3.Legend.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((85)))))), (CInt(((CByte((104)))))))
            Me.xrChart3.Legend.TextOffset = 5
            Me.xrChart3.Legend.VerticalIndent = 10
            Me.xrChart3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.xrChart3.LocationFloat = New DevExpress.Utils.PointFloat(600F, 395F)
            Me.xrChart3.Name = "xrChart3"
            Me.xrChart3.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 15, 96F)
            Me.xrChart3.PaletteName = "Palette 1"
            Me.xrChart3.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197))))))), System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132))))))), System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))))}))
            Me.xrChart3.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", Me.CurrentYear)})
            series1.ArgumentDataMember = "Orders.CategoryName"
            series1.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" & ", 1)"
            doughnutSeriesLabel1.BackColor = System.Drawing.Color.Transparent
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            doughnutSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
            doughnutSeriesLabel1.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            doughnutSeriesLabel1.TextPattern = "{VP:0%}"
            series1.Label = doughnutSeriesLabel1
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series 1"
            series1.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])"
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([Orders.Total])"
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
            series1.ValueDataMembersSerializable = "Orders.Total"
            doughnutSeriesView1.HoleRadiusPercent = 45
            doughnutSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise
            series1.View = doughnutSeriesView1
            Me.xrChart3.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.xrChart3.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart3.SeriesTemplate.View = stackedBarSeriesView1
            Me.xrChart3.SizeF = New System.Drawing.SizeF(390F, 240F)
            Me.xrChart3.StylePriority.UseBackColor = False
            Me.xrChart3.StylePriority.UseBorderColor = False
            Me.xrChart3.StylePriority.UseBorders = False
            Me.xrChart3.StylePriority.UsePadding = False
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            chartTitle2.Indent = 15
            chartTitle2.Text = "Product Categories"
            chartTitle2.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.xrChart3.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            AddHandler Me.xrChart3.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.xrChart_CustomDrawLegendMarker)
            ' 
            ' xrChart2
            ' 
            Me.xrChart2.BackColor = System.Drawing.Color.Transparent
            Me.xrChart2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrChart2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrChart2.DataSource = Me.federationDataSource1
            xyDiagram2.AxisX.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            customAxisLabel13.AxisValueSerializable = "1"
            customAxisLabel13.Name = "Q1"
            customAxisLabel14.AxisValueSerializable = "2"
            customAxisLabel14.Name = "Q2"
            customAxisLabel15.AxisValueSerializable = "3"
            customAxisLabel15.Name = "Q3"
            customAxisLabel16.AxisValueSerializable = "4"
            customAxisLabel16.Name = "Q4"
            xyDiagram2.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel13, customAxisLabel14, customAxisLabel15, customAxisLabel16})
            xyDiagram2.AxisX.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram2.AxisX.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram2.AxisX.Reverse = True
            xyDiagram2.AxisX.Tickmarks.MinorVisible = False
            xyDiagram2.AxisX.Tickmarks.Visible = False
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram2.AxisY.GridLines.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram2.AxisY.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram2.AxisY.Label.TextPattern = "{V:n0}"
            xyDiagram2.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram2.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Millions
            xyDiagram2.AxisY.Tickmarks.MinorVisible = False
            xyDiagram2.AxisY.Tickmarks.Visible = False
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.Transparent
            xyDiagram2.DefaultPane.BorderVisible = False
            xyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.DefaultPane.LayoutOptions.Column = 0
            xyDiagram2.DefaultPane.LayoutOptions.Row = 0
            xyDiagram2.PaneLayout.Direction = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal
            xyDiagram2.Rotated = True
            Me.xrChart2.Diagram = xyDiagram2
            Me.xrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.xrChart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.xrChart2.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.xrChart2.Legend.Name = "Default Legend"
            Me.xrChart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart2.LocationFloat = New DevExpress.Utils.PointFloat(10F, 395F)
            Me.xrChart2.Name = "xrChart2"
            Me.xrChart2.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 22, 96F)
            Me.xrChart2.PaletteName = "Palette 1"
            Me.xrChart2.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197))))))), System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132))))))), System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))))}))
            Me.xrChart2.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", Me.CurrentYear)})
            Me.xrChart2.SeriesDataMember = "Orders.CategoryName"
            Me.xrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.xrChart2.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
            Me.xrChart2.SeriesTemplate.ArgumentDataMember = "Orders.Quarter"
            Me.xrChart2.SeriesTemplate.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" & ", 1)"
            Me.xrChart2.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart2.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])"
            Me.xrChart2.SeriesTemplate.SeriesDataMember = "Orders.CategoryName"
            Me.xrChart2.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total"
            Me.xrChart2.SeriesTemplate.View = stackedBarSeriesView2
            Me.xrChart2.SizeF = New System.Drawing.SizeF(570F, 240F)
            Me.xrChart2.StylePriority.UseBackColor = False
            Me.xrChart2.StylePriority.UseBorderColor = False
            Me.xrChart2.StylePriority.UseBorders = False
            Me.xrChart2.StylePriority.UsePadding = False
            chartTitle3.Alignment = System.Drawing.StringAlignment.Near
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            chartTitle3.Indent = 15
            chartTitle3.Text = "Quarterly Sales Distribution, $"
            chartTitle3.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrChart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3})
            ' 
            ' xrChart4
            ' 
            Me.xrChart4.BackColor = System.Drawing.Color.Transparent
            Me.xrChart4.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrChart4.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrChart4.DataSource = Me.federationDataSource1
            xyDiagram3.AxisX.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            customAxisLabel17.AxisValueSerializable = "1"
            customAxisLabel17.Name = "Q1"
            customAxisLabel18.AxisValueSerializable = "2"
            customAxisLabel18.Name = "Q2"
            customAxisLabel19.AxisValueSerializable = "3"
            customAxisLabel19.Name = "Q3"
            customAxisLabel20.AxisValueSerializable = "4"
            customAxisLabel20.Name = "Q4"
            xyDiagram3.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel17, customAxisLabel18, customAxisLabel19, customAxisLabel20})
            xyDiagram3.AxisX.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram3.AxisX.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram3.AxisX.Tickmarks.MinorVisible = False
            xyDiagram3.AxisX.Tickmarks.Visible = False
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram3.AxisY.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram3.AxisY.GridLines.Color = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            xyDiagram3.AxisY.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xyDiagram3.AxisY.Label.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((154)))))), (CInt(((CByte((163)))))), (CInt(((CByte((179)))))))
            xyDiagram3.AxisY.Label.TextPattern = "{V:n0}"
            xyDiagram3.AxisY.Tickmarks.MinorVisible = False
            xyDiagram3.AxisY.Tickmarks.Visible = False
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram3.DefaultPane.BackColor = System.Drawing.Color.Transparent
            xyDiagram3.DefaultPane.BorderVisible = False
            xyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3.DefaultPane.LayoutOptions.Column = 0
            xyDiagram3.DefaultPane.LayoutOptions.Row = 0
            xyDiagram3.PaneLayout.Direction = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal
            Me.xrChart4.Diagram = xyDiagram3
            Me.xrChart4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.xrChart4.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.xrChart4.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart4.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.xrChart4.Legend.Name = "Default Legend"
            Me.xrChart4.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart4.LocationFloat = New DevExpress.Utils.PointFloat(10F, 10F)
            Me.xrChart4.Name = "xrChart4"
            Me.xrChart4.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 32, 96F)
            Me.xrChart4.PaletteName = "Palette 1"
            Me.xrChart4.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197))))))), System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132))))))), System.Drawing.Color.FromArgb((CInt(((CByte((35)))))), (CInt(((CByte((107)))))), (CInt(((CByte((132)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((163)))))), (CInt(((CByte((140)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((201)))))), (CInt(((CByte((144)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))), System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((162)))))), (CInt(((CByte((161))))))))}))
            Me.xrChart4.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", Me.CurrentYear)})
            Me.xrChart4.SeriesDataMember = "Orders.CategoryName"
            Me.xrChart4.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.xrChart4.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
            Me.xrChart4.SeriesTemplate.ArgumentDataMember = "Orders.Quarter"
            Me.xrChart4.SeriesTemplate.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" & ", 1)"
            Me.xrChart4.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart4.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])"
            Me.xrChart4.SeriesTemplate.SeriesDataMember = "Orders.CategoryName"
            Me.xrChart4.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total"
            Me.xrChart4.SeriesTemplate.View = lineSeriesView1
            Me.xrChart4.SizeF = New System.Drawing.SizeF(570F, 405.0001F)
            Me.xrChart4.StylePriority.UseBackColor = False
            Me.xrChart4.StylePriority.UseBorderColor = False
            Me.xrChart4.StylePriority.UseBorders = False
            Me.xrChart4.StylePriority.UsePadding = False
            chartTitle4.Alignment = System.Drawing.StringAlignment.Near
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            chartTitle4.Indent = 25
            chartTitle4.Text = "Sales by Product Category, $"
            chartTitle4.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrChart4.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle4})
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 55F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.lbTitle})
            Me.ReportHeader.HeightF = 98F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0:d} - {1:d}', ?CurrentYear, AddDays(AddMonths(?CurrentYear, 11), " & "30))")})
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10F, 63F)
            Me.xrLabel3.Multiline = True
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(570F, 25F)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesByCategory].[Totals]")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Tahoma", 22F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((74)))))), (CInt(((CByte((101)))))))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(600F, 22.99999F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(390.0001F, 40F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrLabel2.TextFormatString = "{0:$#,##0}"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(600F, 0F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(390F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Total Sales"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbTitle.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetYear(?CurrentYear)")})
            Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Tahoma", 28F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((74)))))), (CInt(((CByte((101)))))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.999992F, 0F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(570F, 63F)
            Me.lbTitle.StylePriority.UseFont = False
            Me.lbTitle.StylePriority.UseForeColor = False
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.lbTitle.TextFormatString = "Sales Analysis {0}"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 55F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' Year
            ' 
            Me.Year.DataMember = "Orders"
            Me.Year.Expression = "GetYear([OrderDate])"
            Me.Year.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.Year.Name = "Year"
            ' 
            ' Month
            ' 
            Me.Month.DataMember = "Orders"
            Me.Month.Expression = "GetMonth([OrderDate])"
            Me.Month.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.Month.Name = "Month"
            ' 
            ' Quarter
            ' 
            Me.Quarter.DataMember = "Orders"
            Me.Quarter.Expression = "[Month] / 4 + 1"
            Me.Quarter.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.Quarter.Name = "Quarter"
            ' 
            ' DetailReport2
            ' 
            Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.VerticalDetail, Me.ReportHeader1, Me.ReportFooter})
            Me.DetailReport2.DataMember = "SalesByCategory"
            Me.DetailReport2.DataSource = Me.federationDataSource1
            Me.DetailReport2.Level = 1
            Me.DetailReport2.Name = "DetailReport2"
            ' 
            ' VerticalDetail
            ' 
            Me.VerticalDetail.BandLayout = DevExpress.XtraReports.UI.VerticalBandLayout.AcrossThenDown
            Me.VerticalDetail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrChart6})
            Me.VerticalDetail.HeightF = 215F
            Me.VerticalDetail.Name = "VerticalDetail"
            Me.VerticalDetail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.VerticalDetail.WidthF = 195F
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((85)))))), (CInt(((CByte((104)))))))
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(20F, 185F)
            Me.xrLabel5.Multiline = True
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 12, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(175F, 30F)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseForeColor = False
            Me.xrLabel5.StylePriority.UsePadding = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrChart6
            ' 
            Me.xrChart6.BackColor = System.Drawing.Color.Transparent
            Me.xrChart6.BorderColor = System.Drawing.Color.Black
            Me.xrChart6.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart6.Legend.Name = "Default Legend"
            Me.xrChart6.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart6.LocationFloat = New DevExpress.Utils.PointFloat(20F, 0F)
            Me.xrChart6.Name = "xrChart6"
            Me.xrChart6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 20, 20, 96F)
            Me.xrChart6.PaletteName = "Palette 1"
            Me.xrChart6.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197))))))), System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((174)))))), (CInt(((CByte((197)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240))))))), System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240))))))))}))
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Series 1"
            doughnutSeriesView2.HoleRadiusPercent = 45
            doughnutSeriesView2.TotalLabel.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            doughnutSeriesView2.TotalLabel.Visible = True
            series2.View = doughnutSeriesView2
            Me.xrChart6.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            Me.xrChart6.SizeF = New System.Drawing.SizeF(175F, 185F)
            Me.xrChart6.StylePriority.UseBackColor = False
            Me.xrChart6.StylePriority.UsePadding = False
            AddHandler Me.xrChart6.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.xrChart6_BeforePrint)
            ' 
            ' ReportHeader1
            ' 
            Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4})
            Me.ReportHeader1.HeightF = 75F
            Me.ReportHeader1.Name = "ReportHeader1"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(20F, 35.99999F)
            Me.xrLabel4.Multiline = True
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(17, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(559.9999F, 26F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "Sales by Product Category"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.HeightF = 20F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' Totals
            ' 
            Me.Totals.DataMember = "SalesByCategory"
            Me.Totals.Expression = "Sum([Sales])"
            Me.Totals.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
            Me.Totals.Name = "Totals"
            ' 
            ' xrCrossBandBox1
            ' 
            Me.xrCrossBandBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrCrossBandBox1.BorderWidth = 1F
            Me.xrCrossBandBox1.EndBand = Me.ReportFooter
            Me.xrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(10F, 19.99997F)
            Me.xrCrossBandBox1.Name = "xrCrossBandBox1"
            Me.xrCrossBandBox1.StartBand = Me.ReportHeader1
            Me.xrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(10F, 20F)
            Me.xrCrossBandBox1.WidthF = 980F
            ' 
            ' DetailReport1
            ' 
            Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.GroupHeader2})
            Me.DetailReport1.DataMember = "BestSellingProducts"
            Me.DetailReport1.DataSource = Me.federationDataSource1
            Me.DetailReport1.Level = 0
            Me.DetailReport1.Name = "DetailReport1"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail1.HeightF = 32F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrTable1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((85)))))), (CInt(((CByte((104)))))))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(600.0001F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(390F, 32F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell7})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 11.5R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 2, 0, 0, 100F)
            Me.xrTableCell2.StylePriority.UseBorderColor = False
            Me.xrTableCell2.StylePriority.UseBorders = False
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell2.Weight = 1.4364278092423868R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesCount]")})
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 12, 0, 0, 100F)
            Me.xrTableCell3.StylePriority.UseBorders = False
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.89468944643182358R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesTotal]")})
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 22, 0, 0, 100F)
            Me.xrTableCell7.StylePriority.UseBorders = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.TextFormatString = "{0:c0}"
            Me.xrTableCell7.Weight = 0.89468944643182358R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart4})
            Me.GroupHeader1.HeightF = 415.0001F
            Me.GroupHeader1.Level = 1
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.PrintAcrossBands = True
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.xrTable2})
            Me.GroupHeader2.HeightF = 95F
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrLine1.LineWidth = 2F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(600F, 93F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(390F, 2.1F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((236)))))), (CInt(((CByte((240)))))))
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((180)))))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(600F, 10F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(390F, 82.99995F)
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 20.316647656758626R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell1.Font = New DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 8, 100F)
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Best Selling Products"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 3.2258067021060342R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(22, 2, 0, 0, 100F)
            Me.xrTableCell4.StylePriority.UseBorders = False
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "PRODUCT NAME"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell4.Weight = 1.4364278092423868R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 12, 0, 0, 100F)
            Me.xrTableCell5.StylePriority.UseBorders = False
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "SALES COUNT"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell5.Weight = 0.89468944643182358R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 22, 0, 0, 100F)
            Me.xrTableCell6.StylePriority.UseBorders = False
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "TOTAL"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.Weight = 0.89468944643182358R
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.topMarginBand1, Me.DetailReport2, Me.DetailReport1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Year, Me.Month, Me.Quarter, Me.Totals})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1, Me.jsonDataSource1, Me.federationDataSource1})
            Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.xrCrossBandBox1})
            Me.DataSource = Me.federationDataSource1
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(50, 50, 55, 55)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.CurrentYear})
            Me.RequestParameters = False
            Me.Version = "21.2"
            CType((Me.federationDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnutSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private Year As DevExpress.XtraReports.UI.CalculatedField

        Private Month As DevExpress.XtraReports.UI.CalculatedField

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private federationDataSource1 As DevExpress.DataAccess.DataFederation.FederationDataSource

        Private xrChart2 As DevExpress.XtraReports.UI.XRChart

        Private Quarter As DevExpress.XtraReports.UI.CalculatedField

        Private xrChart3 As DevExpress.XtraReports.UI.XRChart

        Private xrChart1 As DevExpress.XtraReports.UI.XRChart

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrChart4 As DevExpress.XtraReports.UI.XRChart

        Private DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand

        Private VerticalDetail As DevExpress.XtraReports.UI.VerticalDetailBand

        Private ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrChart6 As DevExpress.XtraReports.UI.XRChart

        Private Totals As DevExpress.XtraReports.UI.CalculatedField

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox

        Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource

        Private DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private CurrentYear As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
