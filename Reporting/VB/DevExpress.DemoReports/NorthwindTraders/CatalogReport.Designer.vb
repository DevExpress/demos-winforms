Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.NorthwindTraders

    Partial Class CatalogReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbFallCatalog As DevExpress.XtraReports.UI.XRLabel

        Private lbCommitment As DevExpress.XtraReports.UI.XRLabel

        Private lbCommitment1 As DevExpress.XtraReports.UI.XRLabel

        Private lbTourTitle As DevExpress.XtraReports.UI.XRLabel

        Private lbTourParagraph As DevExpress.XtraReports.UI.XRLabel

        Private lbTourParagraph1 As DevExpress.XtraReports.UI.XRLabel

        Private lbTourParagraph2 As DevExpress.XtraReports.UI.XRLabel

        Private lbTourParagraph3 As DevExpress.XtraReports.UI.XRLabel

        Private lbTourParagraph4 As DevExpress.XtraReports.UI.XRLabel

        Private pbLargeLogo As DevExpress.XtraReports.UI.XRPictureBox

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private lbDesciption As DevExpress.XtraReports.UI.XRLabel

        Private PictureBox As DevExpress.XtraReports.UI.XRPictureBox

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private lbPageNumber As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrLine2 As DevExpress.XtraReports.UI.XRLine

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private lbOrderForm As DevExpress.XtraReports.UI.XRLabel

        Private lbAddress As DevExpress.XtraReports.UI.XRLabel

        Private lbInstructionsText As DevExpress.XtraReports.UI.XRLabel

        Private lbBillTo As DevExpress.XtraReports.UI.XRLabel

        Private lbShipTo As DevExpress.XtraReports.UI.XRLabel

        Private xrLine3 As DevExpress.XtraReports.UI.XRLine

        Private xrLine4 As DevExpress.XtraReports.UI.XRLine

        Private xrLine5 As DevExpress.XtraReports.UI.XRLine

        Private xrLine6 As DevExpress.XtraReports.UI.XRLine

        Private xrLine7 As DevExpress.XtraReports.UI.XRLine

        Private xrLine8 As DevExpress.XtraReports.UI.XRLine

        Private xrLine9 As DevExpress.XtraReports.UI.XRLine

        Private xrLine10 As DevExpress.XtraReports.UI.XRLine

        Private xrLine11 As DevExpress.XtraReports.UI.XRLine

        Private lbDateOfOrder As DevExpress.XtraReports.UI.XRLabel

        Private lbDateRequired As DevExpress.XtraReports.UI.XRLabel

        Private xrLine12 As DevExpress.XtraReports.UI.XRLine

        Private lbCustomerID As DevExpress.XtraReports.UI.XRLabel

        Private xrLine13 As DevExpress.XtraReports.UI.XRLine

        Private lbShipVia As DevExpress.XtraReports.UI.XRLabel

        Private lnThickLeft As DevExpress.XtraReports.UI.XRLine

        Private lnThinLeft As DevExpress.XtraReports.UI.XRLine

        Private lnThickRight As DevExpress.XtraReports.UI.XRLine

        Private lnThinRight As DevExpress.XtraReports.UI.XRLine

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private cbSpeedyExpress As DevExpress.XtraReports.UI.XRCheckBox

        Private cbUnitedPackage As DevExpress.XtraReports.UI.XRCheckBox

        Private cbFederalShipping As DevExpress.XtraReports.UI.XRCheckBox

        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell33 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell34 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell36 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell44 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell46 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell49 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell52 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell55 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell56 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell57 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell58 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell59 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell60 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell61 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell62 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell63 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell64 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell65 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell67 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell69 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell70 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell66 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell68 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell71 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell72 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell73 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell74 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTable4 As DevExpress.XtraReports.UI.XRTable

        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.NorthwindTraders.CatalogReport))
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrTableOfContents1 = New DevExpress.XtraReports.UI.XRTableOfContents()
            Me.lbTourParagraph4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTourParagraph3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTourParagraph2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTourParagraph1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTourParagraph = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTourTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbFallCatalog = New DevExpress.XtraReports.UI.XRLabel()
            Me.pbLargeLogo = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.lnThickLeft = New DevExpress.XtraReports.UI.XRLine()
            Me.lnThinLeft = New DevExpress.XtraReports.UI.XRLine()
            Me.lbCommitment1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCommitment = New DevExpress.XtraReports.UI.XRLabel()
            Me.lnThickRight = New DevExpress.XtraReports.UI.XRLine()
            Me.lnThinRight = New DevExpress.XtraReports.UI.XRLine()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.lbHighestPrice = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbLowestPrice = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTotalSales = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCount = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbDesciption = New DevExpress.XtraReports.UI.XRLabel()
            Me.PictureBox = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbPageNumber = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.cbFederalShipping = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.lbShipVia = New DevExpress.XtraReports.UI.XRLabel()
            Me.cbSpeedyExpress = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.cbUnitedPackage = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.lbInstructionsText = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine13 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbCustomerID = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine12 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbDateRequired = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbDateOfOrder = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine11 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine10 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine9 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine8 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine7 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine6 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine5 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbShipTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbBillTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbAddress = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbOrderForm = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.parameterSortGroupsType = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterSortGroupsOrder = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ProductSales = New DevExpress.XtraReports.UI.CalculatedField()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail.HeightF = 24F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BookmarkParent = Me.lbCategoryName
            Me.xrTable2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "ProductName")})
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(33F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(572F, 24F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCategoryName
            ' 
            Me.lbCategoryName.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbCategoryName.BorderColor = System.Drawing.Color.White
            Me.lbCategoryName.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.lbCategoryName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "CategoryName"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName")})
            Me.lbCategoryName.Font = New DevExpress.Drawing.DXFont("Tahoma", 21F)
            Me.lbCategoryName.ForeColor = System.Drawing.Color.DimGray
            Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(34F, 33.00006F)
            Me.lbCategoryName.Name = "lbCategoryName"
            Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 0F, 0F, 0F, 100F)
            Me.lbCategoryName.SizeF = New System.Drawing.SizeF(391F, 44.00002F)
            Me.lbCategoryName.Text = "xrLabel1"
            Me.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.xrTableRow3.BorderColor = System.Drawing.Color.White
            Me.xrTableRow3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell9, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(6F, 0F, 0F, 0F, 100F)
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell4.Weight = 0.42832167832167833R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductID")})
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(6F, 0F, 0F, 0F, 100F)
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell9.Weight = 0.16433566433566432R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "QuantityPerUnit")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell5.Weight = 0.23426573426573427R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 6F, 0F, 0F, 100F)
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.TextFormatString = "{0:C}"
            Me.xrTableCell6.Weight = 0.17307692307692307R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.BorderColor = System.Drawing.Color.Black
            Me.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTableOfContents1, Me.lbTourParagraph4, Me.lbTourParagraph3, Me.lbTourParagraph2, Me.lbTourParagraph1, Me.lbTourParagraph, Me.lbTourTitle, Me.lbFallCatalog, Me.pbLargeLogo, Me.lnThickLeft, Me.lnThinLeft, Me.lbCommitment1, Me.lbCommitment, Me.lnThickRight, Me.lnThinRight})
            Me.ReportHeader.HeightF = 1848F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.ReportHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableOfContents1
            ' 
            Me.xrTableOfContents1.LevelDefault.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
            Me.xrTableOfContents1.LevelDefault.Padding = New DevExpress.XtraPrinting.PaddingInfo(50F, 50F, 0F, 0F, 100F)
            Me.xrTableOfContents1.LevelTitle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 14.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableOfContents1.LevelTitle.Height = 325F
            Me.xrTableOfContents1.LevelTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(50F, 0F, 250F, 0F, 100F)
            Me.xrTableOfContents1.LevelTitle.Text = "Table of Contents"
            Me.xrTableOfContents1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1500F)
            Me.xrTableOfContents1.MaxNestingLevel = 1
            Me.xrTableOfContents1.Name = "xrTableOfContents1"
            Me.xrTableOfContents1.StylePriority.UsePadding = False
            ' 
            ' lbTourParagraph4
            ' 
            Me.lbTourParagraph4.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourParagraph4.ForeColor = System.Drawing.Color.Black
            Me.lbTourParagraph4.LocationFloat = New DevExpress.Utils.PointFloat(125F, 1366F)
            Me.lbTourParagraph4.Name = "lbTourParagraph4"
            Me.lbTourParagraph4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourParagraph4.SizeF = New System.Drawing.SizeF(400F, 66F)
            Me.lbTourParagraph4.Text = "Our sales representatives are ready to take your orders now. For your convenience" & ", we've included details on ordering on the last page of this catalog."
            Me.lbTourParagraph4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTourParagraph3
            ' 
            Me.lbTourParagraph3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourParagraph3.ForeColor = System.Drawing.Color.Black
            Me.lbTourParagraph3.LocationFloat = New DevExpress.Utils.PointFloat(125F, 1266F)
            Me.lbTourParagraph3.Name = "lbTourParagraph3"
            Me.lbTourParagraph3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourParagraph3.SizeF = New System.Drawing.SizeF(400F, 91F)
            Me.lbTourParagraph3.Text = resources.GetString("lbTourParagraph3.Text")
            Me.lbTourParagraph3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTourParagraph2
            ' 
            Me.lbTourParagraph2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourParagraph2.ForeColor = System.Drawing.Color.Black
            Me.lbTourParagraph2.LocationFloat = New DevExpress.Utils.PointFloat(125F, 1200F)
            Me.lbTourParagraph2.Name = "lbTourParagraph2"
            Me.lbTourParagraph2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourParagraph2.SizeF = New System.Drawing.SizeF(400F, 58F)
            Me.lbTourParagraph2.Text = "For thirst quenchers, try exotic Chang, hearty Laughing Lumberjack Lager, robust " & "Rhnbru Klosterbier, and refreshing Lakkalikri."
            Me.lbTourParagraph2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTourParagraph1
            ' 
            Me.lbTourParagraph1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourParagraph1.ForeColor = System.Drawing.Color.Black
            Me.lbTourParagraph1.LocationFloat = New DevExpress.Utils.PointFloat(125F, 1141F)
            Me.lbTourParagraph1.Name = "lbTourParagraph1"
            Me.lbTourParagraph1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourParagraph1.SizeF = New System.Drawing.SizeF(400F, 41F)
            Me.lbTourParagraph1.Text = "The beverages and confections we're featuring this fall are sure to please even t" & "he most discerning palates."
            Me.lbTourParagraph1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTourParagraph
            ' 
            Me.lbTourParagraph.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourParagraph.ForeColor = System.Drawing.Color.Black
            Me.lbTourParagraph.LocationFloat = New DevExpress.Utils.PointFloat(125F, 1050F)
            Me.lbTourParagraph.Name = "lbTourParagraph"
            Me.lbTourParagraph.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourParagraph.SizeF = New System.Drawing.SizeF(400F, 75F)
            Me.lbTourParagraph.Text = "When Northwind Traders buyers set out to search for the Wonders of the Gastronomi" & "c World they found a lot more than seven of them. And here they are--tastefully " & "presented in our Fall Catalog."
            Me.lbTourParagraph.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTourTitle
            ' 
            Me.lbTourTitle.Font = New DevExpress.Drawing.DXFont("Times New Roman", 18F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbTourTitle.ForeColor = System.Drawing.Color.Black
            Me.lbTourTitle.LocationFloat = New DevExpress.Utils.PointFloat(150F, 966F)
            Me.lbTourTitle.Multiline = True
            Me.lbTourTitle.Name = "lbTourTitle"
            Me.lbTourTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbTourTitle.SizeF = New System.Drawing.SizeF(350F, 58F)
            Me.lbTourTitle.Text = "Tour the Gastronomic World with Northwind Traders!"
            Me.lbTourTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' lbFallCatalog
            ' 
            Me.lbFallCatalog.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbFallCatalog.ForeColor = System.Drawing.Color.Maroon
            Me.lbFallCatalog.LocationFloat = New DevExpress.Utils.PointFloat(267F, 442F)
            Me.lbFallCatalog.Name = "lbFallCatalog"
            Me.lbFallCatalog.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbFallCatalog.SizeF = New System.Drawing.SizeF(116F, 25F)
            Me.lbFallCatalog.Text = "Fall Catalog"
            Me.lbFallCatalog.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' pbLargeLogo
            ' 
            Me.pbLargeLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pbLargeLogo.ImageSource"))
            Me.pbLargeLogo.LocationFloat = New DevExpress.Utils.PointFloat(180F, 50F)
            Me.pbLargeLogo.Name = "pbLargeLogo"
            Me.pbLargeLogo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.pbLargeLogo.SizeF = New System.Drawing.SizeF(290.625F, 320.8333F)
            Me.pbLargeLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.pbLargeLogo.UseImageResolution = False
            ' 
            ' lnThickLeft
            ' 
            Me.lnThickLeft.LineWidth = 4F
            Me.lnThickLeft.LocationFloat = New DevExpress.Utils.PointFloat(0F, 175F)
            Me.lnThickLeft.Name = "lnThickLeft"
            Me.lnThickLeft.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.lnThickLeft.SizeF = New System.Drawing.SizeF(180F, 8F)
            ' 
            ' lnThinLeft
            ' 
            Me.lnThinLeft.LocationFloat = New DevExpress.Utils.PointFloat(0F, 167F)
            Me.lnThinLeft.Name = "lnThinLeft"
            Me.lnThinLeft.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.lnThinLeft.SizeF = New System.Drawing.SizeF(180F, 8F)
            ' 
            ' lbCommitment1
            ' 
            Me.lbCommitment1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbCommitment1.ForeColor = System.Drawing.Color.Maroon
            Me.lbCommitment1.LocationFloat = New DevExpress.Utils.PointFloat(171F, 695F)
            Me.lbCommitment1.Name = "lbCommitment1"
            Me.lbCommitment1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbCommitment1.SizeF = New System.Drawing.SizeF(308F, 100F)
            Me.lbCommitment1.Text = resources.GetString("lbCommitment1.Text")
            Me.lbCommitment1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCommitment
            ' 
            Me.lbCommitment.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.25F, CType(((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic)), DevExpress.Drawing.DXFontStyle))
            Me.lbCommitment.ForeColor = System.Drawing.Color.Maroon
            Me.lbCommitment.LocationFloat = New DevExpress.Utils.PointFloat(221F, 658F)
            Me.lbCommitment.Name = "lbCommitment"
            Me.lbCommitment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbCommitment.SizeF = New System.Drawing.SizeF(208F, 23F)
            Me.lbCommitment.Text = "Commitment to Quality"
            Me.lbCommitment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lnThickRight
            ' 
            Me.lnThickRight.LineWidth = 4F
            Me.lnThickRight.LocationFloat = New DevExpress.Utils.PointFloat(471F, 175F)
            Me.lnThickRight.Name = "lnThickRight"
            Me.lnThickRight.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.lnThickRight.SizeF = New System.Drawing.SizeF(179F, 8F)
            ' 
            ' lnThinRight
            ' 
            Me.lnThinRight.LocationFloat = New DevExpress.Utils.PointFloat(471F, 167F)
            Me.lnThinRight.Name = "lnThinRight"
            Me.lnThinRight.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.lnThinRight.SizeF = New System.Drawing.SizeF(179F, 8F)
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbHighestPrice, Me.lbLowestPrice, Me.lbTotalSales, Me.lbCount, Me.lbCategoryName, Me.lbDesciption, Me.PictureBox, Me.xrTable1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
            Me.GroupHeader1.HeightF = 178F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbHighestPrice
            ' 
            Me.lbHighestPrice.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbHighestPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumMax(UnitPrice)")})
            Me.lbHighestPrice.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.lbHighestPrice.ForeColor = System.Drawing.Color.DimGray
            Me.lbHighestPrice.LocationFloat = New DevExpress.Utils.PointFloat(226F, 127F)
            Me.lbHighestPrice.Name = "lbHighestPrice"
            Me.lbHighestPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 10F, 0F, 0F, 100F)
            Me.lbHighestPrice.SizeF = New System.Drawing.SizeF(198F, 22.99995F)
            Me.lbHighestPrice.StylePriority.UseBackColor = False
            Me.lbHighestPrice.StylePriority.UseFont = False
            Me.lbHighestPrice.StylePriority.UseForeColor = False
            Me.lbHighestPrice.StylePriority.UsePadding = False
            Me.lbHighestPrice.StylePriority.UseTextAlignment = False
            xrSummary1.IgnoreNullValues = True
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.lbHighestPrice.Summary = xrSummary1
            Me.lbHighestPrice.Text = "lbHighestPrice"
            Me.lbHighestPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbHighestPrice.TextFormatString = "Highest Price: {0:C}"
            ' 
            ' lbLowestPrice
            ' 
            Me.lbLowestPrice.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbLowestPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumMin(UnitPrice)")})
            Me.lbLowestPrice.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.lbLowestPrice.ForeColor = System.Drawing.Color.DimGray
            Me.lbLowestPrice.LocationFloat = New DevExpress.Utils.PointFloat(226F, 104.0001F)
            Me.lbLowestPrice.Name = "lbLowestPrice"
            Me.lbLowestPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 10F, 0F, 0F, 100F)
            Me.lbLowestPrice.SizeF = New System.Drawing.SizeF(198F, 22.99995F)
            Me.lbLowestPrice.StylePriority.UseBackColor = False
            Me.lbLowestPrice.StylePriority.UseFont = False
            Me.lbLowestPrice.StylePriority.UseForeColor = False
            Me.lbLowestPrice.StylePriority.UsePadding = False
            Me.lbLowestPrice.StylePriority.UseTextAlignment = False
            xrSummary2.IgnoreNullValues = True
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.lbLowestPrice.Summary = xrSummary2
            Me.lbLowestPrice.Text = "lbLowestPrice"
            Me.lbLowestPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbLowestPrice.TextFormatString = "Lowest Price: {0:C}"
            ' 
            ' lbTotalSales
            ' 
            Me.lbTotalSales.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbTotalSales.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(ProductSales)")})
            Me.lbTotalSales.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.lbTotalSales.ForeColor = System.Drawing.Color.DimGray
            Me.lbTotalSales.LocationFloat = New DevExpress.Utils.PointFloat(34F, 127F)
            Me.lbTotalSales.Name = "lbTotalSales"
            Me.lbTotalSales.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 10F, 0F, 0F, 100F)
            Me.lbTotalSales.SizeF = New System.Drawing.SizeF(192F, 22.99995F)
            Me.lbTotalSales.StylePriority.UseBackColor = False
            Me.lbTotalSales.StylePriority.UseFont = False
            Me.lbTotalSales.StylePriority.UseForeColor = False
            Me.lbTotalSales.StylePriority.UsePadding = False
            Me.lbTotalSales.StylePriority.UseTextAlignment = False
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.lbTotalSales.Summary = xrSummary3
            Me.lbTotalSales.Text = "lbTotalSales"
            Me.lbTotalSales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbTotalSales.TextFormatString = "Total Sales: {0:C}"
            ' 
            ' lbCount
            ' 
            Me.lbCount.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbCount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([ProductID])")})
            Me.lbCount.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.lbCount.ForeColor = System.Drawing.Color.DimGray
            Me.lbCount.LocationFloat = New DevExpress.Utils.PointFloat(34F, 104.0001F)
            Me.lbCount.Name = "lbCount"
            Me.lbCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 10F, 0F, 0F, 100F)
            Me.lbCount.SizeF = New System.Drawing.SizeF(192F, 22.99995F)
            Me.lbCount.StylePriority.UseBackColor = False
            Me.lbCount.StylePriority.UseFont = False
            Me.lbCount.StylePriority.UseForeColor = False
            Me.lbCount.StylePriority.UsePadding = False
            Me.lbCount.StylePriority.UseTextAlignment = False
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.lbCount.Summary = xrSummary4
            Me.lbCount.Text = "lbCount"
            Me.lbCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.lbCount.TextFormatString = "Items Count: {0}"
            ' 
            ' lbDesciption
            ' 
            Me.lbDesciption.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((238)))))), (CInt(((CByte((238)))))))
            Me.lbDesciption.BorderColor = System.Drawing.Color.White
            Me.lbDesciption.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.lbDesciption.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Description")})
            Me.lbDesciption.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.lbDesciption.ForeColor = System.Drawing.Color.DarkGray
            Me.lbDesciption.LocationFloat = New DevExpress.Utils.PointFloat(33.99998F, 77.00008F)
            Me.lbDesciption.Name = "lbDesciption"
            Me.lbDesciption.Padding = New DevExpress.XtraPrinting.PaddingInfo(10F, 10F, 0F, 0F, 100F)
            Me.lbDesciption.SizeF = New System.Drawing.SizeF(391F, 27F)
            Me.lbDesciption.Text = "xrLabel1"
            Me.lbDesciption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PictureBox
            ' 
            Me.PictureBox.BorderColor = System.Drawing.Color.Gainsboro
            Me.PictureBox.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PictureBox.BorderWidth = 5F
            Me.PictureBox.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Picture")})
            Me.PictureBox.LocationFloat = New DevExpress.Utils.PointFloat(425F, 33F)
            Me.PictureBox.Name = "PictureBox"
            Me.PictureBox.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.PictureBox.SizeF = New System.Drawing.SizeF(180F, 117F)
            Me.PictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.White
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(33F, 152F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(572F, 26F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((167)))))), (CInt(((CByte((73)))))))
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableRow1.ForeColor = System.Drawing.Color.White
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell1.Text = "Product Name:"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.42832167832167833R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell7.Text = "Product ID:"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.16433566433566432R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell2.Text = "Quantity Per Unit:"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.23426573426573427R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell3.Text = "Unit Price: "
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.17307692307692307R
            ' 
            ' xrTable4
            ' 
            Me.xrTable4.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable4.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable4.ForeColor = System.Drawing.Color.Black
            Me.xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(34F, 425F)
            Me.xrTable4.Name = "xrTable4"
            Me.xrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow9, Me.xrTableRow10, Me.xrTableRow11, Me.xrTableRow12, Me.xrTableRow13, Me.xrTableRow14, Me.xrTableRow15, Me.xrTableRow16, Me.xrTableRow17, Me.xrTableRow18, Me.xrTableRow19})
            Me.xrTable4.SizeF = New System.Drawing.SizeF(582F, 258F)
            Me.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell10, Me.xrTableCell13, Me.xrTableCell11, Me.xrTableCell14, Me.xrTableCell12})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.16279069767441862R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell10.Text = "Product ID:"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell13.Text = "Product Name:"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Multiline = True
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell11.Text = "Unit Price:"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell11.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.Multiline = True
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell14.Text = "Quantity:"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell14.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Multiline = True
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell12.Text = "Extended Price:"
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell12.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell15, Me.xrTableCell22, Me.xrTableCell23, Me.xrTableCell24, Me.xrTableCell25})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell15.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell22.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell23.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell24.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell25.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow9
            ' 
            Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell26, Me.xrTableCell27, Me.xrTableCell28, Me.xrTableCell29, Me.xrTableCell30})
            Me.xrTableRow9.Name = "xrTableRow9"
            Me.xrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow9.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell26.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell27.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell28.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell29.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell30.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow10
            ' 
            Me.xrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell31, Me.xrTableCell32, Me.xrTableCell33, Me.xrTableCell34, Me.xrTableCell35})
            Me.xrTableRow10.Name = "xrTableRow10"
            Me.xrTableRow10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow10.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell31.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell32.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell33.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell34.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell35.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow11
            ' 
            Me.xrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell36, Me.xrTableCell37, Me.xrTableCell38, Me.xrTableCell39, Me.xrTableCell40})
            Me.xrTableRow11.Name = "xrTableRow11"
            Me.xrTableRow11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow11.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell36
            ' 
            Me.xrTableCell36.Name = "xrTableCell36"
            Me.xrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell36.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell37
            ' 
            Me.xrTableCell37.Name = "xrTableCell37"
            Me.xrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell37.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell38
            ' 
            Me.xrTableCell38.Name = "xrTableCell38"
            Me.xrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell38.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell39
            ' 
            Me.xrTableCell39.Name = "xrTableCell39"
            Me.xrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell39.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell40
            ' 
            Me.xrTableCell40.Name = "xrTableCell40"
            Me.xrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell40.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow12
            ' 
            Me.xrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell41, Me.xrTableCell42, Me.xrTableCell43, Me.xrTableCell44, Me.xrTableCell45})
            Me.xrTableRow12.Name = "xrTableRow12"
            Me.xrTableRow12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow12.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell41
            ' 
            Me.xrTableCell41.Name = "xrTableCell41"
            Me.xrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell41.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell42
            ' 
            Me.xrTableCell42.Name = "xrTableCell42"
            Me.xrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell42.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell43
            ' 
            Me.xrTableCell43.Name = "xrTableCell43"
            Me.xrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell43.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell44
            ' 
            Me.xrTableCell44.Name = "xrTableCell44"
            Me.xrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell44.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell45
            ' 
            Me.xrTableCell45.Name = "xrTableCell45"
            Me.xrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell45.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow13
            ' 
            Me.xrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell46, Me.xrTableCell47, Me.xrTableCell48, Me.xrTableCell49, Me.xrTableCell50})
            Me.xrTableRow13.Name = "xrTableRow13"
            Me.xrTableRow13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow13.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell46
            ' 
            Me.xrTableCell46.Name = "xrTableCell46"
            Me.xrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell46.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell47
            ' 
            Me.xrTableCell47.Name = "xrTableCell47"
            Me.xrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell47.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell48
            ' 
            Me.xrTableCell48.Name = "xrTableCell48"
            Me.xrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell48.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell49
            ' 
            Me.xrTableCell49.Name = "xrTableCell49"
            Me.xrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell49.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell50
            ' 
            Me.xrTableCell50.Name = "xrTableCell50"
            Me.xrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell50.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow14
            ' 
            Me.xrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell51, Me.xrTableCell52, Me.xrTableCell53, Me.xrTableCell54, Me.xrTableCell55})
            Me.xrTableRow14.Name = "xrTableRow14"
            Me.xrTableRow14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow14.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell51
            ' 
            Me.xrTableCell51.Name = "xrTableCell51"
            Me.xrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell51.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell52
            ' 
            Me.xrTableCell52.Name = "xrTableCell52"
            Me.xrTableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell52.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell53
            ' 
            Me.xrTableCell53.Name = "xrTableCell53"
            Me.xrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell53.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell54
            ' 
            Me.xrTableCell54.Name = "xrTableCell54"
            Me.xrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell54.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell55
            ' 
            Me.xrTableCell55.Name = "xrTableCell55"
            Me.xrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell55.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow15
            ' 
            Me.xrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell56, Me.xrTableCell57, Me.xrTableCell58, Me.xrTableCell59, Me.xrTableCell60})
            Me.xrTableRow15.Name = "xrTableRow15"
            Me.xrTableRow15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow15.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell56
            ' 
            Me.xrTableCell56.Name = "xrTableCell56"
            Me.xrTableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell56.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell57
            ' 
            Me.xrTableCell57.Name = "xrTableCell57"
            Me.xrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell57.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell58
            ' 
            Me.xrTableCell58.Name = "xrTableCell58"
            Me.xrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell58.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell59
            ' 
            Me.xrTableCell59.Name = "xrTableCell59"
            Me.xrTableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell59.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell60
            ' 
            Me.xrTableCell60.Name = "xrTableCell60"
            Me.xrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell60.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow16
            ' 
            Me.xrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell61, Me.xrTableCell62, Me.xrTableCell63, Me.xrTableCell64, Me.xrTableCell65})
            Me.xrTableRow16.Name = "xrTableRow16"
            Me.xrTableRow16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow16.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell61
            ' 
            Me.xrTableCell61.Name = "xrTableCell61"
            Me.xrTableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell61.Weight = 0.1872852233676976R
            ' 
            ' xrTableCell62
            ' 
            Me.xrTableCell62.Name = "xrTableCell62"
            Me.xrTableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell62.Weight = 0.3127147766323024R
            ' 
            ' xrTableCell63
            ' 
            Me.xrTableCell63.Name = "xrTableCell63"
            Me.xrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell63.Weight = 0.16666666666666666R
            ' 
            ' xrTableCell64
            ' 
            Me.xrTableCell64.Name = "xrTableCell64"
            Me.xrTableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell64.Weight = 0.16838487972508592R
            ' 
            ' xrTableCell65
            ' 
            Me.xrTableCell65.Name = "xrTableCell65"
            Me.xrTableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell65.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow17
            ' 
            Me.xrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell67, Me.xrTableCell69, Me.xrTableCell70})
            Me.xrTableRow17.Name = "xrTableRow17"
            Me.xrTableRow17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow17.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell67
            ' 
            Me.xrTableCell67.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.xrTableCell67.Name = "xrTableCell67"
            Me.xrTableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell67.Weight = 0.5R
            ' 
            ' xrTableCell69
            ' 
            Me.xrTableCell69.Name = "xrTableCell69"
            Me.xrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell69.Text = "Subtotal:"
            Me.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell69.Weight = 0.33505154639175255R
            ' 
            ' xrTableCell70
            ' 
            Me.xrTableCell70.Name = "xrTableCell70"
            Me.xrTableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell70.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow18
            ' 
            Me.xrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell66, Me.xrTableCell68, Me.xrTableCell71})
            Me.xrTableRow18.Name = "xrTableRow18"
            Me.xrTableRow18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow18.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell66
            ' 
            Me.xrTableCell66.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.xrTableCell66.Name = "xrTableCell66"
            Me.xrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell66.Weight = 0.5R
            ' 
            ' xrTableCell68
            ' 
            Me.xrTableCell68.Name = "xrTableCell68"
            Me.xrTableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell68.Text = "Freight (estimated):"
            Me.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell68.Weight = 0.33505154639175255R
            ' 
            ' xrTableCell71
            ' 
            Me.xrTableCell71.Name = "xrTableCell71"
            Me.xrTableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell71.Weight = 0.16494845360824742R
            ' 
            ' xrTableRow19
            ' 
            Me.xrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell72, Me.xrTableCell73, Me.xrTableCell74})
            Me.xrTableRow19.Name = "xrTableRow19"
            Me.xrTableRow19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 96F)
            Me.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow19.Weight = 0.069767441860465115R
            ' 
            ' xrTableCell72
            ' 
            Me.xrTableCell72.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.xrTableCell72.Name = "xrTableCell72"
            Me.xrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell72.Weight = 0.5R
            ' 
            ' xrTableCell73
            ' 
            Me.xrTableCell73.Name = "xrTableCell73"
            Me.xrTableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell73.Text = "Total:"
            Me.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell73.Weight = 0.33505154639175255R
            ' 
            ' xrTableCell74
            ' 
            Me.xrTableCell74.Name = "xrTableCell74"
            Me.xrTableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell74.Weight = 0.16494845360824742R
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrLabel1, Me.lbPageNumber})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.BorderColor = System.Drawing.Color.Black
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrPageInfo1.ForeColor = System.Drawing.Color.Black
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(367F, 25F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(82F, 25F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((212)))))), (CInt(((CByte((212)))))), (CInt(((CByte((212)))))))
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.Black
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 20F)
            Me.xrLabel1.Text = "Northwind Traders  - Fall Catalog"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' lbPageNumber
            ' 
            Me.lbPageNumber.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.lbPageNumber.ForeColor = System.Drawing.Color.Black
            Me.lbPageNumber.LocationFloat = New DevExpress.Utils.PointFloat(258F, 25F)
            Me.lbPageNumber.Name = "lbPageNumber"
            Me.lbPageNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbPageNumber.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.lbPageNumber.Text = "Page Number"
            Me.lbPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1, Me.xrTable4, Me.lbInstructionsText, Me.xrLine13, Me.lbCustomerID, Me.xrLine12, Me.lbDateRequired, Me.lbDateOfOrder, Me.xrLine11, Me.xrLine10, Me.xrLine9, Me.xrLine8, Me.xrLine7, Me.xrLine6, Me.xrLine5, Me.xrLine4, Me.xrLine3, Me.lbShipTo, Me.lbBillTo, Me.lbAddress, Me.lbOrderForm, Me.xrPictureBox2, Me.xrPictureBox1, Me.xrLine2})
            Me.ReportFooter.HeightF = 836F
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
            Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cbFederalShipping, Me.lbShipVia, Me.cbSpeedyExpress, Me.cbUnitedPackage})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(33F, 700F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(192F, 125F)
            ' 
            ' cbFederalShipping
            ' 
            Me.cbFederalShipping.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbFederalShipping.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.cbFederalShipping.ForeColor = System.Drawing.Color.Black
            Me.cbFederalShipping.LocationFloat = New DevExpress.Utils.PointFloat(8F, 92F)
            Me.cbFederalShipping.Name = "cbFederalShipping"
            Me.cbFederalShipping.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.cbFederalShipping.SizeF = New System.Drawing.SizeF(146F, 20F)
            Me.cbFederalShipping.Text = "Federal Shipping"
            ' 
            ' lbShipVia
            ' 
            Me.lbShipVia.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbShipVia.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbShipVia.ForeColor = System.Drawing.Color.Black
            Me.lbShipVia.LocationFloat = New DevExpress.Utils.PointFloat(9F, 9F)
            Me.lbShipVia.Name = "lbShipVia"
            Me.lbShipVia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbShipVia.SizeF = New System.Drawing.SizeF(150F, 21F)
            Me.lbShipVia.Text = "Ship Via (check one):"
            Me.lbShipVia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' cbSpeedyExpress
            ' 
            Me.cbSpeedyExpress.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbSpeedyExpress.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.cbSpeedyExpress.ForeColor = System.Drawing.Color.Black
            Me.cbSpeedyExpress.LocationFloat = New DevExpress.Utils.PointFloat(8F, 42F)
            Me.cbSpeedyExpress.Name = "cbSpeedyExpress"
            Me.cbSpeedyExpress.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.cbSpeedyExpress.SizeF = New System.Drawing.SizeF(146F, 20F)
            Me.cbSpeedyExpress.Text = "Speedy Express"
            ' 
            ' cbUnitedPackage
            ' 
            Me.cbUnitedPackage.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbUnitedPackage.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.cbUnitedPackage.ForeColor = System.Drawing.Color.Black
            Me.cbUnitedPackage.LocationFloat = New DevExpress.Utils.PointFloat(8F, 67F)
            Me.cbUnitedPackage.Name = "cbUnitedPackage"
            Me.cbUnitedPackage.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.cbUnitedPackage.SizeF = New System.Drawing.SizeF(146F, 20F)
            Me.cbUnitedPackage.Text = "United Package"
            ' 
            ' lbInstructionsText
            ' 
            Me.lbInstructionsText.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.lbInstructionsText.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Italic)
            Me.lbInstructionsText.ForeColor = System.Drawing.Color.Black
            Me.lbInstructionsText.LocationFloat = New DevExpress.Utils.PointFloat(42F, 166F)
            Me.lbInstructionsText.Multiline = True
            Me.lbInstructionsText.Name = "lbInstructionsText"
            Me.lbInstructionsText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbInstructionsText.SizeF = New System.Drawing.SizeF(566F, 75F)
            Me.lbInstructionsText.Text = resources.GetString("lbInstructionsText.Text")
            Me.lbInstructionsText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine13
            ' 
            Me.xrLine13.ForeColor = System.Drawing.Color.Black
            Me.xrLine13.LocationFloat = New DevExpress.Utils.PointFloat(441F, 400F)
            Me.xrLine13.Name = "xrLine13"
            Me.xrLine13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine13.SizeF = New System.Drawing.SizeF(173F, 8F)
            ' 
            ' lbCustomerID
            ' 
            Me.lbCustomerID.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbCustomerID.ForeColor = System.Drawing.Color.Black
            Me.lbCustomerID.LocationFloat = New DevExpress.Utils.PointFloat(333F, 391F)
            Me.lbCustomerID.Name = "lbCustomerID"
            Me.lbCustomerID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbCustomerID.SizeF = New System.Drawing.SizeF(108F, 22F)
            Me.lbCustomerID.Text = "Customer ID:"
            Me.lbCustomerID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine12
            ' 
            Me.xrLine12.ForeColor = System.Drawing.Color.Black
            Me.xrLine12.LocationFloat = New DevExpress.Utils.PointFloat(150F, 400F)
            Me.xrLine12.Name = "xrLine12"
            Me.xrLine12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine12.SizeF = New System.Drawing.SizeF(167F, 8F)
            ' 
            ' lbDateRequired
            ' 
            Me.lbDateRequired.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbDateRequired.ForeColor = System.Drawing.Color.Black
            Me.lbDateRequired.LocationFloat = New DevExpress.Utils.PointFloat(33F, 391F)
            Me.lbDateRequired.Name = "lbDateRequired"
            Me.lbDateRequired.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbDateRequired.SizeF = New System.Drawing.SizeF(116F, 22F)
            Me.lbDateRequired.Text = "Date Required:"
            Me.lbDateRequired.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbDateOfOrder
            ' 
            Me.lbDateOfOrder.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbDateOfOrder.ForeColor = System.Drawing.Color.Black
            Me.lbDateOfOrder.LocationFloat = New DevExpress.Utils.PointFloat(33F, 366F)
            Me.lbDateOfOrder.Name = "lbDateOfOrder"
            Me.lbDateOfOrder.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbDateOfOrder.SizeF = New System.Drawing.SizeF(115F, 22F)
            Me.lbDateOfOrder.Text = "Date of Order:"
            Me.lbDateOfOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine11
            ' 
            Me.xrLine11.ForeColor = System.Drawing.Color.Black
            Me.xrLine11.LocationFloat = New DevExpress.Utils.PointFloat(150F, 375F)
            Me.xrLine11.Name = "xrLine11"
            Me.xrLine11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine11.SizeF = New System.Drawing.SizeF(159F, 8F)
            ' 
            ' xrLine10
            ' 
            Me.xrLine10.ForeColor = System.Drawing.Color.Black
            Me.xrLine10.LocationFloat = New DevExpress.Utils.PointFloat(341F, 325F)
            Me.xrLine10.Name = "xrLine10"
            Me.xrLine10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine10.SizeF = New System.Drawing.SizeF(275F, 8F)
            ' 
            ' xrLine9
            ' 
            Me.xrLine9.ForeColor = System.Drawing.Color.Black
            Me.xrLine9.LocationFloat = New DevExpress.Utils.PointFloat(33F, 325F)
            Me.xrLine9.Name = "xrLine9"
            Me.xrLine9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine9.SizeF = New System.Drawing.SizeF(266F, 8F)
            ' 
            ' xrLine8
            ' 
            Me.xrLine8.ForeColor = System.Drawing.Color.Black
            Me.xrLine8.LocationFloat = New DevExpress.Utils.PointFloat(341F, 341F)
            Me.xrLine8.Name = "xrLine8"
            Me.xrLine8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine8.SizeF = New System.Drawing.SizeF(275F, 8F)
            ' 
            ' xrLine7
            ' 
            Me.xrLine7.ForeColor = System.Drawing.Color.Black
            Me.xrLine7.LocationFloat = New DevExpress.Utils.PointFloat(33F, 341F)
            Me.xrLine7.Name = "xrLine7"
            Me.xrLine7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine7.SizeF = New System.Drawing.SizeF(266F, 8F)
            ' 
            ' xrLine6
            ' 
            Me.xrLine6.ForeColor = System.Drawing.Color.Black
            Me.xrLine6.LocationFloat = New DevExpress.Utils.PointFloat(341F, 308F)
            Me.xrLine6.Name = "xrLine6"
            Me.xrLine6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine6.SizeF = New System.Drawing.SizeF(275F, 8F)
            ' 
            ' xrLine5
            ' 
            Me.xrLine5.ForeColor = System.Drawing.Color.Black
            Me.xrLine5.LocationFloat = New DevExpress.Utils.PointFloat(33F, 308F)
            Me.xrLine5.Name = "xrLine5"
            Me.xrLine5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine5.SizeF = New System.Drawing.SizeF(266F, 8F)
            ' 
            ' xrLine4
            ' 
            Me.xrLine4.ForeColor = System.Drawing.Color.Black
            Me.xrLine4.LocationFloat = New DevExpress.Utils.PointFloat(408F, 291F)
            Me.xrLine4.Name = "xrLine4"
            Me.xrLine4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine4.SizeF = New System.Drawing.SizeF(207F, 8F)
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.ForeColor = System.Drawing.Color.Black
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(99F, 291F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine3.SizeF = New System.Drawing.SizeF(200F, 8F)
            ' 
            ' lbShipTo
            ' 
            Me.lbShipTo.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbShipTo.ForeColor = System.Drawing.Color.Black
            Me.lbShipTo.LocationFloat = New DevExpress.Utils.PointFloat(339F, 278F)
            Me.lbShipTo.Name = "lbShipTo"
            Me.lbShipTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbShipTo.SizeF = New System.Drawing.SizeF(67F, 20F)
            Me.lbShipTo.Text = "Ship To:"
            Me.lbShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbBillTo
            ' 
            Me.lbBillTo.Font = New DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbBillTo.ForeColor = System.Drawing.Color.Black
            Me.lbBillTo.LocationFloat = New DevExpress.Utils.PointFloat(33F, 278F)
            Me.lbBillTo.Name = "lbBillTo"
            Me.lbBillTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbBillTo.SizeF = New System.Drawing.SizeF(66F, 20F)
            Me.lbBillTo.Text = "Bill To:"
            Me.lbBillTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbAddress
            ' 
            Me.lbAddress.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.25F, DevExpress.Drawing.DXFontStyle.Italic)
            Me.lbAddress.ForeColor = System.Drawing.Color.Black
            Me.lbAddress.LocationFloat = New DevExpress.Utils.PointFloat(33F, 116F)
            Me.lbAddress.Multiline = True
            Me.lbAddress.Name = "lbAddress"
            Me.lbAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbAddress.SizeF = New System.Drawing.SizeF(258F, 33F)
            Me.lbAddress.Text = "One Portals Way, Twin Points WA  98156" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Phone: 1-206-555-1417   Fax: 1-206-555-59" & "38"
            Me.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbOrderForm
            ' 
            Me.lbOrderForm.Font = New DevExpress.Drawing.DXFont("Times New Roman", 20.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbOrderForm.ForeColor = System.Drawing.Color.Black
            Me.lbOrderForm.LocationFloat = New DevExpress.Utils.PointFloat(425F, 0F)
            Me.lbOrderForm.Name = "lbOrderForm"
            Me.lbOrderForm.Padding = New DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F)
            Me.lbOrderForm.SizeF = New System.Drawing.SizeF(220F, 33F)
            Me.lbOrderForm.Text = "ORDER FORM"
            Me.lbOrderForm.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(118F, 21F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(162F, 38F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(30F, 1F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(87.5F, 87.5F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.UseImageResolution = False
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.LineWidth = 3F
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 91F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F)
            Me.xrLine2.SizeF = New System.Drawing.SizeF(650F, 16F)
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' parameterSortGroupsType
            ' 
            Me.parameterSortGroupsType.Description = "Sort Categories By"
            Me.parameterSortGroupsType.Name = "parameterSortGroupsType"
            ' 
            ' parameterSortGroupsOrder
            ' 
            Me.parameterSortGroupsOrder.Description = "Sort Order"
            Me.parameterSortGroupsOrder.Name = "parameterSortGroupsOrder"
            ' 
            ' ProductSales
            ' 
            Me.ProductSales.DataMember = "Products"
            Me.ProductSales.Expression = "[ProductsOrderDetails].Sum([UnitPrice] * (1 - [Discount]) * [Quantity])"
            Me.ProductSales.Name = "ProductSales"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "QuantityPerUnit"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "CategoryID"
            table2.Name = "Categories"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Description"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Picture"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            columnExpression9.ColumnName = "OrderID"
            table3.Name = "OrderDetails"
            columnExpression9.Table = table3
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "ProductID"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "UnitPrice"
            columnExpression11.Table = table3
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "Quantity"
            columnExpression12.Table = table3
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Discount"
            columnExpression13.Table = table3
            column13.Expression = columnExpression13
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Name = "OrderDetails"
            selectQuery2.Tables.Add(table3)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "OrderDetails"
            relationColumnInfo2.NestedKeyColumn = "ProductID"
            relationColumnInfo2.ParentKeyColumn = "ProductID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2)
            masterDetailInfo1.MasterQueryName = "Products"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' CatalogReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.ReportFooter, Me.BottomMargin, Me.topMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.ProductSales})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 100F, 75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameterSortGroupsType, Me.parameterSortGroupsOrder})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 6
            Me.RequestParameters = False
            Me.Version = "26.1"
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private lbTotalSales As DevExpress.XtraReports.UI.XRLabel

        Private lbCount As DevExpress.XtraReports.UI.XRLabel

        Private lbHighestPrice As DevExpress.XtraReports.UI.XRLabel

        Private lbLowestPrice As DevExpress.XtraReports.UI.XRLabel

        Private parameterSortGroupsType As DevExpress.XtraReports.Parameters.Parameter

        Private parameterSortGroupsOrder As DevExpress.XtraReports.Parameters.Parameter

        Private xrTableOfContents1 As DevExpress.XtraReports.UI.XRTableOfContents

        Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel

        Private ProductSales As DevExpress.XtraReports.UI.CalculatedField

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
