Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.BarCodes

    Public Partial Class BarCodeTypesReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private components As System.ComponentModel.Container = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode2 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell33 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell34 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell36 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell44 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell46 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell49 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell52 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell55 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell56 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell57 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode3 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode4 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode5 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode6 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode7 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode8 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode9 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode10 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode11 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode12 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode13 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode14 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode15 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode16 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode17 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode18 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode19 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode20 As DevExpress.XtraReports.UI.XRBarCode

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private TextPaddingStyle As DevExpress.XtraReports.UI.XRControlStyle

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim aztecCodeGenerator1 As DevExpress.XtraPrinting.BarCode.AztecCodeGenerator = New DevExpress.XtraPrinting.BarCode.AztecCodeGenerator()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.BarCodes.BarCodeTypesReport))
            Dim microQRCodeGenerator1 As DevExpress.XtraPrinting.BarCode.MicroQRCodeGenerator = New DevExpress.XtraPrinting.BarCode.MicroQRCodeGenerator()
            Dim qrCodeGS1Generator1 As DevExpress.XtraPrinting.BarCode.QRCodeGS1Generator = New DevExpress.XtraPrinting.BarCode.QRCodeGS1Generator()
            Dim qrCodeEPCGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeEPCGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeEPCGenerator()
            Dim paymentServicesAustriaQRFrameOptions1 As DevExpress.XtraPrinting.BarCode.PaymentServicesAustriaQRFrameOptions = New DevExpress.XtraPrinting.BarCode.PaymentServicesAustriaQRFrameOptions()
            Dim qrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            Dim rectangleQRFrameOptions1 As DevExpress.XtraPrinting.BarCode.RectangleQRFrameOptions = New DevExpress.XtraPrinting.BarCode.RectangleQRFrameOptions()
            Dim qrCodeGenerator2 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            Dim ssccGenerator1 As DevExpress.XtraPrinting.BarCode.SSCCGenerator = New DevExpress.XtraPrinting.BarCode.SSCCGenerator()
            Dim deutschePostIdentcodeGenerator1 As DevExpress.XtraPrinting.BarCode.DeutschePostIdentcodeGenerator = New DevExpress.XtraPrinting.BarCode.DeutschePostIdentcodeGenerator()
            Dim deutschePostLeitcodeGenerator1 As DevExpress.XtraPrinting.BarCode.DeutschePostLeitcodeGenerator = New DevExpress.XtraPrinting.BarCode.DeutschePostLeitcodeGenerator()
            Dim pharmacodeGenerator1 As DevExpress.XtraPrinting.BarCode.PharmacodeGenerator = New DevExpress.XtraPrinting.BarCode.PharmacodeGenerator()
            Dim pharmacodeGenerator2 As DevExpress.XtraPrinting.BarCode.PharmacodeGenerator = New DevExpress.XtraPrinting.BarCode.PharmacodeGenerator()
            Dim dataBarGenerator1 As DevExpress.XtraPrinting.BarCode.DataBarGenerator = New DevExpress.XtraPrinting.BarCode.DataBarGenerator()
            Dim dataBarGenerator2 As DevExpress.XtraPrinting.BarCode.DataBarGenerator = New DevExpress.XtraPrinting.BarCode.DataBarGenerator()
            Dim itF14Generator1 As DevExpress.XtraPrinting.BarCode.ITF14Generator = New DevExpress.XtraPrinting.BarCode.ITF14Generator()
            Dim dataMatrixGS1Generator1 As DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator = New DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator()
            Dim intelligentMailGenerator1 As DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator = New DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator()
            Dim intelligentMailPackageGenerator1 As DevExpress.XtraPrinting.BarCode.IntelligentMailPackageGenerator = New DevExpress.XtraPrinting.BarCode.IntelligentMailPackageGenerator()
            Dim dataMatrixGenerator1 As DevExpress.XtraPrinting.BarCode.DataMatrixGenerator = New DevExpress.XtraPrinting.BarCode.DataMatrixGenerator()
            Dim pdF417Generator1 As DevExpress.XtraPrinting.BarCode.PDF417Generator = New DevExpress.XtraPrinting.BarCode.PDF417Generator()
            Dim codabarGenerator1 As DevExpress.XtraPrinting.BarCode.CodabarGenerator = New DevExpress.XtraPrinting.BarCode.CodabarGenerator()
            Dim code11Generator1 As DevExpress.XtraPrinting.BarCode.Code11Generator = New DevExpress.XtraPrinting.BarCode.Code11Generator()
            Dim code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Dim eaN128Generator1 As DevExpress.XtraPrinting.BarCode.EAN128Generator = New DevExpress.XtraPrinting.BarCode.EAN128Generator()
            Dim code39Generator1 As DevExpress.XtraPrinting.BarCode.Code39Generator = New DevExpress.XtraPrinting.BarCode.Code39Generator()
            Dim code39ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator()
            Dim code93Generator1 As DevExpress.XtraPrinting.BarCode.Code93Generator = New DevExpress.XtraPrinting.BarCode.Code93Generator()
            Dim code93ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator()
            Dim industrial2of5Generator1 As DevExpress.XtraPrinting.BarCode.Industrial2of5Generator = New DevExpress.XtraPrinting.BarCode.Industrial2of5Generator()
            Dim matrix2of5Generator1 As DevExpress.XtraPrinting.BarCode.Matrix2of5Generator = New DevExpress.XtraPrinting.BarCode.Matrix2of5Generator()
            Dim interleaved2of5Generator1 As DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator = New DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator()
            Dim eaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim eaN8Generator1 As DevExpress.XtraPrinting.BarCode.EAN8Generator = New DevExpress.XtraPrinting.BarCode.EAN8Generator()
            Dim codeMSIGenerator1 As DevExpress.XtraPrinting.BarCode.CodeMSIGenerator = New DevExpress.XtraPrinting.BarCode.CodeMSIGenerator()
            Dim upcaGenerator1 As DevExpress.XtraPrinting.BarCode.UPCAGenerator = New DevExpress.XtraPrinting.BarCode.UPCAGenerator()
            Dim upcE0Generator1 As DevExpress.XtraPrinting.BarCode.UPCE0Generator = New DevExpress.XtraPrinting.BarCode.UPCE0Generator()
            Dim upcSupplemental2Generator1 As DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator = New DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator()
            Dim eaN13Generator2 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim eaN13Generator3 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim upcSupplemental5Generator1 As DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator = New DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator()
            Dim xrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow36 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode37 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode38 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow34 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode35 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow33 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode39 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow35 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode23 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode36 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow32 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode34 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow31 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode32 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow30 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode33 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode30 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode31 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode28 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode27 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode26 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode25 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode24 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode29 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode22 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode21 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode3 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode4 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode5 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode6 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode7 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode8 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode9 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode10 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode11 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode12 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode13 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode14 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode15 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode16 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode19 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode17 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode18 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode20 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.TextPaddingStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.AutoModuleParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail.HeightF = 4108.133F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.White
            Me.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow36, Me.xrTableRow22, Me.xrTableRow34, Me.xrTableRow33, Me.xrTableRow35, Me.xrTableRow32, Me.xrTableRow31, Me.xrTableRow30, Me.xrTableRow28, Me.xrTableRow29, Me.xrTableRow26, Me.xrTableRow25, Me.xrTableRow24, Me.xrTableRow23, Me.xrTableRow27, Me.xrTableRow21, Me.xrTableRow20, Me.xrTableRow2, Me.xrTableRow3, Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow8, Me.xrTableRow9, Me.xrTableRow10, Me.xrTableRow11, Me.xrTableRow12, Me.xrTableRow13, Me.xrTableRow6, Me.xrTableRow7, Me.xrTableRow14, Me.xrTableRow15, Me.xrTableRow16, Me.xrTableRow17, Me.xrTableRow18, Me.xrTableRow19})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(670F, 4108.133F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow36
            ' 
            Me.xrTableRow36.BackColor = System.Drawing.Color.White
            Me.xrTableRow36.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell106, Me.xrTableCell107, Me.xrTableCell108})
            Me.xrTableRow36.Name = "xrTableRow36"
            Me.xrTableRow36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow36.StylePriority.UseBackColor = False
            Me.xrTableRow36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow36.Weight = 0.11324286715924584R
            ' 
            ' xrTableCell106
            ' 
            Me.xrTableCell106.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell106.BorderWidth = 0F
            Me.xrTableCell106.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell106.Multiline = True
            Me.xrTableCell106.Name = "xrTableCell106"
            Me.xrTableCell106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell106.StyleName = "TextPaddingStyle"
            Me.xrTableCell106.StylePriority.UseBackColor = False
            Me.xrTableCell106.StylePriority.UseBorderWidth = False
            Me.xrTableCell106.Text = "Aztec Code"
            Me.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell106.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell107
            ' 
            Me.xrTableCell107.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell107.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell107.BorderWidth = 1F
            Me.xrTableCell107.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode37})
            Me.xrTableCell107.Multiline = True
            Me.xrTableCell107.Name = "xrTableCell107"
            Me.xrTableCell107.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell107.StylePriority.UseBackColor = False
            Me.xrTableCell107.StylePriority.UseBorders = False
            Me.xrTableCell107.StylePriority.UseBorderWidth = False
            Me.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell107.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode37
            ' 
            Me.xrBarCode37.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode37.LocationFloat = New DevExpress.Utils.PointFloat(1.041664F, 0F)
            Me.xrBarCode37.[Module] = 5F
            Me.xrBarCode37.Name = "xrBarCode37"
            Me.xrBarCode37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrBarCode37.ShowText = False
            Me.xrBarCode37.SizeF = New System.Drawing.SizeF(250.7628F, 130.1645F)
            Me.xrBarCode37.StylePriority.UsePadding = False
            Me.xrBarCode37.Symbology = aztecCodeGenerator1
            Me.xrBarCode37.Text = " " & Global.Microsoft.VisualBasic.Constants.vbLf & "https://devexpress.com"
            ' 
            ' xrTableCell108
            ' 
            Me.xrTableCell108.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell108.BorderWidth = 0F
            Me.xrTableCell108.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell108.Multiline = True
            Me.xrTableCell108.Name = "xrTableCell108"
            Me.xrTableCell108.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell108.StyleName = "TextPaddingStyle"
            Me.xrTableCell108.StylePriority.UseBackColor = False
            Me.xrTableCell108.StylePriority.UseBorderWidth = False
            Me.xrTableCell108.Text = resources.GetString("xrTableCell108.Text")
            Me.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell108.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow22
            ' 
            Me.xrTableRow22.BackColor = System.Drawing.Color.White
            Me.xrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell64, Me.xrTableCell65, Me.xrTableCell66})
            Me.xrTableRow22.Name = "xrTableRow22"
            Me.xrTableRow22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow22.StylePriority.UseBackColor = False
            Me.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow22.Weight = 0.11324286715924584R
            ' 
            ' xrTableCell64
            ' 
            Me.xrTableCell64.BackColor = System.Drawing.Color.White
            Me.xrTableCell64.BorderWidth = 0F
            Me.xrTableCell64.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell64.Multiline = True
            Me.xrTableCell64.Name = "xrTableCell64"
            Me.xrTableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell64.StyleName = "TextPaddingStyle"
            Me.xrTableCell64.StylePriority.UseBackColor = False
            Me.xrTableCell64.StylePriority.UseBorderWidth = False
            Me.xrTableCell64.Text = "Micro QR Code"
            Me.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell64.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell65
            ' 
            Me.xrTableCell65.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell65.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell65.BorderWidth = 1F
            Me.xrTableCell65.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode38})
            Me.xrTableCell65.Multiline = True
            Me.xrTableCell65.Name = "xrTableCell65"
            Me.xrTableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell65.StylePriority.UseBackColor = False
            Me.xrTableCell65.StylePriority.UseBorders = False
            Me.xrTableCell65.StylePriority.UseBorderWidth = False
            Me.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell65.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode38
            ' 
            Me.xrBarCode38.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode38.BackColor = System.Drawing.Color.White
            Me.xrBarCode38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode38.LocationFloat = New DevExpress.Utils.PointFloat(1.041664F, 0F)
            Me.xrBarCode38.[Module] = 4F
            Me.xrBarCode38.Name = "xrBarCode38"
            Me.xrBarCode38.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 25, 25, 100F)
            Me.xrBarCode38.ShowText = False
            Me.xrBarCode38.SizeF = New System.Drawing.SizeF(250.7628F, 130.1645F)
            Me.xrBarCode38.StylePriority.UseBackColor = False
            Me.xrBarCode38.StylePriority.UsePadding = False
            microQRCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.MicroQRCodeCompactionMode.[Byte]
            microQRCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.MicroQRCodeVersion.AutoVersion
            Me.xrBarCode38.Symbology = microQRCodeGenerator1
            Me.xrBarCode38.Text = "devexpress.com"
            ' 
            ' xrTableCell66
            ' 
            Me.xrTableCell66.BackColor = System.Drawing.Color.White
            Me.xrTableCell66.BorderWidth = 0F
            Me.xrTableCell66.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell66.Multiline = True
            Me.xrTableCell66.Name = "xrTableCell66"
            Me.xrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell66.StyleName = "TextPaddingStyle"
            Me.xrTableCell66.StylePriority.UseBackColor = False
            Me.xrTableCell66.StylePriority.UseBorderWidth = False
            Me.xrTableCell66.Text = resources.GetString("xrTableCell66.Text")
            Me.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell66.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow34
            ' 
            Me.xrTableRow34.BackColor = System.Drawing.Color.White
            Me.xrTableRow34.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell100, Me.xrTableCell101, Me.xrTableCell102})
            Me.xrTableRow34.Name = "xrTableRow34"
            Me.xrTableRow34.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow34.StylePriority.UseBackColor = False
            Me.xrTableRow34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow34.Weight = 0.11324286715924584R
            ' 
            ' xrTableCell100
            ' 
            Me.xrTableCell100.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell100.BorderWidth = 0F
            Me.xrTableCell100.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell100.Multiline = True
            Me.xrTableCell100.Name = "xrTableCell100"
            Me.xrTableCell100.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell100.StyleName = "TextPaddingStyle"
            Me.xrTableCell100.StylePriority.UseBackColor = False
            Me.xrTableCell100.StylePriority.UseBorderWidth = False
            Me.xrTableCell100.Text = "GS1 QR Code"
            Me.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell100.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell101
            ' 
            Me.xrTableCell101.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell101.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell101.BorderWidth = 1F
            Me.xrTableCell101.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode35})
            Me.xrTableCell101.Multiline = True
            Me.xrTableCell101.Name = "xrTableCell101"
            Me.xrTableCell101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell101.StylePriority.UseBackColor = False
            Me.xrTableCell101.StylePriority.UseBorders = False
            Me.xrTableCell101.StylePriority.UseBorderWidth = False
            Me.xrTableCell101.Text = "xrTableCell101"
            Me.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell101.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode35
            ' 
            Me.xrBarCode35.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode35.BorderWidth = 0F
            Me.xrBarCode35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode35.LocationFloat = New DevExpress.Utils.PointFloat(1.041664F, 0F)
            Me.xrBarCode35.[Module] = 3F
            Me.xrBarCode35.Name = "xrBarCode35"
            Me.xrBarCode35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrBarCode35.ShowText = False
            Me.xrBarCode35.SizeF = New System.Drawing.SizeF(250.7628F, 130.1645F)
            Me.xrBarCode35.StylePriority.UseBorderWidth = False
            Me.xrBarCode35.StylePriority.UsePadding = False
            Me.xrBarCode35.Symbology = qrCodeGS1Generator1
            Me.xrBarCode35.Text = "010123456789012890DEVEXPRESS"
            ' 
            ' xrTableCell102
            ' 
            Me.xrTableCell102.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell102.BorderWidth = 0F
            Me.xrTableCell102.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell102.Multiline = True
            Me.xrTableCell102.Name = "xrTableCell102"
            Me.xrTableCell102.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell102.StyleName = "TextPaddingStyle"
            Me.xrTableCell102.StylePriority.UseBackColor = False
            Me.xrTableCell102.StylePriority.UseBorderWidth = False
            Me.xrTableCell102.Text = resources.GetString("xrTableCell102.Text")
            Me.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell102.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow33
            ' 
            Me.xrTableRow33.BackColor = System.Drawing.Color.White
            Me.xrTableRow33.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell97, Me.xrTableCell98, Me.xrTableCell99})
            Me.xrTableRow33.Name = "xrTableRow33"
            Me.xrTableRow33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow33.StylePriority.UseBackColor = False
            Me.xrTableRow33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow33.Weight = 0.14259301930216561R
            ' 
            ' xrTableCell97
            ' 
            Me.xrTableCell97.BackColor = System.Drawing.Color.White
            Me.xrTableCell97.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell97.Multiline = True
            Me.xrTableCell97.Name = "xrTableCell97"
            Me.xrTableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell97.StyleName = "TextPaddingStyle"
            Me.xrTableCell97.StylePriority.UseBackColor = False
            Me.xrTableCell97.Text = Global.Microsoft.VisualBasic.Constants.vbCrLf & "EPC QR Code"
            Me.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell97.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell98
            ' 
            Me.xrTableCell98.BackColor = System.Drawing.Color.White
            Me.xrTableCell98.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode39})
            Me.xrTableCell98.Multiline = True
            Me.xrTableCell98.Name = "xrTableCell98"
            Me.xrTableCell98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell98.StylePriority.UseBackColor = False
            Me.xrTableCell98.Text = "xrTableCell98"
            Me.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell98.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode39
            ' 
            Me.xrBarCode39.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode39.AutoModule = True
            Me.xrBarCode39.BorderWidth = 0F
            Me.xrBarCode39.Font = New DevExpress.Drawing.DXFont("Arial", 8F)
            Me.xrBarCode39.LocationFloat = New DevExpress.Utils.PointFloat(1.041664F, 0F)
            Me.xrBarCode39.[Module] = 3F
            Me.xrBarCode39.Name = "xrBarCode39"
            Me.xrBarCode39.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 20, 20, 100F)
            Me.xrBarCode39.ShowText = False
            Me.xrBarCode39.SizeF = New System.Drawing.SizeF(251.8045F, 163.9004F)
            Me.xrBarCode39.StylePriority.UseBorderWidth = False
            Me.xrBarCode39.StylePriority.UseFont = False
            Me.xrBarCode39.StylePriority.UsePadding = False
            qrCodeEPCGenerator1.FrameOptions = paymentServicesAustriaQRFrameOptions1
            Me.xrBarCode39.Symbology = qrCodeEPCGenerator1
            Me.xrBarCode39.Text = "BCD" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "002" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "1" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SCT" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "François D'Alsace S.A." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "FR1420041010050500013M02606" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "EUR100.0" & "0" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Client:Marie Louise La Lune"
            ' 
            ' xrTableCell99
            ' 
            Me.xrTableCell99.BackColor = System.Drawing.Color.White
            Me.xrTableCell99.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell99.Multiline = True
            Me.xrTableCell99.Name = "xrTableCell99"
            Me.xrTableCell99.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell99.StyleName = "TextPaddingStyle"
            Me.xrTableCell99.StylePriority.UseBackColor = False
            Me.xrTableCell99.Text = resources.GetString("xrTableCell99.Text")
            Me.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell99.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow35
            ' 
            Me.xrTableRow35.BackColor = System.Drawing.Color.White
            Me.xrTableRow35.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell103, Me.xrTableCell104, Me.xrTableCell105})
            Me.xrTableRow35.Name = "xrTableRow35"
            Me.xrTableRow35.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow35.StylePriority.UseBackColor = False
            Me.xrTableRow35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow35.Weight = 0.202767668776585R
            ' 
            ' xrTableCell103
            ' 
            Me.xrTableCell103.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell103.BorderWidth = 0F
            Me.xrTableCell103.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell103.Multiline = True
            Me.xrTableCell103.Name = "xrTableCell103"
            Me.xrTableCell103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell103.StyleName = "TextPaddingStyle"
            Me.xrTableCell103.StylePriority.UseBackColor = False
            Me.xrTableCell103.StylePriority.UseBorderWidth = False
            Me.xrTableCell103.Text = "QR Code"
            Me.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell103.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell104
            ' 
            Me.xrTableCell104.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell104.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell104.BorderWidth = 1F
            Me.xrTableCell104.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode23, Me.xrBarCode36})
            Me.xrTableCell104.Multiline = True
            Me.xrTableCell104.Name = "xrTableCell104"
            Me.xrTableCell104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell104.StylePriority.UseBackColor = False
            Me.xrTableCell104.StylePriority.UseBorders = False
            Me.xrTableCell104.StylePriority.UseBorderWidth = False
            Me.xrTableCell104.Text = "xrTableCell104"
            Me.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell104.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode23
            ' 
            Me.xrBarCode23.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode23.AutoModule = True
            Me.xrBarCode23.BorderWidth = 0F
            Me.xrBarCode23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode23.LocationFloat = New DevExpress.Utils.PointFloat(9.999985F, 114.248F)
            Me.xrBarCode23.[Module] = 3F
            Me.xrBarCode23.Name = "xrBarCode23"
            Me.xrBarCode23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrBarCode23.ShowText = False
            Me.xrBarCode23.SizeF = New System.Drawing.SizeF(237.0375F, 118.6522F)
            Me.xrBarCode23.StylePriority.UseBorderWidth = False
            Me.xrBarCode23.StylePriority.UsePadding = False
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
            rectangleQRFrameOptions1.Text = "SCAN ME"
            rectangleQRFrameOptions1.TextPosition = DevExpress.XtraPrinting.BarCode.QRFrameTextPosition.Top
            qrCodeGenerator1.FrameOptions = rectangleQRFrameOptions1
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version2
            Me.xrBarCode23.Symbology = qrCodeGenerator1
            Me.xrBarCode23.Text = "URL:https://www.devexpress.com"
            ' 
            ' xrBarCode36
            ' 
            Me.xrBarCode36.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrBarCode36.BorderWidth = 0F
            Me.xrBarCode36.LocationFloat = New DevExpress.Utils.PointFloat(9.999985F, 0F)
            Me.xrBarCode36.[Module] = 3.2F
            Me.xrBarCode36.Name = "xrBarCode36"
            Me.xrBarCode36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrBarCode36.ShowText = False
            Me.xrBarCode36.SizeF = New System.Drawing.SizeF(237.0374F, 114.248F)
            Me.xrBarCode36.StylePriority.UseBorderWidth = False
            Me.xrBarCode36.StylePriority.UsePadding = False
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
            qrCodeGenerator2.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.H
            qrCodeGenerator2.Logo = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("qrCodeGenerator2.Logo"))
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
            Me.xrBarCode36.Symbology = qrCodeGenerator2
            Me.xrBarCode36.Text = "URL:https://www.devexpress.com"
            ' 
            ' xrTableCell105
            ' 
            Me.xrTableCell105.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell105.BorderWidth = 0F
            Me.xrTableCell105.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell105.Multiline = True
            Me.xrTableCell105.Name = "xrTableCell105"
            Me.xrTableCell105.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell105.StyleName = "TextPaddingStyle"
            Me.xrTableCell105.StylePriority.UseBackColor = False
            Me.xrTableCell105.StylePriority.UseBorderWidth = False
            Me.xrTableCell105.Text = resources.GetString("xrTableCell105.Text")
            Me.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell105.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow32
            ' 
            Me.xrTableRow32.BackColor = System.Drawing.Color.White
            Me.xrTableRow32.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell94, Me.xrTableCell95, Me.xrTableCell96})
            Me.xrTableRow32.Name = "xrTableRow32"
            Me.xrTableRow32.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow32.StylePriority.UseBackColor = False
            Me.xrTableRow32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow32.Weight = 0.10288096147870091R
            ' 
            ' xrTableCell94
            ' 
            Me.xrTableCell94.BackColor = System.Drawing.Color.White
            Me.xrTableCell94.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell94.Multiline = True
            Me.xrTableCell94.Name = "xrTableCell94"
            Me.xrTableCell94.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell94.StyleName = "TextPaddingStyle"
            Me.xrTableCell94.StylePriority.UseBackColor = False
            Me.xrTableCell94.Text = "GS1-128 SSCC"
            Me.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell94.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell95
            ' 
            Me.xrTableCell95.BackColor = System.Drawing.Color.White
            Me.xrTableCell95.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode34})
            Me.xrTableCell95.Multiline = True
            Me.xrTableCell95.Name = "xrTableCell95"
            Me.xrTableCell95.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell95.StylePriority.UseBackColor = False
            Me.xrTableCell95.Text = "xrTableCell95"
            Me.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell95.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode34
            ' 
            Me.xrBarCode34.BorderWidth = 0F
            Me.xrBarCode34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode34.LocationFloat = New DevExpress.Utils.PointFloat(1.100014F, 23F)
            Me.xrBarCode34.[Module] = 1.45F
            Me.xrBarCode34.Name = "xrBarCode34"
            Me.xrBarCode34.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode34.SizeF = New System.Drawing.SizeF(251.7462F, 75F)
            Me.xrBarCode34.StylePriority.UseBorderWidth = False
            Me.xrBarCode34.StylePriority.UseTextAlignment = False
            Me.xrBarCode34.Symbology = ssccGenerator1
            Me.xrBarCode34.Text = "00614141234567890"
            Me.xrBarCode34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell96
            ' 
            Me.xrTableCell96.BackColor = System.Drawing.Color.White
            Me.xrTableCell96.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell96.Multiline = True
            Me.xrTableCell96.Name = "xrTableCell96"
            Me.xrTableCell96.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell96.StyleName = "TextPaddingStyle"
            Me.xrTableCell96.StylePriority.UseBackColor = False
            Me.xrTableCell96.Text = resources.GetString("xrTableCell96.Text")
            Me.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell96.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow31
            ' 
            Me.xrTableRow31.BackColor = System.Drawing.Color.White
            Me.xrTableRow31.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell91, Me.xrTableCell92, Me.xrTableCell93})
            Me.xrTableRow31.Name = "xrTableRow31"
            Me.xrTableRow31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow31.StylePriority.UseBackColor = False
            Me.xrTableRow31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow31.Weight = 0.10177710951000171R
            ' 
            ' xrTableCell91
            ' 
            Me.xrTableCell91.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell91.BorderWidth = 0F
            Me.xrTableCell91.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell91.Multiline = True
            Me.xrTableCell91.Name = "xrTableCell91"
            Me.xrTableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell91.StyleName = "TextPaddingStyle"
            Me.xrTableCell91.StylePriority.UseBackColor = False
            Me.xrTableCell91.StylePriority.UseBorderWidth = False
            Me.xrTableCell91.Text = "Deutsche Post Identcode"
            Me.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell91.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell92
            ' 
            Me.xrTableCell92.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell92.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell92.BorderWidth = 1F
            Me.xrTableCell92.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode32})
            Me.xrTableCell92.Multiline = True
            Me.xrTableCell92.Name = "xrTableCell92"
            Me.xrTableCell92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell92.StylePriority.UseBackColor = False
            Me.xrTableCell92.StylePriority.UseBorders = False
            Me.xrTableCell92.StylePriority.UseBorderWidth = False
            Me.xrTableCell92.Text = "xrTableCell92"
            Me.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell92.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode32
            ' 
            Me.xrBarCode32.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode32.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode32.BorderWidth = 0F
            Me.xrBarCode32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode32.LocationFloat = New DevExpress.Utils.PointFloat(4.149498F, 36.98541F)
            Me.xrBarCode32.[Module] = 1.5F
            Me.xrBarCode32.Name = "xrBarCode32"
            Me.xrBarCode32.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode32.SizeF = New System.Drawing.SizeF(246.9505F, 70F)
            Me.xrBarCode32.StylePriority.UseBackColor = False
            Me.xrBarCode32.StylePriority.UseBorderWidth = False
            Me.xrBarCode32.StylePriority.UsePadding = False
            deutschePostIdentcodeGenerator1.WideNarrowRatio = 3F
            Me.xrBarCode32.Symbology = deutschePostIdentcodeGenerator1
            Me.xrBarCode32.Text = "12345678901"
            Me.xrBarCode32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell93
            ' 
            Me.xrTableCell93.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell93.BorderWidth = 0F
            Me.xrTableCell93.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell93.Multiline = True
            Me.xrTableCell93.Name = "xrTableCell93"
            Me.xrTableCell93.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell93.StyleName = "TextPaddingStyle"
            Me.xrTableCell93.StylePriority.UseBackColor = False
            Me.xrTableCell93.StylePriority.UseBorderWidth = False
            Me.xrTableCell93.Text = resources.GetString("xrTableCell93.Text")
            Me.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell93.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow30
            ' 
            Me.xrTableRow30.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell88, Me.xrTableCell89, Me.xrTableCell90})
            Me.xrTableRow30.Name = "xrTableRow30"
            Me.xrTableRow30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow30.StylePriority.UseBackColor = False
            Me.xrTableRow30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow30.Weight = 0.090177202136186976R
            ' 
            ' xrTableCell88
            ' 
            Me.xrTableCell88.BackColor = System.Drawing.Color.White
            Me.xrTableCell88.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell88.Multiline = True
            Me.xrTableCell88.Name = "xrTableCell88"
            Me.xrTableCell88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell88.StyleName = "TextPaddingStyle"
            Me.xrTableCell88.StylePriority.UseBackColor = False
            Me.xrTableCell88.Text = "Deutsche Post Leitcode"
            Me.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell88.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell89
            ' 
            Me.xrTableCell89.BackColor = System.Drawing.Color.White
            Me.xrTableCell89.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode33})
            Me.xrTableCell89.Multiline = True
            Me.xrTableCell89.Name = "xrTableCell89"
            Me.xrTableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell89.StylePriority.UseBackColor = False
            Me.xrTableCell89.Text = "xrTableCell89"
            Me.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell89.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode33
            ' 
            Me.xrBarCode33.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode33.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode33.LocationFloat = New DevExpress.Utils.PointFloat(1.85F, 18F)
            Me.xrBarCode33.[Module] = 1.25F
            Me.xrBarCode33.Name = "xrBarCode33"
            Me.xrBarCode33.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode33.SizeF = New System.Drawing.SizeF(250.9938F, 70.00003F)
            Me.xrBarCode33.StylePriority.UseBackColor = False
            Me.xrBarCode33.StylePriority.UsePadding = False
            deutschePostLeitcodeGenerator1.WideNarrowRatio = 3F
            Me.xrBarCode33.Symbology = deutschePostLeitcodeGenerator1
            Me.xrBarCode33.Text = "1234567890123"
            Me.xrBarCode33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell90
            ' 
            Me.xrTableCell90.BackColor = System.Drawing.Color.White
            Me.xrTableCell90.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell90.Multiline = True
            Me.xrTableCell90.Name = "xrTableCell90"
            Me.xrTableCell90.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell90.StyleName = "TextPaddingStyle"
            Me.xrTableCell90.StylePriority.UseBackColor = False
            Me.xrTableCell90.Text = resources.GetString("xrTableCell90.Text")
            Me.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell90.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow28
            ' 
            Me.xrTableRow28.BackColor = System.Drawing.Color.White
            Me.xrTableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell82, Me.xrTableCell83, Me.xrTableCell84})
            Me.xrTableRow28.Name = "xrTableRow28"
            Me.xrTableRow28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow28.StylePriority.UseBackColor = False
            Me.xrTableRow28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow28.Weight = 0.0752236289479637R
            ' 
            ' xrTableCell82
            ' 
            Me.xrTableCell82.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell82.BorderWidth = 0F
            Me.xrTableCell82.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell82.Multiline = True
            Me.xrTableCell82.Name = "xrTableCell82"
            Me.xrTableCell82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell82.StyleName = "TextPaddingStyle"
            Me.xrTableCell82.StylePriority.UseBackColor = False
            Me.xrTableCell82.StylePriority.UseBorderWidth = False
            Me.xrTableCell82.Text = "Pharmacode" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "One-Track"
            Me.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell82.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell83
            ' 
            Me.xrTableCell83.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell83.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell83.BorderWidth = 1F
            Me.xrTableCell83.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode30})
            Me.xrTableCell83.Multiline = True
            Me.xrTableCell83.Name = "xrTableCell83"
            Me.xrTableCell83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell83.StylePriority.UseBackColor = False
            Me.xrTableCell83.StylePriority.UseBorders = False
            Me.xrTableCell83.StylePriority.UseBorderWidth = False
            Me.xrTableCell83.Text = "xrTableCell83"
            Me.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell83.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode30
            ' 
            Me.xrBarCode30.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode30.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode30.BorderWidth = 0F
            Me.xrBarCode30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode30.LocationFloat = New DevExpress.Utils.PointFloat(4.344994F, 10F)
            Me.xrBarCode30.Name = "xrBarCode30"
            Me.xrBarCode30.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode30.SizeF = New System.Drawing.SizeF(241.8044F, 70F)
            Me.xrBarCode30.StylePriority.UseBackColor = False
            Me.xrBarCode30.StylePriority.UseBorderWidth = False
            Me.xrBarCode30.StylePriority.UsePadding = False
            Me.xrBarCode30.Symbology = pharmacodeGenerator1
            Me.xrBarCode30.Text = "101070"
            Me.xrBarCode30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell84
            ' 
            Me.xrTableCell84.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell84.BorderWidth = 0F
            Me.xrTableCell84.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell84.Multiline = True
            Me.xrTableCell84.Name = "xrTableCell84"
            Me.xrTableCell84.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell84.StyleName = "TextPaddingStyle"
            Me.xrTableCell84.StylePriority.UseBackColor = False
            Me.xrTableCell84.StylePriority.UseBorderWidth = False
            Me.xrTableCell84.Text = resources.GetString("xrTableCell84.Text")
            Me.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell84.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow29
            ' 
            Me.xrTableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell85, Me.xrTableCell86, Me.xrTableCell87})
            Me.xrTableRow29.Name = "xrTableRow29"
            Me.xrTableRow29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow29.StylePriority.UseBackColor = False
            Me.xrTableRow29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow29.Weight = 0.091261359178677309R
            ' 
            ' xrTableCell85
            ' 
            Me.xrTableCell85.BackColor = System.Drawing.Color.White
            Me.xrTableCell85.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell85.Multiline = True
            Me.xrTableCell85.Name = "xrTableCell85"
            Me.xrTableCell85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell85.StyleName = "TextPaddingStyle"
            Me.xrTableCell85.StylePriority.UseBackColor = False
            Me.xrTableCell85.Text = "Pharmacode" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Two-Track"
            Me.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell85.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell86
            ' 
            Me.xrTableCell86.BackColor = System.Drawing.Color.White
            Me.xrTableCell86.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode31})
            Me.xrTableCell86.Multiline = True
            Me.xrTableCell86.Name = "xrTableCell86"
            Me.xrTableCell86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell86.StylePriority.UseBackColor = False
            Me.xrTableCell86.Text = "xrTableCell86"
            Me.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell86.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode31
            ' 
            Me.xrBarCode31.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode31.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode31.BorderWidth = 0F
            Me.xrBarCode31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode31.LocationFloat = New DevExpress.Utils.PointFloat(1.846199F, 19F)
            Me.xrBarCode31.[Module] = 4F
            Me.xrBarCode31.Name = "xrBarCode31"
            Me.xrBarCode31.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode31.SizeF = New System.Drawing.SizeF(250.25F, 65F)
            Me.xrBarCode31.StylePriority.UseBackColor = False
            Me.xrBarCode31.StylePriority.UseBorderWidth = False
            Me.xrBarCode31.StylePriority.UsePadding = False
            pharmacodeGenerator2.PharmacodeType = DevExpress.XtraPrinting.BarCode.PharmacodeType.TwoTrack
            Me.xrBarCode31.Symbology = pharmacodeGenerator2
            Me.xrBarCode31.Text = "32598755"
            Me.xrBarCode31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell87
            ' 
            Me.xrTableCell87.BackColor = System.Drawing.Color.White
            Me.xrTableCell87.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell87.Multiline = True
            Me.xrTableCell87.Name = "xrTableCell87"
            Me.xrTableCell87.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell87.StyleName = "TextPaddingStyle"
            Me.xrTableCell87.StylePriority.UseBackColor = False
            Me.xrTableCell87.Text = resources.GetString("xrTableCell87.Text")
            Me.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell87.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow26
            ' 
            Me.xrTableRow26.BackColor = System.Drawing.Color.White
            Me.xrTableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell76, Me.xrTableCell77, Me.xrTableCell78})
            Me.xrTableRow26.Name = "xrTableRow26"
            Me.xrTableRow26.StylePriority.UseBackColor = False
            Me.xrTableRow26.Weight = 0.18413069809413266R
            ' 
            ' xrTableCell76
            ' 
            Me.xrTableCell76.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell76.BorderColor = System.Drawing.Color.White
            Me.xrTableCell76.BorderWidth = 0F
            Me.xrTableCell76.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell76.Name = "xrTableCell76"
            Me.xrTableCell76.StylePriority.UseBackColor = False
            Me.xrTableCell76.StylePriority.UseBorderColor = False
            Me.xrTableCell76.StylePriority.UseBorderWidth = False
            Me.xrTableCell76.StylePriority.UseFont = False
            Me.xrTableCell76.StylePriority.UseTextAlignment = False
            Me.xrTableCell76.Text = "DataBar"
            Me.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell76.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell77
            ' 
            Me.xrTableCell77.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell77.BorderColor = System.Drawing.Color.White
            Me.xrTableCell77.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell77.BorderWidth = 1F
            Me.xrTableCell77.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode28, Me.xrBarCode27})
            Me.xrTableCell77.Name = "xrTableCell77"
            Me.xrTableCell77.StylePriority.UseBackColor = False
            Me.xrTableCell77.StylePriority.UseBorderColor = False
            Me.xrTableCell77.StylePriority.UseBorders = False
            Me.xrTableCell77.StylePriority.UseBorderWidth = False
            Me.xrTableCell77.StylePriority.UseTextAlignment = False
            Me.xrTableCell77.Text = "xrTableCell77"
            Me.xrTableCell77.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode28
            ' 
            Me.xrBarCode28.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode28.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode28.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrBarCode28.BorderWidth = 0F
            Me.xrBarCode28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode28.LocationFloat = New DevExpress.Utils.PointFloat(4.149467F, 164.6449F)
            Me.xrBarCode28.[Module] = 1.75F
            Me.xrBarCode28.Name = "xrBarCode28"
            Me.xrBarCode28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F)
            Me.xrBarCode28.SizeF = New System.Drawing.SizeF(246.9467F, 47F)
            Me.xrBarCode28.StylePriority.UseBackColor = False
            Me.xrBarCode28.StylePriority.UseBorderWidth = False
            Me.xrBarCode28.StylePriority.UsePadding = False
            Me.xrBarCode28.StylePriority.UseTextAlignment = False
            dataBarGenerator1.SegmentsInRow = 4
            dataBarGenerator1.Type = DevExpress.XtraPrinting.BarCode.DataBarType.Truncated
            Me.xrBarCode28.Symbology = dataBarGenerator1
            Me.xrBarCode28.Text = "123456789"
            Me.xrBarCode28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode27
            ' 
            Me.xrBarCode27.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode27.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode27.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrBarCode27.BorderWidth = 0F
            Me.xrBarCode27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode27.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.75F)
            Me.xrBarCode27.LocationFloat = New DevExpress.Utils.PointFloat(3.149467F, 1F)
            Me.xrBarCode27.[Module] = 1.75F
            Me.xrBarCode27.Name = "xrBarCode27"
            Me.xrBarCode27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F)
            Me.xrBarCode27.SizeF = New System.Drawing.SizeF(247.6923F, 160.4833F)
            Me.xrBarCode27.StylePriority.UseBackColor = False
            Me.xrBarCode27.StylePriority.UseBorderWidth = False
            Me.xrBarCode27.StylePriority.UseFont = False
            Me.xrBarCode27.StylePriority.UsePadding = False
            Me.xrBarCode27.StylePriority.UseTextAlignment = False
            dataBarGenerator2.SegmentsInRow = 4
            dataBarGenerator2.Type = DevExpress.XtraPrinting.BarCode.DataBarType.ExpandedStacked
            Me.xrBarCode27.Symbology = dataBarGenerator2
            Me.xrBarCode27.Text = "01906141410000153202000150"
            Me.xrBarCode27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell78
            ' 
            Me.xrTableCell78.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell78.BorderWidth = 0F
            Me.xrTableCell78.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell78.Multiline = True
            Me.xrTableCell78.Name = "xrTableCell78"
            Me.xrTableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell78.StylePriority.UseBackColor = False
            Me.xrTableCell78.StylePriority.UseBorderColor = False
            Me.xrTableCell78.StylePriority.UseBorderWidth = False
            Me.xrTableCell78.StylePriority.UseFont = False
            Me.xrTableCell78.StylePriority.UsePadding = False
            Me.xrTableCell78.StylePriority.UseTextAlignment = False
            Me.xrTableCell78.Text = resources.GetString("xrTableCell78.Text")
            Me.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell78.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow25
            ' 
            Me.xrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell73, Me.xrTableCell74, Me.xrTableCell75})
            Me.xrTableRow25.Name = "xrTableRow25"
            Me.xrTableRow25.Weight = 0.12569404028090733R
            ' 
            ' xrTableCell73
            ' 
            Me.xrTableCell73.BackColor = System.Drawing.Color.White
            Me.xrTableCell73.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell73.Name = "xrTableCell73"
            Me.xrTableCell73.StylePriority.UseBackColor = False
            Me.xrTableCell73.StylePriority.UseFont = False
            Me.xrTableCell73.StylePriority.UseTextAlignment = False
            Me.xrTableCell73.Text = "UPC Shipping Container Symbol (ITF-14)"
            Me.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell73.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell74
            ' 
            Me.xrTableCell74.BackColor = System.Drawing.Color.White
            Me.xrTableCell74.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode26})
            Me.xrTableCell74.Name = "xrTableCell74"
            Me.xrTableCell74.StylePriority.UseBackColor = False
            Me.xrTableCell74.Text = "xrTableCell74"
            Me.xrTableCell74.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode26
            ' 
            Me.xrBarCode26.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode26.BorderWidth = 0F
            Me.xrBarCode26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode26.LocationFloat = New DevExpress.Utils.PointFloat(1.846186F, 21F)
            Me.xrBarCode26.[Module] = 1.2F
            Me.xrBarCode26.Name = "xrBarCode26"
            Me.xrBarCode26.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 2, 100F)
            Me.xrBarCode26.SizeF = New System.Drawing.SizeF(251F, 100F)
            Me.xrBarCode26.StylePriority.UseBorderWidth = False
            Me.xrBarCode26.StylePriority.UsePadding = False
            Me.xrBarCode26.StylePriority.UseTextAlignment = False
            itF14Generator1.WideNarrowRatio = 3F
            Me.xrBarCode26.Symbology = itF14Generator1
            Me.xrBarCode26.Text = "1234567890123"
            Me.xrBarCode26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell75
            ' 
            Me.xrTableCell75.BackColor = System.Drawing.Color.White
            Me.xrTableCell75.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell75.Multiline = True
            Me.xrTableCell75.Name = "xrTableCell75"
            Me.xrTableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell75.StylePriority.UseBackColor = False
            Me.xrTableCell75.StylePriority.UseFont = False
            Me.xrTableCell75.StylePriority.UsePadding = False
            Me.xrTableCell75.StylePriority.UseTextAlignment = False
            Me.xrTableCell75.Text = resources.GetString("xrTableCell75.Text")
            Me.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell75.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow24
            ' 
            Me.xrTableRow24.BackColor = System.Drawing.Color.White
            Me.xrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell70, Me.xrTableCell71, Me.xrTableCell72})
            Me.xrTableRow24.Name = "xrTableRow24"
            Me.xrTableRow24.StyleName = "TextPaddingStyle"
            Me.xrTableRow24.StylePriority.UseBackColor = False
            Me.xrTableRow24.Weight = 0.084533517554900531R
            ' 
            ' xrTableCell70
            ' 
            Me.xrTableCell70.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell70.BorderWidth = 0F
            Me.xrTableCell70.Name = "xrTableCell70"
            Me.xrTableCell70.StylePriority.UseBackColor = False
            Me.xrTableCell70.StylePriority.UseBorderWidth = False
            Me.xrTableCell70.StylePriority.UseTextAlignment = False
            Me.xrTableCell70.Text = "Data Matrix GS1"
            Me.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell70.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell71
            ' 
            Me.xrTableCell71.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell71.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell71.BorderWidth = 1F
            Me.xrTableCell71.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode25})
            Me.xrTableCell71.Name = "xrTableCell71"
            Me.xrTableCell71.StylePriority.UseBackColor = False
            Me.xrTableCell71.StylePriority.UseBorders = False
            Me.xrTableCell71.StylePriority.UseBorderWidth = False
            Me.xrTableCell71.Text = "xrTableCell71"
            Me.xrTableCell71.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode25
            ' 
            Me.xrBarCode25.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode25.BorderWidth = 0F
            Me.xrBarCode25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode25.LocationFloat = New DevExpress.Utils.PointFloat(9.999985F, 11.28455F)
            Me.xrBarCode25.Name = "xrBarCode25"
            Me.xrBarCode25.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F)
            Me.xrBarCode25.ShowText = False
            Me.xrBarCode25.SizeF = New System.Drawing.SizeF(237.0375F, 75.88062F)
            Me.xrBarCode25.StylePriority.UseBackColor = False
            Me.xrBarCode25.StylePriority.UseBorderWidth = False
            Me.xrBarCode25.StylePriority.UsePadding = False
            Me.xrBarCode25.Symbology = dataMatrixGS1Generator1
            Me.xrBarCode25.Text = "010031234567890621123456789012#300144"
            ' 
            ' xrTableCell72
            ' 
            Me.xrTableCell72.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell72.BorderWidth = 0F
            Me.xrTableCell72.Name = "xrTableCell72"
            Me.xrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell72.StylePriority.UseBackColor = False
            Me.xrTableCell72.StylePriority.UseBorderWidth = False
            Me.xrTableCell72.StylePriority.UsePadding = False
            Me.xrTableCell72.StylePriority.UseTextAlignment = False
            Me.xrTableCell72.Text = resources.GetString("xrTableCell72.Text")
            Me.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell72.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow23
            ' 
            Me.xrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell67, Me.xrTableCell68, Me.xrTableCell69})
            Me.xrTableRow23.Name = "xrTableRow23"
            Me.xrTableRow23.Weight = 0.094268648395414073R
            ' 
            ' xrTableCell67
            ' 
            Me.xrTableCell67.BackColor = System.Drawing.Color.White
            Me.xrTableCell67.Name = "xrTableCell67"
            Me.xrTableCell67.StyleName = "TextPaddingStyle"
            Me.xrTableCell67.StylePriority.UseBackColor = False
            Me.xrTableCell67.StylePriority.UseTextAlignment = False
            Me.xrTableCell67.Text = "Intelligent Mail"
            Me.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell67.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell68
            ' 
            Me.xrTableCell68.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode24})
            Me.xrTableCell68.Name = "xrTableCell68"
            Me.xrTableCell68.Text = "xrTableCell68"
            Me.xrTableCell68.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode24
            ' 
            Me.xrBarCode24.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode24.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode24.BackColor = System.Drawing.Color.White
            Me.xrBarCode24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode24.LocationFloat = New DevExpress.Utils.PointFloat(1.846218F, 3.178914E-05F)
            Me.xrBarCode24.[Module] = 1.75F
            Me.xrBarCode24.Name = "xrBarCode24"
            Me.xrBarCode24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrBarCode24.ShowText = False
            Me.xrBarCode24.SizeF = New System.Drawing.SizeF(251F, 108.3549F)
            Me.xrBarCode24.StylePriority.UseBackColor = False
            Me.xrBarCode24.StylePriority.UsePadding = False
            Me.xrBarCode24.Symbology = intelligentMailGenerator1
            Me.xrBarCode24.Text = "4408200000012345678991203"
            ' 
            ' xrTableCell69
            ' 
            Me.xrTableCell69.BackColor = System.Drawing.Color.White
            Me.xrTableCell69.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell69.Name = "xrTableCell69"
            Me.xrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell69.StylePriority.UseBackColor = False
            Me.xrTableCell69.StylePriority.UseFont = False
            Me.xrTableCell69.StylePriority.UsePadding = False
            Me.xrTableCell69.StylePriority.UseTextAlignment = False
            Me.xrTableCell69.Text = resources.GetString("xrTableCell69.Text")
            Me.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell69.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow27
            ' 
            Me.xrTableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell79, Me.xrTableCell80, Me.xrTableCell81})
            Me.xrTableRow27.Name = "xrTableRow27"
            Me.xrTableRow27.Weight = 0.13272603021968232R
            ' 
            ' xrTableCell79
            ' 
            Me.xrTableCell79.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell79.BorderWidth = 0F
            Me.xrTableCell79.Name = "xrTableCell79"
            Me.xrTableCell79.StyleName = "TextPaddingStyle"
            Me.xrTableCell79.StylePriority.UseBackColor = False
            Me.xrTableCell79.StylePriority.UseBorderWidth = False
            Me.xrTableCell79.StylePriority.UseTextAlignment = False
            Me.xrTableCell79.Text = "Intelligent Mail Package"
            Me.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell79.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell80
            ' 
            Me.xrTableCell80.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell80.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode29})
            Me.xrTableCell80.Name = "xrTableCell80"
            Me.xrTableCell80.StylePriority.UseBackColor = False
            Me.xrTableCell80.Text = "xrTableCell80"
            Me.xrTableCell80.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode29
            ' 
            Me.xrBarCode29.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode29.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode29.BorderWidth = 0F
            Me.xrBarCode29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode29.LocationFloat = New DevExpress.Utils.PointFloat(1.850037F, 0F)
            Me.xrBarCode29.[Module] = 0.65F
            Me.xrBarCode29.Name = "xrBarCode29"
            Me.xrBarCode29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrBarCode29.ShowText = False
            Me.xrBarCode29.SizeF = New System.Drawing.SizeF(250.9962F, 152.559F)
            Me.xrBarCode29.StylePriority.UseBorderWidth = False
            Me.xrBarCode29.StylePriority.UsePadding = False
            Me.xrBarCode29.Symbology = intelligentMailPackageGenerator1
            Me.xrBarCode29.Text = "9212391234567812345671"
            ' 
            ' xrTableCell81
            ' 
            Me.xrTableCell81.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableCell81.BorderWidth = 0F
            Me.xrTableCell81.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell81.Name = "xrTableCell81"
            Me.xrTableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell81.StyleName = "TextPaddingStyle"
            Me.xrTableCell81.StylePriority.UseBackColor = False
            Me.xrTableCell81.StylePriority.UseBorderWidth = False
            Me.xrTableCell81.StylePriority.UseFont = False
            Me.xrTableCell81.StylePriority.UsePadding = False
            Me.xrTableCell81.StylePriority.UseTextAlignment = False
            Me.xrTableCell81.Text = resources.GetString("xrTableCell81.Text")
            Me.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell81.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow21
            ' 
            Me.xrTableRow21.BackColor = System.Drawing.Color.White
            Me.xrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell61, Me.xrTableCell62, Me.xrTableCell63})
            Me.xrTableRow21.Name = "xrTableRow21"
            Me.xrTableRow21.StylePriority.UseBackColor = False
            Me.xrTableRow21.Weight = 0.16560617116237181R
            ' 
            ' xrTableCell61
            ' 
            Me.xrTableCell61.Name = "xrTableCell61"
            Me.xrTableCell61.StyleName = "TextPaddingStyle"
            Me.xrTableCell61.StylePriority.UseTextAlignment = False
            Me.xrTableCell61.Text = "Data Matrix"
            Me.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell61.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell62
            ' 
            Me.xrTableCell62.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode22})
            Me.xrTableCell62.Name = "xrTableCell62"
            Me.xrTableCell62.StylePriority.UseTextAlignment = False
            Me.xrTableCell62.Text = "xrTableCell62"
            Me.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell62.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode22
            ' 
            Me.xrBarCode22.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode22.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode22.LocationFloat = New DevExpress.Utils.PointFloat(1.100014F, 0F)
            Me.xrBarCode22.[Module] = 1F
            Me.xrBarCode22.Name = "xrBarCode22"
            Me.xrBarCode22.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F)
            Me.xrBarCode22.ShowText = False
            Me.xrBarCode22.SizeF = New System.Drawing.SizeF(251.7462F, 190.3522F)
            Me.xrBarCode22.StylePriority.UsePadding = False
            Me.xrBarCode22.StylePriority.UseTextAlignment = False
            Me.xrBarCode22.Symbology = dataMatrixGenerator1
            Me.xrBarCode22.Text = resources.GetString("xrBarCode22.Text")
            Me.xrBarCode22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell63
            ' 
            Me.xrTableCell63.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell63.Multiline = True
            Me.xrTableCell63.Name = "xrTableCell63"
            Me.xrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell63.StylePriority.UseFont = False
            Me.xrTableCell63.StylePriority.UsePadding = False
            Me.xrTableCell63.StylePriority.UseTextAlignment = False
            Me.xrTableCell63.Text = resources.GetString("xrTableCell63.Text")
            Me.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell63.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow20
            ' 
            Me.xrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell58, Me.xrTableCell59, Me.xrTableCell60})
            Me.xrTableRow20.Name = "xrTableRow20"
            Me.xrTableRow20.StylePriority.UseBackColor = False
            Me.xrTableRow20.Weight = 0.1436397802694781R
            ' 
            ' xrTableCell58
            ' 
            Me.xrTableCell58.BorderWidth = 0F
            Me.xrTableCell58.Name = "xrTableCell58"
            Me.xrTableCell58.StyleName = "TextPaddingStyle"
            Me.xrTableCell58.StylePriority.UseBackColor = False
            Me.xrTableCell58.StylePriority.UseBorderWidth = False
            Me.xrTableCell58.StylePriority.UseTextAlignment = False
            Me.xrTableCell58.Text = "PDF417"
            Me.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell58.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell59
            ' 
            Me.xrTableCell59.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell59.BorderWidth = 1F
            Me.xrTableCell59.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode21})
            Me.xrTableCell59.Name = "xrTableCell59"
            Me.xrTableCell59.StylePriority.UseBackColor = False
            Me.xrTableCell59.StylePriority.UseBorders = False
            Me.xrTableCell59.StylePriority.UseBorderWidth = False
            Me.xrTableCell59.Text = "xrTableCell59"
            Me.xrTableCell59.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode21
            ' 
            Me.xrBarCode21.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrBarCode21.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrBarCode21.BorderWidth = 0F
            Me.xrBarCode21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode21.LocationFloat = New DevExpress.Utils.PointFloat(2.345001F, 2.000244F)
            Me.xrBarCode21.[Module] = 1F
            Me.xrBarCode21.Name = "xrBarCode21"
            Me.xrBarCode21.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode21.ShowText = False
            Me.xrBarCode21.SizeF = New System.Drawing.SizeF(248.5011F, 162.1217F)
            Me.xrBarCode21.StylePriority.UseBorderWidth = False
            Me.xrBarCode21.StylePriority.UsePadding = False
            pdF417Generator1.Columns = 9
            pdF417Generator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.ErrorCorrectionLevel.Level0
            pdF417Generator1.Rows = 36
            Me.xrBarCode21.Symbology = pdF417Generator1
            Me.xrBarCode21.Text = resources.GetString("xrBarCode21.Text")
            ' 
            ' xrTableCell60
            ' 
            Me.xrTableCell60.BorderWidth = 0F
            Me.xrTableCell60.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell60.Multiline = True
            Me.xrTableCell60.Name = "xrTableCell60"
            Me.xrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell60.StylePriority.UseBackColor = False
            Me.xrTableCell60.StylePriority.UseBorderWidth = False
            Me.xrTableCell60.StylePriority.UsePadding = False
            Me.xrTableCell60.StylePriority.UseTextAlignment = False
            Me.xrTableCell60.Text = resources.GetString("xrTableCell60.Text")
            Me.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell60.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.BackColor = System.Drawing.Color.White
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.StylePriority.UseBackColor = False
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 0.062805762830391229R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.StyleName = "TextPaddingStyle"
            Me.xrTableCell4.StylePriority.UseBackColor = False
            Me.xrTableCell4.Text = "Codabar"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode1})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.StylePriority.UseBackColor = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell5.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 12F)
            Me.xrBarCode1.[Module] = 1F
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode1.StylePriority.UseBackColor = False
            codabarGenerator1.WideNarrowRatio = 2F
            Me.xrBarCode1.Symbology = codabarGenerator1
            Me.xrBarCode1.Text = "0123456789+-/:.$"
            Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell6.StyleName = "TextPaddingStyle"
            Me.xrTableCell6.StylePriority.UseBackColor = False
            Me.xrTableCell6.Text = resources.GetString("xrTableCell6.Text")
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell6.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((235)))))), (CInt(((CByte((235)))))))
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.StylePriority.UseBackColor = False
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.080640303642661892R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BorderWidth = 0F
            Me.xrTableCell7.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.StyleName = "TextPaddingStyle"
            Me.xrTableCell7.StylePriority.UseBackColor = False
            Me.xrTableCell7.StylePriority.UseBorderWidth = False
            Me.xrTableCell7.Text = "Code 11"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell8.BorderWidth = 1F
            Me.xrTableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode2})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StylePriority.UseBackColor = False
            Me.xrTableCell8.StylePriority.UseBorders = False
            Me.xrTableCell8.StylePriority.UseBorderWidth = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode2
            ' 
            Me.xrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode2.BorderWidth = 0F
            Me.xrBarCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 18F)
            Me.xrBarCode2.Name = "xrBarCode2"
            Me.xrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode2.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode2.StylePriority.UseBackColor = False
            Me.xrBarCode2.StylePriority.UseBorderWidth = False
            Me.xrBarCode2.Symbology = code11Generator1
            Me.xrBarCode2.Text = "0123456"
            Me.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BorderWidth = 0F
            Me.xrTableCell9.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell9.StyleName = "TextPaddingStyle"
            Me.xrTableCell9.StylePriority.UseBackColor = False
            Me.xrTableCell9.StylePriority.UseBorderWidth = False
            Me.xrTableCell9.Text = resources.GetString("xrTableCell9.Text")
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell9.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.BackColor = System.Drawing.Color.White
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.StylePriority.UseBackColor = False
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.12950549263905303R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.StyleName = "TextPaddingStyle"
            Me.xrTableCell10.StylePriority.UseBackColor = False
            Me.xrTableCell10.Text = "Code 128"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode3})
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell11.StylePriority.UseBackColor = False
            Me.xrTableCell11.Text = "xrTableCell11"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell11.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode3
            ' 
            Me.xrBarCode3.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode3.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 42F)
            Me.xrBarCode3.[Module] = 1F
            Me.xrBarCode3.Name = "xrBarCode3"
            Me.xrBarCode3.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode3.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode3.StylePriority.UseBackColor = False
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
            Me.xrBarCode3.Symbology = code128Generator1
            Me.xrBarCode3.Text = "XRBarCode 0123456"
            Me.xrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell12.StyleName = "TextPaddingStyle"
            Me.xrTableCell12.StylePriority.UseBackColor = False
            Me.xrTableCell12.Text = resources.GetString("xrTableCell12.Text")
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell12.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.StylePriority.UseBackColor = False
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 0.090355568115820725R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BorderWidth = 0F
            Me.xrTableCell13.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.StyleName = "TextPaddingStyle"
            Me.xrTableCell13.StylePriority.UseBackColor = False
            Me.xrTableCell13.StylePriority.UseBorderWidth = False
            Me.xrTableCell13.Text = "EAN128"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell14.BorderWidth = 1F
            Me.xrTableCell14.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode4})
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell14.StylePriority.UseBackColor = False
            Me.xrTableCell14.StylePriority.UseBorders = False
            Me.xrTableCell14.StylePriority.UseBorderWidth = False
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell14.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode4
            ' 
            Me.xrBarCode4.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode4.BorderWidth = 0F
            Me.xrBarCode4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode4.LocationFloat = New DevExpress.Utils.PointFloat(4.149467F, 23.8335F)
            Me.xrBarCode4.[Module] = 0.8F
            Me.xrBarCode4.Name = "xrBarCode4"
            Me.xrBarCode4.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode4.SizeF = New System.Drawing.SizeF(242.8879F, 59F)
            Me.xrBarCode4.StylePriority.UseBackColor = False
            Me.xrBarCode4.StylePriority.UseBorderWidth = False
            eaN128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
            Me.xrBarCode4.Symbology = eaN128Generator1
            Me.xrBarCode4.Text = "XRBarCode 0123456"
            Me.xrBarCode4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.BorderWidth = 0F
            Me.xrTableCell15.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell15.StyleName = "TextPaddingStyle"
            Me.xrTableCell15.StylePriority.UseBackColor = False
            Me.xrTableCell15.StylePriority.UseBorderWidth = False
            Me.xrTableCell15.Text = resources.GetString("xrTableCell15.Text")
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell15.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.BackColor = System.Drawing.Color.White
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell22, Me.xrTableCell23, Me.xrTableCell24})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow8.StylePriority.UseBackColor = False
            Me.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow8.Weight = 0.0881799351031717R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell22.Multiline = True
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell22.StyleName = "TextPaddingStyle"
            Me.xrTableCell22.StylePriority.UseBackColor = False
            Me.xrTableCell22.Text = "Code 39"
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell22.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode5})
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell23.StylePriority.UseBackColor = False
            Me.xrTableCell23.Text = "xrTableCell23"
            Me.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell23.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode5
            ' 
            Me.xrBarCode5.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode5.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 20F)
            Me.xrBarCode5.[Module] = 1F
            Me.xrBarCode5.Name = "xrBarCode5"
            Me.xrBarCode5.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode5.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode5.StylePriority.UseBackColor = False
            code39Generator1.WideNarrowRatio = 3F
            Me.xrBarCode5.Symbology = code39Generator1
            Me.xrBarCode5.Text = "XRBARCODE"
            Me.xrBarCode5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell24.StyleName = "TextPaddingStyle"
            Me.xrTableCell24.StylePriority.UseBackColor = False
            Me.xrTableCell24.Text = resources.GetString("xrTableCell24.Text")
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell24.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow9
            ' 
            Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell25, Me.xrTableCell26, Me.xrTableCell27})
            Me.xrTableRow9.Name = "xrTableRow9"
            Me.xrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow9.StylePriority.UseBackColor = False
            Me.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow9.Weight = 0.083830793097216263R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.BorderWidth = 0F
            Me.xrTableCell25.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell25.Multiline = True
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell25.StyleName = "TextPaddingStyle"
            Me.xrTableCell25.StylePriority.UseBackColor = False
            Me.xrTableCell25.StylePriority.UseBorderWidth = False
            Me.xrTableCell25.Text = "Code 39 Extended"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell25.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell26.BorderWidth = 1F
            Me.xrTableCell26.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode6})
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell26.StylePriority.UseBackColor = False
            Me.xrTableCell26.StylePriority.UseBorders = False
            Me.xrTableCell26.StylePriority.UseBorderWidth = False
            Me.xrTableCell26.Text = "xrTableCell26"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell26.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode6
            ' 
            Me.xrBarCode6.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode6.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode6.BorderWidth = 0F
            Me.xrBarCode6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode6.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 18F)
            Me.xrBarCode6.[Module] = 1F
            Me.xrBarCode6.Name = "xrBarCode6"
            Me.xrBarCode6.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode6.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode6.StylePriority.UseBackColor = False
            Me.xrBarCode6.StylePriority.UseBorderWidth = False
            code39ExtendedGenerator1.WideNarrowRatio = 3F
            Me.xrBarCode6.Symbology = code39ExtendedGenerator1
            Me.xrBarCode6.Text = "BarCODE"
            Me.xrBarCode6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.BorderWidth = 0F
            Me.xrTableCell27.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell27.StyleName = "TextPaddingStyle"
            Me.xrTableCell27.StylePriority.UseBackColor = False
            Me.xrTableCell27.StylePriority.UseBorderWidth = False
            Me.xrTableCell27.Text = resources.GetString("xrTableCell27.Text")
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell27.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow10
            ' 
            Me.xrTableRow10.BackColor = System.Drawing.Color.White
            Me.xrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell28, Me.xrTableCell29, Me.xrTableCell30})
            Me.xrTableRow10.Name = "xrTableRow10"
            Me.xrTableRow10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow10.StylePriority.UseBackColor = False
            Me.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow10.Weight = 0.092530570560227524R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell28.Multiline = True
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell28.StyleName = "TextPaddingStyle"
            Me.xrTableCell28.StylePriority.UseBackColor = False
            Me.xrTableCell28.Text = "Code 93"
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell28.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode7})
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell29.StylePriority.UseBackColor = False
            Me.xrTableCell29.Text = "xrTableCell29"
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell29.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode7
            ' 
            Me.xrBarCode7.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode7.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode7.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 21F)
            Me.xrBarCode7.[Module] = 1F
            Me.xrBarCode7.Name = "xrBarCode7"
            Me.xrBarCode7.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode7.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode7.StylePriority.UseBackColor = False
            Me.xrBarCode7.Symbology = code93Generator1
            Me.xrBarCode7.Text = "XRBARCODE"
            Me.xrBarCode7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell30.StyleName = "TextPaddingStyle"
            Me.xrTableCell30.StylePriority.UseBackColor = False
            Me.xrTableCell30.Text = resources.GetString("xrTableCell30.Text")
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell30.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow11
            ' 
            Me.xrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell31, Me.xrTableCell32, Me.xrTableCell33})
            Me.xrTableRow11.Name = "xrTableRow11"
            Me.xrTableRow11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow11.StylePriority.UseBackColor = False
            Me.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow11.Weight = 0.0686058224492926R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.BorderWidth = 0F
            Me.xrTableCell31.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell31.Multiline = True
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell31.StyleName = "TextPaddingStyle"
            Me.xrTableCell31.StylePriority.UseBackColor = False
            Me.xrTableCell31.StylePriority.UseBorderWidth = False
            Me.xrTableCell31.Text = "Code 93 Extended"
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell31.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell32.BorderWidth = 1F
            Me.xrTableCell32.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode8})
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell32.StylePriority.UseBackColor = False
            Me.xrTableCell32.StylePriority.UseBorders = False
            Me.xrTableCell32.StylePriority.UseBorderWidth = False
            Me.xrTableCell32.Text = "xrTableCell32"
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell32.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode8
            ' 
            Me.xrBarCode8.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode8.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode8.BorderWidth = 0F
            Me.xrBarCode8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode8.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 9F)
            Me.xrBarCode8.[Module] = 1F
            Me.xrBarCode8.Name = "xrBarCode8"
            Me.xrBarCode8.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode8.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode8.StylePriority.UseBackColor = False
            Me.xrBarCode8.StylePriority.UseBorderWidth = False
            Me.xrBarCode8.Symbology = code93ExtendedGenerator1
            Me.xrBarCode8.Text = "XRBarCode"
            Me.xrBarCode8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.BorderWidth = 0F
            Me.xrTableCell33.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell33.StyleName = "TextPaddingStyle"
            Me.xrTableCell33.StylePriority.UseBackColor = False
            Me.xrTableCell33.StylePriority.UseBorderWidth = False
            Me.xrTableCell33.Text = resources.GetString("xrTableCell33.Text")
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell33.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow12
            ' 
            Me.xrTableRow12.BackColor = System.Drawing.Color.White
            Me.xrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell34, Me.xrTableCell35, Me.xrTableCell36})
            Me.xrTableRow12.Name = "xrTableRow12"
            Me.xrTableRow12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow12.StylePriority.UseBackColor = False
            Me.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow12.Weight = 0.063530478230094292R
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell34.Multiline = True
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell34.StyleName = "TextPaddingStyle"
            Me.xrTableCell34.StylePriority.UseBackColor = False
            Me.xrTableCell34.Text = "Industrial" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "2 of 5"
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell34.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode9})
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell35.StylePriority.UseBackColor = False
            Me.xrTableCell35.Text = "xrTableCell35"
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell35.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode9
            ' 
            Me.xrBarCode9.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode9.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode9.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 7F)
            Me.xrBarCode9.[Module] = 1F
            Me.xrBarCode9.Name = "xrBarCode9"
            Me.xrBarCode9.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode9.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode9.StylePriority.UseBackColor = False
            Me.xrBarCode9.Symbology = industrial2of5Generator1
            Me.xrBarCode9.Text = "0123456789"
            Me.xrBarCode9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell36
            ' 
            Me.xrTableCell36.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell36.Name = "xrTableCell36"
            Me.xrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell36.StyleName = "TextPaddingStyle"
            Me.xrTableCell36.StylePriority.UseBackColor = False
            Me.xrTableCell36.Text = resources.GetString("xrTableCell36.Text")
            Me.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell36.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow13
            ' 
            Me.xrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell37, Me.xrTableCell38, Me.xrTableCell39})
            Me.xrTableRow13.Name = "xrTableRow13"
            Me.xrTableRow13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow13.StylePriority.UseBackColor = False
            Me.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow13.Weight = 0.087455435424183117R
            ' 
            ' xrTableCell37
            ' 
            Me.xrTableCell37.BorderWidth = 0F
            Me.xrTableCell37.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell37.Multiline = True
            Me.xrTableCell37.Name = "xrTableCell37"
            Me.xrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell37.StyleName = "TextPaddingStyle"
            Me.xrTableCell37.StylePriority.UseBackColor = False
            Me.xrTableCell37.StylePriority.UseBorderWidth = False
            Me.xrTableCell37.Text = "Matrix" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "2 of 5"
            Me.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell37.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell38
            ' 
            Me.xrTableCell38.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell38.BorderWidth = 1F
            Me.xrTableCell38.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode10})
            Me.xrTableCell38.Name = "xrTableCell38"
            Me.xrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell38.StylePriority.UseBackColor = False
            Me.xrTableCell38.StylePriority.UseBorders = False
            Me.xrTableCell38.StylePriority.UseBorderWidth = False
            Me.xrTableCell38.Text = "xrTableCell38"
            Me.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell38.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode10
            ' 
            Me.xrBarCode10.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode10.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode10.BorderWidth = 0F
            Me.xrBarCode10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode10.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 21F)
            Me.xrBarCode10.[Module] = 1F
            Me.xrBarCode10.Name = "xrBarCode10"
            Me.xrBarCode10.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode10.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode10.StylePriority.UseBackColor = False
            Me.xrBarCode10.StylePriority.UseBorderWidth = False
            Me.xrBarCode10.Symbology = matrix2of5Generator1
            Me.xrBarCode10.Text = "00123456789"
            Me.xrBarCode10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell39
            ' 
            Me.xrTableCell39.BorderWidth = 0F
            Me.xrTableCell39.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell39.Name = "xrTableCell39"
            Me.xrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell39.StyleName = "TextPaddingStyle"
            Me.xrTableCell39.StylePriority.UseBackColor = False
            Me.xrTableCell39.StylePriority.UseBorderWidth = False
            Me.xrTableCell39.Text = resources.GetString("xrTableCell39.Text")
            Me.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell39.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.BackColor = System.Drawing.Color.White
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow6.StylePriority.UseBackColor = False
            Me.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow6.Weight = 0.059905205334885074R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell16.Multiline = True
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell16.StyleName = "TextPaddingStyle"
            Me.xrTableCell16.StylePriority.UseBackColor = False
            Me.xrTableCell16.Text = "Interleaved" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "2 of 5"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell16.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode11})
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell17.StylePriority.UseBackColor = False
            Me.xrTableCell17.Text = "xrTableCell17"
            Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell17.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode11
            ' 
            Me.xrBarCode11.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode11.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode11.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 6F)
            Me.xrBarCode11.[Module] = 1F
            Me.xrBarCode11.Name = "xrBarCode11"
            Me.xrBarCode11.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode11.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode11.StylePriority.UseBackColor = False
            interleaved2of5Generator1.WideNarrowRatio = 3F
            Me.xrBarCode11.Symbology = interleaved2of5Generator1
            Me.xrBarCode11.Text = "0123456789"
            Me.xrBarCode11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell18.StyleName = "TextPaddingStyle"
            Me.xrTableCell18.StylePriority.UseBackColor = False
            Me.xrTableCell18.Text = "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard " & "2 of 5 symbology. It is used primarily in the distribution and warehouse industr" & "y."
            Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell18.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell19, Me.xrTableCell20, Me.xrTableCell21})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow7.StylePriority.UseBackColor = False
            Me.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow7.Weight = 0.066431042363160886R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.BorderWidth = 0F
            Me.xrTableCell19.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell19.Multiline = True
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell19.StyleName = "TextPaddingStyle"
            Me.xrTableCell19.StylePriority.UseBackColor = False
            Me.xrTableCell19.StylePriority.UseBorderWidth = False
            Me.xrTableCell19.Text = "EAN13"
            Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell19.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.BorderWidth = 0F
            Me.xrTableCell20.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode12})
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell20.StylePriority.UseBackColor = False
            Me.xrTableCell20.StylePriority.UseBorderWidth = False
            Me.xrTableCell20.Text = "xrTableCell20"
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell20.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode12
            ' 
            Me.xrBarCode12.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode12.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode12.BorderWidth = 0F
            Me.xrBarCode12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode12.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 12F)
            Me.xrBarCode12.[Module] = 1F
            Me.xrBarCode12.Name = "xrBarCode12"
            Me.xrBarCode12.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode12.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode12.StylePriority.UseBackColor = False
            Me.xrBarCode12.StylePriority.UseBorderWidth = False
            Me.xrBarCode12.Symbology = eaN13Generator1
            Me.xrBarCode12.Text = "978531800111"
            Me.xrBarCode12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.BorderWidth = 0F
            Me.xrTableCell21.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell21.StyleName = "TextPaddingStyle"
            Me.xrTableCell21.StylePriority.UseBackColor = False
            Me.xrTableCell21.StylePriority.UseBorderWidth = False
            Me.xrTableCell21.Text = "EAN-13, based upon the UPC-A standard, was implemented by the International Artic" & "le Numbering Association (EAN) in Europe."
            Me.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell21.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow14
            ' 
            Me.xrTableRow14.BackColor = System.Drawing.Color.White
            Me.xrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell40, Me.xrTableCell41, Me.xrTableCell42})
            Me.xrTableRow14.Name = "xrTableRow14"
            Me.xrTableRow14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow14.StylePriority.UseBackColor = False
            Me.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow14.Weight = 0.0555552137211925R
            ' 
            ' xrTableCell40
            ' 
            Me.xrTableCell40.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell40.Multiline = True
            Me.xrTableCell40.Name = "xrTableCell40"
            Me.xrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell40.StyleName = "TextPaddingStyle"
            Me.xrTableCell40.StylePriority.UseBackColor = False
            Me.xrTableCell40.Text = "EAN8"
            Me.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell40.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell41
            ' 
            Me.xrTableCell41.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode13})
            Me.xrTableCell41.Name = "xrTableCell41"
            Me.xrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell41.StylePriority.UseBackColor = False
            Me.xrTableCell41.Text = "xrTableCell41"
            Me.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell41.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode13
            ' 
            Me.xrBarCode13.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode13.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode13.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 2F)
            Me.xrBarCode13.[Module] = 1F
            Me.xrBarCode13.Name = "xrBarCode13"
            Me.xrBarCode13.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode13.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode13.StylePriority.UseBackColor = False
            Me.xrBarCode13.Symbology = eaN8Generator1
            Me.xrBarCode13.Text = "0123456"
            Me.xrBarCode13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell42
            ' 
            Me.xrTableCell42.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell42.Name = "xrTableCell42"
            Me.xrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell42.StyleName = "TextPaddingStyle"
            Me.xrTableCell42.StylePriority.UseBackColor = False
            Me.xrTableCell42.Text = "EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a ""short"" barc" & "ode for small packages."
            Me.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell42.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow15
            ' 
            Me.xrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell43, Me.xrTableCell44, Me.xrTableCell45})
            Me.xrTableRow15.Name = "xrTableRow15"
            Me.xrTableRow15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow15.StylePriority.UseBackColor = False
            Me.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow15.Weight = 0.096155415332787889R
            ' 
            ' xrTableCell43
            ' 
            Me.xrTableCell43.BorderWidth = 0F
            Me.xrTableCell43.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell43.Multiline = True
            Me.xrTableCell43.Name = "xrTableCell43"
            Me.xrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell43.StyleName = "TextPaddingStyle"
            Me.xrTableCell43.StylePriority.UseBackColor = False
            Me.xrTableCell43.StylePriority.UseBorderWidth = False
            Me.xrTableCell43.Text = "MSI/Plessey"
            Me.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell43.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell44
            ' 
            Me.xrTableCell44.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell44.BorderWidth = 1F
            Me.xrTableCell44.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode14})
            Me.xrTableCell44.Name = "xrTableCell44"
            Me.xrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell44.StylePriority.UseBackColor = False
            Me.xrTableCell44.StylePriority.UseBorders = False
            Me.xrTableCell44.StylePriority.UseBorderWidth = False
            Me.xrTableCell44.Text = "xrTableCell44"
            Me.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell44.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode14
            ' 
            Me.xrBarCode14.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode14.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode14.BorderWidth = 0F
            Me.xrBarCode14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode14.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 25F)
            Me.xrBarCode14.[Module] = 1F
            Me.xrBarCode14.Name = "xrBarCode14"
            Me.xrBarCode14.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode14.SizeF = New System.Drawing.SizeF(250F, 62.11206F)
            Me.xrBarCode14.StylePriority.UseBackColor = False
            Me.xrBarCode14.StylePriority.UseBorderWidth = False
            Me.xrBarCode14.Symbology = codeMSIGenerator1
            Me.xrBarCode14.Text = "0123456789"
            Me.xrBarCode14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell45
            ' 
            Me.xrTableCell45.BorderWidth = 0F
            Me.xrTableCell45.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell45.Name = "xrTableCell45"
            Me.xrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell45.StyleName = "TextPaddingStyle"
            Me.xrTableCell45.StylePriority.UseBackColor = False
            Me.xrTableCell45.StylePriority.UseBorderWidth = False
            Me.xrTableCell45.Text = resources.GetString("xrTableCell45.Text")
            Me.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell45.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow16
            ' 
            Me.xrTableRow16.BackColor = System.Drawing.Color.White
            Me.xrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell46, Me.xrTableCell47, Me.xrTableCell48})
            Me.xrTableRow16.Name = "xrTableRow16"
            Me.xrTableRow16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow16.StylePriority.UseBackColor = False
            Me.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow16.Weight = 0.085280652019271208R
            ' 
            ' xrTableCell46
            ' 
            Me.xrTableCell46.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell46.Multiline = True
            Me.xrTableCell46.Name = "xrTableCell46"
            Me.xrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell46.StyleName = "TextPaddingStyle"
            Me.xrTableCell46.StylePriority.UseBackColor = False
            Me.xrTableCell46.Text = "UPC-A"
            Me.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell46.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell47
            ' 
            Me.xrTableCell47.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode15})
            Me.xrTableCell47.Name = "xrTableCell47"
            Me.xrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell47.StylePriority.UseBackColor = False
            Me.xrTableCell47.Text = "xrTableCell47"
            Me.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell47.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode15
            ' 
            Me.xrBarCode15.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode15.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode15.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 19F)
            Me.xrBarCode15.[Module] = 1F
            Me.xrBarCode15.Name = "xrBarCode15"
            Me.xrBarCode15.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode15.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode15.StylePriority.UseBackColor = False
            Me.xrBarCode15.Symbology = upcaGenerator1
            Me.xrBarCode15.Text = "78534235463"
            Me.xrBarCode15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell48
            ' 
            Me.xrTableCell48.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell48.Name = "xrTableCell48"
            Me.xrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell48.StyleName = "TextPaddingStyle"
            Me.xrTableCell48.StylePriority.UseBackColor = False
            Me.xrTableCell48.Text = resources.GetString("xrTableCell48.Text")
            Me.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell48.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow17
            ' 
            Me.xrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell49, Me.xrTableCell50, Me.xrTableCell51})
            Me.xrTableRow17.Name = "xrTableRow17"
            Me.xrTableRow17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow17.StylePriority.UseBackColor = False
            Me.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow17.Weight = 0.088449476476530772R
            ' 
            ' xrTableCell49
            ' 
            Me.xrTableCell49.BorderWidth = 0F
            Me.xrTableCell49.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell49.Multiline = True
            Me.xrTableCell49.Name = "xrTableCell49"
            Me.xrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell49.StyleName = "TextPaddingStyle"
            Me.xrTableCell49.StylePriority.UseBackColor = False
            Me.xrTableCell49.StylePriority.UseBorderWidth = False
            Me.xrTableCell49.Text = "UPC-E"
            Me.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell49.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell50
            ' 
            Me.xrTableCell50.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell50.BorderWidth = 1F
            Me.xrTableCell50.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode16})
            Me.xrTableCell50.Name = "xrTableCell50"
            Me.xrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell50.StylePriority.UseBackColor = False
            Me.xrTableCell50.StylePriority.UseBorders = False
            Me.xrTableCell50.StylePriority.UseBorderWidth = False
            Me.xrTableCell50.Text = "xrTableCell50"
            Me.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell50.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode16
            ' 
            Me.xrBarCode16.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode16.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode16.BorderWidth = 0F
            Me.xrBarCode16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode16.LocationFloat = New DevExpress.Utils.PointFloat(1.04174F, 20F)
            Me.xrBarCode16.[Module] = 1F
            Me.xrBarCode16.Name = "xrBarCode16"
            Me.xrBarCode16.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode16.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode16.StylePriority.UseBackColor = False
            Me.xrBarCode16.StylePriority.UseBorderWidth = False
            Me.xrBarCode16.Symbology = upcE0Generator1
            Me.xrBarCode16.Text = "4210000526"
            Me.xrBarCode16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell51
            ' 
            Me.xrTableCell51.BorderWidth = 0F
            Me.xrTableCell51.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell51.Name = "xrTableCell51"
            Me.xrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell51.StyleName = "TextPaddingStyle"
            Me.xrTableCell51.StylePriority.UseBackColor = False
            Me.xrTableCell51.StylePriority.UseBorderWidth = False
            Me.xrTableCell51.Text = resources.GetString("xrTableCell51.Text")
            Me.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell51.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow18
            ' 
            Me.xrTableRow18.BackColor = System.Drawing.Color.White
            Me.xrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell52, Me.xrTableCell53, Me.xrTableCell54})
            Me.xrTableRow18.Name = "xrTableRow18"
            Me.xrTableRow18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow18.StylePriority.UseBackColor = False
            Me.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow18.Weight = 0.13984097407903812R
            ' 
            ' xrTableCell52
            ' 
            Me.xrTableCell52.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell52.Multiline = True
            Me.xrTableCell52.Name = "xrTableCell52"
            Me.xrTableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell52.StyleName = "TextPaddingStyle"
            Me.xrTableCell52.StylePriority.UseBackColor = False
            Me.xrTableCell52.Text = "EAN13" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "with" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "UPC Suppl. 2"
            Me.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell52.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell53
            ' 
            Me.xrTableCell53.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode19, Me.xrBarCode17})
            Me.xrTableCell53.Name = "xrTableCell53"
            Me.xrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell53.StylePriority.UseBackColor = False
            Me.xrTableCell53.Text = "xrTableCell53"
            Me.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell53.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode19
            ' 
            Me.xrBarCode19.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode19.LocationFloat = New DevExpress.Utils.PointFloat(159F, 48.3335F)
            Me.xrBarCode19.[Module] = 1F
            Me.xrBarCode19.Name = "xrBarCode19"
            Me.xrBarCode19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F)
            Me.xrBarCode19.SizeF = New System.Drawing.SizeF(83.84622F, 60F)
            Me.xrBarCode19.StylePriority.UseBackColor = False
            Me.xrBarCode19.Symbology = upcSupplemental2Generator1
            Me.xrBarCode19.Text = "01"
            Me.xrBarCode19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrBarCode17
            ' 
            Me.xrBarCode17.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode17.LocationFloat = New DevExpress.Utils.PointFloat(25.00001F, 48.3335F)
            Me.xrBarCode17.[Module] = 1F
            Me.xrBarCode17.Name = "xrBarCode17"
            Me.xrBarCode17.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode17.SizeF = New System.Drawing.SizeF(133F, 60F)
            Me.xrBarCode17.StylePriority.UseBackColor = False
            Me.xrBarCode17.Symbology = eaN13Generator2
            Me.xrBarCode17.Text = "978531800111"
            Me.xrBarCode17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell54
            ' 
            Me.xrTableCell54.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell54.Name = "xrTableCell54"
            Me.xrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell54.StyleName = "TextPaddingStyle"
            Me.xrTableCell54.StylePriority.UseBackColor = False
            Me.xrTableCell54.Text = resources.GetString("xrTableCell54.Text")
            Me.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell54.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow19
            ' 
            Me.xrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell55, Me.xrTableCell56, Me.xrTableCell57})
            Me.xrTableRow19.Name = "xrTableRow19"
            Me.xrTableRow19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow19.StylePriority.UseBackColor = False
            Me.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow19.Weight = 0.058001705662949148R
            ' 
            ' xrTableCell55
            ' 
            Me.xrTableCell55.BorderWidth = 0F
            Me.xrTableCell55.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell55.Multiline = True
            Me.xrTableCell55.Name = "xrTableCell55"
            Me.xrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell55.StyleName = "TextPaddingStyle"
            Me.xrTableCell55.StylePriority.UseBackColor = False
            Me.xrTableCell55.StylePriority.UseBorderWidth = False
            Me.xrTableCell55.Text = "EAN13" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "with" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "UPC Suppl. 5"
            Me.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell55.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell56
            ' 
            Me.xrTableCell56.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableCell56.BorderWidth = 1F
            Me.xrTableCell56.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode18, Me.xrBarCode20})
            Me.xrTableCell56.Name = "xrTableCell56"
            Me.xrTableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell56.StylePriority.UseBackColor = False
            Me.xrTableCell56.StylePriority.UseBorders = False
            Me.xrTableCell56.StylePriority.UseBorderWidth = False
            Me.xrTableCell56.Text = "xrTableCell56"
            Me.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell56.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode18
            ' 
            Me.xrBarCode18.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode18.BorderWidth = 0F
            Me.xrBarCode18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode18.LocationFloat = New DevExpress.Utils.PointFloat(25F, 0F)
            Me.xrBarCode18.[Module] = 1F
            Me.xrBarCode18.Name = "xrBarCode18"
            Me.xrBarCode18.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode18.SizeF = New System.Drawing.SizeF(133F, 60F)
            Me.xrBarCode18.StylePriority.UseBackColor = False
            Me.xrBarCode18.StylePriority.UseBorderWidth = False
            Me.xrBarCode18.Symbology = eaN13Generator3
            Me.xrBarCode18.Text = "978531800111"
            Me.xrBarCode18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode20
            ' 
            Me.xrBarCode20.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode20.BorderWidth = 0F
            Me.xrBarCode20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")})
            Me.xrBarCode20.LocationFloat = New DevExpress.Utils.PointFloat(158F, 0F)
            Me.xrBarCode20.[Module] = 1F
            Me.xrBarCode20.Name = "xrBarCode20"
            Me.xrBarCode20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F)
            Me.xrBarCode20.SizeF = New System.Drawing.SizeF(75F, 60F)
            Me.xrBarCode20.StylePriority.UseBackColor = False
            Me.xrBarCode20.StylePriority.UseBorderWidth = False
            Me.xrBarCode20.Symbology = upcSupplemental5Generator1
            Me.xrBarCode20.Text = "01234"
            Me.xrBarCode20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell57
            ' 
            Me.xrTableCell57.BorderWidth = 0F
            Me.xrTableCell57.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableCell57.Name = "xrTableCell57"
            Me.xrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell57.StyleName = "TextPaddingStyle"
            Me.xrTableCell57.StylePriority.UseBackColor = False
            Me.xrTableCell57.StylePriority.UseBorderWidth = False
            Me.xrTableCell57.Text = "5-digit supplemental barcodes are used on books to indicate a suggested retail pr" & "ice."
            Me.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell57.Weight = 0.47324913892078074R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLabel3})
            Me.ReportHeader.HeightF = 32F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(42F, 25F)
            Me.xrLabel1.Text = "Note: "
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(43F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(627F, 25F)
            Me.xrLabel3.Text = "You may print the following barcodes and then read them by any suitable barcode s" & "canner"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomJustify
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.BackColor = System.Drawing.Color.Black
            Me.PageHeader.BorderColor = System.Drawing.Color.White
            Me.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.PageHeader.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageHeader.ForeColor = System.Drawing.Color.White
            Me.PageHeader.HeightF = 34F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(670F, 34F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Text = "Symbology"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "Example"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Text = "Description"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.47324913892078074R
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 93F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' TextPaddingStyle
            ' 
            Me.TextPaddingStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.TextPaddingStyle.Name = "TextPaddingStyle"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 86F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' AutoModuleParameter
            ' 
            Me.AutoModuleParameter.Description = "AutoModule"
            Me.AutoModuleParameter.Name = "AutoModuleParameter"
            Me.AutoModuleParameter.Type = GetType(Boolean)
            Me.AutoModuleParameter.ValueInfo = "False"
            ' 
            ' BarCodeTypesReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.Margins = New DevExpress.Drawing.DXMargins(98F, 80F, 86F, 93F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.AutoModuleParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.TextPaddingStyle})
            Me.Version = "24.2"
            xrWatermark1.Id = "Watermark1"
            Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {xrWatermark1})
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrTableRow20 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell58 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell59 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode21 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell60 As DevExpress.XtraReports.UI.XRTableCell

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private AutoModuleParameter As DevExpress.XtraReports.Parameters.Parameter

        Private xrTableCell61 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell62 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell63 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode22 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow21 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableRow23 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell67 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell68 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode24 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell69 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow24 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell70 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell71 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode25 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell72 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow26 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell76 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell77 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell78 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow25 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell73 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell75 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode28 As DevExpress.XtraReports.UI.XRBarCode

        Private xrBarCode27 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell74 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode26 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow27 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell79 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell80 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell81 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode29 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow28 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell82 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell83 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell84 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode30 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow29 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell85 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell86 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode31 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell87 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow31 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell91 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell92 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode32 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell93 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow30 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell88 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell89 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode33 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell90 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow32 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell94 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell95 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode34 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell96 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow33 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell97 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell98 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode35 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell99 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow34 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell100 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell102 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell101 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode39 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow35 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell103 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell104 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode36 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell105 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode23 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableRow36 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell106 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell107 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode37 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell108 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow22 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell64 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell65 As DevExpress.XtraReports.UI.XRTableCell

        Private xrBarCode38 As DevExpress.XtraReports.UI.XRBarCode

        Private xrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
