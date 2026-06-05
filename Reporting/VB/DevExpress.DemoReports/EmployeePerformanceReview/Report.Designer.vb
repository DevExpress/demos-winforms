Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.EmployeePerformanceReview

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.EmployeePerformanceReview.Report))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox3 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox4 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox5 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox6 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox18 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox65 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox64 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox63 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox7 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox19 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox60 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox61 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox62 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox8 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox20 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox59 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox58 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox57 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox9 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox21 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox54 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox55 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox56 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox10 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox22 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox53 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox52 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox51 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox11 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox23 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox48 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox49 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox50 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox12 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox24 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox47 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox46 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox45 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox13 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox25 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox42 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox43 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox44 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox14 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox26 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox41 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox40 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox39 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox16 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox28 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox35 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox34 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox33 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox15 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox27 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox36 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox37 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox38 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox17 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox29 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox30 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox31 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox32 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow31 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow30 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.startPeriod = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.endPeriod = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.LightHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.LargeHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle5 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle4 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle5 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle4 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 50F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1, Me.table4})
            Me.Detail.HeightF = 560.514F
            Me.Detail.Name = "Detail"
            ' 
            ' table1
            ' 
            Me.table1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(649.9998F, 40F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell6, Me.tableCell5, Me.tableCell4})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.StyleName = "LargeHeaderStyle"
            Me.tableRow1.Weight = 1.1428575165418953R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StylePriority.UseFont = False
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            Me.tableCell1.Text = "Evaluation"
            Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell1.Weight = 1.7307695113504025R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.Text = "5"
            Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell2.Weight = 0.25384664000396051R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StylePriority.UseFont = False
            Me.tableCell3.StylePriority.UsePadding = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "4"
            Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell3.Weight = 0.25384607660235947R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StylePriority.UseFont = False
            Me.tableCell6.StylePriority.UsePadding = False
            Me.tableCell6.StylePriority.UseTextAlignment = False
            Me.tableCell6.Text = "3"
            Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell6.Weight = 0.25384607660235947R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Multiline = True
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StylePriority.UseFont = False
            Me.tableCell5.StylePriority.UsePadding = False
            Me.tableCell5.StylePriority.UseTextAlignment = False
            Me.tableCell5.Text = "2"
            Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell5.Weight = 0.2538462174527597R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StylePriority.UseFont = False
            Me.tableCell4.StylePriority.UsePadding = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "1"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.tableCell4.Weight = 0.25384547798815843R
            ' 
            ' table4
            ' 
            Me.table4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.table4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 39.99999F)
            Me.table4.Name = "table4"
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow10, Me.tableRow11, Me.tableRow12, Me.tableRow13, Me.tableRow14, Me.tableRow15, Me.tableRow16, Me.tableRow17, Me.tableRow18, Me.tableRow19, Me.tableRow21, Me.tableRow20, Me.tableRow22})
            Me.table4.SizeF = New System.Drawing.SizeF(650F, 520.514F)
            Me.table4.StylePriority.UseBorders = False
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell35, Me.tableCell36, Me.tableCell37, Me.tableCell38, Me.tableCell40, Me.tableCell39})
            Me.tableRow10.Name = "tableRow10"
            Me.tableRow10.StylePriority.UseBackColor = False
            Me.tableRow10.Weight = 0.075947049340318332R
            ' 
            ' tableCell35
            ' 
            Me.tableCell35.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell35.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell35.Multiline = True
            Me.tableCell35.Name = "tableCell35"
            Me.tableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell35.StylePriority.UseFont = False
            Me.tableCell35.StylePriority.UseForeColor = False
            Me.tableCell35.StylePriority.UsePadding = False
            Me.tableCell35.StylePriority.UseTextAlignment = False
            Me.tableCell35.Text = "Demonstrates essential job skills and knowledge"
            Me.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell35.Weight = 3.1560162582150939R
            ' 
            ' tableCell36
            ' 
            Me.tableCell36.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox1})
            Me.tableCell36.Multiline = True
            Me.tableCell36.Name = "tableCell36"
            Me.tableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell36.StylePriority.UseBackColor = False
            Me.tableCell36.Text = " "
            Me.tableCell36.Weight = 0.46288237121501008R
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.checkBox1.EditOptions.Enabled = True
            Me.checkBox1.EditOptions.GroupID = "1"
            Me.checkBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox1.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox1.StyleName = "OddStyle5"
            Me.checkBox1.StylePriority.UseBorders = False
            ' 
            ' tableCell37
            ' 
            Me.tableCell37.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox2})
            Me.tableCell37.Multiline = True
            Me.tableCell37.Name = "tableCell37"
            Me.tableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell37.StylePriority.UseBackColor = False
            Me.tableCell37.Text = " "
            Me.tableCell37.Weight = 0.46288238823868011R
            ' 
            ' checkBox2
            ' 
            Me.checkBox2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox2.EditOptions.Enabled = True
            Me.checkBox2.EditOptions.GroupID = "1"
            Me.checkBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox2.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox2.StyleName = "OddStyle4"
            ' 
            ' tableCell38
            ' 
            Me.tableCell38.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox3})
            Me.tableCell38.Multiline = True
            Me.tableCell38.Name = "tableCell38"
            Me.tableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell38.StylePriority.UseBackColor = False
            Me.tableCell38.StylePriority.UsePadding = False
            Me.tableCell38.Text = " "
            Me.tableCell38.Weight = 0.46288238823868016R
            ' 
            ' checkBox3
            ' 
            Me.checkBox3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox3.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox3.EditOptions.Enabled = True
            Me.checkBox3.EditOptions.GroupID = "1"
            Me.checkBox3.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox3.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox3.StyleName = "OddStyle3"
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox4})
            Me.tableCell40.Multiline = True
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell40.StylePriority.UseBackColor = False
            Me.tableCell40.StylePriority.UsePadding = False
            Me.tableCell40.Text = " "
            Me.tableCell40.Weight = 0.46288236406936523R
            ' 
            ' checkBox4
            ' 
            Me.checkBox4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox4.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox4.EditOptions.Enabled = True
            Me.checkBox4.EditOptions.GroupID = "1"
            Me.checkBox4.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox4.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox4.StyleName = "OddStyle2"
            ' 
            ' tableCell39
            ' 
            Me.tableCell39.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox5})
            Me.tableCell39.Multiline = True
            Me.tableCell39.Name = "tableCell39"
            Me.tableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell39.StylePriority.UseBackColor = False
            Me.tableCell39.StylePriority.UsePadding = False
            Me.tableCell39.Text = " "
            Me.tableCell39.Weight = 0.46288233911035281R
            ' 
            ' checkBox5
            ' 
            Me.checkBox5.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox5.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox5.EditOptions.Enabled = True
            Me.checkBox5.EditOptions.GroupID = "1"
            Me.checkBox5.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox5.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox5.StyleName = "OddStyle1"
            ' 
            ' tableRow11
            ' 
            Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell41, Me.tableCell42, Me.tableCell43, Me.tableCell44, Me.tableCell45, Me.tableCell46})
            Me.tableRow11.Name = "tableRow11"
            Me.tableRow11.Weight = 0.076923070237346111R
            ' 
            ' tableCell41
            ' 
            Me.tableCell41.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell41.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell41.Multiline = True
            Me.tableCell41.Name = "tableCell41"
            Me.tableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell41.StylePriority.UseFont = False
            Me.tableCell41.StylePriority.UseForeColor = False
            Me.tableCell41.StylePriority.UsePadding = False
            Me.tableCell41.StylePriority.UseTextAlignment = False
            Me.tableCell41.Text = "Has the ability to learn and use new skills"
            Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell41.Weight = 3.1560162582150939R
            ' 
            ' tableCell42
            ' 
            Me.tableCell42.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox6})
            Me.tableCell42.Multiline = True
            Me.tableCell42.Name = "tableCell42"
            Me.tableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell42.StylePriority.UseBackColor = False
            Me.tableCell42.StylePriority.UsePadding = False
            Me.tableCell42.Text = " "
            Me.tableCell42.Weight = 0.46288237121501008R
            ' 
            ' checkBox6
            ' 
            Me.checkBox6.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox6.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox6.EditOptions.Enabled = True
            Me.checkBox6.EditOptions.GroupID = "2"
            Me.checkBox6.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 7.629395E-06F)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox6.SizeF = New System.Drawing.SizeF(55.00004F, 40.51406F)
            Me.checkBox6.StyleName = "EvenStyle5"
            ' 
            ' tableCell43
            ' 
            Me.tableCell43.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox18})
            Me.tableCell43.Multiline = True
            Me.tableCell43.Name = "tableCell43"
            Me.tableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell43.StylePriority.UseBackColor = False
            Me.tableCell43.StylePriority.UsePadding = False
            Me.tableCell43.Text = " "
            Me.tableCell43.Weight = 0.46288238823868011R
            ' 
            ' checkBox18
            ' 
            Me.checkBox18.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox18.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox18.EditOptions.Enabled = True
            Me.checkBox18.EditOptions.GroupID = "2"
            Me.checkBox18.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox18.LocationFloat = New DevExpress.Utils.PointFloat(0F, 7.629395E-06F)
            Me.checkBox18.Name = "checkBox18"
            Me.checkBox18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox18.SizeF = New System.Drawing.SizeF(55.00004F, 40.51406F)
            Me.checkBox18.StyleName = "EvenStyle4"
            ' 
            ' tableCell44
            ' 
            Me.tableCell44.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox65})
            Me.tableCell44.Multiline = True
            Me.tableCell44.Name = "tableCell44"
            Me.tableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell44.StylePriority.UseBackColor = False
            Me.tableCell44.StylePriority.UsePadding = False
            Me.tableCell44.Text = " "
            Me.tableCell44.Weight = 0.46288238823868016R
            ' 
            ' checkBox65
            ' 
            Me.checkBox65.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox65.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox65.EditOptions.Enabled = True
            Me.checkBox65.EditOptions.GroupID = "2"
            Me.checkBox65.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox65.LocationFloat = New DevExpress.Utils.PointFloat(3.051758E-05F, 7.629395E-06F)
            Me.checkBox65.Name = "checkBox65"
            Me.checkBox65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox65.SizeF = New System.Drawing.SizeF(54.99995F, 40.51406F)
            Me.checkBox65.StyleName = "EvenStyle3"
            ' 
            ' tableCell45
            ' 
            Me.tableCell45.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox64})
            Me.tableCell45.Multiline = True
            Me.tableCell45.Name = "tableCell45"
            Me.tableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell45.StylePriority.UseBackColor = False
            Me.tableCell45.StylePriority.UsePadding = False
            Me.tableCell45.Text = " "
            Me.tableCell45.Weight = 0.46288236406936523R
            ' 
            ' checkBox64
            ' 
            Me.checkBox64.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox64.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox64.EditOptions.Enabled = True
            Me.checkBox64.EditOptions.GroupID = "2"
            Me.checkBox64.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox64.LocationFloat = New DevExpress.Utils.PointFloat(0F, 7.629395E-06F)
            Me.checkBox64.Name = "checkBox64"
            Me.checkBox64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox64.SizeF = New System.Drawing.SizeF(55.00001F, 40.51406F)
            Me.checkBox64.StyleName = "EvenStyle2"
            ' 
            ' tableCell46
            ' 
            Me.tableCell46.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox63})
            Me.tableCell46.Multiline = True
            Me.tableCell46.Name = "tableCell46"
            Me.tableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell46.StylePriority.UseBackColor = False
            Me.tableCell46.StylePriority.UsePadding = False
            Me.tableCell46.Text = " "
            Me.tableCell46.Weight = 0.46288233911035281R
            ' 
            ' checkBox63
            ' 
            Me.checkBox63.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox63.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox63.EditOptions.Enabled = True
            Me.checkBox63.EditOptions.GroupID = "2"
            Me.checkBox63.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox63.LocationFloat = New DevExpress.Utils.PointFloat(0F, 7.629395E-06F)
            Me.checkBox63.Name = "checkBox63"
            Me.checkBox63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox63.SizeF = New System.Drawing.SizeF(55.00012F, 40.51406F)
            Me.checkBox63.StyleName = "EvenStyle1"
            ' 
            ' tableRow12
            ' 
            Me.tableRow12.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell47, Me.tableCell48, Me.tableCell49, Me.tableCell50, Me.tableCell51, Me.tableCell52})
            Me.tableRow12.Name = "tableRow12"
            Me.tableRow12.StylePriority.UseBackColor = False
            Me.tableRow12.Weight = 0.075947049340318318R
            ' 
            ' tableCell47
            ' 
            Me.tableCell47.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell47.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell47.Multiline = True
            Me.tableCell47.Name = "tableCell47"
            Me.tableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell47.StylePriority.UseFont = False
            Me.tableCell47.StylePriority.UseForeColor = False
            Me.tableCell47.StylePriority.UsePadding = False
            Me.tableCell47.StylePriority.UseTextAlignment = False
            Me.tableCell47.Text = "Uses resources effectively"
            Me.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell47.Weight = 3.1560162582150939R
            ' 
            ' tableCell48
            ' 
            Me.tableCell48.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox7})
            Me.tableCell48.Multiline = True
            Me.tableCell48.Name = "tableCell48"
            Me.tableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell48.StylePriority.UseBackColor = False
            Me.tableCell48.StylePriority.UsePadding = False
            Me.tableCell48.Text = " "
            Me.tableCell48.Weight = 0.46288237121501008R
            ' 
            ' checkBox7
            ' 
            Me.checkBox7.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox7.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox7.EditOptions.Enabled = True
            Me.checkBox7.EditOptions.GroupID = "3"
            Me.checkBox7.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox7.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox7.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox7.StyleName = "OddStyle5"
            ' 
            ' tableCell49
            ' 
            Me.tableCell49.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox19})
            Me.tableCell49.Multiline = True
            Me.tableCell49.Name = "tableCell49"
            Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell49.StylePriority.UseBackColor = False
            Me.tableCell49.StylePriority.UsePadding = False
            Me.tableCell49.Text = " "
            Me.tableCell49.Weight = 0.46288238823868011R
            ' 
            ' checkBox19
            ' 
            Me.checkBox19.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox19.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox19.EditOptions.Enabled = True
            Me.checkBox19.EditOptions.GroupID = "3"
            Me.checkBox19.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox19.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox19.Name = "checkBox19"
            Me.checkBox19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox19.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox19.StyleName = "OddStyle4"
            ' 
            ' tableCell50
            ' 
            Me.tableCell50.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox60})
            Me.tableCell50.Multiline = True
            Me.tableCell50.Name = "tableCell50"
            Me.tableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell50.StylePriority.UseBackColor = False
            Me.tableCell50.StylePriority.UsePadding = False
            Me.tableCell50.Text = " "
            Me.tableCell50.Weight = 0.46288238823868016R
            ' 
            ' checkBox60
            ' 
            Me.checkBox60.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox60.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox60.EditOptions.Enabled = True
            Me.checkBox60.EditOptions.GroupID = "3"
            Me.checkBox60.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox60.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox60.Name = "checkBox60"
            Me.checkBox60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox60.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox60.StyleName = "OddStyle3"
            ' 
            ' tableCell51
            ' 
            Me.tableCell51.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox61})
            Me.tableCell51.Multiline = True
            Me.tableCell51.Name = "tableCell51"
            Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell51.StylePriority.UseBackColor = False
            Me.tableCell51.StylePriority.UsePadding = False
            Me.tableCell51.Text = " "
            Me.tableCell51.Weight = 0.46288236406936523R
            ' 
            ' checkBox61
            ' 
            Me.checkBox61.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox61.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox61.EditOptions.Enabled = True
            Me.checkBox61.EditOptions.GroupID = "3"
            Me.checkBox61.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox61.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox61.Name = "checkBox61"
            Me.checkBox61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox61.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox61.StyleName = "OddStyle2"
            ' 
            ' tableCell52
            ' 
            Me.tableCell52.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox62})
            Me.tableCell52.Multiline = True
            Me.tableCell52.Name = "tableCell52"
            Me.tableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell52.StylePriority.UseBackColor = False
            Me.tableCell52.StylePriority.UsePadding = False
            Me.tableCell52.Text = " "
            Me.tableCell52.Weight = 0.46288233911035281R
            ' 
            ' checkBox62
            ' 
            Me.checkBox62.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox62.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox62.EditOptions.Enabled = True
            Me.checkBox62.EditOptions.GroupID = "3"
            Me.checkBox62.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox62.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox62.Name = "checkBox62"
            Me.checkBox62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox62.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox62.StyleName = "OddStyle1"
            ' 
            ' tableRow13
            ' 
            Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell53, Me.tableCell54, Me.tableCell55, Me.tableCell56, Me.tableCell57, Me.tableCell58})
            Me.tableRow13.Name = "tableRow13"
            Me.tableRow13.Weight = 0.075947049340318332R
            ' 
            ' tableCell53
            ' 
            Me.tableCell53.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell53.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell53.Multiline = True
            Me.tableCell53.Name = "tableCell53"
            Me.tableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell53.StylePriority.UseFont = False
            Me.tableCell53.StylePriority.UseForeColor = False
            Me.tableCell53.StylePriority.UsePadding = False
            Me.tableCell53.StylePriority.UseTextAlignment = False
            Me.tableCell53.Text = "Fulfills assigned responsibilities"
            Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell53.Weight = 3.1560162582150939R
            ' 
            ' tableCell54
            ' 
            Me.tableCell54.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox8})
            Me.tableCell54.Multiline = True
            Me.tableCell54.Name = "tableCell54"
            Me.tableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell54.StylePriority.UseBackColor = False
            Me.tableCell54.StylePriority.UsePadding = False
            Me.tableCell54.Text = " "
            Me.tableCell54.Weight = 0.46288237121501008R
            ' 
            ' checkBox8
            ' 
            Me.checkBox8.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox8.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox8.EditOptions.Enabled = True
            Me.checkBox8.EditOptions.GroupID = "4"
            Me.checkBox8.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox8.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox8.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox8.StyleName = "EvenStyle5"
            ' 
            ' tableCell55
            ' 
            Me.tableCell55.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox20})
            Me.tableCell55.Multiline = True
            Me.tableCell55.Name = "tableCell55"
            Me.tableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell55.StylePriority.UseBackColor = False
            Me.tableCell55.StylePriority.UsePadding = False
            Me.tableCell55.Text = " "
            Me.tableCell55.Weight = 0.46288238823868011R
            ' 
            ' checkBox20
            ' 
            Me.checkBox20.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox20.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox20.EditOptions.Enabled = True
            Me.checkBox20.EditOptions.GroupID = "4"
            Me.checkBox20.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox20.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox20.Name = "checkBox20"
            Me.checkBox20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox20.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox20.StyleName = "EvenStyle4"
            ' 
            ' tableCell56
            ' 
            Me.tableCell56.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox59})
            Me.tableCell56.Multiline = True
            Me.tableCell56.Name = "tableCell56"
            Me.tableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell56.StylePriority.UseBackColor = False
            Me.tableCell56.StylePriority.UsePadding = False
            Me.tableCell56.Text = " "
            Me.tableCell56.Weight = 0.46288238823868016R
            ' 
            ' checkBox59
            ' 
            Me.checkBox59.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox59.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox59.EditOptions.Enabled = True
            Me.checkBox59.EditOptions.GroupID = "4"
            Me.checkBox59.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox59.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox59.Name = "checkBox59"
            Me.checkBox59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox59.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox59.StyleName = "EvenStyle3"
            ' 
            ' tableCell57
            ' 
            Me.tableCell57.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox58})
            Me.tableCell57.Multiline = True
            Me.tableCell57.Name = "tableCell57"
            Me.tableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell57.StylePriority.UseBackColor = False
            Me.tableCell57.StylePriority.UsePadding = False
            Me.tableCell57.Text = " "
            Me.tableCell57.Weight = 0.46288236406936523R
            ' 
            ' checkBox58
            ' 
            Me.checkBox58.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox58.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox58.EditOptions.Enabled = True
            Me.checkBox58.EditOptions.GroupID = "4"
            Me.checkBox58.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox58.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox58.Name = "checkBox58"
            Me.checkBox58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox58.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox58.StyleName = "EvenStyle2"
            ' 
            ' tableCell58
            ' 
            Me.tableCell58.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox57})
            Me.tableCell58.Multiline = True
            Me.tableCell58.Name = "tableCell58"
            Me.tableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell58.StylePriority.UseBackColor = False
            Me.tableCell58.StylePriority.UsePadding = False
            Me.tableCell58.Text = " "
            Me.tableCell58.Weight = 0.46288233911035281R
            ' 
            ' checkBox57
            ' 
            Me.checkBox57.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox57.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox57.EditOptions.Enabled = True
            Me.checkBox57.EditOptions.GroupID = "4"
            Me.checkBox57.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox57.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox57.Name = "checkBox57"
            Me.checkBox57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox57.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox57.StyleName = "EvenStyle1"
            ' 
            ' tableRow14
            ' 
            Me.tableRow14.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell59, Me.tableCell60, Me.tableCell61, Me.tableCell62, Me.tableCell63, Me.tableCell64})
            Me.tableRow14.Name = "tableRow14"
            Me.tableRow14.StylePriority.UseBackColor = False
            Me.tableRow14.Weight = 0.075947049340318332R
            ' 
            ' tableCell59
            ' 
            Me.tableCell59.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell59.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell59.Multiline = True
            Me.tableCell59.Name = "tableCell59"
            Me.tableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell59.StylePriority.UseFont = False
            Me.tableCell59.StylePriority.UseForeColor = False
            Me.tableCell59.StylePriority.UsePadding = False
            Me.tableCell59.StylePriority.UseTextAlignment = False
            Me.tableCell59.Text = "Meets attendance requirements"
            Me.tableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell59.Weight = 3.1560162582150939R
            ' 
            ' tableCell60
            ' 
            Me.tableCell60.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox9})
            Me.tableCell60.Multiline = True
            Me.tableCell60.Name = "tableCell60"
            Me.tableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell60.StylePriority.UseBackColor = False
            Me.tableCell60.StylePriority.UsePadding = False
            Me.tableCell60.Text = " "
            Me.tableCell60.Weight = 0.46288237121501008R
            ' 
            ' checkBox9
            ' 
            Me.checkBox9.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox9.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox9.EditOptions.Enabled = True
            Me.checkBox9.EditOptions.GroupID = "5"
            Me.checkBox9.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox9.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox9.Name = "checkBox9"
            Me.checkBox9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox9.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox9.StyleName = "OddStyle5"
            ' 
            ' tableCell61
            ' 
            Me.tableCell61.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox21})
            Me.tableCell61.Multiline = True
            Me.tableCell61.Name = "tableCell61"
            Me.tableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell61.StylePriority.UseBackColor = False
            Me.tableCell61.StylePriority.UsePadding = False
            Me.tableCell61.Text = " "
            Me.tableCell61.Weight = 0.46288238823868011R
            ' 
            ' checkBox21
            ' 
            Me.checkBox21.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox21.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox21.EditOptions.Enabled = True
            Me.checkBox21.EditOptions.GroupID = "5"
            Me.checkBox21.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox21.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox21.Name = "checkBox21"
            Me.checkBox21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox21.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox21.StyleName = "OddStyle4"
            ' 
            ' tableCell62
            ' 
            Me.tableCell62.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox54})
            Me.tableCell62.Multiline = True
            Me.tableCell62.Name = "tableCell62"
            Me.tableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell62.StylePriority.UseBackColor = False
            Me.tableCell62.StylePriority.UsePadding = False
            Me.tableCell62.Text = " "
            Me.tableCell62.Weight = 0.46288238823868016R
            ' 
            ' checkBox54
            ' 
            Me.checkBox54.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox54.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox54.EditOptions.Enabled = True
            Me.checkBox54.EditOptions.GroupID = "5"
            Me.checkBox54.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox54.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox54.Name = "checkBox54"
            Me.checkBox54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox54.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox54.StyleName = "OddStyle3"
            ' 
            ' tableCell63
            ' 
            Me.tableCell63.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox55})
            Me.tableCell63.Multiline = True
            Me.tableCell63.Name = "tableCell63"
            Me.tableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell63.StylePriority.UseBackColor = False
            Me.tableCell63.StylePriority.UsePadding = False
            Me.tableCell63.Text = " "
            Me.tableCell63.Weight = 0.46288236406936523R
            ' 
            ' checkBox55
            ' 
            Me.checkBox55.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox55.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox55.EditOptions.Enabled = True
            Me.checkBox55.EditOptions.GroupID = "5"
            Me.checkBox55.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox55.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox55.Name = "checkBox55"
            Me.checkBox55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox55.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox55.StyleName = "OddStyle2"
            ' 
            ' tableCell64
            ' 
            Me.tableCell64.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox56})
            Me.tableCell64.Multiline = True
            Me.tableCell64.Name = "tableCell64"
            Me.tableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell64.StylePriority.UseBackColor = False
            Me.tableCell64.StylePriority.UsePadding = False
            Me.tableCell64.Text = " "
            Me.tableCell64.Weight = 0.46288233911035281R
            ' 
            ' checkBox56
            ' 
            Me.checkBox56.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox56.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox56.EditOptions.Enabled = True
            Me.checkBox56.EditOptions.GroupID = "5"
            Me.checkBox56.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox56.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox56.Name = "checkBox56"
            Me.checkBox56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox56.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox56.StyleName = "OddStyle1"
            ' 
            ' tableRow15
            ' 
            Me.tableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell65, Me.tableCell66, Me.tableCell67, Me.tableCell68, Me.tableCell69, Me.tableCell70})
            Me.tableRow15.Name = "tableRow15"
            Me.tableRow15.Weight = 0.075947049340318318R
            ' 
            ' tableCell65
            ' 
            Me.tableCell65.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell65.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell65.Multiline = True
            Me.tableCell65.Name = "tableCell65"
            Me.tableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell65.StylePriority.UseFont = False
            Me.tableCell65.StylePriority.UseForeColor = False
            Me.tableCell65.StylePriority.UsePadding = False
            Me.tableCell65.StylePriority.UseTextAlignment = False
            Me.tableCell65.Text = "Responds to management direction"
            Me.tableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell65.Weight = 3.1560162582150939R
            ' 
            ' tableCell66
            ' 
            Me.tableCell66.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox10})
            Me.tableCell66.Multiline = True
            Me.tableCell66.Name = "tableCell66"
            Me.tableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell66.StylePriority.UseBackColor = False
            Me.tableCell66.StylePriority.UsePadding = False
            Me.tableCell66.Text = " "
            Me.tableCell66.Weight = 0.46288237121501008R
            ' 
            ' checkBox10
            ' 
            Me.checkBox10.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox10.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox10.EditOptions.Enabled = True
            Me.checkBox10.EditOptions.GroupID = "6"
            Me.checkBox10.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox10.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox10.Name = "checkBox10"
            Me.checkBox10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox10.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox10.StyleName = "EvenStyle5"
            ' 
            ' tableCell67
            ' 
            Me.tableCell67.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox22})
            Me.tableCell67.Multiline = True
            Me.tableCell67.Name = "tableCell67"
            Me.tableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell67.StylePriority.UseBackColor = False
            Me.tableCell67.StylePriority.UsePadding = False
            Me.tableCell67.Text = " "
            Me.tableCell67.Weight = 0.46288238823868011R
            ' 
            ' checkBox22
            ' 
            Me.checkBox22.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox22.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox22.EditOptions.Enabled = True
            Me.checkBox22.EditOptions.GroupID = "6"
            Me.checkBox22.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox22.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox22.Name = "checkBox22"
            Me.checkBox22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox22.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox22.StyleName = "EvenStyle4"
            ' 
            ' tableCell68
            ' 
            Me.tableCell68.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox53})
            Me.tableCell68.Multiline = True
            Me.tableCell68.Name = "tableCell68"
            Me.tableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell68.StylePriority.UseBackColor = False
            Me.tableCell68.StylePriority.UsePadding = False
            Me.tableCell68.Text = " "
            Me.tableCell68.Weight = 0.46288238823868016R
            ' 
            ' checkBox53
            ' 
            Me.checkBox53.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox53.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox53.EditOptions.Enabled = True
            Me.checkBox53.EditOptions.GroupID = "6"
            Me.checkBox53.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox53.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox53.Name = "checkBox53"
            Me.checkBox53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox53.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox53.StyleName = "EvenStyle3"
            ' 
            ' tableCell69
            ' 
            Me.tableCell69.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox52})
            Me.tableCell69.Multiline = True
            Me.tableCell69.Name = "tableCell69"
            Me.tableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell69.StylePriority.UseBackColor = False
            Me.tableCell69.StylePriority.UsePadding = False
            Me.tableCell69.Text = " "
            Me.tableCell69.Weight = 0.46288236406936523R
            ' 
            ' checkBox52
            ' 
            Me.checkBox52.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox52.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox52.EditOptions.Enabled = True
            Me.checkBox52.EditOptions.GroupID = "6"
            Me.checkBox52.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox52.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox52.Name = "checkBox52"
            Me.checkBox52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox52.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox52.StyleName = "EvenStyle2"
            ' 
            ' tableCell70
            ' 
            Me.tableCell70.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox51})
            Me.tableCell70.Multiline = True
            Me.tableCell70.Name = "tableCell70"
            Me.tableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell70.StylePriority.UseBackColor = False
            Me.tableCell70.StylePriority.UsePadding = False
            Me.tableCell70.Text = " "
            Me.tableCell70.Weight = 0.46288233911035281R
            ' 
            ' checkBox51
            ' 
            Me.checkBox51.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox51.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox51.EditOptions.Enabled = True
            Me.checkBox51.EditOptions.GroupID = "6"
            Me.checkBox51.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox51.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox51.Name = "checkBox51"
            Me.checkBox51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox51.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox51.StyleName = "EvenStyle1"
            ' 
            ' tableRow16
            ' 
            Me.tableRow16.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell71, Me.tableCell72, Me.tableCell73, Me.tableCell74, Me.tableCell75, Me.tableCell76})
            Me.tableRow16.Name = "tableRow16"
            Me.tableRow16.StylePriority.UseBackColor = False
            Me.tableRow16.Weight = 0.075947049340318332R
            ' 
            ' tableCell71
            ' 
            Me.tableCell71.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell71.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell71.Multiline = True
            Me.tableCell71.Name = "tableCell71"
            Me.tableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell71.StylePriority.UseFont = False
            Me.tableCell71.StylePriority.UseForeColor = False
            Me.tableCell71.StylePriority.UsePadding = False
            Me.tableCell71.StylePriority.UseTextAlignment = False
            Me.tableCell71.Text = "Takes responsibility for actions"
            Me.tableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell71.Weight = 3.1560162582150939R
            ' 
            ' tableCell72
            ' 
            Me.tableCell72.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox11})
            Me.tableCell72.Multiline = True
            Me.tableCell72.Name = "tableCell72"
            Me.tableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell72.StylePriority.UseBackColor = False
            Me.tableCell72.StylePriority.UsePadding = False
            Me.tableCell72.Text = " "
            Me.tableCell72.Weight = 0.46288237121501008R
            ' 
            ' checkBox11
            ' 
            Me.checkBox11.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox11.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox11.EditOptions.Enabled = True
            Me.checkBox11.EditOptions.GroupID = "7"
            Me.checkBox11.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox11.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox11.Name = "checkBox11"
            Me.checkBox11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox11.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox11.StyleName = "OddStyle5"
            ' 
            ' tableCell73
            ' 
            Me.tableCell73.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox23})
            Me.tableCell73.Multiline = True
            Me.tableCell73.Name = "tableCell73"
            Me.tableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell73.StylePriority.UseBackColor = False
            Me.tableCell73.StylePriority.UsePadding = False
            Me.tableCell73.Text = " "
            Me.tableCell73.Weight = 0.46288238823868011R
            ' 
            ' checkBox23
            ' 
            Me.checkBox23.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox23.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox23.EditOptions.Enabled = True
            Me.checkBox23.EditOptions.GroupID = "7"
            Me.checkBox23.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox23.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox23.Name = "checkBox23"
            Me.checkBox23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox23.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox23.StyleName = "OddStyle4"
            ' 
            ' tableCell74
            ' 
            Me.tableCell74.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox48})
            Me.tableCell74.Multiline = True
            Me.tableCell74.Name = "tableCell74"
            Me.tableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell74.StylePriority.UseBackColor = False
            Me.tableCell74.StylePriority.UsePadding = False
            Me.tableCell74.Text = " "
            Me.tableCell74.Weight = 0.46288238823868016R
            ' 
            ' checkBox48
            ' 
            Me.checkBox48.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox48.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox48.EditOptions.Enabled = True
            Me.checkBox48.EditOptions.GroupID = "7"
            Me.checkBox48.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox48.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox48.Name = "checkBox48"
            Me.checkBox48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox48.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox48.StyleName = "OddStyle3"
            ' 
            ' tableCell75
            ' 
            Me.tableCell75.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox49})
            Me.tableCell75.Multiline = True
            Me.tableCell75.Name = "tableCell75"
            Me.tableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell75.StylePriority.UseBackColor = False
            Me.tableCell75.StylePriority.UsePadding = False
            Me.tableCell75.Text = " "
            Me.tableCell75.Weight = 0.46288236406936523R
            ' 
            ' checkBox49
            ' 
            Me.checkBox49.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox49.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox49.EditOptions.Enabled = True
            Me.checkBox49.EditOptions.GroupID = "7"
            Me.checkBox49.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox49.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox49.Name = "checkBox49"
            Me.checkBox49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox49.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox49.StyleName = "OddStyle2"
            ' 
            ' tableCell76
            ' 
            Me.tableCell76.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox50})
            Me.tableCell76.Multiline = True
            Me.tableCell76.Name = "tableCell76"
            Me.tableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell76.StylePriority.UseBackColor = False
            Me.tableCell76.StylePriority.UsePadding = False
            Me.tableCell76.Text = " "
            Me.tableCell76.Weight = 0.46288233911035281R
            ' 
            ' checkBox50
            ' 
            Me.checkBox50.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox50.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox50.EditOptions.Enabled = True
            Me.checkBox50.EditOptions.GroupID = "7"
            Me.checkBox50.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox50.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox50.Name = "checkBox50"
            Me.checkBox50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox50.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox50.StyleName = "OddStyle1"
            ' 
            ' tableRow17
            ' 
            Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell77, Me.tableCell78, Me.tableCell79, Me.tableCell80, Me.tableCell81, Me.tableCell82})
            Me.tableRow17.Name = "tableRow17"
            Me.tableRow17.Weight = 0.075947049340318332R
            ' 
            ' tableCell77
            ' 
            Me.tableCell77.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell77.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell77.Multiline = True
            Me.tableCell77.Name = "tableCell77"
            Me.tableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell77.StylePriority.UseFont = False
            Me.tableCell77.StylePriority.UseForeColor = False
            Me.tableCell77.StylePriority.UsePadding = False
            Me.tableCell77.StylePriority.UseTextAlignment = False
            Me.tableCell77.Text = "Honors commitments"
            Me.tableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell77.Weight = 3.1560162582150939R
            ' 
            ' tableCell78
            ' 
            Me.tableCell78.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox12})
            Me.tableCell78.Multiline = True
            Me.tableCell78.Name = "tableCell78"
            Me.tableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell78.StylePriority.UseBackColor = False
            Me.tableCell78.StylePriority.UsePadding = False
            Me.tableCell78.Text = " "
            Me.tableCell78.Weight = 0.46288237121501008R
            ' 
            ' checkBox12
            ' 
            Me.checkBox12.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox12.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox12.EditOptions.Enabled = True
            Me.checkBox12.EditOptions.GroupID = "8"
            Me.checkBox12.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox12.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox12.Name = "checkBox12"
            Me.checkBox12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox12.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox12.StyleName = "EvenStyle5"
            ' 
            ' tableCell79
            ' 
            Me.tableCell79.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox24})
            Me.tableCell79.Multiline = True
            Me.tableCell79.Name = "tableCell79"
            Me.tableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell79.StylePriority.UseBackColor = False
            Me.tableCell79.StylePriority.UsePadding = False
            Me.tableCell79.Text = " "
            Me.tableCell79.Weight = 0.46288238823868011R
            ' 
            ' checkBox24
            ' 
            Me.checkBox24.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox24.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox24.EditOptions.Enabled = True
            Me.checkBox24.EditOptions.GroupID = "8"
            Me.checkBox24.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox24.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox24.Name = "checkBox24"
            Me.checkBox24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox24.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox24.StyleName = "EvenStyle4"
            ' 
            ' tableCell80
            ' 
            Me.tableCell80.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox47})
            Me.tableCell80.Multiline = True
            Me.tableCell80.Name = "tableCell80"
            Me.tableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell80.StylePriority.UseBackColor = False
            Me.tableCell80.StylePriority.UsePadding = False
            Me.tableCell80.Text = " "
            Me.tableCell80.Weight = 0.46288238823868016R
            ' 
            ' checkBox47
            ' 
            Me.checkBox47.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox47.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox47.EditOptions.Enabled = True
            Me.checkBox47.EditOptions.GroupID = "8"
            Me.checkBox47.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox47.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox47.Name = "checkBox47"
            Me.checkBox47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox47.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox47.StyleName = "EvenStyle3"
            ' 
            ' tableCell81
            ' 
            Me.tableCell81.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox46})
            Me.tableCell81.Multiline = True
            Me.tableCell81.Name = "tableCell81"
            Me.tableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell81.StylePriority.UseBackColor = False
            Me.tableCell81.StylePriority.UsePadding = False
            Me.tableCell81.Text = " "
            Me.tableCell81.Weight = 0.46288236406936523R
            ' 
            ' checkBox46
            ' 
            Me.checkBox46.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox46.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox46.EditOptions.Enabled = True
            Me.checkBox46.EditOptions.GroupID = "8"
            Me.checkBox46.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox46.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox46.Name = "checkBox46"
            Me.checkBox46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox46.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox46.StyleName = "EvenStyle2"
            ' 
            ' tableCell82
            ' 
            Me.tableCell82.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox45})
            Me.tableCell82.Multiline = True
            Me.tableCell82.Name = "tableCell82"
            Me.tableCell82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell82.StylePriority.UseBackColor = False
            Me.tableCell82.StylePriority.UsePadding = False
            Me.tableCell82.Text = " "
            Me.tableCell82.Weight = 0.46288233911035281R
            ' 
            ' checkBox45
            ' 
            Me.checkBox45.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox45.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox45.EditOptions.Enabled = True
            Me.checkBox45.EditOptions.GroupID = "8"
            Me.checkBox45.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox45.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox45.Name = "checkBox45"
            Me.checkBox45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox45.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox45.StyleName = "EvenStyle1"
            ' 
            ' tableRow18
            ' 
            Me.tableRow18.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell83, Me.tableCell84, Me.tableCell85, Me.tableCell86, Me.tableCell87, Me.tableCell88})
            Me.tableRow18.Name = "tableRow18"
            Me.tableRow18.StylePriority.UseBackColor = False
            Me.tableRow18.Weight = 0.075947049340318318R
            ' 
            ' tableCell83
            ' 
            Me.tableCell83.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell83.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell83.Multiline = True
            Me.tableCell83.Name = "tableCell83"
            Me.tableCell83.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell83.StylePriority.UseFont = False
            Me.tableCell83.StylePriority.UseForeColor = False
            Me.tableCell83.StylePriority.UsePadding = False
            Me.tableCell83.StylePriority.UseTextAlignment = False
            Me.tableCell83.Text = "Demonstrates problem solving skills"
            Me.tableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell83.Weight = 3.1560162582150939R
            ' 
            ' tableCell84
            ' 
            Me.tableCell84.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox13})
            Me.tableCell84.Multiline = True
            Me.tableCell84.Name = "tableCell84"
            Me.tableCell84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell84.StylePriority.UseBackColor = False
            Me.tableCell84.StylePriority.UsePadding = False
            Me.tableCell84.Text = " "
            Me.tableCell84.Weight = 0.46288237121501008R
            ' 
            ' checkBox13
            ' 
            Me.checkBox13.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox13.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox13.EditOptions.Enabled = True
            Me.checkBox13.EditOptions.GroupID = "9"
            Me.checkBox13.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox13.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox13.Name = "checkBox13"
            Me.checkBox13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox13.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox13.StyleName = "OddStyle5"
            ' 
            ' tableCell85
            ' 
            Me.tableCell85.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox25})
            Me.tableCell85.Multiline = True
            Me.tableCell85.Name = "tableCell85"
            Me.tableCell85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell85.StylePriority.UseBackColor = False
            Me.tableCell85.StylePriority.UsePadding = False
            Me.tableCell85.Text = " "
            Me.tableCell85.Weight = 0.46288238823868011R
            ' 
            ' checkBox25
            ' 
            Me.checkBox25.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox25.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox25.EditOptions.Enabled = True
            Me.checkBox25.EditOptions.GroupID = "9"
            Me.checkBox25.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox25.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox25.Name = "checkBox25"
            Me.checkBox25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox25.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox25.StyleName = "OddStyle4"
            ' 
            ' tableCell86
            ' 
            Me.tableCell86.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox42})
            Me.tableCell86.Multiline = True
            Me.tableCell86.Name = "tableCell86"
            Me.tableCell86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell86.StylePriority.UseBackColor = False
            Me.tableCell86.StylePriority.UsePadding = False
            Me.tableCell86.Text = " "
            Me.tableCell86.Weight = 0.46288238823868016R
            ' 
            ' checkBox42
            ' 
            Me.checkBox42.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox42.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox42.EditOptions.Enabled = True
            Me.checkBox42.EditOptions.GroupID = "9"
            Me.checkBox42.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox42.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox42.Name = "checkBox42"
            Me.checkBox42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox42.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox42.StyleName = "OddStyle3"
            ' 
            ' tableCell87
            ' 
            Me.tableCell87.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox43})
            Me.tableCell87.Multiline = True
            Me.tableCell87.Name = "tableCell87"
            Me.tableCell87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell87.StylePriority.UseBackColor = False
            Me.tableCell87.StylePriority.UsePadding = False
            Me.tableCell87.Text = " "
            Me.tableCell87.Weight = 0.46288236406936523R
            ' 
            ' checkBox43
            ' 
            Me.checkBox43.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox43.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox43.EditOptions.Enabled = True
            Me.checkBox43.EditOptions.GroupID = "9"
            Me.checkBox43.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox43.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox43.Name = "checkBox43"
            Me.checkBox43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox43.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox43.StyleName = "OddStyle2"
            ' 
            ' tableCell88
            ' 
            Me.tableCell88.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox44})
            Me.tableCell88.Multiline = True
            Me.tableCell88.Name = "tableCell88"
            Me.tableCell88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell88.StylePriority.UseBackColor = False
            Me.tableCell88.StylePriority.UsePadding = False
            Me.tableCell88.Text = " "
            Me.tableCell88.Weight = 0.46288233911035281R
            ' 
            ' checkBox44
            ' 
            Me.checkBox44.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox44.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox44.EditOptions.Enabled = True
            Me.checkBox44.EditOptions.GroupID = "9"
            Me.checkBox44.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox44.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox44.Name = "checkBox44"
            Me.checkBox44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox44.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox44.StyleName = "OddStyle1"
            ' 
            ' tableRow19
            ' 
            Me.tableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell89, Me.tableCell90, Me.tableCell91, Me.tableCell92, Me.tableCell93, Me.tableCell94})
            Me.tableRow19.Name = "tableRow19"
            Me.tableRow19.Weight = 0.075947049340318332R
            ' 
            ' tableCell89
            ' 
            Me.tableCell89.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell89.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell89.Multiline = True
            Me.tableCell89.Name = "tableCell89"
            Me.tableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell89.StylePriority.UseFont = False
            Me.tableCell89.StylePriority.UseForeColor = False
            Me.tableCell89.StylePriority.UsePadding = False
            Me.tableCell89.StylePriority.UseTextAlignment = False
            Me.tableCell89.Text = "Offers constructive suggestions"
            Me.tableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell89.Weight = 3.1560162582150939R
            ' 
            ' tableCell90
            ' 
            Me.tableCell90.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox14})
            Me.tableCell90.Multiline = True
            Me.tableCell90.Name = "tableCell90"
            Me.tableCell90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell90.StylePriority.UseBackColor = False
            Me.tableCell90.StylePriority.UsePadding = False
            Me.tableCell90.Text = " "
            Me.tableCell90.Weight = 0.46288237121501008R
            ' 
            ' checkBox14
            ' 
            Me.checkBox14.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox14.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox14.EditOptions.Enabled = True
            Me.checkBox14.EditOptions.GroupID = "10"
            Me.checkBox14.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox14.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox14.Name = "checkBox14"
            Me.checkBox14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox14.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox14.StyleName = "EvenStyle5"
            ' 
            ' tableCell91
            ' 
            Me.tableCell91.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox26})
            Me.tableCell91.Multiline = True
            Me.tableCell91.Name = "tableCell91"
            Me.tableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell91.StylePriority.UseBackColor = False
            Me.tableCell91.StylePriority.UsePadding = False
            Me.tableCell91.Text = " "
            Me.tableCell91.Weight = 0.46288238823868011R
            ' 
            ' checkBox26
            ' 
            Me.checkBox26.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox26.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox26.EditOptions.Enabled = True
            Me.checkBox26.EditOptions.GroupID = "10"
            Me.checkBox26.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox26.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox26.Name = "checkBox26"
            Me.checkBox26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox26.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox26.StyleName = "EvenStyle4"
            ' 
            ' tableCell92
            ' 
            Me.tableCell92.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox41})
            Me.tableCell92.Multiline = True
            Me.tableCell92.Name = "tableCell92"
            Me.tableCell92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell92.StylePriority.UseBackColor = False
            Me.tableCell92.StylePriority.UsePadding = False
            Me.tableCell92.Text = " "
            Me.tableCell92.Weight = 0.46288238823868016R
            ' 
            ' checkBox41
            ' 
            Me.checkBox41.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox41.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox41.EditOptions.Enabled = True
            Me.checkBox41.EditOptions.GroupID = "10"
            Me.checkBox41.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox41.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox41.Name = "checkBox41"
            Me.checkBox41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox41.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox41.StyleName = "EvenStyle3"
            ' 
            ' tableCell93
            ' 
            Me.tableCell93.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox40})
            Me.tableCell93.Multiline = True
            Me.tableCell93.Name = "tableCell93"
            Me.tableCell93.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell93.StylePriority.UseBackColor = False
            Me.tableCell93.StylePriority.UsePadding = False
            Me.tableCell93.Text = " "
            Me.tableCell93.Weight = 0.46288236406936523R
            ' 
            ' checkBox40
            ' 
            Me.checkBox40.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox40.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox40.EditOptions.Enabled = True
            Me.checkBox40.EditOptions.GroupID = "10"
            Me.checkBox40.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox40.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox40.Name = "checkBox40"
            Me.checkBox40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox40.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox40.StyleName = "EvenStyle2"
            ' 
            ' tableCell94
            ' 
            Me.tableCell94.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox39})
            Me.tableCell94.Multiline = True
            Me.tableCell94.Name = "tableCell94"
            Me.tableCell94.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell94.StylePriority.UseBackColor = False
            Me.tableCell94.StylePriority.UsePadding = False
            Me.tableCell94.Text = " "
            Me.tableCell94.Weight = 0.46288233911035281R
            ' 
            ' checkBox39
            ' 
            Me.checkBox39.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox39.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox39.EditOptions.Enabled = True
            Me.checkBox39.EditOptions.GroupID = "10"
            Me.checkBox39.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox39.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox39.Name = "checkBox39"
            Me.checkBox39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox39.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox39.StyleName = "EvenStyle1"
            ' 
            ' tableRow21
            ' 
            Me.tableRow21.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell101, Me.tableCell102, Me.tableCell103, Me.tableCell104, Me.tableCell105, Me.tableCell106})
            Me.tableRow21.Name = "tableRow21"
            Me.tableRow21.StylePriority.UseBackColor = False
            Me.tableRow21.Weight = 0.075947049340318318R
            ' 
            ' tableCell101
            ' 
            Me.tableCell101.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell101.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell101.Multiline = True
            Me.tableCell101.Name = "tableCell101"
            Me.tableCell101.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell101.StylePriority.UseFont = False
            Me.tableCell101.StylePriority.UseForeColor = False
            Me.tableCell101.StylePriority.UsePadding = False
            Me.tableCell101.StylePriority.UseTextAlignment = False
            Me.tableCell101.Text = "Demonstrates innovative thinking"
            Me.tableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell101.Weight = 3.1560162582150939R
            ' 
            ' tableCell102
            ' 
            Me.tableCell102.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox16})
            Me.tableCell102.Multiline = True
            Me.tableCell102.Name = "tableCell102"
            Me.tableCell102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell102.StylePriority.UseBackColor = False
            Me.tableCell102.StylePriority.UsePadding = False
            Me.tableCell102.Text = " "
            Me.tableCell102.Weight = 0.46288237121501008R
            ' 
            ' checkBox16
            ' 
            Me.checkBox16.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox16.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox16.EditOptions.Enabled = True
            Me.checkBox16.EditOptions.GroupID = "12"
            Me.checkBox16.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox16.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox16.Name = "checkBox16"
            Me.checkBox16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox16.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox16.StyleName = "OddStyle5"
            ' 
            ' tableCell103
            ' 
            Me.tableCell103.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox28})
            Me.tableCell103.Multiline = True
            Me.tableCell103.Name = "tableCell103"
            Me.tableCell103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell103.StylePriority.UseBackColor = False
            Me.tableCell103.StylePriority.UsePadding = False
            Me.tableCell103.Text = " "
            Me.tableCell103.Weight = 0.46288238823868011R
            ' 
            ' checkBox28
            ' 
            Me.checkBox28.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox28.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox28.EditOptions.Enabled = True
            Me.checkBox28.EditOptions.GroupID = "12"
            Me.checkBox28.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox28.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox28.Name = "checkBox28"
            Me.checkBox28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox28.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox28.StyleName = "OddStyle4"
            ' 
            ' tableCell104
            ' 
            Me.tableCell104.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox35})
            Me.tableCell104.Multiline = True
            Me.tableCell104.Name = "tableCell104"
            Me.tableCell104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell104.StylePriority.UseBackColor = False
            Me.tableCell104.StylePriority.UsePadding = False
            Me.tableCell104.Text = " "
            Me.tableCell104.Weight = 0.46288238823868016R
            ' 
            ' checkBox35
            ' 
            Me.checkBox35.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox35.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox35.EditOptions.Enabled = True
            Me.checkBox35.EditOptions.GroupID = "12"
            Me.checkBox35.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox35.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox35.Name = "checkBox35"
            Me.checkBox35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox35.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox35.StyleName = "OddStyle3"
            ' 
            ' tableCell105
            ' 
            Me.tableCell105.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox34})
            Me.tableCell105.Multiline = True
            Me.tableCell105.Name = "tableCell105"
            Me.tableCell105.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell105.StylePriority.UseBackColor = False
            Me.tableCell105.StylePriority.UsePadding = False
            Me.tableCell105.Text = " "
            Me.tableCell105.Weight = 0.46288236406936523R
            ' 
            ' checkBox34
            ' 
            Me.checkBox34.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox34.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox34.EditOptions.Enabled = True
            Me.checkBox34.EditOptions.GroupID = "12"
            Me.checkBox34.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox34.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox34.Name = "checkBox34"
            Me.checkBox34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox34.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox34.StyleName = "OddStyle2"
            ' 
            ' tableCell106
            ' 
            Me.tableCell106.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox33})
            Me.tableCell106.Multiline = True
            Me.tableCell106.Name = "tableCell106"
            Me.tableCell106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell106.StylePriority.UseBackColor = False
            Me.tableCell106.StylePriority.UsePadding = False
            Me.tableCell106.Text = " "
            Me.tableCell106.Weight = 0.46288233911035281R
            ' 
            ' checkBox33
            ' 
            Me.checkBox33.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox33.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox33.EditOptions.Enabled = True
            Me.checkBox33.EditOptions.GroupID = "12"
            Me.checkBox33.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox33.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox33.Name = "checkBox33"
            Me.checkBox33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox33.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox33.StyleName = "OddStyle1"
            ' 
            ' tableRow20
            ' 
            Me.tableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell95, Me.tableCell96, Me.tableCell97, Me.tableCell98, Me.tableCell99, Me.tableCell100})
            Me.tableRow20.Name = "tableRow20"
            Me.tableRow20.StylePriority.UseBackColor = False
            Me.tableRow20.Weight = 0.075947049340318318R
            ' 
            ' tableCell95
            ' 
            Me.tableCell95.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell95.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell95.Multiline = True
            Me.tableCell95.Name = "tableCell95"
            Me.tableCell95.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell95.StylePriority.UseFont = False
            Me.tableCell95.StylePriority.UseForeColor = False
            Me.tableCell95.StylePriority.UsePadding = False
            Me.tableCell95.StylePriority.UseTextAlignment = False
            Me.tableCell95.Text = "Develops collaboration accross teams"
            Me.tableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell95.Weight = 3.1560162582150939R
            ' 
            ' tableCell96
            ' 
            Me.tableCell96.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox15})
            Me.tableCell96.Multiline = True
            Me.tableCell96.Name = "tableCell96"
            Me.tableCell96.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell96.StylePriority.UseBackColor = False
            Me.tableCell96.StylePriority.UsePadding = False
            Me.tableCell96.Text = " "
            Me.tableCell96.Weight = 0.46288237121501008R
            ' 
            ' checkBox15
            ' 
            Me.checkBox15.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox15.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox15.EditOptions.Enabled = True
            Me.checkBox15.EditOptions.GroupID = "11"
            Me.checkBox15.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox15.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox15.Name = "checkBox15"
            Me.checkBox15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox15.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox15.StyleName = "EvenStyle5"
            ' 
            ' tableCell97
            ' 
            Me.tableCell97.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox27})
            Me.tableCell97.Multiline = True
            Me.tableCell97.Name = "tableCell97"
            Me.tableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell97.StylePriority.UseBackColor = False
            Me.tableCell97.StylePriority.UsePadding = False
            Me.tableCell97.Text = " "
            Me.tableCell97.Weight = 0.46288238823868011R
            ' 
            ' checkBox27
            ' 
            Me.checkBox27.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox27.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox27.EditOptions.Enabled = True
            Me.checkBox27.EditOptions.GroupID = "11"
            Me.checkBox27.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox27.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox27.Name = "checkBox27"
            Me.checkBox27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox27.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox27.StyleName = "EvenStyle4"
            ' 
            ' tableCell98
            ' 
            Me.tableCell98.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox36})
            Me.tableCell98.Multiline = True
            Me.tableCell98.Name = "tableCell98"
            Me.tableCell98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell98.StylePriority.UseBackColor = False
            Me.tableCell98.StylePriority.UsePadding = False
            Me.tableCell98.Text = " "
            Me.tableCell98.Weight = 0.46288238823868016R
            ' 
            ' checkBox36
            ' 
            Me.checkBox36.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox36.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox36.EditOptions.Enabled = True
            Me.checkBox36.EditOptions.GroupID = "11"
            Me.checkBox36.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox36.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox36.Name = "checkBox36"
            Me.checkBox36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox36.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox36.StyleName = "EvenStyle3"
            ' 
            ' tableCell99
            ' 
            Me.tableCell99.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox37})
            Me.tableCell99.Multiline = True
            Me.tableCell99.Name = "tableCell99"
            Me.tableCell99.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell99.StylePriority.UseBackColor = False
            Me.tableCell99.StylePriority.UsePadding = False
            Me.tableCell99.Text = " "
            Me.tableCell99.Weight = 0.46288236406936523R
            ' 
            ' checkBox37
            ' 
            Me.checkBox37.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox37.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox37.EditOptions.Enabled = True
            Me.checkBox37.EditOptions.GroupID = "11"
            Me.checkBox37.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox37.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox37.Name = "checkBox37"
            Me.checkBox37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox37.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox37.StyleName = "EvenStyle2"
            ' 
            ' tableCell100
            ' 
            Me.tableCell100.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox38})
            Me.tableCell100.Multiline = True
            Me.tableCell100.Name = "tableCell100"
            Me.tableCell100.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell100.StylePriority.UseBackColor = False
            Me.tableCell100.StylePriority.UsePadding = False
            Me.tableCell100.Text = " "
            Me.tableCell100.Weight = 0.46288233911035281R
            ' 
            ' checkBox38
            ' 
            Me.checkBox38.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox38.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox38.EditOptions.Enabled = True
            Me.checkBox38.EditOptions.GroupID = "11"
            Me.checkBox38.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox38.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox38.Name = "checkBox38"
            Me.checkBox38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox38.SizeF = New System.Drawing.SizeF(55F, 39.99999F)
            Me.checkBox38.StyleName = "EvenStyle1"
            ' 
            ' tableRow22
            ' 
            Me.tableRow22.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.tableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell107, Me.tableCell108, Me.tableCell109, Me.tableCell110, Me.tableCell111, Me.tableCell112})
            Me.tableRow22.Name = "tableRow22"
            Me.tableRow22.StylePriority.UseBackColor = False
            Me.tableRow22.Weight = 0.075947049340318332R
            ' 
            ' tableCell107
            ' 
            Me.tableCell107.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell107.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.tableCell107.Multiline = True
            Me.tableCell107.Name = "tableCell107"
            Me.tableCell107.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.tableCell107.StylePriority.UseFont = False
            Me.tableCell107.StylePriority.UseForeColor = False
            Me.tableCell107.StylePriority.UsePadding = False
            Me.tableCell107.StylePriority.UseTextAlignment = False
            Me.tableCell107.Text = "Meets challenges head on"
            Me.tableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell107.Weight = 3.1560162582150939R
            ' 
            ' tableCell108
            ' 
            Me.tableCell108.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox17})
            Me.tableCell108.Multiline = True
            Me.tableCell108.Name = "tableCell108"
            Me.tableCell108.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell108.StylePriority.UseBackColor = False
            Me.tableCell108.StylePriority.UsePadding = False
            Me.tableCell108.Text = " "
            Me.tableCell108.Weight = 0.46288237121501008R
            ' 
            ' checkBox17
            ' 
            Me.checkBox17.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox17.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox17.EditOptions.Enabled = True
            Me.checkBox17.EditOptions.GroupID = "13"
            Me.checkBox17.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox17.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox17.Name = "checkBox17"
            Me.checkBox17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox17.SizeF = New System.Drawing.SizeF(55F, 39.99997F)
            Me.checkBox17.StyleName = "OddStyle5"
            ' 
            ' tableCell109
            ' 
            Me.tableCell109.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox29})
            Me.tableCell109.Multiline = True
            Me.tableCell109.Name = "tableCell109"
            Me.tableCell109.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell109.StylePriority.UseBackColor = False
            Me.tableCell109.StylePriority.UsePadding = False
            Me.tableCell109.Text = " "
            Me.tableCell109.Weight = 0.46288238823868011R
            ' 
            ' checkBox29
            ' 
            Me.checkBox29.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox29.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox29.EditOptions.Enabled = True
            Me.checkBox29.EditOptions.GroupID = "13"
            Me.checkBox29.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox29.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox29.Name = "checkBox29"
            Me.checkBox29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox29.SizeF = New System.Drawing.SizeF(55F, 39.99997F)
            Me.checkBox29.StyleName = "OddStyle4"
            ' 
            ' tableCell110
            ' 
            Me.tableCell110.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox30})
            Me.tableCell110.Multiline = True
            Me.tableCell110.Name = "tableCell110"
            Me.tableCell110.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell110.StylePriority.UseBackColor = False
            Me.tableCell110.StylePriority.UsePadding = False
            Me.tableCell110.Text = " "
            Me.tableCell110.Weight = 0.46288238823868016R
            ' 
            ' checkBox30
            ' 
            Me.checkBox30.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox30.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox30.EditOptions.Enabled = True
            Me.checkBox30.EditOptions.GroupID = "13"
            Me.checkBox30.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox30.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox30.Name = "checkBox30"
            Me.checkBox30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox30.SizeF = New System.Drawing.SizeF(55F, 39.99997F)
            Me.checkBox30.StyleName = "OddStyle3"
            ' 
            ' tableCell111
            ' 
            Me.tableCell111.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox31})
            Me.tableCell111.Multiline = True
            Me.tableCell111.Name = "tableCell111"
            Me.tableCell111.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell111.StylePriority.UseBackColor = False
            Me.tableCell111.StylePriority.UsePadding = False
            Me.tableCell111.Text = " "
            Me.tableCell111.Weight = 0.46288236406936523R
            ' 
            ' checkBox31
            ' 
            Me.checkBox31.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox31.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox31.EditOptions.Enabled = True
            Me.checkBox31.EditOptions.GroupID = "13"
            Me.checkBox31.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox31.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox31.Name = "checkBox31"
            Me.checkBox31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox31.SizeF = New System.Drawing.SizeF(55F, 39.99997F)
            Me.checkBox31.StyleName = "OddStyle2"
            ' 
            ' tableCell112
            ' 
            Me.tableCell112.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox32})
            Me.tableCell112.Multiline = True
            Me.tableCell112.Name = "tableCell112"
            Me.tableCell112.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell112.StylePriority.UseBackColor = False
            Me.tableCell112.StylePriority.UsePadding = False
            Me.tableCell112.Text = " "
            Me.tableCell112.Weight = 0.46288233911035281R
            ' 
            ' checkBox32
            ' 
            Me.checkBox32.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox32.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox32.EditOptions.Enabled = True
            Me.checkBox32.EditOptions.GroupID = "13"
            Me.checkBox32.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox32.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.checkBox32.Name = "checkBox32"
            Me.checkBox32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.checkBox32.SizeF = New System.Drawing.SizeF(55F, 39.99997F)
            Me.checkBox32.StyleName = "OddStyle1"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox3})
            Me.BottomMargin.HeightF = 80F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox3.ImageSource"))
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(239.06F, 20F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox3.UseImageResolution = False
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3, Me.table2, Me.label1})
            Me.ReportHeader.HeightF = 315F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' table3
            ' 
            Me.table3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.table3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(375F, 75F)
            Me.table3.Name = "table3"
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow24, Me.tableRow31, Me.tableRow26, Me.tableRow27, Me.tableRow28, Me.tableRow29, Me.tableRow30})
            Me.table3.SizeF = New System.Drawing.SizeF(275F, 195F)
            Me.table3.StylePriority.UseBackColor = False
            Me.table3.StylePriority.UseForeColor = False
            ' 
            ' tableRow24
            ' 
            Me.tableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17})
            Me.tableRow24.Name = "tableRow24"
            Me.tableRow24.Weight = 0.20909085320073542R
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.Multiline = True
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 10, 100F)
            Me.tableCell17.StyleName = "LargeHeaderStyle"
            Me.tableCell17.StylePriority.UseFont = False
            Me.tableCell17.StylePriority.UsePadding = False
            Me.tableCell17.StylePriority.UseTextAlignment = False
            Me.tableCell17.Text = "Evaluation Scale"
            Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell17.Weight = 3R
            ' 
            ' tableRow31
            ' 
            Me.tableRow31.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell117})
            Me.tableRow31.Name = "tableRow31"
            Me.tableRow31.StylePriority.UseTextAlignment = False
            Me.tableRow31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableRow31.Weight = 0.10454542725428835R
            ' 
            ' tableCell117
            ' 
            Me.tableCell117.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell117.Multiline = True
            Me.tableCell117.Name = "tableCell117"
            Me.tableCell117.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell117.StylePriority.UseFont = False
            Me.tableCell117.StylePriority.UsePadding = False
            Me.tableCell117.StylePriority.UseTextAlignment = False
            Me.tableCell117.Text = "5 = Exceptional"
            Me.tableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell117.Weight = 3R
            ' 
            ' tableRow26
            ' 
            Me.tableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell23})
            Me.tableRow26.Name = "tableRow26"
            Me.tableRow26.StylePriority.UseTextAlignment = False
            Me.tableRow26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableRow26.Weight = 0.10454542725428839R
            ' 
            ' tableCell23
            ' 
            Me.tableCell23.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell23.Multiline = True
            Me.tableCell23.Name = "tableCell23"
            Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell23.StylePriority.UseFont = False
            Me.tableCell23.StylePriority.UsePadding = False
            Me.tableCell23.StylePriority.UseTextAlignment = False
            Me.tableCell23.Text = "4 = Exceeds Requirements"
            Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell23.Weight = 3R
            ' 
            ' tableRow27
            ' 
            Me.tableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell26})
            Me.tableRow27.Name = "tableRow27"
            Me.tableRow27.Weight = 0.1045454272542883R
            ' 
            ' tableCell26
            ' 
            Me.tableCell26.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell26.Multiline = True
            Me.tableCell26.Name = "tableCell26"
            Me.tableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell26.StylePriority.UseFont = False
            Me.tableCell26.StylePriority.UsePadding = False
            Me.tableCell26.StylePriority.UseTextAlignment = False
            Me.tableCell26.Text = "3 = Meets Requirements"
            Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell26.Weight = 3R
            ' 
            ' tableRow28
            ' 
            Me.tableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell29})
            Me.tableRow28.Name = "tableRow28"
            Me.tableRow28.StylePriority.UseTextAlignment = False
            Me.tableRow28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableRow28.Weight = 0.10454542725428832R
            ' 
            ' tableCell29
            ' 
            Me.tableCell29.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell29.Multiline = True
            Me.tableCell29.Name = "tableCell29"
            Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell29.StylePriority.UseFont = False
            Me.tableCell29.StylePriority.UsePadding = False
            Me.tableCell29.StylePriority.UseTextAlignment = False
            Me.tableCell29.Text = "2 = Needs Improvement"
            Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell29.Weight = 3R
            ' 
            ' tableRow29
            ' 
            Me.tableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell32})
            Me.tableRow29.Name = "tableRow29"
            Me.tableRow29.StylePriority.UseTextAlignment = False
            Me.tableRow29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableRow29.Weight = 0.10454542695507439R
            ' 
            ' tableCell32
            ' 
            Me.tableCell32.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.tableCell32.Multiline = True
            Me.tableCell32.Name = "tableCell32"
            Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell32.StylePriority.UseFont = False
            Me.tableCell32.StylePriority.UsePadding = False
            Me.tableCell32.StylePriority.UseTextAlignment = False
            Me.tableCell32.Text = "1 = Unsatisfactory"
            Me.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tableCell32.Weight = 3R
            ' 
            ' tableRow30
            ' 
            Me.tableRow30.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell114})
            Me.tableRow30.Name = "tableRow30"
            Me.tableRow30.Weight = 0.1000004617949222R
            ' 
            ' tableCell114
            ' 
            Me.tableCell114.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell114.Multiline = True
            Me.tableCell114.Name = "tableCell114"
            Me.tableCell114.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F)
            Me.tableCell114.StylePriority.UseFont = False
            Me.tableCell114.StylePriority.UsePadding = False
            Me.tableCell114.StylePriority.UseTextAlignment = False
            Me.tableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell114.Weight = 3R
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 75F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.tableRow3, Me.tableRow4, Me.tableRow5, Me.tableRow6, Me.tableRow7, Me.tableRow8, Me.tableRow9})
            Me.table2.SizeF = New System.Drawing.SizeF(300F, 225F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 0.744805296032943R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.CanGrow = False
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "LightHeaderStyle"
            Me.tableCell7.Text = "Employee Name:"
            Me.tableCell7.Weight = 1.05R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 1.696501064241843R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.CanGrow = False
            Me.tableCell8.EditOptions.Enabled = True
            Me.tableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "LargeHeaderStyle"
            Me.tableCell8.StylePriority.UsePadding = False
            Me.tableCell8.Text = "Michael Adams"
            Me.tableCell8.Weight = 1.05R
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 0.74480534794711106R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.CanGrow = False
            Me.tableCell9.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StyleName = "LightHeaderStyle"
            Me.tableCell9.StylePriority.UsePadding = False
            Me.tableCell9.Text = "Date:"
            Me.tableCell9.Weight = 1.05R
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 1.6965010143101251R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo2})
            Me.tableCell10.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "LargeHeaderStyle"
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.Weight = 1.05R
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.pageInfo2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(300F, 40.99998F)
            Me.pageInfo2.StyleName = "LargeHeaderStyle"
            Me.pageInfo2.StylePriority.UsePadding = False
            Me.pageInfo2.TextFormatString = "{0:M/d/yyyy}"
            ' 
            ' tableRow6
            ' 
            Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell11})
            Me.tableRow6.Name = "tableRow6"
            Me.tableRow6.Weight = 0.74480531552910112R
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.CanGrow = False
            Me.tableCell11.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell11.Multiline = True
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.StyleName = "LightHeaderStyle"
            Me.tableCell11.StylePriority.UsePadding = False
            Me.tableCell11.Text = "Interviewer:"
            Me.tableCell11.Weight = 1.05R
            ' 
            ' tableRow7
            ' 
            Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12})
            Me.tableRow7.Name = "tableRow7"
            Me.tableRow7.Weight = 1.6965010230072186R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.StyleName = "LargeHeaderStyle"
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.Text = "James Dobson"
            Me.tableCell12.Weight = 1.05R
            ' 
            ' tableRow8
            ' 
            Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13})
            Me.tableRow8.Name = "tableRow8"
            Me.tableRow8.Weight = 0.744805324286586R
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.CanGrow = False
            Me.tableCell13.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell13.Multiline = True
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.StyleName = "LightHeaderStyle"
            Me.tableCell13.StylePriority.UsePadding = False
            Me.tableCell13.Text = "Review Period:"
            Me.tableCell13.Weight = 1.05R
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.startPeriod, Me.tableCell16, Me.endPeriod})
            Me.tableRow9.Name = "tableRow9"
            Me.tableRow9.StylePriority.UseTextAlignment = False
            Me.tableRow9.Weight = 1.2413422390017896R
            ' 
            ' startPeriod
            ' 
            Me.startPeriod.EditOptions.EditorName = "Date"
            Me.startPeriod.EditOptions.Enabled = True
            Me.startPeriod.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "AddYears(Today(), -1)")})
            Me.startPeriod.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.startPeriod.Multiline = True
            Me.startPeriod.Name = "startPeriod"
            Me.startPeriod.StyleName = "LargeHeaderStyle"
            Me.startPeriod.StylePriority.UsePadding = False
            Me.startPeriod.Text = " "
            Me.startPeriod.TextFormatString = "{0:M/d/yyyy}"
            Me.startPeriod.Weight = 0.40950000155196975R
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.CanGrow = False
            Me.tableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.tableCell16.Multiline = True
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F)
            Me.tableCell16.StyleName = "LightHeaderStyle"
            Me.tableCell16.StylePriority.UseFont = False
            Me.tableCell16.StylePriority.UsePadding = False
            Me.tableCell16.StylePriority.UseTextAlignment = False
            Me.tableCell16.Text = "-"
            Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.tableCell16.Weight = 0.12031247278025023R
            ' 
            ' endPeriod
            ' 
            Me.endPeriod.EditOptions.EditorName = "Date"
            Me.endPeriod.EditOptions.Enabled = True
            Me.endPeriod.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
            Me.endPeriod.Multiline = True
            Me.endPeriod.Name = "endPeriod"
            Me.endPeriod.StyleName = "LargeHeaderStyle"
            Me.endPeriod.StylePriority.UsePadding = False
            Me.endPeriod.Text = " "
            Me.endPeriod.TextFormatString = "{0:M/d/yyyy}"
            Me.endPeriod.Weight = 0.52018752566778R
            ' 
            ' label1
            ' 
            Me.label1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 24.25F)
            Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(649.9998F, 47.99998F)
            Me.label1.StylePriority.UseBackColor = False
            Me.label1.StylePriority.UseFont = False
            Me.label1.StylePriority.UseForeColor = False
            Me.label1.StylePriority.UsePadding = False
            Me.label1.StylePriority.UseTextAlignment = False
            Me.label1.Text = "Employee Performance Review"
            Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportFooter.HeightF = 90F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((246)))))), (CInt(((CByte((251)))))))
            Me.xrLabel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel1.BorderWidth = 2F
            Me.xrLabel1.EditOptions.Enabled = True
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((34)))))), (CInt(((CByte((34)))))), (CInt(((CByte((34)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 20F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 5, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 70F)
            Me.xrLabel1.StyleName = "LightHeaderStyle"
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseBorderWidth = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Additional Comments:"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' LightHeaderStyle
            ' 
            Me.LightHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.LightHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((173)))))), (CInt(((CByte((173)))))), (CInt(((CByte((173)))))))
            Me.LightHeaderStyle.Name = "LightHeaderStyle"
            Me.LightHeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 4, 100F)
            Me.LightHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' LargeHeaderStyle
            ' 
            Me.LargeHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 13.75F)
            Me.LargeHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.LargeHeaderStyle.Name = "LargeHeaderStyle"
            Me.LargeHeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F)
            ' 
            ' OddStyle5
            ' 
            Me.OddStyle5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((227)))))), (CInt(((CByte((226)))))))
            Me.OddStyle5.Name = "OddStyle5"
            ' 
            ' OddStyle4
            ' 
            Me.OddStyle4.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((208)))))), (CInt(((CByte((231)))))), (CInt(((CByte((231)))))))
            Me.OddStyle4.Name = "OddStyle4"
            ' 
            ' OddStyle3
            ' 
            Me.OddStyle3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((235)))))), (CInt(((CByte((236)))))))
            Me.OddStyle3.Name = "OddStyle3"
            ' 
            ' OddStyle2
            ' 
            Me.OddStyle2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((225)))))), (CInt(((CByte((238)))))), (CInt(((CByte((241)))))))
            Me.OddStyle2.Name = "OddStyle2"
            ' 
            ' OddStyle1
            ' 
            Me.OddStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((234)))))), (CInt(((CByte((242)))))), (CInt(((CByte((246)))))))
            Me.OddStyle1.Name = "OddStyle1"
            ' 
            ' EvenStyle5
            ' 
            Me.EvenStyle5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((209)))))), (CInt(((CByte((235)))))), (CInt(((CByte((229)))))))
            Me.EvenStyle5.Name = "EvenStyle5"
            ' 
            ' EvenStyle4
            ' 
            Me.EvenStyle4.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((239)))))), (CInt(((CByte((235)))))))
            Me.EvenStyle4.Name = "EvenStyle4"
            ' 
            ' EvenStyle3
            ' 
            Me.EvenStyle3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((243)))))), (CInt(((CByte((240)))))))
            Me.EvenStyle3.Name = "EvenStyle3"
            ' 
            ' EvenStyle2
            ' 
            Me.EvenStyle2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((236)))))), (CInt(((CByte((247)))))), (CInt(((CByte((245)))))))
            Me.EvenStyle2.Name = "EvenStyle2"
            ' 
            ' EvenStyle1
            ' 
            Me.EvenStyle1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((246)))))), (CInt(((CByte((251)))))), (CInt(((CByte((250)))))))
            Me.EvenStyle1.Name = "EvenStyle1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 50, 80)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.LightHeaderStyle, Me.LargeHeaderStyle, Me.OddStyle5, Me.OddStyle4, Me.OddStyle3, Me.OddStyle2, Me.OddStyle1, Me.EvenStyle5, Me.EvenStyle4, Me.EvenStyle3, Me.EvenStyle2, Me.EvenStyle1})
            Me.Version = "21.2"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell36 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox2 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox3 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox4 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox5 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox6 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox18 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell44 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox65 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox64 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell46 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox63 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox7 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell49 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox19 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox60 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox61 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell52 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox62 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox8 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell55 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox20 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell56 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox59 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell57 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox58 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell58 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox57 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell59 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell60 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox9 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell61 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox21 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell62 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox54 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell63 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox55 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell64 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox56 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell65 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell66 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox10 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell67 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox22 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell68 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox53 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell69 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox52 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell70 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox51 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell71 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell72 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox11 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell73 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox23 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell74 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox48 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell75 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox49 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell76 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox50 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell77 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell78 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox12 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell79 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox24 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell80 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox47 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell81 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox46 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell82 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox45 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell83 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell84 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox13 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell85 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox25 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell86 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox42 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell87 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox43 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell88 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox44 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell89 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell90 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox14 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell91 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox26 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell92 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox41 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell93 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox40 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell94 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox39 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow20 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell95 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell96 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox15 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell97 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox27 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell98 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox36 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell99 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox37 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell100 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox38 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow21 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell101 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell102 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox16 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell103 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox28 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell104 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox35 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell105 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox34 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell106 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox33 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableRow22 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell107 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell108 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox17 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell109 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox29 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell110 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox30 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell111 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox31 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell112 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox32 As DevExpress.XtraReports.UI.XRCheckBox

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow24 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow31 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell117 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow26 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow27 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow28 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow29 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow30 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell114 As DevExpress.XtraReports.UI.XRTableCell

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private tableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private startPeriod As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private endPeriod As DevExpress.XtraReports.UI.XRTableCell

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private LightHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private LargeHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private OddStyle5 As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle4 As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle3 As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle2 As DevExpress.XtraReports.UI.XRControlStyle

        Private OddStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle5 As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle4 As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle3 As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle2 As DevExpress.XtraReports.UI.XRControlStyle

        Private EvenStyle1 As DevExpress.XtraReports.UI.XRControlStyle

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
