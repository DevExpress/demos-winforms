Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace XtraReportsDemos.AnchorVertical

    Public Partial Class Report

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.AnchorVertical.Report))
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.dsHomes = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1})
            Me.Detail.HeightF = 310F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 67F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox2})
            Me.topMarginBand1.HeightF = 75F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrLabel11.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel11.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel11.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel11.BorderWidth = 0F
            Me.xrLabel11.CanGrow = False
            Me.xrLabel11.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel11.ForeColor = System.Drawing.Color.Black
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(325F, 151F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 5, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(93.25732F, 30F)
            Me.xrLabel11.StylePriority.UseBackColor = False
            Me.xrLabel11.StylePriority.UseFont = False
            Me.xrLabel11.StylePriority.UseForeColor = False
            Me.xrLabel11.StylePriority.UsePadding = False
            Me.xrLabel11.StylePriority.UseTextAlignment = False
            Me.xrLabel11.Text = "Year Built:"
            Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel10
            ' 
            Me.xrLabel10.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrLabel10.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel10.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel10.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel10.BorderWidth = 0F
            Me.xrLabel10.CanGrow = False
            Me.xrLabel10.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel10.ForeColor = System.Drawing.Color.Black
            Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(325.0002F, 121F)
            Me.xrLabel10.Name = "xrLabel10"
            Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 5, 0, 100F)
            Me.xrLabel10.SizeF = New System.Drawing.SizeF(93.25732F, 29.99999F)
            Me.xrLabel10.StylePriority.UseBackColor = False
            Me.xrLabel10.StylePriority.UseFont = False
            Me.xrLabel10.StylePriority.UseForeColor = False
            Me.xrLabel10.StylePriority.UsePadding = False
            Me.xrLabel10.StylePriority.UseTextAlignment = False
            Me.xrLabel10.Text = "Baths:"
            Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrLabel9.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel9.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel9.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel9.BorderWidth = 0F
            Me.xrLabel9.CanGrow = False
            Me.xrLabel9.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel9.ForeColor = System.Drawing.Color.Black
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(325.0005F, 91F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 5, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(93.25729F, 30F)
            Me.xrLabel9.StylePriority.UseBackColor = False
            Me.xrLabel9.StylePriority.UseFont = False
            Me.xrLabel9.StylePriority.UseForeColor = False
            Me.xrLabel9.StylePriority.UsePadding = False
            Me.xrLabel9.StylePriority.UseTextAlignment = False
            Me.xrLabel9.Text = "Beds:"
            Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrLabel8.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel8.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel8.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel8.BorderWidth = 0F
            Me.xrLabel8.CanGrow = False
            Me.xrLabel8.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel8.ForeColor = System.Drawing.Color.Black
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(324.9998F, 41.00002F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 25, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(93.2576F, 50F)
            Me.xrLabel8.StylePriority.UseBackColor = False
            Me.xrLabel8.StylePriority.UseFont = False
            Me.xrLabel8.StylePriority.UseForeColor = False
            Me.xrLabel8.StylePriority.UsePadding = False
            Me.xrLabel8.StylePriority.UseTextAlignment = False
            Me.xrLabel8.Text = "House Size:"
            Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel7.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel7.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel7.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel7.BorderWidth = 0F
            Me.xrLabel7.CanGrow = False
            Me.xrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "YearBuilt")})
            Me.xrLabel7.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel7.ForeColor = System.Drawing.Color.Black
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(418.2578F, 151F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 5, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(331.7423F, 29.99998F)
            Me.xrLabel7.StylePriority.UseBackColor = False
            Me.xrLabel7.StylePriority.UseFont = False
            Me.xrLabel7.StylePriority.UseForeColor = False
            Me.xrLabel7.StylePriority.UsePadding = False
            Me.xrLabel7.StylePriority.UseTextAlignment = False
            Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel6.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel6.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel6.BorderWidth = 0F
            Me.xrLabel6.CanGrow = False
            Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Baths")})
            Me.xrLabel6.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel6.ForeColor = System.Drawing.Color.Black
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(418.2577F, 121F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 5, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(331.7423F, 29.99999F)
            Me.xrLabel6.StylePriority.UseBackColor = False
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UseForeColor = False
            Me.xrLabel6.StylePriority.UsePadding = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel5.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel5.BorderWidth = 0F
            Me.xrLabel5.CanGrow = False
            Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Beds")})
            Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel5.ForeColor = System.Drawing.Color.Black
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(418.2578F, 91F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 5, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(331.7423F, 29.99999F)
            Me.xrLabel5.StylePriority.UseBackColor = False
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseForeColor = False
            Me.xrLabel5.StylePriority.UsePadding = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel4.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel4.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel4.BorderWidth = 0F
            Me.xrLabel4.CanGrow = False
            Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "HouseSize")})
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.ForeColor = System.Drawing.Color.Black
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(418.2578F, 41.00002F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 25, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(331.7423F, 50F)
            Me.xrLabel4.StylePriority.UseBackColor = False
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrLabel3.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel3.BorderWidth = 0F
            Me.xrLabel3.CanGrow = False
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")})
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Tahoma", 16F)
            Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((84)))))), (CInt(((CByte((84)))))))
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 271.0001F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(325F, 38.99994F)
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrLabel3.TextFormatString = "{0:c0}"
            Me.xrLabel3.XlsxFormatString = """Price: ""$#,##0.00"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((51)))))), (CInt(((CByte((135)))))), (CInt(((CByte((206)))))))
            Me.xrLabel2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel2.BorderWidth = 0F
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Address")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Tahoma", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel2.ForeColor = System.Drawing.Color.White
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 7.999992F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(750.0001F, 32F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrLabel1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.BorderWidth = 1F
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Features")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(325F, 181F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 5, 20, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(425F, 129F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrPictureBox1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrPictureBox1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrPictureBox1.BorderColor = System.Drawing.Color.Black
            Me.xrPictureBox1.BorderWidth = 0F
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Photo")})
            Me.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 41.00002F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 0, 25, 5, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(325F, 230F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            Me.xrPictureBox1.StylePriority.UseBackColor = False
            Me.xrPictureBox1.StylePriority.UsePadding = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Arial", 10.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(326F, 25F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.TextFormatString = "Page : {0} / {1}"
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.xrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox2.ImageSource"))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(192.1875F, 22.39584F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(365.625F, 30.20833F)
            ' 
            ' dsHomes
            ' 
            Me.dsHomes.ConnectionName = "HomesConnectionString"
            Me.dsHomes.Name = "dsHomes"
            columnExpression1.ColumnName = "Address"
            table1.Name = "Homes"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Beds"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Baths"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "HouseSize"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Price"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Features"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "YearBuilt"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Photo"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "RtfContent"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Name = "Homes"
            selectQuery1.Tables.Add(table1)
            Me.dsHomes.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsHomes.ResultSchemaSerializable = resources.GetString("dsHomes.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsHomes})
            Me.DataMember = "Homes"
            Me.DataSource = Me.dsHomes
            Me.DisplayName = "Anchoring"
            Me.Margins = New DevExpress.Drawing.DXMargins(50F, 50F, 75F, 67F)
            Me.RequestParameters = False
            Me.Version = "25.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private dsHomes As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
