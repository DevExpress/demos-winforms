Namespace XtraReportsDemos.IListDataSource

    Partial Class Report

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.IListDataSource.Report))
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
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table5 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.line1 = New DevExpress.XtraReports.UI.XRLine()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.LargeHeaderCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SimpleHeaderCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailTableStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DescriptionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.hidePerformance = New DevExpress.XtraReports.Parameters.Parameter()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.detailBand1.HeightF = 98.61111F
            Me.detailBand1.KeepTogether = True
            Me.detailBand1.Name = "detailBand1"
            Me.detailBand1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table2.Name = "table2"
            Me.table2.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.ResizeCellsProportionally
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table2.SizeF = New System.Drawing.SizeF(650F, 98.61111F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 0.6311111328125R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell1.Text = "tableCell1"
            Me.tableCell1.Weight = 0.6108838360126202R
            ' 
            ' table4
            ' 
            Me.table4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table4.Name = "table4"
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6, Me.tableRow8, Me.tableRow7})
            Me.table4.SizeF = New System.Drawing.SizeF(132.3582F, 98.61111F)
            Me.table4.StyleName = "DetailTableStyle"
            ' 
            ' tableRow6
            ' 
            Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17})
            Me.tableRow6.Name = "tableRow6"
            Me.tableRow6.Weight = 1.2499986267090315R
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TrademarkName]")})
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.StylePriority.UseBorders = False
            Me.tableCell17.StylePriority.UsePadding = False
            Me.tableCell17.Text = "Trademark"
            Me.tableCell17.Weight = 1.6989348239966124R
            ' 
            ' tableRow8
            ' 
            Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4})
            Me.tableRow8.Name = "tableRow8"
            Me.tableRow8.Weight = 1.2429588664152294R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")})
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell4.StyleName = "DetailTableStyle"
            Me.tableCell4.Text = "tableCell4"
            Me.tableCell4.Weight = 1.6989348239966124R
            ' 
            ' tableRow7
            ' 
            Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell25})
            Me.tableRow7.Name = "tableRow7"
            Me.tableRow7.Weight = 2.507042700297017R
            ' 
            ' tableCell25
            ' 
            Me.tableCell25.CanGrow = False
            Me.tableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Modification]")})
            Me.tableCell25.Name = "tableCell25"
            Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 2, 100F)
            Me.tableCell25.StylePriority.UsePadding = False
            Me.tableCell25.StylePriority.UseTextAlignment = False
            Me.tableCell25.Text = "Description"
            Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell25.Weight = 1.6989348239966127R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5})
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell2.Text = "tableCell2"
            Me.tableCell2.Weight = 1.2217676250751202R
            ' 
            ' table5
            ' 
            Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table5.Name = "table5"
            Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow14, Me.tableRow15, Me.tableRow16, Me.tableRow17})
            Me.table5.SizeF = New System.Drawing.SizeF(264.7163F, 98.61111F)
            Me.table5.StyleName = "DetailTableStyle"
            ' 
            ' tableRow14
            ' 
            Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell26, Me.tableCell28})
            Me.tableRow14.Name = "tableRow14"
            Me.tableRow14.Weight = 1R
            ' 
            ' tableCell26
            ' 
            Me.tableCell26.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Horsepower]")})
            Me.tableCell26.Name = "tableCell26"
            Me.tableCell26.StylePriority.UseBorders = False
            Me.tableCell26.StylePriority.UsePadding = False
            Me.tableCell26.Text = "Horsepower"
            Me.tableCell26.Weight = 1.1088662716824693R
            ' 
            ' tableCell28
            ' 
            Me.tableCell28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Torque]")})
            Me.tableCell28.Name = "tableCell28"
            Me.tableCell28.StylePriority.UseBorders = False
            Me.tableCell28.StylePriority.UsePadding = False
            Me.tableCell28.Text = "Torque"
            Me.tableCell28.Weight = 1.108865563162565R
            ' 
            ' tableRow15
            ' 
            Me.tableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell40, Me.tableCell45})
            Me.tableRow15.Name = "tableRow15"
            Me.tableRow15.Weight = 1R
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MPGCity]")})
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.StylePriority.UsePadding = False
            Me.tableCell40.Text = "MPG @ City"
            Me.tableCell40.Weight = 1.1088662716824698R
            ' 
            ' tableCell45
            ' 
            Me.tableCell45.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MPGHighway]")})
            Me.tableCell45.Name = "tableCell45"
            Me.tableCell45.StylePriority.UsePadding = False
            Me.tableCell45.Text = "MGP @ Highway"
            Me.tableCell45.Weight = 1.1088655631625648R
            ' 
            ' tableRow16
            ' 
            Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell47, Me.tableCell48})
            Me.tableRow16.Name = "tableRow16"
            Me.tableRow16.Weight = 1R
            ' 
            ' tableCell47
            ' 
            Me.tableCell47.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Doors]")})
            Me.tableCell47.Name = "tableCell47"
            Me.tableCell47.StylePriority.UsePadding = False
            Me.tableCell47.Text = "Doors"
            Me.tableCell47.Weight = 1.1088662716824698R
            ' 
            ' tableCell48
            ' 
            Me.tableCell48.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cylinders]")})
            Me.tableCell48.Name = "tableCell48"
            Me.tableCell48.StylePriority.UsePadding = False
            Me.tableCell48.Text = "Cylinders"
            Me.tableCell48.Weight = 1.1088655631625648R
            ' 
            ' tableRow17
            ' 
            Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell50, Me.tableCell51})
            Me.tableRow17.Name = "tableRow17"
            Me.tableRow17.Weight = 1R
            ' 
            ' tableCell50
            ' 
            Me.tableCell50.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TransmissionType]")})
            Me.tableCell50.Name = "tableCell50"
            Me.tableCell50.StylePriority.UsePadding = False
            Me.tableCell50.Text = "Transmission Type"
            Me.tableCell50.Weight = 1.1088662716824698R
            ' 
            ' tableCell51
            ' 
            Me.tableCell51.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TransmissionSpeeds]")})
            Me.tableCell51.Name = "tableCell51"
            Me.tableCell51.StylePriority.UsePadding = False
            Me.tableCell51.Text = "Transmission Speeds"
            Me.tableCell51.Weight = 1.1088655631625648R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox2})
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell3.Text = "tableCell3"
            Me.tableCell3.Weight = 1.1673485389122595R
            ' 
            ' pictureBox2
            ' 
            Me.pictureBox2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pictureBox2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pictureBox2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.pictureBox2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Photo]")})
            Me.pictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.pictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.SizeF = New System.Drawing.SizeF(252.9255F, 98.61111F)
            Me.pictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            Me.pictureBox2.StyleName = "DetailTableStyle"
            Me.pictureBox2.StylePriority.UseBorders = False
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.line1, Me.label1})
            Me.SubBand1.HeightF = 153.8F
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' line1
            ' 
            Me.line1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((229)))))), (CInt(((CByte((229)))))))
            Me.line1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 150F)
            Me.line1.Name = "line1"
            Me.line1.SizeF = New System.Drawing.SizeF(650F, 2F)
            Me.line1.StylePriority.UseForeColor = False
            ' 
            ' label1
            ' 
            Me.label1.CanShrink = True
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 10, 10, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(650F, 150F)
            Me.label1.StyleName = "DescriptionStyle"
            Me.label1.StylePriority.UsePadding = False
            Me.label1.Text = resources.GetString("label1.Text")
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(275F, 13F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table1.Name = "table1"
            Me.table1.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.ResizeCellsProportionally
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.tableRow3, Me.tableRow4, Me.tableRow5})
            Me.table1.SizeF = New System.Drawing.SizeF(650F, 100F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16, Me.tableCell18, Me.tableCell5, Me.tableCell6})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 1R
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.Multiline = True
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell16.StylePriority.UsePadding = False
            Me.tableCell16.Text = "TRADEMARK" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.tableCell16.Weight = 0.79754283441045715R
            ' 
            ' tableCell18
            ' 
            Me.tableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell18.Name = "tableCell18"
            Me.tableCell18.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell18.StylePriority.UsePadding = False
            Me.tableCell18.Text = "HORSEPOWER"
            Me.tableCell18.Weight = 0.79754283441045715R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell5.StylePriority.UsePadding = False
            Me.tableCell5.Text = "TORQUE"
            Me.tableCell5.Weight = 0.79754283441045715R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.BorderColor = System.Drawing.Color.White
            Me.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableCell6.BorderWidth = 0.8F
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell6.RowSpan = 4
            Me.tableCell6.StyleName = "LargeHeaderCellStyle"
            Me.tableCell6.StylePriority.UseBorderColor = False
            Me.tableCell6.StylePriority.UseBorders = False
            Me.tableCell6.StylePriority.UseBorderWidth = False
            Me.tableCell6.StylePriority.UsePadding = False
            Me.tableCell6.Text = "PHOTO"
            Me.tableCell6.Weight = 1.5240381556102753R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell19, Me.tableCell8, Me.tableCell9})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 1R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell7.StylePriority.UsePadding = False
            Me.tableCell7.Text = "MODEL NAME"
            Me.tableCell7.Weight = 0.79754283441045726R
            ' 
            ' tableCell19
            ' 
            Me.tableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell19.Multiline = True
            Me.tableCell19.Name = "tableCell19"
            Me.tableCell19.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell19.StylePriority.UsePadding = False
            Me.tableCell19.Text = "MPG @ CITY" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.tableCell19.Weight = 0.79754283441045726R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.Text = "MPG @ HIGHWAY"
            Me.tableCell8.Weight = 0.79754283441045726R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.Text = "tableCell9"
            Me.tableCell9.Weight = 1.5240381556102753R
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10, Me.tableCell20, Me.tableCell11, Me.tableCell12})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 1R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell10.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell10.StylePriority.UseBorders = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Weight = 0.79754283441045726R
            ' 
            ' tableCell20
            ' 
            Me.tableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell20.Name = "tableCell20"
            Me.tableCell20.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell20.StylePriority.UsePadding = False
            Me.tableCell20.Text = "DOORS"
            Me.tableCell20.Weight = 0.79754283441045726R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell11.StylePriority.UsePadding = False
            Me.tableCell11.Text = "CYLINDERS"
            Me.tableCell11.Weight = 0.79754283441045726R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.Text = "tableCell12"
            Me.tableCell12.Weight = 1.5240381556102753R
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell21, Me.tableCell14, Me.tableCell15})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell13.StylePriority.UseBorders = False
            Me.tableCell13.StylePriority.UsePadding = False
            Me.tableCell13.Text = "MODIFICATION"
            Me.tableCell13.Weight = 0.79754283441045726R
            ' 
            ' tableCell21
            ' 
            Me.tableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell21.Multiline = True
            Me.tableCell21.Name = "tableCell21"
            Me.tableCell21.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell21.StylePriority.UsePadding = False
            Me.tableCell21.Text = "TRANSMISSION TYPE" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.tableCell21.Weight = 0.79754283441045726R
            ' 
            ' tableCell14
            ' 
            Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?hidePerformance")})
            Me.tableCell14.Name = "tableCell14"
            Me.tableCell14.StyleName = "SimpleHeaderCellStyle"
            Me.tableCell14.StylePriority.UsePadding = False
            Me.tableCell14.Text = "TRANSMISSION SPEEDS"
            Me.tableCell14.Weight = 0.79754283441045726R
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell15.StylePriority.UsePadding = False
            Me.tableCell15.Text = "tableCell15"
            Me.tableCell15.Weight = 1.5240381556102753R
            ' 
            ' LargeHeaderCellStyle
            ' 
            Me.LargeHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.LargeHeaderCellStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 7F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.LargeHeaderCellStyle.ForeColor = System.Drawing.Color.White
            Me.LargeHeaderCellStyle.Name = "LargeHeaderCellStyle"
            Me.LargeHeaderCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.LargeHeaderCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' SimpleHeaderCellStyle
            ' 
            Me.SimpleHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.SimpleHeaderCellStyle.BorderColor = System.Drawing.Color.White
            Me.SimpleHeaderCellStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.SimpleHeaderCellStyle.BorderWidth = 0.8F
            Me.SimpleHeaderCellStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 7F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.SimpleHeaderCellStyle.ForeColor = System.Drawing.Color.White
            Me.SimpleHeaderCellStyle.Name = "SimpleHeaderCellStyle"
            Me.SimpleHeaderCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.SimpleHeaderCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailTableStyle
            ' 
            Me.DetailTableStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((229)))))), (CInt(((CByte((229)))))))
            Me.DetailTableStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.DetailTableStyle.BorderWidth = 0.8F
            Me.DetailTableStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
            Me.DetailTableStyle.ForeColor = System.Drawing.Color.Black
            Me.DetailTableStyle.Name = "DetailTableStyle"
            Me.DetailTableStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
            Me.DetailTableStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DescriptionStyle
            ' 
            Me.DescriptionStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F)
            Me.DescriptionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.DescriptionStyle.Name = "DescriptionStyle"
            Me.DescriptionStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.DescriptionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' hidePerformance
            ' 
            Me.hidePerformance.Description = "Hide Specifications"
            Me.hidePerformance.Name = "hidePerformance"
            Me.hidePerformance.Type = GetType(Boolean)
            Me.hidePerformance.ValueInfo = "False"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "VehiclesDBConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ID"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""463"" />"
            table3.Name = "Model"
            columnExpression1.Table = table3
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Name"
            columnExpression2.Table = table3
            column2.Expression = columnExpression2
            column3.[Alias] = "Trademark"
            columnExpression3.ColumnName = "TrademarkID"
            columnExpression3.Table = table3
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Modification"
            columnExpression4.Table = table3
            column4.Expression = columnExpression4
            column5.[Alias] = "MPGCity"
            columnExpression5.ColumnName = "MPG City"
            columnExpression5.Table = table3
            column5.Expression = columnExpression5
            column6.[Alias] = "MPGHighway"
            columnExpression6.ColumnName = "MPG Highway"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Doors"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Cylinders"
            columnExpression8.Table = table3
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Horsepower"
            columnExpression9.Table = table3
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Torque"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
            column11.[Alias] = "TransmissionSpeeds"
            columnExpression11.ColumnName = "Transmission Speeds"
            columnExpression11.Table = table3
            column11.Expression = columnExpression11
            column12.[Alias] = "TransmissionType"
            columnExpression12.ColumnName = "Transmission Type"
            columnExpression12.Table = table3
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Description"
            columnExpression13.Table = table3
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Photo"
            columnExpression14.Table = table3
            column14.Expression = columnExpression14
            column15.[Alias] = "TrademarkName"
            customExpression1.Expression = "[Trademark.Name]"
            column15.Expression = customExpression1
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
            selectQuery1.Name = "Model"
            relationColumnInfo1.NestedKeyColumn = "ID"
            relationColumnInfo1.ParentKeyColumn = "TrademarkID"
            join1.KeyColumns.Add(relationColumnInfo1)
            table6.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""163"" />"
            table6.Name = "Trademark"
            join1.Nested = table6
            join1.Parent = table3
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table6)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.PageHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Model"
            Me.DataSource = Me.sqlDataSource1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.hidePerformance})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.LargeHeaderCellStyle, Me.SimpleHeaderCellStyle, Me.DetailTableStyle, Me.DescriptionStyle})
            Me.Version = "21.2"
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private detailBand1 As DevExpress.XtraReports.UI.DetailBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private tableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private table5 As DevExpress.XtraReports.UI.XRTable

        Private tableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private line1 As DevExpress.XtraReports.UI.XRLine

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private LargeHeaderCellStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private SimpleHeaderCellStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailTableStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private DescriptionStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private hidePerformance As DevExpress.XtraReports.Parameters.Parameter

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
