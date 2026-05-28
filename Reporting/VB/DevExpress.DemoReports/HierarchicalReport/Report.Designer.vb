Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.HierarchicalReport

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.HierarchicalReport.Report))
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
            Me.xrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 85F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((215)))))), (CInt(((CByte((220)))))), (CInt(((CByte((229)))))))
            Me.Detail.BorderWidth = 1F
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCheckBox1, Me.label6, Me.label5, Me.label4, Me.label3, Me.label2, Me.label1})
            Me.Detail.DrillDownControl = Me.xrCheckBox1
            Me.Detail.EvenStyleName = "EvenStyle"
            Me.Detail.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[RegionID] == -1"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([DataSource.CurrentRowHierarchyLevel] == 0, Rgb(231,235,244), ?)")})
            Me.Detail.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.Detail.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((74)))))), (CInt(((CByte((81)))))), (CInt(((CByte((87)))))))
            Me.Detail.HeightF = 32F
            Me.Detail.HierarchyPrintOptions.Indent = 30F
            Me.Detail.HierarchyPrintOptions.KeyFieldName = "ID"
            Me.Detail.HierarchyPrintOptions.ParentFieldName = "RegionID"
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Region", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.StylePriority.UseBackColor = False
            Me.Detail.StylePriority.UseBorderColor = False
            Me.Detail.StylePriority.UseBorderWidth = False
            Me.Detail.StylePriority.UseFont = False
            Me.Detail.StylePriority.UseForeColor = False
            Me.Detail.StylePriority.UsePadding = False
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCheckBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[ReportItems].[Detail].[DrillDownExpanded]")})
            Me.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Checked"))
            Me.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked"))
            Me.xrCheckBox1.GlyphOptions.Style = DevExpress.XtraPrinting.GlyphStyle.Toggle
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(1.001602F, 0F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(30.9984F, 32F)
            Me.xrCheckBox1.StylePriority.UsePadding = False
            Me.xrCheckBox1.Text = "xrCheckBox1"
            ' 
            ' label6
            ' 
            Me.label6.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.label6.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label6.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label6.CanGrow = False
            Me.label6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MarketShare]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[RegionID] == -1"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([MarketShare] >= 0.85, Rgb(203,239,230)," & Global.Microsoft.VisualBasic.Constants.vbLf & "iif([MarketShare] <= 0.25, Rgb(245,2" & "20,225), ?))")})
            Me.label6.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(735F, 0F)
            Me.label6.Multiline = True
            Me.label6.Name = "label6"
            Me.label6.SizeF = New System.Drawing.SizeF(165F, 31.99999F)
            Me.label6.StylePriority.UseBackColor = False
            Me.label6.StylePriority.UseBorders = False
            Me.label6.StylePriority.UseFont = False
            Me.label6.StylePriority.UseForeColor = False
            Me.label6.StylePriority.UsePadding = False
            Me.label6.StylePriority.UseTextAlignment = False
            Me.label6.Text = "label6"
            Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.label6.TextFormatString = "{0:0%}"
            ' 
            ' label5
            ' 
            Me.label5.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.label5.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label5.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label5.CanGrow = False
            Me.label5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "iif(([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales] > 0, Rgb(66,163," & "137)," & Global.Microsoft.VisualBasic.Constants.vbLf & "iif(([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales]  < 0, Rgb" & "(202,87,112), ?))")})
            Me.label5.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(610F, 0F)
            Me.label5.Multiline = True
            Me.label5.Name = "label5"
            Me.label5.SizeF = New System.Drawing.SizeF(125F, 31.99999F)
            Me.label5.StylePriority.UseBorders = False
            Me.label5.StylePriority.UseFont = False
            Me.label5.StylePriority.UseForeColor = False
            Me.label5.StylePriority.UsePadding = False
            Me.label5.StylePriority.UseTextAlignment = False
            Me.label5.Text = "label5"
            Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.label5.TextFormatString = "{0:0.00%}"
            ' 
            ' label4
            ' 
            Me.label4.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.label4.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label4.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label4.CanGrow = False
            Me.label4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "([MarchSales] - [MarchSalesPrev]) / [MarchSales]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "iif(([MarchSales] - [MarchSalesPrev]) / [MarchSales] > 0, Rgb(66,163,137)," & Global.Microsoft.VisualBasic.Constants.vbLf & "iif(([" & "MarchSales] - [MarchSalesPrev]) / [MarchSales]  < 0, Rgb(202,87,112), ?))")})
            Me.label4.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(485F, 0F)
            Me.label4.Multiline = True
            Me.label4.Name = "label4"
            Me.label4.SizeF = New System.Drawing.SizeF(125F, 31.99999F)
            Me.label4.StylePriority.UseBorders = False
            Me.label4.StylePriority.UseFont = False
            Me.label4.StylePriority.UseForeColor = False
            Me.label4.StylePriority.UsePadding = False
            Me.label4.StylePriority.UseTextAlignment = False
            Me.label4.Text = "label4"
            Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.label4.TextFormatString = "{0:0.00%}"
            ' 
            ' label3
            ' 
            Me.label3.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.label3.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label3.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label3.CanGrow = False
            Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SeptemberSales]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([SeptemberSales] >= 28000, Rgb(203,239,230)," & Global.Microsoft.VisualBasic.Constants.vbLf & "iif([SeptemberSales] <= 6000, Rg" & "b(245,220,225), ?))")})
            Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(360F, 0F)
            Me.label3.Multiline = True
            Me.label3.Name = "label3"
            Me.label3.SizeF = New System.Drawing.SizeF(125F, 31.99999F)
            Me.label3.StylePriority.UseBorders = False
            Me.label3.StylePriority.UsePadding = False
            Me.label3.StylePriority.UseTextAlignment = False
            Me.label3.Text = "label3"
            Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.label3.TextFormatString = "{0:c2}"
            ' 
            ' label2
            ' 
            Me.label2.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
            Me.label2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label2.CanGrow = False
            Me.label2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MarchSales]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([MarchSales] >= 25000, Rgb(203,239,230)," & Global.Microsoft.VisualBasic.Constants.vbLf & "iif([MarchSales] <= 6000, Rgb(245,22" & "0,225), ?))")})
            Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(235F, 0F)
            Me.label2.Multiline = True
            Me.label2.Name = "label2"
            Me.label2.SizeF = New System.Drawing.SizeF(125F, 31.99999F)
            Me.label2.StylePriority.UseBorders = False
            Me.label2.StylePriority.UsePadding = False
            Me.label2.StylePriority.UseTextAlignment = False
            Me.label2.Text = "label2"
            Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.label2.TextFormatString = "{0:c2}"
            ' 
            ' label1
            ' 
            Me.label1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.label1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.label1.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.label1.CanGrow = False
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Region]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Padding.Left", "iif([DataSource.CurrentRowHierarchyLevel] == 0, 0, ?)")})
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(32F, 0F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(203F, 32F)
            Me.label1.StylePriority.UseBorders = False
            Me.label1.StylePriority.UsePadding = False
            Me.label1.StylePriority.UseTextAlignment = False
            Me.label1.Text = "label1"
            Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 85F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label7})
            Me.ReportHeader.HeightF = 95F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.StylePriority.UseBackColor = False
            Me.ReportHeader.StylePriority.UseBorderColor = False
            Me.ReportHeader.StylePriority.UseBorderWidth = False
            Me.ReportHeader.StylePriority.UseFont = False
            Me.ReportHeader.StylePriority.UsePadding = False
            ' 
            ' label7
            ' 
            Me.label7.Font = New DevExpress.Drawing.DXFont("Arial", 26F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label7.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((73)))))), (CInt(((CByte((80)))))), (CInt(((CByte((87)))))))
            Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label7.Multiline = True
            Me.label7.Name = "label7"
            Me.label7.SizeF = New System.Drawing.SizeF(900F, 95F)
            Me.label7.StylePriority.UseFont = False
            Me.label7.StylePriority.UseForeColor = False
            Me.label7.StylePriority.UsePadding = False
            Me.label7.StylePriority.UseTextAlignment = False
            Me.label7.Text = "Market Share Report"
            Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' GroupHeader
            ' 
            Me.GroupHeader.BorderWidth = 1F
            Me.GroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupHeader.HeightF = 66F
            Me.GroupHeader.Name = "GroupHeader"
            Me.GroupHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F)
            Me.GroupHeader.RepeatEveryPage = True
            Me.GroupHeader.StylePriority.UseBorderWidth = False
            Me.GroupHeader.StylePriority.UseFont = False
            Me.GroupHeader.StylePriority.UsePadding = False
            ' 
            ' table1
            ' 
            Me.table1.BorderWidth = 1F
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.tableRow1, Me.tableRow3})
            Me.table1.SizeF = New System.Drawing.SizeF(899.9999F, 66F)
            Me.table1.StylePriority.UseBorders = False
            Me.table1.StylePriority.UseBorderWidth = False
            Me.table1.StylePriority.UsePadding = False
            Me.table1.StylePriority.UseTextAlignment = False
            Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((110)))))), (CInt(((CByte((116)))))), (CInt(((CByte((128)))))))
            Me.tableRow2.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((147)))))), (CInt(((CByte((157)))))))
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell10, Me.tableCell12})
            Me.tableRow2.ForeColor = System.Drawing.Color.White
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.StylePriority.UseBackColor = False
            Me.tableRow2.StylePriority.UseBorderColor = False
            Me.tableRow2.StylePriority.UseBorderWidth = False
            Me.tableRow2.StylePriority.UseForeColor = False
            Me.tableRow2.Weight = 6.4912228827233625R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell7.Multiline = True
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StylePriority.UseBorders = False
            Me.tableCell7.Text = "Sales"
            Me.tableCell7.Weight = 6.0560158592110644R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell10.Multiline = True
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StylePriority.UseBorders = False
            Me.tableCell10.StylePriority.UseTextAlignment = False
            Me.tableCell10.Text = "Change From Prior Year"
            Me.tableCell10.Weight = 3.1216591210081677R
            ' 
            ' tableCell12
            ' 
            Me.tableCell12.Multiline = True
            Me.tableCell12.Name = "tableCell12"
            Me.tableCell12.StylePriority.UseTextAlignment = False
            Me.tableCell12.Text = "Current Market Share"
            Me.tableCell12.Weight = 2.0602940017162554R
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((215)))))), (CInt(((CByte((220)))))), (CInt(((CByte((229)))))))
            Me.tableRow1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6})
            Me.tableRow1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((148)))))), (CInt(((CByte((154)))))), (CInt(((CByte((172)))))))
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.StylePriority.UseBorderColor = False
            Me.tableRow1.StylePriority.UseBorders = False
            Me.tableRow1.StylePriority.UseBorderWidth = False
            Me.tableRow1.StylePriority.UseForeColor = False
            Me.tableRow1.Weight = 6.4912226244229609R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide)
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StylePriority.UseBorders = False
            Me.tableCell1.Text = "Region"
            Me.tableCell1.Weight = 2.9343590482749389R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StylePriority.UseBorders = False
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.Text = "March"
            Me.tableCell2.Weight = 1.560829246522067R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StylePriority.UseBorders = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "September"
            Me.tableCell3.Weight = 1.5608292471577983R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StylePriority.UseBorders = False
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "March"
            Me.tableCell4.Weight = 1.5608292487471154R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell5.Multiline = True
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.StylePriority.UseTextAlignment = False
            Me.tableCell5.Text = "September"
            Me.tableCell5.Weight = 1.5608292566851554R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCell6.Multiline = True
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StylePriority.UseBorders = False
            Me.tableCell6.StylePriority.UseTextAlignment = False
            Me.tableCell6.Text = "Market Share"
            Me.tableCell6.Weight = 2.0602929345484107R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((110)))))), (CInt(((CByte((116)))))), (CInt(((CByte((128)))))))
            Me.tableRow3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableRow3.BorderWidth = 2F
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.StylePriority.UseBorderColor = False
            Me.tableRow3.StylePriority.UseBorders = False
            Me.tableRow3.StylePriority.UseBorderWidth = False
            Me.tableRow3.Weight = 0.40570144920414519R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Multiline = True
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.Weight = 11.237968981935484R
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((248)))))), (CInt(((CByte((250)))))))
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' GroupFooter
            ' 
            Me.GroupFooter.HeightF = 1.041667F
            Me.GroupFooter.Name = "GroupFooter"
            Me.GroupFooter.RepeatEveryPage = True
            ' 
            ' xrCrossBandLine1
            ' 
            Me.xrCrossBandLine1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
            Me.xrCrossBandLine1.EndBand = Me.GroupFooter
            Me.xrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrCrossBandLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((215)))))), (CInt(((CByte((220)))))), (CInt(((CByte((229)))))))
            Me.xrCrossBandLine1.Name = "xrCrossBandLine1"
            Me.xrCrossBandLine1.StartBand = Me.GroupHeader
            Me.xrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(0F, 66F)
            Me.xrCrossBandLine1.WidthF = 1F
            ' 
            ' xrCrossBandLine2
            ' 
            Me.xrCrossBandLine2.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandLine2.EndBand = Me.GroupFooter
            Me.xrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0F, 1.041667F)
            Me.xrCrossBandLine2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((215)))))), (CInt(((CByte((220)))))), (CInt(((CByte((229)))))))
            Me.xrCrossBandLine2.Name = "xrCrossBandLine2"
            Me.xrCrossBandLine2.StartBand = Me.GroupFooter
            Me.xrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrCrossBandLine2.WidthF = 900F
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataMember = "GetData"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.HierarchicalReport.DataSource)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader, Me.GroupFooter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.xrCrossBandLine2, Me.xrCrossBandLine1})
            Me.DataSource = Me.objectDataSource1
            Me.DisplayName = "Hierarchical Report"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 85, 85)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EvenStyle})
            Me.Version = "21.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private label6 As DevExpress.XtraReports.UI.XRLabel

        Private label5 As DevExpress.XtraReports.UI.XRLabel

        Private label4 As DevExpress.XtraReports.UI.XRLabel

        Private label3 As DevExpress.XtraReports.UI.XRLabel

        Private label2 As DevExpress.XtraReports.UI.XRLabel

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private label7 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupFooter As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine

        Private xrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    End Class
End Namespace
