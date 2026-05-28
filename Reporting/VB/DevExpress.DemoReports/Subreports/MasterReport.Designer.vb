Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.Subreports

    Partial Class MasterReport

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.Subreports.MasterReport))
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.subreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.dateRangeParameter_Start = New DevExpress.XtraReports.Parameters.RangeStartParameter()
            Me.dateRangeParameter_End = New DevExpress.XtraReports.Parameters.RangeEndParameter()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.dsCust1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.DetailText = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderText = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.dateRangeParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbDate, Me.lbTitle})
            Me.ReportHeader.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.ReportHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.ReportHeader.HeightF = 80.04163F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.StylePriority.UseFont = False
            Me.ReportHeader.StylePriority.UseForeColor = False
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbDate
            ' 
            Me.lbDate.Font = New DevExpress.Drawing.DXFont("Arial", 8F)
            Me.lbDate.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((77)))))), (CInt(((CByte((107)))))))
            Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(0F, 43.00001F)
            Me.lbDate.Name = "lbDate"
            Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbDate.SizeF = New System.Drawing.SizeF(650F, 16F)
            Me.lbDate.Text = "Order Date: [?dateRangeParameter_Start!d] to [?dateRangeParameter_End!d]"
            Me.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbTitle.BorderWidth = 2F
            Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Arial", 14.25F)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 15F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(650F, 28F)
            Me.lbTitle.StylePriority.UseBorderColor = False
            Me.lbTitle.StylePriority.UseFont = False
            Me.lbTitle.Text = "Customer List (with Order information)"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1, Me.subreport1})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.Detail.HeightF = 107.0419F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.StylePriority.UseFont = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((219)))))), (CInt(((CByte((224)))))), (CInt(((CByte((234)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3, Me.xrTable1, Me.xrTable2})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(650F, 46F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F)
            Me.xrTable3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(431.1094F, 1.999996F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow5, Me.xrTableRow6})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(173.8905F, 40F)
            Me.xrTable3.StylePriority.UseFont = False
            Me.xrTable3.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell5})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Weight = 0.4R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StyleName = "DetailText"
            Me.xrTableCell5.StylePriority.UseFont = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "Occupation"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.xrTableCell5.Weight = 1.9500944627357002R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Weight = 0.39999999999999997R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Occupation]")})
            Me.xrTableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StyleName = "DetailText"
            Me.xrTableCell6.StylePriority.UseFont = False
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "tableCell2"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell6.Weight = 1.9500944627357002R
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F)
            Me.xrTable1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(227.875F, 1.999973F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2, Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(173.8905F, 40F)
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 0.4R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StyleName = "DetailText"
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "Company"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.xrTableCell2.Weight = 1.9500944627357002R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 0.40000000000000008R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company]")})
            Me.xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StyleName = "DetailText"
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "tableCell2"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell3.Weight = 1.9500944627357002R
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F)
            Me.xrTable2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(23F, 1.999996F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.xrTableRow4})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(173.8905F, 40F)
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 0.4R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StyleName = "DetailText"
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Customer"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.xrTableCell1.Weight = 1.9500944627357002R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 0.39999999999999997R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PersonName]")})
            Me.xrTableCell4.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StyleName = "DetailText"
            Me.xrTableCell4.StylePriority.UseFont = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "tableCell2"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell4.Weight = 1.9500944627357002R
            ' 
            ' subreport1
            ' 
            Me.subreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 46F)
            Me.subreport1.Name = "subreport1"
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("customerIDParameter", Nothing, "Customers.ID"))
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("dateRangeParameter_Start", Me.dateRangeParameter_Start))
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("dateRangeParameter_End", Me.dateRangeParameter_End))
            Me.subreport1.ReportSource = New XtraReportsDemos.Subreports.DetailReport()
            Me.subreport1.SizeF = New System.Drawing.SizeF(650F, 52F)
            ' 
            ' dateRangeParameter_Start
            ' 
            Me.dateRangeParameter_Start.Name = "dateRangeParameter_Start"
            Me.dateRangeParameter_Start.ValueInfo = "2016-11-20"
            ' 
            ' dateRangeParameter_End
            ' 
            Me.dateRangeParameter_End.Name = "dateRangeParameter_End"
            Me.dateRangeParameter_End.ValueInfo = "2016-12-20"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1})
            Me.BottomMargin.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.StylePriority.UseFont = False
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((240)))))), (CInt(((CByte((240)))))), (CInt(((CByte((240)))))))
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(268.5F, 26F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(113F, 23F)
            Me.pageInfo1.StyleName = "DetailText"
            Me.pageInfo1.StylePriority.UseBackColor = False
            Me.pageInfo1.StylePriority.UseTextAlignment = False
            Me.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.pageInfo1.TextFormatString = "Page {0} of {1} Pages"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.topMarginBand1.HeightF = 65.58334F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(217.875F, 15.58335F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(212F, 50F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' dsCust1
            ' 
            Me.dsCust1.ConnectionName = "HomesConnectionString"
            Me.dsCust1.Name = "dsCust1"
            columnExpression1.ColumnName = "ID"
            table1.Name = "Customers"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Company"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Occupation"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            column4.[Alias] = "PersonName"
            customExpression1.Expression = "Concat([Customers].[FirstName], ' ', [Customers].[LastName])"
            column4.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Customers"
            selectQuery1.Tables.Add(table1)
            Me.dsCust1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsCust1.ResultSchemaSerializable = resources.GetString("dsCust1.ResultSchemaSerializable")
            ' 
            ' DetailText
            ' 
            Me.DetailText.BackColor = System.Drawing.Color.Transparent
            Me.DetailText.BorderColor = System.Drawing.Color.Black
            Me.DetailText.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailText.Font = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.DetailText.Name = "DetailText"
            Me.DetailText.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.DetailText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' HeaderText
            ' 
            Me.HeaderText.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((242)))))), (CInt(((CByte((237)))))))
            Me.HeaderText.BorderColor = System.Drawing.Color.Black
            Me.HeaderText.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.HeaderText.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderText.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((157)))))), (CInt(((CByte((134)))))))
            Me.HeaderText.Name = "HeaderText"
            Me.HeaderText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HeaderText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' dateRangeParameter
            ' 
            Me.dateRangeParameter.Description = "Date Range"
            Me.dateRangeParameter.Name = "dateRangeParameter"
            Me.dateRangeParameter.Type = GetType(System.DateTime)
            Me.dateRangeParameter.ValueSourceSettings = New DevExpress.XtraReports.Parameters.RangeParametersSettings(Me.dateRangeParameter_Start, Me.dateRangeParameter_End)
            ' 
            ' MasterReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsCust1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.dsCust1
            Me.DisplayName = "Subreport-Based Report"
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 65.58334F, 75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.dateRangeParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.DetailText, Me.HeaderText})
            Me.Version = "25.1"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.MasterReport_BeforePrint)
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Public detailReport1 As XtraReportsDemos.Subreports.DetailReport

        Private components As System.ComponentModel.IContainer

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbDate As DevExpress.XtraReports.UI.XRLabel

        Private lbTitle As DevExpress.XtraReports.UI.XRLabel

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private subreport1 As DevExpress.XtraReports.UI.XRSubreport

        Private dateRangeParameter_Start As DevExpress.XtraReports.Parameters.RangeStartParameter

        Private dateRangeParameter_End As DevExpress.XtraReports.Parameters.RangeEndParameter

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private dsCust1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private DetailText As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderText As DevExpress.XtraReports.UI.XRControlStyle

        Private dateRangeParameter As DevExpress.XtraReports.Parameters.Parameter

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
