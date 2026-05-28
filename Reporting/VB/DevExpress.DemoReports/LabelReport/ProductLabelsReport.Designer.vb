Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.LabelReport

    Public Partial Class ProductLabelsReport
        Inherits DevExpress.XtraReports.UI.XtraReport

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.LabelReport.ProductLabelsReport))
            Dim eaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Me.dsProducts1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dsProducts1
            ' 
            Me.dsProducts1.ConnectionName = "NWindConnectionString"
            Me.dsProducts1.Name = "dsProducts1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
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
            selectQuery1.Name = "Products"
            selectQuery1.Tables.Add(table1)
            Me.dsProducts1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsProducts1.ResultSchemaSerializable = resources.GetString("dsProducts1.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.Detail.HeightF = 200F
            Me.Detail.MultiColumn.ColumnWidth = 400F
            Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
            Me.Detail.Name = "Detail"
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ReorderLevel", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
            ' 
            ' panel1
            ' 
            Me.panel1.BorderColor = System.Drawing.Color.LightGray
            Me.panel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.panel1.CanGrow = False
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLine1, Me.xrBarCode1, Me.xrLabel5, Me.xrLabel4, Me.xrLabel2})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(400F, 200F)
            Me.panel1.StylePriority.UseBorderColor = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((214)))))), (CInt(((CByte((63)))))), (CInt(((CByte((60)))))))
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.CanGrow = False
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([CategoryID] % 2 == 0, Rgb(214,63,60), [CategoryID] == 0 Or [CategoryID] % 3 " & "== 0, Rgb(100,150,194), Rgb(230,138,60))")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 16F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.White
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(15F, 15F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(370F, 55F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((36)))))), (CInt(((CByte((62)))))), (CInt(((CByte((83)))))))
            Me.xrLine1.LineWidth = 3F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(14.99998F, 142F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(370.0001F, 3.126F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.AutoModule = True
            Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EAN13]")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(15F, 82F)
            Me.xrBarCode1.[Module] = 0.3937008F
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.ShowText = False
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(165.0001F, 49.99998F)
            Me.xrBarCode1.StylePriority.UseFont = False
            Me.xrBarCode1.StylePriority.UseForeColor = False
            Me.xrBarCode1.StylePriority.UsePadding = False
            Me.xrBarCode1.Symbology = eaN13Generator1
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel5.CanGrow = False
            Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(14.99998F, 155F)
            Me.xrLabel5.Multiline = True
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(140F, 30F)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseForeColor = False
            Me.xrLabel5.StylePriority.UsePadding = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "Northwind Traders"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel4.CanGrow = False
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(180.0001F, 155F)
            Me.xrLabel4.Multiline = True
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(204.9999F, 29.99998F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "One Portals Way, Twin Points WA  98156 Phone: 1-206-555-1417   Fax: 1-206-555-593" & "8"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.CanGrow = False
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 32F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(210F, 82F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(175F, 50F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel2.TextFormatString = "{0:C2}"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 50F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' ProductLabelsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsProducts1})
            Me.DataMember = "Products"
            Me.DataSource = Me.dsProducts1
            Me.DisplayName = "Product Labels"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((36)))))), (CInt(((CByte((62)))))), (CInt(((CByte((83)))))))
            Me.Margins = New DevExpress.Drawing.DXMargins(25, 25, 50, 50)
            Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 10
            Me.SnapGridSize = 9.84252F
            Me.Version = "21.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private dsProducts1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    End Class
End Namespace
