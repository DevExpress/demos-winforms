Namespace XtraReportsDemos.DrillThroughReport

    Partial Class DetailReport

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
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.DrillThroughReport.DetailReport))
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.panel2 = New DevExpress.XtraReports.UI.XRPanel()
            Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.panel3 = New DevExpress.XtraReports.UI.XRPanel()
            Me.line1 = New DevExpress.XtraReports.UI.XRLine()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.HeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Customer = New DevExpress.XtraReports.Parameters.Parameter()
            Me.orderId = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "DevAvConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "Name"
            table4.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""778"" />"
            table4.Name = "Customers"
            columnExpression1.Table = table4
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Id"
            table5.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""458"" />"
            table5.Name = "Orders"
            columnExpression2.Table = table5
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "OrderId"
            table6.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""218"" />"
            table6.Name = "OrderItems"
            columnExpression3.Table = table6
            column3.Expression = columnExpression3
            column4.[Alias] = "Products_Name"
            columnExpression4.ColumnName = "Name"
            table7.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""458"" />"
            table7.Name = "Products"
            columnExpression4.Table = table7
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ProductUnits"
            columnExpression5.Table = table6
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "ProductPrice"
            columnExpression6.Table = table6
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Discount"
            columnExpression7.Table = table6
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Total"
            columnExpression8.Table = table6
            column8.Expression = columnExpression8
            column9.[Alias] = "Customers_Id"
            columnExpression9.ColumnName = "Id"
            columnExpression9.Table = table4
            column9.Expression = columnExpression9
            column10.[Alias] = "OrderItems_Id"
            columnExpression10.ColumnName = "Id"
            columnExpression10.Table = table6
            column10.Expression = columnExpression10
            column11.[Alias] = "Products_Id"
            columnExpression11.ColumnName = "Id"
            columnExpression11.Table = table7
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "OrderDate"
            columnExpression12.Table = table5
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "ShipDate"
            columnExpression13.Table = table5
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "InvoiceNumber"
            columnExpression14.Table = table5
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ShipmentStatus"
            columnExpression15.Table = table5
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Logo"
            columnExpression16.Table = table4
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ShipMethod"
            columnExpression17.Table = table5
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ShippingAmount"
            columnExpression18.Table = table5
            column18.Expression = columnExpression18
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
            selectQuery1.Columns.Add(column16)
            selectQuery1.Columns.Add(column17)
            selectQuery1.Columns.Add(column18)
            selectQuery1.Name = "Customers"
            relationColumnInfo1.NestedKeyColumn = "CustomerId"
            relationColumnInfo1.ParentKeyColumn = "Id"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table5
            join1.Parent = table4
            relationColumnInfo2.NestedKeyColumn = "OrderId"
            relationColumnInfo2.ParentKeyColumn = "Id"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table6
            join2.Parent = table5
            relationColumnInfo3.NestedKeyColumn = "Id"
            relationColumnInfo3.ParentKeyColumn = "ProductId"
            join3.KeyColumns.Add(relationColumnInfo3)
            join3.Nested = table7
            join3.Parent = table6
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Relations.Add(join3)
            selectQuery1.Tables.Add(table4)
            selectQuery1.Tables.Add(table5)
            selectQuery1.Tables.Add(table6)
            selectQuery1.Tables.Add(table7)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' ReportHeader1
            ' 
            Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2, Me.panel2, Me.label1})
            Me.ReportHeader1.HeightF = 301.303F
            Me.ReportHeader1.Name = "ReportHeader1"
            ' 
            ' table2
            ' 
            Me.table2.Font = New DevExpress.Drawing.DXFont("Arial", 11.75F)
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 129.317F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3, Me.tableRow9, Me.tableRow10})
            Me.table2.SizeF = New System.Drawing.SizeF(452.0256F, 60F)
            Me.table2.StylePriority.UseFont = False
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell8})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 0.4511305324290476R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "HeaderStyle"
            Me.tableCell7.StylePriority.UseBorders = False
            Me.tableCell7.StylePriority.UseFont = False
            Me.tableCell7.StylePriority.UseForeColor = False
            Me.tableCell7.StylePriority.UsePadding = False
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.Text = "Order ID:"
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell7.Weight = 0.14684537614319504R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderId]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData"
            Me.tableCell8.StylePriority.UseBackColor = False
            Me.tableCell8.StylePriority.UseBorderColor = False
            Me.tableCell8.StylePriority.UseBorderDashStyle = False
            Me.tableCell8.StylePriority.UseBorders = False
            Me.tableCell8.StylePriority.UseBorderWidth = False
            Me.tableCell8.StylePriority.UseFont = False
            Me.tableCell8.StylePriority.UseForeColor = False
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.StylePriority.UseTextAlignment = False
            Me.tableCell8.Weight = 0.36293878133311663R
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell27, Me.tableCell28})
            Me.tableRow9.Name = "tableRow9"
            Me.tableRow9.StylePriority.UseBackColor = False
            Me.tableRow9.StylePriority.UseBorderColor = False
            Me.tableRow9.StylePriority.UseBorderDashStyle = False
            Me.tableRow9.StylePriority.UseBorders = False
            Me.tableRow9.StylePriority.UseBorderWidth = False
            Me.tableRow9.StylePriority.UseFont = False
            Me.tableRow9.StylePriority.UseForeColor = False
            Me.tableRow9.StylePriority.UseTextAlignment = False
            Me.tableRow9.Weight = 0.4511305324290476R
            ' 
            ' tableCell27
            ' 
            Me.tableCell27.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell27.Multiline = True
            Me.tableCell27.Name = "tableCell27"
            Me.tableCell27.StyleName = "HeaderStyle"
            Me.tableCell27.StylePriority.UseBorders = False
            Me.tableCell27.StylePriority.UseFont = False
            Me.tableCell27.StylePriority.UseTextAlignment = False
            Me.tableCell27.Text = "Order Date:" & Global.Microsoft.VisualBasic.Constants.vbLf
            Me.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell27.Weight = 0.14684537614319504R
            ' 
            ' tableCell28
            ' 
            Me.tableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate] ")})
            Me.tableCell28.Multiline = True
            Me.tableCell28.Name = "tableCell28"
            Me.tableCell28.StyleName = "DetailData"
            Me.tableCell28.StylePriority.UseBackColor = False
            Me.tableCell28.StylePriority.UseBorderColor = False
            Me.tableCell28.StylePriority.UseFont = False
            Me.tableCell28.StylePriority.UseForeColor = False
            Me.tableCell28.StylePriority.UsePadding = False
            Me.tableCell28.StylePriority.UseTextAlignment = False
            Me.tableCell28.TextFormatString = "{0:M/d/yyyy}"
            Me.tableCell28.Weight = 0.36293878133311663R
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell29, Me.tableCell30})
            Me.tableRow10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow10.Name = "tableRow10"
            Me.tableRow10.StylePriority.UseForeColor = False
            Me.tableRow10.Weight = 0.4511305324290476R
            ' 
            ' tableCell29
            ' 
            Me.tableCell29.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell29.Multiline = True
            Me.tableCell29.Name = "tableCell29"
            Me.tableCell29.StyleName = "HeaderStyle"
            Me.tableCell29.StylePriority.UseBorders = False
            Me.tableCell29.StylePriority.UseFont = False
            Me.tableCell29.StylePriority.UseTextAlignment = False
            Me.tableCell29.Text = "Shipment Status:"
            Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell29.Weight = 0.14684537614319504R
            ' 
            ' tableCell30
            ' 
            Me.tableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ShipmentStatus] == 0, 'Pending', [ShipmentStatus] == 1, 'In Transit', 'Deliv" & "ered')")})
            Me.tableCell30.Font = New DevExpress.Drawing.DXFont("Arial", 11.75F)
            Me.tableCell30.Multiline = True
            Me.tableCell30.Name = "tableCell30"
            Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell30.StyleName = "DetailData"
            Me.tableCell30.StylePriority.UseBackColor = False
            Me.tableCell30.StylePriority.UseBorderColor = False
            Me.tableCell30.StylePriority.UseBorderDashStyle = False
            Me.tableCell30.StylePriority.UseBorders = False
            Me.tableCell30.StylePriority.UseBorderWidth = False
            Me.tableCell30.StylePriority.UsePadding = False
            Me.tableCell30.StylePriority.UseTextAlignment = False
            Me.tableCell30.Text = "tableCell30"
            Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell30.Weight = 0.36293878133311663R
            ' 
            ' panel2
            ' 
            Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((247)))))), (CInt(((CByte((247)))))), (CInt(((CByte((250)))))))
            Me.panel2.CanShrink = True
            Me.panel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label3, Me.table3})
            Me.panel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 236.465F)
            Me.panel2.Name = "panel2"
            Me.panel2.SizeF = New System.Drawing.SizeF(650F, 64.831F)
            Me.panel2.StylePriority.UseBackColor = False
            ' 
            ' label3
            ' 
            Me.label3.Font = New DevExpress.Drawing.DXFont("Arial", 13.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label3.Multiline = True
            Me.label3.Name = "label3"
            Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.label3.SizeF = New System.Drawing.SizeF(186.406F, 23F)
            Me.label3.StylePriority.UseFont = False
            Me.label3.StylePriority.UseForeColor = False
            Me.label3.StylePriority.UsePadding = False
            Me.label3.Text = "Order Items:"
            ' 
            ' table3
            ' 
            Me.table3.BackColor = System.Drawing.Color.Transparent
            Me.table3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((235)))))))
            Me.table3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.table3.BorderWidth = 2F
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 31.98667F)
            Me.table3.Name = "table3"
            Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F)
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
            Me.table3.SizeF = New System.Drawing.SizeF(647.949F, 31.68F)
            Me.table3.StylePriority.UseBackColor = False
            Me.table3.StylePriority.UseBorderColor = False
            Me.table3.StylePriority.UseBorders = False
            Me.table3.StylePriority.UseBorderWidth = False
            Me.table3.StylePriority.UsePadding = False
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell18, Me.tableCell9, Me.tableCell17, Me.tableCell19})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.StylePriority.UseTextAlignment = False
            Me.tableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableRow5.Weight = 1R
            ' 
            ' tableCell18
            ' 
            Me.tableCell18.Name = "tableCell18"
            Me.tableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableCell18.StylePriority.UseBorders = False
            Me.tableCell18.StylePriority.UsePadding = False
            Me.tableCell18.StylePriority.UseTextAlignment = False
            Me.tableCell18.Text = "Name"
            Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell18.Weight = 0.3245012350473872R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F)
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.StylePriority.UseTextAlignment = False
            Me.tableCell9.Text = "Price"
            Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell9.Weight = 0.373586430194757R
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F)
            Me.tableCell17.StylePriority.UseBorders = False
            Me.tableCell17.StylePriority.UsePadding = False
            Me.tableCell17.StylePriority.UseTextAlignment = False
            Me.tableCell17.Text = "Quantity"
            Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell17.Weight = 0.35265621870296848R
            ' 
            ' tableCell19
            ' 
            Me.tableCell19.Multiline = True
            Me.tableCell19.Name = "tableCell19"
            Me.tableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableCell19.StylePriority.UseBorders = False
            Me.tableCell19.StylePriority.UsePadding = False
            Me.tableCell19.StylePriority.UseTextAlignment = False
            Me.tableCell19.Text = "Discount"
            Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell19.Weight = 0.31076249921814414R
            ' 
            ' label1
            ' 
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('Details of Order № {0} ', [OrderId] )")})
            Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 24F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((62)))))), (CInt(((CByte((62)))))), (CInt(((CByte((79)))))))
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(650F, 73.19112F)
            Me.label1.StylePriority.UseFont = False
            Me.label1.StylePriority.UseForeColor = False
            Me.label1.StylePriority.UsePadding = False
            Me.label1.StylePriority.UseTextAlignment = False
            Me.label1.Text = "Details of Order"
            Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.Detail.HeightF = 30.72F
            Me.Detail.Name = "Detail"
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((247)))))), (CInt(((CByte((250)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(650F, 30.72F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' table1
            ' 
            Me.table1.BackColor = System.Drawing.Color.White
            Me.table1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((235)))))))
            Me.table1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.table1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(649.503F, 30.72001F)
            Me.table1.StylePriority.UseBackColor = False
            Me.table1.StylePriority.UseBorderColor = False
            Me.table1.StylePriority.UseBorders = False
            Me.table1.StylePriority.UseForeColor = False
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 11.5R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Products_Name]")})
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            Me.tableCell1.Text = "tableCell1"
            Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell1.Weight = 0.31966462396353656R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductPrice]")})
            Me.tableCell2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 6, 0, 0, 100F)
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UseForeColor = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.Text = "tableCell8"
            Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell2.TextFormatString = "{0:c2}"
            Me.tableCell2.Weight = 0.37028694994410166R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductUnits]")})
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableCell3.StylePriority.UseFont = False
            Me.tableCell3.StylePriority.UsePadding = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "tableCell3"
            Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell3.Weight = 0.34708376659626344R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")})
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableCell4.StylePriority.UseBorderColor = False
            Me.tableCell4.StylePriority.UseBorderDashStyle = False
            Me.tableCell4.StylePriority.UseBorders = False
            Me.tableCell4.StylePriority.UseBorderWidth = False
            Me.tableCell4.StylePriority.UseFont = False
            Me.tableCell4.StylePriority.UsePadding = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "tableCell22"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell4.TextFormatString = "{0:c2}"
            Me.tableCell4.Weight = 0.30970729160222177R
            ' 
            ' ReportFooter1
            ' 
            Me.ReportFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel3})
            Me.ReportFooter1.HeightF = 113.0368F
            Me.ReportFooter1.Name = "ReportFooter1"
            ' 
            ' panel3
            ' 
            Me.panel3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((247)))))), (CInt(((CByte((247)))))), (CInt(((CByte((250)))))))
            Me.panel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1, Me.line1})
            Me.panel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel3.Name = "panel3"
            Me.panel3.SizeF = New System.Drawing.SizeF(650F, 113.0368F)
            Me.panel3.StylePriority.UseBackColor = False
            ' 
            ' line1
            ' 
            Me.line1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.line1.LineWidth = 1.5F
            Me.line1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.line1.Name = "line1"
            Me.line1.SizeF = New System.Drawing.SizeF(650F, 2F)
            Me.line1.StylePriority.UseForeColor = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' HeaderStyle
            ' 
            Me.HeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((147)))))), (CInt(((CByte((173)))))))
            Me.HeaderStyle.Name = "HeaderStyle"
            ' 
            ' DetailData
            ' 
            Me.DetailData.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.DetailData.ForeColor = System.Drawing.Color.Black
            Me.DetailData.Name = "DetailData"
            Me.DetailData.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.DetailData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' Customer
            ' 
            Me.Customer.Description = "Customer:"
            Me.Customer.Name = "Customer"
            Me.Customer.Type = GetType(Integer)
            Me.Customer.ValueInfo = "20"
            dynamicListLookUpSettings1.DataMember = "Customers"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "Name"
            dynamicListLookUpSettings1.ValueMember = "Customers_Id"
            Me.Customer.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' orderId
            ' 
            Me.orderId.Description = "OrderId"
            Me.orderId.Name = "orderId"
            Me.orderId.Type = GetType(Integer)
            Me.orderId.ValueInfo = "0"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Arial", 11.75F)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(332.7478F, 15.06057F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(317.25F, 90F)
            Me.xrTable1.StylePriority.UseFont = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 0.4511305324290476R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell1.StyleName = "HeaderStyle"
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UseForeColor = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Sales Total:"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell1.Weight = 0.36175387770892414R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Total])")})
            Me.xrTableCell2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.xrTableCell2.StyleName = "DetailData"
            Me.xrTableCell2.StylePriority.UseBackColor = False
            Me.xrTableCell2.StylePriority.UseBorderColor = False
            Me.xrTableCell2.StylePriority.UseBorderDashStyle = False
            Me.xrTableCell2.StylePriority.UseBorders = False
            Me.xrTableCell2.StylePriority.UseBorderWidth = False
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.StylePriority.UseForeColor = False
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell2.Summary = xrSummary1
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.TextFormatString = "{0:c2}"
            Me.xrTableCell2.Weight = 0.14803027976738753R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.StylePriority.UseBackColor = False
            Me.xrTableRow2.StylePriority.UseBorderColor = False
            Me.xrTableRow2.StylePriority.UseBorderDashStyle = False
            Me.xrTableRow2.StylePriority.UseBorders = False
            Me.xrTableRow2.StylePriority.UseBorderWidth = False
            Me.xrTableRow2.StylePriority.UseFont = False
            Me.xrTableRow2.StylePriority.UseForeColor = False
            Me.xrTableRow2.StylePriority.UseTextAlignment = False
            Me.xrTableRow2.Weight = 0.4511305324290476R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell3.StyleName = "HeaderStyle"
            Me.xrTableCell3.StylePriority.UseBorders = False
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "Shipping Amount:"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.36175389088054682R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShippingAmount]")})
            Me.xrTableCell4.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.xrTableCell4.StyleName = "DetailData"
            Me.xrTableCell4.StylePriority.UseBackColor = False
            Me.xrTableCell4.StylePriority.UseBorderColor = False
            Me.xrTableCell4.StylePriority.UseFont = False
            Me.xrTableCell4.StylePriority.UseForeColor = False
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell4.TextFormatString = "{0:c2}"
            Me.xrTableCell4.Weight = 0.14803026659576488R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.StylePriority.UseForeColor = False
            Me.xrTableRow3.Weight = 0.4511305324290476R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell5.StyleName = "HeaderStyle"
            Me.xrTableCell5.StylePriority.UseBorders = False
            Me.xrTableCell5.StylePriority.UseFont = False
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "Shipment Status:"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell5.Weight = 0.36175389088054682R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Total]) + [ShippingAmount]")})
            Me.xrTableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.xrTableCell6.StyleName = "DetailData"
            Me.xrTableCell6.StylePriority.UseBackColor = False
            Me.xrTableCell6.StylePriority.UseBorderColor = False
            Me.xrTableCell6.StylePriority.UseBorderDashStyle = False
            Me.xrTableCell6.StylePriority.UseBorders = False
            Me.xrTableCell6.StylePriority.UseBorderWidth = False
            Me.xrTableCell6.StylePriority.UseFont = False
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell6.Summary = xrSummary2
            Me.xrTableCell6.Text = "tableCell30"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.TextFormatString = "{0:c2}"
            Me.xrTableCell6.Weight = 0.14803026659576488R
            ' 
            ' DetailReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.ReportHeader1, Me.Detail, Me.ReportFooter1, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Order Details"
            Me.FilterString = "[Customers_Id] = ?Customer And [OrderId] = ?orderId"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Customer, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.orderId, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Customer, Me.orderId})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.HeaderStyle, Me.DetailData})
            Me.Version = "24.2"
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private panel2 As DevExpress.XtraReports.UI.XRPanel

        Private label3 As DevExpress.XtraReports.UI.XRLabel

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand

        Private panel3 As DevExpress.XtraReports.UI.XRPanel

        Private line1 As DevExpress.XtraReports.UI.XRLine

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private HeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData As DevExpress.XtraReports.UI.XRControlStyle

        Private Customer As DevExpress.XtraReports.Parameters.Parameter

        Private orderId As DevExpress.XtraReports.Parameters.Parameter

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
