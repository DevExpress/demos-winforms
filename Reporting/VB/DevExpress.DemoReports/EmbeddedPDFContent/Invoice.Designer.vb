Namespace XtraReportsDemos.EmbeddedPDFContent

    Partial Class Invoice

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.EmbeddedPDFContent.Invoice))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim customJsonSource1 As DevExpress.DataAccess.Json.CustomJsonSource = New DevExpress.DataAccess.Json.CustomJsonSource()
            Dim jsonSchemaNode1 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("root", True)
            Dim jsonSchemaNode2 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("InvoiceNumber", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode3 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("OrderDate", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of System.DateTime)))
            Dim jsonSchemaNode4 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Customer", True)
            Dim jsonSchemaNode5 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Name", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode6 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("HomeOffice_Line", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode7 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("HomeOffice_City", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode8 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("HomeOffice_StateName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode9 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("HomeOffice_ZipCode", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode10 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Store", True)
            Dim jsonSchemaNode11 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Address_City", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode12 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Address_Line", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode13 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Address_StateName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode14 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Address_ZipCode", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode15 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Employee", True)
            Dim jsonSchemaNode16 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("FullName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode17 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("PONumber", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode18 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ShipMethod", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode19 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("OrderTerms", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode20 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("OrderItems", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
            Dim jsonSchemaNode21 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ProductName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
            Dim jsonSchemaNode22 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ProductPrice", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode23 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ProductUnits", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode24 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Discount", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode25 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Total", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode26 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ShippingAmount", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode27 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("TotalAmount", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of Long)))
            Dim jsonSchemaNode28 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ShipDate", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(System.Nullable(Of System.DateTime)))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBoxLogo = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable5 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrPdfSignature1 = New DevExpress.XtraReports.UI.XRPdfSignature()
            Me.xrTable6 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
            Me.General = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.BillingShippingHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Comments = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailTableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.HeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TableOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 46F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Arial", 12F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(751F, 50F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseTextAlignment = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrPageInfo1.TextFormatString = "Page {0} of {1}"
            ' 
            ' Detail
            ' 
            Me.Detail.Expanded = False
            Me.Detail.FillEmptySpace = True
            Me.Detail.HeightF = 0F
            Me.Detail.Name = "Detail"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1, Me.xrTable1, Me.xrPictureBoxLogo, Me.xrTable4})
            Me.ReportHeader.HeightF = 423.2682F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((249)))))), (CInt(((CByte((251)))))))
            Me.panel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable3})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(25.33332F, 116.0539F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(684.0278F, 154.0404F)
            Me.panel1.StylePriority.UseBackColor = False
            Me.panel1.StylePriority.UseBorders = False
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(23.89176F, 26.95041F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow4, Me.tableRow1, Me.xrTableRow5, Me.xrTableRow6})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(621.0532F, 127.09F)
            Me.xrTable3.StylePriority.UseTextAlignment = False
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2, Me.xrTableCell6})
            Me.xrTableRow4.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.xrTableRow4.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((166)))))), (CInt(((CByte((166)))))), (CInt(((CByte((166)))))))
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.StylePriority.UseFont = False
            Me.xrTableRow4.StylePriority.UseForeColor = False
            Me.xrTableRow4.Weight = 0.8269312838050884R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.CanGrow = False
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell2.StyleName = "BillingShippingHeaderStyle"
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.Text = "Billing Address"
            Me.xrTableCell2.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.CanGrow = False
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell6.StyleName = "BillingShippingHeaderStyle"
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.Text = "Shipping Address"
            Me.xrTableCell6.Weight = 1.7439938465818574R
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.tableRow1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((166)))))), (CInt(((CByte((166)))))), (CInt(((CByte((166)))))))
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.StylePriority.UseFont = False
            Me.tableRow1.StylePriority.UseForeColor = False
            Me.tableRow1.Weight = 0.34950031364622997R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.CanGrow = False
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.tableCell1.StyleName = "BillingShippingHeaderStyle"
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.Weight = 1.2560061534181426R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.CanGrow = False
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.tableCell2.StyleName = "BillingShippingHeaderStyle"
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.Weight = 1.7439938465818574R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow5.Font = New DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.StylePriority.UseFont = False
            Me.xrTableRow5.Weight = 0.88845332146656031R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.CanGrow = False
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")})
            Me.xrTableCell7.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell7.StyleName = "General"
            Me.xrTableCell7.StylePriority.UseFont = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")})
            Me.xrTableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell8.StyleName = "General"
            Me.xrTableCell8.StylePriority.UseFont = False
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.Weight = 1.7439938465818574R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow6.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.StylePriority.UseFont = False
            Me.xrTableRow6.Weight = 3.0187164242698779R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Multiline = True
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell9.StyleName = "General"
            Me.xrTableCell9.StylePriority.UsePadding = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Home Office" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "[Customer.HomeOffice_Line]" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "[Customer.HomeOffice_City], [Customer.Ho" & "meOffice_StateName] [Customer.HomeOffice_ZipCode]"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell9.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTableCell10.StyleName = "General"
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "[Store.Address_City] Store" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "[Store.Address_Line]" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "[Store.Address_City], [Store.Ad" & "dress_StateName] [Store.Address_ZipCode]"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell10.Weight = 1.7439938465818574R
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(21.19776F, 29.0362F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(448.868F, 65.01773F)
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UsePadding = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1})
            Me.xrTableRow1.Font = New DevExpress.Drawing.DXFont("Arial", 14F)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.StylePriority.UseFont = False
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.CanGrow = False
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableCell1.StyleName = "HeaderStyle"
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.StylePriority.UseForeColor = False
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Invoice # [InvoiceNumber]"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 0.3656307129798903R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 7.1843158466786257R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.CanGrow = False
            Me.xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StyleName = "General"
            Me.xrTableCell3.StylePriority.UseFont = False
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "[OrderDate!MM/dd/yy]"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell3.Weight = 0.3656307129798903R
            ' 
            ' xrPictureBoxLogo
            ' 
            Me.xrPictureBoxLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBoxLogo.ImageSource"))
            Me.xrPictureBoxLogo.LocationFloat = New DevExpress.Utils.PointFloat(508.289F, 10.00001F)
            Me.xrPictureBoxLogo.Name = "xrPictureBoxLogo"
            Me.xrPictureBoxLogo.SizeF = New System.Drawing.SizeF(201.0721F, 59.53684F)
            Me.xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable4.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(23.95332F, 294.6833F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow7, Me.xrTableRow8})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(685.4077F, 65.20313F)
            Me.xrTable4.StylePriority.UseBorders = False
            Me.xrTable4.StylePriority.UseFont = False
            Me.xrTable4.StylePriority.UseTextAlignment = False
            Me.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16, Me.xrTableCell17})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F)
            Me.xrTableRow7.StylePriority.UseBackColor = False
            Me.xrTableRow7.StylePriority.UsePadding = False
            Me.xrTableRow7.Weight = 1.3351953125R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.xrTableCell11.StyleName = "TableHeaderStyle"
            Me.xrTableCell11.StylePriority.UsePadding = False
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "Sales Rep."
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell11.Weight = 0.87337124463981453R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 2, 0, 100F)
            Me.xrTableCell12.StyleName = "TableHeaderStyle"
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.Text = "PO #"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell12.Weight = 0.542657708540922R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.StyleName = "TableHeaderStyle"
            Me.xrTableCell14.Text = "Ship Date"
            Me.xrTableCell14.Weight = 0.69479935035123674R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.StyleName = "TableHeaderStyle"
            Me.xrTableCell15.Text = "Ship Via"
            Me.xrTableCell15.Weight = 0.92323718365925511R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.StyleName = "TableHeaderStyle"
            Me.xrTableCell16.Text = "FOB"
            Me.xrTableCell16.Weight = 0.54709842411275023R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.StyleName = "TableHeaderStyle"
            Me.xrTableCell17.Text = "Terms"
            Me.xrTableCell17.Weight = 0.87980333477995443R
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((229)))))), (CInt(((CByte((229)))))))
            Me.xrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell13, Me.xrTableCell18, Me.xrTableCell19, Me.xrTableCell20, Me.xrTableCell21, Me.xrTableCell22})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.StylePriority.UseBorderColor = False
            Me.xrTableRow8.StylePriority.UseBorders = False
            Me.xrTableRow8.Weight = 1.272927903327012R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Employee.FullName]")})
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.xrTableCell13.StyleName = "General"
            Me.xrTableCell13.StylePriority.UsePadding = False
            Me.xrTableCell13.StylePriority.UseTextAlignment = False
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell13.Weight = 0.87337124463981453R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PONumber]")})
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.xrTableCell18.StyleName = "General"
            Me.xrTableCell18.StylePriority.UsePadding = False
            Me.xrTableCell18.StylePriority.UseTextAlignment = False
            Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell18.Weight = 0.54265752408010282R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetDate([ShipDate])")})
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.StyleName = "General"
            Me.xrTableCell19.TextFormatString = "{0:MM/dd/yyyy}"
            Me.xrTableCell19.Weight = 0.69479976538807975R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif([ShipMethod] = 0, 'Ground', [ShipMethod] = 1, 'Air', '-')")})
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.StyleName = "General"
            Me.xrTableCell20.Weight = 0.9232372439369031R
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Text = " - "
            Me.xrTableCell21.Weight = 0.54709823257070933R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderTerms]")})
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.StyleName = "General"
            Me.xrTableCell22.Weight = 0.87980323546832329R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable5})
            Me.GroupHeader1.HeightF = 32.96697F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTable5
            ' 
            Me.xrTable5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((242)))))), (CInt(((CByte((242)))))), (CInt(((CByte((242)))))))
            Me.xrTable5.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable5.Font = New DevExpress.Drawing.DXFont("Arial", 13F)
            Me.xrTable5.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((112)))))), (CInt(((CByte((116)))))))
            Me.xrTable5.LocationFloat = New DevExpress.Utils.PointFloat(23.95326F, 0.3982934F)
            Me.xrTable5.Name = "xrTable5"
            Me.xrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow9})
            Me.xrTable5.SizeF = New System.Drawing.SizeF(685.4077F, 31.25F)
            Me.xrTable5.StylePriority.UseBackColor = False
            Me.xrTable5.StylePriority.UseBorders = False
            Me.xrTable5.StylePriority.UseFont = False
            Me.xrTable5.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow9
            ' 
            Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell23, Me.xrTableCell24, Me.xrTableCell26, Me.xrTableCell27, Me.xrTableCell25})
            Me.xrTableRow9.Name = "xrTableRow9"
            Me.xrTableRow9.StylePriority.UseBorders = False
            Me.xrTableRow9.Weight = 1.031581923608158R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 100F)
            Me.xrTableCell23.StyleName = "DetailTableHeaderStyle"
            Me.xrTableCell23.StylePriority.UsePadding = False
            Me.xrTableCell23.StylePriority.UseTextAlignment = False
            Me.xrTableCell23.Text = "Description"
            Me.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell23.Weight = 0.74283632613826966R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 8, 0, 0, 100F)
            Me.xrTableCell24.StyleName = "DetailTableHeaderStyle"
            Me.xrTableCell24.StylePriority.UsePadding = False
            Me.xrTableCell24.StylePriority.UseTextAlignment = False
            Me.xrTableCell24.Text = "Unit Price"
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell24.Weight = 0.69508230296883622R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F)
            Me.xrTableCell26.StyleName = "DetailTableHeaderStyle"
            Me.xrTableCell26.StylePriority.UsePadding = False
            Me.xrTableCell26.StylePriority.UseTextAlignment = False
            Me.xrTableCell26.Text = "Quantity"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell26.Weight = 0.52416638509731162R
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell27.StyleName = "DetailTableHeaderStyle"
            Me.xrTableCell27.StylePriority.UsePadding = False
            Me.xrTableCell27.StylePriority.UseTextAlignment = False
            Me.xrTableCell27.Text = "Discount"
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell27.Weight = 0.52416638509731162R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 100F)
            Me.xrTableCell25.StyleName = "DetailTableHeaderStyle"
            Me.xrTableCell25.StylePriority.UsePadding = False
            Me.xrTableCell25.StylePriority.UseTextAlignment = False
            Me.xrTableCell25.Text = "Total"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell25.Weight = 0.52416638509731162R
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPdfSignature1, Me.xrTable6})
            Me.GroupFooter1.HeightF = 166.4309F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PrintAtBottom = True
            ' 
            ' xrPdfSignature1
            ' 
            Me.xrPdfSignature1.LocationFloat = New DevExpress.Utils.PointFloat(23.95325F, 43.69211F)
            Me.xrPdfSignature1.Name = "xrPdfSignature1"
            Me.xrPdfSignature1.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 100F)
            Me.xrPdfSignature1.SizeF = New System.Drawing.SizeF(391.1932F, 96.45964F)
            ' 
            ' xrTable6
            ' 
            Me.xrTable6.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable6.LocationFloat = New DevExpress.Utils.PointFloat(479.3797F, 43.69212F)
            Me.xrTable6.Name = "xrTable6"
            Me.xrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow10, Me.xrTableRow11, Me.xrTableRow12})
            Me.xrTable6.SizeF = New System.Drawing.SizeF(229.59F, 98.34043F)
            Me.xrTable6.StylePriority.UseBorders = False
            ' 
            ' xrTableRow10
            ' 
            Me.xrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell28, Me.xrTableCell29})
            Me.xrTableRow10.Name = "xrTableRow10"
            Me.xrTableRow10.Weight = 1.6445612561757967R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((249)))))), (CInt(((CByte((250)))))))
            Me.xrTableCell28.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell28.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell28.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F)
            Me.xrTableCell28.StyleName = "TableOddStyle"
            Me.xrTableCell28.StylePriority.UseBackColor = False
            Me.xrTableCell28.StylePriority.UseBorderColor = False
            Me.xrTableCell28.StylePriority.UseBorders = False
            Me.xrTableCell28.StylePriority.UseFont = False
            Me.xrTableCell28.StylePriority.UsePadding = False
            Me.xrTableCell28.StylePriority.UseTextAlignment = False
            Me.xrTableCell28.Text = "Sub Total"
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell28.Weight = 1.8279264198044849R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((249)))))), (CInt(((CByte((250)))))))
            Me.xrTableCell29.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell29.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([OrderItems].[Total])")})
            Me.xrTableCell29.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 2, 0, 100F)
            Me.xrTableCell29.StyleName = "TableOddStyle"
            Me.xrTableCell29.StylePriority.UseBackColor = False
            Me.xrTableCell29.StylePriority.UseBorderColor = False
            Me.xrTableCell29.StylePriority.UseBorders = False
            Me.xrTableCell29.StylePriority.UseFont = False
            Me.xrTableCell29.StylePriority.UsePadding = False
            Me.xrTableCell29.StylePriority.UseTextAlignment = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell29.Summary = xrSummary1
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell29.TextFormatString = "{0:$#,#}"
            Me.xrTableCell29.Weight = 1.2142824291082539R
            ' 
            ' xrTableRow11
            ' 
            Me.xrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell30, Me.xrTableCell31})
            Me.xrTableRow11.Name = "xrTableRow11"
            Me.xrTableRow11.Weight = 1.5315354078890038R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.BackColor = System.Drawing.Color.Transparent
            Me.xrTableCell30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell30.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.xrTableCell30.StyleName = "TableHeaderStyle"
            Me.xrTableCell30.StylePriority.UseBackColor = False
            Me.xrTableCell30.StylePriority.UseBorders = False
            Me.xrTableCell30.StylePriority.UseFont = False
            Me.xrTableCell30.StylePriority.UsePadding = False
            Me.xrTableCell30.StylePriority.UseTextAlignment = False
            Me.xrTableCell30.Text = "Shipping"
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell30.Weight = 1.82792864409057R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.BackColor = System.Drawing.Color.Transparent
            Me.xrTableCell31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShippingAmount]")})
            Me.xrTableCell31.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell31.StyleName = "TableHeaderStyle"
            Me.xrTableCell31.StylePriority.UseBackColor = False
            Me.xrTableCell31.StylePriority.UseBorders = False
            Me.xrTableCell31.StylePriority.UseFont = False
            Me.xrTableCell31.StylePriority.UsePadding = False
            Me.xrTableCell31.StylePriority.UseTextAlignment = False
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell31.TextFormatString = "{0:$#,#}"
            Me.xrTableCell31.Weight = 1.2142813010470537R
            ' 
            ' xrTableRow12
            ' 
            Me.xrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell32, Me.xrTableCell33})
            Me.xrTableRow12.Name = "xrTableRow12"
            Me.xrTableRow12.Weight = 1.6255815606400634R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.BackColor = System.Drawing.Color.Transparent
            Me.xrTableCell32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F)
            Me.xrTableCell32.StyleName = "TableHeaderStyle"
            Me.xrTableCell32.StylePriority.UseBackColor = False
            Me.xrTableCell32.StylePriority.UseBorders = False
            Me.xrTableCell32.StylePriority.UseFont = False
            Me.xrTableCell32.StylePriority.UsePadding = False
            Me.xrTableCell32.StylePriority.UseTextAlignment = False
            Me.xrTableCell32.Text = "Total Due"
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell32.Weight = 1.82792864409057R
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.BackColor = System.Drawing.Color.Transparent
            Me.xrTableCell33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableCell33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")})
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell33.StyleName = "TableHeaderStyle"
            Me.xrTableCell33.StylePriority.UseBackColor = False
            Me.xrTableCell33.StylePriority.UseBorders = False
            Me.xrTableCell33.StylePriority.UseFont = False
            Me.xrTableCell33.StylePriority.UsePadding = False
            Me.xrTableCell33.StylePriority.UseTextAlignment = False
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell33.TextFormatString = "{0:$#,#}"
            Me.xrTableCell33.Weight = 1.2142813010470537R
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubreport1})
            Me.ReportFooter.HeightF = 39.94839F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.GenerateOwnPages = True
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ReportSource = New XtraReportsDemos.EmbeddedPDFContent.Specification()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(751F, 39.94839F)
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
            Me.DetailReport.DataMember = "OrderItems"
            Me.DetailReport.DataSource = Me.jsonDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail1.FillEmptySpace = True
            Me.Detail1.HeightF = 32.55208F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(25.33332F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.OddStyleName = "TableOddStyle"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow13})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(684.0276F, 31.25F)
            Me.xrTable2.StylePriority.UseBorders = False
            ' 
            ' xrTableRow13
            ' 
            Me.xrTableRow13.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((231)))))), (CInt(((CByte((235)))))))
            Me.xrTableRow13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell34, Me.xrTableCell35, Me.xrTableCell36, Me.xrTableCell37, Me.xrTableCell38})
            Me.xrTableRow13.Name = "xrTableRow13"
            Me.xrTableRow13.StylePriority.UseBorderColor = False
            Me.xrTableRow13.StylePriority.UseBorders = False
            Me.xrTableRow13.Weight = 3.021817127268994R
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell34.Multiline = True
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 100F)
            Me.xrTableCell34.StyleName = "General"
            Me.xrTableCell34.StylePriority.UseFont = False
            Me.xrTableCell34.StylePriority.UsePadding = False
            Me.xrTableCell34.StylePriority.UseTextAlignment = False
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell34.Weight = 180.88969053070841R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductPrice]")})
            Me.xrTableCell35.Multiline = True
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 8, 0, 0, 100F)
            Me.xrTableCell35.StyleName = "General"
            Me.xrTableCell35.StylePriority.UseFont = False
            Me.xrTableCell35.StylePriority.UsePadding = False
            Me.xrTableCell35.StylePriority.UseTextAlignment = False
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell35.TextFormatString = "{0:$#,#}"
            Me.xrTableCell35.Weight = 168.48122563857984R
            ' 
            ' xrTableCell36
            ' 
            Me.xrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductUnits]")})
            Me.xrTableCell36.Multiline = True
            Me.xrTableCell36.Name = "xrTableCell36"
            Me.xrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F)
            Me.xrTableCell36.StyleName = "General"
            Me.xrTableCell36.StylePriority.UseFont = False
            Me.xrTableCell36.StylePriority.UsePadding = False
            Me.xrTableCell36.StylePriority.UseTextAlignment = False
            Me.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell36.Weight = 127.89576640347559R
            ' 
            ' xrTableCell37
            ' 
            Me.xrTableCell37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")})
            Me.xrTableCell37.Multiline = True
            Me.xrTableCell37.Name = "xrTableCell37"
            Me.xrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.xrTableCell37.StyleName = "General"
            Me.xrTableCell37.StylePriority.UseFont = False
            Me.xrTableCell37.StylePriority.UsePadding = False
            Me.xrTableCell37.StylePriority.UseTextAlignment = False
            Me.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell37.TextFormatString = "{0:$#,#;$#,#;'-'}"
            Me.xrTableCell37.Weight = 127.89576640347559R
            ' 
            ' xrTableCell38
            ' 
            Me.xrTableCell38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
            Me.xrTableCell38.Multiline = True
            Me.xrTableCell38.Name = "xrTableCell38"
            Me.xrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 100F)
            Me.xrTableCell38.StyleName = "General"
            Me.xrTableCell38.StylePriority.UseFont = False
            Me.xrTableCell38.StylePriority.UsePadding = False
            Me.xrTableCell38.StylePriority.UseTextAlignment = False
            Me.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell38.TextFormatString = "{0:$#,#}"
            Me.xrTableCell38.Weight = 127.89576640347559R
            ' 
            ' jsonDataSource1
            ' 
            customJsonSource1.Json = resources.GetString("customJsonSource1.Json")
            Me.jsonDataSource1.JsonSource = customJsonSource1
            Me.jsonDataSource1.Name = "jsonDataSource1"
            jsonSchemaNode4.Nodes.Add(jsonSchemaNode5)
            jsonSchemaNode4.Nodes.Add(jsonSchemaNode6)
            jsonSchemaNode4.Nodes.Add(jsonSchemaNode7)
            jsonSchemaNode4.Nodes.Add(jsonSchemaNode8)
            jsonSchemaNode4.Nodes.Add(jsonSchemaNode9)
            jsonSchemaNode10.Nodes.Add(jsonSchemaNode11)
            jsonSchemaNode10.Nodes.Add(jsonSchemaNode12)
            jsonSchemaNode10.Nodes.Add(jsonSchemaNode13)
            jsonSchemaNode10.Nodes.Add(jsonSchemaNode14)
            jsonSchemaNode15.Nodes.Add(jsonSchemaNode16)
            jsonSchemaNode20.Nodes.Add(jsonSchemaNode21)
            jsonSchemaNode20.Nodes.Add(jsonSchemaNode22)
            jsonSchemaNode20.Nodes.Add(jsonSchemaNode23)
            jsonSchemaNode20.Nodes.Add(jsonSchemaNode24)
            jsonSchemaNode20.Nodes.Add(jsonSchemaNode25)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode2)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode3)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode4)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode10)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode15)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode17)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode18)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode19)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode20)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode26)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode27)
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode28)
            Me.jsonDataSource1.Schema = jsonSchemaNode1
            ' 
            ' General
            ' 
            Me.General.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.General.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.General.Name = "General"
            Me.General.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' BillingShippingHeaderStyle
            ' 
            Me.BillingShippingHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.BillingShippingHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.BillingShippingHeaderStyle.Name = "BillingShippingHeaderStyle"
            ' 
            ' Comments
            ' 
            Me.Comments.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.Comments.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((174)))))), (CInt(((CByte((187)))))))
            Me.Comments.Name = "Comments"
            ' 
            ' DetailTableHeaderStyle
            ' 
            Me.DetailTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.DetailTableHeaderStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.DetailTableHeaderStyle.BorderWidth = 0F
            Me.DetailTableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.DetailTableHeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DetailTableHeaderStyle.Name = "DetailTableHeaderStyle"
            ' 
            ' HeaderStyle
            ' 
            Me.HeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 26F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.HeaderStyle.Name = "HeaderStyle"
            Me.HeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' TableHeaderStyle
            ' 
            Me.TableHeaderStyle.BackColor = System.Drawing.Color.Transparent
            Me.TableHeaderStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.TableHeaderStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.TableHeaderStyle.BorderWidth = 2F
            Me.TableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((100)))))), (CInt(((CByte((118)))))))
            Me.TableHeaderStyle.Name = "TableHeaderStyle"
            ' 
            ' TableOddStyle
            ' 
            Me.TableOddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((249)))))), (CInt(((CByte((250)))))))
            Me.TableOddStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.TableOddStyle.BorderWidth = 1F
            Me.TableOddStyle.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.TableOddStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((73)))))), (CInt(((CByte((86)))))))
            Me.TableOddStyle.Name = "TableOddStyle"
            Me.TableOddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TableOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
            ' 
            ' Invoice
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1, Me.ReportFooter, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.jsonDataSource1})
            Me.DataSource = Me.jsonDataSource1
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(56, 43, 46, 50)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.General, Me.BillingShippingHeaderStyle, Me.Comments, Me.DetailTableHeaderStyle, Me.HeaderStyle, Me.TableHeaderStyle, Me.TableOddStyle})
            Me.Version = "21.2"
            CType((Me.xrTable3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrTable3 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrPictureBoxLogo As DevExpress.XtraReports.UI.XRPictureBox

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrTable5 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrPdfSignature1 As DevExpress.XtraReports.UI.XRPdfSignature

        Private xrTable6 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell33 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell34 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell36 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource

        Private General As DevExpress.XtraReports.UI.XRControlStyle

        Private BillingShippingHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private Comments As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailTableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private HeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private TableOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
