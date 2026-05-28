Imports System
Imports System.Collections.Generic
Imports System.Text
Imports XtraReportsDemos.CrossBandControls

Namespace XtraReportsDemos.CrossBandControls

    Public Partial Class Report

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private lbCategory As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private lbUnitPrice As DevExpress.XtraReports.UI.XRLabel

        Private lbQuantity As DevExpress.XtraReports.UI.XRLabel

        Private lbProduct As DevExpress.XtraReports.UI.XRLabel

        Public GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox

        Private xrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine

        Private lbItemsCount As DevExpress.XtraReports.UI.XRLabel

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.CrossBandControls.Report))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.lbUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbQuantity = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbProduct = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCategory = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbItemsCount = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
            Me.xrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.DrawZBelowTheTableParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.dsOddEvenStyles1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbUnitPrice, Me.lbQuantity, Me.lbProduct})
            Me.Detail.HeightF = 27.00001F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbUnitPrice
            ' 
            Me.lbUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbUnitPrice.EvenStyleName = "EvenStyle"
            Me.lbUnitPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.lbUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(528.0416F, 0F)
            Me.lbUnitPrice.Name = "lbUnitPrice"
            Me.lbUnitPrice.OddStyleName = "OddStyle"
            Me.lbUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F)
            Me.lbUnitPrice.SizeF = New System.Drawing.SizeF(101.9167F, 27.00001F)
            Me.lbUnitPrice.Text = "lbUnitPrice"
            Me.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.lbUnitPrice.TextFormatString = "{0:$0.00}"
            ' 
            ' lbQuantity
            ' 
            Me.lbQuantity.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbQuantity.EvenStyleName = "EvenStyle"
            Me.lbQuantity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "QuantityPerUnit")})
            Me.lbQuantity.LocationFloat = New DevExpress.Utils.PointFloat(231F, 0F)
            Me.lbQuantity.Name = "lbQuantity"
            Me.lbQuantity.OddStyleName = "OddStyle"
            Me.lbQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.lbQuantity.SizeF = New System.Drawing.SizeF(296F, 27F)
            Me.lbQuantity.Text = "lbQuantity"
            Me.lbQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbProduct
            ' 
            Me.lbProduct.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbProduct.EvenStyleName = "EvenStyle"
            Me.lbProduct.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")})
            Me.lbProduct.LocationFloat = New DevExpress.Utils.PointFloat(20.04166F, 0F)
            Me.lbProduct.Name = "lbProduct"
            Me.lbProduct.OddStyleName = "OddStyle"
            Me.lbProduct.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.lbProduct.SizeF = New System.Drawing.SizeF(209.9583F, 27.00001F)
            Me.lbProduct.Text = "lbProduct"
            Me.lbProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCategory
            ' 
            Me.lbCategory.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((201)))))), (CInt(((CByte((214)))))), (CInt(((CByte((237)))))))
            Me.lbCategory.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.lbCategory.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCategory.BorderWidth = 1F
            Me.lbCategory.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName")})
            Me.lbCategory.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbCategory.LocationFloat = New DevExpress.Utils.PointFloat(20.04166F, 7.041677F)
            Me.lbCategory.Name = "lbCategory"
            Me.lbCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCategory.SizeF = New System.Drawing.SizeF(609.9165F, 32.95833F)
            Me.lbCategory.Text = "lbCategory"
            Me.lbCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbCategory})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 40.00001F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader1.RepeatEveryPage = True
            Me.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((227)))))), (CInt(((CByte((214)))))))
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Tahoma", 21.75F)
            Me.xrLabel2.ForeColor = System.Drawing.Color.Black
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(19F, 2F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(612F, 64F)
            Me.xrLabel2.Text = "Product List by Category"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 77F
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
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
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
            Me.xrPageInfo1.TextFormatString = "Page : {0 } / {1}"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel1, Me.lbItemsCount})
            Me.GroupFooter1.HeightF = 47F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(528.0416F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(101.9168F, 45.89999F)
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseBorderColor = False
            Me.xrLabel3.StylePriority.UseBorders = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(231F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(296F, 45.89999F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorders = False
            ' 
            ' lbItemsCount
            ' 
            Me.lbItemsCount.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.lbItemsCount.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.lbItemsCount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount(ProductName)")})
            Me.lbItemsCount.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbItemsCount.LocationFloat = New DevExpress.Utils.PointFloat(20.04166F, 0F)
            Me.lbItemsCount.Name = "lbItemsCount"
            Me.lbItemsCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.lbItemsCount.SizeF = New System.Drawing.SizeF(209.9583F, 45.95833F)
            Me.lbItemsCount.StylePriority.UseBorderColor = False
            Me.lbItemsCount.StylePriority.UseBorders = False
            Me.lbItemsCount.StylePriority.UseFont = False
            Me.lbItemsCount.StylePriority.UsePadding = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.lbItemsCount.Summary = xrSummary1
            Me.lbItemsCount.Text = "lbItemsCount"
            Me.lbItemsCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbItemsCount.TextFormatString = "Items count: {0}"
            Me.lbItemsCount.XlsxFormatString = """Items count: ""0"
            ' 
            ' xrCrossBandBox1
            ' 
            Me.xrCrossBandBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.xrCrossBandBox1.BorderWidth = 1F
            Me.xrCrossBandBox1.EndBand = Me.GroupFooter1
            Me.xrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(19F, 47F)
            Me.xrCrossBandBox1.Name = "xrCrossBandBox1"
            Me.xrCrossBandBox1.StartBand = Me.GroupHeader1
            Me.xrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(19F, 6F)
            Me.xrCrossBandBox1.WidthF = 612F
            ' 
            ' xrCrossBandLine1
            ' 
            Me.xrCrossBandLine1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandLine1.EndBand = Me.GroupFooter1
            Me.xrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(527F, 45.9F)
            Me.xrCrossBandLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.xrCrossBandLine1.Name = "xrCrossBandLine1"
            Me.xrCrossBandLine1.StartBand = Me.Detail
            Me.xrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(527F, 0F)
            Me.xrCrossBandLine1.WidthF = 1F
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.Transparent
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.EvenStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((239)))))), (CInt(((CByte((243)))))), (CInt(((CByte((250)))))))
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.OddStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' xrCrossBandLine2
            ' 
            Me.xrCrossBandLine2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandLine2.EndBand = Me.GroupFooter1
            Me.xrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(230F, 45.9F)
            Me.xrCrossBandLine2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((175)))))), (CInt(((CByte((190)))))), (CInt(((CByte((216)))))))
            Me.xrCrossBandLine2.Name = "xrCrossBandLine2"
            Me.xrCrossBandLine2.StartBand = Me.Detail
            Me.xrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(230F, 0F)
            Me.xrCrossBandLine2.WidthF = 1F
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' DrawZBelowTheTableParameter
            ' 
            Me.DrawZBelowTheTableParameter.Description = "Draw Z below the table"
            Me.DrawZBelowTheTableParameter.Name = "DrawZBelowTheTableParameter"
            Me.DrawZBelowTheTableParameter.Type = GetType(Boolean)
            Me.DrawZBelowTheTableParameter.ValueInfo = "False"
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
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.BottomMargin, Me.GroupFooter1, Me.topMarginBand1})
            Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.xrCrossBandBox1, Me.xrCrossBandLine1, Me.xrCrossBandLine2})
            Me.DataMember = "Products"
            Me.DataSource = Me.dsOddEvenStyles1
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 100, 77)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.DrawZBelowTheTableParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 15
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EvenStyle, Me.OddStyle})
            Me.Version = "21.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private DrawZBelowTheTableParameter As DevExpress.XtraReports.Parameters.Parameter

        Private dsOddEvenStyles1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
