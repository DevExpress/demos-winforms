Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.Subreports

    Partial Class DetailReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private GroupFooter0 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private clNo As DevExpress.XtraReports.UI.XRTableCell

        Private clDate As DevExpress.XtraReports.UI.XRTableCell

        Private clAmount As DevExpress.XtraReports.UI.XRTableCell

        Private clID As DevExpress.XtraReports.UI.XRTableCell

        Private clTime As DevExpress.XtraReports.UI.XRTableCell

        Private clPaymentType As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private clOrderCount As DevExpress.XtraReports.UI.XRTableCell

        Private clTotal As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

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
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.Subreports.DetailReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clNo = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clTime = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clPaymentType = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clAmount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter0 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clOrderCount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clTotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.customerIDParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.dsOrders1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.dateRangeParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.dateRangeParameter_Start = New DevExpress.XtraReports.Parameters.RangeStartParameter()
            Me.dateRangeParameter_End = New DevExpress.XtraReports.Parameters.RangeEndParameter()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail.HeightF = 26F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((232)))))), (CInt(((CByte((237)))))))
            Me.xrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.xrTable2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((77)))))), (CInt(((CByte((107)))))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 26F)
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.clNo, Me.clID, Me.clDate, Me.clTime, Me.clPaymentType, Me.clAmount})
            Me.xrTableRow2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((77)))))), (CInt(((CByte((107)))))))
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.StylePriority.UseForeColor = False
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1R
            ' 
            ' clNo
            ' 
            Me.clNo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.clNo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount(ID)")})
            Me.clNo.Name = "clNo"
            Me.clNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.clNo.Summary = xrSummary1
            Me.clNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clNo.Weight = 0.12738853503184713R
            ' 
            ' clID
            ' 
            Me.clID.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ID")})
            Me.clID.Name = "clID"
            Me.clID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clID.Weight = 0.10828025477707007R
            ' 
            ' clDate
            ' 
            Me.clDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "PurchaseDate")})
            Me.clDate.Name = "clDate"
            Me.clDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDate.TextFormatString = "{0:d}"
            Me.clDate.Weight = 0.19108280254777071R
            ' 
            ' clTime
            ' 
            Me.clTime.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Time")})
            Me.clTime.Name = "clTime"
            Me.clTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clTime.TextFormatString = "{0:t}"
            Me.clTime.Weight = 0.14331210191082802R
            ' 
            ' clPaymentType
            ' 
            Me.clPaymentType.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "PaymentType")})
            Me.clPaymentType.Name = "clPaymentType"
            Me.clPaymentType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clPaymentType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clPaymentType.Weight = 0.24840764331210191R
            ' 
            ' clAmount
            ' 
            Me.clAmount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "PaymentAmount")})
            Me.clAmount.Name = "clAmount"
            Me.clAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clAmount.TextFormatString = "{0:c2}"
            Me.clAmount.Weight = 0.21656070393361862R
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CustomerID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader0.HeightF = 26F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((232)))))), (CInt(((CByte((237)))))))
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable1.ForeColor = System.Drawing.Color.Black
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 26F)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell10, Me.xrTableCell2, Me.xrTableCell13, Me.xrTableCell16, Me.xrTableCell3})
            Me.xrTableRow1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((77)))))), (CInt(((CByte((107)))))))
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.StylePriority.UseForeColor = False
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1.04R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.Text = "No."
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.12738853503184713R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.StylePriority.UseFont = False
            Me.xrTableCell10.Text = "ID"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.10828025477707007R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell2.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.Text = "Purchase Date"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.19108280254777071R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell13.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.StylePriority.UseFont = False
            Me.xrTableCell13.StylePriority.UseTextAlignment = False
            Me.xrTableCell13.Text = "Time"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell13.Weight = 0.14331210191082802R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell16.StylePriority.UseFont = False
            Me.xrTableCell16.Text = "Payment Type"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell16.Weight = 0.24840764331210191R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "Amount"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.21656060674387936R
            ' 
            ' GroupFooter0
            ' 
            Me.GroupFooter0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3})
            Me.GroupFooter0.HeightF = 39.33523F
            Me.GroupFooter0.Name = "GroupFooter0"
            Me.GroupFooter0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupFooter0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(650.0001F, 26F)
            Me.xrTable3.StylePriority.UseFont = False
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.clOrderCount, Me.xrTableCell8, Me.clTotal})
            Me.xrTableRow3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((77)))))), (CInt(((CByte((107)))))))
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.StylePriority.UseForeColor = False
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 1.1304347826086956R
            ' 
            ' clOrderCount
            ' 
            Me.clOrderCount.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.clOrderCount.BorderColor = System.Drawing.Color.Empty
            Me.clOrderCount.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.clOrderCount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount(ID)")})
            Me.clOrderCount.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.clOrderCount.Name = "clOrderCount"
            Me.clOrderCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clOrderCount.StylePriority.UseBackColor = False
            Me.clOrderCount.StylePriority.UseBorderColor = False
            Me.clOrderCount.StylePriority.UseFont = False
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.clOrderCount.Summary = xrSummary2
            Me.clOrderCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clOrderCount.TextFormatString = "{0:'Order count: '#}"
            Me.clOrderCount.Weight = 0.25477707006369427R
            Me.clOrderCount.XlsxFormatString = """Order count: ""#"
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.37579617834394907R
            ' 
            ' clTotal
            ' 
            Me.clTotal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((247)))))), (CInt(((CByte((249)))))))
            Me.clTotal.BorderColor = System.Drawing.Color.Empty
            Me.clTotal.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.clTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(PaymentAmount)")})
            Me.clTotal.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.clTotal.Name = "clTotal"
            Me.clTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clTotal.StylePriority.UseBackColor = False
            Me.clTotal.StylePriority.UseBorderColor = False
            Me.clTotal.StylePriority.UseFont = False
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.clTotal.Summary = xrSummary3
            Me.clTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clTotal.TextFormatString = "Total Amount:  {0:c2}"
            Me.clTotal.Weight = 0.40445879310559313R
            Me.clTotal.XlsxFormatString = """Total Amount: ""$#,##0.00"
            ' 
            ' customerIDParameter
            ' 
            Me.customerIDParameter.Name = "customerIDParameter"
            Me.customerIDParameter.Type = GetType(Integer)
            Me.customerIDParameter.ValueInfo = "12"
            Me.customerIDParameter.Visible = False
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' dsOrders1
            ' 
            Me.dsOrders1.ConnectionName = "HomesConnectionString"
            Me.dsOrders1.Name = "dsOrders1"
            columnExpression1.ColumnName = "ID"
            table1.Name = "Orders"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CustomerID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "PurchaseDate"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Time"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "PaymentType"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "PaymentAmount"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "Orders"
            selectQuery1.Tables.Add(table1)
            Me.dsOrders1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsOrders1.ResultSchemaSerializable = resources.GetString("dsOrders1.ResultSchemaSerializable")
            ' 
            ' dateRangeParameter
            ' 
            Me.dateRangeParameter.Description = "Date range"
            Me.dateRangeParameter.Name = "dateRangeParameter"
            Me.dateRangeParameter.Type = GetType(System.DateTime)
            Me.dateRangeParameter.ValueSourceSettings = New DevExpress.XtraReports.Parameters.RangeParametersSettings(Me.dateRangeParameter_Start, Me.dateRangeParameter_End)
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
            ' DetailReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.GroupHeader0, Me.Detail, Me.GroupFooter0, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataMember = "Orders"
            Me.DataSource = Me.dsOrders1
            Me.FilterString = "[CustomerID] = ?customerIDParameter And [PurchaseDate] Between(?dateRangeParamete" & "r_Start, ?dateRangeParameter_End)"
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.customerIDParameter, Me.dateRangeParameter})
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
            Me.RequestParameters = False
            Me.Version = "25.1"
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private dsOrders1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private customerIDParameter As DevExpress.XtraReports.Parameters.Parameter

        Private components As System.ComponentModel.IContainer

        Private dateRangeParameter As DevExpress.XtraReports.Parameters.Parameter

        Private dateRangeParameter_Start As DevExpress.XtraReports.Parameters.RangeStartParameter

        Private dateRangeParameter_End As DevExpress.XtraReports.Parameters.RangeEndParameter
    End Class
End Namespace
