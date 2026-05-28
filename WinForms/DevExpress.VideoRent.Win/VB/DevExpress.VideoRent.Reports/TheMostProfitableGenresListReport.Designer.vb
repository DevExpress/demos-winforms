Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class TheMostProfitableGenresListReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrGroupSortingSummary1 As New DevExpress.XtraReports.UI.XRGroupSortingSummary()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TheMostProfitableGenresListReport))
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTableFilmInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellMovieTitle = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRevenue = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowFilmInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellCover = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBoxCover = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCellMovie = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableFilmFullInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowFilmTitleAndReleaseDate = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellReleaseDateLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellReleaseDate = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowTagLine = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPlotLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellPlot = New DevExpress.XtraReports.UI.XRTableCell()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabelHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.xpCollectionMovies = New DevExpress.Xpo.XPCollection()
			Me.GroupHeaderGenreGroup = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
			Me.xrLabelTotalRevenueLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabelTotalRevenue = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableFilmFullInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableFilmInfo})
			Me.Detail.HeightF = 175F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableFilmInfo
			' 
			Me.xrTableFilmInfo.BorderColor = System.Drawing.Color.White
			Me.xrTableFilmInfo.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableFilmInfo.BorderWidth = 1
			Me.xrTableFilmInfo.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableFilmInfo.KeepTogether = True
			Me.xrTableFilmInfo.LocationFloat = New DevExpress.Utils.PointFloat(1.589457E-05F, 0F)
			Me.xrTableFilmInfo.Name = "xrTableFilmInfo"
			Me.xrTableFilmInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRowFilmInfo})
			Me.xrTableFilmInfo.SizeF = New System.Drawing.SizeF(650F, 175F)
			Me.xrTableFilmInfo.StylePriority.UseBorderColor = False
			Me.xrTableFilmInfo.StylePriority.UseBorders = False
			Me.xrTableFilmInfo.StylePriority.UseBorderWidth = False
			Me.xrTableFilmInfo.StylePriority.UseFont = False
			Me.xrTableFilmInfo.StylePriority.UseTextAlignment = False
			Me.xrTableFilmInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellMovieTitle, Me.xrTableCellRevenue})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 0.27777777353922528
			' 
			' xrTableCellMovieTitle
			' 
			Me.xrTableCellMovieTitle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(193))))))
			Me.xrTableCellMovieTitle.BorderColor = System.Drawing.Color.White
			Me.xrTableCellMovieTitle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellMovieTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Title")})
			Me.xrTableCellMovieTitle.Font = New DevExpress.Drawing.DXFont("Verdana", 9F)
			Me.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle"
			Me.xrTableCellMovieTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			Me.xrTableCellMovieTitle.StylePriority.UseBackColor = False
			Me.xrTableCellMovieTitle.StylePriority.UseBorderColor = False
			Me.xrTableCellMovieTitle.StylePriority.UseBorders = False
			Me.xrTableCellMovieTitle.StylePriority.UseFont = False
			Me.xrTableCellMovieTitle.StylePriority.UseForeColor = False
			Me.xrTableCellMovieTitle.StylePriority.UsePadding = False
			Me.xrTableCellMovieTitle.StylePriority.UseTextAlignment = False
			Me.xrTableCellMovieTitle.Text = "xrTableCellMovieTitle"
			Me.xrTableCellMovieTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellMovieTitle.Weight = 3.0486482764362184
			' 
			' xrTableCellRevenue
			' 
			Me.xrTableCellRevenue.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(193))))))
			Me.xrTableCellRevenue.BorderColor = System.Drawing.Color.White
			Me.xrTableCellRevenue.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRevenue.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableCellRevenue.Name = "xrTableCellRevenue"
			Me.xrTableCellRevenue.StylePriority.UseBackColor = False
			Me.xrTableCellRevenue.StylePriority.UseBorderColor = False
			Me.xrTableCellRevenue.StylePriority.UseBorders = False
			Me.xrTableCellRevenue.StylePriority.UseFont = False
			Me.xrTableCellRevenue.StylePriority.UseForeColor = False
			Me.xrTableCellRevenue.Text = "Revenue: "
			Me.xrTableCellRevenue.Weight = 1.1675674250181261
			' 
			' xrTableRowFilmInfo
			' 
			Me.xrTableRowFilmInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellCover, Me.xrTableCellMovie})
			Me.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo"
			Me.xrTableRowFilmInfo.Weight = 1.7222222264607747
			' 
			' xrTableCellCover
			' 
			Me.xrTableCellCover.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellCover.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBoxCover})
			Me.xrTableCellCover.Name = "xrTableCellCover"
			Me.xrTableCellCover.StylePriority.UseBorders = False
			Me.xrTableCellCover.Text = "xrTableCellPhoto"
			Me.xrTableCellCover.Weight = 0.77837832493913406
			' 
			' xrPictureBoxCover
			' 
			Me.xrPictureBoxCover.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(213))))))
			Me.xrPictureBoxCover.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictureBoxCover.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photo")})
			Me.xrPictureBoxCover.LocationFloat = New DevExpress.Utils.PointFloat(1.818989E-12F, 1.144409E-05F)
			Me.xrPictureBoxCover.Name = "xrPictureBoxCover"
			Me.xrPictureBoxCover.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F)
			Me.xrPictureBoxCover.SizeF = New System.Drawing.SizeF(120F, 150.6944F)
			Me.xrPictureBoxCover.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
			Me.xrPictureBoxCover.StylePriority.UseBackColor = False
			Me.xrPictureBoxCover.StylePriority.UseBorders = False
			Me.xrPictureBoxCover.StylePriority.UsePadding = False
