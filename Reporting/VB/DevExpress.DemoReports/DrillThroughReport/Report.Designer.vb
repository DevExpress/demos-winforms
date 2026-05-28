Namespace XtraReportsDemos.DrillThroughReport

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
            Dim navigateToReportAction1 As DevExpress.XtraReports.Interactivity.NavigateToReportAction = New DevExpress.XtraReports.Interactivity.NavigateToReportAction()
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
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim selectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery4 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table10 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo2 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo3 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.DrillThroughReport.Report))
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.table6 = New DevExpress.XtraReports.UI.XRTable()
            Me.table9 = New DevExpress.XtraReports.UI.XRTable()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.Customers = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Headers = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportTitleCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableHeaders = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailReportTableHeaders = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameter1_Start = New DevExpress.XtraReports.Parameters.RangeStartParameter()
            Me.parameter1_End = New DevExpress.XtraReports.Parameters.RangeEndParameter()
            Me.Company = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 40.625F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1, Me.table6, Me.table9, Me.label1})
            Me.PageHeader.HeightF = 299.9417F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
            Me.DetailReport.DataMember = "Customers.CustomersOrders"
            Me.DetailReport.DataSource = Me.Customers
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            Me.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' table1
            ' 
            Me.table1.Font = New DevExpress.Drawing.DXFont("Arial", 11.75F)
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 112.4415F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1, Me.tableRow2, Me.tableRow9, Me.tableRow10, Me.tableRow16})
            Me.table1.SizeF = New System.Drawing.SizeF(434.5329F, 104.6715F)
            Me.table1.StylePriority.UseFont = False
            ' 
            ' table6
            ' 
            Me.table6.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((247)))))), (CInt(((CByte((250)))))))
            Me.table6.LocationFloat = New DevExpress.Utils.PointFloat(434.5329F, 112.4415F)
            Me.table6.Name = "table6"
            Me.table6.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 2, 0, 0, 100F)
            Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3, Me.tableRow11, Me.tableRow12, Me.tableRow18, Me.tableRow13, Me.tableRow14, Me.tableRow19})
            Me.table6.SizeF = New System.Drawing.SizeF(250.4688F, 124.2285F)
            Me.table6.StylePriority.UseBackColor = False
            Me.table6.StylePriority.UsePadding = False
            ' 
            ' table9
            ' 
            Me.table9.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.table9.LocationFloat = New DevExpress.Utils.PointFloat(0F, 268.9413F)
            Me.table9.Name = "table9"
            Me.table9.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.StretchPreviousCell
            Me.table9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow17})
            Me.table9.SizeF = New System.Drawing.SizeF(685F, 31F)
            Me.table9.StylePriority.UsePadding = False
            ' 
            ' label1
            ' 
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0} Order Overview', ?Company)")})
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(684.9999F, 76.24075F)
            Me.label1.StyleName = "ReportTitleCaption"
            Me.label1.StylePriority.UsePadding = False
            Me.label1.StylePriority.UseTextAlignment = False
            Me.label1.Text = "label1"
            Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 0.5R
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6})
            Me.tableRow2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.StyleName = "DetailData3"
            Me.tableRow2.StylePriority.UseForeColor = False
            Me.tableRow2.Weight = 0.5R
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell27, Me.tableCell28})
            Me.tableRow9.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow9.Name = "tableRow9"
            Me.tableRow9.StyleName = "DetailData3"
            Me.tableRow9.StylePriority.UseForeColor = False
            Me.tableRow9.Weight = 0.5R
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell29, Me.tableCell30})
            Me.tableRow10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow10.Name = "tableRow10"
            Me.tableRow10.StyleName = "DetailData3"
            Me.tableRow10.StylePriority.UseForeColor = False
            Me.tableRow10.Weight = 0.5R
            ' 
            ' tableRow16
            ' 
            Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell35, Me.tableCell38})
            Me.tableRow16.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow16.Name = "tableRow16"
            Me.tableRow16.StyleName = "DetailData3"
            Me.tableRow16.StylePriority.UseForeColor = False
            Me.tableRow16.Weight = 0.5R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
            Me.tableCell1.StyleName = "Headers"
            Me.tableCell1.StylePriority.UseBorders = False
            Me.tableCell1.StylePriority.UseFont = False
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.Text = "Contact Name:"
            Me.tableCell1.Weight = 0.112777535688382R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomersCustomerEmployees].[FullName]")})
            Me.tableCell2.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell2.StyleName = "DetailData3"
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UseForeColor = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.Text = "City"
            Me.tableCell2.Weight = 0.35767574424701465R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
            Me.tableCell5.StyleName = "Headers"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.StylePriority.UseFont = False
            Me.tableCell5.StylePriority.UsePadding = False
            Me.tableCell5.Text = "Address:"
            Me.tableCell5.Weight = 0.112777535688382R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0}, {1}, {2}, {3}', [HomeOffice_Line], [HomeOffice_City], [State]," & " [HomeOffice_ZipCode])")})
            Me.tableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell6.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell6.StyleName = "DetailData3"
            Me.tableCell6.StylePriority.UseFont = False
            Me.tableCell6.StylePriority.UseForeColor = False
            Me.tableCell6.StylePriority.UsePadding = False
            Me.tableCell6.Weight = 0.35767574424701465R
            ' 
            ' tableCell27
            ' 
            Me.tableCell27.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell27.Multiline = True
            Me.tableCell27.Name = "tableCell27"
            Me.tableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
            Me.tableCell27.StyleName = "Headers"
            Me.tableCell27.StylePriority.UseBorders = False
            Me.tableCell27.StylePriority.UseFont = False
            Me.tableCell27.StylePriority.UsePadding = False
            Me.tableCell27.Text = "Web:"
            Me.tableCell27.Weight = 0.112777535688382R
            ' 
            ' tableCell28
            ' 
            Me.tableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Replace([Website], 'nowebsite','')")})
            Me.tableCell28.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell28.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell28.Multiline = True
            Me.tableCell28.Name = "tableCell28"
            Me.tableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell28.StyleName = "DetailData3"
            Me.tableCell28.StylePriority.UseFont = False
            Me.tableCell28.StylePriority.UseForeColor = False
            Me.tableCell28.StylePriority.UsePadding = False
            Me.tableCell28.Text = "tableCell28"
            Me.tableCell28.Weight = 0.35767574424701465R
            ' 
            ' tableCell29
            ' 
            Me.tableCell29.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell29.Multiline = True
            Me.tableCell29.Name = "tableCell29"
            Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
            Me.tableCell29.StyleName = "Headers"
            Me.tableCell29.StylePriority.UseBorders = False
            Me.tableCell29.StylePriority.UseFont = False
            Me.tableCell29.StylePriority.UsePadding = False
            Me.tableCell29.Text = "Phone:"
            Me.tableCell29.Weight = 0.112777535688382R
            ' 
            ' tableCell30
            ' 
            Me.tableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            Me.tableCell30.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell30.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell30.Multiline = True
            Me.tableCell30.Name = "tableCell30"
            Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell30.StyleName = "DetailData3"
            Me.tableCell30.StylePriority.UseFont = False
            Me.tableCell30.StylePriority.UseForeColor = False
            Me.tableCell30.StylePriority.UsePadding = False
            Me.tableCell30.Text = "tableCell30"
            Me.tableCell30.Weight = 0.35767574424701465R
            ' 
            ' tableCell35
            ' 
            Me.tableCell35.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell35.Multiline = True
            Me.tableCell35.Name = "tableCell35"
            Me.tableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
            Me.tableCell35.StyleName = "Headers"
            Me.tableCell35.StylePriority.UseBorders = False
            Me.tableCell35.StylePriority.UseFont = False
            Me.tableCell35.StylePriority.UsePadding = False
            Me.tableCell35.Text = "Email:"
            Me.tableCell35.Weight = 0.112777535688382R
            ' 
            ' tableCell38
            ' 
            Me.tableCell38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Replace([CustomersCustomerEmployees].[Email], 'nowebsite','')")})
            Me.tableCell38.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell38.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell38.Multiline = True
            Me.tableCell38.Name = "tableCell38"
            Me.tableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.tableCell38.StyleName = "DetailData3"
            Me.tableCell38.StylePriority.UseFont = False
            Me.tableCell38.StylePriority.UseForeColor = False
            Me.tableCell38.StylePriority.UsePadding = False
            Me.tableCell38.Text = "tableCell38"
            Me.tableCell38.Weight = 0.35767574424701465R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 2, 10, 10, 100F)
            Me.tableRow3.StylePriority.UsePadding = False
            Me.tableRow3.Weight = 0.16666666666666666R
            ' 
            ' tableRow11
            ' 
            Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell31})
            Me.tableRow11.Name = "tableRow11"
            Me.tableRow11.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 2, 10, 10, 100F)
            Me.tableRow11.StylePriority.UsePadding = False
            Me.tableRow11.Weight = 0.16666666666666666R
            ' 
            ' tableRow12
            ' 
            Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell32})
            Me.tableRow12.Name = "tableRow12"
            Me.tableRow12.Weight = 0.16666666666666666R
            ' 
            ' tableRow18
            ' 
            Me.tableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9})
            Me.tableRow18.Name = "tableRow18"
            Me.tableRow18.Weight = 0.16666666666666666R
            ' 
            ' tableRow13
            ' 
            Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell33})
            Me.tableRow13.Name = "tableRow13"
            Me.tableRow13.Weight = 0.16666666666666666R
            ' 
            ' tableRow14
            ' 
            Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell34})
            Me.tableRow14.Name = "tableRow14"
            Me.tableRow14.Weight = 0.16666666666666666R
            ' 
            ' tableRow19
            ' 
            Me.tableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10})
            Me.tableRow19.Name = "tableRow19"
            Me.tableRow19.Weight = 0.16666666666666666R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "Headers"
            Me.tableCell3.StylePriority.UsePadding = False
            Me.tableCell3.Weight = 1R
            ' 
            ' tableCell31
            ' 
            Me.tableCell31.Multiline = True
            Me.tableCell31.Name = "tableCell31"
            Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 0, 0, 0, 100F)
            Me.tableCell31.StyleName = "Headers"
            Me.tableCell31.StylePriority.UsePadding = False
            Me.tableCell31.Text = "Date Range"
            Me.tableCell31.Weight = 1R
            ' 
            ' tableCell32
            ' 
            Me.tableCell32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0:M/d/yyyy} to {1:M/d/yyyy}', ?parameter1_Start, ?parameter1_End)")})
            Me.tableCell32.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell32.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell32.Multiline = True
            Me.tableCell32.Name = "tableCell32"
            Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 6, 0, 0, 100F)
            Me.tableCell32.StyleName = "DetailData3"
            Me.tableCell32.StylePriority.UseFont = False
            Me.tableCell32.StylePriority.UseForeColor = False
            Me.tableCell32.StylePriority.UsePadding = False
            Me.tableCell32.Text = "tableCell32"
            Me.tableCell32.Weight = 1R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 6, 0, 0, 100F)
            Me.tableCell9.StyleName = "DetailData3"
            Me.tableCell9.StylePriority.UseForeColor = False
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.Weight = 1R
            ' 
            ' tableCell33
            ' 
            Me.tableCell33.Multiline = True
            Me.tableCell33.Name = "tableCell33"
            Me.tableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 0, 0, 0, 100F)
            Me.tableCell33.StyleName = "Headers"
            Me.tableCell33.StylePriority.UsePadding = False
            Me.tableCell33.Text = "Printed On"
            Me.tableCell33.Weight = 1R
            ' 
            ' tableCell34
            ' 
            Me.tableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
            Me.tableCell34.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.tableCell34.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell34.Multiline = True
            Me.tableCell34.Name = "tableCell34"
            Me.tableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(21, 6, 0, 0, 100F)
            Me.tableCell34.StyleName = "DetailData3"
            Me.tableCell34.StylePriority.UseFont = False
            Me.tableCell34.StylePriority.UseForeColor = False
            Me.tableCell34.StylePriority.UsePadding = False
            Me.tableCell34.Text = "tableCell34"
            Me.tableCell34.TextFormatString = "{0:M/d/yyyy}"
            Me.tableCell34.Weight = 1R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "DetailData3"
            Me.tableCell10.StylePriority.UseForeColor = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Weight = 1R
            ' 
            ' tableRow17
            ' 
            Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell39, Me.tableCell40, Me.tableCell41, Me.tableCell42, Me.tableCell43, Me.tableCell7})
            Me.tableRow17.Name = "tableRow17"
            Me.tableRow17.Weight = 0.5535714285714286R
            ' 
            ' tableCell39
            ' 
            Me.tableCell39.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell39.ForeColor = System.Drawing.Color.White
            Me.tableCell39.Name = "tableCell39"
            Me.tableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell39.StyleName = "TableHeaders"
            Me.tableCell39.StylePriority.UseBackColor = False
            Me.tableCell39.StylePriority.UseBorders = False
            Me.tableCell39.StylePriority.UseForeColor = False
            Me.tableCell39.StylePriority.UsePadding = False
            Me.tableCell39.StylePriority.UseTextAlignment = False
            Me.tableCell39.Text = "Order Date"
            Me.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell39.Weight = 0.21147712664587376R
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F)
            Me.tableCell40.StyleName = "TableHeaders"
            Me.tableCell40.StylePriority.UseBackColor = False
            Me.tableCell40.StylePriority.UseForeColor = False
            Me.tableCell40.StylePriority.UsePadding = False
            Me.tableCell40.StylePriority.UseTextAlignment = False
            Me.tableCell40.Text = "Invoice #"
            Me.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell40.Weight = 0.18480433608719826R
            ' 
            ' tableCell41
            ' 
            Me.tableCell41.Name = "tableCell41"
            Me.tableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F)
            Me.tableCell41.StyleName = "TableHeaders"
            Me.tableCell41.StylePriority.UseBackColor = False
            Me.tableCell41.StylePriority.UseForeColor = False
            Me.tableCell41.StylePriority.UsePadding = False
            Me.tableCell41.StylePriority.UseTextAlignment = False
            Me.tableCell41.Text = "Ship Date"
            Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell41.Weight = 0.21719272492940925R
            ' 
            ' tableCell42
            ' 
            Me.tableCell42.Name = "tableCell42"
            Me.tableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell42.StyleName = "TableHeaders"
            Me.tableCell42.StylePriority.UseBackColor = False
            Me.tableCell42.StylePriority.UseForeColor = False
            Me.tableCell42.StylePriority.UsePadding = False
            Me.tableCell42.StylePriority.UseTextAlignment = False
            Me.tableCell42.Text = "Shipment Status"
            Me.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell42.Weight = 0.22862392096430359R
            ' 
            ' tableCell43
            ' 
            Me.tableCell43.Multiline = True
            Me.tableCell43.Name = "tableCell43"
            Me.tableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F)
            Me.tableCell43.StyleName = "TableHeaders"
            Me.tableCell43.StylePriority.UseBackColor = False
            Me.tableCell43.StylePriority.UseForeColor = False
            Me.tableCell43.StylePriority.UsePadding = False
            Me.tableCell43.StylePriority.UseTextAlignment = False
            Me.tableCell43.Text = "Order Total"
            Me.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell43.Weight = 0.21399199465079324R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "TableHeaders"
            Me.tableCell7.StylePriority.UseBorders = False
            Me.tableCell7.StylePriority.UsePadding = False
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.Text = "Order Detail"
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell7.Weight = 0.19676898330395834R
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.Detail1.HeightF = 31F
            Me.Detail1.KeepTogether = True
            Me.Detail1.KeepTogetherWithDetailReports = True
            Me.Detail1.Name = "Detail1"
            ' 
            ' table2
            ' 
            Me.table2.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.table2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((235)))))))
            Me.table2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
            Me.table2.SizeF = New System.Drawing.SizeF(684.9927F, 31F)
            Me.table2.StylePriority.UseBorderColor = False
            Me.table2.StylePriority.UseBorders = False
            Me.table2.StylePriority.UsePadding = False
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.xrTableCell1, Me.tableCell4, Me.tableCell8})
            Me.tableRow4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.StyleName = "DetailData3"
            Me.tableRow4.StylePriority.UseBorderColor = False
            Me.tableRow4.StylePriority.UseForeColor = False
            Me.tableRow4.StylePriority.UseTextAlignment = False
            Me.tableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableRow4.Weight = 0.55357142857142849R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
            Me.tableCell13.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell13.StyleName = "DetailData3"
            Me.tableCell13.StylePriority.UseBorders = False
            Me.tableCell13.StylePriority.UseForeColor = False
            Me.tableCell13.StylePriority.UsePadding = False
            Me.tableCell13.StylePriority.UseTextAlignment = False
            Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell13.TextFormatString = "{0:M/d/yyyy}"
            Me.tableCell13.Weight = 0.26686227206728974R
            ' 
            ' tableCell14
            ' 
            Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNumber]")})
            Me.tableCell14.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell14.Name = "tableCell14"
            Me.tableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F)
            Me.tableCell14.StyleName = "DetailData3"
            Me.tableCell14.StylePriority.UseFont = False
            Me.tableCell14.StylePriority.UseForeColor = False
            Me.tableCell14.StylePriority.UsePadding = False
            Me.tableCell14.StylePriority.UseTextAlignment = False
            Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell14.TextFormatString = "{0:M/d/yyyy}"
            Me.tableCell14.Weight = 0.23320396804434643R
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(!IsNull([ShipDate]), [ShipDate], 'TBD')")})
            Me.tableCell15.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F)
            Me.tableCell15.StyleName = "DetailData3"
            Me.tableCell15.StylePriority.UseFont = False
            Me.tableCell15.StylePriority.UseForeColor = False
            Me.tableCell15.StylePriority.UsePadding = False
            Me.tableCell15.StylePriority.UseTextAlignment = False
            Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell15.TextFormatString = "{0:M/d/yyyy}"
            Me.tableCell15.Weight = 0.27407476672240361R
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
            Me.tableCell16.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.StyleName = "DetailData3"
            Me.tableCell16.StylePriority.UseForeColor = False
            Me.tableCell16.StylePriority.UsePadding = False
            Me.tableCell16.StylePriority.UseTextAlignment = False
            Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell16.Weight = 0.0889541585594197R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ShipmentStatus] == 0, 'Pending', [ShipmentStatus] == 1, 'In Transit', 'Deliv" & "ered')")})
            Me.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableCell1.StyleName = "DetailData3"
            Me.xrTableCell1.StylePriority.UseBorderColor = False
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.StylePriority.UseForeColor = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.TextFormatString = "{0:M/d/yyyy}"
            Me.xrTableCell1.Weight = 0.19954581514680639R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")})
            Me.tableCell4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F)
            Me.tableCell4.StyleName = "DetailData3"
            Me.tableCell4.StylePriority.UseFont = False
            Me.tableCell4.StylePriority.UseForeColor = False
            Me.tableCell4.StylePriority.UsePadding = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "tableCell4"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell4.TextFormatString = "{0:c2}"
            Me.tableCell4.Weight = 0.27003587781417049R
            ' 
            ' tableCell8
            ' 
            navigateToReportAction1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Customer", Nothing, "Customers.Id"))
            navigateToReportAction1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("orderId", Nothing, "Customers.CustomersOrders.Id"))
            navigateToReportAction1.ReportSource = New XtraReportsDemos.DrillThroughReport.DetailReport()
            Me.tableCell8.Action = navigateToReportAction1
            Me.tableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F, DevExpress.Drawing.DXFontStyle.Underline)
            Me.tableCell8.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((11)))))), (CInt(((CByte((69)))))), (CInt(((CByte((127)))))))
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StylePriority.UseFont = False
            Me.tableCell8.StylePriority.UseForeColor = False
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.Text = "Details"
            Me.tableCell8.Weight = 0.24828565099464026R
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.BorderWidth = 0F
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Iif([ShipmentStatus] == 0, [Images.pending], [ShipmentStatus] == 1, [Images.trans" & "it], [Images.delivered])")})
            Me.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(38.54168F, 29.95833F)
            Me.xrPictureBox1.StylePriority.UseBorderWidth = False
            Me.xrPictureBox1.StylePriority.UsePadding = False
            ' 
            ' Customers
            ' 
            Me.Customers.ConnectionName = "DevAvConnectionString"
            Me.Customers.Name = "Customers"
            columnExpression1.ColumnName = "Name"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""190"" Height=""790"" />"
            table3.Name = "Customers"
            columnExpression1.Table = table3
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Phone"
            columnExpression2.Table = table3
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Id"
            columnExpression3.Table = table3
            column3.Expression = columnExpression3
            column4.[Alias] = "State"
            columnExpression4.ColumnName = "LongName"
            table4.MetaSerializable = "<Meta X=""250"" Y=""30"" Width=""125"" Height=""170"" />"
            table4.Name = "States"
            columnExpression4.Table = table4
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Website"
            columnExpression5.Table = table3
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Logo"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "HomeOffice_Line"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "HomeOffice_City"
            columnExpression8.Table = table3
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ShortName"
            columnExpression9.Table = table4
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "HomeOffice_ZipCode"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
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
            selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""165"" Height=""230"" />"
            selectQuery1.Name = "Customers"
            relationColumnInfo1.NestedKeyColumn = "ShortName"
            relationColumnInfo1.ParentKeyColumn = "BillingAddress_State"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table4
            join1.Parent = table3
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table4)
            columnExpression11.ColumnName = "Id"
            table5.MetaSerializable = "<Meta X=""-140"" Y=""30"" Width=""240"" Height=""457"" />"
            table5.Name = "Orders"
            columnExpression11.Table = table5
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "CustomerId"
            columnExpression12.Table = table5
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "OrderDate"
            columnExpression13.Table = table5
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "InvoiceNumber"
            columnExpression14.Table = table5
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "TotalAmount"
            columnExpression15.Table = table5
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "ShipDate"
            columnExpression16.Table = table5
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ShipMethod"
            columnExpression17.Table = table5
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ShipmentStatus"
            columnExpression18.Table = table5
            column18.Expression = columnExpression18
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.Columns.Add(column18)
            selectQuery2.FilterString = "[Orders.OrderDate] >= ?parameter1_Start And [Orders.OrderDate] <= ?parameter1_End" & ""
            selectQuery2.GroupFilterString = ""
            selectQuery2.MetaSerializable = "<Meta X=""205"" Y=""20"" Width=""130"" Height=""230"" />"
            selectQuery2.Name = "Orders"
            queryParameter1.Name = "parameter1_Start"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("?parameter1_Start", GetType(System.DateTime))
            queryParameter2.Name = "parameter1_End"
            queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter2.Value = New DevExpress.DataAccess.Expression("?parameter1_End", GetType(System.DateTime))
            selectQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter1, queryParameter2})
            selectQuery2.Tables.Add(table5)
            column19.[Alias] = "Units"
            columnExpression19.ColumnName = "ProductUnits"
            table7.MetaSerializable = "<Meta X=""-130"" Y=""-30"" Width=""190"" Height=""217"" />"
            table7.Name = "OrderItems"
            columnExpression19.Table = table7
            column19.Expression = columnExpression19
            column20.[Alias] = "Price"
            columnExpression20.ColumnName = "ProductPrice"
            columnExpression20.Table = table7
            column20.Expression = columnExpression20
            columnExpression21.ColumnName = "Discount"
            columnExpression21.Table = table7
            column21.Expression = columnExpression21
            columnExpression22.ColumnName = "Total"
            columnExpression22.Table = table7
            column22.Expression = columnExpression22
            columnExpression23.ColumnName = "Name"
            table8.MetaSerializable = "<Meta X=""90"" Y=""30"" Width=""210"" Height=""457"" />"
            table8.Name = "Products"
            columnExpression23.Table = table8
            column23.Expression = columnExpression23
            columnExpression24.ColumnName = "Weight"
            columnExpression24.Table = table8
            column24.Expression = columnExpression24
            columnExpression25.ColumnName = "OrderId"
            columnExpression25.Table = table7
            column25.Expression = columnExpression25
            selectQuery3.Columns.Add(column19)
            selectQuery3.Columns.Add(column20)
            selectQuery3.Columns.Add(column21)
            selectQuery3.Columns.Add(column22)
            selectQuery3.Columns.Add(column23)
            selectQuery3.Columns.Add(column24)
            selectQuery3.Columns.Add(column25)
            selectQuery3.MetaSerializable = "<Meta X=""355"" Y=""20"" Width=""113"" Height=""210"" />"
            selectQuery3.Name = "OrderItems"
            relationColumnInfo2.NestedKeyColumn = "Id"
            relationColumnInfo2.ParentKeyColumn = "ProductId"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table8
            join2.Parent = table7
            selectQuery3.Relations.Add(join2)
            selectQuery3.Tables.Add(table7)
            selectQuery3.Tables.Add(table8)
            columnExpression26.ColumnName = "CustomerId"
            table10.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""330"" />"
            table10.Name = "CustomerEmployees"
            columnExpression26.Table = table10
            column26.Expression = columnExpression26
            columnExpression27.ColumnName = "FullName"
            columnExpression27.Table = table10
            column27.Expression = columnExpression27
            columnExpression28.ColumnName = "Email"
            columnExpression28.Table = table10
            column28.Expression = columnExpression28
            selectQuery4.Columns.Add(column26)
            selectQuery4.Columns.Add(column27)
            selectQuery4.Columns.Add(column28)
            selectQuery4.MetaSerializable = "<Meta X=""488"" Y=""20"" Width=""181"" Height=""130"" />"
            selectQuery4.Name = "CustomerEmployees"
            selectQuery4.Tables.Add(table10)
            Me.Customers.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2, selectQuery3, selectQuery4})
            masterDetailInfo1.DetailQueryName = "Orders"
            relationColumnInfo3.NestedKeyColumn = "CustomerId"
            relationColumnInfo3.ParentKeyColumn = "Id"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Customers"
            masterDetailInfo2.DetailQueryName = "OrderItems"
            relationColumnInfo4.NestedKeyColumn = "OrderId"
            relationColumnInfo4.ParentKeyColumn = "Id"
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo4)
            masterDetailInfo2.MasterQueryName = "Orders"
            masterDetailInfo3.DetailQueryName = "CustomerEmployees"
            relationColumnInfo5.NestedKeyColumn = "CustomerId"
            relationColumnInfo5.ParentKeyColumn = "Id"
            masterDetailInfo3.KeyColumns.Add(relationColumnInfo5)
            masterDetailInfo3.MasterQueryName = "Customers"
            Me.Customers.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1, masterDetailInfo2, masterDetailInfo3})
            Me.Customers.ResultSchemaSerializable = resources.GetString("Customers.ResultSchemaSerializable")
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(272.6117F, 45.25817F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(137.915F, 23F)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.StylePriority.UseFont = False
            Me.pageInfo2.StylePriority.UseTextAlignment = False
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            ' 
            ' DetailData3
            ' 
            Me.DetailData3.Font = New DevExpress.Drawing.DXFont("Arial", 8.75F)
            Me.DetailData3.ForeColor = System.Drawing.Color.Black
            Me.DetailData3.Name = "DetailData3"
            Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' Headers
            ' 
            Me.Headers.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.Headers.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((147)))))), (CInt(((CByte((173)))))))
            Me.Headers.Name = "Headers"
            Me.Headers.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Headers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportTitleCaption
            ' 
            Me.ReportTitleCaption.BackColor = System.Drawing.Color.Transparent
            Me.ReportTitleCaption.BorderColor = System.Drawing.Color.Transparent
            Me.ReportTitleCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.ReportTitleCaption.Font = New DevExpress.Drawing.DXFont("Arial", 24F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.ReportTitleCaption.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((62)))))), (CInt(((CByte((62)))))), (CInt(((CByte((79)))))))
            Me.ReportTitleCaption.Name = "ReportTitleCaption"
            Me.ReportTitleCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.ReportTitleCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((147)))))), (CInt(((CByte((173)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' TableHeaders
            ' 
            Me.TableHeaders.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((121)))))), (CInt(((CByte((132)))))))
            Me.TableHeaders.BorderColor = System.Drawing.Color.White
            Me.TableHeaders.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.TableHeaders.BorderWidth = 2F
            Me.TableHeaders.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TableHeaders.ForeColor = System.Drawing.Color.White
            Me.TableHeaders.Name = "TableHeaders"
            Me.TableHeaders.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.TableHeaders.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailReportTableHeaders
            ' 
            Me.DetailReportTableHeaders.BackColor = System.Drawing.Color.White
            Me.DetailReportTableHeaders.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((230)))))), (CInt(((CByte((230)))))), (CInt(((CByte((239)))))))
            Me.DetailReportTableHeaders.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.DetailReportTableHeaders.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.DetailReportTableHeaders.BorderWidth = 2F
            Me.DetailReportTableHeaders.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.DetailReportTableHeaders.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((147)))))), (CInt(((CByte((147)))))), (CInt(((CByte((173)))))))
            Me.DetailReportTableHeaders.Name = "DetailReportTableHeaders"
            Me.DetailReportTableHeaders.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 4, 100F)
            Me.DetailReportTableHeaders.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' parameter1
            ' 
            Me.parameter1.Description = "Date Range"
            Me.parameter1.Name = "parameter1"
            Me.parameter1.Type = GetType(System.DateTime)
            Me.parameter1.ValueSourceSettings = New DevExpress.XtraReports.Parameters.RangeParametersSettings(Me.parameter1_Start, Me.parameter1_End)
            ' 
            ' parameter1_Start
            ' 
            Me.parameter1_Start.Name = "parameter1_Start"
            Me.parameter1_Start.ValueInfo = "2024-04-01"
            ' 
            ' parameter1_End
            ' 
            Me.parameter1_End.Name = "parameter1_End"
            Me.parameter1_End.ValueInfo = "2024-08-30"
            ' 
            ' Company
            ' 
            Me.Company.Description = "Company"
            Me.Company.Name = "Company"
            Me.Company.ValueInfo = "ACME"
            dynamicListLookUpSettings1.DataMember = "Customers"
            dynamicListLookUpSettings1.DataSource = Me.Customers
            dynamicListLookUpSettings1.DisplayMember = "Name"
            dynamicListLookUpSettings1.SortMember = "Name"
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            dynamicListLookUpSettings1.ValueMember = "Name"
            Me.Company.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.PageHeader, Me.Detail, Me.DetailReport, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.Customers})
            Me.DataMember = "Customers"
            Me.DataSource = Me.Customers
            Me.DisplayName = "Drill-Through Report"
            Me.FilterString = "[Name] = ?Company"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((62)))))), (CInt(((CByte((62)))))), (CInt(((CByte((79)))))))
            Me.ImageResources.AddRange(New DevExpress.XtraPrinting.Drawing.ImageItem() {New DevExpress.XtraPrinting.Drawing.ImageItem("collapse", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources"))), New DevExpress.XtraPrinting.Drawing.ImageItem("delivered", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources1"))), New DevExpress.XtraPrinting.Drawing.ImageItem("expand", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources2"))), New DevExpress.XtraPrinting.Drawing.ImageItem("pending", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources3"))), New DevExpress.XtraPrinting.Drawing.ImageItem("transit", New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("$this.ImageResources4")))})
            Me.Margins = New DevExpress.Drawing.DXMargins(79F, 81.25F, 40.625F, 100F)
            Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.parameter1, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Company, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameter1, Me.Company})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.DetailData3, Me.Headers, Me.ReportTitleCaption, Me.PageInfo, Me.TableHeaders, Me.DetailReportTableHeaders})
            Me.Version = "25.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private table6 As DevExpress.XtraReports.UI.XRTable

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell33 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell34 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private table9 As DevExpress.XtraReports.UI.XRTable

        Private tableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private Customers As DevExpress.DataAccess.Sql.SqlDataSource

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private DetailData3 As DevExpress.XtraReports.UI.XRControlStyle

        Private Headers As DevExpress.XtraReports.UI.XRControlStyle

        Private ReportTitleCaption As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private TableHeaders As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailReportTableHeaders As DevExpress.XtraReports.UI.XRControlStyle

        Private parameter1 As DevExpress.XtraReports.Parameters.Parameter

        Private parameter1_Start As DevExpress.XtraReports.Parameters.RangeStartParameter

        Private parameter1_End As DevExpress.XtraReports.Parameters.RangeEndParameter

        Private Company As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
