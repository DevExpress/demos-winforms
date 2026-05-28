Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.DataAccess

Namespace XtraReportsDemos.CrossBandContent

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
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.CrossBandContent.Report))
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim table10 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.table5 = New DevExpress.XtraReports.UI.XRTable()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow30 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.line2 = New DevExpress.XtraReports.UI.XRLine()
            Me.table7 = New DevExpress.XtraReports.UI.XRTable()
            Me.barCode2 = New DevExpress.XtraReports.UI.XRBarCode()
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
            Me.tableRow32 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow33 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.InvoiceDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.GreyTextStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderBoldTextStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailTableCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TotalCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.InvoiceHeaderBoldStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.InvoiceHeaderDetailStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.NetPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.SubTotal = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calculatedField3 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.paramCompany = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 0F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 0F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.FillEmptySpace = True
            Me.Detail.HeightF = 31.25F
            Me.Detail.Name = "Detail"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 1100F
            Me.GroupHeader1.Level = 2
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.PrintAcrossBands = True
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.GroupHeader2.HeightF = 33.33333F
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' GroupHeader3
            ' 
            Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1, Me.xrLabel17})
            Me.GroupHeader3.HeightF = 200F
            Me.GroupHeader3.Level = 1
            Me.GroupHeader3.Name = "GroupHeader3"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.line2, Me.table7, Me.barCode2, Me.pictureBox3, Me.table9})
            Me.GroupFooter1.HeightF = 429F
            Me.GroupFooter1.Level = 2
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PrintAtBottom = True
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTable1.BorderWidth = 1F
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(309.9536F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(458.4579F, 31.25F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseBorderWidth = False
            Me.xrTable1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.StylePriority.UsePadding = False
            Me.xrTableRow1.Weight = 13.895833333333334R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.CanGrow = False
            Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([ProductName])")})
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StyleName = "DetailTableCellStyle"
            Me.xrTableCell11.StylePriority.UsePadding = False
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            xrSummary1.IgnoreNullValues = True
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrTableCell11.Summary = xrSummary1
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell11.TextFormatString = "{0:00}"
            Me.xrTableCell11.Weight = 0.30743619581260517R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.CanGrow = False
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 1, 100F)
            Me.xrTableCell1.StyleName = "DetailTableCellStyle"
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 1.159824794670725R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.CanGrow = False
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StyleName = "DetailTableCellStyle"
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.TextFormatString = "{0:$0.00}"
            Me.xrTableCell2.Weight = 0.46119086934664449R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.CanGrow = False
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StyleName = "DetailTableCellStyle"
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.56358944254168175R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.CanGrow = False
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "NetPrice")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StyleName = "DetailTableCellStyle"
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell5.TextFormatString = "{0:$0.00}"
            Me.xrTableCell5.Weight = 0.65701634470818915R
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((66)))))), (CInt(((CByte((115)))))), (CInt(((CByte((187)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5, Me.table4, Me.table3, Me.table2, Me.pictureBox1})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(247.4327F, 1099.157F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' table5
            ' 
            Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(51.07282F, 664.0108F)
            Me.table5.Name = "table5"
            Me.table5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow23, Me.tableRow13, Me.tableRow16, Me.tableRow17, Me.tableRow18, Me.tableRow19, Me.tableRow20, Me.tableRow21, Me.tableRow22})
            Me.table5.SizeF = New System.Drawing.SizeF(144.9713F, 234.1133F)
            ' 
            ' table4
            ' 
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(51.07282F, 267.5371F)
            Me.table4.Name = "table4"
            Me.table4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow7, Me.tableRow8, Me.tableRow9, Me.tableRow10, Me.tableRow11, Me.tableRow12})
            Me.table4.SizeF = New System.Drawing.SizeF(144.9713F, 155.4726F)
            ' 
            ' table3
            ' 
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(51.07282F, 464.3613F)
            Me.table3.Name = "table3"
            Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5, Me.tableRow6, Me.tableRow27, Me.tableRow28, Me.tableRow29, Me.tableRow30})
            Me.table3.SizeF = New System.Drawing.SizeF(144.9713F, 186.8392F)
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(51.07282F, 205.2573F)
            Me.table2.Name = "table2"
            Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4, Me.tableRow3})
            Me.table2.SizeF = New System.Drawing.SizeF(115.2778F, 62.27972F)
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"))
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(44.27083F, 54.6875F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(16, 0, 5, 0, 100F)
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(148.3669F, 103.9839F)
            Me.pictureBox1.StylePriority.UsePadding = False
            ' 
            ' tableRow23
            ' 
            Me.tableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell23})
            Me.tableRow23.Name = "tableRow23"
            Me.tableRow23.Weight = 1.8689700161975629R
            ' 
            ' tableRow13
            ' 
            Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15})
            Me.tableRow13.Name = "tableRow13"
            Me.tableRow13.Weight = 0.89875136663655553R
            ' 
            ' tableRow16
            ' 
            Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16})
            Me.tableRow16.Name = "tableRow16"
            Me.tableRow16.Weight = 0.72504107601208811R
            ' 
            ' tableRow17
            ' 
            Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17})
            Me.tableRow17.Name = "tableRow17"
            Me.tableRow17.Weight = 1.2749583375551774R
            ' 
            ' tableRow18
            ' 
            Me.tableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell18})
            Me.tableRow18.Name = "tableRow18"
            Me.tableRow18.Weight = 0.7969649414013R
            ' 
            ' tableRow19
            ' 
            Me.tableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell19})
            Me.tableRow19.Name = "tableRow19"
            Me.tableRow19.Weight = 1.2685576984647813R
            ' 
            ' tableRow20
            ' 
            Me.tableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell20})
            Me.tableRow20.Name = "tableRow20"
            Me.tableRow20.Weight = 1.0751197621124016R
            ' 
            ' tableRow21
            ' 
            Me.tableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21})
            Me.tableRow21.Name = "tableRow21"
            Me.tableRow21.Weight = 0.99135397592214081R
            ' 
            ' tableRow22
            ' 
            Me.tableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell22})
            Me.tableRow22.Name = "tableRow22"
            Me.tableRow22.Weight = 1.4467637043944475R
            ' 
            ' tableCell23
            ' 
            Me.tableCell23.Multiline = True
            Me.tableCell23.Name = "tableCell23"
            Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell23.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell23.StylePriority.UsePadding = False
            Me.tableCell23.Text = "PAYMENT METHOD:"
            Me.tableCell23.Weight = 3R
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.Multiline = True
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell15.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell15.StylePriority.UsePadding = False
            Me.tableCell15.Text = "Account №:"
            Me.tableCell15.Weight = 3R
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.Multiline = True
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell16.StylePriority.UseTextAlignment = False
            Me.tableCell16.Text = "123-45-6789"
            Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell16.Weight = 3R
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.Multiline = True
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell17.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell17.StylePriority.UsePadding = False
            Me.tableCell17.StylePriority.UseTextAlignment = False
            Me.tableCell17.Text = "Bank:"
            Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell17.Weight = 3R
            ' 
            ' tableCell18
            ' 
            Me.tableCell18.Multiline = True
            Me.tableCell18.Name = "tableCell18"
            Me.tableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 1, 0, 100F)
            Me.tableCell18.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell18.StylePriority.UsePadding = False
            Me.tableCell18.StylePriority.UseTextAlignment = False
            Me.tableCell18.Text = "1st Enterprise Bank"
            Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell18.Weight = 3R
            ' 
            ' tableCell19
            ' 
            Me.tableCell19.Multiline = True
            Me.tableCell19.Name = "tableCell19"
            Me.tableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell19.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell19.StylePriority.UsePadding = False
            Me.tableCell19.StylePriority.UseTextAlignment = False
            Me.tableCell19.Text = "Swift Code:"
            Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell19.Weight = 3R
            ' 
            ' tableCell20
            ' 
            Me.tableCell20.Multiline = True
            Me.tableCell20.Name = "tableCell20"
            Me.tableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell20.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell20.StylePriority.UsePadding = False
            Me.tableCell20.StylePriority.UseTextAlignment = False
            Me.tableCell20.Text = "SWFTKUS6LXXX"
            Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell20.Weight = 3R
            ' 
            ' tableCell21
            ' 
            Me.tableCell21.Multiline = True
            Me.tableCell21.Name = "tableCell21"
            Me.tableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell21.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell21.StylePriority.UsePadding = False
            Me.tableCell21.StylePriority.UseTextAlignment = False
            Me.tableCell21.Text = "Card Payment:"
            Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell21.Weight = 3R
            ' 
            ' tableCell22
            ' 
            Me.tableCell22.Multiline = True
            Me.tableCell22.Name = "tableCell22"
            Me.tableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell22.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell22.StylePriority.UsePadding = False
            Me.tableCell22.StylePriority.UseTextAlignment = False
            Me.tableCell22.Text = "Visa, MasterCard, American Express"
            Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell22.Weight = 3R
            ' 
            ' tableRow7
            ' 
            Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9})
            Me.tableRow7.Name = "tableRow7"
            Me.tableRow7.Weight = 0.89875136663655553R
            ' 
            ' tableRow8
            ' 
            Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10})
            Me.tableRow8.Name = "tableRow8"
            Me.tableRow8.Weight = 1.8536609350924906R
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell11})
            Me.tableRow9.Name = "tableRow9"
            Me.tableRow9.Weight = 0.89875277153706556R
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12})
            Me.tableRow10.Name = "tableRow10"
            Me.tableRow10.Weight = 0.752798909588049R
            ' 
            ' tableRow11
            ' 
            Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13})
            Me.tableRow11.Name = "tableRow11"
            Me.tableRow11.Weight = 1.1969302526990893R
            ' 
            ' tableRow12
            ' 
            Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell14})
            Me.tableRow12.Name = "tableRow12"
            Me.tableRow12.Weight = 1.2701143281899576R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell9.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.Text = "Address:"
            Me.tableCell9.Weight = 3R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell10.StylePriority.UseTextAlignment = False
            Me.tableCell10.Text = "One Portals Way, Twin Points WA, 98156"
            Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell10.Weight = 3R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.Multiline = True
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell11.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell11.StylePriority.UsePadding = False
            Me.tableCell11.Text = "Phone:"
            Me.tableCell11.Weight = 3R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.CanGrow = False
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell12.StylePriority.UseTextAlignment = False
            Me.tableCell12.Text = "1-206-555-1417"
            Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell12.Weight = 3R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.CanGrow = False
            Me.tableCell13.Multiline = True
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell13.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell13.StylePriority.UsePadding = False
            Me.tableCell13.StylePriority.UseTextAlignment = False
            Me.tableCell13.Text = "Web:"
            Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell13.Weight = 3R
            ' 
            ' tableCell14
            ' 
            Me.tableCell14.Multiline = True
            Me.tableCell14.Name = "tableCell14"
            Me.tableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell14.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell14.StylePriority.UsePadding = False
            Me.tableCell14.StylePriority.UseTextAlignment = False
            Me.tableCell14.Text = "www.northwind.com"
            Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell14.Weight = 3R
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1R
            ' 
            ' tableRow6
            ' 
            Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7})
            Me.tableRow6.Name = "tableRow6"
            Me.tableRow6.Weight = 1.7524123017290458R
            ' 
            ' tableRow27
            ' 
            Me.tableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell24})
            Me.tableRow27.Name = "tableRow27"
            Me.tableRow27.Weight = 0.782195135743229R
            ' 
            ' tableRow28
            ' 
            Me.tableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell25})
            Me.tableRow28.Name = "tableRow28"
            Me.tableRow28.Weight = 1.9702171659858165R
            ' 
            ' tableRow29
            ' 
            Me.tableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell26})
            Me.tableRow29.Name = "tableRow29"
            Me.tableRow29.Weight = 0.82179092401249076R
            ' 
            ' tableRow30
            ' 
            Me.tableRow30.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell27})
            Me.tableRow30.Name = "tableRow30"
            Me.tableRow30.Weight = 1.9306213777165553R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell6.Text = "TO:"
            Me.tableCell6.Weight = 3R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell7.StylePriority.UseForeColor = False
            Me.tableCell7.Weight = 3R
            ' 
            ' tableCell24
            ' 
            Me.tableCell24.Multiline = True
            Me.tableCell24.Name = "tableCell24"
            Me.tableCell24.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell24.StylePriority.UseTextAlignment = False
            Me.tableCell24.Text = "Address:"
            Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell24.Weight = 3R
            ' 
            ' tableCell25
            ' 
            Me.tableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0}, {1}, {2}', [Address], [City], [Country])")})
            Me.tableCell25.Multiline = True
            Me.tableCell25.Name = "tableCell25"
            Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.tableCell25.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell25.StylePriority.UseForeColor = False
            Me.tableCell25.StylePriority.UsePadding = False
            Me.tableCell25.StylePriority.UseTextAlignment = False
            Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell25.Weight = 3R
            ' 
            ' tableCell26
            ' 
            Me.tableCell26.Multiline = True
            Me.tableCell26.Name = "tableCell26"
            Me.tableCell26.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell26.StylePriority.UseTextAlignment = False
            Me.tableCell26.Text = "Phone:"
            Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell26.Weight = 3R
            ' 
            ' tableCell27
            ' 
            Me.tableCell27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            Me.tableCell27.Multiline = True
            Me.tableCell27.Name = "tableCell27"
            Me.tableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.tableCell27.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell27.StylePriority.UseForeColor = False
            Me.tableCell27.StylePriority.UsePadding = False
            Me.tableCell27.StylePriority.UseTextAlignment = False
            Me.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell27.Weight = 3R
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 1R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 1.7524123017290458R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "InvoiceHeaderBoldStyle"
            Me.tableCell8.Text = "FROM:"
            Me.tableCell8.Weight = 3R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Multiline = True
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "InvoiceHeaderDetailStyle"
            Me.tableCell5.Text = "Northwind Traders"
            Me.tableCell5.Weight = 3R
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(309.9538F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(458.4583F, 33.33333F)
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
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.StylePriority.UsePadding = False
            Me.xrTableRow2.Weight = 11.236641221374043R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "Pos."
            Me.xrTableCell12.Weight = 0.30522042045810632R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.Text = "Product Name"
            Me.xrTableCell6.Weight = 1.1514660692383285R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "Unit Price"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.Weight = 0.45786681207803032R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "Quantity"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell8.Weight = 0.5595259129897151R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Total"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell10.Weight = 0.652284177027956R
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(644.8574F, 75.69452F)
            Me.table1.Name = "table1"
            Me.table1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1, Me.tableRow2, Me.tableRow14, Me.tableRow15})
            Me.table1.SizeF = New System.Drawing.SizeF(123.5574F, 89.82597F)
            Me.table1.StylePriority.UsePadding = False
            ' 
            ' xrLabel17
            ' 
            Me.xrLabel17.CanGrow = False
            Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(306.25F, 73.95834F)
            Me.xrLabel17.Name = "xrLabel17"
            Me.xrLabel17.SizeF = New System.Drawing.SizeF(211.6745F, 53.20831F)
            Me.xrLabel17.StyleName = "TitleStyle"
            Me.xrLabel17.StylePriority.UseBackColor = False
            Me.xrLabel17.StylePriority.UseFont = False
            Me.xrLabel17.StylePriority.UseForeColor = False
            Me.xrLabel17.StylePriority.UsePadding = False
            Me.xrLabel17.StylePriority.UseTextAlignment = False
            Me.xrLabel17.Text = "INVOICE"
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 0.91397862588205647R
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell2})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 1.3612903225806452R
            ' 
            ' tableRow14
            ' 
            Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3})
            Me.tableRow14.Name = "tableRow14"
            Me.tableRow14.Weight = 0.81391444052419359R
            ' 
            ' tableRow15
            ' 
            Me.tableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4})
            Me.tableRow15.Name = "tableRow15"
            Me.tableRow15.Weight = 1.3615483437815019R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "GreyTextStyle"
            Me.tableCell1.StylePriority.UseFont = False
            Me.tableCell1.Text = "Order №:"
            Me.tableCell1.Weight = 1R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.tableCell2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "HeaderBoldTextStyle"
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UseForeColor = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell2.Weight = 1R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "GreyTextStyle"
            Me.tableCell3.StylePriority.UseFont = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "Order Date:"
            Me.tableCell3.Weight = 1R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
            Me.tableCell4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "HeaderBoldTextStyle"
            Me.tableCell4.StylePriority.UseFont = False
            Me.tableCell4.StylePriority.UseForeColor = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell4.TextFormatString = "{0:MMMM d, yyyy}"
            Me.tableCell4.Weight = 1R
            ' 
            ' line2
            ' 
            Me.line2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.line2.BorderWidth = 1F
            Me.line2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.line2.LineWidth = 2F
            Me.line2.LocationFloat = New DevExpress.Utils.PointFloat(309.9538F, 0F)
            Me.line2.Name = "line2"
            Me.line2.SizeF = New System.Drawing.SizeF(460.0484F, 2.083333F)
            Me.line2.StylePriority.UseBorderColor = False
            Me.line2.StylePriority.UseBorderWidth = False
            Me.line2.StylePriority.UseForeColor = False
            ' 
            ' table7
            ' 
            Me.table7.LocationFloat = New DevExpress.Utils.PointFloat(555.926F, 2.083333F)
            Me.table7.Name = "table7"
            Me.table7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow24, Me.tableRow25, Me.tableRow26})
            Me.table7.SizeF = New System.Drawing.SizeF(214.0729F, 94.14556F)
            ' 
            ' barCode2
            ' 
            Me.barCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.barCode2.AutoModule = True
            Me.barCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "OrderID")})
            Me.barCode2.LocationFloat = New DevExpress.Utils.PointFloat(555F, 113.5417F)
            Me.barCode2.Name = "barCode2"
            Me.barCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 12, 12, 100F)
            Me.barCode2.ShowText = False
            Me.barCode2.SizeF = New System.Drawing.SizeF(215F, 62F)
            Me.barCode2.StyleName = "TitleStyle"
            Me.barCode2.StylePriority.UsePadding = False
            Me.barCode2.Symbology = code128Generator1
            Me.barCode2.Text = "10634"
            ' 
            ' pictureBox3
            ' 
            Me.pictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"))
            Me.pictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(553F, 206F)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.SizeF = New System.Drawing.SizeF(120F, 95F)
            ' 
            ' table9
            ' 
            Me.table9.LocationFloat = New DevExpress.Utils.PointFloat(650F, 301F)
            Me.table9.Name = "table9"
            Me.table9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow32, Me.tableRow33})
            Me.table9.SizeF = New System.Drawing.SizeF(118F, 44F)
            ' 
            ' tableRow24
            ' 
            Me.tableRow24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableRow24.BorderWidth = 2.5F
            Me.tableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell37, Me.tableCell39})
            Me.tableRow24.Name = "tableRow24"
            Me.tableRow24.StylePriority.UseBorders = False
            Me.tableRow24.StylePriority.UseBorderWidth = False
            Me.tableRow24.Weight = 0.31844500653974622R
            ' 
            ' tableRow25
            ' 
            Me.tableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell40, Me.tableCell41})
            Me.tableRow25.Name = "tableRow25"
            Me.tableRow25.Weight = 0.334263861744661R
            ' 
            ' tableRow26
            ' 
            Me.tableRow26.BorderWidth = 2.5F
            Me.tableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell42, Me.tableCell43})
            Me.tableRow26.Name = "tableRow26"
            Me.tableRow26.StylePriority.UseBorderWidth = False
            Me.tableRow26.Weight = 0.32430194900068893R
            ' 
            ' tableCell37
            ' 
            Me.tableCell37.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.tableCell37.BorderWidth = 1F
            Me.tableCell37.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell37.Multiline = True
            Me.tableCell37.Name = "tableCell37"
            Me.tableCell37.StyleName = "TotalCellStyle"
            Me.tableCell37.StylePriority.UseBorderColor = False
            Me.tableCell37.StylePriority.UseBorderWidth = False
            Me.tableCell37.StylePriority.UseForeColor = False
            Me.tableCell37.StylePriority.UseTextAlignment = False
            Me.tableCell37.Text = "Sub Total:"
            Me.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell37.Weight = 1.5R
            ' 
            ' tableCell39
            ' 
            Me.tableCell39.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.tableCell39.BorderWidth = 1F
            Me.tableCell39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotal]")})
            Me.tableCell39.Multiline = True
            Me.tableCell39.Name = "tableCell39"
            Me.tableCell39.StyleName = "TotalCellStyle"
            Me.tableCell39.StylePriority.UseBorderColor = False
            Me.tableCell39.StylePriority.UseBorderWidth = False
            Me.tableCell39.StylePriority.UseTextAlignment = False
            Me.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell39.TextFormatString = "{0:$0.00}"
            Me.tableCell39.Weight = 1.5R
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell40.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.tableCell40.Multiline = True
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.StyleName = "TotalCellStyle"
            Me.tableCell40.StylePriority.UseBorderColor = False
            Me.tableCell40.StylePriority.UseBorders = False
            Me.tableCell40.StylePriority.UseBorderWidth = False
            Me.tableCell40.StylePriority.UseFont = False
            Me.tableCell40.StylePriority.UseForeColor = False
            Me.tableCell40.StylePriority.UseTextAlignment = False
            Me.tableCell40.Text = "Discount Total:"
            Me.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell40.Weight = 1.5R
            ' 
            ' tableCell41
            ' 
            Me.tableCell41.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField1]")})
            Me.tableCell41.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.tableCell41.Multiline = True
            Me.tableCell41.Name = "tableCell41"
            Me.tableCell41.StyleName = "TotalCellStyle"
            Me.tableCell41.StylePriority.UseBorderColor = False
            Me.tableCell41.StylePriority.UseBorders = False
            Me.tableCell41.StylePriority.UseBorderWidth = False
            Me.tableCell41.StylePriority.UseFont = False
            Me.tableCell41.StylePriority.UseForeColor = False
            Me.tableCell41.StylePriority.UseTextAlignment = False
            Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell41.TextFormatString = "{0:$0.00}"
            Me.tableCell41.Weight = 1.5R
            ' 
            ' tableCell42
            ' 
            Me.tableCell42.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell42.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell42.Multiline = True
            Me.tableCell42.Name = "tableCell42"
            Me.tableCell42.StyleName = "TotalCellStyle"
            Me.tableCell42.StylePriority.UseBorderColor = False
            Me.tableCell42.StylePriority.UseBorders = False
            Me.tableCell42.StylePriority.UseBorderWidth = False
            Me.tableCell42.StylePriority.UseForeColor = False
            Me.tableCell42.StylePriority.UseTextAlignment = False
            Me.tableCell42.Text = "Grand Total:"
            Me.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell42.Weight = 1.5R
            ' 
            ' tableCell43
            ' 
            Me.tableCell43.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField2]")})
            Me.tableCell43.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.tableCell43.Multiline = True
            Me.tableCell43.Name = "tableCell43"
            Me.tableCell43.StyleName = "TotalCellStyle"
            Me.tableCell43.StylePriority.UseBorderColor = False
            Me.tableCell43.StylePriority.UseBorders = False
            Me.tableCell43.StylePriority.UseBorderWidth = False
            Me.tableCell43.StylePriority.UseFont = False
            Me.tableCell43.StylePriority.UseForeColor = False
            Me.tableCell43.StylePriority.UseTextAlignment = False
            Me.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell43.TextFormatString = "{0:$0.00}"
            Me.tableCell43.Weight = 1.5R
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
            Me.tableCell53.StyleName = "HeaderBoldTextStyle"
            Me.tableCell53.StylePriority.UsePadding = False
            Me.tableCell53.StylePriority.UseTextAlignment = False
            Me.tableCell53.Text = "Andrew Jacobson"
            Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            Me.tableCell53.Weight = 2R
            ' 
            ' tableCell54
            ' 
            Me.tableCell54.Font = New DevExpress.Drawing.DXFont("Arial", 7.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell54.Multiline = True
            Me.tableCell54.Name = "tableCell54"
            Me.tableCell54.StyleName = "GreyTextStyle"
            Me.tableCell54.StylePriority.UseFont = False
            Me.tableCell54.StylePriority.UsePadding = False
            Me.tableCell54.Text = "Account Manager"
            Me.tableCell54.Weight = 2R
            ' 
            ' InvoiceDataSource
            ' 
            Me.InvoiceDataSource.ConnectionName = "NWindConnectionString"
            Me.InvoiceDataSource.Name = "InvoiceDataSource"
            columnExpression1.ColumnName = "OrderID"
            table6.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""474"" />"
            table6.Name = "Orders"
            columnExpression1.Table = table6
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "OrderDate"
            columnExpression2.Table = table6
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            table8.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""312"" />"
            table8.Name = "OrderDetailsExtended"
            columnExpression3.Table = table8
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table8
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Discount"
            columnExpression5.Table = table8
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Quantity"
            columnExpression6.Table = table8
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ExtendedPrice"
            columnExpression7.Table = table8
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "CompanyName"
            table10.MetaSerializable = "<Meta X=""270"" Y=""370"" Width=""240"" Height=""393"" />"
            table10.Name = "Customers"
            columnExpression8.Table = table10
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ContactName"
            columnExpression9.Table = table10
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Address"
            columnExpression10.Table = table10
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "City"
            columnExpression11.Table = table10
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "Region"
            columnExpression12.Table = table10
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Phone"
            columnExpression13.Table = table10
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Country"
            columnExpression14.Table = table10
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "CustomerID"
            columnExpression15.Table = table6
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
            selectQuery1.Name = "Order_Details_Invoice"
            relationColumnInfo1.NestedKeyColumn = "OrderID"
            relationColumnInfo1.ParentKeyColumn = "OrderID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table8
            join1.Parent = table6
            relationColumnInfo2.NestedKeyColumn = "CustomerID"
            relationColumnInfo2.ParentKeyColumn = "CustomerID"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table10
            join2.Parent = table6
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Tables.Add(table6)
            selectQuery1.Tables.Add(table8)
            selectQuery1.Tables.Add(table10)
            Me.InvoiceDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            masterDetailInfo1.DetailQueryName = "OrderDetails"
            relationColumnInfo3.NestedKeyColumn = "OrderID"
            relationColumnInfo3.ParentKeyColumn = "OrderID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Orders"
            Me.InvoiceDataSource.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.InvoiceDataSource.ResultSchemaSerializable = resources.GetString("InvoiceDataSource.ResultSchemaSerializable")
            ' 
            ' GreyTextStyle
            ' 
            Me.GreyTextStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GreyTextStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.GreyTextStyle.Name = "GreyTextStyle"
            Me.GreyTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' HeaderBoldTextStyle
            ' 
            Me.HeaderBoldTextStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderBoldTextStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.HeaderBoldTextStyle.Name = "HeaderBoldTextStyle"
            Me.HeaderBoldTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' TableHeaderStyle
            ' 
            Me.TableHeaderStyle.BorderWidth = 2F
            Me.TableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.TableHeaderStyle.Name = "TableHeaderStyle"
            Me.TableHeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailTableCellStyle
            ' 
            Me.DetailTableCellStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F)
            Me.DetailTableCellStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.DetailTableCellStyle.Name = "DetailTableCellStyle"
            Me.DetailTableCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 1, 100F)
            Me.DetailTableCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' TotalCellStyle
            ' 
            Me.TotalCellStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.TotalCellStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.TotalCellStyle.BorderWidth = 2F
            Me.TotalCellStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TotalCellStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.TotalCellStyle.Name = "TotalCellStyle"
            Me.TotalCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            ' 
            ' InvoiceHeaderBoldStyle
            ' 
            Me.InvoiceHeaderBoldStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.InvoiceHeaderBoldStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((125)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.InvoiceHeaderBoldStyle.Name = "InvoiceHeaderBoldStyle"
            Me.InvoiceHeaderBoldStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.InvoiceHeaderBoldStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' InvoiceHeaderDetailStyle
            ' 
            Me.InvoiceHeaderDetailStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.5F)
            Me.InvoiceHeaderDetailStyle.ForeColor = System.Drawing.Color.White
            Me.InvoiceHeaderDetailStyle.Name = "InvoiceHeaderDetailStyle"
            Me.InvoiceHeaderDetailStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.InvoiceHeaderDetailStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' TitleStyle
            ' 
            Me.TitleStyle.Font = New DevExpress.Drawing.DXFont("Arial", 36F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((61)))))), (CInt(((CByte((64)))))), (CInt(((CByte((70)))))))
            Me.TitleStyle.Name = "TitleStyle"
            ' 
            ' NetPrice
            ' 
            Me.NetPrice.DataMember = "Order_Details_Invoice"
            Me.NetPrice.Expression = "[UnitPrice] * [Quantity]"
            Me.NetPrice.Name = "NetPrice"
            ' 
            ' SubTotal
            ' 
            Me.SubTotal.DataMember = "Order_Details_Invoice"
            Me.SubTotal.DisplayName = "SubTotal"
            Me.SubTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])"
            Me.SubTotal.Name = "SubTotal"
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataMember = "Order_Details_Invoice"
            Me.calculatedField1.DisplayName = "DiscountTotal"
            Me.calculatedField1.Expression = "[][[ContactName] == [^.ContactName] AND [OrderID] == [^.OrderID]].Sum([calculated" & "Field3])"
            Me.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' calculatedField2
            ' 
            Me.calculatedField2.DataMember = "Order_Details_Invoice"
            Me.calculatedField2.DisplayName = "GrandTotal"
            Me.calculatedField2.Expression = "[SubTotal] - [calculatedField1]"
            Me.calculatedField2.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.calculatedField2.Name = "calculatedField2"
            ' 
            ' calculatedField3
            ' 
            Me.calculatedField3.DataMember = "Order_Details_Invoice"
            Me.calculatedField3.DisplayName = "PosDiscount"
            Me.calculatedField3.Expression = "[Quantity]* [Discount]"
            Me.calculatedField3.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.calculatedField3.Name = "calculatedField3"
            ' 
            ' paramCompany
            ' 
            Me.paramCompany.Description = "Company"
            Me.paramCompany.MultiValue = True
            Me.paramCompany.Name = "paramCompany"
            Me.paramCompany.ValueInfo = "ALFKI"
            dynamicListLookUpSettings1.DataMember = "Order_Details_Invoice"
            dynamicListLookUpSettings1.DataSource = Me.InvoiceDataSource
            dynamicListLookUpSettings1.DisplayMember = "CompanyName"
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            dynamicListLookUpSettings1.ValueMember = "CustomerID"
            Me.paramCompany.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.GroupFooter1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.NetPrice, Me.SubTotal, Me.calculatedField1, Me.calculatedField2, Me.calculatedField3})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.InvoiceDataSource})
            Me.DataMember = "Order_Details_Invoice"
            Me.DataSource = Me.InvoiceDataSource
            Me.DisplayName = "Cross-Band Content"
            Me.FilterString = "[CustomerID] In (?paramCompany)"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompany})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.GreyTextStyle, Me.HeaderBoldTextStyle, Me.TableHeaderStyle, Me.DetailTableCellStyle, Me.TotalCellStyle, Me.InvoiceHeaderBoldStyle, Me.InvoiceHeaderDetailStyle, Me.TitleStyle})
            Me.Version = "25.1"
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private table5 As DevExpress.XtraReports.UI.XRTable

        Private tableRow23 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow20 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow21 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow22 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private tableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow27 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow28 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow29 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow30 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel

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

        Private pictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private table9 As DevExpress.XtraReports.UI.XRTable

        Private tableRow32 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow33 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private InvoiceDataSource As DevExpress.DataAccess.Sql.SqlDataSource

        Private GreyTextStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderBoldTextStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailTableCellStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TotalCellStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private InvoiceHeaderBoldStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private InvoiceHeaderDetailStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TitleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private NetPrice As DevExpress.XtraReports.UI.CalculatedField

        Private SubTotal As DevExpress.XtraReports.UI.CalculatedField

        Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField

        Private calculatedField2 As DevExpress.XtraReports.UI.CalculatedField

        Private calculatedField3 As DevExpress.XtraReports.UI.CalculatedField

        Private paramCompany As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
