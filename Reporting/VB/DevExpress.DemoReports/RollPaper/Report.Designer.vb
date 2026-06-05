Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.RollPaper

    Partial Class Report

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
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.RollPaper.Report))
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.xrTable6 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
            Me.xrTable5 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.NetPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.paramOrderID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.Cash = New DevExpress.XtraReports.UI.CalculatedField()
            Me.Total = New DevExpress.XtraReports.UI.CalculatedField()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
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
            columnExpression7.ColumnName = "ExtendedPrice"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Supplier"
            columnExpression8.Table = table1
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
            selectQuery1.Tables.Add(table1)
            columnExpression9.ColumnName = "OrderID"
            table2.Name = "Orders"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "CustomerID"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EmployeeID"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "OrderDate"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "RequiredDate"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "ShippedDate"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ShipVia"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Freight"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ShipName"
            columnExpression17.Table = table2
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ShipAddress"
            columnExpression18.Table = table2
            column18.Expression = columnExpression18
            columnExpression19.ColumnName = "ShipCity"
            columnExpression19.Table = table2
            column19.Expression = columnExpression19
            columnExpression20.ColumnName = "ShipRegion"
            columnExpression20.Table = table2
            column20.Expression = columnExpression20
            columnExpression21.ColumnName = "ShipPostalCode"
            columnExpression21.Table = table2
            column21.Expression = columnExpression21
            columnExpression22.ColumnName = "ShipCountry"
            columnExpression22.Table = table2
            column22.Expression = columnExpression22
            column23.[Alias] = "Customers_CustomerID"
            columnExpression23.ColumnName = "CustomerID"
            table3.Name = "Customers"
            columnExpression23.Table = table3
            column23.Expression = columnExpression23
            columnExpression24.ColumnName = "CompanyName"
            columnExpression24.Table = table3
            column24.Expression = columnExpression24
            columnExpression25.ColumnName = "ContactName"
            columnExpression25.Table = table3
            column25.Expression = columnExpression25
            columnExpression26.ColumnName = "ContactTitle"
            columnExpression26.Table = table3
            column26.Expression = columnExpression26
            columnExpression27.ColumnName = "Address"
            columnExpression27.Table = table3
            column27.Expression = columnExpression27
            columnExpression28.ColumnName = "City"
            columnExpression28.Table = table3
            column28.Expression = columnExpression28
            columnExpression29.ColumnName = "Region"
            columnExpression29.Table = table3
            column29.Expression = columnExpression29
            columnExpression30.ColumnName = "PostalCode"
            columnExpression30.Table = table3
            column30.Expression = columnExpression30
            columnExpression31.ColumnName = "Country"
            columnExpression31.Table = table3
            column31.Expression = columnExpression31
            columnExpression32.ColumnName = "Phone"
            columnExpression32.Table = table3
            column32.Expression = columnExpression32
            columnExpression33.ColumnName = "Fax"
            columnExpression33.Table = table3
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
            join1.Nested = table2
            join1.Parent = table3
            selectQuery2.Relations.Add(join1)
            selectQuery2.Tables.Add(table3)
            selectQuery2.Tables.Add(table2)
            columnExpression34.ColumnName = "CustomerID"
            table4.Name = "Customers"
            columnExpression34.Table = table4
            column34.Expression = columnExpression34
            columnExpression35.ColumnName = "CompanyName"
            columnExpression35.Table = table4
            column35.Expression = columnExpression35
            columnExpression36.ColumnName = "ContactName"
            columnExpression36.Table = table4
            column36.Expression = columnExpression36
            selectQuery3.Columns.Add(column34)
            selectQuery3.Columns.Add(column35)
            selectQuery3.Columns.Add(column36)
            selectQuery3.Name = "Customers"
            selectQuery3.Tables.Add(table4)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2, selectQuery3})
            masterDetailInfo1.DetailQueryName = "OrderDetails"
            relationColumnInfo2.NestedKeyColumn = "OrderID"
            relationColumnInfo2.ParentKeyColumn = "OrderID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2)
            masterDetailInfo1.MasterQueryName = "Orders"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine2, Me.xrLine1, Me.xrTable2})
            Me.Detail.HeightF = 87.74999F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLine2.LineStyle = DevExpress.Drawing.DXDashStyle.Dash
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10F, 74F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(295.1496F, 2F)
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLine1.LineStyle = DevExpress.Drawing.DXDashStyle.Dash
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 10F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(295.1496F, 2F)
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10F, 22F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2, Me.xrTableRow10})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(295.1496F, 44F)
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6, Me.xrTableCell4})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 0.8799998540463897R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.TextFormatString = "Order #{0}"
            Me.xrTableCell6.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell4.TextFormatString = "{0:g}"
            Me.xrTableCell4.Weight = 1R
            ' 
            ' xrTableRow10
            ' 
            Me.xrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell8})
            Me.xrTableRow10.Name = "xrTableRow10"
            Me.xrTableRow10.Weight = 0.87999985404638981R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
            Me.xrTableCell8.Multiline = True
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.TextFormatString = "Cashier: {0}"
            Me.xrTableCell8.Weight = 2R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 40F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox3.ImageSource"))
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(68.6275F, 10F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox3.UseImageResolution = False
            Me.xrPictureBox3.StylePriority.UsePadding = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 40F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportFooter1})
            Me.DetailReport.DataMember = "Orders.OrdersOrderDetails"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail1.HeightF = 22F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(295.1496F, 22F)
            Me.xrTable1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell1, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1.4406850387385326R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell3.TextFormatString = "{0:$0.00}"
            Me.xrTableCell3.Weight = 0.56145691038257517R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Quantity")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell1.Weight = 0.25336433554110904R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "NetPrice")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F)
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell5.TextFormatString = "{0:$0.00}"
            Me.xrTableCell5.Weight = 0.62586388636789214R
            ' 
            ' ReportFooter1
            ' 
            Me.ReportFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable4})
            Me.ReportFooter1.HeightF = 44.41667F
            Me.ReportFooter1.Name = "ReportFooter1"
            Me.ReportFooter1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1, Me.SubBand2})
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(9.999969F, 10.41667F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow6})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(295.1496F, 34F)
            Me.xrTable4.StylePriority.UseFont = False
            Me.xrTable4.StylePriority.UsePadding = False
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell9, Me.xrTableCell16})
            Me.xrTableRow6.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.75F)
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.StylePriority.UseFont = False
            Me.xrTableRow6.Weight = 15.640000000000002R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StylePriority.UseFont = False
            Me.xrTableCell9.Text = "Total:"
            Me.xrTableCell9.Weight = 1.4245888135874651R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.xrTableCell16.StylePriority.UsePadding = False
            Me.xrTableCell16.StylePriority.UseTextAlignment = False
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell16.TextFormatString = "{0:$0.00}"
            Me.xrTableCell16.Weight = 1.4245880138797629R
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable6})
            Me.SubBand1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[Total] >= 1000")})
            Me.SubBand1.HeightF = 22F
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' xrTable6
            ' 
            Me.xrTable6.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.xrTable6.Name = "xrTable6"
            Me.xrTable6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow5})
            Me.xrTable6.SizeF = New System.Drawing.SizeF(295.1496F, 22F)
            Me.xrTable6.StylePriority.UseFont = False
            Me.xrTable6.StylePriority.UsePadding = False
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell10})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Weight = 10.119999999999997R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.StylePriority.UseFont = False
            Me.xrTableCell7.Text = "Credit card:"
            Me.xrTableCell7.Weight = 1.4245888135874651R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell10.TextFormatString = "{0:$0.00}"
            Me.xrTableCell10.Weight = 1.4245880138797629R
            ' 
            ' SubBand2
            ' 
            Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable5})
            Me.SubBand2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[Total] < 1000")})
            Me.SubBand2.HeightF = 44F
            Me.SubBand2.Name = "SubBand2"
            ' 
            ' xrTable5
            ' 
            Me.xrTable5.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.xrTable5.Name = "xrTable5"
            Me.xrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow11, Me.xrTableRow12})
            Me.xrTable5.SizeF = New System.Drawing.SizeF(295.1496F, 44F)
            Me.xrTable5.StylePriority.UseFont = False
            Me.xrTable5.StylePriority.UsePadding = False
            ' 
            ' xrTableRow11
            ' 
            Me.xrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell19, Me.xrTableCell20})
            Me.xrTableRow11.Name = "xrTableRow11"
            Me.xrTableRow11.Weight = 10.119999999999997R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.Multiline = True
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell19.StylePriority.UseFont = False
            Me.xrTableCell19.Text = "Cash:"
            Me.xrTableCell19.Weight = 1.4245888135874651R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cash]")})
            Me.xrTableCell20.Multiline = True
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.xrTableCell20.StylePriority.UsePadding = False
            Me.xrTableCell20.StylePriority.UseTextAlignment = False
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell20.TextFormatString = "{0:$0.00}"
            Me.xrTableCell20.Weight = 1.4245880138797629R
            ' 
            ' xrTableRow12
            ' 
            Me.xrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell21, Me.xrTableCell22})
            Me.xrTableRow12.Name = "xrTableRow12"
            Me.xrTableRow12.Weight = 10.119999999999997R
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.Multiline = True
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell21.StylePriority.UseFont = False
            Me.xrTableCell21.Text = "Change:"
            Me.xrTableCell21.Weight = 1.4245888135874651R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cash] - [Total]")})
            Me.xrTableCell22.Multiline = True
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.xrTableCell22.StylePriority.UsePadding = False
            Me.xrTableCell22.StylePriority.UseTextAlignment = False
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell22.TextFormatString = "{0:$0.00}"
            Me.xrTableCell22.Weight = 1.4245880138797629R
            ' 
            ' NetPrice
            ' 
            Me.NetPrice.DataMember = "Orders.OrdersOrderDetails"
            Me.NetPrice.Expression = "[UnitPrice] * [Quantity]"
            Me.NetPrice.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
            Me.NetPrice.Name = "NetPrice"
            ' 
            ' paramOrderID
            ' 
            Me.paramOrderID.Description = "Order ID"
            Me.paramOrderID.Name = "paramOrderID"
            Me.paramOrderID.Type = GetType(Long)
            Me.paramOrderID.ValueInfo = "11077"
            dynamicListLookUpSettings1.DataMember = "Orders"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "OrderID"
            dynamicListLookUpSettings1.FilterString = "[Country] = 'USA'"
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            dynamicListLookUpSettings1.ValueMember = "OrderID"
            Me.paramOrderID.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(10F, 50F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3, Me.xrTableRow4, Me.xrTableRow7})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(295.1496F, 66.00001F)
            Me.xrTable3.StylePriority.UseTextAlignment = False
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell13})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 0.88R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.Weight = 1R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell14})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 0.88000000000000012R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address] + ', ' + [City] + ', ' + [Country]")})
            Me.xrTableCell14.Multiline = True
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell14.Weight = 1R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Weight = 0.88R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            Me.xrTableCell11.Multiline = True
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell11.Weight = 1R
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLine3, Me.xrBarCode1})
            Me.ReportFooter.HeightF = 89.99999F
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.StylePriority.UseBorders = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 66.99999F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(295.1496F, 23F)
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Thank you"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLine3.LineStyle = DevExpress.Drawing.DXDashStyle.Dash
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 14.99999F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.SizeF = New System.Drawing.SizeF(295.1496F, 2F)
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(56F, 26.99999F)
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode1.ShowText = False
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(200F, 30F)
            Me.xrBarCode1.StylePriority.UseTextAlignment = False
            Me.xrBarCode1.Symbology = code128Generator1
            Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox3, Me.xrTable3})
            Me.ReportHeader.HeightF = 116F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' Cash
            ' 
            Me.Cash.DataMember = "Orders.OrdersOrderDetails"
            Me.Cash.Expression = "Ceiling([Total] / 100) * 100"
            Me.Cash.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
            Me.Cash.Name = "Cash"
            ' 
            ' Total
            ' 
            Me.Total.DataMember = "Orders.OrdersOrderDetails"
            Me.Total.Expression = "Sum([NetPrice])"
            Me.Total.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
            Me.Total.Name = "Total"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.ReportFooter, Me.ReportHeader})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.NetPrice, Me.Cash, Me.Total})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Orders"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Roll Paper"
            Me.FilterString = "[OrderID] = ?paramOrderID"
            Me.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 40, 40)
            Me.PageWidth = 315
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramOrderID})
            Me.RequestParameters = False
            Me.RollPaper = True
            Me.Version = "21.2"
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private NetPrice As DevExpress.XtraReports.UI.CalculatedField

        Private paramOrderID As DevExpress.XtraReports.Parameters.Parameter

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLine2 As DevExpress.XtraReports.UI.XRLine

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLine3 As DevExpress.XtraReports.UI.XRLine

        Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand

        Private Cash As DevExpress.XtraReports.UI.CalculatedField

        Private Total As DevExpress.XtraReports.UI.CalculatedField

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private xrTable6 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private SubBand2 As DevExpress.XtraReports.UI.SubBand

        Private xrTable5 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