'			Me.xrPictureBoxCover.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictureBoxCover_BeforePrint);
			' 
			' xrTableCellMovie
			' 
			Me.xrTableCellMovie.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellMovie.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableFilmFullInfo})
			Me.xrTableCellMovie.Font = New DevExpress.Drawing.DXFont("Calibri", 12F)
			Me.xrTableCellMovie.Multiline = True
			Me.xrTableCellMovie.Name = "xrTableCellMovie"
			Me.xrTableCellMovie.StylePriority.UseBorders = False
			Me.xrTableCellMovie.StylePriority.UseFont = False
			Me.xrTableCellMovie.Text = "xrTableCellMovie"
			Me.xrTableCellMovie.Weight = 3.43783737651521
			' 
			' xrTableFilmFullInfo
			' 
			Me.xrTableFilmFullInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableFilmFullInfo.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1.144409E-05F)
			Me.xrTableFilmFullInfo.Name = "xrTableFilmFullInfo"
			Me.xrTableFilmFullInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowFilmTitleAndReleaseDate, Me.xrTableRowTagLine})
			Me.xrTableFilmFullInfo.SizeF = New System.Drawing.SizeF(530.0001F, 150.6945F)
			Me.xrTableFilmFullInfo.StylePriority.UseBorders = False
			Me.xrTableFilmFullInfo.StylePriority.UseTextAlignment = False
			Me.xrTableFilmFullInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
			' 
			' xrTableRowFilmTitleAndReleaseDate
			' 
			Me.xrTableRowFilmTitleAndReleaseDate.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableRowFilmTitleAndReleaseDate.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellReleaseDateLabel, Me.xrTableCellReleaseDate})
			Me.xrTableRowFilmTitleAndReleaseDate.Name = "xrTableRowFilmTitleAndReleaseDate"
			Me.xrTableRowFilmTitleAndReleaseDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F)
			Me.xrTableRowFilmTitleAndReleaseDate.StylePriority.UseBorders = False
			Me.xrTableRowFilmTitleAndReleaseDate.StylePriority.UsePadding = False
			Me.xrTableRowFilmTitleAndReleaseDate.StylePriority.UseTextAlignment = False
			Me.xrTableRowFilmTitleAndReleaseDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableRowFilmTitleAndReleaseDate.Weight = 0.11788778790443251
			' 
			' xrTableCellReleaseDateLabel
			' 
			Me.xrTableCellReleaseDateLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellReleaseDateLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellReleaseDateLabel.BorderWidth = 1
			Me.xrTableCellReleaseDateLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
			Me.xrTableCellReleaseDateLabel.Name = "xrTableCellReleaseDateLabel"
			Me.xrTableCellReleaseDateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			Me.xrTableCellReleaseDateLabel.StylePriority.UseBackColor = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseBorders = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseBorderWidth = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseFont = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UsePadding = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellReleaseDateLabel.Text = "Date:"
			Me.xrTableCellReleaseDateLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			Me.xrTableCellReleaseDateLabel.Weight = 0.40829361735037595
			' 
			' xrTableCellReleaseDate
			' 
			Me.xrTableCellReleaseDate.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellReleaseDate.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellReleaseDate.BorderWidth = 1
			Me.xrTableCellReleaseDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReleaseDate", "{0:d}")})
			Me.xrTableCellReleaseDate.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
			Me.xrTableCellReleaseDate.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(85))))), (CInt(Fix((CByte(74))))), (CInt(Fix((CByte(68))))))
			Me.xrTableCellReleaseDate.Name = "xrTableCellReleaseDate"
			Me.xrTableCellReleaseDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCellReleaseDate.StylePriority.UseBackColor = False
			Me.xrTableCellReleaseDate.StylePriority.UseBorders = False
			Me.xrTableCellReleaseDate.StylePriority.UseBorderWidth = False
			Me.xrTableCellReleaseDate.StylePriority.UseFont = False
			Me.xrTableCellReleaseDate.StylePriority.UseForeColor = False
			Me.xrTableCellReleaseDate.StylePriority.UsePadding = False
			Me.xrTableCellReleaseDate.StylePriority.UseTextAlignment = False
			Me.xrTableCellReleaseDate.Text = "xrTableCellReleaseDate"
			Me.xrTableCellReleaseDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			Me.xrTableCellReleaseDate.Weight = 2.5917063826496238
			' 
			' xrTableRowTagLine
			' 
			Me.xrTableRowTagLine.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPlotLabel, Me.xrTableCellPlot})
			Me.xrTableRowTagLine.Name = "xrTableRowTagLine"
			Me.xrTableRowTagLine.Weight = 0.47428028811004519
			' 
			' xrTableCellPlotLabel
			' 
			Me.xrTableCellPlotLabel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellPlotLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCellPlotLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
			Me.xrTableCellPlotLabel.Name = "xrTableCellPlotLabel"
			Me.xrTableCellPlotLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 10, 100F)
			Me.xrTableCellPlotLabel.StylePriority.UseBackColor = False
			Me.xrTableCellPlotLabel.StylePriority.UseBorders = False
			Me.xrTableCellPlotLabel.StylePriority.UseFont = False
			Me.xrTableCellPlotLabel.StylePriority.UsePadding = False
			Me.xrTableCellPlotLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellPlotLabel.Text = "Info:"
			Me.xrTableCellPlotLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellPlotLabel.Weight = 0.40829380889109568
			' 
			' xrTableCellPlot
			' 
			Me.xrTableCellPlot.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(220))))))
			Me.xrTableCellPlot.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCellPlot.BorderWidth = 1
			Me.xrTableCellPlot.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Plot")})
			Me.xrTableCellPlot.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
			Me.xrTableCellPlot.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(85))))), (CInt(Fix((CByte(74))))), (CInt(Fix((CByte(68))))))
			Me.xrTableCellPlot.Name = "xrTableCellPlot"
			Me.xrTableCellPlot.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 100F)
			Me.xrTableCellPlot.StylePriority.UseBackColor = False
			Me.xrTableCellPlot.StylePriority.UseBorders = False
			Me.xrTableCellPlot.StylePriority.UseBorderWidth = False
			Me.xrTableCellPlot.StylePriority.UseFont = False
			Me.xrTableCellPlot.StylePriority.UseForeColor = False
			Me.xrTableCellPlot.StylePriority.UsePadding = False
			Me.xrTableCellPlot.StylePriority.UseTextAlignment = False
			Me.xrTableCellPlot.Text = "xrTableCellPlot"
			Me.xrTableCellPlot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellPlot.Weight = 2.5917061911089045
			' 
			' topMarginBand
			' 
			Me.topMarginBand.HeightF = 46F
			Me.topMarginBand.Name = "topMarginBand"
			' 
			' bottomMarginBand
			' 
			Me.bottomMarginBand.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfoPageCount})
			Me.bottomMarginBand.HeightF = 50F
			Me.bottomMarginBand.Name = "bottomMarginBand"
			' 
			' xrPageInfoPageCount
			' 
			Me.xrPageInfoPageCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(544.5588F, 0F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(105.4412F, 22.99999F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelHeader})
			Me.ReportHeader.HeightF = 35F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabelHeader
			' 
			Me.xrLabelHeader.AutoWidth = True
			Me.xrLabelHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 16F)
			Me.xrLabelHeader.LocationFloat = New DevExpress.Utils.PointFloat(212.5F, 0F)
			Me.xrLabelHeader.Name = "xrLabelHeader"
			Me.xrLabelHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelHeader.SizeF = New System.Drawing.SizeF(232.2916F, 35F)
			Me.xrLabelHeader.StylePriority.UseFont = False
			Me.xrLabelHeader.StylePriority.UseTextAlignment = False
			Me.xrLabelHeader.Text = "Most Profitable Genres"
			Me.xrLabelHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xpCollectionMovies
			' 
			Me.xpCollectionMovies.CaseSensitive = True
			Me.xpCollectionMovies.ObjectType = GetType(DevExpress.VideoRent.Movie)
