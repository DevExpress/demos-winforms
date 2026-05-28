Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PollingReport

    Public Class ResultingTableReport
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private detailBand1 As DetailBand

        Private components As System.ComponentModel.IContainer

        Private bottomMarginBand1 As BottomMarginBand

        Private dtlTable1 As XRTable

        Private detailTableRow As XRTableRow

        Private xrTableCell1 As XRTableCell

        Private xrTableCell2 As XRTableCell

        Private xrTableCell3 As XRTableCell

        Private ghTable1 As XRTable

        Private xrTableRow2 As XRTableRow

        Private xrTableCell4 As XRTableCell

        Private paramQuestionID As DevExpress.XtraReports.Parameters.Parameter

        Private questionStyle As XRControlStyle

        Private xrTableRow4 As XRTableRow

        Private xrTableCell6 As XRTableCell

        Private xrTableCell8 As XRTableCell

        Private headerStyle As XRControlStyle

        Private detailStyleEven As XRControlStyle

        Private xrTableCell12 As XRTableCell

        Friend ResultingTableReportDS As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private GroupHeader1 As GroupHeaderBand

        Private xrLabel1 As XRLabel

        Private detailStyleOdd As XRControlStyle

        Private xrTableCell5 As XRTableCell

        Private xrShape1 As XRShape

        Private ReadOnly emptyAnswerTextColor As System.Drawing.Color

        Friend Property Colors As List(Of Color)

        Public Sub New()
            InitializeComponent()
            emptyAnswerTextColor = detailTableRow.ForeColor
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim shapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
            Dim xrSummary1 As XRSummary = New XRSummary()
            topMarginBand1 = New TopMarginBand()
            detailBand1 = New DetailBand()
            dtlTable1 = New XRTable()
            detailTableRow = New XRTableRow()
            xrTableCell5 = New XRTableCell()
            xrShape1 = New XRShape()
            xrTableCell1 = New XRTableCell()
            xrTableCell2 = New XRTableCell()
            xrTableCell3 = New XRTableCell()
            bottomMarginBand1 = New BottomMarginBand()
            ghTable1 = New XRTable()
            xrTableRow2 = New XRTableRow()
            xrTableCell4 = New XRTableCell()
            xrLabel1 = New XRLabel()
            xrTableRow4 = New XRTableRow()
            xrTableCell12 = New XRTableCell()
            xrTableCell8 = New XRTableCell()
            xrTableCell6 = New XRTableCell()
            paramQuestionID = New DevExpress.XtraReports.Parameters.Parameter()
            questionStyle = New XRControlStyle()
            headerStyle = New XRControlStyle()
            detailStyleEven = New XRControlStyle()
            detailStyleOdd = New XRControlStyle()
            GroupHeader1 = New GroupHeaderBand()
            ResultingTableReportDS = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components)
            CType(dtlTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ghTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ResultingTableReportDS, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.HeightF = 100F
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            detailBand1.Controls.AddRange(New XRControl() {dtlTable1})
            detailBand1.HeightF = 30F
            detailBand1.Name = "detailBand1"
            detailBand1.StylePriority.UseFont = False
            ' 
            ' dtlTable1
            ' 
            dtlTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            dtlTable1.Name = "dtlTable1"
            dtlTable1.Rows.AddRange(New XRTableRow() {detailTableRow})
            dtlTable1.SizeF = New System.Drawing.SizeF(325F, 30F)
            dtlTable1.StylePriority.UseTextAlignment = False
            dtlTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' detailTableRow
            ' 
            detailTableRow.Cells.AddRange(New XRTableCell() {xrTableCell5, xrTableCell1, xrTableCell2, xrTableCell3})
            detailTableRow.EvenStyleName = "detailStyleEven"
            detailTableRow.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141)
            detailTableRow.Name = "detailTableRow"
            detailTableRow.OddStyleName = "detailStyleOdd"
            detailTableRow.StylePriority.UseForeColor = False
            detailTableRow.Weight = 1R
            AddHandler detailTableRow.BeforePrint, New BeforePrintEventHandler(AddressOf detailTableRow_BeforePrint)
            ' 
            ' xrTableCell5
            ' 
            xrTableCell5.Controls.AddRange(New XRControl() {xrShape1})
            xrTableCell5.Name = "xrTableCell5"
            xrTableCell5.StylePriority.UsePadding = False
            xrTableCell5.StylePriority.UseTextAlignment = False
            xrTableCell5.Weight = 0.26494085357768737R
            ' 
            ' xrShape1
            ' 
            xrShape1.ForeColor = System.Drawing.Color.Transparent
            xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(5F, 2.5F)
            xrShape1.Name = "xrShape1"
            xrShape1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F)
            xrShape1.Shape = shapeRectangle1
            xrShape1.SizeF = New System.Drawing.SizeF(24.99998F, 25F)
            xrShape1.StylePriority.UseForeColor = False
            xrShape1.StylePriority.UsePadding = False
            ' 
            ' xrTableCell1
            ' 
            xrTableCell1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Answer")})
            xrTableCell1.Multiline = True
            xrTableCell1.Name = "xrTableCell1"
            xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            xrTableCell1.StylePriority.UsePadding = False
            xrTableCell1.StylePriority.UseTextAlignment = False
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell1.Weight = 1.5749258970746736R
            ' 
            ' xrTableCell2
            ' 
            xrTableCell2.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "AnswerCount")})
            xrTableCell2.Name = "xrTableCell2"
            xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            xrTableCell2.StylePriority.UsePadding = False
            xrTableCell2.StylePriority.UseTextAlignment = False
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell2.Weight = 0.45996698152369797R
            ' 
            ' xrTableCell3
            ' 
            xrTableCell3.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "sumPercentage(AnswerCount)")})
            xrTableCell3.Name = "xrTableCell3"
            xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            xrTableCell3.StylePriority.UsePadding = False
            xrTableCell3.StylePriority.UseTextAlignment = False
            xrSummary1.Running = SummaryRunning.Group
            xrTableCell3.Summary = xrSummary1
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell3.Weight = 0.5703587583536065R
            xrTableCell3.TextFormatString = "{0:0.0%}"
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.HeightF = 100F
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' ghTable1
            ' 
            ghTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            ghTable1.Name = "ghTable1"
            ghTable1.Rows.AddRange(New XRTableRow() {xrTableRow2, xrTableRow4})
            ghTable1.SizeF = New System.Drawing.SizeF(325F, 63.54F)
            ' 
            ' xrTableRow2
            ' 
            xrTableRow2.Cells.AddRange(New XRTableCell() {xrTableCell4})
            xrTableRow2.Name = "xrTableRow2"
            xrTableRow2.StylePriority.UseTextAlignment = False
            xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            xrTableRow2.Weight = 1.7039473665263247R
            ' 
            ' xrTableCell4
            ' 
            xrTableCell4.Controls.AddRange(New XRControl() {xrLabel1})
            xrTableCell4.Name = "xrTableCell4"
            xrTableCell4.StylePriority.UsePadding = False
            xrTableCell4.Weight = 3.8269230769230766R
            ' 
            ' xrLabel1
            ' 
            xrLabel1.AnchorHorizontal = HorizontalAnchorStyles.Left Or HorizontalAnchorStyles.Right
            xrLabel1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Question")})
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.SizeF = New System.Drawing.SizeF(325F, 25F)
            xrLabel1.StyleName = "questionStyle"
            xrLabel1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow4
            ' 
            xrTableRow4.Cells.AddRange(New XRTableCell() {xrTableCell12, xrTableCell8, xrTableCell6})
            xrTableRow4.Name = "xrTableRow4"
            xrTableRow4.StyleName = "headerStyle"
            xrTableRow4.StylePriority.UseTextAlignment = False
            xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            xrTableRow4.Weight = 1.1052630062961615R
            ' 
            ' xrTableCell12
            ' 
            xrTableCell12.Name = "xrTableCell12"
            xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F)
            xrTableCell12.StylePriority.UsePadding = False
            xrTableCell12.StylePriority.UseTextAlignment = False
            xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell12.Weight = 2.2579717305482263R
            ' 
            ' xrTableCell8
            ' 
            xrTableCell8.Name = "xrTableCell8"
            xrTableCell8.StylePriority.UseBorderColor = False
            xrTableCell8.StylePriority.UseBorders = False
            xrTableCell8.StylePriority.UseBorderWidth = False
            xrTableCell8.StylePriority.UsePadding = False
            xrTableCell8.StylePriority.UseTextAlignment = False
            xrTableCell8.Text = "Voted"
            xrTableCell8.Weight = 0.56449296046847441R
            ' 
            ' xrTableCell6
            ' 
            xrTableCell6.Name = "xrTableCell6"
            xrTableCell6.Text = "Percent"
            xrTableCell6.Weight = 0.69997138007444848R
            ' 
            ' paramQuestionID
            ' 
            paramQuestionID.Description = "Question ID"
            paramQuestionID.Name = "paramQuestionID"
            paramQuestionID.Type = GetType(Integer)
            paramQuestionID.ValueInfo = "0"
            paramQuestionID.Visible = False
            ' 
            ' questionStyle
            ' 
            questionStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            questionStyle.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112)
            questionStyle.Name = "questionStyle"
            questionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' headerStyle
            ' 
            headerStyle.BackColor = System.Drawing.Color.FromArgb(141, 141, 141)
            headerStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            headerStyle.ForeColor = System.Drawing.Color.White
            headerStyle.Name = "headerStyle"
            headerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' detailStyleEven
            ' 
            detailStyleEven.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            detailStyleEven.Name = "detailStyleEven"
            ' 
            ' detailStyleOdd
            ' 
            detailStyleOdd.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
            detailStyleOdd.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            detailStyleOdd.Name = "detailStyleOdd"
            ' 
            ' GroupHeader1
            ' 
            GroupHeader1.Controls.AddRange(New XRControl() {ghTable1})
            GroupHeader1.GroupFields.AddRange(New GroupField() {New GroupField("QuestionID", XRColumnSortOrder.Ascending)})
            GroupHeader1.HeightF = 63.54168F
            GroupHeader1.Name = "GroupHeader1"
            ' 
            ' ResultingTableReportDS
            ' 
            ResultingTableReportDS.DataMember = ""
            ResultingTableReportDS.DataSource = GetType(ResultingData)
            ResultingTableReportDS.Name = "ResultingTableReportDS"
            ' 
            ' ResultingTableReport
            ' 
            Bands.AddRange(New Band() {topMarginBand1, detailBand1, bottomMarginBand1, GroupHeader1})
            ComponentStorage.AddRange(New System.ComponentModel.IComponent() {ResultingTableReportDS})
            DataSource = ResultingTableReportDS
            FilterString = "[QuestionID] = ?paramQuestionID"
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {paramQuestionID})
            SnappingMode = SnappingMode.SnapLines Or SnappingMode.SnapToGrid
            StyleSheet.AddRange(New XRControlStyle() {questionStyle, headerStyle, detailStyleEven, detailStyleOdd})
            Version = "17.2"
            CType(dtlTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ghTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ResultingTableReportDS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

        Private Sub detailTableRow_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim voted As Integer = Report.GetCurrentColumnValue(Of Integer)("AnswerCount")
            If Colors Is Nothing OrElse Colors.Count = 0 Then
                detailTableRow.ForeColor = If(voted > 0, Color.Black, emptyAnswerTextColor)
                xrShape1.FillColor = System.Drawing.Color.Transparent
            ElseIf voted > 0 Then
                Dim colorIndex As Integer = Report.CurrentRowIndex Mod Colors.Count
                xrShape1.FillColor = Colors(colorIndex)
                detailTableRow.ForeColor = xrShape1.FillColor
            Else
                detailTableRow.ForeColor = emptyAnswerTextColor
                xrShape1.FillColor = System.Drawing.Color.Transparent
            End If
        End Sub
    End Class
End Namespace
