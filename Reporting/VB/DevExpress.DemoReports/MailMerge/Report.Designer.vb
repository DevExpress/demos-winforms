Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.MailMerge

    Public Partial Class Report

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.MailMerge.Report))
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.richText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.richText4 = New DevExpress.XtraReports.UI.XRRichText()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.pictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.richText2 = New DevExpress.XtraReports.UI.XRRichText()
            Me.pictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.pictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.richText3 = New DevExpress.XtraReports.UI.XRRichText()
            Me.pictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.dsEmployees1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.AddressWithoutLineBreaks = New DevExpress.XtraReports.UI.CalculatedField()
            Me.DateTimeNow = New DevExpress.XtraReports.UI.CalculatedField()
            Me.DateTimeNowPlus = New DevExpress.XtraReports.UI.CalculatedField()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richText1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrRichText1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richText4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richText2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richText3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.Detail.HeightF = 482.3591F
            Me.Detail.HierarchyPrintOptions.Indent = 20.83333F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.topMarginBand1.HeightF = 312F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.bottomMarginBand1.HeightF = 185.4167F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(80.21F, 80F)
            Me.table1.Name = "table1"
            Me.table1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.tableRow3, Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(686.926F, 401.8591F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 3.44011334402534R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 0.80199558555344563R
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 0.8216862566823222R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.CanGrow = False
            Me.tableCell3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.richText1})
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.Weight = 2.3493453229186718R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.CanGrow = False
            Me.tableCell4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText1})
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Text = "tableCell4"
            Me.tableCell4.Weight = 4.3289421831848438R
            ' 
            ' richText1
            ' 
            Me.richText1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75F)
            Me.richText1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.richText1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.richText1.Name = "richText1"
            Me.richText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 16, 0, 0, 100F)
            Me.richText1.SerializableRtfString = resources.GetString("richText1.SerializableRtfString")
            Me.richText1.SizeF = New System.Drawing.SizeF(241.6527F, 273.0049F)
            Me.richText1.StylePriority.UseFont = False
            Me.richText1.StylePriority.UseForeColor = False
            Me.richText1.StylePriority.UsePadding = False
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.BackColor = System.Drawing.Color.Transparent
            Me.xrRichText1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.xrRichText1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.xrRichText1.KeepTogether = True
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(445.2733F, 273.0049F)
            Me.xrRichText1.StylePriority.UseFont = False
            Me.xrRichText1.StylePriority.UseForeColor = False
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Multiline = True
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.Weight = 2.3493453229186718R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1})
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.Text = "tableCell6"
            Me.tableCell6.Weight = 4.3289421831848438R
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"))
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(445.2733F, 63.64579F)
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Weight = 2.3493453229186718R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.richText4})
            Me.tableCell2.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.tableCell2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UseForeColor = False
            Me.tableCell2.Weight = 4.3289421831848438R
            ' 
            ' richText4
            ' 
            Me.richText4.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.richText4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.richText4.Name = "richText4"
            Me.richText4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.richText4.SerializableRtfString = resources.GetString("richText4.SerializableRtfString")
            Me.richText4.SizeF = New System.Drawing.SizeF(445.2733F, 65.20844F)
            Me.richText4.StylePriority.UseFont = False
            Me.richText4.StylePriority.UseForeColor = False
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((244)))))), (CInt(((CByte((244)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox3})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(850F, 312F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' pictureBox3
            ' 
            Me.pictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"))
            Me.pictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(316.7177F, 56.34468F)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.SizeF = New System.Drawing.SizeF(216.5647F, 199.8106F)
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(78.869F, 0F)
            Me.table2.Name = "table2"
            Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4, Me.tableRow5})
            Me.table2.SizeF = New System.Drawing.SizeF(688.2651F, 172.3993F)
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 0.58711817383566267R
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10, Me.tableCell8, Me.tableCell11, Me.tableCell12, Me.tableCell13})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1.4128818261643372R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.tableCell7.BorderWidth = 2F
            Me.tableCell7.Font = New DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.tableCell7.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 8, 100F)
            Me.tableCell7.StylePriority.UseBorders = False
            Me.tableCell7.StylePriority.UseBorderWidth = False
            Me.tableCell7.StylePriority.UseFont = False
            Me.tableCell7.StylePriority.UseForeColor = False
            Me.tableCell7.StylePriority.UsePadding = False
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.Text = "Contact us:"
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell7.Weight = 3.8431752877294705R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox4})
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Weight = 0.14259635080564151R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.richText2})
            Me.tableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 16, 0, 100F)
            Me.tableCell8.StylePriority.UseFont = False
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.Weight = 1.091435821473528R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox6, Me.pictureBox5})
            Me.tableCell11.Multiline = True
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.Weight = 0.17198881521666767R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.richText3})
            Me.tableCell12.Font = New DevExpress.Drawing.DXFont("Arial", 12F)
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 16, 0, 100F)
            Me.tableCell12.StylePriority.UseFont = False
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.Weight = 1.1560958709904765R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox2})
            Me.tableCell13.Multiline = True
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.Weight = 1.1560958709904765R
            ' 
            ' pictureBox4
            ' 
            Me.pictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.pictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox4.ImageSource"))
            Me.pictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(0.5790551F, 14.22786F)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.SizeF = New System.Drawing.SizeF(25F, 25F)
            ' 
            ' richText2
            ' 
            Me.richText2.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.richText2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.richText2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.richText2.Name = "richText2"
            Me.richText2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 19, 0, 100F)
            Me.richText2.SerializableRtfString = resources.GetString("richText2.SerializableRtfString")
            Me.richText2.SizeF = New System.Drawing.SizeF(202.0318F, 121.7899F)
            Me.richText2.StylePriority.UseForeColor = False
            Me.richText2.StylePriority.UsePadding = False
            ' 
            ' pictureBox6
            ' 
            Me.pictureBox6.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.pictureBox6.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox6.ImageSource"))
            Me.pictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(2.473895F, 49.39859F)
            Me.pictureBox6.Name = "pictureBox6"
            Me.pictureBox6.SizeF = New System.Drawing.SizeF(25F, 25F)
            Me.pictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            ' 
            ' pictureBox5
            ' 
            Me.pictureBox5.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.pictureBox5.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox5.ImageSource"))
            Me.pictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(2.473895F, 14.22786F)
            Me.pictureBox5.Name = "pictureBox5"
            Me.pictureBox5.SizeF = New System.Drawing.SizeF(25F, 25F)
            Me.pictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            ' 
            ' richText3
            ' 
            Me.richText3.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.richText3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((52)))))), (CInt(((CByte((73)))))))
            Me.richText3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.richText3.Name = "richText3"
            Me.richText3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 17, 0, 100F)
            Me.richText3.SerializableRtfString = resources.GetString("richText3.SerializableRtfString")
            Me.richText3.SizeF = New System.Drawing.SizeF(214.0008F, 121.7899F)
            Me.richText3.StylePriority.UseForeColor = False
            Me.richText3.StylePriority.UsePadding = False
            ' 
            ' pictureBox2
            ' 
            Me.pictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopRight
            Me.pictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox2.ImageSource"))
            Me.pictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 14, 0, 100F)
            Me.pictureBox2.SizeF = New System.Drawing.SizeF(214.0008F, 121.7899F)
            Me.pictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            Me.pictureBox2.StylePriority.UsePadding = False
            ' 
            ' dsEmployees1
            ' 
            Me.dsEmployees1.ConnectionName = "NWindConnectionString"
            Me.dsEmployees1.Name = "dsEmployees1"
            columnExpression1.ColumnName = "Address"
            table3.[Alias] = "e"
            table3.Name = "Employees"
            columnExpression1.Table = table3
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "BirthDate"
            columnExpression2.Table = table3
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "City"
            columnExpression3.Table = table3
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Country"
            columnExpression4.Table = table3
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "EmployeeID"
            columnExpression5.Table = table3
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "LastName"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "FirstName"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "HireDate"
            columnExpression8.Table = table3
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "HomePhone"
            columnExpression9.Table = table3
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Notes"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "Photo"
            columnExpression11.Table = table3
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "PostalCode"
            columnExpression12.Table = table3
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Extension"
            columnExpression13.Table = table3
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Region"
            columnExpression14.Table = table3
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ReportsTo"
            columnExpression15.Table = table3
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Title"
            columnExpression16.Table = table3
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "TitleOfCourtesy"
            columnExpression17.Table = table3
            column17.Expression = columnExpression17
            column18.[Alias] = "ReportsToInfo"
            customExpression1.Expression = "Concat([r].[FirstName], ' ', [r].[LastName])"
            column18.Expression = customExpression1
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
            selectQuery1.Name = "Employees"
            relationColumnInfo1.NestedKeyColumn = "EmployeeID"
            relationColumnInfo1.ParentKeyColumn = "ReportsTo"
            join1.KeyColumns.Add(relationColumnInfo1)
            table4.[Alias] = "r"
            table4.Name = "Employees"
            join1.Nested = table4
            join1.Parent = table3
            join1.SqlJoinType = CType((DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter), DevExpress.DataAccess.Sql.SqlJoinType)
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table4)
            Me.dsEmployees1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsEmployees1.ResultSchemaSerializable = resources.GetString("dsEmployees1.ResultSchemaSerializable")
            ' 
            ' AddressWithoutLineBreaks
            ' 
            Me.AddressWithoutLineBreaks.DataMember = "Employees"
            Me.AddressWithoutLineBreaks.Expression = "Replace([Address], Concat(Char(13), Char(10)), ' ')"
            Me.AddressWithoutLineBreaks.Name = "AddressWithoutLineBreaks"
            ' 
            ' DateTimeNow
            ' 
            Me.DateTimeNow.DataMember = "Employees"
            Me.DateTimeNow.Expression = "Now()"
            Me.DateTimeNow.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime
            Me.DateTimeNow.Name = "DateTimeNow"
            ' 
            ' DateTimeNowPlus
            ' 
            Me.DateTimeNowPlus.DataMember = "Employees"
            Me.DateTimeNowPlus.Expression = "GetYear(AddYears(Now(), 4))"
            Me.DateTimeNowPlus.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.DateTimeNowPlus.Name = "DateTimeNowPlus"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.AddressWithoutLineBreaks, Me.DateTimeNow, Me.DateTimeNowPlus})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsEmployees1})
            Me.DataMember = "Employees"
            Me.DataSource = Me.dsEmployees1
            Me.DisplayName = "Mail Merge"
            Me.Margins = New DevExpress.Drawing.DXMargins(0F, 0F, 312F, 185.4167F)
            Me.SnapGridSize = 13.02083F
            Me.Version = "25.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richText1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrRichText1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richText4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richText2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richText3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private richText1 As DevExpress.XtraReports.UI.XRRichText

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private richText4 As DevExpress.XtraReports.UI.XRRichText

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private pictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private richText2 As DevExpress.XtraReports.UI.XRRichText

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox6 As DevExpress.XtraReports.UI.XRPictureBox

        Private pictureBox5 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private richText3 As DevExpress.XtraReports.UI.XRRichText

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private dsEmployees1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private AddressWithoutLineBreaks As DevExpress.XtraReports.UI.CalculatedField

        Private DateTimeNow As DevExpress.XtraReports.UI.CalculatedField

        Private DateTimeNowPlus As DevExpress.XtraReports.UI.CalculatedField
    End Class
End Namespace
