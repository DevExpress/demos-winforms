Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.NorthwindTraders

    Partial Class InvoiceReport

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
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.NorthwindTraders.InvoiceReport))
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column34 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table10 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.line2 = New DevExpress.XtraReports.UI.XRLine()
            Me.table7 = New DevExpress.XtraReports.UI.XRTable()
            Me.barCode2 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.table8 = New DevExpress.XtraReports.UI.XRTable()
            Me.pictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.table9 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow30 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow31 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow32 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow33 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Foreground = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ForegroundDisabled = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SimpleTextStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.NetPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.SumUnitPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.DiscountTotal = New DevExpress.XtraReports.UI.CalculatedField()
            Me.AmountPaid = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.paramCompany = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
            Me.Detail.HeightF = 205.2083F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 0F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 59.375F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.GroupFooter1})
            Me.DetailReport.DataMember = "Orders.OrdersOrderDetails"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((239)))))), (CInt(((CByte((241)))))), (CInt(((CByte((245)))))))
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.PageHeader.HeightF = 207.2917F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.StylePriority.UseBackColor = False
            ' 
            ' table3
            ' 
            Me.table3.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(65.625F, 23.36403F)
            Me.table3.Name = "table3"
            Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow13, Me.tableRow8, Me.tableRow9, Me.tableRow10, Me.tableRow11, Me.tableRow12})
            Me.table3.SizeF = New System.Drawing.SizeF(396.92F, 145.0015F)
            Me.table3.StylePriority.UseFont = False
            ' 
            ' tableRow13
            ' 
            Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10, Me.xrTableCell13})
            Me.tableRow13.Name = "tableRow13"
            Me.tableRow13.Weight = 1.97230270460737R
            ' 
            ' tableRow8
            ' 
            Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15, Me.tableCell16})
            Me.tableRow8.Name = "tableRow8"
            Me.tableRow8.Weight = 1R
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17, Me.tableCell18})
            Me.tableRow9.Name = "tableRow9"
            Me.tableRow9.Weight = 1R
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell19, Me.tableCell20})
            Me.tableRow10.Name = "tableRow10"
            Me.tableRow10.Weight = 1R
            ' 
            ' tableRow11
            ' 
            Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21, Me.tableCell22})
            Me.tableRow11.Name = "tableRow11"
            Me.tableRow11.Weight = 1R
            ' 
            ' tableRow12
            ' 
            Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell23, Me.tableCell24})
            Me.tableRow12.Name = "tableRow12"
            Me.tableRow12.Weight = 1R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell10.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell10.StyleName = "SimpleTextStyle"
            Me.tableCell10.StylePriority.UseFont = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Text = "Bill to:"
            Me.tableCell10.Weight = 0.60336829956185767R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.xrTableCell13.StyleName = "SimpleTextStyle"
            Me.xrTableCell13.StylePriority.UseFont = False
            Me.xrTableCell13.StylePriority.UsePadding = False
            Me.xrTableCell13.Weight = 1.0426587834128349R
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell15.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell15.Multiline = True
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell15.StyleName = "ForegroundDisabled"
            Me.tableCell15.StylePriority.UseFont = False
            Me.tableCell15.StylePriority.UsePadding = False
            Me.tableCell15.StylePriority.UseTextAlignment = False
            Me.tableCell15.Text = "Company:"
            Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell15.Weight = 0.60336805972201224R
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.CanGrow = False
            Me.tableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
            Me.tableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell16.Multiline = True
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.StyleName = "SimpleTextStyle"
            Me.tableCell16.StylePriority.UseFont = False
            Me.tableCell16.Weight = 1.0426590232526805R
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell17.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell17.Multiline = True
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell17.StyleName = "ForegroundDisabled"
            Me.tableCell17.StylePriority.UseFont = False
            Me.tableCell17.StylePriority.UsePadding = False
            Me.tableCell17.StylePriority.UseTextAlignment = False
            Me.tableCell17.Text = "Contact Name:"
            Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell17.Weight = 0.60336805972201224R
            ' 
            ' tableCell18
            ' 
            Me.tableCell18.CanGrow = False
            Me.tableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
            Me.tableCell18.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell18.Multiline = True
            Me.tableCell18.Name = "tableCell18"
            Me.tableCell18.StyleName = "SimpleTextStyle"
            Me.tableCell18.StylePriority.UseFont = False
            Me.tableCell18.Weight = 1.0426590232526805R
            ' 
            ' tableCell19
            ' 
            Me.tableCell19.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell19.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell19.Multiline = True
            Me.tableCell19.Name = "tableCell19"
            Me.tableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell19.StyleName = "ForegroundDisabled"
            Me.tableCell19.StylePriority.UseFont = False
            Me.tableCell19.StylePriority.UsePadding = False
            Me.tableCell19.StylePriority.UseTextAlignment = False
            Me.tableCell19.Text = "Address:"
            Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell19.Weight = 0.60336805972201224R
            ' 
            ' tableCell20
            ' 
            Me.tableCell20.CanGrow = False
            Me.tableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0}, {1}, {2}, {3}', [Address], [City], [Country], [PostalCode])")})
            Me.tableCell20.Multiline = True
            Me.tableCell20.Name = "tableCell20"
            Me.tableCell20.StyleName = "SimpleTextStyle"
            Me.tableCell20.Weight = 1.0426590232526805R
            ' 
            ' tableCell21
            ' 
            Me.tableCell21.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell21.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell21.Multiline = True
            Me.tableCell21.Name = "tableCell21"
            Me.tableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell21.StyleName = "ForegroundDisabled"
            Me.tableCell21.StylePriority.UseFont = False
            Me.tableCell21.StylePriority.UsePadding = False
            Me.tableCell21.StylePriority.UseTextAlignment = False
            Me.tableCell21.Text = "Phone:" & Global.Microsoft.VisualBasic.Constants.vbTab
            Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell21.Weight = 0.60336805972201224R
            ' 
            ' tableCell22
            ' 
            Me.tableCell22.CanGrow = False
            Me.tableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            Me.tableCell22.Multiline = True
            Me.tableCell22.Name = "tableCell22"
            Me.tableCell22.StyleName = "SimpleTextStyle"
            Me.tableCell22.Weight = 1.0426590232526805R
            ' 
            ' tableCell23
            ' 
            Me.tableCell23.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell23.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell23.Multiline = True
            Me.tableCell23.Name = "tableCell23"
            Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell23.StyleName = "ForegroundDisabled"
            Me.tableCell23.StylePriority.UseFont = False
            Me.tableCell23.StylePriority.UsePadding = False
            Me.tableCell23.StylePriority.UseTextAlignment = False
            Me.tableCell23.Text = "Mail:"
            Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell23.Weight = 0.60336805972201224R
            ' 
            ' tableCell24
            ' 
            Me.tableCell24.CanGrow = False
            Me.tableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat(Lower(Replace([CompanyName],' ','')), '@mail.com')")})
            Me.tableCell24.Multiline = True
            Me.tableCell24.Name = "tableCell24"
            Me.tableCell24.StyleName = "SimpleTextStyle"
            Me.tableCell24.Weight = 1.0426590232526805R
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail1.FillEmptySpace = True
            Me.Detail1.HeightF = 31.25F
            Me.Detail1.Name = "Detail1"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.GroupHeader1.HeightF = 32.29167F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.line2, Me.table7, Me.barCode2, Me.table8, Me.pictureBox3, Me.table9})
            Me.GroupFooter1.HeightF = 283.5869F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PrintAtBottom = True
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTable1.BorderWidth = 1F
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(80.64301F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(689.3542F, 31.25F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseBorderWidth = False
            Me.xrTable1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTableRow1.StylePriority.UsePadding = False
            Me.xrTableRow1.Weight = 13.895833333333334R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.CanGrow = False
            Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([ProductName])")})
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 5, 5, 100F)
            Me.xrTableCell11.StyleName = "SimpleTextStyle"
            Me.xrTableCell11.StylePriority.UsePadding = False
            xrSummary1.IgnoreNullValues = True
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell11.Summary = xrSummary1
            Me.xrTableCell11.TextFormatString = "{0:00}"
            Me.xrTableCell11.Weight = 0.34866643084144R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.CanGrow = False
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 5, 5, 5, 100F)
            Me.xrTableCell1.StyleName = "SimpleTextStyle"
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.Weight = 1.3214647037089855R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.CanGrow = False
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 7, 5, 5, 100F)
            Me.xrTableCell2.StyleName = "SimpleTextStyle"
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.TextFormatString = "{0:$0.00}"
            Me.xrTableCell2.Weight = 0.467105020016339R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.CanGrow = False
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 8, 5, 5, 100F)
            Me.xrTableCell3.StyleName = "SimpleTextStyle"
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.478822428844348R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.CanGrow = False
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField1]")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 7, 5, 5, 100F)
            Me.xrTableCell4.StyleName = "SimpleTextStyle"
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell4.TextFormatString = "{0:$0.00}"
            Me.xrTableCell4.Weight = 0.55713882978313467R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.CanGrow = False
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "NetPrice")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 5, 5, 100F)
            Me.xrTableCell5.StyleName = "SimpleTextStyle"
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell5.TextFormatString = "{0:$0.00}"
            Me.xrTableCell5.Weight = 0.5329990636687334R
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.BorderWidth = 2F
            Me.xrTable2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(80.64301F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(689.3542F, 32.29167F)
            Me.xrTable2.StyleName = "TableHeaderStyle"
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseBorderWidth = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            Me.xrTable2.StylePriority.UsePadding = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderRow
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 3, 5, 100F)
            Me.xrTableRow2.StylePriority.UsePadding = False
            Me.xrTableRow2.Weight = 11.236641221374043R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 3, 5, 100F)
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "#"
            Me.xrTableCell12.Weight = 0.34615376790364583R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 5, 3, 5, 100F)
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.Text = "Product Name"
            Me.xrTableCell6.Weight = 1.3119414381547954R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "Unit Price"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.Weight = 0.46373906965959022R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 8, 3, 5, 100F)
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "Quantity"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell8.Weight = 0.47537141956127937R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 7, 3, 5, 100F)
            Me.xrTableCell9.StylePriority.UsePadding = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Discount"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell9.Weight = 0.55312370944484268R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 5, 100F)
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Total"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell10.Weight = 0.52915769651282552R
            ' 
            ' line2
            ' 
            Me.line2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.line2.BorderWidth = 1F
            Me.line2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.line2.LineWidth = 2F
            Me.line2.LocationFloat = New DevExpress.Utils.PointFloat(80.64301F, 0F)
            Me.line2.Name = "line2"
            Me.line2.SizeF = New System.Drawing.SizeF(689.36F, 2.083334F)
            Me.line2.StyleName = "SimpleTextStyle"
            Me.line2.StylePriority.UseBorderColor = False
            Me.line2.StylePriority.UseBorderWidth = False
            Me.line2.StylePriority.UseForeColor = False
            ' 
            ' table7
            ' 
            Me.table7.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.table7.LocationFloat = New DevExpress.Utils.PointFloat(557.9952F, 2.083333F)
            Me.table7.Name = "table7"
            Me.table7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow24, Me.tableRow25, Me.tableRow26})
            Me.table7.SizeF = New System.Drawing.SizeF(212.002F, 94.14556F)
            ' 
            ' barCode2
            ' 
            Me.barCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.barCode2.AutoModule = True
            Me.barCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "OrderID")})
            Me.barCode2.LocationFloat = New DevExpress.Utils.PointFloat(554.9952F, 113.5417F)
            Me.barCode2.Name = "barCode2"
            Me.barCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 12, 12, 100F)
            Me.barCode2.ShowText = False
            Me.barCode2.SizeF = New System.Drawing.SizeF(215.002F, 61.99999F)
            Me.barCode2.StyleName = "Foreground"
            Me.barCode2.StylePriority.UsePadding = False
            Me.barCode2.Symbology = code128Generator1
            Me.barCode2.Text = "10634"
            ' 
            ' table8
            ' 
            Me.table8.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.table8.LocationFloat = New DevExpress.Utils.PointFloat(65.62503F, 29.16667F)
            Me.table8.Name = "table8"
            Me.table8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow27, Me.tableRow28, Me.tableRow29, Me.tableRow30, Me.tableRow31})
            Me.table8.SizeF = New System.Drawing.SizeF(396.92F, 125.6415F)
            Me.table8.StylePriority.UseFont = False
            ' 
            ' pictureBox3
            ' 
            Me.pictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"))
            Me.pictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(532.9813F, 180.8091F)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.SizeF = New System.Drawing.SizeF(119.4445F, 102.7778F)
            ' 
            ' table9
            ' 
            Me.table9.LocationFloat = New DevExpress.Utils.PointFloat(652.4258F, 218.1934F)
            Me.table9.Name = "table9"
            Me.table9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow32, Me.tableRow33})
            Me.table9.SizeF = New System.Drawing.SizeF(117.5714F, 43.69209F)
            ' 
            ' tableRow24
            ' 
            Me.tableRow24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell37, Me.tableCell39})
            Me.tableRow24.Name = "tableRow24"
            Me.tableRow24.StylePriority.UseBorders = False
            Me.tableRow24.StylePriority.UseBorderWidth = False
            Me.tableRow24.Weight = 0.31844500653974622R
            ' 
            ' tableRow25
            ' 
            Me.tableRow25.BorderWidth = 2F
            Me.tableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell40, Me.tableCell41})
            Me.tableRow25.Name = "tableRow25"
            Me.tableRow25.StylePriority.UseBorderWidth = False
            Me.tableRow25.Weight = 0.334263861744661R
            ' 
            ' tableRow26
            ' 
            Me.tableRow26.BorderWidth = 2F
            Me.tableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell42, Me.tableCell43})
            Me.tableRow26.Name = "tableRow26"
            Me.tableRow26.StylePriority.UseBorderWidth = False
            Me.tableRow26.Weight = 0.32430194900068893R
            ' 
            ' tableCell37
            ' 
            Me.tableCell37.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell37.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.tableCell37.Multiline = True
            Me.tableCell37.Name = "tableCell37"
            Me.tableCell37.StyleName = "Foreground"
            Me.tableCell37.StylePriority.UseBorderColor = False
            Me.tableCell37.StylePriority.UseTextAlignment = False
            Me.tableCell37.Text = "Sub Total:"
            Me.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell37.Weight = 1.5971166912340502R
            ' 
            ' tableCell39
            ' 
            Me.tableCell39.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.tableCell39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumUnitPrice]")})
            Me.tableCell39.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell39.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.tableCell39.Multiline = True
            Me.tableCell39.Name = "tableCell39"
            Me.tableCell39.StylePriority.UseBorderColor = False
            Me.tableCell39.StylePriority.UseFont = False
            Me.tableCell39.StylePriority.UseForeColor = False
            Me.tableCell39.StylePriority.UseTextAlignment = False
            Me.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell39.TextFormatString = "{0:$0.00}"
            Me.tableCell39.Weight = 1.4028833087659496R
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell40.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((88)))))), (CInt(((CByte((97)))))), (CInt(((CByte((116)))))))
            Me.tableCell40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell40.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell40.Multiline = True
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.StyleName = "ForegroundDisabled"
            Me.tableCell40.StylePriority.UseBorderColor = False
            Me.tableCell40.StylePriority.UseBorders = False
            Me.tableCell40.StylePriority.UseBorderWidth = False
            Me.tableCell40.StylePriority.UseFont = False
            Me.tableCell40.StylePriority.UseTextAlignment = False
            Me.tableCell40.Text = "Discount Total:"
            Me.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell40.Weight = 1.5971166912340502R
            ' 
            ' tableCell41
            ' 
            Me.tableCell41.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((88)))))), (CInt(((CByte((97)))))), (CInt(((CByte((116)))))))
            Me.tableCell41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountTotal]")})
            Me.tableCell41.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.tableCell41.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.tableCell41.Multiline = True
            Me.tableCell41.Name = "tableCell41"
            Me.tableCell41.StylePriority.UseBorderColor = False
            Me.tableCell41.StylePriority.UseBorders = False
            Me.tableCell41.StylePriority.UseBorderWidth = False
            Me.tableCell41.StylePriority.UseFont = False
            Me.tableCell41.StylePriority.UseForeColor = False
            Me.tableCell41.StylePriority.UseTextAlignment = False
            Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell41.TextFormatString = "{0:$0.00}"
            Me.tableCell41.Weight = 1.4028833087659496R
            ' 
            ' tableCell42
            ' 
            Me.tableCell42.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell42.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.tableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell42.Multiline = True
            Me.tableCell42.Name = "tableCell42"
            Me.tableCell42.StyleName = "Foreground"
            Me.tableCell42.StylePriority.UseBorderColor = False
            Me.tableCell42.StylePriority.UseBorders = False
            Me.tableCell42.StylePriority.UseBorderWidth = False
            Me.tableCell42.StylePriority.UseTextAlignment = False
            Me.tableCell42.Text = "Grand Total:"
            Me.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell42.Weight = 1.5971166912340502R
            ' 
            ' tableCell43
            ' 
            Me.tableCell43.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.tableCell43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AmountPaid]")})
            Me.tableCell43.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell43.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.tableCell43.Multiline = True
            Me.tableCell43.Name = "tableCell43"
            Me.tableCell43.StylePriority.UseBorderColor = False
            Me.tableCell43.StylePriority.UseBorders = False
            Me.tableCell43.StylePriority.UseBorderWidth = False
            Me.tableCell43.StylePriority.UseFont = False
            Me.tableCell43.StylePriority.UseForeColor = False
            Me.tableCell43.StylePriority.UseTextAlignment = False
            Me.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell43.TextFormatString = "{0:$0.00}"
            Me.tableCell43.Weight = 1.4028833087659496R
            ' 
            ' tableRow27
            ' 
            Me.tableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell44, Me.xrTableCell14})
            Me.tableRow27.Name = "tableRow27"
            Me.tableRow27.Weight = 0.31800607361714839R
            ' 
            ' tableRow28
            ' 
            Me.tableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell45, Me.tableCell46})
            Me.tableRow28.Name = "tableRow28"
            Me.tableRow28.Weight = 0.17049848950242141R
            ' 
            ' tableRow29
            ' 
            Me.tableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell47, Me.tableCell48})
            Me.tableRow29.Name = "tableRow29"
            Me.tableRow29.Weight = 0.17049848950242141R
            ' 
            ' tableRow30
            ' 
            Me.tableRow30.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell49, Me.tableCell50})
            Me.tableRow30.Name = "tableRow30"
            Me.tableRow30.Weight = 0.17049848950242141R
            ' 
            ' tableRow31
            ' 
            Me.tableRow31.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell51, Me.tableCell52})
            Me.tableRow31.Name = "tableRow31"
            Me.tableRow31.Weight = 0.17049848950242141R
            ' 
            ' tableCell44
            ' 
            Me.tableCell44.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell44.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell44.Multiline = True
            Me.tableCell44.Name = "tableCell44"
            Me.tableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell44.StyleName = "SimpleTextStyle"
            Me.tableCell44.StylePriority.UseFont = False
            Me.tableCell44.StylePriority.UsePadding = False
            Me.tableCell44.Text = "Payment method:"
            Me.tableCell44.Weight = 0.60336810972728738R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell14.Multiline = True
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.xrTableCell14.StyleName = "SimpleTextStyle"
            Me.xrTableCell14.StylePriority.UseFont = False
            Me.xrTableCell14.StylePriority.UsePadding = False
            Me.xrTableCell14.Weight = 1.0426589732474052R
            ' 
            ' tableCell45
            ' 
            Me.tableCell45.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell45.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell45.Multiline = True
            Me.tableCell45.Name = "tableCell45"
            Me.tableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell45.StyleName = "ForegroundDisabled"
            Me.tableCell45.StylePriority.UseFont = False
            Me.tableCell45.StylePriority.UsePadding = False
            Me.tableCell45.StylePriority.UseTextAlignment = False
            Me.tableCell45.Text = "Account №:"
            Me.tableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell45.Weight = 0.60336802027461378R
            ' 
            ' tableCell46
            ' 
            Me.tableCell46.CanGrow = False
            Me.tableCell46.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell46.Multiline = True
            Me.tableCell46.Name = "tableCell46"
            Me.tableCell46.StyleName = "SimpleTextStyle"
            Me.tableCell46.StylePriority.UseFont = False
            Me.tableCell46.Text = "123-45-6789"
            Me.tableCell46.Weight = 1.0426590627000789R
            ' 
            ' tableCell47
            ' 
            Me.tableCell47.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell47.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell47.Multiline = True
            Me.tableCell47.Name = "tableCell47"
            Me.tableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell47.StyleName = "ForegroundDisabled"
            Me.tableCell47.StylePriority.UseFont = False
            Me.tableCell47.StylePriority.UsePadding = False
            Me.tableCell47.StylePriority.UseTextAlignment = False
            Me.tableCell47.Text = "Bank:"
            Me.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell47.Weight = 0.60336802027461378R
            ' 
            ' tableCell48
            ' 
            Me.tableCell48.CanGrow = False
            Me.tableCell48.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell48.Multiline = True
            Me.tableCell48.Name = "tableCell48"
            Me.tableCell48.StyleName = "SimpleTextStyle"
            Me.tableCell48.StylePriority.UseFont = False
            Me.tableCell48.Text = "1st Enterprise Bank"
            Me.tableCell48.Weight = 1.0426590627000789R
            ' 
            ' tableCell49
            ' 
            Me.tableCell49.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell49.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell49.Multiline = True
            Me.tableCell49.Name = "tableCell49"
            Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F)
            Me.tableCell49.StyleName = "ForegroundDisabled"
            Me.tableCell49.StylePriority.UseFont = False
            Me.tableCell49.StylePriority.UsePadding = False
            Me.tableCell49.StylePriority.UseTextAlignment = False
            Me.tableCell49.Text = "Swift Code:"
            Me.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell49.Weight = 0.60336802027461378R
            ' 
            ' tableCell50
            ' 
            Me.tableCell50.CanGrow = False
            Me.tableCell50.Multiline = True
            Me.tableCell50.Name = "tableCell50"
            Me.tableCell50.StyleName = "SimpleTextStyle"
            Me.tableCell50.Text = "SWFTKUS6LXXX"
            Me.tableCell50.Weight = 1.0426590627000789R
            ' 
            ' tableCell51
            ' 
            Me.tableCell51.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell51.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell51.Multiline = True
            Me.tableCell51.Name = "tableCell51"
            Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 2, 100F)
            Me.tableCell51.StyleName = "ForegroundDisabled"
            Me.tableCell51.StylePriority.UseFont = False
            Me.tableCell51.StylePriority.UsePadding = False
            Me.tableCell51.StylePriority.UseTextAlignment = False
            Me.tableCell51.Text = "Payment Options:"
            Me.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell51.Weight = 0.60336802027461378R
            ' 
            ' tableCell52
            ' 
            Me.tableCell52.CanGrow = False
            Me.tableCell52.Multiline = True
            Me.tableCell52.Name = "tableCell52"
            Me.tableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 2, 100F)
            Me.tableCell52.StyleName = "SimpleTextStyle"
            Me.tableCell52.StylePriority.UsePadding = False
            Me.tableCell52.Text = "Visa, MasterCard, American Express"
            Me.tableCell52.Weight = 1.0426590627000789R
            ' 
            ' tableRow32
            ' 
            Me.tableRow32.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell53})
            Me.tableRow32.Name = "tableRow32"
            Me.tableRow32.Weight = 0.808849536872746R
            ' 
            ' tableRow33
            ' 
            Me.tableRow33.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell54})
            Me.tableRow33.Name = "tableRow33"
            Me.tableRow33.Weight = 0.52743325318822309R
            ' 
            ' tableCell53
            ' 
            Me.tableCell53.Multiline = True
            Me.tableCell53.Name = "tableCell53"
            Me.tableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell53.StyleName = "Foreground"
            Me.tableCell53.StylePriority.UsePadding = False
            Me.tableCell53.StylePriority.UseTextAlignment = False
            Me.tableCell53.Text = "Andrew Jacobson"
            Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            Me.tableCell53.Weight = 2R
            ' 
            ' tableCell54
            ' 
            Me.tableCell54.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell54.Multiline = True
            Me.tableCell54.Name = "tableCell54"
            Me.tableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F)
            Me.tableCell54.StyleName = "ForegroundDisabled"
            Me.tableCell54.StylePriority.UseFont = False
            Me.tableCell54.StylePriority.UsePadding = False
            Me.tableCell54.Text = "Account Manager"
            Me.tableCell54.Weight = 2R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table4.Name = "OrderDetailsExtended"
            columnExpression1.Table = table4
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table4
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            columnExpression3.Table = table4
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table4
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Quantity"
            columnExpression5.Table = table4
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Discount"
            columnExpression6.Table = table4
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ExtendedPrice"
            columnExpression7.Table = table4
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Supplier"
            columnExpression8.Table = table4
            column8.Expression = columnExpression8
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Name = "OrderDetails"
            selectQuery1.Tables.Add(table4)
            columnExpression9.ColumnName = "OrderID"
            table5.Name = "Orders"
            columnExpression9.Table = table5
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "CustomerID"
            columnExpression10.Table = table5
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EmployeeID"
            columnExpression11.Table = table5
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "OrderDate"
            columnExpression12.Table = table5
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "RequiredDate"
            columnExpression13.Table = table5
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "ShippedDate"
            columnExpression14.Table = table5
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ShipVia"
            columnExpression15.Table = table5
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Freight"
            columnExpression16.Table = table5
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ShipName"
            columnExpression17.Table = table5
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ShipAddress"
            columnExpression18.Table = table5
            column18.Expression = columnExpression18
            columnExpression19.ColumnName = "ShipCity"
            columnExpression19.Table = table5
            column19.Expression = columnExpression19
            columnExpression20.ColumnName = "ShipRegion"
            columnExpression20.Table = table5
            column20.Expression = columnExpression20
            columnExpression21.ColumnName = "ShipPostalCode"
            columnExpression21.Table = table5
            column21.Expression = columnExpression21
            columnExpression22.ColumnName = "ShipCountry"
            columnExpression22.Table = table5
            column22.Expression = columnExpression22
            column23.[Alias] = "Customers_CustomerID"
            columnExpression23.ColumnName = "CustomerID"
            table6.Name = "Customers"
            columnExpression23.Table = table6
            column23.Expression = columnExpression23
            columnExpression24.ColumnName = "CompanyName"
            columnExpression24.Table = table6
            column24.Expression = columnExpression24
            columnExpression25.ColumnName = "ContactName"
            columnExpression25.Table = table6
            column25.Expression = columnExpression25
            columnExpression26.ColumnName = "ContactTitle"
            columnExpression26.Table = table6
            column26.Expression = columnExpression26
            columnExpression27.ColumnName = "Address"
            columnExpression27.Table = table6
            column27.Expression = columnExpression27
            columnExpression28.ColumnName = "City"
            columnExpression28.Table = table6
            column28.Expression = columnExpression28
            columnExpression29.ColumnName = "Region"
            columnExpression29.Table = table6
            column29.Expression = columnExpression29
            columnExpression30.ColumnName = "PostalCode"
            columnExpression30.Table = table6
            column30.Expression = columnExpression30
            columnExpression31.ColumnName = "Country"
            columnExpression31.Table = table6
            column31.Expression = columnExpression31
            columnExpression32.ColumnName = "Phone"
            columnExpression32.Table = table6
            column32.Expression = columnExpression32
            columnExpression33.ColumnName = "Fax"
            columnExpression33.Table = table6
            column33.Expression = columnExpression33
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.Columns.Add(column18)
            selectQuery2.Columns.Add(column19)
            selectQuery2.Columns.Add(column20)
            selectQuery2.Columns.Add(column21)
            selectQuery2.Columns.Add(column22)
            selectQuery2.Columns.Add(column23)
            selectQuery2.Columns.Add(column24)
            selectQuery2.Columns.Add(column25)
            selectQuery2.Columns.Add(column26)
            selectQuery2.Columns.Add(column27)
            selectQuery2.Columns.Add(column28)
            selectQuery2.Columns.Add(column29)
            selectQuery2.Columns.Add(column30)
            selectQuery2.Columns.Add(column31)
            selectQuery2.Columns.Add(column32)
            selectQuery2.Columns.Add(column33)
            selectQuery2.Name = "Orders"
            relationColumnInfo1.NestedKeyColumn = "CustomerID"
            relationColumnInfo1.ParentKeyColumn = "CustomerID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table5
            join1.Parent = table6
            selectQuery2.Relations.Add(join1)
            selectQuery2.Tables.Add(table6)
            selectQuery2.Tables.Add(table5)
            columnExpression34.ColumnName = "CustomerID"
            table10.Name = "Customers"
            columnExpression34.Table = table10
            column34.Expression = columnExpression34
            columnExpression35.ColumnName = "CompanyName"
            columnExpression35.Table = table10
            column35.Expression = columnExpression35
            columnExpression36.ColumnName = "ContactName"
            columnExpression36.Table = table10
            column36.Expression = columnExpression36
            selectQuery3.Columns.Add(column34)
            selectQuery3.Columns.Add(column35)
            selectQuery3.Columns.Add(column36)
            selectQuery3.Name = "Customers"
            selectQuery3.Tables.Add(table10)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2, selectQuery3})
            masterDetailInfo1.DetailQueryName = "OrderDetails"
            relationColumnInfo2.NestedKeyColumn = "OrderID"
            relationColumnInfo2.ParentKeyColumn = "OrderID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2)
            masterDetailInfo1.MasterQueryName = "Orders"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((239)))))), (CInt(((CByte((241)))))), (CInt(((CByte((245)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1, Me.table2, Me.table1, Me.xrLabel17})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(850F, 207.2917F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"))
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(65.625F, 75F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(16, 0, 5, 0, 100F)
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(145.4951F, 103.9839F)
            Me.pictureBox1.StylePriority.UsePadding = False
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(211.1201F, 75F)
            Me.table2.Name = "table2"
            Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3, Me.tableRow4, Me.tableRow6, Me.tableRow7, Me.tableRow5})
            Me.table2.SizeF = New System.Drawing.SizeF(304F, 103.9839F)
            ' 
            ' table1
            ' 
            Me.table1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(557.9952F, 137.3173F)
            Me.table1.Name = "table1"
            Me.table1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1, Me.tableRow2})
            Me.table1.SizeF = New System.Drawing.SizeF(218.0077F, 41.66667F)
            Me.table1.StylePriority.UseFont = False
            Me.table1.StylePriority.UsePadding = False
            Me.table1.StylePriority.UseTextAlignment = False
            ' 
            ' xrLabel17
            ' 
            Me.xrLabel17.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Heading1
            Me.xrLabel17.CanGrow = False
            Me.xrLabel17.Font = New DevExpress.Drawing.DXFont("Arial", 37.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(515.1201F, 75F)
            Me.xrLabel17.Name = "xrLabel17"
            Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLabel17.SizeF = New System.Drawing.SizeF(260.8827F, 53.2083F)
            Me.xrLabel17.StyleName = "Foreground"
            Me.xrLabel17.StylePriority.UseFont = False
            Me.xrLabel17.StylePriority.UseForeColor = False
            Me.xrLabel17.StylePriority.UsePadding = False
            Me.xrLabel17.StylePriority.UseTextAlignment = False
            Me.xrLabel17.Text = "INVOICE"
            Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 1R
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 1R
            ' 
            ' tableRow6
            ' 
            Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
            Me.tableRow6.Name = "tableRow6"
            Me.tableRow6.Weight = 1R
            ' 
            ' tableRow7
            ' 
            Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9})
            Me.tableRow7.Name = "tableRow7"
            Me.tableRow7.Weight = 1R
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.CanGrow = False
            Me.tableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell5.Multiline = True
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "SimpleTextStyle"
            Me.tableCell5.StylePriority.UseFont = False
            Me.tableCell5.Text = "Northwind Traders"
            Me.tableCell5.Weight = 1.0198401485769693R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.CanGrow = False
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "SimpleTextStyle"
            Me.tableCell6.Text = "One Portals Way, Twin Points WA, 98156"
            Me.tableCell6.Weight = 1.0198401485769693R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.CanGrow = False
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "SimpleTextStyle"
            Me.tableCell8.Text = "1-206-555-1417"
            Me.tableCell8.Weight = 1.0198401485769693R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.CanGrow = False
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StyleName = "SimpleTextStyle"
            Me.tableCell9.Text = "northwind@mail.com"
            Me.tableCell9.Weight = 1.0198401485769693R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.CanGrow = False
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "SimpleTextStyle"
            Me.tableCell7.Text = "www.northwind.com"
            Me.tableCell7.Weight = 1.0198401485769693R
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 0.481148248077382R
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 0.48114824807738177R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell1.CanGrow = False
            Me.tableCell1.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "ForegroundDisabled"
            Me.tableCell1.StylePriority.UseFont = False
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            Me.tableCell1.Text = "Invoice №:"
            Me.tableCell1.Weight = 1.194199883360656R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.CanGrow = False
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "Foreground"
            Me.tableCell2.Weight = 1.1125145374308747R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell
            Me.tableCell3.CanGrow = False
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "ForegroundDisabled"
            Me.tableCell3.StylePriority.UseFont = False
            Me.tableCell3.StylePriority.UsePadding = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "Invoice Date:"
            Me.tableCell3.Weight = 1.194199883360656R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.CanGrow = False
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "Foreground"
            Me.tableCell4.TextFormatString = "{0:MM/dd/yy}"
            Me.tableCell4.Weight = 1.1125145374308745R
            ' 
            ' Foreground
            ' 
            Me.Foreground.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.Foreground.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((67)))))), (CInt(((CByte((82)))))))
            Me.Foreground.Name = "Foreground"
            Me.Foreground.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' ForegroundDisabled
            ' 
            Me.ForegroundDisabled.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.ForegroundDisabled.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.ForegroundDisabled.Name = "ForegroundDisabled"
            Me.ForegroundDisabled.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' SimpleTextStyle
            ' 
            Me.SimpleTextStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.SimpleTextStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.SimpleTextStyle.Name = "SimpleTextStyle"
            Me.SimpleTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' TableHeaderStyle
            ' 
            Me.TableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.TableHeaderStyle.Name = "TableHeaderStyle"
            Me.TableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' NetPrice
            ' 
            Me.NetPrice.DataMember = "Orders.OrdersOrderDetails"
            Me.NetPrice.Expression = "[UnitPrice] * [Quantity] - [Discount]"
            Me.NetPrice.Name = "NetPrice"
            ' 
            ' SumUnitPrice
            ' 
            Me.SumUnitPrice.DataMember = "Orders.OrdersOrderDetails"
            Me.SumUnitPrice.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])"
            Me.SumUnitPrice.Name = "SumUnitPrice"
            ' 
            ' DiscountTotal
            ' 
            Me.DiscountTotal.DataMember = "Orders.OrdersOrderDetails"
            Me.DiscountTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([calculatedField1])"
            Me.DiscountTotal.Name = "DiscountTotal"
            ' 
            ' AmountPaid
            ' 
            Me.AmountPaid.DataMember = "Orders.OrdersOrderDetails"
            Me.AmountPaid.Expression = "[SumUnitPrice] - [DiscountTotal]"
            Me.AmountPaid.Name = "AmountPaid"
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataMember = "Orders.OrdersOrderDetails"
            Me.calculatedField1.DisplayName = "PosDiscount"
            Me.calculatedField1.Expression = "[Quantity]* [Discount]"
            Me.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' paramCompany
            ' 
            Me.paramCompany.Description = "Company"
            Me.paramCompany.MultiValue = True
            Me.paramCompany.Name = "paramCompany"
            Me.paramCompany.ValueInfo = "ALFKI"
            dynamicListLookUpSettings1.DataMember = "Customers"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "CompanyName"
            dynamicListLookUpSettings1.ValueMember = "CustomerID"
            Me.paramCompany.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' InvoiceReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.PageHeader})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.NetPrice, Me.SumUnitPrice, Me.DiscountTotal, Me.AmountPaid, Me.calculatedField1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Orders"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Invoice"
            Me.FilterString = "[CustomerID] In (?paramCompany)"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(0F, 0F, 0F, 59.375F)
            Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.paramCompany, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompany})
            Me.RequestParameters = False
            Me.SnapGridSize = 13.02083F
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Foreground, Me.ForegroundDisabled, Me.SimpleTextStyle, Me.TableHeaderStyle})
            Me.Version = "25.1"
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private line2 As DevExpress.XtraReports.UI.XRLine

        Private table7 As DevExpress.XtraReports.UI.XRTable

        Private tableRow24 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow25 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow26 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private barCode2 As DevExpress.XtraReports.UI.XRBarCode

        Private table8 As DevExpress.XtraReports.UI.XRTable

        Private tableRow27 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell44 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow28 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell46 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow29 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow30 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell49 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow31 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell52 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private table9 As DevExpress.XtraReports.UI.XRTable

        Private tableRow32 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow33 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel

        Private Foreground As DevExpress.XtraReports.UI.XRControlStyle

        Private ForegroundDisabled As DevExpress.XtraReports.UI.XRControlStyle

        Private SimpleTextStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private NetPrice As DevExpress.XtraReports.UI.CalculatedField

        Private SumUnitPrice As DevExpress.XtraReports.UI.CalculatedField

        Private DiscountTotal As DevExpress.XtraReports.UI.CalculatedField

        Private AmountPaid As DevExpress.XtraReports.UI.CalculatedField

        Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField

        Private paramCompany As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
