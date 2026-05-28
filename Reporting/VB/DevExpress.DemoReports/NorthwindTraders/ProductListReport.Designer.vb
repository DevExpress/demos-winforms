Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.NorthwindTraders

    Partial Class ProductListReport

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.NorthwindTraders.ProductListReport))
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.General = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FirstLetter = New DevExpress.XtraReports.UI.CalculatedField()
            Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1, Me.xrPageInfo2, Me.lbTitle})
            Me.ReportHeader.HeightF = 138.1917F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"))
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(583.317F, 0F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(116.683F, 76.20612F)
            Me.pictureBox1.StylePriority.UsePadding = False
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 60.20612F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(96F, 16F)
            Me.xrPageInfo2.StyleName = "General"
            Me.xrPageInfo2.StylePriority.UsePadding = False
            Me.xrPageInfo2.StylePriority.UseTextAlignment = False
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrPageInfo2.TextFormatString = "{0:d}"
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BorderColor = System.Drawing.Color.Transparent
            Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Arial", 21F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 18.10892F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(414.625F, 33.41667F)
            Me.lbTitle.StylePriority.UseBorderColor = False
            Me.lbTitle.StylePriority.UseFont = False
            Me.lbTitle.StylePriority.UseForeColor = False
            Me.lbTitle.StylePriority.UsePadding = False
            Me.lbTitle.Text = "Alphabetical List of Products"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("FirstLetter", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader0.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader0.HeightF = 64F
            Me.GroupHeader0.Level = 1
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.PrintAcrossBands = True
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((227)))))), (CInt(((CByte((128)))))))
            Me.xrLabel1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FirstLetter]")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 21F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(60F, 62F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseBorderWidth = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' Detail
            ' 
            Me.Detail.BorderColor = System.Drawing.Color.White
            Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.Detail.HeightF = 32F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' table3
            ' 
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table3.Name = "table3"
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
            Me.table3.SizeF = New System.Drawing.SizeF(700F, 32F)
            Me.table3.StylePriority.UseBorderColor = False
            Me.table3.StylePriority.UseBorders = False
            Me.table3.StylePriority.UseFont = False
            Me.table3.StylePriority.UseForeColor = False
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 2.7878787878787881R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((227)))))), (CInt(((CByte((128)))))))
            Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[ProductName] != [][[^.FirstLetter] == [FirstLetter]].Min([ProductName])")})
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StyleName = "TableStyle"
            Me.xrTableCell1.StylePriority.UseBackColor = False
            Me.xrTableCell1.StylePriority.UseBorderColor = False
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.StylePriority.UseBorderWidth = False
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UseForeColor = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Weight = 60.187635596419R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")})
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.tableCell9.StyleName = "TableStyle"
            Me.tableCell9.StylePriority.UseBackColor = False
            Me.tableCell9.StylePriority.UseBorderColor = False
            Me.tableCell9.StylePriority.UseBorders = False
            Me.tableCell9.StylePriority.UseBorderWidth = False
            Me.tableCell9.StylePriority.UseFont = False
            Me.tableCell9.StylePriority.UseForeColor = False
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.StylePriority.UseTextAlignment = False
            Me.tableCell9.Text = "tableCell1"
            Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell9.Weight = 237.5295095638923R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName")})
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.tableCell10.StyleName = "TableStyle"
            Me.tableCell10.StylePriority.UseBackColor = False
            Me.tableCell10.StylePriority.UseBorderColor = False
            Me.tableCell10.StylePriority.UseBorders = False
            Me.tableCell10.StylePriority.UseBorderWidth = False
            Me.tableCell10.StylePriority.UseFont = False
            Me.tableCell10.StylePriority.UseForeColor = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.StylePriority.UseTextAlignment = False
            Me.tableCell10.Text = "tableCell6"
            Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell10.Weight = 139.00336652834145R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "QuantityPerUnit")})
            Me.tableCell11.KeepTogether = True
            Me.tableCell11.Multiline = True
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.tableCell11.StyleName = "TableStyle"
            Me.tableCell11.StylePriority.UseBackColor = False
            Me.tableCell11.StylePriority.UseBorderColor = False
            Me.tableCell11.StylePriority.UseBorders = False
            Me.tableCell11.StylePriority.UseBorderWidth = False
            Me.tableCell11.StylePriority.UseFont = False
            Me.tableCell11.StylePriority.UseForeColor = False
            Me.tableCell11.StylePriority.UsePadding = False
            Me.tableCell11.StylePriority.UseTextAlignment = False
            Me.tableCell11.Text = "tableCell7"
            Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell11.Weight = 144.36551185167951R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitsInStock")})
            Me.tableCell12.KeepTogether = True
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F)
            Me.tableCell12.StyleName = "TableStyle"
            Me.tableCell12.StylePriority.UseBackColor = False
            Me.tableCell12.StylePriority.UseBorderColor = False
            Me.tableCell12.StylePriority.UseBorders = False
            Me.tableCell12.StylePriority.UseBorderWidth = False
            Me.tableCell12.StylePriority.UseFont = False
            Me.tableCell12.StylePriority.UseForeColor = False
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.StylePriority.UseTextAlignment = False
            Me.tableCell12.Text = "xrTableCell6"
            Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell12.Weight = 121.10315111061649R
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 88F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 85F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.table1})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 32.08F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.xrLine1.LineWidth = 2F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(700F, 2.083333F)
            Me.xrLine1.StylePriority.UseBorderColor = False
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' table1
            ' 
            Me.table1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "FirstLetter")})
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(60F, 2.083333F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(640F, 30F)
            Me.table1.StylePriority.UseBackColor = False
            Me.table1.StylePriority.UseBorderColor = False
            Me.table1.StylePriority.UseBorders = False
            Me.table1.StylePriority.UseFont = False
            Me.table1.StylePriority.UseForeColor = False
            Me.table1.StylePriority.UsePadding = False
            Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableRow1.Weight = 0.9538342864480398R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.tableCell2.StyleName = "TableHeaderStyle"
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.Text = "ProductName"
            Me.tableCell2.Weight = 0.38575415685319997R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.tableCell3.StyleName = "TableHeaderStyle"
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "Category Name"
            Me.tableCell3.Weight = 0.22574514708639359R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.tableCell4.StyleName = "TableHeaderStyle"
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "Quantity Per Unit"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell4.Weight = 0.2344534427735297R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F)
            Me.tableCell5.StyleName = "TableHeaderStyle"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.StylePriority.UsePadding = False
            Me.tableCell5.StylePriority.UseTextAlignment = False
            Me.tableCell5.Text = "Units In Stock"
            Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell5.Weight = 0.19667476938729045R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table2.Name = "Products"
            columnExpression1.Table = table2
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table2
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "QuantityPerUnit"
            columnExpression3.Table = table2
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitsInStock"
            columnExpression4.Table = table2
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "CategoryID"
            table5.Name = "Categories"
            columnExpression5.Table = table5
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table5
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table5
            join1.Parent = table2
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table2)
            selectQuery1.Tables.Add(table5)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' General
            ' 
            Me.General.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.General.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.General.Name = "General"
            ' 
            ' TableHeaderStyle
            ' 
            Me.TableHeaderStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((236)))))), (CInt(((CByte((237)))))))
            Me.TableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.TableHeaderStyle.Name = "TableHeaderStyle"
            Me.TableHeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            ' 
            ' TableStyle
            ' 
            Me.TableStyle.BackColor = System.Drawing.Color.Transparent
            Me.TableStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((236)))))), (CInt(((CByte((237)))))))
            Me.TableStyle.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.TableStyle.BorderWidth = 1F
            Me.TableStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.TableStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((66)))))), (CInt(((CByte((82)))))))
            Me.TableStyle.Name = "TableStyle"
            Me.TableStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            ' 
            ' FirstLetter
            ' 
            Me.FirstLetter.DataMember = "Products"
            Me.FirstLetter.Expression = "Substring([ProductName], 0, 1)"
            Me.FirstLetter.Name = "FirstLetter"
            ' 
            ' ReportFooter1
            ' 
            Me.ReportFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
            Me.ReportFooter1.HeightF = 2F
            Me.ReportFooter1.Name = "ReportFooter1"
            ' 
            ' table4
            ' 
            Me.table4.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table4.Name = "table4"
            Me.table4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.table4.SizeF = New System.Drawing.SizeF(700.0001F, 2F)
            Me.table4.StylePriority.UseBorders = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((227)))))), (CInt(((CByte((128)))))))
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StylePriority.UseBorderColor = False
            Me.xrTableCell2.Weight = 0.5999999618530274R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((236)))))), (CInt(((CByte((237)))))))
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseBorderColor = False
            Me.xrTableCell3.Weight = 6.4000006484985352R
            ' 
            ' ProductListReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.GroupHeader0, Me.Detail, Me.BottomMargin, Me.topMarginBand1, Me.GroupHeader1, Me.ReportFooter1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.FirstLetter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Product List"
            Me.Margins = New DevExpress.Drawing.DXMargins(75, 75, 85, 88)
            Me.ShowPreviewMarginLines = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.General, Me.TableHeaderStyle, Me.TableStyle})
            Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.Version = "21.1"
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private lbTitle As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private General As DevExpress.XtraReports.UI.XRControlStyle

        Private TableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TableStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private FirstLetter As DevExpress.XtraReports.UI.CalculatedField

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
