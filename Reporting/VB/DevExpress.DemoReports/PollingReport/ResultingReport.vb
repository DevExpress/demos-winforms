Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PollingReport

    Public Class ResultingReport
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private detailBand1 As DetailBand

        Private components As System.ComponentModel.IContainer

        Private bottomMarginBand1 As BottomMarginBand

        Public PollingLink As XRLabel

        Private ReportFooter As ReportFooterBand

        Private ReportHeader As ReportHeaderBand

        Private paramPollCount As DevExpress.XtraReports.Parameters.Parameter

        Private xrChart1 As XRChart

        Private ghStyle1 As XRControlStyle

        Private ghStyle2 As XRControlStyle

        Private detStyle1Odd As XRControlStyle

        Private xrTable1 As XRTable

        Private xrTableRow5 As XRTableRow

        Private xrTableCell9 As XRTableCell

        Private xrTableCell10 As XRTableCell

        Private detStyle1Even As XRControlStyle

        Private xrLine2 As XRLine

        Private xrLine1 As XRLine

        Private xrSubreport1 As XRSubreport

        Private GroupHeader1 As GroupHeaderBand

        Public ResultingReportDS As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Public Sub New()
            InitializeComponent()
            Dim subreport As ResultingTableReport = TryCast(xrSubreport1.ReportSource, ResultingTableReport)
            If subreport IsNot Nothing Then
                subreport.ResultingTableReportDS.DataSource = ResultingReportDS
                subreport.Colors = GetColorList(xrChart1.PaletteRepository(xrChart1.PaletteName))
            End If
        End Sub

        Private Function GetColorList(ByVal palette As Palette) As List(Of Color)
            Dim list As List(Of Color) = New List(Of Color)()
            For Each item As PaletteEntry In palette
                list.Add(item.Color)
            Next

            Return list
        End Function

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim simpleDiagram1 As SimpleDiagram = New SimpleDiagram()
            Dim series1 As Series = New Series()
            Dim pieSeriesLabel1 As PieSeriesLabel = New PieSeriesLabel()
            Dim pieSeriesView1 As PieSeriesView = New PieSeriesView()
            topMarginBand1 = New TopMarginBand()
            detailBand1 = New DetailBand()
            xrChart1 = New XRChart()
            bottomMarginBand1 = New BottomMarginBand()
            PollingLink = New XRLabel()
            xrLine1 = New XRLine()
            ReportFooter = New ReportFooterBand()
            ReportHeader = New ReportHeaderBand()
            xrLine2 = New XRLine()
            xrTable1 = New XRTable()
            xrTableRow5 = New XRTableRow()
            xrTableCell9 = New XRTableCell()
            xrTableCell10 = New XRTableCell()
            paramPollCount = New DevExpress.XtraReports.Parameters.Parameter()
            ghStyle1 = New XRControlStyle()
            ghStyle2 = New XRControlStyle()
            detStyle1Odd = New XRControlStyle()
            detStyle1Even = New XRControlStyle()
            GroupHeader1 = New GroupHeaderBand()
            xrSubreport1 = New XRSubreport()
            ResultingReportDS = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components)
            CType(xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(ResultingReportDS, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            detailBand1.HeightF = 0F
            detailBand1.Name = "detailBand1"
            detailBand1.StylePriority.UseFont = False
            ' 
            ' xrChart1
            ' 
            xrChart1.AnchorHorizontal = HorizontalAnchorStyles.Left Or HorizontalAnchorStyles.Right
            xrChart1.AnchorVertical = VerticalAnchorStyles.Top Or VerticalAnchorStyles.Bottom
            xrChart1.AppearanceNameSerializable = "Light"
            xrChart1.BorderColor = System.Drawing.Color.Black
            xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            simpleDiagram1.EqualPieSize = True
            simpleDiagram1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical
            xrChart1.Diagram = simpleDiagram1
            xrChart1.Legend.Name = "Default Legend"
            xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(350F, 37.5F)
            xrChart1.Name = "xrChart1"
            xrChart1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            xrChart1.Parameters.AddRange(New XRControlParameter() {New XRControlParameter("parameterQuestionID", Nothing, "QuestionID")})
            series1.ArgumentDataMember = "Answer"
            series1.FilterString = "[QuestionID] = ?parameterQuestionID"
            pieSeriesLabel1.TextPattern = "{A}"
            series1.Label = pieSeriesLabel1
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "AnswerCount"
            pieSeriesView1.MinAllowedSizePercentage = 75R
            series1.View = pieSeriesView1
            xrChart1.SeriesSerializable = New Series() {series1}
            xrChart1.SizeF = New System.Drawing.SizeF(300F, 187.5F)
            xrChart1.StylePriority.UsePadding = False
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' PollingLink
            ' 
            PollingLink.BackColor = System.Drawing.Color.FromArgb(255, 114, 45)
            PollingLink.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            PollingLink.ForeColor = System.Drawing.Color.White
            PollingLink.LocationFloat = New DevExpress.Utils.PointFloat(25F, 25F)
            PollingLink.Name = "PollingLink"
            PollingLink.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            PollingLink.SizeF = New System.Drawing.SizeF(150F, 32.5F)
            PollingLink.StylePriority.UseBackColor = False
            PollingLink.StylePriority.UseFont = False
            PollingLink.StylePriority.UseForeColor = False
            PollingLink.StylePriority.UseTextAlignment = False
            PollingLink.Text = "Start a new poll"
            PollingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLine1
            ' 
            xrLine1.AnchorHorizontal = HorizontalAnchorStyles.Left Or HorizontalAnchorStyles.Right
            xrLine1.ForeColor = System.Drawing.Color.FromArgb(226, 226, 226)
            xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
            xrLine1.Name = "xrLine1"
            xrLine1.SizeF = New System.Drawing.SizeF(650F, 12.49997F)
            xrLine1.StylePriority.UseForeColor = False
            ' 
            ' ReportFooter
            ' 
            ReportFooter.Controls.AddRange(New XRControl() {PollingLink})
            ReportFooter.HeightF = 57.5F
            ReportFooter.Name = "ReportFooter"
            ' 
            ' ReportHeader
            ' 
            ReportHeader.Controls.AddRange(New XRControl() {xrLine2, xrTable1})
            ReportHeader.HeightF = 62.49999F
            ReportHeader.Name = "ReportHeader"
            ReportHeader.StylePriority.UseFont = False
            ' 
            ' xrLine2
            ' 
            xrLine2.AnchorHorizontal = HorizontalAnchorStyles.Left Or HorizontalAnchorStyles.Right
            xrLine2.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112)
            xrLine2.LineWidth = 2F
            xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            xrLine2.Name = "xrLine2"
            xrLine2.SizeF = New System.Drawing.SizeF(650F, 2.083333F)
            xrLine2.StylePriority.UseForeColor = False
            ' 
            ' xrTable1
            ' 
            xrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            xrTable1.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112)
            xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(25F, 25F)
            xrTable1.Name = "xrTable1"
            xrTable1.Rows.AddRange(New XRTableRow() {xrTableRow5})
            xrTable1.SizeF = New System.Drawing.SizeF(600F, 33F)
            xrTable1.StylePriority.UseFont = False
            xrTable1.StylePriority.UseForeColor = False
            xrTable1.StylePriority.UseTextAlignment = False
            ' 
            ' xrTableRow5
            ' 
            xrTableRow5.Cells.AddRange(New XRTableCell() {xrTableCell9, xrTableCell10})
            xrTableRow5.Name = "xrTableRow5"
            xrTableRow5.Weight = 0.65999999999999992R
            ' 
            ' xrTableCell9
            ' 
            xrTableCell9.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            xrTableCell9.ForeColor = System.Drawing.Color.FromArgb(255, 114, 45)
            xrTableCell9.Name = "xrTableCell9"
            xrTableCell9.StylePriority.UseFont = False
            xrTableCell9.StylePriority.UseForeColor = False
            xrTableCell9.StylePriority.UseTextAlignment = False
            xrTableCell9.Text = "Polling results"
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            xrTableCell9.Weight = 1.4950000859781933R
            ' 
            ' xrTableCell10
            ' 
            xrTableCell10.Name = "xrTableCell10"
            xrTableCell10.StylePriority.UseTextAlignment = False
            xrTableCell10.Text = "Number of people polled : [Parameters.paramPollCount]"
            xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            xrTableCell10.Weight = 1.26500004317221R
            xrTableCell10.WordWrap = False
            ' 
            ' paramPollCount
            ' 
            paramPollCount.Description = "Poll Count"
            paramPollCount.Name = "paramPollCount"
            paramPollCount.Type = GetType(Integer)
            paramPollCount.ValueInfo = "0"
            paramPollCount.Visible = False
            ' 
            ' ghStyle1
            ' 
            ghStyle1.Font = New DevExpress.Drawing.DXFont("Tahoma", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            ghStyle1.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112)
            ghStyle1.Name = "ghStyle1"
            ghStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            ghStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ghStyle2
            ' 
            ghStyle2.BackColor = System.Drawing.Color.FromArgb(141, 141, 141)
            ghStyle2.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            ghStyle2.ForeColor = System.Drawing.Color.White
            ghStyle2.Name = "ghStyle2"
            ghStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' detStyle1Odd
            ' 
            detStyle1Odd.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            detStyle1Odd.Name = "detStyle1Odd"
            ' 
            ' detStyle1Even
            ' 
            detStyle1Even.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
            detStyle1Even.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            detStyle1Even.Name = "detStyle1Even"
            ' 
            ' GroupHeader1
            ' 
            GroupHeader1.Controls.AddRange(New XRControl() {xrLine1, xrSubreport1, xrChart1})
            GroupHeader1.GroupFields.AddRange(New GroupField() {New GroupField("QuestionID", XRColumnSortOrder.Ascending)})
            GroupHeader1.HeightF = 225F
            GroupHeader1.KeepTogether = True
            GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrSubreport1
            ' 
            xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(25.00003F, 37.5F)
            xrSubreport1.Name = "xrSubreport1"
            xrSubreport1.ParameterBindings.Add(New ParameterBinding("paramQuestionID", Nothing, "QuestionID"))
            xrSubreport1.ReportSource = New ResultingTableReport()
            xrSubreport1.SizeF = New System.Drawing.SizeF(325F, 187.5F)
            ' 
            ' ResultingReportDS
            ' 
            ResultingReportDS.DataSource = GetType(ResultingData)
            ResultingReportDS.Name = "ResultingReportDS"
            ' 
            ' ResultingReport
            ' 
            Bands.AddRange(New Band() {topMarginBand1, detailBand1, bottomMarginBand1, ReportFooter, ReportHeader, GroupHeader1})
            ComponentStorage.AddRange(New System.ComponentModel.IComponent() {ResultingReportDS})
            DataSource = ResultingReportDS
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {paramPollCount})
            SnappingMode = SnappingMode.SnapLines Or SnappingMode.SnapToGrid
            StyleSheet.AddRange(New XRControlStyle() {ghStyle1, ghStyle2, detStyle1Odd, detStyle1Even})
            Version = "19.2"
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(ResultingReportDS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
