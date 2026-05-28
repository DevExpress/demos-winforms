Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.DataAccess

Namespace XtraReportsDemos.VehicleInspectionReport

    Public Partial Class Report

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.VehicleInspectionReport.Report))
            Dim staticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table6 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow37 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox49 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox50 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox51 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow38 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox52 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox53 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox54 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow39 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox55 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox56 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox57 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox19 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox20 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox21 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox22 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox23 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox24 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox25 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox26 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox27 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox28 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox29 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox30 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox31 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox32 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox33 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox34 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox35 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox36 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow30 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox37 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox38 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox39 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow31 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox40 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox41 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox42 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow32 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox43 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox44 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox45 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow33 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox46 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox47 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox48 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox3 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.checkBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.checkBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox3 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox4 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox5 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox6 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox7 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox8 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox9 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox10 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox11 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox12 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox13 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox14 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox15 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox16 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox17 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox18 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.labelCurrentDate = New DevExpress.XtraReports.UI.XRLabel()
            Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table10 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow56 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell129 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox24 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell130 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell131 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox101 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell132 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow57 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell133 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox100 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell134 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell135 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox102 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell136 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.table9 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow54 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox79 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox80 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox81 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox85 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox86 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox87 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell127 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow55 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox82 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox83 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox84 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell126 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox88 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox89 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox90 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell128 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table8 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow45 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox58 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox59 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox60 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow46 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox61 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox62 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox63 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow49 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox64 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox65 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox66 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow50 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox67 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox68 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox69 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow51 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox70 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox71 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox72 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow52 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox73 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox74 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox75 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow53 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox76 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox77 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox78 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table5 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow34 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow35 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow36 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pictureBox7 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.tableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.table7 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow40 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox10 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.checkBox11 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.checkBox12 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow41 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow42 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox91 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox92 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox93 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow43 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow44 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox94 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox95 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox96 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow47 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow48 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox97 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox98 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox99 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.tableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.EditorKeyStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EditorValueStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GeneralTextStyleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SectionTitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.parameterLanguage = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.table6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table6, Me.label6, Me.table4, Me.table3, Me.pictureBox4, Me.label4, Me.label3, Me.label2, Me.table2, Me.table1})
            Me.Detail.Name = "Detail"
            Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
            ' 
            ' table6
            ' 
            Me.table6.Name = "table6"
            Me.table6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow37, Me.tableRow38, Me.tableRow39})
            ' 
            ' tableRow37
            ' 
            Me.tableRow37.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell73, Me.tableCell74})
            Me.tableRow37.Name = "tableRow37"
            ' 
            ' tableCell73
            ' 
            Me.tableCell73.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox49, Me.xrCheckBox50, Me.xrCheckBox51})
            Me.tableCell73.Multiline = True
            Me.tableCell73.Name = "tableCell73"
            ' 
            ' xrCheckBox49
            ' 
            Me.xrCheckBox49.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox49.Checked = True
            Me.xrCheckBox49.EditOptions.Enabled = True
            Me.xrCheckBox49.EditOptions.GroupID = "Battery Charge"
            Me.xrCheckBox49.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox49.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox49.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox49.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox49.Name = "xrCheckBox49"
            Me.xrCheckBox49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox50
            ' 
            Me.xrCheckBox50.EditOptions.Enabled = True
            Me.xrCheckBox50.EditOptions.GroupID = "Battery Charge"
            Me.xrCheckBox50.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox50.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox50.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox50.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox50.Name = "xrCheckBox50"
            Me.xrCheckBox50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox51
            ' 
            Me.xrCheckBox51.EditOptions.Enabled = True
            Me.xrCheckBox51.EditOptions.GroupID = "Battery Charge"
            Me.xrCheckBox51.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox51.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox51.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox51.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox51.Name = "xrCheckBox51"
            Me.xrCheckBox51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell74
            ' 
            Me.tableCell74.Multiline = True
            Me.tableCell74.Name = "tableCell74"
            Me.tableCell74.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow38
            ' 
            Me.tableRow38.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell75, Me.tableCell76})
            Me.tableRow38.Name = "tableRow38"
            ' 
            ' tableCell75
            ' 
            Me.tableCell75.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox52, Me.xrCheckBox53, Me.xrCheckBox54})
            Me.tableCell75.Multiline = True
            Me.tableCell75.Name = "tableCell75"
            ' 
            ' xrCheckBox52
            ' 
            Me.xrCheckBox52.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox52.Checked = True
            Me.xrCheckBox52.EditOptions.Enabled = True
            Me.xrCheckBox52.EditOptions.GroupID = "Battery Condition"
            Me.xrCheckBox52.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox52.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox52.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox52.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox52.Name = "xrCheckBox52"
            Me.xrCheckBox52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox53
            ' 
            Me.xrCheckBox53.EditOptions.Enabled = True
            Me.xrCheckBox53.EditOptions.GroupID = "Battery Condition"
            Me.xrCheckBox53.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox53.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox53.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox53.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox53.Name = "xrCheckBox53"
            Me.xrCheckBox53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox54
            ' 
            Me.xrCheckBox54.EditOptions.Enabled = True
            Me.xrCheckBox54.EditOptions.GroupID = "Battery Condition"
            Me.xrCheckBox54.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox54.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox54.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox54.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox54.Name = "xrCheckBox54"
            Me.xrCheckBox54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell76
            ' 
            Me.tableCell76.Multiline = True
            Me.tableCell76.Name = "tableCell76"
            Me.tableCell76.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow39
            ' 
            Me.tableRow39.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell77, Me.tableCell78})
            Me.tableRow39.Name = "tableRow39"
            ' 
            ' tableCell77
            ' 
            Me.tableCell77.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox55, Me.xrCheckBox56, Me.xrCheckBox57})
            Me.tableCell77.Multiline = True
            Me.tableCell77.Name = "tableCell77"
            ' 
            ' xrCheckBox55
            ' 
            Me.xrCheckBox55.EditOptions.Enabled = True
            Me.xrCheckBox55.EditOptions.GroupID = "Cables & Connections"
            Me.xrCheckBox55.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox55.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox55.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox55.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox55.Name = "xrCheckBox55"
            Me.xrCheckBox55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox56
            ' 
            Me.xrCheckBox56.EditOptions.Enabled = True
            Me.xrCheckBox56.EditOptions.GroupID = "Cables & Connections"
            Me.xrCheckBox56.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox56.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox56.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox56.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox56.Name = "xrCheckBox56"
            Me.xrCheckBox56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox57
            ' 
            Me.xrCheckBox57.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox57.Checked = True
            Me.xrCheckBox57.EditOptions.Enabled = True
            Me.xrCheckBox57.EditOptions.GroupID = "Cables & Connections"
            Me.xrCheckBox57.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox57.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox57.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox57.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox57.Name = "xrCheckBox57"
            Me.xrCheckBox57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell78
            ' 
            Me.tableCell78.Multiline = True
            Me.tableCell78.Name = "tableCell78"
            Me.tableCell78.StyleName = "GeneralTextStyleStyle"
            ' 
            ' label6
            ' 
            Me.label6.Multiline = True
            Me.label6.Name = "label6"
            Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label6.StyleName = "EditorKeyStyle"
            ' 
            ' table4
            ' 
            Me.table4.Name = "table4"
            Me.table4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow24, Me.tableRow25, Me.tableRow26, Me.tableRow27, Me.tableRow28, Me.tableRow29, Me.tableRow30, Me.tableRow31, Me.tableRow32, Me.tableRow33})
            ' 
            ' tableRow24
            ' 
            Me.tableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell47, Me.tableCell48})
            Me.tableRow24.Name = "tableRow24"
            ' 
            ' tableCell47
            ' 
            Me.tableCell47.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox19, Me.xrCheckBox20, Me.xrCheckBox21})
            Me.tableCell47.Multiline = True
            Me.tableCell47.Name = "tableCell47"
            ' 
            ' xrCheckBox19
            ' 
            Me.xrCheckBox19.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox19.Checked = True
            Me.xrCheckBox19.EditOptions.Enabled = True
            Me.xrCheckBox19.EditOptions.GroupID = "Engine Oil"
            Me.xrCheckBox19.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox19.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox19.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox19.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox19.Name = "xrCheckBox19"
            Me.xrCheckBox19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox20
            ' 
            Me.xrCheckBox20.EditOptions.Enabled = True
            Me.xrCheckBox20.EditOptions.GroupID = "Engine Oil"
            Me.xrCheckBox20.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox20.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox20.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox20.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox20.Name = "xrCheckBox20"
            Me.xrCheckBox20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox21
            ' 
            Me.xrCheckBox21.EditOptions.Enabled = True
            Me.xrCheckBox21.EditOptions.GroupID = "Engine Oil"
            Me.xrCheckBox21.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox21.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox21.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox21.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox21.Name = "xrCheckBox21"
            Me.xrCheckBox21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell48
            ' 
            Me.tableCell48.Multiline = True
            Me.tableCell48.Name = "tableCell48"
            Me.tableCell48.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow25
            ' 
            Me.tableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell49, Me.tableCell50})
            Me.tableRow25.Name = "tableRow25"
            ' 
            ' tableCell49
            ' 
            Me.tableCell49.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox22, Me.xrCheckBox23, Me.xrCheckBox24})
            Me.tableCell49.Multiline = True
            Me.tableCell49.Name = "tableCell49"
            ' 
            ' xrCheckBox22
            ' 
            Me.xrCheckBox22.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox22.Checked = True
            Me.xrCheckBox22.EditOptions.Enabled = True
            Me.xrCheckBox22.EditOptions.GroupID = "Brake Fluid"
            Me.xrCheckBox22.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox22.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox22.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox22.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox22.Name = "xrCheckBox22"
            Me.xrCheckBox22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox23
            ' 
            Me.xrCheckBox23.EditOptions.Enabled = True
            Me.xrCheckBox23.EditOptions.GroupID = "Brake Fluid"
            Me.xrCheckBox23.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox23.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox23.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox23.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox23.Name = "xrCheckBox23"
            Me.xrCheckBox23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox24
            ' 
            Me.xrCheckBox24.EditOptions.Enabled = True
            Me.xrCheckBox24.EditOptions.GroupID = "Brake Fluid"
            Me.xrCheckBox24.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox24.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox24.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox24.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox24.Name = "xrCheckBox24"
            Me.xrCheckBox24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell50
            ' 
            Me.tableCell50.Multiline = True
            Me.tableCell50.Name = "tableCell50"
            Me.tableCell50.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow26
            ' 
            Me.tableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell51, Me.tableCell52})
            Me.tableRow26.Name = "tableRow26"
            ' 
            ' tableCell51
            ' 
            Me.tableCell51.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox25, Me.xrCheckBox26, Me.xrCheckBox27})
            Me.tableCell51.Multiline = True
            Me.tableCell51.Name = "tableCell51"
            ' 
            ' xrCheckBox25
            ' 
            Me.xrCheckBox25.EditOptions.Enabled = True
            Me.xrCheckBox25.EditOptions.GroupID = "Power Steering Fluid"
            Me.xrCheckBox25.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox25.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox25.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox25.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox25.Name = "xrCheckBox25"
            Me.xrCheckBox25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox26
            ' 
            Me.xrCheckBox26.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox26.Checked = True
            Me.xrCheckBox26.EditOptions.Enabled = True
            Me.xrCheckBox26.EditOptions.GroupID = "Power Steering Fluid"
            Me.xrCheckBox26.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox26.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox26.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox26.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox26.Name = "xrCheckBox26"
            Me.xrCheckBox26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox27
            ' 
            Me.xrCheckBox27.EditOptions.Enabled = True
            Me.xrCheckBox27.EditOptions.GroupID = "Power Steering Fluid"
            Me.xrCheckBox27.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox27.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox27.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox27.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox27.Name = "xrCheckBox27"
            Me.xrCheckBox27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell52
            ' 
            Me.tableCell52.Multiline = True
            Me.tableCell52.Name = "tableCell52"
            Me.tableCell52.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow27
            ' 
            Me.tableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell53, Me.tableCell54})
            Me.tableRow27.Name = "tableRow27"
            ' 
            ' tableCell53
            ' 
            Me.tableCell53.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox28, Me.xrCheckBox29, Me.xrCheckBox30})
            Me.tableCell53.Multiline = True
            Me.tableCell53.Name = "tableCell53"
            ' 
            ' xrCheckBox28
            ' 
            Me.xrCheckBox28.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox28.Checked = True
            Me.xrCheckBox28.EditOptions.Enabled = True
            Me.xrCheckBox28.EditOptions.GroupID = "Washer Fluid"
            Me.xrCheckBox28.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox28.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox28.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox28.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox28.Name = "xrCheckBox28"
            Me.xrCheckBox28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox29
            ' 
            Me.xrCheckBox29.EditOptions.Enabled = True
            Me.xrCheckBox29.EditOptions.GroupID = "Washer Fluid"
            Me.xrCheckBox29.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox29.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox29.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox29.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox29.Name = "xrCheckBox29"
            Me.xrCheckBox29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox30
            ' 
            Me.xrCheckBox30.EditOptions.Enabled = True
            Me.xrCheckBox30.EditOptions.GroupID = "Washer Fluid"
            Me.xrCheckBox30.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox30.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox30.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox30.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox30.Name = "xrCheckBox30"
            Me.xrCheckBox30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell54
            ' 
            Me.tableCell54.Multiline = True
            Me.tableCell54.Name = "tableCell54"
            Me.tableCell54.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow28
            ' 
            Me.tableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell55, Me.tableCell56})
            Me.tableRow28.Name = "tableRow28"
            ' 
            ' tableCell55
            ' 
            Me.tableCell55.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox31, Me.xrCheckBox32, Me.xrCheckBox33})
            Me.tableCell55.Multiline = True
            Me.tableCell55.Name = "tableCell55"
            ' 
            ' xrCheckBox31
            ' 
            Me.xrCheckBox31.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox31.Checked = True
            Me.xrCheckBox31.EditOptions.Enabled = True
            Me.xrCheckBox31.EditOptions.GroupID = "Belts & Hoses"
            Me.xrCheckBox31.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox31.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox31.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox31.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox31.Name = "xrCheckBox31"
            Me.xrCheckBox31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox32
            ' 
            Me.xrCheckBox32.EditOptions.Enabled = True
            Me.xrCheckBox32.EditOptions.GroupID = "Belts & Hoses"
            Me.xrCheckBox32.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox32.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox32.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox32.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox32.Name = "xrCheckBox32"
            Me.xrCheckBox32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox33
            ' 
            Me.xrCheckBox33.EditOptions.Enabled = True
            Me.xrCheckBox33.EditOptions.GroupID = "Belts & Hoses"
            Me.xrCheckBox33.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox33.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox33.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox33.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox33.Name = "xrCheckBox33"
            Me.xrCheckBox33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell56
            ' 
            Me.tableCell56.Multiline = True
            Me.tableCell56.Name = "tableCell56"
            Me.tableCell56.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow29
            ' 
            Me.tableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell57, Me.tableCell58})
            Me.tableRow29.Name = "tableRow29"
            ' 
            ' tableCell57
            ' 
            Me.tableCell57.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox34, Me.xrCheckBox35, Me.xrCheckBox36})
            Me.tableCell57.Multiline = True
            Me.tableCell57.Name = "tableCell57"
            ' 
            ' xrCheckBox34
            ' 
            Me.xrCheckBox34.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox34.Checked = True
            Me.xrCheckBox34.EditOptions.Enabled = True
            Me.xrCheckBox34.EditOptions.GroupID = "Antifreeze / Coolant"
            Me.xrCheckBox34.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox34.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox34.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox34.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox34.Name = "xrCheckBox34"
            Me.xrCheckBox34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox35
            ' 
            Me.xrCheckBox35.EditOptions.Enabled = True
            Me.xrCheckBox35.EditOptions.GroupID = "Antifreeze / Coolant"
            Me.xrCheckBox35.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox35.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox35.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox35.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox35.Name = "xrCheckBox35"
            Me.xrCheckBox35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox36
            ' 
            Me.xrCheckBox36.EditOptions.Enabled = True
            Me.xrCheckBox36.EditOptions.GroupID = "Antifreeze / Coolant"
            Me.xrCheckBox36.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox36.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox36.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox36.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox36.Name = "xrCheckBox36"
            Me.xrCheckBox36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell58
            ' 
            Me.tableCell58.Multiline = True
            Me.tableCell58.Name = "tableCell58"
            Me.tableCell58.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow30
            ' 
            Me.tableRow30.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell59, Me.tableCell60})
            Me.tableRow30.Name = "tableRow30"
            ' 
            ' tableCell59
            ' 
            Me.tableCell59.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox37, Me.xrCheckBox38, Me.xrCheckBox39})
            Me.tableCell59.Multiline = True
            Me.tableCell59.Name = "tableCell59"
            ' 
            ' xrCheckBox37
            ' 
            Me.xrCheckBox37.EditOptions.Enabled = True
            Me.xrCheckBox37.EditOptions.GroupID = "Air Filter"
            Me.xrCheckBox37.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox37.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox37.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox37.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox37.Name = "xrCheckBox37"
            Me.xrCheckBox37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox38
            ' 
            Me.xrCheckBox38.EditOptions.Enabled = True
            Me.xrCheckBox38.EditOptions.GroupID = "Air Filter"
            Me.xrCheckBox38.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox38.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox38.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox38.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox38.Name = "xrCheckBox38"
            Me.xrCheckBox38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox39
            ' 
            Me.xrCheckBox39.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox39.Checked = True
            Me.xrCheckBox39.EditOptions.Enabled = True
            Me.xrCheckBox39.EditOptions.GroupID = "Air Filter"
            Me.xrCheckBox39.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox39.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox39.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox39.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox39.Name = "xrCheckBox39"
            Me.xrCheckBox39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell60
            ' 
            Me.tableCell60.Multiline = True
            Me.tableCell60.Name = "tableCell60"
            Me.tableCell60.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow31
            ' 
            Me.tableRow31.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell61, Me.tableCell62})
            Me.tableRow31.Name = "tableRow31"
            ' 
            ' tableCell61
            ' 
            Me.tableCell61.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox40, Me.xrCheckBox41, Me.xrCheckBox42})
            Me.tableCell61.Multiline = True
            Me.tableCell61.Name = "tableCell61"
            ' 
            ' xrCheckBox40
            ' 
            Me.xrCheckBox40.EditOptions.Enabled = True
            Me.xrCheckBox40.EditOptions.GroupID = "Cabin Filter"
            Me.xrCheckBox40.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox40.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox40.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox40.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox40.Name = "xrCheckBox40"
            Me.xrCheckBox40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox41
            ' 
            Me.xrCheckBox41.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox41.Checked = True
            Me.xrCheckBox41.EditOptions.Enabled = True
            Me.xrCheckBox41.EditOptions.GroupID = "Cabin Filter"
            Me.xrCheckBox41.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox41.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox41.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox41.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox41.Name = "xrCheckBox41"
            Me.xrCheckBox41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox42
            ' 
            Me.xrCheckBox42.EditOptions.Enabled = True
            Me.xrCheckBox42.EditOptions.GroupID = "Cabin Filter"
            Me.xrCheckBox42.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox42.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox42.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox42.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox42.Name = "xrCheckBox42"
            Me.xrCheckBox42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell62
            ' 
            Me.tableCell62.Multiline = True
            Me.tableCell62.Name = "tableCell62"
            Me.tableCell62.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow32
            ' 
            Me.tableRow32.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell63, Me.tableCell64})
            Me.tableRow32.Name = "tableRow32"
            ' 
            ' tableCell63
            ' 
            Me.tableCell63.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox43, Me.xrCheckBox44, Me.xrCheckBox45})
            Me.tableCell63.Multiline = True
            Me.tableCell63.Name = "tableCell63"
            ' 
            ' xrCheckBox43
            ' 
            Me.xrCheckBox43.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox43.Checked = True
            Me.xrCheckBox43.EditOptions.Enabled = True
            Me.xrCheckBox43.EditOptions.GroupID = "Fuel Filter"
            Me.xrCheckBox43.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox43.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox43.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox43.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox43.Name = "xrCheckBox43"
            Me.xrCheckBox43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox44
            ' 
            Me.xrCheckBox44.EditOptions.Enabled = True
            Me.xrCheckBox44.EditOptions.GroupID = "Fuel Filter"
            Me.xrCheckBox44.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox44.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox44.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox44.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox44.Name = "xrCheckBox44"
            Me.xrCheckBox44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox45
            ' 
            Me.xrCheckBox45.EditOptions.Enabled = True
            Me.xrCheckBox45.EditOptions.GroupID = "Fuel Filter"
            Me.xrCheckBox45.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox45.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox45.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox45.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox45.Name = "xrCheckBox45"
            Me.xrCheckBox45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell64
            ' 
            Me.tableCell64.Multiline = True
            Me.tableCell64.Name = "tableCell64"
            Me.tableCell64.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow33
            ' 
            Me.tableRow33.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell65, Me.tableCell66})
            Me.tableRow33.Name = "tableRow33"
            ' 
            ' tableCell65
            ' 
            Me.tableCell65.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox46, Me.xrCheckBox47, Me.xrCheckBox48})
            Me.tableCell65.Multiline = True
            Me.tableCell65.Name = "tableCell65"
            ' 
            ' xrCheckBox46
            ' 
            Me.xrCheckBox46.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox46.Checked = True
            Me.xrCheckBox46.EditOptions.Enabled = True
            Me.xrCheckBox46.EditOptions.GroupID = "Spark Plugs / Wires"
            Me.xrCheckBox46.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox46.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox46.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox46.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox46.Name = "xrCheckBox46"
            Me.xrCheckBox46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox47
            ' 
            Me.xrCheckBox47.EditOptions.Enabled = True
            Me.xrCheckBox47.EditOptions.GroupID = "Spark Plugs / Wires"
            Me.xrCheckBox47.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox47.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox47.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox47.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox47.Name = "xrCheckBox47"
            Me.xrCheckBox47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox48
            ' 
            Me.xrCheckBox48.EditOptions.Enabled = True
            Me.xrCheckBox48.EditOptions.GroupID = "Spark Plugs / Wires"
            Me.xrCheckBox48.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox48.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox48.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox48.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox48.Name = "xrCheckBox48"
            Me.xrCheckBox48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell66
            ' 
            Me.tableCell66.Multiline = True
            Me.tableCell66.Name = "tableCell66"
            Me.tableCell66.StyleName = "GeneralTextStyleStyle"
            ' 
            ' table3
            ' 
            Me.table3.Name = "table3"
            Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow17, Me.tableRow18, Me.tableRow19, Me.tableRow20, Me.tableRow21, Me.tableRow22, Me.tableRow23})
            ' 
            ' tableRow17
            ' 
            Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell33, Me.tableCell34})
            Me.tableRow17.Name = "tableRow17"
            ' 
            ' tableCell33
            ' 
            Me.tableCell33.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox3, Me.checkBox2, Me.checkBox1})
            Me.tableCell33.Multiline = True
            Me.tableCell33.Name = "tableCell33"
            ' 
            ' checkBox3
            ' 
            Me.checkBox3.EditOptions.Enabled = True
            Me.checkBox3.EditOptions.GroupID = "Exterior Body"
            Me.checkBox3.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox3.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.checkBox3.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.checkBox3.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' checkBox2
            ' 
            Me.checkBox2.EditOptions.Enabled = True
            Me.checkBox2.EditOptions.GroupID = "Exterior Body"
            Me.checkBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox2.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.checkBox2.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.checkBox2.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.checkBox1.Checked = True
            Me.checkBox1.EditOptions.Enabled = True
            Me.checkBox1.EditOptions.GroupID = "Exterior Body"
            Me.checkBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox1.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.checkBox1.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.checkBox1.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell34
            ' 
            Me.tableCell34.Multiline = True
            Me.tableCell34.Name = "tableCell34"
            Me.tableCell34.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow18
            ' 
            Me.tableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell35, Me.tableCell36})
            Me.tableRow18.Name = "tableRow18"
            ' 
            ' tableCell35
            ' 
            Me.tableCell35.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox1, Me.xrCheckBox2, Me.xrCheckBox3})
            Me.tableCell35.Multiline = True
            Me.tableCell35.Name = "tableCell35"
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.EditOptions.Enabled = True
            Me.xrCheckBox1.EditOptions.GroupID = "Windshield / Glass"
            Me.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox1.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox2
            ' 
            Me.xrCheckBox2.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox2.Checked = True
            Me.xrCheckBox2.EditOptions.Enabled = True
            Me.xrCheckBox2.EditOptions.GroupID = "Windshield / Glass"
            Me.xrCheckBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox2.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox2.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox2.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox2.Name = "xrCheckBox2"
            Me.xrCheckBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox3
            ' 
            Me.xrCheckBox3.EditOptions.Enabled = True
            Me.xrCheckBox3.EditOptions.GroupID = "Windshield / Glass"
            Me.xrCheckBox3.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox3.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox3.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox3.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox3.Name = "xrCheckBox3"
            Me.xrCheckBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell36
            ' 
            Me.tableCell36.Multiline = True
            Me.tableCell36.Name = "tableCell36"
            Me.tableCell36.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow19
            ' 
            Me.tableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell37, Me.tableCell38})
            Me.tableRow19.Name = "tableRow19"
            ' 
            ' tableCell37
            ' 
            Me.tableCell37.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox4, Me.xrCheckBox5, Me.xrCheckBox6})
            Me.tableCell37.Multiline = True
            Me.tableCell37.Name = "tableCell37"
            ' 
            ' xrCheckBox4
            ' 
            Me.xrCheckBox4.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox4.Checked = True
            Me.xrCheckBox4.EditOptions.Enabled = True
            Me.xrCheckBox4.EditOptions.GroupID = "Wipers"
            Me.xrCheckBox4.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox4.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox4.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox4.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox4.Name = "xrCheckBox4"
            Me.xrCheckBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox5
            ' 
            Me.xrCheckBox5.EditOptions.Enabled = True
            Me.xrCheckBox5.EditOptions.GroupID = "Wipers"
            Me.xrCheckBox5.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox5.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox5.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox5.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox5.Name = "xrCheckBox5"
            Me.xrCheckBox5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox6
            ' 
            Me.xrCheckBox6.EditOptions.Enabled = True
            Me.xrCheckBox6.EditOptions.GroupID = "Wipers"
            Me.xrCheckBox6.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox6.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox6.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox6.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox6.Name = "xrCheckBox6"
            Me.xrCheckBox6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell38
            ' 
            Me.tableCell38.Multiline = True
            Me.tableCell38.Name = "tableCell38"
            Me.tableCell38.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow20
            ' 
            Me.tableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell39, Me.tableCell40})
            Me.tableRow20.Name = "tableRow20"
            ' 
            ' tableCell39
            ' 
            Me.tableCell39.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox7, Me.xrCheckBox8, Me.xrCheckBox9})
            Me.tableCell39.Multiline = True
            Me.tableCell39.Name = "tableCell39"
            ' 
            ' xrCheckBox7
            ' 
            Me.xrCheckBox7.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox7.Checked = True
            Me.xrCheckBox7.EditOptions.Enabled = True
            Me.xrCheckBox7.EditOptions.GroupID = "Lights (Head, Brake, Turn)"
            Me.xrCheckBox7.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox7.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox7.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox7.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox7.Name = "xrCheckBox7"
            Me.xrCheckBox7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox8
            ' 
            Me.xrCheckBox8.EditOptions.Enabled = True
            Me.xrCheckBox8.EditOptions.GroupID = "Lights (Head, Brake, Turn)"
            Me.xrCheckBox8.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox8.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox8.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox8.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox8.Name = "xrCheckBox8"
            Me.xrCheckBox8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox9
            ' 
            Me.xrCheckBox9.EditOptions.Enabled = True
            Me.xrCheckBox9.EditOptions.GroupID = "Lights (Head, Brake, Turn)"
            Me.xrCheckBox9.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox9.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox9.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox9.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox9.Name = "xrCheckBox9"
            Me.xrCheckBox9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell40
            ' 
            Me.tableCell40.Multiline = True
            Me.tableCell40.Name = "tableCell40"
            Me.tableCell40.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow21
            ' 
            Me.tableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell41, Me.tableCell42})
            Me.tableRow21.Name = "tableRow21"
            ' 
            ' tableCell41
            ' 
            Me.tableCell41.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox10, Me.xrCheckBox11, Me.xrCheckBox12})
            Me.tableCell41.Multiline = True
            Me.tableCell41.Name = "tableCell41"
            ' 
            ' xrCheckBox10
            ' 
            Me.xrCheckBox10.EditOptions.Enabled = True
            Me.xrCheckBox10.EditOptions.GroupID = "Interior Lights"
            Me.xrCheckBox10.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox10.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox10.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox10.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox10.Name = "xrCheckBox10"
            Me.xrCheckBox10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox11
            ' 
            Me.xrCheckBox11.EditOptions.Enabled = True
            Me.xrCheckBox11.EditOptions.GroupID = "Interior Lights"
            Me.xrCheckBox11.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox11.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox11.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox11.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox11.Name = "xrCheckBox11"
            Me.xrCheckBox11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox12
            ' 
            Me.xrCheckBox12.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox12.Checked = True
            Me.xrCheckBox12.EditOptions.Enabled = True
            Me.xrCheckBox12.EditOptions.GroupID = "Interior Lights"
            Me.xrCheckBox12.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox12.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox12.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox12.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox12.Name = "xrCheckBox12"
            Me.xrCheckBox12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell42
            ' 
            Me.tableCell42.Multiline = True
            Me.tableCell42.Name = "tableCell42"
            Me.tableCell42.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow22
            ' 
            Me.tableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell43, Me.tableCell44})
            Me.tableRow22.Name = "tableRow22"
            ' 
            ' tableCell43
            ' 
            Me.tableCell43.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox13, Me.xrCheckBox14, Me.xrCheckBox15})
            Me.tableCell43.Multiline = True
            Me.tableCell43.Name = "tableCell43"
            ' 
            ' xrCheckBox13
            ' 
            Me.xrCheckBox13.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox13.Checked = True
            Me.xrCheckBox13.EditOptions.Enabled = True
            Me.xrCheckBox13.EditOptions.GroupID = "AC Operation"
            Me.xrCheckBox13.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox13.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox13.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox13.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox13.Name = "xrCheckBox13"
            Me.xrCheckBox13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox14
            ' 
            Me.xrCheckBox14.EditOptions.Enabled = True
            Me.xrCheckBox14.EditOptions.GroupID = "AC Operation"
            Me.xrCheckBox14.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox14.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox14.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox14.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox14.Name = "xrCheckBox14"
            Me.xrCheckBox14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox15
            ' 
            Me.xrCheckBox15.EditOptions.Enabled = True
            Me.xrCheckBox15.EditOptions.GroupID = "AC Operation"
            Me.xrCheckBox15.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox15.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox15.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox15.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox15.Name = "xrCheckBox15"
            Me.xrCheckBox15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell44
            ' 
            Me.tableCell44.Multiline = True
            Me.tableCell44.Name = "tableCell44"
            Me.tableCell44.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow23
            ' 
            Me.tableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell45, Me.tableCell46})
            Me.tableRow23.Name = "tableRow23"
            ' 
            ' tableCell45
            ' 
            Me.tableCell45.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox16, Me.xrCheckBox17, Me.xrCheckBox18})
            Me.tableCell45.Multiline = True
            Me.tableCell45.Name = "tableCell45"
            ' 
            ' xrCheckBox16
            ' 
            Me.xrCheckBox16.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox16.Checked = True
            Me.xrCheckBox16.EditOptions.Enabled = True
            Me.xrCheckBox16.EditOptions.GroupID = "Heating"
            Me.xrCheckBox16.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox16.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox16.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox16.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox16.Name = "xrCheckBox16"
            Me.xrCheckBox16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox17
            ' 
            Me.xrCheckBox17.EditOptions.Enabled = True
            Me.xrCheckBox17.EditOptions.GroupID = "Heating"
            Me.xrCheckBox17.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox17.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox17.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox17.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox17.Name = "xrCheckBox17"
            Me.xrCheckBox17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox18
            ' 
            Me.xrCheckBox18.EditOptions.Enabled = True
            Me.xrCheckBox18.EditOptions.GroupID = "Heating"
            Me.xrCheckBox18.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox18.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox18.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox18.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox18.Name = "xrCheckBox18"
            Me.xrCheckBox18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell46
            ' 
            Me.tableCell46.Multiline = True
            Me.tableCell46.Name = "tableCell46"
            Me.tableCell46.StyleName = "GeneralTextStyleStyle"
            ' 
            ' pictureBox4
            ' 
            Me.pictureBox4.EditOptions.EditorName = "DamageDiagram"
            Me.pictureBox4.EditOptions.Enabled = True
            Me.pictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            Me.pictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pictureBox4.ImageSource"))
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.UseImageResolution = False
            ' 
            ' label4
            ' 
            Me.label4.Multiline = True
            Me.label4.Name = "label4"
            Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label4.StyleName = "EditorKeyStyle"
            ' 
            ' label3
            ' 
            Me.label3.Multiline = True
            Me.label3.Name = "label3"
            Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label3.StyleName = "SectionTitleStyle"
            ' 
            ' label2
            ' 
            Me.label2.Multiline = True
            Me.label2.Name = "label2"
            Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label2.StyleName = "SectionTitleStyle"
            ' 
            ' table2
            ' 
            Me.table2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.table2.Name = "table2"
            Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.tableRow3, Me.tableRow4})
            Me.table2.StyleName = "GeneralTextStyleStyle"
            Me.table2.StylePriority.UseBackColor = False
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 20, 0, 100F)
            Me.tableRow2.StylePriority.UsePadding = False
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox1})
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.pictureBox1.Name = "pictureBox1"
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
            Me.tableRow3.StylePriority.UsePadding = False
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox2})
            Me.tableCell5.Multiline = True
            Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 6, 6, 100F)
            Me.tableCell5.Name = "tableCell5"
            ' 
            ' pictureBox2
            ' 
            Me.pictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.pictureBox2.Name = "pictureBox2"
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell8})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 20, 100F)
            Me.tableRow4.StylePriority.UsePadding = False
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox3})
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            ' 
            ' pictureBox3
            ' 
            Me.pictureBox3.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.pictureBox3.Name = "pictureBox3"
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            ' 
            ' table1
            ' 
            Me.table1.Name = "table1"
            Me.table1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1, Me.tableRow5, Me.tableRow6, Me.tableRow7, Me.tableRow8, Me.tableRow9, Me.tableRow10, Me.tableRow11, Me.tableRow12, Me.tableRow13, Me.tableRow14, Me.tableRow15, Me.tableRow16})
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "EditorKeyStyle"
            Me.tableCell1.StylePriority.UseFont = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.EditOptions.Enabled = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "EditorValueStyle"
            Me.tableCell2.StylePriority.UseBorderColor = False
            Me.tableCell2.StylePriority.UseBorderWidth = False
            Me.tableCell2.StylePriority.UseFont = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9, Me.tableCell10})
            Me.tableRow5.Name = "tableRow5"
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.Multiline = True
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StylePriority.UseFont = False
            Me.tableCell9.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StylePriority.UseBorderColor = False
            Me.tableCell10.StylePriority.UseBorderWidth = False
            Me.tableCell10.StylePriority.UseFont = False
            Me.tableCell10.StylePriority.UsePadding = False
            Me.tableCell10.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow6
            ' 
            Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell11, Me.tableCell12})
            Me.tableRow6.Name = "tableRow6"
            ' 
            ' tableCell11
            ' 
            Me.tableCell11.Multiline = True
            Me.tableCell11.Name = "tableCell11"
            Me.tableCell11.StyleName = "EditorKeyStyle"
            Me.tableCell11.StylePriority.UseFont = False
            Me.tableCell11.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.EditOptions.Enabled = True
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.StyleName = "EditorValueStyle"
            Me.tableCell12.StylePriority.UseBorderColor = False
            Me.tableCell12.StylePriority.UseBorderWidth = False
            Me.tableCell12.StylePriority.UseFont = False
            Me.tableCell12.StylePriority.UsePadding = False
            Me.tableCell12.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow7
            ' 
            Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell14})
            Me.tableRow7.Name = "tableRow7"
            ' 
            ' tableCell13
            ' 
            Me.tableCell13.Multiline = True
            Me.tableCell13.Name = "tableCell13"
            Me.tableCell13.StylePriority.UseFont = False
            Me.tableCell13.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell14
            ' 
            Me.tableCell14.Multiline = True
            Me.tableCell14.Name = "tableCell14"
            Me.tableCell14.StylePriority.UseBorderColor = False
            Me.tableCell14.StylePriority.UseBorderWidth = False
            Me.tableCell14.StylePriority.UseFont = False
            Me.tableCell14.StylePriority.UsePadding = False
            Me.tableCell14.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow8
            ' 
            Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15, Me.tableCell16})
            Me.tableRow8.Name = "tableRow8"
            ' 
            ' tableCell15
            ' 
            Me.tableCell15.Multiline = True
            Me.tableCell15.Name = "tableCell15"
            Me.tableCell15.StyleName = "EditorKeyStyle"
            Me.tableCell15.StylePriority.UseFont = False
            Me.tableCell15.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell16
            ' 
            Me.tableCell16.EditOptions.Enabled = True
            Me.tableCell16.Multiline = True
            Me.tableCell16.Name = "tableCell16"
            Me.tableCell16.StyleName = "EditorValueStyle"
            Me.tableCell16.StylePriority.UseBorderColor = False
            Me.tableCell16.StylePriority.UseBorderWidth = False
            Me.tableCell16.StylePriority.UseFont = False
            Me.tableCell16.StylePriority.UsePadding = False
            Me.tableCell16.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow9
            ' 
            Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17, Me.tableCell18})
            Me.tableRow9.Name = "tableRow9"
            ' 
            ' tableCell17
            ' 
            Me.tableCell17.Multiline = True
            Me.tableCell17.Name = "tableCell17"
            Me.tableCell17.StylePriority.UseFont = False
            Me.tableCell17.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell18
            ' 
            Me.tableCell18.Multiline = True
            Me.tableCell18.Name = "tableCell18"
            Me.tableCell18.StylePriority.UseBorderColor = False
            Me.tableCell18.StylePriority.UseBorderWidth = False
            Me.tableCell18.StylePriority.UseFont = False
            Me.tableCell18.StylePriority.UsePadding = False
            Me.tableCell18.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow10
            ' 
            Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell19, Me.tableCell20})
            Me.tableRow10.Name = "tableRow10"
            ' 
            ' tableCell19
            ' 
            Me.tableCell19.Multiline = True
            Me.tableCell19.Name = "tableCell19"
            Me.tableCell19.StyleName = "EditorKeyStyle"
            Me.tableCell19.StylePriority.UseFont = False
            Me.tableCell19.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell20
            ' 
            Me.tableCell20.EditOptions.Enabled = True
            Me.tableCell20.Multiline = True
            Me.tableCell20.Name = "tableCell20"
            Me.tableCell20.StyleName = "EditorValueStyle"
            Me.tableCell20.StylePriority.UseBorderColor = False
            Me.tableCell20.StylePriority.UseBorderWidth = False
            Me.tableCell20.StylePriority.UseFont = False
            Me.tableCell20.StylePriority.UsePadding = False
            Me.tableCell20.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow11
            ' 
            Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21, Me.tableCell22})
            Me.tableRow11.Name = "tableRow11"
            ' 
            ' tableCell21
            ' 
            Me.tableCell21.Multiline = True
            Me.tableCell21.Name = "tableCell21"
            Me.tableCell21.StylePriority.UseFont = False
            Me.tableCell21.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell22
            ' 
            Me.tableCell22.Multiline = True
            Me.tableCell22.Name = "tableCell22"
            Me.tableCell22.StylePriority.UseBorderColor = False
            Me.tableCell22.StylePriority.UseBorderWidth = False
            Me.tableCell22.StylePriority.UseFont = False
            Me.tableCell22.StylePriority.UsePadding = False
            Me.tableCell22.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow12
            ' 
            Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell23, Me.tableCell24})
            Me.tableRow12.Name = "tableRow12"
            ' 
            ' tableCell23
            ' 
            Me.tableCell23.Multiline = True
            Me.tableCell23.Name = "tableCell23"
            Me.tableCell23.StyleName = "EditorKeyStyle"
            Me.tableCell23.StylePriority.UseFont = False
            Me.tableCell23.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell24
            ' 
            Me.tableCell24.EditOptions.Enabled = True
            Me.tableCell24.Multiline = True
            Me.tableCell24.Name = "tableCell24"
            Me.tableCell24.StyleName = "EditorValueStyle"
            Me.tableCell24.StylePriority.UseBorderColor = False
            Me.tableCell24.StylePriority.UseBorderWidth = False
            Me.tableCell24.StylePriority.UseFont = False
            Me.tableCell24.StylePriority.UsePadding = False
            Me.tableCell24.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow13
            ' 
            Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell25, Me.tableCell26})
            Me.tableRow13.Name = "tableRow13"
            ' 
            ' tableCell25
            ' 
            Me.tableCell25.Multiline = True
            Me.tableCell25.Name = "tableCell25"
            Me.tableCell25.StylePriority.UseFont = False
            Me.tableCell25.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell26
            ' 
            Me.tableCell26.Multiline = True
            Me.tableCell26.Name = "tableCell26"
            Me.tableCell26.StylePriority.UseBorderColor = False
            Me.tableCell26.StylePriority.UseBorderWidth = False
            Me.tableCell26.StylePriority.UseFont = False
            Me.tableCell26.StylePriority.UsePadding = False
            Me.tableCell26.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow14
            ' 
            Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell27, Me.tableCell28})
            Me.tableRow14.Name = "tableRow14"
            ' 
            ' tableCell27
            ' 
            Me.tableCell27.Multiline = True
            Me.tableCell27.Name = "tableCell27"
            Me.tableCell27.StyleName = "EditorKeyStyle"
            Me.tableCell27.StylePriority.UseFont = False
            Me.tableCell27.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell28
            ' 
            Me.tableCell28.EditOptions.Enabled = True
            Me.tableCell28.Multiline = True
            Me.tableCell28.Name = "tableCell28"
            Me.tableCell28.StyleName = "EditorValueStyle"
            Me.tableCell28.StylePriority.UseBorderColor = False
            Me.tableCell28.StylePriority.UseBorderWidth = False
            Me.tableCell28.StylePriority.UseFont = False
            Me.tableCell28.StylePriority.UsePadding = False
            Me.tableCell28.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow15
            ' 
            Me.tableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell29, Me.tableCell30})
            Me.tableRow15.Name = "tableRow15"
            ' 
            ' tableCell29
            ' 
            Me.tableCell29.Multiline = True
            Me.tableCell29.Name = "tableCell29"
            Me.tableCell29.StylePriority.UseFont = False
            Me.tableCell29.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell30
            ' 
            Me.tableCell30.Multiline = True
            Me.tableCell30.Name = "tableCell30"
            Me.tableCell30.StylePriority.UseBorderColor = False
            Me.tableCell30.StylePriority.UseBorderWidth = False
            Me.tableCell30.StylePriority.UseFont = False
            Me.tableCell30.StylePriority.UsePadding = False
            Me.tableCell30.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow16
            ' 
            Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell31, Me.tableCell32})
            Me.tableRow16.Name = "tableRow16"
            ' 
            ' tableCell31
            ' 
            Me.tableCell31.Multiline = True
            Me.tableCell31.Name = "tableCell31"
            Me.tableCell31.StyleName = "EditorKeyStyle"
            Me.tableCell31.StylePriority.UseFont = False
            Me.tableCell31.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell32
            ' 
            Me.tableCell32.EditOptions.Enabled = True
            Me.tableCell32.Multiline = True
            Me.tableCell32.Name = "tableCell32"
            Me.tableCell32.StyleName = "EditorValueStyle"
            Me.tableCell32.StylePriority.UseBorderColor = False
            Me.tableCell32.StylePriority.UseBorderWidth = False
            Me.tableCell32.StylePriority.UseFont = False
            Me.tableCell32.StylePriority.UsePadding = False
            Me.tableCell32.StylePriority.UseTextAlignment = False
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.labelCurrentDate, Me.label15, Me.label14, Me.label13, Me.label12, Me.label11, Me.label10, Me.table10, Me.table9, Me.label9, Me.table8, Me.label8, Me.label5, Me.table5, Me.label7, Me.table7})
            Me.SubBand1.KeepTogether = True
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' labelCurrentDate
            ' 
            Me.labelCurrentDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
            Me.labelCurrentDate.Multiline = True
            Me.labelCurrentDate.Name = "labelCurrentDate"
            Me.labelCurrentDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 2, 2, 100F)
            Me.labelCurrentDate.StyleName = "EditorValueStyle"
            Me.labelCurrentDate.StylePriority.UsePadding = False
            Me.labelCurrentDate.StylePriority.UseTextAlignment = False
            ' 
            ' label15
            ' 
            Me.label15.Multiline = True
            Me.label15.Name = "label15"
            Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label15.StyleName = "EditorKeyStyle"
            ' 
            ' label14
            ' 
            Me.label14.EditOptions.Enabled = True
            Me.label14.Name = "label14"
            Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 2, 2, 100F)
            Me.label14.StyleName = "EditorValueStyle"
            Me.label14.StylePriority.UsePadding = False
            Me.label14.StylePriority.UseTextAlignment = False
            ' 
            ' label13
            ' 
            Me.label13.Multiline = True
            Me.label13.Name = "label13"
            Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label13.StyleName = "EditorKeyStyle"
            ' 
            ' label12
            ' 
            Me.label12.EditOptions.Enabled = True
            Me.label12.Multiline = True
            Me.label12.Name = "label12"
            Me.label12.StyleName = "EditorValueStyle"
            Me.label12.StylePriority.UsePadding = False
            Me.label12.StylePriority.UseTextAlignment = False
            Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' label11
            ' 
            Me.label11.Multiline = True
            Me.label11.Name = "label11"
            Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label11.StyleName = "EditorKeyStyle"
            ' 
            ' label10
            ' 
            Me.label10.Multiline = True
            Me.label10.Name = "label10"
            Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label10.StyleName = "EditorKeyStyle"
            ' 
            ' table10
            ' 
            Me.table10.Name = "table10"
            Me.table10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table10.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow56, Me.tableRow57})
            ' 
            ' tableRow56
            ' 
            Me.tableRow56.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell129, Me.tableCell130, Me.tableCell131, Me.tableCell132})
            Me.tableRow56.Name = "tableRow56"
            ' 
            ' tableCell129
            ' 
            Me.tableCell129.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox24})
            Me.tableCell129.Multiline = True
            Me.tableCell129.Name = "tableCell129"
            ' 
            ' checkBox24
            ' 
            Me.checkBox24.EditOptions.Enabled = True
            Me.checkBox24.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox24.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"))
            Me.checkBox24.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"))
            Me.checkBox24.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox24.Name = "checkBox24"
            Me.checkBox24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell130
            ' 
            Me.tableCell130.Multiline = True
            Me.tableCell130.Name = "tableCell130"
            Me.tableCell130.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableCell131
            ' 
            Me.tableCell131.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox101})
            Me.tableCell131.Multiline = True
            Me.tableCell131.Name = "tableCell131"
            ' 
            ' xrCheckBox101
            ' 
            Me.xrCheckBox101.EditOptions.Enabled = True
            Me.xrCheckBox101.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox101.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"))
            Me.xrCheckBox101.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"))
            Me.xrCheckBox101.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox101.Name = "xrCheckBox101"
            Me.xrCheckBox101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell132
            ' 
            Me.tableCell132.Multiline = True
            Me.tableCell132.Name = "tableCell132"
            Me.tableCell132.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow57
            ' 
            Me.tableRow57.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell133, Me.tableCell134, Me.tableCell135, Me.tableCell136})
            Me.tableRow57.Name = "tableRow57"
            ' 
            ' tableCell133
            ' 
            Me.tableCell133.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox100})
            Me.tableCell133.Multiline = True
            Me.tableCell133.Name = "tableCell133"
            ' 
            ' xrCheckBox100
            ' 
            Me.xrCheckBox100.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox100.Checked = True
            Me.xrCheckBox100.EditOptions.Enabled = True
            Me.xrCheckBox100.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox100.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"))
            Me.xrCheckBox100.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"))
            Me.xrCheckBox100.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox100.Name = "xrCheckBox100"
            Me.xrCheckBox100.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell134
            ' 
            Me.tableCell134.Multiline = True
            Me.tableCell134.Name = "tableCell134"
            Me.tableCell134.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableCell135
            ' 
            Me.tableCell135.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox102})
            Me.tableCell135.Multiline = True
            Me.tableCell135.Name = "tableCell135"
            ' 
            ' xrCheckBox102
            ' 
            Me.xrCheckBox102.EditOptions.Enabled = True
            Me.xrCheckBox102.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox102.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"))
            Me.xrCheckBox102.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"))
            Me.xrCheckBox102.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox102.Name = "xrCheckBox102"
            Me.xrCheckBox102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell136
            ' 
            Me.tableCell136.Multiline = True
            Me.tableCell136.Name = "tableCell136"
            Me.tableCell136.StyleName = "GeneralTextStyleStyle"
            ' 
            ' table9
            ' 
            Me.table9.Name = "table9"
            Me.table9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow54, Me.tableRow55})
            ' 
            ' tableRow54
            ' 
            Me.tableRow54.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell121, Me.tableCell122, Me.tableCell125, Me.tableCell127})
            Me.tableRow54.Name = "tableRow54"
            ' 
            ' tableCell121
            ' 
            Me.tableCell121.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox79, Me.xrCheckBox80, Me.xrCheckBox81})
            Me.tableCell121.Multiline = True
            Me.tableCell121.Name = "tableCell121"
            ' 
            ' xrCheckBox79
            ' 
            Me.xrCheckBox79.EditOptions.Enabled = True
            Me.xrCheckBox79.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF"
            Me.xrCheckBox79.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox79.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox79.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox79.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox79.Name = "xrCheckBox79"
            Me.xrCheckBox79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox80
            ' 
            Me.xrCheckBox80.EditOptions.Enabled = True
            Me.xrCheckBox80.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF"
            Me.xrCheckBox80.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox80.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox80.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox80.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox80.Name = "xrCheckBox80"
            Me.xrCheckBox80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox81
            ' 
            Me.xrCheckBox81.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox81.Checked = True
            Me.xrCheckBox81.EditOptions.Enabled = True
            Me.xrCheckBox81.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF"
            Me.xrCheckBox81.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox81.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox81.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox81.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox81.Name = "xrCheckBox81"
            Me.xrCheckBox81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell122
            ' 
            Me.tableCell122.Multiline = True
            Me.tableCell122.Name = "tableCell122"
            Me.tableCell122.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableCell125
            ' 
            Me.tableCell125.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox85, Me.xrCheckBox86, Me.xrCheckBox87})
            Me.tableCell125.Multiline = True
            Me.tableCell125.Name = "tableCell125"
            ' 
            ' xrCheckBox85
            ' 
            Me.xrCheckBox85.EditOptions.Enabled = True
            Me.xrCheckBox85.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR"
            Me.xrCheckBox85.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox85.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox85.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox85.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox85.Name = "xrCheckBox85"
            Me.xrCheckBox85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox86
            ' 
            Me.xrCheckBox86.EditOptions.Enabled = True
            Me.xrCheckBox86.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR"
            Me.xrCheckBox86.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox86.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox86.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox86.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox86.Name = "xrCheckBox86"
            Me.xrCheckBox86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox87
            ' 
            Me.xrCheckBox87.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox87.Checked = True
            Me.xrCheckBox87.EditOptions.Enabled = True
            Me.xrCheckBox87.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR"
            Me.xrCheckBox87.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox87.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox87.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox87.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox87.Name = "xrCheckBox87"
            Me.xrCheckBox87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell127
            ' 
            Me.tableCell127.Multiline = True
            Me.tableCell127.Name = "tableCell127"
            Me.tableCell127.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow55
            ' 
            Me.tableRow55.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell123, Me.tableCell124, Me.tableCell126, Me.tableCell128})
            Me.tableRow55.Name = "tableRow55"
            ' 
            ' tableCell123
            ' 
            Me.tableCell123.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox82, Me.xrCheckBox83, Me.xrCheckBox84})
            Me.tableCell123.Multiline = True
            Me.tableCell123.Name = "tableCell123"
            ' 
            ' xrCheckBox82
            ' 
            Me.xrCheckBox82.EditOptions.Enabled = True
            Me.xrCheckBox82.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF"
            Me.xrCheckBox82.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox82.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox82.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox82.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox82.Name = "xrCheckBox82"
            Me.xrCheckBox82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox83
            ' 
            Me.xrCheckBox83.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox83.Checked = True
            Me.xrCheckBox83.EditOptions.Enabled = True
            Me.xrCheckBox83.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF"
            Me.xrCheckBox83.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox83.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox83.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox83.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox83.Name = "xrCheckBox83"
            Me.xrCheckBox83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox84
            ' 
            Me.xrCheckBox84.EditOptions.Enabled = True
            Me.xrCheckBox84.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF"
            Me.xrCheckBox84.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox84.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox84.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox84.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox84.Name = "xrCheckBox84"
            Me.xrCheckBox84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell124
            ' 
            Me.tableCell124.Multiline = True
            Me.tableCell124.Name = "tableCell124"
            Me.tableCell124.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableCell126
            ' 
            Me.tableCell126.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox88, Me.xrCheckBox89, Me.xrCheckBox90})
            Me.tableCell126.Multiline = True
            Me.tableCell126.Name = "tableCell126"
            ' 
            ' xrCheckBox88
            ' 
            Me.xrCheckBox88.EditOptions.Enabled = True
            Me.xrCheckBox88.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR"
            Me.xrCheckBox88.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox88.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox88.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox88.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox88.Name = "xrCheckBox88"
            Me.xrCheckBox88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox89
            ' 
            Me.xrCheckBox89.EditOptions.Enabled = True
            Me.xrCheckBox89.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR"
            Me.xrCheckBox89.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox89.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox89.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox89.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox89.Name = "xrCheckBox89"
            Me.xrCheckBox89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox90
            ' 
            Me.xrCheckBox90.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox90.Checked = True
            Me.xrCheckBox90.EditOptions.Enabled = True
            Me.xrCheckBox90.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR"
            Me.xrCheckBox90.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox90.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox90.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox90.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox90.Name = "xrCheckBox90"
            Me.xrCheckBox90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell128
            ' 
            Me.tableCell128.Multiline = True
            Me.tableCell128.Name = "tableCell128"
            Me.tableCell128.StyleName = "GeneralTextStyleStyle"
            ' 
            ' label9
            ' 
            Me.label9.Multiline = True
            Me.label9.Name = "label9"
            Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label9.StyleName = "EditorKeyStyle"
            ' 
            ' table8
            ' 
            Me.table8.Name = "table8"
            Me.table8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow45, Me.tableRow46, Me.tableRow49, Me.tableRow50, Me.tableRow51, Me.tableRow52, Me.tableRow53})
            ' 
            ' tableRow45
            ' 
            Me.tableRow45.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell107, Me.tableCell108})
            Me.tableRow45.Name = "tableRow45"
            ' 
            ' tableCell107
            ' 
            Me.tableCell107.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox58, Me.xrCheckBox59, Me.xrCheckBox60})
            Me.tableCell107.Multiline = True
            Me.tableCell107.Name = "tableCell107"
            ' 
            ' xrCheckBox58
            ' 
            Me.xrCheckBox58.EditOptions.Enabled = True
            Me.xrCheckBox58.EditOptions.GroupID = "Brakes (Pads / Shoes)"
            Me.xrCheckBox58.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox58.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox58.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox58.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox58.Name = "xrCheckBox58"
            Me.xrCheckBox58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox59
            ' 
            Me.xrCheckBox59.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox59.Checked = True
            Me.xrCheckBox59.EditOptions.Enabled = True
            Me.xrCheckBox59.EditOptions.GroupID = "Brakes (Pads / Shoes)"
            Me.xrCheckBox59.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox59.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox59.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox59.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox59.Name = "xrCheckBox59"
            Me.xrCheckBox59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox60
            ' 
            Me.xrCheckBox60.EditOptions.Enabled = True
            Me.xrCheckBox60.EditOptions.GroupID = "Brakes (Pads / Shoes)"
            Me.xrCheckBox60.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox60.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox60.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox60.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox60.Name = "xrCheckBox60"
            Me.xrCheckBox60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell108
            ' 
            Me.tableCell108.Multiline = True
            Me.tableCell108.Name = "tableCell108"
            Me.tableCell108.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow46
            ' 
            Me.tableRow46.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell109, Me.tableCell110})
            Me.tableRow46.Name = "tableRow46"
            ' 
            ' tableCell109
            ' 
            Me.tableCell109.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox61, Me.xrCheckBox62, Me.xrCheckBox63})
            Me.tableCell109.Multiline = True
            Me.tableCell109.Name = "tableCell109"
            ' 
            ' xrCheckBox61
            ' 
            Me.xrCheckBox61.EditOptions.Enabled = True
            Me.xrCheckBox61.EditOptions.GroupID = "Brake Lines / Hoses"
            Me.xrCheckBox61.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox61.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox61.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox61.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox61.Name = "xrCheckBox61"
            Me.xrCheckBox61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox62
            ' 
            Me.xrCheckBox62.EditOptions.Enabled = True
            Me.xrCheckBox62.EditOptions.GroupID = "Brake Lines / Hoses"
            Me.xrCheckBox62.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox62.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox62.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox62.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox62.Name = "xrCheckBox62"
            Me.xrCheckBox62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox63
            ' 
            Me.xrCheckBox63.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox63.Checked = True
            Me.xrCheckBox63.EditOptions.Enabled = True
            Me.xrCheckBox63.EditOptions.GroupID = "Brake Lines / Hoses"
            Me.xrCheckBox63.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox63.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox63.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox63.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox63.Name = "xrCheckBox63"
            Me.xrCheckBox63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell110
            ' 
            Me.tableCell110.Multiline = True
            Me.tableCell110.Name = "tableCell110"
            Me.tableCell110.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow49
            ' 
            Me.tableRow49.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell111, Me.tableCell112})
            Me.tableRow49.Name = "tableRow49"
            ' 
            ' tableCell111
            ' 
            Me.tableCell111.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox64, Me.xrCheckBox65, Me.xrCheckBox66})
            Me.tableCell111.Multiline = True
            Me.tableCell111.Name = "tableCell111"
            ' 
            ' xrCheckBox64
            ' 
            Me.xrCheckBox64.EditOptions.Enabled = True
            Me.xrCheckBox64.EditOptions.GroupID = "Steering System"
            Me.xrCheckBox64.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox64.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox64.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox64.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox64.Name = "xrCheckBox64"
            Me.xrCheckBox64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox65
            ' 
            Me.xrCheckBox65.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox65.Checked = True
            Me.xrCheckBox65.EditOptions.Enabled = True
            Me.xrCheckBox65.EditOptions.GroupID = "Steering System"
            Me.xrCheckBox65.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox65.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox65.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox65.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox65.Name = "xrCheckBox65"
            Me.xrCheckBox65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox66
            ' 
            Me.xrCheckBox66.EditOptions.Enabled = True
            Me.xrCheckBox66.EditOptions.GroupID = "Steering System"
            Me.xrCheckBox66.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox66.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox66.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox66.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox66.Name = "xrCheckBox66"
            Me.xrCheckBox66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell112
            ' 
            Me.tableCell112.Multiline = True
            Me.tableCell112.Name = "tableCell112"
            Me.tableCell112.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow50
            ' 
            Me.tableRow50.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell113, Me.tableCell114})
            Me.tableRow50.Name = "tableRow50"
            ' 
            ' tableCell113
            ' 
            Me.tableCell113.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox67, Me.xrCheckBox68, Me.xrCheckBox69})
            Me.tableCell113.Multiline = True
            Me.tableCell113.Name = "tableCell113"
            ' 
            ' xrCheckBox67
            ' 
            Me.xrCheckBox67.EditOptions.Enabled = True
            Me.xrCheckBox67.EditOptions.GroupID = "Shocks & Struts"
            Me.xrCheckBox67.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox67.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox67.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox67.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox67.Name = "xrCheckBox67"
            Me.xrCheckBox67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox68
            ' 
            Me.xrCheckBox68.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox68.Checked = True
            Me.xrCheckBox68.EditOptions.Enabled = True
            Me.xrCheckBox68.EditOptions.GroupID = "Shocks & Struts"
            Me.xrCheckBox68.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox68.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox68.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox68.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox68.Name = "xrCheckBox68"
            Me.xrCheckBox68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox69
            ' 
            Me.xrCheckBox69.EditOptions.Enabled = True
            Me.xrCheckBox69.EditOptions.GroupID = "Shocks & Struts"
            Me.xrCheckBox69.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox69.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox69.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox69.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox69.Name = "xrCheckBox69"
            Me.xrCheckBox69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell114
            ' 
            Me.tableCell114.Multiline = True
            Me.tableCell114.Name = "tableCell114"
            Me.tableCell114.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow51
            ' 
            Me.tableRow51.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell115, Me.tableCell116})
            Me.tableRow51.Name = "tableRow51"
            ' 
            ' tableCell115
            ' 
            Me.tableCell115.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox70, Me.xrCheckBox71, Me.xrCheckBox72})
            Me.tableCell115.Multiline = True
            Me.tableCell115.Name = "tableCell115"
            ' 
            ' xrCheckBox70
            ' 
            Me.xrCheckBox70.EditOptions.Enabled = True
            Me.xrCheckBox70.EditOptions.GroupID = "Driveline (Axles / CV Shaft)"
            Me.xrCheckBox70.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox70.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox70.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox70.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox70.Name = "xrCheckBox70"
            Me.xrCheckBox70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox71
            ' 
            Me.xrCheckBox71.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox71.Checked = True
            Me.xrCheckBox71.EditOptions.Enabled = True
            Me.xrCheckBox71.EditOptions.GroupID = "Driveline (Axles / CV Shaft)"
            Me.xrCheckBox71.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox71.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox71.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox71.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox71.Name = "xrCheckBox71"
            Me.xrCheckBox71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox72
            ' 
            Me.xrCheckBox72.EditOptions.Enabled = True
            Me.xrCheckBox72.EditOptions.GroupID = "Driveline (Axles / CV Shaft)"
            Me.xrCheckBox72.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox72.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox72.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox72.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox72.Name = "xrCheckBox72"
            Me.xrCheckBox72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell116
            ' 
            Me.tableCell116.Multiline = True
            Me.tableCell116.Name = "tableCell116"
            Me.tableCell116.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow52
            ' 
            Me.tableRow52.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell117, Me.tableCell118})
            Me.tableRow52.Name = "tableRow52"
            ' 
            ' tableCell117
            ' 
            Me.tableCell117.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox73, Me.xrCheckBox74, Me.xrCheckBox75})
            Me.tableCell117.Multiline = True
            Me.tableCell117.Name = "tableCell117"
            ' 
            ' xrCheckBox73
            ' 
            Me.xrCheckBox73.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox73.Checked = True
            Me.xrCheckBox73.EditOptions.Enabled = True
            Me.xrCheckBox73.EditOptions.GroupID = "Exhaust System"
            Me.xrCheckBox73.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox73.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox73.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox73.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox73.Name = "xrCheckBox73"
            Me.xrCheckBox73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox74
            ' 
            Me.xrCheckBox74.EditOptions.Enabled = True
            Me.xrCheckBox74.EditOptions.GroupID = "Exhaust System"
            Me.xrCheckBox74.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox74.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox74.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox74.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox74.Name = "xrCheckBox74"
            Me.xrCheckBox74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox75
            ' 
            Me.xrCheckBox75.EditOptions.Enabled = True
            Me.xrCheckBox75.EditOptions.GroupID = "Exhaust System"
            Me.xrCheckBox75.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox75.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox75.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox75.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox75.Name = "xrCheckBox75"
            Me.xrCheckBox75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell118
            ' 
            Me.tableCell118.Multiline = True
            Me.tableCell118.Name = "tableCell118"
            Me.tableCell118.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow53
            ' 
            Me.tableRow53.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell119, Me.tableCell120})
            Me.tableRow53.Name = "tableRow53"
            ' 
            ' tableCell119
            ' 
            Me.tableCell119.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox76, Me.xrCheckBox77, Me.xrCheckBox78})
            Me.tableCell119.Multiline = True
            Me.tableCell119.Name = "tableCell119"
            ' 
            ' xrCheckBox76
            ' 
            Me.xrCheckBox76.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox76.Checked = True
            Me.xrCheckBox76.EditOptions.Enabled = True
            Me.xrCheckBox76.EditOptions.GroupID = "Fuel Lines & Hoses"
            Me.xrCheckBox76.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox76.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"))
            Me.xrCheckBox76.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"))
            Me.xrCheckBox76.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox76.Name = "xrCheckBox76"
            Me.xrCheckBox76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox77
            ' 
            Me.xrCheckBox77.EditOptions.Enabled = True
            Me.xrCheckBox77.EditOptions.GroupID = "Fuel Lines & Hoses"
            Me.xrCheckBox77.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox77.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"))
            Me.xrCheckBox77.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"))
            Me.xrCheckBox77.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox77.Name = "xrCheckBox77"
            Me.xrCheckBox77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox78
            ' 
            Me.xrCheckBox78.EditOptions.Enabled = True
            Me.xrCheckBox78.EditOptions.GroupID = "Fuel Lines & Hoses"
            Me.xrCheckBox78.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox78.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"))
            Me.xrCheckBox78.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"))
            Me.xrCheckBox78.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox78.Name = "xrCheckBox78"
            Me.xrCheckBox78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell120
            ' 
            Me.tableCell120.Multiline = True
            Me.tableCell120.Name = "tableCell120"
            Me.tableCell120.StyleName = "GeneralTextStyleStyle"
            ' 
            ' label8
            ' 
            Me.label8.Multiline = True
            Me.label8.Name = "label8"
            Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label8.StyleName = "SectionTitleStyle"
            Me.label8.StylePriority.UseBorders = False
            ' 
            ' label5
            ' 
            Me.label5.Multiline = True
            Me.label5.Name = "label5"
            Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label5.StyleName = "SectionTitleStyle"
            Me.label5.StylePriority.UseBorders = False
            ' 
            ' table5
            ' 
            Me.table5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.table5.Name = "table5"
            Me.table5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow34, Me.tableRow35, Me.tableRow36})
            Me.table5.StyleName = "GeneralTextStyleStyle"
            Me.table5.StylePriority.UseBackColor = False
            ' 
            ' tableRow34
            ' 
            Me.tableRow34.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell67, Me.tableCell68})
            Me.tableRow34.Name = "tableRow34"
            Me.tableRow34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 20, 0, 100F)
            Me.tableRow34.StylePriority.UsePadding = False
            ' 
            ' tableCell67
            ' 
            Me.tableCell67.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox5})
            Me.tableCell67.Multiline = True
            Me.tableCell67.Name = "tableCell67"
            ' 
            ' pictureBox5
            ' 
            Me.pictureBox5.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox5.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"))
            Me.pictureBox5.Name = "pictureBox5"
            ' 
            ' tableCell68
            ' 
            Me.tableCell68.Multiline = True
            Me.tableCell68.Name = "tableCell68"
            ' 
            ' tableRow35
            ' 
            Me.tableRow35.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell69, Me.tableCell70})
            Me.tableRow35.Name = "tableRow35"
            Me.tableRow35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
            Me.tableRow35.StylePriority.UsePadding = False
            ' 
            ' tableCell69
            ' 
            Me.tableCell69.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox6})
            Me.tableCell69.Multiline = True
            Me.tableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 6, 6, 100F)
            Me.tableCell69.Name = "tableCell69"
            ' 
            ' pictureBox6
            ' 
            Me.pictureBox6.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox6.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"))
            Me.pictureBox6.Name = "pictureBox6"
            ' 
            ' tableCell70
            ' 
            Me.tableCell70.Multiline = True
            Me.tableCell70.Name = "tableCell70"
            Me.tableCell70.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow36
            ' 
            Me.tableRow36.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell71, Me.tableCell72})
            Me.tableRow36.Name = "tableRow36"
            Me.tableRow36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 20, 100F)
            Me.tableRow36.StylePriority.UsePadding = False
            ' 
            ' tableCell71
            ' 
            Me.tableCell71.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pictureBox7})
            Me.tableCell71.Multiline = True
            Me.tableCell71.Name = "tableCell71"
            ' 
            ' pictureBox7
            ' 
            Me.pictureBox7.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
            Me.pictureBox7.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"))
            Me.pictureBox7.Name = "pictureBox7"
            ' 
            ' tableCell72
            ' 
            Me.tableCell72.Multiline = True
            Me.tableCell72.Name = "tableCell72"
            ' 
            ' label7
            ' 
            Me.label7.Multiline = True
            Me.label7.Name = "label7"
            Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label7.StyleName = "EditorKeyStyle"
            ' 
            ' table7
            ' 
            Me.table7.Name = "table7"
            Me.table7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.table7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow40, Me.tableRow41, Me.tableRow42, Me.tableRow43, Me.tableRow44, Me.tableRow47, Me.tableRow48})
            Me.table7.StyleName = "GeneralTextStyleStyle"
            ' 
            ' tableRow40
            ' 
            Me.tableRow40.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell89, Me.tableCell79, Me.tableCell80, Me.tableCell100})
            Me.tableRow40.Name = "tableRow40"
            ' 
            ' tableCell89
            ' 
            Me.tableCell89.Multiline = True
            Me.tableCell89.Name = "tableCell89"
            Me.tableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.tableCell89.StylePriority.UseFont = False
            Me.tableCell89.StylePriority.UsePadding = False
            Me.tableCell89.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell79
            ' 
            Me.tableCell79.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox10, Me.checkBox11, Me.checkBox12})
            Me.tableCell79.Multiline = True
            Me.tableCell79.Name = "tableCell79"
            Me.tableCell79.StylePriority.UseFont = False
            Me.tableCell79.StylePriority.UseTextAlignment = False
            ' 
            ' checkBox10
            ' 
            Me.checkBox10.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.checkBox10.Checked = True
            Me.checkBox10.EditOptions.Enabled = True
            Me.checkBox10.EditOptions.GroupID = "TREAD DEPTH LF"
            Me.checkBox10.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox10.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"))
            Me.checkBox10.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"))
            Me.checkBox10.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox10.Name = "checkBox10"
            Me.checkBox10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' checkBox11
            ' 
            Me.checkBox11.EditOptions.Enabled = True
            Me.checkBox11.EditOptions.GroupID = "TREAD DEPTH LF"
            Me.checkBox11.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox11.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"))
            Me.checkBox11.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"))
            Me.checkBox11.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox11.Name = "checkBox11"
            Me.checkBox11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' checkBox12
            ' 
            Me.checkBox12.EditOptions.Enabled = True
            Me.checkBox12.EditOptions.GroupID = "TREAD DEPTH LF"
            Me.checkBox12.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.checkBox12.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"))
            Me.checkBox12.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"))
            Me.checkBox12.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.checkBox12.Name = "checkBox12"
            Me.checkBox12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell80
            ' 
            Me.tableCell80.EditOptions.EditorName = "IntegerPositive"
            Me.tableCell80.EditOptions.Enabled = True
            Me.tableCell80.Name = "tableCell80"
            Me.tableCell80.StyleName = "EditorValueStyle"
            Me.tableCell80.StylePriority.UseBorderColor = False
            Me.tableCell80.StylePriority.UseBorderWidth = False
            Me.tableCell80.StylePriority.UseFont = False
            Me.tableCell80.StylePriority.UsePadding = False
            Me.tableCell80.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell100
            ' 
            Me.tableCell100.Multiline = True
            Me.tableCell100.Name = "tableCell100"
            Me.tableCell100.StylePriority.UseBorderColor = False
            Me.tableCell100.StylePriority.UseBorderWidth = False
            Me.tableCell100.StylePriority.UseFont = False
            Me.tableCell100.StylePriority.UsePadding = False
            Me.tableCell100.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow41
            ' 
            Me.tableRow41.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell90, Me.tableCell81, Me.tableCell82, Me.tableCell101})
            Me.tableRow41.Name = "tableRow41"
            ' 
            ' tableCell90
            ' 
            Me.tableCell90.Multiline = True
            Me.tableCell90.Name = "tableCell90"
            Me.tableCell90.StylePriority.UseFont = False
            Me.tableCell90.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell81
            ' 
            Me.tableCell81.Multiline = True
            Me.tableCell81.Name = "tableCell81"
            Me.tableCell81.StylePriority.UseFont = False
            Me.tableCell81.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell82
            ' 
            Me.tableCell82.Multiline = True
            Me.tableCell82.Name = "tableCell82"
            Me.tableCell82.StylePriority.UseBorderColor = False
            Me.tableCell82.StylePriority.UseBorderWidth = False
            Me.tableCell82.StylePriority.UseFont = False
            Me.tableCell82.StylePriority.UsePadding = False
            Me.tableCell82.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell101
            ' 
            Me.tableCell101.Multiline = True
            Me.tableCell101.Name = "tableCell101"
            Me.tableCell101.StylePriority.UseBorderColor = False
            Me.tableCell101.StylePriority.UseBorderWidth = False
            Me.tableCell101.StylePriority.UseFont = False
            Me.tableCell101.StylePriority.UsePadding = False
            Me.tableCell101.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow42
            ' 
            Me.tableRow42.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell91, Me.tableCell83, Me.tableCell84, Me.tableCell102})
            Me.tableRow42.Name = "tableRow42"
            ' 
            ' tableCell91
            ' 
            Me.tableCell91.Multiline = True
            Me.tableCell91.Name = "tableCell91"
            Me.tableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.tableCell91.StylePriority.UseFont = False
            Me.tableCell91.StylePriority.UsePadding = False
            Me.tableCell91.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell83
            ' 
            Me.tableCell83.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox91, Me.xrCheckBox92, Me.xrCheckBox93})
            Me.tableCell83.Multiline = True
            Me.tableCell83.Name = "tableCell83"
            Me.tableCell83.StylePriority.UseFont = False
            Me.tableCell83.StylePriority.UseTextAlignment = False
            ' 
            ' xrCheckBox91
            ' 
            Me.xrCheckBox91.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox91.Checked = True
            Me.xrCheckBox91.EditOptions.Enabled = True
            Me.xrCheckBox91.EditOptions.GroupID = "TREAD DEPTH LR"
            Me.xrCheckBox91.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox91.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"))
            Me.xrCheckBox91.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"))
            Me.xrCheckBox91.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox91.Name = "xrCheckBox91"
            Me.xrCheckBox91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox92
            ' 
            Me.xrCheckBox92.EditOptions.Enabled = True
            Me.xrCheckBox92.EditOptions.GroupID = "TREAD DEPTH LR"
            Me.xrCheckBox92.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox92.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"))
            Me.xrCheckBox92.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"))
            Me.xrCheckBox92.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox92.Name = "xrCheckBox92"
            Me.xrCheckBox92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox93
            ' 
            Me.xrCheckBox93.EditOptions.Enabled = True
            Me.xrCheckBox93.EditOptions.GroupID = "TREAD DEPTH LR"
            Me.xrCheckBox93.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox93.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"))
            Me.xrCheckBox93.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"))
            Me.xrCheckBox93.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox93.Name = "xrCheckBox93"
            Me.xrCheckBox93.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell84
            ' 
            Me.tableCell84.EditOptions.EditorName = "IntegerPositive"
            Me.tableCell84.EditOptions.Enabled = True
            Me.tableCell84.Multiline = True
            Me.tableCell84.Name = "tableCell84"
            Me.tableCell84.StyleName = "EditorValueStyle"
            Me.tableCell84.StylePriority.UseBorderColor = False
            Me.tableCell84.StylePriority.UseBorderWidth = False
            Me.tableCell84.StylePriority.UseFont = False
            Me.tableCell84.StylePriority.UsePadding = False
            Me.tableCell84.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell102
            ' 
            Me.tableCell102.Multiline = True
            Me.tableCell102.Name = "tableCell102"
            Me.tableCell102.StylePriority.UseBorderColor = False
            Me.tableCell102.StylePriority.UseBorderWidth = False
            Me.tableCell102.StylePriority.UseFont = False
            Me.tableCell102.StylePriority.UsePadding = False
            Me.tableCell102.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow43
            ' 
            Me.tableRow43.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell92, Me.tableCell85, Me.tableCell86, Me.tableCell103})
            Me.tableRow43.Name = "tableRow43"
            ' 
            ' tableCell92
            ' 
            Me.tableCell92.Multiline = True
            Me.tableCell92.Name = "tableCell92"
            Me.tableCell92.StylePriority.UseFont = False
            Me.tableCell92.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell85
            ' 
            Me.tableCell85.Multiline = True
            Me.tableCell85.Name = "tableCell85"
            Me.tableCell85.StylePriority.UseFont = False
            Me.tableCell85.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell86
            ' 
            Me.tableCell86.Multiline = True
            Me.tableCell86.Name = "tableCell86"
            Me.tableCell86.StylePriority.UseBorderColor = False
            Me.tableCell86.StylePriority.UseBorderWidth = False
            Me.tableCell86.StylePriority.UseFont = False
            Me.tableCell86.StylePriority.UsePadding = False
            Me.tableCell86.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell103
            ' 
            Me.tableCell103.Multiline = True
            Me.tableCell103.Name = "tableCell103"
            Me.tableCell103.StylePriority.UseBorderColor = False
            Me.tableCell103.StylePriority.UseBorderWidth = False
            Me.tableCell103.StylePriority.UseFont = False
            Me.tableCell103.StylePriority.UsePadding = False
            Me.tableCell103.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow44
            ' 
            Me.tableRow44.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell97, Me.tableCell87, Me.tableCell88, Me.tableCell104})
            Me.tableRow44.Name = "tableRow44"
            ' 
            ' tableCell97
            ' 
            Me.tableCell97.Multiline = True
            Me.tableCell97.Name = "tableCell97"
            Me.tableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.tableCell97.StylePriority.UseFont = False
            Me.tableCell97.StylePriority.UsePadding = False
            Me.tableCell97.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell87
            ' 
            Me.tableCell87.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox94, Me.xrCheckBox95, Me.xrCheckBox96})
            Me.tableCell87.Multiline = True
            Me.tableCell87.Name = "tableCell87"
            Me.tableCell87.StylePriority.UseFont = False
            Me.tableCell87.StylePriority.UseTextAlignment = False
            ' 
            ' xrCheckBox94
            ' 
            Me.xrCheckBox94.EditOptions.Enabled = True
            Me.xrCheckBox94.EditOptions.GroupID = "TREAD DEPTH RF"
            Me.xrCheckBox94.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox94.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"))
            Me.xrCheckBox94.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"))
            Me.xrCheckBox94.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox94.Name = "xrCheckBox94"
            Me.xrCheckBox94.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox95
            ' 
            Me.xrCheckBox95.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox95.Checked = True
            Me.xrCheckBox95.EditOptions.Enabled = True
            Me.xrCheckBox95.EditOptions.GroupID = "TREAD DEPTH RF"
            Me.xrCheckBox95.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox95.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"))
            Me.xrCheckBox95.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"))
            Me.xrCheckBox95.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox95.Name = "xrCheckBox95"
            Me.xrCheckBox95.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox96
            ' 
            Me.xrCheckBox96.EditOptions.Enabled = True
            Me.xrCheckBox96.EditOptions.GroupID = "TREAD DEPTH RF"
            Me.xrCheckBox96.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox96.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"))
            Me.xrCheckBox96.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"))
            Me.xrCheckBox96.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox96.Name = "xrCheckBox96"
            Me.xrCheckBox96.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell88
            ' 
            Me.tableCell88.EditOptions.EditorName = "IntegerPositive"
            Me.tableCell88.EditOptions.Enabled = True
            Me.tableCell88.Multiline = True
            Me.tableCell88.Name = "tableCell88"
            Me.tableCell88.StyleName = "EditorValueStyle"
            Me.tableCell88.StylePriority.UseBorderColor = False
            Me.tableCell88.StylePriority.UseBorderWidth = False
            Me.tableCell88.StylePriority.UseFont = False
            Me.tableCell88.StylePriority.UsePadding = False
            Me.tableCell88.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell104
            ' 
            Me.tableCell104.Multiline = True
            Me.tableCell104.Name = "tableCell104"
            Me.tableCell104.StylePriority.UseBorderColor = False
            Me.tableCell104.StylePriority.UseBorderWidth = False
            Me.tableCell104.StylePriority.UseFont = False
            Me.tableCell104.StylePriority.UsePadding = False
            Me.tableCell104.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow47
            ' 
            Me.tableRow47.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell98, Me.tableCell93, Me.tableCell94, Me.tableCell105})
            Me.tableRow47.Name = "tableRow47"
            ' 
            ' tableCell98
            ' 
            Me.tableCell98.Multiline = True
            Me.tableCell98.Name = "tableCell98"
            Me.tableCell98.StylePriority.UseFont = False
            Me.tableCell98.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell93
            ' 
            Me.tableCell93.Multiline = True
            Me.tableCell93.Name = "tableCell93"
            Me.tableCell93.StylePriority.UseFont = False
            Me.tableCell93.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell94
            ' 
            Me.tableCell94.Multiline = True
            Me.tableCell94.Name = "tableCell94"
            Me.tableCell94.StylePriority.UseBorderColor = False
            Me.tableCell94.StylePriority.UseBorderWidth = False
            Me.tableCell94.StylePriority.UseFont = False
            Me.tableCell94.StylePriority.UsePadding = False
            Me.tableCell94.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell105
            ' 
            Me.tableCell105.Multiline = True
            Me.tableCell105.Name = "tableCell105"
            Me.tableCell105.StylePriority.UseBorderColor = False
            Me.tableCell105.StylePriority.UseBorderWidth = False
            Me.tableCell105.StylePriority.UseFont = False
            Me.tableCell105.StylePriority.UsePadding = False
            Me.tableCell105.StylePriority.UseTextAlignment = False
            ' 
            ' tableRow48
            ' 
            Me.tableRow48.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell99, Me.tableCell95, Me.tableCell96, Me.tableCell106})
            Me.tableRow48.Name = "tableRow48"
            ' 
            ' tableCell99
            ' 
            Me.tableCell99.Multiline = True
            Me.tableCell99.Name = "tableCell99"
            Me.tableCell99.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.tableCell99.StylePriority.UseFont = False
            Me.tableCell99.StylePriority.UsePadding = False
            Me.tableCell99.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell95
            ' 
            Me.tableCell95.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox97, Me.xrCheckBox98, Me.xrCheckBox99})
            Me.tableCell95.Multiline = True
            Me.tableCell95.Name = "tableCell95"
            Me.tableCell95.StylePriority.UseFont = False
            Me.tableCell95.StylePriority.UseTextAlignment = False
            ' 
            ' xrCheckBox97
            ' 
            Me.xrCheckBox97.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked
            Me.xrCheckBox97.Checked = True
            Me.xrCheckBox97.EditOptions.Enabled = True
            Me.xrCheckBox97.EditOptions.GroupID = "TREAD DEPTH RR"
            Me.xrCheckBox97.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox97.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"))
            Me.xrCheckBox97.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"))
            Me.xrCheckBox97.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox97.Name = "xrCheckBox97"
            Me.xrCheckBox97.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox98
            ' 
            Me.xrCheckBox98.EditOptions.Enabled = True
            Me.xrCheckBox98.EditOptions.GroupID = "TREAD DEPTH RR"
            Me.xrCheckBox98.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox98.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"))
            Me.xrCheckBox98.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"))
            Me.xrCheckBox98.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox98.Name = "xrCheckBox98"
            Me.xrCheckBox98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrCheckBox99
            ' 
            Me.xrCheckBox99.EditOptions.Enabled = True
            Me.xrCheckBox99.EditOptions.GroupID = "TREAD DEPTH RR"
            Me.xrCheckBox99.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox99.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"))
            Me.xrCheckBox99.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"))
            Me.xrCheckBox99.GlyphOptions.Size = New System.Drawing.SizeF(18F, 18F)
            Me.xrCheckBox99.Name = "xrCheckBox99"
            Me.xrCheckBox99.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' tableCell96
            ' 
            Me.tableCell96.EditOptions.EditorName = "IntegerPositive"
            Me.tableCell96.EditOptions.Enabled = True
            Me.tableCell96.Multiline = True
            Me.tableCell96.Name = "tableCell96"
            Me.tableCell96.StyleName = "EditorValueStyle"
            Me.tableCell96.StylePriority.UseBorderColor = False
            Me.tableCell96.StylePriority.UseBorderWidth = False
            Me.tableCell96.StylePriority.UseFont = False
            Me.tableCell96.StylePriority.UsePadding = False
            Me.tableCell96.StylePriority.UseTextAlignment = False
            ' 
            ' tableCell106
            ' 
            Me.tableCell106.Multiline = True
            Me.tableCell106.Name = "tableCell106"
            Me.tableCell106.StylePriority.UseBorderColor = False
            Me.tableCell106.StylePriority.UseBorderWidth = False
            Me.tableCell106.StylePriority.UseFont = False
            Me.tableCell106.StylePriority.UsePadding = False
            Me.tableCell106.StylePriority.UseTextAlignment = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' label1
            ' 
            Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.label1.StylePriority.UseFont = False
            Me.label1.StylePriority.UseForeColor = False
            Me.label1.StylePriority.UsePadding = False
            Me.label1.StylePriority.UseTextAlignment = False
            Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' EditorKeyStyle
            ' 
            Me.EditorKeyStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.EditorKeyStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((149)))))), (CInt(((CByte((149)))))), (CInt(((CByte((149)))))))
            Me.EditorKeyStyle.Name = "EditorKeyStyle"
            Me.EditorKeyStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.EditorKeyStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' EditorValueStyle
            ' 
            Me.EditorValueStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((217)))))), (CInt(((CByte((217)))))))
            Me.EditorValueStyle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.EditorValueStyle.BorderWidth = 2F
            Me.EditorValueStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.EditorValueStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.EditorValueStyle.Name = "EditorValueStyle"
            Me.EditorValueStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F)
            Me.EditorValueStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GeneralTextStyleStyle
            ' 
            Me.GeneralTextStyleStyle.Font = New DevExpress.Drawing.DXFont("Arial", 9.5F)
            Me.GeneralTextStyleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.GeneralTextStyleStyle.Name = "GeneralTextStyleStyle"
            Me.GeneralTextStyleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 8, 2, 2, 100F)
            Me.GeneralTextStyleStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' SectionTitleStyle
            ' 
            Me.SectionTitleStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.SectionTitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.SectionTitleStyle.BorderWidth = 4F
            Me.SectionTitleStyle.Font = New DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.SectionTitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((52)))))), (CInt(((CByte((52)))))), (CInt(((CByte((52)))))))
            Me.SectionTitleStyle.Name = "SectionTitleStyle"
            Me.SectionTitleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 5, 100F)
            ' 
            ' parameterLanguage
            ' 
            Me.parameterLanguage.Name = "parameterLanguage"
            Me.parameterLanguage.ValueInfo = "Default"
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("Default", "English"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("de", "German"))
            Me.parameterLanguage.ValueSourceSettings = staticListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.ReportHeader})
            Me.LocalizationItems.AddRange(New DevExpress.XtraReports.Localization.LocalizationItem() {New DevExpress.XtraReports.Localization.LocalizationItem(Me.BottomMargin, "Default", "HeightF", 90F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.BottomMargin, "de", "HeightF", 85.99999F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox1, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox1, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox1, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox10, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(1.907349E-06F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox10, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox10, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox10, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox11, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(23.00001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox11, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox11, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox11, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox12, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(46F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox12, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox12, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox12, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox2, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox2, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox2, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox2, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox24, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox24, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox24, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox3, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox3, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox3, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.checkBox3, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.Detail, "Default", "HeightF", 848.0001F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "Default", "Font", New DevExpress.Drawing.DXFont("Arial", 24.5F, DevExpress.Drawing.DXFontStyle.Bold)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(1.222659E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "de", "LocationFloat", New DevExpress.Utils.PointFloat(1.589457E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "Default", "SizeF", New System.Drawing.SizeF(650F, 65F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "de", "SizeF", New System.Drawing.SizeF(734.9999F, 65F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "Default", "Text", "Vehicle Inspection Report"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label1, "de", "Text", "KFZ-Inspektionsbericht"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 501F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 501F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "Default", "SizeF", New System.Drawing.SizeF(295F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 26.99997F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "Default", "Text", "TIRE CHECK / OE INTERVAL SUGGESTIONS"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label10, "de", "Text", "Ratschläge zu Reifenprüfung und Herstellerintervallen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 614F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 613.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "Default", "SizeF", New System.Drawing.SizeF(295F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "Default", "Text", "COMMENTS:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label11, "de", "Text", "Kommentare:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label12, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 641F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label12, "Default", "SizeF", New System.Drawing.SizeF(650F, 172.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label12, "de", "SizeF", New System.Drawing.SizeF(734.9998F, 172.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 840.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 840.0002F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "Default", "SizeF", New System.Drawing.SizeF(460F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "de", "SizeF", New System.Drawing.SizeF(520.4167F, 26.99988F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "Default", "Text", "INSPECTED BY:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label13, "de", "Text", "Inspiziert von"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label14, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 867F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label14, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 867.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label14, "Default", "SizeF", New System.Drawing.SizeF(460F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label14, "de", "SizeF", New System.Drawing.SizeF(520.4167F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(470.0001F, 840.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "de", "LocationFloat", New DevExpress.Utils.PointFloat(533.125F, 840.0002F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "Default", "SizeF", New System.Drawing.SizeF(180F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "de", "SizeF", New System.Drawing.SizeF(201.8749F, 26.99988F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "Default", "Text", "DATE:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label15, "de", "Text", "Datum:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 375F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 375F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "Default", "SizeF", New System.Drawing.SizeF(295F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "de", "SizeF", New System.Drawing.SizeF(340F, 39.99997F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "Default", "Text", "INTERIOR / EXTERIOR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label2, "de", "Text", "INNENRAUM UND KAROSSERIE"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355F, 375F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9175F, 375F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "Default", "SizeF", New System.Drawing.SizeF(295F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "de", "SizeF", New System.Drawing.SizeF(340.0824F, 39.99997F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "Default", "Text", "UNDERHOOD"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label3, "de", "Text", "UNTER DER HAUBE"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(1.946274E-05F, 415F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "de", "LocationFloat", New DevExpress.Utils.PointFloat(3.178914E-05F, 415F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "Default", "SizeF", New System.Drawing.SizeF(295F, 45F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "de", "SizeF", New System.Drawing.SizeF(340F, 45F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "Default", "Text", "Note any existing exterior body damage or defects on diagram:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label4, "de", "Text", "Vermerken Sie bestehende externe Schäden im Diagramm:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label5, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label5, "Default", "SizeF", New System.Drawing.SizeF(295F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label5, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label5, "Default", "Text", "TIRES"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label5, "de", "Text", "REIFEN"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355.0001F, 740.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9175F, 740.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "Default", "SizeF", New System.Drawing.SizeF(295F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "de", "SizeF", New System.Drawing.SizeF(340.0827F, 26.99988F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "Default", "Text", "BATTERY"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label6, "de", "Text", "Batterie"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 51.00006F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 51.00009F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "Default", "SizeF", New System.Drawing.SizeF(295F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "Default", "Text", "TREAD DEPTH"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label7, "de", "Text", "Profiltiefe"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9176F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "Default", "SizeF", New System.Drawing.SizeF(295F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "de", "SizeF", New System.Drawing.SizeF(340.0823F, 40F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "Default", "Text", "UNDER VEHICLE"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label8, "de", "Text", "UNTER DEM FAHRZEUG"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 394F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 394F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "Default", "SizeF", New System.Drawing.SizeF(295F, 26.99994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 27.00003F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "Default", "Text", "WEAR PATTERN / DAMAGE"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.label9, "de", "Text", "Verschleißmuster / Beschädigungen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.labelCurrentDate, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(470F, 867F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.labelCurrentDate, "de", "LocationFloat", New DevExpress.Utils.PointFloat(533.1248F, 867.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.labelCurrentDate, "Default", "SizeF", New System.Drawing.SizeF(180F, 32.49994F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.labelCurrentDate, "de", "SizeF", New System.Drawing.SizeF(201.8751F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.labelCurrentDate, "Default", "TextFormatString", "{0:d}"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.parameterLanguage, "Default", "Description", "Language:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox1, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox1, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 41.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox1, "de", "SizeF", New System.Drawing.SizeF(50.08271F, 39.84F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox2, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.051758E-05F, 3.814697E-06F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox2, "de", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox2, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 32.50001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox2, "de", "SizeF", New System.Drawing.SizeF(50.08271F, 31.2F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox3, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox3, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 41F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox3, "de", "SizeF", New System.Drawing.SizeF(50.08271F, 39.36F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox4, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 460F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox4, "Default", "SizeF", New System.Drawing.SizeF(295F, 190F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox4, "de", "SizeF", New System.Drawing.SizeF(340F, 190F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox5, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox5, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 41.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox6, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.051758E-05F, 3.814697E-06F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox6, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 32.50001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox6, "de", "SizeF", New System.Drawing.SizeF(44.75381F, 32.50001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox7, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.pictureBox7, "Default", "SizeF", New System.Drawing.SizeF(44.75381F, 41F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me, "Default", "DisplayName", "Vehicle Inspection Report"), New DevExpress.XtraReports.Localization.LocalizationItem(Me, "Default", "Font", New DevExpress.Drawing.DXFont("Arial", 9.75F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me, "Default", "Margins", New DevExpress.Drawing.DXMargins(100, 100, 90, 90)), New DevExpress.XtraReports.Localization.LocalizationItem(Me, "de", "Margins", New DevExpress.Drawing.DXMargins(45, 47, 86, 86)), New DevExpress.XtraReports.Localization.LocalizationItem(Me, "de", "PaperKind", System.Drawing.Printing.PaperKind.A4), New DevExpress.XtraReports.Localization.LocalizationItem(Me.ReportHeader, "Default", "HeightF", 65F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.SubBand1, "Default", "HeightF", 899.5F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.SubBand1, "de", "HeightF", 899.5001F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table1, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 20F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table1, "Default", "SizeF", New System.Drawing.SizeF(295F, 298.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table1, "de", "SizeF", New System.Drawing.SizeF(345F, 298.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table10, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(9.536745E-05F, 527.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table10, "Default", "SizeF", New System.Drawing.SizeF(295F, 54F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table10, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 54.00006F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table2, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355F, 20F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table2, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9175F, 20F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table2, "Default", "SizeF", New System.Drawing.SizeF(295F, 115F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table2, "de", "SizeF", New System.Drawing.SizeF(340.0827F, 110.4F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table3, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 659F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table3, "Default", "SizeF", New System.Drawing.SizeF(295F, 189F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table3, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 189.0001F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table4, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355F, 443F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table4, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9175F, 443F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table4, "Default", "SizeF", New System.Drawing.SizeF(295F, 270F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table4, "de", "SizeF", New System.Drawing.SizeF(340.0822F, 269.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table5, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 78F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table5, "Default", "SizeF", New System.Drawing.SizeF(295F, 115F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table5, "de", "SizeF", New System.Drawing.SizeF(340F, 115F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table6, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(354.9999F, 766.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table6, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9176F, 766.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table6, "Default", "SizeF", New System.Drawing.SizeF(295F, 81F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table6, "de", "SizeF", New System.Drawing.SizeF(340.0822F, 81F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table7, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 208F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table7, "Default", "SizeF", New System.Drawing.SizeF(295F, 157F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table7, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 157F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table8, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(355F, 58F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table8, "de", "LocationFloat", New DevExpress.Utils.PointFloat(394.9176F, 58F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table8, "Default", "SizeF", New System.Drawing.SizeF(295F, 189F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table8, "de", "SizeF", New System.Drawing.SizeF(340.0821F, 189F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table9, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(9.536745E-05F, 420.9999F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table9, "Default", "SizeF", New System.Drawing.SizeF(295F, 54F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.table9, "de", "SizeF", New System.Drawing.SizeF(339.9999F, 54.00003F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell1, "Default", "Text", "NAME:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell1, "de", "Text", "Name:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell1, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell1, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell10, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell10, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell100, "Default", "Text", "/32"""), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell100, "de", "Text", "mm"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell100, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell100, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell101, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell101, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell102, "Default", "Text", "/32"""), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell102, "de", "Text", "mm"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell102, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell102, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell103, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell103, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell104, "Default", "Text", "/32"""), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell104, "de", "Text", "mm"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell104, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell104, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell105, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell105, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell106, "Default", "Text", "/32"""), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell106, "de", "Text", "mm"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell106, "Default", "Weight", 0.73000020238445229R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell106, "de", "Weight", 0.80202322518802016R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell107, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell108, "Default", "Text", "Brakes (Pads / Shoes)"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell108, "de", "Text", "Bremsen (Scheiben, Beläge, Bremsbacken)"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell108, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell108, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell109, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell11, "Default", "Text", "PHONE:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell11, "de", "Text", "Telefon:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell11, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell11, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell110, "Default", "Text", "Brake Lines / Hoses"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell110, "de", "Text", "Bremsleitungen / -schläuche"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell110, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell110, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell111, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell112, "Default", "Text", "Steering System"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell112, "de", "Text", "Lenkanlage"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell112, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell112, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell113, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell114, "Default", "Text", "Shocks & Struts"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell114, "de", "Text", "Stoßdämpfer und Federbeine"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell114, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell114, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell115, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell116, "Default", "Text", "Driveline (Axles / CV Shaft)"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell116, "de", "Text", "Antrieb und Fahrwerk (Achsen / Wellen)"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell116, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell116, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell117, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell118, "Default", "Text", "Exhaust System"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell118, "de", "Text", "Abgasanlage"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell118, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell118, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell119, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell12, "Default", "Text", "(123) 456-7890"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell12, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell12, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell120, "Default", "Text", "Fuel Lines & Hoses"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell120, "de", "Text", "Kraftstoffleitungen und -schläuche"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell120, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell120, "de", "Weight", 2.7720227797709707R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell121, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell122, "Default", "Text", "LF"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell122, "de", "Text", "VL"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell122, "Default", "Weight", 0.81355938033379271R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell122, "de", "Weight", 1.0541760567118461R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell123, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell124, "Default", "Text", "RF"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell124, "de", "Text", "HL"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell124, "Default", "Weight", 0.81355938033379271R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell124, "de", "Weight", 1.0541760567118461R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell125, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell126, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell127, "Default", "Text", "LR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell127, "de", "Text", "VR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell127, "Default", "Weight", 0.81355938033379271R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell127, "de", "Weight", 1.0305685773795519R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell128, "Default", "Text", "RR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell128, "de", "Text", "HR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell128, "Default", "Weight", 0.81355938033379271R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell128, "de", "Weight", 1.0305685773795519R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell129, "Default", "Weight", 0.25423699115683063R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell13, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell13, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell130, "Default", "Text", "Alignment"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell130, "de", "Text", "Achsvermessung"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell130, "Default", "Weight", 1.2457631640173155R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell130, "de", "Weight", 1.4969728788609187R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell131, "Default", "Weight", 0.25423734029865042R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell132, "Default", "Text", "Rotation"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell132, "Default", "Weight", 1.2457628148754958R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell132, "de", "Weight", 1.4521795032888887R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell133, "Default", "Weight", 0.25423699115683063R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell134, "Default", "Text", "Balance"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell134, "de", "Text", "Auswuchtung"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell134, "Default", "Weight", 1.2457631640173155R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell134, "de", "Weight", 1.4969728788609187R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell135, "Default", "Weight", 0.25423734029865042R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell136, "Default", "Text", "New Tire"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell136, "de", "Text", "Neuer Reifen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell136, "Default", "Weight", 1.2457628148754958R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell136, "de", "Weight", 1.4521795032888887R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell14, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell14, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell15, "Default", "Text", "EMAIL:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell15, "de", "Text", "Email:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell15, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell15, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell16, "Default", "Text", "john@devexpress.com"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell16, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell16, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell17, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell17, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell18, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell18, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell19, "Default", "Text", "VIN:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell19, "de", "Text", "Fahrgestellnummer:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell19, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell19, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell2, "Default", "Text", "John Smith"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell2, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell2, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell20, "Default", "Text", "1D4GP25B03108775"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell20, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell20, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell21, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell21, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell22, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell22, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell23, "Default", "Text", "MILEAGE:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell23, "de", "Text", "Kilometerstand:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell23, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell23, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell24, "Default", "Text", "123456"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell24, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell24, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell25, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell25, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell26, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell26, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell27, "Default", "Text", "LICENSE:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell27, "de", "Text", "Führerscheinnummer:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell27, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell27, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell28, "Default", "Text", "123456-78"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell28, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell28, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell29, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell29, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell3, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell30, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell30, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell31, "Default", "Text", "MODEL:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell31, "de", "Text", "Fahrzeughersteller und Typ:"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell31, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell31, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell32, "Default", "Text", "Volkswagen Passat"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell32, "Default", "Weight", 2.1999999999999997R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell32, "de", "Weight", 1.5196969939723157R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell33, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell33, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell34, "Default", "Text", "Exterior Body"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell34, "de", "Text", "Karosserie"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell34, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell34, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell35, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell35, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell36, "Default", "Text", "Windshield / Glass"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell36, "de", "Text", "Windschutzscheibe"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell36, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell36, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell37, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell37, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell38, "Default", "Text", "Wipers"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell38, "de", "Text", "Scheibenwischer"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell38, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell38, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell39, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell39, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell4, "Default", "Text", "Checked and OK"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell4, "de", "Text", "Geprüft und in Ordnung"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell4, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell4, "de", "Weight", 1.7665692036940925R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell40, "Default", "Text", "Lights (Head, Brake, Turn)"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell40, "de", "Text", "Scheinwerfer, Bremslichter, Blinker"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell40, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell40, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell41, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell41, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell42, "Default", "Text", "Interior Lights"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell42, "de", "Text", "Innenbeleuchtung"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell42, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell42, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell43, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell43, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell44, "Default", "Text", "AC Operation"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell44, "de", "Text", "Klimaanlage"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell44, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell44, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell45, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell45, "de", "Weight", 0.61363713127814146R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell46, "Default", "Text", "Heating"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell46, "de", "Text", "Heizanlage"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell46, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell46, "de", "Weight", 2.4772717245186211R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell47, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell48, "Default", "Text", "Engine Oil"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell48, "de", "Text", "Motoröl"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell48, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell48, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell49, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell5, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell50, "Default", "Text", "Brake Fluid"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell50, "de", "Text", "Bremsflüssigkeit"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell50, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell50, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell51, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell52, "Default", "Text", "Power Steering Fluid"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell52, "de", "Text", "Lenkungsöl"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell52, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell52, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell53, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell54, "Default", "Text", "Washer Fluid"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell54, "de", "Text", "Scheibenwaschflüssigkeit"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell54, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell54, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell55, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell56, "Default", "Text", "Belts & Hoses"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell56, "de", "Text", "Riemen und Schläuche"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell56, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell56, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell57, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell58, "Default", "Text", "Antifreeze / Coolant"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell58, "de", "Text", "Kühlmittel"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell58, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell58, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell59, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell6, "Default", "Text", "May require attention"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell6, "de", "Text", "In naher Zukunft wieder prüfen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell6, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell6, "de", "Weight", 1.7665692036940925R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell60, "Default", "Text", "Air Filter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell60, "de", "Text", "Luftfilter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell60, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell60, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell61, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell62, "Default", "Text", "Cabin Filter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell62, "de", "Text", "Pollenfilter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell62, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell62, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell63, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell64, "Default", "Text", "Fuel Filter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell64, "de", "Text", "Kraftstofffilter"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell64, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell64, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell65, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell66, "Default", "Text", "Spark Plugs / Wires"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell66, "de", "Text", "Zündkerzen / -kabel"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell66, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell66, "de", "Weight", 2.7720234227046818R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell67, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell68, "Default", "Text", "7/32"" or greater"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell68, "de", "Text", "7mm oder mehr"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell68, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell68, "de", "Weight", 1.9999997931011653R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell69, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell7, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell70, "Default", "Text", "3/32"" to 6/32"""), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell70, "de", "Text", "3mm bis 6mm"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell70, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell70, "de", "Weight", 1.9999997931011653R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell71, "Default", "Weight", 0.30508474576271183R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell72, "Default", "Text", "2/32"" or less"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell72, "de", "Text", "2mm oder weniger"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell72, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell72, "de", "Weight", 1.9999997931011653R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell73, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell74, "Default", "Text", "Battery Charge"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell74, "de", "Text", "Batterieladung"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell74, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell74, "de", "Weight", 2.7720218264889134R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell75, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell76, "Default", "Text", "Battery Condition"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell76, "de", "Text", "Batteriezustand"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell76, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell76, "de", "Weight", 2.7720218264889134R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell77, "Default", "Weight", 0.68644077484035348R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell78, "Default", "Text", "Cables & Connections"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell78, "de", "Text", "Kabel und Verbindungen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell78, "Default", "Weight", 2.3135595355079386R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell78, "de", "Weight", 2.7720218264889134R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell79, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell8, "Default", "Text", "Requires immediate attention"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell8, "de", "Text", "Sofort beheben lassen"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell8, "Default", "Weight", 1.6949152542372881R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell8, "de", "Weight", 1.7665692036940925R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell80, "Default", "Text", "8"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell80, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell80, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell81, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell82, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell82, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell83, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell84, "Default", "Text", "7"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell84, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell84, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell85, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell86, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell86, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell87, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell88, "Default", "Text", "5"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell88, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell88, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell89, "Default", "Text", "LF"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell89, "de", "Text", "VL"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell89, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell89, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell9, "Default", "Weight", 0.75000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell9, "de", "Weight", 1.430303006027684R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell90, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell90, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell91, "Default", "Text", "LR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell91, "de", "Text", "HL"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell91, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell91, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell92, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell92, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell93, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell94, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell94, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell95, "Default", "Weight", 0.770000078011074R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell96, "Default", "Text", "9"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell96, "Default", "Weight", 1.2000000834554068R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell96, "de", "Weight", 1.5154762831330966R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell97, "Default", "Text", "RF"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell97, "de", "Text", "VR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell97, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell97, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell98, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell98, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell99, "Default", "Text", "RR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell99, "de", "Text", "HR"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell99, "Default", "Weight", 0.25000000000000011R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableCell99, "de", "Weight", 0.31250001219222617R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow1, "Default", "Weight", 1.3000001508464096R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow10, "Default", "Weight", 1.300000069724381R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow11, "Default", "Weight", 0.35999999859049603R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow12, "Default", "Weight", 1.3000000662174627R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow13, "Default", "Weight", 0.36000000117826225R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow14, "Default", "Weight", 1.3000000638291813R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow15, "Default", "Weight", 0.36000000303031432R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow16, "Default", "Weight", 1.3000000620983545R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow17, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow18, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow19, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow2, "Default", "Weight", 1.0826088283372961R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow20, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow21, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow22, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow23, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow24, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow25, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow26, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow27, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow28, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow29, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow3, "Default", "Weight", 0.84782602061396062R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow30, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow31, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow32, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow33, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow34, "Default", "Weight", 1.0826088283372961R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow35, "Default", "Weight", 0.84782602061396062R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow36, "Default", "Weight", 1.0695651510487432R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow37, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow38, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow39, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow4, "Default", "Weight", 1.0695651510487432R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow40, "Default", "Weight", 1.3000001508464096R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow41, "Default", "Weight", 0.360000038146976R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow42, "Default", "Weight", 1.3000001094333777R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow43, "Default", "Weight", 0.36000002878248472R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow44, "Default", "Weight", 1.300000109433378R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow45, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow46, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow47, "Default", "Weight", 0.35999999859049603R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow48, "Default", "Weight", 1.3000000662174627R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow49, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow5, "Default", "Weight", 0.360000038146976R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow50, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow51, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow52, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow53, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow54, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow55, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow56, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow57, "Default", "Weight", 1.08R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow6, "Default", "Weight", 1.3000001094333777R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow7, "Default", "Weight", 0.36000002878248472R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow8, "Default", "Weight", 1.300000109433378R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.tableRow9, "Default", "Weight", 1.0400000489787078R), New DevExpress.XtraReports.Localization.LocalizationItem(Me.TopMargin, "Default", "HeightF", 90F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.TopMargin, "de", "HeightF", 85.99999F), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox1, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox1, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox1, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox10, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0001271566F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox10, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox10, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox100, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox100, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox100, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox101, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(1.525879E-05F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox101, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox101, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox101, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox102, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0002593994F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox102, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox102, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox102, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox11, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.5001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox11, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox11, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox12, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45.00008F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox12, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox12, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox12, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox13, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0001271566F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox13, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox13, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox14, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.5001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox14, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox14, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox15, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45.00008F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox15, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox15, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox15, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox16, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0001271566F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox16, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox16, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox17, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.5001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox17, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox17, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox18, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45.00008F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox18, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox18, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox18, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox19, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox19, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox19, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox2, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49998F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox2, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox2, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox2, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox20, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox20, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox20, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox20, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox21, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox21, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox21, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox21, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox22, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox22, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox22, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox22, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox23, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox23, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox23, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox23, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox24, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox24, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox24, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox24, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox25, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox25, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox25, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox25, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox26, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox26, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox26, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox26, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox27, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox27, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox27, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox27, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox28, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox28, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox28, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox28, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox29, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox29, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox29, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox29, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox3, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99995F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox3, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox3, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox3, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox30, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox30, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox30, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox30, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox31, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox31, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox31, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox31, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox32, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox32, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox32, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox32, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox33, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox33, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox33, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox33, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox34, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox34, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox34, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox34, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox35, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox35, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox35, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox35, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox36, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox36, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox36, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox36, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox37, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox37, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox37, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox37, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox38, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox38, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox38, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox38, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox39, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox39, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox39, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox39, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox4, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0001271566F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox4, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox4, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox40, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox40, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox40, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox40, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox41, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49991F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox41, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox41, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox41, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox42, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99988F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox42, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox42, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox42, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox43, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox43, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox43, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox44, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49976F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox44, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox44, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox44, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox45, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99976F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox45, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox45, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox45, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox46, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(6.103516E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox46, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox46, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox46, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox47, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99976F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox47, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox47, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox47, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox48, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49976F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox48, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox48, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox48, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox49, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.051758E-05F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox49, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox49, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox49, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox5, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.5001F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox5, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox5, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox50, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99973F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox50, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox50, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox50, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox51, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49973F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox51, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox51, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox51, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox52, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.051758E-05F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox52, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox52, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox52, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox53, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99973F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox53, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox53, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox53, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox54, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49973F, 0.0001220703F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox54, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox54, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox54, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox55, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.051758E-05F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox55, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox55, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox56, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99973F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox56, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox56, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox56, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox57, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49973F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox57, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox57, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox57, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox58, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 2.288818E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox58, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox58, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox58, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox59, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 2.288818E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox59, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox59, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox59, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox6, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45.00008F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox6, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox6, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox6, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox60, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 2.288818E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox60, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox60, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox60, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox61, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 7.629395E-06F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox61, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox61, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox61, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox62, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 7.629395E-06F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox62, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox62, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox62, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox63, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 7.629395E-06F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox63, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox63, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox63, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox64, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox64, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox64, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox64, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox65, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox65, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox65, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox65, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox66, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox66, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox66, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox66, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox67, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox67, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox67, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox67, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox68, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox68, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox68, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox68, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox69, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox69, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox69, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox69, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox7, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0001271566F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox7, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox7, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox70, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 1.525879E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox70, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox70, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox70, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox71, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 1.525879E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox71, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox71, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox71, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox72, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 1.525879E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox72, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox72, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox72, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox73, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox73, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox73, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox73, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox74, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox74, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox74, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox74, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox75, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox75, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox75, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox75, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox76, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0003051758F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox76, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox76, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox76, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox77, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50003F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox77, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox77, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox77, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox78, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox78, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox78, "de", "SizeF", New System.Drawing.SizeF(22.50001F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox78, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox79, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99998F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox79, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox79, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox79, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox8, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.5001F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox8, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox8, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox80, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox80, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox80, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox80, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox81, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0002861023F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox81, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox81, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox82, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99998F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox82, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox82, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox82, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox83, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.50001F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox83, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox83, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox83, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox84, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0002861023F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox84, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox84, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox85, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99995F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox85, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox85, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox85, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox86, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49998F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox86, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox86, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox86, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox87, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0002593994F, 3.051758E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox87, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox87, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox87, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox88, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(44.99995F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox88, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox88, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox88, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox89, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.49998F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox89, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox89, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox89, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox9, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(45.00008F, 6.103516E-05F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox9, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox9, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox9, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox90, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(0.0002593994F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox90, "Default", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox90, "de", "SizeF", New System.Drawing.SizeF(22.5F, 27F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox90, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox91, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.814697E-06F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox91, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox91, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox92, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.99996F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox92, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox92, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox92, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox93, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(46.00004F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox93, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox93, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox93, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox94, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.814697E-06F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox94, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox94, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox95, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.99996F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox95, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox95, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox95, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox96, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(46.00004F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox96, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox96, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox96, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox97, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(3.814697E-06F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox97, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox97, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox98, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(22.99996F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox98, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox98, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox98, "Default", "Text", "checkBox1"), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox99, "Default", "LocationFloat", New DevExpress.Utils.PointFloat(46.00004F, 0F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox99, "Default", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox99, "de", "SizeF", New System.Drawing.SizeF(23F, 32.5F)), New DevExpress.XtraReports.Localization.LocalizationItem(Me.xrCheckBox99, "Default", "Text", "checkBox1")})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameterLanguage})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EditorKeyStyle, Me.EditorValueStyle, Me.GeneralTextStyleStyle, Me.SectionTitleStyle})
            Me.Version = "20.1"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.Report_BeforePrint)
            CType((Me.table6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table6 As DevExpress.XtraReports.UI.XRTable

        Private tableRow37 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell73 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell74 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow38 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell75 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell76 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow39 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell77 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell78 As DevExpress.XtraReports.UI.XRTableCell

        Private label6 As DevExpress.XtraReports.UI.XRLabel

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private tableRow24 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell47 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell48 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow25 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell49 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell50 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow26 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell51 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell52 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow27 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell53 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell54 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow28 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell55 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell56 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow29 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell57 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell58 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow30 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell59 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell60 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow31 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell61 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell62 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow32 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell63 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell64 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow33 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell65 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell66 As DevExpress.XtraReports.UI.XRTableCell

        Private table3 As DevExpress.XtraReports.UI.XRTable

        Private tableRow17 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell33 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox3 As DevExpress.XtraReports.UI.XRCheckBox

        Private checkBox2 As DevExpress.XtraReports.UI.XRCheckBox

        Private checkBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell34 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow18 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell35 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell36 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow19 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell37 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell38 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow20 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell39 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell40 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow21 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell41 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell42 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow22 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell43 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell44 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow23 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell45 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell46 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private label4 As DevExpress.XtraReports.UI.XRLabel

        Private label3 As DevExpress.XtraReports.UI.XRLabel

        Private label2 As DevExpress.XtraReports.UI.XRLabel

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow6 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow7 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell13 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell14 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow8 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell15 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell16 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow9 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell17 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell18 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow10 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell19 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell20 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow11 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell21 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell22 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow12 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell23 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell24 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow13 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell25 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell26 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow14 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell27 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell28 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow15 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell29 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell30 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow16 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell31 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell32 As DevExpress.XtraReports.UI.XRTableCell

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private labelCurrentDate As DevExpress.XtraReports.UI.XRLabel

        Private label15 As DevExpress.XtraReports.UI.XRLabel

        Private label14 As DevExpress.XtraReports.UI.XRLabel

        Private label13 As DevExpress.XtraReports.UI.XRLabel

        Private label12 As DevExpress.XtraReports.UI.XRLabel

        Private label11 As DevExpress.XtraReports.UI.XRLabel

        Private label10 As DevExpress.XtraReports.UI.XRLabel

        Private table10 As DevExpress.XtraReports.UI.XRTable

        Private tableRow56 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell129 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox24 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell130 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell131 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell132 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow57 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell133 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell134 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell135 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell136 As DevExpress.XtraReports.UI.XRTableCell

        Private table9 As DevExpress.XtraReports.UI.XRTable

        Private tableRow54 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell121 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell122 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell125 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell127 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow55 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell123 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell124 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell126 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell128 As DevExpress.XtraReports.UI.XRTableCell

        Private label9 As DevExpress.XtraReports.UI.XRLabel

        Private table8 As DevExpress.XtraReports.UI.XRTable

        Private tableRow45 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell107 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell108 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow46 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell109 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell110 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow49 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell111 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell112 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow50 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell113 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell114 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow51 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell115 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell116 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow52 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell117 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell118 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow53 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell119 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell120 As DevExpress.XtraReports.UI.XRTableCell

        Private label8 As DevExpress.XtraReports.UI.XRLabel

        Private label5 As DevExpress.XtraReports.UI.XRLabel

        Private table5 As DevExpress.XtraReports.UI.XRTable

        Private tableRow34 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell67 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox5 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell68 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow35 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell69 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox6 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell70 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow36 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell71 As DevExpress.XtraReports.UI.XRTableCell

        Private pictureBox7 As DevExpress.XtraReports.UI.XRPictureBox

        Private tableCell72 As DevExpress.XtraReports.UI.XRTableCell

        Private label7 As DevExpress.XtraReports.UI.XRLabel

        Private table7 As DevExpress.XtraReports.UI.XRTable

        Private tableRow40 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell89 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell79 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox10 As DevExpress.XtraReports.UI.XRCheckBox

        Private checkBox11 As DevExpress.XtraReports.UI.XRCheckBox

        Private checkBox12 As DevExpress.XtraReports.UI.XRCheckBox

        Private tableCell80 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell100 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow41 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell90 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell81 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell82 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell101 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow42 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell91 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell83 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell84 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell102 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow43 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell92 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell85 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell86 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell103 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow44 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell97 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell87 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell88 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell104 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow47 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell98 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell93 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell94 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell105 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow48 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell99 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell95 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell96 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell106 As DevExpress.XtraReports.UI.XRTableCell

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private EditorKeyStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private EditorValueStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private GeneralTextStyleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private SectionTitleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrCheckBox49 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox50 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox51 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox52 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox53 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox54 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox55 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox56 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox57 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox19 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox20 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox21 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox22 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox23 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox24 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox25 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox26 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox27 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox28 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox29 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox30 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox31 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox32 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox33 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox34 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox35 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox36 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox37 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox38 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox39 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox40 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox41 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox42 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox43 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox44 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox45 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox46 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox47 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox48 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox3 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox4 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox5 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox6 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox7 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox8 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox9 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox10 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox11 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox12 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox13 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox14 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox15 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox16 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox17 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox18 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox79 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox80 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox81 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox85 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox86 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox87 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox82 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox83 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox84 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox88 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox89 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox90 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox58 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox59 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox60 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox61 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox62 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox63 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox64 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox65 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox66 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox67 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox68 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox69 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox70 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox71 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox72 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox73 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox74 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox75 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox76 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox77 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox78 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox91 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox92 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox93 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox94 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox95 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox96 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox97 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox98 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox99 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox101 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox100 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox102 As DevExpress.XtraReports.UI.XRCheckBox

        Private parameterLanguage As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
