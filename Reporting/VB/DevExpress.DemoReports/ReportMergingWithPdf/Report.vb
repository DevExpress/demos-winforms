Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.ReportMergingWithPdf

    Public Class Report
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private detailBand1 As DetailBand

        Private bottomMarginBand1 As BottomMarginBand

        Private pageInfo1 As XRPageInfo

        Private OrdersDetailReport As DetailReportBand

        Private OrdersDetail As DetailBand

        Private ReportHeader1 As ReportHeaderBand

        Private panel1 As XRPanel

        Private xrTable3 As XRTable

        Private xrTableRow4 As XRTableRow

        Private xrTableCell2 As XRTableCell

        Private xrTableCell6 As XRTableCell

        Private tableRow1 As XRTableRow

        Private tableCell1 As XRTableCell

        Private tableCell2 As XRTableCell

        Private xrTableRow5 As XRTableRow

        Private xrTableCell7 As XRTableCell

        Private xrTableCell8 As XRTableCell

        Private xrTableRow6 As XRTableRow

        Private xrTableCell9 As XRTableCell

        Private xrTableCell10 As XRTableCell

        Private xrTable1 As XRTable

        Private xrTableRow1 As XRTableRow

        Private xrTableCell1 As XRTableCell

        Private xrTableRow3 As XRTableRow

        Private xrTableCell3 As XRTableCell

        Private xrPictureBoxLogo As XRPictureBox

        Private xrTable4 As XRTable

        Private xrTableRow7 As XRTableRow

        Private xrTableCell11 As XRTableCell

        Private xrTableCell12 As XRTableCell

        Private xrTableCell14 As XRTableCell

        Private xrTableCell15 As XRTableCell

        Private xrTableCell16 As XRTableCell

        Private xrTableCell17 As XRTableCell

        Private xrTableRow8 As XRTableRow

        Private xrTableCell13 As XRTableCell

        Private xrTableCell18 As XRTableCell

        Private xrTableCell19 As XRTableCell

        Private xrTableCell20 As XRTableCell

        Private xrTableCell21 As XRTableCell

        Private xrTableCell22 As XRTableCell

        Private GroupFooter2 As GroupFooterBand

        Private xrTable6 As XRTable

        Private xrTableRow10 As XRTableRow

        Private xrTableCell28 As XRTableCell

        Private xrTableCell29 As XRTableCell

        Private xrTableRow11 As XRTableRow

        Private xrTableCell30 As XRTableCell

        Private xrTableCell31 As XRTableCell

        Private xrTableRow12 As XRTableRow

        Private xrTableCell32 As XRTableCell

        Private xrTableCell33 As XRTableCell

        Private GroupHeader2 As GroupHeaderBand

        Private xrTable5 As XRTable

        Private xrTableRow9 As XRTableRow

        Private xrTableCell23 As XRTableCell

        Private xrTableCell24 As XRTableCell

        Private xrTableCell26 As XRTableCell

        Private xrTableCell27 As XRTableCell

        Private xrTableCell25 As XRTableCell

        Private DetailReport As DetailReportBand

        Private Detail As DetailBand

        Private xrTable2 As XRTable

        Private xrTableRow13 As XRTableRow

        Private xrTableCell34 As XRTableCell

        Private xrTableCell35 As XRTableCell

        Private xrTableCell36 As XRTableCell

        Private xrTableCell37 As XRTableCell

        Private xrTableCell38 As XRTableCell

        Private reportSqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource

        Private DetailReport1 As DetailReportBand

        Private Detail1 As DetailBand

        Private DetailReport2 As DetailReportBand

        Private Detail2 As DetailBand

        Private xrPdfContent1 As XRPdfContent

        Private HeaderStyle As XRControlStyle

        Private General As XRControlStyle

        Private Comments As XRControlStyle

        Private BillingShippingHeaderStyle As XRControlStyle

        Private TableHeaderStyle As XRControlStyle

        Private DetailTableHeaderStyle As XRControlStyle

        Private TableOddStyle As XRControlStyle

        Private HomeOffice_StateName As CalculatedField

        Private Address_StateName As CalculatedField

        Private paramShowHeader As DevExpress.XtraReports.Parameters.Parameter

        Private paramShowFooter As DevExpress.XtraReports.Parameters.Parameter

        Private paramShowStatus As DevExpress.XtraReports.Parameters.Parameter

        Private paramShowComments As DevExpress.XtraReports.Parameters.Parameter

        Private parameterInvoice As DevExpress.XtraReports.Parameters.Parameter

        Private parameterSqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource

        Private xrPdfSignature1 As XRPdfSignature

        Private components As System.ComponentModel.IContainer

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.ReportMergingWithPdfName
            DisplayName = ReportNames.ReportMergingWithPdf
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim xrSummary1 As XRSummary = New XRSummary()
            Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim selectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column34 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression37 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column37 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression38 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column38 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression39 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column39 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression40 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column40 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression41 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column41 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression42 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column42 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression43 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column43 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression44 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column44 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression45 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column45 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression46 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column46 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression47 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column47 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression48 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column48 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression49 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column49 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression50 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column50 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression51 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column51 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression52 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column52 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression53 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column53 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression54 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column54 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression55 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column55 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression56 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column56 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression57 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column57 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression58 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery4 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column58 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression59 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column59 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression60 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column60 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression61 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column61 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression62 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column62 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression63 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column63 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression64 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column64 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression65 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column65 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression66 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim sorting2 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
            Dim columnExpression67 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery5 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column66 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression68 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column67 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression69 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column68 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression70 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column69 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression71 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column70 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression72 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column71 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression73 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column72 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression74 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column73 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression75 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column74 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression76 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column75 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression77 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column76 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression78 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column77 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression79 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column78 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression80 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column79 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression81 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column80 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression82 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column81 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression83 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column82 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression84 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column83 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression85 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column84 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression86 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column85 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression87 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column86 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression88 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery6 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column87 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression89 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column88 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression90 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column89 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression91 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column90 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression92 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column91 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression93 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column92 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression94 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column93 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression95 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column94 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression96 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column95 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression97 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column96 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression98 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column97 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression99 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column98 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression100 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column99 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression101 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column100 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression102 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column101 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression103 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column102 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression104 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column103 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression105 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column104 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression106 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column105 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression107 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column106 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression108 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column107 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression109 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column108 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression110 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column109 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression111 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column110 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression112 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column111 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression113 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column112 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression114 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column113 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression115 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column114 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression116 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column115 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression117 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery7 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column116 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression118 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column117 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression119 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column118 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression120 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column119 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression121 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column120 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression122 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column121 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression123 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column122 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression124 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column123 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression125 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column124 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression126 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column125 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression127 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column126 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression128 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column127 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression129 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column128 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression130 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column129 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression131 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column130 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression132 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column131 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression133 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column132 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression134 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column133 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression135 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column134 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression136 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column135 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression137 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table9 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo2 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo3 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo4 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo6 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo5 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo7 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim masterDetailInfo6 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo8 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            parameterSqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(components)
            topMarginBand1 = New TopMarginBand()
            detailBand1 = New DetailBand()
            bottomMarginBand1 = New BottomMarginBand()
            pageInfo1 = New XRPageInfo()
            OrdersDetailReport = New DetailReportBand()
            OrdersDetail = New DetailBand()
            ReportHeader1 = New ReportHeaderBand()
            panel1 = New XRPanel()
            xrTable3 = New XRTable()
            xrTableRow4 = New XRTableRow()
            xrTableCell2 = New XRTableCell()
            xrTableCell6 = New XRTableCell()
            tableRow1 = New XRTableRow()
            tableCell1 = New XRTableCell()
            tableCell2 = New XRTableCell()
            xrTableRow5 = New XRTableRow()
            xrTableCell7 = New XRTableCell()
            xrTableCell8 = New XRTableCell()
            xrTableRow6 = New XRTableRow()
            xrTableCell9 = New XRTableCell()
            xrTableCell10 = New XRTableCell()
            xrTable1 = New XRTable()
            xrTableRow1 = New XRTableRow()
            xrTableCell1 = New XRTableCell()
            xrTableRow3 = New XRTableRow()
            xrTableCell3 = New XRTableCell()
            xrPictureBoxLogo = New XRPictureBox()
            xrTable4 = New XRTable()
            xrTableRow7 = New XRTableRow()
            xrTableCell11 = New XRTableCell()
            xrTableCell12 = New XRTableCell()
            xrTableCell14 = New XRTableCell()
            xrTableCell15 = New XRTableCell()
            xrTableCell16 = New XRTableCell()
            xrTableCell17 = New XRTableCell()
            xrTableRow8 = New XRTableRow()
            xrTableCell13 = New XRTableCell()
            xrTableCell18 = New XRTableCell()
            xrTableCell19 = New XRTableCell()
            xrTableCell20 = New XRTableCell()
            xrTableCell21 = New XRTableCell()
            xrTableCell22 = New XRTableCell()
            GroupFooter2 = New GroupFooterBand()
            xrTable6 = New XRTable()
            xrTableRow10 = New XRTableRow()
            xrTableCell28 = New XRTableCell()
            xrTableCell29 = New XRTableCell()
            xrTableRow11 = New XRTableRow()
            xrTableCell30 = New XRTableCell()
            xrTableCell31 = New XRTableCell()
            xrTableRow12 = New XRTableRow()
            xrTableCell32 = New XRTableCell()
            xrTableCell33 = New XRTableCell()
            GroupHeader2 = New GroupHeaderBand()
            xrTable5 = New XRTable()
            xrTableRow9 = New XRTableRow()
            xrTableCell23 = New XRTableCell()
            xrTableCell24 = New XRTableCell()
            xrTableCell26 = New XRTableCell()
            xrTableCell27 = New XRTableCell()
            xrTableCell25 = New XRTableCell()
            DetailReport = New DetailReportBand()
            Detail = New DetailBand()
            xrTable2 = New XRTable()
            xrTableRow13 = New XRTableRow()
            xrTableCell34 = New XRTableCell()
            xrTableCell35 = New XRTableCell()
            xrTableCell36 = New XRTableCell()
            xrTableCell37 = New XRTableCell()
            xrTableCell38 = New XRTableCell()
            reportSqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(components)
            DetailReport1 = New DetailReportBand()
            Detail1 = New DetailBand()
            DetailReport2 = New DetailReportBand()
            Detail2 = New DetailBand()
            xrPdfContent1 = New XRPdfContent()
            HeaderStyle = New XRControlStyle()
            General = New XRControlStyle()
            Comments = New XRControlStyle()
            BillingShippingHeaderStyle = New XRControlStyle()
            TableHeaderStyle = New XRControlStyle()
            DetailTableHeaderStyle = New XRControlStyle()
            TableOddStyle = New XRControlStyle()
            HomeOffice_StateName = New CalculatedField()
            Address_StateName = New CalculatedField()
            paramShowHeader = New DevExpress.XtraReports.Parameters.Parameter()
            paramShowFooter = New DevExpress.XtraReports.Parameters.Parameter()
            paramShowStatus = New DevExpress.XtraReports.Parameters.Parameter()
            paramShowComments = New DevExpress.XtraReports.Parameters.Parameter()
            parameterInvoice = New DevExpress.XtraReports.Parameters.Parameter()
            xrPdfSignature1 = New XRPdfSignature()
            CType(xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' parameterSqlDataSource
            ' 
            parameterSqlDataSource.ConnectionName = "DevAvConnectionString"
            parameterSqlDataSource.Name = "parameterSqlDataSource"
            columnExpression1.ColumnName = "InvoiceNumber"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""419"" />"
            table1.Name = "Orders"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "OrderDate"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Id"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Name = "Orders"
            columnExpression4.ColumnName = "OrderDate"
            columnExpression4.Table = table1
            sorting1.Expression = columnExpression4
            selectQuery1.Sorting.Add(sorting1)
            selectQuery1.Tables.Add(table1)
            parameterSqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            parameterSqlDataSource.ResultSchemaSerializable = resources.GetString("parameterSqlDataSource.ResultSchemaSerializable")
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Dpi = 96F
            topMarginBand1.HeightF = 46.08F
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            detailBand1.Dpi = 96F
            detailBand1.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            detailBand1.HeightF = 0F
            detailBand1.HierarchyPrintOptions.Indent = 19.2F
            detailBand1.Name = "detailBand1"
            detailBand1.StylePriority.UseFont = False
            detailBand1.StylePriority.UseForeColor = False
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Controls.AddRange(New XRControl() {pageInfo1})
            bottomMarginBand1.Dpi = 96F
            bottomMarginBand1.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            bottomMarginBand1.HeightF = 60.33794F
            bottomMarginBand1.Name = "bottomMarginBand1"
            bottomMarginBand1.StylePriority.UseFont = False
            ' 
            ' pageInfo1
            ' 
            pageInfo1.Dpi = 96F
            pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(302.5406F, 8.257084F)
            pageInfo1.Name = "pageInfo1"
            pageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            pageInfo1.SizeF = New System.Drawing.SizeF(96F, 22.08F)
            pageInfo1.StyleName = "General"
            pageInfo1.StylePriority.UseTextAlignment = False
            pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            pageInfo1.TextFormatString = "Page {0} of {1}"
            ' 
            ' OrdersDetailReport
            ' 
            OrdersDetailReport.Bands.AddRange(New Band() {OrdersDetail, ReportHeader1, GroupFooter2, GroupHeader2, DetailReport})
            OrdersDetailReport.DataMember = "Orders"
            OrdersDetailReport.DataSource = reportSqlDataSource
            OrdersDetailReport.Dpi = 96F
            OrdersDetailReport.Level = 0
            OrdersDetailReport.Name = "OrdersDetailReport"
            ' 
            ' OrdersDetail
            ' 
            OrdersDetail.Dpi = 96F
            OrdersDetail.HeightF = 0F
            OrdersDetail.HierarchyPrintOptions.Indent = 19.2F
            OrdersDetail.Name = "OrdersDetail"
            ' 
            ' ReportHeader1
            ' 
            ReportHeader1.Controls.AddRange(New XRControl() {panel1, xrTable1, xrPictureBoxLogo, xrTable4})
            ReportHeader1.Dpi = 96F
            ReportHeader1.HeightF = 440.8175F
            ReportHeader1.Name = "ReportHeader1"
            ' 
            ' panel1
            ' 
            panel1.BackColor = System.Drawing.Color.FromArgb(248, 249, 251)
            panel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            panel1.Controls.AddRange(New XRControl() {xrTable3})
            panel1.Dpi = 96F
            panel1.LocationFloat = New DevExpress.Utils.PointFloat(24.31999F, 137.5563F)
            panel1.Name = "panel1"
            panel1.SizeF = New System.Drawing.SizeF(656.6666F, 147.8788F)
            panel1.StylePriority.UseBackColor = False
            panel1.StylePriority.UseBorders = False
            ' 
            ' xrTable3
            ' 
            xrTable3.Dpi = 96F
            xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(22.93609F, 25.87239F)
            xrTable3.Name = "xrTable3"
            xrTable3.Rows.AddRange(New XRTableRow() {xrTableRow4, tableRow1, xrTableRow5, xrTableRow6})
            xrTable3.SizeF = New System.Drawing.SizeF(596.2111F, 122.0064F)
            xrTable3.StylePriority.UseTextAlignment = False
            xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow4
            ' 
            xrTableRow4.Cells.AddRange(New XRTableCell() {xrTableCell2, xrTableCell6})
            xrTableRow4.Dpi = 96F
            xrTableRow4.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            xrTableRow4.ForeColor = System.Drawing.Color.FromArgb(166, 166, 166)
            xrTableRow4.Name = "xrTableRow4"
            xrTableRow4.StylePriority.UseFont = False
            xrTableRow4.StylePriority.UseForeColor = False
            xrTableRow4.Weight = 0.8269312838050884R
            ' 
            ' xrTableCell2
            ' 
            xrTableCell2.CanGrow = False
            xrTableCell2.Dpi = 96F
            xrTableCell2.Name = "xrTableCell2"
            xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell2.StyleName = "BillingShippingHeaderStyle"
            xrTableCell2.StylePriority.UsePadding = False
            xrTableCell2.Text = "Billing Address"
            xrTableCell2.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell6
            ' 
            xrTableCell6.CanGrow = False
            xrTableCell6.Dpi = 96F
            xrTableCell6.Name = "xrTableCell6"
            xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell6.StyleName = "BillingShippingHeaderStyle"
            xrTableCell6.StylePriority.UsePadding = False
            xrTableCell6.Text = "Shipping Address"
            xrTableCell6.Weight = 1.7439938465818574R
            ' 
            ' tableRow1
            ' 
            tableRow1.Cells.AddRange(New XRTableCell() {tableCell1, tableCell2})
            tableRow1.Dpi = 96F
            tableRow1.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            tableRow1.ForeColor = System.Drawing.Color.FromArgb(166, 166, 166)
            tableRow1.Name = "tableRow1"
            tableRow1.StylePriority.UseFont = False
            tableRow1.StylePriority.UseForeColor = False
            tableRow1.Weight = 0.34950031364622997R
            ' 
            ' tableCell1
            ' 
            tableCell1.CanGrow = False
            tableCell1.Dpi = 96F
            tableCell1.Multiline = True
            tableCell1.Name = "tableCell1"
            tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            tableCell1.StyleName = "BillingShippingHeaderStyle"
            tableCell1.StylePriority.UsePadding = False
            tableCell1.Weight = 1.2560061534181426R
            ' 
            ' tableCell2
            ' 
            tableCell2.CanGrow = False
            tableCell2.Dpi = 96F
            tableCell2.Multiline = True
            tableCell2.Name = "tableCell2"
            tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            tableCell2.StyleName = "BillingShippingHeaderStyle"
            tableCell2.StylePriority.UsePadding = False
            tableCell2.Weight = 1.7439938465818574R
            ' 
            ' xrTableRow5
            ' 
            xrTableRow5.Cells.AddRange(New XRTableCell() {xrTableCell7, xrTableCell8})
            xrTableRow5.Dpi = 96F
            xrTableRow5.Font = New DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableRow5.Name = "xrTableRow5"
            xrTableRow5.StylePriority.UseFont = False
            xrTableRow5.Weight = 0.88845332146656031R
            ' 
            ' xrTableCell7
            ' 
            xrTableCell7.CanGrow = False
            xrTableCell7.Dpi = 96F
            xrTableCell7.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")})
            xrTableCell7.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell7.Name = "xrTableCell7"
            xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell7.StyleName = "General"
            xrTableCell7.StylePriority.UseFont = False
            xrTableCell7.StylePriority.UsePadding = False
            xrTableCell7.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell8
            ' 
            xrTableCell8.Dpi = 96F
            xrTableCell8.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")})
            xrTableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            xrTableCell8.Name = "xrTableCell8"
            xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell8.StyleName = "General"
            xrTableCell8.StylePriority.UseFont = False
            xrTableCell8.StylePriority.UsePadding = False
            xrTableCell8.Weight = 1.7439938465818574R
            ' 
            ' xrTableRow6
            ' 
            xrTableRow6.Cells.AddRange(New XRTableCell() {xrTableCell9, xrTableCell10})
            xrTableRow6.Dpi = 96F
            xrTableRow6.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            xrTableRow6.Name = "xrTableRow6"
            xrTableRow6.StylePriority.UseFont = False
            xrTableRow6.Weight = 3.0187164242698779R
            ' 
            ' xrTableCell9
            ' 
            xrTableCell9.Dpi = 96F
            xrTableCell9.Multiline = True
            xrTableCell9.Name = "xrTableCell9"
            xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell9.StyleName = "General"
            xrTableCell9.StylePriority.UsePadding = False
            xrTableCell9.StylePriority.UseTextAlignment = False
            xrTableCell9.Text = "Home Office" & Microsoft.VisualBasic.Constants.vbCrLf & "[Customer.HomeOffice_Line]" & Microsoft.VisualBasic.Constants.vbCrLf & "[Customer.HomeOffice_City], [Customer.Ho" & "meOffice_StateName] [Customer.HomeOffice_ZipCode]"
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            xrTableCell9.Weight = 1.2560061534181426R
            ' 
            ' xrTableCell10
            ' 
            xrTableCell10.Dpi = 96F
            xrTableCell10.Multiline = True
            xrTableCell10.Name = "xrTableCell10"
            xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTableCell10.StyleName = "General"
            xrTableCell10.StylePriority.UsePadding = False
            xrTableCell10.StylePriority.UseTextAlignment = False
            xrTableCell10.Text = "[Store.Address_City] Store" & Microsoft.VisualBasic.Constants.vbCrLf & "[Store.Address_Line]" & Microsoft.VisualBasic.Constants.vbCrLf & "[Store.Address_City], [Store.Ad" & "dress_StateName] [Store.Address_ZipCode]"
            xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            xrTableCell10.Weight = 1.7439938465818574R
            ' 
            ' xrTable1
            ' 
            xrTable1.Dpi = 96F
            xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(22.9952F, 50.39841F)
            xrTable1.Name = "xrTable1"
            xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F)
            xrTable1.Rows.AddRange(New XRTableRow() {xrTableRow1, xrTableRow3})
            xrTable1.SizeF = New System.Drawing.SizeF(430.9133F, 62.41702F)
            xrTable1.StylePriority.UseFont = False
            xrTable1.StylePriority.UsePadding = False
            xrTable1.StylePriority.UseTextAlignment = False
            xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow1
            ' 
            xrTableRow1.Cells.AddRange(New XRTableCell() {xrTableCell1})
            xrTableRow1.Dpi = 96F
            xrTableRow1.Font = New DevExpress.Drawing.DXFont("Arial", 14F)
            xrTableRow1.Name = "xrTableRow1"
            xrTableRow1.StylePriority.UseFont = False
            xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            xrTableCell1.CanGrow = False
            xrTableCell1.Dpi = 96F
            xrTableCell1.Name = "xrTableCell1"
            xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            xrTableCell1.StyleName = "HeaderStyle"
            xrTableCell1.StylePriority.UseFont = False
            xrTableCell1.StylePriority.UseForeColor = False
            xrTableCell1.StylePriority.UsePadding = False
            xrTableCell1.StylePriority.UseTextAlignment = False
            xrTableCell1.Text = "Invoice # [InvoiceNumber]"
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell1.Weight = 0.3656307129798903R
            ' 
            ' xrTableRow3
            ' 
            xrTableRow3.Cells.AddRange(New XRTableCell() {xrTableCell3})
            xrTableRow3.Dpi = 96F
            xrTableRow3.Name = "xrTableRow3"
            xrTableRow3.Weight = 7.1843158466786257R
            ' 
            ' xrTableCell3
            ' 
            xrTableCell3.CanGrow = False
            xrTableCell3.Dpi = 96F
            xrTableCell3.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            xrTableCell3.Name = "xrTableCell3"
            xrTableCell3.StyleName = "General"
            xrTableCell3.StylePriority.UseFont = False
            xrTableCell3.StylePriority.UsePadding = False
            xrTableCell3.StylePriority.UseTextAlignment = False
            xrTableCell3.Text = "[OrderDate!MM/dd/yy]"
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell3.Weight = 0.3656307129798903R
            ' 
            ' xrPictureBoxLogo
            ' 
            xrPictureBoxLogo.Dpi = 96F
            xrPictureBoxLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBoxLogo.ImageSource"))
            xrPictureBoxLogo.LocationFloat = New DevExpress.Utils.PointFloat(490.6027F, 32.12367F)
            xrPictureBoxLogo.Name = "xrPictureBoxLogo"
            xrPictureBoxLogo.SizeF = New System.Drawing.SizeF(193.0292F, 57.15536F)
            xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrTable4
            ' 
            xrTable4.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTable4.Dpi = 96F
            xrTable4.Font = New DevExpress.Drawing.DXFont("Arial", 11F)
            xrTable4.LocationFloat = New DevExpress.Utils.PointFloat(22.99519F, 319.6004F)
            xrTable4.Name = "xrTable4"
            xrTable4.Rows.AddRange(New XRTableRow() {xrTableRow7, xrTableRow8})
            xrTable4.SizeF = New System.Drawing.SizeF(657.9914F, 62.595F)
            xrTable4.StylePriority.UseBorders = False
            xrTable4.StylePriority.UseFont = False
            xrTable4.StylePriority.UseTextAlignment = False
            xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow7
            ' 
            xrTableRow7.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
            xrTableRow7.Cells.AddRange(New XRTableCell() {xrTableCell11, xrTableCell12, xrTableCell14, xrTableCell15, xrTableCell16, xrTableCell17})
            xrTableRow7.Dpi = 96F
            xrTableRow7.Name = "xrTableRow7"
            xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 96F)
            xrTableRow7.StylePriority.UseBackColor = False
            xrTableRow7.StylePriority.UsePadding = False
            xrTableRow7.Weight = 1.3351953125R
            ' 
            ' xrTableCell11
            ' 
            xrTableCell11.Dpi = 96F
            xrTableCell11.Name = "xrTableCell11"
            xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 96F)
            xrTableCell11.StyleName = "TableHeaderStyle"
            xrTableCell11.StylePriority.UsePadding = False
            xrTableCell11.StylePriority.UseTextAlignment = False
            xrTableCell11.Text = "Sales Rep."
            xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell11.Weight = 0.87337124463981453R
            ' 
            ' xrTableCell12
            ' 
            xrTableCell12.Dpi = 96F
            xrTableCell12.Name = "xrTableCell12"
            xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 2, 0, 96F)
            xrTableCell12.StyleName = "TableHeaderStyle"
            xrTableCell12.StylePriority.UsePadding = False
            xrTableCell12.StylePriority.UseTextAlignment = False
            xrTableCell12.Text = "PO #"
            xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell12.Weight = 0.542657708540922R
            ' 
            ' xrTableCell14
            ' 
            xrTableCell14.Dpi = 96F
            xrTableCell14.Name = "xrTableCell14"
            xrTableCell14.StyleName = "TableHeaderStyle"
            xrTableCell14.Text = "Ship Date"
            xrTableCell14.Weight = 0.69479935035123674R
            ' 
            ' xrTableCell15
            ' 
            xrTableCell15.Dpi = 96F
            xrTableCell15.Name = "xrTableCell15"
            xrTableCell15.StyleName = "TableHeaderStyle"
            xrTableCell15.Text = "Ship Via"
            xrTableCell15.Weight = 0.92323718365925511R
            ' 
            ' xrTableCell16
            ' 
            xrTableCell16.Dpi = 96F
            xrTableCell16.Name = "xrTableCell16"
            xrTableCell16.StyleName = "TableHeaderStyle"
            xrTableCell16.Text = "FOB"
            xrTableCell16.Weight = 0.54709842411275023R
            ' 
            ' xrTableCell17
            ' 
            xrTableCell17.Dpi = 96F
            xrTableCell17.Name = "xrTableCell17"
            xrTableCell17.StyleName = "TableHeaderStyle"
            xrTableCell17.Text = "Terms"
            xrTableCell17.Weight = 0.87980333477995443R
            ' 
            ' xrTableRow8
            ' 
            xrTableRow8.BorderColor = System.Drawing.Color.FromArgb(229, 229, 229)
            xrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableRow8.Cells.AddRange(New XRTableCell() {xrTableCell13, xrTableCell18, xrTableCell19, xrTableCell20, xrTableCell21, xrTableCell22})
            xrTableRow8.Dpi = 96F
            xrTableRow8.Name = "xrTableRow8"
            xrTableRow8.StylePriority.UseBorderColor = False
            xrTableRow8.StylePriority.UseBorders = False
            xrTableRow8.Weight = 1.272927903327012R
            ' 
            ' xrTableCell13
            ' 
            xrTableCell13.Dpi = 96F
            xrTableCell13.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Employee.FullName]")})
            xrTableCell13.Name = "xrTableCell13"
            xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F)
            xrTableCell13.StyleName = "General"
            xrTableCell13.StylePriority.UsePadding = False
            xrTableCell13.StylePriority.UseTextAlignment = False
            xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell13.Weight = 0.87337124463981453R
            ' 
            ' xrTableCell18
            ' 
            xrTableCell18.Dpi = 96F
            xrTableCell18.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[PONumber]")})
            xrTableCell18.Name = "xrTableCell18"
            xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 96F)
            xrTableCell18.StyleName = "General"
            xrTableCell18.StylePriority.UsePadding = False
            xrTableCell18.StylePriority.UseTextAlignment = False
            xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell18.Weight = 0.54265752408010282R
            ' 
            ' xrTableCell19
            ' 
            xrTableCell19.Dpi = 96F
            xrTableCell19.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "GetDate([ShipDate])")})
            xrTableCell19.Name = "xrTableCell19"
            xrTableCell19.StyleName = "General"
            xrTableCell19.TextFormatString = "{0:MM/dd/yyyy}"
            xrTableCell19.Weight = 0.69479976538807975R
            ' 
            ' xrTableCell20
            ' 
            xrTableCell20.Dpi = 96F
            xrTableCell20.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "iif([ShipMethod] = 0, 'Ground', [ShipMethod] = 1, 'Air', '-')")})
            xrTableCell20.Name = "xrTableCell20"
            xrTableCell20.StyleName = "General"
            xrTableCell20.Weight = 0.9232372439369031R
            ' 
            ' xrTableCell21
            ' 
            xrTableCell21.Dpi = 96F
            xrTableCell21.Name = "xrTableCell21"
            xrTableCell21.Text = " - "
            xrTableCell21.Weight = 0.54709823257070933R
            ' 
            ' xrTableCell22
            ' 
            xrTableCell22.Dpi = 96F
            xrTableCell22.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[OrderTerms]")})
            xrTableCell22.Name = "xrTableCell22"
            xrTableCell22.StyleName = "General"
            xrTableCell22.Weight = 0.87980323546832329R
            ' 
            ' GroupFooter2
            ' 
            GroupFooter2.Controls.AddRange(New XRControl() {xrPdfSignature1, xrTable6})
            GroupFooter2.Dpi = 96F
            GroupFooter2.HeightF = 159.7737F
            GroupFooter2.Name = "GroupFooter2"
            GroupFooter2.PrintAtBottom = True
            ' 
            ' xrTable6
            ' 
            xrTable6.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTable6.Dpi = 96F
            xrTable6.LocationFloat = New DevExpress.Utils.PointFloat(460.2045F, 41.94443F)
            xrTable6.Name = "xrTable6"
            xrTable6.Rows.AddRange(New XRTableRow() {xrTableRow10, xrTableRow11, xrTableRow12})
            xrTable6.SizeF = New System.Drawing.SizeF(220.4065F, 94.40681F)
            xrTable6.StylePriority.UseBorders = False
            ' 
            ' xrTableRow10
            ' 
            xrTableRow10.Cells.AddRange(New XRTableCell() {xrTableCell28, xrTableCell29})
            xrTableRow10.Dpi = 96F
            xrTableRow10.Name = "xrTableRow10"
            xrTableRow10.Weight = 1.6445612561757967R
            ' 
            ' xrTableCell28
            ' 
            xrTableCell28.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            xrTableCell28.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            xrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell28.Dpi = 96F
            xrTableCell28.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            xrTableCell28.Name = "xrTableCell28"
            xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 96F)
            xrTableCell28.StyleName = "TableOddStyle"
            xrTableCell28.StylePriority.UseBackColor = False
            xrTableCell28.StylePriority.UseBorderColor = False
            xrTableCell28.StylePriority.UseBorders = False
            xrTableCell28.StylePriority.UseFont = False
            xrTableCell28.StylePriority.UsePadding = False
            xrTableCell28.StylePriority.UseTextAlignment = False
            xrTableCell28.Text = "Sub Total"
            xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell28.Weight = 1.8279264198044849R
            ' 
            ' xrTableCell29
            ' 
            xrTableCell29.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            xrTableCell29.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            xrTableCell29.Borders = DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell29.Dpi = 96F
            xrTableCell29.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumSum([OrderItems].[Total])")})
            xrTableCell29.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            xrTableCell29.Name = "xrTableCell29"
            xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 2, 0, 96F)
            xrTableCell29.StyleName = "TableOddStyle"
            xrTableCell29.StylePriority.UseBackColor = False
            xrTableCell29.StylePriority.UseBorderColor = False
            xrTableCell29.StylePriority.UseBorders = False
            xrTableCell29.StylePriority.UseFont = False
            xrTableCell29.StylePriority.UsePadding = False
            xrTableCell29.StylePriority.UseTextAlignment = False
            xrSummary1.Running = SummaryRunning.Report
            xrTableCell29.Summary = xrSummary1
            xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell29.TextFormatString = "{0:$#,#}"
            xrTableCell29.Weight = 1.2142824291082539R
            ' 
            ' xrTableRow11
            ' 
            xrTableRow11.Cells.AddRange(New XRTableCell() {xrTableCell30, xrTableCell31})
            xrTableRow11.Dpi = 96F
            xrTableRow11.Name = "xrTableRow11"
            xrTableRow11.Weight = 1.5315354078890038R
            ' 
            ' xrTableCell30
            ' 
            xrTableCell30.BackColor = System.Drawing.Color.Transparent
            xrTableCell30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell30.Dpi = 96F
            xrTableCell30.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            xrTableCell30.Name = "xrTableCell30"
            xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F)
            xrTableCell30.StyleName = "TableHeaderStyle"
            xrTableCell30.StylePriority.UseBackColor = False
            xrTableCell30.StylePriority.UseBorders = False
            xrTableCell30.StylePriority.UseFont = False
            xrTableCell30.StylePriority.UsePadding = False
            xrTableCell30.StylePriority.UseTextAlignment = False
            xrTableCell30.Text = "Shipping"
            xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell30.Weight = 1.82792864409057R
            ' 
            ' xrTableCell31
            ' 
            xrTableCell31.BackColor = System.Drawing.Color.Transparent
            xrTableCell31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell31.Dpi = 96F
            xrTableCell31.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[ShippingAmount]")})
            xrTableCell31.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            xrTableCell31.Name = "xrTableCell31"
            xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F)
            xrTableCell31.StyleName = "TableHeaderStyle"
            xrTableCell31.StylePriority.UseBackColor = False
            xrTableCell31.StylePriority.UseBorders = False
            xrTableCell31.StylePriority.UseFont = False
            xrTableCell31.StylePriority.UsePadding = False
            xrTableCell31.StylePriority.UseTextAlignment = False
            xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell31.TextFormatString = "{0:$#,#}"
            xrTableCell31.Weight = 1.2142813010470537R
            ' 
            ' xrTableRow12
            ' 
            xrTableRow12.Cells.AddRange(New XRTableCell() {xrTableCell32, xrTableCell33})
            xrTableRow12.Dpi = 96F
            xrTableRow12.Name = "xrTableRow12"
            xrTableRow12.Weight = 1.6255815606400634R
            ' 
            ' xrTableCell32
            ' 
            xrTableCell32.BackColor = System.Drawing.Color.Transparent
            xrTableCell32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell32.Dpi = 96F
            xrTableCell32.Name = "xrTableCell32"
            xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F)
            xrTableCell32.StyleName = "TableHeaderStyle"
            xrTableCell32.StylePriority.UseBackColor = False
            xrTableCell32.StylePriority.UseBorders = False
            xrTableCell32.StylePriority.UseFont = False
            xrTableCell32.StylePriority.UsePadding = False
            xrTableCell32.StylePriority.UseTextAlignment = False
            xrTableCell32.Text = "Total Due"
            xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell32.Weight = 1.82792864409057R
            ' 
            ' xrTableCell33
            ' 
            xrTableCell33.BackColor = System.Drawing.Color.Transparent
            xrTableCell33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableCell33.Dpi = 96F
            xrTableCell33.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")})
            xrTableCell33.Name = "xrTableCell33"
            xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F)
            xrTableCell33.StyleName = "TableHeaderStyle"
            xrTableCell33.StylePriority.UseBackColor = False
            xrTableCell33.StylePriority.UseBorders = False
            xrTableCell33.StylePriority.UseFont = False
            xrTableCell33.StylePriority.UsePadding = False
            xrTableCell33.StylePriority.UseTextAlignment = False
            xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell33.TextFormatString = "{0:$#,#}"
            xrTableCell33.Weight = 1.2142813010470537R
            ' 
            ' GroupHeader2
            ' 
            GroupHeader2.Controls.AddRange(New XRControl() {xrTable5})
            GroupHeader2.Dpi = 96F
            GroupHeader2.HeightF = 30.38236F
            GroupHeader2.Name = "GroupHeader2"
            ' 
            ' xrTable5
            ' 
            xrTable5.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
            xrTable5.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            xrTable5.Dpi = 96F
            xrTable5.Font = New DevExpress.Drawing.DXFont("Arial", 13F)
            xrTable5.ForeColor = System.Drawing.Color.FromArgb(113, 112, 116)
            xrTable5.LocationFloat = New DevExpress.Utils.PointFloat(22.99513F, 0.3823617F)
            xrTable5.Name = "xrTable5"
            xrTable5.Rows.AddRange(New XRTableRow() {xrTableRow9})
            xrTable5.SizeF = New System.Drawing.SizeF(657.9914F, 30F)
            xrTable5.StylePriority.UseBackColor = False
            xrTable5.StylePriority.UseBorders = False
            xrTable5.StylePriority.UseFont = False
            xrTable5.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow9
            ' 
            xrTableRow9.Cells.AddRange(New XRTableCell() {xrTableCell23, xrTableCell24, xrTableCell26, xrTableCell27, xrTableCell25})
            xrTableRow9.Dpi = 96F
            xrTableRow9.Name = "xrTableRow9"
            xrTableRow9.StylePriority.UseBorders = False
            xrTableRow9.Weight = 1.031581923608158R
            ' 
            ' xrTableCell23
            ' 
            xrTableCell23.Dpi = 96F
            xrTableCell23.Name = "xrTableCell23"
            xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 96F)
            xrTableCell23.StyleName = "DetailTableHeaderStyle"
            xrTableCell23.StylePriority.UsePadding = False
            xrTableCell23.StylePriority.UseTextAlignment = False
            xrTableCell23.Text = "Description"
            xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell23.Weight = 0.74283632613826966R
            ' 
            ' xrTableCell24
            ' 
            xrTableCell24.Dpi = 96F
            xrTableCell24.Name = "xrTableCell24"
            xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 8, 0, 0, 96F)
            xrTableCell24.StyleName = "DetailTableHeaderStyle"
            xrTableCell24.StylePriority.UsePadding = False
            xrTableCell24.StylePriority.UseTextAlignment = False
            xrTableCell24.Text = "Unit Price"
            xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell24.Weight = 0.69508230296883622R
            ' 
            ' xrTableCell26
            ' 
            xrTableCell26.Dpi = 96F
            xrTableCell26.Name = "xrTableCell26"
            xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 96F)
            xrTableCell26.StyleName = "DetailTableHeaderStyle"
            xrTableCell26.StylePriority.UsePadding = False
            xrTableCell26.StylePriority.UseTextAlignment = False
            xrTableCell26.Text = "Quantity"
            xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell26.Weight = 0.52416638509731162R
            ' 
            ' xrTableCell27
            ' 
            xrTableCell27.Dpi = 96F
            xrTableCell27.Name = "xrTableCell27"
            xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F)
            xrTableCell27.StyleName = "DetailTableHeaderStyle"
            xrTableCell27.StylePriority.UsePadding = False
            xrTableCell27.StylePriority.UseTextAlignment = False
            xrTableCell27.Text = "Discount"
            xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell27.Weight = 0.52416638509731162R
            ' 
            ' xrTableCell25
            ' 
            xrTableCell25.Dpi = 96F
            xrTableCell25.Name = "xrTableCell25"
            xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 96F)
            xrTableCell25.StyleName = "DetailTableHeaderStyle"
            xrTableCell25.StylePriority.UsePadding = False
            xrTableCell25.StylePriority.UseTextAlignment = False
            xrTableCell25.Text = "Total"
            xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell25.Weight = 0.52416638509731162R
            ' 
            ' DetailReport
            ' 
            DetailReport.Bands.AddRange(New Band() {Detail})
            DetailReport.DataMember = "Orders.OrderItems"
            DetailReport.DataSource = reportSqlDataSource
            DetailReport.Dpi = 96F
            DetailReport.Level = 0
            DetailReport.Name = "DetailReport"
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New XRControl() {xrTable2})
            Detail.Dpi = 96F
            Detail.FillEmptySpace = True
            Detail.HeightF = 30F
            Detail.HierarchyPrintOptions.Indent = 19.2F
            Detail.Name = "Detail"
            ' 
            ' xrTable2
            ' 
            xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
            xrTable2.Dpi = 96F
            xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(24.31999F, 0F)
            xrTable2.Name = "xrTable2"
            xrTable2.OddStyleName = "TableOddStyle"
            xrTable2.Rows.AddRange(New XRTableRow() {xrTableRow13})
            xrTable2.SizeF = New System.Drawing.SizeF(656.6665F, 30F)
            xrTable2.StylePriority.UseBorders = False
            ' 
            ' xrTableRow13
            ' 
            xrTableRow13.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            xrTableRow13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            xrTableRow13.Cells.AddRange(New XRTableCell() {xrTableCell34, xrTableCell35, xrTableCell36, xrTableCell37, xrTableCell38})
            xrTableRow13.Dpi = 96F
            xrTableRow13.Name = "xrTableRow13"
            xrTableRow13.StylePriority.UseBorderColor = False
            xrTableRow13.StylePriority.UseBorders = False
            xrTableRow13.Weight = 3.021817127268994R
            ' 
            ' xrTableCell34
            ' 
            xrTableCell34.Dpi = 96F
            xrTableCell34.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Product_Name]")})
            xrTableCell34.Multiline = True
            xrTableCell34.Name = "xrTableCell34"
            xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 96F)
            xrTableCell34.StyleName = "General"
            xrTableCell34.StylePriority.UseFont = False
            xrTableCell34.StylePriority.UsePadding = False
            xrTableCell34.StylePriority.UseTextAlignment = False
            xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell34.Weight = 180.88969053070841R
            ' 
            ' xrTableCell35
            ' 
            xrTableCell35.Dpi = 96F
            xrTableCell35.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[ProductPrice]")})
            xrTableCell35.Multiline = True
            xrTableCell35.Name = "xrTableCell35"
            xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 8, 0, 0, 96F)
            xrTableCell35.StyleName = "General"
            xrTableCell35.StylePriority.UseFont = False
            xrTableCell35.StylePriority.UsePadding = False
            xrTableCell35.StylePriority.UseTextAlignment = False
            xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell35.TextFormatString = "{0:$#,#}"
            xrTableCell35.Weight = 168.48122563857984R
            ' 
            ' xrTableCell36
            ' 
            xrTableCell36.Dpi = 96F
            xrTableCell36.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[ProductUnits]")})
            xrTableCell36.Multiline = True
            xrTableCell36.Name = "xrTableCell36"
            xrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 96F)
            xrTableCell36.StyleName = "General"
            xrTableCell36.StylePriority.UseFont = False
            xrTableCell36.StylePriority.UsePadding = False
            xrTableCell36.StylePriority.UseTextAlignment = False
            xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell36.Weight = 127.89576640347559R
            ' 
            ' xrTableCell37
            ' 
            xrTableCell37.Dpi = 96F
            xrTableCell37.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Discount]")})
            xrTableCell37.Multiline = True
            xrTableCell37.Name = "xrTableCell37"
            xrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F)
            xrTableCell37.StyleName = "General"
            xrTableCell37.StylePriority.UseFont = False
            xrTableCell37.StylePriority.UsePadding = False
            xrTableCell37.StylePriority.UseTextAlignment = False
            xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell37.TextFormatString = "{0:$#,#;$#,#;'-'}"
            xrTableCell37.Weight = 127.89576640347559R
            ' 
            ' xrTableCell38
            ' 
            xrTableCell38.Dpi = 96F
            xrTableCell38.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[Total]")})
            xrTableCell38.Multiline = True
            xrTableCell38.Name = "xrTableCell38"
            xrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 96F)
            xrTableCell38.StyleName = "General"
            xrTableCell38.StylePriority.UseFont = False
            xrTableCell38.StylePriority.UsePadding = False
            xrTableCell38.StylePriority.UseTextAlignment = False
            xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell38.TextFormatString = "{0:$#,#}"
            xrTableCell38.Weight = 127.89576640347559R
            ' 
            ' reportSqlDataSource
            ' 
            reportSqlDataSource.ConnectionName = "DevAvConnectionString"
            reportSqlDataSource.Name = "reportSqlDataSource"
            columnExpression5.ColumnName = "Id"
            table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""419"" />"
            table2.Name = "Orders"
            columnExpression5.Table = table2
            column4.Expression = columnExpression5
            columnExpression6.ColumnName = "InvoiceNumber"
            columnExpression6.Table = table2
            column5.Expression = columnExpression6
            columnExpression7.ColumnName = "CustomerId"
            columnExpression7.Table = table2
            column6.Expression = columnExpression7
            columnExpression8.ColumnName = "StoreId"
            columnExpression8.Table = table2
            column7.Expression = columnExpression8
            columnExpression9.ColumnName = "PONumber"
            columnExpression9.Table = table2
            column8.Expression = columnExpression9
            columnExpression10.ColumnName = "EmployeeId"
            columnExpression10.Table = table2
            column9.Expression = columnExpression10
            columnExpression11.ColumnName = "OrderDate"
            columnExpression11.Table = table2
            column10.Expression = columnExpression11
            columnExpression12.ColumnName = "SaleAmount"
            columnExpression12.Table = table2
            column11.Expression = columnExpression12
            columnExpression13.ColumnName = "ShippingAmount"
            columnExpression13.Table = table2
            column12.Expression = columnExpression13
            columnExpression14.ColumnName = "TotalAmount"
            columnExpression14.Table = table2
            column13.Expression = columnExpression14
            columnExpression15.ColumnName = "ShipDate"
            columnExpression15.Table = table2
            column14.Expression = columnExpression15
            columnExpression16.ColumnName = "ShipMethod"
            columnExpression16.Table = table2
            column15.Expression = columnExpression16
            columnExpression17.ColumnName = "OrderTerms"
            columnExpression17.Table = table2
            column16.Expression = columnExpression17
            columnExpression18.ColumnName = "ShipmentCourier"
            columnExpression18.Table = table2
            column17.Expression = columnExpression18
            columnExpression19.ColumnName = "ShipmentCourierId"
            columnExpression19.Table = table2
            column18.Expression = columnExpression19
            columnExpression20.ColumnName = "ShipmentStatus"
            columnExpression20.Table = table2
            column19.Expression = columnExpression20
            columnExpression21.ColumnName = "Comments"
            columnExpression21.Table = table2
            column20.Expression = columnExpression21
            columnExpression22.ColumnName = "RefundTotal"
            columnExpression22.Table = table2
            column21.Expression = columnExpression22
            columnExpression23.ColumnName = "PaymentTotal"
            columnExpression23.Table = table2
            column22.Expression = columnExpression23
            selectQuery2.Columns.Add(column4)
            selectQuery2.Columns.Add(column5)
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.Columns.Add(column18)
            selectQuery2.Columns.Add(column19)
            selectQuery2.Columns.Add(column20)
            selectQuery2.Columns.Add(column21)
            selectQuery2.Columns.Add(column22)
            selectQuery2.FilterString = "[Orders.InvoiceNumber] = ?parameterInvoiceNumber"
            selectQuery2.GroupFilterString = ""
            selectQuery2.MetaSerializable = "<Meta X=""110"" Y=""20"" Width=""180"" Height=""360"" />"
            selectQuery2.Name = "Orders"
            queryParameter1.Name = "parameterInvoiceNumber"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("?parameterInvoice", GetType(String))
            selectQuery2.Parameters.Add(queryParameter1)
            selectQuery2.Tables.Add(table2)
            columnExpression24.ColumnName = "Id"
            table3.Name = "Customers"
            columnExpression24.Table = table3
            column23.Expression = columnExpression24
            columnExpression25.ColumnName = "Name"
            columnExpression25.Table = table3
            column24.Expression = columnExpression25
            columnExpression26.ColumnName = "HomeOffice_Line"
            columnExpression26.Table = table3
            column25.Expression = columnExpression26
            columnExpression27.ColumnName = "HomeOffice_City"
            columnExpression27.Table = table3
            column26.Expression = columnExpression27
            columnExpression28.ColumnName = "HomeOffice_State"
            columnExpression28.Table = table3
            column27.Expression = columnExpression28
            columnExpression29.ColumnName = "HomeOffice_Latitude"
            columnExpression29.Table = table3
            column28.Expression = columnExpression29
            columnExpression30.ColumnName = "HomeOffice_Longitude"
            columnExpression30.Table = table3
            column29.Expression = columnExpression30
            columnExpression31.ColumnName = "HomeOffice_ZipCode"
            columnExpression31.Table = table3
            column30.Expression = columnExpression31
            columnExpression32.ColumnName = "BillingAddress_Line"
            columnExpression32.Table = table3
            column31.Expression = columnExpression32
            columnExpression33.ColumnName = "BillingAddress_City"
            columnExpression33.Table = table3
            column32.Expression = columnExpression33
            columnExpression34.ColumnName = "BillingAddress_State"
            columnExpression34.Table = table3
            column33.Expression = columnExpression34
            columnExpression35.ColumnName = "BillingAddress_Latitude"
            columnExpression35.Table = table3
            column34.Expression = columnExpression35
            columnExpression36.ColumnName = "BillingAddress_Longitude"
            columnExpression36.Table = table3
            column35.Expression = columnExpression36
            columnExpression37.ColumnName = "BillingAddress_ZipCode"
            columnExpression37.Table = table3
            column36.Expression = columnExpression37
            columnExpression38.ColumnName = "HomeOfficeLine"
            columnExpression38.Table = table3
            column37.Expression = columnExpression38
            columnExpression39.ColumnName = "HomeOfficeCity"
            columnExpression39.Table = table3
            column38.Expression = columnExpression39
            columnExpression40.ColumnName = "HomeOfficeZipCode"
            columnExpression40.Table = table3
            column39.Expression = columnExpression40
            columnExpression41.ColumnName = "BillingAddressLine"
            columnExpression41.Table = table3
            column40.Expression = columnExpression41
            columnExpression42.ColumnName = "BillingAddressCity"
            columnExpression42.Table = table3
            column41.Expression = columnExpression42
            columnExpression43.ColumnName = "BillingAddressZipCode"
            columnExpression43.Table = table3
            column42.Expression = columnExpression43
            columnExpression44.ColumnName = "HomeOfficeState"
            columnExpression44.Table = table3
            column43.Expression = columnExpression44
            columnExpression45.ColumnName = "HomeOfficeLatitude"
            columnExpression45.Table = table3
            column44.Expression = columnExpression45
            columnExpression46.ColumnName = "HomeOfficeLongitude"
            columnExpression46.Table = table3
            column45.Expression = columnExpression46
            columnExpression47.ColumnName = "BillingAddressState"
            columnExpression47.Table = table3
            column46.Expression = columnExpression47
            columnExpression48.ColumnName = "BillingAddressLatitude"
            columnExpression48.Table = table3
            column47.Expression = columnExpression48
            columnExpression49.ColumnName = "BillingAddressLongitude"
            columnExpression49.Table = table3
            column48.Expression = columnExpression49
            columnExpression50.ColumnName = "Phone"
            columnExpression50.Table = table3
            column49.Expression = columnExpression50
            columnExpression51.ColumnName = "Fax"
            columnExpression51.Table = table3
            column50.Expression = columnExpression51
            columnExpression52.ColumnName = "Website"
            columnExpression52.Table = table3
            column51.Expression = columnExpression52
            columnExpression53.ColumnName = "AnnualRevenue"
            columnExpression53.Table = table3
            column52.Expression = columnExpression53
            columnExpression54.ColumnName = "TotalStores"
            columnExpression54.Table = table3
            column53.Expression = columnExpression54
            columnExpression55.ColumnName = "TotalEmployees"
            columnExpression55.Table = table3
            column54.Expression = columnExpression55
            columnExpression56.ColumnName = "Status"
            columnExpression56.Table = table3
            column55.Expression = columnExpression56
            columnExpression57.ColumnName = "Profile"
            columnExpression57.Table = table3
            column56.Expression = columnExpression57
            columnExpression58.ColumnName = "Logo"
            columnExpression58.Table = table3
            column57.Expression = columnExpression58
            selectQuery3.Columns.Add(column23)
            selectQuery3.Columns.Add(column24)
            selectQuery3.Columns.Add(column25)
            selectQuery3.Columns.Add(column26)
            selectQuery3.Columns.Add(column27)
            selectQuery3.Columns.Add(column28)
            selectQuery3.Columns.Add(column29)
            selectQuery3.Columns.Add(column30)
            selectQuery3.Columns.Add(column31)
            selectQuery3.Columns.Add(column32)
            selectQuery3.Columns.Add(column33)
            selectQuery3.Columns.Add(column34)
            selectQuery3.Columns.Add(column35)
            selectQuery3.Columns.Add(column36)
            selectQuery3.Columns.Add(column37)
            selectQuery3.Columns.Add(column38)
            selectQuery3.Columns.Add(column39)
            selectQuery3.Columns.Add(column40)
            selectQuery3.Columns.Add(column41)
            selectQuery3.Columns.Add(column42)
            selectQuery3.Columns.Add(column43)
            selectQuery3.Columns.Add(column44)
            selectQuery3.Columns.Add(column45)
            selectQuery3.Columns.Add(column46)
            selectQuery3.Columns.Add(column47)
            selectQuery3.Columns.Add(column48)
            selectQuery3.Columns.Add(column49)
            selectQuery3.Columns.Add(column50)
            selectQuery3.Columns.Add(column51)
            selectQuery3.Columns.Add(column52)
            selectQuery3.Columns.Add(column53)
            selectQuery3.Columns.Add(column54)
            selectQuery3.Columns.Add(column55)
            selectQuery3.Columns.Add(column56)
            selectQuery3.Columns.Add(column57)
            selectQuery3.MetaSerializable = "<Meta X=""330"" Y=""20"" Width=""260"" Height=""632"" />"
            selectQuery3.Name = "Customers"
            selectQuery3.Tables.Add(table3)
            columnExpression59.ColumnName = "Id"
            table4.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""191"" />"
            table4.Name = "OrderItems"
            columnExpression59.Table = table4
            column58.Expression = columnExpression59
            columnExpression60.ColumnName = "OrderId"
            columnExpression60.Table = table4
            column59.Expression = columnExpression60
            columnExpression61.ColumnName = "ProductId"
            columnExpression61.Table = table4
            column60.Expression = columnExpression61
            columnExpression62.ColumnName = "ProductUnits"
            columnExpression62.Table = table4
            column61.Expression = columnExpression62
            columnExpression63.ColumnName = "ProductPrice"
            columnExpression63.Table = table4
            column62.Expression = columnExpression63
            columnExpression64.ColumnName = "Discount"
            columnExpression64.Table = table4
            column63.Expression = columnExpression64
            columnExpression65.ColumnName = "Total"
            columnExpression65.Table = table4
            column64.Expression = columnExpression65
            column65.Alias = "Product_Name"
            columnExpression66.ColumnName = "Name"
            table5.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""419"" />"
            table5.Name = "Products"
            columnExpression66.Table = table5
            column65.Expression = columnExpression66
            selectQuery4.Columns.Add(column58)
            selectQuery4.Columns.Add(column59)
            selectQuery4.Columns.Add(column60)
            selectQuery4.Columns.Add(column61)
            selectQuery4.Columns.Add(column62)
            selectQuery4.Columns.Add(column63)
            selectQuery4.Columns.Add(column64)
            selectQuery4.Columns.Add(column65)
            selectQuery4.MetaSerializable = "<Meta X=""-30"" Y=""20"" Width=""100"" Height=""173"" />"
            selectQuery4.Name = "OrderItems"
            relationColumnInfo1.NestedKeyColumn = "Id"
            relationColumnInfo1.ParentKeyColumn = "ProductId"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table5
            join1.Parent = table4
            selectQuery4.Relations.Add(join1)
            columnExpression67.ColumnName = "ProductUnits"
            columnExpression67.Table = table4
            sorting2.Expression = columnExpression67
            selectQuery4.Sorting.Add(sorting2)
            selectQuery4.Tables.Add(table4)
            selectQuery4.Tables.Add(table5)
            columnExpression68.ColumnName = "Id"
            table6.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""457"" />"
            table6.Name = "CustomerStores"
            columnExpression68.Table = table6
            column66.Expression = columnExpression68
            columnExpression69.ColumnName = "CustomerId"
            columnExpression69.Table = table6
            column67.Expression = columnExpression69
            columnExpression70.ColumnName = "Address_Line"
            columnExpression70.Table = table6
            column68.Expression = columnExpression70
            columnExpression71.ColumnName = "Address_City"
            columnExpression71.Table = table6
            column69.Expression = columnExpression71
            columnExpression72.ColumnName = "Address_State"
            columnExpression72.Table = table6
            column70.Expression = columnExpression72
            columnExpression73.ColumnName = "Address_Latitude"
            columnExpression73.Table = table6
            column71.Expression = columnExpression73
            columnExpression74.ColumnName = "Address_Longitude"
            columnExpression74.Table = table6
            column72.Expression = columnExpression74
            columnExpression75.ColumnName = "Address_ZipCode"
            columnExpression75.Table = table6
            column73.Expression = columnExpression75
            columnExpression76.ColumnName = "Address_Line1"
            columnExpression76.Table = table6
            column74.Expression = columnExpression76
            columnExpression77.ColumnName = "Address_City1"
            columnExpression77.Table = table6
            column75.Expression = columnExpression77
            columnExpression78.ColumnName = "Address_State1"
            columnExpression78.Table = table6
            column76.Expression = columnExpression78
            columnExpression79.ColumnName = "Address_ZipCode1"
            columnExpression79.Table = table6
            column77.Expression = columnExpression79
            columnExpression80.ColumnName = "Address_Latitude1"
            columnExpression80.Table = table6
            column78.Expression = columnExpression80
            columnExpression81.ColumnName = "Address_Longitude1"
            columnExpression81.Table = table6
            column79.Expression = columnExpression81
            columnExpression82.ColumnName = "Phone"
            columnExpression82.Table = table6
            column80.Expression = columnExpression82
            columnExpression83.ColumnName = "Fax"
            columnExpression83.Table = table6
            column81.Expression = columnExpression83
            columnExpression84.ColumnName = "TotalEmployees"
            columnExpression84.Table = table6
            column82.Expression = columnExpression84
            columnExpression85.ColumnName = "SquereFootage"
            columnExpression85.Table = table6
            column83.Expression = columnExpression85
            columnExpression86.ColumnName = "AnnualSales"
            columnExpression86.Table = table6
            column84.Expression = columnExpression86
            columnExpression87.ColumnName = "CrestId"
            columnExpression87.Table = table6
            column85.Expression = columnExpression87
            columnExpression88.ColumnName = "Location"
            columnExpression88.Table = table6
            column86.Expression = columnExpression88
            selectQuery5.Columns.Add(column66)
            selectQuery5.Columns.Add(column67)
            selectQuery5.Columns.Add(column68)
            selectQuery5.Columns.Add(column69)
            selectQuery5.Columns.Add(column70)
            selectQuery5.Columns.Add(column71)
            selectQuery5.Columns.Add(column72)
            selectQuery5.Columns.Add(column73)
            selectQuery5.Columns.Add(column74)
            selectQuery5.Columns.Add(column75)
            selectQuery5.Columns.Add(column76)
            selectQuery5.Columns.Add(column77)
            selectQuery5.Columns.Add(column78)
            selectQuery5.Columns.Add(column79)
            selectQuery5.Columns.Add(column80)
            selectQuery5.Columns.Add(column81)
            selectQuery5.Columns.Add(column82)
            selectQuery5.Columns.Add(column83)
            selectQuery5.Columns.Add(column84)
            selectQuery5.Columns.Add(column85)
            selectQuery5.Columns.Add(column86)
            selectQuery5.MetaSerializable = "<Meta X=""0"" Y=""410"" Width=""141"" Height=""394"" />"
            selectQuery5.Name = "CustomerStores"
            selectQuery5.Tables.Add(table6)
            columnExpression89.ColumnName = "Id"
            table7.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""609"" />"
            table7.Name = "Employees"
            columnExpression89.Table = table7
            column87.Expression = columnExpression89
            columnExpression90.ColumnName = "Department"
            columnExpression90.Table = table7
            column88.Expression = columnExpression90
            columnExpression91.ColumnName = "Title"
            columnExpression91.Table = table7
            column89.Expression = columnExpression91
            columnExpression92.ColumnName = "Status"
            columnExpression92.Table = table7
            column90.Expression = columnExpression92
            columnExpression93.ColumnName = "HireDate"
            columnExpression93.Table = table7
            column91.Expression = columnExpression93
            columnExpression94.ColumnName = "PersonalProfile"
            columnExpression94.Table = table7
            column92.Expression = columnExpression94
            columnExpression95.ColumnName = "ProbationReason_Id"
            columnExpression95.Table = table7
            column93.Expression = columnExpression95
            columnExpression96.ColumnName = "FirstName"
            columnExpression96.Table = table7
            column94.Expression = columnExpression96
            columnExpression97.ColumnName = "LastName"
            columnExpression97.Table = table7
            column95.Expression = columnExpression97
            columnExpression98.ColumnName = "FullName"
            columnExpression98.Table = table7
            column96.Expression = columnExpression98
            columnExpression99.ColumnName = "Prefix"
            columnExpression99.Table = table7
            column97.Expression = columnExpression99
            columnExpression100.ColumnName = "HomePhone"
            columnExpression100.Table = table7
            column98.Expression = columnExpression100
            columnExpression101.ColumnName = "MobilePhone"
            columnExpression101.Table = table7
            column99.Expression = columnExpression101
            columnExpression102.ColumnName = "Email"
            columnExpression102.Table = table7
            column100.Expression = columnExpression102
            columnExpression103.ColumnName = "Skype"
            columnExpression103.Table = table7
            column101.Expression = columnExpression103
            columnExpression104.ColumnName = "BirthDate"
            columnExpression104.Table = table7
            column102.Expression = columnExpression104
            columnExpression105.ColumnName = "PictureId"
            columnExpression105.Table = table7
            column103.Expression = columnExpression105
            columnExpression106.ColumnName = "Address_Line"
            columnExpression106.Table = table7
            column104.Expression = columnExpression106
            columnExpression107.ColumnName = "Address_City"
            columnExpression107.Table = table7
            column105.Expression = columnExpression107
            columnExpression108.ColumnName = "Address_State"
            columnExpression108.Table = table7
            column106.Expression = columnExpression108
            columnExpression109.ColumnName = "Address_Latitude"
            columnExpression109.Table = table7
            column107.Expression = columnExpression109
            columnExpression110.ColumnName = "Address_Longitude"
            columnExpression110.Table = table7
            column108.Expression = columnExpression110
            columnExpression111.ColumnName = "Address_ZipCode"
            columnExpression111.Table = table7
            column109.Expression = columnExpression111
            columnExpression112.ColumnName = "AddressLine"
            columnExpression112.Table = table7
            column110.Expression = columnExpression112
            columnExpression113.ColumnName = "AddressCity"
            columnExpression113.Table = table7
            column111.Expression = columnExpression113
            columnExpression114.ColumnName = "AddressZipCode"
            columnExpression114.Table = table7
            column112.Expression = columnExpression114
            columnExpression115.ColumnName = "AddressState"
            columnExpression115.Table = table7
            column113.Expression = columnExpression115
            columnExpression116.ColumnName = "AddressLatitude"
            columnExpression116.Table = table7
            column114.Expression = columnExpression116
            columnExpression117.ColumnName = "AddressLongitude"
            columnExpression117.Table = table7
            column115.Expression = columnExpression117
            selectQuery6.Columns.Add(column87)
            selectQuery6.Columns.Add(column88)
            selectQuery6.Columns.Add(column89)
            selectQuery6.Columns.Add(column90)
            selectQuery6.Columns.Add(column91)
            selectQuery6.Columns.Add(column92)
            selectQuery6.Columns.Add(column93)
            selectQuery6.Columns.Add(column94)
            selectQuery6.Columns.Add(column95)
            selectQuery6.Columns.Add(column96)
            selectQuery6.Columns.Add(column97)
            selectQuery6.Columns.Add(column98)
            selectQuery6.Columns.Add(column99)
            selectQuery6.Columns.Add(column100)
            selectQuery6.Columns.Add(column101)
            selectQuery6.Columns.Add(column102)
            selectQuery6.Columns.Add(column103)
            selectQuery6.Columns.Add(column104)
            selectQuery6.Columns.Add(column105)
            selectQuery6.Columns.Add(column106)
            selectQuery6.Columns.Add(column107)
            selectQuery6.Columns.Add(column108)
            selectQuery6.Columns.Add(column109)
            selectQuery6.Columns.Add(column110)
            selectQuery6.Columns.Add(column111)
            selectQuery6.Columns.Add(column112)
            selectQuery6.Columns.Add(column113)
            selectQuery6.Columns.Add(column114)
            selectQuery6.Columns.Add(column115)
            selectQuery6.MetaSerializable = "<Meta X=""610"" Y=""20"" Width=""141"" Height=""530"" />"
            selectQuery6.Name = "DataEmployees"
            selectQuery6.Tables.Add(table7)
            columnExpression118.ColumnName = "Id"
            table8.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""419"" />"
            table8.Name = "Products"
            columnExpression118.Table = table8
            column116.Expression = columnExpression118
            columnExpression119.ColumnName = "Name"
            columnExpression119.Table = table8
            column117.Expression = columnExpression119
            columnExpression120.ColumnName = "Description"
            columnExpression120.Table = table8
            column118.Expression = columnExpression120
            columnExpression121.ColumnName = "ProductionStart"
            columnExpression121.Table = table8
            column119.Expression = columnExpression121
            columnExpression122.ColumnName = "Available"
            columnExpression122.Table = table8
            column120.Expression = columnExpression122
            columnExpression123.ColumnName = "Image"
            columnExpression123.Table = table8
            column121.Expression = columnExpression123
            columnExpression124.ColumnName = "SupportId"
            columnExpression124.Table = table8
            column122.Expression = columnExpression124
            columnExpression125.ColumnName = "EngineerId"
            columnExpression125.Table = table8
            column123.Expression = columnExpression125
            columnExpression126.ColumnName = "CurrentInventory"
            columnExpression126.Table = table8
            column124.Expression = columnExpression126
            columnExpression127.ColumnName = "Backorder"
            columnExpression127.Table = table8
            column125.Expression = columnExpression127
            columnExpression128.ColumnName = "Manufacturing"
            columnExpression128.Table = table8
            column126.Expression = columnExpression128
            columnExpression129.ColumnName = "Barcode"
            columnExpression129.Table = table8
            column127.Expression = columnExpression129
            columnExpression130.ColumnName = "PrimaryImageId"
            columnExpression130.Table = table8
            column128.Expression = columnExpression130
            columnExpression131.ColumnName = "Cost"
            columnExpression131.Table = table8
            column129.Expression = columnExpression131
            columnExpression132.ColumnName = "SalePrice"
            columnExpression132.Table = table8
            column130.Expression = columnExpression132
            columnExpression133.ColumnName = "RetailPrice"
            columnExpression133.Table = table8
            column131.Expression = columnExpression133
            columnExpression134.ColumnName = "Weight"
            columnExpression134.Table = table8
            column132.Expression = columnExpression134
            columnExpression135.ColumnName = "ConsumerRating"
            columnExpression135.Table = table8
            column133.Expression = columnExpression135
            columnExpression136.ColumnName = "Category"
            columnExpression136.Table = table8
            column134.Expression = columnExpression136
            columnExpression137.ColumnName = "PDF"
            table9.MetaSerializable = "<Meta X=""190"" Y=""40"" Width=""125"" Height=""115"" />"
            table9.Name = "ProductCatalogs"
            columnExpression137.Table = table9
            column135.Expression = columnExpression137
            selectQuery7.Columns.Add(column116)
            selectQuery7.Columns.Add(column117)
            selectQuery7.Columns.Add(column118)
            selectQuery7.Columns.Add(column119)
            selectQuery7.Columns.Add(column120)
            selectQuery7.Columns.Add(column121)
            selectQuery7.Columns.Add(column122)
            selectQuery7.Columns.Add(column123)
            selectQuery7.Columns.Add(column124)
            selectQuery7.Columns.Add(column125)
            selectQuery7.Columns.Add(column126)
            selectQuery7.Columns.Add(column127)
            selectQuery7.Columns.Add(column128)
            selectQuery7.Columns.Add(column129)
            selectQuery7.Columns.Add(column130)
            selectQuery7.Columns.Add(column131)
            selectQuery7.Columns.Add(column132)
            selectQuery7.Columns.Add(column133)
            selectQuery7.Columns.Add(column134)
            selectQuery7.Columns.Add(column135)
            selectQuery7.MetaSerializable = "<Meta X=""960"" Y=""410"" Width=""125"" Height=""360"" />"
            selectQuery7.Name = "Products"
            relationColumnInfo2.NestedKeyColumn = "ProductId"
            relationColumnInfo2.ParentKeyColumn = "Id"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table9
            join2.Parent = table8
            selectQuery7.Relations.Add(join2)
            selectQuery7.Tables.Add(table8)
            selectQuery7.Tables.Add(table9)
            reportSqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery2, selectQuery3, selectQuery4, selectQuery5, selectQuery6, selectQuery7})
            masterDetailInfo1.DetailQueryName = "Customers"
            relationColumnInfo3.NestedKeyColumn = "Id"
            relationColumnInfo3.ParentKeyColumn = "CustomerId"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Orders"
            masterDetailInfo1.Name = "Customer"
            masterDetailInfo2.DetailQueryName = "OrderItems"
            relationColumnInfo4.NestedKeyColumn = "OrderId"
            relationColumnInfo4.ParentKeyColumn = "Id"
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo4)
            masterDetailInfo2.MasterQueryName = "Orders"
            masterDetailInfo2.Name = "OrderItems"
            masterDetailInfo3.DetailQueryName = "CustomerStores"
            relationColumnInfo5.NestedKeyColumn = "Id"
            relationColumnInfo5.ParentKeyColumn = "StoreId"
            masterDetailInfo3.KeyColumns.Add(relationColumnInfo5)
            masterDetailInfo3.MasterQueryName = "Orders"
            masterDetailInfo3.Name = "Store"
            masterDetailInfo4.DetailQueryName = "DataEmployees"
            relationColumnInfo6.NestedKeyColumn = "Id"
            relationColumnInfo6.ParentKeyColumn = "EmployeeId"
            masterDetailInfo4.KeyColumns.Add(relationColumnInfo6)
            masterDetailInfo4.MasterQueryName = "Orders"
            masterDetailInfo4.Name = "Employee"
            masterDetailInfo5.DetailQueryName = "ProductCatalogs"
            relationColumnInfo7.NestedKeyColumn = "ProductId"
            relationColumnInfo7.ParentKeyColumn = "Id"
            masterDetailInfo5.KeyColumns.Add(relationColumnInfo7)
            masterDetailInfo5.MasterQueryName = "Products"
            masterDetailInfo5.Name = "Catalog"
            masterDetailInfo6.DetailQueryName = "Products"
            relationColumnInfo8.NestedKeyColumn = "Id"
            relationColumnInfo8.ParentKeyColumn = "ProductId"
            masterDetailInfo6.KeyColumns.Add(relationColumnInfo8)
            masterDetailInfo6.MasterQueryName = "OrderItems"
            reportSqlDataSource.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1, masterDetailInfo2, masterDetailInfo3, masterDetailInfo4, masterDetailInfo5, masterDetailInfo6})
            reportSqlDataSource.ResultSchemaSerializable = resources.GetString("reportSqlDataSource.ResultSchemaSerializable")
            ' 
            ' DetailReport1
            ' 
            DetailReport1.Bands.AddRange(New Band() {Detail1, DetailReport2})
            DetailReport1.DataMember = "Orders"
            DetailReport1.DataSource = reportSqlDataSource
            DetailReport1.Dpi = 96F
            DetailReport1.Level = 1
            DetailReport1.Name = "DetailReport1"
            ' 
            ' Detail1
            ' 
            Detail1.Dpi = 96F
            Detail1.HeightF = 0F
            Detail1.HierarchyPrintOptions.Indent = 19.2F
            Detail1.Name = "Detail1"
            ' 
            ' DetailReport2
            ' 
            DetailReport2.Bands.AddRange(New Band() {Detail2})
            DetailReport2.DataMember = "Orders.OrderItems"
            DetailReport2.DataSource = reportSqlDataSource
            DetailReport2.Dpi = 96F
            DetailReport2.Level = 0
            DetailReport2.Name = "DetailReport2"
            ' 
            ' Detail2
            ' 
            Detail2.Controls.AddRange(New XRControl() {xrPdfContent1})
            Detail2.Dpi = 96F
            Detail2.HeightF = 22.08F
            Detail2.HierarchyPrintOptions.Indent = 19.2F
            Detail2.Name = "Detail2"
            ' 
            ' xrPdfContent1
            ' 
            xrPdfContent1.Dpi = 96F
            xrPdfContent1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Source", "[OrderItemsProducts].[PDF]")})
            xrPdfContent1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            xrPdfContent1.Name = "xrPdfContent1"
            xrPdfContent1.SizeF = New System.Drawing.SizeF(717F, 22.08F)
            ' 
            ' HeaderStyle
            ' 
            HeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 26F, DevExpress.Drawing.DXFontStyle.Bold)
            HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86)
            HeaderStyle.Name = "HeaderStyle"
            HeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' General
            ' 
            General.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            General.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86)
            General.Name = "General"
            General.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            ' 
            ' Comments
            ' 
            Comments.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Comments.ForeColor = System.Drawing.Color.FromArgb(167, 174, 187)
            Comments.Name = "Comments"
            ' 
            ' BillingShippingHeaderStyle
            ' 
            BillingShippingHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            BillingShippingHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(167, 174, 187)
            BillingShippingHeaderStyle.Name = "BillingShippingHeaderStyle"
            ' 
            ' TableHeaderStyle
            ' 
            TableHeaderStyle.BackColor = System.Drawing.Color.Transparent
            TableHeaderStyle.BorderColor = System.Drawing.Color.FromArgb(92, 100, 118)
            TableHeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            TableHeaderStyle.BorderWidth = 2F
            TableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(92, 100, 118)
            TableHeaderStyle.Name = "TableHeaderStyle"
            ' 
            ' DetailTableHeaderStyle
            ' 
            DetailTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb(92, 100, 118)
            DetailTableHeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right
            DetailTableHeaderStyle.BorderWidth = 0F
            DetailTableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold)
            DetailTableHeaderStyle.ForeColor = System.Drawing.Color.White
            DetailTableHeaderStyle.Name = "DetailTableHeaderStyle"
            ' 
            ' TableOddStyle
            ' 
            TableOddStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            TableOddStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            TableOddStyle.BorderWidth = 1F
            TableOddStyle.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            TableOddStyle.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86)
            TableOddStyle.Name = "TableOddStyle"
            TableOddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            TableOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
            ' 
            ' HomeOffice_StateName
            ' 
            HomeOffice_StateName.DataMember = "Orders.Customer"
            HomeOffice_StateName.Expression = resources.GetString("HomeOffice_StateName.Expression")
            HomeOffice_StateName.FieldType = FieldType.String
            HomeOffice_StateName.Name = "HomeOffice_StateName"
            ' 
            ' Address_StateName
            ' 
            Address_StateName.DataMember = "Orders.Store"
            Address_StateName.Expression = resources.GetString("Address_StateName.Expression")
            Address_StateName.Name = "Address_StateName"
            ' 
            ' paramShowHeader
            ' 
            paramShowHeader.Description = "ParamShowHeader"
            paramShowHeader.Name = "paramShowHeader"
            paramShowHeader.Type = GetType(Boolean)
            paramShowHeader.ValueInfo = "True"
            paramShowHeader.Visible = False
            ' 
            ' paramShowFooter
            ' 
            paramShowFooter.Description = "Show Footer"
            paramShowFooter.Name = "paramShowFooter"
            paramShowFooter.Type = GetType(Boolean)
            paramShowFooter.ValueInfo = "True"
            paramShowFooter.Visible = False
            ' 
            ' paramShowStatus
            ' 
            paramShowStatus.Description = "Show Status"
            paramShowStatus.Name = "paramShowStatus"
            paramShowStatus.Type = GetType(Boolean)
            paramShowStatus.ValueInfo = "True"
            paramShowStatus.Visible = False
            ' 
            ' paramShowComments
            ' 
            paramShowComments.Description = "Show Comments"
            paramShowComments.Name = "paramShowComments"
            paramShowComments.Type = GetType(Boolean)
            paramShowComments.ValueInfo = "True"
            paramShowComments.Visible = False
            ' 
            ' parameterInvoice
            ' 
            parameterInvoice.Description = "Invoice Number"
            parameterInvoice.Name = "parameterInvoice"
            parameterInvoice.ValueInfo = "243817"
            dynamicListLookUpSettings1.DataMember = "Orders"
            dynamicListLookUpSettings1.DataSource = parameterSqlDataSource
            dynamicListLookUpSettings1.DisplayMember = Nothing
            dynamicListLookUpSettings1.SortMember = "OrderDate"
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            dynamicListLookUpSettings1.ValueMember = "InvoiceNumber"
            parameterInvoice.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' xrPdfSignature1
            ' 
            xrPdfSignature1.Dpi = 96F
            xrPdfSignature1.LocationFloat = New DevExpress.Utils.PointFloat(22.99512F, 43.75F)
            xrPdfSignature1.Name = "xrPdfSignature1"
            xrPdfSignature1.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 96F)
            xrPdfSignature1.SizeF = New System.Drawing.SizeF(375.5455F, 92.60126F)
            ' 
            ' Report
            ' 
            Bands.AddRange(New Band() {topMarginBand1, detailBand1, bottomMarginBand1, OrdersDetailReport, DetailReport1})
            CalculatedFields.AddRange(New CalculatedField() {HomeOffice_StateName, Address_StateName})
            ComponentStorage.AddRange(New System.ComponentModel.IComponent() {reportSqlDataSource, parameterSqlDataSource})
            DataSource = reportSqlDataSource
            DisplayName = "Report Merging with PDF"
            Dpi = 96F
            DrawWatermark = True
            Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Margins = New DevExpress.Drawing.DXMargins(56, 43, 46, 60)
            PageHeight = 1056
            PageWidth = 816
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {paramShowHeader, paramShowFooter, paramShowStatus, paramShowComments, parameterInvoice})
            ReportUnit = ReportUnit.Pixels
            RequestParameters = False
            SnapGridSize = 12.5F
            StyleSheet.AddRange(New XRControlStyle() {HeaderStyle, General, Comments, BillingShippingHeaderStyle, TableHeaderStyle, DetailTableHeaderStyle, TableOddStyle})
            Version = "20.2"
            CType(xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
