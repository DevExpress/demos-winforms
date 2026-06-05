Imports System.Globalization
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.Sparkline

    Public Class Report
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private Detail As DetailBand

        Private bottomMarginBand1 As BottomMarginBand

        Private GroupHeader As GroupHeaderBand

        Private calcSum As CalculatedField

        Private calcAverage As CalculatedField

        Private GroupFooter As GroupFooterBand

        Private tableDetail As XRTable

        Private xrTableRow1 As XRTableRow

        Private xrTableCell1 As XRTableCell

        Private xrTableCell2 As XRTableCell

        Private xrTableCell3 As XRTableCell

        Private xrTableCell4 As XRTableCell

        Private sparkline As XRSparkline

        Private tableGroupFooter As XRTable

        Private xrTableRow3 As XRTableRow

        Private xrTableCell10 As XRTableCell

        Private xrTableCell11 As XRTableCell

        Private xrTableCell12 As XRTableCell

        Private xrTableCell13 As XRTableCell

        Private PageHeader As PageHeaderBand

        Private tablePageHeader As XRTable

        Private xrTableRow2 As XRTableRow

        Private xrTableCell5 As XRTableCell

        Private xrTableCell6 As XRTableCell

        Private xrTableCell7 As XRTableCell

        Private xrTableCell8 As XRTableCell

        Private xrTableCell9 As XRTableCell

        Private tableGroupHeader As XRTable

        Private xrTableRow4 As XRTableRow

        Private xrTableCell14 As XRTableCell

        Private xrTableCell15 As XRTableCell

        Friend xrPictureBox1 As XRPictureBox

        Private xrPageInfo1 As XRPageInfo

        Private xrTableCell16 As XRTableCell

        Private oddStyle As XRControlStyle

        Private dsContacts1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private components As System.ComponentModel.IContainer

        Private evenStyle As XRControlStyle

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SparklineName
            DisplayName = ReportNames.Sparkline
        End Sub

        Private Sub xrSparkline1_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            sparkline.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).[Select](Function(x) GetCurrentColumnValue(x)).ToArray()
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim lineSparklineView1 As DevExpress.Sparkline.LineSparklineView = New DevExpress.Sparkline.LineSparklineView()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim xrSummary1 As XRSummary = New XRSummary()
            Dim xrSummary2 As XRSummary = New XRSummary()
            Dim xrSummary3 As XRSummary = New XRSummary()
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
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            topMarginBand1 = New TopMarginBand()
            Detail = New DetailBand()
            sparkline = New XRSparkline()
            tableDetail = New XRTable()
            xrTableRow1 = New XRTableRow()
            xrTableCell1 = New XRTableCell()
            xrTableCell2 = New XRTableCell()
            xrTableCell3 = New XRTableCell()
            xrTableCell4 = New XRTableCell()
            bottomMarginBand1 = New BottomMarginBand()
            xrPageInfo1 = New XRPageInfo()
            xrPictureBox1 = New XRPictureBox()
            GroupHeader = New GroupHeaderBand()
            tableGroupHeader = New XRTable()
            xrTableRow4 = New XRTableRow()
            xrTableCell14 = New XRTableCell()
            xrTableCell15 = New XRTableCell()
            calcSum = New CalculatedField()
            calcAverage = New CalculatedField()
            GroupFooter = New GroupFooterBand()
            tableGroupFooter = New XRTable()
            xrTableRow3 = New XRTableRow()
            xrTableCell10 = New XRTableCell()
            xrTableCell16 = New XRTableCell()
            xrTableCell11 = New XRTableCell()
            xrTableCell12 = New XRTableCell()
            xrTableCell13 = New XRTableCell()
            PageHeader = New PageHeaderBand()
            tablePageHeader = New XRTable()
            xrTableRow2 = New XRTableRow()
            xrTableCell5 = New XRTableCell()
            xrTableCell6 = New XRTableCell()
            xrTableCell7 = New XRTableCell()
            xrTableCell8 = New XRTableCell()
            xrTableCell9 = New XRTableCell()
            oddStyle = New XRControlStyle()
            evenStyle = New XRControlStyle()
            dsContacts1 = New DevExpress.DataAccess.Sql.SqlDataSource(components)
            CType(tableDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(tableGroupHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(tableGroupFooter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(tablePageHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Name = "topMarginBand1"
            topMarginBand1.StylePriority.UseFont = False
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New XRControl() {sparkline, tableDetail})
            Detail.EvenStyleName = "evenStyle"
            Detail.HeightF = 43F
            Detail.Name = "Detail"
            Detail.OddStyleName = "oddStyle"
            ' 
            ' sparkline
            ' 
            sparkline.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
            sparkline.LocationFloat = New DevExpress.Utils.PointFloat(435F, 0F)
            sparkline.Name = "sparkline"
            sparkline.SizeF = New System.Drawing.SizeF(215F, 43F)
            sparkline.StylePriority.UseBorders = False
            lineSparklineView1.Color = System.Drawing.Color.FromArgb(116, 197, 195)
            lineSparklineView1.HighlightMaxPoint = True
            lineSparklineView1.HighlightMinPoint = True
            lineSparklineView1.MaxPointColor = System.Drawing.Color.FromArgb(150, 3, 94)
            lineSparklineView1.MaxPointMarkerSize = 6
            lineSparklineView1.MinPointColor = System.Drawing.Color.FromArgb(17, 116, 167)
            lineSparklineView1.MinPointMarkerSize = 6
            lineSparklineView1.ScaleFactor = 1F
            sparkline.View = lineSparklineView1
            sparkline.XlsxFormatString = Nothing
            AddHandler sparkline.BeforePrint, New BeforePrintEventHandler(AddressOf xrSparkline1_BeforePrint)
            ' 
            ' tableDetail
            ' 
            tableDetail.Borders = DevExpress.XtraPrinting.BorderSide.Left
            tableDetail.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            tableDetail.Name = "tableDetail"
            tableDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            tableDetail.Rows.AddRange(New XRTableRow() {xrTableRow1})
            tableDetail.SizeF = New System.Drawing.SizeF(435F, 43F)
            tableDetail.StylePriority.UseBorders = False
            tableDetail.StylePriority.UsePadding = False
            tableDetail.StylePriority.UseTextAlignment = False
            tableDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTableRow1
            ' 
            xrTableRow1.Cells.AddRange(New XRTableCell() {xrTableCell1, xrTableCell2, xrTableCell3, xrTableCell4})
            xrTableRow1.Name = "xrTableRow1"
            xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            xrTableCell1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "ID")})
            xrTableCell1.Name = "xrTableCell1"
            xrTableCell1.Text = "xrTableCell1"
            xrTableCell1.Weight = 0.280021918927671R
            ' 
            ' xrTableCell2
            ' 
            xrTableCell2.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Customer Name]")})
            xrTableCell2.Name = "xrTableCell2"
            xrTableCell2.StylePriority.UseTextAlignment = False
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell2.Weight = 1.4401123702185R
            ' 
            ' xrTableCell3
            ' 
            xrTableCell3.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "calcSum")})
            xrTableCell3.Name = "xrTableCell3"
            xrTableCell3.TextFormatString = "{0:c}"
            xrTableCell3.Weight = 0.880068677022519R
            ' 
            ' xrTableCell4
            ' 
            xrTableCell4.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "calcAverage")})
            xrTableCell4.Name = "xrTableCell4"
            xrTableCell4.StylePriority.UseTextAlignment = False
            xrTableCell4.TextFormatString = "{0:c}"
            xrTableCell4.Weight = 0.880068815054061R
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Controls.AddRange(New XRControl() {xrPageInfo1, xrPictureBox1})
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrPageInfo1
            ' 
            xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(570.75F, 10.00001F)
            xrPageInfo1.Name = "xrPageInfo1"
            xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrPageInfo1.SizeF = New System.Drawing.SizeF(79.25F, 21.16667F)
            xrPageInfo1.StylePriority.UseFont = False
            xrPageInfo1.TextFormatString = "Page : {0} / {1}"
            ' 
            ' xrPictureBox1
            ' 
            xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"))
            xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(249F, 30F)
            xrPictureBox1.Name = "xrPictureBox1"
            xrPictureBox1.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            xrPictureBox1.UseImageResolution = False
            ' 
            ' GroupHeader
            ' 
            GroupHeader.Controls.AddRange(New XRControl() {tableGroupHeader})
            GroupHeader.GroupFields.AddRange(New GroupField() {New GroupField("Year", XRColumnSortOrder.Ascending)})
            GroupHeader.HeightF = 36F
            GroupHeader.Name = "GroupHeader"
            ' 
            ' tableGroupHeader
            ' 
            tableGroupHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            tableGroupHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            tableGroupHeader.Name = "tableGroupHeader"
            tableGroupHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
            tableGroupHeader.Rows.AddRange(New XRTableRow() {xrTableRow4})
            tableGroupHeader.SizeF = New System.Drawing.SizeF(650F, 36F)
            tableGroupHeader.StylePriority.UseTextAlignment = False
            tableGroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow4
            ' 
            xrTableRow4.Cells.AddRange(New XRTableCell() {xrTableCell14, xrTableCell15})
            xrTableRow4.Name = "xrTableRow4"
            xrTableRow4.Weight = 1R
            ' 
            ' xrTableCell14
            ' 
            xrTableCell14.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Year")})
            xrTableCell14.Name = "xrTableCell14"
            xrTableCell14.StylePriority.UseTextAlignment = False
            xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell14.TextFormatString = "Year: {0}"
            xrTableCell14.Weight = 1.40576914860652R
            ' 
            ' xrTableCell15
            ' 
            xrTableCell15.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumCount([Customer Name])")})
            xrTableCell15.Name = "xrTableCell15"
            xrTableCell15.StylePriority.UseBorders = False
            xrSummary1.Running = SummaryRunning.Group
            xrTableCell15.Summary = xrSummary1
            xrTableCell15.TextFormatString = "(count={0})"
            xrTableCell15.Weight = 1.59423085139348R
            ' 
            ' calcSum
            ' 
            calcSum.DataMember = "CustomersPayment"
            calcSum.DisplayName = "Sum"
            calcSum.Expression = "[April] + [August] + [December] + [February] + [January] + [July] + [June] + [Mar" & "ch] + [May] + [November] + [October] + [September]"
            calcSum.FieldType = FieldType.Double
            calcSum.Name = "calcSum"
            ' 
            ' calcAverage
            ' 
            calcAverage.DataMember = "CustomersPayment"
            calcAverage.DisplayName = "Average"
            calcAverage.Expression = "[calcSum] / 12.0"
            calcAverage.FieldType = FieldType.Double
            calcAverage.Name = "calcAverage"
            ' 
            ' GroupFooter
            ' 
            GroupFooter.Controls.AddRange(New XRControl() {tableGroupFooter})
            GroupFooter.HeightF = 30F
            GroupFooter.Name = "GroupFooter"
            ' 
            ' tableGroupFooter
            ' 
            tableGroupFooter.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            tableGroupFooter.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            tableGroupFooter.Name = "tableGroupFooter"
            tableGroupFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            tableGroupFooter.Rows.AddRange(New XRTableRow() {xrTableRow3})
            tableGroupFooter.SizeF = New System.Drawing.SizeF(650F, 30F)
            tableGroupFooter.StylePriority.UseBorders = False
            tableGroupFooter.StylePriority.UsePadding = False
            tableGroupFooter.StylePriority.UseTextAlignment = False
            tableGroupFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTableRow3
            ' 
            xrTableRow3.Cells.AddRange(New XRTableCell() {xrTableCell10, xrTableCell16, xrTableCell11, xrTableCell12, xrTableCell13})
            xrTableRow3.Name = "xrTableRow3"
            xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell10
            ' 
            xrTableCell10.Name = "xrTableCell10"
            xrTableCell10.Weight = 0.203225842748793R
            ' 
            ' xrTableCell16
            ' 
            xrTableCell16.Name = "xrTableCell16"
            xrTableCell16.Weight = 1.04516120486701R
            ' 
            ' xrTableCell11
            ' 
            xrTableCell11.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumSum(calcSum)")})
            xrTableCell11.Name = "xrTableCell11"
            xrSummary2.Running = SummaryRunning.Group
            xrTableCell11.Summary = xrSummary2
            xrTableCell11.TextFormatString = "{0:c}"
            xrTableCell11.Weight = 0.638709829467386R
            ' 
            ' xrTableCell12
            ' 
            xrTableCell12.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumAvg(calcAverage)")})
            xrTableCell12.Name = "xrTableCell12"
            xrSummary3.Running = SummaryRunning.Group
            xrTableCell12.Summary = xrSummary3
            xrTableCell12.TextFormatString = "{0:c}"
            xrTableCell12.Weight = 0.638709652268553R
            ' 
            ' xrTableCell13
            ' 
            xrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell13.Name = "xrTableCell13"
            xrTableCell13.StylePriority.UseBorders = False
            xrTableCell13.Weight = 1.24838687041697R
            ' 
            ' PageHeader
            ' 
            PageHeader.Controls.AddRange(New XRControl() {tablePageHeader})
            PageHeader.HeightF = 26F
            PageHeader.Name = "PageHeader"
            PageHeader.StylePriority.UseFont = False
            ' 
            ' tablePageHeader
            ' 
            tablePageHeader.BackColor = System.Drawing.Color.FromArgb(143, 143, 143)
            tablePageHeader.BorderColor = System.Drawing.Color.FromArgb(122, 122, 122)
            tablePageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            tablePageHeader.ForeColor = System.Drawing.Color.White
            tablePageHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            tablePageHeader.Name = "tablePageHeader"
            tablePageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 3, 0, 0, 100F)
            tablePageHeader.Rows.AddRange(New XRTableRow() {xrTableRow2})
            tablePageHeader.SizeF = New System.Drawing.SizeF(650F, 26F)
            tablePageHeader.StylePriority.UseBackColor = False
            tablePageHeader.StylePriority.UseBorderColor = False
            tablePageHeader.StylePriority.UseBorders = False
            tablePageHeader.StylePriority.UseForeColor = False
            tablePageHeader.StylePriority.UsePadding = False
            tablePageHeader.StylePriority.UseTextAlignment = False
            tablePageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow2
            ' 
            xrTableRow2.Cells.AddRange(New XRTableCell() {xrTableCell5, xrTableCell6, xrTableCell7, xrTableCell8, xrTableCell9})
            xrTableRow2.Name = "xrTableRow2"
            xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            xrTableCell5.Name = "xrTableCell5"
            xrTableCell5.Text = "ID"
            xrTableCell5.Weight = 0.161538455669696R
            ' 
            ' xrTableCell6
            ' 
            xrTableCell6.Name = "xrTableCell6"
            xrTableCell6.StylePriority.UseBackColor = False
            xrTableCell6.Text = "Customer Name"
            xrTableCell6.Weight = 0.830769260113056R
            ' 
            ' xrTableCell7
            ' 
            xrTableCell7.Name = "xrTableCell7"
            xrTableCell7.Text = "Sum"
            xrTableCell7.Weight = 0.507692295954778R
            ' 
            ' xrTableCell8
            ' 
            xrTableCell8.Name = "xrTableCell8"
            xrTableCell8.Text = "Average"
            xrTableCell8.Weight = 0.507692319429838R
            ' 
            ' xrTableCell9
            ' 
            xrTableCell9.Name = "xrTableCell9"
            xrTableCell9.Text = "Payments"
            xrTableCell9.Weight = 0.992307668832632R
            ' 
            ' oddStyle
            ' 
            oddStyle.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210)
            oddStyle.Name = "oddStyle"
            oddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' evenStyle
            ' 
            evenStyle.BackColor = System.Drawing.Color.FromArgb(247, 247, 247)
            evenStyle.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210)
            evenStyle.Name = "evenStyle"
            evenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' dsContacts1
            ' 
            dsContacts1.ConnectionName = "ContactsConnectionString"
            dsContacts1.Name = "dsContacts1"
            columnExpression1.ColumnName = "ID"
            table1.Name = "CustomersPayment"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Customer Name"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Year"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "January"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "February"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "March"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "April"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "May"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "June"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "July"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "August"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "September"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "October"
            columnExpression13.Table = table1
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "November"
            columnExpression14.Table = table1
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "December"
            columnExpression15.Table = table1
            column15.Expression = columnExpression15
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
            selectQuery1.Columns.Add(column13)
            selectQuery1.Columns.Add(column14)
            selectQuery1.Columns.Add(column15)
            selectQuery1.Name = "CustomersPayment"
            selectQuery1.Tables.Add(table1)
            dsContacts1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            dsContacts1.ResultSchemaSerializable = resources.GetString("dsContacts1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Bands.AddRange(New Band() {topMarginBand1, Detail, bottomMarginBand1, GroupHeader, GroupFooter, PageHeader})
            BorderColor = System.Drawing.Color.FromArgb(210, 210, 210)
            CalculatedFields.AddRange(New CalculatedField() {calcSum, calcAverage})
            DataMember = "CustomersPayment"
            DataSource = dsContacts1
            Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
            StyleSheet.AddRange(New XRControlStyle() {oddStyle, evenStyle})
            Version = "21.2"
            CType(tableDetail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(tableGroupHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(tableGroupFooter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(tablePageHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
