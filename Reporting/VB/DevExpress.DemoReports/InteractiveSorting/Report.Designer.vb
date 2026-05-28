Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.InteractiveSorting

    Public Partial Class Report

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private lbCategory As DevExpress.XtraReports.UI.XRLabel

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.InteractiveSorting.Report))
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
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.lbCategory = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.dsOddEvenStyles1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.HeaderStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((239)))))), (CInt(((CByte((243)))))), (CInt(((CByte((250)))))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((209)))))), (CInt(((CByte((228)))))))
            Me.EvenStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.EvenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.EvenStyle.Name = "EvenStyle"
            Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.EvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((209)))))), (CInt(((CByte((228)))))))
            Me.OddStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.OddStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.OddStyle.Name = "OddStyle"
            Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.OddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 27F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("UnitPrice", DevExpress.XtraReports.UI.XRColumnSortOrder.None)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BookmarkParent = Me.lbCategory
            Me.xrTable1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[ProductName]")})
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(21F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(608F, 27F)
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' lbCategory
            ' 
            Me.lbCategory.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")})
            Me.lbCategory.InteractiveSorting.FieldName = "CategoryID"
            Me.lbCategory.InteractiveSorting.TargetBand = Me.GroupHeader1
            Me.lbCategory.LocationFloat = New DevExpress.Utils.PointFloat(21F, 8F)
            Me.lbCategory.Name = "lbCategory"
            Me.lbCategory.SizeF = New System.Drawing.SizeF(608F, 32F)
            Me.lbCategory.StyleName = "HeaderStyle1"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2, Me.lbCategory})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 75F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader1.RepeatEveryPage = True
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BookmarkParent = Me.lbCategory
            Me.xrTable2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[ProductName]")})
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(21F, 48F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(608F, 27F)
            Me.xrTable2.StyleName = "HeaderStyle2"
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow2.EvenStyleName = "EvenStyle"
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.OddStyleName = "OddStyle"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.InteractiveSorting.FieldName = "ProductName"
            Me.xrTableCell1.InteractiveSorting.TargetBand = Me.Detail
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.Weight = 0.34539473684210525R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "Quantity Per Unit"
            Me.xrTableCell2.Weight = 0.48848684210526316R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.InteractiveSorting.FieldName = "UnitPrice"
            Me.xrTableCell3.InteractiveSorting.TargetBand = Me.Detail
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "Unit Price"
            Me.xrTableCell3.Weight = 0.16611842105263158R
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow1.EvenStyleName = "EvenStyle"
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.OddStyleName = "OddStyle"
            Me.xrTableRow1.StyleName = "EvenStyle"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 0.34539473684210525R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 0.48848684210526316R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F)
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.TextFormatString = "{0:$0.00}"
            Me.xrTableCell6.Weight = 0.16611842105263158R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.ReportHeader.HeightF = 67F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Tahoma", 21.75F)
            Me.xrLabel2.ForeColor = System.Drawing.Color.Black
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(21F, 2F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(608F, 64F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.Text = "Product List by Category"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 85F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 27F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(534F, 7F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrPageInfo1.TextFormatString = "Page : {0} / {1}"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' dsOddEvenStyles1
            ' 
            Me.dsOddEvenStyles1.ConnectionName = "NWindConnectionString"
            Me.dsOddEvenStyles1.Name = "dsOddEvenStyles1"
            columnExpression1.ColumnName = "ProductName"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "QuantityPerUnit"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "CategoryName"
            table2.Name = "Categories"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            Me.dsOddEvenStyles1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsOddEvenStyles1.ResultSchemaSerializable = resources.GetString("dsOddEvenStyles1.ResultSchemaSerializable")
            ' 
            ' HeaderStyle2
            ' 
            Me.HeaderStyle2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((201)))))), (CInt(((CByte((214)))))), (CInt(((CByte((237)))))))
            Me.HeaderStyle2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.HeaderStyle2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.HeaderStyle2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderStyle2.Name = "HeaderStyle2"
            Me.HeaderStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.HeaderStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' HeaderStyle1
            ' 
            Me.HeaderStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((201)))))), (CInt(((CByte((214)))))), (CInt(((CByte((237)))))))
            Me.HeaderStyle1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.HeaderStyle1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.HeaderStyle1.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderStyle1.Name = "HeaderStyle1"
            Me.HeaderStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.DataMember = "Products"
            Me.DataSource = Me.dsOddEvenStyles1
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 100, 85)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 17
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EvenStyle, Me.OddStyle, Me.HeaderStyle2, Me.HeaderStyle1})
            Me.Version = "22.1"
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private dsOddEvenStyles1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private components As System.ComponentModel.IContainer

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private HeaderStyle2 As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
