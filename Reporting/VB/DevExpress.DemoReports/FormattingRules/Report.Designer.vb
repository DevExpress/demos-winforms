Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.FormattingRules

    Public Partial Class Report

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
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.FormattingRules.Report))
            Dim staticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Dim staticListLookUpSettings2 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.tahomaBoldStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.darkRedStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.lightRedStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.darkGreenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.darkBlueStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.lightGreenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.lightBlueStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ConditionParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.StyleParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 23F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportHeader.HeightF = 50F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 23F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((230)))))), (CInt(((CByte((225)))))), (CInt(((CByte((225)))))))
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTable1.FormattingRules.Add(Me.formattingRule1)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.OddStyleName = "oddStyle"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(649F, 23F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UsePadding = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell13, Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18, Me.xrTableCell20, Me.xrTableCell21, Me.xrTableCell22})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.StylePriority.UseTextAlignment = False
            Me.xrTableCell13.Text = "xrTableCell13"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.1032357473035439R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "{0:d}")})
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell16.StylePriority.UseTextAlignment = False
            Me.xrTableCell16.Text = "xrTableCell16"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell16.Weight = 0.14329738058551614R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ProductName")})
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell17.StylePriority.UseTextAlignment = False
            Me.xrTableCell17.Text = "xrTableCell17"
            Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell17.Weight = 0.30508474576271188R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Quantity")})
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell18.StylePriority.UseTextAlignment = False
            Me.xrTableCell18.Text = "xrTableCell18"
            Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell18.Weight = 0.089368258859784278R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.UnitPrice", "{0:c2}")})
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell20.StylePriority.UseTextAlignment = False
            Me.xrTableCell20.Text = "xrTableCell20"
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell20.Weight = 0.12942989214175654R
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Discount", "{0:0%}")})
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell21.StylePriority.UseTextAlignment = False
            Me.xrTableCell21.Text = "xrTableCell21"
            Me.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell21.Weight = 0.10939907550077042R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Extended Price", "{0:c2}")})
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell22.StylePriority.UseTextAlignment = False
            Me.xrTableCell22.Text = "xrTableCell22"
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell22.Weight = 0.12018489984591681R
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 27.75F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 50F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Orders Report"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((234)))))), (CInt(((CByte((233)))))))
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((230)))))), (CInt(((CByte((225)))))), (CInt(((CByte((225)))))))
            Me.xrTable2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(649F, 23F)
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell14, Me.xrTableCell5, Me.xrTableCell15})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F)
            Me.xrTableCell9.StylePriority.UseFont = False
            Me.xrTableCell9.StylePriority.UsePadding = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Order ID"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell9.Weight = 0.1032357473035439R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F)
            Me.xrTableCell10.StylePriority.UseFont = False
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Order Date"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.14329738058551614R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 1, 0, 100F)
            Me.xrTableCell11.StylePriority.UseFont = False
            Me.xrTableCell11.StylePriority.UsePadding = False
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "Product Name"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell11.Weight = 0.30508474576271188R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
            Me.xrTableCell12.StylePriority.UseFont = False
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "Quantity"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell12.Weight = 0.089368258859784278R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
            Me.xrTableCell14.StylePriority.UseFont = False
            Me.xrTableCell14.StylePriority.UsePadding = False
            Me.xrTableCell14.StylePriority.UseTextAlignment = False
            Me.xrTableCell14.Text = "Unit Price"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell14.Weight = 0.12942989214175654R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
            Me.xrTableCell5.StylePriority.UseFont = False
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "Discount"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell5.Weight = 0.10939907550077042R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
            Me.xrTableCell15.StylePriority.UseFont = False
            Me.xrTableCell15.StylePriority.UsePadding = False
            Me.xrTableCell15.StylePriority.UseTextAlignment = False
            Me.xrTableCell15.Text = "Ext. Price"
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell15.Weight = 0.12018489984591681R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderDetails"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            table2.Name = "Products"
            columnExpression3.Table = table2
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Quantity"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "OrderDate"
            table3.Name = "Orders"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            column7.[Alias] = "Extended Price"
            customExpression1.Expression = "ToDecimal(([OrderDetails].[UnitPrice] * [OrderDetails].[Quantity]) * (1 - [OrderD" & "etails].[Discount]))"
            column7.Expression = customExpression1
            columnExpression7.ColumnName = "Discount"
            columnExpression7.Table = table1
            column8.Expression = columnExpression7
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.FilterString = "[Orders.OrderDate] Between(#2022-01-01#, #2022-12-01#)"
            selectQuery1.Name = "Orders"
            relationColumnInfo1.NestedKeyColumn = "ProductID"
            relationColumnInfo1.ParentKeyColumn = "ProductID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table1
            join1.Parent = table2
            relationColumnInfo2.NestedKeyColumn = "OrderID"
            relationColumnInfo2.ParentKeyColumn = "OrderID"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table3
            join2.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Tables.Add(table2)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table3)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' formattingRule1
            ' 
            Me.formattingRule1.Condition = "[Extended Price] > 1000"
            Me.formattingRule1.DataMember = "Orders"
            Me.formattingRule1.Formatting.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.formattingRule1.Name = "formattingRule1"
            ' 
            ' oddStyle
            ' 
            Me.oddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((239)))))), (CInt(((CByte((233)))))))
            Me.oddStyle.Name = "oddStyle"
            ' 
            ' tahomaBoldStyle
            ' 
            Me.tahomaBoldStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tahomaBoldStyle.Name = "tahomaBoldStyle"
            ' 
            ' darkRedStyle
            ' 
            Me.darkRedStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((177)))))), (CInt(((CByte((38)))))), (CInt(((CByte((64)))))))
            Me.darkRedStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((222)))))), (CInt(((CByte((226)))))))
            Me.darkRedStyle.Name = "darkRedStyle"
            ' 
            ' lightRedStyle
            ' 
            Me.lightRedStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((180)))))), (CInt(((CByte((188)))))))
            Me.lightRedStyle.Name = "lightRedStyle"
            ' 
            ' darkGreenStyle
            ' 
            Me.darkGreenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((130)))))), (CInt(((CByte((90)))))))
            Me.darkGreenStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((222)))))), (CInt(((CByte((226)))))))
            Me.darkGreenStyle.Name = "darkGreenStyle"
            ' 
            ' darkBlueStyle
            ' 
            Me.darkBlueStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((56)))))), (CInt(((CByte((112)))))), (CInt(((CByte((159)))))))
            Me.darkBlueStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((222)))))), (CInt(((CByte((226)))))))
            Me.darkBlueStyle.Name = "darkBlueStyle"
            ' 
            ' lightGreenStyle
            ' 
            Me.lightGreenStyle.BackColor = System.Drawing.Color.LightGreen
            Me.lightGreenStyle.Name = "lightGreenStyle"
            ' 
            ' lightBlueStyle
            ' 
            Me.lightBlueStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((197)))))), (CInt(((CByte((221)))))))
            Me.lightBlueStyle.Name = "lightBlueStyle"
            ' 
            ' ConditionParameter
            ' 
            Me.ConditionParameter.Description = "Condition:"
            Me.ConditionParameter.Name = "ConditionParameter"
            Me.ConditionParameter.ValueInfo = "[Extended Price] > 1000"
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Quantity] > 30", "Quantity > 30"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Quantity] > 60", "Quantity > 60"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[UnitPrice] > 40", "Unit price > $40"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[UnitPrice] > 60", "Unit price > $60"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Discount] > 0.05", "Discount > 5%"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Discount] > 0.15", "Discount > 15%"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Extended Price] > 1000", "Extended price > $1000"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("[Extended Price] > 1500", "Extended price > $1500"))
            Me.ConditionParameter.ValueSourceSettings = staticListLookUpSettings1
            ' 
            ' StyleParameter
            ' 
            Me.StyleParameter.Description = "Style:"
            Me.StyleParameter.Name = "StyleParameter"
            Me.StyleParameter.ValueInfo = "tahomaBoldStyle"
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("tahomaBoldStyle", "Tahoma Bold"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("darkRedStyle", "Dark Red"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("lightRedStyle", "Light Red"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("darkBlueStyle", "Dark Blue"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("lightBlueStyle", "Light Blue"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("darkGreenStyle", "Dark Green"))
            staticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("lightGreenStyle", "Light Green"))
            Me.StyleParameter.ValueSourceSettings = staticListLookUpSettings2
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.GroupHeader1, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Orders"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Conditional Formatting"
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formattingRule1})
            Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.ConditionParameter, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.StyleParameter, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ConditionParameter, Me.StyleParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.oddStyle, Me.tahomaBoldStyle, Me.darkRedStyle, Me.lightRedStyle, Me.darkGreenStyle, Me.darkBlueStyle, Me.lightGreenStyle, Me.lightBlueStyle})
            Me.Version = "25.1"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.Report_BeforePrint)
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private oddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private tahomaBoldStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private darkRedStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private lightRedStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private darkGreenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private darkBlueStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private lightGreenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private lightBlueStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private ConditionParameter As DevExpress.XtraReports.Parameters.Parameter

        Private StyleParameter As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
