Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class FilmInfoCardReport
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
			Dim code128Generator1 As New DevExpress.XtraPrinting.BarCode.Code128Generator()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPanelFilmInfoCard = New DevExpress.XtraReports.UI.XRPanel()
			Me.xrLabelMovieTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTableFilmInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowGenreInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellGenreLable = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellGenre = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowYearInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellYearLable = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellYear = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowRatingInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellRatingLable = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRating = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowLocationInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellLocationLable = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellLocation = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrBarCodeMoviItemId = New DevExpress.XtraReports.UI.XRBarCode()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xpCollectionMovieItems = New DevExpress.Xpo.XPCollection()
			Me.xpCollectionMovies = New DevExpress.Xpo.XPCollection()
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionMovieItems, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanelFilmInfoCard})
			Me.Detail.HeightF = 174F
			Me.Detail.MultiColumn.ColumnCount = 2
			Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
			Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPanelFilmInfoCard
			' 
			Me.xrPanelFilmInfoCard.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(204))))))
			Me.xrPanelFilmInfoCard.BorderColor = System.Drawing.Color.White
			Me.xrPanelFilmInfoCard.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.xrPanelFilmInfoCard.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelMovieTitle, Me.xrTableFilmInfo, Me.xrBarCodeMoviItemId})
			Me.xrPanelFilmInfoCard.LocationFloat = New DevExpress.Utils.PointFloat(10F, 7F)
			Me.xrPanelFilmInfoCard.Name = "xrPanelFilmInfoCard"
			Me.xrPanelFilmInfoCard.SizeF = New System.Drawing.SizeF(354.3334F, 160F)
			Me.xrPanelFilmInfoCard.StylePriority.UseBackColor = False
			Me.xrPanelFilmInfoCard.StylePriority.UseBorderColor = False
			Me.xrPanelFilmInfoCard.StylePriority.UseBorders = False
			' 
			' xrLabelMovieTitle
			' 
			Me.xrLabelMovieTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabelMovieTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Movie.Title")})
			Me.xrLabelMovieTitle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrLabelMovieTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 10.00001F)
			Me.xrLabelMovieTitle.Name = "xrLabelMovieTitle"
			Me.xrLabelMovieTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrLabelMovieTitle.SizeF = New System.Drawing.SizeF(255.097F, 31.33333F)
			Me.xrLabelMovieTitle.StylePriority.UseBorders = False
			Me.xrLabelMovieTitle.StylePriority.UseFont = False
			Me.xrLabelMovieTitle.StylePriority.UsePadding = False
			Me.xrLabelMovieTitle.StylePriority.UseTextAlignment = False
			Me.xrLabelMovieTitle.Text = "xrLabelMovieTitle"
			Me.xrLabelMovieTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableFilmInfo
			' 
			Me.xrTableFilmInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableFilmInfo.BorderWidth = 1
			Me.xrTableFilmInfo.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25F)
			Me.xrTableFilmInfo.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 51.87505F)
			Me.xrTableFilmInfo.Name = "xrTableFilmInfo"
			Me.xrTableFilmInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowGenreInfo, Me.xrTableRowYearInfo, Me.xrTableRowRatingInfo, Me.xrTableRowLocationInfo})
			Me.xrTableFilmInfo.SizeF = New System.Drawing.SizeF(255.097F, 80F)
			Me.xrTableFilmInfo.StylePriority.UseBorders = False
			Me.xrTableFilmInfo.StylePriority.UseBorderWidth = False
			Me.xrTableFilmInfo.StylePriority.UseFont = False
			Me.xrTableFilmInfo.StylePriority.UseTextAlignment = False
			Me.xrTableFilmInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableRowGenreInfo
			' 
			Me.xrTableRowGenreInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellGenreLable, Me.xrTableCellGenre})
			Me.xrTableRowGenreInfo.Name = "xrTableRowGenreInfo"
			Me.xrTableRowGenreInfo.Weight = 0.17450354620551689
			' 
			' xrTableCellGenreLable
			' 
			Me.xrTableCellGenreLable.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellGenreLable.Name = "xrTableCellGenreLable"
			Me.xrTableCellGenreLable.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
			Me.xrTableCellGenreLable.StylePriority.UseFont = False
			Me.xrTableCellGenreLable.StylePriority.UsePadding = False
			Me.xrTableCellGenreLable.StylePriority.UseTextAlignment = False
			Me.xrTableCellGenreLable.Text = "GENRE:"
			Me.xrTableCellGenreLable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellGenreLable.Weight = 0.875170230911391
			' 
			' xrTableCellGenre
			' 
			Me.xrTableCellGenre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Movie.Genre")})
			Me.xrTableCellGenre.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellGenre.Multiline = True
			Me.xrTableCellGenre.Name = "xrTableCellGenre"
			Me.xrTableCellGenre.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTableCellGenre.StylePriority.UseFont = False
			Me.xrTableCellGenre.StylePriority.UsePadding = False
			Me.xrTableCellGenre.Text = "xrTableCellGenre"
			Me.xrTableCellGenre.Weight = 2.1248297690886089
			' 
			' xrTableRowYearInfo
			' 
			Me.xrTableRowYearInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellYearLable, Me.xrTableCellYear})
			Me.xrTableRowYearInfo.Name = "xrTableRowYearInfo"
			Me.xrTableRowYearInfo.Weight = 0.17450354408026392
			' 
			' xrTableCellYearLable
			' 
			Me.xrTableCellYearLable.CanGrow = False
			Me.xrTableCellYearLable.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellYearLable.Name = "xrTableCellYearLable"
			Me.xrTableCellYearLable.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
			Me.xrTableCellYearLable.StylePriority.UseFont = False
			Me.xrTableCellYearLable.StylePriority.UsePadding = False
			Me.xrTableCellYearLable.StylePriority.UseTextAlignment = False
			Me.xrTableCellYearLable.Text = "YEAR:"
			Me.xrTableCellYearLable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellYearLable.Weight = 0.875170230911391
			' 
			' xrTableCellYear
			' 
			Me.xrTableCellYear.CanGrow = False
			Me.xrTableCellYear.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Movie.ReleaseDate", "{0:yyyy}")})
			Me.xrTableCellYear.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellYear.Multiline = True
			Me.xrTableCellYear.Name = "xrTableCellYear"
			Me.xrTableCellYear.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTableCellYear.StylePriority.UseFont = False
			Me.xrTableCellYear.StylePriority.UsePadding = False
			Me.xrTableCellYear.Text = "xrTableCellYear"
			Me.xrTableCellYear.Weight = 2.1248297690886089
			' 
			' xrTableRowRatingInfo
			' 
			Me.xrTableRowRatingInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellRatingLable, Me.xrTableCellRating})
			Me.xrTableRowRatingInfo.Name = "xrTableRowRatingInfo"
			Me.xrTableRowRatingInfo.Weight = 0.17450354098189264
			' 
			' xrTableCellRatingLable
			' 
			Me.xrTableCellRatingLable.CanGrow = False
			Me.xrTableCellRatingLable.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellRatingLable.Name = "xrTableCellRatingLable"
			Me.xrTableCellRatingLable.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
			Me.xrTableCellRatingLable.StylePriority.UseFont = False
			Me.xrTableCellRatingLable.StylePriority.UsePadding = False
			Me.xrTableCellRatingLable.StylePriority.UseTextAlignment = False
			Me.xrTableCellRatingLable.Text = "RATING:"
			Me.xrTableCellRatingLable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellRatingLable.Weight = 0.875170230911391
			' 
			' xrTableCellRating
			' 
			Me.xrTableCellRating.CanGrow = False
			Me.xrTableCellRating.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Movie.Rating")})
			Me.xrTableCellRating.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellRating.Multiline = True
			Me.xrTableCellRating.Name = "xrTableCellRating"
			Me.xrTableCellRating.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTableCellRating.StylePriority.UseFont = False
			Me.xrTableCellRating.StylePriority.UsePadding = False
			Me.xrTableCellRating.Text = "xrTableCellRating"
			Me.xrTableCellRating.Weight = 2.1248297690886089
			' 
			' xrTableRowLocationInfo
			' 
			Me.xrTableRowLocationInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellLocationLable, Me.xrTableCellLocation})
			Me.xrTableRowLocationInfo.Name = "xrTableRowLocationInfo"
			Me.xrTableRowLocationInfo.Weight = 0.17450354098189264
			' 
			' xrTableCellLocationLable
			' 
			Me.xrTableCellLocationLable.CanGrow = False
			Me.xrTableCellLocationLable.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellLocationLable.Name = "xrTableCellLocationLable"
			Me.xrTableCellLocationLable.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
			Me.xrTableCellLocationLable.StylePriority.UseFont = False
			Me.xrTableCellLocationLable.StylePriority.UsePadding = False
			Me.xrTableCellLocationLable.StylePriority.UseTextAlignment = False
			Me.xrTableCellLocationLable.Text = "LOCATION:"
			Me.xrTableCellLocationLable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellLocationLable.Weight = 0.875170230911391
			' 
			' xrTableCellLocation
			' 
			Me.xrTableCellLocation.CanGrow = False
			Me.xrTableCellLocation.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Location")})
			Me.xrTableCellLocation.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellLocation.Multiline = True
			Me.xrTableCellLocation.Name = "xrTableCellLocation"
			Me.xrTableCellLocation.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTableCellLocation.StylePriority.UseFont = False
			Me.xrTableCellLocation.StylePriority.UsePadding = False
			Me.xrTableCellLocation.Text = "xrTableCellLocation"
			Me.xrTableCellLocation.Weight = 2.1248297690886089
			' 
			' xrBarCodeMoviItemId
			' 
			Me.xrBarCodeMoviItemId.AutoModule = True
			Me.xrBarCodeMoviItemId.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(203))))))
			Me.xrBarCodeMoviItemId.BarCodeOrientation = DevExpress.XtraPrinting.BarCode.BarCodeOrientation.RotateLeft
			Me.xrBarCodeMoviItemId.BorderColor = System.Drawing.Color.White
			Me.xrBarCodeMoviItemId.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.xrBarCodeMoviItemId.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrBarCodeMoviItemId.LocationFloat = New DevExpress.Utils.PointFloat(275.5136F, 3.33786E-06F)
			Me.xrBarCodeMoviItemId.Name = "xrBarCodeMoviItemId"
			Me.xrBarCodeMoviItemId.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 10, 10, 100F)
			Me.xrBarCodeMoviItemId.SizeF = New System.Drawing.SizeF(78.81982F, 160F)
			Me.xrBarCodeMoviItemId.StylePriority.UseBackColor = False
			Me.xrBarCodeMoviItemId.StylePriority.UseBorderColor = False
			Me.xrBarCodeMoviItemId.StylePriority.UseBorders = False
			Me.xrBarCodeMoviItemId.StylePriority.UseFont = False
			Me.xrBarCodeMoviItemId.StylePriority.UsePadding = False
			Me.xrBarCodeMoviItemId.StylePriority.UseTextAlignment = False
			Me.xrBarCodeMoviItemId.Symbology = code128Generator1
			Me.xrBarCodeMoviItemId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
