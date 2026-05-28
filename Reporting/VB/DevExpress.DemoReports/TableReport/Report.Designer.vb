Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.DataAccess

Namespace XtraReportsDemos.TableReport

    Public Partial Class Report

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.TableReport.Report))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.dsOrderDetails1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OrderIdParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
            Me.Detail.Dpi = 96F
            Me.Detail.HeightF = 90F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2, Me.pictureBox1})
            Me.ReportFooter.Dpi = 96F
            Me.ReportFooter.HeightF = 77.95918F
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.ReportFooter.PrintAtBottom = True
            Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.lbOrderID, Me.xrPageInfo1, Me.xrTable1})
            Me.PageHeader.Dpi = 96F
            Me.PageHeader.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageHeader.HeightF = 115.4961F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 96F
            Me.BottomMargin.HeightF = 72F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Dpi = 96F
            Me.topMarginBand1.HeightF = 72F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' table3
            ' 
            Me.table3.Dpi = 96F
            Me.table3.EvenStyleName = "EvenStyle"
            Me.table3.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table3.Name = "table3"
            Me.table3.OddStyleName = "OddStyle"
            Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 5, 0, 0, 96F)
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3, Me.tableRow4})
            Me.table3.SizeF = New System.Drawing.SizeF(672F, 90F)
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9})
            Me.tableRow3.Dpi = 96F
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 8.9444444444444446R
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14})
            Me.tableRow4.Dpi = 96F
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 14.055555555555555R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Dpi = 96F
            Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.tableCell5.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 2, 96F)
            Me.tableCell5.StylePriority.UseFont = False
            Me.tableCell5.StylePriority.UsePadding = False
            Me.tableCell5.Text = "tableCell5"
            Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell5.Weight = 1.6108408606389968R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Dpi = 96F
            Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.tableCell6.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F)
            Me.tableCell6.RowSpan = 2
            Me.tableCell6.StylePriority.UseFont = False
            Me.tableCell6.StylePriority.UsePadding = False
            Me.tableCell6.Text = "tableCell6"
            Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell6.TextFormatString = "{0:$#,##.00}"
            Me.tableCell6.Weight = 0.40897809652856248R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Dpi = 96F
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
            Me.tableCell7.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F)
            Me.tableCell7.RowSpan = 2
            Me.tableCell7.StylePriority.UseFont = False
            Me.tableCell7.StylePriority.UsePadding = False
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.Text = "tableCell7"
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell7.Weight = 0.40897809652856248R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Dpi = 96F
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")})
            Me.tableCell8.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F)
            Me.tableCell8.RowSpan = 2
            Me.tableCell8.StylePriority.UseFont = False
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.StylePriority.UseTextAlignment = False
            Me.tableCell8.Text = "tableCell8"
            Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell8.TextFormatString = "{0:0%}"
            Me.tableCell8.Weight = 0.40897809652856248R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.Dpi = 96F
            Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotal]")})
            Me.tableCell9.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F)
            Me.tableCell9.RowSpan = 2
            Me.tableCell9.StylePriority.UseFont = False
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.StylePriority.UseTextAlignment = False
            Me.tableCell9.Text = "tableCell9"
            Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell9.TextFormatString = "{0:$#,##.00}"
            Me.tableCell9.Weight = 0.40897809652856248R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.CanGrow = False
            Me.tableCell10.Dpi = 96F
            Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Supplier]")})
            Me.tableCell10.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
            Me.tableCell10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 10, 96F)
            Me.tableCell10.StylePriority.UseFont = False
            Me.tableCell10.StylePriority.UseForeColor = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Text = "tableCell10"
            Me.tableCell10.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
            Me.tableCell10.Weight = 1.610841087893689R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.Dpi = 96F
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.tableCell11.StylePriority.UsePadding = False
            Me.tableCell11.Text = "tableCell11"
            Me.tableCell11.Weight = 0.40897769883285096R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Dpi = 96F
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.Text = "tableCell12"
            Me.tableCell12.Weight = 0.40897815334223553R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.Dpi = 96F
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.tableCell13.StylePriority.UsePadding = False
            Me.tableCell13.Text = "tableCell13"
            Me.tableCell13.Weight = 0.40897843741060114R
            ' 
            ' tableCell14
            ' 
            Me.tableCell14.Dpi = 96F
            Me.tableCell14.Name = "tableCell14"
            Me.tableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.tableCell14.StylePriority.UsePadding = False
            Me.tableCell14.Text = "tableCell14"
            Me.tableCell14.Weight = 0.40897786927387009R
            ' 
            ' table2
            ' 
            Me.table2.Dpi = 96F
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(288F, 0F)
            Me.table2.Name = "table2"
            Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 96F)
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5, Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(384F, 77.95918F)
            Me.table2.StylePriority.UsePadding = False
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Dpi = 96F
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"))
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 30F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.pictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(149.9592F, 37.66764F)
            Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15})
            Me.tableRow5.Dpi = 96F
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1R
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4})
            Me.tableRow2.Dpi = 96F
            Me.tableRow2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 18F)
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.StylePriority.UseFont = False
            Me.tableRow2.Weight = 1.5986393230031763R
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.Dpi = 96F
            Me.tableCell15.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell15.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((190)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 96F)
            Me.tableCell15.StylePriority.UseFont = False
            Me.tableCell15.StylePriority.UseForeColor = False
            Me.tableCell15.StylePriority.UsePadding = False
            Me.tableCell15.StylePriority.UseTextAlignment = False
            Me.tableCell15.Text = "TOTAL ORDER COST"
            Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell15.Weight = 2R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell4.Dpi = 96F
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0:$0.00 }', sumSum([SubTotal]))")})
            Me.tableCell4.Font = New DevExpress.Drawing.DXFont("Segoe UI", 16F)
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 96F)
            Me.tableCell4.StylePriority.UseBorders = False
            Me.tableCell4.StylePriority.UseFont = False
            Me.tableCell4.StylePriority.UsePadding = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.tableCell4.Summary = xrSummary1
            Me.tableCell4.Text = "tableCell2"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell4.Weight = 2R
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.Dpi = 96F
            Me.pageInfo1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.pageInfo1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((190)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(576F, 62.26726F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(95.99999F, 15.35999F)
            Me.pageInfo1.StylePriority.UseFont = False
            Me.pageInfo1.StylePriority.UseForeColor = False
            Me.pageInfo1.TextFormatString = "Page {0} of {1} pages"
            ' 
            ' lbOrderID
            ' 
            Me.lbOrderID.AutoWidth = True
            Me.lbOrderID.BackColor = System.Drawing.Color.Transparent
            Me.lbOrderID.BorderWidth = 0F
            Me.lbOrderID.CanGrow = False
            Me.lbOrderID.Dpi = 96F
            Me.lbOrderID.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.lbOrderID.Font = New DevExpress.Drawing.DXFont("Segoe UI", 18F)
            Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbOrderID.Name = "lbOrderID"
            Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.lbOrderID.SizeF = New System.Drawing.SizeF(474.5528F, 31.68F)
            Me.lbOrderID.StylePriority.UseBackColor = False
            Me.lbOrderID.StylePriority.UseBorderWidth = False
            Me.lbOrderID.StylePriority.UseFont = False
            Me.lbOrderID.StylePriority.UsePadding = False
            Me.lbOrderID.StylePriority.UseTextAlignment = False
            Me.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbOrderID.TextFormatString = "Details for Customer Order # {0}"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Dpi = 96F
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((190)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 31.68001F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(239.04F, 15.36F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseForeColor = False
            Me.xrPageInfo1.StylePriority.UsePadding = False
            Me.xrPageInfo1.StylePriority.UseTextAlignment = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTable1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.BorderWidth = 2F
            Me.xrTable1.Dpi = 96F
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 7F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 85.49609F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(672F, 30F)
            Me.xrTable1.StyleName = "HeaderStyle"
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UsePadding = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell13, Me.xrTableCell3})
            Me.xrTableRow1.Dpi = 96F
            Me.xrTableRow1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BorderWidth = 1F
            Me.xrTableCell1.Dpi = 96F
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 96F)
            Me.xrTableCell1.StyleName = "HeaderStyle"
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "PRODUCT/SUPPLIER"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 0.3396643824140988R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BorderWidth = 1F
            Me.xrTableCell7.Dpi = 96F
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F)
            Me.xrTableCell7.StyleName = "HeaderStyle"
            Me.xrTableCell7.StylePriority.UseFont = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "UNIT PRICE"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.Weight = 0.086237750550321443R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BorderWidth = 1F
            Me.xrTableCell2.Dpi = 96F
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F)
            Me.xrTableCell2.StyleName = "HeaderStyle"
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "QUANTITY"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.Weight = 0.086237750550321443R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BorderWidth = 1F
            Me.xrTableCell13.Dpi = 96F
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F)
            Me.xrTableCell13.StyleName = "HeaderStyle"
            Me.xrTableCell13.StylePriority.UseFont = False
            Me.xrTableCell13.StylePriority.UsePadding = False
            Me.xrTableCell13.StylePriority.UseTextAlignment = False
            Me.xrTableCell13.Text = "DISCOUNT"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell13.Weight = 0.086237750550321443R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BorderWidth = 1F
            Me.xrTableCell3.Dpi = 96F
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F)
            Me.xrTableCell3.StyleName = "HeaderStyle"
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "SUBTOTAL"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.086237750550321443R
            ' 
            ' dsOrderDetails1
            ' 
            Me.dsOrderDetails1.ConnectionName = "NWindConnectionString"
            Me.dsOrderDetails1.Name = "dsOrderDetails1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderDetailsExtended"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Quantity"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Discount"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Supplier"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            column8.[Alias] = "SubTotal"
            customExpression1.Expression = "ToDouble([OrderDetailsExtended].[Quantity] * [OrderDetailsExtended].[UnitPrice])"
            column8.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.FilterString = "[OrderDetailsExtended.OrderID] = ?OrderIdParameter"
            selectQuery1.Name = "OrderDetails"
            queryParameter1.Name = "OrderIdParameter"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.OrderIdParameter]", GetType(Integer))
            selectQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter1})
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
            columnExpression8.ColumnName = "ExtendedPrice"
            columnExpression8.Table = table1
            sorting1.Expression = columnExpression8
            selectQuery1.Sorting.Add(sorting1)
            selectQuery1.Tables.Add(table1)
            Me.dsOrderDetails1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsOrderDetails1.ResultSchemaSerializable = resources.GetString("dsOrderDetails1.ResultSchemaSerializable")
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.White
            Me.EvenStyle.BorderColor = System.Drawing.Color.Transparent
            Me.EvenStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 96F)
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((234)))))), (CInt(((CByte((245)))))), (CInt(((CByte((255)))))))
            Me.OddStyle.BorderColor = System.Drawing.Color.Transparent
            Me.OddStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 96F)
            ' 
            ' HeaderStyle
            ' 
            Me.HeaderStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.HeaderStyle.BorderColor = System.Drawing.Color.Gray
            Me.HeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.HeaderStyle.BorderWidth = 1F
            Me.HeaderStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.HeaderStyle.Name = "HeaderStyle"
            Me.HeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 96F)
            ' 
            ' OrderIdParameter
            ' 
            Me.OrderIdParameter.Description = "Order Id"
            Me.OrderIdParameter.Name = "OrderIdParameter"
            Me.OrderIdParameter.Type = GetType(Integer)
            Me.OrderIdParameter.ValueInfo = "11077"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportFooter, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsOrderDetails1})
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.dsOrderDetails1
            Me.DisplayName = "Table Report"
            Me.Dpi = 96F
            Me.Extensions.Add("DataSerializationExtension", "Table Report")
            Me.Extensions.Add("DataEditorExtension", "Table Report")
            Me.Extensions.Add("ParameterEditorExtension", "Table Report")
            Me.Margins = New DevExpress.Drawing.DXMargins(72F, 72F, 72F, 72F)
            Me.PageHeight = 1056
            Me.PageWidth = 816
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.OrderIdParameter})
            Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels
            Me.RequestParameters = False
            Me.SnapGridSize = 12F
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EvenStyle, Me.OddStyle, Me.HeaderStyle})
            Me.Version = "25.1"
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private lbOrderID As DevExpress.XtraReports.UI.XRLabel

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private dsOrderDetails1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private OrderIdParameter As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
