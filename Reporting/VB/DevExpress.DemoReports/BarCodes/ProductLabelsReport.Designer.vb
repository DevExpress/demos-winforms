Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.BarCodes

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
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.BarCodes.ProductLabelsReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.dsProducts1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrBarCode1, Me.xrLabel1, Me.xrLabel4, Me.xrLine1, Me.xrLabel5})
            Me.Detail.HeightF = 270.8333F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 31.25F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 10.41667F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.CanGrow = False
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 45F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(310.0556F, 115.2917F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(254.5277F, 67.00001F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel2.TextFormatString = "{0:C2}"
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "EAN13")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 119.7917F)
            Me.xrBarCode1.[Module] = 1F
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrBarCode1.ShowText = False
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(233.3333F, 62.50001F)
            Me.xrBarCode1.StylePriority.UsePadding = False
            Me.xrBarCode1.Symbology = code128Generator1
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.CanGrow = False
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([DataSource.CurrentRowIndex] % 2 == 1, Rgb(214,63,60), [DataSource.CurrentRow" & "Index] % 3 == 1, Rgb(100,150,194), Rgb(230,138,60))")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 22F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.White
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 2, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(562.5F, 72.91666F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel4.CanGrow = False
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(280.1231F, 234.0417F)
            Me.xrLabel4.Multiline = True
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(284.4602F, 36.79167F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "One Portals Way, Twin Points WA  98156 Phone: 1-206-555-1417   Fax: 1-206-555-593" & "8"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLine1.LineWidth = 3F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 225F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(562.5F, 4.166672F)
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel5.CanGrow = False
            Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 13.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 234.0417F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(199.6667F, 36.79166F)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UsePadding = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "Northwind Traders"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
            ' ProductLabelsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsProducts1})
            Me.DataMember = "Products"
            Me.DataSource = Me.dsProducts1
            Me.DisplayName = "Product Labels"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(31, 29, 31, 10)
            Me.PageHeight = 312
            Me.PageWidth = 625
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
            Me.Version = "18.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private dsProducts1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
