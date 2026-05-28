Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.PollingReport

    Public Partial Class PollingReport

        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.PollingReport.PollingReport))
            Dim fieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ResultingLink = New DevExpress.XtraReports.UI.XRLabel()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.ghLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.QuestionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.AnswerOptionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TextAnswerStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.DescriptionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.detailBand1.HeightF = 79F
            Me.detailBand1.Name = "detailBand1"
            AddHandler Me.detailBand1.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.detailBand1_BeforePrint)
            AddHandler Me.detailBand1.AfterPrint, New System.EventHandler(AddressOf Me.detailBand1_AfterPrint)
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(25.00007F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(599.9999F, 79F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1})
            Me.xrTableRow1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(Contains([AnswerType], 'Check') Or Contains([AnswerType], 'Radio'), 'True', ?" & ")")})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Visible = False
            Me.xrTableRow1.Weight = 0.45569621745500388R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox1})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrCheckBox1.EditOptions.Enabled = True
            Me.xrCheckBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Answer"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Tag", "AnswerType")})
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(599.9999F, 22F)
            Me.xrCheckBox1.StyleName = "AnswerOptionStyle"
            Me.xrCheckBox1.StylePriority.UseBackColor = False
            Me.xrCheckBox1.StylePriority.UseFont = False
            Me.xrCheckBox1.StylePriority.UsePadding = False
            Me.xrCheckBox1.StylePriority.UseTextAlignment = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2})
            Me.xrTableRow2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([AnswerType]  == 'RadioText', 'True', ?)")})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Visible = False
            Me.xrTableRow2.Weight = 0.49215191445344164R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel2.EditOptions.Enabled = True
            Me.xrLabel2.EditOptions.[ReadOnly] = True
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(30F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(569.9998F, 22F)
            Me.xrLabel2.StyleName = "TextAnswerStyle"
            Me.xrLabel2.StylePriority.UseBorderColor = False
            Me.xrLabel2.StylePriority.UseBorders = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell3})
            Me.xrTableRow3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([AnswerType]  == 'Text' Or [AnswerType]  == 'Number', 'True', ?)")})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Visible = False
            Me.xrTableRow3.Weight = 0.49215191259313812R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 1R
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel3.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel3.EditOptions.Enabled = True
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 3.919209E-05F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(599.9999F, 22.00001F)
            Me.xrLabel3.StyleName = "TextAnswerStyle"
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' ResultingLink
            ' 
            Me.ResultingLink.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((114)))))), (CInt(((CByte((45)))))))
            Me.ResultingLink.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
            Me.ResultingLink.ForeColor = System.Drawing.Color.White
            Me.ResultingLink.LocationFloat = New DevExpress.Utils.PointFloat(475F, 12.50002F)
            Me.ResultingLink.Name = "ResultingLink"
            Me.ResultingLink.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.ResultingLink.SizeF = New System.Drawing.SizeF(150.0006F, 32.50003F)
            Me.ResultingLink.StylePriority.UseBackColor = False
            Me.ResultingLink.StylePriority.UseFont = False
            Me.ResultingLink.StylePriority.UseForeColor = False
            Me.ResultingLink.StylePriority.UseTextAlignment = False
            Me.ResultingLink.Text = "Show Results"
            Me.ResultingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "|DataDirectory|\Questions.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            fieldInfo1.Name = "QuestionID"
            fieldInfo1.Type = GetType(Integer)
            fieldInfo2.Name = "Question"
            fieldInfo2.Type = GetType(String)
            fieldInfo3.Name = "Answer"
            fieldInfo3.Type = GetType(String)
            fieldInfo4.Name = "AnswerType"
            fieldInfo4.Type = GetType(String)
            fieldInfo5.Name = "AnswerID"
            fieldInfo5.Type = GetType(Integer)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5})
            excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetName = "Answers"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = excelSourceOptions1
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ghLabel, Me.xrLine3})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
            Me.GroupHeader1.HeightF = 57.49673F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' ghLabel
            ' 
            Me.ghLabel.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.ghLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Question")})
            Me.ghLabel.LocationFloat = New DevExpress.Utils.PointFloat(25.00052F, 25.00001F)
            Me.ghLabel.Name = "ghLabel"
            Me.ghLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.ghLabel.SizeF = New System.Drawing.SizeF(600.0001F, 27F)
            Me.ghLabel.StyleName = "QuestionStyle"
            Me.ghLabel.StylePriority.UseFont = False
            Me.ghLabel.Text = "ghLabel"
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLine3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((226)))))), (CInt(((CByte((226)))))), (CInt(((CByte((226)))))))
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.SizeF = New System.Drawing.SizeF(650F, 12.49997F)
            Me.xrLine3.StylePriority.UseForeColor = False
            ' 
            ' QuestionStyle
            ' 
            Me.QuestionStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 11.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.QuestionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((112)))))), (CInt(((CByte((112)))))), (CInt(((CByte((112)))))))
            Me.QuestionStyle.Name = "QuestionStyle"
            ' 
            ' AnswerOptionStyle
            ' 
            Me.AnswerOptionStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.AnswerOptionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((112)))))), (CInt(((CByte((112)))))), (CInt(((CByte((112)))))))
            Me.AnswerOptionStyle.Name = "AnswerOptionStyle"
            Me.AnswerOptionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' TextAnswerStyle
            ' 
            Me.TextAnswerStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((193)))))), (CInt(((CByte((193)))))))
            Me.TextAnswerStyle.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.TextAnswerStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F)
            Me.TextAnswerStyle.ForeColor = System.Drawing.Color.Black
            Me.TextAnswerStyle.Name = "TextAnswerStyle"
            Me.TextAnswerStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
            Me.TextAnswerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.xrLabel4, Me.xrLabel1})
            Me.ReportHeader.HeightF = 96.78207F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((112)))))), (CInt(((CByte((112)))))), (CInt(((CByte((112)))))))
            Me.xrLine1.LineWidth = 2
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 2F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(24.99975F, 58F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(600.0002F, 24.99998F)
            Me.xrLabel4.StyleName = "DescriptionStyle"
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "Please take some time to fill in the following questionnaire. "
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25.00052F, 25.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(600F, 33F)
            Me.xrLabel1.StyleName = "TitleStyle"
            Me.xrLabel1.Text = "An analysis of the use of multimedia"
            ' 
            ' TitleStyle
            ' 
            Me.TitleStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.TitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((114)))))), (CInt(((CByte((45)))))))
            Me.TitleStyle.Name = "TitleStyle"
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ResultingLink})
            Me.ReportFooter.HeightF = 45.00005F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' DescriptionStyle
            ' 
            Me.DescriptionStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.DescriptionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((112)))))), (CInt(((CByte((112)))))), (CInt(((CByte((112)))))))
            Me.DescriptionStyle.Name = "DescriptionStyle"
            Me.DescriptionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PollingReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.GroupHeader1, Me.ReportHeader, Me.ReportFooter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.excelDataSource1})
            Me.DataSource = Me.excelDataSource1
            Me.SnappingMode = CType(((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid)), DevExpress.XtraReports.UI.SnappingMode)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.QuestionStyle, Me.AnswerOptionStyle, Me.TextAnswerStyle, Me.TitleStyle, Me.DescriptionStyle})
            Me.Version = "17.2"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.PollingReport_BeforePrint)
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private detailBand1 As DevExpress.XtraReports.UI.DetailBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private ghLabel As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Public ResultingLink As DevExpress.XtraReports.UI.XRLabel

        Private QuestionStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private AnswerOptionStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private TitleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private TextAnswerStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private DescriptionStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine

        Private xrLine3 As DevExpress.XtraReports.UI.XRLine
    End Class
End Namespace
