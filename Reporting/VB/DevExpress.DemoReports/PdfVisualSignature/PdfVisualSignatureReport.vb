Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PdfVisualSignature

    Public Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.PdfVisualSignatureName
            DisplayName = ReportNames.PdfVisualSignature
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
            topMarginBand1 = New TopMarginBand()
            xrPictureBox1 = New XRPictureBox()
            bottomMarginBand1 = New BottomMarginBand()
            detailBand1 = New DetailBand()
            xrPdfSignature2 = New XRPdfSignature()
            xrLabel3 = New XRLabel()
            xrPdfSignature1 = New XRPdfSignature()
            xrLabel2 = New XRLabel()
            xrLabel1 = New XRLabel()
            xrRichText1 = New XRRichText()
            xrControlStyle1 = New XRControlStyle()
            CType(xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Controls.AddRange(New XRControl() {xrPictureBox1})
            topMarginBand1.Name = "topMarginBand1"
            topMarginBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            topMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"))
            xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(549F, 0F)
            xrPictureBox1.Name = "xrPictureBox1"
            xrPictureBox1.SizeF = New System.Drawing.SizeF(150F, 100F)
            xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Name = "bottomMarginBand1"
            bottomMarginBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            bottomMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' detailBand1
            ' 
            detailBand1.Controls.AddRange(New XRControl() {xrPdfSignature2, xrLabel3, xrPdfSignature1, xrLabel2, xrLabel1, xrRichText1})
            detailBand1.HeightF = 880F
            detailBand1.Name = "detailBand1"
            detailBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            detailBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPdfSignature2
            ' 
            xrPdfSignature2.AccessibleDescription = "A placeholder for Baxter Johnson Inc. digital signature"
            xrPdfSignature2.LocationFloat = New DevExpress.Utils.PointFloat(408.33F, 770F)
            xrPdfSignature2.Name = "xrPdfSignature2"
            xrPdfSignature2.Padding = New DevExpress.XtraPrinting.PaddingInfo(8F, 8F, 8F, 8F, 100F)
            xrPdfSignature2.SignatureOptions.DisplayDocumentSignature = False
            xrPdfSignature2.SizeF = New System.Drawing.SizeF(200F, 100F)
            ' 
            ' xrLabel3
            ' 
            xrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(60))))), (CInt(((CByte(66))))), (CInt(((CByte(82))))))
            xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(408.3333F, 747F)
            xrLabel3.Multiline = True
            xrLabel3.Name = "xrLabel3"
            xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            xrLabel3.SizeF = New System.Drawing.SizeF(200F, 23F)
            xrLabel3.StylePriority.UseFont = False
            xrLabel3.StylePriority.UseForeColor = False
            xrLabel3.StylePriority.UseTextAlignment = False
            xrLabel3.Text = "Baxter Johnson Inc"
            xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrPdfSignature1
            ' 
            xrPdfSignature1.LocationFloat = New DevExpress.Utils.PointFloat(54.16F, 770F)
            xrPdfSignature1.Name = "xrPdfSignature1"
            xrPdfSignature1.Padding = New DevExpress.XtraPrinting.PaddingInfo(8F, 8F, 8F, 8F, 100F)
            xrPdfSignature1.SizeF = New System.Drawing.SizeF(200F, 100F)
            ' 
            ' xrLabel2
            ' 
            xrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(60))))), (CInt(((CByte(66))))), (CInt(((CByte(82))))))
            xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(54.16667F, 747F)
            xrLabel2.Multiline = True
            xrLabel2.Name = "xrLabel2"
            xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            xrLabel2.SizeF = New System.Drawing.SizeF(200F, 23F)
            xrLabel2.StylePriority.UseFont = False
            xrLabel2.StylePriority.UseForeColor = False
            xrLabel2.StylePriority.UseTextAlignment = False
            xrLabel2.Text = "DevAV"
            xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel1
            ' 
            xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 21F, DevExpress.Drawing.DXFontStyle.Bold)
            xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(60))))), (CInt(((CByte(66))))), (CInt(((CByte(82))))))
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 10F)
            xrLabel1.Multiline = True
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(667.5F, 36.33333F)
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.StylePriority.UseForeColor = False
            xrLabel1.StylePriority.UseTextAlignment = False
            xrLabel1.Text = "Non-Disclosure Agreement"
            xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrRichText1
            ' 
            xrRichText1.CanShrink = True
            xrRichText1.EvenStyleName = "xrControlStyle1"
            xrRichText1.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            xrRichText1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(60))))), (CInt(((CByte(66))))), (CInt(((CByte(82))))))
            xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(27.5F, 70.33333F)
            xrRichText1.Name = "xrRichText1"
            xrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
            xrRichText1.SizeF = New System.Drawing.SizeF(650F, 657.1667F)
            xrRichText1.StylePriority.UseFont = False
            xrRichText1.StylePriority.UseForeColor = False
            ' 
            ' xrControlStyle1
            ' 
            xrControlStyle1.Name = "xrControlStyle1"
            xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            ' 
            ' Report
            ' 
            Bands.AddRange(New Band() {topMarginBand1, bottomMarginBand1, detailBand1})
            Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Margins = New DevExpress.Drawing.DXMargins(64F, 87F, 100F, 100F)
            StyleSheet.AddRange(New XRControlStyle() {xrControlStyle1})
            Version = "26.1"
            CType(xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As TopMarginBand

        Private bottomMarginBand1 As BottomMarginBand

        Private detailBand1 As DetailBand

        Private xrPictureBox1 As XRPictureBox

        Private xrLabel1 As XRLabel

        Private xrRichText1 As XRRichText

        Private xrControlStyle1 As XRControlStyle

        Private xrPdfSignature2 As XRPdfSignature

        Private xrLabel3 As XRLabel

        Private xrPdfSignature1 As XRPdfSignature

        Private xrLabel2 As XRLabel
    End Class
End Namespace
