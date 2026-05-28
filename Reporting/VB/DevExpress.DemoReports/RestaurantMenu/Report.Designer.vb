Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.RestaurantMenu

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.RestaurantMenu.Report))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.catLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.subCatLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.CategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.MenuItemName = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DescriptionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SubCategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.emptySpaceLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.emptySpaceLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.HierarchyPrintOptions.Indent = 20.83333F
            Me.Detail.KeepTogether = True
            Me.Detail.MultiColumn.ColumnCount = 2
            Me.Detail.MultiColumn.ColumnWidth = 370F
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1, Me.SubBand2})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.SubBand1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CategoryName] != 'DRINKS'")})
            Me.SubBand1.HeightF = 65F
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(78.12F, 24.33334F)
            Me.table1.Name = "table1"
            Me.table1.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.StretchPreviousCell
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1, Me.tableRow2})
            Me.table1.SizeF = New System.Drawing.SizeF(291.4987F, 40.66666F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.StyleName = "MenuItemName"
            Me.tableRow1.Weight = 0.66666666666666674R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")})
            Me.tableCell1.Multiline = True
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.tableCell1.StylePriority.UsePadding = False
            Me.tableCell1.Weight = 2.7551925277709959R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")})
            Me.tableCell2.Multiline = True
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell2.TextFormatString = "{0:c2}"
            Me.tableCell2.Weight = 0.57564048767089859R
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.BackColor = System.Drawing.Color.Transparent
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.StylePriority.UseBackColor = False
            Me.tableRow2.Weight = 0.95999997456868491R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.CanShrink = True
            Me.tableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.tableCell3.Multiline = True
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F)
            Me.tableCell3.StyleName = "DescriptionStyle"
            Me.tableCell3.StylePriority.UseBackColor = False
            Me.tableCell3.StylePriority.UseFont = False
            Me.tableCell3.StylePriority.UsePadding = False
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            Me.tableCell3.Weight = 2.7055612179497381R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.CanShrink = True
            Me.tableCell4.Multiline = True
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.tableCell4.Weight = 0.56527179749215639R
            ' 
            ' SubBand2
            ' 
            Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.SubBand2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CategoryName] == 'DRINKS'")})
            Me.SubBand2.HeightF = 28.6F
            Me.SubBand2.Name = "SubBand2"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(78.12F, 11.93334F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.StretchPreviousCell
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(291.4987F, 16.66666F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.StyleName = "MenuItemName"
            Me.xrTableRow1.Weight = 0.66666666666666674R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")})
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.Weight = 2.7551925277709959R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")})
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell2.TextFormatString = "{0:c2}"
            Me.xrTableCell2.Weight = 0.57564048767089859R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 20F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 25.94191F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
            Me.ReportHeader.HeightF = 308F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(296.875F, 61.45832F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(208.3333F, 208.3333F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.UseImageResolution = False
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.catLabel1, Me.xrPictureBox2})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.None)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 74.08306F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Level = 1
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' catLabel1
            ' 
            Me.catLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
            Me.catLabel1.CanGrow = False
            Me.catLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.catLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.catLabel1.LocationFloat = New DevExpress.Utils.PointFloat(78.12F, 45.91637F)
            Me.catLabel1.Name = "catLabel1"
            Me.catLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.catLabel1.SizeF = New System.Drawing.SizeF(291.5037F, 24F)
            Me.catLabel1.StyleName = "CategoryStyle"
            Me.catLabel1.StylePriority.UseBackColor = False
            Me.catLabel1.StylePriority.UseBorderDashStyle = False
            Me.catLabel1.StylePriority.UseBorders = False
            Me.catLabel1.StylePriority.UseFont = False
            Me.catLabel1.StylePriority.UsePadding = False
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(78.12F, 69.9164F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(291.6667F, 4.166667F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox2.UseImageResolution = False
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.subCatLabel1})
            Me.GroupHeader2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([SubCategoryName])")})
            Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SubCategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.None)})
            Me.GroupHeader2.HeightF = 54.62502F
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' subCatLabel1
            ' 
            Me.subCatLabel1.CanGrow = False
            Me.subCatLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([SubCategoryName])")})
            Me.subCatLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.subCatLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((152)))))), (CInt(((CByte((157)))))), (CInt(((CByte((159)))))))
            Me.subCatLabel1.LocationFloat = New DevExpress.Utils.PointFloat(78.12001F, 40.00003F)
            Me.subCatLabel1.Multiline = True
            Me.subCatLabel1.Name = "subCatLabel1"
            Me.subCatLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.subCatLabel1.SizeF = New System.Drawing.SizeF(291.5037F, 14.625F)
            Me.subCatLabel1.StylePriority.UseBackColor = False
            Me.subCatLabel1.StylePriority.UseFont = False
            Me.subCatLabel1.StylePriority.UseForeColor = False
            Me.subCatLabel1.StylePriority.UsePadding = False
            ' 
            ' CategoryStyle
            ' 
            Me.CategoryStyle.Font = New DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.CategoryStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((188)))))), (CInt(((CByte((136)))))), (CInt(((CByte((100)))))))
            Me.CategoryStyle.Name = "CategoryStyle"
            Me.CategoryStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' MenuItemName
            ' 
            Me.MenuItemName.Font = New DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.MenuItemName.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((78)))))), (CInt(((CByte((85)))))))
            Me.MenuItemName.Name = "MenuItemName"
            Me.MenuItemName.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' DescriptionStyle
            ' 
            Me.DescriptionStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8F)
            Me.DescriptionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((152)))))), (CInt(((CByte((157)))))), (CInt(((CByte((159)))))))
            Me.DescriptionStyle.Name = "DescriptionStyle"
            Me.DescriptionStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' SubCategoryStyle
            ' 
            Me.SubCategoryStyle.Font = New DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.SubCategoryStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((152)))))), (CInt(((CByte((157)))))), (CInt(((CByte((159)))))))
            Me.SubCategoryStyle.Name = "SubCategoryStyle"
            Me.SubCategoryStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' xrCrossBandBox1
            ' 
            Me.xrCrossBandBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.xrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((188)))))), (CInt(((CByte((136)))))), (CInt(((CByte((100)))))))
            Me.xrCrossBandBox1.EndBand = Me.BottomMargin
            Me.xrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.xrCrossBandBox1.Name = "xrCrossBandBox1"
            Me.xrCrossBandBox1.StartBand = Me.TopMargin
            Me.xrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(0F, 18F)
            Me.xrCrossBandBox1.WidthF = 809.0001F
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.emptySpaceLabel2})
            Me.PageFooter.HeightF = 75F
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            ' 
            ' emptySpaceLabel2
            ' 
            Me.emptySpaceLabel2.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
            Me.emptySpaceLabel2.Multiline = True
            Me.emptySpaceLabel2.Name = "emptySpaceLabel2"
            Me.emptySpaceLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.emptySpaceLabel2.SizeF = New System.Drawing.SizeF(2.083333F, 2.083333F)
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.emptySpaceLabel1})
            Me.PageHeader.HeightF = 75F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader
            ' 
            ' emptySpaceLabel1
            ' 
            Me.emptySpaceLabel1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
            Me.emptySpaceLabel1.Multiline = True
            Me.emptySpaceLabel1.Name = "emptySpaceLabel1"
            Me.emptySpaceLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.emptySpaceLabel1.SizeF = New System.Drawing.SizeF(2.083333F, 2.083333F)
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.DataMember = "GetMenuData"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.RestaurantMenu.DataSource)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.PrintAtBottom = True
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.CanGrow = False
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(78.12F, 29.16667F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(661.0835F, 31.24998F)
            Me.xrLabel1.StyleName = "DescriptionStyle"
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "We take pride in preparing our food from scratch every day. Some items will have " & "limited availability. If you have allergies, please alert us as not all ingredie" & "nts are listed."
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.PageFooter, Me.PageHeader, Me.ReportFooter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.xrCrossBandBox1})
            Me.DataSource = Me.objectDataSource1
            Me.ExportOptions.Pdf.ConvertImagesToJpeg = False
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.25F)
            Me.Margins = New DevExpress.Drawing.DXMargins(20, 20, 20, 26)
            Me.PageColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((254)))))), (CInt(((CByte((252)))))))
            Me.SnapGridSize = 13.02083F
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.CategoryStyle, Me.MenuItemName, Me.DescriptionStyle, Me.SubCategoryStyle})
            Me.Version = "19.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private catLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private CategoryStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private MenuItemName As DevExpress.XtraReports.UI.XRControlStyle

        Private DescriptionStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private SubCategoryStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private subCatLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private emptySpaceLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private emptySpaceLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private SubBand2 As DevExpress.XtraReports.UI.SubBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