'			Me.xpCollectionMovies.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionTheMostProfitableGenres_ResolveSession);
			' 
			' GroupHeaderGenreGroup
			' 
			Me.GroupHeaderGenreGroup.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1, Me.xrLabelTotalRevenueLabel, Me.xrLabelTotalRevenue})
			Me.GroupHeaderGenreGroup.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Genre", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeaderGenreGroup.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeaderGenreGroup.HeightF = 59.79176F
			Me.GroupHeaderGenreGroup.Name = "GroupHeaderGenreGroup"
			xrGroupSortingSummary1.Enabled = True
			xrGroupSortingSummary1.FieldName = "MovieId"
			xrGroupSortingSummary1.Function = DevExpress.XtraReports.UI.SortingSummaryFunction.Custom
			xrGroupSortingSummary1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Descending
			Me.GroupHeaderGenreGroup.SortingSummary = xrGroupSortingSummary1
'			Me.GroupHeaderGenreGroup.SortingSummaryReset += New System.EventHandler(Me.GroupHeaderGenreGroup_SortingSummaryReset);
'			Me.GroupHeaderGenreGroup.SortingSummaryGetResult += New DevExpress.XtraReports.UI.GroupSortingSummaryGetResultEventHandler(Me.GroupHeaderGenreGroup_SortingSummaryGetResult);
'			Me.GroupHeaderGenreGroup.SortingSummaryRowChanged += New DevExpress.XtraReports.UI.GroupSortingSummaryRowChangedEventHandler(Me.GroupHeaderGenreGroup_SortingSummaryRowChanged);
			' 
			' xrRichText1
			' 
			Me.xrRichText1.Bookmark = "Genres"
			Me.xrRichText1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Genre")})
			Me.xrRichText1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
			Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10F)
			Me.xrRichText1.Name = "xrRichText1"
			Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
			Me.xrRichText1.SizeF = New System.Drawing.SizeF(630F, 20F)
			Me.xrRichText1.StylePriority.UseFont = False
			' 
			' xrLabelTotalRevenueLabel
			' 
			Me.xrLabelTotalRevenueLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.xrLabelTotalRevenueLabel.LocationFloat = New DevExpress.Utils.PointFloat(225F, 30F)
			Me.xrLabelTotalRevenueLabel.Name = "xrLabelTotalRevenueLabel"
			Me.xrLabelTotalRevenueLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelTotalRevenueLabel.SizeF = New System.Drawing.SizeF(105.6952F, 20F)
			Me.xrLabelTotalRevenueLabel.StylePriority.UseFont = False
			Me.xrLabelTotalRevenueLabel.StylePriority.UseTextAlignment = False
			Me.xrLabelTotalRevenueLabel.Text = "Total Revenue:"
			Me.xrLabelTotalRevenueLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabelTotalRevenue
			' 
			Me.xrLabelTotalRevenue.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MovieId")})
			Me.xrLabelTotalRevenue.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10F)
			Me.xrLabelTotalRevenue.LocationFloat = New DevExpress.Utils.PointFloat(337.5F, 30F)
			Me.xrLabelTotalRevenue.Name = "xrLabelTotalRevenue"
			Me.xrLabelTotalRevenue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelTotalRevenue.SizeF = New System.Drawing.SizeF(82.29166F, 20.00002F)
			Me.xrLabelTotalRevenue.StylePriority.UseFont = False
			Me.xrLabelTotalRevenue.StylePriority.UseTextAlignment = False
			xrSummary1.FormatString = "{0:$0.00}"
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
			xrSummary1.IgnoreNullValues = True
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrLabelTotalRevenue.Summary = xrSummary1
			Me.xrLabelTotalRevenue.Text = "[MovieId]"
			Me.xrLabelTotalRevenue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrLabelTotalRevenue.WordWrap = False
