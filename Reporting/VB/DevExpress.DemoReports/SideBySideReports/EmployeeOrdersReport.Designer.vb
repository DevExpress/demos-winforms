Namespace XtraReportsDemos.SideBySideReports

    Partial Class EmployeeOrdersReport

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
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim customExpression2 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.SideBySideReports.EmployeeOrdersReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.paramEmployeeID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.dsEmployees1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.xrTable3})
            Me.Detail.HeightF = 167F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((216)))))), (CInt(((CByte((216)))))), (CInt(((CByte((197)))))))
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Photo")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(4.000007F, 6.67572E-06F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 7, 7, 7, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.UseImageResolution = False
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(1.001358E-05F, 39.00001F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3, Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow8, Me.xrTableRow6})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(317F, 114F)
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.21929824561403508R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTableCell7.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell7.BorderWidth = 1F
            Me.xrTableCell7.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 6, 5, 4, 100F)
            Me.xrTableCell7.Text = "Full Name:"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell7.Weight = 0.26182965299684541R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((240)))))))
            Me.xrTableCell8.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell8.BorderWidth = 1F
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FullName")})
            Me.xrTableCell8.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.73817034700315454R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.21929824561403508R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTableCell9.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell9.BorderWidth = 1F
            Me.xrTableCell9.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 6, 5, 4, 100F)
            Me.xrTableCell9.Text = "Birth Date:"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell9.Weight = 0.26182965299684541R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((240)))))))
            Me.xrTableCell10.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell10.BorderWidth = 1F
            Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "BirthDate")})
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell10.TextFormatString = "{0:dd MMMM yyyy}"
            Me.xrTableCell10.Weight = 0.73817034700315454R
            Me.xrTableCell10.XlsxFormatString = "dd mmmm yyyy"
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell12})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 0.21929824561403508R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTableCell11.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell11.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell11.BorderWidth = 1F
            Me.xrTableCell11.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 6, 5, 4, 100F)
            Me.xrTableCell11.Text = "Hire Date:"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell11.Weight = 0.26182965299684541R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((240)))))))
            Me.xrTableCell12.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell12.BorderWidth = 1F
            Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "HireDate")})
            Me.xrTableCell12.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell12.TextFormatString = "{0:dd MMMM yyyy}"
            Me.xrTableCell12.Weight = 0.73817034700315454R
            Me.xrTableCell12.XlsxFormatString = "dd mmmm yyyy"
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell18, Me.xrTableCell19})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow8.Weight = 0.12280701754385964R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell18.Weight = 0.26182965299684541R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell19.Weight = 0.73817034700315454R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell13, Me.xrTableCell14})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow6.Weight = 0.21929824561403508R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTableCell13.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell13.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell13.BorderWidth = 1F
            Me.xrTableCell13.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 6, 5, 4, 100F)
            Me.xrTableCell13.Text = "Total Gain:"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell13.Weight = 0.26182965299684541R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((240)))))))
            Me.xrTableCell14.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTableCell14.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell14.BorderWidth = 1F
            Me.xrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Employees_EmployeeOrders.ExtendedPrice)")})
            Me.xrTableCell14.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell14.Summary = xrSummary1
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell14.Weight = 0.73817034700315454R
            Me.xrTableCell14.TextFormatString = "{0:C}"
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((240)))))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((207)))))), (CInt(((CByte((189)))))))
            Me.EvenStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((225)))))), (CInt(((CByte((232)))))), (CInt(((CByte((220)))))))
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((207)))))), (CInt(((CByte((189)))))))
            Me.OddStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' paramEmployeeID
            ' 
            Me.paramEmployeeID.Name = "paramEmployeeID"
            Me.paramEmployeeID.Type = GetType(Long)
            Me.paramEmployeeID.ValueInfo = "0"
            Me.paramEmployeeID.Visible = False
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.GroupFooter1})
            Me.DetailReport.DataMember = "Employees.Employees_EmployeeOrders"
            Me.DetailReport.DataSource = Me.dsEmployees1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            Me.DetailReport.ReportPrintOptions.DetailCount = 50
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail1.HeightF = 25F
            Me.Detail1.Name = "Detail1"
            Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ExtendedPrice", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.EvenStyleName = "EvenStyle"
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.OddStyleName = "OddStyle"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(317F, 25F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "OrderID")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 1, 1, 100F)
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 0.17981072555205047R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CompanyName")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 1, 100F)
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell2.Weight = 0.60883280757097791R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ExtendedPrice")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 5, 1, 1, 100F)
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.TextFormatString = "{0:C}"
            Me.xrTableCell3.Weight = 0.2113564668769716R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.GroupHeader1.HeightF = 25F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTable2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(317F, 25F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell4.Text = "Order ID"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.17981072555205047R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell5.Text = "Company Name"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell5.Weight = 0.60883280757097791R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell6.Text = "Extended Price"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell6.Weight = 0.2113564668769716R
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable4})
            Me.GroupFooter1.HeightF = 25F
            Me.GroupFooter1.KeepTogether = True
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.RepeatEveryPage = True
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((214)))))), (CInt(((CByte((211)))))))
            Me.xrTable4.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((189)))))), (CInt(((CByte((177)))))), (CInt(((CByte((183)))))))
            Me.xrTable4.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow7})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(317F, 25F)
            Me.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell15, Me.xrTableCell16, Me.xrTableCell17})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow7.Weight = 1R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell15.Text = "Order ID"
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell15.Weight = 0.17981072555205047R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell16.Text = "Company Name"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell16.Weight = 0.60883280757097791R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell17.Text = "Extended Price"
            Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell17.Weight = 0.2113564668769716R
            ' 
            ' dsEmployees1
            ' 
            Me.dsEmployees1.ConnectionName = "NWindConnectionString"
            Me.dsEmployees1.Name = "dsEmployees1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "Orders"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "EmployeeID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "CompanyName"
            table2.Name = "Customers"
            columnExpression3.Table = table2
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "ContactName"
            columnExpression4.Table = table2
            column4.Expression = columnExpression4
            column5.[Alias] = "ExtendedPrice"
            customExpression1.Expression = "([OrderDetails].[UnitPrice] * [OrderDetails].[Quantity]) * (1 - [OrderDetails].[D" & "iscount])"
            column5.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Name = "EmployeeOrders"
            relationColumnInfo1.NestedKeyColumn = "OrderID"
            relationColumnInfo1.ParentKeyColumn = "OrderID"
            join1.KeyColumns.Add(relationColumnInfo1)
            table3.Name = "OrderDetails"
            join1.Nested = table3
            join1.Parent = table1
            relationColumnInfo2.NestedKeyColumn = "CustomerID"
            relationColumnInfo2.ParentKeyColumn = "CustomerID"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table2
            join2.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table2)
            columnExpression5.ColumnName = "EmployeeID"
            table4.Name = "Employees"
            columnExpression5.Table = table4
            column6.Expression = columnExpression5
            columnExpression6.ColumnName = "BirthDate"
            columnExpression6.Table = table4
            column7.Expression = columnExpression6
            columnExpression7.ColumnName = "HireDate"
            columnExpression7.Table = table4
            column8.Expression = columnExpression7
            columnExpression8.ColumnName = "Photo"
            columnExpression8.Table = table4
            column9.Expression = columnExpression8
            column10.[Alias] = "FullName"
            customExpression2.Expression = "Concat([Employees].[FirstName], ' ', [Employees].[LastName])"
            column10.Expression = customExpression2
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Name = "Employees"
            selectQuery2.Tables.Add(table4)
            Me.dsEmployees1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "EmployeeOrders"
            relationColumnInfo3.NestedKeyColumn = "EmployeeID"
            relationColumnInfo3.ParentKeyColumn = "EmployeeID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Employees"
            masterDetailInfo1.Name = "Employees_EmployeeOrders"
            Me.dsEmployees1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.dsEmployees1.ResultSchemaSerializable = resources.GetString("dsEmployees1.ResultSchemaSerializable")
            ' 
            ' EmployeeOrdersReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1, Me.DetailReport})
            Me.DataMember = "Employees"
            Me.DataSource = Me.dsEmployees1
            Me.FilterString = "[EmployeeID] = ?paramEmployeeID"
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 432, 100, 100)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramEmployeeID})
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EvenStyle, Me.OddStyle})
            Me.Version = "17.2"
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private paramEmployeeID As DevExpress.XtraReports.Parameters.Parameter

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private dsEmployees1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
