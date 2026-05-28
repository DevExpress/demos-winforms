Namespace XtraReportsDemos.MasterDetailReport

    Public Partial Class Report

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

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.MasterDetailReport.Report))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable6 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.orderDates = New DevExpress.XtraReports.Parameters.Parameter()
            Me.orderDates_Start = New DevExpress.XtraReports.Parameters.RangeStartParameter()
            Me.orderDates_End = New DevExpress.XtraReports.Parameters.RangeEndParameter()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 77F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 30F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2, Me.xrTable1})
            Me.Detail.HeightF = 63.00001F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.xrTable6, Me.xrLabel1})
            Me.ReportHeader.HeightF = 215F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.GroupFooter1})
            Me.DetailReport.DataMember = "Customers.CustomersOrders_1"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.PageFooter.HeightF = 50F
            Me.PageFooter.Name = "PageFooter"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 31.00001F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(690F, 32F)
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.Transparent
            Me.xrTable1.BorderColor = System.Drawing.Color.White
            Me.xrTable1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.BorderWidth = 2F
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable1.ForeColor = System.Drawing.Color.White
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(690F, 31F)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseBorderWidth = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1.28R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")})
            Me.xrTableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell6.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell6.StylePriority.UseFont = False
            Me.xrTableCell6.StylePriority.UseForeColor = False
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.Text = "Company"
            Me.xrTableCell6.Weight = 1.942196197509765R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City]")})
            Me.xrTableCell7.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell7.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell7.StylePriority.UseFont = False
            Me.xrTableCell7.StylePriority.UseForeColor = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.Text = "City"
            Me.xrTableCell7.Weight = 1.1432655334472659R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[State]")})
            Me.xrTableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell8.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell8.Multiline = True
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell8.StylePriority.UseFont = False
            Me.xrTableCell8.StylePriority.UseForeColor = False
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.Text = "State"
            Me.xrTableCell8.Weight = 1.1709265136718747R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomersOrders_1][].Count()")})
            Me.xrTableCell9.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell9.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell9.Multiline = True
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell9.StylePriority.UseFont = False
            Me.xrTableCell9.StylePriority.UseForeColor = False
            Me.xrTableCell9.StylePriority.UsePadding = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Orders"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell9.Weight = 0.84731903076171877R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomersOrders_1][].Avg([TotalAmount])")})
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell10.StylePriority.UseFont = False
            Me.xrTableCell10.StylePriority.UseForeColor = False
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Average Sale Amount"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell10.TextFormatString = "{0:c2}"
            Me.xrTableCell10.Weight = 1.7962927246093756R
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 0.88571428571428579R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((88)))))), (CInt(((CByte((105)))))))
            Me.xrTableCell1.BorderColor = System.Drawing.Color.White
            Me.xrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell1.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 7, 0, 100F)
            Me.xrTableCell1.StylePriority.UseBackColor = False
            Me.xrTableCell1.StylePriority.UseBorderColor = False
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.Text = "Company"
            Me.xrTableCell1.Weight = 1.942196197509765R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((88)))))), (CInt(((CByte((105)))))))
            Me.xrTableCell2.BorderColor = System.Drawing.Color.White
            Me.xrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell2.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 7, 0, 100F)
            Me.xrTableCell2.StylePriority.UseBackColor = False
            Me.xrTableCell2.StylePriority.UseBorderColor = False
            Me.xrTableCell2.StylePriority.UseBorders = False
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.Text = "City"
            Me.xrTableCell2.Weight = 1.1432661437988278R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((88)))))), (CInt(((CByte((105)))))))
            Me.xrTableCell3.BorderColor = System.Drawing.Color.White
            Me.xrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 7, 0, 100F)
            Me.xrTableCell3.StylePriority.UseBackColor = False
            Me.xrTableCell3.StylePriority.UseBorderColor = False
            Me.xrTableCell3.StylePriority.UseBorders = False
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.Text = "State"
            Me.xrTableCell3.Weight = 1.1709259033203123R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((88)))))), (CInt(((CByte((105)))))))
            Me.xrTableCell4.BorderColor = System.Drawing.Color.White
            Me.xrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell4.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 7, 0, 100F)
            Me.xrTableCell4.StylePriority.UseBackColor = False
            Me.xrTableCell4.StylePriority.UseBorderColor = False
            Me.xrTableCell4.StylePriority.UseBorders = False
            Me.xrTableCell4.StylePriority.UseFont = False
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.Text = "Orders"
            Me.xrTableCell4.Weight = 0.847317810058594R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((79)))))), (CInt(((CByte((88)))))), (CInt(((CByte((105)))))))
            Me.xrTableCell5.BorderColor = System.Drawing.Color.White
            Me.xrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell5.StylePriority.UseBackColor = False
            Me.xrTableCell5.StylePriority.UseBorderColor = False
            Me.xrTableCell5.StylePriority.UseBorders = False
            Me.xrTableCell5.StylePriority.UseFont = False
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "Average Sale Amount"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell5.Weight = 1.7962939453125002R
            ' 
            ' label1
            ' 
            Me.label1.AllowMarkupText = True
            Me.label1.CanGrow = False
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("label1.ExpressionBindings"))})
            Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((164)))))), (CInt(((CByte((169)))))), (CInt(((CByte((184)))))))
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 36.29698F)
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 2, 0, 0, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(350F, 23F)
            Me.label1.StylePriority.UseFont = False
            Me.label1.StylePriority.UseForeColor = False
            Me.label1.StylePriority.UsePadding = False
            Me.label1.WordWrap = False
            ' 
            ' xrTable6
            ' 
            Me.xrTable6.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((66)))))), (CInt(((CByte((72)))))))
            Me.xrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 83.49725F)
            Me.xrTable6.Name = "xrTable6"
            Me.xrTable6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow6, Me.xrTableRow7})
            Me.xrTable6.SizeF = New System.Drawing.SizeF(690F, 102.8315F)
            Me.xrTable6.StylePriority.UseForeColor = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(350F, 36.29698F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "Revenue by Customer"
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell23, Me.xrTableCell29, Me.xrTableCell24, Me.xrTableCell31, Me.xrTableCell25})
            Me.xrTableRow6.Font = New DevExpress.Drawing.DXFont("Arial", 20F)
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.StylePriority.UseFont = False
            Me.xrTableRow6.Weight = 1.3703741252770421R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell26, Me.xrTableCell30, Me.xrTableCell27, Me.xrTableCell32, Me.xrTableCell28})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Weight = 0.85752626534795828R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell23.BorderWidth = 0F
            Me.xrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CustomersOrders_1.TotalAmount])")})
            Me.xrTableCell23.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell23.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell23.Multiline = True
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 28, 0, 100F)
            Me.xrTableCell23.StylePriority.UseBackColor = False
            Me.xrTableCell23.StylePriority.UseBorderWidth = False
            Me.xrTableCell23.StylePriority.UseFont = False
            Me.xrTableCell23.StylePriority.UseForeColor = False
            Me.xrTableCell23.StylePriority.UsePadding = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell23.Summary = xrSummary1
            Me.xrTableCell23.Text = "xrTableCell23"
            Me.xrTableCell23.TextFormatString = "{0:c0}"
            Me.xrTableCell23.Weight = 1.7124047654696901R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell29.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell29.Multiline = True
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.StylePriority.UseFont = False
            Me.xrTableCell29.StylePriority.UseForeColor = False
            Me.xrTableCell29.Weight = 0.24438669604995517R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([CustomersOrders_1.OrderId])")})
            Me.xrTableCell24.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell24.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell24.Multiline = True
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 28, 0, 100F)
            Me.xrTableCell24.StylePriority.UseBackColor = False
            Me.xrTableCell24.StylePriority.UseFont = False
            Me.xrTableCell24.StylePriority.UseForeColor = False
            Me.xrTableCell24.StylePriority.UsePadding = False
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell24.Summary = xrSummary2
            Me.xrTableCell24.Text = "xrTableCell24"
            Me.xrTableCell24.Weight = 1.6922230147696711R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell31.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell31.Multiline = True
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.StylePriority.UseFont = False
            Me.xrTableCell31.StylePriority.UseForeColor = False
            Me.xrTableCell31.Weight = 0.2443867061318537R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([CustomersOrders_1.TotalAmount])")})
            Me.xrTableCell25.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell25.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell25.Multiline = True
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 28, 0, 100F)
            Me.xrTableCell25.StylePriority.UseBackColor = False
            Me.xrTableCell25.StylePriority.UseFont = False
            Me.xrTableCell25.StylePriority.UseForeColor = False
            Me.xrTableCell25.StylePriority.UsePadding = False
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell25.Summary = xrSummary3
            Me.xrTableCell25.Text = "xrTableCell25"
            Me.xrTableCell25.TextFormatString = "{0:c0}"
            Me.xrTableCell25.Weight = 1.72749300254838R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell26.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell26.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrTableCell26.Multiline = True
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 0, 0, 100F)
            Me.xrTableCell26.StylePriority.UseBackColor = False
            Me.xrTableCell26.StylePriority.UseFont = False
            Me.xrTableCell26.StylePriority.UseForeColor = False
            Me.xrTableCell26.StylePriority.UsePadding = False
            Me.xrTableCell26.Text = "Total Revenue"
            Me.xrTableCell26.Weight = 1.7124045770592693R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell30.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrTableCell30.Multiline = True
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.StylePriority.UseFont = False
            Me.xrTableCell30.StylePriority.UseForeColor = False
            Me.xrTableCell30.Weight = 0.24438666790668204R
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell27.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell27.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrTableCell27.Multiline = True
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 0, 0, 100F)
            Me.xrTableCell27.StylePriority.UseBackColor = False
            Me.xrTableCell27.StylePriority.UseFont = False
            Me.xrTableCell27.StylePriority.UseForeColor = False
            Me.xrTableCell27.StylePriority.UsePadding = False
            Me.xrTableCell27.Text = "Order Count"
            Me.xrTableCell27.Weight = 1.692222630040523R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell32.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrTableCell32.Multiline = True
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.StylePriority.UseFont = False
            Me.xrTableCell32.StylePriority.UseForeColor = False
            Me.xrTableCell32.Weight = 0.24438667563632305R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTableCell28.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell28.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrTableCell28.Multiline = True
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(32, 2, 0, 0, 100F)
            Me.xrTableCell28.StylePriority.UseBackColor = False
            Me.xrTableCell28.StylePriority.UseFont = False
            Me.xrTableCell28.StylePriority.UseForeColor = False
            Me.xrTableCell28.StylePriority.UsePadding = False
            Me.xrTableCell28.Text = "Average Sale Amount"
            Me.xrTableCell28.Weight = 1.727492922632287R
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3})
            Me.Detail1.HeightF = 31F
            Me.Detail1.Name = "Detail1"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable4})
            Me.GroupHeader1.HeightF = 31F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6})
            Me.GroupFooter1.HeightF = 54.57185F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(690F, 31F)
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.OddStyleName = "xrControlStyle1"
            Me.xrTableRow3.Weight = 14.260000000000002R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetDate([OrderDate])")})
            Me.xrTableCell11.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell11.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell11.Multiline = True
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StylePriority.UseFont = False
            Me.xrTableCell11.StylePriority.UseForeColor = False
            Me.xrTableCell11.StylePriority.UsePadding = False
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "xrTableCell11"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell11.TextFormatString = "{0:d}"
            Me.xrTableCell11.Weight = 0.72809835580679083R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNumber]")})
            Me.xrTableCell12.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell12.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell12.Multiline = True
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell12.StylePriority.UseFont = False
            Me.xrTableCell12.StylePriority.UseForeColor = False
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.Weight = 0.736111098069411R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EmployeeName]")})
            Me.xrTableCell13.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell13.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell13.StylePriority.UseFont = False
            Me.xrTableCell13.StylePriority.UseForeColor = False
            Me.xrTableCell13.StylePriority.UsePadding = False
            Me.xrTableCell13.Text = "xrTableCell13"
            Me.xrTableCell13.Weight = 0.83291547726362192R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
            Me.xrTableCell14.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell14.Multiline = True
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 0, 100F)
            Me.xrTableCell14.StylePriority.UseFont = False
            Me.xrTableCell14.StylePriority.UsePadding = False
            Me.xrTableCell14.StylePriority.UseTextAlignment = False
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell14.Weight = 0.609926037910657R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")})
            Me.xrTableCell15.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell15.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrTableCell15.Multiline = True
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell15.StylePriority.UseFont = False
            Me.xrTableCell15.StylePriority.UseForeColor = False
            Me.xrTableCell15.StylePriority.UsePadding = False
            Me.xrTableCell15.StylePriority.UseTextAlignment = False
            Me.xrTableCell15.Text = "xrTableCell15"
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell15.TextFormatString = "{0:c2}"
            Me.xrTableCell15.Weight = 0.63141056941105766R
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Iif([ShipmentStatus]=2,[Images.DeliveredIcon],[ShipmentStatus]=1,[Images.InTransi" & "tIcon],[Images.PendingIcon])")})
            Me.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(118.9356F, 31F)
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow4})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(690F, 31F)
            Me.xrTable4.StylePriority.UseFont = False
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18, Me.xrTableCell19, Me.xrTableCell20})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 14.260000000000002R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((199)))))), (CInt(((CByte((202)))))))
            Me.xrTableCell16.BorderColor = System.Drawing.Color.White
            Me.xrTableCell16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell16.BorderWidth = 2F
            Me.xrTableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell16.ForeColor = System.Drawing.Color.White
            Me.xrTableCell16.Multiline = True
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 7, 0, 100F)
            Me.xrTableCell16.StylePriority.UseBackColor = False
            Me.xrTableCell16.StylePriority.UseBorderColor = False
            Me.xrTableCell16.StylePriority.UseBorders = False
            Me.xrTableCell16.StylePriority.UseBorderWidth = False
            Me.xrTableCell16.StylePriority.UseFont = False
            Me.xrTableCell16.StylePriority.UseForeColor = False
            Me.xrTableCell16.StylePriority.UsePadding = False
            Me.xrTableCell16.StylePriority.UseTextAlignment = False
            Me.xrTableCell16.Text = "Order Date"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrTableCell16.TextFormatString = "{0:d}"
            Me.xrTableCell16.Weight = 0.72809819930639019R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((199)))))), (CInt(((CByte((202)))))))
            Me.xrTableCell17.BorderColor = System.Drawing.Color.White
            Me.xrTableCell17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell17.BorderWidth = 2F
            Me.xrTableCell17.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell17.ForeColor = System.Drawing.Color.White
            Me.xrTableCell17.Multiline = True
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell17.StylePriority.UseBackColor = False
            Me.xrTableCell17.StylePriority.UseBorderColor = False
            Me.xrTableCell17.StylePriority.UseBorders = False
            Me.xrTableCell17.StylePriority.UseBorderWidth = False
            Me.xrTableCell17.StylePriority.UseFont = False
            Me.xrTableCell17.StylePriority.UseForeColor = False
            Me.xrTableCell17.StylePriority.UsePadding = False
            Me.xrTableCell17.Text = "Invoice #"
            Me.xrTableCell17.Weight = 0.736111098069411R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((199)))))), (CInt(((CByte((202)))))))
            Me.xrTableCell18.BorderColor = System.Drawing.Color.White
            Me.xrTableCell18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell18.BorderWidth = 2F
            Me.xrTableCell18.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell18.ForeColor = System.Drawing.Color.White
            Me.xrTableCell18.Multiline = True
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell18.StylePriority.UseBackColor = False
            Me.xrTableCell18.StylePriority.UseBorderColor = False
            Me.xrTableCell18.StylePriority.UseBorders = False
            Me.xrTableCell18.StylePriority.UseBorderWidth = False
            Me.xrTableCell18.StylePriority.UseFont = False
            Me.xrTableCell18.StylePriority.UseForeColor = False
            Me.xrTableCell18.StylePriority.UsePadding = False
            Me.xrTableCell18.Text = "Salesperson"
            Me.xrTableCell18.Weight = 0.8329159467648235R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((199)))))), (CInt(((CByte((202)))))))
            Me.xrTableCell19.BorderColor = System.Drawing.Color.White
            Me.xrTableCell19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell19.BorderWidth = 2F
            Me.xrTableCell19.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell19.ForeColor = System.Drawing.Color.White
            Me.xrTableCell19.Multiline = True
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell19.StylePriority.UseBackColor = False
            Me.xrTableCell19.StylePriority.UseBorderColor = False
            Me.xrTableCell19.StylePriority.UseBorders = False
            Me.xrTableCell19.StylePriority.UseBorderWidth = False
            Me.xrTableCell19.StylePriority.UseFont = False
            Me.xrTableCell19.StylePriority.UseForeColor = False
            Me.xrTableCell19.StylePriority.UsePadding = False
            Me.xrTableCell19.StylePriority.UseTextAlignment = False
            Me.xrTableCell19.Text = "Delivery Status"
            Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell19.Weight = 0.609926037910657R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((199)))))), (CInt(((CByte((202)))))))
            Me.xrTableCell20.BorderColor = System.Drawing.Color.White
            Me.xrTableCell20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell20.BorderWidth = 2F
            Me.xrTableCell20.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell20.ForeColor = System.Drawing.Color.White
            Me.xrTableCell20.Multiline = True
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 7, 0, 100F)
            Me.xrTableCell20.StylePriority.UseBackColor = False
            Me.xrTableCell20.StylePriority.UseBorderColor = False
            Me.xrTableCell20.StylePriority.UseBorders = False
            Me.xrTableCell20.StylePriority.UseBorderWidth = False
            Me.xrTableCell20.StylePriority.UseFont = False
            Me.xrTableCell20.StylePriority.UseForeColor = False
            Me.xrTableCell20.StylePriority.UsePadding = False
            Me.xrTableCell20.StylePriority.UseTextAlignment = False
            Me.xrTableCell20.Text = "Sale Amount"
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell20.Weight = 0.63141025641025639R
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.AllowMarkupText = True
            Me.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrLabel6.BorderWidth = 2F
            Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalAmount])")})
            Me.xrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((69)))))), (CInt(((CByte((77)))))), (CInt(((CByte((103)))))))
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel6.Multiline = True
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 8, 8, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(690F, 34.07181F)
            Me.xrLabel6.StylePriority.UseBorders = False
            Me.xrLabel6.StylePriority.UseBorderWidth = False
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UseForeColor = False
            Me.xrLabel6.StylePriority.UsePadding = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrLabel6.Summary = xrSummary4
            Me.xrLabel6.Text = "xrLabel6"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrLabel6.TextFormatString = "<color=170,175,189>Grand Total:</color>  {0:c2}"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "DevAvConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "Id"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""180"" Height=""723"" />"
            table1.Name = "Customers"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Name"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            column3.[Alias] = "StateId"
            columnExpression3.ColumnName = "HomeOfficeState"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            column4.[Alias] = "City"
            columnExpression4.ColumnName = "HomeOfficeCity"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            column5.[Alias] = "State"
            columnExpression5.ColumnName = "LongName"
            table2.MetaSerializable = "<Meta X=""240"" Y=""30"" Width=""125"" Height=""134"" />"
            table2.Name = "States"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""119"" Height=""121"" />"
            selectQuery1.Name = "Customers"
            relationColumnInfo1.NestedKeyColumn = "ShortName"
            relationColumnInfo1.ParentKeyColumn = "HomeOfficeState"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            column6.[Alias] = "OrderId"
            columnExpression6.ColumnName = "Id"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""419"" />"
            table3.Name = "Orders"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "EmployeeId"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "InvoiceNumber"
            columnExpression8.Table = table3
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "CustomerId"
            columnExpression9.Table = table3
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "OrderDate"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "TotalAmount"
            columnExpression11.Table = table3
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "ShipmentStatus"
            columnExpression12.Table = table3
            column12.Expression = columnExpression12
            column13.[Alias] = "EmployeeName"
            columnExpression13.ColumnName = "FullName"
            table4.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""609"" />"
            table4.Name = "Employees"
            columnExpression13.Table = table4
            column13.Expression = columnExpression13
            column14.[Alias] = "EmployeeTitle"
            columnExpression14.ColumnName = "Title"
            columnExpression14.Table = table4
            column14.Expression = columnExpression14
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.FilterString = "[Orders.OrderDate] Between(?orderDates_Start, ?orderDates_End)"
            selectQuery2.GroupFilterString = ""
            selectQuery2.MetaSerializable = "<Meta X=""159"" Y=""20"" Width=""114"" Height=""221"" />"
            selectQuery2.Name = "Orders_1"
            queryParameter1.Name = "orderDates_Start"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("?orderDates_Start", GetType(System.DateTime))
            queryParameter2.Name = "orderDates_End"
            queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter2.Value = New DevExpress.DataAccess.Expression("?orderDates_End", GetType(System.DateTime))
            selectQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter1, queryParameter2})
            relationColumnInfo2.NestedKeyColumn = "Id"
            relationColumnInfo2.ParentKeyColumn = "EmployeeId"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table4
            join2.Parent = table3
            selectQuery2.Relations.Add(join2)
            selectQuery2.Tables.Add(table3)
            selectQuery2.Tables.Add(table4)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Orders_1"
            relationColumnInfo3.NestedKeyColumn = "CustomerId"
            relationColumnInfo3.ParentKeyColumn = "Id"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Customers"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((175)))))), (CInt(((CByte((189)))))))
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(308.5462F, 26.99998F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseForeColor = False
            Me.xrPageInfo1.StylePriority.UseTextAlignment = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrPageInfo1.TextFormatString = "Page {0} of {1}"
            ' 
            ' xrControlStyle1
            ' 
            Me.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrControlStyle1.Name = "xrControlStyle1"
            Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' orderDates
            ' 
            Me.orderDates.Description = "Order Dates"
            Me.orderDates.Name = "orderDates"
            Me.orderDates.Type = GetType(System.DateTime)
            Me.orderDates.ValueSourceSettings = New DevExpress.XtraReports.Parameters.RangeParametersSettings(Me.orderDates_Start, Me.orderDates_End)
            ' 
            ' orderDates_Start
            ' 
            Me.orderDates_Start.Name = "orderDates_Start"
            Me.orderDates_Start.ValueInfo = "2024-06-27"
            ' 
            ' orderDates_End
            ' 
            Me.orderDates_End.Name = "orderDates_End"
            Me.orderDates_End.ValueInfo = "2024-07-27"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.DetailReport, Me.PageFooter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Master-Detail Report"
            Me.DrawWatermark = True
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.ImageResources.AddRange(New DevExpress.XtraPrinting.Drawing.ImageItem() {New DevExpress.XtraPrinting.Drawing.ImageItem("PendingIcon", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources"))), New DevExpress.XtraPrinting.Drawing.ImageItem("InTransitIcon", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources1"))), New DevExpress.XtraPrinting.Drawing.ImageItem("DeliveredIcon", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources2")))})
            Me.Margins = New DevExpress.Drawing.DXMargins(80F, 80F, 77F, 30F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.orderDates})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.xrControlStyle1})
            Me.Version = "25.1"
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private xrTable6 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private orderDates As DevExpress.XtraReports.Parameters.Parameter

        Private orderDates_Start As DevExpress.XtraReports.Parameters.RangeStartParameter

        Private orderDates_End As DevExpress.XtraReports.Parameters.RangeEndParameter
    End Class
End Namespace
