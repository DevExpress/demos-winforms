Namespace XtraReportsDemos.EmbeddedPDFContent

    Partial Class Specification

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.EmbeddedPDFContent.Specification))
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
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPictureBoxLogo = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPdfContent1 = New DevExpress.XtraReports.UI.XRPdfContent()
            Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 0F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 2F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBoxLogo, Me.xrLine1, Me.xrPageInfo1, Me.xrLabel2, Me.xrLabel1, Me.xrPdfContent1})
            Me.Detail.HeightF = 1095F
            Me.Detail.Name = "Detail"
            ' 
            ' xrPictureBoxLogo
            ' 
            Me.xrPictureBoxLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBoxLogo.ImageSource"))
            Me.xrPictureBoxLogo.LocationFloat = New DevExpress.Utils.PointFloat(647F, 23.99999F)
            Me.xrPictureBoxLogo.Name = "xrPictureBoxLogo"
            Me.xrPictureBoxLogo.SizeF = New System.Drawing.SizeF(145F, 45F)
            Me.xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.Orange
            Me.xrLine1.LineWidth = 2F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(105F, 69F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(687F, 20F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1045F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(850F, 50F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseTextAlignment = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrPageInfo1.TextFormatString = "Page {0} of {1}"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductPrice]")})
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(105F, 138F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(118F, 30F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextFormatString = "{0:$0}"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 21F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(105F, 94F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(280F, 44F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' xrPdfContent1
            ' 
            Me.xrPdfContent1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "PageRange", "[DataSource.CurrentRowIndex] + 1")})
            Me.xrPdfContent1.GenerateOwnPages = False
            Me.xrPdfContent1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPdfContent1.Name = "xrPdfContent1"
            Me.xrPdfContent1.SizeF = New System.Drawing.SizeF(850F, 1095F)
            Me.xrPdfContent1.SourceSerializable = resources.GetString("xrPdfContent1.SourceSerializable")
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
            Me.jsonDataSource1.Schema = jsonSchemaNode1
            ' 
            ' Specification
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.jsonDataSource1})
            Me.DataMember = "OrderItems"
            Me.DataSource = Me.jsonDataSource1
            Me.DesignerOptions.ShowExportWarnings = False
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 0, 2)
            Me.Version = "21.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrPictureBoxLogo As DevExpress.XtraReports.UI.XRPictureBox

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrPdfContent1 As DevExpress.XtraReports.UI.XRPdfContent

        Private jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource
    End Class
End Namespace