'			Me.xrLabelTotalRevenue.SummaryReset += New System.EventHandler(Me.xrLabelTotalRevenue_SummaryReset);
'			Me.xrLabelTotalRevenue.SummaryRowChanged += New System.EventHandler(Me.xrLabelTotalRevenue_SummaryRowChanged);
'			Me.xrLabelTotalRevenue.SummaryGetResult += New DevExpress.XtraReports.UI.SummaryGetResultHandler(Me.xrLabelTotalRevenue_SummaryGetResult);
			' 
			' TheMostProfitableGenresListReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand, Me.bottomMarginBand, Me.ReportHeader, Me.GroupHeaderGenreGroup})
			Me.Bookmark = "Genres"
			Me.DataSource = Me.xpCollectionMovies
			Me.Extensions.Add("ParametersRequestExtension", "TimePeriodReport")
			Me.Extensions.Add("DataSerializationExtension", "TimePeriodReport")
			Me.Extensions.Add("DataEditorExtension", "TimePeriodReport")
			Me.Extensions.Add("ParameterEditorExtension", "TimePeriodReport")
			Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 46, 50)
			Me.RequestParameters = False
			Me.Version = "10.2"
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableFilmFullInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabelHeader As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xpCollectionMovies As DevExpress.Xpo.XPCollection
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private WithEvents GroupHeaderGenreGroup As DevExpress.XtraReports.UI.GroupHeaderBand
		Private WithEvents xrLabelTotalRevenue As DevExpress.XtraReports.UI.XRLabel
		Private xrTableFilmInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowFilmInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellCover As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrPictureBoxCover As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCellMovie As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableFilmFullInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowFilmTitleAndReleaseDate As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellReleaseDateLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellReleaseDate As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowTagLine As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPlot As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellMovieTitle As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRevenue As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellPlotLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabelTotalRevenueLabel As DevExpress.XtraReports.UI.XRLabel
		Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText
	End Class
End Namespace
