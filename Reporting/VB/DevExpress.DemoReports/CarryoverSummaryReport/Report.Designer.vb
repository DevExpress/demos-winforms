Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CarryoverSummaryReport

    Public Partial Class Report

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.detailReportBand1 = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.detailBand2 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportTitleCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Headers = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SummaryTitles = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SummaryValues = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo4, Me.xrPageInfo3})
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrPageInfo4
            ' 
            Me.xrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(461.75F, 38.73147F)
            Me.xrPageInfo4.Name = "xrPageInfo4"
            Me.xrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo4.SizeF = New System.Drawing.SizeF(178.875F, 23F)
            Me.xrPageInfo4.StyleName = "PageInfo"
            Me.xrPageInfo4.StylePriority.UseForeColor = False
            Me.xrPageInfo4.StylePriority.UsePadding = False
            Me.xrPageInfo4.StylePriority.UseTextAlignment = False
            Me.xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrPageInfo4.TextFormatString = "Issued: {0}"
            ' 
            ' xrPageInfo3
            ' 
            Me.xrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 38.73146F)
            Me.xrPageInfo3.Name = "xrPageInfo3"
            Me.xrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.xrPageInfo3.SizeF = New System.Drawing.SizeF(300.2737F, 23F)
            Me.xrPageInfo3.StyleName = "PageInfo"
            Me.xrPageInfo3.StylePriority.UseForeColor = False
            Me.xrPageInfo3.StylePriority.UsePadding = False
            Me.xrPageInfo3.StylePriority.UseTextAlignment = False
            Me.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrPageInfo3.TextFormatString = "Page {0} of {1} Pages"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable4, Me.xrLabel1})
            Me.detailBand1.HeightF = 198.6111F
            Me.detailBand1.KeepTogether = True
            Me.detailBand1.Name = "detailBand1"
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTable4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 48.95833F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow5, Me.xrTableRow6, Me.xrTableRow7, Me.xrTableRow8})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(640.625F, 116.6666F)
            Me.xrTable4.StylePriority.UseBorderColor = False
            Me.xrTable4.StylePriority.UseBorders = False
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell10, Me.xrTableCell11})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Weight = 10.208333833436589R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            Me.xrTableCell10.StyleName = "DetailData3_Odd"
            Me.xrTableCell10.StylePriority.UseFont = False
            Me.xrTableCell10.StylePriority.UseForeColor = False
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.Text = "CONTACT NAME"
            Me.xrTableCell10.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            Me.xrTableCell11.StyleName = "DetailData3_Odd"
            Me.xrTableCell11.StylePriority.UsePadding = False
            Me.xrTableCell11.Text = "Laurence Lebihan"
            Me.xrTableCell11.Weight = 0.31267396236756584R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell14, Me.xrTableCell16})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Weight = 10.208333401633816R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            Me.xrTableCell14.StyleName = "Headers"
            Me.xrTableCell14.StylePriority.UseBackColor = False
            Me.xrTableCell14.StylePriority.UseBorderColor = False
            Me.xrTableCell14.StylePriority.UseBorders = False
            Me.xrTableCell14.StylePriority.UseFont = False
            Me.xrTableCell14.StylePriority.UseForeColor = False
            Me.xrTableCell14.StylePriority.UsePadding = False
            Me.xrTableCell14.Text = "CONTACT TITLE"
            Me.xrTableCell14.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactTitle]")})
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            Me.xrTableCell16.StyleName = "DetailData3"
            Me.xrTableCell16.StylePriority.UseBorderColor = False
            Me.xrTableCell16.StylePriority.UseBorders = False
            Me.xrTableCell16.StylePriority.UsePadding = False
            Me.xrTableCell16.Text = "Owner"
            Me.xrTableCell16.Weight = 0.31267396236756584R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell17, Me.xrTableCell19})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Weight = 10.208334312922753R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell17.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            Me.xrTableCell17.StyleName = "DetailData3_Odd"
            Me.xrTableCell17.StylePriority.UseFont = False
            Me.xrTableCell17.StylePriority.UseForeColor = False
            Me.xrTableCell17.StylePriority.UsePadding = False
            Me.xrTableCell17.Text = "BILLING STATEMENT DATE"
            Me.xrTableCell17.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillingDate]")})
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            Me.xrTableCell19.StyleName = "DetailData3_Odd"
            Me.xrTableCell19.StylePriority.UsePadding = False
            Me.xrTableCell19.Text = "9/5/2018"
            Me.xrTableCell19.TextFormatString = "{0:M/d/yyyy}"
            Me.xrTableCell19.Weight = 0.31267396236756584R
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell22, Me.xrTableCell30})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Weight = 10.208334312922753R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            Me.xrTableCell22.StyleName = "Headers"
            Me.xrTableCell22.StylePriority.UseBackColor = False
            Me.xrTableCell22.StylePriority.UseBorderColor = False
            Me.xrTableCell22.StylePriority.UseBorders = False
            Me.xrTableCell22.StylePriority.UseFont = False
            Me.xrTableCell22.StylePriority.UseForeColor = False
            Me.xrTableCell22.StylePriority.UsePadding = False
            Me.xrTableCell22.Text = "BILLING PERIOD"
            Me.xrTableCell22.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat(FormatString('{0:M/d/yyyy}',[BillingPeriodStart] ), ' To ', FormatString('" & "{0:M/d/yyyy}',[BillingPeriodEnd]))")})
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            Me.xrTableCell30.StyleName = "DetailData3"
            Me.xrTableCell30.StylePriority.UseBorderColor = False
            Me.xrTableCell30.StylePriority.UseBorders = False
            Me.xrTableCell30.StylePriority.UsePadding = False
            Me.xrTableCell30.Text = "8/4/2018 To 8/17/2018"
            Me.xrTableCell30.Weight = 0.31267396236756584R
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(5.298191E-05F, 2.083354F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(640.625F, 35F)
            Me.xrLabel1.StyleName = "Title"
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Transaction Report"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' detailReportBand1
            ' 
            Me.detailReportBand1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.groupHeaderBand1, Me.detailBand2, Me.ReportHeader, Me.GroupFooter1, Me.GroupHeader1, Me.ReportFooter})
            Me.detailReportBand1.DataMember = "Adjustments"
            Me.detailReportBand1.DataSource = Me.objectDataSource1
            Me.detailReportBand1.Level = 0
            Me.detailReportBand1.Name = "detailReportBand1"
            Me.detailReportBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' groupHeaderBand1
            ' 
            Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.groupHeaderBand1.HeightF = 29.16667F
            Me.groupHeaderBand1.Name = "groupHeaderBand1"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTable2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.BorderWidth = 1.2F
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(640.625F, 29.16667F)
            Me.xrTable2.StyleName = "Headers"
            Me.xrTable2.StylePriority.UseBorderWidth = False
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.StyleName = "Headers"
            Me.xrTableRow3.Weight = 1.0416666991890433R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell7.BorderWidth = 2F
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.xrTableCell7.StyleName = "Headers"
            Me.xrTableCell7.StylePriority.UseBorderColor = False
            Me.xrTableCell7.StylePriority.UseBorders = False
            Me.xrTableCell7.StylePriority.UseBorderWidth = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.Text = "DATE"
            Me.xrTableCell7.Weight = 0.33495923754802337R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell8.BorderWidth = 2F
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StyleName = "Headers"
            Me.xrTableCell8.StylePriority.UseBorderColor = False
            Me.xrTableCell8.StylePriority.UseBorders = False
            Me.xrTableCell8.StylePriority.UseBorderWidth = False
            Me.xrTableCell8.Text = "DESCRIPTION"
            Me.xrTableCell8.Weight = 0.33821137643114435R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell9.BorderWidth = 2F
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell9.StyleName = "Headers"
            Me.xrTableCell9.StylePriority.UseBorderColor = False
            Me.xrTableCell9.StylePriority.UseBorders = False
            Me.xrTableCell9.StylePriority.UseBorderWidth = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "AMOUNT"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell9.Weight = 0.32682931380047742R
            ' 
            ' detailBand2
            ' 
            Me.detailBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3})
            Me.detailBand2.EvenStyleName = "DetailData3"
            Me.detailBand2.HeightF = 29.16667F
            Me.detailBand2.Name = "detailBand2"
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrTable3.BorderWidth = 0.8F
            Me.xrTable3.EvenStyleName = "DetailData3_Odd"
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(5.298196E-05F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.OddStyleName = "DetailData3"
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow4})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(640.6249F, 29.16667F)
            Me.xrTable3.StylePriority.UseBorderColor = False
            Me.xrTable3.StylePriority.UseBorders = False
            Me.xrTable3.StylePriority.UseBorderWidth = False
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell15})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 13.416666666666666R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Date]")})
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.xrTableCell12.StyleName = "DetailData3"
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.Text = "9/9/2018"
            Me.xrTableCell12.TextFormatString = "{0:M/d/yyyy}"
            Me.xrTableCell12.Weight = 0.28130134561309356R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.StyleName = "DetailData3"
            Me.xrTableCell13.StylePriority.UsePadding = False
            Me.xrTableCell13.Text = "Bill - Rent"
            Me.xrTableCell13.Weight = 0.28403245599529431R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]")})
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.xrTableCell15.StyleName = "DetailData3"
            Me.xrTableCell15.StylePriority.UsePadding = False
            Me.xrTableCell15.StylePriority.UseTextAlignment = False
            Me.xrTableCell15.Text = "$210.00"
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell15.TextFormatString = "{0:$#,##.00}"
            Me.xrTableCell15.Weight = 0.27447364354195125R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3})
            Me.ReportHeader.HeightF = 40.44596F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2.083306F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(640.625F, 27.94597F)
            Me.xrLabel3.StyleName = "Title"
            Me.xrLabel3.StylePriority.UseBorderColor = False
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.Text = "Transactions"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel14})
            Me.GroupFooter1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[DataSource.CurrentRowIndex] != [DataSource.RowCount] - 1")})
            Me.GroupFooter1.HeightF = 23F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.RepeatEveryPage = True
            ' 
            ' xrLabel14
            ' 
            Me.xrLabel14.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel14.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrLabel14.BorderWidth = 2F
            Me.xrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCarryoverSum([Amount])")})
            Me.xrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel14.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel14.Multiline = True
            Me.xrLabel14.Name = "xrLabel14"
            Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel14.SizeF = New System.Drawing.SizeF(640.625F, 23F)
            Me.xrLabel14.StylePriority.UseBackColor = False
            Me.xrLabel14.StylePriority.UseBorderColor = False
            Me.xrLabel14.StylePriority.UseBorders = False
            Me.xrLabel14.StylePriority.UseBorderWidth = False
            Me.xrLabel14.StylePriority.UseFont = False
            Me.xrLabel14.StylePriority.UseForeColor = False
            Me.xrLabel14.StylePriority.UseTextAlignment = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrLabel14.Summary = xrSummary1
            Me.xrLabel14.Text = "xrLabel14"
            Me.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel14.TextFormatString = "BALANCE C/F: {0:$#,##.00}"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.GroupHeader1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[DataSource.CurrentRowIndex] != 0")})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 23F
            Me.GroupHeader1.Level = 1
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel2.BorderWidth = 2F
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCarryoverSum([Amount])")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001483493F, 0F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(640.6249F, 23F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseBorderColor = False
            Me.xrLabel2.StylePriority.UseBorders = False
            Me.xrLabel2.StylePriority.UseBorderWidth = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrLabel2.Summary = xrSummary2
            Me.xrLabel2.Text = "xrLabel14"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel2.TextFormatString = "BALANCE B/F: {0:$#,##.00}"
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4})
            Me.ReportFooter.HeightF = 23F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel4.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrLabel4.BorderWidth = 2F
            Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([Amount])")})
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel4.Multiline = True
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(640.625F, 23F)
            Me.xrLabel4.StylePriority.UseBackColor = False
            Me.xrLabel4.StylePriority.UseBorderColor = False
            Me.xrLabel4.StylePriority.UseBorders = False
            Me.xrLabel4.StylePriority.UseBorderWidth = False
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "xrLabel14"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrLabel4.TextFormatString = "CLOSING BALANCE: {0:$#,##.00}"
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataMember = "GetData"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.CarryoverSummaryReport.DataSource)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New DevExpress.Drawing.DXFont("Arial", 13F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.Title.Name = "Title"
            ' 
            ' ReportTitleCaption
            ' 
            Me.ReportTitleCaption.BackColor = System.Drawing.Color.Transparent
            Me.ReportTitleCaption.BorderColor = System.Drawing.Color.Transparent
            Me.ReportTitleCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.ReportTitleCaption.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.ReportTitleCaption.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.ReportTitleCaption.Name = "ReportTitleCaption"
            Me.ReportTitleCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.ReportTitleCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3
            ' 
            Me.DetailData3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData3.ForeColor = System.Drawing.Color.Black
            Me.DetailData3.Name = "DetailData3"
            Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' Headers
            ' 
            Me.Headers.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.Headers.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.Headers.Name = "Headers"
            Me.Headers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' SummaryTitles
            ' 
            Me.SummaryTitles.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.SummaryTitles.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((171)))))), (CInt(((CByte((185)))))), (CInt(((CByte((214)))))))
            Me.SummaryTitles.Name = "SummaryTitles"
            Me.SummaryTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' SummaryValues
            ' 
            Me.SummaryValues.Font = New DevExpress.Drawing.DXFont("Arial", 23F)
            Me.SummaryValues.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((94)))))), (CInt(((CByte((168)))))))
            Me.SummaryValues.Name = "SummaryValues"
            Me.SummaryValues.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 16, 0, 100F)
            Me.SummaryValues.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.bottomMarginBand1, Me.detailBand1, Me.detailReportBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.DisplayName = "Large Dataset"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.ReportTitleCaption, Me.DetailData3, Me.DetailData3_Odd, Me.PageInfo, Me.Headers, Me.SummaryTitles, Me.SummaryValues})
            Me.Version = "23.1"
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private detailBand1 As DevExpress.XtraReports.UI.DetailBand

        Private detailReportBand1 As DevExpress.XtraReports.UI.DetailReportBand

        Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private detailBand2 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private ReportTitleCaption As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private Headers As DevExpress.XtraReports.UI.XRControlStyle

        Private SummaryTitles As DevExpress.XtraReports.UI.XRControlStyle

        Private SummaryValues As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private components As System.ComponentModel.IContainer

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
