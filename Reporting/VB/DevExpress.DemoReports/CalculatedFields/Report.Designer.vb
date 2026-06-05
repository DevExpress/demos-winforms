Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.CalculatedFieldsReport

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.CalculatedFieldsReport.Report))
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
            Dim staticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clProductID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clCalculatedField = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.dsOrderReports1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.HeaderYellowStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.MainYellowStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.MainRedStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.MainGreenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderGreenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderRedStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.ExpressionParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 22F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.ReportHeader.HeightF = 16F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2, Me.xrLabel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
            Me.GroupHeader1.HeightF = 65F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3})
            Me.GroupFooter1.HeightF = 49F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(4F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(647F, 22F)
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.clProductName, Me.clProductID, Me.clQuantity, Me.clUnitPrice, Me.clDiscount, Me.clCalculatedField})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' clProductName
            ' 
            Me.clProductName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")})
            Me.clProductName.Name = "clProductName"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clProductName.StyleName = "MainGreenStyle"
            Me.clProductName.StylePriority.UseTextAlignment = False
            Me.clProductName.Text = "clProductName"
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clProductName.Weight = 0.42040185471406494R
            ' 
            ' clProductID
            ' 
            Me.clProductID.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductID")})
            Me.clProductID.Name = "clProductID"
            Me.clProductID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clProductID.StyleName = "MainYellowStyle"
            Me.clProductID.StylePriority.UseTextAlignment = False
            Me.clProductID.Text = "clProductID"
            Me.clProductID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clProductID.Weight = 0.11591962905718702R
            ' 
            ' clQuantity
            ' 
            Me.clQuantity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Quantity")})
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clQuantity.StyleName = "MainYellowStyle"
            Me.clQuantity.StylePriority.UseTextAlignment = False
            Me.clQuantity.Text = "clQuantity"
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clQuantity.Weight = 0.10510046367851623R
            ' 
            ' clUnitPrice
            ' 
            Me.clUnitPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clUnitPrice.StyleName = "MainYellowStyle"
            Me.clUnitPrice.StylePriority.UseTextAlignment = False
            Me.clUnitPrice.Text = "clUnitPrice"
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clUnitPrice.TextFormatString = "{0:c}"
            Me.clUnitPrice.Weight = 0.10200927357032458R
            ' 
            ' clDiscount
            ' 
            Me.clDiscount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Discount")})
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clDiscount.StyleName = "MainYellowStyle"
            Me.clDiscount.StylePriority.UseTextAlignment = False
            Me.clDiscount.Text = "clDiscount"
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDiscount.TextFormatString = "{0:0%}"
            Me.clDiscount.Weight = 0.10510046367851623R
            ' 
            ' clCalculatedField
            ' 
            Me.clCalculatedField.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "calculatedField1")})
            Me.clCalculatedField.Name = "clCalculatedField"
            Me.clCalculatedField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clCalculatedField.StyleName = "MainRedStyle"
            Me.clCalculatedField.StylePriority.UseTextAlignment = False
            Me.clCalculatedField.Text = "clCalculatedField"
            Me.clCalculatedField.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clCalculatedField.TextFormatString = "{0:c}"
            Me.clCalculatedField.Weight = 0.15146831530139104R
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(408F, 0F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(245F, 16F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(4F, 43F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(647F, 22F)
            Me.xrTable2.StylePriority.UseBorders = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(4F, 5F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(412F, 33F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Order Details: [OrderID]"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrLabel1.XlsxFormatString = """Order details: ""0"
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.StyleName = "HeaderGreenStyle"
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "Product Name"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.42040185471406494R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StyleName = "HeaderYellowStyle"
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "Product ID"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell8.Weight = 0.11591962905718702R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell9.StyleName = "HeaderYellowStyle"
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Quantity"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell9.Weight = 0.10510046367851623R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.StyleName = "HeaderYellowStyle"
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Unit Price"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.10200927357032458R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell11.StyleName = "HeaderYellowStyle"
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "Discount"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell11.Weight = 0.10510046367851623R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell12.StyleName = "HeaderRedStyle"
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "Extended Price"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell12.Weight = 0.15146831530139104R
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([calculatedField1])")})
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(275F, 3F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(376F, 25F)
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrLabel3.Summary = xrSummary1
            Me.xrLabel3.Text = "xrLabel3"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel3.TextFormatString = "Total Extended Price - {0:c}"
            Me.xrLabel3.XlsxFormatString = """Total Extended Price - ""$0.00"
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(248.875F, 34.375F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' dsOrderReports1
            ' 
            Me.dsOrderReports1.ConnectionName = "NWindConnectionString"
            Me.dsOrderReports1.Name = "dsOrderReports1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderReports"
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
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "OrderReports"
            selectQuery1.Tables.Add(table1)
            Me.dsOrderReports1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsOrderReports1.ResultSchemaSerializable = resources.GetString("dsOrderReports1.ResultSchemaSerializable")
            ' 
            ' HeaderYellowStyle
            ' 
            Me.HeaderYellowStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((245)))))), (CInt(((CByte((240)))))), (CInt(((CByte((198)))))))
            Me.HeaderYellowStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((179)))))), (CInt(((CByte((179)))))), (CInt(((CByte((179)))))))
            Me.HeaderYellowStyle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.HeaderYellowStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.HeaderYellowStyle.Name = "HeaderYellowStyle"
            Me.HeaderYellowStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.HeaderYellowStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' MainYellowStyle
            ' 
            Me.MainYellowStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((253)))))), (CInt(((CByte((234)))))))
            Me.MainYellowStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((217)))))), (CInt(((CByte((217)))))))
            Me.MainYellowStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.MainYellowStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.MainYellowStyle.Name = "MainYellowStyle"
            Me.MainYellowStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.MainYellowStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' MainRedStyle
            ' 
            Me.MainRedStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((244)))))), (CInt(((CByte((236)))))))
            Me.MainRedStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((217)))))), (CInt(((CByte((217)))))))
            Me.MainRedStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.MainRedStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.MainRedStyle.Name = "MainRedStyle"
            Me.MainRedStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.MainRedStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' MainGreenStyle
            ' 
            Me.MainGreenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((255)))))), (CInt(((CByte((242)))))))
            Me.MainGreenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((217)))))), (CInt(((CByte((217)))))))
            Me.MainGreenStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.MainGreenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.MainGreenStyle.Name = "MainGreenStyle"
            Me.MainGreenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.MainGreenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' HeaderGreenStyle
            ' 
            Me.HeaderGreenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((212)))))), (CInt(((CByte((223)))))), (CInt(((CByte((201)))))))
            Me.HeaderGreenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((179)))))), (CInt(((CByte((179)))))), (CInt(((CByte((179)))))))
            Me.HeaderGreenStyle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.HeaderGreenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.HeaderGreenStyle.Name = "HeaderGreenStyle"
            Me.HeaderGreenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.HeaderGreenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' HeaderRedStyle
            ' 
            Me.HeaderRedStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((212)))))), (CInt(((CByte((194)))))))
            Me.HeaderRedStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((179)))))), (CInt(((CByte((179)))))), (CInt(((CByte((179)))))))
            Me.HeaderRedStyle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.HeaderRedStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.HeaderRedStyle.Name = "HeaderRedStyle"
            Me.HeaderRedStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.HeaderRedStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataMember = "OrderReports"
            Me.calculatedField1.DisplayName = "ExtendedPrice"
            Me.calculatedField1.Expression = "([UnitPrice] * [Quantity]) * (1 -  [Discount])"
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' ExpressionParameter
            ' 
            Me.ExpressionParameter.Description = "Expression"
            Me.ExpressionParameter.Name = "ExpressionParameter"
            Me.ExpressionParameter.ValueInfo = "([UnitPrice] * [Quantity]) * (1 -  [Discount])"
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("([UnitPrice] * [Quantity]) * (1 -  [Discount])", "Extended Price"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("([UnitPrice]) * (1 -  [Discount])", "Extended Unit Price"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("([UnitPrice] * [Quantity])", "Full Price"))
            Me.ExpressionParameter.ValueSourceSettings = staticListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.topMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calculatedField1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsOrderReports1})
            Me.DataMember = "OrderReports"
            Me.DataSource = Me.dsOrderReports1
            Me.DisplayName = "Calculated Fields"
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 96F, 100F, 75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ExpressionParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.HeaderYellowStyle, Me.MainYellowStyle, Me.MainRedStyle, Me.MainGreenStyle, Me.HeaderGreenStyle, Me.HeaderRedStyle})
            Me.Version = "25.1"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.Report_BeforePrint)
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private clProductName As DevExpress.XtraReports.UI.XRTableCell

        Private clProductID As DevExpress.XtraReports.UI.XRTableCell

        Private clQuantity As DevExpress.XtraReports.UI.XRTableCell

        Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell

        Private clDiscount As DevExpress.XtraReports.UI.XRTableCell

        Private clCalculatedField As DevExpress.XtraReports.UI.XRTableCell

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private dsOrderReports1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private HeaderYellowStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private MainYellowStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private MainRedStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private MainGreenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderGreenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderRedStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField

        Private ExpressionParameter As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