'			Me.xrBarCodeMoviItemId.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrBarCode2_BeforePrint);
			' 
			' topMarginBand
			' 
			Me.topMarginBand.HeightF = 23F
			Me.topMarginBand.Name = "topMarginBand"
			' 
			' bottomMarginBand
			' 
			Me.bottomMarginBand.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfoPageCount})
			Me.bottomMarginBand.HeightF = 37.08331F
			Me.bottomMarginBand.Name = "bottomMarginBand"
			' 
			' xrPageInfoPageCount
			' 
			Me.xrPageInfoPageCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(666.7084F, 2.000014F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(82.29163F, 23F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xpCollectionMovieItems
			' 
			Me.xpCollectionMovieItems.ObjectType = GetType(DevExpress.VideoRent.MovieItem)
			Me.xpCollectionMovieItems.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[MovieTitle]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
'			Me.xpCollectionMovieItems.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionMovieItems_ResolveSession);
			' 
			' xpCollectionMovies
			' 
			Me.xpCollectionMovies.ObjectType = GetType(DevExpress.VideoRent.Movie)
			Me.xpCollectionMovies.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[Title]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
'			Me.xpCollectionMovies.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionMovies_ResolveSession);
			' 
			' FilmInfoCardReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand, Me.bottomMarginBand})
			Me.DataSource = Me.xpCollectionMovieItems
			Me.FilterString = "[Status] <> 'SoldOut' And [Status] <> 'Damage' And [Status] <> 'Lost'"
			Me.Margins = New DevExpress.Drawing.DXMargins(50, 51, 23, 37)
			Me.RequestParameters = False
			Me.Version = "10.2"
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionMovieItems, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private WithEvents xpCollectionMovieItems As DevExpress.Xpo.XPCollection
		Private xrPanelFilmInfoCard As DevExpress.XtraReports.UI.XRPanel
		Private xrTableFilmInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowGenreInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellGenreLable As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellGenre As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowYearInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellYearLable As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellYear As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowRatingInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellRatingLable As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRating As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowLocationInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellLocationLable As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellLocation As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrBarCodeMoviItemId As DevExpress.XtraReports.UI.XRBarCode
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private WithEvents xpCollectionMovies As DevExpress.Xpo.XPCollection
		Private xrLabelMovieTitle As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
