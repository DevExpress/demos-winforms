Namespace XtraReportsDemos.ReportMerging

    Public Partial Class ChartReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private lbTitle As DevExpress.XtraReports.UI.XRLabel

        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupHeader As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Public xrChart1 As DevExpress.XtraReports.UI.XRChart

        Private xrlblCategoryName As DevExpress.XtraReports.UI.XRLabel

        Private CategoryStyle As DevExpress.XtraReports.UI.XRControlStyle

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
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
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
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.ReportMerging.ChartReport))
            Dim staticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.xrlblCategoryName = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.CategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.AppearanceParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ColorEachParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ShowTitle = New DevExpress.XtraReports.Parameters.Parameter()
            Me.LowCategory = New DevExpress.XtraReports.Parameters.Parameter()
            Me.HighCategory = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrChart1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
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
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.Transparent
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart1, Me.xrlblCategoryName})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
            Me.Detail.HeightF = 592F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.BorderColor = System.Drawing.Color.Black
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart1.DataMember = "Categories.Products"
            xyDiagram1.AxisX.Label.Angle = 45
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.xrChart1.Diagram = xyDiagram1
            Me.xrChart1.Legend.Name = "Default Legend"
            Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 40F)
            Me.xrChart1.Name = "xrChart1"
            series1.ArgumentDataMember = "ProductName"
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "Series 1"
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            series1.ValueDataMembersSerializable = "UnitPrice"
            sideBySideBarSeriesView1.ColorEach = True
            series1.View = sideBySideBarSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.xrChart1.SizeF = New System.Drawing.SizeF(917F, 548F)
            Me.xrChart1.StylePriority.UseBackColor = False
            Me.xrChart1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrlblCategoryName
            ' 
            Me.xrlblCategoryName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName] + ' Chart'")})
            Me.xrlblCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrlblCategoryName.Name = "xrlblCategoryName"
            Me.xrlblCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlblCategoryName.SizeF = New System.Drawing.SizeF(917F, 33F)
            Me.xrlblCategoryName.StyleName = "CategoryStyle"
            Me.xrlblCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrlblCategoryName.TextFormatString = "Category: {0}"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""134"" />"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""100"" Height=""105"" />"
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            columnExpression5.ColumnName = "ProductID"
            table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""267"" />"
            table2.Name = "Products"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "ProductName"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "SupplierID"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "CategoryID"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "QuantityPerUnit"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "UnitPrice"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "UnitsInStock"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "UnitsOnOrder"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "ReorderLevel"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Discontinued"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "EAN13"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            selectQuery2.Columns.Add(column5)
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.MetaSerializable = "<Meta X=""140"" Y=""20"" Width=""100"" Height=""224"" />"
            selectQuery2.Name = "Products"
            selectQuery2.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            masterDetailInfo1.Name = "Products"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 89F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(382F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9F, DevExpress.Drawing.DXFontStyle.Italic)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(817F, 0F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrPageInfo1.TextFormatString = "Page : {0} / {1}"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.lbTitle, Me.xrPageInfo2})
            Me.ReportHeader.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowTitle")})
            Me.ReportHeader.HeightF = 50F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((132)))))), (CInt(((CByte((213)))))))
            Me.xrLine1.LineWidth = 2F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 41F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(917F, 9F)
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((132)))))), (CInt(((CByte((213)))))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(225F, 38F)
            Me.lbTitle.Text = "Products by Prices"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((132)))))), (CInt(((CByte((213)))))))
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(625F, 17F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(292F, 23F)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            Me.xrPageInfo2.TextFormatString = "{0:""Current Date: "" dddd, dd MMMM yyyy}"
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
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 119F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' AppearanceParameter
            ' 
            Me.AppearanceParameter.Description = "Chart Appearance"
            Me.AppearanceParameter.Name = "AppearanceParameter"
            Me.AppearanceParameter.ValueInfo = "Default"
            staticListLookUpSettings1.FilterString = Nothing
            Me.AppearanceParameter.ValueSourceSettings = staticListLookUpSettings1
            ' 
            ' ColorEachParameter
            ' 
            Me.ColorEachParameter.Description = "Color Each Bar"
            Me.ColorEachParameter.Name = "ColorEachParameter"
            Me.ColorEachParameter.Type = GetType(Boolean)
            Me.ColorEachParameter.ValueInfo = "True"
            ' 
            ' ShowTitle
            ' 
            Me.ShowTitle.Description = "Show Title"
            Me.ShowTitle.Name = "ShowTitle"
            Me.ShowTitle.Type = GetType(Boolean)
            Me.ShowTitle.ValueInfo = "True"
            Me.ShowTitle.Visible = False
            ' 
            ' LowCategory
            ' 
            Me.LowCategory.Description = "Low Category"
            Me.LowCategory.Name = "LowCategory"
            Me.LowCategory.Type = GetType(Integer)
            Me.LowCategory.ValueInfo = "0"
            Me.LowCategory.Visible = False
            ' 
            ' HighCategory
            ' 
            Me.HighCategory.Description = "High Category"
            Me.HighCategory.Name = "HighCategory"
            Me.HighCategory.Type = GetType(Integer)
            Me.HighCategory.ValueInfo = "10000"
            Me.HighCategory.Visible = False
            ' 
            ' ChartReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.topMarginBand1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.FilterString = "[CategoryID] >= ?LowCategory And [CategoryID] <= ?HighCategory"
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 80, 119, 89)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.AppearanceParameter, Me.ColorEachParameter, Me.ShowTitle, Me.LowCategory, Me.HighCategory})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 1
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.OddStyle, Me.GroupHeader, Me.EvenStyle, Me.CategoryStyle})
            Me.Version = "21.2"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.Report_BeforePrint)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrChart1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private AppearanceParameter As DevExpress.XtraReports.Parameters.Parameter

        Private ColorEachParameter As DevExpress.XtraReports.Parameters.Parameter

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private ShowTitle As DevExpress.XtraReports.Parameters.Parameter

        Private LowCategory As DevExpress.XtraReports.Parameters.Parameter

        Private HighCategory As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
