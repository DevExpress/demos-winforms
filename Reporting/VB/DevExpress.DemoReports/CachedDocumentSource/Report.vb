Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class Report
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private xrPageInfo4 As XRPageInfo

        Private xrPageInfo3 As XRPageInfo

        Private bottomMarginBand1 As BottomMarginBand

        Private detailBand1 As DetailBand

        Private xrLabel1 As XRLabel

        Private xrBarCode1 As XRBarCode

        Private xrLabel4 As XRLabel

        Private xrLabel5 As XRLabel

        Private xrLabel6 As XRLabel

        Private xrLabel7 As XRLabel

        Private xrLabel8 As XRLabel

        Private xrLabel9 As XRLabel

        Private xrLabel10 As XRLabel

        Private xrLabel11 As XRLabel

        Private xrLabel12 As XRLabel

        Private xrLabel13 As XRLabel

        Private SubBand1 As SubBand

        Private xrTable5 As XRTable

        Private xrTableRow9 As XRTableRow

        Private xrTableCell18 As XRTableCell

        Private xrTableCell20 As XRTableCell

        Private xrTableRow11 As XRTableRow

        Private xrTableCell24 As XRTableCell

        Private xrTableCell25 As XRTableCell

        Private xrTableRow12 As XRTableRow

        Private xrTableCell26 As XRTableCell

        Private xrTableCell27 As XRTableCell

        Private xrTableRow10 As XRTableRow

        Private xrTableCell21 As XRTableCell

        Private xrTableCell23 As XRTableCell

        Private xrTableRow13 As XRTableRow

        Private xrTableCell28 As XRTableCell

        Private xrTableCell29 As XRTableCell

        Private xrLabel2 As XRLabel

        Private detailReportBand1 As DetailReportBand

        Private groupHeaderBand1 As GroupHeaderBand

        Private xrTable2 As XRTable

        Private xrTableRow3 As XRTableRow

        Private xrTableCell7 As XRTableCell

        Private xrTableCell8 As XRTableCell

        Private xrTableCell9 As XRTableCell

        Private xrTableCell11 As XRTableCell

        Private detailBand2 As DetailBand

        Private xrTable3 As XRTable

        Private xrTableRow4 As XRTableRow

        Private xrTableCell12 As XRTableCell

        Private xrTableCell13 As XRTableCell

        Private xrTableCell15 As XRTableCell

        Private xrTableCell16 As XRTableCell

        Private ReportHeader As ReportHeaderBand

        Private xrLabel3 As XRLabel

        Private ReportFooter As ReportFooterBand

        Private xrTable1 As XRTable

        Private xrTableRow1 As XRTableRow

        Private xrTableCell3 As XRTableCell

        Private xrTableCell1 As XRTableCell

        Private xrTableCell2 As XRTableCell

        Private xrTableRow2 As XRTableRow

        Private xrTableCell6 As XRTableCell

        Private xrTableCell4 As XRTableCell

        Private xrTableCell5 As XRTableCell

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private Title As XRControlStyle

        Private ReportTitleCaption As XRControlStyle

        Private DetailData3 As XRControlStyle

        Private DetailData3_Odd As XRControlStyle

        Private PageInfo As XRControlStyle

        Private Headers As XRControlStyle

        Private SummaryTitles As XRControlStyle

        Private SummaryValues As XRControlStyle

        Protected RowCountParameter As DevExpress.XtraReports.Parameters.Parameter

        Private components As System.ComponentModel.IContainer

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.LargeDatasetName
            DisplayName = ReportNames.LargeDataset
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim qrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            Dim xrSummary1 As XRSummary = New XRSummary()
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Dim parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
            topMarginBand1 = New TopMarginBand()
            bottomMarginBand1 = New BottomMarginBand()
            detailBand1 = New DetailBand()
            detailReportBand1 = New DetailReportBand()
            xrPageInfo4 = New XRPageInfo()
            xrPageInfo3 = New XRPageInfo()
            xrLabel1 = New XRLabel()
            xrBarCode1 = New XRBarCode()
            xrLabel4 = New XRLabel()
            xrLabel5 = New XRLabel()
            xrLabel6 = New XRLabel()
            xrLabel7 = New XRLabel()
            xrLabel8 = New XRLabel()
            xrLabel9 = New XRLabel()
            xrLabel10 = New XRLabel()
            xrLabel11 = New XRLabel()
            xrLabel12 = New XRLabel()
            xrLabel13 = New XRLabel()
            SubBand1 = New SubBand()
            xrTable5 = New XRTable()
            xrLabel2 = New XRLabel()
            xrTableRow9 = New XRTableRow()
            xrTableRow11 = New XRTableRow()
            xrTableRow12 = New XRTableRow()
            xrTableRow10 = New XRTableRow()
            xrTableRow13 = New XRTableRow()
            xrTableCell18 = New XRTableCell()
            xrTableCell20 = New XRTableCell()
            xrTableCell24 = New XRTableCell()
            xrTableCell25 = New XRTableCell()
            xrTableCell26 = New XRTableCell()
            xrTableCell27 = New XRTableCell()
            xrTableCell21 = New XRTableCell()
            xrTableCell23 = New XRTableCell()
            xrTableCell28 = New XRTableCell()
            xrTableCell29 = New XRTableCell()
            groupHeaderBand1 = New GroupHeaderBand()
            detailBand2 = New DetailBand()
            ReportHeader = New ReportHeaderBand()
            ReportFooter = New ReportFooterBand()
            xrTable2 = New XRTable()
            xrTableRow3 = New XRTableRow()
            xrTableCell7 = New XRTableCell()
            xrTableCell8 = New XRTableCell()
            xrTableCell9 = New XRTableCell()
            xrTableCell11 = New XRTableCell()
            xrTable3 = New XRTable()
            xrTableRow4 = New XRTableRow()
            xrTableCell12 = New XRTableCell()
            xrTableCell13 = New XRTableCell()
            xrTableCell15 = New XRTableCell()
            xrTableCell16 = New XRTableCell()
            xrLabel3 = New XRLabel()
            xrTable1 = New XRTable()
            xrTableRow1 = New XRTableRow()
            xrTableRow2 = New XRTableRow()
            xrTableCell3 = New XRTableCell()
            xrTableCell1 = New XRTableCell()
            xrTableCell2 = New XRTableCell()
            xrTableCell6 = New XRTableCell()
            xrTableCell4 = New XRTableCell()
            xrTableCell5 = New XRTableCell()
            objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components)
            Title = New XRControlStyle()
            ReportTitleCaption = New XRControlStyle()
            DetailData3 = New XRControlStyle()
            DetailData3_Odd = New XRControlStyle()
            PageInfo = New XRControlStyle()
            Headers = New XRControlStyle()
            SummaryTitles = New XRControlStyle()
            SummaryValues = New XRControlStyle()
            RowCountParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType(xrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Controls.AddRange(New XRControl() {xrPageInfo4, xrPageInfo3})
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' detailBand1
            ' 
            detailBand1.Controls.AddRange(New XRControl() {xrLabel1, xrBarCode1, xrLabel4, xrLabel5, xrLabel6, xrLabel7, xrLabel8, xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13})
            detailBand1.HeightF = 197.9167F
            detailBand1.KeepTogether = True
            detailBand1.Name = "detailBand1"
            detailBand1.SubBands.AddRange(New SubBand() {SubBand1})
            ' 
            ' detailReportBand1
            ' 
            detailReportBand1.Bands.AddRange(New Band() {groupHeaderBand1, detailBand2, ReportHeader, ReportFooter})
            detailReportBand1.DataMember = "Adjustments"
            detailReportBand1.DataSource = objectDataSource1
            detailReportBand1.Level = 0
            detailReportBand1.Name = "detailReportBand1"
            detailReportBand1.PageBreak = PageBreak.AfterBand
            ' 
            ' xrPageInfo4
            ' 
            xrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(461.75F, 38.73147F)
            xrPageInfo4.Name = "xrPageInfo4"
            xrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            xrPageInfo4.SizeF = New System.Drawing.SizeF(178.875F, 23F)
            xrPageInfo4.StyleName = "PageInfo"
            xrPageInfo4.StylePriority.UseForeColor = False
            xrPageInfo4.StylePriority.UsePadding = False
            xrPageInfo4.StylePriority.UseTextAlignment = False
            xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrPageInfo4.TextFormatString = "Issued: {0}"
            ' 
            ' xrPageInfo3
            ' 
            xrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 38.73146F)
            xrPageInfo3.Name = "xrPageInfo3"
            xrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrPageInfo3.SizeF = New System.Drawing.SizeF(300.2737F, 23F)
            xrPageInfo3.StyleName = "PageInfo"
            xrPageInfo3.StylePriority.UseForeColor = False
            xrPageInfo3.StylePriority.UsePadding = False
            xrPageInfo3.StylePriority.UseTextAlignment = False
            xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrPageInfo3.TextFormatString = "Page {0} of {1} Pages"
            ' 
            ' xrLabel1
            ' 
            xrLabel1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(650F, 50F)
            xrLabel1.StyleName = "ReportTitleCaption"
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.StylePriority.UseForeColor = False
            xrLabel1.StylePriority.UsePadding = False
            xrLabel1.Text = "Paris spécialités"
            ' 
            ' xrBarCode1
            ' 
            xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            xrBarCode1.AutoModule = True
            xrBarCode1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Address] + NewLine() + [City] + ' , ' + [PostalCode] + NewLine() + [Phone]")})
            xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(514.9792F, 50.18913F)
            xrBarCode1.Module = 4.7F
            xrBarCode1.Name = "xrBarCode1"
            xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            xrBarCode1.ShowText = False
            xrBarCode1.SizeF = New System.Drawing.SizeF(135.021F, 124.9819F)
            xrBarCode1.StylePriority.UsePadding = False
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte
            xrBarCode1.Symbology = qrCodeGenerator1
            xrBarCode1.Text = "12, rue des Bouchers" & Microsoft.VisualBasic.Constants.vbCrLf & "Marseille , 13008" & Microsoft.VisualBasic.Constants.vbCrLf & "91.24.45.40"
            ' 
            ' xrLabel4
            ' 
            xrLabel4.BackColor = System.Drawing.Color.Transparent
            xrLabel4.BorderColor = System.Drawing.Color.Transparent
            xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel4.BorderWidth = 1F
            xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 60.41667F)
            xrLabel4.Name = "xrLabel4"
            xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            xrLabel4.SizeF = New System.Drawing.SizeF(163.3871F, 25F)
            xrLabel4.StyleName = "Headers"
            xrLabel4.StylePriority.UseBackColor = False
            xrLabel4.StylePriority.UseBorderColor = False
            xrLabel4.StylePriority.UseBorders = False
            xrLabel4.StylePriority.UseBorderWidth = False
            xrLabel4.StylePriority.UseFont = False
            xrLabel4.StylePriority.UseForeColor = False
            xrLabel4.StylePriority.UsePadding = False
            xrLabel4.StylePriority.UseTextAlignment = False
            xrLabel4.Text = "CUSTOMER ACCOUNT:"
            xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel5
            ' 
            xrLabel5.BackColor = System.Drawing.Color.Transparent
            xrLabel5.BorderColor = System.Drawing.Color.Transparent
            xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel5.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[CustomerAccount]")})
            xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(163.3871F, 60.41667F)
            xrLabel5.Name = "xrLabel5"
            xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel5.SizeF = New System.Drawing.SizeF(127.8075F, 25F)
            xrLabel5.StyleName = "DetailData3"
            xrLabel5.StylePriority.UseBackColor = False
            xrLabel5.StylePriority.UseBorderColor = False
            xrLabel5.StylePriority.UseBorders = False
            xrLabel5.StylePriority.UseFont = False
            xrLabel5.StylePriority.UseForeColor = False
            xrLabel5.StylePriority.UsePadding = False
            xrLabel5.StylePriority.UseTextAlignment = False
            xrLabel5.Text = "Energy"
            xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel6
            ' 
            xrLabel6.BackColor = System.Drawing.Color.Transparent
            xrLabel6.BorderColor = System.Drawing.Color.Transparent
            xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel6.BorderWidth = 1F
            xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 89.58334F)
            xrLabel6.Name = "xrLabel6"
            xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            xrLabel6.SizeF = New System.Drawing.SizeF(163.3871F, 25F)
            xrLabel6.StyleName = "Headers"
            xrLabel6.StylePriority.UseBackColor = False
            xrLabel6.StylePriority.UseBorderColor = False
            xrLabel6.StylePriority.UseBorders = False
            xrLabel6.StylePriority.UseBorderWidth = False
            xrLabel6.StylePriority.UseFont = False
            xrLabel6.StylePriority.UseForeColor = False
            xrLabel6.StylePriority.UsePadding = False
            xrLabel6.StylePriority.UseTextAlignment = False
            xrLabel6.Text = "CUSTOMER IDENTIFIERS:"
            xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel7
            ' 
            xrLabel7.BackColor = System.Drawing.Color.Transparent
            xrLabel7.BorderColor = System.Drawing.Color.Transparent
            xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel7.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[CustomerIdentifiers]")})
            xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(163.3871F, 89.58334F)
            xrLabel7.Name = "xrLabel7"
            xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel7.SizeF = New System.Drawing.SizeF(127.8075F, 25F)
            xrLabel7.StyleName = "DetailData3"
            xrLabel7.StylePriority.UseBackColor = False
            xrLabel7.StylePriority.UseBorderColor = False
            xrLabel7.StylePriority.UseBorders = False
            xrLabel7.StylePriority.UseFont = False
            xrLabel7.StylePriority.UseForeColor = False
            xrLabel7.StylePriority.UsePadding = False
            xrLabel7.StylePriority.UseTextAlignment = False
            xrLabel7.Text = "1273-86"
            xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel8
            ' 
            xrLabel8.BackColor = System.Drawing.Color.Transparent
            xrLabel8.BorderColor = System.Drawing.Color.Transparent
            xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel8.BorderWidth = 1F
            xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0F, 118.75F)
            xrLabel8.Name = "xrLabel8"
            xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            xrLabel8.SizeF = New System.Drawing.SizeF(163.3871F, 24.99999F)
            xrLabel8.StyleName = "Headers"
            xrLabel8.StylePriority.UseBackColor = False
            xrLabel8.StylePriority.UseBorderColor = False
            xrLabel8.StylePriority.UseBorders = False
            xrLabel8.StylePriority.UseBorderWidth = False
            xrLabel8.StylePriority.UseFont = False
            xrLabel8.StylePriority.UseForeColor = False
            xrLabel8.StylePriority.UsePadding = False
            xrLabel8.StylePriority.UseTextAlignment = False
            xrLabel8.Text = "EMAIL:"
            xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel9
            ' 
            xrLabel9.AutoWidth = True
            xrLabel9.BackColor = System.Drawing.Color.Transparent
            xrLabel9.BorderColor = System.Drawing.Color.Transparent
            xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel9.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Email]")})
            xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(163.3871F, 118.75F)
            xrLabel9.Name = "xrLabel9"
            xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel9.SizeF = New System.Drawing.SizeF(127.8075F, 24.99997F)
            xrLabel9.StyleName = "DetailData3"
            xrLabel9.StylePriority.UseBackColor = False
            xrLabel9.StylePriority.UseBorderColor = False
            xrLabel9.StylePriority.UseBorders = False
            xrLabel9.StylePriority.UseFont = False
            xrLabel9.StylePriority.UseForeColor = False
            xrLabel9.StylePriority.UsePadding = False
            xrLabel9.StylePriority.UseTextAlignment = False
            xrLabel9.Text = "laurence@bon.com"
            xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrLabel9.WordWrap = False
            ' 
            ' xrLabel10
            ' 
            xrLabel10.BackColor = System.Drawing.Color.Transparent
            xrLabel10.BorderColor = System.Drawing.Color.Transparent
            xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel10.CanGrow = False
            xrLabel10.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Address]")})
            xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(370.0327F, 60.41668F)
            xrLabel10.Name = "xrLabel10"
            xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel10.SizeF = New System.Drawing.SizeF(144.7905F, 25F)
            xrLabel10.StyleName = "DetailData3"
            xrLabel10.StylePriority.UseBackColor = False
            xrLabel10.StylePriority.UseBorderColor = False
            xrLabel10.StylePriority.UseBorders = False
            xrLabel10.StylePriority.UseFont = False
            xrLabel10.StylePriority.UseForeColor = False
            xrLabel10.StylePriority.UsePadding = False
            xrLabel10.StylePriority.UseTextAlignment = False
            xrLabel10.Text = "12, rue des Bouchers"
            xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrLabel10.WordWrap = False
            ' 
            ' xrLabel11
            ' 
            xrLabel11.BackColor = System.Drawing.Color.Transparent
            xrLabel11.BorderColor = System.Drawing.Color.Transparent
            xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel11.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[City] + ', ' + [Region] + ' ' + [PostalCode]")})
            xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(302.2708F, 89.58334F)
            xrLabel11.Name = "xrLabel11"
            xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel11.SizeF = New System.Drawing.SizeF(212.5539F, 25F)
            xrLabel11.StyleName = "DetailData3"
            xrLabel11.StylePriority.UseBackColor = False
            xrLabel11.StylePriority.UseBorderColor = False
            xrLabel11.StylePriority.UseBorders = False
            xrLabel11.StylePriority.UseFont = False
            xrLabel11.StylePriority.UseForeColor = False
            xrLabel11.StylePriority.UsePadding = False
            xrLabel11.StylePriority.UseTextAlignment = False
            xrLabel11.Text = "Marseille,  13008"
            xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel12
            ' 
            xrLabel12.BorderColor = System.Drawing.Color.Transparent
            xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel12.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Country]")})
            xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(370.0327F, 118.75F)
            xrLabel12.Name = "xrLabel12"
            xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel12.SizeF = New System.Drawing.SizeF(144.792F, 25.00002F)
            xrLabel12.StyleName = "DetailData3"
            xrLabel12.StylePriority.UseBorderColor = False
            xrLabel12.StylePriority.UseBorders = False
            xrLabel12.StylePriority.UseFont = False
            xrLabel12.StylePriority.UseForeColor = False
            xrLabel12.StylePriority.UsePadding = False
            xrLabel12.StylePriority.UseTextAlignment = False
            xrLabel12.Text = "France"
            xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel13
            ' 
            xrLabel13.BackColor = System.Drawing.Color.Transparent
            xrLabel13.BorderColor = System.Drawing.Color.Transparent
            xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel13.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(370.034F, 147.9167F)
            xrLabel13.Name = "xrLabel13"
            xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel13.SizeF = New System.Drawing.SizeF(144.792F, 25F)
            xrLabel13.StyleName = "DetailData3"
            xrLabel13.StylePriority.UseBackColor = False
            xrLabel13.StylePriority.UseBorderColor = False
            xrLabel13.StylePriority.UseBorders = False
            xrLabel13.StylePriority.UseFont = False
            xrLabel13.StylePriority.UseForeColor = False
            xrLabel13.StylePriority.UsePadding = False
            xrLabel13.StylePriority.UseTextAlignment = False
            xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' SubBand1
            ' 
            SubBand1.Controls.AddRange(New XRControl() {xrTable5, xrLabel2})
            SubBand1.HeightF = 226.7708F
            SubBand1.Name = "SubBand1"
            ' 
            ' xrTable5
            ' 
            xrTable5.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 48.95833F)
            xrTable5.Name = "xrTable5"
            xrTable5.Rows.AddRange(New XRTableRow() {xrTableRow9, xrTableRow11, xrTableRow12, xrTableRow10, xrTableRow13})
            xrTable5.SizeF = New System.Drawing.SizeF(640.625F, 145.8333F)
            xrTable5.StylePriority.UseBorderColor = False
            xrTable5.StylePriority.UseBorders = False
            ' 
            ' xrLabel2
            ' 
            xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2.083345F)
            xrLabel2.Name = "xrLabel2"
            xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel2.SizeF = New System.Drawing.SizeF(640.625F, 35F)
            xrLabel2.StyleName = "Title"
            xrLabel2.StylePriority.UseBorderColor = False
            xrLabel2.StylePriority.UseBorders = False
            xrLabel2.StylePriority.UseFont = False
            xrLabel2.StylePriority.UseForeColor = False
            xrLabel2.StylePriority.UsePadding = False
            xrLabel2.StylePriority.UseTextAlignment = False
            xrLabel2.Text = "Monthly Billing Invoice Statement"
            xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow9
            ' 
            xrTableRow9.Cells.AddRange(New XRTableCell() {xrTableCell18, xrTableCell20})
            xrTableRow9.Name = "xrTableRow9"
            xrTableRow9.Weight = 10.208333833436589R
            ' 
            ' xrTableRow11
            ' 
            xrTableRow11.Cells.AddRange(New XRTableCell() {xrTableCell24, xrTableCell25})
            xrTableRow11.Name = "xrTableRow11"
            xrTableRow11.Weight = 10.208333401633816R
            ' 
            ' xrTableRow12
            ' 
            xrTableRow12.Cells.AddRange(New XRTableCell() {xrTableCell26, xrTableCell27})
            xrTableRow12.Name = "xrTableRow12"
            xrTableRow12.Weight = 10.208334312922753R
            ' 
            ' xrTableRow10
            ' 
            xrTableRow10.Cells.AddRange(New XRTableCell() {xrTableCell21, xrTableCell23})
            xrTableRow10.Name = "xrTableRow10"
            xrTableRow10.Weight = 10.208334312922753R
            ' 
            ' xrTableRow13
            ' 
            xrTableRow13.Cells.AddRange(New XRTableCell() {xrTableCell28, xrTableCell29})
            xrTableRow13.Name = "xrTableRow13"
            xrTableRow13.Weight = 10.208332922147653R
            ' 
            ' xrTableCell18
            ' 
            xrTableCell18.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell18.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell18.Multiline = True
            xrTableCell18.Name = "xrTableCell18"
            xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            xrTableCell18.StyleName = "DetailData3_Odd"
            xrTableCell18.StylePriority.UseFont = False
            xrTableCell18.StylePriority.UseForeColor = False
            xrTableCell18.StylePriority.UsePadding = False
            xrTableCell18.Text = "CONTACT NAME"
            xrTableCell18.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell20
            ' 
            xrTableCell20.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[ContactName]")})
            xrTableCell20.Name = "xrTableCell20"
            xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            xrTableCell20.StyleName = "DetailData3_Odd"
            xrTableCell20.StylePriority.UsePadding = False
            xrTableCell20.Text = "Laurence Lebihan"
            xrTableCell20.Weight = 0.31267396236756584R
            ' 
            ' xrTableCell24
            ' 
            xrTableCell24.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell24.Name = "xrTableCell24"
            xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            xrTableCell24.StyleName = "Headers"
            xrTableCell24.StylePriority.UseBackColor = False
            xrTableCell24.StylePriority.UseBorderColor = False
            xrTableCell24.StylePriority.UseBorders = False
            xrTableCell24.StylePriority.UseFont = False
            xrTableCell24.StylePriority.UseForeColor = False
            xrTableCell24.StylePriority.UsePadding = False
            xrTableCell24.Text = "CONTACT TITLE"
            xrTableCell24.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell25
            ' 
            xrTableCell25.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell25.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[ContactTitle]")})
            xrTableCell25.Name = "xrTableCell25"
            xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            xrTableCell25.StyleName = "DetailData3"
            xrTableCell25.StylePriority.UseBorderColor = False
            xrTableCell25.StylePriority.UseBorders = False
            xrTableCell25.StylePriority.UsePadding = False
            xrTableCell25.Text = "Owner"
            xrTableCell25.Weight = 0.31267396236756584R
            ' 
            ' xrTableCell26
            ' 
            xrTableCell26.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell26.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell26.Name = "xrTableCell26"
            xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            xrTableCell26.StyleName = "DetailData3_Odd"
            xrTableCell26.StylePriority.UseFont = False
            xrTableCell26.StylePriority.UseForeColor = False
            xrTableCell26.StylePriority.UsePadding = False
            xrTableCell26.Text = "BILLING STATEMENT DATE"
            xrTableCell26.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell27
            ' 
            xrTableCell27.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[BillingDate]")})
            xrTableCell27.Name = "xrTableCell27"
            xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            xrTableCell27.StyleName = "DetailData3_Odd"
            xrTableCell27.StylePriority.UsePadding = False
            xrTableCell27.Text = "9/5/2018"
            xrTableCell27.TextFormatString = "{0:M/d/yyyy}"
            xrTableCell27.Weight = 0.31267396236756584R
            ' 
            ' xrTableCell21
            ' 
            xrTableCell21.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell21.Name = "xrTableCell21"
            xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            xrTableCell21.StyleName = "Headers"
            xrTableCell21.StylePriority.UseBackColor = False
            xrTableCell21.StylePriority.UseBorderColor = False
            xrTableCell21.StylePriority.UseBorders = False
            xrTableCell21.StylePriority.UseFont = False
            xrTableCell21.StylePriority.UseForeColor = False
            xrTableCell21.StylePriority.UsePadding = False
            xrTableCell21.Text = "BILLING PERIOD"
            xrTableCell21.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell23
            ' 
            xrTableCell23.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell23.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "FormatString('{0:M/d/yyyy}',[BillingPeriodStart] ) + ' To ' + FormatString('{0:M/" & "d/yyyy}',[BillingPeriodEnd])")})
            xrTableCell23.Name = "xrTableCell23"
            xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            xrTableCell23.StyleName = "DetailData3"
            xrTableCell23.StylePriority.UseBorderColor = False
            xrTableCell23.StylePriority.UseBorders = False
            xrTableCell23.StylePriority.UsePadding = False
            xrTableCell23.Text = "8/4/2018 To 8/17/2018"
            xrTableCell23.Weight = 0.31267396236756584R
            ' 
            ' xrTableCell28
            ' 
            xrTableCell28.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell28.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell28.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell28.Name = "xrTableCell28"
            xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F)
            xrTableCell28.StyleName = "DetailData3_Odd"
            xrTableCell28.StylePriority.UseBorderColor = False
            xrTableCell28.StylePriority.UseBorders = False
            xrTableCell28.StylePriority.UseFont = False
            xrTableCell28.StylePriority.UseForeColor = False
            xrTableCell28.StylePriority.UsePadding = False
            xrTableCell28.Text = "TERMS"
            xrTableCell28.Weight = 0.13177048207687855R
            ' 
            ' xrTableCell29
            ' 
            xrTableCell29.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTableCell29.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Terms]")})
            xrTableCell29.Name = "xrTableCell29"
            xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F)
            xrTableCell29.StyleName = "DetailData3_Odd"
            xrTableCell29.StylePriority.UseBorderColor = False
            xrTableCell29.StylePriority.UseBorders = False
            xrTableCell29.StylePriority.UsePadding = False
            xrTableCell29.Text = "End of month"
            xrTableCell29.Weight = 0.31267396236756584R
            ' 
            ' groupHeaderBand1
            ' 
            groupHeaderBand1.Controls.AddRange(New XRControl() {xrTable2})
            groupHeaderBand1.GroupUnion = GroupUnion.WithFirstDetail
            groupHeaderBand1.HeightF = 29.16667F
            groupHeaderBand1.Name = "groupHeaderBand1"
            ' 
            ' detailBand2
            ' 
            detailBand2.Controls.AddRange(New XRControl() {xrTable3})
            detailBand2.EvenStyleName = "DetailData3"
            detailBand2.HeightF = 29.16667F
            detailBand2.Name = "detailBand2"
            ' 
            ' ReportHeader
            ' 
            ReportHeader.Controls.AddRange(New XRControl() {xrLabel3})
            ReportHeader.HeightF = 46.875F
            ReportHeader.Name = "ReportHeader"
            ' 
            ' ReportFooter
            ' 
            ReportFooter.Controls.AddRange(New XRControl() {xrTable1})
            ReportFooter.HeightF = 98.95834F
            ReportFooter.Name = "ReportFooter"
            ReportFooter.PrintAtBottom = True
            ' 
            ' xrTable2
            ' 
            xrTable2.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTable2.BorderWidth = 1.2F
            xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(4.238557E-05F, 0F)
            xrTable2.Name = "xrTable2"
            xrTable2.Rows.AddRange(New XRTableRow() {xrTableRow3})
            xrTable2.SizeF = New System.Drawing.SizeF(640.625F, 29.16667F)
            xrTable2.StyleName = "Headers"
            xrTable2.StylePriority.UseBorderWidth = False
            ' 
            ' xrTableRow3
            ' 
            xrTableRow3.Cells.AddRange(New XRTableCell() {xrTableCell7, xrTableCell8, xrTableCell9, xrTableCell11})
            xrTableRow3.Name = "xrTableRow3"
            xrTableRow3.StyleName = "Headers"
            xrTableRow3.Weight = 1.0416666991890433R
            ' 
            ' xrTableCell7
            ' 
            xrTableCell7.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell7.BorderWidth = 2F
            xrTableCell7.Name = "xrTableCell7"
            xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            xrTableCell7.StyleName = "Headers"
            xrTableCell7.StylePriority.UseBorderColor = False
            xrTableCell7.StylePriority.UseBorders = False
            xrTableCell7.StylePriority.UseBorderWidth = False
            xrTableCell7.StylePriority.UsePadding = False
            xrTableCell7.Text = "DATE"
            xrTableCell7.Weight = 0.26282052324906857R
            ' 
            ' xrTableCell8
            ' 
            xrTableCell8.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell8.BorderWidth = 2F
            xrTableCell8.Name = "xrTableCell8"
            xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell8.StyleName = "Headers"
            xrTableCell8.StylePriority.UseBorderColor = False
            xrTableCell8.StylePriority.UseBorders = False
            xrTableCell8.StylePriority.UseBorderWidth = False
            xrTableCell8.Text = "DESCRIPTION"
            xrTableCell8.Weight = 0.2264102459817007R
            ' 
            ' xrTableCell9
            ' 
            xrTableCell9.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell9.BorderWidth = 2F
            xrTableCell9.Name = "xrTableCell9"
            xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell9.StyleName = "Headers"
            xrTableCell9.StylePriority.UseBorderColor = False
            xrTableCell9.StylePriority.UseBorders = False
            xrTableCell9.StylePriority.UseBorderWidth = False
            xrTableCell9.StylePriority.UseTextAlignment = False
            xrTableCell9.Text = "AMOUNT"
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell9.Weight = 0.24679486710782655R
            ' 
            ' xrTableCell11
            ' 
            xrTableCell11.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168)
            xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell11.BorderWidth = 2F
            xrTableCell11.Name = "xrTableCell11"
            xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F)
            xrTableCell11.StyleName = "Headers"
            xrTableCell11.StylePriority.UseBorderColor = False
            xrTableCell11.StylePriority.UseBorders = False
            xrTableCell11.StylePriority.UseBorderWidth = False
            xrTableCell11.StylePriority.UsePadding = False
            xrTableCell11.StylePriority.UseTextAlignment = False
            xrTableCell11.Text = "BALANCE"
            xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell11.Weight = 0.26397427885888147R
            ' 
            ' xrTable3
            ' 
            xrTable3.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrTable3.BorderWidth = 0.8F
            xrTable3.EvenStyleName = "DetailData3_Odd"
            xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(5.298196E-05F, 0F)
            xrTable3.Name = "xrTable3"
            xrTable3.OddStyleName = "DetailData3"
            xrTable3.Rows.AddRange(New XRTableRow() {xrTableRow4})
            xrTable3.SizeF = New System.Drawing.SizeF(640.6249F, 29.16667F)
            xrTable3.StylePriority.UseBorderColor = False
            xrTable3.StylePriority.UseBorders = False
            xrTable3.StylePriority.UseBorderWidth = False
            ' 
            ' xrTableRow4
            ' 
            xrTableRow4.Cells.AddRange(New XRTableCell() {xrTableCell12, xrTableCell13, xrTableCell15, xrTableCell16})
            xrTableRow4.Name = "xrTableRow4"
            xrTableRow4.Weight = 13.416666666666666R
            ' 
            ' xrTableCell12
            ' 
            xrTableCell12.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Date]")})
            xrTableCell12.Name = "xrTableCell12"
            xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            xrTableCell12.StyleName = "DetailData3"
            xrTableCell12.StylePriority.UsePadding = False
            xrTableCell12.Text = "9/9/2018"
            xrTableCell12.TextFormatString = "{0:M/d/yyyy}"
            xrTableCell12.Weight = 0.22071864610205361R
            ' 
            ' xrTableCell13
            ' 
            xrTableCell13.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Description]")})
            xrTableCell13.Name = "xrTableCell13"
            xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell13.StyleName = "DetailData3"
            xrTableCell13.StylePriority.UsePadding = False
            xrTableCell13.Text = "Bill - Rent"
            xrTableCell13.Weight = 0.190140978530862R
            ' 
            ' xrTableCell15
            ' 
            xrTableCell15.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Iif(Contains([Description], 'Balance'), '', [Amount])")})
            xrTableCell15.Name = "xrTableCell15"
            xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            xrTableCell15.StyleName = "DetailData3"
            xrTableCell15.StylePriority.UsePadding = False
            xrTableCell15.StylePriority.UseTextAlignment = False
            xrTableCell15.Text = "$210.00"
            xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell15.TextFormatString = "{0:$#,##.00}"
            xrTableCell15.Weight = 0.20726019714891966R
            ' 
            ' xrTableCell16
            ' 
            xrTableCell16.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumRunningSum([Amount])"), New ExpressionBinding("BeforePrint", "Font.Name", "'Arial'"), New ExpressionBinding("BeforePrint", "Font.Size", "8"), New ExpressionBinding("BeforePrint", "Font.Bold", "[DataSource.CurrentRowIndex] == [DataSource.RowCount] -1")})
            xrTableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell16.Name = "xrTableCell16"
            xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 10, 0, 0, 100F)
            xrTableCell16.StyleName = "DetailData3"
            xrTableCell16.StylePriority.UseFont = False
            xrTableCell16.StylePriority.UsePadding = False
            xrTableCell16.StylePriority.UseTextAlignment = False
            xrSummary1.Running = SummaryRunning.Report
            xrTableCell16.Summary = xrSummary1
            xrTableCell16.Text = "xrTableCell16"
            xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell16.TextFormatString = "{0:$#,##.00}"
            xrTableCell16.Weight = 0.22168754127396906R
            ' 
            ' xrLabel3
            ' 
            xrLabel3.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75)
            xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2.083306F)
            xrLabel3.Name = "xrLabel3"
            xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            xrLabel3.SizeF = New System.Drawing.SizeF(640.625F, 27.94597F)
            xrLabel3.StyleName = "Title"
            xrLabel3.StylePriority.UseBorderColor = False
            xrLabel3.StylePriority.UseBorders = False
            xrLabel3.StylePriority.UseFont = False
            xrLabel3.StylePriority.UseForeColor = False
            xrLabel3.StylePriority.UsePadding = False
            xrLabel3.StylePriority.UseTextAlignment = False
            xrLabel3.Text = "Payments and Adjustments"
            xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTable1
            ' 
            xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            xrTable1.Name = "xrTable1"
            xrTable1.Rows.AddRange(New XRTableRow() {xrTableRow1, xrTableRow2})
            xrTable1.SizeF = New System.Drawing.SizeF(650F, 98.95834F)
            ' 
            ' xrTableRow1
            ' 
            xrTableRow1.Cells.AddRange(New XRTableCell() {xrTableCell3, xrTableCell1, xrTableCell2})
            xrTableRow1.KeepTogether = False
            xrTableRow1.Name = "xrTableRow1"
            xrTableRow1.Weight = 0.299592056274414R
            ' 
            ' xrTableRow2
            ' 
            xrTableRow2.Cells.AddRange(New XRTableCell() {xrTableCell6, xrTableCell4, xrTableCell5})
            xrTableRow2.KeepTogether = False
            xrTableRow2.Name = "xrTableRow2"
            xrTableRow2.Weight = 0.70040771484374975R
            ' 
            ' xrTableCell3
            ' 
            xrTableCell3.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246)
            xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right
            xrTableCell3.BorderWidth = 2F
            xrTableCell3.Multiline = True
            xrTableCell3.Name = "xrTableCell3"
            xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell3.StyleName = "SummaryTitles"
            xrTableCell3.StylePriority.UseBorderColor = False
            xrTableCell3.StylePriority.UseBorders = False
            xrTableCell3.StylePriority.UseBorderWidth = False
            xrTableCell3.StylePriority.UseTextAlignment = False
            xrTableCell3.Text = "NEW CHARGES" & Microsoft.VisualBasic.Constants.vbCrLf
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            xrTableCell3.Weight = 0.9903846153846152R
            ' 
            ' xrTableCell1
            ' 
            xrTableCell1.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246)
            xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right
            xrTableCell1.BorderWidth = 2F
            xrTableCell1.Multiline = True
            xrTableCell1.Name = "xrTableCell1"
            xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell1.StyleName = "SummaryTitles"
            xrTableCell1.StylePriority.UseBorderColor = False
            xrTableCell1.StylePriority.UseBorders = False
            xrTableCell1.StylePriority.UseBorderWidth = False
            xrTableCell1.StylePriority.UseTextAlignment = False
            xrTableCell1.Text = "PAYMENTS"
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            xrTableCell1.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            xrTableCell2.Multiline = True
            xrTableCell2.Name = "xrTableCell2"
            xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrTableCell2.StyleName = "SummaryTitles"
            xrTableCell2.StylePriority.UseBorderColor = False
            xrTableCell2.StylePriority.UseBorders = False
            xrTableCell2.StylePriority.UseBorderWidth = False
            xrTableCell2.StylePriority.UsePadding = False
            xrTableCell2.StylePriority.UseTextAlignment = False
            xrTableCell2.Text = "CURRENT BALANCE"
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            xrTableCell2.Weight = 1.0096153846153846R
            ' 
            ' xrTableCell6
            ' 
            xrTableCell6.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246)
            xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Right
            xrTableCell6.BorderWidth = 2F
            xrTableCell6.CanGrow = False
            xrTableCell6.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[][[Amount] > 0 And !Contains([Description], 'Balance')].Sum([Amount])")})
            xrTableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell6.Multiline = True
            xrTableCell6.Name = "xrTableCell6"
            xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F)
            xrTableCell6.StyleName = "SummaryValues"
            xrTableCell6.StylePriority.UseBorderColor = False
            xrTableCell6.StylePriority.UseBorders = False
            xrTableCell6.StylePriority.UseBorderWidth = False
            xrTableCell6.StylePriority.UseFont = False
            xrTableCell6.StylePriority.UsePadding = False
            xrTableCell6.Text = "+$210.00"
            xrTableCell6.TextFormatString = "+{0:$#,##.00}"
            xrTableCell6.Weight = 0.9903846153846152R
            ' 
            ' xrTableCell4
            ' 
            xrTableCell4.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246)
            xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Right
            xrTableCell4.BorderWidth = 2F
            xrTableCell4.CanGrow = False
            xrTableCell4.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[][[Amount] < 0].Sum([Amount])")})
            xrTableCell4.Font = New DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell4.Multiline = True
            xrTableCell4.Name = "xrTableCell4"
            xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F)
            xrTableCell4.StyleName = "SummaryValues"
            xrTableCell4.StylePriority.UseBorderColor = False
            xrTableCell4.StylePriority.UseBorders = False
            xrTableCell4.StylePriority.UseBorderWidth = False
            xrTableCell4.StylePriority.UseFont = False
            xrTableCell4.StylePriority.UsePadding = False
            xrTableCell4.Text = "-$280.00"
            xrTableCell4.TextFormatString = "{0:$#,##.00}"
            xrTableCell4.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            xrTableCell5.CanGrow = False
            xrTableCell5.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Sum([Amount])")})
            xrTableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell5.Multiline = True
            xrTableCell5.Name = "xrTableCell5"
            xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F)
            xrTableCell5.StyleName = "SummaryValues"
            xrTableCell5.StylePriority.UseBorderColor = False
            xrTableCell5.StylePriority.UseBorders = False
            xrTableCell5.StylePriority.UseBorderWidth = False
            xrTableCell5.StylePriority.UseFont = False
            xrTableCell5.StylePriority.UsePadding = False
            xrTableCell5.Text = "$1,480.00"
            xrTableCell5.TextFormatString = "{0:$#,##.00}"
            xrTableCell5.Weight = 1.0096153846153846R
            ' 
            ' objectDataSource1
            ' 
            parameter1.Name = "rowCount"
            parameter1.Type = GetType(DevExpress.DataAccess.Expression)
            parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.RowCountParameter]", GetType(Integer))
            objectConstructorInfo1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {parameter1})
            objectDataSource1.Constructor = objectConstructorInfo1
            objectDataSource1.DataSource = GetType(DataItemList)
            objectDataSource1.Name = "objectDataSource1"
            ' 
            ' Title
            ' 
            Title.BackColor = System.Drawing.Color.Transparent
            Title.BorderColor = System.Drawing.Color.Black
            Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Title.BorderWidth = 1F
            Title.Font = New DevExpress.Drawing.DXFont("Arial", 13F, DevExpress.Drawing.DXFontStyle.Bold)
            Title.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
            Title.Name = "Title"
            ' 
            ' ReportTitleCaption
            ' 
            ReportTitleCaption.BackColor = System.Drawing.Color.Transparent
            ReportTitleCaption.BorderColor = System.Drawing.Color.Transparent
            ReportTitleCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            ReportTitleCaption.Font = New DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            ReportTitleCaption.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
            ReportTitleCaption.Name = "ReportTitleCaption"
            ReportTitleCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ReportTitleCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3
            ' 
            DetailData3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            DetailData3.ForeColor = System.Drawing.Color.Black
            DetailData3.Name = "DetailData3"
            DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(249, 250, 252)
            DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            DetailData3_Odd.BorderWidth = 1F
            DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            DetailData3_Odd.Name = "DetailData3_Odd"
            DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            PageInfo.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
            PageInfo.Name = "PageInfo"
            PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' Headers
            ' 
            Headers.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Headers.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168)
            Headers.Name = "Headers"
            Headers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' SummaryTitles
            ' 
            SummaryTitles.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            SummaryTitles.ForeColor = System.Drawing.Color.FromArgb(171, 185, 214)
            SummaryTitles.Name = "SummaryTitles"
            SummaryTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' SummaryValues
            ' 
            SummaryValues.Font = New DevExpress.Drawing.DXFont("Arial", 23F)
            SummaryValues.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168)
            SummaryValues.Name = "SummaryValues"
            SummaryValues.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 16, 0, 100F)
            SummaryValues.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' RowCountParameter
            ' 
            RowCountParameter.Description = "Row Count"
            RowCountParameter.Name = "RowCountParameter"
            RowCountParameter.Type = GetType(Integer)
            RowCountParameter.ValueInfo = "100000"
            ' 
            ' Report
            ' 
            Bands.AddRange(New Band() {topMarginBand1, bottomMarginBand1, detailBand1, detailReportBand1})
            ComponentStorage.AddRange(New System.ComponentModel.IComponent() {objectDataSource1})
            DataSource = objectDataSource1
            DisplayName = "Large Dataset"
            Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {RowCountParameter})
            RequestParameters = False
            StyleSheet.AddRange(New XRControlStyle() {Title, ReportTitleCaption, DetailData3, DetailData3_Odd, PageInfo, Headers, SummaryTitles, SummaryValues})
            Version = "23.1"
            CType(xrTable5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
