Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.SalesSummary

    Public Partial Class Report

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim crossTabColumnField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
            Dim crossTabColumnField2 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
            Dim crossTabDataField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
            Dim crossTabRowField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
            Dim crossTabRowField2 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.SalesSummary.Report))
            Dim dynamicListLookUpSettings3 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim dynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim groupLayoutItem1 As DevExpress.XtraReports.Parameters.GroupLayoutItem = New DevExpress.XtraReports.Parameters.GroupLayoutItem("Salesperson filter", True)
            Dim groupLayoutItem2 As DevExpress.XtraReports.Parameters.GroupLayoutItem = New DevExpress.XtraReports.Parameters.GroupLayoutItem("Category filter", True)
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.crossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
            Me.crossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell11 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell12 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell13 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell14 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell15 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell16 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell17 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell18 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell19 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.crossTabGeneralStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.crossTabHeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.crossTabDataStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.crossTabTotalStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.country = New DevExpress.XtraReports.Parameters.Parameter()
            Me.salespeople = New DevExpress.XtraReports.Parameters.Parameter()
            Me.enableFilter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.categories = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.crossTab1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.crossTab1})
            Me.Detail.HeightF = 113F
            Me.Detail.Name = "Detail"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 94F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' crossTab1
            ' 
            Me.crossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.crossTabCell1, Me.crossTabCell2, Me.crossTabCell3, Me.crossTabCell4, Me.crossTabCell5, Me.crossTabCell6, Me.crossTabCell7, Me.crossTabCell8, Me.crossTabCell9, Me.crossTabCell10, Me.crossTabCell11, Me.crossTabCell12, Me.crossTabCell13, Me.crossTabCell14, Me.crossTabCell15, Me.crossTabCell16, Me.crossTabCell17, Me.crossTabCell18, Me.crossTabCell19})
            Me.crossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(127.5552F), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(118.1822F), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(130F), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133F), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133F)})
            crossTabColumnField1.FieldName = "Country"
            crossTabColumnField2.FieldName = "FullName"
            Me.crossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() {crossTabColumnField1, crossTabColumnField2})
            Me.crossTab1.DataAreaStyleName = "crossTabDataStyle1"
            crossTabDataField1.FieldName = "ExtendedPrice"
            Me.crossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() {crossTabDataField1})
            Me.crossTab1.DataMember = "SalesPerson"
            Me.crossTab1.DataSource = Me.sqlDataSource1
            Me.crossTab1.FilterString = "[FullName] In (?salespeople) And Iif(?enableFilter, [CategoryName] In (?categorie" & "s), True)"
            Me.crossTab1.GeneralStyleName = "crossTabGeneralStyle1"
            Me.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1"
            Me.crossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.crossTab1.Name = "crossTab1"
            Me.crossTab1.Parameters.AddRange(New DevExpress.XtraReports.UI.XRControlParameter() {New DevExpress.XtraReports.UI.XRControlParameter("enableFilter", Me.enableFilter), New DevExpress.XtraReports.UI.XRControlParameter("categories", Me.categories), New DevExpress.XtraReports.UI.XRControlParameter("salespeople", Me.salespeople)})
            Me.crossTab1.PrintOptions.PrintTotalsForSingleValues = False
            Me.crossTab1.PrintOptions.RepeatColumnHeaders = False
            Me.crossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F)})
            crossTabRowField1.FieldName = "OrderDate"
            crossTabRowField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateQuarter
            crossTabRowField2.FieldName = "CategoryName"
            Me.crossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() {crossTabRowField1, crossTabRowField2})
            Me.crossTab1.SizeF = New System.Drawing.SizeF(641.7374F, 113F)
            Me.crossTab1.TotalAreaStyleName = "crossTabTotalStyle1"
            ' 
            ' crossTabCell1
            ' 
            Me.crossTabCell1.ColumnIndex = 0
            Me.crossTabCell1.Name = "crossTabCell1"
            Me.crossTabCell1.RowIndex = 0
            Me.crossTabCell1.RowSpan = 2
            Me.crossTabCell1.Text = "Order Date"
            Me.crossTabCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell2
            ' 
            Me.crossTabCell2.ColumnIndex = 2
            Me.crossTabCell2.Name = "crossTabCell2"
            Me.crossTabCell2.RowIndex = 2
            Me.crossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell2.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell3
            ' 
            Me.crossTabCell3.ColumnIndex = 2
            Me.crossTabCell3.Name = "crossTabCell3"
            Me.crossTabCell3.RowIndex = 0
            Me.crossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell4
            ' 
            Me.crossTabCell4.ColumnIndex = 4
            Me.crossTabCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "not ?enableFilter")})
            Me.crossTabCell4.Name = "crossTabCell4"
            Me.crossTabCell4.RowIndex = 0
            Me.crossTabCell4.RowSpan = 2
            Me.crossTabCell4.Text = "Grand Total"
            Me.crossTabCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell5
            ' 
            Me.crossTabCell5.ColumnIndex = 4
            Me.crossTabCell5.Name = "crossTabCell5"
            Me.crossTabCell5.RowIndex = 2
            Me.crossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell5.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell6
            ' 
            Me.crossTabCell6.ColumnIndex = 0
            Me.crossTabCell6.Name = "crossTabCell6"
            Me.crossTabCell6.RowIndex = 2
            Me.crossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.crossTabCell6.TextFormatString = "Quarter {0}"
            ' 
            ' crossTabCell7
            ' 
            Me.crossTabCell7.ColumnIndex = 0
            Me.crossTabCell7.ColumnSpan = 2
            Me.crossTabCell7.Name = "crossTabCell7"
            Me.crossTabCell7.RowIndex = 4
            Me.crossTabCell7.Text = "Grand Total"
            Me.crossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell8
            ' 
            Me.crossTabCell8.ColumnIndex = 2
            Me.crossTabCell8.Name = "crossTabCell8"
            Me.crossTabCell8.RowIndex = 4
            Me.crossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell8.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell9
            ' 
            Me.crossTabCell9.ColumnIndex = 4
            Me.crossTabCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "RowVisible", "not ?enableFilter")})
            Me.crossTabCell9.Name = "crossTabCell9"
            Me.crossTabCell9.RowIndex = 4
            Me.crossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell9.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell10
            ' 
            Me.crossTabCell10.ColumnIndex = 2
            Me.crossTabCell10.Name = "crossTabCell10"
            Me.crossTabCell10.RowIndex = 1
            Me.crossTabCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell11
            ' 
            Me.crossTabCell11.ColumnIndex = 3
            Me.crossTabCell11.Name = "crossTabCell11"
            Me.crossTabCell11.RowIndex = 0
            Me.crossTabCell11.RowSpan = 2
            Me.crossTabCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.crossTabCell11.TextFormatString = "Total {0}"
            ' 
            ' crossTabCell12
            ' 
            Me.crossTabCell12.BackColor = System.Drawing.Color.White
            Me.crossTabCell12.ColumnIndex = 3
            Me.crossTabCell12.Font = New DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.crossTabCell12.Name = "crossTabCell12"
            Me.crossTabCell12.RowIndex = 2
            Me.crossTabCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell12.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell13
            ' 
            Me.crossTabCell13.ColumnIndex = 3
            Me.crossTabCell13.Name = "crossTabCell13"
            Me.crossTabCell13.RowIndex = 4
            Me.crossTabCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell13.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell14
            ' 
            Me.crossTabCell14.ColumnIndex = 1
            Me.crossTabCell14.Name = "crossTabCell14"
            Me.crossTabCell14.RowIndex = 0
            Me.crossTabCell14.RowSpan = 2
            Me.crossTabCell14.Text = "Category Name"
            Me.crossTabCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell15
            ' 
            Me.crossTabCell15.ColumnIndex = 1
            Me.crossTabCell15.Name = "crossTabCell15"
            Me.crossTabCell15.RowIndex = 2
            Me.crossTabCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabCell16
            ' 
            Me.crossTabCell16.ColumnIndex = 0
            Me.crossTabCell16.ColumnSpan = 2
            Me.crossTabCell16.Name = "crossTabCell16"
            Me.crossTabCell16.RowIndex = 3
            Me.crossTabCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.crossTabCell16.TextFormatString = "Total {0}"
            ' 
            ' crossTabCell17
            ' 
            Me.crossTabCell17.BackColor = System.Drawing.Color.White
            Me.crossTabCell17.ColumnIndex = 2
            Me.crossTabCell17.Font = New DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.crossTabCell17.Name = "crossTabCell17"
            Me.crossTabCell17.RowIndex = 3
            Me.crossTabCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell17.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell18
            ' 
            Me.crossTabCell18.BackColor = System.Drawing.Color.White
            Me.crossTabCell18.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.crossTabCell18.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.crossTabCell18.BorderWidth = 1F
            Me.crossTabCell18.ColumnIndex = 3
            Me.crossTabCell18.Font = New DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.crossTabCell18.Name = "crossTabCell18"
            Me.crossTabCell18.RowIndex = 3
            Me.crossTabCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell18.TextFormatString = "{0:c}"
            ' 
            ' crossTabCell19
            ' 
            Me.crossTabCell19.ColumnIndex = 4
            Me.crossTabCell19.Name = "crossTabCell19"
            Me.crossTabCell19.RowIndex = 3
            Me.crossTabCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.crossTabCell19.TextFormatString = "{0:c}"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "SalesPerson"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Country"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "FirstName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "LastName"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ProductName"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "OrderDate"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitPrice"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Quantity"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discount"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "ExtendedPrice"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "FullName"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
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
            selectQuery1.Name = "SalesPerson"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(382.3333F, 38.3333F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.UseImageResolution = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(771.861F, 10.00002F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(118.1389F, 24.63888F)
            Me.xrPageInfo1.StylePriority.UseBorders = False
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseForeColor = False
            Me.xrPageInfo1.StylePriority.UsePadding = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrPageInfo1.TextFormatString = "Page : {0 } / {1}"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 21.75F)
            Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(280.1805F, 36.47224F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(324F, 42F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.Text = "Sales Summary by Year"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' crossTabGeneralStyle1
            ' 
            Me.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.crossTabGeneralStyle1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.crossTabGeneralStyle1.Font = New DevExpress.Drawing.DXFont("Calibri", 9F)
            Me.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1"
            Me.crossTabGeneralStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' crossTabHeaderStyle1
            ' 
            Me.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.crossTabHeaderStyle1.Font = New DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1"
            Me.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' crossTabDataStyle1
            ' 
            Me.crossTabDataStyle1.BackColor = System.Drawing.Color.White
            Me.crossTabDataStyle1.Name = "crossTabDataStyle1"
            Me.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' crossTabTotalStyle1
            ' 
            Me.crossTabTotalStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.crossTabTotalStyle1.Font = New DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.crossTabTotalStyle1.Name = "crossTabTotalStyle1"
            Me.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' country
            ' 
            Me.country.Description = "Country"
            Me.country.MultiValue = True
            Me.country.Name = "country"
            Me.country.SelectAllValues = True
            Me.country.ValueInfo = "USA|UK"
            dynamicListLookUpSettings3.DataMember = "SalesPerson"
            dynamicListLookUpSettings3.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings3.DisplayMember = "Country"
            dynamicListLookUpSettings3.ValueMember = "Country"
            Me.country.ValueSourceSettings = dynamicListLookUpSettings3
            ' 
            ' salespeople
            ' 
            Me.salespeople.Description = "Salespeople"
            Me.salespeople.MultiValue = True
            Me.salespeople.Name = "salespeople"
            Me.salespeople.SelectAllValues = True
            Me.salespeople.ValueInfo = "Nancy Davolio|Andrew Fuller|Janet Leverling|Margaret Peacock|Steven Buchanan|Mich" & "ael Suyama|Robert King|Laura Callahan|Anne Dodsworth"
            dynamicListLookUpSettings2.DataMember = "SalesPerson"
            dynamicListLookUpSettings2.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings2.DisplayMember = "FullName"
            dynamicListLookUpSettings2.FilterString = "[Country] In (?country)"
            dynamicListLookUpSettings2.ValueMember = "FullName"
            Me.salespeople.ValueSourceSettings = dynamicListLookUpSettings2
            ' 
            ' enableFilter
            ' 
            Me.enableFilter.Description = "Enable filter"
            Me.enableFilter.Name = "enableFilter"
            Me.enableFilter.Type = GetType(Boolean)
            Me.enableFilter.ValueInfo = "False"
            ' 
            ' categories
            ' 
            Me.categories.Description = "Categories"
            Me.categories.ExpressionBindings.AddRange(New DevExpress.XtraReports.Expressions.BasicExpressionBinding() {New DevExpress.XtraReports.Expressions.BasicExpressionBinding("Enabled", "?enableFilter")})
            Me.categories.MultiValue = True
            Me.categories.Name = "categories"
            Me.categories.SelectAllValues = True
            Me.categories.ValueInfo = "Beverages|Condiments|Confections|Dairy Products|Grains/Cereals|Meat/Poultry|Produ" & "ce|Seafood"
            dynamicListLookUpSettings1.DataMember = "SalesPerson"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "CategoryName"
            dynamicListLookUpSettings1.ValueMember = "CategoryName"
            Me.categories.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DisplayName = "Sales Summary"
            Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 100F, 94F)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            groupLayoutItem1.Items.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.country, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.salespeople, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
            groupLayoutItem1.Title = "Salesperson filter"
            groupLayoutItem2.Items.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.enableFilter, DevExpress.XtraReports.Parameters.Orientation.Vertical), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.categories, DevExpress.XtraReports.Parameters.Orientation.Vertical)})
            groupLayoutItem2.Orientation = DevExpress.XtraReports.Parameters.Orientation.Horizontal
            groupLayoutItem2.Title = "Category filter"
            Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {groupLayoutItem1, groupLayoutItem2})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.country, Me.salespeople, Me.enableFilter, Me.categories})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.crossTabGeneralStyle1, Me.crossTabHeaderStyle1, Me.crossTabDataStyle1, Me.crossTabTotalStyle1})
            Me.Version = "25.1"
            Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
            CType((Me.crossTab1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private crossTab1 As DevExpress.XtraReports.UI.XRCrossTab

        Private crossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell11 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell12 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell13 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell14 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell15 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell16 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell17 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell18 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell19 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private enableFilter As DevExpress.XtraReports.Parameters.Parameter

        Private categories As DevExpress.XtraReports.Parameters.Parameter

        Private salespeople As DevExpress.XtraReports.Parameters.Parameter

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private crossTabGeneralStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private crossTabHeaderStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private crossTabDataStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private crossTabTotalStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private country As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
