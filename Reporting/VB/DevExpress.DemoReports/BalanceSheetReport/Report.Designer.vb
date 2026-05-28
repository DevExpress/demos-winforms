Namespace XtraReportsDemos.BalanceSheetReport

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
            Me.components = New System.ComponentModel.Container()
            Dim crossTabColumnDefinition1 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(32.68535F)
            Dim crossTabColumnDefinition2 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(28.19376F)
            Dim crossTabColumnDefinition3 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(110F)
            Dim crossTabColumnField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField = New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
            Dim crossTabDataField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabDataField = New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
            Dim crossTabRowDefinition1 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F)
            Dim crossTabRowField1 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
            Dim crossTabRowField2 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
            Dim crossTabRowField3 As DevExpress.XtraReports.UI.CrossTab.CrossTabRowField = New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrCrossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
            Me.xrCrossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell11 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell12 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.xrCrossTabCell13 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabHeaderCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabHeaderCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabHeaderCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabTotalCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabTotalCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.crossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            Me.CrossTabGeneralStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.CrossTabDataStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.CrossTabTotalStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.CrossTabHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.SubtitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.xrCrossTab1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 42F
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 42F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCrossTab1})
            Me.Detail.HeightF = 181F
            Me.Detail.Name = "Detail"
            ' 
            ' xrCrossTab1
            ' 
            Me.xrCrossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9, Me.xrCrossTabCell10, Me.xrCrossTabCell11, Me.xrCrossTabCell12, Me.xrCrossTabCell13, Me.crossTabHeaderCell1, Me.crossTabCell1, Me.crossTabCell2, Me.crossTabHeaderCell2, Me.crossTabHeaderCell3, Me.crossTabTotalCell1, Me.crossTabTotalCell2, Me.crossTabCell3, Me.crossTabCell4})
            crossTabColumnDefinition1.Visible = False
            crossTabColumnDefinition2.Visible = False
            crossTabColumnDefinition3.Visible = False
            Me.xrCrossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {crossTabColumnDefinition1, crossTabColumnDefinition2, New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(375F), New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(110F), crossTabColumnDefinition3})
            crossTabColumnField1.FieldName = "Date"
            crossTabColumnField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateYear
            Me.xrCrossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() {crossTabColumnField1})
            Me.xrCrossTab1.DataAreaStyleName = "CrossTabDataStyle"
            crossTabDataField1.FieldName = "Value"
            Me.xrCrossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() {crossTabDataField1})
            Me.xrCrossTab1.DataSource = Me.objectDataSource1
            Me.xrCrossTab1.GeneralStyleName = "CrossTabGeneralStyle"
            Me.xrCrossTab1.HeaderAreaStyleName = "CrossTabHeaderStyle"
            Me.xrCrossTab1.LayoutOptions.CornerHeaderDisplayMode = DevExpress.XtraReports.UI.CrossTab.CornerHeaderDisplayMode.None
            Me.xrCrossTab1.LayoutOptions.HierarchicalRowLayout = True
            Me.xrCrossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrCrossTab1.Name = "xrCrossTab1"
            crossTabRowDefinition1.Visible = False
            Me.xrCrossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(28F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F), New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25.5F), crossTabRowDefinition1})
            crossTabRowField1.FieldName = "Type"
            crossTabRowField1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None
            crossTabRowField2.FieldName = "SubType"
            crossTabRowField2.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None
            crossTabRowField3.FieldName = "Name"
            crossTabRowField3.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None
            Me.xrCrossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() {crossTabRowField1, crossTabRowField2, crossTabRowField3})
            Me.xrCrossTab1.SizeF = New System.Drawing.SizeF(655.8791F, 181F)
            Me.xrCrossTab1.TotalAreaStyleName = "CrossTabTotalStyle"
            ' 
            ' xrCrossTabCell2
            ' 
            Me.xrCrossTabCell2.ColumnIndex = 3
            Me.xrCrossTabCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([Arguments.GroupRowIndex] % 2 == 1, Rgb(249, 250, 252), ?)")})
            Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
            Me.xrCrossTabCell2.RowIndex = 3
            Me.xrCrossTabCell2.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' xrCrossTabCell3
            ' 
            Me.xrCrossTabCell3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((241)))))), (CInt(((CByte((243)))))), (CInt(((CByte((248)))))))
            Me.xrCrossTabCell3.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.xrCrossTabCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrCrossTabCell3.BorderWidth = 2F
            Me.xrCrossTabCell3.ColumnIndex = 3
            Me.xrCrossTabCell3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
            Me.xrCrossTabCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 7, 0, 100F)
            Me.xrCrossTabCell3.RowIndex = 0
            Me.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrCrossTabCell4
            ' 
            Me.xrCrossTabCell4.ColumnIndex = 0
            Me.xrCrossTabCell4.ColumnSpan = 3
            Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
            Me.xrCrossTabCell4.RowIndex = 1
            ' 
            ' xrCrossTabCell5
            ' 
            Me.xrCrossTabCell5.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((241)))))), (CInt(((CByte((243)))))), (CInt(((CByte((248)))))))
            Me.xrCrossTabCell5.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.xrCrossTabCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrCrossTabCell5.BorderWidth = 2F
            Me.xrCrossTabCell5.ColumnIndex = 4
            Me.xrCrossTabCell5.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
            Me.xrCrossTabCell5.RowIndex = 0
            Me.xrCrossTabCell5.Text = "Grand Total"
            Me.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrCrossTabCell6
            ' 
            Me.xrCrossTabCell6.ColumnIndex = 4
            Me.xrCrossTabCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([Arguments.GroupRowIndex] % 2 == 1, Rgb(249, 250, 252), ?)")})
            Me.xrCrossTabCell6.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
            Me.xrCrossTabCell6.RowIndex = 3
            Me.xrCrossTabCell6.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' xrCrossTabCell7
            ' 
            Me.xrCrossTabCell7.ColumnIndex = 0
            Me.xrCrossTabCell7.ColumnSpan = 3
            Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
            Me.xrCrossTabCell7.RowIndex = 6
            Me.xrCrossTabCell7.Text = "Grand Total"
            ' 
            ' xrCrossTabCell8
            ' 
            Me.xrCrossTabCell8.ColumnIndex = 3
            Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
            Me.xrCrossTabCell8.RowIndex = 6
            Me.xrCrossTabCell8.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' xrCrossTabCell9
            ' 
            Me.xrCrossTabCell9.ColumnIndex = 4
            Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
            Me.xrCrossTabCell9.RowIndex = 6
            Me.xrCrossTabCell9.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' xrCrossTabCell10
            ' 
            Me.xrCrossTabCell10.ColumnIndex = 2
            Me.xrCrossTabCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([Arguments.GroupRowIndex] % 2 == 1, Rgb(249, 250, 252), ?)")})
            Me.xrCrossTabCell10.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.xrCrossTabCell10.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.xrCrossTabCell10.Name = "xrCrossTabCell10"
            Me.xrCrossTabCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(42, 6, 6, 6, 100F)
            Me.xrCrossTabCell10.RowIndex = 3
            ' 
            ' xrCrossTabCell11
            ' 
            Me.xrCrossTabCell11.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.xrCrossTabCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrCrossTabCell11.BorderWidth = 2F
            Me.xrCrossTabCell11.ColumnIndex = 0
            Me.xrCrossTabCell11.ColumnSpan = 3
            Me.xrCrossTabCell11.Name = "xrCrossTabCell11"
            Me.xrCrossTabCell11.RowIndex = 5
            Me.xrCrossTabCell11.TextFormatString = "Total {0}"
            ' 
            ' xrCrossTabCell12
            ' 
            Me.xrCrossTabCell12.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.xrCrossTabCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrCrossTabCell12.BorderWidth = 2F
            Me.xrCrossTabCell12.ColumnIndex = 3
            Me.xrCrossTabCell12.Name = "xrCrossTabCell12"
            Me.xrCrossTabCell12.RowIndex = 5
            Me.xrCrossTabCell12.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' xrCrossTabCell13
            ' 
            Me.xrCrossTabCell13.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.xrCrossTabCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrCrossTabCell13.BorderWidth = 2F
            Me.xrCrossTabCell13.ColumnIndex = 4
            Me.xrCrossTabCell13.Name = "xrCrossTabCell13"
            Me.xrCrossTabCell13.RowIndex = 5
            Me.xrCrossTabCell13.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' crossTabHeaderCell1
            ' 
            Me.crossTabHeaderCell1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((241)))))), (CInt(((CByte((243)))))), (CInt(((CByte((248)))))))
            Me.crossTabHeaderCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.crossTabHeaderCell1.BorderWidth = 2F
            Me.crossTabHeaderCell1.ColumnIndex = 0
            Me.crossTabHeaderCell1.ColumnSpan = 3
            Me.crossTabHeaderCell1.Name = "crossTabHeaderCell1"
            Me.crossTabHeaderCell1.RowIndex = 0
            ' 
            ' crossTabCell1
            ' 
            Me.crossTabCell1.ColumnIndex = 3
            Me.crossTabCell1.ColumnSpan = 2
            Me.crossTabCell1.Name = "crossTabCell1"
            Me.crossTabCell1.RowIndex = 1
            ' 
            ' crossTabCell2
            ' 
            Me.crossTabCell2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.crossTabCell2.ColumnIndex = 3
            Me.crossTabCell2.ColumnSpan = 2
            Me.crossTabCell2.Name = "crossTabCell2"
            Me.crossTabCell2.RowIndex = 2
            ' 
            ' crossTabHeaderCell2
            ' 
            Me.crossTabHeaderCell2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((250)))))), (CInt(((CByte((252)))))))
            Me.crossTabHeaderCell2.ColumnIndex = 1
            Me.crossTabHeaderCell2.ColumnSpan = 2
            Me.crossTabHeaderCell2.Name = "crossTabHeaderCell2"
            Me.crossTabHeaderCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(24, 6, 6, 6, 100F)
            Me.crossTabHeaderCell2.RowIndex = 2
            ' 
            ' crossTabHeaderCell3
            ' 
            Me.crossTabHeaderCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.crossTabHeaderCell3.BorderWidth = 2F
            Me.crossTabHeaderCell3.ColumnIndex = 1
            Me.crossTabHeaderCell3.ColumnSpan = 2
            Me.crossTabHeaderCell3.Name = "crossTabHeaderCell3"
            Me.crossTabHeaderCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(24, 6, 6, 6, 100F)
            Me.crossTabHeaderCell3.RowIndex = 4
            Me.crossTabHeaderCell3.TextFormatString = "Total {0}"
            ' 
            ' crossTabTotalCell1
            ' 
            Me.crossTabTotalCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.crossTabTotalCell1.BorderWidth = 2F
            Me.crossTabTotalCell1.ColumnIndex = 3
            Me.crossTabTotalCell1.Name = "crossTabTotalCell1"
            Me.crossTabTotalCell1.RowIndex = 4
            Me.crossTabTotalCell1.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' crossTabTotalCell2
            ' 
            Me.crossTabTotalCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.crossTabTotalCell2.BorderWidth = 2F
            Me.crossTabTotalCell2.ColumnIndex = 4
            Me.crossTabTotalCell2.Name = "crossTabTotalCell2"
            Me.crossTabTotalCell2.RowIndex = 4
            Me.crossTabTotalCell2.TextFormatString = "{0:#,##0.00;(#,##0.00);-}"
            ' 
            ' crossTabCell3
            ' 
            Me.crossTabCell3.ColumnIndex = 0
            Me.crossTabCell3.Name = "crossTabCell3"
            Me.crossTabCell3.RowIndex = 2
            Me.crossTabCell3.RowSpan = 3
            ' 
            ' crossTabCell4
            ' 
            Me.crossTabCell4.ColumnIndex = 1
            Me.crossTabCell4.Name = "crossTabCell4"
            Me.crossTabCell4.RowIndex = 3
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataMember = "GetData"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.BalanceSheetReport.BalanceSheetData)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' CrossTabGeneralStyle
            ' 
            Me.CrossTabGeneralStyle.BackColor = System.Drawing.Color.White
            Me.CrossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.CrossTabGeneralStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.CrossTabGeneralStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.CrossTabGeneralStyle.Name = "CrossTabGeneralStyle"
            Me.CrossTabGeneralStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 6, 6, 100F)
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1})
            Me.ReportHeader.HeightF = 70F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel2.CanGrow = False
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 39F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(706.0001F, 18.83332F)
            Me.xrLabel2.StyleName = "SubtitleStyle"
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.Text = "(Dollars in Millions)"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.CanGrow = False
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 25F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(706F, 39F)
            Me.xrLabel1.StyleName = "TitleStyle"
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Balance Sheet"
            ' 
            ' CrossTabDataStyle
            ' 
            Me.CrossTabDataStyle.Name = "CrossTabDataStyle"
            Me.CrossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' CrossTabTotalStyle
            ' 
            Me.CrossTabTotalStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.CrossTabTotalStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((24)))))), (CInt(((CByte((32)))))), (CInt(((CByte((45)))))))
            Me.CrossTabTotalStyle.Name = "CrossTabTotalStyle"
            Me.CrossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' CrossTabHeaderStyle
            ' 
            Me.CrossTabHeaderStyle.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.CrossTabHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((24)))))), (CInt(((CByte((32)))))), (CInt(((CByte((45)))))))
            Me.CrossTabHeaderStyle.Name = "CrossTabHeaderStyle"
            Me.CrossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TitleStyle
            ' 
            Me.TitleStyle.Font = New DevExpress.Drawing.DXFont("Arial", 24F)
            Me.TitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((32)))))), (CInt(((CByte((45)))))))
            Me.TitleStyle.Name = "TitleStyle"
            Me.TitleStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' SubtitleStyle
            ' 
            Me.SubtitleStyle.Font = New DevExpress.Drawing.DXFont("Arial", 7.5F)
            Me.SubtitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((113)))))), (CInt(((CByte((128)))))), (CInt(((CByte((150)))))))
            Me.SubtitleStyle.Name = "SubtitleStyle"
            Me.SubtitleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DisplayName = "Balance Sheet"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(72F, 72F, 42F, 42F)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.CrossTabGeneralStyle, Me.CrossTabDataStyle, Me.CrossTabTotalStyle, Me.CrossTabHeaderStyle, Me.TitleStyle, Me.SubtitleStyle})
            Me.Version = "23.1"
            CType((Me.xrCrossTab1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private xrCrossTab1 As DevExpress.XtraReports.UI.XRCrossTab

        Private xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private CrossTabGeneralStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell11 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell12 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell13 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabHeaderCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private CrossTabDataStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private CrossTabTotalStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private CrossTabHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private TitleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private SubtitleStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private crossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabHeaderCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabTotalCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabTotalCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private xrCrossTabCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell

        Private crossTabHeaderCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
    End Class
End Namespace
